Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ucDailyHourlyQuality
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim rowIndex As Integer
    Private Sub ucDailyHourlyQuality_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridCol()
        RemoveHandler gvData.SelectionChanged, AddressOf gvData_SelectionChanged
        GetShiftTime()
        AddHandler gvData.SelectionChanged, AddressOf gvData_SelectionChanged
    End Sub
    Private Sub GridCol()

        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time"
        fldTime.FieldName = "fldTime"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.MinWidth = 90
        fldTime.ReadOnly = True
        fldTime.IsPinned = True
        fldTime.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldTime)

        Dim fldCableGrease As New GridViewCheckBoxColumn()
        fldCableGrease.DataType = GetType(Integer)
        fldCableGrease.FieldName = "fldCableG"
        fldCableGrease.HeaderText = "Cable Greasing"
        fldCableGrease.MinWidth = 120
        gvData.MasterTemplate.Columns.Add(fldCableGrease)

        Dim fldStatorGrease As New GridViewCheckBoxColumn()
        fldStatorGrease.DataType = GetType(Integer)
        fldStatorGrease.FieldName = "fldStatorG"
        fldStatorGrease.HeaderText = "Stator Greasing"
        fldStatorGrease.MinWidth = 120
        gvData.MasterTemplate.Columns.Add(fldStatorGrease)

        Dim fldFinalProdCheck As New GridViewCheckBoxColumn()
        fldFinalProdCheck.DataType = GetType(Integer)
        fldFinalProdCheck.FieldName = "fldFinalProdCheck"
        fldFinalProdCheck.HeaderText = "Final Product Check"
        fldFinalProdCheck.MinWidth = 120
        gvData.MasterTemplate.Columns.Add(fldFinalProdCheck)

        Dim fldRotator As New GridViewTextBoxColumn
        fldRotator.HeaderText = "Rotator (Cavity#)"
        fldRotator.FieldName = "fldRotator"
        fldRotator.TextAlignment = ContentAlignment.MiddleCenter
        fldRotator.MinWidth = 120
        gvData.Columns.Add(fldRotator)

        Dim fldStator As New GridViewTextBoxColumn
        fldStator.HeaderText = "Stator (Cavity#)"
        fldStator.FieldName = "fldStator"
        fldStator.TextAlignment = ContentAlignment.MiddleCenter
        fldStator.MinWidth = 120
        gvData.Columns.Add(fldStator)

        Dim fldSubStator As New GridViewTextBoxColumn
        fldSubStator.HeaderText = "Sub Stator (Cavity#)"
        fldSubStator.FieldName = "fldSubStator"
        fldSubStator.TextAlignment = ContentAlignment.MiddleCenter
        fldSubStator.MinWidth = 120
        gvData.Columns.Add(fldSubStator)

        Dim fldSleeve As New GridViewTextBoxColumn
        fldSleeve.HeaderText = "Sleeve (Cavity#)"
        fldSleeve.FieldName = "fldSleeve"
        fldSleeve.TextAlignment = ContentAlignment.MiddleCenter
        fldSleeve.MinWidth = 120
        gvData.Columns.Add(fldSleeve)

        Dim fldBarcode As New GridViewTextBoxColumn
        fldBarcode.HeaderText = "Barcode No."
        fldBarcode.FieldName = "fldBarcode"
        fldBarcode.TextAlignment = ContentAlignment.MiddleCenter
        fldBarcode.MinWidth = 120
        gvData.Columns.Add(fldBarcode)

        Dim fldPlan As New GridViewTextBoxColumn
        fldPlan.HeaderText = "Plan"
        fldPlan.FieldName = "fldPlan"
        fldPlan.TextAlignment = ContentAlignment.MiddleCenter
        fldPlan.MinWidth = 120
        gvData.Columns.Add(fldPlan)

        Dim fldActual As New GridViewTextBoxColumn
        fldActual.HeaderText = "Actual"
        fldActual.FieldName = "fldActual"
        fldActual.TextAlignment = ContentAlignment.MiddleCenter
        fldActual.MinWidth = 120
        gvData.Columns.Add(fldActual)

        Dim fldDeviation As New GridViewTextBoxColumn
        fldDeviation.HeaderText = "Deviation(+/-)"
        fldDeviation.FieldName = "fldDeviation"
        fldDeviation.TextAlignment = ContentAlignment.MiddleCenter
        fldDeviation.MinWidth = 120
        fldDeviation.ReadOnly = True
        gvData.Columns.Add(fldDeviation)

        Dim fldNGElectrical As New GridViewTextBoxColumn
        fldNGElectrical.HeaderText = "Electrical(NG Prod. Counter Pcs.)"
        fldNGElectrical.FieldName = "fldElectrical"
        fldNGElectrical.TextAlignment = ContentAlignment.MiddleCenter
        fldNGElectrical.MinWidth = 120
        gvData.Columns.Add(fldNGElectrical)

        Dim fldNGFunction As New GridViewTextBoxColumn
        fldNGFunction.HeaderText = "Function(NG Prod. Counter Pcs.)"
        fldNGFunction.FieldName = "fldFunction"
        fldNGFunction.TextAlignment = ContentAlignment.MiddleCenter
        fldNGFunction.MinWidth = 120
        gvData.Columns.Add(fldNGFunction)

        Dim fldNGFinal As New GridViewTextBoxColumn
        fldNGFinal.HeaderText = "Final(NG Prod. Counter Pcs.)"
        fldNGFinal.FieldName = "fldFinal"
        fldNGFinal.TextAlignment = ContentAlignment.MiddleCenter
        fldNGFinal.MinWidth = 120
        gvData.Columns.Add(fldNGFinal)

        gvData.MasterTemplate.BestFitColumns()

    End Sub

    Private Sub GetShiftTime()
        gvData.DataSource = Nothing
        Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCHourlyQuality where fldDRID=" & globalVariables.DailyRepID & "")

        If CheckExist.Rows.Count >= 1 Then
            gvData.DataSource = CheckExist
            If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Or globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Or globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then

                If gvData.Rows.Count >= 8 Then

                Else
                    GetShiftTimeExist()
                End If

            ElseIf globalVariables.DailyRepShift = "6AM-6PM" Or globalVariables.DailyRepShift = "6PM-6AM" Then

                If gvData.Rows.Count >= 12 Then

                Else
                    GetShiftTimeExist()
                End If

            End If
        Else
            If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
                Dim InitialTime As Integer = 6
                Dim InitialHour As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    'gvData.Rows.Add(InitialTime)

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    DefaulVal()
                End While
            ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
                Dim InitialTime As Integer = 6
                Dim InitialHour As Integer = 0
                While InitialHour < 12

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    'gvData.Rows.Add(InitialTime)
                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    DefaulVal()
                End While
            ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
                Dim InitialTime As Integer = 14
                Dim InitialHour As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    'gvData.Rows.Add(InitialTime)
                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    DefaulVal()
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
                        'gvData.Rows.Add(After24Hrs)
                        gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                        'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    Else
                        'gvData.Rows.Add(InitialTime)
                        gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                        'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    End If
                    DefaulVal()
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
                        'gvData.Rows.Add(After24Hrs)
                        gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                        'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    Else
                        'gvData.Rows.Add(InitialTime)
                        gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                        'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    End If
                    DefaulVal()
                End While
            End If
        End If

    End Sub

    Private Sub GetShiftTimeExist()

        If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
            Dim InitialTime As Integer = 6 + gvData.Rows.Count
            Dim InitialHour As Integer = gvData.Rows.Count
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                'gvData.Rows.Add(InitialTime)

                gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                DefaulVal()
            End While
        ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
            Dim InitialTime As Integer = 6 + gvData.Rows.Count
            Dim InitialHour As Integer = gvData.Rows.Count
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                'gvData.Rows.Add(InitialTime)
                gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                DefaulVal()
            End While
        ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
            Dim InitialTime As Integer = 14 + gvData.Rows.Count
            Dim InitialHour As Integer = gvData.Rows.Count
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                'gvData.Rows.Add(InitialTime)
                gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                DefaulVal()
            End While
        ElseIf globalVariables.DailyRepShift = "6PM-6AM" Then
            Dim InitialTime As Integer = 18 + gvData.Rows.Count
            Dim InitialHour As Integer = gvData.Rows.Count
            Dim After24Hrs As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    'gvData.Rows.Add(After24Hrs)
                    gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                    'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                Else
                    'gvData.Rows.Add(InitialTime)
                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                End If
                DefaulVal()
            End While
        ElseIf globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then
            Dim InitialTime As Integer = 22 + gvData.Rows.Count
            Dim InitialHour As Integer = gvData.Rows.Count
            Dim After24Hrs As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    'gvData.Rows.Add(After24Hrs)
                    gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                    'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                Else
                    'gvData.Rows.Add(InitialTime)
                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    'gvData.CurrentRow.Cells("fldDeviation").Value = 0
                End If
                DefaulVal()
            End While
        End If

    End Sub

    Private Sub gvData_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellEndEdit

        Dim PlanVal As Integer
        Dim ActualVal As Integer
        Dim Deviationval As Integer
        If gvData.CurrentRow.Cells("fldPlan").Value = Nothing And gvData.CurrentRow.Cells("fldActual").Value = Nothing Then

            Deviationval = 0

        Else

            If gvData.CurrentRow.Cells("fldPlan").Value IsNot Nothing And gvData.CurrentRow.Cells("fldActual").Value = Nothing Then

                PlanVal = gvData.CurrentRow.Cells("fldPlan").Value
                Deviationval = 0 - PlanVal

            ElseIf gvData.CurrentRow.Cells("fldPlan").Value = Nothing And gvData.CurrentRow.Cells("fldActual").Value IsNot Nothing Then

                ActualVal = gvData.CurrentRow.Cells("fldActual").Value
                Deviationval = ActualVal - 0

            Else

                PlanVal = gvData.CurrentRow.Cells("fldPlan").Value
                ActualVal = gvData.CurrentRow.Cells("fldActual").Value
                Deviationval = ActualVal - PlanVal
            End If

        End If

        gvData.CurrentRow.Cells("fldDeviation").Value = Deviationval

    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting
        Try
            If e.CellElement.ColumnInfo.FieldName = "fldCableG" Then

                If e.CellElement.RowInfo.Cells("fldCableG").Value = False Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldStatorG" Then

                If e.CellElement.RowInfo.Cells("fldStatorG").Value = False Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldFinalProdCheck" Then

                If e.CellElement.RowInfo.Cells("fldFinalProdCheck").Value = False Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldRotator" Then

                If e.CellElement.RowInfo.Cells("fldRotator").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldRotator").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldStator" Then

                If e.CellElement.RowInfo.Cells("fldStator").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldStator").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldSubStator" Then

                If e.CellElement.RowInfo.Cells("fldSubStator").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldSubStator").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldSleeve" Then

                If e.CellElement.RowInfo.Cells("fldSleeve").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldSleeve").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldBarcode" Then

                If e.CellElement.RowInfo.Cells("fldBarcode").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldBarcode").Value.ToString.Trim = "" Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldPlan" Then

                If e.CellElement.RowInfo.Cells("fldPlan").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldPlan").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldActual" Then

                If e.CellElement.RowInfo.Cells("fldActual").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldActual").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldElectrical" Then

                If e.CellElement.RowInfo.Cells("fldElectrical").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldElectrical").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldFunction" Then

                If e.CellElement.RowInfo.Cells("fldFunction").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldFunction").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldFinal" Then

                If e.CellElement.RowInfo.Cells("fldFinal").Value Is Nothing Or e.CellElement.RowInfo.Cells("fldFinal").Value = 0 Then
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

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldDeviation" Then

                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.Black
                e.CellElement.BackColor = Color.Silver
                e.CellElement.BackColor2 = Color.Silver

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldTime" Then

                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.Black
                e.CellElement.BackColor = Color.Silver
                e.CellElement.BackColor2 = Color.Silver

            Else

                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        ClickSave()

    End Sub

    Private Sub ClickSave()

        If BackgroundWorker1.IsBusy Then
            MessageBox.Show("Busy")
        Else
            Maria.MyQuery("Delete from tblDailyReportSRCHourlyQuality where fldDRID=" & globalVariables.DailyRepID & "")
            cbbSave.Enabled = False
            cbbClear.Enabled = False
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Maria.MyQuery("Delete from tblDailyReportSRCHourlyQuality where fldDRID=" & globalVariables.DailyRepID & "")
        Catch ex As Exception

            RadMessageBox.Show(ex.Message)
            Maria.Connection.Close()
            cbbSave.Enabled = True
            cbbClear.Enabled = True
            Exit Sub
        End Try
        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1
            Try
                Dim parDRID As Integer = globalVariables.DailyRepID
                Dim parTime As String = gvData.Rows(rowcounter).Cells("fldTime").Value
                Dim parCableG As Boolean = gvData.Rows(rowcounter).Cells("fldCableG").Value
                Dim parStatorG As Boolean = gvData.Rows(rowcounter).Cells("fldStatorG").Value
                Dim parFinalProdCheck As Boolean = gvData.Rows(rowcounter).Cells("fldFinalProdCheck").Value
                Dim parRotator As Integer = gvData.Rows(rowcounter).Cells("fldRotator").Value
                Dim parStator As Integer = gvData.Rows(rowcounter).Cells("fldStator").Value
                Dim parSubStator As Integer = gvData.Rows(rowcounter).Cells("fldSubStator").Value
                Dim parSleeve As Integer = gvData.Rows(rowcounter).Cells("fldSleeve").Value
                Dim parBarcode As String = gvData.Rows(rowcounter).Cells("fldBarcode").Value
                Dim parPlan As Integer = gvData.Rows(rowcounter).Cells("fldPlan").Value
                Dim parActual As Integer = gvData.Rows(rowcounter).Cells("fldActual").Value
                Dim parDeviation As Integer = gvData.Rows(rowcounter).Cells("fldDeviation").Value
                Dim parElectrical As Integer = gvData.Rows(rowcounter).Cells("fldElectrical").Value
                Dim parFunction As Integer = gvData.Rows(rowcounter).Cells("fldFunction").Value
                Dim parFinal As Integer = gvData.Rows(rowcounter).Cells("fldFinal").Value
                Dim parUser As String = globalVariables.currentUser(1)

                Maria.AddMySqlParameters("parDRID", parDRID)
                Maria.AddMySqlParameters("parTime", parTime)
                Maria.AddMySqlParameters("parCableG", parCableG)
                Maria.AddMySqlParameters("parStatorG", parStatorG)
                Maria.AddMySqlParameters("parFinalProdCheck", parFinalProdCheck)
                Maria.AddMySqlParameters("parRotator", parRotator)
                Maria.AddMySqlParameters("parStator", parStator)
                Maria.AddMySqlParameters("parSubStator", parSubStator)
                Maria.AddMySqlParameters("parSleeve", parSleeve)
                Maria.AddMySqlParameters("parBarcode", parBarcode)
                Maria.AddMySqlParameters("parPlan", parPlan)
                Maria.AddMySqlParameters("parActual", parActual)
                Maria.AddMySqlParameters("parDeviation", parDeviation)
                Maria.AddMySqlParameters("parElectrical", parElectrical)
                Maria.AddMySqlParameters("parFunction", parFunction)
                Maria.AddMySqlParameters("parFinal", parFinal)
                Maria.AddMySqlParameters("parUser", parUser)
                Maria.SPADE("SP_SRC_InsertHourlyQuality")

                Threading.Thread.Sleep(60)
                Dim RowCount As Integer = gvData.Rows.Count
                rowIndex = rowcounter
                Dim percent As Double = (rowcounter / RowCount * 100)
                BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
                Maria.Connection.Close()
                cbbSave.Enabled = True
                cbbClear.Enabled = True
                Exit Sub
            End Try
        Next


    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        progressbar.Value1 = e.ProgressPercentage
        progressbar.Text = e.ProgressPercentage.ToString
        gvData.CurrentRow = gvData.Rows(rowIndex)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        progressbar.Value1 = 100
        progressbar.Text = "Done"
        RadMessageBox.Show("Done!")
        cbbSave.Enabled = True
        cbbClear.Enabled = True
    End Sub

    Private Sub DefaulVal()
        gvData.CurrentRow.Cells("fldRotator").Value = 0
        gvData.CurrentRow.Cells("fldStator").Value = 0
        gvData.CurrentRow.Cells("fldSubStator").Value = 0
        gvData.CurrentRow.Cells("fldSleeve").Value = 0
        gvData.CurrentRow.Cells("fldBarcode").Value = " "
        gvData.CurrentRow.Cells("fldPlan").Value = 0
        gvData.CurrentRow.Cells("fldActual").Value = 0
        gvData.CurrentRow.Cells("fldDeviation").Value = 0
        gvData.CurrentRow.Cells("fldElectrical").Value = 0
        gvData.CurrentRow.Cells("fldFunction").Value = 0
        gvData.CurrentRow.Cells("fldFinal").Value = 0
    End Sub

    Private Sub cbbClear_Click(sender As Object, e As EventArgs) Handles cbbClear.Click
        Dim result As Integer = RadMessageBox.Show("Reloading Template will remove all the the data you inputed. Continue?", "Yes or No?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            gvData.DataSource = Nothing
            If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
                Dim InitialTime As Integer = 6
                Dim InitialHour As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime)
                    gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    DefaulVal()
                End While
            ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
                Dim InitialTime As Integer = 6
                Dim InitialHour As Integer = 0
                While InitialHour < 12

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime)
                    gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    DefaulVal()
                End While
            ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
                Dim InitialTime As Integer = 14
                Dim InitialHour As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime)
                    gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    DefaulVal()
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
                        gvData.Rows.Add(After24Hrs)
                        gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    Else
                        gvData.Rows.Add(InitialTime)
                        gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    End If
                    DefaulVal()
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
                        gvData.Rows.Add(After24Hrs)
                        gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    Else
                        gvData.Rows.Add(InitialTime)
                        gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    End If
                    DefaulVal()
                End While
            End If

        End If
    End Sub



    Private Sub gvData_SelectionChanged(sender As Object, e As EventArgs) Handles gvData.SelectionChanged
        'ClickSave()
    End Sub
End Class
