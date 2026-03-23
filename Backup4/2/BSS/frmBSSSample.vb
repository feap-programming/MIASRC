Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmBSSSample
    Dim CheckMe As Int16
    Dim drCountme As DataRow = Nothing
    Private Sub FrmBSSSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        ReadyGridSample()
        loadDropDown()
        CheckifExistSample()
    End Sub

    Private Sub ReadyGridSample()


        Dim fldItemCode As New GridViewTextBoxColumn("Item Code") With {
            .FieldName = "fldItemCode",
            .Width = 150,
            .ReadOnly = True
        }
        gvSample.Columns.Add(fldItemCode)

        Dim fldProcessName As New GridViewTextBoxColumn("Part Name") With {
            .FieldName = "fldPartName",
            .Width = 150,
            .ReadOnly = True
        }
        gvSample.Columns.Add(fldProcessName)

        Dim fldSQty As New GridViewTextBoxColumn("Scrap QTY") With {
            .FieldName = "fldSQty",
            .Width = 130
        }
        gvSample.Columns.Add(fldSQty)

        Dim fldSQRemarks As New GridViewTextBoxColumn("SQRemarks") With {
            .FieldName = "fldSQRemarks",
            .Width = 200,
            .ReadOnly = False
        }
        gvSample.Columns.Add(fldSQRemarks)

        Dim fldQCSampleNormal As New GridViewTextBoxColumn("QA/QC Normal") With {
            .FieldName = "fldQCSampleNormal",
            .Width = 150
        }
        gvSample.Columns.Add(fldQCSampleNormal)

        Dim fldQCSNRemarks As New GridViewTextBoxColumn("QCSNRemarks") With {
            .FieldName = "fldQCSNRemarks",
            .Width = 200,
            .ReadOnly = False
        }
        gvSample.Columns.Add(fldQCSNRemarks)

        Dim fldQCSampleAdd As New GridViewTextBoxColumn("QA/QC Additional") With {
            .FieldName = "fldQCSampleAdd",
            .Width = 150
        }
        gvSample.Columns.Add(fldQCSampleAdd)

        Dim fldQCSARemarks As New GridViewTextBoxColumn("QCSARemarks") With {
            .FieldName = "fldQCSARemarks",
            .Width = 200,
            .ReadOnly = False
        }
        gvSample.Columns.Add(fldQCSARemarks)

        Dim fldEngSampleStrt As New GridViewTextBoxColumn("Engg Start/Setup") With {
          .FieldName = "fldEngSampleStrt",
          .Width = 130
        }
        gvSample.Columns.Add(fldEngSampleStrt)

        Dim fldEngSSRemarks As New GridViewTextBoxColumn("EngSSRemarks") With {
            .FieldName = "fldEngSSRemarks",
            .Width = 200,
            .ReadOnly = False
        }
        gvSample.Columns.Add(fldEngSSRemarks)

        Dim fldEngSampleAdj As New GridViewTextBoxColumn("Engg Adjustment") With {
            .FieldName = "fldEngSampleAdj",
            .Width = 130
        }
        gvSample.Columns.Add(fldEngSampleAdj)

        Dim fldRemarks As New GridViewTextBoxColumn("Remarks") With {
            .FieldName = "fldRemarks",
            .Width = 200,
            .ReadOnly = False
        }
        gvSample.Columns.Add(fldRemarks)

        Dim fldCategory As New GridViewTextBoxColumn("Category") With {
            .FieldName = "fldCategory",
            .Width = 150,
            .ReadOnly = True,
            .IsVisible = False
        }
        gvSample.Columns.Add(fldCategory)

        gvSample.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvSample.AllowAddNewRow = False
        gvSample.ShowFilteringRow = False
        gvSample.ShowGroupPanel = False
        gvSample.EnableSorting = False
        gvSample.AllowColumnReorder = False
        gvSample.AllowRowReorder = False
    End Sub

    Private Sub CheckifExistSample()
        Slipknot.addParameter("RMID", txtRMID.Text)
        Slipknot.addParameter("Category", FrmRMWorkProcess.mcbProcess.Text)
        Dim dtCount As DataTable = Slipknot.dbSelect("SP_CountBSSSamplebyRMIDCategory")
        drCountme = dtCount.Rows(0)
        CheckMe = Convert.ToInt16(drCountme.Item("CountMe"))

        If (CheckMe >= 1) Then
            Slipknot.addParameter("RMID", txtRMID.Text)
            Slipknot.addParameter("_Category", FrmRMWorkProcess.mcbProcess.Text)
            gvSample.DataSource = Slipknot.dbSelect("SP_SelectBSSSamplebyRMID")
        Else
            Slipknot.addParameter("ItemCode", FrmRMWorkProcess.txtItemCode.Text)
            Slipknot.addParameter("_Category", FrmRMWorkProcess.mcbProcess.Text)
            gvSample.DataSource = Slipknot.dbSelect("SP_SelectBSSTemplateBSSSample")
        End If
    End Sub

    Private Sub FrmBSSSample_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        mcbItemCode.SelectedIndex = -1
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

    Private Sub mcbItemCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemCode.SelectedIndexChanged
        If mcbItemCode.SelectedValue Is Nothing Then
            txtPartName.Text = Nothing
        Else
            txtPartName.Text = Convert.ToString(mcbItemCode.SelectedValue)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (CheckMe >= 1) Then
            Slipknot.addParameter("RMID", Convert.ToString(txtRMID.Text))
            Slipknot.dbAED("SP_DeleteFromBSSSamplebyRMID")
            SaveData()
            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            SaveData()
            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub
    Private Sub SaveData()
        If gvSample.Rows.Count > 0 Then
            For Each row As GridViewRowInfo In gvSample.Rows
                Slipknot.addParameter("RMID", txtRMID.Text)
                Slipknot.addParameter("ItemCode", Convert.ToString(row.Cells("fldItemCode").Value).TrimStart.TrimStart)
                Slipknot.addParameter("PartName", Convert.ToString(row.Cells("fldPartName").Value).TrimStart.TrimStart)
                Slipknot.addParameter("SQTY", Convert.ToString(row.Cells("fldSQTY").Value))
                Slipknot.addParameter("SQRemarks", Convert.ToString(row.Cells("fldSQRemarks").Value).TrimStart.TrimStart)
                Slipknot.addParameter("QCSampleNormal", Convert.ToString(row.Cells("fldQCSampleNormal").Value))
                Slipknot.addParameter("QCSNRemarks", Convert.ToString(row.Cells("fldQCSNRemarks").Value).TrimStart.TrimStart)
                Slipknot.addParameter("QCSampleAdd", Convert.ToString(row.Cells("fldQCSampleAdd").Value))
                Slipknot.addParameter("QCSARemarks", Convert.ToString(row.Cells("fldQCSARemarks").Value).TrimStart.TrimStart)
                Slipknot.addParameter("EngSampleStrt", Convert.ToString(row.Cells("fldEngSampleStrt").Value))
                Slipknot.addParameter("EngSSRemarks", Convert.ToString(row.Cells("fldEngSSRemarks").Value).TrimStart.TrimStart)
                Slipknot.addParameter("EngSampleAdj", Convert.ToString(row.Cells("fldEngSampleAdj").Value))
                Slipknot.addParameter("Remarks", Convert.ToString(row.Cells("fldRemarks").Value).TrimStart.TrimStart)
                Slipknot.addParameter("Category", Convert.ToString(row.Cells("fldCategory").Value).TrimStart.TrimStart)
                Slipknot.dbAED("SP_InsertBSSSamplev2")
            Next

        End If
    End Sub
End Class
