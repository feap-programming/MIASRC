<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDailyOtherDetails
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDailyOtherDetails))
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbSave = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClear = New Telerik.WinControls.UI.CommandBarButton()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.tbMoldParts = New Telerik.WinControls.UI.RadTextBox()
        Me.tbInitialProb = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.tbOthers = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMoldParts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInitialProb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOthers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(530, 82)
        Me.RadCommandBar1.TabIndex = 15
        Me.RadCommandBar1.ThemeName = "CrystalDark"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        Me.CommandBarRowElement1.Text = ""
        Me.CommandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.UseCompatibleTextRendering = False
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.DisplayName = "Control Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbSave, Me.cbbClear})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'cbbSave
        '
        Me.cbbSave.AutoSize = False
        Me.cbbSave.Bounds = New System.Drawing.Rectangle(0, 0, 99, 52)
        Me.cbbSave.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbSave.DisplayName = "Add Record"
        Me.cbbSave.DrawText = True
        Me.cbbSave.Image = CType(resources.GetObject("cbbSave.Image"), System.Drawing.Image)
        Me.cbbSave.Name = "cbbSave"
        Me.cbbSave.Text = "Save"
        Me.cbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbSave.UseCompatibleTextRendering = False
        '
        'cbbClear
        '
        Me.cbbClear.AutoSize = False
        Me.cbbClear.Bounds = New System.Drawing.Rectangle(0, 0, 99, 52)
        Me.cbbClear.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbClear.DisplayName = "Delete Record"
        Me.cbbClear.DrawText = True
        Me.cbbClear.Image = CType(resources.GetObject("cbbClear.Image"), System.Drawing.Image)
        Me.cbbClear.Name = "cbbClear"
        Me.cbbClear.Text = "Clear Input"
        Me.cbbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbClear.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbClear.UseCompatibleTextRendering = False
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 82)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(530, 32)
        Me.RadPanel1.TabIndex = 24
        Me.RadPanel1.ThemeName = "Office2007Black"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.ForeColor = System.Drawing.Color.White
        Me.RadLabel4.Location = New System.Drawing.Point(3, 9)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(259, 21)
        Me.RadLabel4.TabIndex = 11
        Me.RadLabel4.Text = "A. Mold Parts Combination & Compatibility"
        '
        'tbMoldParts
        '
        Me.tbMoldParts.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbMoldParts.Location = New System.Drawing.Point(0, 114)
        Me.tbMoldParts.Multiline = True
        Me.tbMoldParts.Name = "tbMoldParts"
        '
        '
        '
        Me.tbMoldParts.RootElement.StretchVertically = True
        Me.tbMoldParts.Size = New System.Drawing.Size(530, 104)
        Me.tbMoldParts.TabIndex = 25
        Me.tbMoldParts.ThemeName = "CrystalDark"
        '
        'tbInitialProb
        '
        Me.tbInitialProb.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbInitialProb.Location = New System.Drawing.Point(0, 250)
        Me.tbInitialProb.Multiline = True
        Me.tbInitialProb.Name = "tbInitialProb"
        '
        '
        '
        Me.tbInitialProb.RootElement.StretchVertically = True
        Me.tbInitialProb.Size = New System.Drawing.Size(530, 104)
        Me.tbInitialProb.TabIndex = 27
        Me.tbInitialProb.ThemeName = "CrystalDark"
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.RadPanel2.Controls.Add(Me.RadLabel1)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Location = New System.Drawing.Point(0, 218)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(530, 32)
        Me.RadPanel2.TabIndex = 26
        Me.RadPanel2.ThemeName = "Office2007Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(3, 9)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(127, 21)
        Me.RadLabel1.TabIndex = 11
        Me.RadLabel1.Text = "B. Initial Production"
        '
        'tbOthers
        '
        Me.tbOthers.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbOthers.Location = New System.Drawing.Point(0, 386)
        Me.tbOthers.Multiline = True
        Me.tbOthers.Name = "tbOthers"
        '
        '
        '
        Me.tbOthers.RootElement.StretchVertically = True
        Me.tbOthers.Size = New System.Drawing.Size(530, 115)
        Me.tbOthers.TabIndex = 29
        Me.tbOthers.ThemeName = "CrystalDark"
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.RadPanel3.Controls.Add(Me.RadLabel2)
        Me.RadPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel3.Location = New System.Drawing.Point(0, 354)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(530, 32)
        Me.RadPanel3.TabIndex = 28
        Me.RadPanel3.ThemeName = "Office2007Black"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(3, 9)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(62, 21)
        Me.RadLabel2.TabIndex = 11
        Me.RadLabel2.Text = "C. Others"
        '
        'ucDailyOtherDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.tbOthers)
        Me.Controls.Add(Me.RadPanel3)
        Me.Controls.Add(Me.tbInitialProb)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.tbMoldParts)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "ucDailyOtherDetails"
        Me.Size = New System.Drawing.Size(530, 478)
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMoldParts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInitialProb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        Me.RadPanel2.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOthers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        Me.RadPanel3.PerformLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClear As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbMoldParts As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents tbInitialProb As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbOthers As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
End Class
