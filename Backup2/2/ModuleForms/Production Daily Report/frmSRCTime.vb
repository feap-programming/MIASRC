Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmSRCTime
    Dim Furina As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim ManPowerTemplate As DataTable = Furina.MyQuery("SELECT * FROM tblDailyReportATManpowerTemp")
    Private Sub FrmSRCTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridCol()
        ReloadGrid()
        GetTemp()
        tpFrom.Value = Now
        tpTo.Value = Now
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
    Private Sub GetTemp()
        Dim tempDT As DataTable = ManPowerTemplate
        Dim TMNo = (From t1 In tempDT.AsEnumerable
                    Where t1("fldModel").ToString.Equals(Mio.ATModel) And t1("fldLine").ToString.Equals(Mio.ATLine)
                    Select New With {
                        .fldMachNo = t1("fldMachNo").ToString
                    }).ToList
        ddITType.DataSource = convertToDatatable(TMNo)
        ddITType.DisplayMember = "fldMachNo"
        ddITType.ValueMember = "fldMachNo"
        ddITType.AutoCompleteDataSource = convertToDatatable(TMNo)
        ddITType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddITType.AutoCompleteDisplayMember = "fldMachNo"
        ddITType.AutoCompleteValueMember = "fldMachNo"
        ddITType.Text = ""
    End Sub
    Private Sub GridCol()

        gvData.Columns.Clear()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldMachNo As New GridViewTextBoxColumn
        fldMachNo.HeaderText = "Mach. No."
        fldMachNo.FieldName = "fldMachNo"
        fldMachNo.TextAlignment = ContentAlignment.MiddleCenter
        fldMachNo.Width = 100
        gvData.Columns.Add(fldMachNo)

        Dim fldTimeFrom As New GridViewDateTimeColumn
        fldTimeFrom.HeaderText = "From"
        fldTimeFrom.FieldName = "fldTimeFrom"
        fldTimeFrom.TextAlignment = ContentAlignment.MiddleCenter
        fldTimeFrom.Width = 150
        fldTimeFrom.FormatString = "{0:HH':'mm}"
        gvData.Columns.Add(fldTimeFrom)

        Dim fldTimeTo As New GridViewDateTimeColumn
        fldTimeTo.HeaderText = "To"
        fldTimeTo.FieldName = "fldTimeTo"
        fldTimeTo.TextAlignment = ContentAlignment.MiddleCenter
        fldTimeTo.Width = 150
        fldTimeTo.FormatString = "{0:HH':'mm}"
        gvData.Columns.Add(fldTimeTo)

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If Tohka.InsertTime(Mio.ATDRID, Mio.ATType, tpFrom.Value, tpTo.Value, globalVariables.currentUser(1), ddITType.Text) Then
            RadMessageBox.Show("Time Added")
        Else
            RadMessageBox.Show("Error Occured")
        End If
        ReloadGrid()
    End Sub


    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        Else
            If Tohka.DeleteTime(gvData.CurrentRow.Cells("fldID").Value) Then
                RadMessageBox.Show("Item Deleted")
            Else
                RadMessageBox.Show("Error Occured")
            End If
            ReloadGrid()
        End If
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadGrid()
    End Sub

    Public Sub ReloadGrid()
        gvData.DataSource = Tohka.SelectTime(Mio.ATDRID, Mio.ATType)
    End Sub

    Private Sub ddITType_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddITType.SelectedIndexChanged

    End Sub
End Class
