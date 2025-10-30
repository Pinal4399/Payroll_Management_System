Public Class frm_Emp_Overtime

#Region "variables"
    Private dtbempOvertimeAttendence, dtbLocation, dtbDepartment, dtbProcessPeriod As DataTable
    Dim dtrowempOvertimeAttendence As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclsemppayroll As New cls_payroll
    Dim dtbempCode As New DataTable
    Dim cmbempcode As New ComboBox
    Dim strQry As String
    Dim i As Integer
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbempOvertimeAttendence = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "


    Private Sub frm_Emp_Overtime_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbempOvertimeAttendence.GetChanges IsNot Nothing Then
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

    Private Sub frm_overtime_attendence_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)

        dtbProcessPeriod = New DataTable
        ObjclsGen.cmbprocessname(dtbProcessPeriod, cmbprocessperiod)
        grid_Emp_overtime_attendence.ReadOnly = True
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub cmbdeptname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdeptname.SelectedIndexChanged
        Try
            Dim strempcode As String
            strempcode = "SELECT a.location_id, a.department_id, a.employee_code, e.short_name" & _
                         " FROM (tbl_emp_attendence a INNER JOIN " & _
                         "tbl_employee e ON a.employee_code = e.employee_code) WHERE " & _
                         "(a.location_id IN(SELECT location_id FROM tbl_location WHERE " & _
                         "location_name = '" & cmblocname.Text.Trim & "') AND a.department_id IN(SELECT department_id" & _
                         " FROM tbl_department WHERE department_name = '" & cmbdeptname.Text.Trim & "'))"

            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempCode) Then
                With grid_Emp_overtime_attendence
                    CType(.Columns("empcode"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("empcode"), DataGridViewComboBoxColumn).DataSource = dtbempCode
                    CType(.Columns("empcode"), DataGridViewComboBoxColumn).ValueMember = "employee_code"
                    CType(.Columns("empcode"), DataGridViewComboBoxColumn).DisplayMember = "employee_code"
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            cmblocname.Enabled = True
            If validateEmpovertimeattendenceData() Then
                If objclsemppayroll.Saveempovertimeattendence(masterform.con, dtbempOvertimeAttendence, cmblocname.SelectedValue, cmbdeptname.SelectedValue, cmbprocessperiod.SelectedValue) Then
                    MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                    searchEmployeeData()
                    grid_Emp_overtime_attendence.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Try
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclear.Click
        dtbempOvertimeAttendence.Clear()
        grid_Emp_overtime_attendence.DataSource = Nothing
        cmblocname.Enabled = True
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
        cmbprocessperiod.SelectedIndex = -1
        cmbdays.SelectedIndex = -1
    End Sub

    Private Sub btncancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Dim dbReturn As Boolean = True
        grid_Emp_overtime_attendence.EndEdit()
        If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
            dbReturn = False
        End If
        If cmbprocessperiod.SelectedIndex < 0 Then
            MsgBox("Must select Process Period", MsgBoxStyle.Critical, "Invalid")
            dbReturn = False
            cmbprocessperiod.Focus()
        End If

        If dbReturn Then
            cmblocname.Enabled = False
            grid_Emp_overtime_attendence.ReadOnly = False
            If Not searchEmployeeData() Then
                MsgBox("Record not found", MsgBoxStyle.Information, "Record Not Found")
                dtbempOvertimeAttendence.Clear()
                grid_Emp_overtime_attendence.AutoGenerateColumns = False
                grid_Emp_overtime_attendence.DataSource = Nothing
                grid_Emp_overtime_attendence.DataSource = dtbempOvertimeAttendence
                ObjclsGen.AddnewRow(dtbempOvertimeAttendence)
            End If
        End If
    End Sub


    Private Sub grid_Emp_overtime_attendence_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grid_Emp_overtime_attendence.CellValidating
        Try
            With grid_Emp_overtime_attendence
                .CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
                .BindingContext(grid_Emp_overtime_attendence.DataSource).EndCurrentEdit()
                If grid_Emp_overtime_attendence.CurrentRow IsNot Nothing Then
                    Dim num As Integer
                    Dim numTotal As Decimal = 0.0
                    For num = 1 To 31
                        dtbempOvertimeAttendence.Columns("day_" & num).AllowDBNull = True
                        If grid_Emp_overtime_attendence.Item("day" & num, grid_Emp_overtime_attendence.CurrentRow.Index).Value Is System.DBNull.Value Then
                            If (grid_Emp_overtime_attendence.CurrentCell.Value Is System.DBNull.Value) Then
                                grid_Emp_overtime_attendence.CurrentCell.Value = 0
                            End If
                        End If
                        numTotal = numTotal + Val(grid_Emp_overtime_attendence.Item("day" & num, e.RowIndex).Value)
                    Next
                    grid_Emp_overtime_attendence.Item("overtimehrs", grid_Emp_overtime_attendence.CurrentRow.Index).Value = numTotal
                    grid_Emp_overtime_attendence.Item("overtimehrs", grid_Emp_overtime_attendence.CurrentRow.Index).ReadOnly = True
                End If
            End With
            If grid_Emp_overtime_attendence.Columns(grid_Emp_overtime_attendence.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EMPLOYEE_CODE" Then
                RemoveHandler cmbempcode.SelectedIndexChanged, AddressOf cmbempcode_SelectedIndexChanged
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_Emp_overtime_attendence_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_Emp_overtime_attendence.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_Emp_overtime_attendence_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grid_Emp_overtime_attendence.EditingControlShowing
        Try
            grid_Emp_overtime_attendence.Item("empname", grid_Emp_overtime_attendence.CurrentRow.Index).ReadOnly = True
            grid_Emp_overtime_attendence.Item("overtimehrs", grid_Emp_overtime_attendence.CurrentRow.Index).ReadOnly = True

            If grid_Emp_overtime_attendence.Columns(grid_Emp_overtime_attendence.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EMPLOYEE_CODE" Then
                cmbempcode = e.Control
                AddHandler cmbempcode.SelectedIndexChanged, AddressOf cmbempcode_SelectedIndexChanged
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub grid_Emp_overtime_attendence_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_Emp_overtime_attendence.KeyDown
        grid_Emp_overtime_attendence.EndEdit()
        If e.KeyCode = Keys.Down Then
            Dim rowindex As Integer = grid_Emp_overtime_attendence.CurrentCell.RowIndex
            Dim clmindex As Integer = grid_Emp_overtime_attendence.CurrentCell.ColumnIndex
            If rowindex = grid_Emp_overtime_attendence.Rows.Count - 1 Then
                If clmindex = 1 Then
                    ObjclsGen.AddnewRow(dtbempOvertimeAttendence)
                End If
            End If
        End If
    End Sub

    Private Sub cmbempcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If grid_Emp_overtime_attendence.CurrentRow IsNot Nothing Then
                If cmbempcode.SelectedIndex >= 0 Then
                    If alreadyfill() Then
                        grid_Emp_overtime_attendence.Item("empname", grid_Emp_overtime_attendence.CurrentRow.Index).Value = cmbempcode.DataSource.DefaultView(cmbempcode.SelectedIndex)("SHORT_NAME")
                        grid_Emp_overtime_attendence.Item("empname", grid_Emp_overtime_attendence.CurrentRow.Index).ReadOnly = True
                    Else
                        Exit Sub
                    End If
                Else
                    grid_Emp_overtime_attendence.Item("empname", grid_Emp_overtime_attendence.CurrentRow.Index).Value = String.Empty
                    grid_Emp_overtime_attendence.Item("empname", grid_Emp_overtime_attendence.CurrentRow.Index).ReadOnly = False
                End If
                End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Try
        End Try
    End Sub

    Private Sub cmbdays_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdays.SelectedIndexChanged
        Dim days As String = Mid(cmbprocessperiod.Text, 5)
        txthours.Enabled = True
        Select Case days
            Case "02"
                If cmbdays.Text = "29" Or cmbdays.Text = "30" Or cmbdays.Text = "31" Then
                    txthours.Enabled = False
                End If
            Case "04"
                txthours.Enabled = True
                If cmbdays.SelectedValue = 31 Then
                    txthours.Enabled = False
                End If
            Case "06"
                txthours.Enabled = True
                If cmbdays.SelectedValue = 31 Then
                    txthours.Enabled = False
                End If
            Case "09"
                txthours.Enabled = True
                If cmbdays.SelectedValue = 31 Then
                    txthours.Enabled = False
                End If
            Case "11"
                txthours.Enabled = True
                If cmbdays.SelectedValue = 31 Then
                    txthours.Enabled = False
                End If
            Case Else
                txthours.Enabled = True
        End Select
    End Sub

    Private Sub btnset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnset.Click
        Try
            With grid_Emp_overtime_attendence
                .CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
                .BindingContext(grid_Emp_overtime_attendence.DataSource).EndCurrentEdit()
                Dim j As Integer
                For j = 0 To grid_Emp_overtime_attendence.RowCount - 1
                    If grid_Emp_overtime_attendence.CurrentRow IsNot Nothing Then
                        Dim num As Integer
                        Dim numTotal As Decimal = 0.0
                        For num = 1 To 31
                            dtbempOvertimeAttendence.Columns("day_" & num).AllowDBNull = True
                            If (grid_Emp_overtime_attendence.CurrentCell.Value Is System.DBNull.Value) Then
                                grid_Emp_overtime_attendence.CurrentCell.Value = 0
                            End If
                            If (num = cmbdays.Text) Then
                                grid_Emp_overtime_attendence.Item("day" & num, j).Value = txthours.Text
                            End If
                            numTotal = numTotal + Val(grid_Emp_overtime_attendence.Item("day" & num, j).Value)
                        Next
                        grid_Emp_overtime_attendence.Item("overtimehrs", j).Value = numTotal
                        grid_Emp_overtime_attendence.Item("overtimehrs", j).ReadOnly = True
                    End If
                Next
            End With
            cmbdays.SelectedIndex = -1
            txthours.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

#End Region

#Region " Functions/Procedures "

    Private Function alreadyfill() As Boolean
        Dim bln As Boolean = True
        If grid_Emp_overtime_attendence.Rows.Count > 1 Then
            For i = 0 To dtbempOvertimeAttendence.Rows.Count - 2
                If cmbempcode.Text.Equals(grid_Emp_overtime_attendence.Item("empcode", i).Value) Then
                    MsgBox(grid_Emp_overtime_attendence.Item("empcode", i).Value & " Already in Grid", MsgBoxStyle.Information, Me.Text)
                    bln = False
                    Exit For
                End If
            Next
        End If
        Return bln
    End Function

    Private Function searchEmployeeData() As Boolean
        Dim dbReturn As Boolean = False
        Dim days As String = Mid(cmbprocessperiod.Text, 5)
        Dim num As Integer = 0
        Try
            dtbempOvertimeAttendence = New DataTable
            masterform.con.Close()
            strQry = "SELECT overtime_id,o.employee_code,e.short_name,overtime_hrs,day_1,day_2,day_3,day_4,day_5,day_6,day_7,day_8,day_9,day_10,day_11,day_12,day_13,day_14,day_15" & _
                     ",day_16,day_17,day_18,day_19,day_20,day_21,day_22,day_23,day_24,day_25,day_26,day_27,day_28,day_29,day_30,day_31 FROM tbl_emp_overtime o,tbl_employee e WHERE " & _
                     "(o.location_id like '" & cmblocname.SelectedValue & "' AND " & _
                     "o.department_id like '" & cmbdeptname.SelectedValue & "') AND " & _
                     "period='" & cmbprocessperiod.Text.ToString & "' AND o.employee_code=e.employee_code"

            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbempOvertimeAttendence) Then
                dbReturn = False
            Else
                dbReturn = True
            End If
            Select Case days
                Case "02"
                    grid_Emp_overtime_attendence.Columns("day29").ReadOnly = True
                    grid_Emp_overtime_attendence.Columns("day30").ReadOnly = True
                    grid_Emp_overtime_attendence.Columns("day31").ReadOnly = True
                    grid_Emp_overtime_attendence.Columns("day29").CellTemplate.Style.BackColor = Color.Olive
                    grid_Emp_overtime_attendence.Columns("day30").CellTemplate.Style.BackColor = Color.Olive
                    grid_Emp_overtime_attendence.Columns("day31").CellTemplate.Style.BackColor = Color.Olive
                Case "04"
                    setgridcolor()
                Case "06"
                    setgridcolor()
                Case "09"
                    setgridcolor()
                Case "11"
                    setgridcolor()
                Case Else
                    grid_Emp_overtime_attendence.Columns("day30").ReadOnly = False
                    grid_Emp_overtime_attendence.Columns("day31").ReadOnly = False
                    grid_Emp_overtime_attendence.Columns("day29").CellTemplate.Style.BackColor = Nothing
                    grid_Emp_overtime_attendence.Columns("day30").CellTemplate.Style.BackColor = Nothing
                    grid_Emp_overtime_attendence.Columns("day31").CellTemplate.Style.BackColor = Nothing
            End Select

            For num = 1 To 31
                dtbempOvertimeAttendence.Columns("day_" & num).DefaultValue = 0
                dtbempOvertimeAttendence.Columns("day_" & num).AllowDBNull = False
            Next
            dtbempOvertimeAttendence.Columns("overtime_hrs").DefaultValue = 0

            masterform.con.Open()
            grid_Emp_overtime_attendence.DataSource = Nothing
            grid_Emp_overtime_attendence.AutoGenerateColumns = False
            grid_Emp_overtime_attendence.DataSource = dtbempOvertimeAttendence

            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateEmpovertimeattendenceData() As Boolean
        Dim dbReturn As Boolean = True
        Try
            grid_Emp_overtime_attendence.EndEdit()
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            If cmbprocessperiod.SelectedIndex < 0 Then
                MsgBox("Must select Process Period", MsgBoxStyle.Critical, Me.Text)
                dbReturn = False
                cmbprocessperiod.Focus()
            End If
            For Each dtrowempOvertimeAttendence In dtbempOvertimeAttendence.Rows
                If dtrowempOvertimeAttendence.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowempOvertimeAttendence("employee_code")) Or (dtrowempOvertimeAttendence("employee_code").Equals(String.Empty)) Then
                        MsgBox("Select Employee Code", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Sub setgridcolor()
        grid_Emp_overtime_attendence.Columns("day29").ReadOnly = False
        grid_Emp_overtime_attendence.Columns("day30").ReadOnly = False
        grid_Emp_overtime_attendence.Columns("day31").ReadOnly = True
        grid_Emp_overtime_attendence.Columns("day29").CellTemplate.Style.BackColor = Nothing
        grid_Emp_overtime_attendence.Columns("day30").CellTemplate.Style.BackColor = Nothing
        grid_Emp_overtime_attendence.Columns("day31").CellTemplate.Style.BackColor = Color.Olive
    End Sub
#End Region
    
End Class