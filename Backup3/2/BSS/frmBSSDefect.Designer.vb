<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSDefect
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBSSDefect))
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwDelete = New System.ComponentModel.BackgroundWorker()
        Me.panelMore = New Telerik.WinControls.UI.RadPanel()
        Me.mcbTitle = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtMainID = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPOSPID = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlDefectCategory = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.seDefect = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbAssemblyProcessName = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.ddlProgDefect = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAddProcess = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelMore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMore.SuspendLayout()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDefectCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProgDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProgDefect.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProgDefect.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 106)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(944, 81)
        Me.RadCommandBar1.TabIndex = 14
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.cbbAdd, Me.cbbEdit, Me.cbbDelete, Me.cbbAddProcess, Me.cbbExport, Me.cbbOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 187)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(944, 355)
        Me.gvData.TabIndex = 15
        '
        'bwDelete
        '
        Me.bwDelete.WorkerReportsProgress = True
        '
        'panelMore
        '
        Me.panelMore.AutoScroll = True
        Me.panelMore.BackColor = System.Drawing.Color.LightGray
        Me.panelMore.Controls.Add(Me.mcbTitle)
        Me.panelMore.Controls.Add(Me.RadLabel2)
        Me.panelMore.Controls.Add(Me.mcbProcess)
        Me.panelMore.Controls.Add(Me.RadLabel3)
        Me.panelMore.Controls.Add(Me.txtMainID)
        Me.panelMore.Controls.Add(Me.txtPOSPID)
        Me.panelMore.Controls.Add(Me.ddlDefectCategory)
        Me.panelMore.Controls.Add(Me.RadLabel11)
        Me.panelMore.Controls.Add(Me.seDefect)
        Me.panelMore.Controls.Add(Me.RadLabel15)
        Me.panelMore.Controls.Add(Me.mcbAssemblyProcessName)
        Me.panelMore.Controls.Add(Me.ddlProgDefect)
        Me.panelMore.Controls.Add(Me.RadLabel1)
        Me.panelMore.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMore.Location = New System.Drawing.Point(0, 0)
        Me.panelMore.Name = "panelMore"
        Me.panelMore.Size = New System.Drawing.Size(944, 106)
        Me.panelMore.TabIndex = 12
        Me.panelMore.ThemeName = "Office2007Black"
        '
        'mcbTitle
        '
        '
        'mcbTitle.NestedRadGridView
        '
        Me.mcbTitle.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbTitle.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbTitle.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbTitle.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbTitle.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbTitle.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbTitle.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbTitle.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbTitle.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbTitle.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbTitle.EditorControl.Name = "NestedRadGridView"
        Me.mcbTitle.EditorControl.ReadOnly = True
        Me.mcbTitle.EditorControl.ShowGroupPanel = False
        Me.mcbTitle.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbTitle.EditorControl.TabIndex = 0
        Me.mcbTitle.Enabled = False
        Me.mcbTitle.Location = New System.Drawing.Point(504, 16)
        Me.mcbTitle.Name = "mcbTitle"
        Me.mcbTitle.NullText = "-- Select Title --"
        Me.mcbTitle.Size = New System.Drawing.Size(398, 20)
        Me.mcbTitle.TabIndex = 89
        Me.mcbTitle.TabStop = False
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(468, 16)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel2.TabIndex = 88
        Me.RadLabel2.Text = "Title:"
        '
        'mcbProcess
        '
        '
        'mcbProcess.NestedRadGridView
        '
        Me.mcbProcess.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbProcess.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbProcess.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbProcess.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbProcess.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbProcess.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbProcess.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbProcess.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbProcess.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbProcess.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbProcess.EditorControl.Name = "NestedRadGridView"
        Me.mcbProcess.EditorControl.ReadOnly = True
        Me.mcbProcess.EditorControl.ShowGroupPanel = False
        Me.mcbProcess.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbProcess.EditorControl.TabIndex = 0
        Me.mcbProcess.Enabled = False
        Me.mcbProcess.Location = New System.Drawing.Point(504, 42)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.NullText = "-- Select Main Process --"
        Me.mcbProcess.Size = New System.Drawing.Size(246, 20)
        Me.mcbProcess.TabIndex = 87
        Me.mcbProcess.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(425, 43)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel3.TabIndex = 90
        Me.RadLabel3.Text = "Main Process:"
        '
        'txtMainID
        '
        Me.txtMainID.Location = New System.Drawing.Point(891, 54)
        Me.txtMainID.Name = "txtMainID"
        Me.txtMainID.Size = New System.Drawing.Size(50, 20)
        Me.txtMainID.TabIndex = 86
        Me.txtMainID.Visible = False
        '
        'txtPOSPID
        '
        Me.txtPOSPID.Location = New System.Drawing.Point(891, 80)
        Me.txtPOSPID.Name = "txtPOSPID"
        Me.txtPOSPID.Size = New System.Drawing.Size(50, 20)
        Me.txtPOSPID.TabIndex = 85
        Me.txtPOSPID.Visible = False
        '
        'ddlDefectCategory
        '
        Me.ddlDefectCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "MAN"
        RadListDataItem2.Text = "MACHINE"
        RadListDataItem3.Text = "MATERIAL"
        RadListDataItem4.Text = "OTHER"
        Me.ddlDefectCategory.Items.Add(RadListDataItem1)
        Me.ddlDefectCategory.Items.Add(RadListDataItem2)
        Me.ddlDefectCategory.Items.Add(RadListDataItem3)
        Me.ddlDefectCategory.Items.Add(RadListDataItem4)
        Me.ddlDefectCategory.Location = New System.Drawing.Point(269, 68)
        Me.ddlDefectCategory.Name = "ddlDefectCategory"
        Me.ddlDefectCategory.NullText = "---Defect Category---"
        Me.ddlDefectCategory.Size = New System.Drawing.Size(150, 20)
        Me.ddlDefectCategory.TabIndex = 15
        '
        'RadLabel11
        '
        Me.RadLabel11.Location = New System.Drawing.Point(120, 69)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(41, 18)
        Me.RadLabel11.TabIndex = 83
        Me.RadLabel11.Text = "Defect:"
        '
        'seDefect
        '
        Me.seDefect.DecimalPlaces = 2
        Me.seDefect.EnableNullValueInput = True
        Me.seDefect.Location = New System.Drawing.Point(165, 68)
        Me.seDefect.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seDefect.Name = "seDefect"
        Me.seDefect.ShowUpDownButtons = False
        Me.seDefect.Size = New System.Drawing.Size(88, 20)
        Me.seDefect.TabIndex = 14
        Me.seDefect.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seDefect.ThousandsSeparator = True
        '
        'RadLabel15
        '
        Me.RadLabel15.Location = New System.Drawing.Point(29, 18)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(130, 18)
        Me.RadLabel15.TabIndex = 64
        Me.RadLabel15.Text = "Assembly Process Name:"
        '
        'mcbAssemblyProcessName
        '
        '
        'mcbAssemblyProcessName.NestedRadGridView
        '
        Me.mcbAssemblyProcessName.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbAssemblyProcessName.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbAssemblyProcessName.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbAssemblyProcessName.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbAssemblyProcessName.EditorControl.Name = "NestedRadGridView"
        Me.mcbAssemblyProcessName.EditorControl.ReadOnly = True
        Me.mcbAssemblyProcessName.EditorControl.ShowGroupPanel = False
        Me.mcbAssemblyProcessName.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbAssemblyProcessName.EditorControl.TabIndex = 0
        Me.mcbAssemblyProcessName.Location = New System.Drawing.Point(165, 16)
        Me.mcbAssemblyProcessName.Name = "mcbAssemblyProcessName"
        Me.mcbAssemblyProcessName.NullText = "-- Select Assembly Process Name --"
        Me.mcbAssemblyProcessName.Size = New System.Drawing.Size(254, 20)
        Me.mcbAssemblyProcessName.TabIndex = 12
        Me.mcbAssemblyProcessName.TabStop = False
        '
        'ddlProgDefect
        '
        '
        'ddlProgDefect.NestedRadGridView
        '
        Me.ddlProgDefect.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlProgDefect.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlProgDefect.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlProgDefect.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlProgDefect.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.ddlProgDefect.EditorControl.Name = "NestedRadGridView"
        Me.ddlProgDefect.EditorControl.ReadOnly = True
        Me.ddlProgDefect.EditorControl.ShowGroupPanel = False
        Me.ddlProgDefect.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlProgDefect.EditorControl.TabIndex = 0
        Me.ddlProgDefect.Location = New System.Drawing.Point(165, 42)
        Me.ddlProgDefect.Name = "ddlProgDefect"
        Me.ddlProgDefect.NullText = "-- Progress Defects --"
        Me.ddlProgDefect.Size = New System.Drawing.Size(254, 20)
        Me.ddlProgDefect.TabIndex = 13
        Me.ddlProgDefect.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(67, 42)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(92, 18)
        Me.RadLabel1.TabIndex = 57
        Me.RadLabel1.Text = "Progress Defects:"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 542)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(944, 26)
        Me.RadStatusStrip1.TabIndex = 13
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Number of Record(s):"
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
        'cbbAddProcess
        '
        Me.cbbAddProcess.AutoSize = False
        Me.cbbAddProcess.Bounds = New System.Drawing.Rectangle(0, 0, 67, 52)
        Me.cbbAddProcess.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAddProcess.DisplayName = "Add Process"
        Me.cbbAddProcess.DrawText = True
        Me.cbbAddProcess.Image = CType(resources.GetObject("cbbAddProcess.Image"), System.Drawing.Image)
        Me.cbbAddProcess.Name = "cbbAddProcess"
        Me.cbbAddProcess.Text = "Process"
        Me.cbbAddProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbAddProcess.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAddProcess.UseCompatibleTextRendering = False
        '
        'cbbExport
        '
        Me.cbbExport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbExport.DisplayName = "Export Data"
        Me.cbbExport.DrawText = True
        Me.cbbExport.Image = CType(resources.GetObject("cbbExport.Image"), System.Drawing.Image)
        Me.cbbExport.Name = "cbbExport"
        Me.cbbExport.Text = "Export Data"
        Me.cbbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbExport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbExport.UseCompatibleTextRendering = False
        '
        'cbbOptions
        '
        Me.cbbOptions.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbOptions.DisplayName = "Options"
        Me.cbbOptions.DrawText = True
        Me.cbbOptions.Image = CType(resources.GetObject("cbbOptions.Image"), System.Drawing.Image)
        Me.cbbOptions.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miEnableFiltering, Me.miEnableGrouping})
        Me.cbbOptions.Name = "cbbOptions"
        Me.cbbOptions.Text = "Options"
        Me.cbbOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbOptions.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbOptions.UseCompatibleTextRendering = False
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
        'FrmBSSDefect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 568)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.panelMore)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Name = "FrmBSSDefect"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BSS DEFECT"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelMore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMore.ResumeLayout(False)
        Me.panelMore.PerformLayout()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDefectCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProgDefect.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProgDefect.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProgDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAddProcess As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwDelete As System.ComponentModel.BackgroundWorker
    Friend WithEvents panelMore As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents ddlProgDefect As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbAssemblyProcessName As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seDefect As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents ddlDefectCategory As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtPOSPID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtMainID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mcbTitle As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
End Class

