<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recruitment_request
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recruitment_request))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lbllocnm = New System.Windows.Forms.Label
        Me.lbldeptnm = New System.Windows.Forms.Label
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnfind = New System.Windows.Forms.Button
        Me.cmblocname = New DefaultControls.ComboBox
        Me.cmbdeptname = New DefaultControls.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grid_recruitment_request = New DefaultControls.DataGridView
        Me.rec_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.totalvacancy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.raisedby = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.startdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.enddate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmjob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmposition = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.grid_recruitment_request, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbllocnm
        '
        Me.lbllocnm.AutoSize = True
        Me.lbllocnm.Location = New System.Drawing.Point(25, 26)
        Me.lbllocnm.Name = "lbllocnm"
        Me.lbllocnm.Size = New System.Drawing.Size(58, 13)
        Me.lbllocnm.TabIndex = 0
        Me.lbllocnm.Text = "Location :*"
        '
        'lbldeptnm
        '
        Me.lbldeptnm.AutoSize = True
        Me.lbldeptnm.Location = New System.Drawing.Point(344, 26)
        Me.lbldeptnm.Name = "lbldeptnm"
        Me.lbldeptnm.Size = New System.Drawing.Size(72, 13)
        Me.lbldeptnm.TabIndex = 1
        Me.lbldeptnm.Text = "Department :*"
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(673, 343)
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
        Me.btncancel.Location = New System.Drawing.Point(765, 343)
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
        Me.btnsave.Location = New System.Drawing.Point(581, 343)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(689, 21)
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
        Me.cmblocname.Location = New System.Drawing.Point(91, 23)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(232, 21)
        Me.cmblocname.TabIndex = 0
        '
        'cmbdeptname
        '
        Me.cmbdeptname.AutoDropDown = False
        Me.cmbdeptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(424, 23)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(231, 21)
        Me.cmbdeptname.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_recruitment_request)
        Me.Panel1.Location = New System.Drawing.Point(28, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 268)
        Me.Panel1.TabIndex = 6
        '
        'grid_recruitment_request
        '
        Me.grid_recruitment_request.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_recruitment_request.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_recruitment_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_recruitment_request.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rec_id, Me.desc, Me.totalvacancy, Me.raisedby, Me.startdate, Me.enddate, Me.clmjob, Me.clmposition})
        Me.grid_recruitment_request.Location = New System.Drawing.Point(6, 10)
        Me.grid_recruitment_request.Name = "grid_recruitment_request"
        Me.grid_recruitment_request.Size = New System.Drawing.Size(824, 249)
        Me.grid_recruitment_request.TabIndex = 17
        '
        'rec_id
        '
        Me.rec_id.DataPropertyName = "recruitment_id"
        Me.rec_id.HeaderText = "Recruitment Id"
        Me.rec_id.Name = "rec_id"
        Me.rec_id.ReadOnly = True
        Me.rec_id.Visible = False
        '
        'desc
        '
        Me.desc.DataPropertyName = "description"
        Me.desc.HeaderText = "Description"
        Me.desc.Name = "desc"
        '
        'totalvacancy
        '
        Me.totalvacancy.DataPropertyName = "total_vacancies"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.totalvacancy.DefaultCellStyle = DataGridViewCellStyle2
        Me.totalvacancy.HeaderText = "Total Vacancies *"
        Me.totalvacancy.Name = "totalvacancy"
        '
        'raisedby
        '
        Me.raisedby.DataPropertyName = "raisedemployee_code"
        Me.raisedby.HeaderText = "Raised By *"
        Me.raisedby.Name = "raisedby"
        Me.raisedby.Width = 150
        '
        'startdate
        '
        Me.startdate.DataPropertyName = "start_date"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.startdate.DefaultCellStyle = DataGridViewCellStyle3
        Me.startdate.HeaderText = "Recruitment Start Date *"
        Me.startdate.Name = "startdate"
        '
        'enddate
        '
        Me.enddate.DataPropertyName = "end_date"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.enddate.DefaultCellStyle = DataGridViewCellStyle4
        Me.enddate.HeaderText = "Recruitment End Date *"
        Me.enddate.Name = "enddate"
        '
        'clmjob
        '
        Me.clmjob.DataPropertyName = "job"
        Me.clmjob.HeaderText = "Job *"
        Me.clmjob.Name = "clmjob"
        '
        'clmposition
        '
        Me.clmposition.DataPropertyName = "rec_position"
        Me.clmposition.HeaderText = "Position *"
        Me.clmposition.Items.AddRange(New Object() {"Administrator", "Senior", "junior", "Management"})
        Me.clmposition.Name = "clmposition"
        '
        'frm_recruitment_request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 389)
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
        Me.Name = "frm_recruitment_request"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recruitment Request"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_recruitment_request, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbllocnm As System.Windows.Forms.Label
    Friend WithEvents lbldeptnm As System.Windows.Forms.Label
    Friend WithEvents cmbdeptname As DefaultControls.ComboBox
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_recruitment_request As DefaultControls.DataGridView
    Friend WithEvents rec_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalvacancy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents raisedby As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents startdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents enddate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmjob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmposition As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
