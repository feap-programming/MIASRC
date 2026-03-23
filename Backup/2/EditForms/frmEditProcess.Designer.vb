<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditProcess
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.sePriority = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtProcessName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCode = New Telerik.WinControls.UI.RadTextBox()
        Me.btnContinue = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.mcbColor = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.chkHideInBOM = New Telerik.WinControls.UI.RadCheckBox()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbColor.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbColor.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.chkHideInBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Location = New System.Drawing.Point(54, 66)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(44, 18)
        Me.RadLabel4.TabIndex = 30
        Me.RadLabel4.Text = "Priority:"
        '
        'sePriority
        '
        Me.sePriority.Location = New System.Drawing.Point(104, 64)
        Me.sePriority.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.sePriority.Name = "sePriority"
        Me.sePriority.ShowUpDownButtons = False
        Me.sePriority.Size = New System.Drawing.Size(136, 20)
        Me.sePriority.TabIndex = 2
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(62, 92)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(36, 18)
        Me.RadLabel3.TabIndex = 29
        Me.RadLabel3.Text = "Color:"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(19, 40)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(79, 18)
        Me.RadLabel1.TabIndex = 28
        Me.RadLabel1.Text = "Process Name:"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(63, 14)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(35, 18)
        Me.RadLabel2.TabIndex = 27
        Me.RadLabel2.Text = "Code:"
        '
        'txtProcessName
        '
        Me.txtProcessName.Location = New System.Drawing.Point(104, 38)
        Me.txtProcessName.Name = "txtProcessName"
        Me.txtProcessName.Size = New System.Drawing.Size(397, 20)
        Me.txtProcessName.TabIndex = 1
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(104, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(136, 20)
        Me.txtCode.TabIndex = 0
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(155, 157)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(110, 24)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.Text = "Continue"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(280, 157)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(33, 159)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(38, 20)
        Me.txtID.TabIndex = 33
        Me.txtID.Visible = False
        '
        'mcbColor
        '
        '
        'mcbColor.NestedRadGridView
        '
        Me.mcbColor.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbColor.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbColor.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbColor.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbColor.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbColor.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbColor.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbColor.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbColor.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbColor.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbColor.EditorControl.Name = "NestedRadGridView"
        Me.mcbColor.EditorControl.ReadOnly = True
        Me.mcbColor.EditorControl.ShowGroupPanel = False
        Me.mcbColor.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbColor.EditorControl.TabIndex = 0
        Me.mcbColor.Location = New System.Drawing.Point(104, 90)
        Me.mcbColor.Name = "mcbColor"
        Me.mcbColor.Size = New System.Drawing.Size(136, 20)
        Me.mcbColor.TabIndex = 3
        Me.mcbColor.TabStop = False
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.chkHideInBOM)
        Me.RadPanel1.Controls.Add(Me.txtCode)
        Me.RadPanel1.Controls.Add(Me.mcbColor)
        Me.RadPanel1.Controls.Add(Me.txtProcessName)
        Me.RadPanel1.Controls.Add(Me.txtID)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.btnCancel)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.btnContinue)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.sePriority)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(520, 201)
        Me.RadPanel1.TabIndex = 35
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'chkHideInBOM
        '
        Me.chkHideInBOM.Location = New System.Drawing.Point(104, 116)
        Me.chkHideInBOM.Name = "chkHideInBOM"
        Me.chkHideInBOM.Size = New System.Drawing.Size(84, 18)
        Me.chkHideInBOM.TabIndex = 4
        Me.chkHideInBOM.Text = "Hide in BOM"
        '
        'FrmEditProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 201)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(528, 231)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(528, 231)
        Me.Name = "FrmEditProcess"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Process"
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbColor.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbColor.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.chkHideInBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents sePriority As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtProcessName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnContinue As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mcbColor As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents chkHideInBOM As Telerik.WinControls.UI.RadCheckBox
End Class

