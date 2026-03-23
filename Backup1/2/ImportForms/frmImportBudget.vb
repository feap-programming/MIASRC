Imports System.ComponentModel
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmImportBudget
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim uploadremarks As String = ""
    Dim uploadStatus As String = ""
    Dim RowIndex, ColIndex As Integer
    Dim ErrorCount As Integer
    Private Sub FrmImportBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        SetUpColumns()
    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click
        Try
            gvData.DataSource = Nothing

            Dim table As DataTable = Slipknot.getClipboard

            table.Rows(0).Delete()

            Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                        Select New With
                                             {
                                               .fldCustomer = Regex.Replace(Trim(T0.Item(0)), "\s+", " "),
                                               .fldItemNo = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
                                               .fldDescription = Regex.Replace(Trim(T0.Item(2)), "\s+", " "),
                                               .fldFGModel = Regex.Replace(Trim(T0.Item(3)), "\s+", " "),
                                               .fldCurrency = Regex.Replace(Trim(T0.Item(4)), "\s+", " "),
                                               .fldYear = IIf(Not String.IsNullOrEmpty(T0.Item(5)), T0.Item(5), 0),
                                               .fldJanuary = IIf(Not String.IsNullOrEmpty(T0.Item(6)), T0.Item(6), 0),
                                               .fldFebruary = IIf(Not String.IsNullOrEmpty(T0.Item(7)), T0.Item(7), 0),
                                               .fldMarch = IIf(Not String.IsNullOrEmpty(T0.Item(8)), T0.Item(8), 0),
                                               .fldApril = IIf(Not String.IsNullOrEmpty(T0.Item(9)), T0.Item(9), 0),
                                               .fldMay = IIf(Not String.IsNullOrEmpty(T0.Item(10)), T0.Item(10), 0),
                                               .fldJune = IIf(Not String.IsNullOrEmpty(T0.Item(11)), T0.Item(11), 0),
                                               .fldJuly = IIf(Not String.IsNullOrEmpty(T0.Item(12)), T0.Item(12), 0),
                                               .fldAugust = IIf(Not String.IsNullOrEmpty(T0.Item(13)), T0.Item(13), 0),
                                               .fldSeptember = IIf(Not String.IsNullOrEmpty(T0.Item(14)), T0.Item(14), 0),
                                               .fldOctober = IIf(Not String.IsNullOrEmpty(T0.Item(15)), T0.Item(15), 0),
                                               .fldNovember = IIf(Not String.IsNullOrEmpty(T0.Item(16)), T0.Item(16), 0),
                                               .fldDecember = IIf(Not String.IsNullOrEmpty(T0.Item(17)), T0.Item(17), 0)
                                             }).ToList
            gvData.DataSource = Query
        Catch ex As Exception
            RadMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click

        bwCheck.RunWorkerAsync()

    End Sub

    Private Sub bwCheck_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCheck.DoWork
        ErrorCount = 0
        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

            Dim fldCustomer As String = gvData.Rows(rowcounter).Cells("fldCustomer").Value.ToString
            Dim fldItemNo As String = gvData.Rows(rowcounter).Cells("fldItemNo").Value.ToString
            Dim fldDescription As String = gvData.Rows(rowcounter).Cells("fldDescription").Value.ToString
            Dim fldFGModel As String = gvData.Rows(rowcounter).Cells("fldFGModel").Value.ToString
            Dim fldCurrency As String = gvData.Rows(rowcounter).Cells("fldCurrency").Value.ToString
            Dim fldYear As String = gvData.Rows(rowcounter).Cells("fldYear").Value.ToString

            Dim intJanuary As Integer = 6
            uploadremarks = ""

            Dim dtCheckCustomer As DataTable = Maria.MyQuery("SELECT fldCustomerName,fldCustomerCode FROM tblCustomer where fldCustomerName='" & fldCustomer & "'")

            If dtCheckCustomer.Rows.Count <= 0 Then
                uploadremarks = "Customer do not exist"
                uploadStatus = "NG"
                ErrorCount = ErrorCount + 1
            Else

                Dim dtCheckItemNo As DataTable = Maria.MyQuery("SELECT fldItemCode FROM tblItemMasterData where fldItemCode='" & fldItemNo & "'")

                If dtCheckItemNo.Rows.Count <= 0 Then

                    uploadremarks = "Item number do not exist"
                    uploadStatus = "NG"
                    ErrorCount = ErrorCount + 1

                Else

                    Maria.AddMySqlParameters("parDesc", fldDescription)
                    Dim dtDemandDesc As DataTable = Maria.SPSelect("SP_SelectDemandByDesc")

                    If dtDemandDesc.Rows.Count <= 0 Then

                        uploadremarks = "Description do not exist"
                        uploadStatus = "NG"
                        ErrorCount = ErrorCount + 1

                    Else

                        uploadStatus = "GOOD"

                    End If

                End If

            End If


            Dim RowCount As Integer = gvData.Rows.Count - 1
            RowIndex = rowcounter
            Dim percent As Double = (rowcounter / RowCount * 100)
            bwCheck.ReportProgress(Convert.ToInt32(percent))

            Threading.Thread.Sleep(80)

        Next

    End Sub

    Private Sub bwCheck_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwCheck.ProgressChanged
        gvData.CurrentRow = gvData.Rows(RowIndex)
        gvData.CurrentRow.Cells(0).Value = uploadStatus
        gvData.CurrentRow.Cells("Remarks").Value = uploadremarks
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwCheck_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCheck.RunWorkerCompleted
        If ErrorCount >= 1 Then
            RadMessageBox.Show("There are " & ErrorCount & " error/s encountered.")
        Else
            RadProgressBarElement1.Value1 = 0
            bwUpload.RunWorkerAsync()
        End If

    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork

        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

            Dim fldCustomer As String = gvData.Rows(rowcounter).Cells("fldCustomer").Value.ToString.Trim
            Dim fldItemNo As String = gvData.Rows(rowcounter).Cells("fldItemNo").Value.ToString.Trim
            Dim fldDescription As String = gvData.Rows(rowcounter).Cells("fldDescription").Value.ToString.Trim
            Dim fldFGModel As String = gvData.Rows(rowcounter).Cells("fldFGModel").Value.ToString.Trim
            Dim fldCurrency As String = gvData.Rows(rowcounter).Cells("fldCurrency").Value.ToString.Trim
            Dim fldYear As String = gvData.Rows(rowcounter).Cells("fldYear").Value.ToString

            Dim intJanuary As Integer = 7
            uploadremarks = ""

            Dim dtCheckCustomer As DataTable = Maria.MyQuery("SELECT fldCustomerName,fldCustomerCode FROM tblCustomer where fldCustomerName='" & fldCustomer & "'")

            While intJanuary <= 18

                Dim Budget As Decimal = gvData.Rows(rowcounter).Cells(intJanuary).Value

                Maria.AddMySqlParameters("parYear", fldYear)
                Maria.AddMySqlParameters("parMonth", intJanuary - 6)
                Maria.AddMySqlParameters("parCustomerID", dtCheckCustomer.Rows(0).Item("fldCustomerCode").ToString)
                Maria.AddMySqlParameters("parItemNo", fldItemNo)
                Maria.AddMySqlParameters("parDesc", fldDescription)
                Maria.AddMySqlParameters("parModel", fldFGModel)
                Maria.AddMySqlParameters("parCurrency", fldCurrency)
                Maria.AddMySqlParameters("parBudget", Math.Round(Budget, 2))
                Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser.Item("fldUsername"))
                Maria.SPADE("SP_InsertBudgetAmount")

                uploadremarks = ""
                Dim RowCount As Integer = gvData.Rows.Count - 1
                RowIndex = rowcounter
                ColIndex = intJanuary
                Dim percent As Double = (rowcounter / RowCount * 100)
                bwUpload.ReportProgress(Convert.ToInt32(percent))

                Threading.Thread.Sleep(80)

                intJanuary = intJanuary + 1

            End While

        Next

    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        gvData.CurrentRow = gvData.Rows(RowIndex)
        gvData.CurrentColumn = gvData.Columns(ColIndex)
        gvData.CurrentRow.Cells(0).Value = uploadStatus
        gvData.Rows(RowIndex).Cells(ColIndex).Style.BackColor = Color.FromArgb(128, 255, 128)
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadMessageBox.Show("Items Uploaded")
    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you want to delete " & gvData.SelectedRows.Count & " selected row(s)?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}
            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1
                Me.gvData.Rows.Remove(rows(i))
            Next

        End If
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click
        If RadMessageBox.Show("Are you sure you want to clear the list?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            gvData.DataSource = Nothing
        End If
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As UI.CellFormattingEventArgs) Handles gvData.CellFormatting

        'If e.CellElement.ColumnInfo.Name = "Status" Then

        '    If e.CellElement.Value = "GOOD" Then
        '        e.CellElement.ForeColor = Color.FromArgb(255, 255, 255)
        '        e.CellElement.BackColor = Color.FromArgb(255, 179, 218)
        '        e.CellElement.BackColor2 = Color.FromArgb(255, 179, 218)
        '    ElseIf e.CellElement.Value = "SAVED" Then
        '        e.CellElement.ForeColor = Color.FromArgb(255, 255, 255)
        '        e.CellElement.BackColor = Color.FromArgb(128, 255, 128)
        '        e.CellElement.BackColor2 = Color.FromArgb(128, 255, 128)
        '    ElseIf e.CellElement.Value = "NG" Then
        '        e.CellElement.ForeColor = Color.FromArgb(255, 255, 255)
        '        e.CellElement.BackColor = Color.FromArgb(242, 38, 19)
        '        e.CellElement.BackColor2 = Color.FromArgb(242, 38, 19)
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        '    End If
        'End If
        'ElseIf e.CellElement.ColumnInfo.Name = "fldFGModel" Then

        '    If CBool(e.CellElement.RowInfo.Cells("fldIsModelNotExist").Value) Then
        '        e.CellElement.ForeColor = Color.FromArgb(242, 38, 19)
        '        e.CellElement.BackColor = Color.FromArgb(255, 204, 204)
        '        e.CellElement.BackColor2 = Color.FromArgb(255, 204, 204)
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        '    End If

        'ElseIf e.CellElement.ColumnInfo.Name = "fldDescription" Then

        '    If CBool(e.CellElement.RowInfo.Cells("fldIsPartNameNotExist").Value) Then
        '        e.CellElement.ForeColor = Color.FromArgb(242, 38, 19)
        '        e.CellElement.BackColor = Color.FromArgb(255, 204, 204)
        '        e.CellElement.BackColor2 = Color.FromArgb(255, 204, 204)
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        '    End If

        'ElseIf e.CellElement.ColumnInfo.Name = "fldModel" Then

        '    If CBool(e.CellElement.RowInfo.Cells("fldIsPartNoNotExist").Value) Then
        '        e.CellElement.ForeColor = Color.FromArgb(242, 38, 19)
        '        e.CellElement.BackColor = Color.FromArgb(255, 204, 204)
        '        e.CellElement.BackColor2 = Color.FromArgb(255, 204, 204)
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        '    End If

        'ElseIf e.CellElement.ColumnInfo.Name = "fldCustomer" Then

        '    If CBool(e.CellElement.RowInfo.Cells("fldIsCustomerNotExist").Value) Then
        '        e.CellElement.ForeColor = Color.FromArgb(242, 38, 19)
        '        e.CellElement.BackColor = Color.FromArgb(255, 204, 204)
        '        e.CellElement.BackColor2 = Color.FromArgb(255, 204, 204)
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        '    End If

        'Else

        '    e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        '    e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
        '    e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)

        'End If

    End Sub

    Private Sub SetUpColumns()

        Dim Status As New GridViewTextBoxColumn("STATUS")
        Status.FieldName = "Status"
        Status.IsVisible = True
        Status.ReadOnly = True
        Status.Width = 100
        gvData.Columns.Add(Status)

        Dim fldCustomer As New GridViewTextBoxColumn("CUSTOMER")
        fldCustomer.FieldName = "fldCustomer"
        fldCustomer.Width = 150
        gvData.Columns.Add(fldCustomer)

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

        Dim fldYear As New GridViewTextBoxColumn("YEAR")
        fldYear.FieldName = "fldYear"
        fldYear.Width = 150
        gvData.Columns.Add(fldYear)

        Dim fldJanuary As New GridViewTextBoxColumn("JANUARY")
        fldJanuary.FieldName = "fldJanuary"
        fldJanuary.Width = 150
        gvData.Columns.Add(fldJanuary)

        Dim fldFebruary As New GridViewTextBoxColumn("FEBRUARY")
        fldFebruary.FieldName = "fldFebruary"
        fldFebruary.Width = 150
        gvData.Columns.Add(fldFebruary)

        Dim fldMarch As New GridViewTextBoxColumn("MARCH")
        fldMarch.FieldName = "fldMarch"
        fldMarch.Width = 150
        gvData.Columns.Add(fldMarch)

        Dim fldApril As New GridViewTextBoxColumn("APRIL")
        fldApril.FieldName = "fldApril"
        fldApril.Width = 150
        gvData.Columns.Add(fldApril)

        Dim fldMay As New GridViewTextBoxColumn("MAY")
        fldMay.FieldName = "fldMay"
        fldMay.Width = 150
        gvData.Columns.Add(fldMay)

        Dim fldJune As New GridViewTextBoxColumn("JUNE")
        fldJune.FieldName = "fldJune"
        fldJune.Width = 150
        gvData.Columns.Add(fldJune)

        Dim fldJuly As New GridViewTextBoxColumn("JULY")
        fldJuly.FieldName = "fldJuly"
        fldJuly.Width = 150
        gvData.Columns.Add(fldJuly)

        Dim fldAugust As New GridViewTextBoxColumn("AUGUST")
        fldAugust.FieldName = "fldAugust"
        fldAugust.Width = 150
        gvData.Columns.Add(fldAugust)

        Dim fldSeptember As New GridViewTextBoxColumn("SEPTEMBER")
        fldSeptember.FieldName = "fldSeptember"
        fldSeptember.Width = 150
        gvData.Columns.Add(fldSeptember)

        Dim fldOctober As New GridViewTextBoxColumn("OCTOBER")
        fldOctober.FieldName = "fldOctober"
        fldOctober.Width = 150
        gvData.Columns.Add(fldOctober)

        Dim fldNovember As New GridViewTextBoxColumn("NOVEMBER")
        fldNovember.FieldName = "fldNovember"
        fldNovember.Width = 150
        gvData.Columns.Add(fldNovember)

        Dim fldDecember As New GridViewTextBoxColumn("DECEMBER")
        fldDecember.FieldName = "fldDecember"
        fldDecember.Width = 150
        gvData.Columns.Add(fldDecember)

        Dim Remarks As New GridViewTextBoxColumn("REMARKS")
        Remarks.FieldName = "Remarks"
        Remarks.IsVisible = True
        Remarks.ReadOnly = True
        Remarks.Width = 150
        gvData.Columns.Add(Remarks)

    End Sub

End Class
