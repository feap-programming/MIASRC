Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmATMaster
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
    Private Sub FrmATMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        dpDate.Value = DateTime.Now
        GridCol()
        GridColLot()
        GetModels()
        ReloadGrid()
        ReloadGrid()
    End Sub

    Private Sub GetModels()

        Dim DTModel As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")

        ddModel.DataSource = DTModel
        ddModel.DisplayMember = "fldModelName"
        ddModel.ValueMember = "fldCode"
        ddModel.AutoCompleteDataSource = DTModel
        ddModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModel.AutoCompleteDisplayMember = "fldModelName"
        ddModel.AutoCompleteValueMember = "fldCode"
        ddModel.Text = ""

        ddModelLot.DataSource = DTModel
        ddModelLot.DisplayMember = "fldModelName"
        ddModelLot.ValueMember = "fldCode"
        ddModelLot.AutoCompleteDataSource = DTModel
        ddModelLot.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModelLot.AutoCompleteDisplayMember = "fldModelName"
        ddModelLot.AutoCompleteValueMember = "fldCode"
        ddModelLot.Text = ""

        ddEmp.DataSource = ProdEmp
        ddEmp.DisplayMember = "fldEmpName"
        ddEmp.ValueMember = "fldEmpName"
        ddEmp.AutoCompleteDataSource = ProdEmp
        ddEmp.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddEmp.AutoCompleteDisplayMember = "fldEmpName"
        ddEmp.AutoCompleteValueMember = "fldEmpName"
        ddEmp.Text = ""

        ddEmp2.DataSource = ProdEmp2
        ddEmp2.DisplayMember = "fldEmpName"
        ddEmp2.ValueMember = "fldEmpName"
        ddEmp2.AutoCompleteDataSource = ProdEmp2
        ddEmp2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddEmp2.AutoCompleteDisplayMember = "fldEmpName"
        ddEmp2.AutoCompleteValueMember = "fldEmpName"
        ddEmp2.Text = ""

        ddEmp3.DataSource = ProdEmp3
        ddEmp3.DisplayMember = "fldEmpName"
        ddEmp3.ValueMember = "fldEmpName"
        ddEmp3.AutoCompleteDataSource = ProdEmp3
        ddEmp3.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddEmp3.AutoCompleteDisplayMember = "fldEmpName"
        ddEmp3.AutoCompleteValueMember = "fldEmpName"
        ddEmp3.Text = ""

        ddEmpD.DataSource = ProdEmpD
        ddEmpD.DisplayMember = "fldEmpName"
        ddEmpD.ValueMember = "fldEmpName"
        ddEmpD.AutoCompleteDataSource = ProdEmpD
        ddEmpD.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddEmpD.AutoCompleteDisplayMember = "fldEmpName"
        ddEmpD.AutoCompleteValueMember = "fldEmpName"
        ddEmpD.Text = ""

        ddEmpN.DataSource = ProdEmpN
        ddEmpN.DisplayMember = "fldEmpName"
        ddEmpN.ValueMember = "fldEmpName"
        ddEmpN.AutoCompleteDataSource = ProdEmpN
        ddEmpN.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddEmpN.AutoCompleteDisplayMember = "fldEmpName"
        ddEmpN.AutoCompleteValueMember = "fldEmpName"
        ddEmpN.Text = ""

        Dim DTPartNames As DataTable = Maria.MyQuery("SELECT CONCAT(fldItemCode,' ',fldPartName) as fldPartName FROM tblItemMasterData")

        ddItemCode.DataSource = DTPartNames
        ddItemCode.DisplayMember = "fldPartName"
        ddItemCode.ValueMember = "fldPartName"
        ddItemCode.AutoCompleteDataSource = DTPartNames
        ddItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddItemCode.AutoCompleteDisplayMember = "fldPartName"
        ddItemCode.AutoCompleteValueMember = "fldPartName"
    End Sub

    Private Sub GridCol()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 20
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldDate As New GridViewTextBoxColumn
        fldDate.HeaderText = "Date"
        fldDate.FieldName = "fldDate"
        fldDate.TextAlignment = ContentAlignment.MiddleCenter
        fldDate.FormatString = "{0:MM/dd/yyy}"
        fldDate.Width = 120
        fldDate.IsVisible = False
        gvData.Columns.Add(fldDate)

        Dim fldProcessName As New GridViewTextBoxColumn
        fldProcessName.HeaderText = "Process Name"
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.TextAlignment = ContentAlignment.MiddleCenter
        fldProcessName.Width = 300
        gvData.Columns.Add(fldProcessName)

        Dim fldEmployee As New GridViewComboBoxColumn
        fldEmployee.FieldName = "fldEmployee"
        fldEmployee.HeaderText = "1st Shift"
        fldEmployee.DataSource = Me.ProdEmpGV
        fldEmployee.ValueMember = "fldEmpName"
        fldEmployee.DisplayMember = "fldEmpName"
        fldEmployee.Width = 250
        Me.gvData.Columns.Add(fldEmployee)

        Dim fldEmployee2 As New GridViewComboBoxColumn
        fldEmployee2.FieldName = "fldEmployee2"
        fldEmployee2.HeaderText = "2nd Shift"
        fldEmployee2.DataSource = Me.ProdEmp2GV
        fldEmployee2.ValueMember = "fldEmpName"
        fldEmployee2.DisplayMember = "fldEmpName"
        fldEmployee2.Width = 250
        Me.gvData.Columns.Add(fldEmployee2)

        Dim fldEmployee3 As New GridViewComboBoxColumn
        fldEmployee3.FieldName = "fldEmployee3"
        fldEmployee3.HeaderText = "3rd Shift"
        fldEmployee3.DataSource = Me.ProdEmp3GV
        fldEmployee3.ValueMember = "fldEmpName"
        fldEmployee3.DisplayMember = "fldEmpName"
        fldEmployee3.Width = 250
        Me.gvData.Columns.Add(fldEmployee3)

        Dim fldEmployeeDay As New GridViewComboBoxColumn
        fldEmployeeDay.FieldName = "fldEmployeeDay"
        fldEmployeeDay.HeaderText = "Day Shift"
        fldEmployeeDay.DataSource = Me.ProdEmpDGV
        fldEmployeeDay.ValueMember = "fldEmpName"
        fldEmployeeDay.DisplayMember = "fldEmpName"
        fldEmployeeDay.Width = 250
        Me.gvData.Columns.Add(fldEmployeeDay)

        Dim fldEmployeeNight As New GridViewComboBoxColumn
        fldEmployeeNight.FieldName = "fldEmployeeNight"
        fldEmployeeNight.HeaderText = "Night Shift"
        fldEmployeeNight.DataSource = Me.ProdEmpNGV
        fldEmployeeNight.ValueMember = "fldEmpName"
        fldEmployeeNight.DisplayMember = "fldEmpName"
        fldEmployeeNight.Width = 250
        Me.gvData.Columns.Add(fldEmployeeNight)

        Dim fldAddedDate As New GridViewTextBoxColumn
        fldAddedDate.HeaderText = "Date Added"
        fldAddedDate.FieldName = "fldAddedDate"
        fldAddedDate.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedDate.Width = 80
        gvData.Columns.Add(fldAddedDate)

        Dim fldAddedBy As New GridViewTextBoxColumn
        fldAddedBy.HeaderText = "Added By"
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedBy.Width = 120
        gvData.Columns.Add(fldAddedBy)

    End Sub

    Private Sub GridColLot()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 20
        fldID.IsVisible = False
        gvDataLot.Columns.Add(fldID)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "Model"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.Width = 80
        fldModel.ReadOnly = True
        gvDataLot.Columns.Add(fldModel)

        Dim fldGroup As New GridViewTextBoxColumn
        fldGroup.HeaderText = "Group"
        fldGroup.FieldName = "fldLotGroup"
        fldGroup.TextAlignment = ContentAlignment.MiddleCenter
        fldGroup.Width = 250
        gvDataLot.Columns.Add(fldGroup)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldLotNo"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.Width = 250
        gvDataLot.Columns.Add(fldPartName)

        Dim fldAddedDate As New GridViewTextBoxColumn
        fldAddedDate.HeaderText = "Date Added"
        fldAddedDate.FieldName = "fldDateAdded"
        fldAddedDate.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedDate.Width = 80
        fldAddedDate.ReadOnly = True
        gvDataLot.Columns.Add(fldAddedDate)

        Dim fldAddedBy As New GridViewTextBoxColumn
        fldAddedBy.HeaderText = "Added By"
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedBy.Width = 80
        fldAddedBy.ReadOnly = True
        gvDataLot.Columns.Add(fldAddedBy)

    End Sub

    Private Sub ReloadGrid()
        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportATManpowerTemp where fldModel='" & ddModel.Text & "' and fldLine=" & spnLine.Value & "")
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Maria.AddMySqlParameters("parCode", ddModel.Text)
        Maria.AddMySqlParameters("parDate", DateTime.Now)
        Maria.AddMySqlParameters("parProcName", tbProcName.Text)
        Maria.AddMySqlParameters("parEmpName", ddEmp.Text)
        Maria.AddMySqlParameters("parEmpName2", ddEmp2.Text)
        Maria.AddMySqlParameters("parEmpName3", ddEmp3.Text)
        Maria.AddMySqlParameters("parEmpNameD", ddEmpD.Text)
        Maria.AddMySqlParameters("parEmpNameN", ddEmpN.Text)
        Maria.AddMySqlParameters("parLine", spnLine.Value)
        Maria.AddMySqlParameters("parMach", spnMach.Value)
        Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))

        Maria.SPADE("SP_SRC_InsertATManpowerTemplate")
        RadMessageBox.Show("Process name added")
        ReloadGrid()

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadGrid()
    End Sub

    Private Sub cbbAddLot_Click(sender As Object, e As EventArgs) Handles cbbAddLot.Click
        Try
            Maria.AddMySqlParameters("parModel", ddModelLot.Text)
            Maria.AddMySqlParameters("parLine", spnLineLot.Value)
            Maria.AddMySqlParameters("parLotGroup", tbGroup.Text)
            Maria.AddMySqlParameters("parLotNo", ddItemCode.Text)
            Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Maria.SPADE("SP_SRC_InsertATLotNoTemplate")
            RadMessageBox.Show("Saved")
        Catch ex As Exception

            RadMessageBox.Show(ex.Message)
        End Try
        ReloadGridLot()
    End Sub

    Private Sub cbbRefreshLot_Click(sender As Object, e As EventArgs) Handles cbbRefreshLot.Click
        ReloadGridLot()
    End Sub

    Private Sub ReloadGridLot()
        gvDataLot.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportATLotTemp where fldModel='" & ddModelLot.Text & "' and fldLine=" & spnLineLot.Value & "")
    End Sub

End Class
