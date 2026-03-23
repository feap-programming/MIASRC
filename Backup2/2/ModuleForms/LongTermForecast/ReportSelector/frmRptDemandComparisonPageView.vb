Imports FEAPNS.DataAccess

Public Class FrmRptDemandComparisonPageView

    Private customer As String
    Private customerName As String
    Private date1 As Date
    Private date2 As Date

    Private Sub FrmRptDemandComparisonPageView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)

        Me.rvFormView.ReportEngineConnection = report.Connection
        report.AddReportParameters("par0Customer", Me.customer)
        report.AddReportParameters("par0CustomerName", Me.customerName)
        report.AddReportParameters("par0Date1", Me.date1)
        report.AddReportParameters("par0Date2", Me.date2)
        Me.rvFormView.ReportSource = report.GenerateReport("MIA/rptDemandComparison")

        Me.rvFormView.ZoomPercent = 100
        Me.rvFormView.RefreshReport()

        Me.rvGraph1stMonth.ReportEngineConnection = report.Connection
        report.AddReportParameters("par1Customer", Me.customer)
        report.AddReportParameters("par1CustomerName", Me.customerName)
        report.AddReportParameters("par1Date1", Me.date1)
        report.AddReportParameters("par1Date2", Me.date2)
        Me.rvGraph1stMonth.ReportSource = report.GenerateReport("MIA/rptDemandComparison1stMonthGraph")

        Me.rvGraph1stMonth.ZoomPercent = 100
        Me.rvGraph1stMonth.RefreshReport()

        Me.rvGraph2ndMonth.ReportEngineConnection = report.Connection
        report.AddReportParameters("par2Customer", Me.customer)
        report.AddReportParameters("par2CustomerName", Me.customerName)
        report.AddReportParameters("par2Date1", Me.date1)
        report.AddReportParameters("par2Date2", Me.date2)
        Me.rvGraph2ndMonth.ReportSource = report.GenerateReport("MIA/rptDemandComparison2ndMonthGraph")

        Me.rvGraph2ndMonth.ZoomPercent = 100
        Me.rvGraph2ndMonth.RefreshReport()

        Me.rvGraph3rdMonth.ReportEngineConnection = report.Connection
        report.AddReportParameters("par3Customer", Me.customer)
        report.AddReportParameters("par3CustomerName", Me.customerName)
        report.AddReportParameters("par3Date1", Me.date1)
        report.AddReportParameters("par3Date2", Me.date2)
        Me.rvGraph3rdMonth.ReportSource = report.GenerateReport("MIA/rptDemandComparison3rdMonthGraph")

        Me.rvGraph3rdMonth.ZoomPercent = 100
        Me.rvGraph3rdMonth.RefreshReport()

        Me.rvGraphTotal.ReportEngineConnection = report.Connection
        report.AddReportParameters("par4Customer", Me.customer)
        report.AddReportParameters("par4CustomerName", Me.customerName)
        report.AddReportParameters("par4Date1", Me.date1)
        report.AddReportParameters("par4Date2", Me.date2)
        Me.rvGraphTotal.ReportSource = report.GenerateReport("MIA/rptDemandComparisonTotalGraph")

        Me.rvGraphTotal.ZoomPercent = 100
        Me.rvGraphTotal.RefreshReport()

        ' ---------- End Report Server Connection ----------

    End Sub

    Public Overloads Sub Show(_customer As String, _customerName As String, _date1 As Date, _date2 As Date)
        Me.customer = _customer
        Me.customerName = _customerName
        Me.date1 = _date1
        Me.date2 = _date2
        Me.Show()
    End Sub

End Class
