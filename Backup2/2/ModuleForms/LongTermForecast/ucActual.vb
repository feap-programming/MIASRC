Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class ucActual

    Private myData As DataTable
    Private myDataList As Object
    Private customerCode As String = String.Empty
    Private modelCode As String = String.Empty

    Private Sub ucActualLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeThemeUC(Me)

        Me.dtETDFEAP.Value = Today
        Me.dtATDFEAP.Value = Today
        Me.dtETDManila.Value = Today
        Me.dtATDManila.Value = Today
        Me.dtATACustomer.Value = Today

        RemoveHandler ddlPartNo.SelectedIndexChanged, AddressOf ddlPartNo_SelectedIndexChanged
        LoadDropDown()
        AddHandler ddlPartNo.SelectedIndexChanged, AddressOf ddlPartNo_SelectedIndexChanged

        'mcbAnnex.Enabled = False

        txtInvoiceNo.Text = String.Empty
        txtCustomer.Text = String.Empty
        txtModel.Text = String.Empty
        txtPartName.Text = String.Empty
        numUnitPrice.Value = 0.0
        numQuantity.Value = 0.0
        ddCurrency.SelectedIndex = ddCurrency.FindStringExact("JPY")

        SetUpColumns()
        LoadTotalSummary()

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork

        bwLoadData.ReportProgress(Convert.ToInt32(0))
        Threading.Thread.Sleep(delay)

        If Not bwLoadData.CancellationPending Then

            myData = Slipknot.dbSelect("SP_P_SelectAllActual")
            myDataList = myData

            bwLoadData.ReportProgress(Convert.ToInt32(100))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged

        If e.ProgressPercentage = 0 Then
            RadProgressBarElement1.Text = "Preparing..."
        ElseIf e.ProgressPercentage = 100 Then
            RadProgressBarElement1.Text = "Done"
        Else
            RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        End If

        RadProgressBarElement1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted

        If Not e.Cancelled Then

            gvData.DataSource = myDataList
            gvData.BestFitColumns()
            leCountRec.Text = gvData.Rows.Count

        End If

    End Sub

    Private Sub ddlPartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPartNo.SelectedIndexChanged

        If ddlPartNo.SelectedIndex >= 0 Then

            Dim dtModel As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
            Dim modelRow As DataRow() = dtModel.Select("fldId = " & ddlPartNo.SelectedValue & "")

            If modelRow.Count > 0 Then

                'mcbAnnex.Enabled = True
                'LoadAnnexDropDown(modelRow(0).Item("fldItemCode"), modelRow(0).Item("fldCustomerCode"), modelRow(0).Item("fldPartName"))

                txtPartName.Text = modelRow(0).Item("fldPartName")
                modelCode = modelRow(0).Item("modelCode")
                txtModel.Text = modelRow(0).Item("model")
                customerCode = modelRow(0).Item("fldCustomerCode")
                txtCustomer.Text = modelRow(0).Item("customer")
            Else

                'mcbAnnex.Enabled = False
                'mcbAnnex.DataSource = Nothing

                txtPartName.Text = String.Empty
                modelCode = String.Empty
                txtModel.Text = String.Empty
                customerCode = String.Empty
                txtCustomer.Text = String.Empty
            End If

        End If

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Try

            Dim dtItemMaster As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
            Dim itemMasterRow As DataRow() = dtItemMaster.Select(
                    "customer = '" & txtCustomer.Text & "' AND " &
                    "model = '" & txtModel.Text & "' AND " &
                    "fldItemCode = '" & ddlPartNo.Text & "'"
                )

            If itemMasterRow.Count > 0 Then

                Dim notSaved As String = String.Empty

                Dim confirmResult As DialogResult = RadMessageBox.Show(Me, "Please confirm to add actual for " & Regex.Replace(Trim(ddlPartNo.Text), "\s+", " "), "SAVING",
                                                           MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
                If confirmResult = DialogResult.Yes Then

                    Slipknot.addParameter("parInvoiceNo", Me.txtInvoiceNo.Text)
                    Slipknot.addParameter("parETDFEAP", Me.dtETDFEAP.Value)
                    Slipknot.addParameter("parATDFEAP", Me.dtATDFEAP.Value)
                    Slipknot.addParameter("parETDManila", Me.dtETDManila.Value)
                    Slipknot.addParameter("parATDManila", Me.dtATDManila.Value)
                    Slipknot.addParameter("parATACustomer", Me.dtATACustomer.Value)
                    Slipknot.addParameter("parCustomer", Regex.Replace(Trim(itemMasterRow(0).Item("fldCustomerCode")), "\s+", " "))
                    Slipknot.addParameter("parModel", Regex.Replace(Trim(itemMasterRow(0).Item("modelCode")), "\s+", " "))
                    Slipknot.addParameter("parPartNo", Regex.Replace(Trim(ddlPartNo.Text), "\s+", " "))
                    Slipknot.addParameter("parPartName", Regex.Replace(Trim(txtPartName.Text), "\s+", " "))
                    'Slipknot.addParameter("parAnnexID", mcbAnnex.SelectedValue)
                    Slipknot.addParameter("parUnitPrice", numUnitPrice.Value)
                    Slipknot.addParameter("parCurrency", Regex.Replace(Trim(ddCurrency.Text), "\s+", " "))
                    Slipknot.addParameter("parQuantity", numQuantity.Value)
                    Slipknot.addParameter("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                    If Not Slipknot.dbAED("SP_P_InsertActual") Then
                        notSaved += "Error"
                    End If

                    If bwLoadData.IsBusy = False Then
                        bwLoadData.RunWorkerAsync()
                        If String.IsNullOrWhiteSpace(notSaved) Then
                            RadMessageBox.Show("Actual successfully added.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                        Else
                            RadMessageBox.Show("Error in saving actual.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                        End If
                    End If

                End If

            Else
                RadMessageBox.Show("Please select correct Part No.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If

        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try

    End Sub

    Private Sub cbbUpdate_Click(sender As Object, e As EventArgs) Handles cbbUpdate.Click
        Dim updateForm As New FrmUpdateActual
        updateForm.ShowDialog(Me)
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
        Slipknot.dbAED("SP_P_DeleteActual")

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

    Private Sub cbUploaderTemplate_Click(sender As Object, e As EventArgs) Handles cbUploaderTemplate.Click
        Dim template As New FrmActualUploaderTemplate
        template.Show(Me)
    End Sub

    Private Sub cbImportData_Click(sender As Object, e As EventArgs) Handles cbImportData.Click
        Dim importForm As New FrmImportActual
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

        'Dim reportSelector As New FrmLatestDemandReportSelector
        'reportSelector.Show()

    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.MasterTemplate.ShowHeaderCellButtons = True
        Else
            gvData.MasterTemplate.ShowHeaderCellButtons = False
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

            Dim editForm As New FrmEditActual
            editForm.ShowDialog(gvData.CurrentRow.Cells("fldID").Value)

        Catch ex As System.Reflection.AmbiguousMatchException

            RadMessageBox.Show(Me, "Please select proper row.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub miHistory_Click(sender As Object, e As EventArgs) Handles miHistory.Click

        Try

            Dim id As Integer = 0
            id = gvData.CurrentRow.Cells("fldID").Value

            Dim editForm As New FrmHistoryActual
            editForm.ShowDialog(id)

        Catch ex As System.Reflection.AmbiguousMatchException

            RadMessageBox.Show(Me, "Please select proper row.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub LoadTotalSummary()

        Dim totalSummary As New GridViewSummaryRowItem From {
            New GridViewSummaryItem("fldModelName", "Total", GridAggregateFunction.Var),
            New GridViewSummaryItem("fldQuantity", "{0:#,##0.00}", GridAggregateFunction.Sum)
        }

        Me.gvData.MasterTemplate.SummaryRowsBottom.Add(totalSummary)
        Me.gvData.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.CellFormatting

        If e.CellElement.ColumnInfo.FieldName = "fldETDFEAP" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldETDManila" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldATDFEAP" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldATDManila" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldATACustomer" Then
            If e.CellElement.Value = #0001-01-01# Then
                e.CellElement.ForeColor = Color.Transparent
            Else
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            End If
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

    End Sub

    Private Sub gvData_ViewCellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.ViewCellFormatting

        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            e.CellElement.DrawFill = True
            e.CellElement.ForeColor = Color.FromArgb(0, 0, 0)
            e.CellElement.BackColor = Color.FromArgb(129, 236, 236)
            e.CellElement.BackColor2 = Color.FromArgb(129, 236, 236)
        Else
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

    End Sub

    Public Sub LoadDropDown()

        Dim fldId As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldId",
            .Width = 80,
            .IsVisible = False
        }
        ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldId)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUST. CODE") With {
            .FieldName = "customer",
            .Width = 100
        }
        ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim fldCustomerCode As New GridViewTextBoxColumn("PART NO") With {
            .FieldName = "fldCustomerPartNo",
            .Width = 100
        }
        ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 100
        }
        ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
        ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE") With {
            .FieldName = "modelCode",
            .Width = 100,
            .IsVisible = False
        }
        ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldModelCode)

        Dim fldModelName As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "model",
            .Width = 100
        }
        ddlPartNo.MultiColumnComboBoxElement.Columns.Add(fldModelName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
        ddlPartNo.DataSource = dtCustomer
        ddlPartNo.DisplayMember = "fldItemCode"
        ddlPartNo.ValueMember = "fldId"
        ddlPartNo.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlPartNo.AutoFilter = True
        ddlPartNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerPartNo As New FilterDescriptor With {
            .PropertyName = "fldItemCode",
            .Operator = FilterOperator.Contains
        }
        ddlPartNo.EditorControl.MasterTemplate.FilterDescriptors.Add(customerPartNo)

        ddlPartNo.SelectedIndex = -1
        ddlPartNo.Text = String.Empty

    End Sub

    'Public Sub LoadAnnexDropDown(parItemCode As String, parCustomer As String, parPartName As String)

    '    mcbAnnex.MultiColumnComboBoxElement.Columns.Clear()
    '    mcbAnnex.DataSource = Nothing

    '    Dim fldId As New GridViewTextBoxColumn("ID") With {
    '        .FieldName = "fldId",
    '        .Width = 80,
    '        .IsVisible = False
    '    }
    '    mcbAnnex.MultiColumnComboBoxElement.Columns.Add(fldId)

    '    Dim fldNewItemCode As New GridViewTextBoxColumn("ANNEX") With {
    '        .FieldName = "fldNewItemCode",
    '        .Width = 100
    '    }
    '    mcbAnnex.MultiColumnComboBoxElement.Columns.Add(fldNewItemCode)

    '    Dim fldEffectivityDate As New GridViewDateTimeColumn("EFF. DATE") With {
    '        .FieldName = "fldEffectivityDate",
    '        .MinWidth = 110,
    '        .Format = DateTimePickerFormat.Custom,
    '        .CustomFormat = "MMM dd, yyyy HH:mm",
    '        .TextAlignment = ContentAlignment.MiddleCenter
    '    }
    '    mcbAnnex.MultiColumnComboBoxElement.Columns.Add(fldEffectivityDate)
    '    mcbAnnex.Columns("fldEffectivityDate").FormatString = "{0:MMM dd, yyyy HH:mm}"

    '    Slipknot.addParameter("parItemCode", parItemCode)
    '    Slipknot.addParameter("parCustomer", parCustomer)
    '    Slipknot.addParameter("parPartName", parPartName)
    '    Dim dtAnnex As DataTable = Slipknot.dbSelect("SP_P_SelectPartNoAnnex")
    '    mcbAnnex.DataSource = dtAnnex
    '    mcbAnnex.DisplayMember = "fldNewItemCode"
    '    mcbAnnex.ValueMember = "fldId"
    '    mcbAnnex.MultiColumnComboBoxElement.DropDownWidth = 250

    'End Sub

    Private Sub SetUpColumns()

        Dim fldID As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = False
        }
        gvData.Columns.Add(fldID)

        Dim fldInvoiceNo As New GridViewTextBoxColumn("INVOICE NO.") With {
            .FieldName = "fldInvoiceNo",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldInvoiceNo)

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDFEAP)
        gvData.Columns("fldETDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETDManila As New GridViewDateTimeColumn("ETD MNL") With {
            .FieldName = "fldETDManila",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDManila)
        gvData.Columns("fldETDManila").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATDFEAP As New GridViewDateTimeColumn("ATD FEAP") With {
            .FieldName = "fldATDFEAP",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldATDFEAP)
        gvData.Columns("fldATDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATDManila As New GridViewDateTimeColumn("ATD MNL") With {
            .FieldName = "fldATDManila",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldATDManila)
        gvData.Columns("fldATDManila").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATACustomer As New GridViewDateTimeColumn("ATA Customer") With {
            .FieldName = "fldATACustomer",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldATACustomer)
        gvData.Columns("fldATACustomer").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomer As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomer",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldCustomer)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldCustomerName)

        Dim fldModel As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "fldModel",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldModel)

        Dim fldModelName As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "fldModelName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldModelName)

        Dim fldPartNo As New GridViewTextBoxColumn("PART NO") With {
            .FieldName = "fldPartNo",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 200
        }
        gvData.Columns.Add(fldPartName)

        Dim fldUnitPrice As New GridViewDecimalColumn("UNIT PRICE") With {
            .FieldName = "fldUnitPrice",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight
        }
        gvData.Columns.Add(fldUnitPrice)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY") With {
            .FieldName = "fldCurrency",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldCurrency)

        Dim fldQuantity As New GridViewDecimalColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight
        }
        gvData.Columns.Add(fldQuantity)

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS") With {
            .FieldName = "fldRemarks",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldRemarks)

        gvData.TableElement.RowHeight = 25

    End Sub

End Class
