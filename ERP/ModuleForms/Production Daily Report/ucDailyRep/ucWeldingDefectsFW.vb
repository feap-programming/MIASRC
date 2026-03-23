Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class ucWeldingDefectsFW
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub ucWeldingDefectsFW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadPartName()

    End Sub

    Private Sub ReloadPartName()

        Dim DTWip As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingTemplate where fldModel='" & globalVariables.DailyReportModel & "' and fldLine=" & globalVariables.ModelLineWelding & " and fldType='FW'")

        ddType.DataSource = DTWip
        ddType.DisplayMember = "fldPartName"
        ddType.ValueMember = "fldPartName"
        ddType.AutoCompleteDataSource = DTWip
        ddType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddType.AutoCompleteDisplayMember = "fldPartName"
        ddType.AutoCompleteValueMember = "fldPartName"
        ddType.Text = ""

    End Sub

    Private Sub GridCol()

        Dim fldDefects As New GridViewTextBoxColumn
        fldDefects.HeaderText = "In Process Defects"
        fldDefects.FieldName = "fldDefects"
        fldDefects.TextAlignment = ContentAlignment.MiddleCenter
        fldDefects.MinWidth = 150
        fldDefects.IsPinned = True
        fldDefects.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldDefects)

        Dim fldS As New GridViewTextBoxColumn
        fldS.HeaderText = "S"
        fldS.FieldName = "S"
        fldS.TextAlignment = ContentAlignment.MiddleCenter
        fldS.MinWidth = 80
        gvData.Columns.Add(fldS)

        Dim fldC As New GridViewTextBoxColumn
        fldC.HeaderText = "C"
        fldC.FieldName = "C"
        fldC.TextAlignment = ContentAlignment.MiddleCenter
        fldC.MinWidth = 80
        gvData.Columns.Add(fldC)

        Dim fldSC As New GridViewTextBoxColumn
        fldSC.HeaderText = "SC"
        fldSC.FieldName = "SC"
        fldSC.TextAlignment = ContentAlignment.MiddleCenter
        fldSC.MinWidth = 80
        gvData.Columns.Add(fldSC)

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

    End Sub

    Private Sub ddType_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddType.SelectedIndexChanged
        gvData.DataSource = Nothing
        gvData.MasterTemplate.Rows.Clear()
        gvData.Columns.Clear()
        If ddType.Text = "" Then

        Else

            Dim checkExist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportWeldingDefectsFW where fldDRID=" & globalVariables.DailyRepID & " and fldWIP='" & ddType.Text & "'")

            If checkExist.Rows.Count >= 1 Then
                Dim Col As New DataTable


                Col.Columns.Add("In Process Defects", GetType(String))

                Dim GetTableData = (From t1 In checkExist.AsEnumerable
                                    Where t1("fldTableNo") = 1
                                    Select New With {
                                        .fldDefects = t1("fldDefects"),
                                        .fldWIP = t1("fldWIP"),
                                        .fldWIPType = t1("fldWIPType"),
                                        .fldQty = t1("fldQty")
                                    }).ToList

                Dim GetCol = (From t1 In convertToDatatable(GetTableData).AsEnumerable
                              Group By Keys = New With {
                                  Key .fldWIPType = t1("fldWIPType")
                                } Into t1g = Group
                              Select New With {
                                      .fldWIPType = Keys.fldWIPType
                                }).ToList

                For Each row As DataRow In convertToDatatable(GetCol).Rows

                    Col.Columns.Add(row.Item("fldWIPType").ToString.Trim, GetType(String))

                Next

                Dim GroupDefects = (From t1 In convertToDatatable(GetTableData).AsEnumerable
                                    Group By Keys = New With {
                                  Key .fldDefects = t1("fldDefects")
                                } Into t1g = Group
                                    Select New With {
                                        .fldDefects = Keys.fldDefects
                                    }).ToList

                For Each row As DataRow In convertToDatatable(GroupDefects).Rows

                    Dim SelectQty = (From t1 In convertToDatatable(GetTableData).AsEnumerable
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
                gvData.DataSource = Col

                Dim ColI As Integer = 0

                While ColI <= gvData.Columns.Count - 1

                    If ColI = 0 Then
                        gvData.Columns(ColI).TextAlignment = ContentAlignment.MiddleCenter
                        gvData.Columns(ColI).MinWidth = 150
                        gvData.Columns(ColI).IsPinned = True
                        gvData.Columns(ColI).PinPosition = PinnedColumnPosition.Left
                    Else
                        gvData.Columns(ColI).TextAlignment = ContentAlignment.MiddleCenter
                        gvData.Columns(ColI).MinWidth = 80
                    End If
                    ColI = ColI + 1
                End While

            Else

                GridCol()
                Defectsdata()

            End If

        End If

    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click

        Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
        Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
        Maria.AddMySqlParameters("parWip", ddType.Text)
        Maria.SPADE("SP_SRCDailyReport_DeleteWeldingDefectsFW")

        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1

            For colcounter As Integer = 1 To Me.gvData.Columns.Count - 1

                Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
                Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
                Maria.AddMySqlParameters("parDefects", gvData.Rows(rowcounter).Cells(0).Value.ToString)
                Maria.AddMySqlParameters("parWIP", ddType.Text)
                Maria.AddMySqlParameters("parWIPType", gvData.Columns(colcounter).FieldName)
                Maria.AddMySqlParameters("parQty", gvData.Rows(rowcounter).Cells(colcounter).Value)
                Maria.AddMySqlParameters("parTableNo", 1)
                Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                Maria.SPADE("SP_SRCDailyReport_InsertWeldingDefectsFW")

            Next

        Next

        Maria.AddMySqlParameters("parDRID", globalVariables.DailyRepID)
        Maria.AddMySqlParameters("parType", globalVariables.SRCReportType)
        Maria.AddMySqlParameters("parDefects", "Material Defects")
        Maria.AddMySqlParameters("parWIP", ddType.Text)
        Maria.AddMySqlParameters("parWIPType", "")
        Maria.AddMySqlParameters("parQty", spnMatsDef.Value)
        Maria.AddMySqlParameters("parTableNo", 2)
        Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
        Maria.SPADE("SP_SRCDailyReport_InsertWeldingDefectsFW")

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
