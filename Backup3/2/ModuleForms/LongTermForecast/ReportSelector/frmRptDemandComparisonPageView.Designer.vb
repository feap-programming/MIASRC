<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptDemandComparisonPageView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptDemandComparisonPageView))
        Me.pvDemandComparison = New Telerik.WinControls.UI.RadPageView()
        Me.pgFormView = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rvFormView = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.pgGraph1stMonth = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rvGraph1stMonth = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.pgGraph2ndMonth = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rvGraph2ndMonth = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.pgGraph3rdMonth = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rvGraph3rdMonth = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.pgGraphTotal = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rvGraphTotal = New Telerik.ReportViewer.WinForms.ReportViewer()
        CType(Me.pvDemandComparison, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvDemandComparison.SuspendLayout()
        Me.pgFormView.SuspendLayout()
        Me.pgGraph1stMonth.SuspendLayout()
        Me.pgGraph2ndMonth.SuspendLayout()
        Me.pgGraph3rdMonth.SuspendLayout()
        Me.pgGraphTotal.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pvDemandComparison
        '
        Me.pvDemandComparison.Controls.Add(Me.pgFormView)
        Me.pvDemandComparison.Controls.Add(Me.pgGraph1stMonth)
        Me.pvDemandComparison.Controls.Add(Me.pgGraph2ndMonth)
        Me.pvDemandComparison.Controls.Add(Me.pgGraph3rdMonth)
        Me.pvDemandComparison.Controls.Add(Me.pgGraphTotal)
        Me.pvDemandComparison.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pvDemandComparison.Location = New System.Drawing.Point(0, 0)
        Me.pvDemandComparison.Name = "pvDemandComparison"
        Me.pvDemandComparison.SelectedPage = Me.pgFormView
        Me.pvDemandComparison.Size = New System.Drawing.Size(692, 570)
        Me.pvDemandComparison.TabIndex = 0
        '
        'pgFormView
        '
        Me.pgFormView.Controls.Add(Me.rvFormView)
        Me.pgFormView.ItemSize = New System.Drawing.SizeF(69.0!, 28.0!)
        Me.pgFormView.Location = New System.Drawing.Point(10, 37)
        Me.pgFormView.Name = "pgFormView"
        Me.pgFormView.Size = New System.Drawing.Size(671, 522)
        Me.pgFormView.Text = "Form View"
        '
        'rvFormView
        '
        Me.rvFormView.AccessibilityKeyMap = Nothing
        Me.rvFormView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvFormView.Location = New System.Drawing.Point(0, 0)
        Me.rvFormView.Name = "rvFormView"
        Me.rvFormView.Size = New System.Drawing.Size(671, 522)
        Me.rvFormView.TabIndex = 0
        '
        'pgGraph1stMonth
        '
        Me.pgGraph1stMonth.Controls.Add(Me.rvGraph1stMonth)
        Me.pgGraph1stMonth.ItemSize = New System.Drawing.SizeF(108.0!, 28.0!)
        Me.pgGraph1stMonth.Location = New System.Drawing.Point(10, 37)
        Me.pgGraph1stMonth.Name = "pgGraph1stMonth"
        Me.pgGraph1stMonth.Size = New System.Drawing.Size(671, 522)
        Me.pgGraph1stMonth.Text = "Graph (1st Month)"
        '
        'rvGraph1stMonth
        '
        Me.rvGraph1stMonth.AccessibilityKeyMap = Nothing
        Me.rvGraph1stMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvGraph1stMonth.Location = New System.Drawing.Point(0, 0)
        Me.rvGraph1stMonth.Name = "rvGraph1stMonth"
        Me.rvGraph1stMonth.Size = New System.Drawing.Size(671, 522)
        Me.rvGraph1stMonth.TabIndex = 0
        '
        'pgGraph2ndMonth
        '
        Me.pgGraph2ndMonth.Controls.Add(Me.rvGraph2ndMonth)
        Me.pgGraph2ndMonth.ItemSize = New System.Drawing.SizeF(112.0!, 28.0!)
        Me.pgGraph2ndMonth.Location = New System.Drawing.Point(281, 30)
        Me.pgGraph2ndMonth.Name = "pgGraph2ndMonth"
        Me.pgGraph2ndMonth.Size = New System.Drawing.Size(410, 539)
        Me.pgGraph2ndMonth.Text = "Graph (2nd Month)"
        '
        'rvGraph2ndMonth
        '
        Me.rvGraph2ndMonth.AccessibilityKeyMap = Nothing
        Me.rvGraph2ndMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvGraph2ndMonth.Location = New System.Drawing.Point(0, 0)
        Me.rvGraph2ndMonth.Name = "rvGraph2ndMonth"
        Me.rvGraph2ndMonth.Size = New System.Drawing.Size(410, 539)
        Me.rvGraph2ndMonth.TabIndex = 0
        '
        'pgGraph3rdMonth
        '
        Me.pgGraph3rdMonth.Controls.Add(Me.rvGraph3rdMonth)
        Me.pgGraph3rdMonth.ItemSize = New System.Drawing.SizeF(110.0!, 28.0!)
        Me.pgGraph3rdMonth.Location = New System.Drawing.Point(281, 30)
        Me.pgGraph3rdMonth.Name = "pgGraph3rdMonth"
        Me.pgGraph3rdMonth.Size = New System.Drawing.Size(410, 539)
        Me.pgGraph3rdMonth.Text = "Graph (3rd Month)"
        '
        'rvGraph3rdMonth
        '
        Me.rvGraph3rdMonth.AccessibilityKeyMap = Nothing
        Me.rvGraph3rdMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvGraph3rdMonth.Location = New System.Drawing.Point(0, 0)
        Me.rvGraph3rdMonth.Name = "rvGraph3rdMonth"
        Me.rvGraph3rdMonth.Size = New System.Drawing.Size(410, 539)
        Me.rvGraph3rdMonth.TabIndex = 0
        '
        'pgGraphTotal
        '
        Me.pgGraphTotal.Controls.Add(Me.rvGraphTotal)
        Me.pgGraphTotal.ItemSize = New System.Drawing.SizeF(82.0!, 28.0!)
        Me.pgGraphTotal.Location = New System.Drawing.Point(281, 30)
        Me.pgGraphTotal.Name = "pgGraphTotal"
        Me.pgGraphTotal.Size = New System.Drawing.Size(410, 539)
        Me.pgGraphTotal.Text = "Graph (Total)"
        '
        'rvGraphTotal
        '
        Me.rvGraphTotal.AccessibilityKeyMap = Nothing
        Me.rvGraphTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvGraphTotal.Location = New System.Drawing.Point(0, 0)
        Me.rvGraphTotal.Name = "rvGraphTotal"
        Me.rvGraphTotal.Size = New System.Drawing.Size(410, 539)
        Me.rvGraphTotal.TabIndex = 0
        '
        'FrmRptDemandComparisonPageView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 570)
        Me.Controls.Add(Me.pvDemandComparison)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRptDemandComparisonPageView"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demand Comparison"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pvDemandComparison, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvDemandComparison.ResumeLayout(False)
        Me.pgFormView.ResumeLayout(False)
        Me.pgGraph1stMonth.ResumeLayout(False)
        Me.pgGraph2ndMonth.ResumeLayout(False)
        Me.pgGraph3rdMonth.ResumeLayout(False)
        Me.pgGraphTotal.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pvDemandComparison As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pgFormView As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pgGraph1stMonth As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pgGraph2ndMonth As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pgGraph3rdMonth As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pgGraphTotal As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rvFormView As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents rvGraph1stMonth As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents rvGraph2ndMonth As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents rvGraph3rdMonth As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents rvGraphTotal As Telerik.ReportViewer.WinForms.ReportViewer
End Class

