<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportviewer
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
        Me.reportview = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'reportview
        '
        Me.reportview.ActiveViewIndex = -1
        Me.reportview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportview.DisplayGroupTree = False
        Me.reportview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportview.Location = New System.Drawing.Point(0, 0)
        Me.reportview.Name = "reportview"
        Me.reportview.SelectionFormula = ""
        Me.reportview.Size = New System.Drawing.Size(794, 443)
        Me.reportview.TabIndex = 0
        Me.reportview.ViewTimeSelectionFormula = ""
        '
        'Reportviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 443)
        Me.Controls.Add(Me.reportview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Reportviewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportviewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportview As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
