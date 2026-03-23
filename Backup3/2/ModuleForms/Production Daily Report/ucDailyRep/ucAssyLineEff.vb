Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ucAssyLineEff
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim rowIndex As Integer
    Private Sub ucAssyLineEff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridCol()
        ReloadGrid()
        ComputeCycleTime()
    End Sub

    Private Sub ReloadGrid()
        Dim DTCheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportAssyLineEff where fldDRID=" & globalVariables.DailyRepID & "")

        If DTCheckExist.Rows.Count >= 1 Then

            tbTimePartition.Text = DTCheckExist.Rows(0).Item("fldTimePartition").ToString
            tbOpTime.Text = DTCheckExist.Rows(0).Item("fldOpTime").ToString
            spnHotto.Value = DTCheckExist.Rows(0).Item("fldHotto")
            'spnPlanDT.Value = DTCheckExist.Rows(0).Item("fldPlanDownTime")
            'spnUnplanDT.Value = DTCheckExist.Rows(0).Item("fldUnPlanDownTime")
            'tbCycleTime.Text = DTCheckExist.Rows(0).Item("fldCycleTime").ToString

            gvData.DataSource = DTCheckExist

        Else

            If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then

                Dim Timeline As String = "06:00-14:00"
                Dim TimeLineMin As Integer = 480

                tbTimePartition.Text = Timeline
                tbOpTime.Text = TimeLineMin

            ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then

                Dim Timeline As String = "06:00-18:00"
                Dim TimeLineMin As Integer = 720

                tbTimePartition.Text = Timeline
                tbOpTime.Text = TimeLineMin

            ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then

                Dim Timeline As String = "14:00-22:00"
                Dim TimeLineMin As Integer = 480

                tbTimePartition.Text = Timeline
                tbOpTime.Text = TimeLineMin

            ElseIf globalVariables.DailyRepShift = "6PM-6AM" Then

                Dim Timeline As String = "18:00-06:00"
                Dim TimeLineMin As Integer = 720

                tbTimePartition.Text = Timeline
                tbOpTime.Text = TimeLineMin

            ElseIf globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then

                Dim Timeline As String = "22:00-06:00"
                Dim TimeLineMin As Integer = 480

                tbTimePartition.Text = Timeline
                tbOpTime.Text = TimeLineMin

            End If

        End If
        GetDownTime()
    End Sub

    Private Sub GetDownTime()

        Dim ShiftConv As String = ""

        If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
            ShiftConv = "1st Shift"
        ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
            ShiftConv = "Day Shift"
        ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
            ShiftConv = "2nd Shift"
        ElseIf globalVariables.DailyRepShift = "6PM-6AM" Then
            ShiftConv = "Night Shift"
        ElseIf globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then
            ShiftConv = "3rd Shift"
        End If

        Maria.AddMySqlParameters("parModel", globalVariables.AssyDownTimeModel)
        Maria.AddMySqlParameters("parShift", ShiftConv)
        Maria.AddMySqlParameters("parDate", globalVariables.AssyDownTimeDate)
        Maria.AddMySqlParameters("parPlan", 1)
        Maria.AddMySqlParameters("parType", "ASSY")
        Dim DTDownTimeCheckPlan As DataTable = Maria.SPSelect("SP_SRCDownTime_SelectByDailyReport")
        If DTDownTimeCheckPlan.Rows.Count >= 1 Then
            If IsDBNull(DTDownTimeCheckPlan.Rows(0).Item("TotalDT")) Then
                spnPlanDT.Value = 0
            Else
                spnPlanDT.Value = Convert.ToInt32(DTDownTimeCheckPlan.Rows(0).Item("TotalDT"))
            End If
        Else
            spnPlanDT.Value = 0
        End If


        Maria.AddMySqlParameters("parModel", globalVariables.AssyDownTimeModel)
        Maria.AddMySqlParameters("parShift", ShiftConv)
        Maria.AddMySqlParameters("parDate", globalVariables.AssyDownTimeDate)
        Maria.AddMySqlParameters("parPlan", 0)
        Maria.AddMySqlParameters("parType", "ASSY")
        Dim DTDownTimeCheckUnplan As DataTable = Maria.SPSelect("SP_SRCDownTime_SelectByDailyReport2")
        If DTDownTimeCheckUnplan.Rows.Count >= 1 Then
            If IsDBNull(DTDownTimeCheckUnplan.Rows(0).Item("TotalDT")) Then
                spnUnplanDT.Value = 0
            Else
                spnUnplanDT.Value = Convert.ToInt32(DTDownTimeCheckUnplan.Rows(0).Item("TotalDT"))
            End If
        Else
            spnUnplanDT.Value = 0
        End If

    End Sub

    Private Sub GridCol()
        'Dim fldTimePartition As New GridViewTextBoxColumn
        'fldTimePartition.HeaderText = "Line Time Partition"
        'fldTimePartition.FieldName = "fldTimePartition"
        'fldTimePartition.TextAlignment = ContentAlignment.MiddleCenter
        'fldTimePartition.MinWidth = 120
        'fldTimePartition.ReadOnly = True
        'fldTimePartition.IsPinned = True
        'fldTimePartition.PinPosition = PinnedColumnPosition.Left
        'gvData.Columns.Add(fldTimePartition)

        'Dim fldOpTime As New GridViewDecimalColumn
        'fldOpTime.HeaderText = "Operation Time(Mins)"
        'fldOpTime.FieldName = "fldOpTime"
        'fldOpTime.TextAlignment = ContentAlignment.MiddleCenter
        'fldOpTime.MinWidth = 120
        'fldOpTime.ReadOnly = True
        'gvData.Columns.Add(fldOpTime)

        'Dim fldHotto As New GridViewDecimalColumn
        'fldHotto.HeaderText = "5's, Hotto, Break"
        'fldHotto.FieldName = "fldHotto"
        'fldHotto.TextAlignment = ContentAlignment.MiddleCenter
        'fldHotto.MinWidth = 120
        'gvData.Columns.Add(fldHotto)

        'Dim fldPlanDownTime As New GridViewDecimalColumn
        'fldPlanDownTime.HeaderText = "Planned Downtime"
        'fldPlanDownTime.FieldName = "fldPlanDownTime"
        'fldPlanDownTime.TextAlignment = ContentAlignment.MiddleCenter
        'fldPlanDownTime.MinWidth = 120
        'gvData.Columns.Add(fldPlanDownTime)

        'Dim fldUnPlanDownTime As New GridViewDecimalColumn
        'fldUnPlanDownTime.HeaderText = "Unplanned Downtime"
        'fldUnPlanDownTime.FieldName = "fldUnPlanDownTime"
        'fldUnPlanDownTime.TextAlignment = ContentAlignment.MiddleCenter
        'fldUnPlanDownTime.MinWidth = 120
        'gvData.Columns.Add(fldUnPlanDownTime)

        'Dim fldCycleTime As New GridViewTextBoxColumn
        'fldCycleTime.HeaderText = "Cycle Time"
        'fldCycleTime.FieldName = "fldCycleTime"
        'fldCycleTime.TextAlignment = ContentAlignment.MiddleCenter
        'fldCycleTime.MinWidth = 120
        'fldCycleTime.ReadOnly = True
        'gvData.Columns.Add(fldCycleTime)

        Dim fldCustomer As New GridViewTextBoxColumn
        fldCustomer.HeaderText = "Customer"
        fldCustomer.FieldName = "fldCustomer"
        fldCustomer.TextAlignment = ContentAlignment.MiddleCenter
        fldCustomer.MinWidth = 120
        gvData.Columns.Add(fldCustomer)

        Dim fldFGNo As New GridViewTextBoxColumn
        fldFGNo.HeaderText = "FG No."
        fldFGNo.FieldName = "fldFGNo"
        fldFGNo.TextAlignment = ContentAlignment.MiddleCenter
        fldFGNo.MinWidth = 120
        gvData.Columns.Add(fldFGNo)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "Model Name"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.MinWidth = 120
        gvData.Columns.Add(fldModel)

        Dim fldModelCode As New GridViewTextBoxColumn
        fldModelCode.HeaderText = "Model Code"
        fldModelCode.FieldName = "fldModelCode"
        fldModelCode.TextAlignment = ContentAlignment.MiddleCenter
        fldModelCode.MinWidth = 120
        gvData.Columns.Add(fldModelCode)

        Dim fldLotNo As New GridViewTextBoxColumn
        fldLotNo.HeaderText = "Lot No."
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLotNo.MinWidth = 120
        gvData.Columns.Add(fldLotNo)

        Dim fldGoodQty As New GridViewTextBoxColumn
        fldGoodQty.HeaderText = "Good Qty."
        fldGoodQty.FieldName = "fldGoodQty"
        fldGoodQty.TextAlignment = ContentAlignment.MiddleCenter
        fldGoodQty.MinWidth = 120
        gvData.Columns.Add(fldGoodQty)

        Dim fldReplacement As New GridViewTextBoxColumn
        fldReplacement.HeaderText = "Replacement"
        fldReplacement.FieldName = "fldReplacement"
        fldReplacement.TextAlignment = ContentAlignment.MiddleCenter
        fldReplacement.MinWidth = 120
        gvData.Columns.Add(fldReplacement)

        Dim fldAssyScrap As New GridViewTextBoxColumn
        fldAssyScrap.HeaderText = "Assembly Scrap"
        fldAssyScrap.FieldName = "fldAssyScrap"
        fldAssyScrap.TextAlignment = ContentAlignment.MiddleCenter
        fldAssyScrap.MinWidth = 120
        gvData.Columns.Add(fldAssyScrap)

        Dim fldSample As New GridViewTextBoxColumn
        fldSample.HeaderText = "Sample"
        fldSample.FieldName = "fldSample"
        fldSample.TextAlignment = ContentAlignment.MiddleCenter
        fldSample.MinWidth = 120
        gvData.Columns.Add(fldSample)

        Dim summaryItem As New GridViewSummaryItem()
        summaryItem.Name = "fldGoodQty"
        summaryItem.AggregateExpression = "Sum(fldGoodQty) "
        Dim summaryRowItem As New GridViewSummaryRowItem()
        summaryRowItem.Add(summaryItem)
        Me.gvData.SummaryRowsBottom.Add(summaryRowItem)

        gvData.MasterTemplate.BestFitColumns()

    End Sub

    Private Sub gvData_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellEndEdit
        ComputeCycleTime()
        'Try

        '    Dim HottoVal As Integer = spnHotto.Value
        '    Dim PlanedDTVal As Integer = spnPlanDT.Value
        '    Dim UnplanedDTVal As Integer = spnUnplanDT.Value
        '    Dim OPTimeVal As Integer = Convert.ToInt32(tbOpTime.Text)

        '    Dim sum As Decimal = 0

        '    For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

        '        Dim fldGoodQty As Integer = gvData.Rows(rowcounter).Cells("fldGoodQty").Value

        '        sum = sum + fldGoodQty

        '    Next

        '    Dim CycleTime As Decimal = ((OPTimeVal - (HottoVal + PlanedDTVal + UnplanedDTVal)) * 60) / sum

        '    tbCycleTime.Text = Math.Round(CycleTime, 2)

        '    'gvData.Rows(0).Cells("fldCycleTime").Value = Math.Round(CycleTime, 2)

        'Catch ex As Exception

        '    tbCycleTime.Text = 0
        '    'gvData.Rows(0).Cells("fldCycleTime").Value = 0

        'End Try

    End Sub

    Private Sub gvData_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles gvData.UserAddedRow

        Try

            Dim HottoVal As Integer = spnHotto.Value
            Dim PlanedDTVal As Integer = spnPlanDT.Value
            Dim UnplanedDTVal As Integer = spnUnplanDT.Value
            Dim OPTimeVal As Integer = Convert.ToInt32(tbOpTime.Text)

            Dim sum As Decimal = 0

            For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

                Dim fldGoodQty As Integer = gvData.Rows(rowcounter).Cells("fldGoodQty").Value

                sum = sum + fldGoodQty

            Next

            Dim CycleTime As Decimal = ((OPTimeVal - (HottoVal + PlanedDTVal + UnplanedDTVal)) * 60) / sum

            tbCycleTime.Text = Math.Round(CycleTime, 2)

            'gvData.Rows(0).Cells("fldCycleTime").Value = Math.Round(CycleTime, 2)

        Catch ex As Exception

            tbCycleTime.Text = 0
            'gvData.Rows(0).Cells("fldCycleTime").Value = 0

        End Try

    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs)

        If e.CellElement.ColumnInfo.FieldName = "fldCustomer" Then
            If e.CellElement.RowInfo.Cells("fldCustomer").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        ElseIf e.CellElement.ColumnInfo.FieldName = "fldFGNo" Then
            If e.CellElement.RowInfo.Cells("fldFGNo").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        ElseIf e.CellElement.ColumnInfo.FieldName = "fldModel" Then
            If e.CellElement.RowInfo.Cells("fldModel").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        ElseIf e.CellElement.ColumnInfo.FieldName = "fldModelCode" Then
            If e.CellElement.RowInfo.Cells("fldModelCode").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        ElseIf e.CellElement.ColumnInfo.FieldName = "fldLotNo" Then
            If e.CellElement.RowInfo.Cells("fldLotNo").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        ElseIf e.CellElement.ColumnInfo.FieldName = "fldGoodQty" Then
            If e.CellElement.RowInfo.Cells("fldGoodQty").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        ElseIf e.CellElement.ColumnInfo.FieldName = "fldReplacement" Then
            If e.CellElement.RowInfo.Cells("fldReplacement").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        ElseIf e.CellElement.ColumnInfo.FieldName = "fldAssyScrap" Then
            If e.CellElement.RowInfo.Cells("fldAssyScrap").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        ElseIf e.CellElement.ColumnInfo.FieldName = "fldSample" Then
            If e.CellElement.RowInfo.Cells("fldSample").Value Is Nothing Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.White
                e.CellElement.BackColor = Color.LightPink
                e.CellElement.BackColor2 = Color.LightPink
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            End If
            e.CellElement.Enabled = True
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
        End If

    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        Dim result As Integer = RadMessageBox.Show("Are you sure you want to save?", "Yes or No?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            cbbSave.Enabled = False
            cbbClear.Enabled = False
            BackgroundWorker1.RunWorkerAsync()
        End If

        'MessageBox.Show(gvData.Rows.Count)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try
            Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
            Maria.SPADE("SP_SRCDailyReport_DeleteAssyLineEff")
            For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

                Dim parDRID As Integer = globalVariables.DailyRepID
                Dim parTimePartition As String = tbTimePartition.Text
                Dim parOpTime As Integer = Convert.ToInt32(tbOpTime.Text)
                Dim parHotto As Integer = spnHotto.Value
                Dim parPlanDownTime As Integer = spnPlanDT.Value
                Dim parUnPlanDownTime As Integer = spnUnplanDT.Value
                Dim parCycleTime As Decimal = Convert.ToDecimal(tbCycleTime.Text)
                Dim parCustomer As String = DirectCast(gvData.Rows(rowcounter).Cells("fldCustomer").Value, String)
                Dim parFGNo As String = gvData.Rows(rowcounter).Cells("fldFGNo").Value.ToString
                Dim parModel As String = DirectCast(gvData.Rows(rowcounter).Cells("fldModel").Value, String)
                Dim parModelCode As String = DirectCast(gvData.Rows(rowcounter).Cells("fldModelCode").Value, String)
                Dim parLotNo As String = DirectCast(gvData.Rows(rowcounter).Cells("fldLotNo").Value, String)
                Dim parGoodQty As Integer = gvData.Rows(rowcounter).Cells("fldGoodQty").Value
                Dim parReplacement As Integer = gvData.Rows(rowcounter).Cells("fldReplacement").Value
                Dim parAssyScrap As Integer = gvData.Rows(rowcounter).Cells("fldAssyScrap").Value
                Dim parSample As Integer = gvData.Rows(rowcounter).Cells("fldSample").Value
                Dim parUser As String = globalVariables.currentUser(1)

                Maria.AddMySqlParameters("parDRID", parDRID)
                Maria.AddMySqlParameters("parTimePartition", parTimePartition)
                Maria.AddMySqlParameters("parOpTime", parOpTime)
                Maria.AddMySqlParameters("parHotto", parHotto)
                Maria.AddMySqlParameters("parPlanDownTime", parPlanDownTime)
                Maria.AddMySqlParameters("parUnPlanDownTime", parUnPlanDownTime)
                Maria.AddMySqlParameters("parCycleTime", parCycleTime)
                Maria.AddMySqlParameters("parCustomer", parCustomer)
                Maria.AddMySqlParameters("parFGNo", parFGNo)
                Maria.AddMySqlParameters("parModel", parModel)
                Maria.AddMySqlParameters("parModelCode", parModelCode)
                Maria.AddMySqlParameters("parLotNo", parLotNo)
                Maria.AddMySqlParameters("parGoodQty", parGoodQty)
                Maria.AddMySqlParameters("parReplacement", parReplacement)
                Maria.AddMySqlParameters("parAssyScrap", parAssyScrap)
                Maria.AddMySqlParameters("parSample", parSample)
                Maria.AddMySqlParameters("parUser", parUser)
                Maria.SPADE("SP_SRC_InsertAssyLineEff")

                Threading.Thread.Sleep(60)
                Dim RowCount As Integer = gvData.Rows.Count
                rowIndex = rowcounter
                Dim percent As Double = (rowcounter / RowCount * 100)
                BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))

            Next
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
            Maria.Connection.Close()
            cbbSave.Enabled = True
            cbbClear.Enabled = True
        End Try

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        gvData.CurrentRow = gvData.Rows(rowIndex)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        RadMessageBox.Show("Done!")

        cbbSave.Enabled = True
        cbbClear.Enabled = True
    End Sub

    Private Sub cbbClear_Click(sender As Object, e As EventArgs) Handles cbbClear.Click
        Dim result As Integer = RadMessageBox.Show("Data inputed will be removed. Continue?", "Yes or No?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            spnHotto.Value = 0
            spnPlanDT.Value = 0
            spnUnplanDT.Value = 0
            tbCycleTime.Text = 0
            gvData.DataSource = Nothing
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        globalVariables.DailyRepEditTimePart = tbTimePartition.Text
        globalVariables.DailyRepNewOPTime = tbOpTime.Text

        FrmEditLineTimePart.ShowDialog(Me)

        tbTimePartition.Text = globalVariables.DailyRepEditTimePart
        tbOpTime.Text = globalVariables.DailyRepNewOPTime

    End Sub

    Private Sub spnHotto_ValueChanged(sender As Object, e As EventArgs) Handles spnHotto.ValueChanged
        ComputeCycleTime()
    End Sub
    Private Sub ComputeCycleTime()
        Try

            Dim HottoVal As Integer = spnHotto.Value
            Dim PlanedDTVal As Integer = spnPlanDT.Value
            Dim UnplanedDTVal As Integer = spnUnplanDT.Value
            Dim OPTimeVal As Integer = Convert.ToInt32(tbOpTime.Text)

            Dim sum As Decimal = 0

            For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

                Dim fldGoodQty As Integer = gvData.Rows(rowcounter).Cells("fldGoodQty").Value

                sum = sum + fldGoodQty

            Next

            Dim CycleTime As Decimal = ((OPTimeVal - (HottoVal + PlanedDTVal + UnplanedDTVal)) * 60) / sum

            tbCycleTime.Text = Math.Round(CycleTime, 2)

            'gvData.Rows(0).Cells("fldCycleTime").Value = Math.Round(CycleTime, 2)

        Catch ex As Exception

            tbCycleTime.Text = 0
            'gvData.Rows(0).Cells("fldCycleTime").Value = 0

        End Try
    End Sub
    Private Sub spnPlanDT_ValueChanged(sender As Object, e As EventArgs) Handles spnPlanDT.ValueChanged
        Try

            Dim HottoVal As Integer = spnHotto.Value
            Dim PlanedDTVal As Integer = spnPlanDT.Value
            Dim UnplanedDTVal As Integer = spnUnplanDT.Value
            Dim OPTimeVal As Integer = Convert.ToInt32(tbOpTime.Text)

            Dim sum As Decimal = 0

            For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

                Dim fldGoodQty As Integer = gvData.Rows(rowcounter).Cells("fldGoodQty").Value

                sum = sum + fldGoodQty

            Next

            Dim CycleTime As Decimal = ((OPTimeVal - (HottoVal + PlanedDTVal + UnplanedDTVal)) * 60) / sum

            tbCycleTime.Text = Math.Round(CycleTime, 2)

            'gvData.Rows(0).Cells("fldCycleTime").Value = Math.Round(CycleTime, 2)

        Catch ex As Exception

            tbCycleTime.Text = 0
            'gvData.Rows(0).Cells("fldCycleTime").Value = 0

        End Try
    End Sub

    Private Sub spnUnplanDT_ValueChanged(sender As Object, e As EventArgs) Handles spnUnplanDT.ValueChanged
        Try

            Dim HottoVal As Integer = spnHotto.Value
            Dim PlanedDTVal As Integer = spnPlanDT.Value
            Dim UnplanedDTVal As Integer = spnUnplanDT.Value
            Dim OPTimeVal As Integer = Convert.ToInt32(tbOpTime.Text)

            Dim sum As Decimal = 0

            For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

                Dim fldGoodQty As Integer = gvData.Rows(rowcounter).Cells("fldGoodQty").Value

                sum = sum + fldGoodQty

            Next

            Dim CycleTime As Decimal = ((OPTimeVal - (HottoVal + PlanedDTVal + UnplanedDTVal)) * 60) / sum

            tbCycleTime.Text = Math.Round(CycleTime, 2)

            'gvData.Rows(0).Cells("fldCycleTime").Value = Math.Round(CycleTime, 2)

        Catch ex As Exception

            tbCycleTime.Text = 0
            'gvData.Rows(0).Cells("fldCycleTime").Value = 0

        End Try
    End Sub
End Class
