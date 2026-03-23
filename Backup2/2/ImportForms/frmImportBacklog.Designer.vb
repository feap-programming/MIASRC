<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportBacklog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportBacklog))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.pnlControls = New Telerik.WinControls.UI.RadPanel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbPaste = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbStartImport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteSelected = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClearList = New Telerik.WinControls.UI.CommandBarButton()
        Me.pnlContols = New Telerik.WinControls.UI.RadPanel()
        Me.ddCustomerCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblCustomerCode = New Telerik.WinControls.UI.RadLabel()
        Me.dtEffectivityDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblEffectivityDate = New Telerik.WinControls.UI.RadLabel()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.bwCheck = New System.ComponentModel.BackgroundWorker()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.lblRemarks = New Telerik.WinControls.UI.RadLabel()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlContols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContols.SuspendLayout()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 58)
        '
        '
        '
        Me.gvData.MasterTemplate.MultiSelect = True
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.ShowGroupPanel = False
        Me.gvData.Size = New System.Drawing.Size(877, 368)
        Me.gvData.TabIndex = 1
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(877, 26)
        Me.RadStatusStrip1.TabIndex = 2
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
        'pnlControls
        '
        Me.pnlControls.Controls.Add(Me.RadCommandBar1)
        Me.pnlControls.Controls.Add(Me.pnlContols)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(877, 58)
        Me.pnlControls.TabIndex = 0
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadCommandBar1.Location = New System.Drawing.Point(385, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(492, 56)
        Me.RadCommandBar1.TabIndex = 1
        Me.RadCommandBar1.ThemeName = "Office2010Black"
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbPaste, Me.CommandBarSeparator1, Me.cbbStartImport, Me.cbbDeleteSelected, Me.cbbClearList})
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
        Me.cbbPaste.DisplayName = "CommandBarButton1"
        Me.cbbPaste.DrawText = True
        Me.cbbPaste.Image = CType(resources.GetObject("cbbPaste.Image"), System.Drawing.Image)
        Me.cbbPaste.Name = "cbbPaste"
        Me.cbbPaste.Text = "Paste"
        Me.cbbPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbPaste.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbPaste.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.UseCompatibleTextRendering = False
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
        Me.pnlContols.Controls.Add(Me.lblRemarks)
        Me.pnlContols.Controls.Add(Me.txtRemarks)
        Me.pnlContols.Controls.Add(Me.ddCustomerCode)
        Me.pnlContols.Controls.Add(Me.lblCustomerCode)
        Me.pnlContols.Controls.Add(Me.dtEffectivityDate)
        Me.pnlContols.Controls.Add(Me.lblEffectivityDate)
        Me.pnlContols.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlContols.Location = New System.Drawing.Point(0, 0)
        Me.pnlContols.Name = "pnlContols"
        Me.pnlContols.Size = New System.Drawing.Size(385, 58)
        Me.pnlContols.TabIndex = 1
        CType(Me.pnlContols.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
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
        Me.ddCustomerCode.Location = New System.Drawing.Point(96, 32)
        Me.ddCustomerCode.Name = "ddCustomerCode"
        Me.ddCustomerCode.Size = New System.Drawing.Size(110, 20)
        Me.ddCustomerCode.TabIndex = 2
        Me.ddCustomerCode.TabStop = False
        Me.ddCustomerCode.ThemeName = "Office2007Black"
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerCode.ForeColor = System.Drawing.Color.White
        Me.lblCustomerCode.Location = New System.Drawing.Point(35, 34)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomerCode.TabIndex = 0
        Me.lblCustomerCode.Text = "Customer"
        '
        'dtEffectivityDate
        '
        Me.dtEffectivityDate.CustomFormat = "MMM dd, yyyy"
        Me.dtEffectivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEffectivityDate.Location = New System.Drawing.Point(96, 6)
        Me.dtEffectivityDate.Name = "dtEffectivityDate"
        Me.dtEffectivityDate.Size = New System.Drawing.Size(110, 20)
        Me.dtEffectivityDate.TabIndex = 1
        Me.dtEffectivityDate.TabStop = False
        Me.dtEffectivityDate.Text = "Aug 25, 2020"
        Me.dtEffectivityDate.ThemeName = "Office2007Black"
        Me.dtEffectivityDate.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblEffectivityDate
        '
        Me.lblEffectivityDate.ForeColor = System.Drawing.Color.White
        Me.lblEffectivityDate.Location = New System.Drawing.Point(9, 8)
        Me.lblEffectivityDate.Name = "lblEffectivityDate"
        Me.lblEffectivityDate.Size = New System.Drawing.Size(81, 18)
        Me.lblEffectivityDate.TabIndex = 0
        Me.lblEffectivityDate.Text = "Effectivity Date"
        Me.lblEffectivityDate.ThemeName = "Office2007Black"
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'bwCheck
        '
        Me.bwCheck.WorkerReportsProgress = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(267, 6)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        '
        '
        '
        Me.txtRemarks.RootElement.StretchVertically = True
        Me.txtRemarks.Size = New System.Drawing.Size(110, 46)
        Me.txtRemarks.TabIndex = 3
        '
        'lblRemarks
        '
        Me.lblRemarks.ForeColor = System.Drawing.Color.White
        Me.lblRemarks.Location = New System.Drawing.Point(212, 8)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 18)
        Me.lblRemarks.TabIndex = 0
        Me.lblRemarks.Text = "Remarks"
        Me.lblRemarks.ThemeName = "Office2007Black"
        '
        'FrmImportBacklog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 452)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.pnlControls)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImportBacklog"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Backlog"
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlContols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContols.ResumeLayout(False)
        Me.pnlContols.PerformLayout()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents pnlControls As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbPaste As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbStartImport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDeleteSelected As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClearList As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents pnlContols As Telerik.WinControls.UI.RadPanel
    Friend WithEvents ddCustomerCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblCustomerCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtEffectivityDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblEffectivityDate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwCheck As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblRemarks As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
End Class

