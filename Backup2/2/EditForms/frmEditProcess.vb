Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmEditProcess


    Private Sub FrmEditProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadColor()
        loadProcess()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub loadProcess()

        Slipknot.addParameter("parId", txtID.Text)
        Dim process As DataTable = Slipknot.dbSelect("SP_SelectProcessByID")

        If process.Rows.Count > 0 Then

            txtCode.Text = Convert.ToString(process.Rows(0).Item("fldCode"))
            txtProcessName.Text = Convert.ToString(process.Rows(0).Item("fldProcessName"))
            sePriority.Value = Convert.ToInt32(process.Rows(0).Item("fldPriority"))
            mcbColor.SelectedValue = Convert.ToString(process.Rows(0).Item("fldColor"))
            chkHideInBOM.Checked = Convert.ToBoolean(process.Rows(0).Item("fldHideInBOM"))

        End If

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If txtProcessName.Text = String.Empty Then
            RadMessageBox.Show("Process name cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If mcbColor.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select color properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parId", txtID.Text)
        Slipknot.addParameter("parProcessName", txtProcessName.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parPriority", sePriority.Value)
        Slipknot.addParameter("parColor", mcbColor.SelectedValue)
        Slipknot.addParameter("parHideInBOM", chkHideInBOM.Checked)

        If Slipknot.dbAED("SP_UpdateProcess") Then
            RadMessageBox.Show("Updated Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Private Sub loadColor()

        Dim dtColors As DataTable = Slipknot.dbSelect("SP_SelectAllColors")

        Dim fldColor As New GridViewColorColumn("COLOR")
        fldColor.FieldName = "fldColor"
        mcbColor.MultiColumnComboBoxElement.Columns.Add(fldColor)

        mcbColor.DataSource = dtColors
        mcbColor.DisplayMember = "fldColor"
        mcbColor.SelectedValue = "fldColor"

        mcbColor.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        mcbColor.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        mcbColor.AutoFilter = True

        Dim filterColor As New FilterDescriptor
        filterColor.PropertyName = "fldColor"
        filterColor.Operator = FilterOperator.Contains
        mcbColor.EditorControl.MasterTemplate.FilterDescriptors.Add(filterColor)
    End Sub
End Class
