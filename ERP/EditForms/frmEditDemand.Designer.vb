<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditDemand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditDemand))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.seDemand = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblDemand = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.lblETDFEAP = New Telerik.WinControls.UI.RadLabel()
        Me.dtETDFEAP = New Telerik.WinControls.UI.RadDateTimePicker()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtETDFEAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.dtETDFEAP)
        Me.panel.Controls.Add(Me.txtCustomer)
        Me.panel.Controls.Add(Me.seDemand)
        Me.panel.Controls.Add(Me.lblDemand)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.txtPartName)
        Me.panel.Controls.Add(Me.lblPartName)
        Me.panel.Controls.Add(Me.lblETDFEAP)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(239, 180)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(98, 91)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(120, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'seDemand
        '
        Me.seDemand.Location = New System.Drawing.Point(98, 117)
        Me.seDemand.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seDemand.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seDemand.Name = "seDemand"
        Me.seDemand.ShowUpDownButtons = False
        Me.seDemand.Size = New System.Drawing.Size(120, 20)
        Me.seDemand.TabIndex = 4
        '
        'lblDemand
        '
        Me.lblDemand.Location = New System.Drawing.Point(43, 118)
        Me.lblDemand.Name = "lblDemand"
        Me.lblDemand.Size = New System.Drawing.Size(49, 18)
        Me.lblDemand.TabIndex = 0
        Me.lblDemand.Text = "Demand"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(37, 94)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(98, 38)
        Me.txtPartName.Multiline = True
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        '
        '
        '
        Me.txtPartName.RootElement.StretchVertically = True
        Me.txtPartName.Size = New System.Drawing.Size(120, 47)
        Me.txtPartName.TabIndex = 2
        '
        'lblPartName
        '
        Me.lblPartName.Location = New System.Drawing.Point(33, 39)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(59, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "Part Name"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 143)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        '
        'lblETDFEAP
        '
        Me.lblETDFEAP.BackColor = System.Drawing.Color.Transparent
        Me.lblETDFEAP.Location = New System.Drawing.Point(38, 14)
        Me.lblETDFEAP.Name = "lblETDFEAP"
        Me.lblETDFEAP.Size = New System.Drawing.Size(54, 18)
        Me.lblETDFEAP.TabIndex = 0
        Me.lblETDFEAP.Text = "ETD FEAP"
        '
        'dtETDFEAP
        '
        Me.dtETDFEAP.CustomFormat = "MMM dd, yyyy"
        Me.dtETDFEAP.Enabled = False
        Me.dtETDFEAP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtETDFEAP.Location = New System.Drawing.Point(98, 12)
        Me.dtETDFEAP.Name = "dtETDFEAP"
        Me.dtETDFEAP.Size = New System.Drawing.Size(120, 20)
        Me.dtETDFEAP.TabIndex = 1
        Me.dtETDFEAP.TabStop = False
        Me.dtETDFEAP.Text = "Jan 19, 2022"
        Me.dtETDFEAP.Value = New Date(2022, 1, 19, 9, 31, 45, 145)
        '
        'FrmEditDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 180)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditDemand"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Demand"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDemand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDemand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtETDFEAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents seDemand As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblDemand As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents dtETDFEAP As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblETDFEAP As Telerik.WinControls.UI.RadLabel
End Class

