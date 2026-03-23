Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.NativeMethods
Imports Telerik.WinControls.UI

Public Class FrmWeldingUpload
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    'Dim Maria As New DB("localhost", "dbmia", "root", "password")
    Dim dtManpower As New DataTable
    Dim dtGoodQty As New DataTable
    Dim dtGoodQtyTemp As New DataTable
    Dim dtDefects As New DataTable
    Dim dtLotNo As New DataTable
    Dim dtLotNoTemp As New DataTable
    Dim dtHourly As New DataTable
    Dim dtHourlyTemp As New DataTable

    Dim ExcelManpower As New DataTable
    Dim ExcelGoodQty As New DataTable
    Dim ExcelDefect As New DataTable
    Dim ExcelLotNo As New DataTable
    Dim ExcelHourly As New DataTable
    Dim CurrentProg As String = ""
    Dim DefectTemp As New DataTable
    Private Sub FrmWeldingUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefectTemp.Columns.Add("In Process Defects")
        DefectTemp.Columns.Add("Part Name")
        DefectTemp.Columns.Add("fldType")
        DefectTemp.Columns.Add("fldVal")
    End Sub
    Private Sub CleanUp()

        gvDataManpower.DataSource = Nothing
        gvDefect.DataSource = Nothing
        gvGQ.DataSource = Nothing
        gvHourly.DataSource = Nothing
        gvLot.DataSource = Nothing

        dtManpower.Reset()
        dtGoodQty.Reset()
        dtGoodQtyTemp.Reset()
        dtDefects.Reset()
        dtLotNo.Reset()
        dtLotNoTemp.Reset()
        dtHourly.Reset()
        dtHourlyTemp.Reset()
        ExcelManpower.Reset()
        ExcelGoodQty.Reset()
        ExcelHourly.Reset()
        ExcelDefect.Reset()
        ExcelLotNo.Reset()

    End Sub
    Dim GetWeldingNo As New DataTable
    Dim GetLotNo As New DataTable
    Private Sub cbbOpen_Click(sender As Object, e As EventArgs) Handles cbbOpen.Click

        OpenFileDialog.ShowDialog()

        If OpenFileDialog.FileName = "" Or OpenFileDialog.FileName = "OpenFileDialog1" Then

        Else
            CleanUp()

            dtGoodQtyTemp.Columns.Add("Welding No.")
            dtGoodQtyTemp.Columns.Add("Part Name")
            dtGoodQtyTemp.Columns.Add("Quantity")

            dtLotNoTemp.Columns.Add("Lot No")
            dtLotNoTemp.Columns.Add("Time")
            dtLotNoTemp.Columns.Add("Machine No.")
            dtLotNoTemp.Columns.Add("Box No (1)")
            dtLotNoTemp.Columns.Add("Box No (2)")
            dtLotNoTemp.Columns.Add("Part Name")
            dtLotNoTemp.Columns.Add("Value")
            dtLotNoTemp.Columns.Add("Cav #")

            dtHourlyTemp.Columns.Add("Welding No")
            dtHourlyTemp.Columns.Add("Time")
            dtHourlyTemp.Columns.Add("Plan")
            dtHourlyTemp.Columns.Add("Actual")
            dtHourlyTemp.Columns.Add("Checked By")
            dtHourlyTemp.Columns.Add("Remarks")

            Dim FilePath As String = OpenFileDialog.FileName
            Dim path As String = Environment.CurrentDirectory + "\Ephemeral\Dupe.xlsx"
            My.Computer.FileSystem.CopyFile(FilePath, Environment.CurrentDirectory + "\Ephemeral\Dupe.xlsx", overwrite:=True)

            Using con As OleDb.OleDbConnection = New OleDb.OleDbConnection()

                con.ConnectionString = String.Format("Provider={0};Data Source={1};Extended Properties=""Excel 12.0 XML;HDR=Yes;""", "Microsoft.ACE.OLEDB.12.0", path)

                If globalVariables.SRCReportType = "FW" Then
                    If globalVariables.FWGroup = 1 Or globalVariables.FWGroup = 2 Then

                        GetWeldingNo = Maria.MyQuery("Select distinct fldPWFWNo FROM dbMIA.tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "' and fldGroup=" & globalVariables.FWGroup & "")
                        GetLotNo = Maria.MyQuery("Select distinct fldAssyNo FROM dbMIA.tblDailyReportWeldingTemplateLotNo where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "' and fldGroup=" & globalVariables.FWGroup & "")

                    Else

                        GetWeldingNo = Maria.MyQuery("Select distinct fldPWFWNo FROM dbMIA.tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")
                        GetLotNo = Maria.MyQuery("Select distinct fldAssyNo FROM dbMIA.tblDailyReportWeldingTemplateLotNo where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")

                    End If
                Else

                    GetWeldingNo = Maria.MyQuery("Select distinct fldPWFWNo FROM dbMIA.tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")
                    GetLotNo = Maria.MyQuery("Select distinct fldAssyNo FROM dbMIA.tblDailyReportWeldingTemplateLotNo where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")

                End If

                '--------------- Manpower ---------------
                For Each row As DataRow In GetWeldingNo.AsEnumerable
                    Dim OwOString As String = "SELECT * FROM [MANPOWER " & row.Item("fldPWFWNo").ToString & "$]"
                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(OwOString, con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            con.Open()
                            da.Fill(dtManpower)
                            con.Close()
                        End Using
                    End Using
                Next
                '--------------- Good Qty ---------------
                For Each row As DataRow In GetWeldingNo.AsEnumerable
                    Dim OwOString As String = "SELECT * FROM [GOOD QTY " & row.Item("fldPWFWNo").ToString & "$]"
                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(OwOString, con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            con.Open()
                            da.Fill(dtGoodQty)
                            con.Close()
                        End Using
                    End Using

                    Dim Adrestia As Integer = 1

                    While Adrestia <= dtGoodQty.Columns.Count - 1

                        dtGoodQtyTemp.Rows.Add(row.Item("fldPWFWNo").ToString, dtGoodQty.Columns(Adrestia).ColumnName, dtGoodQty.Rows(0).Item(Adrestia))
                        Adrestia = Adrestia + 1

                    End While
                    dtGoodQty.Reset()
                Next
                '--------------- Hourly ---------------
                For Each row As DataRow In GetWeldingNo.AsEnumerable
                    Dim OwOString As String = "SELECT * FROM [HOURLY " & row.Item("fldPWFWNo").ToString & "$]"
                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(OwOString, con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            con.Open()
                            da.Fill(dtHourly)
                            con.Close()
                        End Using
                    End Using

                    Dim Adrestia As Integer = 0

                    While Adrestia <= dtHourly.Rows.Count - 1

                        dtHourlyTemp.Rows.Add(row.Item("fldPWFWNo").ToString, dtHourly.Rows(Adrestia).Item(1).ToString, dtHourly.Rows(Adrestia).Item(2), dtHourly.Rows(Adrestia).Item(3), dtHourly.Rows(Adrestia).Item(4).ToString, dtHourly.Rows(Adrestia).Item(5).ToString)
                        Adrestia = Adrestia + 1

                    End While
                    dtHourly.Reset()
                Next
                '--------------- Defects ---------------
                Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [DEFECTS$]", con)
                    Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        con.Open()
                        da.Fill(dtDefects)
                        con.Close()
                    End Using
                End Using
                '--------------- Lot No ---------------
                For Each row As DataRow In GetLotNo.AsEnumerable
                    Dim OwOString As String = "SELECT * FROM [LOT " & row.Item("fldAssyNo").ToString & "$]"
                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(OwOString, con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            con.Open()
                            da.Fill(dtLotNo)
                            con.Close()
                        End Using
                    End Using

                    Dim Adrestia As Integer = 5


                    While Adrestia <= dtLotNo.Columns.Count - 1

                        Dim Celestia As Integer = 0
                        While Celestia <= dtLotNo.Rows.Count - 1
                            dtLotNoTemp.Rows.Add(row.Item("fldAssyNo").ToString, dtLotNo.Rows(Celestia).Item(1), dtLotNo.Rows(Celestia).Item(2), dtLotNo.Rows(Celestia).Item(3), dtLotNo.Rows(Celestia).Item(4), dtLotNo.Columns(Adrestia).ColumnName, dtLotNo.Rows(Celestia).Item(Adrestia), dtLotNo.Rows(Celestia).Item(Adrestia))
                            Celestia = Celestia + 1
                        End While

                        Adrestia = Adrestia + 2

                    End While
                    dtLotNo.Reset()

                Next
            End Using
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim OpenProgress As Integer = 0
        Dim percent As Integer = OpenProgress
        '---------- Col Manpower

        ExcelManpower.Columns.Add("Welding No.")
        ExcelManpower.Columns.Add("Assembly Process Name")
        ExcelManpower.Columns.Add("Employee Name")
        ExcelManpower.Columns.Add("Qualified")
        ExcelManpower.Columns.Add("Transferred")
        ExcelManpower.Columns.Add("TRAINEE")

        For Each dr As DataRow In dtManpower.Rows
            Try
                ExcelManpower.Rows.Add(dr.ItemArray)
            Catch ex As Exception

            End Try
        Next

        Threading.Thread.Sleep(80)
        CurrentProg = "Opening Manpower"
        OpenProgress = OpenProgress + 20
        percent = OpenProgress
        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))

        '--------------- Col Good Qty
        Dim WeldNo As New GridViewTextBoxColumn
        WeldNo.HeaderText = "Welding No."
        WeldNo.FieldName = "Welding No."
        WeldNo.TextAlignment = ContentAlignment.MiddleCenter
        WeldNo.Width = 150
        gvGQ.Columns.Add(WeldNo)

        Dim PartNameGQ As New GridViewTextBoxColumn
        PartNameGQ.HeaderText = "Part Name"
        PartNameGQ.FieldName = "Part Name"
        PartNameGQ.TextAlignment = ContentAlignment.MiddleCenter
        PartNameGQ.Width = 150
        gvGQ.Columns.Add(PartNameGQ)

        Dim QTY As New GridViewTextBoxColumn
        QTY.HeaderText = "Quantity"
        QTY.FieldName = "Quantity"
        QTY.TextAlignment = ContentAlignment.MiddleCenter
        QTY.Width = 150
        gvGQ.Columns.Add(QTY)

        ExcelGoodQty = dtGoodQtyTemp

        Threading.Thread.Sleep(80)
        CurrentProg = "Opening Good Qty."
        OpenProgress = OpenProgress + 20
        percent = OpenProgress
        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))

        '--------------- Col Hourly

        Dim WeldNoHourly As New GridViewTextBoxColumn
        WeldNoHourly.HeaderText = "Welding No."
        WeldNoHourly.FieldName = "Welding No"
        WeldNoHourly.TextAlignment = ContentAlignment.MiddleCenter
        WeldNoHourly.Width = 150
        gvHourly.Columns.Add(WeldNoHourly)

        Dim TimeHourly As New GridViewTextBoxColumn
        TimeHourly.HeaderText = "Time"
        TimeHourly.FieldName = "Time"
        TimeHourly.TextAlignment = ContentAlignment.MiddleCenter
        TimeHourly.Width = 150
        gvHourly.Columns.Add(TimeHourly)

        Dim PlanHourly As New GridViewTextBoxColumn
        PlanHourly.HeaderText = "Plan"
        PlanHourly.FieldName = "Plan"
        PlanHourly.TextAlignment = ContentAlignment.MiddleCenter
        PlanHourly.Width = 80
        gvHourly.Columns.Add(PlanHourly)

        Dim ActualHourly As New GridViewTextBoxColumn
        ActualHourly.HeaderText = "Actual"
        ActualHourly.FieldName = "Actual"
        ActualHourly.TextAlignment = ContentAlignment.MiddleCenter
        ActualHourly.Width = 80
        gvHourly.Columns.Add(ActualHourly)

        Dim CheckByHourly As New GridViewTextBoxColumn
        CheckByHourly.HeaderText = "Check By"
        CheckByHourly.FieldName = "Checked By"
        CheckByHourly.TextAlignment = ContentAlignment.MiddleCenter
        CheckByHourly.Width = 150
        gvHourly.Columns.Add(CheckByHourly)

        Dim RemarksHourly As New GridViewTextBoxColumn
        RemarksHourly.HeaderText = "Remarks"
        RemarksHourly.FieldName = "Remarks"
        RemarksHourly.TextAlignment = ContentAlignment.MiddleCenter
        RemarksHourly.Width = 150
        gvHourly.Columns.Add(RemarksHourly)

        ExcelHourly = dtHourlyTemp

        Threading.Thread.Sleep(80)
        CurrentProg = "Opening Defects"
        OpenProgress = OpenProgress + 20
        percent = OpenProgress
        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))

        '--------------- Col Defects

        If globalVariables.SRCReportType = "FW" Then

            Dim fldProcDef As New GridViewTextBoxColumn
            fldProcDef.HeaderText = "In Process Defects"
            fldProcDef.FieldName = "In Process Defects"
            fldProcDef.TextAlignment = ContentAlignment.MiddleCenter
            fldProcDef.Width = 150
            gvDefect.Columns.Add(fldProcDef)

            Dim fldPart As New GridViewTextBoxColumn
            fldPart.HeaderText = "Part Name"
            fldPart.FieldName = "Part Name"
            fldPart.TextAlignment = ContentAlignment.MiddleCenter
            fldPart.Width = 150
            gvDefect.Columns.Add(fldPart)

            Dim fldType As New GridViewTextBoxColumn
            fldType.HeaderText = "Type"
            fldType.FieldName = "fldType"
            fldType.TextAlignment = ContentAlignment.MiddleCenter
            fldType.Width = 50
            gvDefect.Columns.Add(fldType)

            Dim fldVal As New GridViewTextBoxColumn
            fldVal.HeaderText = "Value"
            fldVal.FieldName = "fldVal"
            fldVal.TextAlignment = ContentAlignment.MiddleCenter
            fldVal.Width = 50
            gvDefect.Columns.Add(fldVal)



            Dim colCount As Integer = dtDefects.Columns.Count
            Dim rowCount As Integer = dtDefects.Rows.Count

            Dim colLoop As Integer = 1
            Dim colNameNo As Integer = 1

            While colLoop <= colCount - 1

                Dim tempPart As String = dtDefects.Columns(colLoop).ColumnName.ToString.Trim
                Dim tempPart2 As String = tempPart.Replace("DEFECTS$.", "")
                Dim tempPart3 As String = ""

                If colNameNo = 1 Then
                    tempPart3 = tempPart2
                Else
                    tempPart3 = tempPart2.Substring(0, tempPart2.Length - 1)
                End If

                Dim tempType As String = dtDefects.Rows(0).Item(colLoop).ToString

                Dim rowLoop As Integer = 2

                While rowLoop <= rowCount
                    DefectTemp.Rows.Add(dtDefects.Rows(rowLoop - 1).Item(0).ToString, tempPart3, tempType, dtDefects.Rows(rowLoop - 1).Item(colLoop).ToString)
                    rowLoop = rowLoop + 1
                End While

                colLoop = colLoop + 1

                If colNameNo >= 3 Then
                    colNameNo = 1
                Else
                    colNameNo = colNameNo + 1
                End If

            End While
            ExcelDefect = DefectTemp
        Else
            Dim DTWip As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldType='" & globalVariables.SRCReportType & "'")
            Dim Pilgrim As New GridViewTextBoxColumn
            Pilgrim.HeaderText = "In Process Defects"
            Pilgrim.FieldName = "In Process Defects"
            Pilgrim.TextAlignment = ContentAlignment.MiddleCenter
            Pilgrim.Width = 150
            gvDefect.Columns.Add(Pilgrim)

            For Each row As DataRow In DTWip.Rows
                'gvDefect.Columns.Add(row.Item("fldPartName").ToString)
                'gvDefect.Columns.Item(row.Item("fldPartName").ToString).Width = 200
                Dim Tetra As New GridViewTextBoxColumn
                Tetra.HeaderText = row.Item("fldPartName").ToString
                Tetra.FieldName = row.Item("fldPartName").ToString
                Tetra.TextAlignment = ContentAlignment.MiddleCenter
                Tetra.Width = 200
                gvDefect.Columns.Add(Tetra)
            Next

            ExcelDefect = dtDefects
        End If

        Threading.Thread.Sleep(80)
        CurrentProg = "Opening Defects"
        OpenProgress = OpenProgress + 20
        percent = OpenProgress
        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))

        '--------------- Col Lot No

        Dim LotNo As New GridViewTextBoxColumn
        LotNo.HeaderText = "Lot No"
        LotNo.FieldName = "Lot No"
        LotNo.TextAlignment = ContentAlignment.MiddleCenter
        LotNo.Width = 150
        gvLot.Columns.Add(LotNo)

        Dim TimeTime As New GridViewTextBoxColumn
        TimeTime.HeaderText = "Time"
        TimeTime.FieldName = "Time"
        TimeTime.TextAlignment = ContentAlignment.MiddleCenter
        TimeTime.Width = 150
        gvLot.Columns.Add(TimeTime)

        Dim MachineNo As New GridViewTextBoxColumn
        MachineNo.HeaderText = "Machine No."
        MachineNo.FieldName = "Machine No."
        MachineNo.TextAlignment = ContentAlignment.MiddleCenter
        MachineNo.Width = 150
        gvLot.Columns.Add(MachineNo)

        Dim BoxNo1 As New GridViewTextBoxColumn
        BoxNo1.HeaderText = "Box No (1)"
        BoxNo1.FieldName = "Box No (1)"
        BoxNo1.TextAlignment = ContentAlignment.MiddleCenter
        BoxNo1.Width = 150
        gvLot.Columns.Add(BoxNo1)

        Dim BoxNo2 As New GridViewTextBoxColumn
        BoxNo2.HeaderText = "Box No (2)"
        BoxNo2.FieldName = "Box No (2)"
        BoxNo2.TextAlignment = ContentAlignment.MiddleCenter
        BoxNo2.Width = 150
        gvLot.Columns.Add(BoxNo2)

        Dim PartName As New GridViewTextBoxColumn
        PartName.HeaderText = "Part Name"
        PartName.FieldName = "Part Name"
        PartName.TextAlignment = ContentAlignment.MiddleCenter
        PartName.Width = 150
        gvLot.Columns.Add(PartName)

        Dim Val As New GridViewTextBoxColumn
        Val.HeaderText = "Value"
        Val.FieldName = "Value"
        Val.TextAlignment = ContentAlignment.MiddleCenter
        Val.Width = 150
        gvLot.Columns.Add(Val)

        Dim CavCav As New GridViewTextBoxColumn
        CavCav.HeaderText = "Cav #"
        CavCav.FieldName = "Cav #"
        CavCav.TextAlignment = ContentAlignment.MiddleCenter
        CavCav.Width = 50
        gvLot.Columns.Add(CavCav)

        ExcelLotNo = dtLotNoTemp

        Threading.Thread.Sleep(80)
        CurrentProg = "Opening Lot No"
        OpenProgress = OpenProgress + 20
        percent = OpenProgress
        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        pbOwO.Text = CurrentProg
        pbOwO.Value1 = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        gvDataManpower.DataSource = ExcelManpower
        gvGQ.DataSource = ExcelGoodQty
        gvHourly.DataSource = ExcelHourly
        gvDefect.DataSource = ExcelDefect
        gvLot.DataSource = ExcelLotNo

        MessageBox.Show("Done!")
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim OpenProgress As Decimal = 0
        Dim percent As Decimal = OpenProgress
        '---------- Col Manpower
        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0;Delete from dbMIA.tblDailyReportWeldingManpowerEmp where fldDRID=" & globalVariables.DailyRepID & ";SET SQL_SAFE_UPDATES = 1;")
        Dim Manpowerint As Integer = 0
        While Manpowerint <= gvDataManpower.Rows.Count - 1
            Dim parDRID As Integer = globalVariables.DailyRepID
            Dim parType As String = globalVariables.SRCReportType
            Dim parFWPWNo As String = gvDataManpower.Rows(Manpowerint).Cells(0).Value.ToString
            Dim parProcName As String = gvDataManpower.Rows(Manpowerint).Cells(1).Value.ToString

            Dim parEmployee As String
            If IsDBNull(gvDataManpower.Rows(Manpowerint).Cells(2).Value.ToString) Then
                parEmployee = "N/A"
            Else
                parEmployee = DirectCast(gvDataManpower.Rows(Manpowerint).Cells(2).Value, String)
            End If

            Dim parQualified As Boolean = gvDataManpower.Rows(Manpowerint).Cells(3).Value
            Dim parTransfer As Boolean = gvDataManpower.Rows(Manpowerint).Cells(4).Value
            Dim parTrainee As Boolean = gvDataManpower.Rows(Manpowerint).Cells(5).Value
            Dim parAddedBy As String = globalVariables.currentUser(1)

            Maria.AddMySqlParameters("parDRID", parDRID)
            Maria.AddMySqlParameters("parType", parType)
            Maria.AddMySqlParameters("parFWPWNo", parFWPWNo)
            Maria.AddMySqlParameters("parProcName", parProcName)
            Maria.AddMySqlParameters("parEmployee", parEmployee)
            Maria.AddMySqlParameters("parQualified", parQualified)
            Maria.AddMySqlParameters("parTransfer", parTransfer)
            Maria.AddMySqlParameters("parTrainee", parTrainee)
            Maria.AddMySqlParameters("parAddedBy", parAddedBy)
            Maria.SPADE("SP_SRCDailyReport_InsertWeldingManpowerEmp")

            Manpowerint = Manpowerint + 1

            Threading.Thread.Sleep(80)
            Dim Bruh As Decimal = 20 / gvDataManpower.Rows.Count
            CurrentProg = "Saving Manpower"
            OpenProgress = OpenProgress + Bruh
            percent = OpenProgress
            BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))

        End While

        '--------------- Col Good Qty
        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0;Delete from dbMIA.tblDailyReportWeldingManpowerGoodQty where fldDRID=" & globalVariables.DailyRepID & ";SET SQL_SAFE_UPDATES = 1;")
        Dim GoodQtyint As Integer = 0
        While GoodQtyint <= gvGQ.Rows.Count - 1
            Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
            Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
            Maria.AddMySqlParameters("parPWFWNo", gvGQ.Rows(GoodQtyint).Cells(0).Value.ToString)
            Maria.AddMySqlParameters("parPartName", gvGQ.Rows(GoodQtyint).Cells(1).Value.ToString)
            If gvGQ.Rows(GoodQtyint).Cells(2).Value Is Nothing Or IsDBNull(gvGQ.Rows(GoodQtyint).Cells(2).Value) Then
                Maria.AddMySqlParameters("parQty", 0)
            Else
                Maria.AddMySqlParameters("parQty", gvGQ.Rows(GoodQtyint).Cells(2).Value)
            End If
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRCDailyReport_InsertWeldingManpowerGoodQty")

            GoodQtyint = GoodQtyint + 1

            Threading.Thread.Sleep(80)
            Dim Bruh As Decimal = 20 / gvGQ.Rows.Count
            CurrentProg = "Saving Good Qty"
            OpenProgress = OpenProgress + Bruh
            percent = OpenProgress
            BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
        End While



        '--------------- Hourly Prod
        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0;Delete from dbMIA.tblDailyReportWeldingHourlyProd where fldDRID=" & globalVariables.DailyRepID & ";SET SQL_SAFE_UPDATES = 1;")

        For rowcounter As Integer = 0 To Me.gvHourly.Rows.Count - 1

            Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
            Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
            Maria.AddMySqlParameters("parFWPWNo", gvHourly.Rows(rowcounter).Cells(0).Value.ToString)
            Maria.AddMySqlParameters("parHour", gvHourly.Rows(rowcounter).Cells(1).Value.ToString)
            Maria.AddMySqlParameters("parPlan", gvHourly.Rows(rowcounter).Cells(2).Value)
            Maria.AddMySqlParameters("parActual", gvHourly.Rows(rowcounter).Cells(3).Value)
            Maria.AddMySqlParameters("parDeviation", gvHourly.Rows(rowcounter).Cells(3).Value - gvHourly.Rows(rowcounter).Cells(2).Value)
            Maria.AddMySqlParameters("parCheckedBy", gvHourly.Rows(rowcounter).Cells(4).Value.ToString)
            Maria.AddMySqlParameters("parRemarks", gvHourly.Rows(rowcounter).Cells(5).Value.ToString)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRCDailyReport_InsertWeldingHourlyProd")

            Threading.Thread.Sleep(80)
            Dim Bruh As Decimal = 20 / gvHourly.Rows.Count
            CurrentProg = "Saving Hourly"
            OpenProgress = OpenProgress + Bruh
            percent = OpenProgress
            BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
        Next

        '--------------- Defects
        If globalVariables.SRCReportType = "FW" Then
            Maria.MyQuery("SET SQL_SAFE_UPDATES = 0;Delete from dbMIA.tblDailyReportWeldingDefectsFW where fldDRID=" & globalVariables.DailyRepID & ";SET SQL_SAFE_UPDATES = 1;")

            For rowcounter As Integer = 0 To Me.gvDefect.Rows.Count - 1

                Try
                    Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                    Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
                    Maria.AddMySqlParameters("parDefects", gvDefect.Rows(rowcounter).Cells(0).Value.ToString)
                    Maria.AddMySqlParameters("parWIP", gvDefect.Rows(rowcounter).Cells(1).Value.ToString)
                    Maria.AddMySqlParameters("parWIPType", gvDefect.Rows(rowcounter).Cells(2).Value.ToString)
                    'Maria.AddMySqlParameters("parQty", gvDefect.Rows(rowcounter).Cells(3).Value.ToString)
                    If gvDefect.Rows(rowcounter).Cells(3).Value.ToString Is Nothing Or IsDBNull(gvDefect.Rows(rowcounter).Cells(3).Value.ToString) Then
                        Maria.AddMySqlParameters("parQty", 0)
                    Else
                        Maria.AddMySqlParameters("parQty", gvDefect.Rows(rowcounter).Cells(3).Value.ToString)
                    End If
                    Maria.AddMySqlParameters("parTableNo", 1)
                    Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                    Maria.SPADE("SP_SRCDailyReport_InsertWeldingDefectsFW")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                Threading.Thread.Sleep(80)
                Dim Bruh As Decimal = 20 / gvDefect.Rows.Count
                CurrentProg = "Saving Defects"
                OpenProgress = OpenProgress + Bruh
                percent = OpenProgress
                BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
            Next
        Else
            Maria.MyQuery("SET SQL_SAFE_UPDATES = 0;Delete from dbMIA.tblDailyReportWeldingDefectsPW where fldDRID=" & globalVariables.DailyRepID & ";SET SQL_SAFE_UPDATES = 1;")

            For rowcounter As Integer = 0 To Me.gvDefect.Rows.Count - 1

                For colcounter As Integer = 1 To Me.gvDefect.Columns.Count - 1
                    Try
                        Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                        Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
                        Maria.AddMySqlParameters("parDefects", gvDefect.Rows(rowcounter).Cells(0).Value.ToString)
                        Maria.AddMySqlParameters("parWIP", gvDefect.Columns(colcounter).FieldName)
                        Maria.AddMySqlParameters("parQty", gvDefect.Rows(rowcounter).Cells(colcounter).Value)
                        Maria.AddMySqlParameters("parTableNo", 1)
                        Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                        Maria.AddMySqlParameters("parOtherDetails", gvDefect.Rows(rowcounter).Cells(colcounter).Value)

                        Maria.SPADE("SP_SRCDailyReport_InsertWeldingDefectsPWv2")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Next
                Threading.Thread.Sleep(80)
                Dim Bruh As Decimal = 20 / gvDefect.Rows.Count
                CurrentProg = "Saving Defects"
                OpenProgress = OpenProgress + Bruh
                percent = OpenProgress
                BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
            Next
        End If


        '--------------- Lot No
        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0;Delete from dbMIA.tblDailyReportWeldingLotNo where fldDRID=" & globalVariables.DailyRepID & ";SET SQL_SAFE_UPDATES = 1;")

        For rowcounter As Integer = 0 To Me.gvLot.Rows.Count - 1

            Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
            Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
            Maria.AddMySqlParameters("parAssyNo", gvLot.Rows(rowcounter).Cells(0).Value.ToString)
            Maria.AddMySqlParameters("parTime", gvLot.Rows(rowcounter).Cells(1).Value.ToString)
            Maria.AddMySqlParameters("parMachineNo", If(gvLot.Rows(rowcounter).Cells(2).Value Is Nothing, 0, gvLot.Rows(rowcounter).Cells(2).Value))
            Maria.AddMySqlParameters("parBoxNo", gvLot.Rows(rowcounter).Cells(3).Value.ToString)
            Maria.AddMySqlParameters("parBoxNo2", gvLot.Rows(rowcounter).Cells(4).Value.ToString)
            Maria.AddMySqlParameters("parPartName", gvLot.Rows(rowcounter).Cells(5).Value.ToString)
            Maria.AddMySqlParameters("parLotNo", If(gvLot.Rows(rowcounter).Cells(6).Value Is Nothing, "", gvLot.Rows(rowcounter).Cells(6).Value.ToString))
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRCDailyReport_InsertWeldingLotNov2")

            Threading.Thread.Sleep(80)
            Dim Bruh As Decimal = 20 / gvLot.Rows.Count
            CurrentProg = "Saving Lot No"
            OpenProgress = OpenProgress + Bruh
            percent = OpenProgress
            BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))

        Next


    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        pbOwO.Text = CurrentProg
        pbOwO.Value1 = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        MessageBox.Show("Done!")
    End Sub
End Class
