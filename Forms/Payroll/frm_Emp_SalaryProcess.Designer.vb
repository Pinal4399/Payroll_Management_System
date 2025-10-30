<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Emp_SalaryProcess
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Emp_SalaryProcess))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grp_searchcriteria = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblperiod = New System.Windows.Forms.Label
        Me.btnfind = New System.Windows.Forms.Button
        Me.lbldeptname = New System.Windows.Forms.Label
        Me.lbllocname = New System.Windows.Forms.Label
        Me.lblrealsal = New System.Windows.Forms.Label
        Me.lblchequesal = New System.Windows.Forms.Label
        Me.lblpayablesal = New System.Windows.Forms.Label
        Me.lblovertimesal = New System.Windows.Forms.Label
        Me.lblcashsal = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.lbltotalemp = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grid_emp_salaryprocess = New DefaultControls.DataGridView
        Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.realsal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chequesal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.presenthrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.payablesal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.overtimehrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.overtimesal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.totalsal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cashsal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.basic = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.da = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.wa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.isadded = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtcashsal = New DefaultControls.MaskedBox(Me.components)
        Me.txtovertimesal = New DefaultControls.MaskedBox(Me.components)
        Me.txtpayablesal = New DefaultControls.MaskedBox(Me.components)
        Me.txtchequesal = New DefaultControls.MaskedBox(Me.components)
        Me.txtrealsal = New DefaultControls.MaskedBox(Me.components)
        Me.txtworkinghrs = New DefaultControls.MaskedBox(Me.components)
        Me.cmbprocessperiod = New DefaultControls.ComboBox
        Me.cmbdeptname = New DefaultControls.ComboBox
        Me.cmblocname = New DefaultControls.ComboBox
        Me.grp_searchcriteria.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_emp_salaryprocess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_searchcriteria
        '
        Me.grp_searchcriteria.Controls.Add(Me.txtworkinghrs)
        Me.grp_searchcriteria.Controls.Add(Me.cmbprocessperiod)
        Me.grp_searchcriteria.Controls.Add(Me.cmbdeptname)
        Me.grp_searchcriteria.Controls.Add(Me.cmblocname)
        Me.grp_searchcriteria.Controls.Add(Me.Label1)
        Me.grp_searchcriteria.Controls.Add(Me.lblperiod)
        Me.grp_searchcriteria.Controls.Add(Me.btnfind)
        Me.grp_searchcriteria.Controls.Add(Me.lbldeptname)
        Me.grp_searchcriteria.Controls.Add(Me.lbllocname)
        Me.grp_searchcriteria.Location = New System.Drawing.Point(10, 12)
        Me.grp_searchcriteria.Name = "grp_searchcriteria"
        Me.grp_searchcriteria.Size = New System.Drawing.Size(922, 61)
        Me.grp_searchcriteria.TabIndex = 2
        Me.grp_searchcriteria.TabStop = False
        Me.grp_searchcriteria.Text = "Search Criteria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(636, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Working Hours :*"
        '
        'lblperiod
        '
        Me.lblperiod.AutoSize = True
        Me.lblperiod.Location = New System.Drawing.Point(410, 29)
        Me.lblperiod.Name = "lblperiod"
        Me.lblperiod.Size = New System.Drawing.Size(88, 13)
        Me.lblperiod.TabIndex = 5
        Me.lblperiod.Text = "Process Period :*"
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(805, 19)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(109, 36)
        Me.btnfind.TabIndex = 4
        Me.btnfind.Text = "&Find/Generate Salary"
        Me.btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'lbldeptname
        '
        Me.lbldeptname.AutoSize = True
        Me.lbldeptname.Location = New System.Drawing.Point(200, 29)
        Me.lbldeptname.Name = "lbldeptname"
        Me.lbldeptname.Size = New System.Drawing.Size(72, 13)
        Me.lbldeptname.TabIndex = 1
        Me.lbldeptname.Text = "Department :*"
        '
        'lbllocname
        '
        Me.lbllocname.AutoSize = True
        Me.lbllocname.Location = New System.Drawing.Point(9, 27)
        Me.lbllocname.Name = "lbllocname"
        Me.lbllocname.Size = New System.Drawing.Size(58, 13)
        Me.lbllocname.TabIndex = 0
        Me.lbllocname.Text = "Location :*"
        '
        'lblrealsal
        '
        Me.lblrealsal.AutoSize = True
        Me.lblrealsal.Location = New System.Drawing.Point(9, 389)
        Me.lblrealsal.Name = "lblrealsal"
        Me.lblrealsal.Size = New System.Drawing.Size(61, 13)
        Me.lblrealsal.TabIndex = 10
        Me.lblrealsal.Text = "Real Salary"
        '
        'lblchequesal
        '
        Me.lblchequesal.AutoSize = True
        Me.lblchequesal.Location = New System.Drawing.Point(114, 389)
        Me.lblchequesal.Name = "lblchequesal"
        Me.lblchequesal.Size = New System.Drawing.Size(76, 13)
        Me.lblchequesal.TabIndex = 16
        Me.lblchequesal.Text = "Cheque Salary"
        '
        'lblpayablesal
        '
        Me.lblpayablesal.AutoSize = True
        Me.lblpayablesal.Location = New System.Drawing.Point(222, 389)
        Me.lblpayablesal.Name = "lblpayablesal"
        Me.lblpayablesal.Size = New System.Drawing.Size(77, 13)
        Me.lblpayablesal.TabIndex = 18
        Me.lblpayablesal.Text = "Payable Salary"
        '
        'lblovertimesal
        '
        Me.lblovertimesal.AutoSize = True
        Me.lblovertimesal.Location = New System.Drawing.Point(332, 389)
        Me.lblovertimesal.Name = "lblovertimesal"
        Me.lblovertimesal.Size = New System.Drawing.Size(56, 13)
        Me.lblovertimesal.TabIndex = 20
        Me.lblovertimesal.Text = "Over Time"
        '
        'lblcashsal
        '
        Me.lblcashsal.AutoSize = True
        Me.lblcashsal.Location = New System.Drawing.Point(439, 389)
        Me.lblcashsal.Name = "lblcashsal"
        Me.lblcashsal.Size = New System.Drawing.Size(63, 13)
        Me.lblcashsal.TabIndex = 22
        Me.lblcashsal.Text = "Cash Salary"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(621, 413)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(63, 23)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(704, 413)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(63, 23)
        Me.btnclear.TabIndex = 6
        Me.btnclear.Text = "Cl&ear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.Location = New System.Drawing.Point(786, 413)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(63, 23)
        Me.btnreport.TabIndex = 7
        Me.btnreport.Text = "&Report"
        Me.btnreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(868, 413)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(65, 23)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "&Close"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lbltotalemp
        '
        Me.lbltotalemp.AutoSize = True
        Me.lbltotalemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalemp.ForeColor = System.Drawing.Color.Red
        Me.lbltotalemp.Location = New System.Drawing.Point(788, 389)
        Me.lbltotalemp.Name = "lbltotalemp"
        Me.lbltotalemp.Size = New System.Drawing.Size(108, 13)
        Me.lbltotalemp.TabIndex = 27
        Me.lbltotalemp.Text = "Total Employees :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_emp_salaryprocess)
        Me.Panel1.Location = New System.Drawing.Point(9, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(922, 307)
        Me.Panel1.TabIndex = 32
        '
        'grid_emp_salaryprocess
        '
        Me.grid_emp_salaryprocess.AllowUserToAddRows = False
        Me.grid_emp_salaryprocess.AllowUserToResizeColumns = False
        Me.grid_emp_salaryprocess.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_emp_salaryprocess.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_emp_salaryprocess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_emp_salaryprocess.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empname, Me.empcode, Me.realsal, Me.chequesal, Me.presenthrs, Me.payablesal, Me.overtimehrs, Me.overtimesal, Me.totalsal, Me.cashsal, Me.basic, Me.da, Me.hra, Me.ca, Me.ea, Me.wa, Me.pt, Me.isadded})
        Me.grid_emp_salaryprocess.Location = New System.Drawing.Point(3, 17)
        Me.grid_emp_salaryprocess.Name = "grid_emp_salaryprocess"
        Me.grid_emp_salaryprocess.ReadOnly = True
        Me.grid_emp_salaryprocess.Size = New System.Drawing.Size(909, 273)
        Me.grid_emp_salaryprocess.TabIndex = 33
        '
        'empname
        '
        Me.empname.DataPropertyName = "short_name"
        Me.empname.Frozen = True
        Me.empname.HeaderText = "Employee Name"
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        '
        'empcode
        '
        Me.empcode.DataPropertyName = "employee_code"
        Me.empcode.Frozen = True
        Me.empcode.HeaderText = "Employee Code"
        Me.empcode.Name = "empcode"
        Me.empcode.ReadOnly = True
        '
        'realsal
        '
        Me.realsal.DataPropertyName = "salary"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.realsal.DefaultCellStyle = DataGridViewCellStyle2
        Me.realsal.HeaderText = "Real Salary"
        Me.realsal.Name = "realsal"
        Me.realsal.ReadOnly = True
        Me.realsal.Width = 95
        '
        'chequesal
        '
        Me.chequesal.DataPropertyName = "cheque_salary"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.chequesal.DefaultCellStyle = DataGridViewCellStyle3
        Me.chequesal.HeaderText = "Cheque Salary"
        Me.chequesal.Name = "chequesal"
        Me.chequesal.ReadOnly = True
        Me.chequesal.Width = 95
        '
        'presenthrs
        '
        Me.presenthrs.DataPropertyName = "present_hrs"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.presenthrs.DefaultCellStyle = DataGridViewCellStyle4
        Me.presenthrs.HeaderText = "Present Hrs"
        Me.presenthrs.Name = "presenthrs"
        Me.presenthrs.ReadOnly = True
        Me.presenthrs.Width = 70
        '
        'payablesal
        '
        Me.payablesal.DataPropertyName = "payable_salary"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.payablesal.DefaultCellStyle = DataGridViewCellStyle5
        Me.payablesal.HeaderText = "Payable Salary"
        Me.payablesal.Name = "payablesal"
        Me.payablesal.ReadOnly = True
        Me.payablesal.Width = 95
        '
        'overtimehrs
        '
        Me.overtimehrs.DataPropertyName = "overtime_hrs"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.overtimehrs.DefaultCellStyle = DataGridViewCellStyle6
        Me.overtimehrs.HeaderText = "Over Time Hrs"
        Me.overtimehrs.Name = "overtimehrs"
        Me.overtimehrs.ReadOnly = True
        Me.overtimehrs.Width = 70
        '
        'overtimesal
        '
        Me.overtimesal.DataPropertyName = "overtime_salary"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.overtimesal.DefaultCellStyle = DataGridViewCellStyle7
        Me.overtimesal.HeaderText = "Over Time"
        Me.overtimesal.Name = "overtimesal"
        Me.overtimesal.ReadOnly = True
        Me.overtimesal.Width = 80
        '
        'totalsal
        '
        Me.totalsal.DataPropertyName = "total_salary"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.totalsal.DefaultCellStyle = DataGridViewCellStyle8
        Me.totalsal.HeaderText = "Total Salary (Payable+Overtime-PT)"
        Me.totalsal.Name = "totalsal"
        Me.totalsal.ReadOnly = True
        Me.totalsal.Width = 140
        '
        'cashsal
        '
        Me.cashsal.DataPropertyName = "cash_salary"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cashsal.DefaultCellStyle = DataGridViewCellStyle9
        Me.cashsal.HeaderText = "Cash Salary"
        Me.cashsal.Name = "cashsal"
        Me.cashsal.ReadOnly = True
        '
        'basic
        '
        Me.basic.DataPropertyName = "basic"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.basic.DefaultCellStyle = DataGridViewCellStyle10
        Me.basic.HeaderText = "Basic"
        Me.basic.Name = "basic"
        Me.basic.ReadOnly = True
        '
        'da
        '
        Me.da.DataPropertyName = "da"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.da.DefaultCellStyle = DataGridViewCellStyle11
        Me.da.HeaderText = "DA"
        Me.da.Name = "da"
        Me.da.ReadOnly = True
        '
        'hra
        '
        Me.hra.DataPropertyName = "hra"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.hra.DefaultCellStyle = DataGridViewCellStyle12
        Me.hra.HeaderText = "HRA"
        Me.hra.Name = "hra"
        Me.hra.ReadOnly = True
        '
        'ca
        '
        Me.ca.DataPropertyName = "ca"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        Me.ca.DefaultCellStyle = DataGridViewCellStyle13
        Me.ca.HeaderText = "CA"
        Me.ca.Name = "ca"
        Me.ca.ReadOnly = True
        '
        'ea
        '
        Me.ea.DataPropertyName = "ea"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        Me.ea.DefaultCellStyle = DataGridViewCellStyle14
        Me.ea.HeaderText = "EA"
        Me.ea.Name = "ea"
        Me.ea.ReadOnly = True
        '
        'wa
        '
        Me.wa.DataPropertyName = "wa"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        Me.wa.DefaultCellStyle = DataGridViewCellStyle15
        Me.wa.HeaderText = "WA"
        Me.wa.Name = "wa"
        Me.wa.ReadOnly = True
        '
        'pt
        '
        Me.pt.DataPropertyName = "pt"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        Me.pt.DefaultCellStyle = DataGridViewCellStyle16
        Me.pt.HeaderText = "PT"
        Me.pt.Name = "pt"
        Me.pt.ReadOnly = True
        '
        'isadded
        '
        Me.isadded.DataPropertyName = "is_added"
        Me.isadded.HeaderText = "Is Added"
        Me.isadded.Name = "isadded"
        Me.isadded.ReadOnly = True
        Me.isadded.Visible = False
        '
        'txtcashsal
        '
        Me.txtcashsal.CheckBounds = False
        Me.txtcashsal.DateFormat = Nothing
        Me.txtcashsal.DecimalPlaces = CType(0, Byte)
        Me.txtcashsal.Location = New System.Drawing.Point(432, 405)
        Me.txtcashsal.MaxDate = New Date(CType(0, Long))
        Me.txtcashsal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcashsal.MinDate = New Date(CType(0, Long))
        Me.txtcashsal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcashsal.Name = "txtcashsal"
        Me.txtcashsal.ReadOnly = True
        Me.txtcashsal.Size = New System.Drawing.Size(100, 20)
        Me.txtcashsal.TabIndex = 31
        Me.txtcashsal.Text = "0"
        Me.txtcashsal.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtovertimesal
        '
        Me.txtovertimesal.CheckBounds = False
        Me.txtovertimesal.DateFormat = Nothing
        Me.txtovertimesal.DecimalPlaces = CType(0, Byte)
        Me.txtovertimesal.Location = New System.Drawing.Point(326, 405)
        Me.txtovertimesal.MaxDate = New Date(CType(0, Long))
        Me.txtovertimesal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtovertimesal.MinDate = New Date(CType(0, Long))
        Me.txtovertimesal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtovertimesal.Name = "txtovertimesal"
        Me.txtovertimesal.ReadOnly = True
        Me.txtovertimesal.Size = New System.Drawing.Size(100, 20)
        Me.txtovertimesal.TabIndex = 30
        Me.txtovertimesal.Text = "0"
        Me.txtovertimesal.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtpayablesal
        '
        Me.txtpayablesal.CheckBounds = False
        Me.txtpayablesal.DateFormat = Nothing
        Me.txtpayablesal.DecimalPlaces = CType(0, Byte)
        Me.txtpayablesal.Location = New System.Drawing.Point(220, 405)
        Me.txtpayablesal.MaxDate = New Date(CType(0, Long))
        Me.txtpayablesal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpayablesal.MinDate = New Date(CType(0, Long))
        Me.txtpayablesal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpayablesal.Name = "txtpayablesal"
        Me.txtpayablesal.ReadOnly = True
        Me.txtpayablesal.Size = New System.Drawing.Size(100, 20)
        Me.txtpayablesal.TabIndex = 29
        Me.txtpayablesal.Text = "0"
        Me.txtpayablesal.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtchequesal
        '
        Me.txtchequesal.CheckBounds = False
        Me.txtchequesal.DateFormat = Nothing
        Me.txtchequesal.DecimalPlaces = CType(0, Byte)
        Me.txtchequesal.Location = New System.Drawing.Point(114, 405)
        Me.txtchequesal.MaxDate = New Date(CType(0, Long))
        Me.txtchequesal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtchequesal.MinDate = New Date(CType(0, Long))
        Me.txtchequesal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtchequesal.Name = "txtchequesal"
        Me.txtchequesal.ReadOnly = True
        Me.txtchequesal.Size = New System.Drawing.Size(100, 20)
        Me.txtchequesal.TabIndex = 28
        Me.txtchequesal.Text = "0"
        Me.txtchequesal.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtrealsal
        '
        Me.txtrealsal.CheckBounds = False
        Me.txtrealsal.DateFormat = Nothing
        Me.txtrealsal.DecimalPlaces = CType(0, Byte)
        Me.txtrealsal.Location = New System.Drawing.Point(8, 405)
        Me.txtrealsal.MaxDate = New Date(CType(0, Long))
        Me.txtrealsal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtrealsal.MinDate = New Date(CType(0, Long))
        Me.txtrealsal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtrealsal.Name = "txtrealsal"
        Me.txtrealsal.ReadOnly = True
        Me.txtrealsal.Size = New System.Drawing.Size(100, 20)
        Me.txtrealsal.TabIndex = 12
        Me.txtrealsal.Text = "0"
        Me.txtrealsal.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtworkinghrs
        '
        Me.txtworkinghrs.CheckBounds = False
        Me.txtworkinghrs.DateFormat = Nothing
        Me.txtworkinghrs.DecimalPlaces = CType(0, Byte)
        Me.txtworkinghrs.Location = New System.Drawing.Point(727, 26)
        Me.txtworkinghrs.MaxDate = New Date(CType(0, Long))
        Me.txtworkinghrs.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtworkinghrs.MinDate = New Date(CType(0, Long))
        Me.txtworkinghrs.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtworkinghrs.Name = "txtworkinghrs"
        Me.txtworkinghrs.ReadOnly = True
        Me.txtworkinghrs.Size = New System.Drawing.Size(63, 20)
        Me.txtworkinghrs.TabIndex = 3
        Me.txtworkinghrs.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'cmbprocessperiod
        '
        Me.cmbprocessperiod.AutoDropDown = False
        Me.cmbprocessperiod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprocessperiod.FormattingEnabled = True
        Me.cmbprocessperiod.Location = New System.Drawing.Point(502, 24)
        Me.cmbprocessperiod.Name = "cmbprocessperiod"
        Me.cmbprocessperiod.Size = New System.Drawing.Size(117, 21)
        Me.cmbprocessperiod.TabIndex = 2
        '
        'cmbdeptname
        '
        Me.cmbdeptname.AutoDropDown = False
        Me.cmbdeptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(276, 26)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(117, 21)
        Me.cmbdeptname.TabIndex = 1
        '
        'cmblocname
        '
        Me.cmblocname.AutoDropDown = False
        Me.cmblocname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocname.FormattingEnabled = True
        Me.cmblocname.Location = New System.Drawing.Point(71, 24)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(121, 21)
        Me.cmblocname.TabIndex = 0
        '
        'frm_Emp_SalaryProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtcashsal)
        Me.Controls.Add(Me.txtovertimesal)
        Me.Controls.Add(Me.txtpayablesal)
        Me.Controls.Add(Me.txtchequesal)
        Me.Controls.Add(Me.txtrealsal)
        Me.Controls.Add(Me.lbltotalemp)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblcashsal)
        Me.Controls.Add(Me.lblovertimesal)
        Me.Controls.Add(Me.lblpayablesal)
        Me.Controls.Add(Me.lblchequesal)
        Me.Controls.Add(Me.lblrealsal)
        Me.Controls.Add(Me.grp_searchcriteria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Emp_SalaryProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Salary Process"
        Me.grp_searchcriteria.ResumeLayout(False)
        Me.grp_searchcriteria.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_emp_salaryprocess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_searchcriteria As System.Windows.Forms.GroupBox
    Friend WithEvents lblperiod As System.Windows.Forms.Label
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents lbldeptname As System.Windows.Forms.Label
    Friend WithEvents lbllocname As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblrealsal As System.Windows.Forms.Label
    Friend WithEvents lblchequesal As System.Windows.Forms.Label
    Friend WithEvents lblpayablesal As System.Windows.Forms.Label
    Friend WithEvents lblovertimesal As System.Windows.Forms.Label
    Friend WithEvents lblcashsal As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lbltotalemp As System.Windows.Forms.Label
    Friend WithEvents txtworkinghrs As DefaultControls.MaskedBox
    Friend WithEvents cmbprocessperiod As DefaultControls.ComboBox
    Friend WithEvents cmbdeptname As DefaultControls.ComboBox
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents txtrealsal As DefaultControls.MaskedBox
    Friend WithEvents txtchequesal As DefaultControls.MaskedBox
    Friend WithEvents txtpayablesal As DefaultControls.MaskedBox
    Friend WithEvents txtovertimesal As DefaultControls.MaskedBox
    Friend WithEvents txtcashsal As DefaultControls.MaskedBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_emp_salaryprocess As DefaultControls.DataGridView
    Friend WithEvents empname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents realsal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chequesal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents presenthrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents payablesal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents overtimehrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents overtimesal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalsal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cashsal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents basic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents da As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isadded As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
