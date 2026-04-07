<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptDemandComparison
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptDemandComparison))
        Me.rvDemandComparison = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGraphTotal = New Telerik.WinControls.UI.RadButton()
        Me.btnGraph3rdMonth = New Telerik.WinControls.UI.RadButton()
        Me.btnGraph2ndMonth = New Telerik.WinControls.UI.RadButton()
        Me.btnGraph1stMonth = New Telerik.WinControls.UI.RadButton()
        Me.btnFormView = New Telerik.WinControls.UI.RadButton()
        Me.FluentDarkTheme1 = New Telerik.WinControls.Themes.FluentDarkTheme()
        Me.Panel1.SuspendLayout()
        CType(Me.btnGraphTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGraph3rdMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGraph2ndMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGraph1stMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFormView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvDemandComparison
        '
        Me.rvDemandComparison.AccessibilityKeyMap = Nothing
        Me.rvDemandComparison.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvDemandComparison.Location = New System.Drawing.Point(0, 50)
        Me.rvDemandComparison.Name = "rvDemandComparison"
        Me.rvDemandComparison.Size = New System.Drawing.Size(692, 520)
        Me.rvDemandComparison.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGraphTotal)
        Me.Panel1.Controls.Add(Me.btnGraph3rdMonth)
        Me.Panel1.Controls.Add(Me.btnGraph2ndMonth)
        Me.Panel1.Controls.Add(Me.btnGraph1stMonth)
        Me.Panel1.Controls.Add(Me.btnFormView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 50)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'btnGraphTotal
        '
        Me.btnGraphTotal.Location = New System.Drawing.Point(427, 3)
        Me.btnGraphTotal.Name = "btnGraphTotal"
        Me.btnGraphTotal.Size = New System.Drawing.Size(100, 44)
        Me.btnGraphTotal.TabIndex = 5
        Me.btnGraphTotal.Text = "Graph" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Total)"
        Me.btnGraphTotal.ThemeName = "FluentDark"
        '
        'btnGraph3rdMonth
        '
        Me.btnGraph3rdMonth.Location = New System.Drawing.Point(321, 3)
        Me.btnGraph3rdMonth.Name = "btnGraph3rdMonth"
        Me.btnGraph3rdMonth.Size = New System.Drawing.Size(100, 44)
        Me.btnGraph3rdMonth.TabIndex = 4
        Me.btnGraph3rdMonth.Text = "Graph" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(3rd Month)"
        Me.btnGraph3rdMonth.ThemeName = "FluentDark"
        '
        'btnGraph2ndMonth
        '
        Me.btnGraph2ndMonth.Location = New System.Drawing.Point(215, 3)
        Me.btnGraph2ndMonth.Name = "btnGraph2ndMonth"
        Me.btnGraph2ndMonth.Size = New System.Drawing.Size(100, 44)
        Me.btnGraph2ndMonth.TabIndex = 3
        Me.btnGraph2ndMonth.Text = "Graph" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(2nd Month)"
        Me.btnGraph2ndMonth.ThemeName = "FluentDark"
        '
        'btnGraph1stMonth
        '
        Me.btnGraph1stMonth.Location = New System.Drawing.Point(109, 3)
        Me.btnGraph1stMonth.Name = "btnGraph1stMonth"
        Me.btnGraph1stMonth.Size = New System.Drawing.Size(100, 44)
        Me.btnGraph1stMonth.TabIndex = 2
        Me.btnGraph1stMonth.Text = "Graph" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(1st Month)"
        Me.btnGraph1stMonth.ThemeName = "FluentDark"
        '
        'btnFormView
        '
        Me.btnFormView.Location = New System.Drawing.Point(3, 3)
        Me.btnFormView.Name = "btnFormView"
        Me.btnFormView.Size = New System.Drawing.Size(100, 44)
        Me.btnFormView.TabIndex = 1
        Me.btnFormView.Text = "Form View"
        Me.btnFormView.ThemeName = "FluentDark"
        '
        'FrmRptDemandComparison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 570)
        Me.Controls.Add(Me.rvDemandComparison)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRptDemandComparison"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demand Comparison"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnGraphTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGraph3rdMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGraph2ndMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGraph1stMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFormView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvDemandComparison As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFormView As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGraphTotal As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGraph3rdMonth As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGraph2ndMonth As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGraph1stMonth As Telerik.WinControls.UI.RadButton
    Friend WithEvents FluentDarkTheme1 As Telerik.WinControls.Themes.FluentDarkTheme
End Class

