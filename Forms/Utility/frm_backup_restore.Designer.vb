<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_backup_restore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_backup_restore))
        Me.btnbackup = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btnrestore = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'btnbackup
        '
        Me.btnbackup.Image = CType(resources.GetObject("btnbackup.Image"), System.Drawing.Image)
        Me.btnbackup.Location = New System.Drawing.Point(79, 12)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(75, 23)
        Me.btnbackup.TabIndex = 0
        Me.btnbackup.Text = "Backup"
        Me.btnbackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'btnrestore
        '
        Me.btnrestore.Image = CType(resources.GetObject("btnrestore.Image"), System.Drawing.Image)
        Me.btnrestore.Location = New System.Drawing.Point(79, 62)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(75, 23)
        Me.btnrestore.TabIndex = 1
        Me.btnrestore.Text = "Restore"
        Me.btnrestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrestore.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(79, 112)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_backup_restore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 152)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnbackup)
        Me.MaximizeBox = False
        Me.Name = "frm_backup_restore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup/Restore"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnrestore As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
