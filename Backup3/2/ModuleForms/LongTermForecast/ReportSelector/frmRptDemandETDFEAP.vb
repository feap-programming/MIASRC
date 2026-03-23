Imports FEAPNS.DataAccess

Public Class FrmRptDemandETDFEAP

    Private parCustomerID As UInteger = 0
    Private parDateFrom As Date
    Private parDateTo As Date

    Private Sub FrmRptDemandETDFEAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvDemandETDFEAP.ReportEngineConnection = report.Connection
        report.AddReportParameters("parCustomerID", Me.parCustomerID)
        report.AddReportParameters("parDateFrom", Me.parDateFrom)
        report.AddReportParameters("parDateTo", Me.parDateTo)
        Me.rvDemandETDFEAP.ReportSource = report.GenerateReport("MIA/rptDemandETDFEAP")

        ' ---------- End Report Server Connection ----------

        Me.rvDemandETDFEAP.RefreshReport()

        Me.rvDemandETDFEAP.ZoomPercent = 100

        Me.rvDemandETDFEAP.RefreshReport()

    End Sub

    Public Overloads Sub Show(customerID As UInteger, dateFrom As Date, dateTo As Date)
        Me.parCustomerID = customerID
        Me.parDateFrom = dateFrom
        Me.parDateTo = dateTo
        Me.Show()
    End Sub

End Class
