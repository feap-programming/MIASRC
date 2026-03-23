Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class ucWeldingHourly
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub ucWeldingHourly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblType.Text = globalVariables.SRCReportType & "-"
        RemoveHandler ddType.SelectedIndexChanged, AddressOf ddType_SelectedIndexChanged
        ReloadWelding()
        GridCol()

        AddHandler ddType.SelectedIndexChanged, AddressOf ddType_SelectedIndexChanged
    End Sub

    Private Sub GridCol()
        Dim fldHour As New GridViewTextBoxColumn
        fldHour.HeaderText = "Time"
        fldHour.FieldName = "fldHour"
        fldHour.TextAlignment = ContentAlignment.MiddleCenter
        fldHour.MinWidth = 90
        fldHour.ReadOnly = True
        fldHour.IsPinned = True
        fldHour.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldHour)

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

        Dim fldCheckedBy As New GridViewTextBoxColumn
        fldCheckedBy.HeaderText = "Checked By"
        fldCheckedBy.FieldName = "fldCheckedBy"
        fldCheckedBy.TextAlignment = ContentAlignment.MiddleCenter
        fldCheckedBy.MinWidth = 120
        gvData.Columns.Add(fldCheckedBy)

        Dim fldNGFinal As New GridViewTextBoxColumn
        fldNGFinal.HeaderText = "Remarks"
        fldNGFinal.FieldName = "fldRemarks"
        fldNGFinal.TextAlignment = ContentAlignment.MiddleCenter
        fldNGFinal.MinWidth = 120
        gvData.Columns.Add(fldNGFinal)

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
    Private Sub GetShiftTime()
        gvData.DataSource = Nothing
        gvData.MasterTemplate.Rows.Clear()
        Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingHourlyProd where fldDRID=" & globalVariables.DailyRepID & " and fldType='" & globalVariables.SRCReportType & "' and fldFWPWNo='" & ddType.Text & "'")

        Dim PlanPerShift As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingPlan where fldShift='" & globalVariables.DailyRepShift & "'")

        If CheckExist.Rows.Count >= 1 Then
            gvData.DataSource = CheckExist
        Else
            If globalVariables.DailyRepShift = "1st Shift" Then
                Dim InitialTime As Integer = 6
                Dim InitialHour As Integer = 0
                Dim PlanRow As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    gvData.CurrentRow.Cells("fldDeviation").Value = 0

                    gvData.CurrentRow.Cells("fldPlan").Value = PlanPerShift.Rows(PlanRow).Item("fldPlan")
                    PlanRow = PlanRow + 1
                    gvData.CurrentRow.Cells("fldActual").Value = 0



                End While
            ElseIf globalVariables.DailyRepShift = "Day Shift" Then
                Dim InitialTime As Integer = 6
                Dim InitialHour As Integer = 0
                Dim PlanRow As Integer = 0
                While InitialHour < 12

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    gvData.CurrentRow.Cells("fldPlan").Value = PlanPerShift.Rows(PlanRow).Item("fldPlan")
                    PlanRow = PlanRow + 1
                    gvData.CurrentRow.Cells("fldActual").Value = 0
                End While
            ElseIf globalVariables.DailyRepShift = "2nd Shift" Then
                Dim InitialTime As Integer = 14
                Dim InitialHour As Integer = 0
                Dim PlanRow As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    gvData.CurrentRow.Cells("fldDeviation").Value = 0
                    gvData.CurrentRow.Cells("fldPlan").Value = PlanPerShift.Rows(PlanRow).Item("fldPlan")
                    PlanRow = PlanRow + 1
                    gvData.CurrentRow.Cells("fldActual").Value = 0
                End While
            ElseIf globalVariables.DailyRepShift = "Night Shift" Then
                Dim InitialTime As Integer = 18
                Dim InitialHour As Integer = 0
                Dim After24Hrs As Integer = 0
                Dim PlanRow As Integer = 0
                While InitialHour < 12

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1
                    If InitialTime > 24 Then
                        After24Hrs = After24Hrs + 1
                        gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                        gvData.CurrentRow.Cells("fldDeviation").Value = 0
                        gvData.CurrentRow.Cells("fldPlan").Value = PlanPerShift.Rows(PlanRow).Item("fldPlan")
                        PlanRow = PlanRow + 1
                        gvData.CurrentRow.Cells("fldActual").Value = 0
                    Else
                        gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                        gvData.CurrentRow.Cells("fldDeviation").Value = 0
                        gvData.CurrentRow.Cells("fldPlan").Value = PlanPerShift.Rows(PlanRow).Item("fldPlan")
                        PlanRow = PlanRow + 1
                        gvData.CurrentRow.Cells("fldActual").Value = 0
                    End If

                End While
            ElseIf globalVariables.DailyRepShift = "3rd Shift" Then
                Dim InitialTime As Integer = 22
                Dim InitialHour As Integer = 0
                Dim After24Hrs As Integer = 0
                Dim PlanRow As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1
                    If InitialTime > 24 Then
                        After24Hrs = After24Hrs + 1
                        gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                        gvData.CurrentRow.Cells("fldDeviation").Value = 0
                        gvData.CurrentRow.Cells("fldPlan").Value = PlanPerShift.Rows(PlanRow).Item("fldPlan")
                        PlanRow = PlanRow + 1
                        gvData.CurrentRow.Cells("fldActual").Value = 0
                    Else
                        gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                        gvData.CurrentRow.Cells("fldDeviation").Value = 0
                        gvData.CurrentRow.Cells("fldPlan").Value = PlanPerShift.Rows(PlanRow).Item("fldPlan")
                        PlanRow = PlanRow + 1
                        gvData.CurrentRow.Cells("fldActual").Value = 0
                    End If
                End While
            End If
        End If

    End Sub

    Private Sub ddType_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddType.SelectedIndexChanged
        GetShiftTime()
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click

        Maria.MyQuery("Delete From tblDailyReportWeldingHourlyProd where fldDRID=" & globalVariables.DailyRepID & " and fldType='" & globalVariables.SRCReportType & "' and fldFWPWNo='" & ddType.Text & "'")

        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

            Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
            Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
            Maria.AddMySqlParameters("parFWPWNo", ddType.Text)
            Maria.AddMySqlParameters("parHour", gvData.Rows(rowcounter).Cells("fldHour").Value)
            Maria.AddMySqlParameters("parPlan", gvData.Rows(rowcounter).Cells("fldPlan").Value)
            Maria.AddMySqlParameters("parActual", gvData.Rows(rowcounter).Cells("fldActual").Value)
            Maria.AddMySqlParameters("parDeviation", gvData.Rows(rowcounter).Cells("fldDeviation").Value)
            Maria.AddMySqlParameters("parCheckedBy", gvData.Rows(rowcounter).Cells("fldCheckedBy").Value)
            Maria.AddMySqlParameters("parRemarks", gvData.Rows(rowcounter).Cells("fldRemarks").Value)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRCDailyReport_InsertWeldingHourlyProd")

        Next

        MessageBox.Show("Done!")

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

    Private Sub cbbPlan_Click(sender As Object, e As EventArgs) Handles cbbPlan.Click
        FrmWeldingPlan.ShowDialog()
    End Sub
End Class
