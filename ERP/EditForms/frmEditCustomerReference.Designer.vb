<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditCustomerReference
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditCustomerReference))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.txtContactPosition = New Telerik.WinControls.UI.RadTextBox()
        Me.lblContactPosition = New Telerik.WinControls.UI.RadLabel()
        Me.txtTIN = New Telerik.WinControls.UI.RadTextBox()
        Me.txtContactPerson = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCountryOrigin = New Telerik.WinControls.UI.RadTextBox()
        Me.lblTIN = New Telerik.WinControls.UI.RadLabel()
        Me.lblContactPerson = New Telerik.WinControls.UI.RadLabel()
        Me.lblCountryOrigin = New Telerik.WinControls.UI.RadLabel()
        Me.txtBusinessStyle = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtFaxNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTelNo = New Telerik.WinControls.UI.RadTextBox()
        Me.lblFaxNo = New Telerik.WinControls.UI.RadLabel()
        Me.lblTelNo = New Telerik.WinControls.UI.RadLabel()
        Me.txtAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.lblAddress = New Telerik.WinControls.UI.RadLabel()
        Me.txtName = New Telerik.WinControls.UI.RadTextBox()
        Me.lblName = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.drpClassification = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblClassification = New Telerik.WinControls.UI.RadLabel()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.txtContactPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblContactPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContactPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountryOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblContactPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCountryOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBusinessStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFaxNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFaxNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTelNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpClassification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblClassification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.drpClassification)
        Me.panel.Controls.Add(Me.lblClassification)
        Me.panel.Controls.Add(Me.txtContactPosition)
        Me.panel.Controls.Add(Me.lblContactPosition)
        Me.panel.Controls.Add(Me.txtTIN)
        Me.panel.Controls.Add(Me.txtContactPerson)
        Me.panel.Controls.Add(Me.txtCountryOrigin)
        Me.panel.Controls.Add(Me.lblTIN)
        Me.panel.Controls.Add(Me.lblContactPerson)
        Me.panel.Controls.Add(Me.lblCountryOrigin)
        Me.panel.Controls.Add(Me.txtBusinessStyle)
        Me.panel.Controls.Add(Me.RadLabel1)
        Me.panel.Controls.Add(Me.txtFaxNo)
        Me.panel.Controls.Add(Me.txtTelNo)
        Me.panel.Controls.Add(Me.lblFaxNo)
        Me.panel.Controls.Add(Me.lblTelNo)
        Me.panel.Controls.Add(Me.txtAddress)
        Me.panel.Controls.Add(Me.lblAddress)
        Me.panel.Controls.Add(Me.txtName)
        Me.panel.Controls.Add(Me.lblName)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(447, 190)
        Me.panel.TabIndex = 2
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtContactPosition
        '
        Me.txtContactPosition.Location = New System.Drawing.Point(300, 90)
        Me.txtContactPosition.Name = "txtContactPosition"
        Me.txtContactPosition.Size = New System.Drawing.Size(120, 20)
        Me.txtContactPosition.TabIndex = 9
        '
        'lblContactPosition
        '
        Me.lblContactPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactPosition.Location = New System.Drawing.Point(235, 92)
        Me.lblContactPosition.Name = "lblContactPosition"
        Me.lblContactPosition.Size = New System.Drawing.Size(59, 18)
        Me.lblContactPosition.TabIndex = 0
        Me.lblContactPosition.Text = "C. Position"
        '
        'txtTIN
        '
        Me.txtTIN.Location = New System.Drawing.Point(300, 38)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Size = New System.Drawing.Size(120, 20)
        Me.txtTIN.TabIndex = 7
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(300, 64)
        Me.txtContactPerson.Name = "txtContactPerson"
        '
        '
        '
        Me.txtContactPerson.RootElement.StretchVertically = True
        Me.txtContactPerson.Size = New System.Drawing.Size(120, 20)
        Me.txtContactPerson.TabIndex = 8
        '
        'txtCountryOrigin
        '
        Me.txtCountryOrigin.Location = New System.Drawing.Point(300, 12)
        Me.txtCountryOrigin.Name = "txtCountryOrigin"
        Me.txtCountryOrigin.Size = New System.Drawing.Size(120, 20)
        Me.txtCountryOrigin.TabIndex = 6
        '
        'lblTIN
        '
        Me.lblTIN.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblTIN.Location = New System.Drawing.Point(270, 40)
        Me.lblTIN.Name = "lblTIN"
        Me.lblTIN.Size = New System.Drawing.Size(24, 18)
        Me.lblTIN.TabIndex = 0
        Me.lblTIN.Text = "TIN"
        '
        'lblContactPerson
        '
        Me.lblContactPerson.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblContactPerson.Location = New System.Drawing.Point(241, 66)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(53, 18)
        Me.lblContactPerson.TabIndex = 0
        Me.lblContactPerson.Text = "C. Person"
        '
        'lblCountryOrigin
        '
        Me.lblCountryOrigin.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountryOrigin.Location = New System.Drawing.Point(228, 17)
        Me.lblCountryOrigin.Name = "lblCountryOrigin"
        Me.lblCountryOrigin.Size = New System.Drawing.Size(66, 15)
        Me.lblCountryOrigin.TabIndex = 0
        Me.lblCountryOrigin.Text = "Country Origin"
        '
        'txtBusinessStyle
        '
        Me.txtBusinessStyle.Location = New System.Drawing.Point(100, 142)
        Me.txtBusinessStyle.Name = "txtBusinessStyle"
        Me.txtBusinessStyle.Size = New System.Drawing.Size(120, 20)
        Me.txtBusinessStyle.TabIndex = 5
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(32, 147)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(62, 15)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Business Style"
        '
        'txtFaxNo
        '
        Me.txtFaxNo.Location = New System.Drawing.Point(100, 116)
        Me.txtFaxNo.Name = "txtFaxNo"
        Me.txtFaxNo.Size = New System.Drawing.Size(120, 20)
        Me.txtFaxNo.TabIndex = 4
        '
        'txtTelNo
        '
        Me.txtTelNo.Location = New System.Drawing.Point(100, 90)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(120, 20)
        Me.txtTelNo.TabIndex = 3
        '
        'lblFaxNo
        '
        Me.lblFaxNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaxNo.Location = New System.Drawing.Point(53, 118)
        Me.lblFaxNo.Name = "lblFaxNo"
        Me.lblFaxNo.Size = New System.Drawing.Size(41, 18)
        Me.lblFaxNo.TabIndex = 0
        Me.lblFaxNo.Text = "Fax No"
        '
        'lblTelNo
        '
        Me.lblTelNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelNo.Location = New System.Drawing.Point(55, 92)
        Me.lblTelNo.Name = "lblTelNo"
        Me.lblTelNo.Size = New System.Drawing.Size(39, 18)
        Me.lblTelNo.TabIndex = 0
        Me.lblTelNo.Text = "Tel No"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(100, 38)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        '
        '
        '
        Me.txtAddress.RootElement.StretchVertically = True
        Me.txtAddress.Size = New System.Drawing.Size(120, 46)
        Me.txtAddress.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(48, 40)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(46, 18)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(100, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(120, 20)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(58, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(36, 18)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(300, 142)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 24)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        '
        'drpClassification
        '
        Me.drpClassification.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "LOCAL"
        RadListDataItem2.Text = "EXPORT"
        Me.drpClassification.Items.Add(RadListDataItem1)
        Me.drpClassification.Items.Add(RadListDataItem2)
        Me.drpClassification.Location = New System.Drawing.Point(300, 116)
        Me.drpClassification.Name = "drpClassification"
        Me.drpClassification.Size = New System.Drawing.Size(120, 20)
        Me.drpClassification.TabIndex = 10
        '
        'lblClassification
        '
        Me.lblClassification.BackColor = System.Drawing.Color.Transparent
        Me.lblClassification.Location = New System.Drawing.Point(223, 118)
        Me.lblClassification.Name = "lblClassification"
        Me.lblClassification.Size = New System.Drawing.Size(71, 18)
        Me.lblClassification.TabIndex = 0
        Me.lblClassification.Text = "Classification"
        '
        'FrmEditCustomerReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 190)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditCustomerReference"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Customer Reference"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.txtContactPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblContactPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContactPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountryOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblContactPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCountryOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBusinessStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFaxNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFaxNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTelNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpClassification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblClassification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblAddress As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBusinessStyle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtFaxNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtTelNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblFaxNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblTelNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTIN As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtContactPerson As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCountryOrigin As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblTIN As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblContactPerson As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCountryOrigin As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtContactPosition As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblContactPosition As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpClassification As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblClassification As Telerik.WinControls.UI.RadLabel
End Class

