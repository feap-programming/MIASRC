Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmAddItemSpecs
    Private Sub FrmAddItemSpecs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        dtpEffectivityDate.Format = DateTimePickerFormat.Custom
        dtpEffectivityDate.CustomFormat = "MMM dd, yyyy"
        dtpEffectivityDate.Value = Today

        If txtId.Text <> String.Empty Then
            loadRecord()
        End If

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If txtId.Text = String.Empty Then

            Slipknot.addParameter("parItemCode", txtItemCode.Text)
            Slipknot.addParameter("parCav", seCav.Value)
            Slipknot.addParameter("parPartWeight", sePartWeight.Value)
            Slipknot.addParameter("parRunnerWeight", seRunnerWeight.Value)
            Slipknot.addParameter("parLoss", seLoss.Value)
            Slipknot.addParameter("parCollection", seCollection.Value)
            Slipknot.addParameter("parCycleTime", seCycleTime.Value)
            Slipknot.addParameter("parEffectivityDate", dtpEffectivityDate.Value)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            If Slipknot.dbAED("SP_InsertItemSpecs") Then
                RadMessageBox.Show("Successfully Added!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If

        Else

            Slipknot.addParameter("parId", txtId.Text)
            Slipknot.addParameter("parItemCode", txtItemCode.Text)
            Slipknot.addParameter("parCav", seCav.Value)
            Slipknot.addParameter("parPartWeight", sePartWeight.Value)
            Slipknot.addParameter("parRunnerWeight", seRunnerWeight.Value)
            Slipknot.addParameter("parLoss", seLoss.Value)
            Slipknot.addParameter("parCollection", seCollection.Value)
            Slipknot.addParameter("parCycleTime", seCycleTime.Value)
            Slipknot.addParameter("parEffectivityDate", dtpEffectivityDate.Value)

            If Slipknot.dbAED("SP_UpdateItemSpecs") Then
                RadMessageBox.Show("Successfully Updated!", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If

        End If

    End Sub

    Private Sub loadRecord()

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblItemSpecs WHERE fldId = '" & txtId.Text & "' LIMIT 1 ")

        If dt.Rows.Count > 0 Then

            txtItemCode.Text = Convert.ToString(dt.Rows(0).Item("fldItemCode"))
            seCav.Value = Convert.ToDecimal(dt.Rows(0).Item("fldCav"))
            sePartWeight.Value = Convert.ToDecimal(dt.Rows(0).Item("fldPartWeight"))
            seRunnerWeight.Value = Convert.ToDecimal(dt.Rows(0).Item("fldRunnerWeight"))
            seLoss.Value = Convert.ToDecimal(dt.Rows(0).Item("fldLoss"))
            seCollection.Value = Convert.ToDecimal(dt.Rows(0).Item("fldCollection"))
            seCycleTime.Value = Convert.ToDecimal(dt.Rows(0).Item("fldCycleTime"))
            dtpEffectivityDate.Value = Convert.ToDateTime(dt.Rows(0).Item("fldEffectivityDate"))

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
