<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCTFormulaSettings
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCTFormulaSettings))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.dbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbSave = New Telerik.WinControls.UI.CommandBarButton()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(573, 56)
        Me.RadCommandBar1.TabIndex = 0
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.dbbRefresh, Me.cbbSave})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        '
        '
        Me.CommandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        Me.CommandBarStripElement1.StretchHorizontally = True
        CType(Me.CommandBarStripElement1.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'dbbRefresh
        '
        Me.dbbRefresh.AutoSize = False
        Me.dbbRefresh.Bounds = New System.Drawing.Rectangle(0, 0, 60, 52)
        Me.dbbRefresh.DisplayName = "CommandBarButton1"
        Me.dbbRefresh.DrawText = True
        Me.dbbRefresh.Image = CType(resources.GetObject("dbbRefresh.Image"), System.Drawing.Image)
        Me.dbbRefresh.Name = "dbbRefresh"
        Me.dbbRefresh.Text = "Refresh"
        Me.dbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbSave
        '
        Me.cbbSave.AutoSize = False
        Me.cbbSave.Bounds = New System.Drawing.Rectangle(0, 0, 60, 52)
        Me.cbbSave.DisplayName = "CommandBarButton2"
        Me.cbbSave.DrawText = True
        Me.cbbSave.Image = CType(resources.GetObject("cbbSave.Image"), System.Drawing.Image)
        Me.cbbSave.Name = "cbbSave"
        Me.cbbSave.Text = "Save"
        Me.cbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 56)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(573, 257)
        Me.gvData.TabIndex = 1
        '
        'FrmCTFormulaSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 313)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCTFormulaSettings"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cost Table Formula Settings"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents dbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
End Class

