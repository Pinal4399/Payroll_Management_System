Public Class frm_work_timings_schedule

#Region "variables"
    Private dtbworktime, dtbLocation, dtbCompany, dtbProcessPeriod As DataTable
    Dim dtrowworktime As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclsemppayroll As New cls_payroll
    Dim strQry As String
    Dim i, j As Integer
    Dim startdt, enddt As Date
    Dim rptview As Reportviewer
    Dim rpt As New rptlocwisedept
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbworktime = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_work_timings_schedule_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbworktime.GetChanges IsNot Nothing Then
                Dim dlg As Windows.Forms.DialogResult = cls_General.SaveMsg("Do You Want To Save Records ?", Me.Text)
                If dlg = Windows.Forms.DialogResult.Yes Then
                    btnsave_Click(sender, e)
                ElseIf dlg = Windows.Forms.DialogResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub frm_work_timings_schedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)
        i = 0
        dtbProcessPeriod = New DataTable
        strQry = "SELECT period FROM tbl_process_period"
        ObjclsGen.Getdata(masterform.con, strQry, dtbProcessPeriod)
        With cmbprocessperiod
            .DataSource = dtbProcessPeriod
            .DisplayMember = "period"
            .ValueMember = "period"
        End With
        cmbprocessperiod.Text = ""
        cmbprocessperiod.SelectedIndex = -1
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Dim dbReturn As Boolean = True
        Try
            grid_worktime_schedule.EndEdit()
            If cmblocname.SelectedIndex < 0 Then
                MsgBox("Must select Location name", MsgBoxStyle.Critical, Me.Text)
                dbReturn = False
                cmblocname.Focus()
            End If
            If cmbprocessperiod.SelectedIndex < 0 Then
                MsgBox("Must select process Period", MsgBoxStyle.Critical, Me.Text)
                dbReturn = False
                cmbprocessperiod.Focus()
            End If

            If dbReturn Then
                cmblocname.Enabled = False
                masterform.con.Close()
                masterform.con.Open()
                masterform.cmd.CommandText = "SELECT start_date,end_date FROM tbl_process_period WHERE period='" & cmbprocessperiod.Text.Trim & "'"
                masterform.cmd.Connection = masterform.con
                masterform.dr = masterform.cmd.ExecuteReader
                If masterform.dr.HasRows Then
                    masterform.dr.Read()
                    startdt = masterform.dr.Item(0)
                    enddt = masterform.dr.Item(1)
                End If
                masterform.dr.Close()
                masterform.con.Close()
                If Not searchWorktimeData() Then

                    grid_worktime_schedule.AutoGenerateColumns = False
                    grid_worktime_schedule.DataSource = Nothing
                    dtbworktime = Nothing
                    dtbworktime = New DataTable
                    grid_worktime_schedule.DataSource = dtbworktime

                    For i = DatePart("d", startdt) To DatePart("d", enddt)
                        If i > DatePart("d", enddt) Then
                            Exit For
                        Else
                            ObjclsGen.AddnewRow(dtbworktime)
                        End If
                    Next
                    i = 0
                    dtbworktime.Columns.Add("work_date")
                    dtbworktime.Columns.Add("start_time")
                    dtbworktime.Columns.Add("end_time")
                    dtbworktime.Columns.Add("work_hrs")
                    dtbworktime.Columns.Add("is_holiday")
                    dtbworktime.Columns.Add("is_weekoff")
                    dtbworktime.Columns.Add("notes")
                    For i = 0 To grid_worktime_schedule.Rows.Count - 1

                        dtbworktime.Rows(i).Item("work_date") = startdt & " " & Format(CDate(startdt), "dddd")
                        grid_worktime_schedule.Columns("clmdate").DataPropertyName = "work_date"

                        dtbworktime.Rows(i).Item("start_time") = startdt & " " & "9:00 AM"
                        grid_worktime_schedule.Columns("starttime").DataPropertyName = "start_time"

                        dtbworktime.Rows(i).Item("end_time") = startdt & " " & "7:00 PM"
                        grid_worktime_schedule.Columns("endtime").DataPropertyName = "end_time"

                        dtbworktime.Rows(i).Item("work_hrs") = "10:00"
                        grid_worktime_schedule.Columns("workhrs").DataPropertyName = "work_hrs"

                        j = DatePart("d", startdt) + 1              'next day
                        If WeekdayName(Weekday(startdt)).Equals("Sunday") Then  'next day name
                            dtbworktime.Rows(i).Item("is_weekoff") = 1
                            grid_worktime_schedule.Columns("weekoff").DataPropertyName = "is_weekoff"
                            grid_worktime_schedule.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                        End If
                        startdt = DateSerial(DatePart("yyyy", startdt), DatePart("m", startdt), j)
                    Next
                    grid_worktime_schedule.EndEdit()

                End If
                grid_worktime_schedule.Columns("holiday").ReadOnly = False
                grid_worktime_schedule.Columns("notes").ReadOnly = False
                grid_worktime_schedule.Columns("clmdate").ReadOnly = True
                grid_worktime_schedule.Columns("weekoff").ReadOnly = True
                grid_worktime_schedule.Columns("starttime").ReadOnly = True
                grid_worktime_schedule.Columns("endtime").ReadOnly = True
                grid_worktime_schedule.Columns("workhrs").ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            cmblocname.Enabled = True
            If validateWorktimedata() Then
                If ObjclsGen.saveWorktimeData(masterform.con, dtbworktime, cmblocname.SelectedValue, cmbprocessperiod.Text) Then
                    MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                    searchWorktimeData()
                    grid_worktime_schedule.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.Enabled = True
        dtbworktime.Clear()
        grid_worktime_schedule.DataSource = Nothing
        cmblocname.SelectedIndex = -1
        cmbprocessperiod.SelectedIndex = -1
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        Dim dbreturn As Boolean = True
        Try
            If cmblocname.SelectedIndex < 0 Then
                MsgBox("Must select Location name", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmblocname.Focus()
            End If
            If cmbprocessperiod.SelectedIndex < 0 Then
                MsgBox("Must select process Period", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbprocessperiod.Focus()
            End If
            If dbreturn Then
                dtbLocation = New DataTable
                strQry = "select * from tbl_worktimings where location_id like '" & cmblocname.SelectedValue & "' AND period like '" & cmbprocessperiod.Text.Trim & "'"
                If ObjclsGen.Getdata(masterform.con, strQry, dtbLocation) Then
                    Dim reportview As New Reportviewer("period", dtbLocation)
                    reportview.Show()
                Else
                    MsgBox("There is no records for selected Period", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_worktime_schedule_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_worktime_schedule.DataError
        e.Cancel = True
    End Sub
#End Region

#Region " Functions/Procedures "

    Private Function searchWorktimeData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbworktime = New DataTable
            masterform.con.Close()
            strQry = "SELECT worktimings_id, work_date, start_time, end_time,work_hrs, is_holiday, is_weekoff, notes" & _
                     " FROM tbl_worktimings WHERE location_id like '" & cmblocname.SelectedValue & "' AND " & _
                     "period like '" & cmbprocessperiod.Text & "'"

            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbworktime) Then
                dbReturn = False
            Else
                masterform.con.Open()
                grid_worktime_schedule.AutoGenerateColumns = False
                grid_worktime_schedule.DataSource = Nothing
                grid_worktime_schedule.DataSource = dtbworktime
                dbReturn = True

                For i = 0 To grid_worktime_schedule.Rows.Count - 1
                    j = DatePart("d", startdt) + 1              'next day
                    If WeekdayName(Weekday(startdt)).Equals("Sunday") Then  'next day name
                        dtbworktime.Rows(i).Item("is_weekoff") = 1
                        grid_worktime_schedule.Columns("weekoff").DataPropertyName = "is_weekoff"
                        grid_worktime_schedule.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                    startdt = DateSerial(DatePart("yyyy", startdt), DatePart("m", startdt), j)
                Next
            End If
            masterform.con.Close()
            Return dbReturn
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateWorktimedata() As Boolean
        Dim dbReturn As Boolean = True
        Try
            
            grid_worktime_schedule.EndEdit()
            If cmblocname.SelectedIndex < 0 Then
                MsgBox("Must select Location name", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmblocname.Focus()
            End If
            If cmbprocessperiod.SelectedIndex < 0 Then
                MsgBox("Must select process Period", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbprocessperiod.Focus()
            End If

            For Each dtrowworktime In dtbworktime.Rows
                If dtrowworktime.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowworktime("notes")) Or (dtrowworktime("notes").Equals(String.Empty)) Then
                        dtrowworktime("notes") = ""
                    End If
                    If IsDBNull(dtrowworktime("is_weekoff")) Then 'Or (dtrowworktime("notes").Equals(String.Empty)) Then
                        dtrowworktime("is_weekoff") = 0
                    End If
                    If IsDBNull(dtrowworktime("is_holiday")) Then ' Or (dtrowworktime("notes").Equals(String.Empty)) Then
                        dtrowworktime("is_holiday") = 0
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function


#End Region
End Class