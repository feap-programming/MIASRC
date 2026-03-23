<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditLatestDemand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditLatestDemand))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.dtDateForecast = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDateForecast = New Telerik.WinControls.UI.RadLabel()
        Me.dtDateIssued = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDateIssued = New Telerik.WinControls.UI.RadLabel()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.seQuantity = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblQuantity = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.dtDateForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateIssued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateIssued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.dtDateForecast)
        Me.panel.Controls.Add(Me.lblDateForecast)
        Me.panel.Controls.Add(Me.dtDateIssued)
        Me.panel.Controls.Add(Me.lblDateIssued)
        Me.panel.Controls.Add(Me.txtCustomer)
        Me.panel.Controls.Add(Me.seQuantity)
        Me.panel.Controls.Add(Me.lblQuantity)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.txtPartName)
        Me.panel.Controls.Add(Me.lblPartName)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(232, 210)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'dtDateForecast
        '
        Me.dtDateForecast.CustomFormat = "MMM dd, yyyy"
        Me.dtDateForecast.Enabled = False
        Me.dtDateForecast.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateForecast.Location = New System.Drawing.Point(98, 38)
        Me.dtDateForecast.Name = "dtDateForecast"
        Me.dtDateForecast.ReadOnly = True
        Me.dtDateForecast.Size = New System.Drawing.Size(120, 20)
        Me.dtDateForecast.TabIndex = 2
        Me.dtDateForecast.TabStop = False
        Me.dtDateForecast.Text = "Aug 25, 2020"
        Me.dtDateForecast.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblDateForecast
        '
        Me.lblDateForecast.Location = New System.Drawing.Point(18, 40)
        Me.lblDateForecast.Name = "lblDateForecast"
        Me.lblDateForecast.Size = New System.Drawing.Size(74, 18)
        Me.lblDateForecast.TabIndex = 0
        Me.lblDateForecast.Text = "Date Forecast"
        '
        'dtDateIssued
        '
        Me.dtDateIssued.CustomFormat = "MMM dd, yyyy"
        Me.dtDateIssued.Enabled = False
        Me.dtDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateIssued.Location = New System.Drawing.Point(98, 12)
        Me.dtDateIssued.Name = "dtDateIssued"
        Me.dtDateIssued.ReadOnly = True
        Me.dtDateIssued.Size = New System.Drawing.Size(120, 20)
        Me.dtDateIssued.TabIndex = 1
        Me.dtDateIssued.TabStop = False
        Me.dtDateIssued.Text = "Aug 25, 2020"
        Me.dtDateIssued.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblDateIssued
        '
        Me.lblDateIssued.Location = New System.Drawing.Point(28, 14)
        Me.lblDateIssued.Name = "lblDateIssued"
        Me.lblDateIssued.Size = New System.Drawing.Size(64, 18)
        Me.lblDateIssued.TabIndex = 0
        Me.lblDateIssued.Text = "Date Issued"
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(98, 64)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(120, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'seQuantity
        '
        Me.seQuantity.Location = New System.Drawing.Point(98, 143)
        Me.seQuantity.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seQuantity.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seQuantity.Name = "seQuantity"
        Me.seQuantity.ShowUpDownButtons = False
        Me.seQuantity.Size = New System.Drawing.Size(120, 20)
        Me.seQuantity.TabIndex = 5
        Me.seQuantity.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(43, 144)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 18)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Quantity"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(37, 67)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(98, 90)
        Me.txtPartName.Multiline = True
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        '
        '
        '
        Me.txtPartName.RootElement.StretchVertically = True
        Me.txtPartName.Size = New System.Drawing.Size(120, 47)
        Me.txtPartName.TabIndex = 4
        '
        'lblPartName
        '
        Me.lblPartName.Location = New System.Drawing.Point(33, 91)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(59, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "Part Name"
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.MIA.My.Resources.Resources.correction
        Me.btnUpdate.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdate.Location = New System.Drawing.Point(98, 169)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 24)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'FrmEditLatestDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 210)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditLatestDemand"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Latest Demand"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.dtDateForecast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateForecast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateIssued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateIssued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents seQuantity As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblQuantity As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtDateIssued As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblDateIssued As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtDateForecast As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblDateForecast As Telerik.WinControls.UI.RadLabel
End Class

