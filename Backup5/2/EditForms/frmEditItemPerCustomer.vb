Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmEditItemPerCustomer
    Private Sub FrmEditItemPerCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadDropDown()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub loadDropDown()

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

        'LOAD CUSTOMER

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSROMER NAME")
        fldCustomerName.FieldName = "fldCustomerName"
        fldCustomerName.Width = 150
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CODE")
        fldCustomerCode.FieldName = "fldCustomerCode"
        fldCustomerCode.Width = 100
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        mcbCustomer.DataSource = dtCustomer
        mcbCustomer.ValueMember = "fldCustomerCode"
        mcbCustomer.DisplayMember = "fldCustomerName"
        mcbCustomer.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbCustomer.AutoFilter = True
        mcbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerName As New FilterDescriptor()
        customerName.PropertyName = "fldCustomerName"
        customerName.Operator = FilterOperator.Contains
        mcbCustomer.EditorControl.MasterTemplate.FilterDescriptors.Add(customerName)

    End Sub

    Private Sub FrmEditItemPerCustomer_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim row As DataRow = Slipknot.rowSelectManual("SELECT * FROM tblItemMasterPerCustomer WHERE fldId = '" & txtId.Text & "' ")

        If row IsNot Nothing Then

            txtCustomerPartNo.Text = Convert.ToString(row.Item("fldCustomerPartNo"))
            mcbCustomer.SelectedValue = Convert.ToString(row.Item("fldCustomerCode"))
            mcbItemCode.SelectedValue = Convert.ToString(row.Item("fldItemCode"))
            txtModelCode.Text = Convert.ToString(row.Item("fldModelCode"))
            seStdQty.Value = Convert.ToDecimal(row.Item("fldStdQty"))
            txtPartLevel.Text = Convert.ToString(row.Item("fldPartLevel"))

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If BulletForMyValentine.isRW("fldMDItemPerCustomer") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If txtCustomerPartNo.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Customer part number cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select item code properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbCustomer.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select customer properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If txtModelCode.Text = String.Empty Then
            RadMessageBox.Show("Model code should not be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parId", txtId.Text)
        Slipknot.addParameter("parCustomerPartNo", txtCustomerPartNo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
        Slipknot.addParameter("parCustomerCode", mcbCustomer.SelectedValue)
        Slipknot.addParameter("parModelCode", txtModelCode.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parStdQty", seStdQty.Value)
        Slipknot.addParameter("parPartLevel", txtPartLevel.Text.TrimStart.TrimEnd)

        If Slipknot.dbAED("SP_UpdateItemMasterPerCustomer") Then

            txtCustomerPartNo.Focus()

            RadMessageBox.Show("Updated Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)

        End If

    End Sub
End Class
