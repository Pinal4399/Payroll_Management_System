Imports System.Data.SqlClient
Public Class cls_General

#Region "Variable Declaration"
    Dim cmd As New sqlCommand
    Dim cmd1 As New sqlCommand
    Dim dr As sqlDataReader
    Dim strQry As String
    Dim oledbTran As sqlTransaction
    Dim cmdsave As sqlCommand
    Dim cmddelete As sqlCommand
#End Region

#Region " Functions/Procedures "

    Public Function Getdata(ByRef dbcon As sqlConnection, ByVal strqry As String, ByRef dbtblname As DataTable) As Boolean
        Dim dbReturn As Boolean = False
        dbtblname = New DataTable
        Dim com As New sqlCommand
        dbcon = masterform.con
        Try
            With com
                .Connection = dbcon
                .CommandText = strqry
                .CommandType = CommandType.Text
            End With
            masterform.adp = New sqlDataAdapter(com)
            If masterform.adp.Fill(dbtblname) Then
                dbReturn = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
        End Try
        Return dbReturn
    End Function

    Public Function saveCmpdata(ByVal dbConnection As sqlConnection, ByRef dttblCompany As DataTable) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowCompany As DataRow
        masterform.con.Close()
        masterform.con.Open()
        oledbTran = dbConnection.BeginTransaction
        Try
            For Each dtrowCompany In dttblCompany.Rows
                If dtrowCompany.RowState = DataRowState.Added Then
                    cmdsave = New sqlCommand
                    strQry = "INSERT INTO tbl_company(company_code,company_name,address,city,state,country,zip_code,phone_no,fax_no,email,website) VALUES ('" & Trim(dtrowCompany("company_code").ToString) & "','" & Trim(dtrowCompany("company_name").ToString) & "','" & Trim(dtrowCompany("address").ToString) & "','" & Trim(dtrowCompany("city").ToString) & "','" & Trim(dtrowCompany("state")) & "','" & Trim(dtrowCompany("country").ToString) & "','" & Trim(dtrowCompany("zip_code")) & "','" & Trim(dtrowCompany("phone_no")) & "','" & Trim(dtrowCompany("fax_no")) & "','" & Trim(dtrowCompany("email")) & "','" & Trim(dtrowCompany("website")) & "')"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowCompany.RowState = DataRowState.Modified Then
                    cmdsave = New sqlCommand
                    strQry = "UPDATE tbl_company SET company_code='" & Trim(dtrowCompany("company_code")) & "',company_name='" & Trim(dtrowCompany("company_name")) & "',address='" & Trim(dtrowCompany("address")) & "',city='" & Trim(dtrowCompany("city")) & "',state='" & Trim(dtrowCompany("state")) & "',country='" & Trim(dtrowCompany("country")) & "',zip_code='" & Trim(dtrowCompany("zip_code")) & "',phone_no='" & Trim(dtrowCompany("phone_no")) & "',fax_no='" & Trim(dtrowCompany("fax_no")) & "',email='" & Trim(dtrowCompany("email")) & "',website='" & Trim(dtrowCompany("website")) & "' WHERE company_id=" & Trim(dtrowCompany("company_id"))
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowCompany.RowState = DataRowState.Deleted Then
                    cmddelete = New sqlCommand
                    strQry = "DELETE FROM tbl_company WHERE company_id not in(select company_id from tbl_location )and company_id =" & dtrowCompany("company_id", DataRowVersion.Original)
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                    If Not cmddelete.ExecuteNonQuery Then
                        MsgBox("Child Record exist so you can't delete this record", MsgBoxStyle.Information, "Company")
                    End If
                Else
                    dbReturn = True
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
            oledbTran.Rollback()
        End Try
        Return dbReturn
    End Function

    Public Function saveLocdata(ByVal dbConnection As sqlConnection, ByRef dttblLocation As DataTable, ByVal cmpid As Integer) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowLocation As DataRow
        masterform.con.Close()
        masterform.con.Open()
        oledbTran = dbConnection.BeginTransaction
        Try
            For Each dtrowLocation In dttblLocation.Rows
                If dtrowLocation.RowState = DataRowState.Added Then
                    cmdsave = New sqlCommand
                    strQry = "INSERT INTO tbl_location(location_code,company_id,location_name,address,city,state,country,zip_code,phone_no,fax_no,email,authorized_person,owner,occupier) VALUES ('" & Trim(dtrowLocation("location_code").ToString) & "'," & cmpid & ",'" & Trim(dtrowLocation("location_name")) & "','" & Trim(dtrowLocation("address").ToString) & "','" & Trim(dtrowLocation("city").ToString) & "','" & Trim(dtrowLocation("state")) & "','" & Trim(dtrowLocation("country").ToString) & "','" & Trim(dtrowLocation("zip_code")) & "','" & Trim(dtrowLocation("phone_no")) & "','" & Trim(dtrowLocation("fax_no")) & "','" & Trim(dtrowLocation("email")) & "','" & Trim(dtrowLocation("authorized_person")) & "','" & Trim(dtrowLocation("owner")) & "','" & Trim(dtrowLocation("occupier")) & "')"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowLocation.RowState = DataRowState.Modified Then
                    cmdsave = New sqlCommand
                    strQry = "UPDATE tbl_location SET location_code='" & Trim(dtrowLocation("location_code")) & "',location_name='" & Trim(dtrowLocation("location_name")) & "',address='" & Trim(dtrowLocation("address")) & "',city='" & Trim(dtrowLocation("city")) & "',state='" & Trim(dtrowLocation("state")) & "',country='" & Trim(dtrowLocation("country")) & "',zip_code='" & Trim(dtrowLocation("zip_code")) & "',phone_no='" & Trim(dtrowLocation("phone_no")) & "',fax_no='" & Trim(dtrowLocation("fax_no")) & "',email='" & Trim(dtrowLocation("email")) & "',authorized_person='" & Trim(dtrowLocation("authorized_person")) & "',owner='" & Trim(dtrowLocation("owner")) & "',occupier='" & Trim(dtrowLocation("occupier")) & "' WHERE location_id=" & Trim(dtrowLocation("location_id"))
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowLocation.RowState = DataRowState.Deleted Then
                    cmddelete = New sqlCommand
                    strQry = "DELETE FROM tbl_location WHERE location_id not in(select location_id from tbl_department )and location_id =" & dtrowLocation("location_id", DataRowVersion.Original)
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                    If Not cmddelete.ExecuteNonQuery Then
                        MsgBox("Child Record exist so you can't delete this record", MsgBoxStyle.Information, "Location")
                    End If
                Else
                    dbReturn = True
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
            oledbTran.Rollback()
        End Try
        Return dbReturn
    End Function

    Public Function saveDeptdata(ByVal dbConnection As sqlConnection, ByRef dttblDepartment As DataTable, ByVal loc_id As Integer) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowDepartment As DataRow
        masterform.con.Close()
        masterform.con.Open()
        oledbTran = dbConnection.BeginTransaction
        Try
            For Each dtrowDepartment In dttblDepartment.Rows
                If dtrowDepartment.RowState = DataRowState.Added Then
                    cmdsave = New sqlCommand
                    strQry = "INSERT INTO tbl_department(location_id,department_code,department_name,dept_isactive,hod_empid,hod_empname,dept_description) VALUES (" & loc_id & ",'" & Trim(dtrowDepartment("department_code").ToString) & "','" & Trim(dtrowDepartment("department_name").ToString) & "'," & Val(dtrowDepartment("dept_isactive").ToString) & " ,'" & Trim(dtrowDepartment("hod_empid").ToString) & "','" & Trim(dtrowDepartment("hod_empname").ToString) & "','" & Trim(dtrowDepartment("dept_description").ToString) & "')"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowDepartment.RowState = DataRowState.Modified Then
                    cmdsave = New sqlCommand
                    strQry = "UPDATE tbl_department SET department_code='" & Trim(dtrowDepartment("department_code")) & "',department_name='" & Trim(dtrowDepartment("department_name")) & "',dept_isactive=" & dtrowDepartment("dept_isactive") & ",hod_empid='" & Trim(dtrowDepartment("hod_empid")) & "',hod_empname='" & Trim(dtrowDepartment("hod_empname")) & "',dept_description='" & Trim(dtrowDepartment("dept_description")) & "' where department_id =" & Trim(dtrowDepartment("department_id"))
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowDepartment.RowState = DataRowState.Deleted Then
                    cmddelete = New sqlCommand
                    strQry = "DELETE FROM tbl_department WHERE department_id not in(select department_id from tbl_employee )and department_id =" & dtrowDepartment("department_id", DataRowVersion.Original)
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                    If Not cmddelete.ExecuteNonQuery Then
                        MsgBox("Child Record exist so you can't delete this record", MsgBoxStyle.Information, "Department")
                    End If
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
            oledbTran.Rollback()
        End Try
        Return dbReturn
    End Function

    Public Function saveEmployeedata(ByVal dbConnection As sqlConnection, ByRef dttblEmployee As DataTable, ByVal empcode As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowEmployee As DataRow
        masterform.con.Close()
        masterform.con.Open()
        oledbTran = dbConnection.BeginTransaction
        Try
            For Each dtrowEmployee In dttblEmployee.Rows
                If dtrowEmployee.RowState = DataRowState.Added Then
                    cmdsave = New sqlCommand
                    strQry = "INSERT INTO tbl_employee (employee_code, location_id, first_name, " & _
                         "middle_name, last_name, short_name, department_id, gender, marital_status,joining_date, " & _
                         "salary, emp_permanent,emp_inactive,emp_photo, current_address, current_city, current_state, current_phoneno, current_pinno, " & _
                         "permanent_address, permanent_city, permanent_state, permanent_phoneno, permanent_pinno, " & _
                         "mobile_no, birth_date, age, birth_place, nationality, email_address,payroll_type, blood_group," & _
                         "job_profile, criminal_litigation, emp_position, litigation_detail, relieved_date,leave_reason, " & _
                         "pancard_no, no_of_children, disabled, percent_of_disability, disability_note, bank_name, bank_ac_no, " & _
                         "reference1, reference2, passport_no, issue_date, issue_place, valid_till, " & _
                         "drv_license_no, vehicle_type, vehicle_no, rationcard_no, hobbies,confirmation_date) VALUES " & _
                         "( '" & empcode & _
                         "', " & Trim(dtrowEmployee("location_id")) & ", '" & Trim(dtrowEmployee("first_name").ToString) & _
                         "', '" & Trim(dtrowEmployee("middle_name").ToString) & "', '" & Trim(dtrowEmployee("last_name").ToString) & _
                         "', '" & Trim(dtrowEmployee("short_name").ToString) & "', " & Trim(dtrowEmployee("department_id")) & _
                         ",  '" & Trim(dtrowEmployee("gender").ToString) & " ','" & Trim(dtrowEmployee("marital_status").ToString) & _
                         "', '" & Trim(dtrowEmployee("joining_date").ToString) & "', " & Trim(dtrowEmployee("salary").ToString) & _
                         ", " & Val(dtrowEmployee("emp_permanent").ToString) & ", " & Val(dtrowEmployee("emp_inactive").ToString) & _
                         ",'" & dtrowEmployee("emp_photo").ToString & _
                         "', '" & Trim(dtrowEmployee("current_address").ToString) & "', '" & Trim(dtrowEmployee("current_city").ToString) & _
                         "', '" & Trim(dtrowEmployee("current_state").ToString) & "', '" & Trim(dtrowEmployee("current_phoneno").ToString) & _
                         "', '" & Trim(dtrowEmployee("current_pinno").ToString) & "', '" & Trim(dtrowEmployee("permanent_address").ToString) & _
                         "', '" & Trim(dtrowEmployee("permanent_city").ToString) & "', '" & Trim(dtrowEmployee("permanent_state").ToString) & _
                         "', '" & Trim(dtrowEmployee("permanent_phoneno").ToString) & "', '" & Trim(dtrowEmployee("permanent_pinno").ToString) & _
                         "', '" & Trim(dtrowEmployee("mobile_no").ToString) & "', '" & Trim(dtrowEmployee("birth_date").ToString) & _
                         "', '" & Trim(dtrowEmployee("age").ToString) & "', '" & Trim(dtrowEmployee("birth_place").ToString) & _
                         "', '" & Trim(dtrowEmployee("nationality").ToString) & "', '" & Trim(dtrowEmployee("email_address").ToString) & _
                         "', '" & Trim(dtrowEmployee("payroll_type").ToString) & "','" & Trim(dtrowEmployee("blood_group").ToString) & _
                         "', '" & Trim(dtrowEmployee("job_profile").ToString) & "', " & Val(dtrowEmployee("criminal_litigation").ToString) & _
                         ",'" & Trim(dtrowEmployee("emp_position").ToString) & "','" & Trim(dtrowEmployee("litigation_detail").ToString) & _
                         "', '" & Trim(dtrowEmployee("relieved_date").ToString) & "','" & Trim(dtrowEmployee("leave_reason").ToString) & _
                         "','" & Trim(dtrowEmployee("pancard_no").ToString) & "', '" & Trim(dtrowEmployee("no_of_children").ToString) & _
                         "', " & Val(dtrowEmployee("disabled").ToString) & ",'" & Trim(dtrowEmployee("percent_of_disability").ToString) & _
                         "', '" & Trim(dtrowEmployee("disability_note").ToString) & "','" & Trim(dtrowEmployee("bank_name").ToString) & _
                         "', '" & Trim(dtrowEmployee("bank_ac_no").ToString) & "', '" & Trim(dtrowEmployee("reference1").ToString) & _
                         "', '" & Trim(dtrowEmployee("reference2").ToString) & _
                         "', '" & Trim(dtrowEmployee("passport_no").ToString) & "', '" & Trim(dtrowEmployee("issue_date").ToString) & _
                         "', '" & Trim(dtrowEmployee("issue_place").ToString) & "', '" & Trim(dtrowEmployee("valid_till").ToString) & _
                         "', '" & Trim(dtrowEmployee("drv_license_no").ToString) & "', '" & Trim(dtrowEmployee("vehicle_type").ToString) & _
                         "', '" & Trim(dtrowEmployee("vehicle_no").ToString) & "', '" & Trim(dtrowEmployee("rationcard_no").ToString) & _
                         "', '" & Trim(dtrowEmployee("hobbies").ToString) & "', '" & Trim(dtrowEmployee("confirmation_date").ToString) & "')"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowEmployee.RowState = DataRowState.Modified Then
                    cmdsave = New sqlCommand
                    strQry = "UPDATE tbl_employee SET " & _
                        "location_id=" & Trim(dtrowEmployee("location_id").ToString) & ",first_name='" & Trim(dtrowEmployee("first_name").ToString) & "', " & _
                        "middle_name='" & Trim(dtrowEmployee("middle_name").ToString) & "',last_name='" & Trim(dtrowEmployee("last_name").ToString) & "', " & _
                        "short_name='" & Trim(dtrowEmployee("short_name").ToString) & "',department_id=" & Trim(dtrowEmployee("department_id").ToString) & ", " & _
                        "gender='" & Trim(dtrowEmployee("gender").ToString) & "',marital_status='" & Trim(dtrowEmployee("marital_status").ToString) & "', " & _
                        "joining_date='" & Trim(dtrowEmployee("joining_date").ToString) & "',salary=" & Trim(dtrowEmployee("salary").ToString) & ", " & _
                        "emp_permanent= " & Val(dtrowEmployee("emp_permanent").ToString) & ", emp_inactive=" & Val(dtrowEmployee("emp_inactive").ToString) & "," & _
                        "emp_photo='" & dtrowEmployee("emp_photo").ToString & "'," & _
                        "current_address='" & Trim(dtrowEmployee("current_address").ToString) & "',current_city='" & Trim(dtrowEmployee("current_city").ToString) & "', " & _
                        "current_state='" & Trim(dtrowEmployee("current_state").ToString) & "',current_phoneno='" & Trim(dtrowEmployee("current_phoneno").ToString) & "', " & _
                        "current_pinno='" & Trim(dtrowEmployee("current_pinno").ToString) & "',permanent_address='" & Trim(dtrowEmployee("permanent_address").ToString) & "', " & _
                        "permanent_city='" & Trim(dtrowEmployee("permanent_city").ToString) & "',permanent_state='" & Trim(dtrowEmployee("permanent_state").ToString) & "', " & _
                        "permanent_phoneno='" & Trim(dtrowEmployee("permanent_phoneno").ToString) & "',permanent_pinno='" & Trim(dtrowEmployee("permanent_pinno").ToString) & "', " & _
                        "mobile_no='" & Trim(dtrowEmployee("mobile_no").ToString) & "',birth_date='" & Trim(dtrowEmployee("birth_date").ToString) & "', " & _
                        "age='" & Trim(dtrowEmployee("age").ToString) & "',birth_place='" & Trim(dtrowEmployee("birth_place").ToString) & "', " & _
                        "nationality='" & Trim(dtrowEmployee("nationality").ToString) & "',email_address='" & Trim(dtrowEmployee("email_address").ToString) & "', " & _
                        "payroll_type='" & Trim(dtrowEmployee("payroll_type").ToString) & "',blood_group='" & Trim(dtrowEmployee("blood_group").ToString) & "', " & _
                        "job_profile='" & Trim(dtrowEmployee("job_profile").ToString) & "',criminal_litigation=" & Val(dtrowEmployee("criminal_litigation").ToString) & ",emp_position='" & Trim(dtrowEmployee("emp_position").ToString) & "', " & _
                        "litigation_detail='" & Trim(dtrowEmployee("litigation_detail").ToString) & "',relieved_date='" & Trim(dtrowEmployee("relieved_date").ToString) & "', " & _
                        "leave_reason='" & Trim(dtrowEmployee("leave_reason").ToString) & "',pancard_no='" & Trim(dtrowEmployee("pancard_no").ToString) & "', " & _
                        "no_of_children='" & Trim(dtrowEmployee("no_of_children").ToString) & "',disabled=" & Val(dtrowEmployee("disabled").ToString) & ",percent_of_disability='" & Trim(dtrowEmployee("percent_of_disability").ToString) & "', " & _
                        "disability_note='" & Trim(dtrowEmployee("disability_note").ToString) & "',bank_name='" & Trim(dtrowEmployee("bank_name").ToString) & "', " & _
                        "bank_ac_no='" & Trim(dtrowEmployee("bank_ac_no").ToString) & " ', " & _
                        "reference1= '" & Trim(dtrowEmployee("reference1").ToString) & "',reference2='" & Trim(dtrowEmployee("reference2").ToString) & "', " & _
                        "passport_no='" & Trim(dtrowEmployee("passport_no").ToString) & "',issue_date='" & Trim(dtrowEmployee("issue_date").ToString) & "', " & _
                        "issue_place='" & Trim(dtrowEmployee("issue_place").ToString) & "',valid_till='" & Trim(dtrowEmployee("valid_till").ToString) & "', " & _
                        "drv_license_no='" & Trim(dtrowEmployee("drv_license_no").ToString) & "',vehicle_type='" & Trim(dtrowEmployee("vehicle_type").ToString) & "', " & _
                        "vehicle_no='" & Trim(dtrowEmployee("vehicle_no").ToString) & "',rationcard_no='" & Trim(dtrowEmployee("rationcard_no").ToString) & "', " & _
                        "hobbies='" & Trim(dtrowEmployee("hobbies").ToString) & "',confirmation_date='" & Trim(dtrowEmployee("confirmation_date").ToString) & "'" & _
                        " WHERE employee_id=" & Trim(dtrowEmployee("employee_id").ToString)
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowEmployee.RowState = DataRowState.Deleted Then
                    cmddelete = New sqlCommand
                    strQry = "DELETE FROM tbl_employee WHERE employee_id=" & dtrowEmployee("employee_id", DataRowVersion.Original)
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
            oledbTran.Rollback()
        End Try
        Return dbReturn
    End Function

    Public Function saveProcessPeriodData(ByVal dbConnection As sqlConnection, ByRef dttblprocessperiod As DataTable) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowprocess As DataRow
        masterform.con.Close()
        masterform.con.Open()

        oledbTran = dbConnection.BeginTransaction
        Try
            For Each dtrowprocess In dttblprocessperiod.Rows
                If dtrowprocess.RowState = DataRowState.Added Then
                    cmdsave = New sqlCommand
                    strQry = "INSERT INTO tbl_process_period(period,start_date,end_date,month_days,no_of_weekly_offs,non_working_days,finalized)" & _
                    "VALUES ('" & Trim(dtrowprocess("period").ToString) & "','" & Trim(dtrowprocess("start_date").ToString) & _
                    "','" & Trim(dtrowprocess("end_date").ToString) & "','" & Trim(dtrowprocess("month_days").ToString) & _
                    "','" & Trim(dtrowprocess("no_of_weekly_offs")) & "','" & Trim(dtrowprocess("non_working_days").ToString) & _
                    "'," & Val(dtrowprocess("finalized")) & ")"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowprocess.RowState = DataRowState.Modified Then
                    cmdsave = New sqlCommand
                    strQry = "UPDATE tbl_process_period SET period='" & Trim(dtrowprocess("period")) & _
                    "',start_date='" & Trim(dtrowprocess("start_date")) & "',end_date='" & Trim(dtrowprocess("end_date")) & _
                    "',month_days='" & Trim(dtrowprocess("month_days")) & "',no_of_weekly_offs='" & Trim(dtrowprocess("no_of_weekly_offs")) & _
                    "',non_working_days='" & Trim(dtrowprocess("non_working_days")) & "',finalized=" & Val(dtrowprocess("finalized")) & _
                    " WHERE period_id=" & Trim(dtrowprocess("period_id", DataRowVersion.Original))
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowprocess.RowState = DataRowState.Deleted Then
                    cmddelete = New sqlCommand
                    strQry = "DELETE FROM tbl_process_period WHERE period_id=" & Trim(dtrowprocess("period_id", DataRowVersion.Original))
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                Else
                    dbReturn = True
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
            oledbTran.Rollback()
        End Try
        Return dbReturn
    End Function

    Public Function saveleavetype(ByVal dbConnection As sqlConnection, ByRef dttblleavetype As DataTable) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrow As DataRow
        masterform.con.Close()
        masterform.con.Open()
        oledbTran = dbConnection.BeginTransaction
        Try
            For Each dtrow In dttblleavetype.Rows
                If dtrow.RowState = DataRowState.Added Then
                    cmdsave = New sqlCommand
                    strQry = "INSERT INTO tbl_leave_type(leave_type,accrual_period,max_leave,max_accrual)" & _
                    "VALUES ('" & Trim(dtrow("leave_type").ToString) & "','" & Trim(dtrow("accrual_period").ToString) & _
                    "'," & Trim(dtrow("max_leave").ToString) & "," & Trim(dtrow("max_accrual").ToString) & ")"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrow.RowState = DataRowState.Modified Then
                    cmdsave = New sqlCommand
                    strQry = "UPDATE tbl_leave_type SET leave_type='" & Trim(dtrow("leave_type")) & _
                    "',accrual_period='" & Trim(dtrow("accrual_period")) & "',max_leave=" & Trim(dtrow("max_leave")) & _
                    ",max_accrual=" & Trim(dtrow("max_accrual")) & _
                    " WHERE leave_id=" & Trim(dtrow("leave_id", DataRowVersion.Original))
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrow.RowState = DataRowState.Deleted Then
                    cmddelete = New sqlCommand
                    strQry = "DELETE FROM tbl_leave_type WHERE leave_id=" & Trim(dtrow("leave_id", DataRowVersion.Original))
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                Else
                    dbReturn = True
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
            oledbTran.Rollback()
        End Try
        Return dbReturn
    End Function

    Public Function saveBankData(ByVal dbConnection As sqlConnection, ByRef dttblbank As DataTable) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowbank As DataRow

        masterform.con.Close()
        masterform.con.Open()
        oledbTran = dbConnection.BeginTransaction
        Try
            For Each dtrowbank In dttblbank.Rows
                If dtrowbank.RowState = DataRowState.Added Then
                    cmdsave = New sqlCommand
                    strQry = "INSERT INTO tbl_bank(code,bank_name,address,city,pincode,contact_person,designation,phone_no,fax_no)" & _
                    "VALUES ('" & Trim(dtrowbank("code").ToString) & "','" & Trim(dtrowbank("bank_name").ToString) & _
                    "','" & Trim(dtrowbank("address").ToString) & "','" & Trim(dtrowbank("city").ToString) & _
                    "','" & Trim(dtrowbank("pincode")) & "','" & Trim(dtrowbank("contact_person").ToString) & _
                    "','" & Trim(dtrowbank("designation")) & "','" & Trim(dtrowbank("phone_no").ToString) & _
                    "','" & Trim(dtrowbank("fax_no")) & "')"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowbank.RowState = DataRowState.Modified Then
                    cmdsave = New sqlCommand
                    strQry = "UPDATE tbl_bank SET code='" & Trim(dtrowbank("code")) & _
                    "',bank_name='" & Trim(dtrowbank("bank_name")) & "',address='" & Trim(dtrowbank("address")) & _
                    "',city='" & Trim(dtrowbank("city")) & "',pincode='" & Trim(dtrowbank("pincode")) & _
                    "',contact_person='" & Trim(dtrowbank("contact_person")) & "',designation='" & Trim(dtrowbank("designation")) & _
                     "',phone_no='" & Trim(dtrowbank("phone_no")) & "',fax_no='" & Trim(dtrowbank("fax_no")) & _
                    "' WHERE bank_id=" & Trim(dtrowbank("bank_id", DataRowVersion.Original))
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowbank.RowState = DataRowState.Deleted Then
                    cmddelete = New sqlCommand
                    strQry = "DELETE FROM tbl_bank WHERE bank_id=" & Trim(dtrowbank("bank_id", DataRowVersion.Original))
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                Else
                    dbReturn = True
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
            oledbTran.Rollback()
        End Try
        Return dbReturn
    End Function

    Public Function SavePTdetail(ByVal empcon As sqlConnection, ByVal dtblpt As DataTable) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowpt As DataRow

        masterform.con.Close()
        masterform.con.Open()
        oledbTran = empcon.BeginTransaction

        Try
            For Each dtrowpt In dtblpt.Rows
                If dtrowpt.RowState = DataRowState.Added Then
                    cmdsave = New sqlCommand
                    strQry = "INSERT INTO tbl_professiontax(pt_amt,description,lower_rng,Ucase_rng,from_month,to_month,fin_year) " & _
                    "VALUES( " & (Trim(dtrowpt("pt_amt"))) & ",'" & (Trim(dtrowpt("description"))) & _
                    "'," & (Trim(dtrowpt("lower_rng"))) & "," & (Trim(dtrowpt("Ucase_rng"))) & _
                    "," & (Trim(dtrowpt("from_month"))) & "," & (Trim(dtrowpt("to_month"))) & _
                    ",'" & (Trim(dtrowpt("fin_year"))) & "')"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowpt.RowState = DataRowState.Modified Then
                    cmdsave = New SqlCommand
                    strQry = "UPDATE tbl_professiontax SET pt_amt= " & (Trim(dtrowpt("pt_amt"))) & _
                    ", description = '" & (Trim(dtrowpt("description"))) & "',lower_rng =" & (Trim(dtrowpt("lower_rng"))) & _
                    ",Ucase_rng =" & (Trim(dtrowpt("Ucase_rng"))) & ",from_month =" & (Trim(dtrowpt("from_month"))) & _
                    ",to_month =" & (Trim(dtrowpt("to_month"))) & ",fin_year = '" & (Trim(dtrowpt("fin_year"))) & _
                    "' WHERE pt_id = " & dtrowpt("pt_id", DataRowVersion.Original)
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowpt.RowState = DataRowState.Deleted Then
                    cmddelete = New SqlCommand
                    strQry = "DELETE FROM tbl_professiontax where pt_id = " & dtrowpt("pt_id", DataRowVersion.Original)
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                Else
                    dbReturn = True
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message)
            oledbTran.Rollback()
            dbReturn = False
        End Try
        Return dbReturn
    End Function

    Public Function saveWorktimeData(ByVal dbConnection As SqlConnection, ByRef dttblworktime As DataTable, ByVal locid As Integer, ByVal period As String) As Boolean
        Dim dbReturn As Boolean = False
        Dim dtrowworktime As DataRow
        '" & Format(Date.Today, "dd/MM/yyyy") & "'
        '" & Format(CDate(billsdate), "dd/MMM/yyyy") & "'
        masterform.con.Close()
        masterform.con.Open()
        oledbTran = dbConnection.BeginTransaction
        Try
            For Each dtrowworktime In dttblworktime.Rows
                If dtrowworktime.RowState = DataRowState.Added Then
                    cmdsave = New SqlCommand
                    strQry = "INSERT INTO tbl_worktimings(location_id,period,work_date,start_time,end_time,work_hrs,is_holiday,is_weekoff,notes)" & _
                    "VALUES (" & locid & ",'" & period & _
                    "','" & Trim(dtrowworktime("work_date").ToString) & "','" & FormatDateTime(dtrowworktime("start_time"), DateFormat.GeneralDate) & _
                    "','" & FormatDateTime(dtrowworktime("end_time"), DateFormat.GeneralDate) & "','" & Trim(dtrowworktime("work_hrs").ToString) & _
                    "'," & Val(dtrowworktime("is_holiday")) & "," & Val(dtrowworktime("is_weekoff").ToString) & _
                    ",'" & Trim(dtrowworktime("notes")) & "')"
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowworktime.RowState = DataRowState.Modified Then
                    cmdsave = New SqlCommand
                    strQry = "UPDATE tbl_worktimings SET work_date='" & Trim(dtrowworktime("work_date")) & _
                    "',start_time='" & FormatDateTime(dtrowworktime("start_time"), DateFormat.GeneralDate) & "',end_time='" & FormatDateTime(dtrowworktime("end_time"), DateFormat.GeneralDate) & _
                    "',work_hrs='" & Trim(dtrowworktime("work_hrs")) & "',is_holiday=" & Val(dtrowworktime("is_holiday")) & _
                    ",is_weekoff=" & Val(dtrowworktime("is_weekoff")) & ",notes='" & Trim(dtrowworktime("notes")) & _
                    "' WHERE worktimings_id=" & Trim(dtrowworktime("worktimings_id", DataRowVersion.Original))
                    With cmdsave
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True

                ElseIf dtrowworktime.RowState = DataRowState.Deleted Then
                    cmddelete = New SqlCommand
                    strQry = "DELETE FROM tbl_worktimings WHERE worktimings_id=" & Trim(dtrowworktime("worktimings_id", DataRowVersion.Original))
                    With cmddelete
                        .Connection = oledbTran.Connection
                        .Transaction = oledbTran
                        .CommandText = strQry
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                    End With
                    dbReturn = True
                Else
                    dbReturn = True
                End If
            Next
            oledbTran.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbReturn = False
            oledbTran.Rollback()
        End Try
        Return dbReturn
    End Function

    Public Shared Function SaveMsg(ByVal str As String, ByVal strMenu As String) As Windows.Forms.DialogResult
        Return MessageBox.Show(str, strMenu, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
    End Function

    Public Function ShowForm(ByVal frmName As String, ByVal MDIfrm As Form) As Boolean    'call in form
        Dim blnreturn As Boolean = True
        Dim obj As New Form
        For Each obj In MDIfrm.MdiChildren
            If obj.Name.ToUpper = frmName.ToUpper Then
                blnreturn = False
            End If
        Next
    End Function

    Public Sub cmblocationname(ByRef dtbloc As DataTable, ByRef cmblocnm As ComboBox)
        Try
            Dim strQrylocname As String
            dtbloc = New DataTable
            strQrylocname = "SELECT location_id,location_name FROM tbl_location WHERE company_id IN(SELECT company_id " & _
                      "FROM tbl_company WHERE Upper(company_name) LIKE 'Laxmi Diamond Pvt. Ltd.')"
            If Getdata(masterform.con, strQrylocname, dtbloc) Then
                With cmblocnm
                    .DataSource = dtbloc
                    .DisplayMember = "location_name"
                    .ValueMember = "location_id"
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub cmbdeptname(ByRef dtbdept As DataTable, ByRef cmbdeptnm As ComboBox, ByRef locnm As String)
        Try
            Dim strQrydeptname As String
            dtbdept = New DataTable
            strQrydeptname = "SELECT department_id,department_name FROM tbl_department WHERE location_id in(SELECT location_id FROM tbl_location WHERE location_name='" & locnm & "')"
            Getdata(masterform.con, strQrydeptname, dtbdept)
            With cmbdeptnm
                .DataSource = dtbdept
                .DisplayMember = "department_name"
                .ValueMember = "department_id"
            End With
            cmbdeptnm.Text = ""
            cmbdeptnm.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub cmbprocessname(ByRef dtbprocess As DataTable, ByRef cmbprocess As ComboBox)
        Dim strQry As String
        Try
            strQry = "SELECT period FROM tbl_process_period WHERE finalized=0"
            Getdata(masterform.con, strQry, dtbprocess)
            With cmbprocess
                .DataSource = dtbprocess
                .DisplayMember = "period"
                .ValueMember = "period"
            End With
            cmbprocess.Text = ""
            cmbprocess.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub getempcode(ByVal locnm As String, ByVal deptnm As String, ByRef dtbemployeecode As DataTable, ByRef grid_emp As DataGridView)
        Try
            Dim strempcode As String
            strempcode = "select * from tbl_Employee WHERE location_id IN(SELECT location_id FROM tbl_location WHERE location_name='" & locnm & "') AND " & _
                         "department_id IN(SELECT department_id FROM tbl_department WHERE department_name='" & deptnm & "') AND emp_inactive=0"

            Getdata(masterform.con, strempcode, dtbemployeecode)
            With grid_emp
                CType(.Columns("empcode"), DataGridViewComboBoxColumn).DataSource = Nothing
                CType(.Columns("empcode"), DataGridViewComboBoxColumn).DataSource = dtbemployeecode
                CType(.Columns("empcode"), DataGridViewComboBoxColumn).ValueMember = "employee_code"
                CType(.Columns("empcode"), DataGridViewComboBoxColumn).DisplayMember = "employee_code"
            End With
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub AddnewRow(ByRef dttbl As DataTable)
        Try
            Dim rw As DataRow = dttbl.NewRow
            dttbl.Rows.Add(rw)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function vallocdept(ByVal cmbloc As ComboBox, ByVal cmbdept As ComboBox) As Boolean
        Dim bln As Boolean = True
        If cmbloc.SelectedIndex < 0 Then
            MsgBox("Must select Location name", MsgBoxStyle.Information, "Invalid")
            bln = False
            cmbloc.Focus()
        End If
        If cmbdept.SelectedIndex < 0 Then
            MsgBox("Must select Department name", MsgBoxStyle.Information, "Invalid")
            bln = False
            cmbdept.Focus()
        End If
        Return bln
    End Function

    Public Sub showMdi(ByVal objfrm As Form)
        Try
            Dim clrBackGround As Color = Color.Honeydew
            Dim clrButtonBack As Color = Color.FromArgb(100, 171, 204, 168)
            Dim clrGridColumnHeaderColor As Color = Color.DarkSeaGreen
            Dim clrGridRowHeaderColor As Color = Color.DarkSeaGreen
            Dim clrGridColor As Color = Color.PaleGreen
            Dim clrGridCellColor As Color = Color.MintCream
            Dim clrGridCellSelectionColor As Color = Color.DarkGreen
            Dim clrTabBackColor As Color = Color.FromArgb(100, 171, 204, 168)
            Dim clrSelectedTabBackColor As Color = Color.MediumSeaGreen
            Dim clrTabPageBackColor As Color = clrBackGround
            Dim clrGroupBoxBackColor As Color = Color.FromArgb(100, 171, 204, 168)
            Dim ctrl As Control
            For Each ctrl In objfrm.Controls
                If TypeOf ctrl Is Button Then
                    CType(ctrl, Button).BackColor = clrBackGround
                    CType(ctrl, Button).ForeColor = Color.Black
                ElseIf TypeOf ctrl Is Panel Then
                    CType(ctrl, Panel).BackColor = clrBackGround
                    Dim pctrl As Control
                    For Each pctrl In ctrl.Controls
                        If TypeOf pctrl Is Button Then
                            CType(pctrl, Button).BackColor = clrBackGround
                        ElseIf TypeOf pctrl Is Label Then
                            CType(pctrl, Label).ForeColor = Color.Black
                        ElseIf TypeOf pctrl Is DataGridView Then
                            CType(pctrl, DataGridView).BackgroundColor = clrBackGround
                            CType(pctrl, DataGridView).ColumnHeadersDefaultCellStyle.BackColor = clrGridColumnHeaderColor
                            CType(pctrl, DataGridView).RowHeadersDefaultCellStyle.BackColor = clrGridRowHeaderColor
                            CType(pctrl, DataGridView).DefaultCellStyle.BackColor = clrGridCellColor
                            CType(pctrl, DataGridView).DefaultCellStyle.SelectionBackColor = clrGridCellSelectionColor
                        ElseIf TypeOf pctrl Is Panel Then
                            CType(pctrl, Panel).BackColor = clrBackGround
                            Dim ppctrl As Control
                            For Each ppctrl In ctrl.Controls
                                If TypeOf ppctrl Is Button Then
                                    CType(ppctrl, Button).BackColor = clrBackGround
                                ElseIf TypeOf ppctrl Is Label Then
                                    CType(ppctrl, Label).ForeColor = Color.Black
                                ElseIf TypeOf ppctrl Is DataGridView Then
                                    CType(ppctrl, DataGridView).BackgroundColor = clrBackGround
                                    CType(ppctrl, DataGridView).ColumnHeadersDefaultCellStyle.BackColor = clrGridColumnHeaderColor
                                    CType(ppctrl, DataGridView).RowHeadersDefaultCellStyle.BackColor = clrGridRowHeaderColor
                                    CType(ppctrl, DataGridView).DefaultCellStyle.BackColor = clrGridCellColor
                                    CType(ppctrl, DataGridView).DefaultCellStyle.SelectionBackColor = clrGridCellSelectionColor
                                End If
                            Next
                        End If
                    Next
                ElseIf TypeOf ctrl Is TabControl Then
                    CType(ctrl, TabControl).TabPages(0).BackColor = clrBackGround
                    CType(ctrl, TabControl).TabPages(1).BackColor = clrBackGround
                    Dim pctrl As Control
                    For Each pctrl In ctrl.Controls
                        If TypeOf pctrl Is Button Then
                            CType(pctrl, Button).BackColor = clrBackGround
                        ElseIf TypeOf pctrl Is Label Then
                            CType(pctrl, Label).ForeColor = Color.Black
                        ElseIf TypeOf pctrl Is DataGridView Then
                            CType(pctrl, DataGridView).BackgroundColor = clrBackGround
                            CType(pctrl, DataGridView).ColumnHeadersDefaultCellStyle.BackColor = clrGridColumnHeaderColor
                            CType(pctrl, DataGridView).RowHeadersDefaultCellStyle.BackColor = clrGridRowHeaderColor
                            CType(pctrl, DataGridView).DefaultCellStyle.BackColor = clrGridCellColor
                            CType(pctrl, DataGridView).DefaultCellStyle.SelectionBackColor = clrGridCellSelectionColor
                        ElseIf TypeOf pctrl Is GroupBox Then
                            CType(pctrl, GroupBox).BackColor = clrGroupBoxBackColor
                        End If
                    Next
                End If
            Next
            objfrm.BackColor = clrBackGround
        Catch ex As Exception
        End Try
    End Sub

#End Region
End Class
