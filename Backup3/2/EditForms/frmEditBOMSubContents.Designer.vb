<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditBOMSubContents
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
        Me.txtBOMTitle = New Telerik.WinControls.UI.RadTextBox()
        Me.txtSubContentLabel = New Telerik.WinControls.UI.RadTextBox()
        Me.sePageNo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnContinue = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.txtBOMTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubContentLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBOMTitle
        '
        Me.txtBOMTitle.Enabled = False
        Me.txtBOMTitle.Location = New System.Drawing.Point(116, 12)
        Me.txtBOMTitle.Name = "txtBOMTitle"
        Me.txtBOMTitle.Size = New System.Drawing.Size(457, 20)
        Me.txtBOMTitle.TabIndex = 0
        '
        'txtSubContentLabel
        '
        Me.txtSubContentLabel.Location = New System.Drawing.Point(116, 38)
        Me.txtSubContentLabel.Name = "txtSubContentLabel"
        Me.txtSubContentLabel.Size = New System.Drawing.Size(457, 20)
        Me.txtSubContentLabel.TabIndex = 1
        '
        'sePageNo
        '
        Me.sePageNo.Location = New System.Drawing.Point(116, 64)
        Me.sePageNo.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.sePageNo.Name = "sePageNo"
        Me.sePageNo.ShowUpDownButtons = False
        Me.sePageNo.Size = New System.Drawing.Size(100, 20)
        Me.sePageNo.TabIndex = 2
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(52, 14)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(58, 18)
        Me.RadLabel1.TabIndex = 3
        Me.RadLabel1.Text = "BOM Title:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(10, 40)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(100, 18)
        Me.RadLabel2.TabIndex = 4
        Me.RadLabel2.Text = "Sub Content Label:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(52, 66)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(54, 18)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Page No.:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(306, 102)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(181, 102)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(110, 24)
        Me.btnContinue.TabIndex = 36
        Me.btnContinue.Text = "Continue"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(461, 106)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(19, 20)
        Me.txtID.TabIndex = 35
        Me.txtID.Visible = False
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtBOMTitle)
        Me.RadPanel1.Controls.Add(Me.btnCancel)
        Me.RadPanel1.Controls.Add(Me.txtSubContentLabel)
        Me.RadPanel1.Controls.Add(Me.btnContinue)
        Me.RadPanel1.Controls.Add(Me.sePageNo)
        Me.RadPanel1.Controls.Add(Me.txtID)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(590, 139)
        Me.RadPanel1.TabIndex = 38
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'FrmEditBOMSubContents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 139)
        Me.Controls.Add(Me.RadPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEditBOMSubContents"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit BOM Sub Content"
        CType(Me.txtBOMTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubContentLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBOMTitle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtSubContentLabel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents sePageNo As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnContinue As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
End Class

