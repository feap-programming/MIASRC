Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class frmGLAccounts

    Private myData As DataTable
    Private Sub frmGLAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldAccountCode As New GridViewTextBoxColumn("Account Code")
        fldAccountCode.FieldName = "fldAccountCode"
        fldAccountCode.Width = 150
        gvData.Columns.Add(fldAccountCode)

        Dim fldAccountTitle As New GridViewTextBoxColumn("Account Title")
        fldAccountTitle.FieldName = "fldAccountTitle"
        fldAccountTitle.Width = 300
        gvData.Columns.Add(fldAccountTitle)

        Dim fldClass As New GridViewTextBoxColumn("Class")
        fldClass.FieldName = "fldClass"
        fldClass.Width = 50
        gvData.Columns.Add(fldClass)

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

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
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

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectAllGLAccounts")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub frmGLAccounts_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        'If BulletForMyValentine.isRW("fldMDWarehousing") = False Then
        '    Slapshock.NoAccessToFunctionMessage()

        '    Exit Sub
        'End If

        If txtAccountCode.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Invalid Account Code", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtAccountCode.Focus()
            Exit Sub
        End If

        If txtAccountTitle.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Invalid Account Title", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtAccountTitle.Focus()
            Exit Sub
        End If

        Slipknot.addParameter("parAccountCode", txtAccountCode.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parAccountTitle", txtAccountTitle.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parClass", ddClass.Text)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertGLAccounts") Then

            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If

        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        'If BulletForMyValentine.isRW("fldMDWarehousing") = False Then
        '    Slapshock.NoAccessToFunctionMessage()

        '    Exit Sub
        'End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwDelete.IsBusy = False Then
                    bwDelete.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub bwDelete_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDelete.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)
            Dim percent As Double

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwDelete.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("parIdArray", id)
        Slipknot.dbAED("SP_DeleteGLAccounts")
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

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub cbbImport_Click(sender As Object, e As EventArgs) Handles cbbImport.Click

        If Slipknot.IsFormOpen(frmImportWarehousing) Then
            frmImportWarehousing.Focus()
        Else
            If BulletForMyValentine.isRW("fldMDWarehousing") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            frmImportWarehousing.Show(Me)
        End If

    End Sub
End Class
