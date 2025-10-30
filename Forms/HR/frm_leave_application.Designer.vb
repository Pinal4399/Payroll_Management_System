<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_leave_application
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_leave_application))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnl_leave_application = New System.Windows.Forms.Panel
        Me.txtmaxleave = New DefaultControls.MaskedBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbleavetype = New DefaultControls.ComboBox
        Me.cmbdeptname = New DefaultControls.ComboBox
        Me.cmblocname = New DefaultControls.ComboBox
        Me.btnfind = New System.Windows.Forms.Button
        Me.lblleavetype = New System.Windows.Forms.Label
        Me.lbldeptnm = New System.Windows.Forms.Label
        Me.lbllocnm = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grid_leave_application = New DefaultControls.DataGridView
        Me.empcode = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.applicationdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fromdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.todate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.noofdays = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnreason = New System.Windows.Forms.DataGridViewButtonColumn
        Me.clmreason = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.leavestatus = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.approvedby = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.pnl_leave_application.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_leave_application, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_leave_application
        '
        Me.pnl_leave_application.Controls.Add(Me.txtmaxleave)
        Me.pnl_leave_application.Controls.Add(Me.Label1)
        Me.pnl_leave_application.Controls.Add(Me.cmbleavetype)
        Me.pnl_leave_application.Controls.Add(Me.cmbdeptname)
        Me.pnl_leave_application.Controls.Add(Me.cmblocname)
        Me.pnl_leave_application.Controls.Add(Me.btnfind)
        Me.pnl_leave_application.Controls.Add(Me.lblleavetype)
        Me.pnl_leave_application.Controls.Add(Me.lbldeptnm)
        Me.pnl_leave_application.Controls.Add(Me.lbllocnm)
        Me.pnl_leave_application.Location = New System.Drawing.Point(12, 12)
        Me.pnl_leave_application.Name = "pnl_leave_application"
        Me.pnl_leave_application.Size = New System.Drawing.Size(918, 105)
        Me.pnl_leave_application.TabIndex = 0
        '
        'txtmaxleave
        '
        Me.txtmaxleave.CheckBounds = False
        Me.txtmaxleave.DateFormat = Nothing
        Me.txtmaxleave.DecimalPlaces = CType(0, Byte)
        Me.txtmaxleave.Location = New System.Drawing.Point(404, 51)
        Me.txtmaxleave.MaxDate = New Date(CType(0, Long))
        Me.txtmaxleave.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmaxleave.MinDate = New Date(CType(0, Long))
        Me.txtmaxleave.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmaxleave.Name = "txtmaxleave"
        Me.txtmaxleave.ReadOnly = True
        Me.txtmaxleave.Size = New System.Drawing.Size(151, 20)
        Me.txtmaxleave.TabIndex = 5
        Me.txtmaxleave.Text = "11"
        Me.txtmaxleave.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Max Leave :"
        '
        'cmbleavetype
        '
        Me.cmbleavetype.AutoDropDown = False
        Me.cmbleavetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbleavetype.FormattingEnabled = True
        Me.cmbleavetype.Items.AddRange(New Object() {"Casual Leave", "Sick Leave", "Paid Holidays"})
        Me.cmbleavetype.Location = New System.Drawing.Point(404, 20)
        Me.cmbleavetype.Name = "cmbleavetype"
        Me.cmbleavetype.Size = New System.Drawing.Size(151, 21)
        Me.cmbleavetype.TabIndex = 2
        '
        'cmbdeptname
        '
        Me.cmbdeptname.AutoDropDown = False
        Me.cmbdeptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(120, 51)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(151, 21)
        Me.cmbdeptname.TabIndex = 1
        '
        'cmblocname
        '
        Me.cmblocname.AutoDropDown = False
        Me.cmblocname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocname.FormattingEnabled = True
        Me.cmblocname.Location = New System.Drawing.Point(120, 20)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(151, 21)
        Me.cmblocname.TabIndex = 0
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(587, 18)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(83, 23)
        Me.btnfind.TabIndex = 3
        Me.btnfind.Text = "&Find"
        Me.btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'lblleavetype
        '
        Me.lblleavetype.AutoSize = True
        Me.lblleavetype.Location = New System.Drawing.Point(308, 23)
        Me.lblleavetype.Name = "lblleavetype"
        Me.lblleavetype.Size = New System.Drawing.Size(74, 13)
        Me.lblleavetype.TabIndex = 3
        Me.lblleavetype.Text = "Leave Type :*"
        '
        'lbldeptnm
        '
        Me.lbldeptnm.AutoSize = True
        Me.lbldeptnm.Location = New System.Drawing.Point(24, 54)
        Me.lbldeptnm.Name = "lbldeptnm"
        Me.lbldeptnm.Size = New System.Drawing.Size(72, 13)
        Me.lbldeptnm.TabIndex = 1
        Me.lbldeptnm.Text = "Department :*"
        '
        'lbllocnm
        '
        Me.lbllocnm.AutoSize = True
        Me.lbllocnm.Location = New System.Drawing.Point(24, 20)
        Me.lbllocnm.Name = "lbllocnm"
        Me.lbllocnm.Size = New System.Drawing.Size(58, 13)
        Me.lbllocnm.TabIndex = 0
        Me.lbllocnm.Text = "Location :*"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(648, 350)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(738, 350)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 5
        Me.btnclear.Text = "Cl&ear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(828, 350)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "&Close"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_leave_application)
        Me.Panel1.Location = New System.Drawing.Point(12, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 212)
        Me.Panel1.TabIndex = 7
        '
        'grid_leave_application
        '
        Me.grid_leave_application.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_leave_application.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_leave_application.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_leave_application.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empcode, Me.empname, Me.applicationdate, Me.fromdate, Me.todate, Me.noofdays, Me.btnreason, Me.clmreason, Me.leavestatus, Me.approvedby})
        Me.grid_leave_application.Location = New System.Drawing.Point(4, 8)
        Me.grid_leave_application.Name = "grid_leave_application"
        Me.grid_leave_application.ReadOnly = True
        Me.grid_leave_application.Size = New System.Drawing.Size(918, 197)
        Me.grid_leave_application.TabIndex = 15
        '
        'empcode
        '
        Me.empcode.DataPropertyName = "employee_code"
        Me.empcode.HeaderText = "Employee Code *"
        Me.empcode.Name = "empcode"
        Me.empcode.ReadOnly = True
        '
        'empname
        '
        Me.empname.DataPropertyName = "short_name"
        Me.empname.HeaderText = "Employee Name"
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        Me.empname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.empname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'applicationdate
        '
        Me.applicationdate.DataPropertyName = "application_date"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.applicationdate.DefaultCellStyle = DataGridViewCellStyle2
        Me.applicationdate.HeaderText = "Application Date *"
        Me.applicationdate.Name = "applicationdate"
        Me.applicationdate.ReadOnly = True
        '
        'fromdate
        '
        Me.fromdate.DataPropertyName = "from_date"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.fromdate.DefaultCellStyle = DataGridViewCellStyle3
        Me.fromdate.HeaderText = "From Date *"
        Me.fromdate.Name = "fromdate"
        Me.fromdate.ReadOnly = True
        '
        'todate
        '
        Me.todate.DataPropertyName = "to_date"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.todate.DefaultCellStyle = DataGridViewCellStyle4
        Me.todate.HeaderText = "To Date *"
        Me.todate.Name = "todate"
        Me.todate.ReadOnly = True
        '
        'noofdays
        '
        Me.noofdays.DataPropertyName = "no_of_days"
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.noofdays.DefaultCellStyle = DataGridViewCellStyle5
        Me.noofdays.HeaderText = "No of Days"
        Me.noofdays.Name = "noofdays"
        Me.noofdays.ReadOnly = True
        Me.noofdays.Width = 65
        '
        'btnreason
        '
        Me.btnreason.HeaderText = "Reason *"
        Me.btnreason.Name = "btnreason"
        Me.btnreason.ReadOnly = True
        Me.btnreason.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnreason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnreason.Text = "........."
        Me.btnreason.UseColumnTextForButtonValue = True
        '
        'clmreason
        '
        Me.clmreason.DataPropertyName = "reason"
        Me.clmreason.HeaderText = "Reason"
        Me.clmreason.Name = "clmreason"
        Me.clmreason.ReadOnly = True
        Me.clmreason.Visible = False
        '
        'leavestatus
        '
        Me.leavestatus.DataPropertyName = "leave_status"
        Me.leavestatus.HeaderText = "Leave Status *"
        Me.leavestatus.Items.AddRange(New Object() {"Approved", "Non-Approved"})
        Me.leavestatus.Name = "leavestatus"
        Me.leavestatus.ReadOnly = True
        Me.leavestatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.leavestatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.leavestatus.Width = 110
        '
        'approvedby
        '
        Me.approvedby.DataPropertyName = "approved_by"
        Me.approvedby.HeaderText = "Approved By"
        Me.approvedby.Name = "approvedby"
        Me.approvedby.ReadOnly = True
        Me.approvedby.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.approvedby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frm_leave_application
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 400)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.pnl_leave_application)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_leave_application"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave Application"
        Me.pnl_leave_application.ResumeLayout(False)
        Me.pnl_leave_application.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_leave_application, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_leave_application As System.Windows.Forms.Panel
    Friend WithEvents lblleavetype As System.Windows.Forms.Label
    Friend WithEvents lbldeptnm As System.Windows.Forms.Label
    Friend WithEvents lbllocnm As System.Windows.Forms.Label
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents cmbdeptname As DefaultControls.ComboBox
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents cmbleavetype As DefaultControls.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmaxleave As DefaultControls.MaskedBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_leave_application As DefaultControls.DataGridView
    Friend WithEvents empcode As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents empname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents applicationdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fromdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents todate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noofdays As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnreason As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents clmreason As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents leavestatus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents approvedby As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
