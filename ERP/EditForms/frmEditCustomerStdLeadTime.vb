Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmEditCustomerStdLeadTime

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable

    Private id As Int64 = 0
    Private customerCode As String = String.Empty

    Private Sub FrmEditCustomerStdLeadTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("id", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetCustomerStdLeadTimePerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            txtCustomer.Text = DR.Item("fldCustomerName")
            numETDManilaSea.Value = DR.Item("fldETDManilaSeaNOD")
            numETDManilaAir.Value = DR.Item("fldETDManilaAirNOD")
            numETACustomerSea.Value = DR.Item("fldETACustomerSeaNOD")
            numETACustomerAir.Value = DR.Item("fldETACustomerAirNOD")
            dtEffectivityDate.Value = DR.Item("fldEffectivityDate")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then

            Me.myDB.AddMySqlParameters("id", id)
            Me.myDB.AddMySqlParameters("parETDManilaSeaNOD", Me.numETDManilaSea.Value)
            Me.myDB.AddMySqlParameters("parETDManilaAirNOD", Me.numETDManilaAir.Value)
            Me.myDB.AddMySqlParameters("parETACustomerSeaNOD", Me.numETACustomerSea.Value)
            Me.myDB.AddMySqlParameters("parETACustomerAirNOD", Me.numETACustomerAir.Value)
            Me.myDB.AddMySqlParameters("parEffectivityDate", Me.dtEffectivityDate.Value)
            Me.myDB.AddMySqlParameters("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
            Me.myDB.SPADE("SP_P_UpdateCustomerStdLeadTime")
            Me.Close()
        End If

    End Sub

    Public Overloads Sub ShowDialog(_id As Int64, _customerCode As String)
        Me.id = _id
        Me.customerCode = _customerCode
        Me.ShowDialog()
    End Sub

End Class
