<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImportDemand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportDemand))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbPaste = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbStartImport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteSelected = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClearList = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.pnlContols = New Telerik.WinControls.UI.RadPanel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.ddCustomerCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblRemarks = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomerCode = New Telerik.WinControls.UI.RadLabel()
        Me.dtDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDateFrom = New Telerik.WinControls.UI.RadLabel()
        Me.lblDateTo = New Telerik.WinControls.UI.RadLabel()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.bwCheck = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlContols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContols.SuspendLayout()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'pnlContols
        '
        Me.pnlContols.BackColor = System.Drawing.Color.Silver
        Me.pnlContols.Controls.Add(Me.txtRemarks)
        Me.pnlContols.Controls.Add(Me.ddCustomerCode)
        Me.pnlContols.Controls.Add(Me.lblRemarks)
        Me.pnlContols.Controls.Add(Me.lblCustomerCode)
        Me.pnlContols.Controls.Add(Me.dtDateTo)
        Me.pnlContols.Controls.Add(Me.dtDateFrom)
        Me.pnlContols.Controls.Add(Me.lblDateFrom)
        Me.pnlContols.Controls.Add(Me.lblDateTo)
        Me.pnlContols.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlContols.Location = New System.Drawing.Point(0, 0)
        Me.pnlContols.Name = "pnlContols"
        Me.pnlContols.Size = New System.Drawing.Size(877, 90)
        Me.pnlContols.TabIndex = 0
        Me.pnlContols.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlContols.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(262, 6)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        '
        '
        '
        Me.txtRemarks.RootElement.StretchVertically = True
        Me.txtRemarks.Size = New System.Drawing.Size(110, 46)
        Me.txtRemarks.TabIndex = 4
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
        Me.ddCustomerCode.Location = New System.Drawing.Point(70, 58)
        Me.ddCustomerCode.Name = "ddCustomerCode"
        Me.ddCustomerCode.Size = New System.Drawing.Size(110, 20)
        Me.ddCustomerCode.TabIndex = 3
        Me.ddCustomerCode.TabStop = False
        '
        'lblRemarks
        '
        Me.lblRemarks.BackColor = System.Drawing.Color.Transparent
        Me.lblRemarks.Location = New System.Drawing.Point(207, 8)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 18)
        Me.lblRemarks.TabIndex = 0
        Me.lblRemarks.Text = "Remarks"
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerCode.Location = New System.Drawing.Point(9, 60)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomerCode.TabIndex = 0
        Me.lblCustomerCode.Text = "Customer"
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "MMM dd, yyyy"
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(70, 32)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(110, 20)
        Me.dtDateTo.TabIndex = 2
        Me.dtDateTo.TabStop = False
        Me.dtDateTo.Text = "Jan 12, 2022"
        Me.dtDateTo.Value = New Date(2022, 1, 12, 8, 13, 41, 854)
        '
        'dtDateFrom
        '
        Me.dtDateFrom.CustomFormat = "MMM dd, yyyy"
        Me.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrom.Location = New System.Drawing.Point(70, 6)
        Me.dtDateFrom.Name = "dtDateFrom"
        Me.dtDateFrom.Size = New System.Drawing.Size(110, 20)
        Me.dtDateFrom.TabIndex = 1
        Me.dtDateFrom.TabStop = False
        Me.dtDateFrom.Text = "Jan 12, 2022"
        Me.dtDateFrom.Value = New Date(2022, 1, 12, 8, 13, 41, 854)
        '
        'lblDateFrom
        '
        Me.lblDateFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblDateFrom.Location = New System.Drawing.Point(5, 8)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(59, 18)
        Me.lblDateFrom.TabIndex = 0
        Me.lblDateFrom.Text = "Date From"
        '
        'lblDateTo
        '
        Me.lblDateTo.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTo.Location = New System.Drawing.Point(19, 34)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(45, 18)
        Me.lblDateTo.TabIndex = 0
        Me.lblDateTo.Text = "Date To"
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'bwCheck
        '
        Me.bwCheck.WorkerReportsProgress = True
        '
        'FrmImportDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 452)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlContols)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImportDemand"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmImportDemand"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlContols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContols.ResumeLayout(False)
        Me.pnlContols.PerformLayout()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateTo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlContols As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dtDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblDateFrom As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDateTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddCustomerCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblCustomerCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwCheck As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblRemarks As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
End Class

