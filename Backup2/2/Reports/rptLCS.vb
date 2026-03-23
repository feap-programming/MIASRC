Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rptLCS
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Dim drFormat As DataRow = Slipknot.rowSelectManual("SELECT * FROM tblLotControlTemplates WHERE fldLotControlTemplate = '" & publicText & "'")

        If drFormat IsNot Nothing Then

            'SET QRCODE IMAGE LOCATION
            Dim qrX As Integer = Convert.ToInt32(drFormat.Item("fldQRX"))
            Dim qrY As Integer = Convert.ToInt32(drFormat.Item("fldQRY"))

            picQr.Location = New PointU(Unit.Point(qrY), Unit.Point(qrX))

            'SET FSIB QRCODE IMAGE LOCATION
            Dim fsibQrX As Integer = Convert.ToInt32(drFormat.Item("fldFSIBQrX"))
            Dim fsibQrY As Integer = Convert.ToInt32(drFormat.Item("fldFSIBQrY"))

            picQrFSIB.Location = New PointU(Unit.Point(fsibQrY), Unit.Point(fsibQrX))

            'SET TEXT FORMAT FOR TXTPARTNAME
            txtPartname.Style.Font.Name = drFormat.Item("fldPartnameFontName").ToString
            txtPartname.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(Convert.ToDouble(drFormat.Item("fldPartnameFontSize")))

            If drFormat.Item("fldPartnameFontStyle").ToString = "Regular" Then
                txtPartname.Style.Font.Style = FontStyle.Regular
            ElseIf drFormat.Item("fldPartnameFontStyle").ToString = "Bold" Then
                txtPartname.Style.Font.Style = FontStyle.Bold
            ElseIf drFormat.Item("fldPartnameFontStyle").ToString = "Italic" Then
                txtPartname.Style.Font.Style = FontStyle.Italic
            Else
                txtPartname.Style.Font.Style = FontStyle.Bold
                txtPartname.Style.Font.Style = FontStyle.Italic
            End If

            'SET TEXT FORMAT FOR TXTPARTNO
            txtPartNo.Style.Font.Name = drFormat.Item("fldPartNoFontName").ToString
            txtPartNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(Convert.ToDouble(drFormat.Item("fldPartNoFontSize")))

            If drFormat.Item("fldPartNoFontStyle").ToString = "Regular" Then
                txtPartNo.Style.Font.Style = FontStyle.Regular
            ElseIf drFormat.Item("fldPartNoFontStyle").ToString = "Bold" Then
                txtPartNo.Style.Font.Style = FontStyle.Bold
            ElseIf drFormat.Item("fldPartNoFontStyle").ToString = "Italic" Then
                txtPartNo.Style.Font.Style = FontStyle.Italic
            Else
                txtPartNo.Style.Font.Style = FontStyle.Bold
                txtPartNo.Style.Font.Style = FontStyle.Italic
            End If

            'SET TEXT FORMAT FOR TXTNOTE
            txtNote.Style.Font.Name = drFormat.Item("fldNoteFontName").ToString
            txtNote.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(Convert.ToDouble(drFormat.Item("fldNoteFontSize")))

            If drFormat.Item("fldNoteFontStyle").ToString = "Regular" Then
                txtNote.Style.Font.Style = FontStyle.Regular
            ElseIf drFormat.Item("fldNoteFontStyle").ToString = "Bold" Then
                txtNote.Style.Font.Style = FontStyle.Bold
            ElseIf drFormat.Item("fldNoteFontStyle").ToString = "Italic" Then
                txtNote.Style.Font.Style = FontStyle.Italic
            Else
                txtNote.Style.Font.Style = FontStyle.Bold
                txtNote.Style.Font.Style = FontStyle.Italic
            End If

            'SET TEXT FORMAT FOR TXTLOTNO
            txtLotNo.Style.Font.Name = drFormat.Item("fldLotNoFontName").ToString
            txtLotNo.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(Convert.ToDouble(drFormat.Item("fldLotNoFontSize")))

            If drFormat.Item("fldLotNoFontStyle").ToString = "Regular" Then
                txtLotNo.Style.Font.Style = FontStyle.Regular
            ElseIf drFormat.Item("fldLotNoFontStyle").ToString = "Bold" Then
                txtLotNo.Style.Font.Style = FontStyle.Bold
            ElseIf drFormat.Item("fldLotNoFontStyle").ToString = "Italic" Then
                txtLotNo.Style.Font.Style = FontStyle.Italic
            Else
                txtLotNo.Style.Font.Style = FontStyle.Bold
                txtLotNo.Style.Font.Style = FontStyle.Italic
            End If

            'SET TEXT FORMAT FOR TXTQTY
            txtQty.Style.Font.Name = drFormat.Item("fldQtyFontName").ToString
            txtQty.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(Convert.ToDouble(drFormat.Item("fldQtyFontSize")))

            If drFormat.Item("fldQtyFontStyle").ToString = "Regular" Then
                txtQty.Style.Font.Style = FontStyle.Regular
            ElseIf drFormat.Item("fldQtyFontStyle").ToString = "Bold" Then
                txtQty.Style.Font.Style = FontStyle.Bold
            ElseIf drFormat.Item("fldQtyFontStyle").ToString = "Italic" Then
                txtQty.Style.Font.Style = FontStyle.Italic
            Else
                txtQty.Style.Font.Style = FontStyle.Bold
                txtQty.Style.Font.Style = FontStyle.Italic
            End If

        End If

        Me.DataSource = dtReportData

    End Sub
End Class





