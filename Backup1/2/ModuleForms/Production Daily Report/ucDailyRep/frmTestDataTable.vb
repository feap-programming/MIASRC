Public Class FrmTestDataTable
    Private Sub FrmTestDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadGridView1.DataSource = globalVariables.TestDT
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        OpenFileDialog.ShowDialog()
        Dim dtDefects As New DataTable
        If OpenFileDialog.FileName = "" Then

        Else

            Dim FilePath As String = OpenFileDialog.FileName
            Dim path As String = Environment.CurrentDirectory + "\Ephemeral\Dupe.xlsx"
            My.Computer.FileSystem.CopyFile(FilePath, Environment.CurrentDirectory + "\Ephemeral\Dupe.xlsx", overwrite:=True)

            '---------------Excel to Datatable

            Using con As OleDb.OleDbConnection = New OleDb.OleDbConnection()

                con.ConnectionString = String.Format("Provider={0};Data Source={1};Extended Properties=""Excel 12.0 XML;HDR=Yes;""", "Microsoft.ACE.OLEDB.12.0", path)

                Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [SRC ASSEMBLY$]", con)
                    Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        con.Open()
                        da.Fill(dtDefects)
                        con.Close()
                    End Using
                End Using

            End Using

            RadGridView1.DataSource = dtDefects

        End If

    End Sub
End Class
