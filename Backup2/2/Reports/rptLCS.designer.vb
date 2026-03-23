Partial Class rptLCS

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.txtPartname = New Telerik.Reporting.TextBox()
        Me.txtPartNo = New Telerik.Reporting.TextBox()
        Me.txtNote = New Telerik.Reporting.TextBox()
        Me.txtLotNo = New Telerik.Reporting.TextBox()
        Me.txtQty = New Telerik.Reporting.TextBox()
        Me.txtLCSId = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.picQr = New Telerik.Reporting.PictureBox()
        Me.picQrFSIB = New Telerik.Reporting.PictureBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(3.264R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtPartname, Me.txtPartNo, Me.txtNote, Me.txtLotNo, Me.txtQty, Me.txtLCSId, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.picQr, Me.picQrFSIB})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'txtPartname
        '
        Me.txtPartname.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.txtPartname.Name = "txtPartname"
        Me.txtPartname.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.txtPartname.Style.Font.Bold = True
        Me.txtPartname.Style.Font.Name = "Arial"
        Me.txtPartname.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.txtPartname.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtPartname.TextWrap = True
        Me.txtPartname.Value = "=Fields.fldPartname"
        '
        'txtPartNo
        '
        Me.txtPartNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.txtPartNo.Style.Font.Bold = True
        Me.txtPartNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.txtPartNo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtPartNo.Value = "=Fields.PartNoCustom"
        '
        'txtNote
        '
        Me.txtNote.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.9R))
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.txtNote.Style.Font.Bold = True
        Me.txtNote.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.txtNote.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtNote.Value = "=Fields.noteLabel"
        '
        'txtLotNo
        '
        Me.txtLotNo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(1.6R))
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.txtLotNo.Style.Font.Bold = True
        Me.txtLotNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.txtLotNo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtLotNo.Value = "=Fields.fldLotNo"
        '
        'txtQty
        '
        Me.txtQty.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(2.0R))
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.32R))
        Me.txtQty.Style.Font.Bold = True
        Me.txtQty.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.txtQty.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtQty.Value = "=Fields.qtyWithUom"
        '
        'txtLCSId
        '
        Me.txtLCSId.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(1.4R))
        Me.txtLCSId.Name = "txtLCSId"
        Me.txtLCSId.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.txtLCSId.Style.Font.Bold = True
        Me.txtLCSId.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.txtLCSId.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtLCSId.Value = "=Fields.fldLCSID"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(2.5R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial Narrow"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox4.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "=Fields.fldLotBD4"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(2.5R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial Narrow"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "=IIF(Fields.fldEnableLotBreakdown = 1 AND Fields.fldLotBD4 <> """", Fields.fldLotBD" &
    "Qty4, """")"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(2.45R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial Narrow"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "=IIF(Fields.fldEnableLotBreakdown = 1 AND Fields.fldLotBD3 <> """", Fields.fldLotBD" &
    "Qty3, """")"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(2.4R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial Narrow"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "=IIF(Fields.fldEnableLotBreakdown = 1 AND Fields.fldLotBD2 <> """", Fields.fldLotBD" &
    "Qty2, """")"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(2.35R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Arial Narrow"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "=IIF(Fields.fldEnableLotBreakdown = 1 AND Fields.fldLotBD1 <> """", Fields.fldLotBD" &
    "Qty1, """")"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(2.35R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial Narrow"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "=Fields.fldLotBD1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(2.45R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial Narrow"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "=Fields.fldLotBD3"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(2.4R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial Narrow"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "=Fields.fldLotBD2"
        '
        'picQr
        '
        Me.picQr.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Point(230.4R), Telerik.Reporting.Drawing.Unit.Point(158.4R))
        Me.picQr.MimeType = ""
        Me.picQr.Name = "picQr"
        Me.picQr.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.picQr.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.picQr.Value = "=Fields.fldQrCode"
        '
        'picQrFSIB
        '
        Me.picQrFSIB.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.picQrFSIB.MimeType = ""
        Me.picQrFSIB.Name = "picQrFSIB"
        Me.picQrFSIB.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.75R), Telerik.Reporting.Drawing.Unit.Inch(0.75R))
        Me.picQrFSIB.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.picQrFSIB.Value = "=Fields.fldQrCodeFSIB"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.detail.Name = "detail"
        '
        'rptLotControlCurrentAndFSIBRev12
        '
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.fldId"))
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.fldLotNo"))
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.detail})
        Me.Name = "rptLot"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.0R), Telerik.Reporting.Drawing.Unit.Inch(3.5R))
        Me.Style.Visible = True
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(4.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents txtPartname As Telerik.Reporting.TextBox
    Friend WithEvents txtPartNo As Telerik.Reporting.TextBox
    Friend WithEvents txtNote As Telerik.Reporting.TextBox
    Friend WithEvents txtLotNo As Telerik.Reporting.TextBox
    Friend WithEvents txtQty As Telerik.Reporting.TextBox
    Friend WithEvents txtLCSId As Telerik.Reporting.TextBox
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents picQr As Telerik.Reporting.PictureBox
    Friend WithEvents picQrFSIB As Telerik.Reporting.PictureBox
End Class