Imports FEAPNS.DataAccess

Public Class FrmRptLatestDemandPerCustomer

    Private customer As String
    Private customerName As String
    Private dateFrom As Date
    Private dateTo As Date

    Private Sub FrmRptLatestDemandPerCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvLatestDemand.ReportEngineConnection = report.Connection
        report.AddReportParameters("par0Customer", Me.customer)
        report.AddReportParameters("par0CustomerName", Me.customerName)
        report.AddReportParameters("par0DateFrom", Me.dateFrom)
        report.AddReportParameters("par0DateTo", Me.dateTo)
        report.AddReportParameters("par1Customer", Me.customer)
        report.AddReportParameters("par1CustomerName", Me.customerName)
        report.AddReportParameters("par1DateFrom", Me.dateFrom)
        report.AddReportParameters("par1DateTo", Me.dateTo)
        report.AddReportParameters("par2Customer", Me.customer)
        report.AddReportParameters("par2CustomerName", Me.customerName)
        report.AddReportParameters("par2DateFrom", Me.dateFrom)
        report.AddReportParameters("par2DateTo", Me.dateTo)
        report.AddReportParameters("par3Customer", Me.customer)
        report.AddReportParameters("par3CustomerName", Me.customerName)
        report.AddReportParameters("par3DateFrom", Me.dateFrom)
        report.AddReportParameters("par3DateTo", Me.dateTo)
        report.AddReportParameters("par4Customer", Me.customer)
        report.AddReportParameters("par4CustomerName", Me.customerName)
        report.AddReportParameters("par4DateFrom", Me.dateFrom)
        report.AddReportParameters("par4DateTo", Me.dateTo)
        Me.rvLatestDemand.ReportSource = report.GenerateReport("MIA/rptBookLatestDemand")

        ' ---------- End Report Server Connection ----------

        Me.rvLatestDemand.RefreshReport()

        Me.rvLatestDemand.ZoomPercent = 100

        Me.rvLatestDemand.RefreshReport()

    End Sub

    Public Overloads Sub Show(customer As String, customerName As String, dateFrom As Date, dateTo As Date)
        Me.customer = customer
        Me.customerName = customerName
        Me.dateFrom = dateFrom
        Me.dateTo = dateTo
        Me.Show()
    End Sub

End Class
