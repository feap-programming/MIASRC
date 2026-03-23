Imports FEAPNS.DataAccess

Public Class frmRptBudgetAllCustomer

    Private year As Integer
    Private userName As String

    Private Sub FrmRptBudgetPerCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvBudgetPerCustomer.ReportEngineConnection = report.Connection
        report.AddReportParameters("parYear", Me.year)
        Me.rvBudgetPerCustomer.ReportSource = report.GenerateReport("MIA/rptBudgetAllCustomer")

        ' ---------- End Report Server Connection ----------

        Me.rvBudgetPerCustomer.RefreshReport()

        Me.rvBudgetPerCustomer.ZoomPercent = 100

        Me.rvBudgetPerCustomer.RefreshReport()

    End Sub

    Public Overloads Sub Show(year As Integer)
        Me.year = year
        Me.Show()
    End Sub

End Class
