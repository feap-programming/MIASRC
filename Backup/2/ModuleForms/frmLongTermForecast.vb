Public Class FrmLongTermForecast

    Private myBudget As ucBudget
    Private myLatestDemand As ucLatestDemand
    Private myActual As ucActual

    Private Sub FrmLongTermForecast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ucBudget As New ucBudget
        spnlBudget.Controls.Add(ucBudget)
        spnlBudget.Dock = DockStyle.Fill
        spnlBudget.BringToFront()
        ucBudget.Dock = DockStyle.Fill

        Dim ucLatestDemand As New ucLatestDemand
        spnlLatestDemand.Controls.Add(ucLatestDemand)
        spnlLatestDemand.Dock = DockStyle.Fill
        spnlLatestDemand.BringToFront()
        ucLatestDemand.Dock = DockStyle.Fill

        Dim ucActual As New ucActual
        spnlActual.Controls.Add(ucActual)
        spnlActual.Dock = DockStyle.Fill
        spnlActual.BringToFront()
        ucActual.Dock = DockStyle.Fill

        myBudget = ucBudget
        myLatestDemand = ucLatestDemand
        myActual = ucActual

    End Sub

    Private Sub FrmLongTermForecast_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If myBudget.bwLoadData.IsBusy Then
            myBudget.bwLoadData.CancelAsync()
        End If

        If myLatestDemand.bwLoadData.IsBusy Then
            myLatestDemand.bwLoadData.CancelAsync()
        End If

        If myLatestDemand.bwLoadData.IsBusy Then
            myActual.bwLoadData.CancelAsync()
        End If

        If myBudget.bwOperation.IsBusy Then
            myBudget.bwOperation.CancelAsync()
        End If

        If myLatestDemand.bwOperation.IsBusy Then
            myLatestDemand.bwOperation.CancelAsync()
        End If

        If myLatestDemand.bwOperation.IsBusy Then
            myActual.bwOperation.CancelAsync()
        End If

    End Sub

End Class
