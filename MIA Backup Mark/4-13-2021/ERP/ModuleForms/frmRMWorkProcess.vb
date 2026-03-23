Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmRMWorkProcess
    Private Sub FrmRMWorkProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        readyGrid()
        readRM()
    End Sub

    Private Sub FrmRMWorkProcess_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchRMWorkProcessbyPOSPID()

    End Sub
    Public Sub FetchRMWorkProcessbyPOSPID()
        Slipknot.addParameter("POSPID", txtPOSPID.Text)
        gvData.DataSource = Slipknot.dbSelect("SP_SelectRMWorkProcessbyPOSPID")
        leCountRec.Text = gvData.Rows.Count
    End Sub
    Private Sub readyGrid()
        Dim fldHID As New GridViewDecimalColumn("RMID") With {
            .FieldName = "fldRMID",
            .IsVisible = True
        }
        gvData.Columns.Add(fldHID)

        Dim fldId As New GridViewDecimalColumn("MainID") With {
            .FieldName = "fldMainID",
            .IsVisible = False
        }
        gvData.Columns.Add(fldId)

        Dim fldPOSPID As New GridViewDecimalColumn("POSPID") With {
            .FieldName = "fldPOSPID",
            .IsVisible = False
        }
        gvData.Columns.Add(fldPOSPID)

        Dim fldTime As New GridViewTextBoxColumn("Time") With {
            .FieldName = "fldTime",
            .Width = 120,
            .IsVisible = True
        }
        gvData.Columns.Add(fldTime)

        Dim fldTrayNo As New GridViewTextBoxColumn("Tray No") With {
            .FieldName = "fldTrayNo",
            .Width = 200,
            .IsVisible = True
        }
        gvData.Columns.Add(fldTrayNo)

        Dim fldCategory As New GridViewTextBoxColumn("Category") With {
            .FieldName = "fldCategory",
            .Width = 120,
            .IsVisible = True
        }
        gvData.Columns.Add(fldCategory)

        'Dim fldScrapQTY As New GridViewTextBoxColumn("Scrap QTY") With {
        '    .FieldName = "fldScrapQTY",
        '    .Width = 120,
        '    .IsVisible = True
        '}
        'gvData.Columns.Add(fldScrapQTY)

        'Dim fldAdj As New GridViewTextBoxColumn("Adjustment") With {
        '    .FieldName = "fldAdj",
        '    .Width = 120,
        '    .IsVisible = True
        '}
        'gvData.Columns.Add(fldAdj)

        'Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED") With {
        '    .FieldName = "fldDateAdded",
        '    .Width = 150,
        '    .Format = DateTimePickerFormat.Custom,
        '    .CustomFormat = "MMM dd, yyyy HH:mm"
        '}
        'gvData.Columns.Add(fldDateAdded)
        'gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        'Dim fldSolderAss As New GridViewTextBoxColumn("Solder Assembly") With {
        '    .FieldName = "fldSolderAss",
        '    .Width = 120,
        '    .IsVisible = True
        '}
        'gvData.Columns.Add(fldSolderAss)

        'Dim fldPCB As New GridViewTextBoxColumn("PCB Dividing") With {
        '    .FieldName = "fldPCB",
        '    .Width = 120,
        '    .IsVisible = True
        '}
        'gvData.Columns.Add(fldPCB)


        gvData.ReadOnly = True
        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25
    End Sub

    Private Sub readRM()

        Dim fldItemCode As New GridViewTextBoxColumn("Item Code") With {
            .FieldName = "fldItemCode",
            .Width = 120,
            .ReadOnly = True
        }
        gvRm.Columns.Add(fldItemCode)

        Dim fldProcessName As New GridViewTextBoxColumn("Part Name") With {
            .FieldName = "fldPartName",
            .Width = 180,
            .ReadOnly = True
        }
        gvRm.Columns.Add(fldProcessName)

        Dim fldLotNo As New GridViewTextBoxColumn("Lot No") With {
            .FieldName = "fldLotNo",
            .Width = 250
        }
        gvRm.Columns.Add(fldLotNo)

        Dim fldSolderAss As New GridViewComboBoxColumn("Solder") With {
            .FieldName = "fldSolderAss",
            .Width = 100,
            .DropDownStyle = RadDropDownStyle.DropDownList,
            .DataSource = New [String]() {"YES", "NO"}
        }
        gvRm.Columns.Add(fldSolderAss)

        Dim fldPCB As New GridViewComboBoxColumn("PCB") With {
            .FieldName = "fldPCB",
            .Width = 100,
            .DropDownStyle = RadDropDownStyle.DropDownList,
            .DataSource = New [String]() {"YES", "NO"}
        }
        gvRm.Columns.Add(fldPCB)

        Dim fldPCBValidityDate As New GridViewDateTimeColumn("Validity Date") With {
            .FieldName = "fldPCBValidityDate",
            .Width = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy"
        }
        gvRm.Columns.Add(fldPCBValidityDate)
        gvRm.Columns("fldPCBValidityDate").FormatString = "{0:MMM dd, yyyy}"

        gvRm.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        gvRm.AllowAddNewRow = False
        gvRm.ShowFilteringRow = False
        gvRm.ShowGroupPanel = False
        gvRm.EnableSorting = False
        gvRm.AllowColumnReorder = False
        gvRm.AllowRowReorder = False

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        If txtTrayNo.Text = "" Then
            RadMessageBox.Show("Tray No cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txtTrayNo.Select()
            Exit Sub
        End If

        Slipknot.addParameter("MainID", Convert.ToInt32(txtMainID.Text))
        Slipknot.addParameter("POSPID", Convert.ToInt32(txtPOSPID.Text))
        Slipknot.addParameter("_Time", rtpTime.Value)
        Slipknot.addParameter("TrayNo", Convert.ToString(txtTrayNo.Text))
        Slipknot.addParameter("Username", currentUser.Item("fldUsername"))
        Slipknot.addParameter("Category", Convert.ToString(mcbProcess.Text))
        Slipknot.dbAED("SP_InsertRMWorkProcess")
        FetchRMWorkProcessbyPOSPID()
        Dim dtTime As DateTime = rtpTime.Value
        rtpTime.Value = dtTime.AddHours(1)
        txtTrayNo.Text = ""
    End Sub

    Private Sub btnLotNo_Click(sender As Object, e As EventArgs) Handles btnLotNo.Click
        If gvData.Rows.Count > 0 Then
            If (mcbProcess.Text = "POST PROCESS ASSEMBLY(BEFORE OVEN)") Then
                If Slipknot.IsFormOpen(frmAddBSSLotNoBeforeOven) Then
                    frmAddBSSLotNoBeforeOven.Focus()
                Else
                    frmAddBSSLotNoBeforeOven.Show(Me)
                    frmAddBSSLotNoBeforeOven.txtRMID.Text = gvData.CurrentRow.Cells("fldRMID").Value

                    frmAddBSSLotNoBeforeOven.txtTime.Text = gvData.CurrentRow.Cells("fldTime").Value.ToString
                    frmAddBSSLotNoBeforeOven.txtTrayNo.Text = gvData.CurrentRow.Cells("fldTrayNo").Value.ToString
                End If
            ElseIf (mcbProcess.Text = "POST PROCESS ASSEMBLY (AFTER OVEN)") Then

                If Slipknot.IsFormOpen(FrmAddBSSLotNoAfterOven) Then
                    FrmAddBSSLotNoAfterOven.Focus()
                Else
                    FrmAddBSSLotNoAfterOven.Show(Me)
                    FrmAddBSSLotNoAfterOven.txtRMID.Text = gvData.CurrentRow.Cells("fldRMID").Value

                    FrmAddBSSLotNoAfterOven.txtTime.Text = gvData.CurrentRow.Cells("fldTime").Value.ToString
                    FrmAddBSSLotNoAfterOven.txtTrayNo.Text = gvData.CurrentRow.Cells("fldTrayNo").Value.ToString
                End If
            End If
        Else
            RadMessageBox.Show("No Record found!", "Info", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If

    End Sub

    Private Sub gvData_SelectionChanged(sender As Object, e As EventArgs) Handles gvData.SelectionChanged
        FetchRMData()
    End Sub
    Private Sub FetchRMData()

        Try
            Slipknot.addParameter("RMID", gvData.CurrentRow.Cells("fldRMID").Value)
            gvRm.DataSource = Slipknot.dbSelect("SP_SelectBSSRMandLotNobyRMID")
        Catch ex As Exception

        End Try

    End Sub
    Private Sub gvRm_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvRm.CellFormatting
        If e.CellElement.ColumnInfo.FieldName = "fldPCBValidityDate" Then
            If e.CellElement.Value = #0001-01-01# Then
                e.CellElement.ForeColor = Color.Transparent

            Else

                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            End If
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Sub cbOtherDetails_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub gvData_Click(sender As Object, e As EventArgs) Handles gvData.Click


    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                Slipknot.addParameter("RMID", gvData.CurrentRow.Cells("fldRMID").Value)
                Slipknot.dbAED("SP_DeleteRMWorkProcessbyID")
                FetchRMWorkProcessbyPOSPID()
            End If
        End If
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        FetchRMWorkProcessbyPOSPID()
        FetchRMData()
    End Sub
End Class
