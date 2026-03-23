Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmEditBusinessPartner
    Private Sub FrmEditBusinessPartner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadRecord()
    End Sub

    Private Sub loadRecord()

        Dim row As DataRow = Slipknot.rowSelectManual("SELECT fldCode, fldVendorName FROM tblVendors WHERE fldId = '" & txtID.Text & "' ")

        If row IsNot Nothing Then

            txtCode.Text = Convert.ToString(row.Item("fldCode"))
            txtName.Text = Convert.ToString(row.Item("fldVendorName"))

        End If

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If BulletForMyValentine.isRW("fldMDBusinessPartners") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If txtCode.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Invalid code!", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        If txtName.Text.TrimStart.TrimEnd = String.Empty Then
            RadMessageBox.Show("Invalid name!", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            Exit Sub
        End If

        Slipknot.addParameter("parId", txtID.Text)
        Slipknot.addParameter("parCode", txtCode.Text.TrimStart.TrimEnd)
        Slipknot.addParameter("parVendorName", txtName.Text.TrimStart.TrimEnd)

        If Slipknot.dbAED("SP_UpdateBusinessPartner") Then
            If FrmBusinessPartners.bwLoadData.IsBusy = False Then
                FrmBusinessPartners.bwLoadData.RunWorkerAsync()
            End If
        End If

    End Sub
End Class
