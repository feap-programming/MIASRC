Imports FEAPNS.DataAccess

Public Class FrmRptDemandComparison

    Private customer As String
    Private customerName As String
    Private date1 As Date
    Private date2 As Date

    Private Sub FrmRptDemandComparison_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        Me.rvDemandComparison.RefreshReport()
        Me.rvDemandComparison.ClearHistory()

        ' ---------- Report Server Connection ----------

        Me.rvDemandComparison.ReportSource = Nothing

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvDemandComparison.ReportEngineConnection = report.Connection
        report.AddReportParameters("par0Customer", Me.customer)
        report.AddReportParameters("par0CustomerName", Me.customerName)
        report.AddReportParameters("par0Date1", Me.date1)
        report.AddReportParameters("par0Date2", Me.date2)
        report.AddReportParameters("par1Customer", Me.customer)
        report.AddReportParameters("par1CustomerName", Me.customerName)
        report.AddReportParameters("par1Date1", Me.date1)
        report.AddReportParameters("par1Date2", Me.date2)
        report.AddReportParameters("par2Customer", Me.customer)
        report.AddReportParameters("par2CustomerName", Me.customerName)
        report.AddReportParameters("par2Date1", Me.date1)
        report.AddReportParameters("par2Date2", Me.date2)
        report.AddReportParameters("par3Customer", Me.customer)
        report.AddReportParameters("par3CustomerName", Me.customerName)
        report.AddReportParameters("par3Date1", Me.date1)
        report.AddReportParameters("par3Date2", Me.date2)
        report.AddReportParameters("par4Customer", Me.customer)
        report.AddReportParameters("par4CustomerName", Me.customerName)
        report.AddReportParameters("par4Date1", Me.date1)
        report.AddReportParameters("par4Date2", Me.date2)
        Me.rvDemandComparison.ReportSource = report.GenerateReport("MIA/rptBookDemandComparison")

        ' ---------- End Report Server Connection ----------

        Me.rvDemandComparison.ZoomPercent = 100

        Me.rvDemandComparison.RefreshReport()

    End Sub

    Private Sub btnFormView_Click(sender As Object, e As EventArgs) Handles btnFormView.Click

        Me.rvDemandComparison.RefreshReport()
        Me.rvDemandComparison.ClearHistory()

        ' ---------- Report Server Connection ----------

        Me.rvDemandComparison.ReportSource = Nothing

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvDemandComparison.ReportEngineConnection = report.Connection
        report.AddReportParameters("par0Customer", Me.customer)
        report.AddReportParameters("par0CustomerName", Me.customerName)
        report.AddReportParameters("par0Date1", Me.date1)
        report.AddReportParameters("par0Date2", Me.date2)
        Me.rvDemandComparison.ReportSource = report.GenerateReport("MIA/rptDemandComparison")

        ' ---------- End Report Server Connection ----------

        Me.rvDemandComparison.ZoomPercent = 100

        Me.rvDemandComparison.RefreshReport()

    End Sub

    Private Sub btnGraph1stMonth_Click(sender As Object, e As EventArgs) Handles btnGraph1stMonth.Click

        Me.rvDemandComparison.CancelRendering()
        Me.rvDemandComparison.ClearHistory()

        Me.rvDemandComparison.RefreshReport()

        ' ---------- Report Server Connection ----------

        Me.rvDemandComparison.ReportSource = Nothing

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvDemandComparison.ReportEngineConnection = report.Connection
        report.AddReportParameters("par1Customer", Me.customer)
        report.AddReportParameters("par1CustomerName", Me.customerName)
        report.AddReportParameters("par1Date1", Me.date1)
        report.AddReportParameters("par1Date2", Me.date2)
        Me.rvDemandComparison.ReportSource = report.GenerateReport("MIA/rptDemandComparison1stMonthGraph")

        ' ---------- End Report Server Connection ----------

        Me.rvDemandComparison.ZoomPercent = 100

        Me.rvDemandComparison.RefreshReport()

    End Sub

    Private Sub btnGraph2ndMonth_Click(sender As Object, e As EventArgs) Handles btnGraph2ndMonth.Click

        Me.rvDemandComparison.CancelRendering()
        Me.rvDemandComparison.ClearHistory()

        Me.rvDemandComparison.RefreshReport()

        ' ---------- Report Server Connection ----------

        Me.rvDemandComparison.ReportSource = Nothing

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvDemandComparison.ReportEngineConnection = report.Connection
        report.AddReportParameters("par2Customer", Me.customer)
        report.AddReportParameters("par2CustomerName", Me.customerName)
        report.AddReportParameters("par2Date1", Me.date1)
        report.AddReportParameters("par2Date2", Me.date2)
        Me.rvDemandComparison.ReportSource = report.GenerateReport("MIA/rptDemandComparison2ndMonthGraph")

        ' ---------- End Report Server Connection ----------

        Me.rvDemandComparison.ZoomPercent = 100

        Me.rvDemandComparison.RefreshReport()

    End Sub

    Private Sub btnGraph3rdMonth_Click(sender As Object, e As EventArgs) Handles btnGraph3rdMonth.Click

        Me.rvDemandComparison.CancelRendering()
        Me.rvDemandComparison.ClearHistory()

        Me.rvDemandComparison.RefreshReport()

        ' ---------- Report Server Connection ----------

        Me.rvDemandComparison.ReportSource = Nothing

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvDemandComparison.ReportEngineConnection = report.Connection
        report.AddReportParameters("par3Customer", Me.customer)
        report.AddReportParameters("par3CustomerName", Me.customerName)
        report.AddReportParameters("par3Date1", Me.date1)
        report.AddReportParameters("par3Date2", Me.date2)
        Me.rvDemandComparison.ReportSource = report.GenerateReport("MIA/rptDemandComparison3rdMonthGraph")

        ' ---------- End Report Server Connection ----------

        Me.rvDemandComparison.ZoomPercent = 100

        Me.rvDemandComparison.RefreshReport()

    End Sub

    Private Sub btnGraphTotal_Click(sender As Object, e As EventArgs) Handles btnGraphTotal.Click

        Me.rvDemandComparison.CancelRendering()
        Me.rvDemandComparison.ClearHistory()

        Me.rvDemandComparison.RefreshReport()

        ' ---------- Report Server Connection ----------

        Me.rvDemandComparison.ReportSource = Nothing

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvDemandComparison.ReportEngineConnection = report.Connection
        report.AddReportParameters("par4Customer", Me.customer)
        report.AddReportParameters("par4CustomerName", Me.customerName)
        report.AddReportParameters("par4Date1", Me.date1)
        report.AddReportParameters("par4Date2", Me.date2)
        Me.rvDemandComparison.ReportSource = report.GenerateReport("MIA/rptDemandComparisonTotalGraph")

        ' ---------- End Report Server Connection ----------

        Me.rvDemandComparison.ZoomPercent = 100

        Me.rvDemandComparison.RefreshReport()

    End Sub

    Public Overloads Sub Show(customer As String, customerName As String, date1 As Date, date2 As Date)
        Me.customer = customer
        Me.customerName = customerName
        Me.date1 = date1
        Me.date2 = date2
        Me.Show()
    End Sub

End Class
