<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_company
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_company))
        Me.companypanel = New System.Windows.Forms.Panel
        Me.txtfaxno = New DefaultControls.MaskedBox(Me.components)
        Me.txtzipcode = New DefaultControls.MaskedBox(Me.components)
        Me.txtstate = New DefaultControls.MaskedBox(Me.components)
        Me.txtwebsite = New DefaultControls.MaskedBox(Me.components)
        Me.txtemail = New DefaultControls.MaskedBox(Me.components)
        Me.txtphno = New DefaultControls.MaskedBox(Me.components)
        Me.txtcountry = New DefaultControls.MaskedBox(Me.components)
        Me.txtcity = New DefaultControls.MaskedBox(Me.components)
        Me.txtcmpname = New DefaultControls.MaskedBox(Me.components)
        Me.txtcmpcode = New DefaultControls.MaskedBox(Me.components)
        Me.lbl_faxno = New System.Windows.Forms.Label
        Me.lbl_zipcode = New System.Windows.Forms.Label
        Me.lbl_state = New System.Windows.Forms.Label
        Me.lbl_website = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_phno = New System.Windows.Forms.Label
        Me.lbl_country = New System.Windows.Forms.Label
        Me.lbl_city = New System.Windows.Forms.Label
        Me.lbl_address = New System.Windows.Forms.Label
        Me.lbl_cmpname = New System.Windows.Forms.Label
        Me.lbl_cmpcode = New System.Windows.Forms.Label
        Me.bnvcompany = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.cmpname = New System.Windows.Forms.ToolStripLabel
        Me.txtcmpnamefind = New System.Windows.Forms.ToolStripTextBox
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.companypanel.SuspendLayout()
        CType(Me.bnvcompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnvcompany.SuspendLayout()
        Me.SuspendLayout()
        '
        'companypanel
        '
        Me.companypanel.Controls.Add(Me.txtaddress)
        Me.companypanel.Controls.Add(Me.txtfaxno)
        Me.companypanel.Controls.Add(Me.txtzipcode)
        Me.companypanel.Controls.Add(Me.txtstate)
        Me.companypanel.Controls.Add(Me.txtwebsite)
        Me.companypanel.Controls.Add(Me.txtemail)
        Me.companypanel.Controls.Add(Me.txtphno)
        Me.companypanel.Controls.Add(Me.txtcountry)
        Me.companypanel.Controls.Add(Me.txtcity)
        Me.companypanel.Controls.Add(Me.txtcmpname)
        Me.companypanel.Controls.Add(Me.txtcmpcode)
        Me.companypanel.Controls.Add(Me.lbl_faxno)
        Me.companypanel.Controls.Add(Me.lbl_zipcode)
        Me.companypanel.Controls.Add(Me.lbl_state)
        Me.companypanel.Controls.Add(Me.lbl_website)
        Me.companypanel.Controls.Add(Me.lbl_email)
        Me.companypanel.Controls.Add(Me.lbl_phno)
        Me.companypanel.Controls.Add(Me.lbl_country)
        Me.companypanel.Controls.Add(Me.lbl_city)
        Me.companypanel.Controls.Add(Me.lbl_address)
        Me.companypanel.Controls.Add(Me.lbl_cmpname)
        Me.companypanel.Controls.Add(Me.lbl_cmpcode)
        Me.companypanel.Location = New System.Drawing.Point(12, 38)
        Me.companypanel.Name = "companypanel"
        Me.companypanel.Size = New System.Drawing.Size(767, 347)
        Me.companypanel.TabIndex = 30
        '
        'txtfaxno
        '
        Me.txtfaxno.CheckBounds = False
        Me.txtfaxno.DateFormat = Nothing
        Me.txtfaxno.DecimalPlaces = CType(0, Byte)
        Me.txtfaxno.Location = New System.Drawing.Point(524, 223)
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
        Me.txtzipcode.Location = New System.Drawing.Point(524, 187)
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
        Me.txtstate.Location = New System.Drawing.Point(524, 153)
        Me.txtstate.MaxDate = New Date(CType(0, Long))
        Me.txtstate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtstate.MinDate = New Date(CType(0, Long))
        Me.txtstate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(221, 20)
        Me.txtstate.TabIndex = 6
        Me.txtstate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtwebsite
        '
        Me.txtwebsite.CheckBounds = False
        Me.txtwebsite.DateFormat = Nothing
        Me.txtwebsite.DecimalPlaces = CType(0, Byte)
        Me.txtwebsite.Location = New System.Drawing.Point(140, 294)
        Me.txtwebsite.MaxDate = New Date(CType(0, Long))
        Me.txtwebsite.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtwebsite.MinDate = New Date(CType(0, Long))
        Me.txtwebsite.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtwebsite.Name = "txtwebsite"
        Me.txtwebsite.Size = New System.Drawing.Size(605, 20)
        Me.txtwebsite.TabIndex = 10
        Me.txtwebsite.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtemail
        '
        Me.txtemail.CheckBounds = False
        Me.txtemail.DateFormat = Nothing
        Me.txtemail.DecimalPlaces = CType(0, Byte)
        Me.txtemail.Location = New System.Drawing.Point(140, 256)
        Me.txtemail.MaxDate = New Date(CType(0, Long))
        Me.txtemail.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemail.MinDate = New Date(CType(0, Long))
        Me.txtemail.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(605, 20)
        Me.txtemail.TabIndex = 9
        Me.txtemail.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_EMails
        '
        'txtphno
        '
        Me.txtphno.CheckBounds = False
        Me.txtphno.DateFormat = Nothing
        Me.txtphno.DecimalPlaces = CType(0, Byte)
        Me.txtphno.Location = New System.Drawing.Point(140, 223)
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
        Me.txtcountry.Location = New System.Drawing.Point(140, 187)
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
        Me.txtcity.Location = New System.Drawing.Point(140, 153)
        Me.txtcity.MaxDate = New Date(CType(0, Long))
        Me.txtcity.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.MinDate = New Date(CType(0, Long))
        Me.txtcity.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(221, 20)
        Me.txtcity.TabIndex = 3
        Me.txtcity.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtcmpname
        '
        Me.txtcmpname.CheckBounds = False
        Me.txtcmpname.DateFormat = Nothing
        Me.txtcmpname.DecimalPlaces = CType(0, Byte)
        Me.txtcmpname.Location = New System.Drawing.Point(140, 46)
        Me.txtcmpname.MaxDate = New Date(CType(0, Long))
        Me.txtcmpname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcmpname.MinDate = New Date(CType(0, Long))
        Me.txtcmpname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcmpname.Name = "txtcmpname"
        Me.txtcmpname.Size = New System.Drawing.Size(605, 20)
        Me.txtcmpname.TabIndex = 1
        Me.txtcmpname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtcmpcode
        '
        Me.txtcmpcode.CheckBounds = False
        Me.txtcmpcode.DateFormat = Nothing
        Me.txtcmpcode.DecimalPlaces = CType(0, Byte)
        Me.txtcmpcode.Location = New System.Drawing.Point(140, 10)
        Me.txtcmpcode.MaxDate = New Date(CType(0, Long))
        Me.txtcmpcode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcmpcode.MinDate = New Date(CType(0, Long))
        Me.txtcmpcode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcmpcode.Name = "txtcmpcode"
        Me.txtcmpcode.Size = New System.Drawing.Size(221, 20)
        Me.txtcmpcode.TabIndex = 0
        Me.txtcmpcode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lbl_faxno
        '
        Me.lbl_faxno.AutoSize = True
        Me.lbl_faxno.Location = New System.Drawing.Point(436, 230)
        Me.lbl_faxno.Name = "lbl_faxno"
        Me.lbl_faxno.Size = New System.Drawing.Size(44, 13)
        Me.lbl_faxno.TabIndex = 22
        Me.lbl_faxno.Text = "Fax No:"
        '
        'lbl_zipcode
        '
        Me.lbl_zipcode.AutoSize = True
        Me.lbl_zipcode.Location = New System.Drawing.Point(436, 194)
        Me.lbl_zipcode.Name = "lbl_zipcode"
        Me.lbl_zipcode.Size = New System.Drawing.Size(53, 13)
        Me.lbl_zipcode.TabIndex = 20
        Me.lbl_zipcode.Text = "Zip Code:"
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.Location = New System.Drawing.Point(436, 156)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(35, 13)
        Me.lbl_state.TabIndex = 18
        Me.lbl_state.Text = "State:"
        '
        'lbl_website
        '
        Me.lbl_website.AutoSize = True
        Me.lbl_website.Location = New System.Drawing.Point(20, 297)
        Me.lbl_website.Name = "lbl_website"
        Me.lbl_website.Size = New System.Drawing.Size(49, 13)
        Me.lbl_website.TabIndex = 16
        Me.lbl_website.Text = "Website:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(20, 259)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 14
        Me.lbl_email.Text = "E-mail:"
        '
        'lbl_phno
        '
        Me.lbl_phno.AutoSize = True
        Me.lbl_phno.Location = New System.Drawing.Point(20, 226)
        Me.lbl_phno.Name = "lbl_phno"
        Me.lbl_phno.Size = New System.Drawing.Size(58, 13)
        Me.lbl_phno.TabIndex = 12
        Me.lbl_phno.Text = "Phone No:"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.Location = New System.Drawing.Point(20, 190)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(50, 13)
        Me.lbl_country.TabIndex = 10
        Me.lbl_country.Text = "Country:*"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Location = New System.Drawing.Point(20, 156)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(31, 13)
        Me.lbl_city.TabIndex = 8
        Me.lbl_city.Text = "City:*"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Location = New System.Drawing.Point(20, 87)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(52, 13)
        Me.lbl_address.TabIndex = 6
        Me.lbl_address.Text = "Address:*"
        '
        'lbl_cmpname
        '
        Me.lbl_cmpname.AutoSize = True
        Me.lbl_cmpname.Location = New System.Drawing.Point(20, 47)
        Me.lbl_cmpname.Name = "lbl_cmpname"
        Me.lbl_cmpname.Size = New System.Drawing.Size(89, 13)
        Me.lbl_cmpname.TabIndex = 4
        Me.lbl_cmpname.Text = "Company Name:*"
        '
        'lbl_cmpcode
        '
        Me.lbl_cmpcode.AutoSize = True
        Me.lbl_cmpcode.Location = New System.Drawing.Point(20, 13)
        Me.lbl_cmpcode.Name = "lbl_cmpcode"
        Me.lbl_cmpcode.Size = New System.Drawing.Size(86, 13)
        Me.lbl_cmpcode.TabIndex = 2
        Me.lbl_cmpcode.Text = "Company Code:*"
        '
        'bnvcompany
        '
        Me.bnvcompany.AddNewItem = Me.btnadd
        Me.bnvcompany.CountItem = Me.BindingNavigatorCountItem1
        Me.bnvcompany.DeleteItem = Me.btndelete
        Me.bnvcompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave, Me.ToolStripSeparator1, Me.cmpname, Me.txtcmpnamefind, Me.btnfind})
        Me.bnvcompany.Location = New System.Drawing.Point(0, 0)
        Me.bnvcompany.MoveFirstItem = Me.btnfirst
        Me.bnvcompany.MoveLastItem = Me.btnlast
        Me.bnvcompany.MoveNextItem = Me.btnnext
        Me.bnvcompany.MovePreviousItem = Me.btnprevious
        Me.bnvcompany.Name = "bnvcompany"
        Me.bnvcompany.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bnvcompany.Size = New System.Drawing.Size(794, 25)
        Me.bnvcompany.TabIndex = 6
        Me.bnvcompany.Text = "BindingNavigator1"
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageTransparentColor = System.Drawing.Color.White
        Me.btnadd.Name = "btnadd"
        Me.btnadd.RightToLeftAutoMirrorImage = True
        Me.btnadd.Size = New System.Drawing.Size(69, 22)
        Me.btnadd.Text = "&Add new"
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
        Me.btnfirst.Size = New System.Drawing.Size(48, 22)
        Me.btnfirst.Text = "&First"
        '
        'btnprevious
        '
        Me.btnprevious.Image = CType(resources.GetObject("btnprevious.Image"), System.Drawing.Image)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.RightToLeftAutoMirrorImage = True
        Me.btnprevious.Size = New System.Drawing.Size(68, 22)
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
        Me.btnnext.Size = New System.Drawing.Size(50, 22)
        Me.btnnext.Text = "&Next"
        '
        'btnlast
        '
        Me.btnlast.Image = CType(resources.GetObject("btnlast.Image"), System.Drawing.Image)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.RightToLeftAutoMirrorImage = True
        Me.btnlast.Size = New System.Drawing.Size(47, 22)
        Me.btnlast.Text = "&Last"
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
        'cmpname
        '
        Me.cmpname.Name = "cmpname"
        Me.cmpname.Size = New System.Drawing.Size(86, 22)
        Me.cmpname.Text = "&Company Name:"
        '
        'txtcmpnamefind
        '
        Me.txtcmpnamefind.Name = "txtcmpnamefind"
        Me.txtcmpnamefind.Size = New System.Drawing.Size(100, 25)
        Me.txtcmpnamefind.Text = "%"
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
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(140, 84)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtaddress.Size = New System.Drawing.Size(605, 58)
        Me.txtaddress.TabIndex = 23
        '
        'frm_company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 401)
        Me.Controls.Add(Me.bnvcompany)
        Me.Controls.Add(Me.companypanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_company"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company"
        Me.companypanel.ResumeLayout(False)
        Me.companypanel.PerformLayout()
        CType(Me.bnvcompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnvcompany.ResumeLayout(False)
        Me.bnvcompany.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents companypanel As System.Windows.Forms.Panel
    Friend WithEvents lbl_faxno As System.Windows.Forms.Label
    Friend WithEvents lbl_zipcode As System.Windows.Forms.Label
    Friend WithEvents lbl_state As System.Windows.Forms.Label
    Friend WithEvents lbl_website As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_phno As System.Windows.Forms.Label
    Friend WithEvents lbl_country As System.Windows.Forms.Label
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_cmpname As System.Windows.Forms.Label
    Friend WithEvents lbl_cmpcode As System.Windows.Forms.Label
    Friend WithEvents bnvcompany As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmpname As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtcmpcode As DefaultControls.MaskedBox
    Friend WithEvents txtcmpname As DefaultControls.MaskedBox
    Friend WithEvents txtfaxno As DefaultControls.MaskedBox
    Friend WithEvents txtzipcode As DefaultControls.MaskedBox
    Friend WithEvents txtstate As DefaultControls.MaskedBox
    Friend WithEvents txtwebsite As DefaultControls.MaskedBox
    Friend WithEvents txtemail As DefaultControls.MaskedBox
    Friend WithEvents txtphno As DefaultControls.MaskedBox
    Friend WithEvents txtcountry As DefaultControls.MaskedBox
    Friend WithEvents txtcity As DefaultControls.MaskedBox
    Friend WithEvents txtcmpnamefind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
End Class
