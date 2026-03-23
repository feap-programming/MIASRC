Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class ucDailyOtherDetails
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub ucDailyOtherDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadData()
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        Dim result As Integer = RadMessageBox.Show("Are you sure you want to save?", "Yes or No?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCOtherDetails where fldDRID=" & globalVariables.DailyRepID & "")

                If CheckExist.Rows.Count >= 1 Then
                    Maria.MyQuery("Delete From tblDailyReportSRCOtherDetails where fldDRID=" & globalVariables.DailyRepID & "")
                End If

                Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                Maria.AddMySqlParameters("parMoldParts", tbMoldParts.Text)
                Maria.AddMySqlParameters("parInitProd", tbInitialProb.Text)
                Maria.AddMySqlParameters("parOthers", tbOthers.Text)
                Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                Maria.SPADE("SP_SRCDailyReport_InsertOtherDetails")

                RadMessageBox.Show("Done!")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub ReloadData()
        Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCOtherDetails where fldDRID=" & globalVariables.DailyRepID & "")

        If CheckExist.Rows.Count >= 1 Then

            tbMoldParts.Text = CheckExist.Rows(0).Item("fldMoldParts").ToString
            tbInitialProb.Text = CheckExist.Rows(0).Item("fldInitProd").ToString
            tbOthers.Text = CheckExist.Rows(0).Item("fldOthers").ToString

        End If
    End Sub

    Private Sub cbbClear_Click(sender As Object, e As EventArgs) Handles cbbClear.Click
        Dim result As Integer = RadMessageBox.Show("Data inputed will be removed. Continue?", "Yes or No?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            tbMoldParts.Text = ""
            tbInitialProb.Text = ""
            tbOthers.Text = ""

        End If
    End Sub

    Private Sub tbMoldParts_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMoldParts.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbMoldParts.Text = tbMoldParts.Text & Environment.NewLine
            tbMoldParts.Select(tbMoldParts.Text.Length, 0)
        End If
    End Sub

    Private Sub tbInitialProb_KeyDown(sender As Object, e As KeyEventArgs) Handles tbInitialProb.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbInitialProb.Text = tbInitialProb.Text & Environment.NewLine
            tbInitialProb.Select(tbInitialProb.Text.Length, 0)
        End If
    End Sub

    Private Sub tbOthers_KeyDown(sender As Object, e As KeyEventArgs) Handles tbOthers.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbOthers.Text = tbOthers.Text & Environment.NewLine
            tbOthers.Select(tbOthers.Text.Length, 0)
        End If
    End Sub
End Class
