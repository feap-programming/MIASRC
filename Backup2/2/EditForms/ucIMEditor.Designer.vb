<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucIMEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.gvData = New Telerik.WinControls.UI.RadGridView()
        Me.Windows7Theme1 = New Telerik.WinControls.Themes.Windows7Theme()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvData
        '
        Me.gvData.Dock = System.Windows.Forms.DockStyle.Top
        Me.gvData.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.gvData.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect
        Me.gvData.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvData.Name = "gvData"
        Me.gvData.Size = New System.Drawing.Size(1075, 454)
        Me.gvData.TabIndex = 2
        Me.gvData.ThemeName = "Windows8"
        '
        'ucIMEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.Controls.Add(Me.gvData)
        Me.Name = "ucIMEditor"
        Me.Size = New System.Drawing.Size(1075, 576)
        CType(Me.gvData.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Windows7Theme1 As Telerik.WinControls.Themes.Windows7Theme
    Friend WithEvents gvData As Telerik.WinControls.UI.RadGridView
End Class
