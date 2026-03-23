Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmImportItemMaster
    Private Sub FrmImportItemMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 220
        gvData.Columns.Add(fldPartName)

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 220
        gvData.Columns.Add(fldDescription)

        Dim fldCategory As New GridViewTextBoxColumn("CATEGORY")
        fldCategory.FieldName = "fldCategory"
        fldCategory.Width = 100
        gvData.Columns.Add(fldCategory)

        Dim fldSubCategory As New GridViewTextBoxColumn("SUB-CATEGORY")
        fldSubCategory.FieldName = "fldSubCategory"
        fldSubCategory.Width = 100
        gvData.Columns.Add(fldSubCategory)

        Dim fldUOM As New GridViewTextBoxColumn("UOM")
        fldUOM.FieldName = "fldUOM"
        fldUOM.Width = 90
        gvData.Columns.Add(fldUOM)

        Dim fldRegistrationNo As New GridViewTextBoxColumn("REGISTRATION NO.")
        fldRegistrationNo.FieldName = "fldRegistrationNo"
        fldRegistrationNo.Width = 140
        gvData.Columns.Add(fldRegistrationNo)

        Dim fldMaker As New GridViewTextBoxColumn("MAKER")
        fldMaker.FieldName = "fldMaker"
        fldMaker.Width = 140
        gvData.Columns.Add(fldMaker)

        Dim fldSellable As New GridViewCheckBoxColumn("SELLABLE")
        fldSellable.FieldName = "fldSellable"
        fldSellable.Width = 80
        gvData.Columns.Add(fldSellable)

        Dim fldInHouse As New GridViewCheckBoxColumn("IN HOUSE")
        fldInHouse.FieldName = "fldInHouse"
        fldInHouse.Width = 80
        gvData.Columns.Add(fldInHouse)

        Dim fldOutSide As New GridViewCheckBoxColumn("OUT SIDE")
        fldOutSide.FieldName = "fldOutSide"
        fldOutSide.Width = 80
        gvData.Columns.Add(fldOutSide)

        Dim fldOkCategory As New GridViewCheckBoxColumn("CATEGORY OK")
        fldOkCategory.FieldName = "fldOkCategory"
        fldOkCategory.Width = 100
        fldOkCategory.IsVisible = False
        gvData.Columns.Add(fldOkCategory)

        Dim fldOkUOM As New GridViewCheckBoxColumn("UOM OK")
        fldOkUOM.FieldName = "fldOkUOM"
        fldOkUOM.Width = 100
        fldOkUOM.IsVisible = False
        gvData.Columns.Add(fldOkUOM)

        Dim fldMakerCode As New GridViewTextBoxColumn("MAKER CODE")
        fldMakerCode.FieldName = "fldMakerCode"
        fldMakerCode.Width = 100
        fldMakerCode.IsVisible = False
        gvData.Columns.Add(fldMakerCode)

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
                                               .fldPartName = T0.Item(1),
                                               .fldDescription = T0.Item(2),
                                               .fldCategory = T0.Item(3),
                                               .fldSubCategory = T0.Item(4),
                                               .fldUOM = T0.Item(5),
                                               .fldRegistrationNo = T0.Item(6),
                                               .fldMaker = T0.Item(7),
                                               .fldSellable = T0.Item(8),
                                               .fldInHouse = T0.Item(9),
                                               .fldOutSide = T0.Item(10),
                                               .fldOkCategory = checkCategory(.fldCategory),
                                               .fldOkUOM = checkUOM(.fldUOM),
                                               .fldMakerCode = getMakerCode(.fldMaker),
                                               .STATUS = checkNG(.fldItemCode, .fldPartName, .fldOkCategory, .fldOkUOM, .fldMakerCode, .fldInHouse, .fldOutSide)
                                             }).ToList

            gvData.DataSource = joinResult

            countError()

        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Function checkCategory(ByVal categoryCode As String) As Boolean

        Dim getCode As DataRow = Slipknot.rowSelectManual("SELECT fldCategory FROM tblCategory WHERE fldCategory = '" & categoryCode & "' LIMIT 1")

        If getCode IsNot Nothing Then
            Return True

            Exit Function
        End If

        Return False
    End Function

    Function checkUOM(ByVal uom As String) As Boolean

        Dim getCode As DataRow = Slipknot.rowSelectManual("SELECT fldUOM FROM tblUOM WHERE fldUOM = '" & uom & "' LIMIT 1")

        If getCode IsNot Nothing Then
            Return True

            Exit Function
        End If

        Return False
    End Function

    Function getMakerCode(ByVal makerName As String) As String

        getMakerCode = String.Empty

        Dim getCode As DataRow = Slipknot.rowSelectManual("SELECT fldMakerCode FROM tblMaker WHERE fldMakerName = '" & makerName & "' LIMIT 1")

        If getCode IsNot Nothing Then
            getMakerCode = Convert.ToString(getCode.Item("fldMakerCode"))
        End If

        Return getMakerCode
    End Function

    Function checkNG(ByVal itemCode As String, ByVal partName As String, ByVal checkCat As Boolean, ByVal checkU As Boolean, ByVal maker As String, ByVal inHouse As Boolean, ByVal outSide As Boolean) As String

        If itemCode = String.Empty Or partName = String.Empty Or checkCat = False Or checkU = False Or maker = String.Empty Or (inHouse = False And outSide = False) Then
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

            If Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldOkCategory").Value) = False And Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldOkUOM").Value) = False And Convert.ToString(e.CellElement.RowInfo.Cells("fldMakerCode").Value).TrimStart.TrimEnd = String.Empty Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Category not found in list, UOM not found in list, Maker code not found in list"
            ElseIf Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldOkCategory").Value) = False And Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldOkUOM").Value) = False Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Category not found in list, UOM not found in list"
            ElseIf Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldOkCategory").Value) = False Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Category not found in list"
            ElseIf Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldOkUOM").Value) = False Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "UOM not found in list"
            ElseIf Convert.ToString(e.CellElement.RowInfo.Cells("fldMakerCode").Value).TrimStart.TrimEnd = String.Empty Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Maker code not found in list"
            ElseIf Convert.ToString(e.CellElement.RowInfo.Cells("fldItemCode").Value).TrimStart.TrimEnd = String.Empty Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Item code cannot be empty"
            ElseIf Convert.ToString(e.CellElement.RowInfo.Cells("fldPartName").Value).TrimStart.TrimEnd = String.Empty Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Partname cannot be empty"
            ElseIf Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldInHouse").Value) = False And Convert.ToBoolean(e.CellElement.RowInfo.Cells("fldOutSide").Value) = False Then
                e.CellElement.RowInfo.Cells("fldWarning").Value = "Please identify if the item is inhouse or outside"
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
        Dim partName As String
        Dim description As String
        Dim category As String
        Dim subCategory As String
        Dim uom As String
        Dim registrationNo As String
        Dim makerCode As String
        Dim sellable As Boolean
        Dim inHouse As Boolean
        Dim outSide As Boolean

        For counter As Integer = 0 To gvData.Rows.Count

            errorMessage = Nothing

            If Convert.ToString(gvData.Rows(counter).Cells("STATUS").Value) <> "NG" Then

                itemCode = Convert.ToString(gvData.Rows(counter).Cells("fldItemCode").Value)
                partName = Convert.ToString(gvData.Rows(counter).Cells("fldPartName").Value)
                description = Convert.ToString(gvData.Rows(counter).Cells("fldDescription").Value)
                category = Convert.ToString(gvData.Rows(counter).Cells("fldCategory").Value)
                subCategory = Convert.ToString(gvData.Rows(counter).Cells("fldSubCategory").Value)
                uom = Convert.ToString(gvData.Rows(counter).Cells("fldUOM").Value)
                registrationNo = Convert.ToString(gvData.Rows(counter).Cells("fldRegistrationNo").Value)
                makerCode = Convert.ToString(gvData.Rows(counter).Cells("fldMakerCode").Value)
                sellable = Convert.ToBoolean(gvData.Rows(counter).Cells("fldSellable").Value)
                inHouse = Convert.ToBoolean(gvData.Rows(counter).Cells("fldInHouse").Value)
                outSide = Convert.ToBoolean(gvData.Rows(counter).Cells("fldOutSide").Value)

                Slipknot.addParameter("parItemCode", itemCode.TrimStart.TrimEnd)
                Slipknot.addParameter("parPartname", partName.TrimStart.TrimEnd)
                Slipknot.addParameter("parDescription", description.TrimStart.TrimEnd)
                Slipknot.addParameter("parCategory", category.TrimStart.TrimEnd)
                Slipknot.addParameter("parSubCategory", subCategory.TrimStart.TrimEnd)
                Slipknot.addParameter("parUOM", uom.TrimStart.TrimEnd)

                If registrationNo.TrimStart.TrimEnd = String.Empty Then
                    Slipknot.addParameter("parRegistrationNo", DBNull.Value)
                Else
                    Slipknot.addParameter("parRegistrationNo", registrationNo.TrimStart.TrimEnd)
                End If

                Slipknot.addParameter("parMakerCode", makerCode.TrimStart.TrimEnd)
                Slipknot.addParameter("parSellable", sellable)
                Slipknot.addParameter("parInHouse", inHouse)
                Slipknot.addParameter("parOutSide", outSide)
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                If Slipknot.dbAED("SP_InsertItemMasterData") Then
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
