<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateCustomerDemand
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdateCustomerDemand))
        Me.panel = New Telerik.WinControls.UI.RadPanel()
        Me.ddlModel = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.dtpDate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.seLatestDemand = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seForecast = New Telerik.WinControls.UI.RadSpinEditor()
        Me.seBudget = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCustomer = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.txtID = New Telerik.WinControls.UI.RadTextBox()
        Me.txtFGModel = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.ddlModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlModel.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seLatestDemand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFGModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Silver
        Me.panel.Controls.Add(Me.txtFGModel)
        Me.panel.Controls.Add(Me.RadLabel6)
        Me.panel.Controls.Add(Me.ddlModel)
        Me.panel.Controls.Add(Me.dtpDate)
        Me.panel.Controls.Add(Me.RadLabel4)
        Me.panel.Controls.Add(Me.seLatestDemand)
        Me.panel.Controls.Add(Me.seForecast)
        Me.panel.Controls.Add(Me.seBudget)
        Me.panel.Controls.Add(Me.RadLabel2)
        Me.panel.Controls.Add(Me.RadLabel1)
        Me.panel.Controls.Add(Me.RadLabel3)
        Me.panel.Controls.Add(Me.txtDescription)
        Me.panel.Controls.Add(Me.RadLabel5)
        Me.panel.Controls.Add(Me.txtCustomer)
        Me.panel.Controls.Add(Me.RadLabel12)
        Me.panel.Controls.Add(Me.RadLabel15)
        Me.panel.Controls.Add(Me.btnUpdate)
        Me.panel.Controls.Add(Me.txtID)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(510, 167)
        Me.panel.TabIndex = 2
        Me.panel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.panel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'ddlModel
        '
        '
        'ddlModel.NestedRadGridView
        '
        Me.ddlModel.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ddlModel.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlModel.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ddlModel.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ddlModel.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ddlModel.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ddlModel.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ddlModel.EditorControl.MasterTemplate.EnableGrouping = False
        Me.ddlModel.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ddlModel.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.ddlModel.EditorControl.Name = "NestedRadGridView"
        Me.ddlModel.EditorControl.ReadOnly = True
        Me.ddlModel.EditorControl.ShowGroupPanel = False
        Me.ddlModel.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ddlModel.EditorControl.TabIndex = 0
        Me.ddlModel.Location = New System.Drawing.Point(92, 14)
        Me.ddlModel.Name = "ddlModel"
        Me.ddlModel.Size = New System.Drawing.Size(141, 20)
        Me.ddlModel.TabIndex = 1
        Me.ddlModel.TabStop = False
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(354, 14)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(141, 20)
        Me.dtpDate.TabIndex = 4
        Me.dtpDate.TabStop = False
        Me.dtpDate.Text = "Tuesday, December 4, 2018"
        Me.dtpDate.Value = New Date(2018, 12, 4, 13, 33, 4, 90)
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(265, 14)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(30, 18)
        Me.RadLabel4.TabIndex = 55
        Me.RadLabel4.Text = "Date"
        '
        'seLatestDemand
        '
        Me.seLatestDemand.DecimalPlaces = 6
        Me.seLatestDemand.Location = New System.Drawing.Point(354, 92)
        Me.seLatestDemand.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seLatestDemand.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seLatestDemand.Name = "seLatestDemand"
        Me.seLatestDemand.ShowUpDownButtons = False
        Me.seLatestDemand.Size = New System.Drawing.Size(143, 20)
        Me.seLatestDemand.TabIndex = 7
        '
        'seForecast
        '
        Me.seForecast.DecimalPlaces = 6
        Me.seForecast.Location = New System.Drawing.Point(354, 66)
        Me.seForecast.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seForecast.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seForecast.Name = "seForecast"
        Me.seForecast.ShowUpDownButtons = False
        Me.seForecast.Size = New System.Drawing.Size(143, 20)
        Me.seForecast.TabIndex = 6
        '
        'seBudget
        '
        Me.seBudget.DecimalPlaces = 6
        Me.seBudget.Location = New System.Drawing.Point(354, 40)
        Me.seBudget.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.seBudget.Minimum = New Decimal(New Integer() {999999, 0, 0, -2147483648})
        Me.seBudget.Name = "seBudget"
        Me.seBudget.ShowUpDownButtons = False
        Me.seBudget.Size = New System.Drawing.Size(143, 20)
        Me.seBudget.TabIndex = 5
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(265, 91)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(81, 18)
        Me.RadLabel2.TabIndex = 51
        Me.RadLabel2.Text = "Latest Demand"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(265, 66)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(48, 18)
        Me.RadLabel1.TabIndex = 50
        Me.RadLabel1.Text = "Forecast"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(265, 39)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(42, 18)
        Me.RadLabel3.TabIndex = 49
        Me.RadLabel3.Text = "Budget"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(92, 40)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        '
        '
        '
        Me.txtDescription.RootElement.StretchVertically = True
        Me.txtDescription.Size = New System.Drawing.Size(141, 46)
        Me.txtDescription.TabIndex = 2
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(13, 39)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(66, 18)
        Me.RadLabel5.TabIndex = 48
        Me.RadLabel5.Text = "Description:"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(92, 118)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(141, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'RadLabel12
        '
        Me.RadLabel12.Location = New System.Drawing.Point(13, 117)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel12.TabIndex = 48
        Me.RadLabel12.Text = "Customer:"
        '
        'RadLabel15
        '
        Me.RadLabel15.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel15.Location = New System.Drawing.Point(13, 14)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(41, 18)
        Me.RadLabel15.TabIndex = 47
        Me.RadLabel15.Text = "Model:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(387, 131)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(308, 135)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(51, 20)
        Me.txtID.TabIndex = 18
        Me.txtID.Visible = False
        '
        'txtFGModel
        '
        Me.txtFGModel.Location = New System.Drawing.Point(92, 92)
        Me.txtFGModel.Name = "txtFGModel"
        Me.txtFGModel.Size = New System.Drawing.Size(141, 20)
        Me.txtFGModel.TabIndex = 56
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(13, 92)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(60, 18)
        Me.RadLabel6.TabIndex = 57
        Me.RadLabel6.Text = "FG MODEL"
        '
        'FrmUpdateCustomerDemand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 167)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdateCustomerDemand"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPDATE CUSTOMER DEMAND"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.ddlModel.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlModel.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seLatestDemand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seForecast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seBudget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFGModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dtpDate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents seLatestDemand As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seForecast As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents seBudget As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCustomer As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ddlModel As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents txtDescription As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtFGModel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
End Class

