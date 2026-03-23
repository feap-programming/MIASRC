Imports FEAPNS.DataAccess

Public Class frmRptModelCapacityTest

    Private year As Integer
    Private month As Integer

    Private Sub FrmRptModelCapacityTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvModelCapacityTest.ReportEngineConnection = report.Connection
        report.AddReportParameters("parYear", Me.year)
        report.AddReportParameters("parMonth", Me.month)
        Me.rvModelCapacityTest.ReportSource = report.GenerateReport("MIA/rptModelCapacityTest3")

        ' ---------- End Report Server Connection ----------

        Me.rvModelCapacityTest.RefreshReport()

        Me.rvModelCapacityTest.ZoomPercent = 100

        Me.rvModelCapacityTest.RefreshReport()

    End Sub

    Private Sub frmRptModelCapacityTest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)

        myDB.AddMySqlParameters("_year", Me.year)
        myDB.AddMySqlParameters("_month", Me.month)
        myDB.SPADE("SP_P_DeleteCapacityPlanningTest")

    End Sub

    Public Overloads Sub Show(year As Integer, month As Integer)
        Me.year = year
        Me.month = month
        Me.Show()
    End Sub

End Class
