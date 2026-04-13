Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmAddBOMContents

    Private isSubContent As Boolean = False
    Private dtSubContent As DataTable
    Private Sub FrmAddBOMContents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadBOMTitle()
        loadBOMSubContent()
        loadPartNo()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldStatus As New GridViewTextBoxColumn("STATUS")
        fldStatus.FieldName = "fldStatus"
        fldStatus.Width = 70
        fldStatus.TextAlignment = ContentAlignment.MiddleCenter
        gvData.Columns.Add(fldStatus)

        Dim fldTitleId As New GridViewTextBoxColumn("TITLE ID")
        fldTitleId.FieldName = "fldTitleId"
        fldTitleId.IsVisible = False
        gvData.Columns.Add(fldTitleId)

        Dim fldSubContentId As New GridViewTextBoxColumn("SUB CONTENT ID")
        fldSubContentId.FieldName = "fldSubContentId"
        fldSubContentId.IsVisible = False
        gvData.Columns.Add(fldSubContentId)

        Dim fldTitle As New GridViewTextBoxColumn("BOM TITLE")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 300
        gvData.Columns.Add(fldTitle)

        Dim fldSubContentLabel As New GridViewTextBoxColumn("SUB CONTENT LABEL")
        fldSubContentLabel.FieldName = "fldSubContentLabel"
        fldSubContentLabel.Width = 200
        gvData.Columns.Add(fldSubContentLabel)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 160
        gvData.Columns.Add(fldItemCode)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("CUSTOMER PART NO.")
        fldCustomerPartNo.FieldName = "fldCustomerPartNo"
        fldCustomerPartNo.Width = 160
        gvData.Columns.Add(fldCustomerPartNo)

        Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE")
        fldModelCode.FieldName = "fldModelCode"
        fldModelCode.Width = 150
        gvData.Columns.Add(fldModelCode)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub loadPartNo()

        Dim dtPartNo As DataTable = Slipknot.dbSelect("SP_SelectItemCodeWithCustomerPartNo")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 120
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 250
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("CUSTOMER PART NO.")
        fldCustomerPartNo.FieldName = "fldCustomerPartNo"
        fldCustomerPartNo.Width = 130
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldCustomerPartNo)

        Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE")
        fldModelCode.FieldName = "fldModelCode"
        fldModelCode.Width = 100
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldModelCode)

        mcbItemCode.DataSource = dtPartNo
        mcbItemCode.ValueMember = "fldItemCode"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 630

        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCode.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub

    Private Sub loadBOMTitle()

        Dim dtTitle As DataTable = Slipknot.dbSelect("SP_SelectAllItemBOMTitle")

        Dim fldTitle As New GridViewTextBoxColumn("BOM TITLE")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 300
        mcbBOMTitle.MultiColumnComboBoxElement.Columns.Add(fldTitle)

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        mcbBOMTitle.MultiColumnComboBoxElement.Columns.Add(fldId)

        mcbBOMTitle.DataSource = dtTitle
        mcbBOMTitle.DisplayMember = "fldTitle"
        mcbBOMTitle.ValueMember = "fldId"
        mcbBOMTitle.MultiColumnComboBoxElement.DropDownWidth = 350

        mcbBOMTitle.AutoFilter = True
        mcbBOMTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim title As New FilterDescriptor()
        title.PropertyName = "fldTitle"
        title.Operator = FilterOperator.Contains
        mcbBOMTitle.EditorControl.MasterTemplate.FilterDescriptors.Add(title)

    End Sub

    Private Sub loadBOMSubContent()

        Slipknot.addParameter("parId", mcbBOMTitle.SelectedValue)
        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectBOMSubContentByID")

        Dim fldSubContentLabel As New GridViewTextBoxColumn("SUB CONTENT")
        fldSubContentLabel.FieldName = "fldSubContentLabel"
        fldSubContentLabel.Width = 300
        mcbSubContent.MultiColumnComboBoxElement.Columns.Add(fldSubContentLabel)

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        mcbSubContent.MultiColumnComboBoxElement.Columns.Add(fldId)

        mcbSubContent.DataSource = dt
        mcbSubContent.DisplayMember = "fldSubContentLabel"
        mcbSubContent.ValueMember = "fldId"
        mcbSubContent.MultiColumnComboBoxElement.DropDownWidth = 350

        mcbSubContent.AutoFilter = True
        mcbSubContent.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim subContent As New FilterDescriptor()
        subContent.PropertyName = "fldSubContentLabel"
        subContent.Operator = FilterOperator.Contains
        mcbSubContent.EditorControl.MasterTemplate.FilterDescriptors.Add(subContent)

    End Sub

    Private Sub cbbAddTolist_Click(sender As Object, e As EventArgs) Handles cbbAddTolist.Click

        If mcbBOMTitle.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select BOM title properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbSubContent.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select sub content properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select company part no. properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Dim titleId As String = Convert.ToString(mcbBOMTitle.SelectedValue)
        Dim subContentId As String = Convert.ToString(mcbSubContent.SelectedValue)
        Dim title As String = Convert.ToString(mcbBOMTitle.EditorControl.CurrentRow.Cells("fldTitle").Value)
        Dim subContent As String = Convert.ToString(mcbSubContent.EditorControl.CurrentRow.Cells("fldSubContentLabel").Value)
        Dim itemCode As String = Convert.ToString(mcbItemCode.SelectedValue)
        Dim customerPartNo As String = Convert.ToString(mcbItemCode.EditorControl.CurrentRow.Cells("fldCustomerPartNo").Value)
        Dim modelCode As String = Convert.ToString(mcbItemCode.EditorControl.CurrentRow.Cells("fldModelCode").Value)

        If checkExisting() = False Then
            gvData.Rows.Add("", titleId, subContentId, title, subContent, itemCode, customerPartNo, modelCode)
        Else
            RadMessageBox.Show("Already exists in grid", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub cbbClear_Click(sender As Object, e As EventArgs) Handles cbbClear.Click
        If gvData.Rows.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to clear the list?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                gvData.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.Rows.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to delete " & gvData.SelectedRows.Count & " selected row(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}
                Me.gvData.SelectedRows.CopyTo(rows, 0)

                For i As Integer = 0 To rows.Length - 1
                    Me.gvData.Rows.Remove(rows(i))
                Next
            End If
        End If
    End Sub

    Private Sub FrmAddBOMContents_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.F3
                cbbSave.PerformClick()
            Case Keys.F7
                cbbDelete.PerformClick()
            Case Keys.F8
                cbbClear.PerformClick()
        End Select

        If (e.KeyCode = Keys.Enter AndAlso e.Control) Then
            cbbAddTolist.PerformClick()
        End If

    End Sub

    Function checkExisting() As Boolean

        Dim found As Boolean = False

        For Each row As GridViewRowInfo In gvData.Rows

            If Convert.ToString(row.Cells("fldTitleId").Value) = Convert.ToString(mcbBOMTitle.EditorControl.CurrentRow.Cells("fldId").Value) And Convert.ToString(mcbItemCode.SelectedValue) = Convert.ToString(row.Cells("fldItemCode").Value) Then
                found = True
            End If

        Next

        Return found

    End Function

    Private lineNo As Integer
    Private lineStat As String

    Private Sub bwSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwSave.DoWork

        Dim titleId As String
        Dim subContentId As String
        Dim itemCode As String
        Dim customerPartNo As String
        Dim modelCode As String

        For i As Integer = 0 To gvData.Rows.Count - 1

            titleId = Convert.ToString(gvData.Rows(i).Cells("fldTitleId").Value)
            subContentId = Convert.ToString(gvData.Rows(i).Cells("fldSubContentId").Value)
            itemCode = Convert.ToString(gvData.Rows(i).Cells("fldItemCode").Value)
            customerPartNo = Convert.ToString(gvData.Rows(i).Cells("fldCustomerPartNo").Value)
            modelCode = Convert.ToString(gvData.Rows(i).Cells("fldModelCode").Value)

            Slipknot.addParameter("parTitleId", titleId)
            Slipknot.addParameter("parSubContentId", subContentId)
            Slipknot.addParameter("parItemCode", itemCode)
            Slipknot.addParameter("parCustomerPartNo", customerPartNo)
            Slipknot.addParameter("parModelCode", modelCode)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            Dim success As Boolean = Slipknot.dbAED("SP_InsertBOMContents")

            If success Then
                lineStat = "OK"
            Else
                lineStat = "NG"
            End If

            Dim percent As Double = i / gvData.Rows.Count * 100
            lineNo = i
            RadProgressBarElement1.Text = "Saving..."
            bwSave.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)

        Next

    End Sub

    Private Sub bwSave_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwSave.ProgressChanged

        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = lineStat

        RadProgressBarElement1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub bwSave_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwSave.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting
        If (e.CellElement.ColumnInfo.Name = "fldStatus" And Convert.ToString(e.CellElement.RowInfo.Cells("fldStatus").Value) = "OK") Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.LimeGreen
            e.CellElement.Font = New Font("Arial", 10, FontStyle.Bold)
        ElseIf e.CellElement.ColumnInfo.Name = "fldStatus" And Convert.ToString(e.CellElement.RowInfo.Cells("fldStatus").Value) = "NG" Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.Red
            e.CellElement.Font = New Font("Arial", 10, FontStyle.Bold)
        Else
            e.CellElement.DrawFill = False
            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.White
        End If
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        bwSave.RunWorkerAsync()
    End Sub

    Private Sub mcbBOMTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbBOMTitle.SelectedIndexChanged
        If isSubContent Then
            Slipknot.addParameter("parId", mcbBOMTitle.SelectedValue)
            dtSubContent = Slipknot.dbSelect("SP_SelectBOMSubContentByID")

            mcbSubContent.DataSource = dtSubContent
        End If
    End Sub

    Private Sub FrmAddBOMContents_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        isSubContent = True
    End Sub
End Class
