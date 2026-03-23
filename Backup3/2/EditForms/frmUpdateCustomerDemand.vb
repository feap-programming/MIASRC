Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class FrmUpdateCustomerDemand
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ddlModel.Text = "" Then
            RadMessageBox.Show("Please select Customer", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If txtCustomer.Text = "" Then
            RadMessageBox.Show("Please select Model", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        Slipknot.addParameter("ID", txtID.Text)
        Slipknot.addParameter("Customer", Regex.Replace(Trim(txtCustomer.Text), "\s+", " "))
        Slipknot.addParameter("_Description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
        Slipknot.addParameter("Model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
        Slipknot.addParameter("AddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
        Slipknot.addParameter("Budget", seBudget.Text)
        Slipknot.addParameter("Forecast", seForecast.Text)
        Slipknot.addParameter("LatestDemand", seLatestDemand.Text)
        Slipknot.addParameter("FDate", dtpDate.Value)
        Slipknot.addParameter("FGModel", Regex.Replace(Trim(txtFGModel.Text), "\s+", " "))

        If Slipknot.dbAED("SP_UpdateCustomerDemand") Then
            FrmCustomerDemand.bwLoadData.RunWorkerAsync()
            RadMessageBox.Show("Successfully updated", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If


    End Sub

    Private Sub FrmUpdateCustomerDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropDown()
        Dim ID = FrmCustomerDemand.gvData.CurrentRow.Cells("fldID").Value
        Slipknot.changeTheme(Me)

        Slipknot.addParameter("ID", ID)
        Dim myData As DataTable = Slipknot.dbSelect("SP_SelectCustomerDemandByID")

        txtID.Text = ID
        If myData.Rows.Count > 0 Then
            Dim DR As DataRow = myData.Rows(0)
            txtCustomer.Text = DR.Item("fldCustomer")
            txtDescription.Text = DR.Item("fldDescription")
            ddlModel.Text = DR.Item("fldModel")
            dtpDate.Text = DR.Item("fldDate")
            seBudget.Value = DR.Item("fldBudget")
            seForecast.Value = DR.Item("fldForecast")
            seLatestDemand.Value = DR.Item("fldLatestDemand")
            txtFGModel.Text = DR.Item("fldFGModel")
        End If
        dtpDate.CustomFormat = "MMM:yyyy"
        dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDate.ShowUpDown = True
    End Sub
    Public Sub LoadDropDown()
        Dim fldCustomerName As New GridViewTextBoxColumn("CUSROMER NAME")
        fldCustomerName.FieldName = "customer"
        fldCustomerName.Width = 100
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim fldCustomerCode As New GridViewTextBoxColumn("PART NO")
        fldCustomerCode.FieldName = "fldCustomerPartNo"
        fldCustomerCode.Width = 100
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 200
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
        ddlModel.DataSource = dtCustomer
        ddlModel.ValueMember = "fldCustomerPartNo"
        ddlModel.DisplayMember = "fldCustomerPartNo"
        ddlModel.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlModel.AutoFilter = True
        ddlModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub ddlCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlModel.SelectedIndexChanged
        If ddlModel.SelectedValue Is Nothing Then
            txtCustomer.Text = Nothing
        Else
            Dim selectedRow As GridViewDataRowInfo = CType(ddlModel.SelectedItem, GridViewDataRowInfo)
            txtCustomer.Text = selectedRow.Cells("customer").Value.ToString()
        End If
    End Sub
End Class
