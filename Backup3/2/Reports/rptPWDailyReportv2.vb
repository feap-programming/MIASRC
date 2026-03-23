Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports FEAPNS
Imports FEAPNS.DataAccess


Partial Public Class rptPWDailyReportv2
    Inherits Telerik.Reporting.Report

    Dim SubPWWeldingLot1 As rptSubPWWeldingLot1
    Dim SubPWWeldingLot2 As rptSubPWWeldingLot2
    Dim SubPWWeldingLot3 As rptSubPWWeldingLot3
    Dim SubPWWeldingLot4 As rptSubPWWeldingLot4
    Dim SubPWWeldingLot5 As rptSubPWWeldingLot5
    Dim SubWeldingGoodQty1 As rptSubWeldingGoodQty1
    Dim SubWeldingGoodQty2 As rptSubWeldingGoodQty2
    Public Sub New()
        InitializeComponent()
        SubPWWeldingLot1 = New rptSubPWWeldingLot1
        'SubPWWeldingLot1.ReportParameters("parID").Value = globalVariables.parDRID
        'SubPWWeldingLot1.ReportParameters("parType").Value = globalVariables.parType
        'SubPWWeldingLot1.ReportParameters("parAssyNo").Value = globalVariables.parLot1

        SubPWWeldingLot2 = New rptSubPWWeldingLot2
        'SubPWWeldingLot2.ReportParameters("parID").Value = globalVariables.parDRID
        'SubPWWeldingLot2.ReportParameters("parType").Value = globalVariables.parType
        'SubPWWeldingLot2.ReportParameters("parAssyNo").Value = globalVariables.parLot2

        SubPWWeldingLot3 = New rptSubPWWeldingLot3
        'SubPWWeldingLot3.ReportParameters("parID").Value = globalVariables.parDRID
        'SubPWWeldingLot3.ReportParameters("parType").Value = globalVariables.parType
        'SubPWWeldingLot3.ReportParameters("parAssyNo").Value = globalVariables.parLot3

        SubPWWeldingLot4 = New rptSubPWWeldingLot4
        'SubPWWeldingLot4.ReportParameters("parID").Value = globalVariables.parDRID
        'SubPWWeldingLot4.ReportParameters("parType").Value = globalVariables.parType
        'SubPWWeldingLot4.ReportParameters("parAssyNo").Value = globalVariables.parLot4

        SubPWWeldingLot5 = New rptSubPWWeldingLot5
        'SubPWWeldingLot5.ReportParameters("parID").Value = globalVariables.parDRID
        'SubPWWeldingLot5.ReportParameters("parType").Value = globalVariables.parType
        'SubPWWeldingLot5.ReportParameters("parAssyNo").Value = globalVariables.parLot5

        SubWeldingGoodQty1 = New rptSubWeldingGoodQty1
        'SubWeldingGoodQty1.ReportParameters("parID").Value = globalVariables.parDRID
        'SubWeldingGoodQty1.ReportParameters("parType").Value = globalVariables.parType
        'SubWeldingGoodQty1.ReportParameters("parWeldingNo1").Value = globalVariables.parWeldingNo1

        SubWeldingGoodQty2 = New rptSubWeldingGoodQty2
        'SubWeldingGoodQty2.ReportParameters("parID").Value = globalVariables.parDRID
        'SubWeldingGoodQty2.ReportParameters("parType").Value = globalVariables.parType
        'SubWeldingGoodQty2.ReportParameters("parWeldingNo2").Value = globalVariables.parWeldingNo2


    End Sub




End Class