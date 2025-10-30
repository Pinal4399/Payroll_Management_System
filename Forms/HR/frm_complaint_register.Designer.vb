<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_complaint_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_complaint_register))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.lbldeptnm = New System.Windows.Forms.Label
        Me.lbllocnm = New System.Windows.Forms.Label
        Me.btnfind = New System.Windows.Forms.Button
        Me.cmblocname = New DefaultControls.ComboBox
        Me.cmbdeptname = New DefaultControls.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grid_complaint_register = New DefaultControls.DataGridView
        Me.compid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btncomplaint = New System.Windows.Forms.DataGridViewButtonColumn
        Me.clmcomplaint = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.submittedby = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.submisiondate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.grid_complaint_register, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(500, 292)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Cl&ear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(592, 292)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&Close"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(408, 292)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lbldeptnm
        '
        Me.lbldeptnm.AutoSize = True
        Me.lbldeptnm.Location = New System.Drawing.Point(310, 21)
        Me.lbldeptnm.Name = "lbldeptnm"
        Me.lbldeptnm.Size = New System.Drawing.Size(72, 13)
        Me.lbldeptnm.TabIndex = 17
        Me.lbldeptnm.Text = "Department :*"
        '
        'lbllocnm
        '
        Me.lbllocnm.AutoSize = True
        Me.lbllocnm.Location = New System.Drawing.Point(21, 21)
        Me.lbllocnm.Name = "lbllocnm"
        Me.lbllocnm.Size = New System.Drawing.Size(58, 13)
        Me.lbllocnm.TabIndex = 16
        Me.lbllocnm.Text = "Location :*"
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(578, 16)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(75, 23)
        Me.btnfind.TabIndex = 2
        Me.btnfind.Text = "&Find"
        Me.btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'cmblocname
        '
        Me.cmblocname.AutoDropDown = False
        Me.cmblocname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocname.FormattingEnabled = True
        Me.cmblocname.Location = New System.Drawing.Point(87, 18)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(180, 21)
        Me.cmblocname.TabIndex = 0
        '
        'cmbdeptname
        '
        Me.cmbdeptname.AutoDropDown = False
        Me.cmbdeptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(390, 18)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(173, 21)
        Me.cmbdeptname.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_complaint_register)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 228)
        Me.Panel1.TabIndex = 18
        '
        'grid_complaint_register
        '
        Me.grid_complaint_register.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_complaint_register.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_complaint_register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_complaint_register.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.compid, Me.btncomplaint, Me.clmcomplaint, Me.submittedby, Me.submisiondate})
        Me.grid_complaint_register.Location = New System.Drawing.Point(6, 3)
        Me.grid_complaint_register.Name = "grid_complaint_register"
        Me.grid_complaint_register.Size = New System.Drawing.Size(643, 213)
        Me.grid_complaint_register.TabIndex = 26
        '
        'compid
        '
        Me.compid.DataPropertyName = "complaint_id"
        Me.compid.HeaderText = "Complaint Id"
        Me.compid.Name = "compid"
        Me.compid.ReadOnly = True
        Me.compid.Visible = False
        '
        'btncomplaint
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomplaint.DefaultCellStyle = DataGridViewCellStyle2
        Me.btncomplaint.HeaderText = "Complaint *"
        Me.btncomplaint.Name = "btncomplaint"
        Me.btncomplaint.Text = "......."
        Me.btncomplaint.UseColumnTextForButtonValue = True
        '
        'clmcomplaint
        '
        Me.clmcomplaint.DataPropertyName = "description"
        Me.clmcomplaint.HeaderText = "Complaint"
        Me.clmcomplaint.Name = "clmcomplaint"
        Me.clmcomplaint.ReadOnly = True
        Me.clmcomplaint.Visible = False
        '
        'submittedby
        '
        Me.submittedby.DataPropertyName = "submitted_empcode"
        Me.submittedby.HeaderText = "Submitted By *"
        Me.submittedby.Name = "submittedby"
        Me.submittedby.Width = 150
        '
        'submisiondate
        '
        Me.submisiondate.DataPropertyName = "submission_date"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.submisiondate.DefaultCellStyle = DataGridViewCellStyle3
        Me.submisiondate.HeaderText = "Submision Date *"
        Me.submisiondate.Name = "submisiondate"
        '
        'frm_complaint_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 332)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmblocname)
        Me.Controls.Add(Me.cmbdeptname)
        Me.Controls.Add(Me.lbldeptnm)
        Me.Controls.Add(Me.lbllocnm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_complaint_register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complaint Register"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_complaint_register, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents cmbdeptname As DefaultControls.ComboBox
    Friend WithEvents lbldeptnm As System.Windows.Forms.Label
    Friend WithEvents lbllocnm As System.Windows.Forms.Label
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_complaint_register As DefaultControls.DataGridView
    Friend WithEvents compid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btncomplaint As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents clmcomplaint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents submittedby As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents submisiondate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
