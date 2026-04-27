Imports Telerik.WinControls


Public Class FrmSRCDailyReportOfflineViewer

    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim Catherine As New Kurumi.DB("192.168.191.12", "dbReportServer", "feap", "45|iF$")
    Private Sub FrmSRCDailyReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)


        Dim SetReport As Action(Of Telerik.Reporting.Report) =
            Sub(rpt As Telerik.Reporting.Report)
                Dim instance As New Telerik.Reporting.InstanceReportSource()
                instance.ReportDocument = rpt
                Me.ReportViewer1.ReportSource = instance
            End Sub

        Dim SetReportBook As Action(Of Telerik.Reporting.ReportBook) =
            Sub(book As Telerik.Reporting.ReportBook)
                Dim instance As New Telerik.Reporting.InstanceReportSource()
                instance.ReportDocument = book
                Me.ReportViewer1.ReportSource = instance
            End Sub

        If globalVariables.SRCReportType = "Daily Report Shift" Then

            Dim ModelName As DataTable = Maria.MyQuery("SELECT fldModelName FROM tblModelList WHERE fldCode='" & globalVariables.ModelCode & "'")

            If globalVariables.SRCReportSeparate = "STANDARD" Then

                If ModelName.Rows.Count < 1 Then
                    RadMessageBox.Show("Model does not exist.")
                    Exit Sub
                End If

                Dim rpt As New MIA.rptSRCDailyReport()
                rpt.ReportParameters("parID").Value = globalVariables.DailyRepID
                rpt.ReportParameters("parModel").Value = ModelName.Rows(0)("fldModelName").ToString

                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview

            ElseIf globalVariables.SRCReportSeparate = "MANPOWER" Then

                Dim rpt As New MIA.rptSRCDailyManpower()
                rpt.ReportParameters("parID").Value = "," & globalVariables.DailyRepID
                rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei

                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            ElseIf globalVariables.SRCReportSeparate = "HOURLY" Then

                Dim rpt As New MIA.rptHourlyQuality()
                rpt.ReportParameters("parDRID").Value = globalVariables.DailyRepID
                rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei.ToString("yyyy-MM-dd")
                rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                rpt.ReportParameters("parShift").Value = globalVariables.AssyShift
                rpt.ReportParameters("parLine").Value = globalVariables.ModelLine

                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            ElseIf globalVariables.SRCReportSeparate = "ASSY LINE EFF." Then

                Dim rpt As New MIA.rptSRCDailyAssyEffZwei()
                rpt.ReportParameters("parID").Value = "," & globalVariables.DailyRepID
                rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei

                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            ElseIf globalVariables.SRCReportSeparate = "SRC ASSY" Then

                Dim rpt As New MIA.rptSRCDailySRCAssyZwei()
                rpt.ReportParameters("parID").Value = "," & globalVariables.DailyRepID
                rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei

                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            ElseIf globalVariables.SRCReportSeparate = "DEFECTS" Then

                Dim rpt As New MIA.rptSRCDailySRCDefectZwei()
                rpt.ReportParameters("parID").Value = "," & globalVariables.DailyRepID
                rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei

                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            ElseIf globalVariables.SRCReportSeparate = "OTHERS" Then

                Dim rpt As New MIA.rptSRCDailySRCOthersZwei()
                rpt.ReportParameters("parID").Value = "," & globalVariables.DailyRepID
                rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei

                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            ElseIf globalVariables.SRCReportSeparate = "LOTNO" Then

                Dim rpt As New MIA.rptSRCDailySRCLotNoZwei()
                rpt.ReportParameters("parID").Value = "," & globalVariables.DailyRepID
                rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei

                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            ElseIf globalVariables.SRCReportSeparate = "ALL (WORK BOOK)" Or globalVariables.SRCReportSeparate = "ALL" Then

                'Dim rpt As New MIA.rptBookSRCDaily()
                'rpt.ReportParameters("parID").Value = "," & globalVariables.DailyRepID
                'rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                'rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                Dim rptBook As New MIA.rptBookSRCDaily("," & globalVariables.DailyRepID)

                SetReportBook(rptBook)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            End If

        ElseIf globalVariables.SRCReportType = "Daily Report Date" Then

            Dim ModelName As DataTable = Maria.MyQuery("SELECT fldModelName FROM tblModelList WHERE fldCode='" & globalVariables.ModelCode & "'")

            If ModelName.Rows.Count < 1 Then
                RadMessageBox.Show("Model does not exist.")
                Exit Sub
            End If

            If globalVariables.SRCReportSeparate = "STANDARD" Then

                'Maria.AddMySqlParameters("parID", globalVariables.DailyRepID)
                'Dim DTAllID As DataTable = Maria.SPSelect("SP_SRCDailyReport_SelectIDByID")

                'Dim rpt As New MIA.rptBookSRCAssyDailyReport()
                'rpt.ReportParameters("parID1").Value = DTAllID.Rows(0)("fld1st").ToString
                'rpt.ReportParameters("parID2").Value = DTAllID.Rows(0)("fld2nd").ToString
                'rpt.ReportParameters("parID3").Value = DTAllID.Rows(0)("fld3rd").ToString
                'rpt.ReportParameters("parIDD").Value = DTAllID.Rows(0)("fldDay").ToString
                'rpt.ReportParameters("parIDN").Value = DTAllID.Rows(0)("fldNight").ToString
                'rpt.ReportParameters("parModel").Value = ModelName.Rows(0)("fldModelName").ToString

                'SetReport(rpt)
                'ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                Dim rptBook As New MIA.rptBookSRCAssyDailyReport()

                SetReportBook(rptBook)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            Else

                Dim idArray As String = GetIDArray()

                If globalVariables.SRCReportSeparate = "MANPOWER" Then
                    Dim rpt As New MIA.rptSRCDailyManpower()
                    rpt.ReportParameters("parID").Value = idArray
                    rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                    rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                    SetReport(rpt)
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ElseIf globalVariables.SRCReportSeparate = "HOURLY" Then
                    Dim rpt As New MIA.rptSRCDailyHourlyZwei()
                    rpt.ReportParameters("parID").Value = idArray
                    rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                    rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                    SetReport(rpt)
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ElseIf globalVariables.SRCReportSeparate = "ASSY LINE EFF." Then
                    Dim rpt As New MIA.rptSRCDailyAssyEffZwei()
                    rpt.ReportParameters("parID").Value = idArray
                    rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                    rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                    SetReport(rpt)
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ElseIf globalVariables.SRCReportSeparate = "SRC ASSY" Then
                    Dim rpt As New MIA.rptSRCDailySRCAssyZwei()
                    rpt.ReportParameters("parID").Value = idArray
                    rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                    rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                    SetReport(rpt)
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ElseIf globalVariables.SRCReportSeparate = "DEFECTS" Then
                    Dim rpt As New MIA.rptSRCDailySRCDefectZwei()
                    rpt.ReportParameters("parID").Value = idArray
                    rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                    rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                    SetReport(rpt)
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ElseIf globalVariables.SRCReportSeparate = "OTHERS" Then
                    Dim rpt As New MIA.rptSRCDailySRCOthersZwei()
                    rpt.ReportParameters("parID").Value = idArray
                    rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                    rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                    SetReport(rpt)
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ElseIf globalVariables.SRCReportSeparate = "LOTNO" Then
                    Dim rpt As New MIA.rptSRCDailySRCLotNoZwei()
                    rpt.ReportParameters("parID").Value = idArray
                    rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                    rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                    SetReport(rpt)
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ElseIf globalVariables.SRCReportSeparate = "ALL (WORK BOOK)" Or globalVariables.SRCReportSeparate = "ALL" Then
                    'Dim rpt As New MIA.rptBookSRCDaily()
                    'rpt.ReportParameters("parID").Value = idArray
                    'rpt.ReportParameters("parModel").Value = globalVariables.DailyReportModelZwei
                    'rpt.ReportParameters("parDate").Value = globalVariables.DailyReportDateZwei
                    'SetReport(rpt)
                    'ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                    Dim rptBook As New MIA.rptBookSRCDaily(idArray)

                    SetReportBook(rptBook)
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                End If

            End If
        ElseIf globalVariables.SRCReportType = "Welding Daily Report" Then
            If globalVariables.parType = "PW" Then
                Dim rpt As New MIA.rptPWDailyReportv5()

                rpt.ReportParameters("parID").Value = globalVariables.parDRID
                rpt.ReportParameters("parType").Value = globalVariables.parType
                rpt.ReportParameters("parGroup").Value = globalVariables.parGroup
                rpt.ReportParameters("parModel").Value = globalVariables.parModel
                rpt.ReportParameters("parLine").Value = globalVariables.parLine
                rpt.ReportParameters("parDate").Value = globalVariables.parDate
                rpt.ReportParameters("parLotNo").Value = globalVariables.parLotNo
                rpt.ReportParameters("parShift").Value = globalVariables.parShift
                rpt.ReportParameters("parTeamLeader").Value = globalVariables.parTeamLeader
                rpt.ReportParameters("parPartName1").Value = globalVariables.parPartName1
                rpt.ReportParameters("parPartName2").Value = globalVariables.parPartName2
                rpt.ReportParameters("parWeldingNo1").Value = globalVariables.parWeldingNo1
                rpt.ReportParameters("parWeldingNo2").Value = globalVariables.parWeldingNo2
                rpt.ReportParameters("parLot1").Value = globalVariables.parLot1
                rpt.ReportParameters("parLot2").Value = globalVariables.parLot2
                rpt.ReportParameters("parLot3").Value = globalVariables.parLot3
                rpt.ReportParameters("parLot4").Value = globalVariables.parLot4
                rpt.ReportParameters("parLot5").Value = globalVariables.parLot5
                rpt.ReportParameters("parLot6").Value = globalVariables.parLot6
                rpt.ReportParameters("parLot7").Value = globalVariables.parLot7
                rpt.ReportParameters("parLot8").Value = globalVariables.parLot8
                rpt.ReportParameters("parLot9").Value = globalVariables.parLot9
                rpt.ReportParameters("parGoodQty1").Value = globalVariables.parGoodQty1
                rpt.ReportParameters("parGoodQty2").Value = globalVariables.parGoodQty2
                SetReport(rpt)
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
            ElseIf globalVariables.parType = "FW" Then

                Dim rpt As New MIA.rptFWDailyReportv2()
                rpt.ReportParameters("parID").Value = globalVariables.parDRID
                rpt.ReportParameters("parType").Value = globalVariables.parType
                rpt.ReportParameters("parGroup").Value = globalVariables.parGroup
                rpt.ReportParameters("parModel").Value = globalVariables.parModel
                rpt.ReportParameters("parLine").Value = globalVariables.parLine
                rpt.ReportParameters("parDate").Value = globalVariables.parDate
                rpt.ReportParameters("parLotNo").Value = globalVariables.parLotNo
                rpt.ReportParameters("parShift").Value = globalVariables.parShift
                rpt.ReportParameters("parTeamLeader").Value = globalVariables.parTeamLeader
                rpt.ReportParameters("parPartName1").Value = globalVariables.parPartName1
                rpt.ReportParameters("parPartName2").Value = globalVariables.parPartName2
                rpt.ReportParameters("parWeldingNo1").Value = globalVariables.parWeldingNo1
                rpt.ReportParameters("parWeldingNo2").Value = globalVariables.parWeldingNo2
                rpt.ReportParameters("parWeldingNo3").Value = globalVariables.parWeldingNo3
                rpt.ReportParameters("parWeldingNo4").Value = globalVariables.parWeldingNo4
                rpt.ReportParameters("parLot1").Value = globalVariables.parLot1
                rpt.ReportParameters("parLot2").Value = globalVariables.parLot2
                rpt.ReportParameters("parLot3").Value = globalVariables.parLot3
                rpt.ReportParameters("parLot4").Value = globalVariables.parLot4
                rpt.ReportParameters("parLot5").Value = globalVariables.parLot5
                rpt.ReportParameters("parLot6").Value = globalVariables.parLot6
                rpt.ReportParameters("parLot7").Value = globalVariables.parLot7
                rpt.ReportParameters("parLot8").Value = globalVariables.parLot8
                rpt.ReportParameters("parLot9").Value = globalVariables.parLot9
                rpt.ReportParameters("parGoodQty1").Value = globalVariables.parGoodQty1
                rpt.ReportParameters("parGoodQty2").Value = globalVariables.parGoodQty2
                rpt.ReportParameters("parGoodQty3").Value = globalVariables.parGoodQty3
                rpt.ReportParameters("parGoodQty4").Value = globalVariables.parGoodQty4
                SetReport(rpt)

                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                ReportViewer1.ZoomPercent = 100
            End If
        ElseIf globalVariables.DowntimeType = "PW" Then

            Dim rpt As New MIA.rptSRCDowntimeReportPW()
            rpt.ReportParameters("parID").Value = globalVariables.AssyDownTimeID
            rpt.ReportParameters("parLine").Value = globalVariables.AssyDownTimeLine
            SetReport(rpt)
        ElseIf globalVariables.DowntimeType = "FW" Then

            Dim rpt As Telerik.Reporting.Report

            If globalVariables.FWGroupDt <> "Both" Then
                rpt = New MIA.rptSRCDowntimeReportFW()
            Else
                rpt = New MIA.rptSRCDowntimeReportFWBoth()
            End If

            rpt.ReportParameters("parID").Value = globalVariables.AssyDownTimeID
            rpt.ReportParameters("parLine").Value = globalVariables.AssyDownTimeLine
            rpt.ReportParameters("parGroup").Value = globalVariables.FWGroupDt

            SetReport(rpt)


        ElseIf globalVariables.downtimeReportType = "STANDARD" Then

            Dim rpt As New MIA.rptSRCDowntimeReportv2()
            rpt.ReportParameters("parID").Value = globalVariables.AssyDownTimeID

            SetReport(rpt)
            ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
        ElseIf globalVariables.downtimeReportType = "PER DAY" Then

            Dim rpt As New MIA.rptSRCDowntimeGraphPerDay()
            rpt.ReportParameters("parDateFrom").Value = globalVariables.dateFrom.ToString("yyyy-MM-dd")
            rpt.ReportParameters("parDateTo").Value = globalVariables.dateTo.ToString("yyyy-MM-dd")
            rpt.ReportParameters("parLine").Value = globalVariables.AssyDownTimeLine
            rpt.ReportParameters("parModel").Value = globalVariables.parModel
            rpt.ReportParameters("parType").Value = globalVariables.DowntimeType

            SetReport(rpt)

        ElseIf globalVariables.downtimeReportType = "PER SHIFT" Then

            Dim rpt As New MIA.rptSRCDowntimeGraphPerShift()
            rpt.ReportParameters("parDateFrom").Value = globalVariables.dateFrom.ToString("yyyy-MM-dd")
            rpt.ReportParameters("parDateTo").Value = globalVariables.dateTo.ToString("yyyy-MM-dd")
            rpt.ReportParameters("parLine").Value = globalVariables.AssyDownTimeLine
            rpt.ReportParameters("parModel").Value = globalVariables.parModel
            rpt.ReportParameters("parType").Value = globalVariables.DowntimeType

            SetReport(rpt)
        ElseIf globalVariables.SRCReportType = "Auto Taping" Then

            Dim rpt As New MIA.rptAutoTapingDailyReport()
            rpt.ReportParameters("parDRID").Value = Mio.ReportATDrid
            rpt.ReportParameters("parNo1").Value = Mio.ReportATNo1
            rpt.ReportParameters("parNo2").Value = Mio.ReportATNo2
            rpt.ReportParameters("parModel").Value = Mio.ReportATModel
            rpt.ReportParameters("parShift").Value = Mio.ReportATShift
            rpt.ReportParameters("parDate").Value = Mio.ReportATDate.ToString("yyyy-MM-dd")
            rpt.ReportParameters("Lot1").Value = Mio.ReportATLot1
            rpt.ReportParameters("Lot2").Value = Mio.ReportATLot2
            rpt.ReportParameters("Lot3").Value = Mio.ReportATLot3
            rpt.ReportParameters("Lot4").Value = Mio.ReportATLot4
            rpt.ReportParameters("Lot5").Value = Mio.ReportATLot5
            rpt.ReportParameters("parLine").Value = Mio.ReportATDLine
            rpt.ReportParameters("parGroup").Value = Mio.ReportATDGroup
            rpt.ReportParameters("parTL").Value = globalVariables.currentUser(1)

            SetReport(rpt)

        End If

        ReportViewer1.RefreshReport()
    End Sub

    Private Function GetIDArray() As String

        Dim ReturnVal As String = ""

        Maria.AddMySqlParameters("parID", globalVariables.DailyRepID)
        Dim DTAllID As DataTable = Maria.SPSelect("SP_SRCDailyReport_SelectIDByID")

        For Each col In {"fld1st", "fld2nd", "fld3rd", "fldDay", "fldNight"}
            If Not IsDBNull(DTAllID.Rows(0)(col)) Then
                ReturnVal &= "," & DTAllID.Rows(0)(col).ToString
            End If
        Next

        Return ReturnVal
    End Function

End Class
