<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Emp_Qualification
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Emp_Qualification))
        Me.pnl_emp_qualification = New System.Windows.Forms.Panel
        Me.grid_emp_qualification_detail = New DefaultControls.DataGridView
        Me.serial_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.qualification = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.uni_college = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.year = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grade_percent = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtemployeecode = New DefaultControls.MaskedBox(Me.components)
        Me.txtemployeename = New DefaultControls.MaskedBox(Me.components)
        Me.txtlocname = New DefaultControls.MaskedBox(Me.components)
        Me.locname = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.pnl_emp_qualification.SuspendLayout()
        CType(Me.grid_emp_qualification_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_emp_qualification
        '
        Me.pnl_emp_qualification.Controls.Add(Me.grid_emp_qualification_detail)
        Me.pnl_emp_qualification.Controls.Add(Me.txtemployeecode)
        Me.pnl_emp_qualification.Controls.Add(Me.txtemployeename)
        Me.pnl_emp_qualification.Controls.Add(Me.txtlocname)
        Me.pnl_emp_qualification.Controls.Add(Me.locname)
        Me.pnl_emp_qualification.Controls.Add(Me.Label2)
        Me.pnl_emp_qualification.Controls.Add(Me.btncancel)
        Me.pnl_emp_qualification.Controls.Add(Me.btnsave)
        Me.pnl_emp_qualification.Location = New System.Drawing.Point(17, 29)
        Me.pnl_emp_qualification.Name = "pnl_emp_qualification"
        Me.pnl_emp_qualification.Size = New System.Drawing.Size(715, 334)
        Me.pnl_emp_qualification.TabIndex = 1
        '
        'grid_emp_qualification_detail
        '
        Me.grid_emp_qualification_detail.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_emp_qualification_detail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_emp_qualification_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_emp_qualification_detail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serial_no, Me.qualification, Me.uni_college, Me.year, Me.grade_percent})
        Me.grid_emp_qualification_detail.Location = New System.Drawing.Point(29, 92)
        Me.grid_emp_qualification_detail.Name = "grid_emp_qualification_detail"
        Me.grid_emp_qualification_detail.Size = New System.Drawing.Size(667, 181)
        Me.grid_emp_qualification_detail.TabIndex = 28
        '
        'serial_no
        '
        Me.serial_no.DataPropertyName = "serial_no"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.serial_no.DefaultCellStyle = DataGridViewCellStyle2
        Me.serial_no.HeaderText = "Serial No"
        Me.serial_no.Name = "serial_no"
        Me.serial_no.Width = 70
        '
        'qualification
        '
        Me.qualification.DataPropertyName = "qualification"
        Me.qualification.HeaderText = "Qualification *"
        Me.qualification.Name = "qualification"
        Me.qualification.Width = 150
        '
        'uni_college
        '
        Me.uni_college.DataPropertyName = "university_college_institute"
        Me.uni_college.HeaderText = "University/College/Institute *"
        Me.uni_college.Name = "uni_college"
        Me.uni_college.Width = 170
        '
        'year
        '
        Me.year.DataPropertyName = "year_of_passing"
        Me.year.HeaderText = "Year Of Passing *"
        Me.year.Name = "year"
        '
        'grade_percent
        '
        Me.grade_percent.DataPropertyName = "grade_percent"
        Me.grade_percent.HeaderText = "Grade/Percent(%)"
        Me.grade_percent.Name = "grade_percent"
        '
        'txtemployeecode
        '
        Me.txtemployeecode.CheckBounds = False
        Me.txtemployeecode.DateFormat = Nothing
        Me.txtemployeecode.DecimalPlaces = CType(0, Byte)
        Me.txtemployeecode.Enabled = False
        Me.txtemployeecode.Location = New System.Drawing.Point(125, 53)
        Me.txtemployeecode.MaxDate = New Date(CType(0, Long))
        Me.txtemployeecode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemployeecode.MinDate = New Date(CType(0, Long))
        Me.txtemployeecode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemployeecode.Name = "txtemployeecode"
        Me.txtemployeecode.Size = New System.Drawing.Size(133, 20)
        Me.txtemployeecode.TabIndex = 27
        Me.txtemployeecode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtemployeename
        '
        Me.txtemployeename.CheckBounds = False
        Me.txtemployeename.DateFormat = Nothing
        Me.txtemployeename.DecimalPlaces = CType(0, Byte)
        Me.txtemployeename.Enabled = False
        Me.txtemployeename.Location = New System.Drawing.Point(273, 53)
        Me.txtemployeename.MaxDate = New Date(CType(0, Long))
        Me.txtemployeename.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemployeename.MinDate = New Date(CType(0, Long))
        Me.txtemployeename.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemployeename.Name = "txtemployeename"
        Me.txtemployeename.Size = New System.Drawing.Size(344, 20)
        Me.txtemployeename.TabIndex = 26
        Me.txtemployeename.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtlocname
        '
        Me.txtlocname.CheckBounds = False
        Me.txtlocname.DateFormat = Nothing
        Me.txtlocname.DecimalPlaces = CType(0, Byte)
        Me.txtlocname.Enabled = False
        Me.txtlocname.Location = New System.Drawing.Point(125, 13)
        Me.txtlocname.MaxDate = New Date(CType(0, Long))
        Me.txtlocname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlocname.MinDate = New Date(CType(0, Long))
        Me.txtlocname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlocname.Name = "txtlocname"
        Me.txtlocname.Size = New System.Drawing.Size(492, 20)
        Me.txtlocname.TabIndex = 25
        Me.txtlocname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'locname
        '
        Me.locname.AutoSize = True
        Me.locname.Location = New System.Drawing.Point(26, 20)
        Me.locname.Name = "locname"
        Me.locname.Size = New System.Drawing.Size(85, 13)
        Me.locname.TabIndex = 22
        Me.locname.Text = "Location Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Employee  Code : "
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(605, 291)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 1
        Me.btncancel.Text = "&Close"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(500, 291)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frm_Emp_Qualification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 382)
        Me.Controls.Add(Me.pnl_emp_qualification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Emp_Qualification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empoyee Qualification"
        Me.pnl_emp_qualification.ResumeLayout(False)
        Me.pnl_emp_qualification.PerformLayout()
        CType(Me.grid_emp_qualification_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_emp_qualification As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents locname As System.Windows.Forms.Label
    Friend WithEvents txtemployeecode As DefaultControls.MaskedBox
    Friend WithEvents txtemployeename As DefaultControls.MaskedBox
    Friend WithEvents txtlocname As DefaultControls.MaskedBox
    Friend WithEvents grid_emp_qualification_detail As DefaultControls.DataGridView
    Friend WithEvents serial_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qualification As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uni_college As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents year As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grade_percent As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
