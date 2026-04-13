Imports System.ComponentModel
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ucDailyManpower
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Dim Kurumi As New Kurumi.DB("192.168.191.252", "dbHRMSlive", "feap", "45|iF$")
    Dim ProdEmp As DataTable = Kurumi.MyQuery("SELECT fldEmpNo,fldEmpName FROM dbHRMSlive.tblEmployee where fldEmpDepartment='PROD' and fldEmpSection='ASSY' and fldEmpStatus='ACTIVE' order by fldEmpName asc")
    Dim rowIndex As Integer
    Private Sub ucDailyManpower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeThemeUC(Me)
        GridCol()
        ReloadData()
    End Sub

    Private Sub GridCol()
        Dim fldProcessName As New GridViewTextBoxColumn
        fldProcessName.HeaderText = "Assembly Process Name"
        fldProcessName.FieldName = "fldProcessName"
        fldProcessName.TextAlignment = ContentAlignment.MiddleCenter
        fldProcessName.Width = 100
        fldProcessName.ReadOnly = True
        gvData.Columns.Add(fldProcessName)

        'Dim fldEmployee As New GridViewComboBoxColumn
        'fldEmployee.FieldName = "fldEmployee"
        'fldEmployee.HeaderText = "Employee Name"
        'fldEmployee.DataSource = Me.ProdEmp
        'fldEmployee.ValueMember = "fldEmpName"
        'fldEmployee.DisplayMember = "fldEmpName"
        'fldEmployee.Width = 100
        'Me.gvData.Columns.Add(fldEmployee)


        Dim fldEmployee As New GridViewTextBoxColumn
        fldEmployee.HeaderText = "Employee Name"
        fldEmployee.FieldName = "fldEmployee"
        fldEmployee.TextAlignment = ContentAlignment.MiddleCenter
        fldEmployee.Width = 100
        gvData.Columns.Add(fldEmployee)


        Dim fldQualified As New GridViewCheckBoxColumn()
        fldQualified.DataType = GetType(Integer)
        fldQualified.Name = "fldQualified"
        fldQualified.FieldName = "fldQualified"
        fldQualified.HeaderText = "Qualified"
        gvData.MasterTemplate.Columns.Add(fldQualified)

        Dim fldTransferred As New GridViewCheckBoxColumn()
        fldTransferred.DataType = GetType(Integer)
        fldTransferred.Name = "fldTransferred"
        fldTransferred.FieldName = "fldTransferred"
        fldTransferred.HeaderText = "Transferred"
        gvData.MasterTemplate.Columns.Add(fldTransferred)

        Dim fldTrainee As New GridViewCheckBoxColumn()
        fldTrainee.DataType = GetType(Integer)
        fldTrainee.Name = "fldTrainee"
        fldTrainee.FieldName = "fldTrainee"
        fldTrainee.HeaderText = "TRAINEE"
        gvData.MasterTemplate.Columns.Add(fldTrainee)
    End Sub

    Private Sub ReloadData()

        Dim checkexist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCManpower where fldDRID=" & globalVariables.DailyRepID & "")

        If checkexist.Rows.Count >= 1 Then

            gvData.DataSource = checkexist

        Else
            Maria.AddMySqlParameters("parCode", globalVariables.ModelCode)
            Maria.AddMySqlParameters("parLine", globalVariables.ModelLine)
            Dim OwO As DataTable = Maria.SPSelect("SP_SRCDailyReport_SelectManpowerTemp2")

            If globalVariables.DailyRepShift = "6AM-2PM(1st Shift)" Then
                Dim UwU = (From t1 In OwO.AsEnumerable
                           Select New With {
                           .fldProcessName = t1("fldProcessName"),
                           .fldEmployee = t1("fldEmployee")
                    }).ToList

                gvData.DataSource = convertToDatatable(UwU)
            ElseIf globalVariables.DailyRepShift = "2PM-10PM(2nd Shift)" Then
                Dim UwU = (From t1 In OwO.AsEnumerable
                           Select New With {
                           .fldProcessName = t1("fldProcessName"),
                           .fldEmployee = t1("fldEmployee2")
                    }).ToList

                gvData.DataSource = convertToDatatable(UwU)
            ElseIf globalVariables.DailyRepShift = "10PM-6AM(3rd Shift)" Then
                Dim UwU = (From t1 In OwO.AsEnumerable
                           Select New With {
                           .fldProcessName = t1("fldProcessName"),
                           .fldEmployee = t1("fldEmployee3")
                    }).ToList

                gvData.DataSource = convertToDatatable(UwU)
            ElseIf globalVariables.DailyRepShift = "6AM-6PM" Then
                Dim UwU = (From t1 In OwO.AsEnumerable
                           Select New With {
                           .fldProcessName = t1("fldProcessName"),
                           .fldEmployee = t1("fldEmployeeDay")
                    }).ToList

                gvData.DataSource = convertToDatatable(UwU)
            ElseIf globalVariables.DailyRepShift = "6PM-6AM" Then
                Dim UwU = (From t1 In OwO.AsEnumerable
                           Select New With {
                           .fldProcessName = t1("fldProcessName"),
                           .fldEmployee = t1("fldEmployeeNight")
                    }).ToList

                gvData.DataSource = convertToDatatable(UwU)
            End If
            'gvData.DataSource = Maria.SPSelect("SP_SRCDailyReport_SelectManpowerTemp")

        End If

    End Sub

    Private Sub cbbTemplate_Click(sender As Object, e As EventArgs) Handles cbbTemplate.Click
        FrmManpowerTemplate.MdiParent = frmBase
        FrmManpowerTemplate.Show()
    End Sub

    Private Sub cbbSave_Click(sender As Object, e As EventArgs) Handles cbbSave.Click
        Dim checkexist As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCManpower where fldDRID=" & globalVariables.DailyRepID & "")
        If checkexist.Rows.Count >= 1 Then
            Maria.MyQuery("Delete from tblDailyReportSRCManpower where fldDRID=" & globalVariables.DailyRepID & "")
        End If
        cbbReload.Enabled = False
        cbbSave.Enabled = False
        cbbClear.Enabled = False
        cbbTemplate.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub



    Private Sub gvData_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gvData.CellFormatting
        Try
            If e.CellElement.ColumnInfo.FieldName = "fldEmployee" Then
                If e.CellElement.RowInfo.Cells("fldEmployee").Value.ToString.Trim = "" Then
                    e.CellElement.DrawFill = True
                    e.CellElement.ForeColor = Color.White
                    e.CellElement.BackColor = Color.LightPink
                    e.CellElement.BackColor2 = Color.LightPink
                Else
                    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
                End If
            ElseIf e.CellElement.ColumnInfo.FieldName = "fldQualified" Or e.CellElement.ColumnInfo.FieldName = "fldTransferred" Or e.CellElement.ColumnInfo.FieldName = "fldTrainee" Then
                If e.CellElement.RowInfo.Cells("fldQualified").Value = False And e.CellElement.RowInfo.Cells("fldTransferred").Value = False And e.CellElement.RowInfo.Cells("fldTrainee").Value = False Then
                    e.CellElement.DrawFill = True
                    e.CellElement.ForeColor = Color.White
                    e.CellElement.BackColor = Color.LightPink
                    e.CellElement.BackColor2 = Color.LightPink
                Else
                    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
                End If

            ElseIf e.CellElement.ColumnInfo.FieldName = "fldProcessName" Then
                e.CellElement.DrawFill = True
                e.CellElement.ForeColor = Color.Black
                e.CellElement.BackColor = Color.Silver
                e.CellElement.BackColor2 = Color.Silver
            Else

                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim checkexistManpower As DataTable = Maria.MyQuery("SELECT * FROM tblDailyReportSRCManpower where fldDRID=" & globalVariables.DailyRepID & "")
        If checkexistManpower.Rows.Count >= 1 Then
            Try
                Maria.MyQuery("Delete from tblDailyReportSRCManpower where fldDRID=" & globalVariables.DailyRepID & "")
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
                Maria.Connection.Close()
            End Try

        End If
        For rowcounter As Integer = 0 To Me.gvData.Rows.Count - 1
            Try
                Dim DRID As Integer = globalVariables.DailyRepID
                Dim ProcessName As String = gvData.Rows(rowcounter).Cells("fldProcessName").Value.ToString
                Dim Employee As String = DirectCast(gvData.Rows(rowcounter).Cells("fldEmployee").Value, String)
                Dim Qualified As Boolean = gvData.Rows(rowcounter).Cells("fldQualified").Value
                Dim Transferred As Boolean = gvData.Rows(rowcounter).Cells("fldTransferred").Value
                Dim Trainee As Boolean = gvData.Rows(rowcounter).Cells("fldTrainee").Value
                Dim CurrUser As String = globalVariables.currentUser(1)

                Maria.AddMySqlParameters("parDRID", DRID)
                Maria.AddMySqlParameters("parProcName", ProcessName)
                Maria.AddMySqlParameters("parEmp", Employee)
                Maria.AddMySqlParameters("parQualified", Qualified)
                Maria.AddMySqlParameters("parTrans", Transferred)
                Maria.AddMySqlParameters("parTrain", Trainee)
                Maria.AddMySqlParameters("parUser", CurrUser)
                Maria.SPADE("SP_SRC_InsertManpowerData")

                Threading.Thread.Sleep(60)
                Dim RowCount As Integer = gvData.Rows.Count
                rowIndex = rowcounter
                Dim percent As Double = (rowcounter / RowCount * 100)
                BackgroundWorker1.ReportProgress(Convert.ToInt32(percent))
            Catch ex As Exception
                RadMessageBox.Show(ex.Message)
                Maria.Connection.Close()

                cbbReload.Enabled = True
                cbbSave.Enabled = True
                cbbClear.Enabled = True
                cbbTemplate.Enabled = True
            End Try
        Next

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        RadMessageBox.Show("Done!")

        cbbReload.Enabled = True
        cbbSave.Enabled = True
        cbbClear.Enabled = True
        cbbTemplate.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        gvData.CurrentRow = gvData.Rows(rowIndex)
    End Sub

    Private Sub cbbReload_Click(sender As Object, e As EventArgs) Handles cbbReload.Click
        Dim result As Integer = RadMessageBox.Show("Reloading Template will remove all the the data you inputed. Continue?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Maria.AddMySqlParameters("parCode", globalVariables.ModelCode)
            Maria.AddMySqlParameters("parLine", globalVariables.ModelLine)
            gvData.DataSource = Nothing
            gvData.DataSource = Maria.SPSelect("SP_SRCDailyReport_SelectManpowerTemp2")
        End If

    End Sub

    Private Sub cbbClear_Click(sender As Object, e As EventArgs) Handles cbbClear.Click
        Dim result As Integer = RadMessageBox.Show("Reloading Template will remove all the the data you inputed. Continue?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Maria.AddMySqlParameters("parCode", globalVariables.ModelCode)
            gvData.DataSource = Nothing
            gvData.DataSource = Maria.SPSelect("SP_SRCDailyReport_SelectManpowerTemp")
        End If
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
