<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDailyReportData
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
        Me.wowo = New Telerik.WinControls.UI.RadPageView()
        Me.manpower = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spManpower = New System.Windows.Forms.Panel()
        Me.hourlyquality = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spHourlyQuality = New System.Windows.Forms.Panel()
        Me.assylineeff = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spLineEff = New System.Windows.Forms.Panel()
        Me.srcassy = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spSRCAssy = New System.Windows.Forms.Panel()
        Me.srcinprocessdefects = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spSRCinProcDefect = New System.Windows.Forms.Panel()
        Me.otherdetails = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spOtherDetails = New System.Windows.Forms.Panel()
        Me.rmwiplot = New Telerik.WinControls.UI.RadPageViewPage()
        Me.spRMWIPLotNo = New System.Windows.Forms.Panel()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        CType(Me.wowo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wowo.SuspendLayout()
        Me.manpower.SuspendLayout()
        Me.hourlyquality.SuspendLayout()
        Me.assylineeff.SuspendLayout()
        Me.srcassy.SuspendLayout()
        Me.srcinprocessdefects.SuspendLayout()
        Me.otherdetails.SuspendLayout()
        Me.rmwiplot.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wowo
        '
        Me.wowo.Controls.Add(Me.manpower)
        Me.wowo.Controls.Add(Me.hourlyquality)
        Me.wowo.Controls.Add(Me.assylineeff)
        Me.wowo.Controls.Add(Me.srcassy)
        Me.wowo.Controls.Add(Me.srcinprocessdefects)
        Me.wowo.Controls.Add(Me.otherdetails)
        Me.wowo.Controls.Add(Me.rmwiplot)
        Me.wowo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wowo.Location = New System.Drawing.Point(0, 0)
        Me.wowo.Name = "wowo"
        Me.wowo.SelectedPage = Me.manpower
        Me.wowo.Size = New System.Drawing.Size(1134, 556)
        Me.wowo.TabIndex = 0
        Me.wowo.ThemeName = "CrystalDark"
        '
        'manpower
        '
        Me.manpower.Controls.Add(Me.spManpower)
        Me.manpower.ItemSize = New System.Drawing.SizeF(80.0!, 28.0!)
        Me.manpower.Location = New System.Drawing.Point(6, 33)
        Me.manpower.Name = "manpower"
        Me.manpower.Size = New System.Drawing.Size(1122, 516)
        Me.manpower.Text = "Manpower"
        '
        'spManpower
        '
        Me.spManpower.AutoScroll = True
        Me.spManpower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spManpower.Location = New System.Drawing.Point(0, 0)
        Me.spManpower.Name = "spManpower"
        Me.spManpower.Size = New System.Drawing.Size(1122, 516)
        Me.spManpower.TabIndex = 0
        '
        'hourlyquality
        '
        Me.hourlyquality.Controls.Add(Me.spHourlyQuality)
        Me.hourlyquality.ItemSize = New System.Drawing.SizeF(100.0!, 28.0!)
        Me.hourlyquality.Location = New System.Drawing.Point(6, 33)
        Me.hourlyquality.Name = "hourlyquality"
        Me.hourlyquality.Size = New System.Drawing.Size(1122, 516)
        Me.hourlyquality.Text = "Hourly Quality"
        '
        'spHourlyQuality
        '
        Me.spHourlyQuality.AutoScroll = True
        Me.spHourlyQuality.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spHourlyQuality.Location = New System.Drawing.Point(0, 0)
        Me.spHourlyQuality.Name = "spHourlyQuality"
        Me.spHourlyQuality.Size = New System.Drawing.Size(1122, 516)
        Me.spHourlyQuality.TabIndex = 1
        '
        'assylineeff
        '
        Me.assylineeff.Controls.Add(Me.spLineEff)
        Me.assylineeff.ItemSize = New System.Drawing.SizeF(167.0!, 28.0!)
        Me.assylineeff.Location = New System.Drawing.Point(6, 33)
        Me.assylineeff.Name = "assylineeff"
        Me.assylineeff.Size = New System.Drawing.Size(1122, 516)
        Me.assylineeff.Text = "Assembly Line Efficiency"
        '
        'spLineEff
        '
        Me.spLineEff.AutoScroll = True
        Me.spLineEff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spLineEff.Location = New System.Drawing.Point(0, 0)
        Me.spLineEff.Name = "spLineEff"
        Me.spLineEff.Size = New System.Drawing.Size(1122, 516)
        Me.spLineEff.TabIndex = 2
        '
        'srcassy
        '
        Me.srcassy.Controls.Add(Me.spSRCAssy)
        Me.srcassy.ItemSize = New System.Drawing.SizeF(104.0!, 28.0!)
        Me.srcassy.Location = New System.Drawing.Point(6, 33)
        Me.srcassy.Name = "srcassy"
        Me.srcassy.Size = New System.Drawing.Size(1122, 516)
        Me.srcassy.Text = "SRC Assembly"
        '
        'spSRCAssy
        '
        Me.spSRCAssy.AutoScroll = True
        Me.spSRCAssy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spSRCAssy.Location = New System.Drawing.Point(0, 0)
        Me.spSRCAssy.Name = "spSRCAssy"
        Me.spSRCAssy.Size = New System.Drawing.Size(1122, 516)
        Me.spSRCAssy.TabIndex = 3
        '
        'srcinprocessdefects
        '
        Me.srcinprocessdefects.Controls.Add(Me.spSRCinProcDefect)
        Me.srcinprocessdefects.ItemSize = New System.Drawing.SizeF(159.0!, 28.0!)
        Me.srcinprocessdefects.Location = New System.Drawing.Point(6, 33)
        Me.srcinprocessdefects.Name = "srcinprocessdefects"
        Me.srcinprocessdefects.Size = New System.Drawing.Size(1122, 516)
        Me.srcinprocessdefects.Text = "SRC In Process Defects"
        '
        'spSRCinProcDefect
        '
        Me.spSRCinProcDefect.AutoScroll = True
        Me.spSRCinProcDefect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spSRCinProcDefect.Location = New System.Drawing.Point(0, 0)
        Me.spSRCinProcDefect.Name = "spSRCinProcDefect"
        Me.spSRCinProcDefect.Size = New System.Drawing.Size(1122, 516)
        Me.spSRCinProcDefect.TabIndex = 4
        '
        'otherdetails
        '
        Me.otherdetails.Controls.Add(Me.spOtherDetails)
        Me.otherdetails.ItemSize = New System.Drawing.SizeF(94.0!, 28.0!)
        Me.otherdetails.Location = New System.Drawing.Point(6, 33)
        Me.otherdetails.Name = "otherdetails"
        Me.otherdetails.Size = New System.Drawing.Size(1122, 516)
        Me.otherdetails.Text = "Other Details"
        '
        'spOtherDetails
        '
        Me.spOtherDetails.AutoScroll = True
        Me.spOtherDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spOtherDetails.Location = New System.Drawing.Point(0, 0)
        Me.spOtherDetails.Name = "spOtherDetails"
        Me.spOtherDetails.Size = New System.Drawing.Size(1122, 516)
        Me.spOtherDetails.TabIndex = 5
        '
        'rmwiplot
        '
        Me.rmwiplot.Controls.Add(Me.spRMWIPLotNo)
        Me.rmwiplot.ItemSize = New System.Drawing.SizeF(123.0!, 28.0!)
        Me.rmwiplot.Location = New System.Drawing.Point(6, 33)
        Me.rmwiplot.Name = "rmwiplot"
        Me.rmwiplot.Size = New System.Drawing.Size(1122, 516)
        Me.rmwiplot.Text = "RM & WIP Lot No."
        '
        'spRMWIPLotNo
        '
        Me.spRMWIPLotNo.AutoScroll = True
        Me.spRMWIPLotNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spRMWIPLotNo.Location = New System.Drawing.Point(0, 0)
        Me.spRMWIPLotNo.Name = "spRMWIPLotNo"
        Me.spRMWIPLotNo.Size = New System.Drawing.Size(1122, 516)
        Me.spRMWIPLotNo.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 556)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 63)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightPink
        Me.Panel3.Location = New System.Drawing.Point(266, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(70, 20)
        Me.Panel3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(224, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Blank: "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(114, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(70, 20)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Not Editable: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Legends:"
        '
        'FrmDailyReportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1134, 619)
        Me.Controls.Add(Me.wowo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDailyReportData"
        Me.Text = "Daily Report"
        Me.ThemeName = "CrystalDark"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.wowo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wowo.ResumeLayout(False)
        Me.manpower.ResumeLayout(False)
        Me.hourlyquality.ResumeLayout(False)
        Me.assylineeff.ResumeLayout(False)
        Me.srcassy.ResumeLayout(False)
        Me.srcinprocessdefects.ResumeLayout(False)
        Me.otherdetails.ResumeLayout(False)
        Me.rmwiplot.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wowo As Telerik.WinControls.UI.RadPageView
    Friend WithEvents manpower As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents hourlyquality As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents assylineeff As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents spManpower As Panel
    Friend WithEvents spHourlyQuality As Panel
    Friend WithEvents spLineEff As Panel
    Friend WithEvents srcassy As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spSRCAssy As Panel
    Friend WithEvents srcinprocessdefects As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spSRCinProcDefect As Panel
    Friend WithEvents otherdetails As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spOtherDetails As Panel
    Friend WithEvents rmwiplot As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents spRMWIPLotNo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
End Class

