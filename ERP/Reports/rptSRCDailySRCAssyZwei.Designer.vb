Partial Class rptSRCDailySRCAssyZwei

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
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup9 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup10 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup11 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
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
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.crosstab1 = New Telerik.Reporting.Crosstab()
        Me.textBox18 = New Telerik.Reporting.TextBox()
        Me.textBox19 = New Telerik.Reporting.TextBox()
        Me.textBox20 = New Telerik.Reporting.TextBox()
        Me.textBox21 = New Telerik.Reporting.TextBox()
        Me.textBox25 = New Telerik.Reporting.TextBox()
        Me.textBox26 = New Telerik.Reporting.TextBox()
        Me.textBox27 = New Telerik.Reporting.TextBox()
        Me.textBox28 = New Telerik.Reporting.TextBox()
        Me.textBox29 = New Telerik.Reporting.TextBox()
        Me.textBox8 = New Telerik.Reporting.TextBox()
        Me.textBox9 = New Telerik.Reporting.TextBox()
        Me.textBox10 = New Telerik.Reporting.TextBox()
        Me.textBox11 = New Telerik.Reporting.TextBox()
        Me.textBox12 = New Telerik.Reporting.TextBox()
        Me.textBox3 = New Telerik.Reporting.TextBox()
        Me.textBox4 = New Telerik.Reporting.TextBox()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox13 = New Telerik.Reporting.TextBox()
        Me.textBox14 = New Telerik.Reporting.TextBox()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Source
        '
        Me.Source.ConnectionString = "MIA.My.MySettings.dbMIA"
        Me.Source.Name = "Source"
        Me.Source.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parID", System.Data.DbType.[String], "= Parameters.parID.Value"))
        Me.Source.SelectCommand = "dbMIA.SP_SRCDailyReport_ReportSRCAssyZwei"
        Me.Source.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(3.648R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.crosstab1, Me.textBox2})
        Me.detailSection1.Name = "detailSection1"
        Me.detailSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        '
        'crosstab1
        '
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.503R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.738R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.066R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.191R)))
        Me.crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.294R)))
        Me.crosstab1.Body.SetCellContent(0, 0, Me.textBox18)
        Me.crosstab1.Body.SetCellContent(0, 1, Me.textBox19)
        Me.crosstab1.Body.SetCellContent(0, 2, Me.textBox20)
        Me.crosstab1.Body.SetCellContent(0, 3, Me.textBox21)
        TableGroup2.Name = "group1"
        TableGroup2.ReportItem = Me.textBox4
        TableGroup3.Name = "group2"
        TableGroup3.ReportItem = Me.textBox5
        TableGroup1.ChildGroups.Add(TableGroup2)
        TableGroup1.ChildGroups.Add(TableGroup3)
        TableGroup1.Name = "fldScrapQty"
        TableGroup1.ReportItem = Me.textBox3
        TableGroup4.Name = "fldQASample"
        TableGroup4.ReportItem = Me.textBox13
        TableGroup5.Name = "fldEngSample"
        TableGroup5.ReportItem = Me.textBox14
        Me.crosstab1.ColumnGroups.Add(TableGroup1)
        Me.crosstab1.ColumnGroups.Add(TableGroup4)
        Me.crosstab1.ColumnGroups.Add(TableGroup5)
        Me.crosstab1.Corner.SetCellContent(0, 0, Me.textBox25, 2, 1)
        Me.crosstab1.Corner.SetCellContent(0, 1, Me.textBox26, 2, 1)
        Me.crosstab1.Corner.SetCellContent(0, 2, Me.textBox27, 2, 1)
        Me.crosstab1.Corner.SetCellContent(0, 3, Me.textBox28, 2, 1)
        Me.crosstab1.Corner.SetCellContent(0, 4, Me.textBox29, 2, 1)
        Me.crosstab1.DataSource = Me.Source
        Me.crosstab1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox25, Me.textBox26, Me.textBox27, Me.textBox28, Me.textBox29, Me.textBox18, Me.textBox19, Me.textBox20, Me.textBox21, Me.textBox8, Me.textBox9, Me.textBox10, Me.textBox11, Me.textBox12, Me.textBox3, Me.textBox4, Me.textBox5, Me.textBox13, Me.textBox14})
        Me.crosstab1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.796R))
        Me.crosstab1.Name = "crosstab1"
        TableGroup11.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup11.Name = "detail"
        TableGroup10.ChildGroups.Add(TableGroup11)
        TableGroup10.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldLotNo"))
        TableGroup10.Name = "fldLotNo"
        TableGroup10.ReportItem = Me.textBox12
        TableGroup10.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldLotNo", Telerik.Reporting.SortDirection.Asc))
        TableGroup9.ChildGroups.Add(TableGroup10)
        TableGroup9.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldPartName"))
        TableGroup9.Name = "fldPartName"
        TableGroup9.ReportItem = Me.textBox11
        TableGroup9.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldPartName", Telerik.Reporting.SortDirection.Asc))
        TableGroup8.ChildGroups.Add(TableGroup9)
        TableGroup8.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldPartNo"))
        TableGroup8.Name = "fldPartNo"
        TableGroup8.ReportItem = Me.textBox10
        TableGroup8.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldPartNo", Telerik.Reporting.SortDirection.Asc))
        TableGroup7.ChildGroups.Add(TableGroup8)
        TableGroup7.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldShift"))
        TableGroup7.Name = "fldShift"
        TableGroup7.ReportItem = Me.textBox9
        TableGroup7.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldShiftOrder", Telerik.Reporting.SortDirection.Asc))
        TableGroup6.ChildGroups.Add(TableGroup7)
        TableGroup6.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDate"))
        TableGroup6.Name = "fldDate"
        TableGroup6.ReportItem = Me.textBox8
        TableGroup6.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldDate", Telerik.Reporting.SortDirection.Asc))
        Me.crosstab1.RowGroups.Add(TableGroup6)
        Me.crosstab1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(15.748R), Telerik.Reporting.Drawing.Unit.Inch(0.882R))
        Me.crosstab1.StyleName = "Normal.TableNormal"
        '
        'textBox18
        '
        Me.textBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox18.Name = "textBox18"
        Me.textBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.503R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox18.StyleName = "Normal.TableBody"
        Me.textBox18.Value = "= Fields.fldScrapQty"
        '
        'textBox19
        '
        Me.textBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox19.Name = "textBox19"
        Me.textBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.738R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox19.StyleName = "Normal.TableBody"
        Me.textBox19.Value = "= Fields.fldPurgeQty"
        '
        'textBox20
        '
        Me.textBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox20.Name = "textBox20"
        Me.textBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.066R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox20.StyleName = "Normal.TableBody"
        Me.textBox20.Value = "= Fields.fldQASample"
        '
        'textBox21
        '
        Me.textBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox21.Name = "textBox21"
        Me.textBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.191R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox21.StyleName = "Normal.TableBody"
        Me.textBox21.Value = "= Fields.fldEngSample"
        '
        'textBox25
        '
        Me.textBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox25.Name = "textBox25"
        Me.textBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.55R), Telerik.Reporting.Drawing.Unit.Inch(0.588R))
        Me.textBox25.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textBox25.Style.Font.Bold = True
        Me.textBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox25.StyleName = "Normal.TableHeader"
        Me.textBox25.Value = "DATE"
        '
        'textBox26
        '
        Me.textBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox26.Name = "textBox26"
        Me.textBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.659R), Telerik.Reporting.Drawing.Unit.Inch(0.588R))
        Me.textBox26.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textBox26.Style.Font.Bold = True
        Me.textBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox26.StyleName = "Normal.TableHeader"
        Me.textBox26.Value = "SHIFT"
        '
        'textBox27
        '
        Me.textBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox27.Name = "textBox27"
        Me.textBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.488R), Telerik.Reporting.Drawing.Unit.Inch(0.588R))
        Me.textBox27.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.textBox27.Style.Font.Bold = True
        Me.textBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox27.StyleName = "Normal.TableHeader"
        Me.textBox27.Value = "PART NO."
        '
        'textBox28
        '
        Me.textBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox28.Name = "textBox28"
        Me.textBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.706R), Telerik.Reporting.Drawing.Unit.Inch(0.588R))
        Me.textBox28.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.textBox28.Style.Font.Bold = True
        Me.textBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox28.StyleName = "Normal.TableHeader"
        Me.textBox28.Value = "PART NAME"
        '
        'textBox29
        '
        Me.textBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox29.Name = "textBox29"
        Me.textBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.847R), Telerik.Reporting.Drawing.Unit.Inch(0.588R))
        Me.textBox29.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.textBox29.Style.Font.Bold = True
        Me.textBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox29.StyleName = "Normal.TableHeader"
        Me.textBox29.Value = "LOT NO."
        '
        'textBox8
        '
        Me.textBox8.Angle = 270.0R
        Me.textBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.55R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox8.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textBox8.Style.Font.Bold = True
        Me.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox8.StyleName = "Normal.TableGroup"
        Me.textBox8.Value = "= Fields.fldDate"
        '
        'textBox9
        '
        Me.textBox9.Angle = 270.0R
        Me.textBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.659R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textBox9.Style.Font.Bold = True
        Me.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox9.StyleName = "Normal.TableGroup"
        Me.textBox9.Value = "= Fields.fldShift"
        '
        'textBox10
        '
        Me.textBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.488R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox10.StyleName = "Normal.TableGroup"
        Me.textBox10.Value = "= Fields.fldPartNo"
        '
        'textBox11
        '
        Me.textBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.706R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox11.StyleName = "Normal.TableGroup"
        Me.textBox11.Value = "= Fields.fldPartName"
        '
        'textBox12
        '
        Me.textBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.847R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox12.StyleName = "Normal.TableGroup"
        Me.textBox12.Value = "= Fields.fldLotNo"
        '
        'textBox3
        '
        Me.textBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.241R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox3.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.textBox3.Style.Font.Bold = True
        Me.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox3.StyleName = "Normal.TableHeader"
        Me.textBox3.Value = "COMPONENT SCRAP"
        '
        'textBox4
        '
        Me.textBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.503R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.textBox4.Style.Font.Bold = True
        Me.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox4.StyleName = "Normal.TableHeader"
        Me.textBox4.Value = "SCRAP QTY."
        '
        'textBox5
        '
        Me.textBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.738R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox5.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.textBox5.Style.Font.Bold = True
        Me.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox5.StyleName = "Normal.TableHeader"
        Me.textBox5.Value = "PURGING QTY."
        '
        'textBox13
        '
        Me.textBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox13.Name = "textBox13"
        Me.textBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.066R), Telerik.Reporting.Drawing.Unit.Inch(0.588R))
        Me.textBox13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.textBox13.Style.Font.Bold = True
        Me.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox13.StyleName = "Normal.TableHeader"
        Me.textBox13.Value = "QA (QC) SAMPLE"
        '
        'textBox14
        '
        Me.textBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox14.Name = "textBox14"
        Me.textBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.191R), Telerik.Reporting.Drawing.Unit.Inch(0.588R))
        Me.textBox14.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.textBox14.Style.Font.Bold = True
        Me.textBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox14.StyleName = "Normal.TableHeader"
        Me.textBox14.Value = "ENG'G SAMPLE"
        '
        'textBox2
        '
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(12.4R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.textBox2.Style.Font.Bold = True
        Me.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(25.0R)
        Me.textBox2.Style.Font.Underline = True
        Me.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox2.Value = "= Parameters.parModel.Value + "" - SRC ASSEMBLY"""
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'rptSRCDailySRCAssyZwei
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(16.01R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Source As Telerik.Reporting.SqlDataSource
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents crosstab1 As Telerik.Reporting.Crosstab
    Friend WithEvents textBox18 As Telerik.Reporting.TextBox
    Friend WithEvents textBox19 As Telerik.Reporting.TextBox
    Friend WithEvents textBox20 As Telerik.Reporting.TextBox
    Friend WithEvents textBox21 As Telerik.Reporting.TextBox
    Friend WithEvents textBox4 As Telerik.Reporting.TextBox
    Friend WithEvents textBox5 As Telerik.Reporting.TextBox
    Friend WithEvents textBox3 As Telerik.Reporting.TextBox
    Friend WithEvents textBox13 As Telerik.Reporting.TextBox
    Friend WithEvents textBox14 As Telerik.Reporting.TextBox
    Friend WithEvents textBox25 As Telerik.Reporting.TextBox
    Friend WithEvents textBox26 As Telerik.Reporting.TextBox
    Friend WithEvents textBox27 As Telerik.Reporting.TextBox
    Friend WithEvents textBox28 As Telerik.Reporting.TextBox
    Friend WithEvents textBox29 As Telerik.Reporting.TextBox
    Friend WithEvents textBox8 As Telerik.Reporting.TextBox
    Friend WithEvents textBox9 As Telerik.Reporting.TextBox
    Friend WithEvents textBox10 As Telerik.Reporting.TextBox
    Friend WithEvents textBox11 As Telerik.Reporting.TextBox
    Friend WithEvents textBox12 As Telerik.Reporting.TextBox
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
End Class