Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ucDailySRCAssy
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim rowIndex As Integer
    Private Sub cbbTemplate_Click(sender As Object, e As EventArgs) Handles cbbTemplate.Click
        FrmSRCAssyTemplate.ShowDialog(Me)
    End Sub
    Private Sub GridCol()
        Dim fldPartNo As New GridViewTextBoxColumn
        fldPartNo.HeaderText = "Part No."
        fldPartNo.FieldName = "fldPartNo"
        fldPartNo.TextAlignment = ContentAlignment.MiddleCenter
        fldPartNo.MinWidth = 100
        fldPartNo.ReadOnly = True
        fldPartNo.IsPinned = True
        fldPartNo.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldPartNo)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.MinWidth = 200
        fldPartName.ReadOnly = True
        fldPartName.IsPinned = True
        fldPartName.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldPartName)

        Dim fldLotNo As New GridViewTextBoxColumn
        fldLotNo.HeaderText = "Lot No"
        fldLotNo.FieldName = "fldLotNo"
        fldLotNo.TextAlignment = ContentAlignment.MiddleCenter
        fldLotNo.MinWidth = 150
        gvData.Columns.Add(fldLotNo)

        Dim fldScrapQty As New GridViewTextBoxColumn
        fldScrapQty.HeaderText = "Scrap Qty"
        fldScrapQty.FieldName = "fldScrapQty"
        fldScrapQty.TextAlignment = ContentAlignment.MiddleCenter
        fldScrapQty.MinWidth = 150
        gvData.Columns.Add(fldScrapQty)

        Dim fldPurgeQty As New GridViewTextBoxColumn
        fldPurgeQty.HeaderText = "Purge Qty"
        fldPurgeQty.FieldName = "fldPurgeQty"
        fldPurgeQty.TextAlignment = ContentAlignment.MiddleCenter
        fldPurgeQty.MinWidth = 150
        gvData.Columns.Add(fldPurgeQty)

        Dim fldQASample As New GridViewTextBoxColumn
        fldQASample.HeaderText = "QA Sample"
        fldQASample.FieldName = "fldQASample"
        fldQASample.TextAlignment = ContentAlignment.MiddleCenter
        fldQASample.MinWidth = 150
        gvData.Columns.Add(fldQASample)

        Dim fldEngSample As New GridViewTextBoxColumn
        fldEngSample.HeaderText = "Engineering Sample"
        fldEngSample.FieldName = "fldEngSample"
        fldEngSample.TextAlignment = ContentAlignment.MiddleCenter
        fldEngSample.MinWidth = 150
        gvData.Columns.Add(fldEngSample)

        gvData.MasterTemplate.BestFitColumns()

    End Sub
    Private Sub cbbReload_Click(sender As Object, e As EventArgs) Handles cbbReload.Click

        Dim result As Integer = RadMessageBox.Show("Reloading Template will remove all the the data you inputed. Continue?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ReloadTemplate()
        End If

    End Sub

    Private Sub ReloadTemplate()
        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportSRCAssyTemplate where fldModel='" & globalVariables.ModelCode & "' and fldLine=" & globalVariables.ModelLine & "")
    End Sub

    Private Sub ReloadData()
        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportSRCAssy where fldDRID=" & globalVariables.DailyRepID & "")
    End Sub

    Private Sub ucDailySRCAssy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridCol()
        Dim checkexist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCAssy where fldDRID=" & globalVariables.DailyRepID & "")
        If checkexist.Rows.Count >= 1 Then
            ReloadData()
        Else
            ReloadTemplate()
        End If

    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        Dim result As Integer = RadMessageBox.Show("Are you sure you want to save?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim checkexist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCAssy where fldDRID=" & globalVariables.DailyRepID & "")

            If checkexist.Rows.Count >= 1 Then

                Maria.MyQuery("Delete from tblDailyReportSRCAssy where fldDRID=" & globalVariables.DailyRepID & "")

            End If
            cbbClear.Enabled = False
            cbbReload.Enabled = False
            cbbSave.Enabled = False
            cbbTemplate.Enabled = False
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Maria.MyQuery("Delete from tblDailyReportSRCAssy where fldDRID=" & globalVariables.DailyRepID & "")
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
            Maria.Connection.Close()

            cbbClear.Enabled = True
            cbbReload.Enabled = True
            cbbSave.Enabled = True
            cbbTemplate.Enabled = True
            Exit Sub
        End Try
        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1
            Try
                Dim parDRID As Integer = globalVariables.DailyRepID
                Dim parPartNo As String = gvData.Rows(rowcounter).Cells("fldPartNo").Value.ToString
                Dim parPartName As String = gvData.Rows(rowcounter).Cells("fldPartName").Value.ToString
                Dim parLotNo As String = DirectCast(gvData.Rows(rowcounter).Cells("fldLotNo").Value, String)
                Dim parScrapQty As String = DirectCast(gvData.Rows(rowcounter).Cells("fldScrapQty").Value, String)
                Dim parPurgeQty As String = DirectCast(gvData.Rows(rowcounter).Cells("fldPurgeQty").Value, String)
                Dim parQASample As String = DirectCast(gvData.Rows(rowcounter).Cells("fldQASample").Value, String)
                Dim parEngSample As String = DirectCast(gvData.Rows(rowcounter).Cells("fldEngSample").Value, String)
                Dim parAddedBy As String = globalVariables.currentUser(1)

                Maria.AddMySqlParameters("parDRID", parDRID)
                Maria.AddMySqlParameters("parPartNo", parPartNo)
                Maria.AddMySqlParameters("parPartName", parPartName)
                Maria.AddMySqlParameters("parLotNo", parLotNo)
                Maria.AddMySqlParameters("parScrapQty", parScrapQty)
                Maria.AddMySqlParameters("parPurgeQty", parPurgeQty)
                Maria.AddMySqlParameters("parQASample", parQASample)
                Maria.AddMySqlParameters("parEngSample", parEngSample)
                Maria.AddMySqlParameters("parAddedBy", parAddedBy)
                Maria.SPADE("SP_SRC_InsertSRCAssy")

                Threading.Thread.Sleep(60)
                Dim RowCount As Integer = gvData.Rows.Count
                rowIndex = rowcounter
                Dim percent As Double = (rowcounter / RowCount * 100)
                BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
                Maria.Connection.Close()

                cbbClear.Enabled = True
                cbbReload.Enabled = True
                cbbSave.Enabled = True
                cbbTemplate.Enabled = True
                Exit Sub
            End Try

        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        gvData.CurrentRow = gvData.Rows(rowIndex)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        RadMessageBox.Show("Done!")
        cbbClear.Enabled = True
        cbbReload.Enabled = True
        cbbSave.Enabled = True
        cbbTemplate.Enabled = True
    End Sub

    Private Sub cbbClear_Click(sender As Object, e As EventArgs) Handles cbbClear.Click
        Dim result As Integer = RadMessageBox.Show("This will clear your inputed data. Continue?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ReloadTemplate()
        End If

    End Sub
End Class
