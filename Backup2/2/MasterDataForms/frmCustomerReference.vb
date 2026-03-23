Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmCustomerReference

    Private myData As DataTable
    Private myDataList As Object

    Private Sub FrmCustomerReference_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        SetUpColumns()

        drpClassification.SelectedIndex = drpClassification.FindStringExact("LOCAL")

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

            myData = Slipknot.dbSelect("SP_P_SelectAllCustomerReference")
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

        If Not String.IsNullOrEmpty(txtName.Text) Then

            Dim notSaved As String = String.Empty

            Dim confirmResult As DialogResult = RadMessageBox.Show(Me, "Please confirm to add Customer Reference", "SAVING",
                                                           MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If confirmResult = DialogResult.Yes Then

                Slipknot.addParameter("parName", Regex.Replace(Trim(Me.txtName.Text), "\s+", " "))
                Slipknot.addParameter("parAddress", Regex.Replace(Trim(Me.txtAddress.Text), "\s+", " "))
                Slipknot.addParameter("parTelNo", Regex.Replace(Trim(Me.txtTelNo.Text), "\s+", " "))
                Slipknot.addParameter("parFaxNo", Regex.Replace(Trim(Me.txtFaxNo.Text), "\s+", " "))
                Slipknot.addParameter("parBusinessStyle", Regex.Replace(Trim(Me.txtBusinessStyle.Text), "\s+", " "))
                Slipknot.addParameter("parCountryOrigin", Regex.Replace(Trim(Me.txtCountryOrigin.Text), "\s+", " "))
                Slipknot.addParameter("parTIN", Regex.Replace(Trim(Me.txtTIN.Text), "\s+", " "))
                Slipknot.addParameter("parContactPerson", Regex.Replace(Trim(Me.txtContactPerson.Text), "\s+", " "))
                Slipknot.addParameter("parContactPosition", Regex.Replace(Trim(Me.txtContactPosition.Text), "\s+", " "))
                Slipknot.addParameter("parClassification", Regex.Replace(Trim(Me.drpClassification.Text), "\s+", " "))
                Slipknot.addParameter("parAddedBy", Regex.Replace(Trim(currentUser.Item("fldUsername")), "\s+", " "))
                If Not Slipknot.dbAED("SP_P_InsertCustomerReference") Then
                    notSaved += "Error"
                End If

                If bwLoadData.IsBusy = False Then
                    bwLoadData.RunWorkerAsync()
                    If String.IsNullOrWhiteSpace(notSaved) Then
                        RadMessageBox.Show("Customer Reference successfully added.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Else
                        RadMessageBox.Show("Error in saving Customer Reference.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                    End If
                End If

            End If

        Else

            RadMessageBox.Show("Please fill-out customer name.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End If

    End Sub

    Private Sub cbbUpdate_Click(sender As Object, e As EventArgs) Handles cbbUpdate.Click

        Dim id As Int64 = 0
        id = gvData.CurrentRow.Cells("fldID").Value

        Dim editForm As New FrmEditCustomerReference
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
        Slipknot.dbAED("SP_P_DeleteCustomerReference")

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

        Dim fldName As New GridViewTextBoxColumn("NAME") With {
            .FieldName = "fldName",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldName)

        Dim fldAddress As New GridViewTextBoxColumn("ADDRESS") With {
            .FieldName = "fldAddress",
            .MinWidth = 300,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldAddress)

        Dim fldTelNo As New GridViewTextBoxColumn("TEL NO") With {
            .FieldName = "fldTelNo",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldTelNo)

        Dim fldFaxNo As New GridViewTextBoxColumn("FAX NO") With {
            .FieldName = "fldFaxNo",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldFaxNo)

        Dim fldBusinessStyle As New GridViewTextBoxColumn("BUSINESS STYLE") With {
            .FieldName = "fldBusinessStyle",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldBusinessStyle)

        Dim fldCountryOrigin As New GridViewTextBoxColumn("COUNTRY ORIGIN") With {
            .FieldName = "fldCountryOrigin",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldCountryOrigin)

        Dim fldTIN As New GridViewTextBoxColumn("TIN") With {
            .FieldName = "fldTIN",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldTIN)

        Dim fldContactPerson As New GridViewTextBoxColumn("CONTACT PERSON") With {
            .FieldName = "fldContactPerson",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldContactPerson)

        Dim fldContactPosition As New GridViewTextBoxColumn("CONTACT POSITION") With {
            .FieldName = "fldContactPosition",
            .MinWidth = 200,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldContactPosition)

        Dim fldClassification As New GridViewTextBoxColumn("CLASSIFICATION") With {
            .FieldName = "fldClassification",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleLeft
        }
        gvData.Columns.Add(fldClassification)

        gvData.TableElement.RowHeight = 25

    End Sub

End Class
