Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmEditCustomerReference

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable

    Private id As Integer = 0

    Private Sub FrmEditCustomerReference_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("id", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetCustomerReferencePerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            txtName.Text = DR.Item("fldName")
            txtAddress.Text = DR.Item("fldAddress")
            txtTelNo.Text = DR.Item("fldTelNo")
            txtFaxNo.Text = DR.Item("fldFaxNo")
            txtBusinessStyle.Text = DR.Item("fldBusinessStyle")
            txtCountryOrigin.Text = DR.Item("fldCountryOrigin")
            txtTIN.Text = DR.Item("fldTIN")
            txtContactPerson.Text = DR.Item("fldContactPerson")
            txtContactPosition.Text = DR.Item("fldContactPosition")
            drpClassification.SelectedIndex = drpClassification.FindStringExact(DR.Item("fldClassification"))
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.myDB.AddMySqlParameters("id", Me.id)
            Me.myDB.AddMySqlParameters("parAddress", Regex.Replace(Trim(Me.txtAddress.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parTelNo", Regex.Replace(Trim(Me.txtTelNo.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parFaxNo", Regex.Replace(Trim(Me.txtFaxNo.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parBusinessStyle", Regex.Replace(Trim(Me.txtBusinessStyle.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parCountryOrigin", Regex.Replace(Trim(Me.txtCountryOrigin.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parTIN", Regex.Replace(Trim(Me.txtTIN.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parContactPerson", Regex.Replace(Trim(Me.txtContactPerson.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parContactPosition", Regex.Replace(Trim(Me.txtContactPosition.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parClassification", Regex.Replace(Trim(Me.drpClassification.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
            Me.myDB.SPADE("SP_P_UpdateCustomerReference")
            Me.Close()

        End If

    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

End Class
