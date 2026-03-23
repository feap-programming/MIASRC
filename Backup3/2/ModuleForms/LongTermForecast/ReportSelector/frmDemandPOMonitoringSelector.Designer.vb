<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDemandPOMonitoringSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDemandPOMonitoringSelector))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.btnGenerate = New Telerik.WinControls.UI.RadButton()
        Me.ddCustomerCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblCustomerCode = New Telerik.WinControls.UI.RadLabel()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.ddCustomerCode)
        Me.panel.Controls.Add(Me.lblCustomerCode)
        Me.panel.Controls.Add(Me.numYear)
        Me.panel.Controls.Add(Me.lblYear)
        Me.panel.Controls.Add(Me.btnGenerate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(252, 100)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'numYear
        '
        Me.numYear.Location = New System.Drawing.Point(83, 12)
        Me.numYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numYear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.NullableValue = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.numYear.ShowUpDownButtons = False
        Me.numYear.Size = New System.Drawing.Size(150, 20)
        Me.numYear.TabIndex = 1
        Me.numYear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numYear.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(49, 14)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(28, 18)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(83, 64)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate"
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
        Me.ddCustomerCode.Location = New System.Drawing.Point(83, 38)
        Me.ddCustomerCode.Name = "ddCustomerCode"
        Me.ddCustomerCode.Size = New System.Drawing.Size(150, 20)
        Me.ddCustomerCode.TabIndex = 2
        Me.ddCustomerCode.TabStop = False
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerCode.Location = New System.Drawing.Point(22, 40)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomerCode.TabIndex = 0
        Me.lblCustomerCode.Text = "Customer"
        '
        'FrmDemandPOMonitoringSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 100)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDemandPOMonitoringSelector"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demand & PO"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnGenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddCustomerCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents lblCustomerCode As Telerik.WinControls.UI.RadLabel
End Class

