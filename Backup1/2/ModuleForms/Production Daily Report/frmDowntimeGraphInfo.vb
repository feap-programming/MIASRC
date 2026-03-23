Public Class FrmDowntimeGraphInfo
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        globalVariables.dateFrom = rdtDateFrom.Value
        globalVariables.dateTo = rdtDateTo.Value
        FrmSRCDailyReportViewer.Show()
    End Sub
End Class
