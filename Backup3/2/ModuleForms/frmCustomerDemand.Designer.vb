<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerDemand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerDemand))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbImportData = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.cbReport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.mcbModel = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlModel = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.dtpDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.seLatestDemand = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seForecast = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudget = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.mcbModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbModel.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlModel.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seLatestDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.DisplayName = "Tool Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbEdit, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbImportData, Me.cbExport, Me.CommandBarSeparator3, Me.cbddOptions, Me.cbReport})
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
        Me.CommandBarSeparator1.DisplayName = "Separator 1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cbbAdd
        '
        Me.cbbAdd.AutoSize = False
        Me.cbbAdd.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbAdd.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAdd.DisplayName = "Add Record"
        Me.cbbAdd.DrawText = True
        Me.cbbAdd.Image = CType(resources.GetObject("cbbAdd.Image"), System.Drawing.Image)
        Me.cbbAdd.Name = "cbbAdd"
        Me.cbbAdd.Text = "Add Record"
        Me.cbbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAdd.UseCompatibleTextRendering = False
        '
        'cbbEdit
        '
        Me.cbbEdit.AutoSize = False
        Me.cbbEdit.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbEdit.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbEdit.DisplayName = "Edit Record"
        Me.cbbEdit.DrawText = True
        Me.cbbEdit.Image = CType(resources.GetObject("cbbEdit.Image"), System.Drawing.Image)
        Me.cbbEdit.Name = "cbbEdit"
        Me.cbbEdit.Text = "Edit Record"
        Me.cbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbEdit.UseCompatibleTextRendering = False
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
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cbImportData
        '
        Me.cbImportData.AutoSize = False
        Me.cbImportData.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbImportData.DisplayName = "Import Data"
        Me.cbImportData.DrawText = True
        Me.cbImportData.Image = CType(resources.GetObject("cbImportData.Image"), System.Drawing.Image)
        Me.cbImportData.Name = "cbImportData"
        Me.cbImportData.Text = "Import Data"
        Me.cbImportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbExport
        '
        Me.cbExport.AutoSize = False
        Me.cbExport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbExport.DisplayName = "Export Data"
        Me.cbExport.DrawText = True
        Me.cbExport.Image = CType(resources.GetObject("cbExport.Image"), System.Drawing.Image)
        Me.cbExport.Name = "cbExport"
        Me.cbExport.Text = "Export Data"
        Me.cbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisplayName = "Separator 3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
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
        Me.miEnableFiltering.UseCompatibleTextRendering = False
        '
        'miEnableGrouping
        '
        Me.miEnableGrouping.CheckOnClick = True
        Me.miEnableGrouping.Name = "miEnableGrouping"
        Me.miEnableGrouping.Text = "Enable Grouping"
        Me.miEnableGrouping.UseCompatibleTextRendering = False
        '
        'cbReport
        '
        Me.cbReport.AutoSize = False
        Me.cbReport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbReport.DisplayName = "View Report"
        Me.cbReport.DrawText = True
        Me.cbReport.Image = CType(resources.GetObject("cbReport.Image"), System.Drawing.Image)
        Me.cbReport.Name = "cbReport"
        Me.cbReport.Text = "View Report"
        Me.cbReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 92)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(985, 81)
        Me.RadCommandBar1.TabIndex = 20
        '
        'RadLabel12
        '
        Me.RadLabel12.Location = New System.Drawing.Point(289, 34)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel12.TabIndex = 11
        Me.RadLabel12.Text = "Customer:"
        '
        'RadLabel15
        '
        Me.RadLabel15.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel15.Location = New System.Drawing.Point(44, 8)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(41, 18)
        Me.RadLabel15.TabIndex = 5
        Me.RadLabel15.Text = "Model:"
        '
        'gvData
        '
        Me.gvData.AutoScroll = True
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gvData.Location = New System.Drawing.Point(0, 173)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(985, 363)
        Me.gvData.TabIndex = 22
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.mcbModel)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.txtDescription)
        Me.RadPanel1.Controls.Add(Me.txtCustomer)
        Me.RadPanel1.Controls.Add(Me.ddlModel)
        Me.RadPanel1.Controls.Add(Me.dtpDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.seLatestDemand)
        Me.RadPanel1.Controls.Add(Me.seForecast)
        Me.RadPanel1.Controls.Add(Me.seBudget)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel12)
        Me.RadPanel1.Controls.Add(Me.RadLabel15)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(985, 92)
        Me.RadPanel1.TabIndex = 4
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'mcbModel
        '
        '
        'mcbModel.NestedRadGridView
        '
        Me.mcbModel.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbModel.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbModel.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbModel.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbModel.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbModel.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbModel.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbModel.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbModel.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbModel.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbModel.EditorControl.Name = "NestedRadGridView"
        Me.mcbModel.EditorControl.ReadOnly = True
        Me.mcbModel.EditorControl.ShowGroupPanel = False
        Me.mcbModel.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbModel.EditorControl.TabIndex = 0
        Me.mcbModel.Location = New System.Drawing.Point(352, 6)
        Me.mcbModel.Name = "mcbModel"
        Me.mcbModel.Size = New System.Drawing.Size(141, 20)
        Me.mcbModel.TabIndex = 2
        Me.mcbModel.TabStop = False
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(289, 10)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel6.TabIndex = 45
        Me.RadLabel6.Text = "FG Model:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(91, 33)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        '
        '
        '
        Me.txtDescription.RootElement.StretchVertically = True
        Me.txtDescription.Size = New System.Drawing.Size(141, 47)
        Me.txtDescription.TabIndex = 1
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(352, 31)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(141, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'ddlModel
        '
        '
        'ddlModel.NestedRadGridView
        '
        Me.ddlModel.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlModel.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlModel.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlModel.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlModel.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlModel.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlModel.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlModel.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlModel.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlModel.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.ddlModel.EditorControl.Name = "NestedRadGridView"
        Me.ddlModel.EditorControl.ReadOnly = True
        Me.ddlModel.EditorControl.ShowGroupPanel = False
        Me.ddlModel.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlModel.EditorControl.TabIndex = 0
        Me.ddlModel.Location = New System.Drawing.Point(91, 6)
        Me.ddlModel.Name = "ddlModel"
        Me.ddlModel.Size = New System.Drawing.Size(141, 20)
        Me.ddlModel.TabIndex = 0
        Me.ddlModel.TabStop = False
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = ""
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(352, 58)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(141, 20)
        Me.dtpDate.TabIndex = 4
        Me.dtpDate.TabStop = False
        Me.dtpDate.Text = "12/4/2018"
        Me.dtpDate.Value = New Date(2018, 12, 4, 13, 33, 4, 90)
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(314, 62)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(32, 18)
        Me.RadLabel4.TabIndex = 43
        Me.RadLabel4.Text = "Date:"
        '
        'seLatestDemand
        '
        Me.seLatestDemand.DecimalPlaces = 6
        Me.seLatestDemand.Location = New System.Drawing.Point(631, 59)
        Me.seLatestDemand.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seLatestDemand.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seLatestDemand.Name = "seLatestDemand"
        Me.seLatestDemand.ShowUpDownButtons = False
        Me.seLatestDemand.Size = New System.Drawing.Size(143, 20)
        Me.seLatestDemand.TabIndex = 7
        '
        'seForecast
        '
        Me.seForecast.DecimalPlaces = 6
        Me.seForecast.Location = New System.Drawing.Point(631, 33)
        Me.seForecast.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seForecast.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seForecast.Name = "seForecast"
        Me.seForecast.ShowUpDownButtons = False
        Me.seForecast.Size = New System.Drawing.Size(143, 20)
        Me.seForecast.TabIndex = 6
        '
        'seBudget
        '
        Me.seBudget.DecimalPlaces = 6
        Me.seBudget.Location = New System.Drawing.Point(631, 7)
        Me.seBudget.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudget.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seBudget.Name = "seBudget"
        Me.seBudget.ShowUpDownButtons = False
        Me.seBudget.Size = New System.Drawing.Size(143, 20)
        Me.seBudget.TabIndex = 5
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(541, 62)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(84, 18)
        Me.RadLabel2.TabIndex = 39
        Me.RadLabel2.Text = "Latest Demand:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(575, 35)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(50, 18)
        Me.RadLabel1.TabIndex = 38
        Me.RadLabel1.Text = "Forecast:"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(19, 35)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(66, 18)
        Me.RadLabel5.TabIndex = 11
        Me.RadLabel5.Text = "Description:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(580, 8)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel3.TabIndex = 37
        Me.RadLabel3.Text = "Budget:"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 536)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(985, 29)
        Me.RadStatusStrip1.TabIndex = 21
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
        '
        'lePermission
        '
        Me.lePermission.Name = "lePermission"
        Me.RadStatusStrip1.SetSpring(Me.lePermission, False)
        Me.lePermission.Text = "lePermission"
        Me.lePermission.TextWrap = True
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator4, False)
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
        'bwLoadData
        '
        '
        'FrmCustomerDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 565)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCustomerDemand"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Customer Demand"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.mcbModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbModel.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlModel.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seLatestDemand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seForecast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents seLatestDemand As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seForecast As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seBudget As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbImportData As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents ddlModel As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cbReport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents txtDescription As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents mcbModel As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
End Class

