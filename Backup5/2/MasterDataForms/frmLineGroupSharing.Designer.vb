<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLineGroupSharing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLineGroupSharing))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.pnlControls = New Telerik.WinControls.UI.RadPanel()
        Me.drpSharingCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblSharingCode = New Telerik.WinControls.UI.RadLabel()
        Me.drpLineCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblLineCode = New Telerik.WinControls.UI.RadLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
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
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        CType(Me.drpSharingCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSharingCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpLineCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLineCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Silver
        Me.pnlControls.Controls.Add(Me.drpSharingCode)
        Me.pnlControls.Controls.Add(Me.lblSharingCode)
        Me.pnlControls.Controls.Add(Me.drpLineCode)
        Me.pnlControls.Controls.Add(Me.lblLineCode)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(985, 92)
        Me.pnlControls.TabIndex = 1
        Me.pnlControls.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlControls.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'drpSharingCode
        '
        Me.drpSharingCode.Location = New System.Drawing.Point(85, 10)
        Me.drpSharingCode.Name = "drpSharingCode"
        Me.drpSharingCode.Size = New System.Drawing.Size(150, 20)
        Me.drpSharingCode.TabIndex = 1
        '
        'lblSharingCode
        '
        Me.lblSharingCode.BackColor = System.Drawing.Color.Transparent
        Me.lblSharingCode.Location = New System.Drawing.Point(6, 12)
        Me.lblSharingCode.Name = "lblSharingCode"
        Me.lblSharingCode.Size = New System.Drawing.Size(73, 18)
        Me.lblSharingCode.TabIndex = 0
        Me.lblSharingCode.Text = "Sharing Code"
        '
        'drpLineCode
        '
        Me.drpLineCode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.drpLineCode.Location = New System.Drawing.Point(85, 36)
        Me.drpLineCode.Name = "drpLineCode"
        Me.drpLineCode.Size = New System.Drawing.Size(150, 20)
        Me.drpLineCode.TabIndex = 2
        '
        'lblLineCode
        '
        Me.lblLineCode.BackColor = System.Drawing.Color.Transparent
        Me.lblLineCode.Location = New System.Drawing.Point(52, 38)
        Me.lblLineCode.Name = "lblLineCode"
        Me.lblLineCode.Size = New System.Drawing.Size(27, 18)
        Me.lblLineCode.TabIndex = 0
        Me.lblLineCode.Text = "Line"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 92)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(985, 81)
        Me.RadCommandBar1.TabIndex = 2
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.cbbAdd, Me.cbbEdit, Me.cbbDelete, Me.cbddOptions})
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
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 536)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(985, 29)
        Me.RadStatusStrip1.TabIndex = 4
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
        Me.gvData.Location = New System.Drawing.Point(0, 173)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.EnableFiltering = True
        Me.gvData.MasterTemplate.MultiSelect = True
        Me.gvData.MasterTemplate.ShowFilteringRow = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.ShowGroupPanel = False
        Me.gvData.Size = New System.Drawing.Size(985, 363)
        Me.gvData.TabIndex = 3
        '
        'bwLoadData
        '
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'FrmLineGroupSharing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 565)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlControls)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLineGroupSharing"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Line Group Sharing"
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.drpSharingCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSharingCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpLineCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLineCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlControls As Telerik.WinControls.UI.RadPanel
    Friend WithEvents drpLineCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblLineCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents drpSharingCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblSharingCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
End Class

