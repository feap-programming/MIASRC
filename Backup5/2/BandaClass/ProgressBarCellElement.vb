Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class ProgressBarCellElement
    Inherits GridDataCellElement

    Private radProgressBarElement As RadProgressBarElement

    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        radProgressBarElement = New RadProgressBarElement()
        Me.Children.Add(radProgressBarElement)
    End Sub

    Protected Overrides Sub SetContentCore(ByVal value As Object)
        If Me.Value IsNot Nothing AndAlso Me.Value IsNot DBNull.Value Then
            Me.radProgressBarElement.Value1 = Convert.ToInt16(Me.Value)
            If Convert.ToInt16(Me.Value) = 0 Then
                Me.radProgressBarElement.ForeColor = Color.FromArgb(255, 255, 255)
                Me.radProgressBarElement.IndicatorElement1.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.IndicatorElement2.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.BackColor = Color.FromArgb(242, 38, 19)
                Me.radProgressBarElement.BackColor2 = Color.FromArgb(242, 38, 19)
                Me.radProgressBarElement.Text = "FAILED"
            ElseIf Convert.ToInt16(Me.Value) = 1 Then
                Me.radProgressBarElement.ForeColor = Color.FromArgb(0, 0, 0)
                Me.radProgressBarElement.IndicatorElement1.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.IndicatorElement2.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.BackColor = Color.FromArgb(244, 208, 63)
                Me.radProgressBarElement.BackColor2 = Color.FromArgb(244, 208, 63)
                Me.radProgressBarElement.Text = "GOOD"
            ElseIf Convert.ToInt16(Me.Value) = 2 Then
                Me.radProgressBarElement.ForeColor = Color.FromArgb(0, 0, 0)
                Me.radProgressBarElement.IndicatorElement1.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.IndicatorElement2.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.BackColor = Color.FromArgb(255, 190, 118)
                Me.radProgressBarElement.BackColor2 = Color.FromArgb(255, 190, 118)
                Me.radProgressBarElement.Text = "WARNING"
            ElseIf (Convert.ToInt16(Me.Value) > 2) AndAlso (Convert.ToInt16(Me.Value) < 100) Then
                Me.radProgressBarElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.IndicatorElement1.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.IndicatorElement2.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
                Me.radProgressBarElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.Text = "SAVING..."
            ElseIf Convert.ToInt16(Me.Value) = 100 Then
                Me.radProgressBarElement.ForeColor = Color.FromArgb(0, 0, 0)
                Me.radProgressBarElement.IndicatorElement1.BackColor = Color.FromArgb(46, 213, 115)
                Me.radProgressBarElement.IndicatorElement2.BackColor = Color.FromArgb(46, 213, 115)
                Me.radProgressBarElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Me.radProgressBarElement.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local)
                Me.radProgressBarElement.Text = "SAVED"
            End If
        End If
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridDataCellElement)
        End Get
    End Property

    Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf data Is ProgressBarColumn AndAlso TypeOf context Is GridDataRowElement
    End Function

End Class
