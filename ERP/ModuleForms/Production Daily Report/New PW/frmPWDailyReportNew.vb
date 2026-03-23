Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class FrmPWDailyReportNew
    Dim DTManPowerProc As DataTable
    Private Sub FrmPWDailyReportNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReloadMPWeldNo()
        GridColManPower()
        ReloadGQWeldNo()
        GridColGoodQty()
        ReloadInteruptPWNo()
    End Sub

#Region "Manpower"
    Private Sub ReloadMPWeldNo()

        RemoveHandler ddMPPW.SelectedIndexChanged, AddressOf ddMPPW_SelectedIndexChanged
        Dim DTManpower As DataTable = Tohka.SelectPWByModel(Mio.PWModel, Mio.PWLine, "PW")
        ddMPPW.DataSource = DTManpower
        ddMPPW.DisplayMember = "fldPWFWNo"
        ddMPPW.ValueMember = "fldPWFWNo"
        ddMPPW.AutoCompleteDataSource = DTManpower
        ddMPPW.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddMPPW.AutoCompleteDisplayMember = "fldPWFWNo"
        ddMPPW.AutoCompleteValueMember = "fldPWFWNo"
        ddMPPW.Text = ""
        AddHandler ddMPPW.SelectedIndexChanged, AddressOf ddMPPW_SelectedIndexChanged

    End Sub

    Private Sub ddMPPW_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddMPPW.SelectedIndexChanged

        RemoveHandler ddMPProc.SelectedIndexChanged, AddressOf ddMPProc_SelectedIndexChanged
        Dim DTManpowerProc As DataTable = Tohka.SelectPWManPowerProc(Mio.PWModel, Mio.PWLine, "PW", ddMPPW.Text)
        ddMPProc.DataSource = DTManpowerProc
        ddMPProc.DisplayMember = "fldProcessName"
        ddMPProc.ValueMember = "fldProcessName"
        ddMPProc.AutoCompleteDataSource = DTManpowerProc
        ddMPProc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddMPProc.AutoCompleteDisplayMember = "fldProcessName"
        ddMPProc.AutoCompleteValueMember = "fldProcessName"
        ddMPProc.Text = ""
        AddHandler ddMPProc.SelectedIndexChanged, AddressOf ddMPProc_SelectedIndexChanged
        ReloadManpowerGrid()
    End Sub

    Private Sub ddMPProc_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddMPProc.SelectedIndexChanged
        tbMPEmpName.Text = ""
        Dim DTManpowerEmp As DataTable = Tohka.SelectPWManPowerProcName(Mio.PWModel, Mio.PWLine, "PW", ddMPPW.Text, ddMPProc.Text)
        tbMPEmpName.Text = DTManpowerEmp.Rows(0).Item("fldEmployee").ToString
    End Sub

    Private Sub GridColManPower()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.ReadOnly = True
        rgvManpower.Columns.Add(fldID)

        Dim fldProcessName As New GridViewTextBoxColumn
        fldProcessName.HeaderText = "Assembly Process Name"
        fldProcessName.FieldName = "fldProcName"
        fldProcessName.TextAlignment = ContentAlignment.MiddleCenter
        fldProcessName.Width = 100
        fldProcessName.ReadOnly = True
        rgvManpower.Columns.Add(fldProcessName)

        Dim fldEmployee As New GridViewTextBoxColumn
        fldEmployee.FieldName = "fldEmployee"
        fldEmployee.HeaderText = "Employee Name"
        fldEmployee.TextAlignment = ContentAlignment.MiddleCenter
        fldEmployee.Width = 100
        fldEmployee.ReadOnly = True
        Me.rgvManpower.Columns.Add(fldEmployee)

        Dim fldQualified As New GridViewCheckBoxColumn()
        fldQualified.DataType = GetType(Integer)
        fldQualified.Name = "fldQualified"
        fldQualified.FieldName = "fldQualified"
        fldQualified.HeaderText = "Qualified"
        fldQualified.ReadOnly = True
        rgvManpower.MasterTemplate.Columns.Add(fldQualified)

        Dim fldTransferred As New GridViewCheckBoxColumn()
        fldTransferred.DataType = GetType(Integer)
        fldTransferred.Name = "fldTransfer"
        fldTransferred.FieldName = "fldTransfer"
        fldTransferred.HeaderText = "Transferred"
        fldTransferred.ReadOnly = True
        rgvManpower.MasterTemplate.Columns.Add(fldTransferred)

        Dim fldTrainee As New GridViewCheckBoxColumn()
        fldTrainee.DataType = GetType(Integer)
        fldTrainee.Name = "fldTrainee"
        fldTrainee.FieldName = "fldTrainee"
        fldTrainee.HeaderText = "TRAINEE"
        fldTrainee.ReadOnly = True
        rgvManpower.MasterTemplate.Columns.Add(fldTrainee)

    End Sub

    Public Sub ReloadManpowerGrid()
        rgvManpower.DataSource = Tohka.SelectPWManpower(Mio.PWDRID, "PW", ddMPPW.Text)
    End Sub

    Private Sub btnMPSubmit_Click(sender As Object, e As EventArgs) Handles btnMPSubmit.Click
        Dim IntQualified As Integer = 0
        Dim IntTransfer As Integer = 0
        Dim Trainee As Integer = 0

        If ddMPStatus.Text = "Qualified" Then
            IntQualified = 1
            IntTransfer = 0
            Trainee = 0
        ElseIf ddMPStatus.Text = "Transferred" Then
            IntQualified = 0
            IntTransfer = 1
            Trainee = 0
        ElseIf ddMPStatus.Text = "Trainee" Then
            IntQualified = 0
            IntTransfer = 0
            Trainee = 1
        End If

        If btnMPSubmit.Text = "SAVE" Then

            Dim StrMessage As String = Tohka.InsertPWManpower(Mio.PWDRID, "PW", ddMPPW.Text, ddMPProc.Text, tbMPEmpName.Text, IntQualified, IntTransfer, Trainee, globalVariables.currentUser(1))
            MessageBox.Show(StrMessage)

            ReloadManpowerGrid()

        Else

            Dim StrMessage As String = Tohka.EditPWManpower(lblEditID.Text, ddMPPW.Text, ddMPProc.Text, tbMPEmpName.Text, IntQualified, IntTransfer, Trainee)
            MessageBox.Show(StrMessage)

            ReloadManpowerGrid()

            btnMPSubmit.Text = "SAVE"
            btnMPCancel.Visible = False

        End If
    End Sub

    Private Sub rgvManpower_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvManpower.CellDoubleClick

        lblEditID.Text = rgvManpower.CurrentRow.Cells("fldID").Value.ToString
        ddMPProc.Text = rgvManpower.CurrentRow.Cells("fldProcName").Value.ToString
        tbMPEmpName.Text = rgvManpower.CurrentRow.Cells("fldEmployee").Value.ToString
        ddMPStatus.Text = ""
        If rgvManpower.CurrentRow.Cells("fldQualified").Value = 1 Then
            ddMPStatus.Text = "Qualified"
        End If
        If rgvManpower.CurrentRow.Cells("fldTransfer").Value = 1 Then
            ddMPStatus.Text = "Transferred"
        End If
        If rgvManpower.CurrentRow.Cells("fldTrainee").Value = 1 Then
            ddMPStatus.Text = "Trainee"
        End If

        btnMPSubmit.Text = "EDIT"
        btnMPCancel.Visible = True

    End Sub

    Private Sub btnMPCancel_Click(sender As Object, e As EventArgs) Handles btnMPCancel.Click
        btnMPSubmit.Text = "SAVE"
        btnMPCancel.Visible = False
    End Sub

    Private Sub rgvManpower_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvManpower.KeyDown

        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                MessageBox.Show(Tohka.DeletePWManpower(rgvManpower.CurrentRow.Cells("fldID").Value))
                ReloadManpowerGrid()
            End If
        End If

    End Sub

#End Region

#Region "Good Qty"

    Private Sub ReloadGQWeldNo()
        RemoveHandler ddGQPWNo.SelectedIndexChanged, AddressOf ddGQPWNo_SelectedIndexChanged
        Dim DTGoodQty As DataTable = Tohka.SelectPWByModel(Mio.PWModel, Mio.PWLine, "PW")
        ddGQPWNo.DataSource = DTGoodQty
        ddGQPWNo.DisplayMember = "fldPWFWNo"
        ddGQPWNo.ValueMember = "fldPWFWNo"
        ddGQPWNo.AutoCompleteDataSource = DTGoodQty
        ddGQPWNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddGQPWNo.AutoCompleteDisplayMember = "fldPWFWNo"
        ddGQPWNo.AutoCompleteValueMember = "fldPWFWNo"
        ddGQPWNo.Text = ""
        AddHandler ddGQPWNo.SelectedIndexChanged, AddressOf ddGQPWNo_SelectedIndexChanged
    End Sub

    Private Sub ddGQPWNo_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles ddGQPWNo.SelectedIndexChanged
        Dim DTGoodQtyTemp As DataTable = Tohka.SelectPWGoodQtyTemplate(Mio.PWModel, "PW", ddGQPWNo.Text, Mio.PWLine)
        ddGQPartName.DataSource = DTGoodQtyTemp
        ddGQPartName.DisplayMember = "fldPartName"
        ddGQPartName.ValueMember = "fldPartName"
        ddGQPartName.AutoCompleteDataSource = DTGoodQtyTemp
        ddGQPartName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddGQPartName.AutoCompleteDisplayMember = "fldPartName"
        ddGQPartName.AutoCompleteValueMember = "fldPartName"
        ddGQPartName.Text = ""

        ReloadGoodQtyGrid()
    End Sub

    Private Sub ReloadGoodQtyGrid()
        rgvGoodQty.DataSource = Tohka.SelectPWGoodQty(Mio.PWDRID, "PW", ddGQPWNo.Text)
    End Sub

    Private Sub GridColGoodQty()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.ReadOnly = True
        rgvGoodQty.Columns.Add(fldID)

        Dim fldPartName As New GridViewTextBoxColumn
        fldPartName.HeaderText = "Part Name"
        fldPartName.FieldName = "fldPartName"
        fldPartName.TextAlignment = ContentAlignment.MiddleCenter
        fldPartName.Width = 100
        fldPartName.ReadOnly = True
        rgvGoodQty.Columns.Add(fldPartName)

        Dim fldQty As New GridViewTextBoxColumn
        fldQty.FieldName = "fldQty"
        fldQty.HeaderText = "Qty"
        fldQty.TextAlignment = ContentAlignment.MiddleCenter
        fldQty.Width = 60
        fldQty.ReadOnly = True
        Me.rgvGoodQty.Columns.Add(fldQty)

    End Sub

    Private Sub rgvGoodQty_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvGoodQty.CellDoubleClick

        lblEditID.Text = rgvGoodQty.CurrentRow.Cells("fldID").Value.ToString
        ddGQPartName.Text = rgvGoodQty.CurrentRow.Cells("fldPartName").Value.ToString
        spnGQQty.Value = rgvGoodQty.CurrentRow.Cells("fldQty").Value
        btnGQSubmit.Text = "EDIT"
        ddGQPWNo.Enabled = False
        btnGQCancel.Visible = True

    End Sub

    Private Sub btnGQCancel_Click(sender As Object, e As EventArgs) Handles btnGQCancel.Click
        btnGQSubmit.Text = "SAVE"
        ddGQPWNo.Enabled = True
        btnGQCancel.Visible = False
        spnGQQty.Value = 0
    End Sub

    Private Sub btnGQSubmit_Click(sender As Object, e As EventArgs) Handles btnGQSubmit.Click

        If btnGQSubmit.Text = "SAVE" Then
            MessageBox.Show(Tohka.InsertPWGoodQty(Mio.PWDRID, "PW", ddGQPWNo.Text, ddGQPartName.Text, spnGQQty.Value, globalVariables.currentUser(1)))
        Else
            MessageBox.Show(Tohka.UpdatePWGoodQty(lblEditID.Text, ddGQPartName.Text, spnGQQty.Value))
            btnGQSubmit.Text = "SAVE"
            ddGQPWNo.Enabled = True
            btnGQCancel.Visible = False
            spnGQQty.Value = 0
        End If
        ReloadGoodQtyGrid()

    End Sub

    Private Sub rgvGoodQty_KeyDown(sender As Object, e As KeyEventArgs) Handles rgvGoodQty.KeyDown

        If e.KeyCode = Keys.Delete Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete?", "Yes or No?", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            Else
                MessageBox.Show(Tohka.DeletePWGoodQty(rgvGoodQty.CurrentRow.Cells("fldID").Value))
                ReloadGoodQtyGrid()
            End If
        End If

    End Sub

#End Region

#Region "Interuption"

    Private Sub ReloadInteruptPWNo()

        RemoveHandler ddITType.SelectedIndexChanged, AddressOf ddMPPW_SelectedIndexChanged
        Dim DTInteruption As DataTable = Tohka.SelectPWByModel(Mio.PWModel, Mio.PWLine, "PW")
        ddITType.DataSource = DTInteruption
        ddITType.DisplayMember = "fldPWFWNo"
        ddITType.ValueMember = "fldPWFWNo"
        ddITType.AutoCompleteDataSource = DTInteruption
        ddITType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddITType.AutoCompleteDisplayMember = "fldPWFWNo"
        ddITType.AutoCompleteValueMember = "fldPWFWNo"
        ddITType.Text = ""
        AddHandler ddITType.SelectedIndexChanged, AddressOf ddMPPW_SelectedIndexChanged

    End Sub

#End Region

End Class
