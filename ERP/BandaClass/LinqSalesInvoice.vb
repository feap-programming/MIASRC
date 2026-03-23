Imports System.ComponentModel
Imports FEAPNS.DataAccess

Public Module LinqSalesInvoice

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)

    Public Function SelectSalesInvoiceSummary(argDateFrom As Date, argDateTo As Date) As DataTable

        myDB.AddMySqlParameters("parDateFrom", argDateFrom)
        myDB.AddMySqlParameters("parDateTo", argDateTo)
        Dim dtSalesInvoiceSummary As DataTable = myDB.SPSelect("SP_P_SelectSalesInvoiceSummaryReport")

        Dim minInvoiceNo = (From T0 In dtSalesInvoiceSummary.AsEnumerable Select T0).ToList.Min(Function(x) x.Field(Of Int64)("fldInvoiceNo"))
        Dim maxInvoiceNo = (From T0 In dtSalesInvoiceSummary.AsEnumerable Select T0).ToList.Max(Function(x) x.Field(Of Int64)("fldInvoiceNo"))

        Dim dtInvoiceNo As New DataTable
        dtInvoiceNo.Columns.Add("fldInvoiceNo", GetType(Int64))
        For invNo As Int64 = minInvoiceNo To maxInvoiceNo
            dtInvoiceNo.Rows.Add(invNo)
        Next

        Dim tblSalesInvoiceSummary = (
                From T0 In dtInvoiceNo.AsEnumerable
                Group Join T1 In dtSalesInvoiceSummary.AsEnumerable
                    On T0.Field(Of Int64)("fldInvoiceNo") Equals T1.Field(Of Int64)("fldInvoiceNo")
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Select New With
                    {
                        Key .fldInvoiceNo = T0.Field(Of Int64)("fldInvoiceNo"),
                        Key .fldFASInvoiceNo = T1?.Field(Of String)("fldFASInvoiceNo"),
                        Key .fldJPY = If(T1 IsNot Nothing, T1.Field(Of Decimal)("fldJPY"), 0),
                        Key .fldUSD = If(T1 IsNot Nothing, T1.Field(Of Decimal)("fldUSD"), 0),
                        Key .fldETDFEAP = If(T1 IsNot Nothing, T1.Field(Of Date)("fldETDFEAP"), DBNull.Value),
                        Key .fldActivity = T1?.Field(Of String)("fldActivity"),
                        Key .fldQty = If(T1 IsNot Nothing, T1.Field(Of Decimal)("fldQty"), 0),
                        Key .fldCustomer = T1?.Field(Of String)("fldCustomer"),
                        Key .fldCustomerName = T1?.Field(Of String)("fldCustomerName"),
                        Key .fldNoOfPackages = T1?.Field(Of String)("fldNoOfPackages"),
                        Key .fldShipVia = T1?.Field(Of String)("fldShipVia"),
                        Key .fldBroker = T1?.Field(Of String)("fldBroker"),
                        Key .fldFreightCondition = T1?.Field(Of String)("fldFreightCondition"),
                        Key .fldBLNo = T1?.Field(Of String)("fldBLNo"),
                        Key .fldBLDate = T1?.Field(Of String)("fldBLDate")
                    }
            ).ToList()

        Return ConvertToDatatable(tblSalesInvoiceSummary)

    End Function

    Public Function ConvertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, prop.PropertyType)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function

End Module
