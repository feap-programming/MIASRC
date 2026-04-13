Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmBSSTemplateAddDefect
    Private Sub FrmBSSTemplateAddDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readyGrid()

        loadItemMaster()
        loadProcessComPerProcess()
        FetchBSSTemplateDefect()
        loadProcess()
    End Sub

    Private Sub btnAddDefect_Click(sender As Object, e As EventArgs) Handles btnAddDefect.Click
        SaveData()
    End Sub

    Private Sub SaveData()

        Slipknot.addParameter("PartName", Convert.ToString(mcbPartName.Text))
        Slipknot.addParameter("itemCode", Convert.ToString(txtItemCode.Text))
        Slipknot.addParameter("MainProcess", Convert.ToString(mcbProcess.Text))
        Slipknot.addParameter("ProcessCode", Convert.ToString(mcbAssemblyProcessName.SelectedValue))
        Slipknot.addParameter("ProcessName", Convert.ToString(mcbAssemblyProcessName.Text))
        Slipknot.dbAED("SP_InsertBSSTemplateDefect")

        FetchBSSTemplateDefect()
    End Sub

    Private Sub FrmBSSTemplateAddDefect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        mcbPartName.SelectedIndex = -1
        txtItemCode.Text = ""
        mcbProcess.SelectedIndex = -1
        mcbAssemblyProcessName.SelectedIndex = -1
    End Sub
    Private Sub FetchBSSTemplateDefect()
        gvDefect.DataSource = Slipknot.dbSelect("SP_SelectAllBSSTemplateDefect")
    End Sub

    Private Sub readyGrid()
        Dim fldDID As New GridViewDecimalColumn("DID") With {
            .FieldName = "fldDID",
            .IsVisible = False
        }
        gvDefect.Columns.Add(fldDID)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name") With {
            .FieldName = "fldPartName",
            .Width = 350
        }
        gvDefect.Columns.Add(fldPartName)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code") With {
            .FieldName = "fldItemCode",
            .Width = 120
        }
        gvDefect.Columns.Add(fldItemCode)

        Dim fldMainProcess As New GridViewTextBoxColumn("Main Process") With {
            .FieldName = "fldMainProcess",
            .Width = 120
        }
        gvDefect.Columns.Add(fldMainProcess)

        Dim fldProcessCode As New GridViewTextBoxColumn("Process Code") With {
            .FieldName = "fldProcessCode",
            .Width = 120
        }
        gvDefect.Columns.Add(fldProcessCode)

        Dim fldProcessName As New GridViewTextBoxColumn("Process Name") With {
            .FieldName = "fldProcessName",
            .Width = 350
        }
        gvDefect.Columns.Add(fldProcessName)


        gvDefect.ReadOnly = True
        gvDefect.AllowAddNewRow = False
        gvDefect.AllowDeleteRow = False
        gvDefect.EnableFiltering = True
        gvDefect.ShowFilteringRow = False
        gvDefect.ShowGroupPanel = False
        gvDefect.MultiSelect = True

        gvDefect.TableElement.RowHeight = 25

    End Sub

    Private Sub loadProcess()

        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllProcess")

        Dim fldProcessCode As New GridViewTextBoxColumn("CODE") With {
            .FieldName = "fldCode",
            .Width = 70
        }
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldProcessCode)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS NAME") With {
            .FieldName = "fldProcessName",
            .Width = 250
        }
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

    Private Sub loadItemMaster()

        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim dtProdLinq = (From x In dtProduct.AsEnumerable() Where x.Field(Of String)("fldItemCode").Contains("FG") Select x).ToList()

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 200
        mcbPartName.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 160
        mcbPartName.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        mcbPartName.DataSource = dtProdLinq.CopyToDataTable()
        mcbPartName.ValueMember = "fldItemCode"
        mcbPartName.DisplayMember = "fldPartName"
        mcbPartName.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbPartName.AutoFilter = True
        mcbPartName.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim PartName As New FilterDescriptor()
        PartName.PropertyName = "fldPartName"
        PartName.Operator = FilterOperator.Contains
        mcbPartName.EditorControl.MasterTemplate.FilterDescriptors.Add(PartName)

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

    Private Sub mcbPartName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbPartName.SelectedIndexChanged
        txtItemCode.Text = mcbPartName.SelectedValue
    End Sub
End Class
