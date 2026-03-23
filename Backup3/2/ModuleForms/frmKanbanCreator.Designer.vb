<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKanbanCreator
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKanbanCreator))
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartition = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.txtSRCLine = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.txtLocation = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbCustomerPartNo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbUOM = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.ddKanbanType = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnChangePhoto = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.seStdQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.seOrderingPoint = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.seMaxQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbLine = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAddRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDeleteRecord = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbddViewKanban = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miIMWithdrawal = New Telerik.WinControls.UI.RadMenuItem()
        Me.miIMMachineIssuance = New Telerik.WinControls.UI.RadMenuItem()
        Me.miFG = New Telerik.WinControls.UI.RadMenuItem()
        Me.miFGRegular = New Telerik.WinControls.UI.RadMenuItem()
        Me.miFGSpecial = New Telerik.WinControls.UI.RadMenuItem()
        Me.miFGFFC = New Telerik.WinControls.UI.RadMenuItem()
        Me.miFGExport = New Telerik.WinControls.UI.RadMenuItem()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.miShowPhoto = New Telerik.WinControls.UI.RadMenuItem()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bwDelete = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSRCLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomerPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomerPartNo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomerPartNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbUOM.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbUOM.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddKanbanType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnChangePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seStdQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seOrderingPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seMaxQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbLine.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbLine.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.RadLabel13)
        Me.RadPanel1.Controls.Add(Me.txtPartition)
        Me.RadPanel1.Controls.Add(Me.RadLabel12)
        Me.RadPanel1.Controls.Add(Me.txtSRCLine)
        Me.RadPanel1.Controls.Add(Me.RadLabel11)
        Me.RadPanel1.Controls.Add(Me.txtLocation)
        Me.RadPanel1.Controls.Add(Me.RadLabel10)
        Me.RadPanel1.Controls.Add(Me.txtCustomer)
        Me.RadPanel1.Controls.Add(Me.RadLabel9)
        Me.RadPanel1.Controls.Add(Me.mcbCustomerPartNo)
        Me.RadPanel1.Controls.Add(Me.mcbUOM)
        Me.RadPanel1.Controls.Add(Me.RadLabel8)
        Me.RadPanel1.Controls.Add(Me.ddKanbanType)
        Me.RadPanel1.Controls.Add(Me.btnChangePhoto)
        Me.RadPanel1.Controls.Add(Me.PictureBox1)
        Me.RadPanel1.Controls.Add(Me.RadLabel7)
        Me.RadPanel1.Controls.Add(Me.seStdQty)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.seOrderingPoint)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.seMaxQty)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.txtPartName)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.mcbLine)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.mcbItemCode)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(963, 197)
        Me.RadPanel1.TabIndex = 0
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadLabel13
        '
        Me.RadLabel13.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel13.Location = New System.Drawing.Point(478, 143)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(125, 18)
        Me.RadLabel13.TabIndex = 45
        Me.RadLabel13.Text = "Partition / Machine No.:"
        '
        'txtPartition
        '
        Me.txtPartition.Location = New System.Drawing.Point(609, 140)
        Me.txtPartition.Name = "txtPartition"
        Me.txtPartition.Size = New System.Drawing.Size(202, 20)
        Me.txtPartition.TabIndex = 12
        '
        'RadLabel12
        '
        Me.RadLabel12.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel12.Location = New System.Drawing.Point(499, 116)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(104, 18)
        Me.RadLabel12.TabIndex = 43
        Me.RadLabel12.Text = "SRC Line / FFC Line:"
        '
        'txtSRCLine
        '
        Me.txtSRCLine.Location = New System.Drawing.Point(609, 114)
        Me.txtSRCLine.Name = "txtSRCLine"
        Me.txtSRCLine.Size = New System.Drawing.Size(202, 20)
        Me.txtSRCLine.TabIndex = 11
        '
        'RadLabel11
        '
        Me.RadLabel11.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel11.Location = New System.Drawing.Point(552, 90)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel11.TabIndex = 41
        Me.RadLabel11.Text = "Location:"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(609, 88)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(202, 20)
        Me.txtLocation.TabIndex = 10
        '
        'RadLabel10
        '
        Me.RadLabel10.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel10.Location = New System.Drawing.Point(96, 117)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel10.TabIndex = 39
        Me.RadLabel10.Text = "Customer:"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(159, 114)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(156, 20)
        Me.txtCustomer.TabIndex = 4
        '
        'RadLabel9
        '
        Me.RadLabel9.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel9.Location = New System.Drawing.Point(52, 65)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(101, 18)
        Me.RadLabel9.TabIndex = 37
        Me.RadLabel9.Text = "Customer Part No.:"
        '
        'mcbCustomerPartNo
        '
        '
        'mcbCustomerPartNo.NestedRadGridView
        '
        Me.mcbCustomerPartNo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbCustomerPartNo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbCustomerPartNo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbCustomerPartNo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbCustomerPartNo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbCustomerPartNo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbCustomerPartNo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbCustomerPartNo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbCustomerPartNo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbCustomerPartNo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbCustomerPartNo.EditorControl.Name = "NestedRadGridView"
        Me.mcbCustomerPartNo.EditorControl.ReadOnly = True
        Me.mcbCustomerPartNo.EditorControl.ShowGroupPanel = False
        Me.mcbCustomerPartNo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbCustomerPartNo.EditorControl.TabIndex = 0
        Me.mcbCustomerPartNo.Location = New System.Drawing.Point(159, 63)
        Me.mcbCustomerPartNo.Name = "mcbCustomerPartNo"
        Me.mcbCustomerPartNo.Size = New System.Drawing.Size(156, 20)
        Me.mcbCustomerPartNo.TabIndex = 2
        Me.mcbCustomerPartNo.TabStop = False
        '
        'mcbUOM
        '
        '
        'mcbUOM.NestedRadGridView
        '
        Me.mcbUOM.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbUOM.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbUOM.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbUOM.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbUOM.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbUOM.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbUOM.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbUOM.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbUOM.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbUOM.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbUOM.EditorControl.Name = "NestedRadGridView"
        Me.mcbUOM.EditorControl.ReadOnly = True
        Me.mcbUOM.EditorControl.ShowGroupPanel = False
        Me.mcbUOM.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbUOM.EditorControl.TabIndex = 0
        Me.mcbUOM.Location = New System.Drawing.Point(609, 39)
        Me.mcbUOM.Name = "mcbUOM"
        Me.mcbUOM.Size = New System.Drawing.Size(100, 20)
        Me.mcbUOM.TabIndex = 8
        Me.mcbUOM.TabStop = False
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Location = New System.Drawing.Point(80, 14)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel8.TabIndex = 35
        Me.RadLabel8.Text = "Kanban Type:"
        '
        'ddKanbanType
        '
        Me.ddKanbanType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "IM WITHDRAWAL"
        RadListDataItem2.Text = "IM MACHINE ISSUANCE"
        RadListDataItem3.Text = "FG"
        Me.ddKanbanType.Items.Add(RadListDataItem1)
        Me.ddKanbanType.Items.Add(RadListDataItem2)
        Me.ddKanbanType.Items.Add(RadListDataItem3)
        Me.ddKanbanType.Location = New System.Drawing.Point(159, 13)
        Me.ddKanbanType.Name = "ddKanbanType"
        Me.ddKanbanType.Size = New System.Drawing.Size(156, 20)
        Me.ddKanbanType.TabIndex = 0
        '
        'btnChangePhoto
        '
        Me.btnChangePhoto.Location = New System.Drawing.Point(830, 129)
        Me.btnChangePhoto.Name = "btnChangePhoto"
        Me.btnChangePhoto.Size = New System.Drawing.Size(110, 24)
        Me.btnChangePhoto.TabIndex = 8
        Me.btnChangePhoto.Text = "Change Photo"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(830, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'RadLabel7
        '
        Me.RadLabel7.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel7.Location = New System.Drawing.Point(514, 65)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(89, 18)
        Me.RadLabel7.TabIndex = 31
        Me.RadLabel7.Text = "Std Qty. Per Box:"
        '
        'seStdQty
        '
        Me.seStdQty.DecimalPlaces = 2
        Me.seStdQty.Location = New System.Drawing.Point(609, 64)
        Me.seStdQty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seStdQty.Name = "seStdQty"
        Me.seStdQty.ShowUpDownButtons = False
        Me.seStdQty.Size = New System.Drawing.Size(100, 20)
        Me.seStdQty.TabIndex = 9
        Me.seStdQty.ThousandsSeparator = True
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Location = New System.Drawing.Point(568, 41)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(35, 18)
        Me.RadLabel6.TabIndex = 29
        Me.RadLabel6.Text = "UOM:"
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Location = New System.Drawing.Point(520, 16)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(83, 18)
        Me.RadLabel5.TabIndex = 27
        Me.RadLabel5.Text = "Ordering Point:"
        '
        'seOrderingPoint
        '
        Me.seOrderingPoint.DecimalPlaces = 2
        Me.seOrderingPoint.Location = New System.Drawing.Point(609, 14)
        Me.seOrderingPoint.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seOrderingPoint.Name = "seOrderingPoint"
        Me.seOrderingPoint.ShowUpDownButtons = False
        Me.seOrderingPoint.Size = New System.Drawing.Size(100, 20)
        Me.seOrderingPoint.TabIndex = 7
        Me.seOrderingPoint.ThousandsSeparator = True
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Location = New System.Drawing.Point(2, 167)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(151, 18)
        Me.RadLabel4.TabIndex = 25
        Me.RadLabel4.Text = "Maximum Capacity Per Hour:"
        '
        'seMaxQty
        '
        Me.seMaxQty.DecimalPlaces = 2
        Me.seMaxQty.Location = New System.Drawing.Point(159, 165)
        Me.seMaxQty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seMaxQty.Name = "seMaxQty"
        Me.seMaxQty.ShowUpDownButtons = False
        Me.seMaxQty.Size = New System.Drawing.Size(156, 20)
        Me.seMaxQty.TabIndex = 6
        Me.seMaxQty.ThousandsSeparator = True
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(91, 89)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(62, 18)
        Me.RadLabel3.TabIndex = 23
        Me.RadLabel3.Text = "Part Name:"
        '
        'txtPartName
        '
        Me.txtPartName.Location = New System.Drawing.Point(159, 88)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        Me.txtPartName.Size = New System.Drawing.Size(301, 20)
        Me.txtPartName.TabIndex = 3
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(124, 142)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(29, 18)
        Me.RadLabel1.TabIndex = 21
        Me.RadLabel1.Text = "Line:"
        '
        'mcbLine
        '
        '
        'mcbLine.NestedRadGridView
        '
        Me.mcbLine.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbLine.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbLine.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbLine.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbLine.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbLine.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbLine.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbLine.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbLine.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbLine.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbLine.EditorControl.Name = "NestedRadGridView"
        Me.mcbLine.EditorControl.ReadOnly = True
        Me.mcbLine.EditorControl.ShowGroupPanel = False
        Me.mcbLine.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbLine.EditorControl.TabIndex = 0
        Me.mcbLine.Location = New System.Drawing.Point(159, 140)
        Me.mcbLine.Name = "mcbLine"
        Me.mcbLine.Size = New System.Drawing.Size(156, 20)
        Me.mcbLine.TabIndex = 5
        Me.mcbLine.TabStop = False
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(92, 40)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel2.TabIndex = 19
        Me.RadLabel2.Text = "Item Code:"
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(159, 38)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(156, 20)
        Me.mcbItemCode.TabIndex = 1
        Me.mcbItemCode.TabStop = False
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 585)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(963, 26)
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
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 18)
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
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 197)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(963, 56)
        Me.RadCommandBar1.TabIndex = 2
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAddRecord, Me.cbbDeleteRecord, Me.CommandBarSeparator5, Me.cbddViewKanban, Me.CommandBarSeparator2, Me.cbbExport, Me.CommandBarSeparator3, Me.cbbOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        '
        'cbbRefresh
        '
        Me.cbbRefresh.AutoSize = False
        Me.cbbRefresh.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
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
        'cbbAddRecord
        '
        Me.cbbAddRecord.AutoSize = False
        Me.cbbAddRecord.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbAddRecord.DisplayName = "Add Record"
        Me.cbbAddRecord.DrawText = True
        Me.cbbAddRecord.Image = CType(resources.GetObject("cbbAddRecord.Image"), System.Drawing.Image)
        Me.cbbAddRecord.Name = "cbbAddRecord"
        Me.cbbAddRecord.Text = "Add Record"
        Me.cbbAddRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbDeleteRecord
        '
        Me.cbbDeleteRecord.AutoSize = False
        Me.cbbDeleteRecord.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbDeleteRecord.DisplayName = "Delete Record"
        Me.cbbDeleteRecord.DrawText = True
        Me.cbbDeleteRecord.Image = CType(resources.GetObject("cbbDeleteRecord.Image"), System.Drawing.Image)
        Me.cbbDeleteRecord.Name = "cbbDeleteRecord"
        Me.cbbDeleteRecord.Text = "Delete Record"
        Me.cbbDeleteRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.DisplayName = "CommandBarSeparator5"
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'cbddViewKanban
        '
        Me.cbddViewKanban.DisplayName = "View kanban"
        Me.cbddViewKanban.DrawText = True
        Me.cbddViewKanban.Image = CType(resources.GetObject("cbddViewKanban.Image"), System.Drawing.Image)
        Me.cbddViewKanban.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miIMWithdrawal, Me.miIMMachineIssuance, Me.miFG})
        Me.cbddViewKanban.Name = "cbddViewKanban"
        Me.cbddViewKanban.Text = "View Kanban"
        Me.cbddViewKanban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miIMWithdrawal
        '
        Me.miIMWithdrawal.Name = "miIMWithdrawal"
        Me.miIMWithdrawal.Text = "IM WITHDRAWAL KANBAN"
        '
        'miIMMachineIssuance
        '
        Me.miIMMachineIssuance.Name = "miIMMachineIssuance"
        Me.miIMMachineIssuance.Text = "IM MACHINE ISSUANCE"
        '
        'miFG
        '
        Me.miFG.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miFGRegular, Me.miFGSpecial, Me.miFGFFC, Me.miFGExport})
        Me.miFG.Name = "miFG"
        Me.miFG.Text = "FG"
        '
        'miFGRegular
        '
        Me.miFGRegular.Name = "miFGRegular"
        Me.miFGRegular.Text = "REGULAR"
        '
        'miFGSpecial
        '
        Me.miFGSpecial.Name = "miFGSpecial"
        Me.miFGSpecial.Text = "SPECIAL"
        '
        'miFGFFC
        '
        Me.miFGFFC.Name = "miFGFFC"
        Me.miFGFFC.Text = "FFC"
        '
        'miFGExport
        '
        Me.miFGExport.Name = "miFGExport"
        Me.miFGExport.Text = "EXPORT"
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cbbExport
        '
        Me.cbbExport.AutoSize = False
        Me.cbbExport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbExport.DisplayName = "Export Data"
        Me.cbbExport.DrawText = True
        Me.cbbExport.Image = CType(resources.GetObject("cbbExport.Image"), System.Drawing.Image)
        Me.cbbExport.Name = "cbbExport"
        Me.cbbExport.Text = "Export Data"
        Me.cbbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisplayName = "Separator 3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'cbbOptions
        '
        Me.cbbOptions.AutoSize = False
        Me.cbbOptions.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbOptions.DisplayName = "Options"
        Me.cbbOptions.DrawText = True
        Me.cbbOptions.Image = CType(resources.GetObject("cbbOptions.Image"), System.Drawing.Image)
        Me.cbbOptions.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miEnableFiltering, Me.miEnableGrouping, Me.RadMenuSeparatorItem1, Me.miShowPhoto})
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
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'miShowPhoto
        '
        Me.miShowPhoto.CheckOnClick = True
        Me.miShowPhoto.Name = "miShowPhoto"
        Me.miShowPhoto.Text = "Show Photo"
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 253)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(963, 332)
        Me.gvData.TabIndex = 3
        '
        'bwLoadData
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'bwDelete
        '
        Me.bwDelete.WorkerReportsProgress = True
        '
        'FrmKanbanCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 611)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmKanbanCreator"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kanban Creator"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSRCLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomerPartNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomerPartNo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomerPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbUOM.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbUOM.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddKanbanType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnChangePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seStdQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seOrderingPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seMaxQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbLine.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbLine.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbLine As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAddRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDeleteRecord As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seOrderingPoint As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seMaxQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seStdQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents btnChangePhoto As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents ddKanbanType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents mcbUOM As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents miShowPhoto As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents bwDelete As System.ComponentModel.BackgroundWorker
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbddViewKanban As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents miIMWithdrawal As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miIMMachineIssuance As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbCustomerPartNo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartition As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSRCLine As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtLocation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents miFG As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miFGRegular As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miFGSpecial As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miFGFFC As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miFGExport As Telerik.WinControls.UI.RadMenuItem
End Class

