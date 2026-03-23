<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeldingDailyReportData
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
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.manpower = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spManpower = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.hourly = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spHourly = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.defects = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spDefect = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.rmwiplot = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spLot = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.manpower.SuspendLayout()
        CType(Me.spManpower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spManpower.SuspendLayout()
        Me.hourly.SuspendLayout()
        CType(Me.spHourly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spHourly.SuspendLayout()
        Me.defects.SuspendLayout()
        CType(Me.spDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spDefect.SuspendLayout()
        Me.rmwiplot.SuspendLayout()
        CType(Me.spLot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spLot.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.manpower)
        Me.RadPageView1.Controls.Add(Me.hourly)
        Me.RadPageView1.Controls.Add(Me.defects)
        Me.RadPageView1.Controls.Add(Me.rmwiplot)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.manpower
        Me.RadPageView1.Size = New System.Drawing.Size(1048, 599)
        Me.RadPageView1.TabIndex = 0
        Me.RadPageView1.ThemeName = "CrystalDark"
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.StripViewButtonsPanel).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Scroll Strip Left"
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).Enabled = False
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Scroll Strip Right"
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).Enabled = False
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Close Selected Page"
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadPageViewLabelElement).Text = "MANPOWER & LINE EFFICIENCY"
        CType(Me.RadPageView1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadPageViewLabelElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'manpower
        '
        Me.manpower.Controls.Add(Me.spManpower)
        Me.manpower.ItemSize = New System.Drawing.SizeF(214.0!, 28.0!)
        Me.manpower.Location = New System.Drawing.Point(6, 33)
        Me.manpower.Name = "manpower"
        Me.manpower.Size = New System.Drawing.Size(1036, 559)
        Me.manpower.Text = "MANPOWER & LINE EFFICIENCY"
        '
        'spManpower
        '
        Me.spManpower.Location = New System.Drawing.Point(144, 75)
        Me.spManpower.Name = "spManpower"
        '
        'spManpower.PanelContainer
        '
        Me.spManpower.PanelContainer.Size = New System.Drawing.Size(198, 98)
        Me.spManpower.Size = New System.Drawing.Size(200, 100)
        Me.spManpower.TabIndex = 0
        '
        'hourly
        '
        Me.hourly.Controls.Add(Me.spHourly)
        Me.hourly.ItemSize = New System.Drawing.SizeF(251.0!, 28.0!)
        Me.hourly.Location = New System.Drawing.Point(6, 33)
        Me.hourly.Name = "hourly"
        Me.hourly.Size = New System.Drawing.Size(1036, 559)
        Me.hourly.Text = "HOURLY PROD. STATUS MONITORING"
        '
        'spHourly
        '
        Me.spHourly.Location = New System.Drawing.Point(418, 229)
        Me.spHourly.Name = "spHourly"
        '
        'spHourly.PanelContainer
        '
        Me.spHourly.PanelContainer.Size = New System.Drawing.Size(198, 98)
        Me.spHourly.Size = New System.Drawing.Size(200, 100)
        Me.spHourly.TabIndex = 1
        '
        'defects
        '
        Me.defects.Controls.Add(Me.spDefect)
        Me.defects.ItemSize = New System.Drawing.SizeF(141.0!, 28.0!)
        Me.defects.Location = New System.Drawing.Point(6, 33)
        Me.defects.Name = "defects"
        Me.defects.Size = New System.Drawing.Size(1036, 559)
        Me.defects.Text = "DEFECTIVE DETAILS"
        '
        'spDefect
        '
        Me.spDefect.Location = New System.Drawing.Point(418, 229)
        Me.spDefect.Name = "spDefect"
        '
        'spDefect.PanelContainer
        '
        Me.spDefect.PanelContainer.Size = New System.Drawing.Size(198, 98)
        Me.spDefect.Size = New System.Drawing.Size(200, 100)
        Me.spDefect.TabIndex = 2
        '
        'rmwiplot
        '
        Me.rmwiplot.Controls.Add(Me.spLot)
        Me.rmwiplot.ItemSize = New System.Drawing.SizeF(130.0!, 28.0!)
        Me.rmwiplot.Location = New System.Drawing.Point(6, 33)
        Me.rmwiplot.Name = "rmwiplot"
        Me.rmwiplot.Size = New System.Drawing.Size(1036, 559)
        Me.rmwiplot.Text = "RM & WIP LOT NO."
        '
        'spLot
        '
        Me.spLot.Location = New System.Drawing.Point(418, 229)
        Me.spLot.Name = "spLot"
        '
        'spLot.PanelContainer
        '
        Me.spLot.PanelContainer.Size = New System.Drawing.Size(198, 98)
        Me.spLot.Size = New System.Drawing.Size(200, 100)
        Me.spLot.TabIndex = 3
        '
        'FrmWeldingDailyReportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 599)
        Me.Controls.Add(Me.RadPageView1)
        Me.Name = "FrmWeldingDailyReportData"
        Me.Text = "Daily Report"
        Me.ThemeName = "CrystalDark"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.manpower.ResumeLayout(False)
        CType(Me.spManpower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spManpower.ResumeLayout(False)
        Me.hourly.ResumeLayout(False)
        CType(Me.spHourly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spHourly.ResumeLayout(False)
        Me.defects.ResumeLayout(False)
        CType(Me.spDefect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spDefect.ResumeLayout(False)
        Me.rmwiplot.ResumeLayout(False)
        CType(Me.spLot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spLot.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents manpower As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents hourly As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents defects As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rmwiplot As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents spManpower As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents spHourly As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents spDefect As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents spLot As Telerik.WinControls.UI.RadScrollablePanel
End Class

