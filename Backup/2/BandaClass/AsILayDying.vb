Public Class AsILayDying

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

    End Sub

    Shared Sub insertSRCAssymbly(ByVal titleId As String, ByVal subContentId As String, ByVal itemCode As String, ByVal counter As Integer)

        Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode, fldUsage FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "'")

        For Each row In dt.Rows

            Dim childCode As String = Convert.ToString(row("fldChildCode"))
            Dim usage As String = Convert.ToString(row("fldUsage"))

            Dim check As DataTable = Slipknot.dbSelectManual("SELECT fldId FROM tblBOMReportSRCAssy WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldChildCode = '" & childCode & "' ")

            If check.Rows.Count > 0 Then

                Slipknot.addParameter("parId", check.Rows(0).Item("fldId"))
                Slipknot.addParameter("parUsage", usage)
                Slipknot.addParameter("parCounter", counter)

                Slipknot.dbAED("SP_UpdateBOMReportSRCAssy")

            Else

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", itemCode)
                Slipknot.addParameter("parChildCode", childCode)

                If counter = 1 Then
                    Slipknot.addParameter("parUsage1", usage)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 2 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", usage)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 3 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", usage)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 4 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", usage)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 5 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", usage)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 6 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", usage)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 7 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", usage)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 8 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", usage)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 9 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", usage)
                    Slipknot.addParameter("parUsage10", 0)
                ElseIf counter = 10 Then
                    Slipknot.addParameter("parUsage1", 0)
                    Slipknot.addParameter("parUsage2", 0)
                    Slipknot.addParameter("parUsage3", 0)
                    Slipknot.addParameter("parUsage4", 0)
                    Slipknot.addParameter("parUsage5", 0)
                    Slipknot.addParameter("parUsage6", 0)
                    Slipknot.addParameter("parUsage7", 0)
                    Slipknot.addParameter("parUsage8", 0)
                    Slipknot.addParameter("parUsage9", 0)
                    Slipknot.addParameter("parUsage10", usage)
                End If

                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportSRCAssy")

            End If

        Next

    End Sub

    Shared Sub insertDetailsLayer1(ByVal titleId As String, ByVal subContentId As String)

        Dim dtSRCAssy As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportSRCAssy WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' ")

        Dim SRCChildCode As String
        Dim SRCU1 As String
        Dim SRCU2 As String
        Dim SRCU3 As String
        Dim SRCU4 As String
        Dim SRCU5 As String
        Dim SRCU6 As String
        Dim SRCU7 As String
        Dim SRCU8 As String
        Dim SRCU9 As String
        Dim SRCU10 As String

        For Each row As DataRow In dtSRCAssy.Rows

            SRCChildCode = Convert.ToString(row.Item("fldChildCode"))
            SRCU1 = Convert.ToString(row.Item("fldUsage1"))
            SRCU2 = Convert.ToString(row.Item("fldUsage2"))
            SRCU3 = Convert.ToString(row.Item("fldUsage3"))
            SRCU4 = Convert.ToString(row.Item("fldUsage4"))
            SRCU5 = Convert.ToString(row.Item("fldUsage5"))
            SRCU6 = Convert.ToString(row.Item("fldUsage6"))
            SRCU7 = Convert.ToString(row.Item("fldUsage7"))
            SRCU8 = Convert.ToString(row.Item("fldUsage8"))
            SRCU9 = Convert.ToString(row.Item("fldUsage9"))
            SRCU10 = Convert.ToString(row.Item("fldUsage10"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "T0.fldUsage, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & SRCChildCode & "'")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildUsage As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildUsage = Convert.ToString(row2.Item("fldUsage"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 1)
                Slipknot.addParameter("parProcess", grandChildProcess)

                If SRCU1 = 0 Then
                    Slipknot.addParameter("parUsage1", 0)
                Else
                    Slipknot.addParameter("parUsage1", grandChildUsage)
                End If

                If SRCU2 = 0 Then
                    Slipknot.addParameter("parUsage2", 0)
                Else
                    Slipknot.addParameter("parUsage2", grandChildUsage)
                End If

                If SRCU3 = 0 Then
                    Slipknot.addParameter("parUsage3", 0)
                Else
                    Slipknot.addParameter("parUsage3", grandChildUsage)
                End If

                If SRCU4 = 0 Then
                    Slipknot.addParameter("parUsage4", 0)
                Else
                    Slipknot.addParameter("parUsage4", grandChildUsage)
                End If

                If SRCU5 = 0 Then
                    Slipknot.addParameter("parUsage5", 0)
                Else
                    Slipknot.addParameter("parUsage5", grandChildUsage)
                End If

                If SRCU6 = 0 Then
                    Slipknot.addParameter("parUsage6", 0)
                Else
                    Slipknot.addParameter("parUsage6", grandChildUsage)
                End If

                If SRCU7 = 0 Then
                    Slipknot.addParameter("parUsage7", 0)
                Else
                    Slipknot.addParameter("parUsage7", grandChildUsage)
                End If

                If SRCU8 = 0 Then
                    Slipknot.addParameter("parUsage8", 0)
                Else
                    Slipknot.addParameter("parUsage8", grandChildUsage)
                End If

                If SRCU9 = 0 Then
                    Slipknot.addParameter("parUsage9", 0)
                Else
                    Slipknot.addParameter("parUsage9", grandChildUsage)
                End If

                If SRCU10 = 0 Then
                    Slipknot.addParameter("parUsage10", 0)
                Else
                    Slipknot.addParameter("parUsage10", grandChildUsage)
                End If

                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer2(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 1 GROUP BY fldChildCode ")

        Dim childCode As String
        Dim SRCU1 As String
        Dim SRCU2 As String
        Dim SRCU3 As String
        Dim SRCU4 As String
        Dim SRCU5 As String
        Dim SRCU6 As String
        Dim SRCU7 As String
        Dim SRCU8 As String
        Dim SRCU9 As String
        Dim SRCU10 As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))
            SRCU1 = Convert.ToString(row.Item("fldUsage1"))
            SRCU2 = Convert.ToString(row.Item("fldUsage2"))
            SRCU3 = Convert.ToString(row.Item("fldUsage3"))
            SRCU4 = Convert.ToString(row.Item("fldUsage4"))
            SRCU5 = Convert.ToString(row.Item("fldUsage5"))
            SRCU6 = Convert.ToString(row.Item("fldUsage6"))
            SRCU7 = Convert.ToString(row.Item("fldUsage7"))
            SRCU8 = Convert.ToString(row.Item("fldUsage8"))
            SRCU9 = Convert.ToString(row.Item("fldUsage9"))
            SRCU10 = Convert.ToString(row.Item("fldUsage10"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "T0.fldUsage, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "'")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildUsage As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildUsage = Convert.ToString(row2.Item("fldUsage"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 2)
                Slipknot.addParameter("parProcess", grandChildProcess)

                If SRCU1 = 0 Then
                    Slipknot.addParameter("parUsage1", 0)
                Else
                    Slipknot.addParameter("parUsage1", grandChildUsage)
                End If

                If SRCU2 = 0 Then
                    Slipknot.addParameter("parUsage2", 0)
                Else
                    Slipknot.addParameter("parUsage2", grandChildUsage)
                End If

                If SRCU3 = 0 Then
                    Slipknot.addParameter("parUsage3", 0)
                Else
                    Slipknot.addParameter("parUsage3", grandChildUsage)
                End If

                If SRCU4 = 0 Then
                    Slipknot.addParameter("parUsage4", 0)
                Else
                    Slipknot.addParameter("parUsage4", grandChildUsage)
                End If

                If SRCU5 = 0 Then
                    Slipknot.addParameter("parUsage5", 0)
                Else
                    Slipknot.addParameter("parUsage5", grandChildUsage)
                End If

                If SRCU6 = 0 Then
                    Slipknot.addParameter("parUsage6", 0)
                Else
                    Slipknot.addParameter("parUsage6", grandChildUsage)
                End If

                If SRCU7 = 0 Then
                    Slipknot.addParameter("parUsage7", 0)
                Else
                    Slipknot.addParameter("parUsage7", grandChildUsage)
                End If

                If SRCU8 = 0 Then
                    Slipknot.addParameter("parUsage8", 0)
                Else
                    Slipknot.addParameter("parUsage8", grandChildUsage)
                End If

                If SRCU9 = 0 Then
                    Slipknot.addParameter("parUsage9", 0)
                Else
                    Slipknot.addParameter("parUsage9", grandChildUsage)
                End If

                If SRCU10 = 0 Then
                    Slipknot.addParameter("parUsage10", 0)
                Else
                    Slipknot.addParameter("parUsage10", grandChildUsage)
                End If

                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer3(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 2 GROUP BY fldChildCode ")

        Dim childCode As String
        Dim SRCU1 As String
        Dim SRCU2 As String
        Dim SRCU3 As String
        Dim SRCU4 As String
        Dim SRCU5 As String
        Dim SRCU6 As String
        Dim SRCU7 As String
        Dim SRCU8 As String
        Dim SRCU9 As String
        Dim SRCU10 As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))
            SRCU1 = Convert.ToString(row.Item("fldUsage1"))
            SRCU2 = Convert.ToString(row.Item("fldUsage2"))
            SRCU3 = Convert.ToString(row.Item("fldUsage3"))
            SRCU4 = Convert.ToString(row.Item("fldUsage4"))
            SRCU5 = Convert.ToString(row.Item("fldUsage5"))
            SRCU6 = Convert.ToString(row.Item("fldUsage6"))
            SRCU7 = Convert.ToString(row.Item("fldUsage7"))
            SRCU8 = Convert.ToString(row.Item("fldUsage8"))
            SRCU9 = Convert.ToString(row.Item("fldUsage9"))
            SRCU10 = Convert.ToString(row.Item("fldUsage10"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "T0.fldUsage, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "'")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildUsage As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildUsage = Convert.ToString(row2.Item("fldUsage"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 3)
                Slipknot.addParameter("parProcess", grandChildProcess)

                If SRCU1 = 0 Then
                    Slipknot.addParameter("parUsage1", 0)
                Else
                    Slipknot.addParameter("parUsage1", grandChildUsage)
                End If

                If SRCU2 = 0 Then
                    Slipknot.addParameter("parUsage2", 0)
                Else
                    Slipknot.addParameter("parUsage2", grandChildUsage)
                End If

                If SRCU3 = 0 Then
                    Slipknot.addParameter("parUsage3", 0)
                Else
                    Slipknot.addParameter("parUsage3", grandChildUsage)
                End If

                If SRCU4 = 0 Then
                    Slipknot.addParameter("parUsage4", 0)
                Else
                    Slipknot.addParameter("parUsage4", grandChildUsage)
                End If

                If SRCU5 = 0 Then
                    Slipknot.addParameter("parUsage5", 0)
                Else
                    Slipknot.addParameter("parUsage5", grandChildUsage)
                End If

                If SRCU6 = 0 Then
                    Slipknot.addParameter("parUsage6", 0)
                Else
                    Slipknot.addParameter("parUsage6", grandChildUsage)
                End If

                If SRCU7 = 0 Then
                    Slipknot.addParameter("parUsage7", 0)
                Else
                    Slipknot.addParameter("parUsage7", grandChildUsage)
                End If

                If SRCU8 = 0 Then
                    Slipknot.addParameter("parUsage8", 0)
                Else
                    Slipknot.addParameter("parUsage8", grandChildUsage)
                End If

                If SRCU9 = 0 Then
                    Slipknot.addParameter("parUsage9", 0)
                Else
                    Slipknot.addParameter("parUsage9", grandChildUsage)
                End If

                If SRCU10 = 0 Then
                    Slipknot.addParameter("parUsage10", 0)
                Else
                    Slipknot.addParameter("parUsage10", grandChildUsage)
                End If

                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer4(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 3 GROUP BY fldChildCode ")

        Dim childCode As String
        Dim SRCU1 As String
        Dim SRCU2 As String
        Dim SRCU3 As String
        Dim SRCU4 As String
        Dim SRCU5 As String
        Dim SRCU6 As String
        Dim SRCU7 As String
        Dim SRCU8 As String
        Dim SRCU9 As String
        Dim SRCU10 As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))
            SRCU1 = Convert.ToString(row.Item("fldUsage1"))
            SRCU2 = Convert.ToString(row.Item("fldUsage2"))
            SRCU3 = Convert.ToString(row.Item("fldUsage3"))
            SRCU4 = Convert.ToString(row.Item("fldUsage4"))
            SRCU5 = Convert.ToString(row.Item("fldUsage5"))
            SRCU6 = Convert.ToString(row.Item("fldUsage6"))
            SRCU7 = Convert.ToString(row.Item("fldUsage7"))
            SRCU8 = Convert.ToString(row.Item("fldUsage8"))
            SRCU9 = Convert.ToString(row.Item("fldUsage9"))
            SRCU10 = Convert.ToString(row.Item("fldUsage10"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "T0.fldUsage, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "'")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildUsage As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildUsage = Convert.ToString(row2.Item("fldUsage"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 4)
                Slipknot.addParameter("parProcess", grandChildProcess)

                If SRCU1 = 0 Then
                    Slipknot.addParameter("parUsage1", 0)
                Else
                    Slipknot.addParameter("parUsage1", grandChildUsage)
                End If

                If SRCU2 = 0 Then
                    Slipknot.addParameter("parUsage2", 0)
                Else
                    Slipknot.addParameter("parUsage2", grandChildUsage)
                End If

                If SRCU3 = 0 Then
                    Slipknot.addParameter("parUsage3", 0)
                Else
                    Slipknot.addParameter("parUsage3", grandChildUsage)
                End If

                If SRCU4 = 0 Then
                    Slipknot.addParameter("parUsage4", 0)
                Else
                    Slipknot.addParameter("parUsage4", grandChildUsage)
                End If

                If SRCU5 = 0 Then
                    Slipknot.addParameter("parUsage5", 0)
                Else
                    Slipknot.addParameter("parUsage5", grandChildUsage)
                End If

                If SRCU6 = 0 Then
                    Slipknot.addParameter("parUsage6", 0)
                Else
                    Slipknot.addParameter("parUsage6", grandChildUsage)
                End If

                If SRCU7 = 0 Then
                    Slipknot.addParameter("parUsage7", 0)
                Else
                    Slipknot.addParameter("parUsage7", grandChildUsage)
                End If

                If SRCU8 = 0 Then
                    Slipknot.addParameter("parUsage8", 0)
                Else
                    Slipknot.addParameter("parUsage8", grandChildUsage)
                End If

                If SRCU9 = 0 Then
                    Slipknot.addParameter("parUsage9", 0)
                Else
                    Slipknot.addParameter("parUsage9", grandChildUsage)
                End If

                If SRCU10 = 0 Then
                    Slipknot.addParameter("parUsage10", 0)
                Else
                    Slipknot.addParameter("parUsage10", grandChildUsage)
                End If

                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer5(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 4 GROUP BY fldChildCode ")

        Dim childCode As String
        Dim SRCU1 As String
        Dim SRCU2 As String
        Dim SRCU3 As String
        Dim SRCU4 As String
        Dim SRCU5 As String
        Dim SRCU6 As String
        Dim SRCU7 As String
        Dim SRCU8 As String
        Dim SRCU9 As String
        Dim SRCU10 As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))
            SRCU1 = Convert.ToString(row.Item("fldUsage1"))
            SRCU2 = Convert.ToString(row.Item("fldUsage2"))
            SRCU3 = Convert.ToString(row.Item("fldUsage3"))
            SRCU4 = Convert.ToString(row.Item("fldUsage4"))
            SRCU5 = Convert.ToString(row.Item("fldUsage5"))
            SRCU6 = Convert.ToString(row.Item("fldUsage6"))
            SRCU7 = Convert.ToString(row.Item("fldUsage7"))
            SRCU8 = Convert.ToString(row.Item("fldUsage8"))
            SRCU9 = Convert.ToString(row.Item("fldUsage9"))
            SRCU10 = Convert.ToString(row.Item("fldUsage10"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "T0.fldUsage, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "'")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildUsage As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildUsage = Convert.ToString(row2.Item("fldUsage"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 5)
                Slipknot.addParameter("parProcess", grandChildProcess)

                If SRCU1 = 0 Then
                    Slipknot.addParameter("parUsage1", 0)
                Else
                    Slipknot.addParameter("parUsage1", grandChildUsage)
                End If

                If SRCU2 = 0 Then
                    Slipknot.addParameter("parUsage2", 0)
                Else
                    Slipknot.addParameter("parUsage2", grandChildUsage)
                End If

                If SRCU3 = 0 Then
                    Slipknot.addParameter("parUsage3", 0)
                Else
                    Slipknot.addParameter("parUsage3", grandChildUsage)
                End If

                If SRCU4 = 0 Then
                    Slipknot.addParameter("parUsage4", 0)
                Else
                    Slipknot.addParameter("parUsage4", grandChildUsage)
                End If

                If SRCU5 = 0 Then
                    Slipknot.addParameter("parUsage5", 0)
                Else
                    Slipknot.addParameter("parUsage5", grandChildUsage)
                End If

                If SRCU6 = 0 Then
                    Slipknot.addParameter("parUsage6", 0)
                Else
                    Slipknot.addParameter("parUsage6", grandChildUsage)
                End If

                If SRCU7 = 0 Then
                    Slipknot.addParameter("parUsage7", 0)
                Else
                    Slipknot.addParameter("parUsage7", grandChildUsage)
                End If

                If SRCU8 = 0 Then
                    Slipknot.addParameter("parUsage8", 0)
                Else
                    Slipknot.addParameter("parUsage8", grandChildUsage)
                End If

                If SRCU9 = 0 Then
                    Slipknot.addParameter("parUsage9", 0)
                Else
                    Slipknot.addParameter("parUsage9", grandChildUsage)
                End If

                If SRCU10 = 0 Then
                    Slipknot.addParameter("parUsage10", 0)
                Else
                    Slipknot.addParameter("parUsage10", grandChildUsage)
                End If

                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer6(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 5 GROUP BY fldChildCode ")

        Dim childCode As String
        Dim SRCU1 As String
        Dim SRCU2 As String
        Dim SRCU3 As String
        Dim SRCU4 As String
        Dim SRCU5 As String
        Dim SRCU6 As String
        Dim SRCU7 As String
        Dim SRCU8 As String
        Dim SRCU9 As String
        Dim SRCU10 As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))
            SRCU1 = Convert.ToString(row.Item("fldUsage1"))
            SRCU2 = Convert.ToString(row.Item("fldUsage2"))
            SRCU3 = Convert.ToString(row.Item("fldUsage3"))
            SRCU4 = Convert.ToString(row.Item("fldUsage4"))
            SRCU5 = Convert.ToString(row.Item("fldUsage5"))
            SRCU6 = Convert.ToString(row.Item("fldUsage6"))
            SRCU7 = Convert.ToString(row.Item("fldUsage7"))
            SRCU8 = Convert.ToString(row.Item("fldUsage8"))
            SRCU9 = Convert.ToString(row.Item("fldUsage9"))
            SRCU10 = Convert.ToString(row.Item("fldUsage10"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "T0.fldUsage, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "'")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildUsage As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildUsage = Convert.ToString(row2.Item("fldUsage"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 6)
                Slipknot.addParameter("parProcess", grandChildProcess)

                If SRCU1 = 0 Then
                    Slipknot.addParameter("parUsage1", 0)
                Else
                    Slipknot.addParameter("parUsage1", grandChildUsage)
                End If

                If SRCU2 = 0 Then
                    Slipknot.addParameter("parUsage2", 0)
                Else
                    Slipknot.addParameter("parUsage2", grandChildUsage)
                End If

                If SRCU3 = 0 Then
                    Slipknot.addParameter("parUsage3", 0)
                Else
                    Slipknot.addParameter("parUsage3", grandChildUsage)
                End If

                If SRCU4 = 0 Then
                    Slipknot.addParameter("parUsage4", 0)
                Else
                    Slipknot.addParameter("parUsage4", grandChildUsage)
                End If

                If SRCU5 = 0 Then
                    Slipknot.addParameter("parUsage5", 0)
                Else
                    Slipknot.addParameter("parUsage5", grandChildUsage)
                End If

                If SRCU6 = 0 Then
                    Slipknot.addParameter("parUsage6", 0)
                Else
                    Slipknot.addParameter("parUsage6", grandChildUsage)
                End If

                If SRCU7 = 0 Then
                    Slipknot.addParameter("parUsage7", 0)
                Else
                    Slipknot.addParameter("parUsage7", grandChildUsage)
                End If

                If SRCU8 = 0 Then
                    Slipknot.addParameter("parUsage8", 0)
                Else
                    Slipknot.addParameter("parUsage8", grandChildUsage)
                End If

                If SRCU9 = 0 Then
                    Slipknot.addParameter("parUsage9", 0)
                Else
                    Slipknot.addParameter("parUsage9", grandChildUsage)
                End If

                If SRCU10 = 0 Then
                    Slipknot.addParameter("parUsage10", 0)
                Else
                    Slipknot.addParameter("parUsage10", grandChildUsage)
                End If

                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer7(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 6 GROUP BY fldChildCode ")

        Dim childCode As String
        Dim SRCU1 As String
        Dim SRCU2 As String
        Dim SRCU3 As String
        Dim SRCU4 As String
        Dim SRCU5 As String
        Dim SRCU6 As String
        Dim SRCU7 As String
        Dim SRCU8 As String
        Dim SRCU9 As String
        Dim SRCU10 As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))
            SRCU1 = Convert.ToString(row.Item("fldUsage1"))
            SRCU2 = Convert.ToString(row.Item("fldUsage2"))
            SRCU3 = Convert.ToString(row.Item("fldUsage3"))
            SRCU4 = Convert.ToString(row.Item("fldUsage4"))
            SRCU5 = Convert.ToString(row.Item("fldUsage5"))
            SRCU6 = Convert.ToString(row.Item("fldUsage6"))
            SRCU7 = Convert.ToString(row.Item("fldUsage7"))
            SRCU8 = Convert.ToString(row.Item("fldUsage8"))
            SRCU9 = Convert.ToString(row.Item("fldUsage9"))
            SRCU10 = Convert.ToString(row.Item("fldUsage10"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "T0.fldUsage, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "'")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildUsage As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildUsage = Convert.ToString(row2.Item("fldUsage"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 7)
                Slipknot.addParameter("parProcess", grandChildProcess)

                If SRCU1 = 0 Then
                    Slipknot.addParameter("parUsage1", 0)
                Else
                    Slipknot.addParameter("parUsage1", grandChildUsage)
                End If

                If SRCU2 = 0 Then
                    Slipknot.addParameter("parUsage2", 0)
                Else
                    Slipknot.addParameter("parUsage2", grandChildUsage)
                End If

                If SRCU3 = 0 Then
                    Slipknot.addParameter("parUsage3", 0)
                Else
                    Slipknot.addParameter("parUsage3", grandChildUsage)
                End If

                If SRCU4 = 0 Then
                    Slipknot.addParameter("parUsage4", 0)
                Else
                    Slipknot.addParameter("parUsage4", grandChildUsage)
                End If

                If SRCU5 = 0 Then
                    Slipknot.addParameter("parUsage5", 0)
                Else
                    Slipknot.addParameter("parUsage5", grandChildUsage)
                End If

                If SRCU6 = 0 Then
                    Slipknot.addParameter("parUsage6", 0)
                Else
                    Slipknot.addParameter("parUsage6", grandChildUsage)
                End If

                If SRCU7 = 0 Then
                    Slipknot.addParameter("parUsage7", 0)
                Else
                    Slipknot.addParameter("parUsage7", grandChildUsage)
                End If

                If SRCU8 = 0 Then
                    Slipknot.addParameter("parUsage8", 0)
                Else
                    Slipknot.addParameter("parUsage8", grandChildUsage)
                End If

                If SRCU9 = 0 Then
                    Slipknot.addParameter("parUsage9", 0)
                Else
                    Slipknot.addParameter("parUsage9", grandChildUsage)
                End If

                If SRCU10 = 0 Then
                    Slipknot.addParameter("parUsage10", 0)
                Else
                    Slipknot.addParameter("parUsage10", grandChildUsage)
                End If

                Slipknot.addParameter("parRemarks", "")
                Slipknot.addParameter("parMaker", "")
                Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))

                Slipknot.dbAED("SP_InsertBOMReportDetails")

            Next

        Next

    End Sub

    Shared Sub insertDetailsLayer8(ByVal titleId As String, ByVal subContentId As String)

        Dim dtDetailsLayer1 As DataTable = Slipknot.dbSelectManual("SELECT * FROM tblBOMReportD WHERE fldTitleId = '" & titleId & "' AND fldSubContentId = '" & subContentId & "' AND fldLayer = 7 GROUP BY fldChildCode ")

        Dim childCode As String
        Dim SRCU1 As String
        Dim SRCU2 As String
        Dim SRCU3 As String
        Dim SRCU4 As String
        Dim SRCU5 As String
        Dim SRCU6 As String
        Dim SRCU7 As String
        Dim SRCU8 As String
        Dim SRCU9 As String
        Dim SRCU10 As String

        For Each row As DataRow In dtDetailsLayer1.Rows

            childCode = Convert.ToString(row.Item("fldChildCode"))
            SRCU1 = Convert.ToString(row.Item("fldUsage1"))
            SRCU2 = Convert.ToString(row.Item("fldUsage2"))
            SRCU3 = Convert.ToString(row.Item("fldUsage3"))
            SRCU4 = Convert.ToString(row.Item("fldUsage4"))
            SRCU5 = Convert.ToString(row.Item("fldUsage5"))
            SRCU6 = Convert.ToString(row.Item("fldUsage6"))
            SRCU7 = Convert.ToString(row.Item("fldUsage7"))
            SRCU8 = Convert.ToString(row.Item("fldUsage8"))
            SRCU9 = Convert.ToString(row.Item("fldUsage9"))
            SRCU10 = Convert.ToString(row.Item("fldUsage10"))

            Dim dtGrandChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                                  & "T0.fldParentCode, " _
                                                                  & "T0.fldChildCode, " _
                                                                  & "T0.fldUsage, " _
                                                                  & "(SELECT fldProcessName FROM tblProcess WHERE fldCode = T1.fldProcessCode) AS processName " _
                                                                  & "FROM " _
                                                                  & "tblBOMMaster T0 " _
                                                                  & "LEFT JOIN " _
                                                                  & "tblItemProcess T1 ON (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldParentCode LIMIT 1) = T1.fldItemCode " _
                                                                  & "WHERE " _
                                                                  & "T0.fldParentCode = '" & childCode & "'")

            Dim grandChildParent As String
            Dim grandChildItemCode As String
            Dim grandChildUsage As String
            Dim grandChildProcess As String

            For Each row2 As DataRow In dtGrandChild.Rows

                grandChildParent = Convert.ToString(row2.Item("fldParentCode"))
                grandChildItemCode = Convert.ToString(row2.Item("fldChildCode"))
                grandChildUsage = Convert.ToString(row2.Item("fldUsage"))
                grandChildProcess = Convert.ToString(row2.Item("processName"))

                Slipknot.addParameter("parTitleId", titleId)
                Slipknot.addParameter("parSubContentId", subContentId)
                Slipknot.addParameter("parParentCode", grandChildParent)
                Slipknot.addParameter("parChildCode", grandChildItemCode)
                Slipknot.addParameter("parLayer", 8)
                Slipknot.addParameter("parProcess", grandChildProcess)

                If SRCU1 = 0 Then
                    Slipknot.addParameter("parUsage1", 0)
                Else
                    Slipknot.addParameter("parUsage1", grandChildUsage)
                End If

                If SRCU2 = 0 Then
                    Slipknot.addParameter("parUsage2", 0)
                Else
                    Slipknot.addParameter("parUsage2", grandChildUsage)
                End If

                If SRCU3 = 0 Then
                    Slipknot.addParameter("parUsage3", 0)
                Else
                    Slipknot.addParameter("parUsage3", grandChildUsage)
                End If

                If SRCU4 = 0 Then
                    Slipknot.addParameter("parUsage4", 0)
                Else
                    Slipknot.addParameter("parUsage4", grandChildUsage)
                End If

                If SRCU5 = 0 Then
                    Slipknot.addParameter("parUsage5", 0)
                Else
                    Slipknot.addParameter("parUsage5", grandChildUsage)
                End If

                If SRCU6 = 0 Then
                    Slipknot.addParameter("parUsage6", 0)
                Else
                    Slipknot.addParameter("parUsage6", grandChildUsage)
                End If

                If SRCU7 = 0 Then
                    Slipknot.addParameter("parUsage7", 0)
                Else
                    Slipknot.addParameter("parUsage7", grandChildUsage)
                End If

                If SRCU8 = 0 Then
                    Slipknot.addParameter("parUsage8", 0)
                Else
                    Slipknot.addParameter("parUsage8", grandChildUsage)
                End If

                If SRCU9 = 0 Then
                    Slipknot.addParameter("parUsage9", 0)
                Else
                    Slipknot.addParameter("parUsage9", grandChildUsage)
                End If

                If SRCU10 = 0 Then
                    Slipknot.addParameter("parUsage10", 0)
                Else
                    Slipknot.addParameter("parUsage10", grandChildUsage)
                End If

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
        Dim parentUsage1 As String
        Dim parentUsage2 As String
        Dim parentUsage3 As String
        Dim parentUsage4 As String
        Dim parentUsage5 As String
        Dim parentUsage6 As String
        Dim parentUsage7 As String
        Dim parentUsage8 As String
        Dim parentUsage9 As String
        Dim parentUsage10 As String

        For Each row As DataRow In dtHeader.Rows

            parentItemCode = Convert.ToString(row.Item("fldChildCode"))
            parentUsage1 = Convert.ToString(row.Item("fldUsage1"))
            parentUsage2 = Convert.ToString(row.Item("fldUsage2"))
            parentUsage3 = Convert.ToString(row.Item("fldUsage3"))
            parentUsage4 = Convert.ToString(row.Item("fldUsage4"))
            parentUsage5 = Convert.ToString(row.Item("fldUsage5"))
            parentUsage6 = Convert.ToString(row.Item("fldUsage6"))
            parentUsage7 = Convert.ToString(row.Item("fldUsage7"))
            parentUsage8 = Convert.ToString(row.Item("fldUsage8"))
            parentUsage9 = Convert.ToString(row.Item("fldUsage9"))
            parentUsage10 = Convert.ToString(row.Item("fldUsage10"))


            Slipknot.addParameter("parTitleId", titleId)
            Slipknot.addParameter("parSubContentId", subContentId)
            Slipknot.addParameter("parParentCode", parentItemCode)
            Slipknot.addParameter("parItemCode", parentItemCode)
            Slipknot.addParameter("parProcess", "SRC ASSEMBLY")
            Slipknot.addParameter("parProcessPriority", 0)
            Slipknot.addParameter("parProcessColor", "LightBlue")
            Slipknot.addParameter("parClass", 0)
            Slipknot.addParameter("parAddedBy", currentUser.Item("fldUsername"))
            Slipknot.addParameter("parU1", parentUsage1)
            Slipknot.addParameter("parU2", parentUsage2)
            Slipknot.addParameter("parU3", parentUsage3)
            Slipknot.addParameter("parU4", parentUsage4)
            Slipknot.addParameter("parU5", parentUsage5)
            Slipknot.addParameter("parU6", parentUsage6)
            Slipknot.addParameter("parU7", parentUsage7)
            Slipknot.addParameter("parU8", parentUsage8)
            Slipknot.addParameter("parU9", parentUsage9)
            Slipknot.addParameter("parU10", parentUsage10)
            Slipknot.addParameter("parLayer", 0)

            Slipknot.dbAED("SP_InsertBOMReportFinal")

        Next


        Dim dtDetails As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                    & "T0.fldProcess, " _
                                                    & "T0.fldParentCode, " _
                                                    & "T0.fldLayer, " _
                                                    & "T1.fldPriority, " _
                                                    & "T1.fldColor " _
                                                    & "FROM " _
                                                    & "tblBOMReportD T0 " _
                                                    & "LEFT JOIN " _
                                                    & "tblProcess T1 ON T0.fldProcess = T1.fldProcessName " _
                                                    & "WHERE " _
                                                    & "T0.fldTitleId = '" & titleId & "' AND T0.fldSubContentId = '" & subContentId & "' " _
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
            Slipknot.addParameter("parU1", "")
            Slipknot.addParameter("parU2", "")
            Slipknot.addParameter("parU3", "")
            Slipknot.addParameter("parU4", "")
            Slipknot.addParameter("parU5", "")
            Slipknot.addParameter("parU6", "")
            Slipknot.addParameter("parU7", "")
            Slipknot.addParameter("parU8", "")
            Slipknot.addParameter("parU9", "")
            Slipknot.addParameter("parU10", "")
            Slipknot.addParameter("parLayer", parentLayer)

            If Slipknot.dbAED("SP_InsertBOMReportFinal") Then

                Dim dtChild As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                              & "T0.fldParentCode, " _
                                                              & "T0.fldChildCode, " _
                                                              & "T0.fldLayer, " _
                                                              & "T0.fldProcess, " _
                                                              & "T0.fldUsage1, " _
                                                              & "T0.fldUsage2, " _
                                                              & "T0.fldUsage3, " _
                                                              & "T0.fldUsage4, " _
                                                              & "T0.fldUsage5, " _
                                                              & "T0.fldUsage6, " _
                                                              & "T0.fldUsage7, " _
                                                              & "T0.fldUsage8, " _
                                                              & "T0.fldUsage9, " _
                                                              & "T0.fldUsage10, " _
                                                              & "T0.fldMaker, " _
                                                              & "T0.fldRemarks, " _
                                                              & "T1.fldPriority, " _
                                                              & "T1.fldColor " _
                                                              & "FROM " _
                                                              & "tblBOMReportD T0 " _
                                                              & "LEFT JOIN " _
                                                              & "tblProcess T1 ON T0.fldProcess = T1.fldProcessName " _
                                                              & "WHERE " _
                                                              & "T0.fldTitleId = '" & titleId & "' AND T0.fldSubContentId = '" & subContentId & "' AND T0.fldParentCode = '" & parentCode & "' " _
                                                              & "GROUP BY T0.fldParentCode, T0.fldChildCode, T0.fldProcess")

                Dim childParentCode As String
                Dim childCode As String
                Dim childProcess As String
                Dim childProcessPriority As Integer
                Dim childProcessColor As String
                Dim childUsage1 As String
                Dim childUsage2 As String
                Dim childUsage3 As String
                Dim childUsage4 As String
                Dim childUsage5 As String
                Dim childUsage6 As String
                Dim childUsage7 As String
                Dim childUsage8 As String
                Dim childUsage9 As String
                Dim childUsage10 As String
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

                    childUsage1 = Convert.ToString(row2.Item("fldUsage1"))
                    childUsage2 = Convert.ToString(row2.Item("fldUsage2"))
                    childUsage3 = Convert.ToString(row2.Item("fldUsage3"))
                    childUsage4 = Convert.ToString(row2.Item("fldUsage4"))
                    childUsage5 = Convert.ToString(row2.Item("fldUsage5"))
                    childUsage6 = Convert.ToString(row2.Item("fldUsage6"))
                    childUsage7 = Convert.ToString(row2.Item("fldUsage7"))
                    childUsage8 = Convert.ToString(row2.Item("fldUsage8"))
                    childUsage9 = Convert.ToString(row2.Item("fldUsage9"))
                    childUsage10 = Convert.ToString(row2.Item("fldUsage10"))

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
                    Slipknot.addParameter("parU1", childUsage1)
                    Slipknot.addParameter("parU2", childUsage2)
                    Slipknot.addParameter("parU3", childUsage3)
                    Slipknot.addParameter("parU4", childUsage4)
                    Slipknot.addParameter("parU5", childUsage5)
                    Slipknot.addParameter("parU6", childUsage6)
                    Slipknot.addParameter("parU7", childUsage7)
                    Slipknot.addParameter("parU8", childUsage8)
                    Slipknot.addParameter("parU9", childUsage9)
                    Slipknot.addParameter("parU10", childUsage10)
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

    Shared Function GetBOM(ByVal parentCode As String) As DataTable

        Dim BOM As New DataTable

        BOM.Columns.Add("fldParentCode", GetType(String))
        BOM.Columns.Add("fldChildCode", GetType(String))
        BOM.Columns.Add("fldUsage", GetType(String))
        BOM.Columns.Add("fldRemarks", GetType(String))
        BOM.Columns.Add("fldLayer", GetType(String))

        Dim dtLayer1 As New DataTable
        dtLayer1.Columns.Add("fldChildCode", GetType(String))

        Dim dtLayer2 As New DataTable
        dtLayer2.Columns.Add("fldChildCode", GetType(String))

        Dim dtLayer3 As New DataTable
        dtLayer3.Columns.Add("fldChildCode", GetType(String))

        Dim dtLayer4 As New DataTable
        dtLayer4.Columns.Add("fldChildCode", GetType(String))

        Dim dtLayer5 As New DataTable
        dtLayer5.Columns.Add("fldChildCode", GetType(String))

        Dim dtLayer6 As New DataTable
        dtLayer6.Columns.Add("fldChildCode", GetType(String))

        Dim dtLayer7 As New DataTable
        dtLayer7.Columns.Add("fldChildCode", GetType(String))

        Dim dtLayer8 As New DataTable
        dtLayer8.Columns.Add("fldChildCode", GetType(String))

        Dim dtMain As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & parentCode & "' ")

        Dim fldParentCode As String
        Dim fldChildCode As String
        Dim fldUsage As String
        Dim fldRemarks As String

        For Each row As DataRow In dtMain.Rows '1ST LOOP

            fldParentCode = String.Empty
            fldChildCode = String.Empty
            fldUsage = String.Empty
            fldRemarks = String.Empty

            fldParentCode = Convert.ToString(row.Item("fldParentCode"))
            fldChildCode = Convert.ToString(row.Item("fldChildCode"))
            fldUsage = Convert.ToString(row.Item("fldUsage"))
            fldRemarks = Convert.ToString(row.Item("fldRemarks"))

            BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 1)
            dtLayer1.Rows.Add(fldChildCode)

        Next

        For Each row As DataRow In dtLayer1.Rows '2ND LOOP

            Dim itemCode As String = Convert.ToString(row.Item("fldChildCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each childRow As DataRow In dt.Rows

                fldParentCode = String.Empty
                fldChildCode = String.Empty
                fldUsage = String.Empty
                fldRemarks = String.Empty

                fldParentCode = Convert.ToString(childRow.Item("fldParentCode"))
                fldChildCode = Convert.ToString(childRow.Item("fldChildCode"))
                fldUsage = Convert.ToString(childRow.Item("fldUsage"))
                fldRemarks = Convert.ToString(childRow.Item("fldRemarks"))

                BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 2)
                dtLayer2.Rows.Add(fldChildCode)

            Next

        Next

        For Each row As DataRow In dtLayer2.Rows '3RD LOOP

            Dim itemCode As String = Convert.ToString(row.Item("fldChildCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each childRow As DataRow In dt.Rows

                fldParentCode = String.Empty
                fldChildCode = String.Empty
                fldUsage = String.Empty
                fldRemarks = String.Empty

                fldParentCode = Convert.ToString(childRow.Item("fldParentCode"))
                fldChildCode = Convert.ToString(childRow.Item("fldChildCode"))
                fldUsage = Convert.ToString(childRow.Item("fldUsage"))
                fldRemarks = Convert.ToString(childRow.Item("fldRemarks"))

                BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 3)
                dtLayer3.Rows.Add(fldChildCode)

            Next

        Next

        For Each row As DataRow In dtLayer3.Rows '4TH LOOP

            Dim itemCode As String = Convert.ToString(row.Item("fldChildCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each childRow As DataRow In dt.Rows

                fldParentCode = String.Empty
                fldChildCode = String.Empty
                fldUsage = String.Empty
                fldRemarks = String.Empty

                fldParentCode = Convert.ToString(childRow.Item("fldParentCode"))
                fldChildCode = Convert.ToString(childRow.Item("fldChildCode"))
                fldUsage = Convert.ToString(childRow.Item("fldUsage"))
                fldRemarks = Convert.ToString(childRow.Item("fldRemarks"))

                BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 4)
                dtLayer4.Rows.Add(fldChildCode)

            Next

        Next

        For Each row As DataRow In dtLayer4.Rows '5TH LOOP

            Dim itemCode As String = Convert.ToString(row.Item("fldChildCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each childRow As DataRow In dt.Rows

                fldParentCode = String.Empty
                fldChildCode = String.Empty
                fldUsage = String.Empty
                fldRemarks = String.Empty

                fldParentCode = Convert.ToString(childRow.Item("fldParentCode"))
                fldChildCode = Convert.ToString(childRow.Item("fldChildCode"))
                fldUsage = Convert.ToString(childRow.Item("fldUsage"))
                fldRemarks = Convert.ToString(childRow.Item("fldRemarks"))

                BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 5)
                dtLayer5.Rows.Add(fldChildCode)

            Next

        Next

        For Each row As DataRow In dtLayer5.Rows '6TH LOOP

            Dim itemCode As String = Convert.ToString(row.Item("fldChildCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each childRow As DataRow In dt.Rows

                fldParentCode = String.Empty
                fldChildCode = String.Empty
                fldUsage = String.Empty
                fldRemarks = String.Empty

                fldParentCode = Convert.ToString(childRow.Item("fldParentCode"))
                fldChildCode = Convert.ToString(childRow.Item("fldChildCode"))
                fldUsage = Convert.ToString(childRow.Item("fldUsage"))
                fldRemarks = Convert.ToString(childRow.Item("fldRemarks"))

                BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 6)
                dtLayer6.Rows.Add(fldChildCode)

            Next

        Next

        For Each row As DataRow In dtLayer6.Rows '7TH LOOP

            Dim itemCode As String = Convert.ToString(row.Item("fldChildCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each childRow As DataRow In dt.Rows

                fldParentCode = String.Empty
                fldChildCode = String.Empty
                fldUsage = String.Empty
                fldRemarks = String.Empty

                fldParentCode = Convert.ToString(childRow.Item("fldParentCode"))
                fldChildCode = Convert.ToString(childRow.Item("fldChildCode"))
                fldUsage = Convert.ToString(childRow.Item("fldUsage"))
                fldRemarks = Convert.ToString(childRow.Item("fldRemarks"))

                BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 7)
                dtLayer7.Rows.Add(fldChildCode)

            Next

        Next

        For Each row As DataRow In dtLayer7.Rows '8TH LOOP

            Dim itemCode As String = Convert.ToString(row.Item("fldChildCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each childRow As DataRow In dt.Rows

                fldParentCode = String.Empty
                fldChildCode = String.Empty
                fldUsage = String.Empty
                fldRemarks = String.Empty

                fldParentCode = Convert.ToString(childRow.Item("fldParentCode"))
                fldChildCode = Convert.ToString(childRow.Item("fldChildCode"))
                fldUsage = Convert.ToString(childRow.Item("fldUsage"))
                fldRemarks = Convert.ToString(childRow.Item("fldRemarks"))

                BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 8)
                dtLayer8.Rows.Add(fldChildCode)

            Next

        Next

        For Each row As DataRow In dtLayer8.Rows '9TH LOOP

            Dim itemCode As String = Convert.ToString(row.Item("fldChildCode"))

            Dim dt As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode, fldUsage, fldRemarks FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

            For Each childRow As DataRow In dt.Rows

                fldParentCode = String.Empty
                fldChildCode = String.Empty
                fldUsage = String.Empty
                fldRemarks = String.Empty

                fldParentCode = Convert.ToString(childRow.Item("fldParentCode"))
                fldChildCode = Convert.ToString(childRow.Item("fldChildCode"))
                fldUsage = Convert.ToString(childRow.Item("fldUsage"))
                fldRemarks = Convert.ToString(childRow.Item("fldRemarks"))

                BOM.Rows.Add(fldParentCode, fldChildCode, fldUsage, fldRemarks, 9)

            Next

        Next

        Dim result = (From T0 In BOM.AsEnumerable
                      Group By Keys = New With
                              {
                                Key .fldParentCode = T0.Field(Of String)("fldParentCode"),
                                Key .fldChildCode = T0.Field(Of String)("fldChildCode"),
                                Key .fldUsage = T0.Field(Of String)("fldUsage")
                              } Into T0G = Group
                      Select New With
                                  {
                        .fldParentCode = Keys.fldParentCode,
                        .fldChildCode = Keys.fldChildCode,
                        .fldUsage = Keys.fldUsage
                      }).ToList

        Dim finalBOM As DataTable = Slipknot.convertToDatatable(result)

        Return finalBOM
    End Function

    Shared Function getItemSpecs(ByVal itemCode As String, ByVal effectivityDate As Date) As DataRow

        getItemSpecs = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & itemCode & "' ")

        If getItemSpecs IsNot Nothing Then
            getItemSpecs = Slipknot.rowSelectManual("SELECT * FROM tblItemSpecs WHERE fldItemCode = '" & Convert.ToString(getItemSpecs.Item("fldItemCode")) & "' AND fldEffectivityDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldEffectivityDate DESC")
        Else
            getItemSpecs = Slipknot.rowSelectManual("SELECT * FROM tblItemSpecs WHERE fldItemCode = '" & itemCode & "' AND fldEffectivityDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldEffectivityDate DESC")
        End If

        Return getItemSpecs

    End Function

    Shared Function getOrigUnitPrice(ByVal itemCode As String, ByVal effectivityDate As Date) As Decimal

        Dim unitPrice As Decimal = 0
        Dim finalItemCode As String

        Dim getItem As DataRow

        getItem = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & itemCode & "' ")

        If getItem IsNot Nothing Then
            finalItemCode = Convert.ToString(getItem.Item("fldItemCode"))
        Else
            finalItemCode = itemCode
        End If

        getItem = Slipknot.rowSelectManual("SELECT fldCategory FROM tblItemMasterData WHERE fldItemCode = '" & finalItemCode & "' ")

        If getItem IsNot Nothing Then

            If Convert.ToString(getItem.Item("fldCategory")) = "RM" Then

                getItem = Slipknot.rowSelectManual("SELECT fldPrice, fldCurrency FROM tblRMPriceMaster WHERE fldItemCode = '" & itemCode & "' AND fldEffectivityDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldEffectivityDate DESC ")

                If getItem IsNot Nothing Then

                    unitPrice = Convert.ToDecimal(getItem.Item("fldPrice"))

                End If

            Else

                Dim dtBOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

                For Each row As DataRow In dtBOM.Rows

                    getItem = Slipknot.rowSelectManual("SELECT fldPrice, fldCurrency FROM tblRMPriceMaster WHERE fldItemCode = '" & Convert.ToString(row.Item("fldChildCode")) & "' AND fldEffectivityDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldEffectivityDate DESC ")

                    If getItem IsNot Nothing Then

                        unitPrice = unitPrice + (Convert.ToDecimal(getItem.Item("fldPrice")))

                    End If

                Next

            End If

        End If


        Return unitPrice

    End Function

    Shared Function getUnitPriceJPY(ByVal itemCode As String, ByVal effectivityDate As Date) As Decimal

        Dim unitPrice As Decimal = 0
        Dim finalItemCode As String
        Dim conversionRate As Decimal = 0

        Dim getConversionRate As DataRow = Nothing
        Dim getItem As DataRow

        getItem = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & itemCode & "' ")

        If getItem IsNot Nothing Then
            finalItemCode = Convert.ToString(getItem.Item("fldItemCode"))
        Else
            finalItemCode = itemCode
        End If

        getItem = Slipknot.rowSelectManual("SELECT fldCategory FROM tblItemMasterData WHERE fldItemCode = '" & finalItemCode & "' ")

        If getItem IsNot Nothing Then

            If Convert.ToString(getItem.Item("fldCategory")) = "RM" Then

                getItem = Slipknot.rowSelectManual("SELECT fldPrice, fldCurrency FROM tblRMPriceMaster WHERE fldItemCode = '" & itemCode & "' AND fldEffectivityDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldEffectivityDate DESC ")

                If getItem IsNot Nothing Then

                    Select Case Convert.ToString(getItem.Item("fldCurrency"))
                        Case "USD"
                            getConversionRate = Slipknot.rowSelectManual("SELECT fldRate FROM tblConversionRate WHERE fldCurrency = 'USD' AND fldDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldDate DESC ")

                            If getConversionRate IsNot Nothing Then

                                conversionRate = Convert.ToDecimal(getConversionRate.Item("fldRate"))

                                unitPrice = Convert.ToDecimal(getItem.Item("fldPrice")) * conversionRate

                            End If

                        Case "PHP"
                            getConversionRate = Slipknot.rowSelectManual("SELECT fldRate FROM tblConversionRate WHERE fldCurrency = 'PHP' AND fldDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldDate DESC ")

                            If getConversionRate IsNot Nothing Then

                                conversionRate = Convert.ToDecimal(getConversionRate.Item("fldRate"))

                                unitPrice = Convert.ToDecimal(getItem.Item("fldPrice")) / conversionRate

                            End If

                        Case "JPY"
                            unitPrice = Convert.ToDecimal(getItem.Item("fldPrice"))
                    End Select

                End If

            Else

                Dim dtBOM As DataTable = Slipknot.dbSelectManual("SELECT fldChildCode FROM tblBOMMaster WHERE fldParentCode = '" & itemCode & "' ")

                For Each row As DataRow In dtBOM.Rows

                    getItem = Slipknot.rowSelectManual("SELECT fldPrice, fldCurrency FROM tblRMPriceMaster WHERE fldItemCode = '" & Convert.ToString(row.Item("fldChildCode")) & "' AND fldEffectivityDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldEffectivityDate DESC ")

                    If getItem IsNot Nothing Then

                        Select Case Convert.ToString(getItem.Item("fldCurrency"))

                            Case "USD"

                                getConversionRate = Slipknot.rowSelectManual("SELECT fldRate FROM tblConversionRate WHERE fldCurrency = 'USD' AND fldDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldDate DESC ")

                                If getConversionRate IsNot Nothing Then

                                    conversionRate = Convert.ToDecimal(getConversionRate.Item("fldRate"))

                                    unitPrice = unitPrice + (Convert.ToDecimal(getItem.Item("fldPrice")) * conversionRate)

                                End If

                            Case "PHP"

                                getConversionRate = Slipknot.rowSelectManual("SELECT fldRate FROM tblConversionRate WHERE fldCurrency = 'PHP' AND fldDate <= '" & effectivityDate.ToString("yyyy-MM-dd") & "' ORDER BY fldDate DESC ")

                                If getConversionRate IsNot Nothing Then

                                    conversionRate = Convert.ToDecimal(getConversionRate.Item("fldRate"))

                                    unitPrice = unitPrice + (Convert.ToDecimal(getItem.Item("fldPrice")) / conversionRate)

                                End If

                            Case "JPY"

                                unitPrice = unitPrice + Convert.ToDecimal(getItem.Item("fldPrice"))

                        End Select

                    End If

                Next

            End If

        End If

        Return unitPrice
    End Function

End Class
