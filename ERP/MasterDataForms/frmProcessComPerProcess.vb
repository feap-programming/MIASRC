Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmProcessComPerProcess

    Private myData As DataTable

    Private Sub FrmProcessComPerProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        loadProcessList(mcbProcess)
        loadProcessComponentList(mcbProcessComponent)
        SetUpColumns(gvData)
    End Sub

    Private Sub FrmProcessComPerProcess_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        myData = Slipknot.dbSelect("SP_SelectAllProcessComPerProcess")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Slipknot.addParameter("parProcessCode", mcbProcess.SelectedValue)
        Slipknot.addParameter("parSubProcessCode", mcbProcessComponent.SelectedValue)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertProcessComPerProcess") Then

            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If

        End If
    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

                frmConfirmCode.ShowDialog()

                If confirmCode Then
                    confirmCode = False
                    If bwDelete.IsBusy = False Then
                        bwDelete.RunWorkerAsync()
                    End If
                End If

            End If
        End If
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
        Slipknot.dbAED("SP_DeleteProcessComPerProcess")
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
    Private Sub cbbExportData_Click(sender As Object, e As EventArgs) Handles cbbExportData.Click
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

    Private Sub loadProcessList(multiColCB As RadMultiColumnComboBox)

        Dim dtProcessList As DataTable = Slipknot.dbSelect("SP_SelectAllProcess")

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 160
        multiColCB.MultiColumnComboBoxElement.Columns.Add(fldCode)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS NAME")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 200
        multiColCB.MultiColumnComboBoxElement.Columns.Add(fldProcessName)

        multiColCB.DataSource = dtProcessList
        multiColCB.ValueMember = "fldCode"
        multiColCB.DisplayMember = "fldProcessName"
        multiColCB.MultiColumnComboBoxElement.DropDownWidth = 400

        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        multiColCB.AutoFilter = True
        multiColCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim processName As New FilterDescriptor()
        processName.PropertyName = "fldProcessName"
        processName.Operator = FilterOperator.Contains
        multiColCB.EditorControl.MasterTemplate.FilterDescriptors.Add(processName)

    End Sub

    Private Sub loadProcessComponentList(multiColCB As RadMultiColumnComboBox)

        Dim dtProcessList As DataTable = Slipknot.dbSelect("SP_SelectAllPComponentList")

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 160
        multiColCB.MultiColumnComboBoxElement.Columns.Add(fldCode)

        Dim fldName As New GridViewTextBoxColumn("PROCESS COM. NAME")
        fldName.FieldName = "fldName"
        fldName.Width = 200
        multiColCB.MultiColumnComboBoxElement.Columns.Add(fldName)

        multiColCB.DataSource = dtProcessList
        multiColCB.ValueMember = "fldCode"
        multiColCB.DisplayMember = "fldName"
        multiColCB.MultiColumnComboBoxElement.DropDownWidth = 400

        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        multiColCB.AutoFilter = True
        multiColCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor()
        name.PropertyName = "fldName"
        name.Operator = FilterOperator.Contains
        multiColCB.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gridView.Columns.Add(fldId)

        Dim fldProcessCode As New GridViewTextBoxColumn("PROCESS CODE")
        fldProcessCode.FieldName = "fldProcessCode"
        fldProcessCode.Width = 80
        gridView.Columns.Add(fldProcessCode)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS NAME")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 150
        gridView.Columns.Add(fldProcessName)

        Dim fldProcessComCode As New GridViewTextBoxColumn("PROCESS COM. CODE")
        fldProcessComCode.FieldName = "fldProcessComCode"
        fldProcessComCode.Width = 80
        gridView.Columns.Add(fldProcessComCode)

        Dim fldProcessComName As New GridViewTextBoxColumn("PROCESS COM. NAME")
        fldProcessComName.FieldName = "fldProcessComName"
        fldProcessComName.Width = 150
        gridView.Columns.Add(fldProcessComName)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gridView.Columns.Add(fldDateAdded)
        gridView.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gridView.Columns.Add(fldAddedBy)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub

End Class
