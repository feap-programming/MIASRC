Imports System.Text.RegularExpressions

Public Class FrmCapacityPlanningPreview

    Private previewType As String

    Private Sub FrmCapacityPlanningPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)
        Me.numYear.Value = Year(Date.Today)
        Me.drpMonth.SelectedIndex = Me.drpMonth.FindStringExact(MonthName(Month(Date.Today)))

    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If Regex.Replace(Me.previewType, "\s+", "") = "LineGroupPreview" Then

            reportType = 7

            Slipknot.addReportParameter("parYear", numYear.Value)
            Slipknot.addReportParameter("parMonth", drpMonth.SelectedIndex + 1)

        ElseIf Regex.Replace(Me.previewType, "\s+", "") = "CTOAPreview" Then

            reportType = 8

            Slipknot.addReportParameter("parYear", numYear.Value)
            Slipknot.addReportParameter("parMonth", drpMonth.SelectedIndex + 1)
        End If

        Dim frm As New FrmReport
        frm.Show()
    End Sub

    Public Overloads Sub ShowDialog(previewType As String)
        Me.previewType = previewType
        Me.Text = previewType
        Me.ShowDialog()
    End Sub

End Class
