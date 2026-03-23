Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmHistoryDemand

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtDemandHistory As DataTable
    Private id As Integer = 0

    Private Sub FrmHistoryDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        myDB.AddMySqlParameters("id", id)
        dtDemandHistory = Me.myDB.SPSelect("SP_P_GetDemandHistoryPerItem")

        gvData.DataSource = dtDemandHistory
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
        gvData.Columns.Add(fldID)

        Dim fldDemandID As New GridViewTextBoxColumn("DEMAND ID") With {
            .FieldName = "fldDemandID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldDemandID)

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 100,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDFEAP)
        gvData.Columns("fldETDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomer As New GridViewTextBoxColumn("CUST ID") With {
            .FieldName = "fldCustomerID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldCustomer)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gvData.Columns.Add(fldCustomerName)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 250,
            .TextAlignment = ContentAlignment.MiddleLeft,
            .IsVisible = True
        }
        gvData.Columns.Add(fldPartName)

        Dim fldQuantity As New GridViewTextBoxColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldQuantity)
        gvData.Columns("fldQuantity").FormatString = "{0:N0}"

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS") With {
            .FieldName = "fldRemarks",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldRemarks)

        Dim fldAddedBy As New GridViewTextBoxColumn("UPDATED BY") With {
            .FieldName = "fldAddedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldAddedBy)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE UPDATED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

    End Sub

End Class
