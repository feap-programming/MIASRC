Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class FrmEditWorkingDays

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private workingDaysID As Integer

    Public Overloads Sub ShowDialog(id As Integer)
        Me.workingDaysID = id
        Me.ShowDialog()
    End Sub

    Private Sub FrmEditWorkingDays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("id", workingDaysID)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetWorkingDaysPerID")

        txtID.Text = workingDaysID
        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            numYear.Value = DR.Item("fldYear")
            drpMonth.SelectedIndex = DR.Item("fldMonth") - 1
            numWorkingDays.Value = DR.Item("fldWorkingDays")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.myDB.AddMySqlParameters("id", Me.txtID.Text)
            Me.myDB.AddMySqlParameters("workingDays", Me.numWorkingDays.Value)
            Me.myDB.SPADE("SP_P_UpdateWorkingDays")
            Me.Close()
        End If

    End Sub

End Class
