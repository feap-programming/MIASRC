<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditModelGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditModelGroup))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.drpCustomerCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblCustomerCode = New Telerik.WinControls.UI.RadLabel()
        Me.drpMonth = New Telerik.WinControls.UI.RadDropDownList()
        Me.drpModelCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.drpGroupCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.numYear = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblModelCode = New Telerik.WinControls.UI.RadLabel()
        Me.numPriority = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblPriority = New Telerik.WinControls.UI.RadLabel()
        Me.numLineNo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblLineNo = New Telerik.WinControls.UI.RadLabel()
        Me.drpLineCode = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblGroupCode = New Telerik.WinControls.UI.RadLabel()
        Me.lblMonth = New Telerik.WinControls.UI.RadLabel()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.lblLineCode = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.drpCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpModelCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpGroupCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModelCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLineNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLineNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpLineCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblGroupCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLineCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.txtPartName)
        Me.panel.Controls.Add(Me.drpCustomerCode)
        Me.panel.Controls.Add(Me.lblCustomerCode)
        Me.panel.Controls.Add(Me.drpMonth)
        Me.panel.Controls.Add(Me.drpModelCode)
        Me.panel.Controls.Add(Me.drpGroupCode)
        Me.panel.Controls.Add(Me.numYear)
        Me.panel.Controls.Add(Me.lblPartName)
        Me.panel.Controls.Add(Me.lblModelCode)
        Me.panel.Controls.Add(Me.numPriority)
        Me.panel.Controls.Add(Me.lblPriority)
        Me.panel.Controls.Add(Me.numLineNo)
        Me.panel.Controls.Add(Me.lblLineNo)
        Me.panel.Controls.Add(Me.drpLineCode)
        Me.panel.Controls.Add(Me.lblGroupCode)
        Me.panel.Controls.Add(Me.lblMonth)
        Me.panel.Controls.Add(Me.lblYear)
        Me.panel.Controls.Add(Me.lblLineCode)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Controls.Add(Me.txtID)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(239, 285)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'drpCustomerCode
        '
        Me.drpCustomerCode.Enabled = False
        Me.drpCustomerCode.Location = New System.Drawing.Point(98, 168)
        Me.drpCustomerCode.Name = "drpCustomerCode"
        Me.drpCustomerCode.Size = New System.Drawing.Size(120, 20)
        Me.drpCustomerCode.TabIndex = 7
        '
        'lblCustomerCode
        '
        Me.lblCustomerCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerCode.Location = New System.Drawing.Point(37, 170)
        Me.lblCustomerCode.Name = "lblCustomerCode"
        Me.lblCustomerCode.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomerCode.TabIndex = 0
        Me.lblCustomerCode.Text = "Customer"
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
        'drpModelCode
        '
        Me.drpModelCode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.drpModelCode.Enabled = False
        Me.drpModelCode.Location = New System.Drawing.Point(98, 116)
        Me.drpModelCode.Name = "drpModelCode"
        Me.drpModelCode.Size = New System.Drawing.Size(120, 20)
        Me.drpModelCode.TabIndex = 5
        '
        'drpGroupCode
        '
        Me.drpGroupCode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.drpGroupCode.Enabled = False
        Me.drpGroupCode.Location = New System.Drawing.Point(98, 90)
        Me.drpGroupCode.Name = "drpGroupCode"
        Me.drpGroupCode.Size = New System.Drawing.Size(120, 20)
        Me.drpGroupCode.TabIndex = 4
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
        'lblModelCode
        '
        Me.lblModelCode.BackColor = System.Drawing.Color.Transparent
        Me.lblModelCode.Location = New System.Drawing.Point(54, 118)
        Me.lblModelCode.Name = "lblModelCode"
        Me.lblModelCode.Size = New System.Drawing.Size(38, 18)
        Me.lblModelCode.TabIndex = 0
        Me.lblModelCode.Text = "Model"
        '
        'numPriority
        '
        Me.numPriority.Location = New System.Drawing.Point(98, 220)
        Me.numPriority.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numPriority.Name = "numPriority"
        Me.numPriority.ShowUpDownButtons = False
        Me.numPriority.Size = New System.Drawing.Size(120, 20)
        Me.numPriority.TabIndex = 9
        Me.numPriority.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPriority
        '
        Me.lblPriority.Location = New System.Drawing.Point(50, 221)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(42, 18)
        Me.lblPriority.TabIndex = 0
        Me.lblPriority.Text = "Priority"
        '
        'numLineNo
        '
        Me.numLineNo.Location = New System.Drawing.Point(98, 194)
        Me.numLineNo.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numLineNo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numLineNo.Name = "numLineNo"
        Me.numLineNo.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numLineNo.ShowUpDownButtons = False
        Me.numLineNo.Size = New System.Drawing.Size(120, 20)
        Me.numLineNo.TabIndex = 8
        Me.numLineNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.numLineNo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblLineNo
        '
        Me.lblLineNo.Location = New System.Drawing.Point(45, 195)
        Me.lblLineNo.Name = "lblLineNo"
        Me.lblLineNo.Size = New System.Drawing.Size(47, 18)
        Me.lblLineNo.TabIndex = 0
        Me.lblLineNo.Text = "Line No."
        '
        'drpLineCode
        '
        Me.drpLineCode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.drpLineCode.Enabled = False
        Me.drpLineCode.Location = New System.Drawing.Point(98, 64)
        Me.drpLineCode.Name = "drpLineCode"
        Me.drpLineCode.Size = New System.Drawing.Size(120, 20)
        Me.drpLineCode.TabIndex = 3
        '
        'lblGroupCode
        '
        Me.lblGroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lblGroupCode.Location = New System.Drawing.Point(54, 92)
        Me.lblGroupCode.Name = "lblGroupCode"
        Me.lblGroupCode.Size = New System.Drawing.Size(38, 18)
        Me.lblGroupCode.TabIndex = 0
        Me.lblGroupCode.Text = "Group"
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
        'lblLineCode
        '
        Me.lblLineCode.BackColor = System.Drawing.Color.Transparent
        Me.lblLineCode.Location = New System.Drawing.Point(65, 66)
        Me.lblLineCode.Name = "lblLineCode"
        Me.lblLineCode.Size = New System.Drawing.Size(27, 18)
        Me.lblLineCode.TabIndex = 0
        Me.lblLineCode.Text = "Line"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 246)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(41, 250)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(51, 20)
        Me.txtID.TabIndex = 18
        Me.txtID.Visible = False
        '
        'lblPartName
        '
        Me.lblPartName.BackColor = System.Drawing.Color.Transparent
        Me.lblPartName.Location = New System.Drawing.Point(36, 144)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(56, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "PartName"
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(98, 142)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(120, 20)
        Me.txtPartName.TabIndex = 6
        '
        'FrmEditModelGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 285)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditModelGroup"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Model Group"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.drpCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpModelCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpGroupCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModelCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPriority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLineNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLineNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpLineCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblGroupCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLineCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents drpMonth As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents drpGroupCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents numYear As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numPriority As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblPriority As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numLineNo As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblLineNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpLineCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblGroupCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblMonth As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblLineCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents drpModelCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblModelCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpCustomerCode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblCustomerCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
End Class

