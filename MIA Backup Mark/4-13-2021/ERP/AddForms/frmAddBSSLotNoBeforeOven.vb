Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class frmAddBSSLotNoBeforeOven
    Dim CheckMe As Int16
    Dim drCountme As DataRow = Nothing
    Private Sub FrmAddBSSLotNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        readRM()
        loadDropDown()
    End Sub

    Public Sub FetchMasterDataBeforeOven()
        mcbItemCode.SelectedIndex = -1
        CheckifExistRM()
    End Sub
    Private Sub CheckifExistRM()

        Slipknot.addParameter("RMID", txtRMID.Text)
        Dim dtCount As DataTable = Slipknot.dbSelect("SP_CountBSSRMLotNo")
        drCountme = dtCount.Rows(0)
        CheckMe = Convert.ToInt16(drCountme.Item("CountMe"))

        If (CheckMe >= 1) Then
            Slipknot.addParameter("RMID", txtRMID.Text)
            gvRm.DataSource = Slipknot.dbSelect("SP_SelectBSSRMandLotNobyRMID")
        Else
            gvRm.DataSource = Slipknot.dbSelect("SP_SelectItemMasterDataBeforeOven")
        End If

    End Sub
    Private Sub frmAddBSSLotNoBeforeOven_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        mcbItemCode.SelectedIndex = -1
        FetchMasterDataBeforeOven()
    End Sub
    Private Sub loadDropDown()

        ' Private Sub LoadItemCode()

        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim fldCompanyPartNo As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 160
        }
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldCompanyPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemCode.DataSource = dtProduct
        mcbItemCode.ValueMember = "fldPartName"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 360
        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCode.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)


    End Sub
    Private Sub readRM()

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code") With {
            .FieldName = "fldItemCode",
            .Width = 150,
            .ReadOnly = True
        }
        gvRm.Columns.Add(fldItemCode)

        Dim fldProcessName As New GridViewTextBoxColumn("Part Name") With {
            .FieldName = "fldPartName",
            .Width = 150,
            .ReadOnly = True
        }
        gvRm.Columns.Add(fldProcessName)

        Dim fldLotNo As New GridViewTextBoxColumn("Lot No") With {
            .FieldName = "fldLotNo",
            .Width = 200
        }
        gvRm.Columns.Add(fldLotNo)

        gvRm.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvRm.AllowAddNewRow = False
        gvRm.ShowFilteringRow = False
        gvRm.ShowGroupPanel = False
        gvRm.EnableSorting = False
        gvRm.AllowColumnReorder = False
        gvRm.AllowRowReorder = False

    End Sub

    Private Sub mcbItemCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemCode.SelectedIndexChanged
        If mcbItemCode.SelectedValue Is Nothing Then
            txtPartName.Text = Nothing
        Else
            txtPartName.Text = Convert.ToString(mcbItemCode.SelectedValue)
        End If
    End Sub

    Private Sub btnAddRM_Click(sender As Object, e As EventArgs) Handles btnAddRM.Click
        If mcbItemCode.SelectedIndex = -1 Then
            RadMessageBox.Show("Please select item code properly", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemCode.Select()
            Exit Sub
        End If
        If txtLotNo.Text = "" Then
            RadMessageBox.Show("Please input lot no properly", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txtLotNo.Select()
            Exit Sub
        End If
        If checkIfExist(Convert.ToString(mcbItemCode.Text)) Then
            gvRm.Rows.Add(Convert.ToString(mcbItemCode.Text), txtPartName.Text, txtLotNo.Text)
        Else
            RadMessageBox.Show("This Item code already exist", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemCode.Select()
        End If

    End Sub
    Private Function checkIfExist(ByVal code As String) As Boolean

        For Each row As GridViewRowInfo In gvRm.Rows

            If code = Convert.ToString(row.Cells("fldItemCode").Value) Then

                Return False
                Exit Function
            End If

        Next

        Return True
    End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (CheckMe >= 1) Then
            Slipknot.addParameter("RMID", Convert.ToString(txtRMID.Text))
            Slipknot.dbAED("SP_DeleteBSSRMandLotNobyRMID")

            If gvRm.Rows.Count > 0 Then
                For Each row As GridViewRowInfo In gvRm.Rows
                    Slipknot.addParameter("RMID", txtRMID.Text)
                    Slipknot.addParameter("itemCode", Convert.ToString(row.Cells("fldItemCode").Value).TrimStart.TrimStart)
                    Slipknot.addParameter("PartName", Convert.ToString(row.Cells("fldPartName").Value).TrimStart.TrimStart)
                    Slipknot.addParameter("LotNo", Convert.ToString(row.Cells("fldLotNo").Value).TrimStart.TrimStart)
                    Slipknot.dbAED("SP_InsertBSSRMandLotNoBeforeOven")
                Next
                RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        Else
            If gvRm.Rows.Count > 0 Then
                For Each row As GridViewRowInfo In gvRm.Rows
                    Slipknot.addParameter("RMID", txtRMID.Text)
                    Slipknot.addParameter("itemCode", Convert.ToString(row.Cells("fldItemCode").Value).TrimStart.TrimStart)
                    Slipknot.addParameter("PartName", Convert.ToString(row.Cells("fldPartName").Value).TrimStart.TrimStart)
                    Slipknot.addParameter("LotNo", Convert.ToString(row.Cells("fldLotNo").Value).TrimStart.TrimStart)
                    Slipknot.dbAED("SP_InsertBSSRMandLotNoBeforeOven")
                Next
                RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End If

    End Sub
End Class
