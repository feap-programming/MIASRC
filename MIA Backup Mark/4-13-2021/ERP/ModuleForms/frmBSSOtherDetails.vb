Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmBSSOtherDetails
    Dim drCountme As DataRow = Nothing
    Dim CheckMe As Int16
    Private Sub FrmBSSOtherDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        ReadRemars()
    End Sub
    Private Sub ReadRemars()
        Dim fldItemCode As New GridViewTextBoxColumn("Remarks") With {
            .FieldName = "fldRemarks",
            .Width = 300,
            .ReadOnly = True
        }
        gvRemarks.Columns.Add(fldItemCode)

        gvRemarks.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvRemarks.AllowAddNewRow = False
        gvRemarks.ShowFilteringRow = False
        gvRemarks.ShowGroupPanel = False
        gvRemarks.EnableSorting = False
        gvRemarks.AllowColumnReorder = False
        gvRemarks.AllowRowReorder = False

    End Sub

    Private Sub btnAddRM_Click(sender As Object, e As EventArgs) Handles btnAddRM.Click
        If txtRemarks.Text = String.Empty Then
            RadMessageBox.Show("No Remarks found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        Else
            gvRemarks.Rows.Add(txtRemarks.Text)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If gvRemarks.Rows.Count > 0 Then
            If CheckMe >= 1 Then
                Slipknot.addParameter("POSPID", txtPOSPID.Text)
                Slipknot.dbAED("SP_DeleteBSSOtherDetailsbyPOSPID")

                For Each row As GridViewRowInfo In gvRemarks.Rows
                    Slipknot.addParameter("MainID", txtMainID.Text)
                    Slipknot.addParameter("POSPID", txtPOSPID.Text)
                    Slipknot.addParameter("Remarks", Convert.ToString(row.Cells("fldRemarks").Value).TrimStart.TrimStart)
                    Slipknot.dbAED("SP_InsertBSSOtherDetails")
                Next
            Else
                For Each row As GridViewRowInfo In gvRemarks.Rows
                    Slipknot.addParameter("MainID", txtMainID.Text)
                    Slipknot.addParameter("POSPID", txtPOSPID.Text)
                    Slipknot.addParameter("Remarks", Convert.ToString(row.Cells("fldRemarks").Value).TrimStart.TrimStart)
                    Slipknot.dbAED("SP_InsertBSSOtherDetails")
                Next
            End If
            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            RadMessageBox.Show("No data found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub FrmBSSOtherDetails_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CheckifExist()
    End Sub

    Private Sub CheckifExist()
        Slipknot.addParameter("POSPID", txtPOSPID.Text)
        Dim dtCount As DataTable = Slipknot.dbSelect("SP_CountBSSOtherDetails")
        drCountme = dtCount.Rows(0)
        CheckMe = Convert.ToInt16(drCountme.Item("CountMe"))
        If (CheckMe >= 1) Then
            Slipknot.addParameter("POSPID", txtPOSPID.Text)
            gvRemarks.DataSource = Slipknot.dbSelect("SP_SelectBSSOtherDetailsbyPOSPID")
        End If
    End Sub
End Class
