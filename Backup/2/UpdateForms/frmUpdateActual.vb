Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmUpdateActual

    Private myDB As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)

    Private Sub FrmUpdateActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        LoadDropDown(mcbInvoiceNo)

        dtATDFEAP.Value = Today
        dtATDManila.Value = Today
        dtATACustomer.Value = Today

        dtATDFEAP.Value = Nothing
        dtATDManila.Value = Nothing
        dtATACustomer.Value = Nothing
    End Sub

    Private Sub cbATDFEAP_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbATDFEAP.ToggleStateChanged
        If cbATDFEAP.Checked Then
            dtATDFEAP.Enabled = True
        Else
            dtATDFEAP.Enabled = False
            dtATDFEAP.Value = Nothing
        End If
    End Sub

    Private Sub cbATDManila_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbATDManila.ToggleStateChanged
        If cbATDManila.Checked Then
            dtATDManila.Enabled = True
        Else
            dtATDManila.Enabled = False
            dtATDManila.Value = Nothing
        End If
    End Sub

    Private Sub cbATACustomer_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles cbATACustomer.ToggleStateChanged
        If cbATACustomer.Checked Then
            dtATACustomer.Enabled = True
        Else
            dtATACustomer.Enabled = False
            dtATACustomer.Value = Nothing
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            Dim notSaved As String = String.Empty

            If (Not String.IsNullOrEmpty(mcbInvoiceNo.SelectedValue)) AndAlso
                (((Not dtATDFEAP.Value = Nothing) AndAlso (cbATDFEAP.Checked)) OrElse (Not cbATDFEAP.Checked)) AndAlso
                (((Not dtATDManila.Value = Nothing) AndAlso (cbATDManila.Checked)) OrElse (Not cbATDManila.Checked)) AndAlso
                (((Not dtATACustomer.Value = Nothing) AndAlso (cbATACustomer.Checked)) OrElse (Not cbATACustomer.Checked)) Then

                Dim result As DialogResult = RadMessageBox.Show(Me, "Please confirm to update Invoice.", "Saving", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
                If result = DialogResult.Yes Then

                    myDB.AddMySqlParameters("parInvoiceNo", Me.mcbInvoiceNo.SelectedValue)
                    myDB.AddMySqlParameters("parATDFEAP", If((cbATDFEAP.Checked), Me.dtATDFEAP.Value, Nothing))
                    myDB.AddMySqlParameters("parATDManila", If((cbATDManila.Checked), Me.dtATDManila.Value, Nothing))
                    myDB.AddMySqlParameters("parATACustomer", If((cbATACustomer.Checked), Me.dtATACustomer.Value, Nothing))
                    myDB.SPADE("SP_P_UpdateAllActualInvoiceNo")

                    RadMessageBox.Show("Invoice successfully updated.", "Success", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Me.Close()

                End If

            Else
                    RadMessageBox.Show("Please completely fill out the form.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try

    End Sub

    Public Sub LoadDropDown(gvMCCB As RadMultiColumnComboBox)

        Dim fldInvoiceNo As New GridViewTextBoxColumn("INVOICE NO.") With {
            .FieldName = "fldInvoiceNo",
            .Width = 120
        }
        gvMCCB.MultiColumnComboBoxElement.Columns.Add(fldInvoiceNo)

        Dim dtAllActualInvoiceNo As DataTable = Slipknot.dbSelect("SP_P_SelectAllActualInvoiceNo")
        gvMCCB.DataSource = dtAllActualInvoiceNo
        gvMCCB.DisplayMember = "fldInvoiceNo"
        gvMCCB.ValueMember = "fldInvoiceNo"
        gvMCCB.MultiColumnComboBoxElement.DropDownWidth = 165

        gvMCCB.AutoFilter = True
        gvMCCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim invoiceNo As New FilterDescriptor With {
            .PropertyName = "fldInvoiceNo",
            .Operator = FilterOperator.Contains
        }
        gvMCCB.EditorControl.MasterTemplate.FilterDescriptors.Add(invoiceNo)

        gvMCCB.SelectedIndex = -1
        gvMCCB.Text = String.Empty

    End Sub

End Class
