<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_department))
        Me.deptpanel = New System.Windows.Forms.Panel
        Me.chkisactive = New DefaultControls.CheckBox
        Me.cmbhodempcode = New DefaultControls.ComboBox
        Me.txthodempname = New DefaultControls.MaskedBox(Me.components)
        Me.txtdeptdesc = New DefaultControls.MaskedBox(Me.components)
        Me.txtdepartmentname = New DefaultControls.MaskedBox(Me.components)
        Me.txtdepartmentcode = New DefaultControls.MaskedBox(Me.components)
        Me.lbl_hodempid = New System.Windows.Forms.Label
        Me.lbldescription = New System.Windows.Forms.Label
        Me.lbldepartmentname = New System.Windows.Forms.Label
        Me.lbldepartmentcode = New System.Windows.Forms.Label
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
        Me.lbldepartname = New System.Windows.Forms.ToolStripLabel
        Me.txtdeptnamefind = New System.Windows.Forms.ToolStripTextBox
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.lbllocationname = New System.Windows.Forms.ToolStripLabel
        Me.bnvcmbLocation = New System.Windows.Forms.ToolStripComboBox
        Me.deptpanel.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'deptpanel
        '
        Me.deptpanel.Controls.Add(Me.chkisactive)
        Me.deptpanel.Controls.Add(Me.cmbhodempcode)
        Me.deptpanel.Controls.Add(Me.txthodempname)
        Me.deptpanel.Controls.Add(Me.txtdeptdesc)
        Me.deptpanel.Controls.Add(Me.txtdepartmentname)
        Me.deptpanel.Controls.Add(Me.txtdepartmentcode)
        Me.deptpanel.Controls.Add(Me.lbl_hodempid)
        Me.deptpanel.Controls.Add(Me.lbldescription)
        Me.deptpanel.Controls.Add(Me.lbldepartmentname)
        Me.deptpanel.Controls.Add(Me.lbldepartmentcode)
        Me.deptpanel.Location = New System.Drawing.Point(12, 39)
        Me.deptpanel.Name = "deptpanel"
        Me.deptpanel.Size = New System.Drawing.Size(805, 192)
        Me.deptpanel.TabIndex = 10
        '
        'chkisactive
        '
        Me.chkisactive.AutoSize = True
        Me.chkisactive.Location = New System.Drawing.Point(467, 25)
        Me.chkisactive.Name = "chkisactive"
        Me.chkisactive.Size = New System.Drawing.Size(67, 17)
        Me.chkisactive.TabIndex = 4
        Me.chkisactive.Text = "Is Active"
        Me.chkisactive.UseVisualStyleBackColor = True
        '
        'cmbhodempcode
        '
        Me.cmbhodempcode.AutoDropDown = False
        Me.cmbhodempcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbhodempcode.FormattingEnabled = True
        Me.cmbhodempcode.Location = New System.Drawing.Point(155, 102)
        Me.cmbhodempcode.Name = "cmbhodempcode"
        Me.cmbhodempcode.Size = New System.Drawing.Size(244, 21)
        Me.cmbhodempcode.TabIndex = 2
        '
        'txthodempname
        '
        Me.txthodempname.CheckBounds = False
        Me.txthodempname.DateFormat = Nothing
        Me.txthodempname.DecimalPlaces = CType(0, Byte)
        Me.txthodempname.Enabled = False
        Me.txthodempname.Location = New System.Drawing.Point(414, 102)
        Me.txthodempname.MaxDate = New Date(CType(0, Long))
        Me.txthodempname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txthodempname.MinDate = New Date(CType(0, Long))
        Me.txthodempname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txthodempname.Name = "txthodempname"
        Me.txthodempname.Size = New System.Drawing.Size(378, 20)
        Me.txthodempname.TabIndex = 12
        Me.txthodempname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtdeptdesc
        '
        Me.txtdeptdesc.CheckBounds = False
        Me.txtdeptdesc.DateFormat = Nothing
        Me.txtdeptdesc.DecimalPlaces = CType(0, Byte)
        Me.txtdeptdesc.Location = New System.Drawing.Point(155, 141)
        Me.txtdeptdesc.MaxDate = New Date(CType(0, Long))
        Me.txtdeptdesc.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdeptdesc.MinDate = New Date(CType(0, Long))
        Me.txtdeptdesc.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdeptdesc.Name = "txtdeptdesc"
        Me.txtdeptdesc.Size = New System.Drawing.Size(244, 20)
        Me.txtdeptdesc.TabIndex = 3
        Me.txtdeptdesc.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtdepartmentname
        '
        Me.txtdepartmentname.CheckBounds = False
        Me.txtdepartmentname.DateFormat = Nothing
        Me.txtdepartmentname.DecimalPlaces = CType(0, Byte)
        Me.txtdepartmentname.Location = New System.Drawing.Point(155, 64)
        Me.txtdepartmentname.MaxDate = New Date(CType(0, Long))
        Me.txtdepartmentname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdepartmentname.MinDate = New Date(CType(0, Long))
        Me.txtdepartmentname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdepartmentname.Name = "txtdepartmentname"
        Me.txtdepartmentname.Size = New System.Drawing.Size(244, 20)
        Me.txtdepartmentname.TabIndex = 1
        Me.txtdepartmentname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtdepartmentcode
        '
        Me.txtdepartmentcode.CheckBounds = False
        Me.txtdepartmentcode.DateFormat = Nothing
        Me.txtdepartmentcode.DecimalPlaces = CType(0, Byte)
        Me.txtdepartmentcode.Location = New System.Drawing.Point(155, 23)
        Me.txtdepartmentcode.MaxDate = New Date(CType(0, Long))
        Me.txtdepartmentcode.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdepartmentcode.MinDate = New Date(CType(0, Long))
        Me.txtdepartmentcode.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdepartmentcode.Name = "txtdepartmentcode"
        Me.txtdepartmentcode.Size = New System.Drawing.Size(244, 20)
        Me.txtdepartmentcode.TabIndex = 0
        Me.txtdepartmentcode.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lbl_hodempid
        '
        Me.lbl_hodempid.AutoSize = True
        Me.lbl_hodempid.Location = New System.Drawing.Point(31, 105)
        Me.lbl_hodempid.Name = "lbl_hodempid"
        Me.lbl_hodempid.Size = New System.Drawing.Size(74, 13)
        Me.lbl_hodempid.TabIndex = 7
        Me.lbl_hodempid.Text = "HOD EmpId *:"
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.Location = New System.Drawing.Point(31, 144)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(66, 13)
        Me.lbldescription.TabIndex = 5
        Me.lbldescription.Text = "Description :"
        '
        'lbldepartmentname
        '
        Me.lbldepartmentname.AutoSize = True
        Me.lbldepartmentname.Location = New System.Drawing.Point(31, 67)
        Me.lbldepartmentname.Name = "lbldepartmentname"
        Me.lbldepartmentname.Size = New System.Drawing.Size(103, 13)
        Me.lbldepartmentname.TabIndex = 3
        Me.lbldepartmentname.Text = "Department Name *:"
        '
        'lbldepartmentcode
        '
        Me.lbldepartmentcode.AutoSize = True
        Me.lbldepartmentcode.Location = New System.Drawing.Point(31, 26)
        Me.lbldepartmentcode.Name = "lbldepartmentcode"
        Me.lbldepartmentcode.Size = New System.Drawing.Size(100, 13)
        Me.lbldepartmentcode.TabIndex = 0
        Me.lbldepartmentcode.Text = "Department Code *:"
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
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(36, 22)
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
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.RightToLeftAutoMirrorImage = True
        Me.btnadd.Size = New System.Drawing.Size(69, 22)
        Me.btnadd.Text = "&Add new"
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.RightToLeftAutoMirrorImage = True
        Me.btndelete.Size = New System.Drawing.Size(58, 22)
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
        'lbldepartname
        '
        Me.lbldepartname.Name = "lbldepartname"
        Me.lbldepartname.Size = New System.Drawing.Size(98, 22)
        Me.lbldepartname.Text = "D&epartment Name:"
        '
        'txtdeptnamefind
        '
        Me.txtdeptnamefind.Name = "txtdeptnamefind"
        Me.txtdeptnamefind.Size = New System.Drawing.Size(100, 25)
        Me.txtdeptnamefind.Text = "%"
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
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.btnadd
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.btndelete
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave, Me.ToolStripSeparator1, Me.lbllocationname, Me.bnvcmbLocation, Me.lbldepartname, Me.txtdeptnamefind, Me.btnfind})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnfirst
        Me.BindingNavigator1.MoveLastItem = Me.btnlast
        Me.BindingNavigator1.MoveNextItem = Me.btnnext
        Me.BindingNavigator1.MovePreviousItem = Me.btnprevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(969, 25)
        Me.BindingNavigator1.TabIndex = 8
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'lbllocationname
        '
        Me.lbllocationname.Name = "lbllocationname"
        Me.lbllocationname.Size = New System.Drawing.Size(84, 22)
        Me.lbllocationname.Text = "L&ocation  Name:"
        '
        'bnvcmbLocation
        '
        Me.bnvcmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bnvcmbLocation.Name = "bnvcmbLocation"
        Me.bnvcmbLocation.Size = New System.Drawing.Size(121, 25)
        '
        'frm_department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 253)
        Me.Controls.Add(Me.deptpanel)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_department"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department"
        Me.deptpanel.ResumeLayout(False)
        Me.deptpanel.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deptpanel As System.Windows.Forms.Panel
    Friend WithEvents lbl_hodempid As System.Windows.Forms.Label
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents lbldepartmentname As System.Windows.Forms.Label
    Friend WithEvents lbldepartmentcode As System.Windows.Forms.Label
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
    Friend WithEvents lbldepartname As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtdeptnamefind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents lbllocationname As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bnvcmbLocation As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtdepartmentcode As DefaultControls.MaskedBox
    Friend WithEvents txthodempname As DefaultControls.MaskedBox
    Friend WithEvents txtdeptdesc As DefaultControls.MaskedBox
    Friend WithEvents txtdepartmentname As DefaultControls.MaskedBox
    Friend WithEvents cmbhodempcode As DefaultControls.ComboBox
    Friend WithEvents chkisactive As DefaultControls.CheckBox
End Class
