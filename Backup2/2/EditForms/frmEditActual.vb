Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmEditActual

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private id As Integer = 0

    Private oldUnitPrice As Decimal = 0
    Private oldCurrency As String = String.Empty
    Private oldQuantity As Decimal = 0

    Private Sub FrmEditActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("id", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetActualPerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            txtInvoiceNo.Text = DR.Item("fldInvoiceNo")
            dtETDFEAP.Value = DR.Item("fldETDFEAP")
            dtETDManila.Value = DR.Item("fldETDManila")
            dtATDFEAP.Value = DR.Item("fldATDFEAP")
            dtATDManila.Value = DR.Item("fldATDManila")
            dtATACustomer.Value = DR.Item("fldATACustomer")
            txtCustomer.Text = DR.Item("fldCustomerName")
            txtModel.Text = DR.Item("fldModelName")
            txtPartNo.Text = DR.Item("fldPartNo")
            txtPartName.Text = DR.Item("fldPartName")
            numUnitPrice.Value = DR.Item("fldUnitPrice")
            ddCurrency.SelectedIndex = ddCurrency.FindStringExact(DR.Item("fldCurrency"))
            numQuantity.Value = DR.Item("fldQuantity")

            oldUnitPrice = DR.Item("fldUnitPrice")
            oldCurrency = DR.Item("fldCurrency")
            oldQuantity = DR.Item("fldQuantity")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If numUnitPrice.Value <> oldUnitPrice OrElse
            ddCurrency.SelectedIndex <> ddCurrency.FindStringExact(oldCurrency) OrElse
            numQuantity.Value <> oldQuantity Then

            Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.myDB.AddMySqlParameters("parID", Me.id)
                Me.myDB.AddMySqlParameters("parUnitPrice", numUnitPrice.Value)
                Me.myDB.AddMySqlParameters("parCurrency", ddCurrency.Text)
                Me.myDB.AddMySqlParameters("parQuantity", numQuantity.Value)
                Me.myDB.AddMySqlParameters("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                Me.myDB.SPADE("SP_P_UpdateActual")
                Me.Close()

            End If

        Else

            RadMessageBox.Show(Me, "You don't have any changes on actual details.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

    Public Shared Function ConvertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function

End Class
