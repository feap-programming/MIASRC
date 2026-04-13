Imports System.IO
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmLogin
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        RadMessageBox.ThemeName = "Breeze"

        Dim frm As RadForm

        For Each frm In My.Application.OpenForms
            Slipknot.changeTheme(frm)
        Next

        If checkConnection() Then
            If checkVersion() = False Then
                Me.Close()
                Dim updaterPath As String = System.IO.Path.Combine(Application.StartupPath, "App-dater.exe")
                System.Diagnostics.Process.Start(updaterPath)

            End If
        Else
            FrmSettings.Show()
            FrmSettings.gbReportServer.Visible = False
            Me.Close()
        End If

    End Sub

    Function checkConnection() As Boolean

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        checkConnection = False

        Try

            conn.Open()

            checkConnection = True

            conn.Close()

            conn = Nothing

        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return checkConnection
    End Function

    Function checkVersion() As Boolean

        checkVersion = False

        Dim settings As DataTable = Slipknot.dbSelect("SP_SelectSettings")

        If settings.Rows.Count > 0 Then
            globalVariables.reportSource = settings.Rows(0).Item("fldOnlineReport")

            If lblVersion.Text = Convert.ToString(settings.Rows(0).Item("fldMiaSrcVersion")) Then
                checkVersion = True
            End If

        End If

        Return checkVersion
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If checkConnection() Then
            loginGo()
        End If
    End Sub

    Private Sub loginGo()

        Slipknot.addParameter("parUsername", txtUsername.Text)
        Slipknot.addParameter("parPassword", Slipknot.getMD5Hash(txtPassword.Text))
        Dim user As DataTable = Slipknot.dbSelect("SP_SelectUser")

        If user.Rows.Count > 0 Then

            currentUser = user.Rows(0)
            frmBase.Show()
            Me.Close()
        Else
            txtPassword.Focus()
            txtPassword.SelectAll()
            RadMessageBox.Show("Access denied! You might entered wrong username or password", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtUsername.Focus()
    End Sub

End Class
