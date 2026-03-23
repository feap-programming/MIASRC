Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmBSSOtherDetails
    Private Sub FrmBSSOtherDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readOtherDetails()
    End Sub
    Private Sub FrmBSSOtherDetails_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub
    Private Sub readOtherDetails()
        Dim fldRemarks As New GridViewTextBoxColumn("Remarks") With {
            .FieldName = "fldRemarks",
            .Width = 250,
            .ReadOnly = True
        }
        gvOtherDetails.Columns.Add(fldRemarks)


        gvOtherDetails.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvOtherDetails.AllowAddNewRow = False
        gvOtherDetails.ShowFilteringRow = False
        gvOtherDetails.ShowGroupPanel = False
        gvOtherDetails.EnableSorting = False
        gvOtherDetails.AllowColumnReorder = False
        gvOtherDetails.AllowRowReorder = False

    End Sub

    Private Sub btnAddRM_Click(sender As Object, e As EventArgs) Handles btnAddRM.Click
        If txtOtherDetails.Text = "" Then
            RadMessageBox.Show("Other Details cannot be empty", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        Else
            gvOtherDetails.Rows.Add(Convert.ToString(txtOtherDetails.Text))
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If gvOtherDetails.Rows.Count > 0 Then
            For Each row As GridViewRowInfo In gvOtherDetails.Rows

            Next
        End If
    End Sub
End Class
