Imports System.ComponentModel
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Microsoft
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmATDailyReport
    Dim Furina As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim ManPowerTemplate As DataTable = Furina.MyQuery("SELECT * FROM tblDailyReportATManpowerTemp")
    Dim GoodQtyTemplate As DataTable = Furina.MyQuery("SELECT * FROM tblDailyReportATGoodQtyTemp")
    Dim CurrUser As String = globalVariables.currentUser(1)
    Dim DTLotTime As New DataTable
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
    Private Sub FrmATDailyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetTMNo()
        GridColManPower()
        GridColGoodQty()
        LoadPartNoDefects()
        GridColDefect()
        ReloadDefects()
        LoadLotGroup()
        ReloadTimeDD()
        ReloadLotNoGrid()
        ReloadOthersGrid()
        ReloadOtherDetails()
    End Sub

    Private Sub ReloadTimeDD()
        DTLotTime.Columns.Add("fldTime")
        Try
            DTLotTime.Rows.Clear()
        Catch ex As Exception

        End Try


        If Mio.ATShift = "6AM-2PM(1st Shift)" Then

            DTLotTime.Rows.Add("06:00-07:00")
            DTLotTime.Rows.Add("07:00-08:00")
            DTLotTime.Rows.Add("08:00-09:00")
            DTLotTime.Rows.Add("09:00-10:00")
            DTLotTime.Rows.Add("10:00-11:00")
            DTLotTime.Rows.Add("11:00-12:00")
            DTLotTime.Rows.Add("12:00-13:00")
            DTLotTime.Rows.Add("13:00-14:00")

        ElseIf Mio.ATShift = "6AM-6PM" Then

            DTLotTime.Rows.Add("14:00-15:00")
            DTLotTime.Rows.Add("15:00-16:00")
            DTLotTime.Rows.Add("16:00-17:00")
            DTLotTime.Rows.Add("17:00-18:00")
            DTLotTime.Rows.Add("18:00-19:00")
            DTLotTime.Rows.Add("19:00-20:00")
            DTLotTime.Rows.Add("20:00-21:00")
            DTLotTime.Rows.Add("21:00-22:00")

        ElseIf Mio.ATShift = "2PM-10PM(2nd Shift)" Then

            DTLotTime.Rows.Add("22:00-23:00")
            DTLotTime.Rows.Add("23:00-00:00")
            DTLotTime.Rows.Add("00:00-01:00")
            DTLotTime.Rows.Add("01:00-02:00")
            DTLotTime.Rows.Add("02:00-03:00")
            DTLotTime.Rows.Add("03:00-04:00")
            DTLotTime.Rows.Add("04:00-05:00")
            DTLotTime.Rows.Add("05:00-06:00")

        ElseIf Mio.ATShift = "6PM-6AM" Then

            DTLotTime.Rows.Add("06:00-07:00")
            DTLotTime.Rows.Add("07:00-08:00")
            DTLotTime.Rows.Add("08:00-09:00")
            DTLotTime.Rows.Add("09:00-10:00")
            DTLotTime.Rows.Add("10:00-11:00")
            DTLotTime.Rows.Add("11:00-12:00")
            DTLotTime.Rows.Add("12:00-13:00")
            DTLotTime.Rows.Add("13:00-14:00")
            DTLotTime.Rows.Add("14:00-15:00")
            DTLotTime.Rows.Add("15:00-16:00")
            DTLotTime.Rows.Add("16:00-17:00")
            DTLotTime.Rows.Add("17:00-18:00")

        ElseIf Mio.ATShift = "10PM-6AM(3rd Shift)" Then

            DTLotTime.Rows.Add("18:00-19:00")
            DTLotTime.Rows.Add("19:00-20:00")
            DTLotTime.Rows.Add("20:00-21:00")
            DTLotTime.Rows.Add("21:00-22:00")
            DTLotTime.Rows.Add("22:00-23:00")
            DTLotTime.Rows.Add("23:00-00:00")
            DTLotTime.Rows.Add("00:00-01:00")
            DTLotTime.Rows.Add("01:00-02:00")
            DTLotTime.Rows.Add("02:00-03:00")
            DTLotTime.Rows.Add("03:00-04:00")
            DTLotTime.Rows.Add("04:00-05:00")
            DTLotTime.Rows.Add("05:00-06:00")

        End If

        DTLotTime.Rows.Add("Component Scrap QTY")
        DTLotTime.Rows.Add("QA (QC) Sample")
        DTLotTime.Rows.Add("Eng'g Sample")

        ddLotTime.DataSource = DTLotTime
        ddLotTime.DisplayMember = "fldTime"
        ddLotTime.ValueMember = "fldTime"
        ddLotTime.AutoCompleteDataSource = DTLotTime
        ddLotTime.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddLotTime.AutoCompleteDisplayMember = "fldTime"
        ddLotTime.AutoCompleteValueMember = "fldTime"
        ddLotTime.Text = ""

    End Sub

    Private Sub GetTMNo()
        RemoveHandler ddMPPW.SelectedIndexChanged, AddressOf ddMPPW_SelectedIndexChanged
        RemoveHandler ddGQPWNo.SelectedIndexChanged, AddressOf ddGQPWNo_SelectedIndexChanged
        RemoveHandler ddITType.SelectedIndexChanged, AddressOf ddITType_SelectedIndexChanged
        Dim tempDT As DataTable = ManPowerTemplate
        Dim TMNo = (From t1 In tempDT.AsEnumerable
                    Where t1("fldModel").ToString.Equals(Mio.ATModel) And t1("fldLine").ToString.Equals(Mio.ATLine)
                    Select New With {
                        .fldMachNo = t1("fldMachNo").ToString
                    }).ToList

        'Dim TMNo As DataTable = Furina.MyQuery("SELECT fldMachNo FROM tblDailyReportATManpowerTemp where fldModel='" & Mio.ATModel & "' and fldLine=" & Mio.ATLine & "")
        ddMPPW.DataSource = convertToDatatable(TMNo)
        ddMPPW.DisplayMember = "fldMachNo"
        ddMPPW.ValueMember = "fldMachNo"
        ddMPPW.AutoCompleteDataSource = convertToDatatable(TMNo)
        ddMPPW.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddMPPW.AutoCompleteDisplayMember = "fldMachNo"
        ddMPPW.AutoCompleteValueMember = "fldMachNo"
        ddMPPW.Text = ""

        ddGQPWNo.DataSource = convertToDatatable(TMNo)
        ddGQPWNo.DisplayMember = "fldMachNo"
        ddGQPWNo.ValueMember = "fldMachNo"
        ddGQPWNo.AutoCompleteDataSource = convertToDatatable(TMNo)
        ddGQPWNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddGQPWNo.AutoCompleteDisplayMember = "fldMachNo"
        ddGQPWNo.AutoCompleteValueMember = "fldMachNo"
        ddGQPWNo.Text = ""

        ddITType.DataSource = convertToDatatable(TMNo)
        ddITType.DisplayMember = "fldMachNo"
        ddITType.ValueMember = "fldMachNo"
        ddITType.AutoCompleteDataSource = convertToDatatable(TMNo)
        ddITType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddITType.AutoCompleteDisplayMember = "fldMachNo"
        ddITType.AutoCompleteValueMember = "fldMachNo"
        ddITType.Text = ""
        AddHandler ddITType.SelectedIndexChanged, AddressOf ddITType_SelectedIndexChanged
        AddHandler ddMPPW.SelectedIndexChanged, AddressOf ddMPPW_SelectedIndexChanged
        AddHandler ddGQPWNo.SelectedIndexChanged, AddressOf ddGQPWNo_SelectedIndexChanged
    End Sub

    Private Sub ddMPPW_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddMPPW.SelectedIndexChanged
        RemoveHandler ddMPProc.SelectedIndexChanged, AddressOf ddMPProc_SelectedIndexChanged
        Dim tempDT As DataTable = ManPowerTemplate
        Dim ManPowerAT = (From t1 In tempDT.AsEnumerable
                          Where t1.Field(Of String)("fldModel") = Mio.ATModel And t1.Field(Of Integer)("fldLine") = Mio.ATLine And t1("fldMachNo") = ddMPPW.Text
                          Select New With {
                        .fldProcessName = t1("fldProcessName").ToString
                    }).ToList
        'Dim ManPowerAT As DataTable = Furina.MyQuery("SELECT * FROM tblDailyReportATManpowerTemp  where fldModel='" & Mio.ATModel & "' and fldLine=" & Mio.ATLine & " and fldMachNo='" & ddMPPW.Text & "' ")
        ddMPProc.DataSource = convertToDatatable(ManPowerAT)
        ddMPProc.DisplayMember = "fldProcessName"
        ddMPProc.ValueMember = "fldProcessName"
        ddMPProc.AutoCompleteDataSource = convertToDatatable(ManPowerAT)
        ddMPProc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddMPProc.AutoCompleteDisplayMember = "fldProcessName"
        ddMPProc.AutoCompleteValueMember = "fldProcessName"
        ddMPProc.Items.Add("-Select Process-")
        ddMPProc.Text = "-Select Process-"
        ReloadManPower()
        AddHandler ddMPProc.SelectedIndexChanged, AddressOf ddMPProc_SelectedIndexChanged
    End Sub

    Private Sub ddMPProc_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddMPProc.SelectedIndexChanged

        If ddMPProc.Text = "-Select Process-" Then
            tbMPEmpName.Text = ""
        Else
            Dim tempDT As DataTable = ManPowerTemplate
            Dim ManPowerAT = (From t1 In tempDT.AsEnumerable
                              Where t1.Field(Of String)("fldModel") = Mio.ATModel And t1.Field(Of Integer)("fldLine") = Mio.ATLine And t1("fldMachNo") = ddMPPW.Text And t1.Field(Of String)("fldProcessName") = ddMPProc.Text
                              Select New With {
                            .fldEmployee = t1("fldEmployee").ToString
                        }).ToList
            tbMPEmpName.Text = ManPowerAT.Item(0).fldEmployee.ToString
        End If
    End Sub

    Private Sub ddGQPWNo_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddGQPWNo.SelectedIndexChanged
        Dim GQAT = (From t1 In GoodQtyTemplate.AsEnumerable
                    Where t1("fldModel") = Mio.ATModel And t1("fldLine") = Mio.ATLine And t1("fldMachNo") = ddGQPWNo.Text
                    Select New With {
                        .fldPartNo = t1("fldPartNo").ToString
                    }).ToList

        ddGQPartName.DataSource = convertToDatatable(GQAT)
        ddGQPartName.DisplayMember = "fldPartNo"
        ddGQPartName.ValueMember = "fldPartNo"
        ddGQPartName.AutoCompleteDataSource = convertToDatatable(GQAT)
        ddGQPartName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddGQPartName.AutoCompleteDisplayMember = "fldPartNo"
        ddGQPartName.AutoCompleteValueMember = "fldPartNo"
        ddGQPartName.Items.Add("-Select Part-")
        ddGQPartName.Text = "-Select Part-"
        ReloadGoodQty()
    End Sub

    Private Sub ddGQPartName_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddGQPartName.SelectedIndexChanged
        If ddGQPartName.Text = "-Select Part-" Then
            spnGQQty.Enabled = False
        Else
            spnGQQty.Enabled = True
        End If
    End Sub

    Private Sub GetTimePart()

    End Sub

    Private Sub ddITType_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddITType.SelectedIndexChanged

        Dim ShiftConv As String = ""

        If Mio.ATShift = "6AM-2PM(1st Shift)" Then
            ShiftConv = "1st Shift"
        ElseIf Mio.ATShift = "6AM-6PM" Then
            ShiftConv = "Day Shift"
        ElseIf Mio.ATShift = "2PM-10PM(2nd Shift)" Then
            ShiftConv = "2nd Shift"
        ElseIf Mio.ATShift = "6PM-6AM" Then
            ShiftConv = "Night Shift"
        ElseIf Mio.ATShift = "10PM-6AM(3rd Shift)" Then
            ShiftConv = "3rd Shift"
        End If

        Furina.AddMySqlParameters("parModel", Mio.ATModel)
        Furina.AddMySqlParameters("parShift", ShiftConv)
        Furina.AddMySqlParameters("parDate", Mio.ATDate)
        Furina.AddMySqlParameters("parPlan", 1)
        Furina.AddMySqlParameters("parType", "TM")
        Furina.AddMySqlParameters("parMachNo", ddITType.Text)
        Dim DTDownTimeCheckPlan As DataTable = Furina.SPSelect("SP_SRCDownTime_SelectByDailyReportByMachine")
        If DTDownTimeCheckPlan.Rows.Count >= 1 Then
            If IsDBNull(DTDownTimeCheckPlan.Rows(0).Item("TotalDT")) Then
                spnITPlanDT.Value = 0
            Else
                spnITPlanDT.Value = DTDownTimeCheckPlan.Rows(0).Item("TotalDT")
            End If
        Else
            spnITPlanDT.Value = 0
        End If

        Furina.AddMySqlParameters("parModel", Mio.ATModel)
        Furina.AddMySqlParameters("parShift", ShiftConv)
        Furina.AddMySqlParameters("parDate", Mio.ATDate)
        Furina.AddMySqlParameters("parPlan", 0)
        Furina.AddMySqlParameters("parType", "TM")
        Furina.AddMySqlParameters("parMachNo", ddITType.Text)
        Dim DTDownTimeCheckUnPlan As DataTable = Furina.SPSelect("SP_SRCDownTime_SelectByDailyReportByMachine")
        If DTDownTimeCheckUnPlan.Rows.Count >= 1 Then
            If IsDBNull(DTDownTimeCheckUnPlan.Rows(0).Item("TotalDT")) Then
                spnITUnplanDT.Value = 0
            Else
                spnITUnplanDT.Value = DTDownTimeCheckUnPlan.Rows(0).Item("TotalDT")
            End If
        Else
            spnITUnplanDT.Value = 0
        End If

        Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
        Furina.AddMySqlParameters("parType", "AT")
        Furina.AddMySqlParameters("parMachNo", ddITType.Text)
        Dim DTOpTime As DataTable = Furina.SPSelect("SP_SRC_SelectATOpTimeByMachine")
        If DTOpTime.Rows.Count >= 1 Then
            If IsDBNull(DTOpTime.Rows(0).Item("TotalTime")) Then
                spnITOPTime.Value = 0
            Else
                spnITOPTime.Value = DTOpTime.Rows(0).Item("TotalTime")
            End If
        Else
            spnITOPTime.Value = 0
        End If

        Dim DTLineTimePart As DataTable = Furina.MyQuery("SELECT concat(Date_Format(fldTimeFrom,'%k:%i'),'-',Date_Format(fldTimeTo,'%k:%i')) as fldTimePart FROM tblDailyReportTime where fldDRID=" & Mio.ATDRID & " and fldType='AT' and fldMachNo='" & ddITType.Text & "'")
        If DTLineTimePart.Rows.Count = 1 Then
            tbITTimePart.Text = DTLineTimePart.Rows(0).Item("fldTimePart").ToString
        ElseIf DTLineTimePart.Rows.Count > 1 Then
            Dim i As Integer = 0
            Dim TimePart As String = ""
            While i <= DTLineTimePart.Rows.Count - 1
                If i = 0 Then
                    TimePart = DTLineTimePart.Rows(i).Item("fldTimePart").ToString
                Else
                    TimePart = TimePart & ", " & DTLineTimePart.Rows(i).Item("fldTimePart").ToString
                End If

                i = i + 1
            End While
            tbITTimePart.Text = TimePart
        Else
            tbITTimePart.Text = "N/A"
        End If

        'Dim DTGoodQty As DataTable = Furina.MyQuery("SELECT sum(fldQty) as fldQty FROM tblDailyReportATGoodQty where fldDRID=" & Mio.ATDRID & " and fldNo='" & ddITType.Text & "'")
        'If DTGoodQty.Rows.Count >= 1 Then
        '    ComputeCycleTime(Convert.ToDecimal(DTGoodQty.Rows(0).Item("fldQty")))
        'Else
        '    ComputeCycleTime(0)
        'End If
    End Sub

    Private Sub ComputeCycleTime(parOutput As Decimal)

        Dim Downtimetotal As Decimal = spnITPlanDT.Value + spnITUnplanDT.Value
        Dim OpTimetotal As Decimal = spnITOPTime.Value
        Dim computeCycle As Decimal = ((OpTimetotal - Downtimetotal) * 60) / parOutput
        RadMessageBox.Show(computeCycle)

    End Sub

    Private Sub btnGQSubmit_Click(sender As Object, e As EventArgs) Handles btnGQSubmit.Click
        Try
            Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
            Furina.AddMySqlParameters("parNo", ddGQPWNo.Text)
            Furina.AddMySqlParameters("parPartName", ddGQPartName.Text)
            Furina.AddMySqlParameters("parQty", spnGQQty.Value)
            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRC_InsertATGoodQty")
            RadMessageBox.Show("Item Added")
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
        ReloadGoodQty()
    End Sub

    Private Sub btnMPSubmit_Click(sender As Object, e As EventArgs) Handles btnMPSubmit.Click

        Try
            Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
            Furina.AddMySqlParameters("parNo", ddMPPW.Text)
            Furina.AddMySqlParameters("parProcName", ddMPProc.Text)
            Furina.AddMySqlParameters("parEmployee", tbMPEmpName.Text)
            If ddMPStatus.Text = "Qualified" Then
                Furina.AddMySqlParameters("parQualified", 1)
                Furina.AddMySqlParameters("parTransfer", 0)
                Furina.AddMySqlParameters("parTrainee", 0)
            ElseIf ddMPStatus.Text = "Transferred" Then
                Furina.AddMySqlParameters("parQualified", 0)
                Furina.AddMySqlParameters("parTransfer", 1)
                Furina.AddMySqlParameters("parTrainee", 0)
            ElseIf ddMPStatus.Text = "Trainee" Then
                Furina.AddMySqlParameters("parQualified", 0)
                Furina.AddMySqlParameters("parTransfer", 0)
                Furina.AddMySqlParameters("parTrainee", 1)
            Else
                Furina.AddMySqlParameters("parQualified", 0)
                Furina.AddMySqlParameters("parTransfer", 0)
                Furina.AddMySqlParameters("parTrainee", 0)
            End If

            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRC_InsertATManpower")

            RadMessageBox.Show("Item Added!")
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
        ReloadManPower()
    End Sub
    Private Sub GridColManPower()

        rgvManpower.Columns.Clear()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvManpower.Columns.Add(fldID)

        Dim fldProcessName As New GridViewTextBoxColumn
        fldProcessName.HeaderText = "Assembly Process Name"
        fldProcessName.FieldName = "fldProcName"
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

    Private Sub GridColGoodQty()
        rgvGoodQty.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvGoodQty.Columns.Add(fldID)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Lot No"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.Width = 200
        fldPartName.ReadOnly = True
        rgvGoodQty.Columns.Add(fldPartName)

        Dim fldQty As New GridViewTextBoxColumn
        fldQty.HeaderText = "Quantity"
        fldQty.FieldName = "fldQty"
        fldQty.TextAlignment = ContentAlignment.MiddleCenter
        fldQty.Width = 100
        fldQty.ReadOnly = True
        rgvGoodQty.Columns.Add(fldQty)

    End Sub
    Private Sub ReloadManPower()
        rgvManpower.DataSource = Furina.MyQuery("Select * From tblDailyReportATManpower where fldDRID=" & Mio.ATDRID & " and fldNo='" & ddMPPW.Text & "'")
    End Sub

    Private Sub ReloadGoodQty()
        rgvGoodQty.DataSource = Furina.MyQuery("Select * From tblDailyReportATGoodQty where fldDRID=" & Mio.ATDRID & " and fldNo='" & ddGQPWNo.Text & "'")
    End Sub

    Private Sub rgvManpower_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvManpower.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                Try
                    Furina.MyQuery("Delete From tblDailyReportATManpower where fldID=" & rgvManpower.CurrentRow.Cells("fldID").Value & "")
                    RadMessageBox.Show("Item Deleted")
                Catch ex As Exception
                    RadMessageBox.Show(ex.Message)
                End Try
                ReloadManPower()
            End If
        End If
    End Sub

    Private Sub rgvGoodQty_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvGoodQty.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                Try
                    Furina.MyQuery("Delete From tblDailyReportATGoodQty where fldID=" & rgvGoodQty.CurrentRow.Cells("fldID").Value & "")
                    RadMessageBox.Show("Item Deleted")
                Catch ex As Exception
                    RadMessageBox.Show(ex.Message)
                End Try
                ReloadGoodQty()
            End If
        End If
    End Sub

    Private Sub LoadPartNoDefects()
        Dim DefPartNo As DataTable = Furina.MyQuery("SELECT distinct(fldPartNo) as fldPartNo FROM tblDailyReportATGoodQtyTemp where fldModel='" & Mio.ATModel & "' and fldLine=" & Mio.ATLine & "")
        ddDEFPart.DataSource = DefPartNo
        ddDEFPart.DisplayMember = "fldPartNo"
        ddDEFPart.ValueMember = "fldPartNo"
        ddDEFPart.AutoCompleteDataSource = DefPartNo
        ddDEFPart.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddDEFPart.AutoCompleteDisplayMember = "fldPartNo"
        ddDEFPart.AutoCompleteValueMember = "fldPartNo"
        ddDEFPart.Text = ""
    End Sub

    Private Sub btnSPDSubmit_Click(sender As Object, e As EventArgs) Handles btnSPDSubmit.Click
        If btnSPDSubmit.Text = "SAVE" Then
            Try
                Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
                Furina.AddMySqlParameters("parDefect", tbDEFDefect.Text)
                Furina.AddMySqlParameters("parPartNo", ddDEFPart.Text)
                Furina.AddMySqlParameters("parNo", spnDEFNo.Value)
                Furina.AddMySqlParameters("parAddedBy", currentUser)
                Furina.SPADE("SP_SRC_InsertATDefects")
                RadMessageBox.Show("Item Added!")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
        Else
            Furina.AddMySqlParameters("parID", lblDefectID.Text)
            Furina.AddMySqlParameters("parDefect", tbDEFDefect.Text)
            Furina.AddMySqlParameters("parPartNo", ddDEFPart.Text)
            Furina.AddMySqlParameters("parNo", spnDEFNo.Value)
            Furina.AddMySqlParameters("parAddedBy", currentUser)
            Furina.SPADE("SP_SRC_EditATDefects")
            RadMessageBox.Show("Item Edited!")
            btnSPDSubmit.Text = "SAVE"
            btnSPDCancel.Visible = False
        End If

        ReloadDefects()
    End Sub

    Private Sub GridColDefect()
        rgvSRCDefects.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvSRCDefects.Columns.Add(fldID)

        Dim fldDefect As New GridViewTextBoxColumn
        fldDefect.HeaderText = "Defect"
        fldDefect.FieldName = "fldDefect"
        fldDefect.TextAlignment = ContentAlignment.MiddleCenter
        fldDefect.Width = 200
        fldDefect.ReadOnly = True
        rgvSRCDefects.Columns.Add(fldDefect)

        Dim fldPartNo As New GridViewTextBoxColumn
        fldPartNo.HeaderText = "Part No."
        fldPartNo.FieldName = "fldPartNo"
        fldPartNo.TextAlignment = ContentAlignment.MiddleCenter
        fldPartNo.Width = 200
        fldPartNo.ReadOnly = True
        rgvSRCDefects.Columns.Add(fldPartNo)

        Dim fldNo As New GridViewTextBoxColumn
        fldNo.HeaderText = "Qty"
        fldNo.FieldName = "fldNo"
        fldNo.TextAlignment = ContentAlignment.MiddleCenter
        fldNo.Width = 90
        fldNo.ReadOnly = True
        rgvSRCDefects.Columns.Add(fldNo)

    End Sub
    Private Sub ReloadDefects()
        rgvSRCDefects.DataSource = Furina.MyQuery("SELECT * FROM tblDailyReportATDefect where fldDRID=" & Mio.ATDRID & "")
    End Sub

    Private Sub rgvSRCDefects_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvSRCDefects.CellDoubleClick
        ddDEFPart.Text = rgvSRCDefects.CurrentRow.Cells("fldPartNo").Value.ToString
        tbDEFDefect.Text = rgvSRCDefects.CurrentRow.Cells("fldDefect").Value.ToString
        spnDEFNo.Value = rgvSRCDefects.CurrentRow.Cells("fldNo").Value
        lblDefectID.Text = rgvSRCDefects.CurrentRow.Cells("fldID").Value.ToString
        btnSPDSubmit.Text = "EDIT"
        btnSPDCancel.Visible = True
    End Sub

    Private Sub btnSPDCancel_Click(sender As Object, e As EventArgs) Handles btnSPDCancel.Click
        btnSPDSubmit.Text = "SAVE"
        btnSPDCancel.Visible = False
    End Sub

    Private Sub LoadLotGroup()
        RemoveHandler ddLotAssy.SelectedIndexChanged, AddressOf ddLotAssy_SelectedIndexChanged
        Dim DTLotGroup As DataTable = Furina.MyQuery("SELECT distinct(fldLotGroup) as fldLotGroup FROM tblDailyReportATLotTemp where fldModel='" & Mio.ATModel & "' and fldLine=" & Mio.ATLine & "")
        ddLotAssy.DataSource = DTLotGroup
        ddLotAssy.DisplayMember = "fldLotGroup"
        ddLotAssy.ValueMember = "fldLotGroup"
        ddLotAssy.AutoCompleteDataSource = DTLotGroup
        ddLotAssy.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddLotAssy.AutoCompleteDisplayMember = "fldLotGroup"
        ddLotAssy.AutoCompleteValueMember = "fldLotGroup"
        ddLotAssy.Text = ""
        AddHandler ddLotAssy.SelectedIndexChanged, AddressOf ddLotAssy_SelectedIndexChanged
    End Sub



    Private Sub btnITSubmit_Click(sender As Object, e As EventArgs) Handles btnITSubmit.Click
        Try
            Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
            Furina.AddMySqlParameters("parNo", ddITType.Text)
            Furina.AddMySqlParameters("parStart", spnITHotto.Value)
            Furina.AddMySqlParameters("parTL", spnITPersons.Value)
            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRC_InsertATTimePart")
            RadMessageBox.Show("Data Saved")
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSRCAutoAdd_Click(sender As Object, e As EventArgs) Handles btnSRCAutoAdd.Click

        Dim result As Integer = MessageBox.Show("This will automatically save Defects and Lot Number Without Data", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        Else

            Dim result2 As Integer = MessageBox.Show("This will replace data if there are existing one. Proceed?", "Yes or No?", MessageBoxButtons.YesNo)
            If result2 = DialogResult.No Then

            Else
                BackgroundWorker1.RunWorkerAsync()
            End If

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Furina.MyQuery("Delete From tblDailyReportATDefect where fldDRID=" & Mio.ATDRID & "")
        Furina.MyQuery("Delete From tblDailyReportATLot where fldDRID=" & Mio.ATDRID & "")

        Dim counter As Integer = 0

        Dim DefPartNo As DataTable = Furina.MyQuery("SELECT distinct(fldPartNo) as fldPartNo FROM tblDailyReportATGoodQtyTemp where fldModel='" & Mio.ATModel & "' and fldLine=" & Mio.ATLine & "")

        For Each row As DataRow In DefPartNo.Rows

            Try
                Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
                Furina.AddMySqlParameters("parDefect", "")
                Furina.AddMySqlParameters("parPartNo", row.Item("fldPartNo").ToString)
                Furina.AddMySqlParameters("parNo", 0)
                Furina.AddMySqlParameters("parAddedBy", currentUser)
                Furina.SPADE("SP_SRC_InsertATDefects")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try

            Dim percent As Double = counter / DefPartNo.Rows.Count * 100
            RadProgressBar1.Text = "TM"
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(50)
            counter = counter + 1
        Next

        Dim DTLotGroup As DataTable = Furina.MyQuery("SELECT distinct(fldLotGroup) as fldLotGroup FROM tblDailyReportATLotTemp where fldModel='" & Mio.ATModel & "' and fldLine=" & Mio.ATLine & "")

        For Each rowLotGroup As DataRow In DTLotGroup.Rows

            Dim DTWIPNo As DataTable = Furina.MyQuery("SELECT fldLotNo FROM tblDailyReportATLotTemp where fldModel='" & Mio.ATModel & "' and fldLine=" & Mio.ATLine & " and fldLotGroup='" & rowLotGroup.Item("fldLotGroup").ToString & "'")

            For Each rowTime As DataRow In DTLotTime.Rows
                counter = 0
                For Each rowWipNo As DataRow In DTWIPNo.Rows

                    Try
                        Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
                        Furina.AddMySqlParameters("parGroup", rowLotGroup.Item("fldLotGroup").ToString)
                        Furina.AddMySqlParameters("parPartName", rowWipNo.Item("fldLotNo").ToString)
                        Furina.AddMySqlParameters("parTime", rowTime.Item("fldTime").ToString)
                        Furina.AddMySqlParameters("parBoxNo", "")
                        Furina.AddMySqlParameters("parLotNo", "")
                        Furina.AddMySqlParameters("parAddedBy", CurrUser)
                        Furina.SPADE("SP_SRC_InsertATLotNo")
                    Catch ex As Exception
                        RadMessageBox.Show(ex.Message)
                    End Try

                    Dim percent As Double = counter / DTWIPNo.Rows.Count * 100
                    RadProgressBar1.Text = rowWipNo.Item("fldLotNo").ToString
                    BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
                    Threading.Thread.Sleep(50)
                    counter = counter + 1

                Next

            Next

        Next

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        RadProgressBar1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        RadMessageBox.Show("Done")
    End Sub

    Private Sub ReloadLotNoGrid()
        rgvLotNo.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvLotNo.Columns.Add(fldID)

        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time"
        fldTime.FieldName = "fldTime"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.Width = 200
        fldTime.ReadOnly = True
        rgvLotNo.Columns.Add(fldTime)

        Dim fldBoxNo As New GridViewTextBoxColumn
        fldBoxNo.HeaderText = "Box No."
        fldBoxNo.FieldName = "fldBoxNo"
        fldBoxNo.TextAlignment = ContentAlignment.MiddleCenter
        fldBoxNo.Width = 200
        fldBoxNo.ReadOnly = True
        rgvLotNo.Columns.Add(fldBoxNo)

        Dim fldLotNo As New GridViewTextBoxColumn
        fldLotNo.HeaderText = "Lot No."
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLotNo.Width = 90
        fldLotNo.ReadOnly = True
        rgvLotNo.Columns.Add(fldLotNo)
    End Sub
    Private Sub ddLotAssy_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddLotAssy.SelectedIndexChanged
        RemoveHandler ddLotPartName.SelectedIndexChanged, AddressOf ddLotPartName_SelectedIndexChanged
        Dim DTLotNo As DataTable = Furina.MyQuery("SELECT fldLotNo FROM tblDailyReportATLotTemp where fldModel='" & Mio.ATModel & "' and fldLine=" & Mio.ATLine & " and fldLotGroup='" & ddLotAssy.Text & "'")
        DTLotNo.Rows.Add("-Select-")
        ddLotPartName.DataSource = DTLotNo
        ddLotPartName.DisplayMember = "fldLotNo"
        ddLotPartName.ValueMember = "fldLotNo"
        ddLotPartName.AutoCompleteDataSource = DTLotNo
        ddLotPartName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddLotPartName.AutoCompleteDisplayMember = "fldLotNo"
        ddLotPartName.AutoCompleteValueMember = "fldLotNo"
        ddLotPartName.SelectedIndex = DTLotNo.Rows.Count - 1
        AddHandler ddLotPartName.SelectedIndexChanged, AddressOf ddLotPartName_SelectedIndexChanged
        rgvLotNo.DataSource = Nothing
    End Sub
    Private Sub ddLotPartName_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddLotPartName.SelectedIndexChanged
        If ddLotPartName.Text = "-Select-" Then
            rgvLotNo.DataSource = Nothing
        Else
            Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
            Furina.AddMySqlParameters("parGroup", ddLotAssy.Text)
            Furina.AddMySqlParameters("parPartName", ddLotPartName.Text)
            rgvLotNo.DataSource = Furina.SPSelect("SP_SRC_SelectATLotByPart")
        End If
    End Sub

    Private Sub rgvLotNo_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvLotNo.CellDoubleClick
        ddLotTime.Text = rgvLotNo.CurrentRow.Cells("fldTime").Value.ToString
        tbLotBoxNo.Text = rgvLotNo.CurrentRow.Cells("fldBoxNo").Value.ToString
        tbLotLotNo.Text = rgvLotNo.CurrentRow.Cells("fldLotNo").Value.ToString
        lblLotID.Text = rgvLotNo.CurrentRow.Cells("fldID").Value.ToString
        btnLotSubmit.Text = "EDIT"
        btnLotCancel.Visible = True
    End Sub

    Private Sub btnLotCancel_Click(sender As Object, e As EventArgs) Handles btnLotCancel.Click
        btnLotSubmit.Text = "SAVE"
        btnLotCancel.Visible = False
    End Sub

    Private Sub btnLotSubmit_Click(sender As Object, e As EventArgs) Handles btnLotSubmit.Click
        If btnLotSubmit.Text = "SAVE" Then
            Try
                Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
                Furina.AddMySqlParameters("parGroup", ddLotAssy.Text)
                Furina.AddMySqlParameters("parPartName", ddLotPartName.Text)
                Furina.AddMySqlParameters("parTime", ddLotTime.Text)
                Furina.AddMySqlParameters("parBoxNo", tbLotBoxNo.Text)
                Furina.AddMySqlParameters("parLotNo", tbLotLotNo.Text)
                Furina.AddMySqlParameters("parAddedBy", CurrUser)
                Furina.SPADE("SP_SRC_InsertATLotNo")
                RadMessageBox.Show("Item Added")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Furina.AddMySqlParameters("parID", lblLotID.Text)
                Furina.AddMySqlParameters("parGroup", ddLotAssy.Text)
                Furina.AddMySqlParameters("parPartName", ddLotPartName.Text)
                Furina.AddMySqlParameters("parTime", ddLotTime.Text)
                Furina.AddMySqlParameters("parBoxNo", tbLotBoxNo.Text)
                Furina.AddMySqlParameters("parLotNo", tbLotLotNo.Text)
                Furina.AddMySqlParameters("parAddedBy", CurrUser)
                Furina.SPADE("SP_SRC_EditATLotNo")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
            Try
                Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
                Furina.AddMySqlParameters("parGroup", ddLotAssy.Text)
                Furina.AddMySqlParameters("parTime", ddLotTime.Text)
                Furina.AddMySqlParameters("parBoxNo", tbLotBoxNo.Text)
                Furina.SPADE("SP_SRC_EditATLotNoBox")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
            RadMessageBox.Show("Done!")
        End If
        ReloadLotItem
    End Sub

    Private Sub ReloadLotItem()
        Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
        Furina.AddMySqlParameters("parGroup", ddLotAssy.Text)
        Furina.AddMySqlParameters("parPartName", ddLotPartName.Text)
        rgvLotNo.DataSource = Furina.SPSelect("SP_SRC_SelectATLotByPart")
    End Sub

    Private Sub btnOthSave_Click(sender As Object, e As EventArgs) Handles btnOthSave.Click
        If btnOthSave.Text = "SAVE" Then
            Try
                Furina.AddMySqlParameters("parDRID", Mio.ATDRID)
                Furina.AddMySqlParameters("parDetails", tbOthDetails.Text)
                Furina.AddMySqlParameters("parAddedBy", CurrUser)
                Furina.SPADE("SP_SRC_InsertATOthers")
                RadMessageBox.Show("Item Added")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Furina.AddMySqlParameters("parID", lblOtherID.Text)
                Furina.AddMySqlParameters("parDetails", tbOthDetails.Text)
                Furina.AddMySqlParameters("parAddedBy", CurrUser)
                Furina.SPADE("SP_SRC_EditATOthers")
                RadMessageBox.Show("Item Edited")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
            End Try
        End If
        ReloadOtherDetails()
    End Sub

    Private Sub rgvOthers_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvOthers.CellDoubleClick
        lblOtherID.Text = rgvOthers.CurrentRow.Cells("fldID").Value.ToString
        tbOthDetails.Text = rgvOthers.CurrentRow.Cells("fldDetails").Value.ToString
        btnOthSave.Text = "EDIT"
        btnOthCancel.Visible = True
    End Sub
    Private Sub ReloadOthersGrid()
        rgvOthers.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        rgvOthers.Columns.Add(fldID)

        Dim fldDetails As New GridViewTextBoxColumn
        fldDetails.HeaderText = "Details"
        fldDetails.FieldName = "fldDetails"
        fldDetails.TextAlignment = ContentAlignment.MiddleCenter
        fldDetails.Width = 400
        fldDetails.ReadOnly = True
        rgvOthers.Columns.Add(fldDetails)
    End Sub

    Private Sub btnOthCancel_Click(sender As Object, e As EventArgs) Handles btnOthCancel.Click
        btnOthSave.Text = "SAVE"
        btnOthCancel.Visible = False
    End Sub

    Private Sub ReloadOtherDetails()
        rgvOthers.DataSource = Furina.MyQuery("Select * From tblDailyReportATOthers where fldDRID=" & Mio.ATDRID & "")
    End Sub

End Class
