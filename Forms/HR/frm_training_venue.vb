Public Class frm_training_venue

#Region " variable declaration "
    Dim bsTVenue As New BindingSource
    Private dtbTVenue As DataTable
    Dim dtrowTVenue As DataRow
    Dim ObjclsGen As New cls_General
    Dim Objhr As New cls_hr
    Dim strQry As String
#End Region

#Region "Constructors"
    Public Sub New()
        InitializeComponent()
        dtbTVenue = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region " Events "

    Private Sub frm_training_venue_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        bsTVenue.EndEdit()
        Try
            If dtbTVenue.GetChanges IsNot Nothing Then
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

    Private Sub frm_training_venue_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        populateTVenuedata()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If pnl_training_venue.Enabled Then
                If validateTVenueData() Then
                    If Objhr.saveTVenuedata(masterform.con, dtbTVenue) Then
                        pnl_training_venue.Enabled = False
                        MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                        pnl_training_venue.Enabled = True
                        populateTVenuedata()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        pnl_training_venue.Enabled = True
        txtvenuenm.Focus()
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        pnl_training_venue.Enabled = False
        If Not populateTVenuedata() Then
            MsgBox("Record not found...", MsgBoxStyle.Information, "Record not found")
        End If
    End Sub

    Private Sub txtvenuefind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvenuefind.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                pnl_training_venue.Enabled = False
                If Not populateTVenuedata() Then
                    pnl_training_venue.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

#End Region

#Region " Functions/Procedures "

    Public Function populateTVenuedata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            If Not ClearBinding() Then
                Exit Try
            End If
            masterform.con.Close()
            masterform.con.Open()
            If txtvenuefind.Text = String.Empty Then
                strQry = "SELECT * FROM tbl_training_venue ORDER BY name"
            Else
                strQry = "SELECT * FROM tbl_training_venue  WHERE  Lower(name) LIKE '" & txtvenuefind.Text.Trim.ToLower & "' "
                txtvenuefind.Text = "%"
            End If
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbTVenue) Then
                pnl_training_venue.Enabled = False
                dbReturn = False
            End If
            bsTVenue.DataSource = dtbTVenue
            bnvtrainingvenue.BindingSource = bsTVenue
            If disp_record() Then
                If dtbTVenue.Rows.Count > 0 Then
                    pnl_training_venue.Enabled = True
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
            dtbTVenue.Columns("availability").DefaultValue = 0
            txtvenuenm.DataBindings.Clear()
            txtadd.DataBindings.Clear()
            txtcity.DataBindings.Clear()
            txtpincode.DataBindings.Clear()
            txtcapacity.DataBindings.Clear()
            txtcost.DataBindings.Clear()
            chkavailable.DataBindings.Clear()
            DateTimePickerfromdate.DataBindings.Clear()
            DateTimePickertodate.DataBindings.Clear()

            txtvenuenm.DataBindings.Add("TEXT", bsTVenue, "name")
            txtadd.DataBindings.Add("TEXT", bsTVenue, "address")
            txtcity.DataBindings.Add("TEXT", bsTVenue, "city")
            txtpincode.DataBindings.Add("TEXT", bsTVenue, "pincode")
            txtcapacity.DataBindings.Add("TEXT", bsTVenue, "capacity")
            txtcost.DataBindings.Add("TEXT", bsTVenue, "cost")
            chkavailable.DataBindings.Add("CHECKED", bsTVenue, "availability", True)
            DateTimePickerfromdate.DataBindings.Add("TEXT", bsTVenue, "from_date")
            DateTimePickertodate.DataBindings.Add("TEXT", bsTVenue, "to_date")

            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function ClearBinding() As Boolean
        Dim dbReturn As Boolean = False
        Try
            ClearAllData()
            If dtbTVenue.Columns.Count > 0 Then
                txtvenuenm.DataBindings.Clear()
                txtadd.DataBindings.Clear()
                txtcity.DataBindings.Clear()
                txtpincode.DataBindings.Clear()
                txtcapacity.DataBindings.Clear()
                txtcost.DataBindings.Clear()
                chkavailable.DataBindings.Clear()
                DateTimePickerfromdate.DataBindings.Clear()
                DateTimePickertodate.DataBindings.Clear()
            End If
            dtbTVenue = Nothing
            dtbTVenue = New DataTable
            bsTVenue = Nothing
            bsTVenue = New BindingSource
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Sub ClearAllData()
        txtvenuenm.Text = ""
        txtadd.Text = ""
        txtcity.Text = ""
        txtcapacity.Text = ""
        txtcost.Text = ""
        txtpincode.Text = ""
        chkavailable.Checked = False
        DateTimePickerfromdate.Text = ""
        DateTimePickertodate.Text = ""
    End Sub

    Private Function validateTVenueData() As Boolean
        Dim dbReturn As Boolean = True
        bsTVenue.EndEdit()
        Try
            For Each dtrowTVenue In dtbTVenue.Rows
                If dtrowTVenue.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtrowTVenue("name")) Or (dtrowTVenue("name").Equals(String.Empty)) Then
                        MsgBox("Must enter Venue Name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtvenuenm.Focus()
                    End If
                    If IsDBNull(dtrowTVenue("address")) Or (dtrowTVenue("address").Equals(String.Empty)) Then
                        MsgBox("Must enter Address", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtadd.Focus()
                    End If
                    If IsDBNull(dtrowTVenue("city")) Or (dtrowTVenue("city").Equals(String.Empty)) Then
                        MsgBox("Must enter City", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcity.Focus()
                    End If
                    If IsDBNull(dtrowTVenue("capacity")) Or (dtrowTVenue("capacity").Equals(String.Empty)) Then
                        MsgBox("Must enter Capacity", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcapacity.Focus()
                    End If
                    If IsDBNull(dtrowTVenue("cost")) Or (dtrowTVenue("cost").Equals(String.Empty)) Then
                        MsgBox("Must enter Cost", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcost.Focus()
                    End If
                    If IsDBNull(dtrowTVenue("availability")) Or (dtrowTVenue("availability").Equals(String.Empty)) Then
                        MsgBox("Must Enter Availability of venue", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        chkavailable.Focus()
                    End If
                    If IsDBNull(dtrowTVenue("from_date")) Or (dtrowTVenue("from_date").Equals(String.Empty)) Then
                        MsgBox("Must enter From Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        DateTimePickerfromdate.Focus()
                    End If
                    If IsDBNull(dtrowTVenue("to_date")) Or (dtrowTVenue("to_date").Equals(String.Empty)) Then
                        MsgBox("Must Enter To Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        DateTimePickertodate.Focus()
                    ElseIf dtrowTVenue("to_date") < dtrowTVenue("from_date") Then
                        MsgBox("To Date must be greater than From Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                    End If
                    If IsDBNull(dtrowTVenue("pincode")) Or (dtrowTVenue("pincode").Equals(String.Empty)) Then
                        dtrowTVenue("pincode") = ""
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