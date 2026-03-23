<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBOMDetails
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.sePageNo = New Telerik.WinControls.UI.RadSpinEditor()
        Me.btnAddForm = New Telerik.WinControls.UI.RadButton()
        Me.gvForms = New Telerik.WinControls.UI.RadGridView()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRecForm = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtFormName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.mcbItemCode = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.btnAddFG = New Telerik.WinControls.UI.RadButton()
        Me.gvItemCode = New Telerik.WinControls.UI.RadGridView()
        Me.RadStatusStrip2 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.leCountRecFG = New Telerik.WinControls.UI.RadLabelElement()
        Me.lblItemCode = New Telerik.WinControls.UI.RadLabel()
        Me.bwLoadData = New System.ComponentModel.BackgroundWorker()
        Me.txtId = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePageNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvForms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvForms.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFormName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddFG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemCode.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.Silver
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.sePageNo)
        Me.RadPanel1.Controls.Add(Me.btnAddForm)
        Me.RadPanel1.Controls.Add(Me.gvForms)
        Me.RadPanel1.Controls.Add(Me.RadStatusStrip1)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.txtFormName)
        Me.RadPanel1.Location = New System.Drawing.Point(1, 4)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(588, 511)
        Me.RadPanel1.TabIndex = 0
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(71, 43)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(54, 18)
        Me.RadLabel2.TabIndex = 6
        Me.RadLabel2.Text = "Page No.:"
        '
        'sePageNo
        '
        Me.sePageNo.Location = New System.Drawing.Point(131, 41)
        Me.sePageNo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sePageNo.Name = "sePageNo"
        Me.sePageNo.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.sePageNo.ShowUpDownButtons = False
        Me.sePageNo.Size = New System.Drawing.Size(242, 20)
        Me.sePageNo.TabIndex = 1
        Me.sePageNo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAddForm
        '
        Me.btnAddForm.Location = New System.Drawing.Point(263, 67)
        Me.btnAddForm.Name = "btnAddForm"
        Me.btnAddForm.Size = New System.Drawing.Size(110, 24)
        Me.btnAddForm.TabIndex = 2
        Me.btnAddForm.Text = "Add"
        '
        'gvForms
        '
        Me.gvForms.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvForms.Location = New System.Drawing.Point(0, 110)
        '
        '
        '
        Me.gvForms.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gvForms.Name = "gvForms"
        Me.gvForms.Size = New System.Drawing.Size(588, 375)
        Me.gvForms.TabIndex = 1
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.leCountRecForm})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 485)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(588, 26)
        Me.RadStatusStrip1.TabIndex = 3
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Records Found:"
        Me.RadLabelElement1.TextWrap = True
        '
        'leCountRecForm
        '
        Me.leCountRecForm.Name = "leCountRecForm"
        Me.RadStatusStrip1.SetSpring(Me.leCountRecForm, False)
        Me.leCountRecForm.Text = "0"
        Me.leCountRecForm.TextWrap = True
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(57, 17)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(68, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Form Name:"
        '
        'txtFormName
        '
        Me.txtFormName.Location = New System.Drawing.Point(131, 15)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.Size = New System.Drawing.Size(242, 20)
        Me.txtFormName.TabIndex = 0
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.Silver
        Me.RadPanel2.Controls.Add(Me.mcbItemCode)
        Me.RadPanel2.Controls.Add(Me.btnAddFG)
        Me.RadPanel2.Controls.Add(Me.gvItemCode)
        Me.RadPanel2.Controls.Add(Me.RadStatusStrip2)
        Me.RadPanel2.Controls.Add(Me.lblItemCode)
        Me.RadPanel2.Location = New System.Drawing.Point(595, 4)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(495, 511)
        Me.RadPanel2.TabIndex = 1
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
        Me.mcbItemCode.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.mcbItemCode.EditorControl.Name = "NestedRadGridView"
        Me.mcbItemCode.EditorControl.ReadOnly = True
        Me.mcbItemCode.EditorControl.ShowGroupPanel = False
        Me.mcbItemCode.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcbItemCode.EditorControl.TabIndex = 0
        Me.mcbItemCode.Location = New System.Drawing.Point(97, 15)
        Me.mcbItemCode.Name = "mcbItemCode"
        Me.mcbItemCode.Size = New System.Drawing.Size(288, 20)
        Me.mcbItemCode.TabIndex = 0
        Me.mcbItemCode.TabStop = False
        '
        'btnAddFG
        '
        Me.btnAddFG.Location = New System.Drawing.Point(275, 67)
        Me.btnAddFG.Name = "btnAddFG"
        Me.btnAddFG.Size = New System.Drawing.Size(110, 24)
        Me.btnAddFG.TabIndex = 1
        Me.btnAddFG.Text = "Add"
        '
        'gvItemCode
        '
        Me.gvItemCode.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvItemCode.Location = New System.Drawing.Point(0, 110)
        '
        '
        '
        Me.gvItemCode.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gvItemCode.Name = "gvItemCode"
        Me.gvItemCode.Size = New System.Drawing.Size(495, 375)
        Me.gvItemCode.TabIndex = 1
        '
        'RadStatusStrip2
        '
        Me.RadStatusStrip2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement2, Me.leCountRecFG})
        Me.RadStatusStrip2.Location = New System.Drawing.Point(0, 485)
        Me.RadStatusStrip2.Name = "RadStatusStrip2"
        Me.RadStatusStrip2.Size = New System.Drawing.Size(495, 26)
        Me.RadStatusStrip2.TabIndex = 3
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip2.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = "Records Found:"
        Me.RadLabelElement2.TextWrap = True
        Me.RadLabelElement2.UseCompatibleTextRendering = False
        '
        'leCountRecFG
        '
        Me.leCountRecFG.Name = "leCountRecFG"
        Me.RadStatusStrip2.SetSpring(Me.leCountRecFG, False)
        Me.leCountRecFG.Text = "0"
        Me.leCountRecFG.TextWrap = True
        Me.leCountRecFG.UseCompatibleTextRendering = False
        '
        'lblItemCode
        '
        Me.lblItemCode.Location = New System.Drawing.Point(30, 17)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(61, 18)
        Me.lblItemCode.TabIndex = 2
        Me.lblItemCode.Text = "Item Code:"
        '
        'bwLoadData
        '
        Me.bwLoadData.WorkerReportsProgress = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(585, 272)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(10, 20)
        Me.txtId.TabIndex = 1
        Me.txtId.Visible = False
        '
        'FrmBOMDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 516)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmBOMDetails"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOM Details"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePageNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvForms.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvForms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFormName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        Me.RadPanel2.PerformLayout()
        CType(Me.mcbItemCode.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcbItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddFG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemCode.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtFormName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents gvForms As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRecForm As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents btnAddForm As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAddFG As Telerik.WinControls.UI.RadButton
    Friend WithEvents gvItemCode As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadStatusStrip2 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents leCountRecFG As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents lblItemCode As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mcbItemCode As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents bwLoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtId As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents sePageNo As Telerik.WinControls.UI.RadSpinEditor
End Class

