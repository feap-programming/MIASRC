<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditHourlyProdMnt
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
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.mcbTitle = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.mcbProcess = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCheckby = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.seDeviation = New Telerik.WinControls.UI.RadSpinEditor()
        Me.Actual = New Telerik.WinControls.UI.RadLabel()
        Me.seActual = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.sePlan = New Telerik.WinControls.UI.RadSpinEditor()
        Me.rtpFrom = New Telerik.WinControls.UI.RadTimePicker()
        Me.rtpTo = New Telerik.WinControls.UI.RadTimePicker()
        Me.mcbShift = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.txtMainID = New Telerik.WinControls.UI.RadTextBox()
        Me.txtPOSPID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtHID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDeviation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Actual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.txtHID)
        Me.z.Controls.Add(Me.btnUpdate)
        Me.z.Controls.Add(Me.mcbTitle)
        Me.z.Controls.Add(Me.RadLabel3)
        Me.z.Controls.Add(Me.RadLabel2)
        Me.z.Controls.Add(Me.txtRemarks)
        Me.z.Controls.Add(Me.mcbProcess)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Controls.Add(Me.RadLabel4)
        Me.z.Controls.Add(Me.txtCheckby)
        Me.z.Controls.Add(Me.RadLabel1)
        Me.z.Controls.Add(Me.seDeviation)
        Me.z.Controls.Add(Me.Actual)
        Me.z.Controls.Add(Me.seActual)
        Me.z.Controls.Add(Me.RadLabel11)
        Me.z.Controls.Add(Me.sePlan)
        Me.z.Controls.Add(Me.rtpFrom)
        Me.z.Controls.Add(Me.rtpTo)
        Me.z.Controls.Add(Me.mcbShift)
        Me.z.Controls.Add(Me.RadLabel16)
        Me.z.Controls.Add(Me.RadLabel17)
        Me.z.Controls.Add(Me.RadLabel19)
        Me.z.Controls.Add(Me.txtMainID)
        Me.z.Controls.Add(Me.txtPOSPID)
        Me.z.Dock = System.Windows.Forms.DockStyle.Fill
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(524, 299)
        Me.z.TabIndex = 17
        Me.z.ThemeName = "Office2007Black"
        '
        'mcbTitle
        '
        '
        'mcbTitle.NestedRadGridView
        '
        Me.mcbTitle.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbTitle.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbTitle.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbTitle.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbTitle.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbTitle.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbTitle.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbTitle.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbTitle.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbTitle.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbTitle.EditorControl.Name = "NestedRadGridView"
        Me.mcbTitle.EditorControl.ReadOnly = True
        Me.mcbTitle.EditorControl.ShowGroupPanel = False
        Me.mcbTitle.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbTitle.EditorControl.TabIndex = 0
        Me.mcbTitle.Enabled = False
        Me.mcbTitle.Location = New System.Drawing.Point(92, 177)
        Me.mcbTitle.Name = "mcbTitle"
        Me.mcbTitle.NullText = "-- Select Title --"
        Me.mcbTitle.Size = New System.Drawing.Size(398, 20)
        Me.mcbTitle.TabIndex = 123
        Me.mcbTitle.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(47, 178)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel3.TabIndex = 122
        Me.RadLabel3.Text = "Title:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(26, 153)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel2.TabIndex = 120
        Me.RadLabel2.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(92, 151)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(398, 20)
        Me.txtRemarks.TabIndex = 119
        '
        'mcbProcess
        '
        '
        'mcbProcess.NestedRadGridView
        '
        Me.mcbProcess.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbProcess.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbProcess.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbProcess.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbProcess.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbProcess.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbProcess.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbProcess.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbProcess.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbProcess.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.mcbProcess.EditorControl.Name = "NestedRadGridView"
        Me.mcbProcess.EditorControl.ReadOnly = True
        Me.mcbProcess.EditorControl.ShowGroupPanel = False
        Me.mcbProcess.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbProcess.EditorControl.TabIndex = 0
        Me.mcbProcess.Enabled = False
        Me.mcbProcess.Location = New System.Drawing.Point(92, 203)
        Me.mcbProcess.Name = "mcbProcess"
        Me.mcbProcess.NullText = "-- Select Main Process --"
        Me.mcbProcess.Size = New System.Drawing.Size(398, 20)
        Me.mcbProcess.TabIndex = 121
        Me.mcbProcess.TabStop = False
        '
        'RadLabel18
        '
        Me.RadLabel18.Location = New System.Drawing.Point(23, 127)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(54, 18)
        Me.RadLabel18.TabIndex = 118
        Me.RadLabel18.Text = "Check by:"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(4, 205)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel4.TabIndex = 124
        Me.RadLabel4.Text = "Main Process:"
        '
        'txtCheckby
        '
        Me.txtCheckby.Location = New System.Drawing.Point(92, 125)
        Me.txtCheckby.Name = "txtCheckby"
        Me.txtCheckby.Size = New System.Drawing.Size(398, 20)
        Me.txtCheckby.TabIndex = 117
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(276, 75)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel1.TabIndex = 116
        Me.RadLabel1.Text = "Deviation:"
        '
        'seDeviation
        '
        Me.seDeviation.EnableNullValueInput = True
        Me.seDeviation.Location = New System.Drawing.Point(356, 73)
        Me.seDeviation.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seDeviation.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seDeviation.Name = "seDeviation"
        Me.seDeviation.ShowUpDownButtons = False
        Me.seDeviation.Size = New System.Drawing.Size(134, 20)
        Me.seDeviation.TabIndex = 115
        Me.seDeviation.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seDeviation.ThousandsSeparator = True
        '
        'Actual
        '
        Me.Actual.Location = New System.Drawing.Point(292, 48)
        Me.Actual.Name = "Actual"
        Me.Actual.Size = New System.Drawing.Size(40, 18)
        Me.Actual.TabIndex = 114
        Me.Actual.Text = "Actual:"
        '
        'seActual
        '
        Me.seActual.EnableNullValueInput = True
        Me.seActual.Location = New System.Drawing.Point(356, 47)
        Me.seActual.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seActual.Name = "seActual"
        Me.seActual.ShowUpDownButtons = False
        Me.seActual.Size = New System.Drawing.Size(134, 20)
        Me.seActual.TabIndex = 113
        Me.seActual.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.seActual.ThousandsSeparator = True
        '
        'RadLabel11
        '
        Me.RadLabel11.Location = New System.Drawing.Point(302, 22)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel11.TabIndex = 112
        Me.RadLabel11.Text = "Plan:"
        '
        'sePlan
        '
        Me.sePlan.EnableNullValueInput = True
        Me.sePlan.Location = New System.Drawing.Point(356, 22)
        Me.sePlan.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.sePlan.Name = "sePlan"
        Me.sePlan.ShowUpDownButtons = False
        Me.sePlan.Size = New System.Drawing.Size(134, 20)
        Me.sePlan.TabIndex = 111
        Me.sePlan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.sePlan.ThousandsSeparator = True
        '
        'rtpFrom
        '
        Me.rtpFrom.Location = New System.Drawing.Point(86, 47)
        Me.rtpFrom.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.rtpFrom.MinValue = New Date(CType(0, Long))
        Me.rtpFrom.Name = "rtpFrom"
        Me.rtpFrom.Size = New System.Drawing.Size(159, 20)
        Me.rtpFrom.TabIndex = 105
        Me.rtpFrom.TabStop = False
        Me.rtpFrom.Value = New Date(2021, 3, 16, 6, 0, 0, 0)
        '
        'rtpTo
        '
        Me.rtpTo.Location = New System.Drawing.Point(86, 72)
        Me.rtpTo.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.rtpTo.MinValue = New Date(CType(0, Long))
        Me.rtpTo.Name = "rtpTo"
        Me.rtpTo.Size = New System.Drawing.Size(159, 20)
        Me.rtpTo.TabIndex = 110
        Me.rtpTo.TabStop = False
        Me.rtpTo.Value = New Date(2021, 3, 16, 7, 0, 0, 0)
        '
        'mcbShift
        '
        '
        'mcbShift.NestedRadGridView
        '
        Me.mcbShift.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbShift.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbShift.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbShift.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbShift.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbShift.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbShift.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbShift.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbShift.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbShift.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.mcbShift.EditorControl.Name = "NestedRadGridView"
        Me.mcbShift.EditorControl.ReadOnly = True
        Me.mcbShift.EditorControl.ShowGroupPanel = False
        Me.mcbShift.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbShift.EditorControl.TabIndex = 0
        Me.mcbShift.Location = New System.Drawing.Point(86, 22)
        Me.mcbShift.Name = "mcbShift"
        Me.mcbShift.NullText = "-- Select Shift --"
        Me.mcbShift.Size = New System.Drawing.Size(159, 20)
        Me.mcbShift.TabIndex = 106
        Me.mcbShift.TabStop = False
        '
        'RadLabel16
        '
        Me.RadLabel16.Location = New System.Drawing.Point(40, 22)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel16.TabIndex = 107
        Me.RadLabel16.Text = "Shift:"
        '
        'RadLabel17
        '
        Me.RadLabel17.Location = New System.Drawing.Point(28, 70)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(49, 18)
        Me.RadLabel17.TabIndex = 109
        Me.RadLabel17.Text = "Time To:"
        '
        'RadLabel19
        '
        Me.RadLabel19.Location = New System.Drawing.Point(18, 44)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(62, 18)
        Me.RadLabel19.TabIndex = 108
        Me.RadLabel19.Text = "Time From:"
        '
        'txtMainID
        '
        Me.txtMainID.Location = New System.Drawing.Point(913, 54)
        Me.txtMainID.Name = "txtMainID"
        Me.txtMainID.Size = New System.Drawing.Size(28, 20)
        Me.txtMainID.TabIndex = 86
        Me.txtMainID.Visible = False
        '
        'txtPOSPID
        '
        Me.txtPOSPID.Location = New System.Drawing.Point(913, 80)
        Me.txtPOSPID.Name = "txtPOSPID"
        Me.txtPOSPID.Size = New System.Drawing.Size(28, 20)
        Me.txtPOSPID.TabIndex = 85
        Me.txtPOSPID.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 246)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 125
        Me.btnUpdate.Text = "Update"
        '
        'txtHID
        '
        Me.txtHID.Location = New System.Drawing.Point(462, 246)
        Me.txtHID.Name = "txtHID"
        Me.txtHID.Size = New System.Drawing.Size(28, 20)
        Me.txtHID.TabIndex = 126
        Me.txtHID.Visible = False
        '
        'FrmEditHourlyProdMnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 299)
        Me.Controls.Add(Me.z)
        Me.Name = "FrmEditHourlyProdMnt"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Update Hourly Production Status Monitoring"
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.mcbTitle.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDeviation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Actual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMainID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOSPID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents mcbTitle As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mcbProcess As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCheckby As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seDeviation As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents Actual As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seActual As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents sePlan As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents rtpFrom As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents rtpTo As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents mcbShift As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtMainID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPOSPID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtHID As Telerik.WinControls.UI.RadTextBox
End Class

