Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmModelGroupAssignment

    Private myData As DataTable
    Private Sub FrmModelGroupAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadLines()
        loadModels()
        loadCustomer()

        dtpEffectivityDate.Format = DateTimePickerFormat.Custom
        dtpEffectivityDate.CustomFormat = "MMM dd, yyyy"
        dtpEffectivityDate.Value = Today

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim line As New GridViewTextBoxColumn("LINE")
        line.FieldName = "line"
        line.Width = 150
        gvData.Columns.Add(line)

        Dim model As New GridViewTextBoxColumn("MODEL")
        model.FieldName = "model"
        model.Width = 150
        gvData.Columns.Add(model)

        Dim customer As New GridViewTextBoxColumn("CUSTOMER")
        customer.FieldName = "customer"
        customer.Width = 150
        gvData.Columns.Add(customer)

        Dim fldActualGroup As New GridViewDecimalColumn("ACTUAL GROUP")
        fldActualGroup.FieldName = "fldActualGroup"
        fldActualGroup.Width = 120
        gvData.Columns.Add(fldActualGroup)

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

    Private Sub loadLines()

        Dim dtLines As DataTable = Slipknot.dbSelect("SP_SelectAllLines")

        Dim fldLineName As New GridViewTextBoxColumn("LINE NAME")
        fldLineName.FieldName = "fldLineName"
        fldLineName.Width = 160
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldLineName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbLine.DataSource = dtLines
        mcbLine.DisplayMember = "fldLineName"
        mcbLine.ValueMember = "fldCode"
        mcbLine.MultiColumnComboBoxElement.DropDownWidth = 210

        mcbLine.AutoFilter = True
        mcbLine.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim line As New FilterDescriptor()
        line.PropertyName = "fldLineName"
        line.Operator = FilterOperator.Contains
        mcbLine.EditorControl.MasterTemplate.FilterDescriptors.Add(line)

    End Sub

    Private Sub loadModels()

        Dim dtModels As DataTable = Slipknot.dbSelect("SP_SelectAllModel")

        Dim fldModelName As New GridViewTextBoxColumn("MODEL NAME")
        fldModelName.FieldName = "fldModelName"
        fldModelName.Width = 160
        mcbModel.MultiColumnComboBoxElement.Columns.Add(fldModelName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        mcbModel.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbModel.DataSource = dtModels
        mcbModel.DisplayMember = "fldModelName"
        mcbModel.ValueMember = "fldCode"
        mcbModel.MultiColumnComboBoxElement.DropDownWidth = 210

        mcbModel.AutoFilter = True
        mcbModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim model As New FilterDescriptor()
        model.PropertyName = "fldModelName"
        model.Operator = FilterOperator.Contains
        mcbModel.EditorControl.MasterTemplate.FilterDescriptors.Add(model)

    End Sub

    Private Sub loadCustomer()

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSROMER NAME")
        fldCustomerName.FieldName = "fldCustomerName"
        fldCustomerName.Width = 150
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CODE")
        fldCustomerCode.FieldName = "fldCustomerCode"
        fldCustomerCode.IsVisible = False
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        mcbCustomer.DataSource = dtCustomer
        mcbCustomer.ValueMember = "fldCustomerCode"
        mcbCustomer.DisplayMember = "fldCustomerName"
        mcbCustomer.MultiColumnComboBoxElement.DropDownWidth = 210

        mcbCustomer.AutoFilter = True
        mcbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerName As New FilterDescriptor()
        customerName.PropertyName = "fldCustomerName"
        customerName.Operator = FilterOperator.Contains
        mcbCustomer.EditorControl.MasterTemplate.FilterDescriptors.Add(customerName)

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If mcbLine.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select line properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbModel.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select model properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbCustomer.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select customer properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parLineCode", mcbLine.SelectedValue)
        Slipknot.addParameter("parModelCode", mcbModel.SelectedValue)
        Slipknot.addParameter("parCustomerCode", mcbCustomer.SelectedValue)
        Slipknot.addParameter("parActualGroup", seActualGroup.Value)
        Slipknot.addParameter("parEffectivityDate", dtpEffectivityDate.Value)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertActualGroup") Then
            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectAllGroupAssignment")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmModelGroupAssignment_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
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
        Slipknot.dbAED("SP_DeleteActualGroupAssignment")
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
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwDelete.IsBusy = False Then
                    bwDelete.RunWorkerAsync()
                End If
            End If
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
End Class
