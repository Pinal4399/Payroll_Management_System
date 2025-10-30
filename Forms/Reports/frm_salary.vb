Public Class frm_salary

#Region "Variable Declaration"
    Dim dtbLocation, dtbdept As DataTable
    Dim ObjClsGen As New cls_General
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ObjClsGen.showMdi(Me)
    End Sub
#End Region

#Region " Functions/Procedures "

    Private Function LoadDefault() As Boolean
        Dim blnReturn As Boolean = True
        Try
            dtbLocation = New DataTable
            ObjClsGen.cmblocationname(dtbLocation, cmblocation)
            cmblocation.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            blnReturn = False
        End Try
        Return blnReturn
    End Function

#End Region

#Region " Events "

    Private Sub frm_salary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            LoadDefault()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub cmblocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocation.SelectedIndexChanged
        Dim strQry As String
        Try
            chkselected.Checked = False
            dtbdept = New DataTable
            If cmblocation.Text = String.Empty Then
                strQry = "SELECT department_id,department_name FROM tbl_department order by department_name"
            Else
                strQry = "select department_id,department_name from tbl_department " & vbCrLf & _
                              "where location_id = " & Val(cmblocation.SelectedValue.ToString)
            End If
            With grid_salary
                If ObjClsGen.Getdata(masterform.con, strQry, dtbdept) Then
                    masterform.con.Open()
                    dtbdept.Columns.Add("id")
                    .AutoGenerateColumns = False
                    .DataSource = Nothing
                    .DataSource = dtbdept
                    .ReadOnly = False
                    btnreport.Enabled = True
                    If dtbdept.Rows.Count > 0 Then
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
        End Try
        masterform.con.Close()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        Dim strQry As String
        Dim m_tbl As New DataTable
        Dim strfind As String = String.Empty
        Dim dtbrow As DataRow
        If cmblocation.Text = String.Empty Then
            MsgBox("Location can not be Blank", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If
        For Each dtbrow In dtbdept.Rows
            If Val(dtbrow("id").ToString) = 1 Then
                If strfind = String.Empty Then strfind = "0"
                strfind = strfind & "," & Val(dtbrow("department_id").ToString)
            End If
        Next
        If strfind = String.Empty Then
            strfind = 0
        End If

        strQry = "select es.*,e.*,l.location_name,d.department_name from tbl_emp_salaryprocess es,tbl_employee e,tbl_location l,tbl_department d where " & _
                 "es.location_id=l.location_id and es.department_id=d.department_id and es.employee_code=e.employee_code " & _
                 "AND (es.location_id LIKE '" & cmblocation.SelectedValue & "') and es.department_id in(" & strfind & ") "
        If Not ObjClsGen.Getdata(masterform.con, strQry, m_tbl) Then
            MsgBox("There are no records for selection", MsgBoxStyle.Information, Me.Text)
        Else
            Dim rptnew As New Reportviewer("Salary", m_tbl)
            rptnew.Show()
        End If
    End Sub

    Private Sub grid_salary_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grid_salary.DataError
        e.Cancel = True
    End Sub

    Private Sub chkselected_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkselected.CheckedChanged
        Try
            Dim draw As DataGridViewRow
            If chkselected.Checked = True Then
                For Each draw In grid_salary.Rows
                    draw.Cells("clmselected").Value = 1
                Next
            Else
                For Each draw In grid_salary.Rows
                    draw.Cells("clmselected").Value = 0
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
#End Region
End Class