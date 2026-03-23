Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class FrmRptSalesInvoice

    Private dbMIA As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)

    Private Property InvoiceID As Int64

    Private Sub FrmRptSalesInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        Me.rvSalesInvoice.RefreshReport()
        Me.rvSalesInvoice.ClearHistory()

        ' ---------- Report Server Connection ----------

        Me.rvSalesInvoice.ReportSource = Nothing

        Dim report As New Report(ReportServer.reportServerURI, ReportServer.reportServerUser, ReportServer.reportServerPwd, 10000)
        Me.rvSalesInvoice.ReportEngineConnection = report.Connection
        report.AddReportParameters("parID", Me.InvoiceID)
        If SetInvoiceClassification(Me.InvoiceID) = "EXPORT" Then
            Me.rvSalesInvoice.ReportSource = report.GenerateReport("MIA/rptSalesInvoice")
        ElseIf SetInvoiceClassification(Me.InvoiceID) = "LOCAL" Then
            Me.rvSalesInvoice.ReportSource = report.GenerateReport("MIA/rptBookInvoiceLocal")
        Else
            RadMessageBox.Show(Me, "No Invoice Classification", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

        ' ---------- End Report Server Connection ----------

        Me.rvSalesInvoice.ZoomPercent = 100

        Me.rvSalesInvoice.RefreshReport()

    End Sub

    Private Function SetInvoiceClassification(invoiceID As Int64) As String

        dbMIA.AddMySqlParameters("parInvoiceID", invoiceID)
        dbMIA.AddMySqlParameters("parClassification", String.Empty)
        Return dbMIA.SPOutput("SP_P_GetInvoiceClassificationByID", "parClassification")("parClassification").ToString

    End Function

    Public Overloads Sub Show(invoiceID As Int64)
        Me.InvoiceID = invoiceID
        Me.Show()
    End Sub

End Class
