<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditInventoryTransfer
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
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition8 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.txtId = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txtRemarks = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbFrom = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.mcbTo = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnContinue = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.seTransferedQty = New Telerik.WinControls.UI.RadSpinEditor()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.mcbShift = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbFrom.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTransferedQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbShift.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(41, 192)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(26, 20)
        Me.txtId.TabIndex = 0
        Me.txtId.Visible = False
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.mcbShift)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.txtRemarks)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.mcbFrom)
        Me.RadPanel1.Controls.Add(Me.mcbTo)
        Me.RadPanel1.Controls.Add(Me.btnCancel)
        Me.RadPanel1.Controls.Add(Me.btnContinue)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.seTransferedQty)
        Me.RadPanel1.Controls.Add(Me.mcbItemCode)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.txtId)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(456, 237)
        Me.RadPanel1.TabIndex = 4
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(90, 144)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel5.TabIndex = 40
        Me.RadLabel5.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(147, 142)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(261, 20)
        Me.txtRemarks.TabIndex = 5
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(31, 40)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(110, 18)
        Me.RadLabel4.TabIndex = 38
        Me.RadLabel4.Text = "Warehouse Code To:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(18, 14)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(123, 18)
        Me.RadLabel3.TabIndex = 37
        Me.RadLabel3.Text = "Warehouse Code From:"
        '
        'mcbFrom
        '
        '
        'mcbFrom.NestedRadGridView
        '
        Me.mcbFrom.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbFrom.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbFrom.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbFrom.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbFrom.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbFrom.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbFrom.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbFrom.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbFrom.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbFrom.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.mcbFrom.EditorControl.Name = "NestedRadGridView"
        Me.mcbFrom.EditorControl.ReadOnly = True
        Me.mcbFrom.EditorControl.ShowGroupPanel = False
        Me.mcbFrom.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbFrom.EditorControl.TabIndex = 0
        Me.mcbFrom.Location = New System.Drawing.Point(147, 12)
        Me.mcbFrom.Name = "mcbFrom"
        Me.mcbFrom.NullText = "--Select Warehouse Code From--"
        Me.mcbFrom.Size = New System.Drawing.Size(261, 20)
        Me.mcbFrom.TabIndex = 0
        Me.mcbFrom.TabStop = False
        '
        'mcbTo
        '
        '
        'mcbTo.NestedRadGridView
        '
        Me.mcbTo.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbTo.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbTo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbTo.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbTo.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbTo.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbTo.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbTo.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbTo.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbTo.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition7
        Me.mcbTo.EditorControl.Name = "NestedRadGridView"
        Me.mcbTo.EditorControl.ReadOnly = True
        Me.mcbTo.EditorControl.ShowGroupPanel = False
        Me.mcbTo.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbTo.EditorControl.TabIndex = 0
        Me.mcbTo.Location = New System.Drawing.Point(147, 38)
        Me.mcbTo.Name = "mcbTo"
        Me.mcbTo.NullText = "--Select Warehouse Code To--"
        Me.mcbTo.Size = New System.Drawing.Size(261, 20)
        Me.mcbTo.TabIndex = 1
        Me.mcbTo.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(245, 190)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 24)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(120, 190)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(110, 24)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "Continue"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(33, 118)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(108, 18)
        Me.RadLabel2.TabIndex = 4
        Me.RadLabel2.Text = "Transfered Quantity:"
        '
        'seTransferedQty
        '
        Me.seTransferedQty.DecimalPlaces = 2
        Me.seTransferedQty.Location = New System.Drawing.Point(147, 116)
        Me.seTransferedQty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.seTransferedQty.Name = "seTransferedQty"
        Me.seTransferedQty.ShowUpDownButtons = False
        Me.seTransferedQty.Size = New System.Drawing.Size(131, 20)
        Me.seTransferedQty.TabIndex = 4
        Me.seTransferedQty.ThousandsSeparator = True
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition8
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(147, 90)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.NullText = "--Select Item Code--"
        Me.mcbItemCode.Size = New System.Drawing.Size(131, 20)
        Me.mcbItemCode.TabIndex = 3
        Me.mcbItemCode.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(80, 92)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Item Code:"
        '
        'mcbShift
        '
        '
        'mcbShift.NestedRadGridView
        '
        Me.mcbShift.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcbShift.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbShift.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcbShift.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcbShift.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcbShift.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcbShift.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcbShift.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcbShift.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcbShift.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.mcbShift.EditorControl.Name = "NestedRadGridView"
        Me.mcbShift.EditorControl.ReadOnly = True
        Me.mcbShift.EditorControl.ShowGroupPanel = False
        Me.mcbShift.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbShift.EditorControl.TabIndex = 0
        Me.mcbShift.Location = New System.Drawing.Point(147, 64)
        Me.mcbShift.Name = "mcbShift"
        Me.mcbShift.NullText = "--Select Shift--"
        Me.mcbShift.Size = New System.Drawing.Size(261, 20)
        Me.mcbShift.TabIndex = 2
        Me.mcbShift.TabStop = False
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(110, 65)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel6.TabIndex = 42
        Me.RadLabel6.Text = "Shift:"
        '
        'frmEditInventoryTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 237)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(464, 267)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(464, 267)
        Me.Name = "frmEditInventoryTransfer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Inventory Transfer"
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTransferedQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbShift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtId As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seTransferedQty As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnContinue As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbFrom As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents mcbTo As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtRemarks As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbShift As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
End Class

