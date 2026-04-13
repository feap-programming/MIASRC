<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucWeldingRMWIP
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWeldingRMWIP))
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ddAssy = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.spnEngExample = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.spnAdditional = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.spnNormal = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.spnComponent = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbSave = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClear = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarButton1 = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbTemplate = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarButton2 = New Telerik.WinControls.UI.CommandBarButton()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ddAssy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.spnEngExample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 93)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.AllowDeleteRow = False
        Me.gvData.MasterTemplate.AllowDragToGroup = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvData.Size = New System.Drawing.Size(958, 478)
        Me.gvData.TabIndex = 24
        Me.gvData.ThemeName = "CrystalDark"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ddAssy)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 36)
        Me.Panel1.TabIndex = 25
        '
        'ddAssy
        '
        Me.ddAssy.DropDownAnimationEnabled = True
        Me.ddAssy.Location = New System.Drawing.Point(112, 7)
        Me.ddAssy.Name = "ddAssy"
        Me.ddAssy.Size = New System.Drawing.Size(231, 20)
        Me.ddAssy.TabIndex = 21
        Me.ddAssy.Text = "RadDropDownList1"
        Me.ddAssy.ThemeName = "Office2007Black"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Assembly Number:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.spnEngExample)
        Me.Panel2.Controls.Add(Me.RadLabel4)
        Me.Panel2.Controls.Add(Me.spnAdditional)
        Me.Panel2.Controls.Add(Me.RadLabel3)
        Me.Panel2.Controls.Add(Me.spnNormal)
        Me.Panel2.Controls.Add(Me.RadLabel2)
        Me.Panel2.Controls.Add(Me.spnComponent)
        Me.Panel2.Controls.Add(Me.RadLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 571)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(958, 132)
        Me.Panel2.TabIndex = 26
        Me.Panel2.Visible = False
        '
        'spnEngExample
        '
        Me.spnEngExample.Location = New System.Drawing.Point(180, 91)
        Me.spnEngExample.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnEngExample.Name = "spnEngExample"
        Me.spnEngExample.Size = New System.Drawing.Size(256, 20)
        Me.spnEngExample.TabIndex = 3
        Me.spnEngExample.ThemeName = "Office2007Black"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(94, 91)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(93, 20)
        Me.RadLabel4.TabIndex = 2
        Me.RadLabel4.Text = "Eng'g Sample:"
        Me.RadLabel4.ThemeName = "CrystalDark"
        '
        'spnAdditional
        '
        Me.spnAdditional.Location = New System.Drawing.Point(179, 65)
        Me.spnAdditional.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnAdditional.Name = "spnAdditional"
        Me.spnAdditional.Size = New System.Drawing.Size(256, 20)
        Me.spnAdditional.TabIndex = 5
        Me.spnAdditional.ThemeName = "Office2007Black"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(10, 65)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(182, 20)
        Me.RadLabel3.TabIndex = 4
        Me.RadLabel3.Text = "QA (QC) Sample [Additional]:"
        Me.RadLabel3.ThemeName = "CrystalDark"
        '
        'spnNormal
        '
        Me.spnNormal.Location = New System.Drawing.Point(179, 39)
        Me.spnNormal.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnNormal.Name = "spnNormal"
        Me.spnNormal.Size = New System.Drawing.Size(256, 20)
        Me.spnNormal.TabIndex = 3
        Me.spnNormal.ThemeName = "Office2007Black"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(24, 39)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(165, 20)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "QA (QC) Sample [Normal]:"
        Me.RadLabel2.ThemeName = "CrystalDark"
        '
        'spnComponent
        '
        Me.spnComponent.Location = New System.Drawing.Point(179, 13)
        Me.spnComponent.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnComponent.Name = "spnComponent"
        Me.spnComponent.Size = New System.Drawing.Size(256, 20)
        Me.spnComponent.TabIndex = 1
        Me.spnComponent.ThemeName = "Office2007Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(44, 13)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(144, 20)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Component Scrap Qty:"
        Me.RadLabel1.ThemeName = "CrystalDark"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(958, 57)
        Me.RadCommandBar1.TabIndex = 27
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbSave, Me.cbbClear, Me.CommandBarButton1})
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
        'CommandBarButton1
        '
        Me.CommandBarButton1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarButton1.DisplayName = "CommandBarButton1"
        Me.CommandBarButton1.DrawText = True
        Me.CommandBarButton1.Image = CType(resources.GetObject("CommandBarButton1.Image"), System.Drawing.Image)
        Me.CommandBarButton1.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.CommandBarButton1.Name = "CommandBarButton1"
        Me.CommandBarButton1.Text = "Templates"
        Me.CommandBarButton1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.CommandBarButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CommandBarButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarButton1.UseCompatibleTextRendering = False
        '
        'cbbTemplate
        '
        Me.cbbTemplate.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbTemplate.DisplayName = "CommandBarButton1"
        Me.cbbTemplate.DrawText = True
        Me.cbbTemplate.Image = CType(resources.GetObject("cbbTemplate.Image"), System.Drawing.Image)
        Me.cbbTemplate.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.cbbTemplate.Name = "cbbTemplate"
        Me.cbbTemplate.Text = "Templates"
        Me.cbbTemplate.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.cbbTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbTemplate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbTemplate.UseCompatibleTextRendering = False
        '
        'CommandBarButton2
        '
        Me.CommandBarButton2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarButton2.DisplayName = "CommandBarButton1"
        Me.CommandBarButton2.DrawText = True
        Me.CommandBarButton2.Image = CType(resources.GetObject("CommandBarButton2.Image"), System.Drawing.Image)
        Me.CommandBarButton2.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.CommandBarButton2.Name = "CommandBarButton2"
        Me.CommandBarButton2.Text = "Templates"
        Me.CommandBarButton2.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.CommandBarButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CommandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarButton2.UseCompatibleTextRendering = False
        '
        'ucWeldingRMWIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ucWeldingRMWIP"
        Me.Size = New System.Drawing.Size(958, 703)
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ddAssy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.spnEngExample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents spnComponent As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnEngExample As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnAdditional As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnNormal As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddAssy As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label1 As Label
    Friend WithEvents cbbTemplate As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarButton2 As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClear As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarButton1 As Telerik.WinControls.UI.CommandBarButton
End Class
