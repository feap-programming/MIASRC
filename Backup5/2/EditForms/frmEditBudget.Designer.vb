<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditBudget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditBudget))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.seBudget = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblBudget = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.lblModel = New Telerik.WinControls.UI.RadLabel()
        Me.lblFGModel = New Telerik.WinControls.UI.RadLabel()
        Me.txtDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.txtModel = New Telerik.WinControls.UI.RadTextBox()
        Me.txtFGModel = New Telerik.WinControls.UI.RadTextBox()
        Me.lblDescription = New Telerik.WinControls.UI.RadLabel()
        Me.drpMonth = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblMonth = New Telerik.WinControls.UI.RadLabel()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFGModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFGModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.txtCustomer)
        Me.panel.Controls.Add(Me.seBudget)
        Me.panel.Controls.Add(Me.lblBudget)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.lblModel)
        Me.panel.Controls.Add(Me.lblFGModel)
        Me.panel.Controls.Add(Me.txtDescription)
        Me.panel.Controls.Add(Me.txtModel)
        Me.panel.Controls.Add(Me.txtFGModel)
        Me.panel.Controls.Add(Me.lblDescription)
        Me.panel.Controls.Add(Me.drpMonth)
        Me.panel.Controls.Add(Me.lblMonth)
        Me.panel.Controls.Add(Me.numYear)
        Me.panel.Controls.Add(Me.lblYear)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(239, 260)
        Me.panel.TabIndex = 1
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(98, 169)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(120, 20)
        Me.txtCustomer.TabIndex = 6
        '
        'seBudget
        '
        Me.seBudget.DecimalPlaces = 6
        Me.seBudget.Location = New System.Drawing.Point(98, 195)
        Me.seBudget.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudget.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seBudget.Name = "seBudget"
        Me.seBudget.ShowUpDownButtons = False
        Me.seBudget.Size = New System.Drawing.Size(120, 20)
        Me.seBudget.TabIndex = 7
        '
        'lblBudget
        '
        Me.lblBudget.Location = New System.Drawing.Point(50, 196)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(42, 18)
        Me.lblBudget.TabIndex = 0
        Me.lblBudget.Text = "Budget"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(37, 172)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(48, 66)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(44, 18)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Part No"
        '
        'lblFGModel
        '
        Me.lblFGModel.Location = New System.Drawing.Point(54, 144)
        Me.lblFGModel.Name = "lblFGModel"
        Me.lblFGModel.Size = New System.Drawing.Size(38, 18)
        Me.lblFGModel.TabIndex = 0
        Me.lblFGModel.Text = "Model"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(98, 90)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        '
        '
        '
        Me.txtDescription.RootElement.StretchVertically = True
        Me.txtDescription.Size = New System.Drawing.Size(120, 47)
        Me.txtDescription.TabIndex = 4
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(98, 64)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(120, 20)
        Me.txtModel.TabIndex = 3
        '
        'txtFGModel
        '
        Me.txtFGModel.Enabled = False
        Me.txtFGModel.Location = New System.Drawing.Point(98, 143)
        Me.txtFGModel.Name = "txtFGModel"
        Me.txtFGModel.ReadOnly = True
        Me.txtFGModel.Size = New System.Drawing.Size(120, 20)
        Me.txtFGModel.TabIndex = 5
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(33, 91)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(59, 18)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Part Name"
        '
        'drpMonth
        '
        Me.drpMonth.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
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
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblMonth.Location = New System.Drawing.Point(52, 40)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 18)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "Month"
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
        Me.numYear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numYear.Value = New Decimal(New Integer() {2019, 0, 0, 0})
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
        Me.btnUpdate.Location = New System.Drawing.Point(98, 221)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        '
        'FrmEditBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 260)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditBudget"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Budget"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFGModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFGModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents drpMonth As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblMonth As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblFGModel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDescription As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtFGModel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblDescription As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents seBudget As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblBudget As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblModel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtModel As Telerik.WinControls.UI.RadTextBox
End Class

