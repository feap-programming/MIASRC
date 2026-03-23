Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmCountingReference
    Private Sub FrmCountingReference_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        readyGridPerWhse()

    End Sub

    Private Sub readyGridPerWhse()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldWarehouse As New GridViewTextBoxColumn("WAREHOUSE")
        fldWarehouse.FieldName = "fldDescription"
        fldWarehouse.Width = 230
        gvData.Columns.Add(fldWarehouse)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("ITEM CODE")
        fldCustomerPartNo.FieldName = "fldItemCode"
        fldCustomerPartNo.Width = 100
        gvData.Columns.Add(fldCustomerPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 250
        gvData.Columns.Add(fldPartName)

        Dim fldQuantity As New GridViewDecimalColumn("QUANTITY")
        fldQuantity.FieldName = "fldQuantity"
        fldQuantity.Width = 120
        gvData.Columns.Add(fldQuantity)
        gvData.Columns("fldQuantity").FormatString = "{0:N2}"

        Dim fldCountingDate As New GridViewDateTimeColumn("COUNTING DATE")
        fldCountingDate.FieldName = "fldCountingDate"
        fldCountingDate.Width = 170
        fldCountingDate.Format = DateTimePickerFormat.Custom
        fldCountingDate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldCountingDate)
        gvData.Columns("fldCountingDate").FormatString = "{0:MMM dd, yyyy HH:mm}"

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

        Dim fldQuantitySum As New GridViewSummaryItem("fldQuantity", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldQuantitySum)

        gvData.SummaryRowsBottom.Add(summaryRowItem)
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

    Private myData As DataTable

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectAllCountingReference")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmCountingReference_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbExportCounting_Click(sender As Object, e As EventArgs) Handles cbbExportCounting.Click
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

    Private Sub cbbImport_Click(sender As Object, e As EventArgs) Handles cbbImport.Click
        If Slipknot.IsFormOpen(frmImportCountingReference) Then
            frmImportCountingReference.Focus()
        Else
            If BulletForMyValentine.isRW("fldModCountingReference") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportCountingReference.Show(Me)
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
        Slipknot.dbAED("SP_DeleteCountingReference")

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
        If Slipknot.IsFormOpen(frmImportCountingReference) Then
            frmImportCountingReference.Focus()
        Else
            If BulletForMyValentine.isRW("fldModCountingReference") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportCountingReference.Show(Me)
        End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwDelete.IsBusy = False Then
                    bwDelete.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub gvData_ViewCellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.ViewCellFormatting
        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)

        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            'e.CellElement.BorderTopColor = DefaultBackColor
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed
        End If
    End Sub
End Class
