Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmDemandPOMonitoringSelector

    Private Sub FrmDemandPOMonitoringSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        numYear.Value = Year(Now)
        LoadCustomerDropDown(ddCustomerCode)

    End Sub

    Public Sub LoadCustomerDropDown(dropdown As RadMultiColumnComboBox)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUSTOMER ID") With {
            .FieldName = "fldId",
            .Width = 100
        }
        dropdown.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER CODE") With {
            .FieldName = "fldCustomerName",
            .Width = 200
        }
        dropdown.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")
        dropdown.DataSource = dtCustomer
        dropdown.DisplayMember = "fldCustomerName"
        dropdown.ValueMember = "fldId"
        dropdown.MultiColumnComboBoxElement.DropDownWidth = 350

        dropdown.AutoFilter = True
        dropdown.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerCode As New FilterDescriptor With {
            .PropertyName = "fldCustomerName",
            .Operator = Telerik.WinControls.Data.FilterOperator.Contains
        }
        dropdown.EditorControl.MasterTemplate.FilterDescriptors.Add(customerCode)

        dropdown.SelectedIndex = -1
        dropdown.Text = String.Empty

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        If Not String.IsNullOrWhiteSpace(ddCustomerCode.Text) Then

            Dim report As New FrmRptLatestDemandForecast
            report.Show(numYear.Value, ddCustomerCode.SelectedValue)

        Else

            RadMessageBox.Show(Me, "Please select customer", "Invalid Customer", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

End Class
