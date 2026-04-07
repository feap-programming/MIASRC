Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmHistoryLatestDemand

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtLatestDemandHistory As DataTable
    Private id As Integer = 0

    Private Sub FrmHistoryLatestDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        myDB.AddMySqlParameters("id", id)
        dtLatestDemandHistory = Me.myDB.SPSelect("SP_P_GetLatestDemandHistoryPerItem")

        gvData.DataSource = dtLatestDemandHistory
        gvData.BestFitColumns()
        leCountRec.Text = gvData.Rows.Count
    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldID As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldID)

        Dim fldDateIssued As New GridViewDateTimeColumn("DATE ISSUED") With {
            .FieldName = "fldDateIssued",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldDateIssued)
        gridView.Columns("fldDateIssued").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDateForecast As New GridViewDateTimeColumn("DATE FORECAST") With {
            .FieldName = "fldDateForecast",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldDateForecast)
        gridView.Columns("fldDateForecast").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldCustomerName)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 200
        }
        gridView.Columns.Add(fldPartName)

        Dim fldQuantity As New GridViewDecimalColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gridView.Columns.Add(fldQuantity)
        gridView.Columns("fldQuantity").FormatString = "{0:N0}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY") With {
            .FieldName = "fldAddedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldAddedBy)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldDateAdded)
        gridView.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        gridView.TableElement.RowHeight = 25

    End Sub

End Class
