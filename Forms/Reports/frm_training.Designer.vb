<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_training
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_training))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbenddate = New DefaultControls.ComboBox
        Me.cmbstartdate = New DefaultControls.ComboBox
        Me.lbltodate = New System.Windows.Forms.Label
        Me.lblfromdate = New System.Windows.Forms.Label
        Me.cmbvenue = New DefaultControls.ComboBox
        Me.lblvenue = New System.Windows.Forms.Label
        Me.cmbtrainer = New DefaultControls.ComboBox
        Me.lbltrainer = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbenddate)
        Me.Panel1.Controls.Add(Me.cmbstartdate)
        Me.Panel1.Controls.Add(Me.lbltodate)
        Me.Panel1.Controls.Add(Me.lblfromdate)
        Me.Panel1.Controls.Add(Me.cmbvenue)
        Me.Panel1.Controls.Add(Me.lblvenue)
        Me.Panel1.Controls.Add(Me.cmbtrainer)
        Me.Panel1.Controls.Add(Me.lbltrainer)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 145)
        Me.Panel1.TabIndex = 0
        '
        'cmbenddate
        '
        Me.cmbenddate.AutoDropDown = False
        Me.cmbenddate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbenddate.FormattingEnabled = True
        Me.cmbenddate.Location = New System.Drawing.Point(112, 105)
        Me.cmbenddate.Name = "cmbenddate"
        Me.cmbenddate.Size = New System.Drawing.Size(190, 21)
        Me.cmbenddate.TabIndex = 3
        '
        'cmbstartdate
        '
        Me.cmbstartdate.AutoDropDown = False
        Me.cmbstartdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstartdate.FormattingEnabled = True
        Me.cmbstartdate.Location = New System.Drawing.Point(112, 75)
        Me.cmbstartdate.Name = "cmbstartdate"
        Me.cmbstartdate.Size = New System.Drawing.Size(190, 21)
        Me.cmbstartdate.TabIndex = 2
        '
        'lbltodate
        '
        Me.lbltodate.AutoSize = True
        Me.lbltodate.Location = New System.Drawing.Point(8, 113)
        Me.lbltodate.Name = "lbltodate"
        Me.lbltodate.Size = New System.Drawing.Size(62, 13)
        Me.lbltodate.TabIndex = 90
        Me.lbltodate.Text = "End Date :*"
        '
        'lblfromdate
        '
        Me.lblfromdate.AutoSize = True
        Me.lblfromdate.Location = New System.Drawing.Point(7, 78)
        Me.lblfromdate.Name = "lblfromdate"
        Me.lblfromdate.Size = New System.Drawing.Size(68, 13)
        Me.lblfromdate.TabIndex = 88
        Me.lblfromdate.Text = "Start  Date :*"
        '
        'cmbvenue
        '
        Me.cmbvenue.AutoDropDown = False
        Me.cmbvenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvenue.FormattingEnabled = True
        Me.cmbvenue.Location = New System.Drawing.Point(111, 42)
        Me.cmbvenue.Name = "cmbvenue"
        Me.cmbvenue.Size = New System.Drawing.Size(190, 21)
        Me.cmbvenue.TabIndex = 1
        '
        'lblvenue
        '
        Me.lblvenue.AutoSize = True
        Me.lblvenue.Location = New System.Drawing.Point(7, 46)
        Me.lblvenue.Name = "lblvenue"
        Me.lblvenue.Size = New System.Drawing.Size(48, 13)
        Me.lblvenue.TabIndex = 84
        Me.lblvenue.Text = "Venue :*"
        '
        'cmbtrainer
        '
        Me.cmbtrainer.AutoDropDown = False
        Me.cmbtrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtrainer.FormattingEnabled = True
        Me.cmbtrainer.Location = New System.Drawing.Point(111, 8)
        Me.cmbtrainer.Name = "cmbtrainer"
        Me.cmbtrainer.Size = New System.Drawing.Size(190, 21)
        Me.cmbtrainer.TabIndex = 0
        '
        'lbltrainer
        '
        Me.lbltrainer.AutoSize = True
        Me.lbltrainer.Location = New System.Drawing.Point(7, 11)
        Me.lbltrainer.Name = "lbltrainer"
        Me.lbltrainer.Size = New System.Drawing.Size(50, 13)
        Me.lbltrainer.TabIndex = 81
        Me.lbltrainer.Text = "Trainer :*"
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(254, 167)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreport.Location = New System.Drawing.Point(163, 168)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 4
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'frm_training
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 201)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_training"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbvenue As DefaultControls.ComboBox
    Friend WithEvents lblvenue As System.Windows.Forms.Label
    Friend WithEvents cmbtrainer As DefaultControls.ComboBox
    Friend WithEvents lbltrainer As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents lbltodate As System.Windows.Forms.Label
    Friend WithEvents lblfromdate As System.Windows.Forms.Label
    Friend WithEvents cmbstartdate As DefaultControls.ComboBox
    Friend WithEvents cmbenddate As DefaultControls.ComboBox
End Class
