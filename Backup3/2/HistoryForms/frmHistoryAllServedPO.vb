Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmHistoryAllServedPO

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtAllServedPO As DataTable

    Private myData As DataTable

    Private Sub FrmHistoryAllServedPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        If Not bwLoadData.CancellationPending Then

            dtAllServedPO = Slipknot.dbSelect("SP_P_SelectAllServedPO")
            myData = dtAllServedPO

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
        Slipknot.dbAED("SP_P_DeleteServedPO")
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

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldID As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldID)

        Dim fldInvoiceNo As New GridViewTextBoxColumn("INVOICE NO") With {
            .FieldName = "fldInvoiceNo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldInvoiceNo)

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETDFEAP)
        gridView.Columns("fldETDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETACustomer As New GridViewDateTimeColumn("ETA CUSTOMER") With {
            .FieldName = "fldETACustomer",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETACustomer)
        gridView.Columns("fldETACustomer").FormatString = "{0:MMM dd, yyyy}"

        Dim fldPONo As New GridViewTextBoxColumn("PO NO") With {
            .FieldName = "fldPONo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldPONo)

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

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY") With {
            .FieldName = "fldAddedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldAddedBy)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldDateAdded)
        gridView.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

    End Sub

End Class
