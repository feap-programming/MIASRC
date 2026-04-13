Partial Class rptSRCDowntimeGraphPerShift

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim GraphGroup1 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphTitle1 As Telerik.Reporting.GraphTitle = New Telerik.Reporting.GraphTitle()
        Dim CategoryScale1 As Telerik.Reporting.CategoryScale = New Telerik.Reporting.CategoryScale()
        Dim NumericalScale1 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim GraphGroup2 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
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
        Dim TableGroup13 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
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
        Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector4 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.sqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.graph2 = New Telerik.Reporting.Graph()
        Me.graphAxis4 = New Telerik.Reporting.GraphAxis()
        Me.graphAxis3 = New Telerik.Reporting.GraphAxis()
        Me.cartesianCoordinateSystem2 = New Telerik.Reporting.CartesianCoordinateSystem()
        Me.barSeries12 = New Telerik.Reporting.BarSeries()
        Me.barSeries13 = New Telerik.Reporting.BarSeries()
        Me.barSeries14 = New Telerik.Reporting.BarSeries()
        Me.barSeries15 = New Telerik.Reporting.BarSeries()
        Me.barSeries16 = New Telerik.Reporting.BarSeries()
        Me.barSeries17 = New Telerik.Reporting.BarSeries()
        Me.barSeries18 = New Telerik.Reporting.BarSeries()
        Me.barSeries19 = New Telerik.Reporting.BarSeries()
        Me.barSeries20 = New Telerik.Reporting.BarSeries()
        Me.barSeries21 = New Telerik.Reporting.BarSeries()
        Me.barSeries22 = New Telerik.Reporting.BarSeries()
        Me.crosstab1 = New Telerik.Reporting.Crosstab()
        Me.textBox17 = New Telerik.Reporting.TextBox()
        Me.textBox18 = New Telerik.Reporting.TextBox()
        Me.textBox19 = New Telerik.Reporting.TextBox()
        Me.textBox20 = New Telerik.Reporting.TextBox()
        Me.textBox21 = New Telerik.Reporting.TextBox()
        Me.textBox22 = New Telerik.Reporting.TextBox()
        Me.textBox23 = New Telerik.Reporting.TextBox()
        Me.textBox24 = New Telerik.Reporting.TextBox()
        Me.textBox25 = New Telerik.Reporting.TextBox()
        Me.textBox26 = New Telerik.Reporting.TextBox()
        Me.textBox27 = New Telerik.Reporting.TextBox()
        Me.textBox15 = New Telerik.Reporting.TextBox()
        Me.textBox16 = New Telerik.Reporting.TextBox()
        Me.textBox14 = New Telerik.Reporting.TextBox()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.textBox3 = New Telerik.Reporting.TextBox()
        Me.textBox4 = New Telerik.Reporting.TextBox()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox6 = New Telerik.Reporting.TextBox()
        Me.textBox7 = New Telerik.Reporting.TextBox()
        Me.textBox8 = New Telerik.Reporting.TextBox()
        Me.textBox9 = New Telerik.Reporting.TextBox()
        Me.textBox10 = New Telerik.Reporting.TextBox()
        Me.textBox11 = New Telerik.Reporting.TextBox()
        Me.textBox12 = New Telerik.Reporting.TextBox()
        Me.textBox13 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'sqlDataSource1
        '
        Me.sqlDataSource1.ConnectionString = "MIA.My.MySettings.dbMIA"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parDateFrom", System.Data.DbType.[String], "= Parameters.parDateFrom.Value"))
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parDateTo", System.Data.DbType.[String], "= Parameters.parDateTo.Value"))
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parLine", System.Data.DbType.[String], "= Parameters.parLine.Value"))
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parModel", System.Data.DbType.[String], "= Parameters.parModel.Value"))
        Me.sqlDataSource1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parType", System.Data.DbType.[String], "= Parameters.parType.Value"))
        Me.sqlDataSource1.SelectCommand = "dbMIA.SP_SRC_SelectDowntimeGraphByDatesAndShift"
        Me.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.6R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(7.5R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox1, Me.graph2, Me.crosstab1})
        Me.detailSection1.Name = "detailSection1"
        '
        'textBox1
        '
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(14.4R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox1.Style.Font.Bold = True
        Me.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(24.0R)
        Me.textBox1.Value = "{Parameters.parType.Value} TOTAL DOWNTIME GRAPH OF {Parameters.parModel.Value} {P" &
    "arameters.parLine.Value} FROM {Parameters.parDateFrom.Value} TO {Parameters.parD" &
    "ateTo.Value}"
        '
        'graph2
        '
        GraphGroup1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDate"))
        GraphGroup1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldShift"))
        GraphGroup1.Label = "= Fields.fldDate.ToString(""dd"") + ""/"" + Fields.fldShift"
        GraphGroup1.Name = "fldShiftGroup1"
        GraphGroup1.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldDate", Telerik.Reporting.SortDirection.Asc))
        GraphGroup1.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldShift", Telerik.Reporting.SortDirection.Asc))
        Me.graph2.CategoryGroups.Add(GraphGroup1)
        Me.graph2.CoordinateSystems.Add(Me.cartesianCoordinateSystem2)
        Me.graph2.DataSource = Me.sqlDataSource1
        Me.graph2.Legend.Style.LineColor = System.Drawing.Color.LightGray
        Me.graph2.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.graph2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.graph2.Name = "graph2"
        Me.graph2.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray
        Me.graph2.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.graph2.Series.Add(Me.barSeries12)
        Me.graph2.Series.Add(Me.barSeries13)
        Me.graph2.Series.Add(Me.barSeries14)
        Me.graph2.Series.Add(Me.barSeries15)
        Me.graph2.Series.Add(Me.barSeries16)
        Me.graph2.Series.Add(Me.barSeries17)
        Me.graph2.Series.Add(Me.barSeries18)
        Me.graph2.Series.Add(Me.barSeries19)
        Me.graph2.Series.Add(Me.barSeries20)
        Me.graph2.Series.Add(Me.barSeries21)
        Me.graph2.Series.Add(Me.barSeries22)
        Me.graph2.SeriesGroups.Add(GraphGroup2)
        Me.graph2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(14.4R), Telerik.Reporting.Drawing.Unit.Inch(5.0R))
        Me.graph2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.graph2.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph2.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        GraphTitle1.Position = Telerik.Reporting.GraphItemPosition.TopCenter
        GraphTitle1.Style.Font.Bold = True
        GraphTitle1.Style.LineColor = System.Drawing.Color.LightGray
        GraphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        GraphTitle1.Text = "DOWNTIME GRAPH"
        Me.graph2.Titles.Add(GraphTitle1)
        '
        'graphAxis4
        '
        Me.graphAxis4.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis4.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis4.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis4.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis4.MinorGridLineStyle.Visible = False
        Me.graphAxis4.Name = "graphAxis4"
        Me.graphAxis4.Scale = CategoryScale1
        '
        'graphAxis3
        '
        Me.graphAxis3.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis3.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis3.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis3.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis3.MinorGridLineStyle.Visible = False
        Me.graphAxis3.Name = "graphAxis3"
        Me.graphAxis3.Scale = NumericalScale1
        '
        'cartesianCoordinateSystem2
        '
        Me.cartesianCoordinateSystem2.Name = "cartesianCoordinateSystem2"
        Me.cartesianCoordinateSystem2.XAxis = Me.graphAxis4
        Me.cartesianCoordinateSystem2.YAxis = Me.graphAxis3
        '
        'barSeries12
        '
        Me.barSeries12.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries12.CategoryGroup = GraphGroup1
        Me.barSeries12.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries12.DataPointLabel = "= Sum(Fields.AfterPM)"
        Me.barSeries12.DataPointLabelStyle.Visible = False
        Me.barSeries12.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries12.DataPointStyle.Visible = True
        Me.barSeries12.LegendItem.Value = "'Sum(AfterPM)'"
        Me.barSeries12.Name = "barSeries12"
        GraphGroup2.Name = "seriesGroup1"
        Me.barSeries12.SeriesGroup = GraphGroup2
        Me.barSeries12.ToolTip.Text = "= Sum(Fields.AfterPM)"
        Me.barSeries12.ToolTip.Title = "'Sum(AfterPM)'"
        Me.barSeries12.Y = "= Sum(Fields.AfterPM)"
        '
        'barSeries13
        '
        Me.barSeries13.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries13.CategoryGroup = GraphGroup1
        Me.barSeries13.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries13.DataPointLabel = "= Sum(Fields.AfterSetup)"
        Me.barSeries13.DataPointLabelStyle.Visible = False
        Me.barSeries13.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries13.DataPointStyle.Visible = True
        Me.barSeries13.LegendItem.Value = "'Sum(AfterSetup)'"
        Me.barSeries13.Name = "barSeries13"
        Me.barSeries13.SeriesGroup = GraphGroup2
        Me.barSeries13.ToolTip.Text = "= Sum(Fields.AfterSetup)"
        Me.barSeries13.ToolTip.Title = "'Sum(AfterSetup)'"
        Me.barSeries13.Y = "= Sum(Fields.AfterSetup)"
        '
        'barSeries14
        '
        Me.barSeries14.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries14.CategoryGroup = GraphGroup1
        Me.barSeries14.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries14.DataPointLabel = "= Sum(Fields.Kanban)"
        Me.barSeries14.DataPointLabelStyle.Visible = False
        Me.barSeries14.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries14.DataPointStyle.Visible = True
        Me.barSeries14.LegendItem.Value = "'Sum(Kanban)'"
        Me.barSeries14.Name = "barSeries14"
        Me.barSeries14.SeriesGroup = GraphGroup2
        Me.barSeries14.ToolTip.Text = "= Sum(Fields.Kanban)"
        Me.barSeries14.ToolTip.Title = "'Sum(Kanban)'"
        Me.barSeries14.Y = "= Sum(Fields.Kanban)"
        '
        'barSeries15
        '
        Me.barSeries15.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries15.CategoryGroup = GraphGroup1
        Me.barSeries15.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries15.DataPointLabel = "= Sum(Fields.Machine)"
        Me.barSeries15.DataPointLabelStyle.Visible = False
        Me.barSeries15.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries15.DataPointStyle.Visible = True
        Me.barSeries15.LegendItem.Value = "'Sum(Machine)'"
        Me.barSeries15.Name = "barSeries15"
        Me.barSeries15.SeriesGroup = GraphGroup2
        Me.barSeries15.ToolTip.Text = "= Sum(Fields.Machine)"
        Me.barSeries15.ToolTip.Title = "'Sum(Machine)'"
        Me.barSeries15.Y = "= Sum(Fields.Machine)"
        '
        'barSeries16
        '
        Me.barSeries16.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries16.CategoryGroup = GraphGroup1
        Me.barSeries16.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries16.DataPointLabel = "= Sum(Fields.Machine2)"
        Me.barSeries16.DataPointLabelStyle.Visible = False
        Me.barSeries16.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries16.DataPointStyle.Visible = True
        Me.barSeries16.LegendItem.Value = "'Sum(Machine2)'"
        Me.barSeries16.Name = "barSeries16"
        Me.barSeries16.SeriesGroup = GraphGroup2
        Me.barSeries16.ToolTip.Text = "= Sum(Fields.Machine2)"
        Me.barSeries16.ToolTip.Title = "'Sum(Machine2)'"
        Me.barSeries16.Y = "= Sum(Fields.Machine2)"
        '
        'barSeries17
        '
        Me.barSeries17.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries17.CategoryGroup = GraphGroup1
        Me.barSeries17.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries17.DataPointLabel = "= Sum(Fields.Man)"
        Me.barSeries17.DataPointLabelStyle.Visible = False
        Me.barSeries17.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries17.DataPointStyle.Visible = True
        Me.barSeries17.LegendItem.Value = "'Sum(Man)'"
        Me.barSeries17.Name = "barSeries17"
        Me.barSeries17.SeriesGroup = GraphGroup2
        Me.barSeries17.ToolTip.Text = "= Sum(Fields.Man)"
        Me.barSeries17.ToolTip.Title = "'Sum(Man)'"
        Me.barSeries17.Y = "= Sum(Fields.Man)"
        '
        'barSeries18
        '
        Me.barSeries18.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries18.CategoryGroup = GraphGroup1
        Me.barSeries18.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries18.DataPointLabel = "= Sum(Fields.Material)"
        Me.barSeries18.DataPointLabelStyle.Visible = False
        Me.barSeries18.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries18.DataPointStyle.Visible = True
        Me.barSeries18.LegendItem.Value = "'Sum(Material)'"
        Me.barSeries18.Name = "barSeries18"
        Me.barSeries18.SeriesGroup = GraphGroup2
        Me.barSeries18.ToolTip.Text = "= Sum(Fields.Material)"
        Me.barSeries18.ToolTip.Title = "'Sum(Material)'"
        Me.barSeries18.Y = "= Sum(Fields.Material)"
        '
        'barSeries19
        '
        Me.barSeries19.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries19.CategoryGroup = GraphGroup1
        Me.barSeries19.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries19.DataPointLabel = "= Sum(Fields.Material2)"
        Me.barSeries19.DataPointLabelStyle.Visible = False
        Me.barSeries19.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries19.DataPointStyle.Visible = True
        Me.barSeries19.LegendItem.Value = "'Sum(Material2)'"
        Me.barSeries19.Name = "barSeries19"
        Me.barSeries19.SeriesGroup = GraphGroup2
        Me.barSeries19.ToolTip.Text = "= Sum(Fields.Material2)"
        Me.barSeries19.ToolTip.Title = "'Sum(Material2)'"
        Me.barSeries19.Y = "= Sum(Fields.Material2)"
        '
        'barSeries20
        '
        Me.barSeries20.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries20.CategoryGroup = GraphGroup1
        Me.barSeries20.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries20.DataPointLabel = "= Sum(Fields.Method)"
        Me.barSeries20.DataPointLabelStyle.Visible = False
        Me.barSeries20.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries20.DataPointStyle.Visible = True
        Me.barSeries20.LegendItem.Value = "'Sum(Method)'"
        Me.barSeries20.Name = "barSeries20"
        Me.barSeries20.SeriesGroup = GraphGroup2
        Me.barSeries20.ToolTip.Text = "= Sum(Fields.Method)"
        Me.barSeries20.ToolTip.Title = "'Sum(Method)'"
        Me.barSeries20.Y = "= Sum(Fields.Method)"
        '
        'barSeries21
        '
        Me.barSeries21.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries21.CategoryGroup = GraphGroup1
        Me.barSeries21.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries21.DataPointLabel = "= Sum(Fields.Other)"
        Me.barSeries21.DataPointLabelStyle.Visible = False
        Me.barSeries21.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries21.DataPointStyle.Visible = True
        Me.barSeries21.LegendItem.Value = "'Sum(Other)'"
        Me.barSeries21.Name = "barSeries21"
        Me.barSeries21.SeriesGroup = GraphGroup2
        Me.barSeries21.ToolTip.Text = "= Sum(Fields.Other)"
        Me.barSeries21.ToolTip.Title = "'Sum(Other)'"
        Me.barSeries21.Y = "= Sum(Fields.Other)"
        '
        'barSeries22
        '
        Me.barSeries22.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries22.CategoryGroup = GraphGroup1
        Me.barSeries22.CoordinateSystem = Me.cartesianCoordinateSystem2
        Me.barSeries22.DataPointLabel = "= Sum(Fields.Setup)"
        Me.barSeries22.DataPointLabelStyle.Visible = False
        Me.barSeries22.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries22.DataPointStyle.Visible = True
        Me.barSeries22.LegendItem.Value = "'Sum(Setup)'"
        Me.barSeries22.Name = "barSeries22"
        Me.barSeries22.SeriesGroup = GraphGroup2
        Me.barSeries22.ToolTip.Text = "= Sum(Fields.Setup)"
        Me.barSeries22.ToolTip.Title = "'Sum(Setup)'"
        Me.barSeries22.Y = "= Sum(Fields.Setup)"
        '
        'crosstab1
        '
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.933R)))
        Me.crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2R)))
        Me.crosstab1.Body.SetCellContent(0, 0, Me.textBox17)
        Me.crosstab1.Body.SetCellContent(0, 1, Me.textBox18)
        Me.crosstab1.Body.SetCellContent(0, 2, Me.textBox19)
        Me.crosstab1.Body.SetCellContent(0, 3, Me.textBox20)
        Me.crosstab1.Body.SetCellContent(0, 4, Me.textBox21)
        Me.crosstab1.Body.SetCellContent(0, 5, Me.textBox22)
        Me.crosstab1.Body.SetCellContent(0, 6, Me.textBox23)
        Me.crosstab1.Body.SetCellContent(0, 7, Me.textBox24)
        Me.crosstab1.Body.SetCellContent(0, 8, Me.textBox25)
        Me.crosstab1.Body.SetCellContent(0, 9, Me.textBox26)
        Me.crosstab1.Body.SetCellContent(0, 10, Me.textBox27)
        TableGroup2.Name = "afterPM"
        TableGroup2.ReportItem = Me.textBox3
        TableGroup3.Name = "afterSetup"
        TableGroup3.ReportItem = Me.textBox4
        TableGroup4.Name = "kanban"
        TableGroup4.ReportItem = Me.textBox5
        TableGroup5.Name = "machine"
        TableGroup5.ReportItem = Me.textBox6
        TableGroup6.Name = "machine2"
        TableGroup6.ReportItem = Me.textBox7
        TableGroup7.Name = "man"
        TableGroup7.ReportItem = Me.textBox8
        TableGroup8.Name = "material"
        TableGroup8.ReportItem = Me.textBox9
        TableGroup9.Name = "material2"
        TableGroup9.ReportItem = Me.textBox10
        TableGroup10.Name = "other"
        TableGroup10.ReportItem = Me.textBox11
        TableGroup11.Name = "method"
        TableGroup11.ReportItem = Me.textBox12
        TableGroup12.Name = "setup"
        TableGroup12.ReportItem = Me.textBox13
        TableGroup1.ChildGroups.Add(TableGroup2)
        TableGroup1.ChildGroups.Add(TableGroup3)
        TableGroup1.ChildGroups.Add(TableGroup4)
        TableGroup1.ChildGroups.Add(TableGroup5)
        TableGroup1.ChildGroups.Add(TableGroup6)
        TableGroup1.ChildGroups.Add(TableGroup7)
        TableGroup1.ChildGroups.Add(TableGroup8)
        TableGroup1.ChildGroups.Add(TableGroup9)
        TableGroup1.ChildGroups.Add(TableGroup10)
        TableGroup1.ChildGroups.Add(TableGroup11)
        TableGroup1.ChildGroups.Add(TableGroup12)
        TableGroup1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldShift"))
        TableGroup1.Name = "fldShift"
        TableGroup1.ReportItem = Me.textBox2
        TableGroup1.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldShift", Telerik.Reporting.SortDirection.Asc))
        Me.crosstab1.ColumnGroups.Add(TableGroup1)
        Me.crosstab1.Corner.SetCellContent(0, 0, Me.textBox15)
        Me.crosstab1.Corner.SetCellContent(1, 0, Me.textBox16)
        Me.crosstab1.DataSource = Me.sqlDataSource1
        Me.crosstab1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox15, Me.textBox16, Me.textBox17, Me.textBox18, Me.textBox19, Me.textBox20, Me.textBox21, Me.textBox22, Me.textBox23, Me.textBox24, Me.textBox25, Me.textBox26, Me.textBox27, Me.textBox14, Me.textBox2, Me.textBox3, Me.textBox4, Me.textBox5, Me.textBox6, Me.textBox7, Me.textBox8, Me.textBox9, Me.textBox10, Me.textBox11, Me.textBox12, Me.textBox13})
        Me.crosstab1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(5.9R))
        Me.crosstab1.Name = "crosstab1"
        TableGroup13.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDate"))
        TableGroup13.Name = "fldDate"
        TableGroup13.ReportItem = Me.textBox14
        TableGroup13.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldDate", Telerik.Reporting.SortDirection.Asc))
        Me.crosstab1.RowGroups.Add(TableGroup13)
        Me.crosstab1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(11.196R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.crosstab1.StyleName = "Normal.TableNormal"
        '
        'textBox17
        '
        Me.textBox17.Format = "{0:N0}"
        Me.textBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox17.Name = "textBox17"
        Me.textBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox17.StyleName = "Normal.TableBody"
        Me.textBox17.Value = "= Sum(Fields.AfterPM)"
        '
        'textBox18
        '
        Me.textBox18.Format = "{0:N0}"
        Me.textBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox18.Name = "textBox18"
        Me.textBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox18.StyleName = "Normal.TableBody"
        Me.textBox18.Value = "= Sum(Fields.AfterSetup)"
        '
        'textBox19
        '
        Me.textBox19.Format = "{0:N0}"
        Me.textBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox19.Name = "textBox19"
        Me.textBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox19.StyleName = "Normal.TableBody"
        Me.textBox19.Value = "= Sum(Fields.Kanban)"
        '
        'textBox20
        '
        Me.textBox20.Format = "{0:N0}"
        Me.textBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox20.Name = "textBox20"
        Me.textBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox20.StyleName = "Normal.TableBody"
        Me.textBox20.Value = "= Sum(Fields.Machine)"
        '
        'textBox21
        '
        Me.textBox21.Format = "{0:N0}"
        Me.textBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox21.Name = "textBox21"
        Me.textBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox21.StyleName = "Normal.TableBody"
        Me.textBox21.Value = "= Sum(Fields.Machine2)"
        '
        'textBox22
        '
        Me.textBox22.Format = "{0:N0}"
        Me.textBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox22.Name = "textBox22"
        Me.textBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox22.StyleName = "Normal.TableBody"
        Me.textBox22.Value = "= Sum(Fields.Man)"
        '
        'textBox23
        '
        Me.textBox23.Format = "{0:N0}"
        Me.textBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox23.Name = "textBox23"
        Me.textBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox23.StyleName = "Normal.TableBody"
        Me.textBox23.Value = "= Sum(Fields.Material)"
        '
        'textBox24
        '
        Me.textBox24.Format = "{0:N0}"
        Me.textBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox24.Name = "textBox24"
        Me.textBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox24.StyleName = "Normal.TableBody"
        Me.textBox24.Value = "= Sum(Fields.Material2)"
        '
        'textBox25
        '
        Me.textBox25.Format = "{0:N0}"
        Me.textBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox25.Name = "textBox25"
        Me.textBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox25.StyleName = "Normal.TableBody"
        Me.textBox25.Value = "= Sum(Fields.Other)"
        '
        'textBox26
        '
        Me.textBox26.Format = "{0:N0}"
        Me.textBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox26.Name = "textBox26"
        Me.textBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox26.StyleName = "Normal.TableBody"
        Me.textBox26.Value = "= Sum(Fields.Method)"
        '
        'textBox27
        '
        Me.textBox27.Format = "{0:N0}"
        Me.textBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox27.Name = "textBox27"
        Me.textBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox27.StyleName = "Normal.TableBody"
        Me.textBox27.Value = "= Sum(Fields.Setup)"
        '
        'textBox15
        '
        Me.textBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox15.Name = "textBox15"
        Me.textBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox15.StyleName = "Normal.TableCorner"
        Me.textBox15.Value = ""
        '
        'textBox16
        '
        Me.textBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox16.Name = "textBox16"
        Me.textBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox16.Style.Font.Bold = True
        Me.textBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox16.StyleName = "Normal.TableHeader"
        Me.textBox16.Value = "DATE"
        '
        'textBox14
        '
        Me.textBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox14.Name = "textBox14"
        Me.textBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox14.StyleName = "Normal.TableGroup"
        Me.textBox14.Value = "= Fields.fldDate.ToString(""yyyy-MM-dd"") + "" - "" + Fields.fldDay"
        '
        'textBox2
        '
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.263R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox2.StyleName = "Normal.TableGroup"
        Me.textBox2.Value = "= Fields.fldShift"
        '
        'textBox3
        '
        Me.textBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox3.Style.Font.Bold = True
        Me.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox3.StyleName = "Normal.TableHeader"
        Me.textBox3.Value = "AFTER PM"
        '
        'textBox4
        '
        Me.textBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox4.Style.Font.Bold = True
        Me.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox4.StyleName = "Normal.TableHeader"
        Me.textBox4.Value = "AFTER SETUP"
        '
        'textBox5
        '
        Me.textBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox5.Style.Font.Bold = True
        Me.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox5.StyleName = "Normal.TableHeader"
        Me.textBox5.Value = "KANBAN"
        '
        'textBox6
        '
        Me.textBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox6.Style.Font.Bold = True
        Me.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox6.StyleName = "Normal.TableHeader"
        Me.textBox6.Value = "MACHINE"
        '
        'textBox7
        '
        Me.textBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox7.Style.Font.Bold = True
        Me.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox7.StyleName = "Normal.TableHeader"
        Me.textBox7.Value = "MACHINE2"
        '
        'textBox8
        '
        Me.textBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox8.Style.Font.Bold = True
        Me.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox8.StyleName = "Normal.TableHeader"
        Me.textBox8.Value = "MAN"
        '
        'textBox9
        '
        Me.textBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox9.Style.Font.Bold = True
        Me.textBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox9.StyleName = "Normal.TableHeader"
        Me.textBox9.Value = "MATERIAL"
        '
        'textBox10
        '
        Me.textBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox10.Style.Font.Bold = True
        Me.textBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox10.StyleName = "Normal.TableHeader"
        Me.textBox10.Value = "MATERIAL2"
        '
        'textBox11
        '
        Me.textBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox11.Style.Font.Bold = True
        Me.textBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox11.StyleName = "Normal.TableHeader"
        Me.textBox11.Value = "OTHERS"
        '
        'textBox12
        '
        Me.textBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox12.Style.Font.Bold = True
        Me.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox12.StyleName = "Normal.TableHeader"
        Me.textBox12.Value = "METHOD"
        '
        'textBox13
        '
        Me.textBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox13.Name = "textBox13"
        Me.textBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.933R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox13.Style.Font.Bold = True
        Me.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox13.StyleName = "Normal.TableHeader"
        Me.textBox13.Value = "SETUP"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.6R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'rptSRCDowntimeGraphPerShift
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detailSection1, Me.pageFooterSection1})
        Me.Name = "SRCDowntimeGraphperShift"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A3
        ReportParameter1.Name = "parDateFrom"
        ReportParameter1.Text = "parDateFrom"
        ReportParameter1.Value = "2025-02-01"
        ReportParameter2.Name = "parDateTo"
        ReportParameter2.Text = "parDateTo"
        ReportParameter2.Value = "2025-02-12"
        ReportParameter3.Name = "parLine"
        ReportParameter3.Text = "parLine"
        ReportParameter3.Value = "L1"
        ReportParameter4.Name = "parModel"
        ReportParameter4.Text = "parModel"
        ReportParameter4.Value = "TMR-051"
        ReportParameter5.Name = "parType"
        ReportParameter5.Text = "parType"
        ReportParameter5.Value = "ASSY"
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
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableCorner")})
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule5.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule5.Style.Font.Name = "Tahoma"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        DescendantSelector3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableHeader")})
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector3})
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule6.Style.Font.Name = "Tahoma"
        StyleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableGroup")})
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector4})
        StyleRule7.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule7.Style.Font.Name = "Tahoma"
        StyleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(14.535R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents sqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents graph2 As Telerik.Reporting.Graph
    Friend WithEvents cartesianCoordinateSystem2 As Telerik.Reporting.CartesianCoordinateSystem
    Friend WithEvents graphAxis4 As Telerik.Reporting.GraphAxis
    Friend WithEvents graphAxis3 As Telerik.Reporting.GraphAxis
    Friend WithEvents barSeries12 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries13 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries14 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries15 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries16 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries17 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries18 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries19 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries20 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries21 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries22 As Telerik.Reporting.BarSeries
    Friend WithEvents crosstab1 As Telerik.Reporting.Crosstab
    Friend WithEvents textBox17 As Telerik.Reporting.TextBox
    Friend WithEvents textBox18 As Telerik.Reporting.TextBox
    Friend WithEvents textBox19 As Telerik.Reporting.TextBox
    Friend WithEvents textBox20 As Telerik.Reporting.TextBox
    Friend WithEvents textBox21 As Telerik.Reporting.TextBox
    Friend WithEvents textBox22 As Telerik.Reporting.TextBox
    Friend WithEvents textBox23 As Telerik.Reporting.TextBox
    Friend WithEvents textBox24 As Telerik.Reporting.TextBox
    Friend WithEvents textBox25 As Telerik.Reporting.TextBox
    Friend WithEvents textBox26 As Telerik.Reporting.TextBox
    Friend WithEvents textBox27 As Telerik.Reporting.TextBox
    Friend WithEvents textBox3 As Telerik.Reporting.TextBox
    Friend WithEvents textBox4 As Telerik.Reporting.TextBox
    Friend WithEvents textBox5 As Telerik.Reporting.TextBox
    Friend WithEvents textBox6 As Telerik.Reporting.TextBox
    Friend WithEvents textBox7 As Telerik.Reporting.TextBox
    Friend WithEvents textBox8 As Telerik.Reporting.TextBox
    Friend WithEvents textBox9 As Telerik.Reporting.TextBox
    Friend WithEvents textBox10 As Telerik.Reporting.TextBox
    Friend WithEvents textBox11 As Telerik.Reporting.TextBox
    Friend WithEvents textBox12 As Telerik.Reporting.TextBox
    Friend WithEvents textBox13 As Telerik.Reporting.TextBox
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
    Friend WithEvents textBox15 As Telerik.Reporting.TextBox
    Friend WithEvents textBox16 As Telerik.Reporting.TextBox
    Friend WithEvents textBox14 As Telerik.Reporting.TextBox
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
End Class