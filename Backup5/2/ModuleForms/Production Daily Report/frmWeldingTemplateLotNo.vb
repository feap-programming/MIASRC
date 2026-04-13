Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class FrmWeldingTemplateLotNo
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub FrmWeldingTemplateLotNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged
        ReloadModel()
        ReloadGrid()

        AddHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged
        ReloadData()
    End Sub

    Private Sub ReloadData()

        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplateLotNo")

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Maria.AddMySqlParameters("parType", ddType.Text)
        Maria.AddMySqlParameters("parAssyNo", tbAssy.Text)
        Maria.AddMySqlParameters("parModel", ddModel.Text)
        Maria.AddMySqlParameters("parPartName", ddPart.Text)
        Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
        Maria.AddMySqlParameters("parFWGroup", ddFWGroup.Text)
        Maria.SPADE("SP_SRCDailyReport_InsertWeldingLotNoTemplate")
        MessageBox.Show("Saved!")

    End Sub

    Private Sub ReloadModel()

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

    Private Sub ReloadItem()
        Dim DTPartNames As DataTable = Maria.MyQuery("SELECT concat(fldItemCode,' ',fldPartName) as fldItemCode FROM tblItemMasterData where fldCategory='WP' or fldCategory='RM'")

        'Dim DTPart As DataTable = Maria.MyQuery("SELECT concat(IMD.fldItemCode,' ',IMD.fldPartName) as fldPartName FROM tblItemPerModel IPM join tblItemMasterData IMD on IPM.fldItemCode=IMD.fldItemCode  where IPM.fldModel='" & ddModel.SelectedValue & "'")

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

        Dim fldType As New GridViewTextBoxColumn
        fldType.HeaderText = "Type"
        fldType.FieldName = "fldType"
        fldType.TextAlignment = ContentAlignment.MiddleCenter
        fldType.Width = 80
        gvData.Columns.Add(fldType)

        Dim fldAssyNo As New GridViewTextBoxColumn
        fldAssyNo.HeaderText = "Assembly Number"
        fldAssyNo.FieldName = "fldAssyNo"
        fldAssyNo.TextAlignment = ContentAlignment.MiddleCenter
        fldAssyNo.Width = 150
        gvData.Columns.Add(fldAssyNo)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "Model"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.Width = 80
        gvData.Columns.Add(fldModel)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.Width = 400
        gvData.Columns.Add(fldPartName)

    End Sub

    Public Shared Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function

    Private Sub ddModel_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddModel.SelectedIndexChanged
        ReloadItem()
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadData()
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Maria.MyQuery("Delete from tblDailyReportWeldingTemplateLotNo where fldID=" & gvData.CurrentRow.Cells(0).Value & "")
            MessageBox.Show("Item Deleted")
            ReloadData()
        End If

    End Sub
End Class
