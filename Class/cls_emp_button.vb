Imports System.Data.SqlClient
Public Class cls_emp_button

#Region " Functions "

    Public Function Saveempfamilydetail(ByVal empcon As SqlConnection, ByVal dtblempdetail As DataTable, ByVal empcode As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim trnOledb As SqlTransaction
        Dim dtrowemployee As DataRow
        Dim cmdSave As SqlCommand
        Dim cmdDelete As SqlCommand
        Dim strSQL As String

        masterform.con.Close()
        masterform.con.Open()
        trnOledb = empcon.BeginTransaction

        Try
            For Each dtrowemployee In dtblempdetail.Rows
                If dtrowemployee.RowState = DataRowState.Added Then
                    cmdSave = New SqlCommand
                    strSQL = "INSERT INTO tbl_emp_familydetail (serial_no,employee_code, member_name, relation,birth_date,education,occupation) " & _
                    "VALUES( " & (Trim(dtrowemployee("serial_no"))) & ",'" & empcode & "','" & (Trim(dtrowemployee("member_name"))) & _
                    "','" & (Trim(dtrowemployee("relation"))) & "','" & (Trim(dtrowemployee("birth_date"))) & _
                    "','" & (Trim(dtrowemployee("education"))) & "','" & (Trim(dtrowemployee("occupation"))) & "')"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee.RowState = DataRowState.Modified Then
                    cmdSave = New SqlCommand
                    strSQL = "UPDATE tbl_emp_familydetail SET serial_no= " & (Trim(dtrowemployee("serial_no"))) & ", member_name = '" & (Trim(dtrowemployee("member_name"))) & "',relation = '" & (Trim(dtrowemployee("relation"))) & _
                    "',birth_date = '" & (Trim(dtrowemployee("birth_date"))) & "',education = '" & (Trim(dtrowemployee("education"))) & _
                    "',occupation = '" & (Trim(dtrowemployee("occupation"))) & "' where employee_code='" & empcode & "' and serial_no = " & dtrowemployee("serial_no", DataRowVersion.Original)
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee.RowState = DataRowState.Deleted Then
                    cmdDelete = New SqlCommand
                    strSQL = "DELETE FROM tbl_emp_familydetail where serial_no = " & dtrowemployee("serial_no", DataRowVersion.Original) & " and employee_code='" & empcode & "'"
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
            MsgBox(ex.Message)
            trnOledb.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function

    Public Function Saveempqualification(ByVal empcon As SqlConnection, ByVal dtblempdetail As DataTable, ByVal empcode As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim trnOledb As SqlTransaction
        Dim dtrowemployee As DataRow
        Dim cmdSave As SqlCommand
        Dim cmdDelete As SqlCommand
        Dim strSQL As String

        masterform.con.Close()
        masterform.con.Open()
        trnOledb = empcon.BeginTransaction

        Try
            For Each dtrowemployee In dtblempdetail.Rows
                If dtrowemployee.RowState = DataRowState.Added Then
                    cmdSave = New SqlCommand
                    strSQL = "INSERT INTO tbl_emp_qualification (serial_no,employee_code, qualification, university_college_institute,year_of_passing,grade_percent) " & _
                    "VALUES( " & (Trim(dtrowemployee("serial_no"))) & ",'" & empcode & "','" & (Trim(dtrowemployee("qualification"))) & _
                    "','" & (Trim(dtrowemployee("university_college_institute"))) & "','" & (Trim(dtrowemployee("year_of_passing"))) & _
                    "','" & (Trim(dtrowemployee("grade_percent"))) & "')"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee.RowState = DataRowState.Modified Then
                    cmdSave = New SqlCommand
                    strSQL = "UPDATE tbl_emp_qualification SET serial_no= " & (Trim(dtrowemployee("serial_no"))) & _
                    ", qualification = '" & (Trim(dtrowemployee("qualification"))) & "',university_college_institute = '" & (Trim(dtrowemployee("university_college_institute"))) & _
                    "',year_of_passing = '" & (Trim(dtrowemployee("year_of_passing"))) & "',grade_percent = '" & (Trim(dtrowemployee("grade_percent"))) & _
                    "' where employee_code='" & empcode & "' and serial_no = " & dtrowemployee("serial_no", DataRowVersion.Original)
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee.RowState = DataRowState.Deleted Then
                    cmdDelete = New SqlCommand
                    strSQL = "DELETE FROM tbl_emp_qualification where serial_no = " & dtrowemployee("serial_no", DataRowVersion.Original) & " and employee_code='" & empcode & "'"
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
            MsgBox(ex.Message)
            trnOledb.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function

    Public Function Saveemphistory(ByVal empcon As SqlConnection, ByVal dtblempdetail As DataTable, ByVal empcode As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim trnOledb As SqlTransaction
        Dim dtrowemployee As DataRow
        Dim cmdSave As SqlCommand
        Dim cmdDelete As SqlCommand
        Dim strSQL As String
        masterform.con.Close()
        masterform.con.Open()
        trnOledb = empcon.BeginTransaction

        Try
            For Each dtrowemployee In dtblempdetail.Rows
                If dtrowemployee.RowState = DataRowState.Added Then
                    cmdSave = New SqlCommand
                    strSQL = "INSERT INTO tbl_emp_history(serial_no,employee_code, employer, designation,from_date,to_date,salary) " & _
                    "VALUES( " & (Trim(dtrowemployee("serial_no"))) & ",'" & empcode & "','" & (Trim(dtrowemployee("employer"))) & _
                    "','" & (Trim(dtrowemployee("designation"))) & "','" & (Trim(dtrowemployee("from_date"))) & _
                    "','" & (Trim(dtrowemployee("to_date"))) & "'," & (Trim(dtrowemployee("salary"))) & ")"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee.RowState = DataRowState.Modified Then
                    cmdSave = New SqlCommand
                    strSQL = "UPDATE tbl_emp_history SET serial_no= " & (Trim(dtrowemployee("serial_no"))) & ", employer = '" & (Trim(dtrowemployee("employer"))) & _
                    "',designation = '" & (Trim(dtrowemployee("designation"))) & "',from_date = '" & (Trim(dtrowemployee("from_date"))) & _
                    "',to_date = '" & (Trim(dtrowemployee("to_date"))) & "',salary = " & (Trim(dtrowemployee("salary"))) & _
                    " where employee_code='" & empcode & "' and serial_no = " & dtrowemployee("serial_no", DataRowVersion.Original)
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee.RowState = DataRowState.Deleted Then
                    cmdDelete = New SqlCommand
                    strSQL = "DELETE FROM tbl_emp_history where serial_no = " & dtrowemployee("serial_no", DataRowVersion.Original) & " and employee_code='" & empcode & "'"
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
            MsgBox(ex.Message)
            trnOledb.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function

    Public Function Saveempearningdetail(ByVal empcon As SqlConnection, ByVal dtblempdetail As DataTable, ByVal empcode As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim trnOledb As SqlTransaction
        Dim dtrowemployee As DataRow
        Dim cmdSave As SqlCommand
        Dim cmdDelete As SqlCommand
        Dim strSQL As String

        masterform.con.Close()
        masterform.con.Open()
        trnOledb = empcon.BeginTransaction

        Try
            For Each dtrowemployee In dtblempdetail.Rows
                If dtrowemployee.RowState = DataRowState.Added Then
                    cmdSave = New SqlCommand
                    strSQL = "INSERT INTO tbl_emp_earning (employee_code, earning_code,description,cheque_salary) " & _
                    "VALUES( '" & empcode & "','" & (Trim(dtrowemployee("earning_code"))) & _
                    "','" & (Trim(dtrowemployee("description"))) & "'," & (Val(dtrowemployee("cheque_salary"))) & ")"
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee.RowState = DataRowState.Modified Then
                    cmdSave = New SqlCommand
                    strSQL = "UPDATE tbl_emp_earning SET " & _
                    "earning_code = '" & (Trim(dtrowemployee("earning_code"))) & "',description = '" & (Trim(dtrowemployee("description"))) & _
                    "',cheque_salary = " & (Val(dtrowemployee("cheque_salary"))) & " where employee_code='" & empcode & _
                    "' and serial_no = " & dtrowemployee("serial_no", DataRowVersion.Original)
                    With cmdSave
                        .Connection = trnOledb.Connection
                        .Transaction = trnOledb
                        .CommandText = strSQL
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowemployee.RowState = DataRowState.Deleted Then
                    cmdDelete = New SqlCommand
                    strSQL = "DELETE FROM tbl_emp_earning where serial_no = " & dtrowemployee("serial_no", DataRowVersion.Original) & " and employee_code='" & empcode & "'"
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
            MsgBox(ex.Message)
            trnOledb.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function
#End Region
End Class
