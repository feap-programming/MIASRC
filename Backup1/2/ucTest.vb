Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class ucTest
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

        Dim topWindow As New ToolWindow
        Dim leftBottomWindow As New ToolWindow
        Dim rightBottomWindow As New ToolWindow
        Dim totalWindow As New ToolWindow
        Dim MTMHwindow As New ToolWindow

        Dim dataGrid As New RadGridView

        For i As Integer = 0 To 0

            topWindow = New ToolWindow
            topWindow.Height = 200
            topWindow.ToolCaptionButtons = ToolStripCaptionButtons.None

            dockMain.DockWindow(topWindow, DockPosition.Top)

            dataGrid = New RadGridView
            dataGrid.Dock = DockStyle.Fill
            topWindow.Controls.Add(dataGrid)

            readyGridTop(dataGrid)

        Next

        For i As Integer = 0 To 2

            leftBottomWindow = New ToolWindow
            leftBottomWindow.ToolCaptionButtons = ToolStripCaptionButtons.None

            dockMain.DockWindow(leftBottomWindow, DockPosition.Bottom)

            dataGrid = New RadGridView
            dataGrid.Dock = DockStyle.Fill
            leftBottomWindow.Controls.Add(dataGrid)

            readyGridLeft(dataGrid)

            rightBottomWindow = New ToolWindow
            rightBottomWindow.ToolCaptionButtons = ToolStripCaptionButtons.None

            dockMain.DockWindow(rightBottomWindow, leftBottomWindow, DockPosition.Right)

            dataGrid = New RadGridView
            dataGrid.Dock = DockStyle.Fill
            rightBottomWindow.Controls.Add(dataGrid)

            readyGridRight(dataGrid)

            If i = 2 Then

                totalWindow.ToolCaptionButtons = ToolStripCaptionButtons.None
                MTMHwindow.ToolCaptionButtons = ToolStripCaptionButtons.None
                MTMHwindow.Height = 300
                dockMain.DockWindow(totalWindow, rightBottomWindow, DockPosition.Bottom)
                dockMain.DockWindow(MTMHwindow, rightBottomWindow, DockPosition.Bottom)

            End If

        Next

    End Sub

    Private Sub readyGridTop(grid As RadGridView)

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.WrapText = True
        fldId.ReadOnly = True
        grid.Columns.Add(fldId)

        Dim fldProcess As New GridViewTextBoxColumn("PROCESS")
        fldProcess.FieldName = "fldProcessName"
        fldProcess.Width = 160
        fldProcess.WrapText = True
        fldProcess.ReadOnly = True
        grid.Columns.Add(fldProcess)

        Dim fldLocation As New GridViewTextBoxColumn("LOCATION")
        fldLocation.FieldName = "fldLocation"
        fldLocation.Width = 100
        fldLocation.WrapText = True
        fldLocation.ReadOnly = True
        fldLocation.IsVisible = False
        grid.Columns.Add(fldLocation)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 220
        fldPartName.ReadOnly = True
        fldPartName.WrapText = True
        grid.Columns.Add(fldPartName)

        Dim fldDescription As New GridViewTextBoxColumn("Description")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 120
        fldDescription.ReadOnly = True
        fldDescription.WrapText = True
        grid.Columns.Add(fldDescription)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 90
        fldItemCode.ReadOnly = True
        fldItemCode.WrapText = True
        grid.Columns.Add(fldItemCode)

        Dim fldCavity As New GridViewDecimalColumn("Cav.")
        fldCavity.FieldName = "fldCavity"
        fldCavity.Width = 60
        fldCavity.WrapText = True
        fldCavity.ShowUpDownButtons = False
        grid.Columns.Add(fldCavity)
        grid.Columns("fldCavity").FormatString = "{0:N2}"

        Dim fldPartWeight As New GridViewDecimalColumn("Part Weight")
        fldPartWeight.FieldName = "fldPartWeight"
        fldPartWeight.Width = 50
        fldPartWeight.WrapText = True
        fldPartWeight.ShowUpDownButtons = False
        grid.Columns.Add(fldPartWeight)
        grid.Columns("fldPartWeight").FormatString = "{0:N2}"

        Dim fldRunnerWeight As New GridViewDecimalColumn("Runner Weight")
        fldRunnerWeight.FieldName = "fldRunnerWeight"
        fldRunnerWeight.Width = 60
        fldRunnerWeight.WrapText = True
        fldRunnerWeight.ShowUpDownButtons = False
        grid.Columns.Add(fldRunnerWeight)
        grid.Columns("fldRunnerWeight").FormatString = "{0:N2}"

        Dim fldLoss As New GridViewDecimalColumn("Loss %")
        fldLoss.FieldName = "fldLoss"
        fldLoss.Width = 50
        fldLoss.WrapText = True
        fldLoss.DecimalPlaces = 2
        fldLoss.ShowUpDownButtons = False
        grid.Columns.Add(fldLoss)
        grid.Columns("fldLoss").FormatString = "{0:N2}"

        Dim fldTotalWeight As New GridViewDecimalColumn("Total Weight")
        fldTotalWeight.FieldName = "totalWeight"
        fldTotalWeight.Width = 50
        fldTotalWeight.ReadOnly = True
        fldTotalWeight.WrapText = True
        grid.Columns.Add(fldTotalWeight)
        grid.Columns("totalWeight").FormatString = "{0:N2}"

        Dim fldUnitPrice As New GridViewDecimalColumn("Unit Price")
        fldUnitPrice.FieldName = "fldUnitPrice"
        fldUnitPrice.Width = 70
        fldUnitPrice.WrapText = True
        fldUnitPrice.ShowUpDownButtons = False
        grid.Columns.Add(fldUnitPrice)
        grid.Columns("fldUnitPrice").FormatString = "{0:N2}"

        Dim fldPiecePrice As New GridViewDecimalColumn("Piece Price")
        fldPiecePrice.FieldName = "piecePrice"
        fldPiecePrice.Width = 50
        fldPiecePrice.ReadOnly = True
        fldPiecePrice.WrapText = True
        grid.Columns.Add(fldPiecePrice)
        grid.Columns("piecePrice").FormatString = "{0:N2}"

        Dim fldScrapWeight As New GridViewDecimalColumn("Scrap Weight")
        fldScrapWeight.FieldName = "scrapWeight"
        fldScrapWeight.Width = 50
        fldScrapWeight.ReadOnly = True
        fldScrapWeight.WrapText = True
        grid.Columns.Add(fldScrapWeight)
        grid.Columns("scrapWeight").FormatString = "{0:N2}"

        Dim fldCollection As New GridViewDecimalColumn("Collection %")
        fldCollection.FieldName = "fldCollection"
        fldCollection.Width = 70
        fldCollection.WrapText = True
        fldCollection.ShowUpDownButtons = False
        grid.Columns.Add(fldCollection)
        grid.Columns("fldCollection").FormatString = "{0:n2}"

        Dim fldScrapUnitPrice As New GridViewDecimalColumn("Scrap Unit Price")
        fldScrapUnitPrice.FieldName = "fldScrapUnitPrice"
        fldScrapUnitPrice.Width = 70
        fldScrapUnitPrice.WrapText = True
        fldScrapUnitPrice.ShowUpDownButtons = False
        grid.Columns.Add(fldScrapUnitPrice)
        grid.Columns("fldScrapUnitPrice").FormatString = "{0:N2}"

        Dim fldScrapPrice As New GridViewDecimalColumn("Scrap Price")
        fldScrapPrice.FieldName = "scrapPrice"
        fldScrapPrice.Width = 50
        fldScrapPrice.ReadOnly = True
        fldScrapPrice.WrapText = True
        grid.Columns.Add(fldScrapPrice)
        grid.Columns("scrapPrice").FormatString = "{0:N2}"

        Dim fldMatCost As New GridViewDecimalColumn("Material Cost")
        fldMatCost.FieldName = "matCost"
        fldMatCost.Width = 60
        fldMatCost.ReadOnly = True
        fldMatCost.WrapText = True
        grid.Columns.Add(fldMatCost)
        grid.Columns("matCost").FormatString = "{0:N2}"

        Dim fldCycleTime As New GridViewDecimalColumn("Cycle Time")
        fldCycleTime.FieldName = "fldCycleTime"
        fldCycleTime.Width = 50
        fldCycleTime.WrapText = True
        fldCycleTime.ShowUpDownButtons = False
        grid.Columns.Add(fldCycleTime)
        grid.Columns("fldCycleTime").FormatString = "{0:N2}"

        Dim fldMhHr As New GridViewDecimalColumn("MH(/hr)*")
        fldMhHr.FieldName = "fldMhHr"
        fldMhHr.Width = 60
        fldMhHr.WrapText = True
        fldMhHr.ShowUpDownButtons = False
        fldMhHr.ReadOnly = True
        grid.Columns.Add(fldMhHr)
        grid.Columns("fldMhHr").FormatString = "{0:N2}"

        Dim fldMHCost As New GridViewDecimalColumn("MH Cost")
        fldMHCost.FieldName = "mhCost"
        fldMHCost.Width = 50
        fldMHCost.ReadOnly = True
        fldMHCost.WrapText = True
        grid.Columns.Add(fldMHCost)
        grid.Columns("mhCost").FormatString = "{0:N2}"

        Dim fldMTHr As New GridViewDecimalColumn("MT(/hr)")
        fldMTHr.FieldName = "fldMtHr"
        fldMTHr.Width = 60
        fldMTHr.ReadOnly = True
        fldMTHr.WrapText = True
        grid.Columns.Add(fldMTHr)
        grid.Columns("fldMtHr").FormatString = "{0:N2}"

        Dim fldMTCost As New GridViewDecimalColumn("MT Cost")
        fldMTCost.FieldName = "mtCost"
        fldMTCost.Width = 60
        fldMTCost.ReadOnly = True
        fldMTCost.WrapText = True
        grid.Columns.Add(fldMTCost)
        grid.Columns("mtCost").FormatString = "{0:N2}"

        Dim fldProcessingCost As New GridViewDecimalColumn("Processing Cost")
        fldProcessingCost.FieldName = "processingFee"
        fldProcessingCost.Width = 70
        fldProcessingCost.ReadOnly = True
        fldProcessingCost.WrapText = True
        grid.Columns.Add(fldProcessingCost)
        grid.Columns("processingFee").FormatString = "{0:N2}"

        Dim fldDirectCost As New GridViewDecimalColumn("Direct Cost")
        fldDirectCost.FieldName = "directCost"
        fldDirectCost.Width = 60
        fldDirectCost.ReadOnly = True
        fldDirectCost.WrapText = True
        grid.Columns.Add(fldDirectCost)
        grid.Columns("directCost").FormatString = "{0:N2}"

        grid.AllowAddNewRow = False
        grid.AllowDeleteRow = False
        grid.ShowGroupPanel = False
        grid.ShowFilteringRow = False
        grid.AllowColumnReorder = False
        grid.AllowRowReorder = False
        grid.EnableSorting = False

        grid.TableElement.RowHeight = 20

        grid.AutoExpandGroups = True

        Dim fldCycleTimeSum As New GridViewSummaryItem("fldCycleTime", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldProcessingCostSum As New GridViewSummaryItem("processingFee", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldDirectCostSum As New GridViewSummaryItem("directCost", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldCycleTimeSum)
        summaryRowItem.Add(fldProcessingCostSum)
        summaryRowItem.Add(fldDirectCostSum)

        grid.SummaryRowsBottom.Add(summaryRowItem)

        Dim descriptor As New GroupDescriptor()
        descriptor.GroupNames.Add("fldProcessName", System.ComponentModel.ListSortDirection.Descending)
        grid.GroupDescriptors.Add(descriptor)

    End Sub

    Private Sub readyGridLeft(grid As RadGridView)

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        fldId.WrapText = True
        grid.Columns.Add(fldId)

        Dim fldProcess As New GridViewTextBoxColumn("Process")
        fldProcess.FieldName = "fldProcessName"
        fldProcess.Width = 160
        fldProcess.ReadOnly = True
        fldProcess.WrapText = True
        grid.Columns.Add(fldProcess)

        Dim myGroup As New GridViewTextBoxColumn("My Group")
        myGroup.FieldName = "myGroup"
        myGroup.Width = 160
        myGroup.ReadOnly = True
        myGroup.IsVisible = False
        grid.Columns.Add(myGroup)

        Dim fldLocation As New GridViewTextBoxColumn("Location")
        fldLocation.FieldName = "location"
        fldLocation.Width = 90
        fldLocation.ReadOnly = True
        fldLocation.WrapText = True
        grid.Columns.Add(fldLocation)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 240
        fldPartName.ReadOnly = True
        grid.Columns.Add(fldPartName)

        Dim maker As New GridViewTextBoxColumn("Maker")
        maker.FieldName = "maker"
        maker.Width = 170
        maker.ReadOnly = True
        maker.WrapText = True
        grid.Columns.Add(maker)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 80
        fldItemCode.ReadOnly = True
        fldItemCode.WrapText = True
        grid.Columns.Add(fldItemCode)

        Dim fldQty As New GridViewDecimalColumn("Qty")
        fldQty.FieldName = "fldUsage"
        fldQty.Width = 70
        fldQty.ReadOnly = True
        fldQty.WrapText = True
        grid.Columns.Add(fldQty)
        grid.Columns("fldUsage").FormatString = "{0:N5}"

        Dim fldUnit As New GridViewTextBoxColumn("Unit")
        fldUnit.FieldName = "fldUOM"
        fldUnit.Width = 40
        fldUnit.ReadOnly = True
        fldUnit.WrapText = True
        grid.Columns.Add(fldUnit)

        Dim fldAtJapan As New GridViewDecimalColumn("Original Price")
        fldAtJapan.FieldName = "fldAtJapan"
        fldAtJapan.Width = 90
        fldAtJapan.WrapText = True
        fldAtJapan.ShowUpDownButtons = False
        grid.Columns.Add(fldAtJapan)
        grid.Columns("fldAtJapan").FormatString = "{0:N2}"

        Dim fldLoss As New GridViewDecimalColumn("Loss %")
        fldLoss.FieldName = "fldLoss"
        fldLoss.Width = 70
        fldLoss.WrapText = True
        fldLoss.ShowUpDownButtons = False
        fldLoss.Minimum = -0
        grid.Columns.Add(fldLoss)
        grid.Columns("fldLoss").FormatString = "{0:N2}"

        Dim fldUnitPrice As New GridViewDecimalColumn("Unit Price (JPY)")
        fldUnitPrice.FieldName = "fldUnitPrice"
        fldUnitPrice.Width = 90
        fldUnitPrice.WrapText = True
        fldUnitPrice.ShowUpDownButtons = False
        grid.Columns.Add(fldUnitPrice)
        grid.Columns("fldUnitPrice").FormatString = "{0:N2}"

        Dim fldPrice As New GridViewDecimalColumn("Price")
        fldPrice.FieldName = "Price"
        fldPrice.Width = 70
        fldPrice.ReadOnly = True
        fldPrice.WrapText = True
        fldPrice.ShowUpDownButtons = False
        grid.Columns.Add(fldPrice)
        grid.Columns("Price").FormatString = "{0:N2}"

        grid.AllowAddNewRow = False
        grid.AllowDeleteRow = False
        grid.ShowGroupPanel = False
        grid.ShowFilteringRow = False
        grid.AllowColumnReorder = False
        grid.AllowRowReorder = False
        grid.EnableSorting = False

        grid.TableElement.RowHeight = 20

        grid.AutoExpandGroups = True

        Dim fldPriceSum As New GridViewSummaryItem("Price", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldPriceSum)

        grid.SummaryRowsBottom.Add(summaryRowItem)

        Dim descriptorProcess As New GroupDescriptor()
        'descriptorProcess.GroupNames.Add("fldProcessName", System.ComponentModel.ListSortDirection.Ascending)
        descriptorProcess.GroupNames.Add("myGroup", System.ComponentModel.ListSortDirection.Ascending)
        grid.GroupDescriptors.Add(descriptorProcess)

        Dim descriptorLocation As New GroupDescriptor
        descriptorLocation.GroupNames.Add("location", System.ComponentModel.ListSortDirection.Ascending)
        grid.GroupDescriptors.Add(descriptorLocation)

    End Sub

    Private Sub readyGridRight(grid As RadGridView)

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        fldId.WrapText = True
        grid.Columns.Add(fldId)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 120
        fldProcessName.ReadOnly = True
        grid.Columns.Add(fldProcessName)

        Dim fldPartName As New GridViewTextBoxColumn("PROCESS NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 310
        fldPartName.ReadOnly = True
        fldPartName.WrapText = True
        grid.Columns.Add(fldPartName)

        Dim fldCycle As New GridViewDecimalColumn("Cycle")
        fldCycle.FieldName = "fldCycle"
        fldCycle.Width = 50
        fldCycle.WrapText = True
        fldCycle.ShowUpDownButtons = False
        grid.Columns.Add(fldCycle)
        grid.Columns("fldCycle").FormatString = "{0:N2}"

        Dim fldOperator As New GridViewDecimalColumn("Operator")
        fldOperator.FieldName = "fldOperator"
        fldOperator.Width = 55
        fldOperator.WrapText = True
        fldOperator.ShowUpDownButtons = False
        grid.Columns.Add(fldOperator)
        grid.Columns("fldOperator").FormatString = "{0:N2}"

        Dim fldOperation As New GridViewDecimalColumn("Operation %")
        fldOperation.FieldName = "fldOperation"
        fldOperation.Width = 55
        fldOperation.WrapText = True
        fldOperation.ShowUpDownButtons = False
        grid.Columns.Add(fldOperation)
        grid.Columns("fldOperation").FormatString = "{0:N2}"

        Dim fldLoss As New GridViewDecimalColumn("Loss %")
        fldLoss.FieldName = "fldLoss"
        fldLoss.Width = 40
        fldLoss.WrapText = True
        fldLoss.ShowUpDownButtons = False
        grid.Columns.Add(fldLoss)
        grid.Columns("fldLoss").FormatString = "{0:N2}"

        Dim fldMhHr As New GridViewDecimalColumn("MH(/hr)*")
        fldMhHr.FieldName = "fldMhHr"
        fldMhHr.Width = 60
        fldMhHr.ReadOnly = True
        fldMhHr.WrapText = True
        grid.Columns.Add(fldMhHr)
        grid.Columns("fldMhHr").FormatString = "{0:N2}"

        Dim fldMHCost As New GridViewDecimalColumn("MH Cost")
        fldMHCost.FieldName = "MHCost"
        fldMHCost.Width = 50
        fldMHCost.ReadOnly = True
        fldMHCost.WrapText = True
        grid.Columns.Add(fldMHCost)
        grid.Columns("MHCost").FormatString = "{0:N2}"

        Dim fldMTHr As New GridViewDecimalColumn("MT(/hr)")
        fldMTHr.FieldName = "fldMtHr"
        fldMTHr.Width = 60
        fldMTHr.ReadOnly = True
        fldMTHr.WrapText = True
        grid.Columns.Add(fldMTHr)
        grid.Columns("fldMtHr").FormatString = "{0:N2}"

        Dim fldMTCost As New GridViewDecimalColumn("MT Cost")
        fldMTCost.FieldName = "MTCost"
        fldMTCost.Width = 60
        fldMTCost.ReadOnly = True
        fldMTCost.WrapText = True
        grid.Columns.Add(fldMTCost)
        grid.Columns("MTCost").FormatString = "{0:N2}"

        Dim fldProcessingCost As New GridViewDecimalColumn("Processing Cost")
        fldProcessingCost.FieldName = "processingCost"
        fldProcessingCost.Width = 70
        fldProcessingCost.ReadOnly = True
        fldProcessingCost.WrapText = True
        grid.Columns.Add(fldProcessingCost)
        grid.Columns("processingCost").FormatString = "{0:N2}"

        grid.AllowAddNewRow = False
        grid.AllowDeleteRow = False
        grid.ShowGroupPanel = False
        grid.ShowFilteringRow = False
        grid.AllowColumnReorder = False
        grid.AllowRowReorder = False
        grid.EnableSorting = False

        grid.TableElement.RowHeight = 20

        grid.AutoExpandGroups = True

        Dim fldProcessingCostSum As New GridViewSummaryItem("processingCost", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldProcessingCostSum)

        grid.SummaryRowsBottom.Add(summaryRowItem)

        Dim descriptorProcess As New GroupDescriptor()
        descriptorProcess.GroupNames.Add("fldProcessName", System.ComponentModel.ListSortDirection.Ascending)
        grid.GroupDescriptors.Add(descriptorProcess)

    End Sub
End Class
