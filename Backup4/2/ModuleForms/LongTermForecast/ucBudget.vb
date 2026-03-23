Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class ucBudget

    Private myData As DataTable
    Private customerCode As String = String.Empty
    Private modelCode As String = String.Empty

    Private Sub ucBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeThemeUC(Me)

        Me.numYear.Value = Year(Date.Today)

        RemoveHandler ddlModel.SelectedIndexChanged, AddressOf ddlModel_SelectedIndexChanged
        LoadDropDown()
        AddHandler ddlModel.SelectedIndexChanged, AddressOf ddlModel_SelectedIndexChanged
        txtFGModel.Text = String.Empty
        txtDescription.Text = String.Empty
        txtCustomer.Text = String.Empty
        seBudgetJan.Value = 0.0
        seBudgetFeb.Value = 0.0
        seBudgetMar.Value = 0.0
        seBudgetApr.Value = 0.0
        seBudgetMay.Value = 0.0
        seBudgetJun.Value = 0.0
        seBudgetJul.Value = 0.0
        seBudgetAug.Value = 0.0
        seBudgetSep.Value = 0.0
        seBudgetOct.Value = 0.0
        seBudgetNov.Value = 0.0
        seBudgetDec.Value = 0.0

        SetUpColumns()
        LoadTotalSummary()

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub ddlModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlModel.SelectedIndexChanged

        If ddlModel.SelectedIndex >= 0 Then

            Dim dtModel As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
            Dim modelRow As DataRow() = dtModel.Select("fldId = " & ddlModel.SelectedValue & "")

            If modelRow.Count > 0 Then
                txtDescription.Text = modelRow(0).Item("fldPartName")
                modelCode = modelRow(0).Item("modelCode")
                txtFGModel.Text = modelRow(0).Item("model")
                customerCode = modelRow(0).Item("fldCustomerCode")
                txtCustomer.Text = modelRow(0).Item("customer")
            Else
                txtDescription.Text = String.Empty
                modelCode = String.Empty
                txtFGModel.Text = String.Empty
                customerCode = String.Empty
                txtCustomer.Text = String.Empty
            End If

        End If

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork

        bwLoadData.ReportProgress(Convert.ToInt32(0))
        Threading.Thread.Sleep(delay)

        Dim budgetJan As DataTable = Nothing
        Dim budgetFeb As DataTable = Nothing
        Dim budgetMar As DataTable = Nothing
        Dim budgetApr As DataTable = Nothing
        Dim budgetMay As DataTable = Nothing
        Dim budgetJun As DataTable = Nothing
        Dim budgetJul As DataTable = Nothing
        Dim budgetAug As DataTable = Nothing
        Dim budgetSep As DataTable = Nothing
        Dim budgetOct As DataTable = Nothing
        Dim budgetNov As DataTable = Nothing
        Dim budgetDec As DataTable = Nothing

        If Not bwLoadData.CancellationPending Then

            myData = Slipknot.dbSelect("SP_P_SelectAllBudget")

            budgetJan = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 1
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((1 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetFeb = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 2
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((2 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetMar = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 3
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((3 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetApr = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 4
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((4 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetMay = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 5
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((5 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetJun = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 6
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((6 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetJul = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 7
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((7 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetAug = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 8
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((8 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetSep = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 9
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((9 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetOct = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 10
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((10 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetNov = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 11
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((11 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            budgetDec = ConvertToDatatable((
                From T0 In myData.AsEnumerable
                Where T0.Field(Of Integer)("fldMonth") = 12
                Select New With
                    {
                        .fldID = T0.Field(Of Int64)("fldID"),
                        .fldYear = T0.Field(Of Integer)("fldYear"),
                        .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        .fldMonthName = T0.Field(Of String)("fldMonthName"),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                        .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList())

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((12 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

        If Not bwLoadData.CancellationPending Then

            Dim annualBudget = (
                From T0 In budgetJan.AsEnumerable
                Group Join T1 In budgetFeb.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T1.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T1.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T1.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T1.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T1.Field(Of String)("fldModel")
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Group Join T2 In budgetMar.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T2.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T2.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T2.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T2.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T2.Field(Of String)("fldModel")
                    Into gT2 = Group
                From T2 In gT2.DefaultIfEmpty
                Group Join T3 In budgetApr.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T3.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T3.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T3.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T3.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T3.Field(Of String)("fldModel")
                    Into gT3 = Group
                From T3 In gT3.DefaultIfEmpty
                Group Join T4 In budgetMay.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T4.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T4.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T4.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T4.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T4.Field(Of String)("fldModel")
                    Into gT4 = Group
                From T4 In gT4.DefaultIfEmpty
                Group Join T5 In budgetJun.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T5.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T5.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T5.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T5.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T5.Field(Of String)("fldModel")
                    Into gT5 = Group
                From T5 In gT5.DefaultIfEmpty
                Group Join T6 In budgetJul.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T6.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T6.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T6.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T6.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T6.Field(Of String)("fldModel")
                    Into gT6 = Group
                From T6 In gT6.DefaultIfEmpty
                Group Join T7 In budgetAug.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T7.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T7.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T7.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T7.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T7.Field(Of String)("fldModel")
                    Into gT7 = Group
                From T7 In gT7.DefaultIfEmpty
                Group Join T8 In budgetSep.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T8.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T8.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T8.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T8.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T8.Field(Of String)("fldModel")
                    Into gT8 = Group
                From T8 In gT8.DefaultIfEmpty
                Group Join T9 In budgetOct.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T9.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T9.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T9.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T9.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T9.Field(Of String)("fldModel")
                    Into gT9 = Group
                From T9 In gT9.DefaultIfEmpty
                Group Join T10 In budgetNov.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T10.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T10.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T10.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T10.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T10.Field(Of String)("fldModel")
                    Into gT10 = Group
                From T10 In gT10.DefaultIfEmpty
                Group Join T11 In budgetDec.AsEnumerable
                    On T0.Field(Of String)("fldYear") Equals T11.Field(Of String)("fldYear") And
                    T0.Field(Of String)("fldCustomer") Equals T11.Field(Of String)("fldCustomer") And
                    T0.Field(Of String)("fldDescription") Equals T11.Field(Of String)("fldDescription") And
                    T0.Field(Of String)("fldFGModel") Equals T11.Field(Of String)("fldFGModel") And
                    T0.Field(Of String)("fldModel") Equals T11.Field(Of String)("fldModel")
                    Into gT11 = Group
                From T11 In gT11.DefaultIfEmpty
                Select New With
                    {
                        .fldYear = Convert.ToInt32(T0.Field(Of String)("fldYear")),
                        .fldCategory = T0.Field(Of String)("fldCategory"),
                        .fldCustomer = T0.Field(Of String)("fldCustomer"),
                        .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                        .fldDescription = T0.Field(Of String)("fldDescription"),
                        .fldFGModel = T0.Field(Of String)("fldFGModel"),
                        .fldModelName = T0.Field(Of String)("fldModelName"),
                        .fldModel = T0.Field(Of String)("fldModel"),
                        .fldIDJan = Convert.ToInt32(T0.Field(Of String)("fldID")),
                        .fldJanuary = Convert.ToDecimal(T0.Field(Of String)("fldBudget")),
                        .fldIDFeb = Convert.ToInt32(T1?.Field(Of String)("fldID")),
                        .fldFebruary = Convert.ToDecimal(T1?.Field(Of String)("fldBudget")),
                        .fldIDMar = Convert.ToInt32(T2?.Field(Of String)("fldID")),
                        .fldMarch = Convert.ToDecimal(T2?.Field(Of String)("fldBudget")),
                        .fldIDApr = Convert.ToInt32(T3?.Field(Of String)("fldID")),
                        .fldApril = Convert.ToDecimal(T3?.Field(Of String)("fldBudget")),
                        .fldIDMay = Convert.ToInt32(T4?.Field(Of String)("fldID")),
                        .fldMay = Convert.ToDecimal(T4?.Field(Of String)("fldBudget")),
                        .fldIDJun = Convert.ToInt32(T5?.Field(Of String)("fldID")),
                        .fldJune = Convert.ToDecimal(T5?.Field(Of String)("fldBudget")),
                        .fldIDJul = Convert.ToInt32(T6?.Field(Of String)("fldID")),
                        .fldJuly = Convert.ToDecimal(T6?.Field(Of String)("fldBudget")),
                        .fldIDAug = Convert.ToInt32(T7?.Field(Of String)("fldID")),
                        .fldAugust = Convert.ToDecimal(T7?.Field(Of String)("fldBudget")),
                        .fldIDSep = Convert.ToInt32(T8?.Field(Of String)("fldID")),
                        .fldSeptember = Convert.ToDecimal(T8?.Field(Of String)("fldBudget")),
                        .fldIDOct = Convert.ToInt32(T9?.Field(Of String)("fldID")),
                        .fldOctober = Convert.ToDecimal(T9?.Field(Of String)("fldBudget")),
                        .fldIDNov = Convert.ToInt32(T10?.Field(Of String)("fldID")),
                        .fldNovember = Convert.ToDecimal(T10?.Field(Of String)("fldBudget")),
                        .fldIDDec = Convert.ToInt32(T11?.Field(Of String)("fldID")),
                        .fldDecember = Convert.ToDecimal(T11?.Field(Of String)("fldBudget")),
                        .fldDateAdded = Convert.ToDateTime(T0.Field(Of String)("fldDateAdded")),
                        .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                    }
            ).ToList()

            myData = ConvertToDatatable(annualBudget)

            bwLoadData.ReportProgress(Convert.ToInt32(Math.Floor((13 / 13) * 100)))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged

        If e.ProgressPercentage = 0 Then
            RadProgressBarElement1.Text = "Preparing..."
        ElseIf e.ProgressPercentage = 100 Then
            RadProgressBarElement1.Text = "Done"
        Else
            RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        End If

        RadProgressBarElement1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted

        If Not e.Cancelled Then

            gvData.DataSource = myData
            gvData.BestFitColumns()
            leCountRec.Text = gvData.Rows.Count

        End If

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Dim dtModel As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
        Dim modelRow As DataRow() = dtModel.Select("fldCustomerPartNo = '" & ddlModel.Text & "'")

        If modelRow.Count > 0 Then

            Dim notSaved As String = String.Empty

            Dim confirmResult As DialogResult = RadMessageBox.Show(Me, "Please confirm to add budget for " & Regex.Replace(Trim(ddlModel.Text), "\s+", " "), "SAVING",
                                                               MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If confirmResult = DialogResult.Yes Then

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 1)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetJan.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "January, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 2)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetFeb.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "February, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 3)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetMar.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "March, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 4)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetApr.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "April, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 5)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetMay.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "May, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 6)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetJun.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "June, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 7)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetJul.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "July, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 8)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetAug.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "August, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 9)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetSep.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "September, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 10)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetOct.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "October, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 11)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetNov.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "November, "
                End If

                Slipknot.addParameter("_year", Me.numYear.Value)
                Slipknot.addParameter("_month", 12)
                Slipknot.addParameter("customer", customerCode)
                Slipknot.addParameter("description", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                Slipknot.addParameter("model", Regex.Replace(Trim(ddlModel.Text), "\s+", " "))
                Slipknot.addParameter("budget", seBudgetDec.Value)
                Slipknot.addParameter("fgModel", modelCode)
                Slipknot.addParameter("addedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBudget") Then
                    notSaved += "December, "
                End If

                If bwLoadData.IsBusy = False Then
                    bwLoadData.RunWorkerAsync()
                    If String.IsNullOrWhiteSpace(notSaved) Then
                        RadMessageBox.Show("Budget successfully added.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Else
                        RadMessageBox.Show("Budget successfully added. " & Environment.NewLine & "But some are not saved as follows: " & Environment.NewLine &
                                       notSaved.Substring(0, notSaved.Length - 2),
                                       "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                    End If
                End If

            End If

        Else
            RadMessageBox.Show("Please select correct FG No.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("It will also delete all history record under this item, are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id += "," & Convert.ToString(rows(i).Cells("fldIDJan").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDFeb").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDMar").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDApr").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDMay").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDJun").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDJul").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDAug").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDSep").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDOct").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDNov").Value)
            id += "," & Convert.ToString(rows(i).Cells("fldIDDec").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("IDArray", id)
        Slipknot.dbAED("SP_P_DeleteBudget")
    End Sub

    Private Sub bwOperation_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwOperation.ProgressChanged
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwOperation_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwOperation.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbImportData_Click(sender As Object, e As EventArgs) Handles cbImportData.Click
        Dim editForm As New FrmImportBudget
        editForm.ShowDialog(Me)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub cbExport_Click(sender As Object, e As EventArgs) Handles cbExport.Click
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

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click
        Dim reportSelector As New FrmBudgetReportSelector
        reportSelector.ShowDialog(Me)
    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.EnableFiltering = True
            gvData.MasterTemplate.ShowHeaderCellButtons = True
            gvData.MasterTemplate.ShowFilteringRow = True
        Else
            gvData.EnableFiltering = False
            gvData.MasterTemplate.ShowHeaderCellButtons = False
            gvData.MasterTemplate.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub gvData_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs) Handles gvData.ContextMenuOpening

        Dim cell As GridDataCellElement = TryCast(e.ContextMenuProvider, GridDataCellElement)

        If cell Is Nothing Then
            Return
        End If

        If cell.ColumnInfo.FieldName = "fldJanuary" OrElse
            cell.ColumnInfo.FieldName = "fldFebruary" OrElse
            cell.ColumnInfo.FieldName = "fldMarch" OrElse
            cell.ColumnInfo.FieldName = "fldApril" OrElse
            cell.ColumnInfo.FieldName = "fldMay" OrElse
            cell.ColumnInfo.FieldName = "fldJune" OrElse
            cell.ColumnInfo.FieldName = "fldJuly" OrElse
            cell.ColumnInfo.FieldName = "fldAugust" OrElse
            cell.ColumnInfo.FieldName = "fldSeptember" OrElse
            cell.ColumnInfo.FieldName = "fldOctober" OrElse
            cell.ColumnInfo.FieldName = "fldNovember" OrElse
            cell.ColumnInfo.FieldName = "fldDecember" Then

            e.ContextMenu = cmActionChooser.DropDown

        End If

    End Sub

    Private Sub miCopy_Click(sender As Object, e As EventArgs) Handles miCopy.Click
        Dim selecionMode As GridViewSelectionMode = Me.gvData.SelectionMode
        Me.gvData.SelectionMode = GridViewSelectionMode.CellSelect
        Me.gvData.CurrentRow.Cells(Me.gvData.CurrentColumn.Name).IsSelected = True
        Me.gvData.Copy()
        Me.gvData.SelectionMode = selecionMode
        Me.gvData.CurrentRow.IsSelected = True
    End Sub

    Private Sub miEdit_Click(sender As Object, e As EventArgs) Handles miEdit.Click

        Try

            Dim id As Integer = 0

            If gvData.CurrentCell.ColumnInfo.FieldName = "fldJanuary" Then
                id = gvData.CurrentRow.Cells("fldIDJan").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldFebruary" Then
                id = gvData.CurrentRow.Cells("fldIDFeb").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldMarch" Then
                id = gvData.CurrentRow.Cells("fldIDMar").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldApril" Then
                id = gvData.CurrentRow.Cells("fldIDApr").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldMay" Then
                id = gvData.CurrentRow.Cells("fldIDMay").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldJune" Then
                id = gvData.CurrentRow.Cells("fldIDJun").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldJuly" Then
                id = gvData.CurrentRow.Cells("fldIDJul").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldAugust" Then
                id = gvData.CurrentRow.Cells("fldIDAug").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldSeptember" Then
                id = gvData.CurrentRow.Cells("fldIDSep").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldOctober" Then
                id = gvData.CurrentRow.Cells("fldIDOct").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldNovember" Then
                id = gvData.CurrentRow.Cells("fldIDNov").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldDecember" Then
                id = gvData.CurrentRow.Cells("fldIDDec").Value
            End If

            If id > 0 Then
                Dim editForm As New FrmEditBudget
                editForm.ShowDialog(id)
            End If

        Catch ex As System.Reflection.AmbiguousMatchException

            RadMessageBox.Show(Me, "Please select proper row.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub miHistory_Click(sender As Object, e As EventArgs) Handles miHistory.Click

        Try

            Dim id As Integer = 0

            If gvData.CurrentCell.ColumnInfo.FieldName = "fldJanuary" Then
                id = gvData.CurrentRow.Cells("fldIDJan").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldFebruary" Then
                id = gvData.CurrentRow.Cells("fldIDFeb").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldMarch" Then
                id = gvData.CurrentRow.Cells("fldIDMar").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldApril" Then
                id = gvData.CurrentRow.Cells("fldIDApr").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldMay" Then
                id = gvData.CurrentRow.Cells("fldIDMay").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldJune" Then
                id = gvData.CurrentRow.Cells("fldIDJun").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldJuly" Then
                id = gvData.CurrentRow.Cells("fldIDJul").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldAugust" Then
                id = gvData.CurrentRow.Cells("fldIDAug").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldSeptember" Then
                id = gvData.CurrentRow.Cells("fldIDSep").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldOctober" Then
                id = gvData.CurrentRow.Cells("fldIDOct").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldNovember" Then
                id = gvData.CurrentRow.Cells("fldIDNov").Value
            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldDecember" Then
                id = gvData.CurrentRow.Cells("fldIDDec").Value
            End If

            If id > 0 Then
                Dim editForm As New FrmHistoryBudget
                editForm.ShowDialog(id)
            End If

        Catch ex As System.Reflection.AmbiguousMatchException

            RadMessageBox.Show(Me, "Please select proper row.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Public Shared Function ConvertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function

    Public Sub LoadDropDown()

        Dim fldId As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldId",
            .Width = 80
        }
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldId)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUST. CODE") With {
            .FieldName = "customer",
            .Width = 100
        }
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim fldCustomerCode As New GridViewTextBoxColumn("PART NO") With {
            .FieldName = "fldCustomerPartNo",
            .Width = 100
        }
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 100
        }
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE") With {
            .FieldName = "modelCode",
            .Width = 100,
            .IsVisible = False
        }
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldModelCode)

        Dim fldModelName As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "model",
            .Width = 100
        }
        ddlModel.MultiColumnComboBoxElement.Columns.Add(fldModelName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
        ddlModel.DataSource = dtCustomer
        ddlModel.DisplayMember = "fldCustomerPartNo"
        ddlModel.ValueMember = "fldId"
        ddlModel.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlModel.AutoFilter = True
        ddlModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerPartNo As New FilterDescriptor With {
            .PropertyName = "fldCustomerPartNo",
            .Operator = FilterOperator.Contains
        }
        ddlModel.EditorControl.MasterTemplate.FilterDescriptors.Add(customerPartNo)

        ddlModel.SelectedIndex = -1
        ddlModel.Text = String.Empty

    End Sub

    Private Sub LoadTotalSummary()

        Dim totalSummary As New GridViewSummaryRowItem From {
            New GridViewSummaryItem("fldModelName", "Total", GridAggregateFunction.Var),
            New GridViewSummaryItem("fldJanuary", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldFebruary", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldMarch", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldApril", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldMay", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldJune", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldJuly", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldAugust", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldSeptember", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldOctober", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldNovember", "{0:#,##0.00}", GridAggregateFunction.Sum),
            New GridViewSummaryItem("fldDecember", "{0:#,##0.00}", GridAggregateFunction.Sum)
        }

        Me.gvData.MasterTemplate.SummaryRowsBottom.Add(totalSummary)
        Me.gvData.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

    End Sub

    Private Sub gvData_ViewCellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.ViewCellFormatting

        If TypeOf e.CellElement Is GridSummaryCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            e.CellElement.DrawFill = True
            e.CellElement.ForeColor = Color.FromArgb(0, 0, 0)
            e.CellElement.BackColor = Color.FromArgb(129, 236, 236)
            e.CellElement.BackColor2 = Color.FromArgb(129, 236, 236)
        Else
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

    End Sub

    Private Sub SetUpColumns()

        Dim fldFGModel As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "fldFGModel",
            .MinWidth = 120,
            .IsPinned = True,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldFGModel)

        Dim fldModelName As New GridViewTextBoxColumn("MODEL *") With {
            .FieldName = "fldModelName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldModelName)

        Dim fldItemNo As New GridViewTextBoxColumn("PART NAME *") With {
            .FieldName = "fldDescription",
            .MinWidth = 200,
            .IsVisible = True
        }
        gvData.Columns.Add(fldItemNo)

        Dim fldModel As New GridViewTextBoxColumn("PART NO *") With {
            .FieldName = "fldModel",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldModel)

        Dim fldCustomer As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomer",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldCustomer)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER *") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gvData.Columns.Add(fldCustomerName)

        Dim fldYear As New GridViewDecimalColumn("YEAR *") With {
            .FieldName = "fldYear",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldYear)

        Dim fldIDJan As New GridViewTextBoxColumn("ID JAN") With {
            .FieldName = "fldIDJan",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDJan)

        Dim fldJanuary As New GridViewTextBoxColumn("JAN *") With {
            .FieldName = "fldJanuary",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldJanuary)
        gvData.Columns("fldJanuary").FormatString = "{0:N0}"

        Dim fldIDFeb As New GridViewTextBoxColumn("ID FEB") With {
            .FieldName = "fldIDFeb",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDFeb)

        Dim fldFebruary As New GridViewTextBoxColumn("FEB *") With {
            .FieldName = "fldFebruary",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldFebruary)
        gvData.Columns("fldFebruary").FormatString = "{0:N0}"

        Dim fldIDMar As New GridViewTextBoxColumn("ID MAR") With {
            .FieldName = "fldIDMar",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDMar)

        Dim fldMarch As New GridViewTextBoxColumn("MAR *") With {
            .FieldName = "fldMarch",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldMarch)
        gvData.Columns("fldMarch").FormatString = "{0:N0}"

        Dim fldIDApr As New GridViewTextBoxColumn("ID APR") With {
            .FieldName = "fldIDApr",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDApr)

        Dim fldApril As New GridViewTextBoxColumn("APR *") With {
            .FieldName = "fldApril",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldApril)
        gvData.Columns("fldApril").FormatString = "{0:N0}"

        Dim fldIDMay As New GridViewTextBoxColumn("ID MAY") With {
            .FieldName = "fldIDMay",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDMay)

        Dim fldMay As New GridViewTextBoxColumn("MAY *") With {
            .FieldName = "fldMay",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldMay)
        gvData.Columns("fldMay").FormatString = "{0:N0}"

        Dim fldIDJun As New GridViewTextBoxColumn("ID JUN") With {
            .FieldName = "fldIDJun",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDJun)

        Dim fldJune As New GridViewTextBoxColumn("JUN *") With {
            .FieldName = "fldJune",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldJune)
        gvData.Columns("fldJune").FormatString = "{0:N0}"

        Dim fldIDJul As New GridViewTextBoxColumn("ID JUL") With {
            .FieldName = "fldIDJul",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDJul)

        Dim fldJuly As New GridViewTextBoxColumn("JUL *") With {
            .FieldName = "fldJuly",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldJuly)
        gvData.Columns("fldJuly").FormatString = "{0:N0}"

        Dim fldIDAug As New GridViewTextBoxColumn("ID AUG") With {
            .FieldName = "fldIDAug",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDAug)

        Dim fldAugust As New GridViewTextBoxColumn("AUG *") With {
            .FieldName = "fldAugust",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldAugust)
        gvData.Columns("fldAugust").FormatString = "{0:N0}"

        Dim fldIDSep As New GridViewTextBoxColumn("ID SEP") With {
            .FieldName = "fldIDSep",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDSep)

        Dim fldSeptember As New GridViewTextBoxColumn("SEP *") With {
            .FieldName = "fldSeptember",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldSeptember)
        gvData.Columns("fldSeptember").FormatString = "{0:N0}"

        Dim fldIDOct As New GridViewTextBoxColumn("ID OCT") With {
            .FieldName = "fldIDOct",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDOct)

        Dim fldOctober As New GridViewTextBoxColumn("OCT *") With {
            .FieldName = "fldOctober",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldOctober)
        gvData.Columns("fldOctober").FormatString = "{0:N0}"

        Dim fldIDNov As New GridViewTextBoxColumn("ID NOV") With {
            .FieldName = "fldIDNov",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDNov)

        Dim fldNovember As New GridViewTextBoxColumn("NOV *") With {
            .FieldName = "fldNovember",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldNovember)
        gvData.Columns("fldNovember").FormatString = "{0:N0}"

        Dim fldIDDec As New GridViewTextBoxColumn("ID DEC") With {
            .FieldName = "fldIDDec",
            .IsVisible = False
        }
        gvData.Columns.Add(fldIDDec)

        Dim fldDecember As New GridViewTextBoxColumn("DEC *") With {
            .FieldName = "fldDecember",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldDecember)
        gvData.Columns("fldDecember").FormatString = "{0:N0}"

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY") With {
            .FieldName = "fldAddedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldAddedBy)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub

End Class