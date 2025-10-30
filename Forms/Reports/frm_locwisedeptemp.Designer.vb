<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_locwisedeptemp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_locwisedeptemp))
        Me.pnl_leave = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.chkselected = New DefaultControls.CheckBox
        Me.grid_locwisedept = New DefaultControls.DataGridView
        Me.clmselected = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.locid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.locname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnl_leave.SuspendLayout()
        CType(Me.grid_locwisedept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_leave
        '
        Me.pnl_leave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_leave.Controls.Add(Me.btnclose)
        Me.pnl_leave.Controls.Add(Me.btnreport)
        Me.pnl_leave.Controls.Add(Me.chkselected)
        Me.pnl_leave.Controls.Add(Me.grid_locwisedept)
        Me.pnl_leave.Location = New System.Drawing.Point(11, 12)
        Me.pnl_leave.Name = "pnl_leave"
        Me.pnl_leave.Size = New System.Drawing.Size(357, 311)
        Me.pnl_leave.TabIndex = 3
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(270, 272)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreport.Location = New System.Drawing.Point(179, 273)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 2
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'chkselected
        '
        Me.chkselected.AutoSize = True
        Me.chkselected.Location = New System.Drawing.Point(12, 276)
        Me.chkselected.Name = "chkselected"
        Me.chkselected.Size = New System.Drawing.Size(82, 17)
        Me.chkselected.TabIndex = 1
        Me.chkselected.Text = "Selected All"
        Me.chkselected.UseVisualStyleBackColor = True
        '
        'grid_locwisedept
        '
        Me.grid_locwisedept.AllowUserToAddRows = False
        Me.grid_locwisedept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_locwisedept.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmselected, Me.locid, Me.locname})
        Me.grid_locwisedept.Location = New System.Drawing.Point(9, 13)
        Me.grid_locwisedept.Name = "grid_locwisedept"
        Me.grid_locwisedept.Size = New System.Drawing.Size(336, 242)
        Me.grid_locwisedept.TabIndex = 0
        '
        'clmselected
        '
        Me.clmselected.DataPropertyName = "id"
        Me.clmselected.FalseValue = "0"
        Me.clmselected.HeaderText = "Selected"
        Me.clmselected.Name = "clmselected"
        Me.clmselected.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmselected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmselected.TrueValue = "1"
        Me.clmselected.Width = 70
        '
        'locid
        '
        Me.locid.DataPropertyName = "location_id"
        Me.locid.HeaderText = "Location Id"
        Me.locid.Name = "locid"
        Me.locid.ReadOnly = True
        Me.locid.Visible = False
        '
        'locname
        '
        Me.locname.DataPropertyName = "location_name"
        Me.locname.HeaderText = "Location"
        Me.locname.Name = "locname"
        Me.locname.ReadOnly = True
        Me.locname.Width = 200
        '
        'frm_locwisedeptemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 335)
        Me.Controls.Add(Me.pnl_leave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_locwisedeptemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location Wise Department Report"
        Me.pnl_leave.ResumeLayout(False)
        Me.pnl_leave.PerformLayout()
        CType(Me.grid_locwisedept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_leave As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents chkselected As DefaultControls.CheckBox
    Friend WithEvents grid_locwisedept As DefaultControls.DataGridView
    Friend WithEvents clmselected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents locid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents locname As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
