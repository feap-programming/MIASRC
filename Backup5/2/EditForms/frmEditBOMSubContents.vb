Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmEditBOMSubContents

    Private origSubLabel As String
    Private origPageNo As Int16
    Private Sub FrmEditBOMSubContents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadData()
    End Sub

    Private Sub loadData()

        Slipknot.addParameter("parId", txtID.Text)
        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectBOMSubByID")

        If dt.Rows.Count > 0 Then

            origSubLabel = Convert.ToString(dt.Rows(0).Item("fldSubContentLabel"))
            origPageNo = Convert.ToInt32(dt.Rows(0).Item("fldPageNo"))

            txtBOMTitle.Text = Convert.ToString(dt.Rows(0).Item("bomTitle"))
            txtSubContentLabel.Text = origSubLabel
            sePageNo.Value = origPageNo

        End If

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If txtSubContentLabel.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Sub content label cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtSubContentLabel.Text = origSubLabel
            Exit Sub
        End If

        If sePageNo.Value = 0 Then
            RadMessageBox.Show("Invalid page number", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            sePageNo.Value = origPageNo
            Exit Sub
        End If

        Slipknot.addParameter("parId", txtID.Text)
        Slipknot.addParameter("parContentLabel", txtSubContentLabel.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPageNo", sePageNo.Value)

        If Slipknot.dbAED("SP_UpdateBOMSubContent") Then
            RadMessageBox.Show("Updated Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)

            origSubLabel = txtSubContentLabel.Text.TrimStart.TrimEnd
            origPageNo = sePageNo.Value
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
