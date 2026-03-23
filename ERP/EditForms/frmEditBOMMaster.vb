Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmEditBOMMaster

    Private origParentCode As String
    Private origChildCode As String
    Private origUsage As Decimal
    Private origRemarks As String
    Private Sub FrmEditBOMMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadDropDown()
        loadData()
    End Sub

    Private Sub loadDropDown()

        'LOAD PART NO. HISTORY

        Dim dtPartNoHistory As DataTable = Slipknot.dbSelect("SP_SelectAllItemCode")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 160
        mcbParent.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 160
        mcbParent.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbParent.DataSource = dtPartNoHistory
        mcbParent.ValueMember = "fldItemCode"
        mcbParent.DisplayMember = "fldItemCode"
        mcbParent.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbParent.AutoFilter = True
        mcbParent.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbParent.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

        'LOAD PART NO. HISTORY

        Dim dtPartNoHistory2 As DataTable = Slipknot.dbSelect("SP_SelectAllItemCode")

        Dim fldItemCode2 As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode2.FieldName = "fldItemCode"
        fldItemCode2.Width = 160
        mcbChild.MultiColumnComboBoxElement.Columns.Add(fldItemCode2)

        Dim fldPartName2 As New GridViewTextBoxColumn("PART NAME")
        fldPartName2.FieldName = "fldPartName"
        fldPartName2.Width = 160
        mcbChild.MultiColumnComboBoxElement.Columns.Add(fldPartName2)

        mcbChild.DataSource = dtPartNoHistory2
        mcbChild.ValueMember = "fldItemCode"
        mcbChild.DisplayMember = "fldItemCode"
        mcbChild.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbChild.AutoFilter = True
        mcbChild.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode2 As New FilterDescriptor()
        itemCode2.PropertyName = "fldItemCode"
        itemCode2.Operator = FilterOperator.Contains
        mcbChild.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode2)

    End Sub

    Private Sub loadData()

        Slipknot.addParameter("parId", txtID.Text)
        Dim record As DataTable = Slipknot.dbSelect("SP_SelectBOMMasterByID")

        If record.Rows.Count > 0 Then

            origParentCode = Convert.ToString(record.Rows(0).Item("fldParentCode"))
            origChildCode = Convert.ToString(record.Rows(0).Item("fldChildCode"))
            origUsage = Convert.ToDecimal(record.Rows(0).Item("fldUsage"))
            origRemarks = Convert.ToString(record.Rows(0).Item("fldRemarks"))

            mcbParent.SelectedValue = origParentCode
            mcbChild.SelectedValue = origChildCode
            seUsage.Value = origUsage
            txtRemarks.Text = origRemarks

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If mcbParent.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please parent part number properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbParent.SelectedValue = origParentCode
            Exit Sub
        End If

        If mcbChild.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please child part number properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbChild.SelectedValue = origChildCode
            Exit Sub
        End If

        If mcbParent.SelectedValue = mcbChild.SelectedValue Then
            RadMessageBox.Show("Parent part no. cannot be equal to child part no.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbParent.SelectedValue = origParentCode
            mcbChild.SelectedValue = origChildCode
            Exit Sub
        End If

        Slipknot.addParameter("parId", txtID.Text)
        Slipknot.addParameter("parParentCode", mcbParent.SelectedValue)
        Slipknot.addParameter("parChildCode", mcbChild.SelectedValue)
        Slipknot.addParameter("parUsage", seUsage.Value)
        Slipknot.addParameter("parRemarks", txtRemarks.Text.TrimStart.TrimEnd)

        If Slipknot.dbAED("SP_UpdateBOMMaster") Then
            RadMessageBox.Show("Updated Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)

            origParentCode = mcbParent.SelectedValue
            origChildCode = mcbChild.SelectedValue
        End If

    End Sub
End Class
