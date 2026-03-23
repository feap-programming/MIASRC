Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports System.ComponentModel

Public Class FrmCapacityPlanning

    Private parYear As Integer
    Private parMonth As Integer
    Private workingDays As Integer

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private tblWorkingDays As DataTable = Nothing
    Private tblLineGroup As DataTable = Nothing
    Private tblModelCapacity As DataTable = Nothing
    Private linestat As String
    Private lineNo As Integer

    Private Sub FrmCapacityPlanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        Me.tblWorkingDays = Me.myDB.SPSelect("SP_P_SelectWorkingDays")
        Me.tblLineGroup = Me.myDB.SPSelect("SP_P_SelectAllLineGroup")
        Me.myDB.AddMySqlParameters("_year", parYear)
        Me.myDB.AddMySqlParameters("_month", parMonth)
        Me.tblModelCapacity = Me.myDB.SPSelect("SP_P_SelectModelCapacityPreview")

        Me.lblMonthYear.Text = MonthName(parMonth) & " " & parYear.ToString()
        Me.workingDays = Me.tblWorkingDays.Select("fldYear = " & parYear & " AND " &
                                                  "fldMonth = " & parMonth & "")(0).Item("fldWorkingDays")
        Me.lblWorkingDays.Text = Me.workingDays.ToString()

        Dim drLineGroup As DataRow() = Me.tblLineGroup.Select("fldYear = " & parYear & " AND " &
                                                              "fldMonth = " & parMonth & "")
        Me.SetUpColumnsRWD(Me.gvReqWDays)
        Me.gvReqWDays.DataSource = If(drLineGroup.Count > 0, drLineGroup.CopyToDataTable(), Nothing)

        Me.SetUpColumns(Me.gvData)
        Me.gvData.DataSource = If(tblModelCapacity, Nothing)
    End Sub

    Private Sub cbbPasteData_Click(sender As Object, e As EventArgs) Handles cbbPasteData.Click
        Try
            gvData.DataSource = Nothing

            Dim table As DataTable = Slipknot.getClipboard

            Dim warningMessage As String = String.Empty
            For Each row As DataRow In table.Rows
                If Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(row.Item(0)), "\s+", " ") & "' AND " &
                                              "fldLineName = '" & Regex.Replace(Trim(row.Item(1)), "\s+", " ") & "' AND " &
                                              "fldModel = '" & Regex.Replace(Trim(row.Item(2)), "\s+", " ") & "' AND " &
                                              "fldPartName = '" & Regex.Replace(Trim(row.Item(3)), "\s+", " ") & "' AND " &
                                              "fldCustomerName = '" & Regex.Replace(Trim(row.Item(4)), "\s+", " ") & "'").Count < 1 Then
                    warningMessage += Environment.NewLine & row.Item(0) & " | " & row.Item(1) & " | " & row.Item(2)
                End If
            Next

            If Not String.IsNullOrWhiteSpace(warningMessage) Then
                RadMessageBox.Show(Me, "The following models are not found in the collection:" & Environment.NewLine & warningMessage, "Model Not Found", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If

            Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                        Select New With
                                             {
                                               .fldID = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldID"),
                                               .fldYear = parYear,
                                               .fldMonth = parMonth,
                                               .fldMonthName = MonthName(parMonth),
                                               .fldSharingCode = Regex.Replace(Trim(T0.Item(0)), "\s+", " "),
                                               .fldLineCode = Me.tblModelCapacity.Select("fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "'")(0).Item("fldLineCode"),
                                               .fldLineName = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
                                               .fldModelCode = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldModelCode"),
                                               .fldModelName = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldModelName"),
                                               .fldModel = Regex.Replace(Trim(T0.Item(2)), "\s+", " "),
                                               .fldPartName = Regex.Replace(Trim(T0.Item(3)), "\s+", " "),
                                               .fldCustomerCode = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldCustomerCode"),
                                               .fldCustomerName = Regex.Replace(Trim(T0.Item(4)), "\s+", " "),
                                               .fldLineNumber = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldLineNumber"),
                                               .fldPriority = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldPriority"),
                                               .fldCT = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldCT"),
                                               .fldOA = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldOA"),
                                               .fldCapacityPerHour = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldCapacityPerHour"),
                                               .fldCapacityPerShift = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldCapacityPerShift"),
                                               .fldLastMonthEndingStock = IIf(Not String.IsNullOrEmpty(T0.Item(5)), T0.Item(5), 0),
                                               .fldLatestDemand = Me.tblModelCapacity.Select("fldSharingCode = '" & Regex.Replace(Trim(T0.Item(0)), "\s+", " ") & "' AND " &
                                                                                "fldLineName = '" & Regex.Replace(Trim(T0.Item(1)), "\s+", " ") & "' AND " &
                                                                                "fldModel = '" & Regex.Replace(Trim(T0.Item(2)), "\s+", " ") & "' AND " &
                                                                                "fldPartName = '" & Regex.Replace(Trim(T0.Item(3)), "\s+", " ") & "' AND " &
                                                                                "fldCustomerName = '" & Regex.Replace(Trim(T0.Item(4)), "\s+", " ") & "'")(0).Item("fldLatestDemand"),
                                               .fldProductionPlan = IIf(Not String.IsNullOrEmpty(T0.Item(6)), T0.Item(6), 0),
                                               .fldAdvanceDelivery = IIf(Not String.IsNullOrEmpty(T0.Item(7)), T0.Item(7), 0),
                                               .fldFirstWeekDelivery = IIf(Not String.IsNullOrEmpty(T0.Item(8)), T0.Item(8), 0)
                                             }).ToList

            gvData.DataSource = Query
            leCountRec.Text = gvData.Rows.Count
        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click

        If Not bwSavePlanning.IsBusy() Then
            Dim confirm As DialogResult = RadMessageBox.Show(Me, "Please confirm to save data.", "Saving Data", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If confirm = DialogResult.Yes Then
                bwSaveWDays.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub bwSaveWDays_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwSaveWDays.DoWork
        Dim delay As Integer = 20

        For counter As Integer = 0 To gvReqWDays.Rows.Count - 1

            Slipknot.addParameter("id", gvReqWDays.Rows(counter).Cells("fldID").Value)
            Slipknot.addParameter("reqdWorkingDays", gvReqWDays.Rows(counter).Cells("fldReqdWorkingDays").Value)
            Slipknot.addParameter("remarks", gvReqWDays.Rows(counter).Cells("fldRemarks").Value)

            If Slipknot.dbAED("SP_P_UpdateReqdWorkingDays") Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / gvReqWDays.Rows.Count * 100
            lineNo = counter
            Threading.Thread.Sleep(delay)
            RadProgressBarElement1.Text = "Saving..."
            bwSaveWDays.ReportProgress(Convert.ToInt32(percent))
        Next

    End Sub

    Private Sub bwSaveWDays_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwSaveWDays.ProgressChanged
        gvReqWDays.CurrentRow = gvReqWDays.Rows(lineNo)
        gvReqWDays.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwSaveWDays_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwSaveWDays.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        bwSavePlanning.RunWorkerAsync()
    End Sub

    Private Sub bwSavePlanning_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwSavePlanning.DoWork
        Dim delay As Integer = 20

        For counter As Integer = 0 To gvData.Rows.Count - 1

            Slipknot.addParameter("id", gvData.Rows(counter).Cells("fldID").Value)
            Slipknot.addParameter("beginningStock", gvData.Rows(counter).Cells("fldLastMonthEndingStock").Value)
            Slipknot.addParameter("productionPlan", gvData.Rows(counter).Cells("fldProductionPlan").Value)
            Slipknot.addParameter("advanceDelivery", gvData.Rows(counter).Cells("fldAdvanceDelivery").Value)
            Slipknot.addParameter("firstWeekDelivery", gvData.Rows(counter).Cells("fldFirstWeekDelivery").Value)

            If Slipknot.dbAED("SP_P_UpdateModelCapacity") Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / gvData.Rows.Count * 100
            lineNo = counter
            Threading.Thread.Sleep(delay)
            RadProgressBarElement1.Text = "Saving..."
            bwSavePlanning.ReportProgress(Convert.ToInt32(percent))
        Next
    End Sub

    Private Sub bwSavePlanning_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwSavePlanning.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwSavePlanning_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwSavePlanning.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        RadMessageBox.Show(Me, "Data successfully saved.", "Data Saved", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub cbbCalculate_Click(sender As Object, e As EventArgs) Handles cbbCalculate.Click

        Dim myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)

        myDB.AddMySqlParameters("_year", parYear)
        myDB.AddMySqlParameters("_month", parMonth)
        myDB.SPADE("SP_P_DeleteCapacityPlanningTest")

        bwWDays.RunWorkerAsync()

    End Sub

    Private Sub bwWDays_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwWDays.DoWork
        Dim delay As Integer = 20

        For counter As Integer = 0 To gvReqWDays.Rows.Count - 1

            Slipknot.addParameter("_year", gvReqWDays.Rows(counter).Cells("fldYear").Value)
            Slipknot.addParameter("_month", gvReqWDays.Rows(counter).Cells("fldMonth").Value)
            Slipknot.addParameter("lineSharingCode", gvReqWDays.Rows(counter).Cells("fldLineSharingCode").Value)
            Slipknot.addParameter("actualGroup", gvReqWDays.Rows(counter).Cells("fldActualGroup").Value)
            Slipknot.addParameter("reqdWorkingDays", gvReqWDays.Rows(counter).Cells("fldReqdWorkingDays").Value)
            Slipknot.addParameter("remarks", gvReqWDays.Rows(counter).Cells("fldRemarks").Value)

            If Slipknot.dbAED("SP_P_InsertWorkingDaysPlanning") Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / gvReqWDays.Rows.Count * 100
            lineNo = counter
            Threading.Thread.Sleep(delay)
            RadProgressBarElement1.Text = "Saving..."
            bwWDays.ReportProgress(Convert.ToInt32(percent))
        Next

    End Sub

    Private Sub bwWDays_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwWDays.ProgressChanged
        gvReqWDays.CurrentRow = gvReqWDays.Rows(lineNo)
        gvReqWDays.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwWDays_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwWDays.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        bwPlanning.RunWorkerAsync()
    End Sub

    Private Sub bwPlanning_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwPlanning.DoWork
        Dim delay As Integer = 20

        For counter As Integer = 0 To gvData.Rows.Count - 1

            Slipknot.addParameter("_year", gvData.Rows(counter).Cells("fldYear").Value)
            Slipknot.addParameter("_month", gvData.Rows(counter).Cells("fldMonth").Value)
            Slipknot.addParameter("lineCode", gvData.Rows(counter).Cells("fldLineCode").Value)
            Slipknot.addParameter("modelCode", gvData.Rows(counter).Cells("fldModelCode").Value)
            Slipknot.addParameter("partName", gvData.Rows(counter).Cells("fldPartName").Value)
            Slipknot.addParameter("customerCode", gvData.Rows(counter).Cells("fldCustomerCode").Value)
            Slipknot.addParameter("lineNo", gvData.Rows(counter).Cells("fldLineNumber").Value)
            Slipknot.addParameter("priority", gvData.Rows(counter).Cells("fldPriority").Value)
            Slipknot.addParameter("ct", gvData.Rows(counter).Cells("fldCT").Value)
            Slipknot.addParameter("oa", gvData.Rows(counter).Cells("fldOA").Value)
            Slipknot.addParameter("beginningStock", gvData.Rows(counter).Cells("fldLastMonthEndingStock").Value)
            Slipknot.addParameter("productionPlan", gvData.Rows(counter).Cells("fldProductionPlan").Value)
            Slipknot.addParameter("advanceDelivery", gvData.Rows(counter).Cells("fldAdvanceDelivery").Value)
            Slipknot.addParameter("firstWeekDelivery", gvData.Rows(counter).Cells("fldFirstWeekDelivery").Value)

            If Slipknot.dbAED("SP_P_InsertCapacityPlanning") Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / gvData.Rows.Count * 100
            lineNo = counter
            Threading.Thread.Sleep(delay)
            RadProgressBarElement1.Text = "Saving..."
            bwPlanning.ReportProgress(Convert.ToInt32(percent))
        Next
    End Sub

    Private Sub bwPlanning_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwPlanning.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwPlanning_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwPlanning.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        Dim previewForm As New frmRptModelCapacityTest
        previewForm.Show(parYear, parMonth)
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

    Public Overloads Sub Show(year As Integer, month As Integer)

        Me.parYear = year
        Me.parMonth = month
        Me.Show()

    End Sub

    Private Sub SetUpColumnsRWD(gridView As RadGridView)

        Dim fldStatColumn As New GridViewTextBoxColumn("Status")
        fldStatColumn.FieldName = "STATUS"
        fldStatColumn.Width = 60
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.IsPinned = True
        fldStatColumn.PinPosition = PinnedColumnPosition.Left
        fldStatColumn.ReadOnly = True
        gridView.Columns.Add(fldStatColumn)

        Dim id As New GridViewDecimalColumn("ID")
        id.FieldName = "fldID"
        id.Width = 80
        id.TextAlignment = ContentAlignment.MiddleCenter
        id.IsVisible = False
        id.ReadOnly = True
        gridView.Columns.Add(id)

        Dim year As New GridViewDecimalColumn("Year")
        year.FieldName = "fldYear"
        year.Width = 100
        year.TextAlignment = ContentAlignment.MiddleCenter
        year.IsVisible = False
        year.ReadOnly = True
        gridView.Columns.Add(year)

        Dim month As New GridViewDecimalColumn("Month")
        month.FieldName = "fldMonth"
        month.Width = 100
        month.TextAlignment = ContentAlignment.MiddleCenter
        month.IsVisible = False
        month.ReadOnly = True
        gridView.Columns.Add(month)

        Dim monthName As New GridViewTextBoxColumn("Month Name")
        monthName.FieldName = "fldMonthName"
        monthName.Width = 150
        monthName.TextAlignment = ContentAlignment.MiddleCenter
        monthName.IsVisible = False
        monthName.ReadOnly = True
        gridView.Columns.Add(monthName)

        Dim lineCode As New GridViewTextBoxColumn("Line Sh. Code")
        lineCode.FieldName = "fldLineSharingCode"
        lineCode.Width = 120
        lineCode.TextAlignment = ContentAlignment.MiddleCenter
        lineCode.ReadOnly = True
        lineCode.IsPinned = True
        lineCode.PinPosition = PinnedColumnPosition.Left
        gridView.Columns.Add(lineCode)

        Dim actualGroup As New GridViewDecimalColumn("Actual Group")
        actualGroup.FieldName = "fldActualGroup"
        actualGroup.Width = 120
        actualGroup.TextAlignment = ContentAlignment.MiddleCenter
        actualGroup.ReadOnly = True
        gridView.Columns.Add(actualGroup)

        Dim reqdWorkingDays As New GridViewDecimalColumn("Req'd W. Days")
        reqdWorkingDays.FieldName = "fldReqdWorkingDays"
        reqdWorkingDays.Width = 120
        reqdWorkingDays.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(reqdWorkingDays)

        Dim remarks As New GridViewTextBoxColumn("Remarks")
        remarks.FieldName = "fldRemarks"
        remarks.Width = 200
        remarks.TextAlignment = ContentAlignment.MiddleLeft
        gridView.Columns.Add(remarks)

    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldStatColumn As New GridViewTextBoxColumn("Status")
        fldStatColumn.FieldName = "STATUS"
        fldStatColumn.Width = 60
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.ReadOnly = True
        fldStatColumn.IsPinned = True
        fldStatColumn.PinPosition = PinnedColumnPosition.Right
        gridView.Columns.Add(fldStatColumn)

        Dim id As New GridViewDecimalColumn("ID")
        id.FieldName = "fldID"
        id.Width = 80
        id.TextAlignment = ContentAlignment.MiddleCenter
        id.ReadOnly = True
        id.IsVisible = False
        gridView.Columns.Add(id)

        Dim year As New GridViewDecimalColumn("Year")
        year.FieldName = "fldYear"
        year.Width = 100
        year.TextAlignment = ContentAlignment.MiddleCenter
        year.ReadOnly = True
        year.IsVisible = False
        gridView.Columns.Add(year)

        Dim month As New GridViewDecimalColumn("Month")
        month.FieldName = "fldMonth"
        month.Width = 150
        month.TextAlignment = ContentAlignment.MiddleCenter
        month.ReadOnly = True
        month.IsVisible = False
        gridView.Columns.Add(month)

        Dim monthName As New GridViewTextBoxColumn("Month Name")
        monthName.FieldName = "fldMonthName"
        monthName.Width = 150
        monthName.TextAlignment = ContentAlignment.MiddleCenter
        monthName.ReadOnly = True
        monthName.IsVisible = False
        gridView.Columns.Add(monthName)

        Dim sharingCode As New GridViewTextBoxColumn("Line Sh. Code *")
        sharingCode.FieldName = "fldSharingCode"
        sharingCode.Width = 150
        sharingCode.ReadOnly = True
        sharingCode.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(sharingCode)

        Dim lineCode As New GridViewTextBoxColumn("Line Code")
        lineCode.FieldName = "fldLineCode"
        lineCode.Width = 150
        lineCode.TextAlignment = ContentAlignment.MiddleCenter
        lineCode.ReadOnly = True
        lineCode.IsVisible = False
        gridView.Columns.Add(lineCode)

        Dim lineName As New GridViewTextBoxColumn("Line Name *")
        lineName.FieldName = "fldLineName"
        lineName.Width = 150
        lineName.PinPosition = PinnedColumnPosition.Left
        lineName.TextAlignment = ContentAlignment.MiddleCenter
        lineName.ReadOnly = True
        lineName.IsPinned = True
        gridView.Columns.Add(lineName)

        Dim modelName As New GridViewTextBoxColumn("Model Name")
        modelName.FieldName = "fldModelName"
        modelName.Width = 150
        modelName.IsPinned = True
        modelName.PinPosition = PinnedColumnPosition.Left
        modelName.TextAlignment = ContentAlignment.MiddleCenter
        modelName.ReadOnly = True
        gridView.Columns.Add(modelName)

        Dim modelCode As New GridViewTextBoxColumn("Model Code")
        modelCode.FieldName = "fldModelCode"
        modelCode.Width = 150
        modelCode.TextAlignment = ContentAlignment.MiddleCenter
        modelCode.ReadOnly = True
        modelCode.IsVisible = False
        gridView.Columns.Add(modelCode)

        Dim model As New GridViewTextBoxColumn("Model *")
        model.FieldName = "fldModel"
        model.Width = 150
        model.TextAlignment = ContentAlignment.MiddleCenter
        model.ReadOnly = True
        model.IsVisible = False
        gridView.Columns.Add(model)

        Dim partName As New GridViewTextBoxColumn("Part Name *")
        partName.FieldName = "fldPartName"
        partName.Width = 200
        partName.TextAlignment = ContentAlignment.MiddleCenter
        partName.ReadOnly = True
        partName.IsVisible = False
        gridView.Columns.Add(partName)

        Dim customerCode As New GridViewTextBoxColumn("Customer Code")
        customerCode.FieldName = "fldCustomerCode"
        customerCode.Width = 150
        customerCode.TextAlignment = ContentAlignment.MiddleCenter
        customerCode.ReadOnly = True
        customerCode.IsVisible = False
        gridView.Columns.Add(customerCode)

        Dim customerName As New GridViewTextBoxColumn("Customer Name *")
        customerName.FieldName = "fldCustomerName"
        customerName.Width = 150
        customerName.TextAlignment = ContentAlignment.MiddleCenter
        customerName.ReadOnly = True
        customerName.IsVisible = False
        gridView.Columns.Add(customerName)

        Dim lineNo As New GridViewDecimalColumn("Line No.")
        lineNo.FieldName = "fldLineNumber"
        lineNo.Width = 100
        lineNo.TextAlignment = ContentAlignment.MiddleCenter
        lineNo.ReadOnly = True
        lineNo.IsVisible = False
        gridView.Columns.Add(lineNo)

        Dim priority As New GridViewDecimalColumn("Priority")
        priority.FieldName = "fldPriority"
        priority.Width = 100
        priority.TextAlignment = ContentAlignment.MiddleCenter
        priority.ReadOnly = True
        priority.IsVisible = False
        gridView.Columns.Add(priority)

        Dim ct As New GridViewDecimalColumn("C.T.")
        ct.FieldName = "fldCT"
        ct.Width = 100
        ct.TextAlignment = ContentAlignment.MiddleRight
        ct.ThousandsSeparator = True
        ct.ReadOnly = True
        gridView.Columns.Add(ct)
        gridView.Columns("fldCT").FormatString = "{0:N0}"

        Dim oa As New GridViewDecimalColumn("O.A. (%)")
        oa.FieldName = "fldOA"
        oa.Width = 100
        oa.TextAlignment = ContentAlignment.MiddleRight
        oa.ReadOnly = True
        gridView.Columns.Add(oa)
        gridView.Columns("fldOA").FormatString = "{0:#,##0.00}"

        Dim capacityPerHour As New GridViewDecimalColumn("Cap. Per Hour")
        capacityPerHour.FieldName = "fldCapacityPerHour"
        capacityPerHour.Width = 100
        capacityPerHour.TextAlignment = ContentAlignment.MiddleRight
        capacityPerHour.ThousandsSeparator = True
        capacityPerHour.ReadOnly = True
        gridView.Columns.Add(capacityPerHour)
        gridView.Columns("fldCapacityPerHour").FormatString = "{0:N0}"

        Dim capacityPerShift As New GridViewDecimalColumn("Cap. Per Shift")
        capacityPerShift.FieldName = "fldCapacityPerShift"
        capacityPerShift.Width = 100
        capacityPerShift.TextAlignment = ContentAlignment.MiddleRight
        capacityPerShift.ThousandsSeparator = True
        capacityPerShift.ReadOnly = True
        gridView.Columns.Add(capacityPerShift)
        gridView.Columns("fldCapacityPerShift").FormatString = "{0:N0}"

        Dim lastMonthEndingStock As New GridViewDecimalColumn("Beginning Stocks *")
        lastMonthEndingStock.FieldName = "fldLastMonthEndingStock"
        lastMonthEndingStock.Width = 100
        lastMonthEndingStock.TextAlignment = ContentAlignment.MiddleRight
        lastMonthEndingStock.ThousandsSeparator = True
        gridView.Columns.Add(lastMonthEndingStock)

        Dim demand As New GridViewDecimalColumn("Demand")
        demand.FieldName = "fldLatestDemand"
        demand.Width = 100
        demand.TextAlignment = ContentAlignment.MiddleRight
        demand.ThousandsSeparator = True
        demand.ReadOnly = True
        gridView.Columns.Add(demand)
        gridView.Columns("fldLatestDemand").FormatString = "{0:N0}"

        Dim productionPlan As New GridViewDecimalColumn("Production Plan *")
        productionPlan.FieldName = "fldProductionPlan"
        productionPlan.Width = 100
        productionPlan.TextAlignment = ContentAlignment.MiddleRight
        productionPlan.ThousandsSeparator = True
        gridView.Columns.Add(productionPlan)

        Dim advanceDelivery As New GridViewDecimalColumn("Adv. Delivery *")
        advanceDelivery.FieldName = "fldAdvanceDelivery"
        advanceDelivery.Width = 100
        advanceDelivery.TextAlignment = ContentAlignment.MiddleRight
        advanceDelivery.ThousandsSeparator = True
        gridView.Columns.Add(advanceDelivery)
        gridView.Columns("fldAdvanceDelivery").FormatString = "{0:N0}"

        Dim firstWeekDelivery As New GridViewDecimalColumn("1st Wk. Delivery *")
        firstWeekDelivery.FieldName = "fldFirstWeekDelivery"
        firstWeekDelivery.Width = 100
        firstWeekDelivery.TextAlignment = ContentAlignment.MiddleRight
        firstWeekDelivery.ThousandsSeparator = True
        gridView.Columns.Add(firstWeekDelivery)
        gridView.Columns("fldFirstWeekDelivery").FormatString = "{0:N0}"

    End Sub

End Class
