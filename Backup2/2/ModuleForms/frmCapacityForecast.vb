Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports System.ComponentModel

Public Class FrmCapacityForecast

    Private Sub FrmCapacityForecast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ucModelCapacity As New ucModelCapacity
        spnlCapacityForecast.Controls.Add(ucModelCapacity)
        spnlCapacityForecast.Dock = DockStyle.Fill
        spnlCapacityForecast.BringToFront()
        ucModelCapacity.Dock = DockStyle.Fill

        Dim ucCTOA As New ucCTOA
        spnlModelSettings.Controls.Add(ucCTOA)
        spnlModelSettings.Dock = DockStyle.Fill
        spnlModelSettings.BringToFront()
        ucCTOA.Dock = DockStyle.Fill

        'Dim ucModelGroup As New ucModelGroup
        'spnlModelGroup.Controls.Add(ucModelGroup)
        'spnlModelGroup.Dock = DockStyle.Fill
        'spnlModelGroup.BringToFront()
        'ucModelGroup.Dock = DockStyle.Fill

        Dim ucLineGroup As New ucLineGroup
        spnlLineGroup.Controls.Add(ucLineGroup)
        spnlLineGroup.Dock = DockStyle.Fill
        spnlLineGroup.BringToFront()
        ucLineGroup.Dock = DockStyle.Fill

        Dim ucWorkingDays As New ucWorkingDays
        spnlWorkingDays.Controls.Add(ucWorkingDays)
        spnlWorkingDays.Dock = DockStyle.Fill
        spnlWorkingDays.BringToFront()
        ucWorkingDays.Dock = DockStyle.Fill

    End Sub

End Class
