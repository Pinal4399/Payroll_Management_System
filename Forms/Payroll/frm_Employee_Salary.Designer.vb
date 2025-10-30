<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Employee_Salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Employee_Salary))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grp_searchcriteria = New System.Windows.Forms.GroupBox
        Me.cmbdeptname = New DefaultControls.ComboBox
        Me.cmblocname = New DefaultControls.ComboBox
        Me.btnfind = New System.Windows.Forms.Button
        Me.lbldeptname = New System.Windows.Forms.Label
        Me.lbllocname = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.lbltotalemp = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grid_emp_salary = New DefaultControls.DataGridView
        Me.empcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.realsal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chequesal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.payablesal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grp_searchcriteria.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grid_emp_salary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_searchcriteria
        '
        Me.grp_searchcriteria.Controls.Add(Me.cmbdeptname)
        Me.grp_searchcriteria.Controls.Add(Me.cmblocname)
        Me.grp_searchcriteria.Controls.Add(Me.btnfind)
        Me.grp_searchcriteria.Controls.Add(Me.lbldeptname)
        Me.grp_searchcriteria.Controls.Add(Me.lbllocname)
        Me.grp_searchcriteria.Location = New System.Drawing.Point(12, 12)
        Me.grp_searchcriteria.Name = "grp_searchcriteria"
        Me.grp_searchcriteria.Size = New System.Drawing.Size(766, 100)
        Me.grp_searchcriteria.TabIndex = 0
        Me.grp_searchcriteria.TabStop = False
        Me.grp_searchcriteria.Text = "Search Criteria"
        '
        'cmbdeptname
        '
        Me.cmbdeptname.AutoDropDown = False
        Me.cmbdeptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(102, 52)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(231, 21)
        Me.cmbdeptname.TabIndex = 1
        '
        'cmblocname
        '
        Me.cmblocname.AutoDropDown = False
        Me.cmblocname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocname.FormattingEnabled = True
        Me.cmblocname.Location = New System.Drawing.Point(102, 24)
        Me.cmblocname.Name = "cmblocname"
        Me.cmblocname.Size = New System.Drawing.Size(231, 21)
        Me.cmblocname.TabIndex = 0
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(355, 50)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(75, 23)
        Me.btnfind.TabIndex = 2
        Me.btnfind.Text = "&Find"
        Me.btnfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'lbldeptname
        '
        Me.lbldeptname.AutoSize = True
        Me.lbldeptname.Location = New System.Drawing.Point(15, 55)
        Me.lbldeptname.Name = "lbldeptname"
        Me.lbldeptname.Size = New System.Drawing.Size(72, 13)
        Me.lbldeptname.TabIndex = 1
        Me.lbldeptname.Text = "Department :*"
        '
        'lbllocname
        '
        Me.lbllocname.AutoSize = True
        Me.lbllocname.Location = New System.Drawing.Point(15, 27)
        Me.lbllocname.Name = "lbllocname"
        Me.lbllocname.Size = New System.Drawing.Size(58, 13)
        Me.lbllocname.TabIndex = 0
        Me.lbllocname.Text = "Location :*"
        '
        'btnsave
        '
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(510, 393)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(694, 393)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "&Close"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(602, 393)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "Cl&ear"
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'lbltotalemp
        '
        Me.lbltotalemp.AutoSize = True
        Me.lbltotalemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalemp.ForeColor = System.Drawing.Color.Red
        Me.lbltotalemp.Location = New System.Drawing.Point(631, 365)
        Me.lbltotalemp.Name = "lbltotalemp"
        Me.lbltotalemp.Size = New System.Drawing.Size(108, 13)
        Me.lbltotalemp.TabIndex = 28
        Me.lbltotalemp.Text = "Total Employees :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grid_emp_salary)
        Me.Panel1.Location = New System.Drawing.Point(3, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 241)
        Me.Panel1.TabIndex = 29
        '
        'grid_emp_salary
        '
        Me.grid_emp_salary.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_emp_salary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_emp_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_emp_salary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empcode, Me.empname, Me.realsal, Me.chequesal, Me.payablesal})
        Me.grid_emp_salary.Location = New System.Drawing.Point(18, 12)
        Me.grid_emp_salary.Name = "grid_emp_salary"
        Me.grid_emp_salary.Size = New System.Drawing.Size(766, 216)
        Me.grid_emp_salary.TabIndex = 7
        '
        'empcode
        '
        Me.empcode.DataPropertyName = "employee_code"
        Me.empcode.HeaderText = "Employee Code *"
        Me.empcode.Name = "empcode"
        Me.empcode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.empcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'empname
        '
        Me.empname.DataPropertyName = "short_name"
        Me.empname.HeaderText = "Employee Name "
        Me.empname.Name = "empname"
        Me.empname.Width = 150
        '
        'realsal
        '
        Me.realsal.DataPropertyName = "salary"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.realsal.DefaultCellStyle = DataGridViewCellStyle2
        Me.realsal.HeaderText = "Real Salary *"
        Me.realsal.Name = "realsal"
        Me.realsal.Width = 120
        '
        'chequesal
        '
        Me.chequesal.DataPropertyName = "cheque_salary"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.chequesal.DefaultCellStyle = DataGridViewCellStyle3
        Me.chequesal.HeaderText = "Cheque Salary"
        Me.chequesal.Name = "chequesal"
        Me.chequesal.Width = 120
        '
        'payablesal
        '
        Me.payablesal.DataPropertyName = "payable_salary"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.payablesal.DefaultCellStyle = DataGridViewCellStyle4
        Me.payablesal.HeaderText = "Payable Salary"
        Me.payablesal.Name = "payablesal"
        '
        'frm_Employee_Salary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 431)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbltotalemp)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.grp_searchcriteria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Employee_Salary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Salary"
        Me.grp_searchcriteria.ResumeLayout(False)
        Me.grp_searchcriteria.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grid_emp_salary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_searchcriteria As System.Windows.Forms.GroupBox
    Friend WithEvents lbldeptname As System.Windows.Forms.Label
    Friend WithEvents lbllocname As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents cmbdeptname As DefaultControls.ComboBox
    Friend WithEvents cmblocname As DefaultControls.ComboBox
    Friend WithEvents lbltotalemp As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grid_emp_salary As DefaultControls.DataGridView
    Friend WithEvents empcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents realsal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chequesal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents payablesal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
