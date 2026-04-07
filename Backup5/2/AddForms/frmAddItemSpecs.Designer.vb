<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddItemSpecs
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
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.seCycleTime = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.seCollection = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.seLoss = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.seRunnerWeight = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.sePartWeight = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.seCav = New Telerik.WinControls.UI.RadSpinEditor()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnContinue = New Telerik.WinControls.UI.RadButton()
        Me.txtItemCode = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpEffectivityDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtId = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seCycleTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seLoss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seRunnerWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePartWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seCav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpEffectivityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtId)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.dtpEffectivityDate)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.txtItemCode)
        Me.RadPanel1.Controls.Add(Me.btnCancel)
        Me.RadPanel1.Controls.Add(Me.btnContinue)
        Me.RadPanel1.Controls.Add(Me.RadLabel13)
        Me.RadPanel1.Controls.Add(Me.seCycleTime)
        Me.RadPanel1.Controls.Add(Me.RadLabel12)
        Me.RadPanel1.Controls.Add(Me.seCollection)
        Me.RadPanel1.Controls.Add(Me.RadLabel11)
        Me.RadPanel1.Controls.Add(Me.seLoss)
        Me.RadPanel1.Controls.Add(Me.RadLabel10)
        Me.RadPanel1.Controls.Add(Me.seRunnerWeight)
        Me.RadPanel1.Controls.Add(Me.RadLabel9)
        Me.RadPanel1.Controls.Add(Me.sePartWeight)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.seCav)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(396, 286)
        Me.RadPanel1.TabIndex = 0
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadLabel13
        '
        Me.RadLabel13.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel13.Location = New System.Drawing.Point(50, 170)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(62, 18)
        Me.RadLabel13.TabIndex = 47
        Me.RadLabel13.Text = "Cycle Time:"
        '
        'seCycleTime
        '
        Me.seCycleTime.DecimalPlaces = 2
        Me.seCycleTime.Location = New System.Drawing.Point(118, 168)
        Me.seCycleTime.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seCycleTime.Name = "seCycleTime"
        Me.seCycleTime.ShowUpDownButtons = False
        Me.seCycleTime.Size = New System.Drawing.Size(188, 20)
        Me.seCycleTime.TabIndex = 6
        Me.seCycleTime.ThousandsSeparator = True
        '
        'RadLabel12
        '
        Me.RadLabel12.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel12.Location = New System.Drawing.Point(53, 144)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(59, 18)
        Me.RadLabel12.TabIndex = 46
        Me.RadLabel12.Text = "Collection:"
        '
        'seCollection
        '
        Me.seCollection.DecimalPlaces = 2
        Me.seCollection.Location = New System.Drawing.Point(118, 142)
        Me.seCollection.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seCollection.Name = "seCollection"
        Me.seCollection.ShowUpDownButtons = False
        Me.seCollection.Size = New System.Drawing.Size(188, 20)
        Me.seCollection.TabIndex = 5
        Me.seCollection.ThousandsSeparator = True
        '
        'RadLabel11
        '
        Me.RadLabel11.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel11.Location = New System.Drawing.Point(82, 118)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel11.TabIndex = 45
        Me.RadLabel11.Text = "Loss:"
        '
        'seLoss
        '
        Me.seLoss.DecimalPlaces = 2
        Me.seLoss.Location = New System.Drawing.Point(118, 116)
        Me.seLoss.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seLoss.Name = "seLoss"
        Me.seLoss.ShowUpDownButtons = False
        Me.seLoss.Size = New System.Drawing.Size(188, 20)
        Me.seLoss.TabIndex = 4
        Me.seLoss.ThousandsSeparator = True
        '
        'RadLabel10
        '
        Me.RadLabel10.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel10.Location = New System.Drawing.Point(28, 92)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(84, 18)
        Me.RadLabel10.TabIndex = 44
        Me.RadLabel10.Text = "Runner Weight:"
        '
        'seRunnerWeight
        '
        Me.seRunnerWeight.DecimalPlaces = 2
        Me.seRunnerWeight.Location = New System.Drawing.Point(118, 90)
        Me.seRunnerWeight.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seRunnerWeight.Name = "seRunnerWeight"
        Me.seRunnerWeight.ShowUpDownButtons = False
        Me.seRunnerWeight.Size = New System.Drawing.Size(188, 20)
        Me.seRunnerWeight.TabIndex = 3
        Me.seRunnerWeight.ThousandsSeparator = True
        '
        'RadLabel9
        '
        Me.RadLabel9.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel9.Location = New System.Drawing.Point(44, 66)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(68, 18)
        Me.RadLabel9.TabIndex = 43
        Me.RadLabel9.Text = "Part Weight:"
        '
        'sePartWeight
        '
        Me.sePartWeight.DecimalPlaces = 2
        Me.sePartWeight.Location = New System.Drawing.Point(118, 64)
        Me.sePartWeight.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.sePartWeight.Name = "sePartWeight"
        Me.sePartWeight.ShowUpDownButtons = False
        Me.sePartWeight.Size = New System.Drawing.Size(188, 20)
        Me.sePartWeight.TabIndex = 2
        Me.sePartWeight.ThousandsSeparator = True
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(85, 41)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(27, 18)
        Me.RadLabel1.TabIndex = 42
        Me.RadLabel1.Text = "Cav:"
        '
        'seCav
        '
        Me.seCav.DecimalPlaces = 2
        Me.seCav.Location = New System.Drawing.Point(118, 39)
        Me.seCav.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seCav.Name = "seCav"
        Me.seCav.ShowUpDownButtons = False
        Me.seCav.Size = New System.Drawing.Size(188, 20)
        Me.seCav.TabIndex = 1
        Me.seCav.ThousandsSeparator = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(206, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(81, 241)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(110, 24)
        Me.btnContinue.TabIndex = 8
        Me.btnContinue.Text = "Continue"
        '
        'txtItemCode
        '
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Location = New System.Drawing.Point(118, 13)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(188, 20)
        Me.txtItemCode.TabIndex = 0
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(50, 15)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel2.TabIndex = 52
        Me.RadLabel2.Text = "Item Code:"
        '
        'dtpEffectivityDate
        '
        Me.dtpEffectivityDate.Location = New System.Drawing.Point(118, 194)
        Me.dtpEffectivityDate.Name = "dtpEffectivityDate"
        Me.dtpEffectivityDate.Size = New System.Drawing.Size(188, 20)
        Me.dtpEffectivityDate.TabIndex = 7
        Me.dtpEffectivityDate.TabStop = False
        Me.dtpEffectivityDate.Text = "Thursday, May 9, 2019"
        Me.dtpEffectivityDate.Value = New Date(2019, 5, 9, 10, 47, 47, 543)
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(28, 196)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(83, 18)
        Me.RadLabel3.TabIndex = 54
        Me.RadLabel3.Text = "Effectivity Date:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(342, 216)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(23, 20)
        Me.txtId.TabIndex = 55
        Me.txtId.Visible = False
        '
        'FrmAddItemSpecs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 286)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(404, 316)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(404, 316)
        Me.Name = "FrmAddItemSpecs"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(404, 316)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Item Specs"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seCycleTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seLoss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seRunnerWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePartWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seCav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpEffectivityDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seCycleTime As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seCollection As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seLoss As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seRunnerWeight As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents sePartWeight As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seCav As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpEffectivityDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtItemCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnContinue As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtId As Telerik.WinControls.UI.RadTextBox
End Class

