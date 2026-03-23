Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class ucIMEditor

    Private Sub ucCTEditor_Load(sender As Object, e As EventArgs) Handles Me.Load

        readyGrid()

        loadData()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.ReadOnly = True
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 80
        fldItemCode.ReadOnly = True
        gvData.Columns.Add(fldItemCode)

        Dim fldQuotationNo As New GridViewDecimalColumn("Quotation No.")
        fldQuotationNo.FieldName = "fldQuotationNo"
        fldQuotationNo.Width = 80
        gvData.Columns.Add(fldQuotationNo)

        Dim fldProcessNo As New GridViewDecimalColumn("Process No.")
        fldProcessNo.FieldName = "fldProcessNo"
        fldProcessNo.Width = 70
        gvData.Columns.Add(fldProcessNo)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 150
        fldPartName.ReadOnly = True
        gvData.Columns.Add(fldPartName)

        Dim fldDemandAve As New GridViewDecimalColumn("Demand Ave. Pcs/M")
        fldDemandAve.FieldName = "fldDemandAve"
        fldDemandAve.Width = 120
        fldDemandAve.ShowUpDownButtons = False
        gvData.Columns.Add(fldDemandAve)

        Dim fldAveDayPerMonth As New GridViewDecimalColumn("Ave.Day / Month")
        fldAveDayPerMonth.FieldName = "fldAveDayPerMonth"
        fldAveDayPerMonth.Width = 100
        fldAveDayPerMonth.ShowUpDownButtons = False
        gvData.Columns.Add(fldAveDayPerMonth)

        Dim fldDailyDemand As New GridViewDecimalColumn("Daily Demand")
        fldDailyDemand.FieldName = "fldDailyDemand"
        fldDailyDemand.Width = 100
        fldDailyDemand.ShowUpDownButtons = False
        gvData.Columns.Add(fldDailyDemand)

        Dim fldLotSize As New GridViewDecimalColumn("Lot Size") 'Manual Input
        fldLotSize.FieldName = "fldLotSize"
        fldLotSize.Width = 70
        fldLotSize.ShowUpDownButtons = False
        gvData.Columns.Add(fldLotSize)
        gvData.Columns("fldLotSize").FormatString = "{0:N2}"

        Dim purgePercent As New GridViewDecimalColumn("Purge (%)")
        purgePercent.FieldName = "purgePercent"
        purgePercent.Width = 80
        purgePercent.ReadOnly = True
        purgePercent.ShowUpDownButtons = False
        gvData.Columns.Add(purgePercent)
        gvData.Columns("purgePercent").FormatString = "{0:P2}"

        Dim disposalPercent As New GridViewDecimalColumn("Disposal (%)")
        disposalPercent.FieldName = "disposalPercent"
        disposalPercent.Width = 80
        disposalPercent.ReadOnly = True
        disposalPercent.ShowUpDownButtons = False
        gvData.Columns.Add(disposalPercent)
        gvData.Columns("disposalPercent").FormatString = "{0:P2}"

        Dim fldDefect As New GridViewDecimalColumn("Defect (%)") 'Manual Input
        fldDefect.FieldName = "fldDefect"
        fldDefect.Width = 80
        fldDefect.DecimalPlaces = 5
        fldDefect.ShowUpDownButtons = False
        gvData.Columns.Add(fldDefect)
        gvData.Columns("fldDefect").FormatString = "{0:P2}"

        Dim fldPolymer As New GridViewTextBoxColumn("Polymer") 'Manual Input
        fldPolymer.FieldName = "fldPolymer"
        fldPolymer.Width = 80
        gvData.Columns.Add(fldPolymer)

        Dim fldGrade As New GridViewTextBoxColumn("Grade") 'Manual Input
        fldGrade.FieldName = "fldGrade"
        fldGrade.Width = 80
        gvData.Columns.Add(fldGrade)

        Dim fldNoOfCav As New GridViewDecimalColumn("No. of Cavity") 'Manual Input
        fldNoOfCav.FieldName = "fldNoOfCav"
        fldNoOfCav.Width = 80
        fldNoOfCav.ShowUpDownButtons = False
        gvData.Columns.Add(fldNoOfCav)
        gvData.Columns("fldNoOfCav").FormatString = "{0:N2}"

        Dim fldPartsGperPC As New GridViewDecimalColumn("Parts g/pc") 'Manual Input
        fldPartsGperPC.FieldName = "fldPartsGperPC"
        fldPartsGperPC.Width = 80
        fldPartsGperPC.ShowUpDownButtons = False
        gvData.Columns.Add(fldPartsGperPC)
        gvData.Columns("fldPartsGperPC").FormatString = "{0:N2}"

        Dim fldRunnerGPerShot As New GridViewDecimalColumn("Runner g/pc") 'Manual Input
        fldRunnerGPerShot.FieldName = "fldRunnerGPerShot"
        fldRunnerGPerShot.Width = 80
        fldRunnerGPerShot.ShowUpDownButtons = False
        gvData.Columns.Add(fldRunnerGPerShot)
        gvData.Columns("fldRunnerGPerShot").FormatString = "{0:N2}"

        Dim consumptionGShot As New GridViewDecimalColumn("Consumption g/shot")
        consumptionGShot.FieldName = "consumptionGShot"
        consumptionGShot.Width = 100
        consumptionGShot.ReadOnly = True
        gvData.Columns.Add(consumptionGShot)
        gvData.Columns("consumptionGShot").FormatString = "{0:N2}"

        Dim prdnShotsSnorPerLot As New GridViewDecimalColumn("Prdn Shots shots/Lot")
        prdnShotsSnorPerLot.FieldName = "prdnShotsSnorPerLot"
        prdnShotsSnorPerLot.Width = 100
        prdnShotsSnorPerLot.ReadOnly = True
        gvData.Columns.Add(prdnShotsSnorPerLot)
        gvData.Columns("prdnShotsSnorPerLot").FormatString = "{0:N2}"

        Dim consumptionGPerPc As New GridViewDecimalColumn("Consumption g/pc")
        consumptionGPerPc.FieldName = "consumptionGPerPc"
        consumptionGPerPc.Width = 100
        consumptionGPerPc.ReadOnly = True
        gvData.Columns.Add(consumptionGPerPc)
        gvData.Columns("consumptionGPerPc").FormatString = "{0:N2}"

        Dim fldResinCost As New GridViewDecimalColumn("Resin Cost JPY/Kg") 'Manual Input
        fldResinCost.FieldName = "fldResinCost"
        fldResinCost.Width = 100
        fldResinCost.ShowUpDownButtons = False
        gvData.Columns.Add(fldResinCost)
        gvData.Columns("fldResinCost").FormatString = "{0:N2}"

        Dim fldRecycleRatio As New GridViewDecimalColumn("Recycle Ratio %") 'Manual Input
        fldRecycleRatio.FieldName = "fldRecycleRatio"
        fldRecycleRatio.Width = 100
        fldRecycleRatio.ShowUpDownButtons = False
        gvData.Columns.Add(fldRecycleRatio)
        gvData.Columns("fldRecycleRatio").FormatString = "{0:N2}"

        Dim fldRecycleCost As New GridViewDecimalColumn("Recycle Cost") 'Manual Input
        fldRecycleCost.FieldName = "fldRecycleCost"
        fldRecycleCost.Width = 80
        fldRecycleCost.ShowUpDownButtons = False
        gvData.Columns.Add(fldRecycleCost)
        gvData.Columns("fldRecycleCost").FormatString = "{0:N2}"

        Dim disposalCostJPYPerKg As New GridViewDecimalColumn("Disposal Cost JPY/Kg")
        disposalCostJPYPerKg.FieldName = "disposalCostJPYPerKg"
        disposalCostJPYPerKg.Width = 110
        disposalCostJPYPerKg.ReadOnly = True
        gvData.Columns.Add(disposalCostJPYPerKg)
        gvData.Columns("disposalCostJPYPerKg").FormatString = "{0:N2}"

        Dim JPYPerPc As New GridViewDecimalColumn("JPY/pc")
        JPYPerPc.FieldName = "JPYPerPc"
        JPYPerPc.Width = 70
        JPYPerPc.ReadOnly = True
        gvData.Columns.Add(JPYPerPc)
        gvData.Columns("JPYPerPc").FormatString = "{0:N2}"

        Dim matCostJPYperPcs As New GridViewDecimalColumn("Material Cost (JPY/pcs)")
        matCostJPYperPcs.FieldName = "matCostJPYperPcs"
        matCostJPYperPcs.Width = 130
        matCostJPYperPcs.ReadOnly = True
        gvData.Columns.Add(matCostJPYperPcs)
        gvData.Columns("matCostJPYperPcs").FormatString = "{0:N2}"

        Dim fldCycleTime As New GridViewDecimalColumn("Cycle Time") 'Manual Input
        fldCycleTime.FieldName = "fldCycleTime"
        fldCycleTime.Width = 80
        fldCycleTime.ShowUpDownButtons = False
        gvData.Columns.Add(fldCycleTime)
        gvData.Columns("fldCycleTime").FormatString = "{0:N2}"

        Dim fldMH As New GridViewDecimalColumn("MH") 'Manual Input
        fldMH.FieldName = "fldMH"
        fldMH.Width = 70
        fldMH.ShowUpDownButtons = False
        gvData.Columns.Add(fldMH)
        gvData.Columns("fldMH").FormatString = "{0:N2}"

        Dim fldMT As New GridViewDecimalColumn("MT") 'Manual Input
        fldMT.FieldName = "fldMT"
        fldMT.Width = 70
        fldMT.ShowUpDownButtons = False
        gvData.Columns.Add(fldMT)
        gvData.Columns("fldMT").FormatString = "{0:N2}"

        Dim PC As New GridViewDecimalColumn("PC (JPY/pc)")
        PC.FieldName = "PC"
        PC.Width = 70
        PC.ShowUpDownButtons = False
        PC.ReadOnly = True
        gvData.Columns.Add(PC)
        gvData.Columns("PC").FormatString = "{0:N2}"

        Dim fldPurgeLossGPerLot As New GridViewDecimalColumn("Purge Loss G/Lot") 'Manual Input
        fldPurgeLossGPerLot.FieldName = "fldPurgeLossGPerLot"
        fldPurgeLossGPerLot.Width = 100
        fldPurgeLossGPerLot.ShowUpDownButtons = False
        gvData.Columns.Add(fldPurgeLossGPerLot)
        gvData.Columns("fldPurgeLossGPerLot").FormatString = "{0:N2}"

        Dim ShotsPerLot As New GridViewDecimalColumn("Shots per Lot")
        ShotsPerLot.FieldName = "ShotsPerLot"
        ShotsPerLot.Width = 90
        ShotsPerLot.ReadOnly = True
        ShotsPerLot.ShowUpDownButtons = False
        gvData.Columns.Add(ShotsPerLot)
        gvData.Columns("ShotsPerLot").FormatString = "{0:N2}"

        Dim fldInitialDisposal As New GridViewDecimalColumn("Initial Disposal Shots/Lot") 'Manual Input
        fldInitialDisposal.FieldName = "fldInitialDisposal"
        fldInitialDisposal.Width = 130
        fldInitialDisposal.ShowUpDownButtons = False
        gvData.Columns.Add(fldInitialDisposal)
        gvData.Columns("fldInitialDisposal").FormatString = "{0:N2}"

        Dim fldQCSample As New GridViewDecimalColumn("QC Sample Shots/Lot") 'Manual Input
        fldQCSample.FieldName = "fldQCSample"
        fldQCSample.Width = 110
        fldQCSample.ShowUpDownButtons = False
        gvData.Columns.Add(fldQCSample)
        gvData.Columns("fldQCSample").FormatString = "{0:N2}"

        Dim totalGPerLot As New GridViewDecimalColumn("Total G/Lot")
        totalGPerLot.FieldName = "totalGPerLot"
        totalGPerLot.Width = 110
        totalGPerLot.ReadOnly = True
        totalGPerLot.ShowUpDownButtons = False
        gvData.Columns.Add(totalGPerLot)
        gvData.Columns("totalGPerLot").FormatString = "{0:N2}"

        Dim fldChangeModelMin As New GridViewDecimalColumn("Change Model Min") 'Manual Input
        fldChangeModelMin.FieldName = "fldChangeModelMin"
        fldChangeModelMin.Width = 110
        fldChangeModelMin.ShowUpDownButtons = False
        gvData.Columns.Add(fldChangeModelMin)
        gvData.Columns("fldChangeModelMin").FormatString = "{0:N2}"

        Dim availability As New GridViewDecimalColumn("Availability OA (%)") 'Manual Input
        availability.FieldName = "fldAvailOA"
        availability.Width = 110
        availability.ShowUpDownButtons = False
        gvData.Columns.Add(availability)
        gvData.Columns("fldAvailOA").FormatString = "{0:N2}"

        gvData.AllowAddNewRow = False
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.AllowDeleteRow = False

    End Sub

    Private Sub loadData()

        Dim dtBOM As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                       & "(SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldChildCode LIMIT 1) AS itemCode " _
                                                       & "FROM " _
                                                       & "tblBOMMaster T0 " _
                                                       & "WHERE T0.fldParentCode = '" & FrmCostTableEditor.txtItemCode.Text & "' ")

        Dim itemCodeArray As String = Nothing

        For Each row As DataRow In dtBOM.Rows

            itemCodeArray = itemCodeArray & "," & Convert.ToString(row.Item("itemCode"))

        Next

        Dim myData As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCostTableIM WHERE FIND_IN_SET(fldItemCode, '" & itemCodeArray & "') ")

        gvData.DataSource = myData


        'Dim myData As DataTable = Slipknot.dbSelectManual("SELECT " _
        '                                                & "T0.fldId, " _
        '                                                & "T0.fldCTID, " _
        '                                                & "T0.fldItemCode, " _
        '                                                & "T0.fldLotSize, " _
        '                                                & "T0.fldDefect, " _
        '                                                & "T0.fldPolymer, " _
        '                                                & "T0.fldGrade, " _
        '                                                & "T0.fldNoOfCav, " _
        '                                                & "T0.fldPartsGperPC, " _
        '                                                & "T0.fldRunnerGPerShot, " _
        '                                                & "T0.fldResinCost, " _
        '                                                & "T0.fldRecycleRatio, " _
        '                                                & "T0.fldRecycleCost, " _
        '                                                & "T0.fldCycleTime, " _
        '                                                & "T0.fldMH, " _
        '                                                & "T0.fldMT, " _
        '                                                & "T0.fldPurgeLossGPerLot, " _
        '                                                & "T0.fldInitialDisposal, " _
        '                                                & "T0.fldQCSample, " _
        '                                                & "T0.fldChangeModelMin, " _
        '                                                & "T0.fldAvailOA, " _
        '                                                & "T1.fldPartName " _
        '                                                & "FROM tblCostTableIM T0 " _
        '                                                & "LEFT JOIN tblItemMasterData T1 ON T1.fldItemCode = (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldItemCode LIMIT 1) " _
        '                                                & "")

        'gvData.DataSource = myData


    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting

        If e.CellElement.ColumnInfo.FieldName = "fldLotSize" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldDefect" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldPolymer" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldGrade" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldNoOfCav" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldPartsGperPC" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldRunnerGPerShot" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldResinCost" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldRecycleRatio" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldRecycleCost" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldCycleTime" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldMH" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldMT" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldPurgeLossGPerLot" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldInitialDisposal" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldQCSample" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldChangeModelMin" OrElse
           e.CellElement.ColumnInfo.FieldName = "fldAvailOA" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.SkyBlue

        ElseIf e.CellElement.ColumnInfo.FieldName = "matCostJPYperPcs" OrElse
               e.CellElement.ColumnInfo.FieldName = "PC" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.Yellow

        Else
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

    End Sub

    Private Sub gvData_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellEndEdit

        Try

            Dim fldLotSize As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldLotSize").Value)
            Dim fldDefect As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldDefect").Value)

            Dim fldNoOfCav As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldNoOfCav").Value)
            Dim fldPartsGperPC As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldPartsGperPC").Value)
            Dim fldRunnerGPerShot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldRunnerGPerShot").Value)
            Dim fldResinCost As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldResinCost").Value)
            Dim fldRecycleRatio As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldRecycleRatio").Value)
            Dim fldRecycleCost As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldRecycleCost").Value)
            Dim fldCycleTime As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldCycleTime").Value)
            Dim fldMH As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldMH").Value)
            Dim fldMT As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldMT").Value)
            Dim fldPurgeLossGPerLot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldPurgeLossGPerLot").Value)
            Dim fldInitialDisposal As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldInitialDisposal").Value)
            Dim fldQCSample As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldQCSample").Value)
            Dim fldChangeModelMin As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldChangeModelMin").Value)

            Dim ShotsPerLot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("ShotsPerLot").Value)

            gvData.CurrentRow.Cells("purgePercent").Value = ShotsPerLot * fldNoOfCav / fldLotSize
            Dim purgePercent As Double = Convert.ToDouble(gvData.CurrentRow.Cells("purgePercent").Value)

            gvData.CurrentRow.Cells("disposalPercent").Value = (fldInitialDisposal + fldQCSample) * fldNoOfCav / fldLotSize
            Dim disposalPercent As Double = Convert.ToDouble(gvData.CurrentRow.Cells("disposalPercent").Value)

            gvData.CurrentRow.Cells("consumptionGShot").Value = fldPartsGperPC * fldNoOfCav + fldRunnerGPerShot
            Dim consumptionGShot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("consumptionGShot").Value)

            gvData.CurrentRow.Cells("prdnShotsSnorPerLot").Value = (fldLotSize / (1 - fldDefect) + fldInitialDisposal + fldQCSample) / fldNoOfCav
            Dim prdnShotsSnorPerLot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("prdnShotsSnorPerLot").Value)

            gvData.CurrentRow.Cells("consumptionGPerPc").Value = (prdnShotsSnorPerLot * consumptionGShot + fldPurgeLossGPerLot) / fldLotSize
            Dim consumptionGPerPc As Double = Convert.ToDouble(gvData.CurrentRow.Cells("consumptionGPerPc").Value)

            If fldRecycleRatio = 0 Then
                gvData.CurrentRow.Cells("disposalCostJPYPerKg").Value = 17.6
            Else
                gvData.CurrentRow.Cells("disposalCostJPYPerKg").Value = 0
            End If

            Dim disposalCostJPYPerKg As Double = Convert.ToDouble(gvData.CurrentRow.Cells("disposalCostJPYPerKg").Value)

            gvData.CurrentRow.Cells("JPYPerPc").Value = (consumptionGPerPc - fldPartsGperPC) * disposalCostJPYPerKg / 1000
            Dim JPYPerPc As Double = Convert.ToDouble(gvData.CurrentRow.Cells("JPYPerPc").Value)

            gvData.CurrentRow.Cells("matCostJPYperPcs").Value = consumptionGPerPc * (1 - fldRecycleRatio) * fldResinCost / 1000 + consumptionGPerPc * fldRecycleRatio * fldRecycleCost / 1000 + JPYPerPc
            Dim matCostJPYperPcs As Double = Convert.ToDouble(gvData.CurrentRow.Cells("matCostJPYperPcs").Value)

            gvData.CurrentRow.Cells("PC").Value = fldCycleTime / fldNoOfCav * (fldMT + fldMT) / (1 - disposalPercent - fldDefect) / 3600
            Dim PC As Double = Convert.ToDouble(gvData.CurrentRow.Cells("PC").Value)

            gvData.CurrentRow.Cells("ShotsPerLot").Value = fldPurgeLossGPerLot / consumptionGShot
            'Dim ShotsPerLot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("ShotsPerLot").Value)

            gvData.CurrentRow.Cells("totalGPerLot").Value = (fldInitialDisposal + fldQCSample) * consumptionGShot
            Dim totalGPerLot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("totalGPerLot").Value)


            'gvData.CurrentRow.Cells("availability").Value = 


        Catch ex As Exception
            'RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub
End Class
