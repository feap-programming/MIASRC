<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSTemplateAddDefect
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
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtItemCode = New Telerik.WinControls.UI.RadTextBox()
        Me.mcbAssemblyProcessName = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbPartName = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.btnAddDefect = New Telerik.WinControls.UI.RadButton()
        Me.gvDefect = New Telerik.WinControls.UI.RadGridView()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPartName.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPartName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDefect.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.mcbProcess)
        Me.z.Controls.Add(Me.RadLabel3)
        Me.z.Controls.Add(Me.txtItemCode)
        Me.z.Controls.Add(Me.mcbAssemblyProcessName)
        Me.z.Controls.Add(Me.RadLabel20)
        Me.z.Controls.Add(Me.RadLabel2)
        Me.z.Controls.Add(Me.mcbPartName)
        Me.z.Controls.Add(Me.RadLabel15)
        Me.z.Controls.Add(Me.btnAddDefect)
        Me.z.Controls.Add(Me.gvDefect)
        Me.z.Dock = System.Windows.Forms.DockStyle.Fill
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(762, 475)
        Me.z.TabIndex = 136
        Me.z.ThemeName = "Office2007Black"
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
        Me.mcbProcess.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbProcess.EditorControl.Name = "NestedRadGridView"
        Me.mcbProcess.EditorControl.ReadOnly = True
        Me.mcbProcess.EditorControl.ShowGroupPanel = False
        Me.mcbProcess.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbProcess.EditorControl.TabIndex = 0
        Me.mcbProcess.Location = New System.Drawing.Point(170, 52)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.NullText = "-- Select Main Process --"
        Me.mcbProcess.Size = New System.Drawing.Size(352, 20)
        Me.mcbProcess.TabIndex = 180
        Me.mcbProcess.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(70, 50)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel3.TabIndex = 181
        Me.RadLabel3.Text = "Main Process:"
        '
        'txtItemCode
        '
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Location = New System.Drawing.Point(170, 26)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(352, 20)
        Me.txtItemCode.TabIndex = 146
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
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbAssemblyProcessName.EditorControl.Name = "NestedRadGridView"
        Me.mcbAssemblyProcessName.EditorControl.ReadOnly = True
        Me.mcbAssemblyProcessName.EditorControl.ShowGroupPanel = False
        Me.mcbAssemblyProcessName.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbAssemblyProcessName.EditorControl.TabIndex = 0
        Me.mcbAssemblyProcessName.Location = New System.Drawing.Point(170, 78)
        Me.mcbAssemblyProcessName.Name = "mcbAssemblyProcessName"
        Me.mcbAssemblyProcessName.NullText = "-- Select Assembly Process Name --"
        Me.mcbAssemblyProcessName.Size = New System.Drawing.Size(352, 20)
        Me.mcbAssemblyProcessName.TabIndex = 140
        Me.mcbAssemblyProcessName.TabStop = False
        '
        'RadLabel20
        '
        Me.RadLabel20.Location = New System.Drawing.Point(81, 5)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(64, 18)
        Me.RadLabel20.TabIndex = 147
        Me.RadLabel20.Text = "Part Name.:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(84, 26)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel2.TabIndex = 145
        Me.RadLabel2.Text = "Item Code:"
        '
        'mcbPartName
        '
        '
        'mcbPartName.NestedRadGridView
        '
        Me.mcbPartName.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbPartName.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbPartName.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbPartName.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbPartName.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbPartName.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbPartName.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbPartName.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbPartName.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbPartName.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbPartName.EditorControl.Name = "NestedRadGridView"
        Me.mcbPartName.EditorControl.ReadOnly = True
        Me.mcbPartName.EditorControl.ShowGroupPanel = False
        Me.mcbPartName.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbPartName.EditorControl.TabIndex = 0
        Me.mcbPartName.Location = New System.Drawing.Point(170, 3)
        Me.mcbPartName.Name = "mcbPartName"
        Me.mcbPartName.Size = New System.Drawing.Size(352, 20)
        Me.mcbPartName.TabIndex = 144
        Me.mcbPartName.TabStop = False
        '
        'RadLabel15
        '
        Me.RadLabel15.Location = New System.Drawing.Point(15, 78)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(130, 18)
        Me.RadLabel15.TabIndex = 143
        Me.RadLabel15.Text = "Assembly Process Name:"
        '
        'btnAddDefect
        '
        Me.btnAddDefect.Location = New System.Drawing.Point(540, 77)
        Me.btnAddDefect.Name = "btnAddDefect"
        Me.btnAddDefect.Size = New System.Drawing.Size(45, 19)
        Me.btnAddDefect.TabIndex = 139
        Me.btnAddDefect.Text = "Add"
        '
        'gvDefect
        '
        Me.gvDefect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvDefect.Location = New System.Drawing.Point(0, 104)
        '
        '
        '
        Me.gvDefect.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.gvDefect.Name = "gvDefect"
        Me.gvDefect.Size = New System.Drawing.Size(762, 371)
        Me.gvDefect.TabIndex = 87
        '
        'FrmBSSTemplateAddDefect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 475)
        Me.Controls.Add(Me.z)
        Me.Name = "FrmBSSTemplateAddDefect"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BSS Template Add Defect"
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPartName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPartName.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDefect.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnAddDefect As Telerik.WinControls.UI.RadButton
    Friend WithEvents gvDefect As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbAssemblyProcessName As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtItemCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbPartName As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
End Class

