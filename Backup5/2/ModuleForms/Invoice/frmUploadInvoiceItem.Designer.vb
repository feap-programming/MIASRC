<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUploadInvoiceItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUploadInvoiceItem))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbAddItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbPaste = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteSelected = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClearList = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbStartImport = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.pnlForm = New Telerik.WinControls.UI.RadPanel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPartNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtModel = New Telerik.WinControls.UI.RadTextBox()
        Me.ddUnit = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblUnit = New Telerik.WinControls.UI.RadLabel()
        Me.numQuantity = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblQuantity = New Telerik.WinControls.UI.RadLabel()
        Me.numUnitPrice = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblUnitPrice = New Telerik.WinControls.UI.RadLabel()
        Me.lblPartNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.lblModel = New Telerik.WinControls.UI.RadLabel()
        Me.ddlCustomerPartNo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblCustomerPartNo = New Telerik.WinControls.UI.RadLabel()
        Me.txtReferenceNo = New Telerik.WinControls.UI.RadTextBox()
        Me.lblReferenceNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblInvoiceNo = New Telerik.WinControls.UI.RadLabel()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.bwCheck = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCustomerPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCustomerPartNo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlCustomerPartNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomerPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferenceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReferenceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 92)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(877, 58)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbAddItem, Me.cbbPaste, Me.cbbDeleteSelected, Me.cbbClearList, Me.CommandBarSeparator1, Me.cbbStartImport})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'cbbAddItem
        '
        Me.cbbAddItem.AutoSize = False
        Me.cbbAddItem.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbAddItem.DisplayName = "CommandBarButton1"
        Me.cbbAddItem.DrawText = True
        Me.cbbAddItem.Image = CType(resources.GetObject("cbbAddItem.Image"), System.Drawing.Image)
        Me.cbbAddItem.Name = "cbbAddItem"
        Me.cbbAddItem.Text = "Add Item"
        Me.cbbAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbPaste
        '
        Me.cbbPaste.AutoSize = False
        Me.cbbPaste.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbPaste.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbPaste.DisplayName = "Paste Data"
        Me.cbbPaste.DrawText = True
        Me.cbbPaste.Image = CType(resources.GetObject("cbbPaste.Image"), System.Drawing.Image)
        Me.cbbPaste.Name = "cbbPaste"
        Me.cbbPaste.Text = "Paste Data"
        Me.cbbPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbPaste.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbPaste.UseCompatibleTextRendering = False
        '
        'cbbDeleteSelected
        '
        Me.cbbDeleteSelected.AutoSize = False
        Me.cbbDeleteSelected.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbDeleteSelected.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDeleteSelected.DisplayName = "Delete Selected"
        Me.cbbDeleteSelected.DrawText = True
        Me.cbbDeleteSelected.Image = CType(resources.GetObject("cbbDeleteSelected.Image"), System.Drawing.Image)
        Me.cbbDeleteSelected.Name = "cbbDeleteSelected"
        Me.cbbDeleteSelected.Text = "Delete Selected"
        Me.cbbDeleteSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbDeleteSelected.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDeleteSelected.UseCompatibleTextRendering = False
        '
        'cbbClearList
        '
        Me.cbbClearList.AutoSize = False
        Me.cbbClearList.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbClearList.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbClearList.DisplayName = "Clear List"
        Me.cbbClearList.DrawText = True
        Me.cbbClearList.Image = CType(resources.GetObject("cbbClearList.Image"), System.Drawing.Image)
        Me.cbbClearList.Name = "cbbClearList"
        Me.cbbClearList.Text = "Clear List"
        Me.cbbClearList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbClearList.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbClearList.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cbbStartImport
        '
        Me.cbbStartImport.AutoSize = False
        Me.cbbStartImport.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbStartImport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbStartImport.DisplayName = "Start Import"
        Me.cbbStartImport.DrawText = True
        Me.cbbStartImport.Image = CType(resources.GetObject("cbbStartImport.Image"), System.Drawing.Image)
        Me.cbbStartImport.Name = "cbbStartImport"
        Me.cbbStartImport.Text = "Start Import"
        Me.cbbStartImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbStartImport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbStartImport.UseCompatibleTextRendering = False
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(877, 24)
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
        'RadProgressBarElement1
        '
        Me.RadProgressBarElement1.AutoSize = False
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 18)
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
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 150)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.ShowGroupPanel = False
        Me.gvData.Size = New System.Drawing.Size(877, 278)
        Me.gvData.TabIndex = 2
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.Silver
        Me.pnlForm.Controls.Add(Me.txtPartName)
        Me.pnlForm.Controls.Add(Me.txtPartNo)
        Me.pnlForm.Controls.Add(Me.txtModel)
        Me.pnlForm.Controls.Add(Me.ddUnit)
        Me.pnlForm.Controls.Add(Me.lblUnit)
        Me.pnlForm.Controls.Add(Me.numQuantity)
        Me.pnlForm.Controls.Add(Me.lblQuantity)
        Me.pnlForm.Controls.Add(Me.numUnitPrice)
        Me.pnlForm.Controls.Add(Me.lblUnitPrice)
        Me.pnlForm.Controls.Add(Me.lblPartNo)
        Me.pnlForm.Controls.Add(Me.lblPartName)
        Me.pnlForm.Controls.Add(Me.lblModel)
        Me.pnlForm.Controls.Add(Me.ddlCustomerPartNo)
        Me.pnlForm.Controls.Add(Me.lblCustomerPartNo)
        Me.pnlForm.Controls.Add(Me.txtReferenceNo)
        Me.pnlForm.Controls.Add(Me.lblReferenceNo)
        Me.pnlForm.Controls.Add(Me.lblInvoiceNo)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlForm.Name = "pnlForm"
        '
        '
        '
        Me.pnlForm.RootElement.BorderHighlightColor = System.Drawing.Color.White
        Me.pnlForm.Size = New System.Drawing.Size(877, 92)
        Me.pnlForm.TabIndex = 0
        Me.pnlForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(397, 36)
        Me.txtPartName.Multiline = True
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        '
        '
        '
        Me.txtPartName.RootElement.StretchVertically = True
        Me.txtPartName.Size = New System.Drawing.Size(110, 46)
        Me.txtPartName.TabIndex = 4
        '
        'txtPartNo
        '
        Me.txtPartNo.Enabled = False
        Me.txtPartNo.Location = New System.Drawing.Point(200, 62)
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.ReadOnly = True
        Me.txtPartNo.Size = New System.Drawing.Size(110, 24)
        Me.txtPartNo.TabIndex = 3
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(397, 10)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(110, 24)
        Me.txtModel.TabIndex = 4
        '
        'ddUnit
        '
        Me.ddUnit.DropDownAnimationEnabled = True
        Me.ddUnit.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "PC"
        RadListDataItem2.Text = "M"
        RadListDataItem3.Text = "KG"
        Me.ddUnit.Items.Add(RadListDataItem1)
        Me.ddUnit.Items.Add(RadListDataItem2)
        Me.ddUnit.Items.Add(RadListDataItem3)
        Me.ddUnit.Location = New System.Drawing.Point(600, 62)
        Me.ddUnit.Name = "ddUnit"
        Me.ddUnit.Size = New System.Drawing.Size(110, 24)
        Me.ddUnit.TabIndex = 8
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Location = New System.Drawing.Point(567, 64)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(27, 18)
        Me.lblUnit.TabIndex = 0
        Me.lblUnit.Text = "Unit"
        '
        'numQuantity
        '
        Me.numQuantity.DecimalPlaces = 4
        Me.numQuantity.Location = New System.Drawing.Point(600, 36)
        Me.numQuantity.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.ShowUpDownButtons = False
        Me.numQuantity.Size = New System.Drawing.Size(110, 24)
        Me.numQuantity.TabIndex = 7
        Me.numQuantity.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Location = New System.Drawing.Point(545, 37)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 18)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Quantity"
        '
        'numUnitPrice
        '
        Me.numUnitPrice.DecimalPlaces = 4
        Me.numUnitPrice.Location = New System.Drawing.Point(600, 10)
        Me.numUnitPrice.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numUnitPrice.Name = "numUnitPrice"
        Me.numUnitPrice.ShowUpDownButtons = False
        Me.numUnitPrice.Size = New System.Drawing.Size(110, 24)
        Me.numUnitPrice.TabIndex = 6
        Me.numUnitPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblUnitPrice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPrice.Location = New System.Drawing.Point(540, 12)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(54, 18)
        Me.lblUnitPrice.TabIndex = 0
        Me.lblUnitPrice.Text = "Unit Price"
        '
        'lblPartNo
        '
        Me.lblPartNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPartNo.Location = New System.Drawing.Point(122, 63)
        Me.lblPartNo.Name = "lblPartNo"
        Me.lblPartNo.Size = New System.Drawing.Size(72, 18)
        Me.lblPartNo.TabIndex = 0
        Me.lblPartNo.Text = "FEAP Part No"
        '
        'lblPartName
        '
        Me.lblPartName.BackColor = System.Drawing.Color.Transparent
        Me.lblPartName.Location = New System.Drawing.Point(332, 37)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(59, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "Part Name"
        '
        'lblModel
        '
        Me.lblModel.BackColor = System.Drawing.Color.Transparent
        Me.lblModel.Location = New System.Drawing.Point(353, 11)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(38, 18)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model"
        '
        'ddlCustomerPartNo
        '
        '
        'ddlCustomerPartNo.NestedRadGridView
        '
        Me.ddlCustomerPartNo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlCustomerPartNo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlCustomerPartNo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlCustomerPartNo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlCustomerPartNo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlCustomerPartNo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlCustomerPartNo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlCustomerPartNo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlCustomerPartNo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlCustomerPartNo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.ddlCustomerPartNo.EditorControl.Name = "NestedRadGridView"
        Me.ddlCustomerPartNo.EditorControl.ReadOnly = True
        Me.ddlCustomerPartNo.EditorControl.ShowGroupPanel = False
        Me.ddlCustomerPartNo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlCustomerPartNo.EditorControl.TabIndex = 0
        Me.ddlCustomerPartNo.Location = New System.Drawing.Point(200, 36)
        Me.ddlCustomerPartNo.Name = "ddlCustomerPartNo"
        Me.ddlCustomerPartNo.Size = New System.Drawing.Size(110, 24)
        Me.ddlCustomerPartNo.TabIndex = 2
        Me.ddlCustomerPartNo.TabStop = False
        '
        'lblCustomerPartNo
        '
        Me.lblCustomerPartNo.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerPartNo.Location = New System.Drawing.Point(98, 37)
        Me.lblCustomerPartNo.Name = "lblCustomerPartNo"
        Me.lblCustomerPartNo.Size = New System.Drawing.Size(96, 18)
        Me.lblCustomerPartNo.TabIndex = 0
        Me.lblCustomerPartNo.Text = "Customer Part No"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.Location = New System.Drawing.Point(200, 10)
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(110, 24)
        Me.txtReferenceNo.TabIndex = 1
        '
        'lblReferenceNo
        '
        Me.lblReferenceNo.BackColor = System.Drawing.Color.Transparent
        Me.lblReferenceNo.Location = New System.Drawing.Point(120, 11)
        Me.lblReferenceNo.Name = "lblReferenceNo"
        Me.lblReferenceNo.Size = New System.Drawing.Size(74, 18)
        Me.lblReferenceNo.TabIndex = 0
        Me.lblReferenceNo.Text = "Reference No"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblInvoiceNo.Location = New System.Drawing.Point(12, 12)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(75, 21)
        Me.lblInvoiceNo.TabIndex = 0
        Me.lblInvoiceNo.Text = "Invoice No"
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'bwCheck
        '
        Me.bwCheck.WorkerReportsProgress = True
        '
        'FrmUploadInvoiceItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 452)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUploadInvoiceItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Upload Invoice Item"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCustomerPartNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCustomerPartNo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlCustomerPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomerPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferenceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReferenceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbPaste As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbStartImport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDeleteSelected As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClearList As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents pnlForm As Telerik.WinControls.UI.RadPanel
    Friend WithEvents cbbAddItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents lblInvoiceNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtReferenceNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblReferenceNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlCustomerPartNo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblCustomerPartNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblModel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numUnitPrice As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblUnitPrice As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numQuantity As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblQuantity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddUnit As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblUnit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtModel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPartNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwCheck As System.ComponentModel.BackgroundWorker
End Class

