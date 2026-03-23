Imports System.IO
Imports ClosedXML.Excel
Imports FEAPNS.DataAccess
Imports Org.BouncyCastle.Crypto.Tls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmProdDailyReportSRC
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim DTExcelManpower, DTExcelHourly, DTExcelSRCAssy, DTExcelDefects, DTExcelLotNo As DataTable
    Private Sub FrmProdDailyReportSRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Slipknot.changeTheme(Me)
        dpDate.Value = DateTime.Now

        RemoveHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged
        GetModels()
        GridCol()

        ddModel.Text = My.Settings.setSRCModel
        spnLine.Value = My.Settings.setSRCLine

        AddHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged

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

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If ddModel.Text = "" Then
            RadMessageBox.Show("Model is required")
        ElseIf spnLine.Value = 0 Then
            RadMessageBox.Show("Line number is required")
        ElseIf dpDate.Value = Nothing Then
            RadMessageBox.Show("Date is required")
        ElseIf ddShift.Text = "" Then
            RadMessageBox.Show("Shift is required")
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
                Maria.AddMySqlParameters("parModel", ddModel.SelectedValue)
                Maria.AddMySqlParameters("parLine", spnLine.Value)
                Maria.AddMySqlParameters("parDate", dpDate.Value)
                Maria.AddMySqlParameters("parShift", ddShift.Text)
                Maria.AddMySqlParameters("parGroup", spnGroup.Value)
                Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))
                Maria.SPADE("SP_SRC_InsertDailyReport")
                RadMessageBox.Show("Data Added!")
                ReloadGrid()
            End If

        End If
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadGrid()
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        Else

            Maria.AddMySqlParameters("parID", gvData.CurrentRow.Cells("fldID").Value)
            Maria.SPADE("SP_SRCDailyReportDeleteRecord")
            RadMessageBox.Show("Item Deleted")
            ReloadGrid()

        End If

    End Sub
    Private Sub ReloadGrid()
        gvData.DataSource = Maria.MyQuery("SELECT DR.fldID,DR.fldModel as fldCode,ML.fldModelName as fldModel,DR.fldLineNo,DR.fldDate,DR.fldShift,DR.fldGroup FROM tblDailyReportSRC DR join tblModelList ML on DR.fldModel=ML.fldCode order by  DR.fldID desc;")
    End Sub

    Private Sub cbbDailyReport_Click(sender As Object, e As EventArgs) Handles cbbDailyReport.Click
        If gvData.Rows.Count <= 0 Then

        Else

            'globalVariables.DailyRepID = gvData.CurrentRow.Cells("fldID").Value
            'globalVariables.ModelCode = gvData.CurrentRow.Cells("fldCode").Value
            'globalVariables.DailyReportModel = gvData.CurrentRow.Cells("fldModel").Value
            'globalVariables.DailyRepShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
            'globalVariables.AssyDownTimeModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
            'globalVariables.AssyDownTimeShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
            'globalVariables.AssyDownTimeDate = gvData.CurrentRow.Cells("fldDate").Value
            'globalVariables.ModelLine = gvData.CurrentRow.Cells("fldLineNo").Value
            'FrmDailyReportData.MdiParent = frmBase
            'FrmDailyReportData.Show()
            'FrmSyncSRC_vb.Show()
            Mio.DRID = gvData.CurrentRow.Cells("fldID").Value
            Mio.Model = gvData.CurrentRow.Cells("fldModel").Value.ToString
            Mio.ModelCode = gvData.CurrentRow.Cells("fldCode").Value.ToString
            Mio.Line = gvData.CurrentRow.Cells("fldLineNo").Value
            Mio.Type = "ASSY"
            Mio.Shift = gvData.CurrentRow.Cells("fldShift").Value.ToString
            Mio.DRDate = gvData.CurrentRow.Cells("fldDate").Value
            FrmSRCDailyReportNew.MdiParent = frmBase
            FrmSRCDailyReportNew.Show()
        End If
    End Sub

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click
        globalVariables.DailyReportModelZwei = gvData.CurrentRow.Cells("fldModel").Value
        globalVariables.DailyReportDateZwei = gvData.CurrentRow.Cells("fldDate").Value
        globalVariables.DailyRepID = gvData.CurrentRow.Cells("fldID").Value
        globalVariables.ModelCode = gvData.CurrentRow.Cells("fldCode").Value
        'globalVariables.SRCReportType = "Daily Report"
        FrmSRCAssyReportSelector.ShowDialog(Me)
    End Sub

    Private Sub cbbDownTime_Click(sender As Object, e As EventArgs) Handles cbbDownTime.Click
        'FldAssemblyDowntimeMain.MdiParent = frmBase
        globalVariables.DowntimeType = "ASSY"
        FldAssemblyDowntimeMain.Show()
    End Sub

    Private Sub ccbOffTemp_Click(sender As Object, e As EventArgs) Handles ccbOffTemp.Click

        If gvData.Rows.Count <= 0 Then

        Else
            globalVariables.DailyRepID = gvData.CurrentRow.Cells("fldID").Value
            globalVariables.ModelCode = gvData.CurrentRow.Cells("fldCode").Value
            globalVariables.DailyReportModel = gvData.CurrentRow.Cells("fldModel").Value
            globalVariables.DailyRepShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
            globalVariables.AssyDownTimeModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
            globalVariables.AssyDownTimeShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
            globalVariables.AssyDownTimeDate = gvData.CurrentRow.Cells("fldDate").Value
            globalVariables.ModelLine = gvData.CurrentRow.Cells("fldLineNo").Value

            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook()
                            workbook.Worksheets.Add(ExcelManpower, "MANPOWER")
                            workbook.Worksheets.Add(ExcelHourly, "HOURLY QUALITY")
                            workbook.Worksheets.Add(ExcelSRCAssy, "SRC ASSEMBLY")
                            workbook.Worksheets.Add(ExcelDefects, "IN PROCESS DEFECTS")
                            workbook.Worksheets.Add(ExcelLotNo, "RM WIP LOT NO")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MessageBox.Show("DONE")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End Using

        End If

    End Sub


    Private Function ExcelManpower() As DataTable
        Dim ManPowerDT As New DataTable
        ManPowerDT.Columns.Add("Assembly Process Name")
        ManPowerDT.Columns.Add("Employee Name")
        ManPowerDT.Columns.Add("Qualified")
        ManPowerDT.Columns.Add("Transferred")
        ManPowerDT.Columns.Add("TRAINEE")

        Maria.AddMySqlParameters("parCode", globalVariables.ModelCode)
        Maria.AddMySqlParameters("parLine", globalVariables.ModelLine)
        For Each row As DataRow In Maria.SPSelect("SP_SRCDailyReport_SelectManpowerTemp2").Rows

            ManPowerDT.Rows.Add(row.Item("fldProcessName").ToString, row.Item("fldEmployee").ToString, False, False, False)

        Next

        Return ManPowerDT
    End Function

    Private Sub cbbUploadDaily_Click(sender As Object, e As EventArgs) Handles cbbUploadDaily.Click
        If gvData.Rows.Count <= 0 Then

        Else

            Try

                'globalVariables.DailyRepID = gvData.CurrentRow.Cells("fldID").Value
                'globalVariables.ModelCode = gvData.CurrentRow.Cells("fldCode").Value
                'globalVariables.DailyReportModel = gvData.CurrentRow.Cells("fldModel").Value
                'globalVariables.DailyRepShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
                'globalVariables.AssyDownTimeModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
                'globalVariables.AssyDownTimeShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
                'globalVariables.AssyDownTimeDate = gvData.CurrentRow.Cells("fldDate").Value
                'globalVariables.AssyDownTimeDateString = gvData.CurrentRow.Cells("fldDate").Value.ToString("MM/dd/yyyy")
                'globalVariables.ModelLine = gvData.CurrentRow.Cells("fldLineNo").Value
                'Dim OwO As New FrmSRCAssyUpload
                'FrmSRCAssyUpload.Show(OwO)
                globalVariables.SRCSyncModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
                globalVariables.SRCSyncDate = gvData.CurrentRow.Cells("fldDate").Value
                globalVariables.SRCSyncShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
                globalVariables.SRCSyncLine = gvData.CurrentRow.Cells("fldLineNo").Value
                globalVariables.SRCSyncID = gvData.CurrentRow.Cells("fldID").Value
                FrmSyncSRC_vb.Show()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub FrmProdDailyReportSRC_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ReloadGrid()
    End Sub

    Private Sub cbbRework_Click(sender As Object, e As EventArgs) Handles cbbRework.Click

        Dim Nya As New FrmReworkingAssy()
        Nya.Show()

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Process.Start("Guide.pdf")
    End Sub

    Private Sub cbbInfo_Click(sender As Object, e As EventArgs) Handles cbbInfo.Click
        Dim DocsInfo As New FrmDocsInfo

        DocsInfo.ShowDialog(Me)
    End Sub

    Private Sub ddModel_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddModel.SelectedIndexChanged
        My.Settings.setSRCModel = ddModel.Text
    End Sub

    Private Sub spnLine_ValueChanged(sender As Object, e As EventArgs) Handles spnLine.ValueChanged
        My.Settings.setSRCLine = spnLine.Value
    End Sub

    Private Function ExcelHourly() As DataTable
        Dim HourlyDT As New DataTable
        HourlyDT.Columns.Add("Time")
        HourlyDT.Columns.Add("Cable Greasing")
        HourlyDT.Columns.Add("Stator Greasing")
        HourlyDT.Columns.Add("Final Product Check")
        HourlyDT.Columns.Add("Rotator (Cavity#)")
        HourlyDT.Columns.Add("Stator (Cavity#)")
        HourlyDT.Columns.Add("Sub Stator (Cavity#)")
        HourlyDT.Columns.Add("Sleeve (Cavity#)")
        HourlyDT.Columns.Add("Barcode No.")
        HourlyDT.Columns.Add("Plan")
        HourlyDT.Columns.Add("Actual")
        HourlyDT.Columns.Add("Electrical(NG Prod. Counter Pcs.)")
        HourlyDT.Columns.Add("Function(NG Prod. Counter Pcs.)")
        HourlyDT.Columns.Add("Final(NG Prod. Counter Pcs.)")

        If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                HourlyDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00", False, False, False, 0, 0, 0, 0, "", 0, 0, 0, 0, 0)
            End While
        ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                HourlyDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00", False, False, False, 0, 0, 0, 0, "", 0, 0, 0, 0, 0)
            End While
        ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
            Dim InitialTime As Integer = 14
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                HourlyDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00", False, False, False, 0, 0, 0, 0, "", 0, 0, 0, 0, 0)
            End While
        ElseIf globalVariables.DailyRepShift = "6PM-6AM" Then
            Dim InitialTime As Integer = 18
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    HourlyDT.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00", False, False, False, 0, 0, 0, 0, "", 0, 0, 0, 0, 0)
                Else
                    HourlyDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00", False, False, False, 0, 0, 0, 0, "", 0, 0, 0, 0, 0)
                End If
            End While
        ElseIf globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then
            Dim InitialTime As Integer = 22
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    HourlyDT.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00", False, False, False, 0, 0, 0, 0, "", 0, 0, 0, 0, 0)
                Else
                    HourlyDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00", False, False, False, 0, 0, 0, 0, "", 0, 0, 0, 0, 0)
                End If
            End While
        End If
        Return HourlyDT
    End Function
    Private Function ExcelSRCAssy() As DataTable
        Dim SRCAssyDT As New DataTable
        SRCAssyDT.Columns.Add("Part No.")
        SRCAssyDT.Columns.Add("Part Name")
        SRCAssyDT.Columns.Add("Lot No")
        SRCAssyDT.Columns.Add("Scrap Qty")
        SRCAssyDT.Columns.Add("Purge Qty")
        SRCAssyDT.Columns.Add("QA Sample")
        SRCAssyDT.Columns.Add("Engineering Sample")


        For Each row As DataRow In Maria.MyQuery("SELECT * FROM tblDailyReportSRCAssyTemplate where fldModel='" & globalVariables.ModelCode & "' and fldLine=" & globalVariables.ModelLine & "").Rows

            SRCAssyDT.Rows.Add(row.Item("fldPartNo").ToString, row.Item("fldPartName").ToString)

        Next

        Return SRCAssyDT
    End Function

    Private Function ExcelDefects() As DataTable
        Dim DefectsDT As New DataTable
        DefectsDT.Columns.Add(" ")
        DefectsDT.Columns.Add("Defective Code")
        DefectsDT.Columns.Add("Part Name")
        DefectsDT.Columns.Add("Man")
        DefectsDT.Columns.Add("Machine")
        DefectsDT.Columns.Add("IM")
        DefectsDT.Columns.Add("FFC")
        DefectsDT.Columns.Add("Sub-Assy")
        DefectsDT.Columns.Add("RM")

        DefectsDT.Rows.Add("A. Function Tester")
        DefectsDT.Rows.Add(" ", "Torque Error")
        DefectsDT.Rows.Add(" ", "Weld Error")

        DefectsDT.Rows.Add("B. Electrical Tester")
        DefectsDT.Rows.Add(" ", "I/R Error")
        DefectsDT.Rows.Add(" ", "Mis-Insertion")
        DefectsDT.Rows.Add(" ", "Pattern Error")
        DefectsDT.Rows.Add(" ", "Pattern Open")
        DefectsDT.Rows.Add(" ", "Pattern Short")
        DefectsDT.Rows.Add(" ", "Shortbar")

        DefectsDT.Rows.Add("C. Final Tester")
        DefectsDT.Rows.Add(" ")

        DefectsDT.Rows.Add("D. Others")
        DefectsDT.Rows.Add(" ")
        Return DefectsDT
    End Function

    Private Function ExcelLotNo() As DataTable
        Dim LotNoDT As New DataTable
        LotNoDT.Columns.Add("Time")
        LotNoDT.Columns.Add("Box/Cart No.")

        Dim OwOSpace As String = " "
        For Each row As DataRow In Maria.MyQuery("SELECT fldPartName FROM tblDailyReportSRCRawMatsTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLine & "").Rows

            LotNoDT.Columns.Add(row.Item("fldPartName").ToString)
            LotNoDT.Columns.Add("Cav No" & OwOSpace)
            OwOSpace = OwOSpace & " "
        Next

        If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                LotNoDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
            End While
        ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                LotNoDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
            End While
        ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
            Dim InitialTime As Integer = 14
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                LotNoDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
            End While
        ElseIf globalVariables.DailyRepShift = "6PM-6AM" Then
            Dim InitialTime As Integer = 18
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    LotNoDT.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                Else
                    LotNoDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                End If

            End While
        ElseIf globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then
            Dim InitialTime As Integer = 22
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1L
                    LotNoDT.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                Else
                    LotNoDT.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                End If
            End While
        End If

        LotNoDT.Rows.Add("Component Scrap QTY")
        LotNoDT.Rows.Add("QA (QC) Sample")
        LotNoDT.Rows.Add("Eng'g Sample")
        Return LotNoDT
    End Function

End Class
