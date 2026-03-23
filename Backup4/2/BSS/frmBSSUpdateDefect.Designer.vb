<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBSSUpdateDefect
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.panelMore = New Telerik.WinControls.UI.RadPanel()
        Me.txtDID = New Telerik.WinControls.UI.RadTextBox()
        Me.ddlDefectCategory = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.seDefect = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbAssemblyProcessName = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.ddlProgDefect = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        CType(Me.panelMore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMore.SuspendLayout()
        CType(Me.txtDID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlDefectCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProgDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProgDefect.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlProgDefect.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMore
        '
        Me.panelMore.AutoScroll = True
        Me.panelMore.BackColor = System.Drawing.Color.LightGray
        Me.panelMore.Controls.Add(Me.btnUpdate)
        Me.panelMore.Controls.Add(Me.txtDID)
        Me.panelMore.Controls.Add(Me.ddlDefectCategory)
        Me.panelMore.Controls.Add(Me.RadLabel11)
        Me.panelMore.Controls.Add(Me.seDefect)
        Me.panelMore.Controls.Add(Me.RadLabel15)
        Me.panelMore.Controls.Add(Me.mcbAssemblyProcessName)
        Me.panelMore.Controls.Add(Me.ddlProgDefect)
        Me.panelMore.Controls.Add(Me.RadLabel1)
        Me.panelMore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMore.Location = New System.Drawing.Point(0, 0)
        Me.panelMore.Name = "panelMore"
        Me.panelMore.Size = New System.Drawing.Size(439, 159)
        Me.panelMore.TabIndex = 13
        Me.panelMore.ThemeName = "Office2007Black"
        '
        'txtDID
        '
        Me.txtDID.Location = New System.Drawing.Point(369, 94)
        Me.txtDID.Name = "txtDID"
        Me.txtDID.Size = New System.Drawing.Size(50, 20)
        Me.txtDID.TabIndex = 86
        Me.txtDID.Visible = False
        '
        'ddlDefectCategory
        '
        Me.ddlDefectCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "MAN"
        RadListDataItem2.Text = "MACHINE"
        RadListDataItem3.Text = "MATERIAL"
        RadListDataItem4.Text = "OTHER"
        Me.ddlDefectCategory.Items.Add(RadListDataItem1)
        Me.ddlDefectCategory.Items.Add(RadListDataItem2)
        Me.ddlDefectCategory.Items.Add(RadListDataItem3)
        Me.ddlDefectCategory.Items.Add(RadListDataItem4)
        Me.ddlDefectCategory.Location = New System.Drawing.Point(269, 68)
        Me.ddlDefectCategory.Name = "ddlDefectCategory"
        Me.ddlDefectCategory.NullText = "---Defect Category---"
        Me.ddlDefectCategory.Size = New System.Drawing.Size(150, 20)
        Me.ddlDefectCategory.TabIndex = 15
        '
        'RadLabel11
        '
        Me.RadLabel11.Location = New System.Drawing.Point(120, 69)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(41, 18)
        Me.RadLabel11.TabIndex = 83
        Me.RadLabel11.Text = "Defect:"
        '
        'seDefect
        '
        Me.seDefect.DecimalPlaces = 2
        Me.seDefect.EnableNullValueInput = True
        Me.seDefect.Location = New System.Drawing.Point(165, 68)
        Me.seDefect.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seDefect.Name = "seDefect"
        Me.seDefect.ShowUpDownButtons = False
        Me.seDefect.Size = New System.Drawing.Size(88, 20)
        Me.seDefect.TabIndex = 14
        Me.seDefect.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seDefect.ThousandsSeparator = True
        '
        'RadLabel15
        '
        Me.RadLabel15.Location = New System.Drawing.Point(29, 18)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(130, 18)
        Me.RadLabel15.TabIndex = 64
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
        Me.mcbAssemblyProcessName.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbAssemblyProcessName.EditorControl.Name = "NestedRadGridView"
        Me.mcbAssemblyProcessName.EditorControl.ReadOnly = True
        Me.mcbAssemblyProcessName.EditorControl.ShowGroupPanel = False
        Me.mcbAssemblyProcessName.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbAssemblyProcessName.EditorControl.TabIndex = 0
        Me.mcbAssemblyProcessName.Location = New System.Drawing.Point(165, 16)
        Me.mcbAssemblyProcessName.Name = "mcbAssemblyProcessName"
        Me.mcbAssemblyProcessName.NullText = "-- Select Assembly Process Name --"
        Me.mcbAssemblyProcessName.Size = New System.Drawing.Size(254, 20)
        Me.mcbAssemblyProcessName.TabIndex = 12
        Me.mcbAssemblyProcessName.TabStop = False
        '
        'ddlProgDefect
        '
        '
        'ddlProgDefect.NestedRadGridView
        '
        Me.ddlProgDefect.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlProgDefect.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlProgDefect.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlProgDefect.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlProgDefect.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlProgDefect.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.ddlProgDefect.EditorControl.Name = "NestedRadGridView"
        Me.ddlProgDefect.EditorControl.ReadOnly = True
        Me.ddlProgDefect.EditorControl.ShowGroupPanel = False
        Me.ddlProgDefect.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlProgDefect.EditorControl.TabIndex = 0
        Me.ddlProgDefect.Location = New System.Drawing.Point(165, 42)
        Me.ddlProgDefect.Name = "ddlProgDefect"
        Me.ddlProgDefect.NullText = "-- Progress Defects --"
        Me.ddlProgDefect.Size = New System.Drawing.Size(254, 20)
        Me.ddlProgDefect.TabIndex = 13
        Me.ddlProgDefect.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(67, 42)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(92, 18)
        Me.RadLabel1.TabIndex = 57
        Me.RadLabel1.Text = "Progress Defects:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(29, 118)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 87
        Me.btnUpdate.Text = "Update"
        '
        'FrmBSSUpdateDefect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 159)
        Me.Controls.Add(Me.panelMore)
        Me.Name = "FrmBSSUpdateDefect"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBSSUpdateDefect"
        CType(Me.panelMore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMore.ResumeLayout(False)
        Me.panelMore.PerformLayout()
        CType(Me.txtDID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlDefectCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbAssemblyProcessName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProgDefect.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProgDefect.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlProgDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMore As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtDID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ddlDefectCategory As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seDefect As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbAssemblyProcessName As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents ddlProgDefect As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class

