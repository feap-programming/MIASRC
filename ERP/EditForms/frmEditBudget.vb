Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class FrmEditBudget

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private id As Integer = 0

    Private oldBudget As Integer = 0

    Private Sub FrmEditBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        myDB.AddMySqlParameters("id", id)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetBudgetPerID")

        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            numYear.Value = DR.Item("fldYear")
            drpMonth.SelectedIndex = DR.Item("fldMonth") - 1
            txtModel.Text = DR.Item("fldModelName")
            txtDescription.Text = DR.Item("fldDescription")
            txtFGModel.Text = DR.Item("fldFGModel")
            txtCustomer.Text = DR.Item("fldCustomerName")
            seBudget.Value = DR.Item("fldBudget")
            oldBudget = DR.Item("fldBudget")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If seBudget.Value <> oldBudget Then

            Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.myDB.AddMySqlParameters("id", Me.id)
                Me.myDB.AddMySqlParameters("budget", seBudget.Value)
                Me.myDB.AddMySqlParameters("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                Me.myDB.SPADE("SP_P_UpdateBudget")
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
