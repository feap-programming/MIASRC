Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmGenCVBTReport
    Private Sub FrmGenCVBTReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MM/dd/yyyy"
        dtpFrom.Value = Today

        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.CustomFormat = "MM/dd/yyyy"
        dtpTo.Value = Today

    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click

        If ddDataType.Text = "Check Voucher" Then
            reportType = 14
        Else
            reportType = 15
        End If

        Slipknot.addReportParameter("parCategory", ddDataType.Text)
        Slipknot.addReportParameter("parFrom", dtpFrom.Value)
        Slipknot.addReportParameter("parTo", dtpTo.Value)

        Dim frm As New FrmReport
        frm.Show()

    End Sub
End Class
