<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWorkingDays
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWorkingDays))
        Me.pnlControls = New Telerik.WinControls.UI.RadPanel()
        Me.numDec = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numSep = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numJun = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numMar = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblDec = New Telerik.WinControls.UI.RadLabel()
        Me.lblSep = New Telerik.WinControls.UI.RadLabel()
        Me.lblJun = New Telerik.WinControls.UI.RadLabel()
        Me.lblMar = New Telerik.WinControls.UI.RadLabel()
        Me.numNov = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numAug = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numMay = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numFeb = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblNov = New Telerik.WinControls.UI.RadLabel()
        Me.lblAug = New Telerik.WinControls.UI.RadLabel()
        Me.lblMay = New Telerik.WinControls.UI.RadLabel()
        Me.lblFeb = New Telerik.WinControls.UI.RadLabel()
        Me.numOct = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblOct = New Telerik.WinControls.UI.RadLabel()
        Me.numJul = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblJul = New Telerik.WinControls.UI.RadLabel()
        Me.numApr = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblApr = New Telerik.WinControls.UI.RadLabel()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numJan = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblJan = New Telerik.WinControls.UI.RadLabel()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        CType(Me.numDec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblJun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAug, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblJul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numApr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblApr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblJan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Silver
        Me.pnlControls.Controls.Add(Me.numDec)
        Me.pnlControls.Controls.Add(Me.numSep)
        Me.pnlControls.Controls.Add(Me.numJun)
        Me.pnlControls.Controls.Add(Me.numMar)
        Me.pnlControls.Controls.Add(Me.lblDec)
        Me.pnlControls.Controls.Add(Me.lblSep)
        Me.pnlControls.Controls.Add(Me.lblJun)
        Me.pnlControls.Controls.Add(Me.lblMar)
        Me.pnlControls.Controls.Add(Me.numNov)
        Me.pnlControls.Controls.Add(Me.numAug)
        Me.pnlControls.Controls.Add(Me.numMay)
        Me.pnlControls.Controls.Add(Me.numFeb)
        Me.pnlControls.Controls.Add(Me.lblNov)
        Me.pnlControls.Controls.Add(Me.lblAug)
        Me.pnlControls.Controls.Add(Me.lblMay)
        Me.pnlControls.Controls.Add(Me.lblFeb)
        Me.pnlControls.Controls.Add(Me.numOct)
        Me.pnlControls.Controls.Add(Me.lblOct)
        Me.pnlControls.Controls.Add(Me.numJul)
        Me.pnlControls.Controls.Add(Me.lblJul)
        Me.pnlControls.Controls.Add(Me.numApr)
        Me.pnlControls.Controls.Add(Me.lblApr)
        Me.pnlControls.Controls.Add(Me.numYear)
        Me.pnlControls.Controls.Add(Me.numJan)
        Me.pnlControls.Controls.Add(Me.lblJan)
        Me.pnlControls.Controls.Add(Me.lblYear)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(990, 92)
        Me.pnlControls.TabIndex = 1
        Me.pnlControls.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlControls.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'numDec
        '
        Me.numDec.Location = New System.Drawing.Point(820, 62)
        Me.numDec.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numDec.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDec.Name = "numDec"
        Me.numDec.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDec.ShowUpDownButtons = False
        Me.numDec.Size = New System.Drawing.Size(120, 20)
        Me.numDec.TabIndex = 13
        Me.numDec.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDec.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numSep
        '
        Me.numSep.Location = New System.Drawing.Point(630, 62)
        Me.numSep.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numSep.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSep.Name = "numSep"
        Me.numSep.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSep.ShowUpDownButtons = False
        Me.numSep.Size = New System.Drawing.Size(120, 20)
        Me.numSep.TabIndex = 10
        Me.numSep.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSep.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numJun
        '
        Me.numJun.Location = New System.Drawing.Point(440, 62)
        Me.numJun.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numJun.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJun.Name = "numJun"
        Me.numJun.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJun.ShowUpDownButtons = False
        Me.numJun.Size = New System.Drawing.Size(120, 20)
        Me.numJun.TabIndex = 7
        Me.numJun.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numJun.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numMar
        '
        Me.numMar.Location = New System.Drawing.Point(250, 62)
        Me.numMar.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numMar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMar.Name = "numMar"
        Me.numMar.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMar.ShowUpDownButtons = False
        Me.numMar.Size = New System.Drawing.Size(120, 20)
        Me.numMar.TabIndex = 4
        Me.numMar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblDec
        '
        Me.lblDec.Location = New System.Drawing.Point(757, 63)
        Me.lblDec.Name = "lblDec"
        Me.lblDec.Size = New System.Drawing.Size(57, 18)
        Me.lblDec.TabIndex = 0
        Me.lblDec.Text = "December"
        '
        'lblSep
        '
        Me.lblSep.Location = New System.Drawing.Point(563, 63)
        Me.lblSep.Name = "lblSep"
        Me.lblSep.Size = New System.Drawing.Size(61, 18)
        Me.lblSep.TabIndex = 0
        Me.lblSep.Text = "September"
        '
        'lblJun
        '
        Me.lblJun.Location = New System.Drawing.Point(405, 63)
        Me.lblJun.Name = "lblJun"
        Me.lblJun.Size = New System.Drawing.Size(29, 18)
        Me.lblJun.TabIndex = 0
        Me.lblJun.Text = "June"
        '
        'lblMar
        '
        Me.lblMar.Location = New System.Drawing.Point(206, 63)
        Me.lblMar.Name = "lblMar"
        Me.lblMar.Size = New System.Drawing.Size(38, 18)
        Me.lblMar.TabIndex = 0
        Me.lblMar.Text = "March"
        '
        'numNov
        '
        Me.numNov.Location = New System.Drawing.Point(820, 36)
        Me.numNov.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numNov.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNov.Name = "numNov"
        Me.numNov.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNov.ShowUpDownButtons = False
        Me.numNov.Size = New System.Drawing.Size(120, 20)
        Me.numNov.TabIndex = 12
        Me.numNov.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numNov.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numAug
        '
        Me.numAug.Location = New System.Drawing.Point(630, 36)
        Me.numAug.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numAug.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numAug.Name = "numAug"
        Me.numAug.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numAug.ShowUpDownButtons = False
        Me.numAug.Size = New System.Drawing.Size(120, 20)
        Me.numAug.TabIndex = 9
        Me.numAug.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numAug.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numMay
        '
        Me.numMay.Location = New System.Drawing.Point(440, 36)
        Me.numMay.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numMay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMay.Name = "numMay"
        Me.numMay.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMay.ShowUpDownButtons = False
        Me.numMay.Size = New System.Drawing.Size(120, 20)
        Me.numMay.TabIndex = 6
        Me.numMay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numFeb
        '
        Me.numFeb.Location = New System.Drawing.Point(250, 36)
        Me.numFeb.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numFeb.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numFeb.Name = "numFeb"
        Me.numFeb.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numFeb.ShowUpDownButtons = False
        Me.numFeb.Size = New System.Drawing.Size(120, 20)
        Me.numFeb.TabIndex = 3
        Me.numFeb.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numFeb.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNov
        '
        Me.lblNov.Location = New System.Drawing.Point(755, 38)
        Me.lblNov.Name = "lblNov"
        Me.lblNov.Size = New System.Drawing.Size(59, 18)
        Me.lblNov.TabIndex = 0
        Me.lblNov.Text = "November"
        '
        'lblAug
        '
        Me.lblAug.Location = New System.Drawing.Point(582, 38)
        Me.lblAug.Name = "lblAug"
        Me.lblAug.Size = New System.Drawing.Size(42, 18)
        Me.lblAug.TabIndex = 0
        Me.lblAug.Text = "August"
        '
        'lblMay
        '
        Me.lblMay.Location = New System.Drawing.Point(406, 38)
        Me.lblMay.Name = "lblMay"
        Me.lblMay.Size = New System.Drawing.Size(28, 18)
        Me.lblMay.TabIndex = 0
        Me.lblMay.Text = "May"
        '
        'lblFeb
        '
        Me.lblFeb.Location = New System.Drawing.Point(194, 38)
        Me.lblFeb.Name = "lblFeb"
        Me.lblFeb.Size = New System.Drawing.Size(50, 18)
        Me.lblFeb.TabIndex = 0
        Me.lblFeb.Text = "February"
        '
        'numOct
        '
        Me.numOct.Location = New System.Drawing.Point(820, 10)
        Me.numOct.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numOct.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numOct.Name = "numOct"
        Me.numOct.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numOct.ShowUpDownButtons = False
        Me.numOct.Size = New System.Drawing.Size(120, 20)
        Me.numOct.TabIndex = 11
        Me.numOct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numOct.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblOct
        '
        Me.lblOct.Location = New System.Drawing.Point(767, 12)
        Me.lblOct.Name = "lblOct"
        Me.lblOct.Size = New System.Drawing.Size(47, 18)
        Me.lblOct.TabIndex = 0
        Me.lblOct.Text = "October"
        '
        'numJul
        '
        Me.numJul.Location = New System.Drawing.Point(630, 10)
        Me.numJul.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numJul.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJul.Name = "numJul"
        Me.numJul.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJul.ShowUpDownButtons = False
        Me.numJul.Size = New System.Drawing.Size(120, 20)
        Me.numJul.TabIndex = 8
        Me.numJul.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numJul.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblJul
        '
        Me.lblJul.Location = New System.Drawing.Point(599, 12)
        Me.lblJul.Name = "lblJul"
        Me.lblJul.Size = New System.Drawing.Size(25, 18)
        Me.lblJul.TabIndex = 0
        Me.lblJul.Text = "July"
        '
        'numApr
        '
        Me.numApr.Location = New System.Drawing.Point(440, 10)
        Me.numApr.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numApr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numApr.Name = "numApr"
        Me.numApr.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numApr.ShowUpDownButtons = False
        Me.numApr.Size = New System.Drawing.Size(120, 20)
        Me.numApr.TabIndex = 5
        Me.numApr.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numApr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblApr
        '
        Me.lblApr.Location = New System.Drawing.Point(404, 12)
        Me.lblApr.Name = "lblApr"
        Me.lblApr.Size = New System.Drawing.Size(30, 18)
        Me.lblApr.TabIndex = 0
        Me.lblApr.Text = "April"
        '
        'numYear
        '
        Me.numYear.Location = New System.Drawing.Point(50, 10)
        Me.numYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numYear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.NullableValue = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.numYear.ShowUpDownButtons = False
        Me.numYear.Size = New System.Drawing.Size(120, 20)
        Me.numYear.TabIndex = 1
        Me.numYear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numYear.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'numJan
        '
        Me.numJan.Location = New System.Drawing.Point(250, 10)
        Me.numJan.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numJan.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJan.Name = "numJan"
        Me.numJan.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJan.ShowUpDownButtons = False
        Me.numJan.Size = New System.Drawing.Size(120, 20)
        Me.numJan.TabIndex = 2
        Me.numJan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numJan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblJan
        '
        Me.lblJan.Location = New System.Drawing.Point(200, 12)
        Me.lblJan.Name = "lblJan"
        Me.lblJan.Size = New System.Drawing.Size(44, 18)
        Me.lblJan.TabIndex = 0
        Me.lblJan.Text = "January"
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(16, 12)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(28, 18)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 92)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(990, 56)
        Me.RadCommandBar1.TabIndex = 2
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
        Me.CommandBarStripElement1.DisplayName = "Tool Bar"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.cbbAdd, Me.cbbEdit, Me.cbbDelete, Me.cbddOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 561)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(990, 29)
        Me.RadStatusStrip1.TabIndex = 4
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Records Found:"
        Me.RadLabelElement1.TextWrap = True
        Me.RadLabelElement1.UseCompatibleTextRendering = False
        '
        'leCountRec
        '
        Me.leCountRec.Name = "leCountRec"
        Me.RadStatusStrip1.SetSpring(Me.leCountRec, True)
        Me.leCountRec.Text = "0"
        Me.leCountRec.TextWrap = True
        Me.leCountRec.UseCompatibleTextRendering = False
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = "Permission:"
        Me.RadLabelElement2.TextWrap = True
        Me.RadLabelElement2.UseCompatibleTextRendering = False
        '
        'lePermission
        '
        Me.lePermission.Name = "lePermission"
        Me.RadStatusStrip1.SetSpring(Me.lePermission, False)
        Me.lePermission.Text = "lePermission"
        Me.lePermission.TextWrap = True
        Me.lePermission.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator4, False)
        Me.CommandBarSeparator4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator4.UseCompatibleTextRendering = False
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'RadProgressBarElement1
        '
        Me.RadProgressBarElement1.AutoSize = False
        Me.RadProgressBarElement1.Bounds = New System.Drawing.Rectangle(0, 0, 100, 21)
        Me.RadProgressBarElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
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
        Me.RadProgressBarElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.RadProgressBarElement1.UseCompatibleTextRendering = False
        '
        'gvData
        '
        Me.gvData.AutoScroll = True
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gvData.Location = New System.Drawing.Point(0, 148)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.EnableFiltering = True
        Me.gvData.MasterTemplate.MultiSelect = True
        Me.gvData.MasterTemplate.ShowFilteringRow = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.ShowGroupPanel = False
        Me.gvData.Size = New System.Drawing.Size(990, 413)
        Me.gvData.TabIndex = 3
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'bwLoadData
        '
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
        'cbbAdd
        '
        Me.cbbAdd.AutoSize = False
        Me.cbbAdd.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
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
        'cbbEdit
        '
        Me.cbbEdit.AutoSize = False
        Me.cbbEdit.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbEdit.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbEdit.DisplayName = "Edit Record"
        Me.cbbEdit.DrawText = True
        Me.cbbEdit.Image = CType(resources.GetObject("cbbEdit.Image"), System.Drawing.Image)
        Me.cbbEdit.Name = "cbbEdit"
        Me.cbbEdit.Text = "Edit Record"
        Me.cbbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbEdit.UseCompatibleTextRendering = False
        '
        'cbbDelete
        '
        Me.cbbDelete.AutoSize = False
        Me.cbbDelete.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
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
        'cbddOptions
        '
        Me.cbddOptions.AutoSize = False
        Me.cbddOptions.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbddOptions.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbddOptions.DisplayName = "Options"
        Me.cbddOptions.DrawText = True
        Me.cbddOptions.Image = CType(resources.GetObject("cbddOptions.Image"), System.Drawing.Image)
        Me.cbddOptions.Items.AddRange(New Telerik.WinControls.RadItem() {Me.miEnableFiltering, Me.miEnableGrouping})
        Me.cbddOptions.Name = "cbddOptions"
        Me.cbddOptions.Text = "Options"
        Me.cbddOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbddOptions.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbddOptions.UseCompatibleTextRendering = False
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
        'ucWorkingDays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlControls)
        Me.Name = "ucWorkingDays"
        Me.Size = New System.Drawing.Size(990, 590)
        CType(Me.pnlControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.numDec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblJun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAug, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblJul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numApr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblApr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblJan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlControls As Telerik.WinControls.UI.RadPanel
    Friend WithEvents numDec As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numSep As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numJun As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numMar As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblDec As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblSep As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblJun As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblMar As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numNov As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numAug As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numMay As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numFeb As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblNov As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblAug As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblMay As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblFeb As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numOct As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblOct As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numJul As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblJul As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numApr As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblApr As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numJan As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblJan As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbddOptions As Telerik.WinControls.UI.CommandBarDropDownButton
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRec As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lePermission As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadProgressBarElement1 As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents miEnableFiltering As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents miEnableGrouping As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
End Class
