<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBSSOtherDetails
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
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.txtOtherDetails = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTime = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.txtRMID = New Telerik.WinControls.UI.RadTextBox()
        Me.gvOtherDetails = New Telerik.WinControls.UI.RadGridView()
        Me.btnAddRM = New Telerik.WinControls.UI.RadButton()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOtherDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOtherDetails.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.btnAddRM)
        Me.z.Controls.Add(Me.gvOtherDetails)
        Me.z.Controls.Add(Me.txtRMID)
        Me.z.Controls.Add(Me.btnSave)
        Me.z.Controls.Add(Me.txtTime)
        Me.z.Controls.Add(Me.RadLabel1)
        Me.z.Controls.Add(Me.RadTextBox1)
        Me.z.Controls.Add(Me.RadLabel19)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Controls.Add(Me.txtOtherDetails)
        Me.z.Dock = System.Windows.Forms.DockStyle.Fill
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(596, 530)
        Me.z.TabIndex = 19
        Me.z.ThemeName = "Office2007Black"
        '
        'RadLabel18
        '
        Me.RadLabel18.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel18.Location = New System.Drawing.Point(24, 108)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(72, 18)
        Me.RadLabel18.TabIndex = 128
        Me.RadLabel18.Text = "Other Details"
        '
        'txtOtherDetails
        '
        Me.txtOtherDetails.Location = New System.Drawing.Point(24, 132)
        Me.txtOtherDetails.Multiline = True
        Me.txtOtherDetails.Name = "txtOtherDetails"
        '
        '
        '
        Me.txtOtherDetails.RootElement.StretchVertically = True
        Me.txtOtherDetails.Size = New System.Drawing.Size(502, 70)
        Me.txtOtherDetails.TabIndex = 127
        '
        'txtTime
        '
        Me.txtTime.Enabled = False
        Me.txtTime.Location = New System.Drawing.Point(78, 12)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(179, 20)
        Me.txtTime.TabIndex = 164
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel1.Location = New System.Drawing.Point(24, 38)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(48, 18)
        Me.RadLabel1.TabIndex = 163
        Me.RadLabel1.Text = "Tray No:"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Enabled = False
        Me.RadTextBox1.Location = New System.Drawing.Point(79, 39)
        Me.RadTextBox1.Multiline = True
        Me.RadTextBox1.Name = "RadTextBox1"
        '
        '
        '
        Me.RadTextBox1.RootElement.StretchVertically = True
        Me.RadTextBox1.Size = New System.Drawing.Size(178, 40)
        Me.RadTextBox1.TabIndex = 162
        '
        'RadLabel19
        '
        Me.RadLabel19.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel19.Location = New System.Drawing.Point(24, 14)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(33, 18)
        Me.RadLabel19.TabIndex = 161
        Me.RadLabel19.Text = "Time:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(498, 486)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 24)
        Me.btnSave.TabIndex = 165
        Me.btnSave.Text = "Save"
        '
        'txtRMID
        '
        Me.txtRMID.Location = New System.Drawing.Point(12, 507)
        Me.txtRMID.Name = "txtRMID"
        Me.txtRMID.Size = New System.Drawing.Size(28, 20)
        Me.txtRMID.TabIndex = 166
        Me.txtRMID.Visible = False
        '
        'gvOtherDetails
        '
        Me.gvOtherDetails.Location = New System.Drawing.Point(24, 208)
        '
        '
        '
        Me.gvOtherDetails.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvOtherDetails.Name = "gvOtherDetails"
        Me.gvOtherDetails.Size = New System.Drawing.Size(553, 272)
        Me.gvOtherDetails.TabIndex = 167
        '
        'btnAddRM
        '
        Me.btnAddRM.Location = New System.Drawing.Point(532, 183)
        Me.btnAddRM.Name = "btnAddRM"
        Me.btnAddRM.Size = New System.Drawing.Size(45, 19)
        Me.btnAddRM.TabIndex = 168
        Me.btnAddRM.Text = "Add"
        '
        'FrmBSSOtherDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 530)
        Me.Controls.Add(Me.z)
        Me.Name = "FrmBSSOtherDetails"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Other Details"
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOtherDetails.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOtherDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtOtherDetails As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtTime As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtRMID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents gvOtherDetails As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnAddRM As Telerik.WinControls.UI.RadButton
End Class

