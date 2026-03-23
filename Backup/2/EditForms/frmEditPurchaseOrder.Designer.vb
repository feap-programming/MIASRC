<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditPurchaseOrder))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.dtDateReceived = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.seQuantity = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblQuantity = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.lblDateReceived = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.lblETACustomer = New Telerik.WinControls.UI.RadLabel()
        Me.dtETACustomer = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.ddModeOfShipment = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblModeOfShipment = New Telerik.WinControls.UI.RadLabel()
        Me.lblQtyPerBox = New Telerik.WinControls.UI.RadLabel()
        Me.numQtyPerBox = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblQtyPerPallet = New Telerik.WinControls.UI.RadLabel()
        Me.numQtyPerPallet = New Telerik.WinControls.UI.RadSpinEditor()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.dtDateReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddModeOfShipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModeOfShipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblQtyPerBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyPerBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblQtyPerPallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyPerPallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.ddModeOfShipment)
        Me.panel.Controls.Add(Me.lblModeOfShipment)
        Me.panel.Controls.Add(Me.dtETACustomer)
        Me.panel.Controls.Add(Me.dtDateReceived)
        Me.panel.Controls.Add(Me.txtCustomer)
        Me.panel.Controls.Add(Me.numQtyPerPallet)
        Me.panel.Controls.Add(Me.lblQtyPerPallet)
        Me.panel.Controls.Add(Me.numQtyPerBox)
        Me.panel.Controls.Add(Me.lblQtyPerBox)
        Me.panel.Controls.Add(Me.seQuantity)
        Me.panel.Controls.Add(Me.lblQuantity)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.txtPartName)
        Me.panel.Controls.Add(Me.lblETACustomer)
        Me.panel.Controls.Add(Me.lblPartName)
        Me.panel.Controls.Add(Me.lblDateReceived)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(239, 285)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'dtDateReceived
        '
        Me.dtDateReceived.CustomFormat = "MMM dd, yyyy"
        Me.dtDateReceived.Enabled = False
        Me.dtDateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateReceived.Location = New System.Drawing.Point(98, 12)
        Me.dtDateReceived.Name = "dtDateReceived"
        Me.dtDateReceived.Size = New System.Drawing.Size(120, 20)
        Me.dtDateReceived.TabIndex = 1
        Me.dtDateReceived.TabStop = False
        Me.dtDateReceived.Text = "Jan 19, 2022"
        Me.dtDateReceived.Value = New Date(2022, 1, 19, 9, 31, 45, 145)
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(98, 117)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(120, 20)
        Me.txtCustomer.TabIndex = 4
        '
        'seQuantity
        '
        Me.seQuantity.Location = New System.Drawing.Point(98, 221)
        Me.seQuantity.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seQuantity.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seQuantity.Name = "seQuantity"
        Me.seQuantity.ShowUpDownButtons = False
        Me.seQuantity.Size = New System.Drawing.Size(120, 20)
        Me.seQuantity.TabIndex = 8
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(43, 222)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 18)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Quantity"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(37, 120)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(98, 64)
        Me.txtPartName.Multiline = True
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        '
        '
        '
        Me.txtPartName.RootElement.StretchVertically = True
        Me.txtPartName.Size = New System.Drawing.Size(120, 47)
        Me.txtPartName.TabIndex = 3
        '
        'lblPartName
        '
        Me.lblPartName.Location = New System.Drawing.Point(33, 65)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(59, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "Part Name"
        '
        'lblDateReceived
        '
        Me.lblDateReceived.BackColor = System.Drawing.Color.Transparent
        Me.lblDateReceived.Location = New System.Drawing.Point(15, 13)
        Me.lblDateReceived.Name = "lblDateReceived"
        Me.lblDateReceived.Size = New System.Drawing.Size(77, 18)
        Me.lblDateReceived.TabIndex = 0
        Me.lblDateReceived.Text = "Date Received"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 247)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        '
        'lblETACustomer
        '
        Me.lblETACustomer.BackColor = System.Drawing.Color.Transparent
        Me.lblETACustomer.Location = New System.Drawing.Point(15, 39)
        Me.lblETACustomer.Name = "lblETACustomer"
        Me.lblETACustomer.Size = New System.Drawing.Size(77, 18)
        Me.lblETACustomer.TabIndex = 0
        Me.lblETACustomer.Text = "ETA Customer"
        '
        'dtETACustomer
        '
        Me.dtETACustomer.CustomFormat = "MMM dd, yyyy"
        Me.dtETACustomer.Enabled = False
        Me.dtETACustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETACustomer.Location = New System.Drawing.Point(98, 38)
        Me.dtETACustomer.Name = "dtETACustomer"
        Me.dtETACustomer.Size = New System.Drawing.Size(120, 20)
        Me.dtETACustomer.TabIndex = 2
        Me.dtETACustomer.TabStop = False
        Me.dtETACustomer.Text = "Jan 19, 2022"
        Me.dtETACustomer.Value = New Date(2022, 1, 19, 9, 31, 45, 145)
        '
        'ddModeOfShipment
        '
        Me.ddModeOfShipment.DropDownAnimationEnabled = True
        RadListDataItem1.Text = "Sea"
        RadListDataItem2.Text = "Air"
        Me.ddModeOfShipment.Items.Add(RadListDataItem1)
        Me.ddModeOfShipment.Items.Add(RadListDataItem2)
        Me.ddModeOfShipment.Location = New System.Drawing.Point(98, 143)
        Me.ddModeOfShipment.Name = "ddModeOfShipment"
        Me.ddModeOfShipment.Size = New System.Drawing.Size(120, 20)
        Me.ddModeOfShipment.TabIndex = 5
        '
        'lblModeOfShipment
        '
        Me.lblModeOfShipment.BackColor = System.Drawing.Color.Transparent
        Me.lblModeOfShipment.Location = New System.Drawing.Point(38, 143)
        Me.lblModeOfShipment.Name = "lblModeOfShipment"
        Me.lblModeOfShipment.Size = New System.Drawing.Size(54, 18)
        Me.lblModeOfShipment.TabIndex = 0
        Me.lblModeOfShipment.Text = "Shipment"
        '
        'lblQtyPerBox
        '
        Me.lblQtyPerBox.Location = New System.Drawing.Point(27, 170)
        Me.lblQtyPerBox.Name = "lblQtyPerBox"
        Me.lblQtyPerBox.Size = New System.Drawing.Size(65, 18)
        Me.lblQtyPerBox.TabIndex = 0
        Me.lblQtyPerBox.Text = "Qty Per Box"
        '
        'numQtyPerBox
        '
        Me.numQtyPerBox.Location = New System.Drawing.Point(98, 169)
        Me.numQtyPerBox.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numQtyPerBox.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.numQtyPerBox.Name = "numQtyPerBox"
        Me.numQtyPerBox.ShowUpDownButtons = False
        Me.numQtyPerBox.Size = New System.Drawing.Size(120, 20)
        Me.numQtyPerBox.TabIndex = 6
        '
        'lblQtyPerPallet
        '
        Me.lblQtyPerPallet.Location = New System.Drawing.Point(18, 196)
        Me.lblQtyPerPallet.Name = "lblQtyPerPallet"
        Me.lblQtyPerPallet.Size = New System.Drawing.Size(74, 18)
        Me.lblQtyPerPallet.TabIndex = 0
        Me.lblQtyPerPallet.Text = "Qty Per Pallet"
        '
        'numQtyPerPallet
        '
        Me.numQtyPerPallet.Location = New System.Drawing.Point(98, 195)
        Me.numQtyPerPallet.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.numQtyPerPallet.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.numQtyPerPallet.Name = "numQtyPerPallet"
        Me.numQtyPerPallet.ShowUpDownButtons = False
        Me.numQtyPerPallet.Size = New System.Drawing.Size(120, 20)
        Me.numQtyPerPallet.TabIndex = 7
        '
        'FrmEditPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 285)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditPurchaseOrder"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Purchase Order"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.dtDateReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateReceived, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddModeOfShipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModeOfShipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblQtyPerBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyPerBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblQtyPerPallet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyPerPallet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dtDateReceived As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents seQuantity As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblQuantity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDateReceived As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtETACustomer As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblETACustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddModeOfShipment As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblModeOfShipment As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numQtyPerPallet As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblQtyPerPallet As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numQtyPerBox As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblQtyPerBox As Telerik.WinControls.UI.RadLabel
End Class

