Imports FEAPNS.DataAccess

Public Class FrmRptLatestDemandCustPageView

    Private customer As String
    Private customerName As String
    Private date1 As Date
    Private date2 As Date

    Private Sub FrmRptLatestDemandCustPageView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)

        Me.rvFormView.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomer", Me.customer)
        report.AddReportParameters("parCustomerName", Me.customerName)
        report.AddReportParameters("parDateFrom", Me.date1)
        report.AddReportParameters("parDateTo", Me.date2)
        Me.rvFormView.ReportSource = report.GenerateReport("MIA/rptLatestDemand")

        Me.rvFormView.ZoomPercent = 100
        Me.rvFormView.RefreshReport()

        Me.rvGraph1stMonth.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomer", Me.customer)
        report.AddReportParameters("parCustomerName", Me.customerName)
        report.AddReportParameters("parDateFrom", Me.date1)
        report.AddReportParameters("parDateTo", Me.date2)
        Me.rvGraph1stMonth.ReportSource = report.GenerateReport("MIA/rptLatestDemand1stMonthGraph")

        Me.rvGraph1stMonth.ZoomPercent = 100
        Me.rvGraph1stMonth.RefreshReport()

        Me.rvGraph2ndMonth.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomer", Me.customer)
        report.AddReportParameters("parCustomerName", Me.customerName)
        report.AddReportParameters("parDateFrom", Me.date1)
        report.AddReportParameters("parDateTo", Me.date2)
        Me.rvGraph2ndMonth.ReportSource = report.GenerateReport("MIA/rptLatestDemand2ndMonthGraph")

        Me.rvGraph2ndMonth.ZoomPercent = 100
        Me.rvGraph2ndMonth.RefreshReport()

        Me.rvGraph3rdMonth.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomer", Me.customer)
        report.AddReportParameters("parCustomerName", Me.customerName)
        report.AddReportParameters("parDateFrom", Me.date1)
        report.AddReportParameters("parDateTo", Me.date2)
        Me.rvGraph3rdMonth.ReportSource = report.GenerateReport("MIA/rptLatestDemand3rdMonthGraph")

        Me.rvGraph3rdMonth.ZoomPercent = 100
        Me.rvGraph3rdMonth.RefreshReport()

        Me.rvGraphTotal.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomer", Me.customer)
        report.AddReportParameters("parCustomerName", Me.customerName)
        report.AddReportParameters("parDateFrom", Me.date1)
        report.AddReportParameters("parDateTo", Me.date2)
        Me.rvGraphTotal.ReportSource = report.GenerateReport("MIA/rptLatestDemandTotalGraph")

        Me.rvGraphTotal.ZoomPercent = 100
        Me.rvGraphTotal.RefreshReport()

        ' ---------- End Report Server Connection ----------

    End Sub

    Public Overloads Sub Show(customer As String, customerName As String, date1 As Date, date2 As Date)
        Me.customer = customer
        Me.customerName = customerName
        Me.date1 = date1
        Me.date2 = date2
        Me.Show()
    End Sub

End Class
