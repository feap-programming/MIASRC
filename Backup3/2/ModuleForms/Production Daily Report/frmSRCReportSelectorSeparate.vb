Public Class FrmSRCReportSelectorSeparate
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        globalVariables.SRCReportSeparate = ddType.Text
        FrmSRCDailyReportViewer.Show()
    End Sub

    Private Sub FrmSRCReportSelectorSeparate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
