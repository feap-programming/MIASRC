Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmImportPurchaseOrder

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtItemMasterPerCustomer As DataTable
    Private dtItemMasterData As DataTable
    Private dtCustomer As DataTable
    Private linecolstat As UInt32 = 0
    Private linestat As String = String.Empty
    Private lineerror As String = String.Empty
    Private lineNo As Integer
    Private isItemExist As Boolean = True

    Private isPartNameNotExist As Boolean = True
    Private isCustomerNotExist As Boolean = True

    Private Sub FrmImportPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)
        LoadCustomerDropDown(ddCustomerCode)
        SetUpColumns(gvData)

    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click

        If Not String.IsNullOrWhiteSpace(ddCustomerCode.Text) AndAlso
            Not String.IsNullOrWhiteSpace(ddModeOfShipment.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtPONo.Text) Then

            If gvData.Columns.Count > 0 Then

                Try

                    gvData.DataSource = Nothing

                    Dim table As DataTable = Slipknot.getClipboard

                    For Each row As DataRow In table.Rows
                        Dim rowInfo As GridViewRowInfo = gvData.Rows.AddNew()
                        rowInfo.Cells("fldCustomerID").Value = ddCustomerCode.SelectedValue
                        rowInfo.Cells("fldCustomerName").Value = ddCustomerCode.Text
                        rowInfo.Cells("fldModeOfShipment").Value = ddModeOfShipment.Text
                        rowInfo.Cells("fldDateReceived").Value = dtDateReceived.Value
                        rowInfo.Cells("fldETACustomer").Value = dtETACustomer.Value
                        rowInfo.Cells("fldPONo").Value = txtPONo.Text
                        rowInfo.Cells("fldPartName").Value = Trim(row(0))
                        rowInfo.Cells("fldQtyPerBox").Value = row(1)
                        rowInfo.Cells("fldQtyPerPallet").Value = row(2)
                        rowInfo.Cells("fldQuantity").Value = IIf(String.IsNullOrWhiteSpace(row(3)) Or (row(3) = "-"), 0, row(3))
                    Next

                Catch ex As Exception
                    RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                End Try

            Else

                RadMessageBox.Show(Me, "Please create a grid first.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            End If

        Else

            RadMessageBox.Show(Me, "Please completely fill-out the required fields.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click

        If gvData.Rows.Count > 0 Then

            pnlContols.Enabled = False
            RadCommandBar1.Enabled = False

            Me.dtItemMasterData = Me.myDB.SPSelect("SP_SelectAllItemMasterData")
            Me.dtCustomer = Me.myDB.SPSelect("SP_SelectAllCustomers")
            bwCheck.RunWorkerAsync()

        Else

            RadMessageBox.Show(Me, "No data to save.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub bwCheck_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCheck.DoWork
        Dim delay As Integer = 30

        dtItemMasterPerCustomer = Me.myDB.SPSelect("SP_SelectAllItemMasterPerCustomer")

        For counter As Integer = 0 To gvData.Rows.Count - 1

            If Not String.IsNullOrWhiteSpace((gvData.Rows(counter).Cells("fldCustomerName").Value)) AndAlso
                Not String.IsNullOrWhiteSpace((gvData.Rows(counter).Cells("fldPartName").Value)) AndAlso
                dtItemMasterPerCustomer.Select("customer = '" & Trim(gvData.Rows(counter).Cells("fldCustomerName").Value) & "' AND " &
                                                "fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "'").Length > 0 Then

                linestat = "GOOD"
                lineerror = String.Empty

                isPartNameNotExist = False
                isCustomerNotExist = False

            Else

                linestat = "NG"
                lineerror = "Item not found in the master list."

                If String.IsNullOrWhiteSpace((gvData.Rows(counter).Cells("fldCustomerName").Value)) Then
                    isCustomerNotExist = True
                    lineerror += Environment.NewLine & "Customer must not null or empty."
                ElseIf Not dtCustomer.Select("fldCustomerName = '" & Trim(gvData.Rows(counter).Cells("fldCustomerName").Value) & "'").Length > 0 Then
                    isCustomerNotExist = True
                    lineerror += Environment.NewLine & "Anonymous Customer."
                ElseIf Not dtItemMasterPerCustomer.Select("customer = '" & Trim(gvData.Rows(counter).Cells("fldCustomerName").Value) & "' AND " &
                                                          "fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "'").Length > 0 Then
                    isCustomerNotExist = True
                    lineerror += Environment.NewLine & "Customer not set to Item Master Per Customer for this item."
                Else
                    isCustomerNotExist = False
                End If

                If String.IsNullOrWhiteSpace((gvData.Rows(counter).Cells("fldPartName").Value)) Then
                    isPartNameNotExist = True
                    lineerror += Environment.NewLine & "Part Name must not null or empty."
                ElseIf Not dtItemMasterData.Select("fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "'").Length > 0 Then
                    isPartNameNotExist = True
                    lineerror += Environment.NewLine & "Anonymous Part Name."
                ElseIf Not dtItemMasterPerCustomer.Select("fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "'").Length > 0 Then
                    isPartNameNotExist = True
                    lineerror += Environment.NewLine & "Part Name not set to Item Master Per Customer"
                Else
                    isPartNameNotExist = False
                End If

                If isItemExist Then
                    isItemExist = False
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
        gvData.CurrentRow.Cells("fldStatus").Value = IIf(linestat = "GOOD", 1, 0)
        gvData.CurrentRow.Cells("fldErrorMessage").Value = lineerror
        RadProgressBarElement1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub bwCheck_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCheck.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If isItemExist Then

            bwUpload.RunWorkerAsync()

        Else

            pnlContols.Enabled = True
            RadCommandBar1.Enabled = True

            RadMessageBox.Show(Me, "There are items not found in the master list", "Item Not Found", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

        isItemExist = True
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 20

        For counter As Integer = 0 To gvData.Rows.Count - 1

            lineNo = counter

            Slipknot.addParameter("parDateReceived", gvData.Rows(counter).Cells("fldDateReceived").Value)
            Slipknot.addParameter("parETACustomer", gvData.Rows(counter).Cells("fldETACustomer").Value)
            Slipknot.addParameter("parCustomerID", gvData.Rows(counter).Cells("fldCustomerID").Value)
            Slipknot.addParameter("parPartName", gvData.Rows(counter).Cells("fldPartName").Value)
            Slipknot.addParameter("parPONo", gvData.Rows(counter).Cells("fldPONo").Value)
            Slipknot.addParameter("parModeOfShipment", gvData.Rows(counter).Cells("fldModeOfShipment").Value)
            Slipknot.addParameter("parQtyPerBox", gvData.Rows(counter).Cells("fldQtyPerBox").Value)
            Slipknot.addParameter("parQtyPerPallet", gvData.Rows(counter).Cells("fldQtyPerPallet").Value)
            Slipknot.addParameter("parQuantity", gvData.Rows(counter).Cells("fldQuantity").Value)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            If Slipknot.dbAED("SP_P_InsertPurchaseOrder") Then
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

        pnlContols.Enabled = True
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

    Public Sub LoadCustomerDropDown(dropdown As RadMultiColumnComboBox)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUSTOMER ID") With {
            .FieldName = "fldId",
            .Width = 100
        }
        dropdown.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER CODE") With {
            .FieldName = "fldCustomerName",
            .Width = 200
        }
        dropdown.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")
        dropdown.DataSource = dtCustomer
        dropdown.DisplayMember = "fldCustomerName"
        dropdown.ValueMember = "fldId"
        dropdown.MultiColumnComboBoxElement.DropDownWidth = 350

        dropdown.AutoFilter = True
        dropdown.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerCode As New FilterDescriptor With {
            .PropertyName = "fldCustomerName",
            .Operator = FilterOperator.Contains
        }
        dropdown.EditorControl.MasterTemplate.FilterDescriptors.Add(customerCode)

        dropdown.SelectedIndex = -1
        dropdown.Text = String.Empty

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

        Dim fldID As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldID)

        Dim fldDateReceived As New GridViewDateTimeColumn("DATE RECEIVED") With {
            .FieldName = "fldDateReceived",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldDateReceived)
        gridView.Columns("fldDateReceived").FormatString = "{0:MMM dd, yyyy}"

        Dim fldETACustomer As New GridViewDateTimeColumn("ETA CUSTOMER") With {
            .FieldName = "fldETACustomer",
            .MinWidth = 120,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy HH:mm",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETACustomer)
        gridView.Columns("fldETACustomer").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCustomer As New GridViewTextBoxColumn("CUST ID") With {
            .FieldName = "fldCustomerID",
            .MinWidth = 80,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldCustomer)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldCustomerName)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .MinWidth = 250,
            .TextAlignment = ContentAlignment.MiddleLeft,
            .IsVisible = True
        }
        gridView.Columns.Add(fldPartName)

        Dim fldPONo As New GridViewTextBoxColumn("PO NO") With {
            .FieldName = "fldPONo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldPONo)

        Dim fldModeOfShipment As New GridViewTextBoxColumn("MODE OF SHIPMENT") With {
            .FieldName = "fldModeOfShipment",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldModeOfShipment)

        Dim fldQtyPerBox As New GridViewTextBoxColumn("QTY PER BOX") With {
            .FieldName = "fldQtyPerBox",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gridView.Columns.Add(fldQtyPerBox)
        gridView.Columns("fldQtyPerBox").FormatString = "{0:N0}"

        Dim fldQtyPerPallet As New GridViewTextBoxColumn("QTY PER PALLET") With {
            .FieldName = "fldQtyPerPallet",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = True
        }
        gridView.Columns.Add(fldQtyPerPallet)
        gridView.Columns("fldQtyPerPallet").FormatString = "{0:N0}"

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
