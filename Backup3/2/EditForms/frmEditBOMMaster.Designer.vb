<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditBOMMaster
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
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.seUsage = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.mcbChild = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbParent = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnContinue = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbChild.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbChild.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbParent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbParent.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbParent.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Location = New System.Drawing.Point(68, 69)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(40, 18)
        Me.RadLabel4.TabIndex = 29
        Me.RadLabel4.Text = "Usage:"
        '
        'seUsage
        '
        Me.seUsage.DecimalPlaces = 6
        Me.seUsage.Location = New System.Drawing.Point(114, 67)
        Me.seUsage.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seUsage.Name = "seUsage"
        Me.seUsage.ShowUpDownButtons = False
        Me.seUsage.Size = New System.Drawing.Size(143, 20)
        Me.seUsage.TabIndex = 24
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(57, 95)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel3.TabIndex = 28
        Me.RadLabel3.Text = "Remarks:"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(30, 43)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 18)
        Me.RadLabel1.TabIndex = 27
        Me.RadLabel1.Text = "Child Part No.:"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(23, 17)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(85, 18)
        Me.RadLabel2.TabIndex = 26
        Me.RadLabel2.Text = "Parent Part No.:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(114, 93)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(300, 20)
        Me.txtRemarks.TabIndex = 25
        '
        'mcbChild
        '
        '
        'mcbChild.NestedRadGridView
        '
        Me.mcbChild.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbChild.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbChild.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbChild.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbChild.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbChild.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbChild.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbChild.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbChild.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbChild.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbChild.EditorControl.Name = "NestedRadGridView"
        Me.mcbChild.EditorControl.ReadOnly = True
        Me.mcbChild.EditorControl.ShowGroupPanel = False
        Me.mcbChild.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbChild.EditorControl.TabIndex = 0
        Me.mcbChild.Location = New System.Drawing.Point(114, 41)
        Me.mcbChild.Name = "mcbChild"
        Me.mcbChild.Size = New System.Drawing.Size(300, 20)
        Me.mcbChild.TabIndex = 23
        Me.mcbChild.TabStop = False
        '
        'mcbParent
        '
        '
        'mcbParent.NestedRadGridView
        '
        Me.mcbParent.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbParent.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbParent.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbParent.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbParent.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbParent.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbParent.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbParent.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbParent.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbParent.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbParent.EditorControl.Name = "NestedRadGridView"
        Me.mcbParent.EditorControl.ReadOnly = True
        Me.mcbParent.EditorControl.ShowGroupPanel = False
        Me.mcbParent.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbParent.EditorControl.TabIndex = 0
        Me.mcbParent.Location = New System.Drawing.Point(114, 15)
        Me.mcbParent.Name = "mcbParent"
        Me.mcbParent.Size = New System.Drawing.Size(300, 20)
        Me.mcbParent.TabIndex = 22
        Me.mcbParent.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(228, 134)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(103, 134)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(110, 24)
        Me.btnContinue.TabIndex = 36
        Me.btnContinue.Text = "Continue"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(373, 134)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(19, 20)
        Me.txtID.TabIndex = 35
        Me.txtID.Visible = False
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.mcbParent)
        Me.RadPanel1.Controls.Add(Me.btnCancel)
        Me.RadPanel1.Controls.Add(Me.mcbChild)
        Me.RadPanel1.Controls.Add(Me.btnContinue)
        Me.RadPanel1.Controls.Add(Me.txtRemarks)
        Me.RadPanel1.Controls.Add(Me.txtID)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.seUsage)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(438, 178)
        Me.RadPanel1.TabIndex = 38
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'FrmEditBOMMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 178)
        Me.Controls.Add(Me.RadPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEditBOMMaster"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edir BOM Master"
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seUsage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbChild.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbChild.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbParent.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbParent.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbParent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seUsage As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mcbChild As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbParent As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnContinue As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
End Class

