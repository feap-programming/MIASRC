<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoice
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInvoice))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAddInvoice = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAddItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbUploaderTemplate = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbReport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.cmActionChooser = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.miCopy = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.miGenerateInvoice = New Telerik.WinControls.UI.RadMenuItem()
        Me.miViewItems = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEditInvoice = New Telerik.WinControls.UI.RadMenuItem()
        Me.pnlControls = New Telerik.WinControls.UI.RadPanel()
        Me.dtDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDateTo = New Telerik.WinControls.UI.RadLabel()
        Me.lblDateFrom = New Telerik.WinControls.UI.RadLabel()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        CType(Me.dtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 58)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(985, 83)
        Me.RadCommandBar1.TabIndex = 1
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAddInvoice, Me.cbbAddItem, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbUploaderTemplate, Me.CommandBarSeparator5, Me.cbbReport, Me.CommandBarSeparator3, Me.cbddOptions})
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
        'cbbAddInvoice
        '
        Me.cbbAddInvoice.AutoSize = False
        Me.cbbAddInvoice.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbAddInvoice.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAddInvoice.DisplayName = "Add Record"
        Me.cbbAddInvoice.DrawText = True
        Me.cbbAddInvoice.Image = CType(resources.GetObject("cbbAddInvoice.Image"), System.Drawing.Image)
        Me.cbbAddInvoice.Name = "cbbAddInvoice"
        Me.cbbAddInvoice.Text = "Add Invoice"
        Me.cbbAddInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbAddInvoice.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAddInvoice.UseCompatibleTextRendering = False
        '
        'cbbAddItem
        '
        Me.cbbAddItem.AutoSize = False
        Me.cbbAddItem.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbAddItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAddItem.DisplayName = "CommandBarButton1"
        Me.cbbAddItem.DrawText = True
        Me.cbbAddItem.Image = CType(resources.GetObject("cbbAddItem.Image"), System.Drawing.Image)
        Me.cbbAddItem.Name = "cbbAddItem"
        Me.cbbAddItem.Text = "Add Item"
        Me.cbbAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbAddItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAddItem.UseCompatibleTextRendering = False
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
        'cbUploaderTemplate
        '
        Me.cbUploaderTemplate.AutoSize = False
        Me.cbUploaderTemplate.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbUploaderTemplate.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbUploaderTemplate.DisplayName = "CommandBarButton1"
        Me.cbUploaderTemplate.DrawText = True
        Me.cbUploaderTemplate.Image = CType(resources.GetObject("cbUploaderTemplate.Image"), System.Drawing.Image)
        Me.cbUploaderTemplate.Name = "cbUploaderTemplate"
        Me.cbUploaderTemplate.Text = "Template"
        Me.cbUploaderTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbUploaderTemplate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbUploaderTemplate.UseCompatibleTextRendering = False
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
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator3.DisplayName = "Separator 3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator3.UseCompatibleTextRendering = False
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
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
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 543)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(985, 27)
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
        Me.gvData.Location = New System.Drawing.Point(0, 141)
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
        Me.gvData.Size = New System.Drawing.Size(985, 402)
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
        Me.cmActionChooser.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miCopy, Me.RadMenuSeparatorItem1, Me.miGenerateInvoice, Me.miViewItems, Me.miEditInvoice})
        Me.cmActionChooser.ThemeName = "CrystalDark"
        '
        'miCopy
        '
        Me.miCopy.Image = Global.MIA.My.Resources.Resources.clipboard
        Me.miCopy.Name = "miCopy"
        Me.miCopy.Text = "Copy"
        Me.miCopy.UseCompatibleTextRendering = False
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadMenuSeparatorItem1.UseCompatibleTextRendering = False
        '
        'miGenerateInvoice
        '
        Me.miGenerateInvoice.Image = CType(resources.GetObject("miGenerateInvoice.Image"), System.Drawing.Image)
        Me.miGenerateInvoice.Name = "miGenerateInvoice"
        Me.miGenerateInvoice.Text = "Generate Invoice"
        '
        'miViewItems
        '
        Me.miViewItems.Image = CType(resources.GetObject("miViewItems.Image"), System.Drawing.Image)
        Me.miViewItems.Name = "miViewItems"
        Me.miViewItems.Text = "View Item/s"
        '
        'miEditInvoice
        '
        Me.miEditInvoice.Image = Global.MIA.My.Resources.Resources.pencil
        Me.miEditInvoice.Name = "miEditInvoice"
        Me.miEditInvoice.Text = "Edit Invoice"
        Me.miEditInvoice.UseCompatibleTextRendering = False
        '
        'pnlControls
        '
        Me.pnlControls.Controls.Add(Me.dtDateTo)
        Me.pnlControls.Controls.Add(Me.dtDateFrom)
        Me.pnlControls.Controls.Add(Me.lblDateTo)
        Me.pnlControls.Controls.Add(Me.lblDateFrom)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(985, 58)
        Me.pnlControls.TabIndex = 0
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "MMM dd, yyyy"
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(73, 32)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(116, 20)
        Me.dtDateTo.TabIndex = 2
        Me.dtDateTo.TabStop = False
        Me.dtDateTo.Text = "Feb 21, 2022"
        Me.dtDateTo.ThemeName = "Office2010Black"
        Me.dtDateTo.Value = New Date(2022, 2, 21, 9, 15, 21, 272)
        '
        'dtDateFrom
        '
        Me.dtDateFrom.CustomFormat = "MMM dd, yyyy"
        Me.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrom.Location = New System.Drawing.Point(73, 6)
        Me.dtDateFrom.Name = "dtDateFrom"
        Me.dtDateFrom.Size = New System.Drawing.Size(116, 20)
        Me.dtDateFrom.TabIndex = 1
        Me.dtDateFrom.TabStop = False
        Me.dtDateFrom.Text = "Feb 21, 2022"
        Me.dtDateFrom.ThemeName = "Office2010Black"
        Me.dtDateFrom.Value = New Date(2022, 2, 21, 9, 15, 21, 272)
        '
        'lblDateTo
        '
        Me.lblDateTo.ForeColor = System.Drawing.Color.White
        Me.lblDateTo.Location = New System.Drawing.Point(22, 32)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(45, 18)
        Me.lblDateTo.TabIndex = 0
        Me.lblDateTo.Text = "Date To"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.ForeColor = System.Drawing.Color.White
        Me.lblDateFrom.Location = New System.Drawing.Point(8, 8)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(59, 18)
        Me.lblDateFrom.TabIndex = 0
        Me.lblDateFrom.Text = "Date From"
        '
        'FrmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 570)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Invoice"
        Me.ThemeName = "CrystalDark"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.dtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAddInvoice As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAddItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbUploaderTemplate As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbReport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
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
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cmActionChooser As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents miCopy As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEditInvoice As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents miGenerateInvoice As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miViewItems As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents pnlControls As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dtDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblDateTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDateFrom As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
End Class

