Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmUsers
    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        txtUsername.Focus()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewTextBoxColumn("ID")
        fldId.FieldName = "fldId"
        fldId.ReadOnly = True
        fldId.IsVisible = False
        gvData.Columns.Add(fldId)

        Dim fldUsername As New GridViewTextBoxColumn("USERNAME")
        fldUsername.FieldName = "fldUsername"
        fldUsername.Width = 110
        fldUsername.ReadOnly = True
        gvData.Columns.Add(fldUsername)

        Dim fldName As New GridViewTextBoxColumn("NAME")
        fldName.FieldName = "fldName"
        fldName.Width = 250
        fldName.ReadOnly = True
        gvData.Columns.Add(fldName)

        Dim fldUserType As New GridViewComboBoxColumn("USER TYPE")
        fldUserType.FieldName = "fldUserType"
        fldUserType.Width = 160
        fldUserType.DataSource = New [String]() {"LIMITED", "ADMINISTRATOR"}
        gvData.Columns.Add(fldUserType)

        Dim fldDisabled As New GridViewCheckBoxColumn("DISABLED")
        fldDisabled.FieldName = "fldDisabled"
        fldDisabled.Width = 100
        gvData.Columns.Add(fldDisabled)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.ReadOnly = True
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.ReadOnly = True
        fldAddedBy.Width = 100
        gvData.Columns.Add(fldAddedBy)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

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

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private myData As DataTable
    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectAllUser")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmUsers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If txtUsername.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Username cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If txtPassword.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Password cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Dim Match = String.Compare(txtPassword.Text, txtConfirmPassword.Text, ignoreCase:=False)

        If Not Match = 0 Then
            RadMessageBox.Show("The same password should be entered in both fields. Please re-enter the password correctly.", "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else

            If lblPasswordMeter.Text <> "Strong" Then
                RadMessageBox.Show("Password should be strong", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Else
                Slipknot.addParameter("parUsername", txtUsername.Text)
                Slipknot.addParameter("parPassword", Slipknot.getMD5Hash(txtPassword.Text))
                Slipknot.addParameter("parUserType", ddUserType.Text)
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername").ToString)

                If Slipknot.dbAED("SP_InsertUser") Then

                    txtUsername.Clear()
                    txtPassword.Clear()
                    txtConfirmPassword.Clear()
                    txtUsername.Focus()

                    If bwLoadData.IsBusy = False Then
                        bwLoadData.RunWorkerAsync()
                    End If
                End If
            End If

        End If

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork
        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = Convert.ToString(rows(i).Cells("fldId").Value)

            If Convert.ToString(rows(i).Cells("fldUsername").Value) <> "admin" Then
                Slipknot.addParameter("parId", id)
                Slipknot.dbAED("SP_DeleteUser")
            End If

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))
        Next
    End Sub
    Private Sub bwOperation_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwOperation.ProgressChanged
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwOperation_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwOperation.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub saveChanges()

        Dim fldId As String
        Dim fldUsername As String
        Dim fldUserType As String
        Dim fldTblCustomerList As String
        Dim fldTblCategoryList As String
        Dim fldTblProcessList As String
        Dim fldTblItemMasterData As String
        Dim fldTblCustomerItemMaster As String
        Dim fldTblPartNumberHistory As String
        Dim fldTblItemMasterProcess As String
        Dim fldTblBOMMasterData As String

        For i As Integer = 0 To gvData.Rows.Count - 1

            fldId = Convert.ToString(gvData.Rows(i).Cells("fldId").Value)
            fldUsername = Convert.ToString(gvData.Rows(i).Cells("fldUsername").Value)

            If fldUsername = "admin" Then
                fldUserType = "ADMINISTRATOR"
            Else
                fldUserType = Convert.ToString(gvData.Rows(i).Cells("fldUserType").Value)
            End If

            fldTblCustomerList = Convert.ToString(gvData.Rows(i).Cells("fldTblCustomerList").Value)
            fldTblCategoryList = Convert.ToString(gvData.Rows(i).Cells("fldTblCategoryList").Value)
            fldTblProcessList = Convert.ToString(gvData.Rows(i).Cells("fldTblProcessList").Value)
            fldTblItemMasterData = Convert.ToString(gvData.Rows(i).Cells("fldTblItemMasterData").Value)
            fldTblCustomerItemMaster = Convert.ToString(gvData.Rows(i).Cells("fldTblCustomerItemMaster").Value)
            fldTblPartNumberHistory = Convert.ToString(gvData.Rows(i).Cells("fldTblPartNumberHistory").Value)
            fldTblItemMasterProcess = Convert.ToString(gvData.Rows(i).Cells("fldTblItemMasterProcess").Value)
            fldTblBOMMasterData = Convert.ToString(gvData.Rows(i).Cells("fldTblBOMMasterData").Value)

            Slipknot.addParameter("parId", fldId)
            Slipknot.addParameter("parUserType", fldUserType)
            Slipknot.addParameter("parTblCustomerList", fldTblCustomerList)
            Slipknot.addParameter("parTblCategoryList", fldTblCategoryList)
            Slipknot.addParameter("parTblProcessList", fldTblProcessList)
            Slipknot.addParameter("parTblItemMasterData", fldTblItemMasterData)
            Slipknot.addParameter("parTblCustomerItemMaster", fldTblCustomerItemMaster)
            Slipknot.addParameter("parTblPartNumberHistory", fldTblPartNumberHistory)
            Slipknot.addParameter("parTblItemMasterProcess", fldTblItemMasterProcess)
            Slipknot.addParameter("parTblBOMMasterData", fldTblBOMMasterData)

            Slipknot.dbAED("SP_UpdateUser")

        Next

        RadMessageBox.Show("Updated Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

    Private Sub cbbExport_Click(sender As Object, e As EventArgs) Handles cbbExport.Click
        If gvData.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.gvData)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
            End If

        End If
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = String.Empty Then
            lblPasswordMeter.Visible = False

        Else
            lblPasswordMeter.Visible = True

        End If

        If Slipknot.passwordMeter(txtPassword.Text) = True Then
            lblPasswordMeter.BackColor = Color.Green
            lblPasswordMeter.Text = "Strong"
            panelPassword.Visible = True
        Else
            lblPasswordMeter.BackColor = Color.Red
            lblPasswordMeter.Text = "Weak"
            panelPassword.Visible = False
            panelConfirmPassword.Visible = False
        End If

        checkPasswordMatch()
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

        checkPasswordMatch()

    End Sub

    Private Sub checkPasswordMatch()

        Dim Match = String.Compare(txtPassword.Text, txtConfirmPassword.Text, ignoreCase:=False)

        If Match <> 0 Then
            panelConfirmPassword.Visible = False
        Else
            If lblPasswordMeter.Text = "Strong" Then
                panelConfirmPassword.Visible = True
            End If
        End If

    End Sub

    Private Sub cbbChangePassword_Click(sender As Object, e As EventArgs) Handles cbbChangePassword.Click

        If Convert.ToString(gvData.CurrentRow.Cells("fldId").Value) <> String.Empty Then
            If Slipknot.IsFormOpen(FrmChangePassword) Then
                FrmChangePassword.Focus()
            Else
                FrmChangePassword.txtUsername.Text = Convert.ToString(gvData.CurrentRow.Cells("fldUsername").Value)
                FrmChangePassword.Show(Me)
            End If
        End If

    End Sub

    Private Sub cbbManageUser_Click(sender As Object, e As EventArgs) Handles cbbManageUser.Click
        If gvData.SelectedRows.Count > 0 Then
            If Slipknot.IsFormOpen(FrmManageUser) Then
                FrmManageUser.Focus()
            Else
                FrmManageUser.txtId.Text = Convert.ToString(gvData.CurrentRow.Cells("fldId").Value)
                FrmManageUser.Show(Me)
            End If
        End If



    End Sub
End Class
