<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_annexure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_annexure))
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreport = New System.Windows.Forms.Button
        Me.txtempname = New DefaultControls.MaskedBox(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbempcode = New DefaultControls.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbdeptnm = New DefaultControls.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmblocnm = New DefaultControls.ComboBox
        Me.lbllocation = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Location = New System.Drawing.Point(208, 166)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Image = CType(resources.GetObject("btnreport.Image"), System.Drawing.Image)
        Me.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreport.Location = New System.Drawing.Point(117, 167)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 4
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'txtempname
        '
        Me.txtempname.CheckBounds = False
        Me.txtempname.DateFormat = Nothing
        Me.txtempname.DecimalPlaces = CType(0, Byte)
        Me.txtempname.Location = New System.Drawing.Point(111, 116)
        Me.txtempname.MaxDate = New Date(CType(0, Long))
        Me.txtempname.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempname.MinDate = New Date(CType(0, Long))
        Me.txtempname.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtempname.Name = "txtempname"
        Me.txtempname.ReadOnly = True
        Me.txtempname.Size = New System.Drawing.Size(177, 20)
        Me.txtempname.TabIndex = 3
        Me.txtempname.TextBoxStyle = DefaultControls.MaskedBox.TextBoxFunction.Allow_AlphaNumerics
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Employee Name :"
        '
        'cmbempcode
        '
        Me.cmbempcode.AutoDropDown = False
        Me.cmbempcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbempcode.FormattingEnabled = True
        Me.cmbempcode.Location = New System.Drawing.Point(111, 79)
        Me.cmbempcode.Name = "cmbempcode"
        Me.cmbempcode.Size = New System.Drawing.Size(177, 21)
        Me.cmbempcode.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Employee Code : *"
        '
        'cmbdeptnm
        '
        Me.cmbdeptnm.AutoDropDown = False
        Me.cmbdeptnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptnm.FormattingEnabled = True
        Me.cmbdeptnm.Location = New System.Drawing.Point(112, 44)
        Me.cmbdeptnm.Name = "cmbdeptnm"
        Me.cmbdeptnm.Size = New System.Drawing.Size(177, 21)
        Me.cmbdeptnm.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Department : *"
        '
        'cmblocnm
        '
        Me.cmblocnm.AutoDropDown = False
        Me.cmblocnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocnm.FormattingEnabled = True
        Me.cmblocnm.Location = New System.Drawing.Point(113, 10)
        Me.cmblocnm.Name = "cmblocnm"
        Me.cmblocnm.Size = New System.Drawing.Size(177, 21)
        Me.cmblocnm.TabIndex = 0
        '
        'lbllocation
        '
        Me.lbllocation.AutoSize = True
        Me.lbllocation.Location = New System.Drawing.Point(5, 15)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(58, 13)
        Me.lbllocation.TabIndex = 21
        Me.lbllocation.Text = "Location :*"
        '
        'frm_annexure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 205)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.txtempname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbempcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbdeptnm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmblocnm)
        Me.Controls.Add(Me.lbllocation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_annexure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Annexure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents txtempname As DefaultControls.MaskedBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbempcode As DefaultControls.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbdeptnm As DefaultControls.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmblocnm As DefaultControls.ComboBox
    Friend WithEvents lbllocation As System.Windows.Forms.Label
End Class
