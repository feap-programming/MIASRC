Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmSRCAssyUpload
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim Kurumi As New Kurumi.DB("192.168.191.252", "dbHRMSlive", "feap", "45|iF$")
    Dim ProdEmp As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")

    Dim CurrentProg As String = ""


    'Dim ExcelManpower As DataTable = globalVariables.GlobalExcelManpower
    'Dim ExcelHourly As DataTable = globalVariables.GlobalExcelHourly
    'Dim ExcelSRCAssy As DataTable = globalVariables.GlobalExcelSRCAssy
    'Dim ExcelDefectsA As DataTable = globalVariables.GlobalExcelDefectsA
    'Dim ExcelDefectsB As DataTable = globalVariables.GlobalExcelDefectsB
    'Dim ExcelDefectsC As DataTable = globalVariables.GlobalExcelDefectsC
    'Dim ExcelDefectsD As DataTable = globalVariables.GlobalExcelDefectsD
    'Dim ExcelLotNo As DataTable = globalVariables.GlobaldtManpower

    'Dim dtManpower As DataTable = globalVariables.GlobaldtManpower
    'Dim dtHourly As DataTable = globalVariables.GlobaldtHourly
    'Dim dtSRCAssy As DataTable = globalVariables.GlobaldtSRCAssy
    'Dim dtDefects As DataTable = globalVariables.GlobaldtDefects
    'Dim dtLotNo As DataTable = globalVariables.GlobaldtLotNo

    Dim ExcelManpower As DataTable = New DataTable
    Dim ExcelHourly As DataTable = New DataTable
    Dim ExcelSRCAssy As DataTable = New DataTable
    Dim ExcelDefectsA As DataTable = New DataTable
    Dim ExcelDefectsB As DataTable = New DataTable
    Dim ExcelDefectsC As DataTable = New DataTable
    Dim ExcelDefectsD As DataTable = New DataTable
    Dim ExcelLotNo As DataTable = New DataTable

    Dim dtManpower As DataTable = New DataTable
    Dim dtHourly As DataTable = New DataTable
    Dim dtSRCAssy As DataTable = New DataTable
    Dim dtDefects As DataTable = New DataTable
    Dim dtLotNo As DataTable = New DataTable
    Private Sub FrmSRCAssyUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refreshGridview()
        'ReloadForm()

    End Sub
    Private Sub GridColManpower()
        gvDataManpower.Columns.Clear()
        Dim fldProcessName As New GridViewTextBoxColumn
        fldProcessName.HeaderText = "Assembly Process Name"
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.TextAlignment = ContentAlignment.MiddleCenter
        fldProcessName.Width = 400
        fldProcessName.ReadOnly = True
        gvDataManpower.Columns.Add(fldProcessName)

        'Dim fldEmployee As New GridViewComboBoxColumn
        'fldEmployee.FieldName = "fldEmployee"
        'fldEmployee.HeaderText = "Employee Name"
        'fldEmployee.DataSource = Me.ProdEmp
        'fldEmployee.ValueMember = "fldEmpName"
        'fldEmployee.DisplayMember = "fldEmpName"
        'fldEmployee.Width = 250
        'Me.gvDataManpower.Columns.Add(fldEmployee)

        Dim fldEmployee As New GridViewTextBoxColumn
        fldEmployee.HeaderText = "Employee Name"
        fldEmployee.FieldName = "fldEmployee"
        fldEmployee.TextAlignment = ContentAlignment.MiddleCenter
        fldEmployee.Width = 250
        fldEmployee.ReadOnly = True
        gvDataManpower.Columns.Add(fldEmployee)


        Dim fldQualified As New GridViewCheckBoxColumn()
        fldQualified.DataType = GetType(Integer)
        fldQualified.Name = "fldQualified"
        fldQualified.FieldName = "fldQualified"
        fldQualified.HeaderText = "Qualified"
        fldQualified.Width = 100
        gvDataManpower.MasterTemplate.Columns.Add(fldQualified)

        Dim fldTransferred As New GridViewCheckBoxColumn()
        fldTransferred.DataType = GetType(Integer)
        fldTransferred.Name = "fldTransferred"
        fldTransferred.FieldName = "fldTransferred"
        fldTransferred.HeaderText = "Transferred"
        fldTransferred.Width = 100
        gvDataManpower.MasterTemplate.Columns.Add(fldTransferred)

        Dim fldTrainee As New GridViewCheckBoxColumn()
        fldTrainee.DataType = GetType(Integer)
        fldTrainee.Name = "fldTrainee"
        fldTrainee.FieldName = "fldTrainee"
        fldTrainee.HeaderText = "Trainee"
        fldTrainee.Width = 100
        gvDataManpower.MasterTemplate.Columns.Add(fldTrainee)
    End Sub
    Private Sub GridColHourly()
        gvDataHourly.Columns.Clear()
        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time"
        fldTime.FieldName = "fldTime"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.MinWidth = 90
        fldTime.ReadOnly = True
        fldTime.IsPinned = True
        fldTime.PinPosition = PinnedColumnPosition.Left
        gvDataHourly.Columns.Add(fldTime)

        Dim fldCableGrease As New GridViewCheckBoxColumn()
        fldCableGrease.DataType = GetType(Integer)
        fldCableGrease.FieldName = "fldCableG"
        fldCableGrease.HeaderText = "Cable Greasing"
        fldCableGrease.MinWidth = 150
        gvDataHourly.MasterTemplate.Columns.Add(fldCableGrease)

        Dim fldStatorGrease As New GridViewCheckBoxColumn()
        fldStatorGrease.DataType = GetType(Integer)
        fldStatorGrease.FieldName = "fldStatorG"
        fldStatorGrease.HeaderText = "Stator Greasing"
        fldStatorGrease.MinWidth = 150
        gvDataHourly.MasterTemplate.Columns.Add(fldStatorGrease)

        Dim fldFinalProdCheck As New GridViewCheckBoxColumn()
        fldFinalProdCheck.DataType = GetType(Integer)
        fldFinalProdCheck.FieldName = "fldFinalProdCheck"
        fldFinalProdCheck.HeaderText = "Final Product Check"
        fldFinalProdCheck.MinWidth = 180
        gvDataHourly.MasterTemplate.Columns.Add(fldFinalProdCheck)

        Dim fldRotator As New GridViewTextBoxColumn
        fldRotator.HeaderText = "Rotator (Cavity#)"
        fldRotator.FieldName = "fldRotator"
        fldRotator.TextAlignment = ContentAlignment.MiddleCenter
        fldRotator.MinWidth = 150
        gvDataHourly.Columns.Add(fldRotator)

        Dim fldStator As New GridViewTextBoxColumn
        fldStator.HeaderText = "Stator (Cavity#)"
        fldStator.FieldName = "fldStator"
        fldStator.TextAlignment = ContentAlignment.MiddleCenter
        fldStator.MinWidth = 150
        gvDataHourly.Columns.Add(fldStator)

        Dim fldSubStator As New GridViewTextBoxColumn
        fldSubStator.HeaderText = "Sub Stator (Cavity#)"
        fldSubStator.FieldName = "fldSubStator"
        fldSubStator.TextAlignment = ContentAlignment.MiddleCenter
        fldSubStator.MinWidth = 200
        gvDataHourly.Columns.Add(fldSubStator)

        Dim fldSleeve As New GridViewTextBoxColumn
        fldSleeve.HeaderText = "Sleeve (Cavity#)"
        fldSleeve.FieldName = "fldSleeve"
        fldSleeve.TextAlignment = ContentAlignment.MiddleCenter
        fldSleeve.MinWidth = 150
        gvDataHourly.Columns.Add(fldSleeve)

        Dim fldBarcode As New GridViewTextBoxColumn
        fldBarcode.HeaderText = "Barcode No."
        fldBarcode.FieldName = "fldBarcode"
        fldBarcode.TextAlignment = ContentAlignment.MiddleCenter
        fldBarcode.MinWidth = 150
        gvDataHourly.Columns.Add(fldBarcode)

        Dim fldPlan As New GridViewTextBoxColumn
        fldPlan.HeaderText = "Plan"
        fldPlan.FieldName = "fldPlan"
        fldPlan.TextAlignment = ContentAlignment.MiddleCenter
        fldPlan.MinWidth = 100
        gvDataHourly.Columns.Add(fldPlan)

        Dim fldActual As New GridViewTextBoxColumn
        fldActual.HeaderText = "Actual"
        fldActual.FieldName = "fldActual"
        fldActual.TextAlignment = ContentAlignment.MiddleCenter
        fldActual.MinWidth = 100
        gvDataHourly.Columns.Add(fldActual)

        Dim fldNGElectrical As New GridViewTextBoxColumn
        fldNGElectrical.HeaderText = "Electrical(NG Prod. Counter Pcs.)"
        fldNGElectrical.FieldName = "fldElectrical"
        fldNGElectrical.TextAlignment = ContentAlignment.MiddleCenter
        fldNGElectrical.MinWidth = 300
        gvDataHourly.Columns.Add(fldNGElectrical)

        Dim fldNGFunction As New GridViewTextBoxColumn
        fldNGFunction.HeaderText = "Function(NG Prod. Counter Pcs.)"
        fldNGFunction.FieldName = "fldFunction"
        fldNGFunction.TextAlignment = ContentAlignment.MiddleCenter
        fldNGFunction.MinWidth = 300
        gvDataHourly.Columns.Add(fldNGFunction)

        Dim fldNGFinal As New GridViewTextBoxColumn
        fldNGFinal.HeaderText = "Final(NG Prod. Counter Pcs.)"
        fldNGFinal.FieldName = "fldFinal"
        fldNGFinal.TextAlignment = ContentAlignment.MiddleCenter
        fldNGFinal.MinWidth = 300
        gvDataHourly.Columns.Add(fldNGFinal)

        'gvDataHourly.MasterTemplate.BestFitColumns()

    End Sub
    Private Sub GridColSRCAssy()
        gvDataSRCAssy.Columns.Clear()
        Dim fldPartNo As New GridViewTextBoxColumn
        fldPartNo.HeaderText = "Part No."
        fldPartNo.FieldName = "fldPartNo"
        fldPartNo.TextAlignment = ContentAlignment.MiddleCenter
        fldPartNo.MinWidth = 100
        fldPartNo.ReadOnly = True
        fldPartNo.IsPinned = True
        fldPartNo.PinPosition = PinnedColumnPosition.Left
        gvDataSRCAssy.Columns.Add(fldPartNo)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 300
        fldPartName.ReadOnly = True
        fldPartName.IsPinned = True
        fldPartName.PinPosition = PinnedColumnPosition.Left
        gvDataSRCAssy.Columns.Add(fldPartName)

        Dim fldLotNo As New GridViewTextBoxColumn
        fldLotNo.HeaderText = "Lot No"
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLotNo.MinWidth = 400
        gvDataSRCAssy.Columns.Add(fldLotNo)

        Dim fldScrapQty As New GridViewTextBoxColumn
        fldScrapQty.HeaderText = "Scrap Qty"
        fldScrapQty.FieldName = "fldScrapQty"
        fldScrapQty.TextAlignment = ContentAlignment.MiddleCenter
        fldScrapQty.MinWidth = 150
        gvDataSRCAssy.Columns.Add(fldScrapQty)

        Dim fldPurgeQty As New GridViewTextBoxColumn
        fldPurgeQty.HeaderText = "Purge Qty"
        fldPurgeQty.FieldName = "fldPurgeQty"
        fldPurgeQty.TextAlignment = ContentAlignment.MiddleCenter
        fldPurgeQty.MinWidth = 150
        gvDataSRCAssy.Columns.Add(fldPurgeQty)

        Dim fldQASample As New GridViewTextBoxColumn
        fldQASample.HeaderText = "QA Sample"
        fldQASample.FieldName = "fldQASample"
        fldQASample.TextAlignment = ContentAlignment.MiddleCenter
        fldQASample.MinWidth = 150
        gvDataSRCAssy.Columns.Add(fldQASample)

        Dim fldEngSample As New GridViewTextBoxColumn
        fldEngSample.HeaderText = "Engineering Sample"
        fldEngSample.FieldName = "fldEngSample"
        fldEngSample.TextAlignment = ContentAlignment.MiddleCenter
        fldEngSample.MinWidth = 150
        gvDataSRCAssy.Columns.Add(fldEngSample)

        'gvDataSRCAssy.MasterTemplate.BestFitColumns()

    End Sub
    Private Sub ReloadGridA()
        gvDataA.Columns.Clear()
        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 200
        gvDataA.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 200
        gvDataA.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 150
        gvDataA.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 150
        gvDataA.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 150
        gvDataA.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 150
        gvDataA.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 150
        gvDataA.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 150
        gvDataA.Columns.Add(fldRM)

        'gvDataA.MasterTemplate.BestFitColumns()
    End Sub
    Private Sub ReloadGridB()
        gvDataB.Columns.Clear()
        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 200
        gvDataB.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 200
        gvDataB.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 150
        gvDataB.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 150
        gvDataB.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 150
        gvDataB.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 150
        gvDataB.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 150
        gvDataB.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 150
        gvDataB.Columns.Add(fldRM)

        'gvDataB.MasterTemplate.BestFitColumns()
    End Sub
    Private Sub ReloadGridC()
        gvDataC.Columns.Clear()
        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 200
        gvDataC.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 200
        gvDataC.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 150
        gvDataC.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 150
        gvDataC.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 150
        gvDataC.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 150
        gvDataC.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 150
        gvDataC.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 150
        gvDataC.Columns.Add(fldRM)

        'gvDataC.MasterTemplate.BestFitColumns()
    End Sub
    Private Sub ReloadGridD()
        gvDataD.Columns.Clear()
        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 200
        gvDataD.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 200
        gvDataD.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 150
        gvDataD.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 150
        gvDataD.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 150
        gvDataD.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 150
        gvDataD.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 150
        gvDataD.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 150
        gvDataD.Columns.Add(fldRM)

        'gvDataD.MasterTemplate.BestFitColumns()
    End Sub
    Private Sub ReloadGrid()

        gvDataLotNo.Columns.Clear()
        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time"
        fldTime.FieldName = "Time"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.Width = 200
        fldTime.IsPinned = True
        fldTime.PinPosition = PinnedColumnPosition.Left
        gvDataLotNo.Columns.Add(fldTime)

        Dim fldBoxNo As New GridViewTextBoxColumn
        fldBoxNo.HeaderText = "Box/Cart No."
        fldBoxNo.FieldName = "Box/Cart No."
        fldBoxNo.TextAlignment = ContentAlignment.MiddleCenter
        fldBoxNo.Width = 150
        fldBoxNo.IsPinned = True
        fldBoxNo.PinPosition = PinnedColumnPosition.Left
        gvDataLotNo.Columns.Add(fldBoxNo)

        Dim DTAssy As DataTable = Maria.MyQuery("SELECT fldPartName FROM tblDailyReportSRCRawMatsTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLine & "")

        Dim CavSpace As String = " "
        For Each row As DataRow In DTAssy.Rows
            Dim fldAssyNo As New GridViewTextBoxColumn
            fldAssyNo.HeaderText = row.Item("fldPartName").ToString
            fldAssyNo.FieldName = row.Item("fldPartName").ToString
            fldAssyNo.TextAlignment = ContentAlignment.MiddleCenter
            fldAssyNo.Width = 350
            gvDataLotNo.Columns.Add(fldAssyNo)

            Dim fldCavNo As New GridViewTextBoxColumn
            fldCavNo.HeaderText = "Cav. No." & CavSpace
            fldCavNo.FieldName = "Cav. No." & CavSpace
            fldCavNo.TextAlignment = ContentAlignment.MiddleCenter
            fldCavNo.Width = 100
            gvDataLotNo.Columns.Add(fldCavNo)
            CavSpace = CavSpace & " "
        Next
    End Sub

    Private Sub ReloadForm()
        Me.Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub refreshGridview()

        gvDataManpower.DataSource = Nothing
        gvDataHourly.DataSource = Nothing
        gvDataSRCAssy.DataSource = Nothing
        gvDataA.DataSource = Nothing
        gvDataB.DataSource = Nothing
        gvDataC.DataSource = Nothing
        gvDataD.DataSource = Nothing
        gvDataLotNo.DataSource = Nothing

        gvDataManpower.Columns.Clear()
        gvDataHourly.Columns.Clear()
        gvDataSRCAssy.Columns.Clear()
        gvDataA.Columns.Clear()
        gvDataB.Columns.Clear()
        gvDataC.Columns.Clear()
        gvDataD.Columns.Clear()
        gvDataLotNo.Columns.Clear()

        If ExcelManpower IsNot Nothing Then

            ExcelManpower.Rows.Clear()
            ExcelManpower.Columns.Clear()
        End If
        If ExcelHourly IsNot Nothing Then

            ExcelHourly.Rows.Clear()
            ExcelHourly.Columns.Clear()

        End If
        If ExcelSRCAssy IsNot Nothing Then

            ExcelSRCAssy.Rows.Clear()
            ExcelSRCAssy.Columns.Clear()

        End If
        If ExcelDefectsA IsNot Nothing Then

            ExcelDefectsA.Rows.Clear()
            ExcelDefectsA.Columns.Clear()

        End If
        If ExcelDefectsB IsNot Nothing Then

            ExcelDefectsB.Rows.Clear()
            ExcelDefectsB.Columns.Clear()

        End If
        If ExcelDefectsC IsNot Nothing Then

            ExcelDefectsC.Rows.Clear()
            ExcelDefectsC.Columns.Clear()

        End If
        If ExcelDefectsD IsNot Nothing Then

            ExcelDefectsD.Rows.Clear()
            ExcelDefectsD.Columns.Clear()

        End If
        If ExcelLotNo IsNot Nothing Then

            ExcelLotNo.Rows.Clear()
            ExcelLotNo.Columns.Clear()

        End If

    End Sub

    Private Sub cbbOpen_Click(sender As Object, e As EventArgs) Handles cbbOpen.Click

        OpenFileDialog.ShowDialog()

        If OpenFileDialog.FileName = "" Or OpenFileDialog.FileName = "OpenFileDialog1" Then

        Else
            refreshGridview()
            'ExcelManpower = globalVariables.BlankDTSRC
            'ExcelHourly = globalVariables.BlankDTSRC
            'ExcelSRCAssy = globalVariables.BlankDTSRC
            'ExcelDefectsA = globalVariables.BlankDTSRC
            'ExcelDefectsB = globalVariables.BlankDTSRC
            'ExcelDefectsC = globalVariables.BlankDTSRC
            'ExcelDefectsD = globalVariables.BlankDTSRC
            'ExcelLotNo = globalVariables.BlankDTSRC

            'dtManpower = globalVariables.GlobaldtManpower
            'dtHourly = globalVariables.GlobaldtHourly
            'dtSRCAssy = globalVariables.GlobaldtSRCAssy
            'dtDefects = globalVariables.GlobaldtDefects
            'dtLotNo = globalVariables.GlobaldtLotNo

            Dim FilePath As String = OpenFileDialog.FileName
            Dim path As String = Environment.CurrentDirectory + "\Ephemeral\Dupe.xlsx"
            My.Computer.FileSystem.CopyFile(FilePath, Environment.CurrentDirectory + "\Ephemeral\Dupe.xlsx", overwrite:=True)

            '---------------Excel to Datatable

            Try
                Using con As OleDb.OleDbConnection = New OleDb.OleDbConnection()

                    con.ConnectionString = String.Format("Provider={0};Data Source={1};Extended Properties=""Excel 12.0 XML;HDR=Yes;""", "Microsoft.ACE.OLEDB.12.0", path)

                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [MANPOWER$]", con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            dtManpower.Clear()
                            con.Open()
                            da.Fill(dtManpower)
                            con.Close()
                        End Using
                    End Using

                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [HOURLY QUALITY$]", con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            dtHourly.Clear()
                            con.Open()
                            da.Fill(dtHourly)
                            con.Close()
                        End Using
                    End Using

                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [SRC ASSEMBLY$]", con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            dtSRCAssy.Clear()
                            con.Open()
                            da.Fill(dtSRCAssy)
                            con.Close()
                        End Using
                    End Using

                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [IN PROCESS DEFECTS$]", con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            dtDefects.Clear()
                            con.Open()
                            da.Fill(dtDefects)
                            con.Close()
                        End Using
                    End Using

                    Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [RM WIP LOT NO$]", con)
                        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            dtLotNo.Clear()
                            con.Open()
                            da.Fill(dtLotNo)
                            con.Close()
                        End Using
                    End Using

                End Using
            Catch ex As Exception

            End Try
            cbbOpen.Enabled = False
            cbbSave.Enabled = False
            pbOwO.Text = "Uploading Template"
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim OpenProgress As Integer = 0
            Dim percent As Integer = OpenProgress

            '---------- Col Manpower
            GridColManpower()
            ExcelManpower.Columns.Add("fldProcessName")
            ExcelManpower.Columns.Add("fldEmployee")
            ExcelManpower.Columns.Add("fldQualified")
            ExcelManpower.Columns.Add("fldTransferred")
            ExcelManpower.Columns.Add("fldTrainee")
            Threading.Thread.Sleep(80)
            OpenProgress = OpenProgress + 10
            percent = OpenProgress
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            '---------- Col Hourly
            GridColHourly()
            ExcelHourly.Columns.Add("fldTime")
            ExcelHourly.Columns.Add("fldCableG")
            ExcelHourly.Columns.Add("fldStatorG")
            ExcelHourly.Columns.Add("fldFinalProdCheck")
            ExcelHourly.Columns.Add("fldRotator")
            ExcelHourly.Columns.Add("fldStator")
            ExcelHourly.Columns.Add("fldSubStator")
            ExcelHourly.Columns.Add("fldSleeve")
            ExcelHourly.Columns.Add("fldBarcode")
            ExcelHourly.Columns.Add("fldPlan")
            ExcelHourly.Columns.Add("fldActual")
            ExcelHourly.Columns.Add("fldElectrical")
            ExcelHourly.Columns.Add("fldFunction")
            ExcelHourly.Columns.Add("fldFinal")
            Threading.Thread.Sleep(80)
            OpenProgress = OpenProgress + 10
            percent = OpenProgress
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            '---------- Col SRC Assy
            GridColSRCAssy()
            ExcelSRCAssy.Columns.Add("fldPartNo")
            ExcelSRCAssy.Columns.Add("fldPartName")
            ExcelSRCAssy.Columns.Add("fldLotNo")
            ExcelSRCAssy.Columns.Add("fldScrapQty")
            ExcelSRCAssy.Columns.Add("fldPurgeQty")
            ExcelSRCAssy.Columns.Add("fldQASample")
            ExcelSRCAssy.Columns.Add("fldEngSample")
            Threading.Thread.Sleep(80)
            OpenProgress = OpenProgress + 10
            percent = OpenProgress
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            '---------- Col Factory Defects
            ReloadGridA()
            ExcelDefectsA.Columns.Add("fldDefCode")
            ExcelDefectsA.Columns.Add("fldPartName")
            ExcelDefectsA.Columns.Add("fldMan")
            ExcelDefectsA.Columns.Add("fldMachine")
            ExcelDefectsA.Columns.Add("fldIM")
            ExcelDefectsA.Columns.Add("fldFFC")
            ExcelDefectsA.Columns.Add("fldSubAssy")
            ExcelDefectsA.Columns.Add("fldRM")
            ReloadGridB()
            ExcelDefectsB.Columns.Add("fldDefCode")
            ExcelDefectsB.Columns.Add("fldPartName")
            ExcelDefectsB.Columns.Add("fldMan")
            ExcelDefectsB.Columns.Add("fldMachine")
            ExcelDefectsB.Columns.Add("fldIM")
            ExcelDefectsB.Columns.Add("fldFFC")
            ExcelDefectsB.Columns.Add("fldSubAssy")
            ExcelDefectsB.Columns.Add("fldRM")
            ReloadGridC()
            ExcelDefectsC.Columns.Add("fldDefCode")
            ExcelDefectsC.Columns.Add("fldPartName")
            ExcelDefectsC.Columns.Add("fldMan")
            ExcelDefectsC.Columns.Add("fldMachine")
            ExcelDefectsC.Columns.Add("fldIM")
            ExcelDefectsC.Columns.Add("fldFFC")
            ExcelDefectsC.Columns.Add("fldSubAssy")
            ExcelDefectsC.Columns.Add("fldRM")
            ReloadGridD()
            ExcelDefectsD.Columns.Add("fldDefCode")
            ExcelDefectsD.Columns.Add("fldPartName")
            ExcelDefectsD.Columns.Add("fldMan")
            ExcelDefectsD.Columns.Add("fldMachine")
            ExcelDefectsD.Columns.Add("fldIM")
            ExcelDefectsD.Columns.Add("fldFFC")
            ExcelDefectsD.Columns.Add("fldSubAssy")
            ExcelDefectsD.Columns.Add("fldRM")
            Threading.Thread.Sleep(80)
            OpenProgress = OpenProgress + 10
            percent = OpenProgress
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            '---------- Col Factory Defects
            ReloadGrid()
            ExcelLotNo.Columns.Add("Time")
            ExcelLotNo.Columns.Add("Box/Cart No.")
            Dim DTAssy As DataTable = Maria.MyQuery("SELECT fldPartName FROM tblDailyReportSRCRawMatsTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLine & "")
            Dim CavSpace As String = " "
            For Each row As DataRow In DTAssy.Rows
                ExcelLotNo.Columns.Add(row.Item("fldPartName").ToString)
                ExcelLotNo.Columns.Add("Cav. No." & CavSpace)
                CavSpace = CavSpace & " "
            Next
            Threading.Thread.Sleep(80)
            OpenProgress = OpenProgress + 10
            percent = OpenProgress
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            '-------------------------------------- Load ---------------------------------

            For Each dr As DataRow In dtManpower.Rows

                Try

                    ExcelManpower.Rows.Add(dr.ItemArray)
                Catch ex As Exception
                    MessageBox.Show("Kindly check Manpower")
                End Try
            Next
            Threading.Thread.Sleep(80)
            OpenProgress = OpenProgress + 10
            percent = OpenProgress
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))


            For Each dr As DataRow In dtHourly.Rows

                Try
                    ExcelHourly.Rows.Add(dr.ItemArray)
                Catch ex As Exception
                    MessageBox.Show("Kindly check Hourly")
                End Try

            Next
            Threading.Thread.Sleep(80)
            OpenProgress = OpenProgress + 10
            percent = OpenProgress
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))

            For Each dr As DataRow In dtSRCAssy.Rows

                Try
                    ExcelSRCAssy.Rows.Add(dr.ItemArray)
                Catch ex As Exception
                    MessageBox.Show("Kindly check SRC Assy")
                End Try

            Next

            Threading.Thread.Sleep(80)
            OpenProgress = OpenProgress + 10
            percent = OpenProgress
            BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            Try
                Dim CheckColDefects As String = ""
                For Each dr As DataRow In dtDefects.Rows

                    If dr.Item(0).ToString.Trim = "" Then

                    Else

                        CheckColDefects = dr.Item(0).ToString

                    End If

                    If CheckColDefects = "A. Function Tester" Then

                        If dr.Item(1).ToString.Trim = "" Or dr.Item(1).ToString.Trim Is Nothing Then

                        Else

                            Dim fldDefCode As String = dr.Item(1).ToString
                            Dim fldPartName As String = dr.Item(2).ToString
                            Dim fldMan As String = dr.Item(3).ToString
                            Dim fldMachine As String = dr.Item(4).ToString
                            Dim fldIM As String = dr.Item(5).ToString
                            Dim fldFFC As String = dr.Item(6).ToString
                            Dim fldSubAssy As String = dr.Item(7).ToString
                            Dim fldRM As String = dr.Item(8).ToString

                            ExcelDefectsA.Rows.Add(fldDefCode, fldPartName, fldMan, fldMachine, fldIM, fldFFC, fldSubAssy, fldRM)

                        End If

                    ElseIf CheckColDefects = "B. Electrical Tester" Or dr.Item(1).ToString.Trim Is Nothing Then

                        If dr.Item(1).ToString.Trim = "" Then
                        Else

                            Dim fldDefCode As String = dr.Item(1).ToString
                            Dim fldPartName As String = dr.Item(2).ToString
                            Dim fldMan As String = dr.Item(3).ToString
                            Dim fldMachine As String = dr.Item(4).ToString
                            Dim fldIM As String = dr.Item(5).ToString
                            Dim fldFFC As String = dr.Item(6).ToString
                            Dim fldSubAssy As String = dr.Item(7).ToString
                            Dim fldRM As String = dr.Item(8).ToString

                            ExcelDefectsB.Rows.Add(fldDefCode, fldPartName, fldMan, fldMachine, fldIM, fldFFC, fldSubAssy, fldRM)
                        End If

                    ElseIf CheckColDefects = "C. Final Tester" Then

                        If dr.Item(1).ToString.Trim = "" Or dr.Item(1).ToString.Trim Is Nothing Then
                        Else

                            Dim fldDefCode As String = dr.Item(1).ToString
                            Dim fldPartName As String = dr.Item(2).ToString
                            Dim fldMan As String = dr.Item(3).ToString
                            Dim fldMachine As String = dr.Item(4).ToString
                            Dim fldIM As String = dr.Item(5).ToString
                            Dim fldFFC As String = dr.Item(6).ToString
                            Dim fldSubAssy As String = dr.Item(7).ToString
                            Dim fldRM As String = dr.Item(8).ToString

                            ExcelDefectsC.Rows.Add(fldDefCode, fldPartName, fldMan, fldMachine, fldIM, fldFFC, fldSubAssy, fldRM)
                        End If

                    ElseIf CheckColDefects = "D. Others" Then

                        If dr.Item(1).ToString.Trim = "" Or dr.Item(1).ToString.Trim Is Nothing Then
                        Else

                            Dim fldDefCode As String = dr.Item(1).ToString
                            Dim fldPartName As String = dr.Item(2).ToString
                            Dim fldMan As String = dr.Item(3).ToString
                            Dim fldMachine As String = dr.Item(4).ToString
                            Dim fldIM As String = dr.Item(5).ToString
                            Dim fldFFC As String = dr.Item(6).ToString
                            Dim fldSubAssy As String = dr.Item(7).ToString
                            Dim fldRM As String = dr.Item(8).ToString

                            ExcelDefectsD.Rows.Add(fldDefCode, fldPartName, fldMan, fldMachine, fldIM, fldFFC, fldSubAssy, fldRM)

                        End If

                    End If

                Next
            Catch
                MessageBox.Show("Kindly check Defects")
            End Try

            Threading.Thread.Sleep(80)
                OpenProgress = OpenProgress + 10
                percent = OpenProgress
                BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            Try
                For Each LotNoRow As DataRow In dtLotNo.Rows

                    Dim RowTime As String = LotNoRow.Item(0).ToString
                    Dim RowBoxNo As String = LotNoRow.Item(1).ToString

                    Dim ArrayOwO(dtLotNo.Columns.Count - 1) As String
                    ArrayOwO(0) = RowTime
                    ArrayOwO(1) = RowBoxNo
                    Dim i As Integer = 2

                    While i < dtLotNo.Columns.Count - 1
                        ArrayOwO(i) = LotNoRow.Item(i).ToString
                        ArrayOwO(i + 1) = LotNoRow.Item(i + 1).ToString
                        i = i + 2
                    End While
                    ExcelLotNo.Rows.Add(ArrayOwO)
                Next
            Catch
                MessageBox.Show("Kindly check Lot No")
            End Try

            Threading.Thread.Sleep(80)
                OpenProgress = OpenProgress + 10
                percent = OpenProgress
                BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        pbOwO.Value1 = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        gvDataManpower.DataSource = ExcelManpower
        gvDataHourly.DataSource = ExcelHourly
        gvDataSRCAssy.DataSource = ExcelSRCAssy
        gvDataA.DataSource = ExcelDefectsA
        gvDataB.DataSource = ExcelDefectsB
        gvDataC.DataSource = ExcelDefectsC
        gvDataD.DataSource = ExcelDefectsD
        gvDataLotNo.DataSource = ExcelLotNo
        cbbOpen.Enabled = True
        cbbSave.Enabled = True

        pbOwO.Text = "Uploading Template Done"

        'FrmTestDataTable.ShowDialog(Me)
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        Dim result As Integer = RadMessageBox.Show("Are you sure you want to save?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            cbbOpen.Enabled = False
            cbbSave.Enabled = False
            BackgroundWorker2.RunWorkerAsync()
        End If


    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        '---------- Manpower ---------
        'rowIndex = 0
        Dim checkexistManpower As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCManpower where fldDRID=" & globalVariables.DailyRepID & "")
        If checkexistManpower.Rows.Count >= 1 Then
            Maria.MyQuery(" SET SQL_SAFE_UPDATES = 0; Delete from tblDailyReportSRCManpower where fldDRID=" & globalVariables.DailyRepID & ";SET SQL_SAFE_UPDATES = 1;")
        End If
        For rowcounter As Integer = 0 To Me.gvDataManpower.Rows.Count - 1
            Try
                Dim DRID As Integer = globalVariables.DailyRepID
                Dim ProcessName As String = gvDataManpower.Rows(rowcounter).Cells("fldProcessName").Value.ToString
                Dim Employee As String = If(IsDBNull(gvDataManpower.Rows(rowcounter).Cells("fldEmployee").Value), "", DirectCast(gvDataManpower.Rows(rowcounter).Cells("fldEmployee").Value, String))
                Dim Qualified As Boolean = gvDataManpower.Rows(rowcounter).Cells("fldQualified").Value
                Dim Transferred As Boolean = gvDataManpower.Rows(rowcounter).Cells("fldTransferred").Value
                Dim Trainee As Boolean = gvDataManpower.Rows(rowcounter).Cells("fldTrainee").Value
                Dim CurrUser As String = globalVariables.currentUser(1)

                Maria.AddMySqlParameters("parDRID", DRID)
                Maria.AddMySqlParameters("parProcName", ProcessName)
                Maria.AddMySqlParameters("parEmp", Employee)
                Maria.AddMySqlParameters("parQualified", Qualified)
                Maria.AddMySqlParameters("parTrans", Transferred)
                Maria.AddMySqlParameters("parTrain", Trainee)
                Maria.AddMySqlParameters("parUser", CurrUser)
                Maria.SPADE("SP_SRC_InsertManpowerData")

                Threading.Thread.Sleep(60)
                CurrentProg = "Saving Manpower"
                Dim RowCount As Integer = gvDataManpower.Rows.Count
                Dim percent As Double = (rowcounter / RowCount * 100)
                BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
            Catch ex As Exception
                Maria.Connection.Close()
                RadMessageBox.Show(ex.Message)
            End Try
        Next
        '---------- Hourly ---------
        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete from tblDailyReportSRCHourlyQuality where fldDRID=" & globalVariables.DailyRepID & "; SET SQL_SAFE_UPDATES = 1;")
        For rowcounter As Integer = 0 To Me.gvDataHourly.Rows.Count - 1
            Try
                Dim parDRID As Integer = globalVariables.DailyRepID
                Dim parTime As String = gvDataHourly.Rows(rowcounter).Cells("fldTime").Value.ToString
                Dim parCableG As Boolean = gvDataHourly.Rows(rowcounter).Cells("fldCableG").Value
                Dim parStatorG As Boolean = gvDataHourly.Rows(rowcounter).Cells("fldStatorG").Value
                Dim parFinalProdCheck As Boolean = gvDataHourly.Rows(rowcounter).Cells("fldFinalProdCheck").Value
                Dim parRotator As String = gvDataHourly.Rows(rowcounter).Cells("fldRotator").Value.ToString
                Dim parStator As String = gvDataHourly.Rows(rowcounter).Cells("fldStator").Value.ToString
                Dim parSubStator As String = gvDataHourly.Rows(rowcounter).Cells("fldSubStator").Value.ToString
                Dim parSleeve As String = gvDataHourly.Rows(rowcounter).Cells("fldSleeve").Value.ToString
                Dim parBarcode As String = If(IsDBNull(gvDataHourly.Rows(rowcounter).Cells("fldBarcode").Value), "", gvDataHourly.Rows(rowcounter).Cells("fldBarcode").Value.ToString)
                Dim parPlan As Integer = gvDataHourly.Rows(rowcounter).Cells("fldPlan").Value
                Dim parActual As Integer = gvDataHourly.Rows(rowcounter).Cells("fldActual").Value
                Dim parDeviation As Integer = gvDataHourly.Rows(rowcounter).Cells("fldPlan").Value - gvDataHourly.Rows(rowcounter).Cells("fldActual").Value
                Dim parElectrical As String = gvDataHourly.Rows(rowcounter).Cells("fldElectrical").Value.ToString
                Dim parFunction As String = gvDataHourly.Rows(rowcounter).Cells("fldFunction").Value.ToString
                Dim parFinal As String = gvDataHourly.Rows(rowcounter).Cells("fldFinal").Value.ToString
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
                CurrentProg = "Saving Hourly Quality"
                Dim RowCount As Integer = gvDataHourly.Rows.Count
                Dim percent As Double = (rowcounter / RowCount * 100)
                BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
            Catch ex As Exception
                Maria.Connection.Close()
                RadMessageBox.Show(ex.Message)
            End Try
        Next
        '---------- SRC Assy ---------
        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete from tblDailyReportSRCAssy where fldDRID=" & globalVariables.DailyRepID & "; SET SQL_SAFE_UPDATES = 1;")
        For rowcounter As Integer = 0 To Me.gvDataSRCAssy.Rows.Count - 1

            Try

                Dim parDRID As Integer = globalVariables.DailyRepID
                Dim parPartNo As String = gvDataSRCAssy.Rows(rowcounter).Cells("fldPartNo").Value.ToString
                Dim parPartName As String = gvDataSRCAssy.Rows(rowcounter).Cells("fldPartName").Value.ToString
                Dim parLotNo As String = If(IsDBNull(gvDataSRCAssy.Rows(rowcounter).Cells("fldLotNo").Value), "", DirectCast(gvDataSRCAssy.Rows(rowcounter).Cells("fldLotNo").Value, String))
                Dim parScrapQty As String = If(IsDBNull(gvDataSRCAssy.Rows(rowcounter).Cells("fldScrapQty").Value), "", DirectCast(gvDataSRCAssy.Rows(rowcounter).Cells("fldScrapQty").Value, String))
                Dim parPurgeQty As String = If(IsDBNull(gvDataSRCAssy.Rows(rowcounter).Cells("fldPurgeQty").Value), "", DirectCast(gvDataSRCAssy.Rows(rowcounter).Cells("fldPurgeQty").Value, String))
                Dim parQASample As String = If(IsDBNull(gvDataSRCAssy.Rows(rowcounter).Cells("fldQASample").Value), "", DirectCast(gvDataSRCAssy.Rows(rowcounter).Cells("fldQASample").Value, String))
                Dim parEngSample As String = If(IsDBNull(gvDataSRCAssy.Rows(rowcounter).Cells("fldEngSample").Value), "", DirectCast(gvDataSRCAssy.Rows(rowcounter).Cells("fldEngSample").Value, String))
                Dim parAddedBy As String = globalVariables.currentUser(1)

                Maria.AddMySqlParameters("parDRID", parDRID)
                Maria.AddMySqlParameters("parPartNo", parPartNo)
                Maria.AddMySqlParameters("parPartName", parPartName)
                Maria.AddMySqlParameters("parLotNo", parLotNo)
                Maria.AddMySqlParameters("parScrapQty", parScrapQty)
                Maria.AddMySqlParameters("parPurgeQty", parPurgeQty)
                Maria.AddMySqlParameters("parQASample", parQASample)
                Maria.AddMySqlParameters("parEngSample", parEngSample)
                Maria.AddMySqlParameters("parAddedBy", parAddedBy)
                Maria.SPADE("SP_SRC_InsertSRCAssy")

                Threading.Thread.Sleep(60)
                CurrentProg = "Saving SRC Assy"
                Dim RowCount As Integer = gvDataSRCAssy.Rows.Count
                Dim percent As Double = (rowcounter / RowCount * 100)
                BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
            Catch ex As Exception
                Maria.Connection.Close()
                RadMessageBox.Show(ex.Message)
            End Try

        Next

        '---------- In Proc Defects ---------
        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete From tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & "; SET SQL_SAFE_UPDATES = 1;")
        For ascii = 65 To 68

            If Chr(ascii) = "A" Then
                For rowcounter As Integer = 0 To Me.gvDataA.Rows.Count - 1
                    Try
                        Dim parDRID As Integer = globalVariables.DailyRepID
                        Dim parDefCode As String = If(gvDataA.Rows(rowcounter).Cells("fldDefCode").Value Is Nothing, "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldDefCode").Value, String))
                        Dim parPartName As String = If(gvDataA.Rows(rowcounter).Cells("fldPartName").Value Is Nothing, "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldPartName").Value, String))
                        Dim parMan As String = If(gvDataA.Rows(rowcounter).Cells("fldMan").Value Is Nothing, "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldMan").Value, String))
                        Dim parMachine As String = If(gvDataA.Rows(rowcounter).Cells("fldMachine").Value Is Nothing, "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldMachine").Value, String))
                        Dim parIM As String = If(gvDataA.Rows(rowcounter).Cells("fldIM").Value Is Nothing, "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldIM").Value, String))
                        Dim parFFC As String = If(gvDataA.Rows(rowcounter).Cells("fldFFC").Value Is Nothing, "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldFFC").Value, String))
                        Dim parSubAssy As String = If(gvDataA.Rows(rowcounter).Cells("fldSubAssy").Value Is Nothing, "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldSubAssy").Value, String))
                        Dim parRM As String = If(gvDataA.Rows(rowcounter).Cells("fldRM").Value Is Nothing, "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldRM").Value, String))
                        Dim parCateg As String = Chr(ascii)
                        Dim parAddedBy As String = globalVariables.currentUser(1)

                        Maria.AddMySqlParameters("parDRID", parDRID)
                        Maria.AddMySqlParameters("parDefCode", parDefCode)
                        Maria.AddMySqlParameters("parPartName", parPartName)
                        Maria.AddMySqlParameters("parMan", parMan)
                        Maria.AddMySqlParameters("parMachine", parMachine)
                        Maria.AddMySqlParameters("parIM", parIM)
                        Maria.AddMySqlParameters("parFFC", parFFC)
                        Maria.AddMySqlParameters("parSubAssy", parSubAssy)
                        Maria.AddMySqlParameters("parRM", parRM)
                        Maria.AddMySqlParameters("parCateg", parCateg)
                        Maria.AddMySqlParameters("parAddedBy", parAddedBy)
                        Maria.SPADE("SP_SRC_InsertSRCInProcDefect")

                        Threading.Thread.Sleep(60)
                        CurrentProg = "Saving In Process Defects"
                        Dim RowCount As Integer = gvDataA.Rows.Count
                        Dim percent As Double = (rowcounter / RowCount * 100)
                        BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
                    Catch ex As Exception
                        Maria.Connection.Close()
                        RadMessageBox.Show(ex.Message)
                    End Try

                Next
            ElseIf Chr(ascii) = "B" Then
                For rowcounter As Integer = 0 To Me.gvDataB.Rows.Count - 1
                    Try
                        Dim parDRID As Integer = globalVariables.DailyRepID
                        Dim parDefCode As String = If(gvDataB.Rows(rowcounter).Cells("fldDefCode").Value Is Nothing, "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldDefCode").Value, String))
                        Dim parPartName As String = If(gvDataB.Rows(rowcounter).Cells("fldPartName").Value Is Nothing, "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldPartName").Value, String))
                        Dim parMan As String = If(gvDataB.Rows(rowcounter).Cells("fldMan").Value Is Nothing, "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldMan").Value, String))
                        Dim parMachine As String = If(gvDataB.Rows(rowcounter).Cells("fldMachine").Value Is Nothing, "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldMachine").Value, String))
                        Dim parIM As String = If(gvDataB.Rows(rowcounter).Cells("fldIM").Value Is Nothing, "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldIM").Value, String))
                        Dim parFFC As String = If(gvDataB.Rows(rowcounter).Cells("fldFFC").Value Is Nothing, "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldFFC").Value, String))
                        Dim parSubAssy As String = If(gvDataB.Rows(rowcounter).Cells("fldSubAssy").Value Is Nothing, "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldSubAssy").Value, String))
                        Dim parRM As String = If(gvDataB.Rows(rowcounter).Cells("fldRM").Value Is Nothing, "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldRM").Value, String))
                        Dim parCateg As String = Chr(ascii)
                        Dim parAddedBy As String = globalVariables.currentUser(1)

                        Maria.AddMySqlParameters("parDRID", parDRID)
                        Maria.AddMySqlParameters("parDefCode", parDefCode)
                        Maria.AddMySqlParameters("parPartName", parPartName)
                        Maria.AddMySqlParameters("parMan", parMan)
                        Maria.AddMySqlParameters("parMachine", parMachine)
                        Maria.AddMySqlParameters("parIM", parIM)
                        Maria.AddMySqlParameters("parFFC", parFFC)
                        Maria.AddMySqlParameters("parSubAssy", parSubAssy)
                        Maria.AddMySqlParameters("parRM", parRM)
                        Maria.AddMySqlParameters("parCateg", parCateg)
                        Maria.AddMySqlParameters("parAddedBy", parAddedBy)
                        Maria.SPADE("SP_SRC_InsertSRCInProcDefect")

                        Threading.Thread.Sleep(60)
                        CurrentProg = "Saving In Process Defects"
                        Dim RowCount As Integer = gvDataB.Rows.Count
                        Dim percent As Double = (rowcounter / RowCount * 100)
                        BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
                    Catch ex As Exception
                        Maria.Connection.Close()
                        RadMessageBox.Show(ex.Message)
                    End Try


                Next
            ElseIf Chr(ascii) = "C" Then
                For rowcounter As Integer = 0 To Me.gvDataC.Rows.Count - 1
                    Try
                        Dim parDRID As Integer = globalVariables.DailyRepID
                        Dim parDefCode As String = If(gvDataC.Rows(rowcounter).Cells("fldDefCode").Value Is Nothing, "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldDefCode").Value, String))
                        Dim parPartName As String = If(gvDataC.Rows(rowcounter).Cells("fldPartName").Value Is Nothing, "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldPartName").Value, String))
                        Dim parMan As String = If(gvDataC.Rows(rowcounter).Cells("fldMan").Value Is Nothing, "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldMan").Value, String))
                        Dim parMachine As String = If(gvDataC.Rows(rowcounter).Cells("fldMachine").Value Is Nothing, "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldMachine").Value, String))
                        Dim parIM As String = If(gvDataC.Rows(rowcounter).Cells("fldIM").Value Is Nothing, "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldIM").Value, String))
                        Dim parFFC As String = If(gvDataC.Rows(rowcounter).Cells("fldFFC").Value Is Nothing, "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldFFC").Value, String))
                        Dim parSubAssy As String = If(gvDataC.Rows(rowcounter).Cells("fldSubAssy").Value Is Nothing, "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldSubAssy").Value, String))
                        Dim parRM As String = If(gvDataC.Rows(rowcounter).Cells("fldRM").Value Is Nothing, "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldRM").Value, String))
                        Dim parCateg As String = Chr(ascii)
                        Dim parAddedBy As String = globalVariables.currentUser(1)

                        Maria.AddMySqlParameters("parDRID", parDRID)
                        Maria.AddMySqlParameters("parDefCode", parDefCode)
                        Maria.AddMySqlParameters("parPartName", parPartName)
                        Maria.AddMySqlParameters("parMan", parMan)
                        Maria.AddMySqlParameters("parMachine", parMachine)
                        Maria.AddMySqlParameters("parIM", parIM)
                        Maria.AddMySqlParameters("parFFC", parFFC)
                        Maria.AddMySqlParameters("parSubAssy", parSubAssy)
                        Maria.AddMySqlParameters("parRM", parRM)
                        Maria.AddMySqlParameters("parCateg", parCateg)
                        Maria.AddMySqlParameters("parAddedBy", parAddedBy)
                        Maria.SPADE("SP_SRC_InsertSRCInProcDefect")

                        Threading.Thread.Sleep(60)
                        CurrentProg = "Saving In Process Defects"
                        Dim RowCount As Integer = gvDataC.Rows.Count
                        Dim percent As Double = (rowcounter / RowCount * 100)
                        BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
                    Catch ex As Exception
                        Maria.Connection.Close()
                        RadMessageBox.Show(ex.Message)
                    End Try


                Next
            ElseIf Chr(ascii) = "D" Then
                For rowcounter As Integer = 0 To Me.gvDataD.Rows.Count - 1

                    Try

                        Dim parDRID As Integer = globalVariables.DailyRepID
                        Dim parDefCode As String = If(gvDataD.Rows(rowcounter).Cells("fldDefCode").Value Is Nothing, "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldDefCode").Value, String))
                        Dim parPartName As String = If(gvDataD.Rows(rowcounter).Cells("fldPartName").Value Is Nothing, "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldPartName").Value, String))
                        Dim parMan As String = If(gvDataD.Rows(rowcounter).Cells("fldMan").Value Is Nothing, "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldMan").Value, String))
                        Dim parMachine As String = If(gvDataD.Rows(rowcounter).Cells("fldMachine").Value Is Nothing, "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldMachine").Value, String))
                        Dim parIM As String = If(gvDataD.Rows(rowcounter).Cells("fldIM").Value Is Nothing, "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldIM").Value, String))
                        Dim parFFC As String = If(gvDataD.Rows(rowcounter).Cells("fldFFC").Value Is Nothing, "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldFFC").Value, String))
                        Dim parSubAssy As String = If(gvDataD.Rows(rowcounter).Cells("fldSubAssy").Value Is Nothing, "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldSubAssy").Value, String))
                        Dim parRM As String = If(gvDataD.Rows(rowcounter).Cells("fldRM").Value Is Nothing, "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldRM").Value, String))
                        Dim parCateg As String = Chr(ascii)
                        Dim parAddedBy As String = globalVariables.currentUser(1)

                        Maria.AddMySqlParameters("parDRID", parDRID)
                        Maria.AddMySqlParameters("parDefCode", parDefCode)
                        Maria.AddMySqlParameters("parPartName", parPartName)
                        Maria.AddMySqlParameters("parMan", parMan)
                        Maria.AddMySqlParameters("parMachine", parMachine)
                        Maria.AddMySqlParameters("parIM", parIM)
                        Maria.AddMySqlParameters("parFFC", parFFC)
                        Maria.AddMySqlParameters("parSubAssy", parSubAssy)
                        Maria.AddMySqlParameters("parRM", parRM)
                        Maria.AddMySqlParameters("parCateg", parCateg)
                        Maria.AddMySqlParameters("parAddedBy", parAddedBy)
                        Maria.SPADE("SP_SRC_InsertSRCInProcDefect")

                        Threading.Thread.Sleep(60)
                        CurrentProg = "Saving In Process Defects"
                        Dim RowCount As Integer = gvDataD.Rows.Count
                        Dim percent As Double = (rowcounter / RowCount * 100)
                        BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
                    Catch ex As Exception
                        Maria.Connection.Close()
                        RadMessageBox.Show(ex.Message)
                    End Try

                Next

            End If

        Next

        '---------- Lot No ---------
        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; DELETE FROM tblDailyReportSRCRMWIP where fldDRID=" & globalVariables.DailyRepID & ";SET SQL_SAFE_UPDATES = 1;")
        For rowcounter As Integer = 0 To Me.gvDataLotNo.Rows.Count - 1

            Dim parTime As String = gvDataLotNo.Rows(rowcounter).Cells("Time").Value.ToString
            Dim parBoxNo As String = If(gvDataLotNo.Rows(rowcounter).Cells("Box/Cart No.").Value Is Nothing, "", gvDataLotNo.Rows(rowcounter).Cells("Box/Cart No.").Value.ToString)

            For colcounter As Integer = 2 To Me.gvDataLotNo.Columns.Count - 1 Step 2

                Try
                    Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                    Maria.AddMySqlParameters("parTime", parTime)
                    Maria.AddMySqlParameters("parBoxNo", parBoxNo)
                    Maria.AddMySqlParameters("parPartName", gvDataLotNo.Columns(colcounter).FieldName)
                    Maria.AddMySqlParameters("parLotNo", If(gvDataLotNo.Rows(rowcounter).Cells(colcounter).Value Is Nothing, "", gvDataLotNo.Rows(rowcounter).Cells(colcounter).Value.ToString))
                    Maria.AddMySqlParameters("parCavNo", If(gvDataLotNo.Rows(rowcounter).Cells(colcounter + 1).Value Is Nothing, 0, gvDataLotNo.Rows(rowcounter).Cells(colcounter + 1).Value))
                    Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                    Maria.SPADE("SP_SRCDailyReport_InsertRMWIP")
                Catch ex As Exception
                    Maria.Connection.Close()
                    RadMessageBox.Show(ex.Message)
                End Try

            Next
            Threading.Thread.Sleep(60)
            CurrentProg = "Saving In Lot No."
            Dim RowCount As Integer = gvDataLotNo.Rows.Count
            Dim percent As Double = (rowcounter / RowCount * 100)
            BackgroundWorker2.ReportProgress(Convert.ToInt32(percent))
        Next

    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        pbOwO.Text = CurrentProg
        pbOwO.Value1 = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        pbOwO.Value1 = 100
        pbOwO.Text = "Upload Done!"

        cbbOpen.Enabled = True
        cbbSave.Enabled = True

    End Sub

    Private Sub FrmSRCAssyUpload_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Try
        '    gvDataManpower.DataSource = Nothing
        '    gvDataHourly.DataSource = Nothing
        '    gvDataSRCAssy.DataSource = Nothing
        '    gvDataA.DataSource = Nothing
        '    gvDataB.DataSource = Nothing
        '    gvDataC.DataSource = Nothing
        '    gvDataD.DataSource = Nothing
        '    gvDataLotNo.DataSource = Nothing

        '    gvDataManpower.Columns.Clear()
        '    gvDataHourly.Columns.Clear()
        '    gvDataSRCAssy.Columns.Clear()
        '    gvDataA.Columns.Clear()
        '    gvDataB.Columns.Clear()
        '    gvDataC.Columns.Clear()
        '    gvDataD.Columns.Clear()
        '    gvDataLotNo.Columns.Clear()

        '    ExcelManpower.Columns.Clear()
        '    ExcelHourly.Columns.Clear()
        '    ExcelSRCAssy.Columns.Clear()
        '    ExcelDefectsA.Columns.Clear()
        '    ExcelDefectsB.Columns.Clear()
        '    ExcelDefectsC.Columns.Clear()
        '    ExcelDefectsD.Columns.Clear()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


    End Sub
End Class
