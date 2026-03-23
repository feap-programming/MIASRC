Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports MySql.Data.MySqlClient
Public Class FrmSettings
    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        txtDbHost.Text = My.Settings.setServerHost
        txtDbUser.Text = My.Settings.setDBUID
        txtDbPassword.Text = My.Settings.setDBPWD
        txtDbName.Text = My.Settings.setDBName

        Try

            Dim setting As DataTable = Slipknot.dbSelect("SP_SelectSettings")

            If setting.Rows.Count > 0 Then

                txtRepHost.Text = Convert.ToString(setting.Rows(0).Item("fldReportServerHost"))
                txtRepUser.Text = Convert.ToString(setting.Rows(0).Item("fldReportServerUser"))
                txtRepPassword.Text = Convert.ToString(setting.Rows(0).Item("fldReportServerPwd"))

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSaveDb_Click(sender As Object, e As EventArgs) Handles btnSaveDb.Click

        Dim testConnString As String = "server=" & txtDbHost.Text & ";" & "uid=" & txtDbUser.Text & ";" & "pwd=" & txtDbPassword.Text & ";" & "Convert Zero Datetime=True;" & "database=" & txtDbName.Text & ";"

        Dim testConn As New MySqlConnection(testConnString)

        Try
            testConn.Open()

            My.Settings.setServerHost = txtDbHost.Text
            My.Settings.setDBUID = txtDbUser.Text
            My.Settings.setDBPWD = txtDbPassword.Text
            My.Settings.setDBName = txtDbName.Text

            My.Settings.Save()

            RadMessageBox.Show("Saved successfully! Restart the program for new settings to take effect.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)

            testConn.Close()

        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        testConn = Nothing

    End Sub

    Private Sub btnSaveRep_Click(sender As Object, e As EventArgs) Handles btnSaveRep.Click

        Slipknot.addParameter("parRepServerHost", txtRepHost.Text)
        Slipknot.addParameter("parRepServerUser", txtRepUser.Text)
        Slipknot.addParameter("parRepServerPwd", txtRepPassword.Text)

        If Slipknot.dbAED("SP_UpdateSetting") Then
            RadMessageBox.Show("Saved successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub
End Class
