Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports MySql.Data.MySqlClient
Public Class test

    Shared Sub constractItemBOM(ByVal titleId As String, ByVal subContentId As String)

        'DELETE EXISTING REPORT DATA
        Slipknot.addParameter("parTitleId", titleId)
        Slipknot.addParameter("parSubContentId", subContentId)
        Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
        Slipknot.dbAED("SP_DeleteBOMReportsData")

        'START OF BOM REPORT CONSTRUCTION
        dtLayer1.Rows.Clear()
        dtLayer2.Rows.Clear()
        dtLayer3.Rows.Clear()
        dtLayer4.Rows.Clear()
        dtLayer5.Rows.Clear()
        dtLayer6.Rows.Clear()
        dtLayer7.Rows.Clear()
        dtLayer8.Rows.Clear()

        dtLayer1.Columns.Clear()
        dtLayer2.Columns.Clear()
        dtLayer3.Columns.Clear()
        dtLayer4.Columns.Clear()
        dtLayer5.Columns.Clear()
        dtLayer6.Columns.Clear()
        dtLayer7.Columns.Clear()
        dtLayer8.Columns.Clear()

        dtLayer1.Columns.Add("itemCode")
        dtLayer2.Columns.Add("itemCode")
        dtLayer3.Columns.Add("itemCode")
        dtLayer4.Columns.Add("itemCode")
        dtLayer5.Columns.Add("itemCode")
        dtLayer6.Columns.Add("itemCode")
        dtLayer7.Columns.Add("itemCode")
        dtLayer8.Columns.Add("itemCode")

        Slipknot.addParameter("parTitleId", titleId)
        Slipknot.addParameter("parSubContentId", subContentId)
        Dim dtHeader As DataTable = Slipknot.dbSelect("SP_SelectBOMContentsByTitleAndSubContent")

        'FG PARENT HEADER LOOP
        For Each row As DataRow In dtHeader.Rows

            Dim itemCode As String = Convert.ToString(row.Item("fldItemCode"))
            Dim partName As String = Convert.ToString(row.Item("fldPartName"))
            Dim registrationNo As String = Convert.ToString(row.Item("fldRegistrationNo"))
            Dim modelCode As String = Convert.ToString(row.Item("fldModelCode"))
            Dim customerPartNo As String = Convert.ToString(row.Item("fldCustomerPartNo"))

            Slipknot.addParameter("parTitleId", titleId)
            Slipknot.addParameter("parSubContentId", subContentId)
            Slipknot.addParameter("parItemCode", itemCode)
            Slipknot.addParameter("parPartName", partName)
            Slipknot.addParameter("parRegistrationNo", registrationNo)
            Slipknot.addParameter("parModelCode", modelCode)
            Slipknot.addParameter("parCustomerPartNo", customerPartNo)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            If Slipknot.dbAED("SP_InsertBOMReportHeader") Then
                addReportRow(itemCode, dtLayer1)
            End If

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each rowC As DataRow In dt.Rows
                Dim childCode As String = Convert.ToString(rowC.Item("fldChildCode"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parChildCode", childCode)
                Slipknot.dbAED("SP_InsertBOMReportSRCAssy")

            Next

        Next

        Dim dtFirst As DataTable = Slipknot.dbSelectManual("SELECT T0.fldItemCode FROM " _
                                                         & "tblBOMReportSRCAssy T0 " _
                                                         & "LEFT JOIN tblItemMasterData T1 " _
                                                         & "ON IF((SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldItemCode LIMIT 1) IS NULL, T0.fldItemCode, (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldItemCode LIMIT 1)) = T1.fldItemCode")


        'LAYER 1 LOOP
        For Each row As DataRow In dtFirst.Rows 'dtLayer1.Rows

            Dim itemCode As String = Convert.ToString(row.Item("fldItemCode"))

            Slipknot.addParameter("parTitleId", titleId)
            Slipknot.addParameter("parSubContentId", subContentId)
            Slipknot.addParameter("parParentCode", "GP")
            Slipknot.addParameter("parParentPartName", "")
            Slipknot.addParameter("parParentRegistrationNo", "")
            Slipknot.addParameter("parItemCode", itemCode)
            Slipknot.addParameter("parClass", 0)
            Slipknot.addParameter("parPartName", "")
            Slipknot.addParameter("parRegistrationNo", "")
            Slipknot.addParameter("parUOM", "")
            Slipknot.addParameter("parUsage", "")
            Slipknot.addParameter("parProcess", "")
            Slipknot.addParameter("parProcessPriority", "")
            Slipknot.addParameter("parProcessColor", "")
            Slipknot.addParameter("parMaker", "")
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            If Slipknot.dbAED("SP_InsertBOMReportDetails") Then
                addReportRow(itemCode, dtLayer2)
            End If

        Next

        'LAYER 2 LOOP
        For Each row As DataRow In dtLayer2.Rows

                Dim itemCode As String = Convert.ToString(row.Item("itemCode"))

            Slipknot.addParameter("parParentCode", itemCode)
            Dim dt As DataTable = Slipknot.dbSelect("SP_Test")

            For Each row1 As DataRow In dt.Rows

                    Dim childCode As String = Convert.ToString(row1.Item("fldChildCode"))
                    Dim partName As String = Convert.ToString(row1.Item("fldPartName"))
                    Dim registrationNo As String = Convert.ToString(row1.Item("fldRegistrationNo"))
                    Dim UOM As String = Convert.ToString(row1.Item("fldUOM"))
                    Dim usage As String = Convert.ToString(row1.Item("fldUsage"))
                    Dim maker As String = Convert.ToString(row1.Item("maker"))

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parParentCode", itemCode)
                    Slipknot.addParameter("parParentPartName", "")
                    Slipknot.addParameter("parParentRegistrationNo", "")
                    Slipknot.addParameter("parItemCode", childCode)
                    Slipknot.addParameter("parClass", 0)
                    Slipknot.addParameter("parPartName", partName)
                    Slipknot.addParameter("parRegistrationNo", registrationNo)
                    Slipknot.addParameter("parUOM", UOM)
                    Slipknot.addParameter("parUsage", usage)
                    Slipknot.addParameter("parProcess", "")
                    Slipknot.addParameter("parProcessPriority", "")
                    Slipknot.addParameter("parProcessColor", "")
                    Slipknot.addParameter("parMaker", maker)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                    If Slipknot.dbAED("SP_InsertBOMReportDetails") Then
                        addReportRow(childCode, dtLayer3)
                    End If

                Next

            Next

            'LAYER 3 LOOP
            For Each row As DataRow In dtLayer3.Rows

                Dim itemCode As String = Convert.ToString(row.Item("itemCode"))

            Slipknot.addParameter("parParentCode", itemCode)
            Dim dt As DataTable = Slipknot.dbSelect("SP_Test")

                For Each row1 As DataRow In dt.Rows

                    Dim childCode As String = Convert.ToString(row1.Item("fldChildCode"))
                    Dim partName As String = Convert.ToString(row1.Item("fldPartName"))
                    Dim registrationNo As String = Convert.ToString(row1.Item("fldRegistrationNo"))
                    Dim UOM As String = Convert.ToString(row1.Item("fldUOM"))
                    Dim usage As String = Convert.ToString(row1.Item("fldUsage"))
                    Dim maker As String = Convert.ToString(row1.Item("maker"))

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parParentCode", itemCode)
                    Slipknot.addParameter("parParentPartName", "")
                    Slipknot.addParameter("parParentRegistrationNo", "")
                    Slipknot.addParameter("parItemCode", childCode)
                    Slipknot.addParameter("parClass", 0)
                    Slipknot.addParameter("parPartName", partName)
                    Slipknot.addParameter("parRegistrationNo", registrationNo)
                    Slipknot.addParameter("parUOM", UOM)
                    Slipknot.addParameter("parUsage", usage)
                    Slipknot.addParameter("parProcess", "")
                    Slipknot.addParameter("parProcessPriority", "")
                    Slipknot.addParameter("parProcessColor", "")
                    Slipknot.addParameter("parMaker", maker)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                    If Slipknot.dbAED("SP_InsertBOMReportDetails") Then
                        addReportRow(childCode, dtLayer4)
                    End If

                Next

            Next

            'LAYER 4 LOOP
            For Each row As DataRow In dtLayer4.Rows

                Dim itemCode As String = Convert.ToString(row.Item("itemCode"))

            Slipknot.addParameter("parParentCode", itemCode)
            Dim dt As DataTable = Slipknot.dbSelect("SP_Test")

                For Each row1 As DataRow In dt.Rows

                    Dim childCode As String = Convert.ToString(row1.Item("fldChildCode"))
                    Dim partName As String = Convert.ToString(row1.Item("fldPartName"))
                    Dim registrationNo As String = Convert.ToString(row1.Item("fldRegistrationNo"))
                    Dim UOM As String = Convert.ToString(row1.Item("fldUOM"))
                    Dim usage As String = Convert.ToString(row1.Item("fldUsage"))
                    Dim maker As String = Convert.ToString(row1.Item("maker"))

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parParentCode", itemCode)
                    Slipknot.addParameter("parParentPartName", "")
                    Slipknot.addParameter("parParentRegistrationNo", "")
                    Slipknot.addParameter("parItemCode", childCode)
                    Slipknot.addParameter("parClass", 0)
                    Slipknot.addParameter("parPartName", partName)
                    Slipknot.addParameter("parRegistrationNo", registrationNo)
                    Slipknot.addParameter("parUOM", UOM)
                    Slipknot.addParameter("parUsage", usage)
                    Slipknot.addParameter("parProcess", "")
                    Slipknot.addParameter("parProcessPriority", "")
                    Slipknot.addParameter("parProcessColor", "")
                    Slipknot.addParameter("parMaker", maker)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                    If Slipknot.dbAED("SP_InsertBOMReportDetails") Then
                        addReportRow(childCode, dtLayer5)
                    End If

                Next

            Next

            'LAYER 5 LOOP
            For Each row As DataRow In dtLayer5.Rows

                Dim itemCode As String = Convert.ToString(row.Item("itemCode"))

            Slipknot.addParameter("parParentCode", itemCode)
            Dim dt As DataTable = Slipknot.dbSelect("SP_Test")

                For Each row1 As DataRow In dt.Rows

                    Dim childCode As String = Convert.ToString(row1.Item("fldChildCode"))
                    Dim partName As String = Convert.ToString(row1.Item("fldPartName"))
                    Dim registrationNo As String = Convert.ToString(row1.Item("fldRegistrationNo"))
                    Dim UOM As String = Convert.ToString(row1.Item("fldUOM"))
                    Dim usage As String = Convert.ToString(row1.Item("fldUsage"))
                    Dim maker As String = Convert.ToString(row1.Item("maker"))

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parParentCode", itemCode)
                    Slipknot.addParameter("parParentPartName", "")
                    Slipknot.addParameter("parParentRegistrationNo", "")
                    Slipknot.addParameter("parItemCode", childCode)
                    Slipknot.addParameter("parClass", 0)
                    Slipknot.addParameter("parPartName", partName)
                    Slipknot.addParameter("parRegistrationNo", registrationNo)
                    Slipknot.addParameter("parUOM", UOM)
                    Slipknot.addParameter("parUsage", usage)
                    Slipknot.addParameter("parProcess", "")
                    Slipknot.addParameter("parProcessPriority", "")
                    Slipknot.addParameter("parProcessColor", "")
                    Slipknot.addParameter("parMaker", maker)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                    If Slipknot.dbAED("SP_InsertBOMReportDetails") Then
                        addReportRow(childCode, dtLayer6)
                    End If

                Next

            Next

            'LAYER 6 LOOP
            For Each row As DataRow In dtLayer6.Rows

                Dim itemCode As String = Convert.ToString(row.Item("itemCode"))

            Slipknot.addParameter("parParentCode", itemCode)
            Dim dt As DataTable = Slipknot.dbSelect("SP_Test")

                For Each row1 As DataRow In dt.Rows

                    Dim childCode As String = Convert.ToString(row1.Item("fldChildCode"))
                    Dim partName As String = Convert.ToString(row1.Item("fldPartName"))
                    Dim registrationNo As String = Convert.ToString(row1.Item("fldRegistrationNo"))
                    Dim UOM As String = Convert.ToString(row1.Item("fldUOM"))
                    Dim usage As String = Convert.ToString(row1.Item("fldUsage"))
                    Dim maker As String = Convert.ToString(row1.Item("maker"))

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parParentCode", itemCode)
                    Slipknot.addParameter("parParentPartName", "")
                    Slipknot.addParameter("parParentRegistrationNo", "")
                    Slipknot.addParameter("parItemCode", childCode)
                    Slipknot.addParameter("parClass", 0)
                    Slipknot.addParameter("parPartName", partName)
                    Slipknot.addParameter("parRegistrationNo", registrationNo)
                    Slipknot.addParameter("parUOM", UOM)
                    Slipknot.addParameter("parUsage", usage)
                    Slipknot.addParameter("parProcess", "")
                    Slipknot.addParameter("parProcessPriority", "")
                    Slipknot.addParameter("parProcessColor", "")
                    Slipknot.addParameter("parMaker", maker)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                    If Slipknot.dbAED("SP_InsertBOMReportDetails") Then
                        addReportRow(childCode, dtLayer7)
                    End If

                Next

            Next

            'LAYER 7 LOOP
            For Each row As DataRow In dtLayer7.Rows

                Dim itemCode As String = Convert.ToString(row.Item("itemCode"))

            Slipknot.addParameter("parParentCode", itemCode)
            Dim dt As DataTable = Slipknot.dbSelect("SP_Test")

                For Each row1 As DataRow In dt.Rows

                    Dim childCode As String = Convert.ToString(row1.Item("fldChildCode"))
                    Dim partName As String = Convert.ToString(row1.Item("fldPartName"))
                    Dim registrationNo As String = Convert.ToString(row1.Item("fldRegistrationNo"))
                    Dim UOM As String = Convert.ToString(row1.Item("fldUOM"))
                    Dim usage As String = Convert.ToString(row1.Item("fldUsage"))
                    Dim maker As String = Convert.ToString(row1.Item("maker"))

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parParentCode", itemCode)
                    Slipknot.addParameter("parParentPartName", "")
                    Slipknot.addParameter("parParentRegistrationNo", "")
                    Slipknot.addParameter("parItemCode", childCode)
                    Slipknot.addParameter("parClass", 0)
                    Slipknot.addParameter("parPartName", partName)
                    Slipknot.addParameter("parRegistrationNo", registrationNo)
                    Slipknot.addParameter("parUOM", UOM)
                    Slipknot.addParameter("parUsage", usage)
                    Slipknot.addParameter("parProcess", "")
                    Slipknot.addParameter("parProcessPriority", "")
                    Slipknot.addParameter("parProcessColor", "")
                    Slipknot.addParameter("parMaker", maker)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                    If Slipknot.dbAED("SP_InsertBOMReportDetails") Then
                        addReportRow(childCode, dtLayer8)
                    End If

                Next

            Next

            'LAYER 8 LOOP
            For Each row As DataRow In dtLayer8.Rows

                Dim itemCode As String = Convert.ToString(row.Item("itemCode"))

            Slipknot.addParameter("parParentCode", itemCode)
            Dim dt As DataTable = Slipknot.dbSelect("SP_Test")

                For Each row1 As DataRow In dt.Rows

                    Dim childCode As String = Convert.ToString(row1.Item("fldChildCode"))
                    Dim partName As String = Convert.ToString(row1.Item("fldPartName"))
                    Dim registrationNo As String = Convert.ToString(row1.Item("fldRegistrationNo"))
                    Dim UOM As String = Convert.ToString(row1.Item("fldUOM"))
                    Dim usage As String = Convert.ToString(row1.Item("fldUsage"))
                    Dim maker As String = Convert.ToString(row1.Item("maker"))

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parParentCode", itemCode)
                    Slipknot.addParameter("parParentPartName", "")
                    Slipknot.addParameter("parParentRegistrationNo", "")
                    Slipknot.addParameter("parItemCode", childCode)
                    Slipknot.addParameter("parClass", 0)
                    Slipknot.addParameter("parPartName", partName)
                    Slipknot.addParameter("parRegistrationNo", registrationNo)
                    Slipknot.addParameter("parUOM", UOM)
                    Slipknot.addParameter("parUsage", usage)
                    Slipknot.addParameter("parProcess", "")
                    Slipknot.addParameter("parProcessPriority", "")
                    Slipknot.addParameter("parProcessColor", "")
                    Slipknot.addParameter("parMaker", maker)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                    Slipknot.dbAED("SP_InsertBOMReportDetails")

                Next

            Next


        'FINALIZING REPORT LOOP
        Slipknot.addParameter("parTitleId", titleId)
        Slipknot.addParameter("parSubContentId", subContentId)
        Dim dtReportH As DataTable = Slipknot.dbSelect("SP_SelectBOMReportHeader")

        Slipknot.addParameter("parTitleId", titleId)
        Slipknot.addParameter("parSubContentId", subContentId)
        Dim dtReportD As DataTable = Slipknot.dbSelect("SP_SelectBOMReportDByTitleId")

        'INSERTING SRC ASSEMBLY PROCESS
        For Each row As DataRow In dtReportD.Rows

            Dim itemCode As String

            Dim process As String
            Dim processPriority As Integer
            Dim processColor As String
            Dim itemClass As Integer

            If Convert.ToString(row.Item("itemProcess")) = "SRC ASSEMBLY" And Convert.ToString(row.Item("fldParentCode")) = "GP" Then

                itemCode = Convert.ToString(row.Item("fldItemCode"))
                process = Convert.ToString(row.Item("itemProcess"))
                processPriority = Convert.ToString(row.Item("itemProcessPriority")) 'x2
                processColor = Convert.ToString(row.Item("itemProcessColor"))
                itemClass = 0

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parItemCode", itemCode)
                Slipknot.addParameter("parProcess", process)
                Slipknot.addParameter("parProcessPriority", processPriority)
                Slipknot.addParameter("parProcessColor", processColor)
                Slipknot.addParameter("parClass", itemClass)
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                '{
                'GETTING USAGE PER OF ITEMS FOR THE PARENT

                Dim uCounter As Integer = 1
                For Each rowH As DataRow In dtReportH.Rows
                    Dim parentCode As String = Convert.ToString(rowH.Item("fldItemCode"))

                    Dim GParent As DataTable = Slipknot.dbSelectManual("SELECT fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & parentCode & "' AND fldChildCode = '" & itemCode & "' ")

                    Dim usage As String = 0
                    If GParent.Rows.Count > 0 Then
                        If Convert.ToDecimal(GParent.Rows(0).Item("fldUsage")) = 0 Then
                            usage = 0
                        Else
                            usage = Convert.ToString(GParent.Rows(0).Item("fldUsage"))
                        End If
                    End If

                    Slipknot.addParameter("parU" & uCounter, usage)

                    uCounter = uCounter + 1
                Next

                For counter As Integer = uCounter To 8
                    Slipknot.addParameter("parU" & counter, DBNull.Value)
                Next

                '}
                Slipknot.dbAED("SP_InsertBOMReportFinal")

            End If

        Next

        'INSERTING NONE SRC ASSEMBLY PROCESS
        For Each row As DataRow In dtReportD.Rows

            Dim itemCode As String

            Dim process As String
            Dim processPriority As String
            Dim processColor As String
            Dim itemClass As String

            If Convert.ToString(row.Item("itemProcess")) <> "SRC ASSEMBLY" Then

                itemCode = Convert.ToString(row.Item("fldParentCode"))
                process = Convert.ToString(row.Item("itemProcess"))
                processPriority = Convert.ToString(row.Item("itemProcessPriority")) 'x1
                processColor = Convert.ToString(row.Item("itemProcessColor"))
                itemClass = 0

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parItemCode", itemCode)
                Slipknot.addParameter("parProcess", process)
                Slipknot.addParameter("parProcessPriority", processPriority)
                Slipknot.addParameter("parProcessColor", processColor)
                Slipknot.addParameter("parClass", itemClass)
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                '{
                'CONSTRUCT DUMMY USAGE

                'For counter As Integer = 1 To 8
                '    Slipknot.addParameter("parU" & counter, DBNull.Value)
                'Next

                Dim uCounter As Integer = 1
                For Each rowH As DataRow In dtReportH.Rows
                    Dim father As String = Convert.ToString(rowH.Item("fldItemCode"))

                    Dim GParent As DataTable = Slipknot.dbSelectManual("SELECT fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & father & "' AND fldChildCode = '" & itemCode & "' ")

                    Dim usage As String = "N"
                    If GParent.Rows.Count > 0 Then
                        If Convert.ToDecimal(GParent.Rows(0).Item("fldUsage")) = 0 Then
                            usage = "N"
                        Else
                            usage = "Y"
                        End If
                    End If

                    Slipknot.addParameter("parU" & uCounter, usage)

                    uCounter = uCounter + 1
                Next

                For counter As Integer = uCounter To 8
                    Slipknot.addParameter("parU" & counter, DBNull.Value)
                Next

                '}
                Slipknot.dbAED("SP_InsertBOMReportFinal")

                'GETTTING AND INSERTING GRAND CHILD
                Slipknot.addParameter("parParentCode", itemCode)
                Dim dtChild As DataTable = Slipknot.dbSelect("SP_SelectBOMMasterByParent")

                Dim parentCode As String = itemCode
                For Each childRow As DataRow In dtChild.Rows

                    itemCode = Convert.ToString(childRow.Item("fldChildCode"))
                    itemClass = 1

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parItemCode", itemCode)
                    Slipknot.addParameter("parProcess", process)
                    Slipknot.addParameter("parProcessPriority", processPriority)
                    Slipknot.addParameter("parProcessColor", processColor)
                    Slipknot.addParameter("parClass", itemClass)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                    '{
                    'GETTING USAGE PER OF ITEMS FOR THE PARENT

                    Dim GParent As DataTable = Slipknot.dbSelectManual("SELECT fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & parentCode & "' AND fldChildCode = '" & itemCode & "' ")
                    Dim usage As String = 0
                    If GParent.Rows.Count > 0 Then
                        usage = Convert.ToString(GParent.Rows(0).Item("fldUsage"))
                    End If

                    Dim parentRow As DataRow = Slipknot.rowSelectManual("SELECT * FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldItemCode = '" & parentCode & "' ")

                    If parentRow IsNot Nothing Then
                        For i As Integer = 1 To 8

                            If Convert.ToString(parentRow.Item("fldU" & i)) = String.Empty Then
                                Slipknot.addParameter("parU" & i, DBNull.Value)
                            Else
                                If Convert.ToString(parentRow.Item("fldU" & i)) = "0" Then
                                    Slipknot.addParameter("parU" & i, "0")
                                Else
                                    Slipknot.addParameter("parU" & i, usage)
                                End If
                            End If

                        Next
                    Else
                        For i As Integer = 1 To 8
                            Slipknot.addParameter("parU" & i, DBNull.Value)
                        Next
                    End If

                    '}

                    Slipknot.dbAED("SP_InsertBOMReportFinal")

                Next

            End If

        Next

    End Sub

    Shared Function addReportRow(ByVal itemCode As String, ByVal dt As DataTable) As Boolean

        Dim added As Boolean = False

        For Each row As DataRow In dt.Rows
            If itemCode = row("itemCode") Then
                added = True
                Exit For
            End If
        Next

        If added = False Then
            dt.Rows.Add(itemCode)
        End If

        Return True
    End Function

End Class
