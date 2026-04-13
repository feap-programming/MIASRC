Partial Class rptSRCDowntimeGraphPerDay

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSRCDowntimeGraphPerDay))
        Dim GraphGroup1 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphTitle1 As Telerik.Reporting.GraphTitle = New Telerik.Reporting.GraphTitle()
        Dim DateTimeScale1 As Telerik.Reporting.DateTimeScale = New Telerik.Reporting.DateTimeScale()
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
        Dim TableGroup14 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
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
        Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector3 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule8 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector4 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule9 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector5 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule10 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector6 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.ForGraph = New Telerik.Reporting.SqlDataSource()
        Me.Summary = New Telerik.Reporting.SqlDataSource()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.graph1 = New Telerik.Reporting.Graph()
        Me.graphAxis2 = New Telerik.Reporting.GraphAxis()
        Me.graphAxis1 = New Telerik.Reporting.GraphAxis()
        Me.cartesianCoordinateSystem1 = New Telerik.Reporting.CartesianCoordinateSystem()
        Me.barSeries1 = New Telerik.Reporting.BarSeries()
        Me.barSeries2 = New Telerik.Reporting.BarSeries()
        Me.barSeries3 = New Telerik.Reporting.BarSeries()
        Me.barSeries4 = New Telerik.Reporting.BarSeries()
        Me.barSeries5 = New Telerik.Reporting.BarSeries()
        Me.barSeries6 = New Telerik.Reporting.BarSeries()
        Me.barSeries7 = New Telerik.Reporting.BarSeries()
        Me.barSeries8 = New Telerik.Reporting.BarSeries()
        Me.barSeries9 = New Telerik.Reporting.BarSeries()
        Me.barSeries10 = New Telerik.Reporting.BarSeries()
        Me.barSeries11 = New Telerik.Reporting.BarSeries()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.crosstab1 = New Telerik.Reporting.Crosstab()
        Me.textBox40 = New Telerik.Reporting.TextBox()
        Me.textBox41 = New Telerik.Reporting.TextBox()
        Me.textBox42 = New Telerik.Reporting.TextBox()
        Me.textBox43 = New Telerik.Reporting.TextBox()
        Me.textBox44 = New Telerik.Reporting.TextBox()
        Me.textBox45 = New Telerik.Reporting.TextBox()
        Me.textBox46 = New Telerik.Reporting.TextBox()
        Me.textBox47 = New Telerik.Reporting.TextBox()
        Me.textBox48 = New Telerik.Reporting.TextBox()
        Me.textBox49 = New Telerik.Reporting.TextBox()
        Me.textBox39 = New Telerik.Reporting.TextBox()
        Me.textBox50 = New Telerik.Reporting.TextBox()
        Me.textBox51 = New Telerik.Reporting.TextBox()
        Me.textBox52 = New Telerik.Reporting.TextBox()
        Me.textBox53 = New Telerik.Reporting.TextBox()
        Me.textBox54 = New Telerik.Reporting.TextBox()
        Me.textBox55 = New Telerik.Reporting.TextBox()
        Me.textBox56 = New Telerik.Reporting.TextBox()
        Me.textBox57 = New Telerik.Reporting.TextBox()
        Me.textBox58 = New Telerik.Reporting.TextBox()
        Me.textBox38 = New Telerik.Reporting.TextBox()
        Me.textBox37 = New Telerik.Reporting.TextBox()
        Me.textBox26 = New Telerik.Reporting.TextBox()
        Me.textBox27 = New Telerik.Reporting.TextBox()
        Me.textBox28 = New Telerik.Reporting.TextBox()
        Me.textBox29 = New Telerik.Reporting.TextBox()
        Me.textBox30 = New Telerik.Reporting.TextBox()
        Me.textBox31 = New Telerik.Reporting.TextBox()
        Me.textBox32 = New Telerik.Reporting.TextBox()
        Me.textBox33 = New Telerik.Reporting.TextBox()
        Me.textBox34 = New Telerik.Reporting.TextBox()
        Me.textBox35 = New Telerik.Reporting.TextBox()
        Me.textBox36 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'ForGraph
        '
        Me.ForGraph.ConnectionString = "MIA.My.MySettings.dbMIA"
        Me.ForGraph.Name = "ForGraph"
        Me.ForGraph.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parDateFrom", System.Data.DbType.[String], "= Parameters.parDateFrom.Value"))
        Me.ForGraph.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parDateTo", System.Data.DbType.[String], "= Parameters.parDateTo.Value"))
        Me.ForGraph.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parLine", System.Data.DbType.[String], "= Parameters.parLine.Value"))
        Me.ForGraph.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parModel", System.Data.DbType.[String], "= Parameters.parModel.Value"))
        Me.ForGraph.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parType", System.Data.DbType.[String], "= Parameters.parType.Value"))
        Me.ForGraph.SelectCommand = "dbMIA.SP_SRC_SelectDowntimeGraphByDateForGraph"
        Me.ForGraph.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'Summary
        '
        Me.Summary.ConnectionString = "MIA.My.MySettings.dbMIA"
        Me.Summary.Name = "Summary"
        Me.Summary.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@parDTID", System.Data.DbType.[String], "= Parameters.parDTID.Value"))
        Me.Summary.SelectCommand = resources.GetString("Summary.SelectCommand")
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(21.622R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.graph1, Me.textBox1, Me.crosstab1})
        Me.detailSection1.Name = "detailSection1"
        '
        'graph1
        '
        GraphGroup1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDate"))
        GraphGroup1.Label = "= Fields.fldDate.ToString(""yyyy-MM-dd"")"
        GraphGroup1.Name = "fldDateGroup"
        GraphGroup1.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldDate", Telerik.Reporting.SortDirection.Asc))
        Me.graph1.CategoryGroups.Add(GraphGroup1)
        Me.graph1.CoordinateSystems.Add(Me.cartesianCoordinateSystem1)
        Me.graph1.DataSource = Me.ForGraph
        Me.graph1.Legend.Style.Font.Bold = True
        Me.graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray
        Me.graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.graph1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.913R))
        Me.graph1.Name = "graph1"
        Me.graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray
        Me.graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.graph1.Series.Add(Me.barSeries1)
        Me.graph1.Series.Add(Me.barSeries2)
        Me.graph1.Series.Add(Me.barSeries3)
        Me.graph1.Series.Add(Me.barSeries4)
        Me.graph1.Series.Add(Me.barSeries5)
        Me.graph1.Series.Add(Me.barSeries6)
        Me.graph1.Series.Add(Me.barSeries7)
        Me.graph1.Series.Add(Me.barSeries8)
        Me.graph1.Series.Add(Me.barSeries9)
        Me.graph1.Series.Add(Me.barSeries10)
        Me.graph1.Series.Add(Me.barSeries11)
        Me.graph1.SeriesGroups.Add(GraphGroup2)
        Me.graph1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(14.9R), Telerik.Reporting.Drawing.Unit.Inch(4.3R))
        Me.graph1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.graph1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        GraphTitle1.Position = Telerik.Reporting.GraphItemPosition.TopCenter
        GraphTitle1.Style.Font.Bold = True
        GraphTitle1.Style.LineColor = System.Drawing.Color.LightGray
        GraphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        GraphTitle1.Text = "DOWNTIME GRAPH"
        Me.graph1.Titles.Add(GraphTitle1)
        '
        'graphAxis2
        '
        Me.graphAxis2.LabelFormat = "{0:dd}"
        Me.graphAxis2.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis2.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis2.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis2.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis2.MinorGridLineStyle.Visible = False
        Me.graphAxis2.Name = "graphAxis2"
        Me.graphAxis2.Scale = DateTimeScale1
        Me.graphAxis2.Style.Font.Bold = True
        Me.graphAxis2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        '
        'graphAxis1
        '
        Me.graphAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis1.MinorGridLineStyle.Visible = False
        Me.graphAxis1.Name = "graphAxis1"
        Me.graphAxis1.Scale = NumericalScale1
        '
        'cartesianCoordinateSystem1
        '
        Me.cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1"
        Me.cartesianCoordinateSystem1.XAxis = Me.graphAxis2
        Me.cartesianCoordinateSystem1.YAxis = Me.graphAxis1
        '
        'barSeries1
        '
        Me.barSeries1.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries1.CategoryGroup = GraphGroup1
        Me.barSeries1.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries1.DataPointLabel = "= Sum(Fields.AfterPM)"
        Me.barSeries1.DataPointLabelStyle.Visible = False
        Me.barSeries1.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries1.DataPointStyle.Visible = True
        Me.barSeries1.LegendItem.Value = "AFTER PM"
        Me.barSeries1.Name = "barSeries1"
        GraphGroup2.Name = "seriesGroup"
        Me.barSeries1.SeriesGroup = GraphGroup2
        Me.barSeries1.ToolTip.Text = "AfterPM"
        Me.barSeries1.ToolTip.Title = "'Sum(AfterPM)'"
        Me.barSeries1.X = "= Fields.fldDate"
        Me.barSeries1.Y = "= Sum(Fields.AfterPM)"
        '
        'barSeries2
        '
        Me.barSeries2.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries2.CategoryGroup = GraphGroup1
        Me.barSeries2.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries2.DataPointLabel = "= Sum(Fields.AfterSetup)"
        Me.barSeries2.DataPointLabelStyle.Visible = False
        Me.barSeries2.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries2.DataPointStyle.Visible = True
        Me.barSeries2.LegendItem.Value = "AFTER SETUP"
        Me.barSeries2.Name = "barSeries2"
        Me.barSeries2.SeriesGroup = GraphGroup2
        Me.barSeries2.ToolTip.Text = "= Sum(Fields.AfterSetup)"
        Me.barSeries2.ToolTip.Title = "'Sum(AfterSetup)'"
        Me.barSeries2.X = "= Fields.fldDate"
        Me.barSeries2.Y = "= Sum(Fields.AfterSetup)"
        '
        'barSeries3
        '
        Me.barSeries3.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries3.CategoryGroup = GraphGroup1
        Me.barSeries3.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries3.DataPointLabel = "= Sum(Fields.Kanban)"
        Me.barSeries3.DataPointLabelStyle.Visible = False
        Me.barSeries3.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries3.DataPointStyle.Visible = True
        Me.barSeries3.LegendItem.Value = "KANBAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.barSeries3.Name = "barSeries3"
        Me.barSeries3.SeriesGroup = GraphGroup2
        Me.barSeries3.ToolTip.Text = "= Sum(Fields.Kanban)"
        Me.barSeries3.ToolTip.Title = "'Sum(Kanban)'"
        Me.barSeries3.X = "= Fields.fldDate"
        Me.barSeries3.Y = "= Sum(Fields.Kanban)"
        '
        'barSeries4
        '
        Me.barSeries4.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries4.CategoryGroup = GraphGroup1
        Me.barSeries4.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries4.DataPointLabel = "= Sum(Fields.Machine)"
        Me.barSeries4.DataPointLabelStyle.Visible = False
        Me.barSeries4.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries4.DataPointStyle.Visible = True
        Me.barSeries4.LegendItem.Value = "MACHINE"
        Me.barSeries4.Name = "barSeries4"
        Me.barSeries4.SeriesGroup = GraphGroup2
        Me.barSeries4.ToolTip.Text = "= Sum(Fields.Machine)"
        Me.barSeries4.ToolTip.Title = "'Sum(Machine)'"
        Me.barSeries4.X = "= Fields.fldDate"
        Me.barSeries4.Y = "= Sum(Fields.Machine)"
        '
        'barSeries5
        '
        Me.barSeries5.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries5.CategoryGroup = GraphGroup1
        Me.barSeries5.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries5.DataPointLabel = "= Sum(Fields.Machine2)"
        Me.barSeries5.DataPointLabelStyle.Visible = False
        Me.barSeries5.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries5.DataPointStyle.Visible = True
        Me.barSeries5.LegendItem.Value = "MACHINE 2"
        Me.barSeries5.Name = "barSeries5"
        Me.barSeries5.SeriesGroup = GraphGroup2
        Me.barSeries5.ToolTip.Text = "= Sum(Fields.Machine2)"
        Me.barSeries5.ToolTip.Title = "'Sum(Machine2)'"
        Me.barSeries5.X = "= Fields.fldDate"
        Me.barSeries5.Y = "= Sum(Fields.Machine2)"
        '
        'barSeries6
        '
        Me.barSeries6.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries6.CategoryGroup = GraphGroup1
        Me.barSeries6.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries6.DataPointLabel = "= Sum(Fields.Man)"
        Me.barSeries6.DataPointLabelStyle.Visible = False
        Me.barSeries6.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries6.DataPointStyle.Visible = True
        Me.barSeries6.LegendItem.Value = "MAN"
        Me.barSeries6.Name = "barSeries6"
        Me.barSeries6.SeriesGroup = GraphGroup2
        Me.barSeries6.ToolTip.Text = "= Sum(Fields.Man)"
        Me.barSeries6.ToolTip.Title = "'Sum(Man)'"
        Me.barSeries6.X = "= Fields.fldDate"
        Me.barSeries6.Y = "= Sum(Fields.Man)"
        '
        'barSeries7
        '
        Me.barSeries7.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries7.CategoryGroup = GraphGroup1
        Me.barSeries7.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries7.DataPointLabel = "= Sum(Fields.Material)"
        Me.barSeries7.DataPointLabelStyle.Visible = False
        Me.barSeries7.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries7.DataPointStyle.Visible = True
        Me.barSeries7.LegendItem.Value = "MATERIAL"
        Me.barSeries7.Name = "barSeries7"
        Me.barSeries7.SeriesGroup = GraphGroup2
        Me.barSeries7.ToolTip.Text = "= Sum(Fields.Material)"
        Me.barSeries7.ToolTip.Title = "'Sum(Material)'"
        Me.barSeries7.X = "= Fields.fldDate"
        Me.barSeries7.Y = "= Sum(Fields.Material)"
        '
        'barSeries8
        '
        Me.barSeries8.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries8.CategoryGroup = GraphGroup1
        Me.barSeries8.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries8.DataPointLabel = "= Sum(Fields.Material2)"
        Me.barSeries8.DataPointLabelStyle.Visible = False
        Me.barSeries8.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries8.DataPointStyle.Visible = True
        Me.barSeries8.LegendItem.Value = "MATERIAL 2"
        Me.barSeries8.Name = "barSeries8"
        Me.barSeries8.SeriesGroup = GraphGroup2
        Me.barSeries8.ToolTip.Text = "= Sum(Fields.Material2)"
        Me.barSeries8.ToolTip.Title = "'Sum(Material2)'"
        Me.barSeries8.X = "= Fields.fldDate"
        Me.barSeries8.Y = "= Sum(Fields.Material2)"
        '
        'barSeries9
        '
        Me.barSeries9.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries9.CategoryGroup = GraphGroup1
        Me.barSeries9.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries9.DataPointLabel = "= Sum(Fields.Method)"
        Me.barSeries9.DataPointLabelStyle.Visible = False
        Me.barSeries9.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries9.DataPointStyle.Visible = True
        Me.barSeries9.LegendItem.Value = "METHOD"
        Me.barSeries9.Name = "barSeries9"
        Me.barSeries9.SeriesGroup = GraphGroup2
        Me.barSeries9.ToolTip.Text = "= Sum(Fields.Method)"
        Me.barSeries9.ToolTip.Title = "'Sum(Method)'"
        Me.barSeries9.X = "= Fields.fldDate"
        Me.barSeries9.Y = "= Sum(Fields.Method)"
        '
        'barSeries10
        '
        Me.barSeries10.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries10.CategoryGroup = GraphGroup1
        Me.barSeries10.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries10.DataPointLabel = "= Sum(Fields.Other)"
        Me.barSeries10.DataPointLabelStyle.Visible = False
        Me.barSeries10.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries10.DataPointStyle.Visible = True
        Me.barSeries10.LegendItem.Value = "OTHERS"
        Me.barSeries10.Name = "barSeries10"
        Me.barSeries10.SeriesGroup = GraphGroup2
        Me.barSeries10.ToolTip.Text = "= Sum(Fields.Other)"
        Me.barSeries10.ToolTip.Title = "'Sum(Other)'"
        Me.barSeries10.X = "= Fields.fldDate"
        Me.barSeries10.Y = "= Sum(Fields.Other)"
        '
        'barSeries11
        '
        Me.barSeries11.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked
        Me.barSeries11.CategoryGroup = GraphGroup1
        Me.barSeries11.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.barSeries11.DataPointLabel = "= Sum(Fields.Setup)"
        Me.barSeries11.DataPointLabelStyle.Visible = False
        Me.barSeries11.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.barSeries11.DataPointStyle.Visible = True
        Me.barSeries11.LegendItem.Value = "SETUP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.barSeries11.Name = "barSeries11"
        Me.barSeries11.SeriesGroup = GraphGroup2
        Me.barSeries11.ToolTip.Text = "= Sum(Fields.Setup)"
        Me.barSeries11.ToolTip.Title = "'Sum(Setup)'"
        Me.barSeries11.X = "= Fields.fldDate"
        Me.barSeries11.Y = "= Sum(Fields.Setup)"
        '
        'textBox1
        '
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.113R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(14.9R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.textBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox1.Style.Font.Bold = True
        Me.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(40.0R)
        Me.textBox1.Value = "{Parameters.parType.Value} DOWNTIME GRAPH OF {Parameters.parModel.Value} {Paramet" &
    "ers.parLine.Value} FOR {Parameters.parDateFrom.Value} TO {Parameters.parDateTo.V" &
    "alue}"
        '
        'crosstab1
        '
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.173R)))
        Me.crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2R)))
        Me.crosstab1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2R)))
        Me.crosstab1.Body.SetCellContent(0, 0, Me.textBox40)
        Me.crosstab1.Body.SetCellContent(0, 1, Me.textBox41)
        Me.crosstab1.Body.SetCellContent(0, 2, Me.textBox42)
        Me.crosstab1.Body.SetCellContent(0, 3, Me.textBox43)
        Me.crosstab1.Body.SetCellContent(0, 4, Me.textBox44)
        Me.crosstab1.Body.SetCellContent(0, 5, Me.textBox45)
        Me.crosstab1.Body.SetCellContent(0, 6, Me.textBox46)
        Me.crosstab1.Body.SetCellContent(0, 7, Me.textBox47)
        Me.crosstab1.Body.SetCellContent(0, 8, Me.textBox48)
        Me.crosstab1.Body.SetCellContent(0, 9, Me.textBox49)
        Me.crosstab1.Body.SetCellContent(1, 0, Me.textBox39)
        Me.crosstab1.Body.SetCellContent(1, 1, Me.textBox50)
        Me.crosstab1.Body.SetCellContent(1, 2, Me.textBox51)
        Me.crosstab1.Body.SetCellContent(1, 3, Me.textBox52)
        Me.crosstab1.Body.SetCellContent(1, 4, Me.textBox53)
        Me.crosstab1.Body.SetCellContent(1, 5, Me.textBox54)
        Me.crosstab1.Body.SetCellContent(1, 6, Me.textBox55)
        Me.crosstab1.Body.SetCellContent(1, 7, Me.textBox56)
        Me.crosstab1.Body.SetCellContent(1, 8, Me.textBox57)
        Me.crosstab1.Body.SetCellContent(1, 9, Me.textBox58)
        TableGroup1.Name = "afterPM1"
        TableGroup1.ReportItem = Me.textBox27
        TableGroup2.Name = "kanban1"
        TableGroup2.ReportItem = Me.textBox28
        TableGroup3.Name = "machine1"
        TableGroup3.ReportItem = Me.textBox29
        TableGroup4.Name = "machine21"
        TableGroup4.ReportItem = Me.textBox30
        TableGroup5.Name = "man1"
        TableGroup5.ReportItem = Me.textBox31
        TableGroup6.Name = "material1"
        TableGroup6.ReportItem = Me.textBox32
        TableGroup7.Name = "material21"
        TableGroup7.ReportItem = Me.textBox33
        TableGroup8.Name = "method1"
        TableGroup8.ReportItem = Me.textBox34
        TableGroup9.Name = "other1"
        TableGroup9.ReportItem = Me.textBox35
        TableGroup10.Name = "setup1"
        TableGroup10.ReportItem = Me.textBox36
        Me.crosstab1.ColumnGroups.Add(TableGroup1)
        Me.crosstab1.ColumnGroups.Add(TableGroup2)
        Me.crosstab1.ColumnGroups.Add(TableGroup3)
        Me.crosstab1.ColumnGroups.Add(TableGroup4)
        Me.crosstab1.ColumnGroups.Add(TableGroup5)
        Me.crosstab1.ColumnGroups.Add(TableGroup6)
        Me.crosstab1.ColumnGroups.Add(TableGroup7)
        Me.crosstab1.ColumnGroups.Add(TableGroup8)
        Me.crosstab1.ColumnGroups.Add(TableGroup9)
        Me.crosstab1.ColumnGroups.Add(TableGroup10)
        Me.crosstab1.Corner.SetCellContent(0, 0, Me.textBox38)
        Me.crosstab1.DataSource = Me.ForGraph
        Me.crosstab1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox38, Me.textBox40, Me.textBox41, Me.textBox42, Me.textBox43, Me.textBox44, Me.textBox45, Me.textBox46, Me.textBox47, Me.textBox48, Me.textBox49, Me.textBox39, Me.textBox50, Me.textBox51, Me.textBox52, Me.textBox53, Me.textBox54, Me.textBox55, Me.textBox56, Me.textBox57, Me.textBox58, Me.textBox37, Me.textBox26, Me.textBox27, Me.textBox28, Me.textBox29, Me.textBox30, Me.textBox31, Me.textBox32, Me.textBox33, Me.textBox34, Me.textBox35, Me.textBox36})
        Me.crosstab1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(5.313R))
        Me.crosstab1.Name = "crosstab1"
        TableGroup12.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup12.Name = "detail"
        TableGroup11.ChildGroups.Add(TableGroup12)
        TableGroup11.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.fldDate"))
        TableGroup11.Name = "fldDate1"
        TableGroup11.ReportItem = Me.textBox37
        TableGroup11.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.fldDate", Telerik.Reporting.SortDirection.Asc))
        TableGroup14.Name = "group1"
        TableGroup13.ChildGroups.Add(TableGroup14)
        TableGroup13.Name = "group"
        TableGroup13.ReportItem = Me.textBox26
        Me.crosstab1.RowGroups.Add(TableGroup11)
        Me.crosstab1.RowGroups.Add(TableGroup13)
        Me.crosstab1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(12.903R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.crosstab1.StyleName = "Normal.TableNormal"
        '
        'textBox40
        '
        Me.textBox40.Format = "{0:N0}"
        Me.textBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox40.Name = "textBox40"
        Me.textBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox40.StyleName = "Normal.TableBody"
        Me.textBox40.Value = "= Fields.AfterPM"
        '
        'textBox41
        '
        Me.textBox41.Format = "{0:N0}"
        Me.textBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox41.Name = "textBox41"
        Me.textBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox41.StyleName = "Normal.TableBody"
        Me.textBox41.Value = "= Fields.Kanban"
        '
        'textBox42
        '
        Me.textBox42.Format = "{0:N0}"
        Me.textBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox42.Name = "textBox42"
        Me.textBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox42.StyleName = "Normal.TableBody"
        Me.textBox42.Value = "= Fields.Machine"
        '
        'textBox43
        '
        Me.textBox43.Format = "{0:N0}"
        Me.textBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox43.Name = "textBox43"
        Me.textBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox43.StyleName = "Normal.TableBody"
        Me.textBox43.Value = "= Fields.Machine2"
        '
        'textBox44
        '
        Me.textBox44.Format = "{0:N0}"
        Me.textBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox44.Name = "textBox44"
        Me.textBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox44.StyleName = "Normal.TableBody"
        Me.textBox44.Value = "= Fields.Man"
        '
        'textBox45
        '
        Me.textBox45.Format = "{0:N0}"
        Me.textBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox45.Name = "textBox45"
        Me.textBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox45.StyleName = "Normal.TableBody"
        Me.textBox45.Value = "= Fields.Material"
        '
        'textBox46
        '
        Me.textBox46.Format = "{0:N0}"
        Me.textBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox46.Name = "textBox46"
        Me.textBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox46.StyleName = "Normal.TableBody"
        Me.textBox46.Value = "= Fields.Material2"
        '
        'textBox47
        '
        Me.textBox47.Format = "{0:N0}"
        Me.textBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox47.Name = "textBox47"
        Me.textBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox47.StyleName = "Normal.TableBody"
        Me.textBox47.Value = "= Fields.Method"
        '
        'textBox48
        '
        Me.textBox48.Format = "{0:N0}"
        Me.textBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox48.Name = "textBox48"
        Me.textBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox48.StyleName = "Normal.TableBody"
        Me.textBox48.Value = "= Fields.Other"
        '
        'textBox49
        '
        Me.textBox49.Format = "{0:N0}"
        Me.textBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox49.Name = "textBox49"
        Me.textBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox49.StyleName = "Normal.TableBody"
        Me.textBox49.Value = "= Fields.Setup"
        '
        'textBox39
        '
        Me.textBox39.Format = "{0:N0}"
        Me.textBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox39.Name = "textBox39"
        Me.textBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox39.StyleName = "Normal.TableBody"
        Me.textBox39.Value = "=Sum(Fields.AfterPM)"
        '
        'textBox50
        '
        Me.textBox50.Format = "{0:N0}"
        Me.textBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox50.Name = "textBox50"
        Me.textBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox50.StyleName = "Normal.TableBody"
        Me.textBox50.Value = "=Sum(Fields.Kanban)"
        '
        'textBox51
        '
        Me.textBox51.Format = "{0:N0}"
        Me.textBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox51.Name = "textBox51"
        Me.textBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox51.StyleName = "Normal.TableBody"
        Me.textBox51.Value = "=Sum(Fields.Machine)"
        '
        'textBox52
        '
        Me.textBox52.Format = "{0:N0}"
        Me.textBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox52.Name = "textBox52"
        Me.textBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox52.StyleName = "Normal.TableBody"
        Me.textBox52.Value = "=Sum(Fields.Machine2)"
        '
        'textBox53
        '
        Me.textBox53.Format = "{0:N0}"
        Me.textBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox53.Name = "textBox53"
        Me.textBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox53.StyleName = "Normal.TableBody"
        Me.textBox53.Value = "=Sum(Fields.Man)"
        '
        'textBox54
        '
        Me.textBox54.Format = "{0:N0}"
        Me.textBox54.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox54.Name = "textBox54"
        Me.textBox54.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox54.StyleName = "Normal.TableBody"
        Me.textBox54.Value = "=Sum(Fields.Material)"
        '
        'textBox55
        '
        Me.textBox55.Format = "{0:N0}"
        Me.textBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox55.Name = "textBox55"
        Me.textBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox55.StyleName = "Normal.TableBody"
        Me.textBox55.Value = "=Sum(Fields.Material2)"
        '
        'textBox56
        '
        Me.textBox56.Format = "{0:N0}"
        Me.textBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox56.Name = "textBox56"
        Me.textBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox56.StyleName = "Normal.TableBody"
        Me.textBox56.Value = "=Sum(Fields.Method)"
        '
        'textBox57
        '
        Me.textBox57.Format = "{0:N0}"
        Me.textBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox57.Name = "textBox57"
        Me.textBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox57.StyleName = "Normal.TableBody"
        Me.textBox57.Value = "=Sum(Fields.Other)"
        '
        'textBox58
        '
        Me.textBox58.Format = "{0:N0}"
        Me.textBox58.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox58.Name = "textBox58"
        Me.textBox58.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox58.StyleName = "Normal.TableBody"
        Me.textBox58.Value = "=Sum(Fields.Setup)"
        '
        'textBox38
        '
        Me.textBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox38.Name = "textBox38"
        Me.textBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox38.Style.Font.Bold = True
        Me.textBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox38.StyleName = "Normal.TableHeader"
        Me.textBox38.Value = "DATE"
        '
        'textBox37
        '
        Me.textBox37.Format = "{0:d}"
        Me.textBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox37.Name = "textBox37"
        Me.textBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox37.StyleName = "Normal.TableGroup"
        Me.textBox37.Value = "= Fields.fldDate"
        '
        'textBox26
        '
        Me.textBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox26.Name = "textBox26"
        Me.textBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox26.Style.Font.Bold = True
        Me.textBox26.StyleName = "Normal.TableGroup"
        Me.textBox26.Value = "TOTAL:"
        '
        'textBox27
        '
        Me.textBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox27.Name = "textBox27"
        Me.textBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox27.Style.Font.Bold = True
        Me.textBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox27.StyleName = "Normal.TableHeader"
        Me.textBox27.Value = "AFTER PM"
        '
        'textBox28
        '
        Me.textBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox28.Name = "textBox28"
        Me.textBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox28.Style.Font.Bold = True
        Me.textBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox28.StyleName = "Normal.TableHeader"
        Me.textBox28.Value = "KANBAN"
        '
        'textBox29
        '
        Me.textBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox29.Name = "textBox29"
        Me.textBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox29.Style.Font.Bold = True
        Me.textBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox29.StyleName = "Normal.TableHeader"
        Me.textBox29.Value = "MACHINE"
        '
        'textBox30
        '
        Me.textBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox30.Name = "textBox30"
        Me.textBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox30.Style.Font.Bold = True
        Me.textBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox30.StyleName = "Normal.TableHeader"
        Me.textBox30.Value = "MACHINE2"
        '
        'textBox31
        '
        Me.textBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox31.Name = "textBox31"
        Me.textBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox31.Style.Font.Bold = True
        Me.textBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox31.StyleName = "Normal.TableHeader"
        Me.textBox31.Value = "MAN"
        '
        'textBox32
        '
        Me.textBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox32.Name = "textBox32"
        Me.textBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox32.Style.Font.Bold = True
        Me.textBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox32.StyleName = "Normal.TableHeader"
        Me.textBox32.Value = "MATERIAL"
        '
        'textBox33
        '
        Me.textBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox33.Name = "textBox33"
        Me.textBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox33.Style.Font.Bold = True
        Me.textBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox33.StyleName = "Normal.TableHeader"
        Me.textBox33.Value = "MATERIAL2"
        '
        'textBox34
        '
        Me.textBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox34.Name = "textBox34"
        Me.textBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox34.Style.Font.Bold = True
        Me.textBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox34.StyleName = "Normal.TableHeader"
        Me.textBox34.Value = "METHOD"
        '
        'textBox35
        '
        Me.textBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox35.Name = "textBox35"
        Me.textBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox35.Style.Font.Bold = True
        Me.textBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox35.StyleName = "Normal.TableHeader"
        Me.textBox35.Value = "OTHER"
        '
        'textBox36
        '
        Me.textBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox36.Name = "textBox36"
        Me.textBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.173R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox36.Style.Font.Bold = True
        Me.textBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.textBox36.StyleName = "Normal.TableHeader"
        Me.textBox36.Value = "SETUP"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'rptSRCDowntimeGraphPerDay
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detailSection1, Me.pageFooterSection1})
        Me.Name = "SRCDowntimeGraphperDay"
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A3
        ReportParameter1.Name = "parDateFrom"
        ReportParameter1.Text = "parDateFrom"
        ReportParameter1.Value = "2025-01-01"
        ReportParameter2.Name = "parDateTo"
        ReportParameter2.Text = "parDateTo"
        ReportParameter2.Value = "2025-01-31"
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
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Normal.TableNormal")})
        StyleRule6.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule6.Style.Color = System.Drawing.Color.Black
        StyleRule6.Style.Font.Name = "Tahoma"
        StyleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableBody")})
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector3})
        StyleRule7.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule7.Style.Font.Name = "Tahoma"
        StyleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableCorner")})
        StyleRule8.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector4})
        StyleRule8.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule8.Style.Font.Name = "Tahoma"
        StyleRule8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        DescendantSelector5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableHeader")})
        StyleRule9.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector5})
        StyleRule9.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule9.Style.Font.Name = "Tahoma"
        StyleRule9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Normal.TableGroup")})
        StyleRule10.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector6})
        StyleRule10.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule10.Style.Font.Name = "Tahoma"
        StyleRule10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7, StyleRule8, StyleRule9, StyleRule10})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(38.1R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents ForGraph As Telerik.Reporting.SqlDataSource
    Friend WithEvents Summary As Telerik.Reporting.SqlDataSource
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents graph1 As Telerik.Reporting.Graph
    Friend WithEvents cartesianCoordinateSystem1 As Telerik.Reporting.CartesianCoordinateSystem
    Friend WithEvents graphAxis2 As Telerik.Reporting.GraphAxis
    Friend WithEvents graphAxis1 As Telerik.Reporting.GraphAxis
    Friend WithEvents barSeries1 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries2 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries3 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries4 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries5 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries6 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries7 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries8 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries9 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries10 As Telerik.Reporting.BarSeries
    Friend WithEvents barSeries11 As Telerik.Reporting.BarSeries
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents crosstab1 As Telerik.Reporting.Crosstab
    Friend WithEvents textBox40 As Telerik.Reporting.TextBox
    Friend WithEvents textBox41 As Telerik.Reporting.TextBox
    Friend WithEvents textBox42 As Telerik.Reporting.TextBox
    Friend WithEvents textBox43 As Telerik.Reporting.TextBox
    Friend WithEvents textBox44 As Telerik.Reporting.TextBox
    Friend WithEvents textBox45 As Telerik.Reporting.TextBox
    Friend WithEvents textBox46 As Telerik.Reporting.TextBox
    Friend WithEvents textBox47 As Telerik.Reporting.TextBox
    Friend WithEvents textBox48 As Telerik.Reporting.TextBox
    Friend WithEvents textBox49 As Telerik.Reporting.TextBox
    Friend WithEvents textBox39 As Telerik.Reporting.TextBox
    Friend WithEvents textBox50 As Telerik.Reporting.TextBox
    Friend WithEvents textBox51 As Telerik.Reporting.TextBox
    Friend WithEvents textBox52 As Telerik.Reporting.TextBox
    Friend WithEvents textBox53 As Telerik.Reporting.TextBox
    Friend WithEvents textBox54 As Telerik.Reporting.TextBox
    Friend WithEvents textBox55 As Telerik.Reporting.TextBox
    Friend WithEvents textBox56 As Telerik.Reporting.TextBox
    Friend WithEvents textBox57 As Telerik.Reporting.TextBox
    Friend WithEvents textBox58 As Telerik.Reporting.TextBox
    Friend WithEvents textBox27 As Telerik.Reporting.TextBox
    Friend WithEvents textBox28 As Telerik.Reporting.TextBox
    Friend WithEvents textBox29 As Telerik.Reporting.TextBox
    Friend WithEvents textBox30 As Telerik.Reporting.TextBox
    Friend WithEvents textBox31 As Telerik.Reporting.TextBox
    Friend WithEvents textBox32 As Telerik.Reporting.TextBox
    Friend WithEvents textBox33 As Telerik.Reporting.TextBox
    Friend WithEvents textBox34 As Telerik.Reporting.TextBox
    Friend WithEvents textBox35 As Telerik.Reporting.TextBox
    Friend WithEvents textBox36 As Telerik.Reporting.TextBox
    Friend WithEvents textBox38 As Telerik.Reporting.TextBox
    Friend WithEvents textBox37 As Telerik.Reporting.TextBox
    Friend WithEvents textBox26 As Telerik.Reporting.TextBox
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
End Class