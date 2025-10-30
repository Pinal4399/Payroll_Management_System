<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_suggestion_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_suggestion_register))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnfind = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.cmblocname = New DefaultControls.ComboBox
        Me.cmbdeptname = New DefaultControls.ComboBox
        Me.lbldeptnm = New System.Windows.Forms.Label
        Me.lbllocnm = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grid_suggestion_register = New DefaultControls.DataGridView
        Me.suggestionid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnsuggestion = New System.Windows.Forms.DataGridViewButtonColumn
        Me.clmsuggestion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.submittedby = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.submissiondate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.grid_suggestion_register, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(563, 17)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(75, 23)
        Me.btnfind.TabIndex = 2
        Me.btnfind.Text = "&Find"
        Me.btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(490, 293)
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
        Me.btncancel.Location = New System.Drawing.Point(582, 293)
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
        Me.btnsave.Location = New System.Drawing.Point(398, 293)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'cmblocname
        '
        Me.cmblocname.AutoDropDown = False
        Me.cmblocname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocname.FormattingEnabled = True
        Me.cmblocname.Location = New System.Drawing.Point(77, 19)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(180, 21)
        Me.cmblocname.TabIndex = 0
        '
        'cmbdeptname
        '
        Me.cmbdeptname.AutoDropDown = False
        Me.cmbdeptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(375, 19)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(173, 21)
        Me.cmbdeptname.TabIndex = 1
        '
        'lbldeptnm
        '
        Me.lbldeptnm.AutoSize = True
        Me.lbldeptnm.Location = New System.Drawing.Point(295, 22)
        Me.lbldeptnm.Name = "lbldeptnm"
        Me.lbldeptnm.Size = New System.Drawing.Size(72, 13)
        Me.lbldeptnm.TabIndex = 27
        Me.lbldeptnm.Text = "Department :*"
        '
        'lbllocnm
        '
        Me.lbllocnm.AutoSize = True
        Me.lbllocnm.Location = New System.Drawing.Point(14, 22)
        Me.lbllocnm.Name = "lbllocnm"
        Me.lbllocnm.Size = New System.Drawing.Size(58, 13)
        Me.lbllocnm.TabIndex = 26
        Me.lbllocnm.Text = "Location :*"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_suggestion_register)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 228)
        Me.Panel1.TabIndex = 28
        '
        'grid_suggestion_register
        '
        Me.grid_suggestion_register.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_suggestion_register.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_suggestion_register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_suggestion_register.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.suggestionid, Me.btnsuggestion, Me.clmsuggestion, Me.submittedby, Me.submissiondate})
        Me.grid_suggestion_register.Location = New System.Drawing.Point(2, 9)
        Me.grid_suggestion_register.Name = "grid_suggestion_register"
        Me.grid_suggestion_register.Size = New System.Drawing.Size(640, 211)
        Me.grid_suggestion_register.TabIndex = 35
        '
        'suggestionid
        '
        Me.suggestionid.DataPropertyName = "suggestion_id"
        Me.suggestionid.HeaderText = "Suggestion Id"
        Me.suggestionid.Name = "suggestionid"
        Me.suggestionid.ReadOnly = True
        Me.suggestionid.Visible = False
        '
        'btnsuggestion
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsuggestion.DefaultCellStyle = DataGridViewCellStyle2
        Me.btnsuggestion.HeaderText = "Suggestion *"
        Me.btnsuggestion.Name = "btnsuggestion"
        Me.btnsuggestion.Text = "......."
        Me.btnsuggestion.UseColumnTextForButtonValue = True
        '
        'clmsuggestion
        '
        Me.clmsuggestion.DataPropertyName = "description"
        Me.clmsuggestion.HeaderText = "Suggestion"
        Me.clmsuggestion.Name = "clmsuggestion"
        Me.clmsuggestion.ReadOnly = True
        Me.clmsuggestion.Visible = False
        '
        'submittedby
        '
        Me.submittedby.DataPropertyName = "submitted_empcode"
        Me.submittedby.HeaderText = "Submitted By *"
        Me.submittedby.Name = "submittedby"
        Me.submittedby.Width = 150
        '
        'submissiondate
        '
        Me.submissiondate.DataPropertyName = "submission_date"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.submissiondate.DefaultCellStyle = DataGridViewCellStyle3
        Me.submissiondate.HeaderText = "Submission Date *"
        Me.submissiondate.Name = "submissiondate"
        '
        'frm_suggestion_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 332)
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
        Me.Name = "frm_suggestion_register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suggestion Register"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_suggestion_register, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents cmbdeptname As DefaultControls.ComboBox
    Friend WithEvents lbldeptnm As System.Windows.Forms.Label
    Friend WithEvents lbllocnm As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_suggestion_register As DefaultControls.DataGridView
    Friend WithEvents suggestionid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnsuggestion As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents clmsuggestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents submittedby As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents submissiondate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
