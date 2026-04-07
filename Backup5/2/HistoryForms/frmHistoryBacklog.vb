Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class frmHistoryBacklog

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtBacklogHistory As DataTable
    Private id As Integer = 0

    Private Sub frmHistoryBacklog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        myDB.AddMySqlParameters("parID", id)
        dtBacklogHistory = Me.myDB.SPSelect("SP_P_GetBacklogHistoryPerItem")

        gvData.DataSource = dtBacklogHistory
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

        Dim fldEffectivityDate As New GridViewDateTimeColumn("EFFECTIVITY DATE") With {
            .FieldName = "fldEffectivityDate",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldEffectivityDate)
        gridView.Columns("fldEffectivityDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomerID As New GridViewDecimalColumn("CUST ID") With {
            .FieldName = "fldCustomerID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldCustomerID)

        Dim fldCustomer As New GridViewTextBoxColumn("CUST CODE") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldCustomer)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 250,
            .TextAlignment = ContentAlignment.MiddleLeft,
            .IsVisible = True
        }
        gridView.Columns.Add(fldPartName)

        Dim fldQuantity As New GridViewTextBoxColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gridView.Columns.Add(fldQuantity)
        gridView.Columns("fldQuantity").FormatString = "{0:N0}"

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS") With {
            .FieldName = "fldRemarks",
            .MinWidth = 250,
            .TextAlignment = ContentAlignment.MiddleLeft,
            .IsVisible = True
        }
        gridView.Columns.Add(fldRemarks)

    End Sub

End Class
