<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePassword))
        Me.txtPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btnContinue = New Telerik.WinControls.UI.RadButton()
        Me.lblPasswordMeter = New Telerik.WinControls.UI.RadLabel()
        Me.txtUsername = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.panelConfirmPassword = New Telerik.WinControls.UI.RadPanel()
        Me.panelPassword = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtConfirmPassword = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPasswordMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelConfirmPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtConfirmPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(139, 23)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(186, 20)
        Me.txtPassword.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(77, 25)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Password:"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(34, 51)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(99, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Confirm Password:"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(112, 115)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(86, 24)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        '
        'lblPasswordMeter
        '
        Me.lblPasswordMeter.AutoSize = False
        Me.lblPasswordMeter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPasswordMeter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPasswordMeter.Location = New System.Drawing.Point(139, 75)
        Me.lblPasswordMeter.Name = "lblPasswordMeter"
        Me.lblPasswordMeter.Size = New System.Drawing.Size(186, 20)
        Me.lblPasswordMeter.TabIndex = 7
        Me.lblPasswordMeter.Text = "Weak"
        Me.lblPasswordMeter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPasswordMeter.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(34, 117)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(36, 20)
        Me.txtUsername.TabIndex = 8
        Me.txtUsername.Visible = False
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(44, 77)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(89, 18)
        Me.RadLabel3.TabIndex = 9
        Me.RadLabel3.Text = "Password Meter:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(204, 115)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'panelConfirmPassword
        '
        Me.panelConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.panelConfirmPassword.BackgroundImage = CType(resources.GetObject("panelConfirmPassword.BackgroundImage"), System.Drawing.Image)
        Me.panelConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelConfirmPassword.Location = New System.Drawing.Point(331, 49)
        Me.panelConfirmPassword.Name = "panelConfirmPassword"
        Me.panelConfirmPassword.Size = New System.Drawing.Size(20, 20)
        Me.panelConfirmPassword.TabIndex = 12
        Me.panelConfirmPassword.Visible = False
        CType(Me.panelConfirmPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'panelPassword
        '
        Me.panelPassword.BackColor = System.Drawing.Color.Transparent
        Me.panelPassword.BackgroundImage = CType(resources.GetObject("panelPassword.BackgroundImage"), System.Drawing.Image)
        Me.panelPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelPassword.Location = New System.Drawing.Point(331, 23)
        Me.panelPassword.Name = "panelPassword"
        Me.panelPassword.Size = New System.Drawing.Size(20, 20)
        Me.panelPassword.TabIndex = 11
        Me.panelPassword.Visible = False
        CType(Me.panelPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RadPanel1.Controls.Add(Me.txtConfirmPassword)
        Me.RadPanel1.Controls.Add(Me.txtPassword)
        Me.RadPanel1.Controls.Add(Me.panelConfirmPassword)
        Me.RadPanel1.Controls.Add(Me.panelPassword)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.txtUsername)
        Me.RadPanel1.Controls.Add(Me.btnContinue)
        Me.RadPanel1.Controls.Add(Me.lblPasswordMeter)
        Me.RadPanel1.Controls.Add(Me.btnCancel)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(388, 159)
        Me.RadPanel1.TabIndex = 13
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(139, 49)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(186, 20)
        Me.txtConfirmPassword.TabIndex = 1
        '
        'FrmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 159)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChangePassword"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPasswordMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelConfirmPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtConfirmPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnContinue As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblPasswordMeter As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtUsername As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents panelConfirmPassword As Telerik.WinControls.UI.RadPanel
    Friend WithEvents panelPassword As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtConfirmPassword As Telerik.WinControls.UI.RadTextBox
End Class

