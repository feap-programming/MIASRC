Imports DocumentFormat.OpenXml.Wordprocessing
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ucWeldingManpower
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim Kurumi As New Kurumi.DB("192.168.191.252", "dbHRMSlive", "feap", "45|iF$")
    Dim ProdEmp As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim selectedRowIndex As Integer
    Dim dtTimePartition As New DataTable

    Private Sub cbbTemplate_Click(sender As Object, e As EventArgs) Handles cbbTemplate.Click
        FrmWeldingTemplates.ShowDialog()
    End Sub

    Private Sub ucWeldingManpower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler ddType.SelectedIndexChanged, AddressOf ddType_SelectedIndexChanged
        ReloadWelding()
        GridColManPower()

        lblType.Text = globalVariables.SRCReportType & "-"
        'ManpowerPerfGrid()
        Timerelated()
        GridTimePartition()
        lblOpTime.Visible = False

        AddHandler ddType.SelectedIndexChanged, AddressOf ddType_SelectedIndexChanged
    End Sub

    Private Sub SelectTimePartition()
        Maria.AddMySqlParameters("parID", globalVariables.DailyRepID)
        dtTimePartition = Maria.SPSelect("SP_SRCDailyReport_ReportWeldingTimePartition")

    End Sub

    Private Sub Timerelated()

        If globalVariables.DailyRepShift = "1st Shift" Then

            Dim Timeline As String = "06:00-14:00"
            Dim TimeLineMin As Integer = 480

            tbTimePart.Text = Timeline
            spnOPTime.Value = TimeLineMin

        ElseIf globalVariables.DailyRepShift = "Day Shift" Then

            Dim Timeline As String = "06:00-18:00"
            Dim TimeLineMin As Integer = 720

            tbTimePart.Text = Timeline
            spnOPTime.Value = TimeLineMin

        ElseIf globalVariables.DailyRepShift = "2nd Shift" Then

            Dim Timeline As String = "14:00-22:00"
            Dim TimeLineMin As Integer = 480

            tbTimePart.Text = Timeline
            spnOPTime.Value = TimeLineMin

        ElseIf globalVariables.DailyRepShift = "Night Shift" Then

            Dim Timeline As String = "18:00-06:00"
            Dim TimeLineMin As Integer = 720

            tbTimePart.Text = Timeline
            spnOPTime.Value = TimeLineMin

        ElseIf globalVariables.DailyRepShift = "3rd Shift" Then

            Dim Timeline As String = "22:00-06:00"
            Dim TimeLineMin As Integer = 480

            tbTimePart.Text = Timeline
            spnOPTime.Value = TimeLineMin

        End If

        GetDownTime()

    End Sub

    Private Sub GetDownTime()

        If ddType.Text = "" Then
        Else
            Maria.AddMySqlParameters("parDate", globalVariables.DailyReportDate)
            Maria.AddMySqlParameters("parModel", globalVariables.DailyReportModel)
            Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
            Maria.AddMySqlParameters("parShift", globalVariables.DailyRepShift)
            Maria.AddMySqlParameters("parPlan", 1)
            Maria.AddMySqlParameters("parNo", ddType.Text)
            Dim DTPlanned As DataTable = Maria.SPSelect("SP_SRCDailyReport_SelectWeldingDowntimePlanned")

            If DTPlanned.Rows.Count >= 1 Then
                If IsDBNull(DTPlanned.Rows(0).Item("fldTime")) Then
                    spnPlanDT.Value = 0.00
                Else
                    Dim PlanDT As Decimal = DTPlanned.Rows(0).Item("fldTime")
                    If IsDBNull(PlanDT) Then
                        spnPlanDT.Value = 0.00
                    Else
                        spnPlanDT.Value = PlanDT
                    End If
                End If
            Else
                spnPlanDT.Value = 0.00
            End If

            Maria.AddMySqlParameters("parDate", globalVariables.DailyReportDate)
            Maria.AddMySqlParameters("parModel", globalVariables.DailyReportModel)
            Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
            Maria.AddMySqlParameters("parShift", globalVariables.DailyRepShift)
            Maria.AddMySqlParameters("parPlan", 0)
            Maria.AddMySqlParameters("parNo", ddType.Text)
            Dim DTUnplanned As DataTable = Maria.SPSelect("SP_SRCDailyReport_SelectWeldingDowntimePlanned")

            If DTUnplanned.Rows.Count >= 1 Then
                If IsDBNull(DTUnplanned.Rows(0).Item("fldTime")) Then
                    spnUnplanDT.Value = 0.00
                Else
                    Dim UnPlanDT As Decimal = DTUnplanned.Rows(0).Item("fldTime")
                    If IsDBNull(UnPlanDT) Then
                        spnUnplanDT.Value = 0.00
                    Else
                        spnUnplanDT.Value = UnPlanDT
                    End If
                End If

            Else
                spnUnplanDT.Value = 0.00
            End If
        End If

    End Sub

    Private Sub ReloadData()

        Dim DTEmp As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingManpowerEmp where fldDRID=" & globalVariables.DailyRepID & " and fldType='" & globalVariables.SRCReportType & "' and fldFWPWNo='" & ddType.Text & "'")
        Dim DTMain As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingManpower where fldDRID=" & globalVariables.DailyRepID & " and fldType='" & globalVariables.SRCReportType & "' and fldFWPWNo='" & ddType.Text & "'")
        Dim DTGoodQty As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingManpowerGoodQty where fldDRID=" & globalVariables.DailyRepID & " and fldType='" & globalVariables.SRCReportType & "' and fldPWFWNo='" & ddType.Text & "'")

        gvEmpStatus.DataSource = Nothing
        gvEmpStatus.MasterTemplate.Rows.Clear()

        If DTEmp.Rows.Count >= 1 Then

            gvEmpStatus.DataSource = DTEmp

        Else

            ManpowerPerfGrid()

        End If

        If DTMain.Rows.Count >= 1 Then

            spnHotto.Value = Convert.ToDecimal(DTMain.Rows(0).Item("fldStart"))
            'spnPlanDT.Value = Convert.ToDecimal(DTMain.Rows(0).Item("fldPlanned"))
            'spnUnplanDT.Value = Convert.ToDecimal(DTMain.Rows(0).Item("fldUnplanned"))
            'spnOPTime.Value = Convert.ToDecimal(DTMain.Rows(0).Item("fldOPTime"))
            spnPersons.Value = Convert.ToDecimal(DTMain.Rows(0).Item("fldNoPerson"))
            'tbTimePart.Text = DTMain.Rows(0).Item("fldLineTimePart")

        Else

            Timerelated()

        End If

        If DTGoodQty.Rows.Count >= 1 Then

            gvPartNames.Columns.Clear()
            Dim DTOwO As New DataTable
            Dim ArrayOwO(DTGoodQty.Rows.Count - 1) As String
            Dim i As Integer = 0
            For Each row As DataRow In DTGoodQty.Rows

                DTOwO.Columns.Add(row.Item("fldPartName"))
                ArrayOwO(i) = row.Item("fldQty")
                i = i + 1

            Next

            DTOwO.Rows.Add(ArrayOwO)

            gvPartNames.DataSource = DTOwO

            Dim colno As Integer = 0
            While colno <= DTOwO.Columns.Count - 1
                gvPartNames.Columns(colno).Width = 250
                colno = colno + 1
            End While

        Else

            gvPartNames.Columns.Clear()
            Dim DTPartNames As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.ModelCode & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "' and fldPWFWNo='" & ddType.Text & "'")

            For Each row As DataRow In DTPartNames.Rows

                Dim fldPart As New GridViewDecimalColumn
                fldPart.HeaderText = row.Item("fldPartName").ToString
                fldPart.FieldName = row.Item("fldPartName").ToString
                fldPart.TextAlignment = ContentAlignment.MiddleCenter
                fldPart.Width = 250
                gvPartNames.Columns.Add(fldPart)

            Next

        End If
        GetDownTime()
        'Maria.AddMySqlParameters("parDate",)
        'Dim DTDownTimes As DataTable = Maria.SPSelect("SP_SRCDownTime_SelectDownTimeByShift")

    End Sub


    Private Sub ReloadWelding()
        'MessageBox.Show(globalVariables.ModelCode & " " & globalVariables.SRCReportType)
        Dim DTModel As DataTable = Maria.MyQuery("Select fldPWFWNo from (SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.ModelCode & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "') as tblOwO group by fldPWFWNo")

        ddType.DataSource = DTModel
        ddType.DisplayMember = "fldPWFWNo"
        ddType.ValueMember = "fldPWFWNo"
        ddType.AutoCompleteDataSource = DTModel
        ddType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddType.AutoCompleteDisplayMember = "fldPWFWNo"
        ddType.AutoCompleteValueMember = "fldPWFWNo"
        ddType.Text = ""

    End Sub

    Private Sub ddType_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddType.SelectedIndexChanged

        ReloadData()
        SelectTimePartition()
        gvTimePartition.DataSource = dtTimePartition
        ComputeCycleTime()


    End Sub

    Private Sub GridColManPower()

        Dim fldProcessName As New GridViewTextBoxColumn
        fldProcessName.HeaderText = "Assembly Process Name"
        fldProcessName.FieldName = "fldProcName"
        fldProcessName.TextAlignment = ContentAlignment.MiddleCenter
        fldProcessName.Width = 100
        fldProcessName.ReadOnly = True
        gvEmpStatus.Columns.Add(fldProcessName)

        Dim fldEmployee As New GridViewComboBoxColumn
        fldEmployee.FieldName = "fldEmployee"
        fldEmployee.HeaderText = "Employee Name"
        fldEmployee.DataSource = Me.ProdEmp
        fldEmployee.ValueMember = "fldEmpName"
        fldEmployee.DisplayMember = "fldEmpName"
        fldEmployee.Width = 100
        Me.gvEmpStatus.Columns.Add(fldEmployee)

        Dim fldQualified As New GridViewCheckBoxColumn()
        fldQualified.DataType = GetType(Integer)
        fldQualified.Name = "fldQualified"
        fldQualified.FieldName = "fldQualified"
        fldQualified.HeaderText = "Qualified"
        gvEmpStatus.MasterTemplate.Columns.Add(fldQualified)

        Dim fldTransferred As New GridViewCheckBoxColumn()
        fldTransferred.DataType = GetType(Integer)
        fldTransferred.Name = "fldTransfer"
        fldTransferred.FieldName = "fldTransfer"
        fldTransferred.HeaderText = "Transferred"
        gvEmpStatus.MasterTemplate.Columns.Add(fldTransferred)

        Dim fldTrainee As New GridViewCheckBoxColumn()
        fldTrainee.DataType = GetType(Integer)
        fldTrainee.Name = "fldTrainee"
        fldTrainee.FieldName = "fldTrainee"
        fldTrainee.HeaderText = "TRAINEE"
        gvEmpStatus.MasterTemplate.Columns.Add(fldTrainee)

    End Sub

    Private Sub GridTimePartition()
        Dim gridDeleteBtn As New GridViewCommandColumn()
        gridDeleteBtn.HeaderText = "DELETE"
        gridDeleteBtn.IsPinned = True
        gridDeleteBtn.PinPosition = PinnedColumnPosition.Left
        gridDeleteBtn.Width = 50
        gridDeleteBtn.Name = "DELETE"
        gridDeleteBtn.DefaultText = "DELETE"
        gridDeleteBtn.UseDefaultText = True
        gridDeleteBtn.TextAlignment = ContentAlignment.MiddleCenter
        gvTimePartition.Columns.Add(gridDeleteBtn)

        Dim fldHotto As New GridViewTextBoxColumn
        fldHotto.HeaderText = "Hotto"
        fldHotto.FieldName = "fldStart"
        fldHotto.TextAlignment = ContentAlignment.MiddleCenter
        fldHotto.ReadOnly = True
        gvTimePartition.Columns.Add(fldHotto)

        Dim fldPlanDowtime As New GridViewTextBoxColumn
        fldPlanDowtime.FieldName = "fldPlanned"
        fldPlanDowtime.HeaderText = "Planned Downtime"
        fldPlanDowtime.TextAlignment = ContentAlignment.MiddleCenter
        Me.gvTimePartition.Columns.Add(fldPlanDowtime)

        Dim fldUnplanDowtime As New GridViewTextBoxColumn()
        fldUnplanDowtime.Name = "fldUnplanDowntime"
        fldUnplanDowtime.FieldName = "fldUnplanned"
        fldUnplanDowtime.HeaderText = "Unplan Downtime"
        fldUnplanDowtime.TextAlignment = ContentAlignment.MiddleCenter
        gvTimePartition.MasterTemplate.Columns.Add(fldUnplanDowtime)

        Dim fldOpTime As New GridViewTextBoxColumn()
        fldOpTime.Name = "fldOpTime"
        fldOpTime.FieldName = "fldOPTime"
        fldOpTime.HeaderText = "Operation Time"
        fldOpTime.TextAlignment = ContentAlignment.MiddleCenter
        gvTimePartition.MasterTemplate.Columns.Add(fldOpTime)

        Dim fldPersons As New GridViewTextBoxColumn()
        fldPersons.Name = "fldPersons"
        fldPersons.FieldName = "fldNoPerson"
        fldPersons.HeaderText = "No. of Persons"
        fldPersons.TextAlignment = ContentAlignment.MiddleCenter
        gvTimePartition.MasterTemplate.Columns.Add(fldPersons)

        Dim fldTimePartition As New GridViewTextBoxColumn()
        fldTimePartition.Name = "fldTimePartition"
        fldTimePartition.FieldName = "fldLineTimePart"
        fldTimePartition.HeaderText = "Line Time Partition"
        fldTimePartition.TextAlignment = ContentAlignment.MiddleCenter
        gvTimePartition.MasterTemplate.Columns.Add(fldTimePartition)

    End Sub

    Private Sub ManpowerPerfGrid()

        If globalVariables.SRCReportType = "FW" Then

            gvEmpStatus.Rows.Add("Mold Key Insertion & Bending")
            gvEmpStatus.Rows.Add("FFC Bending")
            gvEmpStatus.Rows.Add("Visual Inspection")

        ElseIf globalVariables.SRCReportType = "PW" Then

            gvEmpStatus.Rows.Add("Pigtail Assy")
            gvEmpStatus.Rows.Add("Pigtail Insertion & Welding")
            gvEmpStatus.Rows.Add("Visual Inspection & Checking")

        End If

    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        If ddType.Text = "" Then

        End If
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Maria.AddMySqlParameters("parID", globalVariables.DailyRepID)
        Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
        Maria.AddMySqlParameters("parFWPWNo", ddType.Text)
        Maria.SPADE("SP_SRCDailyReport_DeleteWeldingManpower")

        For rowcounter As Integer = 0 To Me.gvEmpStatus.Rows.Count - 1

            Try
                Dim parDRID As Integer = globalVariables.DailyRepID
                Dim parType As String = globalVariables.SRCReportType
                Dim parFWPWNo As String = ddType.Text
                Dim parProcName As String = gvEmpStatus.Rows(rowcounter).Cells("fldProcName").Value.ToString

                Dim parEmployee As String
                If IsDBNull(gvEmpStatus.Rows(rowcounter).Cells("fldEmployee").Value) Then
                    parEmployee = "N/A"
                Else
                    parEmployee = DirectCast(gvEmpStatus.Rows(rowcounter).Cells("fldEmployee").Value, String)
                End If

                Dim parQualified As Boolean = gvEmpStatus.Rows(rowcounter).Cells("fldQualified").Value
                Dim parTransfer As Boolean = gvEmpStatus.Rows(rowcounter).Cells("fldTransfer").Value
                Dim parTrainee As Boolean = gvEmpStatus.Rows(rowcounter).Cells("fldTrainee").Value
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
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
                Maria.Connection.Close()
                'pbEmp.Visible = True
            End Try


        Next
        For rowcounter As Integer = 0 To Me.gvTimePartition.Rows.Count - 1
            Try

                Dim parLineTimePart As String = gvTimePartition.Rows(rowcounter).Cells("fldTimePartition").Value
                Dim parStart As Integer = gvTimePartition.Rows(rowcounter).Cells("fldStart").Value
                Dim parPlanned As Integer = gvTimePartition.Rows(rowcounter).Cells("fldPlanned").Value
                Dim parUnplanned As Integer = gvTimePartition.Rows(rowcounter).Cells("fldUnplanDowntime").Value
                Dim parOPTime As Integer = gvTimePartition.Rows(rowcounter).Cells("fldOpTime").Value
                Dim parNoOfPerson As Decimal = gvTimePartition.Rows(rowcounter).Cells("fldPersons").Value


                Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
                Maria.AddMySqlParameters("parFWPWNo", ddType.Text)
                Maria.AddMySqlParameters("parLineTimePart", parLineTimePart)
                Maria.AddMySqlParameters("parStart", parStart)
                Maria.AddMySqlParameters("parPlanned", parPlanned)
                Maria.AddMySqlParameters("parUnplanned", parUnplanned)
                Maria.AddMySqlParameters("parOPTime", parOPTime)
                Maria.AddMySqlParameters("parNoPerson", parNoOfPerson)
                Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                Maria.AddMySqlParameters("parTotalOpTime", lblOpTime.Text)
                Maria.SPADE("SP_SRCDailyReport_InsertWeldingManpowerv2")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
                Maria.Connection.Close()
                'pbMain.Visible = True
            End Try

        Next
        'Try
        '    Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
        '    Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
        '    Maria.AddMySqlParameters("parFWPWNo", ddType.Text)
        '    Maria.AddMySqlParameters("parLineTimePart", tbTimePart.Text)
        '    Maria.AddMySqlParameters("parStart", spnHotto.Value)
        '    Maria.AddMySqlParameters("parPlanned", spnPlanDT.Value)
        '    Maria.AddMySqlParameters("parUnplanned", spnUnplanDT.Value)
        '    Maria.AddMySqlParameters("parOPTime", spnOPTime.Value)
        '    Maria.AddMySqlParameters("parNoPerson", spnPersons.Value)
        '    Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
        '    'Maria.AddMySqlParameters("parTotalOpTime", lblOpTime.Text)
        '    Maria.SPADE("SP_SRCDailyReport_InsertWeldingManpower")
        'Catch ex As Exception
        '    RadMessageBox.Show(ex.Message)
        'Maria.Connection.Close()
        ''pbMain.Visible = True
        'End Try


        For partcolcounter As Integer = 0 To Me.gvPartNames.Columns.Count - 1

            For partrowcounter As Integer = 0 To Me.gvPartNames.Rows.Count - 1

                Try
                    Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                    Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
                    Maria.AddMySqlParameters("parPWFWNo", ddType.Text)
                    Maria.AddMySqlParameters("parPartName", gvPartNames.Columns(partcolcounter).Name)
                    If gvPartNames.Rows(partrowcounter).Cells(partcolcounter).Value = Nothing Or IsDBNull(gvPartNames.Rows(partrowcounter).Cells(partcolcounter).Value) Then
                        Maria.AddMySqlParameters("parQty", 0)
                    Else
                        Maria.AddMySqlParameters("parQty", gvPartNames.Rows(partrowcounter).Cells(partcolcounter).Value)
                    End If
                    Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                    Maria.SPADE("SP_SRCDailyReport_InsertWeldingManpowerGoodQty")
                Catch ex As Exception
                    RadMessageBox.Show(ex.Message)
                    Maria.Connection.Close()
                    'pbGoodQty.Visible = True
                End Try


            Next

        Next
    End Sub
    Private Sub ComputeCycleTime()
        Try
            Dim totalMinutes As Integer
            Dim sum As Decimal = 0
            Dim sumOperationTime As Decimal
            Dim tempTimePartition As String = ""
            For rowcounter As Integer = 0 To Me.gvTimePartition.Rows.Count - 1
                Dim timePartition As String = gvTimePartition.Rows(rowcounter).Cells("fldTimePartition").Value.ToString()
                Dim times() As String = timePartition.Split("-"c)


                Dim startTime As TimeSpan = TimeSpan.Parse(times(0))
                Dim endTime As TimeSpan = TimeSpan.Parse(times(1))

                Dim duration As TimeSpan
                If endTime < startTime Then
                    duration = (endTime + TimeSpan.FromDays(1)) - startTime
                Else
                    duration = endTime - startTime
                End If
                totalMinutes = CInt(duration.TotalMinutes)
                If timePartition <> tempTimePartition Then
                    sumOperationTime = sumOperationTime + totalMinutes
                End If
                lblOpTime.Text = sumOperationTime
                'tbALEOpTime.Text = sumOperationTime


                tempTimePartition = timePartition

            Next

            'gvData.Rows(0).Cells("fldCycleTime").Value = Math.Round(CycleTime, 2)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
            'gvData.Rows(0).Cells("fldCycleTime").Value = 0

        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Saved!")
        pbEmp.Visible = False
        pbGoodQty.Visible = False
        pbMain.Visible = False
    End Sub

    Private Sub cbbClear_Click(sender As Object, e As EventArgs) Handles cbbClear.Click
        gvEmpStatus.DataSource = Nothing
        gvPartNames.DataSource = Nothing
        gvEmpStatus.Rows.Clear()
        gvPartNames.Rows.Clear()
        ManpowerPerfGrid()
        spnHotto.Value = 0
        spnPersons.Value = 0
        spnPlanDT.Value = 0
        spnUnplanDT.Value = 0
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        globalVariables.DailyRepEditTimePart = tbTimePart.Text
        globalVariables.DailyRepNewOPTime = spnOPTime.Value

        FrmEditLineTimePart.ShowDialog(Me)

        tbTimePart.Text = globalVariables.DailyRepEditTimePart
        spnOPTime.Value = globalVariables.DailyRepNewOPTime
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gvTimePartition.Rows.Add("", spnHotto.Value, spnPlanDT.Value, spnUnplanDT.Value, spnOPTime.Value, spnPersons.Value, tbTimePart.Text)
        ComputeCycleTime()
    End Sub

    Private Sub gvTimePartition_CellClick(sender As Object, e As GridViewCellEventArgs) Handles gvTimePartition.CellClick
        globalVariables.currentRgv = gvTimePartition
        'If e.Column.Name = "DELETE" Then
        '    Dim result As DialogResult = RadMessageBox.Show(
        '    "This record is already saved!",
        '    "WARNING",
        '    MessageBoxButtons.OK,
        '    RadMessageIcon.Error)

        selectedRowIndex = gvTimePartition.CurrentRow.Index
        globalVariables.rgvAssyRowIndex = selectedRowIndex

        If e.Column IsNot Nothing AndAlso e.Column.Name = "DELETE" AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As GridViewRowInfo = gvTimePartition.CurrentRow



            Dim result As DialogResult = RadMessageBox.Show(
        "Are you sure you want to delete this record?",
        "Confirmation",
        MessageBoxButtons.YesNo,
        RadMessageIcon.Question)

            If result = DialogResult.Yes Then
                gvTimePartition.Rows.RemoveAt(selectedRowIndex)
                RadMessageBox.Show("Record Deleted", "INFO", MessageBoxButtons.OK, RadMessageIcon.Info)

            End If
        End If
    End Sub

End Class
