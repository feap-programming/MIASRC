<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditActual
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditActual))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.ddCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblCurrency = New Telerik.WinControls.UI.RadLabel()
        Me.numQuantity = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblQuantity = New Telerik.WinControls.UI.RadLabel()
        Me.numUnitPrice = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblUnitPrice = New Telerik.WinControls.UI.RadLabel()
        Me.lblModel = New Telerik.WinControls.UI.RadLabel()
        Me.txtModel = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtInvoiceNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPartNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.lblInvoiceNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.lblPartNo = New Telerik.WinControls.UI.RadLabel()
        Me.dtATACustomer = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATACustomer = New Telerik.WinControls.UI.RadLabel()
        Me.dtATDManila = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATDManila = New Telerik.WinControls.UI.RadLabel()
        Me.lblETDManila = New Telerik.WinControls.UI.RadLabel()
        Me.dtATDFEAP = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtETDManila = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtETDFEAP = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATDFEAP = New Telerik.WinControls.UI.RadLabel()
        Me.lblETDFEAP = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.ddCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.ddCurrency)
        Me.panel.Controls.Add(Me.lblCurrency)
        Me.panel.Controls.Add(Me.numQuantity)
        Me.panel.Controls.Add(Me.lblQuantity)
        Me.panel.Controls.Add(Me.numUnitPrice)
        Me.panel.Controls.Add(Me.lblUnitPrice)
        Me.panel.Controls.Add(Me.lblModel)
        Me.panel.Controls.Add(Me.txtModel)
        Me.panel.Controls.Add(Me.txtPartName)
        Me.panel.Controls.Add(Me.txtInvoiceNo)
        Me.panel.Controls.Add(Me.txtPartNo)
        Me.panel.Controls.Add(Me.txtCustomer)
        Me.panel.Controls.Add(Me.lblPartName)
        Me.panel.Controls.Add(Me.lblInvoiceNo)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.lblPartNo)
        Me.panel.Controls.Add(Me.dtATACustomer)
        Me.panel.Controls.Add(Me.lblATACustomer)
        Me.panel.Controls.Add(Me.dtATDManila)
        Me.panel.Controls.Add(Me.lblATDManila)
        Me.panel.Controls.Add(Me.lblETDManila)
        Me.panel.Controls.Add(Me.dtATDFEAP)
        Me.panel.Controls.Add(Me.dtETDManila)
        Me.panel.Controls.Add(Me.dtETDFEAP)
        Me.panel.Controls.Add(Me.lblATDFEAP)
        Me.panel.Controls.Add(Me.lblETDFEAP)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(442, 235)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
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
        Me.ddCurrency.Location = New System.Drawing.Point(300, 142)
        Me.ddCurrency.Name = "ddCurrency"
        Me.ddCurrency.Size = New System.Drawing.Size(120, 20)
        Me.ddCurrency.TabIndex = 12
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrency.Location = New System.Drawing.Point(243, 144)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(51, 18)
        Me.lblCurrency.TabIndex = 0
        Me.lblCurrency.Text = "Currency"
        '
        'numQuantity
        '
        Me.numQuantity.DecimalPlaces = 4
        Me.numQuantity.Location = New System.Drawing.Point(300, 168)
        Me.numQuantity.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.ShowUpDownButtons = False
        Me.numQuantity.Size = New System.Drawing.Size(120, 20)
        Me.numQuantity.TabIndex = 13
        Me.numQuantity.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(245, 170)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 18)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Quantity"
        '
        'numUnitPrice
        '
        Me.numUnitPrice.DecimalPlaces = 4
        Me.numUnitPrice.Location = New System.Drawing.Point(300, 116)
        Me.numUnitPrice.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numUnitPrice.Name = "numUnitPrice"
        Me.numUnitPrice.ShowUpDownButtons = False
        Me.numUnitPrice.Size = New System.Drawing.Size(120, 20)
        Me.numUnitPrice.TabIndex = 11
        Me.numUnitPrice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPrice.Location = New System.Drawing.Point(227, 121)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(67, 15)
        Me.lblUnitPrice.TabIndex = 0
        Me.lblUnitPrice.Text = "Unit Price (JPY)"
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(256, 13)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(38, 18)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model"
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(300, 12)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(120, 20)
        Me.txtModel.TabIndex = 8
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(300, 64)
        Me.txtPartName.Multiline = True
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        '
        '
        '
        Me.txtPartName.RootElement.StretchVertically = True
        Me.txtPartName.Size = New System.Drawing.Size(120, 46)
        Me.txtPartName.TabIndex = 10
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Enabled = False
        Me.txtInvoiceNo.Location = New System.Drawing.Point(100, 12)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(120, 20)
        Me.txtInvoiceNo.TabIndex = 1
        '
        'txtPartNo
        '
        Me.txtPartNo.Enabled = False
        Me.txtPartNo.Location = New System.Drawing.Point(300, 38)
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.ReadOnly = True
        Me.txtPartNo.Size = New System.Drawing.Size(120, 20)
        Me.txtPartNo.TabIndex = 9
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(100, 168)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(120, 20)
        Me.txtCustomer.TabIndex = 7
        '
        'lblPartName
        '
        Me.lblPartName.Location = New System.Drawing.Point(235, 66)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(59, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "Part Name"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvoiceNo.Location = New System.Drawing.Point(34, 14)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(60, 18)
        Me.lblInvoiceNo.TabIndex = 0
        Me.lblInvoiceNo.Text = "Invoice No"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(39, 170)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'lblPartNo
        '
        Me.lblPartNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPartNo.Location = New System.Drawing.Point(250, 40)
        Me.lblPartNo.Name = "lblPartNo"
        Me.lblPartNo.Size = New System.Drawing.Size(44, 18)
        Me.lblPartNo.TabIndex = 0
        Me.lblPartNo.Text = "Part No"
        '
        'dtATACustomer
        '
        Me.dtATACustomer.CustomFormat = "MMM dd, yyyy"
        Me.dtATACustomer.Enabled = False
        Me.dtATACustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATACustomer.Location = New System.Drawing.Point(100, 142)
        Me.dtATACustomer.Name = "dtATACustomer"
        Me.dtATACustomer.Size = New System.Drawing.Size(120, 20)
        Me.dtATACustomer.TabIndex = 6
        Me.dtATACustomer.TabStop = False
        Me.dtATACustomer.Text = "Aug 25, 2020"
        Me.dtATACustomer.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblATACustomer
        '
        Me.lblATACustomer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATACustomer.Location = New System.Drawing.Point(16, 143)
        Me.lblATACustomer.Name = "lblATACustomer"
        Me.lblATACustomer.Size = New System.Drawing.Size(78, 18)
        Me.lblATACustomer.TabIndex = 0
        Me.lblATACustomer.Text = "ATA Customer"
        '
        'dtATDManila
        '
        Me.dtATDManila.CustomFormat = "MMM dd, yyyy"
        Me.dtATDManila.Enabled = False
        Me.dtATDManila.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATDManila.Location = New System.Drawing.Point(100, 116)
        Me.dtATDManila.Name = "dtATDManila"
        Me.dtATDManila.Size = New System.Drawing.Size(120, 20)
        Me.dtATDManila.TabIndex = 5
        Me.dtATDManila.TabStop = False
        Me.dtATDManila.Text = "Aug 25, 2020"
        Me.dtATDManila.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblATDManila
        '
        Me.lblATDManila.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATDManila.Location = New System.Drawing.Point(40, 118)
        Me.lblATDManila.Name = "lblATDManila"
        Me.lblATDManila.Size = New System.Drawing.Size(54, 18)
        Me.lblATDManila.TabIndex = 0
        Me.lblATDManila.Text = "ATD MNL"
        '
        'lblETDManila
        '
        Me.lblETDManila.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDManila.Location = New System.Drawing.Point(41, 66)
        Me.lblETDManila.Name = "lblETDManila"
        Me.lblETDManila.Size = New System.Drawing.Size(53, 18)
        Me.lblETDManila.TabIndex = 0
        Me.lblETDManila.Text = "ETD MNL"
        '
        'dtATDFEAP
        '
        Me.dtATDFEAP.CustomFormat = "MMM dd, yyyy"
        Me.dtATDFEAP.Enabled = False
        Me.dtATDFEAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATDFEAP.Location = New System.Drawing.Point(100, 90)
        Me.dtATDFEAP.Name = "dtATDFEAP"
        Me.dtATDFEAP.Size = New System.Drawing.Size(120, 20)
        Me.dtATDFEAP.TabIndex = 4
        Me.dtATDFEAP.TabStop = False
        Me.dtATDFEAP.Text = "Aug 25, 2020"
        Me.dtATDFEAP.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtETDManila
        '
        Me.dtETDManila.CustomFormat = "MMM dd, yyyy"
        Me.dtETDManila.Enabled = False
        Me.dtETDManila.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETDManila.Location = New System.Drawing.Point(100, 64)
        Me.dtETDManila.Name = "dtETDManila"
        Me.dtETDManila.Size = New System.Drawing.Size(120, 20)
        Me.dtETDManila.TabIndex = 3
        Me.dtETDManila.TabStop = False
        Me.dtETDManila.Text = "Aug 25, 2020"
        Me.dtETDManila.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtETDFEAP
        '
        Me.dtETDFEAP.CustomFormat = "MMM dd, yyyy"
        Me.dtETDFEAP.Enabled = False
        Me.dtETDFEAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETDFEAP.Location = New System.Drawing.Point(100, 38)
        Me.dtETDFEAP.Name = "dtETDFEAP"
        Me.dtETDFEAP.Size = New System.Drawing.Size(120, 20)
        Me.dtETDFEAP.TabIndex = 2
        Me.dtETDFEAP.TabStop = False
        Me.dtETDFEAP.Text = "Aug 25, 2020"
        Me.dtETDFEAP.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblATDFEAP
        '
        Me.lblATDFEAP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATDFEAP.Location = New System.Drawing.Point(39, 92)
        Me.lblATDFEAP.Name = "lblATDFEAP"
        Me.lblATDFEAP.Size = New System.Drawing.Size(55, 18)
        Me.lblATDFEAP.TabIndex = 0
        Me.lblATDFEAP.Text = "ATD FEAP"
        '
        'lblETDFEAP
        '
        Me.lblETDFEAP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDFEAP.Location = New System.Drawing.Point(40, 40)
        Me.lblETDFEAP.Name = "lblETDFEAP"
        Me.lblETDFEAP.Size = New System.Drawing.Size(54, 18)
        Me.lblETDFEAP.TabIndex = 0
        Me.lblETDFEAP.Text = "ETD FEAP"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(300, 194)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 24)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        '
        'FrmEditActual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 235)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditActual"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Actual"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.ddCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblETDManila As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATDFEAP As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtETDManila As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtETDFEAP As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATDFEAP As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETDFEAP As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblPartNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATDManila As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATDManila As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numQuantity As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblQuantity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numUnitPrice As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblUnitPrice As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblModel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtModel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblCurrency As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtInvoiceNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblInvoiceNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATACustomer As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATACustomer As Telerik.WinControls.UI.RadLabel
End Class

