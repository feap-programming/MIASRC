Module FormManager
    Private openForms As New Dictionary(Of String, Form)

    Public Sub ShowForm(Of T As {Form, New})(key As String, Optional init As Action(Of T) = Nothing)
        If openForms.ContainsKey(key) Then
            If Not openForms(key).IsDisposed Then
                If openForms(key).WindowState = FormWindowState.Minimized Then
                    openForms(key).WindowState = FormWindowState.Normal
                End If

                openForms(key).BringToFront()
                openForms(key).Activate()
                Return
            Else
                openForms.Remove(key)
            End If
        End If

        Dim frm As New T()

        If init IsNot Nothing Then init(frm)

        AddHandler frm.FormClosed, Sub()
                                       If openForms.ContainsKey(key) Then
                                           openForms.Remove(key)
                                       End If
                                   End Sub

        openForms.Add(key, frm)
        frm.Show()
    End Sub
    Public Function GetFormTitle(type As String) As String
        Select Case type.ToUpper()
            Case "PW" : Return "Pigtail Welding"
            Case "FW" : Return "FFC Welding"
            Case "TM" : Return "Auto Taping"
            Case "ASSY" : Return "SRC Assembly"
            Case Else : Return type
        End Select
    End Function
End Module
