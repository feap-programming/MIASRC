Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmProcessingFeePreset
    Private Sub FrmCTFormulaSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        loadProcess()
        readyGrid()

        loadRecord()


    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.ReadOnly = True
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldProcess As New GridViewTextBoxColumn("PROCESS")
        fldProcess.FieldName = "process"
        fldProcess.Width = 190
        fldProcess.ReadOnly = True
        gvData.Columns.Add(fldProcess)

        Dim fldItem As New GridViewTextBoxColumn("ITEM")
        fldItem.FieldName = "fldItem"
        fldItem.Width = 170
        fldItem.ReadOnly = True
        gvData.Columns.Add(fldItem)

        Dim fldDelete As New GridViewCommandColumn("DELETE")
        fldDelete.FieldName = "fldDelete"
        fldDelete.Width = 70
        fldDelete.TextAlignment = ContentAlignment.MiddleCenter
        fldDelete.UseDefaultText = True
        fldDelete.DefaultText = "Delete"
        gvData.Columns.Add(fldDelete)

        gvData.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False

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

    Private Sub loadRecord()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT *, (SELECT fldProcessName FROM tblProcess WHERE fldCode = tblProcessingFeePreset.fldProcessCode LIMIT 1) AS process FROM tblProcessingFeePreset")

        gvData.DataSource = dt

    End Sub

    Private Sub dbbRefresh_Click(sender As Object, e As EventArgs)
        loadRecord()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If mcbProcess.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select process properly", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        Slipknot.addParameter("parProcessCode", mcbProcess.SelectedValue)
        Slipknot.addParameter("parItem", txtItem.Text.TrimStart.TrimEnd)

        If Slipknot.dbAED("SP_InsertProcessingFeePreset") Then

            txtItem.Clear()

            loadRecord()
        End If

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.Rows.Count.ToString
    End Sub

    Private Sub deleteRecord()

        If RadMessageBox.Show("Are you sure you want to delete '" & gvData.CurrentRow.Cells("fldItem").Value & "'?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

            Slipknot.addParameter("parID", gvData.CurrentRow.Cells("fldId").Value)

            If Slipknot.dbAED("SP_DeleteProcessingFeePreset") Then
                loadRecord()
            End If

        End If

    End Sub

    Private Sub gvData_CellClick(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellClick
        If gvData.CurrentColumn.HeaderText = "DELETE" Then
            deleteRecord()
        End If
    End Sub
End Class
