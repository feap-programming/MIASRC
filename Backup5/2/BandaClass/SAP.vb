Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data

Public Class SAP

    Shared Function addParameter(ByVal name As String, ByVal value As Object) As Boolean
        Dim newParameter As New SqlParameter(name, value)
        myParamSAP.Add(newParameter)

        Return True
    End Function
    Shared Function dbAED(ByVal query As String) As Boolean

        Dim myConn As New SqlConnection(Sapsap)

        Try
            myConn.Open()

            myCmdSAP = New SqlCommand(query, myConn)
            myCmdSAP.CommandType = CommandType.StoredProcedure
            myParamSAP.ForEach(Function(p) myCmd.Parameters.Add(p))
            myCmdSAP.ExecuteNonQuery()
            myParamSAP.Clear()

            myConn.Close()

        Catch ex As Exception
            myConn.Close()
            myParamSAP.Clear()

            If aedTypeSAP = 0 Then
                RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Else
                errorMessage = ex.Message
            End If

            Return False
        End Try

        Return True
    End Function

    Shared Function dbSelect(ByVal query As String) As DataTable

        Dim myData As DataTable = Nothing

        Dim myConn As New SqlConnection(Sapsap)

        Try
            myConn.Open()

            myCmdSAP = New SqlCommand(query, myConn)
            myCmdSAP.CommandType = CommandType.StoredProcedure
            myCmdSAP.CommandTimeout = 0
            myParamSAP.ForEach(Function(p) myCmdSAP.Parameters.Add(p))

            myData = New DataTable
            myAdapterSAP = New SqlDataAdapter(myCmdSAP)
            myAdapterSAP.Fill(myData)

            myParamSAP.Clear()

            myConn.Close()
        Catch ex As Exception
            myConn.Close()
            myParamSAP.Clear()

            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End Try

        myConn = Nothing

        Return myData
    End Function


End Class
