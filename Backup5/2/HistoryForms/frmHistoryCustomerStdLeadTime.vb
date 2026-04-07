Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess

Public Class FrmHistoryCustomerStdLeadTime

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dtCustomerStdLeadTimeHistory As DataTable
    Private customerCode As String = String.Empty

    Private Sub FrmHistoryCustomerStdLeadTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Slipknot.changeTheme(Me)
        Me.SetUpColumns(Me.gvData)

        myDB.AddMySqlParameters("parCustomerCode", customerCode)
        dtCustomerStdLeadTimeHistory = Me.myDB.SPSelect("SP_P_GetCustomerStdLeadTimeHistoryPerItem")

        gvData.DataSource = dtCustomerStdLeadTimeHistory
        gvData.BestFitColumns()
        leCountRec.Text = gvData.Rows.Count

    End Sub

    Public Overloads Sub ShowDialog(_customerCode As String)
        Me.customerCode = _customerCode
        Me.ShowDialog()
    End Sub

    Private Sub SetUpColumns(gridView As RadGridView)

        Dim fldID As New GridViewDecimalColumn("ID") With {
            .FieldName = "fldID",
            .MinWidth = 100,
            .TextAlignment = ContentAlignment.MiddleRight,
            .IsVisible = False
        }
        gridView.Columns.Add(fldID)

        Dim fldCustomerCode As New GridViewTextBoxColumn("CUSTOMER CODE") With {
            .FieldName = "fldCustomerCode",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .IsVisible = False
        }
        gridView.Columns.Add(fldCustomerCode)

        Dim fldCustomerName As New GridViewTextBoxColumn("CUSTOMER") With {
            .FieldName = "fldCustomerName",
            .MinWidth = 120,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldCustomerName)

        Dim fldETDManilaSeaNOD As New GridViewTextBoxColumn("ETD MNL (SEA)") With {
            .FieldName = "fldETDManilaSeaNOD",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETDManilaSeaNOD)

        Dim fldETDManilaAirNOD As New GridViewTextBoxColumn("ETD MNL (AIR)") With {
            .FieldName = "fldETDManilaAirNOD",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETDManilaAirNOD)

        Dim fldETACustomerSeaNOD As New GridViewTextBoxColumn("ETA CUST (SEA)") With {
            .FieldName = "fldETACustomerSeaNOD",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETACustomerSeaNOD)

        Dim fldETACustomerAirNOD As New GridViewTextBoxColumn("ETA CUST (AIR)") With {
            .FieldName = "fldETACustomerAirNOD",
            .MinWidth = 150,
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldETACustomerAirNOD)

        Dim fldEffectivityDate As New GridViewDateTimeColumn("EFFECTIVITY DATE") With {
            .FieldName = "fldEffectivityDate",
            .MinWidth = 150,
            .Format = DateTimePickerFormat.Custom,
            .CustomFormat = "MMM dd, yyyy",
            .TextAlignment = ContentAlignment.MiddleCenter
        }
        gridView.Columns.Add(fldEffectivityDate)
        gridView.Columns("fldEffectivityDate").FormatString = "{0:MMM dd, yyyy}"

    End Sub

End Class
