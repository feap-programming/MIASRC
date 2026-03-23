<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLCSCreator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLCSCreator))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.CommandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel()
        Me.cbhFrom = New Telerik.WinControls.UI.CommandBarHostItem()
        Me.CommandBarLabel2 = New Telerik.WinControls.UI.CommandBarLabel()
        Me.cbhTo = New Telerik.WinControls.UI.CommandBarHostItem()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarLabel3 = New Telerik.WinControls.UI.CommandBarLabel()
        Me.cbhTemplate = New Telerik.WinControls.UI.CommandBarHostItem()
        Me.cbbOpen = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbExport = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.qrImgFSIB = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.qrImgLot = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qrImgFSIB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qrImgLot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(1051, 56)
        Me.RadCommandBar1.TabIndex = 0
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarLabel1, Me.cbhFrom, Me.CommandBarLabel2, Me.cbhTo, Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.CommandBarSeparator2, Me.CommandBarLabel3, Me.cbhTemplate, Me.cbbOpen, Me.CommandBarSeparator3, Me.cbbExport, Me.CommandBarSeparator4, Me.cbbOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        '
        'CommandBarLabel1
        '
        Me.CommandBarLabel1.DisplayName = "Date From Label"
        Me.CommandBarLabel1.Name = "CommandBarLabel1"
        Me.CommandBarLabel1.Text = "From:"
        '
        'cbhFrom
        '
        Me.cbhFrom.AutoSize = False
        Me.cbhFrom.Bounds = New System.Drawing.Rectangle(0, 0, 90, 52)
        Me.cbhFrom.DisplayName = "Date From"
        Me.cbhFrom.Name = "cbhFrom"
        Me.cbhFrom.Text = "CommandBarHostItem1"
        '
        'CommandBarLabel2
        '
        Me.CommandBarLabel2.DisplayName = "Date To Label"
        Me.CommandBarLabel2.Name = "CommandBarLabel2"
        Me.CommandBarLabel2.Text = "To:"
        '
        'cbhTo
        '
        Me.cbhTo.AutoSize = False
        Me.cbhTo.Bounds = New System.Drawing.Rectangle(0, 0, 90, 52)
        Me.cbhTo.DisplayName = "Date To"
        Me.cbhTo.Name = "cbhTo"
        Me.cbhTo.Text = "CommandBarHostItem2"
        '
        'cbbRefresh
        '
        Me.cbbRefresh.AutoSize = False
        Me.cbbRefresh.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbRefresh.DisplayName = "Refresh"
        Me.cbbRefresh.DrawText = True
        Me.cbbRefresh.Image = CType(resources.GetObject("cbbRefresh.Image"), System.Drawing.Image)
        Me.cbbRefresh.Name = "cbbRefresh"
        Me.cbbRefresh.Text = "Refresh"
        Me.cbbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.DisplayName = "Separator 1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cbbAdd
        '
        Me.cbbAdd.AutoSize = False
        Me.cbbAdd.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbAdd.DisplayName = "Add Record"
        Me.cbbAdd.DrawText = True
        Me.cbbAdd.Image = CType(resources.GetObject("cbbAdd.Image"), System.Drawing.Image)
        Me.cbbAdd.Name = "cbbAdd"
        Me.cbbAdd.Text = "Add Record"
        Me.cbbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'CommandBarLabel3
        '
        Me.CommandBarLabel3.DisplayName = "Template Label"
        Me.CommandBarLabel3.Name = "CommandBarLabel3"
        Me.CommandBarLabel3.Text = "Template:"
        '
        'cbhTemplate
        '
        Me.cbhTemplate.AutoSize = False
        Me.cbhTemplate.Bounds = New System.Drawing.Rectangle(0, 0, 200, 20)
        Me.cbhTemplate.DisplayName = "Template"
        Me.cbhTemplate.Name = "cbhTemplate"
        Me.cbhTemplate.PositionOffset = New System.Drawing.SizeF(0!, 15.0!)
        Me.cbhTemplate.Text = "CommandBarHostItem1"
        '
        'cbbOpen
        '
        Me.cbbOpen.AutoSize = False
        Me.cbbOpen.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbOpen.DisplayName = "Open LCS"
        Me.cbbOpen.DrawText = True
        Me.cbbOpen.Image = CType(resources.GetObject("cbbOpen.Image"), System.Drawing.Image)
        Me.cbbOpen.Name = "cbbOpen"
        Me.cbbOpen.Text = "Open LCS"
        Me.cbbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.DisplayName = "Separator 3"
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'cbbExport
        '
        Me.cbbExport.AutoSize = False
        Me.cbbExport.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbExport.DisplayName = "Export Data"
        Me.cbbExport.DrawText = True
        Me.cbbExport.Image = CType(resources.GetObject("cbbExport.Image"), System.Drawing.Image)
        Me.cbbExport.Name = "cbbExport"
        Me.cbbExport.Text = "Export Data"
        Me.cbbExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.DisplayName = "Separator 4"
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'cbbOptions
        '
        Me.cbbOptions.AutoSize = False
        Me.cbbOptions.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbOptions.DisplayName = "Options"
        Me.cbbOptions.DrawText = True
        Me.cbbOptions.Image = CType(resources.GetObject("cbbOptions.Image"), System.Drawing.Image)
        Me.cbbOptions.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miEnableFiltering, Me.miEnableGrouping})
        Me.cbbOptions.Name = "cbbOptions"
        Me.cbbOptions.Text = "Options"
        Me.cbbOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'miEnableFiltering
        '
        Me.miEnableFiltering.CheckOnClick = True
        Me.miEnableFiltering.Name = "miEnableFiltering"
        Me.miEnableFiltering.Text = "Enable Filtering"
        '
        'miEnableGrouping
        '
        Me.miEnableGrouping.CheckOnClick = True
        Me.miEnableGrouping.Name = "miEnableGrouping"
        Me.miEnableGrouping.Text = "Enable Grouping"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator5, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 592)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(1051, 26)
        Me.RadStatusStrip1.TabIndex = 1
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
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = "Permission:"
        Me.RadLabelElement2.TextWrap = True
        '
        'lePermission
        '
        Me.lePermission.Name = "lePermission"
        Me.RadStatusStrip1.SetSpring(Me.lePermission, False)
        Me.lePermission.Text = "lePermission"
        Me.lePermission.TextWrap = True
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator5, False)
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'RadProgressBarElement1
        '
        Me.RadProgressBarElement1.AutoSize = False
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 18)
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
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 56)
        '
        '
        '
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(1051, 536)
        Me.gvData.TabIndex = 2
        '
        'bwLoadData
        '
        '
        'qrImgFSIB
        '
        Me.qrImgFSIB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.qrImgFSIB.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.qrImgFSIB.Image = CType(resources.GetObject("qrImgFSIB.Image"), System.Drawing.Image)
        Me.qrImgFSIB.Location = New System.Drawing.Point(868, 206)
        Me.qrImgFSIB.Name = "qrImgFSIB"
        Me.qrImgFSIB.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.qrImgFSIB.Size = New System.Drawing.Size(70, 70)
        Me.qrImgFSIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.qrImgFSIB.TabIndex = 7
        Me.qrImgFSIB.TabStop = False
        '
        'qrImgLot
        '
        Me.qrImgLot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.qrImgLot.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.qrImgLot.Image = CType(resources.GetObject("qrImgLot.Image"), System.Drawing.Image)
        Me.qrImgLot.Location = New System.Drawing.Point(868, 130)
        Me.qrImgLot.Name = "qrImgLot"
        Me.qrImgLot.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.qrImgLot.Size = New System.Drawing.Size(70, 70)
        Me.qrImgLot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.qrImgLot.TabIndex = 6
        Me.qrImgLot.TabStop = False
        '
        'FrmLCSCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 618)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.qrImgFSIB)
        Me.Controls.Add(Me.qrImgLot)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Name = "FrmLCSCreator"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LCS Creator"
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qrImgFSIB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qrImgLot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents CommandBarLabel1 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents cbhFrom As Telerik.WinControls.UI.CommandBarHostItem
    Friend WithEvents CommandBarLabel2 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents cbhTo As Telerik.WinControls.UI.CommandBarHostItem
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbOpen As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbExport As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbhTemplate As Telerik.WinControls.UI.CommandBarHostItem
    Friend WithEvents CommandBarLabel3 As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents qrImgFSIB As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents qrImgLot As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
End Class

