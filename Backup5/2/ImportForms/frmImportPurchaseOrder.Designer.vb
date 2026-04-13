<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportPurchaseOrder))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbPaste = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbStartImport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteSelected = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClearList = New Telerik.WinControls.UI.CommandBarButton()
        Me.pnlContols = New Telerik.WinControls.UI.RadPanel()
        Me.ddCustomerCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblCustomerCode = New Telerik.WinControls.UI.RadLabel()
        Me.ddModeOfShipment = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtPONo = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPONo = New Telerik.WinControls.UI.RadLabel()
        Me.lblModeOfShipment = New Telerik.WinControls.UI.RadLabel()
        Me.dtETACustomer = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtDateReceived = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDateReceived = New Telerik.WinControls.UI.RadLabel()
        Me.lblETACustomer = New Telerik.WinControls.UI.RadLabel()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.bwCheck = New System.ComponentModel.BackgroundWorker()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlContols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContols.SuspendLayout()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddModeOfShipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPONo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPONo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModeOfShipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 171)
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
        Me.gvData.Size = New System.Drawing.Size(877, 254)
        Me.gvData.TabIndex = 2
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(877, 27)
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
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 19)
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
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 90)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(877, 81)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbPaste, Me.cbbStartImport, Me.cbbDeleteSelected, Me.cbbClearList})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
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
        'pnlContols
        '
        Me.pnlContols.BackColor = System.Drawing.Color.Silver
        Me.pnlContols.Controls.Add(Me.ddCustomerCode)
        Me.pnlContols.Controls.Add(Me.lblCustomerCode)
        Me.pnlContols.Controls.Add(Me.ddModeOfShipment)
        Me.pnlContols.Controls.Add(Me.txtPONo)
        Me.pnlContols.Controls.Add(Me.lblPONo)
        Me.pnlContols.Controls.Add(Me.lblModeOfShipment)
        Me.pnlContols.Controls.Add(Me.dtETACustomer)
        Me.pnlContols.Controls.Add(Me.dtDateReceived)
        Me.pnlContols.Controls.Add(Me.lblDateReceived)
        Me.pnlContols.Controls.Add(Me.lblETACustomer)
        Me.pnlContols.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlContols.Location = New System.Drawing.Point(0, 0)
        Me.pnlContols.Name = "pnlContols"
        Me.pnlContols.Size = New System.Drawing.Size(877, 90)
        Me.pnlContols.TabIndex = 0
        Me.pnlContols.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlContols.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'ddCustomerCode
        '
        '
        'ddCustomerCode.NestedRadGridView
        '
        Me.ddCustomerCode.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddCustomerCode.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddCustomerCode.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddCustomerCode.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.ddCustomerCode.EditorControl.Name = "NestedRadGridView"
        Me.ddCustomerCode.EditorControl.ReadOnly = True
        Me.ddCustomerCode.EditorControl.ShowGroupPanel = False
        Me.ddCustomerCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddCustomerCode.EditorControl.TabIndex = 0
        Me.ddCustomerCode.Location = New System.Drawing.Point(110, 58)
        Me.ddCustomerCode.Name = "ddCustomerCode"
        Me.ddCustomerCode.Size = New System.Drawing.Size(110, 20)
        Me.ddCustomerCode.TabIndex = 3
        Me.ddCustomerCode.TabStop = False
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerCode.Location = New System.Drawing.Point(49, 60)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomerCode.TabIndex = 5
        Me.lblCustomerCode.Text = "Customer"
        '
        'ddModeOfShipment
        '
        Me.ddModeOfShipment.DropDownAnimationEnabled = True
        RadListDataItem1.Text = "Sea"
        RadListDataItem2.Text = "Air"
        Me.ddModeOfShipment.Items.Add(RadListDataItem1)
        Me.ddModeOfShipment.Items.Add(RadListDataItem2)
        Me.ddModeOfShipment.Location = New System.Drawing.Point(332, 7)
        Me.ddModeOfShipment.Name = "ddModeOfShipment"
        Me.ddModeOfShipment.Size = New System.Drawing.Size(110, 20)
        Me.ddModeOfShipment.TabIndex = 4
        '
        'txtPONo
        '
        Me.txtPONo.Location = New System.Drawing.Point(332, 33)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(110, 20)
        Me.txtPONo.TabIndex = 5
        '
        'lblPONo
        '
        Me.lblPONo.BackColor = System.Drawing.Color.Transparent
        Me.lblPONo.Location = New System.Drawing.Point(284, 34)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(42, 18)
        Me.lblPONo.TabIndex = 0
        Me.lblPONo.Text = "PO No."
        '
        'lblModeOfShipment
        '
        Me.lblModeOfShipment.BackColor = System.Drawing.Color.Transparent
        Me.lblModeOfShipment.Location = New System.Drawing.Point(226, 8)
        Me.lblModeOfShipment.Name = "lblModeOfShipment"
        Me.lblModeOfShipment.Size = New System.Drawing.Size(100, 18)
        Me.lblModeOfShipment.TabIndex = 0
        Me.lblModeOfShipment.Text = "Mode of Shipment"
        '
        'dtETACustomer
        '
        Me.dtETACustomer.CustomFormat = "MMM dd, yyyy"
        Me.dtETACustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETACustomer.Location = New System.Drawing.Point(110, 32)
        Me.dtETACustomer.Name = "dtETACustomer"
        Me.dtETACustomer.Size = New System.Drawing.Size(110, 20)
        Me.dtETACustomer.TabIndex = 2
        Me.dtETACustomer.TabStop = False
        Me.dtETACustomer.Text = "Jan 12, 2022"
        Me.dtETACustomer.Value = New Date(2022, 1, 12, 8, 13, 41, 854)
        '
        'dtDateReceived
        '
        Me.dtDateReceived.CustomFormat = "MMM dd, yyyy"
        Me.dtDateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateReceived.Location = New System.Drawing.Point(110, 6)
        Me.dtDateReceived.Name = "dtDateReceived"
        Me.dtDateReceived.Size = New System.Drawing.Size(110, 20)
        Me.dtDateReceived.TabIndex = 1
        Me.dtDateReceived.TabStop = False
        Me.dtDateReceived.Text = "Jan 12, 2022"
        Me.dtDateReceived.Value = New Date(2022, 1, 12, 8, 13, 41, 854)
        '
        'lblDateReceived
        '
        Me.lblDateReceived.BackColor = System.Drawing.Color.Transparent
        Me.lblDateReceived.Location = New System.Drawing.Point(27, 8)
        Me.lblDateReceived.Name = "lblDateReceived"
        Me.lblDateReceived.Size = New System.Drawing.Size(77, 18)
        Me.lblDateReceived.TabIndex = 0
        Me.lblDateReceived.Text = "Date Received"
        '
        'lblETACustomer
        '
        Me.lblETACustomer.BackColor = System.Drawing.Color.Transparent
        Me.lblETACustomer.Location = New System.Drawing.Point(27, 33)
        Me.lblETACustomer.Name = "lblETACustomer"
        Me.lblETACustomer.Size = New System.Drawing.Size(77, 18)
        Me.lblETACustomer.TabIndex = 0
        Me.lblETACustomer.Text = "ETA Customer"
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'bwCheck
        '
        Me.bwCheck.WorkerReportsProgress = True
        '
        'FrmImportPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 452)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlContols)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImportPurchaseOrder"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Purchase Order"
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlContols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContols.ResumeLayout(False)
        Me.pnlContols.PerformLayout()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddModeOfShipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPONo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPONo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModeOfShipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbPaste As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbStartImport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDeleteSelected As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClearList As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents pnlContols As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtPONo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPONo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblModeOfShipment As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtETACustomer As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtDateReceived As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblDateReceived As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETACustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddModeOfShipment As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ddCustomerCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblCustomerCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwCheck As System.ComponentModel.BackgroundWorker
End Class

