<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSRCAssyReportSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSRCAssyReportSelector))
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.CrystalTheme1 = New Telerik.WinControls.Themes.CrystalTheme()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton1
        '
        Me.RadButton1.BackgroundImage = CType(resources.GetObject("RadButton1.BackgroundImage"), System.Drawing.Image)
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.Location = New System.Drawing.Point(12, 12)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(207, 227)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "WHOLE SHIFT"
        Me.RadButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RadButton1.ThemeName = "CrystalDark"
        '
        'RadButton2
        '
        Me.RadButton2.Image = CType(resources.GetObject("RadButton2.Image"), System.Drawing.Image)
        Me.RadButton2.Location = New System.Drawing.Point(225, 12)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(207, 227)
        Me.RadButton2.TabIndex = 1
        Me.RadButton2.Text = "WHOLE DAY"
        Me.RadButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RadButton2.ThemeName = "CrystalDark"
        '
        'FrmSRCAssyReportSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 244)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSRCAssyReportSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Selector"
        Me.ThemeName = "CrystalDark"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalTheme1 As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
End Class

