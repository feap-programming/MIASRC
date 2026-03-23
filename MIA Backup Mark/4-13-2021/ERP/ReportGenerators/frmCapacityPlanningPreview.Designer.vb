<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapacityPlanningPreview
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
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCapacityPlanningPreview))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblMonth = New Telerik.WinControls.UI.RadLabel()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.btnProceed = New Telerik.WinControls.UI.RadButton()
        Me.drpMonth = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnProceed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.drpMonth)
        Me.panel.Controls.Add(Me.numYear)
        Me.panel.Controls.Add(Me.lblMonth)
        Me.panel.Controls.Add(Me.lblYear)
        Me.panel.Controls.Add(Me.btnProceed)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(242, 100)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'numYear
        '
        Me.numYear.Location = New System.Drawing.Point(77, 12)
        Me.numYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numYear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.NullableValue = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.numYear.ShowUpDownButtons = False
        Me.numYear.Size = New System.Drawing.Size(120, 20)
        Me.numYear.TabIndex = 1
        Me.numYear.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblMonth.Location = New System.Drawing.Point(32, 40)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 18)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "Month"
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(43, 14)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(28, 18)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year"
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(77, 64)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(110, 24)
        Me.btnProceed.TabIndex = 3
        Me.btnProceed.Text = "Proceed"
        '
        'drpMonth
        '
        Me.drpMonth.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
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
        Me.drpMonth.Location = New System.Drawing.Point(77, 38)
        Me.drpMonth.Name = "drpMonth"
        Me.drpMonth.Size = New System.Drawing.Size(120, 20)
        Me.drpMonth.TabIndex = 2
        '
        'FrmCapacityPlanningPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 100)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCapacityPlanningPreview"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Capacity Planning Preview"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnProceed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblMonth As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnProceed As Telerik.WinControls.UI.RadButton
    Friend WithEvents drpMonth As Telerik.WinControls.UI.RadDropDownList
End Class

