<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTest
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.dockMain = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadGridView2 = New Telerik.WinControls.UI.RadGridView()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        CType(Me.dockMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockMain.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView2.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dockMain
        '
        Me.dockMain.Controls.Add(Me.ToolTabStrip1)
        Me.dockMain.Controls.Add(Me.DocumentContainer1)
        Me.dockMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockMain.IsCleanUpTarget = True
        Me.dockMain.Location = New System.Drawing.Point(0, 0)
        Me.dockMain.MainDocumentContainer = Me.DocumentContainer1
        Me.dockMain.MainDocumentContainerVisible = False
        Me.dockMain.Name = "dockMain"
        '
        '
        '
        Me.dockMain.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.dockMain.Size = New System.Drawing.Size(897, 1262)
        Me.dockMain.TabIndex = 0
        Me.dockMain.TabStop = False
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Collapsed = True
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(527, 20)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "RadButton1"
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(223, 198)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(240, 150)
        Me.RadGridView1.TabIndex = 0
        '
        'RadGridView2
        '
        Me.RadGridView2.Location = New System.Drawing.Point(290, 174)
        '
        '
        '
        Me.RadGridView2.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.RadGridView2.Name = "RadGridView2"
        Me.RadGridView2.Size = New System.Drawing.Size(240, 150)
        Me.RadGridView2.TabIndex = 0
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(885, 1226)
        Me.ToolWindow1.Text = "ToolWindow1"
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(887, 1252)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ucTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.dockMain)
        Me.Name = "ucTest"
        Me.Size = New System.Drawing.Size(897, 1262)
        CType(Me.dockMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockMain.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView2.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dockMain As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGridView2 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
End Class
