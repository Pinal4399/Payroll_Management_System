Public Class frm_suggestion_approval


#Region "variables"
    Private dtbsuggapp, dtbLocation, dtbDepartment, dtbempnm As DataTable
    Dim dtrowsuggapp As DataRow
    Dim strempcode, strQry As String
    Dim ObjclsGen As New cls_General
    Dim objclshr As New cls_hr
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        '  Add any initialization after the InitializeComponent() call.
        dtbsuggapp = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_suggestion_approval_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbsuggapp.GetChanges IsNot Nothing Then
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

    Private Sub frm_suggestion_approval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)
        grid_suggestion_approval.ReadOnly = True
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Try
            strempcode = "select * from tbl_Employee WHERE location_id  like '" & cmblocname.SelectedValue & "' and Department_id like '" & cmbdeptname.SelectedValue & "' AND emp_inactive=0"
            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
                With grid_suggestion_approval
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).ValueMember = "employee_code"
                    CType(.Columns("submittedby"), DataGridViewComboBoxColumn).DisplayMember = "short_name"
                End With
            End If
            strempcode = "select * from tbl_department WHERE dept_isactive=1"
            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempnm) Then
                With grid_suggestion_approval
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DataSource = Nothing
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DataSource = dtbempnm
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).ValueMember = "hod_empid"
                    CType(.Columns("approvedby"), DataGridViewComboBoxColumn).DisplayMember = "hod_empname"
                End With
            End If

            cmblocname.Enabled = False
            grid_suggestion_approval.ReadOnly = False
            grid_suggestion_approval.Columns("clmsuggestion").ReadOnly = True
            grid_suggestion_approval.Columns("submittedby").ReadOnly = True
            grid_suggestion_approval.Columns("submissiondate").ReadOnly = True

            If Not FetchSuggestionData() Then
                MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
                dtbsuggapp.Clear()
                grid_suggestion_approval.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            cmblocname.Enabled = True
            If validateSuggestionAppdata() Then
                If objclshr.saveSuggestionData(masterform.con, dtbsuggapp, cmblocname.SelectedValue, cmbdeptname.SelectedValue, Me) Then
                    MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                    FetchSuggestionData()
                    grid_suggestion_approval.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.Enabled = True
        dtbsuggapp.Clear()
        grid_suggestion_approval.DataSource = Nothing
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub grid_suggestion_approval_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_suggestion_approval.CellContentClick
        Try
            If grid_suggestion_approval.Columns("btnsuggestion").Index = e.ColumnIndex Then
                If ObjclsGen.ShowForm("frm_notes", Me) = False Then
                    Dim obj As New frm_notes(grid_suggestion_approval.Item("clmsuggestion", e.RowIndex).Value.ToString, True)
                    obj.ShowDialog(Me)
                    grid_suggestion_approval.Item("clmsuggestion", e.RowIndex).Value = obj.strNotes
                End If
            End If

            If grid_suggestion_approval.Columns("btnremarks").Index = e.ColumnIndex Then
                If ObjclsGen.ShowForm("frm_notes", Me) = False Then
                    Dim obj As New frm_notes(grid_suggestion_approval.Item("clmremarks", e.RowIndex).Value.ToString)
                    obj.ShowDialog(Me)
                    grid_suggestion_approval.Item("clmremarks", e.RowIndex).Value = obj.strNotes
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_suggestion_approval_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_suggestion_approval.DataError
        e.Cancel = True
    End Sub
#End Region

#Region " Functions/Procedures "
    Private Function FetchSuggestionData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            Dim strqry As String
            dtbsuggapp = New DataTable
            masterform.con.Close()
            strqry = " SELECT suggestion_id, description, submitted_empcode,submission_date,approved_empcode,remarks " & vbCrLf & _
                       "FROM tbl_suggestion where location_id  like '" & cmblocname.SelectedValue & "' and Department_id like '" & cmbdeptname.SelectedValue & "'"

            If Not ObjclsGen.Getdata(masterform.con, strqry, dtbsuggapp) Then
                dbReturn = False
            Else
                masterform.con.Open()
                grid_suggestion_approval.AutoGenerateColumns = False
                grid_suggestion_approval.DataSource = Nothing
                grid_suggestion_approval.DataSource = dtbsuggapp
                dbReturn = True
            End If
            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Public Function validateSuggestionAppdata() As Boolean
        Dim dbReturn As Boolean = True
        Try
            grid_suggestion_approval.EndEdit()
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            For Each dtrowsuggapp In dtbsuggapp.Rows
                If dtrowsuggapp.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowsuggapp("approved_empcode")) Or (dtrowsuggapp("approved_empcode").Equals(String.Empty)) Then
                        dtrowsuggapp("approved_empcode") = ""
                    End If
                    If IsDBNull(dtrowsuggapp("remarks")) Or (dtrowsuggapp("remarks").Equals(String.Empty)) Then
                        dtrowsuggapp("remarks") = ""
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function
#End Region

End Class