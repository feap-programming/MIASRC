<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddBOMContents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddBOMContents))
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbSubContent = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbBOMTitle = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbSave = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAddTolist = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClear = New Telerik.WinControls.UI.CommandBarButton()
        Me.bwSave = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbSubContent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbSubContent.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbSubContent.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbBOMTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbBOMTitle.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbBOMTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 375)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(661, 29)
        Me.RadStatusStrip1.TabIndex = 0
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Items:"
        Me.RadLabelElement1.TextWrap = True
        '
        'leCountRec
        '
        Me.leCountRec.Name = "leCountRec"
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, True)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        '
        'RadProgressBarElement1
        '
        Me.RadProgressBarElement1.AutoSize = False
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 21)
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
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.mcbSubContent)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.mcbItemCode)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.mcbBOMTitle)
        Me.RadGroupBox1.HeaderText = "Header:"
        Me.RadGroupBox1.Location = New System.Drawing.Point(25, 60)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(616, 104)
        Me.RadGroupBox1.TabIndex = 1
        Me.RadGroupBox1.Text = "Header:"
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(85, 49)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(71, 18)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Sub Content:"
        '
        'mcbSubContent
        '
        '
        'mcbSubContent.NestedRadGridView
        '
        Me.mcbSubContent.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbSubContent.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbSubContent.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbSubContent.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbSubContent.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbSubContent.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbSubContent.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbSubContent.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbSubContent.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbSubContent.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbSubContent.EditorControl.Name = "NestedRadGridView"
        Me.mcbSubContent.EditorControl.ReadOnly = True
        Me.mcbSubContent.EditorControl.ShowGroupPanel = False
        Me.mcbSubContent.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbSubContent.EditorControl.TabIndex = 0
        Me.mcbSubContent.Location = New System.Drawing.Point(162, 47)
        Me.mcbSubContent.Name = "mcbSubContent"
        Me.mcbSubContent.Size = New System.Drawing.Size(401, 20)
        Me.mcbSubContent.TabIndex = 4
        Me.mcbSubContent.TabStop = False
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(98, 23)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(58, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "BOM Title:"
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(162, 73)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(401, 20)
        Me.mcbItemCode.TabIndex = 0
        Me.mcbItemCode.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(95, 75)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Item Code:"
        '
        'mcbBOMTitle
        '
        '
        'mcbBOMTitle.NestedRadGridView
        '
        Me.mcbBOMTitle.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbBOMTitle.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbBOMTitle.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbBOMTitle.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbBOMTitle.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbBOMTitle.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbBOMTitle.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbBOMTitle.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbBOMTitle.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbBOMTitle.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbBOMTitle.EditorControl.Name = "NestedRadGridView"
        Me.mcbBOMTitle.EditorControl.ReadOnly = True
        Me.mcbBOMTitle.EditorControl.ShowGroupPanel = False
        Me.mcbBOMTitle.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbBOMTitle.EditorControl.TabIndex = 0
        Me.mcbBOMTitle.Location = New System.Drawing.Point(162, 21)
        Me.mcbBOMTitle.Name = "mcbBOMTitle"
        Me.mcbBOMTitle.Size = New System.Drawing.Size(401, 20)
        Me.mcbBOMTitle.TabIndex = 2
        Me.mcbBOMTitle.TabStop = False
        '
        'gvData
        '
        Me.gvData.Location = New System.Drawing.Point(25, 170)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(616, 196)
        Me.gvData.TabIndex = 2
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(661, 40)
        Me.RadCommandBar1.TabIndex = 3
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbSave, Me.CommandBarSeparator1, Me.cbbAddTolist, Me.cbbDelete, Me.cbbClear})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        '
        '
        Me.CommandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        Me.CommandBarStripElement1.StretchHorizontally = True
        CType(Me.CommandBarStripElement1.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'cbbSave
        '
        Me.cbbSave.AutoSize = True
        Me.cbbSave.DisplayName = "CommandBarButton1"
        Me.cbbSave.DrawText = True
        Me.cbbSave.Image = CType(resources.GetObject("cbbSave.Image"), System.Drawing.Image)
        Me.cbbSave.Name = "cbbSave"
        Me.cbbSave.Text = "Save"
        Me.cbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cbbAddTolist
        '
        Me.cbbAddTolist.AutoSize = True
        Me.cbbAddTolist.DisplayName = "CommandBaarButton1"
        Me.cbbAddTolist.DrawText = True
        Me.cbbAddTolist.Image = CType(resources.GetObject("cbbAddTolist.Image"), System.Drawing.Image)
        Me.cbbAddTolist.Name = "cbbAddTolist"
        Me.cbbAddTolist.Text = "Add to List"
        Me.cbbAddTolist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'cbbDelete
        '
        Me.cbbDelete.AutoSize = True
        Me.cbbDelete.DisplayName = "CommandBarButton2"
        Me.cbbDelete.DrawText = True
        Me.cbbDelete.Image = CType(resources.GetObject("cbbDelete.Image"), System.Drawing.Image)
        Me.cbbDelete.Name = "cbbDelete"
        Me.cbbDelete.Text = "Delete from List"
        Me.cbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'cbbClear
        '
        Me.cbbClear.AutoSize = True
        Me.cbbClear.DisplayName = "CommandBarButton1"
        Me.cbbClear.DrawText = True
        Me.cbbClear.Image = CType(resources.GetObject("cbbClear.Image"), System.Drawing.Image)
        Me.cbbClear.Name = "cbbClear"
        Me.cbbClear.Text = "Clear List"
        Me.cbbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'bwSave
        '
        Me.bwSave.WorkerReportsProgress = True
        '
        'FrmAddBOMContents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(661, 404)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(669, 434)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(669, 434)
        Me.Name = "FrmAddBOMContents"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(669, 434)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add BOM Contents"
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbSubContent.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbSubContent.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbSubContent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbBOMTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbBOMTitle.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbBOMTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbAddTolist As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbBOMTitle As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents cbbClear As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents bwSave As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbSubContent As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class

