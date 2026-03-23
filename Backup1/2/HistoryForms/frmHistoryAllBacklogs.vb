Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmHistoryAllBacklogs

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtAllBacklog As DataTable

    Private myData As DataTable

    Private Sub frmHistoryAllBacklogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        If Not bwLoadData.CancellationPending Then

            dtAllBacklog = Slipknot.dbSelect("SP_P_SelectAllBacklog")
            myData = dtAllBacklog

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

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
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
        Slipknot.dbAED("SP_P_DeleteBacklog")
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
                Dim editForm As New FrmEditBacklog
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
                Dim historyForm As New frmHistoryBacklog
                historyForm.ShowDialog(id)
            End If

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldID As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldID)

        Dim fldEffectivityDate As New GridViewDateTimeColumn("EFFECTIVITY DATE") With {
            .FieldName = "fldEffectivityDate",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldEffectivityDate)
        gridView.Columns("fldEffectivityDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomerID As New GridViewDecimalColumn("CUST ID") With {
            .FieldName = "fldCustomerID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldCustomerID)

        Dim fldCustomer As New GridViewTextBoxColumn("CUST CODE") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldCustomer)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 250,
            .TextAlignment = ContentAlignment.MiddleLeft,
            .IsVisible = True
        }
        gridView.Columns.Add(fldPartName)

        Dim fldQuantity As New GridViewTextBoxColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gridView.Columns.Add(fldQuantity)
        gridView.Columns("fldQuantity").FormatString = "{0:N0}"

    End Sub

End Class
