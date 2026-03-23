<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLinePerWarehouse
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLinePerWarehouse))
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.mcbLine = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbWarehouse = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAddRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbImportData = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbExportData = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwDelete = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.mcbLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbLine.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbLine.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbWarehouse.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbWarehouse.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.mcbLine)
        Me.RadPanel1.Controls.Add(Me.mcbWarehouse)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(863, 91)
        Me.RadPanel1.TabIndex = 0
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'mcbLine
        '
        '
        'mcbLine.NestedRadGridView
        '
        Me.mcbLine.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbLine.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbLine.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbLine.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbLine.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbLine.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbLine.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbLine.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbLine.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbLine.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbLine.EditorControl.Name = "NestedRadGridView"
        Me.mcbLine.EditorControl.ReadOnly = True
        Me.mcbLine.EditorControl.ShowGroupPanel = False
        Me.mcbLine.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbLine.EditorControl.TabIndex = 0
        Me.mcbLine.Location = New System.Drawing.Point(122, 46)
        Me.mcbLine.Name = "mcbLine"
        Me.mcbLine.Size = New System.Drawing.Size(222, 20)
        Me.mcbLine.TabIndex = 3
        Me.mcbLine.TabStop = False
        '
        'mcbWarehouse
        '
        '
        'mcbWarehouse.NestedRadGridView
        '
        Me.mcbWarehouse.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbWarehouse.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbWarehouse.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbWarehouse.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbWarehouse.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbWarehouse.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbWarehouse.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbWarehouse.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbWarehouse.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbWarehouse.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbWarehouse.EditorControl.Name = "NestedRadGridView"
        Me.mcbWarehouse.EditorControl.ReadOnly = True
        Me.mcbWarehouse.EditorControl.ShowGroupPanel = False
        Me.mcbWarehouse.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbWarehouse.EditorControl.TabIndex = 0
        Me.mcbWarehouse.Location = New System.Drawing.Point(122, 20)
        Me.mcbWarehouse.Name = "mcbWarehouse"
        Me.mcbWarehouse.Size = New System.Drawing.Size(222, 20)
        Me.mcbWarehouse.TabIndex = 2
        Me.mcbWarehouse.TabStop = False
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(87, 48)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(29, 18)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "Line:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(51, 22)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(65, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Warehouse:"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 91)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(863, 81)
        Me.RadCommandBar1.TabIndex = 1
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "Tool Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator2, Me.cbbAddRecord, Me.cbbDeleteRecord, Me.CommandBarSeparator3, Me.cbbImportData, Me.cbbExportData, Me.CommandBarSeparator4, Me.cbbOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        '
        'cbbRefresh
        '
        Me.cbbRefresh.AutoSize = False
        Me.cbbRefresh.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbRefresh.DisplayName = "Refresh"
        Me.cbbRefresh.DrawText = True
        Me.cbbRefresh.Image = CType(resources.GetObject("cbbRefresh.Image"), System.Drawing.Image)
        Me.cbbRefresh.Name = "cbbRefresh"
        Me.cbbRefresh.Text = "Refresh"
        Me.cbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisplayName = "Separator 1"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cbbAddRecord
        '
        Me.cbbAddRecord.AutoSize = False
        Me.cbbAddRecord.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbAddRecord.DisplayName = "Add Record"
        Me.cbbAddRecord.DrawText = True
        Me.cbbAddRecord.Image = CType(resources.GetObject("cbbAddRecord.Image"), System.Drawing.Image)
        Me.cbbAddRecord.Name = "cbbAddRecord"
        Me.cbbAddRecord.Text = "Add Record"
        Me.cbbAddRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbDeleteRecord
        '
        Me.cbbDeleteRecord.AutoSize = False
        Me.cbbDeleteRecord.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbDeleteRecord.DisplayName = "Delete Record"
        Me.cbbDeleteRecord.DrawText = True
        Me.cbbDeleteRecord.Image = CType(resources.GetObject("cbbDeleteRecord.Image"), System.Drawing.Image)
        Me.cbbDeleteRecord.Name = "cbbDeleteRecord"
        Me.cbbDeleteRecord.Text = "Delete Record"
        Me.cbbDeleteRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisplayName = "Separator 2"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'cbbImportData
        '
        Me.cbbImportData.AutoSize = False
        Me.cbbImportData.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbImportData.DisplayName = "Import Data"
        Me.cbbImportData.DrawText = True
        Me.cbbImportData.Image = CType(resources.GetObject("cbbImportData.Image"), System.Drawing.Image)
        Me.cbbImportData.Name = "cbbImportData"
        Me.cbbImportData.Text = "Import Data"
        Me.cbbImportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbExportData
        '
        Me.cbbExportData.AutoSize = False
        Me.cbbExportData.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbExportData.DisplayName = "Export Data"
        Me.cbbExportData.DrawText = True
        Me.cbbExportData.Image = CType(resources.GetObject("cbbExportData.Image"), System.Drawing.Image)
        Me.cbbExportData.Name = "cbbExportData"
        Me.cbbExportData.Text = "Export Data"
        Me.cbbExportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.DisplayName = "Separator 3"
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'cbbOptions
        '
        Me.cbbOptions.AutoSize = False
        Me.cbbOptions.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbOptions.DisplayName = "Options"
        Me.cbbOptions.DrawText = True
        Me.cbbOptions.Image = CType(resources.GetObject("cbbOptions.Image"), System.Drawing.Image)
        Me.cbbOptions.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miEnableFiltering, Me.miEnableGrouping})
        Me.cbbOptions.Name = "cbbOptions"
        Me.cbbOptions.Text = "Options"
        Me.cbbOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miEnableFiltering
        '
        Me.miEnableFiltering.CheckOnClick = True
        Me.miEnableFiltering.Name = "miEnableFiltering"
        Me.miEnableFiltering.Text = "Enable Filtering"
        '
        'miEnableGrouping
        '
        Me.miEnableGrouping.CheckOnClick = True
        Me.miEnableGrouping.Name = "miEnableGrouping"
        Me.miEnableGrouping.Text = "Enable Grouping"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator1, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 563)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(863, 26)
        Me.RadStatusStrip1.TabIndex = 2
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Records Found:"
        Me.RadLabelElement1.TextWrap = True
        '
        'leCountRec
        '
        Me.leCountRec.Name = "leCountRec"
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, True)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = "Permission:"
        Me.RadLabelElement2.TextWrap = True
        '
        'lePermission
        '
        Me.lePermission.Name = "lePermission"
        Me.RadStatusStrip1.SetSpring(Me.lePermission, False)
        Me.lePermission.Text = "lePermission"
        Me.lePermission.TextWrap = True
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator1, False)
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'RadProgressBarElement1
        '
        Me.RadProgressBarElement1.AutoSize = False
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 18)
        Me.RadProgressBarElement1.Name = "RadProgressBarElement1"
        Me.RadProgressBarElement1.SeparatorColor1 = System.Drawing.Color.White
        Me.RadProgressBarElement1.SeparatorColor2 = System.Drawing.Color.White
        Me.RadProgressBarElement1.SeparatorColor3 = System.Drawing.Color.White
        Me.RadProgressBarElement1.SeparatorColor4 = System.Drawing.Color.White
        Me.RadProgressBarElement1.SeparatorGradientAngle = 0
        Me.RadProgressBarElement1.SeparatorGradientPercentage1 = 0.4!
        Me.RadProgressBarElement1.SeparatorGradientPercentage2 = 0.6!
        Me.RadProgressBarElement1.SeparatorNumberOfColors = 2
        Me.RadStatusStrip1.SetSpring(Me.RadProgressBarElement1, False)
        Me.RadProgressBarElement1.StepWidth = 14
        Me.RadProgressBarElement1.SweepAngle = 90
        Me.RadProgressBarElement1.Text = ""
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 172)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(863, 391)
        Me.gvData.TabIndex = 3
        '
        'bwLoadData
        '
        '
        'bwDelete
        '
        Me.bwDelete.WorkerReportsProgress = True
        '
        'FrmLinePerWarehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 589)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmLinePerWarehouse"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Line Per Warehouse"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.mcbLine.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbLine.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbWarehouse.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbWarehouse.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAddRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDeleteRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbImportData As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbExportData As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents mcbLine As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbWarehouse As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwDelete As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class

