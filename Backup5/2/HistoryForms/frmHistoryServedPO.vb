Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmHistoryServedPO

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtServedPOInvoiceHistory As DataTable
    Private id As Integer = 0

    Private Sub FrmHistoryServedPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        myDB.AddMySqlParameters("parID", id)
        dtServedPOInvoiceHistory = Me.myDB.SPSelect("SP_P_GetServedPOInvoiceHistory")

        gvData.DataSource = dtServedPOInvoiceHistory
        gvData.BestFitColumns()
        leCountRec.Text = gvData.Rows.Count
    End Sub

    Public Overloads Sub ShowDialog(_id As Integer)
        Me.id = _id
        Me.ShowDialog()
    End Sub

    Private Sub gvData_CommandCellClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
        If TypeOf e.Column Is GridViewCommandColumn Then
            If gvData.CurrentCell.ColumnInfo.FieldName = "fldDelete" Then

                If RadMessageBox.Show("Are you sure you want to delete this item?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

                    Dim id As Int64 = gvData.CurrentRow.Cells("fldID").Value

                    myDB.AddMySqlParameters("IDArray", id)
                    myDB.SPADE("SP_P_DeleteServedPO")

                    myDB.AddMySqlParameters("parID", id)
                    dtServedPOInvoiceHistory = Me.myDB.SPSelect("SP_P_GetServedPOInvoiceHistory")

                    gvData.DataSource = dtServedPOInvoiceHistory
                    gvData.BestFitColumns()
                    leCountRec.Text = gvData.Rows.Count
                End If

            End If
        End If
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldID As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldID)

        Dim fldDelete As New GridViewCommandColumn("DELETE") With {
            .FieldName = "fldDelete",
            .DefaultText = "DELETE",
            .UseDefaultText = True,
            .IsPinned = True,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .MinWidth = 80
        }
        gvData.Columns.Add(fldDelete)

        Dim fldInvoiceNo As New GridViewTextBoxColumn("INVOICE NO") With {
            .FieldName = "fldInvoiceNo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldInvoiceNo)

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDFEAP)
        gvData.Columns("fldETDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETACustomer As New GridViewDateTimeColumn("ETA CUSTOMER") With {
            .FieldName = "fldETACustomer",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETACustomer)
        gvData.Columns("fldETACustomer").FormatString = "{0:MMM dd, yyyy}"

        Dim fldPONo As New GridViewTextBoxColumn("PO NO") With {
            .FieldName = "fldPONo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gvData.Columns.Add(fldPONo)

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

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY") With {
            .FieldName = "fldAddedBy",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldAddedBy)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
            .FieldName = "fldDateAdded",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        AddHandler gvData.CommandCellClick, AddressOf gvData_CommandCellClick

    End Sub

End Class
