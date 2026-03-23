Imports Org.BouncyCastle.Asn1.Cms
Imports Telerik.Reporting
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmSRCDailyReportNewV2
    Dim Furina As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    'Dim Furina As New Kurumi.DB("localhost", "dbmia", "root", "password")
    Dim ProgressText As String = ""
    Private Sub FrmSRCDailyReportNewV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler cbModelName.SelectedValueChanged, AddressOf cbModelName_SelectedValueChanged
        GetProcessName()
        GetTL()
        ManpowerGrid()
        ReloadManpowerGrid()
        GetHourlyShiftTime()
        HourlyGrid()
        ReloadHourlyGrid()
        AssyLineEffGrid()
        ReloadALEData()
        GetSAPart()
        SRCAssyGrid()
        ReloadSRCAssyGrid()
        SRCDefectsGrid()
        ReloadSRCDefectsGrid()
        ReloadOtherData()
        GetLotNoTime()
        GetLotNoPartName()
        LotNoGrid()
        RealoadLotNoGrid()
        GetDownTime()
        ComputeCycleTime()
        readycbModelName()
        'readyMcbModelName()
        txtManpower.Visible = False
        If rgvManpower.RowCount > 1 And btnMPSubmit.Text.Trim = "SAVE WITH TEAM MEMBERS" Then
            btnMPSubmit.Enabled = False
        End If

        btnAssyCancel.Visible = False
        globalVariables.assyStatus = "ADD"
    End Sub
    Private Sub GetDownTime()

        Dim ShiftConv As String = ""

        If Mio.Shift = "6AM-2PM(1st Shift)" Then
            ShiftConv = "1st Shift"
        ElseIf Mio.Shift = "6AM-6PM" Then
            ShiftConv = "Day Shift"
        ElseIf Mio.Shift = "2PM-10PM(2nd Shift)" Then
            ShiftConv = "2nd Shift"
        ElseIf Mio.Shift = "6PM-6AM" Then
            ShiftConv = "Night Shift"
        ElseIf Mio.Shift = "10PM-6AM(3rd Shift)" Then
            ShiftConv = "3rd Shift"
        End If

        Furina.AddMySqlParameters("parModel", Mio.Model)
        Furina.AddMySqlParameters("parShift", ShiftConv)
        Furina.AddMySqlParameters("parDate", Mio.DRDate)
        Furina.AddMySqlParameters("parPlan", 1)
        Furina.AddMySqlParameters("parType", "ASSY")
        Dim DTDownTimeCheckPlan As DataTable = Furina.SPSelect("SP_SRCDownTime_SelectByDailyReport")
        If DTDownTimeCheckPlan.Rows.Count >= 1 Then
            If IsDBNull(DTDownTimeCheckPlan.Rows(0).Item("TotalDT")) Then
                tbPlanned.Text = 0
            Else
                tbPlanned.Text = Convert.ToInt32(DTDownTimeCheckPlan.Rows(0).Item("TotalDT"))
            End If
        Else
            tbPlanned.Text = 0
        End If


        Furina.AddMySqlParameters("parModel", Mio.Model)
        Furina.AddMySqlParameters("parShift", ShiftConv)
        Furina.AddMySqlParameters("parDate", Mio.DRDate)
        Furina.AddMySqlParameters("parPlan", 0)
        Furina.AddMySqlParameters("parType", "ASSY")
        Dim DTDownTimeCheckUnplan As DataTable = Furina.SPSelect("SP_SRCDownTime_SelectByDailyReport2")
        If DTDownTimeCheckUnplan.Rows.Count >= 1 Then
            If IsDBNull(DTDownTimeCheckUnplan.Rows(0).Item("TotalDT")) Then
                tbUnplanned.Text = 0
            Else
                tbUnplanned.Text = Convert.ToInt32(DTDownTimeCheckUnplan.Rows(0).Item("TotalDT"))
            End If
        Else
            tbUnplanned.Text = 0
        End If

    End Sub
    Private Sub ComputeCycleTime()
        Try

            Dim HottoVal As Integer = spnALEHotto.Value
            Dim PlanedDTVal As Integer = Convert.ToInt32(tbPlanned.Text)
            Dim UnplanedDTVal As Integer = Convert.ToInt32(tbUnplanned.Text)
            Dim OPTimeVal As Integer = Convert.ToInt32(tbALEOpTime.Text)

            Dim sum As Decimal = 0

            For rowcounter As Integer = 0 To Me.rgvAssyLineEff.Rows.Count - 1

                Dim fldGoodQty As Integer = rgvAssyLineEff.Rows(rowcounter).Cells("fldGoodQty").Value
                Try
                    If rgvAssyLineEff.Rows(rowcounter).Cells("fldDelivered").Value.ToString = "Not Delivered" Then

                    Else
                        sum = sum + fldGoodQty
                        lblTotalQty.Text = sum
                    End If
                Catch ex As Exception

                End Try



            Next

            Dim CycleTime As Decimal = ((OPTimeVal - (HottoVal + PlanedDTVal + UnplanedDTVal)) * 60) / sum

            tbCycle.Text = Math.Round(CycleTime, 2)

            'gvData.Rows(0).Cells("fldCycleTime").Value = Math.Round(CycleTime, 2)

        Catch ex As Exception

            tbCycle.Text = 0
            'gvData.Rows(0).Cells("fldCycleTime").Value = 0

        End Try
    End Sub

#Region "Manpower"
    Private Sub GetProcessName()



        Dim DTProc As DataTable = Tohka.SelectSrcTemplate("tblDailyReportSRCManpowerTemp", Mio.ModelCode, Mio.Line)
        ddProc.DataSource = DTProc
        ddProc.DisplayMember = "fldProcessName"
        ddProc.ValueMember = "fldProcessName"
        ddProc.AutoCompleteDataSource = DTProc
        ddProc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddProc.AutoCompleteDisplayMember = "fldProcessName"
        ddProc.AutoCompleteValueMember = "fldProcessName"
        ddProc.Text = ""

        ddStatus.SelectedIndex = 0
    End Sub

    Private Sub GetTL()
        Furina.AddMySqlParameters("parModel", Mio.ModelCode)
        Furina.AddMySqlParameters("parLine", Mio.Line)
        Dim DTTeamLeader As DataTable = Furina.SPSelect("SP_SelectTeamLeaderv2")
        Dim fldTeamLeader As New GridViewTextBoxColumn("TEAM LEADER")
        fldTeamLeader.FieldName = "fldEmpName"
        fldTeamLeader.Width = 200
        cbManpower.MultiColumnComboBoxElement.Columns.Add(fldTeamLeader)

        cbManpower.DataSource = DTTeamLeader
        cbManpower.ValueMember = "fldEmpName"
        cbManpower.DisplayMember = "fldEmpName"
        cbManpower.MultiColumnComboBoxElement.DropDownWidth = 400
        cbManpower.Text = "Select Team Leader"
        cbManpower.AutoFilter = True
        cbManpower.AutoCompleteMode = AutoCompleteMode.SuggestAppend


    End Sub

    Private Sub GetTeam()
        Furina.AddMySqlParameters("empName", cbManpower.Text)
        Dim DTTeamNo As DataTable = Furina.SPSelect("SP_SelectTeamv2")
        ddTeam.DataSource = DTTeamNo
        ddTeam.DisplayMember = "fldTeam"
        ddTeam.ValueMember = "fldTeam"
        ddTeam.Visible = False
        ddProc.DataSource = DTTeamNo
        ddProc.DisplayMember = "fldProcessName"
        ddProc.ValueMember = "fldProcessName"
        ddProc.Enabled = False
    End Sub

    Private Sub ManpowerGrid()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvManpower.Columns.Add(fldID)

        Dim fldProcessName As New GridViewTextBoxColumn
        fldProcessName.HeaderText = "Assembly Process Name"
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.TextAlignment = ContentAlignment.MiddleCenter
        fldProcessName.Width = 100
        fldProcessName.ReadOnly = True
        rgvManpower.Columns.Add(fldProcessName)

        Dim fldEmployee As New GridViewTextBoxColumn
        fldEmployee.HeaderText = "Employee Name"
        fldEmployee.FieldName = "fldEmployee"
        fldEmployee.TextAlignment = ContentAlignment.MiddleCenter
        fldEmployee.Width = 100
        fldEmployee.ReadOnly = True
        rgvManpower.Columns.Add(fldEmployee)

        Dim fldQualify As New GridViewCheckBoxColumn()
        fldQualify.DataType = GetType(Integer)
        fldQualify.Name = "fldQualified"
        fldQualify.FieldName = "fldQualified"
        fldQualify.HeaderText = "Qualified"
        fldQualify.ReadOnly = True
        rgvManpower.MasterTemplate.Columns.Add(fldQualify)

        Dim fldTransfer As New GridViewCheckBoxColumn()
        fldTransfer.DataType = GetType(Integer)
        fldTransfer.Name = "fldTransferred"
        fldTransfer.FieldName = "fldTransferred"
        fldTransfer.HeaderText = "Transferred"
        fldTransfer.ReadOnly = True
        rgvManpower.MasterTemplate.Columns.Add(fldTransfer)

        Dim fldTrainee As New GridViewCheckBoxColumn()
        fldTrainee.DataType = GetType(Integer)
        fldTrainee.Name = "fldTrainee"
        fldTrainee.FieldName = "fldTrainee"
        fldTrainee.HeaderText = "TRAINEE"
        fldTrainee.ReadOnly = True
        rgvManpower.MasterTemplate.Columns.Add(fldTrainee)

    End Sub

    Private Sub ReloadManpowerGrid()
        rgvManpower.DataSource = Tohka.SelectSrcTable("tblDailyReportSRCManpower", Mio.DRID)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnMPSubmit.Click
        If cbManpower.Text.Trim = "" And btnMPSubmit.Text.Trim = "SAVE WITH TEAM MEMBERS" Then
            MessageBox.Show("Please select Team Leader")
        Else
            Dim parQualify As Integer = 0
            Dim parTransfer As Integer = 0
            Dim parTrainee As Integer = 0
            If ddStatus.Text = "Qualified" Then
                parQualify = 1
                parTransfer = 0
                parTrainee = 0
            ElseIf ddStatus.Text = "Transferred" Then
                parQualify = 0
                parTransfer = 1
                parTrainee = 0
            ElseIf ddStatus.Text = "Trainee" Then
                parQualify = 0
                parTransfer = 0
                parTrainee = 1
            Else
                parQualify = 0
                parTransfer = 0
                parTrainee = 0
            End If
            If btnMPSubmit.Text = "SAVE WITH TEAM MEMBERS" Then
                MessageBox.Show(InsertSRCManpowerv2(Mio.DRID, ddTeam.Text, Mio.ModelCode, Mio.Line))
                btnMPSubmit.Text = "SAVE WITH TEAM MEMBERS"
                btnMPCancel.Visible = False
                Dim CurrProcess As Integer = ddProc.SelectedIndex
                If CurrProcess <> ddProc.Items.Count - 1 Then
                    ddProc.SelectedIndex = CurrProcess + 1
                End If
            Else

                MessageBox.Show(EditSRCManpower(Convert.ToInt32(lblEditID.Text), ddProc.Text, txtManpower.Text, parQualify, parTransfer, parTrainee))
                btnMPSubmit.Text = "SAVE"
                ddProc.Enabled = True
                cbManpower.Enabled = False
                txtManpower.Visible = True
                btnMPCancel.Visible = False
                GetProcessName()

            End If

            ReloadManpowerGrid()
        End If

    End Sub

    Private Sub rgvManpower_DoubleClick(sender As Object, e As EventArgs) Handles rgvManpower.DoubleClick
        txtManpower.Visible = True
        cbManpower.Enabled = False
        btnMPSubmit.Enabled = True
        ddProc.Text = rgvManpower.CurrentRow.Cells("fldProcessName").Value.ToString()
        cbManpower.Text = rgvManpower.CurrentRow.Cells("fldEmployee").Value.ToString()
        txtManpower.Text = rgvManpower.CurrentRow.Cells("fldEmployee").Value.ToString()

        If rgvManpower.CurrentRow.Cells("fldQualified").Value = 1 Then
            ddStatus.SelectedIndex = 0
        ElseIf rgvManpower.CurrentRow.Cells("fldTransferred").Value = 1 Then
            ddStatus.SelectedIndex = 1
        ElseIf rgvManpower.CurrentRow.Cells("fldTrainee").Value = 1 Then
            ddStatus.SelectedIndex = 2
        Else
            ddStatus.SelectedIndex = 0
        End If

        lblEditID.Text = rgvManpower.CurrentRow.Cells("fldID").Value

        btnMPSubmit.Text = "EDIT"
        btnMPCancel.Visible = True
    End Sub

    Private Sub btnMPCancel_Click(sender As Object, e As EventArgs) Handles btnMPCancel.Click
        btnMPSubmit.Text = "SAVE WITH TEAM MEMBERS"
        btnMPCancel.Visible = False
        txtManpower.Visible = False
    End Sub

    Private Sub rgvManpower_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvManpower.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                MessageBox.Show(Tohka.DeleteSrcTable("tblDailyReportSRCManpower", rgvManpower.CurrentRow.Cells("fldID").Value))
                ReloadManpowerGrid()
            End If
        End If
    End Sub

#End Region

#Region "Hourly"

    Private Sub GetHourlyShiftTime()

        ddHQTime.Items.Clear()

        Dim DTTimeRange As DataTable = Furina.MyQuery("SELECT * FROM dbMIA.tblDailyReportSRC where fldID='" & Mio.DRID & "'")
        Dim TimeRow As New DataTable
        TimeRow.Columns.Add("Time")

        Dim FromTime As DateTime = DTTimeRange.Rows(0).Item("fldTimeFrom")
        Dim ToTime As DateTime = DTTimeRange.Rows(0).Item("fldTimeTo")
        Dim ToMin As Integer = ToTime.Minute
        Dim ToMonth As Integer = ToTime.Month
        Dim hour As Integer = ToTime.Hour
        Dim lastDay As DateTime = New DateTime(ToTime.Year, ToTime.Month, DateTime.DaysInMonth(ToTime.Year, ToTime.Month))
        Dim lastDayOfMonth As Integer = lastDay.Day

        If ToMin = 0 Then
            While FromTime <= ToTime

                'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
                TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
                FromTime = FromTime.AddHours(1)

            End While
        Else
            While FromTime < ToTime

                'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
                TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
                FromTime = FromTime.AddHours(1)

            End While

            FromTime = FromTime.AddHours(-1)
            FromTime = FromTime.AddMinutes(ToMin)
            'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
            TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
        End If






        Dim TimeInt As Integer = 0
        While TimeInt < TimeRow.Rows.Count - 1
            ddHQTime.Items.Add(TimeRow.Rows(TimeInt).Item(0) & "-" & TimeRow.Rows(TimeInt + 1).Item(0))
            TimeInt += 1
        End While

    End Sub

    Private Sub btnHQSubmit_Click(sender As Object, e As EventArgs) Handles btnHQSubmit.Click
        Dim DRID As Integer = Mio.DRID
        Dim Time As String = ddHQTime.Text
        Dim CableG As Integer = If(cbHQ1.Checked = True, 1, 0)
        Dim StatorG As Integer = If(cbHQ2.Checked = True, 1, 0)
        Dim FinalProd As Integer = If(cbHQ3.Checked = True, 1, 0)
        Dim Rotator As Integer = spnHQRotator.Value
        Dim Stator As Integer = spnHQStator.Value
        Dim SubStator As Integer = spnHQSubstator.Value
        Dim Sleeve As Integer = spnHQSleeve.Value
        Dim Barcode As String = tbHQBarcode.Text
        Dim Plan As Integer = spnHQPlan.Value
        Dim Actual As Integer = spnHQActual.Value
        Dim Deviation As Integer = spnHQActual.Value - spnHQPlan.Value
        Dim Electrical As Integer = spnHQElectrical.Value
        Dim Func As Integer = spnHQFunction.Value
        Dim Final As Integer = spnHQFinal.Value

        If btnHQSubmit.Text = "SAVE" Then
            MessageBox.Show(Tohka.InsertSRCHourly(DRID, Time, CableG, StatorG, FinalProd, Rotator, Stator, SubStator, Sleeve, Barcode, Plan, Actual, Deviation, Electrical, Func, Final))
            Dim CurrDropDown As Integer = ddHQTime.SelectedIndex
            If CurrDropDown < ddHQTime.Items.Count - 1 Then
                ddHQTime.SelectedIndex = CurrDropDown + 1
            End If
        Else
            MessageBox.Show(Tohka.EditSRCHourly(lblHQEdit.Text, Time, CableG, StatorG, FinalProd, Rotator, Stator, SubStator, Sleeve, Barcode, Plan, Actual, Deviation, Electrical, Func, Final))
            btnHQCancel.Visible = False
            btnHQSubmit.Text = "SAVE"
        End If

        ReloadHourlyGrid()
    End Sub

    Private Sub HourlyGrid()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvHourly.Columns.Add(fldID)

        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time"
        fldTime.FieldName = "fldTime"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.MinWidth = 90
        fldTime.ReadOnly = True
        fldTime.IsPinned = True
        fldTime.PinPosition = PinnedColumnPosition.Left
        rgvHourly.Columns.Add(fldTime)

        Dim fldCableGrease As New GridViewCheckBoxColumn()
        fldCableGrease.DataType = GetType(Integer)
        fldCableGrease.FieldName = "fldCableG"
        fldCableGrease.HeaderText = "Cable Greasing"
        fldCableGrease.ReadOnly = True
        fldCableGrease.MinWidth = 120
        rgvHourly.MasterTemplate.Columns.Add(fldCableGrease)

        Dim fldStatorGrease As New GridViewCheckBoxColumn()
        fldStatorGrease.DataType = GetType(Integer)
        fldStatorGrease.FieldName = "fldStatorG"
        fldStatorGrease.HeaderText = "Stator Greasing"
        fldStatorGrease.ReadOnly = True
        fldStatorGrease.MinWidth = 120
        rgvHourly.MasterTemplate.Columns.Add(fldStatorGrease)

        Dim fldFinalProdCheck As New GridViewCheckBoxColumn()
        fldFinalProdCheck.DataType = GetType(Integer)
        fldFinalProdCheck.FieldName = "fldFinalProdCheck"
        fldFinalProdCheck.HeaderText = "Final Product Check"
        fldFinalProdCheck.ReadOnly = True
        fldFinalProdCheck.MinWidth = 120
        rgvHourly.MasterTemplate.Columns.Add(fldFinalProdCheck)

        Dim fldRotator As New GridViewTextBoxColumn
        fldRotator.HeaderText = "Rotator (Cavity#)"
        fldRotator.FieldName = "fldRotator"
        fldRotator.TextAlignment = ContentAlignment.MiddleCenter
        fldRotator.ReadOnly = True
        fldRotator.MinWidth = 120
        rgvHourly.Columns.Add(fldRotator)

        Dim fldStator As New GridViewTextBoxColumn
        fldStator.HeaderText = "Stator (Cavity#)"
        fldStator.FieldName = "fldStator"
        fldStator.TextAlignment = ContentAlignment.MiddleCenter
        fldStator.ReadOnly = True
        fldStator.MinWidth = 120
        rgvHourly.Columns.Add(fldStator)

        Dim fldSubStator As New GridViewTextBoxColumn
        fldSubStator.HeaderText = "Sub Stator (Cavity#)"
        fldSubStator.FieldName = "fldSubStator"
        fldSubStator.TextAlignment = ContentAlignment.MiddleCenter
        fldSubStator.ReadOnly = True
        fldSubStator.MinWidth = 120
        rgvHourly.Columns.Add(fldSubStator)

        Dim fldSleeve As New GridViewTextBoxColumn
        fldSleeve.HeaderText = "Sleeve (Cavity#)"
        fldSleeve.FieldName = "fldSleeve"
        fldSleeve.TextAlignment = ContentAlignment.MiddleCenter
        fldSleeve.ReadOnly = True
        fldSleeve.MinWidth = 120
        rgvHourly.Columns.Add(fldSleeve)

        Dim fldBarcode As New GridViewTextBoxColumn
        fldBarcode.HeaderText = "Barcode No."
        fldBarcode.FieldName = "fldBarcode"
        fldBarcode.TextAlignment = ContentAlignment.MiddleCenter
        fldBarcode.ReadOnly = True
        fldBarcode.MinWidth = 120
        rgvHourly.Columns.Add(fldBarcode)

        Dim fldPlan As New GridViewTextBoxColumn
        fldPlan.HeaderText = "Plan"
        fldPlan.FieldName = "fldPlan"
        fldPlan.TextAlignment = ContentAlignment.MiddleCenter
        fldPlan.ReadOnly = True
        fldPlan.MinWidth = 120
        rgvHourly.Columns.Add(fldPlan)

        Dim fldActual As New GridViewTextBoxColumn
        fldActual.HeaderText = "Actual"
        fldActual.FieldName = "fldActual"
        fldActual.TextAlignment = ContentAlignment.MiddleCenter
        fldActual.ReadOnly = True
        fldActual.MinWidth = 120
        rgvHourly.Columns.Add(fldActual)

        Dim fldDeviation As New GridViewTextBoxColumn
        fldDeviation.HeaderText = "Deviation(+/-)"
        fldDeviation.FieldName = "fldDeviation"
        fldDeviation.TextAlignment = ContentAlignment.MiddleCenter
        fldDeviation.ReadOnly = True
        fldDeviation.MinWidth = 120
        fldDeviation.ReadOnly = True
        rgvHourly.Columns.Add(fldDeviation)

        Dim fldNGElectrical As New GridViewTextBoxColumn
        fldNGElectrical.HeaderText = "Electrical(NG Prod. Counter Pcs.)"
        fldNGElectrical.FieldName = "fldElectrical"
        fldNGElectrical.TextAlignment = ContentAlignment.MiddleCenter
        fldNGElectrical.ReadOnly = True
        fldNGElectrical.MinWidth = 120
        rgvHourly.Columns.Add(fldNGElectrical)

        Dim fldNGFunction As New GridViewTextBoxColumn
        fldNGFunction.HeaderText = "Function(NG Prod. Counter Pcs.)"
        fldNGFunction.FieldName = "fldFunction"
        fldNGFunction.TextAlignment = ContentAlignment.MiddleCenter
        fldNGFunction.ReadOnly = True
        fldNGFunction.MinWidth = 120
        rgvHourly.Columns.Add(fldNGFunction)

        Dim fldNGFinal As New GridViewTextBoxColumn
        fldNGFinal.HeaderText = "Final(NG Prod. Counter Pcs.)"
        fldNGFinal.FieldName = "fldFinal"
        fldNGFinal.TextAlignment = ContentAlignment.MiddleCenter
        fldNGFinal.ReadOnly = True
        fldNGFinal.MinWidth = 120
        rgvHourly.Columns.Add(fldNGFinal)

        rgvHourly.MasterTemplate.BestFitColumns()

    End Sub

    Private Sub ReloadHourlyGrid()
        rgvHourly.DataSource = Tohka.SelectSrcTable("tblDailyReportSRCHourlyQuality", Mio.DRID)
    End Sub
    Private Sub getHourlyPlan()
        Dim values() As Integer

        Select Case Mio.Shift
            Case "6AM-2PM(1st Shift)"
                values = {143, 300, 471, 586, 729, 900, 1057, 1214}
            Case "2PM-10PM(2nd Shift)", "10PM-6AM(3rd Shift)"
                values = {143, 300, 471, 600, 729, 886, 1057, 1214}
            Case "6AM-6PM"
                values = {143, 300, 471, 586, 729, 900, 1057, 1214, 1371, 1514, 1671, 1842}
            Case "6PM-6AM"
                values = {143, 300, 471, 600, 729, 886, 1057, 1186, 1357, 1514, 1685, 1842}
        End Select

        If ddHQTime.SelectedIndex >= 0 AndAlso ddHQTime.SelectedIndex < values.Length Then
            spnHQPlan.Value = values(ddHQTime.SelectedIndex)
        End If

    End Sub

    Private Sub rgvHourly_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvHourly.CellDoubleClick
        lblHQEdit.Text = rgvHourly.CurrentRow.Cells("fldID").Value
        ddHQTime.Text = rgvHourly.CurrentRow.Cells("fldTime").Value
        cbHQ1.Checked = If(rgvHourly.CurrentRow.Cells("fldCableG").Value = 1, True, False)
        cbHQ2.Checked = If(rgvHourly.CurrentRow.Cells("fldStatorG").Value = 1, True, False)
        cbHQ3.Checked = If(rgvHourly.CurrentRow.Cells("fldFinalProdCheck").Value = 1, True, False)
        spnHQRotator.Value = rgvHourly.CurrentRow.Cells("fldRotator").Value
        spnHQStator.Value = rgvHourly.CurrentRow.Cells("fldStator").Value
        spnHQSubstator.Value = rgvHourly.CurrentRow.Cells("fldSubStator").Value
        spnHQSleeve.Value = rgvHourly.CurrentRow.Cells("fldSleeve").Value
        tbHQBarcode.Text = rgvHourly.CurrentRow.Cells("fldBarcode").Value
        spnHQPlan.Value = rgvHourly.CurrentRow.Cells("fldPlan").Value
        spnHQActual.Value = rgvHourly.CurrentRow.Cells("fldActual").Value
        spnHQDeviation.Value = rgvHourly.CurrentRow.Cells("fldActual").Value - rgvHourly.CurrentRow.Cells("fldPlan").Value
        spnHQElectrical.Value = rgvHourly.CurrentRow.Cells("fldElectrical").Value
        spnHQFunction.Value = rgvHourly.CurrentRow.Cells("fldFunction").Value
        spnHQFinal.Value = rgvHourly.CurrentRow.Cells("fldFinal").Value
        btnHQSubmit.Text = "EDIT"
        btnHQCancel.Visible = True
    End Sub

    Private Sub spnHQPlan_ValueChanged(sender As Object, e As EventArgs)
        spnHQDeviation.Value = spnHQActual.Value - spnHQPlan.Value
    End Sub

    Private Sub spnHQActual_ValueChanged(sender As Object, e As EventArgs)
        spnHQDeviation.Value = spnHQActual.Value - spnHQPlan.Value
    End Sub

    Private Sub btnHQCancel_Click(sender As Object, e As EventArgs) Handles btnHQCancel.Click
        btnHQCancel.Visible = False
        btnHQSubmit.Text = "SAVE"
    End Sub

    Private Sub rgvHourly_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvHourly.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                MessageBox.Show(Tohka.DeleteSrcTable("tblDailyReportSRCHourlyQuality", rgvHourly.CurrentRow.Cells("fldID").Value))
                ReloadHourlyGrid()
            End If
        End If
    End Sub

#End Region

#Region "ASSY Line Eff"

    Private Sub AssyLineEffGrid()
        Dim fldCustomer As New GridViewTextBoxColumn
        fldCustomer.HeaderText = "Customer"
        fldCustomer.FieldName = "fldCustomer"
        fldCustomer.TextAlignment = ContentAlignment.MiddleCenter
        fldCustomer.MinWidth = 120
        fldCustomer.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldCustomer)

        Dim fldFGNo As New GridViewTextBoxColumn
        fldFGNo.HeaderText = "FG No."
        fldFGNo.FieldName = "fldFGNo"
        fldFGNo.TextAlignment = ContentAlignment.MiddleCenter
        fldFGNo.MinWidth = 120
        fldFGNo.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldFGNo)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "Model Name"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.MinWidth = 120
        fldModel.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldModel)

        Dim fldModelCode As New GridViewTextBoxColumn
        fldModelCode.HeaderText = "Model Code"
        fldModelCode.FieldName = "fldModelCode"
        fldModelCode.TextAlignment = ContentAlignment.MiddleCenter
        fldModelCode.MinWidth = 120
        fldModelCode.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldModelCode)

        Dim fldLotNo As New GridViewTextBoxColumn
        fldLotNo.HeaderText = "Lot No."
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLotNo.MinWidth = 120
        fldLotNo.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldLotNo)

        Dim fldGoodQty As New GridViewTextBoxColumn
        fldGoodQty.HeaderText = "Good Qty."
        fldGoodQty.FieldName = "fldGoodQty"
        fldGoodQty.TextAlignment = ContentAlignment.MiddleCenter
        fldGoodQty.MinWidth = 120
        fldGoodQty.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldGoodQty)

        Dim fldDelivered As New GridViewTextBoxColumn
        fldDelivered.HeaderText = "Delivered"
        fldDelivered.FieldName = "fldDelivered"
        fldDelivered.TextAlignment = ContentAlignment.MiddleCenter
        fldDelivered.MinWidth = 120
        fldDelivered.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldDelivered)

        Dim fldReplacement As New GridViewTextBoxColumn
        fldReplacement.HeaderText = "Replacement"
        fldReplacement.FieldName = "fldReplacement"
        fldReplacement.TextAlignment = ContentAlignment.MiddleCenter
        fldReplacement.MinWidth = 120
        fldReplacement.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldReplacement)

        Dim fldAssyScrap As New GridViewTextBoxColumn
        fldAssyScrap.HeaderText = "Assembly Scrap"
        fldAssyScrap.FieldName = "fldAssyScrap"
        fldAssyScrap.TextAlignment = ContentAlignment.MiddleCenter
        fldAssyScrap.MinWidth = 120
        fldAssyScrap.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldAssyScrap)

        Dim fldSample As New GridViewTextBoxColumn
        fldSample.HeaderText = "Sample"
        fldSample.FieldName = "fldSample"
        fldSample.TextAlignment = ContentAlignment.MiddleCenter
        fldSample.MinWidth = 120
        fldSample.ReadOnly = True
        rgvAssyLineEff.Columns.Add(fldSample)

        'Dim summaryItem As New GridViewSummaryItem()
        'summaryItem.Name = "fldGoodQty"
        'summaryItem.AggregateExpression = "Sum(fldGoodQty) "
        'Dim summaryRowItem As New GridViewSummaryRowItem()
        'summaryRowItem.Add(summaryItem)
        'Me.rgvAssyLineEff.SummaryRowsBottom.Add(summaryRowItem)

        rgvAssyLineEff.MasterTemplate.BestFitColumns()

    End Sub

    'Private Sub readyMcbModelName()
    '    Dim DTModelName As DataTable = Furina.SPSelect("SP_SelectModelName")
    '    Dim fldPartName As New GridViewTextBoxColumn()
    '    fldPartName.HeaderText = "MODEL NAME"
    '    fldPartName.FieldName = "fldPartName"
    '    cbModelName.MultiColumnComboBoxElement.Columns.Add(fldPartName)
    '    cbModelName.DataSource = DTModelName
    '    cbModelName.DisplayMember = "fldPartName"
    '    cbModelName.ValueMember = "fldPartName"

    '    cbModelName.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
    '    cbModelName.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
    '    cbModelName.AutoFilter = True

    '    Dim modelName As New FilterDescriptor()
    '    modelName.PropertyName = "fldPartName"
    '    modelName.Operator = FilterOperator.Contains
    '    cbModelName.EditorControl.MasterTemplate.FilterDescriptors.Add(modelName)
    'End Sub
    Private Sub readycbModelName()
        Dim DTModelName As DataTable
        DTModelName = GetModelName()
        cbModelName.DataSource = DTModelName
        cbModelName.DisplayMember = "fldPartName"
        cbModelName.ValueMember = "fldID"
        cbModelName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cbModelName.DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains



    End Sub

    Private Function GetModelName() As DataTable
        Dim DTModelName As DataTable
        Furina.AddMySqlParameters("parModel", Mio.ModelCode)
        DTModelName = Furina.SPSelect("SP_SelectModelNamev2")
        Return DTModelName
    End Function

    Private Sub GetCodeFG()
        Try
            Furina.AddMySqlParameters("parID", cbModelName.SelectedValue)
            Dim DTCodeFG As DataTable = Furina.SPSelect("SP_SelectCodeFGv2")
            If DTCodeFG.Rows.Count > 0 Then
                tbALEFGNo.Text = DTCodeFG.Rows(0).Item("fldFG").ToString()
                tbALEModelCode.Text = DTCodeFG.Rows(0).Item("fldModelCode").ToString()
                tbALECustomer.Text = DTCodeFG.Rows(0).Item("fldCustomer").ToString()
            Else
                tbALEFGNo.Text = String.Empty
                tbALEModelCode.Text = String.Empty
                tbALECustomer.Text = String.Empty
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try






    End Sub

    Private Sub GetDefaultALETime()
        tbALETime.Enabled = False
        tbALEOpTime.Enabled = False
        If Mio.Shift = "6AM-2PM(1st Shift)" Then

            Dim Timeline As String = "06:00-14:00"
            Dim TimeLineMin As Integer = 480

            tbALETime.Text = Timeline
            tbALEOpTime.Text = TimeLineMin

        ElseIf Mio.Shift = "6AM-6PM" Then

            Dim Timeline As String = "06:00-18:00"
            Dim TimeLineMin As Integer = 720

            tbALETime.Text = Timeline
            tbALEOpTime.Text = TimeLineMin

        ElseIf Mio.Shift = "2PM-10PM(2nd Shift)" Then

            Dim Timeline As String = "14:00-22:00"
            Dim TimeLineMin As Integer = 480

            tbALETime.Text = Timeline
            tbALEOpTime.Text = TimeLineMin

        ElseIf Mio.Shift = "6PM-6AM" Then

            Dim Timeline As String = "18:00-06:00"
            Dim TimeLineMin As Integer = 720

            tbALETime.Text = Timeline
            tbALEOpTime.Text = TimeLineMin

        ElseIf Mio.Shift = "10PM-6AM(3rd Shift)" Then

            Dim Timeline As String = "22:00-06:00"
            Dim TimeLineMin As Integer = 480

            tbALETime.Text = Timeline
            tbALEOpTime.Text = TimeLineMin

        End If
    End Sub

    Private Sub btnALEAdd_Click(sender As Object, e As EventArgs) Handles btnALEAdd.Click

        rgvAssyLineEff.Rows.Add(tbALECustomer.Text, tbALEFGNo.Text, cbModelName.Text, tbALEModelCode.Text, tbALELotNo.Text, spnALEGoodQty.Value, If(cbDelivered.Checked, "Delivered", "Not Delivered"), spnALEReplace.Value, spnALEScrap.Value, spnALESample.Value)
        ComputeCycleTime()

    End Sub

    Private Sub btnALESubmit_Click(sender As Object, e As EventArgs) Handles btnALESubmit.Click
        If globalVariables.assyStatus = "ADD" Then
            btnALESubmit.Text = "SAVE"
            If rgvAssyLineEff.Rows.Count <= 0 Then
                MessageBox.Show("Data Required")
            Else
                If Tohka.DeleteSrcTableByDRID("tblDailyReportAssyLineEff", Mio.DRID) = "Good" Then
                    For rowcounter As Integer = 0 To Me.rgvAssyLineEff.Rows.Count - 1

                        Dim parCustomer As String = DirectCast(rgvAssyLineEff.Rows(rowcounter).Cells("fldCustomer").Value, String)
                        Dim parFGNo As String = rgvAssyLineEff.Rows(rowcounter).Cells("fldFGNo").Value.ToString
                        Dim parModel As String = DirectCast(rgvAssyLineEff.Rows(rowcounter).Cells("fldModel").Value, String)
                        Dim parModelCode As String = DirectCast(rgvAssyLineEff.Rows(rowcounter).Cells("fldModelCode").Value, String)
                        Dim parLotNo As String = DirectCast(rgvAssyLineEff.Rows(rowcounter).Cells("fldLotNo").Value, String)
                        Dim parGoodQty As Integer = rgvAssyLineEff.Rows(rowcounter).Cells("fldGoodQty").Value
                        Dim parDelivered As String = DirectCast(rgvAssyLineEff.Rows(rowcounter).Cells("fldDelivered").Value, String)
                        Dim parReplacement As Integer = rgvAssyLineEff.Rows(rowcounter).Cells("fldReplacement").Value
                        Dim parAssyScrap As Integer = rgvAssyLineEff.Rows(rowcounter).Cells("fldAssyScrap").Value
                        Dim parSample As Integer = rgvAssyLineEff.Rows(rowcounter).Cells("fldSample").Value


                        If Tohka.InsertSRCAssyLineEff(Mio.DRID, tbALETime.Text, tbALEOpTime.Text, spnALEHotto.Value, Convert.ToInt32(tbPlanned.Text), Convert.ToInt32(tbUnplanned.Text), Convert.ToDouble(tbCycle.Text), parCustomer, parFGNo, parModel, parModelCode, parLotNo, parGoodQty, parDelivered, parReplacement, parAssyScrap, parSample) = "Good" Then

                        Else
                            MessageBox.Show("Error Occured")
                            Exit Sub
                        End If

                    Next
                    MessageBox.Show("Saved")
                    ReloadALEData()
                    'Else
                    'MessageBox.Show("Error Occured")
                    'End If
                    Exit Sub
                End If
            End If

        ElseIf globalVariables.assyStatus = "EDIT" Then


            If Tohka.EditSRCAssyLineEff(Mio.ID, tbALETime.Text, tbALEOpTime.Text, spnALEHotto.Value, Convert.ToInt32(tbPlanned.Text), Convert.ToInt32(tbUnplanned.Text), Convert.ToDouble(tbCycle.Text), tbALECustomer.Text, tbALEFGNo.Text, cbModelName.Text, tbALEModelCode.Text, tbALELotNo.Text, spnALEGoodQty.Value, If(cbDelivered.Checked, "Delivered", "Not Delivered"), spnALEReplace.Value, spnALEScrap.Value, spnALESample.Value) = "Good" Then

            Else
                MessageBox.Show("Error Occured")
                Exit Sub
            End If
            MessageBox.Show("Saved")
            ReloadALEData()



        End If
        'End If
    End Sub
    Private Sub btnAssyCancel_Click(sender As Object, e As EventArgs) Handles btnAssyCancel.Click
        btnAssyCancel.Visible = False
        globalVariables.assyStatus = "ADD"
        btnALESubmit.Text = "SAVE"

    End Sub
    Private Sub rgvAssyLineEff_DoubleClick(sender As Object, e As EventArgs) Handles rgvAssyLineEff.DoubleClick
        globalVariables.assyStatus = "EDIT"
        btnAssyCancel.Visible = True
        btnALESubmit.Text = "EDIT"
        Dim DTAle1 As DataTable = Tohka.SelectSrcALEData2("tblDailyReportAssyLineEff", Mio.DRID)
        Dim currentRow As Integer = rgvAssyLineEff.CurrentRow.Index
        Mio.ID = DTAle1.Rows(currentRow).Item("fldID").ToString()
        tbALETime.Text = DTAle1.Rows(currentRow).Item("fldTimePartition").ToString()
        spnALEHotto.Value = DTAle1.Rows(currentRow).Item("fldHotto").ToString()
        tbALEOpTime.Text = DTAle1.Rows(currentRow).Item("fldOpTime").ToString()
        tbPlanned.Text = DTAle1.Rows(currentRow).Item("fldPlanDownTime").ToString()
        tbCycle.Text = DTAle1.Rows(currentRow).Item("fldCycleTime").ToString()
        tbUnplanned.Text = DTAle1.Rows(currentRow).Item("fldUnPlanDownTime").ToString()
        tbALEFGNo.Text = DTAle1.Rows(currentRow).Item("fldFGNo")
        tbALECustomer.Text = DTAle1.Rows(currentRow).Item("fldCustomer").ToString()
        cbModelName.Text = DTAle1.Rows(currentRow).Item("fldModel").ToString()
        tbALEModelCode.Text = DTAle1.Rows(currentRow).Item("fldModelCode").ToString()
        tbALELotNo.Text = DTAle1.Rows(currentRow).Item("fldLotNo")
        spnALEGoodQty.Value = DTAle1.Rows(currentRow).Item("fldGoodQty")
        spnALEReplace.Value = DTAle1.Rows(currentRow).Item("fldReplacement")
        spnALEScrap.Value = DTAle1.Rows(currentRow).Item("fldAssyScrap")
        spnALESample.Value = DTAle1.Rows(currentRow).Item("fldSample")





    End Sub

    Private Sub ReloadALEData()
        Dim DTAle1 As DataTable = Tohka.SelectSrcALEData1("tblDailyReportAssyLineEff", Mio.DRID)
        Dim DTAle2 As DataTable = Tohka.SelectSrcALEData2("tblDailyReportAssyLineEff", Mio.DRID)

        If DTAle1.Rows.Count >= 1 Then

            tbALETime.Text = DTAle1.Rows(0).Item("fldTimePartition").ToString
            tbALEOpTime.Text = DTAle1.Rows(0).Item("fldOpTime").ToString
            spnALEHotto.Value = Convert.ToInt32(DTAle1.Rows(0).Item("fldHotto"))

            rgvAssyLineEff.DataSource = DTAle2

        Else

            GetDefaultALETime()

        End If

    End Sub

#End Region

#Region "SRC Assy"

    Private Sub GetSAPart()
        RemoveHandler ddSAPartNo.SelectedIndexChanged, AddressOf ddSAPartNo_SelectedIndexChanged
        Dim DTPart As DataTable = Tohka.SelectSrcTemplate("tblDailyReportSRCAssyTemplate", Mio.ModelCode, Mio.Line)
        ddSAPartNo.DataSource = DTPart
        ddSAPartNo.DisplayMember = "fldPartNo"
        ddSAPartNo.ValueMember = "fldPartName"
        ddSAPartNo.AutoCompleteDataSource = DTPart
        ddSAPartNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddSAPartNo.AutoCompleteDisplayMember = "fldPartNo"
        ddSAPartNo.AutoCompleteValueMember = "fldPartName"
        AddHandler ddSAPartNo.SelectedIndexChanged, AddressOf ddSAPartNo_SelectedIndexChanged
        ddSAPartNo.SelectedIndex = 1
        ddSAPartNo.SelectedIndex = ddSAPartNo.SelectedIndex - 1
    End Sub

    Private Sub ddSAPartNo_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddSAPartNo.SelectedIndexChanged
        tbSAPartName.Text = ddSAPartNo.SelectedValue
    End Sub

    Private Sub SRCAssyGrid()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvSRCAssy.Columns.Add(fldID)

        Dim fldPartNo As New GridViewTextBoxColumn
        fldPartNo.HeaderText = "Part No."
        fldPartNo.FieldName = "fldPartNo"
        fldPartNo.TextAlignment = ContentAlignment.MiddleCenter
        fldPartNo.MinWidth = 100
        fldPartNo.ReadOnly = True
        fldPartNo.IsPinned = True
        fldPartNo.PinPosition = PinnedColumnPosition.Left
        rgvSRCAssy.Columns.Add(fldPartNo)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 200
        fldPartName.ReadOnly = True
        fldPartName.IsPinned = True
        fldPartName.PinPosition = PinnedColumnPosition.Left
        rgvSRCAssy.Columns.Add(fldPartName)

        Dim fldLotNo As New GridViewTextBoxColumn
        fldLotNo.HeaderText = "Lot No"
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLotNo.MinWidth = 150
        rgvSRCAssy.Columns.Add(fldLotNo)

        Dim fldScrapQty As New GridViewTextBoxColumn
        fldScrapQty.HeaderText = "Scrap Qty"
        fldScrapQty.FieldName = "fldScrapQty"
        fldScrapQty.TextAlignment = ContentAlignment.MiddleCenter
        fldScrapQty.MinWidth = 150
        rgvSRCAssy.Columns.Add(fldScrapQty)

        Dim fldPurgeQty As New GridViewTextBoxColumn
        fldPurgeQty.HeaderText = "Purge Qty"
        fldPurgeQty.FieldName = "fldPurgeQty"
        fldPurgeQty.TextAlignment = ContentAlignment.MiddleCenter
        fldPurgeQty.MinWidth = 150
        rgvSRCAssy.Columns.Add(fldPurgeQty)

        Dim fldQASample As New GridViewTextBoxColumn
        fldQASample.HeaderText = "QA Sample"
        fldQASample.FieldName = "fldQASample"
        fldQASample.TextAlignment = ContentAlignment.MiddleCenter
        fldQASample.MinWidth = 150
        rgvSRCAssy.Columns.Add(fldQASample)

        Dim fldEngSample As New GridViewTextBoxColumn
        fldEngSample.HeaderText = "Engineering Sample"
        fldEngSample.FieldName = "fldEngSample"
        fldEngSample.TextAlignment = ContentAlignment.MiddleCenter
        fldEngSample.MinWidth = 150
        rgvSRCAssy.Columns.Add(fldEngSample)

        rgvSRCAssy.MasterTemplate.BestFitColumns()
    End Sub

    Private Sub btnSASubmit_Click(sender As Object, e As EventArgs) Handles btnSASubmit.Click
        If btnSASubmit.Text = "SAVE" Then
            MessageBox.Show(Tohka.InsertSRCAssy(Mio.DRID, ddSAPartNo.Text, tbSAPartName.Text, tbSALotNo.Text, tbSAScrap.Text, tbSAPurge.Text, tbSAQASample.Text, tbSAEng.Text))
            Dim CurrIndex As Integer = ddSAPartNo.SelectedIndex
            If CurrIndex < ddSAPartNo.Items.Count - 1 Then
                ddSAPartNo.SelectedIndex = CurrIndex + 1
            End If
        Else
            MessageBox.Show(Tohka.EditSRCAssy(lblSRCAssyID.Text, ddSAPartNo.Text, tbSAPartName.Text, tbSALotNo.Text, tbSAScrap.Text, tbSAPurge.Text, tbSAQASample.Text, tbSAEng.Text))
        End If
        btnSASubmit.Text = "SAVE"
        btnSACancel.Visible = False
        ReloadSRCAssyGrid()
    End Sub

    Private Sub ReloadSRCAssyGrid()

        rgvSRCAssy.DataSource = Tohka.SelectSrcTable("tblDailyReportSRCAssy", Mio.DRID)

    End Sub

    Private Sub rgvSRCAssy_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvSRCAssy.CellDoubleClick
        lblSRCAssyID.Text = rgvSRCAssy.CurrentRow.Cells("fldID").Value
        ddSAPartNo.Text = rgvSRCAssy.CurrentRow.Cells("fldPartNo").Value
        tbSAPartName.Text = rgvSRCAssy.CurrentRow.Cells("fldPartName").Value
        tbSALotNo.Text = rgvSRCAssy.CurrentRow.Cells("fldLotNo").Value
        tbSAScrap.Text = rgvSRCAssy.CurrentRow.Cells("fldScrapQty").Value
        tbSAPurge.Text = rgvSRCAssy.CurrentRow.Cells("fldPurgeQty").Value
        tbSAQASample.Text = rgvSRCAssy.CurrentRow.Cells("fldQASample").Value
        tbSAEng.Text = rgvSRCAssy.CurrentRow.Cells("fldEngSample").Value

        btnSASubmit.Text = "EDIT"
        btnSACancel.Visible = True

    End Sub

    Private Sub btnSACancel_Click(sender As Object, e As EventArgs) Handles btnSACancel.Click
        btnSASubmit.Text = "SAVE"
        btnSACancel.Visible = False
    End Sub

    Private Sub rgvSRCAssy_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvSRCAssy.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                MessageBox.Show(Tohka.DeleteSrcTable("tblDailyReportSRCAssy", rgvSRCAssy.CurrentRow.Cells("fldID").Value))
                ReloadSRCAssyGrid()
            End If
        End If
    End Sub



#End Region

#Region "SRC Defects"

    Private Sub SRCDefectsGrid()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvSRCDefects.Columns.Add(fldID)

        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 100
        rgvSRCDefects.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 120
        rgvSRCDefects.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 70
        rgvSRCDefects.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 70
        rgvSRCDefects.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 70
        rgvSRCDefects.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 70
        rgvSRCDefects.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 70
        rgvSRCDefects.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 70
        rgvSRCDefects.Columns.Add(fldRM)

        rgvSRCDefects.MasterTemplate.BestFitColumns()

    End Sub

    Private Sub ddSPDCategory_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddSPDCategory.SelectedIndexChanged

        ddSPDCode.Items.Clear()

        If ddSPDCategory.SelectedIndex = 0 Then
            ddSPDCode.Items.Add("Torque Error")
            ddSPDCode.Items.Add("Weld Error")
        ElseIf ddSPDCategory.SelectedIndex = 1 Then
            ddSPDCode.Items.Add("I/R Error")
            ddSPDCode.Items.Add("Mis-Insertion")
            ddSPDCode.Items.Add("Pattern Error")
            ddSPDCode.Items.Add("Pattern Open")
            ddSPDCode.Items.Add("Pattern Short")
        ElseIf ddSPDCategory.SelectedIndex = 2 Then

        ElseIf ddSPDCategory.SelectedIndex = 3 Then

        End If
        ReloadSRCDefectsGrid()

    End Sub

    Private Sub btnSPDSubmit_Click(sender As Object, e As EventArgs) Handles btnSPDSubmit.Click
        If ddSPDCategory.Text = "" Then
            MessageBox.Show("Please select category")
        Else
            If btnSPDSubmit.Text = "SAVE" Then
                Dim SPDCateg As String = ""
                If ddSPDCategory.SelectedIndex = 0 Then
                    SPDCateg = "A"
                ElseIf ddSPDCategory.SelectedIndex = 1 Then
                    SPDCateg = "B"
                ElseIf ddSPDCategory.SelectedIndex = 2 Then
                    SPDCateg = "C"
                ElseIf ddSPDCategory.SelectedIndex = 3 Then
                    SPDCateg = "D"
                End If

                MessageBox.Show(Tohka.InsertSRCDefect(Mio.DRID, ddSPDCode.Text, tbSPDPartName.Text, spnSPDMan.Value, spnSPDMachine.Value, spnSPDIM.Value, spnSPDFFC.Value, spnSPDSubAssy.Value, spnSPDRM.Value, SPDCateg))

            Else
                Dim SPDCateg As String = ""
                If ddSPDCategory.SelectedIndex = 0 Then
                    SPDCateg = "A"
                ElseIf ddSPDCategory.SelectedIndex = 1 Then
                    SPDCateg = "B"
                ElseIf ddSPDCategory.SelectedIndex = 2 Then
                    SPDCateg = "C"
                ElseIf ddSPDCategory.SelectedIndex = 3 Then
                    SPDCateg = "D"
                End If

                MessageBox.Show(Tohka.EditSRCDefect(lblDefectID.Text, ddSPDCode.Text, tbSPDPartName.Text, spnSPDMan.Value, spnSPDMachine.Value, spnSPDIM.Value, spnSPDFFC.Value, spnSPDSubAssy.Value, spnSPDRM.Value, SPDCateg))
                btnSPDSubmit.Text = "SAVE"
                btnSPDCancel.Visible = False

            End If
            ReloadSRCDefectsGrid()
        End If
    End Sub

    Private Sub rgvSRCDefects_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvSRCDefects.CellDoubleClick
        lblDefectID.Text = rgvSRCDefects.CurrentRow.Cells("fldID").Value
        ddSPDCode.Text = rgvSRCDefects.CurrentRow.Cells("fldDefCode").Value
        tbSPDPartName.Text = rgvSRCDefects.CurrentRow.Cells("fldPartName").Value
        spnSPDMan.Value = rgvSRCDefects.CurrentRow.Cells("fldMan").Value
        spnSPDMachine.Value = rgvSRCDefects.CurrentRow.Cells("fldMachine").Value
        spnSPDIM.Value = rgvSRCDefects.CurrentRow.Cells("fldIM").Value
        spnSPDFFC.Value = rgvSRCDefects.CurrentRow.Cells("fldFFC").Value
        spnSPDSubAssy.Value = rgvSRCDefects.CurrentRow.Cells("fldSubAssy").Value
        spnSPDRM.Value = rgvSRCDefects.CurrentRow.Cells("fldRM").Value

        btnSPDSubmit.Text = "EDIT"
        btnSPDCancel.Visible = True

    End Sub

    Private Sub rgvSRCDefects_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvSRCDefects.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                MessageBox.Show(Tohka.DeleteSrcTable("tblDailyReportSRCInProcDefect", rgvSRCDefects.CurrentRow.Cells("fldID").Value))
                ReloadSRCDefectsGrid()
            End If
        End If
    End Sub

    Private Sub btnSPDCancel_Click(sender As Object, e As EventArgs) Handles btnSPDCancel.Click
        btnSPDSubmit.Text = "SAVE"
        btnSPDCancel.Visible = False
    End Sub

    Private Sub ReloadSRCDefectsGrid()
        Dim SPDCateg As String = ""
        If ddSPDCategory.SelectedIndex = 0 Then
            SPDCateg = "A"
        ElseIf ddSPDCategory.SelectedIndex = 1 Then
            SPDCateg = "B"
        ElseIf ddSPDCategory.SelectedIndex = 2 Then
            SPDCateg = "C"
        ElseIf ddSPDCategory.SelectedIndex = 3 Then
            SPDCateg = "D"
        End If
        rgvSRCDefects.DataSource = Tohka.SelectSRCDefectByCateg("tblDailyReportSRCInProcDefect", Mio.DRID, SPDCateg)
    End Sub


#End Region

#Region "Others"

    Private Sub ReloadOtherData()

        Dim SelectOtherData As DataTable = Tohka.SelectSrcTable("tblDailyReportSRCOtherDetails", Mio.DRID)

        If SelectOtherData.Rows.Count >= 1 Then
            tbOtherA.Text = SelectOtherData.Rows(0).Item("fldMoldParts").ToString
            tbOtherB.Text = SelectOtherData.Rows(0).Item("fldInitProd").ToString
            tbOtherC.Text = SelectOtherData.Rows(0).Item("fldOthers").ToString
        End If

    End Sub

    Private Sub btnSubmitOther_Click(sender As Object, e As EventArgs) Handles btnSubmitOther.Click
        Dim OtherDelete As String = Tohka.DeleteSrcTableByDRID("tblDailyReportSRCOtherDetails", Mio.DRID)
        If OtherDelete = "Good" Then

            MessageBox.Show(Tohka.InsertSRCOther(Mio.DRID, tbOtherA.Text, tbOtherB.Text, tbOtherC.Text))

        Else
            MessageBox.Show(OtherDelete)
        End If

    End Sub

#End Region

#Region "LotNo"

    Private Sub GetLotNoTime()

        RemoveHandler ddLotTime.SelectedIndexChanged, AddressOf ddLotTime_SelectedIndexChanged

        ddLotTime.Items.Clear()

        Dim DTTimeRange As DataTable = Furina.MyQuery("SELECT * FROM dbMIA.tblDailyReportSRC where fldID='" & Mio.DRID & "'")
            Dim TimeRow As New DataTable
        TimeRow.Columns.Add("Time")

        Dim FromTime As DateTime = DTTimeRange.Rows(0).Item("fldTimeFrom")
        Dim ToTime As DateTime = DTTimeRange.Rows(0).Item("fldTimeTo")
        Dim ToMin As Integer = ToTime.Minute
        If ToMin = 0 Then
            While FromTime <= ToTime

                'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
                TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
                FromTime = FromTime.AddHours(1)

            End While
        Else
            While FromTime < ToTime

                'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
                TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
                FromTime = FromTime.AddHours(1)

            End While

            FromTime = FromTime.AddHours(-1)
            FromTime = FromTime.AddMinutes(ToMin)
            'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
            TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
        End If

        Dim TimeInt As Integer = 0
        While TimeInt < TimeRow.Rows.Count - 1
            ddLotTime.Items.Add(TimeRow.Rows(TimeInt).Item(0) & "-" & TimeRow.Rows(TimeInt + 1).Item(0))
            TimeInt += 1
        End While

        ddLotTime.Items.Add("Component Scrap QTY")
        ddLotTime.Items.Add("QA (QC) Sample")
        ddLotTime.Items.Add("Eng'g Sample")

        ddHQTime.SelectedIndex = 1
        ddHQTime.SelectedIndex = ddHQTime.SelectedIndex - 1
        AddHandler ddLotTime.SelectedIndexChanged, AddressOf ddLotTime_SelectedIndexChanged

    End Sub

    Private Sub GetLotNoPartName()

        Dim DTPartName As DataTable = Tohka.SelectSrcTemplate("tblDailyReportSRCRawMatsTemplate", Mio.Model, Mio.Line)
        ddLotPartName.DataSource = DTPartName
        ddLotPartName.DisplayMember = "fldPartName"
        ddLotPartName.ValueMember = "fldPartName"
        ddLotPartName.AutoCompleteDataSource = DTPartName
        ddLotPartName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddLotPartName.AutoCompleteDisplayMember = "fldPartName"
        ddLotPartName.AutoCompleteValueMember = "fldPartName"
        ddLotPartName.Text = ""

        ddLotPartName.SelectedIndex = 1
        ddLotPartName.SelectedIndex = ddLotPartName.SelectedIndex - 1

    End Sub

    Private Sub LotNoGrid()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvLotNo.Columns.Add(fldID)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.Width = 300
        rgvLotNo.Columns.Add(fldPartName)

        Dim fldBoxNo As New GridViewTextBoxColumn
        fldBoxNo.HeaderText = "Box No"
        fldBoxNo.FieldName = "fldBoxNo"
        fldBoxNo.TextAlignment = ContentAlignment.MiddleCenter
        fldBoxNo.Width = 200
        rgvLotNo.Columns.Add(fldBoxNo)

        Dim fldLotNo As New GridViewTextBoxColumn
        fldLotNo.HeaderText = "Lot No"
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLotNo.Width = 100
        rgvLotNo.Columns.Add(fldLotNo)

        Dim fldCavNo As New GridViewTextBoxColumn
        fldCavNo.HeaderText = "Cav No"
        fldCavNo.FieldName = "fldCavNo"
        fldCavNo.TextAlignment = ContentAlignment.MiddleCenter
        fldCavNo.Width = 100
        rgvLotNo.Columns.Add(fldCavNo)

    End Sub

    Private Sub RealoadLotNoGrid()

        rgvLotNo.DataSource = Tohka.SelectSRCLotByTime("tblDailyReportSRCRMWIP", Mio.DRID, ddLotTime.Text)

    End Sub

    Private Sub btnLotSubmit_Click(sender As Object, e As EventArgs) Handles btnLotSubmit.Click

        If ddLotTime.Text = "" Then
            MessageBox.Show("Please select the time")
        ElseIf ddLotPartName.Text = "" Then
            MessageBox.Show("Please select RM/WIP")
        ElseIf tbLotBoxNo.Text = "" Then
            MessageBox.Show("Box No is required")
        Else
            If btnLotSubmit.Text = "SAVE" Then

                MessageBox.Show(Tohka.InsertSRCLotNo(Mio.DRID, ddLotTime.Text, ddLotPartName.Text, tbLotBoxNo.Text, tbLotLotNo.Text, tbLotCavNo.Text))
                Dim CurrPartName As Integer = ddLotPartName.SelectedIndex
                If CurrPartName < ddLotPartName.Items.Count - 1 Then

                    ddLotPartName.SelectedIndex = CurrPartName + 1

                Else

                    Dim CurrTime As Integer = ddLotTime.SelectedIndex

                    If CurrTime < ddLotTime.Items.Count - 1 Then

                        ddLotTime.SelectedIndex = CurrTime + 1
                        ddLotPartName.SelectedIndex = 0

                    End If

                End If

            Else

                MessageBox.Show(Tohka.EditSRCLotNo(lblLotID.Text, ddLotTime.Text, ddLotPartName.Text, tbLotBoxNo.Text, tbLotLotNo.Text, tbLotCavNo.Text))
                If Tohka.SelectBlankDiffBoxNo(Mio.DRID, ddLotTime.Text, tbLotBoxNo.Text) >= 1 Then
                    MessageBox.Show(Tohka.EditSRCBoxNo(Mio.DRID, ddLotTime.Text, tbLotBoxNo.Text))
                End If
                btnLotSubmit.Text = "SAVE"
                btnLotCancel.Visible = False

            End If
            RealoadLotNoGrid()
        End If

    End Sub

    Private Sub ddLotTime_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddLotTime.SelectedIndexChanged
        RealoadLotNoGrid()
    End Sub

    Private Sub rgvLotNo_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvLotNo.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                MessageBox.Show(Tohka.DeleteSrcTable("tblDailyReportSRCRMWIP", rgvLotNo.CurrentRow.Cells("fldID").Value))
                ReloadSRCAssyGrid()
            End If
        End If
    End Sub

    Private Sub rgvLotNo_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvLotNo.CellDoubleClick

        lblLotID.Text = rgvLotNo.CurrentRow.Cells("fldID").Value
        ddLotPartName.Text = rgvLotNo.CurrentRow.Cells("fldPartName").Value
        tbLotBoxNo.Text = rgvLotNo.CurrentRow.Cells("fldBoxNo").Value
        tbLotLotNo.Text = rgvLotNo.CurrentRow.Cells("fldLotNo").Value
        tbLotCavNo.Text = rgvLotNo.CurrentRow.Cells("fldCavNo").Value

        btnLotSubmit.Text = "EDIT"
        btnLotCancel.Visible = True

    End Sub

    Private Sub btnLotCancel_Click(sender As Object, e As EventArgs) Handles btnLotCancel.Click
        btnLotSubmit.Text = "SAVE"
        btnLotCancel.Visible = False
    End Sub

    Private Sub spnALEHotto_ValueChanged(sender As Object, e As EventArgs)
        ComputeCycleTime()
    End Sub

    Private Sub rgvAssyLineEff_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvAssyLineEff.RowsChanged
        'ComputeCycleTime()
    End Sub

    Private Sub btnSRCAutoAdd_Click(sender As Object, e As EventArgs) Handles btnSRCAutoAdd.Click
        Dim ResultMsg As String = ""
        Dim result As Integer = MessageBox.Show("SRC Assy, Defects and Lot No. will automatically save", "Yes or No?", MessageBoxButtons.YesNo)

        'lblLoading.Visible = True

        If result = DialogResult.No Then

            'lblLoading.Visible = False
        Else
            Dim result2 As Integer = MessageBox.Show("This will replace current data if there is any", "Yes or No?", MessageBoxButtons.YesNo)

            If result2 = DialogResult.No Then

                'lblLoading.Visible = False

            Else

                BackgroundWorker1.RunWorkerAsync()

                'Try

                '    Dim DeleteMessageAssy As String = Tohka.DeleteSrcTableByDRID("tblDailyReportSRCAssy", Mio.DRID)
                '    If DeleteMessageAssy <> "Good" Then
                '        MessageBox.Show(DeleteMessageAssy)
                '        lblLoading.Visible = False
                '        Exit Sub
                '    End If
                '    Dim DTPart As DataTable = Tohka.SelectSrcTemplate("tblDailyReportSRCAssyTemplate", Mio.Model, Mio.Line)
                '    For Each row As DataRow In DTPart.Rows
                '        Dim SaveMsg As String = Tohka.InsertSRCAssy(Mio.DRID, row.Item("fldPartNo").ToString, row.Item("fldPartName").ToString, "", "", "", "", "")
                '        If SaveMsg <> "Good" Then
                '            MessageBox.Show(SaveMsg)
                '            lblLoading.Visible = False
                '            Exit Sub
                '        End If
                '    Next
                '    Dim DTTempDefCode As New DataTable
                '    DTTempDefCode.Columns.Add("DefCode")
                '    DTTempDefCode.Columns.Add("Categ")
                '    DTTempDefCode.Rows.Add("Torque Error", "A")
                '    DTTempDefCode.Rows.Add("Weld Error", "A")
                '    DTTempDefCode.Rows.Add("I/R Error", "B")
                '    DTTempDefCode.Rows.Add("Mis-Insertion", "B")
                '    DTTempDefCode.Rows.Add("Pattern Error", "B")
                '    DTTempDefCode.Rows.Add("Pattern Open", "B")
                '    DTTempDefCode.Rows.Add("Pattern Short", "B")
                '    DTTempDefCode.Rows.Add("", "C")
                '    DTTempDefCode.Rows.Add("", "D")

                '    Dim DeleteMessageDefects As String = Tohka.DeleteSrcTableByDRID("tblDailyReportSRCInProcDefect", Mio.DRID)
                '    If DeleteMessageDefects <> "Good" Then
                '        MessageBox.Show(DeleteMessageDefects)
                '        lblLoading.Visible = False
                '        Exit Sub
                '    End If

                '    For Each row As DataRow In DTTempDefCode.Rows
                '        Dim SaveMsg As String = Tohka.InsertSRCDefect(Mio.DRID, row.Item("DefCode"), "", 0, 0, 0, 0, 0, 0, row.Item("Categ"))
                '        If SaveMsg <> "Good" Then
                '            MessageBox.Show(SaveMsg)
                '            lblLoading.Visible = False
                '            Exit Sub
                '        End If
                '    Next

                '    Dim DeleteMessageLotNo As String = Tohka.DeleteSrcTableByDRID("tblDailyReportSRCRMWIP", Mio.DRID)
                '    If DeleteMessageLotNo <> "Good" Then
                '        MessageBox.Show(DeleteMessageLotNo)
                '        lblLoading.Visible = False
                '        Exit Sub
                '    End If

                '    Dim TimeCount As Integer = 0
                '    Dim DTPartName As DataTable = Tohka.SelectSrcTemplate("tblDailyReportSRCRawMatsTemplate", Mio.Model, Mio.Line)
                '    While TimeCount <= ddLotTime.Items.Count - 1
                '        Dim UwU As String = ddLotTime.Items(TimeCount).ToString
                '        For Each row As DataRow In DTPartName.Rows
                '            Dim SaveMSG As String = Tohka.InsertSRCLotNo(Mio.DRID, UwU, row.Item("fldPartName"), "", "", "")
                '            If SaveMSG <> "Good" Then
                '                MessageBox.Show(SaveMSG)
                '                lblLoading.Visible = False
                '                Exit Sub
                '            End If
                '        Next
                '        TimeCount = TimeCount + 1
                '    End While

                '    MessageBox.Show("Upload Done")
                '    lblLoading.Visible = False

                'Catch ex As Exception

                '    MessageBox.Show(ex.Message)
                '    lblLoading.Visible = False

                'End Try

            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim counter As Integer = 0
        Try

            Dim DeleteMessageAssy As String = Tohka.DeleteSrcTableByDRID("tblDailyReportSRCAssy", Mio.DRID)
            If DeleteMessageAssy <> "Good" Then
                MessageBox.Show(DeleteMessageAssy)
                lblLoading.Visible = False
                Exit Sub
            End If
            Dim DTPart As DataTable = Tohka.SelectSrcTemplate("tblDailyReportSRCAssyTemplate", Mio.ModelCode, Mio.Line)

            For Each row As DataRow In DTPart.Rows

                Dim SaveMsg As String = Tohka.InsertSRCAssy(Mio.DRID, row.Item("fldPartNo").ToString, row.Item("fldPartName").ToString, "", "", "", "", "")
                If SaveMsg <> "Good" Then
                    MessageBox.Show(SaveMsg)
                    'lblLoading.Visible = False
                    Exit Sub
                End If

                Dim percent As Double = counter / DTPart.Rows.Count * 100
                RadProgressBar1.Text = "SRC ASSY"
                BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
                Threading.Thread.Sleep(50)
                counter = counter + 1
            Next

            Dim DTTempDefCode As New DataTable
            DTTempDefCode.Columns.Add("DefCode")
            DTTempDefCode.Columns.Add("Categ")
            DTTempDefCode.Rows.Add("Torque Error", "A")
            DTTempDefCode.Rows.Add("Weld Error", "A")
            DTTempDefCode.Rows.Add("I/R Error", "B")
            DTTempDefCode.Rows.Add("Mis-Insertion", "B")
            DTTempDefCode.Rows.Add("Pattern Error", "B")
            DTTempDefCode.Rows.Add("Pattern Open", "B")
            DTTempDefCode.Rows.Add("Pattern Short", "B")
            DTTempDefCode.Rows.Add("", "C")
            DTTempDefCode.Rows.Add("", "D")

            Dim DeleteMessageDefects As String = Tohka.DeleteSrcTableByDRID("tblDailyReportSRCInProcDefect", Mio.DRID)
            If DeleteMessageDefects <> "Good" Then
                MessageBox.Show(DeleteMessageDefects)
                'lblLoading.Visible = False
                Exit Sub
            End If
            counter = 0
            For Each row As DataRow In DTTempDefCode.Rows
                Dim SaveMsg As String = Tohka.InsertSRCDefect(Mio.DRID, row.Item("DefCode"), "", 0, 0, 0, 0, 0, 0, row.Item("Categ"))
                If SaveMsg <> "Good" Then
                    MessageBox.Show(SaveMsg)
                    'lblLoading.Visible = False
                    Exit Sub
                End If
                Dim percent As Double = counter / DTTempDefCode.Rows.Count * 100
                RadProgressBar1.Text = "DEFECTS"
                BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
                Threading.Thread.Sleep(50)
                counter = counter + 1
            Next

            Dim DeleteMessageLotNo As String = Tohka.DeleteSrcTableByDRID("tblDailyReportSRCRMWIP", Mio.DRID)
            If DeleteMessageLotNo <> "Good" Then
                MessageBox.Show(DeleteMessageLotNo)
                'lblLoading.Visible = False
                Exit Sub
            End If

            Dim TimeCount As Integer = 0
            Dim DTPartName As DataTable = Tohka.SelectSrcTemplate("tblDailyReportSRCRawMatsTemplate", Mio.Model, Mio.Line)
            While TimeCount <= ddLotTime.Items.Count - 1
                Dim UwU As String = ddLotTime.Items(TimeCount).ToString
                counter = 0
                For Each row As DataRow In DTPartName.Rows
                    Dim SaveMSG As String = Tohka.InsertSRCLotNo(Mio.DRID, UwU, row.Item("fldPartName"), "", "", "")
                    If SaveMSG <> "Good" Then
                        MessageBox.Show(SaveMSG)
                        'lblLoading.Visible = False
                        Exit Sub
                    End If
                    Dim percent As Double = counter / DTPartName.Rows.Count * 100
                    RadProgressBar1.Text = "Lot: " & UwU
                    BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
                    Threading.Thread.Sleep(50)
                    counter = counter + 1
                Next
                TimeCount = TimeCount + 1
            End While

            'MessageBox.Show("Upload Done")
            'lblLoading.Visible = False

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            'lblLoading.Visible = False

        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        RadProgressBar1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Upload Done")
        RadProgressBar1.Value1 = 0
        RadProgressBar1.Text = ""
    End Sub

    Private Sub tbOtherA_KeyDown(sender As Object, e As KeyEventArgs) Handles tbOtherA.KeyDown

        If e.KeyCode = Keys.Enter Then
            tbOtherA.AppendText(Environment.NewLine)
        End If

    End Sub

    Private Sub tbOtherB_KeyDown(sender As Object, e As KeyEventArgs) Handles tbOtherB.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbOtherB.AppendText(Environment.NewLine)
        End If
    End Sub

    Private Sub tbOtherC_KeyDown(sender As Object, e As KeyEventArgs) Handles tbOtherC.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbOtherC.AppendText(Environment.NewLine)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        globalVariables.DailyRepEditTimePart = tbALETime.Text
        globalVariables.DailyRepNewOPTime = tbALEOpTime.Text

        FrmEditLineTimePart.ShowDialog(Me)

        tbALETime.Text = globalVariables.DailyRepEditTimePart
        tbALEOpTime.Text = globalVariables.DailyRepNewOPTime
        ComputeCycleTime()
    End Sub

    Private Sub btnReCons_Click(sender As Object, e As EventArgs) Handles btnReCons.Click

        Dim result As Integer = MessageBox.Show("This will delete some excess data. Do you want to proceed?", "Yes or No?", MessageBoxButtons.YesNo)

        'lblLoading.Visible = True

        If result = DialogResult.No Then
            RadMessageBox.Show("Operation Cancelled!")
        Else

            Dim DTTimeRange As DataTable = Furina.MyQuery("SELECT * FROM dbMIA.tblDailyReportSRC where fldID='" & Mio.DRID & "'")
            Dim TimeRow As New DataTable
            Dim AllTIme As New DataTable
            TimeRow.Columns.Add("Time")
            AllTIme.Columns.Add("Time")

            Dim FromTime As DateTime = DTTimeRange.Rows(0).Item("fldTimeFrom")
            Dim ToTime As DateTime = DTTimeRange.Rows(0).Item("fldTimeTo")
            Dim ToMin As Integer = ToTime.Minute
            If ToMin = 0 Then
                While FromTime <= ToTime

                    'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
                    TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
                    FromTime = FromTime.AddHours(1)

                End While
            Else
                While FromTime < ToTime

                    'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
                    TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
                    FromTime = FromTime.AddHours(1)

                End While

                FromTime = FromTime.AddHours(-1)
                FromTime = FromTime.AddMinutes(ToMin)
                'ddHQTime.Items.Add(FromTime.ToString("HH':'mm"))
                TimeRow.Rows.Add(FromTime.ToString("HH':'mm"))
            End If

            Dim TimeInt As Integer = 0
            While TimeInt < TimeRow.Rows.Count - 1
                AllTIme.Rows.Add(TimeRow.Rows(TimeInt).Item(0) & "-" & TimeRow.Rows(TimeInt + 1).Item(0))
                TimeInt += 1
            End While
            AllTIme.Rows.Add("Component Scrap QTY")
            AllTIme.Rows.Add("QA (QC) Sample")
            AllTIme.Rows.Add("Eng'g Sample")

            Dim SavedLot As DataTable = Furina.MyQuery("SELECT fldTime FROM tblDailyReportSRCRMWIP where fldDRID='" & Mio.DRID & "' group by fldTime")


            Dim TimeWithAdjust As String = ""
            Dim TimeAdjustVal As String = ""
            Dim TimeForDelete As New DataTable
            TimeForDelete.Columns.Add("Time")
            'Stay, Delete, Change
            Dim TImeStat As String = "Delete"
            Dim TimeDup As Integer = 0

            For Each row As DataRow In SavedLot.Rows

                'RadMessageBox.Show(row.Item("fldTime"))
                TImeStat = "Delete"
                TimeDup = 0
                For Each rowEtime As DataRow In AllTIme.Rows
                    If row.Item("fldTime") <> rowEtime.Item("Time") Then

                        Dim TimeOld() As String = row.Item("fldTime").ToString.Split("-")
                        Dim TimeNew() As String = rowEtime.Item("Time").ToString.Split("-")

                        If TimeNew(0) = TimeOld(0) Then
                            TimeWithAdjust = row.Item("fldTime")
                            TimeAdjustVal = rowEtime.Item("Time")
                            TImeStat = "Change"
                        End If

                    Else

                        TimeDup = TimeDup + 1

                    End If

                Next

                If TimeDup <= 0 Then
                    If TImeStat <> "Change" Then
                        TimeForDelete.Rows.Add(row.Item("fldTime"))
                    End If
                End If

            Next
            If TimeForDelete.Rows.Count >= 1 Then
                For Each rowEtime As DataRow In TimeForDelete.Rows
                    'RadMessageBox.Show(rowEtime.Item("Time"))
                    Furina.AddMySqlParameters("parID", Mio.DRID)
                    Furina.AddMySqlParameters("parTime", rowEtime.Item("Time"))
                    Furina.SPADE("SP_SRC_DeleteSRCLotByTime")

                Next
            End If
            If TimeWithAdjust <> "" Then
                Furina.AddMySqlParameters("parID", Mio.DRID)
                Furina.AddMySqlParameters("parTimeOld", TimeWithAdjust)
                Furina.AddMySqlParameters("parTimeNew", TimeAdjustVal)
                Furina.SPADE("SP_SRC_EditSRCLotByTime")
            End If
            RadMessageBox.Show("Done")
        End If

    End Sub

    Private Sub cbManpower_TextChanged(sender As Object, e As EventArgs) Handles cbManpower.TextChanged
        GetTeam()
    End Sub

    Private Sub cbModelName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbModelName.SelectedValueChanged
        GetCodeFG()
    End Sub

    Private Sub FrmSRCDailyReportNewV2_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AddHandler cbModelName.SelectedValueChanged, AddressOf cbModelName_SelectedValueChanged
        GetCodeFG()
    End Sub

    Private Sub ddHQTime_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddHQTime.SelectedIndexChanged
        getHourlyPlan()
    End Sub






#End Region

End Class
