Public Class frm_complaint_register

#Region "variables"
    Private dtbcompreg, dtbLocation, dtbDepartment, dtbempnm As DataTable
    Dim dtrowcompreg As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclshr As New cls_hr
    Dim strempcode, strQry As String
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbcompreg = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_complaint_register_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbcompreg.GetChanges IsNot Nothing Then
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
    Private Sub frm_complaint_register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)
        grid_complaint_register.ReadOnly = False
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.Enabled = True
        dtbcompreg.Clear()
        grid_complaint_register.DataSource = Nothing
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        cmblocname.Enabled = True
        grid_complaint_register.EndEdit()
        If validateCompRegdata() Then
            If objclshr.saveComplaintData(masterform.con, dtbcompreg, cmblocname.SelectedValue, cmbdeptname.SelectedValue, Me) Then
                MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                searchEmployeeData()
                grid_complaint_register.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            strempcode = "select * from tbl_Employee WHERE location_id  like '" & cmblocname.SelectedValue & "' and Department_id like '" & cmbdeptname.SelectedValue & "' AND emp_inactive=0"
            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
                With grid_complaint_register
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).ValueMember = "employee_code"
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DisplayMember = "short_name"
                End With
            End If

            cmblocname.Enabled = False
            grid_complaint_register.ReadOnly = False
            If Not searchEmployeeData() Then
                MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
                dtbcompreg.Clear()
                grid_complaint_register.AutoGenerateColumns = False
                grid_complaint_register.DataSource = Nothing
                grid_complaint_register.DataSource = dtbcompreg
                ObjclsGen.AddnewRow(dtbcompreg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub grid_complaint_register_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_complaint_register.CellContentClick
        Try
            If grid_complaint_register.Columns("btncomplaint").Index = e.ColumnIndex Then
                If ObjclsGen.ShowForm("frm_notes", Me) = False Then
                    Dim obj As New frm_notes(grid_complaint_register.Item("clmcomplaint", e.RowIndex).Value.ToString)
                    obj.ShowDialog(Me)
                    grid_complaint_register.Item("clmcomplaint", e.RowIndex).Value = obj.strNotes
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_complaint_register_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_complaint_register.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_complaint_register_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_complaint_register.KeyDown
        grid_complaint_register.EndEdit()
        If e.KeyCode = Keys.Down Then
            Dim rowindex As Integer = grid_complaint_register.CurrentCell.RowIndex
            If rowindex = grid_complaint_register.Rows.Count - 1 Then
                ObjclsGen.AddnewRow(dtbcompreg)
            End If
        End If
    End Sub

#End Region

#Region " Functions/Procedures "
    Private Function searchEmployeeData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            Dim strqry As String
            dtbcompreg = New DataTable
            masterform.con.Close()
            strqry = " SELECT complaint_id, description, submitted_empcode,submission_date " & vbCrLf & _
                        "FROM tbl_complaint where location_id  like '" & cmblocname.SelectedValue & "' and Department_id like '" & cmbdeptname.SelectedValue & "'"

            If Not ObjclsGen.Getdata(masterform.con, strqry, dtbcompreg) Then
                dbReturn = False
            Else
                masterform.con.Open()
                grid_complaint_register.AutoGenerateColumns = False
                grid_complaint_register.DataSource = Nothing
                grid_complaint_register.DataSource = dtbcompreg
                dbReturn = True
            End If
            masterform.con.Close()
            Return dbReturn
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateCompRegdata() As Boolean
        Dim dbReturn As Boolean = True
        Try
            grid_complaint_register.EndEdit()
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            For Each dtrowcompreg In dtbcompreg.Rows
                If dtrowcompreg.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowcompreg("description")) Or (dtrowcompreg("description").Equals(String.Empty)) Then
                        MsgBox("Must enter Complaint", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowcompreg("submitted_empcode")) Or (dtrowcompreg("submitted_empcode").Equals(String.Empty)) Then
                        MsgBox("Must enter Employee Name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowcompreg("submission_date")) Or (dtrowcompreg("submission_date").Equals(String.Empty)) Then
                        MsgBox("Must enter Submission Date", MsgBoxStyle.Information, Me.Text)
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