Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Functions

    Shared Function dbSelect(ByVal query As String) As DataTable

        Dim myData As DataTable = Nothing

        Dim myConn As New MySqlConnection(ConnString)

        Try
            myConn.Open()

            myCmd = New MySqlCommand(query, myConn)
            myCmd.CommandType = CommandType.StoredProcedure
            myCmd.CommandTimeout = 0
            myParam.ForEach(Function(p) myCmd.Parameters.Add(p))

            myData = New DataTable
            myAdapter = New MySqlDataAdapter(myCmd)
            myAdapter.Fill(myData)

            myParam.Clear()

            myConn.Close()
        Catch ex As Exception
            myConn.Close()
            myParam.Clear()

            MsgBox(ex.Message)
        End Try

        myConn = Nothing

        Return myData
    End Function

    Shared Function dbSelectManual(ByVal mySQLcommand As String) As DataTable
        Dim myData As New DataTable
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.CommandText = mySQLcommand
            myCmd.Connection = conn

            myAdapter.SelectCommand = myCmd
            myCmd.CommandTimeout = 0
            myAdapter.Fill(myData)

        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)
        End Try

        conn.Close()
        conn = Nothing

        Return myData
    End Function

    Shared Function rowSelectManual(ByVal SQLcommand As String) As DataRow

        rowSelectManual = Nothing

        Dim myData As New DataTable
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.CommandText = SQLcommand
            myCmd.Connection = conn

            myAdapter.SelectCommand = myCmd
            myCmd.CommandTimeout = 0
            myAdapter.Fill(myData)
            If myData.Rows.Count > 0 Then
                rowSelectManual = myData.Rows(0)
            Else
                rowSelectManual = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
        conn = Nothing

        Return rowSelectManual
    End Function

    Shared Function dbAED(ByVal query As String) As Boolean

        Dim myConn As New MySqlConnection(ConnString)

        Try
            myConn.Open()

            myCmd = New MySqlCommand(query, myConn)
            myCmd.CommandType = CommandType.StoredProcedure
            myParam.ForEach(Function(p) myCmd.Parameters.Add(p))
            myCmd.ExecuteNonQuery()
            myParam.Clear()

            myConn.Close()

        Catch ex As Exception
            myConn.Close()
            myParam.Clear()

            MsgBox(ex.Message)

            Return False
        End Try

        Return True
    End Function

    Public Shared Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
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

    Shared Function addParameter(ByVal name As String, ByVal value As Object) As Boolean
        Dim newParameter As New MySqlParameter(name, value)
        myParam.Add(newParameter)

        Return True
    End Function

End Class
