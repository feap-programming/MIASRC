<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLongTermForecast2
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLongTermForecast2))
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.pvLongTermForecast = New Telerik.WinControls.UI.RadPageView()
        Me.pgDemand = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlDemand = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.pgPurchaseOrder = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlPurchaseOrder = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.pgLatestDemand = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlLatestDemand = New Telerik.WinControls.UI.RadScrollablePanel()
        CType(Me.pvLongTermForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvLongTermForecast.SuspendLayout()
        Me.pgDemand.SuspendLayout()
        CType(Me.spnlDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlDemand.SuspendLayout()
        Me.pgPurchaseOrder.SuspendLayout()
        CType(Me.spnlPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlPurchaseOrder.SuspendLayout()
        Me.pgLatestDemand.SuspendLayout()
        CType(Me.spnlLatestDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlLatestDemand.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pvLongTermForecast
        '
        Me.pvLongTermForecast.Controls.Add(Me.pgDemand)
        Me.pvLongTermForecast.Controls.Add(Me.pgPurchaseOrder)
        Me.pvLongTermForecast.Controls.Add(Me.pgLatestDemand)
        Me.pvLongTermForecast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pvLongTermForecast.Location = New System.Drawing.Point(0, 0)
        Me.pvLongTermForecast.Name = "pvLongTermForecast"
        Me.pvLongTermForecast.SelectedPage = Me.pgDemand
        Me.pvLongTermForecast.Size = New System.Drawing.Size(985, 567)
        Me.pvLongTermForecast.TabIndex = 3
        Me.pvLongTermForecast.ThemeName = "Crystal"
        CType(Me.pvLongTermForecast.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ShowItemCloseButton = False
        '
        'pgDemand
        '
        Me.pgDemand.Controls.Add(Me.spnlDemand)
        Me.pgDemand.ItemSize = New System.Drawing.SizeF(59.0!, 28.0!)
        Me.pgDemand.Location = New System.Drawing.Point(10, 37)
        Me.pgDemand.Name = "pgDemand"
        Me.pgDemand.Size = New System.Drawing.Size(964, 519)
        Me.pgDemand.Text = "Demand"
        '
        'spnlDemand
        '
        Me.spnlDemand.Location = New System.Drawing.Point(0, 3)
        Me.spnlDemand.Name = "spnlDemand"
        '
        'spnlDemand.PanelContainer
        '
        Me.spnlDemand.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlDemand.Size = New System.Drawing.Size(100, 100)
        Me.spnlDemand.TabIndex = 2
        Me.spnlDemand.ThemeName = "Crystal"
        '
        'pgPurchaseOrder
        '
        Me.pgPurchaseOrder.Controls.Add(Me.spnlPurchaseOrder)
        Me.pgPurchaseOrder.ItemSize = New System.Drawing.SizeF(93.0!, 28.0!)
        Me.pgPurchaseOrder.Location = New System.Drawing.Point(10, 37)
        Me.pgPurchaseOrder.Name = "pgPurchaseOrder"
        Me.pgPurchaseOrder.Size = New System.Drawing.Size(964, 519)
        Me.pgPurchaseOrder.Text = "Purchase Order"
        Me.pgPurchaseOrder.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'spnlPurchaseOrder
        '
        Me.spnlPurchaseOrder.Location = New System.Drawing.Point(0, 3)
        Me.spnlPurchaseOrder.Name = "spnlPurchaseOrder"
        '
        'spnlPurchaseOrder.PanelContainer
        '
        Me.spnlPurchaseOrder.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlPurchaseOrder.Size = New System.Drawing.Size(100, 100)
        Me.spnlPurchaseOrder.TabIndex = 3
        Me.spnlPurchaseOrder.ThemeName = "Crystal"
        '
        'pgLatestDemand
        '
        Me.pgLatestDemand.Controls.Add(Me.spnlLatestDemand)
        Me.pgLatestDemand.ItemSize = New System.Drawing.SizeF(91.0!, 28.0!)
        Me.pgLatestDemand.Location = New System.Drawing.Point(10, 37)
        Me.pgLatestDemand.Name = "pgLatestDemand"
        Me.pgLatestDemand.Size = New System.Drawing.Size(964, 519)
        Me.pgLatestDemand.Text = "Latest Demand"
        '
        'spnlLatestDemand
        '
        Me.spnlLatestDemand.Location = New System.Drawing.Point(0, 3)
        Me.spnlLatestDemand.Name = "spnlLatestDemand"
        '
        'spnlLatestDemand.PanelContainer
        '
        Me.spnlLatestDemand.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlLatestDemand.Size = New System.Drawing.Size(100, 100)
        Me.spnlLatestDemand.TabIndex = 3
        Me.spnlLatestDemand.ThemeName = "Crystal"
        '
        'FrmLongTermForecast2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 567)
        Me.Controls.Add(Me.pvLongTermForecast)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLongTermForecast2"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Long Term Forecast"
        Me.ThemeName = "CrystalDark"
        CType(Me.pvLongTermForecast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvLongTermForecast.ResumeLayout(False)
        Me.pgDemand.ResumeLayout(False)
        CType(Me.spnlDemand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlDemand.ResumeLayout(False)
        Me.pgPurchaseOrder.ResumeLayout(False)
        CType(Me.spnlPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlPurchaseOrder.ResumeLayout(False)
        Me.pgLatestDemand.ResumeLayout(False)
        CType(Me.spnlLatestDemand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlLatestDemand.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents pvLongTermForecast As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pgDemand As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spnlDemand As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents pgLatestDemand As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spnlLatestDemand As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents pgPurchaseOrder As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spnlPurchaseOrder As Telerik.WinControls.UI.RadScrollablePanel
End Class

