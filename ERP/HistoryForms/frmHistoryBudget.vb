Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmHistoryBudget

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtBudgetHistory As DataTable
    Private id As Integer = 0

    Private Sub FrmHistoryBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        myDB.AddMySqlParameters("id", id)
        dtBudgetHistory = Me.myDB.SPSelect("SP_P_GetBudgetHistoryPerItem")

        gvData.DataSource = dtBudgetHistory
        gvData.BestFitColumns()
        leCountRec.Text = gvData.Rows.Count
    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldYear As New GridViewDecimalColumn("YEAR") With {
            .FieldName = "fldYear",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldYear)

        Dim fldMonthName As New GridViewTextBoxColumn("MONTH") With {
            .FieldName = "fldMonthName",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldMonthName)

        Dim fldCustomer As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomer",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldCustomer)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gvData.Columns.Add(fldCustomerName)

        Dim fldFGModel As New GridViewTextBoxColumn("FG MODEL") With {
            .FieldName = "fldFGModel",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldFGModel)

        Dim fldModelName As New GridViewTextBoxColumn("FG MODEL") With {
            .FieldName = "fldModelName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldModelName)

        Dim fldModel As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "fldModel",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldModel)

        Dim fldItemNo As New GridViewTextBoxColumn("DESCRIPTION") With {
            .FieldName = "fldDescription",
            .MinWidth = 200,
            .IsVisible = True
        }
        gridView.Columns.Add(fldItemNo)

        Dim fldBudget As New GridViewTextBoxColumn("BUDGET") With {
            .FieldName = "fldBudget",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gridView.Columns.Add(fldBudget)
        gridView.Columns("fldBudget").FormatString = "{0:N0}"

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldUpdatedBy As New GridViewTextBoxColumn("UPDATED BY") With {
            .FieldName = "fldUpdatedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldUpdatedBy)

    End Sub

End Class
