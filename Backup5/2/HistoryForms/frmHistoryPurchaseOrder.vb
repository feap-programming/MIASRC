Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class FrmHistoryPurchaseOrder

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtPurchaseOrderHistory As DataTable
    Private id As Integer = 0

    Private Sub FrmHistoryPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        myDB.AddMySqlParameters("parID", id)
        dtPurchaseOrderHistory = Me.myDB.SPSelect("SP_P_GetPurchaseOrderHistoryPerItem")

        gvData.DataSource = dtPurchaseOrderHistory
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

        Dim fldPOID As New GridViewTextBoxColumn("PO ID") With {
            .FieldName = "fldPOID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldPOID)

        Dim fldDateReceived As New GridViewDateTimeColumn("DATE RECEIVED") With {
            .FieldName = "fldDateReceived",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateReceived)
        gvData.Columns("fldDateReceived").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETACustomer As New GridViewDateTimeColumn("ETA CUSTOMER") With {
            .FieldName = "fldETACustomer",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETACustomer)
        gvData.Columns("fldETACustomer").FormatString = "{0:MMM dd, yyyy}"

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

        Dim fldPONo As New GridViewTextBoxColumn("PO NO") With {
            .FieldName = "fldPONo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gvData.Columns.Add(fldPONo)

        Dim fldModeOfShipment As New GridViewTextBoxColumn("MODE OF SHIPMENT") With {
            .FieldName = "fldModeOfShipment",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gvData.Columns.Add(fldModeOfShipment)

        Dim fldQtyPerBox As New GridViewTextBoxColumn("QTY PER BOX") With {
            .FieldName = "fldQtyPerBox",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldQtyPerBox)
        gvData.Columns("fldQtyPerBox").FormatString = "{0:N0}"

        Dim fldQtyPerPallet As New GridViewTextBoxColumn("QTY PER PALLET") With {
            .FieldName = "fldQtyPerPallet",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldQtyPerPallet)
        gvData.Columns("fldQtyPerPallet").FormatString = "{0:N0}"

        Dim fldQuantity As New GridViewTextBoxColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gvData.Columns.Add(fldQuantity)
        gvData.Columns("fldQuantity").FormatString = "{0:N0}"

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
