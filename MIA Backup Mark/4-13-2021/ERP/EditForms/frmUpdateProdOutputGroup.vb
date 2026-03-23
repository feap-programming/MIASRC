Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmUpdateProdOutputGroup
    Private Sub FrmUpdateProdOutputGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmUpdateProdOutputGroup_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub
    Private Sub FetchData()

        gvAssyProcessName.DataSource = Slipknot.dbSelect("SP_SelectAllBOMMaster")
    End Sub
End Class
