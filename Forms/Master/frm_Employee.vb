Imports System.Data.SqlClient


Public Class frm_employee

#Region " variable declaration "
    Dim bsEmployee As New BindingSource
    Private dtbEmployee, dtbDepartment, dtbLocation As DataTable
    Dim dtEmployeerow As DataRow
    Dim ObjclsGen As New cls_General
    Dim cmdempcode As New sqlCommand
    Dim drempcode As sqlDataReader
    Dim strQry As String
    Dim ismodify As Boolean = False
#End Region

    'Private Sub frm_employee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.Control And Keys.X And e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If

    'End Sub

#Region " Constructors "
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        dtbEmployee = New DataTable
        ObjclsGen.showMdi(Me)
    End Sub
#End Region

#Region "Events"

    Private Sub frm_employee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            masterform.con.Close()
            populateEmployeedata()
            btnfirst.Enabled = False
            btnprevious.Enabled = False
            btnnext.Enabled = False
            btnlast.Enabled = False
            btnadd.Enabled = False
            btndelete.Enabled = False
            btnsave.Enabled = True
            btnfind.Enabled = True

            Dim strQrylocname As String
            dtbLocation = New DataTable
            ObjclsGen.cmblocationname(dtbLocation, cmblocationname)

            dtbLocation = New DataTable
            strQrylocname = "SELECT bank_name FROM tbl_bank"
            If ObjclsGen.Getdata(masterform.con, strQrylocname, dtbLocation) Then
                With cmbbankname
                    .DataSource = dtbLocation
                    .DisplayMember = "bank_name"
                    .ValueMember = "bank_name"
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        btnsave.Text = "&Save"
        btnadd.Enabled = False
        btnfind.Enabled = False
        btnearning.Enabled = False
        btnfamilydeatils.Enabled = False
        btnqualification.Enabled = False
        btnemphistory.Enabled = False
        btnsave.Enabled = True
        btnfirst.Enabled = False
        btnprevious.Enabled = False
        btnnext.Enabled = False
        btnlast.Enabled = False
        btndelete.Enabled = False
        enableallcontrol(False)
        tabcontrol_empdetail.Enabled = True
        cmblocationname.Focus()
        bsEmployee.EndEdit()
        btnadd.Enabled = False
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            tabcontrol_empdetail.Enabled = True
            If tabcontrol_empdetail.Enabled Then
                If btnsave.Text = "&Edit" Then
                    enableallcontrol(False)
                    enablecontrol(False)
                    btnsave.Text = "&Save"
                    ismodify = True
                ElseIf btnsave.Text = "&Save" Then
                    If validateEmployeeData() Then
                        Dim employeecode As String = getempcode()
                        If ObjclsGen.saveEmployeedata(masterform.con, dtbEmployee, employeecode) Then
                            tabcontrol_empdetail.Enabled = False
                            MsgBox("Record saved successfully....", MsgBoxStyle.Information, "Save Data")
                            tabcontrol_empdetail.Enabled = True
                            enableallcontrol(True)
                            masterform.con.Close()
                            populateEmployeedata()
                            btnsave.Text = "&Edit"
                            enablecontrol(True)
                            ismodify = False
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        enableallcontrol(False)
        If Not populateEmployeedata() Then
            MsgBox("Record not found", MsgBoxStyle.Information, "Record not found")
        End If
    End Sub

    Private Sub txtempnamefind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtempnamefind.KeyDown
        findenter(e)
    End Sub

    Private Sub txtempcodefind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtempcodefind.KeyDown
        findenter(e)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        btnsave.Text = "&Save"
    End Sub

    Private Sub btnfamilydeatils_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfamilydeatils.Click
        If ObjclsGen.ShowForm("frm_emp_familydetail", Me) = False Then
            Dim obj As New frm_emp_familydetail(Me.cmblocationname.Text, Me.txtempcode.Text, Me.txtshortname.Text)
            obj.ShowDialog()
        End If
    End Sub

    Private Sub btnqualification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnqualification.Click
        If ObjclsGen.ShowForm("frm_emp_qualification", Me) = False Then
            Dim obj As New frm_Emp_Qualification(Me.cmblocationname.Text, Me.txtempcode.Text, Me.txtshortname.Text)
            obj.ShowDialog()
        End If
    End Sub

    Private Sub btnemphistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnemphistory.Click
        If ObjclsGen.ShowForm("frm_emp_history", Me) = False Then
            Dim obj As New frm_Emp_History(Me.cmblocationname.Text, Me.txtempcode.Text, Me.txtshortname.Text)
            obj.ShowDialog()
        End If
    End Sub

    Private Sub btnearning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnearning.Click
        If ObjclsGen.ShowForm("frm_Emp_Earning", Me) = False Then
            Dim obj As New frm_Emp_Earning(Me.cmblocationname.Text, Me.txtempcode.Text, Me.txtshortname.Text, Me.txtempsalary.Text)
            obj.ShowDialog()
        End If
    End Sub

    Private Sub cmblocationname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmblocationname.SelectedIndexChanged
        dtbDepartment = New DataTable
        ObjclsGen.cmbdeptname(dtbDepartment, cmbdepartmentnm, cmblocationname.Text)
    End Sub

    Private Sub txtfirstname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfirstname.Leave
        txtfirstname.Text = Ucase(Mid(txtfirstname.Text, 1, 1)) & Mid(txtfirstname.Text, 2)
        txtshortname.Text = txtfirstname.Text & " " & Mid(txtmiddlename.Text, 1, 1) & ". " & txtlastname.Text
    End Sub

    Private Sub txtmiddlename_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmiddlename.Leave
        txtmiddlename.Text = Ucase(Mid(txtmiddlename.Text, 1, 1)) & Mid(txtmiddlename.Text, 2)
        txtshortname.Text = txtfirstname.Text & " " & Mid(txtmiddlename.Text, 1, 1) & ". " & txtlastname.Text
    End Sub

    Private Sub txtlastname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlastname.Leave
        txtlastname.Text = Ucase(Mid(txtlastname.Text, 1, 1)) & Mid(txtlastname.Text, 2)
        txtshortname.Text = txtfirstname.Text & " " & Mid(txtmiddlename.Text, 1, 1) & ". " & txtlastname.Text
    End Sub

    Private Sub txtcurrenttelephno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcurrenttelephno.KeyPress
        If (Not (IsNumeric(e.KeyChar))) And (Not (Asc(e.KeyChar) = 32)) And (Not (e.KeyChar = "-")) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtpermnttelephno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpermnttelephno.KeyPress
        If (Not (IsNumeric(e.KeyChar))) And (Not (Asc(e.KeyChar) = 32)) And (Not (e.KeyChar = "-")) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtmobileno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmobileno.KeyPress
        If (Not (IsNumeric(e.KeyChar))) And (Not (Asc(e.KeyChar) = 32)) And (Not (e.KeyChar = "-")) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtpercentofdisabled_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpercentofdisabled.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not e.KeyChar = ".") Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtbirthdate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbirthdate.Leave
        Try
            If Not (IsDate(txtbirthdate.Text)) Then
                txtbirthdate.Text = ""
                txtempage.Text = ""
            Else
                Dim d1, d2, m1, m2, y1, y2 As Integer
                d1 = DatePart("d", txtbirthdate.Text)
                d2 = DatePart("d", Today)
                m1 = DatePart("m", txtbirthdate.Text)
                m2 = DatePart("m", Today)
                y1 = DatePart("yyyy", txtbirthdate.Text)
                y2 = DatePart("yyyy", Today)
                If d2 < d1 Then
                    m2 = m2 - 1
                    d2 = d2 + 30
                End If
                If m2 < m1 Then
                    y2 = y2 - 1
                    m2 = m2 + 12
                End If
                d2 = d2 - d1
                m2 = m2 - m1
                y2 = y2 - y1
                If y2 < 18 Then
                    MsgBox("Age must be Greater than 18 Year", MsgBoxStyle.Information, Me.Text)
                    txtbirthdate.Text = ""
                    txtempage.Text = ""
                    txtbirthdate.Focus()
                Else
                    txtempage.Text = y2 & "Y" & m2 & "M" & d2 & "D"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnsameaddresspass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsameaddresspass.Click
        txtpermanentadd.Text = txtcurrentadd.Text
        txtpermntcity.Text = txtcurrentcity.Text
        txtpermntstate.Text = txtcurrentstate.Text
        txtpermntpinno.Text = txtcurrentpinno.Text
        txtpermnttelephno.Text = txtcurrenttelephno.Text
    End Sub

    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        Try
            empphoto.Show()
            OpenFileDialog1.InitialDirectory = " D:"
            OpenFileDialog1.Filter = "image file|*.jpg"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                empphoto.Load(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        empphoto.ImageLocation = Nothing
    End Sub

#End Region

#Region " Functions/Procedures "

    Public Function getempcode() As String
        Dim finalecode, sortcode1, sortcode2, temp As Integer
        Dim empcode, existecode As String
        Try
            txtshortname.Text = txtfirstname.Text & " " & Mid(txtmiddlename.Text, 1, 1) & ". " & txtlastname.Text
            empcode = Ucase(Mid(txtfirstname.Text, 1, 1) & Mid(txtmiddlename.Text, 1, 1) & Mid(txtlastname.Text, 1, 1))
            masterform.con.Close()
            cmdempcode.Connection = masterform.con

            cmdempcode.CommandText = "SELECT employee_code FROM tbl_employee WHERE Lower(employee_code) LIKE '" & empcode.Trim.ToLower & "%" & "' ORDER BY employee_code"
            masterform.con.Open()
            drempcode = cmdempcode.ExecuteReader
            If drempcode.HasRows Then
                drempcode.Read()
                sortcode2 = Mid(drempcode.GetString(0), 4)
                drempcode.Close()
                drempcode = cmdempcode.ExecuteReader

                While drempcode.Read()
                    existecode = drempcode.GetString(0)
                    sortcode1 = Mid(drempcode.GetString(0), 4)
                    If sortcode2 <= sortcode1 Then
                        sortcode2 = sortcode1
                        sortcode1 = temp
                        temp = sortcode2
                    End If
                End While
                finalecode = temp + 1
                Select Case Len(finalecode.ToString)
                    Case 1
                        txtempcode.Text = empcode & "000" & finalecode
                    Case 2
                        txtempcode.Text = empcode & "00" & finalecode
                    Case 3
                        txtempcode.Text = empcode & "0" & finalecode
                    Case Else
                        txtempcode.Text = empcode & finalecode
                End Select
            Else
                txtempcode.Text = empcode & "0001"
            End If
            drempcode.Close()
            masterform.con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return Ucase(txtempcode.Text)
    End Function

    Private Function Employee_disp_record() As Boolean
        Dim dbReturn As Boolean = False
        Try
            dtbEmployee.Columns("emp_permanent").DefaultValue = 0
            dtbEmployee.Columns("emp_inactive").DefaultValue = 0
            dtbEmployee.Columns("criminal_litigation").DefaultValue = 0
            dtbEmployee.Columns("disabled").DefaultValue = 0
            dtbEmployee.Columns("emp_photo").DefaultValue = ""
            cmblocationname.DataBindings.Clear()
            cmbdepartmentnm.DataBindings.Clear()
            txtfirstname.DataBindings.Clear()
            txtmiddlename.DataBindings.Clear()
            txtlastname.DataBindings.Clear()
            txtshortname.DataBindings.Clear()
            cmbgender.DataBindings.Clear()
            cmbmartialstatus.DataBindings.Clear()
            txtjoiningdate.DataBindings.Clear()
            txtcondate.DataBindings.Clear()
            txtempsalary.DataBindings.Clear()
            txtempcode.DataBindings.Clear()
            chkpermanent.DataBindings.Clear()
            chkinactive.DataBindings.Clear()
            empphoto.DataBindings.Clear()
            txtcurrentadd.DataBindings.Clear()
            txtcurrentcity.DataBindings.Clear()
            txtcurrentstate.DataBindings.Clear()
            txtcurrenttelephno.DataBindings.Clear()
            txtcurrentpinno.DataBindings.Clear()
            txtpermanentadd.DataBindings.Clear()
            txtpermntcity.DataBindings.Clear()
            txtpermntstate.DataBindings.Clear()
            txtpermntpinno.DataBindings.Clear()
            txtpermnttelephno.DataBindings.Clear()
            txtmobileno.DataBindings.Clear()
            txtbirthdate.DataBindings.Clear()
            txtbirthplace.DataBindings.Clear()
            txtempage.DataBindings.Clear()
            txtnationality.DataBindings.Clear()
            txtemailadd.DataBindings.Clear()
            cmbpayrolltype.DataBindings.Clear()
            cmbbloodgroup.DataBindings.Clear()
            txtjobprofile.DataBindings.Clear()
            cmbempposition.DataBindings.Clear()
            chkcivil.DataBindings.Clear()
            txtlitigationdetail.DataBindings.Clear()
            txtrelieveddate.DataBindings.Clear()
            cmbleavereason.DataBindings.Clear()
            txtPANno.DataBindings.Clear()
            txtnoofchild.DataBindings.Clear()
            chkdisabled.DataBindings.Clear()
            txtpercentofdisabled.DataBindings.Clear()
            txtdisablednote.DataBindings.Clear()
            cmbbankname.DataBindings.Clear()
            txtbankacno.DataBindings.Clear()
            txtreference1.DataBindings.Clear()
            txtreference2.DataBindings.Clear()
            txtpassportno.DataBindings.Clear()
            txtdateofissue.DataBindings.Clear()
            txtplaceofissue.DataBindings.Clear()
            txtvalidtill.DataBindings.Clear()
            txtdrivinglicenseno.DataBindings.Clear()
            txtvehicleno.DataBindings.Clear()
            txtvehicletype.DataBindings.Clear()
            txtrationcardno.DataBindings.Clear()
            txthobbies.DataBindings.Clear()

            cmblocationname.DataBindings.Add("SelectedValue", bsEmployee, "location_id")
            cmbdepartmentnm.DataBindings.Add("SelectedValue", bsEmployee, "department_id")
            txtfirstname.DataBindings.Add("TEXT", bsEmployee, "first_name")
            txtmiddlename.DataBindings.Add("TEXT", bsEmployee, "middle_name")
            txtlastname.DataBindings.Add("TEXT", bsEmployee, "last_name")
            txtshortname.DataBindings.Add("TEXT", bsEmployee, "short_name")
            cmbgender.DataBindings.Add("TEXT", bsEmployee, "gender")
            cmbmartialstatus.DataBindings.Add("TEXT", bsEmployee, "marital_status")
            txtjoiningdate.DataBindings.Add("TEXT", bsEmployee, "joining_date")
            txtcondate.DataBindings.Add("TEXT", bsEmployee, "confirmation_date")
            txtempsalary.DataBindings.Add("TEXT", bsEmployee, "salary")
            txtempcode.DataBindings.Add("TEXT", bsEmployee, "employee_code")
            chkpermanent.DataBindings.Add("CHECKED", bsEmployee, "emp_permanent", True)
            chkinactive.DataBindings.Add("CHECKED", bsEmployee, "emp_inactive", True)
            empphoto.DataBindings.Add("IMAGELOCATION", bsEmployee, "emp_photo")
            txtcurrentadd.DataBindings.Add("TEXT", bsEmployee, "current_address")
            txtcurrentcity.DataBindings.Add("TEXT", bsEmployee, "current_city")
            txtcurrentstate.DataBindings.Add("TEXT", bsEmployee, "current_state")
            txtcurrenttelephno.DataBindings.Add("TEXT", bsEmployee, "current_phoneno")
            txtcurrentpinno.DataBindings.Add("TEXT", bsEmployee, "current_pinno")
            txtpermanentadd.DataBindings.Add("TEXT", bsEmployee, "permanent_address")
            txtpermntcity.DataBindings.Add("TEXT", bsEmployee, "permanent_city")
            txtpermntstate.DataBindings.Add("TEXT", bsEmployee, "permanent_state")
            txtpermntpinno.DataBindings.Add("TEXT", bsEmployee, "permanent_pinno")
            txtpermnttelephno.DataBindings.Add("TEXT", bsEmployee, "permanent_phoneno")
            txtmobileno.DataBindings.Add("TEXT", bsEmployee, "mobile_no")
            txtbirthdate.DataBindings.Add("TEXT", bsEmployee, "birth_date")
            txtbirthplace.DataBindings.Add("TEXT", bsEmployee, "birth_place")
            txtempage.DataBindings.Add("TEXT", bsEmployee, "age")
            txtnationality.DataBindings.Add("TEXT", bsEmployee, "nationality")
            txtemailadd.DataBindings.Add("TEXT", bsEmployee, "email_address")
            cmbpayrolltype.DataBindings.Add("TEXT", bsEmployee, "payroll_type")
            cmbbloodgroup.DataBindings.Add("text", bsEmployee, "blood_group")
            txtjobprofile.DataBindings.Add("TEXT", bsEmployee, "job_profile")
            cmbempposition.DataBindings.Add("TEXT", bsEmployee, "emp_position")
            chkcivil.DataBindings.Add("CHECKED", bsEmployee, "criminal_litigation", True)
            txtlitigationdetail.DataBindings.Add("TEXT", bsEmployee, "litigation_detail")
            txtrelieveddate.DataBindings.Add("TEXT", bsEmployee, "relieved_date")
            cmbleavereason.DataBindings.Add("TEXT", bsEmployee, "leave_reason")
            txtPANno.DataBindings.Add("TEXT", bsEmployee, "pancard_no")
            txtnoofchild.DataBindings.Add("TEXT", bsEmployee, "no_of_children")
            chkdisabled.DataBindings.Add("CHECKED", bsEmployee, "disabled", True)
            txtpercentofdisabled.DataBindings.Add("TEXT", bsEmployee, "percent_of_disability")
            txtdisablednote.DataBindings.Add("TEXT", bsEmployee, "disability_note")
            cmbbankname.DataBindings.Add("SELECTEDVALUE", bsEmployee, "bank_name")
            txtbankacno.DataBindings.Add("TEXT", bsEmployee, "bank_ac_no")
            txtreference1.DataBindings.Add("TEXT", bsEmployee, "reference1")
            txtreference2.DataBindings.Add("TEXT", bsEmployee, "reference2")
            txtpassportno.DataBindings.Add("TEXT", bsEmployee, "passport_no")
            txtdateofissue.DataBindings.Add("TEXT", bsEmployee, "issue_date")
            txtplaceofissue.DataBindings.Add("TEXT", bsEmployee, "issue_place")
            txtvalidtill.DataBindings.Add("TEXT", bsEmployee, "valid_till")
            txtdrivinglicenseno.DataBindings.Add("TEXT", bsEmployee, "drv_license_no")
            txtvehicleno.DataBindings.Add("TEXT", bsEmployee, "vehicle_no")
            txtvehicletype.DataBindings.Add("TEXT", bsEmployee, "vehicle_type")
            txtrationcardno.DataBindings.Add("TEXT", bsEmployee, "rationcard_no")
            txthobbies.DataBindings.Add("TEXT", bsEmployee, "hobbies")
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function populateEmployeedata() As Boolean
        Dim dbReturn As Boolean = False
        Try
            'If Not ClearBinding() Then
            '    Exit Try
            'End If
            masterform.con.Close()
            masterform.con.Open()
            dtbEmployee = New DataTable
            strQry = "SELECT * FROM tbl_employee WHERE  Lower(short_name) LIKE '" & txtempnamefind.Text.Trim.ToLower & "' AND Lower(employee_code) LIKE '" & txtempcodefind.Text.Trim.ToLower & "'"
            If Not ObjclsGen.Getdata(masterform.con, strQry, dtbEmployee) Then
                tabcontrol_empdetail.Enabled = False
                btnfamilydeatils.Enabled = False
                btnqualification.Enabled = False
                btnemphistory.Enabled = False
                dbReturn = False
            End If
            bsEmployee.DataSource = dtbEmployee
            BindingNavigator1.BindingSource = bsEmployee
            If Employee_disp_record() Then
                If dtbEmployee.Rows.Count > 0 Then
                    enableallcontrol(True)
                    btnsave.Enabled = True
                    btnfamilydeatils.Enabled = True
                    btnqualification.Enabled = True
                    btnemphistory.Enabled = True
                    dbReturn = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Function ClearBinding() As Boolean
        Dim dbReturn As Boolean = False
        Try
            ClearAllData()
            dtbEmployee = New DataTable
            If dtbEmployee.Columns.Count > 0 Then
                cmblocationname.DataBindings.Clear()
                cmbdepartmentnm.DataBindings.Clear()
                txtfirstname.DataBindings.Clear()
                txtmiddlename.DataBindings.Clear()
                txtlastname.DataBindings.Clear()
                txtshortname.DataBindings.Clear()
                cmbgender.DataBindings.Clear()
                cmbmartialstatus.DataBindings.Clear()
                txtjoiningdate.DataBindings.Clear()
                txtcondate.DataBindings.Clear()
                txtempsalary.DataBindings.Clear()
                txtempcode.DataBindings.Clear()
                chkpermanent.DataBindings.Clear()
                chkinactive.DataBindings.Clear()
                empphoto.DataBindings.Clear()
                txtcurrentadd.DataBindings.Clear()
                txtcurrentcity.DataBindings.Clear()
                txtcurrentstate.DataBindings.Clear()
                txtcurrenttelephno.DataBindings.Clear()
                txtcurrentpinno.DataBindings.Clear()
                txtpermanentadd.DataBindings.Clear()
                txtpermntcity.DataBindings.Clear()
                txtpermntstate.DataBindings.Clear()
                txtpermntpinno.DataBindings.Clear()
                txtpermnttelephno.DataBindings.Clear()
                txtmobileno.DataBindings.Clear()
                txtbirthdate.DataBindings.Clear()
                txtbirthplace.DataBindings.Clear()
                txtempage.DataBindings.Clear()
                txtnationality.DataBindings.Clear()
                txtemailadd.DataBindings.Clear()
                cmbpayrolltype.DataBindings.Clear()
                cmbbloodgroup.DataBindings.Clear()
                txtjobprofile.DataBindings.Clear()
                cmbempposition.DataBindings.Clear()
                chkcivil.DataBindings.Clear()
                txtlitigationdetail.DataBindings.Clear()
                txtrelieveddate.DataBindings.Clear()
                cmbleavereason.DataBindings.Clear()
                txtPANno.DataBindings.Clear()
                txtnoofchild.DataBindings.Clear()
                chkdisabled.DataBindings.Clear()
                txtpercentofdisabled.DataBindings.Clear()
                txtdisablednote.DataBindings.Clear()
                cmbbankname.DataBindings.Clear()
                txtbankacno.DataBindings.Clear()
                txtreference1.DataBindings.Clear()
                txtreference2.DataBindings.Clear()
                txtpassportno.DataBindings.Clear()
                txtdateofissue.DataBindings.Clear()
                txtplaceofissue.DataBindings.Clear()
                txtvalidtill.DataBindings.Clear()
                txtdrivinglicenseno.DataBindings.Clear()
                txtvehicleno.DataBindings.Clear()
                txtvehicletype.DataBindings.Clear()
                txtrationcardno.DataBindings.Clear()
                txthobbies.DataBindings.Clear()
            End If
            dtbEmployee = Nothing
            dtbEmployee = New DataTable
            bsEmployee = Nothing
            bsEmployee = New BindingSource
            dbReturn = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
        Return dbReturn
    End Function

    Private Sub ClearAllData()
        chkpermanent.Checked = False
        chkinactive.Checked = False
        chkcivil.Checked = False
        chkdisabled.Checked = False
        cmblocationname.Text = ""
        cmbdepartmentnm.Text = ""
        txtfirstname.Text = ""
        txtmiddlename.Text = ""
        txtlastname.Text = ""
        txtshortname.Text = ""
        cmbgender.Text = ""
        cmbmartialstatus.Text = ""
        empphoto.ImageLocation = Nothing
        txtjoiningdate.Text = ""
        txtcondate.Text = ""
        txtempsalary.Text = ""
        txtempcode.Text = ""
        txtcurrentadd.Text = ""
        txtcurrentcity.Text = ""
        txtcurrentstate.Text = ""
        txtcurrenttelephno.Text = ""
        txtcurrentpinno.Text = ""
        txtpermanentadd.Text = ""
        txtpermntcity.Text = ""
        txtpermntstate.Text = ""
        txtpermntpinno.Text = ""
        txtpermnttelephno.Text = ""
        txtmobileno.Text = ""
        txtbirthdate.Text = ""
        txtbirthplace.Text = ""
        txtempage.Text = ""
        txtnationality.Text = ""
        txtemailadd.Text = ""
        cmbpayrolltype.Text = ""
        cmbbloodgroup.Text = ""
        txtjobprofile.Text = ""
        cmbempposition.Text = ""
        txtlitigationdetail.Text = ""
        txtrelieveddate.Text = ""
        cmbleavereason.Text = ""
        txtPANno.Text = ""
        txtnoofchild.Text = ""
        txtpercentofdisabled.Text = ""
        txtdisablednote.Text = ""
        cmbbankname.Text = ""
        txtbankacno.Text = ""
        txtreference1.Text = ""
        txtreference2.Text = ""
        txtpassportno.Text = ""
        txtdateofissue.Text = ""
        txtplaceofissue.Text = ""
        txtvalidtill.Text = ""
        txtdrivinglicenseno.Text = ""
        txtvehicleno.Text = ""
        txtvehicletype.Text = ""
        txtrationcardno.Text = ""
        txthobbies.Text = ""
    End Sub

    Private Function validateEmployeeData() As Boolean
        Dim dbReturn As Boolean = True
        bsEmployee.EndEdit()
        Try
            For Each dtEmployeerow In dtbEmployee.Rows
                If dtEmployeerow.RowState <> DataRowState.Deleted Then
                    If IsDBNull(dtEmployeerow("location_id")) Or (dtEmployeerow("location_id").Equals(String.Empty)) Then
                        MsgBox("Select location name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        cmblocationname.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("department_id")) Or (dtEmployeerow("department_id").Equals(String.Empty)) Then
                        MsgBox("Select department name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        cmbdepartmentnm.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("gender")) Or (dtEmployeerow("gender").Equals(String.Empty)) Then
                        MsgBox("Select Gender", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        cmbgender.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("marital_status")) Or (dtEmployeerow("marital_status").Equals(String.Empty)) Then
                        MsgBox("Select Marital Status", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        cmbmartialstatus.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("first_name")) Or (dtEmployeerow("first_name").Equals(String.Empty)) Then
                        MsgBox("Must enter first name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtfirstname.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("middle_name")) Or (dtEmployeerow("middle_name").Equals(String.Empty)) Then
                        MsgBox("Must enter middle name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtmiddlename.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("last_name")) Or (dtEmployeerow("last_name").Equals(String.Empty)) Then
                        MsgBox("Must Enter last name", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtlastname.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("joining_date")) Or (dtEmployeerow("joining_date").Equals(String.Empty)) Then
                        MsgBox("Must enter joining date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtjoiningdate.Focus()
                    End If
                    ' Dim d As Date = FormatDateTime(CDate(dtEmployeerow("joining_date")), DateFormat.GeneralDate)
                    'If Format(CDate(dtEmployeerow("joining_date")), "dd/MM/yyyy") > Format(Date.Today, "dd/MM/yyyy") Then
                    '    MsgBox("Joining Date should not be greater than today's Date", MsgBoxStyle.Information, Me.Text)
                    '    dbReturn = False
                    '    txtjoiningdate.Focus()
                    'End If
                    If dtEmployeerow("joining_date") > Today Then
                        MsgBox("Joining Date should not be greater than today's Date", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtjoiningdate.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("current_address")) Or (dtEmployeerow("current_address").Equals(String.Empty)) Then
                        MsgBox("Must enter curent address ", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcurrentadd.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("current_city")) Or (dtEmployeerow("current_city").Equals(String.Empty)) Then
                        MsgBox("Must Enter current city", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcurrentcity.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("current_state")) Or (dtEmployeerow("current_state").Equals(String.Empty)) Then
                        MsgBox("Must enter current state", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtcurrentstate.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("permanent_address")) Or (dtEmployeerow("permanent_address").Equals(String.Empty)) Then
                        MsgBox("Must enter permanent address", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtpermanentadd.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("permanent_city")) Or (dtEmployeerow("permanent_city").Equals(String.Empty)) Then
                        MsgBox("Must enter permanent city", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtpermntcity.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("permanent_state")) Or (dtEmployeerow("permanent_state").Equals(String.Empty)) Then
                        MsgBox("Must enter permanent state", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtpermntstate.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("nationality")) Or (dtEmployeerow("nationality").Equals(String.Empty)) Then
                        MsgBox("Must Enter nationality", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtnationality.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("salary")) Then
                        MsgBox("Must enter salary", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtempsalary.Focus()
                    ElseIf Val(dtEmployeerow("salary")) < 4200 Then
                        MsgBox("Salary Must be greater than 4200 Rs.", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtempsalary.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("emp_position")) Or (dtEmployeerow("emp_position").Equals(String.Empty)) Then
                        MsgBox("Select Employee position", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        cmbempposition.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("job_profile")) Or (dtEmployeerow("job_profile").Equals(String.Empty)) Then
                        MsgBox("Must Enter job profile", MsgBoxStyle.Information, Me.Text)
                        dbReturn = False
                        txtjobprofile.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("confirmation_date")) Or (dtEmployeerow("confirmation_date").Equals(String.Empty)) Then
                        dtEmployeerow("confirmation_date") = ""
                        'ElseIf (DateDiff(DateInterval.Month, CDate(dtEmployeerow("confirmation_date")), CDate(dtEmployeerow("joining_date")))) < 6 Then
                        '    MsgBox("Confirmation date should not be less than joining date", MsgBoxStyle.Critical, Me.Text)
                        '    dbReturn = False
                        '    txtcondate.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("current_phoneno")) Or (dtEmployeerow("current_phoneno").Equals(String.Empty)) Then
                        dtEmployeerow("current_phoneno") = ""
                    End If
                    If IsDBNull(dtEmployeerow("current_pinno")) Or (dtEmployeerow("current_pinno").Equals(String.Empty)) Then
                        dtEmployeerow("current_pinno") = ""
                    End If
                    If IsDBNull(dtEmployeerow("permanent_phoneno")) Or (dtEmployeerow("permanent_phoneno").Equals(String.Empty)) Then
                        dtEmployeerow("permanent_phoneno") = ""
                    End If
                    If IsDBNull(dtEmployeerow("permanent_pinno")) Or (dtEmployeerow("permanent_pinno").Equals(String.Empty)) Then
                        dtEmployeerow("permanent_pinno") = ""
                    End If
                    If IsDBNull(dtEmployeerow("mobile_no")) Or (dtEmployeerow("mobile_no").Equals(String.Empty)) Then
                        dtEmployeerow("mobile_no") = ""
                    End If
                    If IsDBNull(dtEmployeerow("birth_date")) Or (dtEmployeerow("birth_date").Equals(String.Empty)) Then
                        dtEmployeerow("birth_date") = ""
                    End If
                    If IsDBNull(dtEmployeerow("age")) Or (dtEmployeerow("age").Equals(String.Empty)) Then
                        dtEmployeerow("age") = ""
                    End If
                    If IsDBNull(dtEmployeerow("birth_place")) Or (dtEmployeerow("birth_place").Equals(String.Empty)) Then
                        dtEmployeerow("birth_place") = ""
                    End If

                    If IsDBNull(dtEmployeerow("email_address")) Or (dtEmployeerow("email_address").Equals(String.Empty)) Then
                        dtEmployeerow("email_address") = ""
                    End If
                    If dtEmployeerow("emp_inactive") = 0 Then
                        dtEmployeerow("relieved_date") = ""
                    ElseIf IsDBNull(dtEmployeerow("relieved_date")) Or (dtEmployeerow("relieved_date").Equals(String.Empty)) Then
                        MsgBox("Must Enter Relieved Date because Employee is InActive")
                        dbReturn = False
                    End If
                    If IsDBNull(dtEmployeerow("litigation_detail")) Or (dtEmployeerow("litigation_detail").Equals(String.Empty)) Then
                        dtEmployeerow("litigation_detail") = ""
                    End If

                    masterform.con.Close()
                    cmdempcode = New SqlCommand
                    cmdempcode.Connection = masterform.con
                    cmdempcode.CommandText = "SELECT earning_code FROM tbl_emp_earning WHERE Lower(employee_code) LIKE '" & dtEmployeerow("employee_code").ToString & "'"
                    masterform.con.Open()
                    drempcode = cmdempcode.ExecuteReader
                    If drempcode.HasRows Then
                        While drempcode.Read()
                            If txtempcode.Text = String.Empty Then
                            Else
                                If drempcode.GetString(0).ToString.Equals("BCQ") Then
                                    ' Dim str As String = dtEmployeerow("bank_ac_no")
                                    If IsDBNull(dtEmployeerow("bank_ac_no")) Or (dtEmployeerow("bank_ac_no").Equals(String.Empty)) Then
                                        MsgBox("Must enter Bank A/C No.", MsgBoxStyle.Information, Me.Text)
                                        dbReturn = False
                                    End If
                                    If IsDBNull(dtEmployeerow("bank_name")) Or (dtEmployeerow("bank_name").Equals(String.Empty)) Then
                                        MsgBox("Must enter Bank Name", MsgBoxStyle.Information, Me.Text)
                                        dbReturn = False
                                    End If
                                End If
                            End If
                        End While
                    End If
                    'If IsDBNull(dtEmployeerow("bank_ac_no")) Or (dtEmployeerow("bank_ac_no").Equals(String.Empty)) Then
                    '    dtEmployeerow("bank_ac_no") = ""
                    'End If
                    If IsDBNull(dtEmployeerow("reference1")) Or (dtEmployeerow("reference1").Equals(String.Empty)) Then
                        dtEmployeerow("reference1") = ""
                    End If
                    If IsDBNull(dtEmployeerow("blood_group")) Or (dtEmployeerow("blood_group").Equals(String.Empty)) Then
                        dtEmployeerow("blood_group") = ""
                    End If
                    If IsDBNull(dtEmployeerow("leave_reason")) Or (dtEmployeerow("leave_reason").Equals(String.Empty)) Then
                        dtEmployeerow("leave_reason") = ""
                    End If
                    If IsDBNull(dtEmployeerow("reference2")) Or (dtEmployeerow("reference2").Equals(String.Empty)) Then
                        dtEmployeerow("reference2") = ""
                    End If
                    If IsDBNull(dtEmployeerow("pancard_no")) Or (dtEmployeerow("pancard_no").Equals(String.Empty)) Then
                        dtEmployeerow("pancard_no") = ""
                    End If
                    If IsDBNull(dtEmployeerow("no_of_children")) Or (dtEmployeerow("no_of_children").Equals(String.Empty)) Then
                        dtEmployeerow("no_of_children") = ""
                    End If

                    If IsDBNull(dtEmployeerow("percent_of_disability")) Or (dtEmployeerow("percent_of_disability").Equals(String.Empty)) Then
                        dtEmployeerow("percent_of_disability") = ""
                    End If

                    If Val(dtEmployeerow("percent_of_disability")) > 100 Then
                        MsgBox("Must enter < 100 Percent")
                        dbReturn = False
                        txtpercentofdisabled.Focus()
                    End If
                    If IsDBNull(dtEmployeerow("disability_note")) Or (dtEmployeerow("disability_note").Equals(String.Empty)) Then
                        dtEmployeerow("disability_note") = ""
                    End If
                    If IsDBNull(dtEmployeerow("passport_no")) Or (dtEmployeerow("passport_no").Equals(String.Empty)) Then
                        dtEmployeerow("passport_no") = ""
                    End If
                    If IsDBNull(dtEmployeerow("issue_date")) Or (dtEmployeerow("issue_date").Equals(String.Empty)) Then
                        dtEmployeerow("issue_date") = ""
                    End If
                    If IsDBNull(dtEmployeerow("issue_place")) Or (dtEmployeerow("issue_place").Equals(String.Empty)) Then
                        dtEmployeerow("issue_place") = ""
                    End If

                    If IsDBNull(dtEmployeerow("valid_till")) Or (dtEmployeerow("valid_till").Equals(String.Empty)) Then
                        dtEmployeerow("valid_till") = ""
                    End If
                    If IsDBNull(dtEmployeerow("drv_license_no")) Or (dtEmployeerow("drv_license_no").Equals(String.Empty)) Then
                        dtEmployeerow("drv_license_no") = ""
                    End If
                    If IsDBNull(dtEmployeerow("vehicle_type")) Or (dtEmployeerow("vehicle_type").Equals(String.Empty)) Then
                        dtEmployeerow("vehicle_type") = ""
                    End If
                    If IsDBNull(dtEmployeerow("vehicle_no")) Or (dtEmployeerow("vehicle_no").Equals(String.Empty)) Then
                        dtEmployeerow("vehicle_no") = ""
                    End If
                    If IsDBNull(dtEmployeerow("rationcard_no")) Or (dtEmployeerow("rationcard_no").Equals(String.Empty)) Then
                        dtEmployeerow("rationcard_no") = ""
                    End If
                    If IsDBNull(dtEmployeerow("hobbies")) Or (dtEmployeerow("hobbies").Equals(String.Empty)) Then
                        dtEmployeerow("hobbies") = ""
                    End If
                End If
            Next
            Return dbReturn
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Function

    Private Sub enablecontrol(ByVal bln As Boolean)
        btnfirst.Enabled = bln
        btnprevious.Enabled = bln
        btnnext.Enabled = bln
        btnlast.Enabled = bln
        btnadd.Enabled = bln
        btndelete.Enabled = bln
        btnfind.Enabled = bln
        btnearning.Enabled = bln
        btnfamilydeatils.Enabled = bln
        btnqualification.Enabled = bln
        btnemphistory.Enabled = bln
    End Sub

    Private Sub findenter(ByVal e)
        Try
            If e.KeyCode = Keys.Enter Then
                enableallcontrol(False)
                If Not populateEmployeedata() Then
                    tabcontrol_empdetail.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub enableallcontrol(ByVal enl_dsl As Boolean)
        cmblocationname.Enabled = Not enl_dsl
        cmbdepartmentnm.Enabled = Not enl_dsl
        txtfirstname.ReadOnly = enl_dsl
        txtmiddlename.ReadOnly = enl_dsl
        txtlastname.ReadOnly = enl_dsl
        txtshortname.ReadOnly = enl_dsl
        cmbgender.Enabled = Not enl_dsl
        cmbmartialstatus.Enabled = Not enl_dsl
        txtjoiningdate.ReadOnly = enl_dsl
        txtcondate.ReadOnly = enl_dsl
        txtempsalary.ReadOnly = enl_dsl
        txtempcode.ReadOnly = enl_dsl
        chkpermanent.Enabled = Not enl_dsl
        chkinactive.Enabled = Not enl_dsl
        btnload.Enabled = Not enl_dsl
        btnclear.Enabled = Not enl_dsl
        btnsameaddresspass.Enabled = Not enl_dsl
        txtcurrentadd.ReadOnly = enl_dsl
        txtcurrentcity.ReadOnly = enl_dsl
        txtcurrentstate.ReadOnly = enl_dsl
        txtcurrenttelephno.ReadOnly = enl_dsl
        txtcurrentpinno.ReadOnly = enl_dsl
        txtpermanentadd.ReadOnly = enl_dsl
        txtpermntcity.ReadOnly = enl_dsl
        txtpermntstate.ReadOnly = enl_dsl
        txtpermntpinno.ReadOnly = enl_dsl
        txtpermnttelephno.ReadOnly = enl_dsl
        txtmobileno.ReadOnly = enl_dsl
        txtbirthdate.ReadOnly = enl_dsl
        txtbirthplace.ReadOnly = enl_dsl
        txtempage.ReadOnly = enl_dsl
        txtnationality.ReadOnly = enl_dsl
        txtemailadd.ReadOnly = enl_dsl
        cmbpayrolltype.Enabled = Not enl_dsl
        cmbbloodgroup.Enabled = Not enl_dsl
        txtjobprofile.ReadOnly = enl_dsl
        cmbempposition.Enabled = Not enl_dsl
        chkcivil.Enabled = Not enl_dsl
        txtlitigationdetail.ReadOnly = enl_dsl
        txtrelieveddate.ReadOnly = enl_dsl
        cmbleavereason.Enabled = Not enl_dsl
        txtPANno.ReadOnly = enl_dsl
        txtnoofchild.ReadOnly = enl_dsl
        chkdisabled.Enabled = Not enl_dsl
        txtpercentofdisabled.ReadOnly = enl_dsl
        txtdisablednote.ReadOnly = enl_dsl
        cmbbankname.Enabled = Not enl_dsl
        txtbankacno.ReadOnly = enl_dsl
        txtreference1.ReadOnly = enl_dsl
        txtreference2.ReadOnly = enl_dsl
        txtpassportno.ReadOnly = enl_dsl
        txtdateofissue.ReadOnly = enl_dsl
        txtplaceofissue.ReadOnly = enl_dsl
        txtvalidtill.ReadOnly = enl_dsl
        txtdrivinglicenseno.ReadOnly = enl_dsl
        txtvehicleno.ReadOnly = enl_dsl
        txtvehicletype.ReadOnly = enl_dsl
        txtrationcardno.ReadOnly = enl_dsl
        txthobbies.ReadOnly = enl_dsl
    End Sub
#End Region

End Class