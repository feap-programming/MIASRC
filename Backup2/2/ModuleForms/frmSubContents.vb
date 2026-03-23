Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmSubContents
    Private Sub FrmSubContents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadBOMTitle()
        readyGrid()
    End Sub

    Private Sub FrmSubContents_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldBOMTitleId As New GridViewTextBoxColumn("BOM TITLE ID")
        fldBOMTitleId.FieldName = "fldBOMTitleId"
        fldBOMTitleId.IsVisible = False
        gvData.Columns.Add(fldBOMTitleId)

        Dim fldTitle As New GridViewTextBoxColumn("BOM TITLE")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 350
        gvData.Columns.Add(fldTitle)

        Dim fldSubContentLabel As New GridViewTextBoxColumn("SUB CONTENT LABEL")
        fldSubContentLabel.FieldName = "fldSubContentLabel"
        fldSubContentLabel.Width = 400
        gvData.Columns.Add(fldSubContentLabel)

        Dim fldPageNo As New GridViewDecimalColumn("PAGE NO.")
        fldPageNo.FieldName = "fldPageNo"
        fldPageNo.Width = 70
        gvData.Columns.Add(fldPageNo)

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

    Private Sub loadBOMTitle()

        Dim dtTitle As DataTable = Slipknot.dbSelect("SP_SelectAllItemBOMTitle")

        Dim fldTitle As New GridViewTextBoxColumn("BOM TITLE")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 300
        mcbBOMTitle.MultiColumnComboBoxElement.Columns.Add(fldTitle)

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        mcbBOMTitle.MultiColumnComboBoxElement.Columns.Add(fldId)

        mcbBOMTitle.DataSource = dtTitle
        mcbBOMTitle.ValueMember = "fldTitle"
        mcbBOMTitle.DisplayMember = "fldTitle"
        mcbBOMTitle.MultiColumnComboBoxElement.DropDownWidth = 350

        mcbBOMTitle.AutoFilter = True
        mcbBOMTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim title As New FilterDescriptor()
        title.PropertyName = "fldTitle"
        title.Operator = FilterOperator.Contains
        mcbBOMTitle.EditorControl.MasterTemplate.FilterDescriptors.Add(title)

    End Sub

    Private myData As DataTable
    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        myData = Slipknot.dbSelect("SP_SelectAllBOMSubContents")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If mcbBOMTitle.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select BOM title properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If txtSubContentLabel.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Sub content label cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If sePageNo.Value = 0 Then
            RadMessageBox.Show("Invalid page number", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parBOMTitleId", mcbBOMTitle.EditorControl.CurrentRow.Cells("fldId").Value)
        Slipknot.addParameter("parSubContentLabel", txtSubContentLabel.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPageNo", sePageNo.Value)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertBOMSubContent") Then
            If bwLoadData.IsBusy = False Then
                txtSubContentLabel.Clear()
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("parIdArray", id)
        Slipknot.dbAED("SP_DeleteBOMSubContents")

        Slipknot.addParameter("parSubContentId", id)
        Slipknot.dbAED("SP_DeleteBOMContentsBySubId")

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
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("It will also delete all child record under this item, are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub cbbDetails_Click(sender As Object, e As EventArgs) Handles cbbDetails.Click
        If Slipknot.IsFormOpen(FrmBOMContents) Then
            FrmBOMContents.Focus()
        Else
            FrmBOMContents.gvData.FilterDescriptors.Clear()

            Dim filterTitle As New FilterDescriptor
            filterTitle.PropertyName = "fldTitle"
            filterTitle.[Operator] = FilterOperator.Contains
            filterTitle.Value = gvData.CurrentRow.Cells("fldTitle").Value
            filterTitle.IsFilterEditor = True
            FrmBOMContents.gvData.FilterDescriptors.Add(filterTitle)

            Dim filterSubContent As New FilterDescriptor
            filterSubContent.PropertyName = "fldSubContentLabel"
            filterSubContent.[Operator] = FilterOperator.Contains
            filterSubContent.Value = gvData.CurrentRow.Cells("fldSubContentLabel").Value
            filterSubContent.IsFilterEditor = True
            FrmBOMContents.gvData.FilterDescriptors.Add(filterSubContent)

            FrmBOMContents.MdiParent = frmBase
            FrmBOMContents.Show()
        End If
    End Sub

    Private Sub cbbConstractNow_Click(sender As Object, e As EventArgs) Handles cbbConstractNow.Click

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to constract BOM now? It will overwrite the existing data which constracted last time, do you want to continue?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

                Dim titleId As String = Convert.ToString(gvData.CurrentRow.Cells("fldBOMTitleId").Value)
                Dim subContentId As String = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)

                test.constractItemBOM(titleId, subContentId)

            End If
        End If

    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If Slipknot.IsFormOpen(FrmEditBOMSubContents) Then
            FrmEditBOMSubContents.Focus()
        Else
            FrmEditBOMSubContents.txtID.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
            FrmEditBOMSubContents.Show(Me)
        End If
    End Sub

    Private Sub cbbPreviewBOM_Click(sender As Object, e As EventArgs) Handles cbbPreviewBOM.Click

        If gvData.SelectedRows.Count > 0 Then

            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

            gvData.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1

                Dim titleId As String = Convert.ToString(rows(i).Cells("fldBOMTitleId").Value)
                Dim subContentId As String = Convert.ToString(rows(i).Cells("fldId").Value)

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Dim dtBOMHeader As DataTable = Slipknot.dbSelect("SP_SelectBOMReportHeader")

                Dim counter As Integer = 1

                For Each rowH As DataRow In dtBOMHeader.Rows

                    Slipknot.addReportParameter("parFG" & counter, Convert.ToString(rowH.Item("fldItemCode")))
                    Slipknot.addReportParameter("parBC" & counter, Convert.ToString(rowH.Item("fldModelCode")))

                    counter = counter + 1

                Next

                Slipknot.addReportParameter("parTitleId", titleId)
                Slipknot.addReportParameter("parSubContentId", subContentId)

                reportType = 0

                Dim frm As New FrmReport
                frm.Show()

            Next

            'For Each row As GridViewRowInfo In gvData.Rows

            '    Dim titleId As String = Convert.ToString(row.Cells("fldBOMTitleId").Value)
            '    Dim subContentId As String = Convert.ToString(row.Cells("fldId").Value)

            '    Slipknot.addParameter("parTitleId", titleId)
            '    Slipknot.addParameter("parSubContentId", subContentId)
            '    Dim dtBOMHeader As DataTable = Slipknot.dbSelect("SP_SelectBOMReportHeader")

            '    Dim counter As Integer = 1

            '    For Each rowH As DataRow In dtBOMHeader.Rows

            '        Slipknot.addReportParameter("parFG" & counter, Convert.ToString(rowH.Item("fldItemCode")))
            '        Slipknot.addReportParameter("parBC" & counter, Convert.ToString(rowH.Item("fldModelCode")))

            '        counter = counter + 1

            '    Next

            '    Slipknot.addReportParameter("parTitleId", titleId)
            '    Slipknot.addReportParameter("parSubContentId", subContentId)

            '    reportType = 0

            '    Dim frm As New FrmReport
            '    frm.Show()

            'Next




        End If

    End Sub
End Class
