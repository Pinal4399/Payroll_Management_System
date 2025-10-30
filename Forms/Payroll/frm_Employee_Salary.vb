Public Class frm_Employee_Salary

#Region "variables"
    Private dtbempsalarydetail, dtbLocation, dtbDepartment As DataTable
    Dim dtrowempsalary, dtrow As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclsemppayroll As New cls_payroll
    Dim dtbempCode As New DataTable
    'Dim txtchequesal, txtrealsal As TextBox
    Dim strQry As String
    Dim i, j As Integer
#End Region

#Region " Constructors "

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbempsalarydetail = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_Employee_Salary_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbempsalarydetail.GetChanges IsNot Nothing Then
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

    Private Sub frm_Employee_Salary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)
        grid_emp_salary.ReadOnly = True
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
        lbltotalemp.Text = "Total Employees :" & 0
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            grid_emp_salary.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
            grid_emp_salary.EndEdit()
            cmblocname.Enabled = True
            If validateEmpSalarydata() Then
                If objclsemppayroll.Saveempsalarydetail(masterform.con, dtbempsalarydetail, cmblocname.SelectedValue, cmbdeptname.SelectedValue) Then
                    searchEmployeeData()
                    grid_emp_salary.ReadOnly = True
                End If
                MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                lbltotalemp.Visible = True
                lbltotalemp.Text = "Total Employees :" & grid_emp_salary.RowCount
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.Enabled = True
        dtbempsalarydetail.Clear()
        grid_emp_salary.DataSource = Nothing
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
        lbltotalemp.Text = "Total Employees :" & 0
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click

        If validateEmpSalarydata() Then
            cmblocname.Enabled = False
            If Not searchEmployeeData() Then
                MsgBox("Record not found...", MsgBoxStyle.Information, "Data not found")
                lbltotalemp.Text = "Total Employees :" & 0
            Else
                lbltotalemp.Visible = True
                lbltotalemp.Text = "Total Employees :" & grid_emp_salary.RowCount
            End If
        End If
    End Sub
    Private Sub grid_emp_salary_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_emp_salary.DataError
        e.Cancel = True
    End Sub
#End Region

#Region " Functions/Procedures "
    Private Function searchEmployeeData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbempsalarydetail = New DataTable
            masterform.con.Close()
            strQry = "SELECT 1 as is_added,s.employee_code,e.short_name,s.salary,s.cheque_salary,s.payable_salary " & _
                     "FROM tbl_employee e,tbl_empsalary s " & _
                     "WHERE s.location_id like '" & cmblocname.SelectedValue & "' AND " & _
                     "s.department_id like '" & cmbdeptname.SelectedValue & "' " & _
                     " AND s.employee_code=e.employee_code"

            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbempsalarydetail) Then

                strQry = "SELECT 0 As is_added,tbl_employee.employee_code,tbl_location.location_id, tbl_department.department_id, tbl_employee.salary,tbl_emp_earning.earning_code, tbl_emp_earning.cheque_salary, tbl_employee.short_name " & _
                         " FROM (((tbl_location INNER JOIN " & _
                          "tbl_employee ON tbl_location.location_id = tbl_employee.location_id) INNER JOIN " & _
                          "tbl_department ON tbl_employee.department_id = tbl_department.department_id) LEFT OUTER JOIN " & _
                          "tbl_emp_earning ON tbl_employee.employee_code = tbl_emp_earning.employee_code) " & _
                          "WHERE (tbl_employee.location_id LIKE '" & cmblocname.SelectedValue & "') AND " & _
                          "(tbl_employee.department_id LIKE '" & cmbdeptname.SelectedValue & "') AND tbl_employee.emp_inactive=0"
                If ObjclsGen.Getdata(masterform.con, strQry, dtbempsalarydetail) Then

                    For i = 0 To dtbempsalarydetail.Rows.Count - 1
                        If i = dtbempsalarydetail.Rows.Count - 1 Then
                            Exit For
                        End If
                        If dtbempsalarydetail.Rows(i).Item(1).ToString.Equals(dtbempsalarydetail.Rows(i + 1).Item(1).ToString) Then
                            For j = 0 To dtbempsalarydetail.Rows.Count - 1
                                If dtbempsalarydetail.Rows(j).Item(5).ToString.Equals("BCW") Then
                                    dtbempsalarydetail.Rows.Remove(dtbempsalarydetail.Rows(j))
                                    i = i - 1
                                    Exit For
                                End If
                            Next
                        End If
                    Next

                    For Each dtrow In dtbempsalarydetail.Rows
                        If IsDBNull(dtrow("cheque_salary")) Then
                            dtrow("cheque_salary") = 0.0
                        End If
                        If (dtrow("earning_code")).Equals("BCW") Then
                            dtrow("cheque_salary") = 0.0
                        End If
                    Next
                    masterform.con.Open()
                    grid_emp_salary.AutoGenerateColumns = False
                    grid_emp_salary.DataSource = Nothing

                    grid_emp_salary.DataSource = dtbempsalarydetail
                    dtbempsalarydetail.Columns.Add("payable_salary")
                    Dim rowindex As Integer
                    For rowindex = 0 To grid_emp_salary.Rows.Count - 1
                        dtbempsalarydetail.Rows(rowindex).Item("payable_salary") = CDec(grid_emp_salary.Item("realsal", rowindex).Value - grid_emp_salary.Item("chequesal", rowindex).Value)
                        grid_emp_salary.Columns("payablesal").DataPropertyName = "payable_salary"
                    Next
                End If
            End If
            grid_emp_salary.AutoGenerateColumns = False
            grid_emp_salary.DataSource = Nothing
            grid_emp_salary.DataSource = dtbempsalarydetail
            If grid_emp_salary.RowCount > 0 Then
                dbReturn = True
            Else
                dbReturn = False
            End If
            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateEmpSalarydata() As Boolean
        Dim dbReturn As Boolean = True
        Try
            grid_emp_salary.EndEdit()
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

#End Region
    
    
End Class