Imports MySql.Data.MySqlClient
Public Class BulletForMyValentine

    Shared Function checkIfHaveChild(ByVal itemCode As String) As Boolean

        Dim result As Boolean = False

        Dim conn As New MySqlConnection(ConnString)

        Dim myCmd As New MySqlCommand("SP_SelectItemMasterChild", conn)

        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.Parameters.AddWithValue("parItemCode", itemCode)
        myCmd.Parameters.AddWithValue("result", result)
        myCmd.Parameters("result").Direction = ParameterDirection.Output

        conn.Open()

        myCmd.ExecuteScalar()
        result = myCmd.Parameters("result").Value

        Return result
    End Function

    Shared Function checkItemCodeIfExist(ByVal itemCode As String) As Boolean

        Slipknot.addParameter("parItemCode", itemCode)
        Dim check As DataTable = Slipknot.dbSelect("SP_SelectCodeIfExists")

        If check.Rows.Count > 0 Then
            If Convert.ToString(check.Rows(0).Item("stat")) = "not exist" Then

                Return False
                Exit Function
            End If
        End If

        Return True
    End Function

    Shared Function checkLineIfExists(ByVal lineName As String) As String

        Dim check As DataRow = Slipknot.rowSelectManual("SELECT fldCode FROM tblLines WHERE fldLineName = '" & lineName & "' ")

        If check IsNot Nothing Then

            Return Convert.ToString(check.Item("fldCode"))

            Exit Function
        End If

        Return Nothing
    End Function

    Shared Function validateCopyChild(ByVal parentCode As String, ByVal childCode As String) As Boolean

        If parentCode = childCode Then
            publicText = "Parent part no. cannot be equal to child part no"

            Return False
            Exit Function
        End If

        Dim check As DataTable

        Slipknot.addParameter("parItemCode", childCode)
        check = Slipknot.dbSelect("SP_SelectCodeIfExists")

        If check.Rows.Count > 0 Then
            If Convert.ToString(check.Rows(0).Item("stat")) = "not exist" Then

                publicText = "Child part no. not found"

                Return False
                Exit Function
            End If
        End If

        Return True
    End Function

    Shared Function validateItemMasterData(ByVal categoryCode As String, ByVal uom As String, ByVal supCode As String) As Boolean

        Dim checkCategory As DataRow = Slipknot.rowSelectManual("SELECT fldCategory FROM tblCategory WHERE fldCategory = '" & categoryCode & "' LIMIT 1 ")

        If checkCategory IsNot Nothing Then
            errorMessage = "Category " & categoryCode & " not found in category list"

            Return False
            Exit Function
        End If

        Dim checkUOM As DataRow = Slipknot.rowSelectManual("SELECT fldUOM FROM tblUOM WHERE fldUOM = '" & uom & "' LIMIT 1")

        If checkUOM IsNot Nothing Then
            errorMessage = "UOM " & uom & " not found in UOM list"

            Return False
            Exit Function
        End If

        Dim checkMakerCode As DataRow = Slipknot.rowSelectManual("SELECT fldMakerCode  ")

        Return True
    End Function

    Shared Function isRW(ByVal modelName As String) As Boolean

        Dim check As String = Slipknot.checkPermission(frmBase.leUsername.Text, modelName)

        If check <> "RW" Then
            Return False
        End If

        Return True
    End Function

End Class
