Public Class frm_Emp_History

#Region "variables"
    Private dtbemphistory As DataTable
    Dim dtrowemphistory As DataRow
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
        dtbemphistory = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub

#End Region

#Region " Events "

    Private Sub frm_Emp_History_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dtbemphistory.GetChanges IsNot Nothing Then
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
    Private Sub frm_Emp_History_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtlocname.Text = m_strLocation
            txtemployeecode.Text = m_strEmpCode
            txtemployeename.Text = m_strShortName
            populateEmpHistorydata()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_emp_history.Enabled Then
                If validateEmpHistorydata() Then
                    If objclsempdetail.Saveemphistory(masterform.con, dtbemphistory, txtemployeecode.Text) Then
                        pnl_emp_history.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_emp_history.Enabled = True
                        populateEmpHistorydata()
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

    Private Sub grid_emp_history_detail_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_emp_history_detail.DataError
        e.Cancel = True
    End Sub

    Private Sub grid_emp_history_detail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_emp_history_detail.KeyDown
        grid_emp_history_detail.EndEdit()
        Try
            If grid_emp_history_detail.CurrentCell IsNot Nothing Then
                Dim numrowindex As Integer
                numrowindex = grid_emp_history_detail.CurrentCell.RowIndex
                If numrowindex = grid_emp_history_detail.Rows.Count - 1 Then
                    If e.KeyCode = Keys.Down Then
                        Dim rowindex As Integer = grid_emp_history_detail.CurrentCell.RowIndex
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

    Public Function populateEmpHistorydata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbemphistory = New DataTable
            masterform.con.Close()
            strqry = "SELECT serial_no,employer,designation,from_date,to_date,salary FROM tbl_emp_history where employee_code='" & txtemployeecode.Text & "' ORDER BY serial_no"
            ObjclsGen.Getdata(masterform.con, strqry, dtbemphistory)
            If dtbemphistory.Rows.Count <= 0 Then
                MsgBox("Record not found", MsgBoxStyle.Information, Me.Text)
                Dim rw As DataRow = dtbemphistory.NewRow
                rw("serial_no") = 1
                rw("employer") = String.Empty
                rw("designation") = String.Empty
                'rw("from_date") = String.Empty
                'rw("to_date") = String.Empty
                rw("salary") = 0
                dtbemphistory.Rows.Add(rw)
            End If

            masterform.con.Open()
            grid_emp_history_detail.DataSource = dtbemphistory
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

        masterform.con.Close()
        Return dbReturn
    End Function

    Public Function validateEmpHistorydata() As Boolean
        Dim dbReturn As Boolean = True
        grid_emp_history_detail.EndEdit()
        Try
            For Each dtrowemphistory In dtbemphistory.Rows
                If dtrowemphistory.RowState <> DataRowState.Deleted Then

                    If IsDBNull(dtrowemphistory("employer")) Or (dtrowemphistory("employer").Equals(String.Empty)) Then
                        MsgBox("Must enter employer Name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowemphistory("from_date")) Or (dtrowemphistory("from_date").Equals(String.Empty)) Then
                        MsgBox("Must enter from date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowemphistory("to_date")) Or (dtrowemphistory("to_date").Equals(String.Empty)) Then
                        MsgBox("Must enter To date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If dtrowemphistory("to_date") < dtrowemphistory("from_date") Then
                        MsgBox("To Date must be greater than From Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If

                    If IsDBNull(dtrowemphistory("designation")) Or (dtrowemphistory("designation").Equals(String.Empty)) Then
                        dtrowemphistory("designation") = ""
                    End If
                    If IsDBNull(dtrowemphistory("salary")) Then ' Or (dtrowemphistory("salary").Equals(String.Empty)) Then
                        dtrowemphistory("salary") = 0
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
            For Each drw In dtbemphistory.Rows
                If drw.RowState <> DataRowState.Deleted Then
                    serialNum = drw("serial_no") + 1
                End If
            Next
            Dim rw As DataRow = dtbemphistory.NewRow
            rw("serial_no") = serialNum
            rw("employer") = String.Empty
            rw("designation") = String.Empty
            rw("salary") = 0
            dtbemphistory.Rows.Add(rw)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

#End Region

End Class