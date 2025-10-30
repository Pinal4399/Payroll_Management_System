<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_location
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_location))
        Me.lbl_occupier = New System.Windows.Forms.Label
        Me.lbl_owner = New System.Windows.Forms.Label
        Me.lbl_locationnm = New System.Windows.Forms.Label
        Me.lbl_faxno = New System.Windows.Forms.Label
        Me.lbl_zipcode = New System.Windows.Forms.Label
        Me.lbl_state = New System.Windows.Forms.Label
        Me.lbl_authonm = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_phno = New System.Windows.Forms.Label
        Me.lbl_country = New System.Windows.Forms.Label
        Me.lbl_city = New System.Windows.Forms.Label
        Me.lbl_address = New System.Windows.Forms.Label
        Me.locationpanel = New System.Windows.Forms.Panel
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtoccupier = New DefaultControls.MaskedBox(Me.components)
        Me.txtowner = New DefaultControls.MaskedBox(Me.components)
        Me.txtauthnm = New DefaultControls.MaskedBox(Me.components)
        Me.txtemail = New DefaultControls.MaskedBox(Me.components)
        Me.txtfaxno = New DefaultControls.MaskedBox(Me.components)
        Me.txtzipcode = New DefaultControls.MaskedBox(Me.components)
        Me.txtstate = New DefaultControls.MaskedBox(Me.components)
        Me.txtphno = New DefaultControls.MaskedBox(Me.components)
        Me.txtcountry = New DefaultControls.MaskedBox(Me.components)
        Me.txtcity = New DefaultControls.MaskedBox(Me.components)
        Me.txtlocationname = New DefaultControls.MaskedBox(Me.components)
        Me.txtloccode = New DefaultControls.MaskedBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnfirst = New System.Windows.Forms.ToolStripButton
        Me.btnprevious = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnnext = New System.Windows.Forms.ToolStripButton
        Me.btnlast = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnadd = New System.Windows.Forms.ToolStripButton
        Me.btndelete = New System.Windows.Forms.ToolStripButton
        Me.btnsave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmpname = New System.Windows.Forms.ToolStripLabel
        Me.txtlocnamefind = New System.Windows.Forms.ToolStripTextBox
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.bnvcmbCompany = New System.Windows.Forms.ToolStripComboBox
        Me.locationpanel.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_occupier
        '
        Me.lbl_occupier.AutoSize = True
        Me.lbl_occupier.Location = New System.Drawing.Point(428, 306)
        Me.lbl_occupier.Name = "lbl_occupier"
        Me.lbl_occupier.Size = New System.Drawing.Size(53, 13)
        Me.lbl_occupier.TabIndex = 29
        Me.lbl_occupier.Text = "Occupier:"
        '
        'lbl_owner
        '
        Me.lbl_owner.AutoSize = True
        Me.lbl_owner.Location = New System.Drawing.Point(11, 306)
        Me.lbl_owner.Name = "lbl_owner"
        Me.lbl_owner.Size = New System.Drawing.Size(41, 13)
        Me.lbl_owner.TabIndex = 27
        Me.lbl_owner.Text = "Owner:"
        '
        'lbl_locationnm
        '
        Me.lbl_locationnm.AutoSize = True
        Me.lbl_locationnm.Location = New System.Drawing.Point(11, 42)
        Me.lbl_locationnm.Name = "lbl_locationnm"
        Me.lbl_locationnm.Size = New System.Drawing.Size(86, 13)
        Me.lbl_locationnm.TabIndex = 24
        Me.lbl_locationnm.Text = "Location Name*:"
        '
        'lbl_faxno
        '
        Me.lbl_faxno.AutoSize = True
        Me.lbl_faxno.Location = New System.Drawing.Point(428, 201)
        Me.lbl_faxno.Name = "lbl_faxno"
        Me.lbl_faxno.Size = New System.Drawing.Size(44, 13)
        Me.lbl_faxno.TabIndex = 22
        Me.lbl_faxno.Text = "Fax No:"
        '
        'lbl_zipcode
        '
        Me.lbl_zipcode.AutoSize = True
        Me.lbl_zipcode.Location = New System.Drawing.Point(428, 165)
        Me.lbl_zipcode.Name = "lbl_zipcode"
        Me.lbl_zipcode.Size = New System.Drawing.Size(53, 13)
        Me.lbl_zipcode.TabIndex = 20
        Me.lbl_zipcode.Text = "Zip Code:"
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.Location = New System.Drawing.Point(428, 129)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(35, 13)
        Me.lbl_state.TabIndex = 18
        Me.lbl_state.Text = "State:"
        '
        'lbl_authonm
        '
        Me.lbl_authonm.AutoSize = True
        Me.lbl_authonm.Location = New System.Drawing.Point(11, 273)
        Me.lbl_authonm.Name = "lbl_authonm"
        Me.lbl_authonm.Size = New System.Drawing.Size(91, 13)
        Me.lbl_authonm.TabIndex = 16
        Me.lbl_authonm.Text = "Authorized Name:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(11, 238)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 14
        Me.lbl_email.Text = "E-mail:"
        '
        'lbl_phno
        '
        Me.lbl_phno.AutoSize = True
        Me.lbl_phno.Location = New System.Drawing.Point(11, 201)
        Me.lbl_phno.Name = "lbl_phno"
        Me.lbl_phno.Size = New System.Drawing.Size(58, 13)
        Me.lbl_phno.TabIndex = 12
        Me.lbl_phno.Text = "Phone No:"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Location = New System.Drawing.Point(11, 165)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(50, 13)
        Me.lbl_country.TabIndex = 10
        Me.lbl_country.Text = "Country:*"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Location = New System.Drawing.Point(11, 129)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(31, 13)
        Me.lbl_city.TabIndex = 8
        Me.lbl_city.Text = "City:*"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Location = New System.Drawing.Point(11, 71)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(52, 13)
        Me.lbl_address.TabIndex = 6
        Me.lbl_address.Text = "Address:*"
        '
        'locationpanel
        '
        Me.locationpanel.Controls.Add(Me.txtaddress)
        Me.locationpanel.Controls.Add(Me.txtoccupier)
        Me.locationpanel.Controls.Add(Me.txtowner)
        Me.locationpanel.Controls.Add(Me.txtauthnm)
        Me.locationpanel.Controls.Add(Me.txtemail)
        Me.locationpanel.Controls.Add(Me.txtfaxno)
        Me.locationpanel.Controls.Add(Me.txtzipcode)
        Me.locationpanel.Controls.Add(Me.txtstate)
        Me.locationpanel.Controls.Add(Me.txtphno)
        Me.locationpanel.Controls.Add(Me.txtcountry)
        Me.locationpanel.Controls.Add(Me.txtcity)
        Me.locationpanel.Controls.Add(Me.txtlocationname)
        Me.locationpanel.Controls.Add(Me.txtloccode)
        Me.locationpanel.Controls.Add(Me.Label1)
        Me.locationpanel.Controls.Add(Me.lbl_occupier)
        Me.locationpanel.Controls.Add(Me.lbl_owner)
        Me.locationpanel.Controls.Add(Me.lbl_locationnm)
        Me.locationpanel.Controls.Add(Me.lbl_faxno)
        Me.locationpanel.Controls.Add(Me.lbl_zipcode)
        Me.locationpanel.Controls.Add(Me.lbl_state)
        Me.locationpanel.Controls.Add(Me.lbl_authonm)
        Me.locationpanel.Controls.Add(Me.lbl_email)
        Me.locationpanel.Controls.Add(Me.lbl_phno)
        Me.locationpanel.Controls.Add(Me.lbl_country)
        Me.locationpanel.Controls.Add(Me.lbl_city)
        Me.locationpanel.Controls.Add(Me.lbl_address)
        Me.locationpanel.Location = New System.Drawing.Point(24, 46)
        Me.locationpanel.Name = "locationpanel"
        Me.locationpanel.Size = New System.Drawing.Size(910, 351)
        Me.locationpanel.TabIndex = 3
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(132, 71)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtaddress.Size = New System.Drawing.Size(605, 40)
        Me.txtaddress.TabIndex = 2
        '
        'txtoccupier
        '
        Me.txtoccupier.CheckBounds = False
        Me.txtoccupier.DateFormat = Nothing
        Me.txtoccupier.DecimalPlaces = CType(0, Byte)
        Me.txtoccupier.Location = New System.Drawing.Point(516, 303)
        Me.txtoccupier.MaxDate = New Date(CType(0, Long))
        Me.txtoccupier.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtoccupier.MinDate = New Date(CType(0, Long))
        Me.txtoccupier.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtoccupier.Name = "txtoccupier"
        Me.txtoccupier.Size = New System.Drawing.Size(221, 20)
        Me.txtoccupier.TabIndex = 12
        Me.txtoccupier.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtowner
        '
        Me.txtowner.CheckBounds = False
        Me.txtowner.DateFormat = Nothing
        Me.txtowner.DecimalPlaces = CType(0, Byte)
        Me.txtowner.Location = New System.Drawing.Point(132, 303)
        Me.txtowner.MaxDate = New Date(CType(0, Long))
        Me.txtowner.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtowner.MinDate = New Date(CType(0, Long))
        Me.txtowner.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtowner.Name = "txtowner"
        Me.txtowner.Size = New System.Drawing.Size(221, 20)
        Me.txtowner.TabIndex = 11
        Me.txtowner.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtauthnm
        '
        Me.txtauthnm.CheckBounds = False
        Me.txtauthnm.DateFormat = Nothing
        Me.txtauthnm.DecimalPlaces = CType(0, Byte)
        Me.txtauthnm.Location = New System.Drawing.Point(132, 270)
        Me.txtauthnm.MaxDate = New Date(CType(0, Long))
        Me.txtauthnm.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtauthnm.MinDate = New Date(CType(0, Long))
        Me.txtauthnm.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtauthnm.Name = "txtauthnm"
        Me.txtauthnm.Size = New System.Drawing.Size(605, 20)
        Me.txtauthnm.TabIndex = 10
        Me.txtauthnm.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtemail
        '
        Me.txtemail.CheckBounds = False
        Me.txtemail.DateFormat = Nothing
        Me.txtemail.DecimalPlaces = CType(0, Byte)
        Me.txtemail.Location = New System.Drawing.Point(132, 235)
        Me.txtemail.MaxDate = New Date(CType(0, Long))
        Me.txtemail.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemail.MinDate = New Date(CType(0, Long))
        Me.txtemail.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(605, 20)
        Me.txtemail.TabIndex = 9
        Me.txtemail.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_EMails
        '
        'txtfaxno
        '
        Me.txtfaxno.CheckBounds = False
        Me.txtfaxno.DateFormat = Nothing
        Me.txtfaxno.DecimalPlaces = CType(0, Byte)
        Me.txtfaxno.Location = New System.Drawing.Point(516, 198)
        Me.txtfaxno.MaxDate = New Date(CType(0, Long))
        Me.txtfaxno.MaxLength = 15
        Me.txtfaxno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfaxno.MinDate = New Date(CType(0, Long))
        Me.txtfaxno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfaxno.Name = "txtfaxno"
        Me.txtfaxno.Size = New System.Drawing.Size(221, 20)
        Me.txtfaxno.TabIndex = 8
        Me.txtfaxno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtzipcode
        '
        Me.txtzipcode.CheckBounds = False
        Me.txtzipcode.DateFormat = Nothing
        Me.txtzipcode.DecimalPlaces = CType(0, Byte)
        Me.txtzipcode.Location = New System.Drawing.Point(516, 162)
        Me.txtzipcode.MaxDate = New Date(CType(0, Long))
        Me.txtzipcode.MaxLength = 6
        Me.txtzipcode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtzipcode.MinDate = New Date(CType(0, Long))
        Me.txtzipcode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtzipcode.Name = "txtzipcode"
        Me.txtzipcode.Size = New System.Drawing.Size(221, 20)
        Me.txtzipcode.TabIndex = 7
        Me.txtzipcode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtstate
        '
        Me.txtstate.CheckBounds = False
        Me.txtstate.DateFormat = Nothing
        Me.txtstate.DecimalPlaces = CType(0, Byte)
        Me.txtstate.Location = New System.Drawing.Point(516, 126)
        Me.txtstate.MaxDate = New Date(CType(0, Long))
        Me.txtstate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtstate.MinDate = New Date(CType(0, Long))
        Me.txtstate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(221, 20)
        Me.txtstate.TabIndex = 6
        Me.txtstate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtphno
        '
        Me.txtphno.CheckBounds = False
        Me.txtphno.DateFormat = Nothing
        Me.txtphno.DecimalPlaces = CType(0, Byte)
        Me.txtphno.Location = New System.Drawing.Point(132, 198)
        Me.txtphno.MaxDate = New Date(CType(0, Long))
        Me.txtphno.MaxLength = 12
        Me.txtphno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtphno.MinDate = New Date(CType(0, Long))
        Me.txtphno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtphno.Name = "txtphno"
        Me.txtphno.Size = New System.Drawing.Size(221, 20)
        Me.txtphno.TabIndex = 5
        Me.txtphno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtcountry
        '
        Me.txtcountry.CheckBounds = False
        Me.txtcountry.DateFormat = Nothing
        Me.txtcountry.DecimalPlaces = CType(0, Byte)
        Me.txtcountry.Location = New System.Drawing.Point(132, 162)
        Me.txtcountry.MaxDate = New Date(CType(0, Long))
        Me.txtcountry.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcountry.MinDate = New Date(CType(0, Long))
        Me.txtcountry.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(221, 20)
        Me.txtcountry.TabIndex = 4
        Me.txtcountry.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtcity
        '
        Me.txtcity.CheckBounds = False
        Me.txtcity.DateFormat = Nothing
        Me.txtcity.DecimalPlaces = CType(0, Byte)
        Me.txtcity.Location = New System.Drawing.Point(132, 126)
        Me.txtcity.MaxDate = New Date(CType(0, Long))
        Me.txtcity.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.MinDate = New Date(CType(0, Long))
        Me.txtcity.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(221, 20)
        Me.txtcity.TabIndex = 3
        Me.txtcity.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtlocationname
        '
        Me.txtlocationname.CheckBounds = False
        Me.txtlocationname.DateFormat = Nothing
        Me.txtlocationname.DecimalPlaces = CType(0, Byte)
        Me.txtlocationname.Location = New System.Drawing.Point(132, 39)
        Me.txtlocationname.MaxDate = New Date(CType(0, Long))
        Me.txtlocationname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlocationname.MinDate = New Date(CType(0, Long))
        Me.txtlocationname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlocationname.Name = "txtlocationname"
        Me.txtlocationname.Size = New System.Drawing.Size(221, 20)
        Me.txtlocationname.TabIndex = 1
        Me.txtlocationname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtloccode
        '
        Me.txtloccode.CheckBounds = False
        Me.txtloccode.DateFormat = Nothing
        Me.txtloccode.DecimalPlaces = CType(0, Byte)
        Me.txtloccode.Location = New System.Drawing.Point(132, 10)
        Me.txtloccode.MaxDate = New Date(CType(0, Long))
        Me.txtloccode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtloccode.MinDate = New Date(CType(0, Long))
        Me.txtloccode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtloccode.Name = "txtloccode"
        Me.txtloccode.Size = New System.Drawing.Size(221, 20)
        Me.txtloccode.TabIndex = 0
        Me.txtloccode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Location Code*:"
        '
        'btnfirst
        '
        Me.btnfirst.Image = CType(resources.GetObject("btnfirst.Image"), System.Drawing.Image)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.RightToLeftAutoMirrorImage = True
        Me.btnfirst.Size = New System.Drawing.Size(49, 22)
        Me.btnfirst.Text = "&First"
        '
        'btnprevious
        '
        Me.btnprevious.Image = CType(resources.GetObject("btnprevious.Image"), System.Drawing.Image)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.RightToLeftAutoMirrorImage = True
        Me.btnprevious.Size = New System.Drawing.Size(72, 22)
        Me.btnprevious.Text = "&Previous"
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
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
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
        Me.btnnext.Size = New System.Drawing.Size(51, 22)
        Me.btnnext.Text = "&Next"
        '
        'btnlast
        '
        Me.btnlast.Image = CType(resources.GetObject("btnlast.Image"), System.Drawing.Image)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.RightToLeftAutoMirrorImage = True
        Me.btnlast.Size = New System.Drawing.Size(48, 22)
        Me.btnlast.Text = "&Last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.RightToLeftAutoMirrorImage = True
        Me.btnadd.Size = New System.Drawing.Size(74, 22)
        Me.btnadd.Text = "&Add new"
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.RightToLeftAutoMirrorImage = True
        Me.btndelete.Size = New System.Drawing.Size(60, 22)
        Me.btndelete.Text = "&Delete"
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
        'cmpname
        '
        Me.cmpname.Name = "cmpname"
        Me.cmpname.Size = New System.Drawing.Size(94, 22)
        Me.cmpname.Text = "L&ocation  Name:"
        '
        'txtlocnamefind
        '
        Me.txtlocnamefind.Name = "txtlocnamefind"
        Me.txtlocnamefind.Size = New System.Drawing.Size(100, 25)
        Me.txtlocnamefind.Text = "%"
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(50, 20)
        Me.btnfind.Text = "F&ind"
        Me.btnfind.ToolTipText = "Search"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.btnadd
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.btndelete
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.bnvcmbCompany, Me.cmpname, Me.txtlocnamefind, Me.btnfind})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnfirst
        Me.BindingNavigator1.MoveLastItem = Me.btnlast
        Me.BindingNavigator1.MoveNextItem = Me.btnnext
        Me.BindingNavigator1.MovePreviousItem = Me.btnprevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(972, 25)
        Me.BindingNavigator1.TabIndex = 7
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripLabel1.Text = "&Company Name:"
        '
        'bnvcmbCompany
        '
        Me.bnvcmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bnvcmbCompany.Name = "bnvcmbCompany"
        Me.bnvcmbCompany.Size = New System.Drawing.Size(121, 25)
        '
        'frm_location
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 413)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.locationpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_location"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location"
        Me.locationpanel.ResumeLayout(False)
        Me.locationpanel.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_occupier As System.Windows.Forms.Label
    Friend WithEvents lbl_owner As System.Windows.Forms.Label
    Friend WithEvents lbl_locationnm As System.Windows.Forms.Label
    Friend WithEvents lbl_faxno As System.Windows.Forms.Label
    Friend WithEvents lbl_zipcode As System.Windows.Forms.Label
    Friend WithEvents lbl_state As System.Windows.Forms.Label
    Friend WithEvents lbl_authonm As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_phno As System.Windows.Forms.Label
    Friend WithEvents lbl_country As System.Windows.Forms.Label
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents locationpanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnfirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnprevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnnext As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnlast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnadd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmpname As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtlocnamefind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents bnvcmbCompany As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtloccode As DefaultControls.MaskedBox
    Friend WithEvents txtlocationname As DefaultControls.MaskedBox
    Friend WithEvents txtcity As DefaultControls.MaskedBox
    Friend WithEvents txtphno As DefaultControls.MaskedBox
    Friend WithEvents txtcountry As DefaultControls.MaskedBox
    Friend WithEvents txtfaxno As DefaultControls.MaskedBox
    Friend WithEvents txtzipcode As DefaultControls.MaskedBox
    Friend WithEvents txtstate As DefaultControls.MaskedBox
    Friend WithEvents txtoccupier As DefaultControls.MaskedBox
    Friend WithEvents txtowner As DefaultControls.MaskedBox
    Friend WithEvents txtauthnm As DefaultControls.MaskedBox
    Friend WithEvents txtemail As DefaultControls.MaskedBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox

End Class
