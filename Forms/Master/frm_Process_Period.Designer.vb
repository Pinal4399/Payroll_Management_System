<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Process_Period
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Process_Period))
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
        Me.lblprocessperiod = New System.Windows.Forms.ToolStripLabel
        Me.txtprocessperiodfind = New System.Windows.Forms.ToolStripTextBox
        Me.btnfind = New System.Windows.Forms.ToolStripButton
        Me.pnl_process_period = New System.Windows.Forms.Panel
        Me.chkfinalized = New DefaultControls.CheckBox
        Me.txtnonworking_days = New DefaultControls.MaskedBox(Me.components)
        Me.txtnoof_weekly_offs = New DefaultControls.MaskedBox(Me.components)
        Me.txtmonth_days = New DefaultControls.MaskedBox(Me.components)
        Me.DateTimePicker_enddate = New DefaultControls.DateTimePicker
        Me.DateTimePicker_startdate = New DefaultControls.DateTimePicker
        Me.txtperiod = New DefaultControls.MaskedBox(Me.components)
        Me.lblnonworkingdays = New System.Windows.Forms.Label
        Me.lblnoofweeklyoffs = New System.Windows.Forms.Label
        Me.lblmonthdays = New System.Windows.Forms.Label
        Me.lblenddate = New System.Windows.Forms.Label
        Me.lblstartdate = New System.Windows.Forms.Label
        Me.lblperiod = New System.Windows.Forms.Label
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.pnl_process_period.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.btnadd
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.btndelete
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnfirst, Me.btnprevious, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.btnnext, Me.btnlast, Me.BindingNavigatorSeparator5, Me.btnadd, Me.btndelete, Me.btnsave, Me.ToolStripSeparator1, Me.lblprocessperiod, Me.txtprocessperiodfind, Me.btnfind})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnfirst
        Me.BindingNavigator1.MoveLastItem = Me.btnlast
        Me.BindingNavigator1.MoveNextItem = Me.btnnext
        Me.BindingNavigator1.MovePreviousItem = Me.btnprevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(616, 25)
        Me.BindingNavigator1.TabIndex = 7
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
        'lblprocessperiod
        '
        Me.lblprocessperiod.Name = "lblprocessperiod"
        Me.lblprocessperiod.Size = New System.Drawing.Size(81, 22)
        Me.lblprocessperiod.Text = "&Process Period:"
        '
        'txtprocessperiodfind
        '
        Me.txtprocessperiodfind.Name = "txtprocessperiodfind"
        Me.txtprocessperiodfind.Size = New System.Drawing.Size(100, 25)
        Me.txtprocessperiodfind.Text = "%"
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(47, 20)
        Me.btnfind.Text = "F&ind"
        Me.btnfind.ToolTipText = "Search"
        '
        'pnl_process_period
        '
        Me.pnl_process_period.Controls.Add(Me.chkfinalized)
        Me.pnl_process_period.Controls.Add(Me.txtnonworking_days)
        Me.pnl_process_period.Controls.Add(Me.txtnoof_weekly_offs)
        Me.pnl_process_period.Controls.Add(Me.txtmonth_days)
        Me.pnl_process_period.Controls.Add(Me.DateTimePicker_enddate)
        Me.pnl_process_period.Controls.Add(Me.DateTimePicker_startdate)
        Me.pnl_process_period.Controls.Add(Me.txtperiod)
        Me.pnl_process_period.Controls.Add(Me.lblnonworkingdays)
        Me.pnl_process_period.Controls.Add(Me.lblnoofweeklyoffs)
        Me.pnl_process_period.Controls.Add(Me.lblmonthdays)
        Me.pnl_process_period.Controls.Add(Me.lblenddate)
        Me.pnl_process_period.Controls.Add(Me.lblstartdate)
        Me.pnl_process_period.Controls.Add(Me.lblperiod)
        Me.pnl_process_period.Location = New System.Drawing.Point(12, 38)
        Me.pnl_process_period.Name = "pnl_process_period"
        Me.pnl_process_period.Size = New System.Drawing.Size(586, 254)
        Me.pnl_process_period.TabIndex = 8
        '
        'chkfinalized
        '
        Me.chkfinalized.AutoSize = True
        Me.chkfinalized.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkfinalized.Location = New System.Drawing.Point(17, 203)
        Me.chkfinalized.Name = "chkfinalized"
        Me.chkfinalized.Size = New System.Drawing.Size(157, 17)
        Me.chkfinalized.TabIndex = 6
        Me.chkfinalized.Text = "Finalized :                            "
        Me.chkfinalized.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkfinalized.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkfinalized.UseVisualStyleBackColor = True
        '
        'txtnonworking_days
        '
        Me.txtnonworking_days.CheckBounds = False
        Me.txtnonworking_days.DateFormat = Nothing
        Me.txtnonworking_days.DecimalPlaces = CType(0, Byte)
        Me.txtnonworking_days.Location = New System.Drawing.Point(160, 175)
        Me.txtnonworking_days.MaxDate = New Date(CType(0, Long))
        Me.txtnonworking_days.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnonworking_days.MinDate = New Date(CType(0, Long))
        Me.txtnonworking_days.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnonworking_days.Name = "txtnonworking_days"
        Me.txtnonworking_days.Size = New System.Drawing.Size(191, 20)
        Me.txtnonworking_days.TabIndex = 5
        Me.txtnonworking_days.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtnoof_weekly_offs
        '
        Me.txtnoof_weekly_offs.CheckBounds = False
        Me.txtnoof_weekly_offs.DateFormat = Nothing
        Me.txtnoof_weekly_offs.DecimalPlaces = CType(0, Byte)
        Me.txtnoof_weekly_offs.Location = New System.Drawing.Point(160, 147)
        Me.txtnoof_weekly_offs.MaxDate = New Date(CType(0, Long))
        Me.txtnoof_weekly_offs.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnoof_weekly_offs.MinDate = New Date(CType(0, Long))
        Me.txtnoof_weekly_offs.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtnoof_weekly_offs.Name = "txtnoof_weekly_offs"
        Me.txtnoof_weekly_offs.Size = New System.Drawing.Size(191, 20)
        Me.txtnoof_weekly_offs.TabIndex = 4
        Me.txtnoof_weekly_offs.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'txtmonth_days
        '
        Me.txtmonth_days.CheckBounds = False
        Me.txtmonth_days.DateFormat = Nothing
        Me.txtmonth_days.DecimalPlaces = CType(0, Byte)
        Me.txtmonth_days.Location = New System.Drawing.Point(160, 118)
        Me.txtmonth_days.MaxDate = New Date(CType(0, Long))
        Me.txtmonth_days.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmonth_days.MinDate = New Date(CType(0, Long))
        Me.txtmonth_days.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtmonth_days.Name = "txtmonth_days"
        Me.txtmonth_days.ReadOnly = True
        Me.txtmonth_days.Size = New System.Drawing.Size(191, 20)
        Me.txtmonth_days.TabIndex = 3
        Me.txtmonth_days.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'DateTimePicker_enddate
        '
        Me.DateTimePicker_enddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_enddate.Location = New System.Drawing.Point(160, 87)
        Me.DateTimePicker_enddate.Name = "DateTimePicker_enddate"
        Me.DateTimePicker_enddate.Size = New System.Drawing.Size(191, 20)
        Me.DateTimePicker_enddate.TabIndex = 2
        Me.DateTimePicker_enddate.Value = New Date(2010, 4, 14, 0, 0, 0, 0)
        '
        'DateTimePicker_startdate
        '
        Me.DateTimePicker_startdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_startdate.Location = New System.Drawing.Point(160, 56)
        Me.DateTimePicker_startdate.Name = "DateTimePicker_startdate"
        Me.DateTimePicker_startdate.Size = New System.Drawing.Size(191, 20)
        Me.DateTimePicker_startdate.TabIndex = 1
        Me.DateTimePicker_startdate.Value = New Date(2010, 4, 14, 0, 0, 0, 0)
        '
        'txtperiod
        '
        Me.txtperiod.CheckBounds = False
        Me.txtperiod.DateFormat = Nothing
        Me.txtperiod.DecimalPlaces = CType(0, Byte)
        Me.txtperiod.Location = New System.Drawing.Point(160, 25)
        Me.txtperiod.MaxDate = New Date(CType(0, Long))
        Me.txtperiod.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtperiod.MinDate = New Date(CType(0, Long))
        Me.txtperiod.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtperiod.Name = "txtperiod"
        Me.txtperiod.ReadOnly = True
        Me.txtperiod.Size = New System.Drawing.Size(191, 20)
        Me.txtperiod.TabIndex = 0
        Me.txtperiod.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_Numbers
        '
        'lblnonworkingdays
        '
        Me.lblnonworkingdays.AutoSize = True
        Me.lblnonworkingdays.Location = New System.Drawing.Point(19, 178)
        Me.lblnonworkingdays.Name = "lblnonworkingdays"
        Me.lblnonworkingdays.Size = New System.Drawing.Size(103, 13)
        Me.lblnonworkingdays.TabIndex = 10
        Me.lblnonworkingdays.Text = "Non Working Days :"
        '
        'lblnoofweeklyoffs
        '
        Me.lblnoofweeklyoffs.AutoSize = True
        Me.lblnoofweeklyoffs.Location = New System.Drawing.Point(20, 150)
        Me.lblnoofweeklyoffs.Name = "lblnoofweeklyoffs"
        Me.lblnoofweeklyoffs.Size = New System.Drawing.Size(114, 13)
        Me.lblnoofweeklyoffs.TabIndex = 8
        Me.lblnoofweeklyoffs.Text = "No Of Weekly OFF's *:"
        '
        'lblmonthdays
        '
        Me.lblmonthdays.AutoSize = True
        Me.lblmonthdays.Location = New System.Drawing.Point(19, 121)
        Me.lblmonthdays.Name = "lblmonthdays"
        Me.lblmonthdays.Size = New System.Drawing.Size(74, 13)
        Me.lblmonthdays.TabIndex = 6
        Me.lblmonthdays.Text = "Month Days *:"
        '
        'lblenddate
        '
        Me.lblenddate.AutoSize = True
        Me.lblenddate.Location = New System.Drawing.Point(19, 91)
        Me.lblenddate.Name = "lblenddate"
        Me.lblenddate.Size = New System.Drawing.Size(62, 13)
        Me.lblenddate.TabIndex = 4
        Me.lblenddate.Text = "End Date *:"
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.Location = New System.Drawing.Point(19, 60)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.Size = New System.Drawing.Size(65, 13)
        Me.lblstartdate.TabIndex = 2
        Me.lblstartdate.Text = "Start Date *:"
        '
        'lblperiod
        '
        Me.lblperiod.AutoSize = True
        Me.lblperiod.Location = New System.Drawing.Point(19, 28)
        Me.lblperiod.Name = "lblperiod"
        Me.lblperiod.Size = New System.Drawing.Size(47, 13)
        Me.lblperiod.TabIndex = 0
        Me.lblperiod.Text = "Period *:"
        '
        'frm_Process_Period
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 313)
        Me.Controls.Add(Me.pnl_process_period)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Process_Period"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Period"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.pnl_process_period.ResumeLayout(False)
        Me.pnl_process_period.PerformLayout()
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
    Friend WithEvents lblprocessperiod As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtprocessperiodfind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnfind As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnl_process_period As System.Windows.Forms.Panel
    Friend WithEvents lblperiod As System.Windows.Forms.Label
    Friend WithEvents lblnonworkingdays As System.Windows.Forms.Label
    Friend WithEvents lblnoofweeklyoffs As System.Windows.Forms.Label
    Friend WithEvents lblmonthdays As System.Windows.Forms.Label
    Friend WithEvents lblenddate As System.Windows.Forms.Label
    Friend WithEvents lblstartdate As System.Windows.Forms.Label
    Friend WithEvents txtperiod As DefaultControls.MaskedBox
    Friend WithEvents DateTimePicker_enddate As DefaultControls.DateTimePicker
    Friend WithEvents DateTimePicker_startdate As DefaultControls.DateTimePicker
    Friend WithEvents txtnonworking_days As DefaultControls.MaskedBox
    Friend WithEvents txtnoof_weekly_offs As DefaultControls.MaskedBox
    Friend WithEvents txtmonth_days As DefaultControls.MaskedBox
    Friend WithEvents chkfinalized As DefaultControls.CheckBox
End Class
