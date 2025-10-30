<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changepwd))
        Me.pnl_change = New System.Windows.Forms.Panel
        Me.btncancel = New System.Windows.Forms.Button
        Me.lblusername = New System.Windows.Forms.Label
        Me.lblold = New System.Windows.Forms.Label
        Me.lblnew = New System.Windows.Forms.Label
        Me.btnchangepwd = New System.Windows.Forms.Button
        Me.lblconfirm = New System.Windows.Forms.Label
        Me.txtnewpwd = New DefaultControls.MaskedBox(Me.components)
        Me.txtoldpwd = New DefaultControls.MaskedBox(Me.components)
        Me.txtconnewpwd = New DefaultControls.MaskedBox(Me.components)
        Me.txtuserid = New DefaultControls.MaskedBox(Me.components)
        Me.pnl_change.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_change
        '
        Me.pnl_change.Controls.Add(Me.btncancel)
        Me.pnl_change.Controls.Add(Me.lblusername)
        Me.pnl_change.Controls.Add(Me.lblold)
        Me.pnl_change.Controls.Add(Me.lblnew)
        Me.pnl_change.Controls.Add(Me.btnchangepwd)
        Me.pnl_change.Controls.Add(Me.lblconfirm)
        Me.pnl_change.Controls.Add(Me.txtnewpwd)
        Me.pnl_change.Controls.Add(Me.txtoldpwd)
        Me.pnl_change.Controls.Add(Me.txtconnewpwd)
        Me.pnl_change.Controls.Add(Me.txtuserid)
        Me.pnl_change.Location = New System.Drawing.Point(5, 9)
        Me.pnl_change.Name = "pnl_change"
        Me.pnl_change.Size = New System.Drawing.Size(267, 151)
        Me.pnl_change.TabIndex = 1
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(181, 120)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(14, 16)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(47, 13)
        Me.lblusername.TabIndex = 8
        Me.lblusername.Text = "User Id :"
        '
        'lblold
        '
        Me.lblold.AutoSize = True
        Me.lblold.Location = New System.Drawing.Point(14, 43)
        Me.lblold.Name = "lblold"
        Me.lblold.Size = New System.Drawing.Size(78, 13)
        Me.lblold.TabIndex = 7
        Me.lblold.Text = "Old Password :"
        '
        'lblnew
        '
        Me.lblnew.AutoSize = True
        Me.lblnew.Location = New System.Drawing.Point(14, 69)
        Me.lblnew.Name = "lblnew"
        Me.lblnew.Size = New System.Drawing.Size(84, 13)
        Me.lblnew.TabIndex = 6
        Me.lblnew.Text = "New Password :"
        '
        'btnchangepwd
        '
        Me.btnchangepwd.Image = CType(resources.GetObject("btnchangepwd.Image"), System.Drawing.Image)
        Me.btnchangepwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnchangepwd.Location = New System.Drawing.Point(100, 120)
        Me.btnchangepwd.Name = "btnchangepwd"
        Me.btnchangepwd.Size = New System.Drawing.Size(75, 23)
        Me.btnchangepwd.TabIndex = 4
        Me.btnchangepwd.Text = "Ok"
        Me.btnchangepwd.UseVisualStyleBackColor = True
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.Location = New System.Drawing.Point(14, 96)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(94, 13)
        Me.lblconfirm.TabIndex = 4
        Me.lblconfirm.Text = "Confirm Password:"
        '
        'txtnewpwd
        '
        Me.txtnewpwd.CheckBounds = False
        Me.txtnewpwd.DateFormat = Nothing
        Me.txtnewpwd.DecimalPlaces = CType(0, Byte)
        Me.txtnewpwd.Location = New System.Drawing.Point(118, 66)
        Me.txtnewpwd.MaxDate = New Date(CType(0, Long))
        Me.txtnewpwd.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnewpwd.MinDate = New Date(CType(0, Long))
        Me.txtnewpwd.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnewpwd.Name = "txtnewpwd"
        Me.txtnewpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpwd.Size = New System.Drawing.Size(138, 20)
        Me.txtnewpwd.TabIndex = 2
        Me.txtnewpwd.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtoldpwd
        '
        Me.txtoldpwd.CheckBounds = False
        Me.txtoldpwd.DateFormat = Nothing
        Me.txtoldpwd.DecimalPlaces = CType(0, Byte)
        Me.txtoldpwd.Location = New System.Drawing.Point(118, 40)
        Me.txtoldpwd.MaxDate = New Date(CType(0, Long))
        Me.txtoldpwd.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtoldpwd.MinDate = New Date(CType(0, Long))
        Me.txtoldpwd.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtoldpwd.Name = "txtoldpwd"
        Me.txtoldpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpwd.Size = New System.Drawing.Size(138, 20)
        Me.txtoldpwd.TabIndex = 1
        Me.txtoldpwd.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtconnewpwd
        '
        Me.txtconnewpwd.CheckBounds = False
        Me.txtconnewpwd.DateFormat = Nothing
        Me.txtconnewpwd.DecimalPlaces = CType(0, Byte)
        Me.txtconnewpwd.Location = New System.Drawing.Point(118, 93)
        Me.txtconnewpwd.MaxDate = New Date(CType(0, Long))
        Me.txtconnewpwd.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtconnewpwd.MinDate = New Date(CType(0, Long))
        Me.txtconnewpwd.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtconnewpwd.Name = "txtconnewpwd"
        Me.txtconnewpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconnewpwd.Size = New System.Drawing.Size(138, 20)
        Me.txtconnewpwd.TabIndex = 3
        Me.txtconnewpwd.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtuserid
        '
        Me.txtuserid.CheckBounds = False
        Me.txtuserid.DateFormat = Nothing
        Me.txtuserid.DecimalPlaces = CType(0, Byte)
        Me.txtuserid.Location = New System.Drawing.Point(118, 13)
        Me.txtuserid.MaxDate = New Date(CType(0, Long))
        Me.txtuserid.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtuserid.MinDate = New Date(CType(0, Long))
        Me.txtuserid.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.ReadOnly = True
        Me.txtuserid.Size = New System.Drawing.Size(138, 20)
        Me.txtuserid.TabIndex = 0
        Me.txtuserid.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'changepwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 170)
        Me.Controls.Add(Me.pnl_change)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "changepwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.pnl_change.ResumeLayout(False)
        Me.pnl_change.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_change As System.Windows.Forms.Panel
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblold As System.Windows.Forms.Label
    Friend WithEvents lblnew As System.Windows.Forms.Label
    Friend WithEvents btnchangepwd As System.Windows.Forms.Button
    Friend WithEvents lblconfirm As System.Windows.Forms.Label
    Friend WithEvents txtnewpwd As DefaultControls.MaskedBox
    Friend WithEvents txtoldpwd As DefaultControls.MaskedBox
    Friend WithEvents txtconnewpwd As DefaultControls.MaskedBox
    Friend WithEvents txtuserid As DefaultControls.MaskedBox
End Class
