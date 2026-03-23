<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomerStdLeadTime
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerStdLeadTime))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbUpdate = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
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
        Me.pnlForm = New Telerik.WinControls.UI.RadPanel()
        Me.dtEffectivityDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblEffectivityDate = New Telerik.WinControls.UI.RadLabel()
        Me.numETACustomerAir = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numETACustomerSea = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numETDManilaAir = New Telerik.WinControls.UI.RadSpinEditor()
        Me.mcbCustomer = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblETACustomerAir = New Telerik.WinControls.UI.RadLabel()
        Me.lblETDManilaAir = New Telerik.WinControls.UI.RadLabel()
        Me.lblETACustomerSea = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.cmActionChooser = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.miCopy = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.miHistory = New Telerik.WinControls.UI.RadMenuItem()
        Me.lblETDManilaSea = New Telerik.WinControls.UI.RadLabel()
        Me.numETDManilaSea = New Telerik.WinControls.UI.RadSpinEditor()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        CType(Me.dtEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numETACustomerAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numETACustomerSea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numETDManilaAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETACustomerAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDManilaAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETACustomerSea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDManilaSea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numETDManilaSea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 90)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(788, 56)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbUpdate, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbddOptions})
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
        'cbbUpdate
        '
        Me.cbbUpdate.AutoSize = False
        Me.cbbUpdate.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbUpdate.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbUpdate.DisplayName = "CommandBarButton1"
        Me.cbbUpdate.DrawText = True
        Me.cbbUpdate.Image = CType(resources.GetObject("cbbUpdate.Image"), System.Drawing.Image)
        Me.cbbUpdate.Name = "cbbUpdate"
        Me.cbbUpdate.Text = "Update"
        Me.cbbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbUpdate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbUpdate.UseCompatibleTextRendering = False
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
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 553)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(788, 29)
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
        Me.gvData.Location = New System.Drawing.Point(0, 146)
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
        Me.gvData.Size = New System.Drawing.Size(788, 407)
        Me.gvData.TabIndex = 2
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.Silver
        Me.pnlForm.Controls.Add(Me.dtEffectivityDate)
        Me.pnlForm.Controls.Add(Me.lblEffectivityDate)
        Me.pnlForm.Controls.Add(Me.numETACustomerAir)
        Me.pnlForm.Controls.Add(Me.numETACustomerSea)
        Me.pnlForm.Controls.Add(Me.numETDManilaSea)
        Me.pnlForm.Controls.Add(Me.numETDManilaAir)
        Me.pnlForm.Controls.Add(Me.mcbCustomer)
        Me.pnlForm.Controls.Add(Me.lblETDManilaSea)
        Me.pnlForm.Controls.Add(Me.lblETACustomerAir)
        Me.pnlForm.Controls.Add(Me.lblETDManilaAir)
        Me.pnlForm.Controls.Add(Me.lblETACustomerSea)
        Me.pnlForm.Controls.Add(Me.lblCustomer)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(788, 90)
        Me.pnlForm.TabIndex = 0
        Me.pnlForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'dtEffectivityDate
        '
        Me.dtEffectivityDate.CustomFormat = "MMM dd, yyyy"
        Me.dtEffectivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEffectivityDate.Location = New System.Drawing.Point(342, 6)
        Me.dtEffectivityDate.Name = "dtEffectivityDate"
        Me.dtEffectivityDate.Size = New System.Drawing.Size(110, 20)
        Me.dtEffectivityDate.TabIndex = 4
        Me.dtEffectivityDate.TabStop = False
        Me.dtEffectivityDate.Text = "Mar 23, 2021"
        Me.dtEffectivityDate.Value = New Date(2021, 3, 23, 13, 57, 38, 321)
        '
        'lblEffectivityDate
        '
        Me.lblEffectivityDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEffectivityDate.Location = New System.Drawing.Point(255, 7)
        Me.lblEffectivityDate.Name = "lblEffectivityDate"
        Me.lblEffectivityDate.Size = New System.Drawing.Size(81, 18)
        Me.lblEffectivityDate.TabIndex = 0
        Me.lblEffectivityDate.Text = "Effectivity Date"
        '
        'numETACustomerAir
        '
        Me.numETACustomerAir.Location = New System.Drawing.Point(342, 58)
        Me.numETACustomerAir.Name = "numETACustomerAir"
        Me.numETACustomerAir.Size = New System.Drawing.Size(110, 20)
        Me.numETACustomerAir.TabIndex = 6
        Me.numETACustomerAir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numETACustomerAir.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numETACustomerAir.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'numETACustomerSea
        '
        Me.numETACustomerSea.Location = New System.Drawing.Point(342, 32)
        Me.numETACustomerSea.Name = "numETACustomerSea"
        Me.numETACustomerSea.Size = New System.Drawing.Size(110, 20)
        Me.numETACustomerSea.TabIndex = 5
        Me.numETACustomerSea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numETACustomerSea.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numETACustomerSea.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'numETDManilaAir
        '
        Me.numETDManilaAir.Location = New System.Drawing.Point(111, 58)
        Me.numETDManilaAir.Name = "numETDManilaAir"
        Me.numETDManilaAir.Size = New System.Drawing.Size(110, 20)
        Me.numETDManilaAir.TabIndex = 3
        Me.numETDManilaAir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numETDManilaAir.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numETDManilaAir.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
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
        Me.mcbCustomer.Location = New System.Drawing.Point(111, 6)
        Me.mcbCustomer.Name = "mcbCustomer"
        Me.mcbCustomer.Size = New System.Drawing.Size(110, 20)
        Me.mcbCustomer.TabIndex = 1
        Me.mcbCustomer.TabStop = False
        '
        'lblETACustomerAir
        '
        Me.lblETACustomerAir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETACustomerAir.Location = New System.Drawing.Point(235, 60)
        Me.lblETACustomerAir.Name = "lblETACustomerAir"
        Me.lblETACustomerAir.Size = New System.Drawing.Size(101, 18)
        Me.lblETACustomerAir.TabIndex = 0
        Me.lblETACustomerAir.Text = "ETA Customer (Air)"
        '
        'lblETDManilaAir
        '
        Me.lblETDManilaAir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDManilaAir.Location = New System.Drawing.Point(19, 60)
        Me.lblETDManilaAir.Name = "lblETDManilaAir"
        Me.lblETDManilaAir.Size = New System.Drawing.Size(86, 18)
        Me.lblETDManilaAir.TabIndex = 0
        Me.lblETDManilaAir.Text = "ETD Manila (Air)"
        '
        'lblETACustomerSea
        '
        Me.lblETACustomerSea.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETACustomerSea.Location = New System.Drawing.Point(232, 34)
        Me.lblETACustomerSea.Name = "lblETACustomerSea"
        Me.lblETACustomerSea.Size = New System.Drawing.Size(104, 18)
        Me.lblETACustomerSea.TabIndex = 0
        Me.lblETACustomerSea.Text = "ETA Customer (Sea)"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(50, 8)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
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
        Me.cmActionChooser.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miCopy, Me.RadMenuSeparatorItem1, Me.miHistory})
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
        'miHistory
        '
        Me.miHistory.Image = Global.MIA.My.Resources.Resources.history
        Me.miHistory.Name = "miHistory"
        Me.miHistory.Text = "History"
        Me.miHistory.UseCompatibleTextRendering = False
        '
        'lblETDManilaSea
        '
        Me.lblETDManilaSea.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDManilaSea.Location = New System.Drawing.Point(15, 34)
        Me.lblETDManilaSea.Name = "lblETDManilaSea"
        Me.lblETDManilaSea.Size = New System.Drawing.Size(90, 18)
        Me.lblETDManilaSea.TabIndex = 0
        Me.lblETDManilaSea.Text = "ETD Manila (Sea)"
        '
        'numETDManilaSea
        '
        Me.numETDManilaSea.Location = New System.Drawing.Point(111, 32)
        Me.numETDManilaSea.Name = "numETDManilaSea"
        Me.numETDManilaSea.Size = New System.Drawing.Size(110, 20)
        Me.numETDManilaSea.TabIndex = 2
        Me.numETDManilaSea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numETDManilaSea.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numETDManilaSea.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'FrmCustomerStdLeadTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 582)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCustomerStdLeadTime"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Std Lead Time"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.dtEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numETACustomerAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numETACustomerSea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numETDManilaAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETACustomerAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDManilaAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETACustomerSea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDManilaSea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numETDManilaSea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbUpdate As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents pnlForm As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblETACustomerAir As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETDManilaAir As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETACustomerSea As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbCustomer As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents numETACustomerAir As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numETACustomerSea As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numETDManilaAir As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents dtEffectivityDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblEffectivityDate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cmActionChooser As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents miCopy As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents miHistory As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents numETDManilaSea As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblETDManilaSea As Telerik.WinControls.UI.RadLabel
End Class

