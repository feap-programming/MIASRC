Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ucDailyRawMats
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub ucDailyRawMats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ReloadGrid()
        'ReloadPartName()
        'ReloadTimeDD()
        ReloadData()
    End Sub

    Private Sub ReloadPartName()

        'Dim GetModels As DataTable = Maria.MyQuery("SELECT fldModelName FROM tblModelList where fldCode='" & globalVariables.ModelCode & "'")

        'Dim GetPartNames As DataTable = Maria.MyQuery("SELECT fldPartName FROM tblDailyReportSRCRawMatsTemplate where fldModel='" & GetModels.Rows(0).Item("fldModelName").ToString & "'")

        'ddItemCode.DataSource = GetPartNames
        'ddItemCode.DisplayMember = "fldPartName"
        'ddItemCode.ValueMember = "fldPartName"
        'ddItemCode.AutoCompleteDataSource = GetPartNames
        'ddItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'ddItemCode.AutoCompleteDisplayMember = "fldPartName"
        'ddItemCode.AutoCompleteValueMember = "fldPartName"
        'ddItemCode.Text = ""

    End Sub

    Private Sub cbbTemplate_Click(sender As Object, e As EventArgs) Handles cbbTemplate.Click
        FrmRawMatsWPTemplate.Show()
    End Sub

    Private Sub cbbReload_Click(sender As Object, e As EventArgs) Handles cbbReload.Click

        ReloadData()

    End Sub

    Private Sub ReloadData()

        'gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportSRCRMWIP where fldDRID=" & globalVariables.DailyRepID & " and fldPartName='" & ddItemCode.Text & "' order by fldTime,fldBoxNo")
        gvData.DataSource = Nothing
        gvData.MasterTemplate.Rows.Clear()
        gvData.MasterTemplate.Columns.Clear()
        Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCRMWIP where fldDRID=" & globalVariables.DailyRepID & "")

        If CheckExist.Rows.Count >= 1 Then
            Dim DTCol As New DataTable

            DTCol.Columns.Add("TIME")
            DTCol.Columns.Add("Box/Cart No.")


            Dim GroupPartName = (From t1 In CheckExist.AsEnumerable
                                 Group By Keys = New With {
                              Key .fldPartName = t1("fldPartName")
                            } Into t1g = Group
                                 Select New With {
                                    .fldPartName = Keys.fldPartName
                                }).ToList
            Dim cavcolname = "Cav. No."
            For Each row As DataRow In convertToDatatable(GroupPartName).Rows

                DTCol.Columns.Add(row.Item("fldPartName").ToString)
                DTCol.Columns.Add(cavcolname)
                cavcolname = cavcolname & " "

            Next

            Dim GroupPartNameTimeBox = (From t1 In CheckExist.AsEnumerable
                                        Group By Keys = New With {
                              Key .fldTime = t1("fldTime")
                            } Into t1g = Group
                                        Select New With {
                                    .fldTime = Keys.fldTime,
                                    .fldBoxNo = t1g.First.Field(Of String)("fldBoxNo")
                                }).ToList

            For Each row As DataRow In convertToDatatable(GroupPartNameTimeBox).AsEnumerable


                Dim GetLotNo = (From t1 In CheckExist.AsEnumerable
                                Where t1("fldTime").ToString.Equals(row.Item("fldTime").ToString)
                                Select New With {
                                    .fldLotNo = t1("fldLotNo"),
                                    .fldCavNo = t1("fldCavNo")
                                }).ToList
                Dim ArrayOwO((convertToDatatable(GetLotNo).Rows.Count * 2) + 1) As String
                ArrayOwO(0) = row.Item("fldTime").ToString
                ArrayOwO(1) = row.Item("fldBoxNo").ToString
                Dim i As Integer = 2
                For Each LotNoRow As DataRow In convertToDatatable(GetLotNo).Rows

                    ArrayOwO(i) = LotNoRow.Item("fldLotNo").ToString
                    ArrayOwO(i + 1) = LotNoRow.Item("fldCavNo").ToString
                    i = i + 2

                Next

                DTCol.Rows.Add(ArrayOwO)

            Next
            gvData.DataSource = DTCol

            Dim colcount As Integer = 0

            While colcount <= gvData.Columns.Count - 1
                If colcount = 0 Then

                    gvData.Columns(colcount).Width = 200
                    gvData.Columns(colcount).TextAlignment = ContentAlignment.MiddleCenter
                    gvData.Columns(colcount).IsPinned = True
                    gvData.Columns(colcount).PinPosition = PinnedColumnPosition.Left
                    colcount = colcount + 1

                ElseIf colcount = 1 Then

                    gvData.Columns(colcount).Width = 150
                    gvData.Columns(colcount).TextAlignment = ContentAlignment.MiddleCenter
                    gvData.Columns(colcount).IsPinned = True
                    gvData.Columns(colcount).PinPosition = PinnedColumnPosition.Left
                    colcount = colcount + 1

                Else

                    gvData.Columns(colcount).Width = 350
                    gvData.Columns(colcount).TextAlignment = ContentAlignment.MiddleCenter
                    gvData.Columns(colcount + 1).Width = 100
                    gvData.Columns(colcount + 1).TextAlignment = ContentAlignment.MiddleCenter
                    colcount = colcount + 2

                End If

            End While
            Dim CheckTime As DataTable = Maria.MyQuery("SELECT distinct fldTime FROM tblDailyReportSRCRMWIP where fldDRID=" & globalVariables.DailyRepID & "")
            '------Extra time
            If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Or globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Or globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then
                If CheckTime.Rows.Count >= 8 Then

                Else
                    GetShiftTime()
                End If
            ElseIf globalVariables.DailyRepShift = "6AM-6PM" Or globalVariables.DailyRepShift = "6PM-6AM" Then
                If CheckTime.Rows.Count >= 12 Then

                Else
                    GetShiftTime()
                End If
            End If
            'Extra time end
        Else

            ReloadGrid()

        End If

    End Sub
    Public Shared Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function
    Private Sub ReloadTimeDD()
        ddTime.Items.Clear()
        If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                ddTime.Items.Add(InitialTime.ToString)


            End While
        ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                ddTime.Items.Add(InitialTime.ToString)

            End While
        ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
            Dim InitialTime As Integer = 14
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                ddTime.Items.Add(InitialTime.ToString)
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
                    ddTime.Items.Add(After24Hrs.ToString)
                Else
                    ddTime.Items.Add(InitialTime.ToString)
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
                    ddTime.Items.Add(After24Hrs.ToString)
                Else
                    ddTime.Items.Add(InitialTime.ToString)
                End If
            End While
        End If

    End Sub
    Private Sub ReloadGrid()

        gvData.Columns.Clear()
        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time"
        fldTime.FieldName = "Time"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.Width = 200
        fldTime.IsPinned = True
        fldTime.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldTime)

        Dim fldBoxNo As New GridViewTextBoxColumn
        fldBoxNo.HeaderText = "Box/Cart No."
        fldBoxNo.FieldName = "Box/Cart No."
        fldBoxNo.TextAlignment = ContentAlignment.MiddleCenter
        fldBoxNo.Width = 150
        fldBoxNo.IsPinned = True
        fldBoxNo.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldBoxNo)

        Dim DTAssy As DataTable = Maria.MyQuery("SELECT fldPartName FROM tblDailyReportSRCRawMatsTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLine & "")

        For Each row As DataRow In DTAssy.Rows
            Dim fldAssyNo As New GridViewTextBoxColumn
            fldAssyNo.HeaderText = row.Item("fldPartName").ToString
            fldAssyNo.FieldName = row.Item("fldPartName").ToString
            fldAssyNo.TextAlignment = ContentAlignment.MiddleCenter
            fldAssyNo.Width = 350
            gvData.Columns.Add(fldAssyNo)

            Dim fldCavNo As New GridViewTextBoxColumn
            fldCavNo.HeaderText = "Cav. No."
            fldCavNo.FieldName = "Cav. No."
            fldCavNo.TextAlignment = ContentAlignment.MiddleCenter
            fldCavNo.Width = 100
            gvData.Columns.Add(fldCavNo)
        Next
        GetShiftTime()
    End Sub

    Private Sub GetShiftTime()
        If gvData.Rows.Count >= 1 Then
            'gvData.Rows.Clear()
            If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
                Dim InitialTime As Integer = 6 + gvData.Rows.Count
                Dim InitialHour As Integer = gvData.Rows.Count
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                End While
            ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
                Dim InitialTime As Integer = 6 + gvData.Rows.Count
                Dim InitialHour As Integer = gvData.Rows.Count
                While InitialHour < 12

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                End While
            ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
                Dim InitialTime As Integer = 14 + gvData.Rows.Count
                Dim InitialHour As Integer = gvData.Rows.Count
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
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
                        gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                    Else
                        gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    End If

                End While
            ElseIf globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then
                Dim InitialTime As Integer = 22 + gvData.Rows.Count
                Dim InitialHour As Integer = gvData.Rows.Count
                Dim After24Hrs As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1
                    If InitialTime > 24 Then
                        After24Hrs = After24Hrs + 1L
                        gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                    Else
                        gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    End If
                End While
            End If
            gvData.Rows.Add("Component Scrap QTY")
            gvData.Rows.Add("QA (QC) Sample")
            gvData.Rows.Add("Eng'g Sample")
        Else
            gvData.Rows.Clear()
            If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
                Dim InitialTime As Integer = 6
                Dim InitialHour As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                End While
            ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
                Dim InitialTime As Integer = 6
                Dim InitialHour As Integer = 0
                While InitialHour < 12

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                End While
            ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
                Dim InitialTime As Integer = 14
                Dim InitialHour As Integer = 0
                While InitialHour < 8

                    InitialHour = InitialHour + 1
                    InitialTime = InitialTime + 1

                    gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
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
                        gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                    Else
                        gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
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
                        gvData.Rows.Add(After24Hrs - 1 & ":00-" & After24Hrs & ":00")
                    Else
                        gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
                    End If
                End While
            End If

            gvData.Rows.Add("Component Scrap QTY")
            gvData.Rows.Add("QA (QC) Sample")
            gvData.Rows.Add("Eng'g Sample")
        End If


    End Sub

    Private Sub ddItemCode_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs)
        ReloadData()
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        cbbSave.Text = "SAVING.."
        cbbReload.Enabled = False
        cbbSave.Enabled = False
        cbbTemplate.Enabled = False
        BackgroundWorker1.RunWorkerAsync()

        'Try
        '    Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
        '    Maria.AddMySqlParameters("parPartName", ddItemCode.Text)
        '    Maria.AddMySqlParameters("parTime", ddTime.Text)
        '    Maria.AddMySqlParameters("parBoxNo", tbBoxNo.Text)
        '    Maria.AddMySqlParameters("parLotNo", tbLotNo.Text)
        '    Maria.AddMySqlParameters("parCavNo", tbCavNo.Text)
        '    Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
        '    Maria.SPADE("SP_SRCDailyReport_InsertRMWIP")

        '    ReloadData()
        'Catch ex As Exception
        '    RadMessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim parID As Integer = gvData.CurrentRow.Cells("fldID").Value
            Maria.MyQuery("Delete from tblDailyReportSRCRMWIP where fldID=" & parID & "")
            ReloadData()
        End If
    End Sub

    Private Sub gvData_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellEndEdit
        Try
            Dim parID As Integer = gvData.CurrentRow.Cells("fldID").Value
            Dim parBoxNo As String = gvData.CurrentRow.Cells("fldBoxNo").Value.ToString
            Dim parLotNo As String = gvData.CurrentRow.Cells("fldLotNo").Value.ToString
            Dim parCavNo As Integer = Nothing

            If gvData.CurrentRow.Cells("fldCavNo").Value.ToString = Nothing Then

            Else

                parCavNo = gvData.CurrentRow.Cells("fldCavNo").Value

            End If

            Maria.MyQuery("Update tblDailyReportSRCRMWIP set fldBoxNo='" & parBoxNo & "',fldLotNo='" & parLotNo & "',fldCavNo=" & parCavNo & " where fldID=" & parID & "")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Maria.MyQuery("DELETE FROM tblDailyReportSRCRMWIP where fldDRID=" & globalVariables.DailyRepID & "")
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
            Maria.Connection.Close()
            cbbReload.Enabled = True
            cbbSave.Enabled = True
            cbbTemplate.Enabled = True
            Exit Sub
        End Try

        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

            Dim parTime As String = gvData.Rows(rowcounter).Cells("Time").Value.ToString
            Dim parBoxNo As String = If(gvData.Rows(rowcounter).Cells("Box/Cart No.").Value = Nothing, "", gvData.Rows(rowcounter).Cells("Box/Cart No.").Value.ToString)

            For colcounter As Integer = 2 To Me.gvData.Columns.Count - 1 Step 2

                Try
                    Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                    Maria.AddMySqlParameters("parTime", parTime)
                    Maria.AddMySqlParameters("parBoxNo", parBoxNo)
                    Maria.AddMySqlParameters("parPartName", gvData.Columns(colcounter).FieldName)
                    Maria.AddMySqlParameters("parLotNo", If(gvData.Rows(rowcounter).Cells(colcounter).Value = Nothing, "", gvData.Rows(rowcounter).Cells(colcounter).Value.ToString))
                    Maria.AddMySqlParameters("parCavNo", If(gvData.Rows(rowcounter).Cells(colcounter + 1).Value = Nothing, 0, gvData.Rows(rowcounter).Cells(colcounter + 1).Value))
                    Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                    Maria.SPADE("SP_SRCDailyReport_InsertRMWIP")
                Catch ex As Exception
                    RadMessageBox.Show(ex.Message)
                    Maria.Connection.Close()
                    cbbReload.Enabled = True
                    cbbSave.Enabled = True
                    cbbTemplate.Enabled = True
                    Exit Sub
                End Try

            Next

        Next
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Done!")
        cbbSave.Text = "SAVE"
        cbbReload.Enabled = True
        cbbSave.Enabled = True
        cbbTemplate.Enabled = True
    End Sub
End Class
