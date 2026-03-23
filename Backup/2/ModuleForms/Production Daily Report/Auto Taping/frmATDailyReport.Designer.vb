<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmATDailyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmATDailyReport))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReCons = New Telerik.WinControls.UI.RadButton()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.lblLoading = New Telerik.WinControls.UI.RadLabel()
        Me.btnSRCAutoAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.Manpower = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvManpower = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.ddMPPW = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.lblEditID = New Telerik.WinControls.UI.RadLabel()
        Me.btnMPCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnMPSubmit = New Telerik.WinControls.UI.RadButton()
        Me.ddMPStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.tbMPEmpName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.ddMPProc = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.GoodQty = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvGoodQty = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.btnGQCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnGQSubmit = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.spnGQQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.ddGQPartName = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.ddGQPWNo = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.Interupt = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.ddITType = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblType = New System.Windows.Forms.Label()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.tbITTimePart = New Telerik.WinControls.UI.RadTextBox()
        Me.spnITPersons = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.spnITOPTime = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.spnITUnplanDT = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.spnITHotto = New Telerik.WinControls.UI.RadSpinEditor()
        Me.spnITPlanDT = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblTo = New Telerik.WinControls.UI.RadLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnITSubmit = New Telerik.WinControls.UI.RadButton()
        Me.Defects = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvSRCDefects = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel10 = New Telerik.WinControls.UI.RadPanel()
        Me.lblDefectID = New Telerik.WinControls.UI.RadLabel()
        Me.spnDEFNo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSPDCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSPDSubmit = New Telerik.WinControls.UI.RadButton()
        Me.tbDEFDefect = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel36 = New Telerik.WinControls.UI.RadLabel()
        Me.ddDEFPart = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel37 = New Telerik.WinControls.UI.RadLabel()
        Me.Others = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rgvOthers = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.lblOtherID = New Telerik.WinControls.UI.RadLabel()
        Me.btnOthCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnOthSave = New Telerik.WinControls.UI.RadButton()
        Me.tbOthDetails = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.Lot = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel12 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvLotNo = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel13 = New Telerik.WinControls.UI.RadPanel()
        Me.ddLotAssy = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.lblLotID = New Telerik.WinControls.UI.RadLabel()
        Me.btnLotCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnLotSubmit = New Telerik.WinControls.UI.RadButton()
        Me.tbLotLotNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel47 = New Telerik.WinControls.UI.RadLabel()
        Me.tbLotBoxNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel46 = New Telerik.WinControls.UI.RadLabel()
        Me.ddLotPartName = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel45 = New Telerik.WinControls.UI.RadLabel()
        Me.ddLotTime = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel44 = New Telerik.WinControls.UI.RadLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.btnReCons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSRCAutoAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.Manpower.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.rgvManpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvManpower.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.ddMPPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEditID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMPCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMPSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMPStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMPEmpName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMPProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GoodQty.SuspendLayout()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.rgvGoodQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvGoodQty.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel4.SuspendLayout()
        CType(Me.btnGQCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGQSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnGQQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddGQPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddGQPWNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Interupt.SuspendLayout()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel5.SuspendLayout()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel6.SuspendLayout()
        CType(Me.ddITType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbITTimePart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnITPersons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnITOPTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnITUnplanDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnITHotto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnITPlanDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnITSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Defects.SuspendLayout()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel9.SuspendLayout()
        CType(Me.rgvSRCDefects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSRCDefects.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel10.SuspendLayout()
        CType(Me.lblDefectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnDEFNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSPDCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSPDSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDEFDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddDEFPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel37, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Others.SuspendLayout()
        CType(Me.rgvOthers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvOthers.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel7.SuspendLayout()
        CType(Me.lblOtherID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOthCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOthSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOthDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lot.SuspendLayout()
        CType(Me.RadPanel12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel12.SuspendLayout()
        CType(Me.rgvLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvLotNo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel13.SuspendLayout()
        CType(Me.ddLotAssy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLotID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLotCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLotSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLotLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLotBoxNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLotPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLotTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReCons)
        Me.Panel1.Controls.Add(Me.RadProgressBar1)
        Me.Panel1.Controls.Add(Me.lblLoading)
        Me.Panel1.Controls.Add(Me.btnSRCAutoAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 36)
        Me.Panel1.TabIndex = 4
        '
        'btnReCons
        '
        Me.btnReCons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReCons.Location = New System.Drawing.Point(1100, 6)
        Me.btnReCons.Name = "btnReCons"
        Me.btnReCons.Size = New System.Drawing.Size(88, 24)
        Me.btnReCons.TabIndex = 16
        Me.btnReCons.Text = "ADJUST"
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadProgressBar1.ForeColor = System.Drawing.Color.Black
        Me.RadProgressBar1.Location = New System.Drawing.Point(964, 6)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(130, 24)
        Me.RadProgressBar1.TabIndex = 16
        Me.RadProgressBar1.ThemeName = "TelerikMetroBlue"
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoading.Location = New System.Drawing.Point(676, 10)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(65, 20)
        Me.lblLoading.TabIndex = 15
        Me.lblLoading.Text = "LOADING"
        Me.lblLoading.ThemeName = "CrystalDark"
        Me.lblLoading.Visible = False
        '
        'btnSRCAutoAdd
        '
        Me.btnSRCAutoAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSRCAutoAdd.Location = New System.Drawing.Point(1194, 6)
        Me.btnSRCAutoAdd.Name = "btnSRCAutoAdd"
        Me.btnSRCAutoAdd.Size = New System.Drawing.Size(88, 24)
        Me.btnSRCAutoAdd.TabIndex = 14
        Me.btnSRCAutoAdd.Text = "AUTO ADD"
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.Manpower)
        Me.RadPageView1.Controls.Add(Me.GoodQty)
        Me.RadPageView1.Controls.Add(Me.Interupt)
        Me.RadPageView1.Controls.Add(Me.Defects)
        Me.RadPageView1.Controls.Add(Me.Others)
        Me.RadPageView1.Controls.Add(Me.Lot)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Location = New System.Drawing.Point(0, 36)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.Interupt
        Me.RadPageView1.Size = New System.Drawing.Size(1285, 715)
        Me.RadPageView1.TabIndex = 5
        Me.RadPageView1.ThemeName = "FluentDark"
        Me.RadPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView
        '
        'Manpower
        '
        Me.Manpower.Controls.Add(Me.RadPanel1)
        Me.Manpower.Image = CType(resources.GetObject("Manpower.Image"), System.Drawing.Image)
        Me.Manpower.ItemSize = New System.Drawing.SizeF(145.0!, 40.0!)
        Me.Manpower.Location = New System.Drawing.Point(281, 30)
        Me.Manpower.Name = "Manpower"
        Me.Manpower.Size = New System.Drawing.Size(1003, 684)
        Me.Manpower.Text = "Manpower"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.rgvManpower)
        Me.RadPanel1.Controls.Add(Me.RadPanel2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1003, 684)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.ThemeName = "CrystalDark"
        '
        'rgvManpower
        '
        Me.rgvManpower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvManpower.Location = New System.Drawing.Point(0, 224)
        '
        '
        '
        Me.rgvManpower.MasterTemplate.AllowAddNewRow = False
        Me.rgvManpower.MasterTemplate.AllowCellContextMenu = False
        Me.rgvManpower.MasterTemplate.AllowColumnChooser = False
        Me.rgvManpower.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvManpower.MasterTemplate.AllowColumnReorder = False
        Me.rgvManpower.MasterTemplate.AllowDeleteRow = False
        Me.rgvManpower.MasterTemplate.AllowDragToGroup = False
        Me.rgvManpower.MasterTemplate.AllowEditRow = False
        Me.rgvManpower.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.rgvManpower.MasterTemplate.AllowRowResize = False
        Me.rgvManpower.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvManpower.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgvManpower.Name = "rgvManpower"
        Me.rgvManpower.Size = New System.Drawing.Size(1003, 460)
        Me.rgvManpower.TabIndex = 1
        Me.rgvManpower.ThemeName = "CrystalDark"
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.ddMPPW)
        Me.RadPanel2.Controls.Add(Me.RadLabel4)
        Me.RadPanel2.Controls.Add(Me.lblEditID)
        Me.RadPanel2.Controls.Add(Me.btnMPCancel)
        Me.RadPanel2.Controls.Add(Me.btnMPSubmit)
        Me.RadPanel2.Controls.Add(Me.ddMPStatus)
        Me.RadPanel2.Controls.Add(Me.RadLabel3)
        Me.RadPanel2.Controls.Add(Me.tbMPEmpName)
        Me.RadPanel2.Controls.Add(Me.RadLabel2)
        Me.RadPanel2.Controls.Add(Me.ddMPProc)
        Me.RadPanel2.Controls.Add(Me.RadLabel1)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(1003, 224)
        Me.RadPanel2.TabIndex = 0
        Me.RadPanel2.ThemeName = "CrystalDark"
        '
        'ddMPPW
        '
        Me.ddMPPW.DropDownAnimationEnabled = True
        Me.ddMPPW.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddMPPW.Location = New System.Drawing.Point(106, 7)
        Me.ddMPPW.Name = "ddMPPW"
        Me.ddMPPW.Size = New System.Drawing.Size(253, 24)
        Me.ddMPPW.TabIndex = 17
        Me.ddMPPW.Text = "RadDropDownList1"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(68, 7)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(38, 20)
        Me.RadLabel4.TabIndex = 16
        Me.RadLabel4.Text = "TM - "
        Me.RadLabel4.ThemeName = "CrystalDark"
        '
        'lblEditID
        '
        Me.lblEditID.Location = New System.Drawing.Point(785, 20)
        Me.lblEditID.Name = "lblEditID"
        Me.lblEditID.Size = New System.Drawing.Size(50, 20)
        Me.lblEditID.TabIndex = 15
        Me.lblEditID.Text = "Status:"
        Me.lblEditID.ThemeName = "CrystalDark"
        '
        'btnMPCancel
        '
        Me.btnMPCancel.Location = New System.Drawing.Point(222, 162)
        Me.btnMPCancel.Name = "btnMPCancel"
        Me.btnMPCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnMPCancel.TabIndex = 14
        Me.btnMPCancel.Text = "Cancel"
        Me.btnMPCancel.Visible = False
        '
        'btnMPSubmit
        '
        Me.btnMPSubmit.Location = New System.Drawing.Point(106, 162)
        Me.btnMPSubmit.Name = "btnMPSubmit"
        Me.btnMPSubmit.Size = New System.Drawing.Size(110, 24)
        Me.btnMPSubmit.TabIndex = 13
        Me.btnMPSubmit.Text = "SAVE"
        '
        'ddMPStatus
        '
        Me.ddMPStatus.DropDownAnimationEnabled = True
        Me.ddMPStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Qualified"
        RadListDataItem2.Text = "Transferred"
        RadListDataItem3.Text = "Trainee"
        Me.ddMPStatus.Items.Add(RadListDataItem1)
        Me.ddMPStatus.Items.Add(RadListDataItem2)
        Me.ddMPStatus.Items.Add(RadListDataItem3)
        Me.ddMPStatus.Location = New System.Drawing.Point(106, 122)
        Me.ddMPStatus.Name = "ddMPStatus"
        Me.ddMPStatus.Size = New System.Drawing.Size(253, 24)
        Me.ddMPStatus.TabIndex = 12
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(54, 122)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(50, 20)
        Me.RadLabel3.TabIndex = 11
        Me.RadLabel3.Text = "Status:"
        Me.RadLabel3.ThemeName = "CrystalDark"
        '
        'tbMPEmpName
        '
        Me.tbMPEmpName.Location = New System.Drawing.Point(106, 84)
        Me.tbMPEmpName.Name = "tbMPEmpName"
        Me.tbMPEmpName.Size = New System.Drawing.Size(253, 24)
        Me.tbMPEmpName.TabIndex = 10
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(37, 85)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(70, 20)
        Me.RadLabel2.TabIndex = 9
        Me.RadLabel2.Text = "Employee:"
        Me.RadLabel2.ThemeName = "CrystalDark"
        '
        'ddMPProc
        '
        Me.ddMPProc.DropDownAnimationEnabled = True
        Me.ddMPProc.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddMPProc.Location = New System.Drawing.Point(106, 45)
        Me.ddMPProc.Name = "ddMPProc"
        Me.ddMPProc.Size = New System.Drawing.Size(253, 24)
        Me.ddMPProc.TabIndex = 8
        Me.ddMPProc.Text = "RadDropDownList1"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(10, 45)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(100, 20)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "Process Name:"
        Me.RadLabel1.ThemeName = "CrystalDark"
        '
        'GoodQty
        '
        Me.GoodQty.Controls.Add(Me.RadPanel3)
        Me.GoodQty.Image = CType(resources.GetObject("GoodQty.Image"), System.Drawing.Image)
        Me.GoodQty.ItemSize = New System.Drawing.SizeF(145.0!, 40.0!)
        Me.GoodQty.Location = New System.Drawing.Point(281, 30)
        Me.GoodQty.Name = "GoodQty"
        Me.GoodQty.Size = New System.Drawing.Size(1003, 684)
        Me.GoodQty.Text = "Good Quantity"
        '
        'RadPanel3
        '
        Me.RadPanel3.Controls.Add(Me.rgvGoodQty)
        Me.RadPanel3.Controls.Add(Me.RadPanel4)
        Me.RadPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel3.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(1003, 684)
        Me.RadPanel3.TabIndex = 1
        Me.RadPanel3.ThemeName = "CrystalDark"
        '
        'rgvGoodQty
        '
        Me.rgvGoodQty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvGoodQty.Location = New System.Drawing.Point(0, 229)
        '
        '
        '
        Me.rgvGoodQty.MasterTemplate.AllowAddNewRow = False
        Me.rgvGoodQty.MasterTemplate.AllowCellContextMenu = False
        Me.rgvGoodQty.MasterTemplate.AllowColumnChooser = False
        Me.rgvGoodQty.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvGoodQty.MasterTemplate.AllowColumnReorder = False
        Me.rgvGoodQty.MasterTemplate.AllowDeleteRow = False
        Me.rgvGoodQty.MasterTemplate.AllowDragToGroup = False
        Me.rgvGoodQty.MasterTemplate.AllowEditRow = False
        Me.rgvGoodQty.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.rgvGoodQty.MasterTemplate.AllowRowResize = False
        Me.rgvGoodQty.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvGoodQty.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.rgvGoodQty.Name = "rgvGoodQty"
        Me.rgvGoodQty.Size = New System.Drawing.Size(1003, 455)
        Me.rgvGoodQty.TabIndex = 2
        Me.rgvGoodQty.ThemeName = "CrystalDark"
        '
        'RadPanel4
        '
        Me.RadPanel4.Controls.Add(Me.btnGQCancel)
        Me.RadPanel4.Controls.Add(Me.btnGQSubmit)
        Me.RadPanel4.Controls.Add(Me.RadLabel9)
        Me.RadPanel4.Controls.Add(Me.spnGQQty)
        Me.RadPanel4.Controls.Add(Me.ddGQPartName)
        Me.RadPanel4.Controls.Add(Me.RadLabel8)
        Me.RadPanel4.Controls.Add(Me.ddGQPWNo)
        Me.RadPanel4.Controls.Add(Me.RadLabel7)
        Me.RadPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel4.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(1003, 229)
        Me.RadPanel4.TabIndex = 0
        Me.RadPanel4.ThemeName = "CrystalDark"
        '
        'btnGQCancel
        '
        Me.btnGQCancel.Location = New System.Drawing.Point(201, 133)
        Me.btnGQCancel.Name = "btnGQCancel"
        Me.btnGQCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnGQCancel.TabIndex = 107
        Me.btnGQCancel.Text = "Cancel"
        Me.btnGQCancel.Visible = False
        '
        'btnGQSubmit
        '
        Me.btnGQSubmit.Location = New System.Drawing.Point(85, 133)
        Me.btnGQSubmit.Name = "btnGQSubmit"
        Me.btnGQSubmit.Size = New System.Drawing.Size(110, 24)
        Me.btnGQSubmit.TabIndex = 106
        Me.btnGQSubmit.Text = "SAVE"
        '
        'RadLabel9
        '
        Me.RadLabel9.Location = New System.Drawing.Point(48, 98)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(36, 20)
        Me.RadLabel9.TabIndex = 105
        Me.RadLabel9.Text = "QTY:"
        Me.RadLabel9.ThemeName = "CrystalDark"
        '
        'spnGQQty
        '
        Me.spnGQQty.DecimalPlaces = 2
        Me.spnGQQty.Location = New System.Drawing.Point(86, 97)
        Me.spnGQQty.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnGQQty.Name = "spnGQQty"
        Me.spnGQQty.Size = New System.Drawing.Size(253, 20)
        Me.spnGQQty.TabIndex = 104
        Me.spnGQQty.ThemeName = "Office2007Black"
        CType(Me.spnGQQty.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'ddGQPartName
        '
        Me.ddGQPartName.DropDownAnimationEnabled = True
        Me.ddGQPartName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddGQPartName.Location = New System.Drawing.Point(85, 57)
        Me.ddGQPartName.Name = "ddGQPartName"
        Me.ddGQPartName.Size = New System.Drawing.Size(253, 24)
        Me.ddGQPartName.TabIndex = 21
        Me.ddGQPartName.Text = "RadDropDownList1"
        '
        'RadLabel8
        '
        Me.RadLabel8.Location = New System.Drawing.Point(13, 59)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(79, 20)
        Me.RadLabel8.TabIndex = 20
        Me.RadLabel8.Text = "Part Name: "
        Me.RadLabel8.ThemeName = "CrystalDark"
        '
        'ddGQPWNo
        '
        Me.ddGQPWNo.DropDownAnimationEnabled = True
        Me.ddGQPWNo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddGQPWNo.Location = New System.Drawing.Point(85, 19)
        Me.ddGQPWNo.Name = "ddGQPWNo"
        Me.ddGQPWNo.Size = New System.Drawing.Size(253, 24)
        Me.ddGQPWNo.TabIndex = 19
        Me.ddGQPWNo.Text = "RadDropDownList1"
        '
        'RadLabel7
        '
        Me.RadLabel7.Location = New System.Drawing.Point(47, 21)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(38, 20)
        Me.RadLabel7.TabIndex = 18
        Me.RadLabel7.Text = "TM - "
        Me.RadLabel7.ThemeName = "CrystalDark"
        '
        'Interupt
        '
        Me.Interupt.Controls.Add(Me.RadPanel5)
        Me.Interupt.Image = CType(resources.GetObject("Interupt.Image"), System.Drawing.Image)
        Me.Interupt.ItemSize = New System.Drawing.SizeF(145.0!, 40.0!)
        Me.Interupt.Location = New System.Drawing.Point(281, 37)
        Me.Interupt.Name = "Interupt"
        Me.Interupt.Size = New System.Drawing.Size(1003, 677)
        Me.Interupt.Text = "Interuption Time"
        '
        'RadPanel5
        '
        Me.RadPanel5.Controls.Add(Me.RadPanel6)
        Me.RadPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel5.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(1003, 677)
        Me.RadPanel5.TabIndex = 1
        Me.RadPanel5.ThemeName = "CrystalDark"
        '
        'RadPanel6
        '
        Me.RadPanel6.Controls.Add(Me.ddITType)
        Me.RadPanel6.Controls.Add(Me.lblType)
        Me.RadPanel6.Controls.Add(Me.RadLabel20)
        Me.RadPanel6.Controls.Add(Me.RadLabel13)
        Me.RadPanel6.Controls.Add(Me.tbITTimePart)
        Me.RadPanel6.Controls.Add(Me.spnITPersons)
        Me.RadPanel6.Controls.Add(Me.RadLabel17)
        Me.RadPanel6.Controls.Add(Me.spnITOPTime)
        Me.RadPanel6.Controls.Add(Me.RadLabel18)
        Me.RadPanel6.Controls.Add(Me.spnITUnplanDT)
        Me.RadPanel6.Controls.Add(Me.RadLabel19)
        Me.RadPanel6.Controls.Add(Me.spnITHotto)
        Me.RadPanel6.Controls.Add(Me.spnITPlanDT)
        Me.RadPanel6.Controls.Add(Me.lblTo)
        Me.RadPanel6.Controls.Add(Me.Label2)
        Me.RadPanel6.Controls.Add(Me.btnITSubmit)
        Me.RadPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel6.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(1003, 298)
        Me.RadPanel6.TabIndex = 0
        Me.RadPanel6.ThemeName = "CrystalDark"
        '
        'ddITType
        '
        Me.ddITType.DropDownAnimationEnabled = True
        Me.ddITType.Location = New System.Drawing.Point(171, 11)
        Me.ddITType.Name = "ddITType"
        Me.ddITType.Size = New System.Drawing.Size(146, 20)
        Me.ddITType.TabIndex = 117
        Me.ddITType.Text = "RadDropDownList1"
        Me.ddITType.ThemeName = "Office2007Black"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(127, 14)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(35, 17)
        Me.lblType.TabIndex = 116
        Me.lblType.Text = "TM -"
        '
        'RadLabel20
        '
        Me.RadLabel20.ForeColor = System.Drawing.Color.White
        Me.RadLabel20.Location = New System.Drawing.Point(24, 69)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(135, 18)
        Me.RadLabel20.TabIndex = 115
        Me.RadLabel20.Text = "Start up, 5's, Hotto, Break:"
        '
        'RadLabel13
        '
        Me.RadLabel13.ForeColor = System.Drawing.Color.White
        Me.RadLabel13.Location = New System.Drawing.Point(28, 216)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(102, 18)
        Me.RadLabel13.TabIndex = 113
        Me.RadLabel13.Text = "Line Time Partition:"
        '
        'tbITTimePart
        '
        Me.tbITTimePart.Enabled = False
        Me.tbITTimePart.Location = New System.Drawing.Point(141, 215)
        Me.tbITTimePart.Name = "tbITTimePart"
        Me.tbITTimePart.Size = New System.Drawing.Size(176, 20)
        Me.tbITTimePart.TabIndex = 112
        Me.tbITTimePart.ThemeName = "Office2007Black"
        '
        'spnITPersons
        '
        Me.spnITPersons.DecimalPlaces = 2
        Me.spnITPersons.Location = New System.Drawing.Point(141, 187)
        Me.spnITPersons.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnITPersons.Name = "spnITPersons"
        Me.spnITPersons.Size = New System.Drawing.Size(176, 20)
        Me.spnITPersons.TabIndex = 110
        Me.spnITPersons.ThemeName = "Office2007Black"
        CType(Me.spnITPersons.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel17
        '
        Me.RadLabel17.ForeColor = System.Drawing.Color.White
        Me.RadLabel17.Location = New System.Drawing.Point(14, 188)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(118, 18)
        Me.RadLabel17.TabIndex = 111
        Me.RadLabel17.Text = "No. of Persons (w/ TL):"
        '
        'spnITOPTime
        '
        Me.spnITOPTime.DecimalPlaces = 2
        Me.spnITOPTime.Enabled = False
        Me.spnITOPTime.Location = New System.Drawing.Point(141, 157)
        Me.spnITOPTime.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnITOPTime.Name = "spnITOPTime"
        Me.spnITOPTime.Size = New System.Drawing.Size(176, 20)
        Me.spnITOPTime.TabIndex = 108
        Me.spnITOPTime.ThemeName = "Office2007Black"
        CType(Me.spnITOPTime.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel18
        '
        Me.RadLabel18.ForeColor = System.Drawing.Color.White
        Me.RadLabel18.Location = New System.Drawing.Point(14, 158)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(116, 18)
        Me.RadLabel18.TabIndex = 109
        Me.RadLabel18.Text = "Operation Time (Min):"
        '
        'spnITUnplanDT
        '
        Me.spnITUnplanDT.DecimalPlaces = 2
        Me.spnITUnplanDT.Location = New System.Drawing.Point(171, 126)
        Me.spnITUnplanDT.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnITUnplanDT.Name = "spnITUnplanDT"
        Me.spnITUnplanDT.ReadOnly = True
        Me.spnITUnplanDT.Size = New System.Drawing.Size(146, 20)
        Me.spnITUnplanDT.TabIndex = 106
        Me.spnITUnplanDT.ThemeName = "Office2007Black"
        CType(Me.spnITUnplanDT.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel19
        '
        Me.RadLabel19.ForeColor = System.Drawing.Color.White
        Me.RadLabel19.Location = New System.Drawing.Point(37, 126)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(122, 18)
        Me.RadLabel19.TabIndex = 107
        Me.RadLabel19.Text = "Un-planned Downtime:"
        '
        'spnITHotto
        '
        Me.spnITHotto.DecimalPlaces = 2
        Me.spnITHotto.Location = New System.Drawing.Point(171, 66)
        Me.spnITHotto.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnITHotto.Name = "spnITHotto"
        Me.spnITHotto.Size = New System.Drawing.Size(146, 20)
        Me.spnITHotto.TabIndex = 104
        Me.spnITHotto.ThemeName = "Office2007Black"
        CType(Me.spnITHotto.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'spnITPlanDT
        '
        Me.spnITPlanDT.DecimalPlaces = 2
        Me.spnITPlanDT.Location = New System.Drawing.Point(171, 96)
        Me.spnITPlanDT.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnITPlanDT.Name = "spnITPlanDT"
        Me.spnITPlanDT.ReadOnly = True
        Me.spnITPlanDT.Size = New System.Drawing.Size(146, 20)
        Me.spnITPlanDT.TabIndex = 103
        Me.spnITPlanDT.ThemeName = "Office2007Black"
        CType(Me.spnITPlanDT.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'lblTo
        '
        Me.lblTo.ForeColor = System.Drawing.Color.White
        Me.lblTo.Location = New System.Drawing.Point(56, 96)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(103, 18)
        Me.lblTo.TabIndex = 105
        Me.lblTo.Text = "Planned Downtime:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Interruption Time:"
        '
        'btnITSubmit
        '
        Me.btnITSubmit.Location = New System.Drawing.Point(13, 254)
        Me.btnITSubmit.Name = "btnITSubmit"
        Me.btnITSubmit.Size = New System.Drawing.Size(110, 24)
        Me.btnITSubmit.TabIndex = 27
        Me.btnITSubmit.Text = "SAVE"
        '
        'Defects
        '
        Me.Defects.Controls.Add(Me.RadPanel9)
        Me.Defects.Image = CType(resources.GetObject("Defects.Image"), System.Drawing.Image)
        Me.Defects.ItemSize = New System.Drawing.SizeF(145.0!, 40.0!)
        Me.Defects.Location = New System.Drawing.Point(281, 30)
        Me.Defects.Name = "Defects"
        Me.Defects.Size = New System.Drawing.Size(1003, 684)
        Me.Defects.Text = "Defective Details"
        '
        'RadPanel9
        '
        Me.RadPanel9.Controls.Add(Me.rgvSRCDefects)
        Me.RadPanel9.Controls.Add(Me.RadPanel10)
        Me.RadPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel9.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(1003, 684)
        Me.RadPanel9.TabIndex = 1
        Me.RadPanel9.ThemeName = "CrystalDark"
        '
        'rgvSRCDefects
        '
        Me.rgvSRCDefects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvSRCDefects.Location = New System.Drawing.Point(0, 142)
        '
        '
        '
        Me.rgvSRCDefects.MasterTemplate.AllowAddNewRow = False
        Me.rgvSRCDefects.MasterTemplate.AllowCellContextMenu = False
        Me.rgvSRCDefects.MasterTemplate.AllowColumnChooser = False
        Me.rgvSRCDefects.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvSRCDefects.MasterTemplate.AllowColumnReorder = False
        Me.rgvSRCDefects.MasterTemplate.AllowDeleteRow = False
        Me.rgvSRCDefects.MasterTemplate.AllowDragToGroup = False
        Me.rgvSRCDefects.MasterTemplate.AllowEditRow = False
        Me.rgvSRCDefects.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.rgvSRCDefects.MasterTemplate.AllowRowResize = False
        Me.rgvSRCDefects.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.rgvSRCDefects.Name = "rgvSRCDefects"
        Me.rgvSRCDefects.Size = New System.Drawing.Size(1003, 542)
        Me.rgvSRCDefects.TabIndex = 5
        Me.rgvSRCDefects.ThemeName = "CrystalDark"
        '
        'RadPanel10
        '
        Me.RadPanel10.Controls.Add(Me.lblDefectID)
        Me.RadPanel10.Controls.Add(Me.spnDEFNo)
        Me.RadPanel10.Controls.Add(Me.RadLabel5)
        Me.RadPanel10.Controls.Add(Me.btnSPDCancel)
        Me.RadPanel10.Controls.Add(Me.btnSPDSubmit)
        Me.RadPanel10.Controls.Add(Me.tbDEFDefect)
        Me.RadPanel10.Controls.Add(Me.RadLabel36)
        Me.RadPanel10.Controls.Add(Me.ddDEFPart)
        Me.RadPanel10.Controls.Add(Me.RadLabel37)
        Me.RadPanel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel10.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel10.Name = "RadPanel10"
        Me.RadPanel10.Size = New System.Drawing.Size(1003, 142)
        Me.RadPanel10.TabIndex = 0
        Me.RadPanel10.ThemeName = "CrystalDark"
        '
        'lblDefectID
        '
        Me.lblDefectID.Location = New System.Drawing.Point(463, 61)
        Me.lblDefectID.Name = "lblDefectID"
        Me.lblDefectID.Size = New System.Drawing.Size(76, 20)
        Me.lblDefectID.TabIndex = 114
        Me.lblDefectID.Text = "Part Name:"
        Me.lblDefectID.ThemeName = "CrystalDark"
        '
        'spnDEFNo
        '
        Me.spnDEFNo.DecimalPlaces = 2
        Me.spnDEFNo.Location = New System.Drawing.Point(108, 76)
        Me.spnDEFNo.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnDEFNo.Name = "spnDEFNo"
        Me.spnDEFNo.Size = New System.Drawing.Size(193, 20)
        Me.spnDEFNo.TabIndex = 112
        Me.spnDEFNo.ThemeName = "Office2007Black"
        CType(Me.spnDEFNo.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel5
        '
        Me.RadLabel5.ForeColor = System.Drawing.Color.White
        Me.RadLabel5.Location = New System.Drawing.Point(31, 77)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(76, 18)
        Me.RadLabel5.TabIndex = 113
        Me.RadLabel5.Text = "No of Defect: "
        '
        'btnSPDCancel
        '
        Me.btnSPDCancel.Location = New System.Drawing.Point(208, 102)
        Me.btnSPDCancel.Name = "btnSPDCancel"
        Me.btnSPDCancel.Size = New System.Drawing.Size(85, 24)
        Me.btnSPDCancel.TabIndex = 30
        Me.btnSPDCancel.Text = "Cancel"
        Me.btnSPDCancel.Visible = False
        '
        'btnSPDSubmit
        '
        Me.btnSPDSubmit.Location = New System.Drawing.Point(108, 102)
        Me.btnSPDSubmit.Name = "btnSPDSubmit"
        Me.btnSPDSubmit.Size = New System.Drawing.Size(94, 24)
        Me.btnSPDSubmit.TabIndex = 29
        Me.btnSPDSubmit.Text = "SAVE"
        '
        'tbDEFDefect
        '
        Me.tbDEFDefect.Location = New System.Drawing.Point(108, 44)
        Me.tbDEFDefect.Name = "tbDEFDefect"
        Me.tbDEFDefect.Size = New System.Drawing.Size(193, 24)
        Me.tbDEFDefect.TabIndex = 12
        '
        'RadLabel36
        '
        Me.RadLabel36.Location = New System.Drawing.Point(56, 47)
        Me.RadLabel36.Name = "RadLabel36"
        Me.RadLabel36.Size = New System.Drawing.Size(50, 20)
        Me.RadLabel36.TabIndex = 11
        Me.RadLabel36.Text = "Defect:"
        Me.RadLabel36.ThemeName = "CrystalDark"
        '
        'ddDEFPart
        '
        Me.ddDEFPart.DropDownAnimationEnabled = True
        Me.ddDEFPart.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem4.Text = "A. Function Tester"
        RadListDataItem5.Text = "B. Electrical Test"
        RadListDataItem6.Text = "C. Final Tester"
        RadListDataItem7.Text = "D. Defective Quantity"
        Me.ddDEFPart.Items.Add(RadListDataItem4)
        Me.ddDEFPart.Items.Add(RadListDataItem5)
        Me.ddDEFPart.Items.Add(RadListDataItem6)
        Me.ddDEFPart.Items.Add(RadListDataItem7)
        Me.ddDEFPart.Location = New System.Drawing.Point(108, 13)
        Me.ddDEFPart.Name = "ddDEFPart"
        Me.ddDEFPart.Size = New System.Drawing.Size(193, 24)
        Me.ddDEFPart.TabIndex = 8
        '
        'RadLabel37
        '
        Me.RadLabel37.Location = New System.Drawing.Point(37, 16)
        Me.RadLabel37.Name = "RadLabel37"
        Me.RadLabel37.Size = New System.Drawing.Size(76, 20)
        Me.RadLabel37.TabIndex = 7
        Me.RadLabel37.Text = "Part Name:"
        Me.RadLabel37.ThemeName = "CrystalDark"
        '
        'Others
        '
        Me.Others.Controls.Add(Me.rgvOthers)
        Me.Others.Controls.Add(Me.RadPanel7)
        Me.Others.Image = Global.MIA.My.Resources.Resources.other
        Me.Others.ItemSize = New System.Drawing.SizeF(145.0!, 40.0!)
        Me.Others.Location = New System.Drawing.Point(281, 30)
        Me.Others.Name = "Others"
        Me.Others.Size = New System.Drawing.Size(1003, 684)
        Me.Others.Text = "Others"
        '
        'rgvOthers
        '
        Me.rgvOthers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvOthers.Location = New System.Drawing.Point(0, 88)
        '
        '
        '
        Me.rgvOthers.MasterTemplate.AllowAddNewRow = False
        Me.rgvOthers.MasterTemplate.AllowCellContextMenu = False
        Me.rgvOthers.MasterTemplate.AllowColumnChooser = False
        Me.rgvOthers.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvOthers.MasterTemplate.AllowColumnReorder = False
        Me.rgvOthers.MasterTemplate.AllowDeleteRow = False
        Me.rgvOthers.MasterTemplate.AllowDragToGroup = False
        Me.rgvOthers.MasterTemplate.AllowEditRow = False
        Me.rgvOthers.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.rgvOthers.MasterTemplate.AllowRowResize = False
        Me.rgvOthers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvOthers.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.rgvOthers.Name = "rgvOthers"
        Me.rgvOthers.Size = New System.Drawing.Size(1003, 596)
        Me.rgvOthers.TabIndex = 3
        Me.rgvOthers.ThemeName = "CrystalDark"
        '
        'RadPanel7
        '
        Me.RadPanel7.Controls.Add(Me.lblOtherID)
        Me.RadPanel7.Controls.Add(Me.btnOthCancel)
        Me.RadPanel7.Controls.Add(Me.btnOthSave)
        Me.RadPanel7.Controls.Add(Me.tbOthDetails)
        Me.RadPanel7.Controls.Add(Me.RadLabel14)
        Me.RadPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel7.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(1003, 88)
        Me.RadPanel7.TabIndex = 2
        Me.RadPanel7.ThemeName = "CrystalDark"
        '
        'lblOtherID
        '
        Me.lblOtherID.Location = New System.Drawing.Point(785, 20)
        Me.lblOtherID.Name = "lblOtherID"
        Me.lblOtherID.Size = New System.Drawing.Size(50, 20)
        Me.lblOtherID.TabIndex = 15
        Me.lblOtherID.Text = "Status:"
        Me.lblOtherID.ThemeName = "CrystalDark"
        '
        'btnOthCancel
        '
        Me.btnOthCancel.Location = New System.Drawing.Point(184, 48)
        Me.btnOthCancel.Name = "btnOthCancel"
        Me.btnOthCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnOthCancel.TabIndex = 14
        Me.btnOthCancel.Text = "Cancel"
        Me.btnOthCancel.Visible = False
        '
        'btnOthSave
        '
        Me.btnOthSave.Location = New System.Drawing.Point(68, 48)
        Me.btnOthSave.Name = "btnOthSave"
        Me.btnOthSave.Size = New System.Drawing.Size(110, 24)
        Me.btnOthSave.TabIndex = 13
        Me.btnOthSave.Text = "SAVE"
        '
        'tbOthDetails
        '
        Me.tbOthDetails.Location = New System.Drawing.Point(68, 18)
        Me.tbOthDetails.Name = "tbOthDetails"
        Me.tbOthDetails.Size = New System.Drawing.Size(535, 24)
        Me.tbOthDetails.TabIndex = 10
        '
        'RadLabel14
        '
        Me.RadLabel14.Location = New System.Drawing.Point(18, 20)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(56, 20)
        Me.RadLabel14.TabIndex = 9
        Me.RadLabel14.Text = "Details: "
        Me.RadLabel14.ThemeName = "CrystalDark"
        '
        'Lot
        '
        Me.Lot.Controls.Add(Me.RadPanel12)
        Me.Lot.Image = CType(resources.GetObject("Lot.Image"), System.Drawing.Image)
        Me.Lot.ItemSize = New System.Drawing.SizeF(145.0!, 40.0!)
        Me.Lot.Location = New System.Drawing.Point(281, 30)
        Me.Lot.Name = "Lot"
        Me.Lot.Size = New System.Drawing.Size(1003, 684)
        Me.Lot.Text = "RM & WIP Lot No."
        '
        'RadPanel12
        '
        Me.RadPanel12.Controls.Add(Me.rgvLotNo)
        Me.RadPanel12.Controls.Add(Me.RadPanel13)
        Me.RadPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel12.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel12.Name = "RadPanel12"
        Me.RadPanel12.Size = New System.Drawing.Size(1003, 684)
        Me.RadPanel12.TabIndex = 1
        Me.RadPanel12.ThemeName = "CrystalDark"
        '
        'rgvLotNo
        '
        Me.rgvLotNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvLotNo.Location = New System.Drawing.Point(0, 235)
        '
        '
        '
        Me.rgvLotNo.MasterTemplate.AllowAddNewRow = False
        Me.rgvLotNo.MasterTemplate.AllowCellContextMenu = False
        Me.rgvLotNo.MasterTemplate.AllowColumnChooser = False
        Me.rgvLotNo.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvLotNo.MasterTemplate.AllowColumnReorder = False
        Me.rgvLotNo.MasterTemplate.AllowDeleteRow = False
        Me.rgvLotNo.MasterTemplate.AllowDragToGroup = False
        Me.rgvLotNo.MasterTemplate.AllowEditRow = False
        Me.rgvLotNo.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.rgvLotNo.MasterTemplate.AllowRowResize = False
        Me.rgvLotNo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgvLotNo.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.rgvLotNo.Name = "rgvLotNo"
        Me.rgvLotNo.Size = New System.Drawing.Size(1003, 449)
        Me.rgvLotNo.TabIndex = 6
        Me.rgvLotNo.ThemeName = "CrystalDark"
        '
        'RadPanel13
        '
        Me.RadPanel13.Controls.Add(Me.ddLotAssy)
        Me.RadPanel13.Controls.Add(Me.RadLabel6)
        Me.RadPanel13.Controls.Add(Me.lblLotID)
        Me.RadPanel13.Controls.Add(Me.btnLotCancel)
        Me.RadPanel13.Controls.Add(Me.btnLotSubmit)
        Me.RadPanel13.Controls.Add(Me.tbLotLotNo)
        Me.RadPanel13.Controls.Add(Me.RadLabel47)
        Me.RadPanel13.Controls.Add(Me.tbLotBoxNo)
        Me.RadPanel13.Controls.Add(Me.RadLabel46)
        Me.RadPanel13.Controls.Add(Me.ddLotPartName)
        Me.RadPanel13.Controls.Add(Me.RadLabel45)
        Me.RadPanel13.Controls.Add(Me.ddLotTime)
        Me.RadPanel13.Controls.Add(Me.RadLabel44)
        Me.RadPanel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel13.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel13.Name = "RadPanel13"
        Me.RadPanel13.Size = New System.Drawing.Size(1003, 235)
        Me.RadPanel13.TabIndex = 0
        Me.RadPanel13.ThemeName = "CrystalDark"
        '
        'ddLotAssy
        '
        Me.ddLotAssy.DropDownAnimationEnabled = True
        Me.ddLotAssy.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddLotAssy.Location = New System.Drawing.Point(84, 14)
        Me.ddLotAssy.Name = "ddLotAssy"
        Me.ddLotAssy.Size = New System.Drawing.Size(193, 24)
        Me.ddLotAssy.TabIndex = 34
        Me.ddLotAssy.Text = "RadDropDownList1"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(20, 15)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(68, 20)
        Me.RadLabel6.TabIndex = 33
        Me.RadLabel6.Text = "Assy. No.:"
        Me.RadLabel6.ThemeName = "CrystalDark"
        '
        'lblLotID
        '
        Me.lblLotID.Location = New System.Drawing.Point(452, 103)
        Me.lblLotID.Name = "lblLotID"
        Me.lblLotID.Size = New System.Drawing.Size(41, 20)
        Me.lblLotID.TabIndex = 32
        Me.lblLotID.Text = "Time:"
        Me.lblLotID.ThemeName = "CrystalDark"
        '
        'btnLotCancel
        '
        Me.btnLotCancel.Location = New System.Drawing.Point(192, 197)
        Me.btnLotCancel.Name = "btnLotCancel"
        Me.btnLotCancel.Size = New System.Drawing.Size(85, 24)
        Me.btnLotCancel.TabIndex = 31
        Me.btnLotCancel.Text = "Cancel"
        Me.btnLotCancel.Visible = False
        '
        'btnLotSubmit
        '
        Me.btnLotSubmit.Location = New System.Drawing.Point(86, 197)
        Me.btnLotSubmit.Name = "btnLotSubmit"
        Me.btnLotSubmit.Size = New System.Drawing.Size(100, 24)
        Me.btnLotSubmit.TabIndex = 19
        Me.btnLotSubmit.Text = "SAVE"
        '
        'tbLotLotNo
        '
        Me.tbLotLotNo.Location = New System.Drawing.Point(84, 162)
        Me.tbLotLotNo.Name = "tbLotLotNo"
        Me.tbLotLotNo.Size = New System.Drawing.Size(193, 24)
        Me.tbLotLotNo.TabIndex = 16
        '
        'RadLabel47
        '
        Me.RadLabel47.Location = New System.Drawing.Point(34, 163)
        Me.RadLabel47.Name = "RadLabel47"
        Me.RadLabel47.Size = New System.Drawing.Size(55, 20)
        Me.RadLabel47.TabIndex = 15
        Me.RadLabel47.Text = "Lot No.:"
        Me.RadLabel47.ThemeName = "CrystalDark"
        '
        'tbLotBoxNo
        '
        Me.tbLotBoxNo.Location = New System.Drawing.Point(84, 125)
        Me.tbLotBoxNo.Name = "tbLotBoxNo"
        Me.tbLotBoxNo.Size = New System.Drawing.Size(193, 24)
        Me.tbLotBoxNo.TabIndex = 14
        '
        'RadLabel46
        '
        Me.RadLabel46.Location = New System.Drawing.Point(32, 126)
        Me.RadLabel46.Name = "RadLabel46"
        Me.RadLabel46.Size = New System.Drawing.Size(58, 20)
        Me.RadLabel46.TabIndex = 13
        Me.RadLabel46.Text = "Box No.:"
        Me.RadLabel46.ThemeName = "CrystalDark"
        '
        'ddLotPartName
        '
        Me.ddLotPartName.DropDownAnimationEnabled = True
        Me.ddLotPartName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddLotPartName.Location = New System.Drawing.Point(84, 88)
        Me.ddLotPartName.Name = "ddLotPartName"
        Me.ddLotPartName.Size = New System.Drawing.Size(193, 24)
        Me.ddLotPartName.TabIndex = 12
        Me.ddLotPartName.Text = "RadDropDownList1"
        '
        'RadLabel45
        '
        Me.RadLabel45.Location = New System.Drawing.Point(16, 89)
        Me.RadLabel45.Name = "RadLabel45"
        Me.RadLabel45.Size = New System.Drawing.Size(76, 20)
        Me.RadLabel45.TabIndex = 11
        Me.RadLabel45.Text = "Part Name:"
        Me.RadLabel45.ThemeName = "CrystalDark"
        '
        'ddLotTime
        '
        Me.ddLotTime.DropDownAnimationEnabled = True
        Me.ddLotTime.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddLotTime.Location = New System.Drawing.Point(84, 51)
        Me.ddLotTime.Name = "ddLotTime"
        Me.ddLotTime.Size = New System.Drawing.Size(193, 24)
        Me.ddLotTime.TabIndex = 10
        Me.ddLotTime.Text = "RadDropDownList1"
        '
        'RadLabel44
        '
        Me.RadLabel44.Location = New System.Drawing.Point(46, 51)
        Me.RadLabel44.Name = "RadLabel44"
        Me.RadLabel44.Size = New System.Drawing.Size(41, 20)
        Me.RadLabel44.TabIndex = 9
        Me.RadLabel44.Text = "Time:"
        Me.RadLabel44.ThemeName = "CrystalDark"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'FrmATDailyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 751)
        Me.Controls.Add(Me.RadPageView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmATDailyReport"
        Me.Text = "Auto Taping"
        Me.ThemeName = "CrystalDark"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnReCons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSRCAutoAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.Manpower.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.rgvManpower.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvManpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        Me.RadPanel2.PerformLayout()
        CType(Me.ddMPPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEditID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMPCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMPSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMPStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMPEmpName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMPProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GoodQty.ResumeLayout(False)
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me.rgvGoodQty.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvGoodQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel4.ResumeLayout(False)
        Me.RadPanel4.PerformLayout()
        CType(Me.btnGQCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGQSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnGQQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddGQPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddGQPWNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Interupt.ResumeLayout(False)
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel5.ResumeLayout(False)
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel6.ResumeLayout(False)
        Me.RadPanel6.PerformLayout()
        CType(Me.ddITType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbITTimePart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnITPersons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnITOPTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnITUnplanDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnITHotto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnITPlanDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnITSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Defects.ResumeLayout(False)
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel9.ResumeLayout(False)
        CType(Me.rgvSRCDefects.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSRCDefects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel10.ResumeLayout(False)
        Me.RadPanel10.PerformLayout()
        CType(Me.lblDefectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnDEFNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSPDCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSPDSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDEFDefect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddDEFPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel37, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Others.ResumeLayout(False)
        CType(Me.rgvOthers.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvOthers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel7.ResumeLayout(False)
        Me.RadPanel7.PerformLayout()
        CType(Me.lblOtherID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOthCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOthSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOthDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lot.ResumeLayout(False)
        CType(Me.RadPanel12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel12.ResumeLayout(False)
        CType(Me.rgvLotNo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel13.ResumeLayout(False)
        Me.RadPanel13.PerformLayout()
        CType(Me.ddLotAssy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLotID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLotCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLotSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLotLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLotBoxNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLotPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLotTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReCons As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents lblLoading As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSRCAutoAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents Manpower As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvManpower As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents ddMPPW As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblEditID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnMPCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnMPSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddMPStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbMPEmpName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddMPProc As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents GoodQty As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvGoodQty As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnGQCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnGQSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnGQQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents ddGQPartName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddGQPWNo As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Interupt As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents ddITType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblType As Label
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbITTimePart As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents spnITPersons As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnITOPTime As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnITUnplanDT As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnITHotto As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents spnITPlanDT As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnITSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents Defects As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvSRCDefects As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel10 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnSPDCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSPDSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents tbDEFDefect As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel36 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddDEFPart As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel37 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Lot As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel12 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvLotNo As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel13 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents ddLotAssy As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblLotID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnLotCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnLotSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents tbLotLotNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel47 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbLotBoxNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel46 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddLotPartName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel45 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddLotTime As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel44 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnDEFNo As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDefectID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Others As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rgvOthers As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblOtherID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnOthCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnOthSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents tbOthDetails As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
End Class

