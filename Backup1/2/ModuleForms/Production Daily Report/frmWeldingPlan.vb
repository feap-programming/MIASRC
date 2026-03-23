Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class FrmWeldingPlan
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub FrmWeldingPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridCol()
        ReloadGrid()
    End Sub

    Private Sub GridCol()
        gvData.Columns.Clear()
        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 20
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldShift As New GridViewTextBoxColumn
        fldShift.HeaderText = "Shift"
        fldShift.FieldName = "fldShift"
        fldShift.TextAlignment = ContentAlignment.MiddleCenter
        fldShift.Width = 150
        fldShift.ReadOnly = True
        gvData.Columns.Add(fldShift)

        Dim fldTime As New GridViewTextBoxColumn
        fldTime.HeaderText = "Time"
        fldTime.FieldName = "fldTime"
        fldTime.TextAlignment = ContentAlignment.MiddleCenter
        fldTime.Width = 150
        fldTime.ReadOnly = True
        gvData.Columns.Add(fldTime)

        Dim fldPlan As New GridViewDecimalColumn
        fldPlan.HeaderText = "Plan"
        fldPlan.FieldName = "fldPlan"
        fldPlan.TextAlignment = ContentAlignment.MiddleCenter
        fldPlan.Width = 150
        gvData.Columns.Add(fldPlan)
    End Sub
    Private Sub ReloadGrid()
        gvData.DataSource = Maria.MyQuery("SELECT * FROM dbMIA.tblDailyReportWeldingPlan where fldShift='" & ddShift.Text & "'")
    End Sub

    Private Sub ReloadTime()

    End Sub

    Private Sub ddShift_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddShift.SelectedIndexChanged
        ReloadGrid()
    End Sub
    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click

        Try
            For i As Integer = 0 To gvData.Rows.Count - 1

                Dim parId As Integer = gvData.Rows(i).Cells("fldID").Value
                Dim parVal As Integer = gvData.Rows(i).Cells("fldPlan").Value

                Maria.MyQuery("Update tblDailyReportWeldingPlan set fldPlan=" & parVal & " where fldID=" & parId & "")

            Next
            MessageBox.Show("Done!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Maria.Connection.Close()
        End Try

    End Sub
End Class
