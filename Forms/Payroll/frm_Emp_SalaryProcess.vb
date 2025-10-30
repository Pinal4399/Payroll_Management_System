Public Class frm_Emp_SalaryProcess

#Region "variables"
    Private dtbempsalprocess, dtbLocation, dtbDepartment, dtbProcessPeriod, dtbattendence As DataTable
    Dim dtrowempsalprocess, dtrow As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclsemppayroll As New cls_payroll
    Dim dtbempCode As New DataTable
    Dim cmbempcode As ComboBox
    Dim strQry As String
    Dim rowindex As Integer
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbempsalprocess = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_Emp_SalaryProcess_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbempsalprocess.GetChanges IsNot Nothing Then
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

    Private Sub frm_Emp_SalaryProcess_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbltotalemp.Text = "Total Employees :" & 0
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)

        dtbProcessPeriod = New DataTable
        ObjclsGen.cmbprocessname(dtbProcessPeriod, cmbprocessperiod)
        grid_emp_salaryprocess.ReadOnly = True
    End Sub

    Private Sub cmbprocessperiod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbprocessperiod.SelectedIndexChanged
        Try
            Dim monthday As Integer
            masterform.con.Close()
            masterform.con.Open()
            masterform.cmd.CommandText = "SELECT month_days FROM tbl_process_period WHERE period='" & cmbprocessperiod.Text.Trim & "'"
            masterform.cmd.Connection = masterform.con
            masterform.dr = masterform.cmd.ExecuteReader
            If masterform.dr.HasRows Then
                masterform.dr.Read()
                monthday = masterform.dr.Item(0)
            End If
            txtworkinghrs.Text = (monthday * 10)
            masterform.dr.Close()
            masterform.con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            grid_emp_salaryprocess.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange)
            grid_emp_salaryprocess.EndEdit()
            cmblocname.Enabled = True
            cmbdeptname.Enabled = True
            cmbprocessperiod.Enabled = True
            If ValidateData() Then
                If objclsemppayroll.Saveempsalaryprocess(masterform.con, dtbempsalprocess, cmblocname.SelectedValue, cmbdeptname.SelectedValue, cmbprocessperiod.SelectedValue) Then
                    searchEmployeeData()
                    grid_emp_salaryprocess.ReadOnly = True
                End If
                MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                totalsalarycount()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        lbltotalemp.Text = "Total Employees :" & 0
        dtbempsalprocess.Clear()
        grid_emp_salaryprocess.DataSource = Nothing
        cmblocname.Enabled = True
        cmbdeptname.Enabled = True
        cmbprocessperiod.Enabled = True
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
        cmbprocessperiod.SelectedIndex = -1
        txtworkinghrs.Text = ""
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Dim dbReturn As Boolean = True
        grid_emp_salaryprocess.EndEdit()
        If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
            dbReturn = False
        End If
        If cmbprocessperiod.SelectedIndex < 0 Then
            MsgBox("Must select Process Period", MsgBoxStyle.Critical, Me.Text)
            dbReturn = False
            cmbprocessperiod.Focus()
        End If

        If dbReturn Then
            grid_emp_salaryprocess.ReadOnly = True
            cmblocname.Enabled = False
            cmbdeptname.Enabled = False
            cmbprocessperiod.Enabled = False
            If Not searchEmployeeData() Then
                MsgBox("Record not found", MsgBoxStyle.Information, "Record Not Found")
            End If
        End If
    End Sub

    Private Sub grid_emp_salaryprocess_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_emp_salaryprocess.DataError
        e.Cancel = True
    End Sub
#End Region

#Region " Functions "
    Private Function searchEmployeeData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbempsalprocess = New DataTable
            masterform.con.Close()
            strQry = "SELECT 1 as is_added,short_name,employee_code,salary,cheque_salary,present_hrs,payable_salary,overtime_hrs,overtime_salary,total_salary,cash_salary,basic,da,hra,ca,ea,wa,pt " & _
                     "FROM tbl_emp_salaryprocess  WHERE (location_id like '" & cmblocname.SelectedValue & "' AND " & _
                     "department_id like '" & cmbdeptname.SelectedValue & "') AND " & _
                     "period='" & cmbprocessperiod.Text.ToString & "'"

            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbempsalprocess) Then
               
                strQry = "SELECT 0 AS is_added, tbl_employee.payroll_type, tbl_location.location_id, tbl_department.department_id, tbl_empsalary.salary, " & _
                         "tbl_empsalary.cheque_salary, tbl_employee.short_name, tbl_emp_attendence.employee_code, tbl_emp_attendence.period, " & _
                         "tbl_emp_overtime.overtime_hrs, tbl_emp_attendence.present_hrs " & _
                         "FROM (((((tbl_location INNER JOIN " & _
                         "tbl_emp_attendence ON tbl_location.location_id = tbl_emp_attendence.location_id) INNER JOIN " & _
                         "tbl_department ON tbl_emp_attendence.department_id = tbl_department.department_id) INNER JOIN " & _
                         "tbl_empsalary ON tbl_emp_attendence.employee_code = tbl_empsalary.employee_code) INNER JOIN " & _
                         "tbl_employee ON tbl_emp_attendence.employee_code = tbl_employee.employee_code) LEFT OUTER JOIN " & _
                         "tbl_emp_overtime ON tbl_emp_attendence.employee_code = tbl_emp_overtime.employee_code) " & _
                         "WHERE tbl_emp_attendence.location_id like '" & cmblocname.SelectedValue & "' AND " & _
                         "tbl_emp_attendence.department_id like '" & cmbdeptname.SelectedValue & _
                         "' AND tbl_emp_attendence.period like '" & cmbprocessperiod.Text & "'"

                If ObjclsGen.Getdata(masterform.con, strQry, dtbempsalprocess) Then
                    For Each dtrow In dtbempsalprocess.Rows
                        With grid_emp_salaryprocess
                            CType(.Columns("empname"), DataGridViewTextBoxColumn).DataPropertyName = "short_name"
                            CType(.Columns("empcode"), DataGridViewTextBoxColumn).DataPropertyName = "employee_code"
                            CType(.Columns("presenthrs"), DataGridViewTextBoxColumn).DataPropertyName = "present_hrs"
                            CType(.Columns("realsal"), DataGridViewTextBoxColumn).DataPropertyName = "salary"
                            CType(.Columns("chequesal"), DataGridViewTextBoxColumn).DataPropertyName = "cheque_salary"
                            CType(.Columns("overtimehrs"), DataGridViewTextBoxColumn).DataPropertyName = "overtime_hrs"
                        End With
                    Next
                    For Each dtrow In dtbempsalprocess.Rows
                        If IsDBNull(dtrow("overtime_hrs")) Then
                            dtrow("overtime_hrs") = 0
                        End If
                    Next
                    masterform.con.Open()
                    grid_emp_salaryprocess.DataSource = Nothing
                    grid_emp_salaryprocess.AutoGenerateColumns = False
                    grid_emp_salaryprocess.DataSource = dtbempsalprocess

                    dtbempsalprocess.Columns.Add("payable_salary")
                    dtbempsalprocess.Columns.Add("overtime_salary")
                    dtbempsalprocess.Columns.Add("total_salary")
                    dtbempsalprocess.Columns.Add("cash_salary")
                    dtbempsalprocess.Columns.Add("basic")
                    dtbempsalprocess.Columns.Add("da")
                    dtbempsalprocess.Columns.Add("hra")
                    dtbempsalprocess.Columns.Add("ca")
                    dtbempsalprocess.Columns.Add("ea")
                    dtbempsalprocess.Columns.Add("wa")
                    dtbempsalprocess.Columns.Add("pt")
                  
                    For rowindex = 0 To grid_emp_salaryprocess.Rows.Count - 1
                       
                        If dtbempsalprocess.Rows(rowindex).Item("payroll_type").Equals("Monthly") Then
                            dtbempsalprocess.Rows(rowindex).Item("payable_salary") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value - ((grid_emp_salaryprocess.Item("realsal", rowindex).Value) / 300) * (CDbl(Mid(txtworkinghrs.Text, 1)) - grid_emp_salaryprocess.Item("presenthrs", rowindex).Value)), "f")
                        Else
                            dtbempsalprocess.Rows(rowindex).Item("payable_salary") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value), "f")
                        End If
                        grid_emp_salaryprocess.Columns("payablesal").DataPropertyName = "payable_salary"
                        dtbempsalprocess.Rows(rowindex).Item("overtime_salary") = Format(CDec(((grid_emp_salaryprocess.Item("realsal", rowindex).Value) / 300) * (grid_emp_salaryprocess.Item("overtimehrs", rowindex).Value)), "f")
                        grid_emp_salaryprocess.Columns("overtimesal").DataPropertyName = "overtime_salary"
                       

                        Select Case dtbempsalprocess.Rows(rowindex).Item("salary")

                            Case 4200 To 5000
                                grid_emp_salaryprocess.Columns("basic").DataPropertyName = "basic"
                                dtbempsalprocess.Rows(rowindex).Item("basic") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("da").DataPropertyName = "da"
                                dtbempsalprocess.Rows(rowindex).Item("da") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 30 / 100, "f")
                                grid_emp_salaryprocess.Columns("hra").DataPropertyName = "hra"
                                dtbempsalprocess.Rows(rowindex).Item("hra") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 55 / 100, "f")
                                grid_emp_salaryprocess.Columns("pt").DataPropertyName = "pt"
                                dtbempsalprocess.Rows(rowindex).Item("pt") = 20.0
                            Case 5001 To 6000
                                grid_emp_salaryprocess.Columns("basic").DataPropertyName = "basic"
                                dtbempsalprocess.Rows(rowindex).Item("basic") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("da").DataPropertyName = "da"
                                dtbempsalprocess.Rows(rowindex).Item("da") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 25 / 100, "f")
                                grid_emp_salaryprocess.Columns("hra").DataPropertyName = "hra"
                                dtbempsalprocess.Rows(rowindex).Item("hra") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 40 / 100, "f")
                                grid_emp_salaryprocess.Columns("ca").DataPropertyName = "ca"
                                dtbempsalprocess.Rows(rowindex).Item("ca") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 10 / 100, "f")
                                grid_emp_salaryprocess.Columns("ea").DataPropertyName = "ea"
                                dtbempsalprocess.Rows(rowindex).Item("ea") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 5 / 100, "f")
                                grid_emp_salaryprocess.Columns("wa").DataPropertyName = "wa"
                                dtbempsalprocess.Rows(rowindex).Item("wa") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 5 / 100, "f")
                                grid_emp_salaryprocess.Columns("pt").DataPropertyName = "pt"
                                dtbempsalprocess.Rows(rowindex).Item("pt") = 20.0
                            Case 6001 To 7000
                                grid_emp_salaryprocess.Columns("basic").DataPropertyName = "basic"
                                dtbempsalprocess.Rows(rowindex).Item("basic") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("da").DataPropertyName = "da"
                                dtbempsalprocess.Rows(rowindex).Item("da") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 25 / 100, "f")
                                grid_emp_salaryprocess.Columns("hra").DataPropertyName = "hra"
                                dtbempsalprocess.Rows(rowindex).Item("hra") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 40 / 100, "f")
                                grid_emp_salaryprocess.Columns("ca").DataPropertyName = "ca"
                                dtbempsalprocess.Rows(rowindex).Item("ca") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 10 / 100, "f")
                                grid_emp_salaryprocess.Columns("ea").DataPropertyName = "ea"
                                dtbempsalprocess.Rows(rowindex).Item("ea") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 5 / 100, "f")
                                grid_emp_salaryprocess.Columns("wa").DataPropertyName = "wa"
                                dtbempsalprocess.Rows(rowindex).Item("wa") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 5 / 100, "f")
                                grid_emp_salaryprocess.Columns("pt").DataPropertyName = "pt"
                                dtbempsalprocess.Rows(rowindex).Item("pt") = 80.0
                            Case 7001 To 8000
                                grid_emp_salaryprocess.Columns("basic").DataPropertyName = "basic"
                                dtbempsalprocess.Rows(rowindex).Item("basic") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("da").DataPropertyName = "da"
                                dtbempsalprocess.Rows(rowindex).Item("da") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 25 / 100, "f")
                                grid_emp_salaryprocess.Columns("hra").DataPropertyName = "hra"
                                dtbempsalprocess.Rows(rowindex).Item("hra") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 40 / 100, "f")
                                grid_emp_salaryprocess.Columns("ca").DataPropertyName = "ca"
                                dtbempsalprocess.Rows(rowindex).Item("ca") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("ea").DataPropertyName = "ea"
                                dtbempsalprocess.Rows(rowindex).Item("ea") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 2 / 100, "f")
                                grid_emp_salaryprocess.Columns("wa").DataPropertyName = "wa"
                                dtbempsalprocess.Rows(rowindex).Item("wa") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 3 / 100, "f")
                                grid_emp_salaryprocess.Columns("pt").DataPropertyName = "pt"
                                dtbempsalprocess.Rows(rowindex).Item("pt") = 80.0
                            Case 8001 To 10150
                                grid_emp_salaryprocess.Columns("basic").DataPropertyName = "basic"
                                dtbempsalprocess.Rows(rowindex).Item("basic") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("da").DataPropertyName = "da"
                                dtbempsalprocess.Rows(rowindex).Item("da") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 25 / 100, "f")
                                grid_emp_salaryprocess.Columns("hra").DataPropertyName = "hra"
                                dtbempsalprocess.Rows(rowindex).Item("hra") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 40 / 100, "f")
                                grid_emp_salaryprocess.Columns("ca").DataPropertyName = "ca"
                                dtbempsalprocess.Rows(rowindex).Item("ca") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("ea").DataPropertyName = "ea"
                                dtbempsalprocess.Rows(rowindex).Item("ea") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 2 / 100, "f")
                                grid_emp_salaryprocess.Columns("wa").DataPropertyName = "wa"
                                dtbempsalprocess.Rows(rowindex).Item("wa") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 3 / 100, "f")
                                grid_emp_salaryprocess.Columns("pt").DataPropertyName = "pt"
                                dtbempsalprocess.Rows(rowindex).Item("pt") = 150.0
                            Case 10150 To 10999
                                grid_emp_salaryprocess.Columns("basic").DataPropertyName = "basic"
                                dtbempsalprocess.Rows(rowindex).Item("basic") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 35 / 100, "f")
                                grid_emp_salaryprocess.Columns("da").DataPropertyName = "da"
                                dtbempsalprocess.Rows(rowindex).Item("da") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 50 / 100, "f") - 1200
                                grid_emp_salaryprocess.Columns("hra").DataPropertyName = "hra"
                                dtbempsalprocess.Rows(rowindex).Item("hra") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("ca").DataPropertyName = "ca"
                                dtbempsalprocess.Rows(rowindex).Item("ca") = 800.0
                                grid_emp_salaryprocess.Columns("ea").DataPropertyName = "ea"
                                dtbempsalprocess.Rows(rowindex).Item("ea") = 400.0
                                grid_emp_salaryprocess.Columns("pt").DataPropertyName = "pt"
                                dtbempsalprocess.Rows(rowindex).Item("pt") = 150.0
                            Case 11000 To 11999
                                grid_emp_salaryprocess.Columns("basic").DataPropertyName = "basic"
                                dtbempsalprocess.Rows(rowindex).Item("basic") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 35 / 100, "f")
                                grid_emp_salaryprocess.Columns("da").DataPropertyName = "da"
                                dtbempsalprocess.Rows(rowindex).Item("da") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 50 / 100, "f") - 1200
                                grid_emp_salaryprocess.Columns("hra").DataPropertyName = "hra"
                                dtbempsalprocess.Rows(rowindex).Item("hra") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("ca").DataPropertyName = "ca"
                                dtbempsalprocess.Rows(rowindex).Item("ca") = 800.0
                                grid_emp_salaryprocess.Columns("ea").DataPropertyName = "ea"
                                dtbempsalprocess.Rows(rowindex).Item("ea") = 400.0
                                grid_emp_salaryprocess.Columns("pt").DataPropertyName = "pt"
                                dtbempsalprocess.Rows(rowindex).Item("pt") = 150.0
                            Case Is >= 12000
                                grid_emp_salaryprocess.Columns("basic").DataPropertyName = "basic"
                                dtbempsalprocess.Rows(rowindex).Item("basic") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 35 / 100, "f")
                                grid_emp_salaryprocess.Columns("da").DataPropertyName = "da"
                                dtbempsalprocess.Rows(rowindex).Item("da") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 50 / 100, "f") - 1200.0
                                grid_emp_salaryprocess.Columns("hra").DataPropertyName = "hra"
                                dtbempsalprocess.Rows(rowindex).Item("hra") = Format(CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value) * 15 / 100, "f")
                                grid_emp_salaryprocess.Columns("ca").DataPropertyName = "ca"
                                dtbempsalprocess.Rows(rowindex).Item("ca") = 800.0
                                grid_emp_salaryprocess.Columns("ea").DataPropertyName = "ea"
                                dtbempsalprocess.Rows(rowindex).Item("ea") = 400.0
                                grid_emp_salaryprocess.Columns("pt").DataPropertyName = "pt"
                                dtbempsalprocess.Rows(rowindex).Item("pt") = 150.0
                        End Select
                        dtbempsalprocess.Rows(rowindex).Item("total_salary") = Format(CDec(grid_emp_salaryprocess.Item("payablesal", rowindex).Value) + CDec(grid_emp_salaryprocess.Item("overtimesal", rowindex).Value) - CDec(grid_emp_salaryprocess.Item("pt", rowindex).Value), "f")
                        grid_emp_salaryprocess.Columns("totalsal").DataPropertyName = "total_salary"
                        dtbempsalprocess.Rows(rowindex).Item("cash_salary") = CInt(grid_emp_salaryprocess.Item("totalsal", rowindex).Value - grid_emp_salaryprocess.Item("chequesal", rowindex).Value)
                        grid_emp_salaryprocess.Columns("cashsal").DataPropertyName = "cash_salary"
                    Next
                    For Each dtrow In dtbempsalprocess.Rows
                        If IsDBNull(dtrow("ca")) Then
                            dtrow("ca") = 0
                        End If
                        If IsDBNull(dtrow("ea")) Then
                            dtrow("ea") = 0
                        End If
                        If IsDBNull(dtrow("wa")) Then
                            dtrow("wa") = 0
                        End If
                    Next
                End If
            End If
            grid_emp_salaryprocess.AutoGenerateColumns = False
            grid_emp_salaryprocess.DataSource = Nothing
            grid_emp_salaryprocess.DataSource = dtbempsalprocess

            totalsalarycount()
            If grid_emp_salaryprocess.RowCount > 0 Then
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

    Private Sub totalsalarycount()
        txtrealsal.Text = 0
        txtchequesal.Text = 0
        txtpayablesal.Text = 0
        txtovertimesal.Text = 0
        txtcashsal.Text = 0
        For rowindex = 0 To grid_emp_salaryprocess.Rows.Count - 1
            txtrealsal.Text = CDbl(txtrealsal.Text) + CDec(grid_emp_salaryprocess.Item("realsal", rowindex).Value)
            txtchequesal.Text = CDbl(txtchequesal.Text) + CDec(grid_emp_salaryprocess.Item("chequesal", rowindex).Value)
            txtpayablesal.Text = CDbl(txtpayablesal.Text) + CDec(grid_emp_salaryprocess.Item("payablesal", rowindex).Value)
            txtovertimesal.Text = CDbl(txtovertimesal.Text) + CDec(grid_emp_salaryprocess.Item("overtimesal", rowindex).Value)
            txtcashsal.Text = CDbl(txtcashsal.Text) + CDec(grid_emp_salaryprocess.Item("cashsal", rowindex).Value)
        Next
        lbltotalemp.Text = "Total Employees :" & grid_emp_salaryprocess.RowCount
    End Sub

    Private Function ValidateData() As Boolean
        Dim dbReturn As Boolean = True
        If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
            dbReturn = False
        End If
        If cmbprocessperiod.SelectedIndex < 0 Then
            MsgBox("Must select Process Period", MsgBoxStyle.Information, Me.Text)
            dbReturn = False
            cmbprocessperiod.Focus()
        End If
        Return dbReturn
    End Function
#End Region

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        Try
            Dim dbReturn As Boolean = True
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            If cmbprocessperiod.SelectedIndex < 0 Then
                MsgBox("Must select Process Period", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbprocessperiod.Focus()
            End If
           
            If dbreturn Then
                dtbLocation = New DataTable
                strQry = "select * from tbl_emp_salaryprocess where location_id like '" & cmblocname.SelectedValue & "' AND department_id like '" & cmbdeptname.SelectedValue & "' AND period like '" & cmbprocessperiod.Text.Trim & "'"
                If ObjclsGen.Getdata(masterform.con, strQry, dtbLocation) Then
                    Dim reportview As New Reportviewer("finalsalary", dtbLocation)
                    reportview.Show()
                Else
                    MsgBox("There is no records for selection", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

   
End Class