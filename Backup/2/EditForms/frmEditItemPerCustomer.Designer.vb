<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditItemPerCustomer
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.txtPartLevel = New Telerik.WinControls.UI.RadTextBox()
        Me.txtModelCode = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCustomerPartNo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.seStdQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.mcbCustomer = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtId = New Telerik.WinControls.UI.RadTextBox()
        Me.object_234e92e9_d341_40bc_837c_9f733763479b = New Telerik.WinControls.RootRadElement()
        CType(Me.txtPartLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerPartNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seStdQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPartLevel
        '
        Me.txtPartLevel.Location = New System.Drawing.Point(138, 152)
        Me.txtPartLevel.Name = "txtPartLevel"
        Me.txtPartLevel.Size = New System.Drawing.Size(126, 20)
        Me.txtPartLevel.TabIndex = 23
        '
        'txtModelCode
        '
        Me.txtModelCode.Location = New System.Drawing.Point(138, 101)
        Me.txtModelCode.Name = "txtModelCode"
        Me.txtModelCode.Size = New System.Drawing.Size(126, 20)
        Me.txtModelCode.TabIndex = 21
        '
        'txtCustomerPartNo
        '
        Me.txtCustomerPartNo.Location = New System.Drawing.Point(138, 23)
        Me.txtCustomerPartNo.Name = "txtCustomerPartNo"
        Me.txtCustomerPartNo.Size = New System.Drawing.Size(245, 20)
        Me.txtCustomerPartNo.TabIndex = 18
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Location = New System.Drawing.Point(71, 77)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel6.TabIndex = 29
        Me.RadLabel6.Text = "Item Code:"
        '
        'mcbItemCode
        '
        '
        'mcbItemCode.NestedRadGridView
        '
        Me.mcbItemCode.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbItemCode.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbItemCode.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbItemCode.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbItemCode.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbItemCode.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbItemCode.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(138, 75)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(245, 20)
        Me.mcbItemCode.TabIndex = 20
        Me.mcbItemCode.TabStop = False
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Location = New System.Drawing.Point(75, 154)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel5.TabIndex = 28
        Me.RadLabel5.Text = "Part Level:"
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Location = New System.Drawing.Point(33, 128)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(100, 18)
        Me.RadLabel4.TabIndex = 27
        Me.RadLabel4.Text = "Standard Quantity:"
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Location = New System.Drawing.Point(62, 102)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel3.TabIndex = 26
        Me.RadLabel3.Text = "Model Code:"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Location = New System.Drawing.Point(75, 51)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel2.TabIndex = 25
        Me.RadLabel2.Text = "Customer:"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Location = New System.Drawing.Point(31, 25)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(101, 18)
        Me.RadLabel1.TabIndex = 24
        Me.RadLabel1.Text = "Customer Part No.:"
        '
        'seStdQty
        '
        Me.seStdQty.Location = New System.Drawing.Point(139, 126)
        Me.seStdQty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seStdQty.Name = "seStdQty"
        Me.seStdQty.ShowUpDownButtons = False
        Me.seStdQty.Size = New System.Drawing.Size(125, 20)
        Me.seStdQty.TabIndex = 22
        '
        'mcbCustomer
        '
        '
        'mcbCustomer.NestedRadGridView
        '
        Me.mcbCustomer.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbCustomer.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbCustomer.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbCustomer.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbCustomer.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbCustomer.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbCustomer.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbCustomer.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbCustomer.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbCustomer.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.mcbCustomer.EditorControl.Name = "NestedRadGridView"
        Me.mcbCustomer.EditorControl.ReadOnly = True
        Me.mcbCustomer.EditorControl.ShowGroupPanel = False
        Me.mcbCustomer.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbCustomer.EditorControl.TabIndex = 0
        Me.mcbCustomer.Location = New System.Drawing.Point(138, 49)
        Me.mcbCustomer.Name = "mcbCustomer"
        Me.mcbCustomer.Size = New System.Drawing.Size(245, 20)
        Me.mcbCustomer.TabIndex = 19
        Me.mcbCustomer.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(223, 207)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(98, 207)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Update"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.txtId)
        Me.RadPanel1.Controls.Add(Me.txtCustomerPartNo)
        Me.RadPanel1.Controls.Add(Me.btnCancel)
        Me.RadPanel1.Controls.Add(Me.mcbCustomer)
        Me.RadPanel1.Controls.Add(Me.btnUpdate)
        Me.RadPanel1.Controls.Add(Me.seStdQty)
        Me.RadPanel1.Controls.Add(Me.txtPartLevel)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.txtModelCode)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.mcbItemCode)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(424, 265)
        Me.RadPanel1.TabIndex = 32
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(386, 242)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(26, 20)
        Me.txtId.TabIndex = 32
        Me.txtId.Visible = False
        '
        'object_234e92e9_d341_40bc_837c_9f733763479b
        '
        Me.object_234e92e9_d341_40bc_837c_9f733763479b.Name = "object_234e92e9_d341_40bc_837c_9f733763479b"
        Me.object_234e92e9_d341_40bc_837c_9f733763479b.StretchHorizontally = True
        Me.object_234e92e9_d341_40bc_837c_9f733763479b.StretchVertically = True
        '
        'FrmEditItemPerCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 265)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEditItemPerCustomer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Item Per Customer"
        CType(Me.txtPartLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerPartNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seStdQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtPartLevel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtModelCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCustomerPartNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seStdQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents mcbCustomer As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents object_234e92e9_d341_40bc_837c_9f733763479b As Telerik.WinControls.RootRadElement
    Friend WithEvents txtId As Telerik.WinControls.UI.RadTextBox
End Class

