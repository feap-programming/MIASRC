Imports DocumentFormat.OpenXml.Spreadsheet
Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class FrmReworkingData
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim Catherine As New DB("192.168.191.252", "dbHRMSlive", "feap", "45|iF$")
    Dim ProdEmp As DataTable = Catherine.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Private Sub FrmReworkingData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadCol()
        ReloadGrid()
        ReloadEmp()
        ReloadDefectsGrid()
        'TestOwO()
    End Sub

    Private Sub ReloadEmp()
        ddOpName.DataSource = ProdEmp
        ddOpName.DisplayMember = "fldEmpName"
        ddOpName.ValueMember = "fldEmpName"
        ddOpName.AutoCompleteDataSource = ProdEmp
        ddOpName.AutoCompleteMode = AutoCompleteMode.Suggest
        ddOpName.AutoCompleteDisplayMember = "fldEmpName"
        ddOpName.AutoCompleteValueMember = "fldEmpName"
        ddOpName.Text = ""
    End Sub

    Private Sub ReloadCol()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 20
        fldID.IsVisible = False
        gvManpower.Columns.Add(fldID)

        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time Partition"
        fldTime.FieldName = "fldTime"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.Width = 200
        gvManpower.Columns.Add(fldTime)

        Dim fldTimeFrom As New GridViewTextBoxColumn
        fldTimeFrom.HeaderText = "From"
        fldTimeFrom.FieldName = "fldTimeFrom"
        fldTimeFrom.TextAlignment = ContentAlignment.MiddleCenter
        fldTimeFrom.Width = 300
        fldTimeFrom.IsVisible = False
        gvManpower.Columns.Add(fldTimeFrom)

        Dim fldTimeTo As New GridViewTextBoxColumn
        fldTimeTo.HeaderText = "To"
        fldTimeTo.FieldName = "fldTimeTo"
        fldTimeTo.TextAlignment = ContentAlignment.MiddleCenter
        fldTimeTo.Width = 300
        fldTimeTo.IsVisible = False
        gvManpower.Columns.Add(fldTimeTo)

        Dim fldEmpName As New GridViewTextBoxColumn
        fldEmpName.HeaderText = "Operator Name"
        fldEmpName.FieldName = "fldEmpName"
        fldEmpName.TextAlignment = ContentAlignment.MiddleCenter
        fldEmpName.Width = 300
        gvManpower.Columns.Add(fldEmpName)

        Dim fldStatus As New GridViewTextBoxColumn
        fldStatus.HeaderText = "Status"
        fldStatus.FieldName = "fldStatus"
        fldStatus.TextAlignment = ContentAlignment.MiddleCenter
        fldStatus.Width = 100
        gvManpower.Columns.Add(fldStatus)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Dim TextStats As String = ""
            If rbQualified.IsChecked Then

                TextStats = "Qualified"

            ElseIf rbTrain.IsChecked Then

                TextStats = "Trainee"

            ElseIf rbTrans.IsChecked Then

                TextStats = "Transfer"

            End If

            Maria.AddMySqlParameters("parID", globalVariables.ReworkID)
            Maria.AddMySqlParameters("parTimeFrom", tpFrom.Value)
            Maria.AddMySqlParameters("parTimeTo", tpTo.Value)
            Maria.AddMySqlParameters("parEmpName", ddOpName.Text)
            Maria.AddMySqlParameters("parStatus", TextStats)
            Maria.SPADE("SP_SRCDailyReport_InsertReworkManpower")
            ReloadGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ReloadGrid()
        gvManpower.DataSource = Maria.MyQuery("SELECT *,concat(fldTimeFrom,'-',fldTimeTo) as fldTime FROM dbMIA.tblDailyReportReworkManpower where fldDRID=" & globalVariables.ReworkID & "")
    End Sub

    Private Sub gvManpower_KeyDown(sender As Object, e As KeyEventArgs) Handles gvManpower.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else

                Try
                    Maria.MyQuery("Delete From tblDailyReportReworkManpower where fldID=" & gvManpower.CurrentRow.Cells("fldID").Value & "")
                    MessageBox.Show("Deleted")
                    ReloadGrid()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub ReloadDefectsGrid()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 20
        fldID.IsVisible = False
        gvDefects.Columns.Add(fldID)

        Dim fldOldLot As New GridViewTextBoxColumn
        fldOldLot.HeaderText = "Lot No"
        fldOldLot.FieldName = "fldOldLot"
        fldOldLot.TextAlignment = ContentAlignment.MiddleCenter
        fldOldLot.Width = 200
        gvDefects.Columns.Add(fldOldLot)

        Dim fldOldBox As New GridViewTextBoxColumn
        fldOldBox.HeaderText = "Box No."
        fldOldBox.FieldName = "fldOldBox"
        fldOldBox.TextAlignment = ContentAlignment.MiddleCenter
        fldOldBox.Width = 200
        gvDefects.Columns.Add(fldOldBox)

        Dim fldOldQty As New GridViewTextBoxColumn
        fldOldQty.HeaderText = "Box Qty."
        fldOldQty.FieldName = "fldOldQty"
        fldOldQty.TextAlignment = ContentAlignment.MiddleCenter
        fldOldQty.Width = 200
        gvDefects.Columns.Add(fldOldQty)

        Dim fldNewLot As New GridViewTextBoxColumn
        fldNewLot.HeaderText = "Lot No."
        fldNewLot.FieldName = "fldNewLot"
        fldNewLot.TextAlignment = ContentAlignment.MiddleCenter
        fldNewLot.Width = 200
        gvDefects.Columns.Add(fldNewLot)

        Dim fldNewBox As New GridViewTextBoxColumn
        fldNewBox.HeaderText = "Box No."
        fldNewBox.FieldName = "fldNewBox"
        fldNewBox.TextAlignment = ContentAlignment.MiddleCenter
        fldNewBox.Width = 200
        gvDefects.Columns.Add(fldNewBox)

        Dim fldNewQty As New GridViewTextBoxColumn
        fldNewQty.HeaderText = "Box Qty."
        fldNewQty.FieldName = "fldNewQty"
        fldNewQty.TextAlignment = ContentAlignment.MiddleCenter
        fldNewQty.Width = 200
        gvDefects.Columns.Add(fldNewQty)

        Dim fldDefItem As New GridViewTextBoxColumn
        fldDefItem.HeaderText = "Item"
        fldDefItem.FieldName = "fldDefItem"
        fldDefItem.TextAlignment = ContentAlignment.MiddleCenter
        fldDefItem.Width = 200
        gvDefects.Columns.Add(fldDefItem)

        Dim fldDefQty As New GridViewTextBoxColumn
        fldDefQty.HeaderText = "Qty."
        fldDefQty.FieldName = "fldDefQty"
        fldDefQty.TextAlignment = ContentAlignment.MiddleCenter
        fldDefQty.Width = 200
        gvDefects.Columns.Add(fldDefQty)

        Dim fldDefBar As New GridViewTextBoxColumn
        fldDefBar.HeaderText = "Barcode"
        fldDefBar.FieldName = "fldDefBar"
        fldDefBar.TextAlignment = ContentAlignment.MiddleCenter
        fldDefBar.Width = 200
        gvDefects.Columns.Add(fldDefBar)

        Dim view As New ColumnGroupsViewDefinition()
        view.ColumnGroups.Add(New GridViewColumnGroup(""))
        view.ColumnGroups.Add(New GridViewColumnGroup("OLD"))
        view.ColumnGroups.Add(New GridViewColumnGroup("NEW"))
        view.ColumnGroups.Add(New GridViewColumnGroup("DEFECTS"))

        view.ColumnGroups(0).Rows.Add(New GridViewColumnGroupRow())
        view.ColumnGroups(0).Rows(0).ColumnNames.Add("fldID")

        view.ColumnGroups(1).Rows.Add(New GridViewColumnGroupRow())
        view.ColumnGroups(1).Rows(0).ColumnNames.Add("fldOldLot")
        view.ColumnGroups(1).Rows(0).ColumnNames.Add("fldOldBox")
        view.ColumnGroups(1).Rows(0).ColumnNames.Add("fldOldQty")

        view.ColumnGroups(2).Rows.Add(New GridViewColumnGroupRow())
        view.ColumnGroups(2).Rows(0).ColumnNames.Add("fldNewLot")
        view.ColumnGroups(2).Rows(0).ColumnNames.Add("fldNewBox")
        view.ColumnGroups(2).Rows(0).ColumnNames.Add("fldNewQty")

        view.ColumnGroups(3).Rows.Add(New GridViewColumnGroupRow())
        view.ColumnGroups(3).Rows(0).ColumnNames.Add("fldDefItem")
        view.ColumnGroups(3).Rows(0).ColumnNames.Add("fldDefQty")
        view.ColumnGroups(3).Rows(0).ColumnNames.Add("fldDefBar")
        gvDefects.ViewDefinition = view




    End Sub
    Private Sub TestOwO()

    End Sub
End Class
