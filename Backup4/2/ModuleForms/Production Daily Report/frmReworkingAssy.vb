Imports FEAPNS.DataAccess
Imports Telerik.WinControls.UI

Public Class FrmReworkingAssy
    Dim Maria As New DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub FrmReworkingAssy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridCol()
        LoadModelFrom()
        LoadModelTo()
        ReloadGrid()
    End Sub

    Private Sub LoadModelFrom()
        Dim DTModelFrom As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")

        ddModelFrom.DataSource = DTModelFrom
        ddModelFrom.DisplayMember = "fldModelName"
        ddModelFrom.ValueMember = "fldCode"
        ddModelFrom.AutoCompleteDataSource = DTModelFrom
        ddModelFrom.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModelFrom.AutoCompleteDisplayMember = "fldModelName"
        ddModelFrom.AutoCompleteValueMember = "fldCode"
        ddModelFrom.Text = ""
    End Sub

    Private Sub LoadModelTo()

        Dim DTModelTo As DataTable = Maria.MyQuery("SELECT * FROM tblModelList")

        ddModelTo.DataSource = DTModelTo
        ddModelTo.DisplayMember = "fldModelName"
        ddModelTo.ValueMember = "fldCode"
        ddModelTo.AutoCompleteDataSource = DTModelTo
        ddModelTo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ddModelTo.AutoCompleteDisplayMember = "fldModelName"
        ddModelTo.AutoCompleteValueMember = "fldCode"
        ddModelTo.Text = ""

    End Sub

    Private Sub GridCol()
        gvData.DataSource = Nothing
        gvData.Columns.Clear()

        Dim fldID As New GridViewTextBoxColumn
        fldID.HeaderText = "ID"
        fldID.FieldName = "fldID"
        fldID.TextAlignment = ContentAlignment.MiddleCenter
        fldID.Width = 100
        fldID.IsVisible = False
        gvData.Columns.Add(fldID)

        Dim fldDate As New GridViewTextBoxColumn
        fldDate.HeaderText = "Date"
        fldDate.FieldName = "fldDate"
        fldDate.TextAlignment = ContentAlignment.MiddleCenter
        fldDate.Width = 150
        fldDate.FormatString = "{0:MMM/dd/yy}"
        gvData.Columns.Add(fldDate)

        Dim fldShift As New GridViewTextBoxColumn
        fldShift.HeaderText = "Shift"
        fldShift.FieldName = "fldShift"
        fldShift.TextAlignment = ContentAlignment.MiddleCenter
        fldShift.Width = 150
        gvData.Columns.Add(fldShift)

        Dim fldLine As New GridViewTextBoxColumn
        fldLine.HeaderText = "Line"
        fldLine.FieldName = "fldLine"
        fldLine.TextAlignment = ContentAlignment.MiddleCenter
        fldLine.Width = 90
        gvData.Columns.Add(fldLine)

        Dim fldTL As New GridViewTextBoxColumn
        fldTL.HeaderText = "Line Leader"
        fldTL.FieldName = "fldTL"
        fldTL.TextAlignment = ContentAlignment.MiddleCenter
        fldTL.Width = 150
        gvData.Columns.Add(fldTL)

        Dim fldAux As New GridViewTextBoxColumn
        fldAux.HeaderText = "Aux. Standard No."
        fldAux.FieldName = "fldAux"
        fldAux.TextAlignment = ContentAlignment.MiddleCenter
        fldAux.Width = 300
        gvData.Columns.Add(fldAux)

        Dim fldQty As New GridViewTextBoxColumn
        fldQty.HeaderText = "Affected Qty"
        fldQty.FieldName = "fldQty"
        fldQty.TextAlignment = ContentAlignment.MiddleCenter
        fldQty.Width = 150
        gvData.Columns.Add(fldQty)

        Dim fldModelFrom As New GridViewTextBoxColumn
        fldModelFrom.HeaderText = "Model(From)"
        fldModelFrom.FieldName = "fldModelFrom"
        fldModelFrom.TextAlignment = ContentAlignment.MiddleCenter
        fldModelFrom.Width = 150
        gvData.Columns.Add(fldModelFrom)

        Dim fldModelTo As New GridViewTextBoxColumn
        fldModelTo.HeaderText = "Model(To)"
        fldModelTo.FieldName = "fldModelTo"
        fldModelTo.TextAlignment = ContentAlignment.MiddleCenter
        fldModelTo.Width = 150
        gvData.Columns.Add(fldModelTo)

        Dim fldReason As New GridViewTextBoxColumn
        fldReason.HeaderText = "Reason"
        fldReason.FieldName = "fldReason"
        fldReason.TextAlignment = ContentAlignment.MiddleCenter
        fldReason.Width = 500
        gvData.Columns.Add(fldReason)

    End Sub

    Private Sub ReloadGrid()

        gvData.DataSource = Maria.MyQuery("SELECT * FROM dbMIA.tblDailyReportRework where fldStatus=1")

    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click

        Dim result As Integer = MessageBox.Show("Are you sure you want to add?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        Else
            If AllowAdd() Then
                Maria.AddMySqlParameters("parDate", dpDate.Value)
                Maria.AddMySqlParameters("parShift", ddShift.Text)
                Maria.AddMySqlParameters("parLine", spnLine.Value)
                Maria.AddMySqlParameters("parTL", tbTL.Text)
                Maria.AddMySqlParameters("parAux", tbAux.Text)
                Maria.AddMySqlParameters("parQty", spnQty.Value)
                Maria.AddMySqlParameters("parFrom", ddModelFrom.Text)
                Maria.AddMySqlParameters("parTo", ddModelTo.Text)
                Maria.AddMySqlParameters("parReason", tbReason.Text)
                Maria.AddMySqlParameters("parAddedBy", globalVariables.currentUser(1))
                Maria.SPADE("SP_SRCDailyReport_InsertReworking")
                MessageBox.Show("Done!")
                ReloadGrid()
            Else
                MessageBox.Show("Operation Cancelled!")
            End If
        End If

    End Sub

    Private Function AllowAdd() As Boolean
        Dim Bakudan As Boolean = True

        If ddShift.Text = "" Then
            MessageBox.Show("Shift Required")
            Bakudan = False
        ElseIf spnLine.Value <= 0 Then
            MessageBox.Show("Line# Required")
            Bakudan = False
        ElseIf tbTL.Text = "" Then
            MessageBox.Show("Line Leader Required")
            Bakudan = False
        ElseIf tbAux.Text = "" Then
            MessageBox.Show("Aux. Std. No. Required")
            Bakudan = False
        ElseIf spnQty.Value <= 0 Then
            MessageBox.Show("Qty Required")
            Bakudan = False
        ElseIf ddModelFrom.Text = "" Then
            MessageBox.Show("Model Required")
            Bakudan = False
        ElseIf ddModelTo.Text = "" Then
            MessageBox.Show("Model Required")
            Bakudan = False
        ElseIf tbReason.Text = "" Then
            MessageBox.Show("Reason Required")
            Bakudan = False
        End If

        Return Bakudan
    End Function

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        ReloadGrid()
    End Sub

    Private Sub cbbDelete_Click(sender As Object, e As EventArgs) Handles cbbDelete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to add?", "Yes or No?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        Else
            Dim DeleteID As Integer = gvData.CurrentRow.Cells("fldID").Value
            Maria.MyQuery("Update dbMIA.tblDailyReportRework set fldStatus=0 where fldID=" & DeleteID & "")
        End If
        ReloadGrid()
    End Sub

    Private Sub cbbDailyReport_Click(sender As Object, e As EventArgs) Handles cbbDailyReport.Click
        globalVariables.ReworkID = gvData.CurrentRow.Cells("fldID").Value
        Dim OwO As New FrmReworkingData()
        OwO.Show()
    End Sub
End Class
