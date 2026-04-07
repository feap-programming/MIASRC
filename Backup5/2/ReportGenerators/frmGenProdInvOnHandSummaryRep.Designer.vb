<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenProdInvOnHandSummaryRep
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenProdInvOnHandSummaryRep))
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpLastDateOfInventory = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.btnGenerate = New Telerik.WinControls.UI.RadButton()
        Me.mcbTo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbFrom = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpLastDateOfInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(17, 106)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(118, 18)
        Me.RadLabel4.TabIndex = 21
        Me.RadLabel4.Text = "Last Date of Inventory:"
        '
        'dtpLastDateOfInventory
        '
        Me.dtpLastDateOfInventory.Location = New System.Drawing.Point(141, 104)
        Me.dtpLastDateOfInventory.Name = "dtpLastDateOfInventory"
        Me.dtpLastDateOfInventory.Size = New System.Drawing.Size(164, 20)
        Me.dtpLastDateOfInventory.TabIndex = 16
        Me.dtpLastDateOfInventory.TabStop = False
        Me.dtpLastDateOfInventory.Text = "Wednesday, August 28, 2019"
        Me.dtpLastDateOfInventory.Value = New Date(2019, 8, 28, 7, 36, 53, 590)
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(58, 158)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(77, 18)
        Me.RadLabel3.TabIndex = 19
        Me.RadLabel3.Text = "Date Input To:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(47, 132)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(88, 18)
        Me.RadLabel2.TabIndex = 17
        Me.RadLabel2.Text = "Date Input Start:"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(141, 156)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(164, 20)
        Me.dtpTo.TabIndex = 20
        Me.dtpTo.TabStop = False
        Me.dtpTo.Text = "Wednesday, August 28, 2019"
        Me.dtpTo.Value = New Date(2019, 8, 28, 7, 36, 58, 476)
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(141, 130)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(164, 20)
        Me.dtpFrom.TabIndex = 18
        Me.dtpFrom.TabStop = False
        Me.dtpFrom.Text = "Wednesday, August 28, 2019"
        Me.dtpFrom.Value = New Date(2019, 8, 28, 7, 36, 53, 590)
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(41, 28)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(94, 18)
        Me.RadLabel1.TabIndex = 22
        Me.RadLabel1.Text = "Warehouse From:"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(54, 54)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(81, 18)
        Me.RadLabel5.TabIndex = 23
        Me.RadLabel5.Text = "Warehouse To:"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(74, 80)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel6.TabIndex = 24
        Me.RadLabel6.Text = "Item Code:"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(195, 210)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnGenerate.TabIndex = 25
        Me.btnGenerate.Text = "Generate"
        '
        'mcbTo
        '
        '
        'mcbTo.NestedRadGridView
        '
        Me.mcbTo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbTo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbTo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbTo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbTo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbTo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbTo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbTo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbTo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbTo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbTo.EditorControl.Name = "NestedRadGridView"
        Me.mcbTo.EditorControl.ReadOnly = True
        Me.mcbTo.EditorControl.ShowGroupPanel = False
        Me.mcbTo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbTo.EditorControl.TabIndex = 0
        Me.mcbTo.Location = New System.Drawing.Point(141, 52)
        Me.mcbTo.Name = "mcbTo"
        Me.mcbTo.NullText = "-- Select Warehouse Code To --"
        Me.mcbTo.Size = New System.Drawing.Size(302, 20)
        Me.mcbTo.TabIndex = 27
        Me.mcbTo.TabStop = False
        '
        'mcbFrom
        '
        '
        'mcbFrom.NestedRadGridView
        '
        Me.mcbFrom.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbFrom.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbFrom.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbFrom.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbFrom.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbFrom.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbFrom.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbFrom.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbFrom.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbFrom.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbFrom.EditorControl.Name = "NestedRadGridView"
        Me.mcbFrom.EditorControl.ReadOnly = True
        Me.mcbFrom.EditorControl.ShowGroupPanel = False
        Me.mcbFrom.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbFrom.EditorControl.TabIndex = 0
        Me.mcbFrom.Location = New System.Drawing.Point(141, 26)
        Me.mcbFrom.Name = "mcbFrom"
        Me.mcbFrom.NullText = "-- Select Warehouse Code From --"
        Me.mcbFrom.Size = New System.Drawing.Size(302, 20)
        Me.mcbFrom.TabIndex = 26
        Me.mcbFrom.TabStop = False
        '
        'mcbItemCode
        '
        '
        'mcbItemCode.NestedRadGridView
        '
        Me.mcbItemCode.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbItemCode.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbItemCode.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbItemCode.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbItemCode.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbItemCode.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(141, 78)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.NullText = "-- Select Item Code --"
        Me.mcbItemCode.Size = New System.Drawing.Size(302, 20)
        Me.mcbItemCode.TabIndex = 28
        Me.mcbItemCode.TabStop = False
        '
        'FrmGenProdInvOnHandSummaryRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(473, 261)
        Me.Controls.Add(Me.mcbTo)
        Me.Controls.Add(Me.mcbFrom)
        Me.Controls.Add(Me.mcbItemCode)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.dtpLastDateOfInventory)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(481, 291)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(481, 291)
        Me.Name = "FrmGenProdInvOnHandSummaryRep"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(481, 291)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Production Inventory Daily Summary Monitoring"
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpLastDateOfInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpLastDateOfInventory As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnGenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents mcbTo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbFrom As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class

