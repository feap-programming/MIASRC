Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmAddLCS

    Private frmLotMasterList As New FrmMasterList
    Private toolTipWarning As New RadToolTip
    Private Sub FrmAddLCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyToolTipWarning()

        readyGrid()
    End Sub

    Private Sub readyGrid()
        With gvRecords

            Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
            fldStatColumn.FieldName = "fldStatus"
            fldStatColumn.Width = 70
            fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
            fldStatColumn.ReadOnly = True
            fldStatColumn.IsPinned = True
            fldStatColumn.PinPosition = PinnedColumnPosition.Left
            .Columns.Add(fldStatColumn)

            Dim fldIncrementSeriesColumn As New GridViewCheckBoxColumn("INCREMENT LOTNO")
            fldIncrementSeriesColumn.FieldName = "fldIncrementLotNo"
            fldIncrementSeriesColumn.Width = 140
            .Columns.Add(fldIncrementSeriesColumn)

            Dim fldSeriesColumn As New GridViewDecimalColumn("SERIES")
            fldSeriesColumn.FieldName = "fldSeries"
            fldSeriesColumn.DecimalPlaces = 0
            fldSeriesColumn.Minimum = 0
            fldSeriesColumn.Maximum = 999999
            fldSeriesColumn.Width = 60
            fldSeriesColumn.ShowUpDownButtons = False
            .Columns.Add(fldSeriesColumn)

            Dim fldPartnameColumn As New GridViewTextBoxColumn("PART NAME")
            fldPartnameColumn.FieldName = "fldPartname"
            fldPartnameColumn.Width = 200
            fldPartnameColumn.ReadOnly = True
            .Columns.Add(fldPartnameColumn)

            Dim fldPartNoColumn As New GridViewTextBoxColumn("CUSTOMER PART NO.")
            fldPartNoColumn.FieldName = "fldCustomerPartNo"
            fldPartNoColumn.Width = 150
            fldPartNoColumn.ReadOnly = True
            .Columns.Add(fldPartNoColumn)

            Dim fldPartNoWModelColumn As New GridViewTextBoxColumn("PART NO. W/O MODEL")
            fldPartNoWModelColumn.FieldName = "fldPartNoWoModel"
            fldPartNoWModelColumn.Width = 100
            fldPartNoWModelColumn.ReadOnly = True
            .Columns.Add(fldPartNoWModelColumn)

            Dim fldCustomerColumn As New GridViewTextBoxColumn("CUSTOMER")
            fldCustomerColumn.FieldName = "fldCustomerName"
            fldCustomerColumn.IsVisible = False
            fldCustomerColumn.VisibleInColumnChooser = False
            fldCustomerColumn.ReadOnly = True
            .Columns.Add(fldCustomerColumn)

            Dim fldNoteColumn As New GridViewTextBoxColumn("NOTE")
            fldNoteColumn.FieldName = "fldNote"
            fldNoteColumn.Width = 100
            fldNoteColumn.ReadOnly = True
            .Columns.Add(fldNoteColumn)

            Dim fldLotNoColumn As New GridViewTextBoxColumn("LOT NO.")
            fldLotNoColumn.FieldName = "fldLotNo"
            fldLotNoColumn.Width = 90
            fldLotNoColumn.ReadOnly = True
            .Columns.Add(fldLotNoColumn)

            Dim fldQtyColumn As New GridViewDecimalColumn("QTY")
            fldQtyColumn.FieldName = "fldQty"
            fldQtyColumn.Width = 60
            fldQtyColumn.TextAlignment = ContentAlignment.MiddleRight
            fldQtyColumn.ReadOnly = False
            .Columns.Add(fldQtyColumn)
            .Columns("fldQty").FormatString = "{0:N2}"

            Dim fldUomColumn As New GridViewTextBoxColumn("UOM")
            fldUomColumn.FieldName = "fldUom"
            fldUomColumn.Width = 40
            fldUomColumn.ReadOnly = True
            .Columns.Add(fldUomColumn)

            Dim fldFeapCodeColumn As New GridViewTextBoxColumn("FEAP CODE")
            fldFeapCodeColumn.FieldName = "fldFeapCode"
            fldFeapCodeColumn.Width = 80
            fldFeapCodeColumn.ReadOnly = True
            .Columns.Add(fldFeapCodeColumn)

            Dim fldAdditionalInfoColumn As New GridViewTextBoxColumn("ADDITIONAL INFO")
            fldAdditionalInfoColumn.FieldName = "fldAdditionalInfo"
            fldAdditionalInfoColumn.Width = 120
            fldAdditionalInfoColumn.ReadOnly = True
            .Columns.Add(fldAdditionalInfoColumn)

            Dim fldPONumberColumn As New GridViewTextBoxColumn("PO NUMBER")
            fldPONumberColumn.FieldName = "fldPONumber"
            fldPONumberColumn.Width = 80
            fldPONumberColumn.ReadOnly = True
            .Columns.Add(fldPONumberColumn)

            Dim fldPartLevelColumn As New GridViewTextBoxColumn("PART LEVEL")
            fldPartLevelColumn.FieldName = "fldPartLevel"
            fldPartLevelColumn.Width = 70
            fldPartLevelColumn.ReadOnly = True
            .Columns.Add(fldPartLevelColumn)

            Dim fldEnableBDLotNoColumn As New GridViewCheckBoxColumn("LOT NO BREAKDOWN")
            fldEnableBDLotNoColumn.FieldName = "fldEnableLotBreakdown"
            fldEnableBDLotNoColumn.Width = 100
            fldEnableBDLotNoColumn.ReadOnly = True
            .Columns.Add(fldEnableBDLotNoColumn)

            Dim fldLotNoBD1Column As New GridViewTextBoxColumn("BD LOT NO 1")
            fldLotNoBD1Column.FieldName = "fldLotBD1"
            fldLotNoBD1Column.Width = 70
            fldLotNoBD1Column.ReadOnly = True
            .Columns.Add(fldLotNoBD1Column)

            Dim fldLotNoBD2Column As New GridViewTextBoxColumn("BD LOT NO 2")
            fldLotNoBD2Column.FieldName = "fldLotBD2"
            fldLotNoBD2Column.Width = 70
            fldLotNoBD2Column.ReadOnly = True
            .Columns.Add(fldLotNoBD2Column)

            Dim fldLotNoBD3Column As New GridViewTextBoxColumn("BD LOT NO 3")
            fldLotNoBD3Column.FieldName = "fldLotBD3"
            fldLotNoBD3Column.Width = 70
            fldLotNoBD3Column.ReadOnly = True
            .Columns.Add(fldLotNoBD3Column)

            Dim fldLotNoBD4Column As New GridViewTextBoxColumn("BD LOT NO 4")
            fldLotNoBD4Column.FieldName = "fldLotBD4"
            fldLotNoBD4Column.Width = 70
            fldLotNoBD4Column.ReadOnly = True
            .Columns.Add(fldLotNoBD4Column)

            Dim fldLotNoBDQty1Column As New GridViewDecimalColumn("BD LOT NO QTY 1")
            fldLotNoBDQty1Column.FieldName = "fldLotBDQty1"
            fldLotNoBDQty1Column.Width = 90
            fldLotNoBDQty1Column.ReadOnly = True
            .Columns.Add(fldLotNoBDQty1Column)

            Dim fldLotNoBDQty2Column As New GridViewDecimalColumn("BD LOT NO QTY 2")
            fldLotNoBDQty2Column.FieldName = "fldLotBDQty2"
            fldLotNoBDQty2Column.Width = 90
            fldLotNoBDQty2Column.ReadOnly = True
            .Columns.Add(fldLotNoBDQty2Column)

            Dim fldLotNoBDQty3Column As New GridViewDecimalColumn("BD LOT NO QTY 3")
            fldLotNoBDQty3Column.FieldName = "fldLotBDQty3"
            fldLotNoBDQty3Column.Width = 90
            fldLotNoBDQty3Column.ReadOnly = True
            .Columns.Add(fldLotNoBDQty3Column)

            Dim fldLotNoBDQty4Column As New GridViewDecimalColumn("BD LOT NO QTY 4")
            fldLotNoBDQty4Column.FieldName = "fldLotBDQty4"
            fldLotNoBDQty4Column.Width = 90
            fldLotNoBDQty4Column.ReadOnly = True
            .Columns.Add(fldLotNoBDQty4Column)

            Dim fldCategoryCodeColumn As New GridViewTextBoxColumn("CATEGORY CODE")
            fldCategoryCodeColumn.FieldName = "fldCategoryCode"
            fldCategoryCodeColumn.IsVisible = False
            fldCategoryCodeColumn.VisibleInColumnChooser = False
            fldCategoryCodeColumn.ReadOnly = True
            .Columns.Add(fldCategoryCodeColumn)

            Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
            fldRemarksColumn.FieldName = "fldRemarks"
            fldRemarksColumn.Width = 80
            fldRemarksColumn.ReadOnly = False
            .Columns.Add(fldRemarksColumn)

            'Dim fldIMGColumn As New GridViewImageColumn("QRCODE")
            'fldIMGColumn.FieldName = "fldQrCode"
            'fldIMGColumn.Width = 100
            '.Columns.Add(fldIMGColumn)

            .AllowAddNewRow = False
            .ShowFilteringRow = False
            .EnableFiltering = False
            .EnableGrouping = False
            .ShowGroupPanel = False
            .AllowColumnReorder = False
            .AllowRowReorder = False
            .ShowRowHeaderColumn = False
            .AllowAutoSizeColumns = True
            .MultiSelect = True
            .AllowDeleteRow = True
            .EnableAlternatingRowColor = True

        End With
    End Sub

    Private Sub cbbMasterList_Click(sender As Object, e As EventArgs) Handles cbbMasterList.Click
        showMasterList()
    End Sub

    Private Sub showMasterList()
        If Not Slipknot.IsFormOpen(frmLotMasterList) Then
            frmLotMasterList = New FrmMasterList
            frmLotMasterList.Show(Me)
        End If

    End Sub

    Private Sub FrmAddLCS_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Slipknot.IsFormOpen(frmLotMasterList) Then
            frmLotMasterList.Location = New Point(Me.Location.X - frmLotMasterList.Width, Me.Location.Y)
        End If
    End Sub

    Private Sub searchFilter()

        If Slipknot.IsFormOpen(frmLotMasterList) Then

            frmLotMasterList.gvRecords.FilterDescriptors.Clear()

            If txtPartname.Text = "" Then
            Else
                Dim filterPartname As New FilterDescriptor
                filterPartname.PropertyName = "fldPartName"
                filterPartname.[Operator] = FilterOperator.Contains
                filterPartname.Value = txtPartname.Text
                filterPartname.IsFilterEditor = True
                frmLotMasterList.gvRecords.FilterDescriptors.Add(filterPartname)
            End If

            If txtPartno.Text = "" Then
            Else
                Dim filterPartNo As New FilterDescriptor
                filterPartNo.PropertyName = "fldCustomerPartNo"
                filterPartNo.[Operator] = FilterOperator.Contains
                filterPartNo.Value = txtPartno.Text
                filterPartNo.IsFilterEditor = True
                frmLotMasterList.gvRecords.FilterDescriptors.Add(filterPartNo)
            End If

            If txtFeapCode.Text = "" Then
            Else
                Dim filterFeapPartNo As New FilterDescriptor
                filterFeapPartNo.PropertyName = "fldItemCode"
                filterFeapPartNo.[Operator] = FilterOperator.Contains
                filterFeapPartNo.Value = txtFeapCode.Text
                filterFeapPartNo.IsFilterEditor = True
                frmLotMasterList.gvRecords.FilterDescriptors.Add(filterFeapPartNo)
            End If

            If txtCustomer.Text = "" Then
            Else
                Dim filterCustomer As New FilterDescriptor
                filterCustomer.PropertyName = "customer"
                filterCustomer.[Operator] = FilterOperator.Contains
                filterCustomer.Value = txtCustomer.Text
                filterCustomer.IsFilterEditor = True
                frmLotMasterList.gvRecords.FilterDescriptors.Add(filterCustomer)
            End If

        End If
    End Sub

    Private Sub txtPartname_TextChanged(sender As Object, e As EventArgs) Handles txtPartname.TextChanged
        searchFilter()
        showMasterList()
    End Sub

    Private Sub txtPartno_TextChanged(sender As Object, e As EventArgs) Handles txtPartno.TextChanged
        searchFilter()
        showMasterList()
    End Sub

    Private Sub txtFeapCode_TextChanged(sender As Object, e As EventArgs) Handles txtFeapCode.TextChanged
        searchFilter()
        showMasterList()
    End Sub

    Private Sub txtCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtCustomer.TextChanged
        searchFilter()
        showMasterList()
    End Sub

    Private Sub cbbAddToList_Click(sender As Object, e As EventArgs) Handles cbbAddToList.Click
        If txtLotNo.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Lot no should not be empty!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            addToList()
        End If
    End Sub

    Private partname As String
    Private customerPartNo As String
    Private customerPartNoWoModel As String
    Private customer As String
    Private note As String
    Private lotNo As String
    Private qty As Decimal
    Private uom As String
    Private feapCode As String
    Private additionalInfo As String
    Private poNumber As String
    Private partLevel As String = Nothing
    Private enableLotBD As Boolean
    Private lotBD1 As String
    Private lotBD2 As String
    Private lotBD3 As String
    Private lotBD4 As String
    Private lotBDQty1 As Integer
    Private lotBDQty2 As Integer
    Private lotBDQty3 As Integer
    Private lotBDQty4 As Integer
    Private categoryCode As String
    Private remarks As String

    Private Sub addToList()

        If frmLotMasterList.gvRecords.ChildRows.Count < 1 Then
            RadMessageBox.Show("No records found, please check your filterting.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
            Exit Sub
        End If

        Dim lotControl As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                            & "T0.fldId, " _
                                                            & "T0.fldCustomerPartNo, " _
                                                            & "T0.fldItemCode, " _
                                                            & "T0.fldModelCode, " _
                                                            & "T0.fldStdQty, " _
                                                            & "T0.fldPartLevel, " _
                                                            & "T0.fldCustomerCode, " _
                                                            & "T1.fldPartName, " _
                                                            & "T1.fldCategory " _
                                                            & "FROM " _
                                                            & "tblItemMasterPerCustomer T0 " _
                                                            & "LEFT JOIN tblItemMasterData T1 ON T0.fldItemCode = T1.fldItemCode " _
                                                            & "WHERE T0.fldId = '" & currentSelectedId & "' ")

        If lotControl.Rows.Count > 0 Then

            partname = Convert.ToString(lotControl.Rows(0).Item("fldPartName"))
            customerPartNo = Convert.ToString(lotControl.Rows(0).Item("fldCustomerPartNo"))
            customerPartNoWoModel = Convert.ToString(lotControl.Rows(0).Item("fldCustomerPartNo"))
            customer = Convert.ToString(lotControl.Rows(0).Item("fldCustomerCode"))
            note = Convert.ToString(lotControl.Rows(0).Item("fldModelCode"))
            lotNo = txtLotNo.Text.TrimStart.TrimEnd
            qty = Convert.ToDecimal(lotControl.Rows(0).Item("fldStdQty"))
            uom = ddUom.Text
            feapCode = Convert.ToString(lotControl.Rows(0).Item("fldItemCode"))
            additionalInfo = txtAdditionalInfo.Text.TrimStart.TrimEnd
            poNumber = txtPONumber.Text.TrimStart.TrimEnd
            partLevel = Convert.ToString(lotControl.Rows(0).Item("fldPartLevel"))
            enableLotBD = chkEnableLotBD.Checked
            lotBD1 = txtBDLotNo1.Text.TrimStart.TrimEnd
            lotBD2 = txtBDLotNo2.Text.TrimStart.TrimEnd
            lotBD3 = txtBDLotNo3.Text.TrimStart.TrimEnd
            lotBD4 = txtBDLotNo4.Text.TrimStart.TrimEnd
            lotBDQty1 = seBDLotQty1.Value
            lotBDQty2 = seBDLotQty2.Value
            lotBDQty3 = seBDLotQty3.Value
            lotBDQty4 = seBDLotQty4.Value
            categoryCode = Convert.ToString(lotControl.Rows(0).Item("fldCategory"))
            remarks = txtRemarks.Text.TrimStart.TrimEnd

            If enableLotBD = False Then
                lotBD1 = String.Empty
                lotBD2 = String.Empty
                lotBD3 = String.Empty
                lotBD4 = String.Empty
                lotBDQty1 = 0
                lotBDQty2 = 0
                lotBDQty3 = 0
                lotBDQty4 = 0
            End If

        Else
            RadMessageBox.Show("No records found, you have entered a record that might be deleted by another user.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If Not chkEnableUom.Checked Then
            uom = String.Empty
        End If

        gvRecords.Rows.Add("", True, 1, partname, customerPartNo, customerPartNoWoModel, customer, note, lotNo, qty, uom, feapCode, additionalInfo, poNumber, partLevel, enableLotBD, lotBD1, lotBD2, lotBD3, lotBD4, lotBDQty1, lotBDQty2, lotBDQty3, lotBDQty4, categoryCode, remarks)

    End Sub

    Private Sub gvRecords_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvRecords.RowsChanged
        leCountRec.Text = gvRecords.ChildRows.Count.ToString
    End Sub

    Private Sub bwPickAdder_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwPickAdder.DoWork

        For Each row As DataRow In dtPickedData.Rows

            Dim lotControl As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                            & "T0.fldId, " _
                                                            & "T0.fldCustomerPartNo, " _
                                                            & "T0.fldItemCode, " _
                                                            & "T0.fldModelCode, " _
                                                            & "T0.fldStdQty, " _
                                                            & "T0.fldPartLevel, " _
                                                            & "T0.fldCustomerCode, " _
                                                            & "T1.fldPartName, " _
                                                            & "T1.fldCategory " _
                                                            & "FROM " _
                                                            & "tblItemMasterPerCustomer T0 " _
                                                            & "LEFT JOIN tblItemMasterData T1 ON T0.fldItemCode = T1.fldItemCode " _
                                                            & "WHERE T0.fldId = '" & row.Item("ID").ToString & "' ")

            If lotControl.Rows.Count > 0 Then

                partname = Convert.ToString(lotControl.Rows(0).Item("fldPartName"))
                customerPartNo = Convert.ToString(lotControl.Rows(0).Item("fldCustomerPartNo"))
                customerPartNoWoModel = Convert.ToString(lotControl.Rows(0).Item("fldCustomerPartNo"))
                customer = Convert.ToString(lotControl.Rows(0).Item("fldCustomerCode"))
                note = Convert.ToString(lotControl.Rows(0).Item("fldModelCode"))
                lotNo = txtLotNo.Text.TrimStart.TrimEnd
                qty = Convert.ToDecimal(lotControl.Rows(0).Item("fldStdQty"))
                uom = ddUom.Text
                feapCode = Convert.ToString(lotControl.Rows(0).Item("fldItemCode"))
                additionalInfo = txtAdditionalInfo.Text.TrimStart.TrimEnd
                poNumber = txtPONumber.Text.TrimStart.TrimEnd
                partLevel = Convert.ToString(lotControl.Rows(0).Item("fldPartLevel"))
                enableLotBD = chkEnableLotBD.Checked
                lotBD1 = txtBDLotNo1.Text.TrimStart.TrimEnd
                lotBD2 = txtBDLotNo2.Text.TrimStart.TrimEnd
                lotBD3 = txtBDLotNo3.Text.TrimStart.TrimEnd
                lotBD4 = txtBDLotNo4.Text.TrimStart.TrimEnd
                lotBDQty1 = seBDLotQty1.Value
                lotBDQty2 = seBDLotQty2.Value
                lotBDQty3 = seBDLotQty3.Value
                lotBDQty4 = seBDLotQty4.Value
                categoryCode = Convert.ToString(lotControl.Rows(0).Item("fldCategory"))
                remarks = txtRemarks.Text.TrimStart.TrimEnd

                If enableLotBD = False Then
                    lotBD1 = String.Empty
                    lotBD2 = String.Empty
                    lotBD3 = String.Empty
                    lotBD4 = String.Empty
                    lotBDQty1 = 0
                    lotBDQty2 = 0
                    lotBDQty3 = 0
                    lotBDQty4 = 0
                End If

                If Not chkEnableUom.Checked Then
                    uom = String.Empty
                End If

                bwPickAdder.ReportProgress(Nothing)

                Threading.Thread.Sleep(delay)
            Else
                RadMessageBox.Show("No records found, you have entered a record that might be deleted by another user.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If

        Next

    End Sub

    Private Sub bwPickAdder_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwPickAdder.ProgressChanged
        gvRecords.Rows.Add("", True, 1, partname, customerPartNo, customerPartNoWoModel, customer, note, lotNo, qty, uom, feapCode, additionalInfo, poNumber, partLevel, enableLotBD, lotBD1, lotBD2, lotBD3, lotBD4, lotBDQty1, lotBDQty2, lotBDQty3, lotBDQty4, categoryCode, remarks)
    End Sub

    Private Sub bwPickAdder_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwPickAdder.RunWorkerCompleted
        dtPickedData.Rows.Clear()
    End Sub

    Private Sub cbbDleteFromList_Click(sender As Object, e As EventArgs) Handles cbbDleteFromList.Click
        gvRecords.CurrentRow.Delete()
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click
        FrmClearDialog.ShowDialog()
        Dim ClearMode As String = FrmClearDialog.txtResult.Text

        If ClearMode = "OkOnly" Then
            For counter As Integer = gvRecords.Rows.Count To 1 Step -1
                If gvRecords.Rows(counter - 1).Cells("fldEmpStats").Value.ToString = "OK" Then
                    gvRecords.Rows.Remove(gvRecords.Rows(counter - 1))
                End If
            Next
        End If

        If ClearMode = "ClearAll" Then
            gvRecords.Rows.Clear()
        End If
    End Sub

    Private Sub chkEnableLotBD_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkEnableLotBD.ToggleStateChanged
        If chkEnableLotBD.Checked Then
            gbLotBreakdown.Enabled = True
        Else
            gbLotBreakdown.Enabled = False
        End If
    End Sub

    Private Sub chkEnableUom_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkEnableUom.ToggleStateChanged
        If chkEnableUom.Checked Then
            ddUom.Enabled = True
        Else
            ddUom.Enabled = False
        End If
    End Sub

    Private Sub clearFilter()
        txtPartname.Clear()
        txtPartno.Clear()
        txtFeapCode.Clear()
        txtCustomer.Clear()
    End Sub

    Private Sub cbbClearFilter_Click(sender As Object, e As EventArgs) Handles cbbClearFilter.Click
        clearFilter()
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        If RadMessageBox.Show("Are you sure you want proceed saving?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            bwSave.RunWorkerAsync()
        End If
    End Sub

    Private Sub test()

        Dim status As String
        Dim incrementLotNo As Boolean
        Dim seriesVal As Integer

        For counter As Integer = 0 To gvRecords.Rows.Count - 1

            status = Convert.ToString(gvRecords.Rows(counter).Cells("fldStatus").Value)
            incrementLotNo = Convert.ToBoolean(gvRecords.Rows(counter).Cells("fldIncrementLotNo").Value)
            seriesVal = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldSeries").Value)

            If status <> "OK" Then

                For series As Integer = 0 To seriesVal - 1

                    partname = Convert.ToString(gvRecords.Rows(counter).Cells("fldPartname").Value)
                    customerPartNo = Convert.ToString(gvRecords.Rows(counter).Cells("fldCustomerPartNo").Value)
                    customerPartNoWoModel = Convert.ToString(gvRecords.Rows(counter).Cells("fldPartNoWoModel").Value)
                    customer = Convert.ToString(gvRecords.Rows(counter).Cells("fldCustomerName").Value)
                    note = Convert.ToString(gvRecords.Rows(counter).Cells("fldNote").Value)
                    lotNo = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotNo").Value)
                    qty = Convert.ToDecimal(gvRecords.Rows(counter).Cells("fldQty").Value)
                    uom = Convert.ToString(gvRecords.Rows(counter).Cells("fldUom").Value)
                    feapCode = Convert.ToString(gvRecords.Rows(counter).Cells("fldFeapCode").Value)
                    additionalInfo = Convert.ToString(gvRecords.Rows(counter).Cells("fldAdditionalInfo").Value)
                    poNumber = Convert.ToString(gvRecords.Rows(counter).Cells("fldPONumber").Value)
                    partLevel = Convert.ToString(gvRecords.Rows(counter).Cells("fldPartLevel").Value)
                    enableLotBD = Convert.ToBoolean(gvRecords.Rows(counter).Cells("fldEnableLotBreakdown").Value)
                    lotBD1 = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotBD1").Value)
                    lotBD2 = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotBD2").Value)
                    lotBD3 = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotBD3").Value)
                    lotBD4 = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotBD4").Value)
                    lotBDQty1 = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldLotBDQty1").Value)
                    lotBDQty2 = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldLotBDQty2").Value)
                    lotBDQty3 = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldLotBDQty3").Value)
                    lotBDQty4 = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldLotBDQty4").Value)
                    categoryCode = Convert.ToString(gvRecords.Rows(counter).Cells("fldCategoryCode").Value)
                    remarks = Convert.ToString(gvRecords.Rows(counter).Cells("fldRemarks").Value)

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

                    If incrementLotNo Then
                        If seriesVal > 1 Then

                            Dim lotLastChar As String = finalDigit

                            If IsNumeric(lotLastChar) Then

                                Dim incremental As Integer = Convert.ToInt32(lotLastChar) + series

                                Dim finalSeries As String

                                If incremental.ToString.Length > finalDigit.Length Then
                                    finalSeries = incremental
                                Else
                                    finalSeries = finalDigit.Substring(0, finalDigit.Length - incremental.ToString.Length) & incremental
                                End If

                                lotNo = lotNo.Substring(0, lotNo.Length - finalDigit.ToString.Length) & finalSeries

                            End If

                        End If
                    End If

                    Slipknot.addParameter("parPartname", partname)
                    Slipknot.addParameter("parPartNo", customerPartNo)
                    Slipknot.addParameter("parCustomer", customer)
                    Slipknot.addParameter("parPartNoWoModel", customerPartNoWoModel)
                    Slipknot.addParameter("parNote", note)
                    Slipknot.addParameter("parLotNo", lotNo)
                    Slipknot.addParameter("parQty", qty)
                    Slipknot.addParameter("parUom", uom)
                    Slipknot.addParameter("parFeapCode", feapCode)
                    Slipknot.addParameter("parPONumber", poNumber)
                    Slipknot.addParameter("parPartLevel", partLevel)
                    Slipknot.addParameter("parEnableLotBreakdown", enableLotBD)
                    Slipknot.addParameter("parLotBD1", lotBD1)
                    Slipknot.addParameter("parLotBD2", lotBD2)
                    Slipknot.addParameter("parLotBD3", lotBD3)
                    Slipknot.addParameter("parLotBD4", lotBD4)
                    Slipknot.addParameter("parLotBDQty1", lotBDQty1)
                    Slipknot.addParameter("parLotBDQty2", lotBDQty2)
                    Slipknot.addParameter("parLotBDQty3", lotBDQty3)
                    Slipknot.addParameter("parLotBDQty4", lotBDQty4)
                    Slipknot.addParameter("parCategory", categoryCode)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
                    Slipknot.addParameter("parLastUpdateBy", currentUser.Item("fldUsername"))
                    Slipknot.addParameter("parRemarks", remarks)
                    Slipknot.addParameter("parAdditionalInfo", additionalInfo)

                    Dim success As Boolean = Slipknot.dbAED("SP_InsertLCS")

                    If success Then
                        lineStat = "OK"
                    Else
                        lineStat = "NG"
                    End If

                Next

            End If

        Next

    End Sub

    Private lineNo As Integer = 0
    Private lineStat As String = Nothing
    Private Sub bwSave_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwSave.DoWork

        Dim status As String
        Dim incrementLotNo As Boolean
        Dim seriesVal As Integer

        For counter As Integer = 0 To gvRecords.Rows.Count - 1

            status = Convert.ToString(gvRecords.Rows(counter).Cells("fldStatus").Value)
            incrementLotNo = Convert.ToBoolean(gvRecords.Rows(counter).Cells("fldIncrementLotNo").Value)
            seriesVal = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldSeries").Value)

            If status <> "OK" Then

                For series As Integer = 0 To seriesVal - 1

                    partname = Convert.ToString(gvRecords.Rows(counter).Cells("fldPartname").Value)
                    customerPartNo = Convert.ToString(gvRecords.Rows(counter).Cells("fldCustomerPartNo").Value)
                    customerPartNoWoModel = Convert.ToString(gvRecords.Rows(counter).Cells("fldPartNoWoModel").Value)
                    customer = Convert.ToString(gvRecords.Rows(counter).Cells("fldCustomerName").Value)
                    note = Convert.ToString(gvRecords.Rows(counter).Cells("fldNote").Value)
                    lotNo = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotNo").Value)
                    qty = Convert.ToDecimal(gvRecords.Rows(counter).Cells("fldQty").Value)
                    uom = Convert.ToString(gvRecords.Rows(counter).Cells("fldUom").Value)
                    feapCode = Convert.ToString(gvRecords.Rows(counter).Cells("fldFeapCode").Value)
                    additionalInfo = Convert.ToString(gvRecords.Rows(counter).Cells("fldAdditionalInfo").Value)
                    poNumber = Convert.ToString(gvRecords.Rows(counter).Cells("fldPONumber").Value)
                    partLevel = Convert.ToString(gvRecords.Rows(counter).Cells("fldPartLevel").Value)
                    enableLotBD = Convert.ToBoolean(gvRecords.Rows(counter).Cells("fldEnableLotBreakdown").Value)
                    lotBD1 = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotBD1").Value)
                    lotBD2 = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotBD2").Value)
                    lotBD3 = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotBD3").Value)
                    lotBD4 = Convert.ToString(gvRecords.Rows(counter).Cells("fldLotBD4").Value)
                    lotBDQty1 = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldLotBDQty1").Value)
                    lotBDQty2 = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldLotBDQty2").Value)
                    lotBDQty3 = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldLotBDQty3").Value)
                    lotBDQty4 = Convert.ToInt32(gvRecords.Rows(counter).Cells("fldLotBDQty4").Value)
                    categoryCode = Convert.ToString(gvRecords.Rows(counter).Cells("fldCategoryCode").Value)
                    remarks = Convert.ToString(gvRecords.Rows(counter).Cells("fldRemarks").Value)

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

                    If incrementLotNo Then
                        If seriesVal > 1 Then

                            Dim lotLastChar As String = finalDigit

                            If IsNumeric(lotLastChar) Then

                                Dim incremental As Integer = Convert.ToInt32(lotLastChar) + series

                                Dim finalSeries As String

                                If incremental.ToString.Length > finalDigit.Length Then
                                    finalSeries = incremental
                                Else
                                    finalSeries = finalDigit.Substring(0, finalDigit.Length - incremental.ToString.Length) & incremental
                                End If

                                lotNo = lotNo.Substring(0, lotNo.Length - finalDigit.ToString.Length) & finalSeries

                            End If

                        End If
                    End If

                    Slipknot.addParameter("parPartname", partname)
                    Slipknot.addParameter("parPartNo", customerPartNo)
                    Slipknot.addParameter("parCustomer", customer)
                    Slipknot.addParameter("parPartNoWoModel", customerPartNoWoModel)
                    Slipknot.addParameter("parNote", note)
                    Slipknot.addParameter("parLotNo", lotNo)
                    Slipknot.addParameter("parQty", qty)
                    Slipknot.addParameter("parUom", uom)
                    Slipknot.addParameter("parFeapCode", feapCode)
                    Slipknot.addParameter("parPONumber", poNumber)
                    Slipknot.addParameter("parPartLevel", partLevel)
                    Slipknot.addParameter("parEnableLotBreakdown", enableLotBD)
                    Slipknot.addParameter("parLotBD1", lotBD1)
                    Slipknot.addParameter("parLotBD2", lotBD2)
                    Slipknot.addParameter("parLotBD3", lotBD3)
                    Slipknot.addParameter("parLotBD4", lotBD4)
                    Slipknot.addParameter("parLotBDQty1", lotBDQty1)
                    Slipknot.addParameter("parLotBDQty2", lotBDQty2)
                    Slipknot.addParameter("parLotBDQty3", lotBDQty3)
                    Slipknot.addParameter("parLotBDQty4", lotBDQty4)
                    Slipknot.addParameter("parCategory", categoryCode)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
                    Slipknot.addParameter("parLastUpdateBy", currentUser.Item("fldUsername"))
                    Slipknot.addParameter("parRemarks", remarks)
                    Slipknot.addParameter("parAdditionalInfo", additionalInfo)

                    Dim success As Boolean = Slipknot.dbAED("SP_InsertLCS")

                    If success Then
                        lineStat = "OK"
                    Else
                        lineStat = "NG"
                    End If

                Next

            End If

            Dim percent As Double = counter / gvRecords.Rows.Count * 100
            lineNo = counter
            RadProgressBarElement1.Text = "Saving..."
            bwSave.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)

        Next

    End Sub

    Private Sub bwSave_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwSave.ProgressChanged
        gvRecords.CurrentRow = gvRecords.Rows(lineNo)
        gvRecords.CurrentRow.Cells(0).Value = lineStat

        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwSave_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwSave.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
    End Sub

    Private Sub gvRecords_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvRecords.CellFormatting
        Dim good As Boolean = False

        If Convert.ToString(e.CellElement.RowInfo.Cells("fldStatus").Value) = "OK" Then
            good = True
        End If

        If (e.CellElement.ColumnInfo.Name = "fldStatus" And e.CellElement.RowInfo.Cells("fldStatus").Value <> String.Empty And good) Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.LimeGreen
        ElseIf (e.CellElement.ColumnInfo.Name = "fldStatus" And e.CellElement.RowInfo.Cells("fldStatus").Value <> String.Empty And good = False) Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.IndianRed
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If

        If Not IsNumeric(e.CellElement.RowInfo.Cells("fldLotNo").Value.ToString.Last) Then
            e.CellElement.RowInfo.Cells("fldSeries").ReadOnly = True
        End If
    End Sub

    Private Sub txtLotNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLotNo.KeyPress
        If illegalChar.Contains(e.KeyChar.ToString) Then
            e.Handled = True
            toolTipWarning.Show(vbNewLine, txtLotNo, 15, 20)

            Exit Sub
        Else
            toolTipWarning.Hide()
        End If
    End Sub

    Private Sub readyToolTipWarning()
        toolTipWarning.ToolTipTitle = "WARNING! You are trying to enter an invalid character."
        toolTipWarning.ToolTipIcon = ToolTipIcon.Error
        toolTipWarning.AutoPopDelay = 5000
        toolTipWarning.InitialDelay = 1000
        toolTipWarning.ReshowDelay = 500
        toolTipWarning.UseAnimation = True
        toolTipWarning.UseFading = True
    End Sub
End Class
