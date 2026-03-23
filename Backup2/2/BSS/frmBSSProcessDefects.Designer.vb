<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSProcessDefects
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
        Dim TableViewDefinition9 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition10 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.btnImport = New Telerik.WinControls.UI.RadButton()
        Me.btnPaste = New Telerik.WinControls.UI.RadButton()
        Me.gvDefectsImport = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDefects = New Telerik.WinControls.UI.RadTextBox()
        Me.txtRMID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.gvDefects = New Telerik.WinControls.UI.RadGridView()
        Me.bwUpload = New System.ComponentModel.BackgroundWorker()
        Me.rpbImport = New Telerik.WinControls.UI.RadProgressBar()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.btnImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPaste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDefectsImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDefectsImport.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDefects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDefects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDefects.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpbImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.rpbImport)
        Me.z.Controls.Add(Me.btnImport)
        Me.z.Controls.Add(Me.btnPaste)
        Me.z.Controls.Add(Me.gvDefectsImport)
        Me.z.Controls.Add(Me.RadPanel1)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Controls.Add(Me.txtDefects)
        Me.z.Controls.Add(Me.txtRMID)
        Me.z.Controls.Add(Me.btnSave)
        Me.z.Controls.Add(Me.gvDefects)
        Me.z.Dock = System.Windows.Forms.DockStyle.Fill
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(818, 435)
        Me.z.TabIndex = 135
        Me.z.ThemeName = "Office2007Black"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(669, 25)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(79, 29)
        Me.btnImport.TabIndex = 141
        Me.btnImport.Text = "Import"
        '
        'btnPaste
        '
        Me.btnPaste.Location = New System.Drawing.Point(575, 25)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(79, 29)
        Me.btnPaste.TabIndex = 160
        Me.btnPaste.Text = "Paste Data"
        '
        'gvDefectsImport
        '
        Me.gvDefectsImport.Location = New System.Drawing.Point(575, 58)
        '
        '
        '
        Me.gvDefectsImport.MasterTemplate.ViewDefinition = TableViewDefinition9
        Me.gvDefectsImport.Name = "gvDefectsImport"
        Me.gvDefectsImport.Size = New System.Drawing.Size(231, 345)
        Me.gvDefectsImport.TabIndex = 159
        '
        'RadPanel1
        '
        Me.RadPanel1.Location = New System.Drawing.Point(559, 1)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1, 428)
        Me.RadPanel1.TabIndex = 136
        '
        'RadLabel18
        '
        Me.RadLabel18.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel18.Location = New System.Drawing.Point(23, 11)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(46, 18)
        Me.RadLabel18.TabIndex = 158
        Me.RadLabel18.Text = "Defects:"
        '
        'txtDefects
        '
        Me.txtDefects.Location = New System.Drawing.Point(78, 12)
        Me.txtDefects.Multiline = True
        Me.txtDefects.Name = "txtDefects"
        '
        '
        '
        Me.txtDefects.RootElement.StretchVertically = True
        Me.txtDefects.Size = New System.Drawing.Size(376, 40)
        Me.txtDefects.TabIndex = 157
        '
        'txtRMID
        '
        Me.txtRMID.Location = New System.Drawing.Point(14, 409)
        Me.txtRMID.Name = "txtRMID"
        Me.txtRMID.Size = New System.Drawing.Size(28, 20)
        Me.txtRMID.TabIndex = 154
        Me.txtRMID.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(460, 28)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 24)
        Me.btnSave.TabIndex = 140
        Me.btnSave.Text = "Save"
        '
        'gvDefects
        '
        Me.gvDefects.Location = New System.Drawing.Point(8, 58)
        '
        '
        '
        Me.gvDefects.MasterTemplate.ViewDefinition = TableViewDefinition10
        Me.gvDefects.Name = "gvDefects"
        Me.gvDefects.Size = New System.Drawing.Size(531, 345)
        Me.gvDefects.TabIndex = 87
        '
        'bwUpload
        '
        Me.bwUpload.WorkerReportsProgress = True
        '
        'rpbImport
        '
        Me.rpbImport.Location = New System.Drawing.Point(575, 407)
        Me.rpbImport.Name = "rpbImport"
        Me.rpbImport.Size = New System.Drawing.Size(231, 24)
        Me.rpbImport.TabIndex = 161
        Me.rpbImport.Text = "RadProgressBar1"
        '
        'FrmBSSProcessDefects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 435)
        Me.Controls.Add(Me.z)
        Me.Name = "FrmBSSProcessDefects"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BSS Process Defects"
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.btnImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPaste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDefectsImport.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDefectsImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDefects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDefects.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDefects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpbImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDefects As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtRMID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents gvDefects As Telerik.WinControls.UI.RadGridView
    Friend WithEvents gvDefectsImport As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnImport As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnPaste As Telerik.WinControls.UI.RadButton
    Friend WithEvents bwUpload As System.ComponentModel.BackgroundWorker
    Friend WithEvents rpbImport As Telerik.WinControls.UI.RadProgressBar
End Class

