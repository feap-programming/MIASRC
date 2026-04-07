Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ucSRCInProcDefects
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim rowIndex As Integer
    Dim CurrTable As String
    Dim TotalProd As Integer
    Private Sub ucSRCInProcDefects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadGridA()
        ReloadGridB()
        ReloadGridC()
        ReloadGridD()
        ReloadData()
        Dim ProdDt As DataTable = Maria.MyQuery("SELECT ifnull(max(fldActual),0) as fldActual FROM dbMIA.tblDailyReportSRCHourlyQuality where fldDRID=" & globalVariables.DailyRepID & "")
        If ProdDt.Rows.Count >= 1 Then
            TotalProd = Convert.ToInt32(ProdDt.Rows(0).Item("fldActual"))
        Else
            TotalProd = 0
        End If
        spnTotalProd.Value = TotalProd

        If spnTotalProd.Value = 0 Then
            spnDefectPPM.Value = 0.00
        Else
            spnDefectPPM.Value = spnDefectQty.Value / spnTotalProd.Value
        End If
    End Sub

    Private Sub ReloadData()

        Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & "")
        If CheckExist.Rows.Count >= 1 Then

            Dim GridValA As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & " and fldCateg='A'")
            Dim GridValB As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & " and fldCateg='B'")
            Dim GridValC As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & " and fldCateg='C'")
            Dim GridValD As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & " and fldCateg='D'")

            gvDataA.DataSource = GridValA
            gvDataB.DataSource = GridValB
            gvDataC.DataSource = GridValC
            gvDataD.DataSource = GridValD

            Dim GridValDefQty As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & " and fldCateg='None' and fldDefCode='D. Defective Quantity. (pcs)'")
            Dim GridValTotalProd As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & " and fldCateg='None' and fldDefCode='C: Total Production Output'")

            If GridValDefQty.Rows.Count >= 1 Then
                spnDefectQty.Value = GridValDefQty.Rows(0).Item("fldVal")
            Else
                spnDefectQty.Value = 0
            End If

            'If GridValDefQty.Rows.Count >= 1 Then
            '    spnTotalProd.Value = GridValTotalProd.Rows(0).Item("fldVal")
            'Else
            '    spnTotalProd.Value = 0
            'End If


        Else
            gvDataA.Rows.Add("Torque Error")
            gvDataA.Rows.Add("Weld Error")

            gvDataB.Rows.Add("I/R Error")
            gvDataB.Rows.Add("Mis-Insertion")
            gvDataB.Rows.Add("Pattern Error")
            gvDataB.Rows.Add("Pattern Open")
            gvDataB.Rows.Add("Pattern Short")
            gvDataB.Rows.Add("Shortbar")
        End If

    End Sub

    Private Sub ReloadGridA()

        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 100
        gvDataA.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 120
        gvDataA.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 70
        gvDataA.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 70
        gvDataA.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 70
        gvDataA.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 70
        gvDataA.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 70
        gvDataA.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 70
        gvDataA.Columns.Add(fldRM)

        gvDataA.MasterTemplate.BestFitColumns()
    End Sub

    Private Sub ReloadGridB()

        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 100
        gvDataB.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 120
        gvDataB.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 70
        gvDataB.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 70
        gvDataB.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 70
        gvDataB.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 70
        gvDataB.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 70
        gvDataB.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 70
        gvDataB.Columns.Add(fldRM)

        gvDataB.MasterTemplate.BestFitColumns()
    End Sub

    Private Sub ReloadGridC()

        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 100
        gvDataC.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 120
        gvDataC.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 70
        gvDataC.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 70
        gvDataC.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 70
        gvDataC.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 70
        gvDataC.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 70
        gvDataC.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 70
        gvDataC.Columns.Add(fldRM)

        gvDataC.MasterTemplate.BestFitColumns()
    End Sub

    Private Sub ReloadGridD()

        Dim fldDefCode As New GridViewTextBoxColumn
        fldDefCode.HeaderText = "Defective Code"
        fldDefCode.FieldName = "fldDefCode"
        fldDefCode.TextAlignment = ContentAlignment.MiddleCenter
        fldDefCode.MinWidth = 100
        gvDataD.Columns.Add(fldDefCode)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 120
        gvDataD.Columns.Add(fldPartName)

        Dim fldMan As New GridViewTextBoxColumn
        fldMan.HeaderText = "Man"
        fldMan.FieldName = "fldMan"
        fldMan.TextAlignment = ContentAlignment.MiddleCenter
        fldMan.MinWidth = 70
        gvDataD.Columns.Add(fldMan)

        Dim fldMachine As New GridViewTextBoxColumn
        fldMachine.HeaderText = "Machine"
        fldMachine.FieldName = "fldMachine"
        fldMachine.TextAlignment = ContentAlignment.MiddleCenter
        fldMachine.MinWidth = 70
        gvDataD.Columns.Add(fldMachine)

        Dim fldIM As New GridViewTextBoxColumn
        fldIM.HeaderText = "IM"
        fldIM.FieldName = "fldIM"
        fldIM.TextAlignment = ContentAlignment.MiddleCenter
        fldIM.MinWidth = 70
        gvDataD.Columns.Add(fldIM)

        Dim fldFFC As New GridViewTextBoxColumn
        fldFFC.HeaderText = "FFC"
        fldFFC.FieldName = "fldFFC"
        fldFFC.TextAlignment = ContentAlignment.MiddleCenter
        fldFFC.MinWidth = 70
        gvDataD.Columns.Add(fldFFC)

        Dim fldSubAssy As New GridViewTextBoxColumn
        fldSubAssy.HeaderText = "Sub-Assy"
        fldSubAssy.FieldName = "fldSubAssy"
        fldSubAssy.TextAlignment = ContentAlignment.MiddleCenter
        fldSubAssy.MinWidth = 70
        gvDataD.Columns.Add(fldSubAssy)

        Dim fldRM As New GridViewTextBoxColumn
        fldRM.HeaderText = "RM"
        fldRM.FieldName = "fldRM"
        fldRM.TextAlignment = ContentAlignment.MiddleCenter
        fldRM.MinWidth = 70
        gvDataD.Columns.Add(fldRM)

        gvDataD.MasterTemplate.BestFitColumns()
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        Dim result As Integer = RadMessageBox.Show("Are you sure you want to save?", "Yes or No?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            cbbClear.Enabled = False
            cbbSave.Enabled = False
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim CheckExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & "")
        If CheckExist.Rows.Count >= 1 Then
            Maria.MyQuery("Delete From tblDailyReportSRCInProcDefect where fldDRID=" & globalVariables.DailyRepID & "")
        End If
        For ascii = 65 To 68

            If Chr(ascii) = "A" Then
                For rowcounter As Integer = 0 To Me.gvDataA.Rows.Count - 1
                    Try
                        Dim parDRID As Integer = globalVariables.DailyRepID
                        Dim parDefCode As String = If(IsDBNull(gvDataA.Rows(rowcounter).Cells("fldDefCode").Value), "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldDefCode").Value, String))
                        Dim parPartName As String = If(IsDBNull(gvDataA.Rows(rowcounter).Cells("fldPartName").Value), "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldPartName").Value, String))
                        Dim parMan As String = If(IsDBNull(gvDataA.Rows(rowcounter).Cells("fldMan").Value), "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldMan").Value, String))
                        Dim parMachine As String = If(IsDBNull(gvDataA.Rows(rowcounter).Cells("fldMachine").Value), "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldMachine").Value, String))
                        Dim parIM As String = If(IsDBNull(gvDataA.Rows(rowcounter).Cells("fldIM").Value), "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldIM").Value, String))
                        Dim parFFC As String = If(IsDBNull(gvDataA.Rows(rowcounter).Cells("fldFFC").Value), "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldFFC").Value, String))
                        Dim parSubAssy As String = If(IsDBNull(gvDataA.Rows(rowcounter).Cells("fldSubAssy").Value), "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldSubAssy").Value, String))
                        Dim parRM As String = If(IsDBNull(gvDataA.Rows(rowcounter).Cells("fldRM").Value), "", DirectCast(gvDataA.Rows(rowcounter).Cells("fldRM").Value, String))
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
                        Dim RowCount As Integer = gvDataA.Rows.Count
                        rowIndex = rowcounter
                        CurrTable = Chr(ascii)
                        Dim percent As Double = (rowcounter / RowCount * 100)
                        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
                    Catch ex As Exception
                        RadMessageBox.Show(ex.Message)
                        Maria.Connection.Close()

                        cbbClear.Enabled = True
                        cbbSave.Enabled = True
                    End Try

                Next
            ElseIf Chr(ascii) = "B" Then
                For rowcounter As Integer = 0 To Me.gvDataB.Rows.Count - 1
                    Try
                        Dim parDRID As Integer = globalVariables.DailyRepID
                        Dim parDefCode As String = If(IsDBNull(gvDataB.Rows(rowcounter).Cells("fldDefCode").Value), "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldDefCode").Value, String))
                        Dim parPartName As String = If(IsDBNull(gvDataB.Rows(rowcounter).Cells("fldPartName").Value), "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldPartName").Value, String))
                        Dim parMan As String = If(IsDBNull(gvDataB.Rows(rowcounter).Cells("fldMan").Value), "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldMan").Value, String))
                        Dim parMachine As String = If(IsDBNull(gvDataB.Rows(rowcounter).Cells("fldMachine").Value), "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldMachine").Value, String))
                        Dim parIM As String = If(IsDBNull(gvDataB.Rows(rowcounter).Cells("fldIM").Value), "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldIM").Value, String))
                        Dim parFFC As String = If(IsDBNull(gvDataB.Rows(rowcounter).Cells("fldFFC").Value), "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldFFC").Value, String))
                        Dim parSubAssy As String = If(IsDBNull(gvDataB.Rows(rowcounter).Cells("fldSubAssy").Value), "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldSubAssy").Value, String))
                        Dim parRM As String = If(IsDBNull(gvDataB.Rows(rowcounter).Cells("fldRM").Value), "", DirectCast(gvDataB.Rows(rowcounter).Cells("fldRM").Value, String))
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
                        Dim RowCount As Integer = gvDataB.Rows.Count
                        rowIndex = rowcounter
                        CurrTable = Chr(ascii)
                        Dim percent As Double = (rowcounter / RowCount * 100)
                        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
                    Catch ex As Exception
                        RadMessageBox.Show(ex.Message)
                        Maria.Connection.Close()

                        cbbClear.Enabled = True
                        cbbSave.Enabled = True
                    End Try


                Next
            ElseIf Chr(ascii) = "C" Then
                For rowcounter As Integer = 0 To Me.gvDataC.Rows.Count - 1
                    Try
                        Dim parDRID As Integer = globalVariables.DailyRepID
                        Dim parDefCode As String = If(IsDBNull(gvDataC.Rows(rowcounter).Cells("fldDefCode").Value), "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldDefCode").Value, String))
                        Dim parPartName As String = If(IsDBNull(gvDataC.Rows(rowcounter).Cells("fldPartName").Value), "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldPartName").Value, String))
                        Dim parMan As String = If(IsDBNull(gvDataC.Rows(rowcounter).Cells("fldMan").Value), "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldMan").Value, String))
                        Dim parMachine As String = If(IsDBNull(gvDataC.Rows(rowcounter).Cells("fldMachine").Value), "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldMachine").Value, String))
                        Dim parIM As String = If(IsDBNull(gvDataC.Rows(rowcounter).Cells("fldIM").Value), "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldIM").Value, String))
                        Dim parFFC As String = If(IsDBNull(gvDataC.Rows(rowcounter).Cells("fldFFC").Value), "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldFFC").Value, String))
                        Dim parSubAssy As String = If(IsDBNull(gvDataC.Rows(rowcounter).Cells("fldSubAssy").Value), "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldSubAssy").Value, String))
                        Dim parRM As String = If(IsDBNull(gvDataC.Rows(rowcounter).Cells("fldRM").Value), "", DirectCast(gvDataC.Rows(rowcounter).Cells("fldRM").Value, String))
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
                        Dim RowCount As Integer = gvDataC.Rows.Count
                        rowIndex = rowcounter
                        CurrTable = Chr(ascii)
                        Dim percent As Double = (rowcounter / RowCount * 100)
                        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
                    Catch ex As Exception
                        RadMessageBox.Show(ex.Message)
                        Maria.Connection.Close()

                        cbbClear.Enabled = True
                        cbbSave.Enabled = True
                    End Try


                Next
            ElseIf Chr(ascii) = "D" Then
                For rowcounter As Integer = 0 To Me.gvDataD.Rows.Count - 1
                    Try
                        Dim parDRID As Integer = globalVariables.DailyRepID
                        Dim parDefCode As String = If(IsDBNull(gvDataD.Rows(rowcounter).Cells("fldDefCode").Value), "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldDefCode").Value, String))
                        Dim parPartName As String = If(IsDBNull(gvDataD.Rows(rowcounter).Cells("fldPartName").Value), "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldPartName").Value, String))
                        Dim parMan As String = If(IsDBNull(gvDataD.Rows(rowcounter).Cells("fldMan").Value), "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldMan").Value, String))
                        Dim parMachine As String = If(IsDBNull(gvDataD.Rows(rowcounter).Cells("fldMachine").Value), "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldMachine").Value, String))
                        Dim parIM As String = If(IsDBNull(gvDataD.Rows(rowcounter).Cells("fldIM").Value), "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldIM").Value, String))
                        Dim parFFC As String = If(IsDBNull(gvDataD.Rows(rowcounter).Cells("fldFFC").Value), "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldFFC").Value, String))
                        Dim parSubAssy As String = If(IsDBNull(gvDataD.Rows(rowcounter).Cells("fldSubAssy").Value), "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldSubAssy").Value, String))
                        Dim parRM As String = If(IsDBNull(gvDataD.Rows(rowcounter).Cells("fldRM").Value), "", DirectCast(gvDataD.Rows(rowcounter).Cells("fldRM").Value, String))
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
                        Dim RowCount As Integer = gvDataD.Rows.Count
                        rowIndex = rowcounter
                        CurrTable = Chr(ascii)
                        Dim percent As Double = (rowcounter / RowCount * 100)
                        BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))

                    Catch ex As Exception
                        RadMessageBox.Show(ex.Message)
                        Maria.Connection.Close()

                        cbbClear.Enabled = True
                        cbbSave.Enabled = True
                    End Try

                Next

            End If

        Next
        Try
            Maria.MyQuery("Insert Into tblDailyReportSRCInProcDefect(fldDRID,fldDefCode,fldCateg,fldVal)values(" & globalVariables.DailyRepID & ",'D. Defective Quantity. (pcs)','None'," & spnDefectQty.Value & ")")
            Maria.MyQuery("Insert Into tblDailyReportSRCInProcDefect(fldDRID,fldDefCode,fldCateg,fldVal)values(" & globalVariables.DailyRepID & ",'C: Total Production Output','None'," & spnTotalProd.Value & ")")
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
            Maria.Connection.Close()

            cbbClear.Enabled = True
            cbbSave.Enabled = True
        End Try

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If CurrTable = "A" Then
            gvDataA.CurrentRow = gvDataA.Rows(rowIndex)
        ElseIf CurrTable = "B" Then
            gvDataB.CurrentRow = gvDataB.Rows(rowIndex)
        ElseIf CurrTable = "C" Then
            gvDataC.CurrentRow = gvDataC.Rows(rowIndex)
        ElseIf CurrTable = "D" Then
            gvDataD.CurrentRow = gvDataD.Rows(rowIndex)
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        RadMessageBox.Show("Done!")

        cbbClear.Enabled = True
        cbbSave.Enabled = True
    End Sub

    Private Sub cbbClear_Click(sender As Object, e As EventArgs) Handles cbbClear.Click
        Dim result As Integer = RadMessageBox.Show("Are you sure you want to clear the inputs?", "Yes or No?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            gvDataA.DataSource = Nothing
            gvDataB.DataSource = Nothing
            gvDataC.DataSource = Nothing
            gvDataD.DataSource = Nothing

            spnDefectQty.Value = 0
            spnTotalProd.Value = 0

            gvDataA.Rows.Add("Torque Error")
            gvDataA.Rows.Add("Weld Error")

            gvDataB.Rows.Add("I/R Error")
            gvDataB.Rows.Add("Mis-Insertion")
            gvDataB.Rows.Add("Pattern Error")
            gvDataB.Rows.Add("Pattern Open")
            gvDataB.Rows.Add("Pattern Short")
            gvDataB.Rows.Add("Shortbar")
        End If


    End Sub

    Private Sub spnDefectQty_ValueChanging(sender As Object, e As ValueChangingEventArgs) Handles spnDefectQty.ValueChanging
        If spnTotalProd.Value = 0 Then
            spnDefectPPM.Value = 0.00
        Else
            spnDefectPPM.Value = spnDefectQty.Value / spnTotalProd.Value
        End If
    End Sub

    Private Sub spnTotalProd_ValueChanging(sender As Object, e As ValueChangingEventArgs) Handles spnTotalProd.ValueChanging
        If spnTotalProd.Value = 0 Then
            spnDefectPPM.Value = 0.00
        Else
            spnDefectPPM.Value = spnDefectQty.Value / spnTotalProd.Value
        End If
    End Sub
End Class
