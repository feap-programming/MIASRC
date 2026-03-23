Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmDeletePassword
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim CurrUser As String = globalVariables.currentUser(1)
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            confirmDelete()
        Else

        End If
    End Sub

    Private Sub confirmDelete()

        Maria.AddMySqlParameters("parPassword", txtPassword.Text)
        Maria.AddMySqlParameters("parLine", globalVariables.parLine)
        Maria.AddMySqlParameters("parModelName", globalVariables.parModel)
        Dim confirm As DataTable = Maria.SPSelect("SP_SelectDeletePassword")

        If confirm.Rows.Count > 0 And CurrUser = globalVariables.SRCAddedBy Then
            Maria.AddMySqlParameters("parID", globalVariables.parDRID)
            Maria.SPADE("SP_SRCDailyReportDeleteRecord")
            RadMessageBox.Show("Item Deleted")
            Me.Close()

        ElseIf confirm.Rows.Count < 1 And CurrUser = globalVariables.SRCAddedBy Then
            MessageBox.Show("Wrong Password! Try Again")
            txtPassword.Clear()
        Else
            MessageBox.Show("Not Allowed! You cannot delete what you didn't add!")
            txtPassword.Clear()
        End If
    End Sub
End Class
