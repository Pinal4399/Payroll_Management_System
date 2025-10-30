Public Class frm_training
#Region "variables"
    Private dtbTEnroll, dtbempCode, dtbTrainer, dtbVenue As DataTable
    Dim dtrowTEnroll As DataRow
    Dim strQry As String
    Dim ObjclsGen As New cls_General
    Dim d As Integer
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbTEnroll = New DataTable
        dtbempCode = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        Dim strQry As String
        Dim m_tbl As New DataTable

        strQry = "SELECT en.*,t.trainer_name,v.name,e.short_name,l.location_id,l.location_name,d.department_id,d.department_name " & _
                     "FROM tbl_training_enrollment en,tbl_employee e,tbl_location l,tbl_department d,tbl_trainer t,tbl_training_venue v WHERE " & _
                     "en.trainer_id like '" & cmbtrainer.SelectedValue & "' and en.venue_id like '" & cmbvenue.SelectedValue & "' and " & _
                     "en.start_date like '" & cmbstartdate.Text.ToString & "' AND en.end_date like '" & cmbenddate.Text.ToString & "' AND " & _
                     "en.location_id=l.location_id and en.department_id=d.department_id AND " & _
                     "en.employee_code=e.employee_code and en.trainer_id=t.trainer_id and en.venue_id=v.venue_id"
        If Not ObjclsGen.Getdata(masterform.con, strQry, m_tbl) Then
            MsgBox("No training is given", MsgBoxStyle.Information, Me.Text)
        Else
            Dim rptnew As New Reportviewer("training", m_tbl)
            rptnew.Show()
        End If
    End Sub

    Private Sub frm_training_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtbVenue = New DataTable
            strQry = "SELECT venue_id,name FROM tbl_training_venue"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbVenue) Then
                With cmbvenue
                    .DataSource = dtbVenue
                    .DisplayMember = "name"
                    .ValueMember = "venue_id"
                End With
            End If
            cmbvenue.Text = ""
            cmbvenue.SelectedIndex = -1

            dtbTrainer = New DataTable
            strQry = "SELECT trainer_id,trainer_name FROM tbl_trainer"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbTrainer) Then
                With cmbtrainer
                    .DataSource = dtbTrainer
                    .DisplayMember = "trainer_name"
                    .ValueMember = "trainer_id"
                End With
            End If
            cmbtrainer.Text = ""
            cmbtrainer.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbvenue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvenue.SelectedIndexChanged
        Try
            dtbTEnroll = New DataTable
            strQry = "select DISTINCT(start_date) FROM tbl_training_enrollment WHERE " & vbCrLf & _
                         "trainer_id in(select trainer_id from tbl_trainer where trainer_name ='" & cmbtrainer.Text.Trim & "') and venue_id in(select venue_id from tbl_training_venue where name ='" & cmbvenue.Text.ToString & "')"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbTEnroll) Then
                With cmbstartdate
                    .DataSource = dtbTEnroll
                    .DisplayMember = "start_date"
                    .ValueMember = "start_date"
                End With
            End If
            cmbstartdate.Text = ""
            cmbstartdate.SelectedIndex = -1
            dtbTEnroll = Nothing
            dtbTEnroll = New DataTable
            strQry = "select DISTINCT(end_date) FROM tbl_training_enrollment WHERE " & vbCrLf & _
                     "trainer_id in(select trainer_id from tbl_trainer where trainer_name ='" & cmbtrainer.Text.Trim & "') and venue_id in(select venue_id from tbl_training_venue where name ='" & cmbvenue.Text.ToString & "')"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbTEnroll) Then
                With cmbenddate
                    .DataSource = dtbTEnroll
                    .DisplayMember = "end_date"
                    .ValueMember = "end_date"
                End With
            End If
            cmbenddate.Text = ""
            cmbenddate.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbtrainer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtrainer.SelectedIndexChanged
        Try
            dtbTEnroll = New DataTable
            strQry = "select DISTINCT(start_date) FROM tbl_training_enrollment WHERE " & vbCrLf & _
                         "trainer_id in(select trainer_id from tbl_trainer where trainer_name ='" & cmbtrainer.Text.Trim & "') and venue_id in(select venue_id from tbl_training_venue where name ='" & cmbvenue.Text.Trim & "')"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbTEnroll) Then
                With cmbstartdate
                    .DataSource = dtbTEnroll
                    .DisplayMember = "start_date"
                    .ValueMember = "start_date"
                End With
            End If
            cmbstartdate.Text = ""
            cmbstartdate.SelectedIndex = -1
            dtbTEnroll = New DataTable
            strQry = "select DISTINCT(end_date) FROM tbl_training_enrollment WHERE " & vbCrLf & _
                     "trainer_id in(select trainer_id from tbl_trainer where trainer_name ='" & cmbtrainer.Text.Trim & "') and venue_id in(select venue_id from tbl_training_venue where name ='" & cmbvenue.Text.Trim & "')"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbTEnroll) Then
                With cmbenddate
                    .DataSource = dtbTEnroll
                    .DisplayMember = "end_date"
                    .ValueMember = "end_date"
                End With
            End If
            cmbenddate.Text = ""
            cmbenddate.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
End Class