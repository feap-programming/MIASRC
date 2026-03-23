Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FldAssemblyDowntimeMain
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    'Dim Maria As New DB("localhost", "dbmia", "root", "password")
    Dim DTModel As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")
    Private Sub FldAssemblyDowntimeMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dpDate.Value = Now
        RemoveHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged
        GetModels()
        AddHandler ddModel.SelectedIndexChanged, AddressOf ddModel_SelectedIndexChanged
        GridCol()

        If globalVariables.DowntimeType = "ASSY" Then
            ddType.Visible = False
            RadLabel1.Visible = False
            lblFwGroup.Visible = False
            ddFwGroup.Visible = False
        ElseIf globalVariables.DowntimeType = "FW" Then

            lblFwGroup.Visible = True
            ddFwGroup.Visible = True
            ddType.Text = "FW"
        ElseIf globalVariables.DowntimeType = "PW" Then
            lblFwGroup.Visible = False
            ddFwGroup.Visible = False
            ddType.Text = "PW"
        Else
            If globalVariables.DowntimeType = "Taping" Then
                ddType.Text = "TM"
            End If
            ddType.Visible = True
            ddFwGroup.Visible = False
            lblFwGroup.Visible = False
            RadLabel1.Visible = True

        End If
        ReloadGrid()
    End Sub
    Private Sub GetModels()

        ddModel.DataSource = DTModel
        ddModel.DisplayMember = "fldModelName"
        ddModel.ValueMember = "fldCode"
        ddModel.AutoCompleteDataSource = DTModel
        ddModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModel.AutoCompleteDisplayMember = "fldModelName"
        ddModel.AutoCompleteValueMember = "fldCode"
        ddModel.Text = ""

    End Sub
    Private Sub ReloadGrid()

        If globalVariables.DowntimeType = "ASSY" Then
            gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportDownMain where fldType='" & globalVariables.DowntimeType & "' and fldStatus='Active' order by fldDate desc")
        Else
            gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportDownMain where fldType='" & ddType.Text & "' and fldStatus='Active' order by fldDate desc")
        End If

    End Sub
    Private Sub GridCol()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.ReadOnly = True
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldDate As New GridViewTextBoxColumn
        fldDate.HeaderText = "DATE"
        fldDate.FieldName = "fldDate"
        fldDate.TextAlignment = ContentAlignment.MiddleCenter
        fldDate.Width = 100
        fldDate.FormatString = "{0:MMM/dd/yyy}"
        fldDate.ReadOnly = True
        gvData.Columns.Add(fldDate)

        Dim fldModel As New GridViewTextBoxColumn
        fldModel.HeaderText = "MODEL"
        fldModel.FieldName = "fldModel"
        fldModel.TextAlignment = ContentAlignment.MiddleCenter
        fldModel.Width = 100
        fldModel.ReadOnly = True
        gvData.Columns.Add(fldModel)

        Dim fldType As New GridViewTextBoxColumn
        fldType.HeaderText = "TYPE"
        fldType.FieldName = "fldType"
        fldType.TextAlignment = ContentAlignment.MiddleCenter
        fldType.Width = 100
        fldType.ReadOnly = True
        gvData.Columns.Add(fldType)

        Dim fldGroup As New GridViewTextBoxColumn
        fldGroup.HeaderText = "FW GROUP"
        fldGroup.FieldName = "fldFwGroup"
        fldGroup.TextAlignment = ContentAlignment.MiddleCenter
        fldGroup.Width = 100
        fldGroup.ReadOnly = True
        gvData.Columns.Add(fldGroup)

        If globalVariables.DowntimeType = "FW" Then
            fldGroup.IsVisible = True
        Else
            fldGroup.IsVisible = False
        End If

        Dim fldLine As New GridViewTextBoxColumn
        fldLine.HeaderText = "LINE"
        fldLine.FieldName = "fldLine"
        fldLine.TextAlignment = ContentAlignment.MiddleCenter
        fldLine.Width = 100
        fldLine.ReadOnly = True
        gvData.Columns.Add(fldLine)


    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Dim CheckModel = (From t1 In DTModel.AsEnumerable
                          Where t1("fldModelName").Equals(ddModel.Text.ToString)
                          Select New With {
                                .fldModelName = t1("fldModelName")
                            }).ToList
        If tbMachNo.Text <> "" Then
            If CheckModel.Count >= 1 Then
                Try

                    Maria.AddMySqlParameters("parDate", dpDate.Value)
                    Maria.AddMySqlParameters("parModel", ddModel.Text)
                    Maria.AddMySqlParameters("parLine", ddLine.Text)
                    If globalVariables.DowntimeType = "ASSY" Then
                        Maria.AddMySqlParameters("parType", globalVariables.DowntimeType)
                    Else
                        Maria.AddMySqlParameters("parType", ddType.Text)
                    End If

                    Dim checkexist As DataTable = Maria.SPSelect("SP_SRCDownTime_SelectDownTimeMainByDatev2")

                    If checkexist.Rows.Count >= 1 Then
                        RadMessageBox.Show("Already Added!")
                    Else
                        If globalVariables.DowntimeType = "FW" And ddFwGroup.SelectedIndex = -1 Then
                            RadMessageBox.Show("Please add FW Group", "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error)
                        Else
                            Maria.AddMySqlParameters("parDate", dpDate.Value)
                            Maria.AddMySqlParameters("parModel", ddModel.Text)
                            Maria.AddMySqlParameters("parLine", ddLine.Text)
                            If globalVariables.DowntimeType = "ASSY" Then
                                Maria.AddMySqlParameters("parType", globalVariables.DowntimeType)
                                Maria.AddMySqlParameters("parFwGroup", 0)
                            ElseIf globalVariables.DowntimeType = "PW" Then
                                Maria.AddMySqlParameters("parType", ddType.Text)
                                Maria.AddMySqlParameters("parFwGroup", 0)
                            ElseIf globalVariables.DowntimeType = "FW" Then
                                Maria.AddMySqlParameters("parType", ddType.Text)
                                Maria.AddMySqlParameters("parFwGroup", ddFwGroup.Text)
                            ElseIf globalVariables.DowntimeType = "Taping" Then
                                Maria.AddMySqlParameters("parType", ddType.Text)
                                Maria.AddMySqlParameters("parFwGroup", 0)
                            End If
                            Maria.AddMySqlParameters("parMachNo", tbMachNo.Text)
                            Maria.SPADE("SP_SRCDownTime_InsertDownTimeMain4")
                            RadMessageBox.Show("Done")
                            ReloadGrid()
                        End If
                    End If

                Catch ex As Exception
                    RadMessageBox.Show(ex.Message)
                    Maria.Connection.Close()
                End Try
            Else
                RadMessageBox.Show("Model Name Incorrect")
            End If
        Else
            RadMessageBox.Show("Machine No. is Required!", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If



    End Sub

    Private Sub cbbDownTime_Click(sender As Object, e As EventArgs) Handles cbbDownTime.Click

        globalVariables.AssyDownTimeID = gvData.CurrentRow.Cells("fldID").Value
        globalVariables.AssyDownTimeModel = gvData.CurrentRow.Cells("fldModel").Value.ToString
        If globalVariables.DowntimeType = "Taping" Then
            Dim lineValue As String = gvData.CurrentRow.Cells("fldLine").Value.ToString()
            globalVariables.AssyDownTimeLine = lineValue.Replace("L", "")
        Else
            globalVariables.AssyDownTimeLine = gvData.CurrentRow.Cells("fldLine").Value.ToString
        End If
        globalVariables.AssyDownTimeDate = gvData.CurrentRow.Cells("fldDate").Value.ToString
        globalVariables.AssyDownTimeType = gvData.CurrentRow.Cells("fldType").Value.ToString
        globalVariables.FWGroupDt = gvData.CurrentRow.Cells("fldFwGroup").Value.ToString
        'FrmAssemblyDownTime.MdiParent = frmBase
        FrmAssemblyDownTime.Show()
        Me.Close()

    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click

        Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        Else
            Dim DeleteID As Int32 = gvData.CurrentRow.Cells("fldID").Value
            Maria.MyQuery("Delete From tblDailyReportDownMain where fldID=" & DeleteID & "")
            ReloadGrid()
        End If

    End Sub

    Private Sub cbbReport_Click(sender As Object, e As EventArgs) Handles cbbReport.Click

        globalVariables.AssyDownTimeID = gvData.CurrentRow.Cells("fldID").Value
        globalVariables.AssyDownTimeLine = gvData.CurrentRow.Cells("fldLine").Value.ToString()
        globalVariables.parModel = gvData.CurrentRow.Cells("fldModel").Value.ToString()
        globalVariables.AssyDownTimeDate = gvData.CurrentRow.Cells("fldDate").Value.ToString()
        globalVariables.FWGroupDt = gvData.CurrentRow.Cells("fldFwGroup").Value.ToString()
        globalVariables.SRCReportType = "Down Time"


        If globalVariables.DowntimeType = "ASSY" Then
            FrmDowntimeReportSelector.Show()
        Else
            FrmSRCDailyReportViewer.Show()
        End If



    End Sub

    Private Sub ddType_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddType.SelectedIndexChanged
        gvData.DataSource = Maria.MyQuery("SELECT * FROM tblDailyReportDownMain where fldType='" & ddType.Text & "' order by fldDate desc")
    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click

    End Sub

    Private Sub ddModel_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddModel.SelectedIndexChanged
        'If ddType.Text = "TM" Then
        '    Dim getWeldNo As DataTable = Maria.MyQuery("Select distinct fldMachNo FROM tblDailyReportATManpowerTemp where fldModel='" & ddModel.Text & "' and fldLine='" & ddLine.Text.Chars(1) & "'")
        '    'ddWeldingNo.DataSource = getWeldNo
        '    'ddWeldingNo.DisplayMember = "fldMachNo"
        '    'ddWeldingNo.ValueMember = "fldMachNo"
        '    'ddWeldingNo.AutoCompleteDataSource = getWeldNo
        '    'ddWeldingNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    'ddWeldingNo.AutoCompleteDisplayMember = "fldMachNo"
        '    'ddWeldingNo.AutoCompleteValueMember = "fldMachNo"
        '    tbMachNo.Text = getWeldNo.Rows(0).Item("fldMachNo").ToString()
        'Else
        '    'Dim getWeldNo As DataTable = Maria.MyQuery("Select distinct fldPWFWNo FROM dbMIA.tblDailyReportWeldingTemplate where fldModel='" & ddModel.Text & "' and fldType='" & ddType.Text & "'")
        '    'ddWeldingNo.DataSource = getWeldNo
        '    'ddWeldingNo.DisplayMember = "fldPWFWNo"
        '    'ddWeldingNo.ValueMember = "fldPWFWNo"
        '    'ddWeldingNo.AutoCompleteDataSource = getWeldNo
        '    'ddWeldingNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    'ddWeldingNo.AutoCompleteDisplayMember = "fldPWFWNo"
        '    'ddWeldingNo.AutoCompleteValueMember = "fldPWFWNo"
        'End If




    End Sub

    Private Sub cbbUpload_Click(sender As Object, e As EventArgs) Handles cbbUpload.Click
        Dim OwO As New FrmDownTimeUpload()
        OwO.Show()
    End Sub

    Private Sub FldAssemblyDowntimeMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        globalVariables.SRCReportType = globalVariables.LastSRCReportType
    End Sub
End Class
