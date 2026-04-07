<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBudgetReportSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBudgetReportSelector))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.drpCategory = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblCategory = New Telerik.WinControls.UI.RadLabel()
        Me.drpReport = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblReport = New Telerik.WinControls.UI.RadLabel()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.btnGenerate = New Telerik.WinControls.UI.RadButton()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.drpCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.drpCategory)
        Me.panel.Controls.Add(Me.lblCategory)
        Me.panel.Controls.Add(Me.drpReport)
        Me.panel.Controls.Add(Me.lblReport)
        Me.panel.Controls.Add(Me.numYear)
        Me.panel.Controls.Add(Me.lblYear)
        Me.panel.Controls.Add(Me.btnGenerate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(252, 130)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'drpCategory
        '
        Me.drpCategory.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Per Customer"
        RadListDataItem2.Text = "Per Model"
        Me.drpCategory.Items.Add(RadListDataItem1)
        Me.drpCategory.Items.Add(RadListDataItem2)
        Me.drpCategory.Location = New System.Drawing.Point(83, 38)
        Me.drpCategory.Name = "drpCategory"
        Me.drpCategory.Size = New System.Drawing.Size(150, 20)
        Me.drpCategory.TabIndex = 2
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Location = New System.Drawing.Point(26, 40)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(51, 18)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category"
        '
        'drpReport
        '
        Me.drpReport.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "Per Customer"
        RadListDataItem4.Text = "Per Model"
        Me.drpReport.Items.Add(RadListDataItem3)
        Me.drpReport.Items.Add(RadListDataItem4)
        Me.drpReport.Location = New System.Drawing.Point(83, 64)
        Me.drpReport.Name = "drpReport"
        Me.drpReport.Size = New System.Drawing.Size(150, 20)
        Me.drpReport.TabIndex = 2
        Me.drpReport.Text = "-- Select --"
        '
        'lblReport
        '
        Me.lblReport.BackColor = System.Drawing.Color.Transparent
        Me.lblReport.Location = New System.Drawing.Point(37, 66)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(40, 18)
        Me.lblReport.TabIndex = 0
        Me.lblReport.Text = "Report"
        '
        'numYear
        '
        Me.numYear.Location = New System.Drawing.Point(83, 12)
        Me.numYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numYear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.NullableValue = New Decimal(New Integer() {2019, 0, 0, 0})
        Me.numYear.ShowUpDownButtons = False
        Me.numYear.Size = New System.Drawing.Size(150, 20)
        Me.numYear.TabIndex = 1
        Me.numYear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numYear.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(49, 14)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(28, 18)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(83, 90)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(110, 24)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate"
        '
        'FrmBudgetReportSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 130)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBudgetReportSelector"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Budget Report"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.drpCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents drpReport As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblReport As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnGenerate As Telerik.WinControls.UI.RadButton
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents drpCategory As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblCategory As Telerik.WinControls.UI.RadLabel
End Class

