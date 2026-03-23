<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClearDialog
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
        Me.btnClearOkOnly = New Telerik.WinControls.UI.RadButton()
        Me.btnClearAll = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtResult = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.btnClearOkOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClearAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClearOkOnly
        '
        Me.btnClearOkOnly.Location = New System.Drawing.Point(12, 37)
        Me.btnClearOkOnly.Name = "btnClearOkOnly"
        Me.btnClearOkOnly.Size = New System.Drawing.Size(84, 24)
        Me.btnClearOkOnly.TabIndex = 0
        Me.btnClearOkOnly.Text = """OK"" Only"
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(102, 37)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(84, 24)
        Me.btnClearAll.TabIndex = 1
        Me.btnClearAll.Text = "All"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(192, 37)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 24)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(23, 9)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(242, 18)
        Me.RadLabel1.TabIndex = 3
        Me.RadLabel1.Text = "Which items do you want to clear from the list?"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(121, 67)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(33, 20)
        Me.txtResult.TabIndex = 4
        Me.txtResult.Visible = False
        '
        'FrmClearDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(286, 68)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnClearOkOnly)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmClearDialog"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clear Items"
        CType(Me.btnClearOkOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClearAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClearOkOnly As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClearAll As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtResult As Telerik.WinControls.UI.RadTextBox
End Class

