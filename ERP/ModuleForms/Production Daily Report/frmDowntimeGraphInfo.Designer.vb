<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDowntimeGraphInfo
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
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.btnGo = New Telerik.WinControls.UI.RadButton()
        Me.rdtDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.rdtDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(170, 127)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(110, 24)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Generate"
        Me.btnGo.ThemeName = "CrystalDark"
        '
        'rdtDateFrom
        '
        Me.rdtDateFrom.Location = New System.Drawing.Point(116, 45)
        Me.rdtDateFrom.Name = "rdtDateFrom"
        Me.rdtDateFrom.Size = New System.Drawing.Size(244, 24)
        Me.rdtDateFrom.TabIndex = 9
        Me.rdtDateFrom.TabStop = False
        Me.rdtDateFrom.Text = "Monday, February 17, 2025"
        Me.rdtDateFrom.Value = New Date(2025, 2, 17, 13, 29, 27, 37)
        '
        'rdtDateTo
        '
        Me.rdtDateTo.Location = New System.Drawing.Point(116, 81)
        Me.rdtDateTo.Name = "rdtDateTo"
        Me.rdtDateTo.Size = New System.Drawing.Size(244, 24)
        Me.rdtDateTo.TabIndex = 10
        Me.rdtDateTo.TabStop = False
        Me.rdtDateTo.Text = "Monday, February 17, 2025"
        Me.rdtDateTo.Value = New Date(2025, 2, 17, 13, 29, 27, 37)
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(43, 46)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(39, 18)
        Me.RadLabel1.TabIndex = 11
        Me.RadLabel1.Text = "FROM"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(43, 82)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(21, 18)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "TO"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.ForeColor = System.Drawing.Color.White
        Me.RadLabel3.Location = New System.Drawing.Point(136, 12)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(170, 25)
        Me.RadLabel3.TabIndex = 13
        Me.RadLabel3.Text = "SELECT DATE RANGE"
        '
        'FrmDowntimeGraphInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 163)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.rdtDateTo)
        Me.Controls.Add(Me.rdtDateFrom)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "FrmDowntimeGraphInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDowntimeGraphInfo"
        Me.ThemeName = "CrystalDark"
        CType(Me.btnGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents btnGo As Telerik.WinControls.UI.RadButton
    Friend WithEvents rdtDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents rdtDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
End Class

