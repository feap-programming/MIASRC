Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI.Export
Imports Telerik.Reporting
Imports Telerik.WinControls.Data

Public Class ucDemand

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtDemand As DataTable

    Private parYear As Integer
    Private parCustomerID As Integer

    Private myData As DataTable

    Private Sub ucDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeThemeUC(Me)

        numYear.Value = Year(Now)
        LoadCustomerDropDown(ddCustomerCode)

        SetUpColumns()

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then

            If Not String.IsNullOrWhiteSpace(ddCustomerCode.Text) Then

                parYear = numYear.Value
                parCustomerID = ddCustomerCode.SelectedValue

                bwLoadData.RunWorkerAsync()

            Else

                RadMessageBox.Show(Me, "Please select customer.", "Invalid Customer", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            End If

        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        If Not bwLoadData.CancellationPending Then

            Slipknot.addParameter("parCustomerID", ddCustomerCode.SelectedValue)
            Slipknot.addParameter("parYear", numYear.Value)
            dtDemand = Slipknot.dbSelect("SP_P_SelectDemandPerYearCustomer")
            myData = dtDemand

            RadProgressBarElement1.Text = "Done"
            bwLoadData.ReportProgress(Convert.ToInt32(100))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged

        If e.ProgressPercentage = 0 Then
            RadProgressBarElement1.Text = "Preparing..."
        ElseIf e.ProgressPercentage = 100 Then
            RadProgressBarElement1.Text = "Done"
        Else
            RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        End If

        RadProgressBarElement1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted

        If Not e.Cancelled Then

            gvData.DataSource = myData
            gvData.BestFitColumns()
            leCountRec.Text = gvData.Rows.Count

            If myData.Rows.Count = 0 Then

                RadMessageBox.Show(Me, "There are items not found in the master list", "Item Not Found", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            End If

        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("It will also delete all history record under this item, are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
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
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id += "," & Convert.ToString(rows(i).Cells("fldID").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("IDArray", id)
        Slipknot.dbAED("SP_P_DeleteDemand")
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

    Private Sub cbImportData_Click(sender As Object, e As EventArgs) Handles cbImportData.Click
        Dim editForm As New FrmImportDemand
        editForm.ShowDialog(Me)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub cbExport_Click(sender As Object, e As EventArgs) Handles cbExport.Click
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

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click
        Dim reportSelector As New FrmDemandReportSelector
        reportSelector.ShowDialog(Me)
    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.EnableFiltering = True
            gvData.MasterTemplate.ShowHeaderCellButtons = True
            gvData.MasterTemplate.ShowFilteringRow = True
        Else
            gvData.EnableFiltering = False
            gvData.MasterTemplate.ShowHeaderCellButtons = False
            gvData.MasterTemplate.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub gvData_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs) Handles gvData.ContextMenuOpening

        Dim cell As GridDataCellElement = TryCast(e.ContextMenuProvider, GridDataCellElement)

        If cell Is Nothing Then
            Return
        End If

        e.ContextMenu = cmActionChooser.DropDown

    End Sub

    Private Sub miCopy_Click(sender As Object, e As EventArgs) Handles miCopy.Click
        Dim selecionMode As GridViewSelectionMode = Me.gvData.SelectionMode
        Me.gvData.SelectionMode = GridViewSelectionMode.CellSelect
        Me.gvData.CurrentRow.Cells(Me.gvData.CurrentColumn.Name).IsSelected = True
        Me.gvData.Copy()
        Me.gvData.SelectionMode = selecionMode
        Me.gvData.CurrentRow.IsSelected = True
    End Sub

    Private Sub miEdit_Click(sender As Object, e As EventArgs) Handles miEdit.Click

        Try

            Dim id As Integer = 0
            id = gvData.CurrentRow.Cells("fldID").Value

            If id > 0 Then
                Dim editForm As New FrmEditDemand
                editForm.ShowDialog(id)
                If bwLoadData.IsBusy = False Then
                    bwLoadData.RunWorkerAsync()
                End If
            End If

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub miHistory_Click(sender As Object, e As EventArgs) Handles miHistory.Click

        Try

            Dim id As Integer = 0
            id = gvData.CurrentRow.Cells("fldID").Value

            If id > 0 Then
                Dim editForm As New FrmHistoryDemand
                editForm.ShowDialog(id)
            End If

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Public Sub LoadCustomerDropDown(dropdown As RadMultiColumnComboBox)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUSTOMER ID") With {
            .FieldName = "fldId",
            .Width = 100
        }
        dropdown.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER CODE") With {
            .FieldName = "fldCustomerName",
            .Width = 200
        }
        dropdown.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")
        dropdown.DataSource = dtCustomer
        dropdown.DisplayMember = "fldCustomerName"
        dropdown.ValueMember = "fldId"
        dropdown.MultiColumnComboBoxElement.DropDownWidth = 350

        dropdown.AutoFilter = True
        dropdown.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerCode As New FilterDescriptor With {
            .PropertyName = "fldCustomerName",
            .Operator = Telerik.WinControls.Data.FilterOperator.Contains
        }
        dropdown.EditorControl.MasterTemplate.FilterDescriptors.Add(customerCode)

        dropdown.SelectedIndex = -1
        dropdown.Text = String.Empty

    End Sub

    Private Sub SetUpColumns()

        Dim fldID As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldID)

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 100,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDFEAP)
        gvData.Columns("fldETDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomer As New GridViewTextBoxColumn("CUST ID") With {
            .FieldName = "fldCustomerID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldCustomer)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gvData.Columns.Add(fldCustomerName)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 250,
            .TextAlignment = ContentAlignment.MiddleLeft,
            .IsVisible = True
        }
        gvData.Columns.Add(fldPartName)

        Dim fldQuantity As New GridViewTextBoxColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldQuantity)
        gvData.Columns("fldQuantity").FormatString = "{0:N0}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY") With {
            .FieldName = "fldAddedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldAddedBy)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub cbbBudget_Click(sender As Object, e As EventArgs) Handles cbbBudget.Click
        FrmBudgetAmount.ShowDialog(Me)
    End Sub
End Class
