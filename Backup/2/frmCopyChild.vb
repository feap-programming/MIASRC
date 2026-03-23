Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmCopyChild
    Private Sub FrmCopyChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadParent()
        readyFrid()
    End Sub

    Private Sub readyFrid()

        Dim fldStatus As New GridViewTextBoxColumn("STATUS")
        fldStatus.FieldName = "fldStatus"
        fldStatus.Width = 70
        fldStatus.TextAlignment = ContentAlignment.MiddleCenter
        gvData.Columns.Add(fldStatus)

        Dim fldChildCode As New GridViewTextBoxColumn("CHILD CODE")
        fldChildCode.FieldName = "fldChildCode"
        fldChildCode.Width = 160
        gvData.Columns.Add(fldChildCode)

        Dim fldUsage As New GridViewDecimalColumn("USAGE")
        fldUsage.FieldName = "fldUsage"
        fldUsage.Width = 90
        gvData.Columns.Add(fldUsage)
        gvData.Columns("fldUsage").FormatString = "{0:N6}"

        Dim fldRemarks As New GridViewTextBoxColumn("REMARKS")
        fldRemarks.FieldName = "fldRemarks"
        fldRemarks.Width = 150
        gvData.Columns.Add(fldRemarks)

        Dim fldWarning As New GridViewTextBoxColumn("WARNING")
        fldWarning.FieldName = "fldWarning"
        fldWarning.Width = 150
        gvData.Columns.Add(fldWarning)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True
        gvData.EnableSorting = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False

        gvData.TableElement.RowHeight = 25

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.Rows.Count.ToString
    End Sub

    Private Sub loadParent()

        Dim dtPartNoHistory As DataTable = Slipknot.dbSelect("SP_SelectAllItemCode")

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 160
        mcbParent.MultiColumnComboBoxElement.Columns.Add(fldItemCode)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 160
        mcbParent.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbParent.DataSource = dtPartNoHistory
        mcbParent.ValueMember = "fldItemCode"
        mcbParent.DisplayMember = "fldItemCode"
        mcbParent.MultiColumnComboBoxElement.DropDownWidth = 500

        mcbParent.AutoFilter = True
        mcbParent.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbParent.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub

    Private lineNo As Integer
    Private lineStat As String

    Private Sub bwOperation_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwOperation.DoWork

        aedType = 1

        Dim childCode As String = Nothing
        Dim usage As Decimal = Nothing
        Dim remarks As String

        For i As Integer = 0 To gvData.Rows.Count - 1

            publicText = String.Empty
            usage = 0
            remarks = String.Empty

            childCode = Convert.ToString(gvData.Rows(i).Cells("fldChildCode").Value)
            usage = Convert.ToDecimal(gvData.Rows(i).Cells("fldUsage").Value)
            remarks = Convert.ToString(gvData.Rows(i).Cells("fldRemarks").Value)

            If BulletForMyValentine.validateCopyChild(mcbParent.SelectedValue, childCode) Then

                Slipknot.addParameter("parParent", mcbParent.SelectedValue)
                Slipknot.addParameter("parChild", childCode)
                Slipknot.addParameter("parUsage", usage)
                Slipknot.addParameter("parRemarks", remarks)
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                If Slipknot.dbAED("SP_InsertBOMMaster") Then
                    lineStat = "OK"
                Else
                    lineStat = "NG"
                End If
            Else
                lineStat = "NG"
            End If

            Dim percent As Double = i / gvData.Rows.Count * 100
            lineNo = i
            RadProgressBarElement1.Text = "Saving..."
            bwOperation.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)
        Next

    End Sub

    Private Sub bwOperation_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwOperation.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = lineStat
        gvData.CurrentRow.Cells("fldWarning").Value = publicText

        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwOperation_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwOperation.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        aedType = 0
    End Sub
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If mcbParent.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please parent part number properly", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If Not BulletForMyValentine.checkItemCodeIfExist(mcbParent.SelectedValue) Then
            RadMessageBox.Show("Parent item not found", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        bwOperation.RunWorkerAsync()

    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting
        If (e.CellElement.ColumnInfo.Name = "fldStatus" And Convert.ToString(e.CellElement.RowInfo.Cells("fldStatus").Value) = "OK") Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.BackColor = Color.LimeGreen
            e.CellElement.Font = New Font("Arial", 10, FontStyle.Bold)
        ElseIf e.CellElement.ColumnInfo.Name = "fldStatus" And Convert.ToString(e.CellElement.RowInfo.Cells("fldStatus").Value) = "NG" Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.BackColor = Color.Red
            e.CellElement.Font = New Font("Arial", 10, FontStyle.Bold)
        Else
            e.CellElement.DrawFill = False

        End If
    End Sub
End Class
