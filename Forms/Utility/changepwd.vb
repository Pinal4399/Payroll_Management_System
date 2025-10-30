Imports System.Data.SqlClient

Public Class changepwd
    Dim numcount As Integer
    Dim pass As String = ""
    Dim objclsgen As New cls_General

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ObjClsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub changepwd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frm_login.OpenConnection()
        txtuserid.Text = frm_login.txtusername.Text
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnchangepwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangepwd.Click
        If txtconnewpwd.Text = String.Empty And txtoldpwd.Text = String.Empty And txtnewpwd.Text = String.Empty Then
            MsgBox("Can not be blank", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        Else
            If Len(txtoldpwd.Text) < 6 Then
                MsgBox("Password Must be greater than 6 characters", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If

            masterform.con.Close()
            Dim cmdchange As New sqlCommand("select * from tbl_login where username ='" & txtuserid.Text & "' ")
            cmdchange.Connection = masterform.con
            masterform.con.Open()
            masterform.dr = cmdchange.ExecuteReader
            If masterform.dr.HasRows Then
                masterform.dr.Read()
                pass = ""
                For numcount = 1 To Len(masterform.dr.GetString(2))
                    Dim p As Integer = Asc(Mid(masterform.dr.GetString(2), numcount, 1)) - 3
                    pass = pass & Chr(p)
                Next
                If Not txtoldpwd.Text = pass Then
                    MsgBox("Invalid Password", MsgBoxStyle.Critical, "Invalid")
                    txtconnewpwd.Clear()
                    txtoldpwd.Clear()
                    txtnewpwd.Clear()
                    Exit Sub
                End If
                If Not (txtnewpwd.Text = txtconnewpwd.Text) Then
                    MsgBox("New and Confirm Password must be same", MsgBoxStyle.Information, Me.Text)
                    txtconnewpwd.Clear()
                    txtoldpwd.Clear()
                    txtnewpwd.Clear()
                    Exit Sub
                End If
            Else
                MsgBox("Permission Denied", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If
            masterform.dr.Close()
            pass = ""
            For numcount = 1 To Len(txtconnewpwd.Text)
                Dim p As Integer = Asc(Mid(txtconnewpwd.Text, numcount, 1)) + 3
                pass = pass & Chr(p)
            Next
            cmdchange = New sqlCommand
            cmdchange.Connection = masterform.con
            cmdchange.CommandText = "update tbl_login set pwd='" & pass & "' where username='" & txtuserid.Text & "'"
            cmdchange.ExecuteNonQuery()
            MsgBox("Password changed successfully...", MsgBoxStyle.Information, Me.Text)
            txtuserid.Clear()
            txtoldpwd.Clear()
            txtnewpwd.Clear()
            txtconnewpwd.Clear()
        End If
        masterform.con.Close()
    End Sub

#End Region
End Class