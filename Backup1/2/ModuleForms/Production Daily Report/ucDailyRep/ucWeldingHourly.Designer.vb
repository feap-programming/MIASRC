<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWeldingHourly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWeldingHourly))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbSave = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClear = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbPlan = New Telerik.WinControls.UI.CommandBarButton()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ddType = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblType = New System.Windows.Forms.Label()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1011, 82)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbSave, Me.cbbClear, Me.cbbPlan})
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
        'cbbPlan
        '
        Me.cbbPlan.DisplayName = "Plan"
        Me.cbbPlan.DrawText = True
        Me.cbbPlan.Image = CType(resources.GetObject("cbbPlan.Image"), System.Drawing.Image)
        Me.cbbPlan.MaxSize = New System.Drawing.Size(100, 51)
        Me.cbbPlan.Name = "cbbPlan"
        Me.cbbPlan.Text = "Plan"
        Me.cbbPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 117)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.AllowDeleteRow = False
        Me.gvData.MasterTemplate.AllowDragToGroup = False
        Me.gvData.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvData.Size = New System.Drawing.Size(1011, 487)
        Me.gvData.TabIndex = 16
        Me.gvData.ThemeName = "CrystalDark"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ddType)
        Me.Panel1.Controls.Add(Me.lblType)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 35)
        Me.Panel1.TabIndex = 19
        '
        'ddType
        '
        Me.ddType.DropDownAnimationEnabled = True
        Me.ddType.Location = New System.Drawing.Point(37, 9)
        Me.ddType.Name = "ddType"
        Me.ddType.Size = New System.Drawing.Size(125, 20)
        Me.ddType.TabIndex = 17
        Me.ddType.Text = "RadDropDownList1"
        Me.ddType.ThemeName = "Office2007Black"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(8, 13)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(28, 13)
        Me.lblType.TabIndex = 16
        Me.lblType.Text = "PW-"
        '
        'ucWeldingHourly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "ucWeldingHourly"
        Me.Size = New System.Drawing.Size(1011, 604)
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClear As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ddType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblType As Label
    Friend WithEvents cbbPlan As Telerik.WinControls.UI.CommandBarButton
End Class
