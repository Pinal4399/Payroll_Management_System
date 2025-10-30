Imports System.Drawing
Public Class frm_Emp_Attendence

#Region "variables"
    Private dtbempAttendence, dtbLocation, dtbDepartment, dtbProcessPeriod As DataTable
    Dim dtrowempAttendence As DataRow
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
        dtbempAttendence = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub frm_Emp_Attendence_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbempAttendence.GetChanges IsNot Nothing Then
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

    Private Sub frm_Emp_Attendence_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)

        dtbProcessPeriod = New DataTable
        ObjclsGen.cmbprocessname(dtbProcessPeriod, cmbprocessperiod)
        grid_Emp_attendence.ReadOnly = True
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub cmbdeptname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbdeptname.SelectedIndexChanged
        ObjclsGen.getempcode(cmblocname.Text, cmbdeptname.Text, dtbempCode, grid_Emp_attendence)
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            cmblocname.Enabled = True
            If validateEmpattendenceData() Then
                If dtbempCode.Rows.Count > dtbempAttendence.Rows.Count Then
                    MsgBox("Some Employees are left so must enter all employees")
                End If
                objclsemppayroll.Saveempattendence(masterform.con, dtbempAttendence, cmblocname.SelectedValue, cmbdeptname.SelectedValue, cmbprocessperiod.SelectedValue)
                MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                grid_emp_attendence.ReadOnly = True
                searchEmployeeData()
                If Not dtbempCode.Rows.Count > dtbempAttendence.Rows.Count Then
                    grid_emp_attendence.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Try
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        dtbempAttendence.Clear()
        grid_Emp_attendence.DataSource = Nothing
        cmblocname.Enabled = True
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
        cmbprocessperiod.SelectedIndex = -1
    End Sub

    Private Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            Dim dbReturn As Boolean = True
            grid_Emp_attendence.EndEdit()
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
                grid_emp_attendence.ReadOnly = False
                If Not searchEmployeeData() Then
                    MsgBox("Record not found", MsgBoxStyle.Information, "Record Not Found")
                    dtbempAttendence.Clear()
                    grid_emp_attendence.AutoGenerateColumns = False
                    grid_emp_attendence.DataSource = Nothing
                    grid_emp_attendence.DataSource = dtbempAttendence
                    ObjclsGen.AddnewRow(dtbempAttendence)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

   
    Private Sub grid_emp_attendence_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_emp_attendence.CellLeave
        Try
            With grid_emp_attendence
                .CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
                .BindingContext(grid_emp_attendence.DataSource).EndCurrentEdit()
                If grid_emp_attendence.CurrentRow IsNot Nothing Then
                    Dim num As Integer
                    Dim numTotal As Decimal = 0.0
                    For num = 1 To 31
                        dtbempAttendence.Columns("day_" & num).AllowDBNull = True
                        If grid_emp_attendence.Item("day" & num, grid_emp_attendence.CurrentRow.Index).Value Is System.DBNull.Value Then
                            If (grid_emp_attendence.CurrentCell.Value Is System.DBNull.Value) Then
                                grid_emp_attendence.CurrentCell.Value = 0
                            End If
                        End If
                        numTotal = numTotal + Val(grid_emp_attendence.Item("day" & num, e.RowIndex).Value)
                    Next
                    grid_emp_attendence.Item("presenthrs", grid_emp_attendence.CurrentRow.Index).Value = numTotal
                    grid_emp_attendence.Item("presenthrs", grid_emp_attendence.CurrentRow.Index).ReadOnly = True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_emp_attendence_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grid_emp_attendence.CellValidating
        Try
            If grid_emp_attendence.Columns(grid_emp_attendence.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EMPLOYEE_CODE" Then
                RemoveHandler cmbempcode.SelectedIndexChanged, AddressOf cmbempcode_SelectedIndexChanged
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_emp_attendence_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_emp_attendence.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_emp_attendence_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grid_emp_attendence.EditingControlShowing
        Try
            grid_emp_attendence.Columns("empname").ReadOnly = True
            grid_emp_attendence.Columns("presenthrs").ReadOnly = True
            If grid_emp_attendence.Columns(grid_emp_attendence.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EMPLOYEE_CODE" Then
                cmbempcode = e.Control
                AddHandler cmbempcode.SelectedIndexChanged, AddressOf cmbempcode_SelectedIndexChanged
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_emp_attendence_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_emp_attendence.KeyDown
        grid_emp_attendence.EndEdit()
        If e.KeyCode = Keys.Down Then
            Dim rowindex As Integer = grid_emp_attendence.CurrentCell.RowIndex
            Dim clmindex As Integer = grid_emp_attendence.CurrentCell.ColumnIndex
            If rowindex = grid_emp_attendence.Rows.Count - 1 Then
                If clmindex = 1 Then
                    ObjclsGen.AddnewRow(dtbempAttendence)
                End If
            End If
        End If
    End Sub
   
    Private Sub cmbempcode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            grid_emp_attendence.Columns("empname").ReadOnly = True
            grid_emp_attendence.Columns("presenthrs").ReadOnly = True

            If grid_emp_attendence.CurrentRow IsNot Nothing Then
                If cmbempcode.SelectedIndex >= 0 Then

                    If alreadyfill() Then
                        grid_emp_attendence.Item("empname", grid_emp_attendence.CurrentRow.Index).Value = cmbempcode.DataSource.DefaultView(cmbempcode.SelectedIndex)("SHORT_NAME")
                        grid_emp_attendence.Item("empname", grid_emp_attendence.CurrentRow.Index).ReadOnly = True
                    Else
                        Exit Sub
                    End If
                Else
                    grid_emp_attendence.Item("empname", grid_emp_attendence.CurrentRow.Index).Value = String.Empty
                    grid_emp_attendence.Item("empname", grid_emp_attendence.CurrentRow.Index).ReadOnly = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Try
        End Try
    End Sub
 
   

#End Region

#Region " Functions/Procedures "

    Private Function alreadyfill() As Boolean
        Dim bln As Boolean = True
        If grid_emp_attendence.Rows.Count > 1 Then
            For i = 0 To dtbempAttendence.Rows.Count - 2
                If cmbempcode.Text.Equals(grid_emp_attendence.Item("empcode", i).Value) Then
                    MsgBox(grid_emp_attendence.Item("empcode", i).Value & " Already in Grid", MsgBoxStyle.Information, Me.Text)
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
            dtbempAttendence = New DataTable
            masterform.con.Close()
            strQry = "SELECT a.attendence_id,a.employee_code,e.short_name,a.present_hrs,a.day_1,a.day_2,a.day_3,a.day_4,a.day_5,a.day_6,a.day_7,a.day_8,a.day_9,a.day_10,a.day_11,a.day_12,a.day_13,a.day_14,a.day_15" & _
                                 ",a.day_16,a.day_17,a.day_18,a.day_19,a.day_20,a.day_21,a.day_22,a.day_23,a.day_24,a.day_25,a.day_26,a.day_27,a.day_28,a.day_29,a.day_30,a.day_31 FROM tbl_emp_attendence a,tbl_employee e WHERE " & _
                                 "a.location_id like '" & cmblocname.SelectedValue & "' AND " & _
                                 "a.department_id like '" & cmbdeptname.SelectedValue & "' AND " & _
                                 "a.period='" & cmbprocessperiod.Text.ToString & "' AND a.employee_code=e.employee_code"
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbempAttendence) Then
                dbReturn = False
            Else
                dbReturn = True
            End If
            For num = 1 To 31
                dtbempAttendence.Columns("day_" & num).DefaultValue = 10
                dtbempAttendence.Columns("day_" & num).AllowDBNull = False
                Select Case days
                    Case "02"
                        dtbempAttendence.Columns("day_29").DefaultValue = 0
                        dtbempAttendence.Columns("day_29").AllowDBNull = False
                        dtbempAttendence.Columns("day_30").DefaultValue = 0
                        dtbempAttendence.Columns("day_30").AllowDBNull = False
                        dtbempAttendence.Columns("day_31").DefaultValue = 0
                        dtbempAttendence.Columns("day_31").AllowDBNull = False
                        dtbempAttendence.Columns("present_hrs").DefaultValue = 280
                        grid_emp_attendence.Columns("day29").ReadOnly = True
                        grid_emp_attendence.Columns("day30").ReadOnly = True
                        grid_emp_attendence.Columns("day31").ReadOnly = True
                        grid_emp_attendence.Columns("day29").CellTemplate.Style.BackColor = Color.Olive
                        grid_emp_attendence.Columns("day30").CellTemplate.Style.BackColor = Color.Olive
                        grid_emp_attendence.Columns("day31").CellTemplate.Style.BackColor = Color.Olive
                    Case "04"
                        setgridcolor()
                    Case "06"
                        setgridcolor()
                    Case "09"
                        setgridcolor()
                    Case "11"
                        setgridcolor()
                    Case Else
                        dtbempAttendence.Columns("present_hrs").DefaultValue = 310
                        grid_emp_attendence.Columns("day29").ReadOnly = False
                        grid_emp_attendence.Columns("day30").ReadOnly = False
                        grid_emp_attendence.Columns("day31").ReadOnly = False
                        grid_emp_attendence.Columns("day29").CellTemplate.Style.BackColor = Nothing
                        grid_emp_attendence.Columns("day30").CellTemplate.Style.BackColor = Nothing
                        grid_emp_attendence.Columns("day31").CellTemplate.Style.BackColor = Nothing
                End Select
            Next
            masterform.con.Open()
            grid_emp_attendence.DataSource = Nothing
            grid_emp_attendence.AutoGenerateColumns = False
            grid_emp_attendence.DataSource = dtbempAttendence


            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateEmpattendenceData() As Boolean
        Dim dbReturn As Boolean = True
        grid_emp_attendence.EndEdit()
        If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
            dbReturn = False
        End If
        If cmbprocessperiod.SelectedIndex < 0 Then
            MsgBox("Must select Process Period", MsgBoxStyle.Critical, Me.Text)
            dbReturn = False
            cmbprocessperiod.Focus()
        End If
        For Each dtrowempAttendence In dtbempAttendence.Rows
            If dtrowempAttendence.RowState <> DataRowState.Deleted Then
                If IsDBNull(dtrowempAttendence("employee_code")) Or (dtrowempAttendence("employee_code").Equals(String.Empty)) Then
                    MsgBox("Select Employee Code", MsgBoxStyle.Information, Me.Text)
                    dbReturn = False
                End If

            End If
        Next
        Return dbReturn
    End Function

    Private Sub setgridcolor()
        dtbempAttendence.Columns("day_31").DefaultValue = 0
        dtbempAttendence.Columns("day_31").AllowDBNull = False
        dtbempAttendence.Columns("present_hrs").DefaultValue = 300
        grid_emp_attendence.Columns("day29").ReadOnly = False
        grid_emp_attendence.Columns("day30").ReadOnly = False
        grid_emp_attendence.Columns("day31").ReadOnly = True
        grid_emp_attendence.Columns("day29").CellTemplate.Style.BackColor = Nothing
        grid_emp_attendence.Columns("day30").CellTemplate.Style.BackColor = Nothing
        grid_emp_attendence.Columns("day31").CellTemplate.Style.BackColor = Color.Olive
    End Sub

#End Region

End Class