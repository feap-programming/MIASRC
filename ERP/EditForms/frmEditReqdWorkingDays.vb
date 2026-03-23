Imports System.Text.RegularExpressions
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmEditReqdWorkingDays

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private lineGroupID As Integer

    Public Overloads Sub ShowDialog(id As Integer)
        Me.lineGroupID = id
        Me.ShowDialog()
    End Sub

    Private Sub FrmEditWorkingDays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        Me.LoadLineCode(Me.drpLineCode)

        myDB.AddMySqlParameters("id", lineGroupID)
        Dim myData As DataTable = myDB.SPSelect("SP_P_GetLineGroupPerID")

        txtID.Text = lineGroupID
        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            numYear.Value = DR.Item("fldYear")
            drpMonth.SelectedIndex = DR.Item("fldMonth") - 1
            drpLineCode.SelectedValue = DR.Item("fldLineSharingCode")
            numActualGroup.Value = DR.Item("fldActualGroup")
            numReqWDays.Value = DR.Item("fldReqdWorkingDays")
            txtRemarks.Text = DR.Item("fldRemarks")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Me.myDB.AddMySqlParameters("id", Me.txtID.Text)
            Me.myDB.AddMySqlParameters("reqdWorkingDays", Me.numReqWDays.Value)
            Me.myDB.AddMySqlParameters("remarks", Regex.Replace(Trim(Me.txtRemarks.Text), "\s+", " "))
            Me.myDB.SPADE("SP_P_UpdateReqdWorkingDays")
            Me.Close()
        End If

    End Sub

    Private Sub LoadLineCode(drpLineCode As RadDropDownList)
        drpLineCode.DataSource = Me.myDB.SPSelect("SP_P_SelectAllLineGroupSharingGrpd")
        drpLineCode.ValueMember = "fldSharingCode"
        drpLineCode.DisplayMember = "fldSharingCode"
    End Sub

End Class
