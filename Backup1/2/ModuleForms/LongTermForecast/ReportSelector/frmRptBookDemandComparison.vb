Imports MIA_Report
Imports Telerik.Reporting

Public Class frmRptBookDemandComparison

    Private customer As String
    Private customerName As String
    Private date1 As Date
    Private date2 As Date

    Private Sub FrmRptBookDemandComparison_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim reportBook = New ReportBook()

        Dim rptDemandComparison = New TypeReportSource With {
            .TypeName = GetType(rptDemandComparison).AssemblyQualifiedName
        }
        rptDemandComparison.Parameters.Add("par0Customer", Me.customer)
        rptDemandComparison.Parameters.Add("par0CustomerName", Me.customerName)
        rptDemandComparison.Parameters.Add("par0Date1", Me.date1)
        rptDemandComparison.Parameters.Add("par0Date2", Me.date2)
        reportBook.ReportSources.Add(rptDemandComparison)

        Dim rptDemandComparison1stMonthGraph = New TypeReportSource With {
            .TypeName = GetType(rptDemandComparison1stMonthGraph).AssemblyQualifiedName
        }
        rptDemandComparison1stMonthGraph.Parameters.Add("par1Customer", Me.customer)
        rptDemandComparison1stMonthGraph.Parameters.Add("par1CustomerName", Me.customerName)
        rptDemandComparison1stMonthGraph.Parameters.Add("par1Date1", Me.date1)
        rptDemandComparison1stMonthGraph.Parameters.Add("par1Date2", Me.date2)
        reportBook.ReportSources.Add(rptDemandComparison1stMonthGraph)

        Dim rptDemandComparison2ndMonthGraph = New TypeReportSource With {
            .TypeName = GetType(rptDemandComparison2ndMonthGraph).AssemblyQualifiedName
        }
        rptDemandComparison2ndMonthGraph.Parameters.Add("par2Customer", Me.customer)
        rptDemandComparison2ndMonthGraph.Parameters.Add("par2CustomerName", Me.customerName)
        rptDemandComparison2ndMonthGraph.Parameters.Add("par2Date1", Me.date1)
        rptDemandComparison2ndMonthGraph.Parameters.Add("par2Date2", Me.date2)
        reportBook.ReportSources.Add(rptDemandComparison2ndMonthGraph)

        Dim rptDemandComparison3rdMonthGraph = New TypeReportSource With {
            .TypeName = GetType(rptDemandComparison3rdMonthGraph).AssemblyQualifiedName
        }
        rptDemandComparison3rdMonthGraph.Parameters.Add("par3Customer", Me.customer)
        rptDemandComparison3rdMonthGraph.Parameters.Add("par3CustomerName", Me.customerName)
        rptDemandComparison3rdMonthGraph.Parameters.Add("par3Date1", Me.date1)
        rptDemandComparison3rdMonthGraph.Parameters.Add("par3Date2", Me.date2)
        reportBook.ReportSources.Add(rptDemandComparison3rdMonthGraph)

        Dim rptDemandComparisonTotalGraph = New TypeReportSource With {
            .TypeName = GetType(rptDemandComparisonTotalGraph).AssemblyQualifiedName
        }
        rptDemandComparisonTotalGraph.Parameters.Add("par4Customer", Me.customer)
        rptDemandComparisonTotalGraph.Parameters.Add("par4CustomerName", Me.customerName)
        rptDemandComparisonTotalGraph.Parameters.Add("par4Date1", Me.date1)
        rptDemandComparisonTotalGraph.Parameters.Add("par4Date2", Me.date2)
        reportBook.ReportSources.Add(rptDemandComparisonTotalGraph)

        rvBookDemandComparison.ReportSource = New InstanceReportSource With {.ReportDocument = reportBook}

        ' ---------- End Report Server Connection ----------

        Me.rvBookDemandComparison.RefreshReport()

        Me.rvBookDemandComparison.ZoomPercent = 100

        Me.rvBookDemandComparison.RefreshReport()

    End Sub

    Public Overloads Sub Show(customer As String, customerName As String, date1 As Date, date2 As Date)
        Me.customer = customer
        Me.customerName = customerName
        Me.date1 = date1
        Me.date2 = date2
        Me.Show()
    End Sub

End Class
