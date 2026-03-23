Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmMasterList
    Private myData As DataTable

    Private Sub FrmMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        Me.Size = New Size(380, Me.Owner.Height)
        Me.Location = New Point(Me.Owner.Location.X - Me.Width, Me.Owner.Location.Y)

        readyGrid()
    End Sub
    Private Sub readyGrid()

        Dim fldSelectColumn As New GridViewCheckBoxColumn(" ")
        fldSelectColumn.FieldName = "cb"
        fldSelectColumn.Name = "cb"
        fldSelectColumn.Width = 35
        fldSelectColumn.ReadOnly = False
        fldSelectColumn.IsVisible = True
        fldSelectColumn.IsPinned = True
        fldSelectColumn.PinPosition = PinnedColumnPosition.Left
        gvRecords.Columns.Add(fldSelectColumn)

        Dim fldIdColumn As New GridViewDecimalColumn("ID")
        fldIdColumn.FieldName = "fldId"
        fldIdColumn.IsVisible = False
        fldIdColumn.ReadOnly = True
        fldIdColumn.IsPinned = True
        fldIdColumn.PinPosition = PinnedColumnPosition.Left
        gvRecords.Columns.Add(fldIdColumn)

        Dim fldCustomerPartNoColumn As New GridViewTextBoxColumn("CUSTOMER PART NO.")
        fldCustomerPartNoColumn.FieldName = "fldCustomerPartNo"
        fldCustomerPartNoColumn.Width = 150
        fldCustomerPartNoColumn.ReadOnly = True
        fldCustomerPartNoColumn.IsPinned = True
        fldCustomerPartNoColumn.PinPosition = PinnedColumnPosition.Left
        gvRecords.Columns.Add(fldCustomerPartNoColumn)

        Dim fldPartnameColumn As New GridViewTextBoxColumn("PARTNAME")
        fldPartnameColumn.FieldName = "fldPartName"
        fldPartnameColumn.Width = 200
        fldPartnameColumn.ReadOnly = True
        gvRecords.Columns.Add(fldPartnameColumn)

        Dim fldFeapPartNoColumn As New GridViewTextBoxColumn("FEAP PART NO.")
        fldFeapPartNoColumn.FieldName = "fldItemCode"
        fldFeapPartNoColumn.Width = 110
        fldFeapPartNoColumn.ReadOnly = True
        gvRecords.Columns.Add(fldFeapPartNoColumn)

        Dim fldCustomerColumn As New GridViewTextBoxColumn("CUSTOMER")
        fldCustomerColumn.FieldName = "customer"
        fldCustomerColumn.Width = 90
        fldCustomerColumn.ReadOnly = True
        gvRecords.Columns.Add(fldCustomerColumn)

        Dim fldModelCodeColumn As New GridViewTextBoxColumn("MODEL CODE")
        fldModelCodeColumn.FieldName = "fldModelCode"
        fldModelCodeColumn.Width = 80
        fldModelCodeColumn.ReadOnly = True
        fldModelCodeColumn.IsVisible = False
        gvRecords.Columns.Add(fldModelCodeColumn)

        Dim fldCategoryColumn As New GridViewTextBoxColumn("CATEGORY")
        fldCategoryColumn.FieldName = "category"
        fldCategoryColumn.Width = 70
        fldCategoryColumn.ReadOnly = True
        fldCategoryColumn.IsVisible = False
        gvRecords.Columns.Add(fldCategoryColumn)

        Dim fldDefaultQtyColunm As New GridViewDecimalColumn("QTY")
        fldDefaultQtyColunm.FieldName = "fldDefaultQty"
        fldDefaultQtyColunm.Width = 50
        fldDefaultQtyColunm.ReadOnly = True
        fldDefaultQtyColunm.IsVisible = False
        gvRecords.Columns.Add(fldDefaultQtyColunm)

        Dim fldCategoryCodeColumn As New GridViewTextBoxColumn("CATEGORY CODE")
        fldCategoryCodeColumn.FieldName = "categoryCode"
        fldCategoryCodeColumn.IsVisible = False
        fldCategoryCodeColumn.ReadOnly = True
        fldCategoryCodeColumn.IsVisible = False
        gvRecords.Columns.Add(fldCategoryCodeColumn)

        Dim fldPartLevelColumn As New GridViewTextBoxColumn("PART LEVEL")
        fldPartLevelColumn.FieldName = "fldPartLevel"
        fldPartLevelColumn.ReadOnly = True
        fldPartLevelColumn.IsVisible = False
        gvRecords.Columns.Add(fldPartLevelColumn)

        Dim fldResidencyColumn As New GridViewTextBoxColumn("RESIDENCY")
        fldResidencyColumn.FieldName = "residencyCode"
        fldResidencyColumn.Width = 80
        fldResidencyColumn.ReadOnly = True
        fldResidencyColumn.IsVisible = False
        gvRecords.Columns.Add(fldResidencyColumn)

        gvRecords.SelectionMode = GridViewSelectionMode.FullRowSelect
        gvRecords.EnableFiltering = True
        gvRecords.ShowFilteringRow = False
        gvRecords.EnableGrouping = False
        gvRecords.ShowRowHeaderColumn = False
        gvRecords.AllowRowReorder = False
        gvRecords.MultiSelect = False
        gvRecords.ReadOnly = False
        gvRecords.AllowAddNewRow = False
        gvRecords.AllowRowResize = False
        gvRecords.AllowDeleteRow = False

    End Sub

    Private Sub bwLoadRecords_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadRecords.DoWork
        myData = Slipknot.dbSelectManual("SELECT " _
                                        & "T0.fldId, " _
                                        & "T0.fldCustomerPartNo, " _
                                        & "T0.fldItemCode, " _
                                        & "T1.fldPartName, " _
                                        & "(SELECT fldCustomerName FROM tblCustomer WHERE fldCustomerCode = T0.fldCustomerCode LIMIT 1) AS customer " _
                                        & "FROM " _
                                        & "tblItemMasterPerCustomer T0 " _
                                        & "LEFT JOIN tblItemMasterData T1 ON T0.fldItemCode = T1.fldItemCode " _
                                        & "ORDER BY T1.fldPartName ASC")
    End Sub

    Private Sub bwLoadRecords_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadRecords.RunWorkerCompleted
        gvRecords.DataSource = myData

    End Sub

    Private Sub FrmMasterList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadRecords.RunWorkerAsync()
        Me.Owner.Focus()
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        bwLoadRecords.RunWorkerAsync()
    End Sub
    Private Sub pick()
        If Me.Owner Is FrmAddLCS Then
            currentSelectedId = Convert.ToInt32(gvRecords.CurrentRow.Cells("fldId").Value)
            FrmAddLCS.cbbAddToList.PerformClick()
        End If
    End Sub
    Private Sub switch_adder()
        If Me.Owner Is FrmAddLCS Then
            FrmAddLCS.bwPickAdder.RunWorkerAsync()
        End If
    End Sub
    Private Sub gvRecords_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvRecords.FilterChanged
        leCountRec.Text = gvRecords.ChildRows.Count.ToString
    End Sub

    Private Sub gvRecords_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvRecords.RowsChanged
        leCountRec.Text = gvRecords.ChildRows.Count.ToString
    End Sub

    Private Sub miCurrentRow_Click(sender As Object, e As EventArgs) Handles miCurrentRow.Click
        pick()
    End Sub

    Private Sub cmiPickCurrentRow_Click(sender As Object, e As EventArgs) Handles cmiPickCurrentRow.Click
        pick()
    End Sub
    Private Sub miSelected_Click(sender As Object, e As EventArgs) Handles miSelected.Click
        pickSelected()
    End Sub
    Private Sub pickSelected()
        If Me.Owner Is FrmAddLCS Then
            With FrmAddLCS
                If .txtLotNo.Text = String.Empty Then
                    RadMessageBox.Show("Lot no should not be empty!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
                    Exit Sub
                End If
            End With
        End If

        dtPickedData.Rows.Clear()
        dtPickedData.Columns.Clear()
        dtPickedData.Columns.Add("ID")

        For x As Integer = 0 To gvRecords.ChildRows.Count - 1
            If Convert.ToBoolean(gvRecords.ChildRows(x).Cells("cb").Value) Then
                dtPickedData.Rows.Add(gvRecords.ChildRows(x).Cells("fldId").Value)
            End If
        Next

        switch_adder()
    End Sub

    Private Sub cmiPickSelected_Click(sender As Object, e As EventArgs) Handles cmiPickSelected.Click
        pickSelected()
    End Sub

    Private Sub miAll_Click(sender As Object, e As EventArgs) Handles miAll.Click
        If RadMessageBox.Show("Are you sure you want to add all " & gvRecords.ChildRows.Count & " records?", "LOT PRODUCER", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            pickAll()
        End If
    End Sub
    Private Sub pickAll()
        If Me.Owner Is FrmAddLCS Then
            With FrmAddLCS
                If .txtLotNo.Text = String.Empty Then
                    RadMessageBox.Show("Lot no should not be empty!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Error)
                    Exit Sub
                End If
            End With
        End If

        dtPickedData.Rows.Clear()
        dtPickedData.Columns.Clear()
        dtPickedData.Columns.Add("ID")

        For x As Integer = 0 To gvRecords.ChildRows.Count - 1
            dtPickedData.Rows.Add(gvRecords.ChildRows(x).Cells("fldId").Value)
        Next

        switch_adder()
    End Sub
    Private Sub cmiPickAll_Click(sender As Object, e As EventArgs) Handles cmiPickAll.Click
        If RadMessageBox.Show("Are you sure you want to add all " & gvRecords.ChildRows.Count & " records?", "LOT PRODUCER", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            pickAll()
        End If
    End Sub

End Class
