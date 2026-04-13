Imports FEAPNS.DataAccess

Public Class FrmRptBudgetPerModel

    Private year As Integer
    Private modelCode As String
    Private userName As String

    Private Sub FrmRptBudgetPerModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvBudgetPerModel.ReportEngineConnection = report.Connection
        report.AddReportParameters("parYear", Me.year)
        report.AddReportParameters("parModelCode", Me.modelCode)
        Me.rvBudgetPerModel.ReportSource = report.GenerateReport("MIA/rptBudgetPerModel")

        ' ---------- End Report Server Connection ----------

        Me.rvBudgetPerModel.RefreshReport()

        Me.rvBudgetPerModel.ZoomPercent = 100

        Me.rvBudgetPerModel.RefreshReport()

    End Sub

    Public Overloads Sub Show(year As Integer, modelCode As String)
        Me.year = year
        Me.modelCode = modelCode
        Me.Show()
    End Sub

End Class
