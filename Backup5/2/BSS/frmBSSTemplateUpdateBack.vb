Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmBSSTemplateUpdateBack
    Private Sub FrmBSSTemplateUpdateBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
    End Sub
    Private Sub loadItemMasterForPartNameBack()
        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")
        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE") With {
            .FieldName = "fldItemCode",
            .Width = 160
        }
        mcbItemSub.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME") With {
            .FieldName = "fldPartName",
            .Width = 200
        }
        mcbItemSub.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemSub.DataSource = dtProduct
        mcbItemSub.ValueMember = "fldPartName"
        mcbItemSub.DisplayMember = "fldItemCode"
        mcbItemSub.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbItemSub.AutoFilter = True
        mcbItemSub.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemSub.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub

    Private Sub FrmBSSTemplateUpdateBack_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadItemMasterForPartNameBack()
        mcbItemSub.Text = globalVariables.BSSItemSub

    End Sub

    Private Sub mcbItemSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemSub.SelectedIndexChanged
        txtPartNameSub.Text = mcbItemSub.SelectedValue
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'If mcbItemCodeBack.SelectedValue Is Nothing Then
        '    RadMessageBox.Show("Item Code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        '    mcbItemCodeBack.Select()
        '    Exit Sub
        'End If
        If mcbItemSub.SelectedValue Is Nothing Then
            RadMessageBox.Show("Part Name cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemSub.Select()
            Exit Sub
        End If

        Dim Solder As String
        Dim PCB As String
        Dim ParamRobot As String
        If chSS.Checked Then
            Solder = "YES"
        Else
            Solder = "NO"
        End If
        If chPCB.Checked Then
            PCB = "YES"
        Else
            PCB = "NO"
        End If
        If cbRobot.Checked Then
            ParamRobot = "YES"
        Else
            ParamRobot = "NO"
        End If

        Slipknot.addParameter("BBID", Convert.ToString(txtBBID.Text))
        Slipknot.addParameter("ItemCodeSub", Convert.ToString(mcbItemSub.Text))
        Slipknot.addParameter("PartNameSub", Convert.ToString(txtPartNameSub.Text))
        Slipknot.addParameter("SolderAss", Solder)
        Slipknot.addParameter("PCB", PCB)
        Slipknot.addParameter("Robot", ParamRobot)

        Slipknot.dbAED("SP_UpdateBSSTemplateBack")
        RadMessageBox.Show("Successfully Saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        FrmBSSTemplate.FetchData()
    End Sub
End Class
