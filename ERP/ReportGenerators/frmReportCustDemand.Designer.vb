<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportCustDemand
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportCustDemand))
        Me.ddlReportSelect = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSubmit = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.ddlYear = New Telerik.WinControls.UI.RadDropDownList()
        Me.dtpFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.ddlReportSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddlReportSelect
        '
        Me.ddlReportSelect.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Per Part Name"
        RadListDataItem2.Text = "Per Model"
        RadListDataItem3.Text = "Export Mold Parts"
        Me.ddlReportSelect.Items.Add(RadListDataItem1)
        Me.ddlReportSelect.Items.Add(RadListDataItem2)
        Me.ddlReportSelect.Items.Add(RadListDataItem3)
        Me.ddlReportSelect.Location = New System.Drawing.Point(97, 38)
        Me.ddlReportSelect.Name = "ddlReportSelect"
        Me.ddlReportSelect.Size = New System.Drawing.Size(243, 20)
        Me.ddlReportSelect.TabIndex = 0
        '
        'RadLabel15
        '
        Me.RadLabel15.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel15.Location = New System.Drawing.Point(16, 40)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel15.TabIndex = 6
        Me.RadLabel15.Text = "Select Report:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(230, 90)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(110, 24)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "SUBMIT"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(58, 159)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel1.TabIndex = 9
        Me.RadLabel1.Text = "Set Year"
        Me.RadLabel1.Visible = False
        '
        'ddlYear
        '
        Me.ddlYear.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ddlYear.Location = New System.Drawing.Point(157, 159)
        Me.ddlYear.Name = "ddlYear"
        Me.ddlYear.Size = New System.Drawing.Size(90, 20)
        Me.ddlYear.TabIndex = 10
        Me.ddlYear.Visible = False
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(97, 12)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(82, 20)
        Me.dtpFrom.TabIndex = 44
        Me.dtpFrom.TabStop = False
        Me.dtpFrom.Text = "12/4/2018"
        Me.dtpFrom.Value = New Date(2018, 12, 4, 13, 33, 4, 90)
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(30, 14)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel4.TabIndex = 45
        Me.RadLabel4.Text = "Date From:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(204, 13)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(48, 18)
        Me.RadLabel2.TabIndex = 46
        Me.RadLabel2.Text = "Date To:"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(258, 12)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(82, 20)
        Me.dtpTo.TabIndex = 47
        Me.dtpTo.TabStop = False
        Me.dtpTo.Text = "12/4/2018"
        Me.dtpTo.Value = New Date(2018, 12, 4, 13, 33, 4, 90)
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.dtpFrom)
        Me.RadPanel1.Controls.Add(Me.dtpTo)
        Me.RadPanel1.Controls.Add(Me.RadLabel15)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.btnSubmit)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.ddlReportSelect)
        Me.RadPanel1.Controls.Add(Me.ddlYear)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(365, 126)
        Me.RadPanel1.TabIndex = 48
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'FrmReportCustDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 126)
        Me.Controls.Add(Me.RadPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReportCustDemand"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Demand Report Manager"
        CType(Me.ddlReportSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ddlReportSelect As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlYear As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dtpFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
End Class

