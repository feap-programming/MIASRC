Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmCheckVoucher

    Private myData As DataTable
    Private Sub FrmCheckVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        readyGrid()

    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldCategory As New GridViewTextBoxColumn("Category")
        fldCategory.FieldName = "fldCategory"
        fldCategory.Width = 130
        gvData.Columns.Add(fldCategory)

        Dim fldCVNo As New GridViewTextBoxColumn("CV No.")
        fldCVNo.FieldName = "fldCVNo"
        fldCVNo.Width = 80
        gvData.Columns.Add(fldCVNo)

        Dim fldDate As New GridViewDateTimeColumn("Date")
        fldDate.FieldName = "fldDate"
        fldDate.Format = DateTimePickerFormat.Custom
        fldDate.CustomFormat = "MMM dd, yyyy"
        fldDate.Width = 100
        gvData.Columns.Add(fldDate)
        gvData.Columns("fldDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldAmountInWords As New GridViewTextBoxColumn("Received Sum")
        fldAmountInWords.FieldName = "fldAmountInWords"
        fldAmountInWords.Width = 200
        gvData.Columns.Add(fldAmountInWords)

        Dim fldCurrency As New GridViewTextBoxColumn("Currency")
        fldCurrency.FieldName = "fldCurrency"
        fldCurrency.Width = 70
        gvData.Columns.Add(fldCurrency)

        Dim fldReceivedBy As New GridViewTextBoxColumn("Received By")
        fldReceivedBy.FieldName = "fldReceivedBy"
        fldReceivedBy.Width = 130
        gvData.Columns.Add(fldReceivedBy)

        Dim fldBankName As New GridViewTextBoxColumn("Bank Name")
        fldBankName.FieldName = "fldBankName"
        fldBankName.Width = 180
        gvData.Columns.Add(fldBankName)

        Dim fldProvisionalReceiptNo As New GridViewTextBoxColumn("Provision Receipt No.")
        fldProvisionalReceiptNo.FieldName = "fldProvisionalReceiptNo"
        fldProvisionalReceiptNo.Width = 160
        gvData.Columns.Add(fldProvisionalReceiptNo)

        Dim fldPONo As New GridViewTextBoxColumn("PO No.")
        fldPONo.FieldName = "fldPONo"
        fldPONo.Width = 80
        gvData.Columns.Add(fldPONo)

        Dim fldInvNo As New GridViewTextBoxColumn("Invoice No.")
        fldInvNo.FieldName = "fldInvNo"
        fldInvNo.Width = 80
        gvData.Columns.Add(fldInvNo)

        Dim fldPreparedBy As New GridViewTextBoxColumn("Prepared By")
        fldPreparedBy.FieldName = "fldPreparedBy"
        fldPreparedBy.Width = 130
        gvData.Columns.Add(fldPreparedBy)

        Dim fldPreparedByTitle As New GridViewTextBoxColumn("Prepared By Title")
        fldPreparedByTitle.FieldName = "fldPreparedByTitle"
        fldPreparedByTitle.Width = 130
        gvData.Columns.Add(fldPreparedByTitle)

        Dim fldCheckedBy As New GridViewTextBoxColumn("Checked By")
        fldCheckedBy.FieldName = "fldCheckedBy"
        fldCheckedBy.Width = 130
        gvData.Columns.Add(fldCheckedBy)

        Dim fldCheckedByTitle As New GridViewTextBoxColumn("Checked By Title")
        fldCheckedByTitle.FieldName = "fldCheckedByTitle"
        fldCheckedByTitle.Width = 130
        gvData.Columns.Add(fldCheckedByTitle)

        Dim fldApprovedBy As New GridViewTextBoxColumn("Approved By")
        fldApprovedBy.FieldName = "fldApprovedBy"
        fldApprovedBy.Width = 130
        gvData.Columns.Add(fldApprovedBy)

        Dim fldApprovedByTitle As New GridViewTextBoxColumn("Approved By Title")
        fldApprovedByTitle.FieldName = "fldApprovedByTitle"
        fldApprovedByTitle.Width = 130
        gvData.Columns.Add(fldApprovedByTitle)

        Dim fldNotedBy As New GridViewTextBoxColumn("Noted By")
        fldNotedBy.FieldName = "fldNotedBy"
        fldNotedBy.Width = 130
        gvData.Columns.Add(fldNotedBy)

        Dim fldNotedByTitle As New GridViewTextBoxColumn("Noted By Title")
        fldNotedByTitle.FieldName = "fldNotedByTitle"
        fldNotedByTitle.Width = 130
        gvData.Columns.Add(fldNotedByTitle)

        Dim fldDateAdded As New GridViewDateTimeColumn("Date Added")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("Added By")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvData.Columns.Add(fldAddedBy)

        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If Slipknot.IsFormOpen(FrmAddCV) Then
            FrmAddCV.Focus()
        Else
            FrmAddCV.Show(Me)
        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        myData = Slipknot.dbSelect("SP_SelectAllCVMain")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmCheckVoucher_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork

        'Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        'gvData.SelectedRows.CopyTo(rows, 0)

        'Dim cvNo As String = Nothing
        'Dim percent As Double

        'For i As Integer = 0 To rows.Length - 1

        '    cvNo = cvNo & "," & Convert.ToString(rows(i).Cells("fldCVNo").Value)

        '    Threading.Thread.Sleep(delay)
        '    percent = i / rows.Length * 100
        '    bwOperation.ReportProgress(Convert.ToInt32(percent))
        'Next

        Slipknot.addParameter("parCVNo", Convert.ToString(gvData.CurrentRow.Cells("fldCVNo").Value))
        Slipknot.dbAED("SP_DeleteCVMain")

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

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        'If BulletForMyValentine.isRW("fldMDBOMMasterData") = False Then
        '    Slapshock.NoAccessToFunctionMessage()

        '    Exit Sub
        'End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub cbbEditCV_Click(sender As Object, e As EventArgs) Handles cbbEditCV.Click

        If Slipknot.IsFormOpen(FrmAddCV) Then
            FrmAddCV.Focus()
        Else

            If gvData.SelectedRows.Count > 0 Then

                FrmAddCV.Text = "Edit Check Voucher / Bank Transfer"
                FrmAddCV.txtId.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmAddCV.Show(Me)

            End If

        End If

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub miOpenCVBT_Click(sender As Object, e As EventArgs) Handles miOpenCVBT.Click

        If gvData.SelectedRows.Count > 0 Then

            reportType = 12

            publicText = Nothing

            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}

            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For counter As Integer = 0 To rows.Length - 1

                publicText = publicText & "," & Convert.ToString(rows(counter).Cells("fldId").Value)

            Next

            Slipknot.addReportParameter("parIdArray", publicText)

            Dim frm As New FrmReport
            frm.Show()

        End If

    End Sub

    Private Sub mieOpenCheque_Click(sender As Object, e As EventArgs) Handles mieOpenCheque.Click

        If gvData.SelectedRows.Count > 0 Then

            reportType = 13

            publicText = Nothing

            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}

            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For counter As Integer = 0 To rows.Length - 1

                publicText = publicText & "," & Convert.ToString(rows(counter).Cells("fldId").Value)

            Next

            Slipknot.addReportParameter("parIdArray", publicText)

            Dim frm As New FrmReport
            frm.Show()

        End If


    End Sub

    Private Sub miSummaryReport_Click(sender As Object, e As EventArgs) Handles miSummaryReport.Click

        If Slipknot.IsFormOpen(FrmGenCVBTReport) Then
            FrmGenCVBTReport.Focus()
        Else
            FrmGenCVBTReport.Show(Me)
        End If

    End Sub
End Class
