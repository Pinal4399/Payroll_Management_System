<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_training_enrollment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_training_enrollment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnl_enroll = New System.Windows.Forms.Panel
        Me.lbltotalemp = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnfind = New System.Windows.Forms.Button
        Me.lblvenue = New System.Windows.Forms.Label
        Me.lbltodate = New System.Windows.Forms.Label
        Me.lblfromdate = New System.Windows.Forms.Label
        Me.lbltrainer = New System.Windows.Forms.Label
        Me.lblduration = New System.Windows.Forms.Label
        Me.dttodate = New DefaultControls.DateTimePicker
        Me.dtfromdate = New DefaultControls.DateTimePicker
        Me.cmbvenue = New DefaultControls.ComboBox
        Me.cmbtrainer = New DefaultControls.ComboBox
        Me.txtduration = New DefaultControls.MaskedBox(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpempdetail = New DefaultControls.GroupBox(Me.components)
        Me.grid_emp_enrolldetail = New DefaultControls.DataGridView
        Me.enrollmentid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmemp_code = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmlocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dept = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.locname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.deptname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnl_enroll.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpempdetail.SuspendLayout()
        CType(Me.grid_emp_enrolldetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_enroll
        '
        Me.pnl_enroll.Controls.Add(Me.Panel1)
        Me.pnl_enroll.Controls.Add(Me.lbltotalemp)
        Me.pnl_enroll.Controls.Add(Me.dttodate)
        Me.pnl_enroll.Controls.Add(Me.dtfromdate)
        Me.pnl_enroll.Controls.Add(Me.btnsave)
        Me.pnl_enroll.Controls.Add(Me.btnclear)
        Me.pnl_enroll.Controls.Add(Me.btncancel)
        Me.pnl_enroll.Controls.Add(Me.btnfind)
        Me.pnl_enroll.Controls.Add(Me.cmbvenue)
        Me.pnl_enroll.Controls.Add(Me.lblvenue)
        Me.pnl_enroll.Controls.Add(Me.lbltodate)
        Me.pnl_enroll.Controls.Add(Me.lblfromdate)
        Me.pnl_enroll.Controls.Add(Me.cmbtrainer)
        Me.pnl_enroll.Controls.Add(Me.lbltrainer)
        Me.pnl_enroll.Controls.Add(Me.txtduration)
        Me.pnl_enroll.Controls.Add(Me.lblduration)
        Me.pnl_enroll.Location = New System.Drawing.Point(12, 12)
        Me.pnl_enroll.Name = "pnl_enroll"
        Me.pnl_enroll.Size = New System.Drawing.Size(782, 464)
        Me.pnl_enroll.TabIndex = 0
        '
        'lbltotalemp
        '
        Me.lbltotalemp.AutoSize = True
        Me.lbltotalemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalemp.ForeColor = System.Drawing.Color.Red
        Me.lbltotalemp.Location = New System.Drawing.Point(628, 404)
        Me.lbltotalemp.Name = "lbltotalemp"
        Me.lbltotalemp.Size = New System.Drawing.Size(108, 13)
        Me.lbltotalemp.TabIndex = 79
        Me.lbltotalemp.Text = "Total Employees :"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(498, 428)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(593, 428)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "Cl&ear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(688, 428)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "&Close"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(341, 122)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(75, 23)
        Me.btnfind.TabIndex = 5
        Me.btnfind.Text = "&Find"
        Me.btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'lblvenue
        '
        Me.lblvenue.AutoSize = True
        Me.lblvenue.Location = New System.Drawing.Point(20, 127)
        Me.lblvenue.Name = "lblvenue"
        Me.lblvenue.Size = New System.Drawing.Size(48, 13)
        Me.lblvenue.TabIndex = 76
        Me.lblvenue.Text = "Venue :*"
        '
        'lbltodate
        '
        Me.lbltodate.AutoSize = True
        Me.lbltodate.Location = New System.Drawing.Point(350, 61)
        Me.lbltodate.Name = "lbltodate"
        Me.lbltodate.Size = New System.Drawing.Size(62, 13)
        Me.lbltodate.TabIndex = 71
        Me.lbltodate.Text = "End Date :*"
        '
        'lblfromdate
        '
        Me.lblfromdate.AutoSize = True
        Me.lblfromdate.Location = New System.Drawing.Point(20, 61)
        Me.lblfromdate.Name = "lblfromdate"
        Me.lblfromdate.Size = New System.Drawing.Size(68, 13)
        Me.lblfromdate.TabIndex = 70
        Me.lblfromdate.Text = "Start  Date :*"
        '
        'lbltrainer
        '
        Me.lbltrainer.AutoSize = True
        Me.lbltrainer.Location = New System.Drawing.Point(20, 26)
        Me.lbltrainer.Name = "lbltrainer"
        Me.lbltrainer.Size = New System.Drawing.Size(50, 13)
        Me.lbltrainer.TabIndex = 66
        Me.lbltrainer.Text = "Trainer :*"
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Location = New System.Drawing.Point(20, 93)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(53, 13)
        Me.lblduration.TabIndex = 56
        Me.lblduration.Text = "Duration :"
        '
        'dttodate
        '
        Me.dttodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttodate.Location = New System.Drawing.Point(434, 57)
        Me.dttodate.Name = "dttodate"
        Me.dttodate.Size = New System.Drawing.Size(190, 20)
        Me.dttodate.TabIndex = 2
        Me.dttodate.Value = New Date(2010, 3, 31, 0, 0, 0, 0)
        '
        'dtfromdate
        '
        Me.dtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfromdate.Location = New System.Drawing.Point(124, 57)
        Me.dtfromdate.Name = "dtfromdate"
        Me.dtfromdate.Size = New System.Drawing.Size(190, 20)
        Me.dtfromdate.TabIndex = 1
        Me.dtfromdate.Value = New Date(2010, 3, 31, 0, 0, 0, 0)
        '
        'cmbvenue
        '
        Me.cmbvenue.AutoDropDown = False
        Me.cmbvenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvenue.FormattingEnabled = True
        Me.cmbvenue.Location = New System.Drawing.Point(124, 123)
        Me.cmbvenue.Name = "cmbvenue"
        Me.cmbvenue.Size = New System.Drawing.Size(190, 21)
        Me.cmbvenue.TabIndex = 4
        '
        'cmbtrainer
        '
        Me.cmbtrainer.AutoDropDown = False
        Me.cmbtrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtrainer.FormattingEnabled = True
        Me.cmbtrainer.Location = New System.Drawing.Point(124, 23)
        Me.cmbtrainer.Name = "cmbtrainer"
        Me.cmbtrainer.Size = New System.Drawing.Size(190, 21)
        Me.cmbtrainer.TabIndex = 0
        '
        'txtduration
        '
        Me.txtduration.CheckBounds = False
        Me.txtduration.DateFormat = Nothing
        Me.txtduration.DecimalPlaces = CType(0, Byte)
        Me.txtduration.Enabled = False
        Me.txtduration.Location = New System.Drawing.Point(124, 90)
        Me.txtduration.MaxDate = New Date(CType(0, Long))
        Me.txtduration.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtduration.MinDate = New Date(CType(0, Long))
        Me.txtduration.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(190, 20)
        Me.txtduration.TabIndex = 3
        Me.txtduration.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpempdetail)
        Me.Panel1.Location = New System.Drawing.Point(23, 164)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 237)
        Me.Panel1.TabIndex = 80
        '
        'grpempdetail
        '
        Me.grpempdetail.AllowFormat = True
        Me.grpempdetail.Controls.Add(Me.grid_emp_enrolldetail)
        Me.grpempdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpempdetail.Location = New System.Drawing.Point(8, 4)
        Me.grpempdetail.Name = "grpempdetail"
        Me.grpempdetail.Size = New System.Drawing.Size(743, 228)
        Me.grpempdetail.TabIndex = 79
        Me.grpempdetail.TabStop = False
        Me.grpempdetail.Text = "Employee Details"
        '
        'grid_emp_enrolldetail
        '
        Me.grid_emp_enrolldetail.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_emp_enrolldetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_emp_enrolldetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_emp_enrolldetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.enrollmentid, Me.clmemp_code, Me.empname, Me.clmlocation, Me.dept, Me.locname, Me.deptname})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_emp_enrolldetail.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_emp_enrolldetail.Location = New System.Drawing.Point(12, 22)
        Me.grid_emp_enrolldetail.Name = "grid_emp_enrolldetail"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_emp_enrolldetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_emp_enrolldetail.Size = New System.Drawing.Size(714, 189)
        Me.grid_emp_enrolldetail.TabIndex = 0
        '
        'enrollmentid
        '
        Me.enrollmentid.DataPropertyName = "enrollment_id"
        Me.enrollmentid.HeaderText = "Enrollment Id"
        Me.enrollmentid.Name = "enrollmentid"
        Me.enrollmentid.ReadOnly = True
        Me.enrollmentid.Visible = False
        '
        'clmemp_code
        '
        Me.clmemp_code.DataPropertyName = "employee_code"
        Me.clmemp_code.HeaderText = "Employee Code *"
        Me.clmemp_code.Name = "clmemp_code"
        Me.clmemp_code.Width = 120
        '
        'empname
        '
        Me.empname.DataPropertyName = "short_name"
        Me.empname.HeaderText = "Employee Name*"
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        Me.empname.Width = 170
        '
        'clmlocation
        '
        Me.clmlocation.DataPropertyName = "location_id"
        Me.clmlocation.HeaderText = "Location *"
        Me.clmlocation.Name = "clmlocation"
        Me.clmlocation.ReadOnly = True
        Me.clmlocation.Visible = False
        Me.clmlocation.Width = 140
        '
        'dept
        '
        Me.dept.DataPropertyName = "department_id"
        Me.dept.HeaderText = "Department *"
        Me.dept.Name = "dept"
        Me.dept.ReadOnly = True
        Me.dept.Visible = False
        Me.dept.Width = 140
        '
        'locname
        '
        Me.locname.DataPropertyName = "location_name"
        Me.locname.HeaderText = "Location *"
        Me.locname.Name = "locname"
        Me.locname.ReadOnly = True
        Me.locname.Width = 170
        '
        'deptname
        '
        Me.deptname.DataPropertyName = "department_name"
        Me.deptname.HeaderText = "department *"
        Me.deptname.Name = "deptname"
        Me.deptname.ReadOnly = True
        Me.deptname.Width = 170
        '
        'frm_training_enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 488)
        Me.Controls.Add(Me.pnl_enroll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_training_enrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training Enrollment"
        Me.pnl_enroll.ResumeLayout(False)
        Me.pnl_enroll.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.grpempdetail.ResumeLayout(False)
        CType(Me.grid_emp_enrolldetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_enroll As System.Windows.Forms.Panel
    Friend WithEvents txtduration As DefaultControls.MaskedBox
    Friend WithEvents lblduration As System.Windows.Forms.Label
    Friend WithEvents cmbtrainer As DefaultControls.ComboBox
    Friend WithEvents lbltrainer As System.Windows.Forms.Label
    Friend WithEvents lbltodate As System.Windows.Forms.Label
    Friend WithEvents lblfromdate As System.Windows.Forms.Label
    Friend WithEvents cmbvenue As DefaultControls.ComboBox
    Friend WithEvents lblvenue As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents dttodate As DefaultControls.DateTimePicker
    Friend WithEvents dtfromdate As DefaultControls.DateTimePicker
    Friend WithEvents lbltotalemp As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpempdetail As DefaultControls.GroupBox
    Friend WithEvents grid_emp_enrolldetail As DefaultControls.DataGridView
    Friend WithEvents enrollmentid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmemp_code As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents empname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmlocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents locname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deptname As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
