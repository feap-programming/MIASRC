Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports Telerik.WinControls

Public Class FrmViewInvoiceItem

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtInvoiceItem As DataTable = Nothing

    Private Property InvoiceID As Int64 = 0

    Private Sub FrmViewInvoiceItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        SetUpColumns()

        gvData.DataSource = TblInvoiceItem()

    End Sub

    Private Sub gvData_CommandCellClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
        If TypeOf e.Column Is GridViewCommandColumn Then
            If gvData.CurrentCell.ColumnInfo.FieldName = "fldDelete" Then

                If RadMessageBox.Show("Are you sure you want to delete this item?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

                    Dim id As Int64 = gvData.CurrentRow.Cells("fldID").Value

                    myDB.AddMySqlParameters("IDArray", id)
                    myDB.SPADE("SP_P_DeleteActual")

                    gvData.DataSource = TblInvoiceItem()

                End If

            End If
        End If
    End Sub

    Private Function TblInvoiceItem() As DataTable

        myDB.AddMySqlParameters("parInvoiceID", InvoiceID)
        Return myDB.SPSelect("SP_P_SelectInvoiceItemByInvID")

    End Function

    Public Overloads Sub ShowDialog(invoiceID As Int64)

        Me.InvoiceID = invoiceID
        Me.ShowDialog()

    End Sub

    Private Sub SetUpColumns()

        Dim fldDelete As New GridViewCommandColumn("DELETE") With {
            .FieldName = "fldDelete",
            .DefaultText = "DELETE",
            .UseDefaultText = True,
            .IsPinned = True,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .MinWidth = 80
        }
        gvData.Columns.Add(fldDelete)

        Dim fldID As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .IsVisible = False
        }
        gvData.Columns.Add(fldID)

        Dim fldInvoiceNo As New GridViewTextBoxColumn("INVOICE NO.") With {
            .FieldName = "fldInvoiceNo",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldInvoiceNo)

        Dim fldReferenceNo As New GridViewTextBoxColumn("REFERENCE NO.") With {
            .FieldName = "fldReferenceNo",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldReferenceNo)

        Dim fldModelName As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "fldModelName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldModelName)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("CUSTOMER PART NO") With {
            .FieldName = "fldCustomerPartNo",
            .MinWidth = 130,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldCustomerPartNo)

        Dim fldPartNo As New GridViewTextBoxColumn("PART NO") With {
            .FieldName = "fldPartNo",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 200
        }
        gvData.Columns.Add(fldPartName)

        Dim fldUnitPrice As New GridViewDecimalColumn("UNIT PRICE") With {
            .FieldName = "fldUnitPrice",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight
        }
        gvData.Columns.Add(fldUnitPrice)

        Dim fldQuantity As New GridViewDecimalColumn("QUANTITY") With {
            .FieldName = "fldQuantity",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight
        }
        gvData.Columns.Add(fldQuantity)

        Dim fldUnit As New GridViewTextBoxColumn("UNIT") With {
            .FieldName = "fldUnit",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldUnit)

        AddHandler gvData.CommandCellClick, AddressOf gvData_CommandCellClick

    End Sub

End Class
