Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmSRCAssyTemplate
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub FrmSRCAssyTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        dpDate.Value = DateTime.Now
        GridCol()
        GetModels()
        RemoveHandler ddRMList.SelectedIndexChanged, AddressOf ddRMList_SelectedIndexChanged
        GetRM()
        AddHandler ddRMList.SelectedIndexChanged, AddressOf ddRMList_SelectedIndexChanged
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

    End Sub
    Private Sub GetRM()

        Dim DTModel As DataTable = Maria.MyQuery("SELECT fldItemCode,fldPartName FROM tblItemMasterData where fldCategory='RM'")

        ddRMList.DataSource = DTModel
        ddRMList.DisplayMember = "fldItemCode"
        ddRMList.ValueMember = "fldPartName"
        ddRMList.AutoCompleteDataSource = DTModel
        ddRMList.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddRMList.AutoCompleteDisplayMember = "fldItemCode"
        ddRMList.AutoCompleteValueMember = "fldPartName"

    End Sub
    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        Maria.AddMySqlParameters("parCode", ddModel.SelectedValue)
        Maria.AddMySqlParameters("parDate", dpDate.Value)
        Maria.AddMySqlParameters("parPartNo", ddRMList.Text)
        Maria.AddMySqlParameters("parPartName", tbPartName.Text)
        Maria.AddMySqlParameters("parUser", globalVariables.currentUser(1))

        Maria.SPADE("SP_SRC_InsertSRCAssyTemplate")
        RadMessageBox.Show("Process name added")
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
        fldDate.Width = 80
        gvData.Columns.Add(fldDate)

        Dim fldPartNo As New GridViewTextBoxColumn
        fldPartNo.HeaderText = "Part No."
        fldPartNo.FieldName = "fldPartNo"
        fldPartNo.TextAlignment = ContentAlignment.MiddleCenter
        fldPartNo.Width = 150
        gvData.Columns.Add(fldPartNo)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.Width = 150
        gvData.Columns.Add(fldPartName)

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
        fldAddedBy.Width = 80
        gvData.Columns.Add(fldAddedBy)

    End Sub

    Private Sub ddRMList_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddRMList.SelectedIndexChanged
        Try
            tbPartName.Text = ddRMList.SelectedValue.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportSRCAssyTemplate where fldModel='" & ddModel.SelectedValue & "'")
    End Sub
End Class
