Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmBSSTL
    Private Sub FrmBSSTL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        readRM()
    End Sub

    Private Sub FetchData()
        gvData.DataSource = Slipknot.dbSelect("SP_SelectAllBSSTLSL")
    End Sub

    Private Sub readRM()

        Dim fldTLID As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldTLID",
            .Width = 80,
            .ReadOnly = False
        }
        gvData.Columns.Add(fldTLID)

        Dim fldEmpNo As New GridViewTextBoxColumn("Emp No") With {
            .FieldName = "fldEmpNo",
            .Width = 120,
            .ReadOnly = True
        }
        gvData.Columns.Add(fldEmpNo)

        Dim fldName As New GridViewTextBoxColumn("Name") With {
            .FieldName = "fldName",
            .Width = 250
        }
        gvData.Columns.Add(fldName)

        Dim fldCategory As New GridViewTextBoxColumn("Category") With {
            .FieldName = "fldCategory",
            .Width = 250
        }
        gvData.Columns.Add(fldCategory)


        gvData.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvData.AllowAddNewRow = False
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.EnableSorting = False
        gvData.AllowColumnReorder = False
        gvData.AllowRowReorder = False

    End Sub


    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If txtEmpNo.Text = "" Then
            RadMessageBox.Show("Empolyee No. cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txtEmpNo.Select()
            Exit Sub
        End If
        If txtEmpName.Text = "" Then
            RadMessageBox.Show("Empolyee Name cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txtEmpName.Select()
            Exit Sub
        End If
        If RadMessageBox.Show("Are you sure you want to Save this item?",
                                "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Slipknot.addParameter("_Name", txtEmpName.Text)
            Slipknot.addParameter("EmpNo", Convert.ToString(txtEmpNo.Text))
            Slipknot.addParameter("Category", ddlCategory.Text)
            Slipknot.dbAED("SP_InsertBSSTL")
            RadMessageBox.Show("Record Saved Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
            FetchData()
        End If

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        FetchData()
    End Sub

    Private Sub FrmBSSTL_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchData()
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If RadMessageBox.Show("Are you sure you want to Delete this item?",
                             "Notification", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            Slipknot.addParameter("TLID", gvData.CurrentRow.Cells("fldTLID").Value.ToString)
            Slipknot.dbAED("SP_DeleteBSSTLByID")
            RadMessageBox.Show("Record deleted Successfully!", "Info", MessageBoxButtons.OK, RadMessageIcon.Info)
            FetchData()
        End If
    End Sub
End Class
