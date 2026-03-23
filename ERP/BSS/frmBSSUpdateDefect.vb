Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmBSSUpdateDefect
    Private Sub FrmBSSUpdateDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

    End Sub

    Private Sub FrmBSSUpdateDefect_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'mcbAssemblyProcessName.SelectedIndex = -1
        'ddlProgDefect.SelectedIndex = -1
        loadProcessComPerProcess()
        loadDefectList()
        GetDefectList()
    End Sub

    Public Sub GetDefectList()
        mcbAssemblyProcessName.Text = FrmBSSDefect.gvData.CurrentRow.Cells("fldPartName").Value
        mcbAssemblyProcessName.SelectedValue = FrmBSSDefect.gvData.CurrentRow.Cells("fldProcessCode").Value
        ddlProgDefect.Text = FrmBSSDefect.gvData.CurrentRow.Cells("fldProcessDefect").Value
        seDefect.Value = FrmBSSDefect.gvData.CurrentRow.Cells("fldDefectQTY").Value
        ddlDefectCategory.Text = FrmBSSDefect.gvData.CurrentRow.Cells("fldDefectCategory").Value
        txtDID.Text = FrmBSSDefect.gvData.CurrentRow.Cells("fldDID").Value
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
        UpdateBSSDefect()
    End Sub
    Private Sub UpdateBSSDefect()
        Slipknot.addParameter("DID", Convert.ToInt32(txtDID.Text))
        Slipknot.addParameter("ProcessDefect", Convert.ToString(ddlProgDefect.Text))
        Slipknot.addParameter("ProcessCode", Convert.ToString(mcbAssemblyProcessName.SelectedValue))
        Slipknot.addParameter("PartName", Convert.ToString(mcbAssemblyProcessName.Text))
        Slipknot.addParameter("DefectQTY", Convert.ToString(seDefect.Value))
        Slipknot.addParameter("DefectCategory", Convert.ToString(ddlDefectCategory.Text))

        Slipknot.dbAED("SP_BSSUpdateDefectbyID")
        RadMessageBox.Show("Successfully updated", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        FrmBSSDefect.FetchBSSDefect()
        Me.Close()
    End Sub
End Class
