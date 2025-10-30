Imports System.Data.SqlClient
Public Class cls_payroll

#Region " Variable Declaratios "
    Dim trnOledb As sqlTransaction
    Dim cmdSave As sqlCommand
    Dim cmdDelete As sqlCommand
    Dim strSQL, strempsal As String
#End Region

#Region " Functions "


    Public Function Saveempsalarydetail(ByVal empcon As sqlConnection, ByVal dtblempdetail As DataTable, ByVal location_id As Integer, ByVal dept_id As Integer) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowemployee As DataRow
        masterform.con.Close()
        masterform.con.Open()
        trnOledb = empcon.BeginTransaction
        Try
            For Each dtrowemployee In dtblempdetail.Rows
                If dtrowemployee.RowState = DataRowState.Deleted Then
                    cmdDelete = New sqlCommand
                    strSQL = "DELETE FROM tbl_empsalary where employee_code='" & dtrowemployee("employee_code", DataRowVersion.Original) & " '"
                    With cmdDelete
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = False

                ElseIf dtrowemployee("is_added") = 0 Then
                    cmdSave = New sqlCommand
                    strSQL = "INSERT INTO tbl_empsalary (location_id,department_id,employee_code,salary,cheque_salary,payable_salary,is_added) " & _
                    "VALUES( " & location_id & _
                    "," & dept_id & ",'" & (Trim(dtrowemployee("employee_code").ToString)) & _
                    "'," & (Trim(dtrowemployee("salary").ToString)) & "," & (Trim(dtrowemployee("cheque_salary").ToString)) & _
                    "," & (Trim(dtrowemployee("payable_salary").ToString)) & "," & Val(1) & " )"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee("is_added") = 1 Then
                    cmdSave = New sqlCommand
                    strSQL = "UPDATE tbl_empsalary SET " & _
                    "employee_code='" & (Trim(dtrowemployee("employee_code").ToString)) & _
                    "',salary=" & (Trim(dtrowemployee("salary"))) & ",cheque_salary=" & (Trim(dtrowemployee("cheque_salary"))) & _
                    ",payable_salary=" & (Trim(dtrowemployee("payable_salary"))) & _
                    " where employee_code ='" & (Trim(dtrowemployee("employee_code").ToString)) & "'"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                End If
            Next
            trnOledb.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            trnOledb.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function

    Public Function Saveempattendence(ByVal empcon As sqlConnection, ByVal dtblempdetail As DataTable, ByVal location_id As Integer, ByVal dept_id As Integer, ByVal period As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowemployeeattend As DataRow
        masterform.con.Close()
        masterform.con.Open()
        trnOledb = empcon.BeginTransaction

        Try
            For Each dtrowemployeeattend In dtblempdetail.Rows
                If dtrowemployeeattend.RowState = DataRowState.Added Then
                    cmdSave = New sqlCommand
                    strSQL = "INSERT INTO tbl_emp_attendence(location_id,department_id,period,employee_code" & _
                    ",present_hrs,day_1,day_2,day_3,day_4,day_5,day_6,day_7,day_8,day_9,day_10,day_11,day_12,day_13,day_14,day_15,day_16, " & _
                    "day_17,day_18,day_19,day_20,day_21,day_22,day_23,day_24,day_25,day_26,day_27,day_28,day_29,day_30,day_31)" & _
                    " VALUES( " & location_id & "," & dept_id & _
                    ",'" & period & "','" & (Trim(dtrowemployeeattend("employee_code").ToString)) & _
                    "'," & Trim(dtrowemployeeattend("present_hrs").ToString) & _
                    "," & (Trim(dtrowemployeeattend("day_1").ToString)) & "," & (Trim(dtrowemployeeattend("day_2").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_3").ToString)) & "," & (Trim(dtrowemployeeattend("day_4").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_5").ToString)) & "," & (Trim(dtrowemployeeattend("day_6").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_7").ToString)) & "," & (Trim(dtrowemployeeattend("day_8").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_9").ToString)) & "," & (Trim(dtrowemployeeattend("day_10").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_11").ToString)) & "," & (Trim(dtrowemployeeattend("day_12").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_13").ToString)) & "," & (Trim(dtrowemployeeattend("day_14").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_15").ToString)) & "," & (Trim(dtrowemployeeattend("day_16").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_17").ToString)) & "," & (Trim(dtrowemployeeattend("day_18").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_19").ToString)) & "," & (Trim(dtrowemployeeattend("day_20").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_21").ToString)) & "," & (Trim(dtrowemployeeattend("day_22").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_23").ToString)) & "," & (Trim(dtrowemployeeattend("day_24").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_25").ToString)) & "," & (Trim(dtrowemployeeattend("day_26").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_27").ToString)) & "," & (Trim(dtrowemployeeattend("day_28").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_29").ToString)) & "," & (Trim(dtrowemployeeattend("day_30").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_31").ToString)) & ")"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployeeattend.RowState = DataRowState.Modified Then
                    cmdSave = New sqlCommand
                    strSQL = "UPDATE tbl_emp_attendence SET " & _
                     "employee_code = '" & (Trim(dtrowemployeeattend("employee_code"))) & _
                    "',present_hrs = " & (Trim(dtrowemployeeattend("present_hrs"))) & ",day_1 = " & (Trim(dtrowemployeeattend("day_1"))) & _
                    ",day_2 = " & (Trim(dtrowemployeeattend("day_2"))) & ",day_3 = " & (Trim(dtrowemployeeattend("day_3"))) & _
                    ",day_4 = " & (Trim(dtrowemployeeattend("day_4"))) & ",day_5 = " & (Trim(dtrowemployeeattend("day_5"))) & _
                    ",day_6 = " & (Trim(dtrowemployeeattend("day_6"))) & ",day_7 = " & (Trim(dtrowemployeeattend("day_7"))) & _
                    ",day_8 = " & (Trim(dtrowemployeeattend("day_8"))) & ",day_9 = " & (Trim(dtrowemployeeattend("day_9"))) & _
                    ",day_10 = " & (Trim(dtrowemployeeattend("day_10"))) & ",day_11 = " & (Trim(dtrowemployeeattend("day_11"))) & _
                    ",day_12 = " & (Trim(dtrowemployeeattend("day_12"))) & ",day_13 = " & (Trim(dtrowemployeeattend("day_13"))) & _
                    ",day_14 = " & (Trim(dtrowemployeeattend("day_14"))) & ",day_15 = " & (Trim(dtrowemployeeattend("day_15"))) & _
                    ",day_16 = " & (Trim(dtrowemployeeattend("day_16"))) & ",day_17 = " & (Trim(dtrowemployeeattend("day_17"))) & _
                    ",day_18 = " & (Trim(dtrowemployeeattend("day_18"))) & ",day_19 = " & (Trim(dtrowemployeeattend("day_19"))) & _
                    ",day_20 = " & (Trim(dtrowemployeeattend("day_20"))) & ",day_21 = " & (Trim(dtrowemployeeattend("day_21"))) & _
                    ",day_22 = " & (Trim(dtrowemployeeattend("day_22"))) & ",day_23 = " & (Trim(dtrowemployeeattend("day_23"))) & _
                    ",day_24 = " & (Trim(dtrowemployeeattend("day_24"))) & ",day_25 = " & (Trim(dtrowemployeeattend("day_25"))) & _
                    ",day_26 = " & (Trim(dtrowemployeeattend("day_26"))) & ",day_27 = " & (Trim(dtrowemployeeattend("day_27"))) & _
                    ",day_28 = " & (Trim(dtrowemployeeattend("day_28"))) & ",day_29 = " & (Trim(dtrowemployeeattend("day_29"))) & _
                    ",day_30 = " & (Trim(dtrowemployeeattend("day_30"))) & ",day_31 = " & (Trim(dtrowemployeeattend("day_31"))) & _
                    " where attendence_id=" & (Trim(dtrowemployeeattend("attendence_id").ToString))
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployeeattend.RowState = DataRowState.Deleted Then
                    cmdDelete = New sqlCommand
                    strSQL = "DELETE FROM tbl_emp_attendence where attendence_id = " & dtrowemployeeattend("attendence_id", DataRowVersion.Original)
                    With cmdDelete
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                Else
                    dbReturn = True
                End If
            Next
            trnOledb.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            trnOledb.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function

    Public Function Saveempovertimeattendence(ByVal empcon As sqlConnection, ByVal dtblempdetail As DataTable, ByVal locid As Integer, ByVal deptid As Integer, ByVal processperiod As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowemployeeattend As DataRow
        masterform.con.Close()
        masterform.con.Open()
        trnOledb = empcon.BeginTransaction

        Try
            For Each dtrowemployeeattend In dtblempdetail.Rows
                If dtrowemployeeattend.RowState = DataRowState.Added Then
                    cmdSave = New sqlCommand
                    strSQL = "INSERT INTO tbl_emp_overtime(location_id,department_id,period,employee_code" & _
                    ",overtime_hrs,day_1,day_2,day_3,day_4,day_5,day_6,day_7,day_8,day_9,day_10,day_11,day_12,day_13,day_14,day_15,day_16, " & _
                    "day_17,day_18,day_19,day_20,day_21,day_22,day_23,day_24,day_25,day_26,day_27,day_28,day_29,day_30,day_31)" & _
                    " VALUES( " & locid & "," & deptid & _
                    ",'" & processperiod & "','" & (Trim(dtrowemployeeattend("employee_code").ToString)) & _
                    "'," & Trim(dtrowemployeeattend("overtime_hrs").ToString) & _
                    "," & (Trim(dtrowemployeeattend("day_1").ToString)) & "," & (Trim(dtrowemployeeattend("day_2").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_3").ToString)) & "," & (Trim(dtrowemployeeattend("day_4").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_5").ToString)) & "," & (Trim(dtrowemployeeattend("day_6").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_7").ToString)) & "," & (Trim(dtrowemployeeattend("day_8").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_9").ToString)) & "," & (Trim(dtrowemployeeattend("day_10").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_11").ToString)) & "," & (Trim(dtrowemployeeattend("day_12").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_13").ToString)) & "," & (Trim(dtrowemployeeattend("day_14").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_15").ToString)) & "," & (Trim(dtrowemployeeattend("day_16").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_17").ToString)) & "," & (Trim(dtrowemployeeattend("day_18").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_19").ToString)) & "," & (Trim(dtrowemployeeattend("day_20").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_21").ToString)) & "," & (Trim(dtrowemployeeattend("day_22").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_23").ToString)) & "," & (Trim(dtrowemployeeattend("day_24").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_25").ToString)) & "," & (Trim(dtrowemployeeattend("day_26").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_27").ToString)) & "," & (Trim(dtrowemployeeattend("day_28").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_29").ToString)) & "," & (Trim(dtrowemployeeattend("day_30").ToString)) & _
                    "," & (Trim(dtrowemployeeattend("day_31").ToString)) & ")"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployeeattend.RowState = DataRowState.Modified Then
                    cmdSave = New sqlCommand
                    strSQL = "UPDATE tbl_emp_overtime SET " & _
                    "employee_code = '" & (Trim(dtrowemployeeattend("employee_code"))) & _
                    "',overtime_hrs = " & (Trim(dtrowemployeeattend("overtime_hrs"))) & ",day_1 = " & (Trim(dtrowemployeeattend("day_1"))) & _
                    ",day_2 = " & (Trim(dtrowemployeeattend("day_2"))) & ",day_3 = " & (Trim(dtrowemployeeattend("day_3"))) & _
                    ",day_4 = " & (Trim(dtrowemployeeattend("day_4"))) & ",day_5 = " & (Trim(dtrowemployeeattend("day_5"))) & _
                    ",day_6 = " & (Trim(dtrowemployeeattend("day_6"))) & ",day_7 = " & (Trim(dtrowemployeeattend("day_7"))) & _
                    ",day_8 = " & (Trim(dtrowemployeeattend("day_8"))) & ",day_9 = " & (Trim(dtrowemployeeattend("day_9"))) & _
                    ",day_10 = " & (Trim(dtrowemployeeattend("day_10"))) & ",day_11 = " & (Trim(dtrowemployeeattend("day_11"))) & _
                    ",day_12 = " & (Trim(dtrowemployeeattend("day_12"))) & ",day_13 = " & (Trim(dtrowemployeeattend("day_13"))) & _
                    ",day_14 = " & (Trim(dtrowemployeeattend("day_14"))) & ",day_15 = " & (Trim(dtrowemployeeattend("day_15"))) & _
                    ",day_16 = " & (Trim(dtrowemployeeattend("day_16"))) & ",day_17 = " & (Trim(dtrowemployeeattend("day_17"))) & _
                    ",day_18 = " & (Trim(dtrowemployeeattend("day_18"))) & ",day_19 = " & (Trim(dtrowemployeeattend("day_19"))) & _
                    ",day_20 = " & (Trim(dtrowemployeeattend("day_20"))) & ",day_21 = " & (Trim(dtrowemployeeattend("day_21"))) & _
                    ",day_22 = " & (Trim(dtrowemployeeattend("day_22"))) & ",day_23 = " & (Trim(dtrowemployeeattend("day_23"))) & _
                    ",day_24 = " & (Trim(dtrowemployeeattend("day_24"))) & ",day_25 = " & (Trim(dtrowemployeeattend("day_25"))) & _
                    ",day_26 = " & (Trim(dtrowemployeeattend("day_26"))) & ",day_27 = " & (Trim(dtrowemployeeattend("day_27"))) & _
                    ",day_28 = " & (Trim(dtrowemployeeattend("day_28"))) & ",day_29 = " & (Trim(dtrowemployeeattend("day_29"))) & _
                    ",day_30 = " & (Trim(dtrowemployeeattend("day_30"))) & ",day_31 = " & (Trim(dtrowemployeeattend("day_31"))) & _
                    " where overtime_id=" & (Trim(dtrowemployeeattend("overtime_id").ToString))
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployeeattend.RowState = DataRowState.Deleted Then
                    cmdDelete = New sqlCommand
                    strSQL = "DELETE FROM tbl_emp_overtime where overtime_id = " & dtrowemployeeattend("overtime_id", DataRowVersion.Original)
                    With cmdDelete
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                Else
                    dbReturn = True
                End If
            Next
            trnOledb.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            trnOledb.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function

    Public Function Saveempsalaryprocess(ByVal empcon As sqlConnection, ByVal dtblempdetail As DataTable, ByVal location_id As Integer, ByVal dept_id As Integer, ByVal processperiod As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowemployee As DataRow
        masterform.con.Close()
        masterform.con.Open()
        trnOledb = empcon.BeginTransaction

        Try
            For Each dtrowemployee In dtblempdetail.Rows
                If dtrowemployee.RowState = DataRowState.Deleted Then
                    cmdDelete = New sqlCommand
                    strSQL = "DELETE FROM tbl_emp_salaryprocess where employee_code='" & dtrowemployee("employee_code", DataRowVersion.Original) & " '"
                    With cmdDelete
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = False

                ElseIf dtrowemployee("is_added") = 0 Then
                    cmdSave = New sqlCommand
                    strSQL = "INSERT INTO tbl_emp_salaryprocess (location_id,department_id,period,short_name,employee_code,salary,cheque_salary,present_hrs,payable_salary,overtime_hrs,overtime_salary,total_salary,cash_salary," & _
                    "basic,da,hra,ca,ea,wa,pt,is_added) " & _
                    "VALUES(" & location_id & "," & dept_id & ",'" & processperiod & "','" & (Trim(dtrowemployee("short_name").ToString)) & _
                    "','" & (Trim(dtrowemployee("employee_code").ToString)) & " '," & (Trim(dtrowemployee("salary"))) & _
                    "," & (Trim(dtrowemployee("cheque_salary"))) & "," & (Trim(dtrowemployee("present_hrs"))) & _
                    "," & (Trim(dtrowemployee("payable_salary"))) & "," & (Trim(dtrowemployee("overtime_hrs"))) & _
                    "," & (Trim(dtrowemployee("overtime_salary"))) & "," & (Trim(dtrowemployee("total_salary"))) & _
                    "," & (Trim(dtrowemployee("cash_salary"))) & "," & (Val(dtrowemployee("basic"))) & _
                    "," & (Val(dtrowemployee("da"))) & "," & (Val(dtrowemployee("hra"))) & _
                    "," & (Val(dtrowemployee("ca"))) & "," & (Val(dtrowemployee("ea"))) & _
                    "," & (Val(dtrowemployee("wa"))) & "," & (Val(dtrowemployee("pt"))) & "," & Val(1) & ")"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee("is_added") = 1 Then
                    cmdSave = New sqlCommand
                    strSQL = "UPDATE tbl_emp_salaryprocess SET short_name='" & (Trim(dtrowemployee("short_name").ToString)) & _
                    "',employee_code='" & (Trim(dtrowemployee("employee_code").ToString)) & _
                    "',salary=" & (Trim(dtrowemployee("salary"))) & ",cheque_salary=" & (Trim(dtrowemployee("cheque_salary"))) & _
                    ",present_hrs=" & Trim(dtrowemployee("present_hrs")) & " ,payable_salary=" & (Trim(dtrowemployee("payable_salary"))) & _
                    ",overtime_hrs=" & Trim(dtrowemployee("overtime_hrs")) & " ,overtime_salary=" & (Trim(dtrowemployee("overtime_salary"))) & _
                    ",total_salary=" & (Trim(dtrowemployee("total_salary"))) & ",cash_salary=" & (Trim(dtrowemployee("cash_salary"))) & _
                    ",basic=" & Trim(dtrowemployee("basic")) & " ,da=" & (Trim(dtrowemployee("da"))) & _
                    ",hra=" & Trim(dtrowemployee("hra")) & " ,ca=" & (Trim(dtrowemployee("ca"))) & _
                    ",ea=" & (Trim(dtrowemployee("ea"))) & ",wa=" & (Trim(dtrowemployee("wa"))) & ",pt=" & (Trim(dtrowemployee("pt"))) & _
                    " where employee_code ='" & (Trim(dtrowemployee("employee_code").ToString)) & "'"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                End If
            Next
            trnOledb.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            trnOledb.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function

#End Region
End Class
