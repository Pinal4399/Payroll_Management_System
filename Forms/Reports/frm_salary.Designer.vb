<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_salary))
        Me.pnl_leave = New System.Windows.Forms.Panel
        Me.cmblocation = New DefaultControls.ComboBox
        Me.lbllocation = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.chkselected = New DefaultControls.CheckBox
        Me.grid_salary = New DefaultControls.DataGridView
        Me.clmselected = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.deptid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.deptname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnl_leave.SuspendLayout()
        CType(Me.grid_salary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_leave
        '
        Me.pnl_leave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_leave.Controls.Add(Me.cmblocation)
        Me.pnl_leave.Controls.Add(Me.lbllocation)
        Me.pnl_leave.Controls.Add(Me.btnclose)
        Me.pnl_leave.Controls.Add(Me.btnreport)
        Me.pnl_leave.Controls.Add(Me.chkselected)
        Me.pnl_leave.Controls.Add(Me.grid_salary)
        Me.pnl_leave.Location = New System.Drawing.Point(12, 12)
        Me.pnl_leave.Name = "pnl_leave"
        Me.pnl_leave.Size = New System.Drawing.Size(357, 383)
        Me.pnl_leave.TabIndex = 3
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
        Me.btnclose.Location = New System.Drawing.Point(270, 354)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreport.Location = New System.Drawing.Point(179, 355)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 3
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
        'grid_salary
        '
        Me.grid_salary.AllowUserToAddRows = False
        Me.grid_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_salary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmselected, Me.deptid, Me.deptname})
        Me.grid_salary.Location = New System.Drawing.Point(9, 35)
        Me.grid_salary.Name = "grid_salary"
        Me.grid_salary.Size = New System.Drawing.Size(336, 313)
        Me.grid_salary.TabIndex = 1
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
        'frm_salary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 403)
        Me.Controls.Add(Me.pnl_leave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_salary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary Report"
        Me.pnl_leave.ResumeLayout(False)
        Me.pnl_leave.PerformLayout()
        CType(Me.grid_salary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_leave As System.Windows.Forms.Panel
    Friend WithEvents cmblocation As DefaultControls.ComboBox
    Friend WithEvents lbllocation As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents chkselected As DefaultControls.CheckBox
    Friend WithEvents grid_salary As DefaultControls.DataGridView
    Friend WithEvents clmselected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents deptid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deptname As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
