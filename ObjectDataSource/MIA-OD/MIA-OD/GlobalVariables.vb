Imports MySql.Data.MySqlClient

Module GlobalVariables

    Public ConnString As String = "server=192.168.191.22;uid=feap;pwd=45|iF$;Convert Zero Datetime=True;database=dbMIA;"

    Public myParam As New List(Of MySqlParameter)
    Public myCmd As New MySqlCommand
    Public myAdapter As New MySqlDataAdapter

End Module
