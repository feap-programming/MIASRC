Imports Telerik.WinControls.UI
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class KillSwitch

    Shared Function addBSSAssyProcess(ByVal mainId As Integer, ByVal processCode As String) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblProdOutputSubProcess (fldMainId, fldProcessCode) VALUES (@fldMainId, @fldProcessCode)"
            myCmd.Parameters.AddWithValue("@fldMainId", mainId)
            myCmd.Parameters.AddWithValue("@fldProcessCode", processCode)

            myCmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.Show(ex.Message & "(Function Error)", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success
    End Function

    Shared Function addLinePartition(ByVal mainId As Integer, ByVal dateFrom As DateTime, ByVal dateTo As DateTime) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblProdOutputPartition (fldMainId, fldFrom, fldTo) VALUES (@fldMainId, @fldFrom, @fldTo)"
            myCmd.Parameters.AddWithValue("@fldMainId", mainId)
            myCmd.Parameters.AddWithValue("@fldFrom", dateFrom)
            myCmd.Parameters.AddWithValue("@fldTo", dateTo)

            myCmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.Show(ex.Message & "(Function Error)", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success
    End Function

    Shared Function addProdOutputGroup(ByVal title As String, ByVal recDate As Date, ByVal subLeader As String, ByVal teamLeader As String, ByVal whseCode As String, ByVal line As String, ByVal PartName As String, ByVal ItemCode As String, ByVal Shift As String, ByVal MaterialHandler As String) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblProductionOutputGroup (fldTitle, fldDate, fldSubLeader, fldTeamLeader, fldWhseCode, fldLine, fldDateAdded, fldAddedBy, fldPartName, fldItemCode, fldShift, fldMaterialHandler) VALUES (@fldTitle, @fldDate, @fldSubLeader, @fldTeamLeader, @fldWhseCode, @fldLine, @fldDateAdded, @fldAddedBy, @fldPartName, @fldItemCode, @fldShift, @fldMaterialHandler)"
            myCmd.Parameters.AddWithValue("@fldTitle", title)
            myCmd.Parameters.AddWithValue("@fldDate", recDate)

            If subLeader.TrimStart.TrimEnd = String.Empty Then
                myCmd.Parameters.AddWithValue("@fldSubLeader", DBNull.Value)
            Else
                myCmd.Parameters.AddWithValue("@fldSubLeader", subLeader.TrimStart.TrimEnd)
            End If

            If teamLeader.TrimStart.TrimEnd = String.Empty Then
                myCmd.Parameters.AddWithValue("@fldTeamLeader", DBNull.Value)
            Else
                myCmd.Parameters.AddWithValue("@fldTeamLeader", teamLeader.TrimStart.TrimEnd)
            End If

            myCmd.Parameters.AddWithValue("@fldWhseCode", whseCode)
            myCmd.Parameters.AddWithValue("@fldLine", line)
            myCmd.Parameters.AddWithValue("@fldDateAdded", Today)
            myCmd.Parameters.AddWithValue("@fldAddedBy", currentUser.Item("fldUsername"))
            myCmd.Parameters.AddWithValue("@fldPartName", PartName)
            myCmd.Parameters.AddWithValue("@fldItemCode", ItemCode)
            myCmd.Parameters.AddWithValue("@fldShift", Shift)
            myCmd.Parameters.AddWithValue("@fldMaterialHandler", MaterialHandler)

            myCmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.Show(ex.Message & "(Function Error)", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success
    End Function

    Shared Function deleteProdOutputGroup(ByVal parIdArray As String) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "DELETE FROM tblProductionOutputGroup WHERE fldId IN
                                (
                                SELECT fldId 
                                from
	                                (SELECT fldId FROM tblProductionOutputGroup WHERE FIND_IN_SET(fldId, @parIdArray) ) X
                                )"

            myCmd.Parameters.AddWithValue("@parIdArray", parIdArray)

            myCmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.Show(ex.Message & "(Function Error)", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success
    End Function

    'Shared Function addProdOutputGroupProc(ByVal fldMainId As Integer, ByVal fldProcessCode As String, ByVal fldNoOfPersons As Integer,
    '                                       ByVal fldAOprTime As Decimal, ByVal fldStartUp As Decimal,
    '                                       ByVal fldPlanDowntime As Decimal, ByVal fldUnPlanDowntime As Decimal, ByVal fldCustomer As String,
    '                                       ByVal fldFGNo As String, ByVal fldLotNo As String) As Boolean
    '    Dim success As Boolean = True
    '    Dim myCmd As New MySqlCommand
    '    Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

    '    Try
    '        conn.Open()
    '        myCmd.Connection = conn

    '        myCmd.CommandText = "call SP_InsertProdOutputSubProcess(@fldMainId, @fldProcessCode, @fldNoOfPersons, @fldAOprTime, @fldStartUp,
    '                                                                @fldPlanDowntime, @fldUnPlanDowntime, @fldCustomer, @fldFGNo, @fldLotNo, 
    '                                                                @fldDateAdded, @fldAddedBy)"

    '        myCmd.Parameters.AddWithValue("@MainId", fldMainId)
    '        myCmd.Parameters.AddWithValue("@ProcessCode", fldProcessCode)
    '        myCmd.Parameters.AddWithValue("@NoOfPersons", fldNoOfPersons)
    '        myCmd.Parameters.AddWithValue("@AOprTime", fldAOprTime)
    '        myCmd.Parameters.AddWithValue("@StartUp", fldStartUp)
    '        myCmd.Parameters.AddWithValue("@PlanDowntime", fldPlanDowntime)
    '        myCmd.Parameters.AddWithValue("@UnPlanDowntime", fldUnPlanDowntime)

    '        If fldCustomer = String.Empty Then
    '            myCmd.Parameters.AddWithValue("@Customer", DBNull.Value)
    '        Else
    '            myCmd.Parameters.AddWithValue("@Customer", fldCustomer)
    '        End If

    '        If fldFGNo = String.Empty Then
    '            myCmd.Parameters.AddWithValue("@FGNo", DBNull.Value)
    '        Else
    '            myCmd.Parameters.AddWithValue("@FGNo", fldFGNo)
    '        End If

    '        If fldLotNo = String.Empty Then
    '            myCmd.Parameters.AddWithValue("@LotNo", DBNull.Value)
    '        Else
    '            myCmd.Parameters.AddWithValue("@LotNo", fldLotNo)
    '        End If

    '        myCmd.Parameters.AddWithValue("@DateAdded", Now)
    '        myCmd.Parameters.AddWithValue("@AddedBy", currentUser.Item("fldUsername"))

    '        myCmd.ExecuteNonQuery()

    '        conn.Close()
    '    Catch ex As Exception
    '        success = False
    '        RadMessageBox.Show(ex.Message & "(Function Error)", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
    '    End Try

    '    Return success
    'End Function

End Class
