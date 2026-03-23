Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class frmConfirmCode
    Private Sub FrmAdminRights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        confirmCode = False

        txtConfirmCode.Clear()
        txtConfirmCode.Focus()
    End Sub

    Private Sub txtConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim mySettingsRow As DataTable = Slipknot.dbSelect("SP_SelectSettings")

        If mySettingsRow.Rows.Count > 0 Then

            If Convert.ToString(mySettingsRow.Rows(0).Item("fldConfirmationCode")) = txtConfirmCode.Text Then
                txtConfirmCode.Text = ""
                confirmCode = True
                Me.Close()
            Else
                RadMessageBox.Show("INVALID CODE", "ERROR", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                txtConfirmCode.Focus()
                txtConfirmCode.SelectAll()
            End If

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
