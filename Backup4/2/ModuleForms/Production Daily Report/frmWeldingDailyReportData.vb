Public Class FrmWeldingDailyReportData
    Private Sub FrmWeldingDailyReportData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Manpower = New ucWeldingManpower()
        spManpower.Controls.Add(Manpower)
        spManpower.Dock = DockStyle.Fill
        Manpower.Dock = DockStyle.Fill

        Dim Hourly = New ucWeldingHourly()
        spHourly.Controls.Add(Hourly)
        spHourly.Dock = DockStyle.Fill
        Hourly.Dock = DockStyle.Fill

        If globalVariables.SRCReportType = "PW" Then

            Dim Defects = New ucWeldingDefectsPW()
            spDefect.Controls.Add(Defects)
            spDefect.Dock = DockStyle.Fill
            Defects.Dock = DockStyle.Fill

        Else

            Dim Defects = New ucWeldingDefectsFW()
            spDefect.Controls.Add(Defects)
            spDefect.Dock = DockStyle.Fill
            Defects.Dock = DockStyle.Fill

        End If

        Dim LotNo = New ucWeldingRMWIP()
        spLot.Controls.Add(LotNo)
        spLot.Dock = DockStyle.Fill
        LotNo.Dock = DockStyle.Fill

    End Sub
End Class
