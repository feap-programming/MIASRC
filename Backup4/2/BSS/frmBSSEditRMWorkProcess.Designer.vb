<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBSSEditRMWorkProcess
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.z = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTrayNo = New Telerik.WinControls.UI.RadTextBox()
        Me.rtpTime = New Telerik.WinControls.UI.RadTimePicker()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRMID = New Telerik.WinControls.UI.RadTextBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        CType(Me.z, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.z.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrayNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtpTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'z
        '
        Me.z.AutoScroll = True
        Me.z.BackColor = System.Drawing.Color.LightGray
        Me.z.Controls.Add(Me.RadLabel1)
        Me.z.Controls.Add(Me.RadLabel18)
        Me.z.Controls.Add(Me.txtTrayNo)
        Me.z.Controls.Add(Me.rtpTime)
        Me.z.Controls.Add(Me.RadLabel19)
        Me.z.Controls.Add(Me.txtRMID)
        Me.z.Dock = System.Windows.Forms.DockStyle.Top
        Me.z.Location = New System.Drawing.Point(0, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(399, 142)
        Me.z.TabIndex = 19
        Me.z.ThemeName = "Office2007Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel1.Location = New System.Drawing.Point(12, 61)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel1.TabIndex = 129
        Me.RadLabel1.Text = "Box No:"
        '
        'RadLabel18
        '
        Me.RadLabel18.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel18.Location = New System.Drawing.Point(11, 41)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(48, 18)
        Me.RadLabel18.TabIndex = 128
        Me.RadLabel18.Text = "Tray No:"
        '
        'txtTrayNo
        '
        Me.txtTrayNo.AcceptsReturn = True
        Me.txtTrayNo.Location = New System.Drawing.Point(80, 39)
        Me.txtTrayNo.Multiline = True
        Me.txtTrayNo.Name = "txtTrayNo"
        '
        '
        '
        Me.txtTrayNo.RootElement.StretchVertically = True
        Me.txtTrayNo.Size = New System.Drawing.Size(307, 85)
        Me.txtTrayNo.TabIndex = 127
        '
        'rtpTime
        '
        Me.rtpTime.Location = New System.Drawing.Point(80, 13)
        Me.rtpTime.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.rtpTime.MinValue = New Date(CType(0, Long))
        Me.rtpTime.Name = "rtpTime"
        Me.rtpTime.Size = New System.Drawing.Size(159, 20)
        Me.rtpTime.TabIndex = 125
        Me.rtpTime.TabStop = False
        Me.rtpTime.Value = New Date(2021, 3, 16, 7, 0, 0, 0)
        '
        'RadLabel19
        '
        Me.RadLabel19.BackColor = System.Drawing.Color.LightGray
        Me.RadLabel19.Location = New System.Drawing.Point(26, 13)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(33, 18)
        Me.RadLabel19.TabIndex = 126
        Me.RadLabel19.Text = "Time:"
        '
        'txtRMID
        '
        Me.txtRMID.Location = New System.Drawing.Point(255, 11)
        Me.txtRMID.Name = "txtRMID"
        Me.txtRMID.Size = New System.Drawing.Size(51, 20)
        Me.txtRMID.TabIndex = 86
        Me.txtRMID.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(0, 148)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 24)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        '
        'FrmBSSEditRMWorkProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 178)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.z)
        Me.Name = "FrmBSSEditRMWorkProcess"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update RM work process"
        CType(Me.z, System.ComponentModel.ISupportInitialize).EndInit()
        Me.z.ResumeLayout(False)
        Me.z.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrayNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtpTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRMID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents z As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTrayNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rtpTime As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtRMID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
End Class

