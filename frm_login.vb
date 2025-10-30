Imports System.Data.SqlClient
Public Class frm_login

#Region " Variable Declaration "

    Dim m_cnnOleDb As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\HRS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim m_numCount As Int16
    Dim m_blnFlag As Boolean
    Dim m_strSQL As String
    Dim obj As New cls_General
    Dim adp As SqlDataAdapter
    Dim com As New SqlCommand
#End Region

#Region " Properties "
    Public ReadOnly Property LoginSuccessful() As Boolean
        Get
            Return m_blnFlag
        End Get
    End Property
#End Region

#Region " Events "

    Private Sub frm_login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        m_cnnOleDb.Open()
        m_blnFlag = False
        m_strSQL = String.Empty
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Dim dbReturn As Boolean = False
        Try
            Me.TopMost = False
            If ValidateEntry() Then
                Dim dtbUser As New DataTable
                m_strSQL = "SELECT * FROM tbl_login WHERE Upper(username) = '" & txtusername.Text.ToUpper & "'"
                With com
                    .Connection = m_cnnOleDb
                    .CommandText = m_strSQL
                    .CommandType = CommandType.Text
                End With
                adp = New sqlDataAdapter(com)
                If adp.Fill(dtbUser) Then
                    dbReturn = True
                End If
                If dtbUser.Rows.Count = 0 Then
                    MsgBox("Invalid User Name or Password.", MsgBoxStyle.Information, Me.Text)
                    txtusername.Focus()
                    Exit Try
                ElseIf dtbUser.Rows.Count = 1 Then
                    Dim i As Integer
                    Dim pass As String = ""
                    For i = 1 To Len(dtbUser.Rows(0)("pwd"))
                        Dim p As Integer = Asc(Mid(dtbUser.Rows(0)("pwd"), i, 1)) - 3
                        pass = pass & Chr(p)
                    Next
                    If pass <> txtpassword.Text Then

                        MsgBox("Invalid User Name or Password.", MsgBoxStyle.Information, Me.Text)
                        txtpassword.Focus()
                        Exit Try
                    End If
                    m_blnFlag = True
                    Dim obj As New masterform
                    obj.Show()
                    Me.Hide()
                    'Application.Run()
                End If
            End If
            m_cnnOleDb.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        m_numCount = m_numCount + 1
        If m_numCount >= 3 Then
            Me.Close()
        End If
       
    End Sub

    Private Sub btnclose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub frm_login_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Not OpenConnection() Then
            btnok.Enabled = False
        End If
    End Sub
#End Region


#Region " Functions / Procedures "

    Private Function ValidateEntry() As Boolean
        Dim blnReturn As Boolean = True
        Try
            If txtusername.Text.Trim = String.Empty Then
                MsgBox("Username cannot be blank.", MsgBoxStyle.Information, Me.Text)
                txtusername.Focus()
                blnReturn = False
            ElseIf txtpassword.Text.Trim = String.Empty Then
                MsgBox("Password cannot be blank.", MsgBoxStyle.Information, Me.Text)
                txtpassword.Focus()
                blnReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            blnReturn = False
        End Try
        Return blnReturn
    End Function

    Public Function OpenConnection() As Boolean
        Try
            If m_cnnOleDb.State = ConnectionState.Open Then
                m_cnnOleDb.Close()
            End If
            m_cnnOleDb.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & Application.StartupPath & "\HRS.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            m_cnnOleDb.Open()
        Catch ex As Exception
            MsgBox("Database connection error.", MsgBoxStyle.Critical, Me.Text)
            Return False
        End Try
        Return True
    End Function
#End Region
End Class