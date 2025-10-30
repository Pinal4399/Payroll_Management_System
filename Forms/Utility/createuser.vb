Imports System.Data.SqlClient
Public Class createuser

    Dim objclsgen As New cls_General
    Dim cmdcreateuser As New sqlCommand

#Region " Constructors "
    Public Sub New()
        InitializeComponent()
        objclsgen.showMdi(Me)
    End Sub
#End Region
#Region " Events "

    Private Sub createuser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frm_login.OpenConnection()
        txtuserid.Text = String.Empty
        txtpwd.Text = String.Empty
        txtconpwd.Text = String.Empty
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtuserid.Text = String.Empty
        txtpwd.Text = String.Empty
        txtconpwd.Text = String.Empty
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If Len(txtpwd.Text) < 6 Then
            MsgBox("Password Must be greater than 6 characters", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If
        If Not txtuserid.Text = "" Then
            If Not txtpwd.Text = "" And Not txtconpwd.Text = "" Then
                If Not (txtpwd.Text = txtconpwd.Text) Then
                    MsgBox("Password and Confirm Password must be same", MsgBoxStyle.Information, Me.Text)
                    txtpwd.Clear()
                    txtconpwd.Clear()
                    Exit Sub
                End If
            End If
            Dim cmduser As New sqlCommand("select * from tbl_login where username ='" & txtuserid.Text & "' ")
            masterform.con.Close()
            cmduser.Connection = masterform.con
            masterform.con.Open()
            masterform.dr = cmduser.ExecuteReader
            If masterform.dr.HasRows Then
                masterform.dr.Read()
                MsgBox(txtuserid.Text & " Already Exist", MsgBoxStyle.Information, "Already")
                txtuserid.Text = String.Empty
                txtpwd.Text = String.Empty
                'masterform.dr.Close()
                Exit Sub
            End If
        End If
        masterform.dr.Close()
        Dim i As Integer
        Dim pass As String = ""
        For i = 1 To Len(txtpwd.Text)
            Dim p As Integer = Asc(Mid(txtpwd.Text, i, 1)) + 3
            pass = pass & Chr(p)
        Next
        cmdcreateuser.CommandText = "insert into tbl_login(username,pwd) values ('" & txtuserid.Text & "','" & pass & "')"
        cmdcreateuser.Connection = masterform.con

        cmdcreateuser.ExecuteNonQuery()
        MsgBox("User created successfully.....", MsgBoxStyle.Information, Me.Text)
        txtuserid.Text = String.Empty
        txtpwd.Text = String.Empty
        txtconpwd.Text = String.Empty
        txtuserid.Focus()
    End Sub

#End Region
End Class



