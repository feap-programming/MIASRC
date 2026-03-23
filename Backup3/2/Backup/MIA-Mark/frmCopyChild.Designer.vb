<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCopyChild
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
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbParent = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.btnContinue = New Telerik.WinControls.UI.RadButton()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbParent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbParent.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbParent.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 417)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(653, 29)
        Me.RadStatusStrip1.TabIndex = 0
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Records Found:"
        Me.RadLabelElement1.TextWrap = True
        '
        'leCountRec
        '
        Me.leCountRec.Name = "leCountRec"
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, True)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        Me.leCountRec.UseCompatibleTextRendering = False
        '
        'RadProgressBarElement1
        '
        Me.RadProgressBarElement1.AutoSize = False
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 21)
        Me.RadProgressBarElement1.Name = "RadProgressBarElement1"
        Me.RadProgressBarElement1.SeparatorColor1 = System.Drawing.Color.White
        Me.RadProgressBarElement1.SeparatorColor2 = System.Drawing.Color.White
        Me.RadProgressBarElement1.SeparatorColor3 = System.Drawing.Color.White
        Me.RadProgressBarElement1.SeparatorColor4 = System.Drawing.Color.White
        Me.RadProgressBarElement1.SeparatorGradientAngle = 0
        Me.RadProgressBarElement1.SeparatorGradientPercentage1 = 0.4!
        Me.RadProgressBarElement1.SeparatorGradientPercentage2 = 0.6!
        Me.RadProgressBarElement1.SeparatorNumberOfColors = 2
        Me.RadStatusStrip1.SetSpring(Me.RadProgressBarElement1, False)
        Me.RadProgressBarElement1.StepWidth = 14
        Me.RadProgressBarElement1.SweepAngle = 90
        Me.RadProgressBarElement1.Text = ""
        '
        'gvData
        '
        Me.gvData.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gvData.Location = New System.Drawing.Point(12, 50)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(637, 358)
        Me.gvData.TabIndex = 1
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(13, 17)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(85, 18)
        Me.RadLabel2.TabIndex = 19
        Me.RadLabel2.Text = "Parent Part No.:"
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
        Me.mcbParent.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbParent.EditorControl.Name = "NestedRadGridView"
        Me.mcbParent.EditorControl.ReadOnly = True
        Me.mcbParent.EditorControl.ShowGroupPanel = False
        Me.mcbParent.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbParent.EditorControl.TabIndex = 0
        Me.mcbParent.Location = New System.Drawing.Point(104, 15)
        Me.mcbParent.Name = "mcbParent"
        Me.mcbParent.Size = New System.Drawing.Size(186, 20)
        Me.mcbParent.TabIndex = 18
        Me.mcbParent.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(311, 11)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(110, 24)
        Me.btnContinue.TabIndex = 34
        Me.btnContinue.Text = "Continue"
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'FrmCopyChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(653, 446)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.mcbParent)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(661, 476)
        Me.MinimumSize = New System.Drawing.Size(661, 476)
        Me.Name = "FrmCopyChild"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(661, 476)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copy Child"
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbParent.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbParent.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbParent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbParent As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents btnContinue As Telerik.WinControls.UI.RadButton
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
End Class

