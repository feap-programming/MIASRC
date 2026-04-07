<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateActual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateActual))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.lblInvoiceNo = New Telerik.WinControls.UI.RadLabel()
        Me.dtATACustomer = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATACustomer = New Telerik.WinControls.UI.RadLabel()
        Me.dtATDManila = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATDManila = New Telerik.WinControls.UI.RadLabel()
        Me.dtATDFEAP = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblATDFEAP = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.cbATDFEAP = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbATDManila = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbATACustomer = New Telerik.WinControls.UI.RadCheckBox()
        Me.mcbInvoiceNo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbATDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbATDManila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbATACustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbInvoiceNo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbInvoiceNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.mcbInvoiceNo)
        Me.panel.Controls.Add(Me.cbATACustomer)
        Me.panel.Controls.Add(Me.cbATDManila)
        Me.panel.Controls.Add(Me.cbATDFEAP)
        Me.panel.Controls.Add(Me.lblInvoiceNo)
        Me.panel.Controls.Add(Me.dtATACustomer)
        Me.panel.Controls.Add(Me.lblATACustomer)
        Me.panel.Controls.Add(Me.dtATDManila)
        Me.panel.Controls.Add(Me.lblATDManila)
        Me.panel.Controls.Add(Me.dtATDFEAP)
        Me.panel.Controls.Add(Me.lblATDFEAP)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(252, 155)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
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
        'dtATACustomer
        '
        Me.dtATACustomer.CustomFormat = "MMM dd, yyyy"
        Me.dtATACustomer.Enabled = False
        Me.dtATACustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATACustomer.Location = New System.Drawing.Point(100, 90)
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
        Me.lblATACustomer.Location = New System.Drawing.Point(16, 91)
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
        Me.dtATDManila.Location = New System.Drawing.Point(100, 64)
        Me.dtATDManila.Name = "dtATDManila"
        Me.dtATDManila.Size = New System.Drawing.Size(120, 20)
        Me.dtATDManila.TabIndex = 4
        Me.dtATDManila.TabStop = False
        Me.dtATDManila.Text = "Aug 25, 2020"
        Me.dtATDManila.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblATDManila
        '
        Me.lblATDManila.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATDManila.Location = New System.Drawing.Point(40, 66)
        Me.lblATDManila.Name = "lblATDManila"
        Me.lblATDManila.Size = New System.Drawing.Size(54, 18)
        Me.lblATDManila.TabIndex = 0
        Me.lblATDManila.Text = "ATD MNL"
        '
        'dtATDFEAP
        '
        Me.dtATDFEAP.CustomFormat = "MMM dd, yyyy"
        Me.dtATDFEAP.Enabled = False
        Me.dtATDFEAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtATDFEAP.Location = New System.Drawing.Point(100, 38)
        Me.dtATDFEAP.Name = "dtATDFEAP"
        Me.dtATDFEAP.Size = New System.Drawing.Size(120, 20)
        Me.dtATDFEAP.TabIndex = 2
        Me.dtATDFEAP.TabStop = False
        Me.dtATDFEAP.Text = "Aug 25, 2020"
        Me.dtATDFEAP.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblATDFEAP
        '
        Me.lblATDFEAP.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATDFEAP.Location = New System.Drawing.Point(39, 40)
        Me.lblATDFEAP.Name = "lblATDFEAP"
        Me.lblATDFEAP.Size = New System.Drawing.Size(55, 18)
        Me.lblATDFEAP.TabIndex = 0
        Me.lblATDFEAP.Text = "ATD FEAP"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(100, 116)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 24)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        '
        'cbATDFEAP
        '
        Me.cbATDFEAP.Location = New System.Drawing.Point(226, 38)
        Me.cbATDFEAP.Name = "cbATDFEAP"
        Me.cbATDFEAP.Size = New System.Drawing.Size(15, 15)
        Me.cbATDFEAP.TabIndex = 3
        '
        'cbATDManila
        '
        Me.cbATDManila.Location = New System.Drawing.Point(226, 64)
        Me.cbATDManila.Name = "cbATDManila"
        Me.cbATDManila.Size = New System.Drawing.Size(15, 15)
        Me.cbATDManila.TabIndex = 5
        '
        'cbATACustomer
        '
        Me.cbATACustomer.Location = New System.Drawing.Point(226, 90)
        Me.cbATACustomer.Name = "cbATACustomer"
        Me.cbATACustomer.Size = New System.Drawing.Size(15, 15)
        Me.cbATACustomer.TabIndex = 7
        '
        'mcbInvoiceNo
        '
        '
        'mcbInvoiceNo.NestedRadGridView
        '
        Me.mcbInvoiceNo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbInvoiceNo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbInvoiceNo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbInvoiceNo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbInvoiceNo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbInvoiceNo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbInvoiceNo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbInvoiceNo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbInvoiceNo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbInvoiceNo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbInvoiceNo.EditorControl.Name = "NestedRadGridView"
        Me.mcbInvoiceNo.EditorControl.ReadOnly = True
        Me.mcbInvoiceNo.EditorControl.ShowGroupPanel = False
        Me.mcbInvoiceNo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbInvoiceNo.EditorControl.TabIndex = 0
        Me.mcbInvoiceNo.Location = New System.Drawing.Point(100, 12)
        Me.mcbInvoiceNo.Name = "mcbInvoiceNo"
        Me.mcbInvoiceNo.Size = New System.Drawing.Size(120, 20)
        Me.mcbInvoiceNo.TabIndex = 1
        Me.mcbInvoiceNo.TabStop = False
        '
        'FrmUpdateActual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 155)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdateActual"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Actual"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.lblInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbATDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbATDManila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbATACustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbInvoiceNo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbInvoiceNo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblInvoiceNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATACustomer As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATACustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATDManila As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATDManila As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtATDFEAP As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblATDFEAP As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents cbATACustomer As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbATDManila As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbATDFEAP As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents mcbInvoiceNo As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class

