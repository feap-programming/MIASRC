Imports Telerik.Reporting

Public Class rptBookSRCDaily
    Inherits Telerik.Reporting.ReportBook

    Public Sub New(parID As String)
        Dim parModel = globalVariables.DailyReportModelZwei
        Dim parDate = globalVariables.DailyReportDateZwei

        Me.ReportSources.Add(New InstanceReportSource() With {
            .ReportDocument = CreateManpowerReport(parID, parModel, parDate)
        })

        Me.ReportSources.Add(New InstanceReportSource() With {
            .ReportDocument = CreateHourlyReport(parID, parModel, parDate)
        })

        Me.ReportSources.Add(New InstanceReportSource() With {
            .ReportDocument = CreateAssyEffReport(parID, parModel, parDate)
        })

        Me.ReportSources.Add(New InstanceReportSource() With {
            .ReportDocument = CreateSrcAssyReport(parID, parModel, parDate)
        })

        Me.ReportSources.Add(New InstanceReportSource() With {
            .ReportDocument = CreateDefectsReport(parID, parModel, parDate)
        })

        Me.ReportSources.Add(New InstanceReportSource() With {
            .ReportDocument = CreateOthersReport(parID, parModel, parDate)
        })

        Me.ReportSources.Add(New InstanceReportSource() With {
            .ReportDocument = CreateLotNoReport(parID, parModel, parDate)
        })
    End Sub

    Private Function CreateManpowerReport(parID As String, parModel As String, parDate As Date) As Telerik.Reporting.Report
        Dim rpt As New rptSRCDailyManpower()
        rpt.ReportParameters("parID").Value = parID
        rpt.ReportParameters("parModel").Value = parModel
        rpt.ReportParameters("parDate").Value = parDate
        Return rpt
    End Function

    Private Function CreateHourlyReport(parID As String, parModel As String, parDate As Date) As Telerik.Reporting.Report
        Dim rpt As New rptHourlyQuality()
        rpt.ReportParameters("parDRID").Value = globalVariables.DailyRepID
        rpt.ReportParameters("parDate").Value = parDate.ToString("yyyy-MM-dd")
        rpt.ReportParameters("parModel").Value = parModel
        rpt.ReportParameters("parShift").Value = globalVariables.AssyShift
        rpt.ReportParameters("parLine").Value = globalVariables.ModelLine
        Return rpt
    End Function

    Private Function CreateAssyEffReport(parID As String, parModel As String, parDate As Date) As Telerik.Reporting.Report
        Dim rpt As New rptSRCDailyAssyEffZwei()
        rpt.ReportParameters("parID").Value = parID
        rpt.ReportParameters("parModel").Value = parModel
        rpt.ReportParameters("parDate").Value = parDate
        Return rpt
    End Function

    Private Function CreateSrcAssyReport(parID As String, parModel As String, parDate As Date) As Telerik.Reporting.Report
        Dim rpt As New rptSRCDailySRCAssyZwei()
        rpt.ReportParameters("parID").Value = parID
        rpt.ReportParameters("parModel").Value = parModel
        rpt.ReportParameters("parDate").Value = parDate
        Return rpt
    End Function

    Private Function CreateDefectsReport(parID As String, parModel As String, parDate As Date) As Telerik.Reporting.Report
        Dim rpt As New rptSRCDailySRCDefectZwei()
        rpt.ReportParameters("parID").Value = parID
        rpt.ReportParameters("parModel").Value = parModel
        rpt.ReportParameters("parDate").Value = parDate
        Return rpt
    End Function

    Private Function CreateOthersReport(parID As String, parModel As String, parDate As Date) As Telerik.Reporting.Report
        Dim rpt As New rptSRCDailySRCOthersZwei()
        rpt.ReportParameters("parID").Value = parID
        rpt.ReportParameters("parModel").Value = parModel
        rpt.ReportParameters("parDate").Value = parDate
        Return rpt
    End Function

    Private Function CreateLotNoReport(parID As String, parModel As String, parDate As Date) As Telerik.Reporting.Report
        Dim rpt As New rptSRCDailySRCLotNoZwei()
        rpt.ReportParameters("parID").Value = parID
        rpt.ReportParameters("parModel").Value = parModel
        rpt.ReportParameters("parDate").Value = parDate
        Return rpt
    End Function

End Class