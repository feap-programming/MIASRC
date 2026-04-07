Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmAssemblyDownTime
    Dim EditID As Integer = 0
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    'Dim Maria As New DB("localhost", "dbmia", "root", "password")
    'Dim Catherine As New Kurumi.DB("192.168.191.252", "dbHRMSlive", "feap", "45|iF$")
    'Dim EngEmp As DataTable = Catherine.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where (fldEmpDepartment='ENG' or fldEmpDepartment='ENG1' or fldEmpDepartment='ENG2') and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Public Property DowntimeType As String
    Public Property AssyDownTimeID As Integer
    Public Property AssyDownTimeModel As String
    Public Property AssyDownTimeLine As String
    Public Property AssyDownTimeDate As Date
    Public Property AssyDownTimeType As String
    Public Property FWGroupDt As String

    Private allCauses As New List(Of String)

    Private Sub FrmAssemblyDownTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'GetEngEmp()
        GetMinutes()
        ReloadTimeDD()
        'If globalVariables.AssyDownTimeType = "PW" Then
        '    ReadyPWWeldingNo()
        'ElseIf globalVariables.AssyDownTimeType = "FW" Then
        '    ReadyFWWeldingNo()
        'ElseIf globalVariables.DowntimeType = "Taping" Then
        '    ReadyATMachine()
        'End If


        'dpDate.Value = globalVariables.AssyDownTimeDate
        'tbAssyLine.Text = globalVariables.AssyDownTimeModel & " " & globalVariables.AssyDownTimeLine
        'If globalVariables.DowntimeType = "ASSY" Then
        '    ddWeldingNo.Visible = False
        '    lblWeldingNo.Visible = False
        'End If
        If AssyDownTimeType = "PW" Then
            ReadyPWWeldingNo()
        ElseIf AssyDownTimeType = "FW" Then
            ReadyFWWeldingNo()
        ElseIf DowntimeType = "Taping" Then
            ReadyATMachine()
        End If


        dpDate.Value = AssyDownTimeDate
        tbAssyLine.Text = AssyDownTimeModel & " " & AssyDownTimeLine
        If DowntimeType = "ASSY" Then
            ddWeldingNo.Visible = False
            lblWeldingNo.Visible = False
        End If
        GridCol()
        ReloadGrid()
        readycbModelName()
    End Sub
    Private Sub readycbModelName()
        Dim DTModelName As DataTable
        DTModelName = GetModelName()
        cbProdName.DataSource = DTModelName
        cbProdName.DisplayMember = "fldPartName"
        cbProdName.ValueMember = "fldID"
        cbProdName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cbProdName.DropDownListElement.AutoCompleteSuggest.SuggestMode = Telerik.WinControls.UI.SuggestMode.Contains



    End Sub

    Private Function GetModelName() As DataTable
        Dim DTModelName As DataTable
        Maria.AddMySqlParameters("parModel", AssyDownTimeModel)
        DTModelName = Maria.SPSelect("SP_SelectModelNamev3")
        Return DTModelName
    End Function

    Private Sub GridCol()
        gvData.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.ReadOnly = True
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldDTID As New GridViewTextBoxColumn
        fldDTID.HeaderText = "DTID"
        fldDTID.FieldName = "fldDTID"
        fldDTID.TextAlignment = ContentAlignment.MiddleCenter
        fldDTID.Width = 100
        fldDTID.ReadOnly = True
        fldDTID.IsVisible = False
        gvData.Columns.Add(fldDTID)

        Dim fldShift As New GridViewTextBoxColumn
        fldShift.HeaderText = "SHIFT"
        fldShift.FieldName = "fldShift"
        fldShift.TextAlignment = ContentAlignment.MiddleCenter
        fldShift.Width = 100
        fldShift.ReadOnly = True
        gvData.Columns.Add(fldShift)

        Dim fldProdName As New GridViewTextBoxColumn
        fldProdName.HeaderText = "PRODUCT NAME"
        fldProdName.FieldName = "fldProdName"
        fldProdName.TextAlignment = ContentAlignment.MiddleCenter
        fldProdName.Width = 200
        fldProdName.ReadOnly = True
        gvData.Columns.Add(fldProdName)

        Dim fldStopTime As New GridViewTextBoxColumn
        fldStopTime.HeaderText = "STOP TIME"
        fldStopTime.FieldName = "fldStopTime"
        fldStopTime.TextAlignment = ContentAlignment.MiddleCenter
        fldStopTime.Width = 100
        fldStopTime.ReadOnly = True
        gvData.Columns.Add(fldStopTime)

        Dim fldStartTime As New GridViewTextBoxColumn
        fldStartTime.HeaderText = "START TIME"
        fldStartTime.FieldName = "fldStartTime"
        fldStartTime.TextAlignment = ContentAlignment.MiddleCenter
        fldStartTime.Width = 100
        fldStartTime.ReadOnly = True
        gvData.Columns.Add(fldStartTime)

        Dim fldPlan As New GridViewCheckBoxColumn()
        fldPlan.DataType = GetType(Integer)
        fldPlan.FieldName = "fldPlan"
        fldPlan.HeaderText = "PLANNED?"
        fldPlan.MinWidth = 80
        gvData.MasterTemplate.Columns.Add(fldPlan)

        Dim fldMachName As New GridViewTextBoxColumn
        fldMachName.HeaderText = "MACHINE NAME"
        fldMachName.FieldName = "fldMachName"
        fldMachName.TextAlignment = ContentAlignment.MiddleCenter
        fldMachName.Width = 200
        fldMachName.ReadOnly = True
        gvData.Columns.Add(fldMachName)

        Dim fldWeldingNo As New GridViewTextBoxColumn
        fldWeldingNo.HeaderText = "WELDING NO."
        fldWeldingNo.FieldName = "fldWeldingNo"
        fldWeldingNo.TextAlignment = ContentAlignment.MiddleCenter
        fldWeldingNo.Width = 200
        fldWeldingNo.ReadOnly = True
        gvData.Columns.Add(fldWeldingNo)

        If globalVariables.DowntimeType = "ASSY" Then
            fldWeldingNo.IsVisible = False
        Else
            fldWeldingNo.IsVisible = True
        End If

        Dim ViewEdit As New GridViewCommandColumn()
        ViewEdit.Name = "ViewEdit"
        ViewEdit.UseDefaultText = True
        ViewEdit.FieldName = "ViewEdit"
        ViewEdit.HeaderText = "VIEW/EDIT"
        ViewEdit.DefaultText = "VIEW/EDIT"
        ViewEdit.MinWidth = 70
        ViewEdit.TextAlignment = ContentAlignment.MiddleCenter
        gvData.MasterTemplate.Columns.Add(ViewEdit)


    End Sub

    Private Sub GetMinutes()
        ddStopMin.Items.Clear()
        ddStartMin.Items.Clear()
        Dim i As Integer = 1
        While i <= 60
            ddStartMin.Items.Add(i)
            ddStopMin.Items.Add(i)
            i = i + 1
        End While

    End Sub
    Private Sub ReloadTimeDD()
        ddStopTime.Items.Clear()
        ddStartTime.Items.Clear()
        If ddShift.Text = "1st Shift" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                ddStopTime.Items.Add(InitialTime.ToString)
                ddStartTime.Items.Add(InitialTime.ToString)


            End While
        ElseIf ddShift.Text = "Day Shift" Then
            Dim InitialTime As Integer = 6
            Dim InitialHour As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                ddStopTime.Items.Add(InitialTime.ToString)
                ddStartTime.Items.Add(InitialTime.ToString)

            End While
        ElseIf ddShift.Text = "2nd Shift" Then
            Dim InitialTime As Integer = 14
            Dim InitialHour As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1

                ddStopTime.Items.Add(InitialTime.ToString)
                ddStartTime.Items.Add(InitialTime.ToString)
            End While
        ElseIf ddShift.Text = "Night Shift" Then
            Dim InitialTime As Integer = 18
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 12

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    ddStopTime.Items.Add(After24Hrs.ToString)
                    ddStartTime.Items.Add(After24Hrs.ToString)
                Else
                    ddStopTime.Items.Add(InitialTime.ToString)
                    ddStartTime.Items.Add(InitialTime.ToString)
                End If
            End While
        ElseIf ddShift.Text = "3rd Shift" Then
            Dim InitialTime As Integer = 22
            Dim InitialHour As Integer = 0
            Dim After24Hrs As Integer = 0
            While InitialHour < 8

                InitialHour = InitialHour + 1
                InitialTime = InitialTime + 1
                If InitialTime > 24 Then
                    After24Hrs = After24Hrs + 1
                    ddStopTime.Items.Add(After24Hrs.ToString)
                    ddStartTime.Items.Add(After24Hrs.ToString)
                Else
                    ddStopTime.Items.Add(InitialTime.ToString)
                    ddStartTime.Items.Add(InitialTime.ToString)
                End If
            End While
        End If

    End Sub

    Private Sub ddShift_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddShift.SelectedIndexChanged
        ReloadTimeDD()
    End Sub
    Private Sub ReadyPWWeldingNo()
        Dim dtPWMachine As New DataTable
        'Maria.AddMySqlParameters("parModel", globalVariables.AssyDownTimeModel.ToString())
        'Maria.AddMySqlParameters("parLine", globalVariables.AssyDownTimeLine)
        Maria.AddMySqlParameters("parModel", AssyDownTimeModel.ToString())
        Maria.AddMySqlParameters("parLine", AssyDownTimeLine)
        dtPWMachine = Maria.SPSelect("SP_WeldingDowntime_SelectPWMachine")
        ddWeldingNo.Items.Clear()
        ddWeldingNo.DataSource = dtPWMachine
        ddWeldingNo.ValueMember = "fldPw"
        ddWeldingNo.DisplayMember = "fldPw"

    End Sub
    Private Sub ReadyFWWeldingNo()
        Dim dtFWMachine As New DataTable
        'Maria.AddMySqlParameters("parModel", globalVariables.AssyDownTimeModel.ToString())
        'Maria.AddMySqlParameters("parLine", globalVariables.AssyDownTimeLine)
        'Maria.AddMySqlParameters("parGroup", globalVariables.FWGroupDt)
        Maria.AddMySqlParameters("parModel", AssyDownTimeModel.ToString())
        Maria.AddMySqlParameters("parLine", AssyDownTimeLine)
        Maria.AddMySqlParameters("parGroup", FWGroupDt)
        dtFWMachine = Maria.SPSelect("SP_WeldingDowntime_SelectFWMachine")
        ddWeldingNo.Items.Clear()
        ddWeldingNo.DataSource = dtFWMachine
        ddWeldingNo.ValueMember = "fldFwMachine"
        ddWeldingNo.DisplayMember = "fldFwMachine"
    End Sub
    Private Sub ReadyATMachine()
        Dim dtATMachine As New DataTable
        'Maria.AddMySqlParameters("parModel", globalVariables.AssyDownTimeModel.ToString())
        'Maria.AddMySqlParameters("parLine", globalVariables.AssyDownTimeLine)
        Maria.AddMySqlParameters("parModel", AssyDownTimeModel.ToString())
        Maria.AddMySqlParameters("parLine", AssyDownTimeLine)
        dtATMachine = Maria.SPSelect("SP_SRC_SelectATDowntimeMachine")
        ddWeldingNo.Items.Clear()
        ddWeldingNo.DataSource = dtATMachine
        ddWeldingNo.ValueMember = "fldMachNo"
        ddWeldingNo.DisplayMember = "fldMachNo"
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "SAVE" Then
            SaveReport()
        Else
            Updatereport()
        End If

    End Sub
    Private Sub Updatereport()

        Try
            Maria.AddMySqlParameters("parID", EditID)
            Maria.AddMySqlParameters("parShift", ddShift.Text)
            Maria.AddMySqlParameters("parProdName", tbProdName.Text)
            Maria.AddMySqlParameters("parStopTime", If(ddStopTime.Text = "24", "00", ddStopTime.Text) & ":" & ddStopMin.Text & ":00")
            Maria.AddMySqlParameters("parStartTime", If(ddStartTime.Text = "24", "00", ddStartTime.Text) & ":" & ddStartMin.Text & ":00")
            Maria.AddMySqlParameters("parPlan", swPlan.Value)
            Maria.AddMySqlParameters("parMachName", tbMachName.Text)
            Maria.AddMySqlParameters("parMan", cbDCMan.CheckState)
            Maria.AddMySqlParameters("parMachine", cbDCMachine.CheckState)
            Maria.AddMySqlParameters("parMaterial", cbDCMats.CheckState)
            Maria.AddMySqlParameters("parMethod", cbDCMethod.CheckState)
            Maria.AddMySqlParameters("parSetup", cbDCSetup.CheckState)
            Maria.AddMySqlParameters("parKanban", cbDCWaitingKanban.CheckState)
            Maria.AddMySqlParameters("parOthers", cbDCOther.CheckState)
            Maria.AddMySqlParameters("parAfterSetup", cbAAfterSetup.CheckState)
            Maria.AddMySqlParameters("parAfterPM", cbAAfterPM.CheckState)
            Maria.AddMySqlParameters("parMachine2", cbQAMachine.CheckState)
            Maria.AddMySqlParameters("parMaterial2", cbQAMats.CheckState)
            Maria.AddMySqlParameters("parCause", tbCause.Text)
            Maria.AddMySqlParameters("parME", cbSME.CheckState)
            Maria.AddMySqlParameters("parPDE", cbSPDE.CheckState)
            Maria.AddMySqlParameters("parPME", cbSPME.CheckState)
            Maria.AddMySqlParameters("parOthers2", cbSOthers.CheckState)
            Maria.AddMySqlParameters("parPIC", txtPIC.Text)
            'If globalVariables.DowntimeType = "ASSY" Then
            If DowntimeType = "ASSY" Then
                Maria.AddMySqlParameters("parWeldingNo", 0)
            Else
                Maria.AddMySqlParameters("parWeldingNo", ddWeldingNo.Text)
            End If
            Maria.SPADE("SP_SRCDownTime_UpdateDownTimev2")

            MessageBox.Show("Done")
            btnSave.Text = "SAVE"

            ReloadGrid()
            Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Private Sub GetEngEmp()
    '    ddPIC.DataSource = EngEmp
    '    ddPIC.DisplayMember = "fldEmpName"
    '    ddPIC.ValueMember = "fldEmpName"
    '    ddPIC.AutoCompleteDataSource = EngEmp
    '    ddPIC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    ddPIC.AutoCompleteDisplayMember = "fldEmpName"
    '    ddPIC.AutoCompleteValueMember = "fldEmpName"
    '    ddPIC.Text = ""
    'End Sub
    Private Sub SaveReport()

        Try
            'Maria.AddMySqlParameters("parDTID", globalVariables.AssyDownTimeID)
            Maria.AddMySqlParameters("parDTID", AssyDownTimeID)
            Maria.AddMySqlParameters("parShift", ddShift.Text)
            Maria.AddMySqlParameters("parProdName", tbProdName.Text)
            Maria.AddMySqlParameters("parStopTime", If(ddStopTime.Text = "24", "00", ddStopTime.Text) & ":" & ddStopMin.Text & ":00")
            Maria.AddMySqlParameters("parStartTime", If(ddStartTime.Text = "24", "00", ddStartTime.Text) & ":" & ddStartMin.Text & ":00")
            Maria.AddMySqlParameters("parPlan", swPlan.Value)
            Maria.AddMySqlParameters("parMachName", tbMachName.Text)
            Maria.AddMySqlParameters("parMan", cbDCMan.CheckState)
            Maria.AddMySqlParameters("parMachine", cbDCMachine.CheckState)
            Maria.AddMySqlParameters("parMaterial", cbDCMats.CheckState)
            Maria.AddMySqlParameters("parMethod", cbDCMethod.CheckState)
            Maria.AddMySqlParameters("parSetup", cbDCSetup.CheckState)
            Maria.AddMySqlParameters("parKanban", cbDCWaitingKanban.CheckState)
            Maria.AddMySqlParameters("parOthers", cbDCOther.CheckState)
            Maria.AddMySqlParameters("parAfterSetup", cbAAfterSetup.CheckState)
            Maria.AddMySqlParameters("parAfterPM", cbAAfterPM.CheckState)
            Maria.AddMySqlParameters("parMachine2", cbQAMachine.CheckState)
            Maria.AddMySqlParameters("parMaterial2", cbQAMats.CheckState)
            Maria.AddMySqlParameters("parCause", tbCause.Text)
            Maria.AddMySqlParameters("parME", cbSME.CheckState)
            Maria.AddMySqlParameters("parPDE", cbSPDE.CheckState)
            Maria.AddMySqlParameters("parPME", cbSPME.CheckState)
            Maria.AddMySqlParameters("parOthers2", cbSOthers.CheckState)
            Maria.AddMySqlParameters("parPIC", txtPIC.Text)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            'If globalVariables.DowntimeType = "ASSY" Then
            If DowntimeType = "ASSY" Then
                Maria.AddMySqlParameters("parWeldingNo", 0)
            Else
                Maria.AddMySqlParameters("parWeldingNo", ddWeldingNo.Text)
            End If
            Maria.SPADE("SP_SRCDownTime_InsertDownTimev2")

            MessageBox.Show("Done")
            ReloadGrid()
            Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FrmAssemblyDownTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
    Private Sub ReloadGrid()
        'gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportDownTime where fldDTID=" & globalVariables.AssyDownTimeID & " order by fldStopTime")
        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportDownTime where fldDTID=" & AssyDownTimeID & " order by fldStopTime")
    End Sub

    Private Sub gvData_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles gvData.CommandCellClick
        EditID = 0
        Dim DTEdit As DataTable = Maria.MyQuery("SELECT *, hour(fldStopTime) as StopHour, minute(fldStopTime) as StopMin, hour(fldStartTime) as StartHour, minute(fldStartTime) as StartMin FROM tblDailyReportDownTime where fldID=" & gvData.CurrentRow.Cells("fldID").Value & "")
        EditID = DTEdit.Rows(0).Item("fldID")
        ddShift.Text = DTEdit.Rows(0).Item("fldShift")
        tbProdName.Text = DTEdit.Rows(0).Item("fldProdName")
        ddStopTime.Text = DTEdit.Rows(0).Item("StopHour")
        ddStopMin.Text = DTEdit.Rows(0).Item("StopMin")
        ddStartTime.Text = DTEdit.Rows(0).Item("StartHour")
        ddStartMin.Text = DTEdit.Rows(0).Item("StartMin")
        swPlan.Value = DTEdit.Rows(0).Item("fldPlan")
        tbMachName.Text = DTEdit.Rows(0).Item("fldMachName")
        cbDCMan.Checked = DTEdit.Rows(0).Item("fldMan")
        cbDCMachine.Checked = DTEdit.Rows(0).Item("fldMachine")
        cbDCMachine.Checked = DTEdit.Rows(0).Item("fldMachine")
        cbDCMats.Checked = DTEdit.Rows(0).Item("fldMaterial")
        cbDCMethod.Checked = DTEdit.Rows(0).Item("fldMethod")
        cbDCSetup.Checked = DTEdit.Rows(0).Item("fldSetup")
        cbDCWaitingKanban.Checked = DTEdit.Rows(0).Item("fldKanban")
        cbDCOther.Checked = DTEdit.Rows(0).Item("fldOthers")
        cbAAfterSetup.Checked = DTEdit.Rows(0).Item("fldAfterSetup")
        cbAAfterPM.Checked = DTEdit.Rows(0).Item("fldAfterPM")
        cbQAMachine.Checked = DTEdit.Rows(0).Item("fldMachine2")
        cbQAMats.Checked = DTEdit.Rows(0).Item("fldMaterial2")
        tbCause.Text = DTEdit.Rows(0).Item("fldCause")
        cbSME.Checked = DTEdit.Rows(0).Item("fldME")
        cbSPDE.Checked = DTEdit.Rows(0).Item("fldPDE")
        cbSPME.Checked = DTEdit.Rows(0).Item("fldPME")
        cbSOthers.Checked = DTEdit.Rows(0).Item("fldOthers2")
        txtPIC.Text = DTEdit.Rows(0).Item("fldPIC")
        ddWeldingNo.Text = DTEdit.Rows(0).Item("fldWeldingNo")
        btnCancel.Visible = True
        btnSave.Text = "EDIT"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
    End Sub
    Private Sub Clear()
        EditID = 0

        cbDCMan.Checked = False
        cbDCMachine.Checked = False
        cbDCMachine.Checked = False
        cbDCMats.Checked = False
        cbDCMethod.Checked = False
        cbDCSetup.Checked = False
        cbDCWaitingKanban.Checked = False
        cbDCOther.Checked = False
        cbAAfterSetup.Checked = False
        cbAAfterPM.Checked = False
        cbQAMachine.Checked = False
        cbQAMats.Checked = False
        tbCause.Text = ""
        cbSME.Checked = False
        cbSPDE.Checked = False
        cbSPME.Checked = False
        cbSOthers.Checked = False
        txtPIC.Text = ""
        btnCancel.Visible = False
        btnSave.Text = "SAVE"
    End Sub
    Private Sub gvData_KeyDown(sender As Object, e As KeyEventArgs) Handles gvData.KeyDown
        If e.KeyCode = Keys.Delete Then

            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                Maria.MyQuery("Delete from tblDailyReportDownTime where fldID=" & gvData.CurrentRow.Cells("fldID").Value & "")
                ReloadGrid()
            End If

        End If
    End Sub
    Private Sub LoadDownTimeCause(ByVal category As String)
        Dim dt As New DataTable

        Maria.AddMySqlParameters("parCategory", category)
        Maria.AddMySqlParameters("parPlan", swPlan.Value)

        dt = Maria.SPSelect("SP_SelectDowntimeCause")

        Dim autoSource As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            autoSource.Add(row(0).ToString())
        Next

        tbCause.AutoCompleteCustomSource = Nothing

        tbCause.AutoCompleteCustomSource = autoSource
        tbCause.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tbCause.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    'Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) _
    'Handles cbDCMan.CheckedChanged, cbDCMachine.CheckedChanged, cbDCMats.CheckedChanged, cbDCMethod.CheckedChanged, cbDCSetup.CheckedChanged, cbDCWaitingKanban.CheckedChanged, cbDCOther.CheckedChanged, cbQAMachine.CheckedChanged, cbQAMachine.CheckedChanged

    '    Dim cb As CheckBox = CType(sender, CheckBox)

    '    If cb.Checked AndAlso cb.Text IsNot Nothing Then
    '        Dim category As String = cb.Text.ToString()
    '        LoadDownTimeCause(category)
    '    End If
    'End Sub
    'If Single selection
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles cbDCMan.CheckedChanged, cbDCMachine.CheckedChanged, cbDCMats.CheckedChanged, cbDCMethod.CheckedChanged, cbDCSetup.CheckedChanged, cbDCWaitingKanban.CheckedChanged, cbDCOther.CheckedChanged, cbQAMachine.CheckedChanged, cbQAMachine.CheckedChanged

        Dim cb As CheckBox = CType(sender, CheckBox)

        If cb.Checked AndAlso Not String.IsNullOrEmpty(cb.Tag) Then

            Dim checkboxes As CheckBox() = {
                cbDCMan, cbDCMachine, cbDCMats,
                cbDCMethod, cbDCSetup, cbDCWaitingKanban, cbDCOther, cbQAMachine, cbQAMachine
            }

            Dim selectedCategories As New List(Of String)

            For Each chx As CheckBox In checkboxes
                If chx.Checked Then
                    selectedCategories.Add(chx.Tag.ToString())
                End If
            Next

            Dim categoryStr As String = String.Join(",", selectedCategories)
            LoadDownTimeCause(categoryStr)

        End If

    End Sub
    Private Sub swPlan_ValueChanged(sender As Object, e As EventArgs) Handles swPlan.ValueChanged

        Dim selectedCategory As String = Nothing

        Dim checkboxes As CheckBox() = {
            cbDCMan, cbDCMachine, cbDCMats,
            cbDCMethod, cbDCSetup, cbDCWaitingKanban, cbDCOther, cbQAMachine, cbQAMachine
        }

        For Each cb In checkboxes
            If cb.Checked Then
                selectedCategory = cb.Tag
                Exit For
            End If
        Next

        If Not String.IsNullOrEmpty(selectedCategory) Then
            LoadDownTimeCause(selectedCategory)
        End If

    End Sub

    Private Sub tbCause_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCause.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Oemcomma Then
            e.SuppressKeyPress = True

            Dim currentText As String = tbCause.Text.Trim()

            If currentText <> "" Then
                Dim existing As List(Of String) = tbCause.Text.Split(","c).
                                                   Select(Function(s) s.Trim()).
                                                   Where(Function(s) s <> "").ToList()

                If Not existing.Contains(currentText) Then
                    existing.Add(currentText)
                End If

                tbCause.Text = String.Join(", ", existing)
                tbCause.SelectionStart = tbCause.Text.Length
            End If
        End If
    End Sub

    'Private Sub acCause_ItemSelected(sender As Object, e As KeyEventArgs) Handles acCause.ItemSelected
    '    Dim selectedText As String = e.Text.Trim()

    '    Dim existing As List(Of String) = tbCause.Text.Split(","c).
    '                                       Select(Function(s) s.Trim()).
    '                                       Where(Function(s) s <> "").ToList()

    '    If Not existing.Contains(selectedText) Then
    '        existing.Add(selectedText)
    '    End If

    '    tbCause.Text = String.Join(", ", existing)
    '    tbCause.SelectionStart = tbCause.Text.Length
    'End Sub
End Class
