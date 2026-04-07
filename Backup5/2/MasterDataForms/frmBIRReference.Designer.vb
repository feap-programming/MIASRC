<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBIRReference
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBIRReference))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.pnlForm = New Telerik.WinControls.UI.RadPanel()
        Me.dtDateIssued = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtPermitNo = New Telerik.WinControls.UI.RadTextBox()
        Me.numSeriesTo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numSeriesFrom = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblSeriesTo = New Telerik.WinControls.UI.RadLabel()
        Me.lblSeriesFrom = New Telerik.WinControls.UI.RadLabel()
        Me.lblPermitNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblDateIssued = New Telerik.WinControls.UI.RadLabel()
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
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        CType(Me.dtDateIssued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPermitNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSeriesTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSeriesFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeriesTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeriesFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPermitNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateIssued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.Silver
        Me.pnlForm.Controls.Add(Me.dtDateIssued)
        Me.pnlForm.Controls.Add(Me.txtPermitNo)
        Me.pnlForm.Controls.Add(Me.numSeriesTo)
        Me.pnlForm.Controls.Add(Me.numSeriesFrom)
        Me.pnlForm.Controls.Add(Me.lblSeriesTo)
        Me.pnlForm.Controls.Add(Me.lblSeriesFrom)
        Me.pnlForm.Controls.Add(Me.lblPermitNo)
        Me.pnlForm.Controls.Add(Me.lblDateIssued)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(788, 90)
        Me.pnlForm.TabIndex = 0
        Me.pnlForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'dtDateIssued
        '
        Me.dtDateIssued.CustomFormat = "MMM dd, yyyy"
        Me.dtDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateIssued.Location = New System.Drawing.Point(91, 32)
        Me.dtDateIssued.Name = "dtDateIssued"
        Me.dtDateIssued.Size = New System.Drawing.Size(110, 20)
        Me.dtDateIssued.TabIndex = 2
        Me.dtDateIssued.TabStop = False
        Me.dtDateIssued.Text = "Mar 23, 2021"
        Me.dtDateIssued.Value = New Date(2021, 3, 23, 13, 57, 38, 321)
        '
        'txtPermitNo
        '
        Me.txtPermitNo.Location = New System.Drawing.Point(91, 6)
        Me.txtPermitNo.Name = "txtPermitNo"
        Me.txtPermitNo.Size = New System.Drawing.Size(110, 20)
        Me.txtPermitNo.TabIndex = 1
        '
        'numSeriesTo
        '
        Me.numSeriesTo.Location = New System.Drawing.Point(281, 32)
        Me.numSeriesTo.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numSeriesTo.Name = "numSeriesTo"
        Me.numSeriesTo.Size = New System.Drawing.Size(110, 20)
        Me.numSeriesTo.TabIndex = 4
        Me.numSeriesTo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numSeriesTo.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numSeriesTo.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'numSeriesFrom
        '
        Me.numSeriesFrom.Location = New System.Drawing.Point(281, 6)
        Me.numSeriesFrom.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numSeriesFrom.Name = "numSeriesFrom"
        Me.numSeriesFrom.Size = New System.Drawing.Size(110, 20)
        Me.numSeriesFrom.TabIndex = 3
        Me.numSeriesFrom.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numSeriesFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numSeriesFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'lblSeriesTo
        '
        Me.lblSeriesTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeriesTo.Location = New System.Drawing.Point(224, 34)
        Me.lblSeriesTo.Name = "lblSeriesTo"
        Me.lblSeriesTo.Size = New System.Drawing.Size(51, 18)
        Me.lblSeriesTo.TabIndex = 0
        Me.lblSeriesTo.Text = "Series To"
        '
        'lblSeriesFrom
        '
        Me.lblSeriesFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeriesFrom.Location = New System.Drawing.Point(214, 8)
        Me.lblSeriesFrom.Name = "lblSeriesFrom"
        Me.lblSeriesFrom.Size = New System.Drawing.Size(61, 18)
        Me.lblSeriesFrom.TabIndex = 0
        Me.lblSeriesFrom.Text = "SeriesFrom"
        '
        'lblPermitNo
        '
        Me.lblPermitNo.Location = New System.Drawing.Point(28, 8)
        Me.lblPermitNo.Name = "lblPermitNo"
        Me.lblPermitNo.Size = New System.Drawing.Size(57, 18)
        Me.lblPermitNo.TabIndex = 0
        Me.lblPermitNo.Text = "Permit No"
        '
        'lblDateIssued
        '
        Me.lblDateIssued.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateIssued.Location = New System.Drawing.Point(21, 34)
        Me.lblDateIssued.Name = "lblDateIssued"
        Me.lblDateIssued.Size = New System.Drawing.Size(64, 18)
        Me.lblDateIssued.TabIndex = 0
        Me.lblDateIssued.Text = "Date Issued"
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
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        Me.bwLoadData.WorkerSupportsCancellation = True
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'FrmBIRReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 582)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBIRReference"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BIR Reference"
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.dtDateIssued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPermitNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSeriesTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSeriesFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeriesTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeriesFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPermitNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateIssued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlForm As Telerik.WinControls.UI.RadPanel
    Friend WithEvents numSeriesTo As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numSeriesFrom As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblSeriesTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblSeriesFrom As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblPermitNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDateIssued As Telerik.WinControls.UI.RadLabel
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
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtPermitNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dtDateIssued As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
End Class

