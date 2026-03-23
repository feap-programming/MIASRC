Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmNewAssyDailyReport
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    'Dim Maria As New DB("localhost", "dbmia", "root", "password")
    Private Sub FrmNewAssyDailyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged
        GridCol()
        GetModels()
        tpFrom.Value = Now
        tpTo.Value = Now
        dpDate.Value = Now

        ddModel.Text = My.Settings.setSRCModel
        spnLine.Value = My.Settings.setSRCLine
        AddHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged
    End Sub
    Private Sub GetModels()

        Dim DTModel As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")

        ddModel.DataSource = DTModel
        ddModel.DisplayMember = "fldModelName"
        ddModel.ValueMember = "fldCode"
        ddModel.AutoCompleteDataSource = DTModel
        ddModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModel.AutoCompleteDisplayMember = "fldModelName"
        ddModel.AutoCompleteValueMember = "fldCode"
        ddModel.Text = ""

    End Sub
    Private Sub GridCol()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = True
        gvData.Columns.Add(fldID)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "Model"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.Width = 150
        gvData.Columns.Add(fldModel)

        Dim fldCode As New GridViewTextBoxColumn
        fldCode.HeaderText = "Model Code"
        fldCode.FieldName = "fldCode"
        fldCode.TextAlignment = ContentAlignment.MiddleCenter
        fldCode.Width = 150
        fldCode.IsVisible = False
        gvData.Columns.Add(fldCode)

        Dim fldLineNo As New GridViewTextBoxColumn
        fldLineNo.HeaderText = "Line No"
        fldLineNo.FieldName = "fldLineNo"
        fldLineNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLineNo.Width = 80
        gvData.Columns.Add(fldLineNo)

        Dim fldDate As New GridViewTextBoxColumn
        fldDate.HeaderText = "Date"
        fldDate.FieldName = "fldDate"
        fldDate.TextAlignment = ContentAlignment.MiddleCenter
        fldDate.Width = 150
        gvData.Columns.Add(fldDate)

        Dim fldShift As New GridViewTextBoxColumn
        fldShift.HeaderText = "Shift"
        fldShift.FieldName = "fldShift"
        fldShift.TextAlignment = ContentAlignment.MiddleCenter
        fldShift.Width = 150
        gvData.Columns.Add(fldShift)

        Dim fldTimeFrom As New GridViewDateTimeColumn
        fldTimeFrom.HeaderText = "From"
        fldTimeFrom.FieldName = "fldTimeFrom"
        fldTimeFrom.TextAlignment = ContentAlignment.MiddleCenter
        fldTimeFrom.Width = 150
        fldTimeFrom.FormatString = "{0:HH':'mm}"
        gvData.Columns.Add(fldTimeFrom)

        Dim fldTimeTo As New GridViewDateTimeColumn
        fldTimeTo.HeaderText = "To"
        fldTimeTo.FieldName = "fldTimeTo"
        fldTimeTo.TextAlignment = ContentAlignment.MiddleCenter
        fldTimeTo.Width = 150
        fldTimeTo.FormatString = "{0:HH':'mm}"
        gvData.Columns.Add(fldTimeTo)

        Dim fldGroup As New GridViewTextBoxColumn
        fldGroup.HeaderText = "Group"
        fldGroup.FieldName = "fldGroup"
        fldGroup.TextAlignment = ContentAlignment.MiddleCenter
        fldGroup.Width = 80
        gvData.Columns.Add(fldGroup)

        Dim fldAddedBy As New GridViewTextBoxColumn
        fldAddedBy.HeaderText = "Added By"
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedBy.Width = 80
        gvData.Columns.Add(fldAddedBy)

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If ddModel.Text = "" Then
            RadMessageBox.Show("Model is required")
        ElseIf spnLine.Value = 0 Then
            RadMessageBox.Show("Line number is required")
        ElseIf dpDate.Value = Nothing Then
            RadMessageBox.Show("Date is required")
        ElseIf spnGroup.Value = 0 Then
            RadMessageBox.Show("Group is required")
        Else

            Maria.AddMySqlParameters("parModel", ddModel.SelectedValue)
            Maria.AddMySqlParameters("parDate", dpDate.Value)
            Maria.AddMySqlParameters("parShift", ddShift.Text)
            Maria.AddMySqlParameters("parLine", spnLine.Value)
            Dim checkexist As DataTable = Maria.SPSelect("SP_SelectAssyDailyReport2")

            If checkexist.Rows.Count >= 1 Then
                RadMessageBox.Show("Already Added!")
            Else
                Dim DateFrom As DateTime = tpFrom.Value
                Dim DateFromStr As String = DateFrom.ToString("HH:mm:ss")

                Dim DateTo As DateTime = tpTo.Value
                Dim DateToStr As String = DateTo.ToString("HH:mm:ss")

                Dim lastDay As DateTime = New DateTime(dpDate.Value.Year, dpDate.Value.Month, DateTime.DaysInMonth(dpDate.Value.Year, dpDate.Value.Month))
                Dim lastDayOfMonth As Integer = convert.ToInt32(lastDay.Day)
                Dim DTToMonth As Integer
                DTToMonth = dpDate.Value.Month
                If dpDate.Value.Day = lastDayOfMonth AndAlso ddShift.Text.ToString() = "10PM-6AM(3rd Shift)" Then
                    DTToMonth += 1
                ElseIf dpDate.Value.Day = lastDayOfMonth AndAlso ddShift.Text.ToString() = "6PM-6AM" Then
                    DTToMonth += 1

                    End If

                Dim DTFrom As DateTime = Convert.ToDateTime(Year(dpDate.Value) & "-" & Month(dpDate.Value) & "-" & dpDate.Value.ToString("dd") & " " & DateFromStr)
                Dim DTTo As DateTime

                    If tpFrom.Value > tpTo.Value Or ddShift.SelectedIndex = 3 Then
                    DTTo = Convert.ToDateTime(Year(dpDate.Value) & "-" & DTToMonth & "-" & DateAdd("d", 1, dpDate.Value).ToString("dd") & " " & DateToStr)
                Else
                    DTTo = Convert.ToDateTime(Year(dpDate.Value) & "-" & DTToMonth & "-" & dpDate.Value.ToString("dd") & " " & DateToStr)
                End If


                    Maria.AddMySqlParameters("parModel", ddModel.SelectedValue)
                    Maria.AddMySqlParameters("parLine", spnLine.Value)
                    Maria.AddMySqlParameters("parDate", dpDate.Value)
                    Maria.AddMySqlParameters("parShift", ddShift.Text)
                    Maria.AddMySqlParameters("parFrom", DTFrom)
                    Maria.AddMySqlParameters("parTo", DTTo)
                    Maria.AddMySqlParameters("parGroup", spnGroup.Value)
                    Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))
                    Maria.SPADE("SP_SRC_InsertDailyReport2")
                    RadMessageBox.Show("Data Added!")
                    ReloadGrid()
                End If

            End If

    End Sub

    Private Sub ddModel_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddModel.SelectedIndexChanged
        My.Settings.setSRCModel = ddModel.Text
        ReloadGrid()
    End Sub

    Private Sub spnLine_ValueChanged(sender As Object, e As EventArgs) Handles spnLine.ValueChanged
        My.Settings.setSRCLine = spnLine.Value
    End Sub
    Private Sub ReloadGrid()
        gvData.DataSource = Maria.MyQuery("SELECT DR.fldID,DR.fldModel as fldCode,ML.fldModelName as fldModel,DR.fldLineNo,DR.fldDate,DR.fldShift,DR.fldTimeFrom,DR.fldTimeTo,DR.fldGroup, DR.fldAddedBy FROM tblDailyReportSRC DR join tblModelList ML on DR.fldModel=ML.fldCode order by  DR.fldID desc;")
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadGrid()
    End Sub

    Private Sub cbbDailyReport_Click(sender As Object, e As EventArgs) Handles cbbDailyReport.Click
        If gvData.Rows.Count <= 0 Then

        Else

            If IsDBNull(gvData.CurrentRow.Cells("fldTimeFrom").Value) Or IsDBNull(gvData.CurrentRow.Cells("fldTimeTo").Value) Then
                RadMessageBox.Show("Time is required!")
            Else
                Mio.DRID = gvData.CurrentRow.Cells("fldID").Value
                Mio.Model = gvData.CurrentRow.Cells("fldModel").Value.ToString
                Mio.ModelCode = gvData.CurrentRow.Cells("fldCode").Value.ToString
                Mio.Line = gvData.CurrentRow.Cells("fldLineNo").Value
                Mio.Type = "ASSY"


                Mio.Shift = gvData.CurrentRow.Cells("fldShift").Value.ToString
                Mio.DRDate = gvData.CurrentRow.Cells("fldDate").Value
                FrmSRCDailyReportNewV2.MdiParent = frmBase
                FrmSRCDailyReportNewV2.Show()
            End If

        End If
    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        Mio.EditAssyID = gvData.CurrentRow.Cells("fldID").Value
        Mio.EditAssyModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
        Mio.EditAssyLine = gvData.CurrentRow.Cells("fldLineNo").Value
        Mio.EditAssyDate = gvData.CurrentRow.Cells("fldDate").Value
        Mio.EditAssyShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
        Try

            Mio.EditAssyTimeFrom = gvData.CurrentRow.Cells("fldTimeFrom").Value
            Mio.EditAssyTimeTo = gvData.CurrentRow.Cells("fldTimeTo").Value

        Catch ex As Exception

            Mio.EditAssyTimeFrom = Nothing
            Mio.EditAssyTimeTo = Nothing
        End Try
        Mio.EditAssyGroup = gvData.CurrentRow.Cells("fldGroup").Value
        FrmEditSRCHeader.ShowDialog()
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            globalVariables.SRCAddedBy = gvData.CurrentRow.Cells("fldAddedBy").Value.ToString()
            globalVariables.parLine = gvData.CurrentRow.Cells("fldLineNo").Value.ToString()
            globalVariables.parDRID = gvData.CurrentRow.Cells("fldID").Value
            globalVariables.parModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
            FrmDeletePassword.ShowDialog()
        Else

            'Maria.AddMySqlParameters("parID", gvData.CurrentRow.Cells("fldID").Value)
            'Maria.SPADE("SP_SRCDailyReportDeleteRecord")
            'RadMessageBox.Show("Item Deleted")
            'ReloadGrid()

        End If
    End Sub

    Private Sub cbbDownTime_Click(sender As Object, e As EventArgs) Handles cbbDownTime.Click
        'FldAssemblyDowntimeMain.MdiParent = frmBase
        globalVariables.DowntimeType = "ASSY"
        FldAssemblyDowntimeMain.Show()
    End Sub

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click
        globalVariables.DailyReportModelZwei = gvData.CurrentRow.Cells("fldModel").Value
        globalVariables.DailyReportDateZwei = gvData.CurrentRow.Cells("fldDate").Value
        globalVariables.DailyRepID = gvData.CurrentRow.Cells("fldID").Value
        globalVariables.ModelCode = gvData.CurrentRow.Cells("fldCode").Value
        'globalVariables.SRCReportType = "Daily Report"
        FrmSRCAssyReportSelector.ShowDialog(Me)
    End Sub

    Private Sub ddShift_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddShift.SelectedIndexChanged
        If ddShift.SelectedIndex = 0 Then
            tpFrom.Value = "6:00 AM"
            tpTo.Value = "2:00 PM"
        ElseIf ddShift.SelectedIndex = 1 Then
            tpFrom.Value = "6:00 AM"
            tpTo.Value = "6:00 PM"
        ElseIf ddShift.SelectedIndex = 2 Then
            tpFrom.Value = "2:00 PM"
            tpTo.Value = "10:00 PM"
        ElseIf ddShift.SelectedIndex = 3 Then
            tpFrom.Value = "6:00 PM"
            tpTo.Value = "6:00 AM"
        ElseIf ddShift.SelectedIndex = 4 Then
            tpFrom.Value = "10:00 PM"
            tpTo.Value = "6:00 AM"
        End If
    End Sub
End Class
