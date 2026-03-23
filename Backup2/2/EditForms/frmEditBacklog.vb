Imports System.Text.RegularExpressions
Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class FrmEditBacklog

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private id As Integer = 0

    Private oldBacklog As Integer = 0

    Private Sub FrmEditBacklog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("parID", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetBacklogPerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            dtEffectivityDate.Value = DR.Item("fldEffectivityDate")
            txtCustomer.Text = DR.Item("fldCustomerName")
            txtPartName.Text = DR.Item("fldPartName")
            txtRemarks.Text = String.Empty
            seBacklog.Value = DR.Item("fldQuantity")
            oldBacklog = DR.Item("fldQuantity")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If seBacklog.Value <> oldBacklog Then

            Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.myDB.AddMySqlParameters("parID", Me.id)
                Me.myDB.AddMySqlParameters("parBacklog", seBacklog.Value)
                Me.myDB.AddMySqlParameters("parRemarks", txtRemarks.Text)
                Me.myDB.AddMySqlParameters("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                Me.myDB.SPADE("SP_P_UpdateBacklog")
                Me.Close()

            End If

        Else

            RadMessageBox.Show(Me, "You don't have any changes on backlog.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

End Class
