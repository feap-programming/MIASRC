Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Globalization
Imports FEAPNS.DataAccess

Public Module Zeta

    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PDRD/dbSRC.mdb"
    Public Function SelectDailyReportCount() As Integer
        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCMain"

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using
        Return ReturnDT.Rows.Count
    End Function

    Public Function SelectDailyReportSync(parModel As String, parDate As DateTime, parLine As String, parShift As String) As DataTable

        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCMain where fldModel='" & parModel & "' and fldLine=" & parLine & " and fldShift='" & parShift & "'"

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using

        Dim GetIDByDate = (From t1 In ReturnDT.AsEnumerable
                           Where t1.Field(Of DateTime)("fldDate") = parDate
                           Select New With {
                               .fldID = t1("fldID"),
                               .fldModel = t1("fldModel"),
                               .fldType = t1("fldType"),
                               .fldLine = t1("fldLine"),
                               .fldDate = t1("fldDate"),
                               .fldShift = t1("fldShift")
                            }).ToList

        Return convertToDatatable(GetIDByDate)

    End Function

    Public Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable

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

    Public Function SelectSRCSyncManPower(parID As Integer)

        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCManpower where fldDRID=" & parID & ""

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using

        Return ReturnDT

    End Function

    Public Function SelectSRCSyncHourly(parID As Integer)

        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCHourlyQuality where fldDRID=" & parID & ""

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using

        Return ReturnDT

    End Function

    Public Function SelectSRCSyncAssy(parID As Integer)

        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCAssy where fldDRID=" & parID & ""

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using

        Return ReturnDT

    End Function

    Public Function SelectSRCSyncDefects(parID As Integer)

        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCInProcDefect where fldDRID=" & parID & ""

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using

        Return ReturnDT

    End Function

    Public Function SelectSRCSyncLotNo(parID As Integer)

        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCRMWIP where fldDRID=" & parID & ""

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using

        Return ReturnDT

    End Function

    Public Function SelectSRCSyncOther(parID As Integer)

        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCOtherDetails where fldDRID=" & parID & ""

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using

        Return ReturnDT

    End Function

    Public Function SelectSRCSyncAssyLineEff(parID As Integer)

        Dim ReturnDT As New DataTable


        Using myconnection As New OleDbConnection(constring)

            myconnection.Open()

            Dim sqlQry As String = "select * from tblSRCAssyLineEff where fldDRID=" & parID & ""

            Using cmd As New OleDbCommand(sqlQry, myconnection)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(ReturnDT)
            End Using

            myconnection.Close()

        End Using

        Return ReturnDT

    End Function


    '                              ████                                                                    
    '                          ░░████████                                                                  
    '                        ░░▒▒████████▒▒                                                                
    '                        ░░████████████▓▓▓▓                                                            
    '                        ██████░░██████████████                                                        
    '                        ██████░░░░██████████████          ░░████                                      
    '                      ▓▓██████▓▓▓▓██████████████▓▓▓▓▓▓▓▓░░▓▓████▓▓            ▓▓▓▓▓▓                  
    '                      ████████████████████████████████████████████░░░░░░░░░░░░██████                  
    '                      ██████████████████████████████████████████████████████████████                  
    '                    ░░██████████████████████████████████████████████████████████████                  
    '                  ▒▒██████████████████████████████████████████████████████░░▒▒████████                
    '                ██████████████████████████████████████████████████████████░░░░████████                
    '              ▒▒████████████████████████████████████████▒▒████████████████▒▒░░████████                
    '              ░░░░░░████████████░░████████████████████░░  ██████████████████▓▓████████                
    '                  ▒▒██████████▒▒  ██████████████████▒▒    ████████████████████████████                
    '                ▓▓██████████░░    ██████████░░░░████        ██████████████████████████                
    '            ░░▒▒████████████    ▒▒████████░░                ██████████████████████████                
    '              ████████████░░    ██████░░░░                  ██████████████████████████                
    '            ▒▒██████████▒▒▒▒    ▒▒▒▒▒▒                      ██████████████████████████                
    '          ████████████████  ██                              ██████████████████████████                
    '          ██████████████      ██                  ████      ████████████████████████                  
    '          ██░░██████████      ██                ██    ██      ██  ██████████████████                  
    '          ░░  ██████░░██      ██              ▓▓        ▓▓    ░░  ██████████████████                  
    '          ░░████████    ██  ██                ██        ██        ██████████████████                  
    '          ▓▓████████    ░░▓▓░░                ██        ██        ░░██████████████░░                  
    '          ██████████                            ██    ██            ██████████████                    
    '        ████░░██████░░░░                          ████░░            ██████████████                    
    '        ░░░░  ██████░░                            ░░░░            ▓▓██████████████                    
    '              ████                                ░░░░            ██████████████░░                    
    '              ████                ████                            ██████████████                      
    '              ████                                                ████████████░░                      
    '              ████                                                ██████████░░                        
    '              ░░██▒▒                                            ▒▒██████████                          
    '                ░░██                                            ██████████▒▒                          
    '                    ██                                          ██████████                            
    '                    ████                                      ██████████                              
    '                  ▓▓    ██▓▓▓▓▓▓▓▓                    ▓▓▓▓▓▓▓▓████████  ██                            
    '                ██░░              ████████████████████          ██        ██                          
    '                ██░░░░            ░░██░░░░░░██░░░░░░░░          ░░        ██                          
    '                ██░░░░        ░░░░░░░░▓▓  ▓▓░░░░░░░░░░                    ██                          
    '                ██░░░░      ░░░░░░░░░░██  ██░░░░░░░░░░░░                  ██                          
    '                ██░░░░░░░░░░░░░░░░████▓▓▓▓▓▓██░░░░░░░░░░░░░░░░██░░    ░░░░██                          
    '                  ██░░░░░░░░██████████▓▓▓▓▓▓████████████████░░██░░░░░░░░██                            
    '                  ░░▓▓▓▓▓▓████████████▓▓▓▓▓▓████████████████▓▓░░░░░░░░▒▒░░                            
    '                          ████████████▓▓▓▓▓▓██████████████████░░░░░░░░▒▒                              
    '                          ████████████▓▓▓▓▓▓██████████████████░░░░██▓▓░░                              
    '                  ██████  ██████████▓▓▓▓▓▓▓▓██████████████████████                                    
    '                ██▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓████████████████████████████████████                      
    '                ██▓▓▓▓▓▓████████████▓▓▓▓▓▓▓▓██████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓              
    '              ██▓▓▓▓▓▓▓▓████████████▓▓▓▓▓▓██████████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████        
    '              ██▓▓▓▓▓▓██████████████▓▓▓▓▓▓████████████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████░░      
    '            ████▓▓▓▓▓▓██████████████▓▓▓▓▓▓██████████████████████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒    
    '            ██▓▓▓▓▓▓▓▓██████████████████████████████████████████████████████░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓  
    '          ██▓▓▓▓▓▓▓▓██        ██    ██    ██████████████████████████████████        ░░██▓▓▓▓▓▓▓▓▓▓██  
    '        ██▓▓▓▓▓▓▓▓▓▓██░░░░          ██        ████████████████████████████████          ██▓▓▓▓▓▓▓▓██  
    '        ██▓▓▓▓▓▓▓▓▓▓██░░░░        ████        ████████████████████████████████            ██▓▓▓▓▓▓▓▓██
    '        ██▓▓▓▓▓▓▓▓▓▓██░░░░░░░░░░▒▒▒▒░░        ████████████████████████████████            ██▓▓▓▓▓▓▓▓██
    '        ░░████████████▓▓░░░░░░░░██░░░░░░    ▓▓██████████████████████████████░░            ██▓▓▓▓▓▓▓▓██
    '                        ██░░░░░░░░██░░░░░░░░██████████████████████████████              ██▓▓▓▓▓▓▓▓██  
    '                        ░░██████████░░░░░░░░██████████████████████████▒▒░░          ░░██▓▓▓▓▓▓▓▓▓▓██  
    '                          ░░░░░░    ▓▓▓▓▓▓▓▓░░██████████░░░░░░░░░░░░  ░░            ▓▓▓▓▓▓▓▓▓▓▓▓██░░  
    '                                                ▓▓▓▓▓▓                              ██▓▓▓▓▓▓▓▓▓▓      
    '                                                                                    ▒▒██████▒▒        
    '░░░░    ░░░░  ░░      ░░░░                                                          ░░▓▓▓▓▓▓          



End Module
