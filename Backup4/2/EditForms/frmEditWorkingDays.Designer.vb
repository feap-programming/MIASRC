<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditWorkingDays
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditWorkingDays))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.drpMonth = New Telerik.WinControls.UI.RadDropDownList()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numWorkingDays = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblWorkingDays = New Telerik.WinControls.UI.RadLabel()
        Me.lblMonth = New Telerik.WinControls.UI.RadLabel()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.drpMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWorkingDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblWorkingDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.drpMonth)
        Me.panel.Controls.Add(Me.numYear)
        Me.panel.Controls.Add(Me.numWorkingDays)
        Me.panel.Controls.Add(Me.lblWorkingDays)
        Me.panel.Controls.Add(Me.lblMonth)
        Me.panel.Controls.Add(Me.lblYear)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Controls.Add(Me.txtID)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(239, 131)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'drpMonth
        '
        Me.drpMonth.Enabled = False
        RadListDataItem1.Text = "January"
        RadListDataItem2.Text = "February"
        RadListDataItem3.Text = "March"
        RadListDataItem4.Text = "April"
        RadListDataItem5.Text = "May"
        RadListDataItem6.Text = "June"
        RadListDataItem7.Text = "July"
        RadListDataItem8.Text = "August"
        RadListDataItem9.Text = "September"
        RadListDataItem10.Text = "October"
        RadListDataItem11.Text = "November"
        RadListDataItem12.Text = "December"
        Me.drpMonth.Items.Add(RadListDataItem1)
        Me.drpMonth.Items.Add(RadListDataItem2)
        Me.drpMonth.Items.Add(RadListDataItem3)
        Me.drpMonth.Items.Add(RadListDataItem4)
        Me.drpMonth.Items.Add(RadListDataItem5)
        Me.drpMonth.Items.Add(RadListDataItem6)
        Me.drpMonth.Items.Add(RadListDataItem7)
        Me.drpMonth.Items.Add(RadListDataItem8)
        Me.drpMonth.Items.Add(RadListDataItem9)
        Me.drpMonth.Items.Add(RadListDataItem10)
        Me.drpMonth.Items.Add(RadListDataItem11)
        Me.drpMonth.Items.Add(RadListDataItem12)
        Me.drpMonth.Location = New System.Drawing.Point(98, 38)
        Me.drpMonth.Name = "drpMonth"
        Me.drpMonth.Size = New System.Drawing.Size(120, 20)
        Me.drpMonth.TabIndex = 2
        CType(Me.drpMonth.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'numYear
        '
        Me.numYear.Enabled = False
        Me.numYear.Location = New System.Drawing.Point(98, 12)
        Me.numYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numYear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.NullableValue = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.numYear.ShowUpDownButtons = False
        Me.numYear.Size = New System.Drawing.Size(120, 20)
        Me.numYear.TabIndex = 1
        Me.numYear.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'numWorkingDays
        '
        Me.numWorkingDays.Location = New System.Drawing.Point(98, 64)
        Me.numWorkingDays.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numWorkingDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numWorkingDays.Name = "numWorkingDays"
        Me.numWorkingDays.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numWorkingDays.ShowUpDownButtons = False
        Me.numWorkingDays.Size = New System.Drawing.Size(120, 20)
        Me.numWorkingDays.TabIndex = 3
        Me.numWorkingDays.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numWorkingDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblWorkingDays
        '
        Me.lblWorkingDays.Location = New System.Drawing.Point(16, 65)
        Me.lblWorkingDays.Name = "lblWorkingDays"
        Me.lblWorkingDays.Size = New System.Drawing.Size(76, 18)
        Me.lblWorkingDays.TabIndex = 0
        Me.lblWorkingDays.Text = "Working Days"
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblMonth.Location = New System.Drawing.Point(53, 40)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 18)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "Month"
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(64, 14)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(28, 18)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 90)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(41, 94)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(51, 20)
        Me.txtID.TabIndex = 18
        Me.txtID.Visible = False
        '
        'FrmEditWorkingDays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 131)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditWorkingDays"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Working Days"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.drpMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWorkingDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblWorkingDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents drpMonth As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numWorkingDays As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblWorkingDays As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblMonth As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
End Class

