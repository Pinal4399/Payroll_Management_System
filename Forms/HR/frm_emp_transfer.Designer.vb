<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_emp_transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emp_transfer))
        Me.lbldeptnm = New System.Windows.Forms.Label
        Me.lbllocnm = New System.Windows.Forms.Label
        Me.lblempcd = New System.Windows.Forms.Label
        Me.btntrans = New System.Windows.Forms.Button
        Me.lbltransdt = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.dttime_transdate = New DefaultControls.DateTimePicker
        Me.cmbempcode = New DefaultControls.ComboBox
        Me.cmbdeptname = New DefaultControls.ComboBox
        Me.cmblocname = New DefaultControls.ComboBox
        Me.GroupBox2 = New DefaultControls.GroupBox(Me.components)
        Me.txtsalt = New DefaultControls.MaskedBox(Me.components)
        Me.lblsalt = New System.Windows.Forms.Label
        Me.txtjobt = New DefaultControls.MaskedBox(Me.components)
        Me.cmbposition = New DefaultControls.ComboBox
        Me.cmbpayrolltype = New DefaultControls.ComboBox
        Me.cmbdeptnmt = New DefaultControls.ComboBox
        Me.cmblocnmt = New DefaultControls.ComboBox
        Me.lblloc1 = New System.Windows.Forms.Label
        Me.lblposition1 = New System.Windows.Forms.Label
        Me.lbljob1 = New System.Windows.Forms.Label
        Me.lblpayroll1 = New System.Windows.Forms.Label
        Me.lbldept1 = New System.Windows.Forms.Label
        Me.grp_existing = New DefaultControls.GroupBox(Me.components)
        Me.txtsal = New DefaultControls.MaskedBox(Me.components)
        Me.lblsal = New System.Windows.Forms.Label
        Me.txtposition = New DefaultControls.MaskedBox(Me.components)
        Me.txtjob = New DefaultControls.MaskedBox(Me.components)
        Me.txtpayrolltype = New DefaultControls.MaskedBox(Me.components)
        Me.txtdeptnm = New DefaultControls.MaskedBox(Me.components)
        Me.txtlocnm = New DefaultControls.MaskedBox(Me.components)
        Me.lblloc = New System.Windows.Forms.Label
        Me.lblposition = New System.Windows.Forms.Label
        Me.lbljob = New System.Windows.Forms.Label
        Me.lblpayroll = New System.Windows.Forms.Label
        Me.lbldept = New System.Windows.Forms.Label
        Me.txtempnm = New DefaultControls.MaskedBox(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.grp_existing.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldeptnm
        '
        Me.lbldeptnm.AutoSize = True
        Me.lbldeptnm.Location = New System.Drawing.Point(424, 25)
        Me.lbldeptnm.Name = "lbldeptnm"
        Me.lbldeptnm.Size = New System.Drawing.Size(75, 13)
        Me.lbldeptnm.TabIndex = 21
        Me.lbldeptnm.Text = "Department : *"
        '
        'lbllocnm
        '
        Me.lbllocnm.AutoSize = True
        Me.lbllocnm.Location = New System.Drawing.Point(21, 25)
        Me.lbllocnm.Name = "lbllocnm"
        Me.lbllocnm.Size = New System.Drawing.Size(61, 13)
        Me.lbllocnm.TabIndex = 20
        Me.lbllocnm.Text = "Location : *"
        '
        'lblempcd
        '
        Me.lblempcd.AutoSize = True
        Me.lblempcd.Location = New System.Drawing.Point(21, 59)
        Me.lblempcd.Name = "lblempcd"
        Me.lblempcd.Size = New System.Drawing.Size(97, 13)
        Me.lblempcd.TabIndex = 24
        Me.lblempcd.Text = "Employee Code : * "
        '
        'btntrans
        '
        Me.btntrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntrans.Location = New System.Drawing.Point(360, 189)
        Me.btntrans.Name = "btntrans"
        Me.btntrans.Size = New System.Drawing.Size(57, 23)
        Me.btntrans.TabIndex = 3
        Me.btntrans.Text = ">>"
        Me.btntrans.UseVisualStyleBackColor = True
        '
        'lbltransdt
        '
        Me.lbltransdt.AutoSize = True
        Me.lbltransdt.Location = New System.Drawing.Point(27, 359)
        Me.lbltransdt.Name = "lbltransdt"
        Me.lbltransdt.Size = New System.Drawing.Size(82, 13)
        Me.lbltransdt.TabIndex = 30
        Me.lbltransdt.Text = "Transfer Date :*"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(494, 354)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(586, 354)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Cl&ear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.Location = New System.Drawing.Point(678, 354)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 13
        Me.btnclose.Text = "&Close"
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'dttime_transdate
        '
        Me.dttime_transdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttime_transdate.Location = New System.Drawing.Point(138, 355)
        Me.dttime_transdate.Name = "dttime_transdate"
        Me.dttime_transdate.Size = New System.Drawing.Size(100, 20)
        Me.dttime_transdate.TabIndex = 10
        Me.dttime_transdate.Value = New Date(2010, 3, 19, 0, 0, 0, 0)
        '
        'cmbempcode
        '
        Me.cmbempcode.AutoDropDown = False
        Me.cmbempcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbempcode.FormattingEnabled = True
        Me.cmbempcode.Location = New System.Drawing.Point(138, 55)
        Me.cmbempcode.Name = "cmbempcode"
        Me.cmbempcode.Size = New System.Drawing.Size(190, 21)
        Me.cmbempcode.TabIndex = 2
        '
        'cmbdeptname
        '
        Me.cmbdeptname.AutoDropDown = False
        Me.cmbdeptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(527, 22)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(190, 21)
        Me.cmbdeptname.TabIndex = 1
        '
        'cmblocname
        '
        Me.cmblocname.AutoDropDown = False
        Me.cmblocname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocname.FormattingEnabled = True
        Me.cmblocname.Location = New System.Drawing.Point(138, 22)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(190, 21)
        Me.cmblocname.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.AllowFormat = True
        Me.GroupBox2.Controls.Add(Me.txtsalt)
        Me.GroupBox2.Controls.Add(Me.lblsalt)
        Me.GroupBox2.Controls.Add(Me.txtjobt)
        Me.GroupBox2.Controls.Add(Me.cmbposition)
        Me.GroupBox2.Controls.Add(Me.cmbpayrolltype)
        Me.GroupBox2.Controls.Add(Me.cmbdeptnmt)
        Me.GroupBox2.Controls.Add(Me.cmblocnmt)
        Me.GroupBox2.Controls.Add(Me.lblloc1)
        Me.GroupBox2.Controls.Add(Me.lblposition1)
        Me.GroupBox2.Controls.Add(Me.lbljob1)
        Me.GroupBox2.Controls.Add(Me.lblpayroll1)
        Me.GroupBox2.Controls.Add(Me.lbldept1)
        Me.GroupBox2.Location = New System.Drawing.Point(437, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 225)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transferred To:"
        '
        'txtsalt
        '
        Me.txtsalt.CheckBounds = False
        Me.txtsalt.DateFormat = Nothing
        Me.txtsalt.DecimalPlaces = CType(0, Byte)
        Me.txtsalt.Location = New System.Drawing.Point(100, 187)
        Me.txtsalt.MaxDate = New Date(CType(0, Long))
        Me.txtsalt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsalt.MinDate = New Date(CType(0, Long))
        Me.txtsalt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsalt.Name = "txtsalt"
        Me.txtsalt.Size = New System.Drawing.Size(190, 20)
        Me.txtsalt.TabIndex = 9
        Me.txtsalt.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lblsalt
        '
        Me.lblsalt.AutoSize = True
        Me.lblsalt.Location = New System.Drawing.Point(7, 190)
        Me.lblsalt.Name = "lblsalt"
        Me.lblsalt.Size = New System.Drawing.Size(46, 13)
        Me.lblsalt.TabIndex = 61
        Me.lblsalt.Text = "Salary :*"
        '
        'txtjobt
        '
        Me.txtjobt.CheckBounds = False
        Me.txtjobt.DateFormat = Nothing
        Me.txtjobt.DecimalPlaces = CType(0, Byte)
        Me.txtjobt.Location = New System.Drawing.Point(100, 122)
        Me.txtjobt.MaxDate = New Date(CType(0, Long))
        Me.txtjobt.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjobt.MinDate = New Date(CType(0, Long))
        Me.txtjobt.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjobt.Name = "txtjobt"
        Me.txtjobt.Size = New System.Drawing.Size(190, 20)
        Me.txtjobt.TabIndex = 7
        Me.txtjobt.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'cmbposition
        '
        Me.cmbposition.AutoDropDown = False
        Me.cmbposition.FormattingEnabled = True
        Me.cmbposition.Items.AddRange(New Object() {"Administration", "Management", "Senior", "Junior"})
        Me.cmbposition.Location = New System.Drawing.Point(100, 155)
        Me.cmbposition.Name = "cmbposition"
        Me.cmbposition.Size = New System.Drawing.Size(190, 21)
        Me.cmbposition.TabIndex = 8
        '
        'cmbpayrolltype
        '
        Me.cmbpayrolltype.AutoDropDown = False
        Me.cmbpayrolltype.FormattingEnabled = True
        Me.cmbpayrolltype.Items.AddRange(New Object() {"Fixed", "Monthly"})
        Me.cmbpayrolltype.Location = New System.Drawing.Point(100, 89)
        Me.cmbpayrolltype.Name = "cmbpayrolltype"
        Me.cmbpayrolltype.Size = New System.Drawing.Size(190, 21)
        Me.cmbpayrolltype.TabIndex = 6
        '
        'cmbdeptnmt
        '
        Me.cmbdeptnmt.AutoDropDown = False
        Me.cmbdeptnmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptnmt.FormattingEnabled = True
        Me.cmbdeptnmt.Location = New System.Drawing.Point(100, 56)
        Me.cmbdeptnmt.Name = "cmbdeptnmt"
        Me.cmbdeptnmt.Size = New System.Drawing.Size(190, 21)
        Me.cmbdeptnmt.TabIndex = 5
        '
        'cmblocnmt
        '
        Me.cmblocnmt.AutoDropDown = False
        Me.cmblocnmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocnmt.FormattingEnabled = True
        Me.cmblocnmt.Location = New System.Drawing.Point(100, 23)
        Me.cmblocnmt.Name = "cmblocnmt"
        Me.cmblocnmt.Size = New System.Drawing.Size(190, 21)
        Me.cmblocnmt.TabIndex = 4
        '
        'lblloc1
        '
        Me.lblloc1.AutoSize = True
        Me.lblloc1.Location = New System.Drawing.Point(7, 26)
        Me.lblloc1.Name = "lblloc1"
        Me.lblloc1.Size = New System.Drawing.Size(58, 13)
        Me.lblloc1.TabIndex = 55
        Me.lblloc1.Text = "Location :*"
        '
        'lblposition1
        '
        Me.lblposition1.AutoSize = True
        Me.lblposition1.Location = New System.Drawing.Point(7, 158)
        Me.lblposition1.Name = "lblposition1"
        Me.lblposition1.Size = New System.Drawing.Size(54, 13)
        Me.lblposition1.TabIndex = 54
        Me.lblposition1.Text = "Position :*"
        '
        'lbljob1
        '
        Me.lbljob1.AutoSize = True
        Me.lbljob1.Location = New System.Drawing.Point(7, 125)
        Me.lbljob1.Name = "lbljob1"
        Me.lbljob1.Size = New System.Drawing.Size(34, 13)
        Me.lbljob1.TabIndex = 53
        Me.lbljob1.Text = "Job :*"
        '
        'lblpayroll1
        '
        Me.lblpayroll1.AutoSize = True
        Me.lblpayroll1.Location = New System.Drawing.Point(7, 92)
        Me.lblpayroll1.Name = "lblpayroll1"
        Me.lblpayroll1.Size = New System.Drawing.Size(75, 13)
        Me.lblpayroll1.TabIndex = 52
        Me.lblpayroll1.Text = "Payroll Type :*"
        '
        'lbldept1
        '
        Me.lbldept1.AutoSize = True
        Me.lbldept1.Location = New System.Drawing.Point(7, 59)
        Me.lbldept1.Name = "lbldept1"
        Me.lbldept1.Size = New System.Drawing.Size(72, 13)
        Me.lbldept1.TabIndex = 51
        Me.lbldept1.Text = "Department :*"
        '
        'grp_existing
        '
        Me.grp_existing.AllowFormat = True
        Me.grp_existing.Controls.Add(Me.txtsal)
        Me.grp_existing.Controls.Add(Me.lblsal)
        Me.grp_existing.Controls.Add(Me.txtposition)
        Me.grp_existing.Controls.Add(Me.txtjob)
        Me.grp_existing.Controls.Add(Me.txtpayrolltype)
        Me.grp_existing.Controls.Add(Me.txtdeptnm)
        Me.grp_existing.Controls.Add(Me.txtlocnm)
        Me.grp_existing.Controls.Add(Me.lblloc)
        Me.grp_existing.Controls.Add(Me.lblposition)
        Me.grp_existing.Controls.Add(Me.lbljob)
        Me.grp_existing.Controls.Add(Me.lblpayroll)
        Me.grp_existing.Controls.Add(Me.lbldept)
        Me.grp_existing.Location = New System.Drawing.Point(24, 107)
        Me.grp_existing.Name = "grp_existing"
        Me.grp_existing.Size = New System.Drawing.Size(317, 225)
        Me.grp_existing.TabIndex = 27
        Me.grp_existing.TabStop = False
        Me.grp_existing.Text = "Existing"
        '
        'txtsal
        '
        Me.txtsal.CheckBounds = False
        Me.txtsal.DateFormat = Nothing
        Me.txtsal.DecimalPlaces = CType(0, Byte)
        Me.txtsal.Enabled = False
        Me.txtsal.Location = New System.Drawing.Point(113, 187)
        Me.txtsal.MaxDate = New Date(CType(0, Long))
        Me.txtsal.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsal.MinDate = New Date(CType(0, Long))
        Me.txtsal.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtsal.Name = "txtsal"
        Me.txtsal.Size = New System.Drawing.Size(190, 20)
        Me.txtsal.TabIndex = 62
        Me.txtsal.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lblsal
        '
        Me.lblsal.AutoSize = True
        Me.lblsal.Location = New System.Drawing.Point(6, 190)
        Me.lblsal.Name = "lblsal"
        Me.lblsal.Size = New System.Drawing.Size(42, 13)
        Me.lblsal.TabIndex = 61
        Me.lblsal.Text = "Salary :"
        '
        'txtposition
        '
        Me.txtposition.CheckBounds = False
        Me.txtposition.DateFormat = Nothing
        Me.txtposition.DecimalPlaces = CType(0, Byte)
        Me.txtposition.Enabled = False
        Me.txtposition.Location = New System.Drawing.Point(114, 155)
        Me.txtposition.MaxDate = New Date(CType(0, Long))
        Me.txtposition.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtposition.MinDate = New Date(CType(0, Long))
        Me.txtposition.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(190, 20)
        Me.txtposition.TabIndex = 60
        Me.txtposition.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtjob
        '
        Me.txtjob.CheckBounds = False
        Me.txtjob.DateFormat = Nothing
        Me.txtjob.DecimalPlaces = CType(0, Byte)
        Me.txtjob.Enabled = False
        Me.txtjob.Location = New System.Drawing.Point(114, 122)
        Me.txtjob.MaxDate = New Date(CType(0, Long))
        Me.txtjob.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjob.MinDate = New Date(CType(0, Long))
        Me.txtjob.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtjob.Name = "txtjob"
        Me.txtjob.Size = New System.Drawing.Size(190, 20)
        Me.txtjob.TabIndex = 59
        Me.txtjob.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtpayrolltype
        '
        Me.txtpayrolltype.CheckBounds = False
        Me.txtpayrolltype.DateFormat = Nothing
        Me.txtpayrolltype.DecimalPlaces = CType(0, Byte)
        Me.txtpayrolltype.Enabled = False
        Me.txtpayrolltype.Location = New System.Drawing.Point(114, 89)
        Me.txtpayrolltype.MaxDate = New Date(CType(0, Long))
        Me.txtpayrolltype.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpayrolltype.MinDate = New Date(CType(0, Long))
        Me.txtpayrolltype.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtpayrolltype.Name = "txtpayrolltype"
        Me.txtpayrolltype.Size = New System.Drawing.Size(190, 20)
        Me.txtpayrolltype.TabIndex = 58
        Me.txtpayrolltype.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtdeptnm
        '
        Me.txtdeptnm.CheckBounds = False
        Me.txtdeptnm.DateFormat = Nothing
        Me.txtdeptnm.DecimalPlaces = CType(0, Byte)
        Me.txtdeptnm.Enabled = False
        Me.txtdeptnm.Location = New System.Drawing.Point(114, 56)
        Me.txtdeptnm.MaxDate = New Date(CType(0, Long))
        Me.txtdeptnm.MaxLength = 6
        Me.txtdeptnm.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdeptnm.MinDate = New Date(CType(0, Long))
        Me.txtdeptnm.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdeptnm.Name = "txtdeptnm"
        Me.txtdeptnm.Size = New System.Drawing.Size(190, 20)
        Me.txtdeptnm.TabIndex = 57
        Me.txtdeptnm.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'txtlocnm
        '
        Me.txtlocnm.CheckBounds = False
        Me.txtlocnm.DateFormat = Nothing
        Me.txtlocnm.DecimalPlaces = CType(0, Byte)
        Me.txtlocnm.Enabled = False
        Me.txtlocnm.Location = New System.Drawing.Point(114, 23)
        Me.txtlocnm.MaxDate = New Date(CType(0, Long))
        Me.txtlocnm.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlocnm.MinDate = New Date(CType(0, Long))
        Me.txtlocnm.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtlocnm.Name = "txtlocnm"
        Me.txtlocnm.Size = New System.Drawing.Size(190, 20)
        Me.txtlocnm.TabIndex = 56
        Me.txtlocnm.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'lblloc
        '
        Me.lblloc.AutoSize = True
        Me.lblloc.Location = New System.Drawing.Point(7, 26)
        Me.lblloc.Name = "lblloc"
        Me.lblloc.Size = New System.Drawing.Size(54, 13)
        Me.lblloc.TabIndex = 55
        Me.lblloc.Text = "Location :"
        '
        'lblposition
        '
        Me.lblposition.AutoSize = True
        Me.lblposition.Location = New System.Drawing.Point(7, 158)
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(50, 13)
        Me.lblposition.TabIndex = 54
        Me.lblposition.Text = "Position :"
        '
        'lbljob
        '
        Me.lbljob.AutoSize = True
        Me.lbljob.Location = New System.Drawing.Point(7, 125)
        Me.lbljob.Name = "lbljob"
        Me.lbljob.Size = New System.Drawing.Size(30, 13)
        Me.lbljob.TabIndex = 53
        Me.lbljob.Text = "Job :"
        '
        'lblpayroll
        '
        Me.lblpayroll.AutoSize = True
        Me.lblpayroll.Location = New System.Drawing.Point(7, 92)
        Me.lblpayroll.Name = "lblpayroll"
        Me.lblpayroll.Size = New System.Drawing.Size(71, 13)
        Me.lblpayroll.TabIndex = 52
        Me.lblpayroll.Text = "Payroll Type :"
        '
        'lbldept
        '
        Me.lbldept.AutoSize = True
        Me.lbldept.Location = New System.Drawing.Point(7, 59)
        Me.lbldept.Name = "lbldept"
        Me.lbldept.Size = New System.Drawing.Size(68, 13)
        Me.lbldept.TabIndex = 51
        Me.lbldept.Text = "Department :"
        '
        'txtempnm
        '
        Me.txtempnm.CheckBounds = False
        Me.txtempnm.DateFormat = Nothing
        Me.txtempnm.DecimalPlaces = CType(0, Byte)
        Me.txtempnm.Enabled = False
        Me.txtempnm.Location = New System.Drawing.Point(345, 55)
        Me.txtempnm.MaxDate = New Date(CType(0, Long))
        Me.txtempnm.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempnm.MinDate = New Date(CType(0, Long))
        Me.txtempnm.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempnm.Name = "txtempnm"
        Me.txtempnm.Size = New System.Drawing.Size(372, 20)
        Me.txtempnm.TabIndex = 26
        Me.txtempnm.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'frm_emp_transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 391)
        Me.Controls.Add(Me.dttime_transdate)
        Me.Controls.Add(Me.cmbempcode)
        Me.Controls.Add(Me.cmbdeptname)
        Me.Controls.Add(Me.cmblocname)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lbltransdt)
        Me.Controls.Add(Me.btntrans)
        Me.Controls.Add(Me.grp_existing)
        Me.Controls.Add(Me.txtempnm)
        Me.Controls.Add(Me.lblempcd)
        Me.Controls.Add(Me.lbldeptnm)
        Me.Controls.Add(Me.lbllocnm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_emp_transfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer of Employee"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grp_existing.ResumeLayout(False)
        Me.grp_existing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldeptnm As System.Windows.Forms.Label
    Friend WithEvents lbllocnm As System.Windows.Forms.Label
    Friend WithEvents lblempcd As System.Windows.Forms.Label
    Friend WithEvents txtempnm As DefaultControls.MaskedBox
    Friend WithEvents grp_existing As DefaultControls.GroupBox
    Friend WithEvents btntrans As System.Windows.Forms.Button
    Friend WithEvents lbltransdt As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txtjob As DefaultControls.MaskedBox
    Friend WithEvents txtpayrolltype As DefaultControls.MaskedBox
    Friend WithEvents txtdeptnm As DefaultControls.MaskedBox
    Friend WithEvents txtlocnm As DefaultControls.MaskedBox
    Friend WithEvents lblloc As System.Windows.Forms.Label
    Friend WithEvents lblposition As System.Windows.Forms.Label
    Friend WithEvents lbljob As System.Windows.Forms.Label
    Friend WithEvents lblpayroll As System.Windows.Forms.Label
    Friend WithEvents lbldept As System.Windows.Forms.Label
    Friend WithEvents txtposition As DefaultControls.MaskedBox
    Friend WithEvents GroupBox2 As DefaultControls.GroupBox
    Friend WithEvents lblloc1 As System.Windows.Forms.Label
    Friend WithEvents lblposition1 As System.Windows.Forms.Label
    Friend WithEvents lbljob1 As System.Windows.Forms.Label
    Friend WithEvents lblpayroll1 As System.Windows.Forms.Label
    Friend WithEvents lbldept1 As System.Windows.Forms.Label
    Friend WithEvents cmbpayrolltype As DefaultControls.ComboBox
    Friend WithEvents cmbdeptnmt As DefaultControls.ComboBox
    Friend WithEvents cmblocnmt As DefaultControls.ComboBox
    Friend WithEvents cmbposition As DefaultControls.ComboBox
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents cmbdeptname As DefaultControls.ComboBox
    Friend WithEvents cmbempcode As DefaultControls.ComboBox
    Friend WithEvents dttime_transdate As DefaultControls.DateTimePicker
    Friend WithEvents txtjobt As DefaultControls.MaskedBox
    Friend WithEvents txtsal As DefaultControls.MaskedBox
    Friend WithEvents lblsal As System.Windows.Forms.Label
    Friend WithEvents txtsalt As DefaultControls.MaskedBox
    Friend WithEvents lblsalt As System.Windows.Forms.Label
End Class
