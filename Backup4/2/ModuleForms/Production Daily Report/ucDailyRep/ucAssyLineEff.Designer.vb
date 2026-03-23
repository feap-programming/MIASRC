<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAssyLineEff
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAssyLineEff))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbSave = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbClear = New Telerik.WinControls.UI.CommandBarButton()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.btnEdit = New System.Windows.Forms.PictureBox()
        Me.spnUnplanDT = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.spnPlanDT = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.spnHotto = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.tbCycleTime = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.tbOpTime = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.tbTimePartition = New Telerik.WinControls.UI.RadTextBox()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnUnplanDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnPlanDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHotto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCycleTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOpTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTimePartition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(858, 57)
        Me.RadCommandBar1.TabIndex = 14
        Me.RadCommandBar1.ThemeName = "CrystalDark"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        Me.CommandBarRowElement1.Text = ""
        Me.CommandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.UseCompatibleTextRendering = False
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.DisplayName = "Control Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbSave, Me.cbbClear})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'cbbSave
        '
        Me.cbbSave.AutoSize = False
        Me.cbbSave.Bounds = New System.Drawing.Rectangle(0, 0, 99, 52)
        Me.cbbSave.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbSave.DisplayName = "Add Record"
        Me.cbbSave.DrawText = True
        Me.cbbSave.Image = CType(resources.GetObject("cbbSave.Image"), System.Drawing.Image)
        Me.cbbSave.Name = "cbbSave"
        Me.cbbSave.Text = "Save"
        Me.cbbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbSave.UseCompatibleTextRendering = False
        '
        'cbbClear
        '
        Me.cbbClear.AutoSize = False
        Me.cbbClear.Bounds = New System.Drawing.Rectangle(0, 0, 99, 52)
        Me.cbbClear.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbClear.DisplayName = "Delete Record"
        Me.cbbClear.DrawText = True
        Me.cbbClear.Image = CType(resources.GetObject("cbbClear.Image"), System.Drawing.Image)
        Me.cbbClear.Name = "cbbClear"
        Me.cbbClear.Text = "Clear Input"
        Me.cbbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbClear.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbClear.UseCompatibleTextRendering = False
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 202)
        '
        '
        '
        Me.gvData.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.gvData.MasterTemplate.AllowDeleteRow = False
        Me.gvData.MasterTemplate.AllowDragToGroup = False
        Me.gvData.MasterTemplate.EnableSorting = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.gvData.Size = New System.Drawing.Size(858, 314)
        Me.gvData.TabIndex = 15
        Me.gvData.ThemeName = "CrystalDark"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.btnEdit)
        Me.RadPanel1.Controls.Add(Me.spnUnplanDT)
        Me.RadPanel1.Controls.Add(Me.RadLabel7)
        Me.RadPanel1.Controls.Add(Me.spnPlanDT)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.spnHotto)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.tbCycleTime)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.tbOpTime)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.tbTimePartition)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 57)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(858, 145)
        Me.RadPanel1.TabIndex = 16
        Me.RadPanel1.ThemeName = "CrystalDark"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(274, 39)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(21, 19)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.TabStop = False
        '
        'spnUnplanDT
        '
        Me.spnUnplanDT.BackColor = System.Drawing.Color.Silver
        Me.spnUnplanDT.Location = New System.Drawing.Point(456, 108)
        Me.spnUnplanDT.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnUnplanDT.Minimum = New Decimal(New Integer() {999999999, 0, 0, -2147483648})
        Me.spnUnplanDT.Name = "spnUnplanDT"
        Me.spnUnplanDT.ReadOnly = True
        Me.spnUnplanDT.Size = New System.Drawing.Size(137, 20)
        Me.spnUnplanDT.TabIndex = 16
        Me.spnUnplanDT.ThemeName = "Office2007Black"
        '
        'RadLabel7
        '
        Me.RadLabel7.ForeColor = System.Drawing.Color.White
        Me.RadLabel7.Location = New System.Drawing.Point(331, 110)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(118, 18)
        Me.RadLabel7.TabIndex = 15
        Me.RadLabel7.Text = "Unplanned Downtime:"
        '
        'spnPlanDT
        '
        Me.spnPlanDT.BackColor = System.Drawing.Color.Silver
        Me.spnPlanDT.Location = New System.Drawing.Point(456, 73)
        Me.spnPlanDT.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnPlanDT.Name = "spnPlanDT"
        Me.spnPlanDT.ReadOnly = True
        Me.spnPlanDT.Size = New System.Drawing.Size(137, 20)
        Me.spnPlanDT.TabIndex = 14
        Me.spnPlanDT.ThemeName = "Office2007Black"
        '
        'RadLabel6
        '
        Me.RadLabel6.ForeColor = System.Drawing.Color.White
        Me.RadLabel6.Location = New System.Drawing.Point(346, 75)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(103, 18)
        Me.RadLabel6.TabIndex = 13
        Me.RadLabel6.Text = "Planned Downtime:"
        '
        'spnHotto
        '
        Me.spnHotto.Location = New System.Drawing.Point(456, 38)
        Me.spnHotto.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnHotto.Name = "spnHotto"
        Me.spnHotto.Size = New System.Drawing.Size(137, 20)
        Me.spnHotto.TabIndex = 12
        Me.spnHotto.ThemeName = "Office2007Black"
        '
        'RadLabel5
        '
        Me.RadLabel5.ForeColor = System.Drawing.Color.White
        Me.RadLabel5.Location = New System.Drawing.Point(360, 40)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(90, 18)
        Me.RadLabel5.TabIndex = 11
        Me.RadLabel5.Text = "5's, Hotto, Break:"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.ForeColor = System.Drawing.Color.White
        Me.RadLabel4.Location = New System.Drawing.Point(319, 16)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(111, 21)
        Me.RadLabel4.TabIndex = 10
        Me.RadLabel4.Text = "Interuption Time:"
        '
        'RadLabel3
        '
        Me.RadLabel3.ForeColor = System.Drawing.Color.White
        Me.RadLabel3.Location = New System.Drawing.Point(50, 110)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(62, 18)
        Me.RadLabel3.TabIndex = 9
        Me.RadLabel3.Text = "Cycle Time:"
        '
        'tbCycleTime
        '
        Me.tbCycleTime.BackColor = System.Drawing.Color.Silver
        Me.tbCycleTime.Location = New System.Drawing.Point(120, 109)
        Me.tbCycleTime.Name = "tbCycleTime"
        Me.tbCycleTime.ReadOnly = True
        Me.tbCycleTime.Size = New System.Drawing.Size(151, 20)
        Me.tbCycleTime.TabIndex = 8
        Me.tbCycleTime.ThemeName = "Office2007Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(27, 75)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(87, 18)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "Operation Time:"
        '
        'tbOpTime
        '
        Me.tbOpTime.BackColor = System.Drawing.Color.Silver
        Me.tbOpTime.Location = New System.Drawing.Point(120, 74)
        Me.tbOpTime.Name = "tbOpTime"
        Me.tbOpTime.ReadOnly = True
        Me.tbOpTime.Size = New System.Drawing.Size(151, 20)
        Me.tbOpTime.TabIndex = 6
        Me.tbOpTime.ThemeName = "Office2007Black"
        '
        'RadLabel2
        '
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(12, 40)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(102, 18)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "Line Time Partition:"
        '
        'tbTimePartition
        '
        Me.tbTimePartition.BackColor = System.Drawing.Color.Silver
        Me.tbTimePartition.Location = New System.Drawing.Point(120, 39)
        Me.tbTimePartition.Name = "tbTimePartition"
        Me.tbTimePartition.ReadOnly = True
        Me.tbTimePartition.Size = New System.Drawing.Size(151, 20)
        Me.tbTimePartition.TabIndex = 4
        Me.tbTimePartition.ThemeName = "Office2007Black"
        '
        'ucAssyLineEff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "ucAssyLineEff"
        Me.Size = New System.Drawing.Size(858, 516)
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnUnplanDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnPlanDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHotto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCycleTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOpTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTimePartition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbSave As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbClear As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbCycleTime As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbOpTime As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbTimePartition As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents spnUnplanDT As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnPlanDT As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnHotto As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents btnEdit As PictureBox
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
End Class
