<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSSample
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
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.gvSample = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.seScrap = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.seQASampleNormal = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.seQASampleAdd = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.seEngSampleAdj = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seEngSampleSS = New Telerik.WinControls.UI.RadSpinEditor()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtRMID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnAddRM = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSample.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seScrap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQASampleNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seQASampleAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seEngSampleAdj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seEngSampleSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(341, 17)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(190, 20)
        Me.txtPartName.TabIndex = 2
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel8.Location = New System.Drawing.Point(277, 19)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(58, 18)
        Me.RadLabel8.TabIndex = 171
        Me.RadLabel8.Text = "PartName:"
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel6.Location = New System.Drawing.Point(23, 19)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel6.TabIndex = 167
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(90, 17)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(172, 20)
        Me.mcbItemCode.TabIndex = 1
        Me.mcbItemCode.TabStop = False
        '
        'gvSample
        '
        Me.gvSample.Dock = System.Windows.Forms.DockStyle.Top
        Me.gvSample.Location = New System.Drawing.Point(0, 144)
        '
        '
        '
        Me.gvSample.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvSample.Name = "gvSample"
        Me.gvSample.Size = New System.Drawing.Size(1164, 369)
        Me.gvSample.TabIndex = 165
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel1.Location = New System.Drawing.Point(111, 43)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel1.TabIndex = 173
        Me.RadLabel1.Text = "Scrap Qty:"
        '
        'seScrap
        '
        Me.seScrap.DecimalPlaces = 4
        Me.seScrap.EnableNullValueInput = True
        Me.seScrap.Location = New System.Drawing.Point(174, 43)
        Me.seScrap.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seScrap.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seScrap.Name = "seScrap"
        Me.seScrap.ShowUpDownButtons = False
        Me.seScrap.Size = New System.Drawing.Size(88, 20)
        Me.seScrap.TabIndex = 3
        Me.seScrap.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seScrap.ThousandsSeparator = True
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel2.Location = New System.Drawing.Point(25, 71)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(143, 18)
        Me.RadLabel2.TabIndex = 175
        Me.RadLabel2.Text = "QA ( QC ) Sample (Normal):"
        '
        'seQASampleNormal
        '
        Me.seQASampleNormal.DecimalPlaces = 4
        Me.seQASampleNormal.EnableNullValueInput = True
        Me.seQASampleNormal.Location = New System.Drawing.Point(174, 69)
        Me.seQASampleNormal.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seQASampleNormal.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seQASampleNormal.Name = "seQASampleNormal"
        Me.seQASampleNormal.ShowUpDownButtons = False
        Me.seQASampleNormal.Size = New System.Drawing.Size(88, 20)
        Me.seQASampleNormal.TabIndex = 4
        Me.seQASampleNormal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seQASampleNormal.ThousandsSeparator = True
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel3.Location = New System.Drawing.Point(10, 97)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(158, 18)
        Me.RadLabel3.TabIndex = 175
        Me.RadLabel3.Text = "QA ( QC ) Sample (Additional):"
        '
        'seQASampleAdd
        '
        Me.seQASampleAdd.DecimalPlaces = 4
        Me.seQASampleAdd.EnableNullValueInput = True
        Me.seQASampleAdd.Location = New System.Drawing.Point(174, 95)
        Me.seQASampleAdd.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seQASampleAdd.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seQASampleAdd.Name = "seQASampleAdd"
        Me.seQASampleAdd.ShowUpDownButtons = False
        Me.seQASampleAdd.Size = New System.Drawing.Size(88, 20)
        Me.seQASampleAdd.TabIndex = 5
        Me.seQASampleAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seQASampleAdd.ThousandsSeparator = True
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel4.Location = New System.Drawing.Point(295, 97)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(142, 18)
        Me.RadLabel4.TabIndex = 178
        Me.RadLabel4.Text = "Eng'r Sample (Adjustment):"
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel5.Location = New System.Drawing.Point(277, 70)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(163, 18)
        Me.RadLabel5.TabIndex = 179
        Me.RadLabel5.Text = "Eng'r Sample (Start-up/Set-up):"
        '
        'seEngSampleAdj
        '
        Me.seEngSampleAdj.DecimalPlaces = 4
        Me.seEngSampleAdj.EnableNullValueInput = True
        Me.seEngSampleAdj.Location = New System.Drawing.Point(443, 95)
        Me.seEngSampleAdj.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seEngSampleAdj.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seEngSampleAdj.Name = "seEngSampleAdj"
        Me.seEngSampleAdj.ShowUpDownButtons = False
        Me.seEngSampleAdj.Size = New System.Drawing.Size(88, 20)
        Me.seEngSampleAdj.TabIndex = 7
        Me.seEngSampleAdj.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seEngSampleAdj.ThousandsSeparator = True
        '
        'seEngSampleSS
        '
        Me.seEngSampleSS.DecimalPlaces = 4
        Me.seEngSampleSS.EnableNullValueInput = True
        Me.seEngSampleSS.Location = New System.Drawing.Point(443, 68)
        Me.seEngSampleSS.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seEngSampleSS.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seEngSampleSS.Name = "seEngSampleSS"
        Me.seEngSampleSS.ShowUpDownButtons = False
        Me.seEngSampleSS.Size = New System.Drawing.Size(88, 20)
        Me.seEngSampleSS.TabIndex = 6
        Me.seEngSampleSS.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seEngSampleSS.ThousandsSeparator = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(546, 68)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        '
        '
        '
        Me.txtRemarks.RootElement.StretchVertically = True
        Me.txtRemarks.Size = New System.Drawing.Size(179, 47)
        Me.txtRemarks.TabIndex = 8
        '
        'RadLabel7
        '
        Me.RadLabel7.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel7.Location = New System.Drawing.Point(546, 45)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel7.TabIndex = 180
        Me.RadLabel7.Text = "Remarks:"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.LightGray
        Me.RadPanel1.Controls.Add(Me.txtRMID)
        Me.RadPanel1.Controls.Add(Me.btnAddRM)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1164, 144)
        Me.RadPanel1.TabIndex = 181
        '
        'txtRMID
        '
        Me.txtRMID.Location = New System.Drawing.Point(6, 121)
        Me.txtRMID.Name = "txtRMID"
        Me.txtRMID.Size = New System.Drawing.Size(28, 20)
        Me.txtRMID.TabIndex = 155
        Me.txtRMID.Visible = False
        '
        'btnAddRM
        '
        Me.btnAddRM.Location = New System.Drawing.Point(674, 118)
        Me.btnAddRM.Name = "btnAddRM"
        Me.btnAddRM.Size = New System.Drawing.Size(45, 19)
        Me.btnAddRM.TabIndex = 140
        Me.btnAddRM.Text = "Add"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1085, 521)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 24)
        Me.btnSave.TabIndex = 182
        Me.btnSave.Text = "Save"
        '
        'FrmBSSSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 550)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.RadLabel7)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.seEngSampleAdj)
        Me.Controls.Add(Me.seEngSampleSS)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.seQASampleAdd)
        Me.Controls.Add(Me.seQASampleNormal)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.seScrap)
        Me.Controls.Add(Me.txtPartName)
        Me.Controls.Add(Me.RadLabel8)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.mcbItemCode)
        Me.Controls.Add(Me.gvSample)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmBSSSample"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BSS SAMPLE"
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSample.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seScrap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQASampleNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seQASampleAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seEngSampleAdj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seEngSampleSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents gvSample As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seScrap As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seQASampleNormal As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seQASampleAdd As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seEngSampleAdj As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seEngSampleSS As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnAddRM As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtRMID As Telerik.WinControls.UI.RadTextBox
End Class

