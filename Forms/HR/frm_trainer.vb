Imports System.Data.SqlClient
Public Class frm_trainer

#Region " variable declaration "
    Dim bsTrainer As New BindingSource
    Private dtbtrainer, dtbempcode As DataTable
    Dim dtrowtrainer As DataRow
    Dim ObjclsGen As New cls_General
    Dim Objhr As New cls_hr
    Dim strQry As String
    Dim cmdempcode As New sqlCommand
    Dim drempcode As sqlDataReader
#End Region

#Region "Constructors"
    Public Sub New()
        InitializeComponent()
        dtbtrainer = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_trainer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bsTrainer.EndEdit()
        Try
            If dtbtrainer.GetChanges IsNot Nothing Then
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

    Private Sub frm_trainer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        populateTrainerdata()
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_trainer.Enabled Then
                If validateTrainerData() Then
                    If Objhr.saveTrainerdata(masterform.con, dtbtrainer) Then
                        pnl_trainer.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_trainer.Enabled = True
                        populateTrainerdata()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.Click
        pnl_trainer.Enabled = True
        cmbtrainertype.Focus()
    End Sub

    Private Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        pnl_trainer.Enabled = False
        If Not populateTrainerdata() Then
            MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
        End If
    End Sub

    Private Sub txttrainernamefind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttrainernamefind.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                pnl_trainer.Enabled = False
                If Not populateTrainerdata() Then
                    pnl_trainer.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    

    Private Sub cmbempcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempcode.SelectedIndexChanged
        cmdempcode.Connection = masterform.con
        cmdempcode.CommandText = "SELECT short_name,current_address,current_city,current_state,current_phoneno,current_pinno,permanent_city,mobile_no,email_address FROM tbl_employee WHERE short_name='" & cmbempcode.Text & "'"
        masterform.con.Close()
        masterform.con.Open()
        drempcode = cmdempcode.ExecuteReader

        If drempcode.HasRows Then
            drempcode.Read()
            txttrainername.Text = drempcode.GetString(0)
            txtadd.Text = drempcode.GetString(1)
            txtcity.Text = drempcode.GetString(2)
            txtstate.Text = drempcode.GetString(3)
            txtphoneno.Text = drempcode.GetString(4)
            txtzipcode.Text = drempcode.GetString(5)
            txtcountry.Text = drempcode.GetString(6)
            txtmobileno.Text = drempcode.GetString(7)
            txtemail.Text = drempcode.GetString(8)
        End If
    End Sub

    Private Sub cmbtrainertype_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtrainertype.SelectedIndexChanged
        Try
            If cmbtrainertype.Text.ToUpper = UCase("external") Then
                ClearAllData()
                EnableContol(True)
                cmbempcode.Text = ""
                cmbempcode.SelectedIndex = -1
                cmbempcode.Enabled = False

            ElseIf cmbtrainertype.Text.ToUpper = UCase("internal") Then
                cmbempcode.Enabled = True
                EnableContol(False)
                strQry = "SELECT * FROM tbl_employee WHERE emp_inactive=0"
                If ObjclsGen.Getdata(masterform.con, strQry, dtbempcode) Then
                    With cmbempcode
                        .DataSource = dtbempcode
                        .DisplayMember = "short_name"
                        .ValueMember = "employee_code"
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
#End Region

#Region " Functions/Procedures "
    Private Sub ClearAllData()
        cmbtrainertype.Text = ""
        cmbempcode.Text = ""
        txttrainername.Text = ""
        txtadd.Text = ""
        txtcity.Text = ""
        txtstate.Text = ""
        txtcountry.Text = ""
        txtzipcode.Text = ""
        txtphoneno.Text = ""
        txtmobileno.Text = ""
        txtemail.Text = ""
        chkavailable.Checked = False
        DateTimePickerfromdate.Text = ""
        DateTimePickertodate.Text = ""
    End Sub
    Public Function populateTrainerdata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            masterform.con.Close()
            masterform.con.Open()
            If txttrainernamefind.Text = String.Empty Then
                strQry = "SELECT * FROM tbl_trainer ORDER BY trainer_name"
            Else
                strQry = "SELECT * FROM tbl_trainer  WHERE  Lower(trainer_name) LIKE '" & txttrainernamefind.Text.Trim.ToLower & "' "
                txttrainernamefind.Text = "%"
            End If
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbtrainer) Then
                pnl_trainer.Enabled = False
                dbReturn = False
            End If
            bsTrainer.DataSource = dtbtrainer
            bnvtrainer.BindingSource = bsTrainer
            If disp_record() Then
                If dtbtrainer.Rows.Count > 0 Then
                    pnl_trainer.Enabled = True
                    dbReturn = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        masterform.con.Close()
        Return dbReturn
    End Function

    Private Function disp_record() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbtrainer.Columns("available").DefaultValue = 0
            cmbtrainertype.DataBindings.Clear()
            cmbempcode.DataBindings.Clear()
            txttrainername.DataBindings.Clear()
            txtadd.DataBindings.Clear()
            txtcity.DataBindings.Clear()
            txtstate.DataBindings.Clear()
            txtcountry.DataBindings.Clear()
            txtzipcode.DataBindings.Clear()
            txtphoneno.DataBindings.Clear()
            txtmobileno.DataBindings.Clear()
            txtemail.DataBindings.Clear()
            chkavailable.DataBindings.Clear()
            DateTimePickerfromdate.DataBindings.Clear()
            DateTimePickertodate.DataBindings.Clear()

            cmbtrainertype.DataBindings.Add("TEXT", bsTrainer, "trainer_type")
            cmbempcode.DataBindings.Add("SelectedValue", bsTrainer, "employee_code")
            txttrainername.DataBindings.Add("TEXT", bsTrainer, "trainer_name")
            txtadd.DataBindings.Add("TEXT", bsTrainer, "address")
            txtcity.DataBindings.Add("TEXT", bsTrainer, "city")
            txtstate.DataBindings.Add("TEXT", bsTrainer, "state")
            txtcountry.DataBindings.Add("TEXT", bsTrainer, "country")
            txtzipcode.DataBindings.Add("TEXT", bsTrainer, "zipcode")
            txtphoneno.DataBindings.Add("TEXT", bsTrainer, "phone_no")
            txtmobileno.DataBindings.Add("TEXT", bsTrainer, "mobile_no")
            txtemail.DataBindings.Add("TEXT", bsTrainer, "email")
            chkavailable.DataBindings.Add("CHECKED", bsTrainer, "available", True)
            DateTimePickerfromdate.DataBindings.Add("TEXT", bsTrainer, "from_date")
            DateTimePickertodate.DataBindings.Add("TEXT", bsTrainer, "to_date")

            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function validateTrainerData() As Boolean
        Dim dbReturn As Boolean = True
        bsTrainer.EndEdit()
        Try
            For Each dtrowtrainer In dtbtrainer.Rows
                If dtrowtrainer.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowtrainer("trainer_name")) Or (dtrowtrainer("trainer_name").Equals(String.Empty)) Then
                        MsgBox("Must enter Trainer Name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txttrainername.Focus()
                    End If
                    If IsDBNull(dtrowtrainer("city")) Or (dtrowtrainer("city").Equals(String.Empty)) Then
                        MsgBox("Must enter City", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcity.Focus()
                    End If
                    If IsDBNull(dtrowtrainer("country")) Or (dtrowtrainer("country").Equals(String.Empty)) Then
                        MsgBox("Must enter Country", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcountry.Focus()
                    End If
                    If IsDBNull(dtrowtrainer("available")) Or (dtrowtrainer("available").Equals(String.Empty)) Then
                        MsgBox("Must Enter available", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        chkavailable.Focus()
                    End If
                    If IsDBNull(dtrowtrainer("from_date")) Or (dtrowtrainer("from_date").Equals(String.Empty)) Then
                        MsgBox("Must enter From Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        DateTimePickerfromdate.Focus()
                    End If
                    If IsDBNull(dtrowtrainer("to_date")) Or (dtrowtrainer("to_date").Equals(String.Empty)) Then
                        MsgBox("Must Enter To Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        DateTimePickertodate.Focus()
                    ElseIf dtrowtrainer("to_date") < dtrowtrainer("from_date") Then
                        MsgBox("To Date must be greater than From Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowtrainer("address")) Or (dtrowtrainer("address").Equals(String.Empty)) Then
                        dtrowtrainer("address") = ""
                    End If
                    If IsDBNull(dtrowtrainer("employee_code")) Or (dtrowtrainer("employee_code").Equals(String.Empty)) Then
                        dtrowtrainer("employee_code") = ""
                    End If
                    If IsDBNull(dtrowtrainer("phone_no")) Or (dtrowtrainer("phone_no").Equals(String.Empty)) Then
                        dtrowtrainer("phone_no") = ""
                    End If
                    If IsDBNull(dtrowtrainer("state")) Or (dtrowtrainer("state").Equals(String.Empty)) Then
                        dtrowtrainer("state") = ""
                    End If
                    If IsDBNull(dtrowtrainer("zipcode")) Or (dtrowtrainer("zipcode").Equals(String.Empty)) Then
                        dtrowtrainer("zipcode") = ""
                    End If
                    If IsDBNull(dtrowtrainer("mobile_no")) Or (dtrowtrainer("mobile_no").Equals(String.Empty)) Then
                        dtrowtrainer("mobile_no") = ""
                    End If
                    If IsDBNull(dtrowtrainer("email")) Or (dtrowtrainer("email").Equals(String.Empty)) Then
                        dtrowtrainer("email") = ""
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Sub EnableContol(ByVal bln As Boolean)
        txttrainername.Enabled = bln
        txtadd.Enabled = bln
        txtcity.Enabled = bln
        txtstate.Enabled = bln
        txtphoneno.Enabled = bln
        txtemail.Enabled = bln
        txtzipcode.Enabled = bln
        txtcountry.Enabled = bln
        txtmobileno.Enabled = bln
    End Sub
#End Region



End Class