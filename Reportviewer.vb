Public Class Reportviewer

#Region " Variable Declaration "
    Private dtbReport As New DataTable
    Private SQLstr As String
    Private strRptName As String
    Dim dtb As New DataTable
    Dim obj As New cls_General
#End Region

#Region " Constructors "

    Public Sub New(ByVal strreportname As String)
        InitializeComponent()
        strRptName = strreportname
    End Sub

    Public Sub New(ByVal strreportname As String, ByVal strsql As String)
        InitializeComponent()
        strRptName = strreportname
        SQLstr = strsql
    End Sub

    Public Sub New(ByVal strreportname As String, ByVal dtb As DataTable)
        InitializeComponent()
        strRptName = strreportname
        dtbReport = dtb
    End Sub
#End Region

#Region " Event "

    Private Sub Reportviewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If strRptName = "company" Then
        '    Dim rptnew As New rptCompany
        '    If Not strRptName = String.Empty Then
        '        obj.Getdata(masterform.con, "select * from tbl_company where company_id = 80 ", dtbReport)
        '    End If
        '    rptnew.SetDataSource(dtbReport)
        '    Me.reportview.ReportSource = rptnew

        If strRptName = "department" Then
            Dim rptnew As New rptlocwisedept
            rptnew.SetDataSource(dtbReport)
            Me.reportview.ReportSource = rptnew

        ElseIf strRptName = "active_employees" Then
            Dim rptnew As New rptlocwiseactive_emp
            rptnew.SetDataSource(dtbReport)
            Me.reportview.ReportSource = rptnew

        ElseIf strRptName = "inactive_employees" Then
            Dim rptnew As New rptlocwiseinactive_emp
            rptnew.SetDataSource(dtbReport)
            Me.reportview.ReportSource = rptnew

        ElseIf strRptName = "period" Then
            Dim rptnew As New rptperiod
            rptnew.SetDataSource(dtbReport)
            Me.reportview.ReportSource = rptnew

       
        ElseIf strRptName = "finalsalary" Then
            Dim rptnew As New rptfinalsalary
            rptnew.SetDataSource(dtbReport)
            Me.reportview.ReportSource = rptnew

        ElseIf strRptName = "Salary" Then
            Dim rptnew As New rptsalary
            rptnew.SetDataSource(dtbReport)
            Me.reportview.ReportSource = rptnew

       
        ElseIf strRptName = "Workschedule" Then
            Dim rptnew As New rptperiod
            rptnew.SetDataSource(dtbReport)
            Me.reportview.ReportSource = rptnew

        End If
    End Sub

#End Region

End Class