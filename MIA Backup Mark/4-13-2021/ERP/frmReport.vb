Imports System
Imports System.Data
Imports Telerik.Reporting
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmReport
    Private uriReportSource = New Telerik.Reporting.UriReportSource
    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        If reportType = 1000 Then

            Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource

            Me.Text = "LOT CONTROL PRINT READY"
            instanceReportSource.ReportDocument = New MIA.rptLCS

            ReportViewer1.ReportSource = instanceReportSource
            ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview

            ReportViewer1.ZoomPercent = 100

            ReportViewer1.RefreshReport()

        Else

            ReportViewer1.ReportEngineConnection = New Telerik.ReportViewer.Common.ReportServerConnectionInfo("http://feap-chronos:83", "reportViewer", "WebSlinger15", 10000).ConnectionString

            Select Case reportType
                Case 0
                    Me.Text = "BOM REPORT"
                    uriReportSource.Uri = "MIA/rptBOM"
                Case 1
                    Me.Text = "KANBAN LABEL"
                    uriReportSource.Uri = "MIA/rptWithdrawalKanban"
                Case 2
                    Me.Text = "KANBAN LABEL"
                    uriReportSource.Uri = "MIA/rptIMMachineIssuanceKanban"
                Case 3
                    Me.Text = "CUSTOMER DEMAND REPORT"
                    uriReportSource.Uri = "MIA/rptCustomerDemandPerPartName"
                Case 4
                    Me.Text = "CUSTOMER DEMAND REPORT"
                    uriReportSource.Uri = "MIA/rptCustomerDemandPerModel"
                Case 5
                    Me.Text = "CUSTOMER DEMAND REPORT"
                    uriReportSource.Uri = "MIA/rptCustomerDemandPerExportMoldParts"
                Case 6
                    Me.Text = "MODEL CAPACITY PREVIEW"
                    uriReportSource.Uri = "MIA/rptModelCapacityPreview3"
                Case 7
                    Me.Text = "LINE GROUP PREVIEW"
                    uriReportSource.Uri = "MIA/rptLineGroupPreview"
                Case 8
                    Me.Text = "CTOA PREVIEW"
                    uriReportSource.Uri = "MIA/rptCTOAPreview"
                Case 9
                    Me.Text = "ON-HAND STOCK DAILY REPORT MONITORING"
                    uriReportSource.Uri = "MIA/rptProdInvSummary"
                Case 10
                    Me.Text = "KANBAN LABEL"
                    uriReportSource.Uri = "MIA/rptFGKanban"
                Case 11
                    Me.Text = "COST TABLE"
                    uriReportSource.Uri = "MIA/rptCostTable"
                Case 12
                    Me.Text = "Check Voucher / Bank Transfer"
                    uriReportSource.Uri = "MIA/rptCVBT3"
                Case 13
                    Me.Text = "Check"
                    uriReportSource.Uri = "MIA/rptCVCheque"
                Case 14
                    Me.Text = "Check Voucher Summary"
                    uriReportSource.Uri = "MIA/rptCVSummary"
                Case 15
                    Me.Text = "Bank Transfer Summary"
                    uriReportSource.Uri = "MIA/rptBTSummary"
                Case 16
                    Me.Text = "Daily Report"
                    uriReportSource.Uri = "MIA/rptBSSDailyReport"
            End Select

            ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview

            myReportParam.ForEach(Function(p) uriReportSource.Parameters.Add(p))

            ReportViewer1.ReportSource = uriReportSource

            ReportViewer1.ZoomPercent = 100

            ReportViewer1.RefreshReport()

            myReportParam.Clear()

        End If

    End Sub

End Class

