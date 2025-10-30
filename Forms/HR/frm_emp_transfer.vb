
Imports System.Data.SqlClient
Public Class frm_emp_transfer

#Region "variables"
    Private dtbLocation, dtbDepartment, dtbempcode As DataTable
    Dim ObjclsGen As New cls_General
    Dim strQry As String
    Dim drEmpTransfer As sqlDataReader
    Dim cmdEmpTransfer As New sqlCommand
    Dim ismodify As Boolean = True
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_emp_transfer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If ismodify = True Then
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

    Private Sub frm_emp_transfer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtbLocation = New DataTable
        ObjclsGen.cmblocationname(dtbLocation, cmblocname)
        ObjclsGen.cmblocationname(dtbLocation, cmblocnmt)
        cmblocnmt.SelectedIndex = -1
    End Sub

    Private Sub cmblocname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptname, cmblocname.Text)
    End Sub

    Private Sub cmblocnmt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocnmt.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdeptnmt, cmblocnmt.Text)
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If validateEmpTransferData() Then
                ismodify = False
                cmdEmpTransfer.Connection = masterform.con
                cmdEmpTransfer.CommandText = "UPDATE tbl_employee SET location_id=" & cmblocnmt.SelectedValue & ",department_id=" & cmbdeptnmt.SelectedValue & _
                         ",payroll_type='" & cmbpayrolltype.Text.Trim & "',job_profile='" & txtjobt.Text.Trim & _
                         "',emp_position='" & cmbposition.Text.Trim & "',salary=" & txtsalt.Text.Trim & _
                         " WHERE employee_code='" & cmbempcode.Text.Trim & "'"
                cmdEmpTransfer.CommandType = CommandType.Text
                cmdEmpTransfer.ExecuteNonQuery()

                cmdEmpTransfer.CommandText = "INSERT INTO tbl_emp_transfer (location_id,department_id,employee_code,oldpayroll_type," & _
                                             "oldemp_position,oldjob,oldsalary,newlocation_id,newdepartment_id,transfer_date)" & _
                                             " VALUES (" & cmblocname.SelectedValue & "," & cmbdeptname.SelectedValue & _
                                             ",'" & cmbempcode.Text.Trim & "','" & txtpayrolltype.Text.Trim & _
                                             "','" & txtposition.Text.Trim & "','" & txtjob.Text.Trim & _
                                             "'," & txtsal.Text.Trim & "," & cmblocnmt.SelectedValue & _
                                             "," & cmbdeptnmt.SelectedValue & ",'" & dttime_transdate.Text.Trim & "')"
                cmdEmpTransfer.CommandType = CommandType.Text
                cmdEmpTransfer.ExecuteNonQuery()
                MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Exit Try
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmblocname.SelectedIndex = -1
        cmbdeptname.SelectedIndex = -1
        cmbempcode.SelectedIndex = -1
        txtempnm.Text = ""
        txtlocnm.Text = ""
        txtdeptnm.Text = ""
        txtpayrolltype.Text = ""
        txtjob.Text = ""
        txtposition.Text = ""
        txtsal.Text = ""
        cmblocnmt.SelectedIndex = -1
        cmbdeptnmt.SelectedIndex = -1
        cmbpayrolltype.SelectedIndex = -1
        txtjobt.Text = ""
        cmbposition.SelectedIndex = -1
        txtsalt.Text = ""
        dttime_transdate.Text = Today
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cmbdeptname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdeptname.SelectedIndexChanged
        Try
            Dim strempcode As String
            strempcode = "select * from tbl_Employee WHERE location_id in(SELECT location_id FROM tbl_location WHERE location_name='" & cmblocname.Text.Trim & "') and Department_id IN(SELECT Department_id FROM tbl_department WHERE department_name='" & cmbdeptname.Text.Trim & "') AND emp_inactive=0"
            If ObjclsGen.Getdata(masterform.con, strempcode, dtbempcode) Then
                With cmbempcode
                    .DataSource = dtbempcode
                    .DisplayMember = "employee_code"
                    .ValueMember = "employee_code"
                End With
            End If
            cmbempcode.SelectedIndex = -1
            txtempnm.Text = ""
            txtlocnm.Text = ""
            txtdeptnm.Text = ""
            txtpayrolltype.Text = ""
            txtjob.Text = ""
            txtposition.Text = ""
            txtsal.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btntrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntrans.Click
        cmblocnmt.Text = txtlocnm.Text
        cmbdeptnmt.Text = txtdeptnm.Text
        cmbpayrolltype.Text = txtpayrolltype.Text
        txtjobt.Text = txtjob.Text
        cmbposition.Text = txtposition.Text
        txtsalt.Text = txtsal.Text
    End Sub

    Private Sub cmbempcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempcode.SelectedIndexChanged
        Try
            masterform.con.Close()
            cmdEmpTransfer.CommandText = "SELECT short_name,payroll_type,job_profile,emp_position,salary FROM tbl_employee WHERE Lower(employee_code) LIKE '" & cmbempcode.Text.Trim.ToLower & "'"
            cmdEmpTransfer.Connection = masterform.con
            masterform.con.Open()
            drEmpTransfer = cmdEmpTransfer.ExecuteReader
            If drEmpTransfer.HasRows Then
                drEmpTransfer.Read()
                txtlocnm.Text = cmblocname.Text
                txtdeptnm.Text = cmbdeptname.Text
                txtempnm.Text = drEmpTransfer.GetString(0)
                txtpayrolltype.Text = drEmpTransfer.GetString(1)
                txtjob.Text = drEmpTransfer.GetString(2)
                txtposition.Text = drEmpTransfer.GetString(3)
                txtsal.Text = drEmpTransfer.Item(4)
            End If
            drEmpTransfer.Close()
            cmblocnmt.SelectedIndex = -1
            cmbdeptnmt.SelectedIndex = -1
            cmbpayrolltype.SelectedIndex = -1
            txtjobt.Text = ""
            cmbposition.SelectedIndex = -1
            txtsalt.Text = ""
            dttime_transdate.Text = Today
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
#End Region

#Region " Functions "

    Public Function validateEmpTransferData() As Boolean
        Dim dbReturn As Boolean = True
        Try
            If Not ObjclsGen.vallocdept(cmblocname, cmbdeptname) Then
                dbReturn = False
            End If
            If cmbempcode.SelectedIndex < 0 Then
                MsgBox("must required employee code", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbempcode.Focus()
            End If
            If cmblocnmt.SelectedIndex < 0 Then
                MsgBox("must required Transfer location name", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmblocnmt.Focus()
            End If
            If cmbdeptnmt.SelectedIndex < 0 Then
                MsgBox("must required Transfer department name", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbdeptnmt.Focus()
            End If
            If cmbpayrolltype.SelectedIndex < 0 Then
                MsgBox("must required Payroll Type", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbpayrolltype.Focus()
            End If
            If cmbposition.SelectedIndex < 0 Then
                MsgBox("must required Position", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                cmbposition.Focus()
            End If
            If txtjobt.Text.Trim = String.Empty Then
                MsgBox("must required Job", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                txtjobt.Focus()
            End If
            If txtsalt.Text.Trim = String.Empty Then
                MsgBox("must required Salary", MsgBoxStyle.Critical, Me.Text)
                dbReturn = False
                txtsalt.Focus()
            End If
            If dttime_transdate.Text.Trim = String.Empty Then
                MsgBox("must required Transfer date", MsgBoxStyle.Information, Me.Text)
                dbReturn = False
                dttime_transdate.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

#End Region

End Class