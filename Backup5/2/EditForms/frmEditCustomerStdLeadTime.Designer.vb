<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditCustomerStdLeadTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditCustomerStdLeadTime))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.lblCustomer = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.dtEffectivityDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.lblEffectivityDate = New Telerik.WinControls.UI.RadLabel()
        Me.numETDManilaSea = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numETDManilaAir = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblETDManilaSea = New Telerik.WinControls.UI.RadLabel()
        Me.lblETDManilaAir = New Telerik.WinControls.UI.RadLabel()
        Me.numETACustomerAir = New Telerik.WinControls.UI.RadSpinEditor()
        Me.numETACustomerSea = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lblETACustomerAir = New Telerik.WinControls.UI.RadLabel()
        Me.lblETACustomerSea = New Telerik.WinControls.UI.RadLabel()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numETDManilaSea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numETDManilaAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDManilaSea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETDManilaAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numETACustomerAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numETACustomerSea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETACustomerAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblETACustomerSea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.numETACustomerAir)
        Me.panel.Controls.Add(Me.numETACustomerSea)
        Me.panel.Controls.Add(Me.lblETACustomerAir)
        Me.panel.Controls.Add(Me.lblETACustomerSea)
        Me.panel.Controls.Add(Me.numETDManilaSea)
        Me.panel.Controls.Add(Me.numETDManilaAir)
        Me.panel.Controls.Add(Me.lblETDManilaSea)
        Me.panel.Controls.Add(Me.lblETDManilaAir)
        Me.panel.Controls.Add(Me.dtEffectivityDate)
        Me.panel.Controls.Add(Me.lblEffectivityDate)
        Me.panel.Controls.Add(Me.txtCustomer)
        Me.panel.Controls.Add(Me.lblCustomer)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(247, 205)
        Me.panel.TabIndex = 0
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(116, 12)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(120, 20)
        Me.txtCustomer.TabIndex = 1
        '
        'lblCustomer
        '
        Me.lblCustomer.Location = New System.Drawing.Point(55, 14)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 18)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(116, 168)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 24)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        '
        'dtEffectivityDate
        '
        Me.dtEffectivityDate.CustomFormat = "MMM dd, yyyy"
        Me.dtEffectivityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEffectivityDate.Location = New System.Drawing.Point(116, 142)
        Me.dtEffectivityDate.Name = "dtEffectivityDate"
        Me.dtEffectivityDate.Size = New System.Drawing.Size(119, 20)
        Me.dtEffectivityDate.TabIndex = 6
        Me.dtEffectivityDate.TabStop = False
        Me.dtEffectivityDate.Text = "Mar 23, 2021"
        Me.dtEffectivityDate.Value = New Date(2021, 3, 23, 13, 57, 38, 321)
        '
        'lblEffectivityDate
        '
        Me.lblEffectivityDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEffectivityDate.Location = New System.Drawing.Point(29, 143)
        Me.lblEffectivityDate.Name = "lblEffectivityDate"
        Me.lblEffectivityDate.Size = New System.Drawing.Size(81, 18)
        Me.lblEffectivityDate.TabIndex = 0
        Me.lblEffectivityDate.Text = "Effectivity Date"
        '
        'numETDManilaSea
        '
        Me.numETDManilaSea.Location = New System.Drawing.Point(116, 38)
        Me.numETDManilaSea.Name = "numETDManilaSea"
        Me.numETDManilaSea.Size = New System.Drawing.Size(120, 20)
        Me.numETDManilaSea.TabIndex = 2
        Me.numETDManilaSea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numETDManilaSea.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numETDManilaSea.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'numETDManilaAir
        '
        Me.numETDManilaAir.Location = New System.Drawing.Point(116, 64)
        Me.numETDManilaAir.Name = "numETDManilaAir"
        Me.numETDManilaAir.Size = New System.Drawing.Size(120, 20)
        Me.numETDManilaAir.TabIndex = 3
        Me.numETDManilaAir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numETDManilaAir.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numETDManilaAir.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'lblETDManilaSea
        '
        Me.lblETDManilaSea.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDManilaSea.Location = New System.Drawing.Point(20, 40)
        Me.lblETDManilaSea.Name = "lblETDManilaSea"
        Me.lblETDManilaSea.Size = New System.Drawing.Size(90, 18)
        Me.lblETDManilaSea.TabIndex = 0
        Me.lblETDManilaSea.Text = "ETD Manila (Sea)"
        '
        'lblETDManilaAir
        '
        Me.lblETDManilaAir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETDManilaAir.Location = New System.Drawing.Point(24, 66)
        Me.lblETDManilaAir.Name = "lblETDManilaAir"
        Me.lblETDManilaAir.Size = New System.Drawing.Size(86, 18)
        Me.lblETDManilaAir.TabIndex = 0
        Me.lblETDManilaAir.Text = "ETD Manila (Air)"
        '
        'numETACustomerAir
        '
        Me.numETACustomerAir.Location = New System.Drawing.Point(116, 116)
        Me.numETACustomerAir.Name = "numETACustomerAir"
        Me.numETACustomerAir.Size = New System.Drawing.Size(120, 20)
        Me.numETACustomerAir.TabIndex = 5
        Me.numETACustomerAir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numETACustomerAir.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numETACustomerAir.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'numETACustomerSea
        '
        Me.numETACustomerSea.Location = New System.Drawing.Point(116, 90)
        Me.numETACustomerSea.Name = "numETACustomerSea"
        Me.numETACustomerSea.Size = New System.Drawing.Size(120, 20)
        Me.numETACustomerSea.TabIndex = 4
        Me.numETACustomerSea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        CType(Me.numETACustomerSea.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadSpinElementUpButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.numETACustomerSea.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadSpinElementDownButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'lblETACustomerAir
        '
        Me.lblETACustomerAir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETACustomerAir.Location = New System.Drawing.Point(9, 118)
        Me.lblETACustomerAir.Name = "lblETACustomerAir"
        Me.lblETACustomerAir.Size = New System.Drawing.Size(101, 18)
        Me.lblETACustomerAir.TabIndex = 0
        Me.lblETACustomerAir.Text = "ETA Customer (Air)"
        '
        'lblETACustomerSea
        '
        Me.lblETACustomerSea.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblETACustomerSea.Location = New System.Drawing.Point(6, 92)
        Me.lblETACustomerSea.Name = "lblETACustomerSea"
        Me.lblETACustomerSea.Size = New System.Drawing.Size(104, 18)
        Me.lblETACustomerSea.TabIndex = 0
        Me.lblETACustomerSea.Text = "ETA Customer (Sea)"
        '
        'FrmEditCustomerStdLeadTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 205)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEditCustomerStdLeadTime"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Customer Std Lead Time"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numETDManilaSea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numETDManilaAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDManilaSea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETDManilaAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numETACustomerAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numETACustomerSea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETACustomerAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblETACustomerSea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblCustomer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dtEffectivityDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblEffectivityDate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numETDManilaSea As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numETDManilaAir As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblETDManilaSea As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETDManilaAir As Telerik.WinControls.UI.RadLabel
    Friend WithEvents numETACustomerAir As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents numETACustomerSea As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lblETACustomerAir As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblETACustomerSea As Telerik.WinControls.UI.RadLabel
End Class

