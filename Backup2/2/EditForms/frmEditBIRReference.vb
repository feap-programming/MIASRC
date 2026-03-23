Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmEditBIRReference

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable

    Private id As Integer = 0

    Private Sub FrmEditBIRReference_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("id", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetBIRReferencePerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            txtPermitNo.Text = DR.Item("fldPermitNo")
            dtDateIssued.Value = DR.Item("fldDateIssued")
            numSeriesFrom.Value = DR.Item("fldSeriesFrom")
            numSeriesTo.Value = DR.Item("fldSeriesTo")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.myDB.AddMySqlParameters("id", Me.id)
            Me.myDB.AddMySqlParameters("parDateIssued", dtDateIssued.Value)
            Me.myDB.AddMySqlParameters("parSeriesFrom", numSeriesFrom.Value)
            Me.myDB.AddMySqlParameters("parSeriesTo", numSeriesTo.Value)
            Me.myDB.AddMySqlParameters("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
            Me.myDB.SPADE("SP_P_UpdateBIRReference")
            Me.Close()

        End If

    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

End Class
