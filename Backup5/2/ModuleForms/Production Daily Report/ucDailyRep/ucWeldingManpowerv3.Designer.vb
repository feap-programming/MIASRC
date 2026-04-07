<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWeldingManpowerv3
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWeldingManpowerv3))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.CrystalTheme1 = New Telerik.WinControls.Themes.CrystalTheme()
        Me.CrystalTheme2 = New Telerik.WinControls.Themes.CrystalTheme()
        Me.CrystalTheme3 = New Telerik.WinControls.Themes.CrystalTheme()
        Me.RadScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.gvTimePartition = New Telerik.WinControls.UI.RadGridView()
        Me.gvEmpStatus = New Telerik.WinControls.UI.RadGridView()
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.ddType = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblType = New System.Windows.Forms.Label()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbSave = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClear = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbTemplate = New Telerik.WinControls.UI.CommandBarButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTo = New Telerik.WinControls.UI.RadLabel()
        Me.spnPlanDT = New Telerik.WinControls.UI.RadSpinEditor()
        Me.spnHotto = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.spnUnplanDT = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.spnOPTime = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.spnPersons = New Telerik.WinControls.UI.RadSpinEditor()
        Me.tbTimePart = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.btnEdit = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOpTime = New System.Windows.Forms.Label()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.gvPartNames = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadScrollablePanel1.PanelContainer.SuspendLayout()
        Me.RadScrollablePanel1.SuspendLayout()
        CType(Me.gvTimePartition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTimePartition.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEmpStatus.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gvEmpStatus.SuspendLayout()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnPlanDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHotto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnUnplanDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnOPTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnPersons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTimePart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.gvPartNames, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPartNames.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadScrollablePanel1
        '
        Me.RadScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScrollablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadScrollablePanel1.Name = "RadScrollablePanel1"
        '
        'RadScrollablePanel1.PanelContainer
        '
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.gvTimePartition)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.RadPanel1)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.gvEmpStatus)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.RadPanel3)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.RadCommandBar1)
        Me.RadScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(1110, 948)
        Me.RadScrollablePanel1.Size = New System.Drawing.Size(1112, 950)
        Me.RadScrollablePanel1.TabIndex = 0
        Me.RadScrollablePanel1.ThemeName = "CrystalDark"
        '
        'gvTimePartition
        '
        Me.gvTimePartition.Dock = System.Windows.Forms.DockStyle.Top
        Me.gvTimePartition.Location = New System.Drawing.Point(0, 624)
        '
        '
        '
        Me.gvTimePartition.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gvTimePartition.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvTimePartition.Name = "gvTimePartition"
        Me.gvTimePartition.Size = New System.Drawing.Size(1110, 218)
        Me.gvTimePartition.TabIndex = 25
        Me.gvTimePartition.ThemeName = "CrystalDark"
        '
        'gvEmpStatus
        '
        Me.gvEmpStatus.Controls.Add(Me.pbMain)
        Me.gvEmpStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.gvEmpStatus.Location = New System.Drawing.Point(0, 100)
        '
        '
        '
        Me.gvEmpStatus.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gvEmpStatus.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gvEmpStatus.Name = "gvEmpStatus"
        Me.gvEmpStatus.Size = New System.Drawing.Size(1110, 202)
        Me.gvEmpStatus.TabIndex = 24
        Me.gvEmpStatus.ThemeName = "CrystalDark"
        '
        'pbMain
        '
        Me.pbMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMain.Image = CType(resources.GetObject("pbMain.Image"), System.Drawing.Image)
        Me.pbMain.Location = New System.Drawing.Point(3, 6)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(35, 29)
        Me.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMain.TabIndex = 99
        Me.pbMain.TabStop = False
        Me.pbMain.Visible = False
        '
        'RadPanel3
        '
        Me.RadPanel3.Controls.Add(Me.ddType)
        Me.RadPanel3.Controls.Add(Me.lblType)
        Me.RadPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel3.Location = New System.Drawing.Point(0, 58)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(1110, 42)
        Me.RadPanel3.TabIndex = 23
        Me.RadPanel3.ThemeName = "CrystalDark"
        '
        'ddType
        '
        Me.ddType.Location = New System.Drawing.Point(35, 15)
        Me.ddType.Name = "ddType"
        Me.ddType.Size = New System.Drawing.Size(125, 20)
        Me.ddType.TabIndex = 19
        Me.ddType.Text = "RadDropDownList1"
        Me.ddType.ThemeName = "Office2007Black"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(6, 19)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(33, 17)
        Me.lblType.TabIndex = 18
        Me.lblType.Text = "PW-"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1110, 58)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.ThemeName = "CrystalDark"
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbSave, Me.cbbClear, Me.cbbTemplate})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'cbbSave
        '
        Me.cbbSave.AutoSize = False
        Me.cbbSave.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.cbbSave.BorderBottomWidth = 1.0!
        Me.cbbSave.Bounds = New System.Drawing.Rectangle(0, 0, 99, 52)
        Me.cbbSave.ClipText = False
        Me.cbbSave.DisplayName = "SAVE"
        Me.cbbSave.DrawText = True
        Me.cbbSave.Image = CType(resources.GetObject("cbbSave.Image"), System.Drawing.Image)
        Me.cbbSave.Name = "cbbSave"
        Me.cbbSave.Text = "Save"
        Me.cbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbSave.UseCompatibleTextRendering = False
        '
        'cbbClear
        '
        Me.cbbClear.DisplayName = "CommandBarButton2"
        Me.cbbClear.DrawText = True
        Me.cbbClear.Image = CType(resources.GetObject("cbbClear.Image"), System.Drawing.Image)
        Me.cbbClear.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.cbbClear.Name = "cbbClear"
        Me.cbbClear.Text = "Clear Input"
        Me.cbbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbTemplate
        '
        Me.cbbTemplate.DisplayName = "CommandBarButton3"
        Me.cbbTemplate.DrawText = True
        Me.cbbTemplate.Image = CType(resources.GetObject("cbbTemplate.Image"), System.Drawing.Image)
        Me.cbbTemplate.Name = "cbbTemplate"
        Me.cbbTemplate.Text = "Template"
        Me.cbbTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BackgroundWorker1
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.Controls.Add(Me.RadLabel5)
        Me.Panel3.Controls.Add(Me.lblOpTime)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.RadLabel4)
        Me.Panel3.Controls.Add(Me.tbTimePart)
        Me.Panel3.Controls.Add(Me.spnPersons)
        Me.Panel3.Controls.Add(Me.RadLabel3)
        Me.Panel3.Controls.Add(Me.spnOPTime)
        Me.Panel3.Controls.Add(Me.RadLabel2)
        Me.Panel3.Controls.Add(Me.spnUnplanDT)
        Me.Panel3.Controls.Add(Me.RadLabel1)
        Me.Panel3.Controls.Add(Me.spnHotto)
        Me.Panel3.Controls.Add(Me.spnPlanDT)
        Me.Panel3.Controls.Add(Me.lblTo)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(514, 322)
        Me.Panel3.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Interruption Time:"
        '
        'lblTo
        '
        Me.lblTo.ForeColor = System.Drawing.Color.White
        Me.lblTo.Location = New System.Drawing.Point(51, 61)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(103, 18)
        Me.lblTo.TabIndex = 90
        Me.lblTo.Text = "Planned Downtime:"
        '
        'spnPlanDT
        '
        Me.spnPlanDT.DecimalPlaces = 2
        Me.spnPlanDT.Location = New System.Drawing.Point(166, 61)
        Me.spnPlanDT.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnPlanDT.Name = "spnPlanDT"
        Me.spnPlanDT.ReadOnly = True
        Me.spnPlanDT.Size = New System.Drawing.Size(146, 20)
        Me.spnPlanDT.TabIndex = 88
        Me.spnPlanDT.ThemeName = "Office2007Black"
        CType(Me.spnPlanDT.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'spnHotto
        '
        Me.spnHotto.DecimalPlaces = 2
        Me.spnHotto.Location = New System.Drawing.Point(166, 31)
        Me.spnHotto.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnHotto.Name = "spnHotto"
        Me.spnHotto.Size = New System.Drawing.Size(146, 20)
        Me.spnHotto.TabIndex = 89
        Me.spnHotto.ThemeName = "Office2007Black"
        CType(Me.spnHotto.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel1
        '
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(32, 91)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(122, 18)
        Me.RadLabel1.TabIndex = 92
        Me.RadLabel1.Text = "Un-planned Downtime:"
        '
        'spnUnplanDT
        '
        Me.spnUnplanDT.DecimalPlaces = 2
        Me.spnUnplanDT.Location = New System.Drawing.Point(166, 91)
        Me.spnUnplanDT.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnUnplanDT.Name = "spnUnplanDT"
        Me.spnUnplanDT.ReadOnly = True
        Me.spnUnplanDT.Size = New System.Drawing.Size(146, 20)
        Me.spnUnplanDT.TabIndex = 91
        Me.spnUnplanDT.ThemeName = "Office2007Black"
        CType(Me.spnUnplanDT.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel2
        '
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(9, 132)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(116, 18)
        Me.RadLabel2.TabIndex = 94
        Me.RadLabel2.Text = "Operation Time (Min):"
        '
        'spnOPTime
        '
        Me.spnOPTime.DecimalPlaces = 2
        Me.spnOPTime.Enabled = False
        Me.spnOPTime.Location = New System.Drawing.Point(136, 131)
        Me.spnOPTime.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnOPTime.Name = "spnOPTime"
        Me.spnOPTime.Size = New System.Drawing.Size(176, 20)
        Me.spnOPTime.TabIndex = 93
        Me.spnOPTime.ThemeName = "Office2007Black"
        CType(Me.spnOPTime.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel3
        '
        Me.RadLabel3.ForeColor = System.Drawing.Color.White
        Me.RadLabel3.Location = New System.Drawing.Point(9, 162)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(118, 18)
        Me.RadLabel3.TabIndex = 96
        Me.RadLabel3.Text = "No. of Persons (w/ TL):"
        '
        'spnPersons
        '
        Me.spnPersons.DecimalPlaces = 2
        Me.spnPersons.Location = New System.Drawing.Point(136, 161)
        Me.spnPersons.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnPersons.Name = "spnPersons"
        Me.spnPersons.Size = New System.Drawing.Size(176, 20)
        Me.spnPersons.TabIndex = 95
        Me.spnPersons.ThemeName = "Office2007Black"
        CType(Me.spnPersons.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'tbTimePart
        '
        Me.tbTimePart.Enabled = False
        Me.tbTimePart.Location = New System.Drawing.Point(136, 189)
        Me.tbTimePart.Name = "tbTimePart"
        Me.tbTimePart.Size = New System.Drawing.Size(145, 20)
        Me.tbTimePart.TabIndex = 97
        Me.tbTimePart.ThemeName = "Office2007Black"
        '
        'RadLabel4
        '
        Me.RadLabel4.ForeColor = System.Drawing.Color.White
        Me.RadLabel4.Location = New System.Drawing.Point(23, 190)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(102, 18)
        Me.RadLabel4.TabIndex = 98
        Me.RadLabel4.Text = "Line Time Partition:"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(287, 189)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(21, 19)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEdit.TabIndex = 100
        Me.btnEdit.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(227, 230)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 24)
        Me.btnAdd.TabIndex = 101
        Me.btnAdd.Text = "ADD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "TOTAL OP TIME"
        Me.Label1.Visible = False
        '
        'lblOpTime
        '
        Me.lblOpTime.AutoSize = True
        Me.lblOpTime.Location = New System.Drawing.Point(103, 230)
        Me.lblOpTime.Name = "lblOpTime"
        Me.lblOpTime.Size = New System.Drawing.Size(0, 17)
        Me.lblOpTime.TabIndex = 103
        '
        'RadLabel5
        '
        Me.RadLabel5.ForeColor = System.Drawing.Color.White
        Me.RadLabel5.Location = New System.Drawing.Point(25, 33)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(135, 18)
        Me.RadLabel5.TabIndex = 104
        Me.RadLabel5.Text = "Start up, 5's, Hotto, Break:"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.gvPartNames)
        Me.RadPanel1.Controls.Add(Me.Panel3)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 302)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1110, 322)
        Me.RadPanel1.TabIndex = 21
        Me.RadPanel1.ThemeName = "CrystalDark"
        '
        'gvPartNames
        '
        Me.gvPartNames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvPartNames.Location = New System.Drawing.Point(514, 0)
        '
        '
        '
        Me.gvPartNames.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvPartNames.Name = "gvPartNames"
        Me.gvPartNames.Size = New System.Drawing.Size(596, 322)
        Me.gvPartNames.TabIndex = 91
        Me.gvPartNames.ThemeName = "CrystalDark"
        '
        'ucWeldingManpowerv3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RadScrollablePanel1)
        Me.Name = "ucWeldingManpowerv3"
        Me.Size = New System.Drawing.Size(1112, 950)
        Me.RadScrollablePanel1.PanelContainer.ResumeLayout(False)
        Me.RadScrollablePanel1.PanelContainer.PerformLayout()
        CType(Me.RadScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel1.ResumeLayout(False)
        CType(Me.gvTimePartition.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTimePartition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmpStatus.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEmpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gvEmpStatus.ResumeLayout(False)
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        Me.RadPanel3.PerformLayout()
        CType(Me.ddType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnPlanDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHotto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnUnplanDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnOPTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnPersons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTimePart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.gvPartNames.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPartNames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents CrystalTheme1 As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents CrystalTheme2 As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents CrystalTheme3 As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents RadScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClear As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbTemplate As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents pbMain As PictureBox
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents ddType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblType As Label
    Friend WithEvents gvEmpStatus As Telerik.WinControls.UI.RadGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gvTimePartition As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblOpTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEdit As PictureBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbTimePart As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents spnPersons As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnOPTime As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnUnplanDT As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnHotto As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents spnPlanDT As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents gvPartNames As Telerik.WinControls.UI.RadGridView
End Class
