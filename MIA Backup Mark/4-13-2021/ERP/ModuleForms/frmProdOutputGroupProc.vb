Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmProdOutputGroupProc
    Private Sub FrmProdOutputGroupProc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldPOSPID As New GridViewDecimalColumn("POSPID")
        fldPOSPID.FieldName = "fldPOSPID"
        fldPOSPID.IsVisible = False
        gvData.Columns.Add(fldPOSPID)

        Dim fldMainId As New GridViewDecimalColumn("Main ID")
        fldMainId.FieldName = "fldMainId"
        fldMainId.IsVisible = False
        gvData.Columns.Add(fldMainId)

        Dim fldTitle As New GridViewTextBoxColumn("Title")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 210
        fldTitle.IsVisible = False
        gvData.Columns.Add(fldTitle)

        Dim fldProcessCode As New GridViewTextBoxColumn("Process")
        fldProcessCode.FieldName = "fldProcessCode"
        fldProcessCode.Width = 80
        gvData.Columns.Add(fldProcessCode)

        Dim fldMainProcess As New GridViewTextBoxColumn("Main Name") With {
            .FieldName = "fldMainProcess",
            .Width = 270
        }
        gvData.Columns.Add(fldMainProcess)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name") With {
            .FieldName = "fldPartName",
            .Width = 270
        }
        gvData.Columns.Add(fldPartName)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code") With {
            .FieldName = "fldItemCode",
            .Width = 120
        }
        gvData.Columns.Add(fldItemCode)

        Dim fldNoOfPersons As New GridViewDecimalColumn("No. of Persons")
        fldNoOfPersons.FieldName = "fldNoOfPersons"
        fldNoOfPersons.Width = 110
        gvData.Columns.Add(fldNoOfPersons)

        Dim fldLineTimePartition As New GridViewDecimalColumn("Line Time Partition")
        fldLineTimePartition.FieldName = "fldLineTimePartition"
        fldLineTimePartition.Width = 130
        gvData.Columns.Add(fldLineTimePartition)

        Dim fldAOprTime As New GridViewDecimalColumn("A. Operation TIme (mins)")
        fldAOprTime.FieldName = "fldAOprTime"
        fldAOprTime.Width = 180
        gvData.Columns.Add(fldAOprTime)

        Dim fldStartUp As New GridViewDecimalColumn("Start-up, 5S, Hotto, Breaktime")
        fldStartUp.WrapText = True
        fldStartUp.FieldName = "fldStartUp"
        fldStartUp.Width = 140
        gvData.Columns.Add(fldStartUp)

        Dim fldPlanDowntime As New GridViewDecimalColumn("Planned Downtime")
        fldPlanDowntime.FieldName = "fldPlanDowntime"
        fldPlanDowntime.Width = 90
        gvData.Columns.Add(fldPlanDowntime)

        Dim fldUnPlanDowntime As New GridViewDecimalColumn("Un-Planned Downtime")
        fldUnPlanDowntime.FieldName = "fldUnPlanDowntime"
        fldUnPlanDowntime.Width = 110
        gvData.Columns.Add(fldUnPlanDowntime)

        Dim fldCycleTime As New GridViewDecimalColumn("Cycle Time (A-B*60)/C")
        fldCycleTime.WrapText = True
        fldCycleTime.FieldName = "fldCycleTime"
        fldCycleTime.Width = 110
        gvData.Columns.Add(fldCycleTime)

        Dim fldCustomer As New GridViewTextBoxColumn("Customer")
        fldCustomer.FieldName = "fldCustomer"
        fldCustomer.Width = 100
        gvData.Columns.Add(fldCustomer)

        Dim fldFGNo As New GridViewTextBoxColumn("FG No.")
        fldFGNo.FieldName = "fldFGNo"
        fldFGNo.Width = 80
        gvData.Columns.Add(fldFGNo)

        Dim fldLotNo As New GridViewTextBoxColumn("Lot No.")
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.Width = 80
        gvData.Columns.Add(fldLotNo)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If Slipknot.IsFormOpen(frmAddProdOutputGroupProc) Then
            frmAddProdOutputGroupProc.Focus()
        Else
            If BulletForMyValentine.isRW("fldModProductionOutput") = False Then
                Slapshock.NoAccessToFunctionMessage()

                Exit Sub
            End If
            globalVariables.BSSProdOutputAction = "New"
            frmAddProdOutputGroupProc.Show(Me)
        End If

    End Sub

    Private Sub FrmProdOutputGroupProc_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchProdOutputGroup()
    End Sub

    Private Sub FetchProdOutputGroup()
        Slipknot.addParameter("MainID", globalVariables.MainID)
        gvData.DataSource = Slipknot.dbSelect("SP_SelectProdOutputSubProcessbyMainID")
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        FetchProdOutputGroup()
    End Sub

    Private Sub cbbDefect_Click(sender As Object, e As EventArgs) Handles cbbDefect.Click
        If (gvData.Rows.Count >= 1) Then
            If Slipknot.IsFormOpen(FrmBSSDefect) Then
                FrmBSSDefect.Focus()
            Else
                FrmBSSDefect.mcbTitle.Text = gvData.CurrentRow.Cells("fldTitle").Value
                FrmBSSDefect.mcbProcess.Text = gvData.CurrentRow.Cells("fldMainProcess").Value
                FrmBSSDefect.txtPOSPID.Text = gvData.CurrentRow.Cells("fldPOSPID").Value
                FrmBSSDefect.txtMainID.Text = gvData.CurrentRow.Cells("fldMainId").Value
                FrmBSSDefect.Show(Me)
            End If
        Else
            RadMessageBox.Show("No Record found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub cbHPO_Click(sender As Object, e As EventArgs) Handles cbHPO.Click
        If (gvData.Rows.Count >= 1) Then
            If Slipknot.IsFormOpen(FrmHourlyProdMnt) Then
                FrmHourlyProdMnt.Focus()
            Else
                FrmHourlyProdMnt.mcbTitle.Text = gvData.CurrentRow.Cells("fldTitle").Value
                FrmHourlyProdMnt.mcbProcess.Text = gvData.CurrentRow.Cells("fldMainProcess").Value
                FrmHourlyProdMnt.txtPOSPID.Text = gvData.CurrentRow.Cells("fldPOSPID").Value
                FrmHourlyProdMnt.txtMainID.Text = gvData.CurrentRow.Cells("fldMainId").Value
                FrmHourlyProdMnt.Show(Me)
            End If
        Else
            RadMessageBox.Show("No Record found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub cbRMWorkProcess_Click(sender As Object, e As EventArgs) Handles cbRMWorkProcess.Click
        If (gvData.Rows.Count >= 1) Then
            If Slipknot.IsFormOpen(FrmRMWorkProcess) Then
                FrmRMWorkProcess.Focus()
            Else
                FrmRMWorkProcess.mcbTitle.Text = gvData.CurrentRow.Cells("fldTitle").Value
                FrmRMWorkProcess.mcbProcess.Text = gvData.CurrentRow.Cells("fldMainProcess").Value
                FrmRMWorkProcess.txtPOSPID.Text = gvData.CurrentRow.Cells("fldPOSPID").Value
                FrmRMWorkProcess.txtMainID.Text = gvData.CurrentRow.Cells("fldMainId").Value
                FrmRMWorkProcess.Show(Me)
            End If
        Else
            RadMessageBox.Show("No Record found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub cbOtherDetails_Click(sender As Object, e As EventArgs) Handles cbOtherDetails.Click
        If (gvData.Rows.Count >= 1) Then
            If Slipknot.IsFormOpen(FrmBSSOtherDetails) Then
                FrmBSSOtherDetails.Focus()
            Else
                FrmBSSOtherDetails.mcbTitle.Text = gvData.CurrentRow.Cells("fldTitle").Value
                FrmBSSOtherDetails.mcbProcess.Text = gvData.CurrentRow.Cells("fldMainProcess").Value
                FrmBSSOtherDetails.txtPOSPID.Text = gvData.CurrentRow.Cells("fldPOSPID").Value
                FrmBSSOtherDetails.txtMainID.Text = gvData.CurrentRow.Cells("fldMainId").Value
                FrmBSSOtherDetails.Show(Me)
            End If
        Else
            RadMessageBox.Show("No Record found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If (gvData.Rows.Count >= 1) Then
            If Slipknot.IsFormOpen(frmAddProdOutputGroupProc) Then
                frmAddProdOutputGroupProc.Focus()
            Else
                If BulletForMyValentine.isRW("fldModProductionOutput") = False Then
                    Slapshock.NoAccessToFunctionMessage()

                    Exit Sub
                End If
                globalVariables.BSSProdOutputAction = "Update"
                frmAddProdOutputGroupProc.Show(Me)
                frmAddProdOutputGroupProc.mcbTitle.Text = gvData.CurrentRow.Cells("fldTitle").Value
                frmAddProdOutputGroupProc.mcbProcess.Text = gvData.CurrentRow.Cells("fldMainProcess").Value
                frmAddProdOutputGroupProc.CheckProcessCodeifExist()
            End If
        Else
            RadMessageBox.Show("No Record found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If


    End Sub
End Class
