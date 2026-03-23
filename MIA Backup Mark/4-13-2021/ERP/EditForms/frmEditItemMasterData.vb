Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmEditItemMasterData
    Private Sub FrmEditItemMasterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadCategory()
        loadUOM()
        loadMaker()

        readyGridProcess()
        readyGridModel()
        readyGridCustomer()
        readyGridPartNoHistory()
        readyGridSpecs()

        loadRecord()

        If BulletForMyValentine.checkIfHaveChild(txtItemCodeOrig.Text) Then
            txtItemCode.Enabled = False
        End If

    End Sub

    Private Sub readyGridProcess()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvProcess.Columns.Add(fldId)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS NAME")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 400
        gvProcess.Columns.Add(fldProcessName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldProcessCode"
        fldCode.Width = 60
        gvProcess.Columns.Add(fldCode)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvProcess.Columns.Add(fldDateAdded)
        gvProcess.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvProcess.Columns.Add(fldAddedBy)

        gvProcess.ReadOnly = True
        gvProcess.AllowAddNewRow = False
        gvProcess.AllowDeleteRow = False
        gvProcess.EnableFiltering = True
        gvProcess.ShowFilteringRow = False
        gvProcess.ShowGroupPanel = False
        gvProcess.MultiSelect = True

        gvProcess.TableElement.RowHeight = 25

    End Sub

    Private Sub readyGridModel()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvModel.Columns.Add(fldId)

        Dim fldModel As New GridViewTextBoxColumn("MODEL")
        fldModel.FieldName = "model"
        fldModel.Width = 170
        gvModel.Columns.Add(fldModel)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvModel.Columns.Add(fldDateAdded)
        gvModel.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvModel.Columns.Add(fldAddedBy)

        gvModel.ReadOnly = True
        gvModel.AllowAddNewRow = False
        gvModel.AllowDeleteRow = False
        gvModel.EnableFiltering = True
        gvModel.ShowFilteringRow = False
        gvModel.ShowGroupPanel = False
        gvModel.MultiSelect = True

        gvModel.TableElement.RowHeight = 25

    End Sub

    Private Sub readyGridCustomer()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvCustomer.Columns.Add(fldId)

        Dim customer As New GridViewTextBoxColumn("CUSTOMER")
        customer.FieldName = "customer"
        customer.Width = 120
        gvCustomer.Columns.Add(customer)

        Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE")
        fldModelCode.FieldName = "fldModelCode"
        fldModelCode.Width = 100
        gvCustomer.Columns.Add(fldModelCode)

        Dim fldStdQty As New GridViewDecimalColumn("STANDARD QTY")
        fldStdQty.FieldName = "fldStdQty"
        fldStdQty.Width = 130
        gvCustomer.Columns.Add(fldStdQty)
        gvCustomer.Columns("fldStdQty").FormatString = "{0:N2}"

        Dim fldPartLevel As New GridViewTextBoxColumn("PART LEVEL")
        fldPartLevel.FieldName = "fldPartLevel"
        fldPartLevel.Width = 110
        gvCustomer.Columns.Add(fldPartLevel)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvCustomer.Columns.Add(fldDateAdded)
        gvCustomer.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvCustomer.Columns.Add(fldAddedBy)

        gvCustomer.ReadOnly = True
        gvCustomer.AllowAddNewRow = False
        gvCustomer.AllowDeleteRow = False
        gvCustomer.EnableFiltering = True
        gvCustomer.ShowFilteringRow = False
        gvCustomer.ShowGroupPanel = False
        gvCustomer.MultiSelect = True

        gvCustomer.TableElement.RowHeight = 25

    End Sub

    Private Sub readyGridPartNoHistory()

        Dim fldCompanyPartNo As New GridViewTextBoxColumn("NEW ITEM CODE")
        fldCompanyPartNo.FieldName = "fldNewItemCode"
        fldCompanyPartNo.Width = 150
        gvPartNoHistory.Columns.Add(fldCompanyPartNo)

        Dim fldPrice As New GridViewDecimalColumn("PRICE")
        fldPrice.FieldName = "fldPrice"
        fldPrice.Width = 80
        gvPartNoHistory.Columns.Add(fldPrice)
        gvPartNoHistory.Columns("fldPrice").FormatString = "{0:N2}"

        Dim fldRemraks As New GridViewTextBoxColumn("REMARK")
        fldRemraks.FieldName = "fldRemarks"
        fldRemraks.Width = 150
        gvPartNoHistory.Columns.Add(fldRemraks)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvPartNoHistory.Columns.Add(fldDateAdded)
        gvPartNoHistory.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvPartNoHistory.Columns.Add(fldAddedBy)

        gvPartNoHistory.ReadOnly = True
        gvPartNoHistory.AllowAddNewRow = False
        gvPartNoHistory.AllowDeleteRow = False
        gvPartNoHistory.EnableFiltering = True
        gvPartNoHistory.ShowFilteringRow = False
        gvPartNoHistory.ShowGroupPanel = False
        gvPartNoHistory.MultiSelect = True

        gvPartNoHistory.TableElement.RowHeight = 25

    End Sub

    Private Sub readyGridSpecs()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvSpecs.Columns.Add(fldId)

        Dim fldCav As New GridViewDecimalColumn("CAV.")
        fldCav.FieldName = "fldCav"
        fldCav.Width = 70
        gvSpecs.Columns.Add(fldCav)
        gvSpecs.Columns("fldCav").FormatString = "{0:N2}"

        Dim fldPartWeight As New GridViewDecimalColumn("PART WEIGHT")
        fldPartWeight.FieldName = "fldPartWeight"
        fldPartWeight.Width = 110
        gvSpecs.Columns.Add(fldPartWeight)
        gvSpecs.Columns("fldPartWeight").FormatString = "{0:N2}"

        Dim fldRunnerWeight As New GridViewDecimalColumn("RUNENR WEIGHT")
        fldRunnerWeight.FieldName = "fldRunnerWeight"
        fldRunnerWeight.Width = 120
        gvSpecs.Columns.Add(fldRunnerWeight)
        gvSpecs.Columns("fldRunnerWeight").FormatString = "{0:N2}"

        Dim fldLoss As New GridViewDecimalColumn("LOSS")
        fldLoss.FieldName = "fldLoss"
        fldLoss.Width = 70
        gvSpecs.Columns.Add(fldLoss)
        gvSpecs.Columns("fldLoss").FormatString = "{0:N2}"

        Dim fldCollection As New GridViewDecimalColumn("COLLECTION")
        fldCollection.FieldName = "fldCollection"
        fldCollection.Width = 100
        gvSpecs.Columns.Add(fldCollection)
        gvSpecs.Columns("fldCollection").FormatString = "{0:N2}"

        Dim fldCycleTime As New GridViewDecimalColumn("CYCLE TIME")
        fldCycleTime.FieldName = "fldCycleTime"
        fldCycleTime.Width = 100
        gvSpecs.Columns.Add(fldCycleTime)
        gvSpecs.Columns("fldCycleTime").FormatString = "{0:N2}"

        Dim fldEffectivityDate As New GridViewDateTimeColumn("EFFECTIVITY ADDED")
        fldEffectivityDate.FieldName = "fldEffectivityDate"
        fldEffectivityDate.Width = 150
        fldEffectivityDate.Format = DateTimePickerFormat.Custom
        fldEffectivityDate.CustomFormat = "MMM dd, yyyy"
        gvSpecs.Columns.Add(fldEffectivityDate)
        gvSpecs.Columns("fldEffectivityDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvSpecs.Columns.Add(fldDateAdded)
        gvSpecs.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvSpecs.Columns.Add(fldAddedBy)

        gvSpecs.ReadOnly = True
        gvSpecs.AllowAddNewRow = False
        gvSpecs.AllowDeleteRow = False
        gvSpecs.EnableFiltering = True
        gvSpecs.ShowFilteringRow = False
        gvSpecs.ShowGroupPanel = False
        gvSpecs.MultiSelect = True

        gvSpecs.TableElement.RowHeight = 25

    End Sub

    Private Sub loadRecord()

        Slipknot.addParameter("parId", txtId.Text)
        Dim data As DataTable = Slipknot.dbSelect("SP_SelectItemMasterById")

        If data.Rows.Count > 0 Then

            txtItemCode.Text = Convert.ToString(data.Rows(0).Item("fldItemCode"))
            txtPartName.Text = Convert.ToString(data.Rows(0).Item("fldPartName"))
            txtDescription.Text = Convert.ToString(data.Rows(0).Item("fldDescription"))
            ddCategory.Text = Convert.ToString(data.Rows(0).Item("fldCategory"))
            ddUOM.Text = Convert.ToString(data.Rows(0).Item("fldUOM"))
            txtRegistrationNo.Text = Convert.ToString(data.Rows(0).Item("fldRegistrationNo"))
            chkSellable.Checked = Convert.ToBoolean(data.Rows(0).Item("fldSellable"))
            chkInhouse.Checked = Convert.ToBoolean(data.Rows(0).Item("fldInHouse"))
            chkOutSide.Checked = Convert.ToBoolean(data.Rows(0).Item("fldOutSide"))

            If Convert.ToString(data.Rows(0).Item("fldMakerCode")) <> String.Empty Then
                mcbMaker.SelectedValue = Convert.ToString(data.Rows(0).Item("fldMakerCode"))
            Else
                mcbMaker.SelectedValue = Nothing
            End If

        End If

    End Sub

    Private Sub loadCategory()

        Dim dtCategory As DataTable = Slipknot.dbSelect("SP_SelectAllCategory")

        ddCategory.DataSource = dtCategory
        ddCategory.ValueMember = "fldCategory"
        ddCategory.DisplayMember = "fldCategory"

        Dim dtSubCategory As DataTable = Slipknot.dbSelect("SP_SelectAllCategory")

        ddSubCategory.DataSource = dtSubCategory
        ddSubCategory.ValueMember = "fldCategory"
        ddSubCategory.DisplayMember = "fldCategory"

    End Sub

    Private Sub loadUOM()
        Dim dtUOM As DataTable = Slipknot.dbSelect("SP_SelectAllUOM")

        ddUOM.DataSource = dtUOM
        ddUOM.ValueMember = "fldUOM"
        ddUOM.DisplayMember = "fldUOM"
    End Sub

    Private Sub loadMaker()

        Dim dtMaker As DataTable = Slipknot.dbSelect("SP_SelectAllMaker")

        Dim fldMakerName As New GridViewTextBoxColumn("MAKER")
        fldMakerName.FieldName = "fldMakerName"
        fldMakerName.Width = 220
        mcbMaker.MultiColumnComboBoxElement.Columns.Add(fldMakerName)

        Dim fldMakerCode As New GridViewTextBoxColumn("CODE")
        fldMakerCode.FieldName = "fldMakerCode"
        fldMakerCode.IsVisible = False
        mcbMaker.MultiColumnComboBoxElement.Columns.Add(fldMakerCode)

        mcbMaker.DataSource = dtMaker
        mcbMaker.ValueMember = "fldMakerCode"
        mcbMaker.DisplayMember = "fldMakerName"
        mcbMaker.MultiColumnComboBoxElement.DropDownWidth = 270

        mcbMaker.AutoFilter = True
        mcbMaker.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim makerName As New FilterDescriptor()
        makerName.PropertyName = "fldMakerName"
        makerName.Operator = FilterOperator.Contains
        mcbMaker.EditorControl.MasterTemplate.FilterDescriptors.Add(makerName)

    End Sub

    Private Sub deleteProcess()
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvProcess.SelectedRows.Count - 1) {}

        gvProcess.SelectedRows.CopyTo(rows, 0)

        Dim id As String

        For i As Integer = 0 To rows.Length - 1

            id = Convert.ToString(rows(i).Cells("fldId").Value)

            Slipknot.addParameter("parId", id)
            Slipknot.dbAED("SP_DeleteItemProcess")
        Next
    End Sub

    Private Sub cbbSaveChanges_Click(sender As Object, e As EventArgs) Handles cbbSaveChanges.Click

        If chkInhouse.Checked = False And chkOutSide.Checked = False Then
            RadMessageBox.Show("Please identify if the item is inhouse or outside", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        Dim updateMode As Integer = 0

        If BulletForMyValentine.checkIfHaveChild(txtItemCodeOrig.Text) Then
            updateMode = 1
        End If

        Slipknot.addParameter("parId", txtId.Text)
        Slipknot.addParameter("parItemCode", txtItemCode.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPartName", txtPartName.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parDescription", txtDescription.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parCategory", ddCategory.Text)
        Slipknot.addParameter("parSubCategory", ddSubCategory.Text)
        Slipknot.addParameter("parUOM", ddUOM.Text)

        If txtRegistrationNo.Text.TrimStart.TrimEnd = String.Empty Then
            Slipknot.addParameter("parRegistrationNo", DBNull.Value)
        Else
            Slipknot.addParameter("parRegistrationNo", txtRegistrationNo.Text.TrimStart.TrimEnd)
        End If

        Slipknot.addParameter("parMakerCode", mcbMaker.SelectedValue)
        Slipknot.addParameter("parSellable", chkSellable.Checked)
        Slipknot.addParameter("parInHouse", chkInhouse.Checked)
        Slipknot.addParameter("parOutSide", chkOutSide.Checked)
        Slipknot.addParameter("parUpdateMode", updateMode)

        If Slipknot.dbAED("SP_UpdateItemMasterData") Then
            RadMessageBox.Show("Successfully Updated!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Private Sub FrmEditItemMasterData_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        loadItemPerCustomer()
        loadItemModel()
        loadItemProcess()
        loadPartHistory()
        loadSpecs()
    End Sub

    Private Sub cbbRefreshProcess_Click(sender As Object, e As EventArgs) Handles cbbRefreshProcess.Click
        loadItemProcess()
    End Sub

    Private Sub gvProcess_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvProcess.FilterChanged
        leCountProcess.Text = gvProcess.ChildRows.Count.ToString
    End Sub

    Private Sub gvProcess_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvProcess.RowsChanged
        leCountProcess.Text = gvProcess.ChildRows.Count.ToString
    End Sub

    Private Sub loadItemPerCustomer()
        Dim dtCustomer As DataTable

        Slipknot.addParameter("parItemCode", txtItemCodeOrig.Text)
        dtCustomer = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomerByParent")

        gvCustomer.DataSource = dtCustomer

    End Sub

    Private Sub loadItemProcess()
        Dim dtProcess As DataTable

        Slipknot.addParameter("parItemCode", txtItemCodeOrig.Text)
        dtProcess = Slipknot.dbSelect("SP_SelectItemProcessByParent")

        gvProcess.DataSource = dtProcess
    End Sub

    Private Sub loadItemModel()
        Dim dtModel As DataTable

        Slipknot.addParameter("parItemCode", txtItemCodeOrig.Text)
        dtModel = Slipknot.dbSelect("SP_SelectItemPerModelByParent")

        gvModel.DataSource = dtModel
    End Sub

    Private Sub loadPartHistory()

        Dim dtPartNoHistory As DataTable

        Slipknot.addParameter("parItemCode", txtItemCodeOrig.Text)
        dtPartNoHistory = Slipknot.dbSelect("SP_SelectAllPartyNoHistoryByParent")

        gvPartNoHistory.DataSource = dtPartNoHistory
    End Sub

    Private Sub loadSpecs()

        Dim dtSpecs As DataTable

        Slipknot.addParameter("parItemCode", txtItemCodeOrig.Text)
        dtSpecs = Slipknot.dbSelect("SP_SelectSpecsByItemCode")

        gvSpecs.DataSource = dtSpecs
    End Sub

    Private Sub cbbRefreshCustomer_Click(sender As Object, e As EventArgs) Handles cbbRefreshCustomer.Click
        loadItemPerCustomer()
    End Sub

    Private Sub gvCustomer_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvCustomer.RowsChanged
        leCountCustomer.Text = gvCustomer.ChildRows.Count.ToString
    End Sub

    Private Sub cbbRefreshPartNo_Click(sender As Object, e As EventArgs) Handles cbbRefreshPartNo.Click
        loadPartHistory()
    End Sub

    Private Sub gvPartNoHistory_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvPartNoHistory.RowsChanged
        leCountPartNoHistory.Text = gvPartNoHistory.ChildRows.Count.ToString
    End Sub

    Private Sub cbbRefreshModel_Click(sender As Object, e As EventArgs) Handles cbbRefreshModel.Click
        loadItemModel()
    End Sub

    Private Sub gvModel_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvModel.RowsChanged
        leCountModel.Text = gvModel.ChildRows.Count.ToString
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        loadSpecs()
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If Slipknot.IsFormOpen(FrmAddItemSpecs) Then
            FrmAddItemSpecs.Focus()
        Else
            FrmAddItemSpecs.txtItemCode.Text = txtItemCodeOrig.Text
            FrmAddItemSpecs.Show(Me)
        End If
    End Sub

    Private Sub gvSpecs_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvSpecs.RowsChanged
        leCountRecSpecs.Text = gvSpecs.ChildRows.Count.ToString
    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If Slipknot.IsFormOpen(FrmAddItemSpecs) Then
            FrmAddItemSpecs.Focus()
        Else
            If gvSpecs.SelectedRows.Count > 0 Then
                FrmAddItemSpecs.txtId.Text = Convert.ToString(gvSpecs.CurrentRow.Cells("fldId").Value)
                FrmAddItemSpecs.Show(Me)
            End If
        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvSpecs.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you want to delete selected specs?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvSpecs.SelectedRows.Count - 1) {}

                gvSpecs.SelectedRows.CopyTo(rows, 0)

                Dim id As String = Nothing

                For i As Integer = 0 To rows.Length - 1

                    id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)

                Next

                Slipknot.addParameter("parIdArray", id)
                Slipknot.dbAED("SP_DeleteItemSpecs")

                loadSpecs()
            End If
        End If
    End Sub
End Class
