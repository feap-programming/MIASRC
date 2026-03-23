Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports System.ComponentModel
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI.Export

Public Class ucLineGroup

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable

    Private Sub ucLineGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeThemeUC(Me)

        Me.numYear.Value = Year(Date.Today)
        Me.drpMonth.SelectedIndex = Me.drpMonth.FindStringExact(MonthName(Month(Date.Today)))
        Me.LoadLineCode(Me.drpLineCode)

        Me.SetUpColumns(Me.gvData)

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Me.myDB.SPSelect("SP_P_SelectAllLineGroup")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
        leCountRec.Text = gvData.Rows.Count
    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldID").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("IDArray", id)
        Slipknot.dbAED("SP_P_DeleteLineGroup")
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

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If Me.drpLineCode.Text <> "NOT IN LINE" Then

            Dim year As Integer = Me.numYear.Value
            Dim month As Integer = Me.drpMonth.SelectedIndex + 1
            Dim lineSharingCode As String = Me.drpLineCode.SelectedValue
            Dim actualGroup As Integer = Me.numActualGroup.Value

            Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to save record/s?", "Saving Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.myDB.AddMySqlParameters("_year", year)
                Me.myDB.AddMySqlParameters("_month", month)
                Me.myDB.AddMySqlParameters("lineSharingCode", lineSharingCode)
                Me.myDB.AddMySqlParameters("actualGroup", actualGroup)
                Me.myDB.AddMySqlParameters("addedBy", currentUser.Item("fldUsername"))
                Me.myDB.SPADE("SP_P_InsertLineGroup")

                RadMessageBox.Show(Me, "Line Group successfully added.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If

        Else

            RadMessageBox.Show(Me, "Please select SRC/BSS line.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click

        Try
            Dim editForm As New FrmEditLineGroup
            editForm.ShowDialog(Me.gvData.CurrentRow.Cells("fldID").Value)
        Catch ex As System.Reflection.AmbiguousMatchException
            RadMessageBox.Show(Me, "Please select proper row.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to delete record/s?", "Deleting Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            If gvData.SelectedRows.Count > 0 Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub cbCopy_Click(sender As Object, e As EventArgs) Handles cbCopy.Click
        Dim editForm As New FrmCopyToLineGroup
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

    Private Sub cbImport_Click(sender As Object, e As EventArgs) Handles cbImport.Click
        Dim editForm As New FrmImportLineGroup
        editForm.ShowDialog(Me)
    End Sub

    Private Sub cbPreview_Click(sender As Object, e As EventArgs) Handles cbPreview.Click
        Dim previewForm As New FrmCapacityPlanningPreview
        previewForm.ShowDialog("Line Group Preview")
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

    Private Sub LoadLineCode(drpLineCode As RadDropDownList)
        drpLineCode.DataSource = Me.myDB.SPSelect("SP_P_SelectAllLineGroupSharingGrpd")
        drpLineCode.ValueMember = "fldSharingCode"
        drpLineCode.DisplayMember = "fldSharingCode"
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim id As New GridViewDecimalColumn("ID")
        id.FieldName = "fldID"
        id.Width = 80
        id.TextAlignment = ContentAlignment.MiddleCenter
        id.IsVisible = False
        gridView.Columns.Add(id)

        Dim year As New GridViewDecimalColumn("Year *")
        year.FieldName = "fldYear"
        year.Width = 100
        year.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(year)

        Dim month As New GridViewDecimalColumn("Month")
        month.FieldName = "fldMonth"
        month.Width = 100
        month.TextAlignment = ContentAlignment.MiddleCenter
        month.IsVisible = False
        gridView.Columns.Add(month)

        Dim monthName As New GridViewTextBoxColumn("Month *")
        monthName.FieldName = "fldMonthName"
        monthName.Width = 150
        monthName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(monthName)

        Dim lineCode As New GridViewTextBoxColumn("Line Sh. Code *")
        lineCode.FieldName = "fldLineSharingCode"
        lineCode.Width = 120
        lineCode.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(lineCode)

        Dim actualGroup As New GridViewDecimalColumn("Actual Group *")
        actualGroup.FieldName = "fldActualGroup"
        actualGroup.Width = 120
        actualGroup.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(actualGroup)

        Dim dateAdded As New GridViewDateTimeColumn("Date Added")
        dateAdded.FieldName = "fldDateAdded"
        dateAdded.Width = 150
        dateAdded.Format = DateTimePickerFormat.Custom
        dateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(dateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim addedBy As New GridViewTextBoxColumn("Added By")
        addedBy.FieldName = "fldAddedBy"
        addedBy.Width = 150
        addedBy.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(addedBy)

        Dim yearDesc As New GroupDescriptor()
        yearDesc.GroupNames.Add("fldYear", ListSortDirection.Descending)
        gridView.GroupDescriptors.Add(yearDesc)

        Dim monthDesc As New GroupDescriptor()
        monthDesc.GroupNames.Add("fldMonth", ListSortDirection.Ascending)
        monthDesc.GroupNames.Add("fldMonthName", ListSortDirection.Ascending)
        gridView.GroupDescriptors.Add(monthDesc)

    End Sub

End Class
