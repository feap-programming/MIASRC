Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmImportServedPO

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtOpenPO As DataTable
    Private parPONo As String = String.Empty

    Private linestat As String = String.Empty
    Private lineerror As String = String.Empty
    Private lineNo As Integer
    Private isItemExist As Boolean = True
    Private isExceededQty As Boolean = False

    Private Sub FrmImportServedPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)
        SetUpColumns(gvData)

    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click

        Try

            gvData.DataSource = Nothing

            Dim table As DataTable = Slipknot.getClipboard

            For Each row As DataRow In table.Rows
                Dim rowInfo As GridViewRowInfo = gvData.Rows.AddNew()
                rowInfo.Cells("fldInvoiceNo").Value = Trim(row(0))
                rowInfo.Cells("fldETDFEAP").Value = row(1)
                rowInfo.Cells("fldETACustomer").Value = row(2)
                rowInfo.Cells("fldPONo").Value = Trim(row(3))
                rowInfo.Cells("fldPartName").Value = Trim(row(4))
                rowInfo.Cells("fldQuantity").Value = IIf(String.IsNullOrWhiteSpace(row(5)) Or (row(5) = "-"), 0, row(5))
            Next

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click

        If gvData.Rows.Count > 0 Then

            'pnlContols.Enabled = False
            RadCommandBar1.Enabled = False

            bwCheck.RunWorkerAsync()

        Else

            RadMessageBox.Show(Me, "No data to save.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub bwCheck_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCheck.DoWork
        Dim delay As Integer = 30

        For counter As Integer = 0 To gvData.Rows.Count - 1

            Me.dtOpenPO = Me.myDB.SPSelect("SP_P_SelectAllOpenPO")

            If dtOpenPO.Select("fldPONo = '" & Trim(gvData.Rows(counter).Cells("fldPONo").Value) & "' AND " &
                               "fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "' AND " &
                               "fldRemainingQty >= '" & Trim(gvData.Rows(counter).Cells("fldQuantity").Value) & "'").Length > 0 Then

                linestat = "GOOD"
                lineerror = String.Empty

            ElseIf dtOpenPO.Select("fldPONo = '" & Trim(gvData.Rows(counter).Cells("fldPONo").Value) & "' AND " &
                               "fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "' AND " &
                               "fldRemainingQty < '" & Trim(gvData.Rows(counter).Cells("fldQuantity").Value) & "'").Length > 0 Then

                linestat = "WARNING"
                lineerror = Environment.NewLine & "Item quantity exceeds to PO remaining quantity."
                isExceededQty = True

            Else

                linestat = "NG"
                lineerror = "Invalid transaction."

                If Not dtOpenPO.Select("fldPONo = '" & Trim(gvData.Rows(counter).Cells("fldPONo").Value) & "'").Length > 0 Then
                    isItemExist = False
                    lineerror += Environment.NewLine & "PO No does not exist."
                ElseIf Not dtOpenPO.Select("fldPONo = '" & Trim(gvData.Rows(counter).Cells("fldPONo").Value) & "' AND " &
                                                        "fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "'").Length > 0 Then
                    isItemExist = False
                    lineerror += Environment.NewLine & "Part Name does not exist in PO."
                    'ElseIf Not dtOpenPO.Select("fldPONo = '" & Trim(gvData.Rows(counter).Cells("fldPONo").Value) & "' AND " &
                    '                                        "fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "' AND " &
                    '                                        "fldRemainingQty >= '" & Trim(gvData.Rows(counter).Cells("fldQuantity").Value) & "'").Length > 0 Then
                    '    isItemExist = False
                    '    lineerror += Environment.NewLine & "Item quantity exceeds to PO remaining quantity."
                Else
                    isItemExist = False
                    lineerror += Environment.NewLine & "Something went wrong. Contact your administrator."
                End If

            End If

            Dim percent As Double = (counter + 1) / gvData.Rows.Count * 100
            lineNo = counter
            RadProgressBarElement1.Text = "Checking..."
            bwCheck.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)

        Next

    End Sub

    Private Sub bwCheck_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwCheck.ProgressChanged

        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells("fldStatus").Value = IIf(linestat = "GOOD", 1, IIf(linestat = "WARNING", 2, 0))
        gvData.CurrentRow.Cells("fldErrorMessage").Value = lineerror
        RadProgressBarElement1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub bwCheck_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCheck.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If isItemExist Then

            If isExceededQty Then

                Dim result As DialogResult = RadMessageBox.Show("There are item quantity exceeded to PO quantity, have you already checked the item/s with warning and want to proceed?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question)

                If result = DialogResult.Yes Then

                    bwUpload.RunWorkerAsync()

                Else

                    RadCommandBar1.Enabled = True

                End If

            Else

                bwUpload.RunWorkerAsync()

            End If

        Else

            'pnlContols.Enabled = True
            RadCommandBar1.Enabled = True

            RadMessageBox.Show(Me, "There are items with invalid information", "Invalid Transaction", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

        isItemExist = True
        isExceededQty = False
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 20

        For counter As Integer = 0 To gvData.Rows.Count - 1

            lineNo = counter

            Slipknot.addParameter("parInvoiceNo", gvData.Rows(counter).Cells("fldInvoiceNo").Value)
            Slipknot.addParameter("parETDFEAP", gvData.Rows(counter).Cells("fldETDFEAP").Value)
            Slipknot.addParameter("parETACustomer", gvData.Rows(counter).Cells("fldETACustomer").Value)
            Slipknot.addParameter("parPartName", gvData.Rows(counter).Cells("fldPartName").Value)
            Slipknot.addParameter("parPONo", gvData.Rows(counter).Cells("fldPONo").Value)
            Slipknot.addParameter("parQuantity", gvData.Rows(counter).Cells("fldQuantity").Value)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            If Slipknot.dbAED("SP_P_InsertServedPO") Then
                linestat = "SAVING..."
            Else
                linestat = "NG"
                lineerror = "Systsem error. Kindly contact your administrator."
                Continue For
            End If

            Dim percent As Double = ((counter + 1) / gvData.Rows.Count) * 100
            RadProgressBarElement1.Text = "Saving..."
            bwUpload.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)

        Next

    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells("fldStatus").Value = 100
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted

        'pnlContols.Enabled = True
        RadCommandBar1.Enabled = True

        If RadProgressBarElement1.Value1 = 100 Then
            RadProgressBarElement1.Text = "Done"
            RadMessageBox.Show("Successfully Uploaded", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
            Me.Close()
        Else
            RadProgressBarElement1.Text = "Unfinished"
            RadMessageBox.Show("There are unsaved item/s. Kindly check the grid for your reference.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you to delete " & gvData.SelectedRows.Count & " selected row(s)?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
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
            gvData.Rows.Clear()
        End If
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        gridView.Columns.Clear()

        Dim fldStatus As New ProgressBarColumn("STATUS") With {
            .FieldName = "fldStatus",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldStatus)

        'Dim fldID As New GridViewTextBoxColumn("ID") With {
        '    .FieldName = "fldID",
        '    .MinWidth = 80,
        '    .TextAlignment = ContentAlignment.MiddleCenter,
        '    .IsVisible = False
        '}
        'gridView.Columns.Add(fldID)

        Dim fldInvoiceNo As New GridViewTextBoxColumn("INVOICE NO") With {
            .FieldName = "fldInvoiceNo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldInvoiceNo)

        Dim fldETDFEAP As New GridViewDateTimeColumn("ETD FEAP") With {
            .FieldName = "fldETDFEAP",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETDFEAP)
        gridView.Columns("fldETDFEAP").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETACustomer As New GridViewDateTimeColumn("ETA Customer") With {
            .FieldName = "fldETACustomer",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETACustomer)
        gridView.Columns("fldETACustomer").FormatString = "{0:MMM dd, yyyy}"

        Dim fldPONo As New GridViewTextBoxColumn("PO NO") With {
            .FieldName = "fldPONo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldPONo)

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

        Dim fldErrorMessage As New GridViewTextBoxColumn("ERROR MESSAGE") With {
            .FieldName = "fldErrorMessage",
            .MinWidth = 300,
            .TextAlignment = ContentAlignment.MiddleLeft,
            .IsVisible = True
        }
        gridView.Columns.Add(fldErrorMessage)

        gridView.TableElement.RowHeight = 25

    End Sub

End Class
