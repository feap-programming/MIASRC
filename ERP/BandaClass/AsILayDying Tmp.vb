Public Class AsILayDyingTmp

    Shared Sub constractItemBOM(ByVal titleId As String, ByVal subContentId As String)

        'DELETE EXISTING REPORT DATA
        Slipknot.addParameter("parTitleId", titleId)
        Slipknot.addParameter("parSubContentId", subContentId)
        'Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
        Slipknot.dbAED("SP_DeleteBOMReportsData")

        Slipknot.addParameter("parTitleId", titleId)
        Slipknot.addParameter("parSubContentId", subContentId)
        Dim dtHeader As DataTable = Slipknot.dbSelect("SP_SelectBOMContentsByTitleAndSubContent")

        'FG PARENT HEADER LOOP
        Dim counter As Integer = 1

        For Each row As DataRow In dtHeader.Rows

            Dim granParentCode As String = Convert.ToString(row.Item("fldItemCode"))
            Dim partName As String = Convert.ToString(row.Item("fldPartName"))
            Dim registrationNo As String = Convert.ToString(row.Item("fldRegistrationNo"))
            Dim modelCode As String = Convert.ToString(row.Item("fldModelCode"))
            Dim customerPartNo As String = Convert.ToString(row.Item("fldCustomerPartNo"))

            Slipknot.addParameter("parTitleId", titleId)
            Slipknot.addParameter("parSubContentId", subContentId)
            Slipknot.addParameter("parItemCode", granParentCode)
            Slipknot.addParameter("parPartName", partName)
            Slipknot.addParameter("parRegistrationNo", registrationNo)
            Slipknot.addParameter("parModelCode", modelCode)
            Slipknot.addParameter("parCustomerPartNo", customerPartNo)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

            Slipknot.dbAED("SP_InsertBOMReportHeader")

            insertSRCAssymbly(titleId, subContentId, granParentCode, counter)

            counter = counter + 1

        Next

        insertDetailsLayer1(titleId, subContentId)
        insertDetailsLayer2(titleId, subContentId)
        insertDetailsLayer3(titleId, subContentId)
        insertDetailsLayer4(titleId, subContentId)
        insertDetailsLayer5(titleId, subContentId)
        insertDetailsLayer6(titleId, subContentId)
        insertDetailsLayer7(titleId, subContentId)
        insertDetailsLayer8(titleId, subContentId)

        finalizingReport(titleId, subContentId)


        Dim Uno As Integer = 1
        For Each row As DataRow In dtHeader.Rows

            Dim FGNo As String = Convert.ToString(row.Item("fldItemCode"))

            putUsage(FGNo, titleId, subContentId, Uno)

            Uno = Uno + 1

        Next

    End Sub

    Shared Sub insertSRCAssymbly(ByVal titleId As String, ByVal subContentId As String, ByVal itemCode As String, ByVal counter As Integer)

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "'")

        For Each row In dt.Rows

            Dim childCode As String = Convert.ToString(row("fldChildCode"))

            Dim check As DataTable = Slipknot.dbSelectManual("SELECT fldId FROM tblBOMReportSRCAssy WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldChildCode = '" & childCode & "' ")

            If check.Rows.Count = 0 Then

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", itemCode)
                Slipknot.addParameter("parChildCode", childCode)
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportSRCAssy")

            End If

        Next

    End Sub

    Shared Sub insertDetailsLayer1(ByVal titleId As String, ByVal subContentId As String)

        Dim dtSRCAssy As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportSRCAssy WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' ")

        Dim SRCChildCode As String

        For Each row As DataRow In dtSRCAssy.Rows

            SRCChildCode = Convert.ToString(row.Item("fldChildCode"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblProcess T2 ON T2.fldCode = T1.fldProcessCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & SRCChildCode & "' AND T2.fldHideInBOM = 0 ")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 1)
                Slipknot.addParameter("parProcess", grandChildProcess)
                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer2(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 1 GROUP BY fldChildCode ")

        Dim childCode As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblProcess T2 ON T2.fldCode = T1.fldProcessCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "' AND T2.fldHideInBOM = 0 ")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 2)
                Slipknot.addParameter("parProcess", grandChildProcess)
                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer3(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 2 GROUP BY fldChildCode ")

        Dim childCode As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblProcess T2 ON T2.fldCode = T1.fldProcessCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "' AND T2.fldHideInBOM = 0 ")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 3)
                Slipknot.addParameter("parProcess", grandChildProcess)
                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer4(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 3 GROUP BY fldChildCode ")

        Dim childCode As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblProcess T2 ON T2.fldCode = T1.fldProcessCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "' AND T2.fldHideInBOM = 0 ")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 4)
                Slipknot.addParameter("parProcess", grandChildProcess)
                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer5(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 4 GROUP BY fldChildCode ")

        Dim childCode As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblProcess T2 ON T2.fldCode = T1.fldProcessCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "' AND T2.fldHideInBOM = 0 ")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 5)
                Slipknot.addParameter("parProcess", grandChildProcess)
                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer6(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 5 GROUP BY fldChildCode ")

        Dim childCode As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblProcess T2 ON T2.fldCode = T1.fldProcessCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "' AND T2.fldHideInBOM = 0 ")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 6)
                Slipknot.addParameter("parProcess", grandChildProcess)
                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer7(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 6 GROUP BY fldChildCode ")

        Dim childCode As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblProcess T2 ON T2.fldCode = T1.fldProcessCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "' AND T2.fldHideInBOM = 0 ")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 7)
                Slipknot.addParameter("parProcess", grandChildProcess)
                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer8(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 7 GROUP BY fldChildCode ")

        Dim childCode As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblProcess T2 ON T2.fldCode = T1.fldProcessCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "' AND T2.fldHideInBOM = 0 ")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 8)
                Slipknot.addParameter("parProcess", grandChildProcess)
                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub finalizingReport(ByVal titleId As String, ByVal subContentId As String)

        Dim dtHeader As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                          & "*" _
                                                          & "FROM " _
                                                          & "tblBOMReportSRCAssy T0 " _
                                                          & "WHERE " _
                                                          & "T0.fldTitleId = '" & titleId & "' AND T0.fldSubContentId = '" & subContentId & "' ")

        Dim parentItemCode As String

        For Each row As DataRow In dtHeader.Rows

            parentItemCode = Convert.ToString(row.Item("fldChildCode"))

            Slipknot.addParameter("parTitleId", titleId)
            Slipknot.addParameter("parSubContentId", subContentId)
            Slipknot.addParameter("parParentCode", parentItemCode)
            Slipknot.addParameter("parItemCode", parentItemCode)
            Slipknot.addParameter("parProcess", "SRC ASSEMBLY")
            Slipknot.addParameter("parProcessPriority", 0)
            Slipknot.addParameter("parProcessColor", "LightBlue")
            Slipknot.addParameter("parClass", 0)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
            Slipknot.addParameter("parLayer", 0)

            Slipknot.dbAED("SP_InsertBOMReportFinal")

        Next


        Dim dtDetails As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                    & "T0.fldProcess, " _
                                                    & "T0.fldParentCode, " _
                                                    & "ANY_VALUE(T0.fldLayer) AS fldLayer, " _
                                                    & "ANY_VALUE(T1.fldPriority) AS fldPriority, " _
                                                    & "ANY_VALUE(T1.fldColor) AS fldColor " _
                                                    & "FROM " _
                                                    & "tblBOMReportD T0 " _
                                                    & "LEFT JOIN " _
                                                    & "tblProcess T1 ON T0.fldProcess = T1.fldProcessName " _
                                                    & "WHERE " _
                                                    & "T0.fldTitleId = '" & titleId & "' AND T0.fldSubContentId = '" & subContentId & "' AND T1.fldHideInBOM = 0 " _
                                                    & "GROUP BY " _
                                                    & "T0.fldProcess, " _
                                                    & "T0.fldParentCode " _
                                                    & "ORDER BY " _
                                                    & "T1.fldPriority, T0.fldParentCode ASC")

        Dim process As String
        Dim parentCode As String
        Dim processPriority As Integer
        Dim color As String
        Dim parentLayer As String

        For Each row As DataRow In dtDetails.Rows

            parentCode = Convert.ToString(row.Item("fldParentCode"))
            parentLayer = Convert.ToString(row.Item("fldLayer"))

            If Convert.ToString(row.Item("fldProcess")) <> String.Empty Then
                process = Convert.ToString(row.Item("fldProcess"))
                processPriority = Convert.ToInt32(row.Item("fldPriority"))
                color = Convert.ToString(row.Item("fldColor"))
            Else
                process = "UNKNOWN PROCESS"
                processPriority = 1000
                color = "Red"
            End If

            Slipknot.addParameter("parTitleId", titleId)
            Slipknot.addParameter("parSubContentId", subContentId)
            Slipknot.addParameter("parParentCode", parentCode)
            Slipknot.addParameter("parItemCode", parentCode)
            Slipknot.addParameter("parProcess", process)
            Slipknot.addParameter("parProcessPriority", processPriority)
            Slipknot.addParameter("parProcessColor", color)
            Slipknot.addParameter("parClass", 0)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
            Slipknot.addParameter("parLayer", parentLayer)

            If Slipknot.dbAED("SP_InsertBOMReportFinal") Then

                Dim dtChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                              & "T0.fldParentCode, " _
                                                              & "T0.fldChildCode, " _
                                                              & "ANY_VALUE(T0.fldLayer) AS fldLayer, " _
                                                              & "T0.fldProcess, " _
                                                              & "ANY_VALUE(T0.fldMaker) AS fldMaker, " _
                                                              & "ANY_VALUE(T0.fldRemarks) AS fldRemarks, " _
                                                              & "ANY_VALUE(T1.fldPriority) AS fldPriority, " _
                                                              & "ANY_VALUE(T1.fldColor) AS fldColor " _
                                                              & "FROM " _
                                                              & "tblBOMReportD T0 " _
                                                              & "LEFT JOIN " _
                                                              & "tblProcess T1 ON T0.fldProcess = T1.fldProcessName " _
                                                              & "WHERE " _
                                                              & "T0.fldTitleId = '" & titleId & "' AND T0.fldSubContentId = '" & subContentId & "' AND T0.fldParentCode = '" & parentCode & "' AND T1.fldHideInBOM = 0 " _
                                                              & "GROUP BY T0.fldParentCode, T0.fldChildCode, T0.fldProcess")

                Dim childParentCode As String
                Dim childCode As String
                Dim childProcess As String
                Dim childProcessPriority As Integer
                Dim childProcessColor As String
                Dim childLayer As String

                For Each row2 As DataRow In dtChild.Rows

                    childParentCode = Convert.ToString(row2.Item("fldParentCode"))
                    childCode = Convert.ToString(row2.Item("fldChildCode"))

                    If Convert.ToString(row2.Item("fldProcess")) <> String.Empty Then
                        childProcess = Convert.ToString(row2.Item("fldProcess"))
                        childProcessPriority = Convert.ToInt32(row2.Item("fldPriority"))
                        childProcessColor = Convert.ToString(row2.Item("fldColor"))
                    Else
                        childProcess = "UNKNOWN PROCESS"
                        childProcessPriority = 1000
                        childProcessColor = "Red"
                    End If

                    childLayer = Convert.ToString(row2.Item("fldLayer"))

                    Slipknot.addParameter("parTitleId", titleId)
                    Slipknot.addParameter("parSubContentId", subContentId)
                    Slipknot.addParameter("parParentCode", childParentCode)
                    Slipknot.addParameter("parItemCode", childCode)
                    Slipknot.addParameter("parProcess", childProcess)
                    Slipknot.addParameter("parProcessPriority", childProcessPriority)
                    Slipknot.addParameter("parProcessColor", childProcessColor)
                    Slipknot.addParameter("parClass", 1)
                    Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
                    Slipknot.addParameter("parLayer", childLayer)

                    If process = childProcess Then
                        Slipknot.dbAED("SP_InsertBOMReportFinal")
                    Else
                        myParam.Clear()
                    End If

                Next

            End If

        Next

    End Sub

    Shared Sub putUsage(ByVal FGNo As String, ByVal titleId As String, ByVal subContentId As String, ByVal Uno As Integer)

        'PUTTING ZERO USAGE TO SPECIFIC TITLE ID AND SUB CONTENT IF
        Slipknot.addParameter("parTitleId", titleId)
        Slipknot.addParameter("parSubContentId", subContentId)
        Slipknot.addParameter("parUNo", Uno)

        Slipknot.dbAED("SP_UpdateBOMReportUsageToZero")

        'CLEARING ROWS AND COLUMNS OF LAYERS FOR DATATABLES AND ADDING NEW COLUMNS
        dtLayerSRC.Rows.Clear()
        dtLayer1.Rows.Clear()
        dtLayer2.Rows.Clear()
        dtLayer3.Rows.Clear()
        dtLayer4.Rows.Clear()
        dtLayer5.Rows.Clear()
        dtLayer6.Rows.Clear()
        dtLayer7.Rows.Clear()
        dtLayer8.Rows.Clear()

        dtLayerSRC.Columns.Clear()
        dtLayer1.Columns.Clear()
        dtLayer2.Columns.Clear()
        dtLayer3.Columns.Clear()
        dtLayer4.Columns.Clear()
        dtLayer5.Columns.Clear()
        dtLayer6.Columns.Clear()
        dtLayer7.Columns.Clear()
        dtLayer8.Columns.Clear()

        dtLayerSRC.Columns.Add("itemCode")
        dtLayer1.Columns.Add("itemCode")
        dtLayer2.Columns.Add("itemCode")
        dtLayer3.Columns.Add("itemCode")
        dtLayer4.Columns.Add("itemCode")
        dtLayer5.Columns.Add("itemCode")
        dtLayer6.Columns.Add("itemCode")
        dtLayer7.Columns.Add("itemCode")
        dtLayer8.Columns.Add("itemCode")

        'PUTTING USAGE ON SRC ASSEMBLY PROCESS
        Dim dtFG As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & FGNo & "' ")

        Dim childCode As String
        Dim childUsage As String

        For Each row As DataRow In dtFG.Rows

            childCode = Convert.ToString(row("fldChildCode"))
            childUsage = Convert.ToString(row("fldUsage"))

            Dim srcRow As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldItemCode = '" & childCode & "' AND fldProcess = 'SRC ASSEMBLY' ")

            If srcRow IsNot Nothing Then

                Slipknot.addParameter("parId", srcRow("fldId"))
                Slipknot.addParameter("parUsage", childUsage)
                Slipknot.addParameter("parUNo", Uno)

                Slipknot.dbAED("SP_UpdateBOMReportUsage")

            End If

            dtLayerSRC.Rows.Add(childCode)

        Next

        'PUTTING USAGE ON LAYER 1
        For Each row As DataRow In dtLayerSRC.Rows

            Dim dtLayer1BOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & row.Item("itemCode") & "' ")

            For Each bomRow As DataRow In dtLayer1BOM.Rows

                childCode = Convert.ToString(bomRow.Item("fldChildCode"))
                childUsage = Convert.ToString(bomRow.Item("fldUsage"))

                Dim layer1Row As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldParentCode = '" & row.Item("itemCode") & "' AND fldItemCode = '" & childCode & "' AND fldLayer = 1 ")

                If layer1Row IsNot Nothing Then

                    Slipknot.addParameter("parId", layer1Row("fldId"))
                    Slipknot.addParameter("parUsage", childUsage)
                    Slipknot.addParameter("parUNo", Uno)

                    Slipknot.dbAED("SP_UpdateBOMReportUsage")

                End If

                dtLayer1.Rows.Add(childCode)

            Next

        Next

        'PUTTING USAGE ON LAYER 2
        For Each row As DataRow In dtLayer1.Rows

            Dim dtLayer2BOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & row.Item("itemCode") & "' ")

            For Each bomRow As DataRow In dtLayer2BOM.Rows

                childCode = Convert.ToString(bomRow.Item("fldChildCode"))
                childUsage = Convert.ToString(bomRow.Item("fldUsage"))

                Dim layer2Row As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldParentCode = '" & row.Item("itemCode") & "' AND fldItemCode = '" & childCode & "' AND fldLayer = 2 ")

                If layer2Row IsNot Nothing Then

                    Slipknot.addParameter("parId", layer2Row("fldId"))
                    Slipknot.addParameter("parUsage", childUsage)
                    Slipknot.addParameter("parUNo", Uno)

                    Slipknot.dbAED("SP_UpdateBOMReportUsage")

                End If

                dtLayer2.Rows.Add(childCode)

            Next

        Next

        'PUTTING USAGE ON LAYER 3
        For Each row As DataRow In dtLayer2.Rows

            Dim dtLayer3BOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & row.Item("itemCode") & "' ")

            For Each bomRow As DataRow In dtLayer3BOM.Rows

                childCode = Convert.ToString(bomRow.Item("fldChildCode"))
                childUsage = Convert.ToString(bomRow.Item("fldUsage"))

                Dim layer3Row As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldParentCode = '" & row.Item("itemCode") & "' AND fldItemCode = '" & childCode & "' AND fldLayer = 3 ")

                If layer3Row IsNot Nothing Then

                    Slipknot.addParameter("parId", layer3Row("fldId"))
                    Slipknot.addParameter("parUsage", childUsage)
                    Slipknot.addParameter("parUNo", Uno)

                    Slipknot.dbAED("SP_UpdateBOMReportUsage")

                End If

                dtLayer3.Rows.Add(childCode)

            Next

        Next

        'PUTTING USAGE ON LAYER 4
        For Each row As DataRow In dtLayer3.Rows

            Dim dtLayer4BOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & row.Item("itemCode") & "' ")

            For Each bomRow As DataRow In dtLayer4BOM.Rows

                childCode = Convert.ToString(bomRow.Item("fldChildCode"))
                childUsage = Convert.ToString(bomRow.Item("fldUsage"))

                Dim layer4Row As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldParentCode = '" & row.Item("itemCode") & "' AND fldItemCode = '" & childCode & "' AND fldLayer = 4 ")

                If layer4Row IsNot Nothing Then

                    Slipknot.addParameter("parId", layer4Row("fldId"))
                    Slipknot.addParameter("parUsage", childUsage)
                    Slipknot.addParameter("parUNo", Uno)

                    Slipknot.dbAED("SP_UpdateBOMReportUsage")

                End If

                dtLayer4.Rows.Add(childCode)

            Next

        Next

        'PUTTING USAGE ON LAYER 5
        For Each row As DataRow In dtLayer4.Rows

            Dim dtLayer5BOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & row.Item("itemCode") & "' ")

            For Each bomRow As DataRow In dtLayer5BOM.Rows

                childCode = Convert.ToString(bomRow.Item("fldChildCode"))
                childUsage = Convert.ToString(bomRow.Item("fldUsage"))

                Dim layer5Row As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldParentCode = '" & row.Item("itemCode") & "' AND fldItemCode = '" & childCode & "' AND fldLayer = 5 ")

                If layer5Row IsNot Nothing Then

                    Slipknot.addParameter("parId", layer5Row("fldId"))
                    Slipknot.addParameter("parUsage", childUsage)
                    Slipknot.addParameter("parUNo", Uno)

                    Slipknot.dbAED("SP_UpdateBOMReportUsage")

                End If

                dtLayer5.Rows.Add(childCode)

            Next

        Next

        'PUTTING USAGE ON LAYER 6
        For Each row As DataRow In dtLayer5.Rows

            Dim dtLayer6BOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & row.Item("itemCode") & "' ")

            For Each bomRow As DataRow In dtLayer6BOM.Rows

                childCode = Convert.ToString(bomRow.Item("fldChildCode"))
                childUsage = Convert.ToString(bomRow.Item("fldUsage"))

                Dim layer6Row As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldParentCode = '" & row.Item("itemCode") & "' AND fldItemCode = '" & childCode & "' AND fldLayer = 6 ")

                If layer6Row IsNot Nothing Then

                    Slipknot.addParameter("parId", layer6Row("fldId"))
                    Slipknot.addParameter("parUsage", childUsage)
                    Slipknot.addParameter("parUNo", Uno)

                    Slipknot.dbAED("SP_UpdateBOMReportUsage")

                End If

                dtLayer6.Rows.Add(childCode)

            Next

        Next

        'PUTTING USAGE ON LAYER 7
        For Each row As DataRow In dtLayer6.Rows

            Dim dtLayer7BOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & row.Item("itemCode") & "' ")

            For Each bomRow As DataRow In dtLayer7BOM.Rows

                childCode = Convert.ToString(bomRow.Item("fldChildCode"))
                childUsage = Convert.ToString(bomRow.Item("fldUsage"))

                Dim layer7Row As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldParentCode = '" & row.Item("itemCode") & "' AND fldItemCode = '" & childCode & "' AND fldLayer = 7 ")

                If layer7Row IsNot Nothing Then

                    Slipknot.addParameter("parId", layer7Row("fldId"))
                    Slipknot.addParameter("parUsage", childUsage)
                    Slipknot.addParameter("parUNo", Uno)

                    Slipknot.dbAED("SP_UpdateBOMReportUsage")

                End If

                dtLayer7.Rows.Add(childCode)

            Next

        Next

        'PUTTING USAGE ON LAYER 8
        For Each row As DataRow In dtLayer7.Rows

            Dim dtLayer8BOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & row.Item("itemCode") & "' ")

            For Each bomRow As DataRow In dtLayer8BOM.Rows

                childCode = Convert.ToString(bomRow.Item("fldChildCode"))
                childUsage = Convert.ToString(bomRow.Item("fldUsage"))

                Dim layer8Row As DataRow = Slipknot.rowSelectManual("SELECT fldId FROM tblBOMReportFinal WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldParentCode = '" & row.Item("itemCode") & "' AND fldItemCode = '" & childCode & "' AND fldLayer = 8 ")

                If layer8Row IsNot Nothing Then

                    Slipknot.addParameter("parId", layer8Row("fldId"))
                    Slipknot.addParameter("parUsage", childUsage)
                    Slipknot.addParameter("parUNo", Uno)

                    Slipknot.dbAED("SP_UpdateBOMReportUsage")

                End If

                dtLayer8.Rows.Add(childCode)

            Next

        Next

    End Sub

    Public Sub contractCostTableSec1and2(ByVal itemCode As String, ByVal customerCode As String)

        Dim rowAnnex As DataRow = Slipknot.rowSelectManual("SELECT ")



    End Sub

End Class
