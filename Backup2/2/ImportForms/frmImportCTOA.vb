Imports System.ComponentModel
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmImportCTOA

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtLines As DataTable
    Private dtModel As DataTable
    Private dtCustomer As DataTable
    Private linestat As String
    Private lineNo As Integer
    Private errorMessage As String = String.Empty

    Private Sub FrmImportCTOA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)
    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click
        gvData.DataSource = Nothing

        Dim table As DataTable = Slipknot.getClipboard

        Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                    Select New With
                                         {
                                           .fldYear = IIf(Not String.IsNullOrEmpty(T0.Item(0)), T0.Item(0), 0),
                                           .fldMonthName = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
                                           .fldLineName = Regex.Replace(Trim(T0.Item(2)), "\s+", " "),
                                           .fldModelName = Regex.Replace(Trim(T0.Item(3)), "\s+", " "),
                                           .fldCT = IIf(Not String.IsNullOrEmpty(T0.Item(4)), T0.Item(4), 0),
                                           .fldOA = IIf(Not String.IsNullOrEmpty(T0.Item(5)), T0.Item(5), 0),
                                           .fldPartName = Regex.Replace(Trim(T0.Item(6)), "\s+", " "),
                                           .fldCustomerName = Regex.Replace(Trim(T0.Item(7)), "\s+", " "),
                                           .fldLineNumber = IIf(Not String.IsNullOrEmpty(T0.Item(8)), T0.Item(8), 0),
                                           .fldPriority = IIf(Not String.IsNullOrEmpty(T0.Item(9)), T0.Item(9), 0)
                                         }).ToList
        gvData.DataSource = Query
    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click
        Me.dtLines = Me.myDB.SPSelect("SP_SelectAllLines")
        Me.dtModel = Me.myDB.SPSelect("SP_SelectAllModel")
        Me.dtCustomer = Me.myDB.SPSelect("SP_SelectAllCustomers")
        bwUpload.RunWorkerAsync()
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 20

        Dim lineCode As DataRow()
        Dim modelCode As DataRow()
        Dim customerCode As DataRow()
        Dim customerCodeVal As String = String.Empty

        For counter As Integer = 0 To gvData.Rows.Count - 1

            lineCode = Me.dtLines.Select("fldLineName = '" & Regex.Replace(Trim(gvData.Rows(counter).Cells("fldLineName").Value), "\s+", "") & "'")
            modelCode = Me.dtModel.Select("fldModelName = '" & Regex.Replace(Trim(gvData.Rows(counter).Cells("fldModelName").Value), "\s+", " ") & "'")
            customerCode = Me.dtCustomer.Select("fldCustomerName = '" & Regex.Replace(Trim(gvData.Rows(counter).Cells("fldCustomerName").Value), "\s+", "") & "'")
            If customerCode.Length > 0 Then
                customerCodeVal = customerCode(0).Item("fldCustomerCode")
            End If

            If modelCode.Count > 0 Then

                Slipknot.addParameter("_year", gvData.Rows(counter).Cells("fldYear").Value)
                Slipknot.addParameter("_month", DateTime.ParseExact(gvData.Rows(counter).Cells("fldMonthName").Value, "MMMM", CultureInfo.CurrentCulture).Month)
                Slipknot.addParameter("lineCode", lineCode(0).Item("fldCode"))
                Slipknot.addParameter("modelCode", modelCode(0).Item("fldCode"))
                Slipknot.addParameter("ct", gvData.Rows(counter).Cells("fldCT").Value)
                Slipknot.addParameter("oa", gvData.Rows(counter).Cells("fldOA").Value)
                Slipknot.addParameter("partName", gvData.Rows(counter).Cells("fldPartName").Value)
                Slipknot.addParameter("customerCode", customerCodeVal)
                Slipknot.addParameter("lineNo", gvData.Rows(counter).Cells("fldLineNumber").Value)
                Slipknot.addParameter("priority", gvData.Rows(counter).Cells("fldPriority").Value)
                Slipknot.addParameter("addedBy", currentUser.Item("fldUsername"))

                If Slipknot.dbAED("SP_P_InsertModelSettings") Then
                    linestat = "OK"
                Else
                    linestat = "NG"
                End If

                Dim percent As Double = counter / gvData.Rows.Count * 100
                lineNo = counter
                RadProgressBarElement1.Text = "Saving..."
                bwUpload.ReportProgress(Convert.ToInt32(percent))
                Threading.Thread.Sleep(delay)

            Else

                errorMessage += Environment.NewLine & Regex.Replace(Trim(gvData.Rows(counter).Cells("fldModelName").Value), "\s+", " ")

            End If

        Next
    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        If String.IsNullOrWhiteSpace(errorMessage) Then
            RadMessageBox.Show("Successfully Uploaded", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            RadMessageBox.Show(Me, "The following models are not found in the collection:" & Environment.NewLine & errorMessage, "Model Not Found", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
        errorMessage = String.Empty
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

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldStatColumn As New GridViewTextBoxColumn("Status")
        fldStatColumn.FieldName = "STATUS"
        fldStatColumn.Width = 60
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.IsPinned = True
        fldStatColumn.PinPosition = PinnedColumnPosition.Left
        gridView.Columns.Add(fldStatColumn)

        Dim year As New GridViewDecimalColumn("Year")
        year.FieldName = "fldYear"
        year.Width = 100
        year.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(year)

        Dim monthName As New GridViewTextBoxColumn("Month")
        monthName.FieldName = "fldMonthName"
        monthName.Width = 150
        monthName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(monthName)

        Dim lineName As New GridViewTextBoxColumn("Line Name")
        lineName.FieldName = "fldLineName"
        lineName.Width = 100
        lineName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(lineName)

        Dim modelName As New GridViewTextBoxColumn("Model Name")
        modelName.FieldName = "fldModelName"
        modelName.Width = 150
        modelName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(modelName)

        Dim ct As New GridViewDecimalColumn("C.T.")
        ct.FieldName = "fldCT"
        ct.Width = 100
        ct.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(ct)

        Dim oa As New GridViewDecimalColumn("O.A. (%)")
        oa.FieldName = "fldOA"
        oa.Width = 100
        oa.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(oa)

        Dim partName As New GridViewTextBoxColumn("Part Name")
        partName.FieldName = "fldPartName"
        partName.Width = 200
        partName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(partName)

        Dim customerName As New GridViewTextBoxColumn("Customer Name")
        customerName.FieldName = "fldCustomerName"
        customerName.Width = 150
        customerName.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(customerName)

        Dim lineNo As New GridViewDecimalColumn("Line No.")
        lineNo.FieldName = "fldLineNumber"
        lineNo.Width = 100
        lineNo.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(lineNo)

        Dim priority As New GridViewDecimalColumn("Priority")
        priority.FieldName = "fldPriority"
        priority.Width = 100
        priority.TextAlignment = ContentAlignment.MiddleCenter
        gridView.Columns.Add(priority)

    End Sub

End Class
