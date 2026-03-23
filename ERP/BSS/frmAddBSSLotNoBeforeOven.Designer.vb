<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBSSLotNoBeforeOven
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.txtRMID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnAddRM = New Telerik.WinControls.UI.RadButton()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.txtLotNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.gvRm = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTrayNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTime = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRm.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrayNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.txtTime)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Controls.Add(Me.txtTrayNo)
        Me.z.Controls.Add(Me.RadLabel19)
        Me.z.Controls.Add(Me.txtRMID)
        Me.z.Controls.Add(Me.btnSave)
        Me.z.Controls.Add(Me.btnAddRM)
        Me.z.Controls.Add(Me.txtPartName)
        Me.z.Controls.Add(Me.RadLabel8)
        Me.z.Controls.Add(Me.RadLabel7)
        Me.z.Controls.Add(Me.txtLotNo)
        Me.z.Controls.Add(Me.RadLabel6)
        Me.z.Controls.Add(Me.mcbItemCode)
        Me.z.Controls.Add(Me.gvRm)
        Me.z.Dock = System.Windows.Forms.DockStyle.Fill
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(749, 443)
        Me.z.TabIndex = 134
        Me.z.ThemeName = "Office2007Black"
        '
        'txtRMID
        '
        Me.txtRMID.Location = New System.Drawing.Point(14, 409)
        Me.txtRMID.Name = "txtRMID"
        Me.txtRMID.Size = New System.Drawing.Size(28, 20)
        Me.txtRMID.TabIndex = 154
        Me.txtRMID.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(658, 409)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 24)
        Me.btnSave.TabIndex = 140
        Me.btnSave.Text = "Save"
        '
        'btnAddRM
        '
        Me.btnAddRM.Location = New System.Drawing.Point(518, 141)
        Me.btnAddRM.Name = "btnAddRM"
        Me.btnAddRM.Size = New System.Drawing.Size(45, 19)
        Me.btnAddRM.TabIndex = 139
        Me.btnAddRM.Text = "Add"
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(332, 114)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(179, 20)
        Me.txtPartName.TabIndex = 137
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Location = New System.Drawing.Point(268, 116)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(58, 18)
        Me.RadLabel8.TabIndex = 138
        Me.RadLabel8.Text = "PartName:"
        '
        'RadLabel7
        '
        Me.RadLabel7.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel7.Location = New System.Drawing.Point(32, 140)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(43, 18)
        Me.RadLabel7.TabIndex = 136
        Me.RadLabel7.Text = "Lot No:"
        '
        'txtLotNo
        '
        Me.txtLotNo.Location = New System.Drawing.Point(82, 140)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(430, 20)
        Me.txtLotNo.TabIndex = 135
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Location = New System.Drawing.Point(14, 116)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel6.TabIndex = 134
        Me.RadLabel6.Text = "Item Code:"
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
        Me.mcbItemCode.Location = New System.Drawing.Point(81, 114)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(170, 20)
        Me.mcbItemCode.TabIndex = 133
        Me.mcbItemCode.TabStop = False
        '
        'gvRm
        '
        Me.gvRm.Location = New System.Drawing.Point(8, 166)
        '
        '
        '
        Me.gvRm.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.gvRm.Name = "gvRm"
        Me.gvRm.Size = New System.Drawing.Size(729, 237)
        Me.gvRm.TabIndex = 87
        '
        'RadLabel18
        '
        Me.RadLabel18.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel18.Location = New System.Drawing.Point(27, 36)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(48, 18)
        Me.RadLabel18.TabIndex = 158
        Me.RadLabel18.Text = "Tray No:"
        '
        'txtTrayNo
        '
        Me.txtTrayNo.Enabled = False
        Me.txtTrayNo.Location = New System.Drawing.Point(82, 37)
        Me.txtTrayNo.Multiline = True
        Me.txtTrayNo.Name = "txtTrayNo"
        '
        '
        '
        Me.txtTrayNo.RootElement.StretchVertically = True
        Me.txtTrayNo.Size = New System.Drawing.Size(178, 40)
        Me.txtTrayNo.TabIndex = 157
        '
        'RadLabel19
        '
        Me.RadLabel19.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel19.Location = New System.Drawing.Point(42, 12)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(33, 18)
        Me.RadLabel19.TabIndex = 156
        Me.RadLabel19.Text = "Time:"
        '
        'txtTime
        '
        Me.txtTime.Enabled = False
        Me.txtTime.Location = New System.Drawing.Point(81, 10)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(179, 20)
        Me.txtTime.TabIndex = 160
        '
        'frmAddBSSLotNoBeforeOven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 443)
        Me.Controls.Add(Me.z)
        Me.Name = "frmAddBSSLotNoBeforeOven"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BSS Lot No"
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRm.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrayNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtRMID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAddRM As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtLotNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents gvRm As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTrayNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTime As Telerik.WinControls.UI.RadTextBox
End Class

