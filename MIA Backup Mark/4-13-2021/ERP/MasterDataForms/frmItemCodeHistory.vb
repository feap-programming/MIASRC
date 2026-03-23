Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class frmItemCodeHistory

    Private FGNo As String
    Private customer As String
    Private customerCode As String
    Private initialNewItemCode As String
    Private Sub FrmCompanyPartNoHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        dtpEffectivityDate.Format = DateTimePickerFormat.Custom
        dtpEffectivityDate.CustomFormat = "MMM dd, yyyy"
        dtpEffectivityDate.Value = Today

        loadDropDown()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 150
        gvData.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 170
        gvData.Columns.Add(fldPartName)

        Dim fldNewItemCode As New GridViewTextBoxColumn("NEW ITEM CODE")
        fldNewItemCode.FieldName = "fldNewItemCode"
        fldNewItemCode.Width = 150
        gvData.Columns.Add(fldNewItemCode)

        Dim customer As New GridViewTextBoxColumn("CUSTOMER")
        customer.FieldName = "customer"
        customer.Width = 120
        gvData.Columns.Add(customer)

        Dim fldPrice As New GridViewDecimalColumn("PRICE")
        fldPrice.FieldName = "fldPrice"
        fldPrice.Width = 80
        gvData.Columns.Add(fldPrice)
        gvData.Columns("fldPrice").FormatString = "{0:N2}"

        Dim fldEffectivityDate As New GridViewDateTimeColumn("EFFECTIVITY DATE")
        fldEffectivityDate.FieldName = "fldEffectivityDate"
        fldEffectivityDate.Width = 150
        fldEffectivityDate.Format = DateTimePickerFormat.Custom
        fldEffectivityDate.CustomFormat = "MMM dd, yyyy"
        gvData.Columns.Add(fldEffectivityDate)
        gvData.Columns("fldEffectivityDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS")
        fldRemarks.FieldName = "fldRemarks"
        fldRemarks.Width = 150
        gvData.Columns.Add(fldRemarks)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvData.Columns.Add(fldAddedBy)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25
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

    Dim myData As DataTable
    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        myData = Slipknot.dbSelect("SP_SelectAllPartyNoHistory")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmCompanyPartNoHistory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
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

    Private Sub loadDropDown()

        'LOAD ITEM MASTER DATA

        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim fldCompanyPartNo As New GridViewTextBoxColumn("ITEM CODE")
        fldCompanyPartNo.FieldName = "fldItemCode"
        fldCompanyPartNo.Width = 160
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldCompanyPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 200
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldCategory As New GridViewTextBoxColumn("CATEGORY")
        fldCategory.FieldName = "fldCategory"
        fldCategory.IsVisible = False
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldCategory)

        Dim fldSellable As New GridViewCheckBoxColumn("SELLABLE")
        fldSellable.FieldName = "fldSellable"
        fldSellable.Width = 100
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldSellable)

        mcbItemCode.DataSource = dtProduct
        mcbItemCode.ValueMember = "fldItemCode"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 630

        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCode.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

        'LOAD CUSTOMER

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSROMER NAME")
        fldCustomerName.FieldName = "fldCustomerName"
        fldCustomerName.Width = 150
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CODE")
        fldCustomerCode.FieldName = "fldCustomerCode"
        fldCustomerCode.Width = 100
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        mcbCustomer.DataSource = dtCustomer
        mcbCustomer.ValueMember = "fldCustomerCode"
        mcbCustomer.DisplayMember = "fldCustomerName"
        mcbCustomer.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbCustomer.AutoFilter = True
        mcbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerName As New FilterDescriptor()
        customerName.PropertyName = "fldCustomerName"
        customerName.Operator = FilterOperator.Contains
        mcbCustomer.EditorControl.MasterTemplate.FilterDescriptors.Add(customerName)

    End Sub

    Private Sub constructCompanyPartNo()

        If mcbItemCode.SelectedValue IsNot Nothing Then

            If Convert.ToBoolean(mcbItemCode.EditorControl.CurrentRow.Cells("fldSellable").Value) Then

                If mcbCustomer.SelectedValue Is Nothing Then
                    customer = Nothing
                    customerCode = Nothing
                Else
                    customer = Convert.ToString(mcbCustomer.EditorControl.CurrentRow.Cells("fldCustomerName").Value)
                    customerCode = Convert.ToString(mcbCustomer.EditorControl.CurrentRow.Cells("fldCustomerCode").Value)
                End If

                mcbCustomer.Enabled = True
            Else
                customer = Nothing
                mcbCustomer.Enabled = False
            End If

            Dim category As String

            category = Convert.ToString(mcbItemCode.EditorControl.CurrentRow.Cells("fldCategory").Value)

            If chkSpecialDemand.Checked Then
                customer = "Sd"
            End If

            If category = "SRC" Then
                txtNewItemCode.Text = Convert.ToString(FGNo & "-" & customer & txtAnnex.Text.ToLower.TrimStart.TrimEnd)
                initialNewItemCode = Convert.ToString(FGNo & "-" & customer)
            Else
                txtNewItemCode.Text = Convert.ToString(FGNo & txtAnnex.Text.ToLower.TrimStart.TrimEnd)
                initialNewItemCode = Convert.ToString(FGNo)
            End If

        End If

    End Sub

    Private Sub txtAnnex_TextChanged(sender As Object, e As EventArgs) Handles txtAnnex.TextChanged
        constructCompanyPartNo()
    End Sub

    Private Sub mcbCustomerPartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemCode.SelectedIndexChanged
        If mcbItemCode.SelectedValue Is Nothing Then
            FGNo = Nothing
        Else
            FGNo = Convert.ToString(mcbItemCode.SelectedValue)
        End If

        constructCompanyPartNo()
    End Sub

    Private Sub mcbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbCustomer.SelectedIndexChanged
        If mcbCustomer.SelectedValue Is Nothing Then
            customer = Nothing
        Else
            customer = Convert.ToString(mcbCustomer.EditorControl.CurrentRow.Cells("fldCustomerName").Value)
        End If

        constructCompanyPartNo()
    End Sub

    Private Sub cbbAddRecord_Click(sender As Object, e As EventArgs) Handles cbbAddRecord.Click

        If BulletForMyValentine.isRW("fldMDItemCodeHistory") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If mcbCustomer.Enabled = True Then
            If mcbItemCode.SelectedValue Is Nothing Then
                RadMessageBox.Show("Please select customer part number properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

                Exit Sub
            End If
        End If

        If txtAnnex.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Part number annex cannot be null", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If Convert.ToBoolean(mcbItemCode.EditorControl.CurrentRow.Cells("fldSellable").Value) And sePrice.Value = 0 Then
            RadMessageBox.Show("Sellable item should have price", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
        Slipknot.addParameter("parNewItemCode", txtNewItemCode.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parInitNewItemCode", initialNewItemCode)
        Slipknot.addParameter("parCustomerCode", customerCode)
        Slipknot.addParameter("parPrice", sePrice.Value)
        Slipknot.addParameter("parEffectivityDate", dtpEffectivityDate.Value)
        Slipknot.addParameter("parRemarks", txtRemarks.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertPartNoHistory") Then

            txtAnnex.Clear()
            sePrice.Value = 0

            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If

        End If

    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("parIdArray", id)
        Slipknot.dbAED("SP_DeletePartNoHistory")

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

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        If BulletForMyValentine.isRW("fldMDItemCodeHistory") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub chkSpecialDemand_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkSpecialDemand.ToggleStateChanged
        constructCompanyPartNo()
    End Sub

    Private Sub cbbImport_Click(sender As Object, e As EventArgs) Handles cbbImport.Click
        If Slipknot.IsFormOpen(frmImportItemCodeHistory) Then
            frmImportItemCodeHistory.Focus()
        Else
            If BulletForMyValentine.isRW("fldMDItemCodeHistory") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportItemCodeHistory.Show(Me)
        End If
    End Sub
End Class
