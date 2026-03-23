<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCACostTable
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.txtItemCode = New Telerik.WinControls.UI.RadTextBox()
        Me.lblItemCode = New Telerik.WinControls.UI.RadLabel()
        Me.txtCustomerPartNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.lblTitle = New Telerik.WinControls.UI.RadLabel()
        Me.gvData2 = New Telerik.WinControls.UI.RadGridView()
        Me.txtTitle = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtId = New Telerik.WinControls.UI.RadTextBox()
        Me.lblDateEffect = New Telerik.WinControls.UI.RadLabel()
        Me.txtDateEffect = New Telerik.WinControls.UI.RadTextBox()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.txtYear = New Telerik.WinControls.UI.RadTextBox()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.lblCustomerPartNo = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.mcbFormulaIndicator = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblFormulaIndicator = New Telerik.WinControls.UI.RadLabel()
        Me.lblGroup = New Telerik.WinControls.UI.RadLabel()
        Me.seGroup = New Telerik.WinControls.UI.RadSpinEditor()
        Me.btnConstructNow = New Telerik.WinControls.UI.RadButton()
        Me.btnOpenEditor = New Telerik.WinControls.UI.RadButton()
        Me.btnProcessingFeePreset = New Telerik.WinControls.UI.RadButton()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.lblSection = New Telerik.WinControls.UI.RadLabel()
        Me.lblProcess = New Telerik.WinControls.UI.RadLabel()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.ddSection = New Telerik.WinControls.UI.RadDropDownList()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData2.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomerPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFormulaIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFormulaIndicator.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFormulaIndicator.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFormulaIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConstructNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOpenEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnProcessingFeePreset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtItemCode.Location = New System.Drawing.Point(123, 38)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.ReadOnly = True
        Me.txtItemCode.Size = New System.Drawing.Size(296, 20)
        Me.txtItemCode.TabIndex = 2
        '
        'lblItemCode
        '
        Me.lblItemCode.Location = New System.Drawing.Point(56, 40)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(61, 18)
        Me.lblItemCode.TabIndex = 0
        Me.lblItemCode.Text = "Item Code:"
        '
        'txtCustomerPartNo
        '
        Me.txtCustomerPartNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCustomerPartNo.Location = New System.Drawing.Point(123, 92)
        Me.txtCustomerPartNo.Name = "txtCustomerPartNo"
        Me.txtCustomerPartNo.ReadOnly = True
        Me.txtCustomerPartNo.Size = New System.Drawing.Size(296, 20)
        Me.txtCustomerPartNo.TabIndex = 4
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.lblTitle)
        Me.RadPanel1.Controls.Add(Me.gvData2)
        Me.RadPanel1.Controls.Add(Me.txtTitle)
        Me.RadPanel1.Controls.Add(Me.lblPartName)
        Me.RadPanel1.Controls.Add(Me.txtPartName)
        Me.RadPanel1.Controls.Add(Me.txtId)
        Me.RadPanel1.Controls.Add(Me.lblDateEffect)
        Me.RadPanel1.Controls.Add(Me.txtDateEffect)
        Me.RadPanel1.Controls.Add(Me.lblYear)
        Me.RadPanel1.Controls.Add(Me.txtYear)
        Me.RadPanel1.Controls.Add(Me.lblCustomer)
        Me.RadPanel1.Controls.Add(Me.txtCustomer)
        Me.RadPanel1.Controls.Add(Me.lblCustomerPartNo)
        Me.RadPanel1.Controls.Add(Me.txtItemCode)
        Me.RadPanel1.Controls.Add(Me.lblItemCode)
        Me.RadPanel1.Controls.Add(Me.txtCustomerPartNo)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(733, 118)
        Me.RadPanel1.TabIndex = 0
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(87, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 18)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'gvData2
        '
        Me.gvData2.Location = New System.Drawing.Point(588, 91)
        '
        '
        '
        Me.gvData2.MasterTemplate.MultiSelect = True
        Me.gvData2.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData2.Name = "gvData2"
        Me.gvData2.Size = New System.Drawing.Size(31, 16)
        Me.gvData2.TabIndex = 10
        Me.gvData2.Visible = False
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(123, 12)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(296, 20)
        Me.txtTitle.TabIndex = 1
        '
        'lblPartName
        '
        Me.lblPartName.Location = New System.Drawing.Point(55, 67)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(62, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "Part Name:"
        '
        'txtPartName
        '
        Me.txtPartName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPartName.Location = New System.Drawing.Point(123, 65)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        Me.txtPartName.Size = New System.Drawing.Size(296, 20)
        Me.txtPartName.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(685, 91)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(24, 20)
        Me.txtId.TabIndex = 0
        Me.txtId.Visible = False
        '
        'lblDateEffect
        '
        Me.lblDateEffect.Location = New System.Drawing.Point(435, 67)
        Me.lblDateEffect.Name = "lblDateEffect"
        Me.lblDateEffect.Size = New System.Drawing.Size(63, 18)
        Me.lblDateEffect.TabIndex = 0
        Me.lblDateEffect.Text = "Date Effect:"
        '
        'txtDateEffect
        '
        Me.txtDateEffect.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDateEffect.Location = New System.Drawing.Point(504, 65)
        Me.txtDateEffect.Name = "txtDateEffect"
        Me.txtDateEffect.ReadOnly = True
        Me.txtDateEffect.Size = New System.Drawing.Size(205, 20)
        Me.txtDateEffect.TabIndex = 7
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(467, 40)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(31, 18)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year:"
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtYear.Location = New System.Drawing.Point(504, 39)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(205, 20)
        Me.txtYear.TabIndex = 6
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(441, 14)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(57, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer:"
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCustomer.Location = New System.Drawing.Point(504, 12)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(205, 20)
        Me.txtCustomer.TabIndex = 5
        '
        'lblCustomerPartNo
        '
        Me.lblCustomerPartNo.Location = New System.Drawing.Point(16, 94)
        Me.lblCustomerPartNo.Name = "lblCustomerPartNo"
        Me.lblCustomerPartNo.Size = New System.Drawing.Size(101, 18)
        Me.lblCustomerPartNo.TabIndex = 0
        Me.lblCustomerPartNo.Text = "Customer Part No.:"
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.Silver
        Me.RadPanel2.Controls.Add(Me.RadGridView1)
        Me.RadPanel2.Controls.Add(Me.mcbFormulaIndicator)
        Me.RadPanel2.Controls.Add(Me.lblFormulaIndicator)
        Me.RadPanel2.Controls.Add(Me.lblGroup)
        Me.RadPanel2.Controls.Add(Me.seGroup)
        Me.RadPanel2.Controls.Add(Me.btnConstructNow)
        Me.RadPanel2.Controls.Add(Me.btnOpenEditor)
        Me.RadPanel2.Controls.Add(Me.btnProcessingFeePreset)
        Me.RadPanel2.Controls.Add(Me.btnAdd)
        Me.RadPanel2.Controls.Add(Me.lblSection)
        Me.RadPanel2.Controls.Add(Me.lblProcess)
        Me.RadPanel2.Controls.Add(Me.gvData)
        Me.RadPanel2.Controls.Add(Me.RadStatusStrip1)
        Me.RadPanel2.Controls.Add(Me.ddSection)
        Me.RadPanel2.Controls.Add(Me.mcbProcess)
        Me.RadPanel2.Location = New System.Drawing.Point(12, 124)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(709, 450)
        Me.RadPanel2.TabIndex = 1
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(24, 132)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.MultiSelect = True
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(38, 26)
        Me.RadGridView1.TabIndex = 16
        Me.RadGridView1.Visible = False
        '
        'mcbFormulaIndicator
        '
        Me.mcbFormulaIndicator.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        '
        'mcbFormulaIndicator.NestedRadGridView
        '
        Me.mcbFormulaIndicator.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbFormulaIndicator.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbFormulaIndicator.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbFormulaIndicator.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbFormulaIndicator.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbFormulaIndicator.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbFormulaIndicator.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbFormulaIndicator.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbFormulaIndicator.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbFormulaIndicator.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbFormulaIndicator.EditorControl.Name = "NestedRadGridView"
        Me.mcbFormulaIndicator.EditorControl.ReadOnly = True
        Me.mcbFormulaIndicator.EditorControl.ShowGroupPanel = False
        Me.mcbFormulaIndicator.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbFormulaIndicator.EditorControl.TabIndex = 0
        Me.mcbFormulaIndicator.Location = New System.Drawing.Point(111, 65)
        Me.mcbFormulaIndicator.Name = "mcbFormulaIndicator"
        Me.mcbFormulaIndicator.Size = New System.Drawing.Size(319, 20)
        Me.mcbFormulaIndicator.TabIndex = 15
        Me.mcbFormulaIndicator.TabStop = False
        Me.mcbFormulaIndicator.Visible = False
        '
        'lblFormulaIndicator
        '
        Me.lblFormulaIndicator.Location = New System.Drawing.Point(8, 67)
        Me.lblFormulaIndicator.Name = "lblFormulaIndicator"
        Me.lblFormulaIndicator.Size = New System.Drawing.Size(97, 18)
        Me.lblFormulaIndicator.TabIndex = 14
        Me.lblFormulaIndicator.Text = "Formula Indicator:"
        Me.lblFormulaIndicator.Visible = False
        '
        'lblGroup
        '
        Me.lblGroup.Location = New System.Drawing.Point(65, 93)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(40, 18)
        Me.lblGroup.TabIndex = 12
        Me.lblGroup.Text = "Group:"
        Me.lblGroup.Visible = False
        '
        'seGroup
        '
        Me.seGroup.Location = New System.Drawing.Point(111, 91)
        Me.seGroup.Name = "seGroup"
        Me.seGroup.ShowUpDownButtons = False
        Me.seGroup.Size = New System.Drawing.Size(84, 20)
        Me.seGroup.TabIndex = 11
        Me.seGroup.Visible = False
        '
        'btnConstructNow
        '
        Me.btnConstructNow.Location = New System.Drawing.Point(533, 15)
        Me.btnConstructNow.Name = "btnConstructNow"
        Me.btnConstructNow.Size = New System.Drawing.Size(131, 24)
        Me.btnConstructNow.TabIndex = 9
        Me.btnConstructNow.Text = "Construct Now"
        '
        'btnOpenEditor
        '
        Me.btnOpenEditor.Location = New System.Drawing.Point(533, 45)
        Me.btnOpenEditor.Name = "btnOpenEditor"
        Me.btnOpenEditor.Size = New System.Drawing.Size(131, 24)
        Me.btnOpenEditor.TabIndex = 5
        Me.btnOpenEditor.Text = "Open Editor"
        '
        'btnProcessingFeePreset
        '
        Me.btnProcessingFeePreset.Location = New System.Drawing.Point(533, 75)
        Me.btnProcessingFeePreset.Name = "btnProcessingFeePreset"
        Me.btnProcessingFeePreset.Size = New System.Drawing.Size(131, 24)
        Me.btnProcessingFeePreset.TabIndex = 6
        Me.btnProcessingFeePreset.Text = "Processing Fee Preset"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(111, 117)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 24)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        '
        'lblSection
        '
        Me.lblSection.Location = New System.Drawing.Point(60, 41)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(45, 18)
        Me.lblSection.TabIndex = 0
        Me.lblSection.Text = "Section:"
        '
        'lblProcess
        '
        Me.lblProcess.Location = New System.Drawing.Point(59, 15)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(46, 18)
        Me.lblProcess.TabIndex = 0
        Me.lblProcess.Text = "Process:"
        '
        'gvData
        '
        Me.gvData.Location = New System.Drawing.Point(12, 164)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(685, 254)
        Me.gvData.TabIndex = 7
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(709, 26)
        Me.RadStatusStrip1.TabIndex = 8
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
        'ddSection
        '
        Me.ddSection.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "1"
        RadListDataItem2.Text = "2"
        RadListDataItem3.Text = "3"
        Me.ddSection.Items.Add(RadListDataItem1)
        Me.ddSection.Items.Add(RadListDataItem2)
        Me.ddSection.Items.Add(RadListDataItem3)
        Me.ddSection.Location = New System.Drawing.Point(111, 39)
        Me.ddSection.Name = "ddSection"
        Me.ddSection.Size = New System.Drawing.Size(84, 20)
        Me.ddSection.TabIndex = 2
        '
        'mcbProcess
        '
        '
        'mcbProcess.NestedRadGridView
        '
        Me.mcbProcess.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbProcess.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbProcess.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbProcess.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbProcess.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbProcess.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbProcess.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbProcess.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbProcess.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbProcess.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.mcbProcess.EditorControl.Name = "NestedRadGridView"
        Me.mcbProcess.EditorControl.ReadOnly = True
        Me.mcbProcess.EditorControl.ShowGroupPanel = False
        Me.mcbProcess.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbProcess.EditorControl.TabIndex = 0
        Me.mcbProcess.Location = New System.Drawing.Point(111, 13)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.Size = New System.Drawing.Size(319, 20)
        Me.mcbProcess.TabIndex = 1
        Me.mcbProcess.TabStop = False
        '
        'bwLoadData
        '
        '
        'FrmCACostTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 586)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(741, 616)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(741, 616)
        Me.Name = "FrmCACostTable"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(741, 616)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Construct Cost Table"
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData2.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateEffect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateEffect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomerPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        Me.RadPanel2.PerformLayout()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFormulaIndicator.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFormulaIndicator.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFormulaIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFormulaIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConstructNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOpenEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnProcessingFeePreset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtItemCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblItemCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCustomerPartNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblCustomerPartNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDateEffect As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtYear As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblDateEffect As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents ddSection As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblSection As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblProcess As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnProcessingFeePreset As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtId As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtTitle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblTitle As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnOpenEditor As Telerik.WinControls.UI.RadButton
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnConstructNow As Telerik.WinControls.UI.RadButton
    Friend WithEvents gvData2 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents lblGroup As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seGroup As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents mcbFormulaIndicator As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblFormulaIndicator As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class

