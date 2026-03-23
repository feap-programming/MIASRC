Imports System.ComponentModel
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmImportActual

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    'Private dtPartNoAnnex As DataTable
    Private dtItemMasterPerCustomer As DataTable
    Private dtModel As DataTable
    Private dtCustomer As DataTable

    Public linestat As String = String.Empty
    Public lineerror As String = String.Empty
    Public lineNo As Integer
    Private hasError As Boolean = False

    Private Sub FrmImportActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)
    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click
        Try
            gvData.DataSource = Nothing

            Dim table As DataTable = Slipknot.getClipboard

            Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                        Select New With
                                             {
                                                .fldInvoiceNo = T0.Item(0),
                                                .fldETDFEAP = T0.Item(1),
                                                .fldETDManila = T0.Item(2),
                                                .fldATDFEAP = T0.Item(3),
                                                .fldATDManila = T0.Item(4),
                                                .fldATACustomer = T0.Item(5),
                                                .fldCustomerName = Regex.Replace(Trim(T0.Item(6)), "\s+", " "),
                                                .fldModelName = Regex.Replace(Trim(T0.Item(7)), "\s+", " "),
                                                .fldPartNo = Regex.Replace(Trim(T0.Item(8)), "\s+", " "),
                                                .fldPartName = Regex.Replace(Trim(T0.Item(9)), "\s+", " "),
                                                .fldUnitPrice = IIf(Not String.IsNullOrEmpty(T0.Item(10)), T0.Item(10), 0),
                                                .fldCurrency = Regex.Replace(Trim(T0.Item(11)), "\s+", " "),
                                                .fldQuantity = IIf(Not String.IsNullOrEmpty(T0.Item(12)), T0.Item(12), 0)
                                             }).ToList
            gvData.DataSource = Query
        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click

        If gvData.Rows.Count > 0 Then

            'dtPartNoAnnex = myDB.SPSelect("SP_SelectAllPartyNoHistory")
            dtItemMasterPerCustomer = myDB.SPSelect("SP_SelectAllItemMasterPerCustomer")
            dtModel = myDB.SPSelect("SP_SelectAllModel")
            dtCustomer = myDB.SPSelect("SP_SelectAllCustomers")
            bwCheck.RunWorkerAsync()

        Else

            RadMessageBox.Show(Me, "No data to import.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub bwCheck_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCheck.DoWork

        Dim delay As Integer = 30

        For counter As Integer = 0 To gvData.Rows.Count - 1

            linestat = String.Empty
            lineerror = String.Empty

            Try

                If Not dtItemMasterPerCustomer.Select(
                        "customer = '" & Regex.Replace(Trim(gvData.Rows(counter).Cells("fldCustomerName").Value), "\s+", " ") & "' AND " &
                        "model = '" & Regex.Replace(Trim(gvData.Rows(counter).Cells("fldModelName").Value), "\s+", " ") & "' AND " &
                        "fldItemCode = '" & Regex.Replace(Trim(gvData.Rows(counter).Cells("fldPartNo").Value), "\s+", " ") & "' AND " &
                        "fldPartName = '" & Regex.Replace(Trim(gvData.Rows(counter).Cells("fldPartName").Value), "\s+", " ") & "'"
                    ).Length > 0 Then

                    linestat = "NG"
                    lineerror += "* Item not found in the master list. "
                    hasError = True

                    'If Not dtPartNoAnnex.Select("fldNewItemCode = '" & Trim(gvData.Rows(counter).Cells("fldAnnex").Value) & "'").Length > 0 Then

                    '    lineerror += Environment.NewLine & "* Annex has not been defined. "

                    'End If

                    If Not dtCustomer.Select("fldCustomerName = '" & Trim(gvData.Rows(counter).Cells("fldCustomerName").Value) & "'").Length > 0 Then

                        lineerror += Environment.NewLine & "* Customer has not been defined. "

                    End If

                    If Not dtModel.Select("fldModelName = '" & Trim(gvData.Rows(counter).Cells("fldModelName").Value) & "'").Length > 0 Then

                        lineerror += Environment.NewLine & "* Model has not been defined. "

                    End If

                End If

            Catch ex As Exception

                linestat = "NG"
                lineerror += String.Concat("* ", ex.Message, " ")

            Finally

                If Not linestat = "NG" Then

                    linestat = "GOOD"
                    lineerror = String.Empty

                Else

                    If Not hasError Then

                        hasError = True

                    End If

                End If

                Dim percent As Double = counter / gvData.Rows.Count * 100
                lineNo = counter
                RadProgressBarElement1.Text = "Checking..."
                bwCheck.ReportProgress(Convert.ToInt32(percent))
                Threading.Thread.Sleep(delay)

            End Try

        Next

    End Sub

    Private Sub bwCheck_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwCheck.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells("fldStatus").Value = linestat
        gvData.CurrentRow.Cells("fldErrorMessage").Value = lineerror
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwCheck_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCheck.RunWorkerCompleted

        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        gvData.BestFitColumns()

        If Not hasError Then

            Dim result As DialogResult = RadMessageBox.Show(Me, "Records have been checked. Do you still want to proceed in saving?", "Saving", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                bwUpload.RunWorkerAsync()
            End If

        Else

            RadMessageBox.Show(Me, "There are items not found in the master list", "Item Not Found", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

        hasError = False

    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 30

        'Dim drItemMasterPerCustomer As DataRow()
        Dim drCustomer As DataRow()
        Dim drModel As DataRow()

        For counter As Integer = 0 To gvData.Rows.Count - 1

            drCustomer = dtCustomer.Select("fldCustomerName = '" & Trim(gvData.Rows(counter).Cells("fldCustomerName").Value) & "'")
            drModel = dtModel.Select("fldModelName = '" & Trim(gvData.Rows(counter).Cells("fldModelName").Value) & "'")

            Slipknot.addParameter("parInvoiceNo", Regex.Replace(Trim(gvData.Rows(counter).Cells("fldInvoiceNo").Value), "\s+", " "))
            Slipknot.addParameter("parETDFEAP", If(Not String.IsNullOrEmpty(gvData.Rows(counter).Cells("fldETDFEAP").Value), Date.ParseExact(gvData.Rows(counter).Cells("fldETDFEAP").Value, "dd-MMM-yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), New Date(1, 1, 1)))
            Slipknot.addParameter("parATDFEAP", If(Not String.IsNullOrEmpty(gvData.Rows(counter).Cells("fldATDFEAP").Value), Date.ParseExact(gvData.Rows(counter).Cells("fldATDFEAP").Value, "dd-MMM-yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), New Date(1, 1, 1)))
            Slipknot.addParameter("parETDManila", If(Not String.IsNullOrEmpty(gvData.Rows(counter).Cells("fldETDManila").Value), Date.ParseExact(gvData.Rows(counter).Cells("fldETDManila").Value, "dd-MMM-yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), New Date(1, 1, 1)))
            Slipknot.addParameter("parATDManila", If(Not String.IsNullOrEmpty(gvData.Rows(counter).Cells("fldATDManila").Value), Date.ParseExact(gvData.Rows(counter).Cells("fldATDManila").Value, "dd-MMM-yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), New Date(1, 1, 1)))
            Slipknot.addParameter("parATACustomer", If(Not String.IsNullOrEmpty(gvData.Rows(counter).Cells("fldATACustomer").Value), Date.ParseExact(gvData.Rows(counter).Cells("fldATACustomer").Value, "dd-MMM-yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo), New Date(1, 1, 1)))
            Slipknot.addParameter("parCustomer", drCustomer(0).Item("fldCustomerCode"))
            Slipknot.addParameter("parModel", drModel(0).Item("fldCode"))
            Slipknot.addParameter("parPartNo", Regex.Replace(Trim(gvData.Rows(counter).Cells("fldPartNo").Value), "\s+", " "))
            Slipknot.addParameter("parPartName", Regex.Replace(Trim(gvData.Rows(counter).Cells("fldPartName").Value), "\s+", " "))
            'Slipknot.addParameter("parAnnexID", drPartNoByAnnex(0).Item("fldId"))
            Slipknot.addParameter("parUnitPrice", gvData.Rows(counter).Cells("fldUnitPrice").Value)
            Slipknot.addParameter("parCurrency", Regex.Replace(Trim(gvData.Rows(counter).Cells("fldCurrency").Value), "\s+", " "))
            Slipknot.addParameter("parQuantity", gvData.Rows(counter).Cells("fldQuantity").Value)
            Slipknot.addParameter("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
            If Slipknot.dbAED("SP_P_InsertActual") Then
                linestat = "SAVED"
            Else
                linestat = "NG"
                Continue For
            End If

            Threading.Thread.Sleep(delay)

            Dim percent As Double = counter / gvData.Rows.Count * 100
            lineNo = counter
            RadProgressBarElement1.Text = "Saving..."
            bwUpload.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)

        Next

    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        RadMessageBox.Show("Successfully Uploaded", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you want to delete " & gvData.SelectedRows.Count & " selected row(s)?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}
            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1
                Me.gvData.Rows.Remove(rows(i))
            Next
        End If
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click
        If RadMessageBox.Show("Are you sure you want to clear the list?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            gvData.DataSource = Nothing
        End If
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.CellFormatting

        If e.CellElement.ColumnInfo.FieldName = "fldStatus" Then
            If Convert.ToString(e.CellElement.Value) = "SAVED" Then
                e.CellElement.ForeColor = Color.FromArgb(255, 255, 255)
                e.CellElement.BackColor = Color.FromArgb(34, 167, 240)
                e.CellElement.BackColor2 = Color.FromArgb(34, 167, 240)
                e.CellElement.BackColor3 = Color.FromArgb(34, 167, 240)
                e.CellElement.BackColor4 = Color.FromArgb(34, 167, 240)
            ElseIf Convert.ToString(e.CellElement.Value) = "OK" Then
                e.CellElement.ForeColor = Color.FromArgb(255, 255, 255)
                e.CellElement.BackColor = Color.FromArgb(4, 147, 114)
                e.CellElement.BackColor2 = Color.FromArgb(4, 147, 114)
                e.CellElement.BackColor3 = Color.FromArgb(4, 147, 114)
                e.CellElement.BackColor4 = Color.FromArgb(4, 147, 114)
            ElseIf Convert.ToString(e.CellElement.Value) = "GOOD" Then
                e.CellElement.ForeColor = Color.FromArgb(0, 0, 0)
                e.CellElement.BackColor = Color.FromArgb(244, 208, 63)
                e.CellElement.BackColor2 = Color.FromArgb(244, 208, 63)
                e.CellElement.BackColor3 = Color.FromArgb(244, 208, 63)
                e.CellElement.BackColor4 = Color.FromArgb(244, 208, 63)
            ElseIf Convert.ToString(e.CellElement.Value) = "NG" Then
                e.CellElement.ForeColor = Color.FromArgb(255, 255, 255)
                e.CellElement.BackColor = Color.FromArgb(242, 38, 19)
                e.CellElement.BackColor2 = Color.FromArgb(242, 38, 19)
                e.CellElement.BackColor3 = Color.FromArgb(242, 38, 19)
                e.CellElement.BackColor4 = Color.FromArgb(242, 38, 19)
            Else
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor3Property, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor4Property, ValueResetFlags.Local)
            End If
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColor3Property, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColor4Property, ValueResetFlags.Local)
        End If

    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS") With {
            .FieldName = "fldStatus",
            .MinWidth = 60,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsPinned = True,
            .PinPosition = PinnedColumnPosition.Left,
            .ReadOnly = True
        }
        gridView.Columns.Add(fldStatColumn)

        Dim fldInvoiceNo As New GridViewTextBoxColumn("INVOICE NO. *") With {
            .FieldName = "fldInvoiceNo",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldInvoiceNo)

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP *") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "dd-MMM-yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETDFEAP)
        gridView.Columns("fldETDFEAP").FormatString = "{0:dd-MMM-yyyy}"

        Dim fldETDManila As New GridViewDateTimeColumn("ETD MNL *") With {
            .FieldName = "fldETDManila",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "dd-MMM-yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETDManila)
        gridView.Columns("fldETDManila").FormatString = "{0:dd-MMM-yyyy}"

        Dim fldATDFEAP As New GridViewDateTimeColumn("ATD FEAP *") With {
            .FieldName = "fldATDFEAP",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "dd-MMM-yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldATDFEAP)
        gridView.Columns("fldATDFEAP").FormatString = "{0:dd-MMM-yyyy}"

        Dim fldATDManila As New GridViewDateTimeColumn("ATD MNL *") With {
            .FieldName = "fldATDManila",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "dd-MMM-yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldATDManila)
        gridView.Columns("fldATDManila").FormatString = "{0:dd-MMM-yyyy}"

        Dim fldATACustomer As New GridViewDateTimeColumn("ATA Customer *") With {
            .FieldName = "fldATACustomer",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldATACustomer)
        gridView.Columns("fldATACustomer").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER *") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldCustomerName)

        Dim fldModelName As New GridViewTextBoxColumn("MODEL *") With {
            .FieldName = "fldModelName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldModelName)

        Dim fldPartNo As New GridViewTextBoxColumn("PART NO *") With {
            .FieldName = "fldPartNo",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME *") With {
            .FieldName = "fldPartName",
            .MinWidth = 200
        }
        gridView.Columns.Add(fldPartName)

        Dim fldUnitPrice As New GridViewDecimalColumn("UNIT PRICE *") With {
            .FieldName = "fldUnitPrice",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight
        }
        gridView.Columns.Add(fldUnitPrice)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY *") With {
            .FieldName = "fldCurrency",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldCurrency)

        Dim fldQuantity As New GridViewDecimalColumn("QUANTITY *") With {
            .FieldName = "fldQuantity",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight
        }
        gridView.Columns.Add(fldQuantity)

        Dim fldErrorColumn As New GridViewTextBoxColumn("ERROR MESSAGE") With {
            .FieldName = "fldErrorMessage",
            .MinWidth = 200,
            .ReadOnly = True
        }
        gridView.Columns.Add(fldErrorColumn)

    End Sub

End Class
