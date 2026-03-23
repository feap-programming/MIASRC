<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSTemplateUpdateBack
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
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.cbRobot = New Telerik.WinControls.UI.RadCheckBox()
        Me.chPCB = New Telerik.WinControls.UI.RadCheckBox()
        Me.chSS = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartNameSub = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemSub = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartNameMain = New Telerik.WinControls.UI.RadTextBox()
        Me.mcbItemCodeBack = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBFID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtBBID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.cbRobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chPCB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartNameSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemSub.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemSub.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartNameMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCodeBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCodeBack.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCodeBack.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBFID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBBID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtBBID)
        Me.RadPanel1.Controls.Add(Me.cbRobot)
        Me.RadPanel1.Controls.Add(Me.chPCB)
        Me.RadPanel1.Controls.Add(Me.chSS)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.txtPartNameSub)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.mcbItemSub)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.txtPartNameMain)
        Me.RadPanel1.Controls.Add(Me.mcbItemCodeBack)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.txtBFID)
        Me.RadPanel1.Controls.Add(Me.btnUpdate)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(359, 331)
        Me.RadPanel1.TabIndex = 37
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'cbRobot
        '
        Me.cbRobot.Location = New System.Drawing.Point(251, 221)
        Me.cbRobot.Name = "cbRobot"
        Me.cbRobot.Size = New System.Drawing.Size(82, 18)
        Me.cbRobot.TabIndex = 205
        Me.cbRobot.Text = "With Robot?"
        Me.cbRobot.ThemeName = "ControlDefault"
        '
        'chPCB
        '
        Me.chPCB.Location = New System.Drawing.Point(144, 221)
        Me.chPCB.Name = "chPCB"
        Me.chPCB.Size = New System.Drawing.Size(84, 18)
        Me.chPCB.TabIndex = 204
        Me.chPCB.Text = "PCB Dividing"
        Me.chPCB.ThemeName = "ControlDefault"
        '
        'chSS
        '
        Me.chSS.Location = New System.Drawing.Point(10, 221)
        Me.chSS.Name = "chSS"
        Me.chSS.Size = New System.Drawing.Size(103, 18)
        Me.chSS.TabIndex = 203
        Me.chSS.Text = "Solder Assembly"
        Me.chSS.ThemeName = "ControlDefault"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(12, 167)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(125, 18)
        Me.RadLabel4.TabIndex = 202
        Me.RadLabel4.Text = "Part Name Sub Process:"
        '
        'txtPartNameSub
        '
        Me.txtPartNameSub.Enabled = False
        Me.txtPartNameSub.Location = New System.Drawing.Point(11, 191)
        Me.txtPartNameSub.Name = "txtPartNameSub"
        Me.txtPartNameSub.Size = New System.Drawing.Size(280, 20)
        Me.txtPartNameSub.TabIndex = 201
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(12, 115)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(122, 18)
        Me.RadLabel2.TabIndex = 200
        Me.RadLabel2.Text = "Item Code sub Process:"
        '
        'mcbItemSub
        '
        '
        'mcbItemSub.NestedRadGridView
        '
        Me.mcbItemSub.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbItemSub.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbItemSub.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbItemSub.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbItemSub.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbItemSub.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbItemSub.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbItemSub.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbItemSub.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbItemSub.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbItemSub.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemSub.EditorControl.ReadOnly = True
        Me.mcbItemSub.EditorControl.ShowGroupPanel = False
        Me.mcbItemSub.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemSub.EditorControl.TabIndex = 0
        Me.mcbItemSub.Location = New System.Drawing.Point(12, 139)
        Me.mcbItemSub.Name = "mcbItemSub"
        Me.mcbItemSub.Size = New System.Drawing.Size(279, 20)
        Me.mcbItemSub.TabIndex = 199
        Me.mcbItemSub.TabStop = False
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(11, 65)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(131, 18)
        Me.RadLabel6.TabIndex = 198
        Me.RadLabel6.Text = "Part Name Main Process:"
        '
        'txtPartNameMain
        '
        Me.txtPartNameMain.Enabled = False
        Me.txtPartNameMain.Location = New System.Drawing.Point(12, 89)
        Me.txtPartNameMain.Name = "txtPartNameMain"
        Me.txtPartNameMain.Size = New System.Drawing.Size(279, 20)
        Me.txtPartNameMain.TabIndex = 196
        '
        'mcbItemCodeBack
        '
        '
        'mcbItemCodeBack.NestedRadGridView
        '
        Me.mcbItemCodeBack.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbItemCodeBack.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbItemCodeBack.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbItemCodeBack.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbItemCodeBack.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbItemCodeBack.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbItemCodeBack.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbItemCodeBack.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbItemCodeBack.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbItemCodeBack.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbItemCodeBack.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCodeBack.EditorControl.ReadOnly = True
        Me.mcbItemCodeBack.EditorControl.ShowGroupPanel = False
        Me.mcbItemCodeBack.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCodeBack.EditorControl.TabIndex = 0
        Me.mcbItemCodeBack.Enabled = False
        Me.mcbItemCodeBack.Location = New System.Drawing.Point(12, 33)
        Me.mcbItemCodeBack.Name = "mcbItemCodeBack"
        Me.mcbItemCodeBack.Size = New System.Drawing.Size(279, 20)
        Me.mcbItemCodeBack.TabIndex = 195
        Me.mcbItemCodeBack.TabStop = False
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(12, 9)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(130, 18)
        Me.RadLabel5.TabIndex = 197
        Me.RadLabel5.Text = "Item Code Main Process:"
        '
        'txtBFID
        '
        Me.txtBFID.Location = New System.Drawing.Point(229, 286)
        Me.txtBFID.Name = "txtBFID"
        Me.txtBFID.Size = New System.Drawing.Size(62, 20)
        Me.txtBFID.TabIndex = 194
        Me.txtBFID.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 286)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        '
        'txtBBID
        '
        Me.txtBBID.Location = New System.Drawing.Point(229, 260)
        Me.txtBBID.Name = "txtBBID"
        Me.txtBBID.Size = New System.Drawing.Size(62, 20)
        Me.txtBBID.TabIndex = 206
        Me.txtBBID.Visible = False
        '
        'FrmBSSTemplateUpdateBack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 331)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmBSSTemplateUpdateBack"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BSS Template Update Back"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.cbRobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chPCB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartNameSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemSub.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemSub.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartNameMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCodeBack.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCodeBack.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCodeBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBFID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBBID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtBFID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartNameMain As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mcbItemCodeBack As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemSub As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartNameSub As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cbRobot As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chPCB As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chSS As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents txtBBID As Telerik.WinControls.UI.RadTextBox
End Class

