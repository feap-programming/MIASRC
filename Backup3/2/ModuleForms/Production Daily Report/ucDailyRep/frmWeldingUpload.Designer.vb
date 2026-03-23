<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWeldingUpload
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
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWeldingUpload))
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.pnlMain = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.gvLot = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
        Me.gvOtherDetails = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.gvDefect = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.gvHourly = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.gvGQ = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.gvDataManpower = New Telerik.WinControls.UI.RadGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbOwO = New Telerik.WinControls.UI.RadProgressBar()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbOpen = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbSave = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.PanelContainer.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.gvLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLot.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox6.SuspendLayout()
        CType(Me.gvOtherDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOtherDetails.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.gvDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDefect.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.gvHourly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHourly.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.gvGQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGQ.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.gvDataManpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDataManpower.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbOwO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        '
        'pnlMain.PanelContainer
        '
        Me.pnlMain.PanelContainer.Controls.Add(Me.RadGroupBox5)
        Me.pnlMain.PanelContainer.Controls.Add(Me.RadGroupBox6)
        Me.pnlMain.PanelContainer.Controls.Add(Me.RadGroupBox4)
        Me.pnlMain.PanelContainer.Controls.Add(Me.RadGroupBox3)
        Me.pnlMain.PanelContainer.Controls.Add(Me.RadGroupBox2)
        Me.pnlMain.PanelContainer.Controls.Add(Me.RadGroupBox1)
        Me.pnlMain.PanelContainer.Controls.Add(Me.Panel1)
        Me.pnlMain.PanelContainer.Controls.Add(Me.RadCommandBar1)
        Me.pnlMain.PanelContainer.Size = New System.Drawing.Size(1082, 751)
        Me.pnlMain.Size = New System.Drawing.Size(1101, 753)
        Me.pnlMain.TabIndex = 0
        Me.pnlMain.ThemeName = "CrystalDark"
        '
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Controls.Add(Me.gvLot)
        Me.RadGroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox5.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox5.HeaderText = "RM/WIP Lot No."
        Me.RadGroupBox5.Location = New System.Drawing.Point(0, 2143)
        Me.RadGroupBox5.Name = "RadGroupBox5"
        Me.RadGroupBox5.Size = New System.Drawing.Size(1082, 454)
        Me.RadGroupBox5.TabIndex = 28
        Me.RadGroupBox5.Text = "RM/WIP Lot No."
        Me.RadGroupBox5.ThemeName = "CrystalDark"
        '
        'gvLot
        '
        Me.gvLot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvLot.Location = New System.Drawing.Point(2, 40)
        '
        '
        '
        Me.gvLot.MasterTemplate.AllowColumnReorder = False
        Me.gvLot.MasterTemplate.AllowDragToGroup = False
        Me.gvLot.MasterTemplate.AllowEditRow = False
        Me.gvLot.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvLot.Name = "gvLot"
        Me.gvLot.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvLot.Size = New System.Drawing.Size(1078, 412)
        Me.gvLot.TabIndex = 20
        Me.gvLot.ThemeName = "CrystalDark"
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Controls.Add(Me.gvOtherDetails)
        Me.RadGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox6.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox6.HeaderText = "Other Details"
        Me.RadGroupBox6.Location = New System.Drawing.Point(0, 1689)
        Me.RadGroupBox6.Name = "RadGroupBox6"
        Me.RadGroupBox6.Size = New System.Drawing.Size(1082, 454)
        Me.RadGroupBox6.TabIndex = 27
        Me.RadGroupBox6.Text = "Other Details"
        Me.RadGroupBox6.ThemeName = "CrystalDark"
        '
        'gvOtherDetails
        '
        Me.gvOtherDetails.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvOtherDetails.Location = New System.Drawing.Point(2, 40)
        '
        '
        '
        Me.gvOtherDetails.MasterTemplate.AllowColumnReorder = False
        Me.gvOtherDetails.MasterTemplate.AllowDragToGroup = False
        Me.gvOtherDetails.MasterTemplate.AllowEditRow = False
        Me.gvOtherDetails.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvOtherDetails.Name = "gvOtherDetails"
        Me.gvOtherDetails.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvOtherDetails.Size = New System.Drawing.Size(1078, 412)
        Me.gvOtherDetails.TabIndex = 20
        Me.gvOtherDetails.ThemeName = "CrystalDark"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Controls.Add(Me.gvDefect)
        Me.RadGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox4.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox4.HeaderText = "Defects"
        Me.RadGroupBox4.Location = New System.Drawing.Point(0, 1235)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(1082, 454)
        Me.RadGroupBox4.TabIndex = 24
        Me.RadGroupBox4.Text = "Defects"
        Me.RadGroupBox4.ThemeName = "CrystalDark"
        '
        'gvDefect
        '
        Me.gvDefect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvDefect.Location = New System.Drawing.Point(2, 40)
        '
        '
        '
        Me.gvDefect.MasterTemplate.AllowColumnReorder = False
        Me.gvDefect.MasterTemplate.AllowDragToGroup = False
        Me.gvDefect.MasterTemplate.AllowEditRow = False
        Me.gvDefect.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gvDefect.Name = "gvDefect"
        Me.gvDefect.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvDefect.Size = New System.Drawing.Size(1078, 412)
        Me.gvDefect.TabIndex = 20
        Me.gvDefect.ThemeName = "CrystalDark"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.gvHourly)
        Me.RadGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox3.HeaderText = "Hourly"
        Me.RadGroupBox3.Location = New System.Drawing.Point(0, 809)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(1082, 426)
        Me.RadGroupBox3.TabIndex = 26
        Me.RadGroupBox3.Text = "Hourly"
        Me.RadGroupBox3.ThemeName = "CrystalDark"
        '
        'gvHourly
        '
        Me.gvHourly.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvHourly.Location = New System.Drawing.Point(2, 36)
        '
        '
        '
        Me.gvHourly.MasterTemplate.AllowColumnReorder = False
        Me.gvHourly.MasterTemplate.AllowDragToGroup = False
        Me.gvHourly.MasterTemplate.AllowEditRow = False
        Me.gvHourly.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gvHourly.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.gvHourly.Name = "gvHourly"
        Me.gvHourly.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvHourly.Size = New System.Drawing.Size(1078, 388)
        Me.gvHourly.TabIndex = 20
        Me.gvHourly.ThemeName = "CrystalDark"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.gvGQ)
        Me.RadGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox2.HeaderText = "Good Quantity"
        Me.RadGroupBox2.Location = New System.Drawing.Point(0, 383)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(1082, 426)
        Me.RadGroupBox2.TabIndex = 22
        Me.RadGroupBox2.Text = "Good Quantity"
        Me.RadGroupBox2.ThemeName = "CrystalDark"
        '
        'gvGQ
        '
        Me.gvGQ.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvGQ.Location = New System.Drawing.Point(2, 36)
        '
        '
        '
        Me.gvGQ.MasterTemplate.AllowColumnReorder = False
        Me.gvGQ.MasterTemplate.AllowDragToGroup = False
        Me.gvGQ.MasterTemplate.AllowEditRow = False
        Me.gvGQ.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gvGQ.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.gvGQ.Name = "gvGQ"
        Me.gvGQ.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvGQ.Size = New System.Drawing.Size(1078, 388)
        Me.gvGQ.TabIndex = 20
        Me.gvGQ.ThemeName = "CrystalDark"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.gvDataManpower)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox1.HeaderText = "Manpower"
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 84)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(1082, 299)
        Me.RadGroupBox1.TabIndex = 21
        Me.RadGroupBox1.Text = "Manpower"
        Me.RadGroupBox1.ThemeName = "CrystalDark"
        '
        'gvDataManpower
        '
        Me.gvDataManpower.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvDataManpower.Location = New System.Drawing.Point(2, 36)
        '
        '
        '
        Me.gvDataManpower.MasterTemplate.AllowAddNewRow = False
        Me.gvDataManpower.MasterTemplate.AllowCellContextMenu = False
        Me.gvDataManpower.MasterTemplate.AllowColumnChooser = False
        Me.gvDataManpower.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.gvDataManpower.MasterTemplate.AllowColumnReorder = False
        Me.gvDataManpower.MasterTemplate.AllowDeleteRow = False
        Me.gvDataManpower.MasterTemplate.AllowDragToGroup = False
        Me.gvDataManpower.MasterTemplate.AllowEditRow = False
        Me.gvDataManpower.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gvDataManpower.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.gvDataManpower.Name = "gvDataManpower"
        Me.gvDataManpower.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvDataManpower.Size = New System.Drawing.Size(1078, 261)
        Me.gvDataManpower.TabIndex = 20
        Me.gvDataManpower.ThemeName = "CrystalDark"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbOwO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1082, 27)
        Me.Panel1.TabIndex = 20
        '
        'pbOwO
        '
        Me.pbOwO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbOwO.Location = New System.Drawing.Point(0, 0)
        Me.pbOwO.Name = "pbOwO"
        Me.pbOwO.Size = New System.Drawing.Size(1082, 27)
        Me.pbOwO.TabIndex = 0
        Me.pbOwO.Text = "Hellow"
        Me.pbOwO.ThemeName = "CrystalDark"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1082, 57)
        Me.RadCommandBar1.TabIndex = 16
        Me.RadCommandBar1.ThemeName = "CrystalDark"
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
        Me.CommandBarStripElement1.DisplayName = "Control Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbOpen, Me.CommandBarSeparator1, Me.cbbSave, Me.CommandBarSeparator2})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'cbbOpen
        '
        Me.cbbOpen.AutoSize = False
        Me.cbbOpen.Bounds = New System.Drawing.Rectangle(0, 0, 110, 52)
        Me.cbbOpen.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbOpen.DisplayName = "Refresh"
        Me.cbbOpen.DrawText = True
        Me.cbbOpen.Image = CType(resources.GetObject("cbbOpen.Image"), System.Drawing.Image)
        Me.cbbOpen.Name = "cbbOpen"
        Me.cbbOpen.Text = "Open File"
        Me.cbbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbOpen.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbOpen.UseCompatibleTextRendering = False
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
        'cbbSave
        '
        Me.cbbSave.AutoSize = False
        Me.cbbSave.Bounds = New System.Drawing.Rectangle(0, 0, 99, 52)
        Me.cbbSave.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbSave.DisplayName = "Add Record"
        Me.cbbSave.DrawText = True
        Me.cbbSave.Image = CType(resources.GetObject("cbbSave.Image"), System.Drawing.Image)
        Me.cbbSave.Name = "cbbSave"
        Me.cbbSave.Text = "Save"
        Me.cbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbSave.UseCompatibleTextRendering = False
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
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'FrmWeldingUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 753)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "FrmWeldingUpload"
        Me.Text = "UPLOAD DAILY REPORT"
        Me.ThemeName = "CrystalDark"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMain.PanelContainer.ResumeLayout(False)
        Me.pnlMain.PanelContainer.PerformLayout()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        CType(Me.gvLot.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox6.ResumeLayout(False)
        CType(Me.gvOtherDetails.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOtherDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        CType(Me.gvDefect.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.gvHourly.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHourly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.gvGQ.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.gvDataManpower.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDataManpower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbOwO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents pnlMain As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbOpen As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbOwO As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents gvGQ As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents gvDataManpower As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents gvDefect As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents gvHourly As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox6 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents gvOtherDetails As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents gvLot As Telerik.WinControls.UI.RadGridView
End Class

