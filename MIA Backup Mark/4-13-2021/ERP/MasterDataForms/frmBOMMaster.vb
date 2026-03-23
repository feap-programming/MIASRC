Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmBOMMaster
    Private Sub FrmBOMMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadDropDown()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldParentCode As New GridViewTextBoxColumn("PARENT PART NO.")
        fldParentCode.FieldName = "fldParentCode"
        fldParentCode.Width = 130
        gvData.Columns.Add(fldParentCode)

        Dim fldChildCode As New GridViewTextBoxColumn("CHILD PART NO.")
        fldChildCode.FieldName = "fldChildCode"
        fldChildCode.Width = 130
        gvData.Columns.Add(fldChildCode)

        Dim fldUsage As New GridViewDecimalColumn("USAGE")
        fldUsage.FieldName = "fldUsage"
        fldUsage.Width = 90
        gvData.Columns.Add(fldUsage)
        gvData.Columns("fldUsage").FormatString = "{0:N6}"

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

    Dim myData As DataTable
    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectAllBOMMaster")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmBOMMaster_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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

        'LOAD PART NO. HISTORY

        Dim dtPartNoHistory As DataTable = Slipknot.dbSelect("SP_SelectAllItemCode")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 160
        mcbParent.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 160
        mcbParent.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbParent.DataSource = dtPartNoHistory
        mcbParent.ValueMember = "fldItemCode"
        mcbParent.DisplayMember = "fldItemCode"
        mcbParent.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbParent.AutoFilter = True
        mcbParent.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbParent.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

        'LOAD PART NO. HISTORY

        Dim dtPartNoHistory2 As DataTable = Slipknot.dbSelect("SP_SelectAllItemCode")

        Dim fldItemCode2 As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode2.FieldName = "fldItemCode"
        fldItemCode2.Width = 160
        mcbChild.MultiColumnComboBoxElement.Columns.Add(fldItemCode2)

        Dim fldPartName2 As New GridViewTextBoxColumn("PART NAME")
        fldPartName2.FieldName = "fldPartName"
        fldPartName2.Width = 160
        mcbChild.MultiColumnComboBoxElement.Columns.Add(fldPartName2)

        mcbChild.DataSource = dtPartNoHistory2
        mcbChild.ValueMember = "fldItemCode"
        mcbChild.DisplayMember = "fldItemCode"
        mcbChild.MultiColumnComboBoxElement.DropDownWidth = 500

        mcbChild.AutoFilter = True
        mcbChild.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode2 As New FilterDescriptor()
        itemCode2.PropertyName = "fldItemCode"
        itemCode2.Operator = FilterOperator.Contains
        mcbChild.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode2)

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If BulletForMyValentine.isRW("fldMDBOMMasterData") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If mcbParent.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please parent part number properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbChild.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please parent part number properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbParent.SelectedValue = mcbChild.SelectedValue Then
            RadMessageBox.Show("Parent part no. cannot be equal to child part no", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parParent", mcbParent.SelectedValue)
        Slipknot.addParameter("parChild", mcbChild.SelectedValue)
        Slipknot.addParameter("parUsage", seUsage.Value)
        Slipknot.addParameter("parRemarks", txtRemarks.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertBOMMaster") Then
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
        Slipknot.dbAED("SP_DeleteBOMMaster")

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

    Private Sub cbbDeleteRecord_Click(sender As Object, e As EventArgs) Handles cbbDeleteRecord.Click
        If BulletForMyValentine.isRW("fldMDBOMMasterData") = False Then
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

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click

        If gvData.SelectedRows.Count > 0 Then
            If Slipknot.IsFormOpen(FrmEditBOMMaster) Then
                FrmEditBOMMaster.Focus()
            Else
                If BulletForMyValentine.isRW("fldMDBOMMasterData") = False Then
                    Slapshock.NoAccessToFunctionMessage()

                    Exit Sub
                End If

                FrmEditBOMMaster.txtID.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmEditBOMMaster.Show(Me)
            End If
        End If

    End Sub

    Private Sub cbbCopy_Click(sender As Object, e As EventArgs) Handles cbbCopy.Click

        If gvData.SelectedRows.Count > 0 Then
            If Slipknot.IsFormOpen(FrmCopyChild) Then
                FrmCopyChild.Focus()
            Else
                If BulletForMyValentine.isRW("fldMDBOMMasterData") = False Then
                    Slapshock.NoAccessToFunctionMessage()

                    Exit Sub
                End If

                FrmCopyChild.Show(Me)
                collectSelected()
            End If
        End If

    End Sub

    Private Sub collectSelected()

        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim table As New DataTable
        table.Columns.Add("fldChildCode")
        table.Columns.Add("fldUsage")
        table.Columns.Add("fldRemarks")

        For i As Integer = 0 To rows.Length - 1

            table.Rows.Add(rows(i).Cells("fldChildCode").Value, rows(i).Cells("fldUsage").Value, rows(i).Cells("fldRemarks").Value)

        Next

        FrmCopyChild.gvData.DataSource = table

    End Sub

    Private Sub cbbImport_Click(sender As Object, e As EventArgs) Handles cbbImport.Click

        If Slipknot.IsFormOpen(frmImportBOMMaster) Then
            frmImportBOMMaster.Focus()
        Else
            If BulletForMyValentine.isRW("fldMDBOMMasterData") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportBOMMaster.Show(Me)
        End If

    End Sub
End Class
