<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCapacityPlanning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCapacityPlanning))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.CrystalTheme1 = New Telerik.WinControls.Themes.CrystalTheme()
        Me.pnlControls = New Telerik.WinControls.UI.RadPanel()
        Me.lblMonthYear2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblWorkingDays2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblWorkingDays = New Telerik.WinControls.UI.RadLabel()
        Me.lblMonthYear = New Telerik.WinControls.UI.RadLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbPasteData = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbStartImport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbCalculate = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteSelected = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClearList = New Telerik.WinControls.UI.CommandBarButton()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwSavePlanning = New System.ComponentModel.BackgroundWorker()
        Me.bwPlanning = New System.ComponentModel.BackgroundWorker()
        Me.gvReqWDays = New Telerik.WinControls.UI.RadGridView()
        Me.bwWDays = New System.ComponentModel.BackgroundWorker()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.bwSaveWDays = New System.ComponentModel.BackgroundWorker()
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        CType(Me.lblMonthYear2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWorkingDays2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWorkingDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMonthYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReqWDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReqWDays.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Silver
        Me.pnlControls.Controls.Add(Me.lblMonthYear2)
        Me.pnlControls.Controls.Add(Me.lblWorkingDays2)
        Me.pnlControls.Controls.Add(Me.lblWorkingDays)
        Me.pnlControls.Controls.Add(Me.lblMonthYear)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(985, 60)
        Me.pnlControls.TabIndex = 0
        Me.pnlControls.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlControls.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'lblMonthYear2
        '
        Me.lblMonthYear2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthYear2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMonthYear2.Location = New System.Drawing.Point(3, 39)
        Me.lblMonthYear2.Name = "lblMonthYear2"
        Me.lblMonthYear2.Size = New System.Drawing.Size(65, 18)
        Me.lblMonthYear2.TabIndex = 0
        Me.lblMonthYear2.Text = "Month Year"
        '
        'lblWorkingDays2
        '
        Me.lblWorkingDays2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWorkingDays2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkingDays2.ForeColor = System.Drawing.Color.Red
        Me.lblWorkingDays2.Location = New System.Drawing.Point(906, 39)
        Me.lblWorkingDays2.Name = "lblWorkingDays2"
        Me.lblWorkingDays2.Size = New System.Drawing.Size(76, 18)
        Me.lblWorkingDays2.TabIndex = 0
        Me.lblWorkingDays2.Text = "Working Days"
        '
        'lblWorkingDays
        '
        Me.lblWorkingDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWorkingDays.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblWorkingDays.ForeColor = System.Drawing.Color.Red
        Me.lblWorkingDays.Location = New System.Drawing.Point(945, 4)
        Me.lblWorkingDays.Name = "lblWorkingDays"
        Me.lblWorkingDays.Size = New System.Drawing.Size(34, 33)
        Me.lblWorkingDays.TabIndex = 0
        Me.lblWorkingDays.Text = "00"
        '
        'lblMonthYear
        '
        Me.lblMonthYear.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonthYear.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMonthYear.Location = New System.Drawing.Point(3, 4)
        Me.lblMonthYear.Name = "lblMonthYear"
        Me.lblMonthYear.Size = New System.Drawing.Size(142, 33)
        Me.lblMonthYear.TabIndex = 0
        Me.lblMonthYear.Text = "Month / Year"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 60)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(985, 81)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbPasteData, Me.cbbStartImport, Me.cbbCalculate, Me.cbbDeleteSelected, Me.cbbClearList})
        Me.CommandBarStripElement1.MinSize = New System.Drawing.Size(30, 30)
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'cbbPasteData
        '
        Me.cbbPasteData.AutoSize = False
        Me.cbbPasteData.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbPasteData.DisplayName = "CommandBarButton1"
        Me.cbbPasteData.DrawText = True
        Me.cbbPasteData.Image = CType(resources.GetObject("cbbPasteData.Image"), System.Drawing.Image)
        Me.cbbPasteData.Name = "cbbPasteData"
        Me.cbbPasteData.Text = "Paste Data"
        Me.cbbPasteData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'cbbCalculate
        '
        Me.cbbCalculate.AutoSize = False
        Me.cbbCalculate.Bounds = New System.Drawing.Rectangle(0, 0, 86, 52)
        Me.cbbCalculate.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbCalculate.DisplayName = "Paste Data"
        Me.cbbCalculate.DrawText = True
        Me.cbbCalculate.Image = CType(resources.GetObject("cbbCalculate.Image"), System.Drawing.Image)
        Me.cbbCalculate.Name = "cbbCalculate"
        Me.cbbCalculate.Text = "Calculate Test"
        Me.cbbCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbCalculate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbCalculate.UseCompatibleTextRendering = False
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
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(480, 141)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.ShowGroupPanel = False
        Me.gvData.Size = New System.Drawing.Size(505, 408)
        Me.gvData.TabIndex = 2
        '
        'bwSavePlanning
        '
        Me.bwSavePlanning.WorkerReportsProgress = True
        '
        'bwPlanning
        '
        Me.bwPlanning.WorkerReportsProgress = True
        '
        'gvReqWDays
        '
        Me.gvReqWDays.Dock = System.Windows.Forms.DockStyle.Left
        Me.gvReqWDays.Location = New System.Drawing.Point(0, 141)
        '
        '
        '
        Me.gvReqWDays.MasterTemplate.AllowAddNewRow = False
        Me.gvReqWDays.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvReqWDays.Name = "gvReqWDays"
        Me.gvReqWDays.ShowGroupPanel = False
        Me.gvReqWDays.Size = New System.Drawing.Size(480, 408)
        Me.gvReqWDays.TabIndex = 2
        '
        'bwWDays
        '
        Me.bwWDays.WorkerReportsProgress = True
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
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 549)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(985, 26)
        Me.RadStatusStrip1.TabIndex = 3
        '
        'bwSaveWDays
        '
        Me.bwSaveWDays.WorkerReportsProgress = True
        '
        'FrmCapacityPlanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 575)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.gvReqWDays)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlControls)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(993, 605)
        Me.Name = "FrmCapacityPlanning"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capacity Planning"
        Me.ThemeName = "CrystalDark"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.lblMonthYear2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWorkingDays2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWorkingDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMonthYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReqWDays.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReqWDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalTheme1 As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents pnlControls As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbCalculate As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbStartImport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDeleteSelected As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClearList As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblMonthYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblMonthYear2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblWorkingDays2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblWorkingDays As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbbPasteData As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents bwSavePlanning As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwPlanning As System.ComponentModel.BackgroundWorker
    Friend WithEvents gvReqWDays As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwWDays As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents bwSaveWDays As System.ComponentModel.BackgroundWorker
End Class

