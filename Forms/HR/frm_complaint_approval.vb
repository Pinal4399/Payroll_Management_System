
Public Class frm_complaint_approval

#Region "variables"
    Private dtbcompapp, dtbLocation, dtbDepartment, dtbempnm As DataTable
    Dim dtrowcompapp As DataRow
    Dim strempcode As String
    Dim ObjclsGen As New cls_General
    Dim objclshr As New cls_hr
    Dim strqry As String
#End Region

#Region " Constructors "

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        '  Add any initialization after the InitializeComponent() call.
        dtbcompapp = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub

#End Region

#Region " Events "

    Private Sub frm_complaint_approval_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbcompapp.GetChanges IsNot Nothing Then
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

    Private Sub frm_complaint_approval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)
        grid_complaint_approval.ReadOnly = True
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            strempcode = "select * from tbl_Employee WHERE location_id  like '" & cmblocname.SelectedValue & "' and Department_id like '" & cmbdeptname.SelectedValue & "' AND emp_inactive=0"
            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
                With grid_complaint_approval
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).ValueMember = "employee_code"
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DisplayMember = "short_name"
                End With
            End If
            strempcode = "select * from tbl_department WHERE dept_isactive=1 " 
            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
                With grid_complaint_approval
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).ValueMember = "hod_empid"
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DisplayMember = "hod_empname"
                End With
            End If
            strempcode = "select * from tbl_Employee WHERE emp_inactive=0"
            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
                With grid_complaint_approval
                    CType(.Columns("resolvedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("resolvedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                    CType(.Columns("resolvedby"), DataGridViewComboBoxColumn).ValueMember = "employee_code"
                    CType(.Columns("resolvedby"), DataGridViewComboBoxColumn).DisplayMember = "short_name"
                End With
            End If
            cmblocname.Enabled = False
            grid_complaint_approval.ReadOnly = False
            grid_complaint_approval.Columns("clmcomplaint").ReadOnly = True
            grid_complaint_approval.Columns("submittedby").ReadOnly = True
            grid_complaint_approval.Columns("submissiondate").ReadOnly = True

            If Not FetchComplaintData() Then
                MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            cmblocname.Enabled = True
            If validateCompAppdata() Then
                If objclshr.saveComplaintData(masterform.con, dtbcompapp, cmblocname.SelectedValue, cmbdeptname.SelectedValue, Me) Then
                    MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                    FetchComplaintData()
                    grid_complaint_approval.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.Enabled = True
        dtbcompapp.Clear()
        grid_complaint_approval.DataSource = Nothing
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub grid_complaint_approval_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_complaint_approval.CellContentClick
        Try
            If grid_complaint_approval.Columns("btncomplaint").Index = e.ColumnIndex Then
                If ObjclsGen.ShowForm("frm_notes", Me) = False Then
                    Dim obj As New frm_notes(grid_complaint_approval.Item("clmcomplaint", e.RowIndex).Value.ToString, True)
                    obj.ShowDialog(Me)
                    grid_complaint_approval.Item("clmcomplaint", e.RowIndex).Value = obj.strNotes
                End If
            End If

            If grid_complaint_approval.Columns("btnremarks").Index = e.ColumnIndex Then
                If ObjclsGen.ShowForm("frm_notes", Me) = False Then
                    Dim obj As New frm_notes(grid_complaint_approval.Item("clmremarks", e.RowIndex).Value.ToString)
                    obj.ShowDialog(Me)
                    grid_complaint_approval.Item("clmremarks", e.RowIndex).Value = obj.strNotes
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    

    Private Sub grid_complaint_approval_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_complaint_approval.DataError
        e.Cancel = True
    End Sub

#End Region

#Region " Functions/Procedures "
    Private Function FetchComplaintData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbcompapp = New DataTable
            masterform.con.Close()
            strqry = " SELECT complaint_id, description, submitted_empcode,submission_date,status,followup_date,approved_empcode,resolved_empcode,remarks " & vbCrLf & _
                      "FROM tbl_complaint where location_id  like '" & cmblocname.SelectedValue & "' and Department_id like '" & cmbdeptname.SelectedValue & "'"
            If Not ObjclsGen.Getdata(masterform.con, strqry, dtbcompapp) Then
                dtbcompapp.Clear()
                grid_complaint_approval.DataSource = Nothing
                dbReturn = False
            Else
                masterform.con.Open()
                grid_complaint_approval.AutoGenerateColumns = False
                grid_complaint_approval.DataSource = Nothing
                grid_complaint_approval.DataSource = dtbcompapp
                dbReturn = True
            End If
            masterform.con.Close()
            Return dbReturn
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateCompAppdata() As Boolean
        Dim dbReturn As Boolean = True
        Try
            grid_complaint_approval.EndEdit()
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            For Each dtrowcompapp In dtbcompapp.Rows
                If dtrowcompapp.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowcompapp("status")) Or (dtrowcompapp("status").Equals(String.Empty)) Then
                        MsgBox("Must Enter Status", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    ElseIf dtrowcompapp("status").Equals("Solved") Then
                        If IsDBNull(dtrowcompapp("resolved_empcode")) Or (dtrowcompapp("resolved_empcode").Equals(String.Empty)) Then
                            MsgBox("Must Enter employee name by which the complaint is resolved", MsgBoxStyle.Information, Me.Text)
                            dbReturn = False
                        End If
                    Else
                        dtrowcompapp("resolved_empcode") = ""
                    End If
                    If Not IsDBNull(dtrowcompapp("approved_empcode")) And Not (dtrowcompapp("approved_empcode").Equals(String.Empty)) Then
                        If IsDBNull(dtrowcompapp("followup_date")) Or IsDate(dtrowcompapp("followup_date").Equals(String.Empty)) Then
                            MsgBox("Must Enter Followup date", MsgBoxStyle.Information, Me.Text)
                            dbReturn = False
                        End If
                    End If
                    If IsDBNull(dtrowcompapp("remarks")) Or (dtrowcompapp("remarks").Equals(String.Empty)) Then
                        dtrowcompapp("remarks") = ""
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