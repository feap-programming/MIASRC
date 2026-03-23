<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesInvoiceReportSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalesInvoiceReportSelector))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.dtDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblDateFrom = New Telerik.WinControls.UI.RadLabel()
        Me.btnGenerate = New Telerik.WinControls.UI.RadButton()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.dtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.dtDateTo)
        Me.panel.Controls.Add(Me.dtDateFrom)
        Me.panel.Controls.Add(Me.RadLabel1)
        Me.panel.Controls.Add(Me.lblDateFrom)
        Me.panel.Controls.Add(Me.btnGenerate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(252, 110)
        Me.panel.TabIndex = 1
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "MMM dd, yyyy"
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(83, 41)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(150, 20)
        Me.dtDateTo.TabIndex = 4
        Me.dtDateTo.TabStop = False
        Me.dtDateTo.Text = "Jan 20, 2022"
        Me.dtDateTo.Value = New Date(2022, 1, 20, 17, 17, 27, 205)
        '
        'dtDateFrom
        '
        Me.dtDateFrom.CustomFormat = "MMM dd, yyyy"
        Me.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrom.Location = New System.Drawing.Point(83, 15)
        Me.dtDateFrom.Name = "dtDateFrom"
        Me.dtDateFrom.Size = New System.Drawing.Size(150, 20)
        Me.dtDateFrom.TabIndex = 3
        Me.dtDateFrom.TabStop = False
        Me.dtDateFrom.Text = "Jan 20, 2022"
        Me.dtDateFrom.Value = New Date(2022, 1, 20, 17, 17, 27, 205)
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(32, 43)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Date To"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblDateFrom.Location = New System.Drawing.Point(18, 17)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(59, 18)
        Me.lblDateFrom.TabIndex = 0
        Me.lblDateFrom.Text = "Date From"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(83, 68)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        '
        'FrmSalesInvoiceReportSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 110)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSalesInvoiceReportSelector"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales Invoice Report Selector"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.dtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dtDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDateFrom As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnGenerate As Telerik.WinControls.UI.RadButton
End Class

