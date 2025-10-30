
Public Class frm_Process_Period

#Region " variable declaration "
    Dim bsProcessPeriod As New BindingSource
    Private dtbProcessPeriod As DataTable
    Dim dtrowProcessPeriod As DataRow
    Dim ObjclsGen As New cls_General
    Dim strQry As String
#End Region

#Region "Constructors"
    Public Sub New()
        InitializeComponent()
        dtbProcessPeriod = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "
    

    Private Sub frm_Process_Period_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bsProcessPeriod.EndEdit()
        Try
            If dtbProcessPeriod.GetChanges IsNot Nothing Then
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

    Private Sub frm_Process_Period_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            populateProcessPeriodData()
            txtperiod.Text = DatePart("yyyy", DateTimePicker_startdate.Value) & Format(DateTimePicker_startdate.Value, "MM")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        pnl_process_period.Enabled = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_process_period.Enabled Then
                If validateProcessPeriodData() Then
                    If ObjclsGen.saveProcessPeriodData(masterform.con, dtbProcessPeriod) Then
                        pnl_process_period.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_process_period.Enabled = True
                        populateProcessPeriodData()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        pnl_process_period.Enabled = False
        If Not populateProcessPeriodData() Then
            MsgBox("Record not found", MsgBoxStyle.Information, "Record not found")
        End If
    End Sub

    Private Sub txtprocessperiodfind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtprocessperiodfind.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                pnl_process_period.Enabled = False
                If Not populateProcessPeriodData() Then
                    pnl_process_period.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub DateTimePicker_startdate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker_startdate.ValueChanged
        txtmonth_days.Text = 0
        txtperiod.Text = DatePart("yyyy", DateTimePicker_startdate.Value) & Format(DateTimePicker_startdate.Value, "MM")
        txtmonth_days.Text = (DateDiff("d", DateTimePicker_startdate.Value, DateTimePicker_enddate.Value)) + 1
    End Sub

    Private Sub DateTimePicker_enddate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker_enddate.ValueChanged
        txtmonth_days.Text = 0
        txtmonth_days.Text = (DateDiff("d", DateTimePicker_startdate.Value, DateTimePicker_enddate.Value)) + 1
    End Sub
#End Region

#Region " Functions/Procedures "

    Private Function disp_record() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbProcessPeriod.Columns("finalized").DefaultValue = 0
            txtperiod.DataBindings.Clear()
            DateTimePicker_startdate.DataBindings.Clear()
            DateTimePicker_enddate.DataBindings.Clear()
            txtmonth_days.DataBindings.Clear()
            txtnoof_weekly_offs.DataBindings.Clear()
            txtnonworking_days.DataBindings.Clear()
            chkfinalized.DataBindings.Clear()

            txtperiod.DataBindings.Add("TEXT", bsProcessPeriod, "period")
            DateTimePicker_startdate.DataBindings.Add("TEXT", bsProcessPeriod, "start_date")
            DateTimePicker_enddate.DataBindings.Add("TEXT", bsProcessPeriod, "end_date")
            txtmonth_days.DataBindings.Add("TEXT", bsProcessPeriod, "month_days")
            txtnoof_weekly_offs.DataBindings.Add("TEXT", bsProcessPeriod, "no_of_weekly_offs")
            txtnonworking_days.DataBindings.Add("TEXT", bsProcessPeriod, "non_working_days")
            chkfinalized.DataBindings.Add("CHECKED", bsProcessPeriod, "finalized", True)

            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function populateProcessPeriodData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            Dim strQry As String
            dtbProcessPeriod = New DataTable
            masterform.con.Close()
            masterform.con.Open()
            strQry = "SELECT * FROM tbl_process_period WHERE period LIKE '" & txtprocessperiodfind.Text.Trim & "' ORDER BY period"
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbProcessPeriod) Then
                pnl_process_period.Enabled = False
                dbReturn = False
            End If
            bsProcessPeriod.DataSource = dtbProcessPeriod
            BindingNavigator1.BindingSource = bsProcessPeriod
            If disp_record() Then
                If dtbProcessPeriod.Rows.Count > 0 Then
                    pnl_process_period.Enabled = True
                    dbReturn = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        masterform.con.Close()
        Return dbReturn
    End Function

    Private Function validateProcessPeriodData() As Boolean
        Dim dbreturn As Boolean = True
        bsProcessPeriod.EndEdit()
        Try
            For Each dtrowProcessPeriod In dtbProcessPeriod.Rows
                If dtrowProcessPeriod.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowProcessPeriod("period")) Or (dtrowProcessPeriod("period").Equals(String.Empty)) Then
                        MsgBox("Must Enter Period", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                    End If
                    If IsDBNull(dtrowProcessPeriod("start_date")) Or (dtrowProcessPeriod("start_date").Equals(String.Empty)) Then
                        MsgBox("Must enter Start Date", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        DateTimePicker_startdate.Focus()
                    End If
                    If IsDBNull(dtrowProcessPeriod("end_date")) Or (dtrowProcessPeriod("end_date").Equals(String.Empty)) Then
                        MsgBox("Must Enter End Date", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        DateTimePicker_enddate.Focus()
                    End If
                    If IsDBNull(dtrowProcessPeriod("month_days")) Or (dtrowProcessPeriod("month_days").Equals(String.Empty)) Then
                        MsgBox("Must enter Month Days", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtmonth_days.Focus()
                    End If
                    
                    If IsDBNull(dtrowProcessPeriod("no_of_weekly_offs")) Or (dtrowProcessPeriod("no_of_weekly_offs").Equals(String.Empty)) Then
                        MsgBox("Must enter no of weekly off's", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtnoof_weekly_offs.Focus()
                    End If
                    If IsDBNull(dtrowProcessPeriod("non_working_days")) Or (dtrowProcessPeriod("non_working_days").Equals(String.Empty)) Then
                        dtrowProcessPeriod("non_working_days") = ""
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbreturn
    End Function
#End Region

  
End Class