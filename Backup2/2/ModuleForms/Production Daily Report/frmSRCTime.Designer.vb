<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSRCTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSRCTime))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.panelMore = New Telerik.WinControls.UI.RadPanel()
        Me.ddITType = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblType = New System.Windows.Forms.Label()
        Me.tpTo = New Telerik.WinControls.UI.RadTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.tpFrom = New Telerik.WinControls.UI.RadTimePicker()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.Nyani = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        CType(Me.panelMore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMore.SuspendLayout()
        CType(Me.ddITType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMore
        '
        Me.panelMore.AutoScroll = True
        Me.panelMore.BackColor = System.Drawing.Color.LightGray
        Me.panelMore.Controls.Add(Me.ddITType)
        Me.panelMore.Controls.Add(Me.lblType)
        Me.panelMore.Controls.Add(Me.tpTo)
        Me.panelMore.Controls.Add(Me.RadLabel3)
        Me.panelMore.Controls.Add(Me.RadLabel2)
        Me.panelMore.Controls.Add(Me.tpFrom)
        Me.panelMore.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMore.Location = New System.Drawing.Point(0, 0)
        Me.panelMore.Name = "panelMore"
        Me.panelMore.Size = New System.Drawing.Size(507, 45)
        Me.panelMore.TabIndex = 11
        Me.panelMore.ThemeName = "Office2007Black"
        '
        'ddITType
        '
        Me.ddITType.DropDownAnimationEnabled = True
        Me.ddITType.Location = New System.Drawing.Point(365, 11)
        Me.ddITType.Name = "ddITType"
        Me.ddITType.Size = New System.Drawing.Size(102, 20)
        Me.ddITType.TabIndex = 128
        Me.ddITType.Text = "RadDropDownList1"
        Me.ddITType.ThemeName = "Office2007Black"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.Location = New System.Drawing.Point(332, 14)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(30, 13)
        Me.lblType.TabIndex = 127
        Me.lblType.Text = "TM -"
        '
        'tpTo
        '
        Me.tpTo.Location = New System.Drawing.Point(211, 12)
        Me.tpTo.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.tpTo.MinValue = New Date(CType(0, Long))
        Me.tpTo.Name = "tpTo"
        Me.tpTo.Size = New System.Drawing.Size(104, 20)
        Me.tpTo.TabIndex = 126
        Me.tpTo.TabStop = False
        Me.tpTo.ThemeName = "Office2007Black"
        Me.tpTo.Value = New Date(2024, 1, 4, 8, 43, 17, 290)
        CType(Me.tpTo.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.tpTo.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadTimeElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel3
        '
        Me.RadLabel3.ForeColor = System.Drawing.Color.Black
        Me.RadLabel3.Location = New System.Drawing.Point(186, 13)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(19, 18)
        Me.RadLabel3.TabIndex = 125
        Me.RadLabel3.Text = "To"
        '
        'RadLabel2
        '
        Me.RadLabel2.ForeColor = System.Drawing.Color.Black
        Me.RadLabel2.Location = New System.Drawing.Point(11, 13)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(62, 18)
        Me.RadLabel2.TabIndex = 124
        Me.RadLabel2.Text = "Time From:"
        '
        'tpFrom
        '
        Me.tpFrom.Location = New System.Drawing.Point(76, 12)
        Me.tpFrom.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.tpFrom.MinValue = New Date(CType(0, Long))
        Me.tpFrom.Name = "tpFrom"
        Me.tpFrom.Size = New System.Drawing.Size(104, 20)
        Me.tpFrom.TabIndex = 123
        Me.tpFrom.TabStop = False
        Me.tpFrom.ThemeName = "Office2007Black"
        Me.tpFrom.Value = New Date(2024, 1, 4, 8, 43, 17, 290)
        CType(Me.tpFrom.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.tpFrom.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadTimeElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 45)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(507, 82)
        Me.RadCommandBar1.TabIndex = 13
        Me.RadCommandBar1.ThemeName = "CrystalDark"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.Nyani})
        Me.CommandBarRowElement1.Text = ""
        Me.CommandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowElement1.UseCompatibleTextRendering = False
        '
        'Nyani
        '
        Me.Nyani.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Nyani.DisplayName = "Control Bar"
        Me.Nyani.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbDelete, Me.CommandBarSeparator2})
        Me.Nyani.Name = "Nyani"
        Me.Nyani.StretchHorizontally = True
        Me.Nyani.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Nyani.UseCompatibleTextRendering = False
        '
        'cbbRefresh
        '
        Me.cbbRefresh.AutoSize = False
        Me.cbbRefresh.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbRefresh.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbRefresh.DisplayName = "Refresh"
        Me.cbbRefresh.DrawText = True
        Me.cbbRefresh.Image = CType(resources.GetObject("cbbRefresh.Image"), System.Drawing.Image)
        Me.cbbRefresh.Name = "cbbRefresh"
        Me.cbbRefresh.Text = "Refresh"
        Me.cbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbRefresh.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbRefresh.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.DisplayName = "Separator 1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator1.UseCompatibleTextRendering = False
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cbbAdd
        '
        Me.cbbAdd.AutoSize = False
        Me.cbbAdd.Bounds = New System.Drawing.Rectangle(0, 0, 90, 52)
        Me.cbbAdd.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAdd.DisplayName = "Add Record"
        Me.cbbAdd.DrawText = True
        Me.cbbAdd.Image = CType(resources.GetObject("cbbAdd.Image"), System.Drawing.Image)
        Me.cbbAdd.Name = "cbbAdd"
        Me.cbbAdd.Text = "Add Record"
        Me.cbbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbAdd.UseCompatibleTextRendering = False
        '
        'cbbDelete
        '
        Me.cbbDelete.AutoSize = False
        Me.cbbDelete.Bounds = New System.Drawing.Rectangle(0, 0, 95, 52)
        Me.cbbDelete.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDelete.DisplayName = "Delete Record"
        Me.cbbDelete.DrawText = True
        Me.cbbDelete.Image = CType(resources.GetObject("cbbDelete.Image"), System.Drawing.Image)
        Me.cbbDelete.Name = "cbbDelete"
        Me.cbbDelete.Text = "Delete Record"
        Me.cbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbDelete.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.UseCompatibleTextRendering = False
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 127)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.AllowDeleteRow = False
        Me.gvData.MasterTemplate.AllowDragToGroup = False
        Me.gvData.MasterTemplate.AllowEditRow = False
        Me.gvData.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gvData.MasterTemplate.MultiSelect = True
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(507, 483)
        Me.gvData.TabIndex = 14
        Me.gvData.ThemeName = "CrystalDark"
        '
        'FrmSRCTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 610)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.panelMore)
        Me.Name = "FrmSRCTime"
        Me.Text = "TIME RANGE"
        Me.ThemeName = "CrystalDark"
        CType(Me.panelMore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMore.ResumeLayout(False)
        Me.panelMore.PerformLayout()
        CType(Me.ddITType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents panelMore As Telerik.WinControls.UI.RadPanel
    Friend WithEvents tpTo As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tpFrom As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents Nyani As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ddITType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblType As Label
End Class

