Imports System.Text.RegularExpressions
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmEditCTOA

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private ctoaID As Integer

    Public Overloads Sub ShowDialog(id As Integer)
        Me.ctoaID = id
        Me.ShowDialog()
    End Sub

    Private Sub FrmEditCTOA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        Me.LoadLineCode(Me.drpLineCode)
        Me.LoadCustomerCode(Me.drpCustomerCode)

        myDB.AddMySqlParameters("id", ctoaID)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetModelCapacityPerID")

        txtID.Text = ctoaID
        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            numYear.Value = DR.Item("fldYear")
            drpMonth.SelectedIndex = DR.Item("fldMonth") - 1
            drpLineCode.SelectedValue = DR.Item("fldLineCode")
            drpModelCode.SelectedValue = DR.Item("fldModelCode")
            numCT.Value = DR.Item("fldCT")
            numOA.Value = DR.Item("fldOA")
            txtPartName.Text = DR.Item("fldModelName")
            drpCustomerCode.SelectedValue = DR.Item("fldCustomerCode")
            numLineNo.Value = DR.Item("fldLineNumber")
            numPriority.Value = DR.Item("fldPriority")
        End If

    End Sub

    Private Sub drpLineCode_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles drpLineCode.SelectedIndexChanged

        If Me.drpLineCode.Text <> "NOT IN LINE" Then
            Me.myDB.AddMySqlParameters("lineCode", Me.drpLineCode.SelectedValue)
            Me.drpModelCode.DataSource = Me.myDB.SPSelect("SP_P_SelectModelCodeByLineCode")
            Me.drpModelCode.ValueMember = "fldModelCode"
            Me.drpModelCode.DisplayMember = "fldModelName"
        Else
            Me.drpModelCode.DataSource = Nothing
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.myDB.AddMySqlParameters("id", Me.txtID.Text)
            Me.myDB.AddMySqlParameters("ct", Me.numCT.Value)
            Me.myDB.AddMySqlParameters("oa", Me.numOA.Value)
            Me.myDB.AddMySqlParameters("partName", Regex.Replace(Trim(Me.txtPartName.Text), "\s+", " "))
            Me.myDB.AddMySqlParameters("customerCode", IIf(Me.drpCustomerCode.SelectedIndex > -1, Me.drpCustomerCode.SelectedValue, String.Empty))
            Me.myDB.AddMySqlParameters("lineNo", Me.numLineNo.Value)
            Me.myDB.AddMySqlParameters("priority", Me.numPriority.Value)
            Me.myDB.SPADE("SP_P_UpdateModelSettings")
            Me.Close()
        End If

    End Sub

    Private Sub LoadLineCode(drpLineCode As RadDropDownList)
        drpLineCode.DataSource = Me.myDB.SPSelect("SP_SelectAllLines")
        drpLineCode.ValueMember = "fldCode"
        drpLineCode.DisplayMember = "fldLineName"
    End Sub

    Private Sub LoadCustomerCode(drpCustomerCode As RadDropDownList)
        drpCustomerCode.DataSource = Me.myDB.SPSelect("SP_SelectAllCustomers")
        drpCustomerCode.ValueMember = "fldCustomerCode"
        drpCustomerCode.DisplayMember = "fldCustomerName"
        drpCustomerCode.SelectedIndex = -1
        drpCustomerCode.Text = String.Empty
    End Sub

End Class
