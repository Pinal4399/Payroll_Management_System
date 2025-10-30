Public Class frm_Emp_Earning

#Region "variables"
    Private dtbempearning As DataTable
    Dim dtrowempearning As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclsempdetail As New cls_emp_button
    Dim m_strLocation As String
    Dim m_strEmpCode As String
    Dim m_strShortName As String
    Dim m_numSalary, salary As Double
    Dim strqry As String
    Dim cmbearningcode As ComboBox
#End Region

#Region " Constructors "
    Public Sub New(ByVal strLocation As String, ByVal strEmpCode As String, ByVal strShorName As String, ByVal numSalary As Double)
        m_strLocation = strLocation
        m_strEmpCode = strEmpCode
        m_strShortName = strShorName
        m_numSalary = numSalary
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbempearning = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

    Private Sub frm_Emp_Earning_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbempearning.GetChanges IsNot Nothing Then
                Dim dlg As Windows.Forms.DialogResult = cls_General.SaveMsg("Do You Want To Save Records ?", Me.Text)
                If dlg = Windows.Forms.DialogResult.Yes Then
                    btnsave_Click(sender, e)
                ElseIf dlg = Windows.Forms.DialogResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub frm_Emp_Earning_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtlocname.Text = m_strLocation
            txtemployeecode.Text = m_strEmpCode
            txtemployeename.Text = m_strShortName
            populateEmpEarningdata()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_emp_earning.Enabled Then
                If validateEmpEarningdata() Then
                    If objclsempdetail.Saveempearningdetail(masterform.con, dtbempearning, txtemployeecode.Text) Then
                        pnl_emp_earning.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_emp_earning.Enabled = True
                        populateEmpEarningdata()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub grid_emp_earning_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_emp_earning.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_emp_earning_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grid_emp_earning.EditingControlShowing
        Try
            If grid_emp_earning.Columns(grid_emp_earning.CurrentCell.ColumnIndex).DataPropertyName.ToUpper = "EARNING_CODE" Then
                cmbearningcode = e.Control
                AddHandler cmbearningcode.SelectedIndexChanged, AddressOf cmbearningcode_SelectedIndexChanged
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbearningcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If grid_emp_earning.CurrentRow IsNot Nothing Then
                If cmbearningcode.SelectedIndex >= 0 Then
                    If cmbearningcode.Text = "BCW" Then
                        grid_emp_earning.Item("desc", grid_emp_earning.CurrentRow.Index).Value = "Basic-Cash Salary"
                    ElseIf cmbearningcode.Text = "BCQ" Then
                        grid_emp_earning.Item("desc", grid_emp_earning.CurrentRow.Index).Value = "Basic-Cheque Salary"
                    End If
                    grid_emp_earning.Item("desc", grid_emp_earning.CurrentRow.Index).ReadOnly = True               
                Else
                    grid_emp_earning.Item("desc", grid_emp_earning.CurrentRow.Index).Value = String.Empty
                    grid_emp_earning.Item("desc", grid_emp_earning.CurrentRow.Index).ReadOnly = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Try
        End Try
    End Sub
    Private Sub grid_emp_earning_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_emp_earning.KeyDown
        Try
            grid_emp_earning.EndEdit()
            If e.KeyCode = Keys.Down Then
                Dim rowindex As Integer = grid_emp_earning.CurrentCell.RowIndex
                If rowindex = grid_emp_earning.Rows.Count - 1 Then
                    ObjclsGen.AddnewRow(dtbempearning)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

#Region " Functions/Procedures "

    Public Function populateEmpEarningdata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbempearning = New DataTable
            masterform.con.Close()
            strqry = "SELECT serial_no,earning_code,description,cheque_salary FROM tbl_emp_earning where employee_code='" & txtemployeecode.Text & "' ORDER BY serial_no"
            ObjclsGen.Getdata(masterform.con, strqry, dtbempearning)
            If dtbempearning.Rows.Count <= 0 Then
                MsgBox("Record not found", MsgBoxStyle.Information, Me.Text)
                ObjclsGen.AddnewRow(dtbempearning)
            End If
            masterform.con.Open()
            grid_emp_earning.DataSource = dtbempearning
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        masterform.con.Close()
        Return dbReturn
    End Function

    Public Function validateEmpEarningdata() As Boolean
        Dim dbReturn As Boolean = True
        grid_emp_earning.EndEdit()
        salary = 0
        Try
            For Each dtrowempearning In dtbempearning.Rows
                If dtrowempearning.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowempearning("earning_code")) Or (dtrowempearning("earning_code").Equals(String.Empty)) Then
                        MsgBox("Must enter Earning Code", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowempearning("cheque_salary")) Or (dtrowempearning("cheque_salary").Equals(String.Empty)) Then
                        MsgBox("Must enter Rate", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    Else
                        If dtrowempearning("cheque_salary") < 0 Then
                            MsgBox("Rate Must not be Negative", MsgBoxStyle.Information, Me.Text)
                            dbReturn = False
                        End If
                        salary = salary + dtrowempearning("cheque_salary")
                    End If
                    If IsDBNull(dtrowempearning("description")) Or (dtrowempearning("description").Equals(String.Empty)) Then
                        dtrowempearning("description") = ""
                    End If
                End If
            Next
            If salary <> m_numSalary Then
                MsgBox("Total of salary must be =" & m_numSalary, MsgBoxStyle.Information, Me.Text)
                dbReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    
#End Region
End Class