Partial Class rptSubPWWeldingLot3

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim FormattingRule3 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule4 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule6 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector3 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule8 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector4 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule9 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector5 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule10 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector6 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox4 = New Telerik.Reporting.TextBox()
        Me.textBox3 = New Telerik.Reporting.TextBox()
        Me.sqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.crosstab1 = New Telerik.Reporting.Crosstab()
        Me.textBox8 = New Telerik.Reporting.TextBox()
        Me.textBox6 = New Telerik.Reporting.TextBox()
        Me.textBox7 = New Telerik.Reporting.TextBox()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'textBox1
        '
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.925R), Telerik.Reporting.Drawing.Unit.Inch(0.169R))
        Me.textBox1.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.textBox1.Style.Color = System.Drawing.Color.Black
        Me.textBox1.Style.Font.Bold = True
        Me.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox1.StyleName = "Office.TableGroup"
        Me.textBox1.Value = "= Fields.fldPartName"
        '
        'textBox5
        '
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.537R), Telerik.Reporting.Drawing.Unit.Inch(0.169R))
        Me.textBox5.Style.Color = System.Drawing.Color.Black
        Me.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox5.StyleName = "Office.TableGroup"
        Me.textBox5.Value = "= Fields.fldBoxNo2"
        '
        'textBox4
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Fields.fldPartName", Telerik.Reporting.FilterOperator.Equal, "Nothing"))
        FormattingRule1.Style.Visible = False
        Me.textBox4.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.508R), Telerik.Reporting.Drawing.Unit.Inch(0.169R))
        Me.textBox4.Style.Color = System.Drawing.Color.Black
        Me.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox4.StyleName = "Office.TableGroup"
        Me.textBox4.Value = "= Fields.fldBoxNo"
        '
        'textBox3
        '
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("= Fields.fldPartName", Telerik.Reporting.FilterOperator.Equal, "Nothing"))
        Me.textBox3.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.55R), Telerik.Reporting.Drawing.Unit.Inch(0.169R))
        Me.textBox3.Style.Color = System.Drawing.Color.Black
        Me.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox3.StyleName = "Office.TableGroup"
        Me.textBox3.Value = "= Fields.fldTime"
        '
        'sqlDataSource1
        '
        Me.sqlDataSource1.ConnectionString = "Server=192.168.191.22;Database=dbMIA;Uid=feap;Pwd=45|iF$;Convert Zero Datetime=Tr" &
    "ue"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parID", System.Data.DbType.Int32, "= Parameters.parID.Value"))
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parType", System.Data.DbType.[String], "= Parameters.parType.Value"))
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parAssyNo", System.Data.DbType.[String], "= Parameters.parAssyNo.Value"))
        Me.sqlDataSource1.ProviderName = "MySql.Data.MySqlClient"
        Me.sqlDataSource1.SelectCommand = "CALL dbMIA.SP_SRCDailyReport_ReportWeldingLotv2(@parID, @parType, @parAssyNo);"
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(2.0R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.crosstab1, Me.textBox2})
        Me.detailSection1.Name = "detailSection1"
        '
        'crosstab1
        '
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.925R)))
        Me.crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.169R)))
        Me.crosstab1.Body.SetCellContent(0, 0, Me.textBox8)
        TableGroup1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldPartName"))
        TableGroup1.Name = "fldPartName"
        TableGroup1.ReportItem = Me.textBox1
        TableGroup1.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldPartName", Telerik.Reporting.SortDirection.Asc))
        Me.crosstab1.ColumnGroups.Add(TableGroup1)
        Me.crosstab1.Corner.SetCellContent(0, 0, Me.textBox6)
        Me.crosstab1.Corner.SetCellContent(0, 1, Me.textBox7, 1, 2)
        Me.crosstab1.DataSource = Me.sqlDataSource1
        Me.crosstab1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox6, Me.textBox7, Me.textBox8, Me.textBox1, Me.textBox3, Me.textBox4, Me.textBox5})
        Me.crosstab1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.crosstab1.Name = "crosstab1"
        TableGroup4.Name = "group"
        TableGroup4.ReportItem = Me.textBox5
        TableGroup3.ChildGroups.Add(TableGroup4)
        TableGroup3.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldBoxNo"))
        TableGroup3.Name = "fldBoxNo"
        TableGroup3.ReportItem = Me.textBox4
        TableGroup3.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldBoxNo", Telerik.Reporting.SortDirection.Asc))
        TableGroup2.ChildGroups.Add(TableGroup3)
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldTime"))
        TableGroup2.Name = "fldTime"
        TableGroup2.ReportItem = Me.textBox3
        TableGroup2.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldID", Telerik.Reporting.SortDirection.Asc))
        Me.crosstab1.RowGroups.Add(TableGroup2)
        Me.crosstab1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.52R), Telerik.Reporting.Drawing.Unit.Inch(0.338R))
        Me.crosstab1.StyleName = "Office.TableNormal"
        '
        'textBox8
        '
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.925R), Telerik.Reporting.Drawing.Unit.Inch(0.169R))
        Me.textBox8.Style.Color = System.Drawing.Color.Black
        Me.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox8.StyleName = "Office.TableBody"
        Me.textBox8.Value = "= Fields.fldLotNo"
        '
        'textBox6
        '
        FormattingRule3.Filters.Add(New Telerik.Reporting.Filter("= Fields.fldPartName", Telerik.Reporting.FilterOperator.Equal, "Nothing"))
        Me.textBox6.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule3})
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.55R), Telerik.Reporting.Drawing.Unit.Inch(0.169R))
        Me.textBox6.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.textBox6.Style.Color = System.Drawing.Color.Black
        Me.textBox6.Style.Font.Bold = True
        Me.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox6.StyleName = "Office.TableHeader"
        Me.textBox6.Value = "Time/Shift"
        '
        'textBox7
        '
        FormattingRule4.Filters.Add(New Telerik.Reporting.Filter("= Fields.fldPartName", Telerik.Reporting.FilterOperator.Equal, "Nothing"))
        FormattingRule4.Style.Visible = False
        Me.textBox7.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule4})
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.045R), Telerik.Reporting.Drawing.Unit.Inch(0.169R))
        Me.textBox7.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.textBox7.Style.Color = System.Drawing.Color.Black
        Me.textBox7.Style.Font.Bold = True
        Me.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox7.StyleName = "Office.TableHeader"
        Me.textBox7.Value = "Box No"
        '
        'textBox2
        '
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox2.Style.Font.Bold = True
        Me.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox2.Value = "= Parameters.parAssyNo.Value"
        '
        'rptSubPWWeldingLot3
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detailSection1})
        Me.Name = "rptSubPWWeldingLot"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A3
        ReportParameter1.AllowNull = True
        ReportParameter1.Name = "parID"
        ReportParameter1.Value = ""
        ReportParameter2.AllowNull = True
        ReportParameter2.Name = "parType"
        ReportParameter2.Value = ""
        ReportParameter3.AllowNull = True
        ReportParameter3.Name = "parAssyNo"
        ReportParameter3.Value = ""
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Corporate.TableNormal")})
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Color = System.Drawing.Color.Black
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableBody")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableHeader")})
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule5.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule5.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule5.Style.Color = System.Drawing.Color.White
        StyleRule5.Style.Font.Name = "Tahoma"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableGroup")})
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector3})
        StyleRule6.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule6.Style.Font.Name = "Tahoma"
        StyleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Office.TableNormal")})
        StyleRule7.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule7.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule7.Style.Font.Name = "Calibri"
        StyleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Office.TableBody")})
        StyleRule8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector4})
        StyleRule8.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule8.Style.Font.Name = "Calibri"
        StyleRule8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Office.TableHeader")})
        StyleRule9.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector5})
        StyleRule9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        StyleRule9.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule9.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule9.Style.Font.Name = "Calibri"
        StyleRule9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Office.TableGroup")})
        StyleRule10.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector6})
        StyleRule10.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer))
        StyleRule10.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule10.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule10.Style.Font.Name = "Calibri"
        StyleRule10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7, StyleRule8, StyleRule9, StyleRule10})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(11.1R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents sqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents crosstab1 As Telerik.Reporting.Crosstab
    Friend WithEvents textBox8 As Telerik.Reporting.TextBox
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents textBox6 As Telerik.Reporting.TextBox
    Friend WithEvents textBox7 As Telerik.Reporting.TextBox
    Friend WithEvents textBox3 As Telerik.Reporting.TextBox
    Friend WithEvents textBox4 As Telerik.Reporting.TextBox
    Friend WithEvents textBox5 As Telerik.Reporting.TextBox
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
End Class