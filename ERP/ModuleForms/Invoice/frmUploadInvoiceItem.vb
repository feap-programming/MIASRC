Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports System.ComponentModel

Public Class FrmUploadInvoiceItem

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtAllItemMasterPerCustomer As DataTable = myDB.SPSelect("SP_SelectAllItemMasterPerCustomer")
    Private dtAllPartNoHistory As DataTable = myDB.MyQuery("SELECT * FROM tblPartNoHistory")
    Private dtModel As DataTable
    Private dtCustomer As DataTable

    Private Property InvoiceID As Int64 = 0
    Private Property InvoiceNo As Int64 = 0
    Private Property Customer As String = String.Empty

    Private customerCode As String = String.Empty
    Private modelCode As String = String.Empty
    Public linestat As String = String.Empty
    Public lineerror As String = String.Empty
    Public lineNo As Integer
    Private hasError As Boolean = False

    Private Sub FrmUploadInvoiceItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        lblInvoiceNo.Text = InvoiceNo.ToString

        RemoveHandler ddlCustomerPartNo.SelectedIndexChanged, AddressOf ddlPartNo_SelectedIndexChanged
        LoadDropDown()
        AddHandler ddlCustomerPartNo.SelectedIndexChanged, AddressOf ddlPartNo_SelectedIndexChanged

        SetUpColumns()

    End Sub

    Private Sub ddlPartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCustomerPartNo.SelectedIndexChanged

        If ddlCustomerPartNo.SelectedIndex >= 0 Then

            Dim dtModel As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer")
            Dim dtPartNoHistory As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblPartNoHistory")
            Dim dtItems = (
                From T0 In dtModel.AsEnumerable
                Group Join T1 In dtPartNoHistory.AsEnumerable
                    On T0.Field(Of String)("fldItemCode") Equals T1.Field(Of String)("fldItemCode") And
                        T0.Field(Of String)("fldCustomerCode") Equals T1.Field(Of String)("fldCustomerCode")
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Select New With
                    {
                        Key .fldId = Convert.ToInt64(IIf(T1 IsNot Nothing, T1?.Field(Of Int64)("fldId"), 0)),
                        Key .fldCustomerPartNo = T0.Field(Of String)("fldCustomerPartNo"),
                        Key .fldItemCode = T0.Field(Of String)("fldItemCode"),
                        Key .fldNewItemCode = T1?.Field(Of String)("fldNewItemCode"),
                        Key .fldCustomerCode = T0.Field(Of String)("fldCustomerCode"),
                        Key .customer = T0.Field(Of String)("customer"),
                        Key .fldModelCode = T0.Field(Of String)("fldModelCode"),
                        Key .modelCode = T0.Field(Of String)("modelCode"),
                        Key .model = T0.Field(Of String)("model"),
                        Key .fldStdQty = T0.Field(Of Decimal)("fldStdQty"),
                        Key .fldPartLevel = T0.Field(Of String)("fldPartLevel"),
                        Key .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        Key .fldAddedBy = T0.Field(Of String)("fldAddedBy"),
                        Key .fldPartName = T0.Field(Of String)("fldPartName")
                    }
            ).ToList()

            Dim modelRow As DataRow() = ConvertToDatatable(dtItems).Select("fldId = " & ddlCustomerPartNo.SelectedValue & "")

            If modelRow.Count > 0 Then
                txtPartNo.Text = modelRow(0).Item("fldNewItemCode")
                txtPartName.Text = modelRow(0).Item("fldPartName")
                modelCode = modelRow(0).Item("modelCode")
                txtModel.Text = modelRow(0).Item("model")
                customerCode = modelRow(0).Item("fldCustomerCode")
            Else
                txtPartNo.Text = String.Empty
                txtPartName.Text = String.Empty
                modelCode = String.Empty
                txtModel.Text = String.Empty
                customerCode = String.Empty
            End If

        End If

    End Sub

    Private Sub cbbAddItem_Click(sender As Object, e As EventArgs) Handles cbbAddItem.Click

        Try

            Dim requiredField As String = String.Empty

            requiredField &= Environment.NewLine & IIf(String.IsNullOrWhiteSpace(ddlCustomerPartNo.SelectedValue), "Customer Part No.", "")
            requiredField &= Environment.NewLine & IIf(String.IsNullOrWhiteSpace(ddUnit.Text), "Unit", "")

            If String.IsNullOrWhiteSpace(requiredField) Then

                Dim rowInfo As New GridViewDataRowInfo(gvData.MasterView)
                rowInfo.Cells("fldReferenceNo").Value = txtReferenceNo.Text
                rowInfo.Cells("fldModelName").Value = txtModel.Text
                rowInfo.Cells("fldCustomerPartNo").Value = ddlCustomerPartNo.Text
                rowInfo.Cells("fldPartNo").Value = txtPartNo.Text
                rowInfo.Cells("fldPartName").Value = txtPartName.Text
                rowInfo.Cells("fldUnitPrice").Value = numUnitPrice.Value
                rowInfo.Cells("fldQuantity").Value = numQuantity.Value
                rowInfo.Cells("fldUnit").Value = ddUnit.Text
                gvData.Rows.Add(rowInfo)

            Else

                RadMessageBox.Show(Me, "Following field/s are required:" & Environment.NewLine & requiredField, "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            End If

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click

        Try

            gvData.DataSource = Nothing

            Dim table As DataTable = Slipknot.getClipboard

            Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                        Select New With
                                             {
                                               .fldReferenceNo = Regex.Replace(Trim(T0.Item(0)), "\s+", " "),
                                               .fldModelName = ModelRow(Regex.Replace(Trim(T0.Item(3)), "\s+", " "), Regex.Replace(Trim(T0.Item(2)), "\s+", " "), Customer),
                                               .fldCustomerPartNo = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
                                               .fldPartNo = Regex.Replace(Trim(T0.Item(2)), "\s+", " "),
                                               .fldPartName = Regex.Replace(Trim(T0.Item(3)), "\s+", " "),
                                               .fldUnitPrice = IIf(Not String.IsNullOrEmpty(T0.Item(4)), T0.Item(4), 0),
                                               .fldQuantity = IIf(Not String.IsNullOrEmpty(T0.Item(5)), T0.Item(5), 0),
                                               .fldUnit = Regex.Replace(Trim(T0.Item(6)), "\s+", " ")
                                             }).ToList
            gvData.DataSource = Query

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

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
            gvData.Rows.Clear()
        End If
    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click

        If gvData.Rows.Count > 0 Then

            If Not bwCheck.IsBusy Then
                bwCheck.RunWorkerAsync()
            End If

        Else

            RadMessageBox.Show(Me, "No data to import.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub bwCheck_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCheck.DoWork

        Dim delay As Integer = 30

        Dim dtItems = (
            From T0 In dtAllItemMasterPerCustomer.AsEnumerable
            Group Join T1 In dtAllPartNoHistory.AsEnumerable
                On T0.Field(Of String)("fldCustomerCode") Equals T1.Field(Of String)("fldCustomerCode") And
                    T0.Field(Of String)("fldItemCode") Equals T1.Field(Of String)("fldItemCode")
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Select New With
                {
                    Key .fldId = Convert.ToInt64(IIf(T1 IsNot Nothing, T1?.Field(Of Int64)("fldId"), 0)),
                    Key .fldCustomerPartNo = T0.Field(Of String)("fldCustomerPartNo"),
                    Key .fldItemCode = T0.Field(Of String)("fldItemCode"),
                    Key .fldNewItemCode = T1?.Field(Of String)("fldNewItemCode"),
                    Key .fldCustomerCode = T0.Field(Of String)("fldCustomerCode"),
                    Key .customer = T0.Field(Of String)("customer"),
                    Key .fldModelCode = T0.Field(Of String)("fldModelCode"),
                    Key .modelCode = T0.Field(Of String)("modelCode"),
                    Key .model = T0.Field(Of String)("model"),
                    Key .fldStdQty = T0.Field(Of Decimal)("fldStdQty"),
                    Key .fldPartLevel = T0.Field(Of String)("fldPartLevel"),
                    Key .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                    Key .fldAddedBy = T0.Field(Of String)("fldAddedBy"),
                    Key .fldPartName = T0.Field(Of String)("fldPartName")
                }
        ).ToList()

        For counter As Integer = 0 To gvData.Rows.Count - 1

            linestat = String.Empty
            lineerror = String.Empty

            'Console.WriteLine(Trim(gvData.Rows(counter).Cells("fldPartNo").Value))

            Try

                'Dim row As DataRow() = ConvertToDatatable(dtItems).Select("fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value & "' AND model = '" & Trim(gvData.Rows(counter).Cells("fldModelName").Value) & "' AND fldCustomerCode = '" & Trim(Customer) & "'"))
                'Dim row2 As DataRow() = dtAllItemMasterPerCustomer.Select("fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value & "' AND fldCustomerCode = '" & Trim(Customer) & "'"))

                If (Trim(gvData.Rows(counter).Cells("fldPartNo").Value).Substring(0, 2) = "FG") AndAlso
                    Not (ConvertToDatatable(dtItems).Select("fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value & "' AND model = '" & Trim(gvData.Rows(counter).Cells("fldModelName").Value) & "' AND fldCustomerCode = '" & Trim(Customer) & "'")).Length > 0) Then

                    linestat = "NG"
                    lineerror += "* Item not found in Item Master List / Item Code History."
                    hasError = True

                ElseIf (Trim(gvData.Rows(counter).Cells("fldPartNo").Value).Substring(0, 2) <> "FG") AndAlso
                    Not (dtAllItemMasterPerCustomer.Select("fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value & "' AND fldCustomerCode = '" & Trim(Customer) & "'")).Length > 0) Then

                    linestat = "NG"
                    lineerror += "* Item not found in Item Master per Customer."
                    hasError = True

                End If

                'If Not ConvertToDatatable(dtItems).Select("fldCustomerCode = '" & Trim(Customer) & "' AND model = '" & Trim(gvData.Rows(counter).Cells("fldModelName").Value) & "' AND " & '"fldCustomerPartNo = '" & Trim(gvData.Rows(counter).Cells("fldCustomerPartNo").Value) & "' AND " &
                '                                          "fldPartName = '" & Trim(gvData.Rows(counter).Cells("fldPartName").Value) & "'").Length > 0 Then

                '    linestat = "NG"
                '    lineerror += "* Item not found in the master list. "
                '    hasError = True

                'End If

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

                Dim percent As Double = ((counter + 1) / gvData.Rows.Count) * 100
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
                dtModel = myDB.SPSelect("SP_SelectAllModel")
                bwUpload.RunWorkerAsync()
            End If

        Else

            RadMessageBox.Show(Me, "There are items not found in the master list", "Item Not Found", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

        hasError = False

    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 30

        Dim modelRow As DataRow()
        Dim modelCode As String

        For counter As Integer = 0 To gvData.Rows.Count - 1

            modelRow = dtModel.Select("fldModelName = '" & gvData.Rows(counter).Cells("fldModelName").Value & "'")
            Try
                modelCode = modelRow(0).Item("fldCode")
            Catch ex As IndexOutOfRangeException
                modelCode = String.Empty
            End Try

            Slipknot.addParameter("parInvoiceID", InvoiceID)
            Slipknot.addParameter("parReferenceNo", Regex.Replace(Trim(gvData.Rows(counter).Cells("fldReferenceNo").Value), "\s+", " "))
            Slipknot.addParameter("parModel", Regex.Replace(Trim(modelCode), "\s+", " "))
            Slipknot.addParameter("parCustomerPartNo", Regex.Replace(Trim(gvData.Rows(counter).Cells("fldCustomerPartNo").Value), "\s+", " "))
            Slipknot.addParameter("parPartNo", Regex.Replace(Trim(gvData.Rows(counter).Cells("fldPartNo").Value), "\s+", " "))
            Slipknot.addParameter("parPartName", Regex.Replace(Trim(gvData.Rows(counter).Cells("fldPartName").Value), "\s+", " "))
            Slipknot.addParameter("parQuantity", gvData.Rows(counter).Cells("fldQuantity").Value)
            Slipknot.addParameter("parUnitPrice", gvData.Rows(counter).Cells("fldUnitPrice").Value)
            Slipknot.addParameter("parUnit", gvData.Rows(counter).Cells("fldUnit").Value)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            If Slipknot.dbAED("SP_P_InsertActual") Then
                linestat = "SAVING"
            Else
                linestat = "NG"
                Continue For
            End If

            linestat = "SAVED"

            Dim percent As Double = ((counter + 1) / gvData.Rows.Count) * 100
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

    Private Function ModelRow(parName As String, itemCode As String, customerCode As String) As String

        Dim dtItems = (
            From T0 In dtAllItemMasterPerCustomer.AsEnumerable
            Group Join T1 In dtAllPartNoHistory.AsEnumerable
                On T0.Field(Of String)("fldCustomerCode") Equals T1.Field(Of String)("fldCustomerCode") And
                    T0.Field(Of String)("fldItemCode") Equals T1.Field(Of String)("fldItemCode")
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Select New With
                {
                    Key .fldId = Convert.ToInt64(IIf(T1 IsNot Nothing, T1?.Field(Of Int64)("fldId"), 0)),
                    Key .fldCustomerPartNo = T0.Field(Of String)("fldCustomerPartNo"),
                    Key .fldItemCode = T0.Field(Of String)("fldItemCode"),
                    Key .fldNewItemCode = T1?.Field(Of String)("fldNewItemCode"),
                    Key .fldCustomerCode = T0.Field(Of String)("fldCustomerCode"),
                    Key .customer = T0.Field(Of String)("customer"),
                    Key .fldModelCode = T0.Field(Of String)("fldModelCode"),
                    Key .modelCode = T0.Field(Of String)("modelCode"),
                    Key .model = T0.Field(Of String)("model"),
                    Key .fldStdQty = T0.Field(Of Decimal)("fldStdQty"),
                    Key .fldPartLevel = T0.Field(Of String)("fldPartLevel"),
                    Key .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                    Key .fldAddedBy = T0.Field(Of String)("fldAddedBy"),
                    Key .fldPartName = T0.Field(Of String)("fldPartName")
                }
        ).ToList()

        'Dim row As DataRow() = ConvertToDatatable(dtItems).Select("fldCustomerPartNo = '" & customerPartNo & "' AND fldNewItemCode = '" & itemCode & "' AND fldCustomerCode = '" & customerCode & "'")
        Dim row As DataRow() = ConvertToDatatable(dtItems).Select("fldPartName = '" & parName & "' AND fldNewItemCode = '" & itemCode & "' AND fldCustomerCode = '" & customerCode & "'")
        Dim row2 As DataRow() = dtAllItemMasterPerCustomer.Select("fldPartName = '" & parName & "' AND fldItemCode = '" & itemCode & "' AND fldCustomerCode = '" & customerCode & "'")
        Dim model As String = String.Empty

        If (itemCode.Substring(0, 2) = "FG") AndAlso
            (row.Length > 0) Then

            model = row(0).Item("model")

        ElseIf (itemCode.Substring(0, 2) <> "FG") AndAlso
            (row2.Length > 0) Then

            If Not IsDBNull(row2(0).Item("model")) Then
                model = row2(0).Item("model")
            Else
                model = String.Empty
            End If

        Else

            model = String.Empty

        End If

        Return model

    End Function

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

    Public Overloads Sub ShowDialog(invoiceID As Int64, invoiceNo As Int64, customer As String)
        Me.InvoiceID = invoiceID
        Me.InvoiceNo = invoiceNo
        Me.Customer = customer
        Me.ShowDialog()
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

    Public Sub LoadDropDown()

        Dim fldId As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldId",
            .Width = 80,
            .IsVisible = False
        }
        ddlCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldId)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUST. CODE") With {
            .FieldName = "customer",
            .Width = 100
        }
        ddlCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim fldCustomerCode As New GridViewTextBoxColumn("PART NO") With {
            .FieldName = "fldCustomerPartNo",
            .Width = 100
        }
        ddlCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 100
        }
        ddlCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldNewItemCode As New GridViewTextBoxColumn("ANNEX") With {
            .FieldName = "fldNewItemCode",
            .Width = 100
        }
        ddlCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldNewItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
        ddlCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE") With {
            .FieldName = "modelCode",
            .Width = 100,
            .IsVisible = False
        }
        ddlCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldModelCode)

        Dim fldModelName As New GridViewTextBoxColumn("MODEL") With {
            .FieldName = "model",
            .Width = 100
        }
        ddlCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldModelName)

        Dim dtCustomer As DataTable = (
            From T0 In Slipknot.dbSelect("SP_SelectAllItemMasterPerCustomer").AsEnumerable
            Where T0.Field(Of String)("fldCustomerCode") = Me.Customer
            Select T0
        ).CopyToDataTable
        Dim dtPartNoHistory As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblPartNoHistory")
        Dim dtItems = (
                From T0 In dtCustomer.AsEnumerable
                Group Join T1 In dtPartNoHistory.AsEnumerable
                    On T0.Field(Of String)("fldCustomerCode") Equals T1.Field(Of String)("fldCustomerCode") And
                        T0.Field(Of String)("fldItemCode") Equals T1.Field(Of String)("fldItemCode")
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Select New With
                    {
                        Key .fldId = Convert.ToInt64(IIf(T1 IsNot Nothing, T1?.Field(Of Int64)("fldId"), 0)),
                        Key .fldCustomerPartNo = T0.Field(Of String)("fldCustomerPartNo"),
                        Key .fldItemCode = T0.Field(Of String)("fldItemCode"),
                        Key .fldNewItemCode = T1?.Field(Of String)("fldNewItemCode"),
                        Key .fldCustomerCode = T0.Field(Of String)("fldCustomerCode"),
                        Key .customer = T0.Field(Of String)("customer"),
                        Key .fldModelCode = T0.Field(Of String)("fldModelCode"),
                        Key .modelCode = T0.Field(Of String)("modelCode"),
                        Key .model = T0.Field(Of String)("model"),
                        Key .fldStdQty = T0.Field(Of Decimal)("fldStdQty"),
                        Key .fldPartLevel = T0.Field(Of String)("fldPartLevel"),
                        Key .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                        Key .fldAddedBy = T0.Field(Of String)("fldAddedBy"),
                        Key .fldPartName = T0.Field(Of String)("fldPartName")
                    }
            ).ToList()
        ddlCustomerPartNo.DataSource = ConvertToDatatable(dtItems)
        ddlCustomerPartNo.DisplayMember = "fldCustomerPartNo"
        ddlCustomerPartNo.ValueMember = "fldId"
        ddlCustomerPartNo.MultiColumnComboBoxElement.DropDownWidth = 450

        ddlCustomerPartNo.AutoFilter = True
        ddlCustomerPartNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerPartNo As New FilterDescriptor With {
            .PropertyName = "fldCustomerPartNo",
            .Operator = FilterOperator.Contains
        }
        ddlCustomerPartNo.EditorControl.MasterTemplate.FilterDescriptors.Add(customerPartNo)

        ddlCustomerPartNo.SelectedIndex = -1
        ddlCustomerPartNo.Text = String.Empty

    End Sub

    Private Sub SetUpColumns()

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS") With {
            .FieldName = "fldStatus",
            .MinWidth = 60,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsPinned = True,
            .PinPosition = PinnedColumnPosition.Left,
            .ReadOnly = True
        }
        gvData.Columns.Add(fldStatColumn)

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

        Dim fldErrorColumn As New GridViewTextBoxColumn("ERROR MESSAGE") With {
            .FieldName = "fldErrorMessage",
            .MinWidth = 200,
            .ReadOnly = True
        }
        gvData.Columns.Add(fldErrorColumn)

    End Sub

End Class
