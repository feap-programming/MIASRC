<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBSSOtherDetails
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnAddRM = New Telerik.WinControls.UI.RadButton()
        Me.gvRemarks = New Telerik.WinControls.UI.RadGridView()
        Me.mcbTitle = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtMainID = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPOSPID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRemarks.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.txtMainID)
        Me.z.Controls.Add(Me.txtPOSPID)
        Me.z.Controls.Add(Me.mcbTitle)
        Me.z.Controls.Add(Me.RadLabel4)
        Me.z.Controls.Add(Me.mcbProcess)
        Me.z.Controls.Add(Me.RadLabel3)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Controls.Add(Me.txtRemarks)
        Me.z.Controls.Add(Me.btnSave)
        Me.z.Controls.Add(Me.btnAddRM)
        Me.z.Controls.Add(Me.gvRemarks)
        Me.z.Dock = System.Windows.Forms.DockStyle.Fill
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(629, 466)
        Me.z.TabIndex = 136
        Me.z.ThemeName = "Office2007Black"
        '
        'RadLabel18
        '
        Me.RadLabel18.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel18.Location = New System.Drawing.Point(14, 80)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel18.TabIndex = 158
        Me.RadLabel18.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(95, 80)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        '
        '
        '
        Me.txtRemarks.RootElement.StretchVertically = True
        Me.txtRemarks.Size = New System.Drawing.Size(439, 42)
        Me.txtRemarks.TabIndex = 157
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(529, 421)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 24)
        Me.btnSave.TabIndex = 140
        Me.btnSave.Text = "Save"
        '
        'btnAddRM
        '
        Me.btnAddRM.Location = New System.Drawing.Point(552, 103)
        Me.btnAddRM.Name = "btnAddRM"
        Me.btnAddRM.Size = New System.Drawing.Size(45, 19)
        Me.btnAddRM.TabIndex = 139
        Me.btnAddRM.Text = "Add"
        '
        'gvRemarks
        '
        Me.gvRemarks.Location = New System.Drawing.Point(7, 128)
        '
        '
        '
        Me.gvRemarks.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gvRemarks.Name = "gvRemarks"
        Me.gvRemarks.Size = New System.Drawing.Size(601, 287)
        Me.gvRemarks.TabIndex = 87
        '
        'mcbTitle
        '
        '
        'mcbTitle.NestedRadGridView
        '
        Me.mcbTitle.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbTitle.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbTitle.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbTitle.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbTitle.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbTitle.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbTitle.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbTitle.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbTitle.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbTitle.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbTitle.EditorControl.Name = "NestedRadGridView"
        Me.mcbTitle.EditorControl.ReadOnly = True
        Me.mcbTitle.EditorControl.ShowGroupPanel = False
        Me.mcbTitle.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbTitle.EditorControl.TabIndex = 0
        Me.mcbTitle.Enabled = False
        Me.mcbTitle.Location = New System.Drawing.Point(95, 12)
        Me.mcbTitle.Name = "mcbTitle"
        Me.mcbTitle.NullText = "-- Select Title --"
        Me.mcbTitle.Size = New System.Drawing.Size(398, 20)
        Me.mcbTitle.TabIndex = 161
        Me.mcbTitle.TabStop = False
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(7, 40)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel4.TabIndex = 162
        Me.RadLabel4.Text = "Main Process:"
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
        Me.mcbProcess.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbProcess.EditorControl.Name = "NestedRadGridView"
        Me.mcbProcess.EditorControl.ReadOnly = True
        Me.mcbProcess.EditorControl.ShowGroupPanel = False
        Me.mcbProcess.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbProcess.EditorControl.TabIndex = 0
        Me.mcbProcess.Enabled = False
        Me.mcbProcess.Location = New System.Drawing.Point(95, 38)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.NullText = "-- Select Main Process --"
        Me.mcbProcess.Size = New System.Drawing.Size(398, 20)
        Me.mcbProcess.TabIndex = 159
        Me.mcbProcess.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(50, 13)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel3.TabIndex = 160
        Me.RadLabel3.Text = "Title:"
        '
        'txtMainID
        '
        Me.txtMainID.Location = New System.Drawing.Point(14, 434)
        Me.txtMainID.Name = "txtMainID"
        Me.txtMainID.Size = New System.Drawing.Size(28, 20)
        Me.txtMainID.TabIndex = 164
        Me.txtMainID.Visible = False
        '
        'txtPOSPID
        '
        Me.txtPOSPID.Location = New System.Drawing.Point(48, 434)
        Me.txtPOSPID.Name = "txtPOSPID"
        Me.txtPOSPID.Size = New System.Drawing.Size(28, 20)
        Me.txtPOSPID.TabIndex = 163
        Me.txtPOSPID.Visible = False
        '
        'FrmBSSOtherDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 466)
        Me.Controls.Add(Me.z)
        Me.Name = "FrmBSSOtherDetails"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Other Details"
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRemarks.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAddRM As Telerik.WinControls.UI.RadButton
    Friend WithEvents gvRemarks As Telerik.WinControls.UI.RadGridView
    Friend WithEvents mcbTitle As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtMainID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPOSPID As Telerik.WinControls.UI.RadTextBox
End Class

