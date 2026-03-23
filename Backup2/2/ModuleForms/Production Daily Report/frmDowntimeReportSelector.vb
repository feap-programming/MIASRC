Public Class FrmDowntimeReportSelector
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        globalVariables.downtimeReportType = ddType.Text
        If ddType.Text = "STANDARD" Then
            FrmSRCDailyReportViewer.Show()
        Else
            FrmDowntimeGraphInfo.Show()
            Me.Close()
        End If

    End Sub
End Class
