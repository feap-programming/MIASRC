Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmUnitPriceForMTMH
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

        Dim fldMH As New GridViewDecimalColumn("MH")
        fldMH.FieldName = "fldMH"
        fldMH.Width = 100
        fldMH.ShowUpDownButtons = False
        gvData.Columns.Add(fldMH)

        Dim fldMT As New GridViewDecimalColumn("MT")
        fldMT.FieldName = "fldMT"
        fldMT.Width = 100
        fldMT.ShowUpDownButtons = False
        gvData.Columns.Add(fldMT)

        Dim fldDelete As New GridViewCommandColumn("DELETE")
        fldDelete.FieldName = "fldDelete"
        fldDelete.Width = 70
        fldDelete.TextAlignment = ContentAlignment.MiddleCenter
        fldDelete.UseDefaultText = True
        fldDelete.DefaultText = "Delete"
        gvData.Columns.Add(fldDelete)

        Dim fldSave As New GridViewCommandColumn("UPDATE")
        fldSave.FieldName = "fldSave"
        fldSave.Width = 70
        fldSave.TextAlignment = ContentAlignment.MiddleCenter
        fldSave.UseDefaultText = True
        fldSave.DefaultText = "Update"
        gvData.Columns.Add(fldSave)

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

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT *, (SELECT fldProcessName FROM tblProcess WHERE fldCode = tblUnitPriceOfMTMH.fldProcessCode LIMIT 1) AS process FROM tblUnitPriceOfMTMH")

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
        Slipknot.addParameter("parMH", seMH.Value)
        Slipknot.addParameter("parMT", seMT.Value)

        If Slipknot.dbAED("SP_InsertMTMH") Then
            loadRecord()

            seMH.Value = 0
            seMT.Value = 0
        End If

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.Rows.Count.ToString
    End Sub

    Private Sub deleteRecord()

        If RadMessageBox.Show("Are you sure you want to delete '" & gvData.CurrentRow.Cells("process").Value & "'?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

            Slipknot.addParameter("parID", gvData.CurrentRow.Cells("fldId").Value)

            If Slipknot.dbAED("SP_DeleteMTMH") Then
                loadRecord()
            End If

        End If

    End Sub

    Private Sub updateRecord()

        Slipknot.addParameter("parId", gvData.CurrentRow.Cells("fldId").Value)
        Slipknot.addParameter("parMH", gvData.CurrentRow.Cells("fldMH").Value)
        Slipknot.addParameter("parMT", gvData.CurrentRow.Cells("fldMT").Value)

        If Slipknot.dbAED("SP_UpdateMTMH") Then
            RadMessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub gvData_CellClick(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellClick
        If gvData.CurrentColumn.HeaderText = "DELETE" Then
            deleteRecord()
        ElseIf gvData.CurrentColumn.HeaderText = "UPDATE" Then
            updateRecord()
        End If
    End Sub
End Class
