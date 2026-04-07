Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmProductionOutput

    Private dtpFrom As New RadDateTimePicker
    Private dtpTo As New RadDateTimePicker

    Private recordID As String
    Private Sub FrmProductionOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        cbhFrom.HostedItem = dtpFrom.DateTimePickerElement
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MMM dd, yyyy"
        dtpFrom.Value = Today

        cbhTo.HostedItem = dtpTo.DateTimePickerElement
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.CustomFormat = "MMM dd, yyyy"
        dtpTo.Value = Today

        loadFrom()
        loadLine()
        loadShift()
        loadItemCode()
        loadOutputCategory()
        loadProcess()
        loadProcessComPerProcess()
        loadCustomer()

        mcbProcess.SelectedIndex = -1
        mcbAssemblyProcessName.SelectedIndex = -1
        mcbCustomer.SelectedIndex = -1

        readAssyProcessName()
        readLinePartition()
        readyGrid()
    End Sub

    Private Sub readAssyProcessName()

        Dim fldCode As New GridViewTextBoxColumn("Code")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.ReadOnly = True
        gvAssyProcessName.Columns.Add(fldCode)

        Dim fldProcessName As New GridViewTextBoxColumn("Process")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 130
        fldProcessName.ReadOnly = True
        gvAssyProcessName.Columns.Add(fldProcessName)

        gvAssyProcessName.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvAssyProcessName.AllowAddNewRow = False
        gvAssyProcessName.ShowFilteringRow = False
        gvAssyProcessName.ShowGroupPanel = False
        gvAssyProcessName.EnableSorting = False
        gvAssyProcessName.AllowColumnReorder = False
        gvAssyProcessName.AllowRowReorder = False

    End Sub

    Private Sub readLinePartition()

        Dim fldFrom As New GridViewDateTimeColumn("From")
        fldFrom.FieldName = "fldFrom"
        fldFrom.EditorType = GridViewDateTimeEditorType.DateTimePicker
        fldFrom.FormatString = "{0:MMM dd, yyyy HH:mm:ss}"
        fldFrom.Format = DateTimePickerFormat.Custom
        fldFrom.CustomFormat = "MMM dd, yyyy HH:mm:ss"
        fldFrom.Width = 120
        fldFrom.TextAlignment = ContentAlignment.MiddleCenter
        gvLineTimePartition.Columns.Add(fldFrom)

        Dim fldTo As New GridViewDateTimeColumn("To")
        fldTo.FieldName = "fldTo"
        fldTo.EditorType = GridViewDateTimeEditorType.DateTimePicker
        fldTo.FormatString = "{0:MMM dd, yyyy HH:mm:ss}"
        fldTo.Format = DateTimePickerFormat.Custom
        fldTo.CustomFormat = "MMM dd, yyyy HH:mm:ss"
        fldTo.Width = 120
        fldTo.TextAlignment = ContentAlignment.MiddleCenter
        gvLineTimePartition.Columns.Add(fldTo)

        gvLineTimePartition.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvLineTimePartition.AllowAddNewRow = True
        gvLineTimePartition.ShowFilteringRow = False
        gvLineTimePartition.ShowGroupPanel = False
        gvLineTimePartition.EnableSorting = False
        gvLineTimePartition.AllowColumnReorder = False
        gvLineTimePartition.AllowRowReorder = False

    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldPartNo"
        fldItemCode.Width = 80
        gvData.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 220
        gvData.Columns.Add(fldPartName)

        Dim whse As New GridViewTextBoxColumn("WAREHOUSE")
        whse.FieldName = "fldDescription"
        whse.Width = 210
        gvData.Columns.Add(whse)

        Dim line As New GridViewTextBoxColumn("LINE")
        line.FieldName = "fldLineName"
        line.Width = 130
        gvData.Columns.Add(line)

        Dim fldOutputQty As New GridViewDecimalColumn("OUTPUT QTY")
        fldOutputQty.FieldName = "fldQty"
        fldOutputQty.Width = 110
        gvData.Columns.Add(fldOutputQty)
        gvData.Columns("fldQty").FormatString = "{0:N2}"

        Dim fldShiftName As New GridViewTextBoxColumn("SHIFT")
        fldShiftName.FieldName = "fldShiftName"
        fldShiftName.Width = 90
        gvData.Columns.Add(fldShiftName)

        Dim fldOutputName As New GridViewTextBoxColumn("OUTPUT CATEGORY")
        fldOutputName.FieldName = "fldOutputName"
        fldOutputName.Width = 120
        gvData.Columns.Add(fldOutputName)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldEmpAdded"
        fldAddedBy.Width = 100
        gvData.Columns.Add(fldAddedBy)

        Dim fldLastDateUpdate As New GridViewDateTimeColumn("LAST UPDATE DATE")
        fldLastDateUpdate.FieldName = "fldLastUpdate"
        fldLastDateUpdate.Width = 170
        fldLastDateUpdate.Format = DateTimePickerFormat.Custom
        fldLastDateUpdate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldLastDateUpdate)
        gvData.Columns("fldLastUpdate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldLastUpdatedBy As New GridViewTextBoxColumn("LAST UPDATE BY")
        fldLastUpdatedBy.FieldName = "fldLastUpdateBy"
        fldLastUpdatedBy.Width = 150
        gvData.Columns.Add(fldLastUpdatedBy)

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS")
        fldRemarks.FieldName = "fldUpdateRemarks"
        fldRemarks.Width = 200
        gvData.Columns.Add(fldRemarks)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub FrmProductionOutput_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        mcbItemCode.SelectedIndex = -1

        seNoOfPIC.NullableValue = Nothing
        seOprTime.NullableValue = Nothing
        seBStartUp.NullableValue = Nothing
        sePlanDowntime.NullableValue = Nothing
        seUnPlanDowntime.NullableValue = Nothing

        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub loadFrom()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllWarehouseCode")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldDescription", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 250
        mcbWarehouse.MultiColumnComboBoxElement.Columns.Add(fldDescription)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 100
        mcbWarehouse.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbWarehouse.DataSource = dt
        mcbWarehouse.ValueMember = "fldCode"
        mcbWarehouse.DisplayMember = "fldDescription"
        mcbWarehouse.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbWarehouse.AutoFilter = True
        mcbWarehouse.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldDescription"
        desc.Operator = FilterOperator.Contains
        mcbWarehouse.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub

    Private Sub loadLine()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllLines")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldLineName", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldLineName As New GridViewTextBoxColumn("LINE NAME")
        fldLineName.FieldName = "fldLineName"
        fldLineName.Width = 150
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldLineName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 100
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbLine.DataSource = dt
        mcbLine.ValueMember = "fldCode"
        mcbLine.DisplayMember = "fldLineName"
        mcbLine.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbLine.AutoFilter = True
        mcbLine.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor()
        name.PropertyName = "fldLineName"
        name.Operator = FilterOperator.Contains
        mcbLine.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

    End Sub

    Private Sub loadShift()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllShifts")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldShiftName", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldShiftName As New GridViewTextBoxColumn("SHIFT")
        fldShiftName.FieldName = "fldShiftName"
        fldShiftName.Width = 150
        mcbShift.MultiColumnComboBoxElement.Columns.Add(fldShiftName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 100
        mcbShift.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbShift.DataSource = dt
        mcbShift.ValueMember = "fldCode"
        mcbShift.DisplayMember = "fldShiftName"
        mcbShift.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbShift.AutoFilter = True
        mcbShift.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldShiftName"
        desc.Operator = FilterOperator.Contains
        mcbShift.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub

    Private Sub loadItemCode()

        Dim dtItemCode As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 70
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 150
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemCode.DataSource = dtItemCode
        mcbItemCode.ValueMember = "fldItemCode"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCode.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub

    Private Sub loadProcess()

        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllProcess")

        Dim fldProcessCode As New GridViewTextBoxColumn("CODE")
        fldProcessCode.FieldName = "fldCode"
        fldProcessCode.Width = 70
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldProcessCode)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS NAME")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 250
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldProcessName)

        mcbProcess.DataSource = dtProcess
        mcbProcess.ValueMember = "fldCode"
        mcbProcess.DisplayMember = "fldProcessName"
        mcbProcess.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbProcess.AutoFilter = True
        mcbProcess.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim code As New FilterDescriptor("fldCode", FilterOperator.Contains, "")
        Dim name As New FilterDescriptor("fldProcessName", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(code)
        compositeFilter.FilterDescriptors.Add(name)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.mcbProcess.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub loadProcessComPerProcess()

        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllPComponentList")

        Dim fldProcessCode As New GridViewTextBoxColumn("Code")
        fldProcessCode.FieldName = "fldCode"
        fldProcessCode.Width = 70
        mcbAssemblyProcessName.MultiColumnComboBoxElement.Columns.Add(fldProcessCode)

        Dim processName As New GridViewTextBoxColumn("Process Name")
        processName.FieldName = "fldName"
        processName.Width = 250
        mcbAssemblyProcessName.MultiColumnComboBoxElement.Columns.Add(processName)

        mcbAssemblyProcessName.DataSource = dtProcess
        mcbAssemblyProcessName.ValueMember = "fldCode"
        mcbAssemblyProcessName.DisplayMember = "fldName"
        mcbAssemblyProcessName.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbAssemblyProcessName.AutoFilter = True
        mcbAssemblyProcessName.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim code As New FilterDescriptor("fldCode", FilterOperator.Contains, "")
        Dim name As New FilterDescriptor("fldName", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(code)
        compositeFilter.FilterDescriptors.Add(name)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.mcbAssemblyProcessName.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub loadCustomer()

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")

        Dim fldCustomerCode As New GridViewTextBoxColumn("CODE")
        fldCustomerCode.FieldName = "fldCustomerCode"
        fldCustomerCode.Width = 70
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER NAME")
        fldCustomerName.FieldName = "fldCustomerName"
        fldCustomerName.Width = 250
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        mcbCustomer.DataSource = dtCustomer
        mcbCustomer.ValueMember = "fldCustomerCode"
        mcbCustomer.DisplayMember = "fldCustomerName"
        mcbCustomer.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbCustomer.AutoFilter = True
        mcbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim code As New FilterDescriptor("fldCustomerCode", FilterOperator.Contains, "")
        Dim name As New FilterDescriptor("fldCustomerName", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(code)
        compositeFilter.FilterDescriptors.Add(name)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.mcbCustomer.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
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

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
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

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If BulletForMyValentine.isRW("fldModProductionOutput") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If mcbWarehouse.SelectedValue Is Nothing Then
            RadMessageBox.Show("Warehouse cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbWarehouse.Select()
            Exit Sub
        End If

        If mcbLine.SelectedValue Is Nothing Then
            RadMessageBox.Show("Line cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbLine.Select()
            Exit Sub
        End If

        If mcbShift.SelectedValue Is Nothing Then
            RadMessageBox.Show("Shift cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbShift.Select()
            Exit Sub
        End If

        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Item code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemCode.Select()
            Exit Sub
        End If

        If mcbOutputCategory.SelectedValue Is Nothing Then
            RadMessageBox.Show("Output type cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbOutputCategory.Select()
            Exit Sub
        End If

        If chkRunningQty.Checked = False Then
            If seOutputQty.Value = 0 Then
                RadMessageBox.Show("Invalid output quantity", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

                seOutputQty.Focus()
                Exit Sub
            End If
        Else
            seOutputQty.Value = 0
        End If

        Dim rnd = New Random
        Dim nextValue = rnd.Next(999999)
        recordID = nextValue.ToString

        Slipknot.addParameter("parId", recordID)
        Slipknot.addParameter("partNo", mcbItemCode.SelectedValue)
        Slipknot.addParameter("lineName", mcbLine.SelectedValue)
        Slipknot.addParameter("location", mcbWarehouse.SelectedValue)
        Slipknot.addParameter("shift", mcbShift.SelectedValue)
        Slipknot.addParameter("outputCategory", mcbOutputCategory.SelectedValue)
        Slipknot.addParameter("qty", seOutputQty.Value)
        Slipknot.addParameter("empAdded", currentUser.Item("fldUsername"))
        Slipknot.addParameter("_date", Now)

        If chkEnableMoreDetails.Checked Then

            If mcbProcess.SelectedIndex = -1 Then
                Slipknot.addParameter("parProcessCode", DBNull.Value)
            Else
                Slipknot.addParameter("parProcessCode", mcbProcess.SelectedValue)
            End If

            If txtPIC.Text.TrimStart.TrimEnd = String.Empty Then
                Slipknot.addParameter("parPIC", DBNull.Value)
            Else
                Slipknot.addParameter("parPIC", txtPIC.Text.TrimStart.TrimEnd)
            End If


            Slipknot.addParameter("parStatus", chkStatus.Checked)
            Slipknot.addParameter("parNoOfPIC", seNoOfPIC.Value)

            Slipknot.addParameter("parOprTime", seOprTime.Value)
            Slipknot.addParameter("parStartUp", seBStartUp.Value)
            Slipknot.addParameter("parPlanDowntime", sePlanDowntime.Value)
            Slipknot.addParameter("parUnPlanDowntime", seUnPlanDowntime.Value)

            If mcbCustomer.SelectedIndex = -1 Then
                Slipknot.addParameter("parCustomerCode", DBNull.Value)
            Else
                Slipknot.addParameter("parCustomerCode", mcbCustomer.SelectedValue)
            End If

            If txtLotNo.Text.TrimStart.TrimEnd = String.Empty Then
                Slipknot.addParameter("parLotNo", DBNull.Value)
            Else
                Slipknot.addParameter("parLotNo", txtLotNo.Text.TrimStart.TrimEnd)
            End If

            If txtTeamLeader.Text.TrimStart.TrimEnd = String.Empty Then
                Slipknot.addParameter("parTeamLeader", DBNull.Value)
            Else
                Slipknot.addParameter("parTeamLeader", txtTeamLeader.Text.TrimStart.TrimEnd)
            End If

        Else

            Slipknot.addParameter("parProcessCode", DBNull.Value)
            Slipknot.addParameter("parPIC", DBNull.Value)
            Slipknot.addParameter("parStatus", DBNull.Value)
            Slipknot.addParameter("parNoOfPIC", DBNull.Value)
            Slipknot.addParameter("parOprTime", DBNull.Value)
            Slipknot.addParameter("parStartUp", DBNull.Value)
            Slipknot.addParameter("parPlanDowntime", DBNull.Value)
            Slipknot.addParameter("parUnPlanDowntime", DBNull.Value)
            Slipknot.addParameter("parCustomerCode", DBNull.Value)
            Slipknot.addParameter("parLotNo", DBNull.Value)
            Slipknot.addParameter("parTeamLeader", DBNull.Value)

        End If

        If Slipknot.dbAED("SP_P_InsertProductionOutputTemp") Then

            If chkEnableMoreDetails.Checked Then
                addAssyProcess()
                addLinePartition()
            End If

            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If

        End If

    End Sub

    Private Sub addAssyProcess()

        For Each row As GridViewRowInfo In gvAssyProcessName.Rows

            KillSwitch.addBSSAssyProcess(recordID, Convert.ToString(row.Cells("fldCode").Value))

        Next

    End Sub

    Private Sub addLinePartition()

        For Each row As GridViewRowInfo In gvLineTimePartition.Rows

            KillSwitch.addLinePartition(recordID, Convert.ToDateTime(row.Cells("fldFrom").Value), Convert.ToDateTime(row.Cells("fldTo").Value))

        Next

    End Sub

    Private Sub loadOutputCategory()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllOutputType")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldOutputCode", GetType(String))
        dt2.Columns.Add("fldOutputName", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldOutputCode"
        fldCode.IsVisible = False
        mcbOutputCategory.MultiColumnComboBoxElement.Columns.Add(fldCode)

        Dim fldOutputName As New GridViewTextBoxColumn("OUTPUT TYPE")
        fldOutputName.FieldName = "fldOutputName"
        fldOutputName.Width = 220
        mcbOutputCategory.MultiColumnComboBoxElement.Columns.Add(fldOutputName)

        mcbOutputCategory.DataSource = dt
        mcbOutputCategory.ValueMember = "fldOutputCode"
        mcbOutputCategory.DisplayMember = "fldOutputName"
        mcbOutputCategory.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbOutputCategory.AutoFilter = True
        mcbOutputCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim output As New FilterDescriptor()
        output.PropertyName = "fldOutputName"
        output.Operator = FilterOperator.Contains
        mcbOutputCategory.EditorControl.MasterTemplate.FilterDescriptors.Add(output)

    End Sub

    Private myData As DataTable
    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork

        Slipknot.addParameter("dateFrom", dtpFrom.Value)
        Slipknot.addParameter("dateTo", dtpTo.Value)

        myData = Slipknot.dbSelect("SP_P_SelectAllProductionOutput")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub bwDelete_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDelete.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwDelete.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("parIdArray", id)
        Slipknot.dbAED("SP_DeleteProductionOutput")
    End Sub

    Private Sub bwDelete_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwDelete.ProgressChanged
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwDelete_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDelete.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If BulletForMyValentine.isRW("fldModProductionOutput") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwDelete.IsBusy = False Then
                    bwDelete.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If Slipknot.IsFormOpen(FrmEditProductionOutput) Then
            FrmEditProductionOutput.Focus()
        Else
            If BulletForMyValentine.isRW("fldModProductionOutput") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            If gvData.SelectedRows.Count > 0 Then
                FrmEditProductionOutput.txtId.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmEditProductionOutput.Show(Me)
            End If
        End If
    End Sub

    Private Sub chkShowMore_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkEnableMoreDetails.ToggleStateChanged

        If chkEnableMoreDetails.Checked Then
            panelMore.Visible = True
        Else
            panelMore.Visible = False
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If mcbAssemblyProcessName.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select assembly process properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbAssemblyProcessName.Select()
            Exit Sub
        End If

        If checkIfExist(Convert.ToString(mcbAssemblyProcessName.SelectedValue)) Then
            gvAssyProcessName.Rows.Add(Convert.ToString(mcbAssemblyProcessName.SelectedValue), Convert.ToString(mcbAssemblyProcessName.EditorControl.CurrentRow.Cells("fldName").Value))
        Else
            RadMessageBox.Show("This process already exist", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbAssemblyProcessName.Select()
        End If

    End Sub

    Private Function checkIfExist(ByVal code As String) As Boolean

        For Each row As GridViewRowInfo In gvAssyProcessName.Rows

            If code = Convert.ToString(row.Cells("fldCode").Value) Then

                Return False
                Exit Function
            End If

        Next

        Return True
    End Function

    Private Sub chkDisableQty_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkRunningQty.ToggleStateChanged
        If chkRunningQty.Checked Then
            seOutputQty.Enabled = False
        Else
            seOutputQty.Enabled = True
        End If
    End Sub
End Class
