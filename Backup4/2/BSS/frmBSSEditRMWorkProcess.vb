Imports Telerik.WinControls

Public Class FrmBSSEditRMWorkProcess
    Private Sub FrmBSSEditRMWorkProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtTrayNo.Text = "" Then
            RadMessageBox.Show("Tray no. cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txtTrayNo.Select()
            Exit Sub
        End If
        If RadMessageBox.Show("Are you sure you want to update this item?",
                                "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Slipknot.addParameter("RMID", Convert.ToInt32(txtRMID.Text))
            Slipknot.addParameter("SetTime", rtpTime.Value)
            Slipknot.addParameter("TrayNo", Convert.ToString(txtTrayNo.Text))

            Slipknot.dbAED("SP_BSSUpdateRMWorkProcessbyID")

            FrmRMWorkProcess.FetchRMWorkProcessbyPOSPID()
            Me.Close()
        End If

    End Sub
End Class
