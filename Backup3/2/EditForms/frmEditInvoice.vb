Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmEditInvoice

    Private dbMIA As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dbHRMSlive As New DB("192.168.191.252", "dbHRMSlive", My.Settings.setDBUID, My.Settings.setDBPWD)

    Private Property InvoiceID As Int64 = 0
    Public Property Saved As Boolean = False

    Private Sub FrmCreateInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        LoadCustomerDropDown(mcbCustomer)
        LoadCustomerRefDropDown(mcbSoldTo)
        LoadCustomerRefDropDown(mcbShippedTo)
        LoadFreightConditionDropDown(mcbFreightCondition)
        LoadPreparedByDropDown(mcbPreparedBy)
        LoadCheckedByDropDown(mcbCheckedBy)
        LoadNotedByDropDown(mcbNotedBy)
        LoadApprovedByDropDown(mcbApprovedBy)
        LoadBIRReferenceDropDown(mcbBIRReference)

        GetInvoice(Me.InvoiceID)

    End Sub

    Private Sub cbETDFEAP_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbETDFEAP.ToggleStateChanged
        If cbETDFEAP.Checked Then
            dtETDFEAP.Enabled = True
        Else
            dtETDFEAP.Enabled = False
        End If
    End Sub

    Private Sub cbETDManila_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbETDManila.ToggleStateChanged
        If cbETDManila.Checked Then
            dtETDManila.Enabled = True
        Else
            dtETDManila.Enabled = False
        End If
    End Sub

    Private Sub cbATDFEAP_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbATDFEAP.ToggleStateChanged
        If cbATDFEAP.Checked Then
            dtATDFEAP.Enabled = True
        Else
            dtATDFEAP.Enabled = False
        End If
    End Sub

    Private Sub cbATDManila_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbATDManila.ToggleStateChanged
        If cbATDManila.Checked Then
            dtATDManila.Enabled = True
        Else
            dtATDManila.Enabled = False
        End If
    End Sub

    Private Sub cbATACustomer_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbATACustomer.ToggleStateChanged
        If cbATACustomer.Checked Then
            dtATACustomer.Enabled = True
        Else
            dtATACustomer.Enabled = False
        End If
    End Sub

    'Private Sub drpCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles drpCurrency.SelectedIndexChanged

    '    If drpCurrency.Text = "JPY" Then
    '        lblForex.Text = "Forex (JPY)"
    '        numForex.Value = 0
    '    ElseIf drpCurrency.Text = "PHP" Then
    '        lblForex.Text = "Forex (PHP)"
    '        numForex.Value = 1
    '    ElseIf drpCurrency.Text = "USD" Then
    '        lblForex.Text = "Forex (USD)"
    '        numForex.Value = 0
    '    Else
    '        lblForex.Text = "Forex (XXX)"
    '        numForex.Value = 0
    '    End If

    'End Sub

    Private Sub btnUpdateInvoice_Click(sender As Object, e As EventArgs) Handles btnUpdateInvoice.Click

        Try

            Dim notNullList As String = String.Empty

            notNullList &= IIf(String.IsNullOrWhiteSpace(mcbCustomer.SelectedValue), Environment.NewLine & "Customer", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(drpActivity.Text), Environment.NewLine & "Activity", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(mcbSoldTo.SelectedValue), Environment.NewLine & "Sold To", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(mcbShippedTo.SelectedValue), Environment.NewLine & "Shipped To", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(drpCurrency.Text), Environment.NewLine & "Currency", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(drpInvoiceUOM.Text), Environment.NewLine & "Invoice UOM", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(mcbPreparedBy.SelectedValue), Environment.NewLine & "Prepared By", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(mcbCheckedBy.SelectedValue), Environment.NewLine & "Checked By", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(mcbNotedBy.SelectedValue), Environment.NewLine & "Noted By", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(mcbApprovedBy.SelectedValue), Environment.NewLine & "Approved By", "")
            notNullList &= IIf(String.IsNullOrWhiteSpace(mcbBIRReference.SelectedValue), Environment.NewLine & "BIR Reference", "")

            If String.IsNullOrWhiteSpace(notNullList) Then

                Dim confirmResult As DialogResult = RadMessageBox.Show(Me, "Please confirm to update Invoice with invoice no. " & numInvoiceNo.Value, "SAVING",
                                                            MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
                If confirmResult = DialogResult.Yes Then

                    Slipknot.addParameter("parInvoiceID", Me.InvoiceID)
                    Slipknot.addParameter("parCustomer", IIf(Not String.IsNullOrWhiteSpace(mcbCustomer.SelectedValue), mcbCustomer.SelectedValue, ""))
                    Slipknot.addParameter("parActivity", drpActivity.Text)
                    Slipknot.addParameter("parDescription", Regex.Replace(Trim(txtDescription.Text), "\s+", " "))
                    Slipknot.addParameter("parInvoiceDate", dtInvoiceDate.Value)
                    Slipknot.addParameter("parETDFEAP", IIf(cbETDFEAP.Checked, dtETDFEAP.Value, New Date(1, 1, 1)))
                    Slipknot.addParameter("parATDFEAP", IIf(cbATDFEAP.Checked, dtATDFEAP.Value, New Date(1, 1, 1)))
                    Slipknot.addParameter("parETDManila", IIf(cbETDManila.Checked, dtETDManila.Value, New Date(1, 1, 1)))
                    Slipknot.addParameter("parATDManila", IIf(cbATDManila.Checked, dtATDManila.Value, New Date(1, 1, 1)))
                    Slipknot.addParameter("parATACustomer", IIf(cbATACustomer.Checked, dtATACustomer.Value, New Date(1, 1, 1)))
                    Slipknot.addParameter("parDRNo", Regex.Replace(Trim(txtDRNo.Text), "\s+", " "))
                    Slipknot.addParameter("parPONo", Regex.Replace(Trim(txtPONo.Text), "\s+", " "))
                    Slipknot.addParameter("parPCNo", Regex.Replace(Trim(txtPCNo.Text), "\s+", " "))
                    Slipknot.addParameter("parSoldTo", IIf(Not String.IsNullOrWhiteSpace(mcbSoldTo.SelectedValue), mcbSoldTo.SelectedValue, 0))
                    Slipknot.addParameter("parShippedTo", IIf(Not String.IsNullOrWhiteSpace(mcbShippedTo.SelectedValue), mcbShippedTo.SelectedValue, 0))
                    Slipknot.addParameter("parTerms", Regex.Replace(Trim(txtTerms.Text), "\s+", " "))
                    Slipknot.addParameter("parCurrency", drpCurrency.Text)
                    Slipknot.addParameter("parForex", numForex.Value)
                    Slipknot.addParameter("parForexUSD", numForexUSD.Value)
                    Slipknot.addParameter("parShipVia", Regex.Replace(Trim(drpShipVia.Text), "\s+", " "))
                    Slipknot.addParameter("parSailingOnOrAbout", dtSailingOnOrAbout.Value)
                    Slipknot.addParameter("parFreightTerms", Regex.Replace(Trim(txtFreightTerms.Text), "\s+", " "))
                    Slipknot.addParameter("parFreightCondition", mcbFreightCondition.Text)
                    Slipknot.addParameter("parNoOfPackages", Regex.Replace(Trim(txtNoOfPackages.Text), "\s+", " "))
                    Slipknot.addParameter("parRemarks", Regex.Replace(Trim(txtRemarks.Text), "\s+", " "))
                    Slipknot.addParameter("parInvoiceUOM", drpInvoiceUOM.Text)
                    Slipknot.addParameter("parPreparedBy", IIf(Not String.IsNullOrWhiteSpace(mcbPreparedBy.SelectedValue), mcbPreparedBy.SelectedValue, ""))
                    Slipknot.addParameter("parCheckedBy", IIf(Not String.IsNullOrWhiteSpace(mcbCheckedBy.SelectedValue), mcbCheckedBy.SelectedValue, ""))
                    Slipknot.addParameter("parNotedBy", IIf(Not String.IsNullOrWhiteSpace(mcbNotedBy.SelectedValue), mcbNotedBy.SelectedValue, ""))
                    Slipknot.addParameter("parApprovedBy", IIf(Not String.IsNullOrWhiteSpace(mcbApprovedBy.SelectedValue), mcbApprovedBy.SelectedValue, ""))
                    Slipknot.addParameter("parBIRReferenceID", IIf(Not String.IsNullOrWhiteSpace(mcbBIRReference.SelectedValue), mcbBIRReference.SelectedValue, 0))
                    If Slipknot.dbAED("SP_P_UpdateInvoice") Then
                        RadMessageBox.Show("Invoice successfully updated.", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                        Saved = True
                        Me.Close()
                    End If

                End If

            Else

                RadMessageBox.Show("The following field/s are required:" & Environment.NewLine & notNullList, "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            End If

        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try

    End Sub

    Private Sub GetInvoice(invoiceID As Int64)

        dbMIA.AddMySqlParameters("parInvoiceID", invoiceID)
        Dim myData As DataTable = dbMIA.SPSelect("SP_P_SelectInvoiceByID")

        If myData.Rows.Count > 0 Then

            Dim DR As DataRow = myData.Rows(0)
            numInvoiceNo.Value = DR.Item("fldInvoiceNo")
            mcbCustomer.SelectedValue = DR.Item("fldCustomer")
            drpActivity.SelectedIndex = drpActivity.FindStringExact(DR.Item("fldActivity"))
            txtDescription.Text = DR.Item("fldDescription")
            dtInvoiceDate.Value = DR.Item("fldInvoiceDate")
            If DR.Item("fldETDFEAP") <> "0001-01-01" Then
                dtETDFEAP.Value = DR.Item("fldETDFEAP")
                cbETDFEAP.CheckState = CheckState.Checked
            Else
                dtETDFEAP.Value = Today
                cbETDFEAP.CheckState = CheckState.Unchecked
            End If
            If DR.Item("fldETDManila") <> "0001-01-01" Then
                dtETDManila.Value = DR.Item("fldETDManila")
                cbETDManila.CheckState = CheckState.Checked
            Else
                dtETDManila.Value = Today
                cbETDManila.CheckState = CheckState.Unchecked
            End If
            If DR.Item("fldATDFEAP") <> "0001-01-01" Then
                dtATDFEAP.Value = DR.Item("fldATDFEAP")
                cbATDFEAP.CheckState = CheckState.Checked
            Else
                dtATDFEAP.Value = Today
                cbATDFEAP.CheckState = CheckState.Unchecked
            End If
            If DR.Item("fldATDManila") <> "0001-01-01" Then
                dtATDManila.Value = DR.Item("fldATDManila")
                cbATDManila.CheckState = CheckState.Checked
            Else
                dtATDManila.Value = Today
                cbATDManila.CheckState = CheckState.Unchecked
            End If
            If DR.Item("fldATACustomer") <> "0001-01-01" Then
                dtATACustomer.Value = DR.Item("fldATACustomer")
                cbATACustomer.CheckState = CheckState.Checked
            Else
                dtATACustomer.Value = Today
                cbATACustomer.CheckState = CheckState.Unchecked
            End If
            txtDRNo.Text = DR.Item("fldDRNo")
            txtPONo.Text = DR.Item("fldPONo")
            txtPCNo.Text = DR.Item("fldPCNo")
            mcbSoldTo.SelectedValue = DR.Item("fldSoldTo")
            mcbShippedTo.SelectedValue = DR.Item("fldShippedTo")
            txtTerms.Text = DR.Item("fldTerms")
            drpCurrency.SelectedIndex = drpCurrency.FindStringExact(DR.Item("fldCurrency"))
            numForex.Value = DR.Item("fldForex")
            numForexUSD.Value = DR.Item("fldForexUSD")
            drpShipVia.SelectedIndex = drpShipVia.FindStringExact(DR.Item("fldShipVia"))
            dtSailingOnOrAbout.Value = DR.Item("fldSailingOnOrAbout")
            txtFreightTerms.Text = DR.Item("fldFreightTerms")
            mcbFreightCondition.SelectedValue = DR.Item("fldFreightCondition")
            txtNoOfPackages.Text = DR.Item("fldNoOfPackages")
            txtRemarks.Text = DR.Item("fldRemarks")
            drpInvoiceUOM.SelectedIndex = drpInvoiceUOM.FindStringExact(DR.Item("fldInvoiceUOM"))
            mcbPreparedBy.SelectedValue = DR.Item("fldPreparedBy")
            mcbCheckedBy.SelectedValue = DR.Item("fldCheckedBy")
            mcbNotedBy.SelectedValue = DR.Item("fldNotedBy")
            mcbApprovedBy.SelectedValue = DR.Item("fldApprovedBy")
            mcbBIRReference.SelectedValue = DR.Item("fldBIRReferenceID")

        End If

    End Sub

    Private Function HasDuplicateInvoiceNo(invoiceNo As Int64) As Boolean

        dbMIA.AddMySqlParameters("parInvoiceNo", invoiceNo)
        dbMIA.AddMySqlParameters("parHasDuplicate", False)
        Return Convert.ToInt64(dbMIA.SPOutput("SP_P_HasDuplicateInvoiceNo", "parHasDuplicate")("parHasDuplicate"))

    End Function

    Public Overloads Sub ShowDialog(invoiceID As Int64)
        Me.InvoiceID = invoiceID
        Me.ShowDialog()
    End Sub

    Private Sub LoadCustomerDropDown(mcb As RadMultiColumnComboBox)

        Dim fldId As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldId",
            .Width = 80,
            .IsVisible = False
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldId)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUST. CODE") With {
            .FieldName = "fldCustomerCode",
            .Width = 100
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .Width = 120
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldCustomerName)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_SelectAllCustomers")
        mcb.DataSource = dtCustomer
        mcb.DisplayMember = "fldCustomerName"
        mcb.ValueMember = "fldCustomerCode"
        mcb.MultiColumnComboBoxElement.DropDownWidth = 270

        mcb.AutoFilter = True
        mcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerPartNo As New FilterDescriptor With {
            .PropertyName = "fldCustomerName",
            .Operator = FilterOperator.Contains
        }
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(customerPartNo)

        mcb.SelectedIndex = -1
        mcb.Text = String.Empty

    End Sub

    Private Sub LoadCustomerRefDropDown(mcb As RadMultiColumnComboBox)

        Dim fldId As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldId",
            .Width = 80,
            .IsVisible = False
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldId)

        Dim fldName As New GridViewTextBoxColumn("NAME") With {
            .FieldName = "fldName",
            .Width = 200
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldName)

        Dim fldAddress As New GridViewTextBoxColumn("ADDRESS") With {
            .FieldName = "fldAddress",
            .Width = 250
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldAddress)

        Dim fldTelNo As New GridViewTextBoxColumn("TEL NO") With {
            .FieldName = "fldTelNo",
            .Width = 150
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldTelNo)

        Dim fldFaxNo As New GridViewTextBoxColumn("FAX NO") With {
            .FieldName = "fldFaxNo",
            .Width = 150
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldFaxNo)

        Dim fldBusinessStyle As New GridViewTextBoxColumn("BUSINESS STYLE") With {
            .FieldName = "fldBusinessStyle",
            .Width = 180
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldBusinessStyle)

        Dim fldCountryOrigin As New GridViewTextBoxColumn("COUNTRY ORIGIN") With {
            .FieldName = "fldCountryOrigin",
            .Width = 180
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldCountryOrigin)

        Dim fldTIN As New GridViewTextBoxColumn("TIN") With {
            .FieldName = "fldTIN",
            .Width = 150
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldTIN)

        Dim fldContactPerson As New GridViewTextBoxColumn("CONTACT PERSON") With {
            .FieldName = "fldContactPerson",
            .Width = 200
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldContactPerson)

        Dim fldContactPosition As New GridViewTextBoxColumn("POSITION") With {
            .FieldName = "fldContactPosition",
            .Width = 200
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldContactPosition)

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_P_SelectAllCustomerReference")
        mcb.DataSource = dtCustomer
        mcb.DisplayMember = "fldName"
        mcb.ValueMember = "fldID"
        mcb.MultiColumnComboBoxElement.DropDownWidth = 500

        mcb.AutoFilter = True
        mcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim customerName As New FilterDescriptor With {
            .PropertyName = "fldName",
            .Operator = FilterOperator.Contains
        }
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(customerName)

        mcb.SelectedIndex = -1
        mcb.Text = String.Empty

    End Sub

    Private Sub LoadFreightConditionDropDown(mcb As RadMultiColumnComboBox)

        Dim FldValue As New GridViewTextBoxColumn("VALUE") With {
            .FieldName = "FldValue",
            .Width = 70
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(FldValue)

        Dim Descr As New GridViewTextBoxColumn("DESCRIPTION") With {
            .FieldName = "Descr",
            .Width = 200
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(Descr)

        Dim dtFreightCondition As DataTable = SAP.dbSelect("SP_SelectAllFreightCondition")
        mcb.DataSource = dtFreightCondition
        mcb.DisplayMember = "Descr"
        mcb.ValueMember = "Descr"
        mcb.MultiColumnComboBoxElement.DropDownWidth = 270

        mcb.AutoFilter = True
        mcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim desc As New FilterDescriptor With {
            .PropertyName = "Descr",
            .Operator = FilterOperator.Contains
        }
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(desc)

        mcb.SelectedIndex = -1
        mcb.Text = String.Empty

    End Sub

    Private Sub LoadPreparedByDropDown(mcb As RadMultiColumnComboBox)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO") With {
            .FieldName = "fldEmpNo",
            .Width = 80
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpNo)

        Dim fldEmpFullName As New GridViewTextBoxColumn("FULL NAME") With {
            .FieldName = "fldEmpFullName",
            .Width = 200
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpFullName)

        dbHRMSlive.AddMySqlParameters("parDepartment", "PC/LOG")
        dbHRMSlive.AddMySqlParameters("parSection", "LOG")
        dbHRMSlive.AddMySqlParameters("parJobTitle", "LOG-05,LOG-11,LOG-12,LOG-14")
        Dim dtFreightCondition As DataTable = dbHRMSlive.SPSelect("SP_SelectEmployeeByJobTitlePerSection")
        mcb.DataSource = dtFreightCondition
        mcb.DisplayMember = "fldEmpFullName"
        mcb.ValueMember = "fldEmpNo"
        mcb.MultiColumnComboBoxElement.DropDownWidth = 330

        mcb.AutoFilter = True
        mcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor With {
            .PropertyName = "fldEmpFullName",
            .Operator = FilterOperator.Contains
        }
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

        mcb.SelectedIndex = -1
        mcb.Text = String.Empty

    End Sub

    Private Sub LoadCheckedByDropDown(mcb As RadMultiColumnComboBox)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO") With {
            .FieldName = "fldEmpNo",
            .Width = 80
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpNo)

        Dim fldEmpFullName As New GridViewTextBoxColumn("FULL NAME") With {
            .FieldName = "fldEmpFullName",
            .Width = 200
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpFullName)

        dbHRMSlive.AddMySqlParameters("parDepartment", "PC/LOG")
        dbHRMSlive.AddMySqlParameters("parSection", "LOG")
        dbHRMSlive.AddMySqlParameters("parJobTitle", "LOG-01")
        Dim dtFreightCondition As DataTable = dbHRMSlive.SPSelect("SP_SelectEmployeeByJobTitlePerSection")
        mcb.DataSource = dtFreightCondition
        mcb.DisplayMember = "fldEmpFullName"
        mcb.ValueMember = "fldEmpNo"
        mcb.MultiColumnComboBoxElement.DropDownWidth = 330

        mcb.AutoFilter = True
        mcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor With {
            .PropertyName = "fldEmpFullName",
            .Operator = FilterOperator.Contains
        }
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

        mcb.SelectedIndex = -1
        mcb.Text = String.Empty

    End Sub

    Private Sub LoadNotedByDropDown(mcb As RadMultiColumnComboBox)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO") With {
            .FieldName = "fldEmpNo",
            .Width = 80
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpNo)

        Dim fldEmpFullName As New GridViewTextBoxColumn("FULL NAME") With {
            .FieldName = "fldEmpFullName",
            .Width = 200
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpFullName)

        dbHRMSlive.AddMySqlParameters("parDepartment", "PC/LOG")
        dbHRMSlive.AddMySqlParameters("parSection", "OA")
        dbHRMSlive.AddMySqlParameters("parJobTitle", "PC-01")
        Dim dtFreightCondition As DataTable = dbHRMSlive.SPSelect("SP_SelectEmployeeByJobTitlePerSection")
        mcb.DataSource = dtFreightCondition
        mcb.DisplayMember = "fldEmpFullName"
        mcb.ValueMember = "fldEmpNo"
        mcb.MultiColumnComboBoxElement.DropDownWidth = 330

        mcb.AutoFilter = True
        mcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor With {
            .PropertyName = "fldEmpFullName",
            .Operator = FilterOperator.Contains
        }
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

        mcb.SelectedIndex = -1
        mcb.Text = String.Empty

    End Sub

    Private Sub LoadApprovedByDropDown(mcb As RadMultiColumnComboBox)

        Dim fldEmpNo As New GridViewTextBoxColumn("EMP NO") With {
            .FieldName = "fldEmpNo",
            .Width = 80
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpNo)

        Dim fldEmpFullName As New GridViewTextBoxColumn("FULL NAME") With {
            .FieldName = "fldEmpFullName",
            .Width = 200
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldEmpFullName)

        dbHRMSlive.AddMySqlParameters("parDepartment", "ENGALL")
        dbHRMSlive.AddMySqlParameters("parSection", "OA")
        dbHRMSlive.AddMySqlParameters("parJobTitle", "DIVMNGR-01")
        Dim dtFreightCondition As DataTable = dbHRMSlive.SPSelect("SP_SelectEmployeeByJobTitlePerSection")
        mcb.DataSource = dtFreightCondition
        mcb.DisplayMember = "fldEmpFullName"
        mcb.ValueMember = "fldEmpNo"
        mcb.MultiColumnComboBoxElement.DropDownWidth = 330

        mcb.AutoFilter = True
        mcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor With {
            .PropertyName = "fldEmpFullName",
            .Operator = FilterOperator.Contains
        }
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

        mcb.SelectedIndex = -1
        mcb.Text = String.Empty

    End Sub

    Private Sub LoadBIRReferenceDropDown(mcb As RadMultiColumnComboBox)

        Dim fldId As New GridViewTextBoxColumn("ID") With {
            .FieldName = "fldId",
            .Width = 80,
            .IsVisible = False
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldId)

        Dim fldPermitNo As New GridViewTextBoxColumn("PERMIT NO") With {
            .FieldName = "fldPermitNo",
            .Width = 150
        }
        mcb.MultiColumnComboBoxElement.Columns.Add(fldPermitNo)

        Dim fldDateIssued As New GridViewDateTimeColumn("DATE ISSUED") With {
            .FieldName = "fldDateIssued",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "dd-MMM-yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        mcb.Columns.Add(fldDateIssued)
        mcb.Columns("fldDateIssued").FormatString = "{0:dd-MMM-yyyy}"

        Dim dtCustomer As DataTable = Slipknot.dbSelect("SP_P_SelectAllBIRReference")
        mcb.DataSource = dtCustomer
        mcb.DisplayMember = "fldPermitNo"
        mcb.ValueMember = "fldId"
        mcb.MultiColumnComboBoxElement.DropDownWidth = 350

        mcb.AutoFilter = True
        mcb.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim oermitNo As New FilterDescriptor With {
            .PropertyName = "fldPermitNo",
            .Operator = FilterOperator.Contains
        }
        mcb.EditorControl.MasterTemplate.FilterDescriptors.Add(oermitNo)

        mcb.SelectedIndex = -1
        mcb.Text = String.Empty

    End Sub

End Class
