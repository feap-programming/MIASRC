Public Class FrmMonthYearSelection

    Private Sub FrmMonthYearSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        Me.drpFromMonth.SelectedIndex = 0
        Me.drpToMonth.SelectedIndex = 11

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        reportType = 6

        Slipknot.addReportParameter("parYear", numYear.Value)
        Slipknot.addReportParameter("parFromMonth", Me.drpFromMonth.SelectedIndex + 1)
        Slipknot.addReportParameter("parToMonth", Me.drpToMonth.SelectedIndex + 1)

        Dim frm As New FrmReport
        frm.Show()
    End Sub

End Class