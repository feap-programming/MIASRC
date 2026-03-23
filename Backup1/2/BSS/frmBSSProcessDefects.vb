Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class FrmBSSProcessDefects
    Public linestat As String
    Public lineNo As Integer
    Private Sub FrmBSSProcessDefects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        GridDefects()
        GridDefectsImport()
    End Sub

    Private Sub FrmBSSProcessDefects_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchDefects()
    End Sub
    Private Sub FetchDefects()
        gvDefects.DataSource = Slipknot.dbSelect("SP_SelectBSSProcessDefectList")
    End Sub
    Private Sub GridDefects()
        Dim fldHID As New GridViewDecimalColumn("DID") With {
            .FieldName = "fldDID",
            .IsVisible = False
        }
        gvDefects.Columns.Add(fldHID)

        Dim fldItemCode As New GridViewTextBoxColumn("Defect") With {
            .FieldName = "fldDefect",
            .Width = 300,
            .ReadOnly = True
        }
        gvDefects.Columns.Add(fldItemCode)

        gvDefects.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvDefects.AllowAddNewRow = False
        gvDefects.ShowFilteringRow = False
        gvDefects.ShowGroupPanel = False
        gvDefects.EnableSorting = False
        gvDefects.AllowColumnReorder = False
        gvDefects.AllowRowReorder = False

    End Sub
    Private Sub GridDefectsImport()
        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS") With {
            .FieldName = "STATUS",
            .Width = 60,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .ReadOnly = True,
            .IsPinned = True,
            .PinPosition = PinnedColumnPosition.Left
        }
        gvDefectsImport.Columns.Add(fldStatColumn)

        Dim fldItemCode As New GridViewTextBoxColumn("Defect") With {
            .FieldName = "fldDefect",
            .Width = 120,
            .ReadOnly = True
        }
        gvDefectsImport.Columns.Add(fldItemCode)

        gvDefectsImport.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvDefectsImport.AllowAddNewRow = False
        gvDefectsImport.ShowFilteringRow = False
        gvDefectsImport.ShowGroupPanel = False
        gvDefectsImport.EnableSorting = False
        gvDefectsImport.AllowColumnReorder = False
        gvDefectsImport.AllowRowReorder = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDefects.Text = "" Then
            RadMessageBox.Show("Defects cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtDefects.Select()
            Exit Sub
        End If
        Slipknot.addParameter("Defect", Convert.ToString(txtDefects.Text))
        Slipknot.dbAED("SP_InsertBSSProcessDefect")
        FetchDefects()
    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        gvDefectsImport.DataSource = Nothing
        Dim table As DataTable = getClipboard()

        Dim Query = (From T0 In table.AsEnumerable()
                     Select New With
                         {
                         .fldDefect = Regex.Replace(Trim(T0.Item(0)), "\s+", " ")
                         }).ToList
        gvDefectsImport.DataSource = Query

    End Sub

    Function getClipboard() As DataTable

        Dim ClipboardData As IDataObject = Clipboard.GetDataObject()

        Dim Table As New DataTable With {.TableName = "ExcelData"}

        If Not ClipboardData Is Nothing Then
            If (ClipboardData.GetDataPresent(DataFormats.CommaSeparatedValue)) Then

                Dim ClipboardStream As New IO.StreamReader(
                       CType(ClipboardData.GetData(DataFormats.CommaSeparatedValue), IO.Stream))

                Dim FormattedData As String = ""

                While (ClipboardStream.Peek() > 0)
                    Dim SingleRowData As Array
                    Dim LoopCounter As Integer = 0

                    FormattedData = ClipboardStream.ReadLine()

                    SingleRowData = FormattedData.Split(",".ToCharArray)

                    If Table.Columns.Count <= 0 Then
                        For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                            Table.Columns.Add()
                        Next
                        LoopCounter = 0
                    End If

                    Dim rowNew As DataRow
                    rowNew = Table.NewRow()

                    For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                        rowNew(LoopCounter) = SingleRowData.GetValue(LoopCounter)
                    Next

                    LoopCounter = 0

                    Table.Rows.Add(rowNew)

                    rowNew = Nothing
                End While

                ClipboardStream.Close()

            Else
                RadMessageBox.Show("Clipboard data does not seem to be copied from Excel!", "FEAP HRMS", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        Else
            RadMessageBox.Show("Clipboard is empty!", "FEAP HRMS", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If

        Return Table

    End Function

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If RadMessageBox.Show("Are you sure you want to Save " & gvDefectsImport.SelectedRows.Count & " selected row(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            bwUpload.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        For counter As Integer = 0 To gvDefectsImport.Rows.Count - 1
            Slipknot.addParameter("Defect", Regex.Replace(gvDefectsImport.Rows(counter).Cells("fldDefect").Value, "\s+", " "))
            Slipknot.dbAED("SP_InsertBSSProcessDefect")
            'If Slipknot.dbAED("SP_InsertBSSProcessDefect") Then
            '    linestat = "OK"
            'Else
            '    linestat = "NG"
            'End If

            'Dim percent As Double = counter / gvDefectsImport.Rows.Count * 100
            'lineNo = counter
            'rpbImport.Text = "Saving..."
            'bwUpload.ReportProgress(Convert.ToInt32(percent))
            'Threading.Thread.Sleep(50)
        Next
    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        'gvDefectsImport.CurrentRow = gvDefectsImport.Rows(lineNo)
        'gvDefectsImport.CurrentRow.Cells(0).Value = linestat
        'gvDefectsImport.CurrentRow.Cells("fldWarning").Value = errorMessage

        'rpbImport.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        rpbImport.Value1 = 100
        rpbImport.Text = "Done"
    End Sub
End Class
