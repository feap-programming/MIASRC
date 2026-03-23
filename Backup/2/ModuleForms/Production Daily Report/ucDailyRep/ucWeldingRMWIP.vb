Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class ucWeldingRMWIP
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub ucWeldingRMWIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler ddAssy.SelectedIndexChanged, AddressOf ddAssy_SelectedIndexChanged
        ReloadAssy()
        AddHandler ddAssy.SelectedIndexChanged, AddressOf ddAssy_SelectedIndexChanged
    End Sub
    Private Sub ReloadAssy()

        Dim DTModel As DataTable = Maria.MyQuery("SELECT distinct fldAssyNo FROM tblDailyReportWeldingTemplateLotNo where fldType='" & globalVariables.SRCReportType & "' and fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & "")

        ddAssy.DataSource = DTModel
        ddAssy.DisplayMember = "fldAssyNo"
        ddAssy.ValueMember = "fldAssyNo"
        ddAssy.AutoCompleteDataSource = DTModel
        ddAssy.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddAssy.AutoCompleteDisplayMember = "fldAssyNo"
        ddAssy.AutoCompleteValueMember = "fldAssyNo"
        ddAssy.Text = ""

    End Sub

    Private Sub CommandBarButton1_Click(sender As Object, e As EventArgs) Handles CommandBarButton1.Click
        FrmWeldingTemplateLotNo.ShowDialog()
    End Sub

    Private Sub ddAssy_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddAssy.SelectedIndexChanged
        gvData.DataSource = Nothing
        gvData.MasterTemplate.Rows.Clear()
        gvData.MasterTemplate.Columns.Clear()
        Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingLotNo where fldDRID=" & globalVariables.DailyRepID & " and fldAssyNo='" & ddAssy.Text & "'")

        If CheckExist.Rows.Count >= 1 Then

            Dim DTLotNo As New DataTable

            DTLotNo.Columns.Add("Time")
            DTLotNo.Columns.Add("Box No. (1)")
            DTLotNo.Columns.Add("Box No. (2)")

            Dim GroupPartName = (From t1 In CheckExist.AsEnumerable
                                 Group By Keys = New With {
                              Key .fldPartName = t1("fldPartName")
                            } Into t1g = Group
                                 Select New With {
                                    .fldPartName = Keys.fldPartName
                                }).ToList

            For Each row As DataRow In convertToDatatable(GroupPartName).Rows

                DTLotNo.Columns.Add(row.Item("fldPartName").ToString)

            Next

            Dim GroupPartNameTimeBox = (From t1 In CheckExist.AsEnumerable
                                        Group By Keys = New With {
                              Key .fldTime = t1("fldTime")
                            } Into t1g = Group
                                        Select New With {
                                    .fldTime = Keys.fldTime,
                                    .fldBoxNo = t1g.First.Field(Of String)("fldBoxNo"),
                                    .fldBoxNo2 = t1g.First.Field(Of String)("fldBoxNo2")
                                }).ToList

            For Each row As DataRow In convertToDatatable(GroupPartNameTimeBox).AsEnumerable



                Dim GetLotNo = (From t1 In CheckExist.AsEnumerable
                                Where t1("fldTime").ToString.Equals(row.Item("fldTime").ToString)
                                Select New With {
                                    .fldLotNo = t1("fldLotNo")
                                }).ToList
                Dim ArrayOwO(convertToDatatable(GetLotNo).Rows.Count + 1) As String
                ArrayOwO(0) = row.Item("fldTime").ToString
                ArrayOwO(1) = row.Item("fldBoxNo").ToString
                ArrayOwO(2) = row.Item("fldBoxNo2").ToString
                Dim i As Integer = 3
                For Each LotNoRow As DataRow In convertToDatatable(GetLotNo).Rows

                    ArrayOwO(i) = LotNoRow.Item("fldLotNo").ToString
                    i = i + 1

                Next

                DTLotNo.Rows.Add(ArrayOwO)

            Next
            gvData.DataSource = DTLotNo

            Dim colcount As Integer = 0

            While colcount <= gvData.Columns.Count - 1
                If colcount = 0 Then

                    gvData.Columns(colcount).Width = 200
                    gvData.Columns(colcount).IsPinned = True
                    gvData.Columns(colcount).PinPosition = PinnedColumnPosition.Left
                    gvData.Columns(colcount).ReadOnly = True

                ElseIf colcount = 1 Then
                    gvData.Columns(colcount).Width = 150
                Else
                    gvData.Columns(colcount).Width = 350
                End If
                gvData.Columns(colcount).TextAlignment = ContentAlignment.MiddleCenter
                colcount = colcount + 1
            End While

            'Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingLotNo where fldDRID=" & globalVariables.DailyRepID & " and fldAssyNo='" & ddAssy.Text & "'")


        Else

            ReloadGrid()

        End If


    End Sub
    Private Sub ReloadGrid()
        gvData.Columns.Clear()
        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time"
        fldTime.FieldName = "Time"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.Width = 200
        gvData.Columns.Add(fldTime)

        Dim fldBoxNo1 As New GridViewTextBoxColumn
        fldBoxNo1.HeaderText = "Box No. (1)"
        fldBoxNo1.FieldName = "Box No. (1)"
        fldBoxNo1.TextAlignment = ContentAlignment.MiddleCenter
        fldBoxNo1.Width = 150
        gvData.Columns.Add(fldBoxNo1)

        Dim fldBoxNo2 As New GridViewTextBoxColumn
        fldBoxNo2.HeaderText = "Box No. (2)"
        fldBoxNo2.FieldName = "Box No. (2)"
        fldBoxNo2.TextAlignment = ContentAlignment.MiddleCenter
        fldBoxNo2.Width = 150
        gvData.Columns.Add(fldBoxNo2)

        Dim DTAssy As DataTable = Maria.MyQuery("SELECT fldPartName FROM tblDailyReportWeldingTemplateLotNo where fldType='" & globalVariables.SRCReportType & "' and fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldAssyNo='" & ddAssy.Text & "'")
        Dim CavCav As String = "Cav #"
        For Each row As DataRow In DTAssy.Rows
            Dim fldAssyNo As New GridViewTextBoxColumn
            fldAssyNo.HeaderText = row.Item("fldPartName").ToString
            fldAssyNo.FieldName = row.Item("fldPartName").ToString
            fldAssyNo.TextAlignment = ContentAlignment.MiddleCenter
            fldAssyNo.Width = 350
            gvData.Columns.Add(fldAssyNo)

            Dim fldCav As New GridViewTextBoxColumn
            fldCav.HeaderText = CavCav
            fldCav.FieldName = CavCav
            fldCav.TextAlignment = ContentAlignment.MiddleCenter
            fldCav.Width = 50
            gvData.Columns.Add(fldCav)

            CavCav = CavCav + " "
        Next
        GetShiftTime()
    End Sub

    Private Function Gettimelist() As DataTable
        Dim OwO As New DataTable
        OwO.Columns.Add("Time")
        If globalVariables.DailyRepShift = "1st Shift" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                OwO.Rows.Add(InitialTime)
            End While
        ElseIf globalVariables.DailyRepShift = "Day Shift" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                OwO.Rows.Add(InitialTime)
            End While
        ElseIf globalVariables.DailyRepShift = "2nd Shift" Then
            Dim InitialTime As Integer = 14
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                OwO.Rows.Add(InitialTime)
            End While
        ElseIf globalVariables.DailyRepShift = "Night Shift" Then
            Dim InitialTime As Integer = 18
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    OwO.Rows.Add(After24Hrs)
                Else
                    OwO.Rows.Add(InitialTime)
                End If

            End While
        ElseIf globalVariables.DailyRepShift = "3rd Shift" Then
            Dim InitialTime As Integer = 22
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    OwO.Rows.Add(After24Hrs)
                Else
                    OwO.Rows.Add(InitialTime)
                End If
            End While
        End If

        OwO.Rows.Add("Component Scrap")
        OwO.Rows.Add("QA(QC) Sample (Normal)")
        OwO.Rows.Add("QA(QC) Sample (Additional)")
        OwO.Rows.Add("Engineering Sample")

        Return OwO

    End Function

    Private Sub GetShiftTime()
        gvData.Rows.Clear()
        If globalVariables.DailyRepShift = "1st Shift" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
            End While
            gvData.Rows.Add("Component Scrap")
            gvData.Rows.Add("QA(QC) Sample (Normal)")
            gvData.Rows.Add("QA(QC) Sample (Additional)")
            gvData.Rows.Add("Engineering Sample")
        ElseIf globalVariables.DailyRepShift = "Day Shift" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
            End While
            gvData.Rows.Add("Component Scrap")
            gvData.Rows.Add("QA(QC) Sample (Normal)")
            gvData.Rows.Add("QA(QC) Sample (Additional)")
            gvData.Rows.Add("Engineering Sample")
        ElseIf globalVariables.DailyRepShift = "2nd Shift" Then
            Dim InitialTime As Integer = 14
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                gvData.Rows.Add(InitialTime - 1 & ":00-" & InitialTime & ":00")
            End While
            gvData.Rows.Add("Component Scrap")
            gvData.Rows.Add("QA(QC) Sample (Normal)")
            gvData.Rows.Add("QA(QC) Sample (Additional)")
            gvData.Rows.Add("Engineering Sample")
        ElseIf globalVariables.DailyRepShift = "Night Shift" Then
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
            gvData.Rows.Add("Component Scrap")
            gvData.Rows.Add("QA(QC) Sample (Normal)")
            gvData.Rows.Add("QA(QC) Sample (Additional)")
            gvData.Rows.Add("Engineering Sample")
        ElseIf globalVariables.DailyRepShift = "3rd Shift" Then
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
            gvData.Rows.Add("Component Scrap")
            gvData.Rows.Add("QA(QC) Sample (Normal)")
            gvData.Rows.Add("QA(QC) Sample (Additional)")
            gvData.Rows.Add("Engineering Sample")
        End If

    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click

        Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
        Maria.AddMySqlParameters("parAssyNo", ddAssy.Text)
        Maria.SPADE("SP_SRCDailyReport_DeleteWeldingLotNo")

        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

            Try
                Dim parTime As String = Convert.ToString(gvData.Rows(rowcounter).Cells("Time").Value)
                Dim parBoxNo As String = If(gvData.Rows(rowcounter).Cells("Box/Cart No.").Value = Nothing, "", gvData.Rows(rowcounter).Cells("Box/Cart No.").Value.ToString)

                For colcounter As Integer = 2 To Me.gvData.Columns.Count - 1

                    Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                    Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
                    Maria.AddMySqlParameters("parAssyNo", ddAssy.Text)
                    Maria.AddMySqlParameters("parTime", parTime)
                    Maria.AddMySqlParameters("parBoxNo", parBoxNo)
                    Maria.AddMySqlParameters("parPartName", gvData.Columns(colcounter).FieldName)
                    Maria.AddMySqlParameters("parLotNo", If(gvData.Rows(rowcounter).Cells(colcounter).Value = Nothing, "", gvData.Rows(rowcounter).Cells(colcounter).Value.ToString))
                    Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                    Maria.SPADE("SP_SRCDailyReport_InsertWeldingLotNo")

                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Maria.Connection.Close()
            End Try

        Next
        MessageBox.Show("Done!")
        'Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
        'Maria.AddMySqlParameters("parCompScrap", spnComponent.Value)
        'Maria.AddMySqlParameters("parQANormal", spnNormal.Value)
        'Maria.AddMySqlParameters("parQAAdd", spnAdditional.Value)
        'Maria.AddMySqlParameters("parEng", spnEngExample.Value)
        'Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
        'Maria.SPADE("SP_SRCDailyReport_InsertWeldingLotNoExt")
        'MessageBox.Show("Done!")

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
End Class
