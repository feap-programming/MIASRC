Imports MySql.Data.MySqlClient

Public Class Kurumi
    Public Class DB
        Private ReadOnly server As String
        Private ReadOnly database As String
        Private ReadOnly userID As String
        Private ReadOnly password As String
        Private ReadOnly mySqlParam As List(Of MySqlParameter)
        Public Property Connection As MySqlConnection

        Public Sub New(ByVal server As String, ByVal database As String, ByVal userID As String, ByVal password As String)

            Me.server = server
            Me.database = database
            Me.userID = userID
            Me.password = password
            Me.mySqlParam = New List(Of MySqlParameter)()
            Me.Connection = Me.ConnectionString()

        End Sub

        Private Function ConnectionString() As MySqlConnection
            Dim connection As MySqlConnection = New MySqlConnection With {
                .ConnectionString = String.Format("server={0}; Port=3306; database={1}; user id={2}; pwd={3}; Convert Zero Datetime=True", Me.server, Me.database, Me.userID, Me.password)
            }
            Return connection
        End Function

        Public Function MyQuery(ByVal query As String) As DataTable
            Dim myDT As DataTable = New DataTable()
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter()
            Dim myCmd As MySqlCommand = New MySqlCommand(query, Me.Connection)
            Me.Connection.Open()
            myDA.SelectCommand = myCmd
            myDA.Fill(myDT)
            Me.Connection.Close()
            Me.mySqlParam.Clear()
            Return myDT
        End Function

        Public Function SPSelect(ByVal query As String) As DataTable
            Dim myDT As DataTable = New DataTable()
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter()
            Dim myCmd As MySqlCommand = New MySqlCommand(query, Me.Connection) With {
                .CommandType = CommandType.StoredProcedure
            }
            Me.mySqlParam.ForEach(Sub(p) myCmd.Parameters.Add(p))
            Me.Connection.Open()
            myDA.SelectCommand = myCmd
            myDA.Fill(myDT)
            Me.Connection.Close()
            Me.mySqlParam.Clear()
            Return myDT
        End Function

        Public Sub SPADE(ByVal query As String)
            Dim myCmd As MySqlCommand = New MySqlCommand(query, Me.Connection) With {
                .CommandType = CommandType.StoredProcedure
            }
            Me.mySqlParam.ForEach(Sub(p) myCmd.Parameters.Add(p))
            Me.Connection.Open()
            myCmd.ExecuteNonQuery()
            Me.Connection.Close()
            Me.mySqlParam.Clear()
        End Sub

        Public Function SPOutput(ByVal query As String, ParamArray paramName As String()) As IDictionary(Of String, Object)
            Dim paramValue As IDictionary(Of String, Object) = New Dictionary(Of String, Object)()
            Dim myCmd As MySqlCommand = New MySqlCommand(query, Me.Connection) With {
                .CommandType = CommandType.StoredProcedure
            }
            Me.mySqlParam.ForEach(Sub(p) myCmd.Parameters.Add(p))

            For i As Integer = 0 To paramName.Length - 1
                myCmd.Parameters(paramName(i)).Direction = ParameterDirection.Output
            Next

            Me.Connection.Open()
            'myCmd.ExecuteScalar()


            For i As Integer = 0 To paramName.Length - 1
                paramValue(paramName(i)) = myCmd.Parameters(paramName(i)).Value
            Next

            Me.Connection.Close()
            Me.mySqlParam.Clear()
            Return paramValue
        End Function

        Public Sub AddMySqlParameters(ByVal name As String, ByVal value As Object)
            Dim newParameter As MySqlParameter = New MySqlParameter(name, value)
            Me.mySqlParam.Add(newParameter)
        End Sub

    End Class
End Class
