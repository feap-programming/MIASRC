Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmCustomerStdLeadTime

    Private myData As DataTable
    Private myDataList As Object

    Private Sub FrmCustomerStdLeadTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        LoadDropDown()
        SetUpColumns()

        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork

        bwLoadData.ReportProgress(Convert.ToInt32(0))
        Threading.Thread.Sleep(delay)

        If Not bwLoadData.CancellationPending Then

            myData = Slipknot.dbSelect("SP_P_SelectAllCustomerStdLeadTime")
            myDataList = myData

            bwLoadData.ReportProgress(Convert.ToInt32(100))
            Threading.Thread.Sleep(delay)

        Else

            e.Cancel = True

        End If

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged

        If e.ProgressPercentage = 0 Then
            RadProgressBarElement1.Text = "Preparing..."
        ElseIf e.ProgressPercentage = 100 Then
            RadProgressBarElement1.Text = "Done"
        Else
            RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        End If

        RadProgressBarElement1.Value1 = e.ProgressPercentage

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted

        If Not e.Cancelled Then

            gvData.DataSource = myDataList
            gvData.BestFitColumns()
            leCountRec.Text = gvData.Rows.Count

        End If

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If mcbCustomer.SelectedIndex >= 0 Then

            Dim notSaved As String = String.Empty

            Dim confirmResult As DialogResult = RadMessageBox.Show(Me, "Please confirm to add std lead time for " & Regex.Replace(Trim(mcbCustomer.Text), "\s+", " "), "SAVING",
                                                           MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If confirmResult = DialogResult.Yes Then

                Slipknot.addParameter("parCustomerCode", Me.mcbCustomer.SelectedValue)
                Slipknot.addParameter("parETDManilaSeaNOD", Me.numETDManilaSea.Value)
                Slipknot.addParameter("parETDManilaAirNOD", Me.numETDManilaAir.Value)
                Slipknot.addParameter("parETACustomerSeaNOD", Me.numETACustomerSea.Value)
                Slipknot.addParameter("parETACustomerAirNOD", Me.numETACustomerAir.Value)
                Slipknot.addParameter("parEffectivityDate", Me.dtEffectivityDate.Value)
                Slipknot.addParameter("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertCustomerStdLeadTime") Then
                    notSaved += "Error"
                End If

                If bwLoadData.IsBusy = False Then
                    bwLoadData.RunWorkerAsync()
                    If String.IsNullOrWhiteSpace(notSaved) Then
                        RadMessageBox.Show("Std Lead Time successfully added.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Else
                        RadMessageBox.Show("Error in saving Std Lead Time.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                    End If
                End If

            End If

        Else

            RadMessageBox.Show("Please select customer.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub cbbUpdate_Click(sender As Object, e As EventArgs) Handles cbbUpdate.Click

        If gvData.SelectedRows.Count > 0 Then

            Dim id As Int64 = 0
            Dim customerCode As String = String.Empty
            id = gvData.CurrentRow.Cells("fldID").Value
            customerCode = gvData.CurrentRow.Cells("fldCustomerCode").Value

            Dim editForm As New FrmEditCustomerStdLeadTime
            editForm.ShowDialog(id, customerCode)

        End If

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("It will also delete all history record under this item, are you sure you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwOperation.IsBusy = False Then
                    bwOperation.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub bwOperation_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwOperation.DoWork

        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id += "," & Convert.ToString(rows(i).Cells("fldID").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwOperation.ReportProgress(Convert.ToInt32(percent))

        Next

        Slipknot.addParameter("IDArray", id)
        Slipknot.dbAED("SP_P_DeleteCustomerStdLeadTime")

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

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.EnableFiltering = True
            gvData.MasterTemplate.ShowHeaderCellButtons = True
            gvData.MasterTemplate.ShowFilteringRow = True
        Else
            gvData.EnableFiltering = False
            gvData.MasterTemplate.ShowHeaderCellButtons = False
            gvData.MasterTemplate.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub gvData_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs) Handles gvData.ContextMenuOpening

        Dim cell As GridDataCellElement = TryCast(e.ContextMenuProvider, GridDataCellElement)

        If cell Is Nothing Then
            Return
        End If

        e.ContextMenu = cmActionChooser.DropDown

    End Sub

    Private Sub miCopy_Click(sender As Object, e As EventArgs) Handles miCopy.Click
        Dim selectionMode As GridViewSelectionMode = Me.gvData.SelectionMode
        Me.gvData.SelectionMode = GridViewSelectionMode.CellSelect
        Me.gvData.CurrentRow.Cells(Me.gvData.CurrentColumn.Name).IsSelected = True
        Me.gvData.Copy()
        Me.gvData.SelectionMode = selectionMode
        Me.gvData.CurrentRow.IsSelected = True
    End Sub

    Private Sub miHistory_Click(sender As Object, e As EventArgs) Handles miHistory.Click

        Try

            Dim customerCode As String = String.Empty
            customerCode = gvData.CurrentRow.Cells("fldCustomerCode").Value

            Dim editForm As New FrmHistoryCustomerStdLeadTime
            editForm.ShowDialog(customerCode)

        Catch ex As System.Reflection.AmbiguousMatchException

            RadMessageBox.Show(Me, "Please select proper row.", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        Catch ex As Exception

            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)

        End Try

    End Sub

    Public Sub LoadDropDown()

        Dim fldId As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldId",
            .Width = 80,
            .IsVisible = False
        }
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldId)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUST. CODE") With {
            .FieldName = "fldCustomerCode",
            .Width = 100
        }
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .Width = 120
        }
        mcbCustomer.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")
        mcbCustomer.DataSource = dtCustomer
        mcbCustomer.DisplayMember = "fldCustomerName"
        mcbCustomer.ValueMember = "fldCustomerCode"
        mcbCustomer.MultiColumnComboBoxElement.DropDownWidth = 300

        mcbCustomer.AutoFilter = True
        mcbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerPartNo As New FilterDescriptor With {
            .PropertyName = "fldCustomerName",
            .Operator = FilterOperator.Contains
        }
        mcbCustomer.EditorControl.MasterTemplate.FilterDescriptors.Add(customerPartNo)

        mcbCustomer.SelectedIndex = -1
        mcbCustomer.Text = String.Empty

    End Sub

    Private Sub SetUpColumns()

        Dim fldID As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = False
        }
        gvData.Columns.Add(fldID)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUSTOMER CODE") With {
            .FieldName = "fldCustomerCode",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gvData.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldCustomerName)

        Dim fldETDManilaSeaNOD As New GridViewTextBoxColumn("ETD MNL (SEA)") With {
            .FieldName = "fldETDManilaSeaNOD",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDManilaSeaNOD)

        Dim fldETDManilaAirNOD As New GridViewTextBoxColumn("ETD MNL (AIR)") With {
            .FieldName = "fldETDManilaAirNOD",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETDManilaAirNOD)

        Dim fldETACustomerSeaNOD As New GridViewTextBoxColumn("ETA CUST (SEA)") With {
            .FieldName = "fldETACustomerSeaNOD",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETACustomerSeaNOD)

        Dim fldETACustomerAirNOD As New GridViewTextBoxColumn("ETA CUST (AIR)") With {
            .FieldName = "fldETACustomerAirNOD",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldETACustomerAirNOD)

        Dim fldEffectivityDate As New GridViewDateTimeColumn("EFFECTIVITY DATE") With {
            .FieldName = "fldEffectivityDate",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldEffectivityDate)
        gvData.Columns("fldEffectivityDate").FormatString = "{0:MMM dd, yyyy}"

        gvData.TableElement.RowHeight = 25

    End Sub

End Class
