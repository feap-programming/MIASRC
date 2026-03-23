Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmWeldingTemplates
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim Kurumi As New DB("192.168.191.252", "dbHRMSlive", "feap", "45|iF$")

    Dim Emp As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmp As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmp2 As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmp3 As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmpD As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmpN As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")

    Dim ProdEmpGV As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmp2GV As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmp3GV As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmpDGV As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim ProdEmpNGV As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Private Sub FrmWeldingTemplates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)
        ReloadGrid()
        GetModels()
        GetModelsMP()
        GetPartNames()
        ReloadData()
        GridColMP()

    End Sub
    Private Sub GetModels()

        Dim DTModel As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")

        ddModel.DataSource = DTModel
        ddModel.DisplayMember = "fldModelName"
        ddModel.ValueMember = "fldModelName"
        ddModel.AutoCompleteDataSource = DTModel
        ddModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModel.AutoCompleteDisplayMember = "fldModelName"
        ddModel.AutoCompleteValueMember = "fldModelName"
        ddModel.Text = ""

    End Sub
    Private Sub GetModelsMP()

        Dim DTModelMP As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")

        ddModelMP.DataSource = DTModelMP
        ddModelMP.DisplayMember = "fldModelName"
        ddModelMP.ValueMember = "fldModelName"
        ddModelMP.AutoCompleteDataSource = DTModelMP
        ddModelMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModelMP.AutoCompleteDisplayMember = "fldModelName"
        ddModelMP.AutoCompleteValueMember = "fldModelName"
        ddModelMP.Text = ""

        dd1stMP.DataSource = ProdEmp
        dd1stMP.DisplayMember = "fldEmpName"
        dd1stMP.ValueMember = "fldEmpName"
        dd1stMP.AutoCompleteDataSource = ProdEmp
        dd1stMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dd1stMP.AutoCompleteDisplayMember = "fldEmpName"
        dd1stMP.AutoCompleteValueMember = "fldEmpName"
        dd1stMP.Text = ""

        dd2ndMP.DataSource = ProdEmp2
        dd2ndMP.DisplayMember = "fldEmpName"
        dd2ndMP.ValueMember = "fldEmpName"
        dd2ndMP.AutoCompleteDataSource = ProdEmp2
        dd2ndMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dd2ndMP.AutoCompleteDisplayMember = "fldEmpName"
        dd2ndMP.AutoCompleteValueMember = "fldEmpName"
        dd2ndMP.Text = ""

        dd3rdMP.DataSource = ProdEmp3
        dd3rdMP.DisplayMember = "fldEmpName"
        dd3rdMP.ValueMember = "fldEmpName"
        dd3rdMP.AutoCompleteDataSource = ProdEmp3
        dd3rdMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        dd3rdMP.AutoCompleteDisplayMember = "fldEmpName"
        dd3rdMP.AutoCompleteValueMember = "fldEmpName"
        dd3rdMP.Text = ""

        ddDayMP.DataSource = ProdEmpD
        ddDayMP.DisplayMember = "fldEmpName"
        ddDayMP.ValueMember = "fldEmpName"
        ddDayMP.AutoCompleteDataSource = ProdEmpD
        ddDayMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddDayMP.AutoCompleteDisplayMember = "fldEmpName"
        ddDayMP.AutoCompleteValueMember = "fldEmpName"
        ddDayMP.Text = ""

        ddNightMP.DataSource = ProdEmpN
        ddNightMP.DisplayMember = "fldEmpName"
        ddNightMP.ValueMember = "fldEmpName"
        ddNightMP.AutoCompleteDataSource = ProdEmpN
        ddNightMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddNightMP.AutoCompleteDisplayMember = "fldEmpName"
        ddNightMP.AutoCompleteValueMember = "fldEmpName"
        ddNightMP.Text = ""

    End Sub

    Private Sub GetPartNames()

        Dim DTPartNames As DataTable = Maria.MyQuery("SELECT concat(fldItemCode,' ',fldPartName) as fldItemCode FROM tblItemMasterData where fldCategory='WP'")

        ddPart.DataSource = DTPartNames
        ddPart.DisplayMember = "fldItemCode"
        ddPart.ValueMember = "fldItemCode"
        ddPart.AutoCompleteDataSource = DTPartNames
        ddPart.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddPart.AutoCompleteDisplayMember = "fldItemCode"
        ddPart.AutoCompleteValueMember = "fldItemCode"
        ddPart.Text = ""

    End Sub
    Private Sub ReloadGrid()

        gvData.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 20
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "Model"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.Width = 80
        gvData.Columns.Add(fldModel)

        Dim fldType As New GridViewTextBoxColumn
        fldType.HeaderText = "Type"
        fldType.FieldName = "fldType"
        fldType.TextAlignment = ContentAlignment.MiddleCenter
        fldType.Width = 50
        gvData.Columns.Add(fldType)

        Dim fldPWFWNo As New GridViewTextBoxColumn
        fldPWFWNo.HeaderText = "Welding No."
        fldPWFWNo.FieldName = "fldPWFWNo"
        fldPWFWNo.TextAlignment = ContentAlignment.MiddleCenter
        fldPWFWNo.Width = 80
        gvData.Columns.Add(fldPWFWNo)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.Width = 100
        gvData.Columns.Add(fldPartName)

        Dim fldAddedBy As New GridViewTextBoxColumn
        fldAddedBy.HeaderText = "Added By"
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedBy.Width = 80
        gvData.Columns.Add(fldAddedBy)

        Dim fldAddedDate As New GridViewTextBoxColumn
        fldAddedDate.HeaderText = "Date Added"
        fldAddedDate.FieldName = "fldAddedDate"
        fldAddedDate.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedDate.Width = 80
        gvData.Columns.Add(fldAddedDate)
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        Try
            Maria.AddMySqlParameters("parType", ddType.Text)
            Maria.AddMySqlParameters("parAssyNo", tbNo.Text)
            Maria.AddMySqlParameters("parModel", ddModel.Text)
            Maria.AddMySqlParameters("parPartName", ddPart.Text)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.AddMySqlParameters("parGroup", ddGroup.Text)
            Maria.SPADE("SP_SRCDailyReport_InsertWeldingTemplate")
            MessageBox.Show("Successfuly Added!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ReloadData()

        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate order by fldID desc")

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadData()
    End Sub

    Private Sub cbbAddMP_Click(sender As Object, e As EventArgs) Handles cbbAddMP.Click

        Maria.AddMySqlParameters("parModel", ddModelMP.Text)
        Maria.AddMySqlParameters("parType", ddTypeMP.Text)
        Maria.AddMySqlParameters("parWeldNo", ddWeldNoMP.Text)
        Maria.AddMySqlParameters("parDate", dpDateMP.Value)
        Maria.AddMySqlParameters("parProc", tbProcNameMP.Text)
        Maria.AddMySqlParameters("parEmp1st", dd1stMP.Text)
        Maria.AddMySqlParameters("parEmp2nd", dd2ndMP.Text)
        Maria.AddMySqlParameters("parEmp3rd", dd3rdMP.Text)
        Maria.AddMySqlParameters("parEmpDay", ddDayMP.Text)
        Maria.AddMySqlParameters("parEmpNight", ddNightMP.Text)
        Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))
        Maria.AddMySqlParameters("parGroup", ddGroupMP.Text)
        Maria.SPADE("SP_SRCDailyReport_InsertWeldingManpowerTemp")
        CheckFields()
    End Sub

    Private Sub GetMPData(parModel As String, parType As String, parNo As String)

        gvManpower.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingManpowerTemp where fldModel='" & parModel & "' and fldType='" & parType & "' and fldWeldNo='" & parNo & "'")

    End Sub

    Private Sub GridColMP()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 20
        fldID.IsVisible = False
        gvManpower.Columns.Add(fldID)

        Dim fldDate As New GridViewTextBoxColumn
        fldDate.HeaderText = "Date"
        fldDate.FieldName = "fldDate"
        fldDate.TextAlignment = ContentAlignment.MiddleCenter
        fldDate.FormatString = "{0:MM/dd/yyy}"
        fldDate.Width = 120
        fldDate.IsVisible = False
        gvManpower.Columns.Add(fldDate)

        Dim fldProcessName As New GridViewTextBoxColumn
        fldProcessName.HeaderText = "Process Name"
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.TextAlignment = ContentAlignment.MiddleCenter
        fldProcessName.Width = 300
        gvManpower.Columns.Add(fldProcessName)

        Dim fldEmployee As New GridViewComboBoxColumn
        fldEmployee.FieldName = "fldEmployee"
        fldEmployee.HeaderText = "1st Shift"
        fldEmployee.DataSource = Me.ProdEmpGV
        fldEmployee.ValueMember = "fldEmpName"
        fldEmployee.DisplayMember = "fldEmpName"
        fldEmployee.Width = 250
        Me.gvManpower.Columns.Add(fldEmployee)

        Dim fldEmployee2 As New GridViewComboBoxColumn
        fldEmployee2.FieldName = "fldEmployee2"
        fldEmployee2.HeaderText = "2nd Shift"
        fldEmployee2.DataSource = Me.ProdEmp2GV
        fldEmployee2.ValueMember = "fldEmpName"
        fldEmployee2.DisplayMember = "fldEmpName"
        fldEmployee2.Width = 250
        Me.gvManpower.Columns.Add(fldEmployee2)

        Dim fldEmployee3 As New GridViewComboBoxColumn
        fldEmployee3.FieldName = "fldEmployee3"
        fldEmployee3.HeaderText = "3rd Shift"
        fldEmployee3.DataSource = Me.ProdEmp3GV
        fldEmployee3.ValueMember = "fldEmpName"
        fldEmployee3.DisplayMember = "fldEmpName"
        fldEmployee3.Width = 250
        Me.gvManpower.Columns.Add(fldEmployee3)

        Dim fldEmployeeDay As New GridViewComboBoxColumn
        fldEmployeeDay.FieldName = "fldEmployeeDay"
        fldEmployeeDay.HeaderText = "Day Shift"
        fldEmployeeDay.DataSource = Me.ProdEmpDGV
        fldEmployeeDay.ValueMember = "fldEmpName"
        fldEmployeeDay.DisplayMember = "fldEmpName"
        fldEmployeeDay.Width = 250
        Me.gvManpower.Columns.Add(fldEmployeeDay)

        Dim fldEmployeeNight As New GridViewComboBoxColumn
        fldEmployeeNight.FieldName = "fldEmployeeNight"
        fldEmployeeNight.HeaderText = "Night Shift"
        fldEmployeeNight.DataSource = Me.ProdEmpNGV
        fldEmployeeNight.ValueMember = "fldEmpName"
        fldEmployeeNight.DisplayMember = "fldEmpName"
        fldEmployeeNight.Width = 250
        Me.gvManpower.Columns.Add(fldEmployeeNight)

        Dim fldAddedDate As New GridViewTextBoxColumn
        fldAddedDate.HeaderText = "Date Added"
        fldAddedDate.FieldName = "fldAddedDate"
        fldAddedDate.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedDate.Width = 80
        gvManpower.Columns.Add(fldAddedDate)

        Dim fldAddedBy As New GridViewTextBoxColumn
        fldAddedBy.HeaderText = "Added By"
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedBy.Width = 120
        gvManpower.Columns.Add(fldAddedBy)

    End Sub

    Private Sub ddModelMP_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddModelMP.SelectedIndexChanged
        CheckFields()
    End Sub

    Private Sub ddTypeMP_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddTypeMP.SelectedIndexChanged

        Dim getWeldNo As DataTable = Maria.MyQuery("Select distinct fldWeldNo FROM dbMIA.tblDailyReportWeldingManpowerTemp where fldModel='" & ddModelMP.Text & "' and fldType='" & ddTypeMP.Text & "'")

        ddWeldNoMP.DataSource = getWeldNo
        ddWeldNoMP.DisplayMember = "fldWeldNo"
        ddWeldNoMP.ValueMember = "fldWeldNo"
        ddWeldNoMP.AutoCompleteDataSource = getWeldNo
        ddWeldNoMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddWeldNoMP.AutoCompleteDisplayMember = "fldWeldNo"
        ddWeldNoMP.AutoCompleteValueMember = "fldWeldNo"
        CheckFields()
    End Sub

    Private Sub ddWeldNoMP_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddWeldNoMP.SelectedIndexChanged
        CheckFields()
    End Sub
    Private Sub CheckFields()
        If ddModelMP.Text = "" Or ddTypeMP.Text = "" Or ddWeldNoMP.Text = "" Then

        Else
            GetMPData(ddModelMP.Text, ddTypeMP.Text, ddWeldNoMP.Text)
        End If
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

    End Sub

    Private Sub ddType_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddType.SelectedIndexChanged

    End Sub
End Class
