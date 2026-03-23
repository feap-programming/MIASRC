Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class ucCTEditorBak

    Private myDataS1 As DataTable = Nothing
    Private myDataS2 As DataTable = Nothing
    Private myDataS3 As DataTable = Nothing
    Private myDataS4 As DataTable = Nothing
    Private myDataS5 As DataTable = Nothing

    Private dtTempCT As New DataTable
    Private Sub ucCTEditor_Load(sender As Object, e As EventArgs) Handles Me.Load

        dtTempCT.Columns.Add("formula", GetType(String))
        dtTempCT.Columns.Add("value", GetType(Decimal))

        readyGridSec1()
        readyGridSec2()
        readyGridSec3()
        readyGridSec4()
        readyGridSec5()

        txtId.Text = FrmCostTableEditor.txtId.Text

        If bwLoadDataS1.IsBusy = False Then
            bwLoadDataS1.RunWorkerAsync()
        End If

    End Sub

    Private Sub readyGridSec1()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.WrapText = True
        fldId.ReadOnly = True
        gvSection1.Columns.Add(fldId)

        Dim fldProcess As New GridViewTextBoxColumn("PROCESS")
        fldProcess.FieldName = "fldProcessName"
        fldProcess.Width = 160
        fldProcess.WrapText = True
        fldProcess.ReadOnly = True
        gvSection1.Columns.Add(fldProcess)

        Dim fldLocation As New GridViewTextBoxColumn("LOCATION")
        fldLocation.FieldName = "fldLocation"
        fldLocation.Width = 100
        fldLocation.WrapText = True
        fldLocation.ReadOnly = True
        fldLocation.IsVisible = False
        gvSection1.Columns.Add(fldLocation)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 220
        fldPartName.ReadOnly = True
        fldPartName.WrapText = True
        gvSection1.Columns.Add(fldPartName)

        Dim fldDescription As New GridViewTextBoxColumn("Description")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 120
        fldDescription.ReadOnly = True
        fldDescription.WrapText = True
        gvSection1.Columns.Add(fldDescription)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 90
        fldItemCode.ReadOnly = True
        fldItemCode.WrapText = True
        gvSection1.Columns.Add(fldItemCode)

        Dim fldCavity As New GridViewDecimalColumn("Cav.")
        fldCavity.FieldName = "fldCavity"
        fldCavity.Width = 60
        fldCavity.WrapText = True
        fldCavity.ShowUpDownButtons = False
        gvSection1.Columns.Add(fldCavity)
        gvSection1.Columns("fldCavity").FormatString = "{0:N2}"

        Dim fldPartWeight As New GridViewDecimalColumn("Part Weight")
        fldPartWeight.FieldName = "fldPartWeight"
        fldPartWeight.Width = 50
        fldPartWeight.WrapText = True
        fldPartWeight.ShowUpDownButtons = False
        gvSection1.Columns.Add(fldPartWeight)
        gvSection1.Columns("fldPartWeight").FormatString = "{0:N2}"

        Dim fldRunnerWeight As New GridViewDecimalColumn("Runner Weight")
        fldRunnerWeight.FieldName = "fldRunnerWeight"
        fldRunnerWeight.Width = 60
        fldRunnerWeight.WrapText = True
        fldRunnerWeight.ShowUpDownButtons = False
        gvSection1.Columns.Add(fldRunnerWeight)
        gvSection1.Columns("fldRunnerWeight").FormatString = "{0:N2}"

        Dim fldLoss As New GridViewDecimalColumn("Loss %")
        fldLoss.FieldName = "fldLoss"
        fldLoss.Width = 50
        fldLoss.WrapText = True
        fldLoss.DecimalPlaces = 2
        fldLoss.ShowUpDownButtons = False
        gvSection1.Columns.Add(fldLoss)
        gvSection1.Columns("fldLoss").FormatString = "{0:N2}"

        Dim fldTotalWeight As New GridViewDecimalColumn("Total Weight")
        fldTotalWeight.FieldName = "totalWeight"
        fldTotalWeight.Width = 50
        fldTotalWeight.ReadOnly = True
        fldTotalWeight.WrapText = True
        gvSection1.Columns.Add(fldTotalWeight)
        gvSection1.Columns("totalWeight").FormatString = "{0:N2}"

        Dim fldUnitPrice As New GridViewDecimalColumn("Unit Price")
        fldUnitPrice.FieldName = "fldUnitPrice"
        fldUnitPrice.Width = 70
        fldUnitPrice.WrapText = True
        fldUnitPrice.ShowUpDownButtons = False
        gvSection1.Columns.Add(fldUnitPrice)
        gvSection1.Columns("fldUnitPrice").FormatString = "{0:N2}"

        Dim fldPiecePrice As New GridViewDecimalColumn("Piece Price")
        fldPiecePrice.FieldName = "piecePrice"
        fldPiecePrice.Width = 50
        fldPiecePrice.ReadOnly = True
        fldPiecePrice.WrapText = True
        gvSection1.Columns.Add(fldPiecePrice)
        gvSection1.Columns("piecePrice").FormatString = "{0:N2}"

        Dim fldScrapWeight As New GridViewDecimalColumn("Scrap Weight")
        fldScrapWeight.FieldName = "scrapWeight"
        fldScrapWeight.Width = 50
        fldScrapWeight.ReadOnly = True
        fldScrapWeight.WrapText = True
        gvSection1.Columns.Add(fldScrapWeight)
        gvSection1.Columns("scrapWeight").FormatString = "{0:N2}"

        Dim fldCollection As New GridViewDecimalColumn("Collection %")
        fldCollection.FieldName = "fldCollection"
        fldCollection.Width = 70
        fldCollection.WrapText = True
        fldCollection.ShowUpDownButtons = False
        gvSection1.Columns.Add(fldCollection)
        gvSection1.Columns("fldCollection").FormatString = "{0:n2}"

        Dim fldScrapUnitPrice As New GridViewDecimalColumn("Scrap Unit Price")
        fldScrapUnitPrice.FieldName = "fldScrapUnitPrice"
        fldScrapUnitPrice.Width = 70
        fldScrapUnitPrice.WrapText = True
        fldScrapUnitPrice.ShowUpDownButtons = False
        gvSection1.Columns.Add(fldScrapUnitPrice)
        gvSection1.Columns("fldScrapUnitPrice").FormatString = "{0:N2}"

        Dim fldScrapPrice As New GridViewDecimalColumn("Scrap Price")
        fldScrapPrice.FieldName = "scrapPrice"
        fldScrapPrice.Width = 50
        fldScrapPrice.ReadOnly = True
        fldScrapPrice.WrapText = True
        gvSection1.Columns.Add(fldScrapPrice)
        gvSection1.Columns("scrapPrice").FormatString = "{0:N2}"

        Dim fldMatCost As New GridViewDecimalColumn("Material Cost")
        fldMatCost.FieldName = "matCost"
        fldMatCost.Width = 60
        fldMatCost.ReadOnly = True
        fldMatCost.WrapText = True
        gvSection1.Columns.Add(fldMatCost)
        gvSection1.Columns("matCost").FormatString = "{0:N2}"

        Dim fldCycleTime As New GridViewDecimalColumn("Cycle Time")
        fldCycleTime.FieldName = "fldCycleTime"
        fldCycleTime.Width = 50
        fldCycleTime.WrapText = True
        fldCycleTime.ShowUpDownButtons = False
        gvSection1.Columns.Add(fldCycleTime)
        gvSection1.Columns("fldCycleTime").FormatString = "{0:N2}"

        Dim fldMhHr As New GridViewDecimalColumn("MH(/hr)*")
        fldMhHr.FieldName = "fldMhHr"
        fldMhHr.Width = 60
        fldMhHr.WrapText = True
        fldMhHr.ShowUpDownButtons = False
        fldMhHr.ReadOnly = True
        gvSection1.Columns.Add(fldMhHr)
        gvSection1.Columns("fldMhHr").FormatString = "{0:N2}"

        Dim fldMHCost As New GridViewDecimalColumn("MH Cost")
        fldMHCost.FieldName = "mhCost"
        fldMHCost.Width = 50
        fldMHCost.ReadOnly = True
        fldMHCost.WrapText = True
        gvSection1.Columns.Add(fldMHCost)
        gvSection1.Columns("mhCost").FormatString = "{0:N2}"

        Dim fldMTHr As New GridViewDecimalColumn("MT(/hr)")
        fldMTHr.FieldName = "fldMtHr"
        fldMTHr.Width = 60
        fldMTHr.ReadOnly = True
        fldMTHr.WrapText = True
        gvSection1.Columns.Add(fldMTHr)
        gvSection1.Columns("fldMtHr").FormatString = "{0:N2}"

        Dim fldMTCost As New GridViewDecimalColumn("MT Cost")
        fldMTCost.FieldName = "mtCost"
        fldMTCost.Width = 60
        fldMTCost.ReadOnly = True
        fldMTCost.WrapText = True
        gvSection1.Columns.Add(fldMTCost)
        gvSection1.Columns("mtCost").FormatString = "{0:N2}"

        Dim fldProcessingCost As New GridViewDecimalColumn("Processing Cost")
        fldProcessingCost.FieldName = "processingFee"
        fldProcessingCost.Width = 70
        fldProcessingCost.ReadOnly = True
        fldProcessingCost.WrapText = True
        gvSection1.Columns.Add(fldProcessingCost)
        gvSection1.Columns("processingFee").FormatString = "{0:N2}"

        Dim fldDirectCost As New GridViewDecimalColumn("Direct Cost")
        fldDirectCost.FieldName = "directCost"
        fldDirectCost.Width = 60
        fldDirectCost.ReadOnly = True
        fldDirectCost.WrapText = True
        gvSection1.Columns.Add(fldDirectCost)
        gvSection1.Columns("directCost").FormatString = "{0:N2}"

        gvSection1.AllowAddNewRow = False
        gvSection1.AllowDeleteRow = False
        gvSection1.ShowGroupPanel = False
        gvSection1.ShowFilteringRow = False
        gvSection1.AllowColumnReorder = False
        gvSection1.AllowRowReorder = False
        gvSection1.EnableSorting = False

        gvSection1.TableElement.RowHeight = 20

        gvSection1.AutoExpandGroups = True

        Dim fldCycleTimeSum As New GridViewSummaryItem("fldCycleTime", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldProcessingCostSum As New GridViewSummaryItem("processingFee", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldDirectCostSum As New GridViewSummaryItem("directCost", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldCycleTimeSum)
        summaryRowItem.Add(fldProcessingCostSum)
        summaryRowItem.Add(fldDirectCostSum)

        gvSection1.SummaryRowsBottom.Add(summaryRowItem)

        Dim descriptor As New GroupDescriptor()
        descriptor.GroupNames.Add("fldProcessName", System.ComponentModel.ListSortDirection.Descending)
        gvSection1.GroupDescriptors.Add(descriptor)

    End Sub

    Private Sub readyGridSec2()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        fldId.WrapText = True
        gvSection2.Columns.Add(fldId)

        Dim fldProcess As New GridViewTextBoxColumn("Process")
        fldProcess.FieldName = "fldProcessName"
        fldProcess.Width = 160
        fldProcess.IsVisible = False
        fldProcess.ReadOnly = True
        fldProcess.WrapText = True
        gvSection2.Columns.Add(fldProcess)

        Dim myGroup As New GridViewTextBoxColumn("PROCESS")
        myGroup.FieldName = "myGroup"
        myGroup.Width = 160
        myGroup.ReadOnly = True
        myGroup.IsVisible = False
        gvSection2.Columns.Add(myGroup)

        Dim fldLocation As New GridViewTextBoxColumn("Location")
        fldLocation.FieldName = "location"
        fldLocation.Width = 90
        fldLocation.ReadOnly = True
        fldLocation.WrapText = True
        gvSection2.Columns.Add(fldLocation)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 240
        fldPartName.ReadOnly = True
        gvSection2.Columns.Add(fldPartName)

        Dim maker As New GridViewTextBoxColumn("Maker")
        maker.FieldName = "maker"
        maker.Width = 170
        maker.ReadOnly = True
        maker.WrapText = True
        gvSection2.Columns.Add(maker)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 80
        fldItemCode.ReadOnly = True
        fldItemCode.WrapText = True
        gvSection2.Columns.Add(fldItemCode)

        Dim fldQty As New GridViewDecimalColumn("Qty")
        fldQty.FieldName = "fldUsage"
        fldQty.Width = 70
        fldQty.ReadOnly = True
        fldQty.WrapText = True
        gvSection2.Columns.Add(fldQty)
        gvSection2.Columns("fldUsage").FormatString = "{0:N5}"

        Dim fldUnit As New GridViewTextBoxColumn("Unit")
        fldUnit.FieldName = "fldUOM"
        fldUnit.Width = 40
        fldUnit.ReadOnly = True
        fldUnit.WrapText = True
        gvSection2.Columns.Add(fldUnit)

        Dim fldAtJapan As New GridViewDecimalColumn("Original Price")
        fldAtJapan.FieldName = "fldAtJapan"
        fldAtJapan.Width = 90
        fldAtJapan.WrapText = True
        fldAtJapan.ShowUpDownButtons = False
        gvSection2.Columns.Add(fldAtJapan)
        gvSection2.Columns("fldAtJapan").FormatString = "{0:N2}"

        Dim fldLoss As New GridViewDecimalColumn("Loss %")
        fldLoss.FieldName = "fldLoss"
        fldLoss.Width = 70
        fldLoss.WrapText = True
        fldLoss.ShowUpDownButtons = False
        fldLoss.Minimum = -0
        gvSection2.Columns.Add(fldLoss)
        gvSection2.Columns("fldLoss").FormatString = "{0:N2}"

        Dim fldUnitPrice As New GridViewDecimalColumn("Unit Price (JPY)")
        fldUnitPrice.FieldName = "fldUnitPrice"
        fldUnitPrice.Width = 90
        fldUnitPrice.WrapText = True
        fldUnitPrice.ShowUpDownButtons = False
        gvSection2.Columns.Add(fldUnitPrice)
        gvSection2.Columns("fldUnitPrice").FormatString = "{0:N2}"

        Dim fldPrice As New GridViewDecimalColumn("Price")
        fldPrice.FieldName = "Price"
        fldPrice.Width = 70
        fldPrice.ReadOnly = True
        fldPrice.WrapText = True
        fldPrice.ShowUpDownButtons = False
        gvSection2.Columns.Add(fldPrice)
        gvSection2.Columns("Price").FormatString = "{0:N2}"

        gvSection2.AllowAddNewRow = False
        gvSection2.AllowDeleteRow = False
        gvSection2.ShowGroupPanel = False
        gvSection2.ShowFilteringRow = False
        gvSection2.AllowColumnReorder = False
        gvSection2.AllowRowReorder = False
        gvSection2.EnableSorting = False

        gvSection2.TableElement.RowHeight = 20

        gvSection2.AutoExpandGroups = True

        Dim fldPriceSum As New GridViewSummaryItem("Price", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldPriceSum)

        gvSection2.SummaryRowsBottom.Add(summaryRowItem)

        Dim descriptorProcess As New GroupDescriptor()
        'descriptorProcess.GroupNames.Add("fldProcessName", System.ComponentModel.ListSortDirection.Ascending)
        descriptorProcess.GroupNames.Add("myGroup", System.ComponentModel.ListSortDirection.Ascending)
        gvSection2.GroupDescriptors.Add(descriptorProcess)

        Dim descriptorLocation As New GroupDescriptor
        descriptorLocation.GroupNames.Add("location", System.ComponentModel.ListSortDirection.Ascending)
        gvSection2.GroupDescriptors.Add(descriptorLocation)

    End Sub

    Private Sub readyGridSec3()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        fldId.WrapText = True
        gvSection3.Columns.Add(fldId)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 120
        fldProcessName.ReadOnly = True
        gvSection3.Columns.Add(fldProcessName)

        Dim fldPartName As New GridViewTextBoxColumn("PROCESS NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 310
        fldPartName.ReadOnly = True
        fldPartName.WrapText = True
        gvSection3.Columns.Add(fldPartName)

        Dim fldCycle As New GridViewDecimalColumn("Cycle")
        fldCycle.FieldName = "fldCycle"
        fldCycle.Width = 50
        fldCycle.WrapText = True
        fldCycle.ShowUpDownButtons = False
        gvSection3.Columns.Add(fldCycle)
        gvSection3.Columns("fldCycle").FormatString = "{0:N2}"

        Dim fldOperator As New GridViewDecimalColumn("Operator")
        fldOperator.FieldName = "fldOperator"
        fldOperator.Width = 55
        fldOperator.WrapText = True
        fldOperator.ShowUpDownButtons = False
        gvSection3.Columns.Add(fldOperator)
        gvSection3.Columns("fldOperator").FormatString = "{0:N2}"

        Dim fldOperation As New GridViewDecimalColumn("Operation %")
        fldOperation.FieldName = "fldOperation"
        fldOperation.Width = 55
        fldOperation.WrapText = True
        fldOperation.ShowUpDownButtons = False
        gvSection3.Columns.Add(fldOperation)
        gvSection3.Columns("fldOperation").FormatString = "{0:N2}"

        Dim fldLoss As New GridViewDecimalColumn("Loss %")
        fldLoss.FieldName = "fldLoss"
        fldLoss.Width = 40
        fldLoss.WrapText = True
        fldLoss.ShowUpDownButtons = False
        gvSection3.Columns.Add(fldLoss)
        gvSection3.Columns("fldLoss").FormatString = "{0:N2}"

        Dim fldMhHr As New GridViewDecimalColumn("MH(/hr)*")
        fldMhHr.FieldName = "fldMhHr"
        fldMhHr.Width = 60
        fldMhHr.ReadOnly = True
        fldMhHr.WrapText = True
        gvSection3.Columns.Add(fldMhHr)
        gvSection3.Columns("fldMhHr").FormatString = "{0:N2}"

        Dim fldMHCost As New GridViewDecimalColumn("MH Cost")
        fldMHCost.FieldName = "MHCost"
        fldMHCost.Width = 50
        fldMHCost.ReadOnly = True
        fldMHCost.WrapText = True
        gvSection3.Columns.Add(fldMHCost)
        gvSection3.Columns("MHCost").FormatString = "{0:N2}"

        Dim fldMTHr As New GridViewDecimalColumn("MT(/hr)")
        fldMTHr.FieldName = "fldMtHr"
        fldMTHr.Width = 60
        fldMTHr.ReadOnly = True
        fldMTHr.WrapText = True
        gvSection3.Columns.Add(fldMTHr)
        gvSection3.Columns("fldMtHr").FormatString = "{0:N2}"

        Dim fldMTCost As New GridViewDecimalColumn("MT Cost")
        fldMTCost.FieldName = "MTCost"
        fldMTCost.Width = 60
        fldMTCost.ReadOnly = True
        fldMTCost.WrapText = True
        gvSection3.Columns.Add(fldMTCost)
        gvSection3.Columns("MTCost").FormatString = "{0:N2}"

        Dim fldProcessingCost As New GridViewDecimalColumn("Processing Cost")
        fldProcessingCost.FieldName = "processingCost"
        fldProcessingCost.Width = 70
        fldProcessingCost.ReadOnly = True
        fldProcessingCost.WrapText = True
        gvSection3.Columns.Add(fldProcessingCost)
        gvSection3.Columns("processingCost").FormatString = "{0:N2}"

        gvSection3.AllowAddNewRow = False
        gvSection3.AllowDeleteRow = False
        gvSection3.ShowGroupPanel = False
        gvSection3.ShowFilteringRow = False
        gvSection3.AllowColumnReorder = False
        gvSection3.AllowRowReorder = False
        gvSection3.EnableSorting = False

        gvSection3.TableElement.RowHeight = 20

        gvSection3.AutoExpandGroups = True

        Dim fldProcessingCostSum As New GridViewSummaryItem("processingCost", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldProcessingCostSum)

        gvSection3.SummaryRowsBottom.Add(summaryRowItem)

        Dim descriptorProcess As New GroupDescriptor()
        descriptorProcess.GroupNames.Add("fldProcessName", System.ComponentModel.ListSortDirection.Ascending)
        gvSection3.GroupDescriptors.Add(descriptorProcess)

    End Sub

    Private Sub readyGridSec4()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        fldId.WrapText = True
        gvSection4.Columns.Add(fldId)

        Dim fldName As New GridViewTextBoxColumn("NAME")
        fldName.FieldName = "fldName"
        fldName.Width = 50
        fldName.ReadOnly = True
        fldName.TextAlignment = ContentAlignment.MiddleCenter
        gvSection4.Columns.Add(fldName)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS")
        fldProcessName.FieldName = "fldProcess"
        fldProcessName.Width = 200
        fldProcessName.ReadOnly = True
        gvSection4.Columns.Add(fldProcessName)

        Dim fldFormula As New GridViewTextBoxColumn("FORMULA")
        fldFormula.FieldName = "fldFormula"
        fldFormula.Width = 120
        fldFormula.ReadOnly = True
        gvSection4.Columns.Add(fldFormula)

        Dim fldValue As New GridViewTextBoxColumn("VALUE")
        fldValue.FieldName = "fldValue"
        fldValue.Width = 100
        fldValue.TextAlignment = ContentAlignment.MiddleRight
        fldValue.ReadOnly = True
        gvSection4.Columns.Add(fldValue)

        gvSection4.AllowAddNewRow = False
        gvSection4.AllowDeleteRow = False
        gvSection4.ShowGroupPanel = False
        gvSection4.ShowFilteringRow = False
        gvSection4.AllowColumnReorder = False
        gvSection4.AllowRowReorder = False
        gvSection4.EnableSorting = False

        gvSection4.TableElement.RowHeight = 20

    End Sub

    Private Sub readyGridSec5()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        fldId.WrapText = True
        gvSection5.Columns.Add(fldId)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS")
        fldProcessName.FieldName = "process"
        fldProcessName.Width = 200
        fldProcessName.ReadOnly = True
        gvSection5.Columns.Add(fldProcessName)

        Dim fldMH As New GridViewDecimalColumn("MH")
        fldMH.FieldName = "fldMH"
        fldMH.Width = 100
        fldMH.ShowUpDownButtons = False
        gvSection5.Columns.Add(fldMH)

        Dim fldMT As New GridViewDecimalColumn("MT")
        fldMT.FieldName = "fldMT"
        fldMT.Width = 100
        fldMT.ShowUpDownButtons = False
        gvSection5.Columns.Add(fldMT)

        gvSection5.AllowAddNewRow = False
        gvSection5.AllowDeleteRow = False
        gvSection5.ShowGroupPanel = False
        gvSection5.ShowFilteringRow = False
        gvSection5.AllowColumnReorder = False
        gvSection5.AllowRowReorder = False
        gvSection5.EnableSorting = False

        gvSection5.TableElement.RowHeight = 20

    End Sub

    Private Sub bwLoadDataS1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadDataS1.DoWork

        Slipknot.addParameter("parCTID", txtId.Text)
        myDataS1 = Slipknot.dbSelect("SP_SelectBOMPerItemAndProcess")

    End Sub

    Private Sub bwLoadDataS1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadDataS1.RunWorkerCompleted

        gvSection1.DataSource = myDataS1

        If bwLoadDataS2.IsBusy = False Then
            bwLoadDataS2.RunWorkerAsync()
        End If

    End Sub

    Private Sub bwLoadDataS2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadDataS2.DoWork

        Slipknot.addParameter("parCTID", txtId.Text)
        'myDataS2 = Slipknot.dbSelect("SP_SelectCTMaterial")
        myDataS2 = Slipknot.dbSelect("SP_SelectCTMaterial2")

    End Sub

    Private Sub bwLoadDataS2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadDataS2.RunWorkerCompleted

        gvSection2.DataSource = myDataS2

        If bwLoadDataS3.IsBusy = False Then
            bwLoadDataS3.RunWorkerAsync()
        End If

    End Sub

    Private Sub bwLoadDataS3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadDataS3.DoWork

        Slipknot.addParameter("parCTID", txtId.Text)
        myDataS3 = Slipknot.dbSelect("SP_SelectCTProcessingFee")

    End Sub

    Private Sub bwLoadDataS3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadDataS3.RunWorkerCompleted
        gvSection3.DataSource = myDataS3

        If bwLoadData4.IsBusy = False Then
            bwLoadData4.RunWorkerAsync()
        End If
    End Sub

    Private Sub gvSection1_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvSection1.CellEndEdit

        Try

            Dim fldCavity As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldCavity").Value)
            Dim fldPartWeight As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldPartWeight").Value)
            Dim fldRunnerWeight As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldRunnerWeight").Value)
            Dim fldLoss As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldLoss").Value) / 100 '* 100

            gvSection1.CurrentRow.Cells("fldTotalWeight").Value = (fldPartWeight + (fldRunnerWeight / fldCavity)) * (1 + fldLoss)
            Dim fldTotalWeight As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldTotalWeight").Value)

            Dim fldUnitPrice As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldUnitPrice").Value)

            gvSection1.CurrentRow.Cells("fldPiecePrice").Value = (fldTotalWeight * fldUnitPrice) / 1000
            Dim fldPiecePrice As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldPiecePrice").Value)

            gvSection1.CurrentRow.Cells("fldScrapWeight").Value = fldRunnerWeight + (fldPartWeight + fldRunnerWeight) * fldLoss / 100
            Dim fldScrapWeight As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldScrapWeight").Value)
            Dim fldCollection As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldCollection").Value) / 100 '* 100

            Dim fldScrapUnitPrice As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldScrapUnitPrice").Value)

            gvSection1.CurrentRow.Cells("fldScrapPrice").Value = fldScrapWeight * fldCollection * fldScrapUnitPrice / 1000 / fldCavity
            Dim fldScrapPrice As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldScrapPrice").Value)

            gvSection1.CurrentRow.Cells("fldMatCost").Value = fldPiecePrice - fldScrapPrice
            Dim fldMatCost As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldMatCost").Value)
            Dim fldCycleTime As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldCycleTime").Value)

            Dim fldMhHr As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldMhHr").Value)

            gvSection1.CurrentRow.Cells("fldMHCost").Value = fldCycleTime * fldMhHr / 3600 / fldCavity
            Dim fldMHCost As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldMHCost").Value)

            Dim fldMTHr As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldMTHr").Value)

            gvSection1.CurrentRow.Cells("fldMTCost").Value = fldCycleTime * fldMTHr / 3600 / fldCavity
            Dim fldMTCost As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldMTCost").Value)

            gvSection1.CurrentRow.Cells("fldProcessingCost").Value = fldMHCost + fldMTCost
            Dim fldProcessingCost As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldProcessingCost").Value)

            gvSection1.CurrentRow.Cells("fldDirectCost").Value = fldMatCost + fldProcessingCost
            Dim fldDirectCost As Double = Convert.ToDecimal(gvSection1.CurrentRow.Cells("fldDirectCost").Value)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub gvSection1_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvSection1.ViewCellFormatting

        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)

        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            e.CellElement.BorderTopColor = Color.Black
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed
        End If

    End Sub

    Private Sub gvSection2_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvSection2.CellEndEdit
        Try

            Dim fldUsage As Double = Convert.ToDecimal(gvSection2.CurrentRow.Cells("fldUsage").Value)
            Dim fldAtJapan As Double = Convert.ToDecimal(gvSection2.CurrentRow.Cells("fldAtJapan").Value)
            Dim fldLoss As Double = Val(Convert.ToDecimal(gvSection2.CurrentRow.Cells("fldLoss").Value)) / 100
            Dim fldUnitPrice As Double = Convert.ToDecimal(gvSection2.CurrentRow.Cells("fldUnitPrice").Value)

            gvSection2.CurrentRow.Cells("fldPrice").Value = fldUsage * (1 + fldLoss) * fldUnitPrice

            getSectionValues()

            computeOverall()
            computeTotal()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvSection3_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvSection3.CellFormatting

        If e.CellElement.ColumnInfo.FieldName = "fldPartName" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.DarkSeaGreen

        ElseIf e.CellElement.ColumnInfo.FieldName = "MH" OrElse
            e.CellElement.ColumnInfo.FieldName = "MHCost" OrElse
            e.CellElement.ColumnInfo.FieldName = "MT" OrElse
            e.CellElement.ColumnInfo.FieldName = "MTCost" OrElse
            e.CellElement.ColumnInfo.FieldName = "processingCost" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.WhiteSmoke

        Else
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

    End Sub

    Private Sub gvSection2_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvSection2.CellFormatting

        If e.CellElement.ColumnInfo.FieldName = "fldProcessName" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldLocation" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldPartName" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldMakerName" OrElse
            e.CellElement.ColumnInfo.FieldName = "maker" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldItemCode" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldUsage" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldUOM" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.DarkSeaGreen

        ElseIf e.CellElement.ColumnInfo.FieldName = "Price" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.WhiteSmoke

        Else
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

    End Sub

    Private Sub gvSection1_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvSection1.CellFormatting

        If e.CellElement.ColumnInfo.FieldName = "fldProcessName" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldLocation" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldPartName" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldDescription" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldItemCode" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.DarkSeaGreen

        ElseIf e.CellElement.ColumnInfo.FieldName = "totalWeight" OrElse
            e.CellElement.ColumnInfo.FieldName = "piecePrice" OrElse
            e.CellElement.ColumnInfo.FieldName = "scrapWeight" OrElse
            e.CellElement.ColumnInfo.FieldName = "scrapPrice" OrElse
            e.CellElement.ColumnInfo.FieldName = "matCost" OrElse
            e.CellElement.ColumnInfo.FieldName = "mhCost" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldMhHr" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldMtHr" OrElse
            e.CellElement.ColumnInfo.FieldName = "mhCost" OrElse
            e.CellElement.ColumnInfo.FieldName = "mtCost" OrElse
            e.CellElement.ColumnInfo.FieldName = "processingFee" OrElse
            e.CellElement.ColumnInfo.FieldName = "directCost" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.WhiteSmoke

        Else
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

    End Sub

    Private Sub bwLoadSection5_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData5.DoWork
        myDataS5 = Slipknot.dbSelectManual("SELECT *, (SELECT fldProcessName FROM tblProcess WHERE fldCode = tblUnitPriceOfMTMH.fldProcessCode LIMIT 1) AS process FROM tblUnitPriceOfMTMH")
    End Sub

    Private Sub bwLoadSection5_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData5.RunWorkerCompleted
        gvSection5.DataSource = myDataS5

        getSectionValues()

        computeOverall()
        computeTotal()

    End Sub

    Private Sub bwLoadData4_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData4.DoWork
        myDataS4 = Slipknot.dbSelectManual("SELECT * FROM tblCTSection4 WHERE fldCTID = '" & txtId.Text & "' ")
    End Sub

    Private Sub bwLoadData4_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData4.RunWorkerCompleted
        gvSection4.DataSource = myDataS4

        If bwLoadData5.IsBusy = False Then
            bwLoadData5.RunWorkerAsync()
        End If
    End Sub

    Private Sub gvSection4_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvSection4.CellFormatting
        If e.CellElement.ColumnInfo.FieldName = "fldValue" Then

            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.WhiteSmoke

        Else

            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)

        End If
    End Sub

    Private Sub gvSection5_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvSection5.CellFormatting
        Dim f As Font = New Font(New FontFamily("Arial"), 8.0F)

        e.CellElement.Font = f
    End Sub

    Private Sub gvSection2_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvSection2.ViewCellFormatting

        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)

        If TypeOf e.CellElement Is GridSummaryCellElement Then

            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            e.CellElement.BorderTopColor = Color.Black
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed

        End If

        If TypeOf e.CellElement.RowInfo Is GridViewGroupRowInfo Then

            If Convert.ToString(e.CellElement.Value).Contains("PROCESS") Then
                e.CellElement.DrawFill = True
                e.CellElement.BackColor = Color.Yellow
                e.CellElement.ForeColor = Color.Black
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            End If

        End If

    End Sub

    Private Sub gvSection3_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvSection3.CellEndEdit

        Try
            Dim fldCycle As Double = Convert.ToDouble(gvSection3.CurrentRow.Cells("fldCycle").Value)
            Dim fldOperator As Double = Convert.ToDouble(gvSection3.CurrentRow.Cells("fldOperator").Value)
            Dim fldOperation As Double = Val(Convert.ToDouble(gvSection3.CurrentRow.Cells("fldOperation").Value)) / 100
            Dim fldLoss As Double = Val(Convert.ToDouble(gvSection3.CurrentRow.Cells("fldLoss").Value)) / 100
            Dim MH As Double = Convert.ToDouble(gvSection3.CurrentRow.Cells("fldMhHr").Value)

            gvSection3.CurrentRow.Cells("fldMHCost").Value = fldCycle * fldOperator / fldOperation * (1 + fldLoss) * MH / 3600

            Dim MT As Double = Convert.ToDouble(gvSection3.CurrentRow.Cells("fldMtHr").Value)

            gvSection3.CurrentRow.Cells("fldMTCost").Value = fldCycle / fldOperation * (1 + fldLoss) * MT / 3600

            Dim fldMHCost As Double = Convert.ToDouble(gvSection3.CurrentRow.Cells("fldMHCost").Value) + Convert.ToDouble(gvSection3.CurrentRow.Cells("fldMTCost").Value)

            gvSection3.CurrentRow.Cells("fldProcessingCost").Value = fldMHCost

            getSectionValues()

            computeOverall()
            computeTotal()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub gvSection3_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvSection3.ViewCellFormatting

        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)

        If TypeOf e.CellElement Is GridSummaryCellElement Then

            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            e.CellElement.BorderTopColor = Color.Black
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed

        End If

    End Sub

    Private Sub getSectionValues()

        dtTempCT.Rows.Clear()

        For Each group As DataGroup In Me.gvSection2.Groups

            For Each G As DataGroup In group.Groups

                Dim formulaCode As String = G.Header.ToString.Substring(G.Header.ToString.Length - 2, 2)

                formulaCode = formulaCode.First

                For Each summaryRow As GridViewSummaryRowInfo In G.GroupRow.BottomSummaryRows

                    dtTempCT.Rows.Add(formulaCode, Convert.ToDecimal(summaryRow.GetSummary(Me.gvSection2.Columns("Price"))))

                Next

            Next

        Next

        For Each group As DataGroup In Me.gvSection3.Groups

            Dim formulaCode As String = group.Header.ToString.Substring(group.Header.ToString.Length - 2, 2)

            formulaCode = formulaCode.First

            For Each summaryRow As GridViewSummaryRowInfo In group.GroupRow.BottomSummaryRows

                dtTempCT.Rows.Add(formulaCode, Convert.ToDecimal(summaryRow.GetSummary(Me.gvSection3.Columns("processingCost"))))

            Next

        Next

    End Sub

    Private Sub computeOverall()

        Dim formula As String = String.Empty

        For Each row As GridViewRowInfo In gvSection4.Rows

            formula = Convert.ToString(row.Cells("fldFormula").Value)

            Dim formulaString As String

            If isLetter(row.Cells("fldName").Value) Then

                Try

                    formulaString = String.Empty

                    For Each text As String In formula

                        If isLetter(text) Then

                            Dim query = (From T0 In dtTempCT.AsEnumerable()
                                         Where T0.Field(Of String)("formula") = text
                                         Select New With
                                              {
                                              .myVal = T0("value")
                                              }).ToList

                            Dim dt As DataTable = Slipknot.convertToDatatable(query)

                            formulaString = formulaString & Convert.ToDecimal(dt.Rows(0).Item("myVal"))

                        Else

                            Select Case text.TrimStart.TrimEnd
                                Case "+"
                                    formulaString = formulaString & " + "
                                Case "-"
                                    formulaString = formulaString & " - "
                                Case "*"
                                    formulaString = formulaString & " * "
                                Case "/"
                                    formulaString = formulaString & " / "
                            End Select

                        End If

                    Next

                    row.Cells("fldValue").Value = Convert.ToDecimal(Slipknot.ExecuteFormula(formulaString))

                Catch ex As Exception

                End Try

            Else

                Try

                    row.Cells("fldValue").Value = Convert.ToDecimal(Slipknot.ExecuteFormula(formulaString))

                Catch ex As Exception

                End Try

            End If

        Next

    End Sub

    Private Sub computeTotal()

        Dim formula As String = String.Empty

        For Each row As GridViewRowInfo In gvSection4.Rows

            If Convert.ToString(row.Cells("fldName").Value) = "TOTAL" Then

                Try

                    formula = Convert.ToString(row.Cells("fldFormula").Value)

                    Dim formulaString As String = String.Empty

                    For Each text As String In formula

                        If IsNumeric(text) Then

                            For Each gridRow As GridViewRowInfo In gvSection4.Rows

                                If Convert.ToString(gridRow.Cells("fldName").Value) = text Then

                                    formulaString = formulaString & Convert.ToDecimal(gridRow.Cells("fldValue").Value)

                                    Exit For
                                End If

                            Next

                        Else

                            Select Case text.TrimStart.TrimEnd
                                Case "+"
                                    formulaString = formulaString & " + "
                                Case "-"
                                    formulaString = formulaString & " - "
                                Case "*"
                                    formulaString = formulaString & " * "
                                Case "/"
                                    formulaString = formulaString & " / "
                            End Select

                        End If

                    Next

                    row.Cells("fldValue").Value = Convert.ToDecimal(Slipknot.ExecuteFormula(formulaString))

                Catch ex As Exception

                End Try

            End If

        Next

    End Sub

    Function isLetter(ByVal text As String) As Boolean

        If Char.IsLetter(text) Then
            Return True

            Exit Function
        End If

        Return False
    End Function


End Class
