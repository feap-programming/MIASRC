Imports Telerik.WinControls.UI
Imports FEAPNS.DataAccess
Imports Telerik.WinControls
Imports System.ComponentModel

Public Class FrmLatestDemandReportSelector

    Private myDB As New Kurumi.DB(My.Settings.setServerHost, My.Settings.setDBName, My.Settings.setDBUID, My.Settings.setDBPWD)
    Private dbLotProducer As New Kurumi.DB("192.168.191.252", "dbLotProducer", "feap", "45|iF$")
    Private tblLDDateIssuedList As DataTable
    Private tblDCDateIssuedList As DataTable

    Private ReadOnly Property GetIssuedDateList(customerCode As String) As DataTable
        Get
            Dim listDateIssued = (
                    From T0 In myDB.MyQuery("SELECT * FROM tblLatestDemand").AsEnumerable
                    Where T0.Field(Of String)("fldCustomer") = customerCode
                    Group By Keys = New With
                        {
                            Key .fldDateIssued = T0.Field(Of Date)("fldDateIssued")
                        } Into Group
                    Select New With
                        {
                            Key Keys.fldDateIssued
                        }
                ).ToList()
            Return ConvertToDatatable(listDateIssued)
        End Get
    End Property

    Private Sub FrmLatestDemandReportSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtFLDDateFrom.Value = Today
        dtFLDDateTo.Value = Today

        RemoveHandler drpLDCustomer.SelectedIndexChanged, AddressOf drpLDCustomer_SelectedIndexChanged
        Me.LoadCustomerCode(Me.drpLDCustomer)
        AddHandler drpLDCustomer.SelectedIndexChanged, AddressOf drpLDCustomer_SelectedIndexChanged
        dtLDDateReceivedFrom.Value = Today
        dtLDDateReceivedTo.Value = Today

        RemoveHandler drpLDCustomer.SelectedIndexChanged, AddressOf drpDCCustomer_SelectedIndexChanged
        Me.LoadCustomerCode(Me.drpDCCustomer)
        AddHandler drpDCCustomer.SelectedIndexChanged, AddressOf drpLDCustomer_SelectedIndexChanged
        dtDCDateReceived1.Value = Today
        dtDCDateReceived2.Value = Today

        tblLDDateIssuedList = GetIssuedDateList(Me.drpLDCustomer.SelectedValue)

        AddHandler dtLDDateReceivedFrom.DateTimePickerElement.Calendar.ElementRender, AddressOf LD_Calendar_ElementRender
        AddHandler dtLDDateReceivedTo.DateTimePickerElement.Calendar.ElementRender, AddressOf LD_Calendar_ElementRender

        tblDCDateIssuedList = GetIssuedDateList(Me.drpDCCustomer.SelectedValue)

        AddHandler dtDCDateReceived1.DateTimePickerElement.Calendar.ElementRender, AddressOf DC_Calendar_ElementRender
        AddHandler dtDCDateReceived2.DateTimePickerElement.Calendar.ElementRender, AddressOf DC_Calendar_ElementRender

    End Sub

    Private Sub fldFLDDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtFLDDateFrom.ValueChanged
        dtFLDDateFrom.Value = New Date(dtFLDDateFrom.Value.Year, dtFLDDateFrom.Value.Month, 1)
    End Sub

    Private Sub fldFLDDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtFLDDateTo.ValueChanged
        dtFLDDateTo.Value = New Date(dtFLDDateTo.Value.Year, dtFLDDateTo.Value.Month, Date.DaysInMonth(dtFLDDateTo.Value.Year, dtFLDDateTo.Value.Month))
    End Sub

    Private Sub btnFLDGenerate_Click(sender As Object, e As EventArgs) Handles btnFLDGenerate.Click
        If tglDCReportSource.Value Then
            Dim report As New FrmRptForecastVsLatestDemand
            report.Show(dtFLDDateFrom.Value, dtFLDDateTo.Value)
        Else
            'Dim report As New frmRptBookDemandComparison
            'report.Show(drpDCCustomer.SelectedValue, String.Concat(GetCustomerName(drpDCCustomer.Text), " (", drpDCCustomer.Text, ")"), dtDCDateReceived1.Value, dtDCDateReceived2.Value)
        End If
    End Sub

    Private Sub drpLDCustomer_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles drpLDCustomer.SelectedIndexChanged

        Dim customerCode As String

        Try
            customerCode = Me.drpLDCustomer.SelectedValue
        Catch ex As Exception
            customerCode = String.Empty
        End Try

        tblLDDateIssuedList = GetIssuedDateList(customerCode)

        AddHandler dtLDDateReceivedFrom.DateTimePickerElement.Calendar.ElementRender, AddressOf LD_Calendar_ElementRender
        AddHandler dtLDDateReceivedTo.DateTimePickerElement.Calendar.ElementRender, AddressOf LD_Calendar_ElementRender

    End Sub

    Private Sub drpDCCustomer_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles drpDCCustomer.SelectedIndexChanged

        Dim customerCode As String

        Try
            customerCode = Me.drpDCCustomer.SelectedValue
        Catch ex As Exception
            customerCode = String.Empty
        End Try

        tblDCDateIssuedList = GetIssuedDateList(customerCode)

        AddHandler dtDCDateReceived1.DateTimePickerElement.Calendar.ElementRender, AddressOf DC_Calendar_ElementRender
        AddHandler dtDCDateReceived2.DateTimePickerElement.Calendar.ElementRender, AddressOf DC_Calendar_ElementRender

    End Sub

    Private Sub btnLDGenerate_Click(sender As Object, e As EventArgs) Handles btnLDGenerate.Click

        If Not String.IsNullOrWhiteSpace(drpLDCustomer.Text) Then
            If Not IsDBNull(drpLDCustomer.SelectedValue) Then
                If tglLDReportSource.Value Then
                    Dim report As New FrmRptLatestDemandPerCustomer
                    report.Show(drpLDCustomer.SelectedValue, String.Concat(GetCustomerName(drpLDCustomer.Text), " (", drpLDCustomer.Text, ")"), dtLDDateReceivedFrom.Value, dtLDDateReceivedTo.Value)
                Else
                    Dim report As New FrmRptBookLatestDemandPerCustomer
                    report.Show(drpLDCustomer.SelectedValue, String.Concat(GetCustomerName(drpLDCustomer.Text), " (", drpLDCustomer.Text, ")"), dtLDDateReceivedFrom.Value, dtLDDateReceivedTo.Value)
                End If
            Else
                RadMessageBox.Show("Customer info not found.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Else
            RadMessageBox.Show("Please select Customer.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub btnDCGenerate_Click(sender As Object, e As EventArgs) Handles btnDCGenerate.Click

        If Not String.IsNullOrWhiteSpace(drpDCCustomer.Text) Then
            If Not IsDBNull(drpDCCustomer.SelectedValue) Then
                If tglDCReportSource.Value Then
                    Dim report As New FrmRptDemandComparison
                    report.Show(drpDCCustomer.SelectedValue, String.Concat(GetCustomerName(drpDCCustomer.Text), " (", drpDCCustomer.Text, ")"), dtDCDateReceived1.Value, dtDCDateReceived2.Value)
                Else
                    Dim report As New frmRptBookDemandComparison
                    report.Show(drpDCCustomer.SelectedValue, String.Concat(GetCustomerName(drpDCCustomer.Text), " (", drpDCCustomer.Text, ")"), dtDCDateReceived1.Value, dtDCDateReceived2.Value)
                End If
            Else
                RadMessageBox.Show("Customer info not found.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Else
            RadMessageBox.Show("Please select Customer.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub LD_Calendar_ElementRender(ByVal sender As Object, ByVal e As RenderElementEventArgs)

        If tblLDDateIssuedList.AsEnumerable.Where(Function(x) e.Day.Date = Convert.ToDateTime(x.Field(Of String)("fldDateIssued"))).Count > 0 Then
            e.Element.BackColor = Color.FromArgb(85, 239, 196)
            e.Element.ForeColor = Color.FromArgb(22, 160, 133)
            e.Element.Enabled = True
        Else
            e.Element.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.Element.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.Element.Enabled = False
        End If

    End Sub

    Private Sub DC_Calendar_ElementRender(ByVal sender As Object, ByVal e As RenderElementEventArgs)

        If tblDCDateIssuedList.AsEnumerable.Where(Function(x) e.Day.Date = Convert.ToDateTime(x.Field(Of String)("fldDateIssued"))).Count > 0 Then
            e.Element.BackColor = Color.FromArgb(85, 239, 196)
            e.Element.ForeColor = Color.FromArgb(22, 160, 133)
            e.Element.Enabled = True
        Else
            e.Element.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.Element.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.Element.Enabled = False
        End If

    End Sub

    Private Sub LoadCustomerCode(drpCustomerCode As RadDropDownList)

        'drpCustomerCode.DataSource = Me.myDB.SPSelect("SP_SelectAllCustomers")
        'drpCustomerCode.ValueMember = "fldCustomerCode"
        'drpCustomerCode.DisplayMember = "fldCustomerName"
        'drpCustomerCode.SelectedIndex = -1
        'drpCustomerCode.Text = String.Empty

        ' -----------------------------------------------
        ' Customer names are fetch from P2S.
        ' Customers in MIA includes suppliers.
        ' Customer names must not include supplier names.
        ' -----------------------------------------------
        Dim customer = (
                From T0 In dbLotProducer.MyQuery("SELECT * FROM tblCustomer").AsEnumerable
                Group Join T1 In myDB.SPSelect("SP_SelectAllCustomers").AsEnumerable
                    On T0.Field(Of String)("fldCode") Equals T1.Field(Of String)("fldCustomerName")
                    Into gT1 = Group
                From T1 In gT1.DefaultIfEmpty
                Order By T0.Field(Of String)("fldCode")
                Select New With
                    {
                        Key .fldCustomerCode = T1?.Field(Of String)("fldCustomerCode"),
                        Key .fldCustomerName = T0.Field(Of String)("fldCode")
                    }
            ).ToList()

        drpCustomerCode.DataSource = ConvertToDatatable(customer)
        drpCustomerCode.ValueMember = "fldCustomerCode"
        drpCustomerCode.DisplayMember = "fldCustomerName"
        drpCustomerCode.SelectedIndex = -1
        drpCustomerCode.Text = String.Empty

    End Sub

    Private Function GetCustomerName(customerCode As String) As String

        dbLotProducer.AddMySqlParameters("customerCode", customerCode)
        dbLotProducer.AddMySqlParameters("customerName", String.Empty)
        Dim iCustomerName As IDictionary(Of String, Object) = Me.dbLotProducer.SPOutput("SP_GetCustomerNameByCode", "customerName")

        Return iCustomerName("customerName")

    End Function

    Public Shared Function ConvertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function

End Class
