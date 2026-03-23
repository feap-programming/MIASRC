Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmEditHourlyProdMnt
    Private Sub FrmEditHourlyProdMnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        loadShift()
        GetData()
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

        Dim fldShiftName As New GridViewTextBoxColumn("SHIFT") With {
            .FieldName = "fldShiftName",
            .Width = 150
        }
        mcbShift.MultiColumnComboBoxElement.Columns.Add(fldShiftName)

        Dim fldCode As New GridViewTextBoxColumn("CODE") With {
            .FieldName = "fldCode",
            .IsVisible = False,
            .Width = 100
        }
        mcbShift.MultiColumnComboBoxElement.Columns.Add(fldCode)

        mcbShift.DataSource = dt
        mcbShift.ValueMember = "fldCode"
        mcbShift.DisplayMember = "fldShiftName"
        mcbShift.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbShift.AutoFilter = True
        mcbShift.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor With {
            .PropertyName = "fldShiftName",
            .Operator = FilterOperator.Contains
        }
        mcbShift.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

    End Sub
    Private Sub GetData()

        mcbShift.Text = FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldShift").Value
        rtpFrom.Value = Convert.ToDateTime(FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldTimeFrom").Value.ToString)
        rtpTo.Value = Convert.ToDateTime(FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldTimeTo").Value.ToString)
        sePlan.Value = FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldPlan").Value
        seActual.Value = FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldActual").Value
        seDeviation.Value = FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldDeviation").Value
        txtCheckby.Text = FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldCheckby").Value
        txtRemarks.Text = FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldRemarks").Value
        mcbTitle.Text = FrmHourlyProdMnt.mcbTitle.Text
        mcbProcess.Text = FrmHourlyProdMnt.mcbProcess.Text
        txtHID.Text = FrmHourlyProdMnt.gvData.CurrentRow.Cells("fldHID").Value
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult = RadMessageBox.Show(Me, "Are you sure to update record/s?", "Updating Records", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            If mcbShift.SelectedValue Is Nothing Then
                RadMessageBox.Show("Shift cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

                mcbShift.Select()
                Exit Sub
            End If
            UpdateHourlyProdMnt()
            FrmHourlyProdMnt.FetchHourlyProdMnt()
            RadMessageBox.Show("Updated Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
            Me.Close()
        End If

    End Sub
    Private Sub UpdateHourlyProdMnt()
        Slipknot.addParameter("HID", txtHID.Text)
        Slipknot.addParameter("Shift", Convert.ToString(mcbShift.Text))
        Slipknot.addParameter("TimeFrom", rtpFrom.Value)
        Slipknot.addParameter("TimeTo", rtpTo.Value)
        Slipknot.addParameter("Plan", sePlan.Value)
        Slipknot.addParameter("Actual", seActual.Value)
        Slipknot.addParameter("Deviation", seDeviation.Value)
        Slipknot.addParameter("Checkby", Convert.ToString(txtCheckby.Text))
        Slipknot.addParameter("Remarks", Convert.ToString(txtRemarks.Text))
        Slipknot.dbAED("SP_UpdateHourlyProdMnt")
    End Sub
End Class

