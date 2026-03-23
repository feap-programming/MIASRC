Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports System.ComponentModel
Imports Telerik.WinControls
Imports System.Text.RegularExpressions
Imports System.Data

Public Class FrmInvoice

    Private dbMIA As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dbHRMSlive As New Kurumi.DB("192.168.191.252", "dbHRMSlive", My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtAllInvoice As DataTable = Nothing
    Private dtEmployee As DataTable = Nothing

    Private myData As DataTable = Nothing

    Private Sub FrmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        dtDateFrom.Value = New Date(Now.Year, Now.Month, 1)
        dtDateTo.Value = New Date(Now.Year, Now.Month, DateTime.DaysInMonth(Now.Year, Now.Month))

        SetUpColumns()

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAddInvoice.Click

        Dim createForm As New FrmCreateInvoice
        createForm.ShowDialog(Me)
        If createForm.Saved Then
            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork

        If Not bwLoadData.CancellationPending Then

            myData = DTInvoice()

            bwLoadData.ReportProgress(100)
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

    Private Function DTInvoice() As DataTable

        dbMIA.AddMySqlParameters("parDateFrom", dtDateFrom.Value)
        dbMIA.AddMySqlParameters("parDateTo", dtDateTo.Value)
        dtAllInvoice = dbMIA.SPSelect("SP_P_SelectInvoiceByDate")
        dtEmployee = dbHRMSlive.MyQuery("SELECT fldEmpNo, fldEmpLastName, fldEmpFirstName, fldEmpMiddleName, fldEmpSuffix FROM tblEmployee")

        Dim dtMyInvoice = (
            From T0 In dtAllInvoice.AsEnumerable()
            Group Join T1 In dtEmployee.AsEnumerable()
                On T0.Field(Of String)("fldPreparedBy") Equals T1.Field(Of String)("fldEmpNo")
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Group Join T2 In dtEmployee.AsEnumerable()
                On T0.Field(Of String)("fldCheckedBy") Equals T2.Field(Of String)("fldEmpNo")
                Into gT2 = Group
            From T2 In gT2.DefaultIfEmpty
            Group Join T3 In dtEmployee.AsEnumerable()
                On T0.Field(Of String)("fldNotedBy") Equals T3.Field(Of String)("fldEmpNo")
                Into gT3 = Group
            From T3 In gT3.DefaultIfEmpty
            Group Join T4 In dtEmployee.AsEnumerable()
                On T0.Field(Of String)("fldApprovedBy") Equals T4.Field(Of String)("fldEmpNo")
                Into gT4 = Group
            From T4 In gT4.DefaultIfEmpty
            Select New With
                {
                    .fldID = T0.Field(Of Int64)("fldID"),
                    .fldInvoiceNo = T0.Field(Of Int64)("fldInvoiceNo"),
                    .fldCustomer = T0.Field(Of String)("fldCustomer"),
                    .fldCustomerName = T0.Field(Of String)("fldCustomerName"),
                    .fldActivity = T0.Field(Of String)("fldActivity"),
                    .fldDescription = T0.Field(Of String)("fldDescription"),
                    .fldInvoiceDate = T0.Field(Of Date)("fldInvoiceDate"),
                    .fldETDFEAP = T0.Field(Of Date)("fldETDFEAP"),
                    .fldATDFEAP = T0.Field(Of Date)("fldATDFEAP"),
                    .fldETDManila = T0.Field(Of Date)("fldETDManila"),
                    .fldATDManila = T0.Field(Of Date)("fldATDManila"),
                    .fldATACustomer = T0.Field(Of Date)("fldATACustomer"),
                    .fldDRNo = T0.Field(Of String)("fldDRNo"),
                    .fldPONo = T0.Field(Of String)("fldPONo"),
                    .fldPCNo = T0.Field(Of String)("fldPCNo"),
                    .fldSoldTo = T0.Field(Of Int64)("fldSoldTo"),
                    .fldSoldToName = T0.Field(Of String)("fldSoldToName"),
                    .fldShippedTo = T0.Field(Of Int64)("fldShippedTo"),
                    .fldShippedToName = T0.Field(Of String)("fldShippedToName"),
                    .fldTerms = T0.Field(Of String)("fldTerms"),
                    .fldCurrency = T0.Field(Of String)("fldCurrency"),
                    .fldForex = T0.Field(Of Decimal)("fldForex"),
                    .fldForexUSD = T0.Field(Of Decimal)("fldForexUSD"),
                    .fldShipVia = T0.Field(Of String)("fldShipVia"),
                    .fldSailingOnOrAbout = T0.Field(Of Date)("fldSailingOnOrAbout"),
                    .fldFreightTerms = T0.Field(Of String)("fldFreightTerms"),
                    .fldFreightCondition = T0.Field(Of String)("fldFreightCondition"),
                    .fldNoOfPackages = T0.Field(Of String)("fldNoOfPackages"),
                    .fldRemarks = T0.Field(Of String)("fldRemarks"),
                    .fldInvoiceUOM = T0.Field(Of String)("fldInvoiceUOM"),
                    .fldPreparedBy = Regex.Replace(
                        String.Concat(
                            T1?.Field(Of String)("fldEmpLastName"), " ",
                            T1?.Field(Of String)("fldEmpSuffix"), ", ",
                            T1?.Field(Of String)("fldEmpFirstName"), " ",
                            T1?.Field(Of String)("fldEmpMiddleName")
                        ),
                        "\s+",
                        " "
                    ),
                    .fldCheckedBy = Regex.Replace(
                        String.Concat(
                            T2?.Field(Of String)("fldEmpLastName"), " ",
                            T2?.Field(Of String)("fldEmpSuffix"), ", ",
                            T2?.Field(Of String)("fldEmpFirstName"), " ",
                            T2?.Field(Of String)("fldEmpMiddleName")
                        ),
                        "\s+",
                        " "
                    ),
                    .fldNotedBy = Regex.Replace(
                        String.Concat(
                            T3?.Field(Of String)("fldEmpLastName"), " ",
                            T3?.Field(Of String)("fldEmpSuffix"), ", ",
                            T3?.Field(Of String)("fldEmpFirstName"), " ",
                            T3?.Field(Of String)("fldEmpMiddleName")
                        ),
                        "\s+",
                        " "
                    ),
                    .fldApprovedBy = Regex.Replace(
                        String.Concat(
                            T4?.Field(Of String)("fldEmpLastName"), " ",
                            T4?.Field(Of String)("fldEmpSuffix"), ", ",
                            T4?.Field(Of String)("fldEmpFirstName"), " ",
                            T4?.Field(Of String)("fldEmpMiddleName")
                        ),
                        "\s+",
                        " "
                    ),
                    .fldBIRReferenceID = T0.Field(Of Int64)("fldShippedTo"),
                    .fldBIRPermitNo = T0.Field(Of String)("fldBIRPermitNo")
                }
        ).ToList()

        Return ConvertToDatatable(dtMyInvoice)

    End Function

    Private Sub cbbAddItem_Click(sender As Object, e As EventArgs) Handles cbbAddItem.Click

        Dim invoiceID As Int64 = gvData.CurrentRow.Cells("fldID").Value
        Dim invoiceNo As Int64 = gvData.CurrentRow.Cells("fldInvoiceNo").Value
        Dim customer As Int64 = gvData.CurrentRow.Cells("fldCustomer").Value

        Dim uploadForm As New FrmUploadInvoiceItem
        uploadForm.ShowDialog(invoiceID, invoiceNo, customer)

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("It will also delete all items under this invoice, are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
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

            id += "," & Convert.ToString(rows(i).Cells("fldID").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))

        Next

        Slipknot.addParameter("IDArray", id)
        Slipknot.dbAED("SP_P_DeleteInvoice")

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

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click
        Dim reportSelector As New FrmSalesInvoiceReportSelector
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

        e.ContextMenu = cmActionChooser.DropDown

    End Sub

    Private Sub miCopy_Click(sender As Object, e As EventArgs) Handles miCopy.Click
        Dim selectionMode As GridViewSelectionMode = Me.gvData.SelectionMode
        Me.gvData.SelectionMode = GridViewSelectionMode.CellSelect
        Me.gvData.CurrentRow.Cells(Me.gvData.CurrentColumn.Name).IsSelected = True
        Me.gvData.Copy()
        Me.gvData.SelectionMode = selectionMode
        Me.gvData.CurrentRow.IsSelected = True
    End Sub

    Private Sub miGenerateInvoice_Click(sender As Object, e As EventArgs) Handles miGenerateInvoice.Click

        Try

            Dim invoiceID As Int64 = gvData.CurrentRow.Cells("fldID").Value

            Dim reportViewer As New FrmRptSalesInvoice
            reportViewer.Show(invoiceID)

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub miViewItems_Click(sender As Object, e As EventArgs) Handles miViewItems.Click

        Try

            Dim invoiceID As Int64 = gvData.CurrentRow.Cells("fldID").Value

            Dim viewForm As New FrmViewInvoiceItem
            viewForm.ShowDialog(invoiceID)

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub miEditInvoice_Click(sender As Object, e As EventArgs) Handles miEditInvoice.Click

        Try

            Dim invoiceID As Int64 = gvData.CurrentRow.Cells("fldID").Value

            Dim editForm As New FrmEditInvoice
            editForm.ShowDialog(invoiceID)
            If editForm.Saved Then
                If bwLoadData.IsBusy = False Then
                    bwLoadData.RunWorkerAsync()
                End If
            End If

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub gvData_CommandCellClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
        If TypeOf e.Column Is GridViewCommandColumn Then

            If gvData.CurrentCell.ColumnInfo.FieldName = "fldInvoice" Then

                Dim invoiceID As Int64 = gvData.CurrentRow.Cells("fldID").Value

                Dim reportViewer As New FrmRptSalesInvoice
                reportViewer.Show(invoiceID)

            ElseIf gvData.CurrentCell.ColumnInfo.FieldName = "fldItems" Then

                Dim invoiceID As Int64 = gvData.CurrentRow.Cells("fldID").Value

                Dim viewForm As New FrmViewInvoiceItem
                viewForm.ShowDialog(invoiceID)

            End If
        End If
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.CellFormatting

        If e.CellElement.ColumnInfo.FieldName = "fldETDFEAP" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldETDManila" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldATDFEAP" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldATDManila" OrElse
            e.CellElement.ColumnInfo.FieldName = "fldATACustomer" Then
            If e.CellElement.Value = #0001-01-01# Then
                e.CellElement.ForeColor = Color.Transparent
            Else
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            End If
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If

    End Sub

    Public Shared Function ConvertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, prop.PropertyType)
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

    Private Sub SetUpColumns()

        Dim fldID As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .IsVisible = False
        }
        gvData.Columns.Add(fldID)

        Dim fldInvoice As New GridViewCommandColumn("INVOICE") With {
            .FieldName = "fldInvoice",
            .DefaultText = "View",
            .UseDefaultText = True,
            .IsPinned = True,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .MinWidth = 80,
            .IsVisible = False
        }
        gvData.Columns.Add(fldInvoice)

        Dim fldItems As New GridViewCommandColumn("ITEM/S") With {
            .FieldName = "fldItems",
            .DefaultText = "View",
            .UseDefaultText = True,
            .IsPinned = True,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .MinWidth = 80,
            .IsVisible = False
        }
        gvData.Columns.Add(fldItems)

        Dim fldInvoiceNo As New GridViewDecimalColumn("INVOICE NO") With {
            .FieldName = "fldInvoiceNo",
            .MinWidth = 120,
            .IsPinned = True,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldInvoiceNo)

        Dim fldCustomer As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomer",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldCustomer)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldCustomerName)

        Dim fldActivity As New GridViewTextBoxColumn("ACTIVITY") With {
            .FieldName = "fldActivity",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldActivity)

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION") With {
            .FieldName = "fldDescription",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDescription)

        Dim fldInvoiceDate As New GridViewDateTimeColumn("INVOICE DATE") With {
            .FieldName = "fldInvoiceDate",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldInvoiceDate)
        gvData.Columns("fldInvoiceDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDFEAP)
        gvData.Columns("fldETDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATDFEAP As New GridViewDateTimeColumn("ATD FEAP") With {
            .FieldName = "fldATDFEAP",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldATDFEAP)
        gvData.Columns("fldATDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETDManila As New GridViewDateTimeColumn("ETD MNL") With {
            .FieldName = "fldETDManila",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDManila)
        gvData.Columns("fldETDManila").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATDManila As New GridViewDateTimeColumn("ATD MNL") With {
            .FieldName = "fldATDManila",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldATDManila)
        gvData.Columns("fldATDManila").FormatString = "{0:MMM dd, yyyy}"

        Dim fldATACustomer As New GridViewDateTimeColumn("ATA CUSTOMER") With {
            .FieldName = "fldATACustomer",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldATACustomer)
        gvData.Columns("fldATACustomer").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDRNo As New GridViewTextBoxColumn("DR NO") With {
            .FieldName = "fldDRNo",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldDRNo)

        Dim fldPONo As New GridViewTextBoxColumn("PO NO") With {
            .FieldName = "fldPONo",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldPONo)

        Dim fldPCNo As New GridViewTextBoxColumn("PC NO") With {
            .FieldName = "fldPCNo",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldPCNo)

        Dim fldSoldTo As New GridViewDecimalColumn("SOLD TO") With {
            .FieldName = "fldSoldTo",
            .Width = 80,
            .IsVisible = False
        }
        gvData.Columns.Add(fldSoldTo)

        Dim fldSoldToName As New GridViewTextBoxColumn("SOLD TO") With {
            .FieldName = "fldSoldToName",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldSoldToName)

        Dim fldShippedTo As New GridViewDecimalColumn("SHIPPED TO") With {
            .FieldName = "fldShippedTo",
            .Width = 80,
            .IsVisible = False
        }
        gvData.Columns.Add(fldShippedTo)

        Dim fldShippedToName As New GridViewTextBoxColumn("SHIPPED TO") With {
            .FieldName = "fldShippedToName",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldShippedToName)

        Dim fldTerms As New GridViewTextBoxColumn("TERMS") With {
            .FieldName = "fldTerms",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldTerms)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY") With {
            .FieldName = "fldCurrency",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldCurrency)

        Dim fldForex As New GridViewDecimalColumn("FOREX") With {
            .FieldName = "fldForex",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = False
        }
        gvData.Columns.Add(fldForex)

        Dim fldForexUSD As New GridViewDecimalColumn("FOREX (USD)") With {
            .FieldName = "fldForexUSD",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = False
        }
        gvData.Columns.Add(fldForexUSD)

        Dim fldShipVia As New GridViewTextBoxColumn("SHIP VIA") With {
            .FieldName = "fldShipVia",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldShipVia)

        Dim fldSailingOnOrAbout As New GridViewDateTimeColumn("SAILING ON OR ABOUT") With {
            .FieldName = "fldSailingOnOrAbout",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldSailingOnOrAbout)
        gvData.Columns("fldSailingOnOrAbout").FormatString = "{0:MMM dd, yyyy}"

        Dim fldFreightTerms As New GridViewTextBoxColumn("FREIGHT TERMS") With {
            .FieldName = "fldFreightTerms",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldFreightTerms)

        Dim fldFreightCondition As New GridViewTextBoxColumn("FREIGHT CONDITION") With {
            .FieldName = "fldFreightCondition",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldFreightCondition)

        Dim fldNoOfPackages As New GridViewTextBoxColumn("NO OF PACKAGES") With {
            .FieldName = "fldNoOfPackages",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldNoOfPackages)

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS") With {
            .FieldName = "fldRemarks",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldRemarks)

        Dim fldInvoiceUOM As New GridViewTextBoxColumn("UOM") With {
            .FieldName = "fldInvoiceUOM",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldInvoiceUOM)

        Dim fldPreparedBy As New GridViewTextBoxColumn("PREPARED BY") With {
            .FieldName = "fldPreparedBy",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldPreparedBy)

        Dim fldCheckedBy As New GridViewTextBoxColumn("CHECKED BY") With {
            .FieldName = "fldCheckedBy",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldCheckedBy)

        Dim fldNotedBy As New GridViewTextBoxColumn("NOTED BY") With {
            .FieldName = "fldNotedBy",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldNotedBy)

        Dim fldApprovedBy As New GridViewTextBoxColumn("APPROVED BY") With {
            .FieldName = "fldApprovedBy",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldApprovedBy)

        Dim fldBIRReferenceID As New GridViewDecimalColumn("BIR REF") With {
            .FieldName = "fldBIRReferenceID",
            .Width = 80,
            .IsVisible = False
        }
        gvData.Columns.Add(fldBIRReferenceID)

        Dim fldBIRPermitNo As New GridViewTextBoxColumn("BIR PERMIT NO") With {
            .FieldName = "fldBIRPermitNo",
            .MinWidth = 150
        }
        gvData.Columns.Add(fldBIRPermitNo)

        gvData.TableElement.RowHeight = 25

        AddHandler gvData.CommandCellClick, AddressOf gvData_CommandCellClick

    End Sub

    Private Sub FrmInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Me.bwLoadData.IsBusy Then
            Me.bwLoadData.CancelAsync()
        End If

        If Me.bwOperation.IsBusy Then
            Me.bwOperation.CancelAsync()
        End If

    End Sub

End Class
