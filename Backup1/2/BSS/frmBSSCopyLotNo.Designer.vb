<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSCopyLotNo
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
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbRMIDFrom = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbRMIDTo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.btnSubmit = New Telerik.WinControls.UI.RadButton()
        Me.txtMainID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbRMIDFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbRMIDFrom.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbRMIDFrom.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbRMIDTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbRMIDTo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbRMIDTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.LightGray
        Me.RadPanel1.Controls.Add(Me.txtMainID)
        Me.RadPanel1.Controls.Add(Me.btnSubmit)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.mcbRMIDTo)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.mcbRMIDFrom)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(471, 171)
        Me.RadPanel1.TabIndex = 127
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(57, 37)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(37, 18)
        Me.RadLabel4.TabIndex = 128
        Me.RadLabel4.Text = "RMID:"
        '
        'mcbRMIDFrom
        '
        '
        'mcbRMIDFrom.NestedRadGridView
        '
        Me.mcbRMIDFrom.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbRMIDFrom.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbRMIDFrom.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbRMIDFrom.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbRMIDFrom.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbRMIDFrom.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbRMIDFrom.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbRMIDFrom.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbRMIDFrom.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbRMIDFrom.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbRMIDFrom.EditorControl.Name = "NestedRadGridView"
        Me.mcbRMIDFrom.EditorControl.ReadOnly = True
        Me.mcbRMIDFrom.EditorControl.ShowGroupPanel = False
        Me.mcbRMIDFrom.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbRMIDFrom.EditorControl.TabIndex = 0
        Me.mcbRMIDFrom.Location = New System.Drawing.Point(100, 37)
        Me.mcbRMIDFrom.Name = "mcbRMIDFrom"
        Me.mcbRMIDFrom.NullText = "-- Select Main Process --"
        Me.mcbRMIDFrom.Size = New System.Drawing.Size(359, 20)
        Me.mcbRMIDFrom.TabIndex = 127
        Me.mcbRMIDFrom.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(32, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(116, 18)
        Me.RadLabel1.TabIndex = 129
        Me.RadLabel1.Text = "COPY LOT NO FROM"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(32, 69)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(21, 18)
        Me.RadLabel2.TabIndex = 132
        Me.RadLabel2.Text = "TO"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(57, 93)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(37, 18)
        Me.RadLabel3.TabIndex = 131
        Me.RadLabel3.Text = "RMID:"
        '
        'mcbRMIDTo
        '
        '
        'mcbRMIDTo.NestedRadGridView
        '
        Me.mcbRMIDTo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbRMIDTo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbRMIDTo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbRMIDTo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbRMIDTo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbRMIDTo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbRMIDTo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbRMIDTo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbRMIDTo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbRMIDTo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbRMIDTo.EditorControl.Name = "NestedRadGridView"
        Me.mcbRMIDTo.EditorControl.ReadOnly = True
        Me.mcbRMIDTo.EditorControl.ShowGroupPanel = False
        Me.mcbRMIDTo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbRMIDTo.EditorControl.TabIndex = 0
        Me.mcbRMIDTo.Location = New System.Drawing.Point(100, 93)
        Me.mcbRMIDTo.Name = "mcbRMIDTo"
        Me.mcbRMIDTo.NullText = "-- Select Main Process --"
        Me.mcbRMIDTo.Size = New System.Drawing.Size(359, 20)
        Me.mcbRMIDTo.TabIndex = 130
        Me.mcbRMIDTo.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(32, 135)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(110, 24)
        Me.btnSubmit.TabIndex = 133
        Me.btnSubmit.Text = "Submit"
        '
        'txtMainID
        '
        Me.txtMainID.Location = New System.Drawing.Point(195, 148)
        Me.txtMainID.Name = "txtMainID"
        Me.txtMainID.Size = New System.Drawing.Size(57, 20)
        Me.txtMainID.TabIndex = 134
        Me.txtMainID.Visible = False
        '
        'FrmBSSCopyLotNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 171)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmBSSCopyLotNo"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Duplicate Lot No"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbRMIDFrom.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbRMIDFrom.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbRMIDFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbRMIDTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbRMIDTo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbRMIDTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbRMIDFrom As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbRMIDTo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents btnSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtMainID As Telerik.WinControls.UI.RadTextBox
End Class

