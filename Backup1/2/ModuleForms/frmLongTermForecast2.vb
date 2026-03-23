Public Class FrmLongTermForecast2

    Private myDemand As ucDemand
    Private myPurchaseOrder As ucPurchaseOrder
    Private myLatestDemand As ucLatestDemand

    Private Sub FrmLongTermForecast2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ucDemand As New ucDemand
        spnlDemand.Controls.Add(ucDemand)
        spnlDemand.Dock = DockStyle.Fill
        spnlDemand.BringToFront()
        ucDemand.Dock = DockStyle.Fill

        Dim ucPurchaseOrder As New ucPurchaseOrder
        spnlPurchaseOrder.Controls.Add(ucPurchaseOrder)
        spnlPurchaseOrder.Dock = DockStyle.Fill
        spnlPurchaseOrder.BringToFront()
        ucPurchaseOrder.Dock = DockStyle.Fill

        Dim ucLatestDemand As New ucLatestDemand
        spnlLatestDemand.Controls.Add(ucLatestDemand)
        spnlLatestDemand.Dock = DockStyle.Fill
        spnlLatestDemand.BringToFront()
        ucLatestDemand.Dock = DockStyle.Fill

        myDemand = ucDemand
        myPurchaseOrder = ucPurchaseOrder
        myLatestDemand = ucLatestDemand

    End Sub

    Private Sub FrmLongTermForecast2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If myDemand.bwLoadData.IsBusy Then
            myDemand.bwLoadData.CancelAsync()
        End If

        If myLatestDemand.bwLoadData.IsBusy Then
            myPurchaseOrder.bwLoadData.CancelAsync()
        End If

        If myLatestDemand.bwLoadData.IsBusy Then
            myLatestDemand.bwLoadData.CancelAsync()
        End If

        If myDemand.bwOperation.IsBusy Then
            myDemand.bwOperation.CancelAsync()
        End If

        If myLatestDemand.bwOperation.IsBusy Then
            myPurchaseOrder.bwOperation.CancelAsync()
        End If

        If myLatestDemand.bwOperation.IsBusy Then
            myLatestDemand.bwOperation.CancelAsync()
        End If

    End Sub

End Class
