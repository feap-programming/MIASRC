<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSTemplateUpdate
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
        Dim TableViewDefinition16 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition14 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition15 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition13 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtFGNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbPartNameFront = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbAssemblyProcessName = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.txtBFID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFGNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPartNameFront, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPartNameFront.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbPartNameFront.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBFID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtBFID)
        Me.RadPanel1.Controls.Add(Me.RadLabel15)
        Me.RadPanel1.Controls.Add(Me.mcbAssemblyProcessName)
        Me.RadPanel1.Controls.Add(Me.mcbItemCode)
        Me.RadPanel1.Controls.Add(Me.RadLabel18)
        Me.RadPanel1.Controls.Add(Me.mcbProcess)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.txtFGNo)
        Me.RadPanel1.Controls.Add(Me.RadLabel20)
        Me.RadPanel1.Controls.Add(Me.mcbPartNameFront)
        Me.RadPanel1.Controls.Add(Me.btnUpdate)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(331, 331)
        Me.RadPanel1.TabIndex = 36
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 286)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 60)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(43, 18)
        Me.RadLabel1.TabIndex = 174
        Me.RadLabel1.Text = "FG No.:"
        '
        'txtFGNo
        '
        Me.txtFGNo.Enabled = False
        Me.txtFGNo.Location = New System.Drawing.Point(12, 84)
        Me.txtFGNo.Name = "txtFGNo"
        Me.txtFGNo.Size = New System.Drawing.Size(304, 20)
        Me.txtFGNo.TabIndex = 172
        '
        'RadLabel20
        '
        Me.RadLabel20.Location = New System.Drawing.Point(12, 9)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(64, 18)
        Me.RadLabel20.TabIndex = 173
        Me.RadLabel20.Text = "Part Name.:"
        '
        'mcbPartNameFront
        '
        '
        'mcbPartNameFront.NestedRadGridView
        '
        Me.mcbPartNameFront.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbPartNameFront.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbPartNameFront.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbPartNameFront.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbPartNameFront.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbPartNameFront.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbPartNameFront.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbPartNameFront.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbPartNameFront.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbPartNameFront.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition16
        Me.mcbPartNameFront.EditorControl.Name = "NestedRadGridView"
        Me.mcbPartNameFront.EditorControl.ReadOnly = True
        Me.mcbPartNameFront.EditorControl.ShowGroupPanel = False
        Me.mcbPartNameFront.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbPartNameFront.EditorControl.TabIndex = 0
        Me.mcbPartNameFront.Enabled = False
        Me.mcbPartNameFront.Location = New System.Drawing.Point(12, 34)
        Me.mcbPartNameFront.Name = "mcbPartNameFront"
        Me.mcbPartNameFront.Size = New System.Drawing.Size(304, 20)
        Me.mcbPartNameFront.TabIndex = 171
        Me.mcbPartNameFront.TabStop = False
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition14
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(12, 134)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(304, 20)
        Me.mcbItemCode.TabIndex = 188
        Me.mcbItemCode.TabStop = False
        '
        'RadLabel18
        '
        Me.RadLabel18.Location = New System.Drawing.Point(12, 110)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel18.TabIndex = 191
        Me.RadLabel18.Text = "Item Code:"
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
        Me.mcbProcess.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition15
        Me.mcbProcess.EditorControl.Name = "NestedRadGridView"
        Me.mcbProcess.EditorControl.ReadOnly = True
        Me.mcbProcess.EditorControl.ShowGroupPanel = False
        Me.mcbProcess.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbProcess.EditorControl.TabIndex = 0
        Me.mcbProcess.Location = New System.Drawing.Point(12, 185)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.NullText = "-- Select Main Process --"
        Me.mcbProcess.Size = New System.Drawing.Size(304, 20)
        Me.mcbProcess.TabIndex = 189
        Me.mcbProcess.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 161)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel3.TabIndex = 190
        Me.RadLabel3.Text = "Main Process:"
        '
        'RadLabel15
        '
        Me.RadLabel15.Location = New System.Drawing.Point(12, 211)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(130, 18)
        Me.RadLabel15.TabIndex = 193
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
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition13
        Me.mcbAssemblyProcessName.EditorControl.Name = "NestedRadGridView"
        Me.mcbAssemblyProcessName.EditorControl.ReadOnly = True
        Me.mcbAssemblyProcessName.EditorControl.ShowGroupPanel = False
        Me.mcbAssemblyProcessName.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbAssemblyProcessName.EditorControl.TabIndex = 0
        Me.mcbAssemblyProcessName.Location = New System.Drawing.Point(12, 235)
        Me.mcbAssemblyProcessName.Name = "mcbAssemblyProcessName"
        Me.mcbAssemblyProcessName.NullText = "-- Select Assembly Process Name --"
        Me.mcbAssemblyProcessName.Size = New System.Drawing.Size(304, 20)
        Me.mcbAssemblyProcessName.TabIndex = 192
        Me.mcbAssemblyProcessName.TabStop = False
        '
        'txtBFID
        '
        Me.txtBFID.Location = New System.Drawing.Point(253, 288)
        Me.txtBFID.Name = "txtBFID"
        Me.txtBFID.Size = New System.Drawing.Size(62, 20)
        Me.txtBFID.TabIndex = 194
        Me.txtBFID.Visible = False
        '
        'FrmBSSTemplateUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 331)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmBSSTemplateUpdate"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BSS TEMPLATE UPDATE"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFGNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPartNameFront.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPartNameFront.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbPartNameFront, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBFID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtFGNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbPartNameFront As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbAssemblyProcessName As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtBFID As Telerik.WinControls.UI.RadTextBox
End Class

