<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCapacityForecast
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCapacityForecast))
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.pgCapacityForecast = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlCapacityForecast = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.pgModelSettings = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlModelSettings = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.pgLineGroup = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlLineGroup = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.pgWorkingDays = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spnlWorkingDays = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.pgCapacityForecast.SuspendLayout()
        CType(Me.spnlCapacityForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlCapacityForecast.SuspendLayout()
        Me.pgModelSettings.SuspendLayout()
        CType(Me.spnlModelSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlModelSettings.SuspendLayout()
        Me.pgLineGroup.SuspendLayout()
        CType(Me.spnlLineGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlLineGroup.SuspendLayout()
        Me.pgWorkingDays.SuspendLayout()
        CType(Me.spnlWorkingDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlWorkingDays.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.pgCapacityForecast)
        Me.RadPageView1.Controls.Add(Me.pgModelSettings)
        Me.RadPageView1.Controls.Add(Me.pgLineGroup)
        Me.RadPageView1.Controls.Add(Me.pgWorkingDays)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.pgCapacityForecast
        Me.RadPageView1.Size = New System.Drawing.Size(985, 565)
        Me.RadPageView1.TabIndex = 0
        Me.RadPageView1.ThemeName = "Crystal"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ShowItemCloseButton = False
        '
        'pgCapacityForecast
        '
        Me.pgCapacityForecast.Controls.Add(Me.spnlCapacityForecast)
        Me.pgCapacityForecast.ItemSize = New System.Drawing.SizeF(125.0!, 28.0!)
        Me.pgCapacityForecast.Location = New System.Drawing.Point(6, 33)
        Me.pgCapacityForecast.Name = "pgCapacityForecast"
        Me.pgCapacityForecast.Size = New System.Drawing.Size(973, 525)
        Me.pgCapacityForecast.Text = "Capacity Forecast"
        '
        'spnlCapacityForecast
        '
        Me.spnlCapacityForecast.Location = New System.Drawing.Point(0, 3)
        Me.spnlCapacityForecast.Name = "spnlCapacityForecast"
        '
        'spnlCapacityForecast.PanelContainer
        '
        Me.spnlCapacityForecast.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlCapacityForecast.Size = New System.Drawing.Size(100, 100)
        Me.spnlCapacityForecast.TabIndex = 2
        Me.spnlCapacityForecast.ThemeName = "Crystal"
        '
        'pgModelSettings
        '
        Me.pgModelSettings.Controls.Add(Me.spnlModelSettings)
        Me.pgModelSettings.ItemSize = New System.Drawing.SizeF(107.0!, 28.0!)
        Me.pgModelSettings.Location = New System.Drawing.Point(6, 33)
        Me.pgModelSettings.Name = "pgModelSettings"
        Me.pgModelSettings.Size = New System.Drawing.Size(973, 525)
        Me.pgModelSettings.Text = "Model Settings"
        '
        'spnlModelSettings
        '
        Me.spnlModelSettings.Location = New System.Drawing.Point(0, 3)
        Me.spnlModelSettings.Name = "spnlModelSettings"
        '
        'spnlModelSettings.PanelContainer
        '
        Me.spnlModelSettings.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlModelSettings.Size = New System.Drawing.Size(100, 100)
        Me.spnlModelSettings.TabIndex = 3
        Me.spnlModelSettings.ThemeName = "Crystal"
        '
        'pgLineGroup
        '
        Me.pgLineGroup.Controls.Add(Me.spnlLineGroup)
        Me.pgLineGroup.ItemSize = New System.Drawing.SizeF(81.0!, 28.0!)
        Me.pgLineGroup.Location = New System.Drawing.Point(6, 33)
        Me.pgLineGroup.Name = "pgLineGroup"
        Me.pgLineGroup.Size = New System.Drawing.Size(973, 525)
        Me.pgLineGroup.Text = "Line Group"
        '
        'spnlLineGroup
        '
        Me.spnlLineGroup.Location = New System.Drawing.Point(0, 3)
        Me.spnlLineGroup.Name = "spnlLineGroup"
        '
        'spnlLineGroup.PanelContainer
        '
        Me.spnlLineGroup.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlLineGroup.Size = New System.Drawing.Size(100, 100)
        Me.spnlLineGroup.TabIndex = 1
        Me.spnlLineGroup.ThemeName = "Crystal"
        '
        'pgWorkingDays
        '
        Me.pgWorkingDays.Controls.Add(Me.spnlWorkingDays)
        Me.pgWorkingDays.ItemSize = New System.Drawing.SizeF(99.0!, 28.0!)
        Me.pgWorkingDays.Location = New System.Drawing.Point(6, 33)
        Me.pgWorkingDays.Name = "pgWorkingDays"
        Me.pgWorkingDays.Size = New System.Drawing.Size(973, 525)
        Me.pgWorkingDays.Text = "Working Days"
        '
        'spnlWorkingDays
        '
        Me.spnlWorkingDays.Location = New System.Drawing.Point(0, 3)
        Me.spnlWorkingDays.Name = "spnlWorkingDays"
        '
        'spnlWorkingDays.PanelContainer
        '
        Me.spnlWorkingDays.PanelContainer.Size = New System.Drawing.Size(98, 98)
        Me.spnlWorkingDays.Size = New System.Drawing.Size(100, 100)
        Me.spnlWorkingDays.TabIndex = 0
        Me.spnlWorkingDays.ThemeName = "Crystal"
        '
        'FrmCapacityForecast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 565)
        Me.Controls.Add(Me.RadPageView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCapacityForecast"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = " Capacity Forecast"
        Me.ThemeName = "CrystalDark"
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.pgCapacityForecast.ResumeLayout(False)
        CType(Me.spnlCapacityForecast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlCapacityForecast.ResumeLayout(False)
        Me.pgModelSettings.ResumeLayout(False)
        CType(Me.spnlModelSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlModelSettings.ResumeLayout(False)
        Me.pgLineGroup.ResumeLayout(False)
        CType(Me.spnlLineGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlLineGroup.ResumeLayout(False)
        Me.pgWorkingDays.ResumeLayout(False)
        CType(Me.spnlWorkingDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlWorkingDays.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pgCapacityForecast As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pgLineGroup As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pgWorkingDays As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spnlWorkingDays As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents spnlLineGroup As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents spnlCapacityForecast As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents pgModelSettings As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spnlModelSettings As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
End Class

