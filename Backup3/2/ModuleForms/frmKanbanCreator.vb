Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmKanbanCreator

    Private thisRecordID As String
    Private myData As DataTable
    Private Sub FrmKanbanCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        loadItemCode()
        loadCustomerPartNo()
        loadMachines()
        loadUOM()

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldId As New GridViewDecimalColumn("ID")
        fldId.FieldName = "fldId"
        fldId.IsVisible = False
        fldId.ReadOnly = True
        gvData.Columns.Add(fldId)

        Dim fldSelectForPrinting As New GridViewCheckBoxColumn("CHECK FOR PRINTING")
        fldSelectForPrinting.FieldName = "fldSelectForPrinting"
        fldSelectForPrinting.TextAlignment = ContentAlignment.MiddleCenter
        fldSelectForPrinting.EnableHeaderCheckBox = True
        fldSelectForPrinting.Width = 170
        gvData.Columns.Add(fldSelectForPrinting)

        Dim fldPhotoColumn As New GridViewImageColumn("PHOTO")
        fldPhotoColumn.FieldName = "fldPhoto"
        fldPhotoColumn.Width = 120
        fldPhotoColumn.ImageLayout = ImageLayout.Stretch
        fldPhotoColumn.IsVisible = False
        fldPhotoColumn.ReadOnly = True
        fldPhotoColumn.IsPinned = True
        fldPhotoColumn.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldPhotoColumn)

        Dim fldItemCode As New GridViewTextBoxColumn("ITEM CODE")
        fldItemCode.FieldName = "fldItemCode"
        fldItemCode.Width = 130
        fldItemCode.ReadOnly = True
        gvData.Columns.Add(fldItemCode)

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("CUSTOMER PART NO.")
        fldCustomerPartNo.FieldName = "fldCustomerPartNo"
        fldCustomerPartNo.Width = 150
        fldCustomerPartNo.ReadOnly = True
        gvData.Columns.Add(fldCustomerPartNo)

        Dim fldCustomer As New GridViewTextBoxColumn("CUSTOMER")
        fldCustomer.FieldName = "fldCustomer"
        fldCustomer.Width = 100
        fldCustomer.ReadOnly = True
        gvData.Columns.Add(fldCustomer)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 180
        fldPartName.ReadOnly = True
        gvData.Columns.Add(fldPartName)

        Dim fldKanbanType As New GridViewTextBoxColumn("KANBAN TYPE")
        fldKanbanType.FieldName = "fldKanbanType"
        fldKanbanType.Width = 120
        fldKanbanType.ReadOnly = True
        gvData.Columns.Add(fldKanbanType)

        Dim fldLine As New GridViewTextBoxColumn("LINE")
        fldLine.FieldName = "fldLineName"
        fldLine.Width = 100
        fldLine.ReadOnly = True
        gvData.Columns.Add(fldLine)

        Dim fldMaxCapacityPerHr As New GridViewDecimalColumn("MAX CAPACITY PER HOUR")
        fldMaxCapacityPerHr.FieldName = "fldMaxCapacityPerHr"
        fldMaxCapacityPerHr.Width = 180
        fldMaxCapacityPerHr.ReadOnly = True
        gvData.Columns.Add(fldMaxCapacityPerHr)
        gvData.Columns("fldMaxCapacityPerHr").FormatString = "{0:N2}"

        Dim fldOrderingPoint As New GridViewDecimalColumn("ORDERING POINT")
        fldOrderingPoint.FieldName = "fldOrderingPoint"
        fldOrderingPoint.Width = 120
        fldOrderingPoint.ReadOnly = True
        gvData.Columns.Add(fldOrderingPoint)
        gvData.Columns("fldOrderingPoint").FormatString = "{0:N2}"

        Dim fldUOM As New GridViewTextBoxColumn("UOM")
        fldUOM.FieldName = "fldUOM"
        fldUOM.Width = 80
        fldUOM.ReadOnly = True
        gvData.Columns.Add(fldUOM)

        Dim fldStdQty As New GridViewDecimalColumn("STD QTY")
        fldStdQty.FieldName = "fldStdQty"
        fldStdQty.Width = 100
        fldStdQty.ReadOnly = True
        gvData.Columns.Add(fldStdQty)
        gvData.Columns("fldStdQty").FormatString = "{0:N2}"

        Dim fldLocation As New GridViewTextBoxColumn("LOCATION")
        fldLocation.FieldName = "fldLocation"
        fldLocation.Width = 150
        fldLocation.ReadOnly = True
        gvData.Columns.Add(fldLocation)

        Dim fldSRCLine As New GridViewTextBoxColumn("SRC / FFC LINE")
        fldSRCLine.FieldName = "fldSRCLine"
        fldSRCLine.Width = 150
        fldSRCLine.ReadOnly = True
        gvData.Columns.Add(fldSRCLine)

        Dim fldPartition As New GridViewTextBoxColumn("PARTITION / MACHINE NO.")
        fldPartition.FieldName = "fldPartition"
        fldPartition.Width = 150
        fldPartition.ReadOnly = True
        gvData.Columns.Add(fldPartition)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        fldDateAdded.FieldName = "fldDateAdded"
        fldDateAdded.Width = 150
        fldDateAdded.Format = DateTimePickerFormat.Custom
        fldDateAdded.CustomFormat = "MMM dd, yyyy HH:mm"
        fldDateAdded.ReadOnly = True
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy HH:mm}"

        Dim fldAddedBy As New GridViewTextBoxColumn("ADDED BY")
        fldAddedBy.FieldName = "fldAddedBy"
        fldAddedBy.Width = 100
        fldAddedBy.ReadOnly = True
        gvData.Columns.Add(fldAddedBy)

        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableFiltering = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = True

        gvData.TableElement.RowHeight = 25
    End Sub


    Private Sub loadItemCode()

        Dim dtProduct As DataTable = Slipknot.dbSelect("SP_SelectAllItemMasterData")

        Dim fldCompanyPartNo As New GridViewTextBoxColumn("ITEM CODE")
        fldCompanyPartNo.FieldName = "fldItemCode"
        fldCompanyPartNo.Width = 160
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldCompanyPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 250
        mcbItemCode.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        mcbItemCode.DataSource = dtProduct
        mcbItemCode.ValueMember = "fldItemCode"
        mcbItemCode.DisplayMember = "fldItemCode"
        mcbItemCode.MultiColumnComboBoxElement.DropDownWidth = 500

        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        mcbItemCode.AutoFilter = True
        mcbItemCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim itemCode As New FilterDescriptor()
        itemCode.PropertyName = "fldItemCode"
        itemCode.Operator = FilterOperator.Contains
        mcbItemCode.EditorControl.MasterTemplate.FilterDescriptors.Add(itemCode)

    End Sub

    Private Sub loadCustomerPartNo()

        Dim DT As DataTable = Slipknot.dbSelectManual("SELECT " _
                                        & "T0.fldId, " _
                                        & "T0.fldCustomerPartNo, " _
                                        & "T0.fldItemCode, " _
                                        & "T0.fldStdQty, " _
                                        & "T1.fldPartName, " _
                                        & "(SELECT fldCustomerName FROM tblCustomer WHERE fldCustomerCode = T0.fldCustomerCode LIMIT 1) AS customer " _
                                        & "FROM " _
                                        & "tblItemMasterPerCustomer T0 " _
                                        & "LEFT JOIN tblItemMasterData T1 ON T0.fldItemCode = T1.fldItemCode " _
                                        & "ORDER BY T1.fldPartName ASC")

        Dim fldCustomerPartNo As New GridViewTextBoxColumn("CUSTOMER PART NO.")
        fldCustomerPartNo.FieldName = "fldCustomerPartNo"
        fldCustomerPartNo.Width = 160
        mcbCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldCustomerPartNo)

        Dim fldPartName As New GridViewTextBoxColumn("PART NAME")
        fldPartName.FieldName = "fldPartName"
        fldPartName.Width = 250
        mcbCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldPartName)

        Dim fldCompanyPartNo As New GridViewTextBoxColumn("ITEM CODE")
        fldCompanyPartNo.FieldName = "fldItemCode"
        fldCompanyPartNo.Width = 160
        mcbCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldCompanyPartNo)

        Dim customer As New GridViewTextBoxColumn("CUSTOMER")
        customer.FieldName = "customer"
        customer.Width = 120
        mcbCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(customer)

        Dim fldStdQty As New GridViewDecimalColumn("STD QTY")
        fldStdQty.FieldName = "fldStdQty"
        fldStdQty.Width = 120
        fldStdQty.IsVisible = False
        mcbCustomerPartNo.MultiColumnComboBoxElement.Columns.Add(fldStdQty)

        mcbCustomerPartNo.DataSource = DT
        mcbCustomerPartNo.ValueMember = "fldCustomerPartNo"
        mcbCustomerPartNo.DisplayMember = "fldCustomerPartNo"
        mcbCustomerPartNo.MultiColumnComboBoxElement.DropDownWidth = 700

        mcbCustomerPartNo.AutoFilter = True
        mcbCustomerPartNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim filter As New FilterDescriptor()
        filter.PropertyName = "fldCustomerPartNo"
        filter.Operator = FilterOperator.Contains
        mcbCustomerPartNo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)

    End Sub

    Private Sub loadMachines()

        Dim dtmachine As DataTable = Slipknot.dbSelect("SP_SelectAllLines")

        Dim fldCode As New GridViewTextBoxColumn("CODE")
        fldCode.FieldName = "fldCode"
        fldCode.Width = 160
        fldCode.IsVisible = False
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldCode)

        Dim fldLineName As New GridViewTextBoxColumn("LINE NAME")
        fldLineName.FieldName = "fldLineName"
        fldLineName.Width = 200
        mcbLine.MultiColumnComboBoxElement.Columns.Add(fldLineName)

        mcbLine.DataSource = dtmachine
        mcbLine.ValueMember = "fldCode"
        mcbLine.DisplayMember = "fldLineName"
        mcbLine.MultiColumnComboBoxElement.DropDownWidth = 250

        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeMode = RadAutoSizeMode.Auto
        'mcbCustomerPartNo.MultiColumnComboBoxElement.AutoSizeDropDownToBestFit = True
        mcbLine.AutoFilter = True
        mcbLine.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim name As New FilterDescriptor()
        name.PropertyName = "fldLineName"
        name.Operator = FilterOperator.Contains
        mcbLine.EditorControl.MasterTemplate.FilterDescriptors.Add(name)

    End Sub

    Private Sub loadUOM()

        Dim dtUOM As DataTable = Slipknot.dbSelect("SP_SelectAllUOM")

        Dim fldUOM As New GridViewTextBoxColumn("UOM")
        fldUOM.FieldName = "fldUOM"
        fldUOM.Width = 100
        mcbUOM.MultiColumnComboBoxElement.Columns.Add(fldUOM)

        mcbUOM.DataSource = dtUOM
        mcbUOM.ValueMember = "fldUOM"
        mcbUOM.DisplayMember = "fldUOM"
        mcbUOM.MultiColumnComboBoxElement.DropDownWidth = 180

        mcbUOM.AutoFilter = True
        mcbUOM.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim uom As New FilterDescriptor()
        uom.PropertyName = "fldUOM"
        uom.Operator = FilterOperator.Contains
        mcbUOM.EditorControl.MasterTemplate.FilterDescriptors.Add(uom)

    End Sub

    Private Sub mcbItemCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbItemCode.SelectedIndexChanged

        If mcbItemCode.SelectedValue = Nothing Then
            txtPartName.Clear()
        Else
            txtPartName.Text = Convert.ToString(mcbItemCode.EditorControl.CurrentRow.Cells("fldPartName").Value)
        End If

    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub miEnableFiltering_Click(sender As Object, e As EventArgs) Handles miEnableFiltering.Click
        If miEnableFiltering.IsChecked Then
            gvData.ShowFilteringRow = True
        Else
            gvData.ShowFilteringRow = False
        End If
    End Sub

    Private Sub miEnableGrouping_Click(sender As Object, e As EventArgs) Handles miEnableGrouping.Click
        If miEnableGrouping.IsChecked Then
            gvData.ShowGroupPanel = True
        Else
            gvData.ShowGroupPanel = False
        End If
    End Sub

    Private Sub cbbExport_Click(sender As Object, e As EventArgs) Handles cbbExport.Click
        If gvData.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.gvData)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
            End If

        End If
    End Sub

    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnChangePhoto_Click(sender As Object, e As EventArgs) Handles btnChangePhoto.Click
        Try

            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ResizeImageProfile(OpenFileDialog1.FileName, 400, 400)

                Dim ImageStream As System.IO.Stream
                OpenFileDialog1.FileName = (New System.IO.FileInfo(OpenFileDialog1.FileName)).DirectoryName & "\" & mcbItemCode.SelectedValue.ToString + ".jpg"

                'If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ImageStream = OpenFileDialog1.OpenFile()
                PictureBox1.Image = Image.FromStream(ImageStream)
                'End If

                ImageStream.Dispose()

            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ResizeImageProfile(ByVal fileName As String, ByVal width As Integer, ByVal height As Integer)
        Try
            'following code resizes picture to fit
            Dim bm As New Bitmap(fileName)
            Dim thumb As New Bitmap(width, height)
            Dim g As Graphics = Graphics.FromImage(thumb)

            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

            g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)
            g.Dispose()
            bm.Dispose()

            Dim myPath = (New System.IO.FileInfo(OpenFileDialog1.FileName)).DirectoryName

            'image path.
            thumb.Save(myPath & "\" & mcbItemCode.SelectedValue.ToString & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg) 'can use any image format 

            thumb.Dispose()

        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cbbAddRecord_Click(sender As Object, e As EventArgs) Handles cbbAddRecord.Click
        If BulletForMyValentine.isRW("fldModKanbanCreator") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If mcbItemCode.SelectedValue Is Nothing Then
            RadMessageBox.Show("Item code cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbItemCode.Select()
            Exit Sub
        End If

        If mcbLine.SelectedValue Is Nothing Then
            RadMessageBox.Show("Machine cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbLine.Select()
            Exit Sub
        End If

        If mcbUOM.SelectedValue Is Nothing Then
            RadMessageBox.Show("UOM cannot be empty", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

            mcbUOM.Select()
            Exit Sub
        End If

        Dim rnd = New Random()
        Dim nextValue = rnd.Next(999999)
        thisRecordID = nextValue.ToString

        If (ddKanbanType.Text = "IM WITHDRAWAL") Then

            Slipknot.addParameter("parID", thisRecordID)
            Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
            Slipknot.addParameter("parCustomerPartNo", DBNull.Value)
            Slipknot.addParameter("parCustomer", DBNull.Value)
            Slipknot.addParameter("parLocation", DBNull.Value)
            Slipknot.addParameter("parSRCLine", DBNull.Value)
            Slipknot.addParameter("parPartition", DBNull.Value)
            Slipknot.addParameter("parLine", mcbLine.SelectedValue)
            Slipknot.addParameter("parMaxCapacityPerHr", seMaxQty.Value)
            Slipknot.addParameter("parOrderingPoint", seOrderingPoint.Value)
            Slipknot.addParameter("parUOM", mcbUOM.SelectedValue)
            Slipknot.addParameter("parStdQty", seStdQty.Value)
            Slipknot.addParameter("parKanbanType", ddKanbanType.Text)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        ElseIf ddKanbanType.Text = "IM MACHINE ISSUANCE" Then

            Slipknot.addParameter("parID", thisRecordID)
            Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
            Slipknot.addParameter("parCustomerPartNo", DBNull.Value)
            Slipknot.addParameter("parCustomer", DBNull.Value)
            Slipknot.addParameter("parLocation", DBNull.Value)
            Slipknot.addParameter("parSRCLine", DBNull.Value)
            Slipknot.addParameter("parPartition", DBNull.Value)
            Slipknot.addParameter("parLine", mcbLine.SelectedValue)
            Slipknot.addParameter("parMaxCapacityPerHr", DBNull.Value)
            Slipknot.addParameter("parOrderingPoint", DBNull.Value)
            Slipknot.addParameter("parUOM", DBNull.Value)
            Slipknot.addParameter("parStdQty", seStdQty.Value)
            Slipknot.addParameter("parKanbanType", ddKanbanType.Text)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        ElseIf ddKanbanType.Text = "FG" Then

            Slipknot.addParameter("parID", thisRecordID)
            Slipknot.addParameter("parItemCode", mcbItemCode.SelectedValue)
            Slipknot.addParameter("parCustomerPartNo", mcbCustomerPartNo.SelectedValue)
            Slipknot.addParameter("parCustomer", txtCustomer.Text)
            Slipknot.addParameter("parLocation", txtLocation.Text.TrimStart.TrimEnd)
            Slipknot.addParameter("parSRCLine", txtSRCLine.Text.TrimStart.TrimEnd)
            Slipknot.addParameter("parPartition", txtPartition.Text.TrimStart.TrimEnd)
            Slipknot.addParameter("parLine", DBNull.Value)
            Slipknot.addParameter("parMaxCapacityPerHr", DBNull.Value)
            Slipknot.addParameter("parOrderingPoint", DBNull.Value)
            Slipknot.addParameter("parUOM", DBNull.Value)
            Slipknot.addParameter("parStdQty", seStdQty.Value)
            Slipknot.addParameter("parKanbanType", ddKanbanType.Text)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

        End If

        If Slipknot.dbAED("SP_InsertKanban2") Then

            If ddKanbanType.Text <> "FG" Then
                Slipknot.savePicture(OpenFileDialog1, thisRecordID, "SP_UpdateKanbanPhoto")
            End If

            If bwLoadData.IsBusy = False Then
                bwLoadData.RunWorkerAsync()
            End If

        End If

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLoadData.DoWork

        myData = Slipknot.dbSelect("SP_SelectAllKanban")

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
    End Sub

    Private Sub FrmKanbanCreator_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub gvData_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles gvData.RowFormatting
        If miShowPhoto.IsChecked Then
            e.RowElement.RowInfo.Height = 100
        Else
            e.RowElement.RowInfo.Height = 25
        End If
    End Sub

    Private Sub miShowPhoto_Click(sender As Object, e As EventArgs) Handles miShowPhoto.Click
        If miShowPhoto.IsChecked Then
            gvData.Columns("fldPhoto").IsVisible = True
        Else
            gvData.Columns("fldPhoto").IsVisible = False
        End If
    End Sub

    Private Sub cbbDeleteRecord_Click(sender As Object, e As EventArgs) Handles cbbDeleteRecord.Click
        If BulletForMyValentine.isRW("fldModKanbanCreator") = False Then
            Slapshock.NoAccessToFunctionMessage()

            Exit Sub
        End If

        If gvData.SelectedRows.Count > 0 Then
            If RadMessageBox.Show("Are you you want to delete " & gvData.SelectedRows.Count & " record(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                If bwDelete.IsBusy = False Then
                    bwDelete.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub bwDelete_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwDelete.DoWork

        Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(gvData.SelectedRows.Count - 1) {}

        gvData.SelectedRows.CopyTo(rows, 0)

        Dim id As String = Nothing
        Dim percent As Double

        For i As Integer = 0 To rows.Length - 1

            id = id & "," & Convert.ToString(rows(i).Cells("fldId").Value)

            Threading.Thread.Sleep(delay)
            percent = i / rows.Length * 100
            bwDelete.ReportProgress(Convert.ToInt32(percent))
        Next

        Slipknot.addParameter("parIdArray", id)
        Slipknot.dbAED("SP_Deletekanban")

    End Sub

    Private Sub bwDelete_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwDelete.ProgressChanged
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwDelete_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwDelete.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100

        If bwLoadData.IsBusy = False Then
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub ddKanbanType_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddKanbanType.SelectedIndexChanged

        If ddKanbanType.Text = "IM WITHDRAWAL" Then

            seMaxQty.Enabled = True
            seOrderingPoint.Enabled = True
            mcbUOM.Enabled = True

            mcbCustomerPartNo.Enabled = False
            txtCustomer.Enabled = False
            txtLocation.Enabled = False
            txtSRCLine.Enabled = False
            txtPartition.Enabled = False

            seStdQty.Value = 0

        ElseIf ddKanbanType.Text = "IM MACHINE ISSUANCE" Then

            seMaxQty.Enabled = False
            seOrderingPoint.Enabled = False
            mcbUOM.Enabled = False

            mcbCustomerPartNo.Enabled = False
            txtCustomer.Enabled = False
            txtLocation.Enabled = False
            txtSRCLine.Enabled = False
            txtPartition.Enabled = False

            seStdQty.Value = 0

        ElseIf ddKanbanType.Text = "FG" Then

            mcbCustomerPartNo.Enabled = True
            txtCustomer.Enabled = True
            seStdQty.Enabled = True
            txtLocation.Enabled = True
            txtSRCLine.Enabled = True
            txtPartition.Enabled = True

            mcbItemCode.Enabled = False
            mcbLine.Enabled = False
            seMaxQty.Enabled = False
            seOrderingPoint.Enabled = False
            mcbUOM.Enabled = False

            If mcbCustomerPartNo.SelectedValue IsNot Nothing Then
                seStdQty.Value = Convert.ToDecimal(mcbCustomerPartNo.EditorControl.CurrentRow.Cells("fldStdQty").Value)
            Else
                seStdQty.Value = 0
            End If

        End If
    End Sub

    Private Sub miIMWithdrawal_Click(sender As Object, e As EventArgs) Handles miIMWithdrawal.Click
        reportType = 1

        publicText = Nothing

        For Each row As GridViewRowInfo In gvData.Rows

            If Convert.ToBoolean(row.Cells("fldSelectForPrinting").Value) And Convert.ToString(row.Cells("fldKanbanType").Value) = "IM WITHDRAWAL" Then
                publicText = publicText & "," & Convert.ToString(row.Cells("fldId").Value)
            End If

        Next

        Slipknot.addReportParameter("parIdArray", publicText)

        Dim frm As New FrmReport
        frm.Show()
    End Sub

    Private Sub miIMMachineIssuance_Click(sender As Object, e As EventArgs) Handles miIMMachineIssuance.Click
        reportType = 2

        publicText = Nothing

        For Each row As GridViewRowInfo In gvData.Rows

            If Convert.ToBoolean(row.Cells("fldSelectForPrinting").Value) And Convert.ToString(row.Cells("fldKanbanType").Value) = "IM MACHINE ISSUANCE" Then
                publicText = publicText & "," & Convert.ToString(row.Cells("fldId").Value)
            End If

        Next

        Slipknot.addReportParameter("parIdArray", publicText)

        Dim frm As New FrmReport
        frm.Show()
    End Sub

    Private Sub mcbCustomerPartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcbCustomerPartNo.SelectedIndexChanged

        If mcbCustomerPartNo.SelectedValue IsNot Nothing Then
            mcbItemCode.SelectedValue = Convert.ToString(mcbCustomerPartNo.EditorControl.CurrentRow.Cells("fldItemCode").Value)
            txtCustomer.Text = Convert.ToString(mcbCustomerPartNo.EditorControl.CurrentRow.Cells("customer").Value)
            seStdQty.Value = Convert.ToDecimal(mcbCustomerPartNo.EditorControl.CurrentRow.Cells("fldStdQty").Value)
        Else
            txtCustomer.Clear()
            seStdQty.Value = 0
        End If

    End Sub

    Private Sub miFGRegular_Click(sender As Object, e As EventArgs) Handles miFGRegular.Click

        reportType = 10

        publicText = Nothing

        For Each row As GridViewRowInfo In gvData.Rows

            If Convert.ToBoolean(row.Cells("fldSelectForPrinting").Value) And Convert.ToString(row.Cells("fldKanbanType").Value) = "FG" Then
                publicText = publicText & "," & Convert.ToString(row.Cells("fldId").Value)
            End If

        Next

        Dim title As String = "SRC Assembly Process Production Ordering Kanban"

        Slipknot.addReportParameter("parIdArray", publicText)
        Slipknot.addReportParameter("parTitle", title)

        Dim frm As New FrmReport
        frm.Show()

    End Sub
End Class
