Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class frmEditInventoryTransfer
    Private Sub frmEditInventoryTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        loadFrom()
        loadTo()
        loadShift()
        loadItemCode()

        loadRecord()

    End Sub

    Private Sub loadFrom()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllWarehouseCode")

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

    Private Sub loadTo()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllWarehouseCode")

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 150
        mcbTo.MultiColumnComboBoxElement.Columns.Add(fldDescription)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 100
        mcbTo.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbTo.DataSource = dt
        mcbTo.ValueMember = "fldCode"
        mcbTo.DisplayMember = "fldDescription"
        mcbTo.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbTo.AutoFilter = True
        mcbTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldDescription"
        desc.Operator = FilterOperator.Contains
        mcbTo.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

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

    Private Sub loadRecord()

        Slipknot.addParameter("parId", txtId.Text)

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectInventoryTransferById")

        If dt.Rows.Count > 0 Then

            mcbFrom.SelectedValue = Convert.ToString(dt.Rows(0).Item("fldFrom"))
            mcbTo.SelectedValue = Convert.ToString(dt.Rows(0).Item("fldTo"))
            mcbItemCode.SelectedValue = Convert.ToString(dt.Rows(0).Item("fldItemCode"))
            seTransferedQty.Value = Convert.ToDecimal(dt.Rows(0).Item("fldTransferedQty"))
            mcbShift.SelectedValue = Convert.ToString(dt.Rows(0).Item("fldShiftCode"))
            txtRemarks.Text = Convert.ToString(dt.Rows(0).Item("fldRemarks"))

        End If

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If BulletForMyValentine.isRW("fldModInventoryTransfer") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If mcbFrom.SelectedValue Is Nothing Then
            RadMessageBox.Show("From cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbFrom.Select()
            Exit Sub
        End If

        If mcbTo.SelectedValue Is Nothing Then
            RadMessageBox.Show("To cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbTo.Select()
            Exit Sub
        End If

        If mcbFrom.SelectedValue = mcbTo.SelectedValue Then
            RadMessageBox.Show("Warehouse code from cannot be equal to to", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Item code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemCode.Select()
            Exit Sub
        End If

        If seTransferedQty.Value = 0 Then
            RadMessageBox.Show("Invalid transfered quantity", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbShift.SelectedValue Is Nothing Then
            RadMessageBox.Show("Shift cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbShift.Select()
            Exit Sub
        End If

        If txtRemarks.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Remarks cannot be null", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtRemarks.Focus()
            Exit Sub
        End If

        Slipknot.addParameter("parId", txtId.Text)
        Slipknot.addParameter("parFrom", mcbFrom.SelectedValue)
        Slipknot.addParameter("parTo", mcbTo.SelectedValue)
        Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
        Slipknot.addParameter("parTransferedQty", seTransferedQty.Value)
        Slipknot.addParameter("parShift", mcbShift.SelectedValue)
        Slipknot.addParameter("parRemarks", txtRemarks.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parUpdatedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_UpdateInventoryTransfer") Then
            RadMessageBox.Show("Updated Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub loadShift()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllShifts")

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class
