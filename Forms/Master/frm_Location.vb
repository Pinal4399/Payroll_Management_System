Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frm_location

#Region " variable declaration "
    Dim bsLocation As New BindingSource
    Private dtbLocation, dtbCompany As DataTable
    Dim dtlocationrow As DataRow
    Dim cmdcmpcode, cmd As New sqlCommand
    Dim ObjclsGen As New cls_General
    Dim strQry As String
#End Region

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbLocation = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region "Events  "

    Private Sub frm_location_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bsLocation.EndEdit()
        Try
            If dtbLocation.GetChanges IsNot Nothing Then
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
    Private Sub frm_location_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtbCompany = New DataTable
        Try
            strQry = "SELECT company_id,company_name FROM tbl_company"
            If ObjclsGen.Getdata(masterform.con, strQry, dtbCompany) Then
                With bnvcmbCompany.ComboBox
                    .DataSource = dtbCompany
                    .DisplayMember = "company_name"
                    .ValueMember = "company_id"
                End With
            End If
            populateLocdata()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        locationpanel.Enabled = True
        txtloccode.Focus()
        bsLocation.EndEdit()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If locationpanel.Enabled Then
                If validateLocData() Then
                    If ObjclsGen.saveLocdata(masterform.con, dtbLocation, bnvcmbCompany.ComboBox.SelectedValue) Then
                        locationpanel.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Sava Data")
                        locationpanel.Enabled = True
                        masterform.con.Close()
                        populateLocdata()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        locationpanel.Enabled = False
        If Not populateLocdata() Then
            MsgBox("Record not found", MsgBoxStyle.Information, "Record not found")
        End If
    End Sub

    Private Sub bnvcmbCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bnvcmbCompany.KeyDown
        findenter(e)
    End Sub

    Private Sub txtlocnamefind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlocnamefind.KeyDown
        findenter(e)
    End Sub

    Private Sub txtzipcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtphno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not (IsNumeric(e.KeyChar))) And (Not (Asc(e.KeyChar) = 32)) And (Not (e.KeyChar = "-")) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtfaxno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtemail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Len(txtemail.Text) >= 1 Then
            If (Not (txtemail.Text.Contains("@") And txtemail.Text.Contains("."))) Or (txtemail.Text.Contains(" ")) Then
                MsgBox("Invalid Email Id...")
                txtemail.Focus()
            End If
        End If
    End Sub

#End Region

#Region " Functions/Procedures "

    Private Function loc_disp_record() As Boolean
        Dim dbReturn As Boolean = False
        Try
            txtloccode.DataBindings.Clear()
            txtlocationname.DataBindings.Clear()
            txtaddress.DataBindings.Clear()
            txtcity.DataBindings.Clear()
            txtstate.DataBindings.Clear()
            txtcountry.DataBindings.Clear()
            txtzipcode.DataBindings.Clear()
            txtphno.DataBindings.Clear()
            txtfaxno.DataBindings.Clear()
            txtemail.DataBindings.Clear()
            txtauthnm.DataBindings.Clear()
            txtowner.DataBindings.Clear()
            txtoccupier.DataBindings.Clear()

            txtloccode.DataBindings.Add("TEXT", bsLocation, "location_code")
            txtlocationname.DataBindings.Add("TEXT", bsLocation, "location_name")
            txtaddress.DataBindings.Add("TEXT", bsLocation, "address")
            txtcity.DataBindings.Add("TEXT", bsLocation, "city")
            txtstate.DataBindings.Add("TEXT", bsLocation, "state")
            txtcountry.DataBindings.Add("TEXT", bsLocation, "country")
            txtzipcode.DataBindings.Add("TEXT", bsLocation, "zip_code")
            txtphno.DataBindings.Add("TEXT", bsLocation, "phone_no")
            txtfaxno.DataBindings.Add("TEXT", bsLocation, "fax_no")
            txtemail.DataBindings.Add("TEXT", bsLocation, "email")
            txtauthnm.DataBindings.Add("TEXT", bsLocation, "authorized_person")
            txtowner.DataBindings.Add("TEXT", bsLocation, "owner")
            txtoccupier.DataBindings.Add("TEXT", bsLocation, "occupier")
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function populateLocdata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            If Not ClearBinding() Then
                Exit Try
            End If
            masterform.con.Close()
            masterform.con.Open()
            dtbLocation = New DataTable
            strQry = "SELECT * FROM tbl_location WHERE  Lower(location_name) LIKE '" & txtlocnamefind.Text.Trim.ToLower & "' and company_id in(select company_id from tbl_company where company_name='" & bnvcmbCompany.ComboBox.Text.ToString & "')"

            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbLocation) Then
                locationpanel.Enabled = False
                dbReturn = False
            End If
            bsLocation.DataSource = dtbLocation
            BindingNavigator1.BindingSource = bsLocation
            If loc_disp_record() Then
                If dtbLocation.Rows.Count > 0 Then
                    locationpanel.Enabled = True
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
            dtbLocation = New DataTable
            If dtbLocation.Columns.Count > 0 Then
                txtloccode.DataBindings.Clear()
                txtlocationname.DataBindings.Clear()
                txtaddress.DataBindings.Clear()
                txtcity.DataBindings.Clear()
                txtstate.DataBindings.Clear()
                txtcountry.DataBindings.Clear()
                txtzipcode.DataBindings.Clear()
                txtphno.DataBindings.Clear()
                txtfaxno.DataBindings.Clear()
                txtemail.DataBindings.Clear()
                txtauthnm.DataBindings.Clear()
                txtowner.DataBindings.Clear()
                txtoccupier.DataBindings.Clear()

            End If
            dtbLocation = Nothing
            dtbLocation = New DataTable
            bsLocation = Nothing
            bsLocation = New BindingSource
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

        Return dbReturn
    End Function

    Private Sub ClearAllData()
        txtloccode.Text = ""
        txtlocationname.Text = ""
        txtaddress.Text = ""
        txtcity.Text = ""
        txtstate.Text = ""
        txtcountry.Text = ""
        txtzipcode.Text = ""
        txtphno.Text = ""
        txtfaxno.Text = ""
        txtemail.Text = ""
        txtauthnm.Text = ""
        txtowner.Text = ""
        txtoccupier.Text = ""
    End Sub

    Private Function validateLocData() As Boolean
        Dim dbReturn As Boolean = True
        bsLocation.EndEdit()
        Try
            For Each dtlocationrow In dtbLocation.Rows
                If dtlocationrow.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtlocationrow("location_code")) Or (dtlocationrow("location_code").Equals(String.Empty)) Then
                        MsgBox("Must enter Location code", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtloccode.Focus()
                    End If
                    If IsDBNull(dtlocationrow("location_name")) Or (dtlocationrow("location_name").Equals(String.Empty)) Then
                        MsgBox("Must enter location name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtlocationname.Focus()
                    End If
                    If IsDBNull(dtlocationrow("address")) Or (dtlocationrow("address").Equals(String.Empty)) Then
                        MsgBox("Must Enter address", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtaddress.Focus()
                    End If
                    If IsDBNull(dtlocationrow("city")) Or (dtlocationrow("city").Equals(String.Empty)) Then
                        MsgBox("Must enter City", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcity.Focus()
                    End If
                    If IsDBNull(dtlocationrow("country")) Or (dtlocationrow("country").Equals(String.Empty)) Then
                        MsgBox("Must enter Country", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcountry.Focus()
                    End If
                    If IsDBNull(dtlocationrow("phone_no")) Or (dtlocationrow("phone_no").Equals(String.Empty)) Then
                        dtlocationrow("phone_no") = ""
                    End If
                    If IsDBNull(dtlocationrow("state")) Or (dtlocationrow("state").Equals(String.Empty)) Then
                        dtlocationrow("state") = ""
                    End If
                    If IsDBNull(dtlocationrow("zip_code")) Or (dtlocationrow("zip_code").Equals(String.Empty)) Then
                        dtlocationrow("zip_code") = ""
                    End If
                    If IsDBNull(dtlocationrow("fax_no")) Or (dtlocationrow("fax_no").Equals(String.Empty)) Then
                        dtlocationrow("fax_no") = ""
                    End If
                    If IsDBNull(dtlocationrow("email")) Or (dtlocationrow("email").Equals(String.Empty)) Then
                        dtlocationrow("email") = ""
                    End If
                    If IsDBNull(dtlocationrow("authorized_person")) Or (dtlocationrow("authorized_person").Equals(String.Empty)) Then
                        dtlocationrow("authorized_person") = ""
                    End If
                    If IsDBNull(dtlocationrow("owner")) Or (dtlocationrow("owner").Equals(String.Empty)) Then
                        dtlocationrow("owner") = ""
                    End If
                    If IsDBNull(dtlocationrow("occupier")) Or (dtlocationrow("occupier").Equals(String.Empty)) Then
                        dtlocationrow("occupier") = ""
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
                locationpanel.Enabled = False
                If Not populateLocdata() Then
                    locationpanel.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
#End Region
End Class
