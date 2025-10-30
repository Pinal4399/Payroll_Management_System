Public Class frm_Emp_Qualification

#Region "variables"
    Private dtbempqualification As DataTable
    Dim dtrowempqualification As DataRow
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
        dtbempqualification = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_Emp_Qualification_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbempqualification.GetChanges IsNot Nothing Then
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

    Private Sub frm_Emp_Qualification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtlocname.Text = m_strLocation
            txtemployeecode.Text = m_strEmpCode
            txtemployeename.Text = m_strShortName
            populateEmpQualificationdata()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_emp_qualification.Enabled Then
                If validateEmpQualificationdata() Then
                    If objclsempdetail.Saveempqualification(masterform.con, dtbempqualification, txtemployeecode.Text) Then
                        pnl_emp_qualification.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_emp_qualification.Enabled = True
                        populateEmpQualificationdata()
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

    Private Sub grid_emp_qualification_detail_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_emp_qualification_detail.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_emp_qualification_detail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_emp_qualification_detail.KeyDown
        Try
            If grid_emp_qualification_detail.CurrentCell IsNot Nothing Then
                Dim numrowindex As Integer
                numrowindex = grid_emp_qualification_detail.CurrentCell.RowIndex
                If numrowindex = grid_emp_qualification_detail.Rows.Count - 1 Then
                    If e.KeyCode = Keys.Down Then
                        Dim rowindex As Integer = grid_emp_qualification_detail.CurrentCell.RowIndex
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

    Public Function populateEmpQualificationdata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbempqualification = New DataTable
            masterform.con.Close()
            strqry = "SELECT serial_no,qualification,university_college_institute,year_of_passing,grade_percent FROM tbl_emp_qualification where employee_code='" & txtemployeecode.Text & "' ORDER BY serial_no"
            ObjclsGen.Getdata(masterform.con, strqry, dtbempqualification)
            If dtbempqualification.Rows.Count <= 0 Then
                MsgBox("Record not found", MsgBoxStyle.Information, Me.Text)
                Dim rw As DataRow = dtbempqualification.NewRow
                rw("serial_no") = serialNum
                rw("qualification") = String.Empty
                rw("university_college_institute") = String.Empty
                rw("year_of_passing") = String.Empty
                rw("grade_percent") = String.Empty
                dtbempqualification.Rows.Add(rw)
            End If
            masterform.con.Open()
            grid_emp_qualification_detail.DataSource = dtbempqualification
            dbReturn = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        masterform.con.Close()
        Return dbReturn
    End Function

    Public Function validateEmpQualificationdata() As Boolean
        Dim dbReturn As Boolean = True
        grid_emp_qualification_detail.EndEdit()
        Try
            For Each dtrowempqualification In dtbempqualification.Rows
                If dtrowempqualification.RowState <> DataRowState.Deleted Then

                    If IsDBNull(dtrowempqualification("qualification")) Or (dtrowempqualification("qualification").Equals(String.Empty)) Then
                        MsgBox("Must enter qualification", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowempqualification("university_college_institute")) Or (dtrowempqualification("university_college_institute").Equals(String.Empty)) Then
                        MsgBox("Must enter university/college/institute", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowempqualification("year_of_passing")) Or (dtrowempqualification("year_of_passing").Equals(String.Empty)) Then
                        MsgBox("Must enter year of passing", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowempqualification("grade_percent")) Or (dtrowempqualification("grade_percent").Equals(String.Empty)) Then
                        dtrowempqualification("grade_percent") = ""
                    ElseIf Val(dtrowempqualification("grade_percent")) > 100 Then
                        MsgBox("Percent must be less than 100", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
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
            For Each drw In dtbempqualification.Rows
                If drw.RowState <> DataRowState.Deleted Then
                    serialnum = drw("serial_no") + 1
                End If
            Next
            Dim rw As DataRow = dtbempqualification.NewRow
            rw("serial_no") = serialnum
            rw("qualification") = String.Empty
            rw("university_college_institute") = String.Empty
            rw("year_of_passing") = String.Empty
            rw("grade_percent") = String.Empty
            dtbempqualification.Rows.Add(rw)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
#End Region

End Class