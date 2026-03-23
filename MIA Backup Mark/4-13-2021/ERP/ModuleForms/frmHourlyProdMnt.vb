Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmHourlyProdMnt
    Private Sub FrmHourlyProdMnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        loadShift()
        readyGrid()
    End Sub

    Private Sub FrmHourlyProdMnt_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchHourlyProdMnt()
    End Sub
    Public Sub FetchHourlyProdMnt()
        Slipknot.addParameter("POSPID", txtPOSPID.Text)
        gvData.DataSource = Slipknot.dbSelect("SP_SelectHourlyProdMntbyPOSPID")
        leCountRec.Text = gvData.Rows.Count
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
    Private Sub AddHourlyProdMnt()
        Slipknot.addParameter("MainID", Convert.ToInt32(txtMainID.Text))
        Slipknot.addParameter("POSPID", Convert.ToInt32(txtPOSPID.Text))
        Slipknot.addParameter("Shift", Convert.ToString(mcbShift.Text))
        Slipknot.addParameter("TimeFrom", rtpFrom.Value)
        Slipknot.addParameter("TimeTo", rtpTo.Value)
        Slipknot.addParameter("Plan", sePlan.Value)
        Slipknot.addParameter("Actual", seActual.Value)
        Slipknot.addParameter("Deviation", seDeviation.Value)
        Slipknot.addParameter("Checkby", Convert.ToString(txtCheckby.Text))
        Slipknot.addParameter("Remarks", Convert.ToString(txtRemarks.Text))
        Slipknot.dbAED("SP_InsertHourlyProdMnt")
    End Sub
    Private Sub readyGrid()
        Dim fldHID As New GridViewDecimalColumn("HID") With {
            .FieldName = "fldHID",
            .IsVisible = False
        }
        gvData.Columns.Add(fldHID)

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

        Dim fldShift As New GridViewTextBoxColumn("Shift") With {
            .FieldName = "fldShift",
            .Width = 120,
            .IsVisible = True
        }
        gvData.Columns.Add(fldShift)
        Dim fldTimeFrom As New GridViewTextBoxColumn("Time From") With {
            .FieldName = "fldTimeFrom",
            .Width = 120,
            .IsVisible = True
        }
        gvData.Columns.Add(fldTimeFrom)
        Dim fldTimeTo As New GridViewTextBoxColumn("Time To") With {
            .FieldName = "fldTimeTo",
            .Width = 120,
            .IsVisible = True
        }
        gvData.Columns.Add(fldTimeTo)

        Dim fldPlan As New GridViewTextBoxColumn("Plan") With {
            .FieldName = "fldPlan",
            .Width = 120,
            .IsVisible = True
        }
        gvData.Columns.Add(fldPlan)

        Dim fldActual As New GridViewTextBoxColumn("Actual") With {
            .FieldName = "fldActual",
            .Width = 120,
            .IsVisible = True
        }
        gvData.Columns.Add(fldActual)

        Dim fldDeviation As New GridViewTextBoxColumn("Deviation") With {
            .FieldName = "fldDeviation",
            .Width = 120,
            .IsVisible = True
        }
        gvData.Columns.Add(fldDeviation)

        Dim fldCheckby As New GridViewTextBoxColumn("Check by") With {
            .FieldName = "fldCheckby",
            .Width = 180,
            .IsVisible = True
        }
        gvData.Columns.Add(fldCheckby)

        Dim fldRemarks As New GridViewTextBoxColumn("Remarks") With {
            .FieldName = "fldRemarks",
            .Width = 180,
            .IsVisible = True
        }
        gvData.Columns.Add(fldRemarks)


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
        If txtPOSPID.Text = "" Or txtMainID.Text = "" Then
            RadMessageBox.Show("Close this module and open it again, if this error happens again please contact MIS for support", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If
        If mcbShift.SelectedValue Is Nothing Then
            RadMessageBox.Show("Shift cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbShift.Select()
            Exit Sub
        End If
        AddHourlyProdMnt()
        FetchHourlyProdMnt()

        Dim dtFrom As DateTime = rtpFrom.Value
        Dim dtTo As DateTime = rtpTo.Value
        rtpFrom.Value = dtFrom.AddHours(1)
        rtpTo.Value = dtTo.AddHours(1)
        sePlan.Select()
    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If gvData.Rows.Count > 0 Then
            If Slipknot.IsFormOpen(FrmEditHourlyProdMnt) Then
                FrmEditHourlyProdMnt.Focus()
            Else
                FrmEditHourlyProdMnt.Show(Me)
            End If
        Else
            RadMessageBox.Show("No data found", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

    End Sub

    Private Sub seActual_ValueChanged(sender As Object, e As EventArgs) Handles seActual.ValueChanged
        seDeviation.Value = seActual.Value - sePlan.Value
    End Sub

    Private Sub sePlan_ValueChanged(sender As Object, e As EventArgs) Handles sePlan.ValueChanged
        seDeviation.Value = seActual.Value - sePlan.Value
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        FetchHourlyProdMnt()
    End Sub
End Class
