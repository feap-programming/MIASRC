Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmItemMasterData

    Private myData As DataTable
    Private Sub FrmItemMasterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadDropDown()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.ReadOnly = True
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 150
        gvData.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 220
        gvData.Columns.Add(fldPartName)

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 220
        gvData.Columns.Add(fldDescription)

        Dim fldCategory As New GridViewTextBoxColumn("CATEGORY")
        fldCategory.FieldName = "fldCategory"
        fldCategory.Width = 100
        gvData.Columns.Add(fldCategory)

        Dim fldSubCategory As New GridViewTextBoxColumn("SUB-CATEGORY")
        fldSubCategory.FieldName = "fldSubCategory"
        fldSubCategory.Width = 100
        gvData.Columns.Add(fldSubCategory)

        Dim fldUOM As New GridViewTextBoxColumn("UOM")
        fldUOM.FieldName = "fldUOM"
        fldUOM.Width = 90
        gvData.Columns.Add(fldUOM)

        Dim fldRegistrationNo As New GridViewTextBoxColumn("REGISTRATION NO.")
        fldRegistrationNo.FieldName = "fldRegistrationNo"
        fldRegistrationNo.Width = 140
        gvData.Columns.Add(fldRegistrationNo)

        Dim fldMaker As New GridViewTextBoxColumn("MAKER")
        fldMaker.FieldName = "fldMakerName"
        fldMaker.Width = 140
        gvData.Columns.Add(fldMaker)

        Dim fldSellable As New GridViewCheckBoxColumn("SELLABLE")
        fldSellable.FieldName = "fldSellable"
        fldSellable.Width = 80
        gvData.Columns.Add(fldSellable)

        Dim fldInHouse As New GridViewCheckBoxColumn("IN HOUSE")
        fldInHouse.FieldName = "fldInHouse"
        fldInHouse.Width = 80
        gvData.Columns.Add(fldInHouse)

        Dim fldOutSide As New GridViewCheckBoxColumn("OUT SIDE")
        fldOutSide.FieldName = "fldOutSide"
        fldOutSide.Width = 80
        gvData.Columns.Add(fldOutSide)

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

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectAllItemMasterData")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmItemMasterData_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork

        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        'Dim id As String = Nothing
        Dim itemCode As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1
            'itemCode = Convert.ToString(rows(i).Cells("fldItemCode").Value)

            'If BFMV.checkIfHaveChild(itemCode) = False Then
            '    id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)
            'End If

            itemCode = itemCode & "," & Convert.ToString(rows(i).Cells("fldItemCode").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("parItemCodeArray", itemCode)
        Slipknot.dbAED("SP_DeleteItemMasterData")

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

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbAddRecord_Click(sender As Object, e As EventArgs) Handles cbbAddRecord.Click

        If BulletForMyValentine.isRW("fldMDItemMasterData") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If txtItemCode.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Item code not be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If txtPartname.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Partname should not be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If mcbMaker.SelectedValue = Nothing Then
            RadMessageBox.Show("Maker should not be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If chkInhouse.Checked = False And chkOutSide.Checked = False Then
            RadMessageBox.Show("Please identify if the item is inhouse or outside", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        Slipknot.addParameter("parItemCode", txtItemCode.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPartname", txtPartname.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parDescription", txtDescription.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parCategory", ddCategory.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parSubCategory", ddSubCategory.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parUOM", ddUOM.Text.TrimStart.TrimEnd)

        If txtRegistrationNo.Text.TrimStart.TrimEnd = String.Empty Then
            Slipknot.addParameter("parRegistrationNo", DBNull.Value)
        Else
            Slipknot.addParameter("parRegistrationNo", txtRegistrationNo.Text.TrimStart.TrimEnd)
        End If

        Slipknot.addParameter("parMakerCode", mcbMaker.SelectedValue)
        Slipknot.addParameter("parSellable", chkSellable.Checked)
        Slipknot.addParameter("parInHouse", chkInhouse.Checked)
        Slipknot.addParameter("parOutSide", chkOutSide.Checked)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertItemMasterData") Then

            txtPartname.Clear()
            txtItemCode.Clear()
            txtRegistrationNo.Clear()

            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub cbbDeleteRecord_Click(sender As Object, e As EventArgs) Handles cbbDeleteRecord.Click

        If BulletForMyValentine.isRW("fldMDItemMasterData") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("WARNING! This item code will not exist in the system once deleted, other modules used this item code may encounter data iconsistency. This operation is irreversible are you sure want to delete " & gvData.SelectedRows.Count & " selected record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

                frmConfirmCode.ShowDialog()
                If confirmCode Then
                    confirmCode = False

                    If bwOperation.IsBusy = False Then
                        bwOperation.RunWorkerAsync()
                    End If

                End If
            End If
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

        Dim dtCategory As DataTable = Slipknot.dbSelect("SP_SelectAllCategory")

        ddCategory.DataSource = dtCategory
        ddCategory.ValueMember = "fldCategory"
        ddCategory.DisplayMember = "fldCategory"

        ddSubCategory.DataSource = dtCategory
        ddSubCategory.ValueMember = "fldCategory"
        ddSubCategory.DisplayMember = "fldCategory"

        Dim dtUOM As DataTable = Slipknot.dbSelect("SP_SelectAllUOM")

        ddUOM.DataSource = dtUOM
        ddUOM.ValueMember = "fldUOM"
        ddUOM.DisplayMember = "fldUOM"

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

    Private Sub cbbEditRecord_Click(sender As Object, e As EventArgs) Handles cbbEditRecord.Click

        If gvData.SelectedRows.Count > 0 Then
            If Slipknot.IsFormOpen(FrmEditItemMasterData) Then
                FrmEditItemMasterData.Focus()
            Else
                If BulletForMyValentine.isRW("fldMDItemMasterData") = False Then
                    Slapshock.NoAccessToFunctionMessage()

                    Exit Sub
                End If

                FrmEditItemMasterData.txtId.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmEditItemMasterData.txtItemCodeOrig.Text = Convert.ToString(gvData.CurrentRow.Cells("fldItemCode").Value)
                FrmEditItemMasterData.Show(Me)
            End If
        End If

    End Sub

    Private Sub miItemCode_Click(sender As Object, e As EventArgs) Handles miItemCode.Click

        If Slipknot.IsFormOpen(FrmImportItemMaster) Then
            FrmImportItemMaster.Focus()
        Else
            If BulletForMyValentine.isRW("fldMDItemMasterData") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            FrmImportItemMaster.Show(Me)
        End If

    End Sub

    Private Sub miItemSpecs_Click(sender As Object, e As EventArgs) Handles miItemSpecs.Click

        If Slipknot.IsFormOpen(frmImportItemSpecs) Then
            frmImportItemSpecs.Focus()
        Else
            If BulletForMyValentine.isRW("fldMDItemMasterData") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportItemSpecs.Show(Me)
        End If

    End Sub
End Class
