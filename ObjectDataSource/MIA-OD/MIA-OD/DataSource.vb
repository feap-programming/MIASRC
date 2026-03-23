Public Class DataSource

    Shared Function GetProdInventorySummary(ByVal whseFrom As String, ByVal whseTo As String, ByVal itemCode As String, ByVal lastDateOfInventory As Date, ByVal dateFrom As Date, ByVal dateTo As Date) As DataTable

        Dim dbTemp As New DataTable
        dbTemp.Columns.Add("dateAdded", GetType(Date))
        dbTemp.Columns.Add("parentCode", GetType(String))
        dbTemp.Columns.Add("transferedQty", GetType(Decimal))
        dbTemp.Columns.Add("outputQty", GetType(Decimal))
        dbTemp.Columns.Add("sumOutputQty", GetType(Decimal))
        dbTemp.Columns.Add("begOnHand", GetType(Decimal))

        Dim BeginningInv As Decimal = 0

        Dim getInventoryQty As DataRow = Functions.rowSelectManual("SELECT fldInventoryQty FROM tblWarehousing WHERE fldItemCode = '" & itemCode & "' AND DATE_FORMAT(fldInventoryDate, '%Y-%m-%d') = '" & lastDateOfInventory.ToString("yyyy-MM-dd") & "' ")

        If getInventoryQty IsNot Nothing Then
            BeginningInv = Convert.ToDecimal(getInventoryQty.Item("fldInventoryQty"))
        End If

        Dim firstRec As Boolean = True

        Dim begOnHand As Decimal = 0

        Dim dtBOM As DataTable = Functions.dbSelectManual("SELECT fldParentCode FROM tblBOMMaster WHERE fldChildCode = '" & itemCode & "' ")

        Do While dateFrom <= dateTo

            Dim transferedQty As Decimal = 0
            Dim sumTransferedQty As DataRow = Functions.rowSelectManual("SELECT SUM(fldTransferedQty) AS transferedQty FROM tblInventoryTransfer WHERE fldItemCode = '" & itemCode & "' AND fldFrom = '" & whseFrom & "' AND fldTo = '" & whseTo & "' AND DATE_FORMAT(fldDateAdded, '%Y-%m-%d') = '" & dateFrom.ToString("yyyy-MM-dd") & "' ")

            If Convert.ToString(sumTransferedQty.Item("transferedQty")) <> String.Empty Then
                transferedQty = Convert.ToDecimal(sumTransferedQty.Item("transferedQty"))
            End If

            Dim sumOutQty As Decimal = 0

            For Each row As DataRow In dtBOM.Rows
                Dim outputQty As Decimal = 0
                Dim parentCode As String = Convert.ToString(row.Item("fldParentCode"))

                Dim getInitParentCode As DataRow = Functions.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & parentCode & "' ")

                If getInitParentCode IsNot Nothing Then
                    parentCode = Convert.ToString(getInitParentCode.Item("fldItemCode"))
                End If

                Dim sumOutputQty As DataRow = Functions.rowSelectManual("SELECT SUM(fldQty) AS outputQty FROM tblProductionOutput WHERE fldPartNo = '" & parentCode & "' AND fldLocation = '" & whseTo & "' AND DATE_FORMAT(fldDateAdded, '%Y-%m-%d') = '" & dateFrom.ToString("yyyy-MM-dd") & "' ")

                If Convert.ToString(sumOutputQty.Item("outputQty")) <> String.Empty Then
                    sumOutQty = sumOutQty + Convert.ToDecimal(sumOutputQty.Item("outputQty"))
                End If

            Next

            If firstRec Then

                begOnHand = BeginningInv + transferedQty - sumOutQty

                firstRec = False
            Else
                begOnHand = begOnHand + transferedQty - sumOutQty
            End If

            For Each row As DataRow In dtBOM.Rows

                Dim outputQty As Decimal = 0
                Dim parentCode As String = Convert.ToString(row.Item("fldParentCode"))

                Dim getInitParentCode As DataRow = Functions.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & parentCode & "' ")

                If getInitParentCode IsNot Nothing Then
                    parentCode = Convert.ToString(getInitParentCode.Item("fldItemCode"))
                End If

                Dim sumOutputQty As DataRow = Functions.rowSelectManual("SELECT SUM(fldQty) AS outputQty FROM tblProductionOutput WHERE fldPartNo = '" & parentCode & "' AND fldLocation = '" & whseTo & "' AND DATE_FORMAT(fldDateAdded, '%Y-%m-%d') = '" & dateFrom.ToString("yyyy-MM-dd") & "' ")

                If Convert.ToString(sumOutputQty.Item("outputQty")) <> String.Empty Then
                    outputQty = Convert.ToDecimal(sumOutputQty.Item("outputQty"))
                End If

                dbTemp.Rows.Add(dateFrom, parentCode, transferedQty, outputQty, sumOutQty, begOnHand)

            Next

            dateFrom = dateFrom.AddDays(1)
        Loop

        Return dbTemp
    End Function


End Class
