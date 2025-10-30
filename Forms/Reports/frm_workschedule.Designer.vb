<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_workschedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_workschedule))
        Me.pnl_workschedule = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.cmbperiod = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmblocation = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnl_workschedule.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_workschedule
        '
        Me.pnl_workschedule.Controls.Add(Me.btnclose)
        Me.pnl_workschedule.Controls.Add(Me.btnreport)
        Me.pnl_workschedule.Controls.Add(Me.cmbperiod)
        Me.pnl_workschedule.Controls.Add(Me.Label2)
        Me.pnl_workschedule.Controls.Add(Me.cmblocation)
        Me.pnl_workschedule.Controls.Add(Me.Label1)
        Me.pnl_workschedule.Location = New System.Drawing.Point(12, 12)
        Me.pnl_workschedule.Name = "pnl_workschedule"
        Me.pnl_workschedule.Size = New System.Drawing.Size(268, 124)
        Me.pnl_workschedule.TabIndex = 0
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.Location = New System.Drawing.Point(180, 88)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.Location = New System.Drawing.Point(95, 88)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 2
        Me.btnreport.Text = "Report"
        Me.btnreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'cmbperiod
        '
        Me.cmbperiod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbperiod.FormattingEnabled = True
        Me.cmbperiod.Location = New System.Drawing.Point(95, 46)
        Me.cmbperiod.Name = "cmbperiod"
        Me.cmbperiod.Size = New System.Drawing.Size(121, 21)
        Me.cmbperiod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Period :*"
        '
        'cmblocation
        '
        Me.cmblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocation.FormattingEnabled = True
        Me.cmblocation.Location = New System.Drawing.Point(95, 13)
        Me.cmblocation.Name = "cmblocation"
        Me.cmblocation.Size = New System.Drawing.Size(121, 21)
        Me.cmblocation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Location :*"
        '
        'frm_workschedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 145)
        Me.Controls.Add(Me.pnl_workschedule)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_workschedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Schedule Report"
        Me.pnl_workschedule.ResumeLayout(False)
        Me.pnl_workschedule.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_workschedule As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents cmbperiod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmblocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
