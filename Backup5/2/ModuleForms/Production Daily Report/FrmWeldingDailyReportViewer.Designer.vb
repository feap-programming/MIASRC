<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeldingDailyReportViewer
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
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AccessibilityKeyMap = Nothing
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1014, 384)
        Me.ReportViewer1.TabIndex = 1
        Me.ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
        '
        'FrmWeldingDailyReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 384)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmWeldingDailyReportViewer"
        Me.Text = "FrmWeldingDailyReportViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer
End Class

