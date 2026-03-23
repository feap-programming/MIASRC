Imports FEAPNS.DataAccess
Imports Telerik.Reporting
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmDocsInfo
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub FrmDocsInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridCol()
        ReloadGrid()
    End Sub
    Private Sub GridCol()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 150
        gvData.Columns.Add(fldID)

        Dim fldEffectiveDate As New GridViewTextBoxColumn
        fldEffectiveDate.HeaderText = "Effective Date"
        fldEffectiveDate.FieldName = "fldEffectiveDate"
        fldEffectiveDate.TextAlignment = ContentAlignment.MiddleCenter
        fldEffectiveDate.Width = 150
        gvData.Columns.Add(fldEffectiveDate)

        Dim fldDocNo As New GridViewTextBoxColumn
        fldDocNo.HeaderText = "Document #"
        fldDocNo.FieldName = "fldDocNo"
        fldDocNo.TextAlignment = ContentAlignment.MiddleCenter
        fldDocNo.Width = 150
        gvData.Columns.Add(fldDocNo)

    End Sub

    Private Sub ReloadGrid()
        gvData.DataSource = Maria.MyQuery("Select * From tblDailyReportDocsInfo")
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim arrImage() As Byte
        Try
            Dim mstream As New System.IO.MemoryStream()
            pbStamp.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length


            Maria.AddMySqlParameters("parEffDate", dpEffDate.Value)
            Maria.AddMySqlParameters("parDocNo", tbDocNo.Text)
            Maria.AddMySqlParameters("parStamp", arrImage)
            Maria.SPADE("SP_SRCDailyReport_InsertDocInfo")
            RadMessageBox.Show("Done")
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        OpenFileDialog.ShowDialog()

        If OpenFileDialog.FileName = "" Or OpenFileDialog.FileName = "OpenFileDialog1" Then

        Else

            Try
                pbStamp.Image = Image.FromFile(OpenFileDialog.FileName)
            Catch ex As Exception
                RadMessageBox.Show("Invalid Image File")
            End Try


        End If
    End Sub

    Private Sub gvData_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellDoubleClick
        Dim CheckID As Integer = gvData.CurrentRow.Cells("fldID").Value
        Dim DTehe As DataTable = Maria.MyQuery("Select * From tblDailyReportDocsInfo where fldID=" & CheckID & "")
        DoScan(DTehe)
    End Sub
    Private Sub DoScan(DTStamp As DataTable)
        tbDocNo.Text = DTStamp.Rows(0).Item("fldDocNo").ToString
        dpEffDate.Value = DTStamp.Rows(0).Item("fldEffectiveDate")
        Try

            Dim OwO As Byte() = DTStamp.Rows(0).Item("fldStamp")
            Dim ms As New IO.MemoryStream(OwO)
            Dim returnImage As Image = Image.FromStream(ms)
            pbStamp.Image = returnImage

        Catch ex As Exception

        End Try


    End Sub
End Class
