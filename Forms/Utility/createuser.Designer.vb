<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(createuser))
        Me.pnlcreate = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtconpwd = New DefaultControls.MaskedBox(Me.components)
        Me.btnlogin = New System.Windows.Forms.Button
        Me.lbluser = New System.Windows.Forms.Label
        Me.lblpwd = New System.Windows.Forms.Label
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.txtpwd = New DefaultControls.MaskedBox(Me.components)
        Me.txtuserid = New DefaultControls.MaskedBox(Me.components)
        Me.pnlcreate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlcreate
        '
        Me.pnlcreate.Controls.Add(Me.Label1)
        Me.pnlcreate.Controls.Add(Me.txtconpwd)
        Me.pnlcreate.Controls.Add(Me.btnlogin)
        Me.pnlcreate.Controls.Add(Me.lbluser)
        Me.pnlcreate.Controls.Add(Me.lblpwd)
        Me.pnlcreate.Controls.Add(Me.btnclear)
        Me.pnlcreate.Controls.Add(Me.btncancel)
        Me.pnlcreate.Controls.Add(Me.txtpwd)
        Me.pnlcreate.Controls.Add(Me.txtuserid)
        Me.pnlcreate.Location = New System.Drawing.Point(12, 12)
        Me.pnlcreate.Name = "pnlcreate"
        Me.pnlcreate.Size = New System.Drawing.Size(316, 133)
        Me.pnlcreate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Confirm Password : *"
        '
        'txtconpwd
        '
        Me.txtconpwd.CheckBounds = False
        Me.txtconpwd.DateFormat = Nothing
        Me.txtconpwd.DecimalPlaces = CType(0, Byte)
        Me.txtconpwd.Location = New System.Drawing.Point(129, 62)
        Me.txtconpwd.MaxDate = New Date(CType(0, Long))
        Me.txtconpwd.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtconpwd.MinDate = New Date(CType(0, Long))
        Me.txtconpwd.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtconpwd.Name = "txtconpwd"
        Me.txtconpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconpwd.Size = New System.Drawing.Size(165, 20)
        Me.txtconpwd.TabIndex = 2
        Me.txtconpwd.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'btnlogin
        '
        Me.btnlogin.Image = CType(resources.GetObject("btnlogin.Image"), System.Drawing.Image)
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.Location = New System.Drawing.Point(49, 94)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Create"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(22, 11)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(54, 13)
        Me.lbluser.TabIndex = 4
        Me.lbluser.Text = "User Id : *"
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.Location = New System.Drawing.Point(22, 37)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(66, 13)
        Me.lblpwd.TabIndex = 3
        Me.lblpwd.Text = "Password : *"
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclear.Location = New System.Drawing.Point(134, 94)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(219, 94)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'txtpwd
        '
        Me.txtpwd.CheckBounds = False
        Me.txtpwd.DateFormat = Nothing
        Me.txtpwd.DecimalPlaces = CType(0, Byte)
        Me.txtpwd.Location = New System.Drawing.Point(130, 34)
        Me.txtpwd.MaxDate = New Date(CType(0, Long))
        Me.txtpwd.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpwd.MinDate = New Date(CType(0, Long))
        Me.txtpwd.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(165, 20)
        Me.txtpwd.TabIndex = 1
        Me.txtpwd.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtuserid
        '
        Me.txtuserid.CheckBounds = False
        Me.txtuserid.DateFormat = Nothing
        Me.txtuserid.DecimalPlaces = CType(0, Byte)
        Me.txtuserid.Location = New System.Drawing.Point(130, 8)
        Me.txtuserid.MaxDate = New Date(CType(0, Long))
        Me.txtuserid.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtuserid.MinDate = New Date(CType(0, Long))
        Me.txtuserid.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(165, 20)
        Me.txtuserid.TabIndex = 0
        Me.txtuserid.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'createuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 158)
        Me.Controls.Add(Me.pnlcreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "createuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create User"
        Me.pnlcreate.ResumeLayout(False)
        Me.pnlcreate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlcreate As System.Windows.Forms.Panel
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblpwd As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents txtpwd As DefaultControls.MaskedBox
    Friend WithEvents txtuserid As DefaultControls.MaskedBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtconpwd As DefaultControls.MaskedBox
End Class
