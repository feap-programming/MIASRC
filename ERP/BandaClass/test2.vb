Public Class test2

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

        Slipknot.addParameter("parTitled", titleId)
        Slipknot.addParameter("parSubContentId", titleId)
        Dim dtHeader As DataTable = Slipknot.dbSelect("SP_SelectBOMContentsByTitleAndSubContent")

        'FG PARENT HEADER LOOP
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

            If Slipknot.dbAED("SP_InsertBOMReportHeader") Then
                addReportRow(granParentCode, dtLayer1)
            End If

            Dim dtFirst As DataTable = Slipknot.dbSelectManual("SELECT T0.fldItemCode FROM " _
                                                         & "tblBOMReportSRCAssy T0 " _
                                                         & "LEFT JOIN tblItemMasterData T1 " _
                                                         & "ON IF((SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldItemCode LIMIT 1) IS NULL, T0.fldItemCode, (SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = T0.fldItemCode LIMIT 1)) = T1.fldItemCode")



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
