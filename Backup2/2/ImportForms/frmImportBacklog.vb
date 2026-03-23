Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmImportBacklog

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtItemMasterPerCustomer As DataTable
    Private dtItemMasterData As DataTable
    Private dtCustomer As DataTable

    Private linestat As String = String.Empty
    Private lineerror As String = String.Empty
    Private lineNo As Integer
    Private isItemExist As Boolean = True

    Private isPartNameNotExist As Boolean = True
    Private isCustomerNotExist As Boolean = True

    Private Sub FrmImportBacklog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        LoadCustomerDropDown(ddCustomerCode)

        SetUpColumns(gvData)

        dtEffectivityDate.Value = Now

    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click

        Try

            gvData.DataSource = Nothing

            Dim table As DataTable = Slipknot.getClipboard

            For Each row As DataRow In table.Rows
                Dim rowInfo As GridViewRowInfo = gvData.Rows.AddNew()
                rowInfo.Cells("fldEffectivityDate").Value = dtEffectivityDate.Value
                rowInfo.Cells("fldCustomerID").Value = ddCustomerCode.SelectedValue
                rowInfo.Cells("fldCustomer").Value = ddCustomerCode.Text
                rowInfo.Cells("fldPartName").Value = Trim(row(0))
                rowInfo.Cells("fldQuantity").Value = IIf(String.IsNullOrWhiteSpace(row(1)) Or (row(1) = "-"), 0, row(1))
                rowInfo.Cells("fldRemarks").Value = txtRemarks.Text
            Next

        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

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

            If Not String.IsNullOrWhiteSpace((gvData.Rows(counter).Cells("fldCustomer").Value)) AndAlso
                Not String.IsNullOrWhiteSpace((gvData.Rows(counter).Cells("fldPartName").Value)) AndAlso
                dtItemMasterPerCustomer.Select("customer = '" & Trim(gvData.Rows(counter).Cells("fldCustomer").Value) & "' AND " &
                                                "fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "'").Length > 0 Then

                linestat = "GOOD"
                lineerror = String.Empty

                isPartNameNotExist = False
                isCustomerNotExist = False

            Else

                linestat = "NG"
                lineerror = "Item not found in the master list."

                If String.IsNullOrWhiteSpace((gvData.Rows(counter).Cells("fldCustomer").Value)) Then
                    isCustomerNotExist = True
                    lineerror += Environment.NewLine & "Customer must not null or empty."
                ElseIf Not dtCustomer.Select("fldCustomerName = '" & Trim(gvData.Rows(counter).Cells("fldCustomer").Value) & "'").Length > 0 Then
                    isCustomerNotExist = True
                    lineerror += Environment.NewLine & "Anonymous Customer."
                ElseIf Not dtItemMasterPerCustomer.Select("customer = '" & Trim(gvData.Rows(counter).Cells("fldCustomer").Value) & "'").Length > 0 Then
                    isCustomerNotExist = True
                    lineerror += Environment.NewLine & "Customer not set to Item Master Per Customer"
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

            Dim percent As Double = counter / gvData.Rows.Count * 100
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

            Slipknot.addParameter("parCustomerID", gvData.Rows(counter).Cells("fldCustomerID").Value)
            Slipknot.addParameter("parEffectivityDate", gvData.Rows(counter).Cells("fldEffectivityDate").Value)
            Slipknot.addParameter("parPartName", gvData.Rows(counter).Cells("fldPartName").Value)
            Slipknot.addParameter("parQuantity", gvData.Rows(counter).Cells("fldQuantity").Value)
            Slipknot.addParameter("parRemarks", gvData.Rows(counter).Cells("fldRemarks").Value)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            If Slipknot.dbAED("SP_P_InsertBacklog") Then
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
            .FieldName = "fldCustomer",
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
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = True
        }
        gridView.Columns.Add(fldRemarks)

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
