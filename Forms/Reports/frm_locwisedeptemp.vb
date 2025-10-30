Public Class frm_locwisedeptemp

#Region " Variables "
    Dim rptview As Reportviewer
    Dim rpt As New rptlocwisedept
    Dim ObjclsGen As New cls_General
    Dim dtbLocation, dtbdept As New DataTable
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

    Private Sub frm_locwisedept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadDefault()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub chkselected_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkselected.CheckedChanged
        Try
            Dim draw As DataGridViewRow
            If chkselected.Checked = True Then
                For Each draw In grid_locwisedept.Rows
                    draw.Cells("clmselected").Value = 1
                Next
            Else
                For Each draw In grid_locwisedept.Rows
                    draw.Cells("clmselected").Value = 0
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        Dim strQry As String
        Dim m_tbl As New DataTable
        Dim strfind As String = String.Empty
        Dim dtbrow As DataRow
        For Each dtbrow In dtbLocation.Rows
            If Val(dtbrow("id").ToString) = 1 Then
                If strfind = String.Empty Then strfind = "0"
                strfind = strfind & "," & Val(dtbrow("location_id").ToString)
            End If
        Next
        If strfind = String.Empty Then
            strfind = 0
        End If
        strQry = "select l.location_id,l.location_name,d.* from tbl_department d,tbl_location l where d.location_id=l.location_id and d.location_id in(" & strfind & ") " '"
        If Not ObjclsGen.Getdata(masterform.con, strQry, m_tbl) Then
            MsgBox("First Select Location name", MsgBoxStyle.Information, Me.Text)
        Else
            Dim rptnew As New Reportviewer("department", m_tbl)
            rptnew.Show()
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub grid_locwisedept_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_locwisedept.DataError
        e.Cancel = True
    End Sub
#End Region

#Region " Functions/Procedures "

    Private Function LoadDefault() As Boolean
        Dim blnReturn As Boolean = True
        Dim strQry As String
        Try
            chkselected.Checked = False
            dtbLocation = New DataTable
            strQry = "SELECT location_id,location_name from tbl_location order by location_name"

            With grid_locwisedept
                If ObjclsGen.Getdata(masterform.con, strQry, dtbLocation) Then
                    masterform.con.Close()
                    masterform.con.Open()
                    dtbLocation.Columns.Add("id")
                    .AutoGenerateColumns = False
                    .DataSource = Nothing
                    .DataSource = dtbLocation
                    .ReadOnly = False
                    btnreport.Enabled = True
                    If dtbLocation.Rows.Count > 0 Then
                        .ReadOnly = False
                        .Enabled = True
                    Else
                        .ReadOnly = True
                        .Enabled = False
                    End If
                Else
                    .DataSource = Nothing
                    btnreport.Enabled = False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            blnReturn = False
        End Try
        Return blnReturn
    End Function

#End Region
    
End Class