<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSRCReportSelectorSeparate
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
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.btnGo = New Telerik.WinControls.UI.RadButton()
        Me.ddType = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(116, 71)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(110, 24)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Generate"
        Me.btnGo.ThemeName = "CrystalDark"
        '
        'ddType
        '
        Me.ddType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "STANDARD"
        RadListDataItem2.Text = "MANPOWER"
        RadListDataItem3.Text = "HOURLY"
        RadListDataItem4.Text = "ASSY LINE EFF."
        RadListDataItem5.Text = "SRC ASSY"
        RadListDataItem6.Text = "DEFECTS"
        RadListDataItem7.Text = "OTHERS"
        RadListDataItem8.Text = "LOTNO"
        RadListDataItem9.Text = "ALL (WORK BOOK)"
        Me.ddType.Items.Add(RadListDataItem1)
        Me.ddType.Items.Add(RadListDataItem2)
        Me.ddType.Items.Add(RadListDataItem3)
        Me.ddType.Items.Add(RadListDataItem4)
        Me.ddType.Items.Add(RadListDataItem5)
        Me.ddType.Items.Add(RadListDataItem6)
        Me.ddType.Items.Add(RadListDataItem7)
        Me.ddType.Items.Add(RadListDataItem8)
        Me.ddType.Items.Add(RadListDataItem9)
        Me.ddType.Location = New System.Drawing.Point(12, 31)
        Me.ddType.Name = "ddType"
        Me.ddType.NullText = "ALL"
        Me.ddType.Size = New System.Drawing.Size(329, 24)
        Me.ddType.TabIndex = 3
        Me.ddType.Text = "ALL"
        Me.ddType.ThemeName = "CrystalDark"
        '
        'FrmSRCReportSelectorSeparate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 112)
        Me.Controls.Add(Me.ddType)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "FrmSRCReportSelectorSeparate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Select"
        Me.ThemeName = "CrystalDark"
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents btnGo As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddType As Telerik.WinControls.UI.RadDropDownList
End Class

