Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmBudgetAmount
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim BudgetID As Integer = 0
    Private Sub FrmBudgetAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadCustomer()
        readyGrid()
        ReloadData()
    End Sub
    Private Sub readyGrid()

        gvData.Columns.Clear()

        Dim fldID As New GridViewTextBoxColumn("ID")
        fldID.FieldName = "fldID"
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldCustomer As New GridViewTextBoxColumn("CustomerCode")
        fldCustomer.FieldName = "fldCustomer"
        fldCustomer.IsVisible = False
        gvData.Columns.Add(fldCustomer)

        Dim fldYear As New GridViewTextBoxColumn("YEAR")
        fldYear.FieldName = "fldYear"
        fldYear.Width = 150
        gvData.Columns.Add(fldYear)

        Dim fldMonth As New GridViewTextBoxColumn("MONTH")
        fldMonth.FieldName = "fldMonth"
        fldMonth.Width = 150
        gvData.Columns.Add(fldMonth)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER")
        fldCustomerName.FieldName = "fldCustomerName"
        fldCustomerName.Width = 150
        gvData.Columns.Add(fldCustomerName)

        Dim fldItemNo As New GridViewTextBoxColumn("ITEM NO.")
        fldItemNo.FieldName = "fldItemNo"
        fldItemNo.Width = 100
        gvData.Columns.Add(fldItemNo)

        Dim fldDescription As New GridViewTextBoxColumn("DESCRIPTION")
        fldDescription.FieldName = "fldDescription"
        fldDescription.Width = 250
        gvData.Columns.Add(fldDescription)

        Dim fldFGModel As New GridViewTextBoxColumn("MODEL")
        fldFGModel.FieldName = "fldFGModel"
        fldFGModel.Width = 150
        gvData.Columns.Add(fldFGModel)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY")
        fldCurrency.FieldName = "fldCurrency"
        fldCurrency.Width = 100
        gvData.Columns.Add(fldCurrency)

        Dim fldBudget As New GridViewTextBoxColumn("BUDGET AMOUNT")
        fldBudget.FieldName = "fldBudget"
        fldBudget.Width = 100
        gvData.Columns.Add(fldBudget)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

    End Sub
    Private Sub ReloadCustomer()

        ddCustomer.DataSource = Maria.MyQuery("SELECT * FROM tblCustomer")
        ddCustomer.DisplayMember = "fldCustomerName"
        ddCustomer.ValueMember = "fldCustomerCode"

    End Sub

    Private Sub ReloadData()

        gvData.DataSource = Maria.MyQuery("SELECT B.*,C.fldCustomerName FROM tblBudget B join tblCustomer C on B.fldCustomer=C.fldCustomerCode")

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        InsertData(ddYear.Text, ddMonth.SelectedIndex, ddCustomer.SelectedValue, txtItemNo.Text, txtDesc.Text, txtModel.Text, ddCurrency.Text, spnBudget.Value)

    End Sub

    Private Sub InsertData(ByVal parYear As Integer, ByVal parMonth As Integer, ByVal parCustomerID As Integer, ByVal parItemNo As String, ByVal parDesc As String, ByVal parModel As String, ByVal parCurrency As String, ByVal parBudget As Decimal)
        Try

            Dim dtItemNo As DataTable = Maria.MyQuery("SELECT fldItemCode FROM tblItemMasterData where fldItemCode='" & parItemNo & "'")

            If dtItemNo.Rows.Count >= 1 Then

                Maria.AddMySqlParameters("parDesc", parDesc)
                Dim dtDemandDesc As DataTable = Maria.SPSelect("SP_SelectDemandByDesc")

                If dtDemandDesc.Rows.Count >= 1 Then

                    Maria.AddMySqlParameters("parYear", parYear)
                    Maria.AddMySqlParameters("parMonth", parMonth)
                    Maria.AddMySqlParameters("parCustomerID", parCustomerID)
                    Maria.AddMySqlParameters("parItemNo", parItemNo)
                    Maria.AddMySqlParameters("parDesc", parDesc)
                    Maria.AddMySqlParameters("parModel", parModel)
                    Maria.AddMySqlParameters("parCurrency", parCurrency)
                    Maria.AddMySqlParameters("parBudget", parBudget)
                    Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser.Item("fldUsername"))
                    Maria.SPADE("SP_InsertBudgetAmount")

                    RadMessageBox.Show("Saved")
                    ReloadData()

                Else
                    RadMessageBox.Show("Part Description")
                End If

            Else

                RadMessageBox.Show("Item Number")

            End If


        Catch ex As Exception

            RadMessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Clear()

        txtDesc.Text = String.Empty
        txtItemNo.Text = String.Empty
        txtModel.Text = String.Empty
        spnBudget.Value = 0

    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        EditData(BudgetID, ddYear.Text, ddMonth.SelectedIndex, ddCustomer.SelectedValue, txtItemNo.Text, txtDesc.Text, txtModel.Text, ddCurrency.Text, spnBudget.Value)
    End Sub
    Private Sub EditData(ByVal parID As Integer, ByVal parYear As Integer, ByVal parMonth As Integer, ByVal parCustomerID As Integer, ByVal parItemNo As String, ByVal parDesc As String, ByVal parModel As String, ByVal parCurrency As String, ByVal parBudget As Decimal)
        Try
            Dim dtItemNo As DataTable = Maria.MyQuery("SELECT fldItemCode FROM tblItemMasterData where fldItemCode='" & parItemNo & "'")

            If dtItemNo.Rows.Count >= 1 Then

                Maria.AddMySqlParameters("parDesc", parDesc)
                Dim dtDemandDesc As DataTable = Maria.SPSelect("SP_SelectDemandByDesc")

                If dtDemandDesc.Rows.Count >= 1 Then

                    Maria.AddMySqlParameters("parID", parID)
                    Maria.AddMySqlParameters("parYear", parYear)
                    Maria.AddMySqlParameters("parMonth", parMonth)
                    Maria.AddMySqlParameters("parCustomerID", parCustomerID)
                    Maria.AddMySqlParameters("parItemNo", parItemNo)
                    Maria.AddMySqlParameters("parDesc", parDesc)
                    Maria.AddMySqlParameters("parModel", parModel)
                    Maria.AddMySqlParameters("parCurrency", parCurrency)
                    Maria.AddMySqlParameters("parBudget", parBudget)
                    Maria.SPADE("SP_UpdateBudgetAmount")

                    RadMessageBox.Show("Saved")
                    ReloadData()

                Else
                    RadMessageBox.Show("Part Description")
                End If

            Else

                RadMessageBox.Show("Item Number")

            End If


        Catch ex As Exception

            RadMessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Sub cbbDeleteRecord_Click(sender As Object, e As EventArgs) Handles cbbDeleteRecord.Click
        Dim result As Integer = MessageBox.Show("Are You Sure You Want To Delete This Record", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        Else
            For counter As Integer = 0 To Me.gvData.SelectedRows.Count - 1
                Maria.MyQuery("Delete from tblBudget where fldID=" & Me.gvData.SelectedRows(counter).Cells("fldID").Value & "")
            Next
            RadMessageBox.SetThemeName("CrystalDark")
            RadMessageBox.Show("Item/s Deleted")
            ReloadData()
        End If
    End Sub

    Private Sub cbbImport_Click(sender As Object, e As EventArgs) Handles cbbImport.Click
        FrmImportBudget.ShowDialog(Me)
    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.ShowFilteringRow = True
        Else
            gvData.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub gvData_CellDoubleClick(sender As Object, e As UI.GridViewCellEventArgs) Handles gvData.CellDoubleClick
        BudgetID = gvData.CurrentRow.Cells("fldID").Value
        ddYear.Text = gvData.CurrentRow.Cells("fldYear").Value.ToString
        ddMonth.SelectedIndex = gvData.CurrentRow.Cells("fldMonth").Value
        ddCustomer.SelectedValue = gvData.CurrentRow.Cells("fldCustomer").Value
        txtItemNo.Text = gvData.CurrentRow.Cells("fldItemNo").Value.ToString
        txtDesc.Text = gvData.CurrentRow.Cells("fldDescription").Value.ToString
        txtModel.Text = gvData.CurrentRow.Cells("fldFGModel").Value.ToString
        ddCurrency.Text = gvData.CurrentRow.Cells("fldCurrency").Value.ToString
        spnBudget.Text = gvData.CurrentRow.Cells("fldBudget").Value
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadData()
    End Sub
End Class
