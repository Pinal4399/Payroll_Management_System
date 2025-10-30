Public Class frm_bank

   
#Region " variable declaration "
    Dim bsbank As New BindingSource
    Private dtbbank As DataTable
    Dim dtrowbank As DataRow
    Dim ObjclsGen As New cls_General
    Dim strQry As String
#End Region

#Region "Constructors"
    Public Sub New()
        InitializeComponent()
        dtbbank = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_bank_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bsbank.EndEdit()
        Try
            If dtbbank.GetChanges IsNot Nothing Then
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

    Private Sub frm_bank_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            populateBankData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.Click
        pnl_bank.Enabled = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_bank.Enabled Then
                If validateBankData() Then
                    If ObjclsGen.saveBankData(masterform.con, dtbbank) Then
                        pnl_bank.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_bank.Enabled = True
                        populateBankData()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        pnl_bank.Enabled = False
        If Not populateBankData() Then
            MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
        End If
    End Sub

    Private Sub txtbanknamefind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbanknamefind.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                pnl_bank.Enabled = False
                If Not populateBankData() Then
                    pnl_bank.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

#End Region

#Region " Functions/Procedures "


    Private Function disp_record() As Boolean
        Dim dbReturn As Boolean = False
        Try
            txtbankcode.DataBindings.Clear()
            txtbanknm.DataBindings.Clear()
            txtadd.DataBindings.Clear()
            txtcity.DataBindings.Clear()
            txtpincode.DataBindings.Clear()
            txtcontactperson.DataBindings.Clear()
            txtdesignation.DataBindings.Clear()
            txtphoneno.DataBindings.Clear()
            txtfaxno.DataBindings.Clear()

            txtbankcode.DataBindings.Add("TEXT", bsbank, "code")
            txtbanknm.DataBindings.Add("TEXT", bsbank, "bank_name")
            txtadd.DataBindings.Add("TEXT", bsbank, "address")
            txtcity.DataBindings.Add("TEXT", bsbank, "city")
            txtpincode.DataBindings.Add("TEXT", bsbank, "pincode")
            txtcontactperson.DataBindings.Add("TEXT", bsbank, "contact_person")
            txtdesignation.DataBindings.Add("TEXT", bsbank, "designation")
            txtphoneno.DataBindings.Add("TEXT", bsbank, "phone_no")
            txtfaxno.DataBindings.Add("TEXT", bsbank, "fax_no")
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function populateBankData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            If Not ClearBinding() Then
                Exit Try
            End If
            dtbbank = New DataTable
            masterform.con.Close()
            masterform.con.Open()
            strQry = "SELECT * FROM tbl_bank WHERE bank_name LIKE '" & txtbanknamefind.Text.Trim & "' "
            txtbanknamefind.Text = "%"
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbbank) Then
                pnl_bank.Enabled = False
                dbReturn = False
            End If
            bsbank.DataSource = dtbbank
            BindingNavigator1.BindingSource = bsbank
            If disp_record() Then
                If dtbbank.Rows.Count > 0 Then
                    pnl_bank.Enabled = True
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
            If dtbbank.Columns.Count > 0 Then
                txtbankcode.DataBindings.Clear()
                txtbanknm.DataBindings.Clear()
                txtadd.DataBindings.Clear()
                txtcity.DataBindings.Clear()
                txtpincode.DataBindings.Clear()
                txtcontactperson.DataBindings.Clear()
                txtdesignation.DataBindings.Clear()
                txtphoneno.DataBindings.Clear()
                txtfaxno.DataBindings.Clear()
            End If
            dtbbank = Nothing
            dtbbank = New DataTable
            bsbank = Nothing
            bsbank = New BindingSource

            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

        Return dbReturn
    End Function

    Private Sub ClearAllData()
        txtbankcode.Text = ""
        txtbanknm.Text = ""
        txtadd.Text = ""
        txtcity.Text = ""
        txtpincode.Text = ""
        txtcontactperson.Text = ""
        txtdesignation.Text = ""
        txtphoneno.Text = ""
        txtfaxno.Text = ""
    End Sub

    Private Function validateBankData() As Boolean
        Dim dbreturn As Boolean = True
        bsbank.EndEdit()
        Try
            For Each dtrowbank In dtbbank.Rows
                If dtrowbank.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowbank("code")) Or (dtrowbank("code").Equals(String.Empty)) Then
                        MsgBox("Must Enter Bank Code", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtbankcode.Focus()
                    End If
                    If IsDBNull(dtrowbank("bank_name")) Or (dtrowbank("bank_name").Equals(String.Empty)) Then
                        MsgBox("Must enter Bank Name", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtbanknm.Focus()
                    End If
                    If IsDBNull(dtrowbank("address")) Or (dtrowbank("address").Equals(String.Empty)) Then
                        dtrowbank("address") = ""
                    End If
                    If IsDBNull(dtrowbank("city")) Or (dtrowbank("city").Equals(String.Empty)) Then
                        dtrowbank("city") = ""
                    End If
                    If IsDBNull(dtrowbank("pincode")) Or (dtrowbank("pincode").Equals(String.Empty)) Then
                        dtrowbank("pincode") = ""
                    End If
                    If IsDBNull(dtrowbank("contact_person")) Or (dtrowbank("contact_person").Equals(String.Empty)) Then
                        dtrowbank("contact_person") = ""
                    End If
                    If IsDBNull(dtrowbank("designation")) Or (dtrowbank("designation").Equals(String.Empty)) Then
                        dtrowbank("designation") = ""
                    End If
                    If IsDBNull(dtrowbank("phone_no")) Or (dtrowbank("phone_no").Equals(String.Empty)) Then
                        dtrowbank("phone_no") = ""
                    End If
                    If IsDBNull(dtrowbank("fax_no")) Or (dtrowbank("fax_no").Equals(String.Empty)) Then
                        dtrowbank("fax_no") = ""
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbreturn
    End Function


#End Region

End Class