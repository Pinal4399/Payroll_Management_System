<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_professiontax
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_professiontax))
        Me.pnl_pt = New System.Windows.Forms.Panel
        Me.txtptamt = New DefaultControls.MaskedBox(Me.components)
        Me.txttomonth = New DefaultControls.MaskedBox(Me.components)
        Me.txtUcaserng = New DefaultControls.MaskedBox(Me.components)
        Me.lblUcaserng = New System.Windows.Forms.Label
        Me.lbltomnth = New System.Windows.Forms.Label
        Me.txtfrommonth = New DefaultControls.MaskedBox(Me.components)
        Me.txtlowerrng = New DefaultControls.MaskedBox(Me.components)
        Me.lbllrng = New System.Windows.Forms.Label
        Me.lblfrommnth = New System.Windows.Forms.Label
        Me.cmbfinyear = New DefaultControls.ComboBox
        Me.lblfinyear = New System.Windows.Forms.Label
        Me.txtdesc = New DefaultControls.MaskedBox(Me.components)
        Me.lbldesc = New System.Windows.Forms.Label
        Me.lblptamt = New System.Windows.Forms.Label
        Me.bnvprofessiontax = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnadd = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.btndelete = New System.Windows.Forms.ToolStripButton
        Me.btnfirst = New System.Windows.Forms.ToolStripButton
        Me.btnprevious = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnnext = New System.Windows.Forms.ToolStripButton
        Me.btnlast = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnsave = New System.Windows.Forms.ToolStripButton
        Me.pnl_pt.SuspendLayout()
        CType(Me.bnvprofessiontax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnvprofessiontax.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_pt
        '
        Me.pnl_pt.Controls.Add(Me.txtptamt)
        Me.pnl_pt.Controls.Add(Me.txttomonth)
        Me.pnl_pt.Controls.Add(Me.txtUcaserng)
        Me.pnl_pt.Controls.Add(Me.lblUcaserng)
        Me.pnl_pt.Controls.Add(Me.lbltomnth)
        Me.pnl_pt.Controls.Add(Me.txtfrommonth)
        Me.pnl_pt.Controls.Add(Me.txtlowerrng)
        Me.pnl_pt.Controls.Add(Me.lbllrng)
        Me.pnl_pt.Controls.Add(Me.lblfrommnth)
        Me.pnl_pt.Controls.Add(Me.cmbfinyear)
        Me.pnl_pt.Controls.Add(Me.lblfinyear)
        Me.pnl_pt.Controls.Add(Me.txtdesc)
        Me.pnl_pt.Controls.Add(Me.lbldesc)
        Me.pnl_pt.Controls.Add(Me.lblptamt)
        Me.pnl_pt.Location = New System.Drawing.Point(12, 32)
        Me.pnl_pt.Name = "pnl_pt"
        Me.pnl_pt.Size = New System.Drawing.Size(555, 150)
        Me.pnl_pt.TabIndex = 0
        '
        'txtptamt
        '
        Me.txtptamt.CheckBounds = False
        Me.txtptamt.DateFormat = Nothing
        Me.txtptamt.DecimalPlaces = CType(0, Byte)
        Me.txtptamt.Location = New System.Drawing.Point(116, 13)
        Me.txtptamt.MaxDate = New Date(CType(0, Long))
        Me.txtptamt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtptamt.MinDate = New Date(CType(0, Long))
        Me.txtptamt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtptamt.Name = "txtptamt"
        Me.txtptamt.Size = New System.Drawing.Size(154, 20)
        Me.txtptamt.TabIndex = 0
        Me.txtptamt.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txttomonth
        '
        Me.txttomonth.CheckBounds = False
        Me.txttomonth.DateFormat = Nothing
        Me.txttomonth.DecimalPlaces = CType(0, Byte)
        Me.txttomonth.Location = New System.Drawing.Point(384, 111)
        Me.txttomonth.MaxDate = New Date(CType(0, Long))
        Me.txttomonth.MaxLength = 6
        Me.txttomonth.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttomonth.MinDate = New Date(CType(0, Long))
        Me.txttomonth.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttomonth.Name = "txttomonth"
        Me.txttomonth.Size = New System.Drawing.Size(154, 20)
        Me.txttomonth.TabIndex = 6
        Me.txttomonth.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtUcaserng
        '
        Me.txtUcaserng.CheckBounds = False
        Me.txtUcaserng.DateFormat = Nothing
        Me.txtUcaserng.DecimalPlaces = CType(0, Byte)
        Me.txtUcaserng.Location = New System.Drawing.Point(384, 78)
        Me.txtUcaserng.MaxDate = New Date(CType(0, Long))
        Me.txtUcaserng.MaxLength = 6
        Me.txtUcaserng.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUcaserng.MinDate = New Date(CType(0, Long))
        Me.txtUcaserng.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUcaserng.Name = "txtUcaserng"
        Me.txtUcaserng.Size = New System.Drawing.Size(154, 20)
        Me.txtUcaserng.TabIndex = 4
        Me.txtUcaserng.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'lblUcaserng
        '
        Me.lblUcaserng.AutoSize = True
        Me.lblUcaserng.Location = New System.Drawing.Point(289, 81)
        Me.lblUcaserng.Name = "lblUcaserng"
        Me.lblUcaserng.Size = New System.Drawing.Size(81, 13)
        Me.lblUcaserng.TabIndex = 68
        Me.lblUcaserng.Text = "Ucase Range :*"
        '
        'lbltomnth
        '
        Me.lbltomnth.AutoSize = True
        Me.lbltomnth.Location = New System.Drawing.Point(289, 114)
        Me.lbltomnth.Name = "lbltomnth"
        Me.lbltomnth.Size = New System.Drawing.Size(63, 13)
        Me.lbltomnth.TabIndex = 67
        Me.lbltomnth.Text = "To Month :*"
        '
        'txtfrommonth
        '
        Me.txtfrommonth.CheckBounds = False
        Me.txtfrommonth.DateFormat = Nothing
        Me.txtfrommonth.DecimalPlaces = CType(0, Byte)
        Me.txtfrommonth.Location = New System.Drawing.Point(116, 111)
        Me.txtfrommonth.MaxDate = New Date(CType(0, Long))
        Me.txtfrommonth.MaxLength = 6
        Me.txtfrommonth.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfrommonth.MinDate = New Date(CType(0, Long))
        Me.txtfrommonth.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfrommonth.Name = "txtfrommonth"
        Me.txtfrommonth.Size = New System.Drawing.Size(154, 20)
        Me.txtfrommonth.TabIndex = 5
        Me.txtfrommonth.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtlowerrng
        '
        Me.txtlowerrng.CheckBounds = False
        Me.txtlowerrng.DateFormat = Nothing
        Me.txtlowerrng.DecimalPlaces = CType(0, Byte)
        Me.txtlowerrng.Location = New System.Drawing.Point(116, 81)
        Me.txtlowerrng.MaxDate = New Date(CType(0, Long))
        Me.txtlowerrng.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlowerrng.MinDate = New Date(CType(0, Long))
        Me.txtlowerrng.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlowerrng.Name = "txtlowerrng"
        Me.txtlowerrng.Size = New System.Drawing.Size(154, 20)
        Me.txtlowerrng.TabIndex = 3
        Me.txtlowerrng.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'lbllrng
        '
        Me.lbllrng.AutoSize = True
        Me.lbllrng.Location = New System.Drawing.Point(11, 84)
        Me.lbllrng.Name = "lbllrng"
        Me.lbllrng.Size = New System.Drawing.Size(81, 13)
        Me.lbllrng.TabIndex = 66
        Me.lbllrng.Text = "Lower Range :*"
        '
        'lblfrommnth
        '
        Me.lblfrommnth.AutoSize = True
        Me.lblfrommnth.Location = New System.Drawing.Point(11, 117)
        Me.lblfrommnth.Name = "lblfrommnth"
        Me.lblfrommnth.Size = New System.Drawing.Size(73, 13)
        Me.lblfrommnth.TabIndex = 64
        Me.lblfrommnth.Text = "From Month :*"
        '
        'cmbfinyear
        '
        Me.cmbfinyear.AutoDropDown = False
        Me.cmbfinyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfinyear.FormattingEnabled = True
        Me.cmbfinyear.Items.AddRange(New Object() {"2008-2009", "2009-2010", "2010-2011"})
        Me.cmbfinyear.Location = New System.Drawing.Point(382, 13)
        Me.cmbfinyear.Name = "cmbfinyear"
        Me.cmbfinyear.Size = New System.Drawing.Size(156, 21)
        Me.cmbfinyear.TabIndex = 1
        '
        'lblfinyear
        '
        Me.lblfinyear.AutoSize = True
        Me.lblfinyear.Location = New System.Drawing.Point(287, 17)
        Me.lblfinyear.Name = "lblfinyear"
        Me.lblfinyear.Size = New System.Drawing.Size(52, 13)
        Me.lblfinyear.TabIndex = 59
        Me.lblfinyear.Text = "Fin Year :"
        '
        'txtdesc
        '
        Me.txtdesc.CheckBounds = False
        Me.txtdesc.DateFormat = Nothing
        Me.txtdesc.DecimalPlaces = CType(0, Byte)
        Me.txtdesc.Location = New System.Drawing.Point(116, 47)
        Me.txtdesc.MaxDate = New Date(CType(0, Long))
        Me.txtdesc.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdesc.MinDate = New Date(CType(0, Long))
        Me.txtdesc.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(422, 20)
        Me.txtdesc.TabIndex = 2
        Me.txtdesc.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Location = New System.Drawing.Point(9, 50)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(70, 13)
        Me.lbldesc.TabIndex = 58
        Me.lbldesc.Text = "Description :*"
        '
        'lblptamt
        '
        Me.lblptamt.AutoSize = True
        Me.lblptamt.Location = New System.Drawing.Point(9, 17)
        Me.lblptamt.Name = "lblptamt"
        Me.lblptamt.Size = New System.Drawing.Size(70, 13)
        Me.lblptamt.TabIndex = 56
        Me.lblptamt.Text = "PT Amount :*"
        '
        'bnvprofessiontax
        '
        Me.bnvprofessiontax.AddNewItem = Me.btnadd
        Me.bnvprofessiontax.CountItem = Me.BindingNavigatorCountItem1
        Me.bnvprofessiontax.DeleteItem = Me.btndelete
        Me.bnvprofessiontax.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave})
        Me.bnvprofessiontax.Location = New System.Drawing.Point(0, 0)
        Me.bnvprofessiontax.MoveFirstItem = Me.btnfirst
        Me.bnvprofessiontax.MoveLastItem = Me.btnlast
        Me.bnvprofessiontax.MoveNextItem = Me.btnnext
        Me.bnvprofessiontax.MovePreviousItem = Me.btnprevious
        Me.bnvprofessiontax.Name = "bnvprofessiontax"
        Me.bnvprofessiontax.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bnvprofessiontax.Size = New System.Drawing.Size(581, 25)
        Me.bnvprofessiontax.TabIndex = 10
        Me.bnvprofessiontax.Text = "BindingNavigator1"
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageTransparentColor = System.Drawing.Color.White
        Me.btnadd.Name = "btnadd"
        Me.btnadd.RightToLeftAutoMirrorImage = True
        Me.btnadd.Size = New System.Drawing.Size(70, 22)
        Me.btnadd.Text = "&Add New"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.RightToLeftAutoMirrorImage = True
        Me.btndelete.Size = New System.Drawing.Size(58, 22)
        Me.btndelete.Text = "&Delete"
        '
        'btnfirst
        '
        Me.btnfirst.Image = CType(resources.GetObject("btnfirst.Image"), System.Drawing.Image)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.RightToLeftAutoMirrorImage = True
        Me.btnfirst.Size = New System.Drawing.Size(23, 22)
        Me.btnfirst.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'btnprevious
        '
        Me.btnprevious.Image = CType(resources.GetObject("btnprevious.Image"), System.Drawing.Image)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.RightToLeftAutoMirrorImage = True
        Me.btnprevious.Size = New System.Drawing.Size(23, 22)
        Me.btnprevious.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnnext
        '
        Me.btnnext.Image = CType(resources.GetObject("btnnext.Image"), System.Drawing.Image)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.RightToLeftAutoMirrorImage = True
        Me.btnnext.Size = New System.Drawing.Size(23, 22)
        Me.btnnext.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'btnlast
        '
        Me.btnlast.Image = CType(resources.GetObject("btnlast.Image"), System.Drawing.Image)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.RightToLeftAutoMirrorImage = True
        Me.btnlast.Size = New System.Drawing.Size(23, 22)
        Me.btnlast.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(51, 22)
        Me.btnsave.Text = "&Save"
        '
        'frm_professiontax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 198)
        Me.Controls.Add(Me.bnvprofessiontax)
        Me.Controls.Add(Me.pnl_pt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_professiontax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profession Tax"
        Me.pnl_pt.ResumeLayout(False)
        Me.pnl_pt.PerformLayout()
        CType(Me.bnvprofessiontax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnvprofessiontax.ResumeLayout(False)
        Me.bnvprofessiontax.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_pt As System.Windows.Forms.Panel
    Friend WithEvents cmbfinyear As DefaultControls.ComboBox
    Friend WithEvents lblfinyear As System.Windows.Forms.Label
    Friend WithEvents txtdesc As DefaultControls.MaskedBox
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents lblptamt As System.Windows.Forms.Label
    Friend WithEvents txtptamt As DefaultControls.MaskedBox
    Friend WithEvents txttomonth As DefaultControls.MaskedBox
    Friend WithEvents txtUcaserng As DefaultControls.MaskedBox
    Friend WithEvents lblUcaserng As System.Windows.Forms.Label
    Friend WithEvents lbltomnth As System.Windows.Forms.Label
    Friend WithEvents txtfrommonth As DefaultControls.MaskedBox
    Friend WithEvents txtlowerrng As DefaultControls.MaskedBox
    Friend WithEvents lbllrng As System.Windows.Forms.Label
    Friend WithEvents lblfrommnth As System.Windows.Forms.Label
    Friend WithEvents bnvprofessiontax As System.Windows.Forms.BindingNavigator
    Friend WithEvents btnadd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnfirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnprevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnnext As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnlast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnsave As System.Windows.Forms.ToolStripButton
End Class
