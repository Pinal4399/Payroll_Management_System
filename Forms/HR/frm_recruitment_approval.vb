Public Class frm_recruitment_approval

#Region "variables"
    Private dtbrecapp, dtbLocation, dtbDepartment, dtbempnm As DataTable
    Dim dtrowrecapp As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclshr As New cls_hr
    Dim strQry As String
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbrecapp = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_recruitment_approval_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbrecapp.GetChanges IsNot Nothing Then
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

    Private Sub frm_recruitment_approval_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strempcode As String
        Try
            dtbLocation = New DataTable
            ObjclsGen.cmblocationname(dtbLocation, cmblocname)
            grid_recruitment_approval.ReadOnly = True
            strempcode = "select * from tbl_department WHERE dept_isactive=1 "
            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
                With grid_recruitment_approval
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).ValueMember = "hod_empid"
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DisplayMember = "hod_empname"
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.Enabled = True
        dtbrecapp.Clear()
        grid_recruitment_approval.DataSource = Nothing
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            cmblocname.Enabled = True
            If validateRecruitAppdata() Then
                If objclshr.saveRecruitmentData(masterform.con, dtbrecapp, cmblocname.SelectedValue, cmbdeptname.SelectedValue, Me) Then
                    MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                    FetchRecruitData()
                    grid_recruitment_approval.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub


    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        cmblocname.Enabled = False
        grid_recruitment_approval.ReadOnly = False
        grid_recruitment_approval.Columns("desc").ReadOnly = True
        grid_recruitment_approval.Columns("totvacancy").ReadOnly = True
        grid_recruitment_approval.Columns("job").ReadOnly = True
        grid_recruitment_approval.Columns("position").ReadOnly = True
        grid_recruitment_approval.Columns("open").ReadOnly = True

        If Not FetchRecruitData() Then
            MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
            dtbrecapp.Clear()
            grid_recruitment_approval.DataSource = Nothing
        End If
    End Sub
    Private Sub grid_recruitment_approval_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_recruitment_approval.DataError
        e.Cancel = True
    End Sub
#End Region

#Region " Functions/Procedures "
    Private Function FetchRecruitData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbrecapp = New DataTable
            masterform.con.Close()
            strQry = "SELECT recruitment_id,description,total_vacancies,fulfill_date,job,rec_position,status,approveemployee_code FROM tbl_recruitment " & _
                     "WHERE location_id  like '" & cmblocname.SelectedValue & "' and Department_id like '" & cmbdeptname.SelectedValue & "' "
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbrecapp) Then
                dbReturn = False
            Else
                masterform.con.Open()
                grid_recruitment_approval.AutoGenerateColumns = False
                grid_recruitment_approval.DataSource = Nothing
                grid_recruitment_approval.DataSource = dtbrecapp
                dtbrecapp.Columns("status").DefaultValue = 0
                dtbrecapp.Columns("status").AllowDBNull = False
                dbReturn = True
            End If
            masterform.con.Close()
            Return dbReturn
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateRecruitAppdata() As Boolean
        Dim dbReturn As Boolean = True

        Try
            grid_recruitment_approval.EndEdit()
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            For Each dtrowrecapp In dtbrecapp.Rows
                If dtrowrecapp.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowrecapp("approveemployee_code")) Or (dtrowrecapp("approveemployee_code").Equals(String.Empty)) Then
                        dtrowrecapp("approveemployee_code") = ""
                    End If
                    If Not IsDBNull(dtrowrecapp("approveemployee_code")) And Not (dtrowrecapp("approveemployee_code").Equals(String.Empty)) Then
                        dtrowrecapp("status") = 0
                        If IsDBNull(dtrowrecapp("fulfill_date")) Or IsDate(dtrowrecapp("fulfill_date").Equals(String.Empty)) Then
                            MsgBox("Must Enter fulfill date", MsgBoxStyle.Information, Me.Text)
                            dbReturn = False
                        End If
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