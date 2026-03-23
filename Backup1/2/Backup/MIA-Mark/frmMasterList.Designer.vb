<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterList))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbPick = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miCurrentRow = New Telerik.WinControls.UI.RadMenuItem()
        Me.miSelected = New Telerik.WinControls.UI.RadMenuItem()
        Me.miAll = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.gvRecords = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadRecords = New System.ComponentModel.BackgroundWorker()
        Me.RadContextMenuManager1 = New Telerik.WinControls.UI.RadContextMenuManager()
        Me.cmMasterList = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.cmiPickCurrentRow = New Telerik.WinControls.UI.RadMenuItem()
        Me.cmiPickSelected = New Telerik.WinControls.UI.RadMenuItem()
        Me.cmiPickAll = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRecords.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(512, 40)
        Me.RadCommandBar1.TabIndex = 0
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.cbbPick})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        '
        'cbbRefresh
        '
        Me.cbbRefresh.DisplayName = "Refresh"
        Me.cbbRefresh.DrawText = True
        Me.cbbRefresh.Image = CType(resources.GetObject("cbbRefresh.Image"), System.Drawing.Image)
        Me.cbbRefresh.Name = "cbbRefresh"
        Me.cbbRefresh.Text = "Refresh"
        Me.cbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'cbbPick
        '
        Me.cbbPick.DisplayName = "Pick"
        Me.cbbPick.DrawText = True
        Me.cbbPick.Image = CType(resources.GetObject("cbbPick.Image"), System.Drawing.Image)
        Me.cbbPick.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miCurrentRow, Me.miSelected, Me.miAll})
        Me.cbbPick.Name = "cbbPick"
        Me.cbbPick.Text = "Pick"
        Me.cbbPick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'miCurrentRow
        '
        Me.miCurrentRow.Image = CType(resources.GetObject("miCurrentRow.Image"), System.Drawing.Image)
        Me.miCurrentRow.Name = "miCurrentRow"
        Me.miCurrentRow.Text = "Current Row"
        '
        'miSelected
        '
        Me.miSelected.Image = CType(resources.GetObject("miSelected.Image"), System.Drawing.Image)
        Me.miSelected.Name = "miSelected"
        Me.miSelected.Text = "Selected"
        '
        'miAll
        '
        Me.miAll.Image = CType(resources.GetObject("miAll.Image"), System.Drawing.Image)
        Me.miAll.Name = "miAll"
        Me.miAll.Text = "All"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 358)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(512, 26)
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
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, False)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        '
        'gvRecords
        '
        Me.gvRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvRecords.Location = New System.Drawing.Point(0, 40)
        '
        '
        '
        Me.gvRecords.MasterTemplate.AllowCellContextMenu = False
        Me.gvRecords.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvRecords.Name = "gvRecords"
        Me.RadContextMenuManager1.SetRadContextMenu(Me.gvRecords, Me.cmMasterList)
        Me.gvRecords.Size = New System.Drawing.Size(512, 318)
        Me.gvRecords.TabIndex = 2
        '
        'bwLoadRecords
        '
        Me.bwLoadRecords.WorkerReportsProgress = True
        '
        'cmMasterList
        '
        Me.cmMasterList.Items.AddRange(New Telerik.WinControls.RadItem() {Me.cmiPickCurrentRow, Me.cmiPickSelected, Me.cmiPickAll})
        '
        'cmiPickCurrentRow
        '
        Me.cmiPickCurrentRow.Image = CType(resources.GetObject("cmiPickCurrentRow.Image"), System.Drawing.Image)
        Me.cmiPickCurrentRow.Name = "cmiPickCurrentRow"
        Me.cmiPickCurrentRow.Text = "Pick Current Row"
        '
        'cmiPickSelected
        '
        Me.cmiPickSelected.Image = CType(resources.GetObject("cmiPickSelected.Image"), System.Drawing.Image)
        Me.cmiPickSelected.Name = "cmiPickSelected"
        Me.cmiPickSelected.Text = "Pick Selected"
        '
        'cmiPickAll
        '
        Me.cmiPickAll.Image = CType(resources.GetObject("cmiPickAll.Image"), System.Drawing.Image)
        Me.cmiPickAll.Name = "cmiPickAll"
        Me.cmiPickAll.Text = "Pick All"
        '
        'FrmMasterList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 384)
        Me.Controls.Add(Me.gvRecords)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmMasterList"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.Text = "Master List"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRecords.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents gvRecords As Telerik.WinControls.UI.RadGridView
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbPick As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents miCurrentRow As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miSelected As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miAll As Telerik.WinControls.UI.RadMenuItem
    Public WithEvents bwLoadRecords As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadContextMenuManager1 As Telerik.WinControls.UI.RadContextMenuManager
    Friend WithEvents cmMasterList As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents cmiPickCurrentRow As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cmiPickSelected As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cmiPickAll As Telerik.WinControls.UI.RadMenuItem
End Class

