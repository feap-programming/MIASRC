Imports FEAPNS.DataAccess
Imports Telerik.WinControls


Public Class FrmSRCDailyReportViewer

    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim Catherine As New Kurumi.DB("192.168.191.12", "dbReportServer", "feap", "45|iF$")
    Dim DTReportCred As DataTable = Catherine.MyQuery("SELECT * FROM tblConfig")
    Dim report As New Report(DTReportCred.Rows(0).Item("fldServer").ToString, DTReportCred.Rows(0).Item("fldUser").ToString, DTReportCred.Rows(0).Item("fldPass").ToString, 10000)
    Private Sub FrmSRCDailyReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        If globalVariables.SRCReportType = "Daily Report Shift" Then

            If globalVariables.SRCReportSeparate = "STANDARD" Then

                Dim ModelName As DataTable = Maria.MyQuery("SELECT fldModelName FROM tblModelList where fldCode='" & globalVariables.ModelCode & "'")

                If ModelName.Rows.Count >= 1 Then

                    Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                    Me.report.AddReportParameters("parID", globalVariables.DailyRepID)
                    Me.report.AddReportParameters("parModel", ModelName.Rows(0).Item("fldModelName").ToString)
                    Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailyReportv2")
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                    ReportViewer1.RefreshReport()

                Else
                    RadMessageBox.Show("Model does not exist.")
                End If

            ElseIf globalVariables.SRCReportSeparate = "MANPOWER" Then

                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parID", "," & globalVariables.DailyRepID)
                Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailyManpower")
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                ReportViewer1.RefreshReport()



            ElseIf globalVariables.SRCReportSeparate = "HOURLY" Then

                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parDRID", globalVariables.DailyRepID)
                Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei.ToString("yyyy-MM-dd"))
                Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                Me.report.AddReportParameters("parShift", globalVariables.AssyShift)
                Me.report.AddReportParameters("parLine", globalVariables.ModelLine)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptHourlyQuality")
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                ReportViewer1.RefreshReport()

            ElseIf globalVariables.SRCReportSeparate = "ASSY LINE EFF." Then

                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parID", "," & globalVariables.DailyRepID)
                Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailyAssyEffZwei")
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                ReportViewer1.RefreshReport()

            ElseIf globalVariables.SRCReportSeparate = "SRC ASSY" Then

                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parID", "," & globalVariables.DailyRepID)
                Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailySRCAssyZwei")
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                ReportViewer1.RefreshReport()

            ElseIf globalVariables.SRCReportSeparate = "DEFECTS" Then

                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parID", "," & globalVariables.DailyRepID)
                Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailySRCDefectZwei")
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                ReportViewer1.RefreshReport()

            ElseIf globalVariables.SRCReportSeparate = "OTHERS" Then

                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parID", "," & globalVariables.DailyRepID)
                Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailySRCOthersZwei")
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                ReportViewer1.RefreshReport()

            ElseIf globalVariables.SRCReportSeparate = "LOTNO" Then

                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parID", "," & globalVariables.DailyRepID)
                Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailySRCLotNoZwei")
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                ReportViewer1.RefreshReport()

            ElseIf globalVariables.SRCReportSeparate = "ALL (WORK BOOK)" Then

                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parID", "," & globalVariables.DailyRepID)
                Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptBookSRCDaily")
                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                ReportViewer1.RefreshReport()

            End If

        ElseIf globalVariables.SRCReportType = "Daily Report Date" Then

            If globalVariables.SRCReportSeparate = "STANDARD" Then

                Dim ModelName As DataTable = Maria.MyQuery("SELECT fldModelName FROM tblModelList where fldCode='" & globalVariables.ModelCode & "'")

                If ModelName.Rows.Count >= 1 Then

                    Dim parID1 As String = ""
                    Dim parID2 As String = ""
                    Dim parID3 As String = ""
                    Dim parIDD As String = ""
                    Dim parIDN As String = ""

                    Maria.AddMySqlParameters("parID", globalVariables.DailyRepID)
                    Dim DTAllID As DataTable = Maria.SPSelect("SP_SRCDailyReport_SelectIDByID")

                    parID1 = DTAllID.Rows(0).Item("fld1st").ToString
                    parID2 = DTAllID.Rows(0).Item("fld2nd").ToString
                    parID3 = DTAllID.Rows(0).Item("fld3rd").ToString
                    parIDD = DTAllID.Rows(0).Item("fldDay").ToString
                    parIDN = DTAllID.Rows(0).Item("fldNight").ToString

                    Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                    Me.report.AddReportParameters("parID1", parID1)
                    Me.report.AddReportParameters("parID2", parID2)
                    Me.report.AddReportParameters("parID3", parID3)
                    Me.report.AddReportParameters("parIDD", parIDD)
                    Me.report.AddReportParameters("parIDN", parIDN)
                    Me.report.AddReportParameters("parModel", ModelName.Rows(0).Item("fldModelName").ToString)
                    Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptBookSRCAssyDailyReport")
                    ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
                    ReportViewer1.RefreshReport()
                Else
                    RadMessageBox.Show("Model does not exist.")
                End If

            Else
                Dim ModelName As DataTable = Maria.MyQuery("SELECT fldModelName FROM tblModelList where fldCode='" & globalVariables.ModelCode & "'")

                If ModelName.Rows.Count >= 1 Then

                    If globalVariables.SRCReportSeparate = "MANPOWER" Then

                        Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                        Me.report.AddReportParameters("parID", GetIDArray)
                        Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                        Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailyManpower")
                        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                        ReportViewer1.RefreshReport()

                    ElseIf globalVariables.SRCReportSeparate = "HOURLY" Then

                        Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                        Me.report.AddReportParameters("parID", GetIDArray)
                        Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                        Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailyHourlyZwei")
                        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                        ReportViewer1.RefreshReport()

                    ElseIf globalVariables.SRCReportSeparate = "ASSY LINE EFF." Then

                        Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                        Me.report.AddReportParameters("parID", GetIDArray)
                        Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                        Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailyAssyEffZwei")
                        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                        ReportViewer1.RefreshReport()

                    ElseIf globalVariables.SRCReportSeparate = "SRC ASSY" Then

                        Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                        Me.report.AddReportParameters("parID", GetIDArray)
                        Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                        Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailySRCAssyZwei")
                        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                        ReportViewer1.RefreshReport()

                    ElseIf globalVariables.SRCReportSeparate = "DEFECTS" Then

                        Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                        Me.report.AddReportParameters("parID", GetIDArray)
                        Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                        Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailySRCDefectZwei")
                        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                        ReportViewer1.RefreshReport()

                    ElseIf globalVariables.SRCReportSeparate = "OTHERS" Then

                        Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                        Me.report.AddReportParameters("parID", GetIDArray)
                        Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                        Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailySRCOthersZwei")
                        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                        ReportViewer1.RefreshReport()

                    ElseIf globalVariables.SRCReportSeparate = "LOTNO" Then

                        Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                        Me.report.AddReportParameters("parID", GetIDArray)
                        Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                        Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDailySRCLotNoZwei")
                        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                        ReportViewer1.RefreshReport()

                    ElseIf globalVariables.SRCReportSeparate = "ALL (WORK BOOK)" Then

                        Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                        Me.report.AddReportParameters("parID", GetIDArray)
                        Me.report.AddReportParameters("parModel", globalVariables.DailyReportModelZwei)
                        Me.report.AddReportParameters("parDate", globalVariables.DailyReportDateZwei)
                        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptBookSRCDaily")
                        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive
                        ReportViewer1.RefreshReport()

                    End If

                End If

            End If
        ElseIf globalVariables.DowntimeType = "PW" Then

            Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
            Me.report.AddReportParameters("parID", globalVariables.AssyDownTimeID)
            Me.report.AddReportParameters("parLine", globalVariables.AssyDownTimeLine)
            Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDowntimeReportPWv3")
            ReportViewer1.RefreshReport()


        ElseIf globalVariables.DowntimeType = "FW" Then

            Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
            Me.report.AddReportParameters("parID", globalVariables.AssyDownTimeID)
            Me.report.AddReportParameters("parLine", globalVariables.AssyDownTimeLine)
            Me.report.AddReportParameters("parGroup", globalVariables.FWGroupDt)

            If globalVariables.FWGroupDt <> "Both" Then
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDowntimeReportFW")
                ReportViewer1.RefreshReport()
            Else
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDowntimeReportFWBoth")
                ReportViewer1.RefreshReport()
            End If

            ReportViewer1.RefreshReport()




        ElseIf globalVariables.downtimeReportType = "STANDARD" Then
            globalVariables.SRCReportType = "Down Time"
            If globalVariables.DowntimeType = "ASSY" Then
                Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
                Me.report.AddReportParameters("parID", globalVariables.AssyDownTimeID)
                Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDowntimeReportv2")
                ReportViewer1.RefreshReport()
            End If
            ReportViewer1.RefreshReport()


        ElseIf globalVariables.downtimeReportType = "PER DAY" Then

            Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
            Me.report.AddReportParameters("parDateFrom", globalVariables.dateFrom.ToString("yyyy-MM-dd"))
            Me.report.AddReportParameters("parDateTo", globalVariables.dateTo.ToString("yyyy-MM-dd"))
            Me.report.AddReportParameters("parLine", globalVariables.AssyDownTimeLine)
            Me.report.AddReportParameters("parModel", globalVariables.parModel)
            Me.report.AddReportParameters("parType", globalVariables.DowntimeType)
            Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDowntimeGraphPerDay")
            ReportViewer1.RefreshReport()

        ElseIf globalVariables.downtimeReportType = "PER SHIFT" Then

            Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
            Me.report.AddReportParameters("parDateFrom", globalVariables.dateFrom.ToString("yyyy-MM-dd"))
            Me.report.AddReportParameters("parDateTo", globalVariables.dateTo.ToString("yyyy-MM-dd"))
            Me.report.AddReportParameters("parLine", globalVariables.AssyDownTimeLine)
            Me.report.AddReportParameters("parModel", globalVariables.parModel)
            Me.report.AddReportParameters("parType", globalVariables.DowntimeType)
            Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptSRCDowntimeGraphPerShift")
            ReportViewer1.RefreshReport()

            'ElseIf globalVariables.SRCReportType = "Welding Daily Report" Then

            '    Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
            '    Me.report.AddReportParameters("parID", globalVariables.parDRID)
            '    Me.report.AddReportParameters("parType", globalVariables.parType)
            '    Me.report.AddReportParameters("parGroup", globalVariables.parGroup)
            '    Me.report.AddReportParameters("parModel", globalVariables.parModel)
            '    Me.report.AddReportParameters("parLine", globalVariables.parLine)
            '    Me.report.AddReportParameters("parDate", globalVariables.parDate)
            '    Me.report.AddReportParameters("parLotNo", globalVariables.parLotNo)
            '    Me.report.AddReportParameters("parShift", globalVariables.parShift)
            '    Me.report.AddReportParameters("parTeamLeader", globalVariables.parTeamLeader)
            '    Me.report.AddReportParameters("parPartName1", globalVariables.parPartName1)
            '    Me.report.AddReportParameters("parPartName2", globalVariables.parPartName2)
            '    Me.report.AddReportParameters("parWeldingNo1", globalVariables.parWeldingNo1)
            '    Me.report.AddReportParameters("parWeldingNo2", globalVariables.parWeldingNo2)
            '    Me.report.AddReportParameters("parLot1", globalVariables.parLot1)
            '    Me.report.AddReportParameters("parLot2", globalVariables.parLot2)
            '    Me.report.AddReportParameters("parLot3", globalVariables.parLot3)
            '    Me.report.AddReportParameters("parLot4", globalVariables.parLot4)
            '    Me.report.AddReportParameters("parLot5", globalVariables.parLot5)
            '    Me.report.AddReportParameters("parGoodQty1", globalVariables.parGoodQty1)
            '    Me.report.AddReportParameters("parGoodQty2", globalVariables.parGoodQty2)

            '    If globalVariables.parType = "PW" Then
            '        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptPWDailyReportv2")
            '    ElseIf globalVariables.parType = "FW" Then
            '        Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptFWDailyReport")
            '    End If


            '    ReportViewer1.RefreshReport()
            'ElseIf globalVariables.SRCReportType = "Welding Daily Report" Then
            '    Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()


            'If globalVariables.parType = "PW" Then

            '        instanceReportSource.Parameters.Add("parID", globalVariables.parDRID)
            '        instanceReportSource.Parameters.Add("parType", globalVariables.parType)
            '        instanceReportSource.Parameters.Add("parGroup", globalVariables.parGroup)
            '        instanceReportSource.Parameters.Add("parModel", globalVariables.parModel)
            '        instanceReportSource.Parameters.Add("parLine", globalVariables.parLine)
            '        instanceReportSource.Parameters.Add("parDate", globalVariables.parDate)
            '        instanceReportSource.Parameters.Add("parLotNo", globalVariables.parLotNo)
            '        instanceReportSource.Parameters.Add("parShift", globalVariables.parShift)
            '        instanceReportSource.Parameters.Add("parTeamLeader", globalVariables.parTeamLeader)
            '        instanceReportSource.Parameters.Add("parPartName1", globalVariables.parPartName1)
            '        instanceReportSource.Parameters.Add("parPartName2", globalVariables.parPartName2)
            '        instanceReportSource.Parameters.Add("parWeldingNo1", globalVariables.parWeldingNo1)
            '        instanceReportSource.Parameters.Add("parWeldingNo2", globalVariables.parWeldingNo2)
            '        instanceReportSource.Parameters.Add("parLot1", globalVariables.parLot1)
            '        instanceReportSource.Parameters.Add("parLot2", globalVariables.parLot2)
            '        instanceReportSource.Parameters.Add("parLot3", globalVariables.parLot3)
            '        instanceReportSource.Parameters.Add("parLot4", globalVariables.parLot4)
            '        instanceReportSource.Parameters.Add("parLot5", globalVariables.parLot5)
            '        instanceReportSource.Parameters.Add("parGoodQty1", globalVariables.parGoodQty1)
            '        instanceReportSource.Parameters.Add("parGoodQty2", globalVariables.parGoodQty2)
            '        instanceReportSource.ReportDocument = New MIA.rptPWDailyReportv2()

            '        ReportViewer1.ReportSource = instanceReportSource


            '        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            '        ReportViewer1.ZoomPercent = 100

            '        ReportViewer1.RefreshReport()

            'ElseIf globalVariables.parType = "FW" Then
            '        instanceReportSource.Parameters.Add("parID", globalVariables.parDRID)
            '        instanceReportSource.Parameters.Add("parType", globalVariables.parType)
            '        instanceReportSource.Parameters.Add("parGroup", globalVariables.parGroup)
            '        instanceReportSource.Parameters.Add("parModel", globalVariables.parModel)
            '        instanceReportSource.Parameters.Add("parLine", globalVariables.parLine)
            '        instanceReportSource.Parameters.Add("parDate", globalVariables.parDate)
            '        instanceReportSource.Parameters.Add("parLotNo", globalVariables.parLotNo)
            '        instanceReportSource.Parameters.Add("parShift", globalVariables.parShift)
            '        instanceReportSource.Parameters.Add("parTeamLeader", globalVariables.parTeamLeader)
            '        instanceReportSource.Parameters.Add("parPartName1", globalVariables.parPartName1)
            '        instanceReportSource.Parameters.Add("parPartName2", globalVariables.parPartName2)
            '        instanceReportSource.Parameters.Add("parWeldingNo1", globalVariables.parWeldingNo1)
            '        instanceReportSource.Parameters.Add("parWeldingNo2", globalVariables.parWeldingNo2)
            '        instanceReportSource.Parameters.Add("parWeldingNo3", globalVariables.parWeldingNo3)
            '        instanceReportSource.Parameters.Add("parWeldingNo4", globalVariables.parWeldingNo4)
            '        instanceReportSource.Parameters.Add("parLot1", globalVariables.parLot1)
            '        instanceReportSource.Parameters.Add("parLot2", globalVariables.parLot2)
            '        instanceReportSource.Parameters.Add("parLot3", globalVariables.parLot3)
            '        instanceReportSource.Parameters.Add("parLot4", globalVariables.parLot4)
            '        instanceReportSource.Parameters.Add("parLot5", globalVariables.parLot5)
            '        instanceReportSource.Parameters.Add("parLot6", globalVariables.parLot6)
            '        instanceReportSource.Parameters.Add("parLot7", globalVariables.parLot7)
            '        instanceReportSource.Parameters.Add("parLot8", globalVariables.parLot8)
            '        instanceReportSource.Parameters.Add("parLot9", globalVariables.parLot9)
            '        instanceReportSource.Parameters.Add("parGoodQty1", globalVariables.parGoodQty1)
            '        instanceReportSource.Parameters.Add("parGoodQty2", globalVariables.parGoodQty2)
            '        instanceReportSource.Parameters.Add("parGoodQty3", globalVariables.parGoodQty3)
            '        instanceReportSource.Parameters.Add("parGoodQty4", globalVariables.parGoodQty4)
            '        instanceReportSource.ReportDocument = New MIA.rptFWDailyReport()

            '        ReportViewer1.ReportSource = instanceReportSource


            '        ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

            '        ReportViewer1.ZoomPercent = 100

            '        ReportViewer1.RefreshReport()
            '    End If
            'Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
            'Me.report.AddReportParameters("parID", globalVariables.parDRID)
            'Me.report.AddReportParameters("parType", globalVariables.parType)
            'Me.report.AddReportParameters("parGroup", globalVariables.parGroup)
            'Me.report.AddReportParameters("parModel", globalVariables.parModel)
            'Me.report.AddReportParameters("parLine", globalVariables.parLine)
            'Me.report.AddReportParameters("parDate", globalVariables.parDate)
            'Me.report.AddReportParameters("parLotNo", globalVariables.parLotNo)
            'Me.report.AddReportParameters("parShift", globalVariables.parShift)
            'Me.report.AddReportParameters("parTeamLeader", globalVariables.parTeamLeader)
            'Me.report.AddReportParameters("parPartName1", globalVariables.parPartName1)
            'Me.report.AddReportParameters("parPartName2", globalVariables.parPartName2)
            'Me.report.AddReportParameters("parWeldingNo1", globalVariables.parWeldingNo1)
            'Me.report.AddReportParameters("parWeldingNo2", globalVariables.parWeldingNo2)
            'Me.report.AddReportParameters("parWeldingNo3", globalVariables.parWeldingNo3)
            'Me.report.AddReportParameters("parWeldingNo4", globalVariables.parWeldingNo4)
            'Me.report.AddReportParameters("parLot1", globalVariables.parLot1)
            'Me.report.AddReportParameters("parLot2", globalVariables.parLot2)
            'Me.report.AddReportParameters("parLot3", globalVariables.parLot3)
            'Me.report.AddReportParameters("parLot4", globalVariables.parLot4)
            'Me.report.AddReportParameters("parLot5", globalVariables.parLot5)
            'Me.report.AddReportParameters("parLot2", globalVariables.parLot6)
            'Me.report.AddReportParameters("parLot3", globalVariables.parLot7)
            'Me.report.AddReportParameters("parLot4", globalVariables.parLot8)
            'Me.report.AddReportParameters("parLot5", globalVariables.parLot9)
            'Me.report.AddReportParameters("parGoodQty1", globalVariables.parGoodQty1)
            'Me.report.AddReportParameters("parGoodQty2", globalVariables.parGoodQty2)
            'Me.report.AddReportParameters("parGoodQty2", globalVariables.parGoodQty3)
            'Me.report.AddReportParameters("parGoodQty2", globalVariables.parGoodQty4)

            'Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptFWDailyReport")
            'ReportViewer1.RefreshReport()
            'End If




        ElseIf globalVariables.SRCReportType = "Auto Taping" Then


            Me.ReportViewer1.ReportEngineConnection = Me.report.Connection
            Me.report.AddReportParameters("parDRID", Mio.ReportATDrid)
            Me.report.AddReportParameters("parNo1", Mio.ReportATNo1)
            Me.report.AddReportParameters("parNo2", Mio.ReportATNo2)
            Me.report.AddReportParameters("parModel", Mio.ReportATModel)
            Me.report.AddReportParameters("parShift", Mio.ReportATShift)
            Me.report.AddReportParameters("parDate", Mio.ReportATDate.ToString("yyyy-MM-dd"))
            Me.report.AddReportParameters("Lot1", Mio.ReportATLot1)
            Me.report.AddReportParameters("Lot2", Mio.ReportATLot2)
            Me.report.AddReportParameters("Lot3", Mio.ReportATLot3)
            Me.report.AddReportParameters("Lot4", Mio.ReportATLot4)
            Me.report.AddReportParameters("Lot5", Mio.ReportATLot5)
            Me.report.AddReportParameters("parLine", Mio.ReportATDLine)
            Me.report.AddReportParameters("parGroup", Mio.ReportATDGroup)
            Me.report.AddReportParameters("parTL", globalVariables.currentUser(1))
            Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptAutoTapingDailyReport")
            ReportViewer1.RefreshReport()

        End If

    End Sub

    Private Function GetIDArray() As String

        Dim ReturnVal As String = Nothing

        Dim parID1 As String = ""
        Dim parID2 As String = ""
        Dim parID3 As String = ""
        Dim parIDD As String = ""
        Dim parIDN As String = ""

        Maria.AddMySqlParameters("parID", globalVariables.DailyRepID)
        Dim DTAllID As DataTable = Maria.SPSelect("SP_SRCDailyReport_SelectIDByID")

        parID1 = DTAllID.Rows(0).Item("fld1st").ToString
        parID2 = DTAllID.Rows(0).Item("fld2nd").ToString
        parID3 = DTAllID.Rows(0).Item("fld3rd").ToString
        parIDD = DTAllID.Rows(0).Item("fldDay").ToString
        parIDN = DTAllID.Rows(0).Item("fldNight").ToString

        If IsDBNull(parID1) Or parID1 = Nothing Then

        Else
            ReturnVal = ReturnVal & "," & parID1
        End If

        If IsDBNull(parID2) Or parID2 = Nothing Then

        Else
            ReturnVal = ReturnVal & "," & parID2
        End If

        If IsDBNull(parID3) Or parID3 = Nothing Then

        Else
            ReturnVal = ReturnVal & "," & parID3
        End If

        If IsDBNull(parIDD) Or parIDD = Nothing Then

        Else
            ReturnVal = ReturnVal & "," & parIDD
        End If

        If IsDBNull(parIDN) Or parIDN = Nothing Then

        Else
            ReturnVal = ReturnVal & "," & parIDN
        End If

        Return ReturnVal

    End Function

End Class
