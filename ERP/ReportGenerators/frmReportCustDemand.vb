Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class FrmReportCustDemand
    Private Sub FrmReportCustDemand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slipknot.changeTheme(Me)
        Dim currentDate = Now()
        Dim last6Years = Now().AddYears(-6)

        Dim currentDate2 = Now()
        Dim Next6Years = Now().AddYears(6)

        While last6Years < currentDate
            ddlYear.Items.Add(last6Years.Year)
            last6Years = last6Years.AddYears(1)
        End While

        While currentDate <= Next6Years
            ddlYear.Items.Add(currentDate.Year)
            currentDate = currentDate.AddYears(1)
        End While

        ddlYear.Text = Now().Year()
        dtpFrom.Value = Now()
        dtpTo.Value = Now()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Slipknot.IsFormOpen(frmImportCustomerDemand) Then
            FrmReport.Focus()
        Else
            If (ddlReportSelect.Text = "Per Part Name") Then
                reportType = 3
                Slipknot.addReportParameter("D1", dtpFrom.Value)
                Slipknot.addReportParameter("D2", dtpTo.Value)
                Slipknot.addReportParameter("Category", ddlReportSelect.Text)
                ' Slipknot.addReportParameter("MyYear", ddlYear.Text)
                FrmReport.Show()
            ElseIf (ddlReportSelect.Text = "Per Model") Then
                reportType = 4
                Slipknot.addReportParameter("Category", ddlReportSelect.Text)
                Slipknot.addReportParameter("D1", dtpFrom.Value)
                Slipknot.addReportParameter("D2", dtpTo.Value)
                'Slipknot.addReportParameter("MyYear", ddlYear.Text)
                FrmReport.Show()
            ElseIf (ddlReportSelect.Text = "Export Mold Parts") Then
                reportType = 5
                Slipknot.addReportParameter("Category", ddlReportSelect.Text)
                Slipknot.addReportParameter("D1", dtpFrom.Value)
                Slipknot.addReportParameter("D2", dtpTo.Value)
                Slipknot.addReportParameter("MyYear", ddlYear.Text)
                FrmReport.Show()
            End If

        End If
    End Sub
End Class
