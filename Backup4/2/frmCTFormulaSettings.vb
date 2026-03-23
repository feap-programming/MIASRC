Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmCTFormulaSettings
    Private Sub FrmCTFormulaSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        readyGrid()

        loadRecord()

    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.ReadOnly = True
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldName As New GridViewTextBoxColumn("NAME")
        fldName.FieldName = "fldName"
        fldName.Width = 50
        fldName.TextAlignment = ContentAlignment.MiddleCenter
        gvData.Columns.Add(fldName)

        Dim fldProcess As New GridViewTextBoxColumn("PROCESS")
        fldProcess.FieldName = "fldProcess"
        fldProcess.Width = 190
        gvData.Columns.Add(fldProcess)

        Dim fldFormula As New GridViewTextBoxColumn("FORMULA")
        fldFormula.FieldName = "fldFormula"
        fldFormula.Width = 250
        gvData.Columns.Add(fldFormula)

        gvData.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False

    End Sub

    Private Sub loadRecord()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblCTFormulaSettings")

        gvData.DataSource = dt

    End Sub

    Private Sub dbbRefresh_Click(sender As Object, e As EventArgs) Handles dbbRefresh.Click
        loadRecord()
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click

        For Each row As GridViewRowInfo In gvData.Rows

            Slipknot.addParameter("parId", Convert.ToInt32(row.Cells("fldId").Value))
            Slipknot.addParameter("parName", Convert.ToString(row.Cells("fldName").Value).TrimStart.TrimEnd)
            Slipknot.addParameter("parProcess", Convert.ToString(row.Cells("fldProcess").Value).TrimStart.TrimEnd)
            Slipknot.addParameter("parFormula", Convert.ToString(row.Cells("fldFormula").Value).TrimStart.TrimEnd)

            Slipknot.dbAED("SP_UpdateCTFormulaSettings")

        Next

        RadMessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

End Class
