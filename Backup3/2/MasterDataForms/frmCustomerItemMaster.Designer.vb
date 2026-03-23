<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomerItemMaster
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerItemMaster))
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtPartLevel = New Telerik.WinControls.UI.RadTextBox()
        Me.txtModelCode = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCustomerPartNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.seStdQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.mcbCustomer = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbImportData = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtPartLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seStdQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 586)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(916, 29)
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
        'RadPanel1
        '
        Me.RadPanel1.AutoScroll = True
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtPartLevel)
        Me.RadPanel1.Controls.Add(Me.txtModelCode)
        Me.RadPanel1.Controls.Add(Me.txtCustomerPartNo)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.mcbItemCode)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.seStdQty)
        Me.RadPanel1.Controls.Add(Me.mcbCustomer)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(916, 101)
        Me.RadPanel1.TabIndex = 1
        Me.RadPanel1.ThemeName = "MaterialTeal"
        '
        'txtPartLevel
        '
        Me.txtPartLevel.Location = New System.Drawing.Point(552, 64)
        Me.txtPartLevel.Name = "txtPartLevel"
        Me.txtPartLevel.Size = New System.Drawing.Size(126, 20)
        Me.txtPartLevel.TabIndex = 5
        '
        'txtModelCode
        '
        Me.txtModelCode.Location = New System.Drawing.Point(552, 13)
        Me.txtModelCode.Name = "txtModelCode"
        Me.txtModelCode.Size = New System.Drawing.Size(126, 20)
        Me.txtModelCode.TabIndex = 3
        '
        'txtCustomerPartNo
        '
        Me.txtCustomerPartNo.Location = New System.Drawing.Point(137, 12)
        Me.txtCustomerPartNo.Name = "txtCustomerPartNo"
        Me.txtCustomerPartNo.Size = New System.Drawing.Size(245, 20)
        Me.txtCustomerPartNo.TabIndex = 0
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Location = New System.Drawing.Point(70, 66)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel6.TabIndex = 17
        Me.RadLabel6.Text = "Item Code:"
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(137, 64)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(245, 20)
        Me.mcbItemCode.TabIndex = 2
        Me.mcbItemCode.TabStop = False
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Location = New System.Drawing.Point(489, 66)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel5.TabIndex = 15
        Me.RadLabel5.Text = "Part Level:"
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Location = New System.Drawing.Point(447, 40)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(100, 18)
        Me.RadLabel4.TabIndex = 14
        Me.RadLabel4.Text = "Standard Quantity:"
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(476, 14)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel3.TabIndex = 13
        Me.RadLabel3.Text = "Model Code:"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(74, 40)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "Customer:"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(30, 14)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(101, 18)
        Me.RadLabel1.TabIndex = 11
        Me.RadLabel1.Text = "Customer Part No.:"
        '
        'seStdQty
        '
        Me.seStdQty.Location = New System.Drawing.Point(553, 38)
        Me.seStdQty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seStdQty.Name = "seStdQty"
        Me.seStdQty.ShowUpDownButtons = False
        Me.seStdQty.Size = New System.Drawing.Size(125, 20)
        Me.seStdQty.TabIndex = 4
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
        Me.mcbCustomer.Location = New System.Drawing.Point(137, 38)
        Me.mcbCustomer.Name = "mcbCustomer"
        Me.mcbCustomer.Size = New System.Drawing.Size(245, 20)
        Me.mcbCustomer.TabIndex = 1
        Me.mcbCustomer.TabStop = False
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.gvData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gvData.Location = New System.Drawing.Point(0, 182)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gvData.Name = "gvData"
        Me.gvData.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvData.Size = New System.Drawing.Size(916, 404)
        Me.gvData.TabIndex = 2
        '
        'bwLoadData
        '
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 101)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(916, 81)
        Me.RadCommandBar1.TabIndex = 3
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbEdit, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbbImportData, Me.cbbExport, Me.CommandBarSeparator3, Me.cbddOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisplayName = "Separator 1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisplayName = "Separator 3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
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
        'cbbEdit
        '
        Me.cbbEdit.DisplayName = "Edit Record"
        Me.cbbEdit.DrawText = True
        Me.cbbEdit.Image = CType(resources.GetObject("cbbEdit.Image"), System.Drawing.Image)
        Me.cbbEdit.Name = "cbbEdit"
        Me.cbbEdit.Text = "Edit Record"
        Me.cbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'cbbImportData
        '
        Me.cbbImportData.DisplayName = "Import Data"
        Me.cbbImportData.DrawText = True
        Me.cbbImportData.Image = CType(resources.GetObject("cbbImportData.Image"), System.Drawing.Image)
        Me.cbbImportData.Name = "cbbImportData"
        Me.cbbImportData.Text = "Import Data"
        Me.cbbImportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.miEnableFiltering.Text = "Enable Filternig"
        '
        'miEnableGrouping
        '
        Me.miEnableGrouping.CheckOnClick = True
        Me.miEnableGrouping.Name = "miEnableGrouping"
        Me.miEnableGrouping.Text = "Enable Grouping"
        '
        'FrmCustomerItemMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 615)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Name = "FrmCustomerItemMaster"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Item Master"
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtPartLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seStdQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents mcbCustomer As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents seStdQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtModelCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCustomerPartNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPartLevel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbImportData As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
End Class

