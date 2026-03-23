<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModelGroupAssignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModelGroupAssignment))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpEffectivityDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.seActualGroup = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbCustomer = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbModel = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbLine = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwDelete = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seActualGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbModel.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbLine.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbLine.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 102)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(910, 56)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbbExport, Me.CommandBarSeparator3, Me.cbbOptions})
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
        'cbbAdd
        '
        Me.cbbAdd.AutoSize = False
        Me.cbbAdd.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbAdd.DisplayName = "Add Record"
        Me.cbbAdd.DrawText = True
        Me.cbbAdd.Image = CType(resources.GetObject("cbbAdd.Image"), System.Drawing.Image)
        Me.cbbAdd.Name = "cbbAdd"
        Me.cbbAdd.Text = "Add Record"
        Me.cbbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 565)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(910, 26)
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
        Me.gvData.Location = New System.Drawing.Point(0, 158)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(910, 407)
        Me.gvData.TabIndex = 3
        '
        'RadPanel1
        '
        Me.RadPanel1.AutoScroll = True
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.dtpEffectivityDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.seActualGroup)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.mcbCustomer)
        Me.RadPanel1.Controls.Add(Me.mcbModel)
        Me.RadPanel1.Controls.Add(Me.mcbLine)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(910, 102)
        Me.RadPanel1.TabIndex = 0
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Location = New System.Drawing.Point(462, 44)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(83, 18)
        Me.RadLabel5.TabIndex = 9
        Me.RadLabel5.Text = "Effectivity Date:"
        '
        'dtpEffectivityDate
        '
        Me.dtpEffectivityDate.Location = New System.Drawing.Point(551, 42)
        Me.dtpEffectivityDate.Name = "dtpEffectivityDate"
        Me.dtpEffectivityDate.Size = New System.Drawing.Size(174, 20)
        Me.dtpEffectivityDate.TabIndex = 8
        Me.dtpEffectivityDate.TabStop = False
        Me.dtpEffectivityDate.Text = "Friday, February 1, 2019"
        Me.dtpEffectivityDate.Value = New Date(2019, 2, 1, 8, 59, 11, 645)
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Location = New System.Drawing.Point(471, 18)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(74, 18)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "Actual Group:"
        '
        'seActualGroup
        '
        Me.seActualGroup.Location = New System.Drawing.Point(551, 16)
        Me.seActualGroup.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seActualGroup.Name = "seActualGroup"
        Me.seActualGroup.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.seActualGroup.ShowUpDownButtons = False
        Me.seActualGroup.Size = New System.Drawing.Size(59, 20)
        Me.seActualGroup.TabIndex = 6
        Me.seActualGroup.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(29, 70)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Customer:"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(45, 44)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(41, 18)
        Me.RadLabel2.TabIndex = 4
        Me.RadLabel2.Text = "Model:"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(24, 18)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(62, 18)
        Me.RadLabel1.TabIndex = 3
        Me.RadLabel1.Text = "Line Name:"
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
        Me.mcbCustomer.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbCustomer.EditorControl.Name = "NestedRadGridView"
        Me.mcbCustomer.EditorControl.ReadOnly = True
        Me.mcbCustomer.EditorControl.ShowGroupPanel = False
        Me.mcbCustomer.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbCustomer.EditorControl.TabIndex = 0
        Me.mcbCustomer.Location = New System.Drawing.Point(92, 68)
        Me.mcbCustomer.Name = "mcbCustomer"
        Me.mcbCustomer.Size = New System.Drawing.Size(328, 20)
        Me.mcbCustomer.TabIndex = 2
        Me.mcbCustomer.TabStop = False
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
        Me.mcbModel.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbModel.EditorControl.Name = "NestedRadGridView"
        Me.mcbModel.EditorControl.ReadOnly = True
        Me.mcbModel.EditorControl.ShowGroupPanel = False
        Me.mcbModel.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbModel.EditorControl.TabIndex = 0
        Me.mcbModel.Location = New System.Drawing.Point(92, 42)
        Me.mcbModel.Name = "mcbModel"
        Me.mcbModel.Size = New System.Drawing.Size(328, 20)
        Me.mcbModel.TabIndex = 1
        Me.mcbModel.TabStop = False
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
        Me.mcbLine.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbLine.EditorControl.Name = "NestedRadGridView"
        Me.mcbLine.EditorControl.ReadOnly = True
        Me.mcbLine.EditorControl.ShowGroupPanel = False
        Me.mcbLine.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbLine.EditorControl.TabIndex = 0
        Me.mcbLine.Location = New System.Drawing.Point(92, 16)
        Me.mcbLine.Name = "mcbLine"
        Me.mcbLine.Size = New System.Drawing.Size(328, 20)
        Me.mcbLine.TabIndex = 0
        Me.mcbLine.TabStop = False
        '
        'bwLoadData
        '
        '
        'bwDelete
        '
        Me.bwDelete.WorkerReportsProgress = True
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
        Me.CommandBarSeparator4.Text = ""
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'FrmModelGroupAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 591)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmModelGroupAssignment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actual Group Assignment"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seActualGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbModel.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbLine.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbLine.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents mcbCustomer As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbModel As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbLine As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seActualGroup As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpEffectivityDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents bwDelete As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
End Class

