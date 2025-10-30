Public Class frm_training_enrollment
#Region "variables"
    Private dtbTEnroll, dtbempCode, dtbTrainer, dtbVenue As DataTable
    Dim dtrowTEnroll As DataRow
    Dim strQry As String
    Dim ObjclsGen As New cls_General
    Dim Objhr As New cls_hr
    Dim cmbempcode As New ComboBox
    Dim d As Integer
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbTEnroll = New DataTable
        dtbempCode = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_training_enrollment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbTEnroll.GetChanges IsNot Nothing Then
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

    Private Sub frm_training_enrollment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtbempCode = New DataTable
            strQry = "SELECT e.employee_code,e.short_name,l.location_id,l.location_name,d.department_id,d.department_name FROM tbl_employee e,tbl_location l,tbl_department d WHERE e.location_id=l.location_id and e.department_id=d.department_id "
            If ObjclsGen.Getdata(masterform.con, strQry, dtbempCode) Then
                With grid_emp_enrolldetail
                    CType(.Columns("clmemp_code"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("clmemp_code"), DataGridViewComboBoxColumn).DataSource = dtbempCode
                    CType(.Columns("clmemp_code"), DataGridViewComboBoxColumn).ValueMember = "employee_code"
                    CType(.Columns("clmemp_code"), DataGridViewComboBoxColumn).DisplayMember = "employee_code"
                End With
            End If

            dtbVenue = New DataTable
            strQry = "SELECT venue_id,name FROM tbl_training_venue"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbVenue) Then
                With cmbvenue
                    .DataSource = dtbVenue
                    .DisplayMember = "name"
                    .ValueMember = "venue_id"
                End With
            End If
            cmbvenue.Text = ""
            cmbvenue.SelectedIndex = -1

            dtbTrainer = New DataTable
            strQry = "SELECT trainer_id,trainer_name FROM tbl_trainer"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbTrainer) Then
                With cmbtrainer
                    .DataSource = dtbTrainer
                    .DisplayMember = "trainer_name"
                    .ValueMember = "trainer_id"
                End With
            End If
            cmbtrainer.Text = ""
            cmbtrainer.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        grid_emp_enrolldetail.ReadOnly = True
    End Sub

    Private Sub dtfromdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfromdate.Leave
        txtduration.Text = ""
        txtduration.Text = DateDiff("d", dtfromdate.Value, dttodate.Value) + 1 & " Days"
    End Sub

    Private Sub dttodate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dttodate.Leave
        txtduration.Text = ""
        txtduration.Text = DateDiff("d", dtfromdate.Value, dttodate.Value) + 1 & " Days"
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If validateTEnrolldata() Then
                If Objhr.SaveTEnrolldata(masterform.con, dtbTEnroll, cmbtrainer.SelectedValue, cmbvenue.SelectedValue, d, dtfromdate.Value, dttodate.Value) Then
                    MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                    searchEmployeeData()
                    grid_emp_enrolldetail.ReadOnly = True
                    lbltotalemp.Visible = True
                    lbltotalemp.Text = "Total Employees :" & grid_emp_enrolldetail.RowCount
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        dtbTEnroll.Clear()
        grid_emp_enrolldetail.DataSource = Nothing
        cmbtrainer.SelectedIndex = -1
        cmbvenue.SelectedIndex = -1
        txtduration.Text = String.Empty
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        grid_emp_enrolldetail.ReadOnly = False
        grid_emp_enrolldetail.Columns("deptname").ReadOnly = True
        grid_emp_enrolldetail.Columns("locname").ReadOnly = True
        If Not searchEmployeeData() Then
            MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
            dtbTEnroll.Clear()
            grid_emp_enrolldetail.AutoGenerateColumns = False
            grid_emp_enrolldetail.DataSource = Nothing
            grid_emp_enrolldetail.DataSource = dtbTEnroll
            ObjclsGen.AddnewRow(dtbTEnroll)
            lbltotalemp.Text = "Total Employees :" & 0
        Else
            lbltotalemp.Visible = True
            lbltotalemp.Text = "Total Employees :" & grid_emp_enrolldetail.RowCount
        End If
    End Sub

    Private Sub cmbempcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If grid_emp_enrolldetail.CurrentRow IsNot Nothing Then
                If cmbempcode.SelectedIndex >= 0 Then
                    If alreadyfill() Then
                        grid_emp_enrolldetail.Item("empname", grid_emp_enrolldetail.CurrentRow.Index).Value = cmbempcode.DataSource.DefaultView(cmbempcode.SelectedIndex)("SHORT_NAME")
                        grid_emp_enrolldetail.Item("empname", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = True
                        grid_emp_enrolldetail.Item("locname", grid_emp_enrolldetail.CurrentRow.Index).Value = cmbempcode.DataSource.DefaultView(cmbempcode.SelectedIndex)("LOCATION_NAME")
                        grid_emp_enrolldetail.Item("locname", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = True
                        grid_emp_enrolldetail.Item("deptname", grid_emp_enrolldetail.CurrentRow.Index).Value = cmbempcode.DataSource.DefaultView(cmbempcode.SelectedIndex)("DEPARTMENT_NAME")
                        grid_emp_enrolldetail.Item("deptname", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = True
                        grid_emp_enrolldetail.Item("clmlocation", grid_emp_enrolldetail.CurrentRow.Index).Value = cmbempcode.DataSource.DefaultView(cmbempcode.SelectedIndex)("LOCATION_ID")
                        grid_emp_enrolldetail.Item("clmlocation", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = True
                        grid_emp_enrolldetail.Item("dept", grid_emp_enrolldetail.CurrentRow.Index).Value = cmbempcode.DataSource.DefaultView(cmbempcode.SelectedIndex)("DEPARTMENT_ID")
                        grid_emp_enrolldetail.Item("dept", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = True
                    Else
                        Exit Sub
                    End If
                Else
                    grid_emp_enrolldetail.Item("empname", grid_emp_enrolldetail.CurrentRow.Index).Value = String.Empty
                    grid_emp_enrolldetail.Item("empname", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = False
                    grid_emp_enrolldetail.Item("locname", grid_emp_enrolldetail.CurrentRow.Index).Value = String.Empty
                    grid_emp_enrolldetail.Item("locname", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = False
                    grid_emp_enrolldetail.Item("deptname", grid_emp_enrolldetail.CurrentRow.Index).Value = String.Empty
                    grid_emp_enrolldetail.Item("deptname", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = False
                    grid_emp_enrolldetail.Item("clmlocation", grid_emp_enrolldetail.CurrentRow.Index).Value = String.Empty
                    grid_emp_enrolldetail.Item("clmlocation", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = False
                    grid_emp_enrolldetail.Item("dept", grid_emp_enrolldetail.CurrentRow.Index).Value = String.Empty
                    grid_emp_enrolldetail.Item("dept", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = False
                End If
        End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Try
        End Try
    End Sub

    Private Sub grid_emp_enrolldetail_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grid_emp_enrolldetail.CellValidating
        Try
            If grid_emp_enrolldetail.Columns(grid_emp_enrolldetail.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EMPLOYEE_CODE" Then
                RemoveHandler cmbempcode.SelectedIndexChanged, AddressOf cmbempcode_SelectedIndexChanged
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_emp_enrolldetail_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_emp_enrolldetail.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_emp_enrolldetail_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grid_emp_enrolldetail.EditingControlShowing
        grid_emp_enrolldetail.Item("empname", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = True
        grid_emp_enrolldetail.Item("clmlocation", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = True
        grid_emp_enrolldetail.Item("dept", grid_emp_enrolldetail.CurrentRow.Index).ReadOnly = True
        If grid_emp_enrolldetail.Columns(grid_emp_enrolldetail.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EMPLOYEE_CODE" Then
            cmbempcode = e.Control
            AddHandler cmbempcode.SelectedIndexChanged, AddressOf cmbempcode_SelectedIndexChanged
        End If
    End Sub

    Private Sub grid_emp_enrolldetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_emp_enrolldetail.KeyDown
        grid_emp_enrolldetail.EndEdit()
        If e.KeyCode = Keys.Down Then
            Dim rowindex As Integer = grid_emp_enrolldetail.CurrentCell.RowIndex
            If rowindex = grid_emp_enrolldetail.Rows.Count - 1 Then
                ObjclsGen.AddnewRow(dtbTEnroll)
            End If
        End If
    End Sub
   
#End Region

#Region " Functions/Procedures "
    Dim i As Integer
    Private Function alreadyfill() As Boolean
        Dim bln As Boolean = True
        If grid_emp_enrolldetail.Rows.Count > 1 Then
            For i = 0 To dtbTEnroll.Rows.Count - 2
                If cmbempcode.Text.Equals(grid_emp_enrolldetail.Item("clmemp_code", i).Value) Then
                    MsgBox(grid_emp_enrolldetail.Item("clmemp_code", i).Value & " Already in Grid", MsgBoxStyle.Information, Me.Text)
                    bln = False
                    Exit For
                End If
            Next
        End If
        Return bln
    End Function

    Private Function searchEmployeeData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            Dim strqry As String
            dtbTEnroll = New DataTable
            masterform.con.Close()
            strqry = "SELECT enrollment_id,t.employee_code,e.short_name,l.location_id,l.location_name,d.department_id,d.department_name " & _
                     "FROM tbl_training_enrollment t,tbl_employee e,tbl_location l,tbl_department d WHERE " & _
                     "trainer_id like '" & cmbtrainer.SelectedValue & "' and venue_id like '" & cmbvenue.SelectedValue & "' and " & _
                     "t.start_date like '" & dtfromdate.Value & "' AND t.end_date like '" & dttodate.Value & "' AND " & _
                     "t.location_id=l.location_id and t.department_id=d.department_id AND " & _
                     "t.employee_code=e.employee_code"
            If Not ObjclsGen.Getdata(masterform.con, strqry, dtbTEnroll) Then
                dbReturn = False
            Else
                masterform.con.Open()
                grid_emp_enrolldetail.AutoGenerateColumns = False
                grid_emp_enrolldetail.DataSource = Nothing
                grid_emp_enrolldetail.DataSource = dtbTEnroll
                dbReturn = True
            End If
            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateTEnrolldata() As Boolean
        Dim dbReturn As Boolean = True
        Try
            grid_emp_enrolldetail.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
            grid_emp_enrolldetail.EndEdit()
            If cmbtrainer.SelectedIndex < 0 Then
                MsgBox("Must select trainer name", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbtrainer.Focus()
            End If
            If IsDBNull(dtfromdate.Value) Then
                MsgBox("Must select Start Date", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                dtfromdate.Focus()
            End If
            If IsDBNull(dttodate.Value) Then
                MsgBox("Must select End Date", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                dttodate.Focus()
            End If
            If cmbvenue.SelectedIndex < 0 Then
                MsgBox("Must select Venue name", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbvenue.Focus()
            End If
            For Each dtrowTEnroll In dtbTEnroll.Rows
                If dtrowTEnroll.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowTEnroll("employee_code")) Or (dtrowTEnroll("employee_code").Equals(String.Empty)) Then
                        MsgBox("Must select employee code", MsgBoxStyle.Information, Me.Text)
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