Public Class frm_professiontax


#Region " variable declaration "
    Dim bsPT As New BindingSource
    Private dtbPT As DataTable
    Dim dtrowPT As DataRow
    Dim ObjclsGen As New cls_General
    Dim strQry As String
#End Region

#Region "Constructors"
    Public Sub New()
        InitializeComponent()
        dtbPT = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_professiontax_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bsPT.EndEdit()
        Try
            If dtbPT.GetChanges IsNot Nothing Then
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

    Private Sub frm_professiontax_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            populatePTData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.Click
        pnl_pt.Enabled = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_pt.Enabled Then
                If validatePTData() Then
                    If ObjclsGen.SavePTdetail(masterform.con, dtbPT) Then
                        pnl_pt.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_pt.Enabled = True
                        populatePTData()
                    End If
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
            txtptamt.DataBindings.Clear()
            txtdesc.DataBindings.Clear()
            txtlowerrng.DataBindings.Clear()
            txtUcaserng.DataBindings.Clear()
            txtfrommonth.DataBindings.Clear()
            txttomonth.DataBindings.Clear()
            cmbfinyear.DataBindings.Clear()

            txtptamt.DataBindings.Add("TEXT", bsPT, "pt_amt")
            txtdesc.DataBindings.Add("TEXT", bsPT, "description")
            txtlowerrng.DataBindings.Add("TEXT", bsPT, "lower_rng")
            txtUcaserng.DataBindings.Add("TEXT", bsPT, "Ucase_rng")
            txtfrommonth.DataBindings.Add("TEXT", bsPT, "from_month")
            txttomonth.DataBindings.Add("TEXT", bsPT, "to_month")
            cmbfinyear.DataBindings.Add("TEXT", bsPT, "fin_year")

            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function populatePTData() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbPT = New DataTable
            masterform.con.Close()
            masterform.con.Open()
            strQry = "SELECT * FROM tbl_professiontax ORDER BY pt_id"
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbPT) Then
                pnl_pt.Enabled = False
                dbReturn = False
            End If
            bsPT.DataSource = dtbPT
            bnvprofessiontax.BindingSource = bsPT
            If disp_record() Then
                If dtbPT.Rows.Count > 0 Then
                    pnl_pt.Enabled = True
                    dbReturn = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        masterform.con.Close()
        Return dbReturn
    End Function

    Private Function validatePTData() As Boolean
        Dim dbreturn As Boolean = True
        bsPT.EndEdit()
        Try
            For Each dtrowPT In dtbPT.Rows
                If dtrowPT.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowPT("pt_amt")) Then 'Or (dtrowPT("pt_amt").Equals(String.Empty)) Then
                        MsgBox("Must Enter PT Amount", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtptamt.Focus()
                    End If
                    If IsDBNull(dtrowPT("description")) Or (dtrowPT("description").Equals(String.Empty)) Then
                        MsgBox("Must enter Description", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtdesc.Focus()
                    End If
                    If IsDBNull(dtrowPT("lower_rng")) Then 'Or (dtrowPT("address").Equals(String.Empty)) Then
                        MsgBox("Must enter Lower Range", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtlowerrng.Focus()
                    End If
                    If IsDBNull(dtrowPT("Ucase_rng")) Then ' Or (dtrowPT("city").Equals(String.Empty)) Then
                        MsgBox("Must enter Ucase Range", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtUcaserng.Focus()
                    End If
                    If IsDBNull(dtrowPT("from_month")) Then ' Or (dtrowPT("pincode").Equals(String.Empty)) Then
                        MsgBox("Must enter From Month", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txtfrommonth.Focus()
                    End If
                    If IsDBNull(dtrowPT("to_month")) Then 'Or (dtrowPT("contact_person").Equals(String.Empty)) Then
                        MsgBox("Must enter To Month", MsgBoxStyle.Information, Me.Text)
                        dbreturn = False
                        txttomonth.Focus()
                    End If
                    If IsDBNull(dtrowPT("fin_year")) Or (dtrowPT("fin_year").Equals(String.Empty)) Then
                        dtrowPT("fin_year") = ""
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