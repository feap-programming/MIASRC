<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddProdMainProcess
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
        Dim TableViewDefinition10 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition11 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition12 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbAssemblyProcessName = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.txtMainID = New Telerik.WinControls.UI.RadTextBox()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel15
        '
        Me.RadLabel15.Location = New System.Drawing.Point(10, 39)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(130, 18)
        Me.RadLabel15.TabIndex = 180
        Me.RadLabel15.Text = "Assembly Process Name:"
        '
        'mcbAssemblyProcessName
        '
        '
        'mcbAssemblyProcessName.NestedRadGridView
        '
        Me.mcbAssemblyProcessName.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbAssemblyProcessName.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbAssemblyProcessName.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbAssemblyProcessName.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition10
        Me.mcbAssemblyProcessName.EditorControl.Name = "NestedRadGridView"
        Me.mcbAssemblyProcessName.EditorControl.ReadOnly = True
        Me.mcbAssemblyProcessName.EditorControl.ShowGroupPanel = False
        Me.mcbAssemblyProcessName.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbAssemblyProcessName.EditorControl.TabIndex = 0
        Me.mcbAssemblyProcessName.Location = New System.Drawing.Point(146, 37)
        Me.mcbAssemblyProcessName.Name = "mcbAssemblyProcessName"
        Me.mcbAssemblyProcessName.NullText = "-- Select Assembly Process Name --"
        Me.mcbAssemblyProcessName.Size = New System.Drawing.Size(304, 20)
        Me.mcbAssemblyProcessName.TabIndex = 178
        Me.mcbAssemblyProcessName.TabStop = False
        '
        'mcbProcess
        '
        '
        'mcbProcess.NestedRadGridView
        '
        Me.mcbProcess.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbProcess.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbProcess.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbProcess.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbProcess.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbProcess.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbProcess.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbProcess.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbProcess.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbProcess.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition11
        Me.mcbProcess.EditorControl.Name = "NestedRadGridView"
        Me.mcbProcess.EditorControl.ReadOnly = True
        Me.mcbProcess.EditorControl.ShowGroupPanel = False
        Me.mcbProcess.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbProcess.EditorControl.TabIndex = 0
        Me.mcbProcess.Location = New System.Drawing.Point(146, 11)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.NullText = "-- Select Main Process --"
        Me.mcbProcess.Size = New System.Drawing.Size(304, 20)
        Me.mcbProcess.TabIndex = 177
        Me.mcbProcess.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(65, 12)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel3.TabIndex = 179
        Me.RadLabel3.Text = "Main Process:"
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition12
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(146, 63)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(304, 20)
        Me.mcbItemCode.TabIndex = 188
        Me.mcbItemCode.TabStop = False
        '
        'RadLabel18
        '
        Me.RadLabel18.Location = New System.Drawing.Point(78, 65)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel18.TabIndex = 189
        Me.RadLabel18.Text = "Item Code:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(108, 128)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 19)
        Me.btnSave.TabIndex = 190
        Me.btnSave.Text = "Save"
        '
        'txtMainID
        '
        Me.txtMainID.Location = New System.Drawing.Point(422, 128)
        Me.txtMainID.Name = "txtMainID"
        Me.txtMainID.Size = New System.Drawing.Size(28, 20)
        Me.txtMainID.TabIndex = 191
        Me.txtMainID.Visible = False
        '
        'z
        '
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.txtPartName)
        Me.z.Controls.Add(Me.RadLabel20)
        Me.z.Controls.Add(Me.mcbProcess)
        Me.z.Controls.Add(Me.txtMainID)
        Me.z.Controls.Add(Me.RadLabel3)
        Me.z.Controls.Add(Me.btnSave)
        Me.z.Controls.Add(Me.mcbAssemblyProcessName)
        Me.z.Controls.Add(Me.mcbItemCode)
        Me.z.Controls.Add(Me.RadLabel15)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Location = New System.Drawing.Point(12, 12)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(494, 156)
        Me.z.TabIndex = 192
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(146, 89)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(304, 20)
        Me.txtPartName.TabIndex = 192
        '
        'RadLabel20
        '
        Me.RadLabel20.Location = New System.Drawing.Point(76, 89)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(64, 18)
        Me.RadLabel20.TabIndex = 193
        Me.RadLabel20.Text = "Part Name.:"
        '
        'FrmAddProdMainProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 174)
        Me.Controls.Add(Me.z)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Name = "FrmAddProdMainProcess"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmAddProdMainProcess"
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbAssemblyProcessName As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtMainID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
End Class

