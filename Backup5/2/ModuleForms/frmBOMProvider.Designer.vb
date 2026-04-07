<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBOMProvider
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBOMProvider))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbOpen = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
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
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtApprovedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCheckedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPreparedBy = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpImplemDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpRevDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpEstDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRefNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDocuNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTitle = New Telerik.WinControls.UI.RadTextBox()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtApprovedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPreparedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpImplemDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRevDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEstDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocuNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 177)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(920, 81)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbEdit, Me.cbbDelete, Me.CommandBarSeparator3, Me.cbbOpen, Me.CommandBarSeparator2, Me.cbbOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        '
        'cbbRefresh
        '
        Me.cbbRefresh.AutoSize = False
        Me.cbbRefresh.Bounds = New System.Drawing.Rectangle(0, 0, 69, 52)
        Me.cbbRefresh.DisplayName = "Refresh"
        Me.cbbRefresh.DrawText = True
        Me.cbbRefresh.Image = CType(resources.GetObject("cbbRefresh.Image"), System.Drawing.Image)
        Me.cbbRefresh.Name = "cbbRefresh"
        Me.cbbRefresh.Text = "Refresh"
        Me.cbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisplayName = "Separator 1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cbbAdd
        '
        Me.cbbAdd.AutoSize = False
        Me.cbbAdd.Bounds = New System.Drawing.Rectangle(0, 0, 69, 52)
        Me.cbbAdd.DisplayName = "Add BOM"
        Me.cbbAdd.DrawText = True
        Me.cbbAdd.Image = CType(resources.GetObject("cbbAdd.Image"), System.Drawing.Image)
        Me.cbbAdd.Name = "cbbAdd"
        Me.cbbAdd.Text = "Add BOM"
        Me.cbbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbEdit
        '
        Me.cbbEdit.AutoSize = False
        Me.cbbEdit.Bounds = New System.Drawing.Rectangle(0, 0, 69, 52)
        Me.cbbEdit.DisplayName = "Edit BOM"
        Me.cbbEdit.DrawText = True
        Me.cbbEdit.Image = CType(resources.GetObject("cbbEdit.Image"), System.Drawing.Image)
        Me.cbbEdit.Name = "cbbEdit"
        Me.cbbEdit.Text = "Edit BOM"
        Me.cbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbDelete
        '
        Me.cbbDelete.AutoSize = True
        Me.cbbDelete.DisplayName = "Delete BOM"
        Me.cbbDelete.DrawText = True
        Me.cbbDelete.Image = CType(resources.GetObject("cbbDelete.Image"), System.Drawing.Image)
        Me.cbbDelete.Name = "cbbDelete"
        Me.cbbDelete.Text = "Delete BOM"
        Me.cbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisplayName = "Separator 2"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'cbbOpen
        '
        Me.cbbOpen.DisplayName = "Construction Area"
        Me.cbbOpen.DrawText = True
        Me.cbbOpen.Image = CType(resources.GetObject("cbbOpen.Image"), System.Drawing.Image)
        Me.cbbOpen.Name = "cbbOpen"
        Me.cbbOpen.Text = "Construction Area"
        Me.cbbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisplayName = "Separator 3"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cbbOptions
        '
        Me.cbbOptions.AutoSize = False
        Me.cbbOptions.Bounds = New System.Drawing.Rectangle(0, 0, 69, 52)
        Me.cbbOptions.DisplayName = "Options"
        Me.cbbOptions.DrawText = True
        Me.cbbOptions.Image = CType(resources.GetObject("cbbOptions.Image"), System.Drawing.Image)
        Me.cbbOptions.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miEnableFiltering, Me.miEnableGrouping})
        Me.cbbOptions.Name = "cbbOptions"
        Me.cbbOptions.Text = "Options"
        Me.cbbOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 508)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(920, 29)
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
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, True)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = "Permission:"
        Me.RadLabelElement2.TextWrap = True
        '
        'lePermission
        '
        Me.lePermission.Name = "lePermission"
        Me.RadStatusStrip1.SetSpring(Me.lePermission, False)
        Me.lePermission.Text = "lePermission"
        Me.lePermission.TextWrap = True
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator4, False)
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
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
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gvData.Location = New System.Drawing.Point(0, 258)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvData.Size = New System.Drawing.Size(920, 250)
        Me.gvData.TabIndex = 2
        Me.gvData.ThemeName = "Office2010Black"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtApprovedBy)
        Me.RadPanel1.Controls.Add(Me.txtCheckedBy)
        Me.RadPanel1.Controls.Add(Me.txtPreparedBy)
        Me.RadPanel1.Controls.Add(Me.RadLabel9)
        Me.RadPanel1.Controls.Add(Me.RadLabel8)
        Me.RadPanel1.Controls.Add(Me.RadLabel7)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.dtpImplemDate)
        Me.RadPanel1.Controls.Add(Me.dtpRevDate)
        Me.RadPanel1.Controls.Add(Me.dtpEstDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.txtRefNo)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.txtDocuNo)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.txtTitle)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(920, 177)
        Me.RadPanel1.TabIndex = 3
        Me.RadPanel1.ThemeName = "MaterialTeal"
        '
        'txtApprovedBy
        '
        Me.txtApprovedBy.Location = New System.Drawing.Point(581, 64)
        Me.txtApprovedBy.Name = "txtApprovedBy"
        Me.txtApprovedBy.Size = New System.Drawing.Size(317, 20)
        Me.txtApprovedBy.TabIndex = 8
        '
        'txtCheckedBy
        '
        Me.txtCheckedBy.Location = New System.Drawing.Point(581, 38)
        Me.txtCheckedBy.Name = "txtCheckedBy"
        Me.txtCheckedBy.Size = New System.Drawing.Size(317, 20)
        Me.txtCheckedBy.TabIndex = 7
        '
        'txtPreparedBy
        '
        Me.txtPreparedBy.Location = New System.Drawing.Point(581, 12)
        Me.txtPreparedBy.Name = "txtPreparedBy"
        Me.txtPreparedBy.Size = New System.Drawing.Size(317, 20)
        Me.txtPreparedBy.TabIndex = 6
        '
        'RadLabel9
        '
        Me.RadLabel9.Location = New System.Drawing.Point(502, 66)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel9.TabIndex = 17
        Me.RadLabel9.Text = "Approved By:"
        '
        'RadLabel8
        '
        Me.RadLabel8.Location = New System.Drawing.Point(508, 40)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(67, 18)
        Me.RadLabel8.TabIndex = 16
        Me.RadLabel8.Text = "Checked By:"
        '
        'RadLabel7
        '
        Me.RadLabel7.Location = New System.Drawing.Point(506, 14)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(69, 18)
        Me.RadLabel7.TabIndex = 15
        Me.RadLabel7.Text = "Prepared By:"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(21, 144)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(115, 18)
        Me.RadLabel6.TabIndex = 11
        Me.RadLabel6.Text = "Implementation Date:"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(63, 118)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel5.TabIndex = 10
        Me.RadLabel5.Text = "Revised Date:"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(45, 92)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(91, 18)
        Me.RadLabel4.TabIndex = 9
        Me.RadLabel4.Text = "Established Date:"
        '
        'dtpImplemDate
        '
        Me.dtpImplemDate.Location = New System.Drawing.Point(142, 142)
        Me.dtpImplemDate.Name = "dtpImplemDate"
        Me.dtpImplemDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpImplemDate.TabIndex = 5
        Me.dtpImplemDate.TabStop = False
        Me.dtpImplemDate.Text = "Tuesday, April 30, 2019"
        Me.dtpImplemDate.Value = New Date(2019, 4, 30, 8, 24, 24, 877)
        '
        'dtpRevDate
        '
        Me.dtpRevDate.Location = New System.Drawing.Point(142, 116)
        Me.dtpRevDate.Name = "dtpRevDate"
        Me.dtpRevDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpRevDate.TabIndex = 4
        Me.dtpRevDate.TabStop = False
        Me.dtpRevDate.Text = "Tuesday, April 30, 2019"
        Me.dtpRevDate.Value = New Date(2019, 4, 30, 8, 24, 24, 877)
        '
        'dtpEstDate
        '
        Me.dtpEstDate.Location = New System.Drawing.Point(142, 90)
        Me.dtpEstDate.Name = "dtpEstDate"
        Me.dtpEstDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpEstDate.TabIndex = 3
        Me.dtpEstDate.TabStop = False
        Me.dtpEstDate.Text = "Tuesday, April 30, 2019"
        Me.dtpEstDate.Value = New Date(2019, 4, 30, 8, 24, 24, 877)
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(57, 66)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(79, 18)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Reference No.:"
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(142, 64)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(164, 20)
        Me.txtRefNo.TabIndex = 2
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(55, 40)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(81, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Document No.:"
        '
        'txtDocuNo
        '
        Me.txtDocuNo.Location = New System.Drawing.Point(142, 38)
        Me.txtDocuNo.Name = "txtDocuNo"
        Me.txtDocuNo.Size = New System.Drawing.Size(164, 20)
        Me.txtDocuNo.TabIndex = 1
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(106, 14)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(142, 12)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(317, 20)
        Me.txtTitle.TabIndex = 0
        '
        'bwLoadData
        '
        '
        'frmBOMProvider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 537)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Name = "frmBOMProvider"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item BOM"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtApprovedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPreparedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpImplemDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRevDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEstDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocuNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTitle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbOpen As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRefNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDocuNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpImplemDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpRevDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpEstDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtApprovedBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCheckedBy As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPreparedBy As Telerik.WinControls.UI.RadTextBox
End Class

