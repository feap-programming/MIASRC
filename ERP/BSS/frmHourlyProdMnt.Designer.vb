<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHourlyProdMnt
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
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHourlyProdMnt))
        Me.txtMainID = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPOSPID = New Telerik.WinControls.UI.RadTextBox()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.bwDelete = New System.ComponentModel.BackgroundWorker()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.mcbTitle = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCheckby = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.seDeviation = New Telerik.WinControls.UI.RadSpinEditor()
        Me.Actual = New Telerik.WinControls.UI.RadLabel()
        Me.seActual = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.sePlan = New Telerik.WinControls.UI.RadSpinEditor()
        Me.rtpFrom = New Telerik.WinControls.UI.RadTimePicker()
        Me.rtpTo = New Telerik.WinControls.UI.RadTimePicker()
        Me.mcbShift = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDeviation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Actual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMainID
        '
        Me.txtMainID.Location = New System.Drawing.Point(913, 54)
        Me.txtMainID.Name = "txtMainID"
        Me.txtMainID.Size = New System.Drawing.Size(28, 20)
        Me.txtMainID.TabIndex = 86
        Me.txtMainID.Visible = False
        '
        'txtPOSPID
        '
        Me.txtPOSPID.Location = New System.Drawing.Point(913, 80)
        Me.txtPOSPID.Name = "txtPOSPID"
        Me.txtPOSPID.Size = New System.Drawing.Size(28, 20)
        Me.txtPOSPID.TabIndex = 85
        Me.txtPOSPID.Visible = False
        '
        'leCountRec
        '
        Me.leCountRec.Name = "leCountRec"
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, True)
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
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(947, 26)
        Me.RadStatusStrip1.TabIndex = 17
        '
        'bwDelete
        '
        Me.bwDelete.WorkerReportsProgress = True
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 181)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(947, 358)
        Me.gvData.TabIndex = 19
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.DisplayName = "Control Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.cbbAdd, Me.cbbEdit, Me.cbbDelete, Me.cbbExport, Me.cbbOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
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
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 125)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(947, 56)
        Me.RadCommandBar1.TabIndex = 18
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.mcbTitle)
        Me.z.Controls.Add(Me.RadLabel3)
        Me.z.Controls.Add(Me.RadLabel2)
        Me.z.Controls.Add(Me.txtRemarks)
        Me.z.Controls.Add(Me.mcbProcess)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Controls.Add(Me.RadLabel4)
        Me.z.Controls.Add(Me.txtCheckby)
        Me.z.Controls.Add(Me.RadLabel1)
        Me.z.Controls.Add(Me.seDeviation)
        Me.z.Controls.Add(Me.Actual)
        Me.z.Controls.Add(Me.seActual)
        Me.z.Controls.Add(Me.RadLabel11)
        Me.z.Controls.Add(Me.sePlan)
        Me.z.Controls.Add(Me.rtpFrom)
        Me.z.Controls.Add(Me.rtpTo)
        Me.z.Controls.Add(Me.mcbShift)
        Me.z.Controls.Add(Me.RadLabel16)
        Me.z.Controls.Add(Me.RadLabel17)
        Me.z.Controls.Add(Me.RadLabel19)
        Me.z.Controls.Add(Me.txtMainID)
        Me.z.Controls.Add(Me.txtPOSPID)
        Me.z.Dock = System.Windows.Forms.DockStyle.Top
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(947, 125)
        Me.z.TabIndex = 1
        Me.z.ThemeName = "Office2007Black"
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
        Me.mcbTitle.Location = New System.Drawing.Point(484, 63)
        Me.mcbTitle.Name = "mcbTitle"
        Me.mcbTitle.NullText = "-- Select Title --"
        Me.mcbTitle.Size = New System.Drawing.Size(398, 20)
        Me.mcbTitle.TabIndex = 123
        Me.mcbTitle.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(439, 64)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel3.TabIndex = 122
        Me.RadLabel3.Text = "Title:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(418, 39)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel2.TabIndex = 120
        Me.RadLabel2.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(484, 37)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(254, 20)
        Me.txtRemarks.TabIndex = 9
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
        Me.mcbProcess.Location = New System.Drawing.Point(484, 89)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.NullText = "-- Select Main Process --"
        Me.mcbProcess.Size = New System.Drawing.Size(254, 20)
        Me.mcbProcess.TabIndex = 121
        Me.mcbProcess.TabStop = False
        '
        'RadLabel18
        '
        Me.RadLabel18.Location = New System.Drawing.Point(415, 13)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(54, 18)
        Me.RadLabel18.TabIndex = 118
        Me.RadLabel18.Text = "Check by:"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(396, 91)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel4.TabIndex = 124
        Me.RadLabel4.Text = "Main Process:"
        '
        'txtCheckby
        '
        Me.txtCheckby.Location = New System.Drawing.Point(484, 11)
        Me.txtCheckby.Name = "txtCheckby"
        Me.txtCheckby.Size = New System.Drawing.Size(254, 20)
        Me.txtCheckby.TabIndex = 8
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(221, 64)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel1.TabIndex = 116
        Me.RadLabel1.Text = "Deviation:"
        '
        'seDeviation
        '
        Me.seDeviation.Enabled = False
        Me.seDeviation.EnableNullValueInput = True
        Me.seDeviation.Location = New System.Drawing.Point(289, 61)
        Me.seDeviation.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seDeviation.Minimum = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
        Me.seDeviation.Name = "seDeviation"
        Me.seDeviation.ShowUpDownButtons = False
        Me.seDeviation.Size = New System.Drawing.Size(88, 20)
        Me.seDeviation.TabIndex = 7
        Me.seDeviation.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seDeviation.ThousandsSeparator = True
        '
        'Actual
        '
        Me.Actual.Location = New System.Drawing.Point(237, 37)
        Me.Actual.Name = "Actual"
        Me.Actual.Size = New System.Drawing.Size(40, 18)
        Me.Actual.TabIndex = 114
        Me.Actual.Text = "Actual:"
        '
        'seActual
        '
        Me.seActual.EnableNullValueInput = True
        Me.seActual.Location = New System.Drawing.Point(289, 35)
        Me.seActual.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seActual.Name = "seActual"
        Me.seActual.ShowUpDownButtons = False
        Me.seActual.Size = New System.Drawing.Size(88, 20)
        Me.seActual.TabIndex = 6
        Me.seActual.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seActual.ThousandsSeparator = True
        '
        'RadLabel11
        '
        Me.RadLabel11.Location = New System.Drawing.Point(247, 11)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel11.TabIndex = 112
        Me.RadLabel11.Text = "Plan:"
        '
        'sePlan
        '
        Me.sePlan.EnableNullValueInput = True
        Me.sePlan.Location = New System.Drawing.Point(289, 10)
        Me.sePlan.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.sePlan.Name = "sePlan"
        Me.sePlan.ShowUpDownButtons = False
        Me.sePlan.Size = New System.Drawing.Size(88, 20)
        Me.sePlan.TabIndex = 5
        Me.sePlan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.sePlan.ThousandsSeparator = True
        '
        'rtpFrom
        '
        Me.rtpFrom.Location = New System.Drawing.Point(86, 37)
        Me.rtpFrom.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.rtpFrom.MinValue = New Date(CType(0, Long))
        Me.rtpFrom.Name = "rtpFrom"
        Me.rtpFrom.Size = New System.Drawing.Size(94, 20)
        Me.rtpFrom.TabIndex = 3
        Me.rtpFrom.TabStop = False
        Me.rtpFrom.Value = New Date(2021, 3, 16, 6, 0, 0, 0)
        '
        'rtpTo
        '
        Me.rtpTo.Location = New System.Drawing.Point(86, 62)
        Me.rtpTo.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.rtpTo.MinValue = New Date(CType(0, Long))
        Me.rtpTo.Name = "rtpTo"
        Me.rtpTo.Size = New System.Drawing.Size(94, 20)
        Me.rtpTo.TabIndex = 4
        Me.rtpTo.TabStop = False
        Me.rtpTo.Value = New Date(2021, 3, 16, 7, 0, 0, 0)
        '
        'mcbShift
        '
        '
        'mcbShift.NestedRadGridView
        '
        Me.mcbShift.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbShift.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbShift.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbShift.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbShift.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbShift.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbShift.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbShift.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbShift.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbShift.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbShift.EditorControl.Name = "NestedRadGridView"
        Me.mcbShift.EditorControl.ReadOnly = True
        Me.mcbShift.EditorControl.ShowGroupPanel = False
        Me.mcbShift.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbShift.EditorControl.TabIndex = 0
        Me.mcbShift.Enabled = False
        Me.mcbShift.Location = New System.Drawing.Point(86, 12)
        Me.mcbShift.Name = "mcbShift"
        Me.mcbShift.NullText = "-- Select Shift --"
        Me.mcbShift.Size = New System.Drawing.Size(94, 20)
        Me.mcbShift.TabIndex = 2
        Me.mcbShift.TabStop = False
        '
        'RadLabel16
        '
        Me.RadLabel16.Location = New System.Drawing.Point(40, 12)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel16.TabIndex = 107
        Me.RadLabel16.Text = "Shift:"
        '
        'RadLabel17
        '
        Me.RadLabel17.Location = New System.Drawing.Point(28, 60)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(49, 18)
        Me.RadLabel17.TabIndex = 109
        Me.RadLabel17.Text = "Time To:"
        '
        'RadLabel19
        '
        Me.RadLabel19.Location = New System.Drawing.Point(18, 34)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(62, 18)
        Me.RadLabel19.TabIndex = 108
        Me.RadLabel19.Text = "Time From:"
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
        'FrmHourlyProdMnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 565)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.z)
        Me.Name = "FrmHourlyProdMnt"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Hourly Production Status Monitoring"
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDeviation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Actual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMainID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPOSPID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents bwDelete As System.ComponentModel.BackgroundWorker
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rtpFrom As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents rtpTo As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents mcbShift As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Actual As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seActual As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents sePlan As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seDeviation As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCheckby As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mcbTitle As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
End Class

