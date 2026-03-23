Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmAutoTapingDailyReport
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub FrmAutoTapingDailyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddModel.Text = My.Settings.setSRCModel
        spnLine.Value = My.Settings.setSRCLine
        GridCol()
        GetModels()
        dpDate.Value = Now
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
        fldID.IsVisible = False
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

        Dim fldGroup As New GridViewTextBoxColumn
        fldGroup.HeaderText = "Group"
        fldGroup.FieldName = "fldGroup"
        fldGroup.TextAlignment = ContentAlignment.MiddleCenter
        fldGroup.Width = 80
        gvData.Columns.Add(fldGroup)

        Dim commandColumn2 As New GridViewCommandColumn()
        commandColumn2.Name = "CommandColumn2"
        commandColumn2.UseDefaultText = True
        commandColumn2.DefaultText = "Time"
        commandColumn2.FieldName = "Time"
        commandColumn2.HeaderText = "Time"
        gvData.MasterTemplate.Columns.Add(commandColumn2)
        AddHandler gvData.CommandCellClick, AddressOf gvData_CommandCellClick
    End Sub

    Private Sub gvData_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles gvData.CommandCellClick

        If e.Column.HeaderText = "Time" Then

            Mio.ATDRID = gvData.CurrentRow.Cells("fldID").Value
            Mio.ATType = "AT"
            FrmSRCTime.ShowDialog(Me)

        End If

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If Tohka.InsertAutoTaping(ddModel.Text, spnLine.Value, dpDate.Value, ddShift.Text, spnGroup.Value, globalVariables.currentUser(1)) = False Then
            RadMessageBox.Show("Error Occured")
        End If
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click

        If ddModel.Text = "" Then

            RadMessageBox.Show("Please select model")

        Else

            Try
                ReloadGrid()
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub ReloadGrid()

        gvData.DataSource = Tohka.SelectAutoTaping(ddModel.Text, spnLine.Value)

    End Sub

    Private Sub cbbMaster_Click(sender As Object, e As EventArgs) Handles cbbMaster.Click

        FrmATMaster.ShowDialog(Me)

    End Sub

    Private Sub cbbDailyReport_Click(sender As Object, e As EventArgs) Handles cbbDailyReport.Click
        If gvData.Rows.Count <= 0 Then

        Else

            'If IsDBNull(gvData.CurrentRow.Cells("fldTimeFrom").Value) Or IsDBNull(gvData.CurrentRow.Cells("fldTimeTo").Value) Then
            '    RadMessageBox.Show("Time is required!")
            'Else
            Mio.ATDRID = gvData.CurrentRow.Cells("fldID").Value
                Mio.ATModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
                Mio.ATLine = gvData.CurrentRow.Cells("fldLineNo").Value
                Mio.ATType = "AT"
                Mio.ATShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
                Mio.ATDate = gvData.CurrentRow.Cells("fldDate").Value
                FrmATDailyReport.MdiParent = frmBase
                FrmATDailyReport.Show()
            'End If

        End If
    End Sub

    Private Sub cbbDownTime_Click(sender As Object, e As EventArgs) Handles cbbDownTime.Click
        globalVariables.DowntimeType = "Taping"
        FldAssemblyDowntimeMain.Show()
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

    End Sub

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click
        globalVariables.SRCReportType = "Auto Taping"
        Mio.ReportATDrid = gvData.CurrentRow.Cells("fldID").Value
        Dim DTNo As DataTable = Maria.MyQuery("Select fldMachNo from tblDailyReportATManpowerTemp where fldModel='" & gvData.CurrentRow.Cells("fldModel").Value.ToString & "' and fldLine=" & gvData.CurrentRow.Cells("fldLineNo").Value & "")
        Mio.ReportATNo1 = DTNo.Rows(0).Item("fldMachNo").ToString
        Mio.ReportATNo2 = DTNo.Rows(1).Item("fldMachNo").ToString
        Mio.ReportATModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
        Mio.ReportATShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
        Mio.ReportATDate = gvData.CurrentRow.Cells("fldDate").Value
        Dim DTLotNo As DataTable = Maria.MyQuery("SELECT distinct(fldLotGroup) as fldLotGroup FROM dbMIA.tblDailyReportATLotTemp where fldModel='" & gvData.CurrentRow.Cells("fldModel").Value.ToString & "' and fldLine=" & gvData.CurrentRow.Cells("fldLineNo").Value & "")

        Try
            Mio.ReportATLot1 = DTLotNo.Rows(0).Item("fldLotGroup").ToString
        Catch ex As Exception
            Mio.ReportATLot1 = " "
        End Try
        Try
            Mio.ReportATLot2 = DTLotNo.Rows(1).Item("fldLotGroup").ToString
        Catch ex As Exception
            Mio.ReportATLot2 = " "
        End Try
        Try
            Mio.ReportATLot3 = DTLotNo.Rows(2).Item("fldLotGroup").ToString
        Catch ex As Exception
            Mio.ReportATLot3 = " "
        End Try
        Try
            Mio.ReportATLot4 = DTLotNo.Rows(3).Item("fldLotGroup").ToString
        Catch ex As Exception
            Mio.ReportATLot4 = " "
        End Try
        Try
            Mio.ReportATLot5 = DTLotNo.Rows(4).Item("fldLotGroup").ToString
        Catch ex As Exception
            Mio.ReportATLot5 = " "
        End Try
        FrmSRCDailyReportViewer.Show()
    End Sub
End Class
