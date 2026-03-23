Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class FrmDownTimeUpload
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim DTModel As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")

    Private Sub FrmDownTimeUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dpDate.Value = Now
        GridCol()
        GetModels()
    End Sub
    Private Sub GetModels()

        ddModel.DataSource = DTModel
        ddModel.DisplayMember = "fldModelName"
        ddModel.ValueMember = "fldCode"
        ddModel.AutoCompleteDataSource = DTModel
        ddModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModel.AutoCompleteDisplayMember = "fldModelName"
        ddModel.AutoCompleteValueMember = "fldCode"
        ddModel.Text = ""

    End Sub

    Private Sub cbbCheck_Click(sender As Object, e As EventArgs) Handles cbbCheck.Click
        Dim format As String = "yyyy-MM-dd"

        Dim ParDate As Date = dpDate.Value
        Dim ParAssy As String = ddModel.Text
        Dim LineString As String = ddLine.Text.Substring(0, 2)
        Dim ParType As String = ddType.Text

        Maria.AddMySqlParameters("parDate", ParDate)
        Maria.AddMySqlParameters("parAssy", ParAssy)
        Maria.AddMySqlParameters("parLine", LineString)
        Maria.AddMySqlParameters("parType", ParType)
        Dim CheckDT As DataTable = Maria.SPSelect("SP_SRCDailyReport_SelectDownTimeByData")

        If CheckDT.Rows.Count.ToString = 1 Then
            MessageBox.Show("Record Exists")
            cbbOpen.Enabled = True
        Else
            MessageBox.Show("Not Existing")
        End If


    End Sub

    Private Sub dpDate_ValueChanged(sender As Object, e As EventArgs) Handles dpDate.ValueChanged
        cbbOpen.Enabled = False
        cbbSave.Enabled = False
    End Sub

    Private Sub ddModel_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddModel.SelectedIndexChanged
        cbbOpen.Enabled = False
        cbbSave.Enabled = False
    End Sub

    Private Sub ddLine_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddLine.SelectedIndexChanged
        cbbOpen.Enabled = False
        cbbSave.Enabled = False
    End Sub

    Private Sub ddType_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddType.SelectedIndexChanged
        cbbOpen.Enabled = False
        cbbSave.Enabled = False


    End Sub

    Private Sub cbbExport_Click(sender As Object, e As EventArgs) Handles cbbExport.Click
        FrmDowntimeExcel.ShowDialog(Me)
    End Sub

    Private Sub GridCol()

        Dim ProdName As New GridViewTextBoxColumn
        ProdName.HeaderText = "PRODUCT NAME"
        ProdName.FieldName = "PRODUCT NAME"
        ProdName.TextAlignment = ContentAlignment.MiddleCenter
        ProdName.Width = 150
        gvData.Columns.Add(ProdName)

        Dim StopTime As New GridViewTextBoxColumn
        StopTime.HeaderText = "STOP TIME"
        StopTime.FieldName = "STOP TIME"
        StopTime.TextAlignment = ContentAlignment.MiddleCenter
        StopTime.Width = 150
        gvData.Columns.Add(StopTime)

        Dim StartTime As New GridViewTextBoxColumn
        StartTime.HeaderText = "START TIME"
        StartTime.FieldName = "START TIME"
        StartTime.TextAlignment = ContentAlignment.MiddleCenter
        StartTime.Width = 150
        gvData.Columns.Add(StartTime)

        Dim Planned As New GridViewTextBoxColumn
        Planned.HeaderText = "PLANNED"
        Planned.FieldName = "PLANNED"
        Planned.TextAlignment = ContentAlignment.MiddleCenter
        Planned.Width = 150
        gvData.Columns.Add(Planned)

        Dim MachName As New GridViewTextBoxColumn
        MachName.HeaderText = "MACHINE NAME"
        MachName.FieldName = "MACHINE NAME"
        MachName.TextAlignment = ContentAlignment.MiddleCenter
        MachName.Width = 150
        gvData.Columns.Add(MachName)

        Dim Man As New GridViewTextBoxColumn
        Man.HeaderText = "MAN"
        Man.FieldName = "MAN"
        Man.TextAlignment = ContentAlignment.MiddleCenter
        Man.Width = 150
        gvData.Columns.Add(Man)

        Dim Mach As New GridViewTextBoxColumn
        Mach.HeaderText = "MACHINE"
        Mach.FieldName = "MACHINE"
        Mach.TextAlignment = ContentAlignment.MiddleCenter
        Mach.Width = 150
        gvData.Columns.Add(Mach)

        Dim Mats As New GridViewTextBoxColumn
        Mats.HeaderText = "MATERIAL"
        Mats.FieldName = "MATERIAL"
        Mats.TextAlignment = ContentAlignment.MiddleCenter
        Mats.Width = 150
        gvData.Columns.Add(Mats)

        Dim Math As New GridViewTextBoxColumn
        Math.HeaderText = "METHOD"
        Math.FieldName = "METHOD"
        Math.TextAlignment = ContentAlignment.MiddleCenter
        Math.Width = 150
        gvData.Columns.Add(Math)

        Dim SetUp As New GridViewTextBoxColumn
        SetUp.HeaderText = "SETUP"
        SetUp.FieldName = "SETUP"
        SetUp.TextAlignment = ContentAlignment.MiddleCenter
        SetUp.Width = 150
        gvData.Columns.Add(SetUp)

        Dim Kanban As New GridViewTextBoxColumn
        Kanban.HeaderText = "KANBAN"
        Kanban.FieldName = "KANBAN"
        Kanban.TextAlignment = ContentAlignment.MiddleCenter
        Kanban.Width = 150
        gvData.Columns.Add(Kanban)

        Dim Other1 As New GridViewTextBoxColumn
        Other1.HeaderText = "OTHERS"
        Other1.FieldName = "OTHERS"
        Other1.TextAlignment = ContentAlignment.MiddleCenter
        Other1.Width = 150
        gvData.Columns.Add(Other1)

        Dim AfterSet As New GridViewTextBoxColumn
        AfterSet.HeaderText = "AFTER SETUP"
        AfterSet.FieldName = "AFTER SETUP"
        AfterSet.TextAlignment = ContentAlignment.MiddleCenter
        AfterSet.Width = 150
        gvData.Columns.Add(AfterSet)

        Dim AfterPM As New GridViewTextBoxColumn
        AfterPM.HeaderText = "AFTER PM"
        AfterPM.FieldName = "AFTER PM"
        AfterPM.TextAlignment = ContentAlignment.MiddleCenter
        AfterPM.Width = 150
        gvData.Columns.Add(AfterPM)

        Dim MachineQA As New GridViewTextBoxColumn
        MachineQA.HeaderText = "MACHINE (QA)"
        MachineQA.FieldName = "MACHINE (QA)"
        MachineQA.TextAlignment = ContentAlignment.MiddleCenter
        MachineQA.Width = 150
        gvData.Columns.Add(MachineQA)

        Dim MaterialQA As New GridViewTextBoxColumn
        MaterialQA.HeaderText = "MATERIAL (QA)"
        MaterialQA.FieldName = "MATERIAL (QA)"
        MaterialQA.TextAlignment = ContentAlignment.MiddleCenter
        MaterialQA.Width = 150
        gvData.Columns.Add(MaterialQA)

        Dim Cause As New GridViewTextBoxColumn
        Cause.HeaderText = "CAUSE"
        Cause.FieldName = "CAUSE"
        Cause.TextAlignment = ContentAlignment.MiddleCenter
        Cause.Width = 150
        gvData.Columns.Add(Cause)

        Dim Me1 As New GridViewTextBoxColumn
        Me1.HeaderText = "ME"
        Me1.FieldName = "ME"
        Me1.TextAlignment = ContentAlignment.MiddleCenter
        Me1.Width = 150
        gvData.Columns.Add(Me1)

        Dim Pde As New GridViewTextBoxColumn
        Pde.HeaderText = "PDE"
        Pde.FieldName = "PDE"
        Pde.TextAlignment = ContentAlignment.MiddleCenter
        Pde.Width = 150
        gvData.Columns.Add(Pde)

        Dim Pme As New GridViewTextBoxColumn
        Pme.HeaderText = "PME"
        Pme.FieldName = "PME"
        Pme.TextAlignment = ContentAlignment.MiddleCenter
        Pme.Width = 150
        gvData.Columns.Add(Pme)

        Dim OtherSect As New GridViewTextBoxColumn
        OtherSect.HeaderText = "OTHERS (SECT)"
        OtherSect.FieldName = "OTHERS (SECT)"
        OtherSect.TextAlignment = ContentAlignment.MiddleCenter
        OtherSect.Width = 150
        gvData.Columns.Add(OtherSect)

        Dim Pic As New GridViewTextBoxColumn
        Pic.HeaderText = "PIC"
        Pic.FieldName = "PIC"
        Pic.TextAlignment = ContentAlignment.MiddleCenter
        Pic.Width = 150
        gvData.Columns.Add(Pic)
    End Sub
End Class
