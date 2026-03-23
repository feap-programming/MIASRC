Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmBIRReference

    Private myData As DataTable
    Private myDataList As Object

    Private Sub FrmBIRReference_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        'LoadDropDown()
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

            myData = Slipknot.dbSelect("SP_P_SelectAllBIRReference")
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

        If Not String.IsNullOrEmpty(txtPermitNo.Text) Then

            Dim notSaved As String = String.Empty

            Dim confirmResult As DialogResult = RadMessageBox.Show(Me, "Please confirm to add BIR Reference", "SAVING",
                                                           MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If confirmResult = DialogResult.Yes Then

                Slipknot.addParameter("parPermitNo", Me.txtPermitNo.Text)
                Slipknot.addParameter("parDateIssued", Me.dtDateIssued.Value)
                Slipknot.addParameter("parSeriesFrom", Me.numSeriesFrom.Value)
                Slipknot.addParameter("parSeriesTo", Me.numSeriesTo.Value)
                Slipknot.addParameter("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertBIRReference") Then
                    notSaved += "Error"
                End If

                If bwLoadData.IsBusy = False Then
                    bwLoadData.RunWorkerAsync()
                    If String.IsNullOrWhiteSpace(notSaved) Then
                        RadMessageBox.Show("BIR Reference successfully added.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Else
                        RadMessageBox.Show("Error in saving BIR Reference.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                    End If
                End If

            End If

        Else

            RadMessageBox.Show("Please select customer.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub cbbUpdate_Click(sender As Object, e As EventArgs) Handles cbbUpdate.Click

        Dim id As Int64 = 0
        id = gvData.CurrentRow.Cells("fldID").Value

        Dim editForm As New FrmEditBIRReference
        editForm.ShowDialog(id)

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("It will also delete all history record under this item, are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
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
        Slipknot.dbAED("SP_P_DeleteBIRReference")

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

    Private Sub SetUpColumns()

        Dim fldID As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = False
        }
        gvData.Columns.Add(fldID)

        Dim fldPermitNo As New GridViewTextBoxColumn("PERMIT NO") With {
            .FieldName = "fldPermitNo",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldPermitNo)

        Dim fldDateIssued As New GridViewDateTimeColumn("DATE ISSUED") With {
            .FieldName = "fldDateIssued",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldDateIssued)
        gvData.Columns("fldDateIssued").FormatString = "{0:MMM dd, yyyy}"

        Dim fldSeriesFrom As New GridViewDecimalColumn("SERIES FROM") With {
            .FieldName = "fldSeriesFrom",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldSeriesFrom)

        Dim fldSeriesTo As New GridViewDecimalColumn("SERIES TO") With {
            .FieldName = "fldSeriesTo",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gvData.Columns.Add(fldSeriesTo)

        gvData.TableElement.RowHeight = 25

    End Sub

End Class
