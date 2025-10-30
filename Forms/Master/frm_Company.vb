Imports System.Data.DataTable

Public Class frm_company

#Region " variable declaration "
    Dim bsCompany As New BindingSource
    Private dtbCompany As DataTable
    Dim dtcompanyrow As DataRow
    Dim ObjclsGen As New cls_General
    Dim strQry As String
#End Region

#Region "Constructors"
    Public Sub New()
        InitializeComponent()
        dtbCompany = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_company_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bsCompany.EndEdit()
        Try
            If dtbCompany.GetChanges IsNot Nothing Then
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

    Private Sub company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            populateCmpdata()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If companypanel.Enabled Then
                If validateCmpData() Then
                    If ObjclsGen.saveCmpdata(masterform.con, dtbCompany) Then
                        companypanel.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        companypanel.Enabled = True
                        populateCmpdata()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        companypanel.Enabled = True
        txtcmpcode.Focus()
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        companypanel.Enabled = False
        If Not populateCmpdata() Then
            MsgBox("Record not found", MsgBoxStyle.Information, "Record not found")
        End If
    End Sub

    Private Sub txtcmpnamefind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcmpnamefind.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                companypanel.Enabled = False
                If Not populateCmpdata() Then
                    companypanel.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtphno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphno.KeyPress
        If (Not (IsNumeric(e.KeyChar))) And (Not (Asc(e.KeyChar) = 32)) And (Not (e.KeyChar = "-")) Then
            e.KeyChar = ""
        End If
    End Sub
#End Region

#Region " Functions/Procedures "

    Private Function disp_record() As Boolean
        Dim dbReturn As Boolean = False
        Try
            txtcmpcode.DataBindings.Clear()
            txtcmpname.DataBindings.Clear()
            txtaddress.DataBindings.Clear()
            txtcity.DataBindings.Clear()
            txtstate.DataBindings.Clear()
            txtcountry.DataBindings.Clear()
            txtzipcode.DataBindings.Clear()
            txtphno.DataBindings.Clear()
            txtfaxno.DataBindings.Clear()
            txtemail.DataBindings.Clear()
            txtwebsite.DataBindings.Clear()

            txtcmpcode.DataBindings.Add("TEXT", bsCompany, "company_code")
            txtcmpname.DataBindings.Add("TEXT", bsCompany, "company_name")
            txtaddress.DataBindings.Add("TEXT", bsCompany, "address")
            txtcity.DataBindings.Add("TEXT", bsCompany, "city")
            txtstate.DataBindings.Add("TEXT", bsCompany, "state")
            txtcountry.DataBindings.Add("TEXT", bsCompany, "country")
            txtzipcode.DataBindings.Add("TEXT", bsCompany, "zip_code")
            txtphno.DataBindings.Add("TEXT", bsCompany, "phone_no")
            txtfaxno.DataBindings.Add("TEXT", bsCompany, "fax_no")
            txtemail.DataBindings.Add("TEXT", bsCompany, "email")
            txtwebsite.DataBindings.Add("TEXT", bsCompany, "website")

            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function populateCmpdata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            If Not ClearBinding() Then
                Exit Try
            End If
            dtbCompany = New DataTable
            masterform.con.Close()
            masterform.con.Open()
            strQry = "SELECT * FROM tbl_company WHERE Lower(company_name) LIKE '" & txtcmpnamefind.Text.Trim.ToLower & "' "
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbCompany) Then
                companypanel.Enabled = False
                dbReturn = False
            End If
            bsCompany.DataSource = dtbCompany
            bnvcompany.BindingSource = bsCompany
            If disp_record() Then
                If dtbCompany.Rows.Count > 0 Then
                    companypanel.Enabled = True
                    dbReturn = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        masterform.con.Close()
        Return dbReturn
    End Function

    Private Function ClearBinding() As Boolean
        Dim dbReturn As Boolean = False
        Try
            ClearAllData()
            If dtbCompany.Columns.Count > 0 Then
                txtcmpcode.DataBindings.Clear()
                txtcmpname.DataBindings.Clear()
                txtaddress.DataBindings.Clear()
                txtcity.DataBindings.Clear()
                txtstate.DataBindings.Clear()
                txtcountry.DataBindings.Clear()
                txtzipcode.DataBindings.Clear()
                txtphno.DataBindings.Clear()
                txtfaxno.DataBindings.Clear()
                txtemail.DataBindings.Clear()
                txtwebsite.DataBindings.Clear()
            End If
            dtbCompany = Nothing
            dtbCompany = New DataTable
            bsCompany = Nothing
            bsCompany = New BindingSource

            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

        Return dbReturn
    End Function

    Private Sub ClearAllData()
        txtcmpcode.Text = ""
        txtcmpname.Text = ""
        txtaddress.Text = ""
        txtcity.Text = ""
        txtstate.Text = ""
        txtcountry.Text = ""
        txtzipcode.Text = ""
        txtphno.Text = ""
        txtfaxno.Text = ""
        txtemail.Text = ""
        txtwebsite.Text = ""
    End Sub

    Private Function validateCmpData() As Boolean
        Dim dbReturn As Boolean = True
        bsCompany.EndEdit()
        Try
            For Each dtcompanyrow In dtbCompany.Rows
                If dtcompanyrow.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtcompanyrow("company_code")) Or (dtcompanyrow("company_code").Equals(String.Empty)) Then
                        MsgBox("Must enter Company code", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcmpcode.Focus()
                    End If
                    If IsDBNull(dtcompanyrow("company_name")) Or (dtcompanyrow("company_name").Equals(String.Empty)) Then
                        MsgBox("Must enter Company Name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcmpname.Focus()
                    End If
                    If IsDBNull(dtcompanyrow("address")) Or (dtcompanyrow("address").Equals(String.Empty)) Then
                        MsgBox("Must Enter address", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtaddress.Focus()
                    End If
                    If IsDBNull(dtcompanyrow("city")) Or (dtcompanyrow("city").Equals(String.Empty)) Then
                        MsgBox("Must enter City", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcity.Focus()
                    End If
                    If IsDBNull(dtcompanyrow("country")) Or (dtcompanyrow("country").Equals(String.Empty)) Then
                        MsgBox("Must enter Country", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcountry.Focus()
                    End If
                    If IsDBNull(dtcompanyrow("phone_no")) Or (dtcompanyrow("phone_no").Equals(String.Empty)) Then
                        dtcompanyrow("phone_no") = ""
                    End If
                    If IsDBNull(dtcompanyrow("state")) Or (dtcompanyrow("state").Equals(String.Empty)) Then
                        dtcompanyrow("state") = ""
                    End If
                    If IsDBNull(dtcompanyrow("zip_code")) Or (dtcompanyrow("zip_code").Equals(String.Empty)) Then
                        dtcompanyrow("zip_code") = ""
                    End If
                    If IsDBNull(dtcompanyrow("fax_no")) Or (dtcompanyrow("fax_no").Equals(String.Empty)) Then
                        dtcompanyrow("fax_no") = ""
                    End If
                    If IsDBNull(dtcompanyrow("email")) Or (dtcompanyrow("email").Equals(String.Empty)) Then
                        dtcompanyrow("email") = ""
                    End If
                    If IsDBNull(dtcompanyrow("website")) Or (dtcompanyrow("website").Equals(String.Empty)) Then
                        dtcompanyrow("website") = ""
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

#End Region

End Class