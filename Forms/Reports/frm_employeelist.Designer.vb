<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_employeelist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_employeelist))
        Me.pnl_leave = New System.Windows.Forms.Panel
        Me.rdinactive = New System.Windows.Forms.RadioButton
        Me.rdactive = New System.Windows.Forms.RadioButton
        Me.cmblocation = New DefaultControls.ComboBox
        Me.lbllocation = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.chkselected = New DefaultControls.CheckBox
        Me.grid_employee = New DefaultControls.DataGridView
        Me.clmselected = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.deptid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.deptname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnl_leave.SuspendLayout()
        CType(Me.grid_employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_leave
        '
        Me.pnl_leave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_leave.Controls.Add(Me.rdinactive)
        Me.pnl_leave.Controls.Add(Me.rdactive)
        Me.pnl_leave.Controls.Add(Me.cmblocation)
        Me.pnl_leave.Controls.Add(Me.lbllocation)
        Me.pnl_leave.Controls.Add(Me.btnclose)
        Me.pnl_leave.Controls.Add(Me.btnreport)
        Me.pnl_leave.Controls.Add(Me.chkselected)
        Me.pnl_leave.Controls.Add(Me.grid_employee)
        Me.pnl_leave.Location = New System.Drawing.Point(8, 12)
        Me.pnl_leave.Name = "pnl_leave"
        Me.pnl_leave.Size = New System.Drawing.Size(357, 412)
        Me.pnl_leave.TabIndex = 3
        '
        'rdinactive
        '
        Me.rdinactive.AutoSize = True
        Me.rdinactive.Location = New System.Drawing.Point(280, 359)
        Me.rdinactive.Name = "rdinactive"
        Me.rdinactive.Size = New System.Drawing.Size(64, 17)
        Me.rdinactive.TabIndex = 4
        Me.rdinactive.TabStop = True
        Me.rdinactive.Text = "InActive"
        Me.rdinactive.UseVisualStyleBackColor = True
        '
        'rdactive
        '
        Me.rdactive.AutoSize = True
        Me.rdactive.Location = New System.Drawing.Point(223, 358)
        Me.rdactive.Name = "rdactive"
        Me.rdactive.Size = New System.Drawing.Size(55, 17)
        Me.rdactive.TabIndex = 3
        Me.rdactive.TabStop = True
        Me.rdactive.Text = "Active"
        Me.rdactive.UseVisualStyleBackColor = True
        '
        'cmblocation
        '
        Me.cmblocation.AutoDropDown = False
        Me.cmblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocation.FormattingEnabled = True
        Me.cmblocation.Location = New System.Drawing.Point(77, 7)
        Me.cmblocation.Name = "cmblocation"
        Me.cmblocation.Size = New System.Drawing.Size(177, 21)
        Me.cmblocation.TabIndex = 0
        '
        'lbllocation
        '
        Me.lbllocation.AutoSize = True
        Me.lbllocation.Location = New System.Drawing.Point(13, 12)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(58, 13)
        Me.lbllocation.TabIndex = 9
        Me.lbllocation.Text = "Location :*"
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(270, 381)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreport.Location = New System.Drawing.Point(179, 382)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 5
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'chkselected
        '
        Me.chkselected.AutoSize = True
        Me.chkselected.Location = New System.Drawing.Point(12, 358)
        Me.chkselected.Name = "chkselected"
        Me.chkselected.Size = New System.Drawing.Size(82, 17)
        Me.chkselected.TabIndex = 2
        Me.chkselected.Text = "Selected All"
        Me.chkselected.UseVisualStyleBackColor = True
        '
        'grid_employee
        '
        Me.grid_employee.AllowUserToAddRows = False
        Me.grid_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmselected, Me.deptid, Me.deptname})
        Me.grid_employee.Location = New System.Drawing.Point(9, 35)
        Me.grid_employee.Name = "grid_employee"
        Me.grid_employee.Size = New System.Drawing.Size(336, 313)
        Me.grid_employee.TabIndex = 1
        '
        'clmselected
        '
        Me.clmselected.DataPropertyName = "id"
        Me.clmselected.FalseValue = "0"
        Me.clmselected.HeaderText = "Selected"
        Me.clmselected.Name = "clmselected"
        Me.clmselected.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmselected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmselected.TrueValue = "1"
        Me.clmselected.Width = 70
        '
        'deptid
        '
        Me.deptid.DataPropertyName = "department_id"
        Me.deptid.HeaderText = "Department Id"
        Me.deptid.Name = "deptid"
        Me.deptid.ReadOnly = True
        Me.deptid.Visible = False
        '
        'deptname
        '
        Me.deptname.DataPropertyName = "department_name"
        Me.deptname.HeaderText = "Department"
        Me.deptname.Name = "deptname"
        Me.deptname.ReadOnly = True
        Me.deptname.Width = 200
        '
        'frm_employeelist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 436)
        Me.Controls.Add(Me.pnl_leave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_employeelist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Of Employees"
        Me.pnl_leave.ResumeLayout(False)
        Me.pnl_leave.PerformLayout()
        CType(Me.grid_employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_leave As System.Windows.Forms.Panel
    Friend WithEvents cmblocation As DefaultControls.ComboBox
    Friend WithEvents lbllocation As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents chkselected As DefaultControls.CheckBox
    Friend WithEvents grid_employee As DefaultControls.DataGridView
    Friend WithEvents clmselected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deptid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deptname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rdinactive As System.Windows.Forms.RadioButton
    Friend WithEvents rdactive As System.Windows.Forms.RadioButton
End Class
