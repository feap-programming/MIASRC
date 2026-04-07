<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDowntimeReportSelector
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.ddType = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnGo = New Telerik.WinControls.UI.RadButton()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddType
        '
        Me.ddType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "STANDARD"
        RadListDataItem2.Text = "PER DAY"
        RadListDataItem3.Text = "PER SHIFT"
        Me.ddType.Items.Add(RadListDataItem1)
        Me.ddType.Items.Add(RadListDataItem2)
        Me.ddType.Items.Add(RadListDataItem3)
        Me.ddType.Location = New System.Drawing.Point(73, 46)
        Me.ddType.Name = "ddType"
        Me.ddType.Size = New System.Drawing.Size(329, 24)
        Me.ddType.TabIndex = 5
        Me.ddType.ThemeName = "CrystalDark"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(173, 87)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(110, 24)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "Generate"
        Me.btnGo.ThemeName = "CrystalDark"
        '
        'FrmDowntimeReportSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 138)
        Me.Controls.Add(Me.ddType)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "FrmDowntimeReportSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downtime Report Selector"
        Me.ThemeName = "CrystalDark"
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ddType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnGo As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
End Class

