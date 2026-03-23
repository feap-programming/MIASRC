Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmBSSTemplate

    Private Sub FrmBSSTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        readyGridFront()
        readyGridBack()
        loadItemMaster()
        loadItemMasterForitemCode()
        loadProcess()
        loadProcessComPerProcess()
        loadItemMasterForitemCodeBack()
        loadItemMasterForPartNameBack()
    End Sub
    Private Sub loadItemMaster()
        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim dtProdLinq = (From x In dtProduct.AsEnumerable() Where x.Field(Of String)("fldItemCode").Contains("FG") Select x).ToList()

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
        mcbPartNameFront.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 160
        }
        mcbPartNameFront.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        mcbPartNameFront.DataSource = dtProdLinq.CopyToDataTable()
        mcbPartNameFront.ValueMember = "fldItemCode"
        mcbPartNameFront.DisplayMember = "fldPartName"
        mcbPartNameFront.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbPartNameFront.AutoFilter = True
        mcbPartNameFront.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim PartName As New Telerik.WinControls.Data.FilterDescriptor With {
            .PropertyName = "fldPartName",
            .Operator = FilterOperator.Contains
        }
        mcbPartNameFront.EditorControl.MasterTemplate.FilterDescriptors.Add(PartName)

    End Sub
    Private Sub loadItemMasterForitemCode()
        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 160
        }
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
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
    Private Sub loadItemMasterForitemCodeBack()
        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")
        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 160
        }
        mcbItemCodeBack.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
        mcbItemCodeBack.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemCodeBack.DataSource = dtProduct
        mcbItemCodeBack.ValueMember = "fldPartName"
        mcbItemCodeBack.DisplayMember = "fldItemCode"
        mcbItemCodeBack.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbItemCodeBack.AutoFilter = True
        mcbItemCodeBack.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCodeBack.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub
    Private Sub loadItemMasterForPartNameBack()
        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")
        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 160
        }
        mcbItemSub.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
        mcbItemSub.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemSub.DataSource = dtProduct
        mcbItemSub.ValueMember = "fldPartName"
        mcbItemSub.DisplayMember = "fldItemCode"
        mcbItemSub.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbItemSub.AutoFilter = True
        mcbItemSub.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemSub.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

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
    Private Sub loadProcessComPerProcess()

        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllPComponentList")

        Dim fldProcessCode As New GridViewTextBoxColumn("Code") With {
            .FieldName = "fldCode",
            .Width = 70
        }
        mcbAssemblyProcessName.MultiColumnComboBoxElement.Columns.Add(fldProcessCode)

        Dim processName As New GridViewTextBoxColumn("Process Name") With {
            .FieldName = "fldName",
            .Width = 250
        }
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If mcbPartNameFront.SelectedValue Is Nothing Then
            RadMessageBox.Show("Part Name cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbPartNameFront.Select()
            Exit Sub
        End If

        If txtFGNo.Text = "" Then
            RadMessageBox.Show("Item Code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbPartNameFront.Select()
            Exit Sub
        End If

        'If mcbItemCode.SelectedValue Is Nothing Then
        '    RadMessageBox.Show("Item Code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        '    mcbItemCode.Select()
        '    Exit Sub
        'End If

        If mcbProcess.SelectedValue Is Nothing Then
            RadMessageBox.Show("Main Process cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbProcess.Select()
            Exit Sub
        End If

        If mcbAssemblyProcessName.SelectedValue Is Nothing Then
            RadMessageBox.Show("Assembly Process cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbAssemblyProcessName.Select()
            Exit Sub
        End If

        Slipknot.addParameter("FGNo", Convert.ToString(txtFGNo.Text))
        Slipknot.addParameter("PartName", Convert.ToString(mcbPartNameFront.Text))
        Slipknot.addParameter("ItemCode", Convert.ToString(mcbItemCode.Text))
        Slipknot.addParameter("ProcessCodeMain", Convert.ToString(mcbProcess.SelectedValue))
        Slipknot.addParameter("MainProcess", Convert.ToString(mcbProcess.Text))
        Slipknot.addParameter("ProcessCodeSub", Convert.ToString(mcbAssemblyProcessName.SelectedValue))
        Slipknot.addParameter("ProcessName", Convert.ToString(mcbAssemblyProcessName.Text))

        Slipknot.dbAED("SP_InsertBSSTemplateFront")
        FetchData()
    End Sub

    Private Sub readyGridFront()
        Dim fldId As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldBFID",
            .IsVisible = False
        }
        gvTemplateFront.Columns.Add(fldId)

        Dim fldFGNo As New GridViewTextBoxColumn("FG No") With {
            .FieldName = "fldFGNo",
            .Width = 150
        }
        gvTemplateFront.Columns.Add(fldFGNo)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name") With {
            .FieldName = "fldPartName",
            .Width = 220
        }
        gvTemplateFront.Columns.Add(fldPartName)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code") With {
            .FieldName = "fldItemCode",
            .Width = 110
        }
        gvTemplateFront.Columns.Add(fldItemCode)

        Dim fldProcessCode As New GridViewTextBoxColumn("Process Code Main") With {
            .FieldName = "fldProcessCodeMain",
            .Width = 150
        }
        gvTemplateFront.Columns.Add(fldProcessCode)

        Dim fldMainProcess As New GridViewTextBoxColumn("Main Process") With {
            .FieldName = "fldMainProcess",
            .Width = 220
        }
        gvTemplateFront.Columns.Add(fldMainProcess)

        Dim fldProcessCodeSub As New GridViewTextBoxColumn("Process Code Sub") With {
            .FieldName = "fldProcessCodeSub",
            .Width = 150
        }
        gvTemplateFront.Columns.Add(fldProcessCodeSub)

        Dim fldProcessName As New GridViewTextBoxColumn("Process Name") With {
            .FieldName = "fldProcessName",
            .Width = 220
        }
        gvTemplateFront.Columns.Add(fldProcessName)


        gvTemplateFront.ReadOnly = True
        gvTemplateFront.AllowAddNewRow = False
        gvTemplateFront.AllowDeleteRow = False
        gvTemplateFront.EnableFiltering = True
        gvTemplateFront.ShowFilteringRow = False
        gvTemplateFront.ShowGroupPanel = False
        gvTemplateFront.MultiSelect = True

        gvTemplateFront.TableElement.RowHeight = 25

    End Sub

    Private Sub readyGridBack()
        Dim fldId As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldBBID",
            .IsVisible = False
        }
        gvTemplateBack.Columns.Add(fldId)

        Dim fldItemCodeMain As New GridViewTextBoxColumn("Item Code Main") With {
            .FieldName = "fldItemCodeMain",
            .Width = 110
        }
        gvTemplateBack.Columns.Add(fldItemCodeMain)

        Dim fldPartNameMain As New GridViewTextBoxColumn("Part Name Main") With {
            .FieldName = "fldPartNameMain",
            .Width = 200
        }
        gvTemplateBack.Columns.Add(fldPartNameMain)

        Dim fldItemCodeSub As New GridViewTextBoxColumn("Item Code Sub") With {
            .FieldName = "fldItemCodeSub",
            .Width = 110
        }
        gvTemplateBack.Columns.Add(fldItemCodeSub)

        Dim fldPartNameSub As New GridViewTextBoxColumn("Part Name Sub") With {
            .FieldName = "fldPartNameSub",
            .Width = 200
        }
        gvTemplateBack.Columns.Add(fldPartNameSub)

        Dim fldSolderAss As New GridViewTextBoxColumn("Solder") With {
            .FieldName = "fldSolderAss",
            .Width = 110
        }
        gvTemplateBack.Columns.Add(fldSolderAss)

        Dim fldPCB As New GridViewTextBoxColumn("PCB") With {
            .FieldName = "fldPCB",
            .Width = 110
        }
        gvTemplateBack.Columns.Add(fldPCB)

        Dim fldRobot As New GridViewTextBoxColumn("Robot") With {
            .FieldName = "fldRobot",
            .Width = 110
        }
        gvTemplateBack.Columns.Add(fldRobot)


        gvTemplateBack.ReadOnly = True
        gvTemplateBack.AllowAddNewRow = False
        gvTemplateBack.AllowDeleteRow = False
        gvTemplateBack.EnableFiltering = True
        gvTemplateBack.ShowFilteringRow = False
        gvTemplateBack.ShowGroupPanel = False
        gvTemplateBack.MultiSelect = True

        gvTemplateBack.TableElement.RowHeight = 25

    End Sub

    Private Sub FrmBSSTemplate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        mcbPartNameFront.SelectedIndex = -1
        mcbItemCode.SelectedIndex = -1
        mcbProcess.SelectedIndex = -1
        mcbAssemblyProcessName.SelectedIndex = -1
        mcbItemCodeBack.SelectedIndex = -1
        mcbItemSub.SelectedIndex = -1
        FetchData()
    End Sub
    Private Sub FetchData()
        gvTemplateFront.DataSource = Slipknot.dbSelect("SP_SelectAllBSSTemplateFront")
        gvTemplateBack.DataSource = Slipknot.dbSelect("SP_SelectAllBSSTemplateBack")
    End Sub

    Private Sub mcbPartNameFront_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbPartNameFront.SelectedIndexChanged
        txtFGNo.Text = mcbPartNameFront.SelectedValue
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles btnAddBack.Click
        If mcbItemCodeBack.SelectedValue Is Nothing Then
            RadMessageBox.Show("Item Code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemCodeBack.Select()
            Exit Sub
        End If
        If mcbItemSub.SelectedValue Is Nothing Then
            RadMessageBox.Show("Part Name cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemSub.Select()
            Exit Sub
        End If

        Dim Solder As String
        Dim PCB As String
        Dim ParamRobot As String
        If chSS.Checked Then
            Solder = "YES"
        Else
            Solder = "NO"
        End If
        If chPCB.Checked Then
            PCB = "YES"
        Else
            PCB = "NO"
        End If
        If cbRobot.Checked Then
            ParamRobot = "YES"
        Else
            ParamRobot = "NO"
        End If

        Slipknot.addParameter("ItemCodeMain", Convert.ToString(mcbItemCodeBack.Text))
        Slipknot.addParameter("PartNameMain", Convert.ToString(txtPartNameMain.Text))
        Slipknot.addParameter("ItemCodeSub", Convert.ToString(mcbItemSub.Text))
        Slipknot.addParameter("PartNameSub", Convert.ToString(txtPartNameSub.Text))
        Slipknot.addParameter("SolderAss", Solder)
        Slipknot.addParameter("PCB", PCB)
        Slipknot.addParameter("Robot", ParamRobot)

        Slipknot.dbAED("SP_InsertBSSTemplateBack")
        FetchData()
    End Sub

    Private Sub mcbItemSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemSub.SelectedIndexChanged
        txtPartNameSub.Text = mcbItemSub.SelectedValue
    End Sub

    Private Sub mcbItemCodeBack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemCodeBack.SelectedIndexChanged
        txtPartNameMain.Text = mcbItemCodeBack.SelectedValue
    End Sub
End Class
