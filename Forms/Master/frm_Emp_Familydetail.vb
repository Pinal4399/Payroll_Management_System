Public Class frm_emp_familydetail

#Region "variables"
    Private dtbempfamilydetail As DataTable
    Dim dtrowempfamily As DataRow
    Dim ObjclsGen As New cls_General
    Dim objclsempdetail As New cls_emp_button
    Dim serialNum As Integer = 1
    Dim m_strLocation As String
    Dim m_strEmpCode As String
    Dim m_strShortName As String
    Dim strqry As String
#End Region

#Region " Constructors "

    Public Sub New(ByVal strLocation As String, ByVal strEmpCode As String, ByVal strShorName As String)
        m_strLocation = strLocation
        m_strEmpCode = strEmpCode
        m_strShortName = strShorName
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbempfamilydetail = New DataTable

        ObjclsGen.showMdi(Me)
    End Sub

#End Region

#Region "events"

    Private Sub frm_emp_familydetail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbempfamilydetail.GetChanges IsNot Nothing Then
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

    Private Sub frm_emp_familydetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtlocname.Text = m_strLocation
            txtemployeecode.Text = m_strEmpCode
            txtemployeename.Text = m_strShortName
            populateEmpFamilydata()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_emp_familydetail.Enabled Then
                If validateEmpFamilydata() Then
                    If objclsempdetail.Saveempfamilydetail(masterform.con, dtbempfamilydetail, txtemployeecode.Text) Then
                        pnl_emp_familydetail.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_emp_familydetail.Enabled = True
                        populateEmpFamilydata()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub grid_emp_family_detail_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_emp_family_detail.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_emp_family_detail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_emp_family_detail.KeyDown
        grid_emp_family_detail.EndEdit()
        Try
            If grid_emp_family_detail.CurrentCell IsNot Nothing Then
                Dim numrowindex As Integer
                numrowindex = grid_emp_family_detail.CurrentCell.RowIndex
                If numrowindex = grid_emp_family_detail.Rows.Count - 1 Then
                    If e.KeyCode = Keys.Down Then
                        Dim rowindex As Integer = grid_emp_family_detail.CurrentCell.RowIndex
                        addnew()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
  
#End Region

#Region " Functions/Procedures "

    Public Function populateEmpFamilydata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbempfamilydetail = New DataTable
            masterform.con.Close()
            strqry = "SELECT serial_no,member_name,relation,birth_date,education,occupation FROM tbl_emp_familydetail where employee_code='" & txtemployeecode.Text & "' ORDER BY serial_no"
            ObjclsGen.Getdata(masterform.con, strqry, dtbempfamilydetail)
            If dtbempfamilydetail.Rows.Count <= 0 Then
                MsgBox("Record not found", MsgBoxStyle.Information, Me.Text)
                Dim rw As DataRow = dtbempfamilydetail.NewRow
                rw("serial_no") = 1
                rw("member_name") = String.Empty
                rw("relation") = String.Empty
                rw("birth_date") = String.Empty
                rw("education") = String.Empty
                rw("occupation") = String.Empty
                dtbempfamilydetail.Rows.Add(rw)
            End If
            masterform.con.Open()
            grid_emp_family_detail.DataSource = dtbempfamilydetail
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        masterform.con.Close()
        Return dbReturn
    End Function

    Public Function validateEmpFamilydata() As Boolean
        Dim dbReturn As Boolean = True
        grid_emp_family_detail.EndEdit()
        Try
            For Each dtrowempfamily In dtbempfamilydetail.Rows
                If dtrowempfamily.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowempfamily("member_name")) Or (dtrowempfamily("member_name").Equals(String.Empty)) Then
                        MsgBox("Must enter member Name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowempfamily("relation")) Or (dtrowempfamily("relation").Equals(String.Empty)) Then
                        MsgBox("Must enter relation", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowempfamily("birth_date")) Or (dtrowempfamily("birth_date").Equals(String.Empty)) Then
                        dtrowempfamily("birth_date") = ""
                    ElseIf Not IsDate(dtrowempfamily("birth_date")) Then
                        MsgBox("Enter Valid Date(DD/MM/YYYY)", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowempfamily("education")) Or (dtrowempfamily("education").Equals(String.Empty)) Then
                        dtrowempfamily("education") = ""
                    End If
                    If IsDBNull(dtrowempfamily("occupation")) Or (dtrowempfamily("occupation").Equals(String.Empty)) Then
                        dtrowempfamily("occupation") = ""
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Sub addnew()
        Dim drw As DataRow
        Try
            For Each drw In dtbempfamilydetail.Rows
                If drw.RowState <> DataRowState.Deleted Then
                    serialnum = drw("serial_no") + 1
                End If
            Next
            Dim rw As DataRow = dtbempfamilydetail.NewRow
            rw("serial_no") = serialnum
            rw("member_name") = String.Empty
            rw("relation") = String.Empty
            rw("birth_date") = String.Empty
            rw("education") = String.Empty
            rw("occupation") = String.Empty
            dtbempfamilydetail.Rows.Add(rw)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
#End Region

End Class