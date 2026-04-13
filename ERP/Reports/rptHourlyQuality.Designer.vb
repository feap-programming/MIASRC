Partial Class rptHourlyQuality

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
        Dim TableGroup12 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptHourlyQuality))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter5 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule6 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector3 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.sqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.crosstab1 = New Telerik.Reporting.Crosstab()
        Me.textBox30 = New Telerik.Reporting.TextBox()
        Me.textBox31 = New Telerik.Reporting.TextBox()
        Me.textBox32 = New Telerik.Reporting.TextBox()
        Me.textBox33 = New Telerik.Reporting.TextBox()
        Me.textBox34 = New Telerik.Reporting.TextBox()
        Me.textBox35 = New Telerik.Reporting.TextBox()
        Me.textBox36 = New Telerik.Reporting.TextBox()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox6 = New Telerik.Reporting.TextBox()
        Me.textBox7 = New Telerik.Reporting.TextBox()
        Me.textBox8 = New Telerik.Reporting.TextBox()
        Me.textBox9 = New Telerik.Reporting.TextBox()
        Me.textBox10 = New Telerik.Reporting.TextBox()
        Me.textBox11 = New Telerik.Reporting.TextBox()
        Me.textBox28 = New Telerik.Reporting.TextBox()
        Me.textBox29 = New Telerik.Reporting.TextBox()
        Me.textBox26 = New Telerik.Reporting.TextBox()
        Me.textBox27 = New Telerik.Reporting.TextBox()
        Me.textBox4 = New Telerik.Reporting.TextBox()
        Me.textBox19 = New Telerik.Reporting.TextBox()
        Me.textBox20 = New Telerik.Reporting.TextBox()
        Me.textBox21 = New Telerik.Reporting.TextBox()
        Me.textBox22 = New Telerik.Reporting.TextBox()
        Me.textBox23 = New Telerik.Reporting.TextBox()
        Me.textBox24 = New Telerik.Reporting.TextBox()
        Me.textBox25 = New Telerik.Reporting.TextBox()
        Me.panel1 = New Telerik.Reporting.Panel()
        Me.pictureBox1 = New Telerik.Reporting.PictureBox()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.textBox3 = New Telerik.Reporting.TextBox()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'sqlDataSource1
        '
        Me.sqlDataSource1.ConnectionString = "MIA.My.MySettings.dbMIA"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parDRID", System.Data.DbType.Int32, "= Parameters.parDRID.Value"))
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parShift", System.Data.DbType.[String], "= Parameters.parShift.Value"))
        Me.sqlDataSource1.SelectCommand = "dbMIA.SP_SRCDailyReport_HourlyQuality"
        Me.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(3.1R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.crosstab1, Me.panel1})
        Me.detailSection1.Name = "detailSection1"
        '
        'crosstab1
        '
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.811R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.811R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.811R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.811R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.811R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.811R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.811R)))
        Me.crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2R)))
        Me.crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2R)))
        Me.crosstab1.Body.SetCellContent(0, 0, Me.textBox30)
        Me.crosstab1.Body.SetCellContent(0, 1, Me.textBox31)
        Me.crosstab1.Body.SetCellContent(0, 2, Me.textBox32)
        Me.crosstab1.Body.SetCellContent(0, 3, Me.textBox33)
        Me.crosstab1.Body.SetCellContent(0, 4, Me.textBox34)
        Me.crosstab1.Body.SetCellContent(0, 5, Me.textBox35)
        Me.crosstab1.Body.SetCellContent(0, 6, Me.textBox36)
        Me.crosstab1.Body.SetCellContent(1, 0, Me.textBox5)
        Me.crosstab1.Body.SetCellContent(1, 1, Me.textBox6)
        Me.crosstab1.Body.SetCellContent(1, 2, Me.textBox7)
        Me.crosstab1.Body.SetCellContent(1, 3, Me.textBox8)
        Me.crosstab1.Body.SetCellContent(1, 4, Me.textBox9)
        Me.crosstab1.Body.SetCellContent(1, 5, Me.textBox10)
        Me.crosstab1.Body.SetCellContent(1, 6, Me.textBox11)
        TableGroup1.Name = "fldPlan1"
        TableGroup1.ReportItem = Me.textBox19
        TableGroup2.Name = "fldActual1"
        TableGroup2.ReportItem = Me.textBox20
        TableGroup3.Name = "fldDeviation1"
        TableGroup3.ReportItem = Me.textBox21
        TableGroup4.Name = "totalPlanDT1"
        TableGroup4.ReportItem = Me.textBox22
        TableGroup5.Name = "totalUnplanDT1"
        TableGroup5.ReportItem = Me.textBox23
        TableGroup6.Name = "fldQuantity1"
        TableGroup6.ReportItem = Me.textBox24
        TableGroup7.Name = "fldCause"
        TableGroup7.ReportItem = Me.textBox25
        Me.crosstab1.ColumnGroups.Add(TableGroup1)
        Me.crosstab1.ColumnGroups.Add(TableGroup2)
        Me.crosstab1.ColumnGroups.Add(TableGroup3)
        Me.crosstab1.ColumnGroups.Add(TableGroup4)
        Me.crosstab1.ColumnGroups.Add(TableGroup5)
        Me.crosstab1.ColumnGroups.Add(TableGroup6)
        Me.crosstab1.ColumnGroups.Add(TableGroup7)
        Me.crosstab1.Corner.SetCellContent(0, 0, Me.textBox28)
        Me.crosstab1.Corner.SetCellContent(0, 1, Me.textBox29)
        Me.crosstab1.DataSource = Me.sqlDataSource1
        Me.crosstab1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox28, Me.textBox29, Me.textBox30, Me.textBox31, Me.textBox32, Me.textBox33, Me.textBox34, Me.textBox35, Me.textBox36, Me.textBox5, Me.textBox6, Me.textBox7, Me.textBox8, Me.textBox9, Me.textBox10, Me.textBox11, Me.textBox26, Me.textBox27, Me.textBox4, Me.textBox19, Me.textBox20, Me.textBox21, Me.textBox22, Me.textBox23, Me.textBox24, Me.textBox25})
        Me.crosstab1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.648R))
        Me.crosstab1.Name = "crosstab1"
        TableGroup10.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup10.Name = "detail"
        TableGroup9.ChildGroups.Add(TableGroup10)
        TableGroup9.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldTime"))
        TableGroup9.Name = "fldTime1"
        TableGroup9.ReportItem = Me.textBox27
        TableGroup12.Name = "group1"
        TableGroup11.ChildGroups.Add(TableGroup12)
        TableGroup11.Name = "group"
        TableGroup11.ReportItem = Me.textBox4
        TableGroup8.ChildGroups.Add(TableGroup9)
        TableGroup8.ChildGroups.Add(TableGroup11)
        TableGroup8.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldShift"))
        TableGroup8.Name = "fldShift1"
        TableGroup8.ReportItem = Me.textBox26
        Me.crosstab1.RowGroups.Add(TableGroup8)
        Me.crosstab1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(16.299R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.crosstab1.StyleName = "Normal.TableNormal"
        '
        'textBox30
        '
        Me.textBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox30.Name = "textBox30"
        Me.textBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox30.StyleName = "Normal.TableBody"
        Me.textBox30.Value = "= Fields.fldPlanDiff"
        '
        'textBox31
        '
        Me.textBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox31.Name = "textBox31"
        Me.textBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox31.StyleName = "Normal.TableBody"
        Me.textBox31.Value = "= Fields.fldActualDiff"
        '
        'textBox32
        '
        Me.textBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox32.Name = "textBox32"
        Me.textBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox32.StyleName = "Normal.TableBody"
        Me.textBox32.Value = "= Fields.fldActualDiff - Fields.fldPlanDiff"
        '
        'textBox33
        '
        Me.textBox33.Format = "{0:N0}"
        Me.textBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox33.Name = "textBox33"
        Me.textBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox33.StyleName = "Normal.TableBody"
        Me.textBox33.Value = "= Fields.TotalPlanDT"
        '
        'textBox34
        '
        Me.textBox34.Format = "{0:N0}"
        Me.textBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox34.Name = "textBox34"
        Me.textBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox34.StyleName = "Normal.TableBody"
        Me.textBox34.Value = "= Fields.TotalUnplanDT"
        '
        'textBox35
        '
        Me.textBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox35.Name = "textBox35"
        Me.textBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox35.StyleName = "Normal.TableBody"
        Me.textBox35.Value = "= Fields.fldQuantity"
        '
        'textBox36
        '
        Me.textBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox36.Name = "textBox36"
        Me.textBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox36.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox36.StyleName = "Normal.TableBody"
        Me.textBox36.Value = "= Fields.fldCause"
        '
        'textBox5
        '
        Me.textBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox5.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.textBox5.Style.Font.Bold = True
        Me.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox5.StyleName = "Normal.TableBody"
        Me.textBox5.Value = "=SUM(Fields.fldPlanDiff)"
        '
        'textBox6
        '
        Me.textBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox6.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.textBox6.Style.Font.Bold = True
        Me.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox6.StyleName = "Normal.TableBody"
        Me.textBox6.Value = "=SUM(Fields.fldActualDiff)"
        '
        'textBox7
        '
        Me.textBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox7.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.textBox7.Style.Font.Bold = True
        Me.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox7.StyleName = "Normal.TableBody"
        Me.textBox7.Value = "=SUM(Fields.fldActualDiff - Fields.fldPlanDiff)"
        '
        'textBox8
        '
        Me.textBox8.Format = "{0:N0}"
        Me.textBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox8.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.textBox8.Style.Font.Bold = True
        Me.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox8.StyleName = "Normal.TableBody"
        Me.textBox8.Value = "=SUM(Fields.TotalPlanDT)"
        '
        'textBox9
        '
        Me.textBox9.Format = "{0:N0}"
        Me.textBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox9.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.textBox9.Style.Font.Bold = True
        Me.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox9.StyleName = "Normal.TableBody"
        Me.textBox9.Value = "=SUM(Fields.TotalUnplanDT)"
        '
        'textBox10
        '
        Me.textBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox10.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.textBox10.Style.Font.Bold = True
        Me.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox10.StyleName = "Normal.TableBody"
        Me.textBox10.Value = "= Sum(Fields.fldQuantity)"
        '
        'textBox11
        '
        Me.textBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox11.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox11.StyleName = "Normal.TableBody"
        '
        'textBox28
        '
        Me.textBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox28.Name = "textBox28"
        Me.textBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox28.Style.Font.Bold = True
        Me.textBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox28.StyleName = "Normal.TableHeader"
        Me.textBox28.Value = "SHIFT"
        '
        'textBox29
        '
        Me.textBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox29.Name = "textBox29"
        Me.textBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox29.Style.Font.Bold = True
        Me.textBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox29.StyleName = "Normal.TableHeader"
        Me.textBox29.Value = "TIME"
        '
        'textBox26
        '
        Me.textBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox26.Name = "textBox26"
        Me.textBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.textBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox26.StyleName = "Normal.TableGroup"
        Me.textBox26.Value = "= Fields.fldShift"
        '
        'textBox27
        '
        Me.textBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox27.Name = "textBox27"
        Me.textBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox27.StyleName = "Normal.TableGroup"
        Me.textBox27.Value = "= Fields.fldTime"
        '
        'textBox4
        '
        Me.textBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox4.Style.BackgroundColor = System.Drawing.Color.Gray
        Me.textBox4.Style.Font.Bold = True
        Me.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox4.StyleName = "Normal.TableGroup"
        Me.textBox4.Value = "TOTAL:"
        '
        'textBox19
        '
        Me.textBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox19.Name = "textBox19"
        Me.textBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox19.Style.Font.Bold = True
        Me.textBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox19.StyleName = "Normal.TableHeader"
        Me.textBox19.Value = "PLAN"
        '
        'textBox20
        '
        Me.textBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox20.Name = "textBox20"
        Me.textBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox20.Style.Font.Bold = True
        Me.textBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox20.StyleName = "Normal.TableHeader"
        Me.textBox20.Value = "ACTUAL"
        '
        'textBox21
        '
        Me.textBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox21.Name = "textBox21"
        Me.textBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox21.Style.Font.Bold = True
        Me.textBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox21.StyleName = "Normal.TableHeader"
        Me.textBox21.Value = "DEVIATION"
        '
        'textBox22
        '
        Me.textBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox22.Name = "textBox22"
        Me.textBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox22.Style.Font.Bold = True
        Me.textBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox22.StyleName = "Normal.TableHeader"
        Me.textBox22.Value = "PLANNED DOWNTIME (MINS.)"
        '
        'textBox23
        '
        Me.textBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox23.Name = "textBox23"
        Me.textBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox23.Style.Font.Bold = True
        Me.textBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox23.StyleName = "Normal.TableHeader"
        Me.textBox23.Value = "UNPLANNED DOWNTIME (MINS.)"
        '
        'textBox24
        '
        Me.textBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox24.Name = "textBox24"
        Me.textBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox24.Style.Font.Bold = True
        Me.textBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox24.StyleName = "Normal.TableHeader"
        Me.textBox24.Value = "QUANTITY (PCS.)"
        '
        'textBox25
        '
        Me.textBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox25.Name = "textBox25"
        Me.textBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.811R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox25.Style.Font.Bold = True
        Me.textBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox25.StyleName = "Normal.TableHeader"
        Me.textBox25.Value = "PROBLEM/CAUSE"
        '
        'panel1
        '
        Me.panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pictureBox1, Me.textBox1, Me.textBox3, Me.textBox2})
        Me.panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(16.3R), Telerik.Reporting.Drawing.Unit.Inch(0.648R))
        Me.panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.panel1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        '
        'pictureBox1
        '
        Me.pictureBox1.Docking = Telerik.Reporting.DockingStyle.Left
        Me.pictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.pictureBox1.MimeType = "image/png"
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.648R))
        Me.pictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.pictureBox1.Value = CType(resources.GetObject("pictureBox1.Value"), Object)
        '
        'textBox1
        '
        Me.textBox1.Docking = Telerik.Reporting.DockingStyle.Left
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0R), Telerik.Reporting.Drawing.Unit.Inch(0.648R))
        Me.textBox1.Style.Font.Bold = False
        Me.textBox1.Style.Font.Name = "Arial Black"
        Me.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(45.0R)
        Me.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox1.Value = "FEAP"
        '
        'textBox3
        '
        Me.textBox3.Docking = Telerik.Reporting.DockingStyle.Left
        Me.textBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.496R), Telerik.Reporting.Drawing.Unit.Inch(0.648R))
        Me.textBox3.Style.Font.Bold = True
        Me.textBox3.Style.Font.Italic = True
        Me.textBox3.Style.Font.Name = "Arial"
        Me.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(30.0R)
        Me.textBox3.Style.Font.Underline = True
        Me.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox3.Value = "ASSEMBLY LINE HOURLY OUTPUT FOR {Parameters.parModel.Value} Line {Parameters.parL" &
    "ine.Value}"
        '
        'textBox2
        '
        Me.textBox2.Docking = Telerik.Reporting.DockingStyle.Right
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.488R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.812R), Telerik.Reporting.Drawing.Unit.Inch(0.648R))
        Me.textBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox2.Style.Font.Bold = True
        Me.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox2.Value = "DATE: {Parameters.parDate.Value}"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'rptHourlyQuality
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detailSection1, Me.pageFooterSection1})
        Me.Name = "rptHourlyQuality"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(500.0R), Telerik.Reporting.Drawing.Unit.Mm(470.0R))
        ReportParameter1.Name = "parDRID"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = "7080"
        ReportParameter2.Name = "parShift"
        ReportParameter2.Value = "6AM-6PM"
        ReportParameter3.Name = "parModel"
        ReportParameter3.Value = "TMR-051"
        ReportParameter4.Name = "parDate"
        ReportParameter4.Value = "2025-10-07"
        ReportParameter5.Name = "parLine"
        ReportParameter5.Value = "2"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.ReportParameters.Add(ReportParameter5)
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
        DescendantSelector3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableGroup")})
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector3})
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule6.Style.Font.Name = "Tahoma"
        StyleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(17.203R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents sqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents crosstab1 As Telerik.Reporting.Crosstab
    Friend WithEvents textBox30 As Telerik.Reporting.TextBox
    Friend WithEvents textBox31 As Telerik.Reporting.TextBox
    Friend WithEvents textBox32 As Telerik.Reporting.TextBox
    Friend WithEvents textBox33 As Telerik.Reporting.TextBox
    Friend WithEvents textBox34 As Telerik.Reporting.TextBox
    Friend WithEvents textBox35 As Telerik.Reporting.TextBox
    Friend WithEvents textBox36 As Telerik.Reporting.TextBox
    Friend WithEvents textBox5 As Telerik.Reporting.TextBox
    Friend WithEvents textBox6 As Telerik.Reporting.TextBox
    Friend WithEvents textBox7 As Telerik.Reporting.TextBox
    Friend WithEvents textBox8 As Telerik.Reporting.TextBox
    Friend WithEvents textBox9 As Telerik.Reporting.TextBox
    Friend WithEvents textBox10 As Telerik.Reporting.TextBox
    Friend WithEvents textBox11 As Telerik.Reporting.TextBox
    Friend WithEvents textBox19 As Telerik.Reporting.TextBox
    Friend WithEvents textBox20 As Telerik.Reporting.TextBox
    Friend WithEvents textBox21 As Telerik.Reporting.TextBox
    Friend WithEvents textBox22 As Telerik.Reporting.TextBox
    Friend WithEvents textBox23 As Telerik.Reporting.TextBox
    Friend WithEvents textBox24 As Telerik.Reporting.TextBox
    Friend WithEvents textBox25 As Telerik.Reporting.TextBox
    Friend WithEvents textBox28 As Telerik.Reporting.TextBox
    Friend WithEvents textBox29 As Telerik.Reporting.TextBox
    Friend WithEvents textBox26 As Telerik.Reporting.TextBox
    Friend WithEvents textBox27 As Telerik.Reporting.TextBox
    Friend WithEvents textBox4 As Telerik.Reporting.TextBox
    Friend WithEvents panel1 As Telerik.Reporting.Panel
    Friend WithEvents pictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents textBox3 As Telerik.Reporting.TextBox
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
End Class