Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmDailyReportData
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")

    Private Sub FrmDailyReportData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Slipknot.changeTheme(Me)

        Dim Manpower = New ucDailyManpower()
        spManpower.Controls.Add(Manpower)
        spManpower.Dock = DockStyle.Fill
        Manpower.Dock = DockStyle.Fill

        Dim HourlyQuality = New ucDailyHourlyQuality()
        spHourlyQuality.Controls.Add(HourlyQuality)
        spHourlyQuality.Dock = DockStyle.Fill
        HourlyQuality.Dock = DockStyle.Fill

        Dim AssyLineEff = New ucAssyLineEff()
        spLineEff.Controls.Add(AssyLineEff)
        spLineEff.Dock = DockStyle.Fill
        AssyLineEff.Dock = DockStyle.Fill

        Dim SRCAssy = New ucDailySRCAssy()
        spSRCAssy.Controls.Add(SRCAssy)
        spSRCAssy.Dock = DockStyle.Fill
        SRCAssy.Dock = DockStyle.Fill

        Dim SRCDefects = New ucSRCInProcDefects()
        spSRCinProcDefect.Controls.Add(SRCDefects)
        spSRCinProcDefect.Dock = DockStyle.Fill
        SRCDefects.Dock = DockStyle.Fill

        Dim OtherDetails = New ucDailyOtherDetails()
        spOtherDetails.Controls.Add(OtherDetails)
        spOtherDetails.Dock = DockStyle.Fill
        OtherDetails.Dock = DockStyle.Fill

        Dim RMWIPLotNo = New ucDailyRawMats()
        spRMWIPLotNo.Controls.Add(RMWIPLotNo)
        spRMWIPLotNo.Dock = DockStyle.Fill
        RMWIPLotNo.Dock = DockStyle.Fill

    End Sub


End Class
