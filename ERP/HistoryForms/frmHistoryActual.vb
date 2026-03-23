Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmHistoryActual

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtActualHistory As DataTable
    Private id As Integer = 0

    Private Sub FrmHistoryActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        myDB.AddMySqlParameters("id", id)
        dtActualHistory = Me.myDB.SPSelect("SP_P_GetActualHistoryPerItem")

        gvData.DataSource = dtActualHistory
        gvData.BestFitColumns()
        leCountRec.Text = gvData.Rows.Count

    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldID As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = False
        }
        gridView.Columns.Add(fldID)

        Dim fldInvoiceNo As New GridViewTextBoxColumn("INVOICE NO.") With {
            .FieldName = "fldInvoiceNo",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldInvoiceNo)

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETDFEAP)
        gridView.Columns("fldETDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATDFEAP As New GridViewDateTimeColumn("ATD FEAP") With {
            .FieldName = "fldATDFEAP",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldATDFEAP)
        gridView.Columns("fldATDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETDManila As New GridViewDateTimeColumn("ETD MNL") With {
            .FieldName = "fldETDManila",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETDManila)
        gridView.Columns("fldETDManila").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATDManila As New GridViewDateTimeColumn("ATD MNL") With {
            .FieldName = "fldATDManila",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldATDManila)
        gridView.Columns("fldATDManila").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATACustomer As New GridViewDateTimeColumn("ATA Customer") With {
            .FieldName = "fldATACustomer",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldATACustomer)
        gvData.Columns("fldATACustomer").FormatString = "{0:MMM dd, yyyy}"

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
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldCustomerName)

        Dim fldModel As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "fldModel",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldModel)

        Dim fldModelName As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "fldModelName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldModelName)

        Dim fldPartNo As New GridViewTextBoxColumn("PART NO") With {
            .FieldName = "fldPartNo",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 200
        }
        gridView.Columns.Add(fldPartName)

        Dim fldUnitPrice As New GridViewDecimalColumn("UNIT PRICE") With {
            .FieldName = "fldUnitPrice",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight
        }
        gridView.Columns.Add(fldUnitPrice)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY") With {
            .FieldName = "fldCurrency",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldCurrency)

        Dim fldQuantity As New GridViewDecimalColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight
        }
        gridView.Columns.Add(fldQuantity)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldDateAdded)
        gridView.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldUpdatedBy As New GridViewTextBoxColumn("UPDATED BY") With {
            .FieldName = "fldUpdatedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldUpdatedBy)

    End Sub

End Class
