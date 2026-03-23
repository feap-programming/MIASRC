Imports System.Text.RegularExpressions
Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class FrmEditPurchaseOrder

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private id As Integer = 0

    Private oldModeOfShipment As String = String.Empty
    Private oldQtyPerBox As Integer = 0
    Private oldQtyPerPallet As Integer = 0
    Private oldQuantity As Integer = 0

    Private Sub FrmEditPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("parID", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetPurchaseOrderPerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            dtDateReceived.Value = DR.Item("fldDateReceived")
            dtETACustomer.Value = DR.Item("fldETACustomer")
            txtPartName.Text = DR.Item("fldPartName")
            txtCustomer.Text = DR.Item("fldCustomerName")
            ddModeOfShipment.SelectedIndex = ddModeOfShipment.FindStringExact(DR.Item("fldModeOfShipment"))
            numQtyPerBox.Value = DR.Item("fldQtyPerBox")
            numQtyPerPallet.Value = DR.Item("fldQtyPerPallet")
            seQuantity.Value = DR.Item("fldQuantity")

            oldModeOfShipment = DR.Item("fldModeOfShipment")
            oldQtyPerBox = DR.Item("fldQtyPerBox")
            oldQtyPerPallet = DR.Item("fldQtyPerPallet")
            oldQuantity = DR.Item("fldQuantity")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If Not (ddModeOfShipment.Text = oldModeOfShipment AndAlso
            numQtyPerBox.Value = oldQtyPerBox AndAlso
            numQtyPerPallet.Value = oldQtyPerPallet AndAlso
            seQuantity.Value = oldQuantity) Then

            Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.myDB.AddMySqlParameters("parID", Me.id)
                Me.myDB.AddMySqlParameters("parModeOfShipment", ddModeOfShipment.Text)
                Me.myDB.AddMySqlParameters("parQtyPerBox", numQtyPerBox.Value)
                Me.myDB.AddMySqlParameters("parQtyPerPallet", numQtyPerPallet.Value)
                Me.myDB.AddMySqlParameters("parQuantity", seQuantity.Value)
                Me.myDB.AddMySqlParameters("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                Me.myDB.SPADE("SP_P_UpdatePurchaseOrder")
                Me.Close()

            End If

        Else

            RadMessageBox.Show(Me, "You don't have any changes on purchase order.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

End Class
