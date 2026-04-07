Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class frmProdOutputGroup

    Private myData As DataTable
    Private Sub frmProdOutputGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        loadItemMaster()
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MMM dd, yyyy"
        dtpDate.Value = Today

        loadShift()
        loadFrom()
        loadLine()

        readyGrid()
        loadTeamLeader()
        loadSubLeader()
    End Sub
    Private Sub loadItemMaster()

        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim dtProdLinq = (From x In dtProduct.AsEnumerable() Where x.Field(Of String)("fldItemCode").Contains("FG") Select x).ToList()

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 200
        mcbPartName.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 160
        mcbPartName.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        mcbPartName.DataSource = dtProdLinq.CopyToDataTable()
        mcbPartName.ValueMember = "fldItemCode"
        mcbPartName.DisplayMember = "fldPartName"
        mcbPartName.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbPartName.AutoFilter = True
        mcbPartName.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim PartName As New FilterDescriptor()
        PartName.PropertyName = "fldPartName"
        PartName.Operator = FilterOperator.Contains
        mcbPartName.EditorControl.MasterTemplate.FilterDescriptors.Add(PartName)

    End Sub

    Private Sub loadTeamLeader()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllBSSTL")


        Dim fldName As New GridViewTextBoxColumn("NAME")
        fldName.FieldName = "fldName"
        fldName.Width = 150
        ddlTeamLeader.MultiColumnComboBoxElement.Columns.Add(fldName)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO")
        fldEmpNo.FieldName = "fldEmpNo"
        fldEmpNo.Width = 100
        ddlTeamLeader.MultiColumnComboBoxElement.Columns.Add(fldEmpNo)

        ddlTeamLeader.DataSource = dt
        ddlTeamLeader.ValueMember = "fldName"
        ddlTeamLeader.DisplayMember = "fldName"
        ddlTeamLeader.MultiColumnComboBoxElement.DropDownWidth = 280

        ddlTeamLeader.AutoFilter = True
        ddlTeamLeader.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldName"
        desc.Operator = FilterOperator.Contains
        ddlTeamLeader.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub
    Private Sub loadSubLeader()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllBSSSTL")


        Dim fldName As New GridViewTextBoxColumn("NAME")
        fldName.FieldName = "fldName"
        fldName.Width = 150
        ddlSubLeader.MultiColumnComboBoxElement.Columns.Add(fldName)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO")
        fldEmpNo.FieldName = "fldEmpNo"
        fldEmpNo.Width = 100
        ddlSubLeader.MultiColumnComboBoxElement.Columns.Add(fldEmpNo)

        ddlSubLeader.DataSource = dt
        ddlSubLeader.ValueMember = "fldName"
        ddlSubLeader.DisplayMember = "fldName"
        ddlSubLeader.MultiColumnComboBoxElement.DropDownWidth = 280

        ddlSubLeader.AutoFilter = True
        ddlSubLeader.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldName"
        desc.Operator = FilterOperator.Contains
        ddlSubLeader.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)


    End Sub
    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = True
        gvData.Columns.Add(fldId)

        Dim fldTitle As New GridViewTextBoxColumn("Title")
        fldTitle.FieldName = "fldTitle"
        fldTitle.Width = 220
        gvData.Columns.Add(fldTitle)

        Dim fldDate As New GridViewDateTimeColumn("Date")
        fldDate.FieldName = "fldDate"
        fldDate.Width = 110
        fldDate.Format = DateTimePickerFormat.Custom
        fldDate.CustomFormat = "MMM dd, yyyy"
        gvData.Columns.Add(fldDate)
        gvData.Columns("fldDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldShift As New GridViewTextBoxColumn("Shift") With {
            .FieldName = "fldShift",
            .Width = 150
        }
        gvData.Columns.Add(fldShift)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name") With {
            .FieldName = "fldPartName",
            .Width = 150
        }
        gvData.Columns.Add(fldPartName)

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code") With {
            .FieldName = "fldItemCode",
            .Width = 150
        }
        gvData.Columns.Add(fldItemCode)

        Dim fldSubLeader As New GridViewTextBoxColumn("Sub Leader")
        fldSubLeader.FieldName = "fldSubLeader"
        fldSubLeader.Width = 160
        gvData.Columns.Add(fldSubLeader)

        Dim fldTeamLeader As New GridViewTextBoxColumn("Team Leader")
        fldTeamLeader.FieldName = "fldTeamLeader"
        fldTeamLeader.Width = 160
        gvData.Columns.Add(fldTeamLeader)

        Dim warehouse As New GridViewTextBoxColumn("Warehouse")
        warehouse.FieldName = "whse"
        warehouse.Width = 150
        gvData.Columns.Add(warehouse)

        Dim line As New GridViewTextBoxColumn("Line")
        line.FieldName = "line"
        line.Width = 120
        gvData.Columns.Add(line)

        Dim fldDateAdded As New GridViewDateTimeColumn("Date Added")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("Added By")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        gvData.Columns.Add(fldAddedBy)


        Dim fldLastDateUpdate As New GridViewDateTimeColumn("Last Updated Date")
        fldLastDateUpdate.FieldName = "fldLastDateUpdate"
        fldLastDateUpdate.Width = 170
        fldLastDateUpdate.Format = DateTimePickerFormat.Custom
        fldLastDateUpdate.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldLastDateUpdate)
        gvData.Columns("fldLastDateUpdate").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldLastUpdatedBy As New GridViewTextBoxColumn("Last Update By")
        fldLastUpdatedBy.FieldName = "fldLastUpdatedBy"
        fldLastUpdatedBy.Width = 150
        gvData.Columns.Add(fldLastUpdatedBy)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.ShowFilteringRow = True
        Else
            gvData.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
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
        mcbWarehouse.MultiColumnComboBoxElement.Columns.Add(fldDescription)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 100
        mcbWarehouse.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbWarehouse.DataSource = dt
        mcbWarehouse.ValueMember = "fldCode"
        mcbWarehouse.DisplayMember = "fldDescription"
        mcbWarehouse.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbWarehouse.AutoFilter = True
        mcbWarehouse.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldDescription"
        desc.Operator = FilterOperator.Contains
        mcbWarehouse.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub

    Private Sub loadShift()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllShifts")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldShiftName", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldShiftName As New GridViewTextBoxColumn("SHIFT")
        fldShiftName.FieldName = "fldShiftName"
        fldShiftName.Width = 150
        mcbShift.MultiColumnComboBoxElement.Columns.Add(fldShiftName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.IsVisible = False
        fldCode.Width = 100
        mcbShift.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbShift.DataSource = dt
        mcbShift.ValueMember = "fldCode"
        mcbShift.DisplayMember = "fldShiftName"
        mcbShift.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbShift.AutoFilter = True
        mcbShift.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor()
        desc.PropertyName = "fldShiftName"
        desc.Operator = FilterOperator.Contains
        mcbShift.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub

    Private Sub loadLine()

        Dim dt As DataTable = Slipknot.dbSelect("SP_SelectAllLines")

        Dim dt2 As New DataTable
        dt2.Columns.Add("fldId", GetType(Integer))
        dt2.Columns.Add("fldCode", GetType(String))
        dt2.Columns.Add("fldLineName", GetType(String))
        dt2.Columns.Add("fldDateAdded", GetType(DateTime))
        dt2.Columns.Add("fldAddedBy", GetType(String))

        dt2.Rows.Add(0, DBNull.Value, "", "2016-01-01 00:01:01", "")

        dt.Merge(dt2, False)

        dt.DefaultView.Sort = "fldId ASC"

        Dim fldLineName As New GridViewTextBoxColumn("LINE NAME")
        fldLineName.FieldName = "fldLineName"
        fldLineName.Width = 150
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldLineName)

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 100
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbLine.DataSource = dt
        mcbLine.ValueMember = "fldCode"
        mcbLine.DisplayMember = "fldLineName"
        mcbLine.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbLine.AutoFilter = True
        mcbLine.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor()
        name.PropertyName = "fldLineName"
        name.Operator = FilterOperator.Contains
        mcbLine.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If BulletForMyValentine.isRW("fldModProductionOutput") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If txtTitle.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Invalid title", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtTitle.Select()
            Exit Sub
        End If

        If mcbWarehouse.Text = "" Then
            RadMessageBox.Show("Warehouse cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbWarehouse.Select()
            Exit Sub
        End If

        If mcbLine.Text = "" Then
            RadMessageBox.Show("Line cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbLine.Select()
            Exit Sub
        End If

        If mcbShift.Text = "" Then
            RadMessageBox.Show("Shift cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbShift.Select()
            Exit Sub
        End If

        If txtMaterialHandler.Text = "" Then
            RadMessageBox.Show("Material Handler be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtMaterialHandler.Select()
            Exit Sub
        End If

        If KillSwitch.addProdOutputGroup(txtTitle.Text, dtpDate.Value, ddlSubLeader.Text, ddlTeamLeader.Text, Convert.ToString(mcbWarehouse.SelectedValue), Convert.ToString(mcbLine.SelectedValue), Convert.ToString(mcbPartName.Text), txtItemCode.Text, Convert.ToString(mcbShift.Text), txtMaterialHandler.Text) Then
            bwLoadData.RunWorkerAsync()

            txtTitle.Clear()
            'ddlSubLeader.SelectedValue = -1
            'ddlTeamLeader.SelectedValue = -1

            txtTitle.Focus()
        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        myData = Slipknot.dbSelectManual("SELECT 
                                          T0.fldId,
                                          T0.fldTitle,
                                          T0.fldDate,
                                          T0.fldSubLeader,
                                          T0.fldTeamLeader,
                                          T0.fldWhseCode,
                                          T0.fldLine,
                                          T0.fldDateAdded,
                                          T0.fldAddedBy,
                                          T0.fldPartName,
                                          T0.fldItemCode,
                                          T0.fldShift,
                                          (SELECT fldDescription FROM tblWarehouseCode WHERE fldCode = T0.fldWhseCode LIMIT 1) AS whse,
                                          (SELECT fldLineName FROM tblLines WHERE fldCode = T0.fldLine LIMIT 1) AS line
                                          FROM tblProductionOutputGroup T0 order by T0.fldId desc")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub frmProdOutputGroup_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
        mcbPartName.SelectedIndex = -1
    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If

    End Sub

    Private Sub bwDelete_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDelete.DoWork

        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwDelete.ReportProgress(Convert.ToInt32(percent))
        Next

        KillSwitch.deleteProdOutputGroup(id)

    End Sub

    Private Sub bwDelete_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDelete.RunWorkerCompleted

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        If BulletForMyValentine.isRW("fldModProductionOutput") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwDelete.IsBusy = False Then
                    bwDelete.RunWorkerAsync()
                End If
            End If
        End If

    End Sub

    Private Sub cbbAddProcess_Click(sender As Object, e As EventArgs) Handles cbbAddProcess.Click

        If Slipknot.IsFormOpen(FrmProdOutputGroupProc) Then
            FrmProdOutputGroupProc.Focus()
        Else
            Dim check As String = Slipknot.checkPermission(frmBase.leUsername.Text, "fldModProductionOutput")

            If check <> "NA" Then
                globalVariables.MainID = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                globalVariables.FGNoSelected = Convert.ToString(gvData.CurrentRow.Cells("fldItemCode").Value)
                globalVariables.ShiftSelect = Convert.ToString(gvData.CurrentRow.Cells("fldShift").Value)
                FrmProdOutputGroupProc.Show(Me)
            Else
                Slapshock.NoAccessToMasterMessage()
            End If
        End If

    End Sub

    Private Sub mcbPartName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbPartName.SelectedIndexChanged
        txtItemCode.Text = mcbPartName.SelectedValue
        txtTitle.Text = "DAILY REPORT FOR " + mcbPartName.Text + " POST PROCESS ASSEMBLY"
    End Sub

    Private Sub cbDailyReport_Click(sender As Object, e As EventArgs) Handles cbDailyReport.Click
        Dim drList As DataRow = Nothing

        Slipknot.addParameter("ID", Convert.ToString(gvData.CurrentRow.Cells("fldId").Value))
        Dim DTIDList As DataTable = Slipknot.dbSelect("SP_SelectBSSPOSPIDbyID")
        drList = DTIDList.Rows(0)


        reportType = 16
        'MessageBox.Show(Convert.ToString(drList.Item("POSPIDBeforeOven").ToString()))
        'MessageBox.Show(Convert.ToString(drList.Item("POSPIDAfterOven").ToString()))
        'MessageBox.Show(Convert.ToString(drList.Item("POSPIDPCB").ToString()))
        'MessageBox.Show(Convert.ToString(drList.Item("POSPIDSolder").ToString()))
        'MessageBox.Show(Convert.ToString(drList.Item("POSPIDBSS").ToString()))
        'MessageBox.Show(Convert.ToString(drList.Item("fldId").ToString()))

        Slipknot.addReportParameter("POSPIDBeforeOven", Convert.ToString(drList.Item("POSPIDBeforeOven").ToString()))
        Slipknot.addReportParameter("POSPIDAfterOven", Convert.ToString(drList.Item("POSPIDAfterOven").ToString()))
        Slipknot.addReportParameter("POSPIDPCB", Convert.ToString(drList.Item("POSPIDPCB").ToString()))
        Slipknot.addReportParameter("POSPIDSolder", Convert.ToString(drList.Item("POSPIDSolder").ToString()))
        Slipknot.addReportParameter("POSPIDBSS", Convert.ToString(drList.Item("POSPIDBSS").ToString()))
        Slipknot.addReportParameter("MainID", Convert.ToString(gvData.CurrentRow.Cells("fldId").Value))

        Dim frm As New FrmReport
        frm.Show()
    End Sub

    Private Sub cbTemplate_Click(sender As Object, e As EventArgs) Handles cbTemplate.Click

        If Slipknot.IsFormOpen(FrmBSSTemplate) Then
            FrmBSSTemplate.Focus()
        Else
            FrmBSSTemplate.Show(Me)
        End If
    End Sub

    Private Sub cbProcessDefect_Click(sender As Object, e As EventArgs) Handles cbProcessDefect.Click

        If Slipknot.IsFormOpen(FrmBSSProcessDefects) Then
            FrmBSSProcessDefects.Focus()
        Else
            FrmBSSProcessDefects.Show(Me)
        End If
    End Sub

    Private Sub cbbExport_Click(sender As Object, e As EventArgs) Handles cbbExport.Click

        SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim spreadStreamExport As GridViewSpreadStreamExport = New GridViewSpreadStreamExport(gvData)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport
            spreadStreamExport.ExportVisualSettings = True
            spreadStreamExport.RunExport(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
            RadMessageBox.SetThemeName(Me.gvData.ThemeName)
            RadMessageBox.Show(Me, "export success", "info", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbDefectTemplate_Click(sender As Object, e As EventArgs) Handles cbDefectTemplate.Click

        If Slipknot.IsFormOpen(FrmBSSTemplateAddDefect) Then
            FrmBSSTemplateAddDefect.Focus()
        Else
            FrmBSSTemplateAddDefect.Show(Me)
        End If
    End Sub

    Private Sub cbTeamLeader_Click(sender As Object, e As EventArgs) Handles cbTeamLeader.Click
        If Slipknot.IsFormOpen(FrmBSSTL) Then
            FrmBSSTL.Focus()
        Else
            FrmBSSTL.Show(Me)
        End If
    End Sub
End Class
