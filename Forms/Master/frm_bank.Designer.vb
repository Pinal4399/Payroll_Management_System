<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_bank))
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.lblbankname = New System.Windows.Forms.ToolStripLabel
        Me.txtbanknamefind = New System.Windows.Forms.ToolStripTextBox
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.pnl_bank = New System.Windows.Forms.Panel
        Me.txtfaxno = New DefaultControls.MaskedBox(Me.components)
        Me.txtphoneno = New DefaultControls.MaskedBox(Me.components)
        Me.txtdesignation = New DefaultControls.MaskedBox(Me.components)
        Me.txtcontactperson = New DefaultControls.MaskedBox(Me.components)
        Me.txtpincode = New DefaultControls.MaskedBox(Me.components)
        Me.txtcity = New DefaultControls.MaskedBox(Me.components)
        Me.txtbanknm = New DefaultControls.MaskedBox(Me.components)
        Me.txtbankcode = New DefaultControls.MaskedBox(Me.components)
        Me.lblcity = New System.Windows.Forms.Label
        Me.lblfax = New System.Windows.Forms.Label
        Me.lblphno = New System.Windows.Forms.Label
        Me.lbldesig = New System.Windows.Forms.Label
        Me.lblcontact = New System.Windows.Forms.Label
        Me.lblpincode = New System.Windows.Forms.Label
        Me.lbladd = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.lblcode = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.TextBox
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.pnl_bank.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.btnadd
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.btndelete
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave, Me.ToolStripSeparator1, Me.lblbankname, Me.txtbanknamefind, Me.btnfind})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnfirst
        Me.BindingNavigator1.MoveLastItem = Me.btnlast
        Me.BindingNavigator1.MoveNextItem = Me.btnnext
        Me.BindingNavigator1.MovePreviousItem = Me.btnprevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(585, 25)
        Me.BindingNavigator1.TabIndex = 8
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblbankname
        '
        Me.lblbankname.Name = "lblbankname"
        Me.lblbankname.Size = New System.Drawing.Size(41, 22)
        Me.lblbankname.Text = "&Name :"
        '
        'txtbanknamefind
        '
        Me.txtbanknamefind.Name = "txtbanknamefind"
        Me.txtbanknamefind.Size = New System.Drawing.Size(100, 25)
        Me.txtbanknamefind.Text = "%"
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(47, 22)
        Me.btnfind.Text = "F&ind"
        Me.btnfind.ToolTipText = "Search"
        '
        'pnl_bank
        '
        Me.pnl_bank.Controls.Add(Me.txtadd)
        Me.pnl_bank.Controls.Add(Me.txtfaxno)
        Me.pnl_bank.Controls.Add(Me.txtphoneno)
        Me.pnl_bank.Controls.Add(Me.txtdesignation)
        Me.pnl_bank.Controls.Add(Me.txtcontactperson)
        Me.pnl_bank.Controls.Add(Me.txtpincode)
        Me.pnl_bank.Controls.Add(Me.txtcity)
        Me.pnl_bank.Controls.Add(Me.txtbanknm)
        Me.pnl_bank.Controls.Add(Me.txtbankcode)
        Me.pnl_bank.Controls.Add(Me.lblcity)
        Me.pnl_bank.Controls.Add(Me.lblfax)
        Me.pnl_bank.Controls.Add(Me.lblphno)
        Me.pnl_bank.Controls.Add(Me.lbldesig)
        Me.pnl_bank.Controls.Add(Me.lblcontact)
        Me.pnl_bank.Controls.Add(Me.lblpincode)
        Me.pnl_bank.Controls.Add(Me.lbladd)
        Me.pnl_bank.Controls.Add(Me.lblname)
        Me.pnl_bank.Controls.Add(Me.lblcode)
        Me.pnl_bank.Location = New System.Drawing.Point(12, 43)
        Me.pnl_bank.Name = "pnl_bank"
        Me.pnl_bank.Size = New System.Drawing.Size(561, 375)
        Me.pnl_bank.TabIndex = 9
        '
        'txtfaxno
        '
        Me.txtfaxno.CheckBounds = False
        Me.txtfaxno.DateFormat = Nothing
        Me.txtfaxno.DecimalPlaces = CType(0, Byte)
        Me.txtfaxno.Location = New System.Drawing.Point(161, 323)
        Me.txtfaxno.MaxDate = New Date(CType(0, Long))
        Me.txtfaxno.MaxLength = 15
        Me.txtfaxno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfaxno.MinDate = New Date(CType(0, Long))
        Me.txtfaxno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfaxno.Name = "txtfaxno"
        Me.txtfaxno.Size = New System.Drawing.Size(190, 20)
        Me.txtfaxno.TabIndex = 8
        Me.txtfaxno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtphoneno
        '
        Me.txtphoneno.CheckBounds = False
        Me.txtphoneno.DateFormat = Nothing
        Me.txtphoneno.DecimalPlaces = CType(0, Byte)
        Me.txtphoneno.Location = New System.Drawing.Point(161, 290)
        Me.txtphoneno.MaxDate = New Date(CType(0, Long))
        Me.txtphoneno.MaxLength = 12
        Me.txtphoneno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtphoneno.MinDate = New Date(CType(0, Long))
        Me.txtphoneno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Size = New System.Drawing.Size(190, 20)
        Me.txtphoneno.TabIndex = 7
        Me.txtphoneno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtdesignation
        '
        Me.txtdesignation.CheckBounds = False
        Me.txtdesignation.DateFormat = Nothing
        Me.txtdesignation.DecimalPlaces = CType(0, Byte)
        Me.txtdesignation.Location = New System.Drawing.Point(161, 257)
        Me.txtdesignation.MaxDate = New Date(CType(0, Long))
        Me.txtdesignation.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdesignation.MinDate = New Date(CType(0, Long))
        Me.txtdesignation.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.Size = New System.Drawing.Size(190, 20)
        Me.txtdesignation.TabIndex = 6
        Me.txtdesignation.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtcontactperson
        '
        Me.txtcontactperson.CheckBounds = False
        Me.txtcontactperson.DateFormat = Nothing
        Me.txtcontactperson.DecimalPlaces = CType(0, Byte)
        Me.txtcontactperson.Location = New System.Drawing.Point(161, 224)
        Me.txtcontactperson.MaxDate = New Date(CType(0, Long))
        Me.txtcontactperson.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcontactperson.MinDate = New Date(CType(0, Long))
        Me.txtcontactperson.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcontactperson.Name = "txtcontactperson"
        Me.txtcontactperson.Size = New System.Drawing.Size(190, 20)
        Me.txtcontactperson.TabIndex = 5
        Me.txtcontactperson.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtpincode
        '
        Me.txtpincode.CheckBounds = False
        Me.txtpincode.DateFormat = Nothing
        Me.txtpincode.DecimalPlaces = CType(0, Byte)
        Me.txtpincode.Location = New System.Drawing.Point(161, 191)
        Me.txtpincode.MaxDate = New Date(CType(0, Long))
        Me.txtpincode.MaxLength = 6
        Me.txtpincode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpincode.MinDate = New Date(CType(0, Long))
        Me.txtpincode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpincode.Name = "txtpincode"
        Me.txtpincode.Size = New System.Drawing.Size(190, 20)
        Me.txtpincode.TabIndex = 4
        Me.txtpincode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtcity
        '
        Me.txtcity.CheckBounds = False
        Me.txtcity.DateFormat = Nothing
        Me.txtcity.DecimalPlaces = CType(0, Byte)
        Me.txtcity.Location = New System.Drawing.Point(161, 158)
        Me.txtcity.MaxDate = New Date(CType(0, Long))
        Me.txtcity.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.MinDate = New Date(CType(0, Long))
        Me.txtcity.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(190, 20)
        Me.txtcity.TabIndex = 3
        Me.txtcity.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtbanknm
        '
        Me.txtbanknm.CheckBounds = False
        Me.txtbanknm.DateFormat = Nothing
        Me.txtbanknm.DecimalPlaces = CType(0, Byte)
        Me.txtbanknm.Location = New System.Drawing.Point(161, 58)
        Me.txtbanknm.MaxDate = New Date(CType(0, Long))
        Me.txtbanknm.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbanknm.MinDate = New Date(CType(0, Long))
        Me.txtbanknm.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbanknm.Name = "txtbanknm"
        Me.txtbanknm.Size = New System.Drawing.Size(348, 20)
        Me.txtbanknm.TabIndex = 1
        Me.txtbanknm.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtbankcode
        '
        Me.txtbankcode.CheckBounds = False
        Me.txtbankcode.DateFormat = Nothing
        Me.txtbankcode.DecimalPlaces = CType(0, Byte)
        Me.txtbankcode.Location = New System.Drawing.Point(161, 25)
        Me.txtbankcode.MaxDate = New Date(CType(0, Long))
        Me.txtbankcode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbankcode.MinDate = New Date(CType(0, Long))
        Me.txtbankcode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbankcode.Name = "txtbankcode"
        Me.txtbankcode.Size = New System.Drawing.Size(190, 20)
        Me.txtbankcode.TabIndex = 0
        Me.txtbankcode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(20, 161)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(30, 13)
        Me.lblcity.TabIndex = 27
        Me.lblcity.Text = "City :"
        '
        'lblfax
        '
        Me.lblfax.AutoSize = True
        Me.lblfax.Location = New System.Drawing.Point(20, 326)
        Me.lblfax.Name = "lblfax"
        Me.lblfax.Size = New System.Drawing.Size(50, 13)
        Me.lblfax.TabIndex = 23
        Me.lblfax.Text = "Fax No. :"
        '
        'lblphno
        '
        Me.lblphno.AutoSize = True
        Me.lblphno.Location = New System.Drawing.Point(20, 293)
        Me.lblphno.Name = "lblphno"
        Me.lblphno.Size = New System.Drawing.Size(64, 13)
        Me.lblphno.TabIndex = 22
        Me.lblphno.Text = "Phone No. :"
        '
        'lbldesig
        '
        Me.lbldesig.AutoSize = True
        Me.lbldesig.Location = New System.Drawing.Point(20, 260)
        Me.lbldesig.Name = "lbldesig"
        Me.lbldesig.Size = New System.Drawing.Size(69, 13)
        Me.lbldesig.TabIndex = 20
        Me.lbldesig.Text = "Designation :"
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.Location = New System.Drawing.Point(20, 227)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(86, 13)
        Me.lblcontact.TabIndex = 10
        Me.lblcontact.Text = "Contact Person :"
        '
        'lblpincode
        '
        Me.lblpincode.AutoSize = True
        Me.lblpincode.Location = New System.Drawing.Point(20, 194)
        Me.lblpincode.Name = "lblpincode"
        Me.lblpincode.Size = New System.Drawing.Size(52, 13)
        Me.lblpincode.TabIndex = 8
        Me.lblpincode.Text = "Pincode :"
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Location = New System.Drawing.Point(20, 94)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(51, 13)
        Me.lbladd.TabIndex = 6
        Me.lbladd.Text = "Address :"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(20, 61)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(45, 13)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Name *:"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(20, 28)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(42, 13)
        Me.lblcode.TabIndex = 0
        Me.lblcode.Text = "Code *:"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(161, 91)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtadd.Size = New System.Drawing.Size(348, 58)
        Me.txtadd.TabIndex = 2
        '
        'frm_bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 432)
        Me.Controls.Add(Me.pnl_bank)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_bank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.pnl_bank.ResumeLayout(False)
        Me.pnl_bank.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblbankname As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtbanknamefind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_bank As System.Windows.Forms.Panel
    Friend WithEvents lblcontact As System.Windows.Forms.Label
    Friend WithEvents lblpincode As System.Windows.Forms.Label
    Friend WithEvents lbladd As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblcode As System.Windows.Forms.Label
    Friend WithEvents lblfax As System.Windows.Forms.Label
    Friend WithEvents lblphno As System.Windows.Forms.Label
    Friend WithEvents lbldesig As System.Windows.Forms.Label
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents txtbankcode As DefaultControls.MaskedBox
    Friend WithEvents txtfaxno As DefaultControls.MaskedBox
    Friend WithEvents txtphoneno As DefaultControls.MaskedBox
    Friend WithEvents txtdesignation As DefaultControls.MaskedBox
    Friend WithEvents txtcontactperson As DefaultControls.MaskedBox
    Friend WithEvents txtpincode As DefaultControls.MaskedBox
    Friend WithEvents txtcity As DefaultControls.MaskedBox
    Friend WithEvents txtbanknm As DefaultControls.MaskedBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
End Class
