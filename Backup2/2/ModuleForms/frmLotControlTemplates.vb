Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.Drawing.Text

Public Class FrmLotControlTemplates
    Private myData As DataTable
    Private Sub FrmLotControlTemplates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGrid()
    End Sub
    Private Sub FrmLotControlTemplates_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bwLoadData.RunWorkerAsync()
    End Sub
    Private Sub readyGrid()

        Dim dtPartnameFont As New DataTable
        dtPartnameFont.Columns.Add("font")

        Dim fonts As New InstalledFontCollection

        For Each one As FontFamily In fonts.Families
            dtPartnameFont.Rows.Add(one.Name)
        Next

        Dim fldidColumn As New GridViewDecimalColumn("ID")
        fldidColumn.FieldName = "fldId"
        fldidColumn.ReadOnly = True
        fldidColumn.IsVisible = False
        gvData.Columns.Add(fldidColumn)

        Dim fldLotControlTemplateColumn As New GridViewTextBoxColumn("NAME")
        fldLotControlTemplateColumn.FieldName = "fldLotControlTemplate"
        fldLotControlTemplateColumn.IsPinned = True
        fldLotControlTemplateColumn.PinPosition = PinnedColumnPosition.Left
        fldLotControlTemplateColumn.Width = 150
        gvData.Columns.Add(fldLotControlTemplateColumn)

        Dim fldPartnameFontName As New GridViewComboBoxColumn("PARTNAME FONT")
        fldPartnameFontName.FieldName = "fldPartnameFontName"
        fldPartnameFontName.DataSource = dtPartnameFont
        fldPartnameFontName.DisplayMember = "font"
        fldPartnameFontName.ValueMember = "font"
        fldPartnameFontName.Width = 150
        gvData.Columns.Add(fldPartnameFontName)

        Dim fldPartnameFontStyle As New GridViewComboBoxColumn("PARTNAME STYLE")
        fldPartnameFontStyle.FieldName = "fldPartnameFontStyle"
        fldPartnameFontStyle.DataSource = New [String]() {"Regular", "Bold", "Italic", "Bold / Italic"}
        fldPartnameFontStyle.Width = 100
        gvData.Columns.Add(fldPartnameFontStyle)

        Dim fldPartnameFontSize As New GridViewDecimalColumn("PARTNAME SIZE")
        fldPartnameFontSize.FieldName = "fldPartnameFontSize"
        fldPartnameFontSize.Width = 100
        gvData.Columns.Add(fldPartnameFontSize)

        Dim fldPartNoFontName As New GridViewComboBoxColumn("PARTNO. FONT")
        fldPartNoFontName.FieldName = "fldPartNoFontName"
        fldPartNoFontName.DataSource = dtPartnameFont
        fldPartNoFontName.DisplayMember = "font"
        fldPartNoFontName.ValueMember = "font"
        fldPartNoFontName.Width = 150
        gvData.Columns.Add(fldPartNoFontName)

        Dim fldPartNoFontStyle As New GridViewComboBoxColumn("PARTNO. STYLE")
        fldPartNoFontStyle.FieldName = "fldPartNoFontStyle"
        fldPartNoFontStyle.DataSource = New [String]() {"Regular", "Bold", "Italic", "Bold / Italic"}
        fldPartNoFontStyle.Width = 100
        gvData.Columns.Add(fldPartNoFontStyle)

        Dim fldPartNoFontSize As New GridViewDecimalColumn("PARTNO. SIZE")
        fldPartNoFontSize.FieldName = "fldPartNoFontSize"
        fldPartNoFontSize.Width = 100
        gvData.Columns.Add(fldPartNoFontSize)

        Dim fldNoteFontName As New GridViewComboBoxColumn("NOTE FONT")
        fldNoteFontName.FieldName = "fldNoteFontName"
        fldNoteFontName.DataSource = dtPartnameFont
        fldNoteFontName.DisplayMember = "font"
        fldNoteFontName.ValueMember = "font"
        fldNoteFontName.Width = 150
        gvData.Columns.Add(fldNoteFontName)

        Dim fldNoteFontStyle As New GridViewComboBoxColumn("NOTE STYLE")
        fldNoteFontStyle.FieldName = "fldNoteFontStyle"
        fldNoteFontStyle.DataSource = New [String]() {"Regular", "Bold", "Italic", "Bold / Italic"}
        fldNoteFontStyle.Width = 80
        gvData.Columns.Add(fldNoteFontStyle)

        Dim fldNoteFontSize As New GridViewDecimalColumn("NOTE SIZE")
        fldNoteFontSize.FieldName = "fldNoteFontSize"
        fldNoteFontSize.Width = 80
        gvData.Columns.Add(fldNoteFontSize)

        Dim fldLotNoFontName As New GridViewComboBoxColumn("LOTNO FONT")
        fldLotNoFontName.FieldName = "fldLotNoFontName"
        fldLotNoFontName.DataSource = dtPartnameFont
        fldLotNoFontName.DisplayMember = "font"
        fldLotNoFontName.ValueMember = "font"
        fldLotNoFontName.Width = 150
        gvData.Columns.Add(fldLotNoFontName)

        Dim fldLotNoFontStyle As New GridViewComboBoxColumn("LOTNO STYLE")
        fldLotNoFontStyle.FieldName = "fldLotNoFontStyle"
        fldLotNoFontStyle.DataSource = New [String]() {"Regular", "Bold", "Italic", "Bold / Italic"}
        fldLotNoFontStyle.Width = 80
        gvData.Columns.Add(fldLotNoFontStyle)

        Dim fldLotNoFontSize As New GridViewDecimalColumn("LOTNO SIZE")
        fldLotNoFontSize.FieldName = "fldLotNoFontSize"
        fldLotNoFontSize.Width = 80
        gvData.Columns.Add(fldLotNoFontSize)

        Dim fldQtyFontName As New GridViewComboBoxColumn("QTY FONT")
        fldQtyFontName.FieldName = "fldQtyFontName"
        fldQtyFontName.DataSource = dtPartnameFont
        fldQtyFontName.DisplayMember = "font"
        fldQtyFontName.ValueMember = "font"
        fldQtyFontName.Width = 150
        gvData.Columns.Add(fldQtyFontName)

        Dim fldQtyFontStyle As New GridViewComboBoxColumn("QTY STYLE")
        fldQtyFontStyle.FieldName = "fldQtyFontStyle"
        fldQtyFontStyle.DataSource = New [String]() {"Regular", "Bold", "Italic", "Bold / Italic"}
        fldQtyFontStyle.Width = 60
        gvData.Columns.Add(fldQtyFontStyle)

        Dim fldQtyFontSize As New GridViewDecimalColumn("QTY SIZE")
        fldQtyFontSize.FieldName = "fldQtyFontSize"
        fldQtyFontSize.Width = 60
        gvData.Columns.Add(fldQtyFontSize)

        Dim fldFeapCodeFontName As New GridViewComboBoxColumn("FEAP CODE FONT")
        fldFeapCodeFontName.FieldName = "fldFeapCodeFontName"
        fldFeapCodeFontName.DataSource = dtPartnameFont
        fldFeapCodeFontName.DisplayMember = "font"
        fldFeapCodeFontName.ValueMember = "font"
        fldFeapCodeFontName.Width = 150
        gvData.Columns.Add(fldFeapCodeFontName)

        Dim fldFeapCodeFontStyle As New GridViewComboBoxColumn("FEAP CODE STYLE")
        fldFeapCodeFontStyle.FieldName = "fldFeapCodeFontStyle"
        fldFeapCodeFontStyle.DataSource = New [String]() {"Regular", "Bold", "Italic", "Bold / Italic"}
        fldFeapCodeFontStyle.Width = 100
        gvData.Columns.Add(fldFeapCodeFontStyle)

        Dim fldFeapCodeFontSize As New GridViewDecimalColumn("FEAP CODE SIZE")
        fldFeapCodeFontSize.FieldName = "fldFeapCodeFontSize"
        fldFeapCodeFontSize.Width = 100
        gvData.Columns.Add(fldFeapCodeFontSize)

        Dim fldCustomerColumn As New GridViewCheckBoxColumn("SHOW CUSTOMER")
        fldCustomerColumn.FieldName = "fldCustomer"
        fldCustomerColumn.IsVisible = False
        fldCustomerColumn.VisibleInColumnChooser = False
        fldCustomerColumn.ReadOnly = True
        fldCustomerColumn.Width = 220
        gvData.Columns.Add(fldCustomerColumn)

        Dim fldCombinePartNoCustomerFeapCode As New GridViewCheckBoxColumn("COMBINE PARTNO. / CUSTOMER / FEAP CODE")
        fldCombinePartNoCustomerFeapCode.FieldName = "fldCombinePartNoCustomerFeapCode"
        fldCombinePartNoCustomerFeapCode.Width = 250
        fldCombinePartNoCustomerFeapCode.IsVisible = False
        gvData.Columns.Add(fldCombinePartNoCustomerFeapCode)

        Dim fldHideFeapCode As New GridViewCheckBoxColumn("HIDE FEAP CODE")
        fldHideFeapCode.FieldName = "fldHideFeapCode"
        fldHideFeapCode.Width = 100
        fldHideFeapCode.IsVisible = False
        gvData.Columns.Add(fldHideFeapCode)

        Dim fldHideCustomerParenthesis As New GridViewCheckBoxColumn("HIDE CUSTOMER PARENTHESIS")
        fldHideCustomerParenthesis.FieldName = "fldHideCustomerParenthesis"
        fldHideCustomerParenthesis.Width = 200
        fldHideCustomerParenthesis.IsVisible = False
        gvData.Columns.Add(fldHideCustomerParenthesis)

        Dim fldShowAFIInfo As New GridViewCheckBoxColumn("SHOW AFI INFO")
        fldShowAFIInfo.FieldName = "fldShowAFIInfo"
        fldShowAFIInfo.Width = 150
        fldShowAFIInfo.IsVisible = False
        gvData.Columns.Add(fldShowAFIInfo)

        Dim fldReplaceCustomerPartNoWithFEAPPartNo As New GridViewCheckBoxColumn("REPLACE CUSTOMER PART NO WITH FEAP PART NO")
        fldReplaceCustomerPartNoWithFEAPPartNo.FieldName = "fldReplaceCustomerPartNoWithFEAPPartNo"
        fldReplaceCustomerPartNoWithFEAPPartNo.Width = 270
        fldReplaceCustomerPartNoWithFEAPPartNo.IsVisible = False
        gvData.Columns.Add(fldReplaceCustomerPartNoWithFEAPPartNo)

        Dim fldQRXColumn As New GridViewDecimalColumn("QR X (Point)")
        fldQRXColumn.FieldName = "fldQRY"
        fldQRXColumn.Width = 70
        gvData.Columns.Add(fldQRXColumn)

        Dim fldQRYColumn As New GridViewDecimalColumn("QR Y (Point)")
        fldQRYColumn.FieldName = "fldQRX"
        fldQRYColumn.Width = 70
        gvData.Columns.Add(fldQRYColumn)

        Dim fldFSIBQRXColumn As New GridViewDecimalColumn("FSIB QR X (Point)")
        fldFSIBQRXColumn.FieldName = "fldFSIBQrY"
        fldFSIBQRXColumn.Width = 110
        gvData.Columns.Add(fldFSIBQRXColumn)

        Dim fldFSIBQRYColumn As New GridViewDecimalColumn("FSIB QR Y (Point)")
        fldFSIBQRYColumn.FieldName = "fldFSIBQrX"
        fldFSIBQRYColumn.Width = 110
        gvData.Columns.Add(fldFSIBQRYColumn)

        Dim fldSaveColumn As New GridViewCommandColumn("SAVE")
        fldSaveColumn.FieldName = "fldSave"
        fldSaveColumn.DefaultText = "Save"
        fldSaveColumn.IsPinned = True
        fldSaveColumn.PinPosition = PinnedColumnPosition.Right
        fldSaveColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldSaveColumn.UseDefaultText = True
        gvData.Columns.Add(fldSaveColumn)

        AddHandler gvData.CommandCellClick, AddressOf editTemplate

        gvData.AllowAddNewRow = False
        gvData.AllowDeleteRow = False
        gvData.EnableAlternatingRowColor = True
        gvData.EnableFiltering = True
        gvData.EnableGrouping = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False
        gvData.MultiSelect = False


    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        myData = Slipknot.dbSelect("SP_SelectLotControlTemplates")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = myData
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
    Private originalValue As String

    Private Sub gvData_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles gvData.CellBeginEdit
        If gvData.CurrentRow.Cells("fldId").Value IsNot Nothing Then
            originalValue = gvData.CurrentCell.Value.ToString
        End If
    End Sub
    Private Sub gvData_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles gvData.CellEndEdit
        If gvData.CurrentRow.Cells("fldId").Value IsNot Nothing Then

            If Not gvData.CurrentCell.Value.ToString = originalValue Then
                gvData.CurrentRow.Cells("fldSave").Value = "YES"
            End If

        End If
    End Sub

    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting
        Dim edited As String = Convert.ToString(e.CellElement.RowInfo.Cells("fldSave").Value)

        If TypeOf e.CellElement.ColumnInfo Is GridViewCommandColumn Then

            Dim button As RadButtonElement = CType(e.CellElement.Children(0), RadButtonElement)

            If edited = "YES" Then
                button.Visibility = ElementVisibility.Visible
            Else
                button.Visibility = ElementVisibility.Hidden
            End If
        End If

        If edited = "YES" Then
            e.CellElement.DrawFill = True
            e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.ForeColor = Color.Black
            e.CellElement.BackColor = Color.LightPink
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Sub gvData_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.FilterChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_GroupByChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.GroupByChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub gvData_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gvData.RowsChanged
        leCountRec.Text = gvData.ChildRows.Count.ToString
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If ctxtTemplateName.Text = String.Empty Then
            RadMessageBox.Show("Template name should not be empty", "LOT PRODUCER", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else

            Slipknot.addParameter("parLotControlTemplate", ctxtTemplateName.Text.TrimStart.TrimEnd)
            If Slipknot.dbAED("SP_InsertLotTemplate") Then
                ctxtTemplateName.Clear()
                If bwLoadData.IsBusy = False Then
                    bwLoadData.RunWorkerAsync()
                End If
            End If

        End If
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        If gvData.CurrentCell.Value IsNot Nothing Then
            If RadMessageBox.Show("WARNING! if you delete this template it may ruin the format of the lot control sticker that are using this template, are you sure you want to continue?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
                Dim id As Integer = Convert.ToInt32(gvData.CurrentRow.Cells("fldId").Value)

                Slipknot.addParameter("parId", id)

                If Slipknot.dbAED("SP_DeleteLotTemplate") Then
                    If bwLoadData.IsBusy = False Then
                        bwLoadData.RunWorkerAsync()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub editTemplate(ByVal sender As Object, ByVal e As EventArgs)

        Dim id As Integer = Convert.ToInt32(gvData.CurrentRow.Cells("fldId").Value)
        Dim tempName As String = Convert.ToString(gvData.CurrentRow.Cells("fldLotControlTemplate").Value)
        Dim partnameFont As String = Convert.ToString(gvData.CurrentRow.Cells("fldPartnameFontName").Value)
        Dim partnameStyle As String = Convert.ToString(gvData.CurrentRow.Cells("fldPartnameFontStyle").Value)
        Dim partnameSize As Decimal = Convert.ToDecimal(gvData.CurrentRow.Cells("fldPartnameFontSize").Value)
        Dim partnoFont As String = Convert.ToString(gvData.CurrentRow.Cells("fldPartNoFontName").Value)
        Dim partnoStyle As String = Convert.ToString(gvData.CurrentRow.Cells("fldPartNoFontStyle").Value)
        Dim partnoSize As Decimal = Convert.ToDecimal(gvData.CurrentRow.Cells("fldPartNoFontSize").Value)
        Dim noteFont As String = Convert.ToString(gvData.CurrentRow.Cells("fldNoteFontName").Value)
        Dim noteStyle As String = gvData.CurrentRow.Cells("fldNoteFontStyle").Value.ToString
        Dim noteSize As String = gvData.CurrentRow.Cells("fldNoteFontSize").Value.ToString
        Dim lotNoFont As String = gvData.CurrentRow.Cells("fldLotNoFontName").Value.ToString
        Dim lotNoStyle As String = gvData.CurrentRow.Cells("fldLotNoFontStyle").Value.ToString
        Dim lotNoSize As String = gvData.CurrentRow.Cells("fldLotNoFontSize").Value.ToString
        Dim qtyFont As String = gvData.CurrentRow.Cells("fldQtyFontName").Value.ToString
        Dim qtyStyle As String = gvData.CurrentRow.Cells("fldQtyFontStyle").Value.ToString
        Dim qtySize As String = gvData.CurrentRow.Cells("fldQtyFontSize").Value.ToString
        Dim feapCodeFont As String = gvData.CurrentRow.Cells("fldFeapCodeFontName").Value.ToString
        Dim feapCodeStyle As String = gvData.CurrentRow.Cells("fldFeapCodeFontStyle").Value.ToString
        Dim feapCodeSize As String = gvData.CurrentRow.Cells("fldFeapCodeFontSize").Value.ToString
        Dim customer As Boolean = Convert.ToBoolean(gvData.CurrentRow.Cells("fldCustomer").Value)
        Dim combine As Boolean = Convert.ToBoolean(gvData.CurrentRow.Cells("fldCombinePartNoCustomerFeapCode").Value)
        Dim hideFeapCode As Boolean = Convert.ToBoolean(gvData.CurrentRow.Cells("fldHideFeapCode").Value)
        Dim hideCustomerParenthesis As Boolean = Convert.ToBoolean(gvData.CurrentRow.Cells("fldHideCustomerParenthesis").Value)
        Dim showAfiInfo As Boolean = Convert.ToBoolean(gvData.CurrentRow.Cells("fldShowAFIInfo").Value)
        Dim replaceCustomerPartNoWithFEAPPartNo As Boolean = Convert.ToBoolean(gvData.CurrentRow.Cells("fldReplaceCustomerPartNoWithFEAPPartNo").Value)
        Dim qrx As Integer = Convert.ToInt32(gvData.CurrentRow.Cells("fldQRX").Value)
        Dim qry As Integer = Convert.ToInt32(gvData.CurrentRow.Cells("fldQRY").Value)
        Dim fsibQrx As Integer = Convert.ToInt32(gvData.CurrentRow.Cells("fldFSIBQrX").Value)
        Dim fsibQry As Integer = Convert.ToInt32(gvData.CurrentRow.Cells("fldFSIBQrY").Value)

        Slipknot.addParameter("parId", id)
        Slipknot.addParameter("parLotControlTemplate", tempName)
        Slipknot.addParameter("parPartnameFontName", partnameFont)
        Slipknot.addParameter("parPartnameFontStyle", partnameStyle)
        Slipknot.addParameter("parPartnameFontSize", partnameSize)
        Slipknot.addParameter("parPartNoFontName", partnoFont)
        Slipknot.addParameter("parPartNoFontStyle", partnoStyle)
        Slipknot.addParameter("parPartNoFontSize", partnoSize)
        Slipknot.addParameter("parNoteFontName", noteFont)
        Slipknot.addParameter("parNoteFontStyle", noteStyle)
        Slipknot.addParameter("parNoteFontSize", noteSize)
        Slipknot.addParameter("parLotNoFontName", lotNoFont)
        Slipknot.addParameter("parLotNoFontStyle", lotNoStyle)
        Slipknot.addParameter("parLotNoFontSize", lotNoSize)
        Slipknot.addParameter("parQtyFontName", qtyFont)
        Slipknot.addParameter("parQtyFontStyle", qtyStyle)
        Slipknot.addParameter("parQtyFontSize", qtySize)
        Slipknot.addParameter("parFeapCodeFontName", feapCodeFont)
        Slipknot.addParameter("parFeapCodeFontStyle", feapCodeStyle)
        Slipknot.addParameter("parFeapCodeFontSize", feapCodeSize)
        Slipknot.addParameter("parCustomer", customer)
        Slipknot.addParameter("parCombinePartNoCustomerFeapCode", combine)
        Slipknot.addParameter("parHideFeapCode", hideFeapCode)
        Slipknot.addParameter("parHideCustomerParenthesis", hideCustomerParenthesis)
        Slipknot.addParameter("parShowAFIInfo", showAfiInfo)
        Slipknot.addParameter("parReplaceCustomerPartNoWithFEAPPartNo", replaceCustomerPartNoWithFEAPPartNo)
        Slipknot.addParameter("parQRX", qrx)
        Slipknot.addParameter("parQRY", qry)
        Slipknot.addParameter("parFSIBQrX", fsibQrx)
        Slipknot.addParameter("parFSIBQrY", fsibQry)

        If Slipknot.dbAED("SP_UpdateLotTemplate") Then
            gvData.CurrentRow.Cells("fldSave").Value = ""
        End If

    End Sub
End Class
