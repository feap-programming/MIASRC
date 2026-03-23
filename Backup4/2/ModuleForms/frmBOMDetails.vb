Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmBOMDetails

    Private dtForms As DataTable
    Private dtItemCode As DataTable
    Private buttonClicker As Integer
    Private Sub FrmBOMDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGridForms()
        readyGridItemCode()
        loadItemCode()
    End Sub

    Private Sub readyGridForms()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        gvForms.Columns.Add(fldId)

        Dim fldFormName As New GridViewTextBoxColumn("FORM NAME")
        fldFormName.FieldName = "fldSubContentLabel"
        fldFormName.Width = 135
        gvForms.Columns.Add(fldFormName)

        Dim fldPageNo As New GridViewDecimalColumn("PAGE NO.")
        fldPageNo.FieldName = "fldPageNo"
        fldPageNo.Width = 70
        fldPageNo.Minimum = 1
        fldPageNo.ShowUpDownButtons = False
        gvForms.Columns.Add(fldPageNo)

        Dim fldCostruct As New GridViewCommandColumn("")
        fldCostruct.HeaderText = ""
        fldCostruct.FieldName = "fldConstruct"
        fldCostruct.DefaultText = "CONSTRUCT"
        fldCostruct.UseDefaultText = True
        fldCostruct.Width = 100
        fldCostruct.TextAlignment = ContentAlignment.MiddleCenter
        gvForms.Columns.Add(fldCostruct)

        Dim fldPutRemarks As New GridViewCommandColumn("")
        fldPutRemarks.HeaderText = ""
        fldPutRemarks.FieldName = "fldPutRemarks"
        fldPutRemarks.DefaultText = "PUT REMARKS"
        fldPutRemarks.UseDefaultText = True
        fldPutRemarks.Width = 110
        fldPutRemarks.TextAlignment = ContentAlignment.MiddleCenter
        gvForms.Columns.Add(fldPutRemarks)

        Dim fldView As New GridViewCommandColumn("")
        fldView.HeaderText = ""
        fldView.FieldName = "fldView"
        fldView.DefaultText = "VIEW"
        fldView.UseDefaultText = True
        fldView.Width = 65
        fldView.TextAlignment = ContentAlignment.MiddleCenter
        gvForms.Columns.Add(fldView)

        Dim fldDelete As New GridViewCommandColumn("")
        fldDelete.HeaderText = ""
        fldDelete.FieldName = "fldDelete"
        fldDelete.DefaultText = "DELETE"
        fldDelete.UseDefaultText = True
        fldDelete.Width = 75
        fldDelete.TextAlignment = ContentAlignment.MiddleCenter
        gvForms.Columns.Add(fldDelete)

        AddHandler gvForms.CommandCellClick, AddressOf buttonAction

        gvForms.AllowAddNewRow = False
        gvForms.AllowDeleteRow = False
        gvForms.EnableFiltering = True
        gvForms.ShowFilteringRow = False
        gvForms.ShowGroupPanel = False
        gvForms.MultiSelect = True

        gvForms.TableElement.RowHeight = 25

    End Sub

    Private Sub readyGridItemCode()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvItemCode.Columns.Add(fldId)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 130
        gvItemCode.Columns.Add(fldItemCode)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("CUSTOMER PART NO.")
        fldCustomerPartNo.FieldName = "fldCustomerPartNo"
        fldCustomerPartNo.Width = 150
        gvItemCode.Columns.Add(fldCustomerPartNo)

        Dim fldModelCode As New GridViewTextBoxColumn("MODEL CODE")
        fldModelCode.FieldName = "fldModelCode"
        fldModelCode.Width = 100
        gvItemCode.Columns.Add(fldModelCode)

        Dim fldDelete As New GridViewCommandColumn("")
        fldDelete.HeaderText = ""
        fldDelete.FieldName = "fldDelete"
        fldDelete.DefaultText = "DELETE"
        fldDelete.UseDefaultText = True
        fldDelete.Width = 75
        fldDelete.TextAlignment = ContentAlignment.MiddleCenter
        gvItemCode.Columns.Add(fldDelete)

        AddHandler gvItemCode.CommandCellClick, AddressOf deleteItemCode

        gvItemCode.ReadOnly = True
        gvItemCode.AllowAddNewRow = False
        gvItemCode.AllowDeleteRow = False
        gvItemCode.EnableFiltering = True
        gvItemCode.ShowFilteringRow = False
        gvItemCode.ShowGroupPanel = False
        gvItemCode.MultiSelect = True

        gvItemCode.TableElement.RowHeight = 25

    End Sub

    Private Sub buttonAction(ByVal sender As Object, ByVal e As EventArgs)

        If buttonClicker = 0 Then
            If RadMessageBox.Show("Are you you want to delete the selected record?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                Slipknot.addParameter("parIdArray", gvForms.CurrentRow.Cells("fldId").Value)

                If Slipknot.dbAED("SP_DeleteBOMSubContents") Then
                    bwLoadData.RunWorkerAsync()
                End If
            End If
        ElseIf buttonClicker = 1 Then

            If RadMessageBox.Show("WARNING! All the remarks that you have put on existing constracted report will be removed, are you sure you to contract BOM report?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                AsILayDyingTmp.constractItemBOM(txtId.Text, Convert.ToString(gvForms.CurrentRow.Cells("fldId").Value))

                RadMessageBox.Show("Operation Completed!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If

        ElseIf buttonClicker = 2 Then

            If gvForms.SelectedRows.Count > 0 Then

                Dim docNo As String = Nothing
                Dim title As String = Nothing
                Dim RefNo As String = Nothing
                Dim estDate As Date
                Dim revDate As Date
                Dim implemDate As Date
                Dim preparedBy As String = Nothing
                Dim checkedBy As String = Nothing
                Dim approvedBy As String = Nothing

                Dim dtItemBOM As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblItemBOM WHERE fldId = '" & txtId.Text & "' ")

                If dtItemBOM.Rows.Count > 0 Then

                    docNo = Convert.ToString(dtItemBOM.Rows(0).Item("fldDocumentNo"))
                    title = Convert.ToString(dtItemBOM.Rows(0).Item("fldTitle"))
                    RefNo = Convert.ToString(dtItemBOM.Rows(0).Item("fldReferenceNo"))
                    estDate = Convert.ToDateTime(dtItemBOM.Rows(0).Item("fldEstDate"))
                    revDate = Convert.ToDateTime(dtItemBOM.Rows(0).Item("fldRevDate"))
                    implemDate = Convert.ToDateTime(dtItemBOM.Rows(0).Item("fldImplemDate"))
                    preparedBy = Convert.ToString(dtItemBOM.Rows(0).Item("fldPreparedBy"))
                    checkedBy = Convert.ToString(dtItemBOM.Rows(0).Item("fldCheckedBy"))
                    approvedBy = Convert.ToString(dtItemBOM.Rows(0).Item("fldApprovedBy"))

                End If

                Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvForms.SelectedRows.Count - 1) {}

                gvForms.SelectedRows.CopyTo(rows, 0)

                For i As Integer = 0 To rows.Length - 1

                    Dim titleId As String = txtId.Text
                    Dim subContentId As String = Convert.ToString(rows(i).Cells("fldId").Value)

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
                    Dim dtBOMHeader As DataTable = Slipknot.dbSelect("SP_SelectBOMReportHeader")

                    Dim counter As Integer = 1

                    For Each rowH As DataRow In dtBOMHeader.Rows

                        Slipknot.addReportParameter("parFG" & counter, Convert.ToString(rowH.Item("fldItemCode")))
                        Slipknot.addReportParameter("parBC" & counter, Convert.ToString(rowH.Item("fldModelCode")))

                        counter = counter + 1

                    Next

                    Slipknot.addReportParameter("parTitleId", titleId)
                    Slipknot.addReportParameter("parSubContentId", subContentId)
                    Slipknot.addReportParameter("parAddedBy", currentUser.Item("fldUsername"))
                    Slipknot.addReportParameter("parDocNo", docNo)
                    Slipknot.addReportParameter("parTitle", title)
                    Slipknot.addReportParameter("parRefNo", RefNo)
                    Slipknot.addReportParameter("parEstDate", estDate)
                    Slipknot.addReportParameter("parRevDate", revDate)
                    Slipknot.addReportParameter("parImplemDate", implemDate)
                    Slipknot.addReportParameter("parPreparedBy", preparedBy)
                    Slipknot.addReportParameter("parCheckedBy", checkedBy)
                    Slipknot.addReportParameter("parApprovedBy", approvedBy)

                    reportType = 0

                    Dim frm As New FrmReport
                    frm.Show()

                Next

            End If
        Else
            If Slipknot.IsFormOpen(FrmBOMRemarks) Then
                FrmBOMRemarks.Focus()
            Else
                FrmBOMRemarks.txtTitleId.Text = txtId.Text
                FrmBOMRemarks.txtSubContentId.Text = gvForms.CurrentRow.Cells("fldId").Value
                FrmBOMRemarks.Show(Me)
            End If
        End If

    End Sub

    Private Sub deleteItemCode(ByVal sender As Object, ByVal e As EventArgs)

        If RadMessageBox.Show("Are you you want to delete the selected record?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Slipknot.addParameter("parIdArray", gvItemCode.CurrentRow.Cells("fldId").Value)

            If Slipknot.dbAED("SP_DeleteBOMContents") Then
                loadItemCodeRecord()
            End If
        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        Slipknot.addParameter("parTitleId", txtId.Text)
        dtForms = Slipknot.dbSelect("SP_SelectAllBOMSubContents")

        'dtItemCode = Slipknot.dbSelect("SP_SelectAllBOMContents")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvForms.DataSource = dtForms
        'gvItemCode.DataSource = dtItemCode
    End Sub

    Private Sub FrmBOMDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub gvForms_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvForms.RowsChanged
        leCountRecForm.Text = gvForms.ChildRows.Count.ToString

        If gvForms.Rows.Count > 0 Then
            lblItemCode.Enabled = True
            mcbItemCode.Enabled = True
            btnAddFG.Enabled = True
        Else
            lblItemCode.Enabled = False
            mcbItemCode.Enabled = False
            btnAddFG.Enabled = False

            gvItemCode.DataSource = Nothing
        End If
    End Sub

    Private Sub gvItemCode_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvItemCode.RowsChanged
        leCountRecFG.Text = gvItemCode.ChildRows.Count.ToString
    End Sub

    Private Sub loadItemCode()

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

    Private Sub loadItemCodeRecord()

        If gvForms.Rows.Count > 0 Then
            Slipknot.addParameter("parSubContentId", gvForms.CurrentRow.Cells("fldId").Value)
            dtItemCode = Slipknot.dbSelect("SP_SelectAllBOMContents")

            gvItemCode.DataSource = dtItemCode
        End If

    End Sub

    Private Sub btnAddForm_Click(sender As Object, e As EventArgs) Handles btnAddForm.Click
        If txtFormName.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Form name cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parBOMTitleId", txtId.Text)
        Slipknot.addParameter("parSubContentLabel", txtFormName.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPageNo", sePageNo.Value)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertBOMSubContent") Then
            txtFormName.Clear()
            bwLoadData.RunWorkerAsync()
        End If

    End Sub

    Private Sub btnAddFG_Click(sender As Object, e As EventArgs) Handles btnAddFG.Click
        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select item code properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parTitleId", txtId.Text)
        Slipknot.addParameter("parSubContentId", gvForms.CurrentRow.Cells("fldId").Value)
        Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
        Slipknot.addParameter("parCustomerPartNo", mcbItemCode.EditorControl.CurrentRow.Cells("fldCustomerPartNo").Value)
        Slipknot.addParameter("parModelCode", mcbItemCode.EditorControl.CurrentRow.Cells("fldModelCode").Value)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertBOMContents") Then
            loadItemCodeRecord()
        End If

    End Sub

    Private Sub gvForms_SelectionChanged(sender As Object, e As EventArgs) Handles gvForms.SelectionChanged
        loadItemCodeRecord()
    End Sub

    Dim contentLabelOrig As String
    Dim pageNoOrig As Integer

    Private Sub gvForms_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles gvForms.CellBeginEdit
        contentLabelOrig = Convert.ToString(gvForms.CurrentRow.Cells("fldSubContentLabel").Value)
        pageNoOrig = Convert.ToInt32(gvForms.CurrentRow.Cells("fldPageNo").Value)
    End Sub

    Private Sub gvForms_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvForms.CellEndEdit

        Dim id As String = Convert.ToString(gvForms.CurrentRow.Cells("fldId").Value)
        Dim contentLabel As String = Convert.ToString(gvForms.CurrentRow.Cells("fldSubContentLabel").Value)
        Dim pageNo As Integer = Convert.ToInt32(gvForms.CurrentRow.Cells("fldPageNo").Value)

        If contentLabel.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Form name cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            gvForms.CurrentRow.Cells("fldSubContentLabel").Value = contentLabelOrig

            Exit Sub
        End If

        Slipknot.addParameter("parId", id)
        Slipknot.addParameter("parContentLabel", contentLabel)
        Slipknot.addParameter("parPageNo", pageNo)

        If Slipknot.dbAED("SP_UpdateBOMSubContent") Then
        Else
            gvForms.CurrentRow.Cells("fldSubContentLabel").Value = contentLabelOrig
            gvForms.CurrentRow.Cells("fldPageNo").Value = pageNoOrig
        End If

    End Sub

    Private Sub gvForms_CellClick(sender As Object, e As GridViewCellEventArgs) Handles gvForms.CellClick
        If gvForms.CurrentColumn.FieldName = "fldDelete" Then
            buttonClicker = 0
        ElseIf gvForms.CurrentColumn.FieldName = "fldConstruct" Then
            buttonClicker = 1
        ElseIf gvForms.CurrentColumn.FieldName = "fldView" Then
            buttonClicker = 2
        Else
            buttonClicker = 3
        End If
    End Sub
End Class
