Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls.Data


Public Class FrmLineGroupSharing

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable

    Private Sub FrmLineGroupSharing_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub FrmLineGroupSharing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        Me.LoadSharingCode(Me.drpSharingCode)
        Me.LoadLineCode(Me.drpLineCode)

        Me.SetUpColumns(Me.gvData)

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Me.myDB.SPSelect("SP_P_SelectAllLineGroupSharing")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
        leCountRec.Text = gvData.Rows.Count
    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldID").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Me.myDB.AddMySqlParameters("IDArray", id)
        Me.myDB.SPADE("SP_P_DeleteLineGroupSharing")
    End Sub

    Private Sub bwOperation_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwOperation.ProgressChanged
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwOperation_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwOperation.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If Not String.IsNullOrWhiteSpace(Me.drpSharingCode.Text) AndAlso
            Me.drpLineCode.Text <> "NOT IN LINE" Then

            Dim sharingCode As String = Me.drpSharingCode.Text
            Dim lineCode As String = Me.drpLineCode.SelectedValue

            Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to save record/s?", "Saving Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Me.myDB.AddMySqlParameters("sharingCode", Regex.Replace(Trim(sharingCode), "\s+", ""))
                Me.myDB.AddMySqlParameters("lineCode", lineCode)
                Me.myDB.AddMySqlParameters("addedBy", currentUser.Item("fldUsername"))
                Me.myDB.SPADE("SP_P_InsertLineGroupSharing")
                RadMessageBox.Show(Me, "Line Group Sharing successfully added.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If

        Else

            RadMessageBox.Show(Me, "Please select sharing group and SRC/BSS line.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to delete record/s?", "Deleting Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            If gvData.SelectedRows.Count > 0 Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.ShowFilteringRow = True
        Else
            gvData.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub LoadSharingCode(drpSharingCode As RadDropDownList)
        drpSharingCode.DataSource = Me.myDB.SPSelect("SP_P_SelectAllLineGroupSharingGrpd")
        drpSharingCode.ValueMember = "fldSharingCode"
        drpSharingCode.DisplayMember = "fldSharingCode"
        drpSharingCode.Text = String.Empty
    End Sub

    Private Sub LoadLineCode(drpLineCode As RadDropDownList)
        drpLineCode.DataSource = Me.myDB.SPSelect("SP_SelectAllLines")
        drpLineCode.ValueMember = "fldCode"
        drpLineCode.DisplayMember = "fldLineName"
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim id As New GridViewDecimalColumn("ID")
        id.FieldName = "fldID"
        id.Width = 80
        id.TextAlignment = ContentAlignment.MiddleCenter
        id.IsVisible = False
        gridView.Columns.Add(id)

        Dim sharingCode As New GridViewTextBoxColumn("Sharing Code")
        sharingCode.FieldName = "fldSharingCode"
        sharingCode.Width = 150
        sharingCode.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(sharingCode)

        Dim lineCode As New GridViewTextBoxColumn("Line Code")
        lineCode.FieldName = "fldLineCode"
        lineCode.Width = 150
        lineCode.TextAlignment = ContentAlignment.MiddleCenter
        lineCode.IsVisible = False
        gridView.Columns.Add(lineCode)

        Dim lineName As New GridViewTextBoxColumn("Line Name")
        lineName.FieldName = "fldLineName"
        lineName.Width = 150
        lineName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(lineName)

        Dim dateAdded As New GridViewDateTimeColumn("Date Added")
        dateAdded.FieldName = "fldDateAdded"
        dateAdded.Width = 150
        dateAdded.Format = DateTimePickerFormat.Custom
        dateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(dateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim addedBy As New GridViewTextBoxColumn("Added By")
        addedBy.FieldName = "fldAddedBy"
        addedBy.Width = 150
        addedBy.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(addedBy)

        Dim sharingCodeDesc As New GroupDescriptor()
        sharingCodeDesc.GroupNames.Add("fldSharingCode", ListSortDirection.Ascending)
        gridView.GroupDescriptors.Add(sharingCodeDesc)

    End Sub

End Class
