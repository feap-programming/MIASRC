<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLongTermForecast
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLongTermForecast))
        Me.pvLongTermForecast = New Telerik.WinControls.UI.RadPageView()
        Me.pgBudget = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlBudget = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.pgLatestDemand = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlLatestDemand = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.pgActual = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlActual = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.pvLongTermForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvLongTermForecast.SuspendLayout()
        Me.pgBudget.SuspendLayout()
        CType(Me.spnlBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlBudget.SuspendLayout()
        Me.pgLatestDemand.SuspendLayout()
        CType(Me.spnlLatestDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlLatestDemand.SuspendLayout()
        Me.pgActual.SuspendLayout()
        CType(Me.spnlActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlActual.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pvLongTermForecast
        '
        Me.pvLongTermForecast.Controls.Add(Me.pgBudget)
        Me.pvLongTermForecast.Controls.Add(Me.pgLatestDemand)
        Me.pvLongTermForecast.Controls.Add(Me.pgActual)
        Me.pvLongTermForecast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pvLongTermForecast.Location = New System.Drawing.Point(0, 0)
        Me.pvLongTermForecast.Name = "pvLongTermForecast"
        Me.pvLongTermForecast.SelectedPage = Me.pgBudget
        Me.pvLongTermForecast.Size = New System.Drawing.Size(985, 565)
        Me.pvLongTermForecast.TabIndex = 2
        Me.pvLongTermForecast.ThemeName = "Crystal"
        CType(Me.pvLongTermForecast.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ShowItemCloseButton = False
        '
        'pgBudget
        '
        Me.pgBudget.Controls.Add(Me.spnlBudget)
        Me.pgBudget.ItemSize = New System.Drawing.SizeF(52.0!, 28.0!)
        Me.pgBudget.Location = New System.Drawing.Point(10, 37)
        Me.pgBudget.Name = "pgBudget"
        Me.pgBudget.Size = New System.Drawing.Size(964, 517)
        Me.pgBudget.Text = "Budget"
        '
        'spnlBudget
        '
        Me.spnlBudget.Location = New System.Drawing.Point(0, 3)
        Me.spnlBudget.Name = "spnlBudget"
        '
        'spnlBudget.PanelContainer
        '
        Me.spnlBudget.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlBudget.Size = New System.Drawing.Size(100, 100)
        Me.spnlBudget.TabIndex = 2
        Me.spnlBudget.ThemeName = "Crystal"
        '
        'pgLatestDemand
        '
        Me.pgLatestDemand.Controls.Add(Me.spnlLatestDemand)
        Me.pgLatestDemand.ItemSize = New System.Drawing.SizeF(91.0!, 28.0!)
        Me.pgLatestDemand.Location = New System.Drawing.Point(10, 37)
        Me.pgLatestDemand.Name = "pgLatestDemand"
        Me.pgLatestDemand.Size = New System.Drawing.Size(964, 517)
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
        'pgActual
        '
        Me.pgActual.Controls.Add(Me.spnlActual)
        Me.pgActual.Enabled = False
        Me.pgActual.ItemSize = New System.Drawing.SizeF(47.0!, 28.0!)
        Me.pgActual.Location = New System.Drawing.Point(10, 37)
        Me.pgActual.Name = "pgActual"
        Me.pgActual.Size = New System.Drawing.Size(964, 517)
        Me.pgActual.Text = "Actual"
        '
        'spnlActual
        '
        Me.spnlActual.Location = New System.Drawing.Point(0, 3)
        Me.spnlActual.Name = "spnlActual"
        '
        'spnlActual.PanelContainer
        '
        Me.spnlActual.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlActual.Size = New System.Drawing.Size(100, 100)
        Me.spnlActual.TabIndex = 4
        Me.spnlActual.ThemeName = "Crystal"
        '
        'FrmLongTermForecast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 565)
        Me.Controls.Add(Me.pvLongTermForecast)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLongTermForecast"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Long Term Forecast"
        Me.ThemeName = "CrystalDark"
        CType(Me.pvLongTermForecast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvLongTermForecast.ResumeLayout(False)
        Me.pgBudget.ResumeLayout(False)
        CType(Me.spnlBudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlBudget.ResumeLayout(False)
        Me.pgLatestDemand.ResumeLayout(False)
        CType(Me.spnlLatestDemand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlLatestDemand.ResumeLayout(False)
        Me.pgActual.ResumeLayout(False)
        CType(Me.spnlActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlActual.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pvLongTermForecast As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pgBudget As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spnlBudget As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents pgLatestDemand As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spnlLatestDemand As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents pgActual As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spnlActual As Telerik.WinControls.UI.RadScrollablePanel
End Class

