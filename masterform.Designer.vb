<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class masterform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(masterform))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CompanyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LocationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessPeriodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeSalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeAttendenceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeOvertimeAttendenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeSalaryProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfessionTaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WorkTimingsScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LocationWiseDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WorkScheduleReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalaryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HumanResourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LeaveApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecruitmentRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecruitmentApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuggestionRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SuggestionApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComplaintRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComplaintApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransferOfEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrainingVenueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TrainingEnrollmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.cmpname = New System.Windows.Forms.StatusBarPanel
        Me.todaydate = New System.Windows.Forms.StatusBarPanel
        Me.MenuStrip1.SuspendLayout()
        CType(Me.cmpname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.todaydate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem1, Me.PayrollToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HumanResourceToolStripMenuItem, Me.ToolStripMenuItem1, Me.QuitApplicationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem1
        '
        Me.MasterToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem1, Me.LocationToolStripMenuItem1, Me.DepartmentToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.ProcessPeriodToolStripMenuItem, Me.BankToolStripMenuItem})
        Me.MasterToolStripMenuItem1.Name = "MasterToolStripMenuItem1"
        Me.MasterToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MasterToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem1.Text = "&Master"
        '
        'CompanyToolStripMenuItem1
        '
        Me.CompanyToolStripMenuItem1.Name = "CompanyToolStripMenuItem1"
        Me.CompanyToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CompanyToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.CompanyToolStripMenuItem1.Text = "&Company"
        '
        'LocationToolStripMenuItem1
        '
        Me.LocationToolStripMenuItem1.Name = "LocationToolStripMenuItem1"
        Me.LocationToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LocationToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.LocationToolStripMenuItem1.Text = "&Location"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DepartmentToolStripMenuItem.Text = "&Department"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EmployeeToolStripMenuItem.Text = "&Employee"
        '
        'ProcessPeriodToolStripMenuItem
        '
        Me.ProcessPeriodToolStripMenuItem.Name = "ProcessPeriodToolStripMenuItem"
        Me.ProcessPeriodToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProcessPeriodToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ProcessPeriodToolStripMenuItem.Text = "&Process Period"
        '
        'BankToolStripMenuItem
        '
        Me.BankToolStripMenuItem.Name = "BankToolStripMenuItem"
        Me.BankToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BankToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BankToolStripMenuItem.Text = "&Bank"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionsToolStripMenuItem, Me.ProfessionTaxToolStripMenuItem, Me.WorkTimingsScheduleToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PayrollToolStripMenuItem.Text = "&Payroll"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeSalaryToolStripMenuItem, Me.EmployeeAttendenceToolStripMenuItem1, Me.EmployeeOvertimeAttendenceToolStripMenuItem, Me.EmployeeSalaryProcessToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.TransactionsToolStripMenuItem.Text = "&Transactions"
        '
        'EmployeeSalaryToolStripMenuItem
        '
        Me.EmployeeSalaryToolStripMenuItem.Name = "EmployeeSalaryToolStripMenuItem"
        Me.EmployeeSalaryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EmployeeSalaryToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.EmployeeSalaryToolStripMenuItem.Text = "Employee &Salary"
        '
        'EmployeeAttendenceToolStripMenuItem1
        '
        Me.EmployeeAttendenceToolStripMenuItem1.Name = "EmployeeAttendenceToolStripMenuItem1"
        Me.EmployeeAttendenceToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.EmployeeAttendenceToolStripMenuItem1.Size = New System.Drawing.Size(285, 22)
        Me.EmployeeAttendenceToolStripMenuItem1.Text = "Employee &Attendence"
        '
        'EmployeeOvertimeAttendenceToolStripMenuItem
        '
        Me.EmployeeOvertimeAttendenceToolStripMenuItem.Name = "EmployeeOvertimeAttendenceToolStripMenuItem"
        Me.EmployeeOvertimeAttendenceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.EmployeeOvertimeAttendenceToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.EmployeeOvertimeAttendenceToolStripMenuItem.Text = "Employee &Overtime Attendence"
        '
        'EmployeeSalaryProcessToolStripMenuItem
        '
        Me.EmployeeSalaryProcessToolStripMenuItem.Name = "EmployeeSalaryProcessToolStripMenuItem"
        Me.EmployeeSalaryProcessToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.EmployeeSalaryProcessToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.EmployeeSalaryProcessToolStripMenuItem.Text = "Employee Salary &Process"
        '
        'ProfessionTaxToolStripMenuItem
        '
        Me.ProfessionTaxToolStripMenuItem.Name = "ProfessionTaxToolStripMenuItem"
        Me.ProfessionTaxToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.ProfessionTaxToolStripMenuItem.Text = "Profession Tax"
        '
        'WorkTimingsScheduleToolStripMenuItem
        '
        Me.WorkTimingsScheduleToolStripMenuItem.Name = "WorkTimingsScheduleToolStripMenuItem"
        Me.WorkTimingsScheduleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.WorkTimingsScheduleToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.WorkTimingsScheduleToolStripMenuItem.Text = "&Work Timings Schedule"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocationWiseDepartmentToolStripMenuItem, Me.EmployeeReportToolStripMenuItem, Me.WorkScheduleReportToolStripMenuItem, Me.SalaryReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'LocationWiseDepartmentToolStripMenuItem
        '
        Me.LocationWiseDepartmentToolStripMenuItem.Name = "LocationWiseDepartmentToolStripMenuItem"
        Me.LocationWiseDepartmentToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.LocationWiseDepartmentToolStripMenuItem.Text = "Location Wise Department"
        '
        'EmployeeReportToolStripMenuItem
        '
        Me.EmployeeReportToolStripMenuItem.Name = "EmployeeReportToolStripMenuItem"
        Me.EmployeeReportToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.EmployeeReportToolStripMenuItem.Text = "Employee Report"
        '
        'WorkScheduleReportToolStripMenuItem
        '
        Me.WorkScheduleReportToolStripMenuItem.Name = "WorkScheduleReportToolStripMenuItem"
        Me.WorkScheduleReportToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.WorkScheduleReportToolStripMenuItem.Text = "Work Schedule Report"
        '
        'SalaryReportToolStripMenuItem
        '
        Me.SalaryReportToolStripMenuItem.Name = "SalaryReportToolStripMenuItem"
        Me.SalaryReportToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SalaryReportToolStripMenuItem.Text = "Salary Report"
        '
        'HumanResourceToolStripMenuItem
        '
        Me.HumanResourceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionsToolStripMenuItem1})
        Me.HumanResourceToolStripMenuItem.Name = "HumanResourceToolStripMenuItem"
        Me.HumanResourceToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.HumanResourceToolStripMenuItem.Text = "&Human Resource"
        Me.HumanResourceToolStripMenuItem.Visible = False
        '
        'TransactionsToolStripMenuItem1
        '
        Me.TransactionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeaveApplicationToolStripMenuItem, Me.RecruitmentRequestToolStripMenuItem, Me.RecruitmentApprovalToolStripMenuItem, Me.SuggestionRegisterToolStripMenuItem, Me.SuggestionApprovalToolStripMenuItem, Me.ComplaintRegisterToolStripMenuItem, Me.ComplaintApprovalToolStripMenuItem, Me.TransferOfEmployeeToolStripMenuItem, Me.TrainerToolStripMenuItem, Me.TrainingVenueToolStripMenuItem, Me.TrainingEnrollmentToolStripMenuItem})
        Me.TransactionsToolStripMenuItem1.Name = "TransactionsToolStripMenuItem1"
        Me.TransactionsToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TransactionsToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.TransactionsToolStripMenuItem1.Text = "&Transactions"
        '
        'LeaveApplicationToolStripMenuItem
        '
        Me.LeaveApplicationToolStripMenuItem.Name = "LeaveApplicationToolStripMenuItem"
        Me.LeaveApplicationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LeaveApplicationToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.LeaveApplicationToolStripMenuItem.Text = "&Leave Application && Approval"
        '
        'RecruitmentRequestToolStripMenuItem
        '
        Me.RecruitmentRequestToolStripMenuItem.Name = "RecruitmentRequestToolStripMenuItem"
        Me.RecruitmentRequestToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RecruitmentRequestToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.RecruitmentRequestToolStripMenuItem.Text = "&Recruitment Request"
        '
        'RecruitmentApprovalToolStripMenuItem
        '
        Me.RecruitmentApprovalToolStripMenuItem.Name = "RecruitmentApprovalToolStripMenuItem"
        Me.RecruitmentApprovalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.RecruitmentApprovalToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.RecruitmentApprovalToolStripMenuItem.Text = "Recruitment &Approval"
        '
        'SuggestionRegisterToolStripMenuItem
        '
        Me.SuggestionRegisterToolStripMenuItem.Name = "SuggestionRegisterToolStripMenuItem"
        Me.SuggestionRegisterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.SuggestionRegisterToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.SuggestionRegisterToolStripMenuItem.Text = "Suggestion Re&gister"
        '
        'SuggestionApprovalToolStripMenuItem
        '
        Me.SuggestionApprovalToolStripMenuItem.Name = "SuggestionApprovalToolStripMenuItem"
        Me.SuggestionApprovalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SuggestionApprovalToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.SuggestionApprovalToolStripMenuItem.Text = "&Suggestion Approval"
        '
        'ComplaintRegisterToolStripMenuItem
        '
        Me.ComplaintRegisterToolStripMenuItem.Name = "ComplaintRegisterToolStripMenuItem"
        Me.ComplaintRegisterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ComplaintRegisterToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.ComplaintRegisterToolStripMenuItem.Text = "&Complaint Register "
        '
        'ComplaintApprovalToolStripMenuItem
        '
        Me.ComplaintApprovalToolStripMenuItem.Name = "ComplaintApprovalToolStripMenuItem"
        Me.ComplaintApprovalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ComplaintApprovalToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.ComplaintApprovalToolStripMenuItem.Text = "Complaint A&pproval"
        '
        'TransferOfEmployeeToolStripMenuItem
        '
        Me.TransferOfEmployeeToolStripMenuItem.Name = "TransferOfEmployeeToolStripMenuItem"
        Me.TransferOfEmployeeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.TransferOfEmployeeToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.TransferOfEmployeeToolStripMenuItem.Text = "Transfer of Employee"
        '
        'TrainerToolStripMenuItem
        '
        Me.TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem"
        Me.TrainerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TrainerToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.TrainerToolStripMenuItem.Text = "&Trainer"
        '
        'TrainingVenueToolStripMenuItem
        '
        Me.TrainingVenueToolStripMenuItem.Name = "TrainingVenueToolStripMenuItem"
        Me.TrainingVenueToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.TrainingVenueToolStripMenuItem.Text = "Training Venue"
        '
        'TrainingEnrollmentToolStripMenuItem
        '
        Me.TrainingEnrollmentToolStripMenuItem.Name = "TrainingEnrollmentToolStripMenuItem"
        Me.TrainingEnrollmentToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.TrainingEnrollmentToolStripMenuItem.Text = "Training Enrollment"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.CreateUserToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "&Utility"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'CreateUserToolStripMenuItem
        '
        Me.CreateUserToolStripMenuItem.Name = "CreateUserToolStripMenuItem"
        Me.CreateUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CreateUserToolStripMenuItem.Text = "Create user"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Backup/Restore"
        '
        'QuitApplicationToolStripMenuItem
        '
        Me.QuitApplicationToolStripMenuItem.Name = "QuitApplicationToolStripMenuItem"
        Me.QuitApplicationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitApplicationToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.QuitApplicationToolStripMenuItem.Text = "&Quit Application"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 451)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.cmpname, Me.todaydate})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(750, 22)
        Me.StatusBar1.TabIndex = 3
        '
        'cmpname
        '
        Me.cmpname.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.cmpname.MinWidth = 30
        Me.cmpname.Name = "cmpname"
        Me.cmpname.Text = "Laxmi Diamond Pvt. Ltd."
        Me.cmpname.Width = 137
        '
        'todaydate
        '
        Me.todaydate.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.todaydate.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.todaydate.MinWidth = 30
        Me.todaydate.Name = "todaydate"
        Me.todaydate.Text = "StatusBarPanel3"
        Me.todaydate.Width = 596
        '
        'masterform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(750, 473)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "masterform"
        Me.Text = "PayRoll Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.cmpname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.todaydate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessPeriodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeSalaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeAttendenceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeOvertimeAttendenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeSalaryProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HumanResourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecruitmentRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecruitmentApprovalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuggestionRegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuggestionApprovalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintRegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintApprovalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferOfEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainingVenueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrainingEnrollmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfessionTaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocationWiseDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkTimingsScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents cmpname As System.Windows.Forms.StatusBarPanel
    Friend WithEvents todaydate As System.Windows.Forms.StatusBarPanel
    Friend WithEvents WorkScheduleReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalaryReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
