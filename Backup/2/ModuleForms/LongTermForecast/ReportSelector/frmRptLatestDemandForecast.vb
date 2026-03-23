Imports FEAPNS.DataAccess

Public Class FrmRptLatestDemandForecast

    Private parCustomerID As UInteger = 0
    Private parYear As UInteger = 0

    Private Sub FrmRptLatestDemandForecast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvPurchaseOrder.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomerID", Me.parCustomerID)
        report.AddReportParameters("parYear", Me.parYear)
        Me.rvPurchaseOrder.ReportSource = report.GenerateReport("MIA/rptLatestDemandForecastPerYear")

        ' ---------- End Report Server Connection ----------

        Me.rvPurchaseOrder.RefreshReport()

        Me.rvPurchaseOrder.ZoomPercent = 100

        Me.rvPurchaseOrder.RefreshReport()

    End Sub

    Public Overloads Sub Show(parYear As UInteger, parCustomerID As UInteger)
        Me.parCustomerID = parCustomerID
        Me.parYear = parYear
        Me.Show()
    End Sub

End Class
