Imports FEAPNS.DataAccess

Public Class FrmRptForecastVsLatestDemand

    Private dateFrom As Date
    Private dateTo As Date

    Private Sub FrmRptForecastVsLatestDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvForecastVsLatestDemand.ReportEngineConnection = report.Connection
        report.AddReportParameters("parDateFromMonth", Me.dateFrom.Month)
        report.AddReportParameters("parDateFromYear", Me.dateFrom.Year)
        report.AddReportParameters("parDateToMonth", Me.dateTo.Month)
        report.AddReportParameters("parDateToYear", Me.dateTo.Year)
        Me.rvForecastVsLatestDemand.ReportSource = report.GenerateReport("MIA/rptForecastVsLDBook")

        ' ---------- End Report Server Connection ----------

        Me.rvForecastVsLatestDemand.RefreshReport()

        Me.rvForecastVsLatestDemand.ZoomPercent = 100

        Me.rvForecastVsLatestDemand.RefreshReport()

    End Sub

    Public Overloads Sub Show(dateFrom As Date, dateTo As Date)
        Me.dateFrom = dateFrom
        Me.dateTo = dateTo
        Me.Show()
    End Sub

End Class
