Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class FrmRptSalesInvoiceSummary

    Private dbMIA As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private parDateFrom As Date
    Private parDateTo As Date

    Private Sub FrmRptSalesInvoiceSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        Me.rvSalesInvoice.RefreshReport()
        Me.rvSalesInvoice.ClearHistory()

        ' ---------- Report Server Connection ----------

        Me.rvSalesInvoice.ReportSource = Nothing

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvSalesInvoice.ReportEngineConnection = report.Connection
        report.AddReportParameters("parDateFrom", Me.parDateFrom)
        report.AddReportParameters("parDateTo", Me.parDateTo)
        Me.rvSalesInvoice.ReportSource = report.GenerateReport("MIA/rptSalesInvoiceSummary")

        ' ---------- End Report Server Connection ----------

        Me.rvSalesInvoice.ZoomPercent = 100

        Me.rvSalesInvoice.RefreshReport()

    End Sub

    Public Overloads Sub Show(argDateFrom As Date, argDateTo As Date)
        Me.parDateFrom = argDateFrom
        Me.parDateTo = argDateTo
        Me.Show()
    End Sub

End Class
