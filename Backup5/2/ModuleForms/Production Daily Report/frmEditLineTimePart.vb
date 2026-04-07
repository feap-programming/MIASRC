Public Class FrmEditLineTimePart
    Private Sub FrmEditLineTimePart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        If spnFromM.Value < 10 And spnToM.Value < 10 Then
            globalVariables.DailyRepEditTimePart = spnFrom.Value & ":0" & spnFromM.Value & "-" & spnTo.Value & ":0" & spnToM.Value
        ElseIf spnFromM.Value < 10 And spnToM.Value >= 10 Then
            globalVariables.DailyRepEditTimePart = spnFrom.Value & ":0" & spnFromM.Value & "-" & spnTo.Value & ":" & spnToM.Value
        ElseIf spnFromM.Value >= 10 And spnToM.Value >= 10 Then
            globalVariables.DailyRepEditTimePart = spnFrom.Value & ":" & spnFromM.Value & "-" & spnTo.Value & ":" & spnToM.Value
        ElseIf spnFromM.Value >= 10 And spnToM.Value < 10 Then
            globalVariables.DailyRepEditTimePart = spnFrom.Value & ":" & spnFromM.Value & "-" & spnTo.Value & ":0" & spnToM.Value
        End If


        globalVariables.DailyRepNewOPTime = tbOpTime.Text
        Me.Close()
    End Sub

    Private Sub spnFrom_ValueChanged(sender As Object, e As EventArgs) Handles spnFrom.ValueChanged

        Compute()

    End Sub

    Private Sub spnTo_ValueChanged(sender As Object, e As EventArgs) Handles spnTo.ValueChanged

        Compute()

    End Sub

    Private Sub Compute()
        Dim startint As Integer = 1
        Dim endint As Integer = 1
        Dim duration As TimeSpan
        '----------------------------(year, month, date, hrs, min, sec)


        If spnFrom.Value > spnTo.Value Then
            endint = endint + 1
            Dim startTime As New DateTime(2013, 9, startint, spnFrom.Value, spnFromM.Value, 0)
            Dim endTime As New DateTime(2013, 9, endint, spnTo.Value, spnToM.Value, 0)

            duration = endTime - startTime



            tbOpTime.Text = duration.TotalSeconds / 60
            'Dim extend As Integer = 24 + spnTo.Value

            'tbOpTime.Text = (extend - spnFrom.Value) * 60

        Else
            Dim startTime As New DateTime(2013, 9, startint, spnFrom.Value, spnFromM.Value, 0)
            Dim endTime As New DateTime(2013, 9, endint, spnTo.Value, spnToM.Value, 0)
            duration = endTime - startTime
            tbOpTime.Text = duration.TotalSeconds / 60
            'tbOpTime.Text = (spnTo.Value - spnFrom.Value) * 60
        End If



    End Sub

    Private Sub spnFromM_ValueChanged(sender As Object, e As EventArgs) Handles spnFromM.ValueChanged
        Compute()
    End Sub

    Private Sub spnToM_ValueChanged(sender As Object, e As EventArgs) Handles spnToM.ValueChanged
        Compute()
    End Sub
End Class
