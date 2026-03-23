Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmCACostTable

    Private dtFormula As DataTable
    Private Sub FrmCACostTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadProcess()
        loadFormulaIndicator()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        gvData.Columns.Add(fldId)

        Dim fldProcessCode As New GridViewTextBoxColumn("PROCESS CODE")
        fldProcessCode.FieldName = "fldProcessCode"
        fldProcessCode.IsVisible = False
        fldProcessCode.ReadOnly = True
        gvData.Columns.Add(fldProcessCode)

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 250
        fldProcessName.ReadOnly = True
        gvData.Columns.Add(fldProcessName)

        Dim fldSectionNumber As New GridViewDecimalColumn("SECTION")
        fldSectionNumber.FieldName = "fldSectionNumber"
        fldSectionNumber.Width = 80
        fldSectionNumber.TextAlignment = ContentAlignment.MiddleCenter
        fldSectionNumber.ReadOnly = True
        gvData.Columns.Add(fldSectionNumber)

        Dim fldGroup As New GridViewDecimalColumn("GROUP")
        fldGroup.FieldName = "fldGroup"
        fldGroup.Width = 60
        fldGroup.TextAlignment = ContentAlignment.MiddleCenter
        fldGroup.ShowUpDownButtons = False
        gvData.Columns.Add(fldGroup)

        Dim formula As New GridViewTextBoxColumn("FORMULA")
        formula.FieldName = "formula"
        formula.Width = 200
        formula.ReadOnly = True
        gvData.Columns.Add(formula)

        Dim fldSort As New GridViewDecimalColumn("SORT")
        fldSort.FieldName = "fldSort"
        fldSort.Width = 60
        fldSort.IsVisible = False
        fldSort.ShowUpDownButtons = False
        gvData.Columns.Add(fldSort)

        Dim fldDelete As New GridViewCommandColumn("DELETE")
        fldDelete.FieldName = "fldDelete"
        fldDelete.Width = 70
        fldDelete.TextAlignment = ContentAlignment.MiddleCenter
        fldDelete.UseDefaultText = True
        fldDelete.DefaultText = "Delete"
        gvData.Columns.Add(fldDelete)

        AddHandler gvData.CommandCellClick, AddressOf deleteRecord

        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.ShowGroupPanel = False
        gvData.ShowFilteringRow = False

    End Sub

    Private Sub loadProcess()

        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllProcess")

        Dim fldProcessName As New GridViewTextBoxColumn("PROCESS NAME")
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.Width = 310
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldProcessName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        mcbProcess.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbProcess.DataSource = dtProcess
        mcbProcess.ValueMember = "fldCode"
        mcbProcess.DisplayMember = "fldProcessName"
        mcbProcess.MultiColumnComboBoxElement.DropDownWidth = 380

        mcbProcess.AutoFilter = True
        mcbProcess.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim processName As New FilterDescriptor()
        processName.PropertyName = "fldProcessName"
        processName.Operator = FilterOperator.Contains
        mcbProcess.EditorControl.MasterTemplate.FilterDescriptors.Add(processName)

    End Sub

    Private Sub loadFormulaIndicator()

        'Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldId, fldCode, fldInhouse, fldOutSide, CONCAT(fldInHouse, ' - In House, ', fldOutSide, ' - Outside') AS formulaIndicator FROM tblFormulaIndicator")

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 100
        mcbFormulaIndicator.MultiColumnComboBoxElement.Columns.Add(fldCode)

        Dim formulaIndicator As New GridViewTextBoxColumn("FORMULA INDICATOR")
        formulaIndicator.FieldName = "formulaIndicator"
        formulaIndicator.Width = 200
        mcbFormulaIndicator.MultiColumnComboBoxElement.Columns.Add(formulaIndicator)

        'mcbFormulaIndicator.DataSource = dtFormula
        mcbFormulaIndicator.ValueMember = "fldCode"
        mcbFormulaIndicator.DisplayMember = "formulaIndicator"
        mcbFormulaIndicator.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbFormulaIndicator.AutoFilter = True
        mcbFormulaIndicator.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim filter As New FilterDescriptor()
        filter.PropertyName = "formulaIndicator"
        filter.Operator = FilterOperator.Contains
        mcbFormulaIndicator.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)

    End Sub

    Private Sub loadRecord()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                     & "T0.fldTitle, " _
                                                     & "T0.fldItemCode, " _
                                                     & "T0.fldCustomerPartNo, " _
                                                     & "T0.fldCustomerCode, " _
                                                     & "T0.fldYear, " _
                                                     & "T0.fldDateEffect, " _
                                                     & "(SELECT fldPartName FROM tblItemMasterData WHERE fldItemCode = (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldItemCode LIMIT 1) LIMIT 1) AS partName, " _
                                                     & "(SELECT fldCustomerPartNo FROM tblItemMasterPerCustomer WHERE fldItemCode = (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldItemCode LIMIT 1) LIMIT 1) AS customerPartNo, " _
                                                     & "(SELECT fldCustomerName FROM tblCustomer WHERE fldCustomerCode = T0.fldCustomerCode LIMIT 1) AS customer " _
                                                     & "FROM tblCostTableMain T0 " _
                                                     & "WHERE T0.fldId = " & txtId.Text & " ")

        If dt.Rows.Count > 0 Then

            txtTitle.Text = Convert.ToString(dt.Rows(0).Item("fldTitle"))
            txtItemCode.Text = Convert.ToString(dt.Rows(0).Item("fldItemCode"))
            txtPartName.Text = Convert.ToString(dt.Rows(0).Item("partName"))
            txtCustomerPartNo.Text = Convert.ToString(dt.Rows(0).Item("customerPartNo"))
            txtCustomer.Text = Convert.ToString(dt.Rows(0).Item("customer"))
            txtYear.Text = Convert.ToDateTime(dt.Rows(0).Item("fldYear")).ToString("yyyy")
            txtDateEffect.Text = Convert.ToDateTime(dt.Rows(0).Item("fldDateEffect"))

        End If

    End Sub

    Private Sub FrmCACostTable_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        loadRecord()

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnOpenEditor_Click(sender As Object, e As EventArgs) Handles btnOpenEditor.Click
        If Slipknot.IsFormOpen(FrmCostTableEditor) Then
            FrmCostTableEditor.Focus()
        Else
            FrmCostTableEditor.txtId.Text = txtId.Text
            FrmCostTableEditor.Show()
        End If

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If mcbProcess.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select process properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If ddSection.Text = String.Empty Then
            RadMessageBox.Show("Please select section", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parCTID", txtId.Text)
        Slipknot.addParameter("parProcessCode", mcbProcess.SelectedValue)
        Slipknot.addParameter("parSectionNumber", ddSection.Text)

        If ddSection.Text = 2 Then

            Slipknot.addParameter("parGroup", seGroup.Value)
            Slipknot.addParameter("parFormulaCode", mcbFormulaIndicator.SelectedValue)

        ElseIf ddSection.Text = 1 Then

            Slipknot.addParameter("parGroup", DBNull.Value)
            Slipknot.addParameter("parFormulaCode", DBNull.Value)

        Else

            Slipknot.addParameter("parGroup", DBNull.Value)
            Slipknot.addParameter("parFormulaCode", mcbFormulaIndicator.SelectedValue)

        End If

        If Slipknot.dbAED("SP_InsertCTSection") Then
            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If
        End If


    End Sub

    Private myData As DataTable
    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        Slipknot.addParameter("parCTID", txtId.Text)
        myData = Slipknot.dbSelect("SP_SelectCTSectionByCTID")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub gvData_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellEndEdit

        If Convert.ToString(gvData.CurrentRow.Cells("fldGroup").Value) <> String.Empty Then

            Slipknot.addParameter("parId", Convert.ToString(gvData.CurrentRow.Cells("fldId").Value))
            Slipknot.addParameter("parSort", Convert.ToDecimal(gvData.CurrentRow.Cells("fldSort").Value))
            Slipknot.addParameter("parGroup", Convert.ToDecimal(gvData.CurrentRow.Cells("fldGroup").Value))

            Slipknot.dbAED("SP_UpdateCostTableSort")

        End If

    End Sub

    Private Function getOrigPartNo(ByVal partNo As String) As String

        getOrigPartNo = partNo

        Dim row As DataRow = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & partNo & "' LIMIT 1 ")

        If row IsNot Nothing Then
            getOrigPartNo = Convert.ToString(row.Item("fldItemCode"))

            Return getOrigPartNo
            Exit Function
        End If

        Return getOrigPartNo
    End Function

    Private Sub deleteRecord(ByVal sender As Object, ByVal e As EventArgs)

        Dim result As DialogResult = RadMessageBox.Show(Me, "Please confirm to delete Process Section.", "Deleting", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then

            Slipknot.addParameter("id", gvData.CurrentRow.Cells("fldId").Value)
            If Slipknot.dbAED("SP_DeleteCTSection") Then
                gvData.CurrentRow.Delete()
            End If

        End If

    End Sub

    Private Sub btnConstructNow_Click(sender As Object, e As EventArgs) Handles btnConstructNow.Click

        'GET THE BOM OF THE ITEM
        Dim dtBOM As DataTable = AsILayDying.GetBOM(txtItemCode.Text)

        'CONSTRACT SECTION 1
        Dim result = (From T0 In dtBOM.AsEnumerable
                      Select New With
                      {
                          .fldParentCode = T0("fldParentCode"),
                          .fldChildCode = T0("fldChildCode"),
                          .fldUsage = T0("fldUsage"),
                          .origParentPartNo = getOrigPartNo(.fldParentCode),
                          .origChildPartNo = getOrigPartNo(.fldChildCode)
                      }).ToList

        Dim dtBOMWithOrigPartNo As DataTable = Slipknot.convertToDatatable(result)

        Dim dtItemPerprocess As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblItemProcess")
        RadGridView1.DataSource = dtItemPerprocess
        Dim result2 = (From T0 In dtBOMWithOrigPartNo.AsEnumerable
                       Group Join T1 In dtItemPerprocess.AsEnumerable
                       On T0.Field(Of String)("origParentPartNo") Equals T1.Field(Of String)("fldItemCode")
                       Into G1 = Group
                       From myGroup In G1.DefaultIfEmpty
                       Select New With
                          {
                            .fldParentCode = T0("fldParentCode"),
                            .fldChildCode = T0("fldChildCode"),
                            .fldUsage = T0("fldUsage"),
                            .origParentPartNo = T0("origParentPartNo"),
                            .parentProcessCode = Convert.ToString(myGroup?("fldProcessCode")),
                            .origChildPartNo = T0("origChildPartNo")
                          }).ToList

        Dim dtBOMWithParentProcess As DataTable = Slipknot.convertToDatatable(result2)

        Dim dtSection1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCTSection WHERE fldCTID = '" & txtId.Text & "' AND fldSectionNumber = 1")

        For Each row As DataRow In dtSection1.Rows

            Dim MHhr As Decimal = 0
            Dim MThr As Decimal = 0

            Dim getMHMT As DataRow = Slipknot.rowSelectManual("SELECT fldMH, fldMT FROM tblUnitPriceOfMTMH WHERE fldProcessCode = '" & Convert.ToString(row.Item("fldProcessCode")) & "' ")

            If getMHMT IsNot Nothing Then
                MHhr = Convert.ToDecimal(getMHMT.Item("fldMH"))
                MThr = Convert.ToDecimal(getMHMT.Item("fldMT"))
            End If

            Dim resultSec1 = (From T0 In dtBOMWithParentProcess.AsEnumerable
                              Where T0.Field(Of String)("parentProcessCode") = Convert.ToString(row.Item("fldProcessCode"))
                              Select New With
                                   {
                                   .fldParentCode = T0("fldParentCode")
                                   }).ToList

            Dim dtResultSec1 As DataTable = Slipknot.convertToDatatable(resultSec1)

            Dim specs As DataRow
            Dim Cavity As Decimal
            Dim PartWeight As Decimal
            Dim RunnerWeight As Decimal
            Dim Loss As Decimal
            Dim UnitPrice As Decimal
            Dim Collection As Decimal
            Dim CycleTime As Decimal

            For Each row2 As DataRow In dtResultSec1.Rows

                Cavity = 0
                PartWeight = 0
                RunnerWeight = 0
                Loss = 0
                UnitPrice = 0
                Collection = 0
                CycleTime = 0

                specs = AsILayDying.getItemSpecs(Convert.ToString(row2.Item("fldParentCode")), Convert.ToDateTime(txtDateEffect.Text))

                If specs IsNot Nothing Then
                    Cavity = Convert.ToDecimal(specs.Item("fldCav"))
                    PartWeight = Convert.ToDecimal(specs.Item("fldPartWeight"))
                    RunnerWeight = Convert.ToDecimal(specs.Item("fldRunnerWeight"))
                    Loss = Convert.ToDecimal(specs.Item("fldLoss"))
                    Collection = Convert.ToDecimal(specs.Item("fldCollection"))
                    CycleTime = Convert.ToDecimal(specs.Item("fldCycleTime"))
                End If

                Slipknot.addParameter("parCTID", txtId.Text)
                Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("fldProcessCode")))
                Slipknot.addParameter("parItemCode", Convert.ToString(row2.Item("fldParentCode")))
                Slipknot.addParameter("parCavity", Cavity)
                Slipknot.addParameter("parPartWeight", PartWeight)
                Slipknot.addParameter("parRunnerWeight", RunnerWeight)
                Slipknot.addParameter("parLoss", Loss)
                Slipknot.addParameter("parUnitPrice", UnitPrice)
                Slipknot.addParameter("parCollection", Collection)
                Slipknot.addParameter("parCycleTime", CycleTime)
                Slipknot.addParameter("parMHHr", MHhr)
                Slipknot.addParameter("parMTHr", MThr)

                If IsDBNull(row.Item("fldGroup")) Then
                    Slipknot.addParameter("parGroup", DBNull.Value)
                Else
                    Slipknot.addParameter("parGroup", Convert.ToInt32(row.Item("fldGroup")))
                End If

                Slipknot.dbAED("SP_UpdateCTProcess1Cons")

            Next

            For Each row2 As DataRow In dtResultSec1.Rows

                Cavity = 0
                PartWeight = 0
                RunnerWeight = 0
                Loss = 0
                UnitPrice = 0
                Collection = 0
                CycleTime = 0

                specs = AsILayDying.getItemSpecs(Convert.ToString(row2.Item("fldParentCode")), Convert.ToDateTime(txtDateEffect.Text))

                If specs IsNot Nothing Then
                    Cavity = Convert.ToDecimal(specs.Item("fldCav"))
                    PartWeight = Convert.ToDecimal(specs.Item("fldPartWeight"))
                    RunnerWeight = Convert.ToDecimal(specs.Item("fldRunnerWeight"))
                    Loss = Convert.ToDecimal(specs.Item("fldLoss"))
                    Collection = Convert.ToDecimal(specs.Item("fldCollection"))
                    CycleTime = Convert.ToDecimal(specs.Item("fldCycleTime"))
                End If

                UnitPrice = AsILayDying.getUnitPriceJPY(Convert.ToString(row2.Item("fldParentCode")), Convert.ToDateTime(txtDateEffect.Text))

                Slipknot.addParameter("parCTID", txtId.Text)
                Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("fldProcessCode")))
                Slipknot.addParameter("parItemCode", Convert.ToString(row2.Item("fldParentCode")))
                Slipknot.addParameter("parCavity", Cavity)
                Slipknot.addParameter("parPartWeight", PartWeight)
                Slipknot.addParameter("parRunnerWeight", RunnerWeight)
                Slipknot.addParameter("parLoss", Loss)
                Slipknot.addParameter("parUnitPrice", UnitPrice)
                Slipknot.addParameter("parCollection", Collection)
                Slipknot.addParameter("parCycleTime", CycleTime)
                Slipknot.addParameter("parMHHr", MHhr)
                Slipknot.addParameter("parMTHr", MThr)

                If IsDBNull(row.Item("fldGroup")) Then
                    Slipknot.addParameter("parGroup", DBNull.Value)
                Else
                    Slipknot.addParameter("parGroup", Convert.ToInt32(row.Item("fldGroup")))
                End If

                Slipknot.dbAED("SP_InsertCTProcessS1")

            Next

        Next

        Slipknot.addParameter("parCTID", txtId.Text)
        Slipknot.dbAED("SP_FinishReConstractCTProcessS1")

        'CONSTRUCT SECTION 2
        Dim dtSection2 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCTSection WHERE fldCTID = '" & txtId.Text & "' AND fldSectionNumber = 2")

        For Each row As DataRow In dtSection2.Rows

            Dim resultSec2 = (From T0 In dtBOMWithParentProcess.AsEnumerable
                              Where T0.Field(Of String)("parentProcessCode") = Convert.ToString(row.Item("fldProcessCode"))
                              Select New With
                                   {
                                   .fldChildCode = T0("fldChildCode"),
                                   .fldUsage = T0("fldUsage")
                                   }).ToList

            Dim dtResultSec2 As DataTable = Slipknot.convertToDatatable(resultSec2)

            Dim specs As DataRow
            Dim Loss As Decimal
            Dim origUnitPrice As Decimal
            Dim JPYunitPrice As Decimal

            For Each row2 As DataRow In dtResultSec2.Rows

                specs = AsILayDying.getItemSpecs(Convert.ToString(row2.Item("fldChildCode")), Convert.ToDateTime(txtDateEffect.Text))

                If specs IsNot Nothing Then
                    Loss = Convert.ToDecimal(specs.Item("fldLoss"))
                End If

                origUnitPrice = AsILayDying.getOrigUnitPrice(Convert.ToString(row2.Item("fldChildCode")), Convert.ToDateTime(txtDateEffect.Text))

                JPYunitPrice = AsILayDying.getUnitPriceJPY(Convert.ToString(row2.Item("fldChildCode")), Convert.ToDateTime(txtDateEffect.Text))

                Slipknot.addParameter("parCTID", txtId.Text)
                Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("fldProcessCode")))
                Slipknot.addParameter("parItemCode", Convert.ToString(row2.Item("fldChildCode")))
                Slipknot.addParameter("parUsage", Convert.ToString(row2.Item("fldUsage")))
                Slipknot.addParameter("parAtJapan", origUnitPrice)
                Slipknot.addParameter("parLoss", Loss)
                Slipknot.addParameter("parUnitPrice", JPYunitPrice)
                Slipknot.addParameter("parGroup", Convert.ToInt32(row.Item("fldGroup")))
                Slipknot.addParameter("parFormulaCode", Convert.ToString(row.Item("fldFormulaCode")))

                Slipknot.dbAED("SP_UpdateCTMaterialCons")

            Next

            For Each row2 As DataRow In dtResultSec2.Rows

                specs = AsILayDying.getItemSpecs(Convert.ToString(row2.Item("fldChildCode")), Convert.ToDateTime(txtDateEffect.Text))

                If specs IsNot Nothing Then
                    Loss = Convert.ToDecimal(specs.Item("fldLoss"))
                End If

                origUnitPrice = AsILayDying.getOrigUnitPrice(Convert.ToString(row2.Item("fldChildCode")), Convert.ToDateTime(txtDateEffect.Text))

                JPYunitPrice = AsILayDying.getUnitPriceJPY(Convert.ToString(row2.Item("fldChildCode")), Convert.ToDateTime(txtDateEffect.Text))

                Slipknot.addParameter("parCTID", txtId.Text)
                Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("fldProcessCode")))
                Slipknot.addParameter("parUsage", Convert.ToString(row2.Item("fldUsage")))
                Slipknot.addParameter("parAtJapan", origUnitPrice)
                Slipknot.addParameter("parLoss", Loss)
                Slipknot.addParameter("parUnitPrice", JPYunitPrice)
                Slipknot.addParameter("parItemCode", Convert.ToString(row2.Item("fldChildCode")))
                Slipknot.addParameter("parGroup", Convert.ToInt32(row.Item("fldGroup")))
                Slipknot.addParameter("parFormulaCode", Convert.ToString(row.Item("fldFormulaCode")))

                Slipknot.dbAED("SP_InsertCTMaterial")

            Next

        Next

        Slipknot.addParameter("parCTID", txtId.Text)
        Slipknot.dbAED("SP_FinishReConstractCTMaterial")

        'CONSTRACT SECTION 3
        Dim dtSection3 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCTSection WHERE fldCTID = '" & txtId.Text & "' AND fldSectionNumber = 3")

        For Each row As DataRow In dtSection3.Rows

            Dim MHhr As Decimal = 0
            Dim MThr As Decimal = 0

            Dim getMHMT As DataRow = Slipknot.rowSelectManual("SELECT fldMH, fldMT FROM tblUnitPriceOfMTMH WHERE fldProcessCode = '" & Convert.ToString(row.Item("fldProcessCode")) & "' ")

            If getMHMT IsNot Nothing Then
                MHhr = Convert.ToDecimal(getMHMT.Item("fldMH"))
                MThr = Convert.ToDecimal(getMHMT.Item("fldMT"))
            End If

            Dim checkPreset As DataRow = Slipknot.rowSelectManual("SELECT fldProcessCode FROM tblProcessingFeePreset WHERE fldProcessCode = '" & Convert.ToString(row.Item("fldProcessCode")) & "' LIMIT 1")

            If checkPreset Is Nothing Then

                Dim resultSec3 = (From T0 In dtBOMWithParentProcess.AsEnumerable
                                  Where T0.Field(Of String)("parentProcessCode") = Convert.ToString(row.Item("fldProcessCode"))
                                  Group By Keys = New With {
                                     Key .myCode = T0.Field(Of String)("fldParentCode")
                                        } Into TG = Group
                                  Select New With
                                      {
                                      .fldParentCode = Keys.myCode
                                      }).ToList

                Dim dtResultSec3 As DataTable = Slipknot.convertToDatatable(resultSec3)

                For Each row2 As DataRow In dtResultSec3.Rows

                    Slipknot.addParameter("parCTID", txtId.Text)
                    Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("fldProcessCode")))
                    Slipknot.addParameter("parItemCode", Convert.ToString(row2.Item("fldParentCode")))
                    Slipknot.addParameter("parFormulaCode", Convert.ToString(row.Item("fldFormulaCode")))
                    Slipknot.addParameter("parMhHr", MHhr)
                    Slipknot.addParameter("parMtHr", MThr)
                    Slipknot.addParameter("parPreset", False)

                    Slipknot.dbAED("SP_UpdateCTProcessingFeeCons")

                Next

                For Each row2 As DataRow In dtResultSec3.Rows

                    Slipknot.addParameter("parCTID", txtId.Text)
                    Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("fldProcessCode")))
                    Slipknot.addParameter("parItemCode", Convert.ToString(row2.Item("fldParentCode")))
                    Slipknot.addParameter("parFormulaCode", Convert.ToString(row.Item("fldFormulaCode")))
                    Slipknot.addParameter("parMhHr", MHhr)
                    Slipknot.addParameter("parMtHr", MThr)
                    Slipknot.addParameter("parPreset", False)

                    Slipknot.dbAED("SP_InsertCTProcessingFee")

                Next

            Else

                Dim dtProcess As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblProcessingFeePreset WHERE fldProcessCode = '" & Convert.ToString(row.Item("fldProcessCode")) & "' ")

                For Each row2 As DataRow In dtProcess.Rows

                    Slipknot.addParameter("parCTID", txtId.Text)
                    Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("fldProcessCode")))
                    Slipknot.addParameter("parItemCode", Convert.ToString(row2.Item("fldItem")))
                    Slipknot.addParameter("parFormulaCode", Convert.ToString(row.Item("fldFormulaCode")))
                    Slipknot.addParameter("parMhHr", MHhr)
                    Slipknot.addParameter("parMtHr", MThr)
                    Slipknot.addParameter("parPreset", False)

                    Slipknot.dbAED("SP_UpdateCTProcessingFeeCons")

                Next

                For Each row2 As DataRow In dtProcess.Rows

                    Slipknot.addParameter("parCTID", txtId.Text)
                    Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("fldProcessCode")))
                    Slipknot.addParameter("parItemCode", Convert.ToString(row2.Item("fldItem")))
                    Slipknot.addParameter("parFormulaCode", Convert.ToString(row.Item("fldFormulaCode")))
                    Slipknot.addParameter("parMhHr", MHhr)
                    Slipknot.addParameter("parMtHr", MThr)
                    Slipknot.addParameter("parPreset", True)

                    Slipknot.dbAED("SP_InsertCTProcessingFee")

                Next

            End If

        Next

        Slipknot.addParameter("parCTID", txtId.Text)
        Slipknot.dbAED("SP_DeleteSection4")

        Slipknot.addParameter("parCTID", txtId.Text)
        Slipknot.dbAED("SP_FinishReConstractCTProcessingFee")

        'CONSTRACT SECTION 4
        Dim dtSection4 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCTFormulaSettings")

        For Each row As DataRow In dtSection4.Rows

            Slipknot.addParameter("parCTID", txtId.Text)
            Slipknot.addParameter("parFormula", Convert.ToString(row.Item("fldFormula")))
            Slipknot.addParameter("parName", Convert.ToString(row.Item("fldName")))
            Slipknot.addParameter("parProcess", Convert.ToString(row.Item("fldProcess")))

            Slipknot.dbAED("SP_InsertCTSection4")

        Next

    End Sub

    Dim dtSec1Final As New DataTable
    Dim dtSec2Final As New DataTable
    Dim dtWP As New DataTable
    Private Sub getItemBOM()

        dtSec1Final.Rows.Clear()
        dtSec1Final.Columns.Clear()
        dtSec1Final.Columns.Add("itemCode")
        dtSec1Final.Columns.Add("processCode")

        dtSec2Final.Rows.Clear()
        dtSec2Final.Columns.Clear()
        dtSec2Final.Columns.Add("itemCode")
        dtSec2Final.Columns.Add("processCode")

        dtWP.Rows.Clear()
        dtWP.Columns.Clear()
        dtWP.Columns.Add("itemCode")
        dtWP.Columns.Add("processCode")

        Dim dtFinal As New DataTable

        dtFinal.Columns.Clear()
        dtFinal.Columns.Add("parentCode", GetType(String))
        dtFinal.Columns.Add("childCode", GetType(String))
        dtFinal.Columns.Add("usage", GetType(String))

        Dim dtBOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & txtItemCode.Text & "' ")

        Dim parentCode As String
        Dim childCode As String
        Dim usage As Decimal

        For Each row As DataRow In dtBOM.Rows 'MAIN BOM LOOP SRC ASSEMBLY COMPONENTS

            parentCode = txtItemCode.Text
            childCode = Convert.ToString(row.Item("fldChildCode"))
            usage = Convert.ToDecimal(row.Item("fldUsage"))

            dtFinal.Rows.Add(parentCode, childCode, usage)

            Dim dtLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & childCode & "' ")

            For Each row1 As DataRow In dtLayer1.Rows

                parentCode = childCode
                childCode = Convert.ToString(row1.Item("fldChildCode"))
                usage = Convert.ToDecimal(row1.Item("fldUsage"))

                dtFinal.Rows.Add(parentCode, childCode, usage)

                Dim dtLayer2 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & childCode & "' ")

                For Each row2 As DataRow In dtLayer2.Rows

                    parentCode = childCode
                    childCode = Convert.ToString(row2.Item("fldChildCode"))
                    usage = Convert.ToDecimal(row2.Item("fldUsage"))

                    dtFinal.Rows.Add(parentCode, childCode, usage)

                    Dim dtLayer3 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & childCode & "' ")

                    For Each row3 As DataRow In dtLayer3.Rows

                        parentCode = childCode
                        childCode = Convert.ToString(row3.Item("fldChildCode"))
                        usage = Convert.ToDecimal(row3.Item("fldUsage"))

                        dtFinal.Rows.Add(parentCode, childCode, usage)

                        Dim dtLayer4 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & childCode & "' ")

                        For Each row4 As DataRow In dtLayer4.Rows

                            parentCode = childCode
                            childCode = Convert.ToString(row4.Item("fldChildCode"))
                            usage = Convert.ToDecimal(row4.Item("fldUsage"))

                            dtFinal.Rows.Add(parentCode, childCode, usage)

                            Dim dtLayer5 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & childCode & "' ")

                            For Each row5 As DataRow In dtLayer5.Rows

                                parentCode = childCode
                                childCode = Convert.ToString(row5.Item("fldChildCode"))
                                usage = Convert.ToDecimal(row5.Item("fldUsage"))

                                dtFinal.Rows.Add(parentCode, childCode, usage)

                                Dim dtLayer6 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & childCode & "' ")

                                For Each row6 As DataRow In dtLayer6.Rows

                                    parentCode = childCode
                                    childCode = Convert.ToString(row6.Item("fldChildCode"))
                                    usage = Convert.ToDecimal(row6.Item("fldUsage"))

                                    dtFinal.Rows.Add(parentCode, childCode, usage)

                                    Dim dtLayer7 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & childCode & "' ")

                                    For Each row7 As DataRow In dtLayer7.Rows

                                        parentCode = childCode
                                        childCode = Convert.ToString(row7.Item("fldChildCode"))
                                        usage = Convert.ToDecimal(row7.Item("fldUsage"))

                                        dtFinal.Rows.Add(parentCode, childCode, usage)

                                        Dim dtLayer8 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & childCode & "' ")

                                        For Each row8 As DataRow In dtLayer8.Rows

                                            parentCode = childCode
                                            childCode = Convert.ToString(row8.Item("fldChildCode"))
                                            usage = Convert.ToDecimal(row8.Item("fldUsage"))

                                            dtFinal.Rows.Add(parentCode, childCode, usage)

                                        Next

                                    Next

                                Next

                            Next

                        Next

                    Next

                Next

            Next

        Next

        Dim result = (From T0 In dtFinal.AsEnumerable
                      Group By Keys = New With
                              {
                              Key .childCode = T0.Field(Of String)("childCode")
                              } Into t0G = Group
                      Select New With
                              {
                                  .childCode = Keys.childCode
                              }).ToList

        Dim dtGrouped As DataTable = Slipknot.convertToDatatable(result)

        For Each row As DataRow In dtGrouped.Rows

            If Convert.ToString(row.Item("childCode")).Contains("wp") = True Or Convert.ToString(row.Item("childCode")).Contains("wip") = True Or Convert.ToString(row.Item("childCode")).Contains("WP") = True Or Convert.ToString(row.Item("childCode")).Contains("WIP") = True Then

                Dim code As String = Convert.ToString(row.Item("childCode"))

                Dim dr As DataRow = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & code & "' ")

                If dr IsNot Nothing Then
                    code = Convert.ToString(dr.Item("fldItemCode"))
                End If

                Dim dtProcess As DataTable = Slipknot.dbSelectManual("SELECT fldProcessCode FROM tblItemProcess WHERE fldItemCode = '" & code & "' ")

                For Each pRow As DataRow In dtProcess.Rows

                    dtWP.Rows.Add(Convert.ToString(row.Item("childCode")), Convert.ToString(pRow.Item("fldProcessCode")))

                Next

            End If

        Next

    End Sub

    Private Sub constractSection1()

        Slipknot.addParameter("parCTID", txtId.Text)
        Slipknot.dbAED("SP_DeleteExistingCTProcessS1")

        Dim dtCTSection1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCTSection WHERE fldCTID = '" & txtId.Text & "' AND fldSectionNumber = 1 ")

        For Each row As DataRow In dtCTSection1.Rows

            Dim processCode As String = Convert.ToString(row.Item("fldProcessCode"))

            Dim result2 = (From T0 In dtWP.AsEnumerable
                           Where T0.Field(Of String)("processCode") = processCode
                           Select New With
                                  {
                                    .itemCode = T0.Item("itemCode"),
                                    .processCode = T0.Item("processCode")
                                  }).ToList

            Dim dtSection1 As DataTable = Slipknot.convertToDatatable(result2)

            For Each row2 As DataRow In dtSection1.Rows

                dtSec1Final.Rows.Add(Convert.ToString(row2.Item("itemCode")), Convert.ToString(row2.Item("processCode")))

            Next

        Next

        For Each row As DataRow In dtSec1Final.Rows

            Slipknot.addParameter("parCTID", txtId.Text)
            Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("processCode")))
            Slipknot.addParameter("parItemCode", Convert.ToString(row.Item("itemCode")))

            Slipknot.dbAED("SP_InsertCTProcessS1")

        Next

    End Sub

    Private Sub constractSection2()

        Dim HasSRCAssyProcess As Boolean = False

        Slipknot.addParameter("parCTID", txtId.Text)
        Slipknot.dbAED("SP_DeleteExistingCTMaterial")

        Dim dtCTSection2 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCTSection WHERE fldCTID = '" & txtId.Text & "' AND fldSectionNumber = 2 ")

        For Each row As DataRow In dtCTSection2.Rows

            Dim processCode As String = Convert.ToString(row.Item("fldProcessCode"))

            Dim checkSRCAssy As DataRow = Slipknot.rowSelectManual("SELECT fldProcessName FROM tblProcess WHERE fldCode = '" & processCode & "' ")

            If checkSRCAssy IsNot Nothing Then
                If Convert.ToString(checkSRCAssy.Item("fldProcessName")).Contains("SRC ASSEMBLY") Then
                    HasSRCAssyProcess = True
                End If
            End If

            Dim result2 = (From T0 In dtWP.AsEnumerable
                           Where T0.Field(Of String)("processCode") = processCode
                           Select New With
                                  {
                                    .itemCode = T0.Item("itemCode"),
                                    .processCode = T0.Item("processCode")
                                  }).ToList
            Dim dtSection2 As DataTable = Slipknot.convertToDatatable(result2)

            For Each row2 As DataRow In dtSection2.Rows

                dtSec2Final.Rows.Add(Convert.ToString(row2.Item("itemCode")), Convert.ToString(row2.Item("processCode")))

            Next

        Next

        Dim dtGrouped As New DataTable
        dtGrouped.Columns.Add("itemCode")
        dtGrouped.Columns.Add("processCode")

        For Each row As DataRow In dtSec2Final.Rows

            Dim code As String = Convert.ToString(row.Item("itemCode"))
            Dim pCode As String = Convert.ToString(row.Item("processCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMMaster WHERE fldParentCode = '" & code & "' ")

            For Each row2 As DataRow In dt.Rows

                dtGrouped.Rows.Add(Convert.ToString(row2.Item("fldChildCode")), pCode)

            Next

        Next

        Dim result = (From T0 In dtGrouped.AsEnumerable
                      Group By Keys = New With
                      {
                        Key .itemCode = T0.Field(Of String)("itemCode"),
                        Key .processCode = T0.Field(Of String)("processCode")
                      } Into T0G = Group
                      Select New With
                      {
                      .itemCode = Keys.itemCode,
                      .processCode = Keys.processCode
                      }).ToList

        Dim dtFin As DataTable = Slipknot.convertToDatatable(result)

        For Each row As DataRow In dtFin.Rows

            Slipknot.addParameter("parCTID", txtId.Text)
            Slipknot.addParameter("parProcessCode", Convert.ToString(row.Item("processCode")))
            Slipknot.addParameter("parItemCode", Convert.ToString(row.Item("itemCode")))

            Slipknot.dbAED("SP_InsertCTMaterial")

        Next

        'GATHER SRC ASSEMBLY ITEMS

        If HasSRCAssyProcess Then

            Dim dtBOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & txtItemCode.Text & "' ")

            Dim process As String = ""

            Dim getSRCAssyPCode As DataRow = Slipknot.rowSelectManual("SELECT fldCode FROM tblProcess WHERE fldProcessName LIKE '%SRC ASSEMBLY%' ")

            If getSRCAssyPCode IsNot Nothing Then
                process = Convert.ToString(getSRCAssyPCode.Item("fldCode"))
            End If

            For Each row As DataRow In dtBOM.Rows

                Slipknot.addParameter("parCTID", txtId.Text)
                Slipknot.addParameter("parProcessCode", process)
                Slipknot.addParameter("parItemCode", Convert.ToString(row.Item("fldChildCode")))

                Slipknot.dbAED("SP_InsertCTMaterial")

            Next

        End If

    End Sub

    Private Sub ddSection_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddSection.SelectedIndexChanged
        If ddSection.Text = 2 Then

            dtFormula = Slipknot.dbSelectManual("SELECT fldId, fldCode, fldInhouse, fldOutSide, CONCAT(fldInHouse, ' - In House, ', fldOutSide, ' - Outside') AS formulaIndicator FROM tblFormulaIndicator WHERE fldInHouse IS NOT NULL ")

            mcbFormulaIndicator.DataSource = dtFormula

            lblFormulaIndicator.Visible = True
            mcbFormulaIndicator.Visible = True
            lblGroup.Visible = True
            seGroup.Visible = True

        ElseIf ddSection.Text = 1 Then

            lblFormulaIndicator.Visible = False
            mcbFormulaIndicator.Visible = False
            lblGroup.Visible = False
            seGroup.Visible = False

        Else

            dtFormula = Slipknot.dbSelectManual("SELECT fldId, fldCode, fldInhouse, fldOutSide, fldCode AS formulaIndicator FROM tblFormulaIndicator WHERE fldInHouse IS NULL ")

            mcbFormulaIndicator.DataSource = dtFormula

            lblFormulaIndicator.Visible = True
            mcbFormulaIndicator.Visible = True
            lblGroup.Visible = False
            seGroup.Visible = False

        End If
    End Sub

    Private Sub btnProcessingFeePreset_Click(sender As Object, e As EventArgs) Handles btnProcessingFeePreset.Click

        If Slipknot.IsFormOpen(frmProcessingFeePreset) Then
            frmProcessingFeePreset.Focus()
        Else
            frmProcessingFeePreset.Show()
        End If

    End Sub
End Class
