Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmAddCV
    Private Sub FrmAddCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MMM dd, yyyy"
        dtpDate.Value = Today

        dtpDate2.Format = DateTimePickerFormat.Custom
        dtpDate2.CustomFormat = "MMM dd, yyyy"
        dtpDate2.Value = Today

        loadVendors()
        loadBanks()
        loadGLACcounts()

        readyGridParticular()
        readyGridTrans()

        loadPreparedBy()
        loadCheckedBy()
        loadApprovedBy()
        loadNotedBy()

        If txtId.Text <> String.Empty Then

            txtCVNo.Enabled = False

            loadRecord()
        End If

    End Sub

    Private Sub readyGridParticular()

        Dim fldParticular As New GridViewTextBoxColumn("Particulars")
        fldParticular.FieldName = "fldParticulars"
        fldParticular.Width = 450
        gvParticulars.Columns.Add(fldParticular)

        Dim fldAmount As New GridViewDecimalColumn("Amount")
        fldAmount.FieldName = "fldAmount"
        fldAmount.Width = 90
        fldAmount.ThousandsSeparator = True
        gvParticulars.Columns.Add(fldAmount)
        gvParticulars.Columns("fldAmount").FormatString = "{0:N2}"

        gvParticulars.ShowFilteringRow = False
        gvParticulars.ShowGroupPanel = False

        gvParticulars.TableElement.RowHeight = 25

        Dim fldAmountSum As New GridViewSummaryItem("fldAmount", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldAmountSum)

        gvParticulars.SummaryRowsBottom.Add(summaryRowItem)

    End Sub

    Private Sub readyGridTrans()

        Dim fldAccountCode As New GridViewTextBoxColumn("Account Code")
        fldAccountCode.FieldName = "fldAccountCode"
        fldAccountCode.Width = 110
        fldAccountCode.ReadOnly = True
        gvTrans.Columns.Add(fldAccountCode)

        Dim fldAccountTitle As New GridViewTextBoxColumn("Account Title")
        fldAccountTitle.FieldName = "fldAccountTitle"
        fldAccountTitle.Width = 270
        fldAccountTitle.ReadOnly = True
        gvTrans.Columns.Add(fldAccountTitle)

        Dim fldDebit As New GridViewDecimalColumn("Debit")
        fldDebit.FieldName = "fldDebit"
        fldDebit.Width = 80
        fldDebit.ThousandsSeparator = True
        fldDebit.ReadOnly = True
        gvTrans.Columns.Add(fldDebit)
        gvTrans.Columns("fldDebit").FormatString = "{0:N2}"

        Dim fldCredit As New GridViewDecimalColumn("Credit")
        fldCredit.FieldName = "fldCredit"
        fldCredit.Width = 80
        fldCredit.ThousandsSeparator = True
        fldCredit.ReadOnly = True
        gvTrans.Columns.Add(fldCredit)
        gvTrans.Columns("fldCredit").FormatString = "{0:N2}"

        gvTrans.AllowAddNewRow = False
        gvTrans.ShowFilteringRow = False
        gvTrans.ShowGroupPanel = False

        gvTrans.TableElement.RowHeight = 25

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim debit As Decimal = 0
        Dim credit As Decimal = 0

        For Each row As GridViewRowInfo In gvTrans.Rows

            debit = debit + Convert.ToDecimal(row.Cells("fldDebit").Value)
            credit = credit + Convert.ToDecimal(row.Cells("fldCredit").Value)

        Next

        If debit <> credit Then
            RadMessageBox.Show("Total debit amount should equal to total credit amount", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbPayee.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select payee properly", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbPayee.Select()
            Exit Sub
        End If

        If mcbBank.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select bank properly", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbBank.Select()
            Exit Sub
        End If

        If mcbPreparedBy.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select prepared by", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbPreparedBy.Select()
            Exit Sub
        End If

        If mcbCheckedBy.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select checked by", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbCheckedBy.Select()
            Exit Sub
        End If

        If mcbApprovedBy.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select approved by", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbApprovedBy.Select()
            Exit Sub
        End If

        If mcbNotedBy.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select noted by", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbNotedBy.Select()
            Exit Sub
        End If

        If txtCVNo.Text = String.Empty Then
            addNewRecord()
        Else
            editRecord()
        End If

    End Sub

    Private Sub addNewRecord()

        Dim cvNo As Integer

        Dim getLastNo As DataRow = Slipknot.rowSelectManual("SELECT MAX(fldCVNo) AS cvNo FROM tblCVMain WHERE fldCategory = '" & ddCategory.Text & "' ")

        If Convert.ToString(getLastNo.Item("cvNo")) <> String.Empty Then
            cvNo = Convert.ToInt32(getLastNo.Item("cvNo")) + 1
        Else
            Dim getInitialNo As DataRow

            If ddCategory.Text = "Check Voucher" Then
                getInitialNo = Slipknot.rowSelectManual("SELECT fldLastCVNo AS cvNo FROM tblSettings")
            Else
                getInitialNo = Slipknot.rowSelectManual("SELECT fldLastBTNo AS cvNo FROM tblSettings")
            End If

            cvNo = Convert.ToInt32(getInitialNo.Item("cvNo")) + 1
        End If

        Slipknot.addParameter("parCategory", ddCategory.Text)
        Slipknot.addParameter("parCVNo", cvNo)
        Slipknot.addParameter("parPayee", Convert.ToString(mcbPayee.SelectedValue))
        Slipknot.addParameter("parOtherPayee", txtOtherPayee.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parDate", dtpDate.Value)
        Slipknot.addParameter("parAmountInWords", lblAmountInWords.Text)
        Slipknot.addParameter("parCurrency", ddCurrency.Text)
        Slipknot.addParameter("parReceivedBy", txtReceivedBy.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parBankName", Convert.ToString(mcbBank.SelectedValue))

        If txtCheckNo.Text.TrimStart.TrimEnd = String.Empty Then
            Slipknot.addParameter("parCheckNo", DBNull.Value)
        Else
            Slipknot.addParameter("parCheckNo", txtCheckNo.Text.TrimStart.TrimEnd)
        End If

        Slipknot.addParameter("parProvisionalReceiptNo", txtProvision.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPONo", txtPONo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parInvNo", txtInvNo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPreparedBy", Convert.ToString(mcbPreparedBy.SelectedValue))
        Slipknot.addParameter("parPreparedByTitle", Convert.ToString(mcbPreparedBy.EditorControl.CurrentRow.Cells("fldTitle").Value))
        Slipknot.addParameter("parCheckedBy", Convert.ToString(mcbCheckedBy.SelectedValue))
        Slipknot.addParameter("parCheckedByTitle", Convert.ToString(mcbCheckedBy.EditorControl.CurrentRow.Cells("fldTitle").Value))
        Slipknot.addParameter("parApprovedBy", Convert.ToString(mcbApprovedBy.SelectedValue))
        Slipknot.addParameter("parApprovedByTitle", Convert.ToString(mcbApprovedBy.EditorControl.CurrentRow.Cells("fldTitle").Value))
        Slipknot.addParameter("parNotedBy", Convert.ToString(mcbNotedBy.SelectedValue))
        Slipknot.addParameter("parNotedByTitle", Convert.ToString(mcbNotedBy.EditorControl.CurrentRow.Cells("fldTitle").Value))
        Slipknot.addParameter("parDateAdded", Now)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertCVMain") Then

            For Each row As GridViewRowInfo In gvParticulars.Rows
                Slipknot.addParameter("parCVNo", cvNo)
                Slipknot.addParameter("parParticulars", Convert.ToString(row.Cells("fldParticulars").Value).TrimStart.TrimStart)
                Slipknot.addParameter("parAmount", Convert.ToDecimal(row.Cells("fldAmount").Value))

                Slipknot.dbAED("SP_InsertCVParticulars")
            Next

            For Each row As GridViewRowInfo In gvTrans.Rows
                Slipknot.addParameter("parCVNo", cvNo)
                Slipknot.addParameter("parAccountCode", Convert.ToString(row.Cells("fldAccountCode").Value).TrimStart.TrimStart)
                Slipknot.addParameter("parAccountTitle", Convert.ToString(row.Cells("fldAccountTitle").Value).TrimStart.TrimEnd)
                Slipknot.addParameter("parDebit", Convert.ToDecimal(row.Cells("fldDebit").Value))
                Slipknot.addParameter("parCredit", Convert.ToDecimal(row.Cells("fldCredit").Value))

                Slipknot.dbAED("SP_InsertCVTrans")
            Next

            txtCVNo.Text = cvNo
            btnSave.Enabled = False

            FrmCheckVoucher.bwLoadData.RunWorkerAsync()

            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub editRecord()

        Slipknot.addParameter("parCategory", ddCategory.Text)
        Slipknot.addParameter("parCVNo", txtCVNo.Text)
        Slipknot.addParameter("parPayee", Convert.ToString(mcbPayee.SelectedValue))
        Slipknot.addParameter("parOtherPayee", txtOtherPayee.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parDate", dtpDate.Value)
        Slipknot.addParameter("parAmountInWords", lblAmountInWords.Text)
        Slipknot.addParameter("parCurrency", ddCurrency.Text)
        Slipknot.addParameter("parReceivedBy", txtReceivedBy.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parBankName", Convert.ToString(mcbBank.SelectedValue))

        If txtCheckNo.Text.TrimStart.TrimEnd = String.Empty Then
            Slipknot.addParameter("parCheckNo", DBNull.Value)
        Else
            Slipknot.addParameter("parCheckNo", txtCheckNo.Text.TrimStart.TrimEnd)
        End If

        Slipknot.addParameter("parProvisionalReceiptNo", txtProvision.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPONo", txtPONo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parInvNo", txtInvNo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPreparedBy", Convert.ToString(mcbPreparedBy.SelectedValue))
        Slipknot.addParameter("parPreparedByTitle", Convert.ToString(mcbPreparedBy.EditorControl.CurrentRow.Cells("fldTitle").Value))
        Slipknot.addParameter("parCheckedBy", Convert.ToString(mcbCheckedBy.SelectedValue))
        Slipknot.addParameter("parCheckedByTitle", Convert.ToString(mcbCheckedBy.EditorControl.CurrentRow.Cells("fldTitle").Value))
        Slipknot.addParameter("parApprovedBy", Convert.ToString(mcbApprovedBy.SelectedValue))
        Slipknot.addParameter("parApprovedByTitle", Convert.ToString(mcbApprovedBy.EditorControl.CurrentRow.Cells("fldTitle").Value))
        Slipknot.addParameter("parNotedBy", Convert.ToString(mcbNotedBy.SelectedValue))
        Slipknot.addParameter("parNotedByTitle", Convert.ToString(mcbNotedBy.EditorControl.CurrentRow.Cells("fldTitle").Value))

        If Slipknot.dbAED("SP_UpdateCVMain") Then

            For Each row As GridViewRowInfo In gvParticulars.Rows
                Slipknot.addParameter("parCVNo", txtCVNo.Text)
                Slipknot.addParameter("parParticulars", Convert.ToString(row.Cells("fldParticulars").Value).TrimStart.TrimStart)
                Slipknot.addParameter("parAmount", Convert.ToDecimal(row.Cells("fldAmount").Value))

                Slipknot.dbAED("SP_InsertCVParticulars")
            Next

            For Each row As GridViewRowInfo In gvTrans.Rows
                Slipknot.addParameter("parCVNo", txtCVNo.Text)
                Slipknot.addParameter("parAccountCode", Convert.ToString(row.Cells("fldAccountCode").Value).TrimStart.TrimStart)
                Slipknot.addParameter("parAccountTitle", Convert.ToString(row.Cells("fldAccountTitle").Value).TrimStart.TrimEnd)
                Slipknot.addParameter("parDebit", Convert.ToDecimal(row.Cells("fldDebit").Value))
                Slipknot.addParameter("parCredit", Convert.ToDecimal(row.Cells("fldCredit").Value))

                Slipknot.dbAED("SP_InsertCVTrans")
            Next

            FrmCheckVoucher.bwLoadData.RunWorkerAsync()

            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub gvParticulars_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvParticulars.ViewCellFormatting
        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)

        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            e.CellElement.BorderTopColor = Color.Black
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed
        End If
    End Sub

    Private Sub gvParticulars_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvParticulars.RowsChanged

        makeAmountInWords()

    End Sub

    Private Sub makeAmountInWords()

        Dim mySum As Decimal

        For Each row As GridViewRowInfo In gvParticulars.Rows

            mySum = mySum + Convert.ToDecimal(row.Cells("fldAmount").Value)

        Next

        Dim wordCurrency As String = Nothing

        If ddCurrency.Text = "PHP" Then

            wordCurrency = " pesos only."

        ElseIf ddCurrency.Text = "JPY" Then

            wordCurrency = " Japanese Yen only."

        ElseIf ddCurrency.Text = "USD" Then

            wordCurrency = " US Dollar only."

        End If

        Dim decimalPointWord As String = String.Empty

        Dim decimalPoint As Decimal = mySum - Int(mySum)

        If decimalPoint > 0 Then

            Dim decimalPointString As String = Convert.ToString(decimalPoint).Replace(".", "")

            decimalPointString = Convert.ToInt32(decimalPointString)

            decimalPointWord = " And " & decimalPointString & " / 100 "

        End If

        'lblAmountInWords.Text = Slipknot.NumberToText(mySum) & decimalPointWord & wordCurrency

        lblAmountInWords.Text = Slipknot.ConvertNumberToENG(Math.Floor(mySum)) & decimalPointWord & wordCurrency

    End Sub



    Private Sub loadRecord()

        Dim row As DataRow = Slipknot.rowSelectManual("SELECT * FROM tblCVMain WHERE fldId = '" & txtId.Text & "'")

        If row IsNot Nothing Then

            ddCategory.Text = Convert.ToString(row.Item("fldCategory"))
            txtCVNo.Text = Convert.ToString(row.Item("fldCVNo"))
            mcbPayee.SelectedValue = Convert.ToString(row.Item("fldPayee"))
            txtOtherPayee.Text = Convert.ToString(row.Item("fldOtherPayee"))
            dtpDate.Value = Convert.ToDateTime(row.Item("fldDate"))
            ddCurrency.Text = Convert.ToString(row.Item("fldCurrency"))
            txtReceivedBy.Text = Convert.ToString(row.Item("fldReceivedBy"))
            mcbBank.SelectedValue = Convert.ToString(row.Item("fldBankName"))
            txtCheckNo.Text = Convert.ToString(row.Item("fldCheckNo"))
            txtProvision.Text = Convert.ToString(row.Item("fldProvisionalReceiptNo"))
            txtPONo.Text = Convert.ToString(row.Item("fldPONo"))
            txtInvNo.Text = Convert.ToString(row.Item("fldInvNo"))

            mcbPreparedBy.SelectedValue = Convert.ToString(row.Item("fldPreparedBy"))
            mcbCheckedBy.SelectedValue = Convert.ToString(row.Item("fldCheckedBy"))
            mcbApprovedBy.SelectedValue = Convert.ToString(row.Item("fldApprovedBy"))
            mcbNotedBy.SelectedValue = Convert.ToString(row.Item("fldNotedBy"))

            Dim dtParticulars As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCVParticulars WHERE fldCVNo = '" & txtCVNo.Text & "' ")

            gvParticulars.DataSource = dtParticulars

            Dim dtTrans As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCVTrans WHERE fldCVNo = '" & txtCVNo.Text & "' ")

            gvTrans.DataSource = dtTrans

        End If

    End Sub

    Private Sub loadVendors()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldCode, fldVendorName FROM tblVendors")

        Dim fldCode As New GridViewTextBoxColumn("Code")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 100
        mcbPayee.MultiColumnComboBoxElement.Columns.Add(fldCode)

        Dim fldVendorName As New GridViewTextBoxColumn("Vendor Name")
        fldVendorName.FieldName = "fldVendorName"
        fldVendorName.Width = 350
        mcbPayee.MultiColumnComboBoxElement.Columns.Add(fldVendorName)

        mcbPayee.DataSource = dt
        mcbPayee.ValueMember = "fldCode"
        mcbPayee.DisplayMember = "fldVendorName"

        mcbPayee.AutoFilter = True
        mcbPayee.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        mcbPayee.MultiColumnComboBoxElement.DropDownWidth = 500

        'mcbGLAccount.AutoSizeDropDownToBestFit = True

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim filterCode As New FilterDescriptor("fldCode", FilterOperator.Contains, "")
        Dim filterName As New FilterDescriptor("fldVendorName", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(filterCode)
        compositeFilter.FilterDescriptors.Add(filterName)
        compositeFilter.LogicalOperator = FilterLogicalOperator.Or
        mcbPayee.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub loadBanks()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldCode, fldBankName FROM tblBanks")

        Dim fldCode As New GridViewTextBoxColumn("Code")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 100
        mcbBank.MultiColumnComboBoxElement.Columns.Add(fldCode)

        Dim fldBankName As New GridViewTextBoxColumn("Bank Name")
        fldBankName.FieldName = "fldBankName"
        fldBankName.Width = 350
        mcbBank.MultiColumnComboBoxElement.Columns.Add(fldBankName)

        mcbBank.DataSource = dt
        mcbBank.ValueMember = "fldCode"
        mcbBank.DisplayMember = "fldBankName"

        mcbBank.AutoFilter = True
        mcbBank.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        mcbBank.MultiColumnComboBoxElement.DropDownWidth = 500

        'mcbGLAccount.AutoSizeDropDownToBestFit = True

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim filterCode As New FilterDescriptor("fldCode", FilterOperator.Contains, "")
        Dim filterName As New FilterDescriptor("fldBankName", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(filterCode)
        compositeFilter.FilterDescriptors.Add(filterName)
        compositeFilter.LogicalOperator = FilterLogicalOperator.Or
        mcbBank.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub loadPreparedBy()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldName, fldTitle FROM tblSignatory ORDER BY fldName ASC")

        Dim fldName As New GridViewTextBoxColumn("Name")
        fldName.FieldName = "fldName"
        fldName.Width = 200
        mcbPreparedBy.MultiColumnComboBoxElement.Columns.Add(fldName)

        Dim fldTitle As New GridViewTextBoxColumn("Title")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 220
        mcbPreparedBy.MultiColumnComboBoxElement.Columns.Add(fldTitle)

        mcbPreparedBy.DataSource = dt
        mcbPreparedBy.ValueMember = "fldName"
        mcbPreparedBy.DisplayMember = "fldName"

        mcbPreparedBy.AutoFilter = True
        mcbPreparedBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        mcbPreparedBy.MultiColumnComboBoxElement.DropDownWidth = 500

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim filterName As New FilterDescriptor("fldName", FilterOperator.Contains, "")
        Dim filterTitle As New FilterDescriptor("fldTitle", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(filterName)
        compositeFilter.FilterDescriptors.Add(filterTitle)
        compositeFilter.LogicalOperator = FilterLogicalOperator.Or
        mcbPreparedBy.EditorControl.FilterDescriptors.Add(compositeFilter)

        mcbPreparedBy.SelectedIndex = -1
    End Sub

    Private Sub loadCheckedBy()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldName, fldTitle FROM tblSignatory ORDER BY fldName ASC")

        Dim fldName As New GridViewTextBoxColumn("Name")
        fldName.FieldName = "fldName"
        fldName.Width = 200
        mcbCheckedBy.MultiColumnComboBoxElement.Columns.Add(fldName)

        Dim fldTitle As New GridViewTextBoxColumn("Title")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 220
        mcbCheckedBy.MultiColumnComboBoxElement.Columns.Add(fldTitle)

        mcbCheckedBy.DataSource = dt
        mcbCheckedBy.ValueMember = "fldName"
        mcbCheckedBy.DisplayMember = "fldName"

        mcbCheckedBy.AutoFilter = True
        mcbCheckedBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        mcbCheckedBy.MultiColumnComboBoxElement.DropDownWidth = 500

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim filterName As New FilterDescriptor("fldName", FilterOperator.Contains, "")
        Dim filterTitle As New FilterDescriptor("fldTitle", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(filterName)
        compositeFilter.FilterDescriptors.Add(filterTitle)
        compositeFilter.LogicalOperator = FilterLogicalOperator.Or
        mcbCheckedBy.EditorControl.FilterDescriptors.Add(compositeFilter)

        mcbCheckedBy.SelectedIndex = -1
    End Sub

    Private Sub loadApprovedBy()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldName, fldTitle FROM tblSignatory ORDER BY fldName ASC")

        Dim fldName As New GridViewTextBoxColumn("Name")
        fldName.FieldName = "fldName"
        fldName.Width = 200
        mcbApprovedBy.MultiColumnComboBoxElement.Columns.Add(fldName)

        Dim fldTitle As New GridViewTextBoxColumn("Title")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 220
        mcbApprovedBy.MultiColumnComboBoxElement.Columns.Add(fldTitle)

        mcbApprovedBy.DataSource = dt
        mcbApprovedBy.ValueMember = "fldName"
        mcbApprovedBy.DisplayMember = "fldName"

        mcbApprovedBy.AutoFilter = True
        mcbApprovedBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        mcbApprovedBy.MultiColumnComboBoxElement.DropDownWidth = 500

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim filterName As New FilterDescriptor("fldName", FilterOperator.Contains, "")
        Dim filterTitle As New FilterDescriptor("fldTitle", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(filterName)
        compositeFilter.FilterDescriptors.Add(filterTitle)
        compositeFilter.LogicalOperator = FilterLogicalOperator.Or
        mcbApprovedBy.EditorControl.FilterDescriptors.Add(compositeFilter)

        mcbApprovedBy.SelectedIndex = -1
    End Sub

    Private Sub loadNotedBy()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldName, fldTitle FROM tblSignatory ORDER BY fldName ASC")

        Dim fldName As New GridViewTextBoxColumn("Name")
        fldName.FieldName = "fldName"
        fldName.Width = 200
        mcbNotedBy.MultiColumnComboBoxElement.Columns.Add(fldName)

        Dim fldTitle As New GridViewTextBoxColumn("Title")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 220
        mcbNotedBy.MultiColumnComboBoxElement.Columns.Add(fldTitle)

        mcbNotedBy.DataSource = dt
        mcbNotedBy.ValueMember = "fldName"
        mcbNotedBy.DisplayMember = "fldName"

        mcbNotedBy.AutoFilter = True
        mcbNotedBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        mcbNotedBy.MultiColumnComboBoxElement.DropDownWidth = 500

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim filterName As New FilterDescriptor("fldName", FilterOperator.Contains, "")
        Dim filterTitle As New FilterDescriptor("fldTitle", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(filterName)
        compositeFilter.FilterDescriptors.Add(filterTitle)
        compositeFilter.LogicalOperator = FilterLogicalOperator.Or
        mcbNotedBy.EditorControl.FilterDescriptors.Add(compositeFilter)

        mcbNotedBy.SelectedIndex = -1
    End Sub

    Private Sub loadGLACcounts()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldAccountCode, fldAccountTitle FROM tblGLAccounts")

        Dim fldAccountCode As New GridViewTextBoxColumn("Account Code")
        fldAccountCode.FieldName = "fldAccountCode"
        fldAccountCode.Width = 100
        mcbGLAccount.MultiColumnComboBoxElement.Columns.Add(fldAccountCode)

        Dim fldAccountTitle As New GridViewTextBoxColumn("Account Title")
        fldAccountTitle.FieldName = "fldAccountTitle"
        fldAccountTitle.Width = 350
        mcbGLAccount.MultiColumnComboBoxElement.Columns.Add(fldAccountTitle)

        mcbGLAccount.DataSource = dt
        mcbGLAccount.ValueMember = "fldAccountCode"
        mcbGLAccount.DisplayMember = "fldAccountTitle"

        mcbGLAccount.AutoFilter = True
        mcbGLAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        mcbGLAccount.MultiColumnComboBoxElement.DropDownWidth = 500

        'mcbGLAccount.AutoSizeDropDownToBestFit = True

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim filterCode As New FilterDescriptor("fldAccountCode", FilterOperator.Contains, "")
        Dim filterDeptName As New FilterDescriptor("fldAccountTitle", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(filterCode)
        compositeFilter.FilterDescriptors.Add(filterDeptName)
        compositeFilter.LogicalOperator = FilterLogicalOperator.Or
        mcbGLAccount.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        dtpDate2.Value = dtpDate.Value
    End Sub

    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click

        If seGLAmount.Value < 0 Then

            RadMessageBox.Show("Invalid Amount", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        Else

            If mcbGLAccount.SelectedIndex <> -1 Then

                If isGLAdded(Convert.ToString(mcbGLAccount.SelectedValue)) Then
                    RadMessageBox.Show("GL Account is already added to the list", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

                    Exit Sub
                End If

                Dim debitAmount As Decimal = 0
                Dim creditAmount As Decimal = 0

                If rbtnDebit.IsChecked Then
                    debitAmount = seGLAmount.Value
                Else
                    creditAmount = seGLAmount.Value
                End If

                gvTrans.Rows.Add(Convert.ToString(mcbGLAccount.SelectedValue), Convert.ToString(mcbGLAccount.EditorControl.CurrentRow.Cells("fldAccountTitle").Value), debitAmount, creditAmount)

            Else
                RadMessageBox.Show("Please select GL account properly", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If

        End If

    End Sub

    Private Function isGLAdded(ByVal accountTitle As String) As Boolean

        For Each row As GridViewRowInfo In gvTrans.Rows

            If accountTitle = Convert.ToString(row.Cells("fldAccountCode").Value) Then

                Return True
                Exit Function
            End If

        Next

        Return False

    End Function

    Private Sub ddCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddCurrency.SelectedIndexChanged
        makeAmountInWords()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
