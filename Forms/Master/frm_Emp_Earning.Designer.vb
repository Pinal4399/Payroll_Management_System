<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Emp_Earning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Emp_Earning))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnl_emp_earning = New System.Windows.Forms.Panel
        Me.txtemployeecode = New DefaultControls.MaskedBox(Me.components)
        Me.txtemployeename = New DefaultControls.MaskedBox(Me.components)
        Me.txtlocname = New DefaultControls.MaskedBox(Me.components)
        Me.locname = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ercode = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grid_emp_earning = New DefaultControls.DataGridView
        Me.pnl_emp_earning.SuspendLayout()
        CType(Me.grid_emp_earning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_emp_earning
        '
        Me.pnl_emp_earning.Controls.Add(Me.grid_emp_earning)
        Me.pnl_emp_earning.Controls.Add(Me.txtemployeecode)
        Me.pnl_emp_earning.Controls.Add(Me.txtemployeename)
        Me.pnl_emp_earning.Controls.Add(Me.txtlocname)
        Me.pnl_emp_earning.Controls.Add(Me.locname)
        Me.pnl_emp_earning.Controls.Add(Me.Label2)
        Me.pnl_emp_earning.Controls.Add(Me.btncancel)
        Me.pnl_emp_earning.Controls.Add(Me.btnsave)
        Me.pnl_emp_earning.Location = New System.Drawing.Point(12, 12)
        Me.pnl_emp_earning.Name = "pnl_emp_earning"
        Me.pnl_emp_earning.Size = New System.Drawing.Size(715, 373)
        Me.pnl_emp_earning.TabIndex = 3
        '
        'txtemployeecode
        '
        Me.txtemployeecode.CheckBounds = False
        Me.txtemployeecode.DateFormat = Nothing
        Me.txtemployeecode.DecimalPlaces = CType(0, Byte)
        Me.txtemployeecode.Enabled = False
        Me.txtemployeecode.Location = New System.Drawing.Point(125, 51)
        Me.txtemployeecode.MaxDate = New Date(CType(0, Long))
        Me.txtemployeecode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemployeecode.MinDate = New Date(CType(0, Long))
        Me.txtemployeecode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemployeecode.Name = "txtemployeecode"
        Me.txtemployeecode.Size = New System.Drawing.Size(133, 20)
        Me.txtemployeecode.TabIndex = 24
        Me.txtemployeecode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtemployeename
        '
        Me.txtemployeename.CheckBounds = False
        Me.txtemployeename.DateFormat = Nothing
        Me.txtemployeename.DecimalPlaces = CType(0, Byte)
        Me.txtemployeename.Enabled = False
        Me.txtemployeename.Location = New System.Drawing.Point(273, 48)
        Me.txtemployeename.MaxDate = New Date(CType(0, Long))
        Me.txtemployeename.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemployeename.MinDate = New Date(CType(0, Long))
        Me.txtemployeename.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemployeename.Name = "txtemployeename"
        Me.txtemployeename.Size = New System.Drawing.Size(344, 20)
        Me.txtemployeename.TabIndex = 23
        Me.txtemployeename.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtlocname
        '
        Me.txtlocname.CheckBounds = False
        Me.txtlocname.DateFormat = Nothing
        Me.txtlocname.DecimalPlaces = CType(0, Byte)
        Me.txtlocname.Enabled = False
        Me.txtlocname.Location = New System.Drawing.Point(125, 14)
        Me.txtlocname.MaxDate = New Date(CType(0, Long))
        Me.txtlocname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlocname.MinDate = New Date(CType(0, Long))
        Me.txtlocname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlocname.Name = "txtlocname"
        Me.txtlocname.Size = New System.Drawing.Size(492, 20)
        Me.txtlocname.TabIndex = 22
        Me.txtlocname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'locname
        '
        Me.locname.AutoSize = True
        Me.locname.Location = New System.Drawing.Point(26, 17)
        Me.locname.Name = "locname"
        Me.locname.Size = New System.Drawing.Size(85, 13)
        Me.locname.TabIndex = 20
        Me.locname.Text = "Location Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Employee  Code : "
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(605, 333)
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
        Me.btnsave.Location = New System.Drawing.Point(500, 333)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'rate
        '
        Me.rate.DataPropertyName = "cheque_salary"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.rate.DefaultCellStyle = DataGridViewCellStyle2
        Me.rate.HeaderText = "Rate *"
        Me.rate.Name = "rate"
        Me.rate.Width = 140
        '
        'desc
        '
        Me.desc.DataPropertyName = "description"
        Me.desc.HeaderText = "Description"
        Me.desc.Name = "desc"
        Me.desc.Width = 240
        '
        'ercode
        '
        Me.ercode.DataPropertyName = "earning_code"
        Me.ercode.HeaderText = "Earning Code *"
        Me.ercode.Items.AddRange(New Object() {"BCQ", "BCW"})
        Me.ercode.Name = "ercode"
        Me.ercode.Width = 120
        '
        'srno
        '
        Me.srno.DataPropertyName = "serial_no"
        Me.srno.HeaderText = "serial no"
        Me.srno.Name = "srno"
        Me.srno.ReadOnly = True
        Me.srno.Visible = False
        '
        'grid_emp_earning
        '
        Me.grid_emp_earning.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_emp_earning.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_emp_earning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_emp_earning.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.ercode, Me.desc, Me.rate})
        Me.grid_emp_earning.Location = New System.Drawing.Point(29, 91)
        Me.grid_emp_earning.Name = "grid_emp_earning"
        Me.grid_emp_earning.Size = New System.Drawing.Size(662, 226)
        Me.grid_emp_earning.TabIndex = 25
        '
        'frm_Emp_Earning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 397)
        Me.Controls.Add(Me.pnl_emp_earning)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Emp_Earning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Earning"
        Me.pnl_emp_earning.ResumeLayout(False)
        Me.pnl_emp_earning.PerformLayout()
        CType(Me.grid_emp_earning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_emp_earning As System.Windows.Forms.Panel
    Friend WithEvents txtemployeecode As DefaultControls.MaskedBox
    Friend WithEvents txtemployeename As DefaultControls.MaskedBox
    Friend WithEvents txtlocname As DefaultControls.MaskedBox
    Friend WithEvents locname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents grid_emp_earning As DefaultControls.DataGridView
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ercode As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
