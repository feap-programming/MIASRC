Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmDeletePassword
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
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

        If globalVariables.assyStatus = "DELETE RECORD SRC" Then
            If confirm.Rows.Count > 0 And CurrUser = globalVariables.SRCAddedBy Then
                Maria.AddMySqlParameters("parID", globalVariables.parDRID)
                Maria.SPADE("SP_SRCDailyReportDeleteRecord")
                RadMessageBox.Show("Item Deleted", "INFO", MessageBoxButtons.OK, RadMessageIcon.Info)
                txtPassword.Clear()
                Me.Close()

            ElseIf confirm.Rows.Count < 1 And CurrUser = globalVariables.SRCAddedBy Then
                RadMessageBox.Show("Wrong Password! Try Again", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
                txtPassword.Clear()
            Else
                RadMessageBox.Show("Not Allowed! You cannot delete what you didn't add!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
                txtPassword.Clear()
            End If
        ElseIf globalVariables.assyStatus = "DELETE RECORD AT" Then
            If confirm.Rows.Count > 0 And CurrUser = globalVariables.SRCAddedBy Then
                Maria.AddMySqlParameters("parID", globalVariables.parDRID)
                Maria.SPADE("SP_SRCDailyReportDeleteATRecord")
                RadMessageBox.Show("Item Deleted", "INFO", MessageBoxButtons.OK, RadMessageIcon.Info)
                txtPassword.Clear()
                Me.Close()

            ElseIf confirm.Rows.Count < 1 And CurrUser = globalVariables.SRCAddedBy Then
                RadMessageBox.Show("Wrong Password! Try Again", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
                txtPassword.Clear()
            Else
                RadMessageBox.Show("Not Allowed! You cannot delete what you didn't add!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
                txtPassword.Clear()
            End If
        Else
            If confirm.Rows.Count > 0 And CurrUser = globalVariables.SRCAddedBy Then
                globalVariables.currentRgv.Rows.Remove(globalVariables.currentRgv.SelectedRows(globalVariables.rgvAssyRowIndex))
                RadMessageBox.Show("Record Deleted", "INFO", MessageBoxButtons.OK, RadMessageIcon.Info)
                txtPassword.Clear()
                Me.Close()
            ElseIf confirm.Rows.Count < 1 And CurrUser = globalVariables.SRCAddedBy Then
                MessageBox.Show("Wrong Password! Try Again")
                txtPassword.Clear()
            Else
                MessageBox.Show("Not Allowed! You cannot delete what you didn't add!")
                txtPassword.Clear()
            End If


        End If


    End Sub
End Class
