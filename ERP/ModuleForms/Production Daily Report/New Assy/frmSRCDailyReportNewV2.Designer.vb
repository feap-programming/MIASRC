<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSRCDailyReportNewV2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSRCDailyReportNewV2))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim TableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReCons = New Telerik.WinControls.UI.RadButton()
        Me.RadProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
        Me.lblLoading = New Telerik.WinControls.UI.RadLabel()
        Me.btnSRCAutoAdd = New Telerik.WinControls.UI.RadButton()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.FluentDarkTheme1 = New Telerik.WinControls.Themes.FluentDarkTheme()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.Manpower = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvManpower = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.rcbTrainee = New Telerik.WinControls.UI.RadCheckBox()
        Me.rcbTransfer = New Telerik.WinControls.UI.RadCheckBox()
        Me.rcbQualified = New Telerik.WinControls.UI.RadCheckBox()
        Me.txtManpower = New Telerik.WinControls.UI.RadTextBox()
        Me.ddTeam = New Telerik.WinControls.UI.RadDropDownList()
        Me.cbManpower = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.lblEditID = New Telerik.WinControls.UI.RadLabel()
        Me.btnMPCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnMPSubmit = New Telerik.WinControls.UI.RadButton()
        Me.ddStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.ddProc = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Hourly = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvHourly = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.RadScrollablePanel2 = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.lblHQEdit = New Telerik.WinControls.UI.RadLabel()
        Me.btnHQCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnHQSubmit = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.spnHQFinal = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.spnHQFunction = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.spnHQElectrical = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.spnHQDeviation = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.spnHQActual = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.spnHQPlan = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.tbHQBarcode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.spnHQSleeve = New Telerik.WinControls.UI.RadTextBox()
        Me.spnHQSubstator = New Telerik.WinControls.UI.RadTextBox()
        Me.spnHQStator = New Telerik.WinControls.UI.RadTextBox()
        Me.spnHQRotator = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cbHQ3 = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbHQ2 = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbHQ1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.ddHQTime = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.Assylinef = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvAssyLineEff = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.RadScrollablePanel3 = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.lblOptimeText = New Telerik.WinControls.UI.RadLabel()
        Me.lblTotalOperationTime = New Telerik.WinControls.UI.RadLabel()
        Me.btnAssyCancel = New Telerik.WinControls.UI.RadButton()
        Me.lblTotalQty = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel52 = New Telerik.WinControls.UI.RadLabel()
        Me.tbCycle = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel51 = New Telerik.WinControls.UI.RadLabel()
        Me.tbUnplanned = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel50 = New Telerik.WinControls.UI.RadLabel()
        Me.tbPlanned = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel49 = New Telerik.WinControls.UI.RadLabel()
        Me.tbALEOpTime = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.btnALESubmit = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.cbModelName = New Telerik.WinControls.UI.RadDropDownList()
        Me.cbDelivered = New System.Windows.Forms.CheckBox()
        Me.btnALEAdd = New Telerik.WinControls.UI.RadButton()
        Me.spnALESample = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel27 = New Telerik.WinControls.UI.RadLabel()
        Me.spnALEScrap = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel26 = New Telerik.WinControls.UI.RadLabel()
        Me.spnALEReplace = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel25 = New Telerik.WinControls.UI.RadLabel()
        Me.spnALEGoodQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
        Me.tbALELotNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel23 = New Telerik.WinControls.UI.RadLabel()
        Me.tbALEModelCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel22 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel21 = New Telerik.WinControls.UI.RadLabel()
        Me.tbALEFGNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        Me.tbALECustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.btnEdit = New System.Windows.Forms.PictureBox()
        Me.tbALETime = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.spnALEHotto = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.SRCAssy = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvSRCAssy = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        Me.btnSACancel = New Telerik.WinControls.UI.RadButton()
        Me.lblSRCAssyID = New Telerik.WinControls.UI.RadLabel()
        Me.btnSASubmit = New Telerik.WinControls.UI.RadButton()
        Me.tbSAEng = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel34 = New Telerik.WinControls.UI.RadLabel()
        Me.tbSAQASample = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel33 = New Telerik.WinControls.UI.RadLabel()
        Me.tbSAPurge = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel32 = New Telerik.WinControls.UI.RadLabel()
        Me.tbSAScrap = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel31 = New Telerik.WinControls.UI.RadLabel()
        Me.tbSALotNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel29 = New Telerik.WinControls.UI.RadLabel()
        Me.tbSAPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel28 = New Telerik.WinControls.UI.RadLabel()
        Me.ddSAPartNo = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel30 = New Telerik.WinControls.UI.RadLabel()
        Me.Defects = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.rgvSRCDefects = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel10 = New Telerik.WinControls.UI.RadPanel()
        Me.lblDefectID = New Telerik.WinControls.UI.RadLabel()
        Me.btnSPDCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSPDSubmit = New Telerik.WinControls.UI.RadButton()
        Me.spnSPDRM = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel43 = New Telerik.WinControls.UI.RadLabel()
        Me.spnSPDSubAssy = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel42 = New Telerik.WinControls.UI.RadLabel()
        Me.spnSPDFFC = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel41 = New Telerik.WinControls.UI.RadLabel()
        Me.spnSPDIM = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel40 = New Telerik.WinControls.UI.RadLabel()
        Me.spnSPDMachine = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel39 = New Telerik.WinControls.UI.RadLabel()
        Me.spnSPDMan = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel38 = New Telerik.WinControls.UI.RadLabel()
        Me.tbSPDPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel36 = New Telerik.WinControls.UI.RadLabel()
        Me.ddSPDCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel35 = New Telerik.WinControls.UI.RadLabel()
        Me.ddSPDCategory = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel37 = New Telerik.WinControls.UI.RadLabel()
        Me.Other = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPanel11 = New Telerik.WinControls.UI.RadPanel()
        Me.RadScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.RadGroupBox8 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tbOtherC = New Telerik.WinControls.UI.RadTextBox()
        Me.RadGroupBox7 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tbOtherB = New Telerik.WinControls.UI.RadTextBox()
        Me.RadGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tbOtherA = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel14 = New Telerik.WinControls.UI.RadPanel()
        Me.btnSubmitOther = New Telerik.WinControls.UI.RadButton()
        Me.Lot = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadScrollablePanel4 = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.btnLotSubmit = New Telerik.WinControls.UI.RadButton()
        Me.rgvLotNo = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel12 = New Telerik.WinControls.UI.RadPanel()
        Me.txtBoxNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel45 = New Telerik.WinControls.UI.RadLabel()
        Me.ddLotTime = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel44 = New Telerik.WinControls.UI.RadLabel()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
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
        CType(Me.rcbTrainee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcbTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rcbQualified, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtManpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbManpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbManpower.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbManpower.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEditID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMPCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMPSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Hourly.SuspendLayout()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.rgvHourly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvHourly.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel4.SuspendLayout()
        CType(Me.RadScrollablePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadScrollablePanel2.PanelContainer.SuspendLayout()
        Me.RadScrollablePanel2.SuspendLayout()
        CType(Me.lblHQEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHQCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHQSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.spnHQFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHQFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHQElectrical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHQDeviation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHQActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHQPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbHQBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.spnHQSleeve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHQSubstator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHQStator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHQRotator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.cbHQ3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbHQ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbHQ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddHQTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Assylinef.SuspendLayout()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel5.SuspendLayout()
        CType(Me.rgvAssyLineEff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvAssyLineEff.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel6.SuspendLayout()
        CType(Me.RadScrollablePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadScrollablePanel3.PanelContainer.SuspendLayout()
        Me.RadScrollablePanel3.SuspendLayout()
        CType(Me.lblOptimeText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblOptimeText.SuspendLayout()
        CType(Me.lblTotalOperationTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAssyCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCycle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbUnplanned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbPlanned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbALEOpTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnALESubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbModelName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnALEAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnALESample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnALEScrap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnALEReplace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnALEGoodQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbALELotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbALEModelCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbALEFGNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbALECustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbALETime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnALEHotto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SRCAssy.SuspendLayout()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel7.SuspendLayout()
        CType(Me.rgvSRCAssy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSRCAssy.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel8.SuspendLayout()
        CType(Me.btnSACancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSRCAssyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSASubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSAEng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSAQASample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSAPurge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSAScrap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSALotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSAPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSAPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel30, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Defects.SuspendLayout()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel9.SuspendLayout()
        CType(Me.rgvSRCDefects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvSRCDefects.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel10.SuspendLayout()
        CType(Me.lblDefectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSPDCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSPDSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnSPDRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnSPDSubAssy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnSPDFFC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnSPDIM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnSPDMachine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnSPDMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSPDPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSPDCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSPDCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel37, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Other.SuspendLayout()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel11.SuspendLayout()
        CType(Me.RadScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadScrollablePanel1.PanelContainer.SuspendLayout()
        Me.RadScrollablePanel1.SuspendLayout()
        CType(Me.RadGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox8.SuspendLayout()
        CType(Me.tbOtherC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox7.SuspendLayout()
        CType(Me.tbOtherB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox6.SuspendLayout()
        CType(Me.tbOtherA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel14.SuspendLayout()
        CType(Me.btnSubmitOther, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lot.SuspendLayout()
        CType(Me.RadScrollablePanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadScrollablePanel4.PanelContainer.SuspendLayout()
        Me.RadScrollablePanel4.SuspendLayout()
        CType(Me.btnLotSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvLotNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvLotNo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel12.SuspendLayout()
        CType(Me.txtBoxNo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1369, 38)
        Me.Panel1.TabIndex = 3
        '
        'btnReCons
        '
        Me.btnReCons.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReCons.Location = New System.Drawing.Point(1184, 6)
        Me.btnReCons.Name = "btnReCons"
        Me.btnReCons.Size = New System.Drawing.Size(88, 24)
        Me.btnReCons.TabIndex = 16
        Me.btnReCons.Text = "ADJUST"
        '
        'RadProgressBar1
        '
        Me.RadProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadProgressBar1.ForeColor = System.Drawing.Color.Black
        Me.RadProgressBar1.Location = New System.Drawing.Point(1048, 6)
        Me.RadProgressBar1.Name = "RadProgressBar1"
        Me.RadProgressBar1.Size = New System.Drawing.Size(130, 24)
        Me.RadProgressBar1.TabIndex = 16
        Me.RadProgressBar1.ThemeName = "TelerikMetroBlue"
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoading.Location = New System.Drawing.Point(760, 10)
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
        Me.btnSRCAutoAdd.Location = New System.Drawing.Point(1278, 6)
        Me.btnSRCAutoAdd.Name = "btnSRCAutoAdd"
        Me.btnSRCAutoAdd.Size = New System.Drawing.Size(88, 24)
        Me.btnSRCAutoAdd.TabIndex = 14
        Me.btnSRCAutoAdd.Text = "AUTO ADD"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.Manpower)
        Me.RadPageView1.Controls.Add(Me.Hourly)
        Me.RadPageView1.Controls.Add(Me.Assylinef)
        Me.RadPageView1.Controls.Add(Me.SRCAssy)
        Me.RadPageView1.Controls.Add(Me.Defects)
        Me.RadPageView1.Controls.Add(Me.Other)
        Me.RadPageView1.Controls.Add(Me.Lot)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Location = New System.Drawing.Point(0, 38)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.Lot
        Me.RadPageView1.Size = New System.Drawing.Size(1369, 691)
        Me.RadPageView1.TabIndex = 4
        Me.RadPageView1.ThemeName = "FluentDark"
        Me.RadPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView
        '
        'Manpower
        '
        Me.Manpower.Controls.Add(Me.RadPanel1)
        Me.Manpower.Image = CType(resources.GetObject("Manpower.Image"), System.Drawing.Image)
        Me.Manpower.ItemSize = New System.Drawing.SizeF(176.0!, 40.0!)
        Me.Manpower.Location = New System.Drawing.Point(281, 37)
        Me.Manpower.Name = "Manpower"
        Me.Manpower.Size = New System.Drawing.Size(1087, 653)
        Me.Manpower.Text = "Manpower"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.rgvManpower)
        Me.RadPanel1.Controls.Add(Me.RadPanel2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1087, 653)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.ThemeName = "CrystalDark"
        '
        'rgvManpower
        '
        Me.rgvManpower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvManpower.Location = New System.Drawing.Point(0, 175)
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
        Me.rgvManpower.Size = New System.Drawing.Size(1087, 478)
        Me.rgvManpower.TabIndex = 1
        Me.rgvManpower.ThemeName = "CrystalDark"
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.rcbTrainee)
        Me.RadPanel2.Controls.Add(Me.rcbTransfer)
        Me.RadPanel2.Controls.Add(Me.rcbQualified)
        Me.RadPanel2.Controls.Add(Me.txtManpower)
        Me.RadPanel2.Controls.Add(Me.ddTeam)
        Me.RadPanel2.Controls.Add(Me.cbManpower)
        Me.RadPanel2.Controls.Add(Me.lblEditID)
        Me.RadPanel2.Controls.Add(Me.btnMPCancel)
        Me.RadPanel2.Controls.Add(Me.btnMPSubmit)
        Me.RadPanel2.Controls.Add(Me.ddStatus)
        Me.RadPanel2.Controls.Add(Me.RadLabel3)
        Me.RadPanel2.Controls.Add(Me.RadLabel2)
        Me.RadPanel2.Controls.Add(Me.ddProc)
        Me.RadPanel2.Controls.Add(Me.RadLabel1)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(1087, 175)
        Me.RadPanel2.TabIndex = 0
        Me.RadPanel2.ThemeName = "CrystalDark"
        '
        'rcbTrainee
        '
        Me.rcbTrainee.ForeColor = System.Drawing.Color.White
        Me.rcbTrainee.Location = New System.Drawing.Point(258, 93)
        Me.rcbTrainee.Name = "rcbTrainee"
        Me.rcbTrainee.Size = New System.Drawing.Size(60, 18)
        Me.rcbTrainee.TabIndex = 23
        Me.rcbTrainee.Text = "Trainee"
        '
        'rcbTransfer
        '
        Me.rcbTransfer.ForeColor = System.Drawing.Color.White
        Me.rcbTransfer.Location = New System.Drawing.Point(184, 93)
        Me.rcbTransfer.Name = "rcbTransfer"
        Me.rcbTransfer.Size = New System.Drawing.Size(63, 18)
        Me.rcbTransfer.TabIndex = 23
        Me.rcbTransfer.Text = "Transfer"
        '
        'rcbQualified
        '
        Me.rcbQualified.ForeColor = System.Drawing.Color.White
        Me.rcbQualified.Location = New System.Drawing.Point(110, 93)
        Me.rcbQualified.Name = "rcbQualified"
        Me.rcbQualified.Size = New System.Drawing.Size(68, 18)
        Me.rcbQualified.TabIndex = 22
        Me.rcbQualified.Text = "Qualified"
        '
        'txtManpower
        '
        Me.txtManpower.Location = New System.Drawing.Point(365, 55)
        Me.txtManpower.Name = "txtManpower"
        Me.txtManpower.Size = New System.Drawing.Size(215, 24)
        Me.txtManpower.TabIndex = 21
        '
        'ddTeam
        '
        Me.ddTeam.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddTeam.Location = New System.Drawing.Point(365, 133)
        Me.ddTeam.Name = "ddTeam"
        Me.ddTeam.Size = New System.Drawing.Size(60, 24)
        Me.ddTeam.TabIndex = 20
        Me.ddTeam.Text = "RadDropDownList1"
        '
        'cbManpower
        '
        '
        'cbManpower.NestedRadGridView
        '
        Me.cbManpower.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cbManpower.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbManpower.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbManpower.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.cbManpower.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cbManpower.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cbManpower.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cbManpower.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cbManpower.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cbManpower.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.cbManpower.EditorControl.Name = "NestedRadGridView"
        Me.cbManpower.EditorControl.ReadOnly = True
        Me.cbManpower.EditorControl.ShowGroupPanel = False
        Me.cbManpower.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cbManpower.EditorControl.TabIndex = 0
        Me.cbManpower.Location = New System.Drawing.Point(106, 55)
        Me.cbManpower.Name = "cbManpower"
        Me.cbManpower.Size = New System.Drawing.Size(253, 24)
        Me.cbManpower.TabIndex = 19
        Me.cbManpower.TabStop = False
        Me.cbManpower.Text = "RadMultiColumnComboBox1"
        '
        'lblEditID
        '
        Me.lblEditID.Location = New System.Drawing.Point(785, 20)
        Me.lblEditID.Name = "lblEditID"
        Me.lblEditID.Size = New System.Drawing.Size(50, 20)
        Me.lblEditID.TabIndex = 15
        Me.lblEditID.Text = "Status:"
        Me.lblEditID.ThemeName = "CrystalDark"
        Me.lblEditID.Visible = False
        '
        'btnMPCancel
        '
        Me.btnMPCancel.Location = New System.Drawing.Point(222, 133)
        Me.btnMPCancel.Name = "btnMPCancel"
        Me.btnMPCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnMPCancel.TabIndex = 14
        Me.btnMPCancel.Text = "Cancel"
        Me.btnMPCancel.Visible = False
        '
        'btnMPSubmit
        '
        Me.btnMPSubmit.Location = New System.Drawing.Point(54, 133)
        Me.btnMPSubmit.Name = "btnMPSubmit"
        Me.btnMPSubmit.Size = New System.Drawing.Size(162, 24)
        Me.btnMPSubmit.TabIndex = 13
        Me.btnMPSubmit.Text = "SAVE WITH TEAM MEMBERS"
        '
        'ddStatus
        '
        Me.ddStatus.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Qualified"
        RadListDataItem2.Text = "Transferred"
        RadListDataItem3.Text = "Trainee"
        Me.ddStatus.Items.Add(RadListDataItem1)
        Me.ddStatus.Items.Add(RadListDataItem2)
        Me.ddStatus.Items.Add(RadListDataItem3)
        Me.ddStatus.Location = New System.Drawing.Point(365, 89)
        Me.ddStatus.Name = "ddStatus"
        Me.ddStatus.Size = New System.Drawing.Size(215, 24)
        Me.ddStatus.TabIndex = 12
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(54, 93)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(50, 20)
        Me.RadLabel3.TabIndex = 11
        Me.RadLabel3.Text = "Status:"
        Me.RadLabel3.ThemeName = "CrystalDark"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(37, 59)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(70, 20)
        Me.RadLabel2.TabIndex = 9
        Me.RadLabel2.Text = "Employee:"
        Me.RadLabel2.ThemeName = "CrystalDark"
        '
        'ddProc
        '
        Me.ddProc.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddProc.Location = New System.Drawing.Point(106, 16)
        Me.ddProc.Name = "ddProc"
        Me.ddProc.Size = New System.Drawing.Size(253, 24)
        Me.ddProc.TabIndex = 8
        Me.ddProc.Text = "RadDropDownList1"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(10, 16)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(100, 20)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "Process Name:"
        Me.RadLabel1.ThemeName = "CrystalDark"
        '
        'Hourly
        '
        Me.Hourly.Controls.Add(Me.RadPanel3)
        Me.Hourly.Image = CType(resources.GetObject("Hourly.Image"), System.Drawing.Image)
        Me.Hourly.ItemSize = New System.Drawing.SizeF(176.0!, 40.0!)
        Me.Hourly.Location = New System.Drawing.Point(281, 37)
        Me.Hourly.Name = "Hourly"
        Me.Hourly.Size = New System.Drawing.Size(1087, 653)
        Me.Hourly.Text = "Hourly Quality"
        '
        'RadPanel3
        '
        Me.RadPanel3.Controls.Add(Me.rgvHourly)
        Me.RadPanel3.Controls.Add(Me.RadPanel4)
        Me.RadPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel3.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(1087, 653)
        Me.RadPanel3.TabIndex = 1
        Me.RadPanel3.ThemeName = "CrystalDark"
        '
        'rgvHourly
        '
        Me.rgvHourly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvHourly.Location = New System.Drawing.Point(0, 310)
        '
        '
        '
        Me.rgvHourly.MasterTemplate.AllowAddNewRow = False
        Me.rgvHourly.MasterTemplate.AllowCellContextMenu = False
        Me.rgvHourly.MasterTemplate.AllowColumnChooser = False
        Me.rgvHourly.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvHourly.MasterTemplate.AllowColumnReorder = False
        Me.rgvHourly.MasterTemplate.AllowDeleteRow = False
        Me.rgvHourly.MasterTemplate.AllowDragToGroup = False
        Me.rgvHourly.MasterTemplate.AllowEditRow = False
        Me.rgvHourly.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.rgvHourly.MasterTemplate.AllowRowResize = False
        Me.rgvHourly.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.rgvHourly.Name = "rgvHourly"
        Me.rgvHourly.Size = New System.Drawing.Size(1087, 343)
        Me.rgvHourly.TabIndex = 2
        Me.rgvHourly.ThemeName = "CrystalDark"
        '
        'RadPanel4
        '
        Me.RadPanel4.Controls.Add(Me.RadScrollablePanel2)
        Me.RadPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel4.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(1087, 310)
        Me.RadPanel4.TabIndex = 0
        Me.RadPanel4.ThemeName = "CrystalDark"
        '
        'RadScrollablePanel2
        '
        Me.RadScrollablePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RadScrollablePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScrollablePanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadScrollablePanel2.Name = "RadScrollablePanel2"
        '
        'RadScrollablePanel2.PanelContainer
        '
        Me.RadScrollablePanel2.PanelContainer.Controls.Add(Me.lblHQEdit)
        Me.RadScrollablePanel2.PanelContainer.Controls.Add(Me.btnHQCancel)
        Me.RadScrollablePanel2.PanelContainer.Controls.Add(Me.btnHQSubmit)
        Me.RadScrollablePanel2.PanelContainer.Controls.Add(Me.RadGroupBox3)
        Me.RadScrollablePanel2.PanelContainer.Controls.Add(Me.RadGroupBox2)
        Me.RadScrollablePanel2.PanelContainer.Controls.Add(Me.RadGroupBox1)
        Me.RadScrollablePanel2.PanelContainer.Controls.Add(Me.ddHQTime)
        Me.RadScrollablePanel2.PanelContainer.Controls.Add(Me.RadLabel6)
        Me.RadScrollablePanel2.PanelContainer.Size = New System.Drawing.Size(1085, 308)
        Me.RadScrollablePanel2.Size = New System.Drawing.Size(1087, 310)
        Me.RadScrollablePanel2.TabIndex = 0
        '
        'lblHQEdit
        '
        Me.lblHQEdit.Location = New System.Drawing.Point(667, 9)
        Me.lblHQEdit.Name = "lblHQEdit"
        Me.lblHQEdit.Size = New System.Drawing.Size(86, 20)
        Me.lblHQEdit.TabIndex = 24
        Me.lblHQEdit.Text = "Barcode No.:"
        Me.lblHQEdit.ThemeName = "CrystalDark"
        Me.lblHQEdit.Visible = False
        '
        'btnHQCancel
        '
        Me.btnHQCancel.Location = New System.Drawing.Point(124, 275)
        Me.btnHQCancel.Name = "btnHQCancel"
        Me.btnHQCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnHQCancel.TabIndex = 23
        Me.btnHQCancel.Text = "Cancel"
        Me.btnHQCancel.Visible = False
        '
        'btnHQSubmit
        '
        Me.btnHQSubmit.Location = New System.Drawing.Point(8, 275)
        Me.btnHQSubmit.Name = "btnHQSubmit"
        Me.btnHQSubmit.Size = New System.Drawing.Size(110, 24)
        Me.btnHQSubmit.TabIndex = 22
        Me.btnHQSubmit.Text = "SAVE"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.RadGroupBox4)
        Me.RadGroupBox3.Controls.Add(Me.spnHQDeviation)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel12)
        Me.RadGroupBox3.Controls.Add(Me.spnHQActual)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel11)
        Me.RadGroupBox3.Controls.Add(Me.spnHQPlan)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel10)
        Me.RadGroupBox3.Controls.Add(Me.tbHQBarcode)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel9)
        Me.RadGroupBox3.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox3.HeaderText = "Production Status Monitoring"
        Me.RadGroupBox3.Location = New System.Drawing.Point(304, 37)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(457, 232)
        Me.RadGroupBox3.TabIndex = 21
        Me.RadGroupBox3.Text = "Production Status Monitoring"
        Me.RadGroupBox3.ThemeName = "CrystalDark"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Controls.Add(Me.spnHQFinal)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel16)
        Me.RadGroupBox4.Controls.Add(Me.spnHQFunction)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel15)
        Me.RadGroupBox4.Controls.Add(Me.spnHQElectrical)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel14)
        Me.RadGroupBox4.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox4.HeaderText = """NG"" Product Counter"
        Me.RadGroupBox4.Location = New System.Drawing.Point(268, 49)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(181, 151)
        Me.RadGroupBox4.TabIndex = 23
        Me.RadGroupBox4.Text = """NG"" Product Counter"
        Me.RadGroupBox4.ThemeName = "CrystalDark"
        '
        'spnHQFinal
        '
        Me.spnHQFinal.Location = New System.Drawing.Point(73, 113)
        Me.spnHQFinal.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnHQFinal.Name = "spnHQFinal"
        Me.spnHQFinal.Size = New System.Drawing.Size(69, 24)
        Me.spnHQFinal.TabIndex = 17
        '
        'RadLabel16
        '
        Me.RadLabel16.Location = New System.Drawing.Point(33, 113)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(40, 20)
        Me.RadLabel16.TabIndex = 18
        Me.RadLabel16.Text = "Final:"
        Me.RadLabel16.ThemeName = "CrystalDark"
        '
        'spnHQFunction
        '
        Me.spnHQFunction.Location = New System.Drawing.Point(73, 77)
        Me.spnHQFunction.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnHQFunction.Name = "spnHQFunction"
        Me.spnHQFunction.Size = New System.Drawing.Size(69, 24)
        Me.spnHQFunction.TabIndex = 15
        '
        'RadLabel15
        '
        Me.RadLabel15.Location = New System.Drawing.Point(12, 77)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(63, 20)
        Me.RadLabel15.TabIndex = 16
        Me.RadLabel15.Text = "Function:"
        Me.RadLabel15.ThemeName = "CrystalDark"
        '
        'spnHQElectrical
        '
        Me.spnHQElectrical.Location = New System.Drawing.Point(73, 40)
        Me.spnHQElectrical.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnHQElectrical.Name = "spnHQElectrical"
        Me.spnHQElectrical.Size = New System.Drawing.Size(69, 24)
        Me.spnHQElectrical.TabIndex = 13
        '
        'RadLabel14
        '
        Me.RadLabel14.Location = New System.Drawing.Point(10, 40)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(66, 20)
        Me.RadLabel14.TabIndex = 14
        Me.RadLabel14.Text = "Electrical:"
        Me.RadLabel14.ThemeName = "CrystalDark"
        '
        'spnHQDeviation
        '
        Me.spnHQDeviation.Location = New System.Drawing.Point(85, 164)
        Me.spnHQDeviation.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.spnHQDeviation.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.spnHQDeviation.Name = "spnHQDeviation"
        Me.spnHQDeviation.Size = New System.Drawing.Size(158, 24)
        Me.spnHQDeviation.TabIndex = 19
        '
        'RadLabel12
        '
        Me.RadLabel12.Location = New System.Drawing.Point(20, 164)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(67, 20)
        Me.RadLabel12.TabIndex = 20
        Me.RadLabel12.Text = "Deviation:"
        Me.RadLabel12.ThemeName = "CrystalDark"
        '
        'spnHQActual
        '
        Me.spnHQActual.Location = New System.Drawing.Point(85, 126)
        Me.spnHQActual.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnHQActual.Name = "spnHQActual"
        Me.spnHQActual.Size = New System.Drawing.Size(158, 24)
        Me.spnHQActual.TabIndex = 17
        '
        'RadLabel11
        '
        Me.RadLabel11.Location = New System.Drawing.Point(37, 126)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(49, 20)
        Me.RadLabel11.TabIndex = 18
        Me.RadLabel11.Text = "Actual:"
        Me.RadLabel11.ThemeName = "CrystalDark"
        '
        'spnHQPlan
        '
        Me.spnHQPlan.Location = New System.Drawing.Point(85, 89)
        Me.spnHQPlan.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnHQPlan.Name = "spnHQPlan"
        Me.spnHQPlan.Size = New System.Drawing.Size(158, 24)
        Me.spnHQPlan.TabIndex = 15
        '
        'RadLabel10
        '
        Me.RadLabel10.Location = New System.Drawing.Point(49, 89)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(37, 20)
        Me.RadLabel10.TabIndex = 16
        Me.RadLabel10.Text = "Plan:"
        Me.RadLabel10.ThemeName = "CrystalDark"
        '
        'tbHQBarcode
        '
        Me.tbHQBarcode.Location = New System.Drawing.Point(85, 49)
        Me.tbHQBarcode.Name = "tbHQBarcode"
        Me.tbHQBarcode.Size = New System.Drawing.Size(158, 24)
        Me.tbHQBarcode.TabIndex = 14
        '
        'RadLabel9
        '
        Me.RadLabel9.Location = New System.Drawing.Point(5, 52)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(86, 20)
        Me.RadLabel9.TabIndex = 13
        Me.RadLabel9.Text = "Barcode No.:"
        Me.RadLabel9.ThemeName = "CrystalDark"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.spnHQSleeve)
        Me.RadGroupBox2.Controls.Add(Me.spnHQSubstator)
        Me.RadGroupBox2.Controls.Add(Me.spnHQStator)
        Me.RadGroupBox2.Controls.Add(Me.spnHQRotator)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel8)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel7)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox2.HeaderText = "Parts Change Monitoring"
        Me.RadGroupBox2.Location = New System.Drawing.Point(7, 156)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(291, 113)
        Me.RadGroupBox2.TabIndex = 20
        Me.RadGroupBox2.Text = "Parts Change Monitoring"
        Me.RadGroupBox2.ThemeName = "CrystalDark"
        '
        'spnHQSleeve
        '
        Me.spnHQSleeve.Location = New System.Drawing.Point(217, 68)
        Me.spnHQSleeve.Name = "spnHQSleeve"
        Me.spnHQSleeve.Size = New System.Drawing.Size(69, 24)
        Me.spnHQSleeve.TabIndex = 27
        '
        'spnHQSubstator
        '
        Me.spnHQSubstator.Location = New System.Drawing.Point(217, 34)
        Me.spnHQSubstator.Name = "spnHQSubstator"
        Me.spnHQSubstator.Size = New System.Drawing.Size(69, 24)
        Me.spnHQSubstator.TabIndex = 26
        '
        'spnHQStator
        '
        Me.spnHQStator.Location = New System.Drawing.Point(65, 69)
        Me.spnHQStator.Name = "spnHQStator"
        Me.spnHQStator.Size = New System.Drawing.Size(69, 24)
        Me.spnHQStator.TabIndex = 25
        '
        'spnHQRotator
        '
        Me.spnHQRotator.Location = New System.Drawing.Point(65, 34)
        Me.spnHQRotator.Name = "spnHQRotator"
        Me.spnHQRotator.Size = New System.Drawing.Size(69, 24)
        Me.spnHQRotator.TabIndex = 24
        '
        'RadLabel8
        '
        Me.RadLabel8.Location = New System.Drawing.Point(162, 67)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(50, 20)
        Me.RadLabel8.TabIndex = 18
        Me.RadLabel8.Text = "Sleeve:"
        Me.RadLabel8.ThemeName = "CrystalDark"
        '
        'RadLabel7
        '
        Me.RadLabel7.Location = New System.Drawing.Point(140, 34)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(74, 20)
        Me.RadLabel7.TabIndex = 16
        Me.RadLabel7.Text = "Sub Stator:"
        Me.RadLabel7.ThemeName = "CrystalDark"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(12, 69)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(47, 20)
        Me.RadLabel5.TabIndex = 14
        Me.RadLabel5.Text = "Stator:"
        Me.RadLabel5.ThemeName = "CrystalDark"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(5, 34)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(55, 20)
        Me.RadLabel4.TabIndex = 12
        Me.RadLabel4.Text = "Rotator:"
        Me.RadLabel4.ThemeName = "CrystalDark"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.cbHQ3)
        Me.RadGroupBox1.Controls.Add(Me.cbHQ2)
        Me.RadGroupBox1.Controls.Add(Me.cbHQ1)
        Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox1.HeaderText = "Quality Monitoring"
        Me.RadGroupBox1.Location = New System.Drawing.Point(7, 37)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(291, 113)
        Me.RadGroupBox1.TabIndex = 19
        Me.RadGroupBox1.Text = "Quality Monitoring"
        Me.RadGroupBox1.ThemeName = "CrystalDark"
        '
        'cbHQ3
        '
        Me.cbHQ3.Location = New System.Drawing.Point(5, 86)
        Me.cbHQ3.Name = "cbHQ3"
        Me.cbHQ3.Size = New System.Drawing.Size(146, 18)
        Me.cbHQ3.TabIndex = 12
        Me.cbHQ3.Text = "Final Product Check"
        Me.cbHQ3.ThemeName = "CrystalDark"
        '
        'cbHQ2
        '
        Me.cbHQ2.Location = New System.Drawing.Point(5, 62)
        Me.cbHQ2.Name = "cbHQ2"
        Me.cbHQ2.Size = New System.Drawing.Size(119, 18)
        Me.cbHQ2.TabIndex = 11
        Me.cbHQ2.Text = "Stator Greasing"
        Me.cbHQ2.ThemeName = "CrystalDark"
        '
        'cbHQ1
        '
        Me.cbHQ1.Location = New System.Drawing.Point(5, 38)
        Me.cbHQ1.Name = "cbHQ1"
        Me.cbHQ1.Size = New System.Drawing.Size(117, 18)
        Me.cbHQ1.TabIndex = 10
        Me.cbHQ1.Text = "Cable Greasing"
        Me.cbHQ1.ThemeName = "CrystalDark"
        '
        'ddHQTime
        '
        Me.ddHQTime.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddHQTime.Location = New System.Drawing.Point(51, 9)
        Me.ddHQTime.Name = "ddHQTime"
        Me.ddHQTime.Size = New System.Drawing.Size(134, 24)
        Me.ddHQTime.TabIndex = 18
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(7, 9)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(41, 20)
        Me.RadLabel6.TabIndex = 17
        Me.RadLabel6.Text = "Time:"
        Me.RadLabel6.ThemeName = "CrystalDark"
        '
        'Assylinef
        '
        Me.Assylinef.Controls.Add(Me.RadPanel5)
        Me.Assylinef.Image = CType(resources.GetObject("Assylinef.Image"), System.Drawing.Image)
        Me.Assylinef.ItemSize = New System.Drawing.SizeF(176.0!, 40.0!)
        Me.Assylinef.Location = New System.Drawing.Point(281, 37)
        Me.Assylinef.Name = "Assylinef"
        Me.Assylinef.Size = New System.Drawing.Size(1087, 655)
        Me.Assylinef.Text = "Assembly Line Efficiency"
        '
        'RadPanel5
        '
        Me.RadPanel5.Controls.Add(Me.rgvAssyLineEff)
        Me.RadPanel5.Controls.Add(Me.RadPanel6)
        Me.RadPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel5.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(1087, 655)
        Me.RadPanel5.TabIndex = 1
        Me.RadPanel5.ThemeName = "CrystalDark"
        '
        'rgvAssyLineEff
        '
        Me.rgvAssyLineEff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvAssyLineEff.Location = New System.Drawing.Point(0, 295)
        '
        '
        '
        Me.rgvAssyLineEff.MasterTemplate.AllowAddNewRow = False
        Me.rgvAssyLineEff.MasterTemplate.AllowCellContextMenu = False
        Me.rgvAssyLineEff.MasterTemplate.AllowColumnChooser = False
        Me.rgvAssyLineEff.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvAssyLineEff.MasterTemplate.AllowColumnReorder = False
        Me.rgvAssyLineEff.MasterTemplate.AllowDragToGroup = False
        Me.rgvAssyLineEff.MasterTemplate.AllowEditRow = False
        Me.rgvAssyLineEff.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.rgvAssyLineEff.MasterTemplate.AllowRowResize = False
        Me.rgvAssyLineEff.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.rgvAssyLineEff.Name = "rgvAssyLineEff"
        Me.rgvAssyLineEff.Size = New System.Drawing.Size(1087, 360)
        Me.rgvAssyLineEff.TabIndex = 3
        Me.rgvAssyLineEff.ThemeName = "CrystalDark"
        '
        'RadPanel6
        '
        Me.RadPanel6.Controls.Add(Me.RadScrollablePanel3)
        Me.RadPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel6.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(1087, 295)
        Me.RadPanel6.TabIndex = 0
        Me.RadPanel6.ThemeName = "CrystalDark"
        '
        'RadScrollablePanel3
        '
        Me.RadScrollablePanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RadScrollablePanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScrollablePanel3.Location = New System.Drawing.Point(0, 0)
        Me.RadScrollablePanel3.Name = "RadScrollablePanel3"
        '
        'RadScrollablePanel3.PanelContainer
        '
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.lblOptimeText)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.btnAssyCancel)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.lblTotalQty)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.RadLabel52)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.tbCycle)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.RadLabel51)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.tbUnplanned)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.RadLabel50)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.tbPlanned)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.RadLabel49)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.tbALEOpTime)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.RadLabel13)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.btnALESubmit)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.RadGroupBox5)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.btnEdit)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.tbALETime)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.RadLabel18)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.spnALEHotto)
        Me.RadScrollablePanel3.PanelContainer.Controls.Add(Me.RadLabel17)
        Me.RadScrollablePanel3.PanelContainer.Size = New System.Drawing.Size(1085, 293)
        Me.RadScrollablePanel3.Size = New System.Drawing.Size(1087, 295)
        Me.RadScrollablePanel3.TabIndex = 0
        '
        'lblOptimeText
        '
        Me.lblOptimeText.Controls.Add(Me.lblTotalOperationTime)
        Me.lblOptimeText.Location = New System.Drawing.Point(435, 251)
        Me.lblOptimeText.Name = "lblOptimeText"
        Me.lblOptimeText.Size = New System.Drawing.Size(143, 20)
        Me.lblOptimeText.TabIndex = 55
        Me.lblOptimeText.Text = "Total Operation Time.:"
        Me.lblOptimeText.ThemeName = "CrystalDark"
        '
        'lblTotalOperationTime
        '
        Me.lblTotalOperationTime.Location = New System.Drawing.Point(131, 0)
        Me.lblTotalOperationTime.Name = "lblTotalOperationTime"
        Me.lblTotalOperationTime.Size = New System.Drawing.Size(15, 20)
        Me.lblTotalOperationTime.TabIndex = 56
        Me.lblTotalOperationTime.Text = "0"
        Me.lblTotalOperationTime.ThemeName = "CrystalDark"
        '
        'btnAssyCancel
        '
        Me.btnAssyCancel.Location = New System.Drawing.Point(125, 258)
        Me.btnAssyCancel.Name = "btnAssyCancel"
        Me.btnAssyCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnAssyCancel.TabIndex = 54
        Me.btnAssyCancel.Text = "CANCEL"
        '
        'lblTotalQty
        '
        Me.lblTotalQty.Location = New System.Drawing.Point(566, 268)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(15, 20)
        Me.lblTotalQty.TabIndex = 53
        Me.lblTotalQty.Text = "0"
        Me.lblTotalQty.ThemeName = "CrystalDark"
        '
        'RadLabel52
        '
        Me.RadLabel52.Location = New System.Drawing.Point(476, 268)
        Me.RadLabel52.Name = "RadLabel52"
        Me.RadLabel52.Size = New System.Drawing.Size(102, 20)
        Me.RadLabel52.TabIndex = 51
        Me.RadLabel52.Text = "Total GoodQty.:"
        Me.RadLabel52.ThemeName = "CrystalDark"
        '
        'tbCycle
        '
        Me.tbCycle.Enabled = False
        Me.tbCycle.Location = New System.Drawing.Point(666, 11)
        Me.tbCycle.Name = "tbCycle"
        Me.tbCycle.Size = New System.Drawing.Size(103, 24)
        Me.tbCycle.TabIndex = 50
        '
        'RadLabel51
        '
        Me.RadLabel51.Location = New System.Drawing.Point(591, 13)
        Me.RadLabel51.Name = "RadLabel51"
        Me.RadLabel51.Size = New System.Drawing.Size(78, 20)
        Me.RadLabel51.TabIndex = 49
        Me.RadLabel51.Text = "Cycle Time:"
        Me.RadLabel51.ThemeName = "CrystalDark"
        '
        'tbUnplanned
        '
        Me.tbUnplanned.Enabled = False
        Me.tbUnplanned.Location = New System.Drawing.Point(666, 44)
        Me.tbUnplanned.Name = "tbUnplanned"
        Me.tbUnplanned.Size = New System.Drawing.Size(103, 24)
        Me.tbUnplanned.TabIndex = 48
        '
        'RadLabel50
        '
        Me.RadLabel50.Location = New System.Drawing.Point(535, 46)
        Me.RadLabel50.Name = "RadLabel50"
        Me.RadLabel50.Size = New System.Drawing.Size(141, 20)
        Me.RadLabel50.TabIndex = 47
        Me.RadLabel50.Text = "Unplanned Downtime:"
        Me.RadLabel50.ThemeName = "CrystalDark"
        '
        'tbPlanned
        '
        Me.tbPlanned.Enabled = False
        Me.tbPlanned.Location = New System.Drawing.Point(398, 44)
        Me.tbPlanned.Name = "tbPlanned"
        Me.tbPlanned.Size = New System.Drawing.Size(103, 24)
        Me.tbPlanned.TabIndex = 46
        '
        'RadLabel49
        '
        Me.RadLabel49.Location = New System.Drawing.Point(281, 46)
        Me.RadLabel49.Name = "RadLabel49"
        Me.RadLabel49.Size = New System.Drawing.Size(125, 20)
        Me.RadLabel49.TabIndex = 45
        Me.RadLabel49.Text = "Planned Downtime:"
        Me.RadLabel49.ThemeName = "CrystalDark"
        '
        'tbALEOpTime
        '
        Me.tbALEOpTime.Enabled = False
        Me.tbALEOpTime.Location = New System.Drawing.Point(398, 11)
        Me.tbALEOpTime.Name = "tbALEOpTime"
        Me.tbALEOpTime.Size = New System.Drawing.Size(103, 24)
        Me.tbALEOpTime.TabIndex = 44
        '
        'RadLabel13
        '
        Me.RadLabel13.Location = New System.Drawing.Point(301, 14)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(104, 20)
        Me.RadLabel13.TabIndex = 43
        Me.RadLabel13.Text = "Operation Time:"
        Me.RadLabel13.ThemeName = "CrystalDark"
        '
        'btnALESubmit
        '
        Me.btnALESubmit.Location = New System.Drawing.Point(9, 258)
        Me.btnALESubmit.Name = "btnALESubmit"
        Me.btnALESubmit.Size = New System.Drawing.Size(110, 24)
        Me.btnALESubmit.TabIndex = 42
        Me.btnALESubmit.Text = "SAVE"
        '
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Controls.Add(Me.btnCancel)
        Me.RadGroupBox5.Controls.Add(Me.cbModelName)
        Me.RadGroupBox5.Controls.Add(Me.cbDelivered)
        Me.RadGroupBox5.Controls.Add(Me.btnALEAdd)
        Me.RadGroupBox5.Controls.Add(Me.spnALESample)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel27)
        Me.RadGroupBox5.Controls.Add(Me.spnALEScrap)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel26)
        Me.RadGroupBox5.Controls.Add(Me.spnALEReplace)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel25)
        Me.RadGroupBox5.Controls.Add(Me.spnALEGoodQty)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel24)
        Me.RadGroupBox5.Controls.Add(Me.tbALELotNo)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel23)
        Me.RadGroupBox5.Controls.Add(Me.tbALEModelCode)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel22)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel21)
        Me.RadGroupBox5.Controls.Add(Me.tbALEFGNo)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel20)
        Me.RadGroupBox5.Controls.Add(Me.tbALECustomer)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel19)
        Me.RadGroupBox5.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox5.HeaderText = ""
        Me.RadGroupBox5.Location = New System.Drawing.Point(9, 72)
        Me.RadGroupBox5.Name = "RadGroupBox5"
        Me.RadGroupBox5.Size = New System.Drawing.Size(562, 177)
        Me.RadGroupBox5.TabIndex = 41
        Me.RadGroupBox5.ThemeName = "CrystalDark"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(469, 142)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 24)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Text = "CANCEL"
        '
        'cbModelName
        '
        Me.cbModelName.Location = New System.Drawing.Point(86, 81)
        Me.cbModelName.Name = "cbModelName"
        Me.cbModelName.Size = New System.Drawing.Size(158, 24)
        Me.cbModelName.TabIndex = 35
        '
        'cbDelivered
        '
        Me.cbDelivered.AutoSize = True
        Me.cbDelivered.Checked = True
        Me.cbDelivered.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDelivered.Location = New System.Drawing.Point(474, 24)
        Me.cbDelivered.Name = "cbDelivered"
        Me.cbDelivered.Size = New System.Drawing.Size(75, 19)
        Me.cbDelivered.TabIndex = 34
        Me.cbDelivered.Text = "Delivered"
        Me.cbDelivered.UseVisualStyleBackColor = True
        '
        'btnALEAdd
        '
        Me.btnALEAdd.Location = New System.Drawing.Point(365, 142)
        Me.btnALEAdd.Name = "btnALEAdd"
        Me.btnALEAdd.Size = New System.Drawing.Size(103, 24)
        Me.btnALEAdd.TabIndex = 33
        Me.btnALEAdd.Text = "ADD"
        '
        'spnALESample
        '
        Me.spnALESample.Location = New System.Drawing.Point(365, 111)
        Me.spnALESample.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnALESample.Name = "spnALESample"
        Me.spnALESample.Size = New System.Drawing.Size(103, 24)
        Me.spnALESample.TabIndex = 31
        '
        'RadLabel27
        '
        Me.RadLabel27.Location = New System.Drawing.Point(313, 113)
        Me.RadLabel27.Name = "RadLabel27"
        Me.RadLabel27.Size = New System.Drawing.Size(56, 20)
        Me.RadLabel27.TabIndex = 32
        Me.RadLabel27.Text = "Sample:"
        Me.RadLabel27.ThemeName = "CrystalDark"
        '
        'spnALEScrap
        '
        Me.spnALEScrap.Location = New System.Drawing.Point(365, 81)
        Me.spnALEScrap.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnALEScrap.Name = "spnALEScrap"
        Me.spnALEScrap.Size = New System.Drawing.Size(103, 24)
        Me.spnALEScrap.TabIndex = 29
        '
        'RadLabel26
        '
        Me.RadLabel26.Location = New System.Drawing.Point(264, 83)
        Me.RadLabel26.Name = "RadLabel26"
        Me.RadLabel26.Size = New System.Drawing.Size(109, 20)
        Me.RadLabel26.TabIndex = 30
        Me.RadLabel26.Text = "Assembly Scrap:"
        Me.RadLabel26.ThemeName = "CrystalDark"
        '
        'spnALEReplace
        '
        Me.spnALEReplace.Location = New System.Drawing.Point(365, 51)
        Me.spnALEReplace.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnALEReplace.Name = "spnALEReplace"
        Me.spnALEReplace.Size = New System.Drawing.Size(103, 24)
        Me.spnALEReplace.TabIndex = 27
        '
        'RadLabel25
        '
        Me.RadLabel25.Location = New System.Drawing.Point(281, 53)
        Me.RadLabel25.Name = "RadLabel25"
        Me.RadLabel25.Size = New System.Drawing.Size(90, 20)
        Me.RadLabel25.TabIndex = 28
        Me.RadLabel25.Text = "Replacement:"
        Me.RadLabel25.ThemeName = "CrystalDark"
        '
        'spnALEGoodQty
        '
        Me.spnALEGoodQty.Location = New System.Drawing.Point(365, 21)
        Me.spnALEGoodQty.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnALEGoodQty.Name = "spnALEGoodQty"
        Me.spnALEGoodQty.Size = New System.Drawing.Size(103, 24)
        Me.spnALEGoodQty.TabIndex = 25
        '
        'RadLabel24
        '
        Me.RadLabel24.Location = New System.Drawing.Point(301, 23)
        Me.RadLabel24.Name = "RadLabel24"
        Me.RadLabel24.Size = New System.Drawing.Size(70, 20)
        Me.RadLabel24.TabIndex = 26
        Me.RadLabel24.Text = "Good Qty.:"
        Me.RadLabel24.ThemeName = "CrystalDark"
        '
        'tbALELotNo
        '
        Me.tbALELotNo.Location = New System.Drawing.Point(86, 141)
        Me.tbALELotNo.Name = "tbALELotNo"
        Me.tbALELotNo.Size = New System.Drawing.Size(158, 24)
        Me.tbALELotNo.TabIndex = 24
        '
        'RadLabel23
        '
        Me.RadLabel23.Location = New System.Drawing.Point(34, 144)
        Me.RadLabel23.Name = "RadLabel23"
        Me.RadLabel23.Size = New System.Drawing.Size(55, 20)
        Me.RadLabel23.TabIndex = 23
        Me.RadLabel23.Text = "Lot No.:"
        Me.RadLabel23.ThemeName = "CrystalDark"
        '
        'tbALEModelCode
        '
        Me.tbALEModelCode.Location = New System.Drawing.Point(86, 111)
        Me.tbALEModelCode.Name = "tbALEModelCode"
        Me.tbALEModelCode.Size = New System.Drawing.Size(158, 24)
        Me.tbALEModelCode.TabIndex = 22
        '
        'RadLabel22
        '
        Me.RadLabel22.Location = New System.Drawing.Point(7, 114)
        Me.RadLabel22.Name = "RadLabel22"
        Me.RadLabel22.Size = New System.Drawing.Size(84, 20)
        Me.RadLabel22.TabIndex = 21
        Me.RadLabel22.Text = "Model Code:"
        Me.RadLabel22.ThemeName = "CrystalDark"
        '
        'RadLabel21
        '
        Me.RadLabel21.Location = New System.Drawing.Point(4, 84)
        Me.RadLabel21.Name = "RadLabel21"
        Me.RadLabel21.Size = New System.Drawing.Size(88, 20)
        Me.RadLabel21.TabIndex = 19
        Me.RadLabel21.Text = "Model Name:"
        Me.RadLabel21.ThemeName = "CrystalDark"
        '
        'tbALEFGNo
        '
        Me.tbALEFGNo.Location = New System.Drawing.Point(86, 51)
        Me.tbALEFGNo.Name = "tbALEFGNo"
        Me.tbALEFGNo.Size = New System.Drawing.Size(158, 24)
        Me.tbALEFGNo.TabIndex = 18
        '
        'RadLabel20
        '
        Me.RadLabel20.Location = New System.Drawing.Point(38, 54)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(52, 20)
        Me.RadLabel20.TabIndex = 17
        Me.RadLabel20.Text = "FG No.:"
        Me.RadLabel20.ThemeName = "CrystalDark"
        '
        'tbALECustomer
        '
        Me.tbALECustomer.Location = New System.Drawing.Point(86, 21)
        Me.tbALECustomer.Name = "tbALECustomer"
        Me.tbALECustomer.Size = New System.Drawing.Size(158, 24)
        Me.tbALECustomer.TabIndex = 16
        '
        'RadLabel19
        '
        Me.RadLabel19.Location = New System.Drawing.Point(19, 24)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(70, 20)
        Me.RadLabel19.TabIndex = 15
        Me.RadLabel19.Text = "Customer:"
        Me.RadLabel19.ThemeName = "CrystalDark"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(226, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(27, 24)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEdit.TabIndex = 40
        Me.btnEdit.TabStop = False
        '
        'tbALETime
        '
        Me.tbALETime.Enabled = False
        Me.tbALETime.Location = New System.Drawing.Point(123, 11)
        Me.tbALETime.Name = "tbALETime"
        Me.tbALETime.Size = New System.Drawing.Size(103, 24)
        Me.tbALETime.TabIndex = 39
        '
        'RadLabel18
        '
        Me.RadLabel18.Location = New System.Drawing.Point(9, 14)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(125, 20)
        Me.RadLabel18.TabIndex = 38
        Me.RadLabel18.Text = "Line Time Partition:"
        Me.RadLabel18.ThemeName = "CrystalDark"
        '
        'spnALEHotto
        '
        Me.spnALEHotto.Location = New System.Drawing.Point(123, 44)
        Me.spnALEHotto.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnALEHotto.Name = "spnALEHotto"
        Me.spnALEHotto.Size = New System.Drawing.Size(103, 24)
        Me.spnALEHotto.TabIndex = 36
        '
        'RadLabel17
        '
        Me.RadLabel17.Location = New System.Drawing.Point(22, 46)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(109, 20)
        Me.RadLabel17.TabIndex = 37
        Me.RadLabel17.Text = "5's, Hotto, Break:"
        Me.RadLabel17.ThemeName = "CrystalDark"
        '
        'SRCAssy
        '
        Me.SRCAssy.Controls.Add(Me.RadPanel7)
        Me.SRCAssy.Image = CType(resources.GetObject("SRCAssy.Image"), System.Drawing.Image)
        Me.SRCAssy.ItemSize = New System.Drawing.SizeF(176.0!, 40.0!)
        Me.SRCAssy.Location = New System.Drawing.Point(281, 37)
        Me.SRCAssy.Name = "SRCAssy"
        Me.SRCAssy.Size = New System.Drawing.Size(1087, 653)
        Me.SRCAssy.Text = "SRC Assembly"
        '
        'RadPanel7
        '
        Me.RadPanel7.Controls.Add(Me.rgvSRCAssy)
        Me.RadPanel7.Controls.Add(Me.RadPanel8)
        Me.RadPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel7.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(1087, 653)
        Me.RadPanel7.TabIndex = 1
        Me.RadPanel7.ThemeName = "CrystalDark"
        '
        'rgvSRCAssy
        '
        Me.rgvSRCAssy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvSRCAssy.Location = New System.Drawing.Point(0, 156)
        '
        '
        '
        Me.rgvSRCAssy.MasterTemplate.AllowAddNewRow = False
        Me.rgvSRCAssy.MasterTemplate.AllowCellContextMenu = False
        Me.rgvSRCAssy.MasterTemplate.AllowColumnChooser = False
        Me.rgvSRCAssy.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.rgvSRCAssy.MasterTemplate.AllowColumnReorder = False
        Me.rgvSRCAssy.MasterTemplate.AllowDeleteRow = False
        Me.rgvSRCAssy.MasterTemplate.AllowDragToGroup = False
        Me.rgvSRCAssy.MasterTemplate.AllowEditRow = False
        Me.rgvSRCAssy.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.rgvSRCAssy.MasterTemplate.AllowRowResize = False
        Me.rgvSRCAssy.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.rgvSRCAssy.Name = "rgvSRCAssy"
        Me.rgvSRCAssy.Size = New System.Drawing.Size(1087, 497)
        Me.rgvSRCAssy.TabIndex = 4
        Me.rgvSRCAssy.ThemeName = "CrystalDark"
        '
        'RadPanel8
        '
        Me.RadPanel8.Controls.Add(Me.btnSACancel)
        Me.RadPanel8.Controls.Add(Me.lblSRCAssyID)
        Me.RadPanel8.Controls.Add(Me.btnSASubmit)
        Me.RadPanel8.Controls.Add(Me.tbSAEng)
        Me.RadPanel8.Controls.Add(Me.RadLabel34)
        Me.RadPanel8.Controls.Add(Me.tbSAQASample)
        Me.RadPanel8.Controls.Add(Me.RadLabel33)
        Me.RadPanel8.Controls.Add(Me.tbSAPurge)
        Me.RadPanel8.Controls.Add(Me.RadLabel32)
        Me.RadPanel8.Controls.Add(Me.tbSAScrap)
        Me.RadPanel8.Controls.Add(Me.RadLabel31)
        Me.RadPanel8.Controls.Add(Me.tbSALotNo)
        Me.RadPanel8.Controls.Add(Me.RadLabel29)
        Me.RadPanel8.Controls.Add(Me.tbSAPartName)
        Me.RadPanel8.Controls.Add(Me.RadLabel28)
        Me.RadPanel8.Controls.Add(Me.ddSAPartNo)
        Me.RadPanel8.Controls.Add(Me.RadLabel30)
        Me.RadPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel8.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(1087, 156)
        Me.RadPanel8.TabIndex = 0
        Me.RadPanel8.ThemeName = "CrystalDark"
        '
        'btnSACancel
        '
        Me.btnSACancel.Location = New System.Drawing.Point(438, 118)
        Me.btnSACancel.Name = "btnSACancel"
        Me.btnSACancel.Size = New System.Drawing.Size(85, 24)
        Me.btnSACancel.TabIndex = 28
        Me.btnSACancel.Text = "Cancel"
        Me.btnSACancel.Visible = False
        '
        'lblSRCAssyID
        '
        Me.lblSRCAssyID.Location = New System.Drawing.Point(648, 17)
        Me.lblSRCAssyID.Name = "lblSRCAssyID"
        Me.lblSRCAssyID.Size = New System.Drawing.Size(74, 20)
        Me.lblSRCAssyID.TabIndex = 27
        Me.lblSRCAssyID.Text = "Purge Qty.:"
        Me.lblSRCAssyID.ThemeName = "CrystalDark"
        Me.lblSRCAssyID.Visible = False
        '
        'btnSASubmit
        '
        Me.btnSASubmit.Location = New System.Drawing.Point(359, 118)
        Me.btnSASubmit.Name = "btnSASubmit"
        Me.btnSASubmit.Size = New System.Drawing.Size(73, 24)
        Me.btnSASubmit.TabIndex = 26
        Me.btnSASubmit.Text = "SAVE"
        '
        'tbSAEng
        '
        Me.tbSAEng.Location = New System.Drawing.Point(359, 83)
        Me.tbSAEng.Name = "tbSAEng"
        Me.tbSAEng.Size = New System.Drawing.Size(164, 24)
        Me.tbSAEng.TabIndex = 25
        '
        'RadLabel34
        '
        Me.RadLabel34.Location = New System.Drawing.Point(278, 87)
        Me.RadLabel34.Name = "RadLabel34"
        Me.RadLabel34.Size = New System.Drawing.Size(86, 20)
        Me.RadLabel34.TabIndex = 24
        Me.RadLabel34.Text = "Eng. Sample:"
        Me.RadLabel34.ThemeName = "CrystalDark"
        '
        'tbSAQASample
        '
        Me.tbSAQASample.Location = New System.Drawing.Point(359, 48)
        Me.tbSAQASample.Name = "tbSAQASample"
        Me.tbSAQASample.Size = New System.Drawing.Size(164, 24)
        Me.tbSAQASample.TabIndex = 23
        '
        'RadLabel33
        '
        Me.RadLabel33.Location = New System.Drawing.Point(285, 52)
        Me.RadLabel33.Name = "RadLabel33"
        Me.RadLabel33.Size = New System.Drawing.Size(78, 20)
        Me.RadLabel33.TabIndex = 22
        Me.RadLabel33.Text = "QA Sample:"
        Me.RadLabel33.ThemeName = "CrystalDark"
        '
        'tbSAPurge
        '
        Me.tbSAPurge.Location = New System.Drawing.Point(359, 13)
        Me.tbSAPurge.Name = "tbSAPurge"
        Me.tbSAPurge.Size = New System.Drawing.Size(164, 24)
        Me.tbSAPurge.TabIndex = 21
        '
        'RadLabel32
        '
        Me.RadLabel32.Location = New System.Drawing.Point(290, 17)
        Me.RadLabel32.Name = "RadLabel32"
        Me.RadLabel32.Size = New System.Drawing.Size(74, 20)
        Me.RadLabel32.TabIndex = 20
        Me.RadLabel32.Text = "Purge Qty.:"
        Me.RadLabel32.ThemeName = "CrystalDark"
        '
        'tbSAScrap
        '
        Me.tbSAScrap.Location = New System.Drawing.Point(72, 118)
        Me.tbSAScrap.Name = "tbSAScrap"
        Me.tbSAScrap.Size = New System.Drawing.Size(164, 24)
        Me.tbSAScrap.TabIndex = 19
        '
        'RadLabel31
        '
        Me.RadLabel31.Location = New System.Drawing.Point(3, 122)
        Me.RadLabel31.Name = "RadLabel31"
        Me.RadLabel31.Size = New System.Drawing.Size(73, 20)
        Me.RadLabel31.TabIndex = 18
        Me.RadLabel31.Text = "Scarp Qty.:"
        Me.RadLabel31.ThemeName = "CrystalDark"
        '
        'tbSALotNo
        '
        Me.tbSALotNo.Location = New System.Drawing.Point(72, 83)
        Me.tbSALotNo.Name = "tbSALotNo"
        Me.tbSALotNo.Size = New System.Drawing.Size(164, 24)
        Me.tbSALotNo.TabIndex = 17
        '
        'RadLabel29
        '
        Me.RadLabel29.Location = New System.Drawing.Point(20, 87)
        Me.RadLabel29.Name = "RadLabel29"
        Me.RadLabel29.Size = New System.Drawing.Size(55, 20)
        Me.RadLabel29.TabIndex = 16
        Me.RadLabel29.Text = "Lot No.:"
        Me.RadLabel29.ThemeName = "CrystalDark"
        '
        'tbSAPartName
        '
        Me.tbSAPartName.Location = New System.Drawing.Point(72, 48)
        Me.tbSAPartName.Name = "tbSAPartName"
        Me.tbSAPartName.Size = New System.Drawing.Size(164, 24)
        Me.tbSAPartName.TabIndex = 15
        '
        'RadLabel28
        '
        Me.RadLabel28.Location = New System.Drawing.Point(2, 52)
        Me.RadLabel28.Name = "RadLabel28"
        Me.RadLabel28.Size = New System.Drawing.Size(76, 20)
        Me.RadLabel28.TabIndex = 14
        Me.RadLabel28.Text = "Part Name:"
        Me.RadLabel28.ThemeName = "CrystalDark"
        '
        'ddSAPartNo
        '
        Me.ddSAPartNo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddSAPartNo.Location = New System.Drawing.Point(72, 13)
        Me.ddSAPartNo.Name = "ddSAPartNo"
        Me.ddSAPartNo.Size = New System.Drawing.Size(164, 24)
        Me.ddSAPartNo.TabIndex = 8
        Me.ddSAPartNo.Text = "RadDropDownList1"
        '
        'RadLabel30
        '
        Me.RadLabel30.Location = New System.Drawing.Point(15, 17)
        Me.RadLabel30.Name = "RadLabel30"
        Me.RadLabel30.Size = New System.Drawing.Size(60, 20)
        Me.RadLabel30.TabIndex = 7
        Me.RadLabel30.Text = "Part No.:"
        Me.RadLabel30.ThemeName = "CrystalDark"
        '
        'Defects
        '
        Me.Defects.Controls.Add(Me.RadPanel9)
        Me.Defects.Image = CType(resources.GetObject("Defects.Image"), System.Drawing.Image)
        Me.Defects.ItemSize = New System.Drawing.SizeF(176.0!, 40.0!)
        Me.Defects.Location = New System.Drawing.Point(281, 37)
        Me.Defects.Name = "Defects"
        Me.Defects.Size = New System.Drawing.Size(1087, 653)
        Me.Defects.Text = "SRC In Process Defects"
        '
        'RadPanel9
        '
        Me.RadPanel9.Controls.Add(Me.rgvSRCDefects)
        Me.RadPanel9.Controls.Add(Me.RadPanel10)
        Me.RadPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel9.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(1087, 653)
        Me.RadPanel9.TabIndex = 1
        Me.RadPanel9.ThemeName = "CrystalDark"
        '
        'rgvSRCDefects
        '
        Me.rgvSRCDefects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgvSRCDefects.Location = New System.Drawing.Point(0, 190)
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
        Me.rgvSRCDefects.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.rgvSRCDefects.Name = "rgvSRCDefects"
        Me.rgvSRCDefects.Size = New System.Drawing.Size(1087, 463)
        Me.rgvSRCDefects.TabIndex = 5
        Me.rgvSRCDefects.ThemeName = "CrystalDark"
        '
        'RadPanel10
        '
        Me.RadPanel10.Controls.Add(Me.lblDefectID)
        Me.RadPanel10.Controls.Add(Me.btnSPDCancel)
        Me.RadPanel10.Controls.Add(Me.btnSPDSubmit)
        Me.RadPanel10.Controls.Add(Me.spnSPDRM)
        Me.RadPanel10.Controls.Add(Me.RadLabel43)
        Me.RadPanel10.Controls.Add(Me.spnSPDSubAssy)
        Me.RadPanel10.Controls.Add(Me.RadLabel42)
        Me.RadPanel10.Controls.Add(Me.spnSPDFFC)
        Me.RadPanel10.Controls.Add(Me.RadLabel41)
        Me.RadPanel10.Controls.Add(Me.spnSPDIM)
        Me.RadPanel10.Controls.Add(Me.RadLabel40)
        Me.RadPanel10.Controls.Add(Me.spnSPDMachine)
        Me.RadPanel10.Controls.Add(Me.RadLabel39)
        Me.RadPanel10.Controls.Add(Me.spnSPDMan)
        Me.RadPanel10.Controls.Add(Me.RadLabel38)
        Me.RadPanel10.Controls.Add(Me.tbSPDPartName)
        Me.RadPanel10.Controls.Add(Me.RadLabel36)
        Me.RadPanel10.Controls.Add(Me.ddSPDCode)
        Me.RadPanel10.Controls.Add(Me.RadLabel35)
        Me.RadPanel10.Controls.Add(Me.ddSPDCategory)
        Me.RadPanel10.Controls.Add(Me.RadLabel37)
        Me.RadPanel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel10.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel10.Name = "RadPanel10"
        Me.RadPanel10.Size = New System.Drawing.Size(1087, 190)
        Me.RadPanel10.TabIndex = 0
        Me.RadPanel10.ThemeName = "CrystalDark"
        '
        'lblDefectID
        '
        Me.lblDefectID.Location = New System.Drawing.Point(718, 46)
        Me.lblDefectID.Name = "lblDefectID"
        Me.lblDefectID.Size = New System.Drawing.Size(26, 20)
        Me.lblDefectID.TabIndex = 31
        Me.lblDefectID.Text = "IM:"
        Me.lblDefectID.ThemeName = "CrystalDark"
        Me.lblDefectID.Visible = False
        '
        'btnSPDCancel
        '
        Me.btnSPDCancel.Location = New System.Drawing.Point(511, 155)
        Me.btnSPDCancel.Name = "btnSPDCancel"
        Me.btnSPDCancel.Size = New System.Drawing.Size(85, 24)
        Me.btnSPDCancel.TabIndex = 30
        Me.btnSPDCancel.Text = "Cancel"
        Me.btnSPDCancel.Visible = False
        '
        'btnSPDSubmit
        '
        Me.btnSPDSubmit.Location = New System.Drawing.Point(411, 155)
        Me.btnSPDSubmit.Name = "btnSPDSubmit"
        Me.btnSPDSubmit.Size = New System.Drawing.Size(94, 24)
        Me.btnSPDSubmit.TabIndex = 29
        Me.btnSPDSubmit.Text = "SAVE"
        '
        'spnSPDRM
        '
        Me.spnSPDRM.Location = New System.Drawing.Point(411, 120)
        Me.spnSPDRM.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnSPDRM.Name = "spnSPDRM"
        Me.spnSPDRM.Size = New System.Drawing.Size(193, 24)
        Me.spnSPDRM.TabIndex = 27
        '
        'RadLabel43
        '
        Me.RadLabel43.Location = New System.Drawing.Point(381, 121)
        Me.RadLabel43.Name = "RadLabel43"
        Me.RadLabel43.Size = New System.Drawing.Size(31, 20)
        Me.RadLabel43.TabIndex = 28
        Me.RadLabel43.Text = "RM:"
        Me.RadLabel43.ThemeName = "CrystalDark"
        '
        'spnSPDSubAssy
        '
        Me.spnSPDSubAssy.Location = New System.Drawing.Point(411, 85)
        Me.spnSPDSubAssy.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnSPDSubAssy.Name = "spnSPDSubAssy"
        Me.spnSPDSubAssy.Size = New System.Drawing.Size(193, 24)
        Me.spnSPDSubAssy.TabIndex = 25
        '
        'RadLabel42
        '
        Me.RadLabel42.Location = New System.Drawing.Point(345, 86)
        Me.RadLabel42.Name = "RadLabel42"
        Me.RadLabel42.Size = New System.Drawing.Size(67, 20)
        Me.RadLabel42.TabIndex = 26
        Me.RadLabel42.Text = "Sub-Assy:"
        Me.RadLabel42.ThemeName = "CrystalDark"
        '
        'spnSPDFFC
        '
        Me.spnSPDFFC.Location = New System.Drawing.Point(411, 49)
        Me.spnSPDFFC.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnSPDFFC.Name = "spnSPDFFC"
        Me.spnSPDFFC.Size = New System.Drawing.Size(193, 24)
        Me.spnSPDFFC.TabIndex = 23
        '
        'RadLabel41
        '
        Me.RadLabel41.Location = New System.Drawing.Point(377, 50)
        Me.RadLabel41.Name = "RadLabel41"
        Me.RadLabel41.Size = New System.Drawing.Size(34, 20)
        Me.RadLabel41.TabIndex = 24
        Me.RadLabel41.Text = "FFC:"
        Me.RadLabel41.ThemeName = "CrystalDark"
        '
        'spnSPDIM
        '
        Me.spnSPDIM.Location = New System.Drawing.Point(411, 13)
        Me.spnSPDIM.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnSPDIM.Name = "spnSPDIM"
        Me.spnSPDIM.Size = New System.Drawing.Size(193, 24)
        Me.spnSPDIM.TabIndex = 21
        '
        'RadLabel40
        '
        Me.RadLabel40.Location = New System.Drawing.Point(385, 14)
        Me.RadLabel40.Name = "RadLabel40"
        Me.RadLabel40.Size = New System.Drawing.Size(26, 20)
        Me.RadLabel40.TabIndex = 22
        Me.RadLabel40.Text = "IM:"
        Me.RadLabel40.ThemeName = "CrystalDark"
        '
        'spnSPDMachine
        '
        Me.spnSPDMachine.Location = New System.Drawing.Point(108, 155)
        Me.spnSPDMachine.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnSPDMachine.Name = "spnSPDMachine"
        Me.spnSPDMachine.Size = New System.Drawing.Size(193, 24)
        Me.spnSPDMachine.TabIndex = 19
        '
        'RadLabel39
        '
        Me.RadLabel39.Location = New System.Drawing.Point(49, 156)
        Me.RadLabel39.Name = "RadLabel39"
        Me.RadLabel39.Size = New System.Drawing.Size(63, 20)
        Me.RadLabel39.TabIndex = 20
        Me.RadLabel39.Text = "Machine:"
        Me.RadLabel39.ThemeName = "CrystalDark"
        '
        'spnSPDMan
        '
        Me.spnSPDMan.Location = New System.Drawing.Point(108, 120)
        Me.spnSPDMan.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.spnSPDMan.Name = "spnSPDMan"
        Me.spnSPDMan.Size = New System.Drawing.Size(193, 24)
        Me.spnSPDMan.TabIndex = 17
        '
        'RadLabel38
        '
        Me.RadLabel38.Location = New System.Drawing.Point(73, 122)
        Me.RadLabel38.Name = "RadLabel38"
        Me.RadLabel38.Size = New System.Drawing.Size(37, 20)
        Me.RadLabel38.TabIndex = 18
        Me.RadLabel38.Text = "Man:"
        Me.RadLabel38.ThemeName = "CrystalDark"
        '
        'tbSPDPartName
        '
        Me.tbSPDPartName.Location = New System.Drawing.Point(108, 85)
        Me.tbSPDPartName.Name = "tbSPDPartName"
        Me.tbSPDPartName.Size = New System.Drawing.Size(193, 24)
        Me.tbSPDPartName.TabIndex = 12
        '
        'RadLabel36
        '
        Me.RadLabel36.Location = New System.Drawing.Point(38, 88)
        Me.RadLabel36.Name = "RadLabel36"
        Me.RadLabel36.Size = New System.Drawing.Size(76, 20)
        Me.RadLabel36.TabIndex = 11
        Me.RadLabel36.Text = "Part Name:"
        Me.RadLabel36.ThemeName = "CrystalDark"
        '
        'ddSPDCode
        '
        Me.ddSPDCode.Location = New System.Drawing.Point(108, 49)
        Me.ddSPDCode.Name = "ddSPDCode"
        Me.ddSPDCode.Size = New System.Drawing.Size(193, 24)
        Me.ddSPDCode.TabIndex = 10
        Me.ddSPDCode.Text = "RadDropDownList1"
        '
        'RadLabel35
        '
        Me.RadLabel35.Location = New System.Drawing.Point(10, 52)
        Me.RadLabel35.Name = "RadLabel35"
        Me.RadLabel35.Size = New System.Drawing.Size(103, 20)
        Me.RadLabel35.TabIndex = 9
        Me.RadLabel35.Text = "Defective Code:"
        Me.RadLabel35.ThemeName = "CrystalDark"
        '
        'ddSPDCategory
        '
        Me.ddSPDCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem4.Text = "A. Function Tester"
        RadListDataItem5.Text = "B. Electrical Test"
        RadListDataItem6.Text = "C. Final Tester"
        RadListDataItem7.Text = "D. Others"
        Me.ddSPDCategory.Items.Add(RadListDataItem4)
        Me.ddSPDCategory.Items.Add(RadListDataItem5)
        Me.ddSPDCategory.Items.Add(RadListDataItem6)
        Me.ddSPDCategory.Items.Add(RadListDataItem7)
        Me.ddSPDCategory.Location = New System.Drawing.Point(108, 13)
        Me.ddSPDCategory.Name = "ddSPDCategory"
        Me.ddSPDCategory.Size = New System.Drawing.Size(193, 24)
        Me.ddSPDCategory.TabIndex = 8
        '
        'RadLabel37
        '
        Me.RadLabel37.Location = New System.Drawing.Point(48, 16)
        Me.RadLabel37.Name = "RadLabel37"
        Me.RadLabel37.Size = New System.Drawing.Size(65, 20)
        Me.RadLabel37.TabIndex = 7
        Me.RadLabel37.Text = "Category:"
        Me.RadLabel37.ThemeName = "CrystalDark"
        '
        'Other
        '
        Me.Other.Controls.Add(Me.RadPanel11)
        Me.Other.Image = CType(resources.GetObject("Other.Image"), System.Drawing.Image)
        Me.Other.ItemSize = New System.Drawing.SizeF(176.0!, 40.0!)
        Me.Other.Location = New System.Drawing.Point(281, 37)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(1087, 653)
        Me.Other.Text = "Other Details"
        '
        'RadPanel11
        '
        Me.RadPanel11.Controls.Add(Me.RadScrollablePanel1)
        Me.RadPanel11.Controls.Add(Me.RadPanel14)
        Me.RadPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel11.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel11.Name = "RadPanel11"
        Me.RadPanel11.Size = New System.Drawing.Size(1087, 653)
        Me.RadPanel11.TabIndex = 2
        Me.RadPanel11.ThemeName = "CrystalDark"
        '
        'RadScrollablePanel1
        '
        Me.RadScrollablePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RadScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScrollablePanel1.Location = New System.Drawing.Point(0, 31)
        Me.RadScrollablePanel1.Name = "RadScrollablePanel1"
        '
        'RadScrollablePanel1.PanelContainer
        '
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.RadGroupBox8)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.RadGroupBox7)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.RadGroupBox6)
        Me.RadScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(1085, 620)
        Me.RadScrollablePanel1.Size = New System.Drawing.Size(1087, 622)
        Me.RadScrollablePanel1.TabIndex = 5
        '
        'RadGroupBox8
        '
        Me.RadGroupBox8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox8.Controls.Add(Me.tbOtherC)
        Me.RadGroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox8.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox8.HeaderText = "C. Others"
        Me.RadGroupBox8.Location = New System.Drawing.Point(0, 366)
        Me.RadGroupBox8.Name = "RadGroupBox8"
        Me.RadGroupBox8.Size = New System.Drawing.Size(1085, 183)
        Me.RadGroupBox8.TabIndex = 6
        Me.RadGroupBox8.Text = "C. Others"
        Me.RadGroupBox8.ThemeName = "CrystalDark"
        '
        'tbOtherC
        '
        Me.tbOtherC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbOtherC.Location = New System.Drawing.Point(2, 36)
        Me.tbOtherC.Multiline = True
        Me.tbOtherC.Name = "tbOtherC"
        '
        '
        '
        Me.tbOtherC.RootElement.StretchVertically = True
        Me.tbOtherC.Size = New System.Drawing.Size(1081, 145)
        Me.tbOtherC.TabIndex = 0
        '
        'RadGroupBox7
        '
        Me.RadGroupBox7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox7.Controls.Add(Me.tbOtherB)
        Me.RadGroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox7.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox7.HeaderText = "B. Initial Production"
        Me.RadGroupBox7.Location = New System.Drawing.Point(0, 183)
        Me.RadGroupBox7.Name = "RadGroupBox7"
        Me.RadGroupBox7.Size = New System.Drawing.Size(1085, 183)
        Me.RadGroupBox7.TabIndex = 5
        Me.RadGroupBox7.Text = "B. Initial Production"
        Me.RadGroupBox7.ThemeName = "CrystalDark"
        '
        'tbOtherB
        '
        Me.tbOtherB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbOtherB.Location = New System.Drawing.Point(2, 36)
        Me.tbOtherB.Multiline = True
        Me.tbOtherB.Name = "tbOtherB"
        '
        '
        '
        Me.tbOtherB.RootElement.StretchVertically = True
        Me.tbOtherB.Size = New System.Drawing.Size(1081, 145)
        Me.tbOtherB.TabIndex = 0
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Controls.Add(Me.tbOtherA)
        Me.RadGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox6.HeaderMargin = New System.Windows.Forms.Padding(1)
        Me.RadGroupBox6.HeaderText = "A. Mold Parts Combination Compatibility"
        Me.RadGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox6.Name = "RadGroupBox6"
        Me.RadGroupBox6.Size = New System.Drawing.Size(1085, 183)
        Me.RadGroupBox6.TabIndex = 4
        Me.RadGroupBox6.Text = "A. Mold Parts Combination Compatibility"
        Me.RadGroupBox6.ThemeName = "CrystalDark"
        '
        'tbOtherA
        '
        Me.tbOtherA.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbOtherA.Location = New System.Drawing.Point(2, 36)
        Me.tbOtherA.Multiline = True
        Me.tbOtherA.Name = "tbOtherA"
        '
        '
        '
        Me.tbOtherA.RootElement.StretchVertically = True
        Me.tbOtherA.Size = New System.Drawing.Size(1081, 145)
        Me.tbOtherA.TabIndex = 0
        '
        'RadPanel14
        '
        Me.RadPanel14.Controls.Add(Me.btnSubmitOther)
        Me.RadPanel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel14.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel14.Name = "RadPanel14"
        Me.RadPanel14.Size = New System.Drawing.Size(1087, 31)
        Me.RadPanel14.TabIndex = 4
        Me.RadPanel14.ThemeName = "CrystalDark"
        '
        'btnSubmitOther
        '
        Me.btnSubmitOther.Location = New System.Drawing.Point(3, 3)
        Me.btnSubmitOther.Name = "btnSubmitOther"
        Me.btnSubmitOther.Size = New System.Drawing.Size(94, 24)
        Me.btnSubmitOther.TabIndex = 29
        Me.btnSubmitOther.Text = "SAVE"
        '
        'Lot
        '
        Me.Lot.Controls.Add(Me.RadScrollablePanel4)
        Me.Lot.Image = CType(resources.GetObject("Lot.Image"), System.Drawing.Image)
        Me.Lot.ItemSize = New System.Drawing.SizeF(176.0!, 40.0!)
        Me.Lot.Location = New System.Drawing.Point(281, 37)
        Me.Lot.Name = "Lot"
        Me.Lot.Size = New System.Drawing.Size(1087, 653)
        Me.Lot.Text = "RM & WIP Lot No."
        '
        'RadScrollablePanel4
        '
        Me.RadScrollablePanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScrollablePanel4.Location = New System.Drawing.Point(0, 0)
        Me.RadScrollablePanel4.Name = "RadScrollablePanel4"
        '
        'RadScrollablePanel4.PanelContainer
        '
        Me.RadScrollablePanel4.PanelContainer.Controls.Add(Me.btnLotSubmit)
        Me.RadScrollablePanel4.PanelContainer.Controls.Add(Me.rgvLotNo)
        Me.RadScrollablePanel4.PanelContainer.Controls.Add(Me.RadPanel12)
        Me.RadScrollablePanel4.PanelContainer.Size = New System.Drawing.Size(1085, 651)
        Me.RadScrollablePanel4.Size = New System.Drawing.Size(1087, 653)
        Me.RadScrollablePanel4.TabIndex = 0
        Me.RadScrollablePanel4.ThemeName = "CrystalDark"
        '
        'btnLotSubmit
        '
        Me.btnLotSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLotSubmit.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLotSubmit.Location = New System.Drawing.Point(961, 550)
        Me.btnLotSubmit.Name = "btnLotSubmit"
        Me.btnLotSubmit.Size = New System.Drawing.Size(121, 44)
        Me.btnLotSubmit.TabIndex = 30
        Me.btnLotSubmit.Text = "SAVE"
        Me.btnLotSubmit.ThemeName = "CrystalDark"
        '
        'rgvLotNo
        '
        Me.rgvLotNo.Dock = System.Windows.Forms.DockStyle.Top
        Me.rgvLotNo.Location = New System.Drawing.Point(0, 71)
        '
        '
        '
        Me.rgvLotNo.MasterTemplate.ViewDefinition = TableViewDefinition7
        Me.rgvLotNo.Name = "rgvLotNo"
        Me.rgvLotNo.Size = New System.Drawing.Size(1085, 449)
        Me.rgvLotNo.TabIndex = 29
        Me.rgvLotNo.ThemeName = "CrystalDark"
        '
        'RadPanel12
        '
        Me.RadPanel12.Controls.Add(Me.txtBoxNo)
        Me.RadPanel12.Controls.Add(Me.RadLabel45)
        Me.RadPanel12.Controls.Add(Me.ddLotTime)
        Me.RadPanel12.Controls.Add(Me.RadLabel44)
        Me.RadPanel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel12.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel12.Name = "RadPanel12"
        Me.RadPanel12.Size = New System.Drawing.Size(1085, 71)
        Me.RadPanel12.TabIndex = 0
        Me.RadPanel12.ThemeName = "ControlDefault"
        '
        'txtBoxNo
        '
        Me.txtBoxNo.Location = New System.Drawing.Point(331, 41)
        Me.txtBoxNo.Name = "txtBoxNo"
        Me.txtBoxNo.Size = New System.Drawing.Size(179, 24)
        Me.txtBoxNo.TabIndex = 30
        '
        'RadLabel45
        '
        Me.RadLabel45.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel45.Location = New System.Drawing.Point(282, 44)
        Me.RadLabel45.Name = "RadLabel45"
        Me.RadLabel45.Size = New System.Drawing.Size(54, 20)
        Me.RadLabel45.TabIndex = 29
        Me.RadLabel45.Text = "Box No:"
        Me.RadLabel45.ThemeName = "CrystalDark"
        '
        'ddLotTime
        '
        Me.ddLotTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ddLotTime.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddLotTime.Location = New System.Drawing.Point(61, 41)
        Me.ddLotTime.Name = "ddLotTime"
        Me.ddLotTime.Size = New System.Drawing.Size(193, 24)
        Me.ddLotTime.TabIndex = 28
        Me.ddLotTime.Text = "RadDropDownList1"
        '
        'RadLabel44
        '
        Me.RadLabel44.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel44.Location = New System.Drawing.Point(23, 44)
        Me.RadLabel44.Name = "RadLabel44"
        Me.RadLabel44.Size = New System.Drawing.Size(41, 20)
        Me.RadLabel44.TabIndex = 27
        Me.RadLabel44.Text = "Time:"
        Me.RadLabel44.ThemeName = "CrystalDark"
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'FrmSRCDailyReportNewV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 729)
        Me.Controls.Add(Me.RadPageView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSRCDailyReportNewV2"
        Me.Text = "FrmSRCDailyReportNewV2"
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
        CType(Me.rcbTrainee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcbTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rcbQualified, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtManpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddTeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbManpower.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbManpower.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbManpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEditID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMPCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMPSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Hourly.ResumeLayout(False)
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me.rgvHourly.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvHourly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel4.ResumeLayout(False)
        Me.RadScrollablePanel2.PanelContainer.ResumeLayout(False)
        Me.RadScrollablePanel2.PanelContainer.PerformLayout()
        CType(Me.RadScrollablePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel2.ResumeLayout(False)
        CType(Me.lblHQEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHQCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHQSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        Me.RadGroupBox4.PerformLayout()
        CType(Me.spnHQFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHQFunction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHQElectrical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHQDeviation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHQActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHQPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbHQBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.spnHQSleeve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHQSubstator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHQStator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHQRotator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.cbHQ3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbHQ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbHQ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddHQTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Assylinef.ResumeLayout(False)
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel5.ResumeLayout(False)
        CType(Me.rgvAssyLineEff.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvAssyLineEff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel6.ResumeLayout(False)
        Me.RadScrollablePanel3.PanelContainer.ResumeLayout(False)
        Me.RadScrollablePanel3.PanelContainer.PerformLayout()
        CType(Me.RadScrollablePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel3.ResumeLayout(False)
        CType(Me.lblOptimeText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblOptimeText.ResumeLayout(False)
        Me.lblOptimeText.PerformLayout()
        CType(Me.lblTotalOperationTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAssyCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCycle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbUnplanned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbPlanned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbALEOpTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnALESubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        Me.RadGroupBox5.PerformLayout()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbModelName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnALEAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnALESample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnALEScrap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnALEReplace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnALEGoodQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbALELotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbALEModelCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbALEFGNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbALECustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbALETime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnALEHotto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SRCAssy.ResumeLayout(False)
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel7.ResumeLayout(False)
        CType(Me.rgvSRCAssy.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSRCAssy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel8.ResumeLayout(False)
        Me.RadPanel8.PerformLayout()
        CType(Me.btnSACancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSRCAssyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSASubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSAEng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSAQASample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSAPurge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSAScrap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSALotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSAPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSAPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel30, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Defects.ResumeLayout(False)
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel9.ResumeLayout(False)
        CType(Me.rgvSRCDefects.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvSRCDefects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel10.ResumeLayout(False)
        Me.RadPanel10.PerformLayout()
        CType(Me.lblDefectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSPDCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSPDSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnSPDRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnSPDSubAssy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnSPDFFC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnSPDIM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnSPDMachine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnSPDMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSPDPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSPDCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSPDCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel37, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Other.ResumeLayout(False)
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel11.ResumeLayout(False)
        Me.RadScrollablePanel1.PanelContainer.ResumeLayout(False)
        CType(Me.RadScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel1.ResumeLayout(False)
        CType(Me.RadGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox8.ResumeLayout(False)
        Me.RadGroupBox8.PerformLayout()
        CType(Me.tbOtherC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox7.ResumeLayout(False)
        Me.RadGroupBox7.PerformLayout()
        CType(Me.tbOtherB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox6.ResumeLayout(False)
        Me.RadGroupBox6.PerformLayout()
        CType(Me.tbOtherA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel14.ResumeLayout(False)
        CType(Me.btnSubmitOther, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lot.ResumeLayout(False)
        Me.RadScrollablePanel4.PanelContainer.ResumeLayout(False)
        CType(Me.RadScrollablePanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel4.ResumeLayout(False)
        CType(Me.btnLotSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvLotNo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvLotNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel12.ResumeLayout(False)
        Me.RadPanel12.PerformLayout()
        CType(Me.txtBoxNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLotTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadProgressBar1 As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents lblLoading As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSRCAutoAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents FluentDarkTheme1 As Telerik.WinControls.Themes.FluentDarkTheme
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents Manpower As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvManpower As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblEditID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnMPCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnMPSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents ddStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddProc As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Hourly As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvHourly As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadScrollablePanel2 As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents lblHQEdit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnHQCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnHQSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents spnHQFinal As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnHQFunction As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnHQElectrical As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnHQDeviation As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnHQActual As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnHQPlan As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbHQBarcode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents cbHQ3 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbHQ2 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbHQ1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ddHQTime As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Assylinef As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvAssyLineEff As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadScrollablePanel3 As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents tbCycle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel51 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbUnplanned As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel50 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbPlanned As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel49 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbALEOpTime As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnALESubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btnALEAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents spnALESample As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel27 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnALEScrap As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel26 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnALEReplace As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel25 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnALEGoodQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel24 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbALELotNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel23 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbALEModelCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel21 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbALEFGNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbALECustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnEdit As PictureBox
    Friend WithEvents tbALETime As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnALEHotto As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents SRCAssy As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvSRCAssy As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnSACancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblSRCAssyID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSASubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents tbSAEng As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel34 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbSAQASample As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel33 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbSAPurge As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel32 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbSAScrap As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel31 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbSALotNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel29 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbSAPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel28 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddSAPartNo As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel30 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Defects As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rgvSRCDefects As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel10 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lblDefectID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSPDCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSPDSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents spnSPDRM As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel43 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnSPDSubAssy As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel42 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnSPDFFC As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel41 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnSPDIM As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel40 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnSPDMachine As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel39 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnSPDMan As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel38 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbSPDPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel36 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddSPDCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel35 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddSPDCategory As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel37 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Other As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPanel11 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents RadGroupBox8 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tbOtherC As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadGroupBox7 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tbOtherB As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadGroupBox6 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tbOtherA As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel14 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnSubmitOther As Telerik.WinControls.UI.RadButton
    Friend WithEvents Lot As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents btnReCons As Telerik.WinControls.UI.RadButton
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbDelivered As CheckBox
    Friend WithEvents RadLabel52 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblTotalQty As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbManpower As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents ddTeam As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtManpower As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cbModelName As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnAssyCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents spnHQRotator As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents spnHQSleeve As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents spnHQSubstator As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents spnHQStator As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents rcbQualified As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rcbTrainee As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rcbTransfer As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents lblTotalOperationTime As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblOptimeText As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadScrollablePanel4 As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents rgvLotNo As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel12 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents ddLotTime As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel44 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnLotSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtBoxNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel45 As Telerik.WinControls.UI.RadLabel
End Class

