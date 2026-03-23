<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDemandReportSelector
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDemandReportSelector))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.drpReport = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblReport = New Telerik.WinControls.UI.RadLabel()
        Me.btnGenerate = New Telerik.WinControls.UI.RadButton()
        Me.dtDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDateFrom = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.ddCustomerCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.ddCustomerCode)
        Me.panel.Controls.Add(Me.dtDateTo)
        Me.panel.Controls.Add(Me.dtDateFrom)
        Me.panel.Controls.Add(Me.RadLabel1)
        Me.panel.Controls.Add(Me.lblDateFrom)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.drpReport)
        Me.panel.Controls.Add(Me.lblReport)
        Me.panel.Controls.Add(Me.btnGenerate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(252, 160)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomer.Location = New System.Drawing.Point(22, 42)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'drpReport
        '
        Me.drpReport.DropDownAnimationEnabled = True
        Me.drpReport.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Demand ETD FEAP"
        RadListDataItem2.Text = "Budget ETD FEAP"
        Me.drpReport.Items.Add(RadListDataItem1)
        Me.drpReport.Items.Add(RadListDataItem2)
        Me.drpReport.Location = New System.Drawing.Point(83, 14)
        Me.drpReport.Name = "drpReport"
        Me.drpReport.Size = New System.Drawing.Size(150, 20)
        Me.drpReport.TabIndex = 1
        Me.drpReport.Text = "-- Select --"
        '
        'lblReport
        '
        Me.lblReport.BackColor = System.Drawing.Color.Transparent
        Me.lblReport.Location = New System.Drawing.Point(37, 16)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(40, 18)
        Me.lblReport.TabIndex = 0
        Me.lblReport.Text = "Report"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(83, 120)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        '
        'dtDateFrom
        '
        Me.dtDateFrom.CustomFormat = "MMM dd, yyyy"
        Me.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrom.Location = New System.Drawing.Point(83, 67)
        Me.dtDateFrom.Name = "dtDateFrom"
        Me.dtDateFrom.Size = New System.Drawing.Size(150, 20)
        Me.dtDateFrom.TabIndex = 3
        Me.dtDateFrom.TabStop = False
        Me.dtDateFrom.Text = "Jan 20, 2022"
        Me.dtDateFrom.Value = New Date(2022, 1, 20, 17, 17, 27, 205)
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "MMM dd, yyyy"
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(83, 93)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(150, 20)
        Me.dtDateTo.TabIndex = 4
        Me.dtDateTo.TabStop = False
        Me.dtDateTo.Text = "Jan 20, 2022"
        Me.dtDateTo.Value = New Date(2022, 1, 20, 17, 17, 27, 205)
        '
        'lblDateFrom
        '
        Me.lblDateFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblDateFrom.Location = New System.Drawing.Point(18, 69)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(59, 18)
        Me.lblDateFrom.TabIndex = 0
        Me.lblDateFrom.Text = "Date From"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(32, 95)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Date To"
        '
        'ddCustomerCode
        '
        '
        'ddCustomerCode.NestedRadGridView
        '
        Me.ddCustomerCode.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddCustomerCode.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddCustomerCode.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddCustomerCode.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddCustomerCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.ddCustomerCode.EditorControl.Name = "NestedRadGridView"
        Me.ddCustomerCode.EditorControl.ReadOnly = True
        Me.ddCustomerCode.EditorControl.ShowGroupPanel = False
        Me.ddCustomerCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddCustomerCode.EditorControl.TabIndex = 0
        Me.ddCustomerCode.Location = New System.Drawing.Point(84, 41)
        Me.ddCustomerCode.Name = "ddCustomerCode"
        Me.ddCustomerCode.Size = New System.Drawing.Size(149, 20)
        Me.ddCustomerCode.TabIndex = 2
        Me.ddCustomerCode.TabStop = False
        '
        'FrmDemandReportSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 160)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDemandReportSelector"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Selector"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpReport As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblReport As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnGenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDateFrom As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddCustomerCode As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class

