

Imports FEAPNS.DataAccess

Public Class FrmSyncSRC_vb
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim CurrStatus As String = "^w^/"
    Dim PlannedDT As Integer
    Dim UnplannedDT As Integer
    Private Sub FrmSyncSRC_vb_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim DTDailyReport As DataTable = Zeta.SelectDailyReportSync(globalVariables.SRCSyncModel, globalVariables.SRCSyncDate, globalVariables.SRCSyncLine, globalVariables.SRCSyncShift)

        Dim SyncID As Integer = DTDailyReport.Rows(0).Item("fldID")

        Dim DTManpower As DataTable = Zeta.SelectSRCSyncManPower(SyncID)
        Dim ManpowerCounter = 0

        Maria.MyQuery(" SET SQL_SAFE_UPDATES = 0; Delete from tblDailyReportSRCManpower where fldDRID=" & globalVariables.SRCSyncID & ";SET SQL_SAFE_UPDATES = 1;")

        While ManpowerCounter <= DTManpower.Rows.Count - 1

            Maria.AddMySqlParameters("parDRID", globalVariables.SRCSyncID)
            Maria.AddMySqlParameters("parProcName", DTManpower.Rows(ManpowerCounter).Item("fldProcessName").ToString)
            Maria.AddMySqlParameters("parEmp", DTManpower.Rows(ManpowerCounter).Item("fldEmployee").ToString)
            Maria.AddMySqlParameters("parQualified", DTManpower.Rows(ManpowerCounter).Item("fldQualify"))
            Maria.AddMySqlParameters("parTrans", DTManpower.Rows(ManpowerCounter).Item("fldTransfer"))
            Maria.AddMySqlParameters("parTrain", DTManpower.Rows(ManpowerCounter).Item("fldTrainee"))
            Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRC_InsertManpowerData")

            Threading.Thread.Sleep(60)
            Dim RowCount As Integer = DTManpower.Rows.Count - 1
            CurrStatus = "Saving Manpower"
            Dim percent As Double = (ManpowerCounter / RowCount * 100)
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            ManpowerCounter = ManpowerCounter + 1

        End While

        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete from tblDailyReportSRCHourlyQuality where fldDRID=" & globalVariables.SRCSyncID & "; SET SQL_SAFE_UPDATES = 1;")
        Dim DTHourly As DataTable = Zeta.SelectSRCSyncHourly(SyncID)
        Dim HourlyCounter = 0
        While HourlyCounter <= DTHourly.Rows.Count - 1

            Maria.AddMySqlParameters("parDRID", globalVariables.SRCSyncID)
            Maria.AddMySqlParameters("parTime", DTHourly.Rows(HourlyCounter).Item("fldTime").ToString)
            Maria.AddMySqlParameters("parCableG", DTHourly.Rows(HourlyCounter).Item("fldCableG"))
            Maria.AddMySqlParameters("parStatorG", DTHourly.Rows(HourlyCounter).Item("fldStatorG"))
            Maria.AddMySqlParameters("parFinalProdCheck", DTHourly.Rows(HourlyCounter).Item("fldFinalProdCheck"))
            Maria.AddMySqlParameters("parRotator", DTHourly.Rows(HourlyCounter).Item("fldRotator"))
            Maria.AddMySqlParameters("parStator", DTHourly.Rows(HourlyCounter).Item("fldStator"))
            Maria.AddMySqlParameters("parSubStator", DTHourly.Rows(HourlyCounter).Item("fldSubStator"))
            Maria.AddMySqlParameters("parSleeve", DTHourly.Rows(HourlyCounter).Item("fldSleeve"))
            Maria.AddMySqlParameters("parBarcode", DTHourly.Rows(HourlyCounter).Item("fldBarcode").ToString)
            Maria.AddMySqlParameters("parPlan", DTHourly.Rows(HourlyCounter).Item("fldPlan"))
            Maria.AddMySqlParameters("parActual", DTHourly.Rows(HourlyCounter).Item("fldActual"))
            Maria.AddMySqlParameters("parDeviation", DTHourly.Rows(HourlyCounter).Item("fldDeviation"))
            Maria.AddMySqlParameters("parElectrical", DTHourly.Rows(HourlyCounter).Item("fldElectrical"))
            Maria.AddMySqlParameters("parFunction", DTHourly.Rows(HourlyCounter).Item("fldFunction"))
            Maria.AddMySqlParameters("parFinal", DTHourly.Rows(HourlyCounter).Item("fldFinal"))
            Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRC_InsertHourlyQuality")

            Threading.Thread.Sleep(60)
            Dim RowCount As Integer = DTHourly.Rows.Count - 1
            CurrStatus = "Saving Hourly"
            Dim percent As Double = (HourlyCounter / RowCount * 100)
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            HourlyCounter = HourlyCounter + 1
        End While

        Dim ShiftConv As String = ""

        If globalVariables.SRCSyncShift = "6AM-2PM(1st Shift)" Then
            ShiftConv = "1st Shift"
        ElseIf globalVariables.SRCSyncShift = "6AM-6PM" Then
            ShiftConv = "Day Shift"
        ElseIf globalVariables.SRCSyncShift = "2PM-10PM(2nd Shift)" Then
            ShiftConv = "2nd Shift"
        ElseIf globalVariables.SRCSyncShift = "6PM-6AM" Then
            ShiftConv = "Night Shift"
        ElseIf globalVariables.SRCSyncShift = "10PM-6AM(3rd Shift)" Then
            ShiftConv = "3rd Shift"
        End If

        Maria.AddMySqlParameters("parModel", globalVariables.SRCSyncModel)
        Maria.AddMySqlParameters("parShift", ShiftConv)
        Maria.AddMySqlParameters("parDate", globalVariables.SRCSyncDate)
        Maria.AddMySqlParameters("parPlan", 1)
        Maria.AddMySqlParameters("parType", "ASSY")
        Dim DTDownTimeCheckPlan As DataTable = Maria.SPSelect("SP_SRCDownTime_SelectByDailyReport")
        If DTDownTimeCheckPlan.Rows.Count >= 1 Then
            If IsDBNull(DTDownTimeCheckPlan.Rows(0).Item("TotalDT")) Then
                PlannedDT = 0
            Else
                PlannedDT = Convert.ToInt32(DTDownTimeCheckPlan.Rows(0).Item("TotalDT"))
            End If
        Else
            PlannedDT = 0
        End If


        Maria.AddMySqlParameters("parModel", globalVariables.SRCSyncModel)
        Maria.AddMySqlParameters("parShift", ShiftConv)
        Maria.AddMySqlParameters("parDate", globalVariables.SRCSyncDate)
        Maria.AddMySqlParameters("parPlan", 0)
        Maria.AddMySqlParameters("parType", "ASSY")
        Dim DTDownTimeCheckUnplan As DataTable = Maria.SPSelect("SP_SRCDownTime_SelectByDailyReport2")
        If DTDownTimeCheckUnplan.Rows.Count >= 1 Then
            If IsDBNull(DTDownTimeCheckUnplan.Rows(0).Item("TotalDT")) Then
                UnplannedDT = 0
            Else
                UnplannedDT = Convert.ToInt32(DTDownTimeCheckUnplan.Rows(0).Item("TotalDT"))
            End If
        Else
            UnplannedDT = 0
        End If

        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete from tblDailyReportAssyLineEff where fldDRID=" & globalVariables.SRCSyncID & "; SET SQL_SAFE_UPDATES = 1;")
        Dim DTAssyLineEff As DataTable = Zeta.SelectSRCSyncAssyLineEff(SyncID)
        Dim AssyLineEffCounter = 0
        If DTAssyLineEff.Rows.Count <= 1 Then

            Dim sum As Decimal = 0

            For Each row As DataRow In DTAssyLineEff.Rows

                Dim fldGoodQty As Integer = row.Item("fldGoodQty")
                sum = sum + fldGoodQty
            Next

            Maria.AddMySqlParameters("parDRID", globalVariables.SRCSyncID)
            Maria.AddMySqlParameters("parTimePartition", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldTimePartition").ToString)
            Maria.AddMySqlParameters("parOpTime", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldOpTime"))
            Maria.AddMySqlParameters("parHotto", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldHotto"))
            Maria.AddMySqlParameters("parPlanDownTime", PlannedDT)
            Maria.AddMySqlParameters("parUnPlanDownTime", UnplannedDT)
            Maria.AddMySqlParameters("parCycleTime", ComputeCycleTime(DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldHotto"), PlannedDT, UnplannedDT, DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldOpTime"), sum))
            Maria.AddMySqlParameters("parCustomer", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldCustomer").ToString)
            Maria.AddMySqlParameters("parFGNo", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldFGNo").ToString)
            Maria.AddMySqlParameters("parModel", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldModel").ToString)
            Maria.AddMySqlParameters("parModelCode", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldModelCode").ToString)
            Maria.AddMySqlParameters("parLotNo", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldLotNo").ToString)
            Maria.AddMySqlParameters("parGoodQty", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldGoodQty"))
            Maria.AddMySqlParameters("parReplacement", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldReplacement"))
            Maria.AddMySqlParameters("parAssyScrap", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldAssyScrap"))
            Maria.AddMySqlParameters("parSample", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldSample"))
            Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRC_InsertAssyLineEff")
            Threading.Thread.Sleep(60)
            CurrStatus = "Saving Assy Line Eff"
            BackgroundWorker1.ReportProgress(Convert.ToInt32(100))
        Else
            While AssyLineEffCounter <= DTAssyLineEff.Rows.Count - 1
                Dim sum As Decimal = 0

                For Each row As DataRow In DTAssyLineEff.Rows

                    Dim fldGoodQty As Integer = row.Item("fldGoodQty")
                    sum = sum + fldGoodQty
                Next

                Maria.AddMySqlParameters("parDRID", globalVariables.SRCSyncID)
                Maria.AddMySqlParameters("parTimePartition", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldTimePartition").ToString)
                Maria.AddMySqlParameters("parOpTime", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldOpTime"))
                Maria.AddMySqlParameters("parHotto", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldHotto"))
                Maria.AddMySqlParameters("parPlanDownTime", PlannedDT)
                Maria.AddMySqlParameters("parUnPlanDownTime", UnplannedDT)
                Maria.AddMySqlParameters("parCycleTime", ComputeCycleTime(DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldHotto"), PlannedDT, UnplannedDT, DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldOpTime"), sum))
                Maria.AddMySqlParameters("parCustomer", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldCustomer").ToString)
                Maria.AddMySqlParameters("parFGNo", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldFGNo").ToString)
                Maria.AddMySqlParameters("parModel", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldModel").ToString)
                Maria.AddMySqlParameters("parModelCode", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldModelCode").ToString)
                Maria.AddMySqlParameters("parLotNo", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldLotNo").ToString)
                Maria.AddMySqlParameters("parGoodQty", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldGoodQty"))
                Maria.AddMySqlParameters("parReplacement", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldReplacement"))
                Maria.AddMySqlParameters("parAssyScrap", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldAssyScrap"))
                Maria.AddMySqlParameters("parSample", DTAssyLineEff.Rows(AssyLineEffCounter).Item("fldSample"))
                Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))
                Maria.SPADE("SP_SRC_InsertAssyLineEff")
                Threading.Thread.Sleep(60)
                CurrStatus = "Saving Assy Line Eff"
                BackgroundWorker1.ReportProgress(Convert.ToInt32(100))
                AssyLineEffCounter = AssyLineEffCounter + 1
            End While
        End If


        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete from tblDailyReportSRCAssy where fldDRID=" & globalVariables.SRCSyncID & "; SET SQL_SAFE_UPDATES = 1;")
        Dim DTAssy As DataTable = Zeta.SelectSRCSyncAssy(SyncID)
        Dim AssyCounter = 0
        While AssyCounter <= DTAssy.Rows.Count - 1

            Maria.AddMySqlParameters("parDRID", globalVariables.SRCSyncID)
            Maria.AddMySqlParameters("parPartNo", DTAssy.Rows(AssyCounter).Item("fldPartNo").ToString)
            Maria.AddMySqlParameters("parPartName", DTAssy.Rows(AssyCounter).Item("fldPartName").ToString)
            Maria.AddMySqlParameters("parLotNo", DTAssy.Rows(AssyCounter).Item("fldLotNo").ToString)
            Maria.AddMySqlParameters("parScrapQty", DTAssy.Rows(AssyCounter).Item("fldScrapQty").ToString)
            Maria.AddMySqlParameters("parPurgeQty", DTAssy.Rows(AssyCounter).Item("fldPurgeQty").ToString)
            Maria.AddMySqlParameters("parQASample", DTAssy.Rows(AssyCounter).Item("fldQASample").ToString)
            Maria.AddMySqlParameters("parEngSample", DTAssy.Rows(AssyCounter).Item("fldEngSample").ToString)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRC_InsertSRCAssy")

            Threading.Thread.Sleep(60)
            Dim RowCount As Integer = DTAssy.Rows.Count - 1
            CurrStatus = "Saving SRC Assy"
            Dim percent As Double = (AssyCounter / RowCount * 100)
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            AssyCounter = AssyCounter + 1

        End While

        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete From tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.SRCSyncID & "; SET SQL_SAFE_UPDATES = 1;")
        Dim DTDefects As DataTable = Zeta.SelectSRCSyncDefects(SyncID)
        Dim DefectsCounter = 0
        While DefectsCounter <= DTDefects.Rows.Count - 1

            Maria.AddMySqlParameters("parDRID", globalVariables.SRCSyncID)
            Maria.AddMySqlParameters("parDefCode", DTDefects.Rows(DefectsCounter).Item("fldDefCode").ToString)
            Maria.AddMySqlParameters("parPartName", DTDefects.Rows(DefectsCounter).Item("fldPartName").ToString)
            Maria.AddMySqlParameters("parMan", DTDefects.Rows(DefectsCounter).Item("fldMan"))
            Maria.AddMySqlParameters("parMachine", DTDefects.Rows(DefectsCounter).Item("fldMachine"))
            Maria.AddMySqlParameters("parIM", DTDefects.Rows(DefectsCounter).Item("fldIM"))
            Maria.AddMySqlParameters("parFFC", DTDefects.Rows(DefectsCounter).Item("fldFFC"))
            Maria.AddMySqlParameters("parSubAssy", DTDefects.Rows(DefectsCounter).Item("fldSubAssy"))
            Maria.AddMySqlParameters("parRM", DTDefects.Rows(DefectsCounter).Item("fldRM"))
            Maria.AddMySqlParameters("parCateg", DTDefects.Rows(DefectsCounter).Item("fldCateg").ToString)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRC_InsertSRCInProcDefect")

            Threading.Thread.Sleep(60)
            Dim RowCount As Integer = DTDefects.Rows.Count - 1
            CurrStatus = "Saving Defects"
            Dim percent As Double = (DefectsCounter / RowCount * 100)
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            DefectsCounter = DefectsCounter + 1

        End While


        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete From tblDailyReportSRCOtherDetails where fldDRID=" & globalVariables.SRCSyncID & "; SET SQL_SAFE_UPDATES = 1;")
        Dim DTOthers As DataTable = Zeta.SelectSRCSyncOther(SyncID)

        Maria.AddMySqlParameters("parDRID", globalVariables.SRCSyncID)
        Maria.AddMySqlParameters("parMoldParts", DTOthers.Rows(0).Item("fldMoldParts").ToString)
        Maria.AddMySqlParameters("parInitProd", DTOthers.Rows(0).Item("fldInitProd").ToString)
        Maria.AddMySqlParameters("parOthers", DTOthers.Rows(0).Item("fldOthers").ToString)
        Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
        Maria.SPADE("SP_SRCDailyReport_InsertOtherDetails")

        Threading.Thread.Sleep(60)
        CurrStatus = "Saving Others"
        BackgroundWorker1.ReportProgress(Convert.ToInt32(100))


        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; DELETE FROM tblDailyReportSRCRMWIP where fldDRID=" & globalVariables.SRCSyncID & ";SET SQL_SAFE_UPDATES = 1;")
        Dim DTLotNo As DataTable = Zeta.SelectSRCSyncLotNo(SyncID)
        Dim LotNoCounter = 0
        While LotNoCounter <= DTLotNo.Rows.Count - 1

            Maria.AddMySqlParameters("parDRID", globalVariables.SRCSyncID)
            Maria.AddMySqlParameters("parTime", DTLotNo.Rows(LotNoCounter).Item("fldTime").ToString)
            Maria.AddMySqlParameters("parBoxNo", DTLotNo.Rows(LotNoCounter).Item("fldBoxNo").ToString)
            Maria.AddMySqlParameters("parPartName", DTLotNo.Rows(LotNoCounter).Item("fldPartName").ToString)
            Maria.AddMySqlParameters("parLotNo", DTLotNo.Rows(LotNoCounter).Item("fldLotNo").ToString)
            Maria.AddMySqlParameters("parCavNo", DTLotNo.Rows(LotNoCounter).Item("fldCavNo").ToString)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRCDailyReport_InsertRMWIP")

            Threading.Thread.Sleep(60)
            Dim RowCount As Integer = DTLotNo.Rows.Count - 1
            CurrStatus = "Saving Lot No."
            Dim percent As Double = (LotNoCounter / RowCount * 100)
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            LotNoCounter = LotNoCounter + 1

        End While
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        pbUpload.Text = CurrStatus
        pbUpload.Value1 = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Done!")
        Me.Close()
    End Sub

    Private Sub FrmSyncSRC_vb_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MessageBox.Show(Zeta.SelectDailyReportCount)
        Dim DTDailyReport As DataTable = Zeta.SelectDailyReportSync(globalVariables.SRCSyncModel, globalVariables.SRCSyncDate, globalVariables.SRCSyncLine, globalVariables.SRCSyncShift)

        If DTDailyReport.Rows.Count <= 0 Then
            MessageBox.Show("No Available Daily Report")
            Me.Close()
        Else

            Dim SyncID As Integer = DTDailyReport.Rows(0).Item("fldID")
            Dim DTManpower As DataTable = Zeta.SelectSRCSyncManPower(SyncID)
            Dim DTHourly As DataTable = Zeta.SelectSRCSyncHourly(SyncID)
            Dim DTAssy As DataTable = Zeta.SelectSRCSyncAssy(SyncID)
            Dim DTDefects As DataTable = Zeta.SelectSRCSyncDefects(SyncID)
            Dim DTOthers As DataTable = Zeta.SelectSRCSyncOther(SyncID)
            Dim DTLotNo As DataTable = Zeta.SelectSRCSyncLotNo(SyncID)

            Dim ErrorMSG As String = "No Data: "
            Dim AllowUpload As Integer = True

            If DTManpower.Rows.Count <= 0 Then
                ErrorMSG = ErrorMSG & "Manpower"
                AllowUpload = False
            End If
            If DTHourly.Rows.Count <= 0 Then
                ErrorMSG = ErrorMSG & "Hourly"
                AllowUpload = False
            End If
            If DTAssy.Rows.Count <= 0 Then
                ErrorMSG = ErrorMSG & "SRC Assy"
                AllowUpload = False
            End If
            If DTDefects.Rows.Count <= 0 Then
                ErrorMSG = ErrorMSG & "Defects"
                AllowUpload = False
            End If
            If DTOthers.Rows.Count <= 0 Then
                ErrorMSG = ErrorMSG & "Others"
                AllowUpload = False
            End If
            If DTLotNo.Rows.Count <= 0 Then
                ErrorMSG = ErrorMSG & "Lot No"
                AllowUpload = False
            End If

            If AllowUpload = False Then
                MessageBox.Show(ErrorMSG)
                Me.Close()
            Else
                BackgroundWorker1.RunWorkerAsync()
            End If

        End If

    End Sub

    Private Function ComputeCycleTime(Hotto As Integer, PlanDT As Integer, UnplanDT As Integer, OpTime As Integer, GoodQty As Integer) As Double

        Dim HottoVal As Integer = Hotto
        Dim PlanedDTVal As Integer = PlanDT
        Dim UnplanedDTVal As Integer = UnplanDT
        Dim OPTimeVal As Integer = OpTime

        Dim sum As Decimal = GoodQty

        Dim CycleTime As Decimal = ((OPTimeVal - (HottoVal + PlanedDTVal + UnplanedDTVal)) * 60) / sum

        Return Math.Round(CycleTime, 2)

    End Function
End Class
