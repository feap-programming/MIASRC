Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmBOMRemarks
    Private Sub FrmBOMRemarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        gvData.Columns.Add(fldId)

        Dim fldTableName As New GridViewTextBoxColumn("TABLE NAME")
        fldTableName.FieldName = "fldTableName"
        fldTableName.IsVisible = False
        fldTableName.ReadOnly = True
        gvData.Columns.Add(fldTableName)

        Dim fldProcess As New GridViewTextBoxColumn("PROCESS")
        fldProcess.FieldName = "fldProcess"
        fldProcess.Width = 200
        fldProcess.ReadOnly = True
        gvData.Columns.Add(fldProcess)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 200
        fldItemCode.ReadOnly = True
        gvData.Columns.Add(fldItemCode)

        Dim fldClass As New GridViewDecimalColumn("CLASS")
        fldClass.FieldName = "fldClass"
        fldClass.IsVisible = False
        fldClass.ReadOnly = True
        gvData.Columns.Add(fldClass)

        Dim fldProcessPriority As New GridViewDecimalColumn("PROCESS PRIORITY")
        fldProcessPriority.FieldName = "fldProcessPriority"
        fldProcessPriority.IsVisible = False
        fldProcessPriority.ReadOnly = True
        gvData.Columns.Add(fldProcessPriority)

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS")
        fldRemarks.FieldName = "fldRemarks"
        fldRemarks.Width = 200
        gvData.Columns.Add(fldRemarks)

        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        'gvData.ShowGroupPanel = True
        gvData.MultiSelect = False
        gvData.EnableSorting = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False

        gvData.TableElement.RowHeight = 25

        Dim whseDescriptor As New GroupDescriptor()
        whseDescriptor.GroupNames.Add("fldProcess", ListSortDirection.Ascending)
        gvData.GroupDescriptors.Add(whseDescriptor)

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private myData As DataTable

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        Slipknot.addParameter("parTitleId", txtTitleId.Text)
        Slipknot.addParameter("parSubContentId", txtSubContentId.Text)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        myData = Slipknot.dbSelect("SP_SelectBOMReportFinalForRemarks")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmBOMRemarks_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting

        If e.CellElement.ColumnInfo.HeaderText = "ITEM CODE" Then
            If Convert.ToString(e.CellElement.RowInfo.Cells("fldClass").Value) = "0" Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
            Else
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            End If
        End If

    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click

        Dim id As String
        Dim remarks As String
        Dim tableName As String

        For Each row As GridViewRowInfo In gvData.Rows

            id = Convert.ToString(row.Cells("fldId").Value)
            remarks = Convert.ToString(row.Cells("fldRemarks").Value)
            tableName = Convert.ToString(row.Cells("fldTableName").Value)

            Slipknot.addParameter("parId", id)
            Slipknot.addParameter("parRemarks", remarks)
            Slipknot.addParameter("parTableName", tableName)

            Slipknot.dbAED("SP_UpdateBOMReportFinalForRemarks")

        Next

        RadMessageBox.Show("Operation Completed!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub
End Class
