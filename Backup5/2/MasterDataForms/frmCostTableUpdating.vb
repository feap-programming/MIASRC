
Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmCostTableUpdating
    Private Sub FrmCostTableUpdating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadProcess()
    End Sub

    Private Sub readyGridIM()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.ReadOnly = True
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldProcessCode As New GridViewTextBoxColumn("Process Code")
        fldProcessCode.FieldName = "fldProcessCode"
        fldProcessCode.ReadOnly = True
        fldProcessCode.Width = 100
        gvData.Columns.Add(fldProcessCode)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 80
        fldItemCode.WrapText = True
        fldItemCode.ReadOnly = True
        gvData.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name")
        fldPartName.FieldName = "fldPartName"
        fldPartName.WrapText = True
        fldPartName.Width = 150
        fldPartName.ReadOnly = True
        gvData.Columns.Add(fldPartName)

        Dim fldLotSize As New GridViewDecimalColumn("Lot Size") 'Manual Input
        fldLotSize.FieldName = "fldLotSize"
        fldLotSize.Width = 70
        fldLotSize.WrapText = True
        fldLotSize.ShowUpDownButtons = False
        gvData.Columns.Add(fldLotSize)
        gvData.Columns("fldLotSize").FormatString = "{0:N2}"

        Dim fldPurgePercent As New GridViewDecimalColumn("Purge (%)")
        fldPurgePercent.FieldName = "fldPurgePercent"
        fldPurgePercent.Width = 80
        fldPurgePercent.WrapText = True
        fldPurgePercent.ReadOnly = True
        fldPurgePercent.ShowUpDownButtons = False
        gvData.Columns.Add(fldPurgePercent)
        gvData.Columns("fldPurgePercent").FormatString = "{0:P2}"

        Dim fldDisposalPercent As New GridViewDecimalColumn("Disposal (%)")
        fldDisposalPercent.FieldName = "fldDisposalPercent"
        fldDisposalPercent.Width = 80
        fldDisposalPercent.WrapText = True
        fldDisposalPercent.ReadOnly = True
        fldDisposalPercent.ShowUpDownButtons = False
        gvData.Columns.Add(fldDisposalPercent)
        gvData.Columns("fldDisposalPercent").FormatString = "{0:P2}"

        Dim fldDefect As New GridViewDecimalColumn("Defect (%)") 'Manual Input
        fldDefect.FieldName = "fldDefect"
        fldDefect.Width = 80
        fldDefect.WrapText = True
        fldDefect.DecimalPlaces = 5
        fldDefect.ShowUpDownButtons = False
        gvData.Columns.Add(fldDefect)
        gvData.Columns("fldDefect").FormatString = "{0:P2}"

        Dim fldPolymer As New GridViewTextBoxColumn("Polymer") 'Manual Input
        fldPolymer.FieldName = "fldPolymer"
        fldPolymer.WrapText = True
        fldPolymer.Width = 80
        gvData.Columns.Add(fldPolymer)

        Dim fldGrade As New GridViewTextBoxColumn("Grade") 'Manual Input
        fldGrade.FieldName = "fldGrade"
        fldGrade.Width = 80
        fldGrade.WrapText = True
        gvData.Columns.Add(fldGrade)

        Dim fldNoOfCav As New GridViewDecimalColumn("No. of Cavity") 'Manual Input
        fldNoOfCav.FieldName = "fldNoOfCav"
        fldNoOfCav.Width = 80
        fldNoOfCav.WrapText = True
        fldNoOfCav.ShowUpDownButtons = False
        gvData.Columns.Add(fldNoOfCav)
        gvData.Columns("fldNoOfCav").FormatString = "{0:N2}"

        Dim fldPartsGperPC As New GridViewDecimalColumn("Parts g/pc") 'Manual Input
        fldPartsGperPC.FieldName = "fldPartsGperPC"
        fldPartsGperPC.Width = 80
        fldPartsGperPC.WrapText = True
        fldPartsGperPC.ShowUpDownButtons = False
        gvData.Columns.Add(fldPartsGperPC)
        gvData.Columns("fldPartsGperPC").FormatString = "{0:N2}"

        Dim fldRunnerGPerShot As New GridViewDecimalColumn("Runner g/shot") 'Manual Input
        fldRunnerGPerShot.FieldName = "fldRunnerGPerShot"
        fldRunnerGPerShot.Width = 80
        fldRunnerGPerShot.WrapText = True
        fldRunnerGPerShot.ShowUpDownButtons = False
        gvData.Columns.Add(fldRunnerGPerShot)
        gvData.Columns("fldRunnerGPerShot").FormatString = "{0:N2}"

        Dim fldConsumptionGPerShot As New GridViewDecimalColumn("Consumption g/shot")
        fldConsumptionGPerShot.FieldName = "fldConsumptionGPerShot"
        fldConsumptionGPerShot.Width = 100
        fldConsumptionGPerShot.WrapText = True
        fldConsumptionGPerShot.ReadOnly = True
        gvData.Columns.Add(fldConsumptionGPerShot)
        gvData.Columns("fldConsumptionGPerShot").FormatString = "{0:N2}"

        Dim fldPrdnShotsGPerShot As New GridViewDecimalColumn("Prdn Shots shots/Lot")
        fldPrdnShotsGPerShot.FieldName = "fldPrdnShotsGPerShot"
        fldPrdnShotsGPerShot.Width = 100
        fldPrdnShotsGPerShot.WrapText = True
        fldPrdnShotsGPerShot.ReadOnly = True
        gvData.Columns.Add(fldPrdnShotsGPerShot)
        gvData.Columns("fldPrdnShotsGPerShot").FormatString = "{0:N2}"

        Dim fldConsumptionGPerPc As New GridViewDecimalColumn("Consumption g/pc")
        fldConsumptionGPerPc.FieldName = "fldConsumptionGPerPc"
        fldConsumptionGPerPc.Width = 100
        fldConsumptionGPerPc.WrapText = True
        fldConsumptionGPerPc.ReadOnly = True
        gvData.Columns.Add(fldConsumptionGPerPc)
        gvData.Columns("fldConsumptionGPerPc").FormatString = "{0:N2}"

        Dim fldResinCost As New GridViewDecimalColumn("Resin Cost JPY/Kg") 'Manual Input
        fldResinCost.FieldName = "fldResinCost"
        fldResinCost.Width = 100
        fldResinCost.WrapText = True
        fldResinCost.ShowUpDownButtons = False
        gvData.Columns.Add(fldResinCost)
        gvData.Columns("fldResinCost").FormatString = "{0:N2}"

        Dim fldRecycleRatio As New GridViewDecimalColumn("Recycle Ratio %") 'Manual Input
        fldRecycleRatio.FieldName = "fldRecycleRatio"
        fldRecycleRatio.Width = 100
        fldRecycleRatio.WrapText = True
        fldRecycleRatio.DecimalPlaces = 5
        fldRecycleRatio.ShowUpDownButtons = False
        gvData.Columns.Add(fldRecycleRatio)
        gvData.Columns("fldRecycleRatio").FormatString = "{0:P2}"

        Dim fldRecycleCost As New GridViewDecimalColumn("Recycle Cost") 'Manual Input
        fldRecycleCost.FieldName = "fldRecycleCost"
        fldRecycleCost.Width = 80
        fldRecycleCost.WrapText = True
        fldRecycleCost.ShowUpDownButtons = False
        gvData.Columns.Add(fldRecycleCost)
        gvData.Columns("fldRecycleCost").FormatString = "{0:N2}"

        Dim fldDisposalCostJPYPerKg As New GridViewDecimalColumn("Disposal Cost JPY/Kg")
        fldDisposalCostJPYPerKg.FieldName = "fldDisposalCostJPYPerKg"
        fldDisposalCostJPYPerKg.Width = 110
        fldDisposalCostJPYPerKg.WrapText = True
        fldDisposalCostJPYPerKg.ReadOnly = True
        gvData.Columns.Add(fldDisposalCostJPYPerKg)
        gvData.Columns("fldDisposalCostJPYPerKg").FormatString = "{0:N2}"

        Dim fldJPYPerPc As New GridViewDecimalColumn("JPY/pc")
        fldJPYPerPc.FieldName = "fldJPYPerPc"
        fldJPYPerPc.Width = 70
        fldJPYPerPc.WrapText = True
        fldJPYPerPc.ReadOnly = True
        gvData.Columns.Add(fldJPYPerPc)
        gvData.Columns("fldJPYPerPc").FormatString = "{0:N2}"

        Dim fldMaterialCostJPYPerPcs As New GridViewDecimalColumn("Material Cost (JPY/pcs)")
        fldMaterialCostJPYPerPcs.FieldName = "fldMaterialCostJPYPerPcs"
        fldMaterialCostJPYPerPcs.Width = 130
        fldMaterialCostJPYPerPcs.WrapText = True
        fldMaterialCostJPYPerPcs.ReadOnly = True
        gvData.Columns.Add(fldMaterialCostJPYPerPcs)
        gvData.Columns("fldMaterialCostJPYPerPcs").FormatString = "{0:N2}"

        Dim fldCycleTime As New GridViewDecimalColumn("Cycle Time") 'Manual Input
        fldCycleTime.FieldName = "fldCycleTime"
        fldCycleTime.Width = 80
        fldCycleTime.WrapText = True
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

        Dim fldPcJPYPerPc As New GridViewDecimalColumn("PC (JPY/pc)")
        fldPcJPYPerPc.FieldName = "fldPcJPYPerPc"
        fldPcJPYPerPc.Width = 70
        fldPcJPYPerPc.WrapText = True
        fldPcJPYPerPc.ShowUpDownButtons = False
        fldPcJPYPerPc.ReadOnly = True
        gvData.Columns.Add(fldPcJPYPerPc)
        gvData.Columns("fldPcJPYPerPc").FormatString = "{0:N2}"

        Dim fldPurgeLossGPerLot As New GridViewDecimalColumn("Purge Loss G/Lot") 'Manual Input
        fldPurgeLossGPerLot.FieldName = "fldPurgeLossGPerLot"
        fldPurgeLossGPerLot.Width = 100
        fldPurgeLossGPerLot.WrapText = True
        fldPurgeLossGPerLot.ShowUpDownButtons = False
        gvData.Columns.Add(fldPurgeLossGPerLot)
        gvData.Columns("fldPurgeLossGPerLot").FormatString = "{0:N2}"

        Dim fldShotsPerLot As New GridViewDecimalColumn("Shots per Lot")
        fldShotsPerLot.FieldName = "fldShotsPerLot"
        fldShotsPerLot.Width = 90
        fldShotsPerLot.WrapText = True
        fldShotsPerLot.ReadOnly = True
        fldShotsPerLot.ShowUpDownButtons = False
        gvData.Columns.Add(fldShotsPerLot)
        gvData.Columns("fldShotsPerLot").FormatString = "{0:N2}"

        Dim fldInitialDisposal As New GridViewDecimalColumn("Initial Disposal Shots/Lot") 'Manual Input
        fldInitialDisposal.FieldName = "fldInitialDisposal"
        fldInitialDisposal.WrapText = True
        fldInitialDisposal.Width = 130
        fldInitialDisposal.ShowUpDownButtons = False
        gvData.Columns.Add(fldInitialDisposal)
        gvData.Columns("fldInitialDisposal").FormatString = "{0:N2}"

        Dim fldQCSample As New GridViewDecimalColumn("QC Sample Shots/Lot") 'Manual Input
        fldQCSample.FieldName = "fldQCSample"
        fldQCSample.Width = 110
        fldQCSample.WrapText = True
        fldQCSample.ShowUpDownButtons = False
        gvData.Columns.Add(fldQCSample)
        gvData.Columns("fldQCSample").FormatString = "{0:N2}"

        Dim fldTotalGPerLot As New GridViewDecimalColumn("Total G/Lot")
        fldTotalGPerLot.FieldName = "fldTotalGPerLot"
        fldTotalGPerLot.Width = 110
        fldTotalGPerLot.WrapText = True
        fldTotalGPerLot.ReadOnly = True
        fldTotalGPerLot.ShowUpDownButtons = False
        gvData.Columns.Add(fldTotalGPerLot)
        gvData.Columns("fldTotalGPerLot").FormatString = "{0:N2}"

        Dim fldChangeModelMin As New GridViewDecimalColumn("Change Model Min") 'Manual Input
        fldChangeModelMin.FieldName = "fldChangeModelMin"
        fldChangeModelMin.Width = 110
        fldChangeModelMin.WrapText = True
        fldChangeModelMin.ShowUpDownButtons = False
        gvData.Columns.Add(fldChangeModelMin)
        gvData.Columns("fldChangeModelMin").FormatString = "{0:N2}"

        Dim availability As New GridViewDecimalColumn("Availability OA (%)") 'Manual Input
        availability.FieldName = "fldAvailOA"
        availability.Width = 110
        availability.WrapText = True
        availability.DecimalPlaces = 5
        availability.ShowUpDownButtons = False
        gvData.Columns.Add(availability)
        gvData.Columns("fldAvailOA").FormatString = "{0:P2}"

        gvData.AllowAddNewRow = False
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.EnableFiltering = True
        gvData.EnableGrouping = True
        gvData.AllowDeleteRow = False
        gvData.AllowDeleteRow = False

    End Sub

    Private Sub loadProcess()

        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllProcess")

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS NAME")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 310
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldProcessName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbProcess.DataSource = dtProcess
        mcbProcess.ValueMember = "fldCode"
        mcbProcess.DisplayMember = "fldProcessName"
        mcbProcess.MultiColumnComboBoxElement.DropDownWidth = 380

        mcbProcess.AutoFilter = True
        mcbProcess.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim processName As New FilterDescriptor()
        processName.PropertyName = "fldProcessName"
        processName.Operator = FilterOperator.Contains
        mcbProcess.EditorControl.MasterTemplate.FilterDescriptors.Add(processName)

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click

        If mcbProcess.SelectedValue IsNot Nothing Then

            'If Convert.ToString(mcbProcess.EditorControl.CurrentRow.Cells("fldProcessName").Value).Contains("INJECTION MOLDING") Then

            gvData.DataSource = Nothing
            gvData.Rows.Clear()
            gvData.Columns.Clear()

            readyGridIM()

            loadCostTableIM()

            'End If

        End If

    End Sub

    Private Sub loadCostTableIM()

        Dim myData As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                        & "T0.fldId, " _
                                                        & "T0.fldCTID, " _
                                                        & "T0.fldItemCode, " _
                                                        & "T0.fldProcessCode, " _
                                                        & "T0.fldLotSize, " _
                                                        & "T0.fldPurgePercent, " _
                                                        & "T0.fldDisposalPercent, " _
                                                        & "T0.fldDefect, " _
                                                        & "T0.fldPolymer, " _
                                                        & "T0.fldGrade, " _
                                                        & "T0.fldNoOfCav, " _
                                                        & "T0.fldPartsGperPC, " _
                                                        & "T0.fldRunnerGPerShot, " _
                                                        & "T0.fldConsumptionGPerShot, " _
                                                        & "T0.fldPrdnShotsGPerShot, " _
                                                        & "T0.fldConsumptionGPerPc, " _
                                                        & "T0.fldResinCost, " _
                                                        & "T0.fldRecycleRatio, " _
                                                        & "T0.fldRecycleCost, " _
                                                        & "T0.fldDisposalCostJPYPerKg, " _
                                                        & "T0.fldJPYPerPc, " _
                                                        & "T0.fldMaterialCostJPYPerPcs, " _
                                                        & "T0.fldCycleTime, " _
                                                        & "T0.fldMH, " _
                                                        & "T0.fldMT, " _
                                                        & "T0.fldPcJPYPerPc, " _
                                                        & "T0.fldPurgeLossGPerLot, " _
                                                        & "T0.fldShotsPerLot, " _
                                                        & "T0.fldInitialDisposal, " _
                                                        & "T0.fldQCSample, " _
                                                        & "T0.fldTotalGPerLot, " _
                                                        & "T0.fldChangeModelMin, " _
                                                        & "T0.fldAvailOA, " _
                                                        & "T1.fldPartName " _
                                                        & "FROM tblCostTableIM T0 " _
                                                        & "LEFT JOIN tblItemMasterData T1 ON T1.fldItemCode = (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldItemCode LIMIT 1) " _
                                                        & "WHERE T0.fldProcessCode = '" & Convert.ToString(mcbProcess.EditorControl.CurrentRow.Cells("fldCode").Value) & "' " _
                                                        & "")

        gvData.DataSource = myData

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

            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = GradientStyles.Solid
            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.SkyBlue

        ElseIf e.CellElement.ColumnInfo.FieldName = "fldMaterialCostJPYPerPcs" OrElse
               e.CellElement.ColumnInfo.FieldName = "fldPcJPYPerPc" Then

            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = GradientStyles.Solid
            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.Yellow

        Else

            e.CellElement.DrawFill = False
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)

        End If

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.ShowFilteringRow = True
        Else
            gvData.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
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

            Dim fldShotsPerLot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldShotsPerLot").Value)

            gvData.CurrentRow.Cells("fldPurgePercent").Value = fldShotsPerLot * fldNoOfCav / fldLotSize
            Dim fldPurgePercent As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldPurgePercent").Value)

            gvData.CurrentRow.Cells("fldDisposalPercent").Value = (fldInitialDisposal + fldQCSample) * fldNoOfCav / fldLotSize
            Dim fldDisposalPercent As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldDisposalPercent").Value)

            gvData.CurrentRow.Cells("fldConsumptionGPerShot").Value = fldPartsGperPC * fldNoOfCav + fldRunnerGPerShot
            Dim fldConsumptionGPerShot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldConsumptionGPerShot").Value)

            gvData.CurrentRow.Cells("fldPrdnShotsGPerShot").Value = (fldLotSize / (1 - fldDefect) + fldInitialDisposal + fldQCSample) / fldNoOfCav
            Dim fldPrdnShotsGPerShot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldPrdnShotsGPerShot").Value)

            gvData.CurrentRow.Cells("fldConsumptionGPerPc").Value = (fldPrdnShotsGPerShot * fldConsumptionGPerShot + fldPurgeLossGPerLot) / fldLotSize
            Dim fldConsumptionGPerPc As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldConsumptionGPerPc").Value)

            If fldRecycleRatio = 0 Then
                gvData.CurrentRow.Cells("fldDisposalCostJPYPerKg").Value = 17.6
            Else
                gvData.CurrentRow.Cells("fldDisposalCostJPYPerKg").Value = 0
            End If

            Dim fldDisposalCostJPYPerKg As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldDisposalCostJPYPerKg").Value)

            gvData.CurrentRow.Cells("fldJPYPerPc").Value = (fldConsumptionGPerPc - fldPartsGperPC) * fldDisposalCostJPYPerKg / 1000
            Dim fldJPYPerPc As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldJPYPerPc").Value)

            gvData.CurrentRow.Cells("fldMaterialCostJPYPerPcs").Value = fldConsumptionGPerPc * (1 - fldRecycleRatio) * fldResinCost / 1000 + fldConsumptionGPerPc * fldRecycleRatio * fldRecycleCost / 1000 + fldJPYPerPc
            Dim fldMaterialCostJPYPerPcs As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldMaterialCostJPYPerPcs").Value)

            gvData.CurrentRow.Cells("fldPcJPYPerPc").Value = fldCycleTime / fldNoOfCav * (fldMT + fldMH) / (1 - fldDisposalPercent - fldDefect) / 3600
            Dim fldPcJPYPerPc As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldPcJPYPerPc").Value)

            gvData.CurrentRow.Cells("fldShotsPerLot").Value = fldPurgeLossGPerLot / fldConsumptionGPerShot
            'Dim ShotsPerLot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("ShotsPerLot").Value)

            gvData.CurrentRow.Cells("fldTotalGPerLot").Value = (fldInitialDisposal + fldQCSample) * fldConsumptionGPerShot
            Dim fldTotalGPerLot As Double = Convert.ToDouble(gvData.CurrentRow.Cells("fldTotalGPerLot").Value)


            'gvData.CurrentRow.Cells("availability").Value = 


        Catch ex As Exception
            'RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click

        For Each row As GridViewRowInfo In gvData.Rows

            Slipknot.addParameter("parItemCode", row.Cells("fldItemCode").Value)
            Slipknot.addParameter("parProcessCode", row.Cells("fldProcessCode").Value)
            Slipknot.addParameter("parLotSize", row.Cells("fldLotSize").Value)
            Slipknot.addParameter("parPurgePercent", row.Cells("fldPurgePercent").Value)
            Slipknot.addParameter("parDisposalPercent", row.Cells("fldDisposalPercent").Value)
            Slipknot.addParameter("parDefect", row.Cells("fldDefect").Value)
            Slipknot.addParameter("parPolymer", row.Cells("fldPolymer").Value)
            Slipknot.addParameter("parGrade", row.Cells("fldGrade").Value)
            Slipknot.addParameter("parNoOfCav", row.Cells("fldNoOfCav").Value)
            Slipknot.addParameter("parPartsGperPC", row.Cells("fldPartsGperPC").Value)
            Slipknot.addParameter("parRunnerGPerShot", row.Cells("fldRunnerGPerShot").Value)
            Slipknot.addParameter("parConsumptionGPerShot", row.Cells("fldConsumptionGPerShot").Value)
            Slipknot.addParameter("parPrdnShotsGPerShot", row.Cells("fldPrdnShotsGPerShot").Value)
            Slipknot.addParameter("parConsumptionGPerPc", row.Cells("fldConsumptionGPerPc").Value)
            Slipknot.addParameter("parResinCost", row.Cells("fldResinCost").Value)
            Slipknot.addParameter("parRecycleRatio", row.Cells("fldRecycleRatio").Value)
            Slipknot.addParameter("parRecycleCost", row.Cells("fldRecycleCost").Value)
            Slipknot.addParameter("parDisposalCostJPYPerKg", row.Cells("fldDisposalCostJPYPerKg").Value)
            Slipknot.addParameter("parJPYPerPc", row.Cells("fldJPYPerPc").Value)
            Slipknot.addParameter("parMaterialCostJPYPerPcs", row.Cells("fldMaterialCostJPYPerPcs").Value)
            Slipknot.addParameter("parCycleTime", row.Cells("fldCycleTime").Value)
            Slipknot.addParameter("parMH", row.Cells("fldMH").Value)
            Slipknot.addParameter("parMT", row.Cells("fldMT").Value)
            Slipknot.addParameter("parPcJPYPerPc", row.Cells("fldPcJPYPerPc").Value)
            Slipknot.addParameter("parPurgeLossGPerLot", row.Cells("fldPurgeLossGPerLot").Value)
            Slipknot.addParameter("parShotsPerLot", row.Cells("fldShotsPerLot").Value)
            Slipknot.addParameter("parInitialDisposal", row.Cells("fldInitialDisposal").Value)
            Slipknot.addParameter("parQCSample", row.Cells("fldQCSample").Value)
            Slipknot.addParameter("parTotalGPerLot", row.Cells("fldTotalGPerLot").Value)
            Slipknot.addParameter("parChangeModelMin", row.Cells("fldChangeModelMin").Value)
            Slipknot.addParameter("parAvailOA", row.Cells("fldAvailOA").Value)

            Slipknot.dbAED("SP_UpdateCostTableIM")

        Next

    End Sub

    Private Sub cbbExport_Click(sender As Object, e As EventArgs) Handles cbbExport.Click

        If gvData.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New Telerik.WinControls.Export.GridViewSpreadStreamExport(Me.gvData)
            spreadStreamExport.HiddenColumnOption = UI.Export.HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = UI.Export.HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New Telerik.WinControls.Export.SpreadStreamExportRenderer())
            End If

        End If

    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub cbbImport_Click(sender As Object, e As EventArgs) Handles cbbImport.Click
        If Slipknot.IsFormOpen(frmImportCostTable) Then
            frmImportCostTable.Focus()
        Else
            If BulletForMyValentine.isRW("fldMDItemPerProcess") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportCostTable.Show(Me)
        End If
    End Sub

End Class
