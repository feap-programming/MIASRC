Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class frmImportCustomerDemand
    Private linestat As String
    Private lineNo As Integer = 0
    Private withNG As Boolean = False

    Private dtItemPerCustomer As DataTable = Nothing
    Private dtCustomer As DataTable = Nothing

    Private Sub FrmUploadCD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        dtpDate.Value = DateTime.Today()
        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        fldStatColumn.FieldName = "STATUS"
        fldStatColumn.Width = 60
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.ReadOnly = True
        fldStatColumn.IsPinned = True
        fldStatColumn.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldStatColumn)

        Dim fldCustomer As New GridViewTextBoxColumn("CUSTOMER")
        fldCustomer.FieldName = "fldCustomer"
        fldCustomer.Width = 100
        fldCustomer.IsVisible = True
        gvData.Columns.Add(fldCustomer)

        Dim fldFGModel As New GridViewTextBoxColumn("FG MODEL")
        fldFGModel.FieldName = "fldFGModel"
        fldFGModel.Width = 120
        gvData.Columns.Add(fldFGModel)

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 150
        gvData.Columns.Add(fldDescription)

        Dim fldModel As New GridViewTextBoxColumn("MODEL")
        fldModel.FieldName = "fldModel"
        fldModel.Width = 120
        gvData.Columns.Add(fldModel)

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"

        fldAddedBy.Width = 100
        gvData.Columns.Add(fldAddedBy)

        Dim fldBudget As New GridViewTextBoxColumn("BUDGET")
        fldBudget.FieldName = "fldBudget"
        fldBudget.Width = 120
        fldBudget.IsVisible = True
        gvData.Columns.Add(fldBudget)
        gvData.Columns("fldBudget").FormatString = "{0:N2}"

        Dim fldForecast As New GridViewTextBoxColumn("FORECAST")
        fldForecast.FieldName = "fldForecast"
        fldForecast.Width = 120
        fldForecast.IsVisible = True
        gvData.Columns.Add(fldForecast)
        gvData.Columns("fldForecast").FormatString = "{0:N2}"

        Dim fldLatestDemand As New GridViewTextBoxColumn("LATEST DEMAND")
        fldLatestDemand.FieldName = "fldLatestDemand"
        fldLatestDemand.Width = 120
        fldLatestDemand.IsVisible = True
        gvData.Columns.Add(fldLatestDemand)
        gvData.Columns("fldLatestDemand").FormatString = "{0:N2}"

        Dim fldDate As New GridViewDateTimeColumn("DATE")
        fldDate.FieldName = "fldDate"
        fldDate.Width = 120
        fldDate.Format = DateTimePickerFormat.Custom
        fldDate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDate)
        gvData.Columns("fldDate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        gvData.ReadOnly = True
        gvData.EnableSorting = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False
        gvData.AllowAddNewRow = False
        gvData.ShowFilteringRow = False
        gvData.EnableFiltering = False
        gvData.EnableGrouping = False
        gvData.ShowGroupPanel = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False
        gvData.ShowRowHeaderColumn = False
        gvData.AllowAutoSizeColumns = True
        gvData.MultiSelect = True
        gvData.AllowDeleteRow = True

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click
        '.fldCustomer = Regex.Replace(Trim(T0.Item(0)), "\s+", " "),
        '.fldDescription = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
        '.fldFGModel = Regex.Replace(Trim(T0.Item(2)), "\s+", " "),
        '.fldModel = Regex.Replace(Trim(T0.Item(3)), "\s+", " "),
        '.fldBudget = IIf(Not String.IsNullOrEmpty(T0.Item(4)), T0.Item(4), 0),
        '.fldForecast = IIf(Not String.IsNullOrEmpty(T0.Item(5)), T0.Item(5), 0),
        '.fldLatestDemand = IIf(Not String.IsNullOrEmpty(T0.Item(6)), T0.Item(6), 0),
        '.fldAddedBy = Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "),
        '.fldDate = dtpDate.Value
        gvData.DataSource = Nothing

        Dim table As DataTable = Slipknot.getClipboard

        Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                    Select New With
                                         {
                                           .fldCustomer = Regex.Replace(Trim(T0.Item(0)), "\s+", " "),
                                           .fldDescription = Regex.Replace(Trim(T0.Item(2)), "\s+", " "),
                                           .fldFGModel = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
                                           .fldModel = Regex.Replace(Trim(T0.Item(3)), "\s+", " "),
                                           .fldBudget = IIf(Not String.IsNullOrEmpty(T0.Item(4)), T0.Item(4), 0),
                                           .fldForecast = IIf(Not String.IsNullOrEmpty(T0.Item(5)), T0.Item(5), 0),
                                           .fldLatestDemand = IIf(Not String.IsNullOrEmpty(T0.Item(6)), T0.Item(6), 0),
                                           .fldAddedBy = Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "),
                                           .fldDate = dtpDate.Value
                                         }).ToList
        gvData.DataSource = Query

    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click
        dtItemPerCustomer = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
        dtCustomer = Slipknot.dbSelect("SP_SelectAllCustomers")
        bwChecking.RunWorkerAsync()
    End Sub

    Private Sub bwChecking_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwChecking.DoWork
        Dim delay As Integer = 30

        Dim customerCode As String = String.Empty
        Dim description As String = String.Empty
        Dim model As String = String.Empty
        Dim existItems As Integer = 0

        For counter As Integer = 0 To gvData.Rows.Count - 1

            customerCode = If(dtCustomer.Select("fldCustomerName = '" & Regex.Replace(gvData.Rows(counter).Cells("fldCustomer").Value, "\s+", " ") & "'").Count() > 0,
                dtCustomer.Select("fldCustomerName = '" & Regex.Replace(gvData.Rows(counter).Cells("fldCustomer").Value, "\s+", " ") & "'")(0).Item("fldCustomerCode"),
                "0000")
            description = Regex.Replace(gvData.Rows(counter).Cells("fldDescription").Value, "\s+", " ")
            model = Regex.Replace(gvData.Rows(counter).Cells("fldModel").Value, "\s+", " ")
            existItems = dtItemPerCustomer.Select("fldCustomerCode = '" & customerCode & "' AND fldCustomerPartNo = '" & model & "' AND fldPartName = '" & description & "'").Count()

            If existItems > 0 Then
                linestat = "OK"
            Else
                linestat = "NG"
                If Not withNG Then
                    withNG = True
                End If
            End If

            Dim percent As Double = (counter / gvData.Rows.Count) * 100
            lineNo = counter
            RadProgressBarElement1.Text = "Saving..."
            bwChecking.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)
        Next
    End Sub

    Private Sub bwChecking_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwChecking.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwChecking_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwChecking.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        If RadProgressBarElement1.Value1 = 100 Then
            If Not withNG Then
                bwUpload.RunWorkerAsync()
            Else
                RadMessageBox.Show(Me, "There are items not found in master list.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Else
            RadMessageBox.Show(Me, "Error occured during checking.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If
        withNG = False
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 20
        For counter As Integer = 0 To gvData.Rows.Count - 1

            Slipknot.addParameter("Customer", Regex.Replace(gvData.Rows(counter).Cells("fldCustomer").Value, "\s+", " "))
            Slipknot.addParameter("_Description", Regex.Replace(gvData.Rows(counter).Cells("fldDescription").Value, "\s+", " "))
            Slipknot.addParameter("Model", Regex.Replace(gvData.Rows(counter).Cells("fldModel").Value, "\s+", " "))
            Slipknot.addParameter("AddedBy", Regex.Replace(gvData.Rows(counter).Cells("fldAddedBy").Value, "\s+", " "))
            Slipknot.addParameter("Budget", gvData.Rows(counter).Cells("fldBudget").Value)
            Slipknot.addParameter("Forecast", gvData.Rows(counter).Cells("fldForecast").Value)
            Slipknot.addParameter("LatestDemand", gvData.Rows(counter).Cells("fldLatestDemand").Value)
            Slipknot.addParameter("FDate", Convert.ToDateTime(gvData.Rows(counter).Cells("fldDate").Value))
            Slipknot.addParameter("FGModel", Regex.Replace(gvData.Rows(counter).Cells("fldFGModel").Value, "\s+", " "))

            If Slipknot.dbAED("SP_InsertCustomerDemand") Then
                linestat = "SAVED"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = (counter / gvData.Rows.Count) * 100
            lineNo = counter
            RadProgressBarElement1.Text = "Saving..."
            bwUpload.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)
        Next
    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        FrmCustomerDemand.bwLoadData.RunWorkerAsync()
        RadMessageBox.Show("Successfully Uploaded", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.CellFormatting
        If e.CellElement.ColumnInfo.Name = "STATUS" Then
            If e.CellElement.Value = "SAVED" Then
                e.CellElement.BackColor = Color.FromArgb(34, 167, 240)
                e.CellElement.BackColor2 = Color.FromArgb(34, 167, 240)
            ElseIf e.CellElement.Value = "OK" Then
                e.CellElement.BackColor = Color.FromArgb(4, 147, 114)
                e.CellElement.BackColor2 = Color.FromArgb(4, 147, 114)
            ElseIf e.CellElement.Value = "NG" Then
                e.CellElement.BackColor = Color.FromArgb(242, 38, 19)
                e.CellElement.BackColor2 = Color.FromArgb(242, 38, 19)
            Else
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            End If
        Else
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click
        If RadMessageBox.Show("Are you sure you want to clear the list?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            gvData.DataSource = Nothing
        End If
    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you want to delete " & gvData.SelectedRows.Count & " selected row(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}
            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1
                Me.gvData.Rows.Remove(rows(i))
            Next
        End If
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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

End Class
