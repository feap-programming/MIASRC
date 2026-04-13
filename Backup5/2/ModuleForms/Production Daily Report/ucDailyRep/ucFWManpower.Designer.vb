<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFWManpower
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadSpinEditor2 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadSpinEditor3 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadSpinEditor4 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadGridView3 = New Telerik.WinControls.UI.RadGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView3.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FW-"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.DropDownAnimationEnabled = True
        Me.RadDropDownList1.Location = New System.Drawing.Point(42, 18)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(125, 20)
        Me.RadDropDownList1.TabIndex = 1
        Me.RadDropDownList1.Text = "RadDropDownList1"
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(17, 48)
        '
        '
        '
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(449, 134)
        Me.RadGridView1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(483, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Operation Time (Min):"
        '
        'RadSpinEditor1
        '
        Me.RadSpinEditor1.Location = New System.Drawing.Point(613, 44)
        Me.RadSpinEditor1.Name = "RadSpinEditor1"
        Me.RadSpinEditor1.Size = New System.Drawing.Size(322, 20)
        Me.RadSpinEditor1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(483, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Interruption Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(517, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Start-up, 5's, Hotto, Break:"
        '
        'RadSpinEditor2
        '
        Me.RadSpinEditor2.Location = New System.Drawing.Point(675, 100)
        Me.RadSpinEditor2.Name = "RadSpinEditor2"
        Me.RadSpinEditor2.Size = New System.Drawing.Size(260, 20)
        Me.RadSpinEditor2.TabIndex = 7
        '
        'RadSpinEditor3
        '
        Me.RadSpinEditor3.Location = New System.Drawing.Point(630, 128)
        Me.RadSpinEditor3.Name = "RadSpinEditor3"
        Me.RadSpinEditor3.Size = New System.Drawing.Size(305, 20)
        Me.RadSpinEditor3.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(517, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Plannes Downtime:"
        '
        'RadSpinEditor4
        '
        Me.RadSpinEditor4.Location = New System.Drawing.Point(648, 156)
        Me.RadSpinEditor4.Name = "RadSpinEditor4"
        Me.RadSpinEditor4.Size = New System.Drawing.Size(287, 20)
        Me.RadSpinEditor4.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(517, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Unplanned Downtime:"
        '
        'RadGridView3
        '
        Me.RadGridView3.Location = New System.Drawing.Point(17, 218)
        '
        '
        '
        Me.RadGridView3.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridView3.Name = "RadGridView3"
        Me.RadGridView3.Size = New System.Drawing.Size(918, 240)
        Me.RadGridView3.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Defectrive Detail: "
        '
        'ucFWManpower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadGridView3)
        Me.Controls.Add(Me.RadSpinEditor4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RadSpinEditor3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadSpinEditor2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadSpinEditor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucFWManpower"
        Me.Size = New System.Drawing.Size(952, 928)
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView3.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents RadSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadSpinEditor2 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadSpinEditor3 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents Label5 As Label
    Friend WithEvents RadSpinEditor4 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents Label6 As Label
    Friend WithEvents RadGridView3 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label8 As Label
End Class
