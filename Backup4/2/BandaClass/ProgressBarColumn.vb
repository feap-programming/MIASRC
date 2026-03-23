Imports Telerik.WinControls.UI

Public Class ProgressBarColumn
    Inherits GridViewDataColumn

    Public Sub New(ByVal fieldName As String)
        MyBase.New(fieldName)
    End Sub

    Public Overrides Function GetCellType(ByVal row As GridViewRowInfo) As Type
        If TypeOf row Is GridViewDataRowInfo Then
            Return GetType(ProgressBarCellElement)
        End If
        Return MyBase.GetCellType(row)
    End Function

End Class
