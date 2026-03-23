Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Slipknot

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

            If aedType = 0 Then
                RadMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Else
                errorMessage = ex.Message
            End If

            Return False
        End Try

        Return True
    End Function

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

            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

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
            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
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
            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try

        conn.Close()
        conn = Nothing

        Return rowSelectManual
    End Function

    Shared Function dbSelectManualMH(ByVal mySQLcommand As String) As DataTable
        Dim myData As New DataTable
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnStringMH)

        Try
            conn.Open()
            myCmd.CommandText = mySQLcommand
            myCmd.Connection = conn

            myAdapter.SelectCommand = myCmd
            myCmd.CommandTimeout = 0
            myAdapter.Fill(myData)

        Catch ex As System.Data.SqlClient.SqlException
            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try

        conn.Close()
        conn = Nothing

        Return myData
    End Function

    Shared Function rowSelectManualMH(ByVal SQLcommand As String) As DataRow

        rowSelectManualMH = Nothing

        Dim myData As New DataTable
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnStringMH)

        Try
            conn.Open()
            myCmd.CommandText = SQLcommand
            myCmd.Connection = conn

            myAdapter.SelectCommand = myCmd
            myCmd.CommandTimeout = 0
            myAdapter.Fill(myData)
            If myData.Rows.Count > 0 Then
                rowSelectManualMH = myData.Rows(0)
            Else
                rowSelectManualMH = Nothing
            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try

        conn.Close()
        conn = Nothing

        Return rowSelectManualMH
    End Function

    Shared Function IsFormOpen(ByVal frm As Form) As Boolean
        If System.Windows.Forms.Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function addParameter(ByVal name As String, ByVal value As Object) As Boolean
        Dim newParameter As New MySqlParameter(name, value)
        myParam.Add(newParameter)

        Return True
    End Function

    Shared Function addReportParameter(ByVal name As String, ByVal value As Object) As Boolean
        Dim newParameter As New Telerik.Reporting.Parameter(name, value)
        myReportParam.Add(newParameter)

        Return True
    End Function

    Shared Function CopyDataTable(ByVal table As DataTable) As DataTable
        ' Create an object variable for the copy. 
        Dim temptable As DataTable
        temptable = table.Copy()

        ' Insert code to work with the copy. 
        Return temptable
    End Function

    Shared Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""
        Dim b As Byte

        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Shared Function createPassword() As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789?!@#$%^&*()_+"
        Dim r As New Random
        Const passwordLength As Integer = 10
        Dim passwordChars() As Char = New Char(passwordLength - 1) {}
        Dim charIndex As Integer

        For i As Integer = 0 To passwordLength - 1
            charIndex = r.Next(s.Length)
            passwordChars(i) = s(charIndex)
        Next

        Dim password As New String(passwordChars)

        Return password
    End Function

    Shared Function passwordMeter(ByVal pwd As String,
     Optional ByVal minLength As Integer = 10,
     Optional ByVal numUpper As Integer = 1,
     Optional ByVal numLower As Integer = 1,
     Optional ByVal numNumbers As Integer = 1,
     Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    Public Shared Sub changeTheme(ByVal frm As RadForm)

        frm.ThemeName = My.Settings.setTheme

        For Each con As Control In frm.Controls

            If TypeOf con Is RadGridView Then
                CType(con, RadGridView).ThemeName = My.Settings.setTheme
            End If

            If TypeOf con Is RadTextBox Then
                CType(con, RadTextBox).ElementTree.EnableApplicationThemeName = False
                CType(con, RadTextBox).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadLabel Then
                CType(con, RadLabel).ElementTree.EnableApplicationThemeName = False
                CType(con, RadLabel).ThemeName = "Reset"
            End If

            If TypeOf con Is RadButton Then
                CType(con, RadButton).ElementTree.EnableApplicationThemeName = False
                CType(con, RadButton).ThemeName = "CrystalDark"  '"MaterialTeal" '"Office2010Black"
            End If

            If TypeOf con Is RadCommandBar Then
                If CType(con, RadCommandBar).Name <> "baseCommandBar" Then
                    CType(con, RadCommandBar).ElementTree.EnableApplicationThemeName = False
                    CType(con, RadCommandBar).ThemeName = "Office2010Black"
                End If
            End If

            If TypeOf con Is RadStatusStrip Then
                CType(con, RadStatusStrip).ElementTree.EnableApplicationThemeName = False
                CType(con, RadStatusStrip).ThemeName = My.Settings.setTheme '"Office2010Black" '
            End If

            If TypeOf con Is RadMultiColumnComboBox Then
                CType(con, RadMultiColumnComboBox).ElementTree.EnableApplicationThemeName = False
                CType(con, RadMultiColumnComboBox).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadDropDownList Then
                CType(con, RadDropDownList).ElementTree.EnableApplicationThemeName = False
                CType(con, RadDropDownList).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadSpinEditor Then
                CType(con, RadSpinEditor).ElementTree.EnableApplicationThemeName = False
                CType(con, RadSpinEditor).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadDateTimePicker Then
                CType(con, RadDateTimePicker).ElementTree.EnableApplicationThemeName = False
                CType(con, RadDateTimePicker).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadCheckBox Then
                CType(con, RadCheckBox).ElementTree.EnableApplicationThemeName = False
                CType(con, RadCheckBox).ThemeName = "MaterialTeal"
            End If

            If TypeOf con Is RadDock Then
                CType(con, RadDock).ElementTree.EnableApplicationThemeName = False
                CType(con, RadDock).ThemeName = "Crystal"
            End If

            If TypeOf con Is RadGroupBox Then

                CType(con, RadGroupBox).ElementTree.EnableApplicationThemeName = False
                CType(con, RadGroupBox).ThemeName = "Office2007Black"

                For Each con1 As Control In con.Controls

                    If TypeOf con1 Is RadTextBox Then
                        CType(con1, RadTextBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadTextBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadMultiColumnComboBox Then
                        CType(con1, RadMultiColumnComboBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadMultiColumnComboBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadDropDownList Then
                        CType(con1, RadDropDownList).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadDropDownList).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadSpinEditor Then
                        CType(con1, RadSpinEditor).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadSpinEditor).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadDateTimePicker Then
                        CType(con1, RadDateTimePicker).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadDateTimePicker).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadButton Then
                        CType(con1, RadButton).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadButton).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadCheckBox Then
                        CType(con1, RadCheckBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadCheckBox).ThemeName = "MaterialTeal"

                        If My.Settings.setTheme = "CrystalDark" Then
                            CType(con1, RadCheckBox).ForeColor = Color.White
                        Else
                            CType(con1, RadCheckBox).ForeColor = Color.Black
                        End If


                    End If

                    If TypeOf con1 Is RadLabel Then
                        CType(con1, RadLabel).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadLabel).ThemeName = "Reset"

                        'If My.Settings.setTheme = "CrystalDark" Then
                        '    CType(con1, RadLabel).ForeColor = Color.White
                        'Else
                        '    CType(con1, RadLabel).ForeColor = Color.Black
                        'End If

                    End If
                Next

            End If

            If TypeOf con Is RadPanel Then
                CType(con, RadPanel).ElementTree.EnableApplicationThemeName = False
                CType(con, RadPanel).ThemeName = "Office2010Black"

                For Each con1 As Control In con.Controls

                    If TypeOf con1 Is RadGridView Then
                        CType(con1, RadGridView).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadGridView).ThemeName = My.Settings.setTheme
                    End If

                    If TypeOf con1 Is RadStatusStrip Then
                        CType(con1, RadStatusStrip).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadStatusStrip).ThemeName = My.Settings.setTheme
                    End If

                    If TypeOf con1 Is RadTextBox Then
                        CType(con1, RadTextBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadTextBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadAutoCompleteBox Then
                        CType(con1, RadAutoCompleteBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadAutoCompleteBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadLabel Then
                        CType(con1, RadLabel).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadLabel).ThemeName = "Reset"
                    End If

                    If TypeOf con1 Is RadButton Then
                        CType(con1, RadButton).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadButton).ThemeName = "Office2010Black"
                    End If

                    If TypeOf con1 Is RadMultiColumnComboBox Then
                        CType(con1, RadMultiColumnComboBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadMultiColumnComboBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadDropDownList Then
                        CType(con1, RadDropDownList).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadDropDownList).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadSpinEditor Then
                        CType(con1, RadSpinEditor).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadSpinEditor).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadDateTimePicker Then
                        CType(con1, RadDateTimePicker).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadDateTimePicker).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadCheckBox Then
                        CType(con1, RadCheckBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadCheckBox).ThemeName = "MaterialTeal"
                    End If

                Next

            End If


            If TypeOf con Is RadPageView Then
                CType(con, RadPageView).ElementTree.EnableApplicationThemeName = False
                CType(con, RadPageView).ThemeName = "MaterialTeal"

                For Each pg As RadPageViewPage In CType(con, RadPageView).Pages

                    For Each xcon As Control In pg.Controls

                        If TypeOf xcon Is RadCommandBar Then
                            CType(xcon, RadCommandBar).ThemeName = "Office2010Black"
                        End If

                        If TypeOf xcon Is RadGridView Then
                            CType(xcon, RadGridView).ThemeName = My.Settings.setTheme
                        End If

                        If TypeOf xcon Is RadStatusStrip Then
                            CType(xcon, RadStatusStrip).ThemeName = "Office2010Black"
                        End If

                        If TypeOf xcon Is RadCheckBox Then
                            CType(xcon, RadCheckBox).ThemeName = "MaterialTeal"
                        End If

                        If TypeOf xcon Is RadDropDownList Then
                            CType(xcon, RadDropDownList).ThemeName = "Office2007Black"
                        End If

                        If TypeOf xcon Is RadGroupBox Then
                            CType(xcon, RadGroupBox).ThemeName = "MaterialTeal"

                            For Each ycon As Control In xcon.Controls

                                If TypeOf ycon Is RadCheckBox Then
                                    CType(ycon, RadCheckBox).ThemeName = "MaterialTeal"
                                End If

                                If TypeOf ycon Is RadDropDownList Then
                                    CType(ycon, RadDropDownList).ThemeName = "Office2007Black"
                                End If

                            Next

                        End If

                    Next

                Next

            End If

        Next

    End Sub

    Public Shared Sub changeThemeUC(ByVal frm As UserControl)

        For Each con As Control In frm.Controls

            If TypeOf con Is RadGridView Then
                CType(con, RadGridView).ThemeName = My.Settings.setTheme
            End If

            If TypeOf con Is RadTextBox Then
                CType(con, RadTextBox).ElementTree.EnableApplicationThemeName = False
                CType(con, RadTextBox).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadLabel Then
                CType(con, RadLabel).ElementTree.EnableApplicationThemeName = False
                CType(con, RadLabel).ThemeName = "Reset"
            End If

            If TypeOf con Is RadButton Then
                CType(con, RadButton).ElementTree.EnableApplicationThemeName = False
                CType(con, RadButton).ThemeName = "CrystalDark"  '"MaterialTeal" '"Office2010Black"
            End If

            If TypeOf con Is RadCommandBar Then
                If CType(con, RadCommandBar).Name <> "baseCommandBar" Then
                    CType(con, RadCommandBar).ElementTree.EnableApplicationThemeName = False
                    CType(con, RadCommandBar).ThemeName = "Office2010Black"
                End If
            End If

            If TypeOf con Is RadStatusStrip Then
                CType(con, RadStatusStrip).ElementTree.EnableApplicationThemeName = False
                CType(con, RadStatusStrip).ThemeName = My.Settings.setTheme '"Office2010Black" '
            End If

            If TypeOf con Is RadMultiColumnComboBox Then
                CType(con, RadMultiColumnComboBox).ElementTree.EnableApplicationThemeName = False
                CType(con, RadMultiColumnComboBox).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadDropDownList Then
                CType(con, RadDropDownList).ElementTree.EnableApplicationThemeName = False
                CType(con, RadDropDownList).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadSpinEditor Then
                CType(con, RadSpinEditor).ElementTree.EnableApplicationThemeName = False
                CType(con, RadSpinEditor).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadDateTimePicker Then
                CType(con, RadDateTimePicker).ElementTree.EnableApplicationThemeName = False
                CType(con, RadDateTimePicker).ThemeName = "Office2007Black"
            End If

            If TypeOf con Is RadCheckBox Then
                CType(con, RadCheckBox).ElementTree.EnableApplicationThemeName = False
                CType(con, RadCheckBox).ThemeName = "MaterialTeal"
            End If

            If TypeOf con Is RadGroupBox Then

                CType(con, RadGroupBox).ElementTree.EnableApplicationThemeName = False
                CType(con, RadGroupBox).ThemeName = "Office2007Black"

                For Each con1 As Control In con.Controls
                    If TypeOf con1 Is RadTextBox Then
                        CType(con1, RadTextBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadTextBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadMultiColumnComboBox Then
                        CType(con1, RadMultiColumnComboBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadMultiColumnComboBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadDropDownList Then
                        CType(con1, RadDropDownList).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadDropDownList).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadSpinEditor Then
                        CType(con1, RadSpinEditor).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadSpinEditor).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadDateTimePicker Then
                        CType(con1, RadDateTimePicker).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadDateTimePicker).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadButton Then
                        CType(con1, RadButton).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadButton).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadCheckBox Then
                        CType(con1, RadCheckBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadCheckBox).ThemeName = "MaterialTeal"

                        If My.Settings.setTheme = "CrystalDark" Then
                            CType(con1, RadCheckBox).ForeColor = Color.White
                        Else
                            CType(con1, RadCheckBox).ForeColor = Color.Black
                        End If


                    End If

                    If TypeOf con1 Is RadLabel Then
                        CType(con1, RadLabel).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadLabel).ThemeName = "Reset"

                        'If My.Settings.setTheme = "CrystalDark" Then
                        '    CType(con1, RadLabel).ForeColor = Color.White
                        'Else
                        '    CType(con1, RadLabel).ForeColor = Color.Black
                        'End If

                    End If
                Next

            End If

            If TypeOf con Is RadPanel Then
                CType(con, RadPanel).ElementTree.EnableApplicationThemeName = False
                CType(con, RadPanel).ThemeName = "Office2010Black"

                For Each con1 As Control In con.Controls

                    If TypeOf con1 Is RadGridView Then
                        CType(con1, RadGridView).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadGridView).ThemeName = My.Settings.setTheme
                    End If

                    If TypeOf con1 Is RadStatusStrip Then
                        CType(con1, RadStatusStrip).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadStatusStrip).ThemeName = My.Settings.setTheme
                    End If

                    If TypeOf con1 Is RadTextBox Then
                        CType(con1, RadTextBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadTextBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadLabel Then
                        CType(con1, RadLabel).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadLabel).ThemeName = "Reset"
                    End If

                    If TypeOf con1 Is RadButton Then
                        CType(con1, RadButton).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadButton).ThemeName = "Office2010Black"
                    End If

                    If TypeOf con1 Is RadMultiColumnComboBox Then
                        CType(con1, RadMultiColumnComboBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadMultiColumnComboBox).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadDropDownList Then
                        CType(con1, RadDropDownList).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadDropDownList).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadSpinEditor Then
                        CType(con1, RadSpinEditor).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadSpinEditor).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadDateTimePicker Then
                        CType(con1, RadDateTimePicker).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadDateTimePicker).ThemeName = "Office2007Black"
                    End If

                    If TypeOf con1 Is RadCheckBox Then
                        CType(con1, RadCheckBox).ElementTree.EnableApplicationThemeName = False
                        CType(con1, RadCheckBox).ThemeName = "MaterialTeal"
                    End If

                Next

            End If


            If TypeOf con Is RadPageView Then
                CType(con, RadPageView).ElementTree.EnableApplicationThemeName = False
                CType(con, RadPageView).ThemeName = "MaterialTeal"

                For Each pg As RadPageViewPage In CType(con, RadPageView).Pages

                    For Each xcon As Control In pg.Controls

                        If TypeOf xcon Is RadCommandBar Then
                            CType(xcon, RadCommandBar).ThemeName = "Office2010Black"
                        End If

                        If TypeOf xcon Is RadGridView Then
                            CType(xcon, RadGridView).ThemeName = My.Settings.setTheme
                        End If

                        If TypeOf xcon Is RadStatusStrip Then
                            CType(xcon, RadStatusStrip).ThemeName = "Office2010Black"
                        End If

                        If TypeOf xcon Is RadCheckBox Then
                            CType(xcon, RadCheckBox).ThemeName = "MaterialTeal"
                        End If

                        If TypeOf xcon Is RadDropDownList Then
                            CType(xcon, RadDropDownList).ThemeName = "Office2007Black"
                        End If

                        If TypeOf xcon Is RadGroupBox Then
                            CType(xcon, RadGroupBox).ThemeName = "MaterialTeal"

                            For Each ycon As Control In xcon.Controls

                                If TypeOf ycon Is RadCheckBox Then
                                    CType(ycon, RadCheckBox).ThemeName = "MaterialTeal"
                                End If

                                If TypeOf ycon Is RadDropDownList Then
                                    CType(ycon, RadDropDownList).ThemeName = "Office2007Black"
                                End If

                            Next

                        End If

                    Next

                Next

            End If

        Next

    End Sub
    Shared Function getClipboard() As DataTable

        Dim ClipboardData As IDataObject = Clipboard.GetDataObject()

        Dim Table As New DataTable With {.TableName = "ExcelData"}

        If Not ClipboardData Is Nothing Then
            If (ClipboardData.GetDataPresent(DataFormats.CommaSeparatedValue)) Then

                Dim ClipboardStream As New IO.StreamReader(
                       CType(ClipboardData.GetData(DataFormats.CommaSeparatedValue), IO.Stream))

                Dim FormattedData As String = ""

                While (ClipboardStream.Peek() > 0)
                    Dim SingleRowData As Array
                    Dim LoopCounter As Integer = 0

                    FormattedData = ClipboardStream.ReadLine()

                    SingleRowData = FormattedData.Split(",".ToCharArray)

                    If Table.Columns.Count <= 0 Then
                        For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                            Table.Columns.Add()
                        Next
                        LoopCounter = 0
                    End If

                    Dim rowNew As DataRow
                    rowNew = Table.NewRow()

                    For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                        rowNew(LoopCounter) = SingleRowData.GetValue(LoopCounter)
                    Next

                    LoopCounter = 0

                    Table.Rows.Add(rowNew)

                    rowNew = Nothing
                End While

                ClipboardStream.Close()

            Else
                RadMessageBox.Show("Clipboard data does not seem to be copied from Excel!", "FEAP HRMS", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        Else
            RadMessageBox.Show("Clipboard is empty!", "FEAP HRMS", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If

        Return Table

    End Function

    Shared Function checkPermission(ByVal username As String, ByVal name As String) As String

        Dim user As DataTable = Slipknot.dbSelectManual("SELECT " & name & " FROM tblUser WHERE fldUsername = '" & username & "' LIMIT 1")

        If user IsNot Nothing Then
            checkPermission = Convert.ToString(user.Rows(0).Item(name))
        Else
            checkPermission = "NA"
        End If

        Return checkPermission
    End Function

    Shared Function checkAdminPermission(ByVal username As String) As String

        Dim user As DataTable = Slipknot.dbSelectManual("SELECT fldUserType FROM tblUser WHERE fldUsername = '" & username & "' LIMIT 1")

        If user IsNot Nothing Then
            checkAdminPermission = Convert.ToString(user.Rows(0).Item("fldUserType"))
        Else
            checkAdminPermission = "LIMITED"
        End If

        Return checkAdminPermission
    End Function

    'Public Sub changePhoto(ByVal imageName As String, ByVal openFileDialog As OpenFileDialog, ByVal pic As PictureBox)

    '    Try

    '        ResizeImageProfile(openFileDialog, openFileDialog.FileName, 400, 400)

    '        Dim ImageStream As System.IO.Stream
    '        openFileDialog.FileName = (New System.IO.FileInfo(openFileDialog.FileName)).DirectoryName & "\" & imageName + ".jpg"

    '        'If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
    '        ImageStream = openFileDialog.OpenFile()
    '        pic.Image = Image.FromStream(ImageStream)
    '        'End If

    '        ImageStream.Dispose()
    '    Catch ex As Exception
    '        RadMessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    'Public Sub ResizeImageProfile(openFileDialog As OpenFileDialog, fileName As String, width As Integer, height As Integer)
    '    Try
    '        'following code resizes picture to fit
    '        Dim bm As New Bitmap(fileName)
    '        Dim thumb As New Bitmap(width, height)
    '        Dim g As Graphics = Graphics.FromImage(thumb)

    '        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

    '        g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)
    '        g.Dispose()
    '        bm.Dispose()

    '        Dim myPath = (New System.IO.FileInfo(openFileDialog.FileName)).DirectoryName

    '        'image path.
    '        thumb.Save(myPath & "\" & fileName & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg) 'can use any image format 

    '        thumb.Dispose()

    '    Catch ex As Exception
    '        RadMessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Shared Function savePicture(ByVal openFileDialog As OpenFileDialog, ByVal recordId As String, ByVal query As String) As Boolean

        Try

            Dim picture As String

            picture = openFileDialog.FileName

            If Not picture = "" Then

                Dim FileSize As UInt32
                Dim rawData() As Byte
                Dim fs As FileStream

                fs = New FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read)
                FileSize = Convert.ToUInt32(fs.Length)

                rawData = New Byte(CInt(FileSize)) {}
                fs.Read(rawData, 0, Convert.ToInt32(FileSize))
                fs.Close()

                addParameter("parID", recordId)
                addParameter("parPhoto", rawData)

                dbAED(query)

                fs.Dispose()

            End If

        Catch ex As Exception

            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

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

    Shared Function ExecuteFormula(ByVal strFormula As String) As Double
        Dim intPos As Integer
        Dim intQtdParentesis As Long
        Dim intPosParOpen As Integer
        Dim intQtdParOpen As Long
        Dim intPosParClose As Integer
        Dim intQtdParClose As Long
        Dim strFormulaTemp As String
        Dim strOperator1 As String
        Dim strOperator2 As String
        Dim dblResultTemp As Double

        'Excludes the spaces
        strFormula = strFormula.Replace(" ", "")

        'Excludes the digits grouping symbol
        strFormula = strFormula.Replace(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator, "")

        'Prepares the negative numbers
        strFormula = strFormula.Replace("+-", "+#")
        strFormula = strFormula.Replace("--", "-#")
        strFormula = strFormula.Replace("*-", "*#")
        strFormula = strFormula.Replace("/-", "/#")
        strFormula = strFormula.Replace("^-", "^#")
        If strFormula.IndexOf("-") = 0 Then strFormula = "#" & strFormula.Substring(1)

        'Gets the amount of opening parentesis
        intQtdParOpen = 0
        intPos = strFormula.IndexOf("(")
        intPosParOpen = intPos
        Do While intPos > -1
            intQtdParOpen += 1
            intPos = strFormula.IndexOf("(", intPos + 1)
        Loop

        'Gets the amount of closing parentesis
        intQtdParClose = 0
        intPos = strFormula.IndexOf(")")
        intPosParClose = intPos
        Do While intPos > -1
            intQtdParClose += 1
            intPosParClose = intPos
            intPos = strFormula.IndexOf(")", intPos + 1)
        Loop

        'Check if the amount of parentesis are equal
        If intQtdParOpen <> intQtdParClose Then
            Throw New System.Exception("The amount of parentheses is different in the formula.")
        End If

        'Executes the formula
        If intPosParOpen > -1 Then
            strFormulaTemp = strFormula.Substring(intPosParOpen + 1, intPosParClose - intPosParOpen - 1)
            dblResultTemp = ExecuteFormula(strFormulaTemp)
            strFormulaTemp = strFormula.Replace("(" & strFormulaTemp & ")", dblResultTemp.ToString)
            Return ExecuteFormula(strFormulaTemp)
        ElseIf strFormula.IndexOf("+") > -1 Then
            'Addition
            intPos = strFormula.IndexOf("+")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) + ExecuteFormula(strOperator2)
        ElseIf strFormula.IndexOf("-") > -1 Then
            'Subtraction
            intPos = strFormula.IndexOf("-")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) - ExecuteFormula(strOperator2)
        ElseIf strFormula.IndexOf("*") > -1 Then
            'Multiplication
            intPos = strFormula.IndexOf("*")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) * ExecuteFormula(strOperator2)
        ElseIf strFormula.IndexOf("/") > -1 Then
            'Division
            intPos = strFormula.IndexOf("/")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) / ExecuteFormula(strOperator2)
        ElseIf strFormula.IndexOf("^") > -1 Then
            'Exponentiation
            intPos = strFormula.IndexOf("^")
            strOperator1 = strFormula.Substring(0, intPos)
            strOperator2 = strFormula.Substring(intPos + 1)
            Return ExecuteFormula(strOperator1) ^ ExecuteFormula(strOperator2)
        Else
            'Returns the negative numbers
            strFormula = strFormula.Replace("#", "-")
            'Check if the value is numeric
            If Not IsNumeric(strFormula) Then
                Throw New System.Exception("One of the operators in the formula is not numeric.")
            End If
            'Returns the value
            Return CDbl(strFormula)
        End If
    End Function

    Shared Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven",
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundred " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousand " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Million " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function

    Shared Function ConvertNumberToENG(ByVal amount As String) As String

        Dim pesos, cents, temp As String
        Dim decimalPlace, count As String
        Dim place(9) As String
        place(2) = " Thousand "
        place(3) = " Million "
        place(4) = " Billion "
        place(5) = " Trillion "

        ' String representation of amount.
        amount = amount.Trim()
        amount = amount.Replace(",", "")
        ' Position of decimal place 0 if none.
        decimalPlace = Convert.ToString(amount.IndexOf("."))
        ' Convert cents and set string amount to dollar amount.
        If Convert.ToDecimal(decimalPlace) > 0 Then
            cents = GetTens(amount.Substring(Convert.ToInt32(decimalPlace) + 1).PadRight(2, CChar("0")).Substring(0, 2))
            amount = amount.Substring(0, Convert.ToInt32(decimalPlace)).Trim()
        End If

        count = Convert.ToString(1)
        Do While amount <> ""
            temp = GetHundreds(amount.Substring(Math.Max(amount.Length, 3) - 3))
            If temp <> "" Then pesos = temp & place(Convert.ToInt32(count)) & pesos
            If amount.Length > 3 Then
                amount = amount.Substring(0, amount.Length - 3)
            Else
                amount = ""
            End If
            count = Convert.ToString(Convert.ToDouble(count) + 1)
        Loop

        Select Case pesos
            Case ""
                pesos = "No Pesos"
            Case "One"
                pesos = "One Peso"
            Case Else
                pesos = pesos '& " Pesos"
        End Select

        Select Case cents
            Case ""
                cents = " and No Cents"
            Case "One"
                cents = " and One Cent"
            Case Else
                cents = " and " & cents & " Cents"
        End Select

        ConvertNumberToENG = pesos '& cents

    End Function

    ' Converts a number from 100-999 into text
    Shared Function GetHundreds(ByVal amount As String) As String
        Dim Result As String
        If Not Integer.Parse(amount) = 0 Then
            amount = amount.PadLeft(3, CChar("0"))
            ' Convert the hundreds place.
            If amount.Substring(0, 1) <> "0" Then
                Result = GetDigit(amount.Substring(0, 1)) & " Hundred "
            End If
            ' Convert the tens and ones place.
            If amount.Substring(1, 1) <> "0" Then
                Result = Result & GetTens(amount.Substring(1))
            Else
                Result = Result & GetDigit(amount.Substring(2))
            End If
            GetHundreds = Result
        End If
    End Function

    ' Converts a number from 10 to 99 into text.
    Shared Function GetTens(ByRef TensText As String) As String
        Dim Result As String
        Result = ""           ' Null out the temporary function value.
        If TensText.StartsWith("1") Then   ' If value between 10-19...
            Select Case Integer.Parse(TensText)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else                                 ' If value between 20-99...
            Select Case Integer.Parse(TensText.Substring(0, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select
            Result = Result & GetDigit(TensText.Substring(1, 1))  ' Retrieve ones place.
        End If
        GetTens = Result
    End Function

    ' Converts a number from 1 to 9 into text.
    Shared Function GetDigit(ByRef Digit As String) As String
        Select Case Integer.Parse(Digit)
            Case 1 : GetDigit = "One"
            Case 2 : GetDigit = "Two"
            Case 3 : GetDigit = "Three"
            Case 4 : GetDigit = "Four"
            Case 5 : GetDigit = "Five"
            Case 6 : GetDigit = "Six"
            Case 7 : GetDigit = "Seven"
            Case 8 : GetDigit = "Eight"
            Case 9 : GetDigit = "Nine"
            Case Else : GetDigit = ""
        End Select
    End Function

End Class
