Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmChangePassword

    Private Sub FrmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        Me.Text = "Change Password - " & txtUsername.Text
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = String.Empty Then
            lblPasswordMeter.Visible = False
        Else
            lblPasswordMeter.Visible = True
        End If

        If Slipknot.passwordMeter(txtPassword.Text) = True Then
            lblPasswordMeter.BackColor = Color.Green
            lblPasswordMeter.Text = "Strong"
            panelPassword.Visible = True
        Else
            lblPasswordMeter.BackColor = Color.Red
            lblPasswordMeter.Text = "Weak"
            panelPassword.Visible = False
            panelConfirmPassword.Visible = False
        End If

        checkPasswordMatch()
    End Sub



    Private Sub checkPasswordMatch()

        Dim Match = String.Compare(txtPassword.Text, txtConfirmPassword.Text, ignoreCase:=False)

        If Match <> 0 Then
            panelConfirmPassword.Visible = False
        Else
            If lblPasswordMeter.Text = "Strong" Then
                panelConfirmPassword.Visible = True
            End If
        End If

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If txtPassword.Text = String.Empty Then
            RadMessageBox.Show("Password cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Dim Match = String.Compare(txtPassword.Text, txtConfirmPassword.Text, ignoreCase:=False)

        If Not Match = 0 Then
            RadMessageBox.Show("The same password should be entered in both fields. Please re-enter the password correctly.", "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else

            If lblPasswordMeter.Text <> "Strong" Then
                RadMessageBox.Show("Password should be strong", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Else

                Slipknot.addParameter("parUsername", txtUsername.Text)
                Slipknot.addParameter("parPassword", Slipknot.getMD5Hash(txtPassword.Text))

                If Slipknot.dbAED("SP_ChangePassword") Then
                    Me.Close()
                    RadMessageBox.Show("Password changed successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                End If

            End If

        End If

    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        checkPasswordMatch()
    End Sub
End Class
