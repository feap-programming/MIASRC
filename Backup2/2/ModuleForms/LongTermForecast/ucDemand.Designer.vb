<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDemand
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDemand))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbImportData = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbReport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.cbbBudget = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.cmActionChooser = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.miCopy = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEdit = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.miHistory = New Telerik.WinControls.UI.RadMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.pnlControls = New Telerik.WinControls.UI.RadPanel()
        Me.pnlFilters = New Telerik.WinControls.UI.RadPanel()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.ddCustomerCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomerCode = New Telerik.WinControls.UI.RadLabel()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        CType(Me.pnlFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilters.SuspendLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadCommandBar1.Location = New System.Drawing.Point(200, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(790, 83)
        Me.RadCommandBar1.TabIndex = 1
        Me.RadCommandBar1.ThemeName = "Office2010Black"
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
        Me.CommandBarStripElement1.DisplayName = "Tool Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbImportData, Me.cbExport, Me.CommandBarSeparator3, Me.cbbReport, Me.CommandBarSeparator5, Me.cbddOptions, Me.cbbBudget})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'cbbRefresh
        '
        Me.cbbRefresh.AutoSize = False
        Me.cbbRefresh.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbRefresh.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbRefresh.DisplayName = "Refresh"
        Me.cbbRefresh.DrawText = True
        Me.cbbRefresh.Image = CType(resources.GetObject("cbbRefresh.Image"), System.Drawing.Image)
        Me.cbbRefresh.Name = "cbbRefresh"
        Me.cbbRefresh.Text = "Refresh"
        Me.cbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbRefresh.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbRefresh.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.DisplayName = "Separator 1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.UseCompatibleTextRendering = False
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cbbDelete
        '
        Me.cbbDelete.AutoSize = False
        Me.cbbDelete.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbDelete.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDelete.DisplayName = "Delete Record"
        Me.cbbDelete.DrawText = True
        Me.cbbDelete.Image = CType(resources.GetObject("cbbDelete.Image"), System.Drawing.Image)
        Me.cbbDelete.Name = "cbbDelete"
        Me.cbbDelete.Text = "Delete Record"
        Me.cbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDelete.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.UseCompatibleTextRendering = False
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cbImportData
        '
        Me.cbImportData.AutoSize = False
        Me.cbImportData.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbImportData.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbImportData.DisplayName = "Import Data"
        Me.cbImportData.DrawText = True
        Me.cbImportData.Image = CType(resources.GetObject("cbImportData.Image"), System.Drawing.Image)
        Me.cbImportData.Name = "cbImportData"
        Me.cbImportData.Text = "Import Data"
        Me.cbImportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbImportData.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbImportData.UseCompatibleTextRendering = False
        '
        'cbExport
        '
        Me.cbExport.AutoSize = False
        Me.cbExport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbExport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbExport.DisplayName = "Export Data"
        Me.cbExport.DrawText = True
        Me.cbExport.Image = CType(resources.GetObject("cbExport.Image"), System.Drawing.Image)
        Me.cbExport.Name = "cbExport"
        Me.cbExport.Text = "Export Data"
        Me.cbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbExport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbExport.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator3.DisplayName = "Separator 3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator3.UseCompatibleTextRendering = False
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'cbbReport
        '
        Me.cbbReport.AutoSize = False
        Me.cbbReport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbReport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbReport.DisplayName = "CommandBarButton1"
        Me.cbbReport.DrawText = True
        Me.cbbReport.Image = CType(resources.GetObject("cbbReport.Image"), System.Drawing.Image)
        Me.cbbReport.Name = "cbbReport"
        Me.cbbReport.Text = "Report"
        Me.cbbReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbReport.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator5.DisplayName = "CommandBarSeparator5"
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator5.UseCompatibleTextRendering = False
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'cbddOptions
        '
        Me.cbddOptions.AutoSize = False
        Me.cbddOptions.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbddOptions.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbddOptions.DisplayName = "Options"
        Me.cbddOptions.DrawText = True
        Me.cbddOptions.Image = CType(resources.GetObject("cbddOptions.Image"), System.Drawing.Image)
        Me.cbddOptions.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miEnableFiltering, Me.miEnableGrouping})
        Me.cbddOptions.Name = "cbddOptions"
        Me.cbddOptions.Text = "Options"
        Me.cbddOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbddOptions.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbddOptions.UseCompatibleTextRendering = False
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
        'cbbBudget
        '
        Me.cbbBudget.DisplayName = "CommandBarButton1"
        Me.cbbBudget.DrawText = True
        Me.cbbBudget.FlipText = False
        Me.cbbBudget.Image = CType(resources.GetObject("cbbBudget.Image"), System.Drawing.Image)
        Me.cbbBudget.Name = "cbbBudget"
        Me.cbbBudget.Text = "Budget Anount"
        Me.cbbBudget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 561)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(990, 29)
        Me.RadStatusStrip1.TabIndex = 3
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Records Found:"
        Me.RadLabelElement1.TextWrap = True
        Me.RadLabelElement1.UseCompatibleTextRendering = False
        '
        'leCountRec
        '
        Me.leCountRec.Name = "leCountRec"
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, True)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        Me.leCountRec.UseCompatibleTextRendering = False
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = "Permission:"
        Me.RadLabelElement2.TextWrap = True
        Me.RadLabelElement2.UseCompatibleTextRendering = False
        '
        'lePermission
        '
        Me.lePermission.Name = "lePermission"
        Me.RadStatusStrip1.SetSpring(Me.lePermission, False)
        Me.lePermission.Text = "lePermission"
        Me.lePermission.TextWrap = True
        Me.lePermission.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator4, False)
        Me.CommandBarSeparator4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator4.UseCompatibleTextRendering = False
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'RadProgressBarElement1
        '
        Me.RadProgressBarElement1.AutoSize = False
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 21)
        Me.RadProgressBarElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
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
        Me.RadProgressBarElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.RadProgressBarElement1.UseCompatibleTextRendering = False
        '
        'gvData
        '
        Me.gvData.AutoScroll = True
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gvData.Location = New System.Drawing.Point(0, 58)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.AllowDeleteRow = False
        Me.gvData.MasterTemplate.EnableFiltering = True
        Me.gvData.MasterTemplate.MultiSelect = True
        Me.gvData.MasterTemplate.ShowFilteringRow = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.ShowGroupPanel = False
        Me.gvData.Size = New System.Drawing.Size(990, 503)
        Me.gvData.TabIndex = 2
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        Me.bwLoadData.WorkerSupportsCancellation = True
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'cmActionChooser
        '
        Me.cmActionChooser.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miCopy, Me.miEdit, Me.RadMenuSeparatorItem1, Me.miHistory})
        Me.cmActionChooser.ThemeName = "CrystalDark"
        '
        'miCopy
        '
        Me.miCopy.Name = "miCopy"
        Me.miCopy.Text = "Copy"
        Me.miCopy.UseCompatibleTextRendering = False
        '
        'miEdit
        '
        Me.miEdit.Name = "miEdit"
        Me.miEdit.Text = "Edit"
        Me.miEdit.UseCompatibleTextRendering = False
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadMenuSeparatorItem1.UseCompatibleTextRendering = False
        '
        'miHistory
        '
        Me.miHistory.Name = "miHistory"
        Me.miHistory.Text = "History"
        Me.miHistory.UseCompatibleTextRendering = False
        '
        'pnlControls
        '
        Me.pnlControls.Controls.Add(Me.RadCommandBar1)
        Me.pnlControls.Controls.Add(Me.pnlFilters)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(990, 58)
        Me.pnlControls.TabIndex = 0
        '
        'pnlFilters
        '
        Me.pnlFilters.Controls.Add(Me.numYear)
        Me.pnlFilters.Controls.Add(Me.ddCustomerCode)
        Me.pnlFilters.Controls.Add(Me.RadLabel1)
        Me.pnlFilters.Controls.Add(Me.lblCustomerCode)
        Me.pnlFilters.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFilters.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(200, 58)
        Me.pnlFilters.TabIndex = 0
        Me.pnlFilters.ThemeName = "Office2010Black"
        '
        'numYear
        '
        Me.numYear.Location = New System.Drawing.Point(78, 6)
        Me.numYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.Size = New System.Drawing.Size(116, 20)
        Me.numYear.TabIndex = 1
        Me.numYear.ThemeName = "Office2010Black"
        '
        'ddCustomerCode
        '
        '
        'ddCustomerCode.NestedRadGridView
        '
        Me.ddCustomerCode.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddCustomerCode.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddCustomerCode.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddCustomerCode.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.ddCustomerCode.EditorControl.Name = "NestedRadGridView"
        Me.ddCustomerCode.EditorControl.ReadOnly = True
        Me.ddCustomerCode.EditorControl.ShowGroupPanel = False
        Me.ddCustomerCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddCustomerCode.EditorControl.TabIndex = 0
        Me.ddCustomerCode.Location = New System.Drawing.Point(78, 32)
        Me.ddCustomerCode.Name = "ddCustomerCode"
        Me.ddCustomerCode.Size = New System.Drawing.Size(116, 20)
        Me.ddCustomerCode.TabIndex = 2
        Me.ddCustomerCode.TabStop = False
        Me.ddCustomerCode.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(44, 7)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(28, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Year"
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerCode.Location = New System.Drawing.Point(17, 34)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomerCode.TabIndex = 0
        Me.lblCustomerCode.Text = "Customer"
        '
        'ucDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Name = "ucDemand"
        Me.Size = New System.Drawing.Size(990, 590)
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.pnlFilters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbImportData As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbReport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cmActionChooser As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents miCopy As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEdit As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents miHistory As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents pnlControls As Telerik.WinControls.UI.RadPanel
    Friend WithEvents pnlFilters As Telerik.WinControls.UI.RadPanel
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents ddCustomerCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomerCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents cbbBudget As Telerik.WinControls.UI.CommandBarButton
End Class
