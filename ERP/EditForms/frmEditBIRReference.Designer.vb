<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditBIRReference
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditBIRReference))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtPermitNo = New Telerik.WinControls.UI.RadTextBox()
        Me.lblPermitNo = New Telerik.WinControls.UI.RadLabel()
        Me.dtDateIssued = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblDateIssued = New Telerik.WinControls.UI.RadLabel()
        Me.numSeriesTo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numSeriesFrom = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblSeriesTo = New Telerik.WinControls.UI.RadLabel()
        Me.lblSeriesFrom = New Telerik.WinControls.UI.RadLabel()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPermitNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPermitNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateIssued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateIssued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSeriesTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSeriesFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeriesTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeriesFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.numSeriesTo)
        Me.panel.Controls.Add(Me.numSeriesFrom)
        Me.panel.Controls.Add(Me.lblSeriesTo)
        Me.panel.Controls.Add(Me.lblSeriesFrom)
        Me.panel.Controls.Add(Me.dtDateIssued)
        Me.panel.Controls.Add(Me.lblDateIssued)
        Me.panel.Controls.Add(Me.txtPermitNo)
        Me.panel.Controls.Add(Me.lblPermitNo)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(247, 160)
        Me.panel.TabIndex = 1
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(100, 116)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 24)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        '
        'txtPermitNo
        '
        Me.txtPermitNo.Enabled = False
        Me.txtPermitNo.Location = New System.Drawing.Point(100, 12)
        Me.txtPermitNo.Name = "txtPermitNo"
        Me.txtPermitNo.Size = New System.Drawing.Size(120, 20)
        Me.txtPermitNo.TabIndex = 1
        '
        'lblPermitNo
        '
        Me.lblPermitNo.Location = New System.Drawing.Point(37, 14)
        Me.lblPermitNo.Name = "lblPermitNo"
        Me.lblPermitNo.Size = New System.Drawing.Size(57, 18)
        Me.lblPermitNo.TabIndex = 0
        Me.lblPermitNo.Text = "Permit No"
        '
        'dtDateIssued
        '
        Me.dtDateIssued.CustomFormat = "MMM dd, yyyy"
        Me.dtDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateIssued.Location = New System.Drawing.Point(100, 38)
        Me.dtDateIssued.Name = "dtDateIssued"
        Me.dtDateIssued.Size = New System.Drawing.Size(120, 20)
        Me.dtDateIssued.TabIndex = 2
        Me.dtDateIssued.TabStop = False
        Me.dtDateIssued.Text = "Mar 23, 2021"
        Me.dtDateIssued.Value = New Date(2021, 3, 23, 13, 57, 38, 321)
        '
        'lblDateIssued
        '
        Me.lblDateIssued.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateIssued.Location = New System.Drawing.Point(30, 40)
        Me.lblDateIssued.Name = "lblDateIssued"
        Me.lblDateIssued.Size = New System.Drawing.Size(64, 18)
        Me.lblDateIssued.TabIndex = 0
        Me.lblDateIssued.Text = "Date Issued"
        '
        'numSeriesTo
        '
        Me.numSeriesTo.Location = New System.Drawing.Point(100, 90)
        Me.numSeriesTo.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numSeriesTo.Name = "numSeriesTo"
        Me.numSeriesTo.Size = New System.Drawing.Size(120, 20)
        Me.numSeriesTo.TabIndex = 4
        Me.numSeriesTo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numSeriesTo.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numSeriesTo.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'numSeriesFrom
        '
        Me.numSeriesFrom.Location = New System.Drawing.Point(100, 64)
        Me.numSeriesFrom.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numSeriesFrom.Name = "numSeriesFrom"
        Me.numSeriesFrom.Size = New System.Drawing.Size(120, 20)
        Me.numSeriesFrom.TabIndex = 3
        Me.numSeriesFrom.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numSeriesFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numSeriesFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'lblSeriesTo
        '
        Me.lblSeriesTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeriesTo.Location = New System.Drawing.Point(43, 92)
        Me.lblSeriesTo.Name = "lblSeriesTo"
        Me.lblSeriesTo.Size = New System.Drawing.Size(51, 18)
        Me.lblSeriesTo.TabIndex = 0
        Me.lblSeriesTo.Text = "Series To"
        '
        'lblSeriesFrom
        '
        Me.lblSeriesFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeriesFrom.Location = New System.Drawing.Point(33, 66)
        Me.lblSeriesFrom.Name = "lblSeriesFrom"
        Me.lblSeriesFrom.Size = New System.Drawing.Size(61, 18)
        Me.lblSeriesFrom.TabIndex = 0
        Me.lblSeriesFrom.Text = "SeriesFrom"
        '
        'FrmEditBIRReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 160)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditBIRReference"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit BIR Reference"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPermitNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPermitNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateIssued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateIssued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSeriesTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSeriesFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeriesTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeriesFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtPermitNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblPermitNo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtDateIssued As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblDateIssued As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numSeriesTo As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numSeriesFrom As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblSeriesTo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblSeriesFrom As Telerik.WinControls.UI.RadLabel
End Class

