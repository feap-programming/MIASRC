Imports System.ComponentModel
Imports FEAPNS.DataAccess

Public Module Linq_DemandComparison

    Private dbMIA As New DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private tblItemMasterData As DataTable = dbMIA.SPSelect("SP_SelectAllItemMasterData")
    Private tblCustomer As DataTable = dbMIA.SPSelect("SP_SelectAllCustomers")

    Private ReadOnly Property GetCustomerName(customerCode As String) As String
        Get
            Dim row As EnumerableRowCollection(Of DataRow) = tblCustomer.AsEnumerable.Where(Function(x) x.Item("fldCustomerCode") = customerCode)
            If row.Count > 0 Then
                Return row(0).Item("fldCustomerName")
            Else
                Return String.Empty
            End If
        End Get
    End Property

    Public Function SP_P_SelectDemandComparison(customer As String, date1 As Date, date2 As Date) As DataTable

        dbMIA.AddMySqlParameters("customer", customer)
        dbMIA.AddMySqlParameters("date1", date1)
        dbMIA.AddMySqlParameters("date2", date2)
        Return dbMIA.SPSelect("SP_P_SelectDemandComparison")

    End Function

    Public Function SelectDemandComparison(customer As String, date1 As Date, date2 As Date) As DataTable

        Dim tblResult As DataTable = Nothing

        Dim dcDate1 = ( ' Get all item from 1st date
            From T0 In SP_P_SelectDemandComparison(customer, date1, date2).AsEnumerable
            Where T0.Field(Of String)("fldCustomer") = GetCustomerName(customer) And
                T0.Field(Of Date)("fldDateIssued") = date1
            Select New With
                {
                    .fldID = T0.Field(Of Int64)("fldID"),
                    .fldDateUpdated = T0.Field(Of DateTime)("fldDateUpdated"),
                    .fldYearUpdated = T0.Field(Of UInt32)("fldYearUpdated"),
                    .fldMonthUpdated = T0.Field(Of Int32)("fldMonthUpdated"),
                    .fldDateIssued = T0.Field(Of DateTime)("fldDateIssued"),
                    .fldPartNo = T0.Field(Of String)("fldPartNo"),
                    .fldCustomer = T0.Field(Of String)("fldCustomer"),
                    .fldPartName = T0.Field(Of String)("fldPartName"),
                    .fldModel = T0.Field(Of String)("fldModel"),
                    .fldLDYear = T0.Field(Of Integer)("fldLDYear"),
                    .fldLDMonth = T0.Field(Of Integer)("fldLDMonth"),
                    .fldLDMonthName = T0.Field(Of String)("fldLDMonthName"),
                    .fldLatestDemand = T0.Field(Of Decimal)("fldLatestDemand"),
                    .fldLDPercentage = Convert.ToDecimal(0),
                    .fldRemarks = "Latest",
                    .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                    .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                }
        ).ToList()

        Dim dcDate2 = ( ' Get all item from 2nd date
            From T0 In SP_P_SelectDemandComparison(customer, date1, date2).AsEnumerable
            Where T0.Field(Of String)("fldCustomer") = GetCustomerName(customer) And
                T0.Field(Of Date)("fldDateIssued") = date2
            Select New With
                {
                    .fldID = T0.Field(Of Int64)("fldID"),
                    .fldDateUpdated = T0.Field(Of DateTime)("fldDateUpdated"),
                    .fldYearUpdated = T0.Field(Of UInt32)("fldYearUpdated"),
                    .fldMonthUpdated = T0.Field(Of Int32)("fldMonthUpdated"),
                    .fldDateIssued = T0.Field(Of DateTime)("fldDateIssued"),
                    .fldPartNo = T0.Field(Of String)("fldPartNo"),
                    .fldCustomer = T0.Field(Of String)("fldCustomer"),
                    .fldPartName = T0.Field(Of String)("fldPartName"),
                    .fldModel = T0.Field(Of String)("fldModel"),
                    .fldLDYear = T0.Field(Of Integer)("fldLDYear"),
                    .fldLDMonth = T0.Field(Of Integer)("fldLDMonth"),
                    .fldLDMonthName = T0.Field(Of String)("fldLDMonthName"),
                    .fldLatestDemand = T0.Field(Of Decimal)("fldLatestDemand"),
                    .fldLDPercentage = Convert.ToDecimal(0),
                    .fldRemarks = "Previous",
                    .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                    .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                }
        ).ToList()

        Dim dcUnionItem = ( ' Union of all Items
            From T0 In dcDate1.Union(dcDate2).ToList()
            Group By Keys = New With {
                Key T0.fldPartNo,
                Key T0.fldCustomer,
                Key T0.fldPartName,
                Key T0.fldModel
            } Into Group
            Select New With {
                Key Keys.fldPartNo,
                Key Keys.fldCustomer,
                Key Keys.fldPartName,
                Key Keys.fldModel
            }
        ).ToList()

        ' ---------- Demand Latest (Start) ----------

        Dim dc3MonthsDate1 = ( ' 3 Months of first date parameter
            From T0 In dcDate1
            Group By Keys = New With {
                Key T0.fldDateIssued,
                Key T0.fldLDYear,
                Key T0.fldLDMonth
            } Into Group
            Select New With {
                Key Keys.fldDateIssued,
                Key Keys.fldLDYear,
                Key Keys.fldLDMonth
            }
        ).ToList()

        Dim dcUnion3MonthsDate1 = ( ' 3 Months per item at first date
            From T0 In dcUnionItem
            From T1 In dc3MonthsDate1
            Select New With {
                Key T0.fldPartNo,
                Key T0.fldCustomer,
                Key T0.fldPartName,
                Key T0.fldModel,
                Key T1.fldDateIssued,
                Key T1.fldLDYear,
                Key T1.fldLDMonth
            }
        ).ToList()

        Dim dcDate1Item = (
            From T0 In dcUnion3MonthsDate1
            Group Join T1 In dcDate1
                On T0.fldPartNo Equals T1.fldPartNo And
                    T0.fldCustomer Equals T1.fldCustomer And
                    T0.fldPartName Equals T1.fldPartName And
                    T0.fldModel Equals T1.fldModel And
                    T0.fldLDYear Equals T1.fldLDYear And
                    T0.fldLDMonth Equals T1.fldLDMonth
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Select New With {
                Key .fldID = Convert.ToInt64(If(T1 IsNot Nothing, T1?.fldID, 0)),
                Key T0.fldPartNo,
                Key T0.fldCustomer,
                Key T0.fldPartName,
                Key T0.fldModel,
                Key T0.fldDateIssued,
                Key T0.fldLDYear,
                Key T0.fldLDMonth,
                Key .fldLDMonthName = Convert.ToString(If(T1 IsNot Nothing, T1?.fldLDMonthName, String.Empty)),
                Key .fldLatestDemand = Convert.ToDecimal(If(T1 IsNot Nothing, T1?.fldLatestDemand, 0)),
                Key .fldLDPercentage = Convert.ToDecimal(If(T1 IsNot Nothing, T1?.fldLDPercentage, 0)),
                Key T1?.fldRemarks,
                Key T1?.fldDateAdded,
                Key .fldAddedBy = Convert.ToString(If(T1 IsNot Nothing, T1?.fldAddedBy, String.Empty))
            }
        ).ToList()

        Dim dcDate1LD1 = (
            From T0 In dcDate1Item
            Order By
                T0.fldDateIssued,
                T0.fldModel,
                T0.fldPartNo,
                T0.fldPartName,
                T0.fldLDYear,
                T0.fldLDMonth
            Group By Keys = New With
                {
                    Key T0.fldDateIssued,
                    Key T0.fldCustomer,
                    Key T0.fldModel,
                    Key T0.fldPartNo,
                    Key T0.fldPartName
                } Into Group
            Select New With
                {
                    Group.FirstOrDefault.fldID,
                    Keys.fldDateIssued,
                    Keys.fldPartNo,
                    Keys.fldCustomer,
                    Keys.fldPartName,
                    Keys.fldModel,
                    Group.FirstOrDefault.fldLDYear,
                    Group.FirstOrDefault.fldLDMonth,
                    Group.FirstOrDefault.fldLDMonthName,
                    Group.FirstOrDefault.fldLatestDemand,
                    Group.FirstOrDefault.fldLDPercentage,
                    Group.FirstOrDefault.fldRemarks
                }
        ).ToList()

        Dim dcDate1LD2 = (
            From T0 In dcDate1Item
            Let _date1LD1 = dcDate1LD1.AsEnumerable.Where(
                    Function(x) x.fldDateIssued = T0.fldDateIssued And
                        x.fldCustomer = T0.fldCustomer And
                        x.fldModel = T0.fldModel And
                        x.fldPartNo = T0.fldPartNo And
                        x.fldPartName = T0.fldPartName
                )
            Where T0.fldDateIssued = _date1LD1(0).fldDateIssued And
                T0.fldCustomer = _date1LD1(0).fldCustomer And
                T0.fldModel = _date1LD1(0).fldModel And
                T0.fldPartNo = _date1LD1(0).fldPartNo And
                T0.fldPartName = _date1LD1(0).fldPartName And
                T0.fldLDYear = (New Date(_date1LD1(0).fldLDYear, _date1LD1(0).fldLDMonth, 1)).AddMonths(1).Year And
                T0.fldLDMonth = (New Date(_date1LD1(0).fldLDYear, _date1LD1(0).fldLDMonth, 1)).AddMonths(1).Month
            Select New With
                {
                    T0.fldID,
                    T0.fldDateIssued,
                    T0.fldPartNo,
                    T0.fldCustomer,
                    T0.fldPartName,
                    T0.fldModel,
                    T0.fldLDYear,
                    T0.fldLDMonth,
                    T0.fldLDMonthName,
                    T0.fldLatestDemand,
                    T0.fldLDPercentage,
                    T0.fldRemarks
                }
        ).ToList()

        Dim dcDate1LD3 = (
            From T0 In dcDate1Item
            Let _date1LD1 = dcDate1LD1.AsEnumerable.Where(
                    Function(x) x.fldDateIssued = T0.fldDateIssued And
                        x.fldCustomer = T0.fldCustomer And
                        x.fldModel = T0.fldModel And
                        x.fldPartNo = T0.fldPartNo And
                        x.fldPartName = T0.fldPartName
                )
            Where T0.fldDateIssued = _date1LD1(0).fldDateIssued And
                T0.fldCustomer = _date1LD1(0).fldCustomer And
                T0.fldModel = _date1LD1(0).fldModel And
                T0.fldPartNo = _date1LD1(0).fldPartNo And
                T0.fldPartName = _date1LD1(0).fldPartName And
                T0.fldLDYear = (New Date(_date1LD1(0).fldLDYear, _date1LD1(0).fldLDMonth, 1)).AddMonths(2).Year And
                T0.fldLDMonth = (New Date(_date1LD1(0).fldLDYear, _date1LD1(0).fldLDMonth, 1)).AddMonths(2).Month
            Select New With
                {
                    T0.fldID,
                    T0.fldDateIssued,
                    T0.fldPartNo,
                    T0.fldCustomer,
                    T0.fldPartName,
                    T0.fldModel,
                    T0.fldLDYear,
                    T0.fldLDMonth,
                    T0.fldLDMonthName,
                    T0.fldLatestDemand,
                    T0.fldLDPercentage,
                    T0.fldRemarks
                }
        ).ToList()

        Dim dcDate1_3Months = (
                From T0 In dcDate1Item.AsEnumerable
                Order By
                    T0.fldDateIssued,
                    T0.fldModel,
                    T0.fldPartNo,
                    T0.fldPartName,
                    T0.fldLDYear,
                    T0.fldLDMonth
                Group By Keys = New With
                    {
                        Key T0.fldDateIssued,
                        Key T0.fldCustomer,
                        Key T0.fldModel,
                        Key T0.fldPartNo,
                        Key T0.fldPartName
                    } Into Group
                Let _date1LD1 = TableQuery(
                        ConvertToDatatable(dcDate1LD1),
                        Keys.fldDateIssued,
                        Keys.fldCustomer,
                        Keys.fldModel,
                        Keys.fldPartNo,
                        Keys.fldPartName,
                        Group.FirstOrDefault.fldLDYear,
                        Group.FirstOrDefault.fldLDMonth,
                        0
                    )
                Let _date1LD2 = TableQuery(
                        ConvertToDatatable(dcDate1LD2),
                        Keys.fldDateIssued,
                        Keys.fldCustomer,
                        Keys.fldModel,
                        Keys.fldPartNo,
                        Keys.fldPartName,
                        Group.FirstOrDefault.fldLDYear,
                        Group.FirstOrDefault.fldLDMonth,
                        1
                    )
                Let _date1LD3 = TableQuery(
                        ConvertToDatatable(dcDate1LD3),
                        Keys.fldDateIssued,
                        Keys.fldCustomer,
                        Keys.fldModel,
                        Keys.fldPartNo,
                        Keys.fldPartName,
                        Group.FirstOrDefault.fldLDYear,
                        Group.FirstOrDefault.fldLDMonth,
                        2
                    )
                Select New With
                    {
                        Key Keys.fldDateIssued,
                        Key Keys.fldCustomer,
                        Key Keys.fldModel,
                        Key Keys.fldPartNo,
                        Key Keys.fldPartName,
                        Key .fld3Months = String.Concat(
                                IIf(
                                    _date1LD1.Rows.Count <> 0,
                                    MonthName(_date1LD1(0).Item("fldLDMonth"), True),
                                    "NA"
                                ),
                                " ",
                                IIf(
                                    _date1LD1.Rows.Count <> 0,
                                    _date1LD1(0).Item("fldLDYear").ToString,
                                    "NA"
                                ),
                                " - ",
                                IIf(
                                    _date1LD3.Rows.Count <> 0,
                                    MonthName(_date1LD3(0).Item("fldLDMonth"), True),
                                    "NA"
                                ),
                                " ",
                                IIf(
                                    _date1LD3.Rows.Count <> 0,
                                    _date1LD3(0).Item("fldLDYear").ToString,
                                    "NA"
                                )
                            ),
                        Key .fldLDID1 = Convert.ToInt64(
                                IIf(
                                    _date1LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD1(0).Item("fldID")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDYear1 = Convert.ToUInt64(
                                IIf(
                                    _date1LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD1(0).Item("fldLDYear")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDMonth1 = Convert.ToUInt32(
                                IIf(
                                    _date1LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD1(0).Item("fldLDMonth")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLD1 = Convert.ToDecimal(
                                IIf(
                                    _date1LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD1(0).Item("fldLatestDemand")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDPercentage1 = Convert.ToDecimal(
                                IIf(
                                    _date1LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD1(0).Item("fldLDPercentage")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDID2 = Convert.ToInt64(
                                IIf(
                                    _date1LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD2(0).Item("fldID")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDYear2 = Convert.ToUInt64(
                                IIf(
                                    _date1LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD2(0).Item("fldLDYear")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDMonth2 = Convert.ToUInt32(
                                IIf(
                                    _date1LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD2(0).Item("fldLDMonth")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLD2 = Convert.ToDecimal(
                                IIf(
                                    _date1LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD2(0).Item("fldLatestDemand")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDPercentage2 = Convert.ToDecimal(
                                IIf(
                                    _date1LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD2(0).Item("fldLDPercentage")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDID3 = Convert.ToInt64(
                                IIf(
                                    _date1LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD3(0).Item("fldID")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDYear3 = Convert.ToUInt64(
                                IIf(
                                    _date1LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD3(0).Item("fldLDYear")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDMonth3 = Convert.ToUInt32(
                                IIf(
                                    _date1LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD3(0).Item("fldLDMonth")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLD3 = Convert.ToDecimal(
                                IIf(
                                    _date1LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD3(0).Item("fldLatestDemand")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDPercentage3 = Convert.ToDecimal(
                                IIf(
                                    _date1LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date1LD3(0).Item("fldLDPercentage")),
                                    Convert.ToDecimal(0)
                                )
                            )
                    }
            ).ToList()

        ' ---------- Demand Latest (End) ----------

        ' ---------- Demand Previous (Start) ----------

        Dim dc3MonthsDate2 = ( ' 3 Months of first date parameter
            From T0 In dcDate2
            Group By Keys = New With {
                Key T0.fldDateIssued,
                Key T0.fldLDYear,
                Key T0.fldLDMonth
            } Into Group
            Select New With {
                Key Keys.fldDateIssued,
                Key Keys.fldLDYear,
                Key Keys.fldLDMonth
            }
        ).ToList()

        Dim dcUnion3MonthsDate2 = ( ' 3 Months per item at first date
            From T0 In dcUnionItem
            From T1 In dc3MonthsDate2
            Select New With {
                Key T0.fldPartNo,
                Key T0.fldCustomer,
                Key T0.fldPartName,
                Key T0.fldModel,
                Key T1.fldDateIssued,
                Key T1.fldLDYear,
                Key T1.fldLDMonth
            }
        ).ToList()

        Dim dcDate2Item = (
            From T0 In dcUnion3MonthsDate2
            Group Join T1 In dcDate2
                On T0.fldPartNo Equals T1.fldPartNo And
                    T0.fldCustomer Equals T1.fldCustomer And
                    T0.fldPartName Equals T1.fldPartName And
                    T0.fldModel Equals T1.fldModel And
                    T0.fldLDYear Equals T1.fldLDYear And
                    T0.fldLDMonth Equals T1.fldLDMonth
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Select New With {
                Key .fldID = Convert.ToInt64(If(T1 IsNot Nothing, T1?.fldID, 0)),
                Key T0.fldPartNo,
                Key T0.fldCustomer,
                Key T0.fldPartName,
                Key T0.fldModel,
                Key T0.fldDateIssued,
                Key T0.fldLDYear,
                Key T0.fldLDMonth,
                Key .fldLDMonthName = Convert.ToString(If(T1 IsNot Nothing, T1?.fldLDMonthName, String.Empty)),
                Key .fldLatestDemand = Convert.ToDecimal(If(T1 IsNot Nothing, T1?.fldLatestDemand, 0)),
                Key .fldLDPercentage = Convert.ToDecimal(If(T1 IsNot Nothing, T1?.fldLDPercentage, 0)),
                Key T1?.fldRemarks,
                Key T1?.fldDateAdded,
                Key .fldAddedBy = Convert.ToString(If(T1 IsNot Nothing, T1?.fldAddedBy, String.Empty))
            }
        ).ToList()

        Dim dcDate2LD1 = (
            From T0 In dcDate2Item
            Order By
                T0.fldDateIssued,
                T0.fldModel,
                T0.fldPartNo,
                T0.fldPartName,
                T0.fldLDYear,
                T0.fldLDMonth
            Group By Keys = New With
                {
                    Key T0.fldDateIssued,
                    Key T0.fldCustomer,
                    Key T0.fldModel,
                    Key T0.fldPartNo,
                    Key T0.fldPartName
                } Into Group
            Select New With
                {
                    Group.FirstOrDefault.fldID,
                    Keys.fldDateIssued,
                    Keys.fldPartNo,
                    Keys.fldCustomer,
                    Keys.fldPartName,
                    Keys.fldModel,
                    Group.FirstOrDefault.fldLDYear,
                    Group.FirstOrDefault.fldLDMonth,
                    Group.FirstOrDefault.fldLDMonthName,
                    Group.FirstOrDefault.fldLatestDemand,
                    Group.FirstOrDefault.fldLDPercentage,
                    Group.FirstOrDefault.fldRemarks
                }
        ).ToList()

        Dim dcDate2LD2 = (
            From T0 In dcDate2Item
            Let _date2LD1 = dcDate2LD1.AsEnumerable.Where(
                    Function(x) x.fldDateIssued = T0.fldDateIssued And
                        x.fldCustomer = T0.fldCustomer And
                        x.fldModel = T0.fldModel And
                        x.fldPartNo = T0.fldPartNo And
                        x.fldPartName = T0.fldPartName
                )
            Where T0.fldDateIssued = _date2LD1(0).fldDateIssued And
                T0.fldCustomer = _date2LD1(0).fldCustomer And
                T0.fldModel = _date2LD1(0).fldModel And
                T0.fldPartNo = _date2LD1(0).fldPartNo And
                T0.fldPartName = _date2LD1(0).fldPartName And
                T0.fldLDYear = (New Date(_date2LD1(0).fldLDYear, _date2LD1(0).fldLDMonth, 1)).AddMonths(1).Year And
                T0.fldLDMonth = (New Date(_date2LD1(0).fldLDYear, _date2LD1(0).fldLDMonth, 1)).AddMonths(1).Month
            Select New With
                {
                    T0.fldID,
                    T0.fldDateIssued,
                    T0.fldPartNo,
                    T0.fldCustomer,
                    T0.fldPartName,
                    T0.fldModel,
                    T0.fldLDYear,
                    T0.fldLDMonth,
                    T0.fldLDMonthName,
                    T0.fldLatestDemand,
                    T0.fldLDPercentage,
                    T0.fldRemarks
                }
        ).ToList()

        Dim dcDate2LD3 = (
            From T0 In dcDate2Item
            Let _date2LD1 = dcDate2LD1.AsEnumerable.Where(
                    Function(x) x.fldDateIssued = T0.fldDateIssued And
                        x.fldCustomer = T0.fldCustomer And
                        x.fldModel = T0.fldModel And
                        x.fldPartNo = T0.fldPartNo And
                        x.fldPartName = T0.fldPartName
                )
            Where T0.fldDateIssued = _date2LD1(0).fldDateIssued And
                T0.fldCustomer = _date2LD1(0).fldCustomer And
                T0.fldModel = _date2LD1(0).fldModel And
                T0.fldPartNo = _date2LD1(0).fldPartNo And
                T0.fldPartName = _date2LD1(0).fldPartName And
                T0.fldLDYear = (New Date(_date2LD1(0).fldLDYear, _date2LD1(0).fldLDMonth, 1)).AddMonths(2).Year And
                T0.fldLDMonth = (New Date(_date2LD1(0).fldLDYear, _date2LD1(0).fldLDMonth, 1)).AddMonths(2).Month
            Select New With
                {
                    T0.fldID,
                    T0.fldDateIssued,
                    T0.fldPartNo,
                    T0.fldCustomer,
                    T0.fldPartName,
                    T0.fldModel,
                    T0.fldLDYear,
                    T0.fldLDMonth,
                    T0.fldLDMonthName,
                    T0.fldLatestDemand,
                    T0.fldLDPercentage,
                    T0.fldRemarks
                }
        ).ToList()

        Dim dcDate2_3Months = (
                From T0 In dcDate2Item.AsEnumerable
                Order By
                    T0.fldDateIssued,
                    T0.fldModel,
                    T0.fldPartNo,
                    T0.fldPartName,
                    T0.fldLDYear,
                    T0.fldLDMonth
                Group By Keys = New With
                    {
                        Key T0.fldDateIssued,
                        Key T0.fldCustomer,
                        Key T0.fldModel,
                        Key T0.fldPartNo,
                        Key T0.fldPartName
                    } Into Group
                Let _date2LD1 = TableQuery(
                        ConvertToDatatable(dcDate2LD1),
                        Keys.fldDateIssued,
                        Keys.fldCustomer,
                        Keys.fldModel,
                        Keys.fldPartNo,
                        Keys.fldPartName,
                        Group.FirstOrDefault.fldLDYear,
                        Group.FirstOrDefault.fldLDMonth,
                        0
                    )
                Let _date2LD2 = TableQuery(
                        ConvertToDatatable(dcDate2LD2),
                        Keys.fldDateIssued,
                        Keys.fldCustomer,
                        Keys.fldModel,
                        Keys.fldPartNo,
                        Keys.fldPartName,
                        Group.FirstOrDefault.fldLDYear,
                        Group.FirstOrDefault.fldLDMonth,
                        1
                    )
                Let _date2LD3 = TableQuery(
                        ConvertToDatatable(dcDate2LD3),
                        Keys.fldDateIssued,
                        Keys.fldCustomer,
                        Keys.fldModel,
                        Keys.fldPartNo,
                        Keys.fldPartName,
                        Group.FirstOrDefault.fldLDYear,
                        Group.FirstOrDefault.fldLDMonth,
                        2
                    )
                Select New With
                    {
                        Key Keys.fldDateIssued,
                        Key Keys.fldCustomer,
                        Key Keys.fldModel,
                        Key Keys.fldPartNo,
                        Key Keys.fldPartName,
                        Key .fld3Months = String.Concat(
                                IIf(
                                    _date2LD1.Rows.Count <> 0,
                                    MonthName(_date2LD1(0).Item("fldLDMonth"), True),
                                    "NA"
                                ),
                                " ",
                                IIf(
                                    _date2LD1.Rows.Count <> 0,
                                    _date2LD1(0).Item("fldLDYear").ToString,
                                    "NA"
                                ),
                                " - ",
                                IIf(
                                    _date2LD3.Rows.Count <> 0,
                                    MonthName(_date2LD3(0).Item("fldLDMonth"), True),
                                    "NA"
                                ),
                                " ",
                                IIf(
                                    _date2LD3.Rows.Count <> 0,
                                    _date2LD3(0).Item("fldLDYear").ToString,
                                    "NA"
                                )
                            ),
                        Key .fldLDID1 = Convert.ToInt64(
                                IIf(
                                    _date2LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD1(0).Item("fldID")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDYear1 = Convert.ToUInt64(
                                IIf(
                                    _date2LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD1(0).Item("fldLDYear")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDMonth1 = Convert.ToUInt32(
                                IIf(
                                    _date2LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD1(0).Item("fldLDMonth")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLD1 = Convert.ToDecimal(
                                IIf(
                                    _date2LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD1(0).Item("fldLatestDemand")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDPercentage1 = Convert.ToDecimal(
                                IIf(
                                    _date2LD1.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD1(0).Item("fldLDPercentage")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDID2 = Convert.ToInt64(
                                IIf(
                                    _date2LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD2(0).Item("fldID")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDYear2 = Convert.ToUInt64(
                                IIf(
                                    _date2LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD2(0).Item("fldLDYear")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDMonth2 = Convert.ToUInt32(
                                IIf(
                                    _date2LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD2(0).Item("fldLDMonth")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLD2 = Convert.ToDecimal(
                                IIf(
                                    _date2LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD2(0).Item("fldLatestDemand")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDPercentage2 = Convert.ToDecimal(
                                IIf(
                                    _date2LD2.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD2(0).Item("fldLDPercentage")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDID3 = Convert.ToInt64(
                                IIf(
                                    _date2LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD3(0).Item("fldID")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDYear3 = Convert.ToUInt64(
                                IIf(
                                    _date2LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD3(0).Item("fldLDYear")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDMonth3 = Convert.ToUInt32(
                                IIf(
                                    _date2LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD3(0).Item("fldLDMonth")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLD3 = Convert.ToDecimal(
                                IIf(
                                    _date2LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD3(0).Item("fldLatestDemand")),
                                    Convert.ToDecimal(0)
                                )
                            ),
                        Key .fldLDPercentage3 = Convert.ToDecimal(
                                IIf(
                                    _date2LD3.Rows.Count <> 0,
                                    Convert.ToDecimal(_date2LD3(0).Item("fldLDPercentage")),
                                    Convert.ToDecimal(0)
                                )
                            )
                    }
            ).ToList()

        ' ---------- Demand Previous (End) ----------

        ' ---------- Demand Comparison (Start) ----------

        Dim demandComparison = (
            From T0 In dcDate1Item
            Group Join T1 In dcDate2
                On T0.fldPartNo Equals T1.fldPartNo And
                    T0.fldCustomer Equals T1.fldCustomer And
                    T0.fldPartName Equals T1.fldPartName And
                    T0.fldModel Equals T1.fldModel And
                    T0.fldLDYear Equals T1.fldLDYear And
                    T0.fldLDMonth Equals T1.fldLDMonth
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Select New With
                {
                    T0.fldID,
                    T0.fldDateIssued,
                    T0.fldPartNo,
                    T0.fldCustomer,
                    T0.fldPartName,
                    T0.fldModel,
                    T0.fldLDYear,
                    T0.fldLDMonth,
                    .fldLDMonthName = MonthName(T0.fldLDMonth),
                    .fldLatestDemand = T0.fldLatestDemand - If(T1 IsNot Nothing, T1.fldLatestDemand, 0),
                    .fldLDPercentage = If(
                            If(T1 IsNot Nothing, T1?.fldLatestDemand, 0) > 0,
                            Math.Round((T0.fldLatestDemand - If(T1 IsNot Nothing, T1.fldLatestDemand, 0)) / If(T1 IsNot Nothing, T1.fldLatestDemand, 0), 5),
                            0
                        ),
                    .fldRemarks = "Comparison"
                }
        ).ToList()

        Dim dcComparisonLD1 = (
            From T0 In demandComparison
            Order By
                T0.fldDateIssued,
                T0.fldModel,
                T0.fldPartNo,
                T0.fldPartName,
                T0.fldLDYear,
                T0.fldLDMonth
            Group By Keys = New With
                {
                    Key T0.fldDateIssued,
                    Key T0.fldCustomer,
                    Key T0.fldModel,
                    Key T0.fldPartNo,
                    Key T0.fldPartName
                } Into Group
            Select New With
                {
                    Group.FirstOrDefault.fldID,
                    Keys.fldDateIssued,
                    Keys.fldPartNo,
                    Keys.fldCustomer,
                    Keys.fldPartName,
                    Keys.fldModel,
                    Group.FirstOrDefault.fldLDYear,
                    Group.FirstOrDefault.fldLDMonth,
                    Group.FirstOrDefault.fldLDMonthName,
                    Group.FirstOrDefault.fldLatestDemand,
                    Group.FirstOrDefault.fldLDPercentage,
                    Group.FirstOrDefault.fldRemarks
                }
        ).ToList()

        Dim dcComparisonLD2 = (
            From T0 In demandComparison
            Let _comparisonLD1 = dcComparisonLD1.AsEnumerable.Where(
                    Function(x) x.fldDateIssued = T0.fldDateIssued And
                        x.fldCustomer = T0.fldCustomer And
                        x.fldModel = T0.fldModel And
                        x.fldPartNo = T0.fldPartNo And
                        x.fldPartName = T0.fldPartName
                )
            Where T0.fldDateIssued = _comparisonLD1(0).fldDateIssued And
                T0.fldCustomer = _comparisonLD1(0).fldCustomer And
                T0.fldModel = _comparisonLD1(0).fldModel And
                T0.fldPartNo = _comparisonLD1(0).fldPartNo And
                T0.fldPartName = _comparisonLD1(0).fldPartName And
                T0.fldLDYear = (New Date(_comparisonLD1(0).fldLDYear, _comparisonLD1(0).fldLDMonth, 1)).AddMonths(1).Year And
                T0.fldLDMonth = (New Date(_comparisonLD1(0).fldLDYear, _comparisonLD1(0).fldLDMonth, 1)).AddMonths(1).Month
            Select New With
                {
                    T0.fldID,
                    T0.fldDateIssued,
                    T0.fldPartNo,
                    T0.fldCustomer,
                    T0.fldPartName,
                    T0.fldModel,
                    T0.fldLDYear,
                    T0.fldLDMonth,
                    T0.fldLDMonthName,
                    T0.fldLatestDemand,
                    T0.fldLDPercentage,
                    T0.fldRemarks
                }
        ).ToList()

        Dim dcComparisonLD3 = (
            From T0 In demandComparison
            Let _comparisonLD1 = dcComparisonLD1.AsEnumerable.Where(
                    Function(x) x.fldDateIssued = T0.fldDateIssued And
                        x.fldCustomer = T0.fldCustomer And
                        x.fldModel = T0.fldModel And
                        x.fldPartNo = T0.fldPartNo And
                        x.fldPartName = T0.fldPartName
                )
            Where T0.fldDateIssued = _comparisonLD1(0).fldDateIssued And
                T0.fldCustomer = _comparisonLD1(0).fldCustomer And
                T0.fldModel = _comparisonLD1(0).fldModel And
                T0.fldPartNo = _comparisonLD1(0).fldPartNo And
                T0.fldPartName = _comparisonLD1(0).fldPartName And
                T0.fldLDYear = (New Date(_comparisonLD1(0).fldLDYear, _comparisonLD1(0).fldLDMonth, 1)).AddMonths(2).Year And
                T0.fldLDMonth = (New Date(_comparisonLD1(0).fldLDYear, _comparisonLD1(0).fldLDMonth, 1)).AddMonths(2).Month
            Select New With
                {
                    T0.fldID,
                    T0.fldDateIssued,
                    T0.fldPartNo,
                    T0.fldCustomer,
                    T0.fldPartName,
                    T0.fldModel,
                    T0.fldLDYear,
                    T0.fldLDMonth,
                    T0.fldLDMonthName,
                    T0.fldLatestDemand,
                    T0.fldLDPercentage,
                    T0.fldRemarks
                }
        ).ToList()

        Dim dcComparison_3Months = (
            From T0 In demandComparison.AsEnumerable
            Order By
                T0.fldDateIssued,
                T0.fldModel,
                T0.fldPartNo,
                T0.fldPartName,
                T0.fldLDYear,
                T0.fldLDMonth
            Group By Keys = New With
                {
                    Key T0.fldDateIssued,
                    Key T0.fldCustomer,
                    Key T0.fldModel,
                    Key T0.fldPartNo,
                    Key T0.fldPartName
                } Into Group
            Let _comparisonLD1 = TableQuery(
                    ConvertToDatatable(dcComparisonLD1),
                    Keys.fldDateIssued,
                    Keys.fldCustomer,
                    Keys.fldModel,
                    Keys.fldPartNo,
                    Keys.fldPartName,
                    Group.FirstOrDefault.fldLDYear,
                    Group.FirstOrDefault.fldLDMonth,
                    0
                )
            Let _comparisonLD2 = TableQuery(
                    ConvertToDatatable(dcComparisonLD2),
                    Keys.fldDateIssued,
                    Keys.fldCustomer,
                    Keys.fldModel,
                    Keys.fldPartNo,
                    Keys.fldPartName,
                    Group.FirstOrDefault.fldLDYear,
                    Group.FirstOrDefault.fldLDMonth,
                    1
                )
            Let _comparisonLD3 = TableQuery(
                    ConvertToDatatable(dcComparisonLD3),
                    Keys.fldDateIssued,
                    Keys.fldCustomer,
                    Keys.fldModel,
                    Keys.fldPartNo,
                    Keys.fldPartName,
                    Group.FirstOrDefault.fldLDYear,
                    Group.FirstOrDefault.fldLDMonth,
                    2
                )
            Select New With
                {
                    Key Keys.fldDateIssued,
                    Key Keys.fldCustomer,
                    Key Keys.fldModel,
                    Key Keys.fldPartNo,
                    Key Keys.fldPartName,
                    Key .fld3Months = String.Concat(
                            IIf(
                                _comparisonLD1.Rows.Count <> 0,
                                MonthName(_comparisonLD1(0).Item("fldLDMonth"), True),
                                "NA"
                            ),
                            " ",
                            IIf(
                                _comparisonLD1.Rows.Count <> 0,
                                _comparisonLD1(0).Item("fldLDYear").ToString,
                                "NA"
                            ),
                            " - ",
                            IIf(
                                _comparisonLD3.Rows.Count <> 0,
                                MonthName(_comparisonLD3(0).Item("fldLDMonth"), True),
                                "NA"
                            ),
                            " ",
                            IIf(
                                _comparisonLD3.Rows.Count <> 0,
                                _comparisonLD3(0).Item("fldLDYear").ToString,
                                "NA"
                            )
                        ),
                    Key .fldLDID1 = Convert.ToInt64(
                            IIf(
                                _comparisonLD1.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD1(0).Item("fldID")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDYear1 = Convert.ToUInt64(
                            IIf(
                                _comparisonLD1.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD1(0).Item("fldLDYear")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDMonth1 = Convert.ToUInt32(
                            IIf(
                                _comparisonLD1.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD1(0).Item("fldLDMonth")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLD1 = Convert.ToDecimal(
                            IIf(
                                _comparisonLD1.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD1(0).Item("fldLatestDemand")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDPercentage1 = Convert.ToDecimal(
                            IIf(
                                _comparisonLD1.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD1(0).Item("fldLDPercentage")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDID2 = Convert.ToInt64(
                            IIf(
                                _comparisonLD2.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD2(0).Item("fldID")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDYear2 = Convert.ToUInt64(
                            IIf(
                                _comparisonLD2.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD2(0).Item("fldLDYear")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDMonth2 = Convert.ToUInt32(
                            IIf(
                                _comparisonLD2.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD2(0).Item("fldLDMonth")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLD2 = Convert.ToDecimal(
                            IIf(
                                _comparisonLD2.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD2(0).Item("fldLatestDemand")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDPercentage2 = Convert.ToDecimal(
                            IIf(
                                _comparisonLD2.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD2(0).Item("fldLDPercentage")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDID3 = Convert.ToInt64(
                            IIf(
                                _comparisonLD3.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD3(0).Item("fldID")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDYear3 = Convert.ToUInt64(
                            IIf(
                                _comparisonLD3.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD3(0).Item("fldLDYear")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDMonth3 = Convert.ToUInt32(
                            IIf(
                                _comparisonLD3.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD3(0).Item("fldLDMonth")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLD3 = Convert.ToDecimal(
                            IIf(
                                _comparisonLD3.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD3(0).Item("fldLatestDemand")),
                                Convert.ToDecimal(0)
                            )
                        ),
                    Key .fldLDPercentage3 = Convert.ToDecimal(
                            IIf(
                                _comparisonLD3.Rows.Count <> 0,
                                Convert.ToDecimal(_comparisonLD3(0).Item("fldLDPercentage")),
                                Convert.ToDecimal(0)
                            )
                        )
                }
        ).ToList()

        ' ---------- Demand Comparison (End) ----------

        Dim tblItemMaster = (
            From T0 In tblItemMasterData.AsEnumerable
            Group By Keys = New With
                {
                    Key .fldPartName = T0.Field(Of String)("fldPartName"),
                    Key .fldCategory = T0.Field(Of String)("fldCategory")
                } Into gT1 = Group
        ).ToList()

        Dim tblDemandComparison = (
            From T0 In dcComparison_3Months
            Group Join T3 In tblItemMaster.AsEnumerable
                On T0.fldPartName Equals T3.Keys.fldPartName
                Into gT3 = Group
            From T3 In gT3.DefaultIfEmpty
            Let T1 = dcDate1_3Months.AsEnumerable.Where(
                    Function(x) x.fldCustomer = T0.fldCustomer And
                        x.fldModel = T0.fldModel And
                        x.fldPartNo = T0.fldPartNo And
                        x.fldPartName = T0.fldPartName
                )
            Let T2 = dcDate2_3Months.AsEnumerable.Where(
                    Function(x) x.fldCustomer = T0.fldCustomer And
                        x.fldModel = T0.fldModel And
                        x.fldPartNo = T0.fldPartNo And
                        x.fldPartName = T0.fldPartName
                )
            Select New With
                {
                    Key .fldCatNumber = Convert.ToInt32(IIf(
                            T3?.Keys.fldCategory.ToString() = "SRC",
                            1,
                            IIf(
                                T3?.Keys.fldCategory.ToString() = "BSS",
                                2,
                                3
                            )
                        )),
                    Key .fldCategory = T3?.Keys.fldCategory.ToString(),
                    Key T0.fldCustomer,
                    Key T0.fldModel,
                    Key T0.fldPartNo,
                    Key T0.fldPartName,
                    Key .fldPreviousDateIssued = Convert.ToDateTime(IIf(T2.Count > 0, T2(0)?.fldDateIssued, date2)),
                    Key .fldPreviousLDYear1 = Convert.ToUInt64(IIf(T2.Count > 0, T2(0)?.fldLDYear1, 1)),
                    Key .fldPreviousLDMonth1 = Convert.ToUInt32(IIf(T2.Count > 0, T2(0)?.fldLDMonth1, 1)),
                    Key .fldPreviousLD1 = Convert.ToDecimal(IIf(T2.Count > 0, T2(0)?.fldLD1, 0)),
                    Key .fldPreviousLDPercentage1 = Convert.ToDecimal(IIf(T2.Count > 0, T2(0)?.fldLDPercentage1, 0)),
                    Key .fldPreviousLDYear2 = Convert.ToUInt64(IIf(T2.Count > 0, T2(0)?.fldLDYear2, 1)),
                    Key .fldPreviousLDMonth2 = Convert.ToUInt32(IIf(T2.Count > 0, T2(0)?.fldLDMonth2, 1)),
                    Key .fldPreviousLD2 = Convert.ToDecimal(IIf(T2.Count > 0, T2(0)?.fldLD2, 0)),
                    Key .fldPreviousLDPercentage2 = Convert.ToDecimal(IIf(T2.Count > 0, T2(0)?.fldLDPercentage2, 0)),
                    Key .fldPreviousLDYear3 = Convert.ToUInt64(IIf(T2.Count > 0, T2(0)?.fldLDYear3, 1)),
                    Key .fldPreviousLDMonth3 = Convert.ToUInt32(IIf(T2.Count > 0, T2(0)?.fldLDMonth3, 1)),
                    Key .fldPreviousLD3 = Convert.ToDecimal(IIf(T2.Count > 0, T2(0)?.fldLD3, 0)),
                    Key .fldPreviousLDPercentage3 = Convert.ToDecimal(IIf(T2.Count > 0, T2(0)?.fldLDPercentage3, 0)),
                    Key .fldLatestDateIssued = Convert.ToDateTime(IIf(T1.Count > 0, T1(0)?.fldDateIssued, date1)),
                    Key .fldLatestLDYear1 = Convert.ToUInt64(IIf(T1.Count > 0, T1(0)?.fldLDYear1, 1)),
                    Key .fldLatestLDMonth1 = Convert.ToUInt32(IIf(T1.Count > 0, T1(0)?.fldLDMonth1, 1)),
                    Key .fldLatestLD1 = Convert.ToDecimal(IIf(T1.Count > 0, T1(0)?.fldLD1, 0)),
                    Key .fldLatestLDPercentage1 = Convert.ToDecimal(IIf(T1.Count > 0, T1(0)?.fldLDPercentage1, 0)),
                    Key .fldLatestLDYear2 = Convert.ToUInt64(IIf(T1.Count > 0, T1(0)?.fldLDYear2, 1)),
                    Key .fldLatestLDMonth2 = Convert.ToUInt32(IIf(T1.Count > 0, T1(0)?.fldLDMonth2, 1)),
                    Key .fldLatestLD2 = Convert.ToDecimal(IIf(T1.Count > 0, T1(0)?.fldLD2, 0)),
                    Key .fldLatestLDPercentage2 = Convert.ToDecimal(IIf(T1.Count > 0, T1(0)?.fldLDPercentage2, 0)),
                    Key .fldLatestLDYear3 = Convert.ToUInt64(IIf(T1.Count > 0, T1(0)?.fldLDYear3, 1)),
                    Key .fldLatestLDMonth3 = Convert.ToUInt32(IIf(T1.Count > 0, T1(0)?.fldLDMonth3, 1)),
                    Key .fldLatestLD3 = Convert.ToDecimal(IIf(T1.Count > 0, T1(0)?.fldLD3, 0)),
                    Key .fldLatestLDPercentage3 = Convert.ToDecimal(IIf(T1.Count > 0, T1(0)?.fldLDPercentage3, 0)),
                    Key .fldComparisonDateIssued = T0.fldDateIssued,
                    Key .fldComparisonLDYear1 = T0.fldLDYear1,
                    Key .fldComparisonLDMonth1 = T0.fldLDMonth1,
                    Key .fldComparisonLD1 = T0.fldLD1,
                    Key .fldComparisonLDPercentage1 = T0.fldLDPercentage1,
                    Key .fldComparisonLDYear2 = T0.fldLDYear2,
                    Key .fldComparisonLDMonth2 = T0.fldLDMonth2,
                    Key .fldComparisonLD2 = T0.fldLD2,
                    Key .fldComparisonLDPercentage2 = T0.fldLDPercentage2,
                    Key .fldComparisonLDYear3 = T0.fldLDYear3,
                    Key .fldComparisonLDMonth3 = T0.fldLDMonth3,
                    Key .fldComparisonLD3 = T0.fldLD3,
                    Key .fldComparisonLDPercentage3 = T0.fldLDPercentage3
                }
        ).ToList()

        'tblResult = ConvertToDatatable(demandComparison.Union(dcDate1).Union(dcDate2).ToList())
        tblResult = ConvertToDatatable(tblDemandComparison)
        'tblResult = ConvertToDatatable(dcDate2_3Months)

        Return tblResult

    End Function

    Public Function RoundAwayFromZero(number As Double) As Double

        Dim roundedNumber As Double = 0

        If number >= 0 Then
            roundedNumber = Math.Ceiling(number * 100)
        Else
            roundedNumber = Math.Floor(number * 100)
        End If

        Return (roundedNumber / 100)

    End Function

    Private Function TableQuery(tblNthMonth As DataTable, fldDateIssued As Date, fldCustomer As String, fldModel As String, fldPartNo As String, fldPartName As String, fldLDYear As Integer, fldLDMonth As Integer, nthMonth As Integer) As DataTable

        Dim dataTable As DataTable = Nothing

        Dim nthTable = (
            From T0 In tblNthMonth.AsEnumerable
            Where T0.Item("fldDateIssued") = fldDateIssued And
                T0.Item("fldCustomer") = fldCustomer And
                T0.Item("fldModel") = fldModel And
                T0.Item("fldPartNo") = fldPartNo And
                T0.Item("fldPartName") = fldPartName And
                T0.Item("fldLDYear") = (New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Year And
                T0.Item("fldLDMonth") = (New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Month
            Select New With
                {
                    .fldID = T0.Item("fldID"),
                    .fldLDYear = T0.Item("fldLDYear"),
                    .fldLDMonth = T0.Item("fldLDMonth"),
                    .fldLatestDemand = T0.Item("fldLatestDemand"),
                    .fldLDPercentage = T0.Item("fldLDPercentage")
                }
        ).ToList()

        dataTable = ConvertToDatatable(nthTable)

        If dataTable.Rows.Count <= 0 Then
            dataTable.Rows.Clear()
            dataTable = New DataTable
            dataTable.Columns.Add("fldID", GetType(Int64))
            dataTable.Columns.Add("fldLDYear", GetType(Integer))
            dataTable.Columns.Add("fldLDMonth", GetType(Integer))
            dataTable.Columns.Add("fldLatestDemand", GetType(Decimal))
            dataTable.Columns.Add("fldLDPercentage", GetType(Decimal))
            dataTable.Rows.Add(Convert.ToDecimal(0), (New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Year, (New Date(fldLDYear, fldLDMonth, 1)).AddMonths(nthMonth).Month, Convert.ToDecimal(0), Convert.ToDecimal(0))
        End If

        Return dataTable

    End Function

    Private Function ConvertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
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
