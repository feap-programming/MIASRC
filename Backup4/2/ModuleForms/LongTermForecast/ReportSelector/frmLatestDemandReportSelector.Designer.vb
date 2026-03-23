<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLatestDemandReportSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLatestDemandReportSelector))
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.pgForecastVsLatestDemand = New Telerik.WinControls.UI.RadPageViewPage()
        Me.tglFLDReportSource = New Telerik.WinControls.UI.RadToggleSwitch()
        Me.btnFLDGenerate = New Telerik.WinControls.UI.RadButton()
        Me.dtFLDDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtFLDDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblFLDReportSource = New Telerik.WinControls.UI.RadLabel()
        Me.lblFLDCoveredDate = New Telerik.WinControls.UI.RadLabel()
        Me.pgLatestDemand = New Telerik.WinControls.UI.RadPageViewPage()
        Me.tglLDReportSource = New Telerik.WinControls.UI.RadToggleSwitch()
        Me.drpLDCustomer = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnLDGenerate = New Telerik.WinControls.UI.RadButton()
        Me.lblLDCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.dtLDDateReceivedTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtLDDateReceivedFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDash = New Telerik.WinControls.UI.RadLabel()
        Me.lblLDReportSource = New Telerik.WinControls.UI.RadLabel()
        Me.lblLDCoveredDate = New Telerik.WinControls.UI.RadLabel()
        Me.pgDemandComparison = New Telerik.WinControls.UI.RadPageViewPage()
        Me.lblDCReportSource = New Telerik.WinControls.UI.RadLabel()
        Me.tglDCReportSource = New Telerik.WinControls.UI.RadToggleSwitch()
        Me.lblVersus = New Telerik.WinControls.UI.RadLabel()
        Me.drpDCCustomer = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnDCGenerate = New Telerik.WinControls.UI.RadButton()
        Me.lblDCCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.dtDCDateReceived2 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtDCDateReceived1 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDCDateReceived1 = New Telerik.WinControls.UI.RadLabel()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.pgForecastVsLatestDemand.SuspendLayout()
        CType(Me.tglFLDReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFLDGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFLDDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFLDDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFLDReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFLDCoveredDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgLatestDemand.SuspendLayout()
        CType(Me.tglLDReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpLDCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLDGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLDCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLDDateReceivedTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLDDateReceivedFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLDReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLDCoveredDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgDemandComparison.SuspendLayout()
        CType(Me.lblDCReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDCReportSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVersus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpDCCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDCGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDCCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDCDateReceived2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDCDateReceived1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDCDateReceived1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.pgForecastVsLatestDemand)
        Me.RadPageView1.Controls.Add(Me.pgLatestDemand)
        Me.RadPageView1.Controls.Add(Me.pgDemandComparison)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.ItemSizeMode = CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode)
        Me.RadPageView1.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.pgForecastVsLatestDemand
        Me.RadPageView1.Size = New System.Drawing.Size(372, 275)
        Me.RadPageView1.TabIndex = 0
        Me.RadPageView1.ThemeName = "Office2007Black"
        Me.RadPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
        '
        'pgForecastVsLatestDemand
        '
        Me.pgForecastVsLatestDemand.Controls.Add(Me.tglFLDReportSource)
        Me.pgForecastVsLatestDemand.Controls.Add(Me.btnFLDGenerate)
        Me.pgForecastVsLatestDemand.Controls.Add(Me.dtFLDDateTo)
        Me.pgForecastVsLatestDemand.Controls.Add(Me.dtFLDDateFrom)
        Me.pgForecastVsLatestDemand.Controls.Add(Me.RadLabel2)
        Me.pgForecastVsLatestDemand.Controls.Add(Me.lblFLDReportSource)
        Me.pgForecastVsLatestDemand.Controls.Add(Me.lblFLDCoveredDate)
        Me.pgForecastVsLatestDemand.ItemSize = New System.Drawing.SizeF(372.0!, 34.0!)
        Me.pgForecastVsLatestDemand.Location = New System.Drawing.Point(5, 35)
        Me.pgForecastVsLatestDemand.Name = "pgForecastVsLatestDemand"
        Me.pgForecastVsLatestDemand.Size = New System.Drawing.Size(362, 137)
        Me.pgForecastVsLatestDemand.Text = "Forecast vs Latest Demand"
        '
        'tglFLDReportSource
        '
        Me.tglFLDReportSource.Location = New System.Drawing.Point(102, 70)
        Me.tglFLDReportSource.Name = "tglFLDReportSource"
        Me.tglFLDReportSource.OffText = "LOCAL"
        Me.tglFLDReportSource.OnText = "SERVER"
        Me.tglFLDReportSource.Size = New System.Drawing.Size(110, 20)
        Me.tglFLDReportSource.TabIndex = 4
        Me.tglFLDReportSource.ThemeName = "Office2007Black"
        Me.tglFLDReportSource.ThumbTickness = 19
        '
        'btnFLDGenerate
        '
        Me.btnFLDGenerate.Location = New System.Drawing.Point(102, 96)
        Me.btnFLDGenerate.Name = "btnFLDGenerate"
        Me.btnFLDGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnFLDGenerate.TabIndex = 5
        Me.btnFLDGenerate.Text = "Generate"
        Me.btnFLDGenerate.ThemeName = "Office2007Black"
        '
        'dtFLDDateTo
        '
        Me.dtFLDDateTo.CustomFormat = "MMM dd, yyyy"
        Me.dtFLDDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFLDDateTo.Location = New System.Drawing.Point(235, 44)
        Me.dtFLDDateTo.Name = "dtFLDDateTo"
        Me.dtFLDDateTo.Size = New System.Drawing.Size(110, 20)
        Me.dtFLDDateTo.TabIndex = 3
        Me.dtFLDDateTo.TabStop = False
        Me.dtFLDDateTo.Text = "Aug 25, 2020"
        Me.dtFLDDateTo.ThemeName = "Office2007Black"
        Me.dtFLDDateTo.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtFLDDateFrom
        '
        Me.dtFLDDateFrom.CustomFormat = "MMM dd, yyyy"
        Me.dtFLDDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFLDDateFrom.Location = New System.Drawing.Point(102, 44)
        Me.dtFLDDateFrom.Name = "dtFLDDateFrom"
        Me.dtFLDDateFrom.Size = New System.Drawing.Size(110, 20)
        Me.dtFLDDateFrom.TabIndex = 2
        Me.dtFLDDateFrom.TabStop = False
        Me.dtFLDDateFrom.Text = "Aug 25, 2020"
        Me.dtFLDDateFrom.ThemeName = "Office2007Black"
        Me.dtFLDDateFrom.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'RadLabel2
        '
        Me.RadLabel2.ForeColor = System.Drawing.Color.Black
        Me.RadLabel2.Location = New System.Drawing.Point(218, 45)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(11, 18)
        Me.RadLabel2.TabIndex = 7
        Me.RadLabel2.Text = "-"
        Me.RadLabel2.ThemeName = "Office2007Black"
        '
        'lblFLDReportSource
        '
        Me.lblFLDReportSource.ForeColor = System.Drawing.Color.Black
        Me.lblFLDReportSource.Location = New System.Drawing.Point(19, 72)
        Me.lblFLDReportSource.Name = "lblFLDReportSource"
        Me.lblFLDReportSource.Size = New System.Drawing.Size(77, 18)
        Me.lblFLDReportSource.TabIndex = 0
        Me.lblFLDReportSource.Text = "Report Source"
        Me.lblFLDReportSource.ThemeName = "Office2007Black"
        '
        'lblFLDCoveredDate
        '
        Me.lblFLDCoveredDate.ForeColor = System.Drawing.Color.Black
        Me.lblFLDCoveredDate.Location = New System.Drawing.Point(22, 45)
        Me.lblFLDCoveredDate.Name = "lblFLDCoveredDate"
        Me.lblFLDCoveredDate.Size = New System.Drawing.Size(74, 18)
        Me.lblFLDCoveredDate.TabIndex = 0
        Me.lblFLDCoveredDate.Text = "Covered Date"
        Me.lblFLDCoveredDate.ThemeName = "Office2007Black"
        '
        'pgLatestDemand
        '
        Me.pgLatestDemand.Controls.Add(Me.tglLDReportSource)
        Me.pgLatestDemand.Controls.Add(Me.drpLDCustomer)
        Me.pgLatestDemand.Controls.Add(Me.btnLDGenerate)
        Me.pgLatestDemand.Controls.Add(Me.lblLDCustomer)
        Me.pgLatestDemand.Controls.Add(Me.dtLDDateReceivedTo)
        Me.pgLatestDemand.Controls.Add(Me.dtLDDateReceivedFrom)
        Me.pgLatestDemand.Controls.Add(Me.lblDash)
        Me.pgLatestDemand.Controls.Add(Me.lblLDReportSource)
        Me.pgLatestDemand.Controls.Add(Me.lblLDCoveredDate)
        Me.pgLatestDemand.ItemSize = New System.Drawing.SizeF(372.0!, 34.0!)
        Me.pgLatestDemand.Location = New System.Drawing.Point(5, 35)
        Me.pgLatestDemand.Name = "pgLatestDemand"
        Me.pgLatestDemand.Size = New System.Drawing.Size(362, 137)
        Me.pgLatestDemand.Text = "Demand Summary"
        '
        'tglLDReportSource
        '
        Me.tglLDReportSource.Location = New System.Drawing.Point(102, 70)
        Me.tglLDReportSource.Name = "tglLDReportSource"
        Me.tglLDReportSource.OffText = "LOCAL"
        Me.tglLDReportSource.OnText = "SERVER"
        Me.tglLDReportSource.Size = New System.Drawing.Size(110, 20)
        Me.tglLDReportSource.TabIndex = 4
        Me.tglLDReportSource.ThemeName = "Office2007Black"
        Me.tglLDReportSource.ThumbTickness = 19
        '
        'drpLDCustomer
        '
        Me.drpLDCustomer.DropDownAnimationEnabled = True
        Me.drpLDCustomer.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.drpLDCustomer.Location = New System.Drawing.Point(102, 18)
        Me.drpLDCustomer.Name = "drpLDCustomer"
        Me.drpLDCustomer.Size = New System.Drawing.Size(110, 20)
        Me.drpLDCustomer.TabIndex = 1
        Me.drpLDCustomer.ThemeName = "Office2007Black"
        '
        'btnLDGenerate
        '
        Me.btnLDGenerate.Location = New System.Drawing.Point(102, 96)
        Me.btnLDGenerate.Name = "btnLDGenerate"
        Me.btnLDGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnLDGenerate.TabIndex = 5
        Me.btnLDGenerate.Text = "Generate"
        Me.btnLDGenerate.ThemeName = "Office2007Black"
        '
        'lblLDCustomer
        '
        Me.lblLDCustomer.BackColor = System.Drawing.Color.Transparent
        Me.lblLDCustomer.ForeColor = System.Drawing.Color.Black
        Me.lblLDCustomer.Location = New System.Drawing.Point(41, 20)
        Me.lblLDCustomer.Name = "lblLDCustomer"
        Me.lblLDCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblLDCustomer.TabIndex = 0
        Me.lblLDCustomer.Text = "Customer"
        Me.lblLDCustomer.ThemeName = "Office2007Black"
        '
        'dtLDDateReceivedTo
        '
        Me.dtLDDateReceivedTo.CustomFormat = "MMM dd, yyyy"
        Me.dtLDDateReceivedTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtLDDateReceivedTo.Location = New System.Drawing.Point(235, 44)
        Me.dtLDDateReceivedTo.Name = "dtLDDateReceivedTo"
        Me.dtLDDateReceivedTo.Size = New System.Drawing.Size(110, 20)
        Me.dtLDDateReceivedTo.TabIndex = 3
        Me.dtLDDateReceivedTo.TabStop = False
        Me.dtLDDateReceivedTo.Text = "Aug 25, 2020"
        Me.dtLDDateReceivedTo.ThemeName = "Office2007Black"
        Me.dtLDDateReceivedTo.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtLDDateReceivedFrom
        '
        Me.dtLDDateReceivedFrom.CustomFormat = "MMM dd, yyyy"
        Me.dtLDDateReceivedFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtLDDateReceivedFrom.Location = New System.Drawing.Point(102, 44)
        Me.dtLDDateReceivedFrom.Name = "dtLDDateReceivedFrom"
        Me.dtLDDateReceivedFrom.Size = New System.Drawing.Size(110, 20)
        Me.dtLDDateReceivedFrom.TabIndex = 2
        Me.dtLDDateReceivedFrom.TabStop = False
        Me.dtLDDateReceivedFrom.Text = "Aug 25, 2020"
        Me.dtLDDateReceivedFrom.ThemeName = "Office2007Black"
        Me.dtLDDateReceivedFrom.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblDash
        '
        Me.lblDash.ForeColor = System.Drawing.Color.Black
        Me.lblDash.Location = New System.Drawing.Point(218, 45)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(11, 18)
        Me.lblDash.TabIndex = 0
        Me.lblDash.Text = "-"
        Me.lblDash.ThemeName = "Office2007Black"
        '
        'lblLDReportSource
        '
        Me.lblLDReportSource.ForeColor = System.Drawing.Color.Black
        Me.lblLDReportSource.Location = New System.Drawing.Point(19, 72)
        Me.lblLDReportSource.Name = "lblLDReportSource"
        Me.lblLDReportSource.Size = New System.Drawing.Size(77, 18)
        Me.lblLDReportSource.TabIndex = 0
        Me.lblLDReportSource.Text = "Report Source"
        Me.lblLDReportSource.ThemeName = "Office2007Black"
        '
        'lblLDCoveredDate
        '
        Me.lblLDCoveredDate.ForeColor = System.Drawing.Color.Black
        Me.lblLDCoveredDate.Location = New System.Drawing.Point(22, 45)
        Me.lblLDCoveredDate.Name = "lblLDCoveredDate"
        Me.lblLDCoveredDate.Size = New System.Drawing.Size(74, 18)
        Me.lblLDCoveredDate.TabIndex = 0
        Me.lblLDCoveredDate.Text = "Covered Date"
        Me.lblLDCoveredDate.ThemeName = "Office2007Black"
        '
        'pgDemandComparison
        '
        Me.pgDemandComparison.Controls.Add(Me.lblDCReportSource)
        Me.pgDemandComparison.Controls.Add(Me.tglDCReportSource)
        Me.pgDemandComparison.Controls.Add(Me.lblVersus)
        Me.pgDemandComparison.Controls.Add(Me.drpDCCustomer)
        Me.pgDemandComparison.Controls.Add(Me.btnDCGenerate)
        Me.pgDemandComparison.Controls.Add(Me.lblDCCustomer)
        Me.pgDemandComparison.Controls.Add(Me.dtDCDateReceived2)
        Me.pgDemandComparison.Controls.Add(Me.dtDCDateReceived1)
        Me.pgDemandComparison.Controls.Add(Me.lblDCDateReceived1)
        Me.pgDemandComparison.ItemSize = New System.Drawing.SizeF(372.0!, 34.0!)
        Me.pgDemandComparison.Location = New System.Drawing.Point(5, 35)
        Me.pgDemandComparison.Name = "pgDemandComparison"
        Me.pgDemandComparison.Size = New System.Drawing.Size(362, 137)
        Me.pgDemandComparison.Text = "Demand Comparison"
        '
        'lblDCReportSource
        '
        Me.lblDCReportSource.ForeColor = System.Drawing.Color.Black
        Me.lblDCReportSource.Location = New System.Drawing.Point(19, 72)
        Me.lblDCReportSource.Name = "lblDCReportSource"
        Me.lblDCReportSource.Size = New System.Drawing.Size(77, 18)
        Me.lblDCReportSource.TabIndex = 0
        Me.lblDCReportSource.Text = "Report Source"
        Me.lblDCReportSource.ThemeName = "Office2007Black"
        '
        'tglDCReportSource
        '
        Me.tglDCReportSource.Location = New System.Drawing.Point(102, 70)
        Me.tglDCReportSource.Name = "tglDCReportSource"
        Me.tglDCReportSource.OffText = "LOCAL"
        Me.tglDCReportSource.OnText = "SERVER"
        Me.tglDCReportSource.Size = New System.Drawing.Size(110, 20)
        Me.tglDCReportSource.TabIndex = 6
        Me.tglDCReportSource.ThemeName = "Office2007Black"
        Me.tglDCReportSource.ThumbTickness = 19
        '
        'lblVersus
        '
        Me.lblVersus.ForeColor = System.Drawing.Color.Black
        Me.lblVersus.Location = New System.Drawing.Point(218, 45)
        Me.lblVersus.Name = "lblVersus"
        Me.lblVersus.Size = New System.Drawing.Size(16, 18)
        Me.lblVersus.TabIndex = 5
        Me.lblVersus.Text = "vs"
        Me.lblVersus.ThemeName = "Office2007Black"
        '
        'drpDCCustomer
        '
        Me.drpDCCustomer.DropDownAnimationEnabled = True
        Me.drpDCCustomer.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.drpDCCustomer.Location = New System.Drawing.Point(102, 18)
        Me.drpDCCustomer.Name = "drpDCCustomer"
        Me.drpDCCustomer.Size = New System.Drawing.Size(110, 20)
        Me.drpDCCustomer.TabIndex = 1
        Me.drpDCCustomer.ThemeName = "Office2007Black"
        '
        'btnDCGenerate
        '
        Me.btnDCGenerate.Location = New System.Drawing.Point(102, 96)
        Me.btnDCGenerate.Name = "btnDCGenerate"
        Me.btnDCGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnDCGenerate.TabIndex = 4
        Me.btnDCGenerate.Text = "Generate"
        Me.btnDCGenerate.ThemeName = "Office2007Black"
        '
        'lblDCCustomer
        '
        Me.lblDCCustomer.BackColor = System.Drawing.Color.Transparent
        Me.lblDCCustomer.ForeColor = System.Drawing.Color.Black
        Me.lblDCCustomer.Location = New System.Drawing.Point(41, 20)
        Me.lblDCCustomer.Name = "lblDCCustomer"
        Me.lblDCCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblDCCustomer.TabIndex = 1
        Me.lblDCCustomer.Text = "Customer"
        Me.lblDCCustomer.ThemeName = "Office2007Black"
        '
        'dtDCDateReceived2
        '
        Me.dtDCDateReceived2.CustomFormat = "MMM dd, yyyy"
        Me.dtDCDateReceived2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDCDateReceived2.Location = New System.Drawing.Point(240, 44)
        Me.dtDCDateReceived2.Name = "dtDCDateReceived2"
        Me.dtDCDateReceived2.Size = New System.Drawing.Size(110, 20)
        Me.dtDCDateReceived2.TabIndex = 3
        Me.dtDCDateReceived2.TabStop = False
        Me.dtDCDateReceived2.Text = "Aug 25, 2020"
        Me.dtDCDateReceived2.ThemeName = "Office2007Black"
        Me.dtDCDateReceived2.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'dtDCDateReceived1
        '
        Me.dtDCDateReceived1.CustomFormat = "MMM dd, yyyy"
        Me.dtDCDateReceived1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDCDateReceived1.Location = New System.Drawing.Point(102, 44)
        Me.dtDCDateReceived1.Name = "dtDCDateReceived1"
        Me.dtDCDateReceived1.Size = New System.Drawing.Size(110, 20)
        Me.dtDCDateReceived1.TabIndex = 2
        Me.dtDCDateReceived1.TabStop = False
        Me.dtDCDateReceived1.Text = "Aug 25, 2020"
        Me.dtDCDateReceived1.ThemeName = "Office2007Black"
        Me.dtDCDateReceived1.Value = New Date(2020, 8, 25, 10, 11, 53, 631)
        '
        'lblDCDateReceived1
        '
        Me.lblDCDateReceived1.ForeColor = System.Drawing.Color.Black
        Me.lblDCDateReceived1.Location = New System.Drawing.Point(3, 45)
        Me.lblDCDateReceived1.Name = "lblDCDateReceived1"
        Me.lblDCDateReceived1.Size = New System.Drawing.Size(93, 18)
        Me.lblDCDateReceived1.TabIndex = 0
        Me.lblDCDateReceived1.Text = "Comparison Date"
        Me.lblDCDateReceived1.ThemeName = "Office2007Black"
        '
        'FrmLatestDemandReportSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 275)
        Me.Controls.Add(Me.RadPageView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLatestDemandReportSelector"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "CrystalDark"
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.pgForecastVsLatestDemand.ResumeLayout(False)
        Me.pgForecastVsLatestDemand.PerformLayout()
        CType(Me.tglFLDReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFLDGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFLDDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFLDDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFLDReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFLDCoveredDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgLatestDemand.ResumeLayout(False)
        Me.pgLatestDemand.PerformLayout()
        CType(Me.tglLDReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpLDCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLDGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLDCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLDDateReceivedTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLDDateReceivedFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLDReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLDCoveredDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgDemandComparison.ResumeLayout(False)
        Me.pgDemandComparison.PerformLayout()
        CType(Me.lblDCReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDCReportSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVersus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpDCCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDCGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDCCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDCDateReceived2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDCDateReceived1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDCDateReceived1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pgLatestDemand As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pgDemandComparison As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents dtLDDateReceivedFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblLDCoveredDate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblLDCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtLDDateReceivedTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents btnLDGenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDCGenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblDCCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtDCDateReceived2 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtDCDateReceived1 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblDCDateReceived1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpLDCustomer As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents drpDCCustomer As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblDash As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblVersus As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tglLDReportSource As Telerik.WinControls.UI.RadToggleSwitch
    Friend WithEvents tglDCReportSource As Telerik.WinControls.UI.RadToggleSwitch
    Friend WithEvents lblLDReportSource As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDCReportSource As Telerik.WinControls.UI.RadLabel
    Friend WithEvents pgForecastVsLatestDemand As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents tglFLDReportSource As Telerik.WinControls.UI.RadToggleSwitch
    Friend WithEvents btnFLDGenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtFLDDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtFLDDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblFLDReportSource As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblFLDCoveredDate As Telerik.WinControls.UI.RadLabel
End Class

