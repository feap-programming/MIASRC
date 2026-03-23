Imports System.Text.RegularExpressions
Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class FrmEditDemand

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private id As Integer = 0

    Private oldDemand As Integer = 0

    Private Sub FrmEditDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("parID", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetDemandPerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            dtETDFEAP.Value = DR.Item("fldETDFEAP")
            txtPartName.Text = DR.Item("fldPartName")
            txtCustomer.Text = DR.Item("fldCustomerName")
            seDemand.Value = DR.Item("fldQuantity")
            oldDemand = DR.Item("fldQuantity")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If seDemand.Value <> oldDemand Then

            Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.myDB.AddMySqlParameters("parID", Me.id)
                Me.myDB.AddMySqlParameters("parDemand", seDemand.Value)
                Me.myDB.AddMySqlParameters("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                Me.myDB.SPADE("SP_P_UpdateDemand")
                Me.Close()

            End If

        Else

            RadMessageBox.Show(Me, "You don't have any changes on budget.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

End Class
