Imports FEAPNS.DataAccess

Public Class FrmRptBudgetPerCustomer

    Private year As Integer
    Private customerCode As String
    Private userName As String

    Private Sub FrmRptBudgetPerCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvBudgetPerCustomer.ReportEngineConnection = report.Connection
        report.AddReportParameters("parYear", Me.year)
        report.AddReportParameters("parCustomerCode", Me.customerCode)
        Me.rvBudgetPerCustomer.ReportSource = report.GenerateReport("MIA/rptBudgetPerCustomer")

        ' ---------- End Report Server Connection ----------

        Me.rvBudgetPerCustomer.RefreshReport()

        Me.rvBudgetPerCustomer.ZoomPercent = 100

        Me.rvBudgetPerCustomer.RefreshReport()

    End Sub

    Public Overloads Sub Show(year As Integer, customerCode As String)
        Me.year = year
        Me.customerCode = customerCode
        Me.Show()
    End Sub

End Class
