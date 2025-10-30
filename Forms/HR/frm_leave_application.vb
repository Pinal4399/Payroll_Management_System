Imports System.Data.SqlClient
Public Class frm_leave_application

#Region "variables"
    Private dtbleave, dtbLocation, dtbDepartment, dtbempCode, dtbempnm As DataTable
    Dim dtrowleave As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclshr As New cls_hr
    Dim cmbempcode As New ComboBox
    Dim txtfromdate, txttodate As TextBox
    Dim strempcode, strQry As String
    Dim cmd As New sqlCommand
    Dim dr As sqlDataReader
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbleave = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region
 
#Region " Events "

    Private Sub frm_leave_application_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbleave.GetChanges IsNot Nothing Then
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


    Private Sub frm_leave_application_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)
        grid_leave_application.ReadOnly = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            cmblocname.Enabled = True
            If validateLeavedata() Then
                If objclshr.saveLeaveData(masterform.con, dtbleave, cmblocname.SelectedValue, cmbdeptname.SelectedValue, cmbleavetype.Text) Then
                    MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                    searchEmployeeData()
                    grid_leave_application.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.Enabled = True
        dtbleave.Clear()
        grid_leave_application.DataSource = Nothing
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
        cmbleavetype.SelectedIndex = -1
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub cmbdeptname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdeptname.SelectedIndexChanged
        ObjclsGen.getempcode(cmblocname.Text, cmbdeptname.Text, dtbempCode, grid_leave_application)
    End Sub

    Private Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        dtbempnm = New DataTable
        strempcode = "select * from tbl_department WHERE dept_isactive=1 AND location_id " & _
                      "like '" & cmblocname.SelectedValue & "' "

        If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
            With grid_leave_application
                CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                CType(.Columns("approvedby"), DataGridViewComboBoxColumn).ValueMember = "hod_empid"
                CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DisplayMember = "hod_empname"
            End With
        End If
        cmblocname.Enabled = False
        grid_leave_application.ReadOnly = False


        If Not searchEmployeeData() Then
            MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
            dtbleave.Clear()
            grid_leave_application.AutoGenerateColumns = False
            grid_leave_application.DataSource = Nothing
            grid_leave_application.DataSource = dtbleave
            ObjclsGen.AddnewRow(dtbleave)
        End If
    End Sub

    Private Sub txttodate_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim totleave As Integer
        Try
            If grid_leave_application.CurrentRow IsNot Nothing Then
                If Not txttodate.Text = "" Then
                    grid_leave_application.Item("noofdays", grid_leave_application.CurrentRow.Index).Value = (DateDiff("d", grid_leave_application.Item("fromdate", grid_leave_application.CurrentRow.Index).Value, grid_leave_application.Item("todate", grid_leave_application.CurrentRow.Index).Value)) + 1
                    'grid_leave_application.Item("noofdays", grid_leave_application.CurrentRow.Index).Value = DatePart("d", grid_leave_application.Item("todate", grid_leave_application.CurrentRow.Index).Value) - DatePart("d", grid_leave_application.Item("fromdate", grid_leave_application.CurrentRow.Index).Value)
                    grid_leave_application.Item("noofdays", grid_leave_application.CurrentRow.Index).ReadOnly = True
                Else
                    grid_leave_application.Item("noofdays", grid_leave_application.CurrentRow.Index).Value = String.Empty
                    grid_leave_application.Item("noofdays", grid_leave_application.CurrentRow.Index).ReadOnly = False
                End If
            End If
            masterform.con.Close()
            cmd.Connection = masterform.con
            cmd.CommandText = "SELECT * FROM tbl_leave_application WHERE employee_code LIKE '" & grid_leave_application.Item("empcode", grid_leave_application.CurrentRow.Index).Value & "' AND leave_type LIKE '" & cmbleavetype.Text.Trim & "'"

            masterform.con.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                totleave = 0
                While dr.Read()
                    totleave = totleave + dr.Item(8)
                End While
                If totleave + (CInt(grid_leave_application.Item("noofdays", grid_leave_application.CurrentRow.Index).Value)) > 11 Then
                    MsgBox("This leave application should not approved", MsgBoxStyle.Information, Me.Text)
                    grid_leave_application.Item("leavestatus", grid_leave_application.CurrentRow.Index).Value = "Non-Approved"
                    grid_leave_application.Columns("leavestatus").ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbempcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            grid_leave_application.Item("empname", grid_leave_application.CurrentRow.Index).ReadOnly = True
            grid_leave_application.Item("noofdays", grid_leave_application.CurrentRow.Index).ReadOnly = True
            If grid_leave_application.CurrentRow IsNot Nothing Then
                If cmbempcode.SelectedIndex >= 0 Then
                    grid_leave_application.Item("empname", grid_leave_application.CurrentRow.Index).Value = cmbempcode.DataSource.DefaultView(cmbempcode.SelectedIndex)("SHORT_NAME")
                    grid_leave_application.Item("empname", grid_leave_application.CurrentRow.Index).ReadOnly = True
                Else
                    grid_leave_application.Item("empname", grid_leave_application.CurrentRow.Index).Value = String.Empty
                    grid_leave_application.Item("empname", grid_leave_application.CurrentRow.Index).ReadOnly = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Try
        End Try
    End Sub

    Private Sub grid_leave_application_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_leave_application.CellContentClick
        Try
            If grid_leave_application.Columns("btnreason").Index = e.ColumnIndex Then
                If ObjclsGen.ShowForm("frm_notes", Me) = False Then
                    Dim obj As New frm_notes(grid_leave_application.Item("clmreason", e.RowIndex).Value.ToString)
                    obj.ShowDialog(Me)
                    grid_leave_application.Item("clmreason", e.RowIndex).Value = obj.strNotes
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_leave_application_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grid_leave_application.CellValidating
        Try
            If grid_leave_application.Columns(grid_leave_application.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EMPLOYEE_CODE" Then
                RemoveHandler cmbempcode.SelectedIndexChanged, AddressOf cmbempcode_SelectedIndexChanged
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_leave_application_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_leave_application.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_leave_application_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grid_leave_application.EditingControlShowing
        Try

            grid_leave_application.Columns("empname").ReadOnly = True
            grid_leave_application.Columns("noofdays").ReadOnly = True
            If grid_leave_application.Columns(grid_leave_application.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EMPLOYEE_CODE" Then
                cmbempcode = e.Control
                AddHandler cmbempcode.SelectedIndexChanged, AddressOf cmbempcode_SelectedIndexChanged
            End If
            If grid_leave_application.Columns(grid_leave_application.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "TO_DATE" Then
                txttodate = e.Control
                AddHandler txttodate.Leave, AddressOf txttodate_Leave
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_leave_application_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_leave_application.KeyDown
        grid_leave_application.EndEdit()
        If e.KeyCode = Keys.Down Then
            Dim rowindex As Integer = grid_leave_application.CurrentCell.RowIndex
            If rowindex = grid_leave_application.Rows.Count - 1 Then
                ObjclsGen.AddnewRow(dtbleave)
            End If
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

#End Region

#Region " Functions/Procedures "

    Private Function searchEmployeeData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbleave = New DataTable
            masterform.con.Close()
            strQry = "SELECT leave_id,l.employee_code, e.short_name,application_date,from_date,to_date,no_of_days,reason,leave_status,approved_by " & _
                     "FROM tbl_leave_application l,tbl_employee e WHERE (l.location_id like '" & cmblocname.SelectedValue & "' AND " & _
                     "l.department_id like '" & cmbdeptname.SelectedValue & "') AND leave_type='" & cmbleavetype.Text.ToString & _
                     "' AND l.employee_code=e.employee_code"

            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbleave) Then
                dbReturn = False
            Else
                masterform.con.Open()
                grid_leave_application.AutoGenerateColumns = False
                grid_leave_application.DataSource = Nothing
                grid_leave_application.DataSource = dtbleave
                dbReturn = True
            End If
            masterform.con.Close()
            Return dbReturn
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateLeavedata() As Boolean
        Dim dbReturn As Boolean = True
        Try
            grid_leave_application.EndEdit()
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            If cmbleavetype.SelectedIndex < 0 Then
                MsgBox("Must select Leave Type", MsgBoxStyle.Critical, Me.Text)
                dbReturn = False
                cmbleavetype.Focus()
            End If

            For Each dtrowleave In dtbleave.Rows
                If dtrowleave.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowleave("employee_code")) Or (dtrowleave("employee_code").Equals(String.Empty)) Then
                        MsgBox("Must select employee code", MsgBoxStyle.Information , Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowleave("application_date")) Or (dtrowleave("application_date").Equals(String.Empty)) Then
                        MsgBox("Must enter application date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowleave("from_date")) Or (dtrowleave("from_date").Equals(String.Empty)) Then
                        MsgBox("Must enter from date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowleave("to_date")) Or (dtrowleave("to_date").Equals(String.Empty)) Then
                        MsgBox("Must enter To date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If dtrowleave("to_date") < dtrowleave("from_date") Then
                        MsgBox("To Date must be greater than From Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowleave("reason")) Or (dtrowleave("reason").Equals(String.Empty)) Then
                        MsgBox("Must enter reason", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowleave("leave_status")) Or (dtrowleave("leave_status").Equals(String.Empty)) Then
                        MsgBox("Must enter leave status", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowleave("approved_by")) Or (dtrowleave("approved_by").Equals(String.Empty)) Then
                        dtrowleave("approved_by") = ""
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