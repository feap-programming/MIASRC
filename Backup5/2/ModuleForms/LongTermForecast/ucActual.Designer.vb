<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucActual
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
        Me.components = New System.ComponentModel.Container()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucActual))
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.pnlForm = New Telerik.WinControls.UI.RadPanel()
        Me.ddCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.numQuantity = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblQuantity = New Telerik.WinControls.UI.RadLabel()
        Me.numUnitPrice = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblUnitPrice = New Telerik.WinControls.UI.RadLabel()
        Me.lblCurrency = New Telerik.WinControls.UI.RadLabel()
        Me.ddlPartNo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblPartNo = New Telerik.WinControls.UI.RadLabel()
        Me.dtATACustomer = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtATDManila = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATACustomer = New Telerik.WinControls.UI.RadLabel()
        Me.lblETDManila = New Telerik.WinControls.UI.RadLabel()
        Me.lblATDManila = New Telerik.WinControls.UI.RadLabel()
        Me.dtATDFEAP = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtETDManila = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtETDFEAP = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblModel = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtModel = New Telerik.WinControls.UI.RadTextBox()
        Me.txtInvoiceNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.lblATDFEAP = New Telerik.WinControls.UI.RadLabel()
        Me.lblInvoiceNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblETDFEAP = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbUpdate = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbUploaderTemplate = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbImportData = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbReport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.cmActionChooser = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.miCopy = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEdit = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.miHistory = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        CType(Me.ddCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlPartNo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlPartNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.Silver
        Me.pnlForm.Controls.Add(Me.ddCurrency)
        Me.pnlForm.Controls.Add(Me.numQuantity)
        Me.pnlForm.Controls.Add(Me.lblQuantity)
        Me.pnlForm.Controls.Add(Me.numUnitPrice)
        Me.pnlForm.Controls.Add(Me.lblUnitPrice)
        Me.pnlForm.Controls.Add(Me.lblCurrency)
        Me.pnlForm.Controls.Add(Me.ddlPartNo)
        Me.pnlForm.Controls.Add(Me.lblPartNo)
        Me.pnlForm.Controls.Add(Me.dtATACustomer)
        Me.pnlForm.Controls.Add(Me.dtATDManila)
        Me.pnlForm.Controls.Add(Me.lblATACustomer)
        Me.pnlForm.Controls.Add(Me.lblETDManila)
        Me.pnlForm.Controls.Add(Me.lblATDManila)
        Me.pnlForm.Controls.Add(Me.dtATDFEAP)
        Me.pnlForm.Controls.Add(Me.dtETDManila)
        Me.pnlForm.Controls.Add(Me.dtETDFEAP)
        Me.pnlForm.Controls.Add(Me.lblModel)
        Me.pnlForm.Controls.Add(Me.txtPartName)
        Me.pnlForm.Controls.Add(Me.txtModel)
        Me.pnlForm.Controls.Add(Me.txtInvoiceNo)
        Me.pnlForm.Controls.Add(Me.txtCustomer)
        Me.pnlForm.Controls.Add(Me.lblPartName)
        Me.pnlForm.Controls.Add(Me.lblATDFEAP)
        Me.pnlForm.Controls.Add(Me.lblInvoiceNo)
        Me.pnlForm.Controls.Add(Me.lblETDFEAP)
        Me.pnlForm.Controls.Add(Me.lblCustomer)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(990, 92)
        Me.pnlForm.TabIndex = 0
        Me.pnlForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'ddCurrency
        '
        Me.ddCurrency.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "PHP"
        RadListDataItem2.Text = "JPY"
        RadListDataItem3.Text = "USD"
        Me.ddCurrency.Items.Add(RadListDataItem1)
        Me.ddCurrency.Items.Add(RadListDataItem2)
        Me.ddCurrency.Items.Add(RadListDataItem3)
        Me.ddCurrency.Location = New System.Drawing.Point(851, 6)
        Me.ddCurrency.Name = "ddCurrency"
        Me.ddCurrency.Size = New System.Drawing.Size(109, 20)
        Me.ddCurrency.TabIndex = 12
        '
        'numQuantity
        '
        Me.numQuantity.DecimalPlaces = 4
        Me.numQuantity.Location = New System.Drawing.Point(851, 32)
        Me.numQuantity.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.ShowUpDownButtons = False
        Me.numQuantity.Size = New System.Drawing.Size(110, 20)
        Me.numQuantity.TabIndex = 13
        Me.numQuantity.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(796, 34)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 18)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Quantity"
        '
        'numUnitPrice
        '
        Me.numUnitPrice.DecimalPlaces = 4
        Me.numUnitPrice.Location = New System.Drawing.Point(661, 58)
        Me.numUnitPrice.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numUnitPrice.Name = "numUnitPrice"
        Me.numUnitPrice.ShowUpDownButtons = False
        Me.numUnitPrice.Size = New System.Drawing.Size(110, 20)
        Me.numUnitPrice.TabIndex = 11
        Me.numUnitPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPrice.Location = New System.Drawing.Point(601, 60)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(54, 18)
        Me.lblUnitPrice.TabIndex = 0
        Me.lblUnitPrice.Text = "Unit Price"
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrency.Location = New System.Drawing.Point(794, 8)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(51, 18)
        Me.lblCurrency.TabIndex = 0
        Me.lblCurrency.Text = "Currency"
        '
        'ddlPartNo
        '
        '
        'ddlPartNo.NestedRadGridView
        '
        Me.ddlPartNo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlPartNo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlPartNo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlPartNo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlPartNo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlPartNo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlPartNo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlPartNo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlPartNo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlPartNo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.ddlPartNo.EditorControl.Name = "NestedRadGridView"
        Me.ddlPartNo.EditorControl.ReadOnly = True
        Me.ddlPartNo.EditorControl.ShowGroupPanel = False
        Me.ddlPartNo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlPartNo.EditorControl.TabIndex = 0
        Me.ddlPartNo.Location = New System.Drawing.Point(471, 6)
        Me.ddlPartNo.Name = "ddlPartNo"
        Me.ddlPartNo.Size = New System.Drawing.Size(110, 20)
        Me.ddlPartNo.TabIndex = 7
        Me.ddlPartNo.TabStop = False
        '
        'lblPartNo
        '
        Me.lblPartNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPartNo.Location = New System.Drawing.Point(421, 8)
        Me.lblPartNo.Name = "lblPartNo"
        Me.lblPartNo.Size = New System.Drawing.Size(44, 18)
        Me.lblPartNo.TabIndex = 0
        Me.lblPartNo.Text = "Part No"
        '
        'dtATACustomer
        '
        Me.dtATACustomer.CustomFormat = "MMM dd, yyyy"
        Me.dtATACustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATACustomer.Location = New System.Drawing.Point(281, 58)
        Me.dtATACustomer.Name = "dtATACustomer"
        Me.dtATACustomer.Size = New System.Drawing.Size(110, 20)
        Me.dtATACustomer.TabIndex = 6
        Me.dtATACustomer.TabStop = False
        Me.dtATACustomer.Text = "Aug 25, 2020"
        Me.dtATACustomer.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtATDManila
        '
        Me.dtATDManila.CustomFormat = "MMM dd, yyyy"
        Me.dtATDManila.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATDManila.Location = New System.Drawing.Point(281, 32)
        Me.dtATDManila.Name = "dtATDManila"
        Me.dtATDManila.Size = New System.Drawing.Size(110, 20)
        Me.dtATDManila.TabIndex = 5
        Me.dtATDManila.TabStop = False
        Me.dtATDManila.Text = "Aug 25, 2020"
        Me.dtATDManila.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblATACustomer
        '
        Me.lblATACustomer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATACustomer.Location = New System.Drawing.Point(221, 60)
        Me.lblATACustomer.Name = "lblATACustomer"
        Me.lblATACustomer.Size = New System.Drawing.Size(54, 18)
        Me.lblATACustomer.TabIndex = 0
        Me.lblATACustomer.Text = "ATA Cust."
        '
        'lblETDManila
        '
        Me.lblETDManila.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDManila.Location = New System.Drawing.Point(32, 60)
        Me.lblETDManila.Name = "lblETDManila"
        Me.lblETDManila.Size = New System.Drawing.Size(53, 18)
        Me.lblETDManila.TabIndex = 0
        Me.lblETDManila.Text = "ETD MNL"
        '
        'lblATDManila
        '
        Me.lblATDManila.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATDManila.Location = New System.Drawing.Point(221, 34)
        Me.lblATDManila.Name = "lblATDManila"
        Me.lblATDManila.Size = New System.Drawing.Size(54, 18)
        Me.lblATDManila.TabIndex = 0
        Me.lblATDManila.Text = "ATD MNL"
        '
        'dtATDFEAP
        '
        Me.dtATDFEAP.CustomFormat = "MMM dd, yyyy"
        Me.dtATDFEAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATDFEAP.Location = New System.Drawing.Point(281, 6)
        Me.dtATDFEAP.Name = "dtATDFEAP"
        Me.dtATDFEAP.Size = New System.Drawing.Size(110, 20)
        Me.dtATDFEAP.TabIndex = 4
        Me.dtATDFEAP.TabStop = False
        Me.dtATDFEAP.Text = "Aug 25, 2020"
        Me.dtATDFEAP.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtETDManila
        '
        Me.dtETDManila.CustomFormat = "MMM dd, yyyy"
        Me.dtETDManila.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETDManila.Location = New System.Drawing.Point(91, 58)
        Me.dtETDManila.Name = "dtETDManila"
        Me.dtETDManila.Size = New System.Drawing.Size(110, 20)
        Me.dtETDManila.TabIndex = 3
        Me.dtETDManila.TabStop = False
        Me.dtETDManila.Text = "Aug 25, 2020"
        Me.dtETDManila.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtETDFEAP
        '
        Me.dtETDFEAP.CustomFormat = "MMM dd, yyyy"
        Me.dtETDFEAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETDFEAP.Location = New System.Drawing.Point(91, 32)
        Me.dtETDFEAP.Name = "dtETDFEAP"
        Me.dtETDFEAP.Size = New System.Drawing.Size(110, 20)
        Me.dtETDFEAP.TabIndex = 2
        Me.dtETDFEAP.TabStop = False
        Me.dtETDFEAP.Text = "Aug 25, 2020"
        Me.dtETDFEAP.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(427, 59)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(38, 18)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model"
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(661, 6)
        Me.txtPartName.Multiline = True
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        '
        '
        '
        Me.txtPartName.RootElement.StretchVertically = True
        Me.txtPartName.Size = New System.Drawing.Size(110, 46)
        Me.txtPartName.TabIndex = 10
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(471, 58)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(110, 20)
        Me.txtModel.TabIndex = 9
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(91, 6)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(110, 20)
        Me.txtInvoiceNo.TabIndex = 1
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(471, 32)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(110, 20)
        Me.txtCustomer.TabIndex = 8
        '
        'lblPartName
        '
        Me.lblPartName.Location = New System.Drawing.Point(596, 8)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(59, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "Part Name"
        '
        'lblATDFEAP
        '
        Me.lblATDFEAP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATDFEAP.Location = New System.Drawing.Point(220, 8)
        Me.lblATDFEAP.Name = "lblATDFEAP"
        Me.lblATDFEAP.Size = New System.Drawing.Size(55, 18)
        Me.lblATDFEAP.TabIndex = 0
        Me.lblATDFEAP.Text = "ATD FEAP"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Location = New System.Drawing.Point(25, 8)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(60, 18)
        Me.lblInvoiceNo.TabIndex = 0
        Me.lblInvoiceNo.Text = "Invoice No"
        '
        'lblETDFEAP
        '
        Me.lblETDFEAP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDFEAP.Location = New System.Drawing.Point(31, 34)
        Me.lblETDFEAP.Name = "lblETDFEAP"
        Me.lblETDFEAP.Size = New System.Drawing.Size(54, 18)
        Me.lblETDFEAP.TabIndex = 0
        Me.lblETDFEAP.Text = "ETD FEAP"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(410, 34)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbUpdate, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbUploaderTemplate, Me.cbImportData, Me.cbExport, Me.CommandBarSeparator5, Me.cbbReport, Me.CommandBarSeparator3, Me.cbddOptions})
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
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.DisplayName = "Separator 1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.UseCompatibleTextRendering = False
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
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
        'cbbUpdate
        '
        Me.cbbUpdate.AutoSize = False
        Me.cbbUpdate.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbUpdate.DisplayName = "CommandBarButton1"
        Me.cbbUpdate.DrawText = True
        Me.cbbUpdate.Image = CType(resources.GetObject("cbbUpdate.Image"), System.Drawing.Image)
        Me.cbbUpdate.Name = "cbbUpdate"
        Me.cbbUpdate.Text = "Update"
        Me.cbbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.UseCompatibleTextRendering = False
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cbUploaderTemplate
        '
        Me.cbUploaderTemplate.AutoSize = False
        Me.cbUploaderTemplate.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbUploaderTemplate.DisplayName = "CommandBarButton1"
        Me.cbUploaderTemplate.DrawText = True
        Me.cbUploaderTemplate.Image = CType(resources.GetObject("cbUploaderTemplate.Image"), System.Drawing.Image)
        Me.cbUploaderTemplate.Name = "cbUploaderTemplate"
        Me.cbUploaderTemplate.Text = "Template"
        Me.cbUploaderTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator5.DisplayName = "CommandBarSeparator5"
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator5.UseCompatibleTextRendering = False
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'cbbReport
        '
        Me.cbbReport.AutoSize = False
        Me.cbbReport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbReport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbReport.DisplayName = "CommandBarButton1"
        Me.cbbReport.DrawText = True
        Me.cbbReport.Image = CType(resources.GetObject("cbbReport.Image"), System.Drawing.Image)
        Me.cbbReport.Name = "cbbReport"
        Me.cbbReport.Text = "Report"
        Me.cbbReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbReport.UseCompatibleTextRendering = False
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
        Me.gvData.MasterTemplate.AllowDeleteRow = False
        Me.gvData.MasterTemplate.EnableFiltering = True
        Me.gvData.MasterTemplate.MultiSelect = True
        Me.gvData.MasterTemplate.ShowFilteringRow = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.ShowGroupPanel = False
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
        Me.miCopy.Image = Global.MIA.My.Resources.Resources.clipboard
        Me.miCopy.Name = "miCopy"
        Me.miCopy.Text = "Copy"
        Me.miCopy.UseCompatibleTextRendering = False
        '
        'miEdit
        '
        Me.miEdit.Image = Global.MIA.My.Resources.Resources.pencil
        Me.miEdit.Name = "miEdit"
        Me.miEdit.Text = "Edit"
        Me.miEdit.UseCompatibleTextRendering = False
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadMenuSeparatorItem1.UseCompatibleTextRendering = False
        '
        'miHistory
        '
        Me.miHistory.Image = Global.MIA.My.Resources.Resources.history
        Me.miHistory.Name = "miHistory"
        Me.miHistory.Text = "History"
        Me.miHistory.UseCompatibleTextRendering = False
        '
        'ucActual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlForm)
        Me.Name = "ucActual"
        Me.Size = New System.Drawing.Size(990, 590)
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.ddCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlPartNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlPartNo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlForm As Telerik.WinControls.UI.RadPanel
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
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbReport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents dtATDFEAP As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtETDFEAP As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblModel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtModel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblATDFEAP As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETDFEAP As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATDManila As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblETDManila As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblATDManila As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtETDManila As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents ddlPartNo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblPartNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numQuantity As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblQuantity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numUnitPrice As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblUnitPrice As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmActionChooser As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents miCopy As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEdit As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents miHistory As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents ddCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblCurrency As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATACustomer As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATACustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtInvoiceNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblInvoiceNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbbUpdate As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbUploaderTemplate As Telerik.WinControls.UI.CommandBarButton
End Class
