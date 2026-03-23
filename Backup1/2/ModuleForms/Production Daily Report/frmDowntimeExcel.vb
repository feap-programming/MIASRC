Imports ClosedXML.Excel

Public Class FrmDowntimeExcel
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()

                        workbook.Worksheets.Add(CreateDT(ddType.Text), ddShft.Text)

                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("DONE")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        End Using
    End Sub

    Private Function CreateDT(parType As String) As DataTable

        Dim dtExport As New DataTable

        dtExport.Columns.Add("PRODUCT NAME")
        dtExport.Columns.Add("STOP TIME")
        dtExport.Columns.Add("START TIME")
        dtExport.Columns.Add("PLANNED")
        dtExport.Columns.Add("MACHINE NAME")
        dtExport.Columns.Add("MAN")
        dtExport.Columns.Add("MACHINE")
        dtExport.Columns.Add("MATERIAL")
        dtExport.Columns.Add("METHOD")
        dtExport.Columns.Add("SETUP")
        dtExport.Columns.Add("KANBAN")
        dtExport.Columns.Add("OTHERS")
        dtExport.Columns.Add("AFTER SETUP")
        dtExport.Columns.Add("AFTER PM")
        dtExport.Columns.Add("MACHINE (QA)")
        dtExport.Columns.Add("MATERIAL (QA)")
        dtExport.Columns.Add("CAUSE")
        dtExport.Columns.Add("ME")
        dtExport.Columns.Add("PDE")
        dtExport.Columns.Add("PME")
        dtExport.Columns.Add("OTHERS (SECT)")
        dtExport.Columns.Add("PIC")

        dtExport.Rows.Add("SAMPLE NAME", "00:00", "00:00", "TRUE", "SAMPLE NAME", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "NAME")
        Return dtExport
    End Function
End Class
