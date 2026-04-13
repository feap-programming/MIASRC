Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class frmBase

    Private isLogOut As Boolean
    Private txtSearch As New RadTextBoxControl
    Private formNameToOpen As String

    Private Sub treeMain_NodeMouseClick(sender As Object, e As Telerik.WinControls.UI.RadTreeViewEventArgs) Handles treeModules.NodeMouseClick
        formNameToOpen = treeModules.SelectedNode.Name

        If bwFormOpener.IsBusy = False Then
            bwFormOpener.RunWorkerAsync()
        End If
    End Sub

    Private Sub openItemMasterData()

        If Slipknot.IsFormOpen(FrmItemMasterData) Then
            FrmItemMasterData.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDItemMasterData")

            If check <> "NA" Then
                FrmItemMasterData.MdiParent = Me
                FrmItemMasterData.lePermission.Text = check
                FrmItemMasterData.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openItemBOM()

        If Slipknot.IsFormOpen(frmBOMProvider) Then
            frmBOMProvider.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModBOMProvider")

            If check <> "NA" Then
                frmBOMProvider.MdiParent = Me
                frmBOMProvider.lePermission.Text = check
                frmBOMProvider.Show()
            Else
                Slapshock.NoAccessToModuleMessage()
            End If

        End If

    End Sub

    Private Sub openCostTable()

        If Slipknot.IsFormOpen(FrmCostTable) Then
            FrmCostTable.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModCostTable")

            If check <> "NA" Then
                FrmCostTable.MdiParent = Me
                FrmCostTable.lePermission.Text = check
                FrmCostTable.Show()
            Else
                Slapshock.NoAccessToModuleMessage()
            End If

        End If

    End Sub

    Private Sub openCustomerList()

        If Slipknot.IsFormOpen(FrmCustomerList) Then
            FrmCustomerList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRCustomerList")

            If check <> "NA" Then
                FrmCustomerList.MdiParent = Me
                FrmCustomerList.lePermission.Text = check
                FrmCustomerList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If

        End If

    End Sub

    Private Sub openLineList()

        If Slipknot.IsFormOpen(frmLineList) Then
            frmLineList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRLineList")

            If check <> "NA" Then
                frmLineList.MdiParent = Me
                frmLineList.lePermission.Text = check
                frmLineList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openMachineList()

        If Slipknot.IsFormOpen(FrmMachineList) Then
            frmLineList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRMachineList")

            If check <> "NA" Then
                FrmMachineList.MdiParent = Me
                FrmMachineList.lePermission.Text = check
                FrmMachineList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openMakerList()

        If Slipknot.IsFormOpen(FrmMakerList) Then
            FrmMakerList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRMakerList")

            If check <> "NA" Then
                FrmMakerList.MdiParent = Me
                FrmMakerList.lePermission.Text = check
                FrmMakerList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openItemMasterPerCustomer()

        If Slipknot.IsFormOpen(FrmCustomerItemMaster) Then
            FrmCustomerItemMaster.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDItemPerCustomer")

            If check <> "NA" Then
                FrmCustomerItemMaster.MdiParent = Me
                FrmCustomerItemMaster.lePermission.Text = check
                FrmCustomerItemMaster.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openCategoryList()

        If Slipknot.IsFormOpen(frmCategoryList) Then
            frmCategoryList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRCategoryList")

            If check <> "NA" Then
                frmCategoryList.MdiParent = Me
                frmCategoryList.lePermission.Text = check
                frmCategoryList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openCompanyPartNoHistory()

        If Slipknot.IsFormOpen(frmItemCodeHistory) Then
            frmItemCodeHistory.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDItemCodeHistory")

            If check <> "NA" Then
                frmItemCodeHistory.MdiParent = Me
                frmItemCodeHistory.lePermission.Text = check
                frmItemCodeHistory.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openBOMMaster()

        If Slipknot.IsFormOpen(FrmBOMMaster) Then
            FrmBOMMaster.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDBOMMasterData")

            If check <> "NA" Then
                FrmBOMMaster.MdiParent = Me
                FrmBOMMaster.lePermission.Text = check
                FrmBOMMaster.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openGLAccounts()

        If Slipknot.IsFormOpen(frmGLAccounts) Then
            frmGLAccounts.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDGLAccounts")

            If check <> "NA" Then
                frmGLAccounts.MdiParent = Me
                frmGLAccounts.lePermission.Text = check
                frmGLAccounts.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If

        End If

    End Sub

    Private Sub openBusinessPartners()

        If Slipknot.IsFormOpen(FrmBusinessPartners) Then
            FrmBusinessPartners.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDBusinessPartners")

            If check <> "NA" Then
                FrmBusinessPartners.MdiParent = Me
                FrmBusinessPartners.lePermission.Text = check
                FrmBusinessPartners.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If

        End If

    End Sub

    Private Sub openMaterialPriceList()

        If Slipknot.IsFormOpen(FrmMaterialPriceList) Then
            FrmMaterialPriceList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDMaterialPriceList")

            If check <> "NA" Then
                FrmMaterialPriceList.MdiParent = Me
                FrmMaterialPriceList.lePermission.Text = check
                FrmMaterialPriceList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openWarehousing()

        If Slipknot.IsFormOpen(FrmWarehousing) Then
            FrmWarehousing.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDWarehousing")

            If check <> "NA" Then
                FrmWarehousing.MdiParent = Me
                FrmWarehousing.lePermission.Text = check
                FrmWarehousing.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openLineGroupSharing()

        If Slipknot.IsFormOpen(FrmLineGroupSharing) Then
            FrmLineGroupSharing.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDLineGroupSharing")

            If check <> "NA" Then
                FrmLineGroupSharing.MdiParent = Me
                FrmLineGroupSharing.lePermission.Text = check
                FrmLineGroupSharing.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openLinePerWarehouse()

        If Slipknot.IsFormOpen(FrmLinePerWarehouse) Then
            FrmLinePerWarehouse.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDLinePerWarehouse")

            If check <> "NA" Then
                FrmLinePerWarehouse.MdiParent = Me
                FrmLinePerWarehouse.lePermission.Text = check
                FrmLinePerWarehouse.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openInventoryTransfer()

        If Slipknot.IsFormOpen(frmInventoryTransfer) Then
            frmInventoryTransfer.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModInventoryTransfer")

            If check <> "NA" Then
                frmInventoryTransfer.MdiParent = Me
                frmInventoryTransfer.lePermission.Text = check
                frmInventoryTransfer.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openProdDailyRepSRC()

        If Slipknot.IsFormOpen(FrmNewAssyDailyReport) Then
            FrmNewAssyDailyReport.Focus()
            'FrmProdDailyReportSRC.Focus()
        Else
            'Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModProductionOutput")

            'If check <> "NA" Then
            FrmNewAssyDailyReport.MdiParent = Me
            'FrmProdDailyReportSRC.MdiParent = Me
            '    frmProdOutputGroup.lePermission.Text = check
            FrmNewAssyDailyReport.Show()
            'FrmProdDailyReportSRC.Show()
            'Else
            '    Slapshock.NoAccessToMasterMessage()
            'End If
        End If

    End Sub
    Private Sub openWeldingDailyRepSRC()

        If Slipknot.IsFormOpen(FrmFWPWDailyReport) Then
            FrmFWPWDailyReport.Focus()
        Else
            'Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModProductionOutput")
            Mio.WeldingType = "PW"
            'If check <> "NA" Then
            FrmFWPWDailyReport.MdiParent = Me
            '    frmProdOutputGroup.lePermission.Text = check
            FrmFWPWDailyReport.Show()
            'Else
            '    Slapshock.NoAccessToMasterMessage()
            'End If
        End If

    End Sub

    Private Sub openPWDailyRepSRC()

        If Slipknot.IsFormOpen(FrmFWDailyReport) Then
            FrmFWDailyReport.Focus()
        Else
            'Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModProductionOutput")
            Mio.WeldingType = "FW"
            'If check <> "NA" Then
            FrmFWDailyReport.MdiParent = Me
            '    frmProdOutputGroup.lePermission.Text = check
            FrmFWDailyReport.Show()
            'Else
            '    Slapshock.NoAccessToMasterMessage()
            'End If
        End If

    End Sub
    Private Sub openATDailyRepSRC()

        If Slipknot.IsFormOpen(FrmAutoTapingDailyReport) Then
            FrmAutoTapingDailyReport.Focus()
        Else
            'Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModProductionOutput")
            Mio.WeldingType = "AT"
            'If check <> "NA" Then
            FrmAutoTapingDailyReport.MdiParent = Me
            '    frmProdOutputGroup.lePermission.Text = check
            FrmAutoTapingDailyReport.Show()
            'Else
            '    Slapshock.NoAccessToMasterMessage()
            'End If
        End If

    End Sub

    Private Sub openProductionOutputGroup()

        If Slipknot.IsFormOpen(frmProdOutputGroup) Then
            frmProdOutputGroup.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModProductionOutput")

            If check <> "NA" Then
                frmProdOutputGroup.MdiParent = Me
                frmProdOutputGroup.lePermission.Text = check
                frmProdOutputGroup.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openProductionOutput()

        If Slipknot.IsFormOpen(FrmProductionOutput) Then
            FrmProductionOutput.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModProductionOutput")

            If check <> "NA" Then
                FrmProductionOutput.MdiParent = Me
                FrmProductionOutput.lePermission.Text = check
                FrmProductionOutput.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openLineIssuance()

        If Slipknot.IsFormOpen(FrmLineIssuance) Then
            FrmLineIssuance.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModLineIssuance")

            If check <> "NA" Then
                FrmLineIssuance.MdiParent = Me
                FrmLineIssuance.lePermission.Text = check
                FrmLineIssuance.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openInventoryMonitoring()

        If Slipknot.IsFormOpen(FrmInventoryMonitoring) Then
            FrmInventoryMonitoring.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModInventoryMonitoring")

            If check <> "NA" Then
                FrmInventoryMonitoring.MdiParent = Me
                FrmInventoryMonitoring.lePermission.Text = check
                FrmInventoryMonitoring.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openCountingReference()

        If Slipknot.IsFormOpen(FrmCountingReference) Then
            FrmCountingReference.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModCountingReference")

            If check <> "NA" Then
                FrmCountingReference.MdiParent = Me
                FrmCountingReference.lePermission.Text = check
                FrmCountingReference.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openKanbanCreator()

        If Slipknot.IsFormOpen(FrmKanbanCreator) Then
            FrmKanbanCreator.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModKanbanCreator")

            If check <> "NA" Then
                FrmKanbanCreator.MdiParent = Me
                FrmKanbanCreator.lePermission.Text = check
                FrmKanbanCreator.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openProcessList()

        If Slipknot.IsFormOpen(frmProcessList) Then
            frmProcessList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRProcessList")

            If check <> "NA" Then
                frmProcessList.MdiParent = Me
                frmProcessList.lePermission.Text = check
                frmProcessList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openProcessComponentList()

        If Slipknot.IsFormOpen(frmProcessComponentList) Then
            frmProcessList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRProcessComponentList")

            If check <> "NA" Then
                frmProcessComponentList.MdiParent = Me
                frmProcessComponentList.lePermission.Text = check
                frmProcessComponentList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openModelList()

        If Slipknot.IsFormOpen(FrmModelList) Then
            FrmModelList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRModelList")

            If check <> "NA" Then
                FrmModelList.MdiParent = Me
                FrmModelList.lePermission.Text = check
                FrmModelList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openOutputType()

        If Slipknot.IsFormOpen(FrmOutputType) Then
            FrmOutputType.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMROutputType")

            If check <> "NA" Then
                FrmOutputType.MdiParent = Me
                FrmOutputType.lePermission.Text = check
                FrmOutputType.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openProcessPerItem()

        If Slipknot.IsFormOpen(FrmProcessPerItem) Then
            FrmProcessPerItem.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDItemPerProcess")

            If check <> "NA" Then
                FrmProcessPerItem.MdiParent = Me
                FrmProcessPerItem.lePermission.Text = check
                FrmProcessPerItem.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openProcessPerRM()

        If Slipknot.IsFormOpen(frmRMPriceList) Then
            frmRMPriceList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDRMPriceList")

            If check <> "NA" Then
                frmRMPriceList.MdiParent = Me
                frmRMPriceList.lePermission.Text = check
                frmRMPriceList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openItemPerModel()

        If Slipknot.IsFormOpen(FrmItemPerModel) Then
            FrmItemPerModel.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDItemPerModel")

            If check <> "NA" Then
                FrmItemPerModel.MdiParent = Me
                FrmItemPerModel.lePermission.Text = check
                FrmItemPerModel.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If

        End If

    End Sub

    Private Sub openSettings()

        If Slipknot.IsFormOpen(FrmSettings) Then
            FrmSettings.Focus()
        Else
            Dim check As String = Slipknot.checkAdminPermission(leUsername.Text)

            If check = "ADMINISTRATOR" Then
                FrmSettings.MdiParent = Me
                FrmSettings.Show()
            Else
                Slapshock.NoAccessToModuleMessage()
            End If
        End If

    End Sub

    Private Sub openUser()

        If Slipknot.IsFormOpen(FrmUsers) Then
            FrmUsers.Focus()
        Else
            Dim check As String = Slipknot.checkAdminPermission(leUsername.Text)

            If check = "ADMINISTRATOR" Then
                FrmUsers.MdiParent = Me
                FrmUsers.Show()
            Else
                Slapshock.NoAccessToModuleMessage()
            End If

        End If

    End Sub

    Private Sub openConversionRate()

        If Slipknot.IsFormOpen(FrmConversionRate) Then
            FrmConversionRate.Focus()
        Else
            Dim check As String = Slipknot.checkAdminPermission(leUsername.Text)

            If check = "ADMINISTRATOR" Then
                FrmConversionRate.MdiParent = Me
                FrmConversionRate.Show()
            Else
                Slapshock.NoAccessToModuleMessage()
            End If

        End If

    End Sub

    Private Sub openCapacityForecast()

        If Slipknot.IsFormOpen(FrmCapacityForecast) Then
            FrmCapacityForecast.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModCapacityForecast")

            If check <> "NA" Then
                FrmCapacityForecast.MdiParent = Me
                'FrmCapacityForecast.lePermission.Text = check
                FrmCapacityForecast.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openLongTermForecast()

        If Slipknot.IsFormOpen(FrmLongTermForecast2) Then
            FrmLongTermForecast2.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModCapacityForecast")

            If check <> "NA" Then
                FrmLongTermForecast2.MdiParent = Me
                'FrmCapacityForecast.lePermission.Text = check
                FrmLongTermForecast2.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openInvoice()

        If Slipknot.IsFormOpen(FrmInvoice) Then
            FrmInvoice.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModCapacityForecast")

            If check <> "NA" Then
                FrmInvoice.MdiParent = Me
                'FrmCapacityForecast.lePermission.Text = check
                FrmInvoice.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub
    Private Sub openActualGroupAssignment()

        If Slipknot.IsFormOpen(FrmModelGroupAssignment) Then
            FrmModelGroupAssignment.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModActualGroupAssignment")

            If check <> "NA" Then
                FrmModelGroupAssignment.MdiParent = Me
                FrmModelGroupAssignment.lePermission.Text = check
                FrmModelGroupAssignment.Show()
            Else
                Slapshock.NoAccessToModuleMessage()
            End If
        End If

    End Sub

    Private Sub openShiftList()
        If Slipknot.IsFormOpen(FrmShiftList) Then
            FrmShiftList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRShiftList")

            If check <> "NA" Then
                FrmShiftList.MdiParent = Me
                FrmShiftList.lePermission.Text = check
                FrmShiftList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If
    End Sub
    Private Sub openUOMList()
        If Slipknot.IsFormOpen(FrmUOMList) Then
            FrmUOMList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRUOMList")

            If check <> "NA" Then
                FrmUOMList.MdiParent = Me
                FrmUOMList.lePermission.Text = check
                FrmUOMList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If
    End Sub

    Private Sub openWarehouseCodeList()
        If Slipknot.IsFormOpen(frmWarehouseCodeList) Then
            frmWarehouseCodeList.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMRWarehouseCodeList")

            If check <> "NA" Then
                frmWarehouseCodeList.MdiParent = Me
                frmWarehouseCodeList.lePermission.Text = check
                frmWarehouseCodeList.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If
    End Sub

    Private Sub openLCSCreator()

        If Slipknot.IsFormOpen(FrmLCSCreator) Then
            FrmLCSCreator.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModLCSProvider")

            If check <> "NA" Then
                FrmLCSCreator.MdiParent = Me
                FrmLCSCreator.lePermission.Text = check
                FrmLCSCreator.Show()
            Else
                Slapshock.NoAccessToModuleMessage()
            End If
        End If

    End Sub

    Private Sub openCustomTuning()

        If Slipknot.IsFormOpen(FrmLotControlTemplates) Then
            FrmLotControlTemplates.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModCustomTuning")

            If check <> "NA" Then
                FrmLotControlTemplates.MdiParent = Me
                FrmLotControlTemplates.lePermission.Text = check
                FrmLotControlTemplates.Show()
            Else
                Slapshock.NoAccessToModuleMessage()
            End If
        End If

    End Sub

    Private Sub openChangePassword()

        If Slipknot.IsFormOpen(FrmChangePassword) Then
            FrmChangePassword.Focus()
        Else
            FrmChangePassword.txtUsername.Text = leUsername.Text
            FrmChangePassword.Show(Me)
        End If

    End Sub

    Private Sub openCheckVoucher()

        If Slipknot.IsFormOpen(frmRMPriceList) Then
            FrmCheckVoucher.Focus()
        Else

            FrmCheckVoucher.MdiParent = Me
            FrmCheckVoucher.Show()

            'Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDRMPriceList")

            'If check <> "NA" Then
            '    frmRMPriceList.MdiParent = Me
            '    frmRMPriceList.lePermission.Text = check
            '    frmRMPriceList.Show()
            'Else
            '    Slapshock.NoAccessToMasterMessage()
            'End If
        End If

    End Sub

    Private Sub openCosting()

        If Slipknot.IsFormOpen(FrmCosting) Then
            FrmCosting.Focus()
        Else

            FrmCosting.MdiParent = Me
            FrmCosting.Show()

            'Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldMDRMPriceList")

            'If check <> "NA" Then
            '    frmRMPriceList.MdiParent = Me
            '    frmRMPriceList.lePermission.Text = check
            '    frmRMPriceList.Show()
            'Else
            '    Slapshock.NoAccessToMasterMessage()
            'End If
        End If

    End Sub
    Private Sub openCustomerStdLeadTime()

        If Slipknot.IsFormOpen(FrmCustomerStdLeadTime) Then
            FrmCustomerStdLeadTime.Focus()
        Else
            FrmCustomerStdLeadTime.MdiParent = Me
            'FrmProcessComPerProcess.lePermission.Text = check
            FrmCustomerStdLeadTime.Show()
        End If

    End Sub

    Private Sub openBIRReference()

        If Slipknot.IsFormOpen(FrmBIRReference) Then
            FrmBIRReference.Focus()
        Else
            FrmBIRReference.MdiParent = Me
            'FrmProcessComPerProcess.lePermission.Text = check
            FrmBIRReference.Show()
        End If

    End Sub

    Private Sub openCustomerReference()

        If Slipknot.IsFormOpen(FrmCustomerReference) Then
            FrmCustomerReference.Focus()
        Else
            FrmCustomerReference.MdiParent = Me
            'FrmProcessComPerProcess.lePermission.Text = check
            FrmCustomerReference.Show()
        End If

    End Sub

    Private Sub frmMainContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        cbhSearch.HostedItem = txtSearch.TextBoxElement
        txtSearch.NullText = "Search anything here......"

        Dim dtSearchItems As DataTable = Slipknot.dbSelect("SP_SelectSearchItems")

        txtSearch.AutoCompleteDataSource = dtSearchItems
        txtSearch.AutoCompleteDisplayMember = "fldItem"
        txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        RadMenu1.ElementTree.EnableApplicationThemeName = False
        RadMenu1.ThemeName = "CrystalDark"

        baseCommandBar.ElementTree.EnableApplicationThemeName = False
        baseCommandBar.ThemeName = "Crystal"

        RadCollapsiblePanel1.ElementTree.EnableApplicationThemeName = False
        RadCollapsiblePanel1.ThemeName = "Crystal"

        treeModules.ElementTree.EnableApplicationThemeName = False
        treeModules.ThemeName = "VisualStudio2012Dark"

        RadStatusStrip1.ElementTree.EnableApplicationThemeName = False
        RadStatusStrip1.ThemeName = "Crystal"

        If My.Settings.setTheme = "CrystalDark" Then
            cddTheme.Text = "Dark"
        Else
            cddTheme.Text = "Light"
        End If

        treeModules.Nodes("nodeAdministration").Image = My.Resources.admin2
        treeModules.Nodes("nodeFinance").Image = My.Resources.savings
        treeModules.Nodes("nodeBOM").Image = My.Resources.family_tree
        treeModules.Nodes("nodeCapacityPlanning").Image = My.Resources.sketch
        treeModules.Nodes("nodeLCS").Image = My.Resources.qr_code
        treeModules.Nodes("nodeProduction").Image = My.Resources.product
        treeModules.Nodes("nodeReports").Image = My.Resources.prescription

        treeModules.Nodes("nodeAdministration").Nodes("nodeSettings").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeAdministration").Nodes("nodeUserManagement").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeAdministration").Nodes("nodeConversionRate").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeFinance").Nodes("nodeCheckVoucher").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeFinance").Nodes("nodeCosting").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeBOM").Nodes("nodeBOMProvider").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeBOM").Nodes("nodeCostTable").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeCapacityPlanning").Nodes("nodeActualGroupAssignment").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeCapacityPlanning").Nodes("nodeLongTermForecast").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeCapacityPlanning").Nodes("nodeInvoice").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeCapacityPlanning").Nodes("nodeBudgetReference").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeCapacityPlanning").Nodes("nodeProductionPlanning").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeCapacityPlanning").Nodes("nodeCapacityForecast").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeCapacityPlanning").Nodes("nodeCustomerDemand").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeLCS").Nodes("nodeLCSProvider").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeLCS").Nodes("nodeCustomTuning").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeInventoryTransfer").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeLineIssuance").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeProdDailyRepSRC").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeWeldingDailyRepSRC").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeFWDailyRepSRC").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeATDailyRepSRC").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeProductionOutputGroup").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeProductionOutput").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeInventoryMonitoring").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeCountingReference").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeProduction").Nodes("nodeKanbanCreator").Image = My.Resources.folder__1___1_
        treeModules.Nodes("nodeReports").Nodes("nodeInventory").Image = My.Resources.paper

        treeModules.Nodes("nodeReports").Nodes("nodeInventory").Nodes("nodeOnHandStock").Image = My.Resources.paper

        tvMasterData.Nodes("nodeMasterReference").Image = My.Resources.table
        tvMasterData.Nodes("nodeItemMasterData").Image = My.Resources.to_do_list
        tvMasterData.Nodes("nodeItemPerCustomer").Image = My.Resources.rate
        tvMasterData.Nodes("nodeItemPerModel").Image = My.Resources._3d_design
        tvMasterData.Nodes("nodeItemPerProcess").Image = My.Resources.process
        tvMasterData.Nodes("nodeRMPriceList").Image = My.Resources.creative
        tvMasterData.Nodes("nodeItemCodeHistory").Image = My.Resources.ancient_scroll
        tvMasterData.Nodes("nodeBOMMasterData").Image = My.Resources.ecology_and_environment
        tvMasterData.Nodes("nodeMaterialPricelist").Image = My.Resources.cost
        tvMasterData.Nodes("nodeLineGroupSharing").Image = My.Resources.line_group_sharing
        tvMasterData.Nodes("nodeLinePerWarehouse").Image = My.Resources.conveyor__1_
        tvMasterData.Nodes("nodeWarehousing").Image = My.Resources.warehouse
        tvMasterData.Nodes("nodeProcessComPerProcess").Image = My.Resources.subprocess
        tvMasterData.Nodes("nodeGLAccounts").Image = My.Resources.ledger
        tvMasterData.Nodes("nodeBusinessPartners").Image = My.Resources.partner
        tvMasterData.Nodes("nodeCustomerStdLeadTime").Image = My.Resources.std_lead_time
        tvMasterData.Nodes("nodeBIRReference").Image = My.Resources.taxes
        tvMasterData.Nodes("nodeCustomerReference").Image = My.Resources.id_card

        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeCategoryList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeCustomerList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeLineList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeMachineList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeMakerList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeModelList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeOutputType").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeProcessList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeProcessComponentList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeShiftList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeUOMList").Image = My.Resources.folder__1___1_
        tvMasterData.Nodes("nodeMasterReference").Nodes("nodeWarehouseCodeList").Image = My.Resources.folder__1___1_

        leUsername.Text = Convert.ToString(currentUser.Item("fldUsername"))
        leUserType.Text = Convert.ToString(currentUser.Item("fldUserType"))
        leDatabase.Text = My.Settings.setDBName

    End Sub

    Private Sub frmBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If RadMessageBox.Show("Are you sure you want to quit?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.No Then
            isLogOut = False
            e.Cancel = True


        Else


            For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1

                Dim frm As Form = Application.OpenForms(i)

                If frm IsNot Me Then

                    frm.Close()

                End If

            Next
            If isLogOut Then
                FrmLogin.Show()
            End If

        End If




    End Sub

    Private Sub cddTheme_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles cddTheme.SelectedIndexChanged
        Dim theme As String = "CrystalDark"

        If cddTheme.Text = "Dark" Then
            theme = "CrystalDark"
        Else
            theme = "Crystal"
        End If

        My.Settings.setTheme = theme
        My.Settings.Save()

        Dim frm As Form

        For Each frm In My.Application.OpenForms
            Slipknot.changeTheme(frm)
        Next
    End Sub

    Private Sub tvMasterData_NodeMouseClick(sender As Object, e As RadTreeViewEventArgs) Handles tvMasterData.NodeMouseClick
        formNameToOpen = tvMasterData.SelectedNode.Name

        If bwFormOpener.IsBusy = False Then
            bwFormOpener.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwFormOpener_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwFormOpener.DoWork

        For x As Integer = 0 To 3
            Threading.Thread.Sleep(delay)
        Next

    End Sub

    Private Sub bwFormOpener_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwFormOpener.RunWorkerCompleted
        txtSearch.Text = String.Empty

        Select Case formNameToOpen
            Case "nodeSettings"
                openSettings()
            Case "nodeUserManagement"
                openUser()
            Case "nodeConversionRate"
                openConversionRate()
            Case "nodeBOMProvider"
                openItemBOM()
            Case "nodeCostTable"
                openCostTable()
            Case "nodeActualGroupAssignment"
                openActualGroupAssignment()
            Case "nodeLCSProvider"
                openLCSCreator()
            Case "nodeCustomTuning"
                openCustomTuning()
            Case "nodeCategoryList"
                openCategoryList()
            Case "nodeCustomerList"
                openCustomerList()
            Case "nodeLineList"
                openLineList()
            Case "nodeMachineList"
                openMachineList()
            Case "nodeMakerList"
                openMakerList()
            Case "nodeModelList"
                openModelList()
            Case "nodeOutputType"
                openOutputType()
            Case "nodeProcessList"
                openProcessList()
            Case "nodeProcessComponentList"
                openProcessComponentList()
            Case "nodeShiftList"
                openShiftList()
            Case "nodeUOMList"
                openUOMList()
            Case "nodeWarehouseCodeList"
                openWarehouseCodeList()
            Case "nodeItemMasterData"
                openItemMasterData()
            Case "nodeItemPerCustomer"
                openItemMasterPerCustomer()
            Case "nodeItemPerModel"
                openItemPerModel()
            Case "nodeItemPerProcess"
                openProcessPerItem()
            Case "nodeRMPriceList"
                openProcessPerRM()
            Case "nodeItemCodeHistory"
                openCompanyPartNoHistory()
            Case "nodeBOMMasterData"
                openBOMMaster()
            Case "nodeMaterialPricelist"
                openMaterialPriceList()
            Case "nodeLineGroupSharing"
                openLineGroupSharing()
            Case "nodeLinePerWarehouse"
                openLinePerWarehouse()
            Case "nodeWarehousing"
                openWarehousing()
            Case "nodeGLAccounts"
                openGLAccounts()
            Case "nodeBusinessPartners"
                openBusinessPartners()
            Case "nodeInventoryTransfer"
                openInventoryTransfer()
            Case "nodeCapacityForecast"
                openCapacityForecast()
            Case "nodeLongTermForecast"
                openLongTermForecast()
            Case "nodeInvoice"
                openInvoice()
            Case "nodeProdDailyRepSRC"
                openProdDailyRepSRC()
            Case "nodeWeldingDailyRepSRC"
                openWeldingDailyRepSRC()
            Case "nodeFWDailyRepSRC"
                openPWDailyRepSRC()
            Case "nodeATDailyRepSRC"
                openATDailyRepSRC()
            Case "nodeProductionOutput"
                openProductionOutput()
            Case "nodeProductionOutputGroup"
                openProductionOutputGroup()
            Case "nodeLineIssuance"
                openLineIssuance()
            Case "nodeInventoryMonitoring"
                openInventoryMonitoring()
            Case "nodeCountingReference"
                openCountingReference()
            Case "nodeKanbanCreator"
                openKanbanCreator()
            Case "nodeOnHandStock"
                openOnHandStockMonitoring()
            Case "changePassword"
                openChangePassword()
            Case "nodeCustomerDemand"
                openCustomerDemand()
            Case "nodeProcessComPerProcess"
                openProcessComPerProcess()
            Case "nodeCheckVoucher"
                openCheckVoucher()
            Case "nodeCosting"
                openCosting()
            Case "nodeCustomerStdLeadTime"
                openCustomerStdLeadTime()
            Case "nodeBIRReference"
                openBIRReference()
            Case "nodeCustomerReference"
                openCustomerReference()
        End Select
    End Sub

    Private Sub frmBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If txtSearch.Text <> String.Empty Then

                    If String.Equals(txtSearch.Text, "settings", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeSettings"
                    ElseIf String.Equals(txtSearch.Text, "user management", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeUserManagement"
                    ElseIf String.Equals(txtSearch.Text, "conversion rate", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeConversionRate"
                    ElseIf String.Equals(txtSearch.Text, "bom provider", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeBOMProvider"
                    ElseIf String.Equals(txtSearch.Text, "actual group assignment", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeActualGroupAssignment"
                    ElseIf String.Equals(txtSearch.Text, "budget reference", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeBudgetReference"
                    ElseIf String.Equals(txtSearch.Text, "production planning", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeProductionPlanning"
                    ElseIf String.Equals(txtSearch.Text, "capacity forecast", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeCapacityForecast"
                    ElseIf String.Equals(txtSearch.Text, "lcs provider", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeLCSProvider"
                    ElseIf String.Equals(txtSearch.Text, "custom tuning", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeCustomTuning"
                    ElseIf String.Equals(txtSearch.Text, "category list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeCategoryList"
                    ElseIf String.Equals(txtSearch.Text, "customer list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeCustomerList"
                    ElseIf String.Equals(txtSearch.Text, "line list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeLineList"
                    ElseIf String.Equals(txtSearch.Text, "machine list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeMachineList"
                    ElseIf String.Equals(txtSearch.Text, "maker list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeMakerList"
                    ElseIf String.Equals(txtSearch.Text, "model list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeModelList"
                    ElseIf String.Equals(txtSearch.Text, "output type", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeOutputType"
                    ElseIf String.Equals(txtSearch.Text, "process list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeProcessList"
                    ElseIf String.Equals(txtSearch.Text, "process components", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeProcessComponentList"
                    ElseIf String.Equals(txtSearch.Text, "shift list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeShiftList"
                    ElseIf String.Equals(txtSearch.Text, "uom list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeUOMList"
                    ElseIf String.Equals(txtSearch.Text, "warehouse code list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeWarehouseCodeList"
                    ElseIf String.Equals(txtSearch.Text, "item master data", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeItemMasterData"
                    ElseIf String.Equals(txtSearch.Text, "item per customer", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeItemPerCustomer"
                    ElseIf String.Equals(txtSearch.Text, "item per model", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeItemPerModel"
                    ElseIf String.Equals(txtSearch.Text, "item per process", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeItemPerProcess"
                    ElseIf String.Equals(txtSearch.Text, "rm price list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeRMPriceList"
                    ElseIf String.Equals(txtSearch.Text, "item code history", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeItemCodeHistory"
                    ElseIf String.Equals(txtSearch.Text, "bom master data", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeBOMMasterData"
                    ElseIf String.Equals(txtSearch.Text, "material price list", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeMaterialPricelist"
                    ElseIf String.Equals(txtSearch.Text, "line group sharing", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeLineGroupSharing"
                    ElseIf String.Equals(txtSearch.Text, "line per warehouse", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeLinePerWarehouse"
                    ElseIf String.Equals(txtSearch.Text, "warehousing", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeWarehousing"
                    ElseIf String.Equals(txtSearch.Text, "gl accounts", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeGLAccounts"
                    ElseIf String.Equals(txtSearch.Text, "business partners", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeBusinessPartners"
                    ElseIf String.Equals(txtSearch.Text, "capacity forecast", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeCapacityForecast"
                    ElseIf String.Equals(txtSearch.Text, "inventory transfer", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeInventoryTransfer"
                    ElseIf String.Equals(txtSearch.Text, "line issuance", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeLineIssuance"
                    ElseIf String.Equals(txtSearch.Text, "production output", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeProductionOutput"
                    ElseIf String.Equals(txtSearch.Text, "production output group", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeProductionOutputGroup"
                    ElseIf String.Equals(txtSearch.Text, "inventory monitoring", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeInventoryMonitoring"
                    ElseIf String.Equals(txtSearch.Text, "counting reference", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeCountingReference"
                    ElseIf String.Equals(txtSearch.Text, "kanban creator", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "nodeKanbanCreator"
                    ElseIf String.Equals(txtSearch.Text, "change password", StringComparison.InvariantCultureIgnoreCase) Then
                        formNameToOpen = "changePassword"
                    ElseIf String.Equals(txtSearch.Text, "logout", StringComparison.InvariantCultureIgnoreCase) Then
                        isLogOut = True
                        Me.Close()
                    ElseIf String.Equals(txtSearch.Text, "exit", StringComparison.InvariantCultureIgnoreCase) Then
                        isLogOut = False
                        Me.Close()
                    End If

                    If bwFormOpener.IsBusy = False Then
                        bwFormOpener.RunWorkerAsync()
                    End If

                End If
        End Select
    End Sub

    Private Sub miItemMasterData_Click(sender As Object, e As EventArgs) Handles miItemMasterData.Click
        openItemMasterData()
    End Sub

    Private Sub miCategoryList_Click(sender As Object, e As EventArgs) Handles miCategoryList.Click
        openCategoryList()
    End Sub

    Private Sub miCustomerList_Click(sender As Object, e As EventArgs) Handles miCustomerList.Click
        openCustomerList()
    End Sub

    Private Sub miLineList_Click(sender As Object, e As EventArgs) Handles miLineList.Click
        openLineList()
    End Sub

    Private Sub miMachineList_Click(sender As Object, e As EventArgs) Handles miMachineList.Click
        openMachineList()
    End Sub

    Private Sub miMakerList_Click_1(sender As Object, e As EventArgs) Handles miMakerList.Click
        openMakerList()
    End Sub

    Private Sub miModelList_Click_1(sender As Object, e As EventArgs) Handles miModelList.Click
        openModelList()
    End Sub

    Private Sub miProcessList_Click(sender As Object, e As EventArgs) Handles miProcessList.Click
        openProcessList()
    End Sub

    Private Sub miShiftList_Click(sender As Object, e As EventArgs) Handles miShiftList.Click
        openShiftList()
    End Sub

    Private Sub miUOMList_Click(sender As Object, e As EventArgs) Handles miUOMList.Click
        openUOMList()
    End Sub

    Private Sub miItemPerCustomer_Click(sender As Object, e As EventArgs) Handles miItemPerCustomer.Click
        openItemMasterPerCustomer()
    End Sub

    Private Sub miItemPerModel_Click(sender As Object, e As EventArgs) Handles miItemPerModel.Click
        openItemPerModel()
    End Sub

    Private Sub miItemPerProcess_Click(sender As Object, e As EventArgs) Handles miItemPerProcess.Click
        openProcessPerItem()
    End Sub

    Private Sub miItemCodeHistory_Click(sender As Object, e As EventArgs) Handles miItemCodeHistory.Click
        openCompanyPartNoHistory()
    End Sub

    Private Sub miBOMMasterData_Click(sender As Object, e As EventArgs) Handles miBOMMasterData.Click
        openBOMMaster()
    End Sub

    Private Sub miCascade_Click(sender As Object, e As EventArgs) Handles miCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub miTileHorizontal_Click(sender As Object, e As EventArgs) Handles miTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub miTileVertical_Click(sender As Object, e As EventArgs) Handles miTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub miChangePassword_Click(sender As Object, e As EventArgs) Handles miChangePassword.Click
        openChangePassword()
    End Sub

    Private Sub miLogOut_Click(sender As Object, e As EventArgs) Handles miLogOut.Click
        isLogOut = True
        Me.Close()
    End Sub

    Private Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Me.Close()
    End Sub

    Private Sub miAboutMIA_Click(sender As Object, e As EventArgs) Handles miAboutMIA.Click
        If Slipknot.IsFormOpen(FrmSystemInfo) Then
            FrmSystemInfo.Focus()
        Else
            FrmSystemInfo.Show(Me)
        End If
    End Sub

    Private Sub miViewHelp_Click(sender As Object, e As EventArgs) Handles miViewHelp.Click
        Try
            Process.Start("manual.pdf")
        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub miWarehouseCodeList_Click_1(sender As Object, e As EventArgs) Handles miWarehouseCodeList.Click
        openWarehouseCodeList()
    End Sub

    Private Sub miWarehousing_Click(sender As Object, e As EventArgs) Handles miWarehousing.Click
        openWarehousing()
    End Sub

    Private Sub openCustomerDemand()

        If Slipknot.IsFormOpen(FrmCustomerDemand) Then
            FrmCustomerDemand.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(leUsername.Text, "fldModCustomerDemand")

            If check <> "NA" Then
                FrmCustomerDemand.MdiParent = Me
                FrmCustomerDemand.lePermission.Text = check
                FrmCustomerDemand.Show()
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub openProcessComPerProcess()

        If Slipknot.IsFormOpen(FrmProcessComPerProcess) Then
            FrmProcessComPerProcess.Focus()
        Else
            FrmProcessComPerProcess.MdiParent = Me
            'FrmProcessComPerProcess.lePermission.Text = check
            FrmProcessComPerProcess.Show()
        End If

    End Sub

    Private Sub openOnHandStockMonitoring()

        If Slipknot.IsFormOpen(FrmGenProdInvOnHandSummaryRep) Then
            FrmGenProdInvOnHandSummaryRep.Focus()
        Else
            FrmGenProdInvOnHandSummaryRep.MdiParent = Me
            FrmGenProdInvOnHandSummaryRep.Show()
        End If

    End Sub

    Private Sub miLinePerWarehouse_Click(sender As Object, e As EventArgs) Handles miLinePerWarehouse.Click
        openLinePerWarehouse()
    End Sub

    Private Sub miOutputType_Click(sender As Object, e As EventArgs) Handles miOutputType.Click
        openOutputType()
    End Sub

    Private Sub miMaterialPriceList_Click(sender As Object, e As EventArgs) Handles miMaterialPriceList.Click
        openMaterialPriceList()
    End Sub

    Private Sub miLineGroupSharing_Click(sender As Object, e As EventArgs) Handles miLineGroupSharing.Click
        openLineGroupSharing()
    End Sub

    Private Sub miProcessComponentList_Click(sender As Object, e As EventArgs) Handles miProcessComponentList.Click
        openProcessComponentList()
    End Sub

    Private Sub miRMPerProcess_Click(sender As Object, e As EventArgs) Handles miRMPerProcess.Click
        openProcessPerRM()
    End Sub
End Class
