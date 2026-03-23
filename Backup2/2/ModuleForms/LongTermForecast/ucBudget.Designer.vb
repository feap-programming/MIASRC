<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucBudget
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBudget))
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.lblFGModel = New Telerik.WinControls.UI.RadLabel()
        Me.txtDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.txtFGModel = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlModel = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.seBudgetDec = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudgetSep = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudgetJun = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudgetMar = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudgetNov = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudgetAug = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudgetMay = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudgetFeb = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblBudgetDec = New Telerik.WinControls.UI.RadLabel()
        Me.lblBudgetSep = New Telerik.WinControls.UI.RadLabel()
        Me.lblBudgetJun = New Telerik.WinControls.UI.RadLabel()
        Me.lblBudgetMar = New Telerik.WinControls.UI.RadLabel()
        Me.seBudgetOct = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblBudgetNov = New Telerik.WinControls.UI.RadLabel()
        Me.seBudgetJul = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblBudgetAug = New Telerik.WinControls.UI.RadLabel()
        Me.seBudgetApr = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblBudgetMay = New Telerik.WinControls.UI.RadLabel()
        Me.lblBudgetOct = New Telerik.WinControls.UI.RadLabel()
        Me.seBudgetJan = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblBudgetJul = New Telerik.WinControls.UI.RadLabel()
        Me.lblBudgeFeb = New Telerik.WinControls.UI.RadLabel()
        Me.lblBudgetApr = New Telerik.WinControls.UI.RadLabel()
        Me.lblDescription = New Telerik.WinControls.UI.RadLabel()
        Me.lblBudgetJan = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.lblModel = New Telerik.WinControls.UI.RadLabel()
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
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.cmActionChooser = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.miCopy = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEdit = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.miHistory = New Telerik.WinControls.UI.RadMenuItem()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbImportData = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbReport = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFGModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFGModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlModel.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetDec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetSep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetJun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetMar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetNov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetAug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetMay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetFeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetDec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetSep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetJun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetMar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetOct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetNov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetJul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetAug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetApr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetMay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetOct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudgetJan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetJul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgeFeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetApr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudgetJan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.numYear)
        Me.RadPanel1.Controls.Add(Me.lblYear)
        Me.RadPanel1.Controls.Add(Me.lblFGModel)
        Me.RadPanel1.Controls.Add(Me.txtDescription)
        Me.RadPanel1.Controls.Add(Me.txtFGModel)
        Me.RadPanel1.Controls.Add(Me.txtCustomer)
        Me.RadPanel1.Controls.Add(Me.ddlModel)
        Me.RadPanel1.Controls.Add(Me.seBudgetDec)
        Me.RadPanel1.Controls.Add(Me.seBudgetSep)
        Me.RadPanel1.Controls.Add(Me.seBudgetJun)
        Me.RadPanel1.Controls.Add(Me.seBudgetMar)
        Me.RadPanel1.Controls.Add(Me.seBudgetNov)
        Me.RadPanel1.Controls.Add(Me.seBudgetAug)
        Me.RadPanel1.Controls.Add(Me.seBudgetMay)
        Me.RadPanel1.Controls.Add(Me.seBudgetFeb)
        Me.RadPanel1.Controls.Add(Me.lblBudgetDec)
        Me.RadPanel1.Controls.Add(Me.lblBudgetSep)
        Me.RadPanel1.Controls.Add(Me.lblBudgetJun)
        Me.RadPanel1.Controls.Add(Me.lblBudgetMar)
        Me.RadPanel1.Controls.Add(Me.seBudgetOct)
        Me.RadPanel1.Controls.Add(Me.lblBudgetNov)
        Me.RadPanel1.Controls.Add(Me.seBudgetJul)
        Me.RadPanel1.Controls.Add(Me.lblBudgetAug)
        Me.RadPanel1.Controls.Add(Me.seBudgetApr)
        Me.RadPanel1.Controls.Add(Me.lblBudgetMay)
        Me.RadPanel1.Controls.Add(Me.lblBudgetOct)
        Me.RadPanel1.Controls.Add(Me.seBudgetJan)
        Me.RadPanel1.Controls.Add(Me.lblBudgetJul)
        Me.RadPanel1.Controls.Add(Me.lblBudgeFeb)
        Me.RadPanel1.Controls.Add(Me.lblBudgetApr)
        Me.RadPanel1.Controls.Add(Me.lblDescription)
        Me.RadPanel1.Controls.Add(Me.lblBudgetJan)
        Me.RadPanel1.Controls.Add(Me.lblCustomer)
        Me.RadPanel1.Controls.Add(Me.lblModel)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(990, 92)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'numYear
        '
        Me.numYear.Location = New System.Drawing.Point(67, 6)
        Me.numYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numYear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.NullableValue = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.numYear.ShowUpDownButtons = False
        Me.numYear.Size = New System.Drawing.Size(110, 20)
        Me.numYear.TabIndex = 1
        Me.numYear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numYear.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(33, 8)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(28, 18)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year"
        '
        'lblFGModel
        '
        Me.lblFGModel.Location = New System.Drawing.Point(23, 60)
        Me.lblFGModel.Name = "lblFGModel"
        Me.lblFGModel.Size = New System.Drawing.Size(38, 18)
        Me.lblFGModel.TabIndex = 0
        Me.lblFGModel.Text = "Model"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(257, 5)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        '
        '
        '
        Me.txtDescription.RootElement.StretchVertically = True
        Me.txtDescription.Size = New System.Drawing.Size(110, 47)
        Me.txtDescription.TabIndex = 4
        '
        'txtFGModel
        '
        Me.txtFGModel.Enabled = False
        Me.txtFGModel.Location = New System.Drawing.Point(67, 58)
        Me.txtFGModel.Name = "txtFGModel"
        Me.txtFGModel.ReadOnly = True
        Me.txtFGModel.Size = New System.Drawing.Size(110, 20)
        Me.txtFGModel.TabIndex = 3
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(257, 58)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(110, 20)
        Me.txtCustomer.TabIndex = 4
        '
        'ddlModel
        '
        '
        'ddlModel.NestedRadGridView
        '
        Me.ddlModel.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlModel.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlModel.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlModel.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlModel.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlModel.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlModel.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlModel.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlModel.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlModel.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.ddlModel.EditorControl.Name = "NestedRadGridView"
        Me.ddlModel.EditorControl.ReadOnly = True
        Me.ddlModel.EditorControl.ShowGroupPanel = False
        Me.ddlModel.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlModel.EditorControl.TabIndex = 0
        Me.ddlModel.Location = New System.Drawing.Point(67, 32)
        Me.ddlModel.Name = "ddlModel"
        Me.ddlModel.Size = New System.Drawing.Size(110, 20)
        Me.ddlModel.TabIndex = 2
        Me.ddlModel.TabStop = False
        '
        'seBudgetDec
        '
        Me.seBudgetDec.DecimalPlaces = 4
        Me.seBudgetDec.Location = New System.Drawing.Point(862, 58)
        Me.seBudgetDec.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetDec.Name = "seBudgetDec"
        Me.seBudgetDec.ShowUpDownButtons = False
        Me.seBudgetDec.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetDec.TabIndex = 17
        Me.seBudgetDec.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'seBudgetSep
        '
        Me.seBudgetSep.DecimalPlaces = 4
        Me.seBudgetSep.Location = New System.Drawing.Point(712, 58)
        Me.seBudgetSep.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetSep.Name = "seBudgetSep"
        Me.seBudgetSep.ShowUpDownButtons = False
        Me.seBudgetSep.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetSep.TabIndex = 14
        Me.seBudgetSep.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'seBudgetJun
        '
        Me.seBudgetJun.DecimalPlaces = 4
        Me.seBudgetJun.Location = New System.Drawing.Point(562, 58)
        Me.seBudgetJun.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetJun.Name = "seBudgetJun"
        Me.seBudgetJun.ShowUpDownButtons = False
        Me.seBudgetJun.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetJun.TabIndex = 11
        Me.seBudgetJun.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'seBudgetMar
        '
        Me.seBudgetMar.DecimalPlaces = 4
        Me.seBudgetMar.Location = New System.Drawing.Point(412, 58)
        Me.seBudgetMar.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetMar.Name = "seBudgetMar"
        Me.seBudgetMar.ShowUpDownButtons = False
        Me.seBudgetMar.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetMar.TabIndex = 8
        Me.seBudgetMar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'seBudgetNov
        '
        Me.seBudgetNov.DecimalPlaces = 4
        Me.seBudgetNov.Location = New System.Drawing.Point(862, 32)
        Me.seBudgetNov.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetNov.Name = "seBudgetNov"
        Me.seBudgetNov.ShowUpDownButtons = False
        Me.seBudgetNov.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetNov.TabIndex = 16
        Me.seBudgetNov.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'seBudgetAug
        '
        Me.seBudgetAug.DecimalPlaces = 4
        Me.seBudgetAug.Location = New System.Drawing.Point(712, 32)
        Me.seBudgetAug.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetAug.Name = "seBudgetAug"
        Me.seBudgetAug.ShowUpDownButtons = False
        Me.seBudgetAug.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetAug.TabIndex = 13
        Me.seBudgetAug.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'seBudgetMay
        '
        Me.seBudgetMay.DecimalPlaces = 4
        Me.seBudgetMay.Location = New System.Drawing.Point(562, 32)
        Me.seBudgetMay.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetMay.Name = "seBudgetMay"
        Me.seBudgetMay.ShowUpDownButtons = False
        Me.seBudgetMay.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetMay.TabIndex = 10
        Me.seBudgetMay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'seBudgetFeb
        '
        Me.seBudgetFeb.DecimalPlaces = 4
        Me.seBudgetFeb.Location = New System.Drawing.Point(412, 32)
        Me.seBudgetFeb.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetFeb.Name = "seBudgetFeb"
        Me.seBudgetFeb.ShowUpDownButtons = False
        Me.seBudgetFeb.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetFeb.TabIndex = 7
        Me.seBudgetFeb.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBudgetDec
        '
        Me.lblBudgetDec.Location = New System.Drawing.Point(831, 60)
        Me.lblBudgetDec.Name = "lblBudgetDec"
        Me.lblBudgetDec.Size = New System.Drawing.Size(25, 18)
        Me.lblBudgetDec.TabIndex = 0
        Me.lblBudgetDec.Text = "Dec"
        '
        'lblBudgetSep
        '
        Me.lblBudgetSep.Location = New System.Drawing.Point(681, 60)
        Me.lblBudgetSep.Name = "lblBudgetSep"
        Me.lblBudgetSep.Size = New System.Drawing.Size(25, 18)
        Me.lblBudgetSep.TabIndex = 0
        Me.lblBudgetSep.Text = "Sep"
        '
        'lblBudgetJun
        '
        Me.lblBudgetJun.Location = New System.Drawing.Point(533, 60)
        Me.lblBudgetJun.Name = "lblBudgetJun"
        Me.lblBudgetJun.Size = New System.Drawing.Size(23, 18)
        Me.lblBudgetJun.TabIndex = 0
        Me.lblBudgetJun.Text = "Jun"
        '
        'lblBudgetMar
        '
        Me.lblBudgetMar.Location = New System.Drawing.Point(380, 60)
        Me.lblBudgetMar.Name = "lblBudgetMar"
        Me.lblBudgetMar.Size = New System.Drawing.Size(26, 18)
        Me.lblBudgetMar.TabIndex = 0
        Me.lblBudgetMar.Text = "Mar"
        '
        'seBudgetOct
        '
        Me.seBudgetOct.DecimalPlaces = 4
        Me.seBudgetOct.Location = New System.Drawing.Point(862, 6)
        Me.seBudgetOct.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetOct.Name = "seBudgetOct"
        Me.seBudgetOct.ShowUpDownButtons = False
        Me.seBudgetOct.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetOct.TabIndex = 15
        Me.seBudgetOct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBudgetNov
        '
        Me.lblBudgetNov.Location = New System.Drawing.Point(829, 34)
        Me.lblBudgetNov.Name = "lblBudgetNov"
        Me.lblBudgetNov.Size = New System.Drawing.Size(27, 18)
        Me.lblBudgetNov.TabIndex = 0
        Me.lblBudgetNov.Text = "Nov"
        '
        'seBudgetJul
        '
        Me.seBudgetJul.DecimalPlaces = 4
        Me.seBudgetJul.Location = New System.Drawing.Point(712, 6)
        Me.seBudgetJul.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetJul.Name = "seBudgetJul"
        Me.seBudgetJul.ShowUpDownButtons = False
        Me.seBudgetJul.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetJul.TabIndex = 12
        Me.seBudgetJul.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBudgetAug
        '
        Me.lblBudgetAug.Location = New System.Drawing.Point(679, 34)
        Me.lblBudgetAug.Name = "lblBudgetAug"
        Me.lblBudgetAug.Size = New System.Drawing.Size(27, 18)
        Me.lblBudgetAug.TabIndex = 0
        Me.lblBudgetAug.Text = "Aug"
        '
        'seBudgetApr
        '
        Me.seBudgetApr.DecimalPlaces = 4
        Me.seBudgetApr.Location = New System.Drawing.Point(562, 6)
        Me.seBudgetApr.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetApr.Name = "seBudgetApr"
        Me.seBudgetApr.ShowUpDownButtons = False
        Me.seBudgetApr.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetApr.TabIndex = 9
        Me.seBudgetApr.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBudgetMay
        '
        Me.lblBudgetMay.Location = New System.Drawing.Point(528, 34)
        Me.lblBudgetMay.Name = "lblBudgetMay"
        Me.lblBudgetMay.Size = New System.Drawing.Size(28, 18)
        Me.lblBudgetMay.TabIndex = 0
        Me.lblBudgetMay.Text = "May"
        '
        'lblBudgetOct
        '
        Me.lblBudgetOct.Location = New System.Drawing.Point(832, 8)
        Me.lblBudgetOct.Name = "lblBudgetOct"
        Me.lblBudgetOct.Size = New System.Drawing.Size(24, 18)
        Me.lblBudgetOct.TabIndex = 0
        Me.lblBudgetOct.Text = "Oct"
        '
        'seBudgetJan
        '
        Me.seBudgetJan.DecimalPlaces = 4
        Me.seBudgetJan.Location = New System.Drawing.Point(412, 6)
        Me.seBudgetJan.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudgetJan.Name = "seBudgetJan"
        Me.seBudgetJan.ShowUpDownButtons = False
        Me.seBudgetJan.Size = New System.Drawing.Size(100, 20)
        Me.seBudgetJan.TabIndex = 6
        Me.seBudgetJan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBudgetJul
        '
        Me.lblBudgetJul.Location = New System.Drawing.Point(687, 8)
        Me.lblBudgetJul.Name = "lblBudgetJul"
        Me.lblBudgetJul.Size = New System.Drawing.Size(19, 18)
        Me.lblBudgetJul.TabIndex = 0
        Me.lblBudgetJul.Text = "Jul"
        '
        'lblBudgeFeb
        '
        Me.lblBudgeFeb.Location = New System.Drawing.Point(382, 33)
        Me.lblBudgeFeb.Name = "lblBudgeFeb"
        Me.lblBudgeFeb.Size = New System.Drawing.Size(24, 18)
        Me.lblBudgeFeb.TabIndex = 0
        Me.lblBudgeFeb.Text = "Feb"
        '
        'lblBudgetApr
        '
        Me.lblBudgetApr.Location = New System.Drawing.Point(532, 8)
        Me.lblBudgetApr.Name = "lblBudgetApr"
        Me.lblBudgetApr.Size = New System.Drawing.Size(24, 18)
        Me.lblBudgetApr.TabIndex = 0
        Me.lblBudgetApr.Text = "Apr"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(192, 8)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(59, 18)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Part Name"
        '
        'lblBudgetJan
        '
        Me.lblBudgetJan.Location = New System.Drawing.Point(384, 8)
        Me.lblBudgetJan.Name = "lblBudgetJan"
        Me.lblBudgetJan.Size = New System.Drawing.Size(22, 18)
        Me.lblBudgetJan.TabIndex = 0
        Me.lblBudgetJan.Text = "Jan"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(196, 60)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'lblModel
        '
        Me.lblModel.BackColor = System.Drawing.Color.Transparent
        Me.lblModel.Location = New System.Drawing.Point(17, 34)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(44, 18)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Part No"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 561)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(990, 29)
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
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 92)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(990, 81)
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbImportData, Me.cbExport, Me.CommandBarSeparator3, Me.cbbReport, Me.CommandBarSeparator5, Me.cbddOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
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
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.UseCompatibleTextRendering = False
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator3.DisplayName = "Separator 3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator3.UseCompatibleTextRendering = False
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.DisplayName = "CommandBarSeparator5"
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
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
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(990, 388)
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
        'cmActionChooser
        '
        Me.cmActionChooser.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miCopy, Me.miEdit, Me.RadMenuSeparatorItem1, Me.miHistory})
        Me.cmActionChooser.ThemeName = "CrystalDark"
        '
        'miCopy
        '
        Me.miCopy.Name = "miCopy"
        Me.miCopy.Text = "Copy"
        '
        'miEdit
        '
        Me.miEdit.Name = "miEdit"
        Me.miEdit.Text = "Edit"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'miHistory
        '
        Me.miHistory.Name = "miHistory"
        Me.miHistory.Text = "History"
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
        'cbImportData
        '
        Me.cbImportData.AutoSize = False
        Me.cbImportData.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbImportData.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbImportData.DisplayName = "Import Data"
        Me.cbImportData.DrawText = True
        Me.cbImportData.Image = CType(resources.GetObject("cbImportData.Image"), System.Drawing.Image)
        Me.cbImportData.Name = "cbImportData"
        Me.cbImportData.Text = "Import Data"
        Me.cbImportData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbImportData.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbImportData.UseCompatibleTextRendering = False
        '
        'cbExport
        '
        Me.cbExport.AutoSize = False
        Me.cbExport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbExport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbExport.DisplayName = "Export Data"
        Me.cbExport.DrawText = True
        Me.cbExport.Image = CType(resources.GetObject("cbExport.Image"), System.Drawing.Image)
        Me.cbExport.Name = "cbExport"
        Me.cbExport.Text = "Export Data"
        Me.cbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbExport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbExport.UseCompatibleTextRendering = False
        '
        'cbbReport
        '
        Me.cbbReport.AutoSize = False
        Me.cbbReport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbReport.DisplayName = "CommandBarButton1"
        Me.cbbReport.DrawText = True
        Me.cbbReport.Image = CType(resources.GetObject("cbbReport.Image"), System.Drawing.Image)
        Me.cbbReport.Name = "cbbReport"
        Me.cbbReport.Text = "Report"
        Me.cbbReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ucBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "ucBudget"
        Me.Size = New System.Drawing.Size(990, 590)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFGModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFGModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlModel.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetDec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetSep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetJun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetMar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetNov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetAug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetMay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetFeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetDec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetSep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetJun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetMar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetOct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetNov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetJul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetAug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetApr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetMay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetOct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudgetJan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetJul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgeFeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetApr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudgetJan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblFGModel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDescription As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddlModel As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents seBudgetJan As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblDescription As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBudgetJan As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblModel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbImportData As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtFGModel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cmActionChooser As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents miEdit As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miHistory As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miCopy As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents seBudgetJun As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seBudgetMar As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seBudgetMay As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seBudgetFeb As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblBudgetJun As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBudgetMar As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seBudgetApr As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblBudgetMay As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBudgeFeb As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBudgetApr As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seBudgetSep As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seBudgetAug As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblBudgetSep As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seBudgetJul As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblBudgetAug As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBudgetJul As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seBudgetDec As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seBudgetNov As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblBudgetDec As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seBudgetOct As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblBudgetNov As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblBudgetOct As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbbReport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
End Class
