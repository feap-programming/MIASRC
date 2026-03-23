Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmSalesInvoiceReportSelector

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)

    Private Sub FrmSalesInvoiceReportSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        dtDateFrom.Value = New Date(Now.Year, 1, 1)
        dtDateTo.Value = New Date(Now.Year, 12, 31)

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim report As New FrmRptSalesInvoiceSummary
        Dim parDateFrom As Date = dtDateFrom.Value
        Dim parDateTo As Date = dtDateTo.Value
        report.Show(parDateFrom, parDateTo)

    End Sub

End Class
