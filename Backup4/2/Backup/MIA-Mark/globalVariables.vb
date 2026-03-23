Imports MySql.Data.MySqlClient
Imports Telerik.Reporting
Module globalVariables

    Public ConnString As String = "server=" & My.Settings.setServerHost & ";" & "uid=" & My.Settings.setDBUID & ";" & "pwd=" & My.Settings.setDBPWD & ";" & "Convert Zero Datetime=True;" & "database=" & My.Settings.setDBName & ";"
    Public ConnStringMH As String = "server=192.168.191.252;uid=feap;pwd=45|iF$;Convert Zero Datetime=True;database=dbManHour;"

    Public currentUser As DataRow = Nothing

    Public myParam As New List(Of MySqlParameter)
    Public myCmd As New MySqlCommand
    Public myAdapter As New MySqlDataAdapter

    Public dtReportData As DataTable

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
End Module
