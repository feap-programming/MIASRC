Imports MySql.Data.MySqlClient
Imports Telerik.Reporting
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Module globalVariables

    Public ConnString As String = "server=192.168.191.22;uid=feap;pwd=45|iF$;Convert Zero Datetime=True;database=dbMIA"
    'Public ConnString As String = "server=localhost;uid=root;pwd=password;Convert Zero Datetime=True;database=dbmia"
    Public ConnStringMH As String = "server=192.168.191.252;uid=feap;pwd=45|iF$;Convert Zero Datetime=True;database=dbManHour;"

    Public Sapsap As String = "Data Source=feap-sapdb;Initial Catalog=Furukawa_Live2020;User ID=sa;Password=S@Pbusiness1; Connection Timeout=500;"
    Public myParamSAP As New List(Of SqlParameter)
    Public myCmdSAP As New SqlCommand
    Public aedTypeSAP As Integer = 0
    Public myAdapterSAP As New SqlDataAdapter

    Public currentUser As DataRow = Nothing

    Public myParam As New List(Of MySqlParameter)
    Public myCmd As New MySqlCommand
    Public myAdapter As New MySqlDataAdapter

    Public dtReportData As DataTable
    Public rgvAssyRowIndex As Integer
    Public currentRgv As RadGridView
    Public delay As Integer = 50

    Public publicText As String

    Public illegalChar As String = "'""`^"

    Public aedType As Integer = 0

    Public reportType As Integer

    Public confirmCode As Boolean = False

    Public errorMessage As String

    Public dtPickedData As New DataTable

    Public currentSelectedId As Integer = Nothing

    Public myReportParam As New List(Of Parameter)

    Public dtLayerSRC As New DataTable
    Public dtLayer1 As New DataTable
    Public dtLayer2 As New DataTable
    Public dtLayer3 As New DataTable
    Public dtLayer4 As New DataTable
    Public dtLayer5 As New DataTable
    Public dtLayer6 As New DataTable
    Public dtLayer7 As New DataTable
    Public dtLayer8 As New DataTable

    '---------BSS Production output group
    Public MainID As String
    Public POSPExist As String
    Public BSSProdOutputAction As String
    Public FGNoSelected As String
    Public ShiftSelect As String
    Public BSSSampleCategory As String
    Public BSSItemCode As String
    Public BSSMainProcess As String
    Public BSSAProcess As String
    Public BFID As String
    Public BSSItemSub As String

    '---------SRC Daily Report
    Public DailyRepID As Integer
    Public ModelLine As Integer
    Public ModelLineWelding As Integer
    Public ReworkID As Integer
    Public ModelCode As String
    Public DailyRepShift As String
    Public TrialDate As String
    Public DailyRepEditTimePart As String
    Public DailyRepNewOPTime As Integer
    Public AssyDownTimeID As Integer
    Public AssyDownTimeModel As String
    Public AssyDownTimeLine As String
    Public AssyDownTimeDate As Date
    Public AssyDownTimeDateString As String
    Public AssyDownTimeShift As String
    Public SRCReportType As String
    Public SRCReportSeparate As String
    Public DailyReportModel As String
    Public DailyReportDate As Date
    Public DailyReportModelZwei As String
    Public DailyReportDateZwei As String
    Public TestDT As DataTable
    Public FWGroup As Integer = 0
    Public SRCSyncModel As String
    Public SRCSyncDate As Date
    Public SRCSyncShift As String
    Public SRCSyncLine As Integer
    Public SRCSyncID As Integer

    Public SRCAddedBy As String
    Public assyStatus As String
    Public downtimeReportType As String
    Public dateFrom As Date
    Public dateTo As Date

    Public BlankDTSRC As DataTable = New DataTable
    Public BlankDTSRC2 As DataTable = New DataTable
    Public BlankDTSRC3 As DataTable = New DataTable
    Public BlankDTSRC4 As DataTable = New DataTable
    Public BlankDTSRC5 As DataTable = New DataTable
    Public BlankDTSRC6 As DataTable = New DataTable
    Public BlankDTSRC7 As DataTable = New DataTable
    Public BlankDTSRC8 As DataTable = New DataTable
    Public BlankDTSRC9 As DataTable = New DataTable
    Public BlankDTSRC10 As DataTable = New DataTable
    Public BlankDTSRC11 As DataTable = New DataTable
    Public BlankDTSRC12 As DataTable = New DataTable
    Public BlankDTSRC13 As DataTable = New DataTable
    Public BlankDTSRC14 As DataTable = New DataTable
    Public BlankDTSRC15 As DataTable = New DataTable
    Public BlankDTSRC16 As DataTable = New DataTable


    '---------Down Time Report
    Public DowntimeType As String

    '--------- DailyReport Params<Start>
    '--------- Welding<Start>
    Public parDRID As Integer
    Public parType As String
    Public parModel As String
    Public parLine As Integer
    Public parDate As Date
    Public parLotNo As String
    Public parShift As String
    Public parGroup As String
    Public parTeamLeader As String
    Public parPartName1 As String
    Public parPartName2 As String
    Public parWeldingNo1 As String
    Public parWeldingNo2 As String
    Public parLot1 As String
    Public parLot2 As String
    Public parLot3 As String
    Public parLot4 As String
    Public parLot5 As String
    Public parGoodQty1 As Integer
    Public parGoodQty2 As Integer
    '--------- Welding<End>
    '--------- DailyReport Params<End>

End Module
