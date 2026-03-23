Imports FEAPNS.DataAccess

Public Class FrmRptPurchaseOrder

    Private parCustomerID As UInteger = 0
    Private parDateFrom As Date
    Private parDateTo As Date

    Private Sub FrmRptPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvPurchaseOrder.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomerID", Me.parCustomerID)
        report.AddReportParameters("parDateFrom", Me.parDateFrom)
        report.AddReportParameters("parDateTo", Me.parDateTo)
        Me.rvPurchaseOrder.ReportSource = report.GenerateReport("MIA/rptBookPurchaseOrder")

        ' ---------- End Report Server Connection ----------

        Me.rvPurchaseOrder.RefreshReport()

        Me.rvPurchaseOrder.ZoomPercent = 100

        Me.rvPurchaseOrder.RefreshReport()

    End Sub

    Public Overloads Sub Show(customerID As UInteger, dateFrom As Date, dateTo As Date)
        Me.parCustomerID = customerID
        Me.parDateFrom = dateFrom
        Me.parDateTo = dateTo
        Me.Show()
    End Sub

End Class
