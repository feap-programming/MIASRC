Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class FrmCosting
    Private Sub FrmCosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)

        readyGrid()
    End Sub

    Private Sub readyGrid()

        Dim fldParent As New GridViewTextBoxColumn("Parent")
        fldParent.FieldName = "fldParent"
        fldParent.Width = 100
        gvData.Columns.Add(fldParent)

        Dim fldSubParent As New GridViewTextBoxColumn("Sub Parent")
        fldSubParent.FieldName = "fldSubParent"
        fldSubParent.Width = 100
        gvData.Columns.Add(fldSubParent)

        Dim fldItem As New GridViewTextBoxColumn("Item")
        fldItem.FieldName = "fldItem"
        fldItem.Width = 100
        gvData.Columns.Add(fldItem)

        Dim partName As New GridViewTextBoxColumn("Item Description")
        partName.FieldName = "partName"
        partName.Width = 130
        gvData.Columns.Add(partName)

        Dim fldUOM As New GridViewTextBoxColumn("UOM")
        fldUOM.FieldName = "uom"
        fldUOM.Width = 70
        gvData.Columns.Add(fldUOM)

        Dim fldUsage As New GridViewDecimalColumn("Quantity")
        fldUsage.FieldName = "fldUsage"
        fldUsage.Width = 80
        gvData.Columns.Add(fldUsage)

        Dim fldCurrency As New GridViewTextBoxColumn("Price (Currency)")
        fldCurrency.FieldName = "fldCurrency"
        fldCurrency.Width = 100
        gvData.Columns.Add(fldCurrency)

        Dim fldMatUnitPrice As New GridViewDecimalColumn("Mat Unit Price")
        fldMatUnitPrice.FieldName = "matUnitPrice"
        fldMatUnitPrice.Width = 100
        gvData.Columns.Add(fldMatUnitPrice)

        Dim laborUnitCost As New GridViewDecimalColumn("Labor Unit Price")
        laborUnitCost.FieldName = "laborUnitPrice"
        laborUnitCost.Width = 120
        gvData.Columns.Add(laborUnitCost)

        Dim matAmount As New GridViewDecimalColumn("Material Amount")
        matAmount.FieldName = "matAmount"
        matAmount.Width = 120
        gvData.Columns.Add(matAmount)
        gvData.Columns("matAmount").FormatString = "{0:N2}"

        Dim laborAmount As New GridViewDecimalColumn("Labor Amount")
        laborAmount.FieldName = "laborAmount"
        laborAmount.Width = 100
        gvData.Columns.Add(laborAmount)
        gvData.Columns("laborAmount").FormatString = "{0:N2}"

        Dim totalAmount As New GridViewDecimalColumn("Total Amount")
        totalAmount.FieldName = "totalAmount"
        totalAmount.Width = 100
        gvData.Columns.Add(totalAmount)
        gvData.Columns("totalAmount").FormatString = "{0:N2}"

        Dim depth As New GridViewTextBoxColumn("Depth")
        depth.FieldName = "depth"
        depth.Width = 50
        gvData.Columns.Add(depth)

        gvData.ReadOnly = True
        gvData.AllowAddNewRow = True
        gvData.AllowDeleteRow = True
        gvData.ShowFilteringRow = False
        gvData.ShowGroupPanel = False

    End Sub

    Dim tempTable As New DataTable

    Private Sub test()

        tempTable.Columns.Add("fldParent", GetType(String))
        tempTable.Columns.Add("fldSubParent", GetType(String))
        tempTable.Columns.Add("fldItem", GetType(String))
        tempTable.Columns.Add("partName", GetType(String))
        tempTable.Columns.Add("uom", GetType(String))
        tempTable.Columns.Add("fldUsage", GetType(Decimal))
        tempTable.Columns.Add("fldCurrency", GetType(String))
        tempTable.Columns.Add("matUnitPrice", GetType(Decimal))
        tempTable.Columns.Add("laborUnitPrice", GetType(Decimal))
        tempTable.Columns.Add("matAmount", GetType(Decimal))
        tempTable.Columns.Add("laborAmount", GetType(Decimal))
        tempTable.Columns.Add("totalAmount", GetType(Decimal))
        tempTable.Columns.Add("depth", GetType(String))

        Dim parent As String = String.Empty
        Dim subParent As String = String.Empty
        Dim item As String = String.Empty
        Dim partName As String = String.Empty
        Dim uom As String = String.Empty
        Dim usage As Decimal = 0
        Dim currency As String = "JPY"
        Dim matUnitPrice As Decimal = 0
        Dim laborUnitPrice As Decimal = 0
        Dim matAmount As Decimal = 0
        Dim laborAmount As Decimal = 0
        Dim totalAmount As Decimal = 0

        Dim dtAllParent As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode FROM tblBOMMaster GROUP BY fldParentCode")

        For Each row As DataRow In dtAllParent.Rows

            parent = Convert.ToString(row.Item("fldParentCode"))

            'CONSTRUCTING 1ST LAYER
            Dim dtLayer1 As DataTable = Slipknot.dbSelectManual("SELECT " _
                                                              & "T0.fldParentCode, " _
                                                              & "T0.fldChildCode, " _
                                                              & "T0.fldUsage, " _
                                                              & "IFNULL((SELECT fldStandardPrice FROM tblRMPriceMaster WHERE fldItemCode = T0.fldChildCode ORDER BY fldEffectivityDate DESC LIMIT 1), 0) As matUnitPrice, " _
                                                              & "(T0.fldUsage * (SELECT matUnitPrice)) AS matAmount " _
                                                              & "FROM tblBOMMaster T0 WHERE T0.fldParentCode = '" & parent & "' ")

            'Dim dtLayer1 As DataTable = Slipknot.dbSelectManual("SELECT " _
            '                                                  & "T0.fldParentCode, " _
            '                                                  & "T0.fldChildCode, " _
            '                                                  & "T0.fldUsage " _
            '                                                  & "FROM tblBOMMaster T0 WHERE T0.fldParentCode = '" & parent & "' ")

            For Each layer1Row As DataRow In dtLayer1.Rows

                subParent = Convert.ToString(layer1Row.Item("fldParentCode"))
                item = Convert.ToString(layer1Row.Item("fldChildCode"))
                usage = Convert.ToDecimal(layer1Row.Item("fldUsage"))
                matUnitPrice = Convert.ToDecimal(layer1Row.Item("matUnitPrice"))
                matAmount = Convert.ToDecimal(layer1Row.Item("matAmount"))

                'Dim getPartname As DataRow = Slipknot.rowSelectManual("SELECT fldPartName, fldUOM FROM tblItemMasterData WHERE fldItemCode = '" & item & "' ")

                'If getPartname IsNot Nothing Then
                '    partName = Convert.ToString(getPartname.Item("fldPartName"))
                '    uom = Convert.ToString(getPartname.Item("fldUOM"))
                'Else
                '    Dim getTrueItemCode As DataRow = Slipknot.rowSelectManual("SELECT fldItemCode FROM tblPartNoHistory WHERE fldNewItemCode = '" & item & "' ")

                '    If getTrueItemCode IsNot Nothing Then

                '        getPartname = Slipknot.rowSelectManual("SELECT fldPartName, fldUOM FROM tblItemMasterData WHERE fldItemCode = '" & Convert.ToString(getTrueItemCode.Item("fldItemCode")) & "' ")

                '        If getPartname IsNot Nothing Then
                '            partName = Convert.ToString(getPartname.Item("fldPartName"))
                '            uom = Convert.ToString(getPartname.Item("fldUOM"))
                '        End If

                '    End If

                'End If

                If item.Contains("WP") = False Then

                    If item = "Assy Cost" Then

                        Dim drMH As DataRow = Slipknot.rowSelectManualMH("SELECT " _
                                                                     & "SUM(ROUND(ROUND(If((TI.fldNumberOfPersons * TI.fldTactS / (TI.fldOR / 100) * (1 + (100 - TI.fldYield) / 100)) Is NULL, 0, (TI.fldNumberOfPersons * TI.fldTactS / (TI.fldOR / 100) * (1 + (100 - TI.fldYield) / 100))), 2) " _
                                                                     & "* " _
                                                                     & "ROUND((Select (Select If(ROUND((fldPhp / fldBudgetRate / fldNumberOfHours), 2) / 3600 Is NULL, 0,(fldPhp / fldBudgetRate / fldNumberOfHours) / 3600) FROM tblManPowerTypeList WHERE fldCode = tblManPowerList.fldManPowerType LIMIT 1) FROM tblManPowerList WHERE fldCode = TI.fldManPowerCode LIMIT 1), 5), 5) ) As stdCost " _
                                                                     & "FROM tblItemList TI " _
                                                                     & "WHERE TI.fldItemCode = '" & subParent & "' " _
                                                                     & "GROUP BY TI.fldItemCode ")

                        If drMH IsNot Nothing Then
                            If Convert.ToString(drMH.Item("stdCost")) <> "" Then
                                laborUnitPrice = Convert.ToDecimal(drMH.Item("stdCost"))
                            End If
                        End If

                    Else
                        laborUnitPrice = 0
                    End If

                    laborAmount = usage * laborUnitPrice
                    totalAmount = matAmount + laborAmount

                    tempTable.Rows.Add(parent, subParent, item, partName, uom, usage, currency, matUnitPrice, laborUnitPrice, matAmount, laborAmount, totalAmount, 1)
                End If

            Next

        Next

        gvData.DataSource = tempTable

    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork

        tempTable.Columns.Add("fldParent", GetType(String))
        tempTable.Columns.Add("fldSubParent", GetType(String))
        tempTable.Columns.Add("fldItem", GetType(String))
        tempTable.Columns.Add("fldPriceCurrency", GetType(String))

        Dim parent As String = String.Empty
        Dim subParent As String = String.Empty
        Dim item As String

        Dim dtAllParent As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode FROM tblBOMMaster GROUP BY fldParentCode")

        For Each row As DataRow In dtAllParent.Rows

            Parent = Convert.ToString(row.Item("fldParentCode"))

            Dim dtLayer1 As DataTable = Slipknot.dbSelectManual("SELECT fldParentCode, fldChildCode FROM tblBOMMaster WHERE fldParentCode = '" & parent & "' ")

                        For Each layer1Row As DataRow In dtLayer1.Rows

                subParent = Convert.ToString(layer1Row.Item("fldParentCode"))
                item = Convert.ToString(layer1Row.Item("fldChildCode"))

                tempTable.Rows.Add(parent, subParent, item, "JPY")

            Next

        Next

    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        gvData.DataSource = tempTable
    End Sub

    Private Sub FrmCosting_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'bwLoadData.RunWorkerAsync()

        test()
    End Sub
End Class
