<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCTEditor
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.gvSection4 = New Telerik.WinControls.UI.RadGridView()
        Me.gvSection5 = New Telerik.WinControls.UI.RadGridView()
        Me.gvSection1 = New Telerik.WinControls.UI.RadGridView()
        Me.txtId = New Telerik.WinControls.UI.RadTextBox()
        Me.gvSection2 = New Telerik.WinControls.UI.RadGridView()
        Me.gvSection3 = New Telerik.WinControls.UI.RadGridView()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.bwLoadDataS1 = New System.ComponentModel.BackgroundWorker()
        Me.bwLoadDataS2 = New System.ComponentModel.BackgroundWorker()
        Me.bwLoadDataS3 = New System.ComponentModel.BackgroundWorker()
        Me.CrystalDarkTheme1 = New Telerik.WinControls.Themes.CrystalDarkTheme()
        Me.bwLoadData5 = New System.ComponentModel.BackgroundWorker()
        Me.bwLoadData4 = New System.ComponentModel.BackgroundWorker()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.gvSection4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection4.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection5.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gvSection1.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection2.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSection3.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvSection4
        '
        Me.gvSection4.AutoSize = True
        Me.gvSection4.Dock = System.Windows.Forms.DockStyle.Top
        Me.gvSection4.Location = New System.Drawing.Point(0, 3)
        '
        '
        '
        Me.gvSection4.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvSection4.Name = "gvSection4"
        Me.gvSection4.Size = New System.Drawing.Size(1682, 3)
        Me.gvSection4.TabIndex = 5
        Me.gvSection4.ThemeName = "Windows8"
        '
        'gvSection5
        '
        Me.gvSection5.AutoSize = True
        Me.gvSection5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvSection5.Location = New System.Drawing.Point(0, 6)
        '
        '
        '
        Me.gvSection5.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gvSection5.Name = "gvSection5"
        Me.gvSection5.Size = New System.Drawing.Size(1682, 1496)
        Me.gvSection5.TabIndex = 4
        Me.gvSection5.ThemeName = "Windows8"
        '
        'gvSection1
        '
        Me.gvSection1.AutoSize = True
        Me.gvSection1.Controls.Add(Me.txtId)
        Me.gvSection1.Dock = System.Windows.Forms.DockStyle.Top
        Me.gvSection1.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.gvSection1.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gvSection1.Name = "gvSection1"
        Me.gvSection1.Size = New System.Drawing.Size(2, 3)
        Me.gvSection1.TabIndex = 1
        Me.gvSection1.ThemeName = "Windows8"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(237, 110)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(19, 20)
        Me.txtId.TabIndex = 1
        Me.txtId.Visible = False
        '
        'gvSection2
        '
        Me.gvSection2.AutoSize = True
        Me.gvSection2.Dock = System.Windows.Forms.DockStyle.Left
        Me.gvSection2.Location = New System.Drawing.Point(0, 3)
        '
        '
        '
        Me.gvSection2.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.gvSection2.Name = "gvSection2"
        Me.gvSection2.Size = New System.Drawing.Size(2, 3)
        Me.gvSection2.TabIndex = 2
        Me.gvSection2.ThemeName = "Windows8"
        '
        'gvSection3
        '
        Me.gvSection3.AutoSize = True
        Me.gvSection3.Dock = System.Windows.Forms.DockStyle.Top
        Me.gvSection3.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.gvSection3.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.gvSection3.Name = "gvSection3"
        Me.gvSection3.Size = New System.Drawing.Size(1682, 3)
        Me.gvSection3.TabIndex = 3
        Me.gvSection3.ThemeName = "Windows8"
        '
        'bwLoadDataS1
        '
        Me.bwLoadDataS1.WorkerReportsProgress = True
        '
        'bwLoadDataS2
        '
        Me.bwLoadDataS2.WorkerReportsProgress = True
        '
        'bwLoadDataS3
        '
        Me.bwLoadDataS3.WorkerReportsProgress = True
        '
        'bwLoadData5
        '
        '
        'bwLoadData4
        '
        '
        'RadPanel1
        '
        Me.RadPanel1.AutoScroll = True
        Me.RadPanel1.AutoSize = True
        Me.RadPanel1.Controls.Add(Me.gvSection5)
        Me.RadPanel1.Controls.Add(Me.gvSection4)
        Me.RadPanel1.Controls.Add(Me.gvSection3)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(2, 3)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1682, 1502)
        Me.RadPanel1.TabIndex = 6
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'ucCTEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.gvSection2)
        Me.Controls.Add(Me.gvSection1)
        Me.Name = "ucCTEditor"
        Me.Size = New System.Drawing.Size(1684, 1505)
        CType(Me.gvSection4.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection5.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gvSection1.ResumeLayout(False)
        Me.gvSection1.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection2.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection3.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSection3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvSection3 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents gvSection1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents gvSection2 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents bwLoadDataS1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoadDataS2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoadDataS3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CrystalDarkTheme1 As Telerik.WinControls.Themes.CrystalDarkTheme
    Friend WithEvents txtId As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents gvSection5 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents bwLoadData5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwLoadData4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents gvSection4 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
End Class
