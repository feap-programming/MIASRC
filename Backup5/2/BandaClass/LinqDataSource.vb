Imports System.ComponentModel
Imports FEAPNS.DataAccess

Public Class LinqDataSource

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)

    Private tblBOMMaster As DataTable = myDB.MyQuery("SELECT * FROM tblBOMMaster")
    Private tblPartNoHistory As DataTable = myDB.MyQuery("SELECT * FROM tblPartNoHistory")
    Private tblCustomer As DataTable = myDB.MyQuery("SELECT * FROM tblCustomer")
    Private tblItemMasterData As DataTable = myDB.MyQuery("SELECT * FROM tblItemMasterData")
    Private tblItemProcess As DataTable = myDB.MyQuery("SELECT * FROM tblItemProcess")
    Private tblProcess As DataTable = myDB.MyQuery("SELECT * FROM tblProcess")
    Private tblItemPerModel As DataTable = myDB.MyQuery("SELECT * FROM tblItemPerModel")
    Private tblModelList As DataTable = myDB.MyQuery("SELECT * FROM tblModelList")

    Private tblWorkingDays As DataTable = myDB.SPSelect("SP_P_SelectWorkingDays")
    Private tblModelCapacity As DataTable = myDB.MyQuery("SELECT * FROM tblModelCapacity")
    Private tblCustomerDemand As DataTable = myDB.SPSelect("SP_SelectAllCustomerDemand")
    Private tblFGModelCapacity As DataTable = myDB.SPSelect("SP_P_SelectModelCapacityByItem")
    Private tblModelCavity As DataTable = myDB.SPSelect("SP_P_SelectAllIMModelCavity")
    Private tblModelCycleTime As DataTable = myDB.SPSelect("SP_P_SelectAllIMModelCycleTime")
    Private tblMachineList As DataTable = myDB.MyQuery("SELECT * FROM tblMachineList")

    Private Function GetIMPlan(_year As Integer, _month As Integer) As DataTable

        Dim partNoLatestAnnex = (
            From T0 In tblPartNoHistory.AsEnumerable
            Group Join T1 In tblItemMasterData.AsEnumerable
                On T0.Field(Of String)("fldItemCode") Equals T1.Field(Of String)("fldItemCode")
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Group Join T2 In tblCustomer.AsEnumerable
                On T0.Field(Of String)("fldCustomerCode") Equals T2.Field(Of String)("fldCustomerCode")
                Into gT2 = Group
            From T2 In gT2.DefaultIfEmpty
            Let latestDate As Date = New DateTime(_year, _month, DateTime.DaysInMonth(_year, _month))
            Where T0.Field(Of Date)("fldEffectivityDate") < latestDate
            Order By T0.Field(Of String)("fldItemCode") Ascending,
                T2?.Field(Of String)("fldCustomerName") Ascending,
                T0.Field(Of Date)("fldEffectivityDate") Descending,
                T0.Field(Of Int64)("fldId") Descending
            Group By Keys = New With
                {
                    Key .fldItemCode = T0.Field(Of String)("fldItemCode"),
                    Key .fldCustomerName = T2?.Field(Of String)("fldCustomerName")
                } Into Group
            Select New With
                {
                    Key .fldId = Group.FirstOrDefault.T0.Field(Of Int64)("fldId"),
                    Key Keys.fldCustomerName,
                    Key Keys.fldItemCode,
                    Key .fldNewItemCode = Group.FirstOrDefault.T0.Field(Of String)("fldNewItemCode"),
                    Key .fldPartName = Group.FirstOrDefault.T1?.Field(Of String)("fldPartName"),
                    Key .fldEffectivityDate = Group.FirstOrDefault.T0.Field(Of Date)("fldEffectivityDate"),
                    Key .fldRemarks = Group.FirstOrDefault.T0.Field(Of String)("fldRemarks")
                }
        ).ToList()

        Dim bomMaster = (
            From T0 In tblBOMMaster.AsEnumerable
            Group Join T1 In tblPartNoHistory.AsEnumerable
                On Trim(T0.Field(Of String)("fldParentCode")) Equals Trim(T1.Field(Of String)("fldNewItemCode"))
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Group Join T2 In tblItemMasterData.AsEnumerable
                On Trim(T1?.Field(Of String)("fldItemCode")) Equals Trim(T2.Field(Of String)("fldItemCode"))
                Into gT2 = Group
            From T2 In gT2.DefaultIfEmpty
            Group Join T3 In tblCustomer.AsEnumerable
                On T1?.Field(Of String)("fldCustomerCode") Equals T3.Field(Of String)("fldCustomerCode")
                Into gT3 = Group
            From T3 In gT3.DefaultIfEmpty
            Select New With
                {
                    Key .fldId = T0.Field(Of Int64)("fldId"),
                    Key .fldCustomerName = T3?.Field(Of String)("fldCustomerName"),
                    Key .fldItemCode = T1?.Field(Of String)("fldItemCode"),
                    Key .fldNewItemCode = T1?.Field(Of String)("fldNewItemCode"),
                    Key .fldParentCode = T0.Field(Of String)("fldParentCode"),
                    Key .fldPartName = T2?.Field(Of String)("fldPartName"),
                    Key .fldChildCode = T0.Field(Of String)("fldChildCode"),
                    Key .fldUsage = T0.Field(Of Decimal)("fldUsage"),
                    Key .fldEffectivityDate = T1?.Field(Of Date)("fldEffectivityDate"),
                    Key .fldRemarks = T1?.Field(Of String)("fldRemarks")
                }
        ).ToList()

        Dim bomLatestAnnex = (
            From T0 In bomMaster
            Where partNoLatestAnnex.Any(Function(T1) T1.fldNewItemCode = T0.fldParentCode)
            Select T0
        ).ToList()

        Dim customerDemand = (
            From T0 In tblFGModelCapacity.AsEnumerable
            Where Year(T0.Field(Of Date)("fldDate")) = _year And
                Month(T0.Field(Of Date)("fldDate")) = _month
            Select New With
                {
                    Key .fldID = T0.Field(Of Int64)("fldID"),
                    Key .fldYear = Year(T0.Field(Of Date)("fldDate")),
                    Key .fldMonth = Month(T0.Field(Of Date)("fldDate")),
                    Key .fldCategory = T0.Field(Of String)("fldCategory"),
                    Key .fldModel = T0.Field(Of String)("fldModel"),
                    Key .fldFGModel = T0.Field(Of String)("fldFGModel"),
                    Key .fldCustomer = T0.Field(Of String)("fldCustomer"),
                    Key .fldItemCode = T0.Field(Of String)("fldItemCode"),
                    Key .CPartNo = T0.Field(Of String)("CPartNo"),
                    Key .fldPartName = T0.Field(Of String)("fldPartName"),
                    Key .fldBudget = T0.Field(Of Decimal)("fldBudget"),
                    Key .fldForecast = T0.Field(Of Decimal)("fldForecast"),
                    Key .fldLatestDemand = T0.Field(Of Decimal)("fldLatestDemand"),
                    Key .fldProductionPlan = T0.Field(Of Decimal)("fldProductionPlan")
                }
        ).ToList()

        ' -----------------------------------
        ' ---------- Getting IM WP ----------
        ' -----------------------------------

        Dim bom1stLayer = ( '1ST LOOP
            From T0 In bomLatestAnnex
            Where customerDemand.Any(Function(TX) TX.fldCustomer = T0.fldCustomerName And TX.fldItemCode = T0.fldItemCode And TX.fldPartName = T0.fldPartName)
            Select New With
                {
                    Key T0.fldId,
                    Key T0.fldCustomerName,
                    Key .fldModel = (From TY In customerDemand
                                     Where TY.fldCustomer = T0.fldCustomerName And
                                         TY.fldItemCode = T0.fldItemCode And
                                         TY.fldPartName = T0.fldPartName
                                     Select TY.fldModel).FirstOrDefault(),
                    Key T0.fldItemCode,
                    Key T0.fldParentCode,
                    Key T0.fldPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T0.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T0.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T0.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key T0.fldUsage,
                    Key T0.fldEffectivityDate,
                    Key T0.fldRemarks,
                    Key .fldParentPlan = Math.Round(
                        (From TY In customerDemand
                         Where TY.fldCustomer = T0.fldCustomerName And
                             TY.fldItemCode = T0.fldItemCode And
                             TY.fldPartName = T0.fldPartName
                         Select TY.fldProductionPlan).FirstOrDefault(),
                        6
                    ),
                    Key .fldChildPlan = Math.Round(
                        T0.fldUsage *
                        (From TY In customerDemand
                         Where TY.fldCustomer = T0.fldCustomerName And
                             TY.fldItemCode = T0.fldItemCode And
                             TY.fldPartName = T0.fldPartName
                         Select TY.fldProductionPlan).FirstOrDefault(),
                        6
                    )
                }
        ).ToList()

        Dim bom2ndLayer = ( ' 2nd Layer
            From T0 In bom1stLayer
            Join T1 In bomLatestAnnex
                On T0.fldChildCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key .fldItemCode = T0.fldChildItemCode,
                    Key .fldParentCode = T0.fldChildCode,
                    Key .fldPartName = T0.fldChildPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldChildPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldChildPlan,
                        6
                    )
                }
        ).ToList()

        Dim bom3rdLayer = ( ' 3rd Layer
            From T0 In bom2ndLayer
            Join T1 In bomLatestAnnex
                On T0.fldChildCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key .fldItemCode = T0.fldChildItemCode,
                    Key .fldParentCode = T0.fldChildCode,
                    Key .fldPartName = T0.fldChildPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldChildPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldChildPlan,
                        6
                    )
                }
        ).ToList()

        Dim bom4thLayer = ( ' 4th Layer
            From T0 In bom3rdLayer
            Join T1 In bomLatestAnnex
                On T0.fldChildCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key .fldItemCode = T0.fldChildItemCode,
                    Key .fldParentCode = T0.fldChildCode,
                    Key .fldPartName = T0.fldChildPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldChildPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldChildPlan,
                        6
                    )
                }
        ).ToList()

        Dim bom5thLayer = ( ' 5th Layer
            From T0 In bom4thLayer
            Join T1 In bomLatestAnnex
                On T0.fldChildCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key .fldItemCode = T0.fldChildItemCode,
                    Key .fldParentCode = T0.fldChildCode,
                    Key .fldPartName = T0.fldChildPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldChildPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldChildPlan,
                        6
                    )
                }
        ).ToList()

        Dim bom6thLayer = ( ' 6th Layer
            From T0 In bom5thLayer
            Join T1 In bomLatestAnnex
                On T0.fldChildCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key .fldItemCode = T0.fldChildItemCode,
                    Key .fldParentCode = T0.fldChildCode,
                    Key .fldPartName = T0.fldChildPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldChildPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldChildPlan,
                        6
                    )
                }
        ).ToList()

        Dim bom7thLayer = ( '7th Layer
            From T0 In bom6thLayer
            Join T1 In bomLatestAnnex
                On T0.fldChildCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key .fldItemCode = T0.fldChildItemCode,
                    Key .fldParentCode = T0.fldChildCode,
                    Key .fldPartName = T0.fldChildPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldChildPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldChildPlan,
                        6
                    )
                }
        ).ToList()

        Dim bom8thLayer = ( '8th Layer
            From T0 In bom7thLayer
            Join T1 In bomLatestAnnex
                On T0.fldChildCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key .fldItemCode = T0.fldChildItemCode,
                    Key .fldParentCode = T0.fldChildCode,
                    Key .fldPartName = T0.fldChildPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldChildPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldChildPlan,
                        6
                    )
                }
        ).ToList()

        Dim bom9thLayer = ( '9th Layer
            From T0 In bom8thLayer
            Join T1 In bomLatestAnnex
                On T0.fldChildCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key .fldItemCode = T0.fldChildItemCode,
                    Key .fldParentCode = T0.fldChildCode,
                    Key .fldPartName = T0.fldChildPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldChildPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldChildPlan,
                        6
                    )
                }
        ).ToList()

        Dim tblIMPlan = ( ' All IM Plan
            From T0 In bom1stLayer.Union(bom2ndLayer).Union(bom3rdLayer).Union(bom4thLayer).Union(bom5thLayer).Union(bom6thLayer).Union(bom7thLayer).Union(bom8thLayer).Union(bom9thLayer)
            Group Join T1 In tblItemProcess.AsEnumerable
                On T0.fldChildItemCode Equals T1.Field(Of String)("fldItemCode")
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Group Join T2 In tblProcess.AsEnumerable
                On T1?.Field(Of String)("fldProcessCode") Equals T2.Field(Of String)("fldCode")
                Into gT2 = Group
            From T2 In gT2.DefaultIfEmpty
            Group Join T3 In tblItemMasterData.AsEnumerable
                On T0.fldChildItemCode Equals T3.Field(Of String)("fldItemCode")
                Into gT3 = Group
            From T3 In gT3.DefaultIfEmpty
            Group By Keys = New With
                {
                    Key T0.fldModel, ' Key T0.fldCustomerName,
                    Key T0.fldCustomerName,
                    Key .fldSubCategory = T3?.Field(Of String)("fldSubCategory"),
                    Key T0.fldChildCode
                } Into Group
            Where Group.FirstOrDefault.T2?.Field(Of String)("fldCode") = "P003" ' Or T2?.Field(Of String)("fldCode") = "P016"
            Order By Group.FirstOrDefault.T0.fldModel, ' Group.FirstOrDefault.T0.fldCustomerName,
                Group.FirstOrDefault.T0.fldCustomerName,
                Group.FirstOrDefault.T3?.Field(Of String)("fldSubCategory"),
                Group.FirstOrDefault.T0.fldChildCode
            Select New With
                {
                    Key .fldYear = _year,
                    Key .fldMonth = _month,
                    Key .fldMonthName = MonthName(_month),
                    Key .fldProcessName = Group.FirstOrDefault.T2?.Field(Of String)("fldProcessName"),
                    Key Keys.fldModel, ' Key Keys.fldCustomerName,
                    Key Keys.fldCustomerName,
                    Key Keys.fldSubCategory,
                    Key .fldItemCode = Group.FirstOrDefault.T0.fldChildItemCode,
                    Key .fldItemCodeWithAnnex = Keys.fldChildCode,
                    Key .fldPartName = Group.FirstOrDefault.T0.fldChildPartName,
                    Key .fldProductionPlan = Group.Sum(Function(x) x.T0.fldChildPlan)
                }
        ).ToList()

        ' -------------------------------
        ' ---------- Get IM RM ----------
        ' -------------------------------

        Dim IMbom1stLayer = ( '1st Layer
            From T0 In tblIMPlan
            Join T1 In bomLatestAnnex
                On T0.fldItemCode Equals T1.fldParentCode
            Select New With
                {
                    Key .fldId = If(T1 IsNot Nothing, T1.fldId, 0),
                    Key T0.fldCustomerName,
                    Key T0.fldModel,
                    Key T0.fldSubCategory,
                    Key T0.fldItemCode,
                    Key .fldParentCode = T0.fldItemCodeWithAnnex,
                    Key T0.fldPartName,
                    Key .fldChildItemCode = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldItemCode).FirstOrDefault(),
                    Key T1?.fldChildCode,
                    Key .fldChildPartName = (From TZ In partNoLatestAnnex
                                             Where TZ.fldNewItemCode = T1?.fldChildCode
                                             Select TZ.fldPartName).FirstOrDefault(),
                    Key .fldUsage = If(T1 IsNot Nothing, T1.fldUsage, 0),
                    Key T1?.fldEffectivityDate,
                    Key T1?.fldRemarks,
                    Key .fldParentPlan = T0.fldProductionPlan,
                    Key .fldChildPlan = Math.Round(
                        If(T1 IsNot Nothing, T1.fldUsage, 0) * T0.fldProductionPlan,
                        6
                    )
                }
        ).ToList()

        Dim tblIMPlanFinal = (
            From T0 In IMbom1stLayer
            Group Join T1 In tblItemProcess.AsEnumerable
                On T0.fldChildItemCode Equals T1.Field(Of String)("fldItemCode")
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Group Join T2 In tblProcess.AsEnumerable
                On T1?.Field(Of String)("fldProcessCode") Equals T2.Field(Of String)("fldCode")
                Into gT2 = Group
            From T2 In gT2.DefaultIfEmpty
            Group Join T3 In tblItemMasterData.AsEnumerable
                On T0.fldChildItemCode Equals T3.Field(Of String)("fldItemCode")
                Into gT3 = Group
            From T3 In gT3.DefaultIfEmpty
            Group By Keys = New With
                {
                    Key T0.fldModel, ' Key T0.fldCustomerName,
                    Key T0.fldSubCategory,
                    Key T0.fldChildCode
                } Into Group
            Where Keys.fldModel <> String.Empty And
                Keys.fldSubCategory <> String.Empty
            Order By Group.FirstOrDefault.T3?.Field(Of String)("fldSubCategory"),
                Group.FirstOrDefault.T0.fldModel, ' Group.FirstOrDefault.T0.fldCustomerName,
                Group.FirstOrDefault.T0.fldChildCode
            Select New With
                {
                    Key .fldYear = _year,
                    Key .fldMonth = _month,
                    Key .fldMonthName = MonthName(_month),
                    Key .fldProcessName = Group.FirstOrDefault.T2?.Field(Of String)("fldProcessName"),
                    Key Keys.fldModel, ' Key Keys.fldCustomerName,
                    Key Keys.fldSubCategory,
                    Key .fldItemCode = Group.FirstOrDefault.T0.fldChildItemCode,
                    Key .fldItemCodeWithAnnex = Keys.fldChildCode,
                    Key .fldPartName = Group.FirstOrDefault.T0.fldChildPartName,
                    Key .fldProductionPlan = Group.Sum(Function(x) x.T0.fldChildPlan)
                }
        ).ToList()

        ' ----------------------------------------------
        ' ---------- Get Daily Target and MDC ----------
        ' ----------------------------------------------

        Dim modelCavity = (
            From T0 In tblModelCavity.AsEnumerable
            Group Join T1 In tblIMPlanFinal
                On T0.Field(Of Integer)("fldYear") Equals T1.fldYear And
                T0.Field(Of Integer)("fldMonth") Equals T1.fldMonth And
                T0.Field(Of String)("fldModelName") Equals T1.fldModel And
                T0.Field(Of String)("fldCategory") Equals T1.fldSubCategory And
                T0.Field(Of String)("fldResinMaterial") Equals T1.fldPartName
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Group Join T2 In tblWorkingDays.AsEnumerable
                On T0.Field(Of Integer)("fldYear") Equals T2.Field(Of Integer)("fldYear") And
                T0.Field(Of Integer)("fldMonth") Equals T2.Field(Of Integer)("fldMonth")
                Into gT2 = Group
            From T2 In gT2.DefaultIfEmpty
            Where T0.Field(Of Integer)("fldYear") = _year And
                T0.Field(Of Integer)("fldMonth") = _month
            Select New With
                {
                    Key .fldID = T0.Field(Of Integer)("fldID"),
                    Key .fldYear = T0.Field(Of Integer)("fldYear"),
                    Key .fldMonth = T0.Field(Of Integer)("fldMonth"),
                    Key .fldMonthName = T0.Field(Of String)("fldMonthName"),
                    Key .fldModelCode = T0.Field(Of String)("fldModelCode"),
                    Key .fldModelName = T0.Field(Of String)("fldModelName"),
                    Key .fldCategory = T0.Field(Of String)("fldCategory"),
                    Key .fldResinMaterial = T0.Field(Of String)("fldResinMaterial"),
                    Key .fldNoOfCavity = T0.Field(Of Integer)("fldNoOfCavity"),
                    Key .fldCavityName = T0.Field(Of String)("fldCavityName"),
                    Key .fldRequirement = If(T0.Field(Of Integer)("fldPriority") = 1,
                        Convert.ToInt32(Math.Round(If(T1 IsNot Nothing, T1.fldProductionPlan, 0), 0)),
                        0
                    ),
                    Key .fldTotalWorkingDays = Convert.ToInt32(
                        If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)
                    ),
                    Key .fldDailyTarget = Math.Round(
                         If(T0.Field(Of Integer)("fldPriority") = 1,
                            Convert.ToInt32(Math.Round(If(T1 IsNot Nothing, T1.fldProductionPlan, 0), 0)),
                            0
                        ) /
                        Convert.ToInt32(If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)),
                        0
                    ),
                    Key .fldYield = Math.Round(T0.Field(Of Decimal)("fldYield"), 4),
                    Key .fldStartUp = Math.Round(T0.Field(Of Integer)("fldStartUp") / 60 / 24 / 7, 4),
                    Key .fldChangeMold = T0.Field(Of Integer)("fldChangeMold"),
                    Key .fldDowntime = Math.Round(T0.Field(Of Integer)("fldDowntime") / 60 / 24 / 7, 4),
                    Key .fldMaxShots = T0.Field(Of Integer)("fldMaxShots"),
                    Key .fldOverhaul = T0.Field(Of Integer)("fldOverhaul"),
                    Key .fldMDC = If(If(T0.Field(Of Integer)("fldPriority") = 1,
                            Convert.ToInt32(Math.Round(If(T1 IsNot Nothing, T1.fldProductionPlan, 0), 0)),
                            0
                        ) > (T0.Field(Of Integer)("fldMaxShots") * T0.Field(Of Integer)("fldNoOfCavity")),
                        (
                        If(
                            T0.Field(Of Integer)("fldPriority") = 1,
                            Convert.ToInt32(Math.Round(If(T1 IsNot Nothing, T1.fldProductionPlan, 0), 0)),
                            0
                        ) / (T0.Field(Of Integer)("fldMaxShots") * T0.Field(Of Integer)("fldNoOfCavity"))) *
                        (T0.Field(Of Integer)("fldOverhaul") * 60) /
                        Convert.ToInt32(If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)) /
                        24 / 60,
                        0
                    ),
                    Key .fldPriority = T0.Field(Of Integer)("fldPriority"),
                    Key .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                    Key .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                }
        ).ToList()

        ' ---------------------------------------------
        ' ---------- Check for Shared Moldie ----------
        ' ---------------------------------------------

        Dim modelCycleTimePriority = (
            From T0 In tblModelCycleTime.AsEnumerable
            Group Join T1 In modelCavity
                On T0.Field(Of Integer)("fldYear") Equals T1.fldYear And
                T0.Field(Of Integer)("fldMonth") Equals T1.fldMonth And
                T0.Field(Of String)("fldModelName") Equals T1.fldModelName And
                T0.Field(Of String)("fldCategory") Equals T1.fldCategory And
                T0.Field(Of String)("fldCavityName") Equals T1.fldCavityName
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Where T0.Field(Of Integer)("fldYear") = _year And
                T0.Field(Of Integer)("fldMonth") = _month And
                T0.Field(Of Integer)("fldPriority") = 1 And
                If(T1 IsNot Nothing, T1.fldDailyTarget, 0) > 0
            Group By Keys = New With
                {
                    Key .fldYear = T0.Field(Of Integer)("fldYear"),
                    Key .fldMonth = T0.Field(Of Integer)("fldMonth"),
                    Key .fldMachineCode = T0.Field(Of String)("fldMachineCode")
                } Into Group
            Select New With
                {
                    Key Keys.fldYear,
                    Key Keys.fldMonth,
                    Key .fldMonthName = Group.FirstOrDefault.T0.Field(Of String)("fldMonthName"),
                    Key Keys.fldMachineCode,
                    Key .fldMachineName = Group.FirstOrDefault.T0.Field(Of String)("fldMachineName"),
                    Key .fldSharingMachine = Group.Count()
                }
        ).ToList()

        ' --------------------------------------------------------
        ' ---------- Get Change Mold and Operation Rate ----------
        ' --------------------------------------------------------

        Dim withSharingMold = (
            From T0 In tblModelCycleTime.AsEnumerable
            Group Join T1 In modelCycleTimePriority
                On T0.Field(Of Integer)("fldYear") Equals T1.fldYear And
                T0.Field(Of Integer)("fldMonth") Equals T1.fldMonth And
                T0.Field(Of String)("fldMachineCode") Equals T1.fldMachineCode
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Where T0.Field(Of Integer)("fldYear") = _year And
                T0.Field(Of Integer)("fldMonth") = _month And
                T0.Field(Of Integer)("fldPriority") = 1
            Group By Keys = New With
                {
                    Key .fldYear = T0.Field(Of Integer)("fldYear"),
                    Key .fldMonth = T0.Field(Of Integer)("fldMonth"),
                    Key .fldModelCode = T0.Field(Of String)("fldModelCode"),
                    Key .fldCategory = T0.Field(Of String)("fldCategory"),
                    Key .fldCavityName = T0.Field(Of String)("fldCavityName")
                } Into Group
            Select New With
                {
                    Key Keys.fldYear,
                    Key Keys.fldMonth,
                    Key .fldMonthName = Group.FirstOrDefault.T0.Field(Of String)("fldMonthName"),
                    Key Keys.fldModelCode,
                    Key .fldModelName = Group.FirstOrDefault.T0.Field(Of String)("fldModelName"),
                    Key Keys.fldCategory,
                    Key .fldCavityName = Group.FirstOrDefault.T0.Field(Of String)("fldCavityName"),
                    Key .fldSharingMachine = If(Group.FirstOrDefault.T1 IsNot Nothing, Group.FirstOrDefault.T1.fldSharingMachine, 0)
                }
        ).ToList()

        Dim modelCavityPriority = (
            From T0 In modelCavity
            Group Join T1 In withSharingMold
                On T0.fldYear Equals T1.fldYear And
                T0.fldMonth Equals T1.fldMonth And
                T0.fldModelCode Equals T1.fldModelCode And
                T0.fldCategory Equals T1.fldCategory And
                T0.fldCavityName Equals T1.fldCavityName
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Where T0.fldYear = _year And
                T0.fldMonth = _month
            Select New With
                {
                    Key T0.fldID,
                    Key T0.fldYear,
                    Key T0.fldMonth,
                    Key T0.fldMonthName,
                    Key T0.fldModelCode,
                    Key T0.fldModelName,
                    Key T0.fldCategory,
                    Key T0.fldResinMaterial,
                    Key T0.fldNoOfCavity,
                    Key T0.fldCavityName,
                    Key T0.fldRequirement,
                    Key T0.fldTotalWorkingDays,
                    Key T0.fldDailyTarget,
                    Key T0.fldYield,
                    Key T0.fldStartUp,
                    Key .fldChangeMold = Math.Round(If(T0.fldPriority = 1, If(If(T1 IsNot Nothing, T1.fldSharingMachine, 0) > 1, T0.fldChangeMold / 24 / 60, 0), 0), 4),
                    Key T0.fldMDC,
                    Key T0.fldDowntime,
                    Key .fldOperationRate = Math.Round(
                        1.0 -
                        (
                            T0.fldStartUp +
                            Math.Round(If(T0.fldPriority = 1, If(If(T1 IsNot Nothing, T1.fldSharingMachine, 0) > 1, T0.fldChangeMold / 24 / 60, 0), 0), 4) +
                            T0.fldMDC +
                            T0.fldDowntime
                        ),
                    4),
                    Key T0.fldPriority,
                    Key T0.fldDateAdded,
                    Key T0.fldAddedBy
                }
        ).ToList()

        Dim modelCavityFinal = (
            From T0 In tblModelCavity.AsEnumerable
            Group Join T1 In modelCavityPriority
                On T0.Field(Of Integer)("fldYear") Equals T1.fldYear And
                T0.Field(Of Integer)("fldMonth") Equals T1.fldMonth And
                T0.Field(Of String)("fldModelCode") Equals T1.fldModelCode And
                T0.Field(Of String)("fldCategory") Equals T1.fldCategory And
                T0.Field(Of String)("fldResinMaterial") Equals T1.fldResinMaterial And
                T0.Field(Of String)("fldCavityName") Equals T1.fldCavityName And
                T0.Field(Of Integer)("fldPriority") Equals T1.fldPriority
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Group Join T2 In tblWorkingDays.AsEnumerable
                On T0.Field(Of Integer)("fldYear") Equals T2.Field(Of Integer)("fldYear") And
                T0.Field(Of Integer)("fldMonth") Equals T2.Field(Of Integer)("fldMonth")
                Into gT2 = Group
            From T2 In gT2.DefaultIfEmpty
            Where T0.Field(Of Integer)("fldYear") = _year And
                T0.Field(Of Integer)("fldMonth") = _month
            Select New With
                {
                    Key .fldID = T0.Field(Of Integer)("fldID"),
                    Key .fldYear = T0.Field(Of Integer)("fldYear"),
                    Key .fldMonth = T0.Field(Of Integer)("fldMonth"),
                    Key .fldMonthName = T0.Field(Of String)("fldMonthName"),
                    Key .fldModelCode = T0.Field(Of String)("fldModelCode"),
                    Key .fldModelName = T0.Field(Of String)("fldModelName"),
                    Key .fldCategory = T0.Field(Of String)("fldCategory"),
                    Key .fldResinMaterial = T0.Field(Of String)("fldResinMaterial"),
                    Key .fldNoOfCavity = T0.Field(Of Integer)("fldNoOfCavity"),
                    Key .fldCavityName = T0.Field(Of String)("fldCavityName"),
                    Key .fldRequirement = If(T1 IsNot Nothing, T1.fldRequirement, 0),
                    Key .fldTotalWorkingDays = Convert.ToInt32(
                        If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)
                    ),
                    Key .fldDailyTarget = Math.Round(
                        Convert.ToInt32(Math.Round(If(T1 IsNot Nothing, T1.fldRequirement, 0), 0)) /
                        Convert.ToInt32(If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)),
                        0
                    ),
                    Key .fldYield = If(T1 IsNot Nothing, T1.fldYield, 0),
                    Key .fldStartUp = If(T1 IsNot Nothing, T1.fldStartUp, 0),
                    Key .fldChangeMold = If(T1 IsNot Nothing, T1.fldChangeMold, 0),
                    Key .fldMDC = If(T1 IsNot Nothing, T1.fldMDC, 0),
                    Key .fldDowntime = If(T1 IsNot Nothing, T1.fldDowntime, 0),
                    Key .fldOperationRate = If(T1 IsNot Nothing, T1.fldOperationRate, 0),
                    Key .fldPriority = T0.Field(Of Integer)("fldPriority"),
                    Key .fldDateAdded = T0.Field(Of DateTime)("fldDateAdded"),
                    Key .fldAddedBy = T0.Field(Of String)("fldAddedBy")
                }
        ).ToList()

        ' -----------------------------------------------
        ' ---------- Compute IM Model Capacity ----------
        ' -----------------------------------------------

        Dim modelCapacityIM = (
            From T0 In modelCavityFinal
            Group Join T1 In tblModelCycleTime.AsEnumerable
                On T0.fldYear Equals T1.Field(Of Integer)("fldYear") And
                T0.fldMonth Equals T1.Field(Of Integer)("fldMonth") And
                T0.fldModelCode Equals T1.Field(Of String)("fldModelCode") And
                T0.fldCategory Equals T1.Field(Of String)("fldCategory") And
                T0.fldCavityName Equals T1.Field(Of String)("fldCavityName")
                Into gT1 = Group
            From T1 In gT1.DefaultIfEmpty
            Group Join T2 In tblWorkingDays.AsEnumerable
                On T0.fldYear Equals T2.Field(Of Integer)("fldYear") And
                T0.fldMonth Equals T2.Field(Of Integer)("fldMonth")
                Into gT2 = Group
            From T2 In gT2.DefaultIfEmpty
            Group Join T3 In tblMachineList.AsEnumerable
                On T1?.Field(Of String)("fldMachineCode") Equals T3.Field(Of String)("fldCode")
                Into gT3 = Group
            From T3 In gT3.DefaultIfEmpty
            Where T0.fldYear = _year And
                T0.fldMonth = _month
            Select New With
                {
                    Key T0.fldID,
                    Key T0.fldYear,
                    Key T0.fldMonth,
                    Key T0.fldMonthName,
                    Key .fldMachineCode = T1?.Field(Of String)("fldMachineCode"),
                    Key .fldMachineName = T1?.Field(Of String)("fldMachineName"),
                    Key .fldType = T3?.Field(Of String)("fldType"),
                    Key .fldRobotModel = T3?.Field(Of String)("fldRobotModel"),
                    Key T0.fldModelCode,
                    Key T0.fldModelName,
                    Key T0.fldCategory,
                    Key T0.fldCavityName,
                    Key .fldCycleTime = If(T1 IsNot Nothing, T1.Field(Of Decimal)("fldCycleTime"), 0),
                    Key .fldModelPriority = T0.fldPriority,
                    Key .fldMachinePriority = If(T1 IsNot Nothing, T1.Field(Of Integer)("fldPriority"), 0),
                    Key T0.fldResinMaterial,
                    Key T0.fldNoOfCavity,
                    Key .fldRequirement = If(T0.fldPriority = 1 And If(T1 IsNot Nothing, T1.Field(Of Integer)("fldPriority"), 0) = 1, If(T0.fldPriority = 1, T0.fldRequirement, 0), 0),
                    Key .fldTotalWorkingDays = Convert.ToInt32(
                        If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)
                    ),
                    Key .fldDailyTarget = Math.Round(
                        Convert.ToInt32(Math.Round(If(T0.fldPriority = 1 And If(T1 IsNot Nothing, T1.Field(Of Integer)("fldPriority"), 0) = 1, If(T0.fldPriority = 1, T0.fldRequirement, 0), 0), 0)) /
                        Convert.ToInt32(If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)),
                        0
                    ),
                    Key T0.fldYield,
                    Key T0.fldStartUp,
                    Key T0.fldChangeMold,
                    Key T0.fldMDC,
                    Key T0.fldDowntime,
                    Key T0.fldOperationRate,
                    Key .fldCapacity = Math.Round(
                        If(Not Double.IsNaN((
                            Math.Round(
                                Convert.ToInt32(Math.Round(If(T0.fldPriority = 1 And If(T1 IsNot Nothing, T1.Field(Of Integer)("fldPriority"), 0) = 1, If(T0.fldPriority = 1, T0.fldRequirement, 0), 0), 0)) /
                                Convert.ToInt32(If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)),
                                0
                            ) *
                            If(T1 IsNot Nothing, T1.Field(Of Decimal)("fldCycleTime"), 0.0) /
                            T0.fldYield /
                            T0.fldOperationRate /
                            3600
                        ) / T0.fldNoOfCavity),
                        (
                            Math.Round(
                                Convert.ToInt32(Math.Round(If(T0.fldPriority = 1 And If(T1 IsNot Nothing, T1.Field(Of Integer)("fldPriority"), 0) = 1, If(T0.fldPriority = 1, T0.fldRequirement, 0), 0), 0)) /
                                Convert.ToInt32(If(T2 IsNot Nothing, T2.Field(Of Integer)("fldWorkingDays"), 0)),
                                0
                            ) *
                            If(T1 IsNot Nothing, T1.Field(Of Decimal)("fldCycleTime"), 0.0) /
                            T0.fldYield /
                            T0.fldOperationRate /
                            3600
                        ) / T0.fldNoOfCavity,
                        0),
                    3),
                    Key T0.fldDateAdded,
                    Key T0.fldAddedBy
                }
        ).ToList()

        ' -------------------------------------
        ' ---------- Model Auto Plan ----------
        ' -------------------------------------

        ' Get Next Priority
        Dim exceededModelCapacity = (
            From T0 In modelCapacityIM
            Let _GetNextPriority = ConvertToDatatable(modelCavityFinal).Select("fldYear = " & T0.fldYear & " And " &
                "fldMonth = " & T0.fldMonth & " And " &
                "fldModelCode = '" & T0.fldModelCode & "' And " &
                "fldCategory = '" & T0.fldCategory & "' And " &
                "fldResinMaterial = '" & T0.fldResinMaterial & "' And " &
                "fldPriority = " & T0.fldModelPriority & " + 1")
            Select New With
            {
                Key T0.fldID,
                Key T0.fldYear,
                Key T0.fldMonth,
                Key T0.fldMonthName,
                Key T0.fldMachineCode,
                Key T0.fldMachineName,
                Key T0.fldType,
                Key T0.fldRobotModel,
                Key T0.fldModelCode,
                Key T0.fldModelName,
                Key T0.fldCategory,
                Key T0.fldCavityName,
                Key T0.fldCycleTime,
                Key T0.fldModelPriority,
                Key .fldNextModelPriority = If(
                    T0.fldMachinePriority = 1,
                    If(_GetNextPriority.Count > 0,
                        Convert.ToInt32(_GetNextPriority(0).Item("fldPriority")),
                        0
                    ),
                    0
                ),
                Key T0.fldMachinePriority,
                Key .fldNextMachinePriority = Convert.ToInt32(0),
                Key T0.fldResinMaterial,
                Key T0.fldNoOfCavity,
                Key T0.fldRequirement,
                Key .fldExcessRequirement = Convert.ToInt32(0),
                Key T0.fldTotalWorkingDays,
                Key T0.fldDailyTarget,
                Key T0.fldYield,
                Key T0.fldStartUp,
                Key T0.fldChangeMold,
                Key T0.fldMDC,
                Key T0.fldDowntime,
                Key T0.fldOperationRate,
                Key T0.fldCapacity,
                Key T0.fldDateAdded,
                Key T0.fldAddedBy
            }
        ).ToList()

        ' Check for Model Run Time
        Dim modelRunTime = (
            From T0 In exceededModelCapacity
            Group By Keys = New With
                {
                    Key T0.fldYear,
                    Key T0.fldMonth,
                    Key T0.fldModelCode,
                    Key T0.fldCategory,
                    Key T0.fldResinMaterial,
                    Key T0.fldCavityName
                } Into Group
            Select New With
                {
                    Key Keys.fldYear,
                    Key Keys.fldMonth,
                    Key Group.FirstOrDefault.fldMonthName,
                    Key Keys.fldModelCode,
                    Key Group.FirstOrDefault.fldModelName,
                    Key Keys.fldCategory,
                    Key Keys.fldResinMaterial,
                    Key Keys.fldCavityName,
                    Key .fldRunTime = Group.Sum(Function(x) x.fldCapacity)
                }
        ).ToList()

        ' Get Model Exceeding to 24hr
        Dim modelHoursPerDay As Integer = 24
        Dim exceedingModelRunTime = (
            From T0 In modelRunTime
            Where T0.fldRunTime >= modelHoursPerDay
            Select T0
        ).ToList()

        ' Transfer exceeded capacity to next priority
        Dim modelPriority As Integer = 1
        Dim modelLastPriority As Integer = 4
        For count As Integer = 1 To modelLastPriority + 1

            modelPriority = count

            While True

                exceededModelCapacity = (
                    From T0 In exceededModelCapacity
                    Group Join T1 In exceedingModelRunTime
                        On T0.fldYear Equals T1.fldYear And
                        T0.fldMonth Equals T1.fldMonth And
                        T0.fldModelCode Equals T1.fldModelCode And
                        T0.fldCategory Equals T1.fldCategory And
                        T0.fldResinMaterial Equals T1.fldResinMaterial And
                        T0.fldCavityName Equals T1.fldCavityName
                        Into gT1 = Group
                    From T1 In gT1.DefaultIfEmpty
                    Select New With
                    {
                        Key T0.fldID,
                        Key T0.fldYear,
                        Key T0.fldMonth,
                        Key T0.fldMonthName,
                        Key T0.fldMachineCode,
                        Key T0.fldMachineName,
                        Key T0.fldType,
                        Key T0.fldRobotModel,
                        Key T0.fldModelCode,
                        Key T0.fldModelName,
                        Key T0.fldCategory,
                        Key T0.fldCavityName,
                        Key T0.fldCycleTime,
                        Key T0.fldModelPriority,
                        Key T0.fldNextModelPriority,
                        Key T0.fldMachinePriority,
                        Key T0.fldNextMachinePriority,
                        Key T0.fldResinMaterial,
                        Key T0.fldNoOfCavity,
                        Key .fldRequirement = If(T0.fldModelPriority = modelPriority And (T0.fldNextModelPriority = modelPriority + 1 Or T0.fldNextModelPriority = 0) And T0.fldRequirement > 100,
                            If(T1 IsNot Nothing, T0.fldRequirement - 100, T0.fldRequirement),
                            T0.fldRequirement
                        ),
                        Key .fldExcessRequirement = If(T0.fldModelPriority = modelPriority And (T0.fldNextModelPriority = modelPriority + 1 Or T0.fldNextModelPriority = 0) And T0.fldRequirement > 100,
                            If(T1 IsNot Nothing, T0.fldExcessRequirement + 100, T0.fldExcessRequirement),
                            T0.fldExcessRequirement
                        ),
                        Key T0.fldTotalWorkingDays,
                        Key .fldDailyTarget = Math.Round(
                            If(T0.fldModelPriority = modelPriority And (T0.fldNextModelPriority = modelPriority + 1 Or T0.fldNextModelPriority = 0) And T0.fldRequirement > 100,
                                If(T1 IsNot Nothing, T0.fldRequirement - 100, T0.fldRequirement),
                                T0.fldRequirement
                            ) /
                            T0.fldTotalWorkingDays,
                            0
                        ),
                        Key T0.fldYield,
                        Key T0.fldStartUp,
                        Key T0.fldChangeMold,
                        Key T0.fldMDC,
                        Key T0.fldDowntime,
                        Key T0.fldOperationRate,
                        Key .fldCapacity = Math.Round(
                            If(Not Double.IsNaN((
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        If(T0.fldModelPriority = modelPriority And (T0.fldNextModelPriority = modelPriority + 1 Or T0.fldNextModelPriority = 0) And T0.fldRequirement > 100,
                                            If(T1 IsNot Nothing, T0.fldRequirement - 100, T0.fldRequirement),
                                            T0.fldRequirement
                                        ),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity),
                            (
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        If(T0.fldModelPriority = modelPriority And (T0.fldNextModelPriority = modelPriority + 1 Or T0.fldNextModelPriority = 0) And T0.fldRequirement > 100,
                                            If(T1 IsNot Nothing, T0.fldRequirement - 100, T0.fldRequirement),
                                            T0.fldRequirement
                                        ),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity,
                            0),
                        3),
                        Key T0.fldDateAdded,
                        Key T0.fldAddedBy
                    }
                ).ToList()

                modelRunTime = (
                    From T0 In exceededModelCapacity
                    Where T0.fldModelPriority = modelPriority
                    Group By Keys = New With
                        {
                            Key T0.fldYear,
                            Key T0.fldMonth,
                            Key T0.fldModelCode,
                            Key T0.fldCategory,
                            Key T0.fldResinMaterial,
                            Key T0.fldCavityName
                        } Into Group
                    Select New With
                        {
                            Key Keys.fldYear,
                            Key Keys.fldMonth,
                            Key Group.FirstOrDefault.fldMonthName,
                            Key Keys.fldModelCode,
                            Key Group.FirstOrDefault.fldModelName,
                            Key Keys.fldCategory,
                            Key Keys.fldResinMaterial,
                            Key Keys.fldCavityName,
                            Key .fldRunTime = Group.Sum(Function(x) x.fldCapacity)
                        }
                ).ToList()

                exceedingModelRunTime = (
                    From T0 In modelRunTime
                    Where T0.fldRunTime >= modelHoursPerDay
                    Select T0
                ).ToList()

                If exceedingModelRunTime.Count = 0 Then
                    Exit While
                End If

            End While

            If modelPriority = modelLastPriority + 1 Then

                ' Transfer Excess Requirement to the next 1st Priority
                exceededModelCapacity = (
                    From T0 In exceededModelCapacity
                    Let _WithExcessRequirement = ConvertToDatatable(exceededModelCapacity).Select(
                        "fldYear = " & T0.fldYear & " AND " &
                        "fldMonth = " & T0.fldMonth & " AND " &
                        "fldModelCode = '" & T0.fldModelCode & "' AND " &
                        "fldCategory = '" & T0.fldCategory & "' AND " &
                        "fldResinMaterial = '" & T0.fldResinMaterial & "' AND " &
                        "fldModelPriority = " & modelPriority & " AND " &
                        "(fldNextModelPriority = " & 0 & " OR " &
                        "fldNextModelPriority = " & modelPriority + 1 & ") AND " &
                        "fldExcessRequirement > " & 0
                        )
                    Select New With
                    {
                        Key T0.fldID,
                        Key T0.fldYear,
                        Key T0.fldMonth,
                        Key T0.fldMonthName,
                        Key T0.fldMachineCode,
                        Key T0.fldMachineName,
                        Key T0.fldType,
                        Key T0.fldRobotModel,
                        Key T0.fldModelCode,
                        Key T0.fldModelName,
                        Key T0.fldCategory,
                        Key T0.fldCavityName,
                        Key T0.fldCycleTime,
                        Key T0.fldModelPriority,
                        Key T0.fldNextModelPriority,
                        Key T0.fldMachinePriority,
                        Key T0.fldNextMachinePriority,
                        Key T0.fldResinMaterial,
                        Key T0.fldNoOfCavity,
                        Key .fldRequirement = Convert.ToInt32(If(
                            _WithExcessRequirement.Count > 0,
                            If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldModelPriority") = modelPriority And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0,
                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                T0.fldRequirement
                            ),
                            T0.fldRequirement
                        )),
                        Key .fldExcessRequirement = Convert.ToInt32(0),
                        Key T0.fldTotalWorkingDays,
                        Key .fldDailyTarget = Math.Round(
                            Convert.ToInt32(If(
                                _WithExcessRequirement.Count > 0,
                                If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldModelPriority") = modelPriority And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0,
                                    T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                    T0.fldRequirement
                                ),
                                T0.fldRequirement
                            )) /
                            T0.fldTotalWorkingDays,
                            0
                        ),
                        Key T0.fldYield,
                        Key T0.fldStartUp,
                        Key T0.fldChangeMold,
                        Key T0.fldMDC,
                        Key T0.fldDowntime,
                        Key T0.fldOperationRate,
                        Key .fldCapacity = Math.Round(
                            If(Not Double.IsNaN((
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        Convert.ToInt32(If(
                                            _WithExcessRequirement.Count > 0,
                                            If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldModelPriority") = modelPriority And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0,
                                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                                T0.fldRequirement
                                            ),
                                            T0.fldRequirement
                                        )),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity),
                            (
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        Convert.ToInt32(If(
                                            _WithExcessRequirement.Count > 0,
                                            If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldModelPriority") = modelPriority And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0,
                                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                                T0.fldRequirement
                                            ),
                                            T0.fldRequirement
                                        )),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity,
                            0),
                        3),
                        Key T0.fldDateAdded,
                        Key T0.fldAddedBy
                    }
                ).ToList()

            Else

                ' Transfer Excess Requirement to the next priority
                exceededModelCapacity = (
                    From T0 In exceededModelCapacity
                    Let _WithExcessRequirement = ConvertToDatatable(exceededModelCapacity).Select(
                        "fldYear = " & T0.fldYear & " AND " &
                        "fldMonth = " & T0.fldMonth & " AND " &
                        "fldModelCode = '" & T0.fldModelCode & "' AND " &
                        "fldCategory = '" & T0.fldCategory & "' AND " &
                        "fldResinMaterial = '" & T0.fldResinMaterial & "' AND " &
                        "fldModelPriority = " & modelPriority & " AND " &
                        "(fldNextModelPriority = " & 0 & " OR " &
                        "fldNextModelPriority = " & modelPriority + 1 & ") AND " &
                        "fldExcessRequirement > " & 0
                        )
                    Select New With
                    {
                        Key T0.fldID,
                        Key T0.fldYear,
                        Key T0.fldMonth,
                        Key T0.fldMonthName,
                        Key T0.fldMachineCode,
                        Key T0.fldMachineName,
                        Key T0.fldType,
                        Key T0.fldRobotModel,
                        Key T0.fldModelCode,
                        Key T0.fldModelName,
                        Key T0.fldCategory,
                        Key T0.fldCavityName,
                        Key T0.fldCycleTime,
                        Key T0.fldModelPriority,
                        Key T0.fldNextModelPriority,
                        Key T0.fldMachinePriority,
                        Key T0.fldNextMachinePriority,
                        Key T0.fldResinMaterial,
                        Key T0.fldNoOfCavity,
                        Key .fldRequirement = Convert.ToInt32(If(
                            _WithExcessRequirement.Count > 0,
                            If((T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldNextModelPriority") = 0 And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0) Or
                                (T0.fldModelPriority = modelPriority + 1 And T0.fldModelPriority = _WithExcessRequirement(0).Item("fldNextModelPriority") And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0),
                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                T0.fldRequirement
                            ),
                            T0.fldRequirement
                        )),
                        Key .fldExcessRequirement = Convert.ToInt32(0),
                        Key T0.fldTotalWorkingDays,
                        Key .fldDailyTarget = Math.Round(
                            Convert.ToInt32(If(
                                _WithExcessRequirement.Count > 0,
                                If((T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldNextModelPriority") = 0 And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0) Or
                                    (T0.fldModelPriority = modelPriority + 1 And T0.fldModelPriority = _WithExcessRequirement(0).Item("fldNextModelPriority") And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0),
                                    T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                    T0.fldRequirement
                                ),
                                T0.fldRequirement
                            )) /
                            T0.fldTotalWorkingDays,
                            0
                        ),
                        Key T0.fldYield,
                        Key T0.fldStartUp,
                        Key T0.fldChangeMold,
                        Key T0.fldMDC,
                        Key T0.fldDowntime,
                        Key T0.fldOperationRate,
                        Key .fldCapacity = Math.Round(
                            If(Not Double.IsNaN((
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        Convert.ToInt32(If(
                                            _WithExcessRequirement.Count > 0,
                                            If((T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldNextModelPriority") = 0 And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0) Or
                                                (T0.fldModelPriority = modelPriority + 1 And T0.fldModelPriority = _WithExcessRequirement(0).Item("fldNextModelPriority") And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0),
                                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                                T0.fldRequirement
                                            ),
                                            T0.fldRequirement
                                        )),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity),
                            (
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        Convert.ToInt32(If(
                                            _WithExcessRequirement.Count > 0,
                                            If((T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldNextModelPriority") = 0 And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0) Or
                                                (T0.fldModelPriority = modelPriority + 1 And T0.fldModelPriority = _WithExcessRequirement(0).Item("fldNextModelPriority") And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0),
                                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                                T0.fldRequirement
                                            ),
                                            T0.fldRequirement
                                        )),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity,
                            0),
                        3),
                        Key T0.fldDateAdded,
                        Key T0.fldAddedBy
                    }
                ).ToList()

            End If

            ' Transfer Requirement to 1st priority for excess that unable to compute
            exceededModelCapacity = (
                From T0 In exceededModelCapacity
                Let _WithExcessRequirement = ConvertToDatatable(exceededModelCapacity).Select(
                    "fldYear = " & T0.fldYear & " AND " &
                    "fldMonth = " & T0.fldMonth & " AND " &
                    "fldModelCode = '" & T0.fldModelCode & "' AND " &
                    "fldCategory = '" & T0.fldCategory & "' AND " &
                    "fldResinMaterial = '" & T0.fldResinMaterial & "' AND " &
                    "fldModelPriority = " & modelPriority + 1 & " AND " &
                    "fldMachinePriority <> " & 1 & " AND " &
                    "fldRequirement > " & 0
                    )
                Select New With
                {
                    Key T0.fldID,
                    Key T0.fldYear,
                    Key T0.fldMonth,
                    Key T0.fldMonthName,
                    Key T0.fldMachineCode,
                    Key T0.fldMachineName,
                    Key T0.fldType,
                    Key T0.fldRobotModel,
                    Key T0.fldModelCode,
                    Key T0.fldModelName,
                    Key T0.fldCategory,
                    Key T0.fldCavityName,
                    Key T0.fldCycleTime,
                    Key T0.fldModelPriority,
                    Key T0.fldNextModelPriority,
                    Key T0.fldMachinePriority,
                    Key T0.fldNextMachinePriority,
                    Key T0.fldResinMaterial,
                    Key T0.fldNoOfCavity,
                    Key .fldRequirement = Convert.ToInt32(If(
                        _WithExcessRequirement.Count > 0,
                        If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldRequirement") > 0,
                            T0.fldRequirement + _WithExcessRequirement(0).Item("fldRequirement"),
                            If(T0.fldModelPriority = _WithExcessRequirement(0).Item("fldModelPriority"),
                                T0.fldRequirement - _WithExcessRequirement(0).Item("fldRequirement"),
                                T0.fldRequirement
                            )
                        ),
                        T0.fldRequirement
                    )),
                    Key .fldExcessRequirement = Convert.ToInt32(0),
                    Key T0.fldTotalWorkingDays,
                    Key .fldDailyTarget = Math.Round(
                        Convert.ToInt32(If(
                            _WithExcessRequirement.Count > 0,
                            If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldRequirement") > 0,
                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldRequirement"),
                                If(T0.fldModelPriority = _WithExcessRequirement(0).Item("fldModelPriority"),
                                    T0.fldRequirement - _WithExcessRequirement(0).Item("fldRequirement"),
                                    T0.fldRequirement
                                )
                            ),
                            T0.fldRequirement
                        )) /
                        T0.fldTotalWorkingDays,
                        0
                    ),
                    Key T0.fldYield,
                    Key T0.fldStartUp,
                    Key T0.fldChangeMold,
                    Key T0.fldMDC,
                    Key T0.fldDowntime,
                    Key T0.fldOperationRate,
                    Key .fldCapacity = Math.Round(
                        If(Not Double.IsNaN((
                            Math.Round(
                                Convert.ToInt32(Math.Round(
                                    Convert.ToInt32(If(
                                        _WithExcessRequirement.Count > 0,
                                        If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldRequirement") > 0,
                                            T0.fldRequirement + _WithExcessRequirement(0).Item("fldRequirement"),
                                            If(T0.fldModelPriority = _WithExcessRequirement(0).Item("fldModelPriority"),
                                                T0.fldRequirement - _WithExcessRequirement(0).Item("fldRequirement"),
                                                T0.fldRequirement
                                            )
                                        ),
                                        T0.fldRequirement
                                    )),
                                0)) /
                                T0.fldTotalWorkingDays,
                                0
                            ) *
                            T0.fldCycleTime /
                            T0.fldYield /
                            T0.fldOperationRate /
                            3600
                        ) / T0.fldNoOfCavity),
                        (
                            Math.Round(
                                Convert.ToInt32(Math.Round(
                                    Convert.ToInt32(If(
                                        _WithExcessRequirement.Count > 0,
                                        If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldRequirement") > 0,
                                            T0.fldRequirement + _WithExcessRequirement(0).Item("fldRequirement"),
                                            If(T0.fldModelPriority = _WithExcessRequirement(0).Item("fldModelPriority"),
                                                T0.fldRequirement - _WithExcessRequirement(0).Item("fldRequirement"),
                                                T0.fldRequirement
                                            )
                                        ),
                                        T0.fldRequirement
                                    )),
                                0)) /
                                T0.fldTotalWorkingDays,
                                0
                            ) *
                            T0.fldCycleTime /
                            T0.fldYield /
                            T0.fldOperationRate /
                            3600
                        ) / T0.fldNoOfCavity,
                        0),
                    3),
                    Key T0.fldDateAdded,
                    Key T0.fldAddedBy
                }
            ).ToList()

            ' Check for sharing Moldie
            modelCycleTimePriority = (
                From T0 In tblModelCycleTime.AsEnumerable
                Group Join T1 In exceededModelCapacity
                    On T0.Field(Of Integer)("fldYear") Equals T1.fldYear And
                    T0.Field(Of Integer)("fldMonth") Equals T1.fldMonth And
                    T0.Field(Of String)("fldModelName") Equals T1.fldModelName And
                    T0.Field(Of String)("fldCategory") Equals T1.fldCategory And
                    T0.Field(Of String)("fldCavityName") Equals T1.fldCavityName And
                    T0.Field(Of Integer)("fldPriority") Equals T1.fldMachinePriority
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Where T0.Field(Of Integer)("fldYear") = _year And
                    T0.Field(Of Integer)("fldMonth") = _month And
                    If(T1 IsNot Nothing, T1.fldDailyTarget, 0) > 0
                Group By Keys = New With
                    {
                        Key .fldYear = T0.Field(Of Integer)("fldYear"),
                        Key .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        Key .fldMachineCode = T0.Field(Of String)("fldMachineCode")
                    } Into Group
                Select New With
                    {
                        Key Keys.fldYear,
                        Key Keys.fldMonth,
                        Key .fldMonthName = Group.FirstOrDefault.T0.Field(Of String)("fldMonthName"),
                        Key Keys.fldMachineCode,
                        Key .fldMachineName = Group.FirstOrDefault.T0.Field(Of String)("fldMachineName"),
                        Key .fldSharingMachine = Group.Count()
                    }
            ).ToList()

            ' Final Model Runtime per loop
            exceededModelCapacity = (
                From T0 In exceededModelCapacity
                Group Join T1 In modelCavity
                    On T0.fldYear Equals T1.fldYear And
                    T0.fldMonth Equals T1.fldMonth And
                    T0.fldModelCode Equals T1.fldModelCode And
                    T0.fldCategory Equals T1.fldCategory And
                    T0.fldResinMaterial Equals T1.fldResinMaterial And
                    T0.fldCavityName Equals T1.fldCavityName
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Group Join T2 In modelCycleTimePriority
                    On T0.fldYear Equals T2.fldYear And
                    T0.fldMonth Equals T2.fldMonth And
                    T0.fldMachineCode Equals T2.fldMachineCode
                    Into gT2 = Group
                From T2 In gT2.DefaultIfEmpty
                Where T0.fldYear = _year And
                    T0.fldMonth = _month
                Select New With
                    {
                        Key T0.fldID,
                        Key T0.fldYear,
                        Key T0.fldMonth,
                        Key T0.fldMonthName,
                        Key T0.fldMachineCode,
                        Key T0.fldMachineName,
                        Key T0.fldType,
                        Key T0.fldRobotModel,
                        Key T0.fldModelCode,
                        Key T0.fldModelName,
                        Key T0.fldCategory,
                        Key T0.fldCavityName,
                        Key T0.fldCycleTime,
                        Key T0.fldModelPriority,
                        Key T0.fldNextModelPriority,
                        Key T0.fldMachinePriority,
                        Key T0.fldNextMachinePriority,
                        Key T0.fldResinMaterial,
                        Key T0.fldNoOfCavity,
                        Key T0.fldRequirement,
                        Key T0.fldExcessRequirement,
                        Key T0.fldTotalWorkingDays,
                        Key T0.fldDailyTarget,
                        Key T0.fldYield,
                        Key T0.fldStartUp,
                        Key .fldChangeMold = Math.Round(
                            If(If(T2 IsNot Nothing, T2.fldSharingMachine, 0) > 1,
                                T1.fldChangeMold / 24 / 60,
                                0
                            ),
                        4),
                        Key T0.fldMDC,
                        Key T0.fldDowntime,
                        Key .fldOperationRate = Math.Round(
                            1.0 -
                            (
                                T0.fldStartUp +
                                Math.Round(
                                    If(If(T2 IsNot Nothing, T2.fldSharingMachine, 0) > 1,
                                        T1.fldChangeMold / 24 / 60,
                                        0
                                    ),
                                4) +
                                T0.fldMDC +
                                T0.fldDowntime
                            ),
                        4),
                        Key .fldCapacity = Math.Round(
                            If(Not Double.IsNaN(
                                (
                                    Math.Round(
                                        T0.fldRequirement /
                                        T0.fldTotalWorkingDays,
                                        0
                                    ) *
                                    T0.fldCycleTime /
                                    T0.fldYield /
                                    Math.Round(
                                        1.0 -
                                        (
                                            T0.fldStartUp +
                                            Math.Round(
                                                If(If(T2 IsNot Nothing, T2.fldSharingMachine, 0) > 1,
                                                    T1.fldChangeMold / 24 / 60,
                                                    0
                                                ),
                                            4) +
                                            T0.fldMDC +
                                            T0.fldDowntime
                                        ),
                                    4) /
                                    3600
                                ) /
                                T0.fldNoOfCavity),
                                (
                                    Math.Round(
                                        T0.fldRequirement /
                                        T0.fldTotalWorkingDays,
                                        0
                                    ) *
                                    T0.fldCycleTime /
                                    T0.fldYield /
                                    Math.Round(
                                        1.0 -
                                        (
                                            T0.fldStartUp +
                                            Math.Round(
                                                If(If(T2 IsNot Nothing, T2.fldSharingMachine, 0) > 1,
                                                    T1.fldChangeMold / 24 / 60,
                                                    0
                                                ),
                                            4) +
                                            T0.fldMDC +
                                            T0.fldDowntime
                                        ),
                                    4) /
                                    3600
                                ) /
                                T0.fldNoOfCavity,
                            0),
                        3),
                        Key T0.fldDateAdded,
                        Key T0.fldAddedBy
                    }
            ).ToList()

        Next

        ' ---------------------------------------
        ' ---------- Machine Auto Plan ----------
        ' ---------------------------------------

        ' Check for Machine Run Time
        Dim machineRunTime = (
            From T0 In exceededModelCapacity
            Group By Keys = New With
                {
                    Key T0.fldYear,
                    Key T0.fldMonth,
                    Key T0.fldMachineCode
                } Into Group
            Select New With
                {
                    Key Keys.fldYear,
                    Key Keys.fldMonth,
                    Key Group.FirstOrDefault.fldMonthName,
                    Key Keys.fldMachineCode,
                    Key .fldRunTime = Group.Sum(Function(x) x.fldCapacity)
                }
        ).ToList()

        ' Get Model Exceeding to 24hr
        Dim machineHoursPerDay As Integer = 3
        Dim exceedingMachineRunTime = (
            From T0 In machineRunTime
            Where T0.fldRunTime >= machineHoursPerDay
            Select T0
        ).ToList()

        ' Transfer exceeded capacity to next priority
        Dim machinePriority As Integer = 1
        Dim machineLastPriority As Integer = 1
        For count As Integer = 1 To machineLastPriority + 1

            machinePriority = count

            While True

                exceededModelCapacity = (
                    From T0 In exceededModelCapacity
                    Group Join T1 In exceedingMachineRunTime
                        On T0.fldYear Equals T1.fldYear And
                        T0.fldMonth Equals T1.fldMonth And
                        T0.fldMachineCode Equals T1.fldMachineCode
                        Into gT1 = Group
                    From T1 In gT1.DefaultIfEmpty
                    Select New With
                    {
                        Key T0.fldID,
                        Key T0.fldYear,
                        Key T0.fldMonth,
                        Key T0.fldMonthName,
                        Key T0.fldMachineCode,
                        Key T0.fldMachineName,
                        Key T0.fldType,
                        Key T0.fldRobotModel,
                        Key T0.fldModelCode,
                        Key T0.fldModelName,
                        Key T0.fldCategory,
                        Key T0.fldCavityName,
                        Key T0.fldCycleTime,
                        Key T0.fldModelPriority,
                        Key T0.fldNextModelPriority,
                        Key T0.fldMachinePriority,
                        Key T0.fldNextMachinePriority,
                        Key T0.fldResinMaterial,
                        Key T0.fldNoOfCavity,
                        Key .fldRequirement = If(T0.fldMachinePriority = machinePriority And (T0.fldNextMachinePriority = machinePriority + 1 Or T0.fldNextMachinePriority = 0) And T0.fldRequirement > 100,
                            If(T1 IsNot Nothing, T0.fldRequirement - 100, T0.fldRequirement),
                            T0.fldRequirement
                        ),
                        Key .fldExcessRequirement = If(T0.fldMachinePriority = machinePriority And (T0.fldNextMachinePriority = machinePriority + 1 Or T0.fldNextMachinePriority = 0) And T0.fldRequirement > 100,
                            If(T1 IsNot Nothing, T0.fldExcessRequirement + 100, T0.fldExcessRequirement),
                            T0.fldExcessRequirement
                        ),
                        Key T0.fldTotalWorkingDays,
                        Key .fldDailyTarget = Math.Round(
                            If(T0.fldMachinePriority = machinePriority And (T0.fldNextMachinePriority = machinePriority + 1 Or T0.fldNextMachinePriority = 0) And T0.fldRequirement > 100,
                                If(T1 IsNot Nothing, T0.fldRequirement - 100, T0.fldRequirement),
                                T0.fldRequirement
                            ) /
                            T0.fldTotalWorkingDays,
                            0
                        ),
                        Key T0.fldYield,
                        Key T0.fldStartUp,
                        Key T0.fldChangeMold,
                        Key T0.fldMDC,
                        Key T0.fldDowntime,
                        Key T0.fldOperationRate,
                        Key .fldCapacity = Math.Round(
                            If(Not Double.IsNaN((
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        If(T0.fldMachinePriority = machinePriority And (T0.fldNextMachinePriority = machinePriority + 1 Or T0.fldNextMachinePriority = 0) And T0.fldRequirement > 100,
                                            If(T1 IsNot Nothing, T0.fldRequirement - 100, T0.fldRequirement),
                                            T0.fldRequirement
                                        ),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity),
                            (
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        If(T0.fldMachinePriority = machinePriority And (T0.fldNextMachinePriority = machinePriority + 1 Or T0.fldNextMachinePriority = 0) And T0.fldRequirement > 100,
                                            If(T1 IsNot Nothing, T0.fldRequirement - 100, T0.fldRequirement),
                                            T0.fldRequirement
                                        ),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity,
                            0),
                        3),
                        Key T0.fldDateAdded,
                        Key T0.fldAddedBy
                    }
                ).ToList()

                machineRunTime = (
                    From T0 In exceededModelCapacity
                    Where T0.fldModelPriority = machinePriority
                    Group By Keys = New With
                        {
                            Key T0.fldYear,
                            Key T0.fldMonth,
                            Key T0.fldMachineCode
                        } Into Group
                    Select New With
                        {
                            Key Keys.fldYear,
                            Key Keys.fldMonth,
                            Key Group.FirstOrDefault.fldMonthName,
                            Key Keys.fldMachineCode,
                            Key .fldRunTime = Group.Sum(Function(x) x.fldCapacity)
                        }
                ).ToList()

                exceedingMachineRunTime = (
                    From T0 In machineRunTime
                    Where T0.fldRunTime >= machineHoursPerDay
                    Select T0
                ).ToList()

                If exceedingMachineRunTime.Count = 0 Then
                    Exit While
                End If

            End While

            If machinePriority = machineLastPriority + 1 Then

                ' Transfer Excess Requirement to the next 1st Priority
                exceededModelCapacity = (
                    From T0 In exceededModelCapacity
                    Let _WithExcessRequirement = ConvertToDatatable(exceededModelCapacity).Select(
                        "fldYear = " & T0.fldYear & " AND " &
                        "fldMonth = " & T0.fldMonth & " AND " &
                        "fldModelCode = '" & T0.fldModelCode & "' AND " &
                        "fldCategory = '" & T0.fldCategory & "' AND " &
                        "fldResinMaterial = '" & T0.fldResinMaterial & "' AND " &
                        "fldCavityName = '" & T0.fldCavityName & "' AND " &
                        "fldMachinePriority = " & machinePriority & " AND " &
                        "(fldNextMachinePriority = " & 0 & " OR " &
                        "fldNextMachinePriority = " & machinePriority + 1 & ") AND " &
                        "fldExcessRequirement > " & 0
                        )
                    Select New With
                    {
                        Key T0.fldID,
                        Key T0.fldYear,
                        Key T0.fldMonth,
                        Key T0.fldMonthName,
                        Key T0.fldMachineCode,
                        Key T0.fldMachineName,
                        Key T0.fldType,
                        Key T0.fldRobotModel,
                        Key T0.fldModelCode,
                        Key T0.fldModelName,
                        Key T0.fldCategory,
                        Key T0.fldCavityName,
                        Key T0.fldCycleTime,
                        Key T0.fldModelPriority,
                        Key T0.fldNextModelPriority,
                        Key T0.fldMachinePriority,
                        Key T0.fldNextMachinePriority,
                        Key T0.fldResinMaterial,
                        Key T0.fldNoOfCavity,
                        Key .fldRequirement = Convert.ToInt32(If(
                            _WithExcessRequirement.Count > 0,
                            If(T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldMachinePriority") = machinePriority And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0,
                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                T0.fldRequirement
                            ),
                            T0.fldRequirement
                        )),
                        Key .fldExcessRequirement = Convert.ToInt32(0),
                        Key T0.fldTotalWorkingDays,
                        Key .fldDailyTarget = Math.Round(
                            Convert.ToInt32(If(
                                _WithExcessRequirement.Count > 0,
                                If(T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldMachinePriority") = machinePriority And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0,
                                    T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                    T0.fldRequirement
                                ),
                                T0.fldRequirement
                            )) /
                            T0.fldTotalWorkingDays,
                            0
                        ),
                        Key T0.fldYield,
                        Key T0.fldStartUp,
                        Key T0.fldChangeMold,
                        Key T0.fldMDC,
                        Key T0.fldDowntime,
                        Key T0.fldOperationRate,
                        Key .fldCapacity = Math.Round(
                            If(Not Double.IsNaN((
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        Convert.ToInt32(If(
                                            _WithExcessRequirement.Count > 0,
                                            If(T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldMachinePriority") = machinePriority And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0,
                                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                                T0.fldRequirement
                                            ),
                                            T0.fldRequirement
                                        )),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity),
                            (
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        Convert.ToInt32(If(
                                            _WithExcessRequirement.Count > 0,
                                            If(T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldMachinePriority") = machinePriority And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0,
                                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                                T0.fldRequirement
                                            ),
                                            T0.fldRequirement
                                        )),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity,
                            0),
                        3),
                        Key T0.fldDateAdded,
                        Key T0.fldAddedBy
                    }
                ).ToList()

            Else

                ' Transfer Excess Requirement to the next priority
                exceededModelCapacity = (
                    From T0 In exceededModelCapacity
                    Let _WithExcessRequirement = ConvertToDatatable(exceededModelCapacity).Select(
                        "fldYear = " & T0.fldYear & " AND " &
                        "fldMonth = " & T0.fldMonth & " AND " &
                        "fldModelCode = '" & T0.fldModelCode & "' AND " &
                        "fldCategory = '" & T0.fldCategory & "' AND " &
                        "fldResinMaterial = '" & T0.fldResinMaterial & "' AND " &
                        "fldCavityName = '" & T0.fldCavityName & "' AND " &
                        "fldMachinePriority = " & machinePriority & " AND " &
                        "(fldNextMachinePriority = " & 0 & " OR " &
                        "fldNextMachinePriority = " & machinePriority + 1 & ") AND " &
                        "fldExcessRequirement > " & 0
                        )
                    Select New With
                    {
                        Key T0.fldID,
                        Key T0.fldYear,
                        Key T0.fldMonth,
                        Key T0.fldMonthName,
                        Key T0.fldMachineCode,
                        Key T0.fldMachineName,
                        Key T0.fldType,
                        Key T0.fldRobotModel,
                        Key T0.fldModelCode,
                        Key T0.fldModelName,
                        Key T0.fldCategory,
                        Key T0.fldCavityName,
                        Key T0.fldCycleTime,
                        Key T0.fldModelPriority,
                        Key T0.fldNextModelPriority,
                        Key T0.fldMachinePriority,
                        Key T0.fldNextMachinePriority,
                        Key T0.fldResinMaterial,
                        Key T0.fldNoOfCavity,
                        Key .fldRequirement = Convert.ToInt32(If(
                            _WithExcessRequirement.Count > 0,
                            If((T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldNextMachinePriority") = 0 And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0) Or
                                (T0.fldMachinePriority = machinePriority + 1 And T0.fldMachinePriority = _WithExcessRequirement(0).Item("fldNextMachinePriority") And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0),
                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                T0.fldRequirement
                            ),
                            T0.fldRequirement
                        )),
                        Key .fldExcessRequirement = Convert.ToInt32(0),
                        Key T0.fldTotalWorkingDays,
                        Key .fldDailyTarget = Math.Round(
                            Convert.ToInt32(If(
                                _WithExcessRequirement.Count > 0,
                                If((T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldNextMachinePriority") = 0 And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0) Or
                                    (T0.fldMachinePriority = machinePriority + 1 And T0.fldMachinePriority = _WithExcessRequirement(0).Item("fldNextMachinePriority") And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0),
                                    T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                    T0.fldRequirement
                                ),
                                T0.fldRequirement
                            )) /
                            T0.fldTotalWorkingDays,
                            0
                        ),
                        Key T0.fldYield,
                        Key T0.fldStartUp,
                        Key T0.fldChangeMold,
                        Key T0.fldMDC,
                        Key T0.fldDowntime,
                        Key T0.fldOperationRate,
                        Key .fldCapacity = Math.Round(
                            If(Not Double.IsNaN((
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        Convert.ToInt32(If(
                                            _WithExcessRequirement.Count > 0,
                                            If((T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldNextMachinePriority") = 0 And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0) Or
                                                (T0.fldMachinePriority = machinePriority + 1 And T0.fldMachinePriority = _WithExcessRequirement(0).Item("fldNextMachinePriority") And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0),
                                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                                T0.fldRequirement
                                            ),
                                            T0.fldRequirement
                                        )),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity),
                            (
                                Math.Round(
                                    Convert.ToInt32(Math.Round(
                                        Convert.ToInt32(If(
                                            _WithExcessRequirement.Count > 0,
                                            If((T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldNextMachinePriority") = 0 And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0) Or
                                                (T0.fldMachinePriority = machinePriority + 1 And T0.fldMachinePriority = _WithExcessRequirement(0).Item("fldNextMachinePriority") And _WithExcessRequirement(0).Item("fldExcessRequirement") > 0),
                                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldExcessRequirement"),
                                                T0.fldRequirement
                                            ),
                                            T0.fldRequirement
                                        )),
                                    0)) /
                                    T0.fldTotalWorkingDays,
                                    0
                                ) *
                                T0.fldCycleTime /
                                T0.fldYield /
                                T0.fldOperationRate /
                                3600
                            ) / T0.fldNoOfCavity,
                            0),
                        3),
                        Key T0.fldDateAdded,
                        Key T0.fldAddedBy
                    }
                ).ToList()

            End If

            ' Transfer Requirement to 1st priority for excess that unable to compute
            exceededModelCapacity = (
                From T0 In exceededModelCapacity
                Let _WithExcessRequirement = ConvertToDatatable(exceededModelCapacity).Select(
                    "fldYear = " & T0.fldYear & " AND " &
                    "fldMonth = " & T0.fldMonth & " AND " &
                    "fldModelCode = '" & T0.fldModelCode & "' AND " &
                    "fldCategory = '" & T0.fldCategory & "' AND " &
                    "fldResinMaterial = '" & T0.fldResinMaterial & "' AND " &
                    "fldCavityName = '" & T0.fldCavityName & "' AND " &
                    "fldMachinePriority = " & machinePriority + 1 & " AND " &
                    "fldRequirement > " & 0
                    )
                Select New With
                {
                    Key T0.fldID,
                    Key T0.fldYear,
                    Key T0.fldMonth,
                    Key T0.fldMonthName,
                    Key T0.fldMachineCode,
                    Key T0.fldMachineName,
                    Key T0.fldType,
                    Key T0.fldRobotModel,
                    Key T0.fldModelCode,
                    Key T0.fldModelName,
                    Key T0.fldCategory,
                    Key T0.fldCavityName,
                    Key T0.fldCycleTime,
                    Key T0.fldModelPriority,
                    Key T0.fldNextModelPriority,
                    Key T0.fldMachinePriority,
                    Key T0.fldNextMachinePriority,
                    Key T0.fldResinMaterial,
                    Key T0.fldNoOfCavity,
                    Key .fldRequirement = Convert.ToInt32(If(
                        _WithExcessRequirement.Count > 0,
                        If(T0.fldMachinePriority = 1 And _WithExcessRequirement(0).Item("fldRequirement") > 0,
                            T0.fldRequirement + _WithExcessRequirement(0).Item("fldRequirement"),
                            If(T0.fldMachinePriority = _WithExcessRequirement(0).Item("fldMachinePriority"),
                                T0.fldRequirement - _WithExcessRequirement(0).Item("fldRequirement"),
                                T0.fldRequirement
                            )
                        ),
                        T0.fldRequirement
                    )),
                    Key .fldExcessRequirement = Convert.ToInt32(0),
                    Key T0.fldTotalWorkingDays,
                    Key .fldDailyTarget = Math.Round(
                        Convert.ToInt32(If(
                            _WithExcessRequirement.Count > 0,
                            If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldRequirement") > 0,
                                T0.fldRequirement + _WithExcessRequirement(0).Item("fldRequirement"),
                                If(T0.fldModelPriority = _WithExcessRequirement(0).Item("fldModelPriority"),
                                    T0.fldRequirement - _WithExcessRequirement(0).Item("fldRequirement"),
                                    T0.fldRequirement
                                )
                            ),
                            T0.fldRequirement
                        )) /
                        T0.fldTotalWorkingDays,
                        0
                    ),
                    Key T0.fldYield,
                    Key T0.fldStartUp,
                    Key T0.fldChangeMold,
                    Key T0.fldMDC,
                    Key T0.fldDowntime,
                    Key T0.fldOperationRate,
                    Key .fldCapacity = Math.Round(
                        If(Not Double.IsNaN((
                            Math.Round(
                                Convert.ToInt32(Math.Round(
                                    Convert.ToInt32(If(
                                        _WithExcessRequirement.Count > 0,
                                        If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldRequirement") > 0,
                                            T0.fldRequirement + _WithExcessRequirement(0).Item("fldRequirement"),
                                            If(T0.fldModelPriority = _WithExcessRequirement(0).Item("fldModelPriority"),
                                                T0.fldRequirement - _WithExcessRequirement(0).Item("fldRequirement"),
                                                T0.fldRequirement
                                            )
                                        ),
                                        T0.fldRequirement
                                    )),
                                0)) /
                                T0.fldTotalWorkingDays,
                                0
                            ) *
                            T0.fldCycleTime /
                            T0.fldYield /
                            T0.fldOperationRate /
                            3600
                        ) / T0.fldNoOfCavity),
                        (
                            Math.Round(
                                Convert.ToInt32(Math.Round(
                                    Convert.ToInt32(If(
                                        _WithExcessRequirement.Count > 0,
                                        If(T0.fldModelPriority = 1 And _WithExcessRequirement(0).Item("fldRequirement") > 0,
                                            T0.fldRequirement + _WithExcessRequirement(0).Item("fldRequirement"),
                                            If(T0.fldModelPriority = _WithExcessRequirement(0).Item("fldModelPriority"),
                                                T0.fldRequirement - _WithExcessRequirement(0).Item("fldRequirement"),
                                                T0.fldRequirement
                                            )
                                        ),
                                        T0.fldRequirement
                                    )),
                                0)) /
                                T0.fldTotalWorkingDays,
                                0
                            ) *
                            T0.fldCycleTime /
                            T0.fldYield /
                            T0.fldOperationRate /
                            3600
                        ) / T0.fldNoOfCavity,
                        0),
                    3),
                    Key T0.fldDateAdded,
                    Key T0.fldAddedBy
                }
            ).ToList()

            ' Check for sharing Moldie
            modelCycleTimePriority = (
                From T0 In tblModelCycleTime.AsEnumerable
                Group Join T1 In exceededModelCapacity
                    On T0.Field(Of Integer)("fldYear") Equals T1.fldYear And
                    T0.Field(Of Integer)("fldMonth") Equals T1.fldMonth And
                    T0.Field(Of String)("fldModelName") Equals T1.fldModelName And
                    T0.Field(Of String)("fldCategory") Equals T1.fldCategory And
                    T0.Field(Of String)("fldCavityName") Equals T1.fldCavityName And
                    T0.Field(Of Integer)("fldPriority") Equals T1.fldMachinePriority
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Where T0.Field(Of Integer)("fldYear") = _year And
                    T0.Field(Of Integer)("fldMonth") = _month And
                    If(T1 IsNot Nothing, T1.fldDailyTarget, 0) > 0
                Group By Keys = New With
                    {
                        Key .fldYear = T0.Field(Of Integer)("fldYear"),
                        Key .fldMonth = T0.Field(Of Integer)("fldMonth"),
                        Key .fldMachineCode = T0.Field(Of String)("fldMachineCode")
                    } Into Group
                Select New With
                    {
                        Key Keys.fldYear,
                        Key Keys.fldMonth,
                        Key .fldMonthName = Group.FirstOrDefault.T0.Field(Of String)("fldMonthName"),
                        Key Keys.fldMachineCode,
                        Key .fldMachineName = Group.FirstOrDefault.T0.Field(Of String)("fldMachineName"),
                        Key .fldSharingMachine = Group.Count()
                    }
            ).ToList()

            ' Final Model Runtime per loop
            exceededModelCapacity = (
                From T0 In exceededModelCapacity
                Group Join T1 In modelCavity
                    On T0.fldYear Equals T1.fldYear And
                    T0.fldMonth Equals T1.fldMonth And
                    T0.fldModelCode Equals T1.fldModelCode And
                    T0.fldCategory Equals T1.fldCategory And
                    T0.fldResinMaterial Equals T1.fldResinMaterial And
                    T0.fldCavityName Equals T1.fldCavityName
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Group Join T2 In modelCycleTimePriority
                    On T0.fldYear Equals T2.fldYear And
                    T0.fldMonth Equals T2.fldMonth And
                    T0.fldMachineCode Equals T2.fldMachineCode
                    Into gT2 = Group
                From T2 In gT2.DefaultIfEmpty
                Where T0.fldYear = _year And
                    T0.fldMonth = _month
                Select New With
                    {
                        Key T0.fldID,
                        Key T0.fldYear,
                        Key T0.fldMonth,
                        Key T0.fldMonthName,
                        Key T0.fldMachineCode,
                        Key T0.fldMachineName,
                        Key T0.fldType,
                        Key T0.fldRobotModel,
                        Key T0.fldModelCode,
                        Key T0.fldModelName,
                        Key T0.fldCategory,
                        Key T0.fldCavityName,
                        Key T0.fldCycleTime,
                        Key T0.fldModelPriority,
                        Key T0.fldNextModelPriority,
                        Key T0.fldMachinePriority,
                        Key T0.fldNextMachinePriority,
                        Key T0.fldResinMaterial,
                        Key T0.fldNoOfCavity,
                        Key T0.fldRequirement,
                        Key T0.fldExcessRequirement,
                        Key T0.fldTotalWorkingDays,
                        Key T0.fldDailyTarget,
                        Key T0.fldYield,
                        Key T0.fldStartUp,
                        Key .fldChangeMold = Math.Round(
                            If(If(T2 IsNot Nothing, T2.fldSharingMachine, 0) > 1,
                                T1.fldChangeMold / 24 / 60,
                                0
                            ),
                        4),
                        Key T0.fldMDC,
                        Key T0.fldDowntime,
                        Key .fldOperationRate = Math.Round(
                            1.0 -
                            (
                                T0.fldStartUp +
                                Math.Round(
                                    If(If(T2 IsNot Nothing, T2.fldSharingMachine, 0) > 1,
                                        T1.fldChangeMold / 24 / 60,
                                        0
                                    ),
                                4) +
                                T0.fldMDC +
                                T0.fldDowntime
                            ),
                        4),
                        Key .fldCapacity = Math.Round(
                            If(Not Double.IsNaN(
                                (
                                    Math.Round(
                                        T0.fldRequirement /
                                        T0.fldTotalWorkingDays,
                                        0
                                    ) *
                                    T0.fldCycleTime /
                                    T0.fldYield /
                                    Math.Round(
                                        1.0 -
                                        (
                                            T0.fldStartUp +
                                            Math.Round(
                                                If(If(T2 IsNot Nothing, T2.fldSharingMachine, 0) > 1,
                                                    T1.fldChangeMold / 24 / 60,
                                                    0
                                                ),
                                            4) +
                                            T0.fldMDC +
                                            T0.fldDowntime
                                        ),
                                    4) /
                                    3600
                                ) /
                                T0.fldNoOfCavity),
                                (
                                    Math.Round(
                                        T0.fldRequirement /
                                        T0.fldTotalWorkingDays,
                                        0
                                    ) *
                                    T0.fldCycleTime /
                                    T0.fldYield /
                                    Math.Round(
                                        1.0 -
                                        (
                                            T0.fldStartUp +
                                            Math.Round(
                                                If(If(T2 IsNot Nothing, T2.fldSharingMachine, 0) > 1,
                                                    T1.fldChangeMold / 24 / 60,
                                                    0
                                                ),
                                            4) +
                                            T0.fldMDC +
                                            T0.fldDowntime
                                        ),
                                    4) /
                                    3600
                                ) /
                                T0.fldNoOfCavity,
                            0),
                        3),
                        Key T0.fldDateAdded,
                        Key T0.fldAddedBy
                    }
            ).ToList()

        Next

        ' Final Model IM Plan
        exceededModelCapacity = (
            From T0 In exceededModelCapacity
            Where T0.fldYear = _year And
                T0.fldMonth = _month And
                T0.fldMachineCode <> Nothing
            Select T0
        ).ToList()

        Return ConvertToDatatable(exceededModelCapacity)

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

End Class
