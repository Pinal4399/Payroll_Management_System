<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_trainer))
        Me.bnvtrainer = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.lbltrainernamefind = New System.Windows.Forms.ToolStripLabel
        Me.txttrainernamefind = New System.Windows.Forms.ToolStripTextBox
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.pnl_trainer = New System.Windows.Forms.Panel
        Me.cmbtrainertype = New DefaultControls.ComboBox
        Me.DateTimePickerfromdate = New DefaultControls.DateTimePicker
        Me.DateTimePickertodate = New DefaultControls.DateTimePicker
        Me.chkavailable = New DefaultControls.CheckBox
        Me.cmbempcode = New DefaultControls.ComboBox
        Me.lblempcode = New System.Windows.Forms.Label
        Me.txtmobileno = New DefaultControls.MaskedBox(Me.components)
        Me.txtcountry = New DefaultControls.MaskedBox(Me.components)
        Me.txtzipcode = New DefaultControls.MaskedBox(Me.components)
        Me.lblzip = New System.Windows.Forms.Label
        Me.lbltodt = New System.Windows.Forms.Label
        Me.lblmobile = New System.Windows.Forms.Label
        Me.lblcntry = New System.Windows.Forms.Label
        Me.txtemail = New DefaultControls.MaskedBox(Me.components)
        Me.txtphoneno = New DefaultControls.MaskedBox(Me.components)
        Me.txtstate = New DefaultControls.MaskedBox(Me.components)
        Me.txtcity = New DefaultControls.MaskedBox(Me.components)
        Me.txttrainername = New DefaultControls.MaskedBox(Me.components)
        Me.lblcity = New System.Windows.Forms.Label
        Me.lblfromdt = New System.Windows.Forms.Label
        Me.lblemail = New System.Windows.Forms.Label
        Me.lblphno = New System.Windows.Forms.Label
        Me.lblstate = New System.Windows.Forms.Label
        Me.lbladd = New System.Windows.Forms.Label
        Me.lbltrnm = New System.Windows.Forms.Label
        Me.lblttype = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.TextBox
        CType(Me.bnvtrainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnvtrainer.SuspendLayout()
        Me.pnl_trainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnvtrainer
        '
        Me.bnvtrainer.AddNewItem = Me.btnadd
        Me.bnvtrainer.CountItem = Me.BindingNavigatorCountItem1
        Me.bnvtrainer.DeleteItem = Me.btndelete
        Me.bnvtrainer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave, Me.ToolStripSeparator1, Me.lbltrainernamefind, Me.txttrainernamefind, Me.btnfind})
        Me.bnvtrainer.Location = New System.Drawing.Point(0, 0)
        Me.bnvtrainer.MoveFirstItem = Me.btnfirst
        Me.bnvtrainer.MoveLastItem = Me.btnlast
        Me.bnvtrainer.MoveNextItem = Me.btnnext
        Me.bnvtrainer.MovePreviousItem = Me.btnprevious
        Me.bnvtrainer.Name = "bnvtrainer"
        Me.bnvtrainer.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bnvtrainer.Size = New System.Drawing.Size(743, 25)
        Me.bnvtrainer.TabIndex = 9
        Me.bnvtrainer.Text = "BindingNavigator1"
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
        'lbltrainernamefind
        '
        Me.lbltrainernamefind.Name = "lbltrainernamefind"
        Me.lbltrainernamefind.Size = New System.Drawing.Size(78, 22)
        Me.lbltrainernamefind.Text = "Trainer &Name :"
        '
        'txttrainernamefind
        '
        Me.txttrainernamefind.Name = "txttrainernamefind"
        Me.txttrainernamefind.Size = New System.Drawing.Size(100, 25)
        Me.txttrainernamefind.Text = "%"
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
        'pnl_trainer
        '
        Me.pnl_trainer.Controls.Add(Me.txtadd)
        Me.pnl_trainer.Controls.Add(Me.cmbtrainertype)
        Me.pnl_trainer.Controls.Add(Me.DateTimePickerfromdate)
        Me.pnl_trainer.Controls.Add(Me.DateTimePickertodate)
        Me.pnl_trainer.Controls.Add(Me.chkavailable)
        Me.pnl_trainer.Controls.Add(Me.cmbempcode)
        Me.pnl_trainer.Controls.Add(Me.lblempcode)
        Me.pnl_trainer.Controls.Add(Me.txtmobileno)
        Me.pnl_trainer.Controls.Add(Me.txtcountry)
        Me.pnl_trainer.Controls.Add(Me.txtzipcode)
        Me.pnl_trainer.Controls.Add(Me.lblzip)
        Me.pnl_trainer.Controls.Add(Me.lbltodt)
        Me.pnl_trainer.Controls.Add(Me.lblmobile)
        Me.pnl_trainer.Controls.Add(Me.lblcntry)
        Me.pnl_trainer.Controls.Add(Me.txtemail)
        Me.pnl_trainer.Controls.Add(Me.txtphoneno)
        Me.pnl_trainer.Controls.Add(Me.txtstate)
        Me.pnl_trainer.Controls.Add(Me.txtcity)
        Me.pnl_trainer.Controls.Add(Me.txttrainername)
        Me.pnl_trainer.Controls.Add(Me.lblcity)
        Me.pnl_trainer.Controls.Add(Me.lblfromdt)
        Me.pnl_trainer.Controls.Add(Me.lblemail)
        Me.pnl_trainer.Controls.Add(Me.lblphno)
        Me.pnl_trainer.Controls.Add(Me.lblstate)
        Me.pnl_trainer.Controls.Add(Me.lbladd)
        Me.pnl_trainer.Controls.Add(Me.lbltrnm)
        Me.pnl_trainer.Controls.Add(Me.lblttype)
        Me.pnl_trainer.Location = New System.Drawing.Point(21, 44)
        Me.pnl_trainer.Name = "pnl_trainer"
        Me.pnl_trainer.Size = New System.Drawing.Size(706, 343)
        Me.pnl_trainer.TabIndex = 10
        '
        'cmbtrainertype
        '
        Me.cmbtrainertype.AutoDropDown = False
        Me.cmbtrainertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtrainertype.FormattingEnabled = True
        Me.cmbtrainertype.Items.AddRange(New Object() {"External", "Internal"})
        Me.cmbtrainertype.Location = New System.Drawing.Point(127, 25)
        Me.cmbtrainertype.Name = "cmbtrainertype"
        Me.cmbtrainertype.Size = New System.Drawing.Size(190, 21)
        Me.cmbtrainertype.TabIndex = 0
        '
        'DateTimePickerfromdate
        '
        Me.DateTimePickerfromdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerfromdate.Location = New System.Drawing.Point(127, 289)
        Me.DateTimePickerfromdate.Name = "DateTimePickerfromdate"
        Me.DateTimePickerfromdate.Size = New System.Drawing.Size(190, 20)
        Me.DateTimePickerfromdate.TabIndex = 12
        Me.DateTimePickerfromdate.Value = New Date(2010, 3, 29, 0, 0, 0, 0)
        '
        'DateTimePickertodate
        '
        Me.DateTimePickertodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickertodate.Location = New System.Drawing.Point(460, 286)
        Me.DateTimePickertodate.Name = "DateTimePickertodate"
        Me.DateTimePickertodate.Size = New System.Drawing.Size(190, 20)
        Me.DateTimePickertodate.TabIndex = 13
        Me.DateTimePickertodate.Value = New Date(2010, 3, 29, 0, 0, 0, 0)
        '
        'chkavailable
        '
        Me.chkavailable.AutoSize = True
        Me.chkavailable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkavailable.Location = New System.Drawing.Point(353, 259)
        Me.chkavailable.Name = "chkavailable"
        Me.chkavailable.Size = New System.Drawing.Size(124, 17)
        Me.chkavailable.TabIndex = 11
        Me.chkavailable.Text = "Available :*               "
        Me.chkavailable.UseVisualStyleBackColor = True
        '
        'cmbempcode
        '
        Me.cmbempcode.AutoDropDown = False
        Me.cmbempcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbempcode.Enabled = False
        Me.cmbempcode.FormattingEnabled = True
        Me.cmbempcode.Location = New System.Drawing.Point(460, 24)
        Me.cmbempcode.Name = "cmbempcode"
        Me.cmbempcode.Size = New System.Drawing.Size(190, 21)
        Me.cmbempcode.TabIndex = 1
        '
        'lblempcode
        '
        Me.lblempcode.AutoSize = True
        Me.lblempcode.Location = New System.Drawing.Point(353, 28)
        Me.lblempcode.Name = "lblempcode"
        Me.lblempcode.Size = New System.Drawing.Size(87, 13)
        Me.lblempcode.TabIndex = 47
        Me.lblempcode.Text = "Employee Code :"
        '
        'txtmobileno
        '
        Me.txtmobileno.CheckBounds = False
        Me.txtmobileno.DateFormat = Nothing
        Me.txtmobileno.DecimalPlaces = CType(0, Byte)
        Me.txtmobileno.Location = New System.Drawing.Point(460, 221)
        Me.txtmobileno.MaxDate = New Date(CType(0, Long))
        Me.txtmobileno.MaxLength = 12
        Me.txtmobileno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmobileno.MinDate = New Date(CType(0, Long))
        Me.txtmobileno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(190, 20)
        Me.txtmobileno.TabIndex = 10
        Me.txtmobileno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtcountry
        '
        Me.txtcountry.CheckBounds = False
        Me.txtcountry.DateFormat = Nothing
        Me.txtcountry.DecimalPlaces = CType(0, Byte)
        Me.txtcountry.Location = New System.Drawing.Point(460, 188)
        Me.txtcountry.MaxDate = New Date(CType(0, Long))
        Me.txtcountry.MaxLength = 6
        Me.txtcountry.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcountry.MinDate = New Date(CType(0, Long))
        Me.txtcountry.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(190, 20)
        Me.txtcountry.TabIndex = 9
        Me.txtcountry.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtzipcode
        '
        Me.txtzipcode.CheckBounds = False
        Me.txtzipcode.DateFormat = Nothing
        Me.txtzipcode.DecimalPlaces = CType(0, Byte)
        Me.txtzipcode.Location = New System.Drawing.Point(460, 155)
        Me.txtzipcode.MaxDate = New Date(CType(0, Long))
        Me.txtzipcode.MaxLength = 6
        Me.txtzipcode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtzipcode.MinDate = New Date(CType(0, Long))
        Me.txtzipcode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtzipcode.Name = "txtzipcode"
        Me.txtzipcode.Size = New System.Drawing.Size(190, 20)
        Me.txtzipcode.TabIndex = 8
        Me.txtzipcode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'lblzip
        '
        Me.lblzip.AutoSize = True
        Me.lblzip.Location = New System.Drawing.Point(353, 158)
        Me.lblzip.Name = "lblzip"
        Me.lblzip.Size = New System.Drawing.Size(56, 13)
        Me.lblzip.TabIndex = 41
        Me.lblzip.Text = "Zip Code :"
        '
        'lbltodt
        '
        Me.lbltodt.AutoSize = True
        Me.lbltodt.Location = New System.Drawing.Point(353, 290)
        Me.lbltodt.Name = "lbltodt"
        Me.lbltodt.Size = New System.Drawing.Size(56, 13)
        Me.lbltodt.TabIndex = 40
        Me.lbltodt.Text = "To Date :*"
        '
        'lblmobile
        '
        Me.lblmobile.AutoSize = True
        Me.lblmobile.Location = New System.Drawing.Point(353, 224)
        Me.lblmobile.Name = "lblmobile"
        Me.lblmobile.Size = New System.Drawing.Size(64, 13)
        Me.lblmobile.TabIndex = 38
        Me.lblmobile.Text = "Mobile No. :"
        '
        'lblcntry
        '
        Me.lblcntry.AutoSize = True
        Me.lblcntry.Location = New System.Drawing.Point(353, 191)
        Me.lblcntry.Name = "lblcntry"
        Me.lblcntry.Size = New System.Drawing.Size(53, 13)
        Me.lblcntry.TabIndex = 37
        Me.lblcntry.Text = "Country :*"
        '
        'txtemail
        '
        Me.txtemail.CheckBounds = False
        Me.txtemail.DateFormat = Nothing
        Me.txtemail.DecimalPlaces = CType(0, Byte)
        Me.txtemail.Location = New System.Drawing.Point(127, 257)
        Me.txtemail.MaxDate = New Date(CType(0, Long))
        Me.txtemail.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemail.MinDate = New Date(CType(0, Long))
        Me.txtemail.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(190, 20)
        Me.txtemail.TabIndex = 7
        Me.txtemail.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_EMails
        '
        'txtphoneno
        '
        Me.txtphoneno.CheckBounds = False
        Me.txtphoneno.DateFormat = Nothing
        Me.txtphoneno.DecimalPlaces = CType(0, Byte)
        Me.txtphoneno.Location = New System.Drawing.Point(127, 224)
        Me.txtphoneno.MaxDate = New Date(CType(0, Long))
        Me.txtphoneno.MaxLength = 12
        Me.txtphoneno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtphoneno.MinDate = New Date(CType(0, Long))
        Me.txtphoneno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtphoneno.Name = "txtphoneno"
        Me.txtphoneno.Size = New System.Drawing.Size(190, 20)
        Me.txtphoneno.TabIndex = 6
        Me.txtphoneno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtstate
        '
        Me.txtstate.CheckBounds = False
        Me.txtstate.DateFormat = Nothing
        Me.txtstate.DecimalPlaces = CType(0, Byte)
        Me.txtstate.Location = New System.Drawing.Point(127, 191)
        Me.txtstate.MaxDate = New Date(CType(0, Long))
        Me.txtstate.MaxLength = 6
        Me.txtstate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtstate.MinDate = New Date(CType(0, Long))
        Me.txtstate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(190, 20)
        Me.txtstate.TabIndex = 5
        Me.txtstate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtcity
        '
        Me.txtcity.CheckBounds = False
        Me.txtcity.DateFormat = Nothing
        Me.txtcity.DecimalPlaces = CType(0, Byte)
        Me.txtcity.Location = New System.Drawing.Point(127, 158)
        Me.txtcity.MaxDate = New Date(CType(0, Long))
        Me.txtcity.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.MinDate = New Date(CType(0, Long))
        Me.txtcity.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(190, 20)
        Me.txtcity.TabIndex = 4
        Me.txtcity.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txttrainername
        '
        Me.txttrainername.CheckBounds = False
        Me.txttrainername.DateFormat = Nothing
        Me.txttrainername.DecimalPlaces = CType(0, Byte)
        Me.txttrainername.Location = New System.Drawing.Point(127, 58)
        Me.txttrainername.MaxDate = New Date(CType(0, Long))
        Me.txttrainername.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttrainername.MinDate = New Date(CType(0, Long))
        Me.txttrainername.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttrainername.Name = "txttrainername"
        Me.txttrainername.Size = New System.Drawing.Size(523, 20)
        Me.txttrainername.TabIndex = 2
        Me.txttrainername.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(20, 161)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(34, 13)
        Me.lblcity.TabIndex = 27
        Me.lblcity.Text = "City :*"
        '
        'lblfromdt
        '
        Me.lblfromdt.AutoSize = True
        Me.lblfromdt.Location = New System.Drawing.Point(20, 293)
        Me.lblfromdt.Name = "lblfromdt"
        Me.lblfromdt.Size = New System.Drawing.Size(66, 13)
        Me.lblfromdt.TabIndex = 22
        Me.lblfromdt.Text = "From Date :*"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(20, 260)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(38, 13)
        Me.lblemail.TabIndex = 20
        Me.lblemail.Text = "Email :"
        '
        'lblphno
        '
        Me.lblphno.AutoSize = True
        Me.lblphno.Location = New System.Drawing.Point(20, 227)
        Me.lblphno.Name = "lblphno"
        Me.lblphno.Size = New System.Drawing.Size(64, 13)
        Me.lblphno.TabIndex = 10
        Me.lblphno.Text = "Phone No. :"
        '
        'lblstate
        '
        Me.lblstate.AutoSize = True
        Me.lblstate.Location = New System.Drawing.Point(20, 194)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.Size = New System.Drawing.Size(38, 13)
        Me.lblstate.TabIndex = 8
        Me.lblstate.Text = "State :"
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
        'lbltrnm
        '
        Me.lbltrnm.AutoSize = True
        Me.lbltrnm.Location = New System.Drawing.Point(20, 61)
        Me.lbltrnm.Name = "lbltrnm"
        Me.lbltrnm.Size = New System.Drawing.Size(81, 13)
        Me.lbltrnm.TabIndex = 2
        Me.lbltrnm.Text = "Trainer Name :*"
        '
        'lblttype
        '
        Me.lblttype.AutoSize = True
        Me.lblttype.Location = New System.Drawing.Point(20, 28)
        Me.lblttype.Name = "lblttype"
        Me.lblttype.Size = New System.Drawing.Size(73, 13)
        Me.lblttype.TabIndex = 0
        Me.lblttype.Text = "Trainer Type :"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(127, 91)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtadd.Size = New System.Drawing.Size(523, 58)
        Me.txtadd.TabIndex = 3
        '
        'frm_trainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 405)
        Me.Controls.Add(Me.pnl_trainer)
        Me.Controls.Add(Me.bnvtrainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_trainer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trainer"
        CType(Me.bnvtrainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnvtrainer.ResumeLayout(False)
        Me.bnvtrainer.PerformLayout()
        Me.pnl_trainer.ResumeLayout(False)
        Me.pnl_trainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnvtrainer As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents lbltrainernamefind As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txttrainernamefind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_trainer As System.Windows.Forms.Panel
    Friend WithEvents txtemail As DefaultControls.MaskedBox
    Friend WithEvents txtphoneno As DefaultControls.MaskedBox
    Friend WithEvents txtstate As DefaultControls.MaskedBox
    Friend WithEvents txtcity As DefaultControls.MaskedBox
    Friend WithEvents txttrainername As DefaultControls.MaskedBox
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblfromdt As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblphno As System.Windows.Forms.Label
    Friend WithEvents lblstate As System.Windows.Forms.Label
    Friend WithEvents lbladd As System.Windows.Forms.Label
    Friend WithEvents lbltrnm As System.Windows.Forms.Label
    Friend WithEvents lblttype As System.Windows.Forms.Label
    Friend WithEvents txtmobileno As DefaultControls.MaskedBox
    Friend WithEvents txtcountry As DefaultControls.MaskedBox
    Friend WithEvents txtzipcode As DefaultControls.MaskedBox
    Friend WithEvents lblzip As System.Windows.Forms.Label
    Friend WithEvents lbltodt As System.Windows.Forms.Label
    Friend WithEvents lblmobile As System.Windows.Forms.Label
    Friend WithEvents lblcntry As System.Windows.Forms.Label
    Friend WithEvents cmbempcode As DefaultControls.ComboBox
    Friend WithEvents lblempcode As System.Windows.Forms.Label
    Friend WithEvents chkavailable As DefaultControls.CheckBox
    Friend WithEvents DateTimePickerfromdate As DefaultControls.DateTimePicker
    Friend WithEvents DateTimePickertodate As DefaultControls.DateTimePicker
    Friend WithEvents cmbtrainertype As DefaultControls.ComboBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
End Class
