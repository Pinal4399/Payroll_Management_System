<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recruitment_approval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recruitment_approval))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.lbldeptnm = New System.Windows.Forms.Label
        Me.lbllocnm = New System.Windows.Forms.Label
        Me.btnfind = New System.Windows.Forms.Button
        Me.cmblocname = New DefaultControls.ComboBox
        Me.cmbdeptname = New DefaultControls.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grid_recruitment_approval = New DefaultControls.DataGridView
        Me.recruitid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.totvacancy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fulfilldate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.job = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.position = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.open = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.approvedby = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.grid_recruitment_approval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(672, 281)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&Close"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(580, 281)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Cl&ear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(488, 281)
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
        Me.lbldeptnm.Location = New System.Drawing.Point(345, 34)
        Me.lbldeptnm.Name = "lbldeptnm"
        Me.lbldeptnm.Size = New System.Drawing.Size(72, 13)
        Me.lbldeptnm.TabIndex = 17
        Me.lbldeptnm.Text = "Department :*"
        '
        'lbllocnm
        '
        Me.lbllocnm.AutoSize = True
        Me.lbllocnm.Location = New System.Drawing.Point(14, 34)
        Me.lbllocnm.Name = "lbllocnm"
        Me.lbllocnm.Size = New System.Drawing.Size(58, 13)
        Me.lbllocnm.TabIndex = 16
        Me.lbllocnm.Text = "Location :*"
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(672, 29)
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
        Me.cmblocname.Location = New System.Drawing.Point(80, 31)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(228, 21)
        Me.cmblocname.TabIndex = 0
        '
        'cmbdeptname
        '
        Me.cmbdeptname.AutoDropDown = False
        Me.cmbdeptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(432, 31)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(223, 21)
        Me.cmbdeptname.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_recruitment_approval)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 217)
        Me.Panel1.TabIndex = 18
        '
        'grid_recruitment_approval
        '
        Me.grid_recruitment_approval.AllowUserToAddRows = False
        Me.grid_recruitment_approval.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_recruitment_approval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_recruitment_approval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_recruitment_approval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.recruitid, Me.desc, Me.totvacancy, Me.fulfilldate, Me.job, Me.position, Me.open, Me.approvedby})
        Me.grid_recruitment_approval.Location = New System.Drawing.Point(0, 14)
        Me.grid_recruitment_approval.Name = "grid_recruitment_approval"
        Me.grid_recruitment_approval.Size = New System.Drawing.Size(784, 189)
        Me.grid_recruitment_approval.TabIndex = 21
        '
        'recruitid
        '
        Me.recruitid.DataPropertyName = "recruitment_id"
        Me.recruitid.HeaderText = "Recruitment Id"
        Me.recruitid.Name = "recruitid"
        Me.recruitid.Visible = False
        '
        'desc
        '
        Me.desc.DataPropertyName = "description"
        Me.desc.HeaderText = "Description"
        Me.desc.Name = "desc"
        '
        'totvacancy
        '
        Me.totvacancy.DataPropertyName = "total_vacancies"
        Me.totvacancy.HeaderText = "Total Vacancies *"
        Me.totvacancy.Name = "totvacancy"
        '
        'fulfilldate
        '
        Me.fulfilldate.DataPropertyName = "fulfill_date"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.fulfilldate.DefaultCellStyle = DataGridViewCellStyle2
        Me.fulfilldate.HeaderText = "FulFill Date"
        Me.fulfilldate.Name = "fulfilldate"
        '
        'job
        '
        Me.job.DataPropertyName = "job"
        Me.job.HeaderText = "Job *"
        Me.job.Name = "job"
        Me.job.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.job.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'position
        '
        Me.position.DataPropertyName = "rec_position"
        Me.position.HeaderText = "Position *"
        Me.position.Name = "position"
        Me.position.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'open
        '
        Me.open.DataPropertyName = "status"
        Me.open.HeaderText = "Open? *"
        Me.open.Name = "open"
        Me.open.ReadOnly = True
        '
        'approvedby
        '
        Me.approvedby.DataPropertyName = "approveemployee_code"
        Me.approvedby.HeaderText = "Approved By"
        Me.approvedby.Name = "approvedby"
        Me.approvedby.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.approvedby.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.approvedby.Width = 140
        '
        'frm_recruitment_approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 324)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmblocname)
        Me.Controls.Add(Me.cmbdeptname)
        Me.Controls.Add(Me.lbldeptnm)
        Me.Controls.Add(Me.lbllocnm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_recruitment_approval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recruitment Approval"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_recruitment_approval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents lbldeptnm As System.Windows.Forms.Label
    Friend WithEvents lbllocnm As System.Windows.Forms.Label

    Private Sub cmbdeptname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents cmbdeptname As DefaultControls.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_recruitment_approval As DefaultControls.DataGridView
    Friend WithEvents recruitid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totvacancy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fulfilldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents job As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents open As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents approvedby As System.Windows.Forms.DataGridViewComboBoxColumn

   

   
End Class
