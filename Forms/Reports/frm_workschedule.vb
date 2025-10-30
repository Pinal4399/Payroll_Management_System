Public Class frm_workschedule
#Region "Variable Declaration"
    Dim dtbLocation, dtbperiod As DataTable
    Dim ObjClsGen As New cls_General
    Dim strQry As String
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ObjClsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click

        Dim m_tbl As New DataTable

        strQry = "SELECT w.*,l.location_name from tbl_worktimings w,tbl_location l where w.location_id=l.location_id and w.location_id like '" & cmblocation.SelectedValue & "' and period='" & cmbperiod.Text.ToString & "'"
        If Not ObjClsGen.Getdata(masterform.con, strQry, m_tbl) Then
            MsgBox("Not Available", MsgBoxStyle.Information, Me.Text)
        Else
            Dim rptnew As New Reportviewer("Workschedule", m_tbl)
            rptnew.Show()
        End If
    End Sub

   
    Private Sub frm_workschedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            LoadDefault()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Function LoadDefault() As Boolean
        Dim blnReturn As Boolean = True
        Try
            dtbLocation = New DataTable
            ObjClsGen.cmblocationname(dtbLocation, cmblocation)
            cmblocation.SelectedIndex = -1

            dtbperiod = New DataTable
            strQry = "SELECT period FROM tbl_process_period"
            ObjClsGen.Getdata(masterform.con, strQry, dtbperiod)
            With cmbperiod
                .DataSource = dtbperiod
                .DisplayMember = "period"
                .ValueMember = "period"
            End With
            cmbperiod.Text = ""
            cmbperiod.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            blnReturn = False
        End Try
        Return blnReturn
    End Function

#End Region
  
End Class