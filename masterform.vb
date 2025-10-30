'Imports System.Data.SqlClient
Imports System.Data.SqlClient
Public Class masterform

#Region " Variable Declaration "
    Public Shared con As New sqlConnection
    Public cmd As New sqlCommand
    Public dr As sqlDataReader
    Public adp As sqlDataAdapter
    Public ObjclsGen As New cls_General             'to call showform method from cls_General class
#End Region

#Region " Events "

    Private Sub masterform_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub masterform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\database\db_hrms.mdb"
            con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\HRS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        If frm_login.txtusername.Text <> "admin" Then
            CreateUserToolStripMenuItem.Visible = False
        End If
        StatusBar1.Panels(0).Text = "   Laxmi Diamond Pvt. Ltd."
        StatusBar1.Panels(1).Text = Today
    End Sub

    Private Sub CompanyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyToolStripMenuItem1.Click
        If ObjclsGen.ShowForm("frm_company", Me) = False Then
            Dim obj As New frm_company
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub LocationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationToolStripMenuItem1.Click
        If ObjclsGen.ShowForm("frm_location", Me) = False Then
            Dim obj As New frm_location
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_department", Me) = False Then
            Dim obj As New frm_department
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_employee", Me) = False Then
            Dim obj As New frm_employee
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub ProcessPeriodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessPeriodToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_process_period", Me) = False Then
            Dim obj As New frm_Process_Period
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub EmployeeSalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeSalaryToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_employee_salary", Me) = False Then
            Dim obj As New frm_Employee_Salary
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub EmployeeAttendenceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeAttendenceToolStripMenuItem1.Click
        If ObjclsGen.ShowForm("frm_Emp_Attendence", Me) = False Then
            Dim obj As New frm_Emp_Attendence
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub EmployeeOvertimeAttendenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeOvertimeAttendenceToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_Emp_Overtime", Me) = False Then
            Dim obj As New frm_Emp_Overtime
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub EmployeeSalaryProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeSalaryProcessToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_Emp_SalaryProcesss", Me) = False Then
            Dim obj As New frm_Emp_SalaryProcess
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub BankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_bank", Me) = False Then
            Dim obj As New frm_bank
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        If ObjclsGen.ShowForm("changepwd", Me) = False Then
            Dim obj As New changepwd
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub CreateUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateUserToolStripMenuItem.Click
        If ObjclsGen.ShowForm("createuser", Me) = False Then
            Dim obj As New createuser
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub ProfessionTaxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfessionTaxToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_professiontax", Me) = False Then
            Dim obj As New frm_professiontax
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub QuitApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitApplicationToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub TEMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Dim temp As New Reportviewer("company")
        ' temp.Show()
    End Sub

    Private Sub LocationWiseDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationWiseDepartmentToolStripMenuItem.Click
        Dim temp As New frm_locwisedeptemp
        temp.Show()
    End Sub

    Private Sub WorkTimingsScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkTimingsScheduleToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_work_timings_schedule", Me) = False Then
            Dim obj As New frm_work_timings_schedule
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If ObjclsGen.ShowForm("frm_backup_restore", Me) = False Then
            Dim obj As New frm_backup_restore
            obj.Show()
            obj.MdiParent = Me
        End If
    End Sub

    Private Sub EmployeeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeReportToolStripMenuItem.Click
        Dim temp As New frm_employeelist
        temp.Show()
    End Sub


    Private Sub WorkScheduleReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkScheduleReportToolStripMenuItem.Click
        Dim temp As New frm_workschedule
        temp.Show()
    End Sub

  
    Private Sub ResignedCompanyLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell(Application.StartupPath & "\open.bat", AppWinStyle.Hide)
    End Sub

    Private Sub SalaryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalaryReportToolStripMenuItem.Click
        Dim temp As New frm_salary
        temp.Show()
    End Sub

#End Region
End Class