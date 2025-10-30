Public Class frm_backup_restore
    Dim objclsgen As New cls_General

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ObjClsGen.showMdi(Me)
    End Sub
#End Region
    Dim str As String = Application.StartupPath & "\HRS.mdf"

    Private Sub btnbackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbackup.Click
        SaveFileDialog1.ShowDialog()
        If Not SaveFileDialog1.FileName = String.Empty Then
            FileCopy(str, SaveFileDialog1.FileName & ".mdf")
        End If
    End Sub

    Private Sub btnrestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestore.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.FileName = String.Empty
        If Not SaveFileDialog1.FileName = String.Empty Then
            FileCopy(OpenFileDialog1.FileName, str)
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class