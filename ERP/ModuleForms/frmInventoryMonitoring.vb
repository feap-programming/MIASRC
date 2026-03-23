Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmInventoryMonitoring

    Private myData As DataTable
    Private Sub FrmInventoryMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadWarehouse()

        readyGridPerWhse()
    End Sub

    Private Sub readyGridPerWhse()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldWarehouse As New GridViewTextBoxColumn("WAREHOUSE")
        fldWarehouse.FieldName = "fldDescription"
        fldWarehouse.Width = 210
        gvData.Columns.Add(fldWarehouse)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("ITEM CODE")
        fldCustomerPartNo.FieldName = "fldItemCode"
        fldCustomerPartNo.Width = 100
        gvData.Columns.Add(fldCustomerPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 250
        gvData.Columns.Add(fldPartName)

        Dim fldInventoryQty As New GridViewDecimalColumn("BEGINNING QTY")
        fldInventoryQty.FieldName = "fldInventoryQty"
        fldInventoryQty.Width = 120
        gvData.Columns.Add(fldInventoryQty)
        gvData.Columns("fldInventoryQty").FormatString = "{0:N2}"

        Dim inQty As New GridViewDecimalColumn("IN QTY")
        inQty.FieldName = "inQty"
        inQty.Width = 120
        gvData.Columns.Add(inQty)
        gvData.Columns("inQty").FormatString = "{0:N2}"

        Dim issuedQty As New GridViewDecimalColumn("OUT QTY")
        issuedQty.FieldName = "outQty"
        issuedQty.Width = 100
        gvData.Columns.Add(issuedQty)
        gvData.Columns("outQty").FormatString = "{0:N2}"

        Dim currentStockQty As New GridViewDecimalColumn("STOCK QTY")
        currentStockQty.FieldName = "currentStockQty"
        currentStockQty.Width = 100
        gvData.Columns.Add(currentStockQty)
        gvData.Columns("currentStockQty").FormatString = "{0:N2}"

        Dim fldInventoryDate As New GridViewDateTimeColumn("LAST INVENTORY DATE")
        fldInventoryDate.FieldName = "fldInventoryDate"
        fldInventoryDate.Width = 170
        fldInventoryDate.Format = DateTimePickerFormat.Custom
        fldInventoryDate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldInventoryDate)
        gvData.Columns("fldInventoryDate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldInventoryBy As New GridViewTextBoxColumn("LAST INVENTORY BY")
        fldInventoryBy.FieldName = "fldInventoryBy"
        fldInventoryBy.Width = 160
        gvData.Columns.Add(fldInventoryBy)

        'Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        'fldDateAdded.FieldName = "fldDateAdded"
        'fldDateAdded.Width = 150
        'fldDateAdded.Format = DateTimePickerFormat.Custom
        'fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        'gvData.Columns.Add(fldDateAdded)
        'gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        'Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        'fldAddedBy.FieldName = "fldAddedBy"
        'fldAddedBy.Width = 100
        'gvData.Columns.Add(fldAddedBy)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

        Dim fldInventoryQtySum As New GridViewSummaryItem("fldInventoryQty", "{0:N2}", GridAggregateFunction.Sum)
        Dim inQtySum As New GridViewSummaryItem("inQty", "{0:N2}", GridAggregateFunction.Sum)
        Dim outQtySum As New GridViewSummaryItem("outQty", "{0:N2}", GridAggregateFunction.Sum)
        Dim currentStockQtySum As New GridViewSummaryItem("currentStockQty", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldInventoryQtySum)
        summaryRowItem.Add(inQtySum)
        summaryRowItem.Add(outQtySum)
        summaryRowItem.Add(currentStockQtySum)

        gvData.SummaryRowsBottom.Add(summaryRowItem)
    End Sub

    Private Sub readyGridPerline()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldWarehouse As New GridViewTextBoxColumn("WAREHOUSE")
        fldWarehouse.FieldName = "fldDescription"
        fldWarehouse.Width = 210
        gvData.Columns.Add(fldWarehouse)

        Dim fldLine As New GridViewTextBoxColumn("LINE")
        fldLine.FieldName = "fldLineName"
        fldLine.Width = 100
        gvData.Columns.Add(fldLine)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("ITEM CODE")
        fldCustomerPartNo.FieldName = "fldItemCode"
        fldCustomerPartNo.Width = 100
        gvData.Columns.Add(fldCustomerPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 250
        gvData.Columns.Add(fldPartName)

        Dim fldInventoryQty As New GridViewDecimalColumn("INVENTORY QTY")
        fldInventoryQty.FieldName = "fldInventoryQty"
        fldInventoryQty.Width = 120
        gvData.Columns.Add(fldInventoryQty)
        gvData.Columns("fldInventoryQty").FormatString = "{0:N2}"

        Dim receivedQty As New GridViewDecimalColumn("IN QTY")
        receivedQty.FieldName = "receivedQty"
        receivedQty.Width = 120
        gvData.Columns.Add(receivedQty)
        gvData.Columns("receivedQty").FormatString = "{0:N2}"

        Dim producedQty As New GridViewDecimalColumn("OUT QTY")
        producedQty.FieldName = "producedQty"
        producedQty.Width = 110
        gvData.Columns.Add(producedQty)
        gvData.Columns("producedQty").FormatString = "{0:N2}"

        Dim currentStockQty As New GridViewDecimalColumn("STOCK QTY")
        currentStockQty.FieldName = "currentStockQty"
        currentStockQty.Width = 100
        gvData.Columns.Add(currentStockQty)
        gvData.Columns("currentStockQty").FormatString = "{0:N2}"

        Dim fldInventoryDate As New GridViewDateTimeColumn("LAST INVENTORY DATE")
        fldInventoryDate.FieldName = "fldInventoryDate"
        fldInventoryDate.Width = 170
        fldInventoryDate.Format = DateTimePickerFormat.Custom
        fldInventoryDate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldInventoryDate)
        gvData.Columns("fldInventoryDate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldInventoryBy As New GridViewTextBoxColumn("LAST INVENTORY BY")
        fldInventoryBy.FieldName = "fldAddedBy"
        fldInventoryBy.Width = 160
        gvData.Columns.Add(fldInventoryBy)

        'Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        'fldDateAdded.FieldName = "fldDateAdded"
        'fldDateAdded.Width = 150
        'fldDateAdded.Format = DateTimePickerFormat.Custom
        'fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        'gvData.Columns.Add(fldDateAdded)
        'gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        'Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        'fldAddedBy.FieldName = "fldAddedBy"
        'fldAddedBy.Width = 100
        'gvData.Columns.Add(fldAddedBy)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowGroupPanel = False
        gvData.ShowFilteringRow = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

        Dim fldInventoryQtySum As New GridViewSummaryItem("fldInventoryQty", "{0:N2}", GridAggregateFunction.Sum)
        Dim receivedQtySum As New GridViewSummaryItem("receivedQty", "{0:N2}", GridAggregateFunction.Sum)
        Dim producedQtySum As New GridViewSummaryItem("producedQty", "{0:N2}", GridAggregateFunction.Sum)
        Dim currentStockQtySum As New GridViewSummaryItem("currentStockQty", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldInventoryQtySum)
        summaryRowItem.Add(receivedQtySum)
        summaryRowItem.Add(producedQtySum)
        summaryRowItem.Add(currentStockQtySum)

        gvData.SummaryRowsBottom.Add(summaryRowItem)

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

    Private Sub loadWarehouse()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllWarehouseCode")

        cbddWarehouse.DataSource = dt

        cbddWarehouse.DisplayMember = "fldDescription"
        cbddWarehouse.ValueMember = "fldCode"

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click

        gvData.Columns.Clear()
        gvData.SummaryRowsBottom.Clear()

        If cbddType.Text = "PER WAREHOUSE" Then
            readyGridPerWhse()
        Else
            readyGridPerline()
        End If

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        Slipknot.addParameter("parWarehouseCode", cbddWarehouse.SelectedValue)

        If cbddType.Text = "PER WAREHOUSE" Then
            myData = Slipknot.dbSelect("SP_SelectInventoryMonitoringByWhse")
        Else
            myData = Slipknot.dbSelect("SP_SelectInventoryMonitoringByLine")
        End If

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData

        If cbddType.Text = "PER LINE" Then
            Dim whseDescriptor As New GroupDescriptor()
            whseDescriptor.GroupNames.Add("fldDescription", ListSortDirection.Ascending)
            gvData.GroupDescriptors.Add(whseDescriptor)

            Dim lineDescriptor As New GroupDescriptor()
            lineDescriptor.GroupNames.Add("fldLineName", ListSortDirection.Ascending)
            gvData.GroupDescriptors.Add(lineDescriptor)

            miEnableGrouping.IsChecked = True

            gvData.ShowGroupPanel = True
            gvData.MasterTemplate.AutoExpandGroups = True
        End If

    End Sub

    Private Sub FrmInventoryMonitoring_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub



    Private Sub cbbExport_Click(sender As Object, e As EventArgs) Handles cbbExport.Click
        If gvData.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.gvData)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
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

    Private Sub gvData_CellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.CellFormatting

        If e.CellElement.ColumnInfo.HeaderText = "STOCK QTY" Then

            e.CellElement.DrawFill = True
            e.CellElement.BackColor = Color.Green
        Else
            e.CellElement.DrawFill = False
        End If

    End Sub

    Private Sub miPerWarehouse_Click(sender As Object, e As EventArgs) Handles miPerWarehouse.Click
        If Slipknot.IsFormOpen(frmImportInventoryPerWarehouse) Then
            frmImportInventoryPerWarehouse.Focus()
        Else
            If BulletForMyValentine.isRW("fldModInventoryMonitoring") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportInventoryPerWarehouse.Show(Me)
        End If
    End Sub

    Private Sub miPerLine_Click(sender As Object, e As EventArgs) Handles miPerLine.Click
        If Slipknot.IsFormOpen(frmImportInventoryPerLine) Then
            frmImportInventoryPerLine.Focus()
        Else
            If BulletForMyValentine.isRW("fldModInventoryMonitoring") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportInventoryPerLine.Show(Me)
        End If
    End Sub

    Private Sub gvData_ViewCellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.ViewCellFormatting
        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)

        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            'e.CellElement.BorderTopColor = DefaultBackColor
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed
        End If
    End Sub
End Class
