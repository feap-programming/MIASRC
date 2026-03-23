Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmGenProdInvOnHandSummaryRep

    Private BeginningInv As Decimal = 0
    Private Sub FrmGenProdInvOnHandSummaryRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        loadFrom()
        loadTo()
        loadItemCode()

        dtpLastDateOfInventory.Format = DateTimePickerFormat.Custom
        dtpLastDateOfInventory.CustomFormat = "MMM dd, yyyy"
        dtpLastDateOfInventory.Value = Today

        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "MMM dd, yyyy"
        dtpFrom.Value = Today

        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.CustomFormat = "MMM dd, yyyy"
        dtpTo.Value = Today

    End Sub

    Private Sub loadFrom()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllWarehouseCode")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldDescription", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 250
        mcbFrom.MultiColumnComboBoxElement.Columns.Add(fldDescription)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 100
        mcbFrom.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbFrom.DataSource = dt
        mcbFrom.ValueMember = "fldCode"
        mcbFrom.DisplayMember = "fldDescription"
        mcbFrom.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbFrom.AutoFilter = True
        mcbFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldDescription"
        desc.Operator = FilterOperator.Contains
        mcbFrom.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub

    Private Sub loadTo()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllWarehouseCode")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldDescription", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 250
        mcbTo.MultiColumnComboBoxElement.Columns.Add(fldDescription)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 100
        mcbTo.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbTo.DataSource = dt
        mcbTo.ValueMember = "fldCode"
        mcbTo.DisplayMember = "fldDescription"
        mcbTo.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbTo.AutoFilter = True
        mcbTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldDescription"
        desc.Operator = FilterOperator.Contains
        mcbTo.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub

    Private Sub loadItemCode()

        Dim dtItemCode As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 70
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 150
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemCode.DataSource = dtItemCode
        mcbItemCode.ValueMember = "fldItemCode"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCode.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        If mcbFrom.SelectedValue Is Nothing Then
            RadMessageBox.Show("Select warehouse code from properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbTo.SelectedValue Is Nothing Then
            RadMessageBox.Show("Select warehouse to properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Select item code properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        GetProdInventorySummary(mcbFrom.SelectedValue, mcbTo.SelectedValue, mcbItemCode.SelectedValue, dtpLastDateOfInventory.Value, dtpFrom.Value, dtpTo.Value)

        Slipknot.addReportParameter("parAddedBy", currentUser.Item("fldUsername"))
        Slipknot.addReportParameter("parItemCode", mcbItemCode.SelectedValue)
        Slipknot.addReportParameter("parPartname", mcbItemCode.EditorControl.CurrentRow.Cells("fldPartName").Value)
        Slipknot.addReportParameter("parWarehouseFrom", mcbFrom.Text)
        Slipknot.addReportParameter("parWarehouseTo", mcbTo.Text)
        Slipknot.addReportParameter("parLastInvDate", dtpLastDateOfInventory.Value)
        Slipknot.addReportParameter("parBegInv", BeginningInv)

        reportType = 9

        Dim frm As New FrmReport
        frm.Show()

    End Sub

    Private Sub GetProdInventorySummary(ByVal whseFrom As String, ByVal whseTo As String, ByVal itemCode As String, ByVal lastDateOfInventory As Date, ByVal dateFrom As Date, ByVal dateTo As Date)

        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
        Slipknot.dbAED("SP_DeleteOnHandStockRep")

        Dim getInventoryQty As DataRow = Slipknot.rowSelectManual("SELECT fldInventoryQty FROM tblWarehousing WHERE fldItemCode = '" & itemCode & "' AND DATE_FORMAT(fldInventoryDate, '%Y-%m-%d') = '" & lastDateOfInventory.ToString("yyyy-MM-dd") & "' ")

        If getInventoryQty IsNot Nothing Then
            BeginningInv = Convert.ToDecimal(getInventoryQty.Item("fldInventoryQty"))
        Else
            BeginningInv = 0
        End If

        Dim firstRec As Boolean = True

        Dim begOnHand As Decimal = 0

        Dim dtBOM As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode FROM tblBOMMaster WHERE fldChildCode = '" & itemCode & "' ")

        Do While dateFrom <= dateTo

            Dim transferedQty As Decimal = 0
            Dim sumTransferedQty As DataRow = Slipknot.rowSelectManual("SELECT SUM(fldTransferedQty) AS transferedQty FROM tblInventoryTransfer WHERE fldItemCode = '" & itemCode & "' AND fldFrom = '" & whseFrom & "' AND fldTo = '" & whseTo & "' AND DATE_FORMAT(fldDateAdded, '%Y-%m-%d') = '" & dateFrom.ToString("yyyy-MM-dd") & "' ")

            If Convert.ToString(sumTransferedQty.Item("transferedQty")) <> String.Empty Then
                transferedQty = Convert.ToDecimal(sumTransferedQty.Item("transferedQty"))
            End If

            Dim sumOutQty As Decimal = 0

            For Each row As DataRow In dtBOM.Rows
                Dim outputQty As Decimal = 0
                Dim parentCode As String = Convert.ToString(row.Item("fldParentCode"))

                Dim getInitParentCode As DataRow = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & parentCode & "' ")

                If getInitParentCode IsNot Nothing Then
                    parentCode = Convert.ToString(getInitParentCode.Item("fldItemCode"))
                End If

                Dim sumOutputQty As DataRow = Slipknot.rowSelectManual("SELECT SUM(fldQty) AS outputQty FROM tblProductionOutput WHERE fldPartNo = '" & parentCode & "' AND fldLocation = '" & whseTo & "' AND DATE_FORMAT(fldDateAdded, '%Y-%m-%d') = '" & dateFrom.ToString("yyyy-MM-dd") & "' ")

                If Convert.ToString(sumOutputQty.Item("outputQty")) <> String.Empty Then
                    sumOutQty = sumOutQty + Convert.ToDecimal(sumOutputQty.Item("outputQty"))
                End If

            Next

            If firstRec Then

                begOnHand = BeginningInv + transferedQty - sumOutQty

                firstRec = False
            Else
                begOnHand = begOnHand + transferedQty - sumOutQty
            End If

            For Each row As DataRow In dtBOM.Rows

                Dim outputQty As Decimal = 0
                Dim parentCode As String = Convert.ToString(row.Item("fldParentCode"))

                Dim getInitParentCode As DataRow = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & parentCode & "' ")

                If getInitParentCode IsNot Nothing Then
                    parentCode = Convert.ToString(getInitParentCode.Item("fldItemCode"))
                End If

                Dim sumOutputQty As DataRow = Slipknot.rowSelectManual("SELECT SUM(fldQty) AS outputQty FROM tblProductionOutput WHERE fldPartNo = '" & parentCode & "' AND fldLocation = '" & whseTo & "' AND DATE_FORMAT(fldDateAdded, '%Y-%m-%d') = '" & dateFrom.ToString("yyyy-MM-dd") & "' ")

                If Convert.ToString(sumOutputQty.Item("outputQty")) <> String.Empty Then
                    outputQty = Convert.ToDecimal(sumOutputQty.Item("outputQty"))
                End If

                Slipknot.addParameter("parDateAdded", dateFrom)
                Slipknot.addParameter("parParentCode", parentCode)
                Slipknot.addParameter("parTransferedQty", transferedQty)
                Slipknot.addParameter("parOutputQty", outputQty)
                Slipknot.addParameter("parSumOutputQty", sumOutQty)
                Slipknot.addParameter("parBegOnHand", begOnHand)
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
                Slipknot.dbAED("SP_InsertOnHandStockRep")

            Next

            dateFrom = dateFrom.AddDays(1)
        Loop

    End Sub

End Class
