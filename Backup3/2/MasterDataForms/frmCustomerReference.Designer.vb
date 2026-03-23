<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerReference
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerReference))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.pnlForm = New Telerik.WinControls.UI.RadPanel()
        Me.drpClassification = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblClassification = New Telerik.WinControls.UI.RadLabel()
        Me.txtTIN = New Telerik.WinControls.UI.RadTextBox()
        Me.txtContactPosition = New Telerik.WinControls.UI.RadTextBox()
        Me.txtContactPerson = New Telerik.WinControls.UI.RadTextBox()
        Me.txtBusinessStyle = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtFaxNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCountryOrigin = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTelNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.txtName = New Telerik.WinControls.UI.RadTextBox()
        Me.lblContactPosition = New Telerik.WinControls.UI.RadLabel()
        Me.lblFaxNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblTIN = New Telerik.WinControls.UI.RadLabel()
        Me.lblContactPerson = New Telerik.WinControls.UI.RadLabel()
        Me.lblCountryOrigin = New Telerik.WinControls.UI.RadLabel()
        Me.lblTelNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblName = New Telerik.WinControls.UI.RadLabel()
        Me.lblAddress = New Telerik.WinControls.UI.RadLabel()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cbbRefresh = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbbAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbUpdate = New Telerik.WinControls.UI.CommandBarButton()
        Me.cbbDelete = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cbddOptions = New Telerik.WinControls.UI.CommandBarDropDownButton()
        Me.miEnableFiltering = New Telerik.WinControls.UI.RadMenuItem()
        Me.miEnableGrouping = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRec = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.lePermission = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadProgressBarElement1 = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.bwOperation = New System.ComponentModel.BackgroundWorker()
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        CType(Me.drpClassification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClassification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusinessStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFaxNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountryOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblContactPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFaxNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblContactPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCountryOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTelNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.Silver
        Me.pnlForm.Controls.Add(Me.drpClassification)
        Me.pnlForm.Controls.Add(Me.lblClassification)
        Me.pnlForm.Controls.Add(Me.txtTIN)
        Me.pnlForm.Controls.Add(Me.txtContactPosition)
        Me.pnlForm.Controls.Add(Me.txtContactPerson)
        Me.pnlForm.Controls.Add(Me.txtBusinessStyle)
        Me.pnlForm.Controls.Add(Me.RadLabel1)
        Me.pnlForm.Controls.Add(Me.txtFaxNo)
        Me.pnlForm.Controls.Add(Me.txtCountryOrigin)
        Me.pnlForm.Controls.Add(Me.txtTelNo)
        Me.pnlForm.Controls.Add(Me.txtAddress)
        Me.pnlForm.Controls.Add(Me.txtName)
        Me.pnlForm.Controls.Add(Me.lblContactPosition)
        Me.pnlForm.Controls.Add(Me.lblFaxNo)
        Me.pnlForm.Controls.Add(Me.lblTIN)
        Me.pnlForm.Controls.Add(Me.lblContactPerson)
        Me.pnlForm.Controls.Add(Me.lblCountryOrigin)
        Me.pnlForm.Controls.Add(Me.lblTelNo)
        Me.pnlForm.Controls.Add(Me.lblName)
        Me.pnlForm.Controls.Add(Me.lblAddress)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(788, 90)
        Me.pnlForm.TabIndex = 0
        Me.pnlForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.pnlForm.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'drpClassification
        '
        Me.drpClassification.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "LOCAL"
        RadListDataItem2.Text = "EXPORT"
        Me.drpClassification.Items.Add(RadListDataItem1)
        Me.drpClassification.Items.Add(RadListDataItem2)
        Me.drpClassification.Location = New System.Drawing.Point(661, 32)
        Me.drpClassification.Name = "drpClassification"
        Me.drpClassification.Size = New System.Drawing.Size(110, 20)
        Me.drpClassification.TabIndex = 10
        '
        'lblClassification
        '
        Me.lblClassification.BackColor = System.Drawing.Color.Transparent
        Me.lblClassification.Location = New System.Drawing.Point(584, 34)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(71, 18)
        Me.lblClassification.TabIndex = 0
        Me.lblClassification.Text = "Classification"
        '
        'txtTIN
        '
        Me.txtTIN.Location = New System.Drawing.Point(471, 32)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Size = New System.Drawing.Size(110, 20)
        Me.txtTIN.TabIndex = 7
        '
        'txtContactPosition
        '
        Me.txtContactPosition.Location = New System.Drawing.Point(661, 6)
        Me.txtContactPosition.Name = "txtContactPosition"
        Me.txtContactPosition.Size = New System.Drawing.Size(110, 20)
        Me.txtContactPosition.TabIndex = 9
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(471, 58)
        Me.txtContactPerson.Name = "txtContactPerson"
        '
        '
        '
        Me.txtContactPerson.RootElement.StretchVertically = True
        Me.txtContactPerson.Size = New System.Drawing.Size(110, 20)
        Me.txtContactPerson.TabIndex = 8
        '
        'txtBusinessStyle
        '
        Me.txtBusinessStyle.Location = New System.Drawing.Point(281, 58)
        Me.txtBusinessStyle.Name = "txtBusinessStyle"
        Me.txtBusinessStyle.Size = New System.Drawing.Size(110, 20)
        Me.txtBusinessStyle.TabIndex = 5
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(213, 63)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(62, 15)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Business Style"
        '
        'txtFaxNo
        '
        Me.txtFaxNo.Location = New System.Drawing.Point(281, 32)
        Me.txtFaxNo.Name = "txtFaxNo"
        Me.txtFaxNo.Size = New System.Drawing.Size(110, 20)
        Me.txtFaxNo.TabIndex = 4
        '
        'txtCountryOrigin
        '
        Me.txtCountryOrigin.Location = New System.Drawing.Point(471, 6)
        Me.txtCountryOrigin.Name = "txtCountryOrigin"
        Me.txtCountryOrigin.Size = New System.Drawing.Size(110, 20)
        Me.txtCountryOrigin.TabIndex = 6
        '
        'txtTelNo
        '
        Me.txtTelNo.Location = New System.Drawing.Point(281, 6)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(110, 20)
        Me.txtTelNo.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(91, 32)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        '
        '
        '
        Me.txtAddress.RootElement.StretchVertically = True
        Me.txtAddress.Size = New System.Drawing.Size(110, 46)
        Me.txtAddress.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(91, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(110, 20)
        Me.txtName.TabIndex = 1
        '
        'lblContactPosition
        '
        Me.lblContactPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactPosition.Location = New System.Drawing.Point(596, 8)
        Me.lblContactPosition.Name = "lblContactPosition"
        Me.lblContactPosition.Size = New System.Drawing.Size(59, 18)
        Me.lblContactPosition.TabIndex = 0
        Me.lblContactPosition.Text = "C. Position"
        '
        'lblFaxNo
        '
        Me.lblFaxNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaxNo.Location = New System.Drawing.Point(234, 34)
        Me.lblFaxNo.Name = "lblFaxNo"
        Me.lblFaxNo.Size = New System.Drawing.Size(41, 18)
        Me.lblFaxNo.TabIndex = 0
        Me.lblFaxNo.Text = "Fax No"
        '
        'lblTIN
        '
        Me.lblTIN.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblTIN.Location = New System.Drawing.Point(441, 34)
        Me.lblTIN.Name = "lblTIN"
        Me.lblTIN.Size = New System.Drawing.Size(24, 18)
        Me.lblTIN.TabIndex = 0
        Me.lblTIN.Text = "TIN"
        '
        'lblContactPerson
        '
        Me.lblContactPerson.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblContactPerson.Location = New System.Drawing.Point(412, 60)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(53, 18)
        Me.lblContactPerson.TabIndex = 0
        Me.lblContactPerson.Text = "C. Person"
        '
        'lblCountryOrigin
        '
        Me.lblCountryOrigin.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountryOrigin.Location = New System.Drawing.Point(399, 11)
        Me.lblCountryOrigin.Name = "lblCountryOrigin"
        Me.lblCountryOrigin.Size = New System.Drawing.Size(66, 15)
        Me.lblCountryOrigin.TabIndex = 0
        Me.lblCountryOrigin.Text = "Country Origin"
        '
        'lblTelNo
        '
        Me.lblTelNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelNo.Location = New System.Drawing.Point(236, 8)
        Me.lblTelNo.Name = "lblTelNo"
        Me.lblTelNo.Size = New System.Drawing.Size(39, 18)
        Me.lblTelNo.TabIndex = 0
        Me.lblTelNo.Text = "Tel No"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(49, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(36, 18)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(39, 34)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(46, 18)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 90)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(788, 81)
        Me.RadCommandBar1.TabIndex = 1
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
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbRefresh, Me.CommandBarSeparator1, Me.cbbAdd, Me.cbbUpdate, Me.cbbDelete, Me.CommandBarSeparator2, Me.cbddOptions})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        Me.CommandBarStripElement1.StretchHorizontally = True
        Me.CommandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarStripElement1.UseCompatibleTextRendering = False
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
        'cbbUpdate
        '
        Me.cbbUpdate.AutoSize = False
        Me.cbbUpdate.Bounds = New System.Drawing.Rectangle(0, 0, 79, 52)
        Me.cbbUpdate.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbUpdate.DisplayName = "CommandBarButton1"
        Me.cbbUpdate.DrawText = True
        Me.cbbUpdate.Image = CType(resources.GetObject("cbbUpdate.Image"), System.Drawing.Image)
        Me.cbbUpdate.Name = "cbbUpdate"
        Me.cbbUpdate.Text = "Update"
        Me.cbbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cbbUpdate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cbbUpdate.UseCompatibleTextRendering = False
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
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.DisplayName = "Separator 2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator2.UseCompatibleTextRendering = False
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
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
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRec, Me.RadLabelElement2, Me.lePermission, Me.CommandBarSeparator4, Me.RadProgressBarElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 553)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(788, 29)
        Me.RadStatusStrip1.TabIndex = 3
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
        Me.gvData.Location = New System.Drawing.Point(0, 171)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowAddNewRow = False
        Me.gvData.MasterTemplate.AllowDeleteRow = False
        Me.gvData.MasterTemplate.EnableFiltering = True
        Me.gvData.MasterTemplate.MultiSelect = True
        Me.gvData.MasterTemplate.ShowFilteringRow = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.ReadOnly = True
        Me.gvData.ShowGroupPanel = False
        Me.gvData.Size = New System.Drawing.Size(788, 382)
        Me.gvData.TabIndex = 2
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        Me.bwLoadData.WorkerSupportsCancellation = True
        '
        'bwOperation
        '
        Me.bwOperation.WorkerReportsProgress = True
        '
        'FrmCustomerReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 582)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.pnlForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCustomerReference"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Customer Reference"
        CType(Me.pnlForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.drpClassification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClassification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusinessStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFaxNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountryOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblContactPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFaxNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblContactPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCountryOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTelNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlForm As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblFaxNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblTelNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblAddress As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cbbRefresh As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cbbAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbUpdate As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cbbDelete As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
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
    Friend WithEvents txtTelNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtFaxNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtContactPosition As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtContactPerson As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtBusinessStyle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCountryOrigin As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblContactPosition As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblContactPerson As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCountryOrigin As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwOperation As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtTIN As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblTIN As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpClassification As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblClassification As Telerik.WinControls.UI.RadLabel
End Class

