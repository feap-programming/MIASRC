Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class FrmWeldingDailyReportOfflineViewer
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim Catherine As New Kurumi.DB("192.168.191.12", "dbReportServer", "feap", "45|iF$")
    Dim DTReportCred As DataTable = Catherine.MyQuery("SELECT * FROM tblConfig")
    Dim report As New Report(DTReportCred.Rows(0).Item("fldServer").ToString, DTReportCred.Rows(0).Item("fldUser").ToString, DTReportCred.Rows(0).Item("fldPass").ToString, 0)

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Slipknot.changeTheme(Me)

        If globalVariables.SRCReportType = "Welding Daily Report" Then
            Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()


            If globalVariables.parType = "PW" Then
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
                'Me.report.AddReportParameters("parLot1", globalVariables.parLot1)
                'Me.report.AddReportParameters("parLot2", globalVariables.parLot2)
                'Me.report.AddReportParameters("parLot3", globalVariables.parLot3)
                'Me.report.AddReportParameters("parLot4", globalVariables.parLot4)
                'Me.report.AddReportParameters("parLot5", globalVariables.parLot5)
                'Me.report.AddReportParameters("parLot6", globalVariables.parLot6)
                'Me.report.AddReportParameters("parLot7", globalVariables.parLot7)
                'Me.report.AddReportParameters("parLot8", globalVariables.parLot8)
                'Me.report.AddReportParameters("parLot9", globalVariables.parLot9)
                'Me.report.AddReportParameters("parGoodQty1", globalVariables.parGoodQty1)
                'Me.report.AddReportParameters("parGoodQty2", globalVariables.parGoodQty2)
                'Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptPWDailyReportv5")

                instanceReportSource.Parameters.Add("parID", globalVariables.parDRID)
                instanceReportSource.Parameters.Add("parType", globalVariables.parType)
                instanceReportSource.Parameters.Add("parGroup", globalVariables.parGroup)
                instanceReportSource.Parameters.Add("parModel", globalVariables.parModel)
                instanceReportSource.Parameters.Add("parLine", globalVariables.parLine)
                instanceReportSource.Parameters.Add("parDate", globalVariables.parDate)
                instanceReportSource.Parameters.Add("parLotNo", globalVariables.parLotNo)
                instanceReportSource.Parameters.Add("parShift", globalVariables.parShift)
                instanceReportSource.Parameters.Add("parTeamLeader", globalVariables.parTeamLeader)
                instanceReportSource.Parameters.Add("parPartName1", globalVariables.parPartName1)
                instanceReportSource.Parameters.Add("parPartName2", globalVariables.parPartName2)
                instanceReportSource.Parameters.Add("parWeldingNo1", globalVariables.parWeldingNo1)
                instanceReportSource.Parameters.Add("parWeldingNo2", globalVariables.parWeldingNo2)
                instanceReportSource.Parameters.Add("parLot1", globalVariables.parLot1)
                instanceReportSource.Parameters.Add("parLot2", globalVariables.parLot2)
                instanceReportSource.Parameters.Add("parLot3", globalVariables.parLot3)
                instanceReportSource.Parameters.Add("parLot4", globalVariables.parLot4)
                instanceReportSource.Parameters.Add("parLot5", globalVariables.parLot5)
                instanceReportSource.Parameters.Add("parGoodQty1", globalVariables.parGoodQty1)
                instanceReportSource.Parameters.Add("parGoodQty2", globalVariables.parGoodQty2)
                instanceReportSource.ReportDocument = New MIA.rptPWDailyReportv2()

                ReportViewer1.ReportSource = instanceReportSource

                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ReportViewer1.ZoomPercent = 100

                ReportViewer1.RefreshReport()

            ElseIf globalVariables.parType = "FW" Then
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
                'Me.report.AddReportParameters("parLot6", globalVariables.parLot6)
                'Me.report.AddReportParameters("parLot7", globalVariables.parLot7)
                'Me.report.AddReportParameters("parLot8", globalVariables.parLot8)
                'Me.report.AddReportParameters("parLot9", globalVariables.parLot9)
                'Me.report.AddReportParameters("parGoodQty1", globalVariables.parGoodQty1)
                'Me.report.AddReportParameters("parGoodQty2", globalVariables.parGoodQty2)
                'Me.report.AddReportParameters("parGoodQty3", globalVariables.parGoodQty3)
                'Me.report.AddReportParameters("parGoodQty4", globalVariables.parGoodQty4)

                'Me.ReportViewer1.ReportSource = report.GenerateReport("MIA/rptFWDailyReportv2")

                instanceReportSource.Parameters.Add("parID", globalVariables.parDRID)
                instanceReportSource.Parameters.Add("parType", globalVariables.parType)
                instanceReportSource.Parameters.Add("parGroup", globalVariables.parGroup)
                instanceReportSource.Parameters.Add("parModel", globalVariables.parModel)
                instanceReportSource.Parameters.Add("parLine", globalVariables.parLine)
                instanceReportSource.Parameters.Add("parDate", globalVariables.parDate)
                instanceReportSource.Parameters.Add("parLotNo", globalVariables.parLotNo)
                instanceReportSource.Parameters.Add("parShift", globalVariables.parShift)
                instanceReportSource.Parameters.Add("parTeamLeader", globalVariables.parTeamLeader)
                instanceReportSource.Parameters.Add("parPartName1", globalVariables.parPartName1)
                instanceReportSource.Parameters.Add("parPartName2", globalVariables.parPartName2)
                instanceReportSource.Parameters.Add("parWeldingNo1", globalVariables.parWeldingNo1)
                instanceReportSource.Parameters.Add("parWeldingNo2", globalVariables.parWeldingNo2)
                instanceReportSource.Parameters.Add("parWeldingNo3", globalVariables.parWeldingNo3)
                instanceReportSource.Parameters.Add("parWeldingNo4", globalVariables.parWeldingNo4)
                instanceReportSource.Parameters.Add("parLot1", globalVariables.parLot1)
                instanceReportSource.Parameters.Add("parLot2", globalVariables.parLot2)
                instanceReportSource.Parameters.Add("parLot3", globalVariables.parLot3)
                instanceReportSource.Parameters.Add("parLot4", globalVariables.parLot4)
                instanceReportSource.Parameters.Add("parLot5", globalVariables.parLot5)
                instanceReportSource.Parameters.Add("parLot6", globalVariables.parLot6)
                instanceReportSource.Parameters.Add("parLot7", globalVariables.parLot7)
                instanceReportSource.Parameters.Add("parLot8", globalVariables.parLot8)
                instanceReportSource.Parameters.Add("parLot9", globalVariables.parLot9)
                instanceReportSource.Parameters.Add("parGoodQty1", globalVariables.parGoodQty1)
                instanceReportSource.Parameters.Add("parGoodQty2", globalVariables.parGoodQty2)
                instanceReportSource.Parameters.Add("parGoodQty3", globalVariables.parGoodQty3)
                instanceReportSource.Parameters.Add("parGoodQty4", globalVariables.parGoodQty4)
                instanceReportSource.ReportDocument = New MIA.rptFWDailyReport()

                ReportViewer1.ReportSource = instanceReportSource


                ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.Interactive

                ReportViewer1.ZoomPercent = 100

                ReportViewer1.RefreshReport()
            End If
        End If
    End Sub
End Class
