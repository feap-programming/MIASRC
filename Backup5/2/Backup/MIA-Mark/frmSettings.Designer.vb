<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.gbDatabase = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnSaveDb = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDbName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDbPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDbUser = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDbHost = New Telerik.WinControls.UI.RadTextBox()
        Me.gbReportServer = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnSaveRep = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRepPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRepUser = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRepHost = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.gbDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatabase.SuspendLayout()
        CType(Me.btnSaveDb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDbName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDbPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDbHost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbReportServer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbReportServer.SuspendLayout()
        CType(Me.btnSaveRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRepPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRepUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRepHost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatabase
        '
        Me.gbDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gbDatabase.BackColor = System.Drawing.Color.Transparent
        Me.gbDatabase.Controls.Add(Me.btnSaveDb)
        Me.gbDatabase.Controls.Add(Me.RadLabel4)
        Me.gbDatabase.Controls.Add(Me.RadLabel3)
        Me.gbDatabase.Controls.Add(Me.RadLabel2)
        Me.gbDatabase.Controls.Add(Me.RadLabel1)
        Me.gbDatabase.Controls.Add(Me.txtDbName)
        Me.gbDatabase.Controls.Add(Me.txtDbPassword)
        Me.gbDatabase.Controls.Add(Me.txtDbUser)
        Me.gbDatabase.Controls.Add(Me.txtDbHost)
        Me.gbDatabase.HeaderText = "Database Connection"
        Me.gbDatabase.Location = New System.Drawing.Point(12, 22)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(399, 189)
        Me.gbDatabase.TabIndex = 0
        Me.gbDatabase.Text = "Database Connection"
        '
        'btnSaveDb
        '
        Me.btnSaveDb.Location = New System.Drawing.Point(259, 147)
        Me.btnSaveDb.Name = "btnSaveDb"
        Me.btnSaveDb.Size = New System.Drawing.Size(110, 24)
        Me.btnSaveDb.TabIndex = 4
        Me.btnSaveDb.Text = "Save"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(31, 110)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(88, 18)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "Database Name:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(63, 84)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel3.TabIndex = 6
        Me.RadLabel3.Text = "Password:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(87, 58)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "User:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(87, 32)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(32, 18)
        Me.RadLabel1.TabIndex = 4
        Me.RadLabel1.Text = "Host:"
        '
        'txtDbName
        '
        Me.txtDbName.Location = New System.Drawing.Point(125, 108)
        Me.txtDbName.Name = "txtDbName"
        Me.txtDbName.Size = New System.Drawing.Size(188, 20)
        Me.txtDbName.TabIndex = 3
        '
        'txtDbPassword
        '
        Me.txtDbPassword.Location = New System.Drawing.Point(125, 82)
        Me.txtDbPassword.Name = "txtDbPassword"
        Me.txtDbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtDbPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtDbPassword.TabIndex = 2
        '
        'txtDbUser
        '
        Me.txtDbUser.Location = New System.Drawing.Point(125, 56)
        Me.txtDbUser.Name = "txtDbUser"
        Me.txtDbUser.Size = New System.Drawing.Size(188, 20)
        Me.txtDbUser.TabIndex = 1
        '
        'txtDbHost
        '
        Me.txtDbHost.Location = New System.Drawing.Point(125, 30)
        Me.txtDbHost.Name = "txtDbHost"
        Me.txtDbHost.Size = New System.Drawing.Size(188, 20)
        Me.txtDbHost.TabIndex = 0
        '
        'gbReportServer
        '
        Me.gbReportServer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gbReportServer.Controls.Add(Me.btnSaveRep)
        Me.gbReportServer.Controls.Add(Me.RadLabel7)
        Me.gbReportServer.Controls.Add(Me.RadLabel6)
        Me.gbReportServer.Controls.Add(Me.RadLabel5)
        Me.gbReportServer.Controls.Add(Me.txtRepPassword)
        Me.gbReportServer.Controls.Add(Me.txtRepUser)
        Me.gbReportServer.Controls.Add(Me.txtRepHost)
        Me.gbReportServer.HeaderText = "Report Server Connection"
        Me.gbReportServer.Location = New System.Drawing.Point(12, 217)
        Me.gbReportServer.Name = "gbReportServer"
        Me.gbReportServer.Size = New System.Drawing.Size(399, 175)
        Me.gbReportServer.TabIndex = 1
        Me.gbReportServer.Text = "Report Server Connection"
        '
        'btnSaveRep
        '
        Me.btnSaveRep.Location = New System.Drawing.Point(259, 122)
        Me.btnSaveRep.Name = "btnSaveRep"
        Me.btnSaveRep.Size = New System.Drawing.Size(110, 24)
        Me.btnSaveRep.TabIndex = 3
        Me.btnSaveRep.Text = "Save"
        '
        'RadLabel7
        '
        Me.RadLabel7.Location = New System.Drawing.Point(63, 82)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel7.TabIndex = 10
        Me.RadLabel7.Text = "Password:"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(88, 56)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel6.TabIndex = 9
        Me.RadLabel6.Text = "User:"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(87, 30)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(32, 18)
        Me.RadLabel5.TabIndex = 8
        Me.RadLabel5.Text = "Host:"
        '
        'txtRepPassword
        '
        Me.txtRepPassword.Location = New System.Drawing.Point(125, 80)
        Me.txtRepPassword.Name = "txtRepPassword"
        Me.txtRepPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtRepPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtRepPassword.TabIndex = 2
        '
        'txtRepUser
        '
        Me.txtRepUser.Location = New System.Drawing.Point(125, 54)
        Me.txtRepUser.Name = "txtRepUser"
        Me.txtRepUser.Size = New System.Drawing.Size(188, 20)
        Me.txtRepUser.TabIndex = 1
        '
        'txtRepHost
        '
        Me.txtRepHost.Location = New System.Drawing.Point(125, 28)
        Me.txtRepHost.Name = "txtRepHost"
        Me.txtRepHost.Size = New System.Drawing.Size(188, 20)
        Me.txtRepHost.TabIndex = 0
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(429, 429)
        Me.Controls.Add(Me.gbReportServer)
        Me.Controls.Add(Me.gbDatabase)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.gbDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatabase.ResumeLayout(False)
        Me.gbDatabase.PerformLayout()
        CType(Me.btnSaveDb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDbName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDbPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDbHost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbReportServer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReportServer.ResumeLayout(False)
        Me.gbReportServer.PerformLayout()
        CType(Me.btnSaveRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRepPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRepUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRepHost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatabase As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtDbPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDbUser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDbHost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents gbReportServer As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtDbName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRepPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtRepUser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtRepHost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSaveDb As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSaveRep As Telerik.WinControls.UI.RadButton
End Class

