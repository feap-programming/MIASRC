Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmClearDialog

    Private Sub btnOkOnly_Click(sender As Object, e As EventArgs) Handles btnClearOkOnly.Click
        txtResult.Text = "OkOnly"
        Me.Close()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtResult.Text = "ClearAll"
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtResult.Text = "Cancel"
        Me.Close()
    End Sub

    Private Sub FrmClearDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        btnClearAll.Focus()
    End Sub
End Class
