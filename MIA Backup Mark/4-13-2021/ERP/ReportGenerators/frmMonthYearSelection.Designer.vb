<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonthYearSelection
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
        Dim RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem14 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem15 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem16 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem17 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem18 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem19 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem20 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem21 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem22 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem23 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem24 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonthYearSelection))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.drpToMonth = New Telerik.WinControls.UI.RadDropDownList()
        Me.drpFromMonth = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblToMonth = New Telerik.WinControls.UI.RadLabel()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblFromMonth = New Telerik.WinControls.UI.RadLabel()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.btnGenerate = New Telerik.WinControls.UI.RadButton()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.drpToMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpFromMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblToMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFromMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.drpToMonth)
        Me.panel.Controls.Add(Me.drpFromMonth)
        Me.panel.Controls.Add(Me.lblToMonth)
        Me.panel.Controls.Add(Me.numYear)
        Me.panel.Controls.Add(Me.lblFromMonth)
        Me.panel.Controls.Add(Me.lblYear)
        Me.panel.Controls.Add(Me.btnGenerate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(242, 130)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'drpToMonth
        '
        Me.drpToMonth.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
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
        Me.drpToMonth.Items.Add(RadListDataItem1)
        Me.drpToMonth.Items.Add(RadListDataItem2)
        Me.drpToMonth.Items.Add(RadListDataItem3)
        Me.drpToMonth.Items.Add(RadListDataItem4)
        Me.drpToMonth.Items.Add(RadListDataItem5)
        Me.drpToMonth.Items.Add(RadListDataItem6)
        Me.drpToMonth.Items.Add(RadListDataItem7)
        Me.drpToMonth.Items.Add(RadListDataItem8)
        Me.drpToMonth.Items.Add(RadListDataItem9)
        Me.drpToMonth.Items.Add(RadListDataItem10)
        Me.drpToMonth.Items.Add(RadListDataItem11)
        Me.drpToMonth.Items.Add(RadListDataItem12)
        Me.drpToMonth.Location = New System.Drawing.Point(98, 64)
        Me.drpToMonth.Name = "drpToMonth"
        Me.drpToMonth.Size = New System.Drawing.Size(120, 20)
        Me.drpToMonth.TabIndex = 3
        '
        'drpFromMonth
        '
        Me.drpFromMonth.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem13.Text = "January"
        RadListDataItem14.Text = "February"
        RadListDataItem15.Text = "March"
        RadListDataItem16.Text = "April"
        RadListDataItem17.Text = "May"
        RadListDataItem18.Text = "June"
        RadListDataItem19.Text = "July"
        RadListDataItem20.Text = "August"
        RadListDataItem21.Text = "September"
        RadListDataItem22.Text = "October"
        RadListDataItem23.Text = "November"
        RadListDataItem24.Text = "December"
        Me.drpFromMonth.Items.Add(RadListDataItem13)
        Me.drpFromMonth.Items.Add(RadListDataItem14)
        Me.drpFromMonth.Items.Add(RadListDataItem15)
        Me.drpFromMonth.Items.Add(RadListDataItem16)
        Me.drpFromMonth.Items.Add(RadListDataItem17)
        Me.drpFromMonth.Items.Add(RadListDataItem18)
        Me.drpFromMonth.Items.Add(RadListDataItem19)
        Me.drpFromMonth.Items.Add(RadListDataItem20)
        Me.drpFromMonth.Items.Add(RadListDataItem21)
        Me.drpFromMonth.Items.Add(RadListDataItem22)
        Me.drpFromMonth.Items.Add(RadListDataItem23)
        Me.drpFromMonth.Items.Add(RadListDataItem24)
        Me.drpFromMonth.Location = New System.Drawing.Point(98, 38)
        Me.drpFromMonth.Name = "drpFromMonth"
        Me.drpFromMonth.Size = New System.Drawing.Size(120, 20)
        Me.drpFromMonth.TabIndex = 2
        '
        'lblToMonth
        '
        Me.lblToMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblToMonth.Location = New System.Drawing.Point(37, 66)
        Me.lblToMonth.Name = "lblToMonth"
        Me.lblToMonth.Size = New System.Drawing.Size(55, 18)
        Me.lblToMonth.TabIndex = 0
        Me.lblToMonth.Text = "To Month"
        '
        'numYear
        '
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
        'lblFromMonth
        '
        Me.lblFromMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblFromMonth.Location = New System.Drawing.Point(23, 40)
        Me.lblFromMonth.Name = "lblFromMonth"
        Me.lblFromMonth.Size = New System.Drawing.Size(69, 18)
        Me.lblFromMonth.TabIndex = 0
        Me.lblFromMonth.Text = "From Month"
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
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(98, 90)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnGenerate.TabIndex = 4
        Me.btnGenerate.Text = "Generate"
        '
        'FrmMonthYearSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 130)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMonthYearSelection"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Month-Year Selection"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.drpToMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpFromMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblToMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFromMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblFromMonth As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnGenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblToMonth As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpToMonth As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents drpFromMonth As Telerik.WinControls.UI.RadDropDownList
End Class

