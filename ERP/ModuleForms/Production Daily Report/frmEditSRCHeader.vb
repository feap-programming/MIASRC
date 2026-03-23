Imports Telerik.WinControls

Public Class FrmEditSRCHeader
    Dim Maria As New Kurumi.DB("192.168.191.22", "dbMIA", "feap", "45|iF$")
    Private Sub FrmEditSRCHeader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ddModel.Text = Mio.EditAssyModel
        spnLine.Value = Mio.EditAssyLine
        dpDatePicker.Value = Mio.EditAssyDate
        ddShift.Text = Mio.EditAssyShift

        If Mio.EditAssyTimeFrom = Nothing Then
            If Mio.EditAssyShift = "6AM-2PM(1st Shift)" Then
                tpFrom.Value = "6:00 AM"
            ElseIf Mio.EditAssyShift = "6AM-6PM" Then
                tpFrom.Value = "6:00 AM"
            ElseIf Mio.EditAssyShift = "2PM-10PM(2nd Shift)" Then
                tpFrom.Value = "2:00 PM"
            ElseIf Mio.EditAssyShift = "6PM-6AM" Then
                tpFrom.Value = "6:00 PM"
            ElseIf Mio.EditAssyShift = "10PM-6AM(3rd Shift)" Then
                tpFrom.Value = "10:00 PM"
            End If
        Else
            tpFrom.Value = Mio.EditAssyTimeFrom
        End If

        If Mio.EditAssyTimeTo = Nothing Then
            If Mio.EditAssyShift = "6AM-2PM(1st Shift)" Then
                tpTo.Value = "2:00 PM"
            ElseIf Mio.EditAssyShift = "6AM-6PM" Then
                tpTo.Value = "6:00 PM"
            ElseIf Mio.EditAssyShift = "2PM-10PM(2nd Shift)" Then
                tpTo.Value = "10:00 PM"
            ElseIf Mio.EditAssyShift = "6PM-6AM" Then
                tpTo.Value = "6:00 AM"
            ElseIf Mio.EditAssyShift = "10PM-6AM(3rd Shift)" Then
                tpTo.Value = "6:00 AM"
            End If
        Else
            tpTo.Value = Mio.EditAssyTimeTo
        End If

        'Try
        '    tpFrom.Value = Mio.EditAssyTimeFrom
        '    tpTo.Value = Mio.EditAssyTimeTo
        'Catch ex As Exception
        '    If Mio.EditAssyShift = "6AM-2PM(1st Shift)" Then
        '        tpFrom.Value = "6:00 AM"
        '        tpTo.Value = "2:00 PM"
        '    ElseIf Mio.EditAssyShift = "6AM-6PM" Then
        '        tpFrom.Value = "6:00 AM"
        '        tpTo.Value = "6:00 PM"
        '    ElseIf Mio.EditAssyShift = "2PM-10PM(2nd Shift)" Then
        '        tpFrom.Value = "2:00 PM"
        '        tpTo.Value = "10:00 PM"
        '    ElseIf Mio.EditAssyShift = "6PM-6AM" Then
        '        tpFrom.Value = "6:00 PM"
        '        tpTo.Value = "6:00 AM"
        '    ElseIf Mio.EditAssyShift = "10PM-6AM(3rd Shift)" Then
        '        tpFrom.Value = "10:00 PM"
        '        tpTo.Value = "6:00 AM"
        '    End If
        'End Try

        spnGroup.Value = Mio.EditAssyGroup

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try

            Dim DateFrom As DateTime = tpFrom.Value
            Dim DateFromStr As String = DateFrom.ToString("HH:mm:ss")

            Dim DateTo As DateTime = tpTo.Value
            Dim DateToStr As String = DateTo.ToString("HH:mm:ss")

            Dim DTFrom As DateTime = Convert.ToDateTime(Year(dpDatePicker.Value) & "-" & Month(dpDatePicker.Value) & "-" & dpDatePicker.Value.ToString("dd") & " " & DateFromStr)
            'Dim DTTo As DateTime = Convert.ToDateTime(Year(dpDate.Value) & "-" & Month(dpDate.Value) & "-" & dpDate.Value.ToString("dd") & " " & DateToStr)
            Dim DTTo As DateTime
            If tpFrom.Value > tpTo.Value Or ddShift.SelectedIndex = 3 Then
                DTTo = Convert.ToDateTime(Year(dpDatePicker.Value) & "-" & Month(dpDatePicker.Value) & "-" & DateAdd("d", 1, dpDatePicker.Value).ToString("dd") & " " & DateToStr)
            Else
                DTTo = Convert.ToDateTime(Year(dpDatePicker.Value) & "-" & Month(dpDatePicker.Value) & "-" & dpDatePicker.Value.ToString("dd") & " " & DateToStr)
            End If

            Maria.AddMySqlParameters("parID", Mio.EditAssyID)
            Maria.AddMySqlParameters("parLine", spnLine.Value)
            Maria.AddMySqlParameters("parDate", dpDatePicker.Value)
            Maria.AddMySqlParameters("parShift", ddShift.Text)
            Maria.AddMySqlParameters("parFrom", DTFrom)
            Maria.AddMySqlParameters("parTo", DTTo)
            Maria.AddMySqlParameters("parGroup", spnGroup.Value)
            Maria.SPADE("SP_SRC_EditAssyHeader")
            RadMessageBox.Show("Done")
            Me.Close()

        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
