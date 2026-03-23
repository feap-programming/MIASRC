Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class FrmTest
    Private Sub FrmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblTest")

        RadGridView1.DataSource = dt


    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

        Dim itemCode As String
        Dim price As Decimal

        For Each row As GridViewRowInfo In RadGridView1.Rows

            itemCode = Convert.ToString(row.Cells("fldItemCode").Value)
            price = Convert.ToDecimal(row.Cells("fldPrice").Value)

            Slipknot.addParameter("parItemCode", itemCode.TrimStart.TrimEnd)
            Slipknot.addParameter("parPrice", price)

            Slipknot.dbAED("test")

        Next

        MsgBox("Done")

    End Sub
End Class
