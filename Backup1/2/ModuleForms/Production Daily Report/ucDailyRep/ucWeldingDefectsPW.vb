Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class ucWeldingDefectsPW
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")

    Private Sub ucWeldingDefectsPW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GridCol()
        'Defectsdata()
        ReloadGrid()
    End Sub

    Private Sub ReloadGrid()

        Dim DTPW As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingDefectsPW where fldDRID=" & globalVariables.DailyRepID & " and fldType='" & globalVariables.SRCReportType & "'")

        If DTPW.Rows.Count >= 1 Then

            Dim DTOwO As New DataTable
            Dim DTPW1 As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingDefectsPW where fldDRID=" & globalVariables.DailyRepID & " and fldType='" & globalVariables.SRCReportType & "' and fldTableNo=1")
            Dim DTPW2 As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingDefectsPW where fldDRID=" & globalVariables.DailyRepID & " and fldType='" & globalVariables.SRCReportType & "' and fldTableNo=2")

            Dim i As Integer = 0

            gvData.DataSource = ReloadCol(DTPW1, 1)
            gvData.Columns(0).Width = 100

            gvMaterialDefects.DataSource = ReloadCol(DTPW2, 1)
            gvMaterialDefects.Columns(0).Width = 100

            Dim ColI As Integer = 0

            While ColI <= gvData.Columns.Count - 1

                    If ColI = 0 Then
                        gvData.Columns(ColI).TextAlignment = ContentAlignment.MiddleCenter
                        gvData.Columns(ColI).MinWidth = 150
                        gvData.Columns(ColI).IsPinned = True
                        gvData.Columns(ColI).PinPosition = PinnedColumnPosition.Left

                        gvMaterialDefects.Columns(ColI).TextAlignment = ContentAlignment.MiddleCenter
                        gvMaterialDefects.Columns(ColI).MinWidth = 150
                        gvMaterialDefects.Columns(ColI).IsPinned = True
                        gvMaterialDefects.Columns(ColI).PinPosition = PinnedColumnPosition.Left
                    Else
                        gvData.Columns(ColI).TextAlignment = ContentAlignment.MiddleCenter
                        gvData.Columns(ColI).MinWidth = 300
                        gvMaterialDefects.Columns(ColI).TextAlignment = ContentAlignment.MiddleCenter
                        gvMaterialDefects.Columns(ColI).MinWidth = 80
                    End If

                    ColI = ColI + 1

                End While

        Else

            GridCol()
            GridCol2()
            Defectsdata()

        End If

    End Sub

    Function ReloadCol(DTNya As DataTable, TblNo As Integer) As DataTable
        Dim Col As New DataTable


        Col.Columns.Add("In Process Defects", GetType(String))

        Dim GroupWip = (From t1 In DTNya.AsEnumerable
                        Group By Keys = New With {
                          Key .fldWIP = t1("fldWIP")
                        } Into t1g = Group
                        Select New With {
                                .fldWIP = Keys.fldWIP
                            }).ToList

        For Each row As DataRow In convertToDatatable(GroupWip).Rows

            Col.Columns.Add(row.Item("fldWIP").ToString.Trim, GetType(String))

        Next

        Dim GroupDefects = (From t1 In DTNya.AsEnumerable
                            Group By Keys = New With {
                          Key .fldDefects = t1("fldDefects")
                        } Into t1g = Group
                            Select New With {
                                .fldDefects = Keys.fldDefects
                            }).ToList

        For Each row As DataRow In convertToDatatable(GroupDefects).Rows

            Dim SelectQty = (From t1 In DTNya.AsEnumerable
                             Where t1("fldDefects").ToString.Equals(row.Item("fldDefects").ToString)
                             Select New With {
                                    .fldQty = t1("fldQty")
                                }).ToList

            Dim ArrayOwO(convertToDatatable(SelectQty).Rows.Count) As String
            ArrayOwO(0) = row.Item("fldDefects").ToString
            Dim i As Integer = 1
            For Each QtyRow As DataRow In convertToDatatable(SelectQty).Rows

                ArrayOwO(i) = QtyRow.Item("fldQty").ToString
                i = i + 1

            Next
            Col.Rows.Add(ArrayOwO)
        Next

        Return Col

    End Function

    Private Sub GridCol()

        Dim fldDefects As New GridViewTextBoxColumn
        fldDefects.HeaderText = "In Process Defects"
        fldDefects.FieldName = "fldDefects"
        fldDefects.TextAlignment = ContentAlignment.MiddleCenter
        fldDefects.MinWidth = 150
        fldDefects.IsPinned = True
        fldDefects.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldDefects)

        Dim DTWip As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='PW'")

        For Each row As DataRow In DTWip.Rows

            Dim fldWips As New GridViewDecimalColumn
            fldWips.HeaderText = row.Item("fldPartName").ToString.Trim
            fldWips.FieldName = row.Item("fldPartName").ToString.Trim
            fldWips.TextAlignment = ContentAlignment.MiddleCenter
            fldWips.MinWidth = 300
            gvData.Columns.Add(fldWips)

        Next

    End Sub
    Private Sub GridCol2()

        Dim fldDefects2 As New GridViewTextBoxColumn
        fldDefects2.HeaderText = "In Process Defects"
        fldDefects2.FieldName = "fldDefects"
        fldDefects2.TextAlignment = ContentAlignment.MiddleCenter
        fldDefects2.MinWidth = 150
        fldDefects2.IsPinned = True
        fldDefects2.PinPosition = PinnedColumnPosition.Left
        gvMaterialDefects.Columns.Add(fldDefects2)

        Dim DTWip As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='PW'")

        For Each row As DataRow In DTWip.Rows

            Dim fldWips2 As New GridViewDecimalColumn
            fldWips2.HeaderText = row.Item("fldPartName").ToString.Trim
            fldWips2.FieldName = row.Item("fldPartName").ToString.Trim
            fldWips2.TextAlignment = ContentAlignment.MiddleCenter
            fldWips2.MinWidth = 300
            gvMaterialDefects.Columns.Add(fldWips2)

        Next

    End Sub

    Private Sub Defectsdata()

        gvData.Rows.Add("Autorun")
        gvData.Rows.Add("Damage Busbar")
        gvData.Rows.Add("Foreign Material")
        gvData.Rows.Add("Lifted Welding")
        gvData.Rows.Add("Loose Wire")
        gvData.Rows.Add("Mis Insertion")
        gvData.Rows.Add("Sensor Error")
        gvData.Rows.Add("Short Weld")
        gvData.Rows.Add("Strong Weld")
        gvData.Rows.Add("USW Error (Power)")
        gvData.Rows.Add("USW Error (Strain)")
        gvData.Rows.Add("USW Error (Time)")
        gvData.Rows.Add("USW Error (Voltage)")
        gvData.Rows.Add("Weak Weld")

        gvMaterialDefects.Rows.Add("Material Defects")

    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click

        Maria.MyQuery("SET SQL_SAFE_UPDATES = 0; Delete FROM tblDailyReportWeldingDefectsPW where fldDRID=" & globalVariables.DailyRepID & "; SET SQL_SAFE_UPDATES = 1;")

        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

            For colcounter As Integer = 1 To Me.gvData.Columns.Count - 1

                Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
                Maria.AddMySqlParameters("parDefects", gvData.Rows(rowcounter).Cells(0).Value.ToString)
                Maria.AddMySqlParameters("parWIP", gvData.Columns(colcounter).FieldName)
                Maria.AddMySqlParameters("parQty", gvData.Rows(rowcounter).Cells(colcounter).Value)
                Maria.AddMySqlParameters("parTableNo", 1)
                Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                Maria.SPADE("SP_SRCDailyReport_InsertWeldingDefectsPW")

            Next

        Next

        For rowcounter As Integer = 0 To Me.gvMaterialDefects.Rows.Count - 1

            For colcounter As Integer = 1 To Me.gvMaterialDefects.Columns.Count - 1

                Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
                Maria.AddMySqlParameters("parDefects", gvMaterialDefects.Rows(rowcounter).Cells(0).Value.ToString)
                Maria.AddMySqlParameters("parWIP", gvMaterialDefects.Columns(colcounter).FieldName)
                Maria.AddMySqlParameters("parQty", gvMaterialDefects.Rows(rowcounter).Cells(colcounter).Value)
                Maria.AddMySqlParameters("parTableNo", 2)
                Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                Maria.SPADE("SP_SRCDailyReport_InsertWeldingDefectsPW")

            Next

        Next

        MessageBox.Show("Done!")

    End Sub
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
End Class
