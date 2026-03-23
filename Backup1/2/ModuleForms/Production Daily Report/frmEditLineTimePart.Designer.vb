<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditLineTimePart
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
        Me.spnFrom = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.spnTo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.tbOpTime = New Telerik.WinControls.UI.RadTextBox()
        Me.btnDone = New Telerik.WinControls.UI.RadButton()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.spnFromM = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.spnToM = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.spnFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOpTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnFromM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnToM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spnFrom
        '
        Me.spnFrom.Location = New System.Drawing.Point(63, 36)
        Me.spnFrom.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnFrom.Name = "spnFrom"
        Me.spnFrom.Size = New System.Drawing.Size(33, 20)
        Me.spnFrom.TabIndex = 14
        Me.spnFrom.ThemeName = "Office2007Black"
        CType(Me.spnFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadLabel5
        '
        Me.RadLabel5.ForeColor = System.Drawing.Color.White
        Me.RadLabel5.Location = New System.Drawing.Point(3, 14)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(102, 18)
        Me.RadLabel5.TabIndex = 13
        Me.RadLabel5.Text = "Line Time Partition:"
        '
        'RadLabel1
        '
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(23, 38)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(34, 18)
        Me.RadLabel1.TabIndex = 15
        Me.RadLabel1.Text = "From:"
        '
        'RadLabel2
        '
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(134, 38)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(19, 18)
        Me.RadLabel2.TabIndex = 17
        Me.RadLabel2.Text = "To"
        '
        'spnTo
        '
        Me.spnTo.Location = New System.Drawing.Point(153, 36)
        Me.spnTo.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnTo.Name = "spnTo"
        Me.spnTo.Size = New System.Drawing.Size(33, 20)
        Me.spnTo.TabIndex = 16
        Me.spnTo.ThemeName = "Office2007Black"
        CType(Me.spnTo.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadLabel3
        '
        Me.RadLabel3.ForeColor = System.Drawing.Color.White
        Me.RadLabel3.Location = New System.Drawing.Point(3, 71)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(87, 18)
        Me.RadLabel3.TabIndex = 18
        Me.RadLabel3.Text = "Operation Time:"
        '
        'tbOpTime
        '
        Me.tbOpTime.Location = New System.Drawing.Point(63, 95)
        Me.tbOpTime.Name = "tbOpTime"
        Me.tbOpTime.ReadOnly = True
        Me.tbOpTime.Size = New System.Drawing.Size(166, 20)
        Me.tbOpTime.TabIndex = 19
        Me.tbOpTime.Text = "0"
        Me.tbOpTime.ThemeName = "Office2007Black"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(63, 121)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(110, 24)
        Me.btnDone.TabIndex = 20
        Me.btnDone.Text = "DONE"
        Me.btnDone.ThemeName = "CrystalDark"
        '
        'spnFromM
        '
        Me.spnFromM.Location = New System.Drawing.Point(102, 36)
        Me.spnFromM.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnFromM.Name = "spnFromM"
        Me.spnFromM.Size = New System.Drawing.Size(33, 20)
        Me.spnFromM.TabIndex = 15
        Me.spnFromM.ThemeName = "Office2007Black"
        CType(Me.spnFromM.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadLabel4
        '
        Me.RadLabel4.ForeColor = System.Drawing.Color.White
        Me.RadLabel4.Location = New System.Drawing.Point(95, 38)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(9, 18)
        Me.RadLabel4.TabIndex = 22
        Me.RadLabel4.Text = ":"
        '
        'spnToM
        '
        Me.spnToM.Location = New System.Drawing.Point(194, 36)
        Me.spnToM.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.spnToM.Name = "spnToM"
        Me.spnToM.Size = New System.Drawing.Size(33, 20)
        Me.spnToM.TabIndex = 17
        Me.spnToM.ThemeName = "Office2007Black"
        CType(Me.spnToM.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadLabel6
        '
        Me.RadLabel6.ForeColor = System.Drawing.Color.White
        Me.RadLabel6.Location = New System.Drawing.Point(186, 38)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(9, 18)
        Me.RadLabel6.TabIndex = 24
        Me.RadLabel6.Text = ":"
        '
        'FrmEditLineTimePart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 148)
        Me.Controls.Add(Me.spnToM)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.spnFromM)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.tbOpTime)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.spnTo)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.spnFrom)
        Me.Controls.Add(Me.RadLabel5)
        Me.Name = "FrmEditLineTimePart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Line Time Partition"
        Me.ThemeName = "CrystalDark"
        CType(Me.spnFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOpTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnFromM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnToM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spnFrom As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnTo As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbOpTime As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnDone As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents spnFromM As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spnToM As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
End Class

