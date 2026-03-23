Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmLCSCreator

    Private myData As DataTable
    Private dtpFrom As New RadDateTimePicker
    Private dtpTo As New RadDateTimePicker
    Private mcbTemplate As New RadMultiColumnComboBox
    Private Sub FrmLCSCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        cbhFrom.HostedItem = dtpFrom.DateTimePickerElement
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MMM dd, yyyy"
        dtpFrom.Value = Today

        cbhTo.HostedItem = dtpTo.DateTimePickerElement
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.CustomFormat = "MMM dd, yyyy"
        dtpTo.Value = Today

        cbhTemplate.HostedItem = mcbTemplate.MultiColumnComboBoxElement

        loadTemplate()

        readyGrid()
    End Sub

    Private Sub readyGrid()
        Dim fldIdColumn As New GridViewDecimalColumn("ID")
        fldIdColumn.FieldName = "fldId"
        fldIdColumn.IsVisible = False
        fldIdColumn.ReadOnly = True
        gvData.Columns.Add(fldIdColumn)

        Dim fldLCSIDColumn As New GridViewTextBoxColumn("LOT CONTROL SHEET ID")
        fldLCSIDColumn.FieldName = "lcsId"
        fldLCSIDColumn.Width = 170
        fldLCSIDColumn.ReadOnly = True
        gvData.Columns.Add(fldLCSIDColumn)

        Dim fldPartnameColumn As New GridViewTextBoxColumn("PART NAME")
        fldPartnameColumn.FieldName = "fldPartname"
        fldPartnameColumn.Width = 200
        fldPartnameColumn.ReadOnly = True
        gvData.Columns.Add(fldPartnameColumn)

        Dim fldPartNoColumn As New GridViewTextBoxColumn("PART NO.")
        fldPartNoColumn.FieldName = "fldPartNo"
        fldPartNoColumn.Width = 100
        fldPartNoColumn.ReadOnly = True
        gvData.Columns.Add(fldPartNoColumn)

        Dim fldCustomerColumn As New GridViewTextBoxColumn("CUSTOMER")
        fldCustomerColumn.FieldName = "fldCustomer"
        fldCustomerColumn.Width = 90
        fldCustomerColumn.ReadOnly = True
        gvData.Columns.Add(fldCustomerColumn)

        Dim fldPartNoWModelColumn As New GridViewTextBoxColumn("PART NO. W/O MODEL")
        fldPartNoWModelColumn.FieldName = "fldPartNoWoModel"
        fldPartNoWModelColumn.Width = 200
        fldPartNoWModelColumn.ReadOnly = True
        gvData.Columns.Add(fldPartNoWModelColumn)

        Dim fldNoteColumn As New GridViewTextBoxColumn("NOTE")
        fldNoteColumn.FieldName = "fldNote"
        fldNoteColumn.Width = 100
        fldNoteColumn.ReadOnly = True
        gvData.Columns.Add(fldNoteColumn)

        Dim fldLotNoColumn As New GridViewTextBoxColumn("LOT NO.")
        fldLotNoColumn.FieldName = "fldLotNo"
        fldLotNoColumn.Width = 90
        fldLotNoColumn.ReadOnly = True
        gvData.Columns.Add(fldLotNoColumn)

        Dim fldQtyColumn As New GridViewDecimalColumn("QTY")
        fldQtyColumn.FieldName = "fldQty"
        fldQtyColumn.Width = 60
        fldQtyColumn.TextAlignment = ContentAlignment.MiddleRight
        fldQtyColumn.ReadOnly = True
        gvData.Columns.Add(fldQtyColumn)

        Dim fldUomColumn As New GridViewTextBoxColumn("UOM")
        fldUomColumn.FieldName = "fldUom"
        fldUomColumn.Width = 40
        fldUomColumn.ReadOnly = True
        gvData.Columns.Add(fldUomColumn)

        Dim fldFeapCodeColumn As New GridViewTextBoxColumn("FEAP CODE")
        fldFeapCodeColumn.FieldName = "fldFeapCode"
        fldFeapCodeColumn.Width = 100
        fldFeapCodeColumn.ReadOnly = True
        gvData.Columns.Add(fldFeapCodeColumn)

        Dim fldAdditionalInfoColumn As New GridViewTextBoxColumn("ADDITIONAL INFO")
        fldAdditionalInfoColumn.FieldName = "fldAdditionalInfo"
        fldAdditionalInfoColumn.Width = 140
        fldAdditionalInfoColumn.ReadOnly = True
        gvData.Columns.Add(fldAdditionalInfoColumn)

        Dim fldPONUmberColumn As New GridViewTextBoxColumn("PO NUMBER")
        fldPONUmberColumn.FieldName = "fldPONumber"
        fldPONUmberColumn.Width = 100
        fldPONUmberColumn.ReadOnly = True
        gvData.Columns.Add(fldPONUmberColumn)

        Dim fldPartLevelColumn As New GridViewTextBoxColumn("PART LEVEL")
        fldPartLevelColumn.FieldName = "fldPartLevel"
        fldPartLevelColumn.Width = 100
        fldPartLevelColumn.ReadOnly = True
        gvData.Columns.Add(fldPartLevelColumn)

        Dim fldCategoryColumn As New GridViewTextBoxColumn("CATEGORY")
        fldCategoryColumn.FieldName = "category"
        fldCategoryColumn.Width = 100
        fldCategoryColumn.ReadOnly = True
        gvData.Columns.Add(fldCategoryColumn)

        Dim fldEnableLotBDColumn As New GridViewCheckBoxColumn("ENABLE LOT BREAKDOWN")
        fldEnableLotBDColumn.FieldName = "fldEnableLotBreakdown"
        fldEnableLotBDColumn.Width = 120
        fldEnableLotBDColumn.ReadOnly = True
        gvData.Columns.Add(fldEnableLotBDColumn)

        Dim fldLotBD1Column As New GridViewTextBoxColumn("LOT BREAKDOWN 1")
        fldLotBD1Column.FieldName = "fldLotBD1"
        fldLotBD1Column.Width = 100
        fldLotBD1Column.ReadOnly = True
        gvData.Columns.Add(fldLotBD1Column)

        Dim fldLotBD2Column As New GridViewTextBoxColumn("LOT BREAKDOWN 2")
        fldLotBD2Column.FieldName = "fldLotBD2"
        fldLotBD2Column.Width = 100
        fldLotBD2Column.ReadOnly = True
        gvData.Columns.Add(fldLotBD2Column)

        Dim fldLotBD3Column As New GridViewTextBoxColumn("LOT BREAKDOWN 3")
        fldLotBD3Column.FieldName = "fldLotBD3"
        fldLotBD3Column.Width = 100
        fldLotBD3Column.ReadOnly = True
        gvData.Columns.Add(fldLotBD3Column)

        Dim fldLotBD4Column As New GridViewTextBoxColumn("LOT BREAKDOWN 4")
        fldLotBD4Column.FieldName = "fldLotBD4"
        fldLotBD4Column.Width = 100
        fldLotBD4Column.ReadOnly = True
        gvData.Columns.Add(fldLotBD4Column)

        Dim fldLotBDQty1Column As New GridViewDecimalColumn("LOT BREAKDOWN QTY 1")
        fldLotBDQty1Column.FieldName = "fldLotBDQty1"
        fldLotBDQty1Column.Width = 120
        fldLotBDQty1Column.ReadOnly = True
        gvData.Columns.Add(fldLotBDQty1Column)

        Dim fldLotBDQty2Column As New GridViewDecimalColumn("LOT BREAKDOWN QTY 2")
        fldLotBDQty2Column.FieldName = "fldLotBDQty2"
        fldLotBDQty2Column.Width = 120
        fldLotBDQty2Column.ReadOnly = True
        gvData.Columns.Add(fldLotBDQty2Column)

        Dim fldLotBDQty3Column As New GridViewDecimalColumn("LOT BREAKDOWN QTY 3")
        fldLotBDQty3Column.FieldName = "fldLotBDQty3"
        fldLotBDQty3Column.Width = 120
        fldLotBDQty3Column.ReadOnly = True
        gvData.Columns.Add(fldLotBDQty3Column)

        Dim fldLotBDQty4Column As New GridViewDecimalColumn("LOT BREAKDOWN QTY 4")
        fldLotBDQty4Column.FieldName = "fldLotBDQty1"
        fldLotBDQty4Column.Width = 120
        fldLotBDQty4Column.ReadOnly = True
        gvData.Columns.Add(fldLotBDQty4Column)

        Dim fldCheckingRemarksColumn As New GridViewTextBoxColumn("CHECKING REMARKS")
        fldCheckingRemarksColumn.FieldName = "checkingRemarks"
        fldCheckingRemarksColumn.Width = 200
        fldCheckingRemarksColumn.ReadOnly = True
        gvData.Columns.Add(fldCheckingRemarksColumn)

        Dim fldCheckingCodeColumn As New GridViewDecimalColumn("CHECKING CODE")
        fldCheckingCodeColumn.FieldName = "fldCheckingCode"
        fldCheckingCodeColumn.IsVisible = False
        fldCheckingCodeColumn.Width = 100
        fldCheckingCodeColumn.ReadOnly = True
        gvData.Columns.Add(fldCheckingCodeColumn)

        Dim fldDateAddedColumn As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAddedColumn.FieldName = "fldDateAdded"
        fldDateAddedColumn.Width = 130
        fldDateAddedColumn.IsVisible = True
        fldDateAddedColumn.ReadOnly = True
        fldDateAddedColumn.Format = DateTimePickerFormat.Custom
        fldDateAddedColumn.CustomFormat = "MMM dd, yyyy hh:mm tt"
        gvData.Columns.Add(fldDateAddedColumn)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy hh:mm tt}"
        gvData.Columns("fldDateAdded").ExcelExportType = DisplayFormatType.Custom
        gvData.Columns("fldDateAdded").ExcelExportFormatString = "MMM dd, yyyy hh:mm tt"

        Dim fldAddedByColumn As New GridViewTextBoxColumn("ADDED BY")
        fldAddedByColumn.FieldName = "fldAddedBy"
        fldAddedByColumn.Width = 80
        fldAddedByColumn.IsVisible = False
        fldAddedByColumn.ReadOnly = True
        gvData.Columns.Add(fldAddedByColumn)

        Dim fldLastUpdatedColumn As New GridViewDateTimeColumn("LAST UPDATED DATE")
        fldLastUpdatedColumn.FieldName = "fldLastUpdated"
        fldLastUpdatedColumn.Width = 130
        fldLastUpdatedColumn.IsVisible = False
        fldLastUpdatedColumn.ReadOnly = True
        fldLastUpdatedColumn.Format = DateTimePickerFormat.Custom
        fldLastUpdatedColumn.CustomFormat = "MMM dd, yyyy hh:mm tt"
        gvData.Columns.Add(fldLastUpdatedColumn)
        gvData.Columns("fldLastUpdated").FormatString = "{0:MMM dd, yyyy hh:mm tt}"
        gvData.Columns("fldLastUpdated").ExcelExportType = DisplayFormatType.Custom
        gvData.Columns("fldLastUpdated").ExcelExportFormatString = "MMM dd, yyyy hh:mm tt"

        Dim fldLastUpdateByColumn As New GridViewTextBoxColumn("LAST UPDATE BY")
        fldLastUpdateByColumn.FieldName = "fldLastUpdateBy"
        fldLastUpdateByColumn.Width = 90
        fldLastUpdateByColumn.IsVisible = False
        fldLastUpdateByColumn.ReadOnly = True
        gvData.Columns.Add(fldLastUpdateByColumn)

        Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
        fldRemarksColumn.FieldName = "fldRemarks"
        fldRemarksColumn.Width = 100
        fldRemarksColumn.ReadOnly = True
        gvData.Columns.Add(fldRemarksColumn)

        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableAlternatingRowColor = True
        gvData.EnableGrouping = True
        gvData.EnableFiltering = True
        gvData.ShowGroupPanel = False
        gvData.ShowFilteringRow = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.ShowFilteringRow = True
        Else
            gvData.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        Slipknot.addParameter("parDateFrom", dtpFrom.Value)
        Slipknot.addParameter("parDateTo", dtpTo.Value)
        Slipknot.addParameter("parUser", currentUser.Item("fldUsername"))
        myData = Slipknot.dbSelect("SP_SelectLCSByDateRange")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbExport_Click(sender As Object, e As EventArgs) Handles cbbExport.Click
        If gvData.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.gvData)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
            End If

        End If
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If Slipknot.IsFormOpen(FrmAddLCS) Then
            FrmAddLCS.Focus()
        Else
            FrmAddLCS.Show(Me)
        End If
    End Sub

    Private Sub FrmLCSCreator_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub loadTemplate()

        Dim DT As DataTable = Slipknot.dbSelectManual("SELECT fldLotControlTemplate FROM tblLotControlTemplates")

        Dim fldLotControlTemplate As New GridViewTextBoxColumn("TEMPLATE")
        fldLotControlTemplate.FieldName = "fldLotControlTemplate"
        fldLotControlTemplate.Width = 270
        mcbTemplate.MultiColumnComboBoxElement.Columns.Add(fldLotControlTemplate)

        mcbTemplate.DataSource = DT
        mcbTemplate.ValueMember = "fldLotControlTemplate"
        mcbTemplate.DisplayMember = "fldLotControlTemplate"
        mcbTemplate.MultiColumnComboBoxElement.DropDownWidth = 320

        mcbTemplate.SelectedValue = My.Settings.setLCSTemplate

        mcbTemplate.AutoFilter = True
        mcbTemplate.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim filter As New FilterDescriptor()
        filter.PropertyName = "fldLotControlTemplate"
        filter.Operator = FilterOperator.Contains
        mcbTemplate.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)

    End Sub

    Private Sub saveTemplate()

        My.Settings.setLCSTemplate = mcbTemplate.SelectedValue

        My.Settings.Save()

    End Sub

    Private Sub FrmLCSCreator_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        saveTemplate()
    End Sub

    Private Sub openLot()

        If mcbTemplate.SelectedValue Is Nothing Then

            RadMessageBox.Show("Please select template properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub

        End If

        Dim getTemplate As DataRow = Slipknot.rowSelectManual("SELECT * FROM tblLotControlTemplates WHERE fldLotControlTemplate = '" & mcbTemplate.SelectedValue & "' LIMIT 1")
        Dim showAFIInfo As Boolean = False

        If getTemplate IsNot Nothing Then
            showAFIInfo = Convert.ToBoolean(getTemplate.Item("fldShowAFIInfo"))
        End If

        Dim tempTable As New DataTable

        tempTable.Columns.Add("fldId", GetType(Integer))
        tempTable.Columns.Add("fldLCSID", GetType(String))
        tempTable.Columns.Add("fldFurmexSerial", GetType(String))
        tempTable.Columns.Add("fldPartNo", GetType(String))
        tempTable.Columns.Add("fldPartname", GetType(String))
        tempTable.Columns.Add("PartNoCustom", GetType(String))
        tempTable.Columns.Add("fldPartNoWoModel", GetType(String))
        tempTable.Columns.Add("noteLabel", GetType(String))
        tempTable.Columns.Add("fldNote", GetType(String))
        tempTable.Columns.Add("fldLotNo", GetType(String))
        tempTable.Columns.Add("fldQty", GetType(String))
        tempTable.Columns.Add("fldUom", GetType(String))
        tempTable.Columns.Add("fldFeapCode", GetType(String))
        tempTable.Columns.Add("fldPartLevel", GetType(String))
        tempTable.Columns.Add("fldEnableLotBreakdown", GetType(Integer))
        tempTable.Columns.Add("fldLotBD1", GetType(String))
        tempTable.Columns.Add("fldLotBD2", GetType(String))
        tempTable.Columns.Add("fldLotBD3", GetType(String))
        tempTable.Columns.Add("fldLotBD4", GetType(String))
        tempTable.Columns.Add("fldLotBDQty1", GetType(String))
        tempTable.Columns.Add("fldLotBDQty2", GetType(String))
        tempTable.Columns.Add("fldLotBDQty3", GetType(String))
        tempTable.Columns.Add("fldLotBDQty4", GetType(String))
        tempTable.Columns.Add("fldPONumber", GetType(String))
        tempTable.Columns.Add("fldDateAdded", GetType(Date))
        tempTable.Columns.Add("fldAddedBy", GetType(String))
        tempTable.Columns.Add("fldLastUpdated", GetType(Date))
        tempTable.Columns.Add("fldLastUpdateBy", GetType(String))
        tempTable.Columns.Add("qtyWithUom", GetType(String))
        tempTable.Columns.Add("fldQrCode", GetType(Object))
        tempTable.Columns.Add("fldQrCodeFSIB", GetType(Object))

        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        For x As Integer = 0 To rows.Length - 1

            Dim rowId As Integer = Convert.ToInt32(rows(x).Cells("fldId").Value)

            Dim lotNo As String = Nothing
            Dim selectLotNo As DataRow = Slipknot.rowSelectManual("SELECT fldLotNo FROM tblLCSContainer WHERE fldId = '" & rowId & "' ")

            If selectLotNo IsNot Nothing Then
                lotNo = selectLotNo.Item("fldLotNo").ToString
            End If

            Dim finalDigit As String = Nothing

            Dim myText As String = StrReverse(lotNo)
            Dim myChars() As Char = myText
            For Each ch As Char In myChars
                If Char.IsDigit(ch) Then
                    finalDigit = finalDigit & ch
                Else
                    Exit For
                End If
            Next

            finalDigit = StrReverse(finalDigit)

            Dim drFormat As DataRow = Slipknot.rowSelectManual("SELECT * FROM tblLotControlTemplates WHERE fldLotControlTemplate = '" & mcbTemplate.SelectedValue & "' LIMIT 1 ")

            Dim combinePartNoCustomerFEAPCode As Boolean = True
            If drFormat IsNot Nothing Then
                combinePartNoCustomerFEAPCode = Convert.ToBoolean(drFormat.Item("fldCombinePartNoCustomerFeapCode"))
            End If

            Dim selectRow As DataRow

            If combinePartNoCustomerFEAPCode Then

                selectRow = Slipknot.rowSelectManual("SELECT " _
                                                 & "(SELECT fldReplaceCustomerPartNoWithFEAPPartNo FROM tblLotControlTemplates WHERE fldLotControlTemplate = '" & mcbTemplate.SelectedValue & "' LIMIT 1) AS replaceCustomerPartNoWithFEAPPartNo, " _
                                                 & "T0.fldId, IF((SELECT replaceCustomerPartNoWithFEAPPartNo) = 0, T0.fldPartNo, T0.fldFeapCode) AS fldPartNo, " _
                                                 & "T0.fldPartname, " _
                                                 & "T0.fldCustomer, " _
                                                 & "fldPartLevel, " _
                                                 & "(SELECT fldPartNoSpaceNo FROM tblSettings LIMIT 1) AS fldPartNoSpaceNo, " _
                                                 & "(SELECT fldQtySpaceNo FROM tblSettings LIMIT 1) AS fldQtySpaceNo, " _
                                                 & "(SELECT fldLotNoSpaceNo FROM tblSettings LIMIT 1) AS fldLotNoSpaceNo, " _
                                                 & "(SELECT fldNoteSpaceNo FROM tblSettings LIMIT 1) AS fldNoteSpaceNo, " _
                                                 & "(SELECT fldPartnameSpaceNo FROM tblSettings LIMIT 1) AS fldPartnameSpaceNo, " _
                                                 & "(SELECT fldHideCustomerParenthesis FROM tblLotControlTemplates WHERE fldLotControlTemplate = '" & mcbTemplate.SelectedValue & "' LIMIT 1) AS hideCustonerParenthesis, " _
                                                 & "IF(T0.fldFeapCode IS NULL OR T0.fldFeapCode = '' , CONCAT(IF((SELECT replaceCustomerPartNoWithFEAPPartNo) = 0, T0.fldPartNo, T0.fldFeapCode), IF((SELECT hideCustonerParenthesis) = 0,' (','') , T1.fldCustomerName, IF((SELECT hideCustonerParenthesis) = 0,')','')), CONCAT(IF((SELECT replaceCustomerPartNoWithFEAPPartNo) = 0, T0.fldPartNo, T0.fldFeapCode), IF((SELECT hideCustonerParenthesis) = 0,' (',''), T1.fldCustomerName, IF((SELECT hideCustonerParenthesis) = 0,')',''), '<',T0.fldFeapCode, '>') ) AS PartNoCustom, " _
                                                 & "IF((SELECT replaceCustomerPartNoWithFEAPPartNo) = 0, T0.fldPartNoWoModel, T0.fldFeapCode) AS fldPartNoWoModel, " _
                                                 & "IF(T0.fldPONumber Is NULL, T0.fldNote, CONCAT(T0.fldNote,CHAR(13),T0.fldPONumber) ) AS noteLabel, " _
                                                 & "T0.fldNote, " _
                                                 & "T0.fldPONumber, " _
                                                 & "T0.fldLotNo, " _
                                                 & "T0.fldAdditionalInfo, " _
                                                 & "IF(T0.fldUom Is NULL, TRUNCATE(T0.fldQty, 0), TRUNCATE(T0.fldQty, 2)) AS Qty, " _
                                                 & "T0.fldUom," _
                                                 & "T0.fldLotBD1, " _
                                                 & "T0.fldLotBD2, " _
                                                 & "T0.fldLotBD3, " _
                                                 & "T0.fldLotBD4, " _
                                                 & "T0.fldEnableLotBreakdown, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1, CONCAT('FEAP CODE: ', T0.fldFeapCode), T0.fldFeapCode) AS feapCode, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1 AND T0.fldLotBD1 IS NOT NULL, T0.fldLotBDQty1, '') AS lotBDQty1, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1 AND T0.fldLotBD2 IS NOT NULL, T0.fldLotBDQty2, '') AS lotBDQty2, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1 AND T0.fldLotBD3 IS NOT NULL, T0.fldLotBDQty3, '') AS lotBDQty3, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1 AND T0.fldLotBD4 IS NOT NULL, T0.fldLotBDQty4, '') AS lotBDQty4, " _
                                                 & "T0.fldDateAdded, T0.fldCategory, T0.fldAddedBy, T0.fldLastUpdated, T0.fldLastUpdateBy, " _
                                                 & "IF(T0.fldUom IS NULL, TRUNCATE(T0.fldQty, 0), CONCAT(T0.fldQty, ' ', T0.fldUom)) AS qtyWithUom, " _
                                                 & "T1.fldCustomerCode, " _
                                                 & "T0.fldLastUpdated " _
                                                 & "FROM tblLCSContainer T0 " _
                                                 & "LEFT JOIN tblCustomer T1 ON T0.fldCustomer = T1.fldCustomerCode " _
                                                 & "WHERE T0.fldId = '" & rowId & "' ")


            Else

                selectRow = Slipknot.rowSelectManual("SELECT " _
                                                 & "(SELECT fldReplaceCustomerPartNoWithFEAPPartNo FROM tblLotControlTemplates WHERE fldLotControlTemplate = '" & mcbTemplate.SelectedValue & "' LIMIT 1) AS replaceCustomerPartNoWithFEAPPartNo, " _
                                                 & "T0.fldId, " _
                                                 & "IF((SELECT replaceCustomerPartNoWithFEAPPartNo) = 0, T0.fldPartNo, T0.fldFeapCode) AS fldPartNo, " _
                                                 & "T0.fldPartname, " _
                                                 & "T0.fldCustomer, " _
                                                 & "T0.fldPartLevel, " _
                                                 & "(SELECT fldPartNoSpaceNo FROM tblSettings LIMIT 1) AS fldPartNoSpaceNo, " _
                                                 & "(SELECT fldQtySpaceNo FROM tblSettings LIMIT 1) AS fldQtySpaceNo, " _
                                                 & "(SELECT fldLotNoSpaceNo FROM tblSettings LIMIT 1) AS fldLotNoSpaceNo, " _
                                                 & "(SELECT fldNoteSpaceNo FROM tblSettings LIMIT 1) AS fldNoteSpaceNo, " _
                                                 & "(SELECT fldPartnameSpaceNo FROM tblSettings LIMIT 1) AS fldPartnameSpaceNo, " _
                                                 & "(SELECT fldHideCustomerParenthesis FROM tblLotControlTemplates WHERE fldLotControlTemplate = '" & mcbTemplate.SelectedValue & "' LIMIT 1) AS hideCustonerParenthesis, " _
                                                 & "(SELECT fldHideFeapCode FROM tblLotControlTemplates WHERE fldLotControlTemplate = '" & mcbTemplate.SelectedValue & "' LIMIT 1) AS template, " _
                                                 & "IF(T0.fldPartNo = '', CONCAT( IF((SELECT hideCustonerParenthesis) = 0,' (','') ,T1.fldCustomerName , IF((SELECT hideCustonerParenthesis) = 0,')','') ,T0.fldFeapCode), CONCAT( IF((SELECT hideCustonerParenthesis) = 0,' (',''),T1.fldCustomerName ,IF((SELECT hideCustonerParenthesis) = 0,')',''), IF((SELECT replaceCustomerPartNoWithFEAPPartNo) = 0, T0.fldPartNo, T0.fldFeapCode))) AS PartNoCustom, " _
                                                 & "IF((SELECT replaceCustomerPartNoWithFEAPPartNo) = 0, T0.fldPartNoWoModel, T0.fldFeapCode) AS fldPartNoWoModel, IF(T0.fldPONumber IS NULL, IF(T0.fldFeapCode IS NULL OR T0.fldFeapCode = '' OR ((SELECT template) IS NOT NULL AND (SELECT template) = 1), T0.fldNote, CONCAT(T0.fldNote, ' / ', T0.fldFeapCode)) , CONCAT(T0.fldNote,' ',T0.fldPONumber , " _
                                                 & "IF(T0.fldFeapCode Is NULL Or T0.fldFeapCode = '','', CONCAT(' / ', T0.fldFeapCode)) )) AS noteLabel, " _
                                                 & "T0.fldNote, " _
                                                 & "T0.fldPONumber, " _
                                                 & "T0.fldLotNo, " _
                                                 & "T0.fldAdditionalInfo, " _
                                                 & "IF(T0.fldUom Is NULL, TRUNCATE(T0.fldQty, 0), TRUNCATE(T0.fldQty, 2)) AS qty, " _
                                                 & "T0.fldUom, " _
                                                 & "T0.fldLotBD1, " _
                                                 & "T0.fldLotBD2, " _
                                                 & "T0.fldLotBD3, " _
                                                 & "T0.fldLotBD4, " _
                                                 & "T0.fldEnableLotBreakdown, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1, CONCAT('FEAP CODE: ', T0.fldFeapCode), T0.fldFeapCode) AS feapCode, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1 AND T0.fldLotBD1 IS NOT NULL, T0.fldLotBDQty1, '') AS lotBDQty1, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1 AND T0.fldLotBD2 IS NOT NULL, T0.fldLotBDQty2, '') AS lotBDQty2, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1 AND T0.fldLotBD3 IS NOT NULL, T0.fldLotBDQty3, '') AS lotBDQty3, " _
                                                 & "IF(T0.fldEnableLotBreakdown = 1 AND T0.fldLotBD4 IS NOT NULL, T0.fldLotBDQty4, '') AS lotBDQty4, " _
                                                 & "T0.fldDateAdded, " _
                                                 & "T0.fldCategory, " _
                                                 & "T0.fldAddedBy, " _
                                                 & "T0.fldLastUpdated, " _
                                                 & "T0.fldLastUpdateBy, " _
                                                 & "IF(T0.fldUom IS NULL, TRUNCATE(T0.fldQty, 0), CONCAT(T0.fldQty, ' ', T0.fldUom)) AS qtyWithUom, " _
                                                 & "T1.fldCustomerCode " _
                                                 & "FROM tblLCSContainer T0 " _
                                                 & "LEFT JOIN tblCustomer T1 ON T0.fldCustomer = T1.fldCustomerCode " _
                                                 & "WHERE T0.fldId = '" & rowId & "' ")

            End If

            If selectRow IsNot Nothing Then

                Dim fldId As Integer = Convert.ToInt32(selectRow.Item("fldId"))
                Dim fldPartNo As String = Convert.ToString(selectRow.Item("fldPartNo"))
                Dim fldCustomer As String = Convert.ToString(selectRow.Item("fldCustomer"))
                Dim fldPartname As String = Convert.ToString(selectRow.Item("fldPartname")) & " " & Convert.ToString(selectRow.Item("fldAdditionalInfo"))
                Dim PartNoCustom As String = Convert.ToString(selectRow.Item("PartNoCustom"))
                Dim fldPartNoWoModel As String = Convert.ToString(selectRow.Item("fldPartNoWoModel"))
                Dim noteLabel As String = Convert.ToString(selectRow.Item("noteLabel"))
                Dim fldNote As String = Convert.ToString(selectRow.Item("fldNote"))
                Dim fldLotNo As String = Convert.ToString(selectRow.Item("fldLotNo"))
                Dim fldPONumber As String = Convert.ToString(selectRow.Item("fldPONumber"))
                Dim fldQty As String = Convert.ToString(selectRow.Item("Qty"))
                Dim fldUom As String = Convert.ToString(selectRow.Item("fldUom"))
                Dim fldFeapCode As String = Convert.ToString(selectRow.Item("feapCode"))
                Dim fldPartLevel As String = Convert.ToString(selectRow.Item("fldPartLevel"))
                Dim fldEnableLotBreakdown As Integer = Convert.ToInt32(selectRow.Item("fldEnableLotBreakdown"))
                Dim fldLotBD1 As String = Convert.ToString(selectRow.Item("fldLotBD1"))
                Dim fldLotBD2 As String = Convert.ToString(selectRow.Item("fldLotBD2"))
                Dim fldLotBD3 As String = Convert.ToString(selectRow.Item("fldLotBD3"))
                Dim fldLotBD4 As String = Convert.ToString(selectRow.Item("fldLotBD4"))
                Dim fldLotBDQty1 As String = Convert.ToString(selectRow.Item("lotBDQty1"))
                Dim fldLotBDQty2 As String = Convert.ToString(selectRow.Item("lotBDQty2"))
                Dim fldLotBDQty3 As String = Convert.ToString(selectRow.Item("lotBDQty3"))
                Dim fldLotBDQty4 As String = Convert.ToString(selectRow.Item("lotBDQty4"))
                Dim fldDateAdded As DateTime = Convert.ToDateTime(selectRow.Item("fldDateAdded"))
                Dim fldCategory As String = Convert.ToString(selectRow.Item("fldCategory"))
                Dim fldAddedBy As String = Convert.ToString(selectRow.Item("fldAddedBy"))
                Dim fldLastUpdated As DateTime = Convert.ToDateTime(selectRow.Item("fldLastUpdated"))
                Dim fldLastUpdateBy As String = Convert.ToString(selectRow.Item("fldLastUpdateBy"))
                Dim qtyWithUom As String = Convert.ToString(selectRow.Item("qtyWithUom"))
                Dim fldCustomerCode As String = Convert.ToString(selectRow.Item("fldCustomerCode"))

                fldPartname = fldPartname.TrimStart.TrimEnd()

                'MAKING QR CODE IMAGE
                Dim finalQrValue = Nothing
                Dim finalQrFSIBValue = Nothing
                Dim customerCode As String = selectRow.Item("fldCustomer")

                Dim partNoSpaceNo As Integer = Convert.ToInt32(selectRow.Item("fldPartNoSpaceNo"))
                Dim qtySpaceNo As Integer = Convert.ToInt32(selectRow.Item("fldQtySpaceNo"))
                Dim lotNoSpaceNo As Integer = Convert.ToInt32(selectRow.Item("fldLotNoSpaceNo"))
                Dim noteSpaceNo As Integer = Convert.ToInt32(selectRow.Item("fldNoteSpaceNo"))
                Dim partNameSpaceNo As Integer = Convert.ToInt32(selectRow.Item("fldPartnameSpaceNo"))

                Dim customerCodeQr As String
                Dim partNoQr As String
                Dim qtyQr As String
                Dim lotNoQr As String
                Dim noteQr As String
                Dim partNameQr As String

                customerCodeQr = customerCode

                If fldPartNoWoModel.Length >= partNoSpaceNo Then
                    partNoQr = fldPartNoWoModel
                Else
                    partNoQr = fldPartNoWoModel & Space(partNoSpaceNo - fldPartNoWoModel.Length)
                End If

                If fldQty.Length >= qtySpaceNo Then
                    qtyQr = fldQty
                Else
                    qtyQr = Space(qtySpaceNo - fldQty.Length) & fldQty
                End If

                If lotNo.Length >= lotNoSpaceNo Then
                    lotNoQr = lotNo
                Else
                    lotNoQr = lotNo & Space(lotNoSpaceNo - lotNo.Length)
                End If

                If fldNote.Length >= noteSpaceNo Then
                    noteQr = fldNote
                Else
                    noteQr = fldNote & Space(noteSpaceNo - fldNote.Length)
                End If

                If fldPartname.Length >= partNameSpaceNo Then
                    partNameQr = fldPartname
                Else
                    partNameQr = fldPartname & Space(partNameSpaceNo - fldPartname.Length)
                End If

                qrImgLot.Text = "01" & partNoQr & qtyQr & lotNoQr & noteQr & partNameQr

                finalQrValue = qrImgLot.Image

                'START TO CREATE QR CODE FOR FSIB this the revised with lotno, note and partname
                '{

                Dim headerQrFSIB As String
                Dim lcsIdQrFSIB As String
                Dim furmexSerial As String
                Dim partNoQrFSIB As String
                Dim qtyQrFSIB As String
                Dim packageIdQrFSIB As String
                Dim referenceCodeQrFSIB As String
                Dim lotNoQrFSIB As String
                Dim noteQrFSIB As String
                Dim customerCodeQrFSIB As String
                Dim AFIIdQrFSIB As String
                Dim AFIPartLevelQrFSIB As String
                Dim spaceQrFSIB As String

                headerQrFSIB = "F1001"

                lcsIdQrFSIB = "XAA3" & fldId.ToString.PadLeft(16, "0")

                furmexSerial = "FEA" & fldId.ToString.PadLeft(16, "0")

                If fldPartNo.Length >= 20 Then
                    partNoQrFSIB = fldPartNo.Substring(0, 20)
                Else
                    partNoQrFSIB = fldPartNo & Space(20 - fldPartNo.Length)
                End If

                If fldQty.Length >= 10 Then
                    qtyQrFSIB = fldQty.Substring(0, 10)
                Else
                    qtyQrFSIB = fldQty.ToString().PadLeft(10, "0")
                End If

                packageIdQrFSIB = "01"

                If fldPartname.Length >= 25 Then
                    referenceCodeQrFSIB = fldPartname.Substring(0, 25)
                Else
                    referenceCodeQrFSIB = fldPartname & Space(25 - fldPartname.Length)
                End If

                If fldLotNo.Length >= 20 Then
                    lotNoQrFSIB = fldLotNo.Substring(0, 20)
                Else
                    lotNoQrFSIB = fldLotNo & Space(20 - fldLotNo.Length)
                End If

                If fldNote.Length >= 10 Then
                    noteQrFSIB = fldNote.Substring(0, 10)
                Else
                    noteQrFSIB = fldNote & Space(10 - fldNote.Length)
                End If

                If fldCustomerCode.Length >= 4 Then
                    customerCodeQrFSIB = fldCustomerCode.Substring(4 - fldCustomerCode.Length)
                Else
                    customerCodeQrFSIB = fldCustomerCode & Space(4 - fldCustomerCode.Length)
                End If

                AFIIdQrFSIB = "*FEA" & fldId.ToString.PadLeft(16, "0") & "*S"

                If fldPartLevel.Length >= 3 Then
                    AFIPartLevelQrFSIB = fldPartLevel.Substring(0, 3)
                Else
                    AFIPartLevelQrFSIB = fldPartLevel & Space(3 - fldPartLevel.Length)
                End If

                If showAFIInfo Then
                    spaceQrFSIB = Space(109)
                    qrImgFSIB.Text = headerQrFSIB & lcsIdQrFSIB & partNoQrFSIB & qtyQrFSIB & packageIdQrFSIB & referenceCodeQrFSIB & lotNoQrFSIB & noteQrFSIB & customerCodeQrFSIB & AFIIdQrFSIB & AFIPartLevelQrFSIB & spaceQrFSIB
                Else
                    spaceQrFSIB = Space(134)
                    qrImgFSIB.Text = headerQrFSIB & lcsIdQrFSIB & partNoQrFSIB & qtyQrFSIB & packageIdQrFSIB & referenceCodeQrFSIB & lotNoQrFSIB & noteQrFSIB & customerCodeQrFSIB & spaceQrFSIB
                End If

                finalQrFSIBValue = qrImgFSIB.Image

                Dim percent As Double = x / gvData.SelectedRows.Count * 100

                RadProgressBarElement1.Text = percent & "%"
                RadProgressBarElement1.Value1 = percent

                tempTable.Rows.Add(fldId, lcsIdQrFSIB, furmexSerial, fldPartNo, fldPartname, PartNoCustom, fldPartNoWoModel, noteLabel, fldNote, lotNo, fldQty, fldUom, fldFeapCode, fldPartLevel, fldEnableLotBreakdown, fldLotBD1, fldLotBD2, fldLotBD3, fldLotBD4, fldLotBDQty1, fldLotBDQty2, fldLotBDQty3, fldLotBDQty4, fldPONumber, fldDateAdded, fldAddedBy, fldLastUpdated, fldLastUpdateBy, qtyWithUom, finalQrValue, finalQrFSIBValue)

            End If

        Next

        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        dtReportData = Slipknot.CopyDataTable(tempTable)

        Dim frm As New FrmReport
        frm.Show()

    End Sub

    Private Sub cbbOpen_Click(sender As Object, e As EventArgs) Handles cbbOpen.Click

        reportType = 1000
        publicText = mcbTemplate.SelectedValue
        openLot()

    End Sub
End Class
