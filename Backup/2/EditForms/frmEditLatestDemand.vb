Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmEditLatestDemand

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private id As Integer = 0

    Private oldQuantity As Integer = 0

    Private Sub FrmEditLatestDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("parID", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetLatestDemandPerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            dtDateIssued.Value = DR.Item("fldDateIssued")
            dtDateForecast.Value = DR.Item("fldDateForecast")
            txtCustomer.Text = DR.Item("fldCustomerName")
            txtPartName.Text = DR.Item("fldPartName")
            seQuantity.Value = DR.Item("fldQuantity")
            oldQuantity = DR.Item("fldQuantity")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If seQuantity.Value <> oldQuantity Then

            Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.myDB.AddMySqlParameters("parID", Me.id)
                Me.myDB.AddMySqlParameters("parQuantity", seQuantity.Value)
                Me.myDB.AddMySqlParameters("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                Me.myDB.SPADE("SP_P_UpdateLatestDemand")
                Me.Close()

            End If

        Else

            RadMessageBox.Show(Me, "You don't have any changes on quantity.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

End Class
