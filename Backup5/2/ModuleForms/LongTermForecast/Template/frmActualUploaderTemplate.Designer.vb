<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualUploaderTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualUploaderTemplate))
        Me.rvActual = New Telerik.ReportViewer.WinForms.ReportViewer()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvActual
        '
        Me.rvActual.AccessibilityKeyMap = Nothing
        Me.rvActual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvActual.Location = New System.Drawing.Point(0, 0)
        Me.rvActual.Name = "rvActual"
        Me.rvActual.Size = New System.Drawing.Size(692, 570)
        Me.rvActual.TabIndex = 0
        '
        'FrmActualUploaderTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 570)
        Me.Controls.Add(Me.rvActual)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmActualUploaderTemplate"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actual Uploader Template"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvActual As Telerik.ReportViewer.WinForms.ReportViewer
End Class

