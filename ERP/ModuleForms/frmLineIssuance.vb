Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmLineIssuance

    Private dtpFrom As New RadDateTimePicker
    Private dtpTo As New RadDateTimePicker

    Private myData As DataTable
    Private Sub FrmLineIssuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        cbhFrom.HostedItem = dtpFrom.DateTimePickerElement
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MMM dd, yyyy"
        dtpFrom.Value = Today

        cbhTo.HostedItem = dtpTo.DateTimePickerElement
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.CustomFormat = "MMM dd, yyyy"
        dtpTo.Value = Today

        loadFrom()
        loadLine()
        loadShift()
        loadItemCode()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 80
        gvData.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 220
        gvData.Columns.Add(fldPartName)

        Dim fldFrom As New GridViewTextBoxColumn("FROM")
        fldFrom.FieldName = "whseFrom"
        fldFrom.Width = 210
        gvData.Columns.Add(fldFrom)

        Dim fldTo As New GridViewTextBoxColumn("TO")
        fldTo.FieldName = "lineTo"
        fldTo.Width = 130
        gvData.Columns.Add(fldTo)

        Dim fldTransferedQty As New GridViewDecimalColumn("ISSUED QTY")
        fldTransferedQty.FieldName = "fldTransferedQty"
        fldTransferedQty.Width = 110
        gvData.Columns.Add(fldTransferedQty)
        gvData.Columns("fldTransferedQty").FormatString = "{0:N2}"

        Dim fldShiftName As New GridViewTextBoxColumn("SHIFT")
        fldShiftName.FieldName = "fldShiftName"
        fldShiftName.Width = 90
        gvData.Columns.Add(fldShiftName)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvData.Columns.Add(fldAddedBy)

        Dim fldLastDateUpdate As New GridViewDateTimeColumn("LAST UPDATE DATE")
        fldLastDateUpdate.FieldName = "fldLastDateUpdate"
        fldLastDateUpdate.Width = 170
        fldLastDateUpdate.Format = DateTimePickerFormat.Custom
        fldLastDateUpdate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldLastDateUpdate)
        gvData.Columns("fldLastDateUpdate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldLastUpdatedBy As New GridViewTextBoxColumn("LAST UPDATE BY")
        fldLastUpdatedBy.FieldName = "fldLastUpdatedBy"
        fldLastUpdatedBy.Width = 150
        gvData.Columns.Add(fldLastUpdatedBy)

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS")
        fldRemarks.FieldName = "fldRemarks"
        fldRemarks.Width = 200
        gvData.Columns.Add(fldRemarks)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

        Dim fldTransferedQtySum As New GridViewSummaryItem("fldTransferedQty", "{0:N2}", GridAggregateFunction.Sum)

        Dim summaryRowItem As New GridViewSummaryRowItem

        summaryRowItem.Add(fldTransferedQtySum)

        gvData.SummaryRowsBottom.Add(summaryRowItem)

    End Sub

    Private Sub loadFrom()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllWarehouseCode")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldDescription", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 150
        mcbFrom.MultiColumnComboBoxElement.Columns.Add(fldDescription)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 100
        mcbFrom.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbFrom.DataSource = dt
        mcbFrom.ValueMember = "fldCode"
        mcbFrom.DisplayMember = "fldDescription"
        mcbFrom.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbFrom.AutoFilter = True
        mcbFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldDescription"
        desc.Operator = FilterOperator.Contains
        mcbFrom.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub

    Private Sub loadLine()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllLines")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldLineName", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldLineName As New GridViewTextBoxColumn("LINE NAME")
        fldLineName.FieldName = "fldLineName"
        fldLineName.Width = 150
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldLineName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 100
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbLine.DataSource = dt
        mcbLine.ValueMember = "fldCode"
        mcbLine.DisplayMember = "fldLineName"
        mcbLine.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbLine.AutoFilter = True
        mcbLine.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor()
        name.PropertyName = "fldLineName"
        name.Operator = FilterOperator.Contains
        mcbLine.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

    End Sub

    Private Sub loadItemCode()

        Dim dtItemCode As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 70
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 150
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemCode.DataSource = dtItemCode
        mcbItemCode.ValueMember = "fldItemCode"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCode.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub

    Private Sub rbtnBarcode_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbtnBarcode.ToggleStateChanged
        If rbtnBarcode.CheckState = CheckState.Checked Then

            lblBarcode.Enabled = True
            txtBarcode.Enabled = True

            lblTo.Enabled = False
            lblItemCode.Enabled = False
            lblReceivedQty.Enabled = False
            mcbLine.Enabled = False
            mcbItemCode.Enabled = False
            seReceivedQty.Enabled = False

            cbbAdd.Enabled = False

            txtBarcode.Focus()

        Else
            lblBarcode.Enabled = False
            txtBarcode.Enabled = False

            lblTo.Enabled = True
            lblItemCode.Enabled = True
            lblReceivedQty.Enabled = True
            mcbLine.Enabled = True
            mcbItemCode.Enabled = True
            seReceivedQty.Enabled = True

            cbbAdd.Enabled = True

            mcbFrom.Select()
        End If
    End Sub

    Private Sub FrmLineIssuance_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtBarcode.Focus()

        mcbItemCode.SelectedIndex = -1

        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
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
        myData = Slipknot.dbSelect("SP_SelectAllLineIssuance")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If BulletForMyValentine.isRW("fldModLineIssuance") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If mcbFrom.SelectedValue Is Nothing Then
            RadMessageBox.Show("From cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbFrom.Select()
            Exit Sub
        End If

        If mcbShift.SelectedValue Is Nothing Then
            RadMessageBox.Show("Shift cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbShift.Select()
            Exit Sub
        End If

        If mcbLine.SelectedValue Is Nothing Then
            RadMessageBox.Show("Line cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbLine.Select()
            Exit Sub
        End If

        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Item code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemCode.Select()
            Exit Sub
        End If

        If seReceivedQty.Value = 0 Then
            RadMessageBox.Show("Invalid received quantity", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        addEntry()

    End Sub

    Private Sub addEntry()

        Dim itemCode As String
        Dim line As String
        Dim transferredQty As Decimal

        If rbtnManual.IsChecked Then
            itemCode = mcbItemCode.SelectedValue
            line = Convert.ToString(mcbLine.EditorControl.CurrentRow.Cells("fldLineName").Value)
            transferredQty = seReceivedQty.Value
        Else
            itemCode = txtBarcode.Text.Substring(0, 20).TrimStart.TrimEnd
            line = txtBarcode.Text.Substring(20, 20).TrimStart.TrimEnd
            transferredQty = txtBarcode.Text.Substring(40, 10)
        End If

        If BulletForMyValentine.checkItemCodeIfExist(itemCode) = False Then
            RadMessageBox.Show("Item code not found!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If BulletForMyValentine.checkLineIfExists(line) IsNot Nothing Then
            line = BulletForMyValentine.checkLineIfExists(line)
        Else
            RadMessageBox.Show("Line not found!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parItemCode", itemCode)
        Slipknot.addParameter("parFrom", mcbFrom.SelectedValue)
        Slipknot.addParameter("parTo", line)
        Slipknot.addParameter("parTransferredQty", transferredQty)
        Slipknot.addParameter("parShift", mcbShift.SelectedValue)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertLineIssuance") Then
            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If BulletForMyValentine.isRW("fldModLineIssuance") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            If mcbFrom.SelectedValue Is Nothing Then
                RadMessageBox.Show("From cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

                txtBarcode.Clear()
                mcbFrom.Select()
                Exit Sub
            End If

            If mcbShift.SelectedValue Is Nothing Then
                RadMessageBox.Show("Shift cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

                txtBarcode.Clear()
                mcbShift.Select()
                Exit Sub
            End If

            addEntry()

            txtBarcode.Clear()
            txtBarcode.Focus()

        End If
    End Sub

    Private Sub bwDelete_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDelete.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwDelete.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("parIdArray", id)
        Slipknot.dbAED("SP_DeleteLineIssuance")
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        If BulletForMyValentine.isRW("fldModLineIssuance") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwDelete.IsBusy = False Then
                    bwDelete.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Function isPermmited() As Boolean
        Dim check As String = Slipknot.checkPermission(frmBase.leUsername.Text, "fldModLineIssuance")

        If check <> "RW" Then
            Slapshock.NoAccessToFunctionMessage()

            Return False
        End If

        Return True
    End Function

    Private Sub bwDelete_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwDelete.ProgressChanged
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwDelete_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDelete.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

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

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If Slipknot.IsFormOpen(frmEditLineIssuance) Then
            frmEditLineIssuance.Focus()
        Else
            If BulletForMyValentine.isRW("fldModLineIssuance") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If

            If gvData.SelectedRows.Count > 0 Then
                frmEditLineIssuance.txtId.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                frmEditLineIssuance.Show(Me)
            End If
        End If
    End Sub

    Private Sub gvData_ViewCellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.ViewCellFormatting
        Dim font_Renamed As Font = New Font(e.CellElement.Font, FontStyle.Bold)

        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.DrawBorder = True
            e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders
            e.CellElement.BorderLeftWidth = 0
            e.CellElement.BorderRightWidth = 0
            e.CellElement.BorderBottomWidth = 0
            e.CellElement.BorderTopWidth = 3
            'e.CellElement.BorderTopColor = DefaultBackColor
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight

            e.CellElement.ForeColor = Color.Green
            e.CellElement.Font = font_Renamed
        End If
    End Sub

    Private Sub loadShift()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllShifts")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldShiftName", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldShiftName As New GridViewTextBoxColumn("SHIFT")
        fldShiftName.FieldName = "fldShiftName"
        fldShiftName.Width = 150
        mcbShift.MultiColumnComboBoxElement.Columns.Add(fldShiftName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 100
        mcbShift.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbShift.DataSource = dt
        mcbShift.ValueMember = "fldCode"
        mcbShift.DisplayMember = "fldShiftName"
        mcbShift.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbShift.AutoFilter = True
        mcbShift.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldShiftName"
        desc.Operator = FilterOperator.Contains
        mcbShift.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub
End Class
