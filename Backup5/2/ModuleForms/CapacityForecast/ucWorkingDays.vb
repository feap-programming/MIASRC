Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports System.ComponentModel
Imports Telerik.WinControls.Data

Public Class ucWorkingDays

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable

    Private Sub ucWorkingDays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeThemeUC(Me)

        Me.numYear.Value = Year(Date.Today)
        Me.GetWorkingDaysPerYear(Me.numYear.Value)

        Me.SetUpColumns(Me.gvData)

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Me.myDB.SPSelect("SP_P_SelectWorkingDays")
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

        Slipknot.addParameter("IDArray", id)
        Slipknot.dbAED("SP_P_DeleteWorkingDays")
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

    Private Sub numYear_ValueChanged(sender As Object, e As EventArgs) Handles numYear.ValueChanged
        Me.GetWorkingDaysPerYear(Me.numYear.Value)
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Dim year As Integer = Me.numYear.Value
        Dim monthWD() As Integer = {Me.numJan.Value, Me.numFeb.Value, Me.numMar.Value, Me.numApr.Value, Me.numMay.Value, Me.numJun.Value, Me.numJul.Value, Me.numAug.Value, Me.numSep.Value, Me.numOct.Value, Me.numNov.Value, Me.numDec.Value}

        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to save record/s?", "Saving Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            For month As Integer = 1 To 12
                Me.myDB.AddMySqlParameters("_year", year)
                Me.myDB.AddMySqlParameters("_month", month)
                Me.myDB.AddMySqlParameters("workingDays", monthWD(month - 1))
                Me.myDB.AddMySqlParameters("addedBy", currentUser.Item("fldUsername"))
                Me.myDB.SPADE("SP_P_InsertWorkingDays")
            Next
            RadMessageBox.Show(Me, "Monthly working days successfully added.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click

        Try
            Dim editForm As New FrmEditLineGroup
            editForm.ShowDialog(Me.gvData.CurrentRow.Cells("fldID").Value)
        Catch ex As System.Reflection.AmbiguousMatchException
            RadMessageBox.Show(Me, "Please select proper row.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

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

    Private Sub GetWorkingDaysPerYear(year As Integer)

        Me.myDB.AddMySqlParameters("_year", year)
        Me.myDB.AddMySqlParameters("janWD", 0)
        Me.myDB.AddMySqlParameters("febWD", 0)
        Me.myDB.AddMySqlParameters("marWD", 0)
        Me.myDB.AddMySqlParameters("aprWD", 0)
        Me.myDB.AddMySqlParameters("mayWD", 0)
        Me.myDB.AddMySqlParameters("junWD", 0)
        Me.myDB.AddMySqlParameters("julWD", 0)
        Me.myDB.AddMySqlParameters("augWD", 0)
        Me.myDB.AddMySqlParameters("sepWD", 0)
        Me.myDB.AddMySqlParameters("octWD", 0)
        Me.myDB.AddMySqlParameters("novWD", 0)
        Me.myDB.AddMySqlParameters("decWD", 0)
        Dim workingDays As IDictionary(Of String, Object) =
            Me.myDB.SPOutput("SP_P_GetWorkingDaysPerYear",
                             "janWD", "febWD", "marWD", "aprWD", "mayWD", "junWD",
                             "julWD", "augWD", "sepWD", "octWD", "novWD", "decWD")
        Me.numJan.Value = CInt(workingDays("janWD"))
        Me.numFeb.Value = CInt(workingDays("febWD"))
        Me.numMar.Value = CInt(workingDays("marWD"))
        Me.numApr.Value = CInt(workingDays("aprWD"))
        Me.numMay.Value = CInt(workingDays("mayWD"))
        Me.numJun.Value = CInt(workingDays("junWD"))
        Me.numJul.Value = CInt(workingDays("julWD"))
        Me.numAug.Value = CInt(workingDays("augWD"))
        Me.numSep.Value = CInt(workingDays("sepWD"))
        Me.numOct.Value = CInt(workingDays("octWD"))
        Me.numNov.Value = CInt(workingDays("novWD"))
        Me.numDec.Value = CInt(workingDays("decWD"))

    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim id As New GridViewDecimalColumn("ID")
        id.FieldName = "fldID"
        id.Width = 80
        id.TextAlignment = ContentAlignment.MiddleCenter
        id.IsVisible = False
        gridView.Columns.Add(id)

        Dim year As New GridViewDecimalColumn("Year")
        year.FieldName = "fldYear"
        year.Width = 100
        year.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(year)

        Dim month As New GridViewTextBoxColumn("Month")
        month.FieldName = "fldMonthName"
        month.Width = 150
        month.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(month)

        Dim workingDays As New GridViewDecimalColumn("Working Days")
        workingDays.FieldName = "fldWorkingDays"
        workingDays.Width = 100
        workingDays.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(workingDays)

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

        Dim yearDesc As New GroupDescriptor()
        yearDesc.GroupNames.Add("fldYear", ListSortDirection.Descending)
        gridView.GroupDescriptors.Add(yearDesc)
        'gridView.MasterTemplate.AutoExpandGroups = True

    End Sub

End Class
