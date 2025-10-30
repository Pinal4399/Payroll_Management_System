<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_training_venue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_training_venue))
        Me.bnvtrainingvenue = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.lblvenuefind = New System.Windows.Forms.ToolStripLabel
        Me.txtvenuefind = New System.Windows.Forms.ToolStripTextBox
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.pnl_training_venue = New System.Windows.Forms.Panel
        Me.DateTimePickerfromdate = New DefaultControls.DateTimePicker
        Me.DateTimePickertodate = New DefaultControls.DateTimePicker
        Me.lbltodt = New System.Windows.Forms.Label
        Me.lblfromdt = New System.Windows.Forms.Label
        Me.chkavailable = New DefaultControls.CheckBox
        Me.txtpincode = New DefaultControls.MaskedBox(Me.components)
        Me.lblzip = New System.Windows.Forms.Label
        Me.txtcost = New DefaultControls.MaskedBox(Me.components)
        Me.txtcapacity = New DefaultControls.MaskedBox(Me.components)
        Me.txtcity = New DefaultControls.MaskedBox(Me.components)
        Me.txtvenuenm = New DefaultControls.MaskedBox(Me.components)
        Me.lblcity = New System.Windows.Forms.Label
        Me.lblcost = New System.Windows.Forms.Label
        Me.lblcapacity = New System.Windows.Forms.Label
        Me.lbladd = New System.Windows.Forms.Label
        Me.lbldesc = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.TextBox
        CType(Me.bnvtrainingvenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnvtrainingvenue.SuspendLayout()
        Me.pnl_training_venue.SuspendLayout()
        Me.SuspendLayout()
        '
        'bnvtrainingvenue
        '
        Me.bnvtrainingvenue.AddNewItem = Me.btnadd
        Me.bnvtrainingvenue.CountItem = Me.BindingNavigatorCountItem1
        Me.bnvtrainingvenue.DeleteItem = Me.btndelete
        Me.bnvtrainingvenue.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave, Me.ToolStripSeparator1, Me.lblvenuefind, Me.txtvenuefind, Me.btnfind})
        Me.bnvtrainingvenue.Location = New System.Drawing.Point(0, 0)
        Me.bnvtrainingvenue.MoveFirstItem = Me.btnfirst
        Me.bnvtrainingvenue.MoveLastItem = Me.btnlast
        Me.bnvtrainingvenue.MoveNextItem = Me.btnnext
        Me.bnvtrainingvenue.MovePreviousItem = Me.btnprevious
        Me.bnvtrainingvenue.Name = "bnvtrainingvenue"
        Me.bnvtrainingvenue.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bnvtrainingvenue.Size = New System.Drawing.Size(693, 25)
        Me.bnvtrainingvenue.TabIndex = 10
        Me.bnvtrainingvenue.Text = "BindingNavigator1"
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
        'lblvenuefind
        '
        Me.lblvenuefind.Name = "lblvenuefind"
        Me.lblvenuefind.Size = New System.Drawing.Size(44, 22)
        Me.lblvenuefind.Text = "&Venue :"
        '
        'txtvenuefind
        '
        Me.txtvenuefind.Name = "txtvenuefind"
        Me.txtvenuefind.Size = New System.Drawing.Size(100, 25)
        Me.txtvenuefind.Text = "%"
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
        'pnl_training_venue
        '
        Me.pnl_training_venue.Controls.Add(Me.txtadd)
        Me.pnl_training_venue.Controls.Add(Me.DateTimePickerfromdate)
        Me.pnl_training_venue.Controls.Add(Me.DateTimePickertodate)
        Me.pnl_training_venue.Controls.Add(Me.lbltodt)
        Me.pnl_training_venue.Controls.Add(Me.lblfromdt)
        Me.pnl_training_venue.Controls.Add(Me.chkavailable)
        Me.pnl_training_venue.Controls.Add(Me.txtpincode)
        Me.pnl_training_venue.Controls.Add(Me.lblzip)
        Me.pnl_training_venue.Controls.Add(Me.txtcost)
        Me.pnl_training_venue.Controls.Add(Me.txtcapacity)
        Me.pnl_training_venue.Controls.Add(Me.txtcity)
        Me.pnl_training_venue.Controls.Add(Me.txtvenuenm)
        Me.pnl_training_venue.Controls.Add(Me.lblcity)
        Me.pnl_training_venue.Controls.Add(Me.lblcost)
        Me.pnl_training_venue.Controls.Add(Me.lblcapacity)
        Me.pnl_training_venue.Controls.Add(Me.lbladd)
        Me.pnl_training_venue.Controls.Add(Me.lbldesc)
        Me.pnl_training_venue.Location = New System.Drawing.Point(20, 35)
        Me.pnl_training_venue.Name = "pnl_training_venue"
        Me.pnl_training_venue.Size = New System.Drawing.Size(654, 291)
        Me.pnl_training_venue.TabIndex = 11
        '
        'DateTimePickerfromdate
        '
        Me.DateTimePickerfromdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerfromdate.Location = New System.Drawing.Point(127, 247)
        Me.DateTimePickerfromdate.Name = "DateTimePickerfromdate"
        Me.DateTimePickerfromdate.Size = New System.Drawing.Size(190, 20)
        Me.DateTimePickerfromdate.TabIndex = 7
        Me.DateTimePickerfromdate.Value = New Date(2010, 3, 29, 0, 0, 0, 0)
        '
        'DateTimePickertodate
        '
        Me.DateTimePickertodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickertodate.Location = New System.Drawing.Point(425, 247)
        Me.DateTimePickertodate.Name = "DateTimePickertodate"
        Me.DateTimePickertodate.Size = New System.Drawing.Size(190, 20)
        Me.DateTimePickertodate.TabIndex = 8
        Me.DateTimePickertodate.Value = New Date(2010, 3, 29, 0, 0, 0, 0)
        '
        'lbltodt
        '
        Me.lbltodt.AutoSize = True
        Me.lbltodt.Location = New System.Drawing.Point(353, 251)
        Me.lbltodt.Name = "lbltodt"
        Me.lbltodt.Size = New System.Drawing.Size(56, 13)
        Me.lbltodt.TabIndex = 56
        Me.lbltodt.Text = "To Date :*"
        '
        'lblfromdt
        '
        Me.lblfromdt.AutoSize = True
        Me.lblfromdt.Location = New System.Drawing.Point(20, 251)
        Me.lblfromdt.Name = "lblfromdt"
        Me.lblfromdt.Size = New System.Drawing.Size(66, 13)
        Me.lblfromdt.TabIndex = 55
        Me.lblfromdt.Text = "From Date :*"
        '
        'chkavailable
        '
        Me.chkavailable.AutoSize = True
        Me.chkavailable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkavailable.Location = New System.Drawing.Point(21, 219)
        Me.chkavailable.Name = "chkavailable"
        Me.chkavailable.Size = New System.Drawing.Size(121, 17)
        Me.chkavailable.TabIndex = 6
        Me.chkavailable.Text = "Availability :*            "
        Me.chkavailable.UseVisualStyleBackColor = True
        '
        'txtpincode
        '
        Me.txtpincode.CheckBounds = False
        Me.txtpincode.DateFormat = Nothing
        Me.txtpincode.DecimalPlaces = CType(0, Byte)
        Me.txtpincode.Location = New System.Drawing.Point(425, 123)
        Me.txtpincode.MaxDate = New Date(CType(0, Long))
        Me.txtpincode.MaxLength = 6
        Me.txtpincode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpincode.MinDate = New Date(CType(0, Long))
        Me.txtpincode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpincode.Name = "txtpincode"
        Me.txtpincode.Size = New System.Drawing.Size(190, 20)
        Me.txtpincode.TabIndex = 3
        Me.txtpincode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'lblzip
        '
        Me.lblzip.AutoSize = True
        Me.lblzip.Location = New System.Drawing.Point(353, 126)
        Me.lblzip.Name = "lblzip"
        Me.lblzip.Size = New System.Drawing.Size(52, 13)
        Me.lblzip.TabIndex = 41
        Me.lblzip.Text = "Pincode :"
        '
        'txtcost
        '
        Me.txtcost.CheckBounds = False
        Me.txtcost.DateFormat = Nothing
        Me.txtcost.DecimalPlaces = CType(0, Byte)
        Me.txtcost.Location = New System.Drawing.Point(127, 188)
        Me.txtcost.MaxDate = New Date(CType(0, Long))
        Me.txtcost.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcost.MinDate = New Date(CType(0, Long))
        Me.txtcost.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(190, 20)
        Me.txtcost.TabIndex = 5
        Me.txtcost.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtcapacity
        '
        Me.txtcapacity.CheckBounds = False
        Me.txtcapacity.DateFormat = Nothing
        Me.txtcapacity.DecimalPlaces = CType(0, Byte)
        Me.txtcapacity.Location = New System.Drawing.Point(127, 156)
        Me.txtcapacity.MaxDate = New Date(CType(0, Long))
        Me.txtcapacity.MaxLength = 6
        Me.txtcapacity.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcapacity.MinDate = New Date(CType(0, Long))
        Me.txtcapacity.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcapacity.Name = "txtcapacity"
        Me.txtcapacity.Size = New System.Drawing.Size(190, 20)
        Me.txtcapacity.TabIndex = 4
        Me.txtcapacity.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtcity
        '
        Me.txtcity.CheckBounds = False
        Me.txtcity.DateFormat = Nothing
        Me.txtcity.DecimalPlaces = CType(0, Byte)
        Me.txtcity.Location = New System.Drawing.Point(127, 123)
        Me.txtcity.MaxDate = New Date(CType(0, Long))
        Me.txtcity.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.MinDate = New Date(CType(0, Long))
        Me.txtcity.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(190, 20)
        Me.txtcity.TabIndex = 2
        Me.txtcity.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtvenuenm
        '
        Me.txtvenuenm.CheckBounds = False
        Me.txtvenuenm.DateFormat = Nothing
        Me.txtvenuenm.DecimalPlaces = CType(0, Byte)
        Me.txtvenuenm.Location = New System.Drawing.Point(127, 21)
        Me.txtvenuenm.MaxDate = New Date(CType(0, Long))
        Me.txtvenuenm.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvenuenm.MinDate = New Date(CType(0, Long))
        Me.txtvenuenm.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtvenuenm.Name = "txtvenuenm"
        Me.txtvenuenm.Size = New System.Drawing.Size(488, 20)
        Me.txtvenuenm.TabIndex = 0
        Me.txtvenuenm.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Location = New System.Drawing.Point(20, 126)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(34, 13)
        Me.lblcity.TabIndex = 27
        Me.lblcity.Text = "City :*"
        '
        'lblcost
        '
        Me.lblcost.AutoSize = True
        Me.lblcost.Location = New System.Drawing.Point(20, 186)
        Me.lblcost.Name = "lblcost"
        Me.lblcost.Size = New System.Drawing.Size(38, 13)
        Me.lblcost.TabIndex = 10
        Me.lblcost.Text = "Cost :*"
        '
        'lblcapacity
        '
        Me.lblcapacity.AutoSize = True
        Me.lblcapacity.Location = New System.Drawing.Point(20, 156)
        Me.lblcapacity.Name = "lblcapacity"
        Me.lblcapacity.Size = New System.Drawing.Size(58, 13)
        Me.lblcapacity.TabIndex = 8
        Me.lblcapacity.Text = "Capacity :*"
        '
        'lbladd
        '
        Me.lbladd.AutoSize = True
        Me.lbladd.Location = New System.Drawing.Point(20, 62)
        Me.lbladd.Name = "lbladd"
        Me.lbladd.Size = New System.Drawing.Size(55, 13)
        Me.lbladd.TabIndex = 6
        Me.lbladd.Text = "Address :*"
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Location = New System.Drawing.Point(20, 24)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(48, 13)
        Me.lbldesc.TabIndex = 2
        Me.lbldesc.Text = "Venue :*"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(127, 54)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtadd.Size = New System.Drawing.Size(488, 58)
        Me.txtadd.TabIndex = 1
        '
        'frm_training_venue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 342)
        Me.Controls.Add(Me.pnl_training_venue)
        Me.Controls.Add(Me.bnvtrainingvenue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_training_venue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training Venue"
        CType(Me.bnvtrainingvenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnvtrainingvenue.ResumeLayout(False)
        Me.bnvtrainingvenue.PerformLayout()
        Me.pnl_training_venue.ResumeLayout(False)
        Me.pnl_training_venue.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnvtrainingvenue As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents lblvenuefind As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtvenuefind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_training_venue As System.Windows.Forms.Panel
    Friend WithEvents chkavailable As DefaultControls.CheckBox
    Friend WithEvents txtpincode As DefaultControls.MaskedBox
    Friend WithEvents lblzip As System.Windows.Forms.Label
    Friend WithEvents txtcost As DefaultControls.MaskedBox
    Friend WithEvents txtcapacity As DefaultControls.MaskedBox
    Friend WithEvents txtcity As DefaultControls.MaskedBox
    Friend WithEvents txtvenuenm As DefaultControls.MaskedBox
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblcost As System.Windows.Forms.Label
    Friend WithEvents lblcapacity As System.Windows.Forms.Label
    Friend WithEvents lbladd As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerfromdate As DefaultControls.DateTimePicker
    Friend WithEvents DateTimePickertodate As DefaultControls.DateTimePicker
    Friend WithEvents lbltodt As System.Windows.Forms.Label
    Friend WithEvents lblfromdt As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
End Class
