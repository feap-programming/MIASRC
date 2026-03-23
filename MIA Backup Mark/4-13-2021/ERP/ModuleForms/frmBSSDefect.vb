Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmBSSDefect
    Private Sub FrmBSSDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        loadProcessComPerProcess()
        loadDefectList()
        readyGrid()
    End Sub

    Private Sub FrmBSSDefect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchBSSDefect()
        mcbAssemblyProcessName.SelectedIndex = -1
        ddlProgDefect.SelectedIndex = -1
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If txtPOSPID.Text = "" Or txtMainID.Text = "" Then
            RadMessageBox.Show("Close this module and open it again, if this error happens again please contact MIS for support", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            seDefect.Select()
            Exit Sub
        End If
        If mcbAssemblyProcessName.SelectedValue Is Nothing Then
            RadMessageBox.Show("Assembly process name cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbAssemblyProcessName.Select()
            Exit Sub
        End If
        If ddlProgDefect.SelectedValue Is Nothing Then
            RadMessageBox.Show("Progress defects cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            ddlProgDefect.Select()
            Exit Sub
        End If
        If seDefect.Value = 0 Then
            RadMessageBox.Show("Zero Defect is not allowed", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            seDefect.Select()
            Exit Sub
        End If
        If ddlDefectCategory.Text = "" Then
            RadMessageBox.Show("Defects category cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            seDefect.Select()
            Exit Sub
        End If

        AddBSSDefect()
        FetchBSSDefect()
    End Sub
    Private Sub AddBSSDefect()
        Slipknot.addParameter("MainID", Convert.ToInt32(txtMainID.Text))
        Slipknot.addParameter("POSPID", Convert.ToInt32(txtPOSPID.Text))
        Slipknot.addParameter("ProcessDefect", Convert.ToString(ddlProgDefect.Text))
        Slipknot.addParameter("ProcessCode", Convert.ToString(mcbAssemblyProcessName.SelectedValue))
        Slipknot.addParameter("PartName", Convert.ToString(mcbAssemblyProcessName.Text))
        Slipknot.addParameter("DefectQTY", Convert.ToString(seDefect.Value))
        Slipknot.addParameter("DefectCategory", Convert.ToString(ddlDefectCategory.Text))

        Slipknot.dbAED("SP_InsertBSSDefect")
    End Sub
    Private Sub FetchBSSDefect()
        Slipknot.addParameter("POSPID", txtPOSPID.Text)
        gvData.DataSource = Slipknot.dbSelect("SP_SelectBSSDefectByPOSPID")
        leCountRec.Text = gvData.Rows.Count
    End Sub
    Private Sub readyGrid()
        Dim fldId As New GridViewDecimalColumn("MainID") With {
            .FieldName = "fldMainID",
            .IsVisible = False
        }
        gvData.Columns.Add(fldId)

        Dim fldPOSPID As New GridViewDecimalColumn("POSPID") With {
            .FieldName = "fldPOSPID",
            .IsVisible = False
        }
        gvData.Columns.Add(fldPOSPID)

        Dim fldPartName As New GridViewTextBoxColumn("Part Name") With {
            .FieldName = "fldPartName",
            .Width = 350
        }
        gvData.Columns.Add(fldPartName)

        Dim fldTitle As New GridViewTextBoxColumn("Process Defect") With {
            .FieldName = "fldProcessDefect",
            .Width = 300
        }
        gvData.Columns.Add(fldTitle)

        Dim fldDefectQTY As New GridViewTextBoxColumn("QTY") With {
            .FieldName = "fldDefectQTY",
            .Width = 100
        }
        gvData.Columns.Add(fldDefectQTY)

        Dim fldDefectCategory As New GridViewTextBoxColumn("Category")
        fldDefectCategory.FieldName = "fldDefectCategory"
        fldDefectCategory.Width = 120
        gvData.Columns.Add(fldDefectCategory)


        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub loadProcessComPerProcess()

        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllPComponentList")

        Dim fldProcessCode As New GridViewTextBoxColumn("Code")
        fldProcessCode.FieldName = "fldCode"
        fldProcessCode.Width = 70
        mcbAssemblyProcessName.MultiColumnComboBoxElement.Columns.Add(fldProcessCode)

        Dim processName As New GridViewTextBoxColumn("Process Name")
        processName.FieldName = "fldName"
        processName.Width = 250
        mcbAssemblyProcessName.MultiColumnComboBoxElement.Columns.Add(processName)

        mcbAssemblyProcessName.DataSource = dtProcess
        mcbAssemblyProcessName.ValueMember = "fldCode"
        mcbAssemblyProcessName.DisplayMember = "fldName"
        mcbAssemblyProcessName.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbAssemblyProcessName.AutoFilter = True
        mcbAssemblyProcessName.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim code As New FilterDescriptor("fldCode", FilterOperator.Contains, "")
        Dim name As New FilterDescriptor("fldName", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(code)
        compositeFilter.FilterDescriptors.Add(name)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.mcbAssemblyProcessName.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub
    Private Sub loadDefectList()

        Dim dtDefect As DataTable = Slipknot.dbSelect("SP_SelectBSSProcessDefectList")

        Dim DefectList As New GridViewTextBoxColumn("DEFECT LIST")
        DefectList.FieldName = "fldDefect"
        DefectList.Width = 250
        ddlProgDefect.MultiColumnComboBoxElement.Columns.Add(DefectList)

        ddlProgDefect.DataSource = dtDefect
        ddlProgDefect.ValueMember = "fldDefect"
        ddlProgDefect.DisplayMember = "fldDefect"
        ddlProgDefect.MultiColumnComboBoxElement.DropDownWidth = 300

        ddlProgDefect.AutoFilter = True
        ddlProgDefect.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim Defect As New FilterDescriptor("fldDefect", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(Defect)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.ddlProgDefect.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        FetchBSSDefect()
    End Sub
End Class
