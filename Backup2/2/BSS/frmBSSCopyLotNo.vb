Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmBSSCopyLotNo

    Private Sub FrmBSSCopyLotNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        loadProcess()
        loadProcess2()
        mcbRMIDFrom.Text = ""
        mcbRMIDTo.Text = ""
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If RadMessageBox.Show("This action is irreversible, are you sure you want to proceed with this transaction?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Slipknot.addParameter("RMIDFrom", mcbRMIDFrom.Text)
            Slipknot.addParameter("RMIDTo", mcbRMIDTo.Text)
            Slipknot.dbAED("SP_BSSDuplicateLotNoBeforeOven")
            RadMessageBox.Show("successfully copied!", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub
    Private Sub loadProcess()
        Slipknot.addParameter("_MainID", txtMainID.Text)
        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectRMWorkProcessbyMainID")

        Dim fldRMID As New GridViewTextBoxColumn("RMID") With {
            .FieldName = "fldRMID",
            .Width = 70
        }
        mcbRMIDFrom.MultiColumnComboBoxElement.Columns.Add(fldRMID)

        Dim fldTime As New GridViewTextBoxColumn("TIME") With {
            .FieldName = "fldTime",
            .Width = 100
        }
        mcbRMIDFrom.MultiColumnComboBoxElement.Columns.Add(fldTime)

        Dim fldTray As New GridViewTextBoxColumn("TRAY") With {
            .FieldName = "fldTrayNo",
            .Width = 200
        }
        mcbRMIDFrom.MultiColumnComboBoxElement.Columns.Add(fldTray)

        mcbRMIDFrom.DataSource = dtProcess
        mcbRMIDFrom.ValueMember = "fldRMID"
        mcbRMIDFrom.DisplayMember = "fldRMID"
        mcbRMIDFrom.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbRMIDFrom.AutoFilter = True
        mcbRMIDFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim RMID As New FilterDescriptor("fldRMID", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(RMID)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.mcbRMIDFrom.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub

    Private Sub loadProcess2()
        Slipknot.addParameter("_MainID", txtMainID.Text)
        Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectRMWorkProcessbyMainID")

        Dim fldRMID As New GridViewTextBoxColumn("RMID") With {
            .FieldName = "fldRMID",
            .Width = 70
        }
        mcbRMIDTo.MultiColumnComboBoxElement.Columns.Add(fldRMID)

        Dim fldTime As New GridViewTextBoxColumn("TIME") With {
            .FieldName = "fldTime",
            .Width = 100
        }
        mcbRMIDTo.MultiColumnComboBoxElement.Columns.Add(fldTime)

        Dim fldTray As New GridViewTextBoxColumn("TRAY") With {
            .FieldName = "fldTrayNo",
            .Width = 200
        }
        mcbRMIDTo.MultiColumnComboBoxElement.Columns.Add(fldTray)

        mcbRMIDTo.DataSource = dtProcess
        mcbRMIDTo.ValueMember = "fldRMID"
        mcbRMIDTo.DisplayMember = "fldRMID"
        mcbRMIDTo.MultiColumnComboBoxElement.DropDownWidth = 400

        mcbRMIDTo.AutoFilter = True
        mcbRMIDTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim RMID As New FilterDescriptor("fldRMID", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(RMID)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        Me.mcbRMIDTo.EditorControl.FilterDescriptors.Add(compositeFilter)

    End Sub
End Class
