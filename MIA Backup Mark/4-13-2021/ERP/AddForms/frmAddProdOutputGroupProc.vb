Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmAddProdOutputGroupProc
    Private SetID As String
    Private SetPOSPID As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub frmAddProdOutputGroupProc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)
        loadItemMaster()
        loadTitle()
        loadProcess()
        readTimePartition()
        readAssyProcessName()
        loadProcessComPerProcess()
        loadCustomer()
        loadFGNo()
        loadShift()
        rtpFrom.Value = Today
        rtpTo.Value = Today
    End Sub
    Private Sub loadItemMaster()

        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 160
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 200
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemCode.DataSource = dtProduct
        mcbItemCode.ValueMember = "fldPartName"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCode.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

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

        Dim fldPIC As New GridViewTextBoxColumn("PIC")
        fldPIC.FieldName = "fldPIC"
        fldPIC.Width = 120
        gvAssyProcessName.Columns.Add(fldPIC)

        gvAssyProcessName.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvAssyProcessName.AllowAddNewRow = False
        gvAssyProcessName.ShowFilteringRow = False
        gvAssyProcessName.ShowGroupPanel = False
        gvAssyProcessName.EnableSorting = False
        gvAssyProcessName.AllowColumnReorder = False
        gvAssyProcessName.AllowRowReorder = False

    End Sub
    Private Sub readTimePartition()
        Dim fldShift As New GridViewTextBoxColumn("Shift") With {
            .FieldName = "fldShift",
            .IsVisible = True,
            .ReadOnly = True
        }
        gvbTimePartition.Columns.Add(fldShift)

        Dim fldTimeFrom As New GridViewDateTimeColumn("Time From") With {
            .FieldName = "fldTimeFrom",
            .IsVisible = True,
            .ReadOnly = True,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "hh:mm:ss tt"
        }
        gvbTimePartition.Columns.Add(fldTimeFrom)
        gvbTimePartition.Columns("fldTimeFrom").FormatString = "{0:hh:mm:ss tt}"

        Dim fldTimeTo As New GridViewDateTimeColumn("Time To") With {
            .FieldName = "fldTimeTo",
            .IsVisible = True,
            .ReadOnly = True,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "hh:mm:ss tt"
        }
        gvbTimePartition.Columns.Add(fldTimeTo)
        gvbTimePartition.Columns("fldTimeTo").FormatString = "{0:hh:mm:ss tt}"


        gvbTimePartition.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvbTimePartition.AllowAddNewRow = False
        gvbTimePartition.ShowFilteringRow = False
        gvbTimePartition.ShowGroupPanel = False
        gvbTimePartition.EnableSorting = False
        gvbTimePartition.AllowColumnReorder = False
        gvbTimePartition.AllowRowReorder = False

    End Sub

    Private Sub loadTitle()

        Dim dtTitle As DataTable = Slipknot.dbSelectManual("SELECT fldId, fldTitle FROM tblProductionOutputGroup")

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        mcbTitle.MultiColumnComboBoxElement.Columns.Add(fldId)

        Dim fldTitle As New GridViewTextBoxColumn("Title")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 500
        mcbTitle.MultiColumnComboBoxElement.Columns.Add(fldTitle)

        mcbTitle.DataSource = dtTitle
        mcbTitle.ValueMember = "fldId"
        mcbTitle.DisplayMember = "fldTitle"
        mcbTitle.MultiColumnComboBoxElement.DropDownWidth = 500

        mcbTitle.AutoFilter = True
        mcbTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        'Dim code As New FilterDescriptor("fldId", FilterOperator.Contains, "")
        Dim name As New FilterDescriptor("fldTitle", FilterOperator.Contains, "")
        'compositeFilter.FilterDescriptors.Add(code)
        compositeFilter.FilterDescriptors.Add(name)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.mcbTitle.EditorControl.FilterDescriptors.Add(compositeFilter)

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

    Private Sub loadFGNo()

        Dim dtFg As DataTable = Slipknot.dbSelectManual("SELECT fldItemCode FROM tblItemMasterData WHERE fldCategory != 'WP' AND fldCategory != 'RM' ")

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 90
        mcbFGNo.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        mcbFGNo.DataSource = dtFg
        mcbFGNo.ValueMember = "fldItemCode"
        mcbFGNo.DisplayMember = "fldItemCode"
        mcbFGNo.MultiColumnComboBoxElement.DropDownWidth = 200

        mcbFGNo.AutoFilter = True
        mcbFGNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim name As New FilterDescriptor("fldItemCode", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(name)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.mcbFGNo.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub frmAddProdOutputGroupProc_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If globalVariables.BSSProdOutputAction = "New" Then
            mcbTitle.SelectedIndex = -1
            mcbProcess.SelectedIndex = -1
            mcbAssemblyProcessName.SelectedIndex = -1
            mcbCustomer.SelectedIndex = -1
            mcbFGNo.SelectedIndex = -1
            mcbItemCode.SelectedIndex = -1
        End If


    End Sub
    Public Sub CheckProcessCodeifExist()
        Try
            Dim drProcessCode As DataRow = Nothing
            Dim drPOSP As DataRow = Nothing
            Dim CheckMe As Int16

            Slipknot.addParameter("_ProcessCode", mcbProcess.SelectedValue)
            Slipknot.addParameter("_title", mcbTitle.Text)
            Dim dtPC As DataTable = Slipknot.dbSelect("SP_CheckifExistProdOutputGroup")
            drProcessCode = dtPC.Rows(0)

            CheckMe = Convert.ToInt16(drProcessCode.Item("Checkme"))
            If (CheckMe >= 1) Then
                globalVariables.POSPExist = "YES"
                SetID = Convert.ToString(drProcessCode.Item("fldID"))
                SetPOSPID = Convert.ToString(drProcessCode.Item("fldPOSPID"))
                FetchExisitingData(drProcessCode.Item("fldMainId"), drProcessCode.Item("fldPOSPID"))
            Else
                globalVariables.POSPExist = "NO"
                ClearMe()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FetchExisitingData(_MainID As String, _POSPID As String)
        Dim drPOSP As DataRow = Nothing
        Slipknot.addParameter("MainID", _MainID)
        Dim dtPOSP As DataTable = Slipknot.dbSelect("SP_SelectProdOutputSubProcessbyMainID")

        If dtPOSP.Rows.Count > 0 Then
            drPOSP = dtPOSP.Rows(0)
            seNoOfPIC.Value = Convert.ToDecimal(drPOSP.Item("fldNoofPersons"))
            seOprTime.Value = Convert.ToDecimal(drPOSP.Item("fldAOprTime"))
            seBStartUp.Value = Convert.ToDecimal(drPOSP.Item("fldStartUp"))
            sePlanDowntime.Value = Convert.ToDecimal(drPOSP.Item("fldPlanDowntime"))
            seUnPlanDowntime.Value = Convert.ToDecimal(drPOSP.Item("fldUnPlanDowntime"))
            mcbCustomer.Text = Convert.ToString(drPOSP.Item("fldCustomer"))
            mcbFGNo.Text = Convert.ToString(drPOSP.Item("fldFGNo"))
            txtLotNo.Text = Convert.ToString(drPOSP.Item("fldLotNo"))
            If Convert.ToString(drPOSP.Item("fldStatus")) = "YES" Then
                chkStatus.Checked = True
            Else
                chkStatus.Checked = False
            End If
            mcbItemCode.Text = Convert.ToString(drPOSP.Item("fldItemCode"))
            txtPartName.Text = Convert.ToString(drPOSP.Item("fldPartName"))
            seGoodQty.Value = Convert.ToDecimal(drPOSP.Item("fldGoodQTY"))
            txtSample.Text = Convert.ToString(drPOSP.Item("fldASamples"))
            txtReplacement.Text = Convert.ToString(drPOSP.Item("fldReplacement"))
        End If

        Slipknot.addParameter("POSPID", _POSPID)
        gvAssyProcessName.DataSource = Slipknot.dbSelect("SP_SelectPOSPProcessNamebyPOSPID")

        'Slipknot.addParameter("POSPID", _POSPID)
        'gvbTimePartition.DataSource = Slipknot.dbSelect("SP_SelectPOSPLTPartition")

        Slipknot.addParameter("POSPID", _POSPID)
        Dim dtLTPartition As DataTable = Slipknot.dbSelect("SP_SelectPOSPLTPartition")

        If dtLTPartition.Rows.Count > 0 Then
            gvbTimePartition.DataSource = dtLTPartition
        End If


    End Sub
    Private Sub ClearMe()

        seNoOfPIC.Value = 0
        seOprTime.Value = 0
        seBStartUp.Value = 0
        sePlanDowntime.Value = 0
        seUnPlanDowntime.Value = 0
        mcbCustomer.Text = ""
        mcbFGNo.Text = ""
        txtLotNo.Text = ""
        gvAssyProcessName.DataSource = Nothing
        gvbTimePartition.DataSource = Nothing

        chkStatus.Checked = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If mcbAssemblyProcessName.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select assembly process properly", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbAssemblyProcessName.Select()
            Exit Sub
        End If

        If checkIfExist(Convert.ToString(mcbAssemblyProcessName.SelectedValue)) Then
            gvAssyProcessName.Rows.Add(Convert.ToString(mcbAssemblyProcessName.SelectedValue), Convert.ToString(mcbAssemblyProcessName.EditorControl.CurrentRow.Cells("fldName").Value))
        Else
            RadMessageBox.Show("This process already exist", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

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

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If BulletForMyValentine.isRW("fldModProductionOutput") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If mcbTitle.SelectedValue Is Nothing Then
            RadMessageBox.Show("Title cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbTitle.Select()
            Exit Sub
        End If

        If mcbProcess.SelectedValue Is Nothing Then
            RadMessageBox.Show("Main process cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbProcess.Select()
            Exit Sub
        End If

        'If (gvAssyProcessName.Rows.Count = 0) Then
        '    RadMessageBox.Show("Assembly process cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        '    mcbAssemblyProcessName.Select()
        '    Exit Sub
        'End If


        If (globalVariables.POSPExist = "NO") Then
            AddProdOutputGroup()
        Else
            UpdateProdOutputGroup()
        End If




    End Sub


    Private Sub AddProdOutputGroup()
        Dim customer As String = String.Empty
        Dim FGNo As String = String.Empty
        Dim RandNo As String = String.Empty

        'GetRandomNumber
        Dim DRSetRandomNo As DataRow = Nothing

        Dim Rand As DataTable = Slipknot.dbSelect("SP_SelectRandomNumberPOSP")
        DRSetRandomNo = Rand.Rows(0)
        RandNo = Convert.ToString(DRSetRandomNo.Item("SetRandom"))



        Slipknot.addParameter("MainId", Convert.ToInt32(mcbTitle.SelectedValue))
        Slipknot.addParameter("POSPID", RandNo)
        Slipknot.addParameter("ProcessCode", Convert.ToString(mcbProcess.SelectedValue))
        Slipknot.addParameter("MainProcess", Convert.ToString(mcbProcess.Text))
        Slipknot.addParameter("NoOfPersons", seNoOfPIC.Value)
        Slipknot.addParameter("AOprTime", seOprTime.Value)
        Slipknot.addParameter("StartUp", seBStartUp.Value)
        Slipknot.addParameter("PlanDowntime", sePlanDowntime.Value)
        Slipknot.addParameter("UnPlanDowntime", seUnPlanDowntime.Value)
        Slipknot.addParameter("Customer", Convert.ToString(mcbCustomer.SelectedValue))
        Slipknot.addParameter("FGNo", Convert.ToString(mcbFGNo.SelectedValue))
        Slipknot.addParameter("LotNo", Convert.ToString(txtLotNo.Text))
        Slipknot.addParameter("AddedBy", currentUser.Item("fldUsername"))
        If chkStatus.Checked Then
            Slipknot.addParameter("Stat", "YES")
        Else
            Slipknot.addParameter("Stat", "NO")
        End If
        Slipknot.addParameter("GoodQTY", Convert.ToInt32(seGoodQty.Value))
        Slipknot.addParameter("ASamples", Convert.ToString(txtSample.Text))
        Slipknot.addParameter("Replacement", Convert.ToString(txtReplacement.Text))
        Slipknot.addParameter("PartName", Convert.ToString(txtPartName.Text))
        Slipknot.addParameter("ItemCode", Convert.ToString(mcbItemCode.Text))

        Slipknot.dbAED("SP_InsertProdOutputSubProcess")

        For Each row As GridViewRowInfo In gvAssyProcessName.Rows
            Slipknot.addParameter("POSPID", RandNo)
            Slipknot.addParameter("ProcessCode", Convert.ToString(row.Cells("fldCode").Value).TrimStart.TrimStart)
            Slipknot.addParameter("ProcessName", Convert.ToString(row.Cells("fldProcessName").Value).TrimStart.TrimStart)
            Slipknot.addParameter("PIC", Convert.ToString(row.Cells("fldPIC").Value).TrimStart.TrimStart)

            Slipknot.dbAED("SP_InsertPOSPProcessName")
        Next

        For Each row As GridViewRowInfo In gvbTimePartition.Rows
            Slipknot.addParameter("POSPID", RandNo)
            Slipknot.addParameter("Shift", Convert.ToString(row.Cells("fldShift").Value).TrimStart.TrimStart)
            Slipknot.addParameter("TimeFrom", Convert.ToString(row.Cells("fldTimeFrom").Value).TrimStart.TrimStart)
            Slipknot.addParameter("TimeTo", Convert.ToString(row.Cells("fldTimeTo").Value).TrimStart.TrimStart)

            Slipknot.dbAED("SP_InsertPOSPLineTimePartition")
        Next

        RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub
    Private Sub UpdateProdOutputGroup()
        Dim customer As String = String.Empty
        Dim FGNo As String = String.Empty


        Slipknot.addParameter("ID", SetID)
        Slipknot.addParameter("POSPID", SetPOSPID)
        Slipknot.addParameter("ProcessCode", Convert.ToString(mcbProcess.SelectedValue))
        Slipknot.addParameter("MainProcess", Convert.ToString(mcbProcess.Text))
        Slipknot.addParameter("NoOfPersons", seNoOfPIC.Value)
        Slipknot.addParameter("AOprTime", seOprTime.Value)
        Slipknot.addParameter("StartUp", seBStartUp.Value)
        Slipknot.addParameter("PlanDowntime", sePlanDowntime.Value)
        Slipknot.addParameter("UnPlanDowntime", seUnPlanDowntime.Value)
        Slipknot.addParameter("Customer", Convert.ToString(mcbCustomer.SelectedValue))
        Slipknot.addParameter("FGNo", Convert.ToString(mcbFGNo.SelectedValue))
        Slipknot.addParameter("LotNo", Convert.ToString(txtLotNo.Text))
        If chkStatus.Checked Then
            Slipknot.addParameter("Stat", "YES")
        Else
            Slipknot.addParameter("Stat", "NO")
        End If
        Slipknot.addParameter("GoodQTY", Convert.ToInt32(seGoodQty.Value))
        Slipknot.addParameter("ASamples", Convert.ToString(txtSample.Text))
        Slipknot.addParameter("Replacement", Convert.ToString(txtReplacement.Text))
        Slipknot.addParameter("PartName", Convert.ToString(txtPartName.Text))
        Slipknot.addParameter("ItemCode", Convert.ToString(mcbItemCode.Text))
        Slipknot.dbAED("SP_UpdateProdOutputSubProcess")

        For Each row As GridViewRowInfo In gvAssyProcessName.Rows
            Slipknot.addParameter("POSPID", SetPOSPID)
            Slipknot.addParameter("ProcessCode", Convert.ToString(row.Cells("fldCode").Value).TrimStart.TrimStart)
            Slipknot.addParameter("ProcessName", Convert.ToString(row.Cells("fldProcessName").Value).TrimStart.TrimStart)
            Slipknot.addParameter("PIC", Convert.ToString(row.Cells("fldPIC").Value).TrimStart.TrimStart)

            Slipknot.dbAED("SP_InsertPOSPProcessName")
        Next

        For Each row As GridViewRowInfo In gvbTimePartition.Rows
            Slipknot.addParameter("POSPID", SetPOSPID)
            Slipknot.addParameter("Shift", Convert.ToString(row.Cells("fldShift").Value).TrimStart.TrimStart)
            Slipknot.addParameter("TimeFrom", Convert.ToString(row.Cells("fldTimeFrom").Value).TrimStart.TrimStart)
            Slipknot.addParameter("TimeTo", Convert.ToString(row.Cells("fldTimeTo").Value).TrimStart.TrimStart)

            Slipknot.dbAED("SP_InsertPOSPLineTimePartition")
        Next

        RadMessageBox.Show("Record has been updated Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub


    Private Sub btnAddLTPartition_Click(sender As Object, e As EventArgs) Handles btnAddLTPartition.Click

        If mcbShift.Text = "" Then
            RadMessageBox.Show("Please select Shift properly", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbShift.Select()
            Exit Sub
        End If

        If checkIfExist(Convert.ToString(mcbShift.SelectedValue)) Then

            gvbTimePartition.Rows.Add(Convert.ToString(mcbShift.SelectedValue), rtpFrom.Value, rtpTo.Value)
        Else
            RadMessageBox.Show("This Shift already exist", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbShift.Select()
        End If
    End Sub

    Public Sub mcbProcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbProcess.SelectedIndexChanged
        CheckProcessCodeifExist()
    End Sub

    Private Sub mcbItemCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemCode.SelectedIndexChanged
        txtPartName.Text = mcbItemCode.SelectedValue
    End Sub

End Class
