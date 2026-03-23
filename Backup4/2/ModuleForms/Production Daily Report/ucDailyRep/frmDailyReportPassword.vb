Imports Telerik.WinControls
Imports FEAPNS.DataAccess

Public Class FrmDailyReportPassword
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim CurrUser As String = globalVariables.currentUser(1)
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        confirmDelete()
    End Sub

    Private Sub confirmDelete()
        Maria.AddMySqlParameters("parPassword", txtPassword.Text)
        Maria.AddMySqlParameters("parLine", globalVariables.parLine)
        Maria.AddMySqlParameters("parModelName", globalVariables.parModel)
        Dim confirm As DataTable = Maria.SPSelect("SP_SelectDeletePassword")

        If confirm.Rows.Count > 0 And CurrUser = globalVariables.SRCAddedBy Then
            Maria.AddMySqlParameters("parID", globalVariables.parDRID)
            Maria.SPADE("SP_SRCDailyReportDeleteRecord")
            FrmSRCDailyReportNewV2.MdiParent = frmBase
            FrmSRCDailyReportNewV2.Show()
            txtPassword.Clear()
            Me.Close()

        ElseIf confirm.Rows.Count < 1 And CurrUser = globalVariables.SRCAddedBy Then
            RadMessageBox.Show("Wrong Password! Try Again", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
            txtPassword.Clear()
        Else
            RadMessageBox.Show("Not Allowed! You cannot open this record!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
            txtPassword.Clear()
        End If

    End Sub

End Class
