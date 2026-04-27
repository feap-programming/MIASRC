Public Class FrmDowntimeReportSelector
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        globalVariables.downtimeReportType = ddType.Text
        If ddType.Text = "STANDARD" Then
            'FrmSRCDailyReportViewer.Show()
            If globalVariables.currentUser("fldUserType") = "ADMINISTRATOR" AndAlso globalVariables.currentUser("fldModDailyReportSRC") = "RW" AndAlso globalVariables.reportSource = 0 Then
                FrmSRCDailyReportOfflineViewer.Show()
            Else
                FrmSRCDailyReportViewer.Show()
            End If
        Else
            FrmDowntimeGraphInfo.Show()
            Me.Close()
        End If

    End Sub

    Private Sub FrmDowntimeReportSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddType.SelectedIndex = 0
    End Sub
End Class
