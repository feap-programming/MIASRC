Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmConversionRate

    Private myData As DataTable
    Private Sub FrmConversionRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        dtpEffectivityDate.Format = DateTimePickerFormat.Custom
        dtpEffectivityDate.CustomFormat = "MMM dd, yyyy"
        dtpEffectivityDate.Value = Today

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        gvData.Columns.Add(fldId)

        Dim fldCurrency As New GridViewTextBoxColumn("Currency")
        fldCurrency.FieldName = "fldCurrency"
        fldCurrency.Width = 70
        fldCurrency.ReadOnly = True
        gvData.Columns.Add(fldCurrency)

        Dim fldRate As New GridViewDecimalColumn("Rate")
        fldRate.FieldName = "fldRate"
        fldRate.Width = 80
        fldRate.ReadOnly = True
        gvData.Columns.Add(fldRate)

        Dim fldDate As New GridViewDateTimeColumn("Effectivity Date")
        fldDate.FieldName = "fldDate"
        fldDate.Width = 120
        fldDate.ReadOnly = True
        fldDate.Format = DateTimePickerFormat.Custom
        gvData.Columns.Add(fldDate)
        gvData.Columns("fldDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDateAdded As New GridViewDateTimeColumn("Date Added")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.ReadOnly = True
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("Added By")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        fldAddedBy.ReadOnly = True
        gvData.Columns.Add(fldAddedBy)

        Dim fldDelete As New GridViewCommandColumn("Delete")
        fldDelete.FieldName = "fldDelete"
        fldDelete.Width = 60
        fldDelete.DefaultText = "Delete"
        fldDelete.UseDefaultText = True
        fldDelete.TextAlignment = ContentAlignment.MiddleCenter
        gvData.Columns.Add(fldDelete)

        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25

        AddHandler gvData.CommandCellClick, AddressOf deleteRecord

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If seRate.Value < 0 Then
            RadMessageBox.Show("Invalid rate amount", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parCurrency", ddCurrency.Text)
        Slipknot.addParameter("parRate", seRate.Value)
        Slipknot.addParameter("parDate", dtpEffectivityDate.Value)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        If Slipknot.dbAED("SP_InsertConversionRate") Then
            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelectManual("SELECT * FROM tblConversionRate")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmConversionRate_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub deleteRecord(ByVal sender As Object, ByVal e As EventArgs)

        If RadMessageBox.Show("Are you sure you want to delete the selected rate?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

            Slipknot.addParameter("parId", gvData.CurrentRow.Cells("fldId").Value)

            If Slipknot.dbAED("SP_DeleteConversionRate") Then
                gvData.CurrentRow.Delete()
            End If

        End If

    End Sub

End Class
