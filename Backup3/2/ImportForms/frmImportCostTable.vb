Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class frmImportCostTable
    Private Sub frmImportCostTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldStatColumn As New GridViewTextBoxColumn("Status")
        fldStatColumn.FieldName = "STATUS"
        fldStatColumn.Width = 60
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.ReadOnly = True
        fldStatColumn.IsPinned = True
        fldStatColumn.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldStatColumn)

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
        fldPartName.Width = 180
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

        Dim fldWarningColumn As New GridViewTextBoxColumn("Warning")
        fldWarningColumn.FieldName = "fldWarning"
        fldWarningColumn.Width = 120
        fldWarningColumn.ReadOnly = True
        gvData.Columns.Add(fldWarningColumn)

        gvData.ReadOnly = True
        gvData.EnableSorting = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False
        gvData.AllowAddNewRow = False
        gvData.ShowFilteringRow = False
        gvData.EnableFiltering = False
        gvData.EnableGrouping = False
        gvData.ShowGroupPanel = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False
        gvData.ShowRowHeaderColumn = False
        gvData.AllowAutoSizeColumns = True
        gvData.MultiSelect = True
        gvData.AllowDeleteRow = True

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click

        Try

            gvData.DataSource = Nothing

            Dim table As DataTable = Slipknot.getClipboard

            Dim joinResult As IEnumerable = (From T0 In table.AsEnumerable()
                                             Select New With
                                             {
                                              .fldProcessCode = T0.Item(0),
                                              .fldItemCode = T0.Item(1),
                                              .fldLotSize = T0.Item(2),
                                              .fldDefect = T0.Item(3),
                                              .fldPolymer = T0.Item(4),
                                              .fldGrade = T0.Item(5),
                                              .fldNoOfCav = T0.Item(6),
                                              .fldPartsGperPC = T0.Item(7),
                                              .fldRunnerGPerShot = T0.Item(8),
                                              .fldResinCost = T0.Item(9),
                                              .fldRecycleRatio = T0.Item(10),
                                              .fldRecycleCost = T0.Item(11),
                                              .fldCycleTime = T0.Item(12),
                                              .fldPurgeLossGPerLot = T0.Item(13),
                                              .fldInitialDisposal = T0.Item(14),
                                              .fldQCSample = T0.Item(15),
                                              .fldChangeModelMin = T0.Item(16),
                                              .fldAvailOA = T0.Item(17),
                                              .fldPartName = getPartName(.fldItemCode),
                                              .fldWarning = validateRow(Convert.ToString(.fldItemCode), Convert.ToString(.fldProcessCode))
                                             }).ToList

            gvData.DataSource = joinResult

            countError()

        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        compute()

    End Sub

    Function checkItemCode(ByVal itemCode As String) As Boolean

        Dim good As Boolean = False

        If itemCode = "Assy Cost" Then
            good = True
        Else

            Dim getCode As DataRow

            getCode = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblItemMasterData WHERE fldItemCode = '" & itemCode & "' LIMIT 1")

            If getCode Is Nothing Then
                getCode = Slipknot.rowSelectManual("SELECT fldNewItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & itemCode & "' LIMIT 1")
            End If

            If getCode IsNot Nothing Then
                good = True
            Else
                good = False
            End If

        End If

        Return good
    End Function

    Function checkNG(ByVal itemCodeOk1 As Boolean, ByVal itemCodeOk2 As Boolean) As String

        If itemCodeOk1 = False Or itemCodeOk2 = False Then
            Return "NG"

            Exit Function
        End If

        Return String.Empty

    End Function

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString

    End Sub

    Private Sub compute()

        For Each row As GridViewRowInfo In gvData.Rows

            Try

                Dim fldLotSize As Double = Convert.ToDouble(row.Cells("fldLotSize").Value)
                Dim fldDefect As Double = Convert.ToDouble(row.Cells("fldDefect").Value)

                Dim fldNoOfCav As Double = Convert.ToDouble(row.Cells("fldNoOfCav").Value)
                Dim fldPartsGperPC As Double = Convert.ToDouble(row.Cells("fldPartsGperPC").Value)
                Dim fldRunnerGPerShot As Double = Convert.ToDouble(row.Cells("fldRunnerGPerShot").Value)
                Dim fldResinCost As Double = Convert.ToDouble(row.Cells("fldResinCost").Value)
                Dim fldRecycleRatio As Double = Convert.ToDouble(row.Cells("fldRecycleRatio").Value)
                Dim fldRecycleCost As Double = Convert.ToDouble(row.Cells("fldRecycleCost").Value)
                Dim fldCycleTime As Double = Convert.ToDouble(row.Cells("fldCycleTime").Value)
                Dim fldMH As Double = Convert.ToDouble(row.Cells("fldMH").Value)
                Dim fldMT As Double = Convert.ToDouble(row.Cells("fldMT").Value)
                Dim fldPurgeLossGPerLot As Double = Convert.ToDouble(row.Cells("fldPurgeLossGPerLot").Value)
                Dim fldInitialDisposal As Double = Convert.ToDouble(row.Cells("fldInitialDisposal").Value)
                Dim fldQCSample As Double = Convert.ToDouble(row.Cells("fldQCSample").Value)
                Dim fldChangeModelMin As Double = Convert.ToDouble(row.Cells("fldChangeModelMin").Value)

                Dim fldShotsPerLot As Double = Convert.ToDouble(row.Cells("fldShotsPerLot").Value)

                row.Cells("fldPurgePercent").Value = fldShotsPerLot * fldNoOfCav / fldLotSize
                Dim fldPurgePercent As Double = Convert.ToDouble(row.Cells("fldPurgePercent").Value)

                row.Cells("fldDisposalPercent").Value = (fldInitialDisposal + fldQCSample) * fldNoOfCav / fldLotSize
                Dim fldDisposalPercent As Double = Convert.ToDouble(row.Cells("fldDisposalPercent").Value)

                row.Cells("fldConsumptionGPerShot").Value = fldPartsGperPC * fldNoOfCav + fldRunnerGPerShot
                Dim fldConsumptionGPerShot As Double = Convert.ToDouble(row.Cells("fldConsumptionGPerShot").Value)

                row.Cells("fldPrdnShotsGPerShot").Value = (fldLotSize / (1 - fldDefect) + fldInitialDisposal + fldQCSample) / fldNoOfCav
                Dim fldPrdnShotsGPerShot As Double = Convert.ToDouble(row.Cells("fldPrdnShotsGPerShot").Value)

                row.Cells("fldConsumptionGPerPc").Value = (fldPrdnShotsGPerShot * fldConsumptionGPerShot + fldPurgeLossGPerLot) / fldLotSize
                Dim fldConsumptionGPerPc As Double = Convert.ToDouble(row.Cells("fldConsumptionGPerPc").Value)

                If fldRecycleRatio = 0 Then
                    row.Cells("fldDisposalCostJPYPerKg").Value = 17.6
                Else
                    row.Cells("fldDisposalCostJPYPerKg").Value = 0
                End If

                Dim fldDisposalCostJPYPerKg As Double = Convert.ToDouble(row.Cells("fldDisposalCostJPYPerKg").Value)

                row.Cells("fldJPYPerPc").Value = (fldConsumptionGPerPc - fldPartsGperPC) * fldDisposalCostJPYPerKg / 1000
                Dim fldJPYPerPc As Double = Convert.ToDouble(row.Cells("fldJPYPerPc").Value)

                row.Cells("fldMaterialCostJPYPerPcs").Value = fldConsumptionGPerPc * (1 - fldRecycleRatio) * fldResinCost / 1000 + fldConsumptionGPerPc * fldRecycleRatio * fldRecycleCost / 1000 + fldJPYPerPc
                Dim fldMaterialCostJPYPerPcs As Double = Convert.ToDouble(row.Cells("fldMaterialCostJPYPerPcs").Value)

                row.Cells("fldPcJPYPerPc").Value = fldCycleTime / fldNoOfCav * (fldMT + fldMH) / (1 - fldDisposalPercent - fldDefect) / 3600
                Dim fldPcJPYPerPc As Double = Convert.ToDouble(row.Cells("fldPcJPYPerPc").Value)

                row.Cells("fldShotsPerLot").Value = fldPurgeLossGPerLot / fldConsumptionGPerShot

                row.Cells("fldTotalGPerLot").Value = (fldInitialDisposal + fldQCSample) * fldConsumptionGPerShot
                Dim fldTotalGPerLot As Double = Convert.ToDouble(row.Cells("fldTotalGPerLot").Value)

            Catch ex As Exception
                'RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try

        Next

    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you want to delete " & gvData.SelectedRows.Count & " selected row(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}
            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1
                Me.gvData.Rows.Remove(rows(i))
            Next

            countError()
        End If
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click

        If RadMessageBox.Show("Are you sure you want to clear the list?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            gvData.DataSource = Nothing

            countError()
        End If

    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting

        If e.CellElement.ColumnInfo.FieldName = "STATUS" Then

            If Convert.ToString(e.CellElement.RowInfo.Cells("STATUS").Value) = "OK" Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.LimeGreen
                e.CellElement.Font = New Font("Arial", 10, FontStyle.Bold)
            ElseIf Convert.ToString(e.CellElement.RowInfo.Cells("STATUS").Value) = "NG" Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.Red
                e.CellElement.Font = New Font("Arial", 10, FontStyle.Bold)
            Else
                e.CellElement.DrawFill = False
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            End If

        Else

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

        End If

    End Sub

    Private lineNo As Integer
    Private lineStat As String
    Private Sub bwSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwSave.DoWork
        aedType = 1

        Dim fldItemCode As String
        Dim fldProcessCode As String
        Dim fldLotSize As Decimal
        Dim fldPurgePercent As Decimal
        Dim fldDisposalPercent As Decimal
        Dim fldDefect As Decimal
        Dim fldPolymer As String
        Dim fldGrade As String
        Dim fldNoOfCav As Decimal
        Dim fldPartsGperPC As Decimal
        Dim fldRunnerGPerShot As Decimal
        Dim fldConsumptionGPerShot As Decimal
        Dim fldPrdnShotsGPerShot As Decimal
        Dim fldConsumptionGPerPc As Decimal
        Dim fldResinCost As Decimal
        Dim fldRecycleRatio As Decimal
        Dim fldRecycleCost As Decimal
        Dim fldDisposalCostJPYPerKg As Decimal
        Dim fldJPYPerPc As Decimal
        Dim fldMaterialCostJPYPerPcs As Decimal
        Dim fldCycleTime As Decimal
        Dim fldMH As Decimal
        Dim fldMT As Decimal
        Dim fldPcJPYPerPc As Decimal
        Dim fldPurgeLossGPerLot As Decimal
        Dim fldShotsPerLot As Decimal
        Dim fldInitialDisposal As Decimal
        Dim fldQCSample As Decimal
        Dim fldTotalGPerLot As Decimal
        Dim fldChangeModelMin As Decimal
        Dim fldAvailOA As Decimal

        For counter As Integer = 0 To gvData.Rows.Count - 1

            errorMessage = Nothing

            If Convert.ToString(gvData.Rows(counter).Cells("fldWarning").Value) = String.Empty Then

                fldItemCode = Convert.ToString(gvData.Rows(counter).Cells("fldItemCode").Value)
                fldProcessCode = Convert.ToString(gvData.Rows(counter).Cells("fldProcessCode").Value)
                fldLotSize = Convert.ToDecimal(gvData.Rows(counter).Cells("fldLotSize").Value)
                fldPurgePercent = Convert.ToDecimal(gvData.Rows(counter).Cells("fldPurgePercent").Value)
                fldDisposalPercent = Convert.ToDecimal(gvData.Rows(counter).Cells("fldDisposalPercent").Value)
                fldDefect = Convert.ToDecimal(gvData.Rows(counter).Cells("fldDefect").Value)
                fldPolymer = Convert.ToString(gvData.Rows(counter).Cells("fldPolymer").Value)
                fldGrade = Convert.ToString(gvData.Rows(counter).Cells("fldGrade").Value)
                fldNoOfCav = Convert.ToDecimal(gvData.Rows(counter).Cells("fldNoOfCav").Value)
                fldPartsGperPC = Convert.ToDecimal(gvData.Rows(counter).Cells("fldPartsGperPC").Value)
                fldRunnerGPerShot = Convert.ToDecimal(gvData.Rows(counter).Cells("fldRunnerGPerShot").Value)
                fldConsumptionGPerShot = Convert.ToDecimal(gvData.Rows(counter).Cells("fldConsumptionGPerShot").Value)
                fldPrdnShotsGPerShot = Convert.ToDecimal(gvData.Rows(counter).Cells("fldPrdnShotsGPerShot").Value)
                fldConsumptionGPerPc = Convert.ToDecimal(gvData.Rows(counter).Cells("fldConsumptionGPerPc").Value)
                fldResinCost = Convert.ToDecimal(gvData.Rows(counter).Cells("fldResinCost").Value)
                fldRecycleRatio = Convert.ToDecimal(gvData.Rows(counter).Cells("fldRecycleRatio").Value)
                fldRecycleCost = Convert.ToDecimal(gvData.Rows(counter).Cells("fldRecycleCost").Value)
                fldDisposalCostJPYPerKg = Convert.ToDecimal(gvData.Rows(counter).Cells("fldDisposalCostJPYPerKg").Value)
                fldJPYPerPc = Convert.ToDecimal(gvData.Rows(counter).Cells("fldJPYPerPc").Value)
                fldMaterialCostJPYPerPcs = Convert.ToDecimal(gvData.Rows(counter).Cells("fldMaterialCostJPYPerPcs").Value)
                fldCycleTime = Convert.ToDecimal(gvData.Rows(counter).Cells("fldCycleTime").Value)
                fldMH = Convert.ToDecimal(gvData.Rows(counter).Cells("fldMH").Value)
                fldMT = Convert.ToDecimal(gvData.Rows(counter).Cells("fldMT").Value)
                fldPcJPYPerPc = Convert.ToDecimal(gvData.Rows(counter).Cells("fldPcJPYPerPc").Value)
                fldPurgeLossGPerLot = Convert.ToDecimal(gvData.Rows(counter).Cells("fldPurgeLossGPerLot").Value)
                fldShotsPerLot = Convert.ToDecimal(gvData.Rows(counter).Cells("fldShotsPerLot").Value)
                fldInitialDisposal = Convert.ToDecimal(gvData.Rows(counter).Cells("fldInitialDisposal").Value)
                fldQCSample = Convert.ToDecimal(gvData.Rows(counter).Cells("fldQCSample").Value)
                fldTotalGPerLot = Convert.ToDecimal(gvData.Rows(counter).Cells("fldTotalGPerLot").Value)
                fldChangeModelMin = Convert.ToDecimal(gvData.Rows(counter).Cells("fldChangeModelMin").Value)
                fldAvailOA = Convert.ToDecimal(gvData.Rows(counter).Cells("fldAvailOA").Value)

                Slipknot.addParameter("parItemCode", fldItemCode)
                Slipknot.addParameter("parProcessCode", fldProcessCode)
                Slipknot.addParameter("parLotSize", fldLotSize)
                Slipknot.addParameter("parPurgePercent", fldPurgePercent)
                Slipknot.addParameter("parDisposalPercent", fldDisposalPercent)
                Slipknot.addParameter("parDefect", fldDefect)
                Slipknot.addParameter("parPolymer", fldPolymer)
                Slipknot.addParameter("parGrade", fldGrade)
                Slipknot.addParameter("parNoOfCav", fldNoOfCav)
                Slipknot.addParameter("parPartsGperPC", fldPartsGperPC)
                Slipknot.addParameter("parRunnerGPerShot", fldRunnerGPerShot)
                Slipknot.addParameter("parConsumptionGPerShot", fldConsumptionGPerShot)
                Slipknot.addParameter("parPrdnShotsGPerShot", fldPrdnShotsGPerShot)
                Slipknot.addParameter("parConsumptionGPerPc", fldConsumptionGPerPc)
                Slipknot.addParameter("parResinCost", fldResinCost)
                Slipknot.addParameter("parRecycleRatio", fldRecycleRatio)
                Slipknot.addParameter("parRecycleCost", fldRecycleCost)
                Slipknot.addParameter("parDisposalCostJPYPerKg", fldDisposalCostJPYPerKg)
                Slipknot.addParameter("parJPYPerPc", fldJPYPerPc)
                Slipknot.addParameter("parMaterialCostJPYPerPcs", fldMaterialCostJPYPerPcs)
                Slipknot.addParameter("parCycleTime", fldCycleTime)
                Slipknot.addParameter("parMH", fldMH)
                Slipknot.addParameter("parMT", fldMT)
                Slipknot.addParameter("parPcJPYPerPc", fldPcJPYPerPc)
                Slipknot.addParameter("parPurgeLossGPerLot", fldPurgeLossGPerLot)
                Slipknot.addParameter("parShotsPerLot", fldShotsPerLot)
                Slipknot.addParameter("parInitialDisposal", fldInitialDisposal)
                Slipknot.addParameter("parQCSample", fldQCSample)
                Slipknot.addParameter("parTotalGPerLot", fldTotalGPerLot)
                Slipknot.addParameter("parChangeModelMin", fldChangeModelMin)
                Slipknot.addParameter("parAvailOA", fldAvailOA)

                If Slipknot.dbAED("SP_UpdateCostTableIM") Then
                    lineStat = "OK"
                Else
                    lineStat = "NG"
                End If

            Else
                lineStat = "NG"
            End If

            Dim percent As Double = counter / gvData.Rows.Count * 100
            lineNo = counter
            RadProgressBarElement1.Text = "Saving..."
            bwSave.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(50)

        Next

    End Sub

    Private Sub bwSave_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwSave.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = lineStat
        gvData.CurrentRow.Cells("fldWarning").Value = errorMessage

        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwSave_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwSave.RunWorkerCompleted
        RadProgressBarElement1.Value1 = 100
        RadProgressBarElement1.Text = "Done"

        countError()
    End Sub

    Private Sub countError()

        lblError.Text = String.Empty

        Dim err As Integer = 0

        For Each row As GridViewRowInfo In gvData.Rows
            If Convert.ToString(row.Cells("STATUS").Value) = "NG" Then
                err = err + 1
            End If
        Next

        If err > 0 Then
            lblError.Text = "There are " & err & " error(s) in grid, fixing is recommended before you proceed"
        End If

    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click
        If bwSave.IsBusy = False Then
            If RadMessageBox.Show("Are you sure want to upload the data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                bwSave.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Function getPartName(ByVal itemCode As String) As String

        getPartName = Nothing

        Dim row As DataRow = Slipknot.rowSelectManual("SELECT fldPartName FROM tblItemMasterData WHERE fldItemCode = '" & itemCode & "' ")

        If row IsNot Nothing Then
            getPartName = Convert.ToString(row.Item("fldPartName"))
        End If

        Return getPartName
    End Function

    Private Function validateRow(ByVal itemCode As String, ByVal processCode As String) As String

        validateRow = String.Empty

        Dim itemCodeRow As DataRow = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblItemMasterData WHERE fldItemCode = '" & itemCode & "' ")
        Dim processCodeRow As DataRow = Slipknot.rowSelectManual("SELECT fldCode FROM tblProcess WHERE fldCode = '" & processCode & "' ")

        If itemCodeRow Is Nothing Then
            validateRow = "Item code not found in master list"
        End If

        If itemCodeRow Is Nothing Then
            validateRow = "Process code not found in master list"
        End If

        If itemCodeRow Is Nothing And processCode Is Nothing Then
            validateRow = "Item code and process code not found in list"
        End If

        Return validateRow
    End Function

    Private Sub gvData_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles gvData.RowFormatting

        If Convert.ToString(e.RowElement.RowInfo.Cells("fldWarning").Value) <> String.Empty Then
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.Red
        Else
            e.RowElement.DrawFill = False
            e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
        End If

    End Sub
End Class
