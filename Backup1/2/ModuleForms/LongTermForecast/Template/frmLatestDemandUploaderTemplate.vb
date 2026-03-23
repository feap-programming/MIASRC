Imports FEAPNS.DataAccess

Public Class frmLatestDemandUploaderTemplate
    Private Sub RptLatestDemandUploaderTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvLatestDemand.ReportEngineConnection = report.Connection
        Me.rvLatestDemand.ReportSource = report.GenerateReport("MIA/rptLatestDemandUploaderTemplate")

        ' ---------- End Report Server Connection ----------

        Me.rvLatestDemand.RefreshReport()

        Me.rvLatestDemand.ZoomPercent = 100

        Me.rvLatestDemand.RefreshReport()

    End Sub
End Class
