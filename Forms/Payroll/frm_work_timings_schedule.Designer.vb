<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_work_timings_schedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_work_timings_schedule))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grp_searchcriteria = New System.Windows.Forms.GroupBox
        Me.cmbprocessperiod = New DefaultControls.ComboBox
        Me.cmblocname = New DefaultControls.ComboBox
        Me.MaskedBox1 = New DefaultControls.MaskedBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblperiod = New System.Windows.Forms.Label
        Me.btnfind = New System.Windows.Forms.Button
        Me.lbllocname = New System.Windows.Forms.Label
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grid_worktime_schedule = New DefaultControls.DataGridView
        Me.worktimeid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.holiday = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.weekoff = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.starttime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.endtime = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.workhrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.notes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grp_searchcriteria.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_worktime_schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_searchcriteria
        '
        Me.grp_searchcriteria.Controls.Add(Me.cmbprocessperiod)
        Me.grp_searchcriteria.Controls.Add(Me.cmblocname)
        Me.grp_searchcriteria.Controls.Add(Me.MaskedBox1)
        Me.grp_searchcriteria.Controls.Add(Me.Label1)
        Me.grp_searchcriteria.Controls.Add(Me.lblperiod)
        Me.grp_searchcriteria.Controls.Add(Me.btnfind)
        Me.grp_searchcriteria.Controls.Add(Me.lbllocname)
        Me.grp_searchcriteria.Location = New System.Drawing.Point(7, 9)
        Me.grp_searchcriteria.Name = "grp_searchcriteria"
        Me.grp_searchcriteria.Size = New System.Drawing.Size(902, 100)
        Me.grp_searchcriteria.TabIndex = 2
        Me.grp_searchcriteria.TabStop = False
        Me.grp_searchcriteria.Text = "Search Criteria"
        '
        'cmbprocessperiod
        '
        Me.cmbprocessperiod.AutoDropDown = False
        Me.cmbprocessperiod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprocessperiod.FormattingEnabled = True
        Me.cmbprocessperiod.Location = New System.Drawing.Point(445, 24)
        Me.cmbprocessperiod.Name = "cmbprocessperiod"
        Me.cmbprocessperiod.Size = New System.Drawing.Size(162, 21)
        Me.cmbprocessperiod.TabIndex = 1
        '
        'cmblocname
        '
        Me.cmblocname.AutoDropDown = False
        Me.cmblocname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocname.FormattingEnabled = True
        Me.cmblocname.Location = New System.Drawing.Point(97, 53)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(224, 21)
        Me.cmblocname.TabIndex = 0
        '
        'MaskedBox1
        '
        Me.MaskedBox1.CheckBounds = False
        Me.MaskedBox1.DateFormat = Nothing
        Me.MaskedBox1.DecimalPlaces = CType(0, Byte)
        Me.MaskedBox1.Enabled = False
        Me.MaskedBox1.Location = New System.Drawing.Point(97, 24)
        Me.MaskedBox1.MaxDate = New Date(CType(0, Long))
        Me.MaskedBox1.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MaskedBox1.MinDate = New Date(CType(0, Long))
        Me.MaskedBox1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MaskedBox1.Name = "MaskedBox1"
        Me.MaskedBox1.Size = New System.Drawing.Size(224, 20)
        Me.MaskedBox1.TabIndex = 7
        Me.MaskedBox1.Text = "Laxmi Diamond Pvt. Ltd."
        Me.MaskedBox1.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Company :*"
        '
        'lblperiod
        '
        Me.lblperiod.AutoSize = True
        Me.lblperiod.Location = New System.Drawing.Point(341, 27)
        Me.lblperiod.Name = "lblperiod"
        Me.lblperiod.Size = New System.Drawing.Size(88, 13)
        Me.lblperiod.TabIndex = 5
        Me.lblperiod.Text = "Process Period :*"
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(644, 22)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(75, 23)
        Me.btnfind.TabIndex = 2
        Me.btnfind.Text = "&Find"
        Me.btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'lbllocname
        '
        Me.lbllocname.AutoSize = True
        Me.lbllocname.Location = New System.Drawing.Point(15, 56)
        Me.lbllocname.Name = "lbllocname"
        Me.lbllocname.Size = New System.Drawing.Size(58, 13)
        Me.lbllocname.TabIndex = 0
        Me.lbllocname.Text = "Location :*"
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(662, 459)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Cl&ear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(830, 459)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "&Close"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(578, 459)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.Location = New System.Drawing.Point(746, 459)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 5
        Me.btnreport.Text = "&Report"
        Me.btnreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_worktime_schedule)
        Me.Panel1.Location = New System.Drawing.Point(7, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 338)
        Me.Panel1.TabIndex = 11
        '
        'grid_worktime_schedule
        '
        Me.grid_worktime_schedule.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_worktime_schedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_worktime_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_worktime_schedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.worktimeid, Me.clmdate, Me.holiday, Me.weekoff, Me.starttime, Me.endtime, Me.workhrs, Me.notes})
        Me.grid_worktime_schedule.Location = New System.Drawing.Point(8, 6)
        Me.grid_worktime_schedule.Name = "grid_worktime_schedule"
        Me.grid_worktime_schedule.Size = New System.Drawing.Size(902, 327)
        Me.grid_worktime_schedule.TabIndex = 4
        '
        'worktimeid
        '
        Me.worktimeid.DataPropertyName = "worktiming_id"
        DataGridViewCellStyle2.Format = "N0"
        Me.worktimeid.DefaultCellStyle = DataGridViewCellStyle2
        Me.worktimeid.HeaderText = "Work Timings Id"
        Me.worktimeid.Name = "worktimeid"
        Me.worktimeid.ReadOnly = True
        Me.worktimeid.Visible = False
        '
        'clmdate
        '
        Me.clmdate.DataPropertyName = "work_date"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmdate.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmdate.HeaderText = "Date"
        Me.clmdate.Name = "clmdate"
        Me.clmdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmdate.Width = 150
        '
        'holiday
        '
        Me.holiday.DataPropertyName = "is_holiday"
        Me.holiday.FalseValue = "0"
        Me.holiday.HeaderText = "Holiday *"
        Me.holiday.Name = "holiday"
        Me.holiday.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.holiday.TrueValue = "1"
        Me.holiday.Width = 80
        '
        'weekoff
        '
        Me.weekoff.DataPropertyName = "is_weekoff"
        Me.weekoff.FalseValue = "0"
        Me.weekoff.HeaderText = "Week Off *"
        Me.weekoff.Name = "weekoff"
        Me.weekoff.TrueValue = "1"
        Me.weekoff.Width = 80
        '
        'starttime
        '
        Me.starttime.DataPropertyName = "start_time"
        Me.starttime.HeaderText = "Start Time"
        Me.starttime.Name = "starttime"
        Me.starttime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.starttime.Width = 150
        '
        'endtime
        '
        Me.endtime.DataPropertyName = "end_time"
        Me.endtime.HeaderText = "End Time"
        Me.endtime.Name = "endtime"
        Me.endtime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.endtime.Width = 150
        '
        'workhrs
        '
        Me.workhrs.DataPropertyName = "work_hrs"
        Me.workhrs.HeaderText = "Work Hours *"
        Me.workhrs.Name = "workhrs"
        Me.workhrs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.workhrs.Width = 80
        '
        'notes
        '
        Me.notes.DataPropertyName = "notes"
        Me.notes.HeaderText = "Notes"
        Me.notes.Name = "notes"
        Me.notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.notes.Width = 200
        '
        'frm_work_timings_schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 494)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.grp_searchcriteria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_work_timings_schedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Timings Schedule"
        Me.grp_searchcriteria.ResumeLayout(False)
        Me.grp_searchcriteria.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_worktime_schedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_searchcriteria As System.Windows.Forms.GroupBox
    Friend WithEvents lblperiod As System.Windows.Forms.Label
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbllocname As System.Windows.Forms.Label
    Friend WithEvents MaskedBox1 As DefaultControls.MaskedBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cmbprocessperiod As DefaultControls.ComboBox
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_worktime_schedule As DefaultControls.DataGridView
    Friend WithEvents worktimeid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents holiday As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents weekoff As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents starttime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents endtime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents workhrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notes As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
