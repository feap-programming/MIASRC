Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmCostTable

    Private myData As DataTable
    Private Sub FrmCostTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        dtpYear.Format = DateTimePickerFormat.Custom
        dtpYear.CustomFormat = "yyyy"
        dtpYear.Value = Today

        dtpDateEffect.Format = DateTimePickerFormat.Custom
        dtpDateEffect.CustomFormat = "MMM dd, yyyy"
        dtpDateEffect.Value = Today

        loadItemCode()

        readyGrid()

    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.ReadOnly = True
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldTitle As New GridViewTextBoxColumn("Title")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 250
        gvData.Columns.Add(fldTitle)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 150
        gvData.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 220
        gvData.Columns.Add(fldPartName)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("Customer Part No.")
        fldCustomerPartNo.FieldName = "fldCustomerPartNo"
        fldCustomerPartNo.Width = 150
        gvData.Columns.Add(fldCustomerPartNo)

        Dim customer As New GridViewTextBoxColumn("Customer")
        customer.FieldName = "fldCustomerName"
        customer.Width = 120
        gvData.Columns.Add(customer)

        Dim fldYear As New GridViewDateTimeColumn("Year")
        fldYear.FieldName = "fldYear"
        fldYear.Width = 60
        fldYear.Format = DateTimePickerFormat.Custom
        fldYear.CustomFormat = "yyyy"
        gvData.Columns.Add(fldYear)
        gvData.Columns("fldYear").FormatString = "{0:yyyy}"

        Dim fldDateEffect As New GridViewDateTimeColumn("Date Effect")
        fldDateEffect.FieldName = "fldDateEffect"
        fldDateEffect.Width = 150
        fldDateEffect.Format = DateTimePickerFormat.Custom
        fldDateEffect.CustomFormat = "MMM dd, yyyy"
        gvData.Columns.Add(fldDateEffect)
        gvData.Columns("fldDateEffect").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCategory As New GridViewTextBoxColumn("Category")
        fldCategory.FieldName = "fldCategory"
        fldCategory.Width = 80
        gvData.Columns.Add(fldCategory)

        Dim fldDateAdded As New GridViewDateTimeColumn("Date Added")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("Added By")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvData.Columns.Add(fldAddedBy)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
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

    Private Sub cbbOpenDetails_Click(sender As Object, e As EventArgs) Handles cbbConstructionArea.Click

        If gvData.SelectedRows.Count > 0 Then

            If Slipknot.IsFormOpen(FrmCACostTable) Then
                FrmCACostTable.Focus()
            Else
                FrmCACostTable.txtId.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmCACostTable.Show(Me)
            End If

        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectAllCostTableMain")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmCostTable_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub loadItemCode()

        Dim dtPartNo As DataTable = Slipknot.dbSelect("SP_SelectItemCodeWithCustomerPartNo")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 120
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 250
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("CUSTOMER PART NO.")
        fldCustomerPartNo.FieldName = "fldCustomerPartNo"
        fldCustomerPartNo.Width = 130
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldCustomerPartNo)

        Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE")
        fldModelCode.FieldName = "fldModelCode"
        fldModelCode.Width = 100
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldModelCode)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUSTOMER CODE")
        fldCustomerCode.FieldName = "fldCustomerCode"
        fldCustomerCode.Width = 100
        fldCustomerCode.IsVisible = False
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER")
        fldCustomerName.FieldName = "fldCustomerName"
        fldCustomerName.Width = 80
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        mcbItemCode.DataSource = dtPartNo
        mcbItemCode.ValueMember = "fldItemCode"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 630

        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor
        Dim itemCode As New FilterDescriptor("fldItemCode", FilterOperator.Contains, "")
        Dim partName As New FilterDescriptor("fldPartName", FilterOperator.Contains, "")
        Dim customerpartNo As New FilterDescriptor("fldCustomerPartNo", FilterOperator.Contains, "")

        compositeFilter.FilterDescriptors.Add(itemCode)
        compositeFilter.FilterDescriptors.Add(partName)
        compositeFilter.FilterDescriptors.Add(customerpartNo)

        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        mcbItemCode.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub cbbAddRecord_Click(sender As Object, e As EventArgs) Handles cbbAddRecord.Click

        If txtTitle.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Please put title on this file", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select item properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parTitle", txtTitle.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
        Slipknot.addParameter("parCustomerPartNo", mcbItemCode.EditorControl.CurrentRow.Cells("fldCustomerPartNo").Value)
        Slipknot.addParameter("parCustomerCode", mcbItemCode.EditorControl.CurrentRow.Cells("fldCustomerCode").Value)
        Slipknot.addParameter("parYear", dtpYear.Value)
        Slipknot.addParameter("parDateEffect", dtpDateEffect.Value)
        Slipknot.addParameter("parCategory", ddCategory.Text)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertCostTableMain") Then

            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If

        End If

        'If ddCategory.Text <> "IM" Then

        '    Slipknot.addParameter("parTitle", txtTitle.Text.TrimStart.TrimEnd)
        '    Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
        '    Slipknot.addParameter("parCustomerPartNo", mcbItemCode.EditorControl.CurrentRow.Cells("fldCustomerPartNo").Value)
        '    Slipknot.addParameter("parCustomerCode", mcbItemCode.EditorControl.CurrentRow.Cells("fldCustomerCode").Value)
        '    Slipknot.addParameter("parYear", dtpYear.Value)
        '    Slipknot.addParameter("parDateEffect", dtpDateEffect.Value)
        '    Slipknot.addParameter("parCategory", ddCategory.Text)
        '    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        '    If Slipknot.dbAED("SP_InsertCostTableMain") Then

        '        If bwLoadData.IsBusy = False Then
        '            bwLoadData.RunWorkerAsync()
        '        End If

        '    End If

        'Else

        '    Dim recordId As String
        '    Dim rnd = New Random()
        '    Dim nextValue = rnd.Next(999999)
        '    recordId = nextValue.ToString

        '    Slipknot.addParameter("parId", recordId)
        '    Slipknot.addParameter("parTitle", txtTitle.Text.TrimStart.TrimEnd)
        '    Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
        '    Slipknot.addParameter("parCustomerPartNo", mcbItemCode.EditorControl.CurrentRow.Cells("fldCustomerPartNo").Value)
        '    Slipknot.addParameter("parCustomerCode", mcbItemCode.EditorControl.CurrentRow.Cells("fldCustomerCode").Value)
        '    Slipknot.addParameter("parYear", dtpYear.Value)
        '    Slipknot.addParameter("parDateEffect", dtpDateEffect.Value)
        '    Slipknot.addParameter("parCategory", ddCategory.Text)
        '    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        '    If Slipknot.dbAED("SP_InsertCostTableMain2") Then

        '        Dim dtBOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMMaster WHERE fldParentCode = '" & Convert.ToString(mcbItemCode.SelectedValue) & "' ")

        '        Dim childCode As String = String.Empty
        '        Dim MH As Decimal
        '        Dim MT As Decimal

        '        Dim drMH As DataRow = Slipknot.rowSelectManual("SELECT fldMH, fldMT FROM tblUnitPriceOfMTMH WHERE fldProcessCode = 'P003' ")

        '        If drMH IsNot Nothing Then
        '            MH = Convert.ToDecimal(drMH.Item("fldMH"))
        '            MT = Convert.ToDecimal(drMH.Item("fldMT"))
        '        End If

        '        For Each row As DataRow In dtBOM.Rows

        '            childCode = Convert.ToString(row.Item("fldChildCode"))

        '            Slipknot.addParameter("parRecordID", recordId)
        '            Slipknot.addParameter("parChildCode", childCode)
        '            Slipknot.addParameter("parMH", MH)
        '            Slipknot.addParameter("parMT", MT)

        '            If childCode.Contains("WP") Then
        '                Slipknot.dbAED("SP_InserCTIMChildCode")
        '            Else
        '                myParam.Clear()
        '            End If

        '        Next

        '        If bwLoadData.IsBusy = False Then
        '            bwLoadData.RunWorkerAsync()
        '        End If

        '    End If

        'End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        Dim result As DialogResult = RadMessageBox.Show(Me, "Please confirm to delete Cost Table.", "Deleting", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then

            If gvData.SelectedRows.Count > 0 Then

                If Convert.ToString(gvData.CurrentRow.Cells("fldCategory").Value) = "IM" Then

                    Slipknot.addParameter("id", gvData.CurrentRow.Cells("fldId").Value)
                    If Slipknot.dbAED("SP_DeleteCostTableMainIM") Then
                        gvData.CurrentRow.Delete()
                        RadMessageBox.Show(Me, "Cost Table successfully deleted.", "Deleted", MessageBoxButtons.OK, RadMessageIcon.Info)
                    End If

                Else

                    Slipknot.addParameter("id", gvData.CurrentRow.Cells("fldId").Value)
                    If Slipknot.dbAED("SP_DeleteCostTableMain") Then
                        gvData.CurrentRow.Delete()
                        RadMessageBox.Show(Me, "Cost Table successfully deleted.", "Deleted", MessageBoxButtons.OK, RadMessageIcon.Info)
                    End If

                End If

            End If

        End If

    End Sub

    Private Sub cbbViewReport_Click(sender As Object, e As EventArgs) Handles cbbViewReport.Click

        If gvData.SelectedRows.Count > 0 Then

            reportType = 11

            Slipknot.addReportParameter("parCTID", Convert.ToInt32(gvData.CurrentRow.Cells("fldId").Value))
            Slipknot.addReportParameter("parYear", Convert.ToDateTime(gvData.CurrentRow.Cells("fldYear").Value).ToString("yyyy"))
            Slipknot.addReportParameter("parPartName", Convert.ToString(gvData.CurrentRow.Cells("fldPartName").Value))
            Slipknot.addReportParameter("parCustomerPartNo", Convert.ToString(gvData.CurrentRow.Cells("fldCustomerPartNo").Value))
            Slipknot.addReportParameter("parCustomer", Convert.ToString(gvData.CurrentRow.Cells("fldCustomerName").Value))

            Dim frm As New FrmReport
            frm.Show()

        End If

    End Sub

    Private Sub gvData_SelectionChanged(sender As Object, e As EventArgs) Handles gvData.SelectionChanged

        If gvData.SelectedRows.Count > 0 Then

            If Convert.ToString(gvData.CurrentRow.Cells("fldCategory").Value) = "IM" Then

                cbbConstructionArea.Enabled = False
                cbbOpenEditor.Enabled = True

            Else

                cbbConstructionArea.Enabled = True
                cbbOpenEditor.Enabled = False

            End If

        End If

    End Sub

    Private Sub cbbOpenEditor_Click(sender As Object, e As EventArgs) Handles cbbOpenEditor.Click

        If gvData.SelectedRows.Count > 0 Then

            If Slipknot.IsFormOpen(FrmCostTableEditor) Then
                FrmCostTableEditor.Focus()
            Else
                FrmCostTableEditor.txtId.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmCostTableEditor.Show()
            End If

        End If

    End Sub
End Class
