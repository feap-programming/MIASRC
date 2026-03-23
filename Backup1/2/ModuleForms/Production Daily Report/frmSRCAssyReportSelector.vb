Public Class FrmSRCAssyReportSelector
    Private Sub FrmSRCAssyReportSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        globalVariables.SRCReportType = "Daily Report Shift"
        FrmSRCReportSelectorSeparate.Show()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        globalVariables.SRCReportType = "Daily Report Date"
        FrmSRCReportSelectorSeparate.Show()
    End Sub
End Class
