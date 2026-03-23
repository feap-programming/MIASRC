Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports System.ComponentModel
Imports System.Linq
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI.Export

Public Class ucModelCapacity

    Private workingDays As Integer
    Private errorMessage As String = String.Empty

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private myData As DataTable
    Private drLineGroup As DataRow()
    Private tblWorkingDays As DataTable
    Private dtModelCapacity As DataTable
    Private dtCustomerDemand As DataTable
    Private dtLineGroup As DataTable

    Private Sub ucModelCapacity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeThemeUC(Me)

        Me.numYear.Value = Year(Date.Today)
        Me.drpMonth.SelectedIndex = Me.drpMonth.FindStringExact(MonthName(Month(Date.Today)))

        Me.SetUpColumnsRWD(Me.gvReqWDays)
        Me.SetUpColumns(Me.gvData)

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork

        Me.dtLineGroup = Me.myDB.SPSelect("SP_P_SelectAllLineGroup")
        Me.drLineGroup = Me.dtLineGroup.Select("fldYear = " & Me.numYear.Value & " AND " &
                                            "fldMonth = " & Me.drpMonth.SelectedIndex + 1 & "")

        Me.tblWorkingDays = Me.myDB.SPSelect("SP_P_SelectWorkingDays")
        Me.workingDays = Me.tblWorkingDays.Select("fldYear = " & Me.numYear.Value & " AND " &
                                                  "fldMonth = " & Me.drpMonth.SelectedIndex + 1 & "")(0).Item("fldWorkingDays")

        Me.myDB.AddMySqlParameters("_year", Me.numYear.Value)
        Me.myDB.AddMySqlParameters("_month", Me.drpMonth.SelectedIndex + 1)
        myData = Me.myDB.SPSelect("SP_P_SelectModelCapacityPreview")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted

        Try

            Me.lblMonthYear.Text = MonthName(Me.drpMonth.SelectedIndex + 1) & " " & Me.numYear.Value.ToString()

            Me.lblWorkingDays.Text = Me.workingDays.ToString()

            gvReqWDays.DataSource = drLineGroup.CopyToDataTable()
            gvReqWDays.BestFitColumns()

            gvData.DataSource = myData
            gvData.BestFitColumns()

            leCountRec.Text = gvData.Rows.Count

        Catch ex As InvalidOperationException

            gvReqWDays.DataSource = Nothing
            gvData.DataSource = Nothing
            leCountRec.Text = gvData.Rows.Count
            RadMessageBox.Show(Me, "Line Group / Model Group might not set for this month", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click

        If Not bwLoadData.IsBusy Then
            bwLoadData.RunWorkerAsync()
        End If

    End Sub

    Private Sub cbbCapacityPlan_Click(sender As Object, e As EventArgs) Handles cbbCapacityPlan.Click
        Dim planningForm As New FrmCapacityPlanning
        planningForm.Show(Me.numYear.Value, Me.drpMonth.SelectedIndex + 1)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub cbbTemplate_Click(sender As Object, e As EventArgs) Handles cbbTemplate.Click
        If gvData.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.gvData)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
            End If

        End If
    End Sub

    Private Sub cbbPreview_Click(sender As Object, e As EventArgs) Handles cbbPreview.Click
        FrmMonthYearSelection.ShowDialog()
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

    Private Sub gvReqWDays_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles gvReqWDays.CellDoubleClick

        Try
            Dim editForm As New FrmEditReqdWorkingDays
            editForm.ShowDialog(e.Row.Cells("fldID").Value)
        Catch ex As System.Reflection.AmbiguousMatchException
            RadMessageBox.Show(Me, "Please select proper row.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Private Sub SetUpColumnsRWD(gridView As RadGridView)

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
        year.IsVisible = False
        gridView.Columns.Add(year)

        Dim month As New GridViewDecimalColumn("Month")
        month.FieldName = "fldMonth"
        month.Width = 100
        month.TextAlignment = ContentAlignment.MiddleCenter
        month.IsVisible = False
        gridView.Columns.Add(month)

        Dim monthName As New GridViewTextBoxColumn("Month Name")
        monthName.FieldName = "fldMonthName"
        monthName.Width = 150
        monthName.TextAlignment = ContentAlignment.MiddleCenter
        monthName.IsVisible = False
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
        year.IsVisible = False
        gridView.Columns.Add(year)

        Dim month As New GridViewDecimalColumn("Month")
        month.FieldName = "fldMonth"
        month.Width = 150
        month.TextAlignment = ContentAlignment.MiddleCenter
        month.IsVisible = False
        gridView.Columns.Add(month)

        Dim monthName As New GridViewTextBoxColumn("Month")
        monthName.FieldName = "fldMonthName"
        monthName.Width = 150
        monthName.TextAlignment = ContentAlignment.MiddleCenter
        monthName.IsVisible = False
        gridView.Columns.Add(monthName)

        Dim sharingCode As New GridViewTextBoxColumn("Line Sh. Code *")
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

        Dim lineName As New GridViewTextBoxColumn("Line Name *")
        lineName.FieldName = "fldLineName"
        lineName.Width = 150
        lineName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(lineName)

        Dim modelName As New GridViewTextBoxColumn("Model Name")
        modelName.FieldName = "fldModelName"
        modelName.Width = 150
        modelName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(modelName)

        Dim model As New GridViewTextBoxColumn("Model *")
        model.FieldName = "fldModel"
        model.Width = 150
        model.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(model)

        Dim partName As New GridViewTextBoxColumn("Part Name *")
        partName.FieldName = "fldPartName"
        partName.Width = 200
        partName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(partName)

        Dim customerName As New GridViewTextBoxColumn("Customer Name *")
        customerName.FieldName = "fldCustomerName"
        customerName.Width = 150
        customerName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(customerName)

        Dim ct As New GridViewDecimalColumn("C.T.")
        ct.FieldName = "fldCT"
        ct.Width = 100
        ct.TextAlignment = ContentAlignment.MiddleRight
        ct.ThousandsSeparator = True
        gridView.Columns.Add(ct)
        gridView.Columns("fldCT").FormatString = "{0:N0}"

        Dim oa As New GridViewDecimalColumn("O.A. (%)")
        oa.FieldName = "fldOA"
        oa.Width = 100
        oa.TextAlignment = ContentAlignment.MiddleRight
        gridView.Columns.Add(oa)
        gridView.Columns("fldOA").FormatString = "{0:#,##0.00}"

        Dim capacityPerHour As New GridViewDecimalColumn("Cap. Per Hour")
        capacityPerHour.FieldName = "fldCapacityPerHour"
        capacityPerHour.Width = 100
        capacityPerHour.TextAlignment = ContentAlignment.MiddleRight
        capacityPerHour.ThousandsSeparator = True
        gridView.Columns.Add(capacityPerHour)
        gridView.Columns("fldCapacityPerHour").FormatString = "{0:N0}"

        Dim capacityPerShift As New GridViewDecimalColumn("Cap. Per Shift")
        capacityPerShift.FieldName = "fldCapacityPerShift"
        capacityPerShift.Width = 100
        capacityPerShift.TextAlignment = ContentAlignment.MiddleRight
        capacityPerShift.ThousandsSeparator = True
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
