Imports System.Data.SqlClient
Public Class frm_department

#Region " variable declaration "
    Dim bsDepartment As New BindingSource
    Private dtbLocation, dtbDepartment, dtbEmployee As DataTable
    Dim dtdeptrow As DataRow
    Dim ObjclsGen As New cls_General
    Dim strQry As String
#End Region

#Region " Constructor "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        dtbDepartment = New DataTable
        ObjclsGen.showMdi(Me)
        ' Add any initialization after the InitializeComponent() call.
    End Sub
#End Region

#Region "Events"

    Private Sub frm_department_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bsDepartment.EndEdit()
        Try
            If dtbDepartment.GetChanges IsNot Nothing Then
                Dim dlg As Windows.Forms.DialogResult = cls_General.SaveMsg("Do You Want To Save Records ?", Me.Text)
                If dlg = Windows.Forms.DialogResult.Yes Then
                    btnsave_Click(sender, e)
                ElseIf dlg = Windows.Forms.DialogResult.Cancel Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub


    Private Sub frm_department_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strQrys As String
        dtbLocation = New DataTable
        Try
            strQrys = "SELECT location_id,location_name FROM tbl_location WHERE company_id IN(SELECT company_id " & _
                      "FROM tbl_company WHERE Upper(company_name) LIKE 'Laxmi Diamond Pvt. Ltd.')"
            If ObjclsGen.Getdata(masterform.con, strQrys, dtbLocation) Then
                With bnvcmbLocation.ComboBox
                    .DataSource = dtbLocation
                    .DisplayMember = "location_name"
                    .ValueMember = "location_id"
                End With
            End If

            Dim strqryhodid As String
            dtbEmployee = New DataTable
            strqryhodid = "SELECT employee_code FROM tbl_employee "
            If ObjclsGen.Getdata(masterform.con, strqryhodid, dtbEmployee) Then
                With cmbhodempcode
                    .DataSource = dtbEmployee
                    .DisplayMember = "employee_code"
                    .ValueMember = "employee_code"
                End With
            End If

            populateDeptdata()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    
    Private Sub cmbhodempcode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbhodempcode.SelectedIndexChanged
        Try
            Dim cmdhodnm As New sqlCommand
            Dim drhodnm As sqlDataReader
            masterform.con.Close()
            masterform.con.Open()
            cmdhodnm.CommandText = "SELECT short_name FROM tbl_employee WHERE employee_code ='" & cmbhodempcode.Text & "'"
            cmdhodnm.Connection = masterform.con
            drhodnm = cmdhodnm.ExecuteReader
            If drhodnm.HasRows Then
                drhodnm.Read()
                txthodempname.Text = drhodnm.GetString(0)
            End If
            drhodnm.Close()
            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.Click
        deptpanel.Enabled = True
        txtdepartmentcode.Focus()
        chkisactive.Checked = False
        bsDepartment.EndEdit()
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If deptpanel.Enabled Then
                If validateDeptData() Then
                    If ObjclsGen.saveDeptdata(masterform.con, dtbDepartment, bnvcmbLocation.ComboBox.SelectedValue.ToString) Then
                        deptpanel.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        deptpanel.Enabled = True
                        masterform.con.Close()
                        populateDeptdata()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        If cmbhodempcode.Text = "" Then
            txthodempname.Text = ""
        End If
        deptpanel.Enabled = False
        If Not populateDeptdata() Then
            MsgBox("Record not found", MsgBoxStyle.Information, "Record not found")
        End If
    End Sub

    Private Sub bnvcmbLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bnvcmbLocation.KeyDown
        findenter(e)
    End Sub

    Private Sub txtdeptnamefind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdeptnamefind.KeyDown
        findenter(e)
    End Sub

#End Region

#Region " Functions/Procedures "

    Private Function dept_disp_record() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbDepartment.Columns("dept_isactive").DefaultValue = 0
            txtdepartmentcode.DataBindings.Clear()
            txtdepartmentname.DataBindings.Clear()
            cmbhodempcode.DataBindings.Clear()
            txthodempname.DataBindings.Clear()
            txtdeptdesc.DataBindings.Clear()
            chkisactive.DataBindings.Clear()

            txtdepartmentcode.DataBindings.Add("TEXT", bsDepartment, "department_code")
            txtdepartmentname.DataBindings.Add("TEXT", bsDepartment, "department_name")
            cmbhodempcode.DataBindings.Add("TEXT", bsDepartment, "hod_empid")
            txthodempname.DataBindings.Add("TEXT", bsDepartment, "hod_empname")
            txtdeptdesc.DataBindings.Add("TEXT", bsDepartment, "dept_description")
            chkisactive.DataBindings.Add("CHECKED", bsDepartment, "dept_isactive", True)
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function populateDeptdata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            If Not ClearBinding() Then
                Exit Try
            End If
            masterform.con.Close()
            masterform.con.Open()
            dtbDepartment = New DataTable
            strQry = "SELECT * FROM tbl_department WHERE  Lower(department_name) LIKE '" & txtdeptnamefind.Text.Trim.ToLower & "' and location_id in(select location_id from tbl_location where location_name='" & bnvcmbLocation.ComboBox.Text.ToString & "')"

            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbDepartment) Then
                deptpanel.Enabled = False
                dbReturn = False
            End If
            bsDepartment.DataSource = dtbDepartment
            BindingNavigator1.BindingSource = bsDepartment
            If dept_disp_record() Then
                If dtbDepartment.Rows.Count > 0 Then
                    deptpanel.Enabled = True
                    dbReturn = True
                End If
            End If
            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function ClearBinding() As Boolean
        Dim dbReturn As Boolean = False
        Try
            ClearAllData()
            dtbDepartment = New DataTable
            If dtbLocation.Columns.Count > 0 Then

                txtdepartmentcode.DataBindings.Clear()
                txtdepartmentname.DataBindings.Clear()
                cmbhodempcode.DataBindings.Clear()
                txthodempname.DataBindings.Clear()
                txtdeptdesc.DataBindings.Clear()
                chkisactive.DataBindings.Clear()
            End If
            dtbDepartment = Nothing
            dtbDepartment = New DataTable
            bsDepartment = Nothing
            bsDepartment = New BindingSource
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Sub ClearAllData()
        chkisactive.Checked = False
        txtdepartmentcode.Text = ""
        txtdepartmentname.Text = ""
        cmbhodempcode.Text = ""
        txthodempname.Text = ""
        txtdeptdesc.Text = ""
    End Sub

    Private Function validateDeptData() As Boolean
        Dim dbReturn As Boolean = True
        bsDepartment.EndEdit()
        Try
            For Each dtdeptrow In dtbDepartment.Rows
                If dtdeptrow.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtdeptrow("department_code")) Or (dtdeptrow("department_code").Equals(String.Empty)) Then
                        MsgBox("Must enter department code", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtdepartmentcode.Focus()
                    End If
                    If IsDBNull(dtdeptrow("department_name")) Or (dtdeptrow("department_name").Equals(String.Empty)) Then
                        MsgBox("Must enter department name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtdepartmentname.Focus()
                    End If
                    'If IsDBNull(dtdeptrow("hod_empid")) Or (dtdeptrow("hod_empid").Equals(String.Empty)) Then
                    '    MsgBox("Must enter Head of Department", MsgBoxStyle.Information, Me.Text)
                    '    dbReturn = False
                    '    cmbhodempcode.Focus()
                    'End If
                    If IsDBNull(dtdeptrow("dept_description")) Or (dtdeptrow("dept_description").Equals(String.Empty)) Then
                        dtdeptrow("dept_description") = ""
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Sub findenter(ByVal e)
        Try
            If e.KeyCode = Keys.Enter Then
                deptpanel.Enabled = False
                If Not populateDeptdata() Then
                    deptpanel.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
#End Region

End Class