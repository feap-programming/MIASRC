Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class FrmCustomerDemand
    Private myData As DataTable
    Private Sub FrmCustomerDemand_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        bwLoadData.RunWorkerAsync()
        LoadDropDown()

        ddlModel.Text = ""
        txtDescription.Text = ""
        txtCustomer.Text = ""

        dtpDate.CustomFormat = "MMM, yyyy"
        dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDate.ShowUpDown = True
    End Sub
    Private Sub FrmCustomerDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        dtpDate.Value = Date.Now()

        loadModel()

        readyGridChild()
    End Sub
    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.ShowFilteringRow = True
        Else
            gvData.ShowFilteringRow = False
        End If
    End Sub
    Public Sub LoadDropDown()

        Dim fldCustomerName As New GridViewTextBoxColumn("CUST. CODE")
        fldCustomerName.FieldName = "customer"
        fldCustomerName.Width = 100
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim fldCustomerCode As New GridViewTextBoxColumn("PART NO")
        fldCustomerCode.FieldName = "fldCustomerPartNo"
        fldCustomerCode.Width = 100
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 200
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
        ddlModel.DataSource = dtCustomer
        ddlModel.ValueMember = "fldCustomerPartNo"
        ddlModel.DisplayMember = "fldCustomerPartNo"
        ddlModel.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlModel.AutoFilter = True
        ddlModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldCustomerPartNo"
        itemCode.Operator = FilterOperator.Contains
        ddlModel.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub readyGridChild()
        Dim fldID As New GridViewTextBoxColumn("ID")
        fldID.FieldName = "fldID"
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldCustomer As New GridViewTextBoxColumn("CUSTOMER")
        fldCustomer.FieldName = "fldCustomer"
        fldCustomer.Width = 100
        fldCustomer.IsVisible = True
        gvData.Columns.Add(fldCustomer)

        Dim fldModel As New GridViewTextBoxColumn("MODEL")
        fldModel.FieldName = "CPartNo"
        fldModel.Width = 120
        gvData.Columns.Add(fldModel)

        Dim fldItemNo As New GridViewTextBoxColumn("DESCRIPTION")
        fldItemNo.FieldName = "fldPartName"
        fldItemNo.Width = 200
        fldItemNo.IsVisible = True
        gvData.Columns.Add(fldItemNo)

        Dim fldFGModel As New GridViewTextBoxColumn("FG MODEL")
        fldFGModel.FieldName = "fldFGModel"
        fldFGModel.Width = 120
        gvData.Columns.Add(fldFGModel)

        Dim fldFGNo As New GridViewTextBoxColumn("FG NO")
        fldFGNo.FieldName = "fldItemCode"
        fldFGNo.Width = 120
        gvData.Columns.Add(fldFGNo)

        Dim fldCategory As New GridViewTextBoxColumn("CATEGORY")
        fldCategory.FieldName = "fldCategory"
        fldCategory.Width = 100
        gvData.Columns.Add(fldCategory)

        Dim fldBudget As New GridViewTextBoxColumn("BUDGET")
        fldBudget.FieldName = "fldBudget"
        fldBudget.Width = 120
        fldBudget.IsVisible = True
        gvData.Columns.Add(fldBudget)
        gvData.Columns("fldBudget").FormatString = "{0:N0}"

        Dim fldForecast As New GridViewTextBoxColumn("FORECAST")
        fldForecast.FieldName = "fldForecast"
        fldForecast.Width = 120
        fldForecast.IsVisible = True
        gvData.Columns.Add(fldForecast)
        gvData.Columns("fldForecast").FormatString = "{0:N0}"

        Dim fldLatestDemand As New GridViewTextBoxColumn("LATEST DEMAND")
        fldLatestDemand.FieldName = "fldLatestDemand"
        fldLatestDemand.Width = 120
        fldLatestDemand.IsVisible = True
        gvData.Columns.Add(fldLatestDemand)
        gvData.Columns("fldLatestDemand").FormatString = "{0:N0}"

        Dim fldDate As New GridViewDateTimeColumn("DATE")
        fldDate.FieldName = "fldDate"
        fldDate.Width = 120
        fldDate.Format = DateTimePickerFormat.Custom
        fldDate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDate)
        gvData.Columns("fldDate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub
    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If ddlModel.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select Customer", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If txtCustomer.Text = "" Then
            RadMessageBox.Show("Please select Model", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        Slipknot.addParameter("Customer", Regex.Replace(Trim(txtCustomer.Text), "\s+", " "))
        Slipknot.addParameter("_Description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
        Slipknot.addParameter("Model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
        Slipknot.addParameter("AddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
        Slipknot.addParameter("Budget", seBudget.Text)
        Slipknot.addParameter("Forecast", seForecast.Text)
        Slipknot.addParameter("LatestDemand", seLatestDemand.Text)
        Slipknot.addParameter("FDate", dtpDate.Value)
        Slipknot.addParameter("FGModel", Regex.Replace(Trim(mcbModel.SelectedValue), "\s+", " "))

        If Slipknot.dbAED("SP_InsertCustomerDemand") Then
            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
                RadMessageBox.Show("Successfully added", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End If
    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldID").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("IDArray", id)
        Slipknot.dbAED("SP_DeleteCustomerDemand")
    End Sub

    Private Sub bwOperation_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwOperation.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectAllCustomerDemand")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
        leCountRec.Text = gvData.Rows.Count
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("It will also delete all child record under this item, are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwOperation_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwOperation.ProgressChanged
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If Slipknot.IsFormOpen(FrmUpdateCustomerDemand) Then
            FrmUpdateCustomerDemand.Focus()
        Else
            FrmUpdateCustomerDemand.ShowDialog(Me)
        End If
    End Sub

    Private Sub cbUpload_Click(sender As Object, e As EventArgs) Handles cbImportData.Click
        If Slipknot.IsFormOpen(frmImportCustomerDemand) Then
            frmImportCustomerDemand.Focus()
        Else
            frmImportCustomerDemand.Show()
        End If
    End Sub

    Private Sub ddlCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlModel.SelectedIndexChanged
        If ddlModel.SelectedValue Is Nothing Then
            txtCustomer.Text = Nothing
        Else
            Dim selectedRow As GridViewDataRowInfo = CType(ddlModel.SelectedItem, GridViewDataRowInfo)
            txtCustomer.Text = selectedRow.Cells("customer").Value.ToString()
            txtDescription.Text = selectedRow.Cells("fldPartName").Value.ToString()
        End If
    End Sub

    Private Sub cbReport_Click(sender As Object, e As EventArgs) Handles cbReport.Click
        If Slipknot.IsFormOpen(FrmReportCustDemand) Then
            FrmReportCustDemand.Focus()
        Else
            FrmReportCustDemand.Show(Me)
        End If
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

    Private Sub loadModel()

        Dim dtModel As DataTable = Slipknot.dbSelect("SP_SelectAllModel")

        Dim fldModel As New GridViewTextBoxColumn("MODEL")
        fldModel.FieldName = "fldModelName"
        fldModel.Width = 160
        mcbModel.MultiColumnComboBoxElement.Columns.Add(fldModel)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 200
        mcbModel.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbModel.DataSource = dtModel
        mcbModel.ValueMember = "fldCode"
        mcbModel.DisplayMember = "fldModelName"
        mcbModel.MultiColumnComboBoxElement.DropDownWidth = 200

        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        mcbModel.AutoFilter = True
        mcbModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim model As New FilterDescriptor()
        model.PropertyName = "fldModelName"
        model.Operator = FilterOperator.Contains
        mcbModel.EditorControl.MasterTemplate.FilterDescriptors.Add(model)

    End Sub
End Class
