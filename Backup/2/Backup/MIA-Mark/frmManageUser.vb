Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmManageUser
    Private Sub FrmManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadRecord()
    End Sub

    Private Sub loadRecord()

        Slipknot.addParameter("parId", txtId.Text)
        Dim user As DataTable = Slipknot.dbSelect("SP_SelectUserById")

        If user.Rows.Count > 0 Then

            txtUsername.Text = Convert.ToString(user.Rows(0).Item("fldUsername"))
            txtName.Text = Convert.ToString(user.Rows(0).Item("fldName"))
            ddUserType.Text = Convert.ToString(user.Rows(0).Item("fldUserType"))
            chkDisabled.Checked = Convert.ToBoolean(user.Rows(0).Item("fldDisabled"))

            ddBOMProvider.Text = Convert.ToString(user.Rows(0).Item("fldModBOMProvider"))
            ddCostTable.Text = Convert.ToString(user.Rows(0).Item("fldModCostTable"))
            ddLCSProvider.Text = Convert.ToString(user.Rows(0).Item("fldModLCSProvider"))
            ddCustomTuning.Text = Convert.ToString(user.Rows(0).Item("fldModCustomTuning"))
            ddActualGroupAssignment.Text = Convert.ToString(user.Rows(0).Item("fldModActualGroupAssignment"))
            ddBudgetReference.Text = Convert.ToString(user.Rows(0).Item("fldModBudgetReference"))
            ddProductionPlanning.Text = Convert.ToString(user.Rows(0).Item("fldModProductionPlanning"))
            ddCapacityForecast.Text = Convert.ToString(user.Rows(0).Item("fldModCapacityForecast"))
            ddCustomerDemand.Text = Convert.ToString(user.Rows(0).Item("fldModCustomerDemand"))
            ddInventoryTransfer.Text = Convert.ToString(user.Rows(0).Item("fldModInventoryTransfer"))
            ddLineIssuance.Text = Convert.ToString(user.Rows(0).Item("fldModLineIssuance"))
            ddProductionOutput.Text = Convert.ToString(user.Rows(0).Item("fldModProductionOutput"))
            ddInventoryMonitoring.Text = Convert.ToString(user.Rows(0).Item("fldModInventoryMonitoring"))
            ddCountingReference.Text = Convert.ToString(user.Rows(0).Item("fldModCountingReference"))
            ddKanbanCreator.Text = Convert.ToString(user.Rows(0).Item("fldModKanbanCreator"))
            ddCategoryList.Text = Convert.ToString(user.Rows(0).Item("fldMRCategoryList"))
            ddCustomerList.Text = Convert.ToString(user.Rows(0).Item("fldMRCustomerList"))
            ddLineList.Text = Convert.ToString(user.Rows(0).Item("fldMRLineList"))
            ddMachineList.Text = Convert.ToString(user.Rows(0).Item("fldMRMachineList"))
            ddMakerList.Text = Convert.ToString(user.Rows(0).Item("fldMRMakerList"))
            ddModelList.Text = Convert.ToString(user.Rows(0).Item("fldMRModelList"))
            ddOutputType.Text = Convert.ToString(user.Rows(0).Item("fldMROutputType"))
            ddProcessList.Text = Convert.ToString(user.Rows(0).Item("fldMRProcessList"))
            ddProcessComponentList.Text = Convert.ToString(user.Rows(0).Item("fldMRProcessComponentList"))
            ddShiftList.Text = Convert.ToString(user.Rows(0).Item("fldMRShiftList"))
            ddUOMList.Text = Convert.ToString(user.Rows(0).Item("fldMRUOMList"))
            ddWarehouseCodeList.Text = Convert.ToString(user.Rows(0).Item("fldMRWarehouseCodeList"))
            ddItemMasterData.Text = Convert.ToString(user.Rows(0).Item("fldMDItemMasterData"))
            ddItemPerCustomer.Text = Convert.ToString(user.Rows(0).Item("fldMDItemPerCustomer"))
            ddItemPerModel.Text = Convert.ToString(user.Rows(0).Item("fldMDItemPerModel"))
            ddItemPerProcess.Text = Convert.ToString(user.Rows(0).Item("fldMDItemPerProcess"))
            ddRMPriceList.Text = Convert.ToString(user.Rows(0).Item("fldMDRMPriceList"))
            ddItemCodeHistory.Text = Convert.ToString(user.Rows(0).Item("fldMDItemCodeHistory"))
            ddBOMMasterData.Text = Convert.ToString(user.Rows(0).Item("fldMDBOMMasterData"))
            ddMaterialPriceList.Text = Convert.ToString(user.Rows(0).Item("fldMDMaterialPriceList"))
            ddLineGroupSharing.Text = Convert.ToString(user.Rows(0).Item("fldMDLineGroupSharing"))
            ddLinePerWarehouse.Text = Convert.ToString(user.Rows(0).Item("fldMDLinePerWarehouse"))
            ddWarehousing.Text = Convert.ToString(user.Rows(0).Item("fldMDWarehousing"))
            ddGLAccounts.Text = Convert.ToString(user.Rows(0).Item("fldMDGLAccounts"))
            ddBusinessPartners.Text = Convert.ToString(user.Rows(0).Item("fldMDBusinessPartners"))

            If txtUsername.Text = "admin" Then

                txtName.ReadOnly = True
                ddUserType.ReadOnly = True
                chkDisabled.ReadOnly = True

                ddBOMProvider.ReadOnly = True
                ddCostTable.ReadOnly = True
                ddLCSProvider.ReadOnly = True
                ddCustomTuning.ReadOnly = True
                ddActualGroupAssignment.ReadOnly = True
                ddBudgetReference.ReadOnly = True
                ddProductionPlanning.ReadOnly = True
                ddCapacityForecast.ReadOnly = True
                ddCustomerDemand.ReadOnly = True
                ddInventoryTransfer.ReadOnly = True
                ddLineIssuance.ReadOnly = True
                ddInventoryMonitoring.ReadOnly = True
                ddCountingReference.ReadOnly = True
                ddKanbanCreator.ReadOnly = True

                ddCategoryList.ReadOnly = True
                ddCustomerList.ReadOnly = True
                ddLineList.ReadOnly = True
                ddMachineList.ReadOnly = True
                ddMakerList.ReadOnly = True
                ddModelList.ReadOnly = True
                ddProcessList.ReadOnly = True
                ddShiftList.ReadOnly = True
                ddUOMList.ReadOnly = True
                ddWarehouseCodeList.ReadOnly = True
                ddItemMasterData.ReadOnly = True
                ddItemPerCustomer.ReadOnly = True
                ddItemPerModel.ReadOnly = True
                ddItemPerProcess.ReadOnly = True
                ddRMPriceList.ReadOnly = True
                ddItemCodeHistory.ReadOnly = True
                ddLinePerWarehouse.ReadOnly = True
                ddBOMMasterData.ReadOnly = True
                ddMaterialPriceList.ReadOnly = True
                ddWarehousing.ReadOnly = True
                ddLineGroupSharing.ReadOnly = True

                btnSave.Enabled = False

            End If


        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Slipknot.addParameter("parId", txtId.Text)
        Slipknot.addParameter("parName", txtName.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parUserType", ddUserType.Text)
        Slipknot.addParameter("parDisabled", chkDisabled.Checked)
        Slipknot.addParameter("parModBOMProvider", ddBOMProvider.Text)
        Slipknot.addParameter("parModCostTable", ddCostTable.Text)
        Slipknot.addParameter("parModLCSProvider", ddLCSProvider.Text)
        Slipknot.addParameter("parModCustomTuning", ddCustomTuning.Text)
        Slipknot.addParameter("parModActualGroupAssignment", ddActualGroupAssignment.Text)
        Slipknot.addParameter("parModBudgetReference", ddBudgetReference.Text)
        Slipknot.addParameter("parModProductionPlanning", ddProductionPlanning.Text)
        Slipknot.addParameter("parModCapacityForecast", ddCapacityForecast.Text)
        Slipknot.addParameter("parModCustomerDemand", ddCustomerDemand.Text)
        Slipknot.addParameter("parModInventoryTransfer", ddInventoryTransfer.Text)
        Slipknot.addParameter("parModLineIssuance", ddLineIssuance.Text)
        Slipknot.addParameter("parModProductionOutput", ddProductionOutput.Text)
        Slipknot.addParameter("parModInventoryMonitoring", ddInventoryMonitoring.Text)
        Slipknot.addParameter("parModCountingReference", ddCountingReference.Text)
        Slipknot.addParameter("parModKanbanCreator", ddKanbanCreator.Text)
        Slipknot.addParameter("parMRCategoryList", ddCategoryList.Text)
        Slipknot.addParameter("parMRCustomerList", ddCustomerList.Text)
        Slipknot.addParameter("parMRLineList", ddLineList.Text)
        Slipknot.addParameter("parMRMachineList", ddMachineList.Text)
        Slipknot.addParameter("parMRMakerList", ddMakerList.Text)
        Slipknot.addParameter("parMRModelList", ddModelList.Text)
        Slipknot.addParameter("parMROutputType", ddOutputType.Text)
        Slipknot.addParameter("parMRProcessList", ddProcessList.Text)
        Slipknot.addParameter("parMRProcessComponentList", ddProcessComponentList.Text)
        Slipknot.addParameter("parMRShiftList", ddShiftList.Text)
        Slipknot.addParameter("parMRUOMList", ddUOMList.Text)
        Slipknot.addParameter("parWarehouseCodeList", ddWarehouseCodeList.Text)
        Slipknot.addParameter("parMDItemMasterData", ddItemMasterData.Text)
        Slipknot.addParameter("parMDItemPerCustomer", ddItemPerCustomer.Text)
        Slipknot.addParameter("parMDItemPerModel", ddItemPerModel.Text)
        Slipknot.addParameter("parMDItemPerProcess", ddItemPerProcess.Text)
        Slipknot.addParameter("parMDRMPriceList", ddRMPriceList.Text)
        Slipknot.addParameter("parMDItemCodeHistory", ddItemCodeHistory.Text)
        Slipknot.addParameter("parMDBOMMasterData", ddBOMMasterData.Text)
        Slipknot.addParameter("parMDMaterialPriceList", ddMaterialPriceList.Text)
        Slipknot.addParameter("parMDLineGroupSharing", ddLineGroupSharing.Text)
        Slipknot.addParameter("parMDLinePerWarehouse", ddLinePerWarehouse.Text)
        Slipknot.addParameter("parMDWarehousing", ddWarehousing.Text)
        Slipknot.addParameter("parMDGLAccounts", ddGLAccounts.Text)
        Slipknot.addParameter("parMDBusinessPartners", ddBusinessPartners.Text)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_UpdateUser") Then
            RadMessageBox.Show("Save Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub
End Class
