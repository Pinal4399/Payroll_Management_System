<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_employee))
        Me.btnfamilydeatils = New System.Windows.Forms.Button
        Me.btnqualification = New System.Windows.Forms.Button
        Me.btnemphistory = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
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
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtempnamefind = New System.Windows.Forms.ToolStripTextBox
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.lblempcodefind = New System.Windows.Forms.ToolStripLabel
        Me.txtempcodefind = New System.Windows.Forms.ToolStripTextBox
        Me.btnearning = New System.Windows.Forms.Button
        Me.tabcontrol_empdetail = New System.Windows.Forms.TabControl
        Me.EmployeeDetails = New System.Windows.Forms.TabPage
        Me.panel_empdetail3 = New System.Windows.Forms.Panel
        Me.txtpermanentadd = New System.Windows.Forms.TextBox
        Me.txtpermntcity = New DefaultControls.MaskedBox(Me.components)
        Me.txtpermnttelephno = New DefaultControls.MaskedBox(Me.components)
        Me.txtpermntpinno = New DefaultControls.MaskedBox(Me.components)
        Me.txtpermntstate = New DefaultControls.MaskedBox(Me.components)
        Me.lblpermanentadd = New System.Windows.Forms.Label
        Me.lblpercity = New System.Windows.Forms.Label
        Me.lblperpinno = New System.Windows.Forms.Label
        Me.lblperteleno = New System.Windows.Forms.Label
        Me.lblperstate = New System.Windows.Forms.Label
        Me.panel_empdetail4S = New System.Windows.Forms.Panel
        Me.txtempsalary = New DefaultControls.MaskedBox(Me.components)
        Me.txtemailadd = New DefaultControls.MaskedBox(Me.components)
        Me.txtnationality = New DefaultControls.MaskedBox(Me.components)
        Me.txtbirthplace = New DefaultControls.MaskedBox(Me.components)
        Me.txtempage = New DefaultControls.MaskedBox(Me.components)
        Me.txtbirthdate = New DefaultControls.MaskedBox(Me.components)
        Me.txtmobileno = New DefaultControls.MaskedBox(Me.components)
        Me.cmbbloodgroup = New DefaultControls.ComboBox
        Me.cmbpayrolltype = New DefaultControls.ComboBox
        Me.lblempsalary = New System.Windows.Forms.Label
        Me.lblbloodgroup = New System.Windows.Forms.Label
        Me.lblemailadd = New System.Windows.Forms.Label
        Me.lblpayrolltype = New System.Windows.Forms.Label
        Me.lblnationality = New System.Windows.Forms.Label
        Me.lblbirthplace = New System.Windows.Forms.Label
        Me.lblbirthdate = New System.Windows.Forms.Label
        Me.lblmobileno = New System.Windows.Forms.Label
        Me.panel_empdetail2 = New System.Windows.Forms.Panel
        Me.txtcurrentadd = New System.Windows.Forms.TextBox
        Me.txtcurrentpinno = New DefaultControls.MaskedBox(Me.components)
        Me.txtcurrenttelephno = New DefaultControls.MaskedBox(Me.components)
        Me.txtcurrentstate = New DefaultControls.MaskedBox(Me.components)
        Me.txtcurrentcity = New DefaultControls.MaskedBox(Me.components)
        Me.btnsameaddresspass = New System.Windows.Forms.Button
        Me.lblpinno = New System.Windows.Forms.Label
        Me.lblstate = New System.Windows.Forms.Label
        Me.lbltelephno = New System.Windows.Forms.Label
        Me.lblcity = New System.Windows.Forms.Label
        Me.lblcurrentadd = New System.Windows.Forms.Label
        Me.panel_empdetail1 = New System.Windows.Forms.Panel
        Me.lblconfirm = New System.Windows.Forms.Label
        Me.txtcondate = New DefaultControls.MaskedBox(Me.components)
        Me.chkinactive = New DefaultControls.CheckBox
        Me.chkpermanent = New DefaultControls.CheckBox
        Me.txtempcode = New DefaultControls.MaskedBox(Me.components)
        Me.txtjoiningdate = New DefaultControls.MaskedBox(Me.components)
        Me.txtshortname = New DefaultControls.MaskedBox(Me.components)
        Me.txtlastname = New DefaultControls.MaskedBox(Me.components)
        Me.txtmiddlename = New DefaultControls.MaskedBox(Me.components)
        Me.txtfirstname = New DefaultControls.MaskedBox(Me.components)
        Me.cmbgender = New DefaultControls.ComboBox
        Me.cmbmartialstatus = New DefaultControls.ComboBox
        Me.cmbdepartmentnm = New DefaultControls.ComboBox
        Me.cmblocationname = New DefaultControls.ComboBox
        Me.lblempcode = New System.Windows.Forms.Label
        Me.lbldepartment = New System.Windows.Forms.Label
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnload = New System.Windows.Forms.Button
        Me.empphoto = New System.Windows.Forms.PictureBox
        Me.lbljoindate = New System.Windows.Forms.Label
        Me.lblmaritalsts = New System.Windows.Forms.Label
        Me.lblgender = New System.Windows.Forms.Label
        Me.lblshortname = New System.Windows.Forms.Label
        Me.lbllastname = New System.Windows.Forms.Label
        Me.lblmiddlename = New System.Windows.Forms.Label
        Me.lblfirstname = New System.Windows.Forms.Label
        Me.lbllocname = New System.Windows.Forms.Label
        Me.OtherDetails = New System.Windows.Forms.TabPage
        Me.txthobbies = New DefaultControls.MaskedBox(Me.components)
        Me.grp_incometax = New System.Windows.Forms.GroupBox
        Me.chkdisabled = New DefaultControls.CheckBox
        Me.txtpercentofdisabled = New DefaultControls.MaskedBox(Me.components)
        Me.txtdisablednote = New DefaultControls.MaskedBox(Me.components)
        Me.txtnoofchild = New DefaultControls.MaskedBox(Me.components)
        Me.txtPANno = New DefaultControls.MaskedBox(Me.components)
        Me.lblpanno = New System.Windows.Forms.Label
        Me.lblpercentdisabled = New System.Windows.Forms.Label
        Me.lbldisablednote = New System.Windows.Forms.Label
        Me.lblnoofchild = New System.Windows.Forms.Label
        Me.lblhobies = New System.Windows.Forms.Label
        Me.grp_vehicledetail = New System.Windows.Forms.GroupBox
        Me.txtrationcardno = New DefaultControls.MaskedBox(Me.components)
        Me.txtvehicleno = New DefaultControls.MaskedBox(Me.components)
        Me.txtvehicletype = New DefaultControls.MaskedBox(Me.components)
        Me.txtdrivinglicenseno = New DefaultControls.MaskedBox(Me.components)
        Me.txtvalidtill = New DefaultControls.MaskedBox(Me.components)
        Me.txtplaceofissue = New DefaultControls.MaskedBox(Me.components)
        Me.txtdateofissue = New DefaultControls.MaskedBox(Me.components)
        Me.txtpassportno = New DefaultControls.MaskedBox(Me.components)
        Me.lblrationno = New System.Windows.Forms.Label
        Me.lblvalidtill = New System.Windows.Forms.Label
        Me.lblvehicleno = New System.Windows.Forms.Label
        Me.lblissueplace = New System.Windows.Forms.Label
        Me.lblpassportno = New System.Windows.Forms.Label
        Me.lbllicenseno = New System.Windows.Forms.Label
        Me.lblvehicletype = New System.Windows.Forms.Label
        Me.lblissuedate = New System.Windows.Forms.Label
        Me.grp_bank_reference_detail = New System.Windows.Forms.GroupBox
        Me.txtbankacno = New DefaultControls.MaskedBox(Me.components)
        Me.txtreference2 = New DefaultControls.MaskedBox(Me.components)
        Me.txtreference1 = New DefaultControls.MaskedBox(Me.components)
        Me.cmbbankname = New DefaultControls.ComboBox
        Me.lblreference1 = New System.Windows.Forms.Label
        Me.lblreference2 = New System.Windows.Forms.Label
        Me.lblbankacno = New System.Windows.Forms.Label
        Me.lblbanknm = New System.Windows.Forms.Label
        Me.grp_otherdetail = New System.Windows.Forms.GroupBox
        Me.chkcivil = New DefaultControls.CheckBox
        Me.txtlitigationdetail = New DefaultControls.MaskedBox(Me.components)
        Me.txtrelieveddate = New DefaultControls.MaskedBox(Me.components)
        Me.txtjobprofile = New DefaultControls.MaskedBox(Me.components)
        Me.cmbleavereason = New DefaultControls.ComboBox
        Me.cmbempposition = New DefaultControls.ComboBox
        Me.lbllitigationdetail = New System.Windows.Forms.Label
        Me.lblleavereason = New System.Windows.Forms.Label
        Me.lblrelieveddate = New System.Windows.Forms.Label
        Me.lblpos = New System.Windows.Forms.Label
        Me.lbljobprofile = New System.Windows.Forms.Label
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.tabcontrol_empdetail.SuspendLayout()
        Me.EmployeeDetails.SuspendLayout()
        Me.panel_empdetail3.SuspendLayout()
        Me.panel_empdetail4S.SuspendLayout()
        Me.panel_empdetail2.SuspendLayout()
        Me.panel_empdetail1.SuspendLayout()
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OtherDetails.SuspendLayout()
        Me.grp_incometax.SuspendLayout()
        Me.grp_vehicledetail.SuspendLayout()
        Me.grp_bank_reference_detail.SuspendLayout()
        Me.grp_otherdetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnfamilydeatils
        '
        Me.btnfamilydeatils.Location = New System.Drawing.Point(526, 541)
        Me.btnfamilydeatils.Name = "btnfamilydeatils"
        Me.btnfamilydeatils.Size = New System.Drawing.Size(100, 35)
        Me.btnfamilydeatils.TabIndex = 36
        Me.btnfamilydeatils.Text = "Fa&mily Details"
        Me.btnfamilydeatils.UseVisualStyleBackColor = True
        '
        'btnqualification
        '
        Me.btnqualification.Location = New System.Drawing.Point(672, 541)
        Me.btnqualification.Name = "btnqualification"
        Me.btnqualification.Size = New System.Drawing.Size(100, 35)
        Me.btnqualification.TabIndex = 37
        Me.btnqualification.Text = "&Qualification"
        Me.btnqualification.UseVisualStyleBackColor = True
        '
        'btnemphistory
        '
        Me.btnemphistory.Location = New System.Drawing.Point(818, 541)
        Me.btnemphistory.Name = "btnemphistory"
        Me.btnemphistory.Size = New System.Drawing.Size(100, 35)
        Me.btnemphistory.TabIndex = 38
        Me.btnemphistory.Text = "Employee &History"
        Me.btnemphistory.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.btnsave.Size = New System.Drawing.Size(47, 22)
        Me.btnsave.Text = "&Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripLabel1.Text = "Emplo&yee Name:"
        '
        'txtempnamefind
        '
        Me.txtempnamefind.Name = "txtempnamefind"
        Me.txtempnamefind.Size = New System.Drawing.Size(100, 25)
        Me.txtempnamefind.Text = "%"
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
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txtempnamefind, Me.lblempcodefind, Me.txtempcodefind, Me.btnfind})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnfirst
        Me.BindingNavigator1.MoveLastItem = Me.btnlast
        Me.BindingNavigator1.MoveNextItem = Me.btnnext
        Me.BindingNavigator1.MovePreviousItem = Me.btnprevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(947, 25)
        Me.BindingNavigator1.TabIndex = 9
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'lblempcodefind
        '
        Me.lblempcodefind.Name = "lblempcodefind"
        Me.lblempcodefind.Size = New System.Drawing.Size(93, 22)
        Me.lblempcodefind.Text = "Employee &Code:"
        '
        'txtempcodefind
        '
        Me.txtempcodefind.Name = "txtempcodefind"
        Me.txtempcodefind.Size = New System.Drawing.Size(100, 25)
        Me.txtempcodefind.Text = "%"
        '
        'btnearning
        '
        Me.btnearning.Location = New System.Drawing.Point(380, 541)
        Me.btnearning.Name = "btnearning"
        Me.btnearning.Size = New System.Drawing.Size(100, 35)
        Me.btnearning.TabIndex = 35
        Me.btnearning.Text = "Earnin&gs"
        Me.btnearning.UseVisualStyleBackColor = True
        '
        'tabcontrol_empdetail
        '
        Me.tabcontrol_empdetail.Controls.Add(Me.EmployeeDetails)
        Me.tabcontrol_empdetail.Controls.Add(Me.OtherDetails)
        Me.tabcontrol_empdetail.Location = New System.Drawing.Point(12, 32)
        Me.tabcontrol_empdetail.Name = "tabcontrol_empdetail"
        Me.tabcontrol_empdetail.SelectedIndex = 0
        Me.tabcontrol_empdetail.Size = New System.Drawing.Size(923, 508)
        Me.tabcontrol_empdetail.TabIndex = 37
        '
        'EmployeeDetails
        '
        Me.EmployeeDetails.Controls.Add(Me.panel_empdetail3)
        Me.EmployeeDetails.Controls.Add(Me.panel_empdetail4S)
        Me.EmployeeDetails.Controls.Add(Me.panel_empdetail2)
        Me.EmployeeDetails.Controls.Add(Me.panel_empdetail1)
        Me.EmployeeDetails.Location = New System.Drawing.Point(4, 22)
        Me.EmployeeDetails.Name = "EmployeeDetails"
        Me.EmployeeDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.EmployeeDetails.Size = New System.Drawing.Size(915, 482)
        Me.EmployeeDetails.TabIndex = 0
        Me.EmployeeDetails.Text = "Employee Details"
        Me.EmployeeDetails.UseVisualStyleBackColor = True
        '
        'panel_empdetail3
        '
        Me.panel_empdetail3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_empdetail3.Controls.Add(Me.txtpermanentadd)
        Me.panel_empdetail3.Controls.Add(Me.txtpermntcity)
        Me.panel_empdetail3.Controls.Add(Me.txtpermnttelephno)
        Me.panel_empdetail3.Controls.Add(Me.txtpermntpinno)
        Me.panel_empdetail3.Controls.Add(Me.txtpermntstate)
        Me.panel_empdetail3.Controls.Add(Me.lblpermanentadd)
        Me.panel_empdetail3.Controls.Add(Me.lblpercity)
        Me.panel_empdetail3.Controls.Add(Me.lblperpinno)
        Me.panel_empdetail3.Controls.Add(Me.lblperteleno)
        Me.panel_empdetail3.Controls.Add(Me.lblperstate)
        Me.panel_empdetail3.Location = New System.Drawing.Point(456, 204)
        Me.panel_empdetail3.Name = "panel_empdetail3"
        Me.panel_empdetail3.Size = New System.Drawing.Size(453, 147)
        Me.panel_empdetail3.TabIndex = 2
        '
        'txtpermanentadd
        '
        Me.txtpermanentadd.Location = New System.Drawing.Point(117, 15)
        Me.txtpermanentadd.Multiline = True
        Me.txtpermanentadd.Name = "txtpermanentadd"
        Me.txtpermanentadd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtpermanentadd.Size = New System.Drawing.Size(320, 55)
        Me.txtpermanentadd.TabIndex = 21
        '
        'txtpermntcity
        '
        Me.txtpermntcity.CheckBounds = False
        Me.txtpermntcity.DateFormat = Nothing
        Me.txtpermntcity.DecimalPlaces = CType(0, Byte)
        Me.txtpermntcity.Location = New System.Drawing.Point(115, 84)
        Me.txtpermntcity.MaxDate = New Date(CType(0, Long))
        Me.txtpermntcity.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpermntcity.MinDate = New Date(CType(0, Long))
        Me.txtpermntcity.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpermntcity.Name = "txtpermntcity"
        Me.txtpermntcity.Size = New System.Drawing.Size(122, 20)
        Me.txtpermntcity.TabIndex = 22
        Me.txtpermntcity.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtpermnttelephno
        '
        Me.txtpermnttelephno.CheckBounds = False
        Me.txtpermnttelephno.DateFormat = Nothing
        Me.txtpermnttelephno.DecimalPlaces = CType(0, Byte)
        Me.txtpermnttelephno.Location = New System.Drawing.Point(115, 113)
        Me.txtpermnttelephno.MaxDate = New Date(CType(0, Long))
        Me.txtpermnttelephno.MaxLength = 12
        Me.txtpermnttelephno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpermnttelephno.MinDate = New Date(CType(0, Long))
        Me.txtpermnttelephno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpermnttelephno.Name = "txtpermnttelephno"
        Me.txtpermnttelephno.Size = New System.Drawing.Size(122, 20)
        Me.txtpermnttelephno.TabIndex = 24
        Me.txtpermnttelephno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtpermntpinno
        '
        Me.txtpermntpinno.CheckBounds = False
        Me.txtpermntpinno.DateFormat = Nothing
        Me.txtpermntpinno.DecimalPlaces = CType(0, Byte)
        Me.txtpermntpinno.Location = New System.Drawing.Point(315, 113)
        Me.txtpermntpinno.MaxDate = New Date(CType(0, Long))
        Me.txtpermntpinno.MaxLength = 6
        Me.txtpermntpinno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpermntpinno.MinDate = New Date(CType(0, Long))
        Me.txtpermntpinno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpermntpinno.Name = "txtpermntpinno"
        Me.txtpermntpinno.Size = New System.Drawing.Size(122, 20)
        Me.txtpermntpinno.TabIndex = 25
        Me.txtpermntpinno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtpermntstate
        '
        Me.txtpermntstate.CheckBounds = False
        Me.txtpermntstate.DateFormat = Nothing
        Me.txtpermntstate.DecimalPlaces = CType(0, Byte)
        Me.txtpermntstate.Location = New System.Drawing.Point(315, 84)
        Me.txtpermntstate.MaxDate = New Date(CType(0, Long))
        Me.txtpermntstate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpermntstate.MinDate = New Date(CType(0, Long))
        Me.txtpermntstate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpermntstate.Name = "txtpermntstate"
        Me.txtpermntstate.Size = New System.Drawing.Size(122, 20)
        Me.txtpermntstate.TabIndex = 23
        Me.txtpermntstate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'lblpermanentadd
        '
        Me.lblpermanentadd.AutoSize = True
        Me.lblpermanentadd.Location = New System.Drawing.Point(3, 13)
        Me.lblpermanentadd.Name = "lblpermanentadd"
        Me.lblpermanentadd.Size = New System.Drawing.Size(106, 13)
        Me.lblpermanentadd.TabIndex = 29
        Me.lblpermanentadd.Text = "Permanent Address*:"
        '
        'lblpercity
        '
        Me.lblpercity.AutoSize = True
        Me.lblpercity.Location = New System.Drawing.Point(3, 87)
        Me.lblpercity.Name = "lblpercity"
        Me.lblpercity.Size = New System.Drawing.Size(31, 13)
        Me.lblpercity.TabIndex = 29
        Me.lblpercity.Text = "City*:"
        '
        'lblperpinno
        '
        Me.lblperpinno.AutoSize = True
        Me.lblperpinno.Location = New System.Drawing.Point(248, 116)
        Me.lblperpinno.Name = "lblperpinno"
        Me.lblperpinno.Size = New System.Drawing.Size(48, 13)
        Me.lblperpinno.TabIndex = 32
        Me.lblperpinno.Text = "PIN No.:"
        '
        'lblperteleno
        '
        Me.lblperteleno.AutoSize = True
        Me.lblperteleno.Location = New System.Drawing.Point(3, 116)
        Me.lblperteleno.Name = "lblperteleno"
        Me.lblperteleno.Size = New System.Drawing.Size(81, 13)
        Me.lblperteleno.TabIndex = 30
        Me.lblperteleno.Text = "Telephone No.:"
        '
        'lblperstate
        '
        Me.lblperstate.AutoSize = True
        Me.lblperstate.Location = New System.Drawing.Point(248, 87)
        Me.lblperstate.Name = "lblperstate"
        Me.lblperstate.Size = New System.Drawing.Size(39, 13)
        Me.lblperstate.TabIndex = 31
        Me.lblperstate.Text = "State*:"
        '
        'panel_empdetail4S
        '
        Me.panel_empdetail4S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_empdetail4S.Controls.Add(Me.txtempsalary)
        Me.panel_empdetail4S.Controls.Add(Me.txtemailadd)
        Me.panel_empdetail4S.Controls.Add(Me.txtnationality)
        Me.panel_empdetail4S.Controls.Add(Me.txtbirthplace)
        Me.panel_empdetail4S.Controls.Add(Me.txtempage)
        Me.panel_empdetail4S.Controls.Add(Me.txtbirthdate)
        Me.panel_empdetail4S.Controls.Add(Me.txtmobileno)
        Me.panel_empdetail4S.Controls.Add(Me.cmbbloodgroup)
        Me.panel_empdetail4S.Controls.Add(Me.cmbpayrolltype)
        Me.panel_empdetail4S.Controls.Add(Me.lblempsalary)
        Me.panel_empdetail4S.Controls.Add(Me.lblbloodgroup)
        Me.panel_empdetail4S.Controls.Add(Me.lblemailadd)
        Me.panel_empdetail4S.Controls.Add(Me.lblpayrolltype)
        Me.panel_empdetail4S.Controls.Add(Me.lblnationality)
        Me.panel_empdetail4S.Controls.Add(Me.lblbirthplace)
        Me.panel_empdetail4S.Controls.Add(Me.lblbirthdate)
        Me.panel_empdetail4S.Controls.Add(Me.lblmobileno)
        Me.panel_empdetail4S.Location = New System.Drawing.Point(20, 357)
        Me.panel_empdetail4S.Name = "panel_empdetail4S"
        Me.panel_empdetail4S.Size = New System.Drawing.Size(889, 117)
        Me.panel_empdetail4S.TabIndex = 3
        '
        'txtempsalary
        '
        Me.txtempsalary.CheckBounds = False
        Me.txtempsalary.DateFormat = Nothing
        Me.txtempsalary.DecimalPlaces = CType(0, Byte)
        Me.txtempsalary.Location = New System.Drawing.Point(378, 92)
        Me.txtempsalary.MaxDate = New Date(CType(0, Long))
        Me.txtempsalary.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempsalary.MinDate = New Date(CType(0, Long))
        Me.txtempsalary.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempsalary.Name = "txtempsalary"
        Me.txtempsalary.Size = New System.Drawing.Size(217, 20)
        Me.txtempsalary.TabIndex = 34
        Me.txtempsalary.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtemailadd
        '
        Me.txtemailadd.CheckBounds = False
        Me.txtemailadd.DateFormat = Nothing
        Me.txtemailadd.DecimalPlaces = CType(0, Byte)
        Me.txtemailadd.Location = New System.Drawing.Point(378, 12)
        Me.txtemailadd.MaxDate = New Date(CType(0, Long))
        Me.txtemailadd.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemailadd.MinDate = New Date(CType(0, Long))
        Me.txtemailadd.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtemailadd.Name = "txtemailadd"
        Me.txtemailadd.Size = New System.Drawing.Size(495, 20)
        Me.txtemailadd.TabIndex = 31
        Me.txtemailadd.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_EMails
        '
        'txtnationality
        '
        Me.txtnationality.CheckBounds = False
        Me.txtnationality.DateFormat = Nothing
        Me.txtnationality.DecimalPlaces = CType(0, Byte)
        Me.txtnationality.Location = New System.Drawing.Point(99, 94)
        Me.txtnationality.MaxDate = New Date(CType(0, Long))
        Me.txtnationality.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnationality.MinDate = New Date(CType(0, Long))
        Me.txtnationality.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.Size = New System.Drawing.Size(166, 20)
        Me.txtnationality.TabIndex = 30
        Me.txtnationality.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtbirthplace
        '
        Me.txtbirthplace.CheckBounds = False
        Me.txtbirthplace.DateFormat = Nothing
        Me.txtbirthplace.DecimalPlaces = CType(0, Byte)
        Me.txtbirthplace.Location = New System.Drawing.Point(99, 68)
        Me.txtbirthplace.MaxDate = New Date(CType(0, Long))
        Me.txtbirthplace.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbirthplace.MinDate = New Date(CType(0, Long))
        Me.txtbirthplace.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbirthplace.Name = "txtbirthplace"
        Me.txtbirthplace.Size = New System.Drawing.Size(166, 20)
        Me.txtbirthplace.TabIndex = 29
        Me.txtbirthplace.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtempage
        '
        Me.txtempage.CheckBounds = False
        Me.txtempage.DateFormat = Nothing
        Me.txtempage.DecimalPlaces = CType(0, Byte)
        Me.txtempage.Enabled = False
        Me.txtempage.Location = New System.Drawing.Point(196, 41)
        Me.txtempage.MaxDate = New Date(CType(0, Long))
        Me.txtempage.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempage.MinDate = New Date(CType(0, Long))
        Me.txtempage.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempage.Name = "txtempage"
        Me.txtempage.Size = New System.Drawing.Size(69, 20)
        Me.txtempage.TabIndex = 28
        Me.txtempage.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtbirthdate
        '
        Me.txtbirthdate.CheckBounds = False
        Me.txtbirthdate.DateFormat = Nothing
        Me.txtbirthdate.DecimalPlaces = CType(0, Byte)
        Me.txtbirthdate.Location = New System.Drawing.Point(99, 41)
        Me.txtbirthdate.MaxDate = New Date(CType(0, Long))
        Me.txtbirthdate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbirthdate.MinDate = New Date(CType(0, Long))
        Me.txtbirthdate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbirthdate.Name = "txtbirthdate"
        Me.txtbirthdate.Size = New System.Drawing.Size(91, 20)
        Me.txtbirthdate.TabIndex = 27
        Me.txtbirthdate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Dates
        '
        'txtmobileno
        '
        Me.txtmobileno.CheckBounds = False
        Me.txtmobileno.DateFormat = Nothing
        Me.txtmobileno.DecimalPlaces = CType(0, Byte)
        Me.txtmobileno.Location = New System.Drawing.Point(99, 12)
        Me.txtmobileno.MaxDate = New Date(CType(0, Long))
        Me.txtmobileno.MaxLength = 12
        Me.txtmobileno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmobileno.MinDate = New Date(CType(0, Long))
        Me.txtmobileno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(166, 20)
        Me.txtmobileno.TabIndex = 26
        Me.txtmobileno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'cmbbloodgroup
        '
        Me.cmbbloodgroup.AutoDropDown = False
        Me.cmbbloodgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbloodgroup.FormattingEnabled = True
        Me.cmbbloodgroup.Items.AddRange(New Object() {"", "O+", "O", "A+", "A", "B+", "B"})
        Me.cmbbloodgroup.Location = New System.Drawing.Point(378, 65)
        Me.cmbbloodgroup.Name = "cmbbloodgroup"
        Me.cmbbloodgroup.Size = New System.Drawing.Size(217, 21)
        Me.cmbbloodgroup.TabIndex = 33
        '
        'cmbpayrolltype
        '
        Me.cmbpayrolltype.AutoDropDown = False
        Me.cmbpayrolltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpayrolltype.FormattingEnabled = True
        Me.cmbpayrolltype.Items.AddRange(New Object() {"Fixed", "Monthly"})
        Me.cmbpayrolltype.Location = New System.Drawing.Point(378, 38)
        Me.cmbpayrolltype.Name = "cmbpayrolltype"
        Me.cmbpayrolltype.Size = New System.Drawing.Size(217, 21)
        Me.cmbpayrolltype.TabIndex = 32
        '
        'lblempsalary
        '
        Me.lblempsalary.AutoSize = True
        Me.lblempsalary.Location = New System.Drawing.Point(284, 96)
        Me.lblempsalary.Name = "lblempsalary"
        Me.lblempsalary.Size = New System.Drawing.Size(92, 13)
        Me.lblempsalary.TabIndex = 43
        Me.lblempsalary.Text = "Employee Salary*:"
        '
        'lblbloodgroup
        '
        Me.lblbloodgroup.AutoSize = True
        Me.lblbloodgroup.Location = New System.Drawing.Point(284, 71)
        Me.lblbloodgroup.Name = "lblbloodgroup"
        Me.lblbloodgroup.Size = New System.Drawing.Size(69, 13)
        Me.lblbloodgroup.TabIndex = 31
        Me.lblbloodgroup.Text = "Blood Group:"
        '
        'lblemailadd
        '
        Me.lblemailadd.AutoSize = True
        Me.lblemailadd.Location = New System.Drawing.Point(284, 15)
        Me.lblemailadd.Name = "lblemailadd"
        Me.lblemailadd.Size = New System.Drawing.Size(82, 13)
        Me.lblemailadd.TabIndex = 28
        Me.lblemailadd.Text = "E-mail Address: "
        '
        'lblpayrolltype
        '
        Me.lblpayrolltype.AutoSize = True
        Me.lblpayrolltype.Location = New System.Drawing.Point(284, 44)
        Me.lblpayrolltype.Name = "lblpayrolltype"
        Me.lblpayrolltype.Size = New System.Drawing.Size(72, 13)
        Me.lblpayrolltype.TabIndex = 29
        Me.lblpayrolltype.Text = "Payroll Type*:"
        '
        'lblnationality
        '
        Me.lblnationality.AutoSize = True
        Me.lblnationality.Location = New System.Drawing.Point(4, 93)
        Me.lblnationality.Name = "lblnationality"
        Me.lblnationality.Size = New System.Drawing.Size(63, 13)
        Me.lblnationality.TabIndex = 23
        Me.lblnationality.Text = "Nationality*:"
        '
        'lblbirthplace
        '
        Me.lblbirthplace.AutoSize = True
        Me.lblbirthplace.Location = New System.Drawing.Point(4, 68)
        Me.lblbirthplace.Name = "lblbirthplace"
        Me.lblbirthplace.Size = New System.Drawing.Size(61, 13)
        Me.lblbirthplace.TabIndex = 22
        Me.lblbirthplace.Text = "Birth Place:"
        '
        'lblbirthdate
        '
        Me.lblbirthdate.AutoSize = True
        Me.lblbirthdate.Location = New System.Drawing.Point(4, 41)
        Me.lblbirthdate.Name = "lblbirthdate"
        Me.lblbirthdate.Size = New System.Drawing.Size(57, 13)
        Me.lblbirthdate.TabIndex = 21
        Me.lblbirthdate.Text = "Birth Date:"
        '
        'lblmobileno
        '
        Me.lblmobileno.AutoSize = True
        Me.lblmobileno.Location = New System.Drawing.Point(4, 12)
        Me.lblmobileno.Name = "lblmobileno"
        Me.lblmobileno.Size = New System.Drawing.Size(61, 13)
        Me.lblmobileno.TabIndex = 20
        Me.lblmobileno.Text = "Mobile No.:"
        '
        'panel_empdetail2
        '
        Me.panel_empdetail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_empdetail2.Controls.Add(Me.txtcurrentadd)
        Me.panel_empdetail2.Controls.Add(Me.txtcurrentpinno)
        Me.panel_empdetail2.Controls.Add(Me.txtcurrenttelephno)
        Me.panel_empdetail2.Controls.Add(Me.txtcurrentstate)
        Me.panel_empdetail2.Controls.Add(Me.txtcurrentcity)
        Me.panel_empdetail2.Controls.Add(Me.btnsameaddresspass)
        Me.panel_empdetail2.Controls.Add(Me.lblpinno)
        Me.panel_empdetail2.Controls.Add(Me.lblstate)
        Me.panel_empdetail2.Controls.Add(Me.lbltelephno)
        Me.panel_empdetail2.Controls.Add(Me.lblcity)
        Me.panel_empdetail2.Controls.Add(Me.lblcurrentadd)
        Me.panel_empdetail2.Location = New System.Drawing.Point(20, 204)
        Me.panel_empdetail2.Name = "panel_empdetail2"
        Me.panel_empdetail2.Size = New System.Drawing.Size(430, 147)
        Me.panel_empdetail2.TabIndex = 1
        '
        'txtcurrentadd
        '
        Me.txtcurrentadd.Location = New System.Drawing.Point(99, 14)
        Me.txtcurrentadd.Multiline = True
        Me.txtcurrentadd.Name = "txtcurrentadd"
        Me.txtcurrentadd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtcurrentadd.Size = New System.Drawing.Size(277, 55)
        Me.txtcurrentadd.TabIndex = 15
        '
        'txtcurrentpinno
        '
        Me.txtcurrentpinno.CheckBounds = False
        Me.txtcurrentpinno.DateFormat = Nothing
        Me.txtcurrentpinno.DecimalPlaces = CType(0, Byte)
        Me.txtcurrentpinno.Location = New System.Drawing.Point(299, 110)
        Me.txtcurrentpinno.MaxDate = New Date(CType(0, Long))
        Me.txtcurrentpinno.MaxLength = 6
        Me.txtcurrentpinno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrentpinno.MinDate = New Date(CType(0, Long))
        Me.txtcurrentpinno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrentpinno.Name = "txtcurrentpinno"
        Me.txtcurrentpinno.Size = New System.Drawing.Size(122, 20)
        Me.txtcurrentpinno.TabIndex = 19
        Me.txtcurrentpinno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtcurrenttelephno
        '
        Me.txtcurrenttelephno.CheckBounds = False
        Me.txtcurrenttelephno.DateFormat = Nothing
        Me.txtcurrenttelephno.DecimalPlaces = CType(0, Byte)
        Me.txtcurrenttelephno.Location = New System.Drawing.Point(99, 110)
        Me.txtcurrenttelephno.MaxDate = New Date(CType(0, Long))
        Me.txtcurrenttelephno.MaxLength = 12
        Me.txtcurrenttelephno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrenttelephno.MinDate = New Date(CType(0, Long))
        Me.txtcurrenttelephno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrenttelephno.Name = "txtcurrenttelephno"
        Me.txtcurrenttelephno.Size = New System.Drawing.Size(122, 20)
        Me.txtcurrenttelephno.TabIndex = 18
        Me.txtcurrenttelephno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtcurrentstate
        '
        Me.txtcurrentstate.CheckBounds = False
        Me.txtcurrentstate.DateFormat = Nothing
        Me.txtcurrentstate.DecimalPlaces = CType(0, Byte)
        Me.txtcurrentstate.Location = New System.Drawing.Point(299, 84)
        Me.txtcurrentstate.MaxDate = New Date(CType(0, Long))
        Me.txtcurrentstate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrentstate.MinDate = New Date(CType(0, Long))
        Me.txtcurrentstate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrentstate.Name = "txtcurrentstate"
        Me.txtcurrentstate.Size = New System.Drawing.Size(122, 20)
        Me.txtcurrentstate.TabIndex = 17
        Me.txtcurrentstate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtcurrentcity
        '
        Me.txtcurrentcity.CheckBounds = False
        Me.txtcurrentcity.DateFormat = Nothing
        Me.txtcurrentcity.DecimalPlaces = CType(0, Byte)
        Me.txtcurrentcity.Location = New System.Drawing.Point(99, 84)
        Me.txtcurrentcity.MaxDate = New Date(CType(0, Long))
        Me.txtcurrentcity.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrentcity.MinDate = New Date(CType(0, Long))
        Me.txtcurrentcity.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcurrentcity.Name = "txtcurrentcity"
        Me.txtcurrentcity.Size = New System.Drawing.Size(122, 20)
        Me.txtcurrentcity.TabIndex = 16
        Me.txtcurrentcity.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'btnsameaddresspass
        '
        Me.btnsameaddresspass.Location = New System.Drawing.Point(386, 13)
        Me.btnsameaddresspass.Name = "btnsameaddresspass"
        Me.btnsameaddresspass.Size = New System.Drawing.Size(35, 44)
        Me.btnsameaddresspass.TabIndex = 20
        Me.btnsameaddresspass.Text = ">>"
        Me.btnsameaddresspass.UseVisualStyleBackColor = True
        '
        'lblpinno
        '
        Me.lblpinno.AutoSize = True
        Me.lblpinno.Location = New System.Drawing.Point(234, 113)
        Me.lblpinno.Name = "lblpinno"
        Me.lblpinno.Size = New System.Drawing.Size(48, 13)
        Me.lblpinno.TabIndex = 7
        Me.lblpinno.Text = "PIN No.:"
        '
        'lblstate
        '
        Me.lblstate.AutoSize = True
        Me.lblstate.Location = New System.Drawing.Point(234, 87)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.Size = New System.Drawing.Size(39, 13)
        Me.lblstate.TabIndex = 6
        Me.lblstate.Text = "State*:"
        '
        'lbltelephno
        '
        Me.lbltelephno.AutoSize = True
        Me.lbltelephno.Location = New System.Drawing.Point(4, 113)
        Me.lbltelephno.Name = "lbltelephno"
        Me.lbltelephno.Size = New System.Drawing.Size(81, 13)
        Me.lbltelephno.TabIndex = 4
        Me.lbltelephno.Text = "Telephone No.:"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(4, 87)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(31, 13)
        Me.lblcity.TabIndex = 3
        Me.lblcity.Text = "City*:"
        '
        'lblcurrentadd
        '
        Me.lblcurrentadd.AutoSize = True
        Me.lblcurrentadd.Location = New System.Drawing.Point(4, 13)
        Me.lblcurrentadd.Name = "lblcurrentadd"
        Me.lblcurrentadd.Size = New System.Drawing.Size(89, 13)
        Me.lblcurrentadd.TabIndex = 1
        Me.lblcurrentadd.Text = "Current Address*:"
        '
        'panel_empdetail1
        '
        Me.panel_empdetail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_empdetail1.Controls.Add(Me.lblconfirm)
        Me.panel_empdetail1.Controls.Add(Me.txtcondate)
        Me.panel_empdetail1.Controls.Add(Me.chkinactive)
        Me.panel_empdetail1.Controls.Add(Me.chkpermanent)
        Me.panel_empdetail1.Controls.Add(Me.txtempcode)
        Me.panel_empdetail1.Controls.Add(Me.txtjoiningdate)
        Me.panel_empdetail1.Controls.Add(Me.txtshortname)
        Me.panel_empdetail1.Controls.Add(Me.txtlastname)
        Me.panel_empdetail1.Controls.Add(Me.txtmiddlename)
        Me.panel_empdetail1.Controls.Add(Me.txtfirstname)
        Me.panel_empdetail1.Controls.Add(Me.cmbgender)
        Me.panel_empdetail1.Controls.Add(Me.cmbmartialstatus)
        Me.panel_empdetail1.Controls.Add(Me.cmbdepartmentnm)
        Me.panel_empdetail1.Controls.Add(Me.cmblocationname)
        Me.panel_empdetail1.Controls.Add(Me.lblempcode)
        Me.panel_empdetail1.Controls.Add(Me.lbldepartment)
        Me.panel_empdetail1.Controls.Add(Me.btnclear)
        Me.panel_empdetail1.Controls.Add(Me.btnload)
        Me.panel_empdetail1.Controls.Add(Me.empphoto)
        Me.panel_empdetail1.Controls.Add(Me.lbljoindate)
        Me.panel_empdetail1.Controls.Add(Me.lblmaritalsts)
        Me.panel_empdetail1.Controls.Add(Me.lblgender)
        Me.panel_empdetail1.Controls.Add(Me.lblshortname)
        Me.panel_empdetail1.Controls.Add(Me.lbllastname)
        Me.panel_empdetail1.Controls.Add(Me.lblmiddlename)
        Me.panel_empdetail1.Controls.Add(Me.lblfirstname)
        Me.panel_empdetail1.Controls.Add(Me.lbllocname)
        Me.panel_empdetail1.Location = New System.Drawing.Point(20, 7)
        Me.panel_empdetail1.Name = "panel_empdetail1"
        Me.panel_empdetail1.Size = New System.Drawing.Size(889, 192)
        Me.panel_empdetail1.TabIndex = 0
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.Location = New System.Drawing.Point(320, 126)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(97, 13)
        Me.lblconfirm.TabIndex = 42
        Me.lblconfirm.Text = "Confirmation Date :"
        '
        'txtcondate
        '
        Me.txtcondate.CheckBounds = False
        Me.txtcondate.DateFormat = Nothing
        Me.txtcondate.DecimalPlaces = CType(0, Byte)
        Me.txtcondate.Location = New System.Drawing.Point(424, 123)
        Me.txtcondate.MaxDate = New Date(CType(0, Long))
        Me.txtcondate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcondate.MinDate = New Date(CType(0, Long))
        Me.txtcondate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcondate.Name = "txtcondate"
        Me.txtcondate.Size = New System.Drawing.Size(217, 20)
        Me.txtcondate.TabIndex = 9
        Me.txtcondate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Dates
        '
        'chkinactive
        '
        Me.chkinactive.AutoSize = True
        Me.chkinactive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkinactive.Location = New System.Drawing.Point(653, 36)
        Me.chkinactive.Name = "chkinactive"
        Me.chkinactive.Size = New System.Drawing.Size(83, 17)
        Me.chkinactive.TabIndex = 12
        Me.chkinactive.Text = "InActive :    "
        Me.chkinactive.UseVisualStyleBackColor = True
        '
        'chkpermanent
        '
        Me.chkpermanent.AutoSize = True
        Me.chkpermanent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkpermanent.Location = New System.Drawing.Point(653, 13)
        Me.chkpermanent.Name = "chkpermanent"
        Me.chkpermanent.Size = New System.Drawing.Size(83, 17)
        Me.chkpermanent.TabIndex = 11
        Me.chkpermanent.Text = "Permanent :"
        Me.chkpermanent.UseVisualStyleBackColor = True
        '
        'txtempcode
        '
        Me.txtempcode.CheckBounds = False
        Me.txtempcode.DateFormat = Nothing
        Me.txtempcode.DecimalPlaces = CType(0, Byte)
        Me.txtempcode.Enabled = False
        Me.txtempcode.Location = New System.Drawing.Point(425, 150)
        Me.txtempcode.MaxDate = New Date(CType(0, Long))
        Me.txtempcode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempcode.MinDate = New Date(CType(0, Long))
        Me.txtempcode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempcode.Name = "txtempcode"
        Me.txtempcode.Size = New System.Drawing.Size(217, 20)
        Me.txtempcode.TabIndex = 10
        Me.txtempcode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtjoiningdate
        '
        Me.txtjoiningdate.CheckBounds = False
        Me.txtjoiningdate.DateFormat = Nothing
        Me.txtjoiningdate.DecimalPlaces = CType(0, Byte)
        Me.txtjoiningdate.Location = New System.Drawing.Point(425, 93)
        Me.txtjoiningdate.MaxDate = New Date(CType(0, Long))
        Me.txtjoiningdate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjoiningdate.MinDate = New Date(CType(0, Long))
        Me.txtjoiningdate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjoiningdate.Name = "txtjoiningdate"
        Me.txtjoiningdate.Size = New System.Drawing.Size(217, 20)
        Me.txtjoiningdate.TabIndex = 8
        Me.txtjoiningdate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Dates
        '
        'txtshortname
        '
        Me.txtshortname.CheckBounds = False
        Me.txtshortname.DateFormat = Nothing
        Me.txtshortname.DecimalPlaces = CType(0, Byte)
        Me.txtshortname.Enabled = False
        Me.txtshortname.Location = New System.Drawing.Point(99, 150)
        Me.txtshortname.MaxDate = New Date(CType(0, Long))
        Me.txtshortname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtshortname.MinDate = New Date(CType(0, Long))
        Me.txtshortname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtshortname.Name = "txtshortname"
        Me.txtshortname.Size = New System.Drawing.Size(217, 20)
        Me.txtshortname.TabIndex = 5
        Me.txtshortname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtlastname
        '
        Me.txtlastname.CheckBounds = False
        Me.txtlastname.DateFormat = Nothing
        Me.txtlastname.DecimalPlaces = CType(0, Byte)
        Me.txtlastname.Location = New System.Drawing.Point(99, 111)
        Me.txtlastname.MaxDate = New Date(CType(0, Long))
        Me.txtlastname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlastname.MinDate = New Date(CType(0, Long))
        Me.txtlastname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(217, 20)
        Me.txtlastname.TabIndex = 4
        Me.txtlastname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtmiddlename
        '
        Me.txtmiddlename.CheckBounds = False
        Me.txtmiddlename.DateFormat = Nothing
        Me.txtmiddlename.DecimalPlaces = CType(0, Byte)
        Me.txtmiddlename.Location = New System.Drawing.Point(99, 76)
        Me.txtmiddlename.MaxDate = New Date(CType(0, Long))
        Me.txtmiddlename.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmiddlename.MinDate = New Date(CType(0, Long))
        Me.txtmiddlename.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(217, 20)
        Me.txtmiddlename.TabIndex = 3
        Me.txtmiddlename.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtfirstname
        '
        Me.txtfirstname.CheckBounds = False
        Me.txtfirstname.DateFormat = Nothing
        Me.txtfirstname.DecimalPlaces = CType(0, Byte)
        Me.txtfirstname.Location = New System.Drawing.Point(99, 39)
        Me.txtfirstname.MaxDate = New Date(CType(0, Long))
        Me.txtfirstname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfirstname.MinDate = New Date(CType(0, Long))
        Me.txtfirstname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(217, 20)
        Me.txtfirstname.TabIndex = 2
        Me.txtfirstname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'cmbgender
        '
        Me.cmbgender.AutoDropDown = False
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"", "Female", "Male"})
        Me.cmbgender.Location = New System.Drawing.Point(425, 36)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(217, 21)
        Me.cmbgender.TabIndex = 6
        '
        'cmbmartialstatus
        '
        Me.cmbmartialstatus.AutoDropDown = False
        Me.cmbmartialstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmartialstatus.FormattingEnabled = True
        Me.cmbmartialstatus.Items.AddRange(New Object() {"", "Married", "Unmarried", "Seperated", "Divorsed"})
        Me.cmbmartialstatus.Location = New System.Drawing.Point(425, 64)
        Me.cmbmartialstatus.Name = "cmbmartialstatus"
        Me.cmbmartialstatus.Size = New System.Drawing.Size(217, 21)
        Me.cmbmartialstatus.TabIndex = 7
        '
        'cmbdepartmentnm
        '
        Me.cmbdepartmentnm.AutoDropDown = False
        Me.cmbdepartmentnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdepartmentnm.FormattingEnabled = True
        Me.cmbdepartmentnm.Location = New System.Drawing.Point(425, 8)
        Me.cmbdepartmentnm.Name = "cmbdepartmentnm"
        Me.cmbdepartmentnm.Size = New System.Drawing.Size(217, 21)
        Me.cmbdepartmentnm.TabIndex = 1
        '
        'cmblocationname
        '
        Me.cmblocationname.AutoDropDown = False
        Me.cmblocationname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocationname.FormattingEnabled = True
        Me.cmblocationname.Location = New System.Drawing.Point(99, 8)
        Me.cmblocationname.Name = "cmblocationname"
        Me.cmblocationname.Size = New System.Drawing.Size(217, 21)
        Me.cmblocationname.TabIndex = 0
        '
        'lblempcode
        '
        Me.lblempcode.AutoSize = True
        Me.lblempcode.Location = New System.Drawing.Point(322, 153)
        Me.lblempcode.Name = "lblempcode"
        Me.lblempcode.Size = New System.Drawing.Size(88, 13)
        Me.lblempcode.TabIndex = 40
        Me.lblempcode.Text = "Employee Code*:"
        '
        'lbldepartment
        '
        Me.lbldepartment.AutoSize = True
        Me.lbldepartment.Location = New System.Drawing.Point(322, 11)
        Me.lbldepartment.Name = "lbldepartment"
        Me.lbldepartment.Size = New System.Drawing.Size(69, 13)
        Me.lbldepartment.TabIndex = 38
        Me.lbldepartment.Text = "Department*:"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(820, 147)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(53, 32)
        Me.btnclear.TabIndex = 14
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(748, 146)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(56, 33)
        Me.btnload.TabIndex = 13
        Me.btnload.Text = "Load"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'empphoto
        '
        Me.empphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.empphoto.Location = New System.Drawing.Point(749, 10)
        Me.empphoto.Name = "empphoto"
        Me.empphoto.Size = New System.Drawing.Size(124, 121)
        Me.empphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.empphoto.TabIndex = 12
        Me.empphoto.TabStop = False
        '
        'lbljoindate
        '
        Me.lbljoindate.AutoSize = True
        Me.lbljoindate.Location = New System.Drawing.Point(322, 96)
        Me.lbljoindate.Name = "lbljoindate"
        Me.lbljoindate.Size = New System.Drawing.Size(73, 13)
        Me.lbljoindate.TabIndex = 8
        Me.lbljoindate.Text = "Joining Date*:"
        '
        'lblmaritalsts
        '
        Me.lblmaritalsts.AutoSize = True
        Me.lblmaritalsts.Location = New System.Drawing.Point(322, 67)
        Me.lblmaritalsts.Name = "lblmaritalsts"
        Me.lblmaritalsts.Size = New System.Drawing.Size(78, 13)
        Me.lblmaritalsts.TabIndex = 6
        Me.lblmaritalsts.Text = "Marital Status*:"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(322, 37)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(49, 13)
        Me.lblgender.TabIndex = 5
        Me.lblgender.Text = "Gender*:"
        '
        'lblshortname
        '
        Me.lblshortname.AutoSize = True
        Me.lblshortname.Location = New System.Drawing.Point(4, 153)
        Me.lblshortname.Name = "lblshortname"
        Me.lblshortname.Size = New System.Drawing.Size(70, 13)
        Me.lblshortname.TabIndex = 4
        Me.lblshortname.Text = "Short Name*:"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(5, 114)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(65, 13)
        Me.lbllastname.TabIndex = 3
        Me.lbllastname.Text = "Last Name*:"
        '
        'lblmiddlename
        '
        Me.lblmiddlename.AutoSize = True
        Me.lblmiddlename.Location = New System.Drawing.Point(5, 79)
        Me.lblmiddlename.Name = "lblmiddlename"
        Me.lblmiddlename.Size = New System.Drawing.Size(76, 13)
        Me.lblmiddlename.TabIndex = 2
        Me.lblmiddlename.Text = "Middle Name*:"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Location = New System.Drawing.Point(5, 42)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(64, 13)
        Me.lblfirstname.TabIndex = 1
        Me.lblfirstname.Text = "First Name*:"
        '
        'lbllocname
        '
        Me.lbllocname.AutoSize = True
        Me.lbllocname.Location = New System.Drawing.Point(4, 11)
        Me.lbllocname.Name = "lbllocname"
        Me.lbllocname.Size = New System.Drawing.Size(86, 13)
        Me.lbllocname.TabIndex = 0
        Me.lbllocname.Text = "Location Name*:"
        '
        'OtherDetails
        '
        Me.OtherDetails.Controls.Add(Me.txthobbies)
        Me.OtherDetails.Controls.Add(Me.grp_incometax)
        Me.OtherDetails.Controls.Add(Me.lblhobies)
        Me.OtherDetails.Controls.Add(Me.grp_vehicledetail)
        Me.OtherDetails.Controls.Add(Me.grp_bank_reference_detail)
        Me.OtherDetails.Controls.Add(Me.grp_otherdetail)
        Me.OtherDetails.Location = New System.Drawing.Point(4, 22)
        Me.OtherDetails.Name = "OtherDetails"
        Me.OtherDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.OtherDetails.Size = New System.Drawing.Size(915, 482)
        Me.OtherDetails.TabIndex = 1
        Me.OtherDetails.Text = "Other Details"
        Me.OtherDetails.UseVisualStyleBackColor = True
        '
        'txthobbies
        '
        Me.txthobbies.CheckBounds = False
        Me.txthobbies.DateFormat = Nothing
        Me.txthobbies.DecimalPlaces = CType(0, Byte)
        Me.txthobbies.Location = New System.Drawing.Point(679, 356)
        Me.txthobbies.MaxDate = New Date(CType(0, Long))
        Me.txthobbies.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txthobbies.MinDate = New Date(CType(0, Long))
        Me.txthobbies.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txthobbies.Multiline = True
        Me.txthobbies.Name = "txthobbies"
        Me.txthobbies.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txthobbies.Size = New System.Drawing.Size(224, 114)
        Me.txthobbies.TabIndex = 23
        Me.txthobbies.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'grp_incometax
        '
        Me.grp_incometax.Controls.Add(Me.chkdisabled)
        Me.grp_incometax.Controls.Add(Me.txtpercentofdisabled)
        Me.grp_incometax.Controls.Add(Me.txtdisablednote)
        Me.grp_incometax.Controls.Add(Me.txtnoofchild)
        Me.grp_incometax.Controls.Add(Me.txtPANno)
        Me.grp_incometax.Controls.Add(Me.lblpanno)
        Me.grp_incometax.Controls.Add(Me.lblpercentdisabled)
        Me.grp_incometax.Controls.Add(Me.lbldisablednote)
        Me.grp_incometax.Controls.Add(Me.lblnoofchild)
        Me.grp_incometax.Location = New System.Drawing.Point(6, 135)
        Me.grp_incometax.Name = "grp_incometax"
        Me.grp_incometax.Size = New System.Drawing.Size(903, 114)
        Me.grp_incometax.TabIndex = 1
        Me.grp_incometax.TabStop = False
        Me.grp_incometax.Text = "Income Tax Details"
        '
        'chkdisabled
        '
        Me.chkdisabled.AutoSize = True
        Me.chkdisabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkdisabled.Location = New System.Drawing.Point(386, 28)
        Me.chkdisabled.Name = "chkdisabled"
        Me.chkdisabled.Size = New System.Drawing.Size(142, 17)
        Me.chkdisabled.TabIndex = 8
        Me.chkdisabled.Text = "Disabled :                       "
        Me.chkdisabled.UseVisualStyleBackColor = True
        '
        'txtpercentofdisabled
        '
        Me.txtpercentofdisabled.CheckBounds = False
        Me.txtpercentofdisabled.DateFormat = Nothing
        Me.txtpercentofdisabled.DecimalPlaces = CType(0, Byte)
        Me.txtpercentofdisabled.Location = New System.Drawing.Point(513, 55)
        Me.txtpercentofdisabled.MaxDate = New Date(CType(0, Long))
        Me.txtpercentofdisabled.MaxLength = 6
        Me.txtpercentofdisabled.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpercentofdisabled.MinDate = New Date(CType(0, Long))
        Me.txtpercentofdisabled.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpercentofdisabled.Name = "txtpercentofdisabled"
        Me.txtpercentofdisabled.Size = New System.Drawing.Size(217, 20)
        Me.txtpercentofdisabled.TabIndex = 9
        Me.txtpercentofdisabled.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtdisablednote
        '
        Me.txtdisablednote.CheckBounds = False
        Me.txtdisablednote.DateFormat = Nothing
        Me.txtdisablednote.DecimalPlaces = CType(0, Byte)
        Me.txtdisablednote.Location = New System.Drawing.Point(513, 81)
        Me.txtdisablednote.MaxDate = New Date(CType(0, Long))
        Me.txtdisablednote.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdisablednote.MinDate = New Date(CType(0, Long))
        Me.txtdisablednote.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdisablednote.Name = "txtdisablednote"
        Me.txtdisablednote.Size = New System.Drawing.Size(217, 20)
        Me.txtdisablednote.TabIndex = 10
        Me.txtdisablednote.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtnoofchild
        '
        Me.txtnoofchild.CheckBounds = False
        Me.txtnoofchild.DateFormat = Nothing
        Me.txtnoofchild.DecimalPlaces = CType(0, Byte)
        Me.txtnoofchild.Location = New System.Drawing.Point(122, 67)
        Me.txtnoofchild.MaxDate = New Date(CType(0, Long))
        Me.txtnoofchild.MaxLength = 2
        Me.txtnoofchild.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnoofchild.MinDate = New Date(CType(0, Long))
        Me.txtnoofchild.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnoofchild.Name = "txtnoofchild"
        Me.txtnoofchild.Size = New System.Drawing.Size(217, 20)
        Me.txtnoofchild.TabIndex = 7
        Me.txtnoofchild.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtPANno
        '
        Me.txtPANno.CheckBounds = False
        Me.txtPANno.DateFormat = Nothing
        Me.txtPANno.DecimalPlaces = CType(0, Byte)
        Me.txtPANno.Location = New System.Drawing.Point(122, 26)
        Me.txtPANno.MaxDate = New Date(CType(0, Long))
        Me.txtPANno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPANno.MinDate = New Date(CType(0, Long))
        Me.txtPANno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPANno.Name = "txtPANno"
        Me.txtPANno.Size = New System.Drawing.Size(217, 20)
        Me.txtPANno.TabIndex = 6
        Me.txtPANno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lblpanno
        '
        Me.lblpanno.AutoSize = True
        Me.lblpanno.Location = New System.Drawing.Point(10, 29)
        Me.lblpanno.Name = "lblpanno"
        Me.lblpanno.Size = New System.Drawing.Size(103, 13)
        Me.lblpanno.TabIndex = 45
        Me.lblpanno.Text = "Permanent A/C No.:"
        '
        'lblpercentdisabled
        '
        Me.lblpercentdisabled.AutoSize = True
        Me.lblpercentdisabled.Location = New System.Drawing.Point(387, 58)
        Me.lblpercentdisabled.Name = "lblpercentdisabled"
        Me.lblpercentdisabled.Size = New System.Drawing.Size(105, 13)
        Me.lblpercentdisabled.TabIndex = 46
        Me.lblpercentdisabled.Text = "Percent Disability(%):"
        '
        'lbldisablednote
        '
        Me.lbldisablednote.AutoSize = True
        Me.lbldisablednote.Location = New System.Drawing.Point(387, 84)
        Me.lbldisablednote.Name = "lbldisablednote"
        Me.lbldisablednote.Size = New System.Drawing.Size(82, 13)
        Me.lbldisablednote.TabIndex = 49
        Me.lbldisablednote.Text = "Disability Notes:"
        '
        'lblnoofchild
        '
        Me.lblnoofchild.AutoSize = True
        Me.lblnoofchild.Location = New System.Drawing.Point(10, 70)
        Me.lblnoofchild.Name = "lblnoofchild"
        Me.lblnoofchild.Size = New System.Drawing.Size(80, 13)
        Me.lblnoofchild.TabIndex = 48
        Me.lblnoofchild.Text = "No. of Children:"
        '
        'lblhobies
        '
        Me.lblhobies.AutoSize = True
        Me.lblhobies.Location = New System.Drawing.Point(676, 335)
        Me.lblhobies.Name = "lblhobies"
        Me.lblhobies.Size = New System.Drawing.Size(96, 13)
        Me.lblhobies.TabIndex = 63
        Me.lblhobies.Text = "Hobbies && Interest:"
        '
        'grp_vehicledetail
        '
        Me.grp_vehicledetail.Controls.Add(Me.txtrationcardno)
        Me.grp_vehicledetail.Controls.Add(Me.txtvehicleno)
        Me.grp_vehicledetail.Controls.Add(Me.txtvehicletype)
        Me.grp_vehicledetail.Controls.Add(Me.txtdrivinglicenseno)
        Me.grp_vehicledetail.Controls.Add(Me.txtvalidtill)
        Me.grp_vehicledetail.Controls.Add(Me.txtplaceofissue)
        Me.grp_vehicledetail.Controls.Add(Me.txtdateofissue)
        Me.grp_vehicledetail.Controls.Add(Me.txtpassportno)
        Me.grp_vehicledetail.Controls.Add(Me.lblrationno)
        Me.grp_vehicledetail.Controls.Add(Me.lblvalidtill)
        Me.grp_vehicledetail.Controls.Add(Me.lblvehicleno)
        Me.grp_vehicledetail.Controls.Add(Me.lblissueplace)
        Me.grp_vehicledetail.Controls.Add(Me.lblpassportno)
        Me.grp_vehicledetail.Controls.Add(Me.lbllicenseno)
        Me.grp_vehicledetail.Controls.Add(Me.lblvehicletype)
        Me.grp_vehicledetail.Controls.Add(Me.lblissuedate)
        Me.grp_vehicledetail.Location = New System.Drawing.Point(6, 330)
        Me.grp_vehicledetail.Name = "grp_vehicledetail"
        Me.grp_vehicledetail.Size = New System.Drawing.Size(664, 143)
        Me.grp_vehicledetail.TabIndex = 3
        Me.grp_vehicledetail.TabStop = False
        Me.grp_vehicledetail.Text = "Passport/Vehicle/License Details"
        '
        'txtrationcardno
        '
        Me.txtrationcardno.CheckBounds = False
        Me.txtrationcardno.DateFormat = Nothing
        Me.txtrationcardno.DecimalPlaces = CType(0, Byte)
        Me.txtrationcardno.Location = New System.Drawing.Point(454, 108)
        Me.txtrationcardno.MaxDate = New Date(CType(0, Long))
        Me.txtrationcardno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtrationcardno.MinDate = New Date(CType(0, Long))
        Me.txtrationcardno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtrationcardno.Name = "txtrationcardno"
        Me.txtrationcardno.Size = New System.Drawing.Size(201, 20)
        Me.txtrationcardno.TabIndex = 22
        Me.txtrationcardno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtvehicleno
        '
        Me.txtvehicleno.CheckBounds = False
        Me.txtvehicleno.DateFormat = Nothing
        Me.txtvehicleno.DecimalPlaces = CType(0, Byte)
        Me.txtvehicleno.Location = New System.Drawing.Point(454, 82)
        Me.txtvehicleno.MaxDate = New Date(CType(0, Long))
        Me.txtvehicleno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvehicleno.MinDate = New Date(CType(0, Long))
        Me.txtvehicleno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvehicleno.Name = "txtvehicleno"
        Me.txtvehicleno.Size = New System.Drawing.Size(201, 20)
        Me.txtvehicleno.TabIndex = 21
        Me.txtvehicleno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtvehicletype
        '
        Me.txtvehicletype.CheckBounds = False
        Me.txtvehicletype.DateFormat = Nothing
        Me.txtvehicletype.DecimalPlaces = CType(0, Byte)
        Me.txtvehicletype.Location = New System.Drawing.Point(454, 55)
        Me.txtvehicletype.MaxDate = New Date(CType(0, Long))
        Me.txtvehicletype.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvehicletype.MinDate = New Date(CType(0, Long))
        Me.txtvehicletype.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvehicletype.Name = "txtvehicletype"
        Me.txtvehicletype.Size = New System.Drawing.Size(201, 20)
        Me.txtvehicletype.TabIndex = 20
        Me.txtvehicletype.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtdrivinglicenseno
        '
        Me.txtdrivinglicenseno.CheckBounds = False
        Me.txtdrivinglicenseno.DateFormat = Nothing
        Me.txtdrivinglicenseno.DecimalPlaces = CType(0, Byte)
        Me.txtdrivinglicenseno.Location = New System.Drawing.Point(454, 26)
        Me.txtdrivinglicenseno.MaxDate = New Date(CType(0, Long))
        Me.txtdrivinglicenseno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdrivinglicenseno.MinDate = New Date(CType(0, Long))
        Me.txtdrivinglicenseno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdrivinglicenseno.Name = "txtdrivinglicenseno"
        Me.txtdrivinglicenseno.Size = New System.Drawing.Size(201, 20)
        Me.txtdrivinglicenseno.TabIndex = 19
        Me.txtdrivinglicenseno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtvalidtill
        '
        Me.txtvalidtill.CheckBounds = False
        Me.txtvalidtill.DateFormat = Nothing
        Me.txtvalidtill.DecimalPlaces = CType(0, Byte)
        Me.txtvalidtill.Location = New System.Drawing.Point(122, 108)
        Me.txtvalidtill.MaxDate = New Date(CType(0, Long))
        Me.txtvalidtill.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvalidtill.MinDate = New Date(CType(0, Long))
        Me.txtvalidtill.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvalidtill.Name = "txtvalidtill"
        Me.txtvalidtill.Size = New System.Drawing.Size(217, 20)
        Me.txtvalidtill.TabIndex = 18
        Me.txtvalidtill.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Dates
        '
        'txtplaceofissue
        '
        Me.txtplaceofissue.CheckBounds = False
        Me.txtplaceofissue.DateFormat = Nothing
        Me.txtplaceofissue.DecimalPlaces = CType(0, Byte)
        Me.txtplaceofissue.Location = New System.Drawing.Point(122, 82)
        Me.txtplaceofissue.MaxDate = New Date(CType(0, Long))
        Me.txtplaceofissue.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtplaceofissue.MinDate = New Date(CType(0, Long))
        Me.txtplaceofissue.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtplaceofissue.Name = "txtplaceofissue"
        Me.txtplaceofissue.Size = New System.Drawing.Size(217, 20)
        Me.txtplaceofissue.TabIndex = 17
        Me.txtplaceofissue.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtdateofissue
        '
        Me.txtdateofissue.CheckBounds = False
        Me.txtdateofissue.DateFormat = Nothing
        Me.txtdateofissue.DecimalPlaces = CType(0, Byte)
        Me.txtdateofissue.Location = New System.Drawing.Point(122, 55)
        Me.txtdateofissue.MaxDate = New Date(CType(0, Long))
        Me.txtdateofissue.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdateofissue.MinDate = New Date(CType(0, Long))
        Me.txtdateofissue.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdateofissue.Name = "txtdateofissue"
        Me.txtdateofissue.Size = New System.Drawing.Size(217, 20)
        Me.txtdateofissue.TabIndex = 16
        Me.txtdateofissue.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Dates
        '
        'txtpassportno
        '
        Me.txtpassportno.CheckBounds = False
        Me.txtpassportno.DateFormat = Nothing
        Me.txtpassportno.DecimalPlaces = CType(0, Byte)
        Me.txtpassportno.Location = New System.Drawing.Point(122, 26)
        Me.txtpassportno.MaxDate = New Date(CType(0, Long))
        Me.txtpassportno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpassportno.MinDate = New Date(CType(0, Long))
        Me.txtpassportno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpassportno.Name = "txtpassportno"
        Me.txtpassportno.Size = New System.Drawing.Size(217, 20)
        Me.txtpassportno.TabIndex = 15
        Me.txtpassportno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lblrationno
        '
        Me.lblrationno.AutoSize = True
        Me.lblrationno.Location = New System.Drawing.Point(345, 111)
        Me.lblrationno.Name = "lblrationno"
        Me.lblrationno.Size = New System.Drawing.Size(86, 13)
        Me.lblrationno.TabIndex = 57
        Me.lblrationno.Text = "Ration Card No.:"
        '
        'lblvalidtill
        '
        Me.lblvalidtill.AutoSize = True
        Me.lblvalidtill.Location = New System.Drawing.Point(10, 114)
        Me.lblvalidtill.Name = "lblvalidtill"
        Me.lblvalidtill.Size = New System.Drawing.Size(49, 13)
        Me.lblvalidtill.TabIndex = 56
        Me.lblvalidtill.Text = "Valid Till:"
        '
        'lblvehicleno
        '
        Me.lblvehicleno.AutoSize = True
        Me.lblvehicleno.Location = New System.Drawing.Point(345, 85)
        Me.lblvehicleno.Name = "lblvehicleno"
        Me.lblvehicleno.Size = New System.Drawing.Size(65, 13)
        Me.lblvehicleno.TabIndex = 54
        Me.lblvehicleno.Text = "Vehicle No.:"
        '
        'lblissueplace
        '
        Me.lblissueplace.AutoSize = True
        Me.lblissueplace.Location = New System.Drawing.Point(10, 85)
        Me.lblissueplace.Name = "lblissueplace"
        Me.lblissueplace.Size = New System.Drawing.Size(77, 13)
        Me.lblissueplace.TabIndex = 53
        Me.lblissueplace.Text = "Place of Issue:"
        '
        'lblpassportno
        '
        Me.lblpassportno.AutoSize = True
        Me.lblpassportno.Location = New System.Drawing.Point(10, 29)
        Me.lblpassportno.Name = "lblpassportno"
        Me.lblpassportno.Size = New System.Drawing.Size(71, 13)
        Me.lblpassportno.TabIndex = 45
        Me.lblpassportno.Text = "Passport No.:"
        '
        'lbllicenseno
        '
        Me.lbllicenseno.AutoSize = True
        Me.lbllicenseno.Location = New System.Drawing.Point(345, 29)
        Me.lbllicenseno.Name = "lbllicenseno"
        Me.lbllicenseno.Size = New System.Drawing.Size(103, 13)
        Me.lbllicenseno.TabIndex = 46
        Me.lbllicenseno.Text = "Driving License No.:"
        '
        'lblvehicletype
        '
        Me.lblvehicletype.AutoSize = True
        Me.lblvehicletype.Location = New System.Drawing.Point(345, 55)
        Me.lblvehicletype.Name = "lblvehicletype"
        Me.lblvehicletype.Size = New System.Drawing.Size(72, 13)
        Me.lblvehicletype.TabIndex = 49
        Me.lblvehicletype.Text = "Vehicle Type:"
        '
        'lblissuedate
        '
        Me.lblissuedate.AutoSize = True
        Me.lblissuedate.Location = New System.Drawing.Point(10, 58)
        Me.lblissuedate.Name = "lblissuedate"
        Me.lblissuedate.Size = New System.Drawing.Size(73, 13)
        Me.lblissuedate.TabIndex = 48
        Me.lblissuedate.Text = "Date of Issue:"
        '
        'grp_bank_reference_detail
        '
        Me.grp_bank_reference_detail.Controls.Add(Me.txtbankacno)
        Me.grp_bank_reference_detail.Controls.Add(Me.txtreference2)
        Me.grp_bank_reference_detail.Controls.Add(Me.txtreference1)
        Me.grp_bank_reference_detail.Controls.Add(Me.cmbbankname)
        Me.grp_bank_reference_detail.Controls.Add(Me.lblreference1)
        Me.grp_bank_reference_detail.Controls.Add(Me.lblreference2)
        Me.grp_bank_reference_detail.Controls.Add(Me.lblbankacno)
        Me.grp_bank_reference_detail.Controls.Add(Me.lblbanknm)
        Me.grp_bank_reference_detail.Location = New System.Drawing.Point(6, 253)
        Me.grp_bank_reference_detail.Name = "grp_bank_reference_detail"
        Me.grp_bank_reference_detail.Size = New System.Drawing.Size(903, 74)
        Me.grp_bank_reference_detail.TabIndex = 2
        Me.grp_bank_reference_detail.TabStop = False
        Me.grp_bank_reference_detail.Text = "Bank, Reference Details"
        '
        'txtbankacno
        '
        Me.txtbankacno.CheckBounds = False
        Me.txtbankacno.DateFormat = Nothing
        Me.txtbankacno.DecimalPlaces = CType(0, Byte)
        Me.txtbankacno.Location = New System.Drawing.Point(513, 18)
        Me.txtbankacno.MaxDate = New Date(CType(0, Long))
        Me.txtbankacno.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbankacno.MinDate = New Date(CType(0, Long))
        Me.txtbankacno.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtbankacno.Name = "txtbankacno"
        Me.txtbankacno.Size = New System.Drawing.Size(217, 20)
        Me.txtbankacno.TabIndex = 31
        Me.txtbankacno.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtreference2
        '
        Me.txtreference2.CheckBounds = False
        Me.txtreference2.DateFormat = Nothing
        Me.txtreference2.DecimalPlaces = CType(0, Byte)
        Me.txtreference2.Location = New System.Drawing.Point(513, 47)
        Me.txtreference2.MaxDate = New Date(CType(0, Long))
        Me.txtreference2.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtreference2.MinDate = New Date(CType(0, Long))
        Me.txtreference2.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtreference2.Name = "txtreference2"
        Me.txtreference2.Size = New System.Drawing.Size(217, 20)
        Me.txtreference2.TabIndex = 14
        Me.txtreference2.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'txtreference1
        '
        Me.txtreference1.CheckBounds = False
        Me.txtreference1.DateFormat = Nothing
        Me.txtreference1.DecimalPlaces = CType(0, Byte)
        Me.txtreference1.Location = New System.Drawing.Point(122, 47)
        Me.txtreference1.MaxDate = New Date(CType(0, Long))
        Me.txtreference1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtreference1.MinDate = New Date(CType(0, Long))
        Me.txtreference1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtreference1.Name = "txtreference1"
        Me.txtreference1.Size = New System.Drawing.Size(217, 20)
        Me.txtreference1.TabIndex = 13
        Me.txtreference1.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Characters
        '
        'cmbbankname
        '
        Me.cmbbankname.AutoDropDown = False
        Me.cmbbankname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbankname.FormattingEnabled = True
        Me.cmbbankname.Location = New System.Drawing.Point(122, 19)
        Me.cmbbankname.Name = "cmbbankname"
        Me.cmbbankname.Size = New System.Drawing.Size(217, 21)
        Me.cmbbankname.TabIndex = 11
        '
        'lblreference1
        '
        Me.lblreference1.AutoSize = True
        Me.lblreference1.Location = New System.Drawing.Point(10, 50)
        Me.lblreference1.Name = "lblreference1"
        Me.lblreference1.Size = New System.Drawing.Size(69, 13)
        Me.lblreference1.TabIndex = 30
        Me.lblreference1.Text = "Reference 1:"
        '
        'lblreference2
        '
        Me.lblreference2.AutoSize = True
        Me.lblreference2.Location = New System.Drawing.Point(387, 50)
        Me.lblreference2.Name = "lblreference2"
        Me.lblreference2.Size = New System.Drawing.Size(69, 13)
        Me.lblreference2.TabIndex = 29
        Me.lblreference2.Text = "Reference 2:"
        '
        'lblbankacno
        '
        Me.lblbankacno.AutoSize = True
        Me.lblbankacno.Location = New System.Drawing.Point(387, 21)
        Me.lblbankacno.Name = "lblbankacno"
        Me.lblbankacno.Size = New System.Drawing.Size(77, 13)
        Me.lblbankacno.TabIndex = 28
        Me.lblbankacno.Text = "Bank A/C No.:"
        '
        'lblbanknm
        '
        Me.lblbanknm.AutoSize = True
        Me.lblbanknm.Location = New System.Drawing.Point(10, 21)
        Me.lblbanknm.Name = "lblbanknm"
        Me.lblbanknm.Size = New System.Drawing.Size(66, 13)
        Me.lblbanknm.TabIndex = 27
        Me.lblbanknm.Text = "Bank Name:"
        '
        'grp_otherdetail
        '
        Me.grp_otherdetail.Controls.Add(Me.chkcivil)
        Me.grp_otherdetail.Controls.Add(Me.txtlitigationdetail)
        Me.grp_otherdetail.Controls.Add(Me.txtrelieveddate)
        Me.grp_otherdetail.Controls.Add(Me.txtjobprofile)
        Me.grp_otherdetail.Controls.Add(Me.cmbleavereason)
        Me.grp_otherdetail.Controls.Add(Me.cmbempposition)
        Me.grp_otherdetail.Controls.Add(Me.lbllitigationdetail)
        Me.grp_otherdetail.Controls.Add(Me.lblleavereason)
        Me.grp_otherdetail.Controls.Add(Me.lblrelieveddate)
        Me.grp_otherdetail.Controls.Add(Me.lblpos)
        Me.grp_otherdetail.Controls.Add(Me.lbljobprofile)
        Me.grp_otherdetail.Location = New System.Drawing.Point(6, 5)
        Me.grp_otherdetail.Name = "grp_otherdetail"
        Me.grp_otherdetail.Size = New System.Drawing.Size(903, 126)
        Me.grp_otherdetail.TabIndex = 0
        Me.grp_otherdetail.TabStop = False
        Me.grp_otherdetail.Text = "Other Details"
        '
        'chkcivil
        '
        Me.chkcivil.AutoSize = True
        Me.chkcivil.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkcivil.Location = New System.Drawing.Point(8, 63)
        Me.chkcivil.Name = "chkcivil"
        Me.chkcivil.Size = New System.Drawing.Size(137, 17)
        Me.chkcivil.TabIndex = 2
        Me.chkcivil.Text = "Civil/Criminal Litigation :"
        Me.chkcivil.UseVisualStyleBackColor = True
        '
        'txtlitigationdetail
        '
        Me.txtlitigationdetail.CheckBounds = False
        Me.txtlitigationdetail.DateFormat = Nothing
        Me.txtlitigationdetail.DecimalPlaces = CType(0, Byte)
        Me.txtlitigationdetail.Location = New System.Drawing.Point(513, 64)
        Me.txtlitigationdetail.MaxDate = New Date(CType(0, Long))
        Me.txtlitigationdetail.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlitigationdetail.MinDate = New Date(CType(0, Long))
        Me.txtlitigationdetail.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlitigationdetail.Name = "txtlitigationdetail"
        Me.txtlitigationdetail.Size = New System.Drawing.Size(217, 20)
        Me.txtlitigationdetail.TabIndex = 3
        Me.txtlitigationdetail.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtrelieveddate
        '
        Me.txtrelieveddate.CheckBounds = False
        Me.txtrelieveddate.DateFormat = Nothing
        Me.txtrelieveddate.DecimalPlaces = CType(0, Byte)
        Me.txtrelieveddate.Location = New System.Drawing.Point(122, 96)
        Me.txtrelieveddate.MaxDate = New Date(CType(0, Long))
        Me.txtrelieveddate.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtrelieveddate.MinDate = New Date(CType(0, Long))
        Me.txtrelieveddate.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtrelieveddate.Name = "txtrelieveddate"
        Me.txtrelieveddate.Size = New System.Drawing.Size(217, 20)
        Me.txtrelieveddate.TabIndex = 4
        Me.txtrelieveddate.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Dates
        '
        'txtjobprofile
        '
        Me.txtjobprofile.CheckBounds = False
        Me.txtjobprofile.DateFormat = Nothing
        Me.txtjobprofile.DecimalPlaces = CType(0, Byte)
        Me.txtjobprofile.Location = New System.Drawing.Point(122, 27)
        Me.txtjobprofile.MaxDate = New Date(CType(0, Long))
        Me.txtjobprofile.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjobprofile.MinDate = New Date(CType(0, Long))
        Me.txtjobprofile.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjobprofile.Name = "txtjobprofile"
        Me.txtjobprofile.Size = New System.Drawing.Size(217, 20)
        Me.txtjobprofile.TabIndex = 0
        Me.txtjobprofile.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'cmbleavereason
        '
        Me.cmbleavereason.AutoDropDown = False
        Me.cmbleavereason.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbleavereason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbleavereason.FormattingEnabled = True
        Me.cmbleavereason.Items.AddRange(New Object() {"", "Depth", "Left", "Resigned", "Terminated", "Retied", "Transfer"})
        Me.cmbleavereason.Location = New System.Drawing.Point(513, 96)
        Me.cmbleavereason.Name = "cmbleavereason"
        Me.cmbleavereason.Size = New System.Drawing.Size(217, 21)
        Me.cmbleavereason.TabIndex = 5
        '
        'cmbempposition
        '
        Me.cmbempposition.AutoDropDown = False
        Me.cmbempposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbempposition.FormattingEnabled = True
        Me.cmbempposition.Items.AddRange(New Object() {"", "Administration", "Management", "Senior", "Junior"})
        Me.cmbempposition.Location = New System.Drawing.Point(513, 26)
        Me.cmbempposition.Name = "cmbempposition"
        Me.cmbempposition.Size = New System.Drawing.Size(217, 21)
        Me.cmbempposition.TabIndex = 1
        '
        'lbllitigationdetail
        '
        Me.lbllitigationdetail.AutoSize = True
        Me.lbllitigationdetail.Location = New System.Drawing.Point(387, 67)
        Me.lbllitigationdetail.Name = "lbllitigationdetail"
        Me.lbllitigationdetail.Size = New System.Drawing.Size(87, 13)
        Me.lbllitigationdetail.TabIndex = 24
        Me.lbllitigationdetail.Text = "Litigation Details:"
        '
        'lblleavereason
        '
        Me.lblleavereason.AutoSize = True
        Me.lblleavereason.Location = New System.Drawing.Point(387, 99)
        Me.lblleavereason.Name = "lblleavereason"
        Me.lblleavereason.Size = New System.Drawing.Size(106, 13)
        Me.lblleavereason.TabIndex = 21
        Me.lblleavereason.Text = "Reason For Leaving:"
        '
        'lblrelieveddate
        '
        Me.lblrelieveddate.AutoSize = True
        Me.lblrelieveddate.Location = New System.Drawing.Point(10, 99)
        Me.lblrelieveddate.Name = "lblrelieveddate"
        Me.lblrelieveddate.Size = New System.Drawing.Size(78, 13)
        Me.lblrelieveddate.TabIndex = 20
        Me.lblrelieveddate.Text = "Relieved Date:"
        '
        'lblpos
        '
        Me.lblpos.AutoSize = True
        Me.lblpos.Location = New System.Drawing.Point(387, 30)
        Me.lblpos.Name = "lblpos"
        Me.lblpos.Size = New System.Drawing.Size(51, 13)
        Me.lblpos.TabIndex = 16
        Me.lblpos.Text = "Position*:"
        '
        'lbljobprofile
        '
        Me.lbljobprofile.AutoSize = True
        Me.lbljobprofile.Location = New System.Drawing.Point(10, 30)
        Me.lbljobprofile.Name = "lbljobprofile"
        Me.lbljobprofile.Size = New System.Drawing.Size(63, 13)
        Me.lbljobprofile.TabIndex = 15
        Me.lbljobprofile.Text = "Job Profile*:"
        '
        'frm_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 577)
        Me.Controls.Add(Me.tabcontrol_empdetail)
        Me.Controls.Add(Me.btnearning)
        Me.Controls.Add(Me.btnemphistory)
        Me.Controls.Add(Me.btnqualification)
        Me.Controls.Add(Me.btnfamilydeatils)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.tabcontrol_empdetail.ResumeLayout(False)
        Me.EmployeeDetails.ResumeLayout(False)
        Me.panel_empdetail3.ResumeLayout(False)
        Me.panel_empdetail3.PerformLayout()
        Me.panel_empdetail4S.ResumeLayout(False)
        Me.panel_empdetail4S.PerformLayout()
        Me.panel_empdetail2.ResumeLayout(False)
        Me.panel_empdetail2.PerformLayout()
        Me.panel_empdetail1.ResumeLayout(False)
        Me.panel_empdetail1.PerformLayout()
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OtherDetails.ResumeLayout(False)
        Me.OtherDetails.PerformLayout()
        Me.grp_incometax.ResumeLayout(False)
        Me.grp_incometax.PerformLayout()
        Me.grp_vehicledetail.ResumeLayout(False)
        Me.grp_vehicledetail.PerformLayout()
        Me.grp_bank_reference_detail.ResumeLayout(False)
        Me.grp_bank_reference_detail.PerformLayout()
        Me.grp_otherdetail.ResumeLayout(False)
        Me.grp_otherdetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfamilydeatils As System.Windows.Forms.Button
    Friend WithEvents btnqualification As System.Windows.Forms.Button
    Friend WithEvents btnemphistory As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
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
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtempnamefind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents lblempcodefind As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtempcodefind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnearning As System.Windows.Forms.Button
    Friend WithEvents tabcontrol_empdetail As System.Windows.Forms.TabControl
    Friend WithEvents EmployeeDetails As System.Windows.Forms.TabPage
    Friend WithEvents panel_empdetail3 As System.Windows.Forms.Panel
    Friend WithEvents txtpermntcity As DefaultControls.MaskedBox
    Friend WithEvents txtpermnttelephno As DefaultControls.MaskedBox
    Friend WithEvents txtpermntpinno As DefaultControls.MaskedBox
    Friend WithEvents txtpermntstate As DefaultControls.MaskedBox
    Friend WithEvents lblpermanentadd As System.Windows.Forms.Label
    Friend WithEvents lblpercity As System.Windows.Forms.Label
    Friend WithEvents lblperpinno As System.Windows.Forms.Label
    Friend WithEvents lblperteleno As System.Windows.Forms.Label
    Friend WithEvents lblperstate As System.Windows.Forms.Label
    Friend WithEvents panel_empdetail4S As System.Windows.Forms.Panel
    Friend WithEvents txtempsalary As DefaultControls.MaskedBox
    Friend WithEvents txtemailadd As DefaultControls.MaskedBox
    Friend WithEvents txtnationality As DefaultControls.MaskedBox
    Friend WithEvents txtbirthplace As DefaultControls.MaskedBox
    Friend WithEvents txtempage As DefaultControls.MaskedBox
    Friend WithEvents txtbirthdate As DefaultControls.MaskedBox
    Friend WithEvents txtmobileno As DefaultControls.MaskedBox
    Friend WithEvents cmbbloodgroup As DefaultControls.ComboBox
    Friend WithEvents cmbpayrolltype As DefaultControls.ComboBox
    Friend WithEvents lblempsalary As System.Windows.Forms.Label
    Friend WithEvents lblbloodgroup As System.Windows.Forms.Label
    Friend WithEvents lblemailadd As System.Windows.Forms.Label
    Friend WithEvents lblpayrolltype As System.Windows.Forms.Label
    Friend WithEvents lblnationality As System.Windows.Forms.Label
    Friend WithEvents lblbirthplace As System.Windows.Forms.Label
    Friend WithEvents lblbirthdate As System.Windows.Forms.Label
    Friend WithEvents lblmobileno As System.Windows.Forms.Label
    Friend WithEvents panel_empdetail2 As System.Windows.Forms.Panel
    Friend WithEvents txtcurrentpinno As DefaultControls.MaskedBox
    Friend WithEvents txtcurrenttelephno As DefaultControls.MaskedBox
    Friend WithEvents txtcurrentstate As DefaultControls.MaskedBox
    Friend WithEvents txtcurrentcity As DefaultControls.MaskedBox
    Friend WithEvents btnsameaddresspass As System.Windows.Forms.Button
    Friend WithEvents lblpinno As System.Windows.Forms.Label
    Friend WithEvents lblstate As System.Windows.Forms.Label
    Friend WithEvents lbltelephno As System.Windows.Forms.Label
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblcurrentadd As System.Windows.Forms.Label
    Friend WithEvents panel_empdetail1 As System.Windows.Forms.Panel
    Friend WithEvents chkinactive As DefaultControls.CheckBox
    Friend WithEvents chkpermanent As DefaultControls.CheckBox
    Friend WithEvents txtempcode As DefaultControls.MaskedBox
    Friend WithEvents txtjoiningdate As DefaultControls.MaskedBox
    Friend WithEvents txtshortname As DefaultControls.MaskedBox
    Friend WithEvents txtlastname As DefaultControls.MaskedBox
    Friend WithEvents txtmiddlename As DefaultControls.MaskedBox
    Friend WithEvents txtfirstname As DefaultControls.MaskedBox
    Friend WithEvents cmbgender As DefaultControls.ComboBox
    Friend WithEvents cmbmartialstatus As DefaultControls.ComboBox
    Friend WithEvents cmbdepartmentnm As DefaultControls.ComboBox
    Friend WithEvents cmblocationname As DefaultControls.ComboBox
    Friend WithEvents lblempcode As System.Windows.Forms.Label
    Friend WithEvents lbldepartment As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnload As System.Windows.Forms.Button
    Friend WithEvents empphoto As System.Windows.Forms.PictureBox
    Friend WithEvents lbljoindate As System.Windows.Forms.Label
    Friend WithEvents lblmaritalsts As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblshortname As System.Windows.Forms.Label
    Friend WithEvents lbllastname As System.Windows.Forms.Label
    Friend WithEvents lblmiddlename As System.Windows.Forms.Label
    Friend WithEvents lblfirstname As System.Windows.Forms.Label
    Friend WithEvents lbllocname As System.Windows.Forms.Label
    Friend WithEvents OtherDetails As System.Windows.Forms.TabPage
    Friend WithEvents txthobbies As DefaultControls.MaskedBox
    Friend WithEvents grp_incometax As System.Windows.Forms.GroupBox
    Friend WithEvents chkdisabled As DefaultControls.CheckBox
    Friend WithEvents txtpercentofdisabled As DefaultControls.MaskedBox
    Friend WithEvents txtdisablednote As DefaultControls.MaskedBox
    Friend WithEvents txtnoofchild As DefaultControls.MaskedBox
    Friend WithEvents txtPANno As DefaultControls.MaskedBox
    Friend WithEvents lblpanno As System.Windows.Forms.Label
    Friend WithEvents lblpercentdisabled As System.Windows.Forms.Label
    Friend WithEvents lbldisablednote As System.Windows.Forms.Label
    Friend WithEvents lblnoofchild As System.Windows.Forms.Label
    Friend WithEvents lblhobies As System.Windows.Forms.Label
    Friend WithEvents grp_vehicledetail As System.Windows.Forms.GroupBox
    Friend WithEvents txtrationcardno As DefaultControls.MaskedBox
    Friend WithEvents txtvehicleno As DefaultControls.MaskedBox
    Friend WithEvents txtvehicletype As DefaultControls.MaskedBox
    Friend WithEvents txtdrivinglicenseno As DefaultControls.MaskedBox
    Friend WithEvents txtvalidtill As DefaultControls.MaskedBox
    Friend WithEvents txtplaceofissue As DefaultControls.MaskedBox
    Friend WithEvents txtdateofissue As DefaultControls.MaskedBox
    Friend WithEvents txtpassportno As DefaultControls.MaskedBox
    Friend WithEvents lblrationno As System.Windows.Forms.Label
    Friend WithEvents lblvalidtill As System.Windows.Forms.Label
    Friend WithEvents lblvehicleno As System.Windows.Forms.Label
    Friend WithEvents lblissueplace As System.Windows.Forms.Label
    Friend WithEvents lblpassportno As System.Windows.Forms.Label
    Friend WithEvents lbllicenseno As System.Windows.Forms.Label
    Friend WithEvents lblvehicletype As System.Windows.Forms.Label
    Friend WithEvents lblissuedate As System.Windows.Forms.Label
    Friend WithEvents grp_bank_reference_detail As System.Windows.Forms.GroupBox
    Friend WithEvents txtreference2 As DefaultControls.MaskedBox
    Friend WithEvents txtreference1 As DefaultControls.MaskedBox
    Friend WithEvents cmbbankname As DefaultControls.ComboBox
    Friend WithEvents lblreference1 As System.Windows.Forms.Label
    Friend WithEvents lblreference2 As System.Windows.Forms.Label
    Friend WithEvents lblbankacno As System.Windows.Forms.Label
    Friend WithEvents lblbanknm As System.Windows.Forms.Label
    Friend WithEvents grp_otherdetail As System.Windows.Forms.GroupBox
    Friend WithEvents chkcivil As DefaultControls.CheckBox
    Friend WithEvents txtlitigationdetail As DefaultControls.MaskedBox
    Friend WithEvents txtrelieveddate As DefaultControls.MaskedBox
    Friend WithEvents txtjobprofile As DefaultControls.MaskedBox
    Friend WithEvents cmbleavereason As DefaultControls.ComboBox
    Friend WithEvents cmbempposition As DefaultControls.ComboBox
    Friend WithEvents lbllitigationdetail As System.Windows.Forms.Label
    Friend WithEvents lblleavereason As System.Windows.Forms.Label
    Friend WithEvents lblrelieveddate As System.Windows.Forms.Label
    Friend WithEvents lblpos As System.Windows.Forms.Label
    Friend WithEvents lbljobprofile As System.Windows.Forms.Label
    Friend WithEvents txtcurrentadd As System.Windows.Forms.TextBox
    Friend WithEvents txtpermanentadd As System.Windows.Forms.TextBox
    Friend WithEvents txtcondate As DefaultControls.MaskedBox
    Friend WithEvents lblconfirm As System.Windows.Forms.Label
    Friend WithEvents txtbankacno As DefaultControls.MaskedBox
End Class
