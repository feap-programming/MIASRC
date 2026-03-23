Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmEditBOMItem

    Private origTitle As String
    Private origDocNo As String
    Private origRefNo As String
    Private origEstDate As Date
    Private origRevDate As Date
    Private origImplemDate As Date
    Private origPreparedBy As String
    Private origCheckedBy As String
    Private origApprovedBy As String

    Private Sub FrmEditBOMItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        dtpEstDate.Format = DateTimePickerFormat.Custom
        dtpEstDate.CustomFormat = "MMM dd, yyyy"
        dtpEstDate.Value = Today

        dtpRevDate.Format = DateTimePickerFormat.Custom
        dtpRevDate.CustomFormat = "MMM dd, yyyy"
        dtpRevDate.Value = Today

        dtpImplemDate.Format = DateTimePickerFormat.Custom
        dtpImplemDate.CustomFormat = "MMM dd, yyyy"
        dtpImplemDate.Value = Today

        loadTitle()
    End Sub

    Private Sub loadTitle()

        Slipknot.addParameter("parId", txtID.Text)
        Dim title As DataTable = Slipknot.dbSelect("SP_SelectBOMTitleByID")

        If title.Rows.Count > 0 Then

            origTitle = Convert.ToString(title.Rows(0).Item("fldTitle"))
            origDocNo = Convert.ToString(title.Rows(0).Item("fldDocumentNo"))
            origRefNo = Convert.ToString(title.Rows(0).Item("fldReferenceNo"))
            origEstDate = Convert.ToDateTime(title.Rows(0).Item("fldEstDate"))
            origRevDate = Convert.ToDateTime(title.Rows(0).Item("fldRevDate"))
            origImplemDate = Convert.ToDateTime(title.Rows(0).Item("fldImplemDate"))
            origPreparedBy = Convert.ToString(title.Rows(0).Item("fldPreparedBy"))
            origCheckedBy = Convert.ToString(title.Rows(0).Item("fldCheckedBy"))
            origApprovedBy = Convert.ToString(title.Rows(0).Item("fldApprovedBy"))

            txtTitle.Text = origTitle
            txtDocuNo.Text = origDocNo
            txtRefNo.Text = origRefNo
            dtpEstDate.Value = origEstDate
            dtpRevDate.Value = origRevDate
            dtpImplemDate.Value = origImplemDate
            txtPreparedBy.Text = origPreparedBy
            txtCheckedBy.Text = origCheckedBy
            txtApprovedBy.Text = origApprovedBy
        End If

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtTitle.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Title cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            txtTitle.Text = origTitle
            Exit Sub
        End If

        Slipknot.addParameter("parId", txtID.Text)
        Slipknot.addParameter("parTitle", txtTitle.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parDocumentNo", txtDocuNo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parReferenceNo", txtRefNo.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parEstDate", dtpEstDate.Value)
        Slipknot.addParameter("parRevDate", dtpRevDate.Value)
        Slipknot.addParameter("parImplemDate", dtpImplemDate.Value)
        Slipknot.addParameter("parPreparedBy", txtPreparedBy.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parCheckedBy", txtCheckedBy.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parApprovedBy", txtApprovedBy.Text.TrimStart.TrimEnd)

        If Slipknot.dbAED("SP_UpdateBOMTitleByID") Then
            RadMessageBox.Show("Updated Successfully!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)

            origTitle = txtTitle.Text
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
