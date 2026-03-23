Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmBOMProvider
    Private Sub frmItemBOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        txtTitle.Focus()

        dtpEstDate.Format = DateTimePickerFormat.Custom
        dtpEstDate.CustomFormat = "MMM dd, yyyy"
        dtpEstDate.Value = Today

        dtpRevDate.Format = DateTimePickerFormat.Custom
        dtpRevDate.CustomFormat = "MMM dd, yyyy"
        dtpRevDate.Value = Today

        dtpImplemDate.Format = DateTimePickerFormat.Custom
        dtpImplemDate.CustomFormat = "MMM dd, yyyy"
        dtpImplemDate.Value = Today

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldTitle As New GridViewTextBoxColumn("TITLE")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 350
        gvData.Columns.Add(fldTitle)

        Dim fldDocumentNo As New GridViewTextBoxColumn("DOCUMENT NO.")
        fldDocumentNo.FieldName = "fldDocumentNo"
        fldDocumentNo.Width = 140
        gvData.Columns.Add(fldDocumentNo)

        Dim fldReferenceNo As New GridViewTextBoxColumn("REFERENCE NO.")
        fldReferenceNo.FieldName = "fldReferenceNo"
        fldReferenceNo.Width = 110
        gvData.Columns.Add(fldReferenceNo)

        Dim fldEstDate As New GridViewDateTimeColumn("ESTABLISHED DATE")
        fldEstDate.FieldName = "fldEstDate"
        fldEstDate.Width = 140
        fldEstDate.Format = DateTimePickerFormat.Custom
        fldEstDate.CustomFormat = "MMM dd, yyyy"
        gvData.Columns.Add(fldEstDate)
        gvData.Columns("fldEstDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRevDate As New GridViewDateTimeColumn("REVISED DATE")
        fldRevDate.FieldName = "fldRevDate"
        fldRevDate.Width = 130
        fldRevDate.Format = DateTimePickerFormat.Custom
        fldRevDate.CustomFormat = "MMM dd, yyyy"
        gvData.Columns.Add(fldRevDate)
        gvData.Columns("fldRevDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldImplemDate As New GridViewDateTimeColumn("IMPLEMENTATION DATE")
        fldImplemDate.FieldName = "fldImplemDate"
        fldImplemDate.Width = 180
        fldImplemDate.Format = DateTimePickerFormat.Custom
        fldImplemDate.CustomFormat = "MMM dd, yyyy"
        gvData.Columns.Add(fldImplemDate)
        gvData.Columns("fldImplemDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldPreparedBy As New GridViewTextBoxColumn("PREPARED BY")
        fldPreparedBy.FieldName = "fldPreparedBy"
        fldPreparedBy.Width = 130
        gvData.Columns.Add(fldPreparedBy)

        Dim fldCheckedBy As New GridViewTextBoxColumn("CHECKED BY")
        fldCheckedBy.FieldName = "fldCheckedBy"
        fldCheckedBy.Width = 130
        gvData.Columns.Add(fldCheckedBy)

        Dim fldApprovedBy As New GridViewTextBoxColumn("APPROVED BY")
        fldApprovedBy.FieldName = "fldApprovedBy"
        fldApprovedBy.Width = 130
        gvData.Columns.Add(fldApprovedBy)

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
        gvData.MultiSelect = False

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

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If txtTitle.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Title cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parTitle", txtTitle.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parDocumentNo", txtDocuNo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parReferenceNo", txtRefNo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parEstDate", dtpEstDate.Value)
        Slipknot.addParameter("parRevDate", dtpRevDate.Value)
        Slipknot.addParameter("parImplemDate", dtpImplemDate.Value)
        Slipknot.addParameter("parPreparedBy", txtPreparedBy.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parCheckedBy", txtCheckedBy.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parApprovedBy", txtApprovedBy.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertItemBOMTitle") Then
            txtTitle.Clear()
            txtDocuNo.Clear()
            txtRefNo.Clear()
            txtPreparedBy.Clear()
            txtCheckedBy.Clear()
            txtApprovedBy.Clear()

            txtTitle.Focus()

            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private myData As DataTable
    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        myData = Slipknot.dbSelect("SP_SelectAllItemBOMTitle")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub frmItemBOM_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbSubContents_Click(sender As Object, e As EventArgs) Handles cbbOpen.Click
        'If Slipknot.IsFormOpen(FrmSubContents) Then
        '    FrmSubContents.Focus()
        'Else
        '    FrmSubContents.gvData.FilterDescriptors.Clear()

        '    Dim filter As New FilterDescriptor
        '    filter.PropertyName = "fldTitle"
        '    filter.[Operator] = FilterOperator.Contains
        '    filter.Value = gvData.CurrentRow.Cells("fldTitle").Value
        '    filter.IsFilterEditor = True
        '    FrmSubContents.gvData.FilterDescriptors.Add(filter)

        '    FrmSubContents.MdiParent = frmBase
        '    FrmSubContents.Show()
        'End If

        If gvData.SelectedRows.Count > 0 Then
            If Slipknot.IsFormOpen(FrmBOMDetails) Then
                FrmBOMDetails.Focus()
            Else
                FrmBOMDetails.txtId.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmBOMDetails.Text = "BOM Details - " & Convert.ToString(gvData.CurrentRow.Cells("fldTitle").Value)
                FrmBOMDetails.Show(Me)
            End If
        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to delete selected BOM Title?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                Slipknot.addParameter("parIdArray", gvData.CurrentRow.Cells("fldId").Value)
                If Slipknot.dbAED("SP_DeleteBOMTitle") Then
                    bwLoadData.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If gvData.SelectedRows.Count > 0 Then
            If Slipknot.IsFormOpen(FrmEditBOMItem) Then
                FrmEditBOMItem.Focus()
            Else
                FrmEditBOMItem.txtID.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmEditBOMItem.Show(Me)
            End If
        End If
    End Sub
End Class
