Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class frmImportCountingReference
    Private Sub frmImportInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        fldStatColumn.FieldName = "STATUS"
        fldStatColumn.Width = 60
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.ReadOnly = True
        fldStatColumn.IsPinned = True
        fldStatColumn.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldStatColumn)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 150
        gvData.Columns.Add(fldItemCode)

        Dim fldWarehouseName As New GridViewTextBoxColumn("WAREHOUSE NAME")
        fldWarehouseName.FieldName = "fldWarehouseName"
        fldWarehouseName.Width = 200
        gvData.Columns.Add(fldWarehouseName)

        Dim fldQuantity As New GridViewDecimalColumn("QUANTITY")
        fldQuantity.FieldName = "fldQuantity"
        fldQuantity.Width = 120
        gvData.Columns.Add(fldQuantity)
        gvData.Columns("fldQuantity").FormatString = "{0:N2}"

        Dim fldCountingDate As New GridViewDateTimeColumn("COUNTING DATE")
        fldCountingDate.FieldName = "fldCountingDate"
        fldCountingDate.Width = 170
        fldCountingDate.Format = DateTimePickerFormat.Custom
        fldCountingDate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldCountingDate)
        gvData.Columns("fldCountingDate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldItemCodeOk As New GridViewCheckBoxColumn("ITEM CODE OK")
        fldItemCodeOk.FieldName = "fldItemCodeOk"
        fldItemCodeOk.Width = 100
        fldItemCodeOk.IsVisible = False
        gvData.Columns.Add(fldItemCodeOk)

        Dim fldWarehouseCode As New GridViewTextBoxColumn("WAREHOUSE CODE")
        fldWarehouseCode.FieldName = "fldWarehouseCode"
        fldWarehouseCode.Width = 130
        fldWarehouseCode.IsVisible = False
        gvData.Columns.Add(fldWarehouseCode)

        Dim fldWarningColumn As New GridViewTextBoxColumn("WARNING")
        fldWarningColumn.FieldName = "fldWarning"
        fldWarningColumn.Width = 120
        fldWarningColumn.ReadOnly = True
        gvData.Columns.Add(fldWarningColumn)

        gvData.ReadOnly = True
        gvData.EnableSorting = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False
        gvData.AllowAddNewRow = False
        gvData.ShowFilteringRow = False
        gvData.EnableFiltering = False
        gvData.EnableGrouping = False
        gvData.ShowGroupPanel = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False
        gvData.ShowRowHeaderColumn = False
        gvData.AllowAutoSizeColumns = True
        gvData.MultiSelect = True
        gvData.AllowDeleteRow = True

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click

        Try

            gvData.DataSource = Nothing

            Dim table As DataTable = Slipknot.getClipboard

            Dim joinResult As IEnumerable = (From T0 In table.AsEnumerable()
                                             Select New With
                                             {
                                               .fldItemCode = T0.Item(0),
                                               .fldWarehouseName = T0.Item(1),
                                               .fldQuantity = T0.Item(2),
                                               .fldCountingDate = T0.Item(3),
                                               .fldItemCodeOk = checkItemCode(.fldItemCode),
                                               .fldWarehouseCode = getWarehouseCode(.fldWarehouseName),
                                               .STATUS = checkNG(.fldItemCodeOk, .fldWarehouseCode)
                                             }).ToList

            gvData.DataSource = joinResult

            countError()

        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Function checkItemCode(ByVal itemCode As String) As Boolean

        Dim getCode As DataRow = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblItemMasterData WHERE fldItemCode = '" & itemCode & "' LIMIT 1")

        If getCode IsNot Nothing Then
            Return True

            Exit Function
        End If

        Return False
    End Function

    Function getWarehouseCode(ByVal warehouseName As String) As String

        getWarehouseCode = String.Empty

        Dim getCode As DataRow = Slipknot.rowSelectManual("SELECT fldCode FROM tblWarehouseCode WHERE fldDescription = '" & warehouseName & "' LIMIT 1")

        If getCode IsNot Nothing Then
            getWarehouseCode = Convert.ToString(getCode.Item("fldCode"))
        End If

        Return getWarehouseCode
    End Function

    Function checkNG(ByVal itemCodeOk As Boolean, ByVal warehouseCode As String) As String

        If itemCodeOk = False Or warehouseCode = String.Empty Then
            Return "NG"

            Exit Function
        End If

        Return String.Empty

    End Function

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you want to delete " & gvData.SelectedRows.Count & " selected row(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}
            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1
                Me.gvData.Rows.Remove(rows(i))
            Next

            countError()
        End If
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click
        If RadMessageBox.Show("Are you sure you want to clear the list?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            gvData.DataSource = Nothing

            countError()
        End If
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting

        If (e.CellElement.ColumnInfo.Name = "STATUS" And Convert.ToString(e.CellElement.RowInfo.Cells("STATUS").Value) = "OK") Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.BackColor = Color.LimeGreen
            e.CellElement.Font = New Font("Arial", 10, FontStyle.Bold)
        ElseIf e.CellElement.ColumnInfo.Name = "STATUS" And Convert.ToString(e.CellElement.RowInfo.Cells("STATUS").Value) = "NG" Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.BackColor = Color.Red
            e.CellElement.Font = New Font("Arial", 10, FontStyle.Bold)
        Else
            e.CellElement.DrawFill = False
            e.CellElement.BackColor = Color.White

            If Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldItemCodeOk").Value) = False And Convert.ToString(e.CellElement.RowInfo.Cells("fldWarehouseCode").Value).TrimStart.TrimEnd = String.Empty Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Item code not found in list, Warehouse code not found in list"
            ElseIf Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldItemCodeOk").Value) = False Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Item code not found in list"
            ElseIf Convert.ToString(e.CellElement.RowInfo.Cells("fldWarehouseCode").Value).TrimStart.TrimEnd = String.Empty Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Warehouse code not found in list"
            Else
                If Convert.ToString(e.CellElement.RowInfo.Cells("STATUS").Value) = "OK" And Convert.ToString(e.CellElement.RowInfo.Cells("STATUS").Value) = String.Empty Then
                    e.CellElement.RowInfo.Cells("fldWarning").Value = String.Empty
                End If
            End If

        End If

    End Sub

    Private lineNo As Integer
    Private lineStat As String
    Private Sub bwSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwSave.DoWork
        aedType = 1

        Dim itemCode As String
        Dim warehouseCode As String
        Dim qty As Decimal
        Dim countingDate As DateTime

        For counter As Integer = 0 To gvData.Rows.Count

            errorMessage = Nothing

            If Convert.ToString(gvData.Rows(counter).Cells("STATUS").Value) <> "NG" Then

                warehouseCode = Convert.ToString(gvData.Rows(counter).Cells("fldWarehouseCode").Value)
                itemCode = Convert.ToString(gvData.Rows(counter).Cells("fldItemCode").Value)
                qty = Convert.ToDecimal(gvData.Rows(counter).Cells("fldQuantity").Value)
                countingDate = Convert.ToDateTime(gvData.Rows(counter).Cells("fldCountingDate").Value)

                Slipknot.addParameter("parWarehouseCode", warehouseCode)
                Slipknot.addParameter("parItemCode", itemCode.TrimStart.TrimEnd)
                Slipknot.addParameter("parQuantity", qty)
                Slipknot.addParameter("parCountingDate", countingDate)
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                If Slipknot.dbAED("SP_InsertCountingReference") Then
                    lineStat = "OK"
                Else
                    lineStat = "NG"
                End If

            Else
                lineStat = "NG"
            End If

            Dim percent As Double = counter / gvData.Rows.Count * 100
            lineNo = counter
            RadProgressBarElement1.Text = "Saving..."
            bwSave.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(50)

        Next

    End Sub

    Private Sub bwSave_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwSave.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = lineStat
        gvData.CurrentRow.Cells("fldWarning").Value = errorMessage

        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwSave_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwSave.RunWorkerCompleted
        RadProgressBarElement1.Value1 = 100
        RadProgressBarElement1.Text = "Done"

        countError()
    End Sub

    Private Sub countError()

        lblError.Text = String.Empty

        Dim err As Integer = 0

        For Each row As GridViewRowInfo In gvData.Rows
            If Convert.ToString(row.Cells("STATUS").Value) = "NG" Then
                err = err + 1
            End If
        Next

        If err > 0 Then
            lblError.Text = "There are " & err & " error(s) in grid, fixing is recommended before you proceed"
        End If

    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click
        If bwSave.IsBusy = False Then
            If RadMessageBox.Show("Are you sure want to upload the data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                bwSave.RunWorkerAsync()
            End If
        End If
    End Sub
End Class
