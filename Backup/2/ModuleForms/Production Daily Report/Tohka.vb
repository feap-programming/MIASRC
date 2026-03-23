

Imports System.ComponentModel

Public Module Tohka
    Dim Furina As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    'Dim Furina As New Kurumi.DB("localhost", "dbmia", "root", "password")
    Dim CurrUser As String = globalVariables.currentUser(1)

    Dim PlannedDT As Integer
    Dim UnplannedDT As Integer
    Public Function SelectSrcTemplate(TableName As String, AssyModel As String, AssyLine As String) As DataTable

        Return Furina.MyQuery("select * from " & TableName & " where fldModel='" & AssyModel & "' and fldLine=" & AssyLine & "")

    End Function
    Public Function SelectSrcTable(TableName As String, DRID As Integer) As DataTable

        Return Furina.MyQuery("select * from " & TableName & " where fldDRID=" & DRID & "")

    End Function

    Public Function InsertSRCManpower(DRID As Integer, Process As String, Employee As String, Qualify As Integer, Transfer As Integer, Trainee As Integer) As String

        Try
            Furina.AddMySqlParameters("parDRID", DRID)
            Furina.AddMySqlParameters("parProcName", Process)
            Furina.AddMySqlParameters("parEmp", Employee)
            Furina.AddMySqlParameters("parQualified", Qualify)
            Furina.AddMySqlParameters("parTrans", Transfer)
            Furina.AddMySqlParameters("parTrain", Trainee)
            Furina.AddMySqlParameters("parUser", CurrUser)
            Furina.SPADE("SP_SRC_InsertManpowerData")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function InsertSRCManpowerv2(DRID As Integer, Team As Integer, Model As String, Line As Integer) As String

        Try
            Furina.AddMySqlParameters("parDRID", DRID)
            Furina.AddMySqlParameters("parTeam", Team)
            Furina.AddMySqlParameters("parModel", Model)
            Furina.AddMySqlParameters("parLine", Line)
            Furina.AddMySqlParameters("parUser", CurrUser)
            Furina.SPADE("SP_SRC_InsertManpowerDatav3")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function EditSRCManpower(ID As Integer, Process As String, Employee As String, Qualify As Integer, Transfer As Integer, Trainee As Integer) As String
        Try
            Furina.AddMySqlParameters("parID", ID)
            Furina.AddMySqlParameters("parProcName", Process)
            Furina.AddMySqlParameters("parEmp", Employee)
            Furina.AddMySqlParameters("parQualified", Qualify)
            Furina.AddMySqlParameters("parTrans", Transfer)
            Furina.AddMySqlParameters("parTrain", Trainee)
            Furina.SPADE("SP_SRC_EditManpowerData")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function DeleteSrcTable(TableName As String, ID As Integer) As String
        Try
            Furina.MyQuery("delete from " & TableName & " where fldID=" & ID & "")
            Return "Deleted"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function InsertSRCHourly(DRID As Integer, Time As String, CableG As Integer,
                                    StatorG As Integer, FinalProd As Integer, Rotator As Integer,
                                    Stator As Integer, SubStator As Integer, Sleeve As Integer,
                                    Barcode As String, Plan As Integer, Actual As Integer,
                                    Deviation As Integer, Electrical As Integer, Func As Integer, Final As Integer) As String

        Try
            Furina.AddMySqlParameters("parDRID", DRID)
            Furina.AddMySqlParameters("parTime", Time)
            Furina.AddMySqlParameters("parCableG", CableG)
            Furina.AddMySqlParameters("parStatorG", StatorG)
            Furina.AddMySqlParameters("parFinalProdCheck", FinalProd)
            Furina.AddMySqlParameters("parRotator", Rotator)
            Furina.AddMySqlParameters("parStator", Stator)
            Furina.AddMySqlParameters("parSubStator", SubStator)
            Furina.AddMySqlParameters("parSleeve", Sleeve)
            Furina.AddMySqlParameters("parBarcode", Barcode)
            Furina.AddMySqlParameters("parPlan", Plan)
            Furina.AddMySqlParameters("parActual", Actual)
            Furina.AddMySqlParameters("parDeviation", Deviation)
            Furina.AddMySqlParameters("parElectrical", Electrical)
            Furina.AddMySqlParameters("parFunction", Func)
            Furina.AddMySqlParameters("parFinal", Final)
            Furina.AddMySqlParameters("parUser", CurrUser)
            Furina.SPADE("SP_SRC_InsertHourlyQuality")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function EditSRCHourly(ID As Integer, Time As String, CableG As Integer,
                                    StatorG As Integer, FinalProd As Integer, Rotator As Integer,
                                    Stator As Integer, SubStator As Integer, Sleeve As Integer,
                                    Barcode As String, Plan As Integer, Actual As Integer,
                                    Deviation As Integer, Electrical As Integer, Func As Integer, Final As Integer) As String

        Try
            Furina.AddMySqlParameters("parID", ID)
            Furina.AddMySqlParameters("parTime", Time)
            Furina.AddMySqlParameters("parCableG", CableG)
            Furina.AddMySqlParameters("parStatorG", StatorG)
            Furina.AddMySqlParameters("parFinalProdCheck", FinalProd)
            Furina.AddMySqlParameters("parRotator", Rotator)
            Furina.AddMySqlParameters("parStator", Stator)
            Furina.AddMySqlParameters("parSubStator", SubStator)
            Furina.AddMySqlParameters("parSleeve", Sleeve)
            Furina.AddMySqlParameters("parBarcode", Barcode)
            Furina.AddMySqlParameters("parPlan", Plan)
            Furina.AddMySqlParameters("parActual", Actual)
            Furina.AddMySqlParameters("parDeviation", Deviation)
            Furina.AddMySqlParameters("parElectrical", Electrical)
            Furina.AddMySqlParameters("parFunction", Func)
            Furina.AddMySqlParameters("parFinal", Final)
            Furina.SPADE("SP_SRC_EditHourlyQuality")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function DeleteSrcTableByDRID(TableName As String, DRID As Integer) As String
        Try
            Furina.MyQuery("delete from " & TableName & " where fldDRID=" & DRID & "")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function InsertSRCAssyLineEff(DRID As Integer, TimePart As String, OpTime As Integer, Hotto As Integer, Plan As Integer, Unplan As Integer, Cycle As Double,
                                         Customer As String, FGNo As String, Model As String, ModelCode As String, LotNo As String,
                                         GoodQty As Integer, Delivered As String, Replace As Integer, Scrap As Integer, Sample As String) As String

        Try
            Furina.AddMySqlParameters("parDRID", DRID)
            Furina.AddMySqlParameters("parTimePartition", TimePart)
            Furina.AddMySqlParameters("parOpTime", OpTime)
            Furina.AddMySqlParameters("parHotto", Hotto)
            Furina.AddMySqlParameters("parPlanDownTime", Plan)
            Furina.AddMySqlParameters("parUnPlanDownTime", Unplan)
            Furina.AddMySqlParameters("parCycleTime", Cycle)
            Furina.AddMySqlParameters("parCustomer", Customer)
            Furina.AddMySqlParameters("parFGNo", FGNo)
            Furina.AddMySqlParameters("parModel", Model)
            Furina.AddMySqlParameters("parModelCode", ModelCode)
            Furina.AddMySqlParameters("parLotNo", LotNo)
            Furina.AddMySqlParameters("parGoodQty", GoodQty)
            Furina.AddMySqlParameters("parDelivery", Delivered)
            Furina.AddMySqlParameters("parReplacement", Replace)
            Furina.AddMySqlParameters("parAssyScrap", Scrap)
            Furina.AddMySqlParameters("parSample", Sample)
            Furina.AddMySqlParameters("parUser", CurrUser)
            Furina.SPADE("SP_SRC_InsertAssyLineEff2")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function


    Public Function SelectSrcALEData1(TableName As String, DRID As Integer) As DataTable
        Return Furina.MyQuery("select fldTimePartition,fldOpTime,fldHotto from " & TableName & " where fldDRID=" & DRID & " group by fldTimePartition,fldOpTime,fldHotto")
    End Function
    Public Function SelectSrcALEData2(TableName As String, DRID As Integer) As DataTable
        Return Furina.MyQuery("select * from " & TableName & " where fldDRID=" & DRID & "")
    End Function

    Public Function InsertSRCAssy(DRID As Integer, PartNo As String, PartName As String, LotNo As String, Scrap As String, Purge As String, QASample As String, EngSample As String) As String
        Try
            Furina.AddMySqlParameters("parDRID", DRID)
            Furina.AddMySqlParameters("parPartNo", PartNo)
            Furina.AddMySqlParameters("parPartName", PartName)
            Furina.AddMySqlParameters("parLotNo", LotNo)
            Furina.AddMySqlParameters("parScrapQty", Scrap)
            Furina.AddMySqlParameters("parPurgeQty", Purge)
            Furina.AddMySqlParameters("parQASample", QASample)
            Furina.AddMySqlParameters("parEngSample", EngSample)
            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRC_InsertSRCAssy")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function EditSRCAssy(ID As Integer, PartNo As String, PartName As String, LotNo As String, Scrap As String, Purge As String, QASample As String, EngSample As String) As String
        Try
            Furina.AddMySqlParameters("parID", ID)
            Furina.AddMySqlParameters("parPartNo", PartNo)
            Furina.AddMySqlParameters("parPartName", PartName)
            Furina.AddMySqlParameters("parLotNo", LotNo)
            Furina.AddMySqlParameters("parScrapQty", Scrap)
            Furina.AddMySqlParameters("parPurgeQty", Purge)
            Furina.AddMySqlParameters("parQASample", QASample)
            Furina.AddMySqlParameters("parEngSample", EngSample)
            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRC_EditSRCAssy")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function InsertSRCDefect(DRID As Integer, Code As String, PartName As String, Man As Integer, Machine As Integer, IM As Integer, FFC As Integer, SubAssy As Integer, RM As Integer, Categ As String) As String
        Try
            Furina.AddMySqlParameters("parDRID", DRID)
            Furina.AddMySqlParameters("parDefCode", Code)
            Furina.AddMySqlParameters("parPartName", PartName)
            Furina.AddMySqlParameters("parMan", Man)
            Furina.AddMySqlParameters("parMachine", Machine)
            Furina.AddMySqlParameters("parIM", IM)
            Furina.AddMySqlParameters("parFFC", FFC)
            Furina.AddMySqlParameters("parSubAssy", SubAssy)
            Furina.AddMySqlParameters("parRM", RM)
            Furina.AddMySqlParameters("parCateg", Categ)
            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRC_InsertSRCInProcDefect")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function EditSRCDefect(ID As Integer, Code As String, PartName As String, Man As Integer, Machine As Integer, IM As Integer, FFC As Integer, SubAssy As Integer, RM As Integer, Categ As String) As String
        Try
            Furina.AddMySqlParameters("parID", ID)
            Furina.AddMySqlParameters("parDefCode", Code)
            Furina.AddMySqlParameters("parPartName", PartName)
            Furina.AddMySqlParameters("parMan", Man)
            Furina.AddMySqlParameters("parMachine", Machine)
            Furina.AddMySqlParameters("parIM", IM)
            Furina.AddMySqlParameters("parFFC", FFC)
            Furina.AddMySqlParameters("parSubAssy", SubAssy)
            Furina.AddMySqlParameters("parRM", RM)
            Furina.AddMySqlParameters("parCateg", Categ)
            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRC_EditSRCInProcDefect")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function SelectSRCDefectByCateg(TableName As String, DRID As Integer, Categ As String)
        Return Furina.MyQuery("select * from " & TableName & " where fldDRID=" & DRID & " and fldCateg='" & Categ & "'")
    End Function
    Public Function InsertSRCOther(DRID As Integer, Mold As String, Init As String, Others As String) As String
        Try
            Furina.AddMySqlParameters("parDRID", DRID)
            Furina.AddMySqlParameters("parMoldParts", Mold)
            Furina.AddMySqlParameters("parInitProd", Init)
            Furina.AddMySqlParameters("parOthers", Others)
            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRCDailyReport_InsertOtherDetails")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function SelectSRCLotByTime(TableName As String, DRID As Integer, Time As String) As DataTable
        Furina.AddMySqlParameters("parDRID", DRID)
        Furina.AddMySqlParameters("parTime", Time)
        Return Furina.SPSelect("SP_SRC_SelectSRCLotByTime")
    End Function
    Public Function InsertSRCLotNo(DRID As Integer, Time As String, PartName As String, BoxNo As String, LotNo As String, CavNo As String) As String
        Dim ReturnDT As New DataTable
        Furina.AddMySqlParameters("parDRID", DRID)
        Furina.AddMySqlParameters("parTime", Time)
        Furina.AddMySqlParameters("parPartName", PartName)
        ReturnDT = Furina.SPSelect("SP_SRC_SelectSRCLotByTimeAndPartName")
        If ReturnDT.Rows.Count >= 1 Then
            Return "Part Name Already Exists"
        Else
            Try
                Furina.AddMySqlParameters("parDRID", DRID)
                Furina.AddMySqlParameters("parTime", Time)
                Furina.AddMySqlParameters("parBoxNo", BoxNo)
                Furina.AddMySqlParameters("parPartName", PartName)
                Furina.AddMySqlParameters("parLotNo", LotNo)
                Furina.AddMySqlParameters("parCavNo", CavNo)
                Furina.AddMySqlParameters("parAddedBy", CurrUser)
                Furina.SPADE("SP_SRCDailyReport_InsertRMWIP")
                Return "Good"
            Catch ex As Exception
                Return ex.Message
            End Try
        End If
    End Function
    Public Function EditSRCLotNo(ID As Integer, Time As String, PartName As String, BoxNo As String, LotNo As String, CavNo As String) As String
        Try
            Furina.AddMySqlParameters("parID", ID)
            Furina.AddMySqlParameters("parTime", Time)
            Furina.AddMySqlParameters("parBoxNo", BoxNo)
            Furina.AddMySqlParameters("parPartName", PartName)
            Furina.AddMySqlParameters("parLotNo", LotNo)
            Furina.AddMySqlParameters("parCavNo", CavNo)
            Furina.AddMySqlParameters("parAddedBy", CurrUser)
            Furina.SPADE("SP_SRCDailyReport_EditRMWIP")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function SelectBlankDiffBoxNo(DRID As Integer, Time As String, BoxNo As String) As Integer
        Furina.AddMySqlParameters("parDRID", DRID)
        Furina.AddMySqlParameters("parTime", Time)
        Furina.AddMySqlParameters("parBoxNo", BoxNo)
        Return Furina.SPSelect("SP_SRCDailyReport_SelectBlankDiffBoxNo").Rows.Count
    End Function

    Public Function EditSRCBoxNo(DRID As Integer, Time As String, BoxNo As String) As String
        Try
            Furina.AddMySqlParameters("parDRID", DRID)
            Furina.AddMySqlParameters("parTime", Time)
            Furina.AddMySqlParameters("parBoxNo", BoxNo)
            Furina.SPADE("SP_SRCDailyReport_EditSRCBoxNo")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function


    '[-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=PW=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-]

    Public Function SelectPWByModel(parModel As String, parLine As Integer, parType As String) As DataTable

        Furina.AddMySqlParameters("parModel", parModel)
        Furina.AddMySqlParameters("parLine", parLine)
        Furina.AddMySqlParameters("parType", parType)
        Return Furina.SPSelect("SP_PWDailyReport_SelectPWNo")

    End Function

    Public Function SelectPWManPowerProc(parModel As String, parLine As Integer, parType As String, parNo As String)

        Furina.AddMySqlParameters("parModel", parModel)
        Furina.AddMySqlParameters("parLine", parLine)
        Furina.AddMySqlParameters("parType", parType)
        Furina.AddMySqlParameters("parNo", parNo)
        Return Furina.SPSelect("SP_PWDailyReport_SelectPWManPowerProc")

    End Function

    Public Function SelectPWManPowerProcName(parModel As String, parLine As Integer, parType As String, parNo As String, parProc As String)

        Furina.AddMySqlParameters("parModel", parModel)
        Furina.AddMySqlParameters("parLine", parLine)
        Furina.AddMySqlParameters("parType", parType)
        Furina.AddMySqlParameters("parNo", parNo)
        Furina.AddMySqlParameters("parProc", parProc)
        Return Furina.SPSelect("SP_PWDailyReport_SelectPWManPowerProcName2")

    End Function

    Public Function SelectPWManpower(parDRID As Integer, parType As String, parNo As String) As DataTable
        Furina.AddMySqlParameters("parDRID", parDRID)
        Furina.AddMySqlParameters("parType", parType)
        Furina.AddMySqlParameters("parNo", parNo)
        Return Furina.SPSelect("SP_PWDailyReport_SelectPWManpower")
    End Function

    Public Function InsertPWManpower(parDRID As Integer, parType As String, parFWPWNo As String, parProcName As String, parEmployee As String, parQualified As Integer,
                                     parTransfer As Integer, parTrainee As Integer, parAddedBy As String) As String
        Try
            Furina.AddMySqlParameters("parDRID", parDRID)
            Furina.AddMySqlParameters("parType", parType)
            Furina.AddMySqlParameters("parFWPWNo", parFWPWNo)
            Furina.AddMySqlParameters("parProcName", parProcName)
            Furina.AddMySqlParameters("parEmployee", parEmployee)
            Furina.AddMySqlParameters("parQualified", parQualified)
            Furina.AddMySqlParameters("parTransfer", parTransfer)
            Furina.AddMySqlParameters("parTrainee", parTrainee)
            Furina.AddMySqlParameters("parAddedBy", parAddedBy)
            Furina.SPADE("SP_PWDailyReport_InsertPWManpower")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function EditPWManpower(parID As Integer, parFWPWNo As String, parProcName As String, parEmployee As String, parQualified As Integer,
                                     parTransfer As Integer, parTrainee As Integer) As String
        Try
            Furina.AddMySqlParameters("parID", parID)
            Furina.AddMySqlParameters("parFWPWNo", parFWPWNo)
            Furina.AddMySqlParameters("parProcName", parProcName)
            Furina.AddMySqlParameters("parEmployee", parEmployee)
            Furina.AddMySqlParameters("parQualified", parQualified)
            Furina.AddMySqlParameters("parTransfer", parTransfer)
            Furina.AddMySqlParameters("parTrainee", parTrainee)
            Furina.SPADE("SP_PWDailyReport_EditPWManpower")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function DeletePWManpower(parID As Integer) As String

        Try
            Furina.AddMySqlParameters("parID", parID)
            Furina.SPADE("SP_PWDailyReport_DeletePWManpower")
            Return "Deleted"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function SelectPWGoodQtyTemplate(parModel As String, parType As String, parNo As String, parLine As Integer) As DataTable

        Furina.AddMySqlParameters("parModel", parModel)
        Furina.AddMySqlParameters("parType", parType)
        Furina.AddMySqlParameters("parNo", parNo)
        Furina.AddMySqlParameters("parLine", parLine)
        Return Furina.SPSelect("SP_PWDailyReport_SelectPWGoodQtyTemplate")

    End Function

    Public Function SelectPWGoodQty(parDRID As Integer, parType As String, parNo As Integer) As DataTable

        Furina.AddMySqlParameters("parDRID", parDRID)
        Furina.AddMySqlParameters("parType", parType)
        Furina.AddMySqlParameters("parNo", parNo)
        Return Furina.SPSelect("SP_PWDailyReport_SelectPWGoodQty")

    End Function

    Public Function InsertPWGoodQty(parDRID As Integer, parType As String, parPWFWNo As String, parPartName As String, parQty As Decimal, parAddedBy As String) As String

        Try
            Furina.AddMySqlParameters("parDRID", parDRID)
            Furina.AddMySqlParameters("parType", parType)
            Furina.AddMySqlParameters("parPWFWNo", parPWFWNo)
            Furina.AddMySqlParameters("parPartName", parPartName)
            Furina.AddMySqlParameters("parQty", parQty)
            Furina.AddMySqlParameters("parAddedBy", parAddedBy)
            Furina.SPADE("SP_PWDailyReport_InsertPWGoodQty")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function UpdatePWGoodQty(parID As Integer, parPartName As String, parQty As Decimal) As String

        Try
            Furina.AddMySqlParameters("parID", parID)
            Furina.AddMySqlParameters("parPartName", parPartName)
            Furina.AddMySqlParameters("parQty", parQty)
            Furina.SPADE("SP_PWDailyReport_EditPWGoodQty")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function DeletePWGoodQty(parID As Integer)

        Try
            Furina.AddMySqlParameters("parID", parID)
            Furina.SPADE("SP_PWDailyReport_DeletePWGoodQty")
            Return "Deleted"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Function InsertPWGoodQty(parDRID As Integer, parType As String, parFWPWNo As String,
                                    parLineTimePart As String, parStart As Decimal, parPlanned As Decimal,
                                    parUnplanned As Decimal, parOPTime As Decimal, parNoPerson As Decimal) As String

        Try
            Furina.AddMySqlParameters("parDRID", parDRID)
            Furina.AddMySqlParameters("parType", parType)
            Furina.AddMySqlParameters("parFWPWNo", parFWPWNo)
            Furina.AddMySqlParameters("parLineTimePart", parLineTimePart)
            Furina.AddMySqlParameters("parStart", parStart)
            Furina.AddMySqlParameters("parPlanned", parPlanned)
            Furina.AddMySqlParameters("parUnplanned", parUnplanned)
            Furina.AddMySqlParameters("parOPTime", parOPTime)
            Furina.AddMySqlParameters("parNoPerson", parNoPerson)
            Furina.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
            Furina.SPADE("SP_SRCDailyReport_InsertWeldingManpower")
            Return "Good"
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    '[-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=Auto Taping=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-]

    Public Function InsertAutoTaping(parModel As String, parLineNo As Integer, parDate As DateTime, parShift As String, parGroup As Integer, parAddedBy As String) As Boolean

        Try

            Furina.AddMySqlParameters("parModel", parModel)
            Furina.AddMySqlParameters("parLineNo", parLineNo)
            Furina.AddMySqlParameters("parDate", parDate)
            Furina.AddMySqlParameters("parShift", parShift)
            Furina.AddMySqlParameters("parGroup", parGroup)
            Furina.AddMySqlParameters("parAddedBy", parAddedBy)
            Furina.SPADE("SP_SRC_InsertAT")

            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    Public Function SelectAutoTaping(parModel As String, parLine As Integer) As DataTable

        Furina.AddMySqlParameters("parModel", parModel)
        Furina.AddMySqlParameters("parLine", parLine)
        Return Furina.SPSelect("SP_SRC_SelectAT")

    End Function

    Public Function InsertTime(parDRID As Integer, parType As String, parTimeFrom As DateTime, parTimeTo As DateTime, parAddedBy As String, parMachNo As String) As Boolean

        Try
            Furina.AddMySqlParameters("parDRID", parDRID)
            Furina.AddMySqlParameters("parType", parType)
            Furina.AddMySqlParameters("parTimeFrom", parTimeFrom)
            Furina.AddMySqlParameters("parTimeTo", parTimeTo)
            Furina.AddMySqlParameters("parAddedBy", parAddedBy)
            Furina.AddMySqlParameters("parMachNo", parMachNo)
            Furina.SPADE("SP_SRC_InsertTime")
            Return 1
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function SelectTime(parDRID As Integer, parType As String) As DataTable

        Return Furina.MyQuery("SELECT * FROM tblDailyReportTime where fldDRID=" & parDRID & " and fldType='" & parType & "'")

    End Function

    Public Function DeleteTime(parID As Integer)

        Try
            Furina.MyQuery("Delete From tblDailyReportTime where fldID=" & parID & "")
            Return 1
        Catch ex As Exception
            Return 0
        End Try

    End Function

    '[-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=Others=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-]
    Private Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
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

    '##################%%##+========---+*******#**##########%%%%%###**##%%%%%%%%##******************#********************#%%#########=========*###**#****####+========+#*
    '##*%%#################*==========***#***#***-=#######%%%#*************#***********************#*****#*****************#%#########=====-=====*##**####**#*-========*#
    '##*#########***%%%######+======-+#*#**#**+::-=+#####%#******#********#**********##******#%#*#%****#%########***********%%%#######*++==:=======+##*##**#*#*=======###
    '###%########**%%%%%%%######+===+#*#****+:::-=#####%%#+*****#*******#####################%###%#####%################****%%%%%%#########:-=====+=-=*#*#**###=====*###%
    '####%#######*#@%%%%%%%#*#####*+###*###-.::-+####%%#*+*****#******##%##########%#######%@###%#####%####################*#%%%%###########======*+----+*#*#***===*####%
    '############*%@%%%%%%%%#==+*#**#######+.::+####%#++=+****#**-+***#%#####%%###%#######%@###%####%%#######################*#*****#########=====**=-----=#*#*#*+*==+##%
    '#####%######%%%%%%%%%##################=:=##%%***++=****#**=+****###+##%%###%#######%@%##%#####%###############%%########%*******#######====+##=------:#***#=====###
    '+#####%%%###############################%%#******+=++**#**=+**=*%#*=##%%###%%######@@%##%%####%##**##=*########%#########%#*******###+======*##+-------.*****======#
    '#######################################%%#****#**=++=*##*=+**=*%#*=##%%###%%######@@%##%@####@%##+##++####%%%%%%%#######%%###*****###=======###*-------::***#+=====+
    '#######%%%%%##########################%%#****##*+=+=*##*=+**=*%#*=##%%##%%@%#%%%%@@%##%@%%%#@@##**#*=#####%%%%@%%%%%%###%######***%##*=====+####=-====--::**#*=====*
    '#########%######%%%##################%#***####**=+=*#%#*+**+#%%#+##%%#%%%%%%%%%%@@@%%%@%%%%%@%##=**=*######%%@@%%%%%%%%#%#######**#%%##====#####+-======-.-###*==+##
    '#######%######@@%###################%#*#####%#*++=+#%#*+##*#%*%*##%%%%%%%%%%%%%@@@%%%@@%%%%@@##+*#++##*+####%@%%%%%%%%%%%%########**#%%#+=+#####*========-.+###+####
    '%%%##%######@@%#####################%#######%#*+*+#%##+###%@-###%%@%%%%%@%%%%%@@@%%%%@%%%%@@%##+#*=**#=*#+*%@@%%%%%%%%%%%%%%########**#%###############*==::+#######
    '%%##%#####@@@##############################%##+**#%%###%%%@=*%%%%@%%%%%@%%%%%@@@@%%%@@%%%@@@##+##=*##++#*=#%@@%%%*#%%%%%%%%%%%#########*#%%###############=.=-######
    '%%%#####@@@%#####%########################%%##+##%@%%%%%%@+-@%%%%@%%%%%@%%%%%@@@%%%@@%%%@@@@%###**###=##+##%@@%%%+#%%%%%%%%%%%%%%########*##%%#############+=:-#####
    '%#####%@@@######%#################%####%%%%%%##%%@%%%%%%@#:#@%%%@%%%%%@%%%%%@@@%%%%@@%%%@@@@%%##+##%####*%%@@@%%#+#%%%%@%%%%%%%%%%%%########*###############*=:=####
    '#####@@@@#####%###################%#%%%%%%%%%%%%@@%%%%%@@+#@@@%@@%%%%%@%%%%@@@@%%%@@%%%%@@@%%%%+#%%@%%%%%%@@@%%%#+%%%%%@@%%%%%%%%%%%%%%#########*###%%#***+++=-:*###
    '####%@@%#####%###################%%%%%%%%%%%%%%@@@%%%@@@=:#@%%@@@@@%%@%%%%@@@@%%%%@@%%%#@@@%%%%*%%@@%%%%%%@@@%@%#+%%%%%@@%%%%%%%%%%%%%%%%%%##########%%*++++*###=###
    '###########%%#######%@@@@%###+:  #%%%%%%%%%%%%@@@%@@@%@%--@@@@@@%@@@@@%%%@@@@@%%%@@%%@#%@@@%%%%%%%@@%%@@%@@@@%@%#*%%%%%@@%%%%%%@@%%%%%%%%%%%%%####%####%#++#%%#####%
    '*##################%@@@@@@@# --=+%%%%%%%%@@%%%@@@@@@@@@=:*@@@@@@@@@@@@@@@@@@@@%@%@@@@@+@@@@@@@%%%@@@@@@@@@@@@%@%*#%%%%%@@@%@@%%@%%%%%%%%%%%%%%%%%%%#####%%%%%%####%%
    '   .###############@@@@@@@%.=--:+%%%%@@@@@@@@@@@@@@@@@#:-%@@@@@@@@@@@@@@@@@@@@@#%@@@@=+@@@@@@@@@@@@@@@@@@@@@@@#%##%%%@@@@@@@@@%@@%%%%*%%%%%%%%%%%%%%%%##%%%@@@####@@
    '  -#####-.-+######-.-#@@@%:   ==%%@%@@@@@@@@@@@@@@@@@@=-=@@@@@@@@@@@@@@@@@@@@@@+@@@@#:%@@@@@@@@@@@@@@@@@@#@@@@#%#%%@@@@@@@@@@@@@@%%%#+%%%%%%%%%%%%%%%%%%%%%@@@####@@
    ' =#####-   .#####*     .+=  .=-=%@@@@@@@@@@@@@@@@@@@@%--+@@@@#@@@@@@@@@@@@@@@@@@@@@@=-@@@@@@@@@@@@@@@@@@@=@@@@*%@@@@@@@@@@@@@@@@@@%%#+%%#%%%%%%%%%%%%%%%%%%%@@###@@@
    '-#####=    =#####.      -. .---+@@@@@@@@@@@@@@@@@@@@@=::#@@@#*@@@@@@@@@@@@@@@%=@@@@#:-@@@@@@@@@@@@@@@@@@%-%@@@*%@@@@@@@@@@@@@@@@@@@%#=%%*%%@@@%%%%%@%%%%%@%%@@##%@@@
    '#####+     #####+       -  :---%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+:@@@@*.=@@@@@@@@@@%@@@@@@@#:%@@@+%@@@@@@@@@@@@@@@@@@@%#=#%*%%@@@@@@@@@%%%%%@%%@@%#####
    '####*     =#####.       - :=-+=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+@@@@@@#@@%--@@@%%@*@@@@@@@@@%%@@@@@@@*:*@@@+#@@@@@@@@@@@@@@@@@@@%%=#%+%%@@@@@@@@@@@@@%@@@@@@%%###
    '####.    .#####=        -..+:++@@@@@@@@@@@@@@@#%@@%=-:::@@@##%@@@@@@@@@@@%@@-:=@@@: -@@@@@@@@@@#%@@@@@@@=-+@@@*+@@@@@@@@@@@@@@@@@@@@%+%%*%@@@@@@@@@@@@@@@@@@@@@%%%@@
    '###.     :#####.        :: =-+@@@@@@@@@@@@@@@@=.%@+:::.#@@@@###@@@@@@@@@++@@::+@@* .-%@@@@@@@@@+%@@@@@@@---@@@*=@@@@@@@@@@@@@@@@@@@@@#%%*%@@@@@@@@@@@@@@@@@@@@@%@%%@
    '.=-      +####+         .= :+=@@@@@@@@@@@@@@@@: .%*    %@%%%%%@@@@@@@@@@##@-.+*@@- .-#@@@@@@@@@=%@@@@@@@::-%@@%-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@%%
    '        .#####:          -: -#@@@@@@@@@@@@@@@@.  .#.   :+#%%%%@@@@@@@@@@@@@: :#@%-..-#@@@@@@@@@-%@@@@@@@:.:*@@%:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@%@@%
    '        :#####           .=. *@@@@@@@@@@@@@@@@.   .+     .#%#@@@@@@@%@@@@@@@=-*@%-: :*@@@@@@@@@-%@@@@@@@+*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@%%@@
    '        :####=            := %@@@@@@@@@@@@@@@@.        *@####%@@@@%%%@@@@@@@.:%@--: :+@@@@@@@@%-%@@@@@@@. .-%@@-:%@@@@@#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@%@@
    '         :+##:             .+@@@@@@@#@@@@@@@@@.      -.:@%###**###%%%%@@#=@@= +#:-: :-@@@@@@@@#:%@@@@@@@:  :+@@+-+@@@@@*@@@@@@@@@@@@@@@@@@@@*%@@@@@@@@@@@@@@##%%@%%@
    '                            =@@@@@@@*@@@@@@@@@.       :*@@#****#####:-*-:-@@# =-.-. .-+@@@@@@@*:%@@@@@@@:  .-%@*--@@@@@##@@@@@@@@@@@@@@@@@@@@*@@@@@@@@@@@@@@*+%%%@%@
    '                            *@@@@@@@#@@@@@@@@@:          .+%%#*####@+   . =**.:: :. .--:=*@@@@*:%@@@@@@@:   :=@*--+@@@@%=@@@@@@@@@@@@@@@@@@@@*@@@@@@@@@@@@@@@+%%@%%%
    '                           .%@@@@@@%#@@@@@@@@@-              :+#%@%.       =..        .::---=*+:-%@@@@@@-    :%#:--@@@@@-%@@@@@@@@@@@@@@@@@@@##@@@@@@@@@@@@@@@%%@%@#
    '                           .@@@@@@@#%@@@@@@@@@*                   .                          .. ..:+%@@@%===-=*@==-+@@@@--@@@@@@@@@@@@@@@@@@@@+@@@@@@@@@@@@@@@%%@###
    '                           :@@@@@@@+@@@@@@@@=@%.                                                 :=+**%@@%#*+-:+-.--#@@@+-#@@@@@@@@@@@@@@@@@@@*%@@@@@@@@@@@@@@######
    '                           -@@@@@@@+@@@@@@@@-*@:                                               .-: :%@@@@@@@@@@@@@@@%@@@+--@@@@@@@@@@@@@@@@@@@%*@@@@@@@@@@@@@@@#####
    '                          .+@@@@@@@*@@@@@@@%--#=                                                .=%@@%++@@:::=#%@@@@@@@@@%==@@@@@@@@@@@@@@@@@@@*@@@@@@@@@@@@@@@%####
    '                         .:#@@@@@@%*@@@@@@@#--:=                                                ==. .::@@+.:.:-=+=+=+%@@@@@@@@@@@@@@@@@@@@@@@@@#*@@@**@@@@@@@@@@####
    '              ..         .-@@@@@@@##@@@@@@@#::-::                                                     -@%+==---*++****@@@@@@@@@@@@@@@@@@@@@@@@@@+@@@* *@@@@@@@@@%###
    '             .+:        .-=@@@@@@@#%@@@@@@@*:.:.                                                        :=+===%*=+*+-%@*@@@@@@@@@@@@@@@@@@@@@@@@%#@@*  =@@@@@@@@@%##
    '             -=-        :-*@@@@@@@#%@@@@@@@*-. .                                                      .%*+*++-:::+##%@*:*@+@@@@@@@@@@@@@@@@@@@@@@*@@# . =@@@@@@@@@##
    '             +--.      .--%@@@@@@@*%@@@@@@@#-.                                                      +=.@@##**=--=+*@@: .:#+-@@@@@@@@@@@@@@@@@@@@@@*@%.   .@@@@@@@@##
    '            :+--:     .--=@@@@@@@@*%@@@@@@@%-.                                    .                  .=%@@#**++*-         %@@@%=*@@@@@@@@@@@@@@@@@#%@*    .%@@@@@@@#
    '           .*=---     ---+@@@@@@@@*@@@@@@@@@-:                                   =--.                    .-#@@%@@*      =@#*. ==-@@@@@@@@@@@@@@@@@@*@@=     =@@@@@@%
    '           -+----.   :---#@@@@@@@@*@@@@@@@@@+-.                                 .+:-.                        .:+     :==.   .+---@@@@@@@@@@@@@@@@@@@#@@:     #@@@@@@
    '          .=-----:  :----@@@=@@@@@#@@@@@@@@@-+-.                                .-.                                        -==+--@@@@@@@@@@@@@@@@@@@%@@@.    ##%@@@@
    '.   .-*%%#*+-----: .----=@@%:%@@@@#@@@@@@@@@--+-            :-                                                           .+=*=--+@@@@@@@@@@@@@@@@@@@@@@@%  . ####@@@
    '@. :@@@@@@@@@@*---.-----*@@*-*@@@@#@@@@@@@@@=--+:             -:                                                        -#+---=*-@@@@@@@@@@@@@@@@@@@@@@@@#...#####:@
    '@@@@@@@@@@@@@@@#--------%@@=-=@@@@#@@@@@@@@@*---*-              =.                                                    .*----=#--=@@@@@@@@@@@@@@@@@@@@@@@@@+ .##### .
    '@@@@@@@@@@@@@@@@--------@@%---*@@@@@@@@@@@@@%----*-               -:                                                 ==---=*=--=#@@@@@@@@@@@@@@@@@@@@@@@@@@* ..:::..
    '@@@@@@@@@@@@@@@@=------+@@+----@@@@@@@@@@@@@@=----+=                ::                                             :+=+++=---+=-*@@@@@@@@@@@@@@@@@@@@@@@@@@@+ ..    
    '@@@@@@@@@@@@@@@@=------%@@=----+@@@@@@@@@@@@@+-----=+.                      ...        .                         .=------=++----%@@@@@@@@@@@@@@@@@@@@@@@@@@@@* .    
    '@@@@@@@@@@@@@@@@+------@@@------%@@@@@@@@@@@@#-------*:                        .......                          =*++++++--------@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@* .   
    '@@@@@%######%@@@@@*---+@@%-------@@@@@@@@@@@@@--------==                                                      -=---------------=@@@@@@@@@@@@@@@@@@@@@@@@=%@@@@@# ...
    '@%#%@@@@@@@%###%@@@*--#@@*-------=@@@@@@@@@@@@=---------+.                                                  ==-----------------*@@@@@@@@@@@@@@@@@@@@@@@@=--%@@@@%...
    '@@@@@@@@@@@@@@%###@@@=%@@=--------+@@@@@@@@@@@*----------==                                             :==--------------------%@@@@@@@@@@@@@@@@@@@@@@@@*---.=@@@%. 
    '@@@@@@@%%%#%%@@@@#@@@@@@@----------*@@@@@@@@@@@+-----------=-                                     .-===------------------------@@@@@@@@@@@@@@@@@@@@@@*@@#----. :#@%.
    '#######%%@@@##@@@@@@@@@@#-----------*@@@@@@@@@@+=*=----------+- .            ..   ...     .:--====-------------::--=+#####----+@@@@@@@@@@@@@@@@@@@@@@-@@%----: . :%@
    '%@@@@@@@@@@@%#%@@@@@@@@@####+=-------+@@@@@@@@@@---*+----------+:          ....:::--======-----------=+#%%%@%%%%###########+--%@@@@@@@@@@@@@@@@@@@@@%-*@%-----..#@@@
    '@@@@@@@@@@@@%#%@@@@@@@@@@###%@@@@%+=--+@@@@@@@@@*----=*+---------===+++======-----------------=+#%@@@@@@@@@%%%%#############*=@@@@@@@@@@@@@@@@@@@@@@%--@@=--+%@@@@%%
    '@@@@@@@@@@@@@##@@@@@@@###@##%@@@@@@@@%#=@@@@@@@@@-------=#=-------------------------------+%@@@@@@@@@@@@%%%%%%%#####%#+=:..  ........  ..-@@@@@@@@@@*--+@#@@@@@#####
    '@@@@@@@@@@@@@##@@@@%##%@@@%##@@@@@@@@@##%#%@@@@@@#---------+---------------------=%@@@@@@@@@@@@@@@@@@@@%%%%%%%%%##*#.            ...........+@@@@@@@+--+@@@@@@######
    '@@@@@@@@@@@@@##@@###@@@@@@@###@@@@@@@%%##@@@@@@@@@@#==------------------=+#%@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%##*******.          ..............:%@@@@=-#@@@@@@@####: 
    '@@@@@@@@@@@@@@@@%%@@@@@@@@@@##@@@@@@##%%##@@@@@@@@@@#%###%@@@@%%*==#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%#**********#=       ...................*@@=%@@@@@@@@%*....
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@###@@@##%@@@##%@@@@@@@####%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%#**********##*.      ...........-=.........=*%@@@@@@@%=.....
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#@###@@@@@%##@@@@@###@@##@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%##########+:        ..............+:.........:%@@#####......
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@###@@##%@@@@##@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%#*****#*           ................-=...........#%###.......
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%@@@@@@@#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%#*****#.          .........=:.........=-..........:#%:.......
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%#********#.          ............=-.........=:.........==....-:..
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%########*#-         ...-=..........:=-........:+:........=:.:===..
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@##########*       ........:+:.........:=:........-=...::..:+-===+:.
    '@@@@@@@%%%%%%%%%%%@@%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%###########:   .............-#:.........=-.::::::::+:::::::-*++=*-:
    '%%%%%%%%%%%%%%%@@%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#%%%%%%@%############---------===+*##%%@@%%%#=:...-=:::::::::+:::::::-*=##-:
    '%%%%%%%%%%%%%@@%%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#%%######%%#######*---=+#%%%%%%%%%%%%%%%%%%%%@#:.-=.::::::::+::::::::*-#=:
    '%%%%%%%%%%%@@%%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#####%%%##%%%%%%%%###%%%%%%%%%%%%%%%%%%%@@@%%%@*-=:::::::::*::::::::##=-
    '%%%%%%%%%@@%%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@##@%##%@%#%%#%%%%%%%%%%%%%%%%%%%%%%%%@@@@@@@@@@@@-.:::::::+::::::::%+=
    '%%%%%%%@@%%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%@@%%%@%%@%%%%%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@%@@*:::::::+-::::::+#=
    '%%%%%@@%%%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%%%%@@%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@%@+--::::=-::::::#=
    '%%%@@%%%%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%%%%%@@%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@%%%%%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%%%%%@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@@@@%%%%%%%%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%%%%@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@@@@@@@%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@+ @@@#+=#--==%+@:%:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@% @@@*-:@+**#@+@*-+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


End Module
