Public Class frm_recruitment_request

#Region "variables"
    Private dtbrecreq, dtbLocation, dtbDepartment, dtbempnm As DataTable
    Dim dtrowrecreq As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclshr As New cls_hr
    Dim strQry As String
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbrecreq = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_recruitment_request_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbrecreq.GetChanges IsNot Nothing Then
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

    Private Sub frm_recruitment_request_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)
        cmblocname.SelectedIndex = -1
        grid_recruitment_request.ReadOnly = False
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.Enabled = True
        dtbrecreq.Clear()
        grid_recruitment_request.DataSource = Nothing
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            cmblocname.Enabled = True
            grid_recruitment_request.EndEdit()
            If validateRecReqdata() Then
                If objclshr.saveRecruitmentData(masterform.con, dtbrecreq, cmblocname.SelectedValue, cmbdeptname.SelectedValue, Me) Then
                    MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                    searchEmployeeData()
                    grid_recruitment_request.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_recruitment_request_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_recruitment_request.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_recruitment_request_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_recruitment_request.KeyDown
        grid_recruitment_request.EndEdit()
        If e.KeyCode = Keys.Down Then
            Dim rowindex As Integer = grid_recruitment_request.CurrentCell.RowIndex
            If rowindex = grid_recruitment_request.Rows.Count - 1 Then
                ObjclsGen.AddnewRow(dtbrecreq)
            End If
        End If
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        cmblocname.Enabled = False
        Dim strempcode As String
        strempcode = "select * from tbl_department WHERE dept_isactive=1 "
        If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
            With grid_recruitment_request
                CType(.Columns("raisedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                CType(.Columns("raisedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                CType(.Columns("raisedby"), DataGridViewComboBoxColumn).ValueMember = "hod_empid"
                CType(.Columns("raisedby"), DataGridViewComboBoxColumn).DisplayMember = "hod_empname"
            End With
        End If

        grid_recruitment_request.ReadOnly = False
        If Not searchEmployeeData() Then
            MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
            dtbrecreq.Clear()
            grid_recruitment_request.AutoGenerateColumns = False
            grid_recruitment_request.DataSource = Nothing
            grid_recruitment_request.DataSource = dtbrecreq
            ObjclsGen.AddnewRow(dtbrecreq)
        End If
    End Sub
#End Region

#Region " Functions/Procedures "
    Private Function searchEmployeeData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbrecreq = New DataTable
            masterform.con.Close()
            strQry = " SELECT recruitment_id, description, total_vacancies, raisedemployee_code,  start_date, end_date, job, " & vbCrLf & _
                        "rec_position " & vbCrLf & _
                        "FROM tbl_recruitment where location_id  like '" & cmblocname.SelectedValue & "' and Department_id like '" & cmbdeptname.SelectedValue & "'"

            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbrecreq) Then
                dbReturn = False
            Else
                masterform.con.Open()
                grid_recruitment_request.AutoGenerateColumns = False
                grid_recruitment_request.DataSource = Nothing
                grid_recruitment_request.DataSource = dtbrecreq
                dbReturn = True
            End If
            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

  
    Public Function validateRecReqdata() As Boolean
        Dim dbReturn As Boolean = True
        Try
            grid_recruitment_request.EndEdit()
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            For Each dtrowrecreq In dtbrecreq.Rows
                If dtrowrecreq.RowState <> DataRowState.Deleted Then

                    If IsDBNull(dtrowrecreq("description")) Or (dtrowrecreq("description").Equals(String.Empty)) Then
                        MsgBox("Must enter Description", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowrecreq("total_vacancies")) Or (dtrowrecreq("total_vacancies").Equals(String.Empty)) Then
                        MsgBox("Must enter Total Vacancy", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowrecreq("raisedemployee_code")) Or (dtrowrecreq("raisedemployee_code").Equals(String.Empty)) Then
                        MsgBox("Must Select Employee Name ", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowrecreq("start_date")) Or (dtrowrecreq("start_date").Equals(String.Empty)) Then
                        MsgBox("Must enter Start date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowrecreq("end_date")) Or (dtrowrecreq("end_date").Equals(String.Empty)) Then
                        MsgBox("Must enter end date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowrecreq("job")) Or (dtrowrecreq("job").Equals(String.Empty)) Then
                        MsgBox("Must enter Job", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowrecreq("rec_position")) Or (dtrowrecreq("rec_position").Equals(String.Empty)) Then
                        MsgBox("Must enter Position", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
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