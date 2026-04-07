<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemMasterData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemMasterData))
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.ddCategory = New Telerik.WinControls.UI.RadDropDownList()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.chkOutSide = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkInhouse = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRegistrationNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPartname = New Telerik.WinControls.UI.RadTextBox()
        Me.txtItemCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbMaker = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.ddUOM = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.chkSellable = New Telerik.WinControls.UI.RadCheckBox()
        Me.ddSubCategory = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAddRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEditRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbddImport = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miItemCode = New Telerik.WinControls.UI.RadMenuItem()
        Me.miItemSpecs = New Telerik.WinControls.UI.RadMenuItem()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.chkOutSide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInhouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRegistrationNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbMaker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbMaker.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbMaker.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSellable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSubCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 638)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(1100, 29)
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
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 21)
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
        Me.gvData.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gvData.Location = New System.Drawing.Point(0, 212)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(1100, 426)
        Me.gvData.TabIndex = 2
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Location = New System.Drawing.Point(81, 14)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel5.TabIndex = 0
        Me.RadLabel5.Text = "Item Code:"
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Location = New System.Drawing.Point(429, 67)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(113, 18)
        Me.RadLabel4.TabIndex = 0
        Me.RadLabel4.Text = "Registration Number:"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(86, 40)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel2.TabIndex = 0
        Me.RadLabel2.Text = "Partname:"
        '
        'ddCategory
        '
        Me.ddCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddCategory.Location = New System.Drawing.Point(148, 90)
        Me.ddCategory.Name = "ddCategory"
        Me.ddCategory.Size = New System.Drawing.Size(125, 20)
        Me.ddCategory.TabIndex = 4
        '
        'bwLoadData
        '
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'RadPanel1
        '
        Me.RadPanel1.AutoScroll = True
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.chkOutSide)
        Me.RadPanel1.Controls.Add(Me.chkInhouse)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.txtDescription)
        Me.RadPanel1.Controls.Add(Me.txtRegistrationNo)
        Me.RadPanel1.Controls.Add(Me.txtPartname)
        Me.RadPanel1.Controls.Add(Me.txtItemCode)
        Me.RadPanel1.Controls.Add(Me.RadLabel8)
        Me.RadPanel1.Controls.Add(Me.mcbMaker)
        Me.RadPanel1.Controls.Add(Me.RadLabel7)
        Me.RadPanel1.Controls.Add(Me.ddUOM)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.chkSellable)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.ddSubCategory)
        Me.RadPanel1.Controls.Add(Me.ddCategory)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1100, 131)
        Me.RadPanel1.TabIndex = 4
        Me.RadPanel1.ThemeName = "MaterialTeal"
        '
        'chkOutSide
        '
        Me.chkOutSide.Location = New System.Drawing.Point(805, 65)
        Me.chkOutSide.Name = "chkOutSide"
        Me.chkOutSide.Size = New System.Drawing.Size(62, 18)
        Me.chkOutSide.TabIndex = 11
        Me.chkOutSide.Text = "Out side"
        '
        'chkInhouse
        '
        Me.chkInhouse.Location = New System.Drawing.Point(805, 39)
        Me.chkInhouse.Name = "chkInhouse"
        Me.chkInhouse.Size = New System.Drawing.Size(65, 18)
        Me.chkInhouse.TabIndex = 10
        Me.chkInhouse.Text = "In House"
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(76, 66)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(66, 18)
        Me.RadLabel3.TabIndex = 0
        Me.RadLabel3.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(148, 64)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(256, 20)
        Me.txtDescription.TabIndex = 3
        '
        'txtRegistrationNo
        '
        Me.txtRegistrationNo.Location = New System.Drawing.Point(548, 65)
        Me.txtRegistrationNo.Name = "txtRegistrationNo"
        Me.txtRegistrationNo.Size = New System.Drawing.Size(125, 20)
        Me.txtRegistrationNo.TabIndex = 7
        '
        'txtPartname
        '
        Me.txtPartname.Location = New System.Drawing.Point(148, 38)
        Me.txtPartname.Name = "txtPartname"
        Me.txtPartname.Size = New System.Drawing.Size(256, 20)
        Me.txtPartname.TabIndex = 2
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(148, 13)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(256, 20)
        Me.txtItemCode.TabIndex = 1
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Location = New System.Drawing.Point(502, 93)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(40, 18)
        Me.RadLabel8.TabIndex = 0
        Me.RadLabel8.Text = "Maker:"
        '
        'mcbMaker
        '
        '
        'mcbMaker.NestedRadGridView
        '
        Me.mcbMaker.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbMaker.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbMaker.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbMaker.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbMaker.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbMaker.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbMaker.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbMaker.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbMaker.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbMaker.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbMaker.EditorControl.Name = "NestedRadGridView"
        Me.mcbMaker.EditorControl.ReadOnly = True
        Me.mcbMaker.EditorControl.ShowGroupPanel = False
        Me.mcbMaker.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbMaker.EditorControl.TabIndex = 0
        Me.mcbMaker.Location = New System.Drawing.Point(548, 91)
        Me.mcbMaker.Name = "mcbMaker"
        Me.mcbMaker.Size = New System.Drawing.Size(209, 20)
        Me.mcbMaker.TabIndex = 8
        Me.mcbMaker.TabStop = False
        '
        'RadLabel7
        '
        Me.RadLabel7.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel7.Location = New System.Drawing.Point(507, 40)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(35, 18)
        Me.RadLabel7.TabIndex = 0
        Me.RadLabel7.Text = "UOM:"
        '
        'ddUOM
        '
        Me.ddUOM.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddUOM.Location = New System.Drawing.Point(548, 38)
        Me.ddUOM.Name = "ddUOM"
        Me.ddUOM.Size = New System.Drawing.Size(125, 20)
        Me.ddUOM.TabIndex = 6
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(466, 14)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(76, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Sub Category:"
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Location = New System.Drawing.Point(88, 92)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(54, 18)
        Me.RadLabel6.TabIndex = 0
        Me.RadLabel6.Text = "Category:"
        '
        'chkSellable
        '
        Me.chkSellable.Location = New System.Drawing.Point(805, 14)
        Me.chkSellable.Name = "chkSellable"
        Me.chkSellable.Size = New System.Drawing.Size(59, 18)
        Me.chkSellable.TabIndex = 9
        Me.chkSellable.Text = "Sellable"
        '
        'ddSubCategory
        '
        Me.ddSubCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddSubCategory.Location = New System.Drawing.Point(548, 13)
        Me.ddSubCategory.Name = "ddSubCategory"
        Me.ddSubCategory.Size = New System.Drawing.Size(125, 20)
        Me.ddSubCategory.TabIndex = 5
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 131)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1100, 81)
        Me.RadCommandBar1.TabIndex = 5
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAddRecord, Me.cbbEditRecord, Me.cbbDeleteRecord, Me.CommandBarSeparator2, Me.cbddImport, Me.cbbExport, Me.CommandBarSeparator3, Me.cbddOptions})
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
        'cbbEditRecord
        '
        Me.cbbEditRecord.AutoSize = False
        Me.cbbEditRecord.Bounds = New System.Drawing.Rectangle(0, 0, 67, 52)
        Me.cbbEditRecord.DisplayName = "Edit Record"
        Me.cbbEditRecord.DrawText = True
        Me.cbbEditRecord.Image = CType(resources.GetObject("cbbEditRecord.Image"), System.Drawing.Image)
        Me.cbbEditRecord.Name = "cbbEditRecord"
        Me.cbbEditRecord.Text = "Edit Record"
        Me.cbbEditRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cbddImport
        '
        Me.cbddImport.DisplayName = "Import"
        Me.cbddImport.DrawText = True
        Me.cbddImport.Image = CType(resources.GetObject("cbddImport.Image"), System.Drawing.Image)
        Me.cbddImport.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miItemCode, Me.miItemSpecs})
        Me.cbddImport.Name = "cbddImport"
        Me.cbddImport.Text = "Import Data"
        Me.cbddImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miItemCode
        '
        Me.miItemCode.Name = "miItemCode"
        Me.miItemCode.Text = "Item Code"
        '
        'miItemSpecs
        '
        Me.miItemSpecs.Name = "miItemSpecs"
        Me.miItemSpecs.Text = "Item Specs"
        '
        'cbbExport
        '
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
        'FrmItemMasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 667)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Name = "FrmItemMasterData"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Master Data"
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.chkOutSide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInhouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRegistrationNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbMaker.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbMaker.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbMaker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSellable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSubCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ddCategory As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAddRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDeleteRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents chkSellable As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddUOM As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbMaker As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents cbbEditRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents txtPartname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtItemCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtRegistrationNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDescription As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents chkOutSide As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkInhouse As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddSubCategory As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cbddImport As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents miItemCode As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miItemSpecs As Telerik.WinControls.UI.RadMenuItem
End Class

