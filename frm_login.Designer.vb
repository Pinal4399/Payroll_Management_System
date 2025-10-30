<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.pnl_login = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.pctgeneral = New System.Windows.Forms.PictureBox
        Me.btnok = New System.Windows.Forms.Button
        Me.txtpassword = New DefaultControls.MaskedBox(Me.components)
        Me.txtusername = New DefaultControls.MaskedBox(Me.components)
        Me.lblpassword = New System.Windows.Forms.Label
        Me.lblusername = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl_login.SuspendLayout()
        CType(Me.pctgeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_login
        '
        Me.pnl_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_login.Controls.Add(Me.btnclose)
        Me.pnl_login.Controls.Add(Me.pctgeneral)
        Me.pnl_login.Controls.Add(Me.btnok)
        Me.pnl_login.Controls.Add(Me.txtpassword)
        Me.pnl_login.Controls.Add(Me.txtusername)
        Me.pnl_login.Controls.Add(Me.lblpassword)
        Me.pnl_login.Controls.Add(Me.lblusername)
        Me.pnl_login.Controls.Add(Me.PictureBox1)
        Me.pnl_login.Location = New System.Drawing.Point(1, 1)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(574, 234)
        Me.pnl_login.TabIndex = 1
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.Location = New System.Drawing.Point(202, 200)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(57, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'pctgeneral
        '
        Me.pctgeneral.Image = CType(resources.GetObject("pctgeneral.Image"), System.Drawing.Image)
        Me.pctgeneral.Location = New System.Drawing.Point(-2, -1)
        Me.pctgeneral.Name = "pctgeneral"
        Me.pctgeneral.Size = New System.Drawing.Size(574, 160)
        Me.pctgeneral.TabIndex = 0
        Me.pctgeneral.TabStop = False
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnok.Image = CType(resources.GetObject("btnok.Image"), System.Drawing.Image)
        Me.btnok.Location = New System.Drawing.Point(202, 171)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(57, 23)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "Ok"
        Me.btnok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnok.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.CheckBounds = False
        Me.txtpassword.DateFormat = Nothing
        Me.txtpassword.DecimalPlaces = CType(0, Byte)
        Me.txtpassword.Location = New System.Drawing.Point(81, 202)
        Me.txtpassword.MaxDate = New Date(CType(0, Long))
        Me.txtpassword.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpassword.MinDate = New Date(CType(0, Long))
        Me.txtpassword.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(115, 20)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtusername
        '
        Me.txtusername.CheckBounds = False
        Me.txtusername.DateFormat = Nothing
        Me.txtusername.DecimalPlaces = CType(0, Byte)
        Me.txtusername.Location = New System.Drawing.Point(81, 173)
        Me.txtusername.MaxDate = New Date(CType(0, Long))
        Me.txtusername.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtusername.MinDate = New Date(CType(0, Long))
        Me.txtusername.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(115, 20)
        Me.txtusername.TabIndex = 0
        Me.txtusername.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(12, 205)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(59, 13)
        Me.lblpassword.TabIndex = 3
        Me.lblpassword.Text = "Password :"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(12, 176)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(47, 13)
        Me.lblusername.TabIndex = 2
        Me.lblusername.Text = "User Id :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(265, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 74)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 235)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_login"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.pctgeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_login As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents txtpassword As DefaultControls.MaskedBox
    Friend WithEvents txtusername As DefaultControls.MaskedBox
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctgeneral As System.Windows.Forms.PictureBox
End Class
