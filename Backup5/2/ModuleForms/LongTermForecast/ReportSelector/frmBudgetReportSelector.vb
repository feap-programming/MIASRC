Imports Telerik.WinControls
Imports FEAPNS.DataAccess

Public Class FrmBudgetReportSelector

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtBudgetCustomers As DataTable = Nothing
    Private dtBudgetModels As DataTable = Nothing

    Private Sub FrmBudgetReportSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        dtBudgetCustomers = myDB.SPSelect("SP_P_SelectAllBudgetCustomers")
        dtBudgetModels = myDB.SPSelect("SP_P_SelectAllBudgetModels")

        numYear.Value = Date.Now.Year
        drpCategory.SelectedIndex = 0

        If drpCategory.Text = "Per Customer" Then
            ReportTypeCustomerSelected()
        ElseIf drpCategory.Text = "Per Model" Then
            ReportTypeModelSelected()
        End If

    End Sub

    Private Sub drpReportType_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles drpCategory.SelectedIndexChanged

        If drpCategory.Text = "Per Customer" Then
            ReportTypeCustomerSelected()
        ElseIf drpCategory.Text = "Per Model" Then
            ReportTypeModelSelected()
        End If

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        If drpCategory.Text = "Per Customer" Then

            If drpReport.Text = "-- Select --" Then

                RadMessageBox.Show(Me, "Please select report.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            ElseIf drpReport.Text = "All Customers" Then

                Dim report As New frmRptBudgetAllCustomer
                report.Show(numYear.Value)

            Else

                Dim report As New FrmRptBudgetPerCustomer
                Dim customerCode As String = dtBudgetCustomers.Select("fldCustomerName = '" & drpReport.Text & "'")(0).Item("fldCustomer")
                report.Show(numYear.Value, customerCode)

            End If

        ElseIf drpCategory.Text = "Per Model" Then

            If drpReport.Text = "-- Select --" Then

                RadMessageBox.Show(Me, "Please select report.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Else

                Dim report As New FrmRptBudgetPerModel
                Dim modelCode As String = dtBudgetModels.Select("fldModelName = '" & drpReport.Text & "'")(0).Item("fldFGModel")
                report.Show(numYear.Value, modelCode)

            End If

        End If

    End Sub

    Private Sub ReportTypeCustomerSelected()

        drpReport.Items.Clear()

        drpReport.Items.Add("All Customers")
        For Each row As DataRow In dtBudgetCustomers.Rows
            drpReport.Items.Add(row.Item("fldCustomerName"))
        Next

        drpReport.Text = "-- Select --"

    End Sub

    Private Sub ReportTypeModelSelected()

        drpReport.Items.Clear()

        For Each row As DataRow In dtBudgetModels.Rows
            drpReport.Items.Add(row.Item("fldModelName"))
        Next

        drpReport.Text = "-- Select --"

    End Sub

End Class
