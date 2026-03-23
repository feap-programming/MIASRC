Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports MySql.Data.MySqlClient
Public Class Slapshock

    Shared Sub constractItemBOM(ByVal titleId As String, ByVal subContentId As String)

        Slipknot.addParameter("parTitleId", titleId)
        Slipknot.addParameter("parSubContentId", subContentId)

        Dim dtHeader As DataTable = Slipknot.dbSelect("SP_SelectBOMContentsByTitleAndSubContent")

        Dim parentCode As String
        Dim parentPartName As String = String.Empty
        Dim parentRegistrationNo As String = String.Empty

        Dim itemCode As String
        Dim partName As String
        Dim registrationNo As String
        Dim modelCode As String
        Dim customerPartNo As String

        Dim childCode As String
        Dim usage As Double = 0
        Dim processName As String = Nothing
        Dim processCode As String = Nothing
        Dim processPriority As Integer
        Dim processColor As String

        Dim UOM As String = Nothing
        Dim maker As String = Nothing

        For Each row As DataRow In dtHeader.Rows 'FG PARENT LOOP

            itemCode = Nothing
            partName = Nothing
            registrationNo = Nothing
            modelCode = Nothing
            customerPartNo = Nothing

            itemCode = Convert.ToString(row.Item("fldItemCode"))
            partName = Convert.ToString(row.Item("fldPartName"))
            registrationNo = Convert.ToString(row.Item("fldRegistrationNo"))
            modelCode = Convert.ToString(row.Item("fldModelCode"))
            customerPartNo = Convert.ToString(row.Item("fldCustomerPartNo"))

            Slipknot.addParameter("parTitleId", titleId)
            Slipknot.addParameter("parSubContentId", subContentId)
            Slipknot.addParameter("parItemCode", itemCode)
            Slipknot.addParameter("parPartName", partName)
            Slipknot.addParameter("parRegistrationNo", registrationNo)
            Slipknot.addParameter("parModelCode", modelCode)
            Slipknot.addParameter("parCustomerPartNo", customerPartNo)

            If Slipknot.dbAED("SP_InsertBOMReportHeader") Then

                Dim dtProcess As DataTable = Slipknot.dbSelect("SP_SelectAllProcess")

                For Each procRow As DataRow In dtProcess.Rows 'ALL PROCESS LOOP

                    processName = Nothing
                    processCode = Nothing
                    processPriority = Nothing
                    processColor = Nothing

                    processName = Convert.ToString(procRow.Item("fldProcessName"))
                    processCode = Convert.ToString(procRow.Item("fldCode"))
                    processPriority = Convert.ToInt32(procRow.Item("fldPriority"))
                    processColor = Convert.ToString(procRow.Item("fldColor"))

                    'START OF LAYER 1
                    Slipknot.addParameter("parParentCode", itemCode)
                    Slipknot.addParameter("parProcessCode", processCode)
                    Dim dtBOM1 As DataTable = Slipknot.dbSelect("SP_SelectBOMMasterByParentAndProcess")

                    For Each bomRow1 As DataRow In dtBOM1.Rows 'BOM LAYER 1 LOOP

                        childCode = Nothing
                        partName = Nothing
                        registrationNo = Nothing
                        UOM = Nothing
                        maker = Nothing

                        childCode = Convert.ToString(bomRow1.Item("fldChildCode"))
                        partName = Convert.ToString(bomRow1.Item("fldPartName"))
                        registrationNo = Convert.ToString(bomRow1.Item("fldRegistrationNo"))
                        UOM = Convert.ToString(bomRow1.Item("fldUOM"))
                        maker = Convert.ToString(bomRow1.Item("maker"))

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
                        Slipknot.addParameter("parProcess", processName)
                        Slipknot.addParameter("parProcessPriority", processPriority)
                        Slipknot.addParameter("parProcessColor", processColor)
                        Slipknot.addParameter("parMaker", maker)
                        Slipknot.dbAED("SP_InsertBOMReportDetails")

                        'START OF LAYER 2
                        Slipknot.addParameter("parParentCode", childCode)
                        Slipknot.addParameter("parProcessCode", processCode)
                        Dim dtBOM2 As DataTable = Slipknot.dbSelect("SP_SelectBOMMasterByParentAndProcess")

                        For Each bomRow2 As DataRow In dtBOM2.Rows 'BOM LAYER 2 LOOP

                            parentCode = Nothing
                            'childCode = Nothing
                            partName = Nothing
                            registrationNo = Nothing
                            UOM = Nothing
                            maker = Nothing

                            parentCode = childCode
                            childCode = Convert.ToString(bomRow2.Item("fldChildCode"))
                            partName = Convert.ToString(bomRow2.Item("fldPartName"))
                            registrationNo = Convert.ToString(bomRow1.Item("fldRegistrationNo"))
                            UOM = Convert.ToString(bomRow1.Item("fldUOM"))
                            maker = Convert.ToString(bomRow1.Item("maker"))

                            Slipknot.addParameter("parTitleId", titleId)
                            Slipknot.addParameter("parSubContentId", subContentId)
                            Slipknot.addParameter("parParentCode", parentCode)
                            Slipknot.addParameter("parParentPartName", "")
                            Slipknot.addParameter("parParentRegistrationNo", "")
                            Slipknot.addParameter("parItemCode", childCode)
                            Slipknot.addParameter("parClass", 0)
                            Slipknot.addParameter("parPartName", partName)
                            Slipknot.addParameter("parRegistrationNo", registrationNo)
                            Slipknot.addParameter("parUOM", UOM)
                            Slipknot.addParameter("parProcess", processName)
                            Slipknot.addParameter("parProcessPriority", processPriority)
                            Slipknot.addParameter("parProcessColor", processColor)
                            Slipknot.addParameter("parMaker", maker)
                            Slipknot.dbAED("SP_InsertBOMReportDetails")

                            'START OF LAYER 3
                            'Slipknot.addParameter("parParentCode", childCode)
                            'Slipknot.addParameter("parProcessCode", processCode)
                            'Dim dtBOM3 As DataTable = Slipknot.dbSelect("SP_SelectBOMMasterByParentAndProcess")

                            'For Each bomRow3 As DataRow In dtBOM3.Rows 'BOM LAYER 3 LOOP

                            '    parentCode = Nothing
                            '    'childCode = Nothing
                            '    partName = Nothing
                            '    registrationNo = Nothing
                            '    UOM = Nothing
                            '    maker = Nothing

                            '    parentCode = childCode
                            '    childCode = Convert.ToString(bomRow3.Item("fldChildCode"))
                            '    partName = Convert.ToString(bomRow3.Item("fldPartName"))
                            '    registrationNo = Convert.ToString(bomRow3.Item("fldRegistrationNo"))
                            '    UOM = Convert.ToString(bomRow3.Item("fldUOM"))
                            '    maker = Convert.ToString(bomRow3.Item("maker"))

                            '    Slipknot.addParameter("parTitleId", titleId)
                            '    Slipknot.addParameter("parSubContentId", subContentId)
                            '    Slipknot.addParameter("parParentCode", parentCode)
                            '    Slipknot.addParameter("parParentPartName", "")
                            '    Slipknot.addParameter("parParentRegistrationNo", "")
                            '    Slipknot.addParameter("parItemCode", childCode)
                            '    Slipknot.addParameter("parClass", 0)
                            '    Slipknot.addParameter("parPartName", partName)
                            '    Slipknot.addParameter("parRegistrationNo", registrationNo)
                            '    Slipknot.addParameter("parUOM", UOM)
                            '    Slipknot.addParameter("parProcess", processName)
                            '    Slipknot.addParameter("parProcessPriority", processPriority)
                            '    Slipknot.addParameter("parProcessColor", processColor)
                            '    Slipknot.addParameter("parMaker", maker)
                            '    Slipknot.dbAED("SP_InsertBOMReportDetails")

                            'Next

                        Next

                    Next

                Next

            End If

        Next




    End Sub

    Shared Sub NoAccessToFunctionMessage()
        RadMessageBox.Show("Sorry you are not allowed to use that function", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
    End Sub

    Shared Sub NoAccessToModuleMessage()
        RadMessageBox.Show("Sorry you are not authorized to access this module", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
    End Sub

    Shared Sub NoAccessToMasterMessage()
        RadMessageBox.Show("Sorry you are not authorized to access this master data", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
    End Sub


End Class
