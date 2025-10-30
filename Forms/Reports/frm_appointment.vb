Imports System.Data.SqlClient
Public Class frm_appointment
#Region " Variable Declaration "
    Dim dtbLocation, dtbdepartment, dtbempcode As DataTable
    Dim ObjClsGen As New cls_General
    Dim strempcode As String
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
    Private Sub frm_appointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadDefault()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmblocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocnm.SelectedIndexChanged
        dtbdepartment = New DataTable
        ObjClsGen.cmbdeptname(dtbdepartment, cmbdeptnm, cmblocnm.Text)
    End Sub

    Private Sub cmbempcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempcode.SelectedIndexChanged
        Try
            ' cmbempcode.SelectedIndex = -1
            txtempname.Text = ""
            Dim cmdhodnm As New sqlCommand
            Dim drhodnm As sqlDataReader
            masterform.con.Close()
            masterform.con.Open()
            cmdhodnm.CommandText = "SELECT short_name FROM tbl_employee WHERE employee_code ='" & cmbempcode.Text & "'"
            cmdhodnm.Connection = masterform.con
            drhodnm = cmdhodnm.ExecuteReader
            If drhodnm.HasRows Then
                drhodnm.Read()
                txtempname.Text = drhodnm.GetString(0)
            End If
            drhodnm.Close()
            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmbdeptnm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdeptnm.SelectedIndexChanged
        Try
            strempcode = "select * from tbl_Employee WHERE location_id IN(SELECT location_id FROM tbl_location WHERE location_name='" & cmblocnm.Text.Trim & "') AND " & _
                         "department_id IN(SELECT department_id FROM tbl_department WHERE department_name='" & cmbdeptnm.Text.Trim & "') "
            If ObjClsGen.Getdata(masterform.con, strempcode, dtbempcode) Then
                With cmbempcode
                    .DataSource = dtbempcode
                    .DisplayMember = "employee_code"
                    .ValueMember = "employee_code"
                End With
                cmbempcode.Text = ""
                cmbempcode.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        Dim strQry As String
        Dim m_tbl As New DataTable
        strQry = "select * from tbl_employee where location_id like '" & cmblocnm.SelectedValue & "'and department_id like '" & cmbdeptnm.SelectedValue & "'and employee_code like '" & cmbempcode.Text.Trim & "'"
        If ObjClsGen.Getdata(masterform.con, strQry, m_tbl) Then
            Dim rptnew As New Reportviewer("appointmentletter", m_tbl)
            rptnew.Show()
        End If
    End Sub
#End Region

#Region " Function "
    Private Function LoadDefault() As Boolean
        Dim blnReturn As Boolean = True
        Try
            dtbLocation = New DataTable
            ObjClsGen.cmblocationname(dtbLocation, cmblocnm)
            cmblocnm.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            blnReturn = False
        End Try
        Return blnReturn
    End Function
#End Region
End Class