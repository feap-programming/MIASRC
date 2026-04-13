Public Class FrmSRCReportSelectorSeparate
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        globalVariables.SRCReportSeparate = ddType.Text
        If globalVariables.currentUser("fldUserType") = "ADMINISTRATOR" AndAlso globalVariables.currentUser("fldModDailyReportSRC") = "RW" AndAlso globalVariables.reportSource = 0 Then
            FrmSRCDailyReportOfflineViewer.Show()
        Else
            FrmSRCDailyReportViewer.Show()
        End If
    End Sub

    Private Sub FrmSRCReportSelectorSeparate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
