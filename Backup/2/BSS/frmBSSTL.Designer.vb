<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSTL
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBSSTL))
        Me.lbl = New Telerik.WinControls.UI.RadPanel()
        Me.ddlCategory = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txtEmpName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtEmpNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        CType(Me.lbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lbl.SuspendLayout()
        CType(Me.ddlCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoScroll = True
        Me.lbl.BackColor = System.Drawing.Color.LightGray
        Me.lbl.Controls.Add(Me.ddlCategory)
        Me.lbl.Controls.Add(Me.RadLabel6)
        Me.lbl.Controls.Add(Me.txtEmpName)
        Me.lbl.Controls.Add(Me.txtEmpNo)
        Me.lbl.Controls.Add(Me.RadLabel18)
        Me.lbl.Controls.Add(Me.RadLabel19)
        Me.lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl.Location = New System.Drawing.Point(0, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(763, 102)
        Me.lbl.TabIndex = 135
        Me.lbl.ThemeName = "Office2007Black"
        '
        'ddlCategory
        '
        RadListDataItem1.Text = "Team Leader"
        RadListDataItem2.Text = "Sub Team Leader"
        Me.ddlCategory.Items.Add(RadListDataItem1)
        Me.ddlCategory.Items.Add(RadListDataItem2)
        Me.ddlCategory.Location = New System.Drawing.Point(77, 63)
        Me.ddlCategory.Name = "ddlCategory"
        Me.ddlCategory.Size = New System.Drawing.Size(253, 20)
        Me.ddlCategory.TabIndex = 170
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel6.Location = New System.Drawing.Point(17, 63)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(54, 18)
        Me.RadLabel6.TabIndex = 169
        Me.RadLabel6.Text = "Category:"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(77, 35)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(253, 20)
        Me.txtEmpName.TabIndex = 161
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(77, 12)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(105, 20)
        Me.txtEmpNo.TabIndex = 160
        '
        'RadLabel18
        '
        Me.RadLabel18.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel18.Location = New System.Drawing.Point(7, 35)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(64, 18)
        Me.RadLabel18.TabIndex = 158
        Me.RadLabel18.Text = "Emp Name:"
        '
        'RadLabel19
        '
        Me.RadLabel19.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel19.Location = New System.Drawing.Point(22, 11)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(49, 18)
        Me.RadLabel19.TabIndex = 156
        Me.RadLabel19.Text = "Emp No:"
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 183)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(763, 252)
        Me.gvData.TabIndex = 87
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 102)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(763, 81)
        Me.RadCommandBar1.TabIndex = 136
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.cbbAdd, Me.cbbDelete})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'cbbRefresh
        '
        Me.cbbRefresh.DisplayName = "Refresh"
        Me.cbbRefresh.DrawText = True
        Me.cbbRefresh.Image = CType(resources.GetObject("cbbRefresh.Image"), System.Drawing.Image)
        Me.cbbRefresh.Name = "cbbRefresh"
        Me.cbbRefresh.Text = "Refresh"
        Me.cbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbAdd
        '
        Me.cbbAdd.DisplayName = "Add Record"
        Me.cbbAdd.DrawText = True
        Me.cbbAdd.Image = CType(resources.GetObject("cbbAdd.Image"), System.Drawing.Image)
        Me.cbbAdd.Name = "cbbAdd"
        Me.cbbAdd.Text = "Add Record"
        Me.cbbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cbbDelete
        '
        Me.cbbDelete.DisplayName = "Delete Record"
        Me.cbbDelete.DrawText = True
        Me.cbbDelete.Image = CType(resources.GetObject("cbbDelete.Image"), System.Drawing.Image)
        Me.cbbDelete.Name = "cbbDelete"
        Me.cbbDelete.Text = "Delete Record"
        Me.cbbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FrmBSSTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 435)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.lbl)
        Me.Name = "FrmBSSTL"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BSS TL"
        CType(Me.lbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lbl.ResumeLayout(False)
        Me.lbl.PerformLayout()
        CType(Me.ddlCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtEmpName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtEmpNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlCategory As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
End Class

