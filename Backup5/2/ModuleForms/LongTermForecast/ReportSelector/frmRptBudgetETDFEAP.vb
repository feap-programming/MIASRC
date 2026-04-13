Imports FEAPNS.DataAccess

Public Class FrmRptBudgetETDFEAP

    Private parCustomerID As UInteger = 0
    Private parDateFrom As Date
    Private parDateTo As Date

    Private Sub FrmRptBudgetETDFEAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvBudgetETDFEAP.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomerID", Me.parCustomerID)
        report.AddReportParameters("parDateFrom", Me.parDateFrom)
        report.AddReportParameters("parDateTo", Me.parDateTo)
        Me.rvBudgetETDFEAP.ReportSource = report.GenerateReport("MIA/rptBudgetETDFEAP")

        ' ---------- End Report Server Connection ----------

        Me.rvBudgetETDFEAP.RefreshReport()

        Me.rvBudgetETDFEAP.ZoomPercent = 100

        Me.rvBudgetETDFEAP.RefreshReport()

    End Sub

    Public Overloads Sub Show(customerID As UInteger, dateFrom As Date, dateTo As Date)
        Me.parCustomerID = customerID
        Me.parDateFrom = dateFrom
        Me.parDateTo = dateTo
        Me.Show()
    End Sub

End Class
