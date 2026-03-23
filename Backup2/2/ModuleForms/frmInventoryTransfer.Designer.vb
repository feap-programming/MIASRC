<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryTransfer
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
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryTransfer))
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.mcbShift = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblTo = New Telerik.WinControls.UI.RadLabel()
        Me.mcbTo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblFrom = New Telerik.WinControls.UI.RadLabel()
        Me.mcbFrom = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.rbtnBarcode = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbtnManual = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblBarcode = New Telerik.WinControls.UI.RadLabel()
        Me.txtBarcode = New Telerik.WinControls.UI.RadTextBox()
        Me.lblReceivedQty = New Telerik.WinControls.UI.RadLabel()
        Me.seReceivedQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblItemCode = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.CommandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel()
        Me.cbhDateFrom = New Telerik.WinControls.UI.CommandBarHostItem()
        Me.CommandBarLabel2 = New Telerik.WinControls.UI.CommandBarLabel()
        Me.cbhDateTo = New Telerik.WinControls.UI.CommandBarHostItem()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwDelete = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAddRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.mcbShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtnBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtnManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReceivedQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seReceivedQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.mcbShift)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.lblTo)
        Me.RadPanel1.Controls.Add(Me.mcbTo)
        Me.RadPanel1.Controls.Add(Me.lblFrom)
        Me.RadPanel1.Controls.Add(Me.mcbFrom)
        Me.RadPanel1.Controls.Add(Me.rbtnBarcode)
        Me.RadPanel1.Controls.Add(Me.rbtnManual)
        Me.RadPanel1.Controls.Add(Me.lblBarcode)
        Me.RadPanel1.Controls.Add(Me.txtBarcode)
        Me.RadPanel1.Controls.Add(Me.lblReceivedQty)
        Me.RadPanel1.Controls.Add(Me.seReceivedQty)
        Me.RadPanel1.Controls.Add(Me.lblItemCode)
        Me.RadPanel1.Controls.Add(Me.mcbItemCode)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(965, 190)
        Me.RadPanel1.TabIndex = 0
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
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
        Me.mcbShift.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbShift.EditorControl.Name = "NestedRadGridView"
        Me.mcbShift.EditorControl.ReadOnly = True
        Me.mcbShift.EditorControl.ShowGroupPanel = False
        Me.mcbShift.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbShift.EditorControl.TabIndex = 0
        Me.mcbShift.Location = New System.Drawing.Point(153, 102)
        Me.mcbShift.Name = "mcbShift"
        Me.mcbShift.NullText = "-- Select Shift --"
        Me.mcbShift.Size = New System.Drawing.Size(216, 20)
        Me.mcbShift.TabIndex = 4
        Me.mcbShift.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(116, 103)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel1.TabIndex = 15
        Me.RadLabel1.Text = "Shift:"
        '
        'lblTo
        '
        Me.lblTo.Location = New System.Drawing.Point(38, 78)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(110, 18)
        Me.lblTo.TabIndex = 13
        Me.lblTo.Text = "Warehouse Code To:"
        '
        'mcbTo
        '
        '
        'mcbTo.NestedRadGridView
        '
        Me.mcbTo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbTo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbTo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbTo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbTo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbTo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbTo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbTo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbTo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbTo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbTo.EditorControl.Name = "NestedRadGridView"
        Me.mcbTo.EditorControl.ReadOnly = True
        Me.mcbTo.EditorControl.ShowGroupPanel = False
        Me.mcbTo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbTo.EditorControl.TabIndex = 0
        Me.mcbTo.Location = New System.Drawing.Point(153, 76)
        Me.mcbTo.Name = "mcbTo"
        Me.mcbTo.NullText = "-- Select Warehouse Code To --"
        Me.mcbTo.Size = New System.Drawing.Size(216, 20)
        Me.mcbTo.TabIndex = 3
        Me.mcbTo.TabStop = False
        '
        'lblFrom
        '
        Me.lblFrom.Location = New System.Drawing.Point(24, 52)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(123, 18)
        Me.lblFrom.TabIndex = 11
        Me.lblFrom.Text = "Warehouse Code From:"
        '
        'mcbFrom
        '
        '
        'mcbFrom.NestedRadGridView
        '
        Me.mcbFrom.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbFrom.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbFrom.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbFrom.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbFrom.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbFrom.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbFrom.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbFrom.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbFrom.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbFrom.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbFrom.EditorControl.Name = "NestedRadGridView"
        Me.mcbFrom.EditorControl.ReadOnly = True
        Me.mcbFrom.EditorControl.ShowGroupPanel = False
        Me.mcbFrom.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbFrom.EditorControl.TabIndex = 0
        Me.mcbFrom.Location = New System.Drawing.Point(153, 50)
        Me.mcbFrom.Name = "mcbFrom"
        Me.mcbFrom.NullText = "-- Select Warehouse Code From --"
        Me.mcbFrom.Size = New System.Drawing.Size(216, 20)
        Me.mcbFrom.TabIndex = 2
        Me.mcbFrom.TabStop = False
        '
        'rbtnBarcode
        '
        Me.rbtnBarcode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbtnBarcode.Location = New System.Drawing.Point(268, 12)
        Me.rbtnBarcode.Name = "rbtnBarcode"
        Me.rbtnBarcode.Size = New System.Drawing.Size(61, 18)
        Me.rbtnBarcode.TabIndex = 1
        Me.rbtnBarcode.Text = "Barcode"
        Me.rbtnBarcode.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rbtnManual
        '
        Me.rbtnManual.Location = New System.Drawing.Point(153, 12)
        Me.rbtnManual.Name = "rbtnManual"
        Me.rbtnManual.Size = New System.Drawing.Size(87, 18)
        Me.rbtnManual.TabIndex = 0
        Me.rbtnManual.TabStop = False
        Me.rbtnManual.Text = "Manual Input"
        '
        'lblBarcode
        '
        Me.lblBarcode.Location = New System.Drawing.Point(401, 103)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(49, 18)
        Me.lblBarcode.TabIndex = 7
        Me.lblBarcode.Text = "Barcode:"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(456, 101)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(439, 20)
        Me.txtBarcode.TabIndex = 7
        '
        'lblReceivedQty
        '
        Me.lblReceivedQty.Enabled = False
        Me.lblReceivedQty.Location = New System.Drawing.Point(73, 155)
        Me.lblReceivedQty.Name = "lblReceivedQty"
        Me.lblReceivedQty.Size = New System.Drawing.Size(74, 18)
        Me.lblReceivedQty.TabIndex = 5
        Me.lblReceivedQty.Text = "Received Qty:"
        '
        'seReceivedQty
        '
        Me.seReceivedQty.DecimalPlaces = 2
        Me.seReceivedQty.Enabled = False
        Me.seReceivedQty.Location = New System.Drawing.Point(153, 153)
        Me.seReceivedQty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seReceivedQty.Name = "seReceivedQty"
        Me.seReceivedQty.ShowUpDownButtons = False
        Me.seReceivedQty.Size = New System.Drawing.Size(100, 20)
        Me.seReceivedQty.TabIndex = 6
        Me.seReceivedQty.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seReceivedQty.ThousandsSeparator = True
        '
        'lblItemCode
        '
        Me.lblItemCode.Enabled = False
        Me.lblItemCode.Location = New System.Drawing.Point(86, 129)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(61, 18)
        Me.lblItemCode.TabIndex = 1
        Me.lblItemCode.Text = "Item Code:"
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Enabled = False
        Me.mcbItemCode.Location = New System.Drawing.Point(153, 127)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.NullText = "-- Select Item Code --"
        Me.mcbItemCode.Size = New System.Drawing.Size(216, 20)
        Me.mcbItemCode.TabIndex = 5
        Me.mcbItemCode.TabStop = False
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement3, Me.lePermission, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 611)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(965, 26)
        Me.RadStatusStrip1.TabIndex = 1
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
        'RadLabelElement3
        '
        Me.RadLabelElement3.Name = "RadLabelElement3"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement3, False)
        Me.RadLabelElement3.Text = "Permission:"
        Me.RadLabelElement3.TextWrap = True
        '
        'lePermission
        '
        Me.lePermission.Name = "lePermission"
        Me.RadStatusStrip1.SetSpring(Me.lePermission, False)
        Me.lePermission.Text = "lePermission"
        Me.lePermission.TextWrap = True
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
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 190)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(965, 81)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarLabel1, Me.cbhDateFrom, Me.CommandBarLabel2, Me.cbhDateTo, Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAddRecord, Me.cbbEdit, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbbExport, Me.CommandBarSeparator3, Me.cbbOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        '
        'CommandBarLabel1
        '
        Me.CommandBarLabel1.DisplayName = "Date From Label"
        Me.CommandBarLabel1.Name = "CommandBarLabel1"
        Me.CommandBarLabel1.Text = "Date From:"
        '
        'cbhDateFrom
        '
        Me.cbhDateFrom.AutoSize = False
        Me.cbhDateFrom.Bounds = New System.Drawing.Rectangle(0, 0, 100, 52)
        Me.cbhDateFrom.DisplayName = "Date From"
        Me.cbhDateFrom.Name = "cbhDateFrom"
        Me.cbhDateFrom.Text = "CommandBarHostItem1"
        '
        'CommandBarLabel2
        '
        Me.CommandBarLabel2.DisplayName = "Date To Label"
        Me.CommandBarLabel2.Name = "CommandBarLabel2"
        Me.CommandBarLabel2.Text = "Date To:"
        '
        'cbhDateTo
        '
        Me.cbhDateTo.AutoSize = False
        Me.cbhDateTo.Bounds = New System.Drawing.Rectangle(0, 0, 100, 52)
        Me.cbhDateTo.DisplayName = "Date To"
        Me.cbhDateTo.Name = "cbhDateTo"
        Me.cbhDateTo.Text = "CommandBarHostItem1"
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
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 271)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(965, 340)
        Me.gvData.TabIndex = 3
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        '
        'bwDelete
        '
        Me.bwDelete.WorkerReportsProgress = True
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
        'cbbEdit
        '
        Me.cbbEdit.AutoSize = False
        Me.cbbEdit.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
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
        'frmInventoryTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 637)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadPanel1)
        Me.KeyPreview = True
        Me.Name = "frmInventoryTransfer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Transfer"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.mcbShift.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtnBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtnManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReceivedQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seReceivedQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement3 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAddRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents lblItemCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents seReceivedQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblReceivedQty As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBarcode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBarcode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rbtnBarcode As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbtnManual As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbTo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblFrom As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbFrom As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents bwDelete As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CommandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents cbhDateFrom As Telerik.WinControls.UI.CommandBarHostItem
    Friend WithEvents CommandBarLabel2 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents cbhDateTo As Telerik.WinControls.UI.CommandBarHostItem
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbShift As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class

