<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGenCVBTReport
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.ddDataType = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.btnGenerateReport = New Telerik.WinControls.UI.RadButton()
        CType(Me.ddDataType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenerateReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ddDataType
        '
        Me.ddDataType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "Check Voucher"
        RadListDataItem4.Text = "Bank Transfer"
        Me.ddDataType.Items.Add(RadListDataItem3)
        Me.ddDataType.Items.Add(RadListDataItem4)
        Me.ddDataType.Location = New System.Drawing.Point(88, 32)
        Me.ddDataType.Name = "ddDataType"
        Me.ddDataType.Size = New System.Drawing.Size(207, 20)
        Me.ddDataType.TabIndex = 0
        Me.ddDataType.Text = "Check Voucher"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(23, 34)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(59, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Data Type:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(88, 74)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(207, 20)
        Me.dtpFrom.TabIndex = 1
        Me.dtpFrom.TabStop = False
        Me.dtpFrom.Text = "Thursday, April 23, 2020"
        Me.dtpFrom.Value = New Date(2020, 4, 23, 15, 25, 56, 847)
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(88, 100)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(207, 20)
        Me.dtpTo.TabIndex = 2
        Me.dtpTo.TabStop = False
        Me.dtpTo.Text = "Thursday, April 23, 2020"
        Me.dtpTo.Value = New Date(2020, 4, 23, 15, 26, 1, 89)
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(48, 76)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(34, 18)
        Me.RadLabel2.TabIndex = 4
        Me.RadLabel2.Text = "From:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(61, 102)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(21, 18)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "To:"
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Location = New System.Drawing.Point(100, 158)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(154, 24)
        Me.btnGenerateReport.TabIndex = 6
        Me.btnGenerateReport.Text = "Generate Report"
        '
        'FrmGenCVBTReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(346, 222)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.ddDataType)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(354, 252)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(354, 252)
        Me.Name = "FrmGenCVBTReport"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Report"
        CType(Me.ddDataType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenerateReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ddDataType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnGenerateReport As Telerik.WinControls.UI.RadButton
End Class

