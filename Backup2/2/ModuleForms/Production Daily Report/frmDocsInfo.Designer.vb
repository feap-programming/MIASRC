<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocsInfo
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblID = New Telerik.WinControls.UI.RadLabel()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.pbStamp = New System.Windows.Forms.PictureBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.dpEffDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.tbDocNo = New Telerik.WinControls.UI.RadTextBox()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.lblID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStamp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpEffDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDocNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadButton1)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.pbStamp)
        Me.Panel1.Controls.Add(Me.RadLabel3)
        Me.Panel1.Controls.Add(Me.dpEffDate)
        Me.Panel1.Controls.Add(Me.RadLabel2)
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.tbDocNo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(389, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 414)
        Me.Panel1.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(3, 376)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 25)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "ID"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(195, 375)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 33)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.ThemeName = "CrystalDark"
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(68, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 33)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        Me.btnSave.ThemeName = "CrystalDark"
        '
        'pbStamp
        '
        Me.pbStamp.BackColor = System.Drawing.Color.White
        Me.pbStamp.Location = New System.Drawing.Point(68, 239)
        Me.pbStamp.Name = "pbStamp"
        Me.pbStamp.Size = New System.Drawing.Size(271, 103)
        Me.pbStamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStamp.TabIndex = 6
        Me.pbStamp.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.ForeColor = System.Drawing.Color.White
        Me.RadLabel3.Location = New System.Drawing.Point(22, 208)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(58, 25)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Stamp:"
        '
        'dpEffDate
        '
        Me.dpEffDate.CalendarSize = New System.Drawing.Size(290, 320)
        Me.dpEffDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpEffDate.Location = New System.Drawing.Point(68, 154)
        Me.dpEffDate.Name = "dpEffDate"
        Me.dpEffDate.Size = New System.Drawing.Size(271, 31)
        Me.dpEffDate.TabIndex = 4
        Me.dpEffDate.TabStop = False
        Me.dpEffDate.Text = "Thursday, 13 April 2023"
        Me.dpEffDate.Value = New Date(2023, 4, 13, 10, 43, 59, 855)
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(22, 123)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(111, 25)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Effective Date:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(22, 38)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(152, 25)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Document Number:"
        '
        'tbDocNo
        '
        Me.tbDocNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDocNo.Location = New System.Drawing.Point(68, 69)
        Me.tbDocNo.Name = "tbDocNo"
        Me.tbDocNo.Size = New System.Drawing.Size(271, 31)
        Me.tbDocNo.TabIndex = 0
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvData.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.gvData.MasterTemplate.AllowDeleteRow = False
        Me.gvData.MasterTemplate.AllowDragToGroup = False
        Me.gvData.MasterTemplate.AllowEditRow = False
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(389, 414)
        Me.gvData.TabIndex = 1
        Me.gvData.ThemeName = "CrystalDark"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(268, 342)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(71, 18)
        Me.RadButton1.TabIndex = 10
        Me.RadButton1.Text = "Browse...."
        Me.RadButton1.ThemeName = "CrystalDark"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'FrmDocsInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 414)
        Me.Controls.Add(Me.gvData)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDocsInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Docs Info"
        Me.ThemeName = "CrystalDark"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lblID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStamp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpEffDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDocNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblID As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents pbStamp As PictureBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dpEffDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tbDocNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class

