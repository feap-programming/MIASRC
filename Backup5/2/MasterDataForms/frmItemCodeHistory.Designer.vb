<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItemCodeHistory
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemCodeHistory))
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtNewItemCode = New Telerik.WinControls.UI.RadTextBox()
        Me.chkSpecialDemand = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpEffectivityDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.sePrice = New Telerik.WinControls.UI.RadSpinEditor()
        Me.txtAnnex = New Telerik.WinControls.UI.RadTextBox()
        Me.mcbCustomer = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAddRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbImport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtNewItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSpecialDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnnex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(908, 26)
        Me.RadStatusStrip1.TabIndex = 0
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
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator4, False)
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
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
        'RadPanel1
        '
        Me.RadPanel1.AutoScroll = True
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtNewItemCode)
        Me.RadPanel1.Controls.Add(Me.chkSpecialDemand)
        Me.RadPanel1.Controls.Add(Me.RadLabel8)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.txtRemarks)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.dtpEffectivityDate)
        Me.RadPanel1.Controls.Add(Me.sePrice)
        Me.RadPanel1.Controls.Add(Me.txtAnnex)
        Me.RadPanel1.Controls.Add(Me.mcbCustomer)
        Me.RadPanel1.Controls.Add(Me.mcbItemCode)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(908, 123)
        Me.RadPanel1.TabIndex = 1
        Me.RadPanel1.ThemeName = "MaterialTeal"
        '
        'txtNewItemCode
        '
        Me.txtNewItemCode.Location = New System.Drawing.Point(538, 12)
        Me.txtNewItemCode.Name = "txtNewItemCode"
        Me.txtNewItemCode.Size = New System.Drawing.Size(164, 20)
        Me.txtNewItemCode.TabIndex = 20
        '
        'chkSpecialDemand
        '
        Me.chkSpecialDemand.Location = New System.Drawing.Point(128, 65)
        Me.chkSpecialDemand.Name = "chkSpecialDemand"
        Me.chkSpecialDemand.Size = New System.Drawing.Size(101, 18)
        Me.chkSpecialDemand.TabIndex = 19
        Me.chkSpecialDemand.Text = "Special Demand"
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Location = New System.Drawing.Point(431, 14)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(86, 18)
        Me.RadLabel8.TabIndex = 18
        Me.RadLabel8.Text = "New Item Code:"
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Location = New System.Drawing.Point(481, 93)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel6.TabIndex = 16
        Me.RadLabel6.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(538, 91)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(269, 20)
        Me.txtRemarks.TabIndex = 15
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Location = New System.Drawing.Point(449, 67)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(83, 18)
        Me.RadLabel5.TabIndex = 14
        Me.RadLabel5.Text = "Effectivity Date:"
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Location = New System.Drawing.Point(499, 40)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(33, 18)
        Me.RadLabel4.TabIndex = 13
        Me.RadLabel4.Text = "Price:"
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(82, 92)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(40, 18)
        Me.RadLabel3.TabIndex = 12
        Me.RadLabel3.Text = "Annex:"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(65, 41)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel2.TabIndex = 11
        Me.RadLabel2.Text = "Customer:"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(61, 14)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel1.TabIndex = 10
        Me.RadLabel1.Text = "Item Code:"
        '
        'dtpEffectivityDate
        '
        Me.dtpEffectivityDate.Location = New System.Drawing.Point(538, 65)
        Me.dtpEffectivityDate.Name = "dtpEffectivityDate"
        Me.dtpEffectivityDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpEffectivityDate.TabIndex = 4
        Me.dtpEffectivityDate.TabStop = False
        Me.dtpEffectivityDate.Text = "Tuesday, December 4, 2018"
        Me.dtpEffectivityDate.Value = New Date(2018, 12, 4, 13, 33, 4, 90)
        '
        'sePrice
        '
        Me.sePrice.DecimalPlaces = 2
        Me.sePrice.Location = New System.Drawing.Point(538, 39)
        Me.sePrice.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.sePrice.Name = "sePrice"
        Me.sePrice.ShowUpDownButtons = False
        Me.sePrice.Size = New System.Drawing.Size(164, 20)
        Me.sePrice.TabIndex = 3
        '
        'txtAnnex
        '
        Me.txtAnnex.Location = New System.Drawing.Point(128, 90)
        Me.txtAnnex.Name = "txtAnnex"
        Me.txtAnnex.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnex.TabIndex = 2
        '
        'mcbCustomer
        '
        '
        'mcbCustomer.NestedRadGridView
        '
        Me.mcbCustomer.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbCustomer.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbCustomer.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbCustomer.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbCustomer.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbCustomer.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbCustomer.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbCustomer.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbCustomer.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbCustomer.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbCustomer.EditorControl.Name = "NestedRadGridView"
        Me.mcbCustomer.EditorControl.ReadOnly = True
        Me.mcbCustomer.EditorControl.ShowGroupPanel = False
        Me.mcbCustomer.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbCustomer.EditorControl.TabIndex = 0
        Me.mcbCustomer.Location = New System.Drawing.Point(128, 39)
        Me.mcbCustomer.Name = "mcbCustomer"
        Me.mcbCustomer.Size = New System.Drawing.Size(258, 20)
        Me.mcbCustomer.TabIndex = 1
        Me.mcbCustomer.TabStop = False
        '
        'mcbItemCode
        '
        '
        'mcbItemCode.NestedRadGridView
        '
        Me.mcbItemCode.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbItemCode.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbItemCode.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbItemCode.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbItemCode.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbItemCode.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(128, 12)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(258, 20)
        Me.mcbItemCode.TabIndex = 0
        Me.mcbItemCode.TabStop = False
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 123)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(908, 56)
        Me.RadCommandBar1.TabIndex = 2
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAddRecord, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbbImport, Me.cbbExport, Me.CommandBarSeparator3, Me.cbddOptions})
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
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisplayName = "Separator 1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
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
        'cbbDelete
        '
        Me.cbbDelete.AutoSize = False
        Me.cbbDelete.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbDelete.DisplayName = "Delete Record"
        Me.cbbDelete.DrawText = True
        Me.cbbDelete.Image = CType(resources.GetObject("cbbDelete.Image"), System.Drawing.Image)
        Me.cbbDelete.Name = "cbbDelete"
        Me.cbbDelete.Text = "Delete Record"
        Me.cbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cbbImport
        '
        Me.cbbImport.DisplayName = "Import Data"
        Me.cbbImport.DrawText = True
        Me.cbbImport.Image = CType(resources.GetObject("cbbImport.Image"), System.Drawing.Image)
        Me.cbbImport.Name = "cbbImport"
        Me.cbbImport.Text = "Import Data"
        Me.cbbImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbExport
        '
        Me.cbbExport.AutoSize = False
        Me.cbbExport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbExport.DisplayName = "Export Data"
        Me.cbbExport.DrawText = True
        Me.cbbExport.Image = CType(resources.GetObject("cbbExport.Image"), System.Drawing.Image)
        Me.cbbExport.Name = "cbbExport"
        Me.cbbExport.Text = "Export Data"
        Me.cbbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.cbddOptions.DisplayName = "Options"
        Me.cbddOptions.DrawText = True
        Me.cbddOptions.Image = CType(resources.GetObject("cbddOptions.Image"), System.Drawing.Image)
        Me.cbddOptions.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miEnableFiltering, Me.miEnableGrouping})
        Me.cbddOptions.Name = "cbddOptions"
        Me.cbddOptions.Text = "Options"
        Me.cbddOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gvData.Location = New System.Drawing.Point(0, 179)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gvData.Name = "gvData"
        Me.gvData.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvData.Size = New System.Drawing.Size(908, 401)
        Me.gvData.TabIndex = 3
        '
        'bwLoadData
        '
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'frmItemCodeHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 606)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Name = "frmItemCodeHistory"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Code History"
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtNewItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSpecialDemand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnnex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAddRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbCustomer As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtAnnex As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents sePrice As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents dtpEffectivityDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents chkSpecialDemand As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents txtNewItemCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbImport As Telerik.WinControls.UI.CommandBarButton
End Class

