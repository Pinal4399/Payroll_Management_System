Public Class frm_notes
    Public strNotes As String
    Dim objclsGen As New cls_General
    Public Sub New(ByVal p_strNotes As String)
        InitializeComponent()
        txtrichnotes.Text = p_strNotes
        ObjclsGen.showMdi(Me)
    End Sub
    Public Sub New(ByVal p_strNotes As String, ByVal isreadonly As Boolean)
        InitializeComponent()
        txtrichnotes.Text = p_strNotes
        txtrichnotes.ReadOnly = isreadonly
        btnok.Enabled = Not isreadonly
        ObjclsGen.showMdi(Me)
    End Sub
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        strNotes = Me.txtrichnotes.Text
        Me.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        strNotes = Me.txtrichnotes.Text
        Me.Close()
    End Sub

    Private Sub frm_notes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        strNotes = Me.txtrichnotes.Text
    End Sub
End Class