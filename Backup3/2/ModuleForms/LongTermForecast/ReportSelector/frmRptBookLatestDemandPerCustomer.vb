Imports MIA_Report
Imports Telerik.Reporting

Public Class FrmRptBookLatestDemandPerCustomer

    Private customer As String
    Private customerName As String
    Private dateFrom As Date
    Private dateTo As Date

    Private Sub FrmRptLatestDemandPerCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Slipknot.changeTheme(Me)

        ' ---------- Report Server Connection ----------

        Dim reportBook = New ReportBook()

        Dim rptLatestDemand = New TypeReportSource With {
            .TypeName = GetType(rptLatestDemand).AssemblyQualifiedName
        }
        rptLatestDemand.Parameters.Add("par0Customer", Me.customer)
        rptLatestDemand.Parameters.Add("par0CustomerName", Me.customerName)
        rptLatestDemand.Parameters.Add("par0DateFrom", Me.dateFrom)
        rptLatestDemand.Parameters.Add("par0DateTo", Me.dateTo)
        reportBook.ReportSources.Add(rptLatestDemand)

        Dim rptLatestDemand1stMonthGraph = New TypeReportSource With {
            .TypeName = GetType(rptLatestDemand1stMonthGraph).AssemblyQualifiedName
        }
        rptLatestDemand1stMonthGraph.Parameters.Add("par1Customer", Me.customer)
        rptLatestDemand1stMonthGraph.Parameters.Add("par1CustomerName", Me.customerName)
        rptLatestDemand1stMonthGraph.Parameters.Add("par1DateFrom", Me.dateFrom)
        rptLatestDemand1stMonthGraph.Parameters.Add("par1DateTo", Me.dateTo)
        reportBook.ReportSources.Add(rptLatestDemand1stMonthGraph)

        Dim rptLatestDemand2ndMonthGraph = New TypeReportSource With {
            .TypeName = GetType(rptLatestDemand2ndMonthGraph).AssemblyQualifiedName
        }
        rptLatestDemand2ndMonthGraph.Parameters.Add("par2Customer", Me.customer)
        rptLatestDemand2ndMonthGraph.Parameters.Add("par2CustomerName", Me.customerName)
        rptLatestDemand2ndMonthGraph.Parameters.Add("par2DateFrom", Me.dateFrom)
        rptLatestDemand2ndMonthGraph.Parameters.Add("par2DateTo", Me.dateTo)
        reportBook.ReportSources.Add(rptLatestDemand2ndMonthGraph)

        Dim rptLatestDemand3rdMonthGraph = New TypeReportSource With {
            .TypeName = GetType(rptLatestDemand3rdMonthGraph).AssemblyQualifiedName
        }
        rptLatestDemand3rdMonthGraph.Parameters.Add("par3Customer", Me.customer)
        rptLatestDemand3rdMonthGraph.Parameters.Add("par3CustomerName", Me.customerName)
        rptLatestDemand3rdMonthGraph.Parameters.Add("par3DateFrom", Me.dateFrom)
        rptLatestDemand3rdMonthGraph.Parameters.Add("par3DateTo", Me.dateTo)
        reportBook.ReportSources.Add(rptLatestDemand3rdMonthGraph)

        Dim rptLatestDemandTotalGraph = New TypeReportSource With {
            .TypeName = GetType(rptLatestDemandTotalGraph).AssemblyQualifiedName
        }
        rptLatestDemandTotalGraph.Parameters.Add("par4Customer", Me.customer)
        rptLatestDemandTotalGraph.Parameters.Add("par4CustomerName", Me.customerName)
        rptLatestDemandTotalGraph.Parameters.Add("par4DateFrom", Me.dateFrom)
        rptLatestDemandTotalGraph.Parameters.Add("par4DateTo", Me.dateTo)
        reportBook.ReportSources.Add(rptLatestDemandTotalGraph)

        rvBookLatestDemand.ReportSource = New InstanceReportSource() With {.ReportDocument = reportBook}

        ' ---------- End Report Server Connection ----------

        Me.rvBookLatestDemand.RefreshReport()

        Me.rvBookLatestDemand.ZoomPercent = 100

        Me.rvBookLatestDemand.RefreshReport()

    End Sub

    Public Overloads Sub Show(customer As String, customerName As String, dateFrom As Date, dateTo As Date)
        Me.customer = customer
        Me.customerName = customerName
        Me.dateFrom = dateFrom
        Me.dateTo = dateTo
        Me.Show()
    End Sub

End Class
