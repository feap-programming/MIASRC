Partial Class rptSRCDailySRCOthersZwei

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
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
        Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector3 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule8 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector4 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule9 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector5 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule10 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector6 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule11 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule12 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector7 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule13 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector8 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule14 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector9 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule15 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector10 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.Source = New Telerik.Reporting.SqlDataSource()
        Me.objectDataSource1 = New Telerik.Reporting.ObjectDataSource()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.crosstab1 = New Telerik.Reporting.Crosstab()
        Me.textBox11 = New Telerik.Reporting.TextBox()
        Me.textBox12 = New Telerik.Reporting.TextBox()
        Me.textBox13 = New Telerik.Reporting.TextBox()
        Me.textBox9 = New Telerik.Reporting.TextBox()
        Me.textBox10 = New Telerik.Reporting.TextBox()
        Me.textBox7 = New Telerik.Reporting.TextBox()
        Me.textBox8 = New Telerik.Reporting.TextBox()
        Me.textBox4 = New Telerik.Reporting.TextBox()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox6 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Source
        '
        Me.Source.ConnectionString = "MIA.My.MySettings.dbMIA"
        Me.Source.Name = "Source"
        Me.Source.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parID", System.Data.DbType.[String], "= Parameters.parID.Value"))
        Me.Source.SelectCommand = "dbMIA.SP_SRCDailyReport_ReportOtherDetailsZwei"
        Me.Source.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'objectDataSource1
        '
        Me.objectDataSource1.DataMember = "GetInProcDefects"
        Me.objectDataSource1.DataSource = "SRCDailyLibrary.Kurumi, SRCDailyLibrary, Version=1.0.0.0, Culture=neutral, Public" &
    "KeyToken=null"
        Me.objectDataSource1.Name = "objectDataSource1"
        Me.objectDataSource1.Parameters.Add(New Telerik.Reporting.ObjectDataSourceParameter("parID", GetType(String), "= Parameters.parID.Value"))
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(2.0R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.crosstab1})
        Me.detailSection1.Name = "detailSection1"
        Me.detailSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        '
        'crosstab1
        '
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(4.97R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(4.97R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(4.97R)))
        Me.crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2R)))
        Me.crosstab1.Body.SetCellContent(0, 0, Me.textBox11)
        Me.crosstab1.Body.SetCellContent(0, 1, Me.textBox12)
        Me.crosstab1.Body.SetCellContent(0, 2, Me.textBox13)
        TableGroup1.Name = "fldMoldParts"
        TableGroup1.ReportItem = Me.textBox4
        TableGroup2.Name = "fldInitProd"
        TableGroup2.ReportItem = Me.textBox5
        TableGroup3.Name = "fldOthers"
        TableGroup3.ReportItem = Me.textBox6
        Me.crosstab1.ColumnGroups.Add(TableGroup1)
        Me.crosstab1.ColumnGroups.Add(TableGroup2)
        Me.crosstab1.ColumnGroups.Add(TableGroup3)
        Me.crosstab1.Corner.SetCellContent(0, 0, Me.textBox9)
        Me.crosstab1.Corner.SetCellContent(0, 1, Me.textBox10)
        Me.crosstab1.DataSource = Me.Source
        Me.crosstab1.Docking = Telerik.Reporting.DockingStyle.Top
        Me.crosstab1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox9, Me.textBox10, Me.textBox11, Me.textBox12, Me.textBox13, Me.textBox7, Me.textBox8, Me.textBox4, Me.textBox5, Me.textBox6})
        Me.crosstab1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.crosstab1.Name = "crosstab1"
        TableGroup6.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup6.Name = "detail"
        TableGroup5.ChildGroups.Add(TableGroup6)
        TableGroup5.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldShift"))
        TableGroup5.Name = "fldShift"
        TableGroup5.ReportItem = Me.textBox8
        TableGroup5.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldShiftOrder", Telerik.Reporting.SortDirection.Asc))
        TableGroup4.ChildGroups.Add(TableGroup5)
        TableGroup4.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDate"))
        TableGroup4.Name = "fldDate"
        TableGroup4.ReportItem = Me.textBox7
        TableGroup4.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldDate", Telerik.Reporting.SortDirection.Asc))
        Me.crosstab1.RowGroups.Add(TableGroup4)
        Me.crosstab1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(16.005R), Telerik.Reporting.Drawing.Unit.Inch(0.535R))
        Me.crosstab1.StyleName = "Normal.TableNormal"
        '
        'textBox11
        '
        Me.textBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.97R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox11.StyleName = "Normal.TableBody"
        Me.textBox11.Value = "= Fields.fldMoldParts"
        '
        'textBox12
        '
        Me.textBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.97R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox12.StyleName = "Normal.TableBody"
        Me.textBox12.Value = "= Fields.fldInitProd"
        '
        'textBox13
        '
        Me.textBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox13.Name = "textBox13"
        Me.textBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.97R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox13.StyleName = "Normal.TableBody"
        Me.textBox13.Value = "= Fields.fldOthers"
        '
        'textBox9
        '
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.484R), Telerik.Reporting.Drawing.Unit.Inch(0.335R))
        Me.textBox9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textBox9.Style.Font.Bold = True
        Me.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox9.StyleName = "Normal.TableHeader"
        Me.textBox9.Value = "DATE"
        '
        'textBox10
        '
        Me.textBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.611R), Telerik.Reporting.Drawing.Unit.Inch(0.335R))
        Me.textBox10.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textBox10.Style.Font.Bold = True
        Me.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox10.StyleName = "Normal.TableHeader"
        Me.textBox10.Value = "SHIFT"
        '
        'textBox7
        '
        Me.textBox7.Angle = 270.0R
        Me.textBox7.Format = "{0:MMMM dd, yyyy}"
        Me.textBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.484R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox7.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox7.StyleName = "Normal.TableGroup"
        Me.textBox7.Value = "= Fields.fldDate"
        '
        'textBox8
        '
        Me.textBox8.Angle = 270.0R
        Me.textBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.611R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox8.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox8.StyleName = "Normal.TableGroup"
        Me.textBox8.Value = "= Fields.fldShift"
        '
        'textBox4
        '
        Me.textBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.97R), Telerik.Reporting.Drawing.Unit.Inch(0.335R))
        Me.textBox4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.textBox4.Style.Font.Bold = True
        Me.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox4.StyleName = "Normal.TableHeader"
        Me.textBox4.Value = "A. Mold Parts Combination Compatibility"
        '
        'textBox5
        '
        Me.textBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.97R), Telerik.Reporting.Drawing.Unit.Inch(0.335R))
        Me.textBox5.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.textBox5.Style.Font.Bold = True
        Me.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox5.StyleName = "Normal.TableHeader"
        Me.textBox5.Value = "B. Initial Production"
        '
        'textBox6
        '
        Me.textBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.97R), Telerik.Reporting.Drawing.Unit.Inch(0.335R))
        Me.textBox6.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.textBox6.Style.Font.Bold = True
        Me.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox6.StyleName = "Normal.TableHeader"
        Me.textBox6.Value = "C. Others"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.748R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox2})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'textBox2
        '
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.048R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(15.2R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.textBox2.Style.Font.Bold = True
        Me.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(25.0R)
        Me.textBox2.Style.Font.Underline = True
        Me.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox2.Value = "= Parameters.parModel.Value + "" - OTHER DETAILS"""
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'rptSRCDailySRCOthersZwei
        '
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDRID"))
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.pageHeaderSection1, Me.detailSection1, Me.pageFooterSection1})
        Me.Name = "rptSRCDailyReport"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A3
        ReportParameter1.Name = "parID"
        ReportParameter1.Value = ",507,511,509"
        ReportParameter2.Name = "parModel"
        ReportParameter2.Value = "TMR-051"
        ReportParameter3.Name = "parDate"
        ReportParameter3.Value = "2023-02-24"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Normal.TableNormal")})
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Color = System.Drawing.Color.Black
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableBody")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableHeader")})
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule5.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule5.Style.Font.Name = "Tahoma"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Office.TableNormal")})
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule6.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule6.Style.Font.Name = "Calibri"
        StyleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Office.TableBody")})
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector3})
        StyleRule7.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule7.Style.Font.Name = "Calibri"
        StyleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Office.TableHeader")})
        StyleRule8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector4})
        StyleRule8.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(227, Byte), Integer))
        StyleRule8.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule8.Style.Color = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(77, Byte), Integer))
        StyleRule8.Style.Font.Name = "Calibri"
        StyleRule8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableCorner")})
        StyleRule9.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector5})
        StyleRule9.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule9.Style.Font.Name = "Tahoma"
        StyleRule9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        DescendantSelector6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableGroup")})
        StyleRule10.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector6})
        StyleRule10.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule10.Style.Font.Name = "Tahoma"
        StyleRule10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule11.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Corporate.TableNormal")})
        StyleRule11.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule11.Style.Color = System.Drawing.Color.Black
        StyleRule11.Style.Font.Name = "Tahoma"
        StyleRule11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableBody")})
        StyleRule12.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector7})
        StyleRule12.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule12.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule12.Style.Font.Name = "Tahoma"
        StyleRule12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableHeader")})
        StyleRule13.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector8})
        StyleRule13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule13.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule13.Style.Color = System.Drawing.Color.White
        StyleRule13.Style.Font.Name = "Tahoma"
        StyleRule13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector9.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableGroup")})
        StyleRule14.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector9})
        StyleRule14.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        StyleRule14.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule14.Style.Font.Name = "Tahoma"
        StyleRule14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector10.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Corporate.TableCorner")})
        StyleRule15.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector10})
        StyleRule15.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule15.Style.Color = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(112, Byte), Integer))
        StyleRule15.Style.Font.Name = "Tahoma"
        StyleRule15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7, StyleRule8, StyleRule9, StyleRule10, StyleRule11, StyleRule12, StyleRule13, StyleRule14, StyleRule15})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(16.005R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Source As Telerik.Reporting.SqlDataSource
    Friend WithEvents objectDataSource1 As Telerik.Reporting.ObjectDataSource
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents crosstab1 As Telerik.Reporting.Crosstab
    Friend WithEvents textBox11 As Telerik.Reporting.TextBox
    Friend WithEvents textBox12 As Telerik.Reporting.TextBox
    Friend WithEvents textBox13 As Telerik.Reporting.TextBox
    Friend WithEvents textBox4 As Telerik.Reporting.TextBox
    Friend WithEvents textBox5 As Telerik.Reporting.TextBox
    Friend WithEvents textBox6 As Telerik.Reporting.TextBox
    Friend WithEvents textBox9 As Telerik.Reporting.TextBox
    Friend WithEvents textBox10 As Telerik.Reporting.TextBox
    Friend WithEvents textBox7 As Telerik.Reporting.TextBox
    Friend WithEvents textBox8 As Telerik.Reporting.TextBox
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
End Class