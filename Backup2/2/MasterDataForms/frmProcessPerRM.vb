Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class frmProcessPerRM

    Private Sub FrmProcessPerItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadProcess()
        loadItemMaster()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.ReadOnly = True
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldItemCode As New GridViewTextBoxColumn("RM NUMBER")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 150
        gvData.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 250
        gvData.Columns.Add(fldPartName)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 300
        gvData.Columns.Add(fldProcessName)

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

    Dim myData As DataTable

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        myData = Slipknot.dbSelect("SP_SelectAllProcessPerRM")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmProcessPerItem_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
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

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        If BulletForMyValentine.isRW("fldMDRMPerProcess") = False Then
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

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)
            Dim percent As Double

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("parIdArray", id)
        Slipknot.dbAED("SP_DeleteRMProcess")
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

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
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

    Private Sub loadProcess()

        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllProcess")

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS NAME")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 310
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldProcessName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbProcess.DataSource = dtProcess
        mcbProcess.ValueMember = "fldCode"
        mcbProcess.DisplayMember = "fldProcessName"
        mcbProcess.MultiColumnComboBoxElement.DropDownWidth = 380

        mcbProcess.AutoFilter = True
        mcbProcess.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim processName As New FilterDescriptor()
        processName.PropertyName = "fldProcessName"
        processName.Operator = FilterOperator.Contains
        mcbProcess.EditorControl.MasterTemplate.FilterDescriptors.Add(processName)

    End Sub

    Private Sub loadItemMaster()

        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllRM")

        Dim fldItemCode As New GridViewTextBoxColumn("RM NUMBER")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 160
        mcbRMNumber.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 200
        mcbRMNumber.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbRMNumber.DataSource = dtProduct
        mcbRMNumber.ValueMember = "fldItemCode"
        mcbRMNumber.DisplayMember = "fldItemCode"
        mcbRMNumber.MultiColumnComboBoxElement.DropDownWidth = 400

        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        mcbRMNumber.AutoFilter = True
        mcbRMNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbRMNumber.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If BulletForMyValentine.isRW("fldMDRMPerProcess") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If mcbRMNumber.SelectedValue Is Nothing Then
            RadMessageBox.Show("Item code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbProcess.SelectedValue Is Nothing Then
            RadMessageBox.Show("Process cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parItemCode", mcbRMNumber.SelectedValue)
        Slipknot.addParameter("parProcessCode", mcbProcess.SelectedValue)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertRMProcess") Then
            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub cbbImport_Click(sender As Object, e As EventArgs) Handles cbbImport.Click

        If Slipknot.IsFormOpen(frmImportRMPerProcess) Then
            frmImportRMPerProcess.Focus()
        Else
            If BulletForMyValentine.isRW("fldMDRMPerProcess") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportRMPerProcess.Show(Me)
        End If

    End Sub
End Class
