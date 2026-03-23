Imports System.ComponentModel
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmImportLineGroup

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Public linestat As String
    Public lineNo As Integer

    Private Sub FrmImportLineGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)
    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click
        gvData.DataSource = Nothing

        Dim table As DataTable = Slipknot.getClipboard

        Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                    Select New With
                                         {
                                           .fldYear = IIf(Not String.IsNullOrEmpty(T0.Item(0)), T0.Item(0), 0),
                                           .fldMonthName = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
                                           .fldLineSharingCode = Regex.Replace(Trim(T0.Item(2)), "\s+", " "),
                                           .fldActualGroup = IIf(Not String.IsNullOrEmpty(T0.Item(3)), T0.Item(3), 0)
                                         }).ToList
        gvData.DataSource = Query
    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click
        bwUpload.RunWorkerAsync()
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 20

        For counter As Integer = 0 To gvData.Rows.Count - 1

            Slipknot.addParameter("_year", gvData.Rows(counter).Cells("fldYear").Value)
            Slipknot.addParameter("_month", DateTime.ParseExact(gvData.Rows(counter).Cells("fldMonthName").Value, "MMMM", CultureInfo.CurrentCulture).Month)
            Slipknot.addParameter("lineSharingCode", gvData.Rows(counter).Cells("fldLineSharingCode").Value)
            Slipknot.addParameter("actualGroup", gvData.Rows(counter).Cells("fldActualGroup").Value)
            Slipknot.addParameter("addedBy", currentUser.Item("fldUsername"))

            If Slipknot.dbAED("SP_P_InsertLineGroup") Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / gvData.Rows.Count * 100
            lineNo = counter
            RadProgressBarElement1.Text = "Saving..."
            bwUpload.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)
        Next
    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        'ucLineGroup.bwLoadData.RunWorkerAsync()
        RadMessageBox.Show("Successfully Uploaded", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you want to delete " & gvData.SelectedRows.Count & " selected row(s)?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}
            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1
                Me.gvData.Rows.Remove(rows(i))
            Next
        End If
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click
        If RadMessageBox.Show("Are you sure you want to clear the list?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            gvData.DataSource = Nothing
        End If
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldStatColumn As New GridViewTextBoxColumn("Status")
        fldStatColumn.FieldName = "STATUS"
        fldStatColumn.Width = 60
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.IsPinned = True
        fldStatColumn.PinPosition = PinnedColumnPosition.Left
        gridView.Columns.Add(fldStatColumn)

        Dim year As New GridViewDecimalColumn("Year")
        year.FieldName = "fldYear"
        year.Width = 100
        year.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(year)

        Dim monthName As New GridViewTextBoxColumn("Month")
        monthName.FieldName = "fldMonthName"
        monthName.Width = 150
        monthName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(monthName)

        Dim lineCode As New GridViewTextBoxColumn("Line Sh. Code")
        lineCode.FieldName = "fldLineSharingCode"
        lineCode.Width = 120
        lineCode.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(lineCode)

        Dim actualGroup As New GridViewDecimalColumn("Actual Group")
        actualGroup.FieldName = "fldActualGroup"
        actualGroup.Width = 120
        actualGroup.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(actualGroup)

    End Sub

End Class
