Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmEditProductionOutput

    Private Sub FrmEditProductionOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGridRunningQty()

        seNoOfPIC.NullableValue = Nothing

        loadFrom()
        loadLine()
        loadShift()
        loadItemCode()
        loadOutputCategory()
        loadProcess()
        loadProcessComPerProcess()
        loadCustomer()

    End Sub

    Private Sub readyGridRunningQty()

        Dim fldFrom As New GridViewDateTimeColumn("From")
        fldFrom.FieldName = "fldFrom"
        fldFrom.EditorType = GridViewDateTimeEditorType.DateTimePicker
        fldFrom.FormatString = "{0:MMM dd, yyyy HH:mm:ss}"
        fldFrom.Format = DateTimePickerFormat.Custom
        fldFrom.CustomFormat = "MMM dd, yyyy HH:mm:ss"
        fldFrom.Width = 120
        fldFrom.TextAlignment = ContentAlignment.MiddleCenter
        gvRunningQty.Columns.Add(fldFrom)

        Dim fldTo As New GridViewDateTimeColumn("To")
        fldTo.FieldName = "fldTo"
        fldTo.EditorType = GridViewDateTimeEditorType.DateTimePicker
        fldTo.FormatString = "{0:MMM dd, yyyy HH:mm:ss}"
        fldTo.Format = DateTimePickerFormat.Custom
        fldTo.CustomFormat = "MMM dd, yyyy HH:mm:ss"
        fldTo.Width = 120
        fldTo.TextAlignment = ContentAlignment.MiddleCenter
        gvRunningQty.Columns.Add(fldTo)

    End Sub

    Private Sub loadRecord()

        Slipknot.addParameter("parId", txtId.Text)

        Dim data As DataTable = Slipknot.dbSelect("SP_SelectProductionOutputById")

        If data.Rows.Count > 0 Then

            mcbWarehouse.SelectedValue = Convert.ToString(data.Rows(0).Item("fldLocation"))
            mcbLine.SelectedValue = Convert.ToString(data.Rows(0).Item("fldLineNo"))
            mcbShift.SelectedValue = Convert.ToString(data.Rows(0).Item("fldShift"))
            mcbItemCode.SelectedValue = Convert.ToString(data.Rows(0).Item("fldPartNo"))
            mcbOutputCategory.SelectedValue = Convert.ToString(data.Rows(0).Item("fldOutputCategory"))
            seOutputQty.Value = Convert.ToDecimal(data.Rows(0).Item("fldQty"))
            txtRemarks.Text = Convert.ToString(data.Rows(0).Item("fldUpdateRemarks"))

            'If IsDBNull(data.Rows(0).Item("fldProcessCode")) Then
            '    mcbProcess.SelectedIndex = -1
            'Else
            '    mcbProcess.SelectedValue = Convert.ToString(data.Rows(0).Item("fldProcessCode"))
            'End If

            txtPIC.Text = Convert.ToString(data.Rows(0).Item("fldPIC"))

                If IsDBNull(data.Rows(0).Item("fldStatus")) Then
                    chkStatus.Checked = False
                Else
                    chkStatus.Checked = Convert.ToBoolean(data.Rows(0).Item("fldStatus"))
                End If

                If IsDBNull(data.Rows(0).Item("fldNoOfPIC")) Then
                    seNoOfPIC.NullableValue = Nothing
                Else
                    seNoOfPIC.Value = Convert.ToInt32(data.Rows(0).Item("fldNoOfPIC"))
                End If

            If IsDBNull(data.Rows(0).Item("fldOprTime")) Then
                    seOprTime.NullableValue = Nothing
                Else
                    seOprTime.Value = Convert.ToInt32(data.Rows(0).Item("fldOprTime"))
                End If

                If IsDBNull(data.Rows(0).Item("fldStartUp")) Then
                    seBStartUp.NullableValue = Nothing
                Else
                    seBStartUp.Value = Convert.ToInt32(data.Rows(0).Item("fldStartUp"))
                End If

                If IsDBNull(data.Rows(0).Item("fldPlanDowntime")) Then
                    sePlanDowntime.NullableValue = Nothing
                Else
                    sePlanDowntime.Value = Convert.ToInt32(data.Rows(0).Item("fldPlanDowntime"))
                End If

                If IsDBNull(data.Rows(0).Item("fldUnPlanDowntime")) Then
                    seUnPlanDowntime.NullableValue = Nothing
                Else
                    seUnPlanDowntime.Value = Convert.ToInt32(data.Rows(0).Item("fldUnPlanDowntime"))
                End If

                If IsDBNull(data.Rows(0).Item("fldCustomerCode")) Then
                    mcbCustomer.SelectedIndex = -1
                Else
                    mcbCustomer.SelectedValue = Convert.ToString(data.Rows(0).Item("fldCustomerCode"))
                End If

                txtLotNo.Text = Convert.ToString(data.Rows(0).Item("fldLotNo"))

            End If

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

    Private Sub FrmEditProductionOutput_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        loadRecord()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

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

        If seOutputQty.Value = 0 Then
            RadMessageBox.Show("Invalid output quantity", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            seOutputQty.Focus()
            Exit Sub
        End If

        If txtRemarks.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Remarks cannot be null", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtRemarks.Focus()
            Exit Sub
        End If

        Slipknot.addParameter("_id", txtId.Text)
        Slipknot.addParameter("partNo", mcbItemCode.SelectedValue)
        Slipknot.addParameter("shift", mcbShift.SelectedValue)
        Slipknot.addParameter("outputCategory", mcbOutputCategory.SelectedValue)
        Slipknot.addParameter("qty", seOutputQty.Value)
        Slipknot.addParameter("lastUpdateBy", currentUser.Item("fldUsername"))
        Slipknot.addParameter("lastUpdate", Now)
        Slipknot.addParameter("updateRemarks", txtRemarks.Text.TrimStart.TrimEnd)

        If mcbProcess.SelectedIndex = -1 Then
            Slipknot.addParameter("parProcessCode", DBNull.Value)
        Else
            Slipknot.addParameter("parProcessCode", mcbProcess.SelectedValue)
        End If

        If mcbAssemblyProcessName.SelectedIndex = -1 Then
            Slipknot.addParameter("parSubProcessCode", DBNull.Value)
        Else
            Slipknot.addParameter("parSubProcessCode", mcbAssemblyProcessName.SelectedValue)
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

        If Slipknot.dbAED("SP_P_UpdateProductionOutputTemp") Then
            RadMessageBox.Show("Updated Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
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

    'Public Sub InitializeNullableSpinEditor1()
    '    Dim item As New Item("Apple", 2)
    '    Me.seNoOfPIC.DataBindings.Add("NullableValue", item, "Id", True, DataSourceUpdateMode.OnPropertyChanged)
    'End Sub

    'Public Sub InitializeNullableSpinEditor2()
    '    Dim item As New Item("Apple", 2)
    '    Me.seOprTime.DataBindings.Add("NullableValue", item, "Id", True, DataSourceUpdateMode.OnPropertyChanged)
    'End Sub
    'Public Sub InitializeNullableSpinEditor3()
    '    Dim item As New Item("Apple", 2)
    '    Me.seBStartUp.DataBindings.Add("NullableValue", item, "Id", True, DataSourceUpdateMode.OnPropertyChanged)
    'End Sub
    'Public Sub InitializeNullableSpinEditor4()
    '    Dim item As New Item("Apple", 2)
    '    Me.sePlanDowntime.DataBindings.Add("NullableValue", item, "Id", True, DataSourceUpdateMode.OnPropertyChanged)
    'End Sub
    'Public Sub InitializeNullableSpinEditor5()
    '    Dim item As New Item("Apple", 2)
    '    Me.seUnPlanDowntime.DataBindings.Add("NullableValue", item, "Id", True, DataSourceUpdateMode.OnPropertyChanged)
    'End Sub
End Class

'Public Class Item
'    Implements System.ComponentModel.INotifyPropertyChanged
'    Private _name As String
'    Private _id As System.Nullable(Of Integer)
'    Public Sub New(name As String, id As System.Nullable(Of Integer))
'        Me._name = name
'        Me._id = id
'    End Sub
'    Public Property Name() As String
'        Get
'            Return Me._name
'        End Get
'        Set(value As String)
'            Me._name = value
'            OnPropertyChanged("Name")
'        End Set
'    End Property
'    Public Property Id() As System.Nullable(Of Integer)
'        Get
'            Return Me._id
'        End Get
'        Set(value As System.Nullable(Of Integer))
'            Me._id = value
'            OnPropertyChanged("Id")
'        End Set
'    End Property
'    Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
'    Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
'        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
'    End Sub
'End Class




