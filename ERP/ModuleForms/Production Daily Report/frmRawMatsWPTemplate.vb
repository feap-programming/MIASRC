Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmRawMatsWPTemplate
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub FrmRawMatsWPTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        ReloadGrid()
        GetModels()
        GetPartNames()
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
    Private Sub GetPartNames()

        Dim DTPartNames As DataTable = Maria.MyQuery("SELECT CONCAT(fldItemCode,' ',fldPartName) as fldPartName FROM tblItemMasterData")

        ddItemCode.DataSource = DTPartNames
        ddItemCode.DisplayMember = "fldPartName"
        ddItemCode.ValueMember = "fldPartName"
        ddItemCode.AutoCompleteDataSource = DTPartNames
        ddItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddItemCode.AutoCompleteDisplayMember = "fldPartName"
        ddItemCode.AutoCompleteValueMember = "fldPartName"

    End Sub
    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Maria.AddMySqlParameters("parModel", ddModel.Text)
        Maria.AddMySqlParameters("parPartName", ddItemCode.Text)
        Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
        Maria.SPADE("SP_SRCDailyReport_InsertRMWIPTemplate")
        ReloadData()

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadData()
    End Sub

    Private Sub ReloadData()
        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportSRCRawMatsTemplate where fldModel='" & ddModel.Text & "'")
    End Sub

    Private Sub ReloadGrid()

        gvData.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 20
        fldID.IsVisible = False
        fldID.ReadOnly = True
        gvData.Columns.Add(fldID)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "Model"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.Width = 80
        fldModel.ReadOnly = True
        gvData.Columns.Add(fldModel)

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
        fldAddedDate.ReadOnly = True
        gvData.Columns.Add(fldAddedDate)

        Dim fldAddedBy As New GridViewTextBoxColumn
        fldAddedBy.HeaderText = "Added By"
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.TextAlignment = ContentAlignment.MiddleCenter
        fldAddedBy.Width = 80
        fldAddedBy.ReadOnly = True
        gvData.Columns.Add(fldAddedBy)

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        Try
            Maria.MyQuery("Delete From tblDailyReportSRCRawMatsTemplate where fldID=" & gvData.CurrentRow.Cells("fldID").Value & "")
            MessageBox.Show(gvData.CurrentRow.Cells("fldPartName").Value.ToString & " deleted!")
            ReloadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub gvData_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellEndEdit
        'If Maria.MyQuery("") Then
        '    gvData.CurrentRow.Cells("fldID").Value
        'End If

        Try
            Maria.MyQuery("Update tblDailyReportSRCRawMatsTemplate set fldPartName='" & gvData.CurrentRow.Cells("fldPartName").Value.ToString & "' where fldID=" & gvData.CurrentRow.Cells("fldID").Value & "")
            MessageBox.Show("Updated to " & gvData.CurrentRow.Cells("fldPartName").Value.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
