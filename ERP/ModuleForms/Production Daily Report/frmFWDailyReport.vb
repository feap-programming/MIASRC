Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports ClosedXML.Excel
Imports System.ComponentModel
Imports System.Xml
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports DocumentFormat.OpenXml.Presentation
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx
Imports Telerik.Windows.Documents.Spreadsheet
Imports Telerik.Windows.Documents.Spreadsheet.Model

Public Class FrmFWPWDailyReport
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    'Dim Maria As New DB("localhost", "dbmia", "root", "password")
    Dim TempGroupDT As New DataTable
    Dim GetWeldingNo As New DataTable
    Dim LotNoTemplate As New DataTable
    Dim GetSampleTemplate As New DataTable
    Private Sub FrmFWPWDailyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Slipknot.changeTheme(Me)
        GridCol()
        GetModels()
        RemoveHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged
        RemoveHandler ddType.SelectedIndexChanged, AddressOf ddType_SelectedIndexChanged
        ddModel.SelectedIndex = My.Settings.setSRCModel
        spnLine.Value = My.Settings.setSRCLine

        dpDate.Value = DateTime.Now


        TempGroupDT.Columns.Add("fldGroup")
        TempGroupDT.Columns.Add("fldWeldNo")
        AddHandler ddType.SelectedIndexChanged, AddressOf ddType_SelectedIndexChanged
        AddHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged


        ddType.SelectedIndex = If(Mio.WeldingType = "PW", 0, 1)
        If Mio.WeldingType = "PW" Then
            ddType.Enabled = False
            ddGroup.Enabled = False
        Else
            ddType.Enabled = False
            ddGroup.Enabled = True
        End If
        SelectType()
        ReloadGrid()
    End Sub
    Private Sub GetModels()

        Dim DTModel As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")

        ddModel.DataSource = DTModel
        ddModel.DisplayMember = "fldModelName"
        ddModel.ValueMember = "fldCode"
        ddModel.AutoCompleteDataSource = DTModel
        ddModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModel.AutoCompleteDisplayMember = "fldModelName"
        ddModel.AutoCompleteValueMember = "fldCode"
        ddModel.Text = ""

    End Sub
    Private Sub ReloadGrid()
        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportWelding where fldStatus='Active' and fldModel='" & ddModel.Text & "' and fldLine=" & spnLine.Value & " and fldType='" & ddType.Text & "' order by fldID desc")
    End Sub
    Private Sub GridCol()

        gvData.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        'fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "Model"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.Width = 150
        gvData.Columns.Add(fldModel)

        Dim fldCode As New GridViewTextBoxColumn
        fldCode.HeaderText = "Model Code"
        fldCode.FieldName = "fldCode"
        fldCode.TextAlignment = ContentAlignment.MiddleCenter
        fldCode.Width = 150
        fldCode.IsVisible = False
        gvData.Columns.Add(fldCode)

        Dim fldLineNo As New GridViewTextBoxColumn
        fldLineNo.HeaderText = "Line No"
        fldLineNo.FieldName = "fldLine"
        fldLineNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLineNo.Width = 80
        gvData.Columns.Add(fldLineNo)

        Dim fldDate As New GridViewTextBoxColumn
        fldDate.HeaderText = "Date"
        fldDate.FieldName = "fldDate"
        fldDate.FormatString = "{0:yyyy-MM-dd}"
        fldDate.TextAlignment = ContentAlignment.MiddleCenter
        fldDate.Width = 150
        gvData.Columns.Add(fldDate)

        Dim fldShift As New GridViewTextBoxColumn
        fldShift.HeaderText = "Shift"
        fldShift.FieldName = "fldShift"
        fldShift.TextAlignment = ContentAlignment.MiddleCenter
        fldShift.Width = 150
        gvData.Columns.Add(fldShift)

        Dim fldGroup As New GridViewTextBoxColumn
        fldGroup.HeaderText = "Group"
        fldGroup.FieldName = "fldGroup"
        fldGroup.TextAlignment = ContentAlignment.MiddleCenter
        fldGroup.Width = 150
        gvData.Columns.Add(fldGroup)

        Dim fldLotNo As New GridViewTextBoxColumn
        fldLotNo.HeaderText = "Lot No."
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLotNo.Width = 200
        gvData.Columns.Add(fldLotNo)

        Dim fldType As New GridViewTextBoxColumn
        fldType.HeaderText = "Type"
        fldType.FieldName = "fldType"
        fldType.TextAlignment = ContentAlignment.MiddleCenter
        fldType.Width = 80
        gvData.Columns.Add(fldType)

        Dim fldTL As New GridViewTextBoxColumn
        fldTL.HeaderText = "Team Leader"
        fldTL.FieldName = "fldTL"
        fldTL.TextAlignment = ContentAlignment.MiddleCenter
        fldTL.Width = 80
        gvData.Columns.Add(fldTL)

        Dim fldAddedBy As New GridViewTextBoxColumn
        fldAddedBy.HeaderText = "Added/Edit By"
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedBy.Width = 120
        gvData.Columns.Add(fldAddedBy)

        Dim fldAddedDate As New GridViewTextBoxColumn
        fldAddedDate.HeaderText = "Added/Edit Date"
        fldAddedDate.FieldName = "fldAddedDate"
        fldAddedDate.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedDate.Width = 150
        fldAddedDate.FormatString = "{0:MMM/dd/yyy h:m tt}"
        gvData.Columns.Add(fldAddedDate)

        Dim fldFWGroup As New GridViewTextBoxColumn
        fldFWGroup.HeaderText = "FW Group"
        fldFWGroup.FieldName = "fldFWGroup"
        fldFWGroup.TextAlignment = ContentAlignment.MiddleCenter
        fldFWGroup.Width = 80
        fldFWGroup.IsVisible = False
        gvData.Columns.Add(fldFWGroup)

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        Maria.AddMySqlParameters("parDate", dpDate.Value)
        Maria.AddMySqlParameters("parLot", spnLotNo.Value)
        Maria.AddMySqlParameters("parShift", ddShift.Text)
        Maria.AddMySqlParameters("parModel", ddModel.Text)
        Maria.AddMySqlParameters("parType", ddType.Text)
        Maria.AddMySqlParameters("parLine", spnLine.Value)
        Maria.AddMySqlParameters("parFWGroup", ddGroup.SelectedValue)
        Dim checkexist As DataTable = Maria.SPSelect("SP_SRCDownTime_SelectCheckExistWelding3")

        If checkexist.Rows.Count >= 1 Then

            RadMessageBox.Show("Already Exists")

        Else

            Maria.AddMySqlParameters("parDate", dpDate.Value)
            Maria.AddMySqlParameters("parLotNo", spnLotNo.Value)
            Maria.AddMySqlParameters("parShift", ddShift.Text)
            Maria.AddMySqlParameters("parGroup", spnGroup.Value)
            Maria.AddMySqlParameters("parTL", tbTL.Text)
            Maria.AddMySqlParameters("parModel", ddModel.Text)
            Maria.AddMySqlParameters("parLine", spnLine.Value)
            Maria.AddMySqlParameters("parType", ddType.Text)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.AddMySqlParameters("parFWGroup", If(ddType.Text = "FW", ddGroup.SelectedValue, 0))
            Maria.SPADE("SP_SRCDailyReport_InsertWelding2")
            MessageBox.Show("Item Added!")
            ReloadGrid()

        End If

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadGrid()
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        Else

            Maria.MyQuery("Update tblDailyReportWelding set fldStatus='Removed', fldRemovedBy='" & globalVariables.currentUser(1) & "' where fldID=" & gvData.CurrentRow.Cells("fldID").Value & "")
            MessageBox.Show("Item Deleted!")
            ReloadGrid()
            'Maria.AddMySqlParameters("parID", gvData.CurrentRow.Cells("fldID").Value)
            'Maria.SPADE("SP_SRCDailyReportDeleteRecord")
            'RadMessageBox.Show("Item Deleted")
            'ReloadGrid()

        End If
    End Sub

    Private Sub cbbDailyReport_Click(sender As Object, e As EventArgs) Handles cbbDailyReport.Click
        globalVariables.DailyRepID = gvData.CurrentRow.Cells("fldID").Value
        globalVariables.ModelCode = gvData.CurrentRow.Cells("fldModel").Value
        globalVariables.SRCReportType = gvData.CurrentRow.Cells("fldType").Value
        globalVariables.DailyRepShift = gvData.CurrentRow.Cells("fldShift").Value
        globalVariables.DailyReportModel = gvData.CurrentRow.Cells("fldModel").Value
        globalVariables.DailyReportDate = gvData.CurrentRow.Cells("fldDate").Value
        globalVariables.ModelLineWelding = gvData.CurrentRow.Cells("fldLine").Value
        FrmWeldingDailyReportData.MdiParent = frmBase
        FrmWeldingDailyReportData.Show()

        'Mio.PWDRID = gvData.CurrentRow.Cells("fldID").Value
        'Mio.PWModel = gvData.CurrentRow.Cells("fldModel").Value
        'Mio.PWType = gvData.CurrentRow.Cells("fldType").Value
        'Mio.PWShift = gvData.CurrentRow.Cells("fldShift").Value
        'Mio.PWDate = gvData.CurrentRow.Cells("fldDate").Value
        'Mio.PWLine = gvData.CurrentRow.Cells("fldLine").Value
        'FrmPWDailyReportNew.MdiParent = frmBase
        'FrmPWDailyReportNew.Show()
    End Sub

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click
        globalVariables.SRCReportType = "Welding Daily Report"
        globalVariables.LastSRCReportType = "Welding Daily Report"
        globalVariables.parDRID = Convert.ToInt32(gvData.CurrentRow.Cells("fldID").Value)
        globalVariables.parType = gvData.CurrentRow.Cells("fldType").Value.ToString
        globalVariables.parGroup = gvData.CurrentRow.Cells("fldGroup").Value.ToString
        globalVariables.parModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
        globalVariables.parLine = gvData.CurrentRow.Cells("fldLine").Value
        globalVariables.parDate = gvData.CurrentRow.Cells("fldDate").Value
        globalVariables.parLotNo = gvData.CurrentRow.Cells("fldLotNo").Value.ToString
        globalVariables.parShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
        globalVariables.parTeamLeader = gvData.CurrentRow.Cells("fldTL").Value.ToString
        globalVariables.parPartName1 = 0
        globalVariables.parPartName2 = 0

        Dim DTGetReportDetais As DataTable = Maria.MyQuery("SELECT distinct fldFWPWNo FROM dbMIA.tblDailyReportWeldingManpowerEmp where fldDRID=" & parDRID & "")
        'globalVariables.parWeldingNo1 = DTGetReportDetais.Rows(0).Item("fldFWPWNo").ToString
        'globalVariables.parWeldingNo2 = DTGetReportDetais.Rows(1).Item("fldFWPWNo").ToString

        If DTGetReportDetais.Rows.Count >= 4 Then
            globalVariables.parWeldingNo1 = DTGetReportDetais.Rows(0).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo2 = DTGetReportDetais.Rows(1).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo3 = DTGetReportDetais.Rows(2).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo4 = DTGetReportDetais.Rows(3).Item("fldFWPWNo").ToString
        ElseIf DTGetReportDetais.Rows.Count >= 3 Then
            globalVariables.parWeldingNo1 = DTGetReportDetais.Rows(0).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo2 = DTGetReportDetais.Rows(1).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo3 = DTGetReportDetais.Rows(2).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo4 = 0
        ElseIf DTGetReportDetais.Rows.Count >= 2 Then
            globalVariables.parWeldingNo1 = DTGetReportDetais.Rows(0).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo2 = DTGetReportDetais.Rows(1).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo3 = 0
            globalVariables.parWeldingNo4 = 0
        ElseIf DTGetReportDetais.Rows.Count >= 1 Then
            globalVariables.parWeldingNo1 = DTGetReportDetais.Rows(0).Item("fldFWPWNo").ToString
            globalVariables.parWeldingNo2 = 0
            globalVariables.parWeldingNo3 = 0
            globalVariables.parWeldingNo4 = 0
        ElseIf DTGetReportDetais.Rows.Count <= 0 Then
            globalVariables.parWeldingNo1 = 0
            globalVariables.parWeldingNo2 = 0
            globalVariables.parWeldingNo3 = 0
            globalVariables.parWeldingNo4 = 0
        End If

        Dim DTGetLotNoCount As DataTable = Maria.MyQuery("SELECT distinct fldAssyNo FROM tblDailyReportWeldingLotNo where fldDRID='" & parDRID & "'")
        If DTGetLotNoCount.Rows.Count >= 9 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = DTGetLotNoCount.Rows(1).Item("fldAssyNo").ToString
            globalVariables.parLot3 = DTGetLotNoCount.Rows(2).Item("fldAssyNo").ToString
            globalVariables.parLot4 = DTGetLotNoCount.Rows(3).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot6 = DTGetLotNoCount.Rows(5).Item("fldAssyNo").ToString
            globalVariables.parLot7 = DTGetLotNoCount.Rows(6).Item("fldAssyNo").ToString
            globalVariables.parLot8 = DTGetLotNoCount.Rows(7).Item("fldAssyNo").ToString
            globalVariables.parLot9 = DTGetLotNoCount.Rows(8).Item("fldAssyNo").ToString
        ElseIf DTGetLotNoCount.Rows.Count >= 8 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = DTGetLotNoCount.Rows(1).Item("fldAssyNo").ToString
            globalVariables.parLot3 = DTGetLotNoCount.Rows(2).Item("fldAssyNo").ToString
            globalVariables.parLot4 = DTGetLotNoCount.Rows(3).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot6 = DTGetLotNoCount.Rows(5).Item("fldAssyNo").ToString
            globalVariables.parLot7 = DTGetLotNoCount.Rows(6).Item("fldAssyNo").ToString
            globalVariables.parLot8 = DTGetLotNoCount.Rows(7).Item("fldAssyNo").ToString
            globalVariables.parLot9 = 0
        ElseIf DTGetLotNoCount.Rows.Count >= 7 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = DTGetLotNoCount.Rows(1).Item("fldAssyNo").ToString
            globalVariables.parLot3 = DTGetLotNoCount.Rows(2).Item("fldAssyNo").ToString
            globalVariables.parLot4 = DTGetLotNoCount.Rows(3).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot6 = DTGetLotNoCount.Rows(5).Item("fldAssyNo").ToString
            globalVariables.parLot7 = DTGetLotNoCount.Rows(6).Item("fldAssyNo").ToString
            globalVariables.parLot8 = 0
            globalVariables.parLot9 = 0
        ElseIf DTGetLotNoCount.Rows.Count >= 6 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = DTGetLotNoCount.Rows(1).Item("fldAssyNo").ToString
            globalVariables.parLot3 = DTGetLotNoCount.Rows(2).Item("fldAssyNo").ToString
            globalVariables.parLot4 = DTGetLotNoCount.Rows(3).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot6 = DTGetLotNoCount.Rows(5).Item("fldAssyNo").ToString
            globalVariables.parLot7 = 0
            globalVariables.parLot8 = 0
            globalVariables.parLot9 = 0
        ElseIf DTGetLotNoCount.Rows.Count >= 5 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = DTGetLotNoCount.Rows(1).Item("fldAssyNo").ToString
            globalVariables.parLot3 = DTGetLotNoCount.Rows(2).Item("fldAssyNo").ToString
            globalVariables.parLot4 = DTGetLotNoCount.Rows(3).Item("fldAssyNo").ToString
            globalVariables.parLot5 = DTGetLotNoCount.Rows(4).Item("fldAssyNo").ToString
            globalVariables.parLot6 = 0
            globalVariables.parLot7 = 0
            globalVariables.parLot8 = 0
            globalVariables.parLot9 = 0
        ElseIf DTGetLotNoCount.Rows.Count >= 4 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = DTGetLotNoCount.Rows(1).Item("fldAssyNo").ToString
            globalVariables.parLot3 = DTGetLotNoCount.Rows(2).Item("fldAssyNo").ToString
            globalVariables.parLot4 = DTGetLotNoCount.Rows(3).Item("fldAssyNo").ToString
            globalVariables.parLot5 = 0
            globalVariables.parLot6 = 0
            globalVariables.parLot7 = 0
            globalVariables.parLot8 = 0
            globalVariables.parLot9 = 0
        ElseIf DTGetLotNoCount.Rows.Count >= 3 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = DTGetLotNoCount.Rows(1).Item("fldAssyNo").ToString
            globalVariables.parLot3 = DTGetLotNoCount.Rows(2).Item("fldAssyNo").ToString
            globalVariables.parLot4 = 0
            globalVariables.parLot5 = 0
            globalVariables.parLot6 = 0
            globalVariables.parLot7 = 0
            globalVariables.parLot8 = 0
            globalVariables.parLot9 = 0

        ElseIf DTGetLotNoCount.Rows.Count >= 2 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = DTGetLotNoCount.Rows(1).Item("fldAssyNo").ToString
            globalVariables.parLot3 = 0
            globalVariables.parLot4 = 0
            globalVariables.parLot5 = 0
            globalVariables.parLot6 = 0
            globalVariables.parLot7 = 0
            globalVariables.parLot8 = 0
            globalVariables.parLot9 = 0
        ElseIf DTGetLotNoCount.Rows.Count >= 1 Then
            globalVariables.parLot1 = DTGetLotNoCount.Rows(0).Item("fldAssyNo").ToString
            globalVariables.parLot2 = 0
            globalVariables.parLot3 = 0
            globalVariables.parLot4 = 0
            globalVariables.parLot5 = 0
            globalVariables.parLot6 = 0
            globalVariables.parLot7 = 0
            globalVariables.parLot8 = 0
            globalVariables.parLot9 = 0
        ElseIf DTGetLotNoCount.Rows.Count <= 0 Then
            globalVariables.parLot1 = 0
            globalVariables.parLot2 = 0
            globalVariables.parLot3 = 0
            globalVariables.parLot4 = 0
            globalVariables.parLot5 = 0
            globalVariables.parLot6 = 0
            globalVariables.parLot7 = 0
            globalVariables.parLot8 = 0
            globalVariables.parLot9 = 0
        End If

        Dim CheckGoodQtyCount1 As DataTable = Maria.MyQuery("Select count(fldDRID) as fldCount From tblDailyReportWeldingManpowerGoodQty where fldDRID=" & gvData.CurrentRow.Cells("fldID").Value & " and fldType='" & gvData.CurrentRow.Cells("fldType").Value.ToString & "' and fldPWFWNo='" & globalVariables.parWeldingNo1 & "'")
        Dim CheckGoodQtyCount2 As DataTable = Maria.MyQuery("Select count(fldDRID) as fldCount From tblDailyReportWeldingManpowerGoodQty where fldDRID=" & gvData.CurrentRow.Cells("fldID").Value & " and fldType='" & gvData.CurrentRow.Cells("fldType").Value.ToString & "' and fldPWFWNo='" & globalVariables.parWeldingNo2 & "'")
        Dim CheckGoodQtyCount3 As DataTable = Maria.MyQuery("Select count(fldDRID) as fldCount From tblDailyReportWeldingManpowerGoodQty where fldDRID=" & gvData.CurrentRow.Cells("fldID").Value & " and fldType='" & gvData.CurrentRow.Cells("fldType").Value.ToString & "' and fldPWFWNo='" & globalVariables.parWeldingNo3 & "'")
        Dim CheckGoodQtyCount4 As DataTable = Maria.MyQuery("Select count(fldDRID) as fldCount From tblDailyReportWeldingManpowerGoodQty where fldDRID=" & gvData.CurrentRow.Cells("fldID").Value & " and fldType='" & gvData.CurrentRow.Cells("fldType").Value.ToString & "' and fldPWFWNo='" & globalVariables.parWeldingNo4 & "'")

        globalVariables.parGoodQty1 = Convert.ToInt32(CheckGoodQtyCount1.Rows(0).Item("fldCount"))
        globalVariables.parGoodQty2 = Convert.ToInt32(CheckGoodQtyCount2.Rows(0).Item("fldCount"))
        globalVariables.parGoodQty3 = Convert.ToInt32(CheckGoodQtyCount3.Rows(0).Item("fldCount"))
        globalVariables.parGoodQty4 = Convert.ToInt32(CheckGoodQtyCount4.Rows(0).Item("fldCount"))




        'FrmSRCDailyReportViewer.Show()
        FrmWeldingDailyReportViewer.Show()
    End Sub

    Private Sub cbbDownTime_Click(sender As Object, e As EventArgs) Handles cbbDownTime.Click

        If Mio.WeldingType = "PW" Then
            globalVariables.DowntimeType = "PW"
        Else
            globalVariables.DowntimeType = "FW"
        End If
        FldAssemblyDowntimeMain.Show()
    End Sub

    Private Sub AddWorksheetFromDataTable(workbook As Telerik.Windows.Documents.Spreadsheet.Model.Workbook, sheetName As String, dt As DataTable)
        ' Create Worksheet
        Dim ws As Telerik.Windows.Documents.Spreadsheet.Model.Worksheet = workbook.Worksheets.Add()
        ws.Name = sheetName
        Dim rowIndex As Integer = 0
        Dim colIndex As Integer = 0

        ' Write headers
        For Each col As DataColumn In dt.Columns
            ws.Cells(rowIndex, colIndex).SetValue(col.ColumnName)
            colIndex += 1
        Next

        rowIndex = 1

        ' Write rows
        For Each dr As DataRow In dt.Rows
            colIndex = 0
            For Each col As DataColumn In dt.Columns
                ws.Cells(rowIndex, colIndex).SetValue(dr(col).ToString())
                colIndex += 1
            Next
            rowIndex += 1
        Next

        ' Auto-fit all columns in this worksheet
        Dim textFormat As CellValueFormat = New CellValueFormat("@")
        Dim lastColumnIndex As Integer = ws.UsedCellRange.ColumnCount - 1
        Dim columnSelection As ColumnSelection = ws.Columns(0, lastColumnIndex)
        columnSelection.AutoFitWidth()

    End Sub

    Private Sub cbbOffline_Click(sender As Object, e As EventArgs) Handles cbbOffline.Click

        If gvData.Rows.Count <= 0 Then

        Else
            globalVariables.DailyRepID = gvData.CurrentRow.Cells("fldID").Value
            globalVariables.ModelCode = gvData.CurrentRow.Cells("fldCode").Value
            globalVariables.DailyReportModel = gvData.CurrentRow.Cells("fldModel").Value
            globalVariables.DailyRepShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
            globalVariables.AssyDownTimeModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
            globalVariables.AssyDownTimeShift = gvData.CurrentRow.Cells("fldShift").Value.ToString
            globalVariables.AssyDownTimeDate = gvData.CurrentRow.Cells("fldDate").Value
            globalVariables.SRCReportType = gvData.CurrentRow.Cells("fldType").Value
            globalVariables.ModelLineWelding = gvData.CurrentRow.Cells("fldLine").Value
            globalVariables.FWGroup = gvData.CurrentRow.Cells("fldFWGroup").Value

            If gvData.CurrentRow.Cells("fldType").Value.ToString = "FW" Then

                If gvData.CurrentRow.Cells("fldFWGroup").Value.ToString = "1" Or gvData.CurrentRow.Cells("fldFWGroup").Value.ToString = "2" Then

                    GetWeldingNo = Maria.MyQuery("Select distinct fldPWFWNo FROM dbMIA.tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "' and fldGroup=" & gvData.CurrentRow.Cells("fldFWGroup").Value & "")
                    LotNoTemplate = Maria.MyQuery("SELECT distinct fldAssyNo FROM dbMIA.tblDailyReportWeldingTemplateLotNo where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "' and fldGroup=" & gvData.CurrentRow.Cells("fldFWGroup").Value & "")



                ElseIf gvData.CurrentRow.Cells("fldFWGroup").Value.ToString = "3" Then

                    GetWeldingNo = Maria.MyQuery("Select distinct fldPWFWNo FROM dbMIA.tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")
                    LotNoTemplate = Maria.MyQuery("SELECT distinct fldAssyNo FROM dbMIA.tblDailyReportWeldingTemplateLotNo where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")


                Else

                    GetWeldingNo = Maria.MyQuery("Select distinct fldPWFWNo FROM dbMIA.tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")
                    LotNoTemplate = Maria.MyQuery("SELECT distinct fldAssyNo FROM dbMIA.tblDailyReportWeldingTemplateLotNo where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")


                End If

            Else
                GetWeldingNo = Maria.MyQuery("Select distinct fldPWFWNo FROM dbMIA.tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")
                LotNoTemplate = Maria.MyQuery("SELECT distinct fldAssyNo FROM dbMIA.tblDailyReportWeldingTemplateLotNo where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")
            End If



            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If Mio.WeldingType = "PW" Then
                    If sfd.ShowDialog() = DialogResult.OK Then
                        Try
                            Using workbook As XLWorkbook = New XLWorkbook()
                                For Each row As DataRow In GetWeldingNo.AsEnumerable
                                    Dim worksheet = workbook.Worksheets.Add(ExcelManpower(row.Item("fldPWFWNo").ToString), "MANPOWER " & row.Item("fldPWFWNo").ToString)
                                    worksheet.Column("C").Width = 20
                                    worksheet.Column("C").Style.Font.FontSize = 8
                                    worksheet.Columns().AdjustToContents()
                                    worksheet.Columns().Style.NumberFormat.Format = "@"

                                Next
                                For Each row As DataRow In GetWeldingNo.AsEnumerable
                                    Dim worksheet = workbook.Worksheets.Add(ExcelGoodQty(row.Item("fldPWFWNo").ToString), "GOOD QTY " & row.Item("fldPWFWNo").ToString)
                                    worksheet.Columns().AdjustToContents()
                                    worksheet.Columns().Style.NumberFormat.Format = "@"

                                Next
                                For Each row As DataRow In GetWeldingNo.AsEnumerable
                                    Dim worksheet = workbook.Worksheets.Add(ExcelHourly(row.Item("fldPWFWNo").ToString), "HOURLY " & row.Item("fldPWFWNo").ToString)
                                    worksheet.Columns().AdjustToContents()
                                    worksheet.Columns().Style.NumberFormat.Format = "@"
                                Next

                                If Mio.WeldingType = "FW" Then
                                    Dim worksheet3 = workbook.Worksheets.Add(ExcelSample(), "FW SAMPLE")
                                    worksheet3.Columns().AdjustToContents()
                                    worksheet3.Columns().Style.NumberFormat.Format = "@"
                                End If



                                Dim worksheet1 = workbook.Worksheets.Add(ExcelDefects(), "DEFECTS")
                                worksheet1.Columns().AdjustToContents()
                                worksheet1.Columns().Style.NumberFormat.Format = "@"

                                Dim worksheet2 = workbook.Worksheets.Add(ExcelOtherDetails(), "OTHER DETAILS")
                                worksheet2.Columns().AdjustToContents()
                                worksheet2.Column("A").Width = 50
                                worksheet2.Columns().Style.NumberFormat.Format = "@"


                                For Each row As DataRow In LotNoTemplate.AsEnumerable
                                    Dim worksheet = workbook.Worksheets.Add(ExcelLotNo(row.Item("fldAssyNo").ToString), "LOT " & row.Item("fldAssyNo").ToString)
                                    worksheet.Columns().AdjustToContents()
                                    worksheet.Columns().Style.NumberFormat.Format = "@"
                                Next

                                workbook.SaveAs(sfd.FileName)
                            End Using
                            MessageBox.Show("DONE")
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                ElseIf Mio.WeldingType = "FW" Then
                    If sfd.ShowDialog() = DialogResult.OK Then
                        Try
                            Dim workbook As New Telerik.Windows.Documents.Spreadsheet.Model.Workbook()

                            ' MANPOWER sheets
                            For Each row As DataRow In GetWeldingNo.Rows
                                AddWorksheetFromDataTable(workbook,
                                                      "MANPOWER " & row("fldPWFWNo").ToString(),
                                                      ExcelManpower(row("fldPWFWNo")))
                            Next

                            ' GOOD QTY sheets
                            For Each row As DataRow In GetWeldingNo.Rows
                                AddWorksheetFromDataTable(workbook,
                                                      "GOOD QTY " & row("fldPWFWNo").ToString(),
                                                      ExcelGoodQty(row("fldPWFWNo")))
                            Next

                            ' HOURLY sheets
                            For Each row As DataRow In GetWeldingNo.Rows
                                AddWorksheetFromDataTable(workbook,
                                                      "HOURLY " & row("fldPWFWNo").ToString(),
                                                      ExcelHourly(row("fldPWFWNo")))
                            Next

                            ' FW Sample sheet
                            If Mio.WeldingType = "FW" Then
                                AddWorksheetFromDataTable(workbook, "FW SAMPLE", ExcelSample())
                            End If

                            ' Defects sheet
                            AddWorksheetFromDataTable(workbook, "DEFECTS", ExcelDefects())

                            ' Other details
                            AddWorksheetFromDataTable(workbook, "OTHER DETAILS", ExcelOtherDetails())

                            ' LOT sheets
                            For Each row As DataRow In LotNoTemplate.Rows
                                Dim sheetName As String = "LOT " & row("fldAssyNo").ToString()
                                AddWorksheetFromDataTable(workbook, sheetName, ExcelLotNo(row("fldAssyNo")))
                            Next

                            ' Save workbook
                            Dim provider As New XlsxFormatProvider()
                            Using fs As New IO.FileStream(sfd.FileName, IO.FileMode.Create)
                                provider.Export(workbook, fs)
                           
                            End Using

                            MessageBox.Show("DONE")
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                End If


            End Using

        End If

    End Sub

    Private Function ExcelManpower(parNO As String) As DataTable
        Dim ManPowerDT As New DataTable
        ManPowerDT.Columns.Add("Welding No.")
        ManPowerDT.Columns.Add("Assembly Process Name")
        ManPowerDT.Columns.Add("Employee Name")
        ManPowerDT.Columns.Add("Qualified")
        ManPowerDT.Columns.Add("Transferred")
        ManPowerDT.Columns.Add("TRAINEE")

        Dim Adrestia As DataTable = Maria.MyQuery("Select fldProcessName,fldEmployee,fldEmployee2,fldEmployee3,fldEmployeeDay,fldEmployeeNight FROM tblDailyReportWeldingManpowerTemp where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "' and fldWeldNo='" & parNO & "'")
        'MessageBox.Show(Adrestia.Rows.Count)

        For Each row As DataRow In Adrestia.Rows

            If globalVariables.DailyRepShift = "1st Shift" Then
                ManPowerDT.Rows.Add(parNO, row.Item("fldProcessName").ToString, row.Item("fldEmployee").ToString, True, False, False)
            ElseIf globalVariables.DailyRepShift = "Day Shift" Then
                ManPowerDT.Rows.Add(parNO, row.Item("fldProcessName").ToString, row.Item("fldEmployeeDay").ToString, True, False, False)
            ElseIf globalVariables.DailyRepShift = "2nd Shift" Then
                ManPowerDT.Rows.Add(parNO, row.Item("fldProcessName").ToString, row.Item("fldEmployee2").ToString, True, False, False)
            ElseIf globalVariables.DailyRepShift = "Night Shift" Then
                ManPowerDT.Rows.Add(parNO, row.Item("fldProcessName").ToString, row.Item("fldEmployeeNight").ToString, True, False, False)
            ElseIf globalVariables.DailyRepShift = "3rd Shift" Then
                ManPowerDT.Rows.Add(parNO, row.Item("fldProcessName").ToString, row.Item("fldEmployee3").ToString, True, False, False)
            End If

        Next

        Return ManPowerDT
    End Function

    Private Function ExcelGoodQty(parNO As String) As DataTable
        Dim Minerva As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "' and fldPWFWNo='" & parNO & "'")

        Dim GoodQtyDT As New DataTable
        GoodQtyDT.Columns.Add("Welding No.")
        For Each row As DataRow In Minerva.Rows

            GoodQtyDT.Columns.Add(row.Item("fldPartName").ToString)

        Next

        GoodQtyDT.Rows.Add(parNO)
        For Each row As DataRow In Minerva.Rows

            GoodQtyDT.Rows(0).Item(row.Item("fldPartName").ToString) = 0

        Next
        Return GoodQtyDT
    End Function

    Private Function ExcelSample() As DataTable
        Dim Minerva As DataTable = Maria.MyQuery("SELECT *, CONCAT(fldPartNumber, ' ', fldPartName) AS fldWIP " & "FROM dbMIA.tblDailyReportWeldingSampleTemplate " & "WHERE fldModel = '" & globalVariables.DailyReportModel & "'")

        Dim sampleDT As New DataTable
        For Each row As DataRow In Minerva.Rows

            sampleDT.Columns.Add(row.Item("fldWIP").ToString)

        Next
        Return sampleDT
    End Function

    Private Function ExcelHourly(parNo As String) As DataTable
        Dim Akali As DataTable
        If WeldingType = "PW" Then
            Akali = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingPlan where fldShift='" & globalVariables.DailyRepShift & "'")
        Else
            Akali = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingPlanFw where fldShift='" & globalVariables.DailyRepShift & "'")
        End If
        'If globalVariables.SRCReportType = "PW" Then
        '    Akali = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingPlan where fldShift='" & globalVariables.DailyRepShift & "'")
        'ElseIf globalVariables.SRCReportType = "FW" Then
        '    'Akali = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingPlan where fldShift='" & globalVariables.DailyRepShift & "'")
        '    Akali = Maria.MyQuery("SELECT T0.* FROM dbMIA.tblDailyReportWeldingPlanFw T0 LEFT JOIN dbMIA.tblDowntimeFWMachine T1 ON T0.fldModel = T1.fldModel AND T0.fldFwMachine = T1.fldFwMachine
        '                            WHERE (T0.fldShift = '" & globalVariables.DailyRepShift & "') AND (T1.fldGroup = '" & globalVariables.FWGroup & "') AND 
        '                            (T0.fldFwMachine = '" & parNo & "') GROUP BY T0.fldTime, T0.fldPlan")
        'End If


        Dim HourlyDT As New DataTable

        HourlyDT.Columns.Add("Welding No")
        HourlyDT.Columns.Add("Time")
        HourlyDT.Columns.Add("Plan")
        HourlyDT.Columns.Add("Actual")
        HourlyDT.Columns.Add("Checked By")
        HourlyDT.Columns.Add("Remarks")

        For Each row As DataRow In Akali.AsEnumerable
            HourlyDT.Rows.Add(parNo, row.Item("fldTime").ToString, row.Item("fldPlan"), 0, " ", " ")
        Next
        Return HourlyDT

    End Function
    Dim DTWip As New DataTable
    Private Function ExcelDefects() As DataTable

        Dim DefectsDT As New DataTable
        DefectsDT.Columns.Add("In Process Defects")

        If globalVariables.SRCReportType = "FW" Then

            If gvData.CurrentRow.Cells("fldFWGroup").Value.ToString = "1" Or gvData.CurrentRow.Cells("fldFWGroup").Value.ToString = "2" Then
                DTWip = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine='" & globalVariables.ModelLineWelding & "' and fldType='" & globalVariables.SRCReportType & "' and fldGroup=" & gvData.CurrentRow.Cells("fldFWGroup").Value.ToString & "")
                For Each row As DataRow In DTWip.Rows
                    DefectsDT.Columns.Add(row.Item("fldPartName").ToString)
                    DefectsDT.Columns.Add(row.Item("fldPartName").ToString & " ")
                    DefectsDT.Columns.Add(row.Item("fldPartName").ToString & "  ")
                Next

                Dim SCArray(DTWip.Rows.Count * 3) As String

                Dim i = 0
                Dim e = 1
                SCArray(0) = " "
                While i <= DTWip.Rows.Count - 1

                    SCArray(e) = "S"
                    SCArray(e + 1) = "C"
                    SCArray(e + 2) = "S/C"
                    e = e + 3
                    i = i + 1
                End While

                DefectsDT.Rows.Add(SCArray)
            Else
                DTWip = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")
                For Each row As DataRow In DTWip.Rows
                    DefectsDT.Columns.Add(row.Item("fldPartName").ToString)
                    DefectsDT.Columns.Add(row.Item("fldPartName").ToString & " ")
                    DefectsDT.Columns.Add(row.Item("fldPartName").ToString & "  ")
                Next

                Dim SCArray(DTWip.Rows.Count * 3) As String

                Dim i = 0
                Dim e = 1
                SCArray(0) = " "
                While i <= DTWip.Rows.Count - 1

                    SCArray(e) = "S"
                    SCArray(e + 1) = "C"
                    SCArray(e + 2) = "S/C"
                    e = e + 3
                    i = i + 1
                End While

                DefectsDT.Rows.Add(SCArray)
            End If

        Else
            DTWip = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "'")
            For Each row As DataRow In DTWip.Rows
                DefectsDT.Columns.Add(row.Item("fldPartName").ToString)
            Next

        End If

        DefectsDT.Rows.Add("Autorun")
        DefectsDT.Rows.Add("Damage Busbar")
        DefectsDT.Rows.Add("Foreign Material")
        DefectsDT.Rows.Add("Lifted Welding")
        DefectsDT.Rows.Add("Loose Wire")
        DefectsDT.Rows.Add("Mis Insertion")
        DefectsDT.Rows.Add("Sensor Error")
        DefectsDT.Rows.Add("Short Weld")
        DefectsDT.Rows.Add("Strong Weld")
        DefectsDT.Rows.Add("USW Error (Power)")
        DefectsDT.Rows.Add("USW Error (Strain)")
        DefectsDT.Rows.Add("USW Error (Time)")
        DefectsDT.Rows.Add("USW Error (Voltage)")
        DefectsDT.Rows.Add("Weak Weld")

        DefectsDT.Rows.Add("Material Defects")
        Return DefectsDT
    End Function

    Private Function ExcelOtherDetails() As DataTable

        Dim OtherDetailsDT As New DataTable
        OtherDetailsDT.Columns.Add("Other Details")


        Return OtherDetailsDT
    End Function

    Private Function ExcelLotNo(parNO As String) As DataTable
        Dim DTWip As DataTable = Maria.MyQuery("SELECT fldPartName, fldTypeNo FROM dbMIA.tblDailyReportWeldingTemplateLotNo where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='" & globalVariables.SRCReportType & "' and fldAssyNo='" & parNO & "'")
        Dim LotNoDT As New DataTable
        LotNoDT.Columns.Add("Lot No")
        LotNoDT.Columns.Add("Time")
        LotNoDT.Columns.Add("Machine No.")
        LotNoDT.Columns.Add("Box No (1)")
        LotNoDT.Columns.Add("Box No (2)")
        Dim CavNo As Integer = 1
        Dim CavCav As String = "Cav"
        Dim machineNo As String
        For Each row As DataRow In DTWip.Rows
            LotNoDT.Columns.Add(row.Item("fldPartName").ToString)
            LotNoDT.Columns.Add(CavCav)
            CavCav = "Cav" & CavNo
            machineNo = row.Item("fldTypeNo").ToString()
            CavNo = CavNo + 1
        Next

        If globalVariables.DailyRepShift = "1st Shift" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                'LotNoDT.Rows.Add(parNO, InitialTime - 1 & ":00-" & InitialTime & ":00", machineNo)
                LotNoDT.Rows.Add(parNO, (InitialTime - 1 & ":00 - " & InitialTime & ":00"), machineNo)

            End While
            LotNoDT.Rows.Add(parNO, "Component Scrap")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Normal)")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Additional)")
            LotNoDT.Rows.Add(parNO, "Engineering Sample")
        ElseIf globalVariables.DailyRepShift = "Day Shift" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                LotNoDT.Rows.Add(parNO, (InitialTime - 1 & ":00 - " & InitialTime & ":00"), machineNo)

            End While
            LotNoDT.Rows.Add(parNO, "Component Scrap")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Normal)")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Additional)")
            LotNoDT.Rows.Add(parNO, "Engineering Sample")
        ElseIf globalVariables.DailyRepShift = "2nd Shift" Then
            Dim InitialTime As Integer = 14
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                LotNoDT.Rows.Add(parNO, InitialTime - 1 & ":00-" & InitialTime & ":00", machineNo)
            End While
            LotNoDT.Rows.Add(parNO, "Component Scrap")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Normal)")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Additional)")
            LotNoDT.Rows.Add(parNO, "Engineering Sample")
        ElseIf globalVariables.DailyRepShift = "Night Shift" Then
            Dim InitialTime As Integer = 18
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    LotNoDT.Rows.Add(parNO, After24Hrs - 1 & ":00 - " & After24Hrs & ":00", machineNo)
                Else
                    LotNoDT.Rows.Add(parNO, InitialTime - 1 & ":00 - " & InitialTime & ":00", machineNo)
                End If

            End While
            LotNoDT.Rows.Add(parNO, "Component Scrap")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Normal)")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Additional)")
            LotNoDT.Rows.Add(parNO, "Engineering Sample")
        ElseIf globalVariables.DailyRepShift = "3rd Shift" Then
            Dim InitialTime As Integer = 22
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1L
                    LotNoDT.Rows.Add(parNO, After24Hrs - 1 & ":00-" & After24Hrs & ":00", machineNo)
                Else
                    LotNoDT.Rows.Add(parNO, InitialTime - 1 & ":00-" & InitialTime & ":00", machineNo)
                End If
            End While
            LotNoDT.Rows.Add(parNO, "Component Scrap")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Normal)")
            LotNoDT.Rows.Add(parNO, "QA(QC) Sample (Additional)")
            LotNoDT.Rows.Add(parNO, "Engineering Sample")
        End If

        Return LotNoDT
    End Function

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

    Private Sub CommandBarButton1_Click(sender As Object, e As EventArgs) Handles CommandBarButton1.Click
        If Mio.WeldingType = "FW" Then
            Mio.uploadType = "FW"
        Else
            Mio.uploadType = "PW"
        End If
        If gvData.Rows.Count <= 0 Then

        Else
            globalVariables.DailyRepID = gvData.CurrentRow.Cells("fldID").Value
            globalVariables.ModelCode = gvData.CurrentRow.Cells("fldModel").Value
            globalVariables.SRCReportType = gvData.CurrentRow.Cells("fldType").Value
            globalVariables.DailyRepShift = gvData.CurrentRow.Cells("fldShift").Value
            globalVariables.DailyReportModel = gvData.CurrentRow.Cells("fldModel").Value
            globalVariables.FWGroup = gvData.CurrentRow.Cells("fldFWGroup").Value
            globalVariables.ModelLineWelding = gvData.CurrentRow.Cells("fldLine").Value
            FrmWeldingUpload.Show()
        End If
    End Sub

    Private Sub ddType_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddType.SelectedIndexChanged

        SelectType()
        ReloadGrid()

    End Sub

    Private Sub ddModel_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddModel.SelectedIndexChanged
        My.Settings.setSRCModel = ddModel.SelectedIndex
        SelectType()
        ReloadGrid()

    End Sub

    Private Sub SelectType()
        If TempGroupDT.Rows.Count >= 1 Then

            TempGroupDT.Rows.Clear()

        End If

        If ddType.Text = "FW" Then

            Dim GetWeldNo1 As DataTable = Maria.MyQuery("SET sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & ddModel.Text & "' and  fldType='" & ddType.Text & "' and fldGroup=1 and fldLine = '" & spnLine.Value & "' group by fldPWFWNo")
            Dim GetWeldNo2 As DataTable = Maria.MyQuery("SET sql_mode=(SELECT REPLACE(@@sql_mode,'ONLY_FULL_GROUP_BY',''));SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & ddModel.Text & "' and  fldType='" & ddType.Text & "' and fldGroup=2 and fldLine = '" & spnLine.Value & "' group by fldPWFWNo")

            If GetWeldNo1 IsNot Nothing Then
                Dim WeldStr1 As String = String.Empty
                For Each row As DataRow In GetWeldNo1.Rows
                    If WeldStr1 = String.Empty Then
                        WeldStr1 = WeldStr1 & row.Item("fldPWFWNo").ToString
                    Else
                        WeldStr1 = WeldStr1 & " & " & row.Item("fldPWFWNo").ToString
                    End If
                Next
                TempGroupDT.Rows.Add(1, WeldStr1)
            End If

            If GetWeldNo2 IsNot Nothing Then
                Dim WeldStr1 As String = String.Empty
                For Each row As DataRow In GetWeldNo2.Rows
                    If WeldStr1 = String.Empty Then
                        WeldStr1 = WeldStr1 & row.Item("fldPWFWNo").ToString
                    Else
                        WeldStr1 = WeldStr1 & " & " & row.Item("fldPWFWNo").ToString
                    End If
                Next
                TempGroupDT.Rows.Add(2, WeldStr1)
            End If

            If GetWeldNo1 IsNot Nothing And GetWeldNo2 IsNot Nothing Then
                TempGroupDT.Rows.Add(3, "Both")
            End If


            ddGroup.Enabled = True

            ddGroup.DataSource = TempGroupDT
            ddGroup.DisplayMember = "fldWeldNo"
            ddGroup.ValueMember = "fldGroup"
            ddGroup.AutoCompleteDataSource = TempGroupDT
            ddGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ddGroup.AutoCompleteDisplayMember = "fldWeldNo"
            ddGroup.AutoCompleteValueMember = "fldGroup"
            ddGroup.Text = ""


            ddGroup.SelectedIndex = 2

        Else
            If TempGroupDT.Rows.Count >= 1 Then

                TempGroupDT.Rows.Clear()
                ddGroup.DataSource = Nothing
                ddGroup.Enabled = False

            End If


        End If
    End Sub

    Private Sub spnLine_ValueChanged(sender As Object, e As EventArgs) Handles spnLine.ValueChanged
        My.Settings.setSRCLine = spnLine.Value
        SelectType()
        ReloadGrid()
    End Sub
End Class

