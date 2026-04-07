<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditBacklog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditBacklog))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.dtEffectivityDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.seBacklog = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblBacklog = New Telerik.WinControls.UI.RadLabel()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.txtPartName = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPartName = New Telerik.WinControls.UI.RadLabel()
        Me.lblEffectivityDate = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.lblRemarks = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.dtEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBacklog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblBacklog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.dtEffectivityDate)
        Me.panel.Controls.Add(Me.txtCustomer)
        Me.panel.Controls.Add(Me.seBacklog)
        Me.panel.Controls.Add(Me.lblBacklog)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.txtRemarks)
        Me.panel.Controls.Add(Me.lblRemarks)
        Me.panel.Controls.Add(Me.txtPartName)
        Me.panel.Controls.Add(Me.lblPartName)
        Me.panel.Controls.Add(Me.lblEffectivityDate)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(239, 235)
        Me.panel.TabIndex = 1
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'dtEffectivityDate
        '
        Me.dtEffectivityDate.CustomFormat = "MMM dd, yyyy"
        Me.dtEffectivityDate.Enabled = False
        Me.dtEffectivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEffectivityDate.Location = New System.Drawing.Point(98, 12)
        Me.dtEffectivityDate.Name = "dtEffectivityDate"
        Me.dtEffectivityDate.Size = New System.Drawing.Size(120, 20)
        Me.dtEffectivityDate.TabIndex = 1
        Me.dtEffectivityDate.TabStop = False
        Me.dtEffectivityDate.Text = "Jan 19, 2022"
        Me.dtEffectivityDate.Value = New Date(2022, 1, 19, 9, 31, 45, 145)
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(98, 38)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(120, 20)
        Me.txtCustomer.TabIndex = 2
        '
        'seBacklog
        '
        Me.seBacklog.Location = New System.Drawing.Point(98, 170)
        Me.seBacklog.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBacklog.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seBacklog.Name = "seBacklog"
        Me.seBacklog.ShowUpDownButtons = False
        Me.seBacklog.Size = New System.Drawing.Size(120, 20)
        Me.seBacklog.TabIndex = 5
        '
        'lblBacklog
        '
        Me.lblBacklog.Location = New System.Drawing.Point(47, 171)
        Me.lblBacklog.Name = "lblBacklog"
        Me.lblBacklog.Size = New System.Drawing.Size(45, 18)
        Me.lblBacklog.TabIndex = 0
        Me.lblBacklog.Text = "Backlog"
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(37, 41)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'txtPartName
        '
        Me.txtPartName.Enabled = False
        Me.txtPartName.Location = New System.Drawing.Point(98, 64)
        Me.txtPartName.Multiline = True
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.ReadOnly = True
        '
        '
        '
        Me.txtPartName.RootElement.StretchVertically = True
        Me.txtPartName.Size = New System.Drawing.Size(120, 47)
        Me.txtPartName.TabIndex = 3
        '
        'lblPartName
        '
        Me.lblPartName.Location = New System.Drawing.Point(33, 65)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(59, 18)
        Me.lblPartName.TabIndex = 0
        Me.lblPartName.Text = "Part Name"
        '
        'lblEffectivityDate
        '
        Me.lblEffectivityDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEffectivityDate.Location = New System.Drawing.Point(11, 14)
        Me.lblEffectivityDate.Name = "lblEffectivityDate"
        Me.lblEffectivityDate.Size = New System.Drawing.Size(81, 18)
        Me.lblEffectivityDate.TabIndex = 0
        Me.lblEffectivityDate.Text = "Effectivity Date"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 196)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        '
        'lblRemarks
        '
        Me.lblRemarks.Location = New System.Drawing.Point(43, 118)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(49, 18)
        Me.lblRemarks.TabIndex = 0
        Me.lblRemarks.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(98, 117)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ReadOnly = True
        '
        '
        '
        Me.txtRemarks.RootElement.StretchVertically = True
        Me.txtRemarks.Size = New System.Drawing.Size(120, 47)
        Me.txtRemarks.TabIndex = 4
        '
        'FrmEditBacklog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 235)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditBacklog"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Backlog"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.dtEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBacklog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblBacklog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPartName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dtEffectivityDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents seBacklog As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblBacklog As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPartName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPartName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblEffectivityDate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblRemarks As Telerik.WinControls.UI.RadLabel
End Class

