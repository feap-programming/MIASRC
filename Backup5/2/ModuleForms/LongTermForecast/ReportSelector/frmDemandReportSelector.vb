
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmDemandReportSelector

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtBudgetCustomers As DataTable = Nothing

    Private Sub FrmDemandReportSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        LoadCustomerDropDown(ddCustomerCode)
        ddCustomerCode.SelectedIndex = -1
        ddCustomerCode.Text = "-- Select --"
        dtDateFrom.Value = New Date(Now.Year, 1, 1)
        dtDateTo.Value = New Date(Now.Year, 12, 31)

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        If Not (drpReport.Text = "-- Select --") AndAlso
            Not (ddCustomerCode.SelectedIndex = -1) Then

            If drpReport.Text = "Demand ETD FEAP" Then

                Dim report As New FrmRptDemandETDFEAP
                Dim parCustomerID As UInteger = ddCustomerCode.SelectedValue
                Dim parDateFrom As Date = dtDateFrom.Value
                Dim parDateTo As Date = dtDateTo.Value
                report.Show(parCustomerID, parDateFrom, parDateTo)

            ElseIf drpReport.Text = "Budget ETD FEAP" Then

                Dim report As New FrmRptBudgetETDFEAP
                Dim parCustomerID As UInteger = ddCustomerCode.SelectedValue
                Dim parDateFrom As Date = dtDateFrom.Value
                Dim parDateTo As Date = dtDateTo.Value
                report.Show(parCustomerID, parDateFrom, parDateTo)

            Else

                RadMessageBox.Show(Me, "Unknown report layout. Kindly contact your administrator.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

            End If

        Else

            RadMessageBox.Show(Me, "Please completely fill-out the form.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

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
            .Operator = FilterOperator.Contains
        }
        dropdown.EditorControl.MasterTemplate.FilterDescriptors.Add(customerCode)

        dropdown.SelectedIndex = -1
        dropdown.Text = String.Empty

    End Sub

End Class
