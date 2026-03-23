Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmAddBSSLotNoAfterOven
    Dim CheckMe As Int16
    Dim drCountme As DataRow = Nothing
    Private Sub FrmAddBSSLotNoAfterOven_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        dtpValidityDate.Format = DateTimePickerFormat.Custom
        dtpValidityDate.CustomFormat = "MMM dd, yyyy"
        dtpValidityDate.Value = Today

        dtpRobotDate.Format = DateTimePickerFormat.Custom
        dtpRobotDate.CustomFormat = "MMM dd, yyyy"
        dtpRobotDate.Value = Today

        dtpRobotDate2.Format = DateTimePickerFormat.Custom
        dtpRobotDate2.CustomFormat = "MMM dd, yyyy"
        dtpRobotDate2.Value = Today

        readRM()
        readRobot()
        loadDropDown()
    End Sub

    Private Sub FrmAddBSSLotNoAfterOven_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
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

            Slipknot.addParameter("RMID", txtRMID.Text)
            gvRobot.DataSource = Slipknot.dbSelect("SP_SelectBSSRobotDatabyRMID")
        Else
            Slipknot.addParameter("ItemCode", FrmRMWorkProcess.txtItemCode.Text)
            gvRm.DataSource = Slipknot.dbSelect("SP_SelectBSSTemplateRMWProcess")
        End If

    End Sub
    Public Sub FetchMasterDataAfterOven()
        'gvRm.DataSource = Slipknot.dbSelect("SP_SelectItemMasterDataAfterOven")
        Dim DTSelect As DataTable = Slipknot.dbSelect("SP_SelectItemMasterDataAfterOven")
        Dim dtQuery = (From i In DTSelect.AsEnumerable()
                       Let _SetSolder = SetSolder(Convert.ToString(i("fldItemCode")))
                       Let _SetPCB = SetPCB(Convert.ToString(i("fldItemCode")))
                       Select New With
                           {
                                    .fldItemCode = i("fldItemCode"),
                                    .fldPartName = i("fldPartName"),
                                    .fldSolderAss = _SetSolder,
                                    .fldPCB = _SetPCB,
                                    .fldPCBValidityDate = DateTime.Today
                            })
        gvRm.DataSource = dtQuery
    End Sub
    Public Function SetSolder(ByVal ItemCode As String)
        If ItemCode = "RM1608" Or ItemCode = "WP2779" Or ItemCode = "RM2334" Or ItemCode = "WP2767" Then
            Return "YES"
        Else
            Return "NO"
        End If
    End Function
    Public Function SetPCB(ByVal ItemCode As String)
        If ItemCode = "WP2781" Then
            Return "YES"
        Else
            Return "NO"
        End If
    End Function

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
    Private Sub readRobot()
        Dim fldItemCode As New GridViewTextBoxColumn("Item Code") With {
            .FieldName = "fldItemCode",
            .Width = 150,
            .ReadOnly = True
        }
        gvRobot.Columns.Add(fldItemCode)

        Dim fldRobot As New GridViewTextBoxColumn("Robot1") With {
            .FieldName = "fldRobot",
            .Width = 150
        }
        gvRobot.Columns.Add(fldRobot)

        Dim fldValidityDate As New GridViewDateTimeColumn("Validity Date") With {
            .FieldName = "fldValidityDate",
            .Width = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy"
        }
        gvRobot.Columns.Add(fldValidityDate)
        gvRobot.Columns("fldValidityDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRobot2 As New GridViewTextBoxColumn("Robot2") With {
            .FieldName = "fldRobot2",
            .Width = 150
        }
        gvRobot.Columns.Add(fldRobot2)

        Dim fldValidityDate2 As New GridViewDateTimeColumn("Validity Date") With {
            .FieldName = "fldValidityDate2",
            .Width = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy"
        }
        gvRobot.Columns.Add(fldValidityDate2)
        gvRobot.Columns("fldValidityDate2").FormatString = "{0:MMM dd, yyyy}"


        gvRobot.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvRobot.AllowAddNewRow = False
        gvRobot.ShowFilteringRow = False
        gvRobot.ShowGroupPanel = False
        gvRobot.EnableSorting = False
        gvRobot.AllowColumnReorder = False
        gvRobot.AllowRowReorder = False

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

        Dim fldSolderAss As New GridViewComboBoxColumn("Solder") With {
            .FieldName = "fldSolderAss",
            .Width = 150,
            .DropDownStyle = RadDropDownStyle.DropDownList,
            .DataSource = New [String]() {"YES", "NO"}
        }
        gvRm.Columns.Add(fldSolderAss)

        Dim fldPCB As New GridViewComboBoxColumn("PCB") With {
            .FieldName = "fldPCB",
            .Width = 150,
            .DropDownStyle = RadDropDownStyle.DropDownList,
            .DataSource = New [String]() {"YES", "NO"}
        }
        gvRm.Columns.Add(fldPCB)

        Dim fldPCBValidityDate As New GridViewDateTimeColumn("Validity Date") With {
            .FieldName = "fldPCBValidityDate",
            .Width = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy"
        }
        gvRm.Columns.Add(fldPCBValidityDate)
        gvRm.Columns("fldPCBValidityDate").FormatString = "{0:MMM dd, yyyy}"

        gvRm.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvRm.AllowAddNewRow = False
        gvRm.ShowFilteringRow = False
        gvRm.ShowGroupPanel = False
        gvRm.EnableSorting = False
        gvRm.AllowColumnReorder = False
        gvRm.AllowRowReorder = False

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
            Dim Solder As String
            Dim PCB As String
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

            gvRm.Rows.Add(Convert.ToString(mcbItemCode.Text), txtPartName.Text, txtLotNo.Text, Solder, PCB, dtpValidityDate.Value)
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

            Slipknot.addParameter("RMID", Convert.ToString(txtRMID.Text))
            Slipknot.dbAED("SP_DeleteBSSRobotDatabyRMID")

            SaveData()
            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            SaveData()
            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub
    Private Sub SaveData()
        If gvRm.Rows.Count > 0 Then
            For Each row As GridViewRowInfo In gvRm.Rows
                Slipknot.addParameter("RMID", txtRMID.Text)
                Slipknot.addParameter("itemCode", Convert.ToString(row.Cells("fldItemCode").Value).TrimStart.TrimStart)
                Slipknot.addParameter("PartName", Convert.ToString(row.Cells("fldPartName").Value).TrimStart.TrimStart)
                Slipknot.addParameter("LotNo", Convert.ToString(row.Cells("fldLotNo").Value).TrimStart.TrimStart)
                Slipknot.addParameter("SolderAss", Convert.ToString(row.Cells("fldSolderAss").Value).TrimStart.TrimStart)
                Slipknot.addParameter("PCB", Convert.ToString(row.Cells("fldPCB").Value).TrimStart.TrimStart)
                Slipknot.addParameter("PCBValidityDate", Convert.ToDateTime(row.Cells("fldPCBValidityDate").Value))
                Slipknot.dbAED("SP_InsertBSSRMandLotNoAfterOven")
            Next

            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
        If gvRobot.Rows.Count > 0 Then
            For Each row As GridViewRowInfo In gvRobot.Rows
                Slipknot.addParameter("RMID", txtRMID.Text)
                Slipknot.addParameter("itemCode", Convert.ToString(row.Cells("fldItemCode").Value).TrimStart.TrimStart)
                Slipknot.addParameter("Robot", Convert.ToString(row.Cells("fldRobot").Value).TrimStart.TrimStart)
                Slipknot.addParameter("ValidityDate", Convert.ToDateTime(row.Cells("fldValidityDate").Value))
                Slipknot.addParameter("Robot2", Convert.ToString(row.Cells("fldRobot2").Value).TrimStart.TrimStart)
                Slipknot.addParameter("ValidityDate2", Convert.ToDateTime(row.Cells("fldValidityDate2").Value))
                Slipknot.dbAED("SP_InsertBSSRobotDatav2")
            Next
        End If
    End Sub

    Private Sub btnAddRobot_Click(sender As Object, e As EventArgs) Handles btnAddRobot.Click
        If gvRm.Rows.Count = 0 Then
            RadMessageBox.Show("No RM found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        ElseIf txtRobot.Text = "" Then
            RadMessageBox.Show("Please input Robot ", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        Else
            gvRobot.Rows.Add(Convert.ToString(gvRm.CurrentRow.Cells("fldItemCode").Value), txtRobot.Text, dtpRobotDate.Value, txtRobot2.Text, dtpRobotDate2.Value)
        End If
    End Sub

    Private Sub gvRm_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvRm.CellFormatting
        If e.CellElement.ColumnInfo.FieldName = "fldPCBValidityDate" Then
            If e.CellElement.Value = #0001-01-01# Then
                e.CellElement.ForeColor = Color.Transparent

            Else

                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            End If
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Sub mcbItemCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemCode.SelectedIndexChanged
        If mcbItemCode.SelectedValue Is Nothing Then
            txtPartName.Text = Nothing
        Else
            txtPartName.Text = Convert.ToString(mcbItemCode.SelectedValue)
        End If
    End Sub
End Class
