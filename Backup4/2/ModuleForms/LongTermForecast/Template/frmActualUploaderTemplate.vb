Imports FEAPNS.DataAccess

Public Class FrmActualUploaderTemplate
    Private Sub FrmActualUploaderTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvActual.ReportEngineConnection = report.Connection
        Me.rvActual.ReportSource = report.GenerateReport("MIA/rptActualUploaderTemplate")

        ' ---------- End Report Server Connection ----------

        Me.rvActual.RefreshReport()

        Me.rvActual.ZoomPercent = 100

        Me.rvActual.RefreshReport()

    End Sub
End Class
