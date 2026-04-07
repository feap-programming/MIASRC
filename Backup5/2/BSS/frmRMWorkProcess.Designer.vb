<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRMWorkProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRMWorkProcess))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.btnLotNo = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbSample = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbDuplicate = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.gvRm = New Telerik.WinControls.UI.RadGridView()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.txtPCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtItemCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbTitle = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTrayNo = New Telerik.WinControls.UI.RadTextBox()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.rtpTime = New Telerik.WinControls.UI.RadTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.txtMainID = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPOSPID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRm.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.txtPCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrayNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtpTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leCountRec
        '
        Me.leCountRec.Name = "leCountRec"
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, False)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        Me.leCountRec.UseCompatibleTextRendering = False
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Number of Record(s):"
        Me.RadLabelElement1.TextWrap = True
        Me.RadLabelElement1.UseCompatibleTextRendering = False
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.DisplayName = "Control Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.cbbAdd, Me.cbbEdit, Me.cbbDelete, Me.cbbExport, Me.cbbOptions, Me.btnLotNo, Me.cbSample, Me.cbDuplicate})
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
        Me.miEnableFiltering.Name = "miEnableFiltering"
        Me.miEnableFiltering.Text = "Enable Filtering"
        '
        'miEnableGrouping
        '
        Me.miEnableGrouping.Name = "miEnableGrouping"
        Me.miEnableGrouping.Text = "Enable Grouping"
        '
        'btnLotNo
        '
        Me.btnLotNo.DisplayName = "CommandBarButton1"
        Me.btnLotNo.DrawText = True
        Me.btnLotNo.Image = CType(resources.GetObject("btnLotNo.Image"), System.Drawing.Image)
        Me.btnLotNo.Name = "btnLotNo"
        Me.btnLotNo.Text = "Lot No."
        Me.btnLotNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbSample
        '
        Me.cbSample.DisplayName = "CommandBarButton1"
        Me.cbSample.DrawText = True
        Me.cbSample.Image = CType(resources.GetObject("cbSample.Image"), System.Drawing.Image)
        Me.cbSample.Name = "cbSample"
        Me.cbSample.Text = " Sample"
        Me.cbSample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbDuplicate
        '
        Me.cbDuplicate.DisplayName = "Duplicate"
        Me.cbDuplicate.DrawText = True
        Me.cbDuplicate.Image = CType(resources.GetObject("cbDuplicate.Image"), System.Drawing.Image)
        Me.cbDuplicate.Name = "cbDuplicate"
        Me.cbDuplicate.Text = "Duplicate lot no."
        Me.cbDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Left
        Me.gvData.Location = New System.Drawing.Point(0, 175)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(421, 327)
        Me.gvData.TabIndex = 16
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 502)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(979, 26)
        Me.RadStatusStrip1.TabIndex = 15
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 119)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(979, 56)
        Me.RadCommandBar1.TabIndex = 14
        '
        'gvRm
        '
        Me.gvRm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvRm.Location = New System.Drawing.Point(421, 175)
        '
        '
        '
        Me.gvRm.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvRm.Name = "gvRm"
        Me.gvRm.Size = New System.Drawing.Size(558, 327)
        Me.gvRm.TabIndex = 17
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.txtPCode)
        Me.z.Controls.Add(Me.RadLabel5)
        Me.z.Controls.Add(Me.RadLabel2)
        Me.z.Controls.Add(Me.txtItemCode)
        Me.z.Controls.Add(Me.RadLabel1)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Controls.Add(Me.mcbTitle)
        Me.z.Controls.Add(Me.RadLabel4)
        Me.z.Controls.Add(Me.txtTrayNo)
        Me.z.Controls.Add(Me.mcbProcess)
        Me.z.Controls.Add(Me.rtpTime)
        Me.z.Controls.Add(Me.RadLabel3)
        Me.z.Controls.Add(Me.RadLabel19)
        Me.z.Controls.Add(Me.txtMainID)
        Me.z.Controls.Add(Me.txtPOSPID)
        Me.z.Dock = System.Windows.Forms.DockStyle.Top
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(979, 119)
        Me.z.TabIndex = 18
        Me.z.ThemeName = "Office2007Black"
        '
        'txtPCode
        '
        Me.txtPCode.Enabled = False
        Me.txtPCode.Location = New System.Drawing.Point(737, 86)
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(38, 20)
        Me.txtPCode.TabIndex = 133
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(657, 85)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(74, 18)
        Me.RadLabel5.TabIndex = 132
        Me.RadLabel5.Text = "Process code:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(270, 32)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel2.TabIndex = 131
        Me.RadLabel2.Text = "Item Code:"
        '
        'txtItemCode
        '
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Location = New System.Drawing.Point(344, 32)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(157, 20)
        Me.txtItemCode.TabIndex = 130
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel1.Location = New System.Drawing.Point(12, 61)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel1.TabIndex = 129
        Me.RadLabel1.Text = "Box No:"
        '
        'RadLabel18
        '
        Me.RadLabel18.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel18.Location = New System.Drawing.Point(11, 41)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(48, 18)
        Me.RadLabel18.TabIndex = 128
        Me.RadLabel18.Text = "Tray No:"
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
        Me.mcbTitle.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbTitle.EditorControl.Name = "NestedRadGridView"
        Me.mcbTitle.EditorControl.ReadOnly = True
        Me.mcbTitle.EditorControl.ShowGroupPanel = False
        Me.mcbTitle.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbTitle.EditorControl.TabIndex = 0
        Me.mcbTitle.Enabled = False
        Me.mcbTitle.Location = New System.Drawing.Point(344, 58)
        Me.mcbTitle.Name = "mcbTitle"
        Me.mcbTitle.NullText = "-- Select Title --"
        Me.mcbTitle.Size = New System.Drawing.Size(431, 20)
        Me.mcbTitle.TabIndex = 123
        Me.mcbTitle.TabStop = False
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(270, 86)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel4.TabIndex = 124
        Me.RadLabel4.Text = "Main Process:"
        '
        'txtTrayNo
        '
        Me.txtTrayNo.AcceptsReturn = True
        Me.txtTrayNo.Location = New System.Drawing.Point(80, 39)
        Me.txtTrayNo.Multiline = True
        Me.txtTrayNo.Name = "txtTrayNo"
        '
        '
        '
        Me.txtTrayNo.RootElement.StretchVertically = True
        Me.txtTrayNo.Size = New System.Drawing.Size(159, 64)
        Me.txtTrayNo.TabIndex = 127
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
        Me.mcbProcess.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbProcess.EditorControl.Name = "NestedRadGridView"
        Me.mcbProcess.EditorControl.ReadOnly = True
        Me.mcbProcess.EditorControl.ShowGroupPanel = False
        Me.mcbProcess.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbProcess.EditorControl.TabIndex = 0
        Me.mcbProcess.Enabled = False
        Me.mcbProcess.Location = New System.Drawing.Point(344, 84)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.NullText = "-- Select Main Process --"
        Me.mcbProcess.Size = New System.Drawing.Size(309, 20)
        Me.mcbProcess.TabIndex = 121
        Me.mcbProcess.TabStop = False
        '
        'rtpTime
        '
        Me.rtpTime.Location = New System.Drawing.Point(80, 13)
        Me.rtpTime.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.rtpTime.MinValue = New Date(CType(0, Long))
        Me.rtpTime.Name = "rtpTime"
        Me.rtpTime.Size = New System.Drawing.Size(159, 20)
        Me.rtpTime.TabIndex = 125
        Me.rtpTime.TabStop = False
        Me.rtpTime.Value = New Date(2021, 3, 16, 7, 0, 0, 0)
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(299, 59)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel3.TabIndex = 122
        Me.RadLabel3.Text = "Title:"
        '
        'RadLabel19
        '
        Me.RadLabel19.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel19.Location = New System.Drawing.Point(26, 13)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(33, 18)
        Me.RadLabel19.TabIndex = 126
        Me.RadLabel19.Text = "Time:"
        '
        'txtMainID
        '
        Me.txtMainID.Location = New System.Drawing.Point(898, 13)
        Me.txtMainID.Name = "txtMainID"
        Me.txtMainID.Size = New System.Drawing.Size(28, 20)
        Me.txtMainID.TabIndex = 86
        Me.txtMainID.Visible = False
        '
        'txtPOSPID
        '
        Me.txtPOSPID.Location = New System.Drawing.Point(932, 13)
        Me.txtPOSPID.Name = "txtPOSPID"
        Me.txtPOSPID.Size = New System.Drawing.Size(28, 20)
        Me.txtPOSPID.TabIndex = 85
        Me.txtPOSPID.Visible = False
        '
        'FrmRMWorkProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 528)
        Me.Controls.Add(Me.gvRm)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.z)
        Me.Name = "FrmRMWorkProcess"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RM Work Process"
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRm.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.txtPCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrayNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtpTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents gvRm As Telerik.WinControls.UI.RadGridView
    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents mcbTitle As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtMainID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPOSPID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTrayNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rtpTime As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnLotNo As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtItemCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cbSample As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cbDuplicate As Telerik.WinControls.UI.CommandBarButton
End Class

