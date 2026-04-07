<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDowntimeExcel
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
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btnExport = New Telerik.WinControls.UI.RadButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ddShft = New Telerik.WinControls.UI.RadDropDownList()
        Me.ddType = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddShft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(30, 32)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(49, 25)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Shift:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(31, 127)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(50, 25)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "Type:"
        Me.RadLabel2.Visible = False
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(129, 66)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(110, 24)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "EXPORT"
        '
        'ddShft
        '
        Me.ddShft.DropDownAnimationEnabled = True
        Me.ddShft.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem9.Text = "First Shift"
        RadListDataItem10.Text = "Day Shift"
        RadListDataItem11.Text = "Second Shift"
        RadListDataItem12.Text = "Night Shift"
        RadListDataItem13.Text = "Third Shift"
        Me.ddShft.Items.Add(RadListDataItem9)
        Me.ddShft.Items.Add(RadListDataItem10)
        Me.ddShft.Items.Add(RadListDataItem11)
        Me.ddShft.Items.Add(RadListDataItem12)
        Me.ddShft.Items.Add(RadListDataItem13)
        Me.ddShft.Location = New System.Drawing.Point(85, 26)
        Me.ddShft.Name = "ddShft"
        Me.ddShft.Size = New System.Drawing.Size(247, 31)
        Me.ddShft.TabIndex = 6
        '
        'ddType
        '
        Me.ddType.DropDownAnimationEnabled = True
        Me.ddType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "ASSY"
        RadListDataItem2.Text = "PW"
        RadListDataItem3.Text = "FW"
        Me.ddType.Items.Add(RadListDataItem1)
        Me.ddType.Items.Add(RadListDataItem2)
        Me.ddType.Items.Add(RadListDataItem3)
        Me.ddType.Location = New System.Drawing.Point(87, 124)
        Me.ddType.Name = "ddType"
        Me.ddType.Size = New System.Drawing.Size(247, 31)
        Me.ddType.TabIndex = 7
        Me.ddType.Visible = False
        '
        'FrmDowntimeExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 101)
        Me.Controls.Add(Me.ddType)
        Me.Controls.Add(Me.ddShft)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "FrmDowntimeExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Excel"
        Me.ThemeName = "CrystalDark"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddShft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnExport As Telerik.WinControls.UI.RadButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ddShft As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddType As Telerik.WinControls.UI.RadDropDownList
End Class

