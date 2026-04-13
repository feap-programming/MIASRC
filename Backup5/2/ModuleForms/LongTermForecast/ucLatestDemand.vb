Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class ucLatestDemand

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtLatestDemand As DataTable

    Private parCustomerID As Integer
    Private parDateFrom As Date
    Private parDateTo As Date

    Private myData As DataTable

    Private Sub ucLatestDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeThemeUC(Me)

        dtDateFrom.Value = Now
        dtDateTo.Value = Now
        LoadCustomerDropDown(ddCustomerCode)

        SetUpColumns()

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then

            If Not String.IsNullOrWhiteSpace(ddCustomerCode.Text) Then

                parDateFrom = dtDateFrom.Value
                parDateTo = dtDateTo.Value
                parCustomerID = ddCustomerCode.SelectedValue

                bwLoadData.RunWorkerAsync()

            Else

                RadMessageBox.Show(Me, "Please select customer.", "Invalid Customer", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            End If

        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        If Not bwLoadData.CancellationPending Then

            Slipknot.addParameter("parCustomerID", parCustomerID)
            Slipknot.addParameter("parDateFrom", parDateFrom)
            Slipknot.addParameter("parDateTo", parDateTo)
            dtLatestDemand = Slipknot.dbSelect("SP_P_SelectLatestDemandByDateForecast")
            myData = dtLatestDemand

            RadProgressBarElement1.Text = "Done"
            bwLoadData.ReportProgress(Convert.ToInt32(100))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged

        If e.ProgressPercentage = 0 Then
            RadProgressBarElement1.Text = "Preparing..."
        ElseIf e.ProgressPercentage = 100 Then
            RadProgressBarElement1.Text = "Done"
        Else
            RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        End If

        RadProgressBarElement1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted

        If Not e.Cancelled Then

            gvData.DataSource = myData
            gvData.BestFitColumns()
            leCountRec.Text = gvData.Rows.Count

            If myData.Rows.Count = 0 Then

                RadMessageBox.Show(Me, "There are items not found in the master list", "Item Not Found", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            End If

        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("It will also delete all history record under this item, are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id += "," & Convert.ToString(rows(i).Cells("fldID").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("IDArray", id)
        Slipknot.dbAED("SP_P_DeleteLatestDemand")
    End Sub

    Private Sub bwOperation_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwOperation.ProgressChanged
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwOperation_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwOperation.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbBacklog_Click(sender As Object, e As EventArgs) Handles cbbBacklog.Click
        Dim editForm As New frmHistoryAllBacklogs
        editForm.ShowDialog(Me)
    End Sub

    'Private Sub cbUploaderTemplate_Click(sender As Object, e As EventArgs) Handles cbUploaderTemplate.Click
    '    Dim template As New frmLatestDemandUploaderTemplate
    '    template.Show(Me)
    'End Sub

    Private Sub miImportLatestDemand_Click(sender As Object, e As EventArgs) Handles miImportLatestDemand.Click
        Dim importForm As New FrmImportLatestDemand
        importForm.ShowDialog(Me)
    End Sub

    Private Sub miImportBacklog_Click(sender As Object, e As EventArgs) Handles miImportBacklog.Click
        Dim importForm As New FrmImportBacklog
        importForm.ShowDialog(Me)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub cbExport_Click(sender As Object, e As EventArgs) Handles cbExport.Click
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

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click

        Dim reportSelector As New FrmDemandPOMonitoringSelector
        reportSelector.Show()

    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.EnableFiltering = True
            gvData.MasterTemplate.ShowHeaderCellButtons = True
            gvData.MasterTemplate.ShowFilteringRow = True
        Else
            gvData.EnableFiltering = False
            gvData.MasterTemplate.ShowHeaderCellButtons = False
            gvData.MasterTemplate.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub gvData_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs) Handles gvData.ContextMenuOpening

        Dim cell As GridDataCellElement = TryCast(e.ContextMenuProvider, GridDataCellElement)

        If cell Is Nothing Then
            Return
        End If

        e.ContextMenu = cmActionChooser.DropDown

    End Sub

    Private Sub miCopy_Click(sender As Object, e As EventArgs) Handles miCopy.Click
        Dim selectionMode As GridViewSelectionMode = Me.gvData.SelectionMode
        Me.gvData.SelectionMode = GridViewSelectionMode.CellSelect
        Me.gvData.CurrentRow.Cells(Me.gvData.CurrentColumn.Name).IsSelected = True
        Me.gvData.Copy()
        Me.gvData.SelectionMode = selectionMode
        Me.gvData.CurrentRow.IsSelected = True
    End Sub

    Private Sub miEdit_Click(sender As Object, e As EventArgs) Handles miEdit.Click

        Try

            Dim id As Integer = 0
            id = gvData.CurrentRow.Cells("fldID").Value

            If id > 0 Then
                Dim editForm As New FrmEditLatestDemand
                editForm.ShowDialog(id)
                If bwLoadData.IsBusy = False Then
                    bwLoadData.RunWorkerAsync()
                End If
            End If

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub miHistory_Click(sender As Object, e As EventArgs) Handles miHistory.Click

        Try

            Dim id As Integer = 0
            id = gvData.CurrentRow.Cells("fldID").Value

            If id > 0 Then
                Dim historyForm As New FrmHistoryLatestDemand
                historyForm.ShowDialog(id)
            End If

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    'Public Shared Function ConvertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
    '    Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
    '    Dim table As DataTable = New DataTable()
    '    For Each prop As PropertyDescriptor In properties
    '        table.Columns.Add(prop.Name)
    '    Next

    '    For Each item As T In data
    '        Dim row As DataRow = table.NewRow()
    '        For Each prop As PropertyDescriptor In properties
    '            row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
    '        Next

    '        table.Rows.Add(row)
    '    Next

    '    Return table
    'End Function

    'Public Sub LoadDropDown()

    '    Dim fldId As New GridViewTextBoxColumn("ID") With {
    '        .FieldName = "fldId",
    '        .Width = 80,
    '        .IsVisible = False
    '    }
    '    ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldId)

    '    Dim fldCustomerName As New GridViewTextBoxColumn("CUST. CODE") With {
    '        .FieldName = "customer",
    '        .Width = 100
    '    }
    '    ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

    '    Dim fldCustomerCode As New GridViewTextBoxColumn("PART NO") With {
    '        .FieldName = "fldCustomerPartNo",
    '        .Width = 100
    '    }
    '    ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

    '    Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
    '        .FieldName = "fldItemCode",
    '        .Width = 100
    '    }
    '    ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

    '    Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
    '        .FieldName = "fldPartName",
    '        .Width = 200
    '    }
    '    ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldPartName)

    '    Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE") With {
    '        .FieldName = "modelCode",
    '        .Width = 100,
    '        .IsVisible = False
    '    }
    '    ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldModelCode)

    '    Dim fldModelName As New GridViewTextBoxColumn("MODEL") With {
    '        .FieldName = "model",
    '        .Width = 100
    '    }
    '    ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldModelName)

    '    Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
    '    ddlPartNo.DataSource = dtCustomer
    '    ddlPartNo.DisplayMember = "fldCustomerPartNo"
    '    ddlPartNo.ValueMember = "fldId"
    '    ddlPartNo.MultiColumnComboBoxElement.DropDownWidth = 450

    '    ddlPartNo.AutoFilter = True
    '    ddlPartNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    '    Dim customerPartNo As New FilterDescriptor With {
    '        .PropertyName = "fldCustomerPartNo",
    '        .Operator = FilterOperator.Contains
    '    }
    '    ddlPartNo.EditorControl.MasterTemplate.FilterDescriptors.Add(customerPartNo)

    '    ddlPartNo.SelectedIndex = -1
    '    ddlPartNo.Text = String.Empty

    'End Sub

    'Private Sub LoadTotalSummary()

    '    Dim totalSummary As New GridViewSummaryRowItem From {
    '        New GridViewSummaryItem("fldModelName", "Total", GridAggregateFunction.Var),
    '        New GridViewSummaryItem("fld1stMonthLD", "{0:#,##0.00}", GridAggregateFunction.Sum),
    '        New GridViewSummaryItem("fld2ndMonthLD", "{0:#,##0.00}", GridAggregateFunction.Sum),
    '        New GridViewSummaryItem("fld3rdMonthLD", "{0:#,##0.00}", GridAggregateFunction.Sum)
    '    }

    '    Me.gvData.MasterTemplate.SummaryRowsBottom.Add(totalSummary)
    '    Me.gvData.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

    'End Sub

    'Private Sub gvData_FilterPopupRequired(sender As Object, e As FilterPopupRequiredEventArgs) Handles gvData.FilterPopupRequired
    '    If TypeOf e.FilterPopup Is RadDateFilterPopup Then
    '        Dim popup As RadDateFilterPopup = DirectCast(e.FilterPopup, RadDateFilterPopup)
    '        popup.ClearCustomMenuItems()
    '        popup.AddCustomMenuItem("today", New DateFilterDescriptor(e.Column.Name, FilterOperator.IsEqualTo, DateTime.Today))
    '    Else
    '        e.FilterPopup = New RadSimpleListFilterPopup(e.Column)
    '    End If
    'End Sub

    'Private Sub gvData_ViewCellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.ViewCellFormatting

    '    If TypeOf e.CellElement Is GridSummaryCellElement Then
    '        e.CellElement.TextAlignment = ContentAlignment.MiddleRight
    '        e.CellElement.DrawFill = True
    '        e.CellElement.ForeColor = Color.FromArgb(0, 0, 0)
    '        e.CellElement.BackColor = Color.FromArgb(129, 236, 236)
    '        e.CellElement.BackColor2 = Color.FromArgb(129, 236, 236)
    '    Else
    '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
    '        e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
    '        e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
    '    End If

    'End Sub

    'Private Function TableQuery(tblNthMonth As DataTable, fldDateUpdated As Date, fldDateIssued As Date, fldCustomer As String, fldModel As String, fldPartNo As String, fldPartName As String, fldLDYear As Integer, fldLDMonth As Integer, nthMonth As Integer) As DataTable

    '    Dim dataTable As DataTable = Nothing

    '    Dim nthTable = (
    '        From T0 In tblNthMonth.AsEnumerable
    '        Where T0.Item("fldDateUpdated") = fldDateUpdated And
    '            T0.Item("fldDateIssued") = fldDateIssued And
    '            T0.Item("fldCustomer") = fldCustomer And
    '            T0.Item("fldModel") = fldModel And
    '            T0.Item("fldPartNo") = fldPartNo And
    '            T0.Item("fldPartName") = fldPartName And
    '            T0.Item("fldLDYear") = (New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Year And
    '            T0.Item("fldLDMonth") = (New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Month
    '        Select New With
    '            {
    '                .fldID = T0.Item("fldID"),
    '                .fldLDYear = T0.Item("fldLDYear"),
    '                .fldLDMonth = T0.Item("fldLDMonth"),
    '                .fldLDMonthName = T0.Item("fldLDMonthName"),
    '                .fldLatestDemand = T0.Item("fldLatestDemand"),
    '                .fldLDDelay = T0.Item("fldLDDelay"),
    '                .fldLDInTransit = T0.Item("fldLDInTransit")
    '            }
    '    ).ToList()

    '    dataTable = ConvertToDatatable(nthTable)

    '    If dataTable.Rows.Count <= 0 Then
    '        dataTable.Rows.Clear()
    '        dataTable = New DataTable
    '        dataTable.Columns.Add("fldID", GetType(Int64))
    '        dataTable.Columns.Add("fldLDYear", GetType(Integer))
    '        dataTable.Columns.Add("fldLDMonth", GetType(Integer))
    '        dataTable.Columns.Add("fldLDMonthName", GetType(String))
    '        dataTable.Columns.Add("fldLatestDemand", GetType(Int64))
    '        dataTable.Columns.Add("fldLDDelay", GetType(Int64))
    '        dataTable.Columns.Add("fldLDInTransit", GetType(Int64))
    '        dataTable.Rows.Add(Convert.ToDecimal(0), (New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Year, (New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Month, MonthName((New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Month), Convert.ToDecimal(0))
    '    End If

    '    Return dataTable

    'End Function

    Public Sub LoadCustomerDropDown(dropdown As RadMultiColumnComboBox)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUSTOMER ID") With {
            .FieldName = "fldId",
            .Width = 100
        }
        dropdown.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER CODE") With {
            .FieldName = "fldCustomerName",
            .Width = 200
        }
        dropdown.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")
        dropdown.DataSource = dtCustomer
        dropdown.DisplayMember = "fldCustomerName"
        dropdown.ValueMember = "fldId"
        dropdown.MultiColumnComboBoxElement.DropDownWidth = 350

        dropdown.AutoFilter = True
        dropdown.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerCode As New FilterDescriptor With {
            .PropertyName = "fldCustomerName",
            .Operator = Telerik.WinControls.Data.FilterOperator.Contains
        }
        dropdown.EditorControl.MasterTemplate.FilterDescriptors.Add(customerCode)

        dropdown.SelectedIndex = -1
        dropdown.Text = String.Empty

    End Sub

    Private Sub SetUpColumns()

        Dim fldID As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldID)

        Dim fldDateIssued As New GridViewDateTimeColumn("DATE ISSUED") With {
            .FieldName = "fldDateIssued",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateIssued)
        gvData.Columns("fldDateIssued").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDateForecast As New GridViewDateTimeColumn("DATE FORECAST") With {
            .FieldName = "fldDateForecast",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateForecast)
        gvData.Columns("fldDateForecast").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldCustomerName)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 200
        }
        gvData.Columns.Add(fldPartName)

        Dim fldQuantity As New GridViewDecimalColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldQuantity)
        gvData.Columns("fldQuantity").FormatString = "{0:N0}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY") With {
            .FieldName = "fldAddedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldAddedBy)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        gvData.TableElement.RowHeight = 25

    End Sub

End Class
