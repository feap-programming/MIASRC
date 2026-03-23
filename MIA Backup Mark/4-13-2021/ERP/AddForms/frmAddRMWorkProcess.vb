Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmAddRMWorkProcess
    Dim RandNoRM As String = String.Empty
    Dim RandNoRMWP As String = String.Empty
    Private Sub FrmAddRMWorkProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        dtpValidityDate.Format = DateTimePickerFormat.Custom
        dtpValidityDate.CustomFormat = "MMM dd, yyyy"
        dtpValidityDate.Value = Today

        dtpRobotDate.Format = DateTimePickerFormat.Custom
        dtpRobotDate.CustomFormat = "MMM dd, yyyy"
        dtpRobotDate.Value = Today

        LoadItemCode()
        readRM()
        readRobot()
        ' RandNoRM = GetRandom()
        RandNoRMWP = GetRandom()
    End Sub

    Private Sub LoadItemCode()

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
        Dim fldRMLID As New GridViewTextBoxColumn("RMLID") With {
            .FieldName = "fldRMLID",
            .IsVisible = True,
            .ReadOnly = True
        }
        gvRm.Columns.Add(fldRMLID)

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
            .Width = 120
        }
        gvRm.Columns.Add(fldLotNo)

        Dim fldSolderAss As New GridViewTextBoxColumn("Solder") With {
            .FieldName = "fldSolderAss",
            .Width = 80
        }
        gvRm.Columns.Add(fldSolderAss)

        Dim fldPCB As New GridViewTextBoxColumn("PCB") With {
            .FieldName = "fldPCB",
            .Width = 80
        }
        gvRm.Columns.Add(fldPCB)

        gvRm.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvRm.AllowAddNewRow = False
        gvRm.ShowFilteringRow = False
        gvRm.ShowGroupPanel = False
        gvRm.EnableSorting = False
        gvRm.AllowColumnReorder = False
        gvRm.AllowRowReorder = False

    End Sub
    Private Sub readRobot()
        Dim fldRMLID As New GridViewTextBoxColumn("RMLID") With {
            .FieldName = "fldRMLID",
            .IsVisible = True,
            .ReadOnly = True
        }
        gvRobot.Columns.Add(fldRMLID)

        Dim fldRobot As New GridViewTextBoxColumn("Robot") With {
            .FieldName = "fldRobot",
            .Width = 150,
            .ReadOnly = True
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


        gvRobot.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvRobot.AllowAddNewRow = False
        gvRobot.ShowFilteringRow = False
        gvRobot.ShowGroupPanel = False
        gvRobot.EnableSorting = False
        gvRobot.AllowColumnReorder = False
        gvRobot.AllowRowReorder = False

    End Sub
    Private Sub FrmAddRMWorkProcess_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        mcbItemCode.SelectedIndex = -1

    End Sub

    Private Function GetRandom()
        'GetRandomNumber
        Dim DRSetRandomNo As DataRow = Nothing

        Dim Rand As DataTable = Slipknot.dbSelect("SP_SelectRandomNumberPOSP")
        DRSetRandomNo = Rand.Rows(0)
        Return Convert.ToString(DRSetRandomNo.Item("SetRandom"))
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtTrayNo.Text Is Nothing Then
            RadMessageBox.Show("Tray No cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txtTrayNo.Select()
            Exit Sub
        End If
        AddRMWorkProcess()
    End Sub
    Private Sub AddRMWorkProcess()
        Slipknot.addParameter("RMID", Convert.ToInt32(RandNoRMWP))
        Slipknot.addParameter("MainID", Convert.ToInt32(txtMainID.Text))
        Slipknot.addParameter("POSPID", Convert.ToInt32(txtPOSPID.Text))
        Slipknot.addParameter("_Time", rtpTime.Value)
        Slipknot.addParameter("TrayNo", Convert.ToString(txtTrayNo.Text))
        Slipknot.addParameter("ScrapQTY", Convert.ToInt32(seScrapQTY.Value))
        Slipknot.addParameter("QCNormal", Convert.ToInt32(seNormal.Value))
        Slipknot.addParameter("QTYAdd", Convert.ToInt32(seAdd.Value))
        Slipknot.addParameter("StartUp", Convert.ToInt32(seStartup.Value))
        Slipknot.addParameter("Adj", Convert.ToInt32(seAdj.Value))
        Slipknot.addParameter("ValidityDate", Convert.ToDateTime(dtpValidityDate.Value))
        Slipknot.addParameter("Username", currentUser.Item("fldUsername"))

        Slipknot.dbAED("SP_InsertRMWorkProcess")

        If gvRm.Rows.Count > 0 Then
            For Each row As GridViewRowInfo In gvRm.Rows
                Slipknot.addParameter("RMLID", Convert.ToString(row.Cells("fldRMLID").Value).TrimStart.TrimStart)
                Slipknot.addParameter("RMID", Convert.ToInt32(RandNoRMWP))
                Slipknot.addParameter("itemCode", Convert.ToString(row.Cells("fldItemCode").Value).TrimStart.TrimStart)
                Slipknot.addParameter("PartName", Convert.ToString(row.Cells("fldPartName").Value).TrimStart.TrimStart)
                Slipknot.addParameter("LotNo", Convert.ToString(row.Cells("fldLotNo").Value).TrimStart.TrimStart)
                Slipknot.addParameter("SolderAss", Convert.ToString(row.Cells("fldSolderAss").Value).TrimStart.TrimStart)
                Slipknot.addParameter("PCB", Convert.ToString(row.Cells("fldPCB").Value).TrimStart.TrimStart)
                Slipknot.dbAED("SP_InsertBSSRMandLotNo")
            Next
        End If
        If gvRobot.Rows.Count > 0 Then
            For Each row As GridViewRowInfo In gvRobot.Rows
                Slipknot.addParameter("RMLID", Convert.ToString(row.Cells("fldRMLID").Value).TrimStart.TrimStart)
                Slipknot.addParameter("Robot", Convert.ToString(row.Cells("fldRobot").Value).TrimStart.TrimStart)
                Slipknot.addParameter("ValidityDate", Convert.ToDateTime(row.Cells("fldValidityDate").Value))
                Slipknot.dbAED("SP_InsertBSSRobotData")
            Next
        End If
        RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
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

            gvRm.Rows.Add(Convert.ToString(GetRandom()), mcbItemCode.Text, txtPartName.Text, txtLotNo.Text, Solder, PCB)
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

    Private Sub btnAddRobot_Click(sender As Object, e As EventArgs) Handles btnAddRobot.Click
        If gvRm.Rows.Count = 0 Then
            RadMessageBox.Show("No RM found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        ElseIf txtRobot.Text = "" Then
            RadMessageBox.Show("Please input Robot ", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        Else
            gvRobot.Rows.Add(Convert.ToString(gvRm.CurrentRow.Cells("fldRMLID").Value), txtRobot.Text, dtpRobotDate.Value)
        End If
    End Sub
End Class
